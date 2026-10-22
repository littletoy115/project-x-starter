using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

internal static class Class21
{
	private sealed class Class22
	{
		public long long_0;

		internal bool method_0(JObject jobject_0)
		{
			if ((long?)jobject_0[Class185.smethod_0(-1141293578)] == long_0)
			{
				return (string)jobject_0[Class185.smethod_0(-1141293587)] == Class185.smethod_0(-1141293606);
			}
			return false;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct2 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<Class345> asyncTaskMethodBuilder_0;

		public long long_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public long long_1;

		public long long_2;

		public string string_3;

		public HttpClient httpClient_0;

		public CancellationToken cancellationToken_0;

		private Class22 class22_0;

		private Class25 class25_0;

		private string string_4;

		private JObject jobject_0;

		private JObject jobject_1;

		private Class345 class345_0;

		private Encoding encoding_0;

		private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private IEnumerator<Class94> ienumerator_0;

		private void MoveNext()
		{
			int num = int_0;
			Class345 result3;
			try
			{
				byte[] result;
				ref JObject reference;
				JToken obj;
				ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter awaiter;
				byte[] result2;
				switch (num)
				{
				default:
					class22_0 = new Class22();
					class22_0.long_0 = long_0;
					smethod_16(string_0, Class185.smethod_0(-1141293709));
					smethod_16(string_1, Class185.smethod_0(-1141293713));
					smethod_16(string_2, Class185.smethod_0(-1141293730));
					smethod_17(long_1, class22_0.long_0, long_2, string_3);
					string_4 = smethod_15(string_0, string_1);
					encoding_0 = Encoding.UTF8;
					awaiter = smethod_11(httpClient_0, string_4 + Class185.smethod_0(-1141294715) + long_1, Class185.smethod_0(-1141293085), 1048576, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						configuredTaskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0150;
				case 0:
					awaiter = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0150;
				case 1:
					awaiter = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_03bb;
				case 2:
					break;
					IL_03bb:
					result = awaiter.GetResult();
					if (result.LongLength == (long)jobject_1[Class185.smethod_0(-1141293374)] && smethod_26(smethod_24(result), string_3))
					{
						string value = (string)jobject_1[Class185.smethod_0(-1141293458)];
						if (!string.IsNullOrEmpty(value) && !smethod_26(value, Class185.smethod_0(-1141293479) + string_3))
						{
							throw new InvalidDataException(Class185.smethod_0(-1141294918));
						}
						class345_0 = smethod_9(result, string_2, long_1, class22_0.long_0);
						class345_0.string_4 = smethod_22(jobject_0[Class185.smethod_0(-1141293557)]);
						ienumerator_0 = class345_0.ireadOnlyList_0.GetEnumerator();
						break;
					}
					throw new InvalidDataException(Class185.smethod_0(-1141294834));
					IL_0150:
					result2 = awaiter.GetResult();
					jobject_0 = JObject.Parse(encoding_0.GetString(result2));
					encoding_0 = null;
					if ((long?)jobject_0[Class185.smethod_0(-1141293578)] != long_1 || (bool?)jobject_0[Class185.smethod_0(-1141293634)] == true || (bool?)jobject_0[Class185.smethod_0(-1141293654)] == true || !(((string)jobject_0[Class185.smethod_0(-1141293671)]) ?? string.Empty).StartsWith(Class185.smethod_0(-1141293686) + string_2 + Class185.smethod_0(-1141293701), StringComparison.Ordinal))
					{
						throw new InvalidDataException(Class185.smethod_0(-1141294732));
					}
					reference = ref jobject_1;
					obj = jobject_0[Class185.smethod_0(-1141293233)];
					reference = ((IEnumerable)((obj is JArray) ? obj : null))?.OfType<JObject>().SingleOrDefault(class22_0.method_0);
					if (jobject_1 != null && (long?)jobject_1[Class185.smethod_0(-1141293374)] == long_2 && long_2 > 0L && long_2 <= 1048576L)
					{
						awaiter = smethod_11(httpClient_0, string_4 + Class185.smethod_0(-1141293797) + class22_0.long_0, Class185.smethod_0(-1141293821), 1048576, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
							configuredTaskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_03bb;
					}
					throw new InvalidDataException(Class185.smethod_0(-1141294789));
				}
				try
				{
					if (num != 2)
					{
						goto IL_0606;
					}
					awaiter = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_06ab;
					IL_06ab:
					result2 = awaiter.GetResult();
					JObject val = JObject.Parse(encoding_0.GetString(result2));
					encoding_0 = null;
					if ((long?)val[Class185.smethod_0(-1141293578)] != class25_0.class94_0.Int64_1 || (bool?)val[Class185.smethod_0(-1141293634)] == true || (bool?)val[Class185.smethod_0(-1141293654)] == true)
					{
						throw new InvalidDataException(Class185.smethod_0(-1141294983));
					}
					JToken obj2 = val[Class185.smethod_0(-1141293233)];
					JObject val2 = ((IEnumerable)((obj2 is JArray) ? obj2 : null))?.OfType<JObject>().SingleOrDefault(class25_0.method_0);
					if (val2 != null && (long?)val2[Class185.smethod_0(-1141293374)] == class25_0.class94_0.Int64_0)
					{
						string value2 = (string)val2[Class185.smethod_0(-1141293458)];
						if (string.IsNullOrEmpty(value2) || smethod_26(value2, Class185.smethod_0(-1141293479) + class25_0.class94_0.String_2))
						{
							class25_0 = null;
							goto IL_0606;
						}
						throw new InvalidDataException(Class185.smethod_0(-1141295099));
					}
					throw new InvalidDataException(Class185.smethod_0(-1141295033));
					IL_0606:
					if (ienumerator_0.MoveNext())
					{
						class25_0 = new Class25();
						class25_0.class94_0 = ienumerator_0.Current;
						encoding_0 = Encoding.UTF8;
						awaiter = smethod_11(httpClient_0, string_4 + Class185.smethod_0(-1141294715) + class25_0.class94_0.Int64_1, Class185.smethod_0(-1141293085), 1048576, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 2;
							int_0 = 2;
							configuredTaskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_06ab;
					}
				}
				finally
				{
					if (num < 0 && ienumerator_0 != null)
					{
						ienumerator_0.Dispose();
					}
				}
				ienumerator_0 = null;
				result3 = class345_0;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class22_0 = null;
				string_4 = null;
				jobject_0 = null;
				jobject_1 = null;
				class345_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class22_0 = null;
			string_4 = null;
			jobject_0 = null;
			jobject_1 = null;
			class345_0 = null;
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

	private sealed class Class23
	{
		public string string_0;

		internal bool method_0(JObject jobject_0)
		{
			if ((bool?)jobject_0[Class185.smethod_0(-1141293634)] != true && (bool?)jobject_0[Class185.smethod_0(-1141293654)] != true)
			{
				return (((string)jobject_0[Class185.smethod_0(-1141293671)]) ?? string.Empty).StartsWith(Class185.smethod_0(-1141293686) + string_0 + Class185.smethod_0(-1141293701), StringComparison.Ordinal);
			}
			return false;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct3 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public long long_0;

		public long long_1;

		public string string_0;

		public string string_1;

		public string string_2;

		public CancellationToken cancellationToken_0;

		public HttpClient httpClient_0;

		public string string_3;

		private CancellationTokenSource cancellationTokenSource_0;

		private HttpRequestMessage httpRequestMessage_0;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private void MoveNext()
		{
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Expected O, but got Unknown
			int num = int_0;
			try
			{
				string text = default(string);
				if (num != 0)
				{
					if (long_0 <= 0L || long_1 < 0L || long_1 > 536870912L || !smethod_18(string_0))
					{
						throw new InvalidDataException(Class185.smethod_0(-1141293746));
					}
					text = smethod_15(string_1, string_2) + Class185.smethod_0(-1141293797) + long_0;
					smethod_13(new Uri(text), bool_0: false);
					cancellationTokenSource_0 = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken_0);
				}
				try
				{
					if (num != 0)
					{
						httpRequestMessage_0 = new HttpRequestMessage(HttpMethod.Get, text);
					}
					try
					{
						ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							cancellationTokenSource_0.CancelAfter(TimeSpan.FromMinutes(10.0));
							httpRequestMessage_0.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(Class185.smethod_0(-1141293821)));
							awaiter = smethod_6(httpClient_0, httpRequestMessage_0, string_3, long_1, string_0, cancellationTokenSource_0.Token, bool_0: true).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
							configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
							num = -1;
							int_0 = -1;
						}
						awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && httpRequestMessage_0 != null)
						{
							((IDisposable)httpRequestMessage_0).Dispose();
						}
					}
					httpRequestMessage_0 = null;
				}
				finally
				{
					if (num < 0 && cancellationTokenSource_0 != null)
					{
						((IDisposable)cancellationTokenSource_0).Dispose();
					}
				}
				cancellationTokenSource_0 = null;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult();
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
	private struct Struct4 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<Class438> asyncTaskMethodBuilder_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public string string_3;

		public string string_4;

		public HttpMessageHandler httpMessageHandler_0;

		public CancellationToken cancellationToken_0;

		private string string_5;

		private HttpClient httpClient_0;

		private ConfiguredTaskAwaitable<Class345>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class438 result;
			try
			{
				if (num != 0)
				{
					smethod_16(string_0, Class185.smethod_0(-1141293709));
					smethod_16(string_1, Class185.smethod_0(-1141293713));
					smethod_16(string_2, Class185.smethod_0(-1141293730));
					string_5 = Class382.smethod_1(string_3);
					httpClient_0 = smethod_3(string_4, httpMessageHandler_0);
				}
				try
				{
					ConfiguredTaskAwaitable<Class345>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = smethod_7(httpClient_0, string_0, string_1, string_2, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
						configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable<Class345>.ConfiguredTaskAwaiter);
						num = -1;
						int_0 = -1;
					}
					result = smethod_8(awaiter.GetResult(), string_5);
				}
				finally
				{
					if (num < 0 && httpClient_0 != null)
					{
						((IDisposable)httpClient_0).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				string_5 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			string_5 = null;
			asyncTaskMethodBuilder_0.SetResult(result);
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
	private struct Struct5 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<byte[]> asyncTaskMethodBuilder_0;

		public HttpClient httpClient_0;

		public HttpRequestMessage httpRequestMessage_0;

		public CancellationToken cancellationToken_0;

		public bool bool_0;

		public int int_1;

		private HttpResponseMessage httpResponseMessage_0;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private HttpRequestMessage httpRequestMessage_1;

		private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter configuredTaskAwaiter_1;

		private Stream stream_0;

		private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter configuredTaskAwaiter_2;

		private MemoryStream memoryStream_0;

		private byte[] byte_0;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter configuredTaskAwaiter_3;

		private void MoveNext()
		{
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected O, but got Unknown
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			int num = int_0;
			byte[] result3;
			try
			{
				ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					if ((uint)(num - 1) <= 2u)
					{
						goto IL_0074;
					}
					awaiter = httpClient_0.SendAsync(httpRequestMessage_0, (HttpCompletionOption)1, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
				HttpResponseMessage result = awaiter.GetResult();
				httpResponseMessage_0 = result;
				goto IL_0074;
				IL_0074:
				try
				{
					ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter awaiter2;
					Stream result4;
					switch (num)
					{
					default:
						if (smethod_14(httpResponseMessage_0.StatusCode) & bool_0)
						{
							Uri location = httpResponseMessage_0.Headers.Location;
							smethod_13(location, bool_0: true);
							httpRequestMessage_1 = new HttpRequestMessage(HttpMethod.Get, location);
							goto case 1;
						}
						if (!httpResponseMessage_0.IsSuccessStatusCode)
						{
							throw new HttpRequestException(Class185.smethod_0(-1141294131) + (int)httpResponseMessage_0.StatusCode + Class185.smethod_0(-1141293956));
						}
						if (httpResponseMessage_0.Content.Headers.ContentLength > int_1)
						{
							throw new InvalidDataException(Class185.smethod_0(-1141294163));
						}
						awaiter2 = httpResponseMessage_0.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 2;
							int_0 = 2;
							configuredTaskAwaiter_2 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0246;
					case 1:
						try
						{
							ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter awaiter4;
							if (num != 1)
							{
								awaiter4 = smethod_12(httpClient_0, httpRequestMessage_1, int_1, cancellationToken_0, bool_0: false).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								if (!awaiter4.IsCompleted)
								{
									num = 1;
									int_0 = 1;
									configuredTaskAwaiter_1 = awaiter4;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									return;
								}
							}
							else
							{
								awaiter4 = configuredTaskAwaiter_1;
								configuredTaskAwaiter_1 = default(ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter);
								num = -1;
								int_0 = -1;
							}
							result3 = awaiter4.GetResult();
						}
						finally
						{
							if (num < 0 && httpRequestMessage_1 != null)
							{
								((IDisposable)httpRequestMessage_1).Dispose();
							}
						}
						break;
					case 2:
						awaiter2 = configuredTaskAwaiter_2;
						configuredTaskAwaiter_2 = default(ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter);
						num = -1;
						int_0 = -1;
						goto IL_0246;
					case 3:
						{
							try
							{
								if (num != 3)
								{
									memoryStream_0 = new MemoryStream();
								}
								try
								{
									if (num != 3)
									{
										byte_0 = new byte[81920];
										goto IL_02c9;
									}
									ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter3 = configuredTaskAwaiter_3;
									configuredTaskAwaiter_3 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
									num = -1;
									int_0 = -1;
									goto IL_0303;
									IL_0303:
									int result2;
									if ((result2 = awaiter3.GetResult()) != 0)
									{
										if (memoryStream_0.Length + result2 <= int_1)
										{
											memoryStream_0.Write(byte_0, 0, result2);
											goto IL_02c9;
										}
										throw new InvalidDataException(Class185.smethod_0(-1141294163));
									}
									result3 = memoryStream_0.ToArray();
									goto end_IL_0268;
									IL_02c9:
									awaiter3 = stream_0.ReadAsync(byte_0, 0, byte_0.Length, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num = 3;
										int_0 = 3;
										configuredTaskAwaiter_3 = awaiter3;
										asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									}
									goto IL_0303;
									end_IL_0268:;
								}
								finally
								{
									if (num < 0 && memoryStream_0 != null)
									{
										((IDisposable)memoryStream_0).Dispose();
									}
								}
							}
							finally
							{
								if (num < 0 && stream_0 != null)
								{
									((IDisposable)stream_0).Dispose();
								}
							}
							break;
						}
						IL_0246:
						result4 = awaiter2.GetResult();
						stream_0 = result4;
						goto case 3;
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

	private sealed class Class24
	{
		public Class94 class94_0;

		internal bool method_0(JObject jobject_0)
		{
			if ((long?)jobject_0[Class185.smethod_0(-1141293578)] == class94_0.Int64_1 && (bool?)jobject_0[Class185.smethod_0(-1141293634)] != true)
			{
				return (bool?)jobject_0[Class185.smethod_0(-1141293654)] != true;
			}
			return false;
		}

		internal bool method_1(JObject jobject_0)
		{
			return (long?)jobject_0[Class185.smethod_0(-1141293578)] == class94_0.Int64_2;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct6 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public HttpClient httpClient_0;

		public HttpRequestMessage httpRequestMessage_0;

		public CancellationToken cancellationToken_0;

		public bool bool_0;

		public string string_0;

		public long long_0;

		public string string_1;

		private HttpResponseMessage httpResponseMessage_0;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private HttpRequestMessage httpRequestMessage_1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_1;

		private Stream stream_0;

		private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter configuredTaskAwaiter_2;

		private FileStream fileStream_0;

		private SHA256 sha256_0;

		private byte[] byte_0;

		private long long_1;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter configuredTaskAwaiter_3;

		private void MoveNext()
		{
			//IL_0469: Unknown result type (might be due to invalid IL or missing references)
			//IL_0473: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			int num = int_0;
			try
			{
				ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					if ((uint)(num - 1) <= 2u)
					{
						goto IL_0095;
					}
					awaiter = httpClient_0.SendAsync(httpRequestMessage_0, (HttpCompletionOption)1, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
				HttpResponseMessage result = awaiter.GetResult();
				httpResponseMessage_0 = result;
				goto IL_0095;
				IL_0095:
				try
				{
					if (num == 1)
					{
						goto IL_0448;
					}
					if ((uint)(num - 2) > 1u)
					{
						if (smethod_14(httpResponseMessage_0.StatusCode) & bool_0)
						{
							Uri location = httpResponseMessage_0.Headers.Location;
							smethod_13(location, bool_0: true);
							httpRequestMessage_1 = new HttpRequestMessage(HttpMethod.Get, location);
							goto IL_0448;
						}
						if (!httpResponseMessage_0.IsSuccessStatusCode)
						{
							throw new HttpRequestException(Class185.smethod_0(-1141293914) + (int)httpResponseMessage_0.StatusCode + Class185.smethod_0(-1141293956));
						}
						if (httpResponseMessage_0.Content.Headers.ContentLength.HasValue && httpResponseMessage_0.Content.Headers.ContentLength.Value != long_0)
						{
							throw new InvalidDataException(Class185.smethod_0(-1141293973));
						}
					}
					checked
					{
						try
						{
							ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter awaiter2;
							if (num != 2)
							{
								if (num == 3)
								{
									goto IL_0208;
								}
								awaiter2 = httpResponseMessage_0.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num = 2;
									int_0 = 2;
									configuredTaskAwaiter_2 = awaiter2;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = configuredTaskAwaiter_2;
								configuredTaskAwaiter_2 = default(ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter);
								num = -1;
								int_0 = -1;
							}
							Stream result2 = awaiter2.GetResult();
							stream_0 = result2;
							goto IL_0208;
							IL_0208:
							try
							{
								if (num != 3)
								{
									fileStream_0 = new FileStream(string_0, FileMode.CreateNew, FileAccess.Write, FileShare.None);
								}
								try
								{
									if (num != 3)
									{
										sha256_0 = SHA256.Create();
									}
									try
									{
										if (num != 3)
										{
											byte_0 = new byte[81920];
											long_1 = 0L;
											goto IL_02c1;
										}
										ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter awaiter3 = configuredTaskAwaiter_3;
										configuredTaskAwaiter_3 = default(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter);
										num = -1;
										int_0 = -1;
										goto IL_02fe;
										IL_02fe:
										int result3;
										if ((result3 = awaiter3.GetResult()) != 0)
										{
											long_1 += result3;
											if (long_1 <= long_0)
											{
												sha256_0.TransformBlock(byte_0, 0, result3, null, 0);
												fileStream_0.Write(byte_0, 0, result3);
												goto IL_02c1;
											}
											throw new InvalidDataException(Class185.smethod_0(-1141294017));
										}
										sha256_0.TransformFinalBlock(new byte[0], 0, 0);
										fileStream_0.Flush(flushToDisk: true);
										string text = BitConverter.ToString(sha256_0.Hash).Replace(Class185.smethod_0(-1141293701), string.Empty).ToLowerInvariant();
										if (long_1 != long_0 || !smethod_26(text, string_1))
										{
											throw new InvalidDataException(Class185.smethod_0(-1141293844));
										}
										byte_0 = null;
										goto end_IL_0231;
										IL_02c1:
										awaiter3 = stream_0.ReadAsync(byte_0, 0, byte_0.Length, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
										if (!awaiter3.IsCompleted)
										{
											num = 3;
											int_0 = 3;
											configuredTaskAwaiter_3 = awaiter3;
											asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											return;
										}
										goto IL_02fe;
										end_IL_0231:;
									}
									finally
									{
										if (num < 0 && sha256_0 != null)
										{
											((IDisposable)sha256_0).Dispose();
										}
									}
									sha256_0 = null;
								}
								finally
								{
									if (num < 0 && fileStream_0 != null)
									{
										((IDisposable)fileStream_0).Dispose();
									}
								}
								fileStream_0 = null;
							}
							finally
							{
								if (num < 0 && stream_0 != null)
								{
									((IDisposable)stream_0).Dispose();
								}
							}
							stream_0 = null;
						}
						catch
						{
							try
							{
								if (File.Exists(string_0))
								{
									File.Delete(string_0);
								}
							}
							catch
							{
							}
							throw;
						}
						goto end_IL_0095;
					}
					IL_0448:
					try
					{
						ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter4;
						if (num != 1)
						{
							httpRequestMessage_1.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(Class185.smethod_0(-1141293821)));
							awaiter4 = smethod_6(httpClient_0, httpRequestMessage_1, string_0, long_0, string_1, cancellationToken_0, bool_0: false).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								num = 1;
								int_0 = 1;
								configuredTaskAwaiter_1 = awaiter4;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							}
						}
						else
						{
							awaiter4 = configuredTaskAwaiter_1;
							configuredTaskAwaiter_1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
							num = -1;
							int_0 = -1;
						}
						awaiter4.GetResult();
					}
					finally
					{
						if (num < 0 && httpRequestMessage_1 != null)
						{
							((IDisposable)httpRequestMessage_1).Dispose();
						}
					}
					goto end_IL_0007;
					end_IL_0095:;
				}
				finally
				{
					if (num < 0 && httpResponseMessage_0 != null)
					{
						((IDisposable)httpResponseMessage_0).Dispose();
					}
				}
				httpResponseMessage_0 = null;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult();
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

	private sealed class Class25
	{
		public Class94 class94_0;

		internal bool method_0(JObject jobject_0)
		{
			return (long?)jobject_0[Class185.smethod_0(-1141293578)] == class94_0.Int64_2;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct7 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<byte[]> asyncTaskMethodBuilder_0;

		public string string_0;

		public CancellationToken cancellationToken_0;

		public string string_1;

		public HttpClient httpClient_0;

		public int int_1;

		private CancellationTokenSource cancellationTokenSource_0;

		private HttpRequestMessage httpRequestMessage_0;

		private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private void MoveNext()
		{
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			int num = int_0;
			byte[] result;
			try
			{
				if (num != 0)
				{
					smethod_13(new Uri(string_0), bool_0: false);
					cancellationTokenSource_0 = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken_0);
				}
				try
				{
					if (num != 0)
					{
						httpRequestMessage_0 = new HttpRequestMessage(HttpMethod.Get, string_0);
					}
					try
					{
						ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							cancellationTokenSource_0.CancelAfter(TimeSpan.FromMinutes(10.0));
							httpRequestMessage_0.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(string_1));
							awaiter = smethod_12(httpClient_0, httpRequestMessage_0, int_1, cancellationTokenSource_0.Token, bool_0: true).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
							configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter);
							num = -1;
							int_0 = -1;
						}
						result = awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && httpRequestMessage_0 != null)
						{
							((IDisposable)httpRequestMessage_0).Dispose();
						}
					}
				}
				finally
				{
					if (num < 0 && cancellationTokenSource_0 != null)
					{
						((IDisposable)cancellationTokenSource_0).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result);
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

	[Serializable]
	private sealed class Class26
	{
		public static readonly Class26 class26_0 = new Class26();

		public static Func<JObject, DateTimeOffset> func_0;

		public static Func<JObject, long> func_1;

		public static Func<JObject, bool> func_2;

		public static Func<Class94, string> func_3;

		public static Func<Class94, string> func_4;

		public static Func<Class94, bool> func_5;

		public static Func<Class94, string> func_6;

		public static Func<char, bool> func_7;

		internal DateTimeOffset method_0(JObject jobject_0)
		{
			return ((DateTimeOffset?)jobject_0[Class185.smethod_0(-1141296639)]) ?? DateTimeOffset.MinValue;
		}

		internal long method_1(JObject jobject_0)
		{
			return ((long?)jobject_0[Class185.smethod_0(-1141293578)]).GetValueOrDefault();
		}

		internal bool method_2(JObject jobject_0)
		{
			return (string)jobject_0[Class185.smethod_0(-1141293587)] == Class185.smethod_0(-1141293606);
		}

		internal string method_3(Class94 class94_0)
		{
			return class94_0.String_0;
		}

		internal string method_4(Class94 class94_0)
		{
			return class94_0.String_0;
		}

		internal bool method_5(Class94 class94_0)
		{
			return class94_0.String_3 != Class185.smethod_0(-1141293618);
		}

		internal string method_6(Class94 class94_0)
		{
			return class94_0.String_0;
		}

		internal bool method_7(char char_0)
		{
			if (!char.IsLetterOrDigit(char_0) && char_0 != '-' && char_0 != '_')
			{
				return char_0 != '.';
			}
			return false;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct8 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<byte[]> asyncTaskMethodBuilder_0;

		public long long_0;

		public long long_1;

		public HttpClient httpClient_0;

		public string string_0;

		public string string_1;

		public CancellationToken cancellationToken_0;

		public string string_2;

		private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			byte[] result2;
			try
			{
				ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					if (long_0 <= 0L || long_1 < 0L || long_1 > 536870912L)
					{
						throw new InvalidDataException(Class185.smethod_0(-1141293746));
					}
					awaiter = smethod_11(httpClient_0, smethod_15(string_0, string_1) + Class185.smethod_0(-1141293797) + long_0, Class185.smethod_0(-1141293821), checked((int)Math.Min(536870912L, long_1 + 1L)), cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
				}
				byte[] result = awaiter.GetResult();
				if (result.LongLength != long_1 || !smethod_26(smethod_24(result), string_2))
				{
					throw new InvalidDataException(Class185.smethod_0(-1141293844));
				}
				result2 = result;
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

	private sealed class Class27
	{
		public JObject jobject_0;

		public string[] string_0;

		internal bool method_0(string string_1)
		{
			return jobject_0[string_1] == null;
		}

		internal bool method_1(JProperty jproperty_0)
		{
			return !string_0.Contains(jproperty_0.Name);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct9 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<Class345> asyncTaskMethodBuilder_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public HttpClient httpClient_0;

		public CancellationToken cancellationToken_0;

		private Class23 class23_0;

		private string string_3;

		private List<JObject> list_0;

		private JObject jobject_0;

		private JObject jobject_1;

		private long long_0;

		private long long_1;

		private long long_2;

		private int int_1;

		private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class345 result2;
			try
			{
				ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					if (num != 1)
					{
						class23_0 = new Class23();
						class23_0.string_0 = string_0;
						string_3 = smethod_15(string_1, string_2);
						list_0 = new List<JObject>();
						int_1 = 1;
						goto IL_00b8;
					}
					awaiter = configuredTaskAwaiter_0;
					configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter);
					num = -1;
					int_0 = -1;
					goto IL_0397;
				}
				awaiter = configuredTaskAwaiter_0;
				configuredTaskAwaiter_0 = default(ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter);
				num = -1;
				int_0 = -1;
				goto IL_011e;
				IL_0397:
				byte[] result = awaiter.GetResult();
				if (result.LongLength != long_2)
				{
					throw new InvalidDataException(Class185.smethod_0(-1141293396));
				}
				string text = smethod_24(result);
				string value = (string)jobject_1[Class185.smethod_0(-1141293458)];
				if (!string.IsNullOrEmpty(value) && !smethod_26(value, Class185.smethod_0(-1141293479) + text))
				{
					throw new InvalidDataException(Class185.smethod_0(-1141293493));
				}
				Class345 @class = smethod_9(result, class23_0.string_0, long_0, long_1);
				@class.string_4 = smethod_22(jobject_0[Class185.smethod_0(-1141293557)]);
				IEnumerator<Class94> enumerator = @class.ireadOnlyList_0.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class24 class2 = new Class24();
						class2.class94_0 = enumerator.Current;
						JObject obj = list_0.SingleOrDefault(class2.method_0);
						JToken obj2 = ((obj != null) ? obj[Class185.smethod_0(-1141293233)] : null);
						JObject val = ((IEnumerable)((obj2 is JArray) ? obj2 : null))?.OfType<JObject>().SingleOrDefault(class2.method_1);
						if (val != null && (long?)val[Class185.smethod_0(-1141293374)] == class2.class94_0.Int64_0)
						{
							string value2 = (string)val[Class185.smethod_0(-1141293458)];
							if (!string.IsNullOrEmpty(value2) && !smethod_26(value2, Class185.smethod_0(-1141293479) + class2.class94_0.String_2))
							{
								throw new InvalidDataException(Class185.smethod_0(-1141294663));
							}
							continue;
						}
						throw new InvalidDataException(Class185.smethod_0(-1141293568));
					}
				}
				finally
				{
					if (num < 0)
					{
						enumerator?.Dispose();
					}
				}
				result2 = @class;
				goto end_IL_0007;
				IL_00b8:
				if (int_1 <= 10)
				{
					awaiter = smethod_11(httpClient_0, string_3 + Class185.smethod_0(-1141294066) + int_1, Class185.smethod_0(-1141293085), 16777216, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						configuredTaskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_011e;
				}
				goto IL_018f;
				IL_011e:
				byte[] result3 = awaiter.GetResult();
				JArray val2 = JArray.Parse(Encoding.UTF8.GetString(result3));
				list_0.AddRange(((IEnumerable)val2).OfType<JObject>());
				if (((JContainer)val2).Count >= 100)
				{
					if (int_1 != 10)
					{
						int_1++;
						goto IL_00b8;
					}
					throw new InvalidDataException(Class185.smethod_0(-1141293119));
				}
				goto IL_018f;
				IL_018f:
				jobject_0 = list_0.Where(class23_0.method_0).OrderByDescending(Class26.class26_0.method_0).ThenByDescending(Class26.class26_0.method_1)
					.FirstOrDefault();
				if (jobject_0 == null)
				{
					throw new InvalidDataException(Class185.smethod_0(-1141293183));
				}
				JToken obj3 = jobject_0[Class185.smethod_0(-1141293233)];
				List<JObject> list = ((IEnumerable)((obj3 is JArray) ? obj3 : null))?.OfType<JObject>().Where(Class26.class26_0.method_2).ToList();
				if (list != null && list.Count == 1)
				{
					jobject_1 = list[0];
					long_0 = smethod_19(jobject_0[Class185.smethod_0(-1141293578)], Class185.smethod_0(-1141293326));
					long_1 = smethod_19(jobject_1[Class185.smethod_0(-1141293578)], Class185.smethod_0(-1141293351));
					long_2 = smethod_20(jobject_1[Class185.smethod_0(-1141293374)], Class185.smethod_0(-1141293377), 1L, 1048576L);
					awaiter = smethod_11(httpClient_0, string_3 + Class185.smethod_0(-1141293797) + long_1, Class185.smethod_0(-1141293821), 1048576, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						configuredTaskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0397;
				}
				throw new InvalidDataException(Class185.smethod_0(-1141293254));
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				class23_0 = null;
				string_3 = null;
				list_0 = null;
				jobject_0 = null;
				jobject_1 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			class23_0 = null;
			string_3 = null;
			list_0 = null;
			jobject_0 = null;
			jobject_1 = null;
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

	internal static Task<Class438> smethod_0(string string_0, string string_1, string string_2, string string_3, string string_4, CancellationToken cancellationToken_0)
	{
		return smethod_1(string_0, string_1, string_2, string_3, string_4, cancellationToken_0, null);
	}

	internal static async Task<Class438> smethod_1(string string_0, string string_1, string string_2, string string_3, string string_4, CancellationToken cancellationToken_0, HttpMessageHandler httpMessageHandler_0)
	{
		smethod_16(string_0, Class185.smethod_0(-1141293709));
		smethod_16(string_1, Class185.smethod_0(-1141293713));
		smethod_16(string_2, Class185.smethod_0(-1141293730));
		string string_5 = Class382.smethod_1(string_3);
		HttpClient val = smethod_3(string_4, httpMessageHandler_0);
		try
		{
			return smethod_8(await smethod_7(val, string_0, string_1, string_2, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false), string_5);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	internal static async Task<Class345> smethod_2(HttpClient httpClient_0, string string_0, string string_1, string string_2, long long_0, long long_1, long long_2, string string_3, CancellationToken cancellationToken_0)
	{
		Class22 @class = new Class22
		{
			long_0 = long_1
		};
		smethod_16(string_0, Class185.smethod_0(-1141293709));
		smethod_16(string_1, Class185.smethod_0(-1141293713));
		smethod_16(string_2, Class185.smethod_0(-1141293730));
		smethod_17(long_0, @class.long_0, long_2, string_3);
		string text = smethod_15(string_0, string_1);
		Encoding uTF = Encoding.UTF8;
		JObject val = JObject.Parse(uTF.GetString(await smethod_11(httpClient_0, text + Class185.smethod_0(-1141294715) + long_0, Class185.smethod_0(-1141293085), 1048576, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false)));
		if ((long?)val[Class185.smethod_0(-1141293578)] != long_0 || (bool?)val[Class185.smethod_0(-1141293634)] == true || (bool?)val[Class185.smethod_0(-1141293654)] == true || !(((string)val[Class185.smethod_0(-1141293671)]) ?? string.Empty).StartsWith(Class185.smethod_0(-1141293686) + string_2 + Class185.smethod_0(-1141293701), StringComparison.Ordinal))
		{
			throw new InvalidDataException(Class185.smethod_0(-1141294732));
		}
		JToken obj = val[Class185.smethod_0(-1141293233)];
		JObject val2 = ((IEnumerable)((obj is JArray) ? obj : null))?.OfType<JObject>().SingleOrDefault(@class.method_0);
		if (val2 == null || (long?)val2[Class185.smethod_0(-1141293374)] != long_2 || long_2 <= 0L || long_2 > 1048576L)
		{
			throw new InvalidDataException(Class185.smethod_0(-1141294789));
		}
		byte[] array = await smethod_11(httpClient_0, text + Class185.smethod_0(-1141293797) + @class.long_0, Class185.smethod_0(-1141293821), 1048576, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false);
		if (array.LongLength == (long)val2[Class185.smethod_0(-1141293374)] && smethod_26(smethod_24(array), string_3))
		{
			string text2 = (string)val2[Class185.smethod_0(-1141293458)];
			if (!string.IsNullOrEmpty(text2) && !smethod_26(text2, Class185.smethod_0(-1141293479) + string_3))
			{
				throw new InvalidDataException(Class185.smethod_0(-1141294918));
			}
			Class345 class2 = smethod_9(array, string_2, long_0, @class.long_0);
			class2.string_4 = smethod_22(val[Class185.smethod_0(-1141293557)]);
			using (IEnumerator<Class94> enumerator = class2.ireadOnlyList_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class25 class3 = new Class25
					{
						class94_0 = enumerator.Current
					};
					uTF = Encoding.UTF8;
					JObject val3 = JObject.Parse(uTF.GetString(await smethod_11(httpClient_0, text + Class185.smethod_0(-1141294715) + class3.class94_0.Int64_1, Class185.smethod_0(-1141293085), 1048576, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false)));
					if ((long?)val3[Class185.smethod_0(-1141293578)] != class3.class94_0.Int64_1 || (bool?)val3[Class185.smethod_0(-1141293634)] == true || (bool?)val3[Class185.smethod_0(-1141293654)] == true)
					{
						throw new InvalidDataException(Class185.smethod_0(-1141294983));
					}
					JToken obj2 = val3[Class185.smethod_0(-1141293233)];
					JObject val4 = ((IEnumerable)((obj2 is JArray) ? obj2 : null))?.OfType<JObject>().SingleOrDefault(class3.method_0);
					if (val4 != null && (long?)val4[Class185.smethod_0(-1141293374)] == class3.class94_0.Int64_0)
					{
						string text3 = (string)val4[Class185.smethod_0(-1141293458)];
						if (!string.IsNullOrEmpty(text3) && !smethod_26(text3, Class185.smethod_0(-1141293479) + class3.class94_0.String_2))
						{
							throw new InvalidDataException(Class185.smethod_0(-1141295099));
						}
						continue;
					}
					throw new InvalidDataException(Class185.smethod_0(-1141295033));
				}
			}
			return class2;
		}
		throw new InvalidDataException(Class185.smethod_0(-1141294834));
	}

	internal static HttpClient smethod_3(string string_0, HttpMessageHandler httpMessageHandler_0)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(string_0) || string_0.Length > 4096 || string_0.IndexOfAny(new char[3] { '\r', '\n', '\0' }) >= 0)
		{
			throw new ArgumentException(Class185.smethod_0(-1141294222), Class185.smethod_0(-1141294262));
		}
		HttpClient val = new HttpClient((HttpMessageHandler)(object)new Class166((HttpMessageHandler)(((object)httpMessageHandler_0) ?? ((object)new HttpClientHandler
		{
			AllowAutoRedirect = false
		})), string_0))
		{
			Timeout = Timeout.InfiniteTimeSpan
		};
		val.DefaultRequestHeaders.UserAgent.ParseAdd(Class185.smethod_0(-1141294265));
		((HttpHeaders)val.DefaultRequestHeaders).Add(Class185.smethod_0(-1141294303), Class185.smethod_0(-1141294322));
		return val;
	}

	internal static async Task<byte[]> smethod_4(HttpClient httpClient_0, string string_0, string string_1, long long_0, long long_1, string string_2, CancellationToken cancellationToken_0)
	{
		if (long_0 <= 0L || long_1 < 0L || long_1 > 536870912L)
		{
			throw new InvalidDataException(Class185.smethod_0(-1141293746));
		}
		byte[] array = await smethod_11(httpClient_0, smethod_15(string_0, string_1) + Class185.smethod_0(-1141293797) + long_0, Class185.smethod_0(-1141293821), checked((int)Math.Min(536870912L, long_1 + 1L)), cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false);
		if (array.LongLength != long_1 || !smethod_26(smethod_24(array), string_2))
		{
			throw new InvalidDataException(Class185.smethod_0(-1141293844));
		}
		return array;
	}

	internal static async Task smethod_5(HttpClient httpClient_0, string string_0, string string_1, long long_0, long long_1, string string_2, string string_3, CancellationToken cancellationToken_0)
	{
		if (long_0 > 0L && long_1 >= 0L && long_1 <= 536870912L && smethod_18(string_2))
		{
			string text = smethod_15(string_0, string_1) + Class185.smethod_0(-1141293797) + long_0;
			smethod_13(new Uri(text), bool_0: false);
			using (CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken_0))
			{
				HttpRequestMessage val = new HttpRequestMessage(HttpMethod.Get, text);
				try
				{
					cancellationTokenSource.CancelAfter(TimeSpan.FromMinutes(10.0));
					val.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(Class185.smethod_0(-1141293821)));
					await smethod_6(httpClient_0, val, string_3, long_1, string_2, cancellationTokenSource.Token, bool_0: true).ConfigureAwait(continueOnCapturedContext: false);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			return;
		}
		throw new InvalidDataException(Class185.smethod_0(-1141293746));
	}

	private static async Task smethod_6(HttpClient httpClient_0, HttpRequestMessage httpRequestMessage_0, string string_0, long long_0, string string_1, CancellationToken cancellationToken_0, bool bool_0)
	{
		HttpResponseMessage val = await httpClient_0.SendAsync(httpRequestMessage_0, (HttpCompletionOption)1, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false);
		try
		{
			if (smethod_14(val.StatusCode) && bool_0)
			{
				Uri location = val.Headers.Location;
				smethod_13(location, bool_0: true);
				HttpRequestMessage val2 = new HttpRequestMessage(HttpMethod.Get, location);
				try
				{
					val2.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(Class185.smethod_0(-1141293821)));
					await smethod_6(httpClient_0, val2, string_0, long_0, string_1, cancellationToken_0, bool_0: false).ConfigureAwait(continueOnCapturedContext: false);
					return;
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			if (!val.IsSuccessStatusCode)
			{
				throw new HttpRequestException(Class185.smethod_0(-1141293914) + (int)val.StatusCode + Class185.smethod_0(-1141293956));
			}
			if (val.Content.Headers.ContentLength.HasValue && val.Content.Headers.ContentLength.Value != long_0)
			{
				throw new InvalidDataException(Class185.smethod_0(-1141293973));
			}
			try
			{
				using Stream stream = await val.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
				using FileStream fileStream = new FileStream(string_0, FileMode.CreateNew, FileAccess.Write, FileShare.None);
				using SHA256 sHA = SHA256.Create();
				byte[] array = new byte[81920];
				long num = 0L;
				int num2;
				while ((num2 = await stream.ReadAsync(array, 0, array.Length, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false)) != 0)
				{
					num = checked(num + num2);
					if (num <= long_0)
					{
						sHA.TransformBlock(array, 0, num2, null, 0);
						fileStream.Write(array, 0, num2);
						continue;
					}
					throw new InvalidDataException(Class185.smethod_0(-1141294017));
				}
				sHA.TransformFinalBlock(new byte[0], 0, 0);
				fileStream.Flush(flushToDisk: true);
				string string_2 = BitConverter.ToString(sHA.Hash).Replace(Class185.smethod_0(-1141293701), string.Empty).ToLowerInvariant();
				if (num == long_0 && smethod_26(string_2, string_1))
				{
					return;
				}
				throw new InvalidDataException(Class185.smethod_0(-1141293844));
			}
			catch
			{
				try
				{
					if (File.Exists(string_0))
					{
						File.Delete(string_0);
					}
				}
				catch
				{
				}
				throw;
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private static async Task<Class345> smethod_7(HttpClient httpClient_0, string string_0, string string_1, string string_2, CancellationToken cancellationToken_0)
	{
		Class23 @class = new Class23
		{
			string_0 = string_2
		};
		string text = smethod_15(string_0, string_1);
		List<JObject> list = new List<JObject>();
		for (int i = 1; i <= 10; i++)
		{
			byte[] bytes = await smethod_11(httpClient_0, text + Class185.smethod_0(-1141294066) + i, Class185.smethod_0(-1141293085), 16777216, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false);
			JArray val = JArray.Parse(Encoding.UTF8.GetString(bytes));
			list.AddRange(((IEnumerable)val).OfType<JObject>());
			if (((JContainer)val).Count < 100)
			{
				break;
			}
			if (i == 10)
			{
				throw new InvalidDataException(Class185.smethod_0(-1141293119));
			}
		}
		JObject val2 = list.Where(@class.method_0).OrderByDescending(Class26.class26_0.method_0).ThenByDescending(Class26.class26_0.method_1)
			.FirstOrDefault();
		if (val2 == null)
		{
			throw new InvalidDataException(Class185.smethod_0(-1141293183));
		}
		JToken obj = val2[Class185.smethod_0(-1141293233)];
		List<JObject> list2 = ((IEnumerable)((obj is JArray) ? obj : null))?.OfType<JObject>().Where(Class26.class26_0.method_2).ToList();
		if (list2 != null && list2.Count == 1)
		{
			JObject val3 = list2[0];
			long long_ = smethod_19(val2[Class185.smethod_0(-1141293578)], Class185.smethod_0(-1141293326));
			long long_2 = smethod_19(val3[Class185.smethod_0(-1141293578)], Class185.smethod_0(-1141293351));
			long num = smethod_20(val3[Class185.smethod_0(-1141293374)], Class185.smethod_0(-1141293377), 1L, 1048576L);
			byte[] obj2 = await smethod_11(httpClient_0, text + Class185.smethod_0(-1141293797) + long_2, Class185.smethod_0(-1141293821), 1048576, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false);
			if (obj2.LongLength != num)
			{
				throw new InvalidDataException(Class185.smethod_0(-1141293396));
			}
			string text2 = smethod_24(obj2);
			string text3 = (string)val3[Class185.smethod_0(-1141293458)];
			if (!string.IsNullOrEmpty(text3) && !smethod_26(text3, Class185.smethod_0(-1141293479) + text2))
			{
				throw new InvalidDataException(Class185.smethod_0(-1141293493));
			}
			Class345 class2 = smethod_9(obj2, @class.string_0, long_, long_2);
			class2.string_4 = smethod_22(val2[Class185.smethod_0(-1141293557)]);
			using IEnumerator<Class94> enumerator = class2.ireadOnlyList_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Class24 class3 = new Class24();
				class3.class94_0 = enumerator.Current;
				JObject obj3 = list.SingleOrDefault(class3.method_0);
				JToken obj4 = ((obj3 != null) ? obj3[Class185.smethod_0(-1141293233)] : null);
				JObject val4 = ((IEnumerable)((obj4 is JArray) ? obj4 : null))?.OfType<JObject>().SingleOrDefault(class3.method_1);
				if (val4 != null && (long?)val4[Class185.smethod_0(-1141293374)] == class3.class94_0.Int64_0)
				{
					string text4 = (string)val4[Class185.smethod_0(-1141293458)];
					if (!string.IsNullOrEmpty(text4) && !smethod_26(text4, Class185.smethod_0(-1141293479) + class3.class94_0.String_2))
					{
						throw new InvalidDataException(Class185.smethod_0(-1141294663));
					}
					continue;
				}
				throw new InvalidDataException(Class185.smethod_0(-1141293568));
			}
			return class2;
		}
		throw new InvalidDataException(Class185.smethod_0(-1141293254));
	}

	private static Class438 smethod_8(Class345 class345_0, string string_0)
	{
		List<Class94> list = new List<Class94>();
		long num = 0L;
		foreach (Class94 item in class345_0.ireadOnlyList_0.OrderBy(Class26.class26_0.method_3, StringComparer.OrdinalIgnoreCase).ThenBy(Class26.class26_0.method_4, StringComparer.Ordinal))
		{
			string text = Class382.smethod_2(string_0, item.String_0);
			Class94 @class = smethod_27(item);
			if (!File.Exists(text))
			{
				@class.String_3 = Class185.smethod_0(-1141294339);
			}
			else
			{
				FileInfo fileInfo = new FileInfo(text);
				@class.Nullable_0 = fileInfo.Length;
				@class.String_4 = smethod_25(text);
				@class.String_3 = ((fileInfo.Length != item.Int64_0 || !smethod_26(@class.String_4, item.String_2)) ? Class185.smethod_0(-1141294353) : Class185.smethod_0(-1141293618));
			}
			if (@class.String_3 != Class185.smethod_0(-1141293618))
			{
				num = checked(num + @class.Int64_0);
			}
			list.Add(@class);
		}
		List<Class94> list2 = list.Where(Class26.class26_0.method_5).ToList();
		return new Class438
		{
			String_0 = class345_0.string_0,
			String_1 = class345_0.string_1,
			Int64_0 = class345_0.long_0,
			Int64_1 = class345_0.long_1,
			String_2 = class345_0.string_3,
			Int64_2 = class345_0.long_2,
			String_3 = class345_0.string_2,
			IReadOnlyList_0 = list,
			IReadOnlyList_1 = list2,
			Boolean_0 = (list2.Count != 0),
			Int64_3 = num,
			String_4 = (class345_0.string_4 ?? string.Empty)
		};
	}

	private static Class345 smethod_9(byte[] byte_0, string string_0, long long_0, long long_1)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		if (byte_0.Length > 1048576)
		{
			throw new InvalidDataException(Class185.smethod_0(-1141294374));
		}
		string text = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true).GetString(byte_0).TrimStart('\ufeff');
		JsonTextReader val = new JsonTextReader((TextReader)new StringReader(text));
		try
		{
			while (((JsonReader)val).Read())
			{
				if ((int)((JsonReader)val).TokenType == 5)
				{
					throw new InvalidDataException(Class185.smethod_0(-1141294395));
				}
			}
		}
		finally
		{
			((IDisposable)val).Dispose();
		}
		JObject val2 = JObject.Parse(text, new JsonLoadSettings
		{
			DuplicatePropertyNameHandling = (DuplicatePropertyNameHandling)2
		});
		smethod_23(val2, new string[4]
		{
			Class185.smethod_0(-1141294448),
			Class185.smethod_0(-1141293730),
			Class185.smethod_0(-1141294460),
			Class185.smethod_0(-1141294482)
		});
		if ((int)val2[Class185.smethod_0(-1141294448)].Type == 6 && (int)val2[Class185.smethod_0(-1141294448)] == 2)
		{
			string text2 = smethod_21(val2[Class185.smethod_0(-1141293730)], Class185.smethod_0(-1141293730), 128);
			if (!string.Equals(text2, string_0, StringComparison.Ordinal))
			{
				throw new InvalidDataException(Class185.smethod_0(-1141294551));
			}
			string string_1 = smethod_21(val2[Class185.smethod_0(-1141294460)], Class185.smethod_0(-1141294460), 512);
			JToken obj = val2[Class185.smethod_0(-1141294482)];
			JArray val3 = (JArray)(object)((obj is JArray) ? obj : null);
			if (val3 != null && ((JContainer)val3).Count <= 4096)
			{
				HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
				List<Class94> list = new List<Class94>();
				foreach (JToken item in val3)
				{
					JObject val4 = (JObject)(object)((item is JObject) ? item : null);
					if (val4 != null)
					{
						smethod_23(val4, new string[6]
						{
							Class185.smethod_0(-1141299812),
							Class185.smethod_0(-1141299831),
							Class185.smethod_0(-1141293374),
							Class185.smethod_0(-1141299845),
							Class185.smethod_0(-1141299850),
							Class185.smethod_0(-1141299866)
						});
						string text3 = smethod_21(val4[Class185.smethod_0(-1141299812)], Class185.smethod_0(-1141299812), 512);
						Class382.smethod_0(text3);
						if (hashSet.Add(text3))
						{
							string text4 = smethod_21(val4[Class185.smethod_0(-1141299845)], Class185.smethod_0(-1141299845), 64);
							if (smethod_18(text4))
							{
								list.Add(new Class94
								{
									String_0 = text3,
									String_1 = smethod_21(val4[Class185.smethod_0(-1141299831)], Class185.smethod_0(-1141299831), 512),
									Int64_0 = smethod_20(val4[Class185.smethod_0(-1141293374)], Class185.smethod_0(-1141293374), 0L, 536870912L),
									String_2 = text4.ToLowerInvariant(),
									Int64_1 = smethod_19(val4[Class185.smethod_0(-1141299850)], Class185.smethod_0(-1141299850)),
									Int64_2 = smethod_19(val4[Class185.smethod_0(-1141299866)], Class185.smethod_0(-1141299866))
								});
								continue;
							}
							throw new InvalidDataException(Class185.smethod_0(-1141299935));
						}
						throw new InvalidDataException(Class185.smethod_0(-1141299888));
					}
					throw new InvalidDataException(Class185.smethod_0(-1141299776));
				}
				HashSet<string> hashSet2 = new HashSet<string>(list.Select(Class26.class26_0.method_6), StringComparer.OrdinalIgnoreCase);
				foreach (string item2 in hashSet2)
				{
					string text5 = item2;
					while (text5.Contains(Class185.smethod_0(-1141300031)))
					{
						text5 = text5.Substring(0, text5.LastIndexOf('/'));
						if (hashSet2.Contains(text5))
						{
							throw new InvalidDataException(Class185.smethod_0(-1141299961));
						}
					}
				}
				return new Class345
				{
					string_0 = text2,
					string_1 = string_1,
					string_2 = ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()),
					string_3 = smethod_24(byte_0),
					long_2 = byte_0.LongLength,
					long_0 = long_0,
					long_1 = long_1,
					ireadOnlyList_0 = list
				};
			}
			throw new InvalidDataException(Class185.smethod_0(-1141299723));
		}
		throw new InvalidDataException(Class185.smethod_0(-1141294502));
	}

	internal static Class345 smethod_10(byte[] byte_0, string string_0)
	{
		return smethod_9(byte_0, string_0, 1L, 1L);
	}

	private static async Task<byte[]> smethod_11(HttpClient httpClient_0, string string_0, string string_1, int int_0, CancellationToken cancellationToken_0)
	{
		smethod_13(new Uri(string_0), bool_0: false);
		using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken_0);
		HttpRequestMessage val = new HttpRequestMessage(HttpMethod.Get, string_0);
		try
		{
			cancellationTokenSource.CancelAfter(TimeSpan.FromMinutes(10.0));
			val.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(string_1));
			return await smethod_12(httpClient_0, val, int_0, cancellationTokenSource.Token, bool_0: true).ConfigureAwait(continueOnCapturedContext: false);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private static async Task<byte[]> smethod_12(HttpClient httpClient_0, HttpRequestMessage httpRequestMessage_0, int int_0, CancellationToken cancellationToken_0, bool bool_0)
	{
		HttpResponseMessage val = await httpClient_0.SendAsync(httpRequestMessage_0, (HttpCompletionOption)1, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false);
		try
		{
			if (smethod_14(val.StatusCode) && bool_0)
			{
				Uri location = val.Headers.Location;
				smethod_13(location, bool_0: true);
				HttpRequestMessage val2 = new HttpRequestMessage(HttpMethod.Get, location);
				try
				{
					return await smethod_12(httpClient_0, val2, int_0, cancellationToken_0, bool_0: false).ConfigureAwait(continueOnCapturedContext: false);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			if (!val.IsSuccessStatusCode)
			{
				throw new HttpRequestException(Class185.smethod_0(-1141294131) + (int)val.StatusCode + Class185.smethod_0(-1141293956));
			}
			if (val.Content.Headers.ContentLength > int_0)
			{
				throw new InvalidDataException(Class185.smethod_0(-1141294163));
			}
			using Stream stream = await val.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			using MemoryStream memoryStream = new MemoryStream();
			byte[] array = new byte[81920];
			while (true)
			{
				int num;
				if ((num = await stream.ReadAsync(array, 0, array.Length, cancellationToken_0).ConfigureAwait(continueOnCapturedContext: false)) != 0)
				{
					if (memoryStream.Length + num > int_0)
					{
						break;
					}
					memoryStream.Write(array, 0, num);
					continue;
				}
				return memoryStream.ToArray();
			}
			throw new InvalidDataException(Class185.smethod_0(-1141294163));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private static void smethod_13(Uri uri_0, bool bool_0)
	{
		if (!(uri_0 == null) && uri_0.IsAbsoluteUri && !(uri_0.Scheme != Uri.UriSchemeHttps))
		{
			if (string.IsNullOrEmpty(uri_0.UserInfo) && uri_0.IsDefaultPort)
			{
				bool num;
				if (bool_0)
				{
					if (uri_0.Host == Class185.smethod_0(-1141300136) || uri_0.Host.EndsWith(Class185.smethod_0(-1141300164), StringComparison.Ordinal) || uri_0.Host == Class185.smethod_0(-1141300201))
					{
						return;
					}
					num = uri_0.Host.EndsWith(Class185.smethod_0(-1141299220), StringComparison.Ordinal);
				}
				else
				{
					num = uri_0.Host == Class185.smethod_0(-1141296605);
				}
				if (!num)
				{
					throw new InvalidDataException(Class185.smethod_0(-1141299272));
				}
				return;
			}
			throw new InvalidDataException(Class185.smethod_0(-1141300075));
		}
		throw new InvalidDataException(Class185.smethod_0(-1141300039));
	}

	private static bool smethod_14(HttpStatusCode httpStatusCode_0)
	{
		if (httpStatusCode_0 != HttpStatusCode.MovedPermanently && httpStatusCode_0 != HttpStatusCode.Found && httpStatusCode_0 != HttpStatusCode.SeeOther && httpStatusCode_0 != HttpStatusCode.TemporaryRedirect)
		{
			return httpStatusCode_0 == (HttpStatusCode)308;
		}
		return true;
	}

	private static string smethod_15(string string_0, string string_1)
	{
		return Class185.smethod_0(-1141299315) + string_0 + Class185.smethod_0(-1141300031) + string_1;
	}

	private static void smethod_16(string string_0, string string_1)
	{
		if (string.IsNullOrWhiteSpace(string_0) || string_0.Length > 128 || string_0.Any(Class26.class26_0.method_7))
		{
			throw new ArgumentException(Class185.smethod_0(-1141299359) + string_1 + Class185.smethod_0(-1141299374));
		}
	}

	private static void smethod_17(long long_0, long long_1, long long_2, string string_0)
	{
		if (long_0 <= 0L || long_1 <= 0L || long_2 <= 0L || long_2 > 1048576L || !smethod_18(string_0))
		{
			throw new ArgumentException(Class185.smethod_0(-1141299382));
		}
	}

	private static bool smethod_18(string string_0)
	{
		if (string_0 != null && string_0.Length == 64)
		{
			return string_0.All(Uri.IsHexDigit);
		}
		return false;
	}

	private static long smethod_19(JToken jtoken_0, string string_0)
	{
		return smethod_20(jtoken_0, string_0, 1L, long.MaxValue);
	}

	private static long smethod_20(JToken jtoken_0, string string_0, long long_0, long long_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		if (jtoken_0 == null || (int)jtoken_0.Type != 6 || !long.TryParse(jtoken_0.ToString((Formatting)0, Array.Empty<JsonConverter>()), NumberStyles.None, CultureInfo.InvariantCulture, out var result) || result < long_0 || result > long_1)
		{
			throw new InvalidDataException(Class185.smethod_0(-1141299421) + string_0 + Class185.smethod_0(-1141299374));
		}
		return result;
	}

	private static string smethod_21(JToken jtoken_0, string string_0, int int_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		string text = ((jtoken_0 == null || (int)jtoken_0.Type != 8) ? null : ((string)jtoken_0));
		if (string.IsNullOrWhiteSpace(text) || text.Length > int_0)
		{
			throw new InvalidDataException(Class185.smethod_0(-1141299421) + string_0 + Class185.smethod_0(-1141299374));
		}
		return text;
	}

	private static string smethod_22(JToken jtoken_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		if (jtoken_0 != null && (int)jtoken_0.Type != 10)
		{
			if ((int)jtoken_0.Type != 8)
			{
				return string.Empty;
			}
			string text = (((string)jtoken_0) ?? string.Empty).Replace(Class185.smethod_0(-1141299436), string.Empty);
			if (string.Equals(text, Class185.smethod_0(-1141299444), StringComparison.Ordinal))
			{
				return string.Empty;
			}
			if (text.Length <= 8192)
			{
				return text;
			}
			int num = 8192;
			if (char.IsHighSurrogate(text[8191]) && char.IsLowSurrogate(text[num]))
			{
				num--;
			}
			return text.Substring(0, num);
		}
		return string.Empty;
	}

	private static void smethod_23(JObject jobject_0, string[] string_0)
	{
		Class27 @class = new Class27();
		@class.jobject_0 = jobject_0;
		@class.string_0 = string_0;
		if (((JContainer)@class.jobject_0).Count != @class.string_0.Length || @class.string_0.Any(@class.method_0) || @class.jobject_0.Properties().Any(@class.method_1))
		{
			throw new InvalidDataException(Class185.smethod_0(-1141299535));
		}
	}

	internal static string smethod_24(byte[] byte_0)
	{
		using SHA256 sHA = SHA256.Create();
		return BitConverter.ToString(sHA.ComputeHash(byte_0)).Replace(Class185.smethod_0(-1141293701), string.Empty).ToLowerInvariant();
	}

	internal static string smethod_25(string string_0)
	{
		using SHA256 sHA = SHA256.Create();
		FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		try
		{
			return BitConverter.ToString(sHA.ComputeHash(fileStream)).Replace(Class185.smethod_0(-1141293701), string.Empty).ToLowerInvariant();
		}
		finally
		{
			((IDisposable)fileStream).Dispose();
		}
	}

	internal static bool smethod_26(string string_0, string string_1)
	{
		if (string_0 != null && string_1 != null && string_0.Length == string_1.Length)
		{
			int num = 0;
			for (int i = 0; i < string_0.Length; i++)
			{
				num |= char.ToUpperInvariant(string_0[i]) ^ char.ToUpperInvariant(string_1[i]);
			}
			return num == 0;
		}
		return false;
	}

	private static Class94 smethod_27(Class94 class94_0)
	{
		return new Class94
		{
			String_0 = class94_0.String_0,
			String_1 = class94_0.String_1,
			Int64_0 = class94_0.Int64_0,
			String_2 = class94_0.String_2,
			Int64_1 = class94_0.Int64_1,
			Int64_2 = class94_0.Int64_2
		};
	}
}
