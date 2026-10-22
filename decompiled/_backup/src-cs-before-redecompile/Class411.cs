using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

internal sealed class Class411
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct126 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<Class187> asyncTaskMethodBuilder_0;

		public Class411 class411_0;

		public string string_0;

		public Class1 class1_0;

		public CancellationToken cancellationToken_0;

		private Class187 class187_0;

		private MultipartFormDataContent multipartFormDataContent_0;

		private HttpResponseMessage httpResponseMessage_0;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter configuredTaskAwaiter_1;

		private void MoveNext()
		{
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Expected O, but got Unknown
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			int num = int_0;
			Class411 @class = class411_0;
			Class187 result2;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_00a6;
				}
				class187_0 = new Class187
				{
					timeSpan_0 = TimeSpan.FromSeconds(5.0)
				};
				Uri uri = default(Uri);
				if (!string.IsNullOrWhiteSpace(@class.string_0) && File.Exists(string_0))
				{
					if (Uri.TryCreate(@class.string_0, UriKind.Absolute, out var result))
					{
						string text = ((result.Query.Length == 0) ? "?" : "&");
						uri = new Uri(@class.string_0 + text + "wait=true");
						goto IL_00a6;
					}
					result2 = class187_0;
				}
				else
				{
					result2 = class187_0;
				}
				goto end_IL_000e;
				IL_00a6:
				try
				{
					if ((uint)num > 1u)
					{
						multipartFormDataContent_0 = new MultipartFormDataContent();
					}
					try
					{
						ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0189;
							}
							multipartFormDataContent_0.Add((HttpContent)new StringContent(smethod_0(class1_0), Encoding.UTF8), "content");
							multipartFormDataContent_0.Add((HttpContent)new ByteArrayContent(File.ReadAllBytes(string_0)), "files[0]", "challenge_" + class1_0.String_0 + ".png");
							awaiter = @class.httpClient_0.PostAsync(uri, (HttpContent)(object)multipartFormDataContent_0, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								int_0 = 0;
								configuredTaskAwaiter_0 = awaiter;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = configuredTaskAwaiter_0;
							configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
							num = -1;
							int_0 = -1;
						}
						HttpResponseMessage result3 = awaiter.GetResult();
						httpResponseMessage_0 = result3;
						goto IL_0189;
						IL_0189:
						try
						{
							ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter2;
							if (num != 1)
							{
								awaiter2 = httpResponseMessage_0.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num = 1;
									int_0 = 1;
									configuredTaskAwaiter_1 = awaiter2;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = configuredTaskAwaiter_1;
								configuredTaskAwaiter_1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
								num = -1;
								int_0 = -1;
							}
							string result4 = awaiter2.GetResult();
							if (httpResponseMessage_0.IsSuccessStatusCode)
							{
								JObject val = JObject.Parse(result4);
								class187_0.string_0 = (string)val["id"];
								result2 = class187_0;
							}
							else if (httpResponseMessage_0.StatusCode == (HttpStatusCode)429)
							{
								double num2;
								try
								{
									num2 = ((double?)JObject.Parse(result4)["retry_after"]) ?? 5.0;
								}
								catch (JsonException)
								{
									num2 = 5.0;
								}
								if (num2 > 0.0 && num2 < 3600.0)
								{
									class187_0.timeSpan_0 = TimeSpan.FromSeconds(num2);
								}
								result2 = class187_0;
							}
							else
							{
								class187_0.bool_0 = httpResponseMessage_0.StatusCode == HttpStatusCode.NotFound || httpResponseMessage_0.StatusCode == HttpStatusCode.Unauthorized || httpResponseMessage_0.StatusCode == HttpStatusCode.Forbidden;
								result2 = class187_0;
							}
						}
						finally
						{
							if (num < 0 && httpResponseMessage_0 != null)
							{
								((IDisposable)httpResponseMessage_0).Dispose();
							}
						}
					}
					finally
					{
						if (num < 0 && multipartFormDataContent_0 != null)
						{
							((IDisposable)multipartFormDataContent_0).Dispose();
						}
					}
				}
				catch (OperationCanceledException)
				{
					result2 = class187_0;
				}
				catch (HttpRequestException)
				{
					result2 = class187_0;
				}
				catch (IOException)
				{
					result2 = class187_0;
				}
				catch (JsonException)
				{
					result2 = class187_0;
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class187_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class187_0 = null;
			asyncTaskMethodBuilder_0.SetResult(result2);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private readonly HttpClient httpClient_0;

	private readonly string string_0;

	internal Class411(HttpClient httpClient_1, string string_1)
	{
		httpClient_0 = httpClient_1 ?? throw new ArgumentNullException("\u000e");
		string_0 = string_1 ?? string.Empty;
	}

	internal static string smethod_0(Class1 class1_0)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		if (class1_0 == null)
		{
			throw new ArgumentNullException("sample");
		}
		string text = ((class1_0.String_7 == "verified") ? "PASS_VERIFIED" : ((class1_0.String_7 == "expired") ? "REVIEW_NEEDED_EXPIRED" : ((class1_0.String_7 == "failed") ? "REVIEW_NEEDED_FAILED" : null)));
		if (text == null)
		{
			throw new InvalidOperationException("challenge is not terminal");
		}
		JObject val = new JObject
		{
			["sampleId"] = JToken.op_Implicit(class1_0.String_0),
			["heroName"] = (JToken)((class1_0.String_2 == null) ? ((object)JValue.CreateNull()) : ((object)new JValue(class1_0.String_2))),
			["imageSha256"] = JToken.op_Implicit(class1_0.String_3),
			["gameVersionCode"] = JToken.op_Implicit(class1_0.Int32_1),
			["challengeType"] = JToken.op_Implicit(class1_0.Int32_2),
			["result"] = JToken.op_Implicit(class1_0.String_6),
			["header"] = JToken.op_Implicit(text),
			["labelStatus"] = JToken.op_Implicit((class1_0.String_7 == "verified") ? "server_verified" : "needs_human_review"),
			["prediction"] = (JToken)((class1_0.String_9 == null) ? ((object)JValue.CreateNull()) : ((object)new JValue(class1_0.String_9))),
			["predictionConfidence"] = (JToken)((!class1_0.Nullable_2.HasValue) ? ((object)JValue.CreateNull()) : ((object)new JValue(class1_0.Nullable_2.Value))),
			["verifiedAnswer"] = (JToken)((class1_0.String_5 == null) ? ((object)JValue.CreateNull()) : ((object)new JValue(class1_0.String_5)))
		};
		if (class1_0.String_11 != null)
		{
			val["shadowPrediction"] = JToken.op_Implicit(class1_0.String_11);
			val["shadowConfidence"] = (JToken)((!class1_0.Nullable_4.HasValue) ? ((object)JValue.CreateNull()) : ((object)new JValue(class1_0.Nullable_4.Value)));
		}
		if (class1_0.String_10 != null && class1_0.String_10 != "oneocr")
		{
			val["answerSource"] = JToken.op_Implicit(class1_0.String_10);
		}
		string text2 = ((JToken)val).ToString((Formatting)1, Array.Empty<JsonConverter>());
		if (text2.Length > 2000)
		{
			throw new InvalidDataException("Discord content is too long");
		}
		return text2;
	}

	internal async Task<Class187> method_0(Class1 class1_0, string string_1, CancellationToken cancellationToken_0)
	{
		Class187 @class = new Class187
		{
			timeSpan_0 = TimeSpan.FromSeconds(5.0)
		};
		if (!string.IsNullOrWhiteSpace(string_0) && File.Exists(string_1))
		{
			if (!Uri.TryCreate(string_0, UriKind.Absolute, out var result))
			{
				return @class;
			}
			string text = ((result.Query.Length == 0) ? "?" : "&");
			Uri uri = new Uri(string_0 + text + "wait=true");
			try
			{
				MultipartFormDataContent val = new MultipartFormDataContent();
				try
				{
					val.Add((HttpContent)new StringContent(smethod_0(class1_0), Encoding.UTF8), "content");
					val.Add((HttpContent)new ByteArrayContent(File.ReadAllBytes(string_1)), "files[0]", "challenge_" + class1_0.String_0 + ".png");
					HttpResponseMessage val2 = await httpClient_0.PostAsync(uri, (HttpContent)(object)val, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false);
					try
					{
						string text2 = await val2.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
						if (val2.IsSuccessStatusCode)
						{
							JObject val3 = JObject.Parse(text2);
							@class.string_0 = (string)val3["id"];
							return @class;
						}
						if (val2.StatusCode == (HttpStatusCode)429)
						{
							double num;
							try
							{
								num = ((double?)JObject.Parse(text2)["retry_after"]) ?? 5.0;
							}
							catch (JsonException)
							{
								num = 5.0;
							}
							if (num > 0.0 && num < 3600.0)
							{
								@class.timeSpan_0 = TimeSpan.FromSeconds(num);
							}
							return @class;
						}
						@class.bool_0 = val2.StatusCode == HttpStatusCode.NotFound || val2.StatusCode == HttpStatusCode.Unauthorized || val2.StatusCode == HttpStatusCode.Forbidden;
						return @class;
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			catch (OperationCanceledException)
			{
				return @class;
			}
			catch (HttpRequestException)
			{
				return @class;
			}
			catch (IOException)
			{
				return @class;
			}
			catch (JsonException)
			{
				return @class;
			}
		}
		return @class;
	}
}
