using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Posts the anti-bot challenge image to the user's own Discord webhook so they can answer it by hand,
// then a follow-up line when the game reports the outcome.
// Settings live in %LOCALAPPDATA%\Capybara_Bot\discord.json, not <hero>_Setting.ini: that file sits in
// the git tree and the webhook URL is a secret (anyone holding it can post to the channel).
internal sealed class DiscordNotifier
{
	private static readonly byte[] PngSignature = new byte[8] { 137, 80, 78, 71, 13, 10, 26, 10 };

	// Below this width the image is scaled up so the digits are readable on a phone.
	private const int MinImageWidth = 600;

	private const int MaxRemembered = 256;

	private readonly HttpClient http = new HttpClient { Timeout = TimeSpan.FromSeconds(15) };

	private readonly Action<string> log;

	private readonly object gate = new object();

	// session|challengeId -> hero name, for challenges already posted (the result line goes only to those)
	private readonly Dictionary<string, string> posted = new Dictionary<string, string>(StringComparer.Ordinal);

	// session|challengeId|sha256 — the agent can report the same image more than once
	private readonly HashSet<string> sentImages = new HashSet<string>(StringComparer.Ordinal);

	// Sends run one after another so a result line never lands before its image.
	private Task tail = Task.CompletedTask;

	private volatile bool enabled;

	private volatile string webhookUrl = string.Empty;

	static DiscordNotifier()
	{
		ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
	}

	internal DiscordNotifier(Action<string> log)
	{
		this.log = log ?? delegate
		{
		};
	}

	internal static string SettingsPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Capybara_Bot", "discord.json");

	internal bool Enabled => enabled;

	internal string WebhookUrl => webhookUrl;

	internal void Load()
	{
		try
		{
			if (File.Exists(SettingsPath))
			{
				JObject settings = JObject.Parse(File.ReadAllText(SettingsPath));
				webhookUrl = ((string?)settings["webhookUrl"] ?? string.Empty).Trim();
				enabled = (bool?)settings["enabled"] == true;
			}
		}
		catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException || ex is JsonException || ex is FormatException || ex is ArgumentException)
		{
			log("[Discord] settings not loaded: " + ex.Message);
		}
	}

	internal void Update(bool enabled, string webhookUrl)
	{
		webhookUrl = (webhookUrl ?? string.Empty).Trim();
		if (enabled == this.enabled && webhookUrl == this.webhookUrl)
		{
			return;
		}
		this.enabled = enabled;
		this.webhookUrl = webhookUrl;
		try
		{
			Directory.CreateDirectory(Path.GetDirectoryName(SettingsPath));
			File.WriteAllText(SettingsPath, new JObject
			{
				["enabled"] = enabled,
				["webhookUrl"] = webhookUrl
			}.ToString());
		}
		catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
		{
			log("[Discord] settings not saved: " + ex.Message);
		}
	}

	internal static bool IsWebhookUrl(string url)
	{
		if (!Uri.TryCreate(url, UriKind.Absolute, out Uri uri) || uri.Scheme != Uri.UriSchemeHttps)
		{
			return false;
		}
		string host = uri.Host.ToLowerInvariant();
		return (host == "discord.com" || host == "discordapp.com" || host.EndsWith(".discord.com", StringComparison.Ordinal)) && uri.AbsolutePath.StartsWith("/api/webhooks/", StringComparison.Ordinal);
	}

	// timeoutSec / attemptsLeft are what the game showed when the image arrived.
	internal void NotifyChallenge(string session, uint challengeId, int timeoutSec, int attemptsLeft, byte[] png, string heroName)
	{
		if (!enabled || !IsPng(png))
		{
			return;
		}
		string key = session + "|" + challengeId;
		string imageKey;
		using (SHA256 sha = SHA256.Create())
		{
			imageKey = key + "|" + Convert.ToBase64String(sha.ComputeHash(png));
		}
		lock (gate)
		{
			if (sentImages.Contains(imageKey))
			{
				return;
			}
			if (sentImages.Count >= MaxRemembered)
			{
				sentImages.Clear();
				posted.Clear();
			}
			sentImages.Add(imageKey);
			posted[key] = heroName;
		}
		long deadline = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + timeoutSec;
		string text = "⚠️ **เจอ captcha** — " + Who(heroName) + "\nหมดเวลา <t:" + deadline + ":R> · ตอบได้อีก " + attemptsLeft + " ครั้ง";
		Enqueue(text, Enlarge(png), "captcha_" + challengeId + ".png");
	}

	// result: 0 pass, 1 wrong (retry allowed), 2 failed, 3 expired — same codes as Class35.method_4
	internal void NotifyResult(string session, uint challengeId, int result, int attemptsLeft)
	{
		if (!enabled)
		{
			return;
		}
		string key = session + "|" + challengeId;
		string heroName;
		lock (gate)
		{
			if (!posted.TryGetValue(key, out heroName))
			{
				return;
			}
			if (result != 1)
			{
				posted.Remove(key);
			}
		}
		string text;
		switch (result)
		{
		case 0:
			text = "✅ ผ่านแล้ว";
			break;
		case 1:
			text = "❌ ตอบผิด เหลืออีก " + attemptsLeft + " ครั้ง";
			break;
		case 2:
			text = "⛔ ไม่ผ่าน (ตอบผิดครบจำนวนครั้ง)";
			break;
		case 3:
			text = "⌛ หมดเวลา ไม่ได้ตอบ";
			break;
		default:
			return;
		}
		Enqueue(text + " — " + Who(heroName), null, null);
	}

	// StuckGuard: once per stall, on its third try to get the character moving; NotifyUnstuck closes it.
	internal void NotifyStuck(string heroName, TimeSpan idle, string why)
	{
		if (!enabled)
		{
			return;
		}
		Enqueue("🧍 **ตัวละครค้าง** — " + Who(heroName) + "\nยืนเฉยมา " + (int)idle.TotalMinutes + " นาที · " + why, null, null);
	}

	internal void NotifyUnstuck(string heroName, TimeSpan idle)
	{
		if (!enabled)
		{
			return;
		}
		Enqueue("✅ กลับมาขยับแล้ว (ค้างไป " + (int)idle.TotalMinutes + " นาที) — " + Who(heroName), null, null);
	}

	// Sends straight away (ignores the enabled switch) and returns null on success, else the reason.
	// Attaches the newest captcha the bot has archived, if any, so the image upload is tested too.
	internal async Task<string> SendTestAsync(string url, string heroName)
	{
		url = (url ?? string.Empty).Trim();
		if (!IsWebhookUrl(url))
		{
			return "URL นี้ไม่ใช่ Discord webhook (ต้องขึ้นต้นด้วย https://discord.com/api/webhooks/)";
		}
		byte[] image = null;
		try
		{
			string archive = Class363.smethod_0();
			FileInfo newest = Directory.Exists(archive) ? new DirectoryInfo(archive).EnumerateFiles("image.png", SearchOption.AllDirectories).OrderByDescending((FileInfo f) => f.LastWriteTimeUtc).FirstOrDefault() : null;
			if (newest != null && newest.Length <= 8192)
			{
				image = Enlarge(File.ReadAllBytes(newest.FullName));
			}
		}
		catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
		{
		}
		string text = "🔔 ทดสอบแจ้งเตือนจากบอท — " + Who(heroName) + ((image == null) ? string.Empty : "\n(ภาพตัวอย่างจาก captcha ครั้งก่อน)");
		return await PostAsync(url, text, image, "captcha_test.png").ConfigureAwait(continueOnCapturedContext: false);
	}

	private void Enqueue(string text, byte[] image, string fileName)
	{
		string url = webhookUrl;
		if (!IsWebhookUrl(url))
		{
			log("[Discord] webhook URL is not a Discord webhook, not sent");
			return;
		}
		lock (gate)
		{
			tail = tail.ContinueWith((Task _) => SendAsync(url, text, image, fileName), CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.Default).Unwrap();
		}
	}

	private async Task SendAsync(string url, string text, byte[] image, string fileName)
	{
		string error = await PostAsync(url, text, image, fileName).ConfigureAwait(continueOnCapturedContext: false);
		if (error != null)
		{
			log("[Discord] not sent: " + error);
		}
	}

	private async Task<string> PostAsync(string url, string text, byte[] image, string fileName)
	{
		for (int attempt = 0; attempt < 2; attempt++)
		{
			try
			{
				using (MultipartFormDataContent form = new MultipartFormDataContent())
				{
					JObject payload = new JObject
					{
						["content"] = text,
						["allowed_mentions"] = new JObject { ["parse"] = new JArray() }
					};
					form.Add(new StringContent(payload.ToString(Formatting.None), Encoding.UTF8, "application/json"), "payload_json");
					if (image != null)
					{
						ByteArrayContent file = new ByteArrayContent(image);
						file.Headers.ContentType = new MediaTypeHeaderValue("image/png");
						form.Add(file, "files[0]", fileName);
					}
					using (HttpResponseMessage response = await http.PostAsync(url, form).ConfigureAwait(continueOnCapturedContext: false))
					{
						if (response.IsSuccessStatusCode)
						{
							return null;
						}
						string body = await response.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
						if ((int)response.StatusCode == 429 && attempt == 0)
						{
							double wait = 2.0;
							try
							{
								wait = (double?)JObject.Parse(body)["retry_after"] ?? 2.0;
							}
							catch (JsonException)
							{
							}
							await Task.Delay(TimeSpan.FromSeconds(Math.Min(Math.Max(wait, 0.5), 30.0))).ConfigureAwait(continueOnCapturedContext: false);
							continue;
						}
						return "HTTP " + (int)response.StatusCode + " " + ((body.Length > 200) ? body.Substring(0, 200) : body);
					}
				}
			}
			catch (Exception ex) when (ex is HttpRequestException || ex is TaskCanceledException || ex is IOException)
			{
				return ex.GetBaseException().Message;
			}
		}
		return "HTTP 429 rate limited";
	}

	private static bool IsPng(byte[] data)
	{
		if (data == null || data.Length < PngSignature.Length)
		{
			return false;
		}
		for (int i = 0; i < PngSignature.Length; i++)
		{
			if (data[i] != PngSignature[i])
			{
				return false;
			}
		}
		return true;
	}

	private static byte[] Enlarge(byte[] png)
	{
		try
		{
			using (MemoryStream input = new MemoryStream(png))
			using (Image source = Image.FromStream(input))
			{
				if (source.Width <= 0 || source.Width >= MinImageWidth)
				{
					return png;
				}
				int scale = (MinImageWidth + source.Width - 1) / source.Width;
				using (Bitmap target = new Bitmap(source.Width * scale, source.Height * scale))
				{
					using (Graphics g = Graphics.FromImage(target))
					using (ImageAttributes edges = new ImageAttributes())
					{
						edges.SetWrapMode(WrapMode.TileFlipXY);
						g.InterpolationMode = InterpolationMode.HighQualityBicubic;
						g.PixelOffsetMode = PixelOffsetMode.HighQuality;
						g.DrawImage(source, new Rectangle(0, 0, target.Width, target.Height), 0, 0, source.Width, source.Height, GraphicsUnit.Pixel, edges);
					}
					using (MemoryStream output = new MemoryStream())
					{
						target.Save(output, ImageFormat.Png);
						return output.ToArray();
					}
				}
			}
		}
		catch (Exception ex) when (ex is ArgumentException || ex is ExternalException || ex is OutOfMemoryException)
		{
			return png;
		}
	}

	private static string Who(string heroName)
	{
		if (string.IsNullOrWhiteSpace(heroName))
		{
			return "(ยังไม่รู้ชื่อตัวละคร)";
		}
		StringBuilder escaped = new StringBuilder();
		foreach (char c in heroName.Trim())
		{
			if ("\\*_~`|>#[]()".IndexOf(c) >= 0)
			{
				escaped.Append('\\');
			}
			escaped.Append(c);
		}
		return "**" + escaped + "**";
	}
}
