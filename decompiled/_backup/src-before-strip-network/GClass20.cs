using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public sealed class GClass20
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct132 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<(GClass17, GClass0)> asyncTaskMethodBuilder_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public GClass20 gclass20_0;

		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		private void MoveNext()
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			int num = int_0;
			GClass20 gClass = gclass20_0;
			(GClass17, GClass0) result3;
			try
			{
				try
				{
					TaskAwaiter<string> awaiter;
					TaskAwaiter<HttpResponseMessage> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = taskAwaiter_1;
							taskAwaiter_1 = default(TaskAwaiter<string>);
							num = -1;
							int_0 = -1;
							goto IL_0127;
						}
						StringContent val = new StringContent(JsonConvert.SerializeObject(new Class359<string, string, string, string>(string_0, string_1, string_2, gClass.string_1)), Encoding.UTF8, "application/json");
						awaiter2 = gClass.httpClient_0.PostAsync(gClass.string_0 + "/login", (HttpContent)(object)val).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
						num = -1;
						int_0 = -1;
					}
					HttpResponseMessage result = awaiter2.GetResult();
					result.EnsureSuccessStatusCode();
					awaiter = result.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0127;
					IL_0127:
					string result2 = awaiter.GetResult();
					GClass17 gClass2 = JsonConvert.DeserializeObject<GClass17>(result2);
					GClass0 item = JsonConvert.DeserializeObject<GClass0>(result2);
					if (gClass2 != null && gClass2.Success)
					{
						Class357.smethod_15(gClass2.Offsets, out var _);
					}
					result3 = (gClass2, item);
				}
				catch (HttpRequestException)
				{
					result3 = (null, null);
				}
				catch (JsonException)
				{
					result3 = (null, null);
				}
				catch (Exception)
				{
					result3 = (null, null);
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result3);
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

	[StructLayout(LayoutKind.Auto)]
	private struct Struct133 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		public string string_0;

		public string string_1;

		public GClass20 gclass20_0;

		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		private void MoveNext()
		{
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			int num = int_0;
			GClass20 gClass = gclass20_0;
			string result2;
			try
			{
				try
				{
					TaskAwaiter<string> awaiter;
					TaskAwaiter<HttpResponseMessage> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = taskAwaiter_1;
							taskAwaiter_1 = default(TaskAwaiter<string>);
							num = -1;
							int_0 = -1;
							goto IL_011b;
						}
						StringContent val = new StringContent(JsonConvert.SerializeObject(new Class118<string, string, string>(string_0, string_1, gClass.string_1)), Encoding.UTF8, "application/json");
						awaiter2 = gClass.httpClient_0.PostAsync(gClass.string_0 + "/git-token", (HttpContent)(object)val).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
						num = -1;
						int_0 = -1;
					}
					HttpResponseMessage result = awaiter2.GetResult();
					result.EnsureSuccessStatusCode();
					awaiter = result.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_011b;
					IL_011b:
					GClass8 gClass2 = JsonConvert.DeserializeObject<GClass8>(awaiter.GetResult());
					result2 = ((gClass2 == null || !gClass2.Success) ? string.Empty : gClass2.Token);
				}
				catch (Exception)
				{
					result2 = string.Empty;
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
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

	[StructLayout(LayoutKind.Auto)]
	private struct Struct134 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<GClass5> asyncTaskMethodBuilder_0;

		public GClass20 gclass20_0;

		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			GClass20 gClass = gclass20_0;
			GClass5 result2;
			try
			{
				try
				{
					TaskAwaiter<string> awaiter;
					TaskAwaiter<HttpResponseMessage> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = taskAwaiter_1;
							taskAwaiter_1 = default(TaskAwaiter<string>);
							num = -1;
							int_0 = -1;
							goto IL_0102;
						}
						string text = "?server=" + Uri.EscapeDataString(gClass.string_1);
						awaiter2 = gClass.httpClient_0.GetAsync(gClass.string_0 + "/latest-version" + text).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
						num = -1;
						int_0 = -1;
					}
					HttpResponseMessage result = awaiter2.GetResult();
					result.EnsureSuccessStatusCode();
					awaiter = result.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0102;
					IL_0102:
					result2 = JsonConvert.DeserializeObject<GClass5>(awaiter.GetResult());
				}
				catch (Exception)
				{
					result2 = null;
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
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

	[StructLayout(LayoutKind.Auto)]
	private struct Struct135 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<GClass0> asyncTaskMethodBuilder_0;

		public string string_0;

		public GClass20 gclass20_0;

		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		private void MoveNext()
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			int num = int_0;
			GClass20 gClass = gclass20_0;
			GClass0 result2;
			try
			{
				try
				{
					TaskAwaiter<string> awaiter;
					TaskAwaiter<HttpResponseMessage> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = taskAwaiter_1;
							taskAwaiter_1 = default(TaskAwaiter<string>);
							num = -1;
							int_0 = -1;
							goto IL_0112;
						}
						StringContent val = new StringContent(JsonConvert.SerializeObject(new Class42<string, string>(string_0, gClass.string_1)), Encoding.UTF8, "application/json");
						awaiter2 = gClass.httpClient_0.PostAsync(gClass.string_0 + "/check-login-status", (HttpContent)(object)val).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
						num = -1;
						int_0 = -1;
					}
					HttpResponseMessage result = awaiter2.GetResult();
					result.EnsureSuccessStatusCode();
					awaiter = result.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0112;
					IL_0112:
					result2 = JsonConvert.DeserializeObject<GClass0>(awaiter.GetResult(), new JsonSerializerSettings
					{
						Converters = new List<JsonConverter>
						{
							new GClass10()
						}
					});
				}
				catch (Exception)
				{
					result2 = null;
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
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

	[StructLayout(LayoutKind.Auto)]
	private struct Struct136 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<GClass17> asyncTaskMethodBuilder_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public GClass20 gclass20_0;

		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		private void MoveNext()
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected O, but got Unknown
			int num = int_0;
			GClass20 gClass = gclass20_0;
			GClass17 result2;
			try
			{
				try
				{
					TaskAwaiter<string> awaiter;
					TaskAwaiter<HttpResponseMessage> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = taskAwaiter_1;
							taskAwaiter_1 = default(TaskAwaiter<string>);
							num = -1;
							int_0 = -1;
							goto IL_0121;
						}
						StringContent val = new StringContent(JsonConvert.SerializeObject(new Class359<string, string, string, string>(string_0, string_1, string_2, gClass.string_1)), Encoding.UTF8, "application/json");
						awaiter2 = gClass.httpClient_0.PostAsync(gClass.string_0 + "/register", (HttpContent)(object)val).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
						num = -1;
						int_0 = -1;
					}
					HttpResponseMessage result = awaiter2.GetResult();
					result.EnsureSuccessStatusCode();
					awaiter = result.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0121;
					IL_0121:
					result2 = JsonConvert.DeserializeObject<GClass17>(awaiter.GetResult());
				}
				catch (Exception)
				{
					result2 = null;
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
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

	private readonly string string_1;

	public GClass20()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		httpClient_0 = new HttpClient();
		string_0 = Class135.smethod_0();
		string_1 = Class135.smethod_2();
	}

	public async Task<GClass17> method_0(string string_2, string string_3, string string_4)
	{
		try
		{
			StringContent val = new StringContent(JsonConvert.SerializeObject(new Class359<string, string, string, string>(string_2, string_3, string_4, string_1)), Encoding.UTF8, "application/json");
			HttpResponseMessage obj = await httpClient_0.PostAsync(string_0 + "/register", (HttpContent)(object)val);
			obj.EnsureSuccessStatusCode();
			return JsonConvert.DeserializeObject<GClass17>(await obj.Content.ReadAsStringAsync());
		}
		catch (Exception)
		{
			return null;
		}
	}

	public async Task<(GClass17, GClass0)> method_1(string string_2, string string_3, string string_4)
	{
		try
		{
			StringContent val = new StringContent(JsonConvert.SerializeObject(new Class359<string, string, string, string>(string_2, string_3, string_4, string_1)), Encoding.UTF8, "application/json");
			HttpResponseMessage obj = await httpClient_0.PostAsync(string_0 + "/login", (HttpContent)(object)val);
			obj.EnsureSuccessStatusCode();
			string value = await obj.Content.ReadAsStringAsync();
			GClass17 gClass = JsonConvert.DeserializeObject<GClass17>(value);
			GClass0 item = JsonConvert.DeserializeObject<GClass0>(value);
			if (gClass != null && gClass.Success)
			{
				Class357.smethod_15(gClass.Offsets, out var _);
			}
			return (gClass, item);
		}
		catch (HttpRequestException)
		{
			return (null, null);
		}
		catch (JsonException)
		{
			return (null, null);
		}
		catch (Exception)
		{
			return (null, null);
		}
	}

	public async Task<GClass0> method_2(string string_2)
	{
		try
		{
			StringContent val = new StringContent(JsonConvert.SerializeObject(new Class42<string, string>(string_2, string_1)), Encoding.UTF8, "application/json");
			HttpResponseMessage obj = await httpClient_0.PostAsync(string_0 + "/check-login-status", (HttpContent)(object)val);
			obj.EnsureSuccessStatusCode();
			return JsonConvert.DeserializeObject<GClass0>(await obj.Content.ReadAsStringAsync(), new JsonSerializerSettings
			{
				Converters = new List<JsonConverter>
				{
					new GClass10()
				}
			});
		}
		catch (Exception)
		{
			return null;
		}
	}

	public async Task<GClass5> method_3()
	{
		try
		{
			string text = "?server=" + Uri.EscapeDataString(string_1);
			HttpResponseMessage obj = await httpClient_0.GetAsync(string_0 + "/latest-version" + text);
			obj.EnsureSuccessStatusCode();
			return JsonConvert.DeserializeObject<GClass5>(await obj.Content.ReadAsStringAsync());
		}
		catch (Exception)
		{
			return null;
		}
	}

	public async Task<string> method_4(string string_2, string string_3)
	{
		try
		{
			StringContent val = new StringContent(JsonConvert.SerializeObject(new Class118<string, string, string>(string_2, string_3, string_1)), Encoding.UTF8, "application/json");
			HttpResponseMessage obj = await httpClient_0.PostAsync(string_0 + "/git-token", (HttpContent)(object)val);
			obj.EnsureSuccessStatusCode();
			GClass8 gClass = JsonConvert.DeserializeObject<GClass8>(await obj.Content.ReadAsStringAsync());
			if (gClass != null && gClass.Success)
			{
				return gClass.Token;
			}
			return string.Empty;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}
}
