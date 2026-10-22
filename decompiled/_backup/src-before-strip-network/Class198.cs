using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

internal static class Class198
{
	private sealed class Class199
	{
		public List<string> list_0;

		public Class119 class119_0;

		public long long_0;

		public List<string> list_1;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
			JObject jObject = JObject.Parse(string_0);
			if ((string?)jObject["cmd"] == "pick")
			{
				class119_0.method_145((uint)jObject["id"], (byte)jObject["type"], (uint)jObject["req"], bool_17: true, null);
			}
		}

		internal long method_1()
		{
			return long_0;
		}

		internal void method_2(string string_0)
		{
			list_0.Add(string_0);
		}

		internal long method_3()
		{
			return long_0;
		}

		internal void method_4(string string_0)
		{
			list_1.Add(string_0);
		}
	}

	private sealed class Class200
	{
		public Class339 class339_0;

		public int int_0;

		internal void method_0(string string_0)
		{
			if (string_0.IndexOf("\"cmd\":\"census_raw\"", StringComparison.Ordinal) >= 0)
			{
				int_0++;
				class339_0.method_0(new List<Class403>(), null);
			}
		}
	}

	private sealed class Class201
	{
		public string string_0;

		public int int_0;

		internal Class175 method_0()
		{
			int_0++;
			return new Class175("secret-license", string_0, "ran-origin", "https://worker.example");
		}
	}

	private sealed class Class202<T> : IEnumerable<T>, IReadOnlyList<T>, IReadOnlyCollection<T>, IEnumerable
	{
		private readonly IReadOnlyList<T> ireadOnlyList_0;

		private readonly int int_0;

		private readonly Action action_0;

		private int int_1;

		public int Count
		{
			get
			{
				int_1++;
				if (int_1 == int_0 && action_0 != null)
				{
					action_0();
				}
				return ireadOnlyList_0.Count;
			}
		}

		public T this[int index] => ireadOnlyList_0[index];

		internal Class202(IReadOnlyList<T> ireadOnlyList_1, int int_2, Action action_1)
		{
			ireadOnlyList_0 = ireadOnlyList_1;
			int_0 = int_2;
			action_0 = action_1;
		}

		internal bool method_0()
		{
			return int_1 >= int_0;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return ireadOnlyList_0.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	private sealed class Class203
	{
		public long long_0;

		public int int_0;

		internal long method_0()
		{
			return long_0;
		}

		internal Task method_1(int int_1)
		{
			int_0++;
			long_0 += int_1;
			return Task.CompletedTask;
		}
	}

	private sealed class Class204
	{
		public List<string> list_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
		}
	}

	private sealed class Class205
	{
		public List<string> list_0;

		public long long_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
		}

		internal long method_1()
		{
			return long_0;
		}

		internal Task method_2(int int_0)
		{
			long_0 += int_0;
			return Task.CompletedTask;
		}

		internal long method_3()
		{
			return long_0;
		}

		internal Task method_4(int int_0)
		{
			long_0 += int_0;
			return Task.CompletedTask;
		}

		internal long method_5()
		{
			return long_0;
		}

		internal Task method_6(int int_0)
		{
			long_0 += int_0;
			return Task.CompletedTask;
		}
	}

	private sealed class Class206
	{
		internal readonly string string_0 = new string('0', 64);

		internal string string_1;

		internal string string_2;

		internal bool bool_0;

		internal bool bool_1;

		internal bool bool_2;

		internal bool bool_3;

		internal bool bool_4;

		internal bool bool_5;

		internal bool bool_6;

		internal int int_0;

		private readonly long long_0;

		private readonly string string_3;

		internal Class206(long long_1, string string_4)
		{
			long_0 = long_1;
			string_3 = string_4;
			string_1 = string_0;
			string_2 = string_0;
		}

		internal Class71.Class72 method_0(string string_4, string string_5, string string_6, int int_1)
		{
			if (string_6 == "get-state")
			{
				return Class71.Class72.smethod_0("device");
			}
			if (string_6.Contains("id -u"))
			{
				return Class71.Class72.smethod_0("0");
			}
			if (string_6.Contains("pidof .klxsvc"))
			{
				return Class71.Class72.smethod_0(bool_6 ? "1234" : string.Empty);
			}
			if (string_6.StartsWith("push "))
			{
				int_0++;
				if (!bool_0)
				{
					return Class71.Class72.smethod_0("pushed");
				}
				return Class71.Class72.smethod_1("no space left on device");
			}
			if (string_6.Contains("test -f"))
			{
				return Class71.Class72.smethod_0("PRESENT");
			}
			if (string_6.Contains("stat -c %s"))
			{
				return Class71.Class72.smethod_0(long_0.ToString());
			}
			if (string_6.Contains("sha256sum"))
			{
				return Class71.Class72.smethod_0((string_6.Contains(".upload.") ? string_3 : string_1) + "  runner");
			}
			if (string_6.Contains("cat /data/local/tmp/.klxsvc.id.upload."))
			{
				return Class71.Class72.smethod_0(string_3);
			}
			if (string_6.Contains("cat /data/local/tmp/.klxsvc.id"))
			{
				return Class71.Class72.smethod_0(string_2);
			}
			if (string_6.Contains("echo ") && string_6.Contains(".id.upload."))
			{
				if (!bool_2)
				{
					return Class71.Class72.smethod_0(string.Empty);
				}
				return Class71.Class72.smethod_1("read-only file system");
			}
			if (string_6.Contains("mv /data/local/tmp/.klxsvc.upload."))
			{
				if (bool_3)
				{
					string_1 = string_3;
					bool_4 = true;
					return Class71.Class72.smethod_1("runner move failed");
				}
				string_1 = string_3;
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_6.Contains("mv /data/local/tmp/.klxsvc.id.upload."))
			{
				if (bool_5)
				{
					return Class71.Class72.smethod_1("marker move failed");
				}
				string_2 = string_3;
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_6.Contains("mv /data/local/tmp/.klxsvc.backup."))
			{
				string_1 = string_0;
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_6.Contains("mv /data/local/tmp/.klxsvc.id.backup."))
			{
				string_2 = string_0;
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_6.Contains("rm -f ") && string_6.Contains(".klxsvc.upload.") && bool_1)
			{
				return Class71.Class72.smethod_1("device disconnected");
			}
			if (!string_6.Contains("chmod ") && !string_6.Contains("ln ") && !string_6.Contains("rm -f"))
			{
				return Class71.Class72.smethod_1("unexpected command: " + string_6);
			}
			return Class71.Class72.smethod_0(string.Empty);
		}
	}

	private sealed class Class207
	{
		public int int_0;

		public List<string> list_0;

		internal void method_0()
		{
			Interlocked.Increment(ref int_0);
		}

		internal bool method_1()
		{
			return list_0.Exists(Class299.class299_0.method_111);
		}
	}

	private sealed class Class208
	{
		public Class438 class438_0;

		internal Task<Class438> method_0(string string_0, CancellationToken cancellationToken_0)
		{
			return Task.FromResult(class438_0);
		}
	}

	private sealed class Class209
	{
		public long long_0;

		internal long method_0()
		{
			return long_0;
		}
	}

	private sealed class Class210<T> : IEnumerable<T>, IReadOnlyList<T>, IReadOnlyCollection<T>, IEnumerable
	{
		private readonly IReadOnlyList<T> ireadOnlyList_0;

		private readonly Action action_0;

		private bool bool_0;

		public int Count
		{
			get
			{
				if (!bool_0)
				{
					bool_0 = true;
					if (action_0 != null)
					{
						action_0();
					}
				}
				return ireadOnlyList_0.Count;
			}
		}

		public T this[int index] => ireadOnlyList_0[index];

		internal Class210(IReadOnlyList<T> ireadOnlyList_1, Action action_1)
		{
			ireadOnlyList_0 = ireadOnlyList_1;
			action_0 = action_1;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return ireadOnlyList_0.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	private sealed class Class211
	{
		public List<string> list_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
		}
	}

	private sealed class Class212
	{
		public ManualResetEventSlim manualResetEventSlim_0;

		public ManualResetEventSlim manualResetEventSlim_1;

		internal void method_0()
		{
			manualResetEventSlim_0.Set();
			manualResetEventSlim_1.Wait(2000);
		}
	}

	private sealed class Class213
	{
		public List<string> list_0;

		public long long_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
		}

		internal long method_1()
		{
			return long_0;
		}

		internal void method_2(string string_0)
		{
			list_0.Add(string_0);
		}
	}

	private sealed class Class214
	{
		public Class119 class119_0;

		public int int_0;

		public Class335 class335_0;

		internal void method_0(string string_0)
		{
			if (string_0.IndexOf("\"cmd\":\"census_raw\"", StringComparison.Ordinal) >= 0)
			{
				int_0++;
				class335_0.class339_0.method_0(new List<Class403>(), null);
				class335_0.class339_0.method_3(class119_0);
			}
		}
	}

	private sealed class Class215
	{
		public Class270 class270_0;

		internal void method_0(string string_0, uint uint_0, string string_1, int int_0)
		{
			class270_0.list_0.Add(uint_0 + ":" + string_1);
		}
	}

	private sealed class Class216
	{
		public string string_0;

		public long long_0;

		public Func<string, string, string, int, Class71.Class72> func_0;

		public int int_0;

		public int int_1;

		internal Class71.Class72 method_0(string string_1, string string_2, string string_3, int int_2)
		{
			if (string_3 == "get-state")
			{
				return Class71.Class72.smethod_0("device");
			}
			if (string_3.Contains("id -u"))
			{
				return Class71.Class72.smethod_0("0");
			}
			if (string_3.Contains("test -f"))
			{
				return Class71.Class72.smethod_0("PRESENT");
			}
			if (string_3.Contains("cat /data/local/tmp/.klxsvc.id"))
			{
				return Class71.Class72.smethod_0(string_0);
			}
			if (string_3.Contains("stat -c %s"))
			{
				return Class71.Class72.smethod_0(long_0.ToString());
			}
			if (string_3.Contains("sha256sum"))
			{
				return Class71.Class72.smethod_0(string_0 + "  /data/local/tmp/.klxsvc");
			}
			return Class71.Class72.smethod_1("unexpected probe: " + string_3);
		}

		internal Class71.Class72 method_1(string string_1, string string_2, string string_3, int int_2)
		{
			if (!(string_3 == "get-state"))
			{
				return func_0(string_1, string_2, string_3, int_2);
			}
			return Class71.Class72.smethod_1("device offline");
		}

		internal Class71.Class72 method_2(string string_1, string string_2, string string_3, int int_2)
		{
			if (!string_3.Contains("test -f /data/local/tmp/.klxsvc;"))
			{
				return func_0(string_1, string_2, string_3, int_2);
			}
			return Class71.Class72.smethod_0("MISSING");
		}

		internal Class71.Class72 method_3(string string_1, string string_2, string string_3, int int_2)
		{
			if (!string_3.Contains("id -u"))
			{
				return func_0(string_1, string_2, string_3, int_2);
			}
			return Class71.Class72.smethod_1("su not ready");
		}

		internal Class71.Class72 method_4(string string_1, string string_2, string string_3, int int_2)
		{
			if (!string_3.Contains("stat -c %s"))
			{
				return func_0(string_1, string_2, string_3, int_2);
			}
			return Class71.Class72.smethod_0((long_0 - 1L).ToString());
		}

		internal Class71.Class72 method_5(string string_1, string string_2, string string_3, int int_2)
		{
			if (string_2 == "emulator-5556" && string_3.Contains("test -f /data/local/tmp/.klxsvc;"))
			{
				return Class71.Class72.smethod_0("MISSING");
			}
			return func_0(string_1, string_2, string_3, int_2);
		}

		internal Class71.Class72 method_6(string string_1, string string_2, string string_3, int int_2)
		{
			int_0++;
			int_1 = int_2;
			Thread.Sleep(80);
			return func_0(string_1, string_2, string_3, int_2);
		}
	}

	private sealed class Class217
	{
		public int int_0;

		internal void method_0()
		{
			Interlocked.Increment(ref int_0);
		}
	}

	private sealed class Class218 : IDisposable, Interface5
	{
		internal string string_0;

		internal double double_0;

		internal string string_1;

		internal int int_0;

		public Class50 imethod_0(byte[] byte_0)
		{
			int_0++;
			Class50 @class = new Class50();
			@class.method_1(string_0);
			@class.method_3(double_0);
			@class.method_7(string_1);
			@class.method_5(5);
			return @class;
		}

		public void Dispose()
		{
		}
	}

	private sealed class Class219
	{
		public Task task_0;

		internal bool method_0()
		{
			return task_0.IsCompleted;
		}
	}

	private sealed class Class220
	{
		public Class339 class339_0;

		public Class300 class300_0;

		internal Task method_0()
		{
			return (Task)class300_0.methodInfo_0.Invoke(class339_0.gform0_0, new object[2] { class339_0.class119_0, class339_0.long_0 });
		}
	}

	private sealed class Class221
	{
		public long long_0;

		internal long method_0()
		{
			return long_0;
		}
	}

	private sealed class Class222 : IDisposable
	{
		private static readonly FieldInfo fieldInfo_0 = typeof(GForm0).GetField("_session", BindingFlags.Instance | BindingFlags.NonPublic);

		private static readonly FieldInfo fieldInfo_1 = typeof(Class119).GetField("_world", BindingFlags.Instance | BindingFlags.NonPublic);

		private static readonly FieldInfo fieldInfo_2 = typeof(Class119).GetField("_readyRequest", BindingFlags.Instance | BindingFlags.NonPublic);

		private static readonly FieldInfo fieldInfo_3 = typeof(Class119).GetField("_pickArmed", BindingFlags.Instance | BindingFlags.NonPublic);

		internal readonly GForm0 gform0_0;

		internal readonly Class119 class119_0;

		internal Class222(Class119 class119_1)
		{
			gform0_0 = new GForm0();
			_ = gform0_0.Handle;
			class119_0 = class119_1;
			if (!(fieldInfo_0 == null) && !(fieldInfo_1 == null) && !(fieldInfo_2 == null) && !(fieldInfo_3 == null))
			{
				fieldInfo_0.SetValue(gform0_0, class119_1);
				if (class119_1 != null)
				{
					fieldInfo_3.SetValue(class119_1, true);
				}
				return;
			}
			throw new InvalidOperationException("LiveFormFixture reflection contract missing");
		}

		internal void method_0(Class145 class145_0, bool bool_0)
		{
			if (class119_0 != null)
			{
				fieldInfo_1.SetValue(class119_0, class145_0 ?? Class145.class145_0);
				fieldInfo_2.SetValue(class119_0, bool_0 ? 1 : 0);
			}
		}

		internal void method_1(Class119 class119_1, Class145 class145_0, bool bool_0)
		{
			if (class119_1 != null)
			{
				fieldInfo_1.SetValue(class119_1, class145_0 ?? Class145.class145_0);
				fieldInfo_2.SetValue(class119_1, bool_0 ? 1 : 0);
				fieldInfo_3.SetValue(class119_1, true);
			}
			fieldInfo_0.SetValue(gform0_0, class119_1);
		}

		internal void method_2(bool bool_0)
		{
			Class119 @class = gform0_0.method_7();
			if (@class != null)
			{
				fieldInfo_3.SetValue(@class, bool_0);
			}
		}

		internal DataGridView method_3()
		{
			return (DataGridView)gform0_0.Controls.Find("dataGridView3", searchAllChildren: true)[0];
		}

		internal void method_4(int int_0, int int_1, bool bool_0, string[] string_0)
		{
			int[] array = new int[6] { 1, 2, 3, 4, 5, 26 };
			for (int i = 0; i < array.Length; i++)
			{
				((RadioButton)gform0_0.Controls.Find("radioButton" + array[i], searchAllChildren: true)[0]).Checked = array[i] == int_0;
			}
			int[] array2 = new int[5] { 18, 19, 20, 21, 22 };
			for (int j = 0; j < array2.Length; j++)
			{
				((RadioButton)gform0_0.Controls.Find("radioButton" + array2[j], searchAllChildren: true)[0]).Checked = array2[j] == int_1;
			}
			int[] array3 = new int[8] { 29, 30, 31, 32, 33, 38, 43, 94 };
			for (int k = 0; k < array3.Length; k++)
			{
				((CheckBox)gform0_0.Controls.Find("checkBox" + array3[k], searchAllChildren: true)[0]).Checked = array3[k] == 43 && bool_0;
			}
			DataGridView dataGridView = method_3();
			dataGridView.Rows.Clear();
			if (string_0 != null)
			{
				for (int l = 0; l < string_0.Length; l++)
				{
					dataGridView.Rows.Add(string_0[l]);
				}
			}
		}

		internal void method_5(bool bool_0, int[] int_0)
		{
			((CheckBox)gform0_0.Controls.Find("checkBox69", searchAllChildren: true)[0]).Checked = bool_0;
			for (int i = 1; i <= 10; i++)
			{
				bool flag = int_0 != null && Array.IndexOf(int_0, i) >= 0;
				((CheckBox)gform0_0.Controls.Find("checkBox" + (5 + i), searchAllChildren: true)[0]).Checked = flag;
			}
		}

		public void Dispose()
		{
			gform0_0.Dispose();
		}
	}

	private sealed class Class223
	{
		public Class145 class145_0;

		public Class145 class145_1;

		public List<string> list_0;

		public Class145 class145_2;
	}

	private sealed class Class224
	{
		public GForm0 gform0_0;

		internal Task method_0()
		{
			return Class58.smethod_0(gform0_0);
		}
	}

	private sealed class Class225
	{
		public long long_0;

		internal long method_0()
		{
			return long_0;
		}

		internal long method_1()
		{
			return long_0;
		}
	}

	private sealed class Class226 : Interface2
	{
		internal readonly List<IntPtr> list_0 = new List<IntPtr>();

		internal JObject jobject_0;

		internal string string_0;

		internal bool bool_0;

		internal int int_0;

		internal bool bool_1;

		private readonly Queue<IntPtr> queue_0;

		private Class63.Delegate15 delegate15_0;

		private IntPtr intptr_0;

		private int int_1;

		internal Class226(params IntPtr[] intptr_1)
		{
			queue_0 = new Queue<IntPtr>(intptr_1);
		}

		public IntPtr imethod_0()
		{
			if (queue_0.Count != 0)
			{
				return queue_0.Dequeue();
			}
			return IntPtr.Zero;
		}

		public int imethod_1(IntPtr intptr_1, string string_1, string string_2, int int_2)
		{
			return 1;
		}

		public int imethod_2(IntPtr intptr_1, uint uint_0, int int_2)
		{
			int_1++;
			if (bool_1 && int_1 == 1)
			{
				return 0;
			}
			return 1;
		}

		public int imethod_3(IntPtr intptr_1, string string_1, int int_2)
		{
			method_0(new JObject { ["t"] = "ready" });
			return 1;
		}

		public void imethod_4(IntPtr intptr_1, Class63.Delegate15 delegate15_1, Class63.Delegate16 delegate16_0, IntPtr intptr_2)
		{
			delegate15_0 = delegate15_1;
			intptr_0 = intptr_2;
		}

		public void imethod_5(IntPtr intptr_1, string string_1, byte[] byte_0, int int_2)
		{
			JObject jObject = JObject.Parse(string_1);
			if ((string?)jObject["cmd"] != "libshare_init")
			{
				return;
			}
			jobject_0 = jObject;
			if (!bool_0)
			{
				int num = (int)jObject["req"] + int_0;
				if (string_0 == null)
				{
					method_0(new JObject
					{
						["t"] = "libshare",
						["ok"] = true,
						["req"] = num,
						["apiVersion"] = 1,
						["buildAbi"] = "arm64-v8a",
						["sha256"] = (string?)jObject["sha256"]
					});
				}
				else
				{
					method_0(new JObject
					{
						["t"] = "libshare",
						["ok"] = false,
						["req"] = num,
						["error"] = string_0
					});
				}
			}
		}

		public string imethod_6(IntPtr intptr_1)
		{
			return "native failure";
		}

		public void imethod_7(IntPtr intptr_1)
		{
			list_0.Add(intptr_1);
		}

		private void method_0(JObject jobject_1)
		{
			if (delegate15_0 == null)
			{
				return;
			}
			IntPtr hglobal = Marshal.StringToHGlobalAnsi(new JObject
			{
				["type"] = "send",
				["payload"] = jobject_1
			}.ToString(Formatting.None));
			try
			{
				delegate15_0(hglobal, IntPtr.Zero, 0, intptr_0);
			}
			finally
			{
				Marshal.FreeHGlobal(hglobal);
			}
		}
	}

	private sealed class Class227
	{
		public int int_0;

		public int int_1;

		public int int_2;

		internal void method_0(object sender, FormClosingEventArgs e)
		{
			Interlocked.Increment(ref int_0);
		}

		internal void method_1(object sender, FormClosedEventArgs e)
		{
			Interlocked.Increment(ref int_1);
			Interlocked.Increment(ref int_2);
		}
	}

	private sealed class Class228
	{
		public List<JObject> list_0;

		internal void method_0(string string_0)
		{
			list_0.Add(JObject.Parse(string_0));
		}
	}

	private sealed class Class229
	{
		public Class222 class222_0;

		public List<string> list_0;

		public long long_0;

		public Class223 class223_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
			class222_0.method_0(class223_0.class145_2, bool_0: true);
		}

		internal long method_1()
		{
			return long_0;
		}
	}

	private sealed class Class230 : IEnumerator<MethodBase>, IEnumerable<MethodBase>, IEnumerable, IEnumerator, IDisposable
	{
		private int int_0;

		private MethodBase methodBase_0;

		private int int_1;

		private MethodBase methodBase_1;

		public MethodBase methodBase_2;

		private byte[] byte_0;

		private int int_2;

		private OpCode opCode_0;

		MethodBase IEnumerator<MethodBase>.Current
		{
			[DebuggerHidden]
			get
			{
				return methodBase_0;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return methodBase_0;
			}
		}

		[DebuggerHidden]
		public Class230(int int_3)
		{
			int_0 = int_3;
			int_1 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			byte_0 = null;
			opCode_0 = default(OpCode);
			int_0 = -2;
		}

		private bool MoveNext()
		{
			int num = int_0;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				int_0 = -1;
				goto IL_014f;
			}
			int_0 = -1;
			if (methodBase_1 == null)
			{
				return false;
			}
			MethodBody methodBody = methodBase_1.GetMethodBody();
			if (methodBody == null)
			{
				return false;
			}
			byte_0 = methodBody.GetILAsByteArray();
			int_2 = 0;
			goto IL_0057;
			IL_0057:
			if (int_2 < byte_0.Length)
			{
				byte b = byte_0[int_2++];
				if (b == 254)
				{
					opCode_0 = opCode_1[byte_0[int_2++]];
				}
				else
				{
					opCode_0 = Class198.opCode_0[b];
				}
				if (opCode_0.OperandType == OperandType.InlineMethod)
				{
					int metadataToken = BitConverter.ToInt32(byte_0, int_2);
					MethodBase methodBase = null;
					try
					{
						Type[] genericTypeArguments = ((methodBase_1.DeclaringType == null) ? null : methodBase_1.DeclaringType.GetGenericArguments());
						Type[] genericMethodArguments = (methodBase_1.IsGenericMethod ? methodBase_1.GetGenericArguments() : null);
						methodBase = methodBase_1.Module.ResolveMethod(metadataToken, genericTypeArguments, genericMethodArguments);
					}
					catch (ArgumentException)
					{
						methodBase = null;
					}
					if (methodBase != null)
					{
						methodBase_0 = methodBase;
						int_0 = 1;
						return true;
					}
				}
				goto IL_014f;
			}
			return false;
			IL_014f:
			int_2 += smethod_205(opCode_0.OperandType, byte_0, int_2);
			opCode_0 = default(OpCode);
			goto IL_0057;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<MethodBase> IEnumerable<MethodBase>.GetEnumerator()
		{
			Class230 @class;
			if (int_0 == -2 && int_1 == Environment.CurrentManagedThreadId)
			{
				int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class230(0);
			}
			@class.methodBase_1 = methodBase_2;
			return @class;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<MethodBase>)this).GetEnumerator();
		}
	}

	private sealed class Class231
	{
		public List<string> list_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
		}
	}

	private sealed class Class232
	{
		public int int_0;

		public List<string> list_0;

		public int int_1;

		public List<string> list_1;

		public List<string> list_2;

		public bool bool_0;

		public bool bool_1;

		public Func<int, ulong, string> func_0;

		public List<string> list_3;

		public int int_2;

		public bool bool_2;

		public List<string> list_4;

		public List<string> list_5;

		public List<string> list_6;

		public List<string> list_7;

		public int int_3;

		public Class327 class327_0;

		public Class327 class327_1;

		public Class327 class327_2;

		public Func<string, string, string, int, Class71.Class72> func_1;

		public Func<Class9> func_2;

		internal Class71.Class72 method_0(string string_0, string string_1, string string_2, int int_4)
		{
			int_0++;
			return Class71.Class72.smethod_1("must not run");
		}

		internal Class9 method_1()
		{
			list_0.Add("runner");
			return new Class9(null, 27060);
		}

		internal string method_2(int int_4)
		{
			list_0.Add("forward:" + int_4);
			return null;
		}

		internal bool method_3()
		{
			list_0.Add("pid");
			return true;
		}

		internal string method_4()
		{
			list_0.Add("attach");
			return null;
		}

		internal Class9 method_5()
		{
			int_1++;
			return null;
		}

		internal Class9 method_6()
		{
			int_1++;
			return null;
		}

		internal Class9 method_7()
		{
			list_1.Add("runner");
			return new Class9(null, 27060);
		}

		internal string method_8(int int_4)
		{
			list_1.Add("forward");
			return null;
		}

		internal bool method_9()
		{
			list_1.Add("pid");
			return false;
		}

		internal string method_10()
		{
			list_1.Add("attach");
			return null;
		}

		internal Class71.Class72 method_11(string string_0, int int_4)
		{
			list_2.Add(string_0);
			if (string_0.Contains("KLX_PIDFILE_MISSING"))
			{
				return Class71.Class72.smethod_0(bool_0 ? "KLX_PIDFILE_PRESENT:3776" : "KLX_PIDFILE_MISSING");
			}
			if (string_0.Contains("pidof .klxsvc"))
			{
				return Class71.Class72.smethod_0(bool_1 ? "4512" : string.Empty);
			}
			switch (string_0)
			{
			case "shell su 0 cat /proc/4512/cmdline":
				if (!bool_1)
				{
					return Class71.Class72.smethod_1("No such file");
				}
				return Class71.Class72.smethod_0("/data/local/tmp/.klxsvc\0--port\027060\0");
			case "shell su 0 cat /proc/4512/stat":
				if (!bool_1)
				{
					return Class71.Class72.smethod_1("No such file");
				}
				return Class71.Class72.smethod_0(func_0(4512, 100uL));
			case "shell su 0 ls -l /proc/4512/fd":
				return Class71.Class72.smethod_0(string.Empty);
			default:
				if (string_0.Contains("KLX_SIGNAL_SENT"))
				{
					bool_1 = false;
					return Class71.Class72.smethod_0("KLX_SIGNAL_SENT");
				}
				if (string_0 == "shell su 0 rm -f /data/local/tmp/.klxsvc.pid")
				{
					bool_0 = false;
					return Class71.Class72.smethod_0(string.Empty);
				}
				if (string_0.Contains("KLX_PIDFILE_ABSENT"))
				{
					return Class71.Class72.smethod_0(bool_0 ? string.Empty : "KLX_PIDFILE_ABSENT");
				}
				return Class71.Class72.smethod_0(string.Empty);
			case "shell su 0 cat /proc/net/tcp":
			case "shell su 0 cat /proc/net/tcp6":
				return Class71.Class72.smethod_0(string.Empty);
			}
		}

		internal Class71.Class72 method_12(string string_0, int int_4)
		{
			list_3.Add(string_0);
			if (string_0.Contains("KLX_PIDFILE_MISSING"))
			{
				return Class71.Class72.smethod_0("KLX_PIDFILE_PRESENT:4512");
			}
			if (string_0.Contains("pidof .klxsvc"))
			{
				return Class71.Class72.smethod_0("4512");
			}
			if (string_0.EndsWith("/cmdline"))
			{
				return Class71.Class72.smethod_0("/data/local/tmp/.klxsvc\0--port\027060\0");
			}
			if (string_0.EndsWith("/stat"))
			{
				return Class71.Class72.smethod_0(func_0(4512, (++int_2 == 1) ? 100uL : 200uL));
			}
			if (string_0.Contains("/fd"))
			{
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_0.Contains("/proc/net/tcp"))
			{
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_0.Contains("KLX_SIGNAL_SENT"))
			{
				bool_2 = false;
				return Class71.Class72.smethod_0("KLX_SIGNAL_MISMATCH");
			}
			if (string_0.Contains("rm -f"))
			{
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_0.Contains("KLX_PIDFILE_ABSENT"))
			{
				return Class71.Class72.smethod_0("KLX_PIDFILE_ABSENT");
			}
			return Class71.Class72.smethod_0(string.Empty);
		}

		internal Class71.Class72 method_13(string string_0, int int_4)
		{
			list_4.Add(string_0);
			if (string_0.Contains("KLX_PIDFILE_MISSING"))
			{
				return Class71.Class72.smethod_0("KLX_PIDFILE_MISSING");
			}
			if (string_0.Contains("pidof .klxsvc"))
			{
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_0.Contains("/proc/net/tcp"))
			{
				return Class71.Class72.smethod_1("Permission denied");
			}
			return Class71.Class72.smethod_0(string.Empty);
		}

		internal Class71.Class72 method_14(string string_0, int int_4)
		{
			list_5.Add(string_0);
			if (string_0.Contains("KLX_PIDFILE_MISSING"))
			{
				return Class71.Class72.smethod_0("KLX_PIDFILE_MISSING");
			}
			if (string_0.Contains("pidof .klxsvc"))
			{
				return new Class71.Class72(string.Empty, "Permission denied", bool_2: true, bool_3: false, 0);
			}
			string_0.Contains("/proc/net/tcp");
			return Class71.Class72.smethod_0(string.Empty);
		}

		internal Class71.Class72 method_15(string string_0, int int_4)
		{
			list_6.Add(string_0);
			if (string_0.Contains("KLX_PIDFILE_MISSING"))
			{
				return Class71.Class72.smethod_0("KLX_PIDFILE_PRESENT:4512");
			}
			if (string_0.Contains("pidof .klxsvc"))
			{
				return Class71.Class72.smethod_0("4512");
			}
			if (string_0.EndsWith("/cmdline"))
			{
				return Class71.Class72.smethod_0("/data/local/tmp/.klxsvc\0--port\027060\0");
			}
			if (string_0.EndsWith("/stat"))
			{
				return Class71.Class72.smethod_0(func_0(4512, 100uL));
			}
			if (string_0.Contains("/fd"))
			{
				return Class71.Class72.smethod_0("lrwx------ 4 -> socket:[22018]");
			}
			return string_0 switch
			{
				"shell su 0 cat /proc/net/tcp" => Class71.Class72.smethod_0("0: 0100007F:69B4 00000000:0000 0A 00000000:00000000 00:00000000 00000000 0 0 22018 1 0000000000000000"), 
				"shell su 0 cat /proc/net/tcp6" => Class71.Class72.smethod_0(string.Empty), 
				"shell su 0 cat /data/local/tmp/.klx.tok" => Class71.Class72.smethod_0("0123456789abcdef0123456789abcdef"), 
				_ => Class71.Class72.smethod_0(string.Empty), 
			};
		}

		internal Class71.Class72 method_16(string string_0, int int_4)
		{
			list_7.Add(string_0);
			if (string_0.Contains("KLX_PIDFILE_MISSING"))
			{
				return Class71.Class72.smethod_0("KLX_PIDFILE_PRESENT:" + int_3);
			}
			if (string_0 == "shell su 0 cat /data/local/tmp/.klxsvc.pid")
			{
				return Class71.Class72.smethod_0(int_3.ToString());
			}
			if (string_0.Contains("pidof .klxsvc"))
			{
				return Class71.Class72.smethod_0("4512");
			}
			if (string_0.EndsWith("/cmdline"))
			{
				return Class71.Class72.smethod_0("/data/local/tmp/.klxsvc\0--port\027060\0");
			}
			if (string_0.EndsWith("/stat"))
			{
				return Class71.Class72.smethod_0(func_0(4512, 100uL));
			}
			if (string_0.Contains("/fd"))
			{
				return Class71.Class72.smethod_0("lrwx------ 4 -> socket:[22018]");
			}
			switch (string_0)
			{
			case "shell su 0 cat /proc/net/tcp":
				return Class71.Class72.smethod_0("0: 0100007F:69B4 00000000:0000 0A 00000000:00000000 00:00000000 00000000 0 0 22018 1 0000000000000000");
			case "shell su 0 cat /proc/net/tcp6":
				return Class71.Class72.smethod_0(string.Empty);
			case "shell su 0 cat /data/local/tmp/.klx.tok":
				return Class71.Class72.smethod_0("0123456789abcdef0123456789abcdef");
			default:
				if (string_0.Contains("echo 4512 > /data/local/tmp/.klxsvc.pid"))
				{
					int_3 = 4512;
					return Class71.Class72.smethod_0(string.Empty);
				}
				return Class71.Class72.smethod_0(string.Empty);
			}
		}

		internal void method_17()
		{
			class327_0.method_0(7);
		}

		internal void method_18()
		{
			class327_1.method_1("{\"type\":\"send\",\"payload\":{\"t\":\"snap\",\"seq\":1,\"skipped\":0}}");
		}

		internal void method_19()
		{
			class327_2.method_1("{\"type\":\"send\",\"payload\":{\"t\":\"snap\",\"seq\":1,\"skipped\":0}}");
		}
	}

	private sealed class Class233
	{
		public Class222 class222_0;

		public Class239 class239_0;

		internal void method_0()
		{
			class222_0.method_0(smethod_113(new List<Class403> { class239_0.class403_1 }, class239_0.dictionary_0, class239_0.class83_0, 411), bool_0: true);
		}
	}

	private sealed class Class234
	{
		public Class339 class339_0;

		public Class300 class300_0;

		internal Task method_0()
		{
			return (Task)class300_0.methodInfo_0.Invoke(class339_0.gform0_0, new object[2] { class339_0.class119_0, class339_0.long_0 });
		}
	}

	private sealed class Class235
	{
		public string string_0;

		public CountdownEvent countdownEvent_0;

		public ManualResetEventSlim manualResetEventSlim_0;

		public Exception[] exception_0;
	}

	private sealed class Class236
	{
		public Class145 class145_0;

		internal Class145 method_0()
		{
			return class145_0;
		}
	}

	private sealed class Class237
	{
		public int int_0;

		public int int_1;

		internal void method_0(Class101 class101_0)
		{
			int_0++;
		}

		internal void method_1(Class400 class400_0)
		{
			int_1++;
		}
	}

	private sealed class Class238 : HttpMessageHandler
	{
		private readonly byte[] byte_0;

		private readonly string string_0;

		internal Class238(string string_1, bool bool_0)
		{
			string text = Class21.smethod_24(Encoding.UTF8.GetBytes("new"));
			string s = "{\"schemaVersion\":2,\"profileId\":\"ran-test\",\"contentRevision\":\"r1\",\"files\":[{\"path\":\"model.bin\",\"version\":\"v2\",\"size\":3,\"sha256\":\"" + text + "\",\"releaseId\":10,\"assetId\":20}]}";
			byte_0 = Encoding.UTF8.GetBytes(s);
			string text2 = (bool_0 ? (",\"body\":" + JsonConvert.SerializeObject(string_1)) : string.Empty);
			string_0 = "[{\"id\":30,\"draft\":false,\"prerelease\":false,\"tag_name\":\"catalog-ran-test-x\",\"published_at\":\"2026-10-05T00:00:00Z\"" + text2 + ",\"assets\":[{\"id\":40,\"name\":\"manifest.json\",\"size\":" + byte_0.Length + ",\"digest\":\"sha256:" + Class21.smethod_24(byte_0) + "\"}]},{\"id\":10,\"draft\":false,\"prerelease\":false,\"tag_name\":\"artifact-model\",\"published_at\":\"2026-10-04T00:00:00Z\",\"assets\":[{\"id\":20,\"name\":\"model.bin\",\"size\":3,\"digest\":\"sha256:" + text + "\"}]}]";
		}

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			string absolutePath = request.RequestUri.AbsolutePath;
			if (absolutePath.EndsWith("/releases", StringComparison.Ordinal))
			{
				return Task.FromResult<HttpResponseMessage>(smethod_0(string_0));
			}
			if (absolutePath.EndsWith("/releases/assets/40", StringComparison.Ordinal))
			{
				return Task.FromResult<HttpResponseMessage>(smethod_1(byte_0));
			}
			return Task.FromResult<HttpResponseMessage>(new HttpResponseMessage(HttpStatusCode.NotFound));
		}

		private static HttpResponseMessage smethod_0(string string_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0021: Expected O, but got Unknown
			return new HttpResponseMessage(HttpStatusCode.OK)
			{
				Content = (HttpContent)new StringContent(string_1, Encoding.UTF8, "application/json")
			};
		}

		private static HttpResponseMessage smethod_1(byte[] byte_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0017: Expected O, but got Unknown
			return new HttpResponseMessage(HttpStatusCode.OK)
			{
				Content = (HttpContent)new ByteArrayContent(byte_1)
			};
		}
	}

	private sealed class Class239
	{
		public List<string> list_0;

		public long long_0;

		public Class403 class403_0;

		public Dictionary<string, string> dictionary_0;

		public Class83 class83_0;

		public List<string> list_1;

		public Class403 class403_1;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
		}

		internal long method_1()
		{
			return long_0;
		}

		internal void method_2(string string_0)
		{
			list_1.Add(string_0);
		}

		internal long method_3()
		{
			return long_0;
		}
	}

	private sealed class Class240
	{
		public Class339 class339_0;

		public Class300 class300_0;

		internal Task method_0()
		{
			return (Task)class300_0.methodInfo_0.Invoke(class339_0.gform0_0, new object[2] { class339_0.class119_0, class339_0.long_0 });
		}
	}

	private sealed class Class241
	{
		public Class119 class119_0;

		internal void method_0(string string_0)
		{
			if (string_0.StartsWith("detached,", StringComparison.Ordinal))
			{
				class119_0.method_44(2L);
				smethod_250(class119_0, "{\"t\":\"radar_readiness\",\"ready\":true}", 2L);
			}
		}
	}

	private sealed class Class242
	{
		private readonly ConcurrentQueue<Action> concurrentQueue_0 = new ConcurrentQueue<Action>();

		internal void method_0(Action action_0)
		{
			concurrentQueue_0.Enqueue(action_0);
		}

		internal bool method_1(TimeSpan timeSpan_0)
		{
			return SpinWait.SpinUntil(method_4, timeSpan_0);
		}

		internal bool method_2(Func<bool> func_0, TimeSpan timeSpan_0)
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			while (true)
			{
				if (stopwatch.Elapsed < timeSpan_0)
				{
					method_3();
					if (func_0())
					{
						break;
					}
					Thread.Sleep(5);
					continue;
				}
				method_3();
				return func_0();
			}
			return true;
		}

		internal void method_3()
		{
			Action result;
			while (concurrentQueue_0.TryDequeue(out result))
			{
				result();
			}
		}

		private bool method_4()
		{
			return !concurrentQueue_0.IsEmpty;
		}
	}

	private sealed class Class243
	{
		public Class222 class222_0;

		public long long_0;

		public int int_0;

		public Class223 class223_0;

		internal long method_0()
		{
			return long_0;
		}

		internal Task method_1(int int_1)
		{
			int_0++;
			long_0 += int_1;
			if (long_0 == 10000L)
			{
				class222_0.method_0(class223_0.class145_2, bool_0: true);
			}
			return Task.CompletedTask;
		}
	}

	private sealed class Class244
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Struct79 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<int> asyncTaskMethodBuilder_0;

			public Class244 class244_0;

			private TaskAwaiter<int> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class244 @class = class244_0;
				int result;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						awaiter = @class.gform0_0.smethod_10(1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<int>);
						num = -1;
						int_0 = -1;
					}
					result = awaiter.GetResult();
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

		[StructLayout(LayoutKind.Auto)]
		private struct Struct80 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<IReadOnlyList<string>> asyncTaskMethodBuilder_0;

			public Class244 class244_0;

			private TaskAwaiter<IReadOnlyList<string>> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class244 @class = class244_0;
				IReadOnlyList<string> result;
				try
				{
					TaskAwaiter<IReadOnlyList<string>> awaiter;
					if (num != 0)
					{
						awaiter = @class.gform0_0.smethod_14().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<IReadOnlyList<string>>);
						num = -1;
						int_0 = -1;
					}
					result = awaiter.GetResult();
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

		[StructLayout(LayoutKind.Auto)]
		private struct Struct81 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<List<int>> asyncTaskMethodBuilder_0;

			public Class244 class244_0;

			private TaskAwaiter<List<int>> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class244 @class = class244_0;
				List<int> result;
				try
				{
					TaskAwaiter<List<int>> awaiter;
					if (num != 0)
					{
						awaiter = Class104.smethod_0(@class.gform0_0, 29, 33).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<List<int>>);
						num = -1;
						int_0 = -1;
					}
					result = awaiter.GetResult();
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

		[StructLayout(LayoutKind.Auto)]
		private struct Struct82 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

			public Class244 class244_0;

			private TaskAwaiter<bool> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class244 @class = class244_0;
				bool result;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = @class.gform0_0.smethod_7(1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
					}
					result = awaiter.GetResult();
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

		[StructLayout(LayoutKind.Auto)]
		private struct Struct83 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

			public Class244 class244_0;

			private TaskAwaiter<bool> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class244 @class = class244_0;
				bool result;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = @class.gform0_0.smethod_6(42).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
					}
					result = awaiter.GetResult();
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

		[StructLayout(LayoutKind.Auto)]
		private struct Struct84 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<List<int>> asyncTaskMethodBuilder_0;

			public Class244 class244_0;

			private TaskAwaiter<List<int>> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class244 @class = class244_0;
				List<int> result;
				try
				{
					TaskAwaiter<List<int>> awaiter;
					if (num != 0)
					{
						awaiter = Class104.smethod_0(@class.gform0_0, 29, 33).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<List<int>>);
						num = -1;
						int_0 = -1;
					}
					result = awaiter.GetResult();
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

		[StructLayout(LayoutKind.Auto)]
		private struct Struct85 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

			public Class244 class244_0;

			private TaskAwaiter<bool> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class244 @class = class244_0;
				bool result;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = @class.gform0_0.smethod_6(42).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
					}
					result = awaiter.GetResult();
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

		[StructLayout(LayoutKind.Auto)]
		private struct Struct86 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<IReadOnlyList<string>> asyncTaskMethodBuilder_0;

			public Class244 class244_0;

			private TaskAwaiter<IReadOnlyList<string>> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class244 @class = class244_0;
				IReadOnlyList<string> result;
				try
				{
					TaskAwaiter<IReadOnlyList<string>> awaiter;
					if (num != 0)
					{
						awaiter = @class.gform0_0.smethod_15().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<IReadOnlyList<string>>);
						num = -1;
						int_0 = -1;
					}
					result = awaiter.GetResult();
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

		[StructLayout(LayoutKind.Auto)]
		private struct Struct87 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<int> asyncTaskMethodBuilder_0;

			public Class244 class244_0;

			private TaskAwaiter<int> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class244 @class = class244_0;
				int result;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						awaiter = @class.gform0_0.smethod_10(1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<int>);
						num = -1;
						int_0 = -1;
					}
					result = awaiter.GetResult();
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

		[StructLayout(LayoutKind.Auto)]
		private struct Struct88 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

			public Class244 class244_0;

			private TaskAwaiter<bool> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class244 @class = class244_0;
				bool result;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = @class.gform0_0.smethod_7(1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
					}
					result = awaiter.GetResult();
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

		public GForm0 gform0_0;

		internal async Task<bool> method_0()
		{
			return await gform0_0.smethod_6(42);
		}

		internal async Task<bool> method_1()
		{
			return await gform0_0.smethod_7(1);
		}

		internal async Task<int> method_2()
		{
			return await gform0_0.smethod_10(1);
		}

		internal async Task<bool> method_3()
		{
			return await gform0_0.smethod_6(42);
		}

		internal async Task<bool> method_4()
		{
			return await gform0_0.smethod_7(1);
		}

		internal async Task<int> method_5()
		{
			return await gform0_0.smethod_10(1);
		}

		internal async Task<List<int>> method_6()
		{
			return await Class104.smethod_0(gform0_0, 29, 33);
		}

		internal async Task<List<int>> method_7()
		{
			return await Class104.smethod_0(gform0_0, 29, 33);
		}

		internal async Task<IReadOnlyList<string>> method_8()
		{
			return await gform0_0.smethod_15();
		}

		internal async Task<IReadOnlyList<string>> method_9()
		{
			return await gform0_0.smethod_14();
		}
	}

	private sealed class Class245
	{
		public Class222 class222_0;

		internal Task<Enum9> method_0()
		{
			return Class179.smethod_0(class222_0.gform0_0, -1, 200, 10.0);
		}

		internal Task<Enum9> method_1()
		{
			return Class179.smethod_1(class222_0.gform0_0, 0, 0, 10.0);
		}

		internal Task<Enum9> method_2()
		{
			return Class179.smethod_2(class222_0.gform0_0, " ", 0, 200, double.NaN);
		}

		internal Task<Enum9> method_3()
		{
			return Class179.smethod_2(class222_0.gform0_0, " ", 0, 200, double.PositiveInfinity);
		}

		internal Task<Enum9> method_4()
		{
			return Class179.smethod_2(class222_0.gform0_0, " ", 0, 200, -0.1);
		}

		internal Task<Enum9> method_5()
		{
			return Class179.smethod_2(class222_0.gform0_0, " ", 0, 200, double.MaxValue);
		}
	}

	private sealed class Class246 : IDisposable
	{
		private readonly string string_0;

		private readonly object object_0 = new object();

		private Process process_0;

		private string string_1;

		internal Class246()
		{
			string location = Assembly.GetExecutingAssembly().Location;
			string text = "hb" + Guid.NewGuid().ToString("N");
			string_0 = Path.Combine(Path.GetTempPath(), text + ".exe");
			File.Copy(location, string_0, overwrite: false);
			method_1(text);
		}

		internal string method_0()
		{
			return string_1;
		}

		private void method_1(string string_2)
		{
			string_1 = string_2;
		}

		internal void method_2(int int_0)
		{
			Process process = Process.Start(new ProcessStartInfo
			{
				FileName = string_0,
				Arguments = "--heartbeat-watchdog-probe-child " + int_0,
				UseShellExecute = false,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			});
			lock (object_0)
			{
				if (process_0 != null)
				{
					process.Dispose();
					throw new InvalidOperationException("The heartbeat probe child was already started.");
				}
				process_0 = process;
			}
		}

		internal void method_3(TimeSpan timeSpan_0)
		{
			Process process;
			lock (object_0)
			{
				process = process_0;
			}
			if (process == null || !process.WaitForExit((int)timeSpan_0.TotalMilliseconds))
			{
				throw new TimeoutException("The heartbeat probe child did not exit in time.");
			}
		}

		public void Dispose()
		{
			Process process;
			lock (object_0)
			{
				process = process_0;
			}
			if (process != null)
			{
				try
				{
					if (!process.HasExited)
					{
						process.Kill();
						process.WaitForExit(2000);
					}
				}
				catch (InvalidOperationException)
				{
				}
				catch (Win32Exception)
				{
				}
				finally
				{
					process.Dispose();
				}
			}
			try
			{
				File.Delete(string_0);
			}
			catch (IOException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
		}
	}

	private sealed class Class247
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		internal void method_0()
		{
			Interlocked.Increment(ref int_0);
		}

		internal void method_1()
		{
			Interlocked.Increment(ref int_1);
		}

		internal void method_2()
		{
			Interlocked.Increment(ref int_2);
		}

		internal Task<bool> method_3()
		{
			Interlocked.Increment(ref int_3);
			return Task.FromResult(result: false);
		}

		internal Task<bool> method_4()
		{
			Interlocked.Increment(ref int_4);
			return Task.FromResult(result: true);
		}

		internal void method_5()
		{
			Interlocked.Increment(ref int_5);
		}
	}

	private sealed class Class248
	{
		public List<string> list_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
		}
	}

	private sealed class Class249
	{
		public Class222 class222_0;

		public List<string> list_0;

		public long long_0;

		public int int_0;

		public Class223 class223_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
			class222_0.method_0(class223_0.class145_0, bool_0: true);
		}

		internal long method_1()
		{
			return long_0;
		}

		internal Task method_2(int int_1)
		{
			int_0++;
			long_0 += int_1;
			if (int_0 == 2)
			{
				class222_0.method_0(class223_0.class145_1, bool_0: true);
			}
			return Task.CompletedTask;
		}
	}

	private sealed class Class250 : HttpMessageHandler
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Struct89 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<HttpResponseMessage> asyncTaskMethodBuilder_0;

			public Class250 class250_0;

			public HttpRequestMessage httpRequestMessage_0;

			private Encoding encoding_0;

			private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

			private void MoveNext()
			{
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d9: Expected O, but got Unknown
				//IL_00da: Expected O, but got Unknown
				int num = int_0;
				Class250 @class = class250_0;
				HttpResponseMessage result2;
				try
				{
					ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						@class.string_1 = httpRequestMessage_0.RequestUri.ToString();
						encoding_0 = Encoding.UTF8;
						awaiter = httpRequestMessage_0.Content.ReadAsByteArrayAsync().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
					@class.string_2 = encoding_0.GetString(result);
					encoding_0 = null;
					result2 = new HttpResponseMessage(@class.httpStatusCode_0)
					{
						Content = (HttpContent)new StringContent(@class.string_0)
					};
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

		private readonly HttpStatusCode httpStatusCode_0;

		private readonly string string_0;

		internal string string_1;

		internal string string_2;

		internal Class250(HttpStatusCode httpStatusCode_1, string string_3)
		{
			httpStatusCode_0 = httpStatusCode_1;
			string_0 = string_3;
		}

		protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			string_1 = request.RequestUri.ToString();
			Encoding uTF = Encoding.UTF8;
			string_2 = uTF.GetString(await request.Content.ReadAsByteArrayAsync().ConfigureAwait(continueOnCapturedContext: false));
			return new HttpResponseMessage(httpStatusCode_0)
			{
				Content = (HttpContent)new StringContent(string_0)
			};
		}
	}

	private sealed class Class251
	{
		public bool bool_0;

		public Class119 class119_0;

		public int int_0;

		public MethodInfo methodInfo_0;

		internal void method_0(int int_1)
		{
			bool_0 = !class119_0.method_10();
			int_0 = int_1;
		}

		internal void method_1()
		{
			class119_0.method_94();
		}

		internal void method_2()
		{
			class119_0.method_94();
		}

		internal void method_3()
		{
			class119_0.method_95();
		}

		internal object method_4()
		{
			return methodInfo_0.Invoke(class119_0, new object[2]
			{
				73,
				IntPtr.Zero
			});
		}
	}

	private sealed class Class252
	{
		public ManualResetEventSlim manualResetEventSlim_0;

		public ManualResetEventSlim manualResetEventSlim_1;

		public int int_0;

		internal void method_0(string string_0)
		{
			if (string_0 == "hold")
			{
				manualResetEventSlim_0.Set();
				manualResetEventSlim_1.Wait(2000);
			}
			else if (string_0.Contains("\"cmd\":\"ack\""))
			{
				Interlocked.Increment(ref int_0);
			}
		}

		internal bool method_1()
		{
			return Volatile.Read(ref int_0) == 1;
		}
	}

	private sealed class Class253
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Struct90 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

			public Class253 class253_0;

			private TaskAwaiter<bool> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class253 @class = class253_0;
				bool result;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = Class360.smethod_1(@class.class222_0.gform0_0, 20f).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
					}
					result = awaiter.GetResult();
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

		public Class222 class222_0;

		internal void method_0()
		{
			class222_0.gform0_0.bool_3 = true;
		}

		internal async Task<bool> method_1()
		{
			return await Class360.smethod_1(class222_0.gform0_0, 20f);
		}

		internal void method_2()
		{
			class222_0.gform0_0.bool_3 = true;
		}

		internal void method_3()
		{
			class222_0.gform0_0.bool_3 = true;
		}

		internal void method_4()
		{
			class222_0.method_0(Class145.class145_0, bool_0: true);
		}
	}

	private sealed class Class254
	{
		public int int_0;

		public string string_0;

		public int int_1;

		public Class119 class119_0;

		public ManualResetEventSlim manualResetEventSlim_0;

		public ManualResetEventSlim manualResetEventSlim_1;

		public int int_2;

		public GForm0 gform0_0;

		internal object method_0(string string_1, Class119 class119_1, Func<object> func_0)
		{
			Interlocked.Increment(ref int_0);
			if (string_1 != string_0)
			{
				Interlocked.Increment(ref int_1);
			}
			if (class119_1 != class119_0)
			{
				Interlocked.Increment(ref int_1);
			}
			manualResetEventSlim_0.Set();
			manualResetEventSlim_1.Wait();
			if (!(string_0 == "Census"))
			{
				return true;
			}
			return "TestHero";
		}

		internal void method_1(Class119 class119_1)
		{
			if (class119_1 != class119_0)
			{
				Interlocked.Increment(ref int_1);
			}
			Interlocked.Increment(ref int_2);
		}
	}

	private sealed class Class255
	{
		public List<JObject> list_0;

		public List<string> list_1;

		internal void method_0(string string_0)
		{
			list_0.Add(JObject.Parse(string_0));
		}

		internal void method_1(string string_0)
		{
			list_1.Add(string_0);
		}
	}

	private sealed class Class256
	{
		public string string_0;

		internal void method_0(string string_1)
		{
			string_0 = string_1;
		}
	}

	private sealed class Class257
	{
		public Class246 class246_0;

		internal bool method_0(string string_0)
		{
			if (string_0.Contains("reason=process-missing") && string_0.Contains("process=" + class246_0.method_0()))
			{
				return string_0.Contains("elapsed_ms=");
			}
			return false;
		}
	}

	private sealed class Class258
	{
		public List<string> list_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
		}
	}

	private sealed class Class259
	{
		public Class339 class339_0;

		internal object method_0(string string_0, Class119 class119_0, Func<object> func_0)
		{
			object result = func_0();
			class339_0.method_2(class119_0, bool_0: false);
			return result;
		}
	}

	private sealed class Class260
	{
		public Class222 class222_0;

		public Class145 class145_0;

		public long long_0;

		public List<int> list_0;

		public Class145 class145_1;

		public Class223 class223_0;

		internal void method_0(string string_0)
		{
			class223_0.list_0.Add(string_0);
			class222_0.method_0(class145_0, bool_0: true);
		}

		internal long method_1()
		{
			return long_0;
		}

		internal Task method_2(int int_0)
		{
			list_0.Add(int_0);
			long_0 += int_0;
			class222_0.method_0(class145_1, bool_0: true);
			return Task.CompletedTask;
		}
	}

	private sealed class Class261 : IDisposable
	{
		private readonly Dictionary<Class119, Class222> dictionary_0 = new Dictionary<Class119, Class222>();

		private Class222 class222_0;

		internal Class261()
		{
			if (class261_0 != null)
			{
				throw new InvalidOperationException("LiveFormFixtureScope cannot be nested");
			}
			class261_0 = this;
		}

		internal Class222 method_0(Class119 class119_0)
		{
			if (class119_0 == null)
			{
				if (class222_0 == null)
				{
					class222_0 = new Class222(null);
				}
				return class222_0;
			}
			if (!dictionary_0.TryGetValue(class119_0, out var value))
			{
				value = new Class222(class119_0);
				dictionary_0.Add(class119_0, value);
			}
			return value;
		}

		public void Dispose()
		{
			foreach (Class222 value in dictionary_0.Values)
			{
				value.Dispose();
			}
			dictionary_0.Clear();
			if (class222_0 != null)
			{
				class222_0.Dispose();
				class222_0 = null;
			}
			if (class261_0 == this)
			{
				class261_0 = null;
			}
		}
	}

	private sealed class Class262
	{
		public Class222 class222_0;

		public List<string> list_0;

		public long long_0;

		public Class223 class223_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
			class222_0.method_0(class223_0.class145_0, bool_0: true);
		}

		internal long method_1()
		{
			return long_0;
		}

		internal Task method_2(int int_0)
		{
			long_0 += int_0;
			return Task.CompletedTask;
		}
	}

	private sealed class Class263
	{
		public MethodInfo methodInfo_0;

		public List<string> list_0;

		public Class403 class403_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
		}
	}

	private sealed class Class264
	{
		public long long_0;

		internal long method_0()
		{
			return long_0;
		}
	}

	private sealed class Class265 : Interface2
	{
		private sealed class Class266
		{
			internal readonly Class63.Delegate15 delegate15_0;

			internal readonly IntPtr intptr_0;

			internal Class266(Class63.Delegate15 delegate15_1, IntPtr intptr_1)
			{
				delegate15_0 = delegate15_1;
				intptr_0 = intptr_1;
			}
		}

		internal readonly List<IntPtr> list_0 = new List<IntPtr>();

		internal readonly List<string> list_1 = new List<string>();

		internal readonly List<string> list_2 = new List<string>();

		internal JObject jobject_0;

		internal int int_0;

		internal int int_1;

		internal bool bool_0;

		internal int int_2;

		internal int int_3;

		internal bool bool_1;

		internal bool bool_2;

		internal bool bool_3;

		internal uint uint_0;

		private readonly Queue<IntPtr> queue_0;

		private readonly List<Class266> list_3 = new List<Class266>();

		private JObject jobject_1;

		internal Class265(params IntPtr[] intptr_0)
		{
			queue_0 = new Queue<IntPtr>(intptr_0);
		}

		internal int method_0()
		{
			return list_3.Count - 1;
		}

		public IntPtr imethod_0()
		{
			if (queue_0.Count != 0)
			{
				return queue_0.Dequeue();
			}
			return IntPtr.Zero;
		}

		public int imethod_1(IntPtr intptr_0, string string_0, string string_1, int int_4)
		{
			return 1;
		}

		public int imethod_2(IntPtr intptr_0, uint uint_1, int int_4)
		{
			return 1;
		}

		public int imethod_3(IntPtr intptr_0, string string_0, int int_4)
		{
			method_3(method_0(), new JObject { ["t"] = "ready" });
			return 1;
		}

		public void imethod_4(IntPtr intptr_0, Class63.Delegate15 delegate15_0, Class63.Delegate16 delegate16_0, IntPtr intptr_1)
		{
			list_3.Add(new Class266(delegate15_0, intptr_1));
		}

		public void imethod_5(IntPtr intptr_0, string string_0, byte[] byte_0, int int_4)
		{
			JObject jObject = JObject.Parse(string_0);
			string text = (string?)jObject["cmd"];
			list_1.Add(text);
			list_2.Add(text);
			switch (text)
			{
			case "libshare_init":
				method_3(method_0(), new JObject
				{
					["t"] = "libshare",
					["ok"] = true,
					["req"] = (int)jObject["req"],
					["apiVersion"] = 1,
					["buildAbi"] = "arm64-v8a",
					["sha256"] = (string?)jObject["sha256"]
				});
				break;
			case "license_open":
				int_1++;
				if (!bool_0)
				{
					jobject_1 = new JObject
					{
						["t"] = "license_hello",
						["ok"] = true,
						["req"] = (int)jObject["req"] + int_2,
						["protocol"] = 1,
						["pid"] = uint_0 + int_3,
						["sessionId"] = "000102030405060708090a0b0c0d0e0f",
						["challenge"] = "101112131415161718191a1b1c1d1e1f202122232425262728292a2b2c2d2e2f",
						["publicKey"] = (bool_1 ? ("04" + new string('0', 128)) : "046b17d1f2e12c4247f8bce6e563a440f277037d812deb33a0f4a13945d898c2964fe342e2fe1a7f9b8ee7eb4a7c0f9e162bce33576b315ececbb6406837bf51f5")
					};
					method_3(method_0(), jobject_1);
				}
				break;
			case "license_bootstrap":
				jobject_0 = jObject;
				int_0++;
				method_3(method_0(), new JObject
				{
					["t"] = "license_bootstrap",
					["ok"] = true,
					["req"] = (int)jObject["req"],
					["sessionId"] = (bool_2 ? "ffffffffffffffffffffffffffffffff" : ((string?)jObject["sessionId"]))
				});
				if (bool_3)
				{
					method_2(method_0(), bool_4: true, "accepted", "immediate", 1, 1);
				}
				break;
			}
		}

		public string imethod_6(IntPtr intptr_0)
		{
			return "native failure";
		}

		public void imethod_7(IntPtr intptr_0)
		{
			list_2.Add("close");
			list_0.Add(intptr_0);
		}

		internal void method_1()
		{
			if (jobject_1 != null)
			{
				method_3(method_0(), jobject_1);
			}
		}

		internal void method_2(int int_4, bool bool_4, string string_0, string string_1, int int_5, int int_6)
		{
			method_3(int_4, new JObject
			{
				["t"] = "license_status",
				["sessionId"] = "000102030405060708090a0b0c0d0e0f",
				["authorized"] = bool_4,
				["state"] = string_0,
				["reason"] = string_1,
				["attempt"] = int_5,
				["round"] = int_6,
				["serverId"] = "ran-origin"
			});
		}

		private void method_3(int int_4, JObject jobject_2)
		{
			if (int_4 >= 0 && int_4 < list_3.Count)
			{
				Class266 @class = list_3[int_4];
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(new JObject
				{
					["type"] = "send",
					["payload"] = jobject_2
				}.ToString(Formatting.None));
				try
				{
					@class.delegate15_0(intPtr, IntPtr.Zero, 0, @class.intptr_0);
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
		}
	}

	private sealed class Class267
	{
		public int int_0;

		internal void method_0()
		{
			Interlocked.Increment(ref int_0);
		}

		internal bool method_1()
		{
			return Volatile.Read(ref int_0) == 1;
		}
	}

	private sealed class Class268
	{
		public MethodInfo methodInfo_0;

		public MethodInfo methodInfo_1;

		internal string method_0(bool bool_0, bool bool_1, string string_0, string string_1, string string_2)
		{
			return (string)methodInfo_0.Invoke(null, new object[5] { bool_0, bool_1, string_0, string_1, string_2 });
		}

		internal string method_1(string string_0)
		{
			return (string)methodInfo_1.Invoke(null, new object[1] { JObject.Parse(string_0) });
		}
	}

	private sealed class Class269
	{
		public Class222 class222_0;

		public long long_0;

		internal long method_0()
		{
			return long_0;
		}

		internal Task method_1(int int_0)
		{
			long_0 += int_0;
			smethod_94(class222_0.gform0_0, "_session", null);
			return Task.CompletedTask;
		}
	}

	private sealed class Class270
	{
		internal readonly Dictionary<string, Class1> dictionary_0 = new Dictionary<string, Class1>();

		internal readonly List<string> list_0 = new List<string>();

		internal readonly List<string> list_1 = new List<string>();

		internal Class351 class351_0;

		internal Class1 method_0(string string_0, uint uint_0)
		{
			dictionary_0.TryGetValue(string_0 + "/" + uint_0, out var value);
			return value;
		}

		internal void method_1(uint uint_0, long long_0, int int_0)
		{
			dictionary_0["s/" + uint_0] = new Class1
			{
				String_0 = uint_0.ToString(),
				String_1 = "s",
				UInt32_0 = uint_0,
				String_7 = "captured",
				Int32_4 = 3,
				Int32_3 = int_0,
				Int64_0 = long_0
			};
		}

		internal Class114 method_2(double double_0, double double_1, double double_2, double double_3)
		{
			return new Class114
			{
				bool_0 = true,
				double_0 = double_0,
				double_1 = double_3,
				double_2 = double_1,
				double_3 = double_2
			};
		}
	}

	private sealed class Class271
	{
		public byte[] byte_0;

		public byte[] byte_1;

		public Class66 class66_0;

		public byte[] byte_2;

		internal void method_0()
		{
			Class103.smethod_7(byte_0, byte_1, new byte[0], class66_0.byte_0, byte_2);
		}
	}

	private sealed class Class272
	{
		public Enum1 enum1_0;

		internal Class87 method_0()
		{
			return new Class87(enum1_0, 0, 0, "probe failed");
		}
	}

	private sealed class Class273
	{
		public List<string> list_0;

		public Class119 class119_0;

		public long long_0;

		public List<string> list_1;

		public List<string> list_2;

		public List<string> list_3;

		public Class403 class403_0;

		public Dictionary<string, string> dictionary_0;

		public Class83 class83_0;

		public Class119 class119_1;

		public List<string> list_4;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
			JObject jObject = JObject.Parse(string_0);
			if ((string?)jObject["cmd"] == "pick")
			{
				class119_0.method_145((uint)jObject["id"], (byte)jObject["type"], (uint)jObject["req"], bool_17: false, "refused");
			}
		}

		internal long method_1()
		{
			return long_0;
		}

		internal void method_2(string string_0)
		{
			list_1.Add(string_0);
		}

		internal long method_3()
		{
			return long_0;
		}

		internal void method_4(string string_0)
		{
			list_2.Add(string_0);
			if (list_2.Count == 1)
			{
				long_0 = 1000L;
			}
		}

		internal long method_5()
		{
			return long_0;
		}

		internal long method_6()
		{
			return long_0;
		}

		internal void method_7(string string_0)
		{
			list_4.Add(string_0);
		}

		internal long method_8()
		{
			return long_0;
		}
	}

	private sealed class Class274
	{
		public int int_0;

		public Class234 class234_0;

		internal void method_0(string string_0)
		{
			if (string_0.IndexOf("\"cmd\":\"census_raw\"", StringComparison.Ordinal) >= 0)
			{
				int_0++;
				class234_0.class339_0.method_0(new List<Class403>
				{
					new Class403
					{
						byte_0 = 100,
						byte_1 = 4,
						uint_0 = 77u
					}
				}, "Hero77");
				class234_0.class339_0.method_1(bool_0: false);
			}
		}
	}

	private sealed class Class275
	{
		public int int_0;

		public Class235 class235_0;

		internal void method_0()
		{
			try
			{
				using DataGridView dataGridView = smethod_267();
				Class67 @class = new Class67(class235_0.string_0);
				@class.method_6(dataGridView, "concurrent.json", bool_0: false);
				class235_0.countdownEvent_0.Signal();
				class235_0.manualResetEventSlim_0.Wait();
				for (int i = 0; i < 20; i++)
				{
					using (@class.method_17(dataGridView))
					{
						dataGridView.Rows.Add(int_0 + "-" + i);
					}
				}
				using (@class.method_17(dataGridView))
				{
				}
			}
			catch (Exception ex)
			{
				class235_0.exception_0[int_0] = ex;
			}
		}
	}

	private sealed class Class276
	{
		public int int_0;

		public IntPtr intptr_0;

		public string string_0;

		internal IntPtr method_0(string string_1)
		{
			int_0++;
			if (int_0 != 1)
			{
				return intptr_0;
			}
			return IntPtr.Zero;
		}

		internal void method_1()
		{
			intptr_0 = LoadLibraryExW(string_0, IntPtr.Zero, 0u);
		}
	}

	private sealed class Class277
	{
		public ManualResetEventSlim manualResetEventSlim_0;

		public ManualResetEventSlim manualResetEventSlim_1;

		public ManualResetEventSlim manualResetEventSlim_2;

		public Class119 class119_0;

		public Exception exception_0;

		public Exception exception_1;

		internal void method_0()
		{
			manualResetEventSlim_0.Set();
			manualResetEventSlim_1.Wait();
		}

		internal void method_1(Class400 class400_0)
		{
			manualResetEventSlim_2.Set();
			class119_0.method_119();
		}

		internal void method_2()
		{
			try
			{
				class119_0.method_210();
			}
			catch (Exception ex)
			{
				exception_0 = ex;
			}
		}

		internal void method_3()
		{
			try
			{
				smethod_250(class119_0, "{\"t\":\"cam_zoom_status\",\"ready\":true,\"anchored\":true,\"reason\":\"\"}", 1L);
			}
			catch (Exception ex)
			{
				exception_1 = ex;
			}
		}
	}

	private sealed class Class278
	{
		internal readonly string string_0;

		internal readonly string string_1;

		internal Class278(string string_2, string string_3)
		{
			string_0 = string_2;
			string_1 = string_3;
		}
	}

	private sealed class Class279
	{
		public List<string> list_0;

		public int int_0;

		public int int_1;

		public bool bool_0;

		public List<Tuple<float, float>> list_1;

		public Class403 class403_0;

		public bool bool_1;

		public Class119 class119_0;

		public long long_0;

		public Class83 class83_0;

		public int int_2;

		public Class222 class222_0;

		public Dictionary<string, string> dictionary_0;

		public int int_3;

		public Queue<int> queue_0;

		public List<string> list_2;

		public Class119 class119_1;

		public bool bool_2;

		public Class222 class222_1;

		public Class83 class83_1;

		public List<string> list_3;

		public Class119 class119_2;

		public bool bool_3;

		public Class222 class222_2;

		public List<string> list_4;

		public Class119 class119_3;

		public Class119 class119_4;

		public bool bool_4;

		public Class222 class222_3;

		public Class403 class403_1;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
			JObject jObject = JObject.Parse(string_0);
			string text = (string?)jObject["cmd"];
			if (text == "move")
			{
				int_0++;
				int_1 = 0;
				bool_0 = false;
				if (int_0 > 1)
				{
					list_1.Add(Tuple.Create(class403_0.float_0, class403_0.float_2));
				}
			}
			else if (text == "pick")
			{
				if (int_0 != 0 && !bool_0)
				{
					bool_1 = true;
				}
				class119_0.method_145((uint)jObject["id"], (byte)jObject["type"], (uint)jObject["req"], bool_17: true, null);
			}
		}

		internal Task method_1(int int_4)
		{
			long_0 += int_4;
			int_1++;
			JObject jObject = JObject.Parse(list_0.Last());
			float num = (float)jObject["x"];
			float float_ = (float)jObject["y"];
			float float_2 = (float)jObject["z"];
			if (int_0 == 1 && int_1 == 1)
			{
				class83_0 = new Class83
				{
					float_0 = num + 0.251f,
					float_1 = float_,
					float_2 = float_2
				};
			}
			else
			{
				class83_0 = new Class83
				{
					float_0 = num + ((int_0 == 1) ? 0.25f : 0f),
					float_1 = float_,
					float_2 = float_2
				};
				bool_0 = true;
				if (int_0 == 1)
				{
					int_2 = int_1;
				}
			}
			class222_0.method_0(smethod_113(new List<Class403> { class403_0 }, dictionary_0, class83_0, ++int_3), bool_0: true);
			return Task.CompletedTask;
		}

		internal int method_2(int int_4, int int_5)
		{
			return queue_0.Dequeue();
		}

		internal long method_3()
		{
			return long_0;
		}

		internal void method_4(string string_0)
		{
			list_2.Add(string_0);
			JObject jObject = JObject.Parse(string_0);
			if ((string?)jObject["cmd"] == "pick")
			{
				class119_1.method_145((uint)jObject["id"], (byte)jObject["type"], (uint)jObject["req"], bool_17: true, null);
			}
		}

		internal Task method_5(int int_4)
		{
			long_0 += int_4;
			if (bool_2)
			{
				class222_1.method_0(smethod_113(new List<Class403>(), dictionary_0, class83_1, ++int_3), bool_0: true);
			}
			return Task.CompletedTask;
		}

		internal long method_6()
		{
			return long_0;
		}

		internal void method_7(string string_0)
		{
			list_3.Add(string_0);
			JObject jObject = JObject.Parse(string_0);
			if ((string?)jObject["cmd"] == "pick")
			{
				class119_2.method_145((uint)jObject["id"], (byte)jObject["type"], (uint)jObject["req"], bool_17: true, null);
			}
		}

		internal long method_8()
		{
			return long_0;
		}

		internal Task method_9(int int_4)
		{
			long_0 += int_4;
			if (bool_3)
			{
				class222_2.gform0_0.bool_3 = true;
			}
			return Task.CompletedTask;
		}

		internal void method_10(string string_0)
		{
			list_3.Add(string_0);
			JObject jObject = JObject.Parse(string_0);
			if ((string?)jObject["cmd"] == "pick")
			{
				class119_2.method_145((uint)jObject["id"], (byte)jObject["type"], (uint)jObject["req"], bool_17: true, null);
			}
		}

		internal void method_11(string string_0)
		{
			list_4.Add(string_0);
			JObject jObject = JObject.Parse(string_0);
			if ((string?)jObject["cmd"] == "pick")
			{
				class119_3.method_145((uint)jObject["id"], (byte)jObject["type"], (uint)jObject["req"], bool_17: true, null);
			}
		}

		internal void method_12(string string_0)
		{
			list_4.Add(string_0);
			JObject jObject = JObject.Parse(string_0);
			if ((string?)jObject["cmd"] == "pick")
			{
				class119_4.method_145((uint)jObject["id"], (byte)jObject["type"], (uint)jObject["req"], bool_17: true, null);
			}
		}

		internal Task method_13(int int_4)
		{
			long_0 += int_4;
			if (bool_4)
			{
				bool_4 = false;
				class222_3.method_1(class119_4, smethod_113(new List<Class403> { class403_1 }, dictionary_0, class83_1, ++int_3), bool_0: true);
			}
			return Task.CompletedTask;
		}

		internal long method_14()
		{
			return long_0;
		}
	}

	private sealed class Class280
	{
		public int int_0;

		public Class220 class220_0;

		internal void method_0(string string_0)
		{
			if (string_0.IndexOf("\"cmd\":\"census_raw\"", StringComparison.Ordinal) >= 0)
			{
				int_0++;
				if (int_0 == 1)
				{
					class220_0.class339_0.method_0(new List<Class403>(), null);
					return;
				}
				class220_0.class339_0.method_0(new List<Class403>
				{
					new Class403
					{
						byte_0 = 100,
						byte_1 = 4,
						uint_0 = 77u
					}
				}, "Hero77");
			}
		}
	}

	private sealed class Class281
	{
		public int int_0;

		internal void method_0(object sender, EventArgs e)
		{
			int_0++;
		}
	}

	private sealed class Class282
	{
		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		internal readonly string string_3;

		internal Class282(string string_4, string string_5, string string_6, string string_7 = null)
		{
			string_0 = string_4;
			string_1 = string_5;
			string_2 = string_6;
			string_3 = string_7 ?? (string_5 + "." + string_6);
		}
	}

	private sealed class Class283
	{
		public Class222 class222_0;

		public List<string> list_0;

		public long long_0;

		public List<int> list_1;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
		}

		internal long method_1()
		{
			return long_0;
		}

		internal Task method_2(int int_0)
		{
			list_1.Add(int_0);
			long_0 += int_0;
			if (long_0 == 1000L)
			{
				class222_0.method_0(class222_0.gform0_0.method_5().method_104("boundary"), bool_0: true);
			}
			return Task.CompletedTask;
		}
	}

	private sealed class Class284
	{
		public Class222 class222_0;

		internal void method_0()
		{
			class222_0.gform0_0.bool_3 = true;
		}

		internal void method_1(object sender, EventArgs e)
		{
			class222_0.gform0_0.bool_3 = true;
		}

		internal void method_2(object sender, EventArgs e)
		{
			class222_0.gform0_0.bool_3 = true;
		}
	}

	private sealed class Class285
	{
		public Class222 class222_0;

		public List<string> list_0;

		public long long_0;

		public int int_0;

		public Class223 class223_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
			class222_0.method_0(class223_0.class145_0, bool_0: true);
		}

		internal long method_1()
		{
			return long_0;
		}

		internal Task method_2(int int_1)
		{
			int_0++;
			long_0 += int_1;
			if (int_0 == 2)
			{
				class222_0.method_0(class223_0.class145_1, bool_0: true);
			}
			return Task.CompletedTask;
		}
	}

	private sealed class Class286
	{
		internal string string_0;

		internal string string_1;

		internal double double_0;

		internal bool bool_0;

		internal string string_2;

		internal double double_1;

		internal bool bool_1;

		internal string string_3;

		internal string string_4;

		internal string string_5;
	}

	private sealed class Class287
	{
		public int int_0;

		internal void method_0()
		{
			Interlocked.Increment(ref int_0);
		}

		internal bool method_1()
		{
			return Volatile.Read(ref int_0) == 1;
		}
	}

	private sealed class Class288
	{
		public Class145 class145_0;

		public HashSet<string> hashSet_0;

		public (ushort, ushort)[] valueTuple_0;

		internal List<Class53> method_0()
		{
			return Class144.smethod_1(class145_0, "Hero", hashSet_0, 9, valueTuple_0);
		}

		internal List<Class53> method_1()
		{
			return Class144.smethod_0(class145_0, "Hero", hashSet_0);
		}
	}

	private sealed class Class289
	{
		public Class222 class222_0;

		public Class145 class145_0;

		public Class145 class145_1;

		internal void method_0()
		{
			for (int i = 0; i < 20000; i++)
			{
				class222_0.method_0(((i & 1) == 0) ? class145_0 : class145_1, bool_0: true);
			}
		}
	}

	private sealed class Class290
	{
		private readonly string string_0;

		private readonly Action action_0;

		private bool bool_0;

		internal Class290(string string_1, Action action_1)
		{
			string_0 = string_1;
			action_0 = action_1;
		}

		public override string ToString()
		{
			if (!bool_0)
			{
				bool_0 = true;
				if (action_0 != null)
				{
					action_0();
				}
			}
			return string_0;
		}
	}

	private sealed class Class291
	{
		public string string_0;

		internal void method_0(string string_1)
		{
			string_0 = string_1;
		}
	}

	private sealed class Class292
	{
		public Class119 class119_0;

		internal void method_0()
		{
			class119_0.method_178("hold");
		}
	}

	private sealed class Class293
	{
		public List<string> list_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
		}
	}

	private sealed class Class294
	{
		public Class339 class339_0;

		public Class300 class300_0;

		internal void method_0(string string_0)
		{
			if (string_0.IndexOf("\"cmd\":\"census_raw\"", StringComparison.Ordinal) >= 0)
			{
				class339_0.method_0(new List<Class403>
				{
					new Class403
					{
						byte_0 = 100,
						byte_1 = 4,
						uint_0 = 77u
					}
				}, "Hero77");
			}
		}

		internal object method_1(string string_0, Class119 class119_0, Func<object> func_0)
		{
			object result = func_0();
			class339_0.method_2(class119_0, bool_0: false);
			return result;
		}

		internal Task method_2()
		{
			return (Task)class300_0.methodInfo_0.Invoke(class339_0.gform0_0, new object[2] { class339_0.class119_0, class339_0.long_0 });
		}
	}

	private sealed class Class295
	{
		public Class270 class270_0;

		internal void method_0(string string_0, uint uint_0, string string_1, int int_0)
		{
			class270_0.list_0.Add(uint_0 + ":" + string_1);
		}

		internal void method_1(string string_0, uint uint_0, string string_1, double double_0, string string_2, int int_0)
		{
			class270_0.list_1.Add(uint_0 + ":" + (string_1 ?? "null"));
		}
	}

	private sealed class Class296
	{
		public int int_0;

		internal void method_0()
		{
			Interlocked.Increment(ref int_0);
		}
	}

	private sealed class Class297
	{
		public int int_0;

		internal void method_0()
		{
			Interlocked.Increment(ref int_0);
		}

		internal bool method_1()
		{
			return Volatile.Read(ref int_0) == 1;
		}
	}

	private sealed class Class298
	{
		private readonly Exception exception_0;

		internal Class298(Exception exception_1)
		{
			exception_0 = exception_1;
		}

		public override string ToString()
		{
			throw exception_0;
		}
	}

	[Serializable]
	private sealed class Class299
	{
		public static readonly Class299 class299_0 = new Class299();

		public static Predicate<string> predicate_0;

		public static Predicate<string> predicate_1;

		public static Predicate<string> predicate_2;

		public static Func<int, bool> func_0;

		public static Func<int, bool> func_1;

		public static Action action_0;

		public static Action action_1;

		public static Action action_2;

		public static Action action_3;

		public static Action action_4;

		public static Action action_5;

		public static Func<byte, bool> func_2;

		public static Func<byte, bool> func_3;

		public static Predicate<string> predicate_3;

		public static Func<Class175> func_4;

		public static Func<int, bool> func_5;

		public static Func<int, bool> func_6;

		public static Func<int, bool> func_7;

		public static Func<int, bool> func_8;

		public static Func<string, bool> func_9;

		public static Func<string, bool> func_10;

		public static Action<string> action_6;

		public static Action<string> action_7;

		public static Func<int, ulong, string> func_11;

		public static Func<Class87> func_12;

		public static Func<Class87> func_13;

		public static Func<Class87> func_14;

		public static Action<int> action_8;

		public static Func<string, bool> func_15;

		public static Func<string, bool> func_16;

		public static Action<int> action_9;

		public static Func<string, bool> func_17;

		public static Action<int> action_10;

		public static Func<string, bool> func_18;

		public static Action<int> action_11;

		public static Func<string, bool> func_19;

		public static Func<Enum3> func_20;

		public static Func<string, bool> func_21;

		public static Func<Enum3> func_22;

		public static Func<string, bool> func_23;

		public static Func<string, bool> func_24;

		public static Func<int, bool> func_25;

		public static Func<Class87> func_26;

		public static Func<Class9> func_27;

		public static Func<int, string> func_28;

		public static Func<bool> func_29;

		public static Func<int, bool> func_30;

		public static Func<int, bool> func_31;

		public static Func<int, bool> func_32;

		public static Func<int, bool> func_33;

		public static Func<int, bool> func_34;

		public static Func<int, bool> func_35;

		public static Func<string, int> func_36;

		public static Func<int, bool> func_37;

		public static Func<string, string> func_38;

		public static Predicate<string> predicate_4;

		public static Predicate<string> predicate_5;

		public static Func<int> func_39;

		public static Func<int> func_40;

		public static Action<string> action_12;

		public static Func<string, bool> func_41;

		public static Func<string, bool> func_42;

		public static Func<JObject, bool> func_43;

		public static Func<JObject, bool> func_44;

		public static Func<int, int, int> func_45;

		public static Func<string, bool> func_46;

		public static Func<string, bool> func_47;

		public static Func<int, int, int> func_48;

		public static Func<string, bool> func_49;

		public static Func<string, bool> func_50;

		public static Func<string, bool> func_51;

		public static Func<string, bool> func_52;

		public static Func<string, bool> func_53;

		public static Func<string, bool> func_54;

		public static Func<int, int, int> func_55;

		public static Func<string, bool> func_56;

		public static Func<string, bool> func_57;

		public static Func<string, bool> func_58;

		public static Func<string, bool> func_59;

		public static Func<string, bool> func_60;

		public static Func<string, bool> func_61;

		public static Func<string, bool> func_62;

		public static Func<string, bool> func_63;

		public static Func<int, Task> func_64;

		public static Func<MethodInfo, bool> func_65;

		public static Func<MethodInfo, bool> func_66;

		public static Func<MethodInfo, bool> func_67;

		public static Func<MethodInfo, bool> func_68;

		public static Func<MethodInfo, bool> func_69;

		public static Func<int, Task> func_70;

		public static Func<int, Task> func_71;

		public static Func<int, Task> func_72;

		public static Action<string> action_13;

		public static Func<int, Task> func_73;

		public static Func<int, Task> func_74;

		public static Func<int, Task> func_75;

		public static Func<int, Task> func_76;

		public static Func<int, Task> func_77;

		public static Func<int, Task> func_78;

		public static Func<string, bool> func_79;

		public static Action<string> action_14;

		public static Func<string, TimeSpan, TimeSpan, CancellationToken, Task<bool>> func_80;

		public static Func<string, bool> func_81;

		public static Func<string, TimeSpan, TimeSpan, CancellationToken, Task<bool>> func_82;

		public static Predicate<string> predicate_6;

		public static Func<string, bool> func_83;

		public static Action<string> action_15;

		public static Func<string, TimeSpan, TimeSpan, CancellationToken, Task<bool>> func_84;

		public static Func<string, bool> func_85;

		public static Action<Action> action_16;

		public static Func<string, TimeSpan, TimeSpan, CancellationToken, Task<bool>> func_86;

		public static Predicate<string> predicate_7;

		public static Predicate<string> predicate_8;

		public static Func<string, bool> func_87;

		public static Action<string> action_17;

		public static Func<string, TimeSpan, TimeSpan, CancellationToken, Task<bool>> func_88;

		public static Func<Class1, bool> func_89;

		public static Func<string> func_90;

		public static Func<ParameterInfo, Type> func_91;

		public static Func<MethodInfo, bool> func_92;

		public static Func<char, bool> func_93;

		public static Action<string> action_18;

		public static Action<string> action_19;

		public static Func<string, string> func_94;

		public static Action<string> action_20;

		public static Action<string> action_21;

		public static Action<string> action_22;

		public static Action<Class270, Class218, double> action_23;

		public static Action action_24;

		public static Action<string, uint, string, double, string, int> action_25;

		public static Action<string> action_26;

		public static Func<string, bool> func_95;

		public static Func<int, bool> func_96;

		public static Func<int, bool> func_97;

		public static Action<string> action_27;

		public static Func<int, bool> func_98;

		public static Func<CancellationToken, Task<string>> func_99;

		public static Func<Class438, string, bool> func_100;

		public static Func<bool> func_101;

		public static Action<string> action_28;

		public static Func<Class438, bool> func_102;

		public static Func<Class438, bool> func_103;

		public static Func<Class438, string, bool> func_104;

		public static Func<bool> func_105;

		public static Action<string> action_29;

		public static Func<CancellationToken, Task<string>> func_106;

		public static Func<Class438, bool> func_107;

		public static Func<Class438, string, bool> func_108;

		public static Func<bool> func_109;

		public static Action<string> action_30;

		public static Func<CancellationToken, Task<string>> func_110;

		public static Func<string, CancellationToken, Task<Class438>> func_111;

		public static Func<bool> func_112;

		public static Func<Class438, bool> func_113;

		public static Func<Class438, string, bool> func_114;

		public static Func<bool> func_115;

		public static Action<string> action_31;

		public static Func<CancellationToken, Task<string>> func_116;

		public static Func<bool> func_117;

		public static Action<string> action_32;

		public static Func<Class53, bool> func_118;

		public static Func<Class53, bool> func_119;

		public static Func<Class53, bool> func_120;

		public static Func<Class53, bool> func_121;

		public static Func<Class53, bool> func_122;

		public static Func<Class53, bool> func_123;

		public static Func<Class53, bool> func_124;

		public static Func<Class53, bool> func_125;

		public static Func<DataGridViewRow, bool> func_126;

		public static Func<int, Task> func_127;

		public static Func<Class381, bool> func_128;

		public static Func<Class381, bool> func_129;

		public static Func<Class381, bool> func_130;

		public static Func<Class381, bool> func_131;

		internal bool method_0(string string_0)
		{
			if (string_0.Contains(".libshare.so.stage."))
			{
				return string_0.Contains("mv -n");
			}
			return false;
		}

		internal bool method_1(string string_0)
		{
			if (string_0.Contains("chown 0:0 $p/8") && string_0.Contains("chown 0:0 $p/7"))
			{
				return string_0.Contains("chown 0:0 $p/6");
			}
			return false;
		}

		internal bool method_2(string string_0)
		{
			if (string_0.Contains("CAPY_DEPLOY="))
			{
				return string_0.Length < 4000;
			}
			return false;
		}

		internal bool method_3(int int_0)
		{
			return false;
		}

		internal bool method_4(int int_0)
		{
			return true;
		}

		internal void method_5()
		{
			Class103.smethod_2(new Class175(string.Empty, "device", "server", "https://unit.example"));
		}

		internal void method_6()
		{
			Class103.smethod_2(new Class175("license", string.Empty, "server", "https://unit.example"));
		}

		internal void method_7()
		{
			Class103.smethod_2(new Class175("license", "device\n", "server", "https://unit.example"));
		}

		internal void method_8()
		{
			Class103.smethod_2(new Class175(new string('x', 1025), "device", "server", "https://unit.example"));
		}

		internal void method_9()
		{
			Class103.smethod_2(new Class175("license", "device\ud800", "server", "https://unit.example"));
		}

		internal void method_10()
		{
			Class103.smethod_4(smethod_18(new string('0', 63) + "2"), new byte[65], new byte[65]);
		}

		internal bool method_11(byte byte_0)
		{
			return byte_0 == 0;
		}

		internal bool method_12(byte byte_0)
		{
			return byte_0 == 0;
		}

		internal bool method_13(string string_0)
		{
			if (string_0.IndexOf("secret-license", StringComparison.Ordinal) < 0)
			{
				return string_0.IndexOf("current-device", StringComparison.Ordinal) < 0;
			}
			return false;
		}

		internal Class175 method_14()
		{
			return new Class175(string.Empty, string.Empty, "ran-origin", "https://worker.example");
		}

		internal bool method_15(int int_0)
		{
			return false;
		}

		internal bool method_16(int int_0)
		{
			return true;
		}

		internal bool method_17(int int_0)
		{
			return true;
		}

		internal bool method_18(int int_0)
		{
			return true;
		}

		internal bool method_19(string string_0)
		{
			return string_0.IndexOf("\"cmd\":\"frame_hook\"", StringComparison.Ordinal) >= 0;
		}

		internal bool method_20(string string_0)
		{
			return string_0.IndexOf("\"cmd\":\"sub\"", StringComparison.Ordinal) >= 0;
		}

		internal void method_21(string string_0)
		{
		}

		internal void method_22(string string_0)
		{
		}

		internal string method_23(int int_0, ulong ulong_0)
		{
			return int_0 + " (runner name with ) parenthesis) S 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 " + ulong_0 + " 20";
		}

		internal Class87 method_24()
		{
			return new Class87(Enum1.Unhealthy, 0, 0, "no listener");
		}

		internal Class87 method_25()
		{
			return new Class87(Enum1.Unhealthy, 0, 0, "no listener");
		}

		internal Class87 method_26()
		{
			return new Class87(Enum1.Unhealthy, 0, 0, "no listener");
		}

		internal void method_27(int int_0)
		{
		}

		internal bool method_28(string string_0)
		{
			if (string_0.Contains("kill $pid"))
			{
				return string_0.Contains("KLX_SIGNAL_SENT");
			}
			return false;
		}

		internal bool method_29(string string_0)
		{
			return string_0.Contains("kill 3776");
		}

		internal void method_30(int int_0)
		{
		}

		internal bool method_31(string string_0)
		{
			return string_0.Contains("KLX_SIGNAL_MISMATCH");
		}

		internal void method_32(int int_0)
		{
		}

		internal bool method_33(string string_0)
		{
			if (!string_0.Contains(" kill ") && !string_0.Contains("rm -f"))
			{
				return string_0.Contains(".klxsvc --port");
			}
			return true;
		}

		internal void method_34(int int_0)
		{
		}

		internal bool method_35(string string_0)
		{
			if (!string_0.Contains(" kill ") && !string_0.Contains("rm -f"))
			{
				return string_0.Contains(".klxsvc --port");
			}
			return true;
		}

		internal Enum3 method_36()
		{
			return Enum3.Current;
		}

		internal bool method_37(string string_0)
		{
			if (!string_0.Contains(" kill ") && !string_0.Contains(".klxsvc --port"))
			{
				return string_0.Contains("rm -f");
			}
			return true;
		}

		internal Enum3 method_38()
		{
			return Enum3.Current;
		}

		internal bool method_39(string string_0)
		{
			return string_0.Contains("echo 4512 > /data/local/tmp/.klxsvc.pid");
		}

		internal bool method_40(string string_0)
		{
			if (!string_0.Contains(" kill "))
			{
				return string_0.Contains(".klxsvc --port");
			}
			return true;
		}

		internal bool method_41(int int_0)
		{
			return true;
		}

		internal Class87 method_42()
		{
			return new Class87(Enum1.Unhealthy, 0, 0, "no listener");
		}

		internal Class9 method_43()
		{
			return new Class9(null, 27060);
		}

		internal string method_44(int int_0)
		{
			return null;
		}

		internal bool method_45()
		{
			return true;
		}

		internal bool method_46(int int_0)
		{
			return true;
		}

		internal bool method_47(int int_0)
		{
			return true;
		}

		internal bool method_48(int int_0)
		{
			return true;
		}

		internal bool method_49(int int_0)
		{
			return true;
		}

		internal bool method_50(int int_0)
		{
			return true;
		}

		internal bool method_51(int int_0)
		{
			return true;
		}

		internal int method_52(string string_0)
		{
			if (!int.TryParse(string_0, out var result))
			{
				return 0;
			}
			return result;
		}

		internal bool method_53(int int_0)
		{
			return int_0 > 0;
		}

		internal string method_54(string string_0)
		{
			return (string_0 ?? string.Empty).Replace("\r", "\\r").Replace("\n", "\\n");
		}

		internal bool method_55(string string_0)
		{
			return string_0.Contains("\"cmd\":\"attack_stop\"");
		}

		internal bool method_56(string string_0)
		{
			return string_0.Contains("\"cmd\":\"attack_stop\"");
		}

		internal int method_57()
		{
			return 1;
		}

		internal int method_58()
		{
			return Thread.CurrentThread.ManagedThreadId;
		}

		internal void method_59(string string_0)
		{
		}

		internal bool method_60(string string_0)
		{
			return string_0.Contains("\"cmd\":\"pick\"");
		}

		internal bool method_61(string string_0)
		{
			return string_0.Contains("\"cmd\":\"move\"");
		}

		internal bool method_62(JObject jobject_0)
		{
			return (string?)jobject_0["cmd"] == "move";
		}

		internal bool method_63(JObject jobject_0)
		{
			return (string?)jobject_0["cmd"] == "pick";
		}

		internal int method_64(int int_0, int int_1)
		{
			return int_0;
		}

		internal bool method_65(string string_0)
		{
			return string_0.Contains("\"cmd\":\"pick\"");
		}

		internal bool method_66(string string_0)
		{
			return string_0.Contains("\"cmd\":\"pick\"");
		}

		internal int method_67(int int_0, int int_1)
		{
			return int_0;
		}

		internal bool method_68(string string_0)
		{
			return string_0.Contains("\"cmd\":\"pick\"");
		}

		internal bool method_69(string string_0)
		{
			return string_0.Contains("\"cmd\":\"pick\"");
		}

		internal bool method_70(string string_0)
		{
			return string_0.Contains("\"cmd\":\"pick\"");
		}

		internal bool method_71(string string_0)
		{
			return string_0.Contains("\"cmd\":\"pick\"");
		}

		internal bool method_72(string string_0)
		{
			return string_0.Contains("\"cmd\":\"pick\"");
		}

		internal bool method_73(string string_0)
		{
			return string_0.Contains("\"cmd\":\"pick\"");
		}

		internal int method_74(int int_0, int int_1)
		{
			return int_0;
		}

		internal bool method_75(string string_0)
		{
			return string_0.Contains("\"cmd\":\"pick\"");
		}

		internal bool method_76(string string_0)
		{
			return string_0.Contains("\"cmd\":\"pick\"");
		}

		internal bool method_77(string string_0)
		{
			return string_0.Contains("\"cmd\":\"attack_stop\"");
		}

		internal bool method_78(string string_0)
		{
			return string_0.Contains("\"cmd\":\"pick\"");
		}

		internal bool method_79(string string_0)
		{
			return string_0.Contains("\"cmd\":\"pick\"");
		}

		internal bool method_80(string string_0)
		{
			return string_0.Contains("\"cmd\":\"pick\"");
		}

		internal bool method_81(string string_0)
		{
			return string_0.Contains("\"cmd\":\"move\"");
		}

		internal bool method_82(string string_0)
		{
			return string_0.Contains("\"cmd\":\"move\"");
		}

		internal Task method_83(int int_0)
		{
			return Task.CompletedTask;
		}

		internal bool method_84(MethodInfo methodInfo_0)
		{
			if (!(methodInfo_0.Name == "BackToStartAsync") && !(methodInfo_0.Name == "BackToRecentAsync"))
			{
				return methodInfo_0.Name == "WarpToFriendAsync";
			}
			return true;
		}

		internal bool method_85(MethodInfo methodInfo_0)
		{
			return !methodInfo_0.Name.EndsWith("CoreAsync", StringComparison.Ordinal);
		}

		internal bool method_86(MethodInfo methodInfo_0)
		{
			if (methodInfo_0.Name == "BackToStartAsync")
			{
				return methodInfo_0.GetParameters().Length == 4;
			}
			return false;
		}

		internal bool method_87(MethodInfo methodInfo_0)
		{
			if (methodInfo_0.Name == "BackToRecentAsync")
			{
				return methodInfo_0.GetParameters().Length == 4;
			}
			return false;
		}

		internal bool method_88(MethodInfo methodInfo_0)
		{
			if (methodInfo_0.Name == "WarpToFriendAsync")
			{
				return methodInfo_0.GetParameters().Length == 5;
			}
			return false;
		}

		internal Task method_89(int int_0)
		{
			return Task.CompletedTask;
		}

		internal Task method_90(int int_0)
		{
			return Task.CompletedTask;
		}

		internal Task method_91(int int_0)
		{
			return Task.CompletedTask;
		}

		internal void method_92(string string_0)
		{
		}

		internal Task method_93(int int_0)
		{
			return Task.CompletedTask;
		}

		internal Task method_94(int int_0)
		{
			return Task.CompletedTask;
		}

		internal Task method_95(int int_0)
		{
			return Task.CompletedTask;
		}

		internal Task method_96(int int_0)
		{
			return Task.CompletedTask;
		}

		internal Task method_97(int int_0)
		{
			return Task.CompletedTask;
		}

		internal Task method_98(int int_0)
		{
			return Task.CompletedTask;
		}

		internal bool method_99(string string_0)
		{
			return false;
		}

		internal void method_100(string string_0)
		{
		}

		internal Task<bool> method_101(string string_0, TimeSpan timeSpan_0, TimeSpan timeSpan_1, CancellationToken cancellationToken_0)
		{
			return Task.FromResult(result: true);
		}

		internal bool method_102(string string_0)
		{
			throw new InvalidOperationException("private-detail");
		}

		internal Task<bool> method_103(string string_0, TimeSpan timeSpan_0, TimeSpan timeSpan_1, CancellationToken cancellationToken_0)
		{
			return Task.FromResult(result: true);
		}

		internal bool method_104(string string_0)
		{
			if (string_0.Contains("reason=process-enumeration-failed") && string_0.Contains("process=fault-probe"))
			{
				return string_0.IndexOf("private-detail", StringComparison.Ordinal) < 0;
			}
			return false;
		}

		internal bool method_105(string string_0)
		{
			return false;
		}

		internal void method_106(string string_0)
		{
		}

		internal Task<bool> method_107(string string_0, TimeSpan timeSpan_0, TimeSpan timeSpan_1, CancellationToken cancellationToken_0)
		{
			return Task.FromResult(result: true);
		}

		internal bool method_108(string string_0)
		{
			return false;
		}

		internal void method_109(Action action_33)
		{
			throw new InvalidOperationException("dispatcher-private-detail");
		}

		internal Task<bool> method_110(string string_0, TimeSpan timeSpan_0, TimeSpan timeSpan_1, CancellationToken cancellationToken_0)
		{
			return Task.FromResult(result: true);
		}

		internal bool method_111(string string_0)
		{
			return string_0.Contains("reason=ui-dispatch-failed");
		}

		internal bool method_112(string string_0)
		{
			return string_0.IndexOf("dispatcher-private-detail", StringComparison.Ordinal) < 0;
		}

		internal bool method_113(string string_0)
		{
			return false;
		}

		internal void method_114(string string_0)
		{
		}

		internal Task<bool> method_115(string string_0, TimeSpan timeSpan_0, TimeSpan timeSpan_1, CancellationToken cancellationToken_0)
		{
			return Task.FromResult(result: true);
		}

		internal bool method_116(Class1 class1_0)
		{
			return class1_0.UInt32_0 == 19;
		}

		internal string method_117()
		{
			return "HitCbara";
		}

		internal bool method_118(MethodInfo methodInfo_0)
		{
			if (methodInfo_0.ReturnType == typeof(void))
			{
				return methodInfo_0.GetParameters().Select(class299_0.method_119).SequenceEqual(new Type[4]
				{
					typeof(IntPtr),
					typeof(IntPtr),
					typeof(int),
					typeof(IntPtr)
				});
			}
			return false;
		}

		internal Type method_119(ParameterInfo parameterInfo_0)
		{
			return parameterInfo_0.ParameterType;
		}

		internal bool method_120(char char_0)
		{
			return char_0 <= '\u007f';
		}

		internal void method_121(string string_0)
		{
			Console.WriteLine(string_0);
		}

		internal void method_122(string string_0)
		{
			Console.WriteLine(string_0);
		}

		internal string method_123(string string_0)
		{
			return string_0;
		}

		internal void method_124(string string_0)
		{
			Console.WriteLine(string_0);
		}

		internal void method_125(string string_0)
		{
			Console.WriteLine(string_0);
		}

		internal void method_126(Class270 class270_0, Class218 class218_0, double double_0)
		{
			Class295 @class = new Class295();
			@class.class270_0 = class270_0;
			@class.class270_0.class351_0 = new Class351(class218_0, @class.class270_0.method_0, @class.method_0, @class.method_1, @class.class270_0.method_2(double_0, 0.0, 0.2, 0.0), class299_0.method_127);
		}

		internal void method_127(string string_0)
		{
		}

		internal void method_128()
		{
			Thread.Sleep(500);
		}

		internal void method_129(string string_0, uint uint_0, string string_1, double double_0, string string_2, int int_0)
		{
		}

		internal void method_130(string string_0)
		{
		}

		internal bool method_131(string string_0)
		{
			return string_0.StartsWith("rebirth: ");
		}

		internal bool method_132(int int_0)
		{
			return true;
		}

		internal bool method_133(int int_0)
		{
			return true;
		}

		internal void method_134(string string_0)
		{
			throw new InvalidOperationException("post failed");
		}

		internal bool method_135(int int_0)
		{
			return true;
		}

		internal Task<string> method_136(CancellationToken cancellationToken_0)
		{
			return Task.FromResult("token");
		}

		internal bool method_137(Class438 class438_0, string string_0)
		{
			return true;
		}

		internal bool method_138()
		{
			return false;
		}

		internal void method_139(string string_0)
		{
		}

		internal bool method_140(Class438 class438_0)
		{
			return true;
		}

		internal bool method_141(Class438 class438_0)
		{
			return true;
		}

		internal bool method_142(Class438 class438_0, string string_0)
		{
			return true;
		}

		internal bool method_143()
		{
			return true;
		}

		internal void method_144(string string_0)
		{
		}

		internal Task<string> method_145(CancellationToken cancellationToken_0)
		{
			return Task.FromResult("token");
		}

		internal bool method_146(Class438 class438_0)
		{
			return false;
		}

		internal bool method_147(Class438 class438_0, string string_0)
		{
			return true;
		}

		internal bool method_148()
		{
			return false;
		}

		internal void method_149(string string_0)
		{
		}

		internal Task<string> method_150(CancellationToken cancellationToken_0)
		{
			return Task.FromResult("secret-sentinel-token");
		}

		internal Task<Class438> method_151(string string_0, CancellationToken cancellationToken_0)
		{
			return Task.FromException<Class438>(new InvalidOperationException("secret-sentinel-token"));
		}

		internal bool method_152()
		{
			return false;
		}

		internal bool method_153(Class438 class438_0)
		{
			return true;
		}

		internal bool method_154(Class438 class438_0, string string_0)
		{
			return true;
		}

		internal bool method_155()
		{
			return false;
		}

		internal void method_156(string string_0)
		{
		}

		internal Task<string> method_157(CancellationToken cancellationToken_0)
		{
			return Task.FromResult("runtime-read-token");
		}

		internal bool method_158()
		{
			return false;
		}

		internal void method_159(string string_0)
		{
		}

		internal bool method_160(Class53 class53_0)
		{
			if (class53_0.string_0 == "Hero")
			{
				return class53_0.bool_0;
			}
			return false;
		}

		internal bool method_161(Class53 class53_0)
		{
			if (class53_0.string_0 == "Teammate")
			{
				return class53_0.bool_0;
			}
			return false;
		}

		internal bool method_162(Class53 class53_0)
		{
			return class53_0.string_0 != "Stranger";
		}

		internal bool method_163(Class53 class53_0)
		{
			if (class53_0.string_0 == "Hero")
			{
				return class53_0.string_1 == "12.34";
			}
			return false;
		}

		internal bool method_164(Class53 class53_0)
		{
			if (class53_0.string_0 == "Teammate")
			{
				return class53_0.string_1 == "0.00";
			}
			return false;
		}

		internal bool method_165(Class53 class53_0)
		{
			if (class53_0.string_0 == "Hero")
			{
				return class53_0.string_1 == "45.50";
			}
			return false;
		}

		internal bool method_166(Class53 class53_0)
		{
			if (class53_0.string_0 == "Teammate")
			{
				return class53_0.string_1 == "?";
			}
			return false;
		}

		internal bool method_167(Class53 class53_0)
		{
			if (class53_0.string_0 == "Teammate")
			{
				return !class53_0.bool_0;
			}
			return false;
		}

		internal bool method_168(DataGridViewRow dataGridViewRow_0)
		{
			if ((string)dataGridViewRow_0.Cells[1].Value == "Hero")
			{
				return (bool)dataGridViewRow_0.Cells[0].Value;
			}
			return false;
		}

		internal Task method_169(int int_0)
		{
			return Task.CompletedTask;
		}

		internal bool method_170(Class381 class381_0)
		{
			return class381_0.string_0 == "Stranger";
		}

		internal bool method_171(Class381 class381_0)
		{
			return class381_0.string_0 != "Gone";
		}

		internal bool method_172(Class381 class381_0)
		{
			if (class381_0.string_0 == "Gone")
			{
				return !class381_0.bool_2;
			}
			return false;
		}

		internal bool method_173(Class381 class381_0)
		{
			return class381_0.string_0 != "Stranger";
		}
	}

	private sealed class Class300
	{
		public MethodInfo methodInfo_0;
	}

	private sealed class Class301
	{
		public long long_0;

		internal long method_0()
		{
			return long_0;
		}

		internal long method_1()
		{
			return long_0;
		}
	}

	private sealed class Class302 : SynchronizationContext
	{
		public override void Post(SendOrPostCallback d, object state)
		{
			d(state);
		}
	}

	private sealed class Class303
	{
		public MethodInfo methodInfo_0;

		public GForm0 gform0_0;

		public Class119 class119_0;

		public Class119 class119_1;

		public int int_0;

		internal void method_0()
		{
			try
			{
				for (int i = 0; i < 20000; i++)
				{
					methodInfo_0.Invoke(gform0_0, new object[1] { class119_0 });
					methodInfo_0.Invoke(gform0_0, new object[1]);
					methodInfo_0.Invoke(gform0_0, new object[1] { class119_1 });
				}
			}
			catch
			{
				Interlocked.Increment(ref int_0);
			}
		}
	}

	private sealed class Class304
	{
		public Class119 class119_0;

		internal void method_0()
		{
			class119_0.method_178("{}");
		}

		internal void method_1()
		{
			class119_0.method_78(27043);
		}
	}

	private sealed class Class305
	{
		public Class222 class222_0;

		internal Enum9 method_0()
		{
			using (Class75.smethod_1(new Class264
			{
				long_0 = 0L
			}.method_0, 1000L, Class299.class299_0.method_95, bool_0: false, bool_1: false))
			{
				return Class179.smethod_0(class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult();
			}
		}

		internal Enum9 method_1()
		{
			using (Class75.smethod_1(new Class326
			{
				long_0 = 0L
			}.method_0, 1000L, Class299.class299_0.method_96, bool_0: true, bool_1: true))
			{
				return Class179.smethod_0(class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult();
			}
		}
	}

	private sealed class Class306
	{
		internal readonly List<string> list_0 = new List<string>();

		internal bool bool_0;

		internal string string_0;

		internal string string_1;

		internal bool bool_1;

		internal bool bool_2;

		internal bool bool_3;

		internal bool bool_4;

		internal bool bool_5;

		internal bool bool_6;

		internal int int_0;

		internal int int_1;

		private readonly string string_2;

		private readonly string string_3;

		private readonly string string_4;

		private readonly int int_2;

		private bool bool_7;

		internal Class306(string string_5, string string_6, string string_7, int int_3)
		{
			string_2 = string_5;
			string_3 = string_6;
			string_4 = string_7;
			int_2 = int_3;
			string_1 = string_5;
			string_0 = string_7;
		}

		internal Class71.Class72 method_0(string string_5, string string_6, string string_7, int int_3)
		{
			list_0.Add(string_7);
			if (string_6 != string_3)
			{
				return Class71.Class72.smethod_1("wrong selected serial");
			}
			if (string_7 == "get-state")
			{
				return Class71.Class72.smethod_0("device");
			}
			if (string_7.StartsWith("shell cmd package list packages -U ", StringComparison.Ordinal))
			{
				return Class71.Class72.smethod_0("package:" + string_1 + " uid:10066");
			}
			if (string_7.StartsWith("shell dumpsys package ", StringComparison.Ordinal))
			{
				return Class71.Class72.smethod_0("Package [" + string_1 + "]\n  userId=10066\n  dataDir=/data/user/0/" + string_1);
			}
			if (string_7.Contains("su 0 id -u"))
			{
				return Class71.Class72.smethod_0("0");
			}
			if (string_7.Contains("CAPY_PROBE="))
			{
				if (!bool_4 && !bool_5)
				{
					if (!bool_0)
					{
						return Class71.Class72.smethod_0("CAPY_PROBE=MISSING");
					}
					int_1++;
					return Class71.Class72.smethod_0("CAPY_PROBE=" + ((string_0 == string_4) ? "CURRENT" : "IMMUTABLE"));
				}
				return Class71.Class72.smethod_0("CAPY_PROBE=NAMESPACE");
			}
			if (string_7.StartsWith("push ", StringComparison.Ordinal))
			{
				int_0++;
				if (!bool_1)
				{
					return Class71.Class72.smethod_0("pushed");
				}
				return Class71.Class72.smethod_1("no space left on device");
			}
			if (string_7.Contains("CAPY_DEPLOY="))
			{
				if (bool_2)
				{
					return Class71.Class72.smethod_1("permission denied");
				}
				if (bool_6)
				{
					return Class71.Class72.smethod_0("CAPY_DEPLOY=NAMESPACE");
				}
				if (bool_3)
				{
					return Class71.Class72.smethod_0("CAPY_DEPLOY=PERMISSIONS");
				}
				bool_7 = true;
				bool_0 = true;
				string_0 = string_4;
				int_1++;
				return Class71.Class72.smethod_0("CAPY_DEPLOY=CREATED");
			}
			if (string_7.Contains("mkdir -p") && string_7.Contains("capybara-license"))
			{
				if (!bool_2)
				{
					return Class71.Class72.smethod_0(string.Empty);
				}
				return Class71.Class72.smethod_1("permission denied");
			}
			if (string_7.Contains("cp ") && string_7.Contains(".stage."))
			{
				bool_7 = true;
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_7.Contains("mv -n") && string_7.Contains(".stage."))
			{
				if (!bool_7)
				{
					return Class71.Class72.smethod_1("stage missing");
				}
				bool_0 = true;
				string_0 = string_4;
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_7.Contains("test -e") && string_7.Contains(".stage."))
			{
				return Class71.Class72.smethod_0("MISSING");
			}
			if (!string_7.Contains("chmod ") && !string_7.Contains("chown ") && !string_7.Contains("restorecon") && !string_7.Contains("rm -f"))
			{
				return Class71.Class72.smethod_1("unexpected command");
			}
			return Class71.Class72.smethod_0(string.Empty);
		}
	}

	private sealed class Class307
	{
		public GForm0 gform0_0;

		internal bool method_0()
		{
			return gform0_0.IsDisposed;
		}
	}

	private sealed class Class308
	{
		public List<string> list_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
		}
	}

	private sealed class Class309
	{
		public List<string> list_0;

		public long long_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
		}

		internal long method_1()
		{
			return long_0;
		}

		internal Task method_2(int int_0)
		{
			long_0 += int_0;
			return Task.CompletedTask;
		}
	}

	private sealed class Class310
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Struct91 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<int> asyncTaskMethodBuilder_0;

			public Class310 class310_0;

			private TaskAwaiter<int> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class310 @class = class310_0;
				int result;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						awaiter = @class.class244_0.gform0_0.smethod_0(@class.method_2).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<int>);
						num = -1;
						int_0 = -1;
					}
					result = awaiter.GetResult();
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

		[StructLayout(LayoutKind.Auto)]
		private struct Struct92 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder<int> asyncTaskMethodBuilder_0;

			public Class310 class310_0;

			private TaskAwaiter<int> taskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class310 @class = class310_0;
				int result;
				try
				{
					TaskAwaiter<int> awaiter;
					if (num != 0)
					{
						awaiter = @class.gform0_0.smethod_0(@class.method_4).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<int>);
						num = -1;
						int_0 = -1;
					}
					result = awaiter.GetResult();
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

		public int int_0;

		public int int_1;

		public GForm0 gform0_0;

		public int int_2;

		public GForm0 gform0_1;

		public Class244 class244_0;

		public Func<int> func_0;

		public Func<int> func_1;

		internal int method_0()
		{
			int_0++;
			return Thread.CurrentThread.ManagedThreadId;
		}

		internal async Task<int> method_1()
		{
			return await class244_0.gform0_0.smethod_0(method_2);
		}

		internal int method_2()
		{
			int_1++;
			return Thread.CurrentThread.ManagedThreadId;
		}

		internal async Task<int> method_3()
		{
			return await gform0_0.smethod_0(method_4);
		}

		internal int method_4()
		{
			int_2++;
			return Thread.CurrentThread.ManagedThreadId;
		}

		internal Task<int> method_5()
		{
			return gform0_1.smethod_0(Class299.class299_0.method_58);
		}
	}

	private sealed class Class311
	{
		public Class145 class145_0;

		public Class253 class253_0;

		internal void method_0()
		{
			class253_0.class222_0.method_0(class145_0, bool_0: true);
		}
	}

	private sealed class Class312
	{
		public MethodInfo methodInfo_0;

		public object[] object_0;

		public MethodInfo methodInfo_1;

		public Class254 class254_0;

		internal Task method_0()
		{
			return (Task)methodInfo_0.Invoke(class254_0.gform0_0, object_0);
		}

		internal Task method_1()
		{
			return (Task)methodInfo_1.Invoke(class254_0.gform0_0, new object[1] { Class8.smethod_0(0L) });
		}

		internal Task method_2()
		{
			return (Task)methodInfo_0.Invoke(class254_0.gform0_0, object_0);
		}
	}

	private sealed class Class313
	{
		public Class222 class222_0;

		public Class239 class239_0;

		internal void method_0()
		{
			class222_0.method_0(smethod_113(new List<Class403> { class239_0.class403_0 }, class239_0.dictionary_0, class239_0.class83_0, 401), bool_0: true);
		}
	}

	private sealed class Class314
	{
		public int int_0;

		public Class240 class240_0;

		internal void method_0(string string_0)
		{
			if (string_0.IndexOf("\"cmd\":\"census_raw\"", StringComparison.Ordinal) >= 0)
			{
				int_0++;
				class240_0.class339_0.method_1(bool_0: false);
				class240_0.class339_0.method_0(new List<Class403>(), null);
			}
		}
	}

	private sealed class Class315
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		internal void method_0()
		{
			Interlocked.Increment(ref int_0);
		}

		internal void method_1()
		{
			Interlocked.Increment(ref int_1);
		}

		internal void method_2()
		{
			Interlocked.Increment(ref int_2);
		}

		internal Task<bool> method_3()
		{
			Interlocked.Increment(ref int_3);
			return Task.FromResult(result: true);
		}

		internal Task<bool> method_4()
		{
			Interlocked.Increment(ref int_4);
			return Task.FromResult(result: true);
		}

		internal void method_5()
		{
			Interlocked.Increment(ref int_5);
		}
	}

	private sealed class Class316
	{
		public TaskCompletionSource<bool> taskCompletionSource_0;

		internal Task method_0(int int_0)
		{
			return taskCompletionSource_0.Task;
		}
	}

	private sealed class Class317
	{
		public (string, string) valueTuple_0;

		internal bool method_0((string, string) valueTuple_1)
		{
			return valueTuple_1.Item1 == valueTuple_0.Item1;
		}
	}

	private sealed class Class318 : SynchronizationContext
	{
		private sealed class Class319
		{
			public SendOrPostCallback sendOrPostCallback_0;

			public object object_0;

			internal void method_0()
			{
				sendOrPostCallback_0(object_0);
			}
		}

		private readonly Queue<Action> queue_0 = new Queue<Action>();

		public override void Post(SendOrPostCallback d, object state)
		{
			Class319 @class = new Class319();
			@class.sendOrPostCallback_0 = d;
			@class.object_0 = state;
			queue_0.Enqueue(@class.method_0);
		}

		internal void method_0()
		{
			while (queue_0.Count != 0)
			{
				queue_0.Dequeue()();
			}
		}
	}

	private sealed class Class320
	{
		public Class119 class119_0;

		internal void method_0()
		{
			for (uint num = 1u; num <= 500; num++)
			{
				class119_0.method_145(num, 3, num, (num & 1) == 0, num + ":3:" + ((num & 1) == 0));
			}
		}

		internal void method_1()
		{
			for (uint num = 501u; num <= 1000; num++)
			{
				class119_0.method_145(num, 4, num, (num & 1) == 0, num + ":4:" + ((num & 1) == 0));
			}
		}
	}

	private sealed class Class321
	{
		public List<string> list_0;

		public Class259 class259_0;

		internal void method_0(string string_0)
		{
			list_0.Add(string_0);
			if (string_0.IndexOf("\"cmd\":\"census_raw\"", StringComparison.Ordinal) >= 0)
			{
				class259_0.class339_0.method_0(new List<Class403>
				{
					new Class403
					{
						byte_0 = 100,
						byte_1 = 4,
						uint_0 = 77u
					}
				}, "Hero77");
			}
		}
	}

	private sealed class Class322
	{
		public Class222 class222_0;

		public int int_0;

		public long long_0;

		internal void method_0(string string_0)
		{
			int_0++;
		}

		internal long method_1()
		{
			return long_0;
		}

		internal Task method_2(int int_1)
		{
			long_0 += int_1;
			class222_0.gform0_0.bool_3 = true;
			return Task.CompletedTask;
		}
	}

	private sealed class Class323
	{
		private long long_0;

		internal Class323(DateTime dateTime_0)
		{
			long_0 = dateTime_0.Ticks;
		}

		internal DateTime method_0()
		{
			return new DateTime(Interlocked.Read(ref long_0), DateTimeKind.Utc);
		}

		internal void method_1(DateTime dateTime_0)
		{
			Interlocked.Exchange(ref long_0, dateTime_0.Ticks);
		}
	}

	private sealed class Class324
	{
		public Class222 class222_0;

		internal void method_0(string string_0)
		{
			class222_0.method_0(class222_0.gform0_0.method_5().method_104("refused"), bool_0: true);
		}
	}

	private sealed class Class325
	{
		public Class222 class222_0;

		public Class263 class263_0;

		internal Task<bool> method_0()
		{
			return (Task<bool>)class263_0.methodInfo_0.Invoke(null, new object[2]
			{
				class222_0.gform0_0,
				class263_0.class403_0.uint_0
			});
		}
	}

	private sealed class Class326
	{
		public long long_0;

		internal long method_0()
		{
			return long_0;
		}
	}

	private sealed class Class327 : Interface2
	{
		private readonly Queue<IntPtr> queue_0;

		internal readonly List<IntPtr> list_0 = new List<IntPtr>();

		internal readonly ManualResetEventSlim manualResetEventSlim_0 = new ManualResetEventSlim(initialState: false);

		internal readonly ManualResetEventSlim manualResetEventSlim_1 = new ManualResetEventSlim(initialState: false);

		internal readonly ManualResetEventSlim manualResetEventSlim_2 = new ManualResetEventSlim(initialState: false);

		internal int int_0 = 1;

		internal bool bool_0;

		internal int int_1;

		internal int int_2;

		internal bool bool_1;

		internal Thread thread_0;

		private Class63.Delegate15 delegate15_0;

		private Class63.Delegate16 delegate16_0;

		private IntPtr intptr_0;

		internal Class327(params IntPtr[] intptr_1)
		{
			queue_0 = new Queue<IntPtr>(intptr_1);
		}

		public IntPtr imethod_0()
		{
			int_1++;
			if (queue_0.Count != 0)
			{
				return queue_0.Dequeue();
			}
			return IntPtr.Zero;
		}

		public int imethod_1(IntPtr intptr_1, string string_0, string string_1, int int_3)
		{
			return 1;
		}

		public int imethod_2(IntPtr intptr_1, uint uint_0, int int_3)
		{
			return int_0;
		}

		public int imethod_3(IntPtr intptr_1, string string_0, int int_3)
		{
			return 1;
		}

		public void imethod_4(IntPtr intptr_1, Class63.Delegate15 delegate15_1, Class63.Delegate16 delegate16_1, IntPtr intptr_2)
		{
			delegate15_0 = delegate15_1;
			delegate16_0 = delegate16_1;
			intptr_0 = intptr_2;
		}

		public void imethod_5(IntPtr intptr_1, string string_0, byte[] byte_0, int int_3)
		{
			int_2++;
		}

		public string imethod_6(IntPtr intptr_1)
		{
			return "Connection closed";
		}

		public void imethod_7(IntPtr intptr_1)
		{
			list_0.Add(intptr_1);
			manualResetEventSlim_2.Set();
			if (thread_0 != null)
			{
				bool_1 = !thread_0.Join(1000);
			}
			if (bool_0)
			{
				manualResetEventSlim_0.Set();
				manualResetEventSlim_1.Wait(5000);
			}
		}

		internal void method_0(int int_3)
		{
			if (delegate16_0 != null)
			{
				delegate16_0(int_3, intptr_0);
			}
		}

		internal void method_1(string string_0)
		{
			if (delegate15_0 == null)
			{
				return;
			}
			IntPtr hglobal = Marshal.StringToHGlobalAnsi(string_0);
			try
			{
				delegate15_0(hglobal, IntPtr.Zero, 0, intptr_0);
			}
			finally
			{
				Marshal.FreeHGlobal(hglobal);
			}
		}
	}

	private sealed class Class328
	{
		public int int_0;

		internal void method_0()
		{
			Interlocked.Increment(ref int_0);
		}
	}

	private sealed class Class329
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public string string_0;

		public int int_4;

		public Class438 class438_0;

		public int int_5;

		public TaskCompletionSource<Class438> taskCompletionSource_0;

		public string string_1;

		public TaskCompletionSource<string> taskCompletionSource_1;

		internal bool method_0(Class438 class438_1)
		{
			int_0++;
			return true;
		}

		internal bool method_1(Class438 class438_1, string string_2)
		{
			int_1++;
			return true;
		}

		internal bool method_2(Class438 class438_1)
		{
			int_0++;
			return false;
		}

		internal bool method_3(Class438 class438_1, string string_2)
		{
			int_1++;
			return true;
		}

		internal Task<Class438> method_4(string string_2, CancellationToken cancellationToken_0)
		{
			return Task.FromResult((int_2++ == 0) ? smethod_288(bool_0: true, "catalog-b") : smethod_288(bool_0: true, "catalog-c"));
		}

		internal bool method_5(Class438 class438_1)
		{
			int_3++;
			return false;
		}

		internal bool method_6(Class438 class438_1, string string_2)
		{
			string_0 = string_2;
			return true;
		}

		internal Task<string> method_7(CancellationToken cancellationToken_0)
		{
			int_4++;
			return Task.FromResult("token");
		}

		internal Task<Class438> method_8(string string_2, CancellationToken cancellationToken_0)
		{
			return Task.FromResult(class438_0);
		}

		internal Task<Class438> method_9(string string_2, CancellationToken cancellationToken_0)
		{
			int_5++;
			return taskCompletionSource_0.Task;
		}

		internal bool method_10(Class438 class438_1)
		{
			int_0++;
			return true;
		}

		internal bool method_11(Class438 class438_1, string string_2)
		{
			int_1++;
			return true;
		}

		internal void method_12(string string_2)
		{
			string_1 = string_2;
		}

		internal Task<string> method_13(CancellationToken cancellationToken_0)
		{
			return taskCompletionSource_1.Task;
		}

		internal Task<Class438> method_14(string string_2, CancellationToken cancellationToken_0)
		{
			return Task.FromResult(class438_0);
		}
	}

	private sealed class Class330
	{
		public Class222 class222_0;

		internal void method_0()
		{
			smethod_94(class222_0.gform0_0, "_session", null);
		}
	}

	private sealed class Class331
	{
		private readonly int int_0;

		private readonly List<string> list_0 = new List<string>();

		internal Class331(int int_1)
		{
			int_0 = int_1;
		}

		internal void method_0(string string_0)
		{
			lock (list_0)
			{
				if (list_0.Count < int_0)
				{
					list_0.Add(string_0);
				}
			}
		}

		internal int method_1(string string_0)
		{
			lock (list_0)
			{
				int num = 0;
				for (int i = 0; i < list_0.Count; i++)
				{
					if (list_0[i] == string_0)
					{
						num++;
					}
				}
				return num;
			}
		}

		internal void method_2()
		{
			lock (list_0)
			{
				list_0.Clear();
			}
		}
	}

	private sealed class Class332
	{
		public List<int> list_0;

		public string string_0;

		internal void method_0(object sender, DataGridViewRowsAddedEventArgs e)
		{
			list_0.Add(smethod_146(string_0));
		}

		internal void method_1(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			list_0.Add(smethod_146(string_0));
		}
	}

	private sealed class Class333
	{
		public Class119 class119_0;

		internal string method_0()
		{
			return class119_0.method_78(27043);
		}
	}

	private sealed class Class334
	{
		public Class222 class222_0;

		public bool bool_0;

		public Class273 class273_0;

		internal void method_0(string string_0)
		{
			class273_0.list_3.Add(string_0);
			JObject jObject = JObject.Parse(string_0);
			if (!bool_0 && !((string?)jObject["cmd"] != "pick"))
			{
				bool_0 = true;
				class273_0.long_0 = 1000L;
				class222_0.method_0(smethod_113(new List<Class403> { class273_0.class403_0 }, class273_0.dictionary_0, class273_0.class83_0, 321), bool_0: true);
				class273_0.class119_1.method_145((uint)jObject["id"], (byte)jObject["type"], (uint)jObject["req"], bool_17: true, null);
			}
		}
	}

	private sealed class Class335
	{
		public Class339 class339_0;

		public Class300 class300_0;

		internal Task method_0()
		{
			return (Task)class300_0.methodInfo_0.Invoke(class339_0.gform0_0, new object[2] { class339_0.class119_0, class339_0.long_0 });
		}
	}

	private sealed class Class336
	{
		public Class1 class1_0;

		public Class1 class1_1;

		public Class1 class1_2;

		internal bool method_0(Class1 class1_3)
		{
			return class1_3.String_0 == class1_0.String_0;
		}

		internal bool method_1(Class1 class1_3)
		{
			return class1_3.String_0 == class1_1.String_0;
		}

		internal bool method_2(Class1 class1_3)
		{
			return class1_3.String_0 == class1_2.String_0;
		}
	}

	private sealed class Class337
	{
		public string string_0;

		public byte[] byte_0;

		public byte[] byte_1;

		public Class306 class306_0;

		public Class306 class306_1;

		public Class306 class306_2;

		public Class306 class306_3;

		public Class306 class306_4;

		public Class306 class306_5;

		public Class306 class306_6;

		public Class306 class306_7;

		public Class306 class306_8;

		internal void method_0()
		{
			Class442.smethod_1(null, string_0, "com.indraftInno.ranorigin", "adb", "emulator-5554", smethod_7);
		}

		internal void method_1()
		{
			Class442.smethod_1(byte_0, string_0, "com.indraftInno.ranorigin", "adb", "emulator-5554", smethod_7);
		}

		internal void method_2()
		{
			Class442.smethod_1(byte_1, string_0, "com.indraftInno.ranorigin", "adb", "emulator-5554", class306_0.method_0);
		}

		internal void method_3()
		{
			Class442.smethod_1(byte_1, string_0, "com.indraftInno.ranorigin", "adb", "emulator-5554", class306_1.method_0);
		}

		internal void method_4()
		{
			Class442.smethod_1(byte_1, string_0, "com.indraftInno.ranorigin", "adb", "emulator-5554", class306_2.method_0);
		}

		internal void method_5()
		{
			Class442.smethod_1(byte_1, string_0, "com.indraftInno.ranorigin", "adb", "emulator-5554", class306_3.method_0);
		}

		internal void method_6()
		{
			Class442.smethod_1(byte_1, string_0, "com.indraftInno.ranorigin", "adb", "emulator-5554", class306_4.method_0);
		}

		internal void method_7()
		{
			Class442.smethod_1(byte_1, string_0, "com.indraftInno.ranorigin", "adb", "emulator-5554 shell", class306_5.method_0);
		}

		internal void method_8()
		{
			Class442.smethod_1(byte_1, string_0, "com.indraftInno.ranorigin", "adb", "emulator-5554", class306_6.method_0);
		}

		internal void method_9()
		{
			Class442.smethod_1(byte_1, string_0, "com.indraftInno.ranorigin", "adb", "emulator-5554", class306_7.method_0);
		}

		internal void method_10()
		{
			Class442.smethod_1(byte_1, string_0, "com.indraftInno.ranorigin", "adb", "emulator-5554", class306_8.method_0);
		}
	}

	private sealed class Class338
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Struct93 : IAsyncStateMachine
		{
			public int int_0;

			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			public Class338 class338_0;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter_0;

			private void MoveNext()
			{
				int num = int_0;
				Class338 @class = class338_0;
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(120).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
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
					@class.class246_0.method_2(1400);
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

		public Class246 class246_0;

		internal async Task method_0()
		{
			await Task.Delay(120).ConfigureAwait(continueOnCapturedContext: false);
			class246_0.method_2(1400);
		}
	}

	private sealed class Class339 : IDisposable
	{
		private static readonly MethodInfo methodInfo_0 = typeof(GForm0).GetMethod("method_8", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

		private static readonly MethodInfo methodInfo_1 = typeof(GForm0).GetMethod("method_9", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

		private static readonly FieldInfo fieldInfo_0 = typeof(Class119).GetField("_agent", BindingFlags.Instance | BindingFlags.NonPublic);

		private static readonly FieldInfo fieldInfo_1 = typeof(Class119).GetField("_readyRequest", BindingFlags.Instance | BindingFlags.NonPublic);

		private static readonly FieldInfo fieldInfo_2 = typeof(Class119).GetField("_lastRows", BindingFlags.Instance | BindingFlags.NonPublic);

		private static readonly FieldInfo fieldInfo_3 = typeof(Class119).GetField("_census", BindingFlags.Instance | BindingFlags.NonPublic);

		internal readonly GForm0 gform0_0;

		internal readonly Class119 class119_0;

		internal readonly long long_0;

		internal Class339()
		{
			if (!(methodInfo_0 == null) && !(methodInfo_1 == null) && !(fieldInfo_0 == null) && !(fieldInfo_1 == null) && !(fieldInfo_2 == null) && !(fieldInfo_3 == null))
			{
				gform0_0 = new GForm0();
				class119_0 = new Class119();
				fieldInfo_0.SetValue(class119_0, new IntPtr(1));
				fieldInfo_1.SetValue(class119_0, 1);
				methodInfo_0.Invoke(gform0_0, new object[1] { class119_0 });
				object[] array = new object[2] { null, 0L };
				if (!(bool)methodInfo_1.Invoke(gform0_0, array))
				{
					throw new InvalidOperationException("Could not capture Select hero session");
				}
				long_0 = (long)array[1];
				return;
			}
			throw new InvalidOperationException("Select hero reflection contract missing");
		}

		internal void method_0(List<Class403> list_0, string string_0)
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				class119_0.dictionary_2["77"] = string_0;
			}
			fieldInfo_2.SetValue(class119_0, list_0);
			((ManualResetEventSlim)fieldInfo_3.GetValue(class119_0)).Set();
		}

		internal void method_1(bool bool_0)
		{
			method_2(class119_0, bool_0);
		}

		internal void method_2(Class119 class119_1, bool bool_0)
		{
			fieldInfo_1.SetValue(class119_1, bool_0 ? 1 : 0);
		}

		internal void method_3(Class119 class119_1)
		{
			methodInfo_0.Invoke(gform0_0, new object[1] { class119_1 });
		}

		public void Dispose()
		{
			class119_0.method_30(null);
			fieldInfo_0.SetValue(class119_0, IntPtr.Zero);
			class119_0.Dispose();
			gform0_0.Dispose();
		}
	}

	private static readonly Class282[] class282_0 = new Class282[222]
	{
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\AutomateScript.cs", "AutomateScript", "public static async Task Master_Manager(Form1 form)", "AutomateScript.Master_Manager(Form1)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private async Task Prepare_Start(bool fromUI)", "Form1.Prepare_Start(bool)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private Task Start_Button(bool fromUI)", "Form1.Start_Button(bool)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private Task Stop_Button(bool need_start_again = false)", "Form1.Stop_Button(bool)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private Task RequestStop(StopRequest request)", "Form1.RequestStop(StopRequest)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private async Task StopCoreAsync()", "Form1.StopCoreAsync()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private async Task ObserveAutomaticRunAsync(AutomaticRunContext run, Task worker)", "Form1.ObserveAutomaticRunAsync(AutomaticRunContext,Task)"),
		new Class282("Capybara-UI-Winform\\Form1.cs", "Form1", "private async void button1_Click(object sender, EventArgs e)", "Form1.button1_Click(object,EventArgs)"),
		new Class282("Capybara-UI-Winform\\Form1.cs", "Form1", "private async void button2_Click(object sender, EventArgs e)", "Form1.button2_Click(object,EventArgs)"),
		new Class282("Capybara-UI-Winform\\Form1.cs", "Form1", "private async void Form1_FormClosing(object sender, FormClosingEventArgs e)", "Form1.Form1_FormClosing(object,FormClosingEventArgs)"),
		new Class282("Capybara-UI-Winform\\Form1.cs", "Form1", "private async void Session_Detached(int reason)", "Form1.Session_Detached(int)"),
		new Class282("Capybara-UI-Winform\\Form1.cs", "Form1", "private void BeginSessionClose()", "Form1.BeginSessionClose()"),
		new Class282("Capybara-UI-Winform\\Form1.cs", "Form1", "private bool TryCaptureSessionGeneration(out KlxSession session, out long generation)", "Form1.TryCaptureSessionGeneration(KlxSession&,long&)"),
		new Class282("Capybara-UI-Winform\\Ui\\SellRun.cs", "Form1", "private void Sell_Run_Click(object sender, EventArgs e)", "Form1.Sell_Run_Click(object,EventArgs)"),
		new Class282("Capybara-UI-Winform\\Ui\\SellRun.cs", "Form1", "private void SellPump_Tick(object sender, EventArgs e)", "Form1.SellPump_Tick(object,EventArgs)"),
		new Class282("Capybara-UI-Winform\\Ui\\SellRun.cs", "Form1", "private async Task RunManualSellPassAsync()", "Form1.RunManualSellPassAsync()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Card_Travel.cs", "Card_Travel", "internal static Task<CardTravelResult> BackToStartAsync(Form1 form, int delayBeforePressSeconds = 0, int pollIntervalMilliseconds = 200, double timeoutSeconds = 10.0)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Card_Travel.cs", "Card_Travel", "internal static Task<CardTravelResult> BackToRecentAsync(Form1 form, int delayBeforePressSeconds = 0, int pollIntervalMilliseconds = 200, double timeoutSeconds = 10.0)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Card_Travel.cs", "Card_Travel", "internal static Task<CardTravelResult> WarpToFriendAsync(Form1 form, string friendName, int delayBeforePressSeconds = 0, int pollIntervalMilliseconds = 200, double timeoutSeconds = 10.0)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Card_Travel.cs", "Card_Travel", "static async Task<CardTravelResult> TravelAsync(Form1 form, string cardName, string friendName, bool friendWarp, bool available, int delayBeforePressSeconds, int pollIntervalMilliseconds, double timeoutSeconds, CardTravelRuntime runtime)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Card_Travel.cs", "Card_Travel", "private static bool BagIsFresh(WorldState snapshot)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Card_Travel.cs", "Card_Travel", "private static bool TryFindCard(WorldState snapshot, string cardName, out BagRow card, out bool unknownName)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Card_Travel.cs", "Card_Travel", "private static bool CardNameMatches(string raw, string cardName)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Card_Travel.cs", "Card_Travel", "static long ValidateSeconds(double seconds, string parameterName, long frequency)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Card_Travel.cs", "Card_Travel", "static long RemainingTicks(long started, long duration, long now)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Card_Travel.cs", "Card_Travel", "static int WaitSliceMilliseconds(long remainingTicks, long frequency, int pollIntervalMilliseconds)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static bool TryReadLiveTravelSample(this Form1 form, bool friendWarp, out float x, out float z, out string error)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "public static async Task<bool> Can_We_run_BeCuz_NeedBuff(Form1 form)", "Buff.Can_We_run_BeCuz_NeedBuff(Form1)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "internal static async Task<bool> Mode(Form1 form, float radius)", "Manage_Pick_Item.Mode(Form1,float)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static bool TrySelectLiveTarget(Form1 form, ZoneState zone, float radius, int subMode, bool noMoney, bool noBox, bool killFirst, int boxLocks, IReadOnlyList<string> wantedNames, out PickIdentity target)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static bool AnyLiveMonsterInZone(Form1 form, float cx, float cy, float cz, float radius)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static void LogDecision(Form1 form, PickIdentity target, float distance, string action)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Attack_Monster.cs", "Manage_Attack_Monster", "public static async Task<bool> Mode(Form1 form, float radius)", "Manage_Attack_Monster.Mode(Form1,float)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Attack_Monster.cs", "Manage_Attack_Monster", "public static async Task<bool> Engage(Form1 form, uint targetId)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Attack_Monster.cs", "Manage_Attack_Monster", "public static Task ShowZoneAsync(Form1 form)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Attack_Monster.cs", "Manage_Attack_Monster", "private static EntityRow FindLiveMonster(Form1 form, uint targetId)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Attack_Monster.cs", "Manage_Attack_Monster", "public static void Reset()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Mode_Attack.cs", "Mode_Attack", "public static async Task<bool> Mode_PinPoint(Form1 form, float radius, IReadOnlyList<uint> monsterIds)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Mode_Attack.cs", "Mode_Attack", "public static async Task<bool> Mode_FollowPos(Form1 form, float radius, float cx, float cy, float cz)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Mode_Attack.cs", "Mode_Attack", "public static async Task<bool> Mode_Follow_Circle(Form1 form, float radius, IReadOnlyList<uint> monsterIds)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Mode_Attack.cs", "Mode_Attack", "public static async Task<bool> Mode_Random(Form1 form, IReadOnlyList<uint> monsterIds)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Mode_Attack.cs", "Mode_Attack", "public static Task<bool> Mode_Heal(Form1 form, float radius)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Mode_Attack.cs", "Mode_Attack", "public static async Task<bool> CheckHP_Target(Form1 form, uint targetId)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Mode_Attack.cs", "Mode_Attack", "private static EntityRow FindLiveMonster(Form1 form, uint targetId)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Mode_Attack.cs", "Mode_Attack", "private static bool LiveMonsterInZone(Form1 form, uint targetId, float cx, float cy, float cz, float radius)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Attack.cs", "Skill_Attack", "public static async Task<bool> TryCast(Form1 form, uint targetId)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Entity_Manager.cs", "Entity_Manager", "public static async Task<List<uint>> SortMonsterIdsAsync(Form1 form)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Entity_Manager.cs", "Entity_Manager", "private static List<uint> CurrentMonsterIds(Form1 form)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Entity_Manager.cs", "Entity_Manager", "private static EntityRow FindMonster(IReadOnlyList<EntityRow> rows, uint targetId)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Follow_Pos.cs", "Manage_Follow_Pos", "public static async Task<bool> Mode(Form1 form, float radius)", "Manage_Follow_Pos.Mode(Form1,float)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Follow_Pos.cs", "Manage_Follow_Pos", "internal static string Countdown(string prefix, int capSec, DateTime since)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Follow_Pos.cs", "Manage_Follow_Pos", "static bool WaitedDelay(int delaySec)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Follow_Pos.cs", "Manage_Follow_Pos", "static void Advance(int count, bool random)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Follow_Pos.cs", "Manage_Follow_Pos", "internal static void PublishTarget(int target)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Follow_Pos.cs", "Manage_Follow_Pos", "public static void Reset()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Looper.cs", "Manage_Looper", "public static async Task<bool> Mode(Form1 form, float radius)", "Manage_Looper.Mode(Form1,float)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Looper.cs", "Manage_Looper", "static void StepRow(Form1 form, int count)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Looper.cs", "Manage_Looper", "static void EnterFight(Form1 form)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Looper.cs", "Manage_Looper", "static void BeginSegment(int segment)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Looper.cs", "Manage_Looper", "static void AdvanceSeg(IReadOnlyList<int> segs, bool random)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Looper.cs", "Manage_Looper", "internal static void PublishPosition(int segment, int rowIndex, bool atEndpoint)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Looper.cs", "Manage_Looper", "static bool Waiting(ref DateTime since, int sec)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Looper.cs", "Manage_Looper", "static Task<IReadOnlyList<int>> LooperSegmentsAsync(Form1 form)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Looper.cs", "Manage_Looper", "public static void Reset()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static Task<T> ReadUiAsync<T>(this Form1 form, Func<T> query)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static Task WriteUiAsync(this Form1 form, Action update)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static Task<bool> GetCheckboxValueAsync(this Form1 form, int index)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static Task<string> GetTextboxValueAsync(this Form1 form, int index)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static Task<string> GetComboTextAsync(this Form1 form, string name)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static Task<int> GetTrackBarValueAsync(this Form1 form, int index)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "Async_Method", "internal static async Task<List<int>> GetCheckedCheckBoxesByCount(Form1 form, int start, int last)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static Task<IReadOnlyList<string>> ReadSellNamesAsync(this Form1 form)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static Task<IReadOnlyList<string>> ReadPickNamesAsync(this Form1 form)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static Task<IReadOnlyList<Waypoint>> ReadFollowWaypointsAsync(this Form1 form)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static Task<IReadOnlyList<Waypoint>> ReadLooperWaypointsAsync(this Form1 form, int segment)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static async Task<IReadOnlyList<int>> ReadLooperSegmentsAsync(this Form1 form)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static Task HighlightFollowWaypointAsync(this Form1 form, int row)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Cal_RedZone.cs", "Cal_RedZone", "public static float Dist(float fromX, float fromY, float fromZ, float toX, float toY, float toZ)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Cal_RedZone.cs", "Cal_RedZone", "public static bool IsInZone(float x, float y, float z, float cx, float cy, float cz, float radius)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "internal void PublishWorkerCompleted(AutomaticRunContext run)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private static async Task ObserveTaskAsync(Task task, string operation)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private static async Task<Exception> CaptureTaskFaultAsync(Task task)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private bool HasStopRequestFor(long generation)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private void MergePendingStop(StopRequest request)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private StopRequest PendingForGeneration(long generation, StopRequest fallback)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private void RunStopCleanup(string operation, Action cleanup)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private async Task RunStopCleanupAsync(string operation, Func<Task> cleanup)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private Task RestartDelaySliceAsync(int slice)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private async Task CleanupForCloseAsync()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private static void LogAutomaticStop(string operation, Exception ex)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", "Form1", "private static void LogAutomaticFault( AutomaticRunContext run, Task worker, Exception ex)"),
		new Class282("Capybara-UI-Winform\\Ui\\SellRun.cs", "Form1", "internal bool TryAcquireSellDriver(SellDriver driver)"),
		new Class282("Capybara-UI-Winform\\Ui\\SellRun.cs", "Form1", "private bool TryTransferSellDriver(SellDriver from, SellDriver to)"),
		new Class282("Capybara-UI-Winform\\Ui\\SellRun.cs", "Form1", "internal void ReleaseSellDriver(SellDriver driver)"),
		new Class282("Capybara-UI-Winform\\Ui\\SellRun.cs", "Form1", "private void RunOneManualSale()"),
		new Class282("Capybara-UI-Winform\\Ui\\SellRun.cs", "Form1", "private static void SellRunTrace(string action, string detail)"),
		new Class282("Capybara-UI-Winform\\Ui\\SellRun.cs", "Form1", "private void StartSellPump()"),
		new Class282("Capybara-UI-Winform\\Ui\\SellRun.cs", "Form1", "private async Task ObserveManualSellPassAsync(Task pass)"),
		new Class282("Capybara-UI-Winform\\Ui\\SellRun.cs", "Form1", "private void StopSellPump()"),
		new Class282("Capybara-UI-Winform\\Ui\\SellRun.cs", "Form1", "private void FinishManualSellPump()"),
		new Class282("Capybara-UI-Winform\\Form1.cs", "Form1", "private void ApplyRunLook()"),
		new Class282("Capybara-UI-Winform\\Form1.cs", "Form1", "private void PumpCamera()"),
		new Class282("Capybara-UI-Winform\\Ui\\RouteRecord.cs", "Form1", "private void StopRecording()"),
		new Class282("Capybara-UI-Winform\\Ui\\RouteRecord.cs", "Form1", "private void RouteRecordLock()"),
		new Class282("Capybara-UI-Winform\\Ui\\RouteRecord.cs", "Form1", "private Button SegmentButton(int segment)"),
		new Class282("Capybara-UI-Winform\\Ui\\SellNpcPos.cs", "Form1", "internal static bool CanRecordNpcPos(RunPhase phase, bool streaming, bool hasSelf)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "internal static int LockBit(byte bonus)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static void ScanLiveEligible(Form1 form, IReadOnlyList<EntityRow> rows, ZoneState zone, float radius, int subMode, bool noMoney, bool noBox, int boxLocks, IReadOnlyList<string> wantedNames, byte activeBoxBuff, float selfX, float selfY, float selfZ, ref bool found, ref PickIdentity best, ref float bestDistance)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static bool EligibleLive(Form1 form, EntityRow row, int subMode, bool noMoney, bool noBox, int boxLocks, IReadOnlyList<string> wantedNames, byte activeBoxBuff)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static bool TryLiveSelf(Form1 form, out float x, out float y, out float z)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static bool TryLivePickOrigin(Form1 form, out float x, out float y, out float z, out byte activeBoxBuff)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static bool TryLiveTarget(Form1 form, PickIdentity target, out float x, out float y, out float z, out byte crowType, out byte entityKind, out string itemName)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static bool TryResolveLiveEligibleTarget(Form1 form, PickIdentity target, ZoneState zone, float radius, int subMode, bool noMoney, bool noBox, bool killFirst, int boxLocks, IReadOnlyList<string> wantedNames, out float x, out float y, out float z, out byte crowType, out byte entityKind, out string itemName)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static bool IsLiveEligibleTarget(Form1 form, PickIdentity target, ZoneState zone, float radius, int subMode, bool noMoney, bool noBox, bool killFirst, int boxLocks, IReadOnlyList<string> wantedNames)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static async Task<MoveWaitResult> MoveAndWaitAsync(Form1 form, PickIdentity target, float destinationX, float destinationY, float destinationZ, string reason, string logAction, int attempt, ZoneState zone, float radius, int subMode, bool noMoney, bool noBox, bool killFirst, int boxLocks, IReadOnlyList<string> wantedNames, PickRetryRuntime runtime)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static void NextRecoveryDestination(PickRetryRuntime runtime, int attempt, float itemX, float itemZ, float selfX, float selfZ, out float destinationX, out float destinationZ)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static float RandomOffset(PickRetryRuntime runtime)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static float HorizontalDistance(float ax, float az, float bx, float bz)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static bool TryFindLiveTarget(Form1 form, IReadOnlyList<EntityRow> rows, PickIdentity target, out float x, out float y, out float z, out byte crowType, out byte entityKind, out string itemName)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static void SyncTarget(PickIdentity target)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static bool SettlePendingPick(Form1 form, PickIdentity target, KlxSession session, long now, long frequency)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static bool IsCurrentRetrySession(KlxSession session)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static void ResetCurrentTarget()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static void ResetRetryState(bool clearBlacklist)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static double ElapsedMilliseconds(long from, long to, long frequency)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static void AddBlacklist(PickIdentity target, long now, long frequency)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static void PruneBlacklist(long now)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static void LogRetry(PickIdentity target, string action, int attempt, int total)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static void LogMoveResult(PickIdentity target, string action, MoveWaitResult result, int attempt)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "PickIdentity", "internal static PickIdentity From(EntityRow row)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "PickIdentity", "public bool Equals(PickIdentity other)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "PickRetryRuntime", "internal bool IsPickAvailable(KlxSession session)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "PickRetryRuntime", "internal void BeforeCommandResolve()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "PickRetryRuntime", "internal Task DelayAsync(int milliseconds)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "PickRetryRuntime", "internal int NextRandom(int minInclusive, int maxExclusive)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "static bool IsItemInList(IReadOnlyList<string> names, string name)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Pick_Item.cs", "Manage_Pick_Item", "public static void Reset()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Mode_Attack.cs", "Mode_Attack", "private static bool CheckHpScalars(byte kind, uint id, int hp, int max, string name, bool filterEnabled, string focus)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Mode_Attack.cs", "Mode_Attack", "private static bool NameNeeded(string name, string focus)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Mode_Attack.cs", "Mode_Attack", "private static bool ShouldSkip(uint id)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Mode_Attack.cs", "Mode_Attack", "public static void CleanupExpired()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Mode_Attack.cs", "Mode_Attack", "public static void ResetState()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Attack_Monster.cs", "Manage_Attack_Monster", "public static void FixZone(float x, float y, float z)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Attack_Monster.cs", "Manage_Attack_Monster", "public static void NotFixZone()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Attack_Monster.cs", "Manage_Attack_Monster", "public static void ClearTarget()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Follow_Pos.cs", "Manage_Follow_Pos", "internal static int NextRandom(int count)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Follow_Pos.cs", "Manage_Follow_Pos", "public static void ReleaseWaypoint()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Looper.cs", "Manage_Looper", "internal static int NextSeq(IReadOnlyList<int> segs, int cur)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Looper.cs", "Manage_Looper", "internal static int NextRandomSeg(IReadOnlyList<int> segs)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Looper.cs", "Manage_Looper", "static bool SameShuffleSet(IReadOnlyList<int> segs)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Manage_Looper.cs", "Manage_Looper", "static int IndexOf(IReadOnlyList<int> values, int value)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Attack.cs", "Skill_Attack", "public static void Reset()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Entity_Manager.cs", "Entity_Manager", "internal static string LiveMobName(Form1 form, ushort main, ushort sub)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Entity_Manager.cs", "Entity_Manager", "internal static string LiveItemName(Form1 form, ushort main, ushort sub)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static Task<T> ReadGridAsync<T>(this Form1 form, string controlName, Func<DataGridView, T> query)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static Task<int> GetSelectedRadioAsync(this Form1 form, params int[] numbers)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "internal static Task SetLabelValueAsync(this Form1 form, int index, string value)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "public static void SetLabelValue(this Form1 form, int index, string value)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "public static void SetLabelValue(this Form1 form, int index, string value, Color color)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "static T FindControl<T>(Form1 form, string controlName, bool logMissing = true)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "static void Missing(string controlName)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "public static void Reset()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "internal static void PublishOff(bool value)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "internal static void PublishLastIntervalOk(long value)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "internal static long NowMs()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "internal static BuffCastReply TakeReply()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "static void Trace(long nowMs, string key, string text)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "static void TraceNow(string text)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "internal static string TraceLine(string tag, bool run, int cast, string detail)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "static bool End(bool run, int cast, string tag, int slot, string detail, string slots)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "static string SlotText(int buff, (ushort MainId, ushort SubId)[] tab3, IReadOnlyList<SelfBuff> buffs, SkillReadiness ready, string box, long nowMs)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "static string ReadyCode(ushort main, ushort sub, SkillReadiness ready)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "static string ReadyAge(SkillReadiness ready, long nowMs)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "static string Tag(int buff)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "static string Slots()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "static int Rank(string tag)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "static bool Skip((ushort MainId, ushort SubId)[] tab3, IReadOnlyList<SelfBuff> buffs, SkillReadiness ready, string[] boxes, long nowMs)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "internal static bool Step(long nowMs, bool dead, (ushort MainId, ushort SubId)[] tab3, SkillReadiness ready, IReadOnlyList<SelfBuff> buffs, bool[] on, string[] boxes, out int cast, bool commitCast)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "internal static bool IsReady(ushort main, ushort sub, SkillReadiness ready, long nowMs, out string why)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "internal static bool NeedsCast(bool on, (ushort MainId, ushort SubId)[] tab3, int buff, IReadOnlyList<SelfBuff> buffs, string thresholdText, long holdUntilMs, long nowMs, out string why)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "internal static bool IntervalDue(bool on, (ushort MainId, ushort SubId)[] tab3, string intervalText, long lastOkMs, long holdUntilMs, long nowMs, out string why)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "internal static bool FindFact(ushort main, ushort sub, IReadOnlyList<SelfBuff> buffs, out float left)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "internal static int SecondsOf(string text)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "internal static bool HasSeconds(string text)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "static bool StepCasting(long nowMs, (ushort MainId, ushort SubId)[] tab3, IReadOnlyList<SelfBuff> buffs, SkillReadiness ready, string[] boxes)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "static bool StepConfirming(long nowMs, IReadOnlyList<SelfBuff> buffs, string[] boxes, (ushort MainId, ushort SubId)[] tab3, SkillReadiness ready)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "internal static void Send(int buff, ushort main, ushort sub, long nowMs)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "static void HoldBusy(int buff, long nowMs)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Buff.cs", "Buff", "static void HoldFail(int buff, long nowMs)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\AutomaticRunContext.cs", "StopRequest", "internal static StopRequest ForClose(long generation)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\AutomaticRunContext.cs", "StopRequest", "internal static StopRequest ForDetach(long generation, int reason)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\AutomaticRunContext.cs", "StopRequest", "internal static StopRequest ForFault(long generation, Exception exception)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\AutomaticRunContext.cs", "StopRequest", "internal static StopRequest ForNormal(long generation)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\AutomaticRunContext.cs", "StopRequest", "internal static StopRequest ForSelfStop(long generation)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\AutomaticRunContext.cs", "StopRequest", "internal static StopRequest ForRestart(long generation)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\AutomaticRunContext.cs", "StopRequest", "internal StopRequest Merge(StopRequest other)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\AutomaticRunContext.cs", "AutomaticRunContext", "internal void AttachWorker(Task workerTask)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\AutomaticRunContext.cs", "AutomaticRunContext", "internal bool MarkExternalStop()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\AutomaticRunContext.cs", "AutomaticRunContext", "internal bool PublishExit(WorkerExitReason reason)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\AutomaticRunContext.cs", "AutomaticRunContext", "internal Exception PublishOrGetCanonicalFault(Exception fault)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\AutomaticRunContext.cs", "AutomaticRunContext", "internal Exception GetOrCreateUnexpectedExitException()"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\AutomaticRunContext.cs", "AutomaticRunContext", "internal bool TryRecordFault(long generation, Task workerTask, Exception fault)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static int Seconds(bool enabled, string typed)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static string Coord(float v)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static string PosLabel(float x, float z)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static bool TryCoord(string cell, out float v)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static bool TryNpcPos(string text, out float x, out float y, out float z)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static bool Flag(string cell)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static bool Read(string[] cells, out Waypoint wp)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static List<Waypoint> ReadAll(DataGridView grid)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static void SelectRow(DataGridView grid, int rowIndex)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static List<Waypoint> ReadRoute(DataGridView grid)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static int Nearest(List<Waypoint> pts, float x, float z)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static int Next(int i, int count)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static float HorizDist(float ax, float az, float bx, float bz)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static bool Arrived(float d)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Position_Grid.cs", "Position_Grid", "public static float RouteReach(int row, int count)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Buff_Label.cs", "Buff_Label", "internal static int ThresholdBoxOf(int buff)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", "FormAccess", "static IReadOnlyList<Waypoint> ImmutableWaypoints(List<Waypoint> points)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Sell_List.cs", "Sell_List", "internal static bool Same(string a, string b)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Entity_Manager.cs", "Entity_Manager", "private static bool Focused(string name, string focus)"),
		new Class282("Capybara-UI-Winform\\Ui\\Bot\\Skill_Attack.cs", "SkillAttackReadiness", "internal bool IsReady(int slot)")
	};

	private static long long_0;

	private static readonly HashSet<string> hashSet_0 = smethod_198();

	private static readonly OpCode[] opCode_0 = smethod_204(bool_0: false);

	private static readonly OpCode[] opCode_1 = smethod_204(bool_0: true);

	[ThreadStatic]
	private static Class261 class261_0;

	internal static int smethod_0(string string_0)
	{
		int num = 0;
		byte[] byte_;
		string string_1;
		try
		{
			Class57.smethod_0(out byte_, out string_1);
		}
		catch (Exception ex)
		{
			Console.WriteLine("FAIL  agent-license-resource/load  " + ex.Message);
			Console.WriteLine("FAIL agent-license-resource: 1");
			return 1;
		}
		num += smethod_243("agent-license-resource/embedded-bytes", byte_.Length >= 20);
		num += smethod_244("agent-license-resource/elf64", (byte)2, byte_[4]);
		num += smethod_244("agent-license-resource/little-endian", (byte)1, byte_[5]);
		num += smethod_244("agent-license-resource/machine", 183, byte_[18] | (byte_[19] << 8));
		num += smethod_244("agent-license-resource/hash", smethod_2(byte_), string_1);
		if (!string.IsNullOrWhiteSpace(string_0))
		{
			num += smethod_243("agent-license-resource/expected-file-exists", File.Exists(string_0));
			if (File.Exists(string_0))
			{
				byte[] array = File.ReadAllBytes(string_0);
				num += smethod_244("agent-license-resource/expected-file-length", array.Length, byte_.Length);
				num += smethod_244("agent-license-resource/expected-file-hash", smethod_2(array), string_1);
			}
		}
		num += smethod_243("agent-license-resource/malformed-rejected", smethod_1(new byte[4] { 127, 69, 76, 70 }));
		byte[] array2 = (byte[])byte_.Clone();
		array2[18] = 62;
		array2[19] = 0;
		num += smethod_243("agent-license-resource/wrong-architecture-rejected", smethod_1(array2));
		Console.WriteLine((num == 0) ? "PASS agent-license-resource" : ("FAIL agent-license-resource: " + num));
		Console.WriteLine("agent-license-resource sha256: " + string_1);
		return num;
	}

	private static bool smethod_1(byte[] byte_0)
	{
		try
		{
			Class57.smethod_1(byte_0);
			return false;
		}
		catch (InvalidDataException)
		{
			return true;
		}
	}

	private static string smethod_2(byte[] byte_0)
	{
		using SHA256 sHA = SHA256.Create();
		return BitConverter.ToString(sHA.ComputeHash(byte_0)).Replace("-", string.Empty).ToLowerInvariant();
	}

	internal static int smethod_3()
	{
		Class337 @class = new Class337();
		int num = 0;
		@class.byte_1 = smethod_5();
		@class.string_0 = Class57.smethod_1(@class.byte_1);
		num = 0 + smethod_243("agent-license-deploy/missing-rejected-before-adb", smethod_6(@class.method_0, "missing"));
		@class.byte_0 = (byte[])@class.byte_1.Clone();
		@class.byte_0[0] = 0;
		num += smethod_243("agent-license-deploy/corrupt-rejected-before-adb", smethod_6(@class.method_1, "ELF"));
		Class306 class2 = new Class306("com.indraftInno.ranorigin", "emulator-5554", @class.string_0, @class.byte_1.Length)
		{
			bool_0 = true,
			string_0 = @class.string_0
		};
		Class32 class3 = Class442.smethod_1(@class.byte_1, @class.string_0, "com.indraftInno.ranorigin", "adb", "emulator-5554", class2.method_0);
		num += smethod_244("agent-license-deploy/hash-identical-path", "/data/user/0/com.indraftInno.ranorigin/code_cache/capybara-license/" + @class.string_0 + "/libshare.so", class3.string_2);
		num += smethod_244("agent-license-deploy/hash-identical-hash", @class.string_0, class3.string_3);
		num += smethod_244("agent-license-deploy/hash-identical-uid", 10066, class3.int_0);
		num += smethod_243("agent-license-deploy/hash-identical-reports-reused", class3.bool_0);
		num += smethod_244("agent-license-deploy/hash-identical-skips-push", 0, class2.int_0);
		@class.class306_0 = new Class306("com.indraftInno.ranorigin", "emulator-5554", @class.string_0, @class.byte_1.Length)
		{
			bool_4 = true
		};
		num += smethod_243("agent-license-deploy/symlink-base-refused-before-push", smethod_6(@class.method_2, "symlink"));
		num += smethod_244("agent-license-deploy/symlink-base-no-push", 0, @class.class306_0.int_0);
		@class.class306_1 = new Class306("com.indraftInno.ranorigin", "emulator-5554", @class.string_0, @class.byte_1.Length)
		{
			bool_5 = true
		};
		num += smethod_243("agent-license-deploy/symlink-version-refused-before-push", smethod_6(@class.method_3, "symlink"));
		num += smethod_244("agent-license-deploy/symlink-version-no-push", 0, @class.class306_1.int_0);
		@class.class306_2 = new Class306("com.indraftInno.ranorigin", "emulator-5554", @class.string_0, @class.byte_1.Length)
		{
			bool_6 = true
		};
		num += smethod_243("agent-license-deploy/symlink-stage-refused", smethod_6(@class.method_4, "symlink"));
		num += smethod_244("agent-license-deploy/symlink-stage-pushes-once", 1, @class.class306_2.int_0);
		num += smethod_243("agent-license-deploy/symlink-stage-does-not-publish", !@class.class306_2.bool_0);
		Class306 class4 = new Class306("com.indraftInno.ranorigin", "emulator-5554", @class.string_0, @class.byte_1.Length);
		Class32 class5 = Class442.smethod_1(@class.byte_1, @class.string_0, "com.indraftInno.ranorigin", "adb", "emulator-5554", class4.method_0);
		num += smethod_244("agent-license-deploy/missing-installs-once", 1, class4.int_0);
		num += smethod_243("agent-license-deploy/new-install-reports-created", !class5.bool_0);
		num += smethod_243("agent-license-deploy/missing-promotes-verified-file", class4.bool_0 && class4.string_0 == @class.string_0 && class4.int_1 > 0 && class5.string_2.EndsWith("/" + @class.string_0 + "/libshare.so", StringComparison.Ordinal));
		num += smethod_243("agent-license-deploy/staging-is-unique", class4.list_0.Exists(Class299.class299_0.method_0));
		num += smethod_243("agent-license-deploy/new-inodes-are-fd-chowned-root", class4.list_0.Exists(Class299.class299_0.method_1));
		num += smethod_243("agent-license-deploy/root-command-fits-adb-shell-limit", class4.list_0.Exists(Class299.class299_0.method_2));
		@class.class306_3 = new Class306("com.indraftInno.ranorigin", "emulator-5554", @class.string_0, @class.byte_1.Length)
		{
			bool_0 = true,
			string_0 = new string('0', 64)
		};
		num += smethod_243("agent-license-deploy/corrupt-immutable-target-refused", smethod_6(@class.method_5, "immutable"));
		num += smethod_244("agent-license-deploy/corrupt-target-not-overwritten", 0, @class.class306_3.int_0);
		@class.class306_4 = new Class306("com.indraftInno.ranorigin", "emulator-5554", @class.string_0, @class.byte_1.Length)
		{
			string_1 = "com.example.other"
		};
		num += smethod_243("agent-license-deploy/wrong-package-refused-before-mutation", smethod_6(@class.method_6, "package"));
		num += smethod_244("agent-license-deploy/wrong-package-no-push", 0, @class.class306_4.int_0);
		@class.class306_5 = new Class306("com.indraftInno.ranorigin", "emulator-5554", @class.string_0, @class.byte_1.Length);
		num += smethod_243("agent-license-deploy/unsafe-serial-refused-before-adb", smethod_6(@class.method_7, "serial"));
		num += smethod_244("agent-license-deploy/unsafe-serial-no-command", 0, @class.class306_5.list_0.Count);
		@class.class306_6 = new Class306("com.indraftInno.ranorigin", "emulator-5554", @class.string_0, @class.byte_1.Length)
		{
			bool_1 = true
		};
		num += smethod_243("agent-license-deploy/push-failure-is-clear", smethod_6(@class.method_8, "push"));
		num += smethod_243("agent-license-deploy/push-failure-does-not-publish", !@class.class306_6.bool_0);
		@class.class306_7 = new Class306("com.indraftInno.ranorigin", "emulator-5554", @class.string_0, @class.byte_1.Length)
		{
			bool_2 = true
		};
		num += smethod_243("agent-license-deploy/private-directory-failure-is-clear", smethod_6(@class.method_9, "anchored private deployment"));
		num += smethod_243("agent-license-deploy/private-directory-failure-does-not-publish", !@class.class306_7.bool_0);
		@class.class306_8 = new Class306("com.indraftInno.ranorigin", "emulator-5554", @class.string_0, @class.byte_1.Length)
		{
			bool_3 = true
		};
		num += smethod_243("agent-license-deploy/permission-readback-failure-is-clear", smethod_6(@class.method_10, "permissions"));
		Class32 class6 = new Class32("com.indraftInno.ranorigin", 10066, "/data/user/0/com.indraftInno.ranorigin", "/data/user/0/com.indraftInno.ranorigin/code_cache/capybara-license/" + @class.string_0 + "/libshare.so", @class.string_0);
		Class226 class7 = new Class226(new IntPtr(501));
		Class119 class8 = new Class119();
		try
		{
			class8.method_34(class7);
			class8.method_39(class6);
			class8.method_46(7001u);
			string gparam_ = class8.method_78(27043);
			num += smethod_244("agent-license-deploy/handshake-success", null, gparam_);
			num += smethod_243("agent-license-deploy/handshake-before-publication", class8.method_47() == new IntPtr(501) && class7.jobject_0 != null && (string?)class7.jobject_0["cmd"] == "libshare_init" && (string?)class7.jobject_0["package"] == "com.indraftInno.ranorigin" && (string?)class7.jobject_0["path"] == class6.string_2 && (string?)class7.jobject_0["sha256"] == @class.string_0 && (int)class7.jobject_0["req"] > 0);
		}
		finally
		{
			((IDisposable)class8).Dispose();
		}
		Class226 class9 = new Class226(new IntPtr(502))
		{
			string_0 = "dlopen failed"
		};
		Class119 class10 = new Class119();
		try
		{
			class10.method_34(class9);
			class10.method_39(class6);
			class10.method_46(7002u);
			string text = class10.method_78(27043);
			num += smethod_243("agent-license-deploy/handshake-failure-closes-unpublished-handle", text != null && text.Contains("dlopen failed") && class10.method_47() == IntPtr.Zero && class9.list_0.Contains(new IntPtr(502)));
		}
		finally
		{
			((IDisposable)class10).Dispose();
		}
		Class226 class11 = new Class226(new IntPtr(503))
		{
			bool_0 = true
		};
		Class119 class12 = new Class119();
		try
		{
			class12.method_34(class11);
			class12.method_39(class6);
			class12.method_36(Class299.class299_0.method_3);
			class12.method_46(7003u);
			string text2 = class12.method_78(27043);
			num += smethod_243("agent-license-deploy/handshake-timeout-closes-handle", text2 != null && text2.Contains("never reported") && class12.method_47() == IntPtr.Zero && class11.list_0.Contains(new IntPtr(503)));
		}
		finally
		{
			((IDisposable)class12).Dispose();
		}
		Class226 interface2_ = new Class226(new IntPtr(504))
		{
			int_0 = 1
		};
		Class119 class13 = new Class119();
		try
		{
			class13.method_34(interface2_);
			class13.method_39(class6);
			class13.method_36(Class299.class299_0.method_4);
			class13.method_46(7004u);
			string text3 = class13.method_78(27043);
			num += smethod_243("agent-license-deploy/stale-request-reply-rejected", text3 != null && text3.Contains("current libshare request") && class13.method_47() == IntPtr.Zero);
		}
		finally
		{
			((IDisposable)class13).Dispose();
		}
		Class226 class14 = new Class226(new IntPtr(505));
		Class119 class15 = new Class119();
		try
		{
			class15.method_34(class14);
			class15.method_46(7005u);
			string text4 = class15.method_79(27043, bool_17: true);
			num += smethod_243("agent-license-deploy/production-missing-descriptor-fails-closed", text4 != null && text4.Contains("descriptor is missing") && class15.method_47() == IntPtr.Zero && class14.list_0.Contains(new IntPtr(505)));
		}
		finally
		{
			((IDisposable)class15).Dispose();
		}
		Class226 class16 = new Class226(new IntPtr(506), new IntPtr(507))
		{
			bool_1 = true
		};
		Class119 class17 = new Class119();
		try
		{
			class17.method_34(class16);
			class17.method_39(class6);
			class17.method_46(7006u);
			string text5 = class17.method_79(27043, bool_17: true);
			string text6 = class17.method_79(27043, bool_17: true);
			num += smethod_243("agent-license-deploy/retry-preserves-validated-descriptor", text5 != null && text5.Contains("attach failed") && text6 == null && class16.jobject_0 != null && class17.method_47() == new IntPtr(507));
		}
		finally
		{
			((IDisposable)class17).Dispose();
		}
		Console.WriteLine((num == 0) ? "PASS agent-license-deploy" : ("FAIL agent-license-deploy: " + num));
		return num;
	}

	internal static int smethod_4(string string_0, string string_1)
	{
		try
		{
			Class32 @class = Class442.smethod_0(string_0, string_1);
			Console.WriteLine("PASS agent-license-deploy-live");
			Console.WriteLine("descriptor=" + new JObject
			{
				["package"] = @class.string_0,
				["path"] = @class.string_2,
				["sha256"] = @class.string_3
			}.ToString(Formatting.None));
			Console.WriteLine("uid=" + @class.int_0);
			Console.WriteLine("publication=" + (@class.bool_0 ? "reused" : "created"));
			return 0;
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine("FAIL agent-license-deploy-live: " + ex.Message);
			return 1;
		}
	}

	private static byte[] smethod_5()
	{
		byte[] array = new byte[64];
		array[0] = 127;
		array[1] = 69;
		array[2] = 76;
		array[3] = 70;
		array[4] = 2;
		array[5] = 1;
		array[18] = 183;
		array[19] = 0;
		for (int i = 20; i < array.Length; i++)
		{
			array[i] = (byte)(i * 3);
		}
		return array;
	}

	private static bool smethod_6(Action action_0, string string_0)
	{
		try
		{
			action_0();
			return false;
		}
		catch (Exception ex)
		{
			return ex.Message.IndexOf(string_0, StringComparison.OrdinalIgnoreCase) >= 0;
		}
	}

	private static Class71.Class72 smethod_7(string string_0, string string_1, string string_2, int int_0)
	{
		throw new InvalidOperationException("ADB must not run for an invalid library");
	}

	internal static int smethod_8()
	{
		int num = 0;
		num = 0 + smethod_9();
		num += smethod_10();
		num += smethod_11();
		num += smethod_12();
		num += smethod_13();
		num += smethod_15();
		Console.WriteLine((num == 0) ? "PASS agent-license-crypto" : ("FAIL agent-license-crypto: " + num));
		return num;
	}

	private static int smethod_9()
	{
		byte[] byte_ = Class103.smethod_5(smethod_18("0b0b0b0b0b0b0b0b0b0b0b0b0b0b0b0b0b0b0b0b0b0b"), smethod_18("000102030405060708090a0b0c"), smethod_18("f0f1f2f3f4f5f6f7f8f9"), 42);
		return smethod_244("agent-license-crypto/rfc5869", "3cb25f25faacd57a90434f64d0362f2a2d2d0a90cf1a5a4c5db02d56ecc4c5bf34007208d5b887185865", smethod_19(byte_));
	}

	private static int smethod_10()
	{
		Class271 @class = new Class271();
		@class.byte_0 = new byte[32];
		@class.byte_1 = new byte[12];
		byte[] array = new byte[16];
		@class.class66_0 = Class103.smethod_6(@class.byte_0, @class.byte_1, new byte[0], array);
		int num = smethod_244("agent-license-crypto/nist-ciphertext", "cea7403d4d606b6e074ec5d3baf39d18", smethod_19(@class.class66_0.byte_0)) + smethod_244("agent-license-crypto/nist-tag", "d0d1c8a799996bf0265b98b5d48ab919", smethod_19(@class.class66_0.byte_1)) + smethod_244("agent-license-crypto/nist-decrypt", smethod_19(array), smethod_19(Class103.smethod_7(@class.byte_0, @class.byte_1, new byte[0], @class.class66_0.byte_0, @class.class66_0.byte_1)));
		@class.byte_2 = (byte[])@class.class66_0.byte_1.Clone();
		@class.byte_2[0] ^= 1;
		return num + smethod_243("agent-license-crypto/tampered-tag-rejected", smethod_14(@class.method_0));
	}

	private static int smethod_11()
	{
		int num = 0;
		byte[] byte_ = smethod_18("000102030405060708090a0b0c0d0e0f");
		byte[] byte_2 = smethod_18("101112131415161718191a1b1c1d1e1f202122232425262728292a2b2c2d2e2f");
		byte[] array = smethod_18("046b17d1f2e12c4247f8bce6e563a440f277037d812deb33a0f4a13945d898c2964fe342e2fe1a7f9b8ee7eb4a7c0f9e162bce33576b315ececbb6406837bf51f5");
		byte[] byte_3 = smethod_18("0000000000000000000000000000000000000000000000000000000000000002");
		byte[] byte_4 = smethod_18("047cf27b188d034f7e8a52380304b51ac3c08969e277f21b35a60b48fc4766997807775510db8ed040293d9ac69f7430dbba7dade63ce982299e04b79d227873d1");
		byte[] byte_5 = smethod_18("a0a1a2a3a4a5a6a7a8a9aaab");
		Class393 class393_ = new Class393(7, 1, 1234u, byte_, byte_2, array);
		Class175 class175_ = new Class175("fixture-license", "fixture-device", "ran-origin", "https://capybara-ran-cafe-gen2-login-status-checker.nikom576.workers.dev");
		using Class103 @class = Class103.smethod_1(class393_, class175_, byte_3, byte_4, byte_5);
		num += smethod_244("agent-license-crypto/p256-client-public", "047cf27b188d034f7e8a52380304b51ac3c08969e277f21b35a60b48fc4766997807775510db8ed040293d9ac69f7430dbba7dade63ce982299e04b79d227873d1", smethod_19(@class.byte_0));
		num += smethod_244("agent-license-crypto/p256-shared-secret", "7cf27b188d034f7e8a52380304b51ac3c08969e277f21b35a60b48fc47669978", smethod_19(Class103.smethod_4(byte_3, byte_4, array)));
		num += smethod_244("agent-license-crypto/plaintext", "0f00666978747572652d6c6963656e73650e00666978747572652d6465766963650a0072616e2d6f726967696e480068747470733a2f2f63617079626172612d72616e2d636166652d67656e322d6c6f67696e2d7374617475732d636865636b65722e6e696b6f6d3537362e776f726b6572732e646576", smethod_19(Class103.smethod_2(class175_)));
		num += smethod_244("agent-license-crypto/cross-native-ciphertext", "6c4353b56f1290dbc887e172949a40093b5c137d72bac59cc7f59c5a32a96b0ad2f9dfc9d21eba699d8963d1e0c44c953b006917eeb35fd531d628b98ed8a62aa23a5c70003b65dfda940d653dba8f9bcdc3b31951126b352b794496c1a7ddc1957cc00c43d9613b7e0535f421fee21e8aeb9426a5e997", smethod_19(@class.byte_3));
		num += smethod_244("agent-license-crypto/cross-native-tag", "74b806a8001446a6369b82a2954c29f1", smethod_19(@class.byte_2));
		return num + smethod_244("agent-license-crypto/configure-length", 93 + @class.byte_3.Length, @class.byte_4.Length);
	}

	private static int smethod_12()
	{
		return smethod_243("agent-license-crypto/empty-license-accepted", !smethod_14(Class299.class299_0.method_5)) + smethod_243("agent-license-crypto/missing-identity-rejected", smethod_14(Class299.class299_0.method_6)) + smethod_243("agent-license-crypto/control-rejected", smethod_14(Class299.class299_0.method_7)) + smethod_243("agent-license-crypto/oversize-field-rejected", smethod_14(Class299.class299_0.method_8)) + smethod_243("agent-license-crypto/invalid-utf16-rejected", smethod_14(Class299.class299_0.method_9)) + smethod_243("agent-license-crypto/bad-public-prefix-rejected", smethod_14(Class299.class299_0.method_10));
	}

	private static int smethod_13()
	{
		Class393 class393_ = new Class393(1, 1, 2u, new byte[16], new byte[32], smethod_18("046b17d1f2e12c4247f8bce6e563a440f277037d812deb33a0f4a13945d898c2964fe342e2fe1a7f9b8ee7eb4a7c0f9e162bce33576b315ececbb6406837bf51f5"));
		Class175 class175_ = new Class175(string.Empty, "device", "server", "https://unit.example");
		Class103 @class = Class103.smethod_0(class393_, class175_);
		Class103 class2 = Class103.smethod_0(class393_, class175_);
		int num = smethod_243("agent-license-crypto/fresh-client-key", !Class80.smethod_1(@class.byte_0, class2.byte_0)) + smethod_243("agent-license-crypto/fresh-nonce", !Class80.smethod_1(@class.byte_1, class2.byte_1));
		byte[] byte_ = @class.byte_3;
		byte[] byte_2 = @class.byte_2;
		@class.Dispose();
		int result = num + smethod_243("agent-license-crypto/dispose-wipes-ciphertext", byte_.All(Class299.class299_0.method_11)) + smethod_243("agent-license-crypto/dispose-wipes-tag", byte_2.All(Class299.class299_0.method_12));
		class2.Dispose();
		return result;
	}

	private static bool smethod_14(Action action_0)
	{
		try
		{
			action_0();
			return false;
		}
		catch (ArgumentException)
		{
			return true;
		}
		catch (InvalidOperationException)
		{
			return true;
		}
		catch (CryptographicException)
		{
			return true;
		}
	}

	private static int smethod_15()
	{
		JObject jObject = smethod_17("000102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f202122232425262728292a2b2c2d2e2f046b17d1f2e12c4247f8bce6e563a440f277037d812deb33a0f4a13945d898c2964fe342e2fe1a7f9b8ee7eb4a7c0f9e162bce33576b315ececbb6406837bf51f5");
		string text = (string?)jObject["clientPublicKey"] + (string?)jObject["nonce"] + (string?)jObject["tag"] + (string?)jObject["ciphertext"];
		return smethod_243("agent-license-crypto/native-interop-envelope", (int)jObject["protocol"] == 1 && (string?)jObject["sessionId"] == "000102030405060708090a0b0c0d0e0f" && (string?)jObject["configure"] == text && jObject.ToString().IndexOf("fixture-license", StringComparison.Ordinal) < 0 && jObject.ToString().IndexOf("fixture-device", StringComparison.Ordinal) < 0);
	}

	internal static int smethod_16(string string_0, string string_1)
	{
		try
		{
			if (string.IsNullOrWhiteSpace(string_1))
			{
				throw new ArgumentException("Output path is required.", "\u0003");
			}
			JObject jObject = smethod_17(string_0);
			File.WriteAllText(string_1, jObject.ToString(Formatting.Indented), new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			Console.WriteLine("PASS agent-license-envelope");
			Console.WriteLine("output=" + Path.GetFullPath(string_1));
			return 0;
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine("FAIL agent-license-envelope: " + ex.Message);
			return 1;
		}
	}

	private static JObject smethod_17(string string_0)
	{
		byte[] array = smethod_18(string_0);
		if (array.Length != 113)
		{
			throw new ArgumentException("Handshake must contain exactly 113 bytes.", "\u000e");
		}
		byte[] array2 = new byte[16];
		byte[] array3 = new byte[32];
		byte[] array4 = new byte[65];
		Buffer.BlockCopy(array, 0, array2, 0, array2.Length);
		Buffer.BlockCopy(array, array2.Length, array3, 0, array3.Length);
		Buffer.BlockCopy(array, array2.Length + array3.Length, array4, 0, array4.Length);
		Class393 @class = new Class393(1, 1, 0u, array2, array3, array4);
		Class175 class175_ = new Class175("fixture-license", "fixture-device", Class135.smethod_2(), Class135.smethod_0());
		using Class103 class2 = Class103.smethod_0(@class, class175_);
		return new JObject
		{
			["protocol"] = 1,
			["sessionId"] = @class.method_0(),
			["clientPublicKey"] = smethod_19(class2.byte_0),
			["nonce"] = smethod_19(class2.byte_1),
			["tag"] = smethod_19(class2.byte_2),
			["ciphertext"] = smethod_19(class2.byte_3),
			["configure"] = smethod_19(class2.byte_4)
		};
	}

	private static byte[] smethod_18(string string_0)
	{
		if (string_0 != null && (string_0.Length & 1) == 0)
		{
			byte[] array = new byte[string_0.Length / 2];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToByte(string_0.Substring(i * 2, 2), 16);
			}
			return array;
		}
		throw new ArgumentException("hex length");
	}

	private static string smethod_19(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
		foreach (byte b in byte_0)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	internal static int smethod_20()
	{
		int num = 0;
		num = 0 + smethod_21();
		num += smethod_22();
		num += smethod_23();
		num += smethod_24();
		num += smethod_26();
		num += smethod_25();
		Console.WriteLine((num == 0) ? "PASS agent-license" : ("FAIL agent-license: " + num));
		return num;
	}

	private static int smethod_21()
	{
		Class201 @class = new Class201();
		int num = 0;
		Class265 class2 = new Class265(new IntPtr(801));
		@class.string_0 = "not-current-yet";
		List<string> list = new List<string>();
		using Class119 class3 = smethod_27(class2, 8101u);
		class3.method_2(list.Add);
		@class.int_0 = 0;
		class3.method_38(@class.method_0);
		@class.string_0 = "current-device";
		string gparam_ = class3.method_80(27043);
		num += smethod_244("agent-license/startup-success", null, gparam_);
		num += smethod_244("agent-license/provider-read-on-run", 1, @class.int_0);
		num += smethod_243("agent-license/bootstrap-before-publication", class3.method_47() == new IntPtr(801) && class2.list_1.IndexOf("libshare_init") < class2.list_1.IndexOf("license_open") && class2.list_1.IndexOf("license_open") < class2.list_1.IndexOf("license_bootstrap"));
		num += smethod_243("agent-license/bootstrap-carries-ciphertext-only", class2.jobject_0 != null && ((string?)class2.jobject_0["clientPublicKey"]).Length == 130 && ((string?)class2.jobject_0["nonce"]).Length == 24 && ((string?)class2.jobject_0["tag"]).Length == 32 && ((string?)class2.jobject_0["ciphertext"]).Length > 0 && class2.jobject_0.ToString().IndexOf("secret-license", StringComparison.Ordinal) < 0 && class2.jobject_0.ToString().IndexOf("current-device", StringComparison.Ordinal) < 0 && class2.jobject_0.ToString().IndexOf("https://worker.example", StringComparison.Ordinal) < 0);
		num += smethod_243("agent-license/published-before-first-authorization", class3.method_47() != IntPtr.Zero && !class3.method_50().bool_0);
		int int_ = class2.int_0;
		class2.method_1();
		num += smethod_244("agent-license/replayed-hello-ignored", int_, class2.int_0);
		class2.method_2(class2.method_0(), bool_4: true, "accepted", "ok", 1, 1);
		Class147 class4 = class3.method_50();
		num += smethod_243("agent-license/current-status-published", class4.bool_0 && class4.string_1 == "accepted" && class4.string_2 == "ok" && class4.int_0 == 1 && class4.int_1 == 1);
		num += smethod_243("agent-license/no-credential-logging", list.TrueForAll(Class299.class299_0.method_13));
		class3.method_210();
		return num + smethod_243("agent-license/dispose-before-native-close", class2.list_2.IndexOf("license_dispose") >= 0 && class2.list_2.IndexOf("license_dispose") < class2.list_2.IndexOf("close"));
	}

	private static int smethod_22()
	{
		Class265 @class = new Class265(new IntPtr(802));
		using Class119 class2 = smethod_27(@class, 8102u);
		class2.method_38(Class299.class299_0.method_14);
		string text = class2.method_80(27043);
		return smethod_243("agent-license/missing-identity-fails-closed", text != null && text.IndexOf("identity", StringComparison.OrdinalIgnoreCase) >= 0 && @class.int_1 == 0 && class2.method_47() == IntPtr.Zero && @class.list_0.Contains(new IntPtr(802)));
	}

	private static int smethod_23()
	{
		int num = 0;
		Class265 @class = new Class265(new IntPtr(803))
		{
			bool_0 = true
		};
		using Class119 class2 = smethod_27(@class, 8103u);
		class2.method_38(smethod_29);
		class2.method_37(Class299.class299_0.method_15);
		string text = class2.method_80(27043);
		num += smethod_243("agent-license/hello-timeout-fails-closed", text != null && text.IndexOf("never reported", StringComparison.OrdinalIgnoreCase) >= 0 && class2.method_47() == IntPtr.Zero && @class.list_0.Contains(new IntPtr(803)));
		return num + smethod_243("agent-license/timeout-disposes-context", @class.list_1.Contains("license_dispose"));
	}

	private static int smethod_24()
	{
		int num = 0;
		using (Class119 @class = smethod_27(new Class265(new IntPtr(804))
		{
			int_2 = 1
		}, 8104u))
		{
			@class.method_38(smethod_29);
			@class.method_37(Class299.class299_0.method_16);
			string text = @class.method_80(27043);
			num += smethod_243("agent-license/stale-request-rejected", text != null && text.IndexOf("current license request", StringComparison.OrdinalIgnoreCase) >= 0 && @class.method_47() == IntPtr.Zero);
		}
		using (Class119 class2 = smethod_27(new Class265(new IntPtr(805))
		{
			int_3 = 1
		}, 8105u))
		{
			class2.method_38(smethod_29);
			class2.method_37(Class299.class299_0.method_17);
			string text2 = class2.method_80(27043);
			num += smethod_243("agent-license/wrong-pid-rejected", text2 != null && text2.IndexOf("current license request", StringComparison.OrdinalIgnoreCase) >= 0 && class2.method_47() == IntPtr.Zero);
		}
		Class265 class3 = new Class265(new IntPtr(808))
		{
			bool_1 = true
		};
		using (Class119 class4 = smethod_27(class3, 8108u))
		{
			class4.method_38(smethod_29);
			string text3 = null;
			Exception ex = null;
			try
			{
				text3 = class4.method_80(27043);
			}
			catch (Exception ex2)
			{
				ex = ex2;
			}
			num += smethod_243("agent-license/invalid-public-point-fails-closed", ex == null && text3 != null && text3.IndexOf("cryptographic", StringComparison.OrdinalIgnoreCase) >= 0 && class3.list_1.Contains("license_dispose") && class4.method_47() == IntPtr.Zero);
		}
		using Class119 class5 = smethod_27(new Class265(new IntPtr(809))
		{
			bool_2 = true
		}, 8109u);
		class5.method_38(smethod_29);
		class5.method_37(Class299.class299_0.method_18);
		string text4 = class5.method_80(27043);
		return num + smethod_243("agent-license/mismatched-bootstrap-ack-rejected", text4 != null && text4.IndexOf("current license bootstrap", StringComparison.OrdinalIgnoreCase) >= 0 && class5.method_47() == IntPtr.Zero);
	}

	private static int smethod_25()
	{
		int num = 0;
		Class265 @class = new Class265(new IntPtr(806), new IntPtr(807));
		using Class119 class2 = smethod_27(@class, 8106u);
		class2.method_38(smethod_29);
		num += smethod_244("agent-license/old-generation-first-start", null, class2.method_80(27043));
		int int_ = @class.method_0();
		class2.method_210();
		class2.method_39(smethod_28());
		num += smethod_244("agent-license/old-generation-second-start", null, class2.method_80(27043));
		@class.method_2(int_, bool_4: true, "accepted", "stale", 6, 3);
		num += smethod_243("agent-license/old-generation-status-rejected", !class2.method_50().bool_0 && class2.method_50().string_2 != "stale");
		@class.method_2(@class.method_0(), bool_4: true, "accepted", "current", 1, 1);
		return num + smethod_243("agent-license/new-generation-status-accepted", class2.method_50().bool_0 && class2.method_50().string_2 == "current");
	}

	private static int smethod_26()
	{
		using Class119 @class = smethod_27(new Class265(new IntPtr(810))
		{
			bool_3 = true
		}, 8110u);
		@class.method_38(smethod_29);
		string text = @class.method_80(27043);
		Class147 class2 = @class.method_50();
		return smethod_243("agent-license/synchronous-status-after-ack-retained", text == null && class2.bool_0 && class2.string_1 == "accepted" && class2.string_2 == "immediate");
	}

	private static Class119 smethod_27(Class265 class265_0, uint uint_0)
	{
		Class119 @class = new Class119();
		@class.method_34(class265_0);
		@class.method_39(smethod_28());
		@class.method_46(uint_0);
		class265_0.uint_0 = uint_0;
		return @class;
	}

	private static Class32 smethod_28()
	{
		return new Class32("com.indraftInno.ranorigin", 10066, "/data/user/0/com.indraftInno.ranorigin", "/data/user/0/com.indraftInno.ranorigin/code_cache/capybara-license/1111111111111111111111111111111111111111111111111111111111111111/libshare.so", "1111111111111111111111111111111111111111111111111111111111111111");
	}

	private static Class175 smethod_29()
	{
		return new Class175(string.Empty, "fixture-device", "ran-origin", "https://worker.example");
	}

	internal static int smethod_30()
	{
		int int_ = 0;
		string text = Path.Combine(Path.GetTempPath(), "Capybara-ProductLayout-Test");
		string text2 = Path.Combine(text, "other-working-directory");
		string currentDirectory = Environment.CurrentDirectory;
		Directory.CreateDirectory(text2);
		try
		{
			Environment.CurrentDirectory = text2;
			int_ += smethod_244("product-layout/native-path", Path.GetFullPath(Path.Combine(text, "config", "klx.dll")), Class18.smethod_0(text));
			int_ += smethod_244("product-layout/runner-path", Path.GetFullPath(Path.Combine(text, "config", "klxsvc")), Class18.smethod_1(text));
			int_ += smethod_243("product-layout/native-missing-rejected", !Class384.smethod_3(Class18.smethod_0(text), out var string_));
			int_ += smethod_243("product-layout/native-missing-path", string_ != null && string_.IndexOf(Class18.smethod_0(text), StringComparison.OrdinalIgnoreCase) >= 0);
			int_ += smethod_244("product-layout/runtime-runner-path", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config", "klxsvc")), Class180.smethod_1());
			int_ += smethod_243("product-layout/missing-packaged-runner", !Class421.smethod_1());
			Struct31 @struct = Class392.smethod_0(Enum3.RunnerMissing, Enum0.Idle);
			int_ += smethod_244("product-layout/missing-runner-text", "Setup", @struct.string_0);
			int_ += smethod_243("product-layout/missing-runner-tip-path", @struct.string_1.IndexOf("config\\klxsvc", StringComparison.OrdinalIgnoreCase) >= 0);
			int_ += smethod_243("product-layout/missing-runner-tip-no-setting", @struct.string_1.IndexOf("RunnerLocalPath", StringComparison.OrdinalIgnoreCase) < 0);
			string text3 = smethod_173("Capybara-UI-Winform\\Session\\KlxNative.cs", ref int_);
			int_ += smethod_243("product-layout/pinvoke-name", text3 != null && text3.IndexOf("private const string Dll = \"klx.dll\"", StringComparison.Ordinal) >= 0);
			string text4 = smethod_173("Capybara-UI-Winform\\Capybara-UI-Winform.csproj", ref int_);
			int_ += smethod_243("product-layout/no-root-native-copy", text4 != null && text4.IndexOf("<Link>klx_frida.dll</Link>", StringComparison.OrdinalIgnoreCase) < 0);
			string text5 = smethod_173("Capybara-UI-Winform\\Program.cs", ref int_);
			int_ += smethod_243("product-layout/cli-route", text5 != null && text5.IndexOf("--test-product-layout", StringComparison.Ordinal) >= 0 && text5.IndexOf("ProductPackage.RunCli()", StringComparison.Ordinal) >= 0);
		}
		finally
		{
			Environment.CurrentDirectory = currentDirectory;
			try
			{
				Directory.Delete(text, recursive: true);
			}
			catch (IOException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
		}
		Console.WriteLine((int_ == 0) ? "PASS product-layout-paths" : ("FAIL product-layout-paths=" + int_));
		return int_;
	}

	internal static int smethod_31()
	{
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), "Capybara-ProductManifest-Test");
		try
		{
			Directory.CreateDirectory(Path.Combine(text, "config"));
			Directory.CreateDirectory(Path.Combine(text, "OneOCR"));
			File.WriteAllText(Path.Combine(text, Class135.smethod_4() + ".exe"), "fixture");
			File.WriteAllBytes(Path.Combine(text, "config", "klx.dll"), new byte[1] { 1 });
			string text2 = Path.Combine(text, "config", "klxsvc");
			File.WriteAllBytes(text2, smethod_41());
			string[] string_ = Class436.string_0;
			foreach (string path in string_)
			{
				File.WriteAllBytes(Path.Combine(text, "OneOCR", path), new byte[1] { 1 });
			}
			num += smethod_243("product-layout/manifest-accepts-exact-layout", Class436.smethod_1(text, out var list_));
			num += smethod_244("product-layout/manifest-exact-errors", 0, list_.Count);
			num += smethod_243("product-layout/runner-elf64-x86-64", Class436.smethod_2(text2));
			File.WriteAllText(Path.Combine(text, "OneOCR", "notes.txt"), "not allowed");
			num += smethod_243("product-layout/manifest-rejects-oneocr-extra", !Class436.smethod_1(text, out list_));
			num += smethod_243("product-layout/manifest-names-oneocr-extra", smethod_40(list_, "notes.txt"));
			File.Delete(Path.Combine(text, "OneOCR", "notes.txt"));
			Directory.CreateDirectory(Path.Combine(text, "OneOCR", "nested"));
			num += smethod_243("product-layout/manifest-rejects-oneocr-nested", !Class436.smethod_1(text, out list_));
			num += smethod_243("product-layout/manifest-names-oneocr-nested", smethod_40(list_, "nested"));
			Directory.Delete(Path.Combine(text, "OneOCR", "nested"));
			File.Move(Path.Combine(text, "OneOCR", "oneocr.onemodel"), Path.Combine(text, "OneOCR", "renamed.model"));
			num += smethod_243("product-layout/manifest-rejects-oneocr-rename", !Class436.smethod_1(text, out list_));
			num += smethod_243("product-layout/manifest-names-oneocr-missing", smethod_40(list_, "oneocr.onemodel"));
			File.Move(Path.Combine(text, "OneOCR", "renamed.model"), Path.Combine(text, "OneOCR", "oneocr.onemodel"));
			string_ = Class436.string_0;
			foreach (string path2 in string_)
			{
				File.Delete(Path.Combine(text, "OneOCR", path2));
			}
			Directory.Delete(Path.Combine(text, "OneOCR"));
			num += smethod_243("product-layout/manifest-rejects-missing-oneocr", !Class436.smethod_1(text, out list_));
			Directory.CreateDirectory(Path.Combine(text, "OneOCR"));
			string_ = Class436.string_0;
			foreach (string path3 in string_)
			{
				File.WriteAllBytes(Path.Combine(text, "OneOCR", path3), new byte[1] { 1 });
			}
			string text3 = Class135.smethod_4() + ".exe.config";
			File.WriteAllText(Path.Combine(text, text3), "not allowed");
			num += smethod_243("product-layout/manifest-rejects-exe-config", !Class436.smethod_1(text, out list_));
			num += smethod_243("product-layout/manifest-names-exe-config", smethod_40(list_, text3));
			File.Delete(Path.Combine(text, text3));
			File.WriteAllBytes(text2, new byte[20]);
			num += smethod_243("product-layout/runner-rejects-non-elf", !Class436.smethod_2(text2));
		}
		finally
		{
			try
			{
				Directory.Delete(text, recursive: true);
			}
			catch (IOException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
		}
		Console.WriteLine((num == 0) ? "PASS product-layout-manifest" : ("FAIL product-layout-manifest=" + num));
		return num;
	}

	internal static int smethod_32()
	{
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), "Capybara-NativeBridgeCollision-Test");
		try
		{
			string text2 = Path.Combine(text, "decoy");
			string text3 = Path.Combine(text, "expected", "config");
			Directory.CreateDirectory(text2);
			Directory.CreateDirectory(text3);
			string text4 = Path.Combine(text2, "klx.dll");
			string text5 = Path.Combine(text3, "klx.dll");
			string text6 = smethod_171("Capybara-UI-Winform\\Native\\klx_frida.dll");
			num += smethod_243("product-layout/collision/source-native", File.Exists(text6));
			if (num == 0)
			{
				File.Copy(text6, text5);
			}
			string string_;
			bool flag = smethod_36(text2, text4, out string_);
			num += smethod_243("product-layout/collision/decoy-compiled", flag);
			if (!flag)
			{
				Console.WriteLine("collision compiler: " + string_);
			}
			if (num == 0)
			{
				string string_2;
				int gparam_ = smethod_37(text4, text5, out string_2);
				num += smethod_244("product-layout/collision/child-exit", 0, gparam_);
				num += smethod_243("product-layout/collision/child-pass", string_2.IndexOf("PASS native-collision", StringComparison.Ordinal) >= 0);
				string string_3;
				int gparam_2 = smethod_38(text5, out string_3);
				num += smethod_244("product-layout/owned-reference/child-exit", 0, gparam_2);
				num += smethod_243("product-layout/owned-reference/child-pass", string_3.IndexOf("PASS native-owned-reference", StringComparison.Ordinal) >= 0);
				string string_4;
				int gparam_3 = smethod_39(text4, text5, out string_4);
				num += smethod_244("product-layout/post-load-collision/child-exit", 0, gparam_3);
				num += smethod_243("product-layout/post-load-collision/child-pass", string_4.IndexOf("PASS native-post-load-collision", StringComparison.Ordinal) >= 0);
			}
		}
		finally
		{
			try
			{
				Directory.Delete(text, recursive: true);
			}
			catch (IOException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
		}
		Console.WriteLine((num == 0) ? "PASS native-bridge-collision" : ("FAIL native-bridge-collision=" + num));
		return num;
	}

	internal static int smethod_33(string string_0, string string_1)
	{
		if (LoadLibraryExW(string_0, IntPtr.Zero, 0u) == IntPtr.Zero)
		{
			Console.Error.WriteLine("collision child could not preload decoy: " + Marshal.GetLastWin32Error());
			return 2;
		}
		if (Class384.smethod_3(string_1, out var string_2))
		{
			Console.Error.WriteLine("collision child accepted a basename collision");
			return 1;
		}
		if (!string.IsNullOrEmpty(string_2) && string_2.IndexOf(string_1, StringComparison.OrdinalIgnoreCase) >= 0 && string_2.IndexOf(string_0, StringComparison.OrdinalIgnoreCase) >= 0)
		{
			Console.WriteLine("PASS native-collision");
			return 0;
		}
		Console.Error.WriteLine("collision child did not report expected and actual paths: " + (string_2 ?? "(none)"));
		return 1;
	}

	internal static int smethod_34(string string_0)
	{
		IntPtr intPtr = LoadLibraryExW(string_0, IntPtr.Zero, 0u);
		if (intPtr == IntPtr.Zero)
		{
			Console.Error.WriteLine("owned-reference child could not preload real bridge: " + Marshal.GetLastWin32Error());
			return 2;
		}
		if (!Class384.smethod_3(string_0, out var string_1))
		{
			Console.Error.WriteLine("owned-reference child rejected expected bridge: " + string_1);
			return 1;
		}
		if (!FreeLibrary(intPtr))
		{
			Console.Error.WriteLine("owned-reference child could not release external handle: " + Marshal.GetLastWin32Error());
			return 2;
		}
		try
		{
			if (string.IsNullOrWhiteSpace(Class63.smethod_1(Class63.klx_frida_version())))
			{
				Console.Error.WriteLine("owned-reference child received no native version");
				return 1;
			}
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine("owned-reference child lost native bridge: " + ex.GetType().Name + ": " + ex.Message);
			return 1;
		}
		Console.WriteLine("PASS native-owned-reference");
		return 0;
	}

	internal static int smethod_35(string string_0, string string_1)
	{
		Class276 @class = new Class276();
		@class.string_0 = string_0;
		@class.intptr_0 = IntPtr.Zero;
		@class.int_0 = 0;
		Class384.smethod_1(@class.method_0);
		Class384.smethod_2(@class.method_1);
		try
		{
			if (Class384.smethod_3(string_1, out var string_2))
			{
				Console.Error.WriteLine("post-load child accepted a late basename collision");
				return 1;
			}
			if (@class.intptr_0 == IntPtr.Zero)
			{
				Console.Error.WriteLine("post-load child could not load late decoy: " + Marshal.GetLastWin32Error());
				return 2;
			}
			if (string.IsNullOrEmpty(string_2) || string_2.IndexOf(string_1, StringComparison.OrdinalIgnoreCase) < 0 || string_2.IndexOf(@class.string_0, StringComparison.OrdinalIgnoreCase) < 0)
			{
				Console.Error.WriteLine("post-load child did not report expected and actual paths: " + (string_2 ?? "(none)"));
				return 1;
			}
		}
		finally
		{
			Class384.smethod_1(null);
			Class384.smethod_2(null);
		}
		Console.WriteLine("PASS native-post-load-collision");
		return 0;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr LoadLibraryExW(string string_0, IntPtr intptr_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool FreeLibrary(IntPtr intptr_0);

	private static bool smethod_36(string string_0, string string_1, out string string_2)
	{
		string_2 = null;
		string text = "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\VC\\Auxiliary\\Build\\vcvars64.bat";
		if (!File.Exists(text))
		{
			string_2 = "vcvars64.bat was not found: " + text;
			return false;
		}
		string text2 = Path.Combine(string_0, "decoy.c");
		File.WriteAllText(text2, "__declspec(dllexport) const char* klx_frida_version(void) { return \"DECOY\"; }\r\n");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec") ?? "cmd.exe";
		processStartInfo.Arguments = "/d /s /c \"\"" + text + "\" && cl.exe /nologo /LD /Fe:\"" + string_1 + "\" \"" + text2 + "\"\"";
		processStartInfo.WorkingDirectory = string_0;
		processStartInfo.UseShellExecute = false;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.CreateNoWindow = true;
		using Process process = Process.Start(processStartInfo);
		string text3 = process.StandardOutput.ReadToEnd();
		string text4 = process.StandardError.ReadToEnd();
		process.WaitForExit();
		if (process.ExitCode == 0 && File.Exists(string_1))
		{
			return true;
		}
		string_2 = "exit " + process.ExitCode + ": " + text3 + text4;
		return false;
	}

	private static int smethod_37(string string_0, string string_1, out string string_2)
	{
		string location = Assembly.GetExecutingAssembly().Location;
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = location;
		processStartInfo.Arguments = "--test-native-collision-child \"" + string_0 + "\" \"" + string_1 + "\"";
		processStartInfo.UseShellExecute = false;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.CreateNoWindow = true;
		using Process process = Process.Start(processStartInfo);
		string text = process.StandardOutput.ReadToEnd();
		string text2 = process.StandardError.ReadToEnd();
		process.WaitForExit();
		string_2 = text + text2;
		return process.ExitCode;
	}

	private static int smethod_38(string string_0, out string string_1)
	{
		string location = Assembly.GetExecutingAssembly().Location;
		using Process process = Process.Start(new ProcessStartInfo
		{
			FileName = location,
			Arguments = "--test-native-owned-reference-child \"" + string_0 + "\"",
			UseShellExecute = false,
			RedirectStandardOutput = true,
			RedirectStandardError = true,
			CreateNoWindow = true
		});
		string text = process.StandardOutput.ReadToEnd();
		string text2 = process.StandardError.ReadToEnd();
		process.WaitForExit();
		string_1 = text + text2;
		return process.ExitCode;
	}

	private static int smethod_39(string string_0, string string_1, out string string_2)
	{
		string location = Assembly.GetExecutingAssembly().Location;
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = location;
		processStartInfo.Arguments = "--test-native-post-load-collision-child \"" + string_0 + "\" \"" + string_1 + "\"";
		processStartInfo.UseShellExecute = false;
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.CreateNoWindow = true;
		using Process process = Process.Start(processStartInfo);
		string text = process.StandardOutput.ReadToEnd();
		string text2 = process.StandardError.ReadToEnd();
		process.WaitForExit();
		string_2 = text + text2;
		return process.ExitCode;
	}

	private static bool smethod_40(IReadOnlyList<string> ireadOnlyList_0, string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < ireadOnlyList_0.Count)
			{
				if (ireadOnlyList_0[num].IndexOf(string_0, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static byte[] smethod_41()
	{
		return new byte[20]
		{
			127, 69, 76, 70, 2, 1, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 62, 0
		};
	}

	internal static int smethod_42()
	{
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), "klx-runner-deploy-test-" + Guid.NewGuid().ToString("N"));
		File.WriteAllText(text, "runner payload for offline deploy test");
		try
		{
			Class216 @class = new Class216();
			using (SHA256 sHA = SHA256.Create())
			{
				using FileStream inputStream = File.OpenRead(text);
				@class.string_0 = BitConverter.ToString(sHA.ComputeHash(inputStream)).Replace("-", string.Empty).ToLowerInvariant();
			}
			@class.long_0 = new FileInfo(text).Length;
			@class.func_0 = @class.method_0;
			num += smethod_243("runner-deploy/matching-file-and-marker-current", Class421.smethod_5(text, "adb", "emulator-5554", @class.func_0).enum3_0 == Enum3.Current);
			Func<string, string, string, int, Class71.Class72> func_ = @class.method_1;
			num += smethod_243("runner-deploy/offline-is-unknown", Class421.smethod_5(text, "adb", "emulator-5554", func_).enum3_0 == Enum3.Unknown);
			Func<string, string, string, int, Class71.Class72> func_2 = @class.method_2;
			num += smethod_243("runner-deploy/marker-alone-not-current", Class421.smethod_5(text, "adb", "emulator-5554", func_2).enum3_0 == Enum3.Stale);
			Func<string, string, string, int, Class71.Class72> func_3 = @class.method_3;
			num += smethod_243("runner-deploy/root-error-is-unknown", Class421.smethod_5(text, "adb", "emulator-5554", func_3).enum3_0 == Enum3.Unknown);
			Func<string, string, string, int, Class71.Class72> func_4 = @class.method_4;
			num += smethod_243("runner-deploy/wrong-size-is-stale", Class421.smethod_5(text, "adb", "emulator-5554", func_4).enum3_0 == Enum3.Stale);
			Func<string, string, string, int, Class71.Class72> func_5 = @class.method_5;
			num += smethod_243("runner-deploy/serial-isolation", Class421.smethod_5(text, "adb", "emulator-5554", func_5).enum3_0 == Enum3.Current && Class421.smethod_5(text, "adb", "emulator-5556", func_5).enum3_0 == Enum3.Stale);
			Class85 class2 = new Class85
			{
				string_1 = "emulator-5554"
			};
			Class85 class85_ = new Class85
			{
				string_1 = "emulator-5556"
			};
			num += smethod_243("runner-deploy/discard-late-target-check", GForm0.smethod_2(class2, class2, 4L, 4L) && !GForm0.smethod_2(class85_, class2, 5L, 4L));
			num += smethod_243("runner-deploy/selected-phase-shows-stale", Class392.smethod_0(Enum3.Stale, Enum0.Selected).bool_0 && Class392.smethod_0(Enum3.Stale, Enum0.Selected).color_0 == Class392.color_1);
			Class206 class3 = new Class206(@class.long_0, @class.string_0);
			class3.bool_0 = true;
			bool flag = Class421.smethod_16(text, "adb", "emulator-5554", null, class3.method_0, out var string_);
			num += smethod_243("runner-deploy/push-failure-preserves-old", !flag && class3.string_1 == class3.string_0 && class3.string_2 == class3.string_0 && string_.Contains("push failed"));
			class3 = new Class206(@class.long_0, @class.string_0)
			{
				bool_0 = true,
				bool_1 = true
			};
			flag = Class421.smethod_16(text, "adb", "emulator-5554", null, class3.method_0, out string_);
			num += smethod_243("runner-deploy/orphan-path-visible-on-cleanup-failure", !flag && string_.Contains(".klxsvc.upload.") && string_.Contains("cleanup failed"));
			class3 = new Class206(@class.long_0, @class.string_0)
			{
				bool_6 = true
			};
			flag = Class421.smethod_16(text, "adb", "emulator-5554", null, class3.method_0, out string_);
			num += smethod_243("runner-deploy/live-runner-blocks-push", !flag && class3.int_0 == 0 && class3.string_1 == class3.string_0);
			class3 = new Class206(@class.long_0, @class.string_0)
			{
				bool_2 = true
			};
			flag = Class421.smethod_16(text, "adb", "emulator-5554", null, class3.method_0, out string_);
			num += smethod_243("runner-deploy/marker-failure-preserves-old", !flag && class3.string_1 == class3.string_0 && class3.string_2 == class3.string_0);
			class3 = new Class206(@class.long_0, @class.string_0)
			{
				bool_3 = true
			};
			flag = Class421.smethod_16(text, "adb", "emulator-5554", null, class3.method_0, out string_);
			num += smethod_243("runner-deploy/runner-promotion-failure-rolls-back", !flag && class3.string_1 == class3.string_0 && class3.string_2 == class3.string_0 && class3.bool_4);
			@class.int_0 = 0;
			@class.int_1 = 0;
			Stopwatch stopwatch = Stopwatch.StartNew();
			Func<string, string, string, int, Class71.Class72> func_6 = @class.method_6;
			Class82 class4 = Class421.smethod_6(text, "adb", "emulator-5554", func_6, 2250);
			num += smethod_243("runner-deploy/deadline-covers-whole-check", class4.enum3_0 == Enum3.Unknown && @class.int_0 <= 2 && @class.int_1 < 150 && stopwatch.ElapsedMilliseconds < 300L);
			class3 = new Class206(@class.long_0, @class.string_0)
			{
				bool_5 = true
			};
			flag = Class421.smethod_16(text, "adb", "emulator-5554", null, class3.method_0, out string_);
			num += smethod_243("runner-deploy/promotion-failure-rolls-back", !flag && class3.string_1 == class3.string_0 && class3.string_2 == class3.string_0);
			class3 = new Class206(@class.long_0, @class.string_0);
			flag = Class421.smethod_16(text, "adb", "emulator-5554", null, class3.method_0, out string_);
			num += smethod_243("runner-deploy/stage-promote-and-recheck", flag && class3.string_1 == @class.string_0 && class3.string_2 == @class.string_0 && class3.int_0 == 1);
			class3 = new Class206(@class.long_0, @class.string_0)
			{
				bool_1 = true
			};
			flag = Class421.smethod_16(text, "adb", "emulator-5554", null, class3.method_0, out string_);
			num += smethod_243("runner-deploy/installed-but-orphan-visible", !flag && class3.string_1 == @class.string_0 && class3.string_2 == @class.string_0 && string_.Contains(".klxsvc.upload.") && string_.Contains("cleanup failed"));
		}
		finally
		{
			File.Delete(text);
		}
		Console.WriteLine("runner-deploy: " + num + " failed");
		return num;
	}

	internal static int smethod_43()
	{
		Class296 @class = new Class296();
		int num = 0;
		@class.int_0 = 0;
		Form1 form = new Form1(@class.method_0);
		try
		{
			form.method_1(Keys.F2);
			Thread.Sleep(80);
			num += smethod_243("autoclick/f2-starts", Volatile.Read(ref @class.int_0) > 0);
			form.method_1(Keys.F2);
			int num2 = Volatile.Read(ref @class.int_0);
			Thread.Sleep(50);
			return num + smethod_243("autoclick/f2-stops", Volatile.Read(ref @class.int_0) == num2);
		}
		finally
		{
			((IDisposable)form).Dispose();
		}
	}

	internal static int smethod_44()
	{
		Class256 @class = new Class256();
		int num = 0;
		@class.string_0 = null;
		Dictionary<string, string> ireadOnlyDictionary_ = new Dictionary<string, string> { { "11:1", "Pet Card [7D]" } };
		Class145 class145_ = Class145.class145_0.method_98(new Struct27[1]
		{
			new Struct27
			{
				int_0 = 3,
				int_1 = 3,
				ushort_0 = 11,
				ushort_1 = 1,
				int_2 = 1
			}
		}, new Struct19[0], new Class95(null, ireadOnlyDictionary_, null), 1, 24, 60);
		Form7 form = new Form7(null, null, @class.method_0);
		try
		{
			form.method_0(class145_);
			form.method_5(3);
			return num + smethod_244("pet-card-pick/name", "Pet Card [7D]", @class.string_0);
		}
		finally
		{
			((IDisposable)form).Dispose();
		}
	}

	internal static int smethod_45()
	{
		int num = 0;
		string text = "the push did not leave 121746248 bytes on the device - " + Environment.NewLine + "adb: error: failed to copy config\\klxsvc to /data/local/tmp/.klxsvc: No space left on device; verify the selected emulator's writable disk";
		Form0 form = new Form0("unused-adb", "emulator-5554");
		try
		{
			_ = form.Handle;
			FieldInfo field = typeof(Form0).GetField("_detail", BindingFlags.Instance | BindingFlags.NonPublic);
			System.Windows.Forms.Label label = ((field == null) ? null : (field.GetValue(form) as System.Windows.Forms.Label));
			num += smethod_243("deploy-error-ui/progress-unchanged", form.Size == new Size(420, 210) && label != null && label.Text == "Deploying runner..." && label.Height == 22);
			MethodInfo methodInfo = typeof(Form0).GetMethod("method_4", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			num += smethod_243("deploy-error-ui/finish-method", methodInfo != null);
			if (methodInfo != null)
			{
				methodInfo.Invoke(form, new object[2] { false, text });
				Application.DoEvents();
			}
			FieldInfo field2 = typeof(Form0).GetField("_errorDetail", BindingFlags.Instance | BindingFlags.NonPublic);
			TextBox textBox = ((field2 == null) ? null : (field2.GetValue(form) as TextBox));
			Button button = typeof(Form0).GetField("_close", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(form) as Button;
			num += smethod_243("deploy-error-ui/full-copyable-error", textBox != null && textBox.Text == text && textBox.ReadOnly);
			num += smethod_243("deploy-error-ui/three-wrapped-lines", textBox != null && textBox.Multiline && textBox.WordWrap && textBox.ScrollBars == ScrollBars.Vertical && textBox.Height >= textBox.Font.Height * 3 && textBox.Height <= textBox.Font.Height * 5);
			num += smethod_243("deploy-error-ui/no-overlap", textBox != null && button != null && textBox.Top >= 109 && textBox.Bottom < button.Top && button.Bottom < form.ClientSize.Height);
			num += smethod_243("deploy-error-ui/compact-dialog", textBox != null && form.Height > 210 && form.Height <= 220 + textBox.Height);
		}
		finally
		{
			((IDisposable)form).Dispose();
		}
		Console.WriteLine("deploy-error-ui: " + num + " failed");
		return num;
	}

	public static int smethod_46()
	{
		return smethod_251() + smethod_286() + smethod_282() + smethod_276() + smethod_278() + smethod_279() + smethod_280() + smethod_57() + smethod_100() + smethod_231() + smethod_151() + smethod_152() + smethod_101() + smethod_115() + smethod_117() + smethod_118() + smethod_119() + smethod_102() + smethod_103() + smethod_120() + smethod_147() + smethod_248() + smethod_148() + smethod_149() + smethod_150() + smethod_232() + smethod_126() + smethod_125() + smethod_127() + smethod_128() + smethod_144() + smethod_130() + smethod_154() + smethod_155() + smethod_212() + smethod_129() + smethod_153() + smethod_213() + smethod_48() + smethod_47() + smethod_52() + smethod_30() + smethod_31() + smethod_32() + smethod_297() + smethod_298() + smethod_299();
	}

	public static int smethod_47()
	{
		Class300 @class = new Class300();
		int num = 0;
		bool flag = false;
		@class.methodInfo_0 = typeof(GForm0).GetMethod("method_65", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		MethodInfo methodInfo = typeof(GForm0).GetMethod("method_66", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		MethodInfo methodInfo2 = typeof(GForm0).GetMethod("method_68", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		num = 0 + smethod_243("select-hero/contract/operation", @class.methodInfo_0 != null);
		num += smethod_243("select-hero/contract/bounded-wait", methodInfo != null);
		num += smethod_243("select-hero/contract/select", methodInfo2 != null);
		if (@class.methodInfo_0 != null)
		{
			Class220 class2 = new Class220();
			class2.class300_0 = @class;
			class2.class339_0 = new Class339();
			try
			{
				Class280 class3 = new Class280();
				class3.class220_0 = class2;
				class3.int_0 = 0;
				class3.class220_0.class339_0.class119_0.method_30(class3.method_0);
				Task result = Task.Factory.StartNew((Func<Task>)class3.class220_0.method_0, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).GetAwaiter().GetResult();
				bool flag2 = result.Wait(3000);
				num += smethod_243("select-hero/retries-empty-census/completes", flag2);
				if (flag2)
				{
					num += smethod_244("select-hero/retries-empty-census/name", "Hero77", (string)smethod_51(result));
					num += smethod_243("select-hero/retries-empty-census/current", smethod_50(result));
				}
				num += smethod_243("select-hero/retries-empty-census/attempts", class3.int_0 >= 2);
			}
			finally
			{
				if (class2.class339_0 != null)
				{
					((IDisposable)class2.class339_0).Dispose();
				}
			}
			Class240 class4 = new Class240();
			class4.class300_0 = @class;
			class4.class339_0 = new Class339();
			try
			{
				Class314 class5 = new Class314();
				class5.class240_0 = class4;
				class5.int_0 = 0;
				class5.class240_0.class339_0.class119_0.method_30(class5.method_0);
				Task result2 = Task.Factory.StartNew((Func<Task>)class5.class240_0.method_0, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).GetAwaiter().GetResult();
				bool flag3 = result2.Wait(1000);
				num += smethod_243("select-hero/ready-cleared/completes", flag3);
				num += smethod_244("select-hero/ready-cleared/attempts", 1, class5.int_0);
				if (flag3)
				{
					num += smethod_244("select-hero/ready-cleared/name", null, (string)smethod_51(result2));
				}
			}
			finally
			{
				if (class4.class339_0 != null)
				{
					((IDisposable)class4.class339_0).Dispose();
				}
			}
			Class234 class6 = new Class234();
			class6.class300_0 = @class;
			class6.class339_0 = new Class339();
			try
			{
				Class274 class7 = new Class274();
				class7.class234_0 = class6;
				class7.int_0 = 0;
				class7.class234_0.class339_0.class119_0.method_30(class7.method_0);
				Task result3 = Task.Factory.StartNew((Func<Task>)class7.class234_0.method_0, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).GetAwaiter().GetResult();
				bool flag4 = result3.Wait(1000);
				num += smethod_243("select-hero/ready-cleared-with-name/completes", flag4);
				num += smethod_244("select-hero/ready-cleared-with-name/attempts", 1, class7.int_0);
				if (flag4)
				{
					num += smethod_243("select-hero/ready-cleared-with-name/not-current", !smethod_50(result3));
					num += smethod_244("select-hero/ready-cleared-with-name/rejected", null, (string)smethod_51(result3));
				}
			}
			finally
			{
				if (class6.class339_0 != null)
				{
					((IDisposable)class6.class339_0).Dispose();
				}
			}
			Class335 class8 = new Class335();
			class8.class300_0 = @class;
			class8.class339_0 = new Class339();
			try
			{
				Class214 class9 = new Class214();
				class9.class335_0 = class8;
				class9.class119_0 = new Class119();
				try
				{
					class9.int_0 = 0;
					class9.class335_0.class339_0.class119_0.method_30(class9.method_0);
					Task result4 = Task.Factory.StartNew((Func<Task>)class9.class335_0.method_0, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).GetAwaiter().GetResult();
					bool flag5 = result4.Wait(1000);
					num += smethod_243("select-hero/generation-change/completes", flag5);
					num += smethod_244("select-hero/generation-change/attempts", 1, class9.int_0);
					if (flag5)
					{
						num += smethod_243("select-hero/generation-change/stale", !smethod_50(result4));
					}
				}
				finally
				{
					if (class9.class119_0 != null)
					{
						((IDisposable)class9.class119_0).Dispose();
					}
				}
			}
			finally
			{
				if (class8.class339_0 != null)
				{
					((IDisposable)class8.class339_0).Dispose();
				}
			}
			Class294 class10 = new Class294();
			class10.class300_0 = @class;
			class10.class339_0 = new Class339();
			try
			{
				class10.class339_0.class119_0.method_30(class10.method_0);
				class10.class339_0.gform0_0.func_0 = class10.method_1;
				Task result5 = Task.Factory.StartNew((Func<Task>)class10.method_2, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).GetAwaiter().GetResult();
				bool flag6 = result5.Wait(1000);
				num += smethod_243("select-hero/post-await-ready-cleared/completes", flag6);
				if (flag6)
				{
					num += smethod_244("select-hero/post-await-ready-cleared/name", "Hero77", (string)smethod_51(result5));
					flag = !smethod_50(result5);
					num += smethod_243("select-hero/post-await-ready-cleared/not-current", flag);
				}
			}
			finally
			{
				if (class10.class339_0 != null)
				{
					((IDisposable)class10.class339_0).Dispose();
				}
			}
			if (methodInfo2 != null && flag)
			{
				Class259 class11 = new Class259();
				class11.class339_0 = new Class339();
				try
				{
					Class321 class12 = new Class321();
					class12.class259_0 = class11;
					smethod_94(class12.class259_0.class339_0.gform0_0, "_settings", new Class11("SelectHeroTest.ini"));
					smethod_94(class12.class259_0.class339_0.gform0_0, "_grids", new Class67());
					class12.list_0 = new List<string>();
					class12.class259_0.class339_0.class119_0.method_30(class12.method_0);
					class12.class259_0.class339_0.gform0_0.func_0 = class12.class259_0.method_0;
					Task<bool> task = (Task<bool>)methodInfo2.Invoke(class12.class259_0.class339_0.gform0_0, new object[2]
					{
						class12.class259_0.class339_0.class119_0,
						class12.class259_0.class339_0.long_0
					});
					bool flag7 = smethod_96(task);
					num += smethod_243("select-hero/post-await-ready-cleared/select-completes", flag7);
					if (flag7)
					{
						num += smethod_243("select-hero/post-await-ready-cleared/select-rejected", !task.GetAwaiter().GetResult());
						num += smethod_244("select-hero/post-await-ready-cleared/no-settings", null, ((Class11)smethod_95(class12.class259_0.class339_0.gform0_0, "_settings")).method_0());
						num += smethod_244("select-hero/post-await-ready-cleared/no-grids", null, ((Class67)smethod_95(class12.class259_0.class339_0.gform0_0, "_grids")).method_1());
						num += smethod_243("select-hero/post-await-ready-cleared/no-hook", !class12.list_0.Any(Class299.class299_0.method_19));
						num += smethod_243("select-hero/post-await-ready-cleared/no-readout", smethod_95(class12.class259_0.class339_0.gform0_0, "_readout") == null);
						num += smethod_243("select-hero/post-await-ready-cleared/no-stream", !class12.class259_0.class339_0.class119_0.method_28() && !class12.list_0.Any(Class299.class299_0.method_20));
					}
				}
				finally
				{
					if (class11.class339_0 != null)
					{
						((IDisposable)class11.class339_0).Dispose();
					}
				}
			}
		}
		if (methodInfo != null)
		{
			Class200 class13 = new Class200();
			class13.class339_0 = new Class339();
			try
			{
				class13.int_0 = 0;
				class13.class339_0.class119_0.method_30(class13.method_0);
				Stopwatch stopwatch = Stopwatch.StartNew();
				string gparam_ = (string)methodInfo.Invoke(class13.class339_0.gform0_0, new object[3]
				{
					class13.class339_0.class119_0,
					class13.class339_0.long_0,
					180
				});
				stopwatch.Stop();
				num += smethod_244("select-hero/timeout/name", null, gparam_);
				num += smethod_243("select-hero/timeout/retries", class13.int_0 >= 2);
				num += smethod_243("select-hero/timeout/bounded", stopwatch.ElapsedMilliseconds >= 100L && stopwatch.ElapsedMilliseconds < 750L);
			}
			finally
			{
				if (class13.class339_0 != null)
				{
					((IDisposable)class13.class339_0).Dispose();
				}
			}
		}
		string text = smethod_173("Shared\\Agent\\runtime.ts", ref num);
		if (text != null)
		{
			string text2 = smethod_80(text, "const gaeaId =", "// PartyId is what the buff decision filters on first");
			num += smethod_243("select-hero/agent/empty-name-not-cached", text2 != null && smethod_81(text2, new string[4] { "const playerName = readString(u, o.unitName);", "if (playerName.length > 0)", "knownPlayerNames[gaeaId] = true;", "pnames[gaeaId] = playerName;" }));
		}
		string text3 = smethod_174(ref num);
		if (text3 != null)
		{
			num += smethod_243("select-hero/embedded/empty-name-not-cached", text3.Contains("const playerName = readString(u, o.unitName);") && text3.Contains("pnames[gaeaId] = playerName;"));
		}
		Console.WriteLine("select-hero: " + num + " failed");
		return num;
	}

	public static int smethod_48()
	{
		int num = 0;
		num = 0 + smethod_49("Run");
		num += smethod_49("Attach");
		num += smethod_49("Census");
		string text = smethod_173("Capybara-UI-Winform\\Ui\\ProcessButton.cs", ref num);
		string text2 = smethod_173("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", ref num);
		string text3 = smethod_173("Capybara-UI-Winform\\Form1.cs", ref num);
		if (text != null)
		{
			num += smethod_243("session-lifecycle/source/no-shared-session-in-transport", !text.Contains("Task.Run(() => _session.") && !text.Contains("_session.Census") && text.Contains("RunSessionTransportAsync(") && text.Contains("AttachSessionTransportAsync(") && text.Contains("CensusSessionTransportAsync(") && smethod_160(text, "StartSessionOperation(\"Run\"") == 1 && smethod_160(text, "StartSessionOperation(\"Attach\"") == 1 && smethod_160(text, "StartSessionOperation(\"Census\"") == 1 && smethod_160(text, "IsSessionOperationCurrent(") >= 3);
		}
		if (text2 != null)
		{
			string text4 = smethod_80(text2, "private async Task CleanupForCloseAsync()", "private static void LogAutomaticStop");
			num += smethod_243("session-lifecycle/source/drain-before-dispose", text4 != null && smethod_81(text4, new string[5] { "BeginSessionClose()", "await CaptureTaskFaultAsync(operations[i])", "session.OnDetached -= Session_Detached", "session.StopStreaming", "session.Dispose" }));
		}
		if (text3 != null)
		{
			string text5 = smethod_80(text3, "private async void button1_Click(object sender, EventArgs e)", "private async void button2_Click(object sender, EventArgs e)");
			string text6 = smethod_80(text3, "private async void button2_Click(object sender, EventArgs e)", "private void button3_Click(object sender, EventArgs e)");
			string text7 = smethod_80(text3, "private async void button17_Click(object sender, EventArgs e)", "private void button18_Click(object sender, EventArgs e)");
			string text8 = smethod_80(text3, "private async void button8_Click(object sender, EventArgs e)", "private void button10_Click(object sender, EventArgs e)");
			num += smethod_243("session-lifecycle/source/async-void-button-faults-contained", text5 != null && text6 != null && text7 != null && text8 != null && text5.Contains("try { await Prepare_Start(true); }") && text5.Contains("catch (Exception ex)") && text6.Contains("try { await Stop_Button(false); }") && text6.Contains("catch (Exception ex)") && text7.Contains("try { await Run_Button(); }") && text7.Contains("catch (Exception ex)") && text8.Contains("catch (Exception ex)"));
		}
		Console.WriteLine("session-lifecycle: " + num + " failed");
		return num;
	}

	private static int smethod_49(string string_0)
	{
		Class254 @class = new Class254();
		@class.string_0 = string_0;
		int num = 0;
		@class.gform0_0 = new GForm0();
		@class.class119_0 = new Class119();
		@class.manualResetEventSlim_0 = new ManualResetEventSlim(initialState: false);
		@class.manualResetEventSlim_1 = new ManualResetEventSlim(initialState: false);
		@class.int_2 = 0;
		int num2 = 0;
		@class.int_1 = 0;
		@class.int_0 = 0;
		try
		{
			Class312 class2 = new Class312();
			class2.class254_0 = @class;
			MethodInfo methodInfo = typeof(GForm0).GetMethod("method_8", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			string name = ((class2.class254_0.string_0 == "Run") ? "RunSessionTransportAsync" : ((class2.class254_0.string_0 == "Attach") ? "AttachSessionTransportAsync" : "CensusSessionTransportAsync"));
			class2.methodInfo_0 = typeof(GForm0).GetMethod(name, BindingFlags.Instance | BindingFlags.NonPublic);
			class2.methodInfo_1 = typeof(GForm0).GetMethod("method_52", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			FieldInfo field = typeof(GForm0).GetField("SessionTransportForTest", BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field2 = typeof(GForm0).GetField("SessionDisposeForTest", BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field3 = typeof(GForm0).GetField("_sessionOperations", BindingFlags.Instance | BindingFlags.NonPublic);
			num += smethod_243("session-lifecycle/" + class2.class254_0.string_0 + "/contract", methodInfo != null && class2.methodInfo_0 != null && class2.methodInfo_1 != null && field != null && field2 != null && field3 != null);
			if (num != 0)
			{
				return num;
			}
			methodInfo.Invoke(class2.class254_0.gform0_0, new object[1] { class2.class254_0.class119_0 });
			field.SetValue(class2.class254_0.gform0_0, new Func<string, Class119, Func<object>, object>(class2.class254_0.method_0));
			field2.SetValue(class2.class254_0.gform0_0, new Action<Class119>(class2.class254_0.method_1));
			MethodInfo methodInfo2 = typeof(GForm0).GetMethod("method_9", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			object[] array = new object[2] { null, 0L };
			bool flag = (bool)methodInfo2.Invoke(class2.class254_0.gform0_0, array);
			Class119 class3 = (Class119)array[0];
			long num3 = (long)array[1];
			num += smethod_243("session-lifecycle/" + class2.class254_0.string_0 + "/capture", flag && class3 == class2.class254_0.class119_0);
			class2.object_0 = ((!(class2.class254_0.string_0 == "Census")) ? new object[5]
			{
				class2.class254_0.class119_0,
				num3,
				"adb.exe",
				"emulator-1",
				27043
			} : new object[2]
			{
				class2.class254_0.class119_0,
				num3
			});
			Task result = Task.Factory.StartNew((Func<Task>)class2.method_0, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).GetAwaiter().GetResult();
			num += smethod_243("session-lifecycle/" + class2.class254_0.string_0 + "/entered", result != null && class2.class254_0.manualResetEventSlim_0.Wait(2000));
			Task task = Task.Run((Func<Task>)class2.method_1);
			num += smethod_243("session-lifecycle/" + class2.class254_0.string_0 + "/close-waits", !task.Wait(100) && class2.class254_0.int_2 == 0 && class2.class254_0.gform0_0.method_7() == null);
			Task result2 = Task.Factory.StartNew((Func<Task>)class2.method_2, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).GetAwaiter().GetResult();
			result2.Wait(1000);
			num += smethod_243("session-lifecycle/" + class2.class254_0.string_0 + "/reject-after-close", result2.IsCompleted && !smethod_50(result2) && class2.class254_0.int_0 == 1);
			class2.class254_0.manualResetEventSlim_1.Set();
			num += smethod_243("session-lifecycle/" + class2.class254_0.string_0 + "/drained", Task.WhenAll(task, result).Wait(3000));
			if (smethod_50(result))
			{
				num2++;
			}
			object value = field3.GetValue(class2.class254_0.gform0_0);
			int gparam_ = (int)value.GetType().GetProperty("Count").GetValue(value, null);
			num += smethod_244("session-lifecycle/" + class2.class254_0.string_0 + "/dispose-exact", 1, class2.class254_0.int_2);
			num += smethod_244("session-lifecycle/" + class2.class254_0.string_0 + "/captured-session", 0, class2.class254_0.int_1);
			num += smethod_244("session-lifecycle/" + class2.class254_0.string_0 + "/stale-ui", 0, num2);
			num += smethod_244("session-lifecycle/" + class2.class254_0.string_0 + "/typed-result", (class2.class254_0.string_0 == "Census") ? "TestHero" : ((object)true), smethod_51(result));
			num += smethod_244("session-lifecycle/" + class2.class254_0.string_0 + "/task-cleanup", 0, gparam_);
		}
		catch (Exception ex)
		{
			Console.WriteLine("FAIL  session-lifecycle/" + @class.string_0 + "/exception " + ex.GetBaseException().GetType().Name + ": " + ex.GetBaseException().Message);
			num++;
		}
		finally
		{
			@class.manualResetEventSlim_1.Set();
			@class.class119_0.Dispose();
			@class.gform0_0.Dispose();
			@class.manualResetEventSlim_0.Dispose();
			@class.manualResetEventSlim_1.Dispose();
		}
		return num;
	}

	private static bool smethod_50(Task task_0)
	{
		PropertyInfo property = task_0.GetType().GetProperty("Result");
		object obj = ((property == null) ? null : property.GetValue(task_0, null));
		if (obj == null)
		{
			return false;
		}
		PropertyInfo property2 = obj.GetType().GetProperty("Current", BindingFlags.Instance | BindingFlags.NonPublic);
		if (property2 != null)
		{
			return (bool)property2.GetValue(obj, null);
		}
		return false;
	}

	private static object smethod_51(Task task_0)
	{
		PropertyInfo property = task_0.GetType().GetProperty("Result");
		object obj = ((property == null) ? null : property.GetValue(task_0, null));
		if (obj == null)
		{
			return null;
		}
		PropertyInfo property2 = obj.GetType().GetProperty("Value", BindingFlags.Instance | BindingFlags.NonPublic);
		if (!(property2 == null))
		{
			return property2.GetValue(obj, null);
		}
		return null;
	}

	public static int smethod_52()
	{
		Class232 @class = new Class232();
		int num = 0;
		string[] array = new string[17]
		{
			string.Empty,
			" ",
			"\t",
			"emulator 5556",
			"\"emulator-5556\"",
			"'emulator-5556'",
			"emulator-5556;id",
			"emulator-5556&id",
			"emulator-5556|id",
			"emulator-5556>file",
			"emulator-5556<file",
			"`id`",
			"$(id)",
			"serial\rnext",
			"serial\nnext",
			"-s",
			"--help"
		};
		for (int i = 0; i < array.Length; i++)
		{
			num += smethod_243("runner/serial-rejects-unsafe-" + i, !Class71.smethod_2(array[i]));
		}
		string[] array2 = new string[4] { "emulator-5556", "127.0.0.1:5555", "R58M1234ABC", "device._:123-ABC" };
		for (int j = 0; j < array2.Length; j++)
		{
			num += smethod_243("runner/serial-accepts-safe-" + j, Class71.smethod_2(array2[j]));
		}
		Class71.Class72 class2 = Class71.smethod_1("adb-path-must-not-be-opened", "bad;serial", "get-state", 1);
		num += smethod_243("runner/unsafe-serial-central-rejection-is-not-started", !class2.bool_0 && class2.string_2 == "adb serial contains unsafe characters");
		@class.int_0 = 0;
		string[] array3 = array;
		foreach (string string_ in array3)
		{
			int gparam_ = smethod_54("adb", string_, @class.method_0, Class299.class299_0.method_21, Class299.class299_0.method_22);
			num += smethod_244("runner/unsafe-serial-exit", 1, gparam_);
		}
		num += smethod_244("runner/unsafe-serial-launch-count", 0, @class.int_0);
		num += smethod_244("runner/pidfile-probe-exact-shell", "shell su 0 sh -c 'if [ -e /data/local/tmp/.klxsvc.pid ]; then pid=$(cat /data/local/tmp/.klxsvc.pid) || { echo KLX_PIDFILE_READ_FAILED >&2; exit 7; }; echo KLX_PIDFILE_PRESENT:$pid; else echo KLX_PIDFILE_MISSING; fi'", Class119.smethod_6());
		num += smethod_243("runner/pidfile-missing-marker-is-explicit", Class119.smethod_7(Class71.Class72.smethod_0("KLX_PIDFILE_MISSING"), out var int_, out var string_2) && int_ == 0);
		num += smethod_243("runner/pidfile-syntax-stderr-rejects-missing-marker", !Class119.smethod_7(new Class71.Class72("KLX_PIDFILE_MISSING", "sh: syntax error", bool_2: true, bool_3: false, 0), out int_, out string_2) && string_2.Contains("syntax error"));
		@class.func_0 = Class299.class299_0.method_23;
		num += smethod_243("runner/stat-parses-comm-parentheses", Class195.smethod_4(@class.func_0(4512, 98765uL), 4512, out var ulong_) && ulong_ == 98765L);
		string gparam_2 = Class119.smethod_13(new Class45(4512, 98765uL), bool_17: false, bool_18: true);
		num += smethod_244("runner/signal-shell-exact-dry-run", "shell su 0 sh -c 'pid=4512; expected=98765; if [ ! -e /proc/$pid/exe ] || [ ! -r /proc/$pid/stat ]; then echo KLX_SIGNAL_GONE; exit 0; fi; exe=$(readlink /proc/$pid/exe) || { echo KLX_SIGNAL_PROBE_FAILED >&2; exit 8; }; stat=$(cat /proc/$pid/stat) || { echo KLX_SIGNAL_PROBE_FAILED >&2; exit 8; }; tail=${stat##*) }; set -- $tail; if [ $# -lt 20 ]; then echo KLX_SIGNAL_PROBE_FAILED >&2; exit 8; fi; shift 19; start=$1; if [ \"$exe\" != \"/data/local/tmp/.klxsvc\" ] || [ \"$start\" != \"$expected\" ]; then echo KLX_SIGNAL_MISMATCH; exit 0; fi; echo KLX_SIGNAL_MATCH'", gparam_2);
		Class380 class380_ = new Class380
		{
			bool_0 = false,
			bool_1 = true,
			bool_2 = true,
			bool_3 = true,
			string_2 = "pidfile: timed out"
		};
		num += smethod_244("runner/probe-timeout-is-unknown", Enum1.Unknown, Class195.smethod_0(class380_, 27060).enum1_0);
		Class380 class3 = new Class380();
		class3.int_0 = 4512;
		class3.bool_0 = true;
		class3.bool_1 = true;
		class3.string_0 = "0: 0100007F:69B4 00000000:0000 0A 00000000:00000000 00:00000000 00000000 0 0 22018 1 0000000000000000";
		class3.bool_2 = true;
		class3.bool_3 = true;
		class3.ireadOnlyList_0 = new Class133[1]
		{
			new Class133(4512, "/data/local/tmp/.klxsvc\0--port\027060\0", @class.func_0(4512, 100uL), "lrwx------ 4 -> socket:[22018]")
		};
		Class380 class4 = class3;
		num += smethod_244("runner/current-pid-and-listener-are-ready", Enum1.Healthy, Class195.smethod_0(class4, 27060).enum1_0);
		class4.bool_3 = false;
		class4.string_2 = "tcp6: permission denied";
		num += smethod_244("runner/healthy-looking-partial-probe-is-unknown", Enum1.Unknown, Class195.smethod_0(class4, 27060).enum1_0);
		class4.bool_3 = true;
		class4.string_2 = null;
		class3 = new Class380();
		class3.int_0 = 3776;
		class3.bool_0 = true;
		class3.bool_1 = true;
		class3.bool_2 = true;
		class3.bool_3 = true;
		class3.ireadOnlyList_0 = new Class133[1]
		{
			new Class133(4512, "/data/local/tmp/.klxsvc\0--port\027060\0", @class.func_0(4512, 100uL), string.Empty)
		};
		Class380 class380_2 = class3;
		num += smethod_244("runner/stuck-process-is-confirmed-unhealthy", Enum1.Unhealthy, Class195.smethod_0(class380_2, 27060).enum1_0);
		num += smethod_244("runner/stuck-process-has-stable-identity", 4512, Class195.smethod_1(class380_2).Single().int_0);
		class3 = new Class380();
		class3.bool_0 = true;
		class3.bool_1 = true;
		class3.bool_2 = true;
		class3.bool_3 = true;
		class3.ireadOnlyList_0 = new Class133[1]
		{
			new Class133(4512, "/data/local/tmp/.klxsvc\0--port\027060\0", @class.func_0(4512, 100uL), string.Empty, bool_3: true, bool_4: true, bool_5: false, "fd: permission denied")
		};
		Class380 class380_3 = class3;
		num += smethod_244("runner/fd-permission-failure-is-unknown", Enum1.Unknown, Class195.smethod_0(class380_3, 27060).enum1_0);
		num += smethod_243("runner/forward-exact-match", Class119.smethod_11("emulator-5556 tcp:27043 tcp:27060", "emulator-5556", 27043, 27060));
		num += smethod_243("runner/forward-rejects-other-device", !Class119.smethod_11("emulator-5554 tcp:27043 tcp:27060", "emulator-5556", 27043, 27060));
		num += smethod_243("runner/forward-rejects-other-port", !Class119.smethod_11("emulator-5556 tcp:27043 tcp:27042", "emulator-5556", 27043, 27060));
		@class.list_0 = new List<string>();
		Class414 class414_ = new Class414
		{
			func_0 = Class299.class299_0.method_24,
			func_1 = @class.method_1,
			func_2 = @class.method_2,
			func_3 = @class.method_3,
			func_4 = @class.method_4
		};
		Class3 class5 = Class142.smethod_0("attach failed: Connection closed", bool_0: true, class414_);
		num += smethod_243("runner/recovery-retries-exactly-once", class5.bool_0 && class5.string_0 == null && string.Join(",", @class.list_0) == "runner,forward:27060,pid,attach");
		@class.int_1 = 0;
		Enum1[] array4 = new Enum1[2]
		{
			Enum1.Healthy,
			Enum1.Unknown
		};
		for (int k = 0; k < array4.Length; k++)
		{
			Class272 class6 = new Class272();
			class6.enum1_0 = array4[k];
			Class3 class7 = Class142.smethod_0("attach failed: Connection closed", bool_0: true, new Class414
			{
				func_0 = class6.method_0,
				func_1 = @class.method_5
			});
			num += smethod_243("runner/recovery-skips-" + class6.enum1_0.ToString().ToLowerInvariant(), !class7.bool_0);
		}
		Class3 class8 = Class142.smethod_0("attach failed: process not found", bool_0: true, new Class414
		{
			func_0 = Class299.class299_0.method_25,
			func_1 = @class.method_6
		});
		num += smethod_243("runner/recovery-skips-unrelated-error", !class8.bool_0);
		num += smethod_244("runner/skipped-recovery-does-not-mutate", 0, @class.int_1);
		@class.list_1 = new List<string>();
		Class3 class9 = Class142.smethod_0("attach failed: Connection closed", bool_0: true, new Class414
		{
			func_0 = Class299.class299_0.method_26,
			func_1 = @class.method_7,
			func_2 = @class.method_8,
			func_3 = @class.method_9,
			func_4 = @class.method_10
		});
		num += smethod_243("runner/recovery-pid-mismatch-aborts-attach", class9.bool_0 && class9.string_0.Contains("game pid changed") && string.Join(",", @class.list_1) == "runner,forward,pid");
		@class.list_2 = new List<string>();
		@class.bool_1 = true;
		@class.bool_0 = true;
		Class119 class10 = new Class119();
		try
		{
			class10.method_32(Class299.class299_0.method_27);
			class10.method_31(@class.method_11);
			num += smethod_244("runner/safe-stop-result", null, class10.method_194("adb", "serial"));
		}
		finally
		{
			((IDisposable)class10).Dispose();
		}
		num += smethod_243("runner/safe-stop-kills-verified-process", @class.list_2.Any(Class299.class299_0.method_28));
		num += smethod_243("runner/safe-stop-never-kills-stale-pid", !@class.list_2.Any(Class299.class299_0.method_29));
		num += smethod_243("runner/safe-stop-cleans-pidfile", @class.list_2.Contains("shell su 0 rm -f /data/local/tmp/.klxsvc.pid"));
		@class.list_3 = new List<string>();
		@class.int_2 = 0;
		@class.bool_2 = false;
		Class119 class11 = new Class119();
		try
		{
			class11.method_32(Class299.class299_0.method_30);
			class11.method_31(@class.method_12);
			num += smethod_244("runner/pid-reuse-stop-result", null, class11.method_194("adb", "serial"));
		}
		finally
		{
			((IDisposable)class11).Dispose();
		}
		num += smethod_243("runner/pid-reuse-race-emits-no-signal", !@class.bool_2 && @class.list_3.Any(Class299.class299_0.method_31));
		@class.list_4 = new List<string>();
		Class119 class12 = new Class119();
		try
		{
			class12.method_32(Class299.class299_0.method_32);
			class12.method_31(@class.method_13);
			num += smethod_243("runner/unknown-health-fails-actionably", class12.method_192("adb", "serial", out var _)?.Contains("could not be verified") ?? false);
		}
		finally
		{
			((IDisposable)class12).Dispose();
		}
		num += smethod_243("runner/unknown-health-never-recovers-destructively", !@class.list_4.Any(Class299.class299_0.method_33));
		@class.list_5 = new List<string>();
		Class119 class13 = new Class119();
		try
		{
			class13.method_32(Class299.class299_0.method_34);
			class13.method_31(@class.method_14);
			num += smethod_243("runner/stderr-with-zero-exit-is-unknown", class13.method_192("adb", "serial", out var _)?.Contains("could not be verified") ?? false);
		}
		finally
		{
			((IDisposable)class13).Dispose();
		}
		num += smethod_243("runner/stderr-with-zero-exit-never-recovers", !@class.list_5.Any(Class299.class299_0.method_35));
		@class.list_6 = new List<string>();
		Class119 class14 = new Class119();
		try
		{
			class14.method_33(Class299.class299_0.method_36);
			class14.method_31(@class.method_15);
			num += smethod_244("runner/verified-adoption-result", null, class14.method_192("adb", "serial", out var int_4));
			num += smethod_244("runner/verified-adoption-port", 27060, int_4);
		}
		finally
		{
			((IDisposable)class14).Dispose();
		}
		num += smethod_243("runner/verified-adoption-does-not-mutate-runner", !@class.list_6.Any(Class299.class299_0.method_37));
		@class.int_3 = 3776;
		@class.list_7 = new List<string>();
		Class119 class15 = new Class119();
		try
		{
			class15.method_33(Class299.class299_0.method_38);
			class15.method_31(@class.method_16);
			num += smethod_244("runner/stale-pidfile-repair-result", null, class15.method_192("adb", "serial", out var _));
		}
		finally
		{
			((IDisposable)class15).Dispose();
		}
		num += smethod_243("runner/stale-pidfile-repairs-without-restart", @class.list_7.Any(Class299.class299_0.method_39) && !@class.list_7.Any(Class299.class299_0.method_40));
		Class327 class16 = new Class327(new IntPtr(11), new IntPtr(12));
		class16.int_0 = 0;
		Class333 class17 = new Class333();
		class17.class119_0 = new Class119();
		try
		{
			class17.class119_0.method_34(class16);
			class17.class119_0.method_35(Class299.class299_0.method_41);
			class17.class119_0.method_46(5046u);
			Class3 class18 = Class142.smethod_0(class17.class119_0.method_78(27043), bool_0: true, new Class414
			{
				func_0 = Class299.class299_0.method_42,
				func_1 = Class299.class299_0.method_43,
				func_2 = Class299.class299_0.method_44,
				func_3 = Class299.class299_0.method_45,
				func_4 = class17.method_0
			});
			num += smethod_243("runner/both-failed-native-handles-are-closed", class18.bool_0 && class18.string_0 != null && class16.list_0.SequenceEqual(new IntPtr[2]
			{
				new IntPtr(11),
				new IntPtr(12)
			}) && class17.class119_0.method_47() == IntPtr.Zero);
		}
		finally
		{
			if (class17.class119_0 != null)
			{
				((IDisposable)class17.class119_0).Dispose();
			}
		}
		Class327 interface2_ = new Class327(new IntPtr(21));
		Class119 class19 = new Class119();
		try
		{
			class19.method_34(interface2_);
			class19.method_35(Class299.class299_0.method_46);
			class19.method_46(5046u);
			num += smethod_244("runner/native-success-result", null, class19.method_78(27043));
			num += smethod_244("runner/native-success-publishes-handle", new IntPtr(21), class19.method_47());
		}
		finally
		{
			((IDisposable)class19).Dispose();
		}
		@class.class327_0 = new Class327(new IntPtr(25));
		Class119 class20 = new Class119();
		try
		{
			class20.method_34(@class.class327_0);
			class20.method_35(Class299.class299_0.method_47);
			class20.method_40(@class.method_17);
			class20.method_46(5046u);
			string text = class20.method_78(27043);
			num += smethod_243("runner/detach-before-publication-loses-race", text != null && text.Contains("detached during startup") && class20.method_47() == IntPtr.Zero && @class.class327_0.list_0.SequenceEqual(new IntPtr[1]
			{
				new IntPtr(25)
			}));
		}
		finally
		{
			((IDisposable)class20).Dispose();
		}
		Class327 class21 = new Class327(new IntPtr(26), new IntPtr(27));
		class21.int_0 = 0;
		Class119 class22 = new Class119();
		try
		{
			class22.method_34(class21);
			class22.method_35(Class299.class299_0.method_48);
			class22.method_48(50);
			class22.method_46(5046u);
			class21.bool_0 = true;
			string text2 = class22.method_78(27043);
			num += smethod_243("runner/timed-out-close-was-started", text2 != null && class21.manualResetEventSlim_0.IsSet);
			string text3 = class22.method_78(27043);
			num += smethod_243("runner/pending-close-blocks-next-open", text3 != null && text3.Contains("still closing") && class21.int_1 == 1);
			class21.bool_0 = false;
			class21.manualResetEventSlim_1.Set();
			for (int l = 0; l < 100; l++)
			{
				if (!class22.method_49())
				{
					break;
				}
				Thread.Sleep(5);
			}
			num += smethod_243("runner/pending-close-eventually-completes", !class22.method_49());
		}
		finally
		{
			((IDisposable)class22).Dispose();
		}
		@class.class327_1 = new Class327(new IntPtr(29));
		Class119 class23 = new Class119();
		try
		{
			Class212 class24 = new Class212();
			class24.manualResetEventSlim_0 = new ManualResetEventSlim(initialState: false);
			class24.manualResetEventSlim_1 = new ManualResetEventSlim(initialState: false);
			class23.method_34(@class.class327_1);
			class23.method_35(Class299.class299_0.method_49);
			class23.method_48(500);
			class23.method_42(class24.method_0);
			class23.method_46(5046u);
			class23.method_78(27043);
			Thread thread = new Thread(@class.method_18);
			@class.class327_1.thread_0 = thread;
			thread.Start();
			num += smethod_243("runner/callback-reaches-ack-before-close", class24.manualResetEventSlim_0.Wait(1000));
			Thread thread2 = new Thread(class23.method_210);
			thread2.Start();
			num += smethod_243("runner/native-close-waits-for-inflight-callback", @class.class327_1.manualResetEventSlim_2.Wait(1000));
			class24.manualResetEventSlim_1.Set();
			num += smethod_243("runner/callback-ack-cannot-deadlock-close", !@class.class327_1.bool_1 && thread.Join(1000) && thread2.Join(1000) && !class23.method_49());
			num += smethod_244("runner/callback-ack-is-dropped-during-close", 1, @class.class327_1.int_2);
		}
		finally
		{
			((IDisposable)class23).Dispose();
		}
		@class.class327_2 = new Class327(new IntPtr(30));
		Class292 class25 = new Class292();
		class25.class119_0 = new Class119();
		try
		{
			Class252 class26 = new Class252();
			class25.class119_0.method_34(@class.class327_2);
			class25.class119_0.method_35(Class299.class299_0.method_50);
			class25.class119_0.method_46(5046u);
			class25.class119_0.method_78(27043);
			class26.manualResetEventSlim_0 = new ManualResetEventSlim(initialState: false);
			class26.manualResetEventSlim_1 = new ManualResetEventSlim(initialState: false);
			class26.int_0 = 0;
			class25.class119_0.method_30(class26.method_0);
			Thread thread3 = new Thread(class25.method_0);
			thread3.Start();
			num += smethod_243("runner/ordinary-post-holds-ack-gate", class26.manualResetEventSlim_0.Wait(1000));
			Thread thread4 = new Thread(@class.method_19);
			thread4.Start();
			num += smethod_243("runner/busy-ack-callback-returns", thread4.Join(1000));
			class26.manualResetEventSlim_1.Set();
			num += smethod_243("runner/busy-ack-post-completes", thread3.Join(1000));
			num += smethod_243("runner/busy-ack-eventually-posted", SpinWait.SpinUntil(class26.method_1, 1000));
		}
		finally
		{
			if (class25.class119_0 != null)
			{
				((IDisposable)class25.class119_0).Dispose();
			}
		}
		Class327 class27 = new Class327(new IntPtr(31), new IntPtr(32));
		Class304 class28 = new Class304();
		class28.class119_0 = new Class119();
		try
		{
			class28.class119_0.method_34(class27);
			class28.class119_0.method_35(Class299.class299_0.method_51);
			class28.class119_0.method_46(5046u);
			class28.class119_0.method_78(27043);
			class27.bool_0 = true;
			Thread thread5 = new Thread(class28.class119_0.method_210);
			thread5.Start();
			num += smethod_243("runner/concurrent-close-entered", class27.manualResetEventSlim_0.Wait(2000));
			Thread thread6 = new Thread(class28.method_0);
			thread6.Start();
			Thread thread7 = new Thread(class28.method_1);
			thread7.Start();
			Thread.Sleep(100);
			num += smethod_244("runner/concurrent-attach-waits-for-close", 1, class27.int_1);
			num += smethod_244("runner/concurrent-post-waits-for-close", 1, class27.int_2);
			class27.manualResetEventSlim_1.Set();
			num += smethod_243("runner/concurrent-lifecycle-completes", thread5.Join(2000) && thread7.Join(2000) && thread6.Join(2000));
			num += smethod_244("runner/concurrent-attach-opens-after-close", 2, class27.int_1);
			num += smethod_244("runner/post-does-not-use-closed-handle", 1, class27.int_2);
			class27.bool_0 = false;
		}
		finally
		{
			if (class28.class119_0 != null)
			{
				((IDisposable)class28.class119_0).Dispose();
			}
		}
		Console.WriteLine("runner-health: " + num + " failed");
		return num;
	}

	public static int smethod_53(string string_0, string string_1)
	{
		return smethod_54(string_0, string_1, Class71.smethod_1, Console.WriteLine, Console.Error.WriteLine);
	}

	internal static int smethod_54(string string_0, string string_1, Func<string, string, string, int, Class71.Class72> func_0, Action<string> action_0, Action<string> action_1)
	{
		if (!string.IsNullOrWhiteSpace(string_0) && Class71.smethod_2(string_1))
		{
			Class71.Class72 @class = func_0(string_0, string_1, "get-state", 8000);
			smethod_56("device", @class, action_0);
			if (smethod_55(@class) && !(@class.string_1.Trim() != "device"))
			{
				Class71.Class72 class72_ = func_0(string_0, string_1, Class119.smethod_6(), 8000);
				smethod_56("pidfile", class72_, action_0);
				if (!Class119.smethod_7(class72_, out var int_, out var string_2))
				{
					action_1("FAIL  runner/live-pidfile  " + string_2);
					return 1;
				}
				Class71.Class72 class2 = func_0(string_0, string_1, "shell su 0 sh -c 'pidof .klxsvc || true'", 8000);
				smethod_56("process-list", class2, action_0);
				if (!smethod_55(class2))
				{
					action_1("FAIL  runner/live-process-list");
					return 1;
				}
				int[] array = class2.string_1.Split((char[])null, StringSplitOptions.RemoveEmptyEntries).Select(Class299.class299_0.method_52).Where(Class299.class299_0.method_53)
					.Distinct()
					.ToArray();
				int num = 0;
				while (true)
				{
					if (num < array.Length)
					{
						int num2 = array[num];
						Class71.Class72 class3 = func_0(string_0, string_1, "shell su 0 cat /proc/" + num2 + "/stat", 8000);
						if (smethod_55(class3) && Class195.smethod_4(class3.string_1, num2, out var ulong_))
						{
							string text = Class119.smethod_13(new Class45(num2, ulong_), bool_17: false, bool_18: true);
							if (text.Contains("kill $pid") || !text.EndsWith("echo KLX_SIGNAL_MATCH'", StringComparison.Ordinal))
							{
								break;
							}
							Class71.Class72 class4 = func_0(string_0, string_1, text, 8000);
							smethod_56("identity-" + num2, class4, action_0);
							if (smethod_55(class4) && class4.string_1.Trim() == "KLX_SIGNAL_MATCH")
							{
								action_0("PASS  runner/live-read-only  pid=" + num2 + " starttime=" + ulong_ + " pidfile=" + int_);
								return 0;
							}
						}
						num++;
						continue;
					}
					action_1("FAIL  runner/live-identity  no current runner matched executable and starttime");
					return 1;
				}
				action_1("FAIL  runner/live-dry-run-safety");
				return 1;
			}
			action_1("FAIL  runner/live-device");
			return 1;
		}
		action_1("FAIL  runner/live-arguments");
		return 1;
	}

	private static bool smethod_55(Class71.Class72 class72_0)
	{
		if (class72_0 != null && class72_0.method_0())
		{
			return string.IsNullOrWhiteSpace(class72_0.string_2);
		}
		return false;
	}

	private static void smethod_56(string string_0, Class71.Class72 class72_0, Action<string> action_0)
	{
		if (class72_0 == null)
		{
			action_0("LIVE  runner/" + string_0 + " result=null");
			return;
		}
		Func<string, string> func = Class299.class299_0.method_54;
		action_0("LIVE  runner/" + string_0 + " exit=" + class72_0.int_0 + " stdout=\"" + func(class72_0.string_1) + "\" stderr=\"" + func(class72_0.string_2) + "\"");
	}

	public static int smethod_57()
	{
		return smethod_67();
	}

	private static int smethod_58()
	{
		return 0;
	}

	private static int smethod_59()
	{
		int num = 0;
		InvalidOperationException ex = new InvalidOperationException("stop-fault-marker");
		Class8 @class = Class8.smethod_5(17L).method_12(Class8.smethod_4(17L)).method_12(Class8.smethod_3(17L))
			.method_12(Class8.smethod_2(17L, ex))
			.method_12(Class8.smethod_1(17L, 73))
			.method_12(Class8.smethod_0(17L));
		num = 0 + smethod_244("automatic/stop-request/generation", 17L, @class.method_0());
		num += smethod_243("automatic/stop-request/or-facts", @class.method_1() && @class.method_2() && @class.method_3() && @class.method_4() && @class.method_5() && @class.method_6());
		num += smethod_243("automatic/stop-request/preserves-fault", ex == @class.method_7());
		num += smethod_244("automatic/stop-request/preserves-detach", 73, @class.method_8());
		num += smethod_244("automatic/stop-request/close-precedence", (Enum2)4, @class.method_11());
		num += smethod_244("automatic/stop-request/detach-fault-precedence", (Enum2)3, Class8.smethod_5(17L).method_12(Class8.smethod_3(17L)).method_12(Class8.smethod_2(17L, ex))
			.method_11());
		num += smethod_244("automatic/stop-request/normal-self-precedence", (Enum2)2, Class8.smethod_5(17L).method_12(Class8.smethod_4(17L)).method_11());
		num += smethod_244("automatic/stop-request/restart-precedence", (Enum2)1, Class8.smethod_5(17L).method_11());
		num += smethod_243("automatic/stop-request/restart-only", Class8.smethod_5(17L).method_10());
		num += smethod_243("automatic/stop-request/promotion-cancels-restart", !Class8.smethod_5(17L).method_12(Class8.smethod_3(17L)).method_10());
		TaskCompletionSource<object> taskCompletionSource = new TaskCompletionSource<object>(TaskCreationOptions.RunContinuationsAsynchronously);
		Class148 class2 = new Class148(17L);
		class2.method_6(taskCompletionSource.Task);
		num += smethod_243("automatic/run/exact-worker", taskCompletionSource.Task == class2.method_1());
		bool bool_ = false;
		try
		{
			class2.method_6(taskCompletionSource.Task);
		}
		catch (InvalidOperationException)
		{
			bool_ = true;
		}
		num += smethod_243("automatic/run/duplicate-attach-rejected", bool_);
		num += smethod_243("automatic/run/external-marker", class2.method_8());
		num += smethod_243("automatic/run/external-visible", class2.method_4());
		bool bool_2 = class2.method_11((Enum5)1);
		bool bool_3 = !class2.method_7();
		num += smethod_243("automatic/run/first-exit-published", bool_2);
		num += smethod_243("automatic/run/later-exit-rejected", bool_3);
		num += smethod_243("automatic/run/sell-marker-visible", class2.method_3());
		num += smethod_244("automatic/run/first-exit-wins", (Enum5)1, class2.method_2());
		Exception ex3 = class2.method_12(ex);
		InvalidOperationException exception_ = new InvalidOperationException("later-fault-marker");
		num += smethod_243("automatic/run/canonical-fault-identity", ex == ex3 && ex3 == class2.method_12(exception_) && ex3 == class2.method_5());
		num += smethod_243("automatic/run/diagnostic-once-exact-identity", class2.method_14(17L, taskCompletionSource.Task, ex3));
		num += smethod_243("automatic/run/diagnostic-rejects-duplicate", !class2.method_14(17L, taskCompletionSource.Task, ex3));
		Class148 class3 = new Class148(18L);
		class3.method_6(Task.CompletedTask);
		Exception ex4 = class3.method_13();
		num += smethod_243("automatic/run/unexpected-fault-identity", ex4 == class3.method_13());
		string text = smethod_173("Capybara-UI-Winform\\Ui\\Bot\\AutomaticRunContext.cs", ref num);
		string text2 = smethod_173("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", ref num);
		string text3 = smethod_173("Capybara-UI-Winform\\Form1.cs", ref num);
		if (text != null)
		{
			num += smethod_243("automatic/run/atomic-markers", text.Contains("Interlocked.Exchange(ref _sellSelfStop, 1)") && text.Contains("Interlocked.Exchange(ref _externalStop, 1)") && text.Contains("Volatile.Read(ref _sellSelfStop)") && text.Contains("Volatile.Read(ref _externalStop)"));
			num += smethod_243("automatic/run/atomic-canonicalization", text.Contains("Interlocked.CompareExchange(ref _canonicalFault") && text.Contains("Interlocked.CompareExchange(ref _faultRecorded"));
			num += smethod_243("automatic/run/atomic-exit-publication", text.Contains("Interlocked.CompareExchange(") && text.Contains("ref _exitReason, (int)reason"));
		}
		if (text2 != null)
		{
			num += smethod_243("automatic/stop/source/coordinator", text2.Contains("private Task RequestStop(StopRequest request)") && text2.Contains("private async Task StopCoreAsync()") && text2.Contains("private async Task ObserveAutomaticRunAsync") && !text2.Contains("StopCompatibilityDriverAsync") && !text2.Contains("CompleteCompatibilityRunFromPassAsync"));
			num += smethod_243("automatic/stop/source/no-blocking-waits", text2.IndexOf(".Wait()", StringComparison.Ordinal) < 0 && text2.IndexOf(".Result", StringComparison.Ordinal) < 0 && text2.IndexOf("Task.WaitAll", StringComparison.Ordinal) < 0 && text2.IndexOf("Thread.Sleep", StringComparison.Ordinal) < 0);
			num += smethod_243("automatic/stop/source/no-empty-catch", text2.IndexOf("catch {", StringComparison.Ordinal) < 0 && text2.IndexOf("catch\r\n", StringComparison.Ordinal) < 0);
		}
		if (text3 != null)
		{
			num += smethod_243("automatic/stop/source/thin-button", text3.Contains("await Stop_Button(false);"));
			num += smethod_243("automatic/close/source/async-boundary", text3.Contains("e.Cancel = true;") && text3.Contains("StopRequest.ForClose") && text3.Contains("_closeCleanupComplete"));
		}
		return num;
	}

	private static Task smethod_60(GForm0 gform0_0)
	{
		Class224 obj = new Class224
		{
			gform0_0 = gform0_0
		};
		obj.gform0_0.bool_3 = false;
		obj.gform0_0.bool_4 = false;
		Class148 @class = new Class148(Interlocked.Increment(ref long_0));
		smethod_94(obj.gform0_0, "_activeAutomaticRun", @class);
		Task task = Task.Run((Func<Task>)obj.method_0);
		@class.method_6(task);
		smethod_94(obj.gform0_0, "_automaticTask", task);
		return task;
	}

	private static Exception smethod_61(Task task_0)
	{
		if (task_0.Exception != null)
		{
			return task_0.Exception.InnerException;
		}
		return null;
	}

	private static bool smethod_62(string string_0, string string_1, string string_2, string string_3, string string_4)
	{
		if (string_0 != null && string_1 != null && string_2 != null && string_3 != null && string_4 != null)
		{
			string text = smethod_80(string_0, "public static async Task<bool> Engage(Form1 form, uint targetId)", "public static void ClearTarget()");
			string string_5 = smethod_80(text, "if (noNormalAttack)", "bool newTarget");
			string string_6 = smethod_80(string_0, "bool newTarget", "public static void ClearTarget()");
			string text2 = smethod_80(string_3, "public static async Task<bool> TryCast(Form1 form, uint targetId)", "public static void Reset()");
			string text3 = smethod_80(string_0, "public static async Task<bool> Mode(Form1 form, float radius)", "public static async Task<bool> Engage(Form1 form, uint targetId)");
			string text4 = smethod_80(string_2, "public static async Task<List<uint>> SortMonsterIdsAsync(Form1 form)", "private static List<uint> CurrentMonsterIds(Form1 form)");
			string text5 = smethod_80(string_1, "public static async Task<bool> Mode_PinPoint(Form1 form, float radius,", "public static async Task<bool> Mode_FollowPos(Form1 form, float radius,");
			string text6 = smethod_80(string_1, "public static async Task<bool> Mode_Follow_Circle(Form1 form, float radius,", "public static async Task<bool> Mode_Random(Form1 form,");
			string text7 = smethod_80(string_1, "public static async Task<bool> Mode_Random(Form1 form,", "public static Task<bool> Mode_Heal(Form1 form, float radius)");
			string text8 = smethod_80(string_1, "public static Task<bool> Mode_Heal(Form1 form, float radius)", "public static async Task<bool> CheckHP_Target(Form1 form, uint targetId)");
			string text9 = smethod_80(string_1, "public static async Task<bool> CheckHP_Target(Form1 form, uint targetId)", "private static bool CheckHpScalars(");
			bool flag = string_0.Contains("public static Task ShowZoneAsync(Form1 form)") && string_0.Contains("public static async Task<bool> Mode(Form1 form, float radius)") && string_0.Contains("public static async Task<bool> Engage(Form1 form, uint targetId)") && string_0.Contains("private static EntityRow FindLiveMonster(Form1 form, uint targetId)") && string_0.Contains("public static void Reset()") && string_2.Contains("public static async Task<List<uint>> SortMonsterIdsAsync(Form1 form)") && string_1.Contains("public static async Task<bool> Mode_PinPoint(Form1 form, float radius,") && string_1.Contains("public static async Task<bool> Mode_Follow_Circle(Form1 form, float radius,") && string_1.Contains("public static async Task<bool> Mode_Random(Form1 form,") && string_1.Contains("public static Task<bool> Mode_Heal(Form1 form, float radius)") && string_1.Contains("public static async Task<bool> CheckHP_Target(Form1 form, uint targetId)") && string_3.Contains("public static async Task<bool> TryCast(Form1 form, uint targetId)") && string_3.Contains("public static void Reset()") && !string_0.Contains("Mode(KlxSession s, WorldState w, SelfState self") && !string_0.Contains("Engage(KlxSession s, SelfState self, EntityRow target") && !string_3.Contains("TryCast(KlxSession s, SelfState self");
			bool flag2 = text != null && text2 != null && text3 != null && text4 != null && text5 != null && text6 != null && text7 != null && text8 != null && text9 != null && text.IndexOf("WorldState ", StringComparison.Ordinal) < 0 && text.IndexOf("SelfState ", StringComparison.Ordinal) < 0 && text2.IndexOf("WorldState ", StringComparison.Ordinal) < 0 && text2.IndexOf("SelfState ", StringComparison.Ordinal) < 0 && text3.IndexOf("WorldState ", StringComparison.Ordinal) < 0 && text3.IndexOf("SelfState ", StringComparison.Ordinal) < 0 && text4.IndexOf("WorldState ", StringComparison.Ordinal) < 0 && text4.IndexOf("SelfState ", StringComparison.Ordinal) < 0 && text4.IndexOf("IReadOnlyList<EntityRow>", StringComparison.Ordinal) < 0 && text5.IndexOf("WorldState ", StringComparison.Ordinal) < 0 && text5.IndexOf("SelfState ", StringComparison.Ordinal) < 0 && text6.IndexOf("WorldState ", StringComparison.Ordinal) < 0 && text6.IndexOf("SelfState ", StringComparison.Ordinal) < 0 && text7.IndexOf("WorldState ", StringComparison.Ordinal) < 0 && text7.IndexOf("SelfState ", StringComparison.Ordinal) < 0 && text8.IndexOf("WorldState ", StringComparison.Ordinal) < 0 && text8.IndexOf("SelfState ", StringComparison.Ordinal) < 0 && text9.IndexOf("WorldState ", StringComparison.Ordinal) < 0 && text9.IndexOf("SelfState ", StringComparison.Ordinal) < 0 && smethod_81(text4, new string[5] { "List<uint> candidateIds = CurrentMonsterIds(form);", "string focus = await form.GetTextboxValueAsync(54);", "bool preferFocus = await form.GetCheckboxValueAsync(73);", "bool preferHighHp = await form.GetCheckboxValueAsync(50);", "EntityRow live = FindMonster(form.Snap.Monsters, candidateIds[i]);" });
			bool flag3 = smethod_81(string_5, new string[4] { "EntityRow selectLive = FindLiveMonster(form, targetId);", "uint liveId = selectLive.Id;", "KlxSession selectSession = form.ActiveSession;", "selectSession.SelectTarget(liveId);" });
			bool flag4 = smethod_81(string_6, new string[4] { "EntityRow attackLive = FindLiveMonster(form, targetId);", "uint attackId = attackLive.Id;", "KlxSession session = form.ActiveSession;", "session.Attack(attackId);" });
			bool flag5 = !string_0.Contains("IsStopRequested()") && !string_1.Contains("IsStopRequested()") && !string_2.Contains("IsStopRequested()") && !string_3.Contains("IsStopRequested()");
			bool flag6 = string_0.IndexOf("CompatibilityUnmigrated", StringComparison.Ordinal) < 0 && string_4.Contains("await Manage_Attack_Monster.Mode(") && string_4.Contains("form, attackRadius);") && string_4.IndexOf("CompatibilityUnmigratedDecisionTail", StringComparison.Ordinal) < 0;
			string text10 = smethod_80(string_0, "public static void Reset()", "    }");
			bool flag7 = text != null && text.Contains("bool castOwns = await Skill_Attack.TryCast(form, live.Id);") && text.Contains("if (_id != 0 && !skillsOnly)") && text.Contains("_id = 0;") && text.Contains("bool idleReattack = !newTarget") && text.Contains("form.Snap.Self?.Action == GLAT_IDLE") && text.Contains("(DateTime.Now - _lastAttack).TotalMilliseconds > ReattackMs") && string_0.Contains("public static void ClearTarget() { _id = 0; }") && text10 != null && !text10.Contains("AttackStop(") && text2 != null && text2.Contains("form.ActiveSession") && text2.Contains("SkillAttackReadiness ready = Volatile.Read(ref _ready)") && smethod_81(text2, new string[2] { "castSession.SelectTarget(targetId);", "castSession.CastSkills(castSlot);" });
			return flag && flag2 && flag3 && flag4 && flag5 && flag6 && flag7;
		}
		return false;
	}

	private static bool smethod_63(string string_0, string string_1, string string_2, string string_3)
	{
		if (string_0 != null && string_1 != null && string_2 != null && string_3 != null)
		{
			if (string_2.Contains("public static async Task<bool> Mode(Form1 form, float radius)") && !string_2.Contains("Mode(KlxSession s, WorldState w, SelfState self") && string_1.Contains("public static async Task<bool> Mode_FollowPos(Form1 form, float radius,") && !string_1.Contains("Mode_FollowPos(KlxSession s, WorldState w, SelfState self") && string_0.IndexOf("CompatibilityFollowPos", StringComparison.Ordinal) < 0 && string_0.IndexOf("MigrationCompatibility_RemoveInTask9", StringComparison.Ordinal) < 0 && string_2.IndexOf("form.GetGrid(", StringComparison.Ordinal) < 0 && string_3.Contains("ReadFollowWaypointsAsync"))
			{
				return string_3.Contains("Position_Grid.ReadAll(grid)");
			}
			return false;
		}
		return false;
	}

	private static bool smethod_64(string string_0, string string_1, string string_2, string string_3)
	{
		if (string_0 != null && string_1 != null && string_2 != null && string_3 != null)
		{
			if (string_2.Contains("public static async Task<bool> Mode(Form1 form, float radius)") && !string_2.Contains("Mode(KlxSession s, WorldState w, SelfState self") && string_0.IndexOf("CompatibilityLooper", StringComparison.Ordinal) < 0 && string_2.IndexOf("form.GetGrid(", StringComparison.Ordinal) < 0 && string_3.Contains("ReadLooperWaypointsAsync") && string_3.Contains("ReadLooperSegmentsAsync"))
			{
				return string_3.Contains("Position_Grid.ReadRoute(grid)");
			}
			return false;
		}
		return false;
	}

	private static bool smethod_65(string string_0, string string_1)
	{
		if (string_0 != null && string_1 != null)
		{
			if (smethod_160(string_0, "await ") >= 4 && smethod_160(string_1, "await ") >= 6 && !string_0.Contains("IsStopRequested()") && !string_1.Contains("IsStopRequested()") && !string_0.Contains("SelfState self = form.Snap.Self;") && !string_1.Contains("SelfState self = form.Snap.Self;") && string_0.Contains("form.Snap.Self?.X"))
			{
				return string_1.Contains("form.Snap.Self?.X");
			}
			return false;
		}
		return false;
	}

	private static bool smethod_66()
	{
		Class263 @class = new Class263();
		@class.methodInfo_0 = typeof(Class412).GetMethod("Engage", BindingFlags.Static | BindingFlags.Public, null, new Type[2]
		{
			typeof(GForm0),
			typeof(uint)
		}, null);
		if (!(@class.methodInfo_0 == null) && !(@class.methodInfo_0.ReturnType != typeof(Task<bool>)))
		{
			FieldInfo field = typeof(Class412).GetField("_id", BindingFlags.Static | BindingFlags.NonPublic);
			FieldInfo field2 = typeof(Class412).GetField("_lastAttack", BindingFlags.Static | BindingFlags.NonPublic);
			FieldInfo field3 = typeof(Class119).GetField("_skillArmed", BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field4 = typeof(Class357).GetField("<SkillAvailable>k__BackingField", BindingFlags.Static | BindingFlags.NonPublic);
			if (!(field == null) && !(field2 == null) && !(field3 == null) && !(field4 == null))
			{
				bool flag = (bool)field4.GetValue(null);
				try
				{
					Class119 class2 = new Class119();
					@class.list_0 = new List<string>();
					class2.method_30(@class.method_0);
					@class.class403_0 = new Class403
					{
						uint_0 = 701u,
						byte_0 = 2,
						ushort_2 = 100,
						ushort_3 = 100,
						float_0 = 3f,
						float_1 = 0f,
						float_2 = 0f
					};
					Class83 class83_ = new Class83
					{
						byte_0 = 1,
						float_0 = 0f,
						float_1 = 0f,
						float_2 = 0f
					};
					Class83 class83_2 = new Class83
					{
						byte_0 = 0,
						float_0 = 0f,
						float_1 = 0f,
						float_2 = 0f
					};
					Class325 class3 = new Class325();
					class3.class263_0 = @class;
					class3.class222_0 = new Class222(class2);
					try
					{
						class3.class222_0.method_0(smethod_78(new List<Class403> { class3.class263_0.class403_0 }, class83_), bool_0: true);
						class3.class222_0.method_5(bool_0: false, Array.Empty<int>());
						field4.SetValue(null, false);
						field3.SetValue(class2, false);
						field.SetValue(null, 0u);
						field2.SetValue(null, DateTime.MinValue);
						Class138.smethod_3();
						bool num = smethod_76(class3.class263_0.methodInfo_0, class3.class222_0.gform0_0, class3.class263_0.class403_0.uint_0);
						DateTime dateTime = (DateTime)field2.GetValue(null);
						if (!num || class3.class263_0.list_0.Count != 1 || !class3.class263_0.list_0[0].Contains("\"cmd\":\"attack\",\"id\":701") || (uint)field.GetValue(null) != class3.class263_0.class403_0.uint_0 || dateTime == DateTime.MinValue)
						{
							return false;
						}
						class3.class263_0.list_0.Clear();
						if (!smethod_76(class3.class263_0.methodInfo_0, class3.class222_0.gform0_0, class3.class263_0.class403_0.uint_0) || class3.class263_0.list_0.Count != 0)
						{
							return false;
						}
						field2.SetValue(null, DateTime.Now.AddSeconds(-3.0));
						class3.class222_0.method_0(smethod_78(new List<Class403> { class3.class263_0.class403_0 }, class83_2), bool_0: true);
						if (!smethod_76(class3.class263_0.methodInfo_0, class3.class222_0.gform0_0, class3.class263_0.class403_0.uint_0) || class3.class263_0.list_0.Count != 1 || !class3.class263_0.list_0[0].Contains("\"cmd\":\"attack\",\"id\":701"))
						{
							return false;
						}
						class3.class263_0.list_0.Clear();
						field.SetValue(null, 0u);
						class3.class222_0.method_5(bool_0: true, Array.Empty<int>());
						if (!smethod_76(class3.class263_0.methodInfo_0, class3.class222_0.gform0_0, class3.class263_0.class403_0.uint_0) || class3.class263_0.list_0.Count != 1 || !class3.class263_0.list_0[0].Contains("\"press\":false"))
						{
							return false;
						}
						if (!smethod_76(class3.class263_0.methodInfo_0, class3.class222_0.gform0_0, class3.class263_0.class403_0.uint_0) || class3.class263_0.list_0.Count != 1)
						{
							return false;
						}
						class3.class263_0.list_0.Clear();
						class3.class222_0.method_5(bool_0: false, new int[1] { 1 });
						field4.SetValue(null, true);
						field3.SetValue(class2, true);
						Class138.smethod_1(new GStruct1[1]
						{
							new GStruct1(1, 0)
						});
						field.SetValue(null, class3.class263_0.class403_0.uint_0);
						if (!smethod_76(class3.class263_0.methodInfo_0, class3.class222_0.gform0_0, class3.class263_0.class403_0.uint_0) || class3.class263_0.list_0.Count != 3 || !class3.class263_0.list_0[0].Contains("\"cmd\":\"skill_check\"") || !class3.class263_0.list_0[1].Contains("\"cmd\":\"attack\",\"id\":701,\"press\":false") || !class3.class263_0.list_0[2].Contains("\"cmd\":\"skill\"") || class3.class263_0.list_0.Exists(Class299.class299_0.method_55) || (uint)field.GetValue(null) != 0)
						{
							return false;
						}
						class3.class263_0.list_0.Clear();
						class3.class222_0.method_5(bool_0: true, new int[1] { 1 });
						Class138.smethod_1(new GStruct1[1]
						{
							new GStruct1(1, 0)
						});
						field.SetValue(null, class3.class263_0.class403_0.uint_0);
						if (!smethod_76(class3.class263_0.methodInfo_0, class3.class222_0.gform0_0, class3.class263_0.class403_0.uint_0) || class3.class263_0.list_0.Count != 3 || !class3.class263_0.list_0[0].Contains("\"cmd\":\"skill_check\"") || !class3.class263_0.list_0[1].Contains("\"cmd\":\"attack\",\"id\":701,\"press\":false") || !class3.class263_0.list_0[2].Contains("\"cmd\":\"skill\"") || class3.class263_0.list_0.Exists(Class299.class299_0.method_56) || (uint)field.GetValue(null) != 0)
						{
							return false;
						}
						class3.class263_0.list_0.Clear();
						Class138.smethod_3();
						field4.SetValue(null, false);
						field3.SetValue(class2, false);
						class3.class222_0.method_5(bool_0: false, Array.Empty<int>());
						field.SetValue(null, 0u);
						class3.class222_0.gform0_0.bool_3 = false;
						class3.class222_0.method_0(smethod_78(new List<Class403> { class3.class263_0.class403_0 }, class83_), bool_0: true);
						Task<bool> result = Task.Factory.StartNew((Func<Task<bool>>)class3.method_0).GetAwaiter().GetResult();
						class3.class222_0.method_0(smethod_78(new List<Class403>(), class83_), bool_0: true);
						if (smethod_77(result) || class3.class263_0.list_0.Count != 0)
						{
							return false;
						}
					}
					finally
					{
						if (class3.class222_0 != null)
						{
							((IDisposable)class3.class222_0).Dispose();
						}
					}
					return true;
				}
				finally
				{
					field4.SetValue(null, flag);
					Class138.smethod_3();
				}
			}
			return false;
		}
		return false;
	}

	private static int smethod_67()
	{
		Class204 @class = new Class204();
		int num = 0;
		Class119 class2 = new Class119();
		@class.list_0 = new List<string>();
		class2.method_30(@class.method_0);
		Class83 class83_ = new Class83
		{
			float_0 = 0f,
			float_1 = 0f,
			float_2 = 0f
		};
		Dictionary<string, string> dictionary_ = new Dictionary<string, string>(StringComparer.Ordinal) { { "1:1", "Route Drop" } };
		Class284 class3 = new Class284();
		class3.class222_0 = new Class222(class2);
		try
		{
			DataGridView dataGridView = smethod_68(class3.class222_0.gform0_0, "dataGridView1");
			DataGridView dataGridView2 = (DataGridView)class3.class222_0.gform0_0.Controls.Find("dataGridView51", searchAllChildren: true)[0];
			DataGridView dataGridView3 = (DataGridView)class3.class222_0.gform0_0.Controls.Find("dataGridView52", searchAllChildren: true)[0];
			dataGridView2.Rows.Clear();
			class3.class222_0.gform0_0.bool_3 = false;
			dataGridView2.Rows.Add(new Class290("0", class3.method_0), "0", "0");
			num += smethod_244("route/live/segment-stop-finishes-read", 1, class3.class222_0.gform0_0.smethod_18().GetAwaiter().GetResult()?.Count ?? (-1));
			class3.class222_0.gform0_0.bool_3 = false;
			Class412.smethod_15();
			smethod_71(class3.class222_0.gform0_0, 4);
			smethod_72(class3.class222_0.gform0_0, 0, 0, bool_0: false);
			smethod_69(dataGridView, new Struct76[2]
			{
				new Struct76
				{
					float_0 = 99f,
					float_1 = 0f,
					float_2 = 0f,
					int_0 = 0,
					bool_0 = false
				},
				new Struct76
				{
					float_0 = 10f,
					float_1 = 0f,
					float_2 = 0f,
					int_0 = 2,
					bool_0 = true
				}
			});
			dataGridView.Rows[0].Cells[0].Value = "bad";
			dataGridView.CreateControl();
			Class403 item = new Class403
			{
				uint_0 = 801u,
				byte_0 = 101,
				ushort_0 = 1,
				ushort_1 = 1,
				float_0 = 0f,
				float_1 = 0f,
				float_2 = 0f
			};
			class3.class222_0.method_0(smethod_113(new List<Class403> { item }, dictionary_, class83_, 1), bool_0: true);
			class3.class222_0.method_4(4, 18, bool_0: false, Array.Empty<string>());
			Class360.smethod_33();
			num += smethod_243("route/live/follow-unfixed-suppresses-pick", !Class360.smethod_1(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			@class.list_0.Clear();
			bool result = Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243("route/live/follow-row-walks", result);
			num += smethod_244("route/live/follow-parsed-route-row", 0, Class2.smethod_6());
			num += smethod_243("route/live/follow-route-command", @class.list_0.Count == 1 && @class.list_0[0].Contains("\"cmd\":\"move\"") && @class.list_0[0].Contains("\"x\":10"));
			@class.list_0.Clear();
			smethod_69(dataGridView, new Struct76[2]
			{
				new Struct76
				{
					float_0 = 0f,
					float_1 = 0f,
					float_2 = 0f,
					int_0 = 2,
					bool_0 = true
				},
				new Struct76
				{
					float_0 = 20f,
					float_1 = 0f,
					float_2 = 0f,
					int_0 = 0,
					bool_0 = false
				}
			});
			Class2.smethod_8();
			class3.class222_0.method_0(smethod_113(new List<Class403> { item }, dictionary_, class83_, 1), bool_0: true);
			bool result2 = Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243("route/live/follow-nohit-waits", result2);
			num += smethod_244("route/live/follow-nohit-holds-row", 0, Class2.smethod_6());
			num += smethod_243("route/live/follow-arrival-fixes-zone", Class412.smethod_2());
			Class360.smethod_33();
			num += smethod_243("route/live/follow-fixed-zone-allows-pick", Class360.smethod_1(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_243("route/live/follow-delay-clock-fixture", smethod_74(typeof(Class2), "_calmFrom", DateTime.Now.AddSeconds(-3.0)));
			Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244("route/live/follow-nohit-advances-after-delay", 1, Class2.smethod_6());
			Class412.smethod_15();
			smethod_69(dataGridView, new Struct76[2]
			{
				new Struct76
				{
					float_0 = 0f,
					float_1 = 0f,
					float_2 = 0f,
					int_0 = 0,
					bool_0 = false
				},
				new Struct76
				{
					float_0 = 20f,
					float_1 = 0f,
					float_2 = 0f,
					int_0 = 0,
					bool_0 = false
				}
			});
			class3.class222_0.method_0(smethod_78(new List<Class403>(), class83_), bool_0: true);
			Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244("route/live/follow-pick-grace-holds-row", 0, Class2.smethod_6());
			Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244("route/live/follow-pick-grace-then-advances", 1, Class2.smethod_6());
			Class412.smethod_15();
			smethod_72(class3.class222_0.gform0_0, 1, 0, bool_0: false);
			smethod_69(dataGridView, new Struct76[2]
			{
				new Struct76
				{
					float_0 = 0f,
					float_1 = 0f,
					float_2 = 0f,
					int_0 = 0,
					bool_0 = false
				},
				new Struct76
				{
					float_0 = 20f,
					float_1 = 0f,
					float_2 = 0f,
					int_0 = 0,
					bool_0 = false
				}
			});
			Class403 item2 = new Class403
			{
				uint_0 = 802u,
				byte_0 = 2,
				ushort_2 = 100,
				ushort_3 = 100,
				float_0 = 0f,
				float_1 = 0f,
				float_2 = 0f
			};
			class3.class222_0.method_0(smethod_78(new List<Class403> { item2 }, new Class83
			{
				float_0 = 0f,
				float_1 = 0f,
				float_2 = 0f,
				byte_0 = 1
			}), bool_0: true);
			@class.list_0.Clear();
			num += smethod_243("route/live/follow-fight-runs", Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_243("route/live/follow-fight-command", @class.list_0.Count != 0);
			num += smethod_243("route/live/follow-fight-cap-clock-fixture", smethod_74(typeof(Class2), "_engagedFrom", DateTime.Now.AddSeconds(-2.0)));
			Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244("route/live/follow-fight-cap-advances", 1, Class2.smethod_6());
			Class412.smethod_15();
			smethod_72(class3.class222_0.gform0_0, 0, 0, bool_0: false);
			smethod_69(dataGridView, new Struct76[1]
			{
				new Struct76
				{
					float_0 = 0f,
					float_1 = 0f,
					float_2 = 0f,
					int_0 = 1,
					bool_0 = true
				}
			});
			class3.class222_0.method_0(smethod_78(new List<Class403>(), class83_), bool_0: true);
			Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			System.Windows.Forms.Label obj = (System.Windows.Forms.Label)class3.class222_0.gform0_0.Controls.Find("label73", searchAllChildren: true)[0];
			obj.Text = string.Empty;
			class3.class222_0.gform0_0.bool_3 = false;
			EventHandler value = class3.method_1;
			obj.TextChanged += value;
			@class.list_0.Clear();
			bool result3 = Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			obj.TextChanged -= value;
			num += smethod_243("route/live/follow-stop-after-delay-finishes-pass", result3);
			num += smethod_244("route/live/follow-stop-after-delay-no-action", 0, @class.list_0.Count);
			class3.class222_0.gform0_0.bool_3 = false;
			Class412.smethod_15();
			smethod_71(class3.class222_0.gform0_0, 5);
			smethod_73(class3.class222_0.gform0_0, bool_0: true, 0, 0, 0, bool_1: false);
			smethod_70(dataGridView2, new Struct76[1]
			{
				new Struct76
				{
					float_0 = 10f,
					float_1 = 0f,
					float_2 = 0f
				}
			});
			smethod_70(dataGridView3, new Struct76[1]
			{
				new Struct76
				{
					float_0 = 20f,
					float_1 = 0f,
					float_2 = 0f
				}
			});
			class3.class222_0.method_0(smethod_78(new List<Class403>(), class83_), bool_0: true);
			@class.list_0.Clear();
			num += smethod_243("route/live/looper-first-segment-walks", Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_244("route/live/looper-first-segment", 51, Class188.smethod_13());
			num += smethod_243("route/live/looper-first-route-command", @class.list_0.Count == 1 && @class.list_0[0].Contains("\"x\":10"));
			class3.class222_0.method_0(smethod_78(new List<Class403>(), new Class83
			{
				float_0 = 10f,
				float_1 = 0f,
				float_2 = 0f
			}), bool_0: true);
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243("route/live/looper-endpoint-fixes-zone", Class412.smethod_2());
			class3.class222_0.method_4(5, 18, bool_0: false, Array.Empty<string>());
			class3.class222_0.method_0(smethod_113(new List<Class403> { item }, dictionary_, new Class83
			{
				float_0 = 10f,
				float_1 = 0f,
				float_2 = 0f
			}, 1), bool_0: true);
			Class360.smethod_33();
			num += smethod_243("route/live/looper-fixed-endpoint-allows-pick", Class360.smethod_1(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243("route/live/looper-walkonly-unfixes-zone", !Class412.smethod_2());
			Class360.smethod_33();
			num += smethod_243("route/live/looper-unfixed-suppresses-pick", !Class360.smethod_1(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			@class.list_0.Clear();
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244("route/live/looper-sequential-next-segment", 52, Class188.smethod_13());
			num += smethod_243("route/live/looper-next-route-command", @class.list_0.Count == 1 && @class.list_0[0].Contains("\"x\":20"));
			Class412.smethod_15();
			smethod_73(class3.class222_0.gform0_0, bool_0: false, 60, 60, 0, bool_1: false);
			smethod_70(dataGridView2, new Struct76[1]
			{
				new Struct76
				{
					float_0 = 0f,
					float_1 = 0f,
					float_2 = 0f
				}
			});
			smethod_70(dataGridView3, new Struct76[1]
			{
				new Struct76
				{
					float_0 = 30f,
					float_1 = 0f,
					float_2 = 0f
				}
			});
			class3.class222_0.method_0(smethod_78(new List<Class403>(), class83_), bool_0: true);
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			@class.list_0.Clear();
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			System.Windows.Forms.Label label = (System.Windows.Forms.Label)class3.class222_0.gform0_0.Controls.Find("label67", searchAllChildren: true)[0];
			num += smethod_244("route/live/looper-pre-dwell-keeps-segment", 51, Class188.smethod_13());
			num += smethod_244("route/live/looper-pre-dwell-no-command", 0, @class.list_0.Count);
			num += smethod_244("route/live/looper-pre-dwell-label", "Loop 51: รอก\u0e48อนต\u0e35 60.0s", label.Text);
			num += smethod_243("route/live/looper-pre-dwell-clock-fixture", smethod_74(typeof(Class188), "_preFrom", DateTime.Now.AddSeconds(-61.0)));
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244("route/live/looper-pick-grace-holds-segment", 51, Class188.smethod_13());
			@class.list_0.Clear();
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244("route/live/looper-post-dwell-keeps-segment", 51, Class188.smethod_13());
			num += smethod_244("route/live/looper-post-dwell-no-command", 0, @class.list_0.Count);
			num += smethod_244("route/live/looper-post-dwell-label", "Loop 51: รอหล\u0e31งต\u0e35 60.0s", label.Text);
			num += smethod_243("route/live/looper-post-dwell-clock-fixture", smethod_74(typeof(Class188), "_postFrom", DateTime.Now.AddSeconds(-61.0)));
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244("route/live/looper-post-dwell-advances", 52, Class188.smethod_13());
			Class412.smethod_15();
			smethod_73(class3.class222_0.gform0_0, bool_0: true, 0, 0, 0, bool_1: true);
			smethod_70(dataGridView2, new Struct76[1]
			{
				new Struct76
				{
					float_0 = 51f,
					float_1 = 0f,
					float_2 = 0f
				}
			});
			smethod_70(dataGridView3, new Struct76[1]
			{
				new Struct76
				{
					float_0 = 52f,
					float_1 = 0f,
					float_2 = 0f
				}
			});
			num += smethod_243("route/live/looper-random-shuffle-fixture", smethod_75(typeof(Class188), new int[2] { 52, 51 }, 0));
			class3.class222_0.method_0(smethod_78(new List<Class403>(), class83_), bool_0: true);
			@class.list_0.Clear();
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244("route/live/looper-random-dispatches-shuffled-segment", 52, Class188.smethod_13());
			num += smethod_243("route/live/looper-random-dispatches-shuffled-route", @class.list_0.Count == 1 && @class.list_0[0].Contains("\"x\":52"));
			Class412.smethod_15();
			smethod_73(class3.class222_0.gform0_0, bool_0: false, 0, 0, 1, bool_1: false);
			smethod_70(dataGridView2, new Struct76[1]
			{
				new Struct76
				{
					float_0 = 0f,
					float_1 = 0f,
					float_2 = 0f
				}
			});
			smethod_70(dataGridView3, new Struct76[1]
			{
				new Struct76
				{
					float_0 = 30f,
					float_1 = 0f,
					float_2 = 0f
				}
			});
			class3.class222_0.method_0(smethod_78(new List<Class403> { item2 }, new Class83
			{
				float_0 = 0f,
				float_1 = 0f,
				float_2 = 0f,
				byte_0 = 1
			}), bool_0: true);
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			@class.list_0.Clear();
			num += smethod_243("route/live/looper-fight-runs", Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_243("route/live/looper-fight-command", @class.list_0.Count != 0);
			num += smethod_243("route/live/looper-fight-cap-clock-fixture", smethod_74(typeof(Class188), "_engagedFrom", DateTime.Now.AddSeconds(-2.0)));
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244("route/live/looper-fight-cap-advances", 52, Class188.smethod_13());
			Class412.smethod_15();
			smethod_73(class3.class222_0.gform0_0, bool_0: true, 0, 0, 0, bool_1: false);
			smethod_70(dataGridView2, new Struct76[1]
			{
				new Struct76
				{
					float_0 = 15f,
					float_1 = 0f,
					float_2 = 0f
				}
			});
			dataGridView3.Rows.Clear();
			class3.class222_0.method_0(smethod_78(new List<Class403>(), class83_), bool_0: true);
			System.Windows.Forms.Label obj2 = (System.Windows.Forms.Label)class3.class222_0.gform0_0.Controls.Find("label67", searchAllChildren: true)[0];
			EventHandler value2 = class3.method_2;
			obj2.TextChanged += value2;
			@class.list_0.Clear();
			bool result4 = Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			obj2.TextChanged -= value2;
			num += smethod_243("route/live/looper-stop-after-delay-finishes-pass", result4);
			num += smethod_244("route/live/looper-stop-after-delay-action", 1, @class.list_0.Count);
			class3.class222_0.gform0_0.bool_3 = false;
			return num;
		}
		finally
		{
			if (class3.class222_0 != null)
			{
				((IDisposable)class3.class222_0).Dispose();
			}
		}
	}

	private static DataGridView smethod_68(GForm0 gform0_0, string string_0)
	{
		DataGridView obj = (DataGridView)gform0_0.Controls.Find(string_0, searchAllChildren: true)[0];
		Class440.smethod_0(obj);
		return obj;
	}

	private static void smethod_69(DataGridView dataGridView_0, Struct76[] struct76_0)
	{
		dataGridView_0.Rows.Clear();
		int num = 0;
		while (struct76_0 != null && num < struct76_0.Length)
		{
			DataGridViewRowCollection rows = dataGridView_0.Rows;
			object[] values = Class440.smethod_8(struct76_0[num]);
			rows.Add(values);
			num++;
		}
	}

	private static void smethod_70(DataGridView dataGridView_0, Struct76[] struct76_0)
	{
		dataGridView_0.Rows.Clear();
		int num = 0;
		while (struct76_0 != null && num < struct76_0.Length)
		{
			dataGridView_0.Rows.Add(Class440.smethod_2(struct76_0[num].float_0), Class440.smethod_2(struct76_0[num].float_1), Class440.smethod_2(struct76_0[num].float_2));
			num++;
		}
	}

	private static void smethod_71(GForm0 gform0_0, int int_0)
	{
		int[] array = new int[6] { 1, 2, 3, 4, 5, 26 };
		for (int i = 0; i < array.Length; i++)
		{
			((RadioButton)gform0_0.Controls.Find("radioButton" + array[i], searchAllChildren: true)[0]).Checked = array[i] == int_0;
		}
	}

	private static void smethod_72(GForm0 gform0_0, int int_0, int int_1, bool bool_0)
	{
		((CheckBox)gform0_0.Controls.Find("checkBox75", searchAllChildren: true)[0]).Checked = int_0 > 0;
		((TextBox)gform0_0.Controls.Find("textBox45", searchAllChildren: true)[0]).Text = int_0.ToString();
		((CheckBox)gform0_0.Controls.Find("checkBox76", searchAllChildren: true)[0]).Checked = int_1 > 0;
		((TextBox)gform0_0.Controls.Find("textBox46", searchAllChildren: true)[0]).Text = int_1.ToString();
		((CheckBox)gform0_0.Controls.Find("checkBox51", searchAllChildren: true)[0]).Checked = bool_0;
	}

	private static void smethod_73(GForm0 gform0_0, bool bool_0, int int_0, int int_1, int int_2, bool bool_1)
	{
		((CheckBox)gform0_0.Controls.Find("checkBox54", searchAllChildren: true)[0]).Checked = bool_1;
		((CheckBox)gform0_0.Controls.Find("checkBox46", searchAllChildren: true)[0]).Checked = bool_0;
		((TextBox)gform0_0.Controls.Find("textBox4", searchAllChildren: true)[0]).Text = int_0.ToString();
		((TextBox)gform0_0.Controls.Find("textBox8", searchAllChildren: true)[0]).Text = int_1.ToString();
		((CheckBox)gform0_0.Controls.Find("checkBox68", searchAllChildren: true)[0]).Checked = int_2 > 0;
		((TextBox)gform0_0.Controls.Find("textBox16", searchAllChildren: true)[0]).Text = int_2.ToString();
	}

	private static bool smethod_74(Type type_0, string string_0, DateTime dateTime_0)
	{
		FieldInfo field = type_0.GetField(string_0, BindingFlags.Static | BindingFlags.NonPublic);
		if (field == null)
		{
			return false;
		}
		field.SetValue(null, dateTime_0);
		return true;
	}

	private static bool smethod_75(Type type_0, IEnumerable<int> ienumerable_0, int int_0)
	{
		FieldInfo field = type_0.GetField("_shuffle", BindingFlags.Static | BindingFlags.NonPublic);
		FieldInfo field2 = type_0.GetField("_shuffleAt", BindingFlags.Static | BindingFlags.NonPublic);
		if (!(field == null) && !(field2 == null))
		{
			field.SetValue(null, new List<int>(ienumerable_0));
			field2.SetValue(null, int_0);
			return true;
		}
		return false;
	}

	private static bool smethod_76(MethodInfo methodInfo_0, GForm0 gform0_0, uint uint_0)
	{
		return ((Task<bool>)methodInfo_0.Invoke(null, new object[2] { gform0_0, uint_0 })).GetAwaiter().GetResult();
	}

	private static bool smethod_77(Task<bool> task_0)
	{
		DateTime dateTime = DateTime.UtcNow.AddSeconds(5.0);
		while (!task_0.IsCompleted && DateTime.UtcNow < dateTime)
		{
			Application.DoEvents();
			Thread.Sleep(1);
		}
		if (!task_0.IsCompleted)
		{
			throw new TimeoutException("Attack worker/UI boundary did not complete");
		}
		return task_0.GetAwaiter().GetResult();
	}

	private static Class145 smethod_78(List<Class403> list_0, Class83 class83_0)
	{
		return Class145.class145_0.method_95(list_0, Class95.class95_0, null, default(GStruct4), 1, 0).method_93(class83_0, 1, 0);
	}

	private static bool smethod_79(string string_0, string string_1)
	{
		return false;
	}

	private static string smethod_80(string string_0, string string_1, string string_2)
	{
		if (string_0 == null)
		{
			return null;
		}
		int num = string_0.IndexOf(string_1, StringComparison.Ordinal);
		if (num < 0)
		{
			return null;
		}
		int num2 = string_0.IndexOf(string_2, num + string_1.Length, StringComparison.Ordinal);
		if (num2 >= 0)
		{
			return string_0.Substring(num, num2 - num);
		}
		return null;
	}

	private static bool smethod_81(string string_0, string[] string_1)
	{
		if (string_0 == null)
		{
			return false;
		}
		int startIndex = 0;
		int num = 0;
		while (true)
		{
			if (num < string_1.Length)
			{
				startIndex = string_0.IndexOf(string_1[num], startIndex, StringComparison.Ordinal);
				if (startIndex < 0)
				{
					break;
				}
				startIndex += string_1[num].Length;
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private static int smethod_82(string string_0, string string_1)
	{
		string text = smethod_171("Capybara-UI-Winform\\Capybara-UI-Winform.csproj");
		if (text == null)
		{
			return -1;
		}
		string directoryName = Path.GetDirectoryName(text);
		string fullPath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(directoryName), string_1));
		int num = 0;
		string[] files = Directory.GetFiles(directoryName, "*.cs", SearchOption.AllDirectories);
		for (int i = 0; i < files.Length; i++)
		{
			string fullPath2 = Path.GetFullPath(files[i]);
			if (!string.Equals(fullPath2, fullPath, StringComparison.OrdinalIgnoreCase) && !fullPath2.EndsWith("\\SelfTest.cs", StringComparison.OrdinalIgnoreCase) && fullPath2.IndexOf("\\Ui\\RefPort\\", StringComparison.OrdinalIgnoreCase) < 0)
			{
				num += smethod_160(File.ReadAllText(fullPath2), string_0);
			}
		}
		return num;
	}

	private static int smethod_83()
	{
		return 0;
	}

	private static int smethod_84()
	{
		return 0;
	}

	private static int smethod_85()
	{
		Class244 @class = new Class244();
		int num = 0;
		int managedThreadId = Thread.CurrentThread.ManagedThreadId;
		@class.gform0_0 = new GForm0();
		_ = @class.gform0_0.Handle;
		try
		{
			Class310 class2 = new Class310();
			class2.class244_0 = @class;
			class2.int_0 = 0;
			Task<int> task = class2.class244_0.gform0_0.smethod_0(class2.method_0);
			num += smethod_243("automatic/ui/inline-completes", task.IsCompleted);
			num += smethod_244("automatic/ui/inline-thread", managedThreadId, task.GetAwaiter().GetResult());
			num += smethod_244("automatic/ui/inline-once", 1, class2.int_0);
			class2.int_1 = 0;
			Task<int> task2 = Task.Run((Func<Task<int>>)class2.method_1);
			num += smethod_243("automatic/ui/worker-completes", smethod_96(task2));
			if (task2.IsCompleted)
			{
				num += smethod_244("automatic/ui/worker-thread", managedThreadId, task2.GetAwaiter().GetResult());
			}
			num += smethod_244("automatic/ui/worker-query-once", 1, class2.int_1);
			CheckBox checkBox = class2.class244_0.gform0_0.Controls.Find("checkBox42", searchAllChildren: true)[0] as CheckBox;
			RadioButton obj = class2.class244_0.gform0_0.Controls.Find("radioButton1", searchAllChildren: true)[0] as RadioButton;
			TrackBar trackBar = class2.class244_0.gform0_0.Controls.Find("trackBar1", searchAllChildren: true)[0] as TrackBar;
			checkBox.Checked = true;
			obj.Checked = true;
			trackBar.Value = trackBar.Minimum + 1;
			Task<bool> task3 = Task.Run((Func<Task<bool>>)class2.class244_0.method_0);
			Task<bool> task4 = Task.Run((Func<Task<bool>>)class2.class244_0.method_1);
			Task<int> task5 = Task.Run((Func<Task<int>>)class2.class244_0.method_2);
			num += smethod_243("automatic/ui/live-first-check-completes", smethod_96(task3));
			num += smethod_243("automatic/ui/live-first-radio-completes", smethod_96(task4));
			num += smethod_243("automatic/ui/live-first-track-completes", smethod_96(task5));
			if (task3.IsCompleted)
			{
				num += smethod_243("automatic/ui/live-first-check", task3.GetAwaiter().GetResult());
			}
			if (task4.IsCompleted)
			{
				num += smethod_243("automatic/ui/live-first-radio", task4.GetAwaiter().GetResult());
			}
			if (task5.IsCompleted)
			{
				num += smethod_244("automatic/ui/live-first-track", trackBar.Minimum + 1, task5.GetAwaiter().GetResult());
			}
			checkBox.Checked = false;
			obj.Checked = false;
			trackBar.Value = trackBar.Minimum + 2;
			Task<bool> task6 = Task.Run((Func<Task<bool>>)class2.class244_0.method_3);
			Task<bool> task7 = Task.Run((Func<Task<bool>>)class2.class244_0.method_4);
			Task<int> task8 = Task.Run((Func<Task<int>>)class2.class244_0.method_5);
			num += smethod_243("automatic/ui/live-second-check-completes", smethod_96(task6));
			num += smethod_243("automatic/ui/live-second-radio-completes", smethod_96(task7));
			num += smethod_243("automatic/ui/live-second-track-completes", smethod_96(task8));
			if (task6.IsCompleted)
			{
				num += smethod_243("automatic/ui/live-second-check", !task6.GetAwaiter().GetResult());
			}
			if (task7.IsCompleted)
			{
				num += smethod_243("automatic/ui/live-second-radio", !task7.GetAwaiter().GetResult());
			}
			if (task8.IsCompleted)
			{
				num += smethod_244("automatic/ui/live-second-track", trackBar.Minimum + 2, task8.GetAwaiter().GetResult());
			}
			for (int i = 29; i <= 33; i++)
			{
				((CheckBox)class2.class244_0.gform0_0.Controls.Find("checkBox" + i, searchAllChildren: true)[0]).Checked = false;
			}
			((CheckBox)class2.class244_0.gform0_0.Controls.Find("checkBox29", searchAllChildren: true)[0]).Checked = true;
			((CheckBox)class2.class244_0.gform0_0.Controls.Find("checkBox31", searchAllChildren: true)[0]).Checked = true;
			((CheckBox)class2.class244_0.gform0_0.Controls.Find("checkBox33", searchAllChildren: true)[0]).Checked = true;
			Task<List<int>> task9 = Task.Run((Func<Task<List<int>>>)class2.class244_0.method_6);
			num += smethod_243("automatic/ui/range-first-completes", smethod_96(task9));
			if (task9.IsCompleted)
			{
				List<int> result = task9.GetAwaiter().GetResult();
				num += smethod_244("automatic/ui/range-first-count", 3, result.Count);
				num += smethod_243("automatic/ui/range-first-values", result.SequenceEqual(new int[3] { 29, 31, 33 }));
			}
			((CheckBox)class2.class244_0.gform0_0.Controls.Find("checkBox29", searchAllChildren: true)[0]).Checked = false;
			((CheckBox)class2.class244_0.gform0_0.Controls.Find("checkBox30", searchAllChildren: true)[0]).Checked = true;
			((CheckBox)class2.class244_0.gform0_0.Controls.Find("checkBox31", searchAllChildren: true)[0]).Checked = false;
			Task<List<int>> task10 = Task.Run((Func<Task<List<int>>>)class2.class244_0.method_7);
			num += smethod_243("automatic/ui/range-second-completes", smethod_96(task10));
			if (task10.IsCompleted)
			{
				List<int> result2 = task10.GetAwaiter().GetResult();
				num += smethod_244("automatic/ui/range-second-count", 2, result2.Count);
				num += smethod_243("automatic/ui/range-second-values", result2.SequenceEqual(new int[2] { 30, 33 }));
			}
			DataGridView dataGridView = class2.class244_0.gform0_0.Controls.Find("dataGridView3", searchAllChildren: true)[0] as DataGridView;
			dataGridView.Rows.Add("Alpha");
			dataGridView.Rows.Add("Beta");
			Task<IReadOnlyList<string>> task11 = Task.Run((Func<Task<IReadOnlyList<string>>>)class2.class244_0.method_8);
			num += smethod_243("automatic/ui/grid-completes", smethod_96(task11));
			if (task11.IsCompleted)
			{
				IReadOnlyList<string> result3 = task11.GetAwaiter().GetResult();
				num += smethod_243("automatic/ui/grid-plain-list", result3 != null && !(result3 is Control));
				num += smethod_244("automatic/ui/grid-count", 2, result3.Count);
				if (result3.Count == 2)
				{
					num += smethod_244("automatic/ui/grid-first", "Alpha", result3[0]);
					num += smethod_244("automatic/ui/grid-second", "Beta", result3[1]);
				}
			}
			DataGridView dataGridView2 = class2.class244_0.gform0_0.Controls.Find("dataGridView9", searchAllChildren: true)[0] as DataGridView;
			dataGridView2.Rows.Clear();
			dataGridView2.Rows.Add("  Beta  ");
			dataGridView2.Rows.Add(new object[1]);
			dataGridView2.Rows.Add("   ");
			dataGridView2.Rows.Add("Alpha");
			Task<IReadOnlyList<string>> task12 = Task.Run((Func<Task<IReadOnlyList<string>>>)class2.class244_0.method_9);
			num += smethod_243("automatic/ui/sell-grid-completes", smethod_96(task12));
			if (task12.IsCompleted)
			{
				IReadOnlyList<string> result4 = task12.GetAwaiter().GetResult();
				num += smethod_243("automatic/ui/sell-grid-read-only-list", result4 != null && result4 is IList<string> && ((IList<string>)result4).IsReadOnly);
				num += smethod_244("automatic/ui/sell-grid-count", 2, result4.Count);
				if (result4.Count == 2)
				{
					num += smethod_244("automatic/ui/sell-grid-trims-first", "Beta", result4[0]);
					num += smethod_244("automatic/ui/sell-grid-keeps-order", "Alpha", result4[1]);
				}
				bool bool_ = false;
				try
				{
					((IList<string>)result4).Add("Gamma");
				}
				catch (NotSupportedException)
				{
					bool_ = true;
				}
				num += smethod_243("automatic/ui/sell-grid-rejects-mutation", bool_);
			}
			using (GForm0 gForm = new GForm0())
			{
				_ = gForm.Handle;
				DataGridView dataGridView3 = gForm.Controls.Find("dataGridView9", searchAllChildren: true)[0] as DataGridView;
				dataGridView3.Parent.Controls.Remove(dataGridView3);
				num += smethod_243("automatic/ui/missing-sell-grid-is-null", gForm.smethod_14().GetAwaiter().GetResult() == null);
				dataGridView3.Dispose();
			}
			StringWriter stringWriter = new StringWriter();
			TextWriterTraceListener textWriterTraceListener = new TextWriterTraceListener(stringWriter);
			Debug.Listeners.Add(textWriterTraceListener);
			try
			{
				num += smethod_243("automatic/ui/missing-checkbox", !class2.class244_0.gform0_0.smethod_6(9999).GetAwaiter().GetResult());
				num += smethod_243("automatic/ui/missing-radio-value", !class2.class244_0.gform0_0.smethod_7(9998).GetAwaiter().GetResult());
				num += smethod_243("automatic/ui/missing-text", class2.class244_0.gform0_0.smethod_8(9999).GetAwaiter().GetResult() == null);
				num += smethod_243("automatic/ui/missing-combo", class2.class244_0.gform0_0.smethod_9("missingCombo").GetAwaiter().GetResult() == null);
				num += smethod_244("automatic/ui/missing-track", 0, class2.class244_0.gform0_0.smethod_10(9999).GetAwaiter().GetResult());
				num += smethod_244("automatic/ui/missing-radio", -1, class2.class244_0.gform0_0.smethod_12(new int[1] { 9999 }).GetAwaiter().GetResult());
				class2.class244_0.gform0_0.smethod_13(9999, "ignored").GetAwaiter().GetResult();
				textWriterTraceListener.Flush();
			}
			finally
			{
				Debug.Listeners.Remove(textWriterTraceListener);
				textWriterTraceListener.Dispose();
			}
			string string_ = stringWriter.ToString();
			num += smethod_244("automatic/ui/missing-checkbox-log", 1, smethod_160(string_, "[FormAccess] missing checkBox9999"));
			num += smethod_244("automatic/ui/missing-radio-value-log", 1, smethod_160(string_, "[FormAccess] missing radioButton9998"));
			num += smethod_244("automatic/ui/missing-text-log", 1, smethod_160(string_, "[FormAccess] missing textBox9999"));
			num += smethod_244("automatic/ui/missing-combo-log", 1, smethod_160(string_, "[FormAccess] missing missingCombo"));
			num += smethod_244("automatic/ui/missing-track-log", 1, smethod_160(string_, "[FormAccess] missing trackBar9999"));
			num += smethod_244("automatic/ui/missing-radio-log", 1, smethod_160(string_, "[FormAccess] missing radioButton9999"));
			num += smethod_244("automatic/ui/missing-write-log", 1, smethod_160(string_, "[FormAccess] missing label9999"));
			GForm0 gForm2 = new GForm0();
			_ = gForm2.Handle;
			gForm2.Dispose();
			Task<int> task13 = gForm2.smethod_0(Class299.class299_0.method_57);
			num += smethod_243("automatic/ui/disposed-faulted", task13.IsFaulted);
			num += smethod_243("automatic/ui/disposed-object-disposed", task13.Exception != null && task13.Exception.InnerException is ObjectDisposedException);
			class2.gform0_0 = new GForm0();
			class2.int_2 = 0;
			num += smethod_243("automatic/ui/handleless-fixture", !class2.gform0_0.IsHandleCreated);
			Task<int> task14 = Task.Run((Func<Task<int>>)class2.method_3);
			num += smethod_243("automatic/ui/handleless-worker-completes", smethod_96(task14));
			num += smethod_243("automatic/ui/handleless-worker-faults", task14.IsFaulted && task14.Exception != null && task14.Exception.InnerException is InvalidOperationException);
			num += smethod_244("automatic/ui/handleless-query-not-run", 0, class2.int_2);
			class2.gform0_0.Dispose();
			class2.gform0_1 = new GForm0();
			_ = class2.gform0_1.Handle;
			Task<Task<int>> task15 = Task.Factory.StartNew((Func<Task<int>>)class2.method_5, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
			num += smethod_243("automatic/ui/disposal-race-queued", smethod_97(task15));
			Task<int> result5 = task15.GetAwaiter().GetResult();
			class2.gform0_1.Dispose();
			num += smethod_243("automatic/ui/disposal-race-completes", smethod_96(result5));
			num += smethod_243("automatic/ui/disposal-race-object-disposed", result5.IsFaulted && result5.Exception != null && result5.Exception.InnerException is ObjectDisposedException);
			num += smethod_87(class2.class244_0.gform0_0);
			string text = smethod_173("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", ref num);
			if (text != null)
			{
				num += smethod_244("automatic/ui/one-begininvoke-site", 1, smethod_160(text, "BeginInvoke("));
				num += smethod_243("automatic/ui/async-continuations", text.IndexOf("TaskCreationOptions.RunContinuationsAsynchronously", StringComparison.Ordinal) >= 0);
			}
			return num + smethod_86();
		}
		finally
		{
			@class.gform0_0.Dispose();
		}
	}

	private static int smethod_86()
	{
		int num = 0;
		string text = smethod_171("Capybara-UI-Winform\\Capybara-UI-Winform.csproj");
		Class278 @class = smethod_168(text);
		num = 0 + smethod_243("automatic/ui/source-audit-project", @class.string_0 != null);
		if (@class.string_0 == null)
		{
			return num;
		}
		string directoryName = Path.GetDirectoryName(text);
		MatchCollection matchCollection = Regex.Matches(@class.string_0, "<Compile\\s+Include=\\\"([^\\\"]+\\.cs)\\\"", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
		num += smethod_243("automatic/ui/source-audit-compiled-files", matchCollection.Count > 0);
		for (int i = 0; i < matchCollection.Count; i++)
		{
			string value = matchCollection[i].Groups[1].Value;
			string path = value.Replace('\\', Path.DirectorySeparatorChar);
			string fullPath = Path.GetFullPath(Path.Combine(directoryName, path));
			if (!fullPath.EndsWith(Path.DirectorySeparatorChar + "SelfTest.cs", StringComparison.OrdinalIgnoreCase) && !fullPath.EndsWith(Path.DirectorySeparatorChar + "FormAccess.cs", StringComparison.OrdinalIgnoreCase))
			{
				Class278 class2 = smethod_168(fullPath);
				num += smethod_243("automatic/ui/source-audit-readable/" + value, class2.string_0 != null);
				if (class2.string_0 != null)
				{
					num += smethod_244("automatic/ui/named-helper-only/" + value, 0, Regex.Matches(class2.string_0, "\\.ReadUiAsync\\s*\\(", RegexOptions.CultureInvariant).Count);
				}
			}
		}
		return num;
	}

	private static int smethod_87(GForm0 gform0_0)
	{
		return 0;
	}

	private static int smethod_88(MethodInfo methodInfo_0, MethodInfo methodInfo_1)
	{
		return 0;
	}

	private static int smethod_89(MethodInfo methodInfo_0)
	{
		return 0;
	}

	private static int smethod_90(MethodInfo methodInfo_0)
	{
		return 0;
	}

	private static int smethod_91(MethodInfo methodInfo_0)
	{
		return 0;
	}

	private static Class148 smethod_92(GForm0 gform0_0, Class119 class119_0, long long_1, Task task_0)
	{
		smethod_94(gform0_0, "_session", class119_0);
		smethod_93(class119_0, bool_0: true, bool_1: true);
		smethod_94(gform0_0, "Select_request", true);
		Class148 @class = new Class148(long_1);
		@class.method_6(task_0);
		smethod_94(gform0_0, "_activeAutomaticRun", @class);
		smethod_94(gform0_0, "_automaticTask", task_0);
		gform0_0.bool_2 = true;
		gform0_0.bool_3 = false;
		gform0_0.bool_4 = false;
		gform0_0.method_92((Enum11)2);
		return @class;
	}

	private static void smethod_93(Class119 class119_0, bool bool_0, bool bool_1)
	{
		typeof(Class119).GetField("_readyRequest", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(class119_0, bool_0 ? 1 : 0);
		typeof(Class119).GetField("_streaming", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(class119_0, bool_1 ? 1 : 0);
		class119_0.method_30(Class299.class299_0.method_59);
	}

	private static void smethod_94(object object_0, string string_0, object object_1)
	{
		object_0.GetType().GetField(string_0, BindingFlags.Instance | BindingFlags.NonPublic).SetValue(object_0, object_1);
	}

	private static object smethod_95(object object_0, string string_0)
	{
		return object_0.GetType().GetField(string_0, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(object_0);
	}

	private static bool smethod_96(Task task_0)
	{
		return smethod_98(new Class219
		{
			task_0 = task_0
		}.method_0);
	}

	private static bool smethod_97(Task task_0)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		while (!task_0.IsCompleted && stopwatch.ElapsedMilliseconds < 5000L)
		{
			Thread.Yield();
		}
		return task_0.IsCompleted;
	}

	private static bool smethod_98(Func<bool> func_0)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		while (!func_0() && stopwatch.ElapsedMilliseconds < 5000L)
		{
			Application.DoEvents();
			Thread.Yield();
		}
		Application.DoEvents();
		return func_0();
	}

	private static int smethod_99()
	{
		return 0;
	}

	public static int smethod_100()
	{
		int num = 0;
		num = 0 + smethod_243("focused_filters_zone", !Class172.smethod_0("{\"t\":\"zone\",\"id\":\"wpt\"}"));
		num += smethod_243("focused_filters_skill", !Class172.smethod_0("{\"t\":\"skill\",\"fired\":0}"));
		num += smethod_243("focused_filters_slot", !Class172.smethod_0("{\"t\":\"slot\",\"ok\":true}"));
		num += smethod_243("focused_keeps_run", Class172.smethod_0("Run: attached"));
		num += smethod_243("focused_keeps_pick_decision", Class172.smethod_0("[PickDecision] action=move"));
		Class172.bool_0 = false;
		num += smethod_243("focused_can_be_disabled", Class172.smethod_0("{\"t\":\"zone\"}"));
		Class172.bool_0 = true;
		string text = Class172.smethod_7(7u, 101, "Sword", 0f, 0f, 0f, 1f, 10f, 0f, 1f, 10f, 0f, 10.05f, 1f, 10f, "move", 12, 3456L, 9);
		num += smethod_243("decision_uses_3d_metric", text.IndexOf("d3=", StringComparison.Ordinal) >= 0 && text.IndexOf(" dXZ=1 threshold=10 compare=d3>threshold", StringComparison.Ordinal) >= 0);
		num += smethod_243("decision_has_snapshot_ids", text.IndexOf("snap_seq=12 self_stamp_ms=3456 census_seq=9", StringComparison.Ordinal) >= 0);
		string text2 = Class172.smethod_7(7u, 101, "Sword", 0f, 0f, 0f, 10.004f, 0f, 0f, 10.004f, 0f, 0f, 10.004f, 10.004f, 10f, "move", 12, 3456L, 9);
		num += smethod_243("decision_keeps_just_over_threshold", text2.IndexOf("action=move", StringComparison.Ordinal) >= 0 && text2.IndexOf("d3=10 threshold=10", StringComparison.Ordinal) < 0);
		string text3 = Class172.smethod_7(8u, 101, "line1\r\nline2\tend", 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 10f, "pick", 1, 2L, 3);
		num += smethod_243("decision_name_one_line", text3.IndexOf('\r') < 0 && text3.IndexOf('\n') < 0 && text3.IndexOf("line1\\r\\nline2\\tend", StringComparison.Ordinal) >= 0);
		Class172.Class173 @class = new Class172.Class173();
		DateTime dateTime_ = new DateTime(2026, 9, 17, 0, 0, 0, DateTimeKind.Utc);
		num += smethod_243("gate_first", @class.method_0("pick:7:move", bool_0: false, dateTime_));
		num += smethod_243("gate_same_bounded", !@class.method_0("pick:7:move", bool_0: false, dateTime_.AddMilliseconds(999.0)));
		num += smethod_243("gate_same_after_second", @class.method_0("pick:7:move", bool_0: false, dateTime_.AddMilliseconds(1000.0)));
		num += smethod_243("gate_action_change", @class.method_0("pick:7:pick", bool_0: false, dateTime_.AddMilliseconds(1001.0)));
		num += smethod_243("gate_target_change", @class.method_0("pick:8:pick", bool_0: false, dateTime_.AddMilliseconds(1002.0)));
		num += smethod_243("gate_failure_immediate", @class.method_0("pick:8:pick", bool_0: true, dateTime_.AddMilliseconds(1003.0)));
		num += smethod_243("gate_failure_bounded", !@class.method_0("pick:8:pick", bool_0: true, dateTime_.AddMilliseconds(1004.0)));
		Class172.Class173 class2 = new Class172.Class173();
		num += smethod_243("gate_inreach_first", class2.method_0("pick:7:in_reach", bool_0: false, dateTime_));
		num += smethod_243("gate_inreach_throttle_pick_bounded", !class2.method_0("pick:7:in_reach", bool_0: false, dateTime_.AddMilliseconds(600.0)));
		Console.WriteLine("focusedlogs: " + num + " failed");
		return num;
	}

	public static int smethod_101()
	{
		int num = 0;
		num = 0 + smethod_244("Check(1,3,5)", "{\"cmd\":\"skill_check\",\"slots\":[1,3,5]}", Class454.smethod_1(new int[3] { 1, 3, 5 }));
		num += smethod_244("Check(empty)", "{\"cmd\":\"skill_check\",\"slots\":[]}", Class454.smethod_1(new int[0]));
		IReadOnlyList<GStruct1> readOnlyList = Class119.smethod_17((JObject)JToken.Parse("{\"t\":\"skill_check\",\"ok\":true,\"slots\":[{\"n\":1,\"code\":0,\"ready\":true},{\"n\":2,\"code\":8,\"ready\":false},{\"n\":3,\"code\":-1,\"ready\":false}]}"));
		num += smethod_244("rows.Count", 3, readOnlyList.Count);
		if (readOnlyList.Count == 3)
		{
			num += smethod_244("row0.Slot", 1, readOnlyList[0].int_0);
			num += smethod_243("row0.Ready (code 0)", readOnlyList[0].bool_0);
			num += smethod_244("row1.Code", 8, readOnlyList[1].int_1);
			num += smethod_243("row1 not ready (NOTSP 8)", !readOnlyList[1].bool_0);
			num += smethod_244("row2.Code", -1, readOnlyList[2].int_1);
			num += smethod_243("row2 not ready (empty -1)", !readOnlyList[2].bool_0);
		}
		num += smethod_243("SkillReady(3,0).Ready", new GStruct1(3, 0).bool_0);
		num += smethod_243("SkillReady(1,8) not ready", !new GStruct1(1, 8).bool_0);
		num += smethod_243("SkillReady(2,-1) not ready", !new GStruct1(2, -1).bool_0);
		FieldInfo field = typeof(Class357).GetField("<SkillAvailable>k__BackingField", BindingFlags.Static | BindingFlags.NonPublic);
		FieldInfo field2 = typeof(Class119).GetField("_skillArmed", BindingFlags.Instance | BindingFlags.NonPublic);
		bool flag = (bool)field.GetValue(null);
		try
		{
			Class258 @class = new Class258();
			Class119 class2 = new Class119();
			@class.list_0 = new List<string>();
			class2.method_30(@class.method_0);
			Class222 class3 = new Class222(class2);
			try
			{
				class3.method_0(smethod_78(new List<Class403>(), new Class83
				{
					byte_0 = 3
				}), bool_0: true);
				class3.method_5(bool_0: false, new int[1] { 1 });
				field.SetValue(null, true);
				field2.SetValue(class2, true);
				Class138.smethod_3();
				Class138.smethod_1(new GStruct1[1]
				{
					new GStruct1(1, 0)
				});
				bool result = Class138.smethod_2(class3.gform0_0, 701u).GetAwaiter().GetResult();
				num += smethod_243("skillcheck/action3-still-requests-cast", result && @class.list_0.Count == 3 && @class.list_0[0].Contains("\"cmd\":\"skill_check\"") && @class.list_0[1].Contains("\"cmd\":\"attack\",\"id\":701,\"press\":false") && @class.list_0[2].Contains("\"cmd\":\"skill\""));
			}
			finally
			{
				((IDisposable)class3).Dispose();
			}
		}
		finally
		{
			Class138.smethod_3();
			field.SetValue(null, flag);
		}
		num += smethod_243("skillcheck/cast-does-not-stop-normal-attack", smethod_66());
		Console.WriteLine("skillcheck: " + num + " failed");
		return num;
	}

	public static int smethod_102()
	{
		int num = 0;
		num = 0 + smethod_244("poslabel", "X:12.50 , Z:-7.25", Class440.smethod_3(12.5f, -7.25f));
		Class412.smethod_6(3f, 9f, 4f);
		num += smethod_243("zone_fixed_flag", Class412.smethod_2());
		num += smethod_243("zone_fixed_projection_matches_state", Class412.smethod_2() == Class412.smethod_1().bool_0);
		num += smethod_244("zone_label_fixed", "X:3.00 , Z:4.00", Class412.smethod_8());
		Class412.smethod_7();
		num += smethod_243("zone_unfixed_flag", !Class412.smethod_2());
		num += smethod_243("zone_unfixed_projection_matches_state", Class412.smethod_2() == Class412.smethod_1().bool_0);
		num += smethod_244("zone_label_unfixed", "-", Class412.smethod_8());
		Console.WriteLine("zonelabel: " + num + " failed");
		return num;
	}

	public static int smethod_103()
	{
		int num = 0;
		num = 0 + smethod_244("pick/cmd/request-token", "{\"cmd\":\"pick\",\"type\":3,\"id\":77,\"req\":1234}", Class397.smethod_0(3, 77u, 1234u));
		string text = smethod_174(ref num);
		if (text != null)
		{
			num += smethod_243("pick/agent/dispatch-forwards-request-token", text.Contains("pickTake(m.type === void 0 ? -1 : m.type, m.id === void 0 ? 0 : m.id, m.req === void 0 ? 0 : m.req)"));
			num += smethod_243("pick/agent/reply-echoes-request-token", text.Contains("t: \"pick\", ok: true, id, type, req"));
			num += smethod_243("pick/agent/queue-failure-echoes-request-token", text.Contains("send({ t: \"pick\", ok: false, id, type, req, error: \"frame queue unavailable\" })"));
		}
		Dictionary<string, string> dictionary_ = new Dictionary<string, string>(StringComparer.Ordinal)
		{
			{ "1:1", "Sword" },
			{ "1:2", "Potion" },
			{ "9:9", "กล\u0e48องเส\u0e35\u0e48ยงโชค" }
		};
		Class83 class83_ = new Class83
		{
			float_0 = 0f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 @class = new Class403
		{
			uint_0 = 1u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 1f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class2 = new Class403
		{
			uint_0 = 2u,
			byte_0 = 101,
			ushort_0 = 7,
			ushort_1 = 7,
			float_0 = 2f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class145_ = smethod_113(new List<Class403> { @class, class2 }, dictionary_, class83_, 1);
		num += smethod_244("itemname_seen", "Sword", Class447.smethod_3(class145_, @class));
		num += smethod_243("itemname_unseen_null", Class447.smethod_3(class145_, class2) == null);
		num += smethod_243("list_exact_ci", Class360.smethod_32(smethod_114(new string[1] { "Apple" }), "apple"));
		num += smethod_243("list_row_contains_name", Class360.smethod_32(smethod_114(new string[1] { "Red Apple" }), "Apple"));
		num += smethod_243("list_name_contains_row", Class360.smethod_32(smethod_114(new string[1] { "App" }), "Apple"));
		num += smethod_243("list_empty_grid_false", !Class360.smethod_32(smethod_114(Array.Empty<string>()), "Apple"));
		num += smethod_243("list_null_name_false", !Class360.smethod_32(smethod_114(new string[1] { "Apple" }), null));
		num += smethod_243("list_empty_name_false", !Class360.smethod_32(smethod_114(new string[1] { "Apple" }), string.Empty));
		DataGridView dataGridView = new DataGridView();
		dataGridView.Columns.Add("col0", "item");
		dataGridView.Rows.Add("Apple");
		num += smethod_243("list_newrow_match", Class360.smethod_32(dataGridView, "Apple"));
		num += smethod_243("list_newrow_skipped", !Class360.smethod_32(dataGridView, "Banana"));
		Class403 class3 = new Class403
		{
			uint_0 = 10u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class4 = new Class403
		{
			uint_0 = 11u,
			byte_0 = 102,
			float_0 = 6f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class145_2 = smethod_113(new List<Class403> { class3, class4 }, dictionary_, class83_, 1);
		num += smethod_243("mode22_none_null", Class360.smethod_27(class145_2, class83_, bool_5: false, 0f, 0f, 0f, 100f, 22, bool_6: false, bool_7: false, 0, bool_8: false, null) == null);
		num += smethod_243("mode_noradio_null", Class360.smethod_27(class145_2, class83_, bool_5: false, 0f, 0f, 0f, 100f, -1, bool_6: false, bool_7: false, 0, bool_8: false, null) == null);
		num += smethod_243("mode19_returns_money", Class360.smethod_27(class145_2, class83_, bool_5: false, 0f, 0f, 0f, 100f, 19, bool_6: false, bool_7: false, 0, bool_8: false, null) == class4);
		num += smethod_243("mode18_returns_nearest", Class360.smethod_27(class145_2, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class3);
		Class403 class5 = new Class403
		{
			uint_0 = 20u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 10f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class6 = new Class403
		{
			uint_0 = 21u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 2,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 item = new Class403
		{
			uint_0 = 22u,
			byte_0 = 102,
			float_0 = 20f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class145_3 = smethod_113(new List<Class403> { class5, class6, item }, dictionary_, class83_, 1);
		DataGridView dataGridView_ = smethod_114(new string[1] { "Sword" });
		Class403 class7 = Class360.smethod_27(class145_3, class83_, bool_5: false, 0f, 0f, 0f, 100f, 20, bool_6: false, bool_7: false, 0, bool_8: false, dataGridView_);
		num += smethod_243("mode20_unlisted_not_chosen", class7 != class6);
		num += smethod_243("mode20_listed_chosen", class7 == class5);
		Class403 class8 = new Class403
		{
			uint_0 = 30u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class9 = new Class403
		{
			uint_0 = 31u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 2,
			float_0 = 10f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 item2 = new Class403
		{
			uint_0 = 32u,
			byte_0 = 102,
			float_0 = 20f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class145_4 = smethod_113(new List<Class403> { class8, class9, item2 }, dictionary_, class83_, 1);
		DataGridView dataGridView_2 = smethod_114(new string[1] { "Sword" });
		Class403 class10 = Class360.smethod_27(class145_4, class83_, bool_5: false, 0f, 0f, 0f, 100f, 21, bool_6: false, bool_7: false, 0, bool_8: false, dataGridView_2);
		num += smethod_243("mode21_listed_skipped", class10 != class8);
		num += smethod_243("mode21_unlisted_chosen", class10 == class9);
		Class403 class11 = new Class403
		{
			uint_0 = 40u,
			byte_0 = 102,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class145_5 = smethod_113(new List<Class403> { class11 }, dictionary_, class83_, 1);
		num += smethod_243("cb94_money_skipped_null", Class360.smethod_27(class145_5, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: true, bool_7: false, 0, bool_8: false, null) == null);
		num += smethod_243("cb94_off_money_chosen", Class360.smethod_27(class145_5, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class11);
		Class403 class12 = new Class403
		{
			uint_0 = 50u,
			byte_0 = 101,
			ushort_0 = 9,
			ushort_1 = 9,
			byte_2 = 16,
			byte_3 = 6,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class145_6 = smethod_113(new List<Class403> { class12 }, dictionary_, class83_, 1);
		DataGridView dataGridView_3 = smethod_114(Array.Empty<string>());
		num += smethod_243("cb38_box_skipped_null", Class360.smethod_27(class145_6, class83_, bool_5: false, 0f, 0f, 0f, 100f, 20, bool_6: false, bool_7: true, 0, bool_8: false, dataGridView_3) == null);
		num += smethod_243("cb38_off_box_chosen", Class360.smethod_27(class145_6, class83_, bool_5: false, 0f, 0f, 0f, 100f, 20, bool_6: false, bool_7: false, 0, bool_8: false, dataGridView_3) == class12);
		Class403 class13 = new Class403
		{
			uint_0 = 60u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 item3 = new Class403
		{
			uint_0 = 61u,
			byte_0 = 1,
			byte_1 = 0,
			float_0 = 10f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class145_7 = smethod_113(new List<Class403> { class13, item3 }, dictionary_, class83_, 1);
		num += smethod_243("cb43_monster_defers_null", Class360.smethod_27(class145_7, class83_, bool_5: true, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: true, null) == null);
		Class145 class145_8 = smethod_113(new List<Class403> { class13 }, dictionary_, class83_, 1);
		num += smethod_243("cb43_clear_returns_drop", Class360.smethod_27(class145_8, class83_, bool_5: true, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: true, null) == class13);
		Class83 class83_2 = new Class83
		{
			float_0 = 40f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class14 = new Class403
		{
			uint_0 = 70u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 0f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class15 = new Class403
		{
			uint_0 = 71u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 55f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class145_9 = smethod_113(new List<Class403> { class14, class15 }, dictionary_, class83_2, 1);
		num += smethod_243("zonegate_picks_inzone", Class360.smethod_27(class145_9, class83_2, bool_5: true, 0f, 0f, 0f, 50f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class14);
		num += smethod_243("zonegate_off_picks_nearest", Class360.smethod_27(class145_9, class83_2, bool_5: false, 0f, 0f, 0f, 50f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class15);
		Class83 class83_3 = new Class83
		{
			float_0 = 40f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class16 = new Class403
		{
			uint_0 = 72u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 0f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class145_10 = smethod_113(new List<Class403> { class16 }, dictionary_, class83_3, 1);
		num += smethod_243("zonegate_inzone_beyond_self_radius", Class360.smethod_27(class145_10, class83_3, bool_5: true, 0f, 0f, 0f, 30f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class16);
		Class403 item4 = new Class403
		{
			uint_0 = 80u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class17 = new Class403
		{
			uint_0 = 81u,
			byte_0 = 102,
			float_0 = 20f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class145_11 = smethod_113(new List<Class403> { item4, class17 }, dictionary_, class83_, 1);
		num += smethod_243("nearest_eligible_skips_filtered", Class360.smethod_27(class145_11, class83_, bool_5: false, 0f, 0f, 0f, 100f, 19, bool_6: false, bool_7: false, 0, bool_8: false, null) == class17);
		Class403 class18 = new Class403
		{
			uint_0 = 90u,
			byte_0 = 101,
			byte_2 = 16,
			byte_3 = 6,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class145_12 = smethod_113(new List<Class403> { class18 }, dictionary_, class83_, 1);
		num += smethod_243("box_default_kept", Class360.smethod_27(class145_12, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class18);
		num += smethod_243("box_cb38_skipped", Class360.smethod_27(class145_12, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: true, 0, bool_8: false, null) == null);
		Class403 class19 = new Class403
		{
			uint_0 = 91u,
			byte_0 = 101,
			byte_2 = 16,
			byte_3 = 1,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class20 = new Class403
		{
			uint_0 = 92u,
			byte_0 = 101,
			byte_2 = 16,
			byte_3 = 3,
			float_0 = 10f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class21 = Class360.smethod_27(smethod_113(new List<Class403> { class19, class20 }, dictionary_, class83_, 1), class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, Class360.smethod_0(1), bool_8: false, null);
		num += smethod_243("box_lock_speedup_skips_locked", class21 != class19);
		num += smethod_243("box_lock_speedup_keeps_other", class21 == class20);
		Class403 item5 = new Class403
		{
			uint_0 = 93u,
			byte_0 = 101,
			byte_2 = 16,
			byte_3 = 6,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class145_13 = smethod_113(new List<Class403> { item5 }, dictionary_, class83_, 1);
		num += smethod_243("box_lock_lucky", Class360.smethod_27(class145_13, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, Class360.smethod_0(6), bool_8: false, null) == null);
		Class403 class22 = new Class403
		{
			uint_0 = 94u,
			byte_0 = 101,
			byte_2 = 16,
			byte_3 = 7,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class23 = new Class403
		{
			uint_0 = 95u,
			byte_0 = 101,
			byte_2 = 16,
			byte_3 = 8,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class145_14 = smethod_113(new List<Class403> { class22 }, dictionary_, class83_, 1);
		Class145 class145_15 = smethod_113(new List<Class403> { class23 }, dictionary_, class83_, 1);
		num += smethod_243("box_bomb_kept", Class360.smethod_27(class145_14, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class22);
		num += smethod_243("box_mobgen_kept", Class360.smethod_27(class145_15, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class23);
		num += smethod_243("box_bomb_cb38_skipped", Class360.smethod_27(class145_14, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: true, 0, bool_8: false, null) == null);
		Class83 class83_4 = new Class83
		{
			float_0 = 0f,
			float_1 = 0f,
			float_2 = 0f,
			byte_5 = 0
		};
		Class83 class83_5 = new Class83
		{
			float_0 = 0f,
			float_1 = 0f,
			float_2 = 0f,
			byte_5 = 6
		};
		Class83 class83_6 = new Class83
		{
			float_0 = 0f,
			float_1 = 0f,
			float_2 = 0f,
			byte_5 = 9
		};
		Class403 class24 = new Class403
		{
			uint_0 = 100u,
			byte_0 = 101,
			byte_2 = 16,
			byte_3 = 1,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class25 = new Class403
		{
			uint_0 = 101u,
			byte_0 = 101,
			byte_2 = 16,
			byte_3 = 2,
			float_0 = 10f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 item6 = new Class403
		{
			uint_0 = 102u,
			byte_0 = 101,
			byte_2 = 16,
			byte_3 = 6,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class26 = new Class403
		{
			uint_0 = 103u,
			byte_0 = 101,
			byte_2 = 16,
			byte_3 = 1,
			float_0 = 10f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class27 = new Class403
		{
			uint_0 = 104u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 15f,
			float_1 = 0f,
			float_2 = 0f
		};
		int int_ = Class360.smethod_0(6);
		int int_2 = Class360.smethod_0(1);
		Class145 class145_16 = smethod_113(new List<Class403> { class24, class25 }, dictionary_, class83_5, 1);
		num += smethod_243("held6_lock33_skips_every_box", Class360.smethod_27(class145_16, class83_5, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, int_, bool_8: false, null) == null);
		num += smethod_243("held6_lock33_skips_every_box_mode20", Class360.smethod_27(class145_16, class83_5, bool_5: false, 0f, 0f, 0f, 100f, 20, bool_6: false, bool_7: false, int_, bool_8: false, smethod_114(Array.Empty<string>())) == null);
		num += smethod_243("held6_nolock_picks_by_type", Class360.smethod_27(class145_16, class83_5, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class24);
		Class145 class145_17 = smethod_113(new List<Class403> { item6, class26 }, dictionary_, class83_4, 1);
		num += smethod_243("held0_lock33_skips_only_lucky", Class360.smethod_27(class145_17, class83_4, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, int_, bool_8: false, null) == class26);
		Class145 class145_18 = smethod_113(new List<Class403> { class24, class25 }, dictionary_, class83_6, 1);
		num += smethod_243("held9_lock29_guard_off", Class360.smethod_27(class145_18, class83_6, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, int_2, bool_8: false, null) == class25);
		Class145 class145_19 = smethod_113(new List<Class403> { class24, class27 }, dictionary_, class83_5, 1);
		num += smethod_243("held6_lock33_keeps_items", Class360.smethod_27(class145_19, class83_5, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, int_, bool_8: false, null) == class27);
		string text2 = GForm0.smethod_1("{\r\n  \"t\": \"moved\",\r\n  \"ok\": true,\r\n  \"target\": {\r\n    \"x\": 1.5,\r\n    \"z\": 2.5\r\n  }\r\n}");
		num += smethod_243("sessionlog_moved_kept", text2 != null);
		num += smethod_243("sessionlog_moved_one_line", text2 != null && text2.IndexOf('\n') < 0 && text2.IndexOf('\r') < 0);
		num += smethod_244("sessionlog_moved_compact", "{\"t\":\"moved\",\"ok\":true,\"target\":{\"x\":1.5,\"z\":2.5}}", text2);
		num += smethod_244("sessionlog_pick_kept", "{\"t\":\"pick\",\"ok\":true,\"id\":7,\"type\":101}", GForm0.smethod_1("{\r\n  \"t\": \"pick\",\r\n  \"ok\": true,\r\n  \"id\": 7,\r\n  \"type\": 101\r\n}"));
		num += smethod_243("sessionlog_zone_dropped", GForm0.smethod_1("{\r\n  \"t\": \"zone\",\r\n  \"id\": \"wpt\",\r\n  \"ok\": true\r\n}") == null);
		num += smethod_244("sessionlog_text_unchanged", "Run: attached", GForm0.smethod_1("Run: attached"));
		num += smethod_244("sessionlog_error_unchanged", "agent error: boom", GForm0.smethod_1("agent error: boom"));
		num += smethod_104();
		num += smethod_111();
		num += smethod_105();
		Console.WriteLine("pick: " + num + " failed");
		return num;
	}

	private static int smethod_104()
	{
		int num = 0;
		Class119 @class = new Class119();
		try
		{
			num += smethod_243("pick/reply/initial-empty", @class.method_20() == null);
			long num2 = @class.method_21();
			@class.method_145(401u, 3, 11u, bool_17: false, "refused");
			Class60 class2 = @class.method_20();
			num += smethod_243("pick/reply/first-coherent", class2 != null && class2.long_0 == num2 + 1L && class2.uint_0 == 401 && class2.byte_0 == 3 && class2.uint_1 == 11 && !class2.bool_0 && class2.string_0 == "refused");
			@class.method_145(402u, 4, 12u, bool_17: true, null);
			Class60 class3 = @class.method_20();
			num += smethod_243("pick/reply/second-coherent", class3 != null && class3.long_0 == class2.long_0 + 1L && class3.uint_0 == 402 && class3.byte_0 == 4 && class3.uint_1 == 12 && class3.bool_0 && class3.string_0 == string.Empty);
			long gparam_ = @class.method_21();
			long num3 = @class.method_22();
			smethod_94(@class, "_pickArmed", true);
			@class.method_210();
			num += smethod_243("pick/reply/close-clears-publication", @class.method_20() == null);
			num += smethod_244("pick/reply/sequence-does-not-rewind", gparam_, @class.method_21());
			num += smethod_243("pick/reply/close-advances-lifecycle", @class.method_22() > num3);
			num += smethod_243("pick/reply/close-disarms-pick", !@class.method_136());
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		Class320 class4 = new Class320();
		class4.class119_0 = new Class119();
		try
		{
			bool bool_ = true;
			long num4 = 0L;
			Task task = Task.Run((Action)class4.method_0);
			Task task2 = Task.Run((Action)class4.method_1);
			while (!Task.WaitAll(new Task[2] { task, task2 }, 0))
			{
				Class60 class5 = class4.class119_0.method_20();
				if (class5 != null)
				{
					string text = class5.uint_0 + ":" + class5.byte_0 + ":" + class5.bool_0;
					if (class5.long_0 < num4 || class5.string_0 != text)
					{
						bool_ = false;
						break;
					}
					num4 = class5.long_0;
				}
			}
			Task.WaitAll(task, task2);
			Class60 class6 = class4.class119_0.method_20();
			if (class6 != null && class6.long_0 < num4)
			{
				bool_ = false;
			}
			num += smethod_243("pick/reply/concurrent-publication-coherent", bool_);
			num += smethod_244("pick/reply/concurrent-sequence-count", 1000L, class4.class119_0.method_21());
		}
		finally
		{
			if (class4.class119_0 != null)
			{
				((IDisposable)class4.class119_0).Dispose();
			}
		}
		using (Class119 class7 = new Class119())
		{
			MethodInfo methodInfo = typeof(Class119).GetMethod("method_204", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			num += smethod_243("pick/reply/detach-fixture", methodInfo != null);
			if (methodInfo != null)
			{
				smethod_94(class7, "_pickArmed", true);
				class7.method_145(403u, 3, 13u, bool_17: true, null);
				long num5 = class7.method_22();
				methodInfo.Invoke(class7, new object[2]
				{
					7,
					IntPtr.Zero
				});
				num += smethod_243("pick/reply/detach-disarms-pick", !class7.method_136());
				num += smethod_243("pick/reply/detach-clears-publication", class7.method_20() == null);
				num += smethod_243("pick/reply/detach-advances-lifecycle", class7.method_22() > num5);
			}
		}
		return num;
	}

	private static int smethod_105()
	{
		Class199 @class = new Class199();
		int num = 0;
		Dictionary<string, string> dictionary_ = new Dictionary<string, string>(StringComparer.Ordinal)
		{
			{ "1:1", "Sword" },
			{ "2:1", "Potion" }
		};
		@class.class119_0 = new Class119();
		@class.list_0 = new List<string>();
		@class.class119_0.method_30(@class.method_0);
		Class83 class83_ = new Class83
		{
			float_0 = 0f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class2 = new Class403
		{
			uint_0 = 301u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 5f,
			float_1 = 2f,
			float_2 = 6f
		};
		@class.long_0 = 0L;
		Class222 class3 = new Class222(@class.class119_0);
		try
		{
			using (Class169.smethod_1(@class.method_1, 1000L))
			{
				class3.method_4(1, 18, bool_0: false, Array.Empty<string>());
				Class360.smethod_33();
				class3.method_2(bool_0: false);
				class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 1), bool_0: true);
				num += smethod_243("pick/retry/unavailable-declines", !Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/retry/unavailable-no-send", 0, @class.list_0.Count);
				class3.method_2(bool_0: true);
				for (int i = 1; i <= 5; i++)
				{
					class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, i), bool_0: true);
					bool result = Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
					num += smethod_243("pick/retry/initial-owns-" + i, result);
					num += smethod_244("pick/retry/initial-pick-count-" + i, i, @class.list_0.Count(Class299.class299_0.method_60));
					num += smethod_244("pick/retry/no-early-forced-move-" + i, 0, @class.list_0.Count(Class299.class299_0.method_61));
					@class.long_0 += 500L;
				}
				@class.list_0.Clear();
				Class360.smethod_33();
				@class.long_0 += 500L;
				for (int j = 1; j <= 5; j++)
				{
					class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 20 + j), bool_0: true);
					Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
					@class.long_0 += 500L;
				}
				Class403 item = new Class403
				{
					uint_0 = 301u,
					byte_0 = 101,
					ushort_0 = 2,
					ushort_1 = 1,
					float_0 = 5f,
					float_1 = 0f,
					float_2 = 0f
				};
				class3.method_0(smethod_113(new List<Class403> { item }, dictionary_, class83_, 26), bool_0: true);
				Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/retry/composite-id-reuse-resets", @class.list_0.Last().Contains("\"cmd\":\"pick\"") && @class.list_0.Last().Contains("\"id\":301"));
				Class403 item2 = new Class403
				{
					uint_0 = 302u,
					byte_0 = 101,
					ushort_0 = 2,
					ushort_1 = 1,
					float_0 = 7f,
					float_1 = 0f,
					float_2 = 0f
				};
				@class.list_0.Clear();
				Class360.smethod_33();
				class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 30), bool_0: true);
				Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
				@class.long_0 += 500L;
				class3.method_0(smethod_113(new List<Class403> { item2 }, dictionary_, class83_, 31), bool_0: true);
				Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/retry/disappearance-switches-target", @class.list_0.Count == 2 && @class.list_0[1].Contains("\"id\":302"));
				@class.list_0.Clear();
				Class360.smethod_33();
				class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 32), bool_0: true);
				Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
				@class.long_0 += 500L;
				Class403 item3 = new Class403
				{
					uint_0 = 303u,
					byte_0 = 101,
					ushort_0 = 2,
					ushort_1 = 1,
					float_0 = 2f,
					float_1 = 0f,
					float_2 = 0f
				};
				class3.method_0(smethod_113(new List<Class403> { class2, item3 }, dictionary_, class83_, 33), bool_0: true);
				Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/retry/pending-target-is-stable", @class.list_0.Count == 2 && @class.list_0[1].Contains("\"id\":301"));
				@class.list_0.Clear();
				Class360.smethod_33();
				for (int k = 1; k <= 5; k++)
				{
					class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 34 + k), bool_0: true);
					Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
					@class.long_0 += 500L;
				}
				class3.method_4(1, 19, bool_0: false, Array.Empty<string>());
				num += smethod_243("pick/retry/ineligible-declines", !Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				class3.method_4(1, 18, bool_0: false, Array.Empty<string>());
				class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 40), bool_0: true);
				Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/retry/ineligible-reset-starts-first-phase", @class.list_0.Last().Contains("\"cmd\":\"pick\""));
				@class.list_0.Clear();
				Class360.smethod_33();
				class3.method_4(1, 18, bool_0: false, Array.Empty<string>());
				for (int l = 1; l <= 5; l++)
				{
					class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 60 + l), bool_0: true);
					Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
					@class.long_0 += 500L;
				}
				class3.method_4(4, 18, bool_0: false, Array.Empty<string>());
				num += smethod_243("pick/retry/unfixed-follow-declines", !Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				class3.method_4(1, 18, bool_0: false, Array.Empty<string>());
				class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 66), bool_0: true);
				Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/retry/unfixed-follow-resets-first-phase", @class.list_0.Last().Contains("\"cmd\":\"pick\""));
				@class.list_0.Clear();
				Class360.smethod_33();
				for (int m = 1; m <= 5; m++)
				{
					class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 70 + m), bool_0: true);
					Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
					@class.long_0 += 500L;
				}
				class3.method_2(bool_0: false);
				num += smethod_243("pick/retry/availability-loss-declines", !Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				class3.method_2(bool_0: true);
				class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 76), bool_0: true);
				Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/retry/availability-loss-resets-first-phase", @class.list_0.Last().Contains("\"cmd\":\"pick\""));
				@class.list_0.Clear();
				Class360.smethod_33();
				for (int n = 1; n <= 5; n++)
				{
					class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 40 + n), bool_0: true);
					Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
					@class.long_0 += 500L;
				}
				Class360.smethod_33();
				class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 46), bool_0: true);
				Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/retry/lifecycle-reset-starts-first-phase", @class.list_0.Last().Contains("\"cmd\":\"pick\""));
				@class.list_0.Clear();
				Class360.smethod_33();
				for (int num2 = 1; num2 <= 5; num2++)
				{
					class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 50 + num2), bool_0: true);
					Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
					@class.long_0 += 500L;
				}
				Class119 class4 = new Class119();
				class4.method_30(@class.method_2);
				class3.method_1(class4, smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 56), bool_0: true);
				Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/retry/session-generation-resets-first-phase", @class.list_0.Last().Contains("\"cmd\":\"pick\""));
			}
		}
		finally
		{
			((IDisposable)class3).Dispose();
		}
		Class119 class5 = new Class119();
		@class.list_1 = new List<string>();
		@class.long_0 = 0L;
		Class222 class6 = new Class222(class5);
		try
		{
			using (Class169.smethod_1(@class.method_3, 1000L))
			{
				class6.method_4(1, 18, bool_0: false, Array.Empty<string>());
				Class360.smethod_33();
				for (int num3 = 1; num3 <= 5; num3++)
				{
					class6.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 80 + num3), bool_0: true);
					num += smethod_243("pick/retry/unposted-declines-" + num3, !Class360.smethod_1(class6.gform0_0, 20f).GetAwaiter().GetResult());
					@class.long_0 += 500L;
				}
				class5.method_30(@class.method_4);
				class6.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 86), bool_0: true);
				num += smethod_243("pick/retry/first-accepted-send-owns", Class360.smethod_1(class6.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_243("pick/retry/unposted-calls-not-counted", @class.list_1.Count == 1 && @class.list_1[0].Contains("\"cmd\":\"pick\""));
			}
		}
		finally
		{
			((IDisposable)class6).Dispose();
		}
		num += smethod_108(dictionary_, class83_, class2);
		num += smethod_107(dictionary_, class83_);
		num += smethod_106(dictionary_);
		num += smethod_110(dictionary_, class83_, class2);
		num += smethod_109();
		Class360.smethod_33();
		return num;
	}

	private static int smethod_106(Dictionary<string, string> dictionary_0)
	{
		Class279 @class = new Class279();
		@class.dictionary_0 = dictionary_0;
		int num = 0;
		@class.long_0 = 0L;
		@class.int_3 = 700;
		@class.class119_0 = new Class119();
		@class.list_0 = new List<string>();
		@class.queue_0 = new Queue<int>(new int[10] { 0, 0, 500000, 1500000, 1000000, 2000000, 1500000, 500000, 2000000, 1000000 });
		@class.class403_0 = new Class403
		{
			uint_0 = 701u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 5f,
			float_1 = 2f,
			float_2 = 6f
		};
		@class.class83_0 = new Class83
		{
			float_0 = 0f,
			float_1 = 2f,
			float_2 = 0f
		};
		@class.class222_0 = null;
		@class.int_0 = 0;
		@class.int_1 = 0;
		@class.int_2 = 0;
		@class.bool_0 = true;
		@class.bool_1 = false;
		@class.list_1 = new List<Tuple<float, float>>();
		@class.class119_0.method_30(@class.method_0);
		Func<int, Task> func_ = @class.method_1;
		Func<int, int, int> func_2 = @class.method_2;
		using (@class.class222_0 = new Class222(@class.class119_0))
		{
			using (Class169.smethod_3(@class.method_3, 1000L, null, func_, func_2))
			{
				@class.class222_0.method_4(1, 18, bool_0: false, Array.Empty<string>());
				Class360.smethod_33();
				for (int i = 1; i <= 5; i++)
				{
					@class.class222_0.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, ++@class.int_3), bool_0: true);
					Class360.smethod_1(@class.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
					@class.long_0 += 500L;
				}
				@class.class403_0 = new Class403
				{
					uint_0 = 701u,
					byte_0 = 101,
					ushort_0 = 1,
					ushort_1 = 1,
					float_0 = 8f,
					float_1 = 3f,
					float_2 = 9f
				};
				@class.class222_0.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, ++@class.int_3), bool_0: true);
				bool result = Class360.smethod_1(@class.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/recovery/exact-wait-owns-no-attack", result);
				num += smethod_243("pick/recovery/no-pick-before-arrival", !@class.bool_1);
				num += smethod_244("pick/recovery/exact-boundary-polls", 2, @class.int_2);
				List<JObject> list = @class.list_0.Select(JObject.Parse).ToList();
				num += smethod_244("pick/recovery/exact-plus-first-cycle-command-count", 8, list.Count);
				num += smethod_243("pick/recovery/exact-move-latest-position", (string?)list[5]["cmd"] == "move" && (float)list[5]["x"] == 8f && (float)list[5]["y"] == 3f && (float)list[5]["z"] == 9f);
				num += smethod_243("pick/recovery/move-arrival-pick-order", (string?)list[6]["cmd"] == "move" && (string?)list[7]["cmd"] == "pick");
				for (int j = 2; j <= 5; j++)
				{
					@class.class403_0 = new Class403
					{
						uint_0 = 701u,
						byte_0 = 101,
						ushort_0 = 1,
						ushort_1 = 1,
						float_0 = 8f + (float)j,
						float_1 = 3f,
						float_2 = 9f + (float)j
					};
					@class.class222_0.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, ++@class.int_3), bool_0: true);
					num += smethod_243("pick/recovery/cycle-owns-no-attack-" + j, Class360.smethod_1(@class.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
				}
				list = @class.list_0.Select(JObject.Parse).ToList();
				List<JObject> list2 = list.Where(Class299.class299_0.method_62).Skip(1).ToList();
				num += smethod_244("pick/recovery/five-random-moves", 5, list2.Count);
				num += smethod_244("pick/recovery/five-recovery-picks", 10, list.Count(Class299.class299_0.method_63));
				HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
				bool flag = list2.Count == @class.list_1.Count;
				for (int k = 0; k < list2.Count && k < @class.list_1.Count; k++)
				{
					float num2 = (float)list2[k]["x"] - @class.list_1[k].Item1;
					float num3 = (float)list2[k]["z"] - @class.list_1[k].Item2;
					flag = flag && num2 >= -1f && num2 <= 1f && num3 >= -1f && num3 <= 1f;
					hashSet.Add(num2.ToString("R", CultureInfo.InvariantCulture) + ":" + num3.ToString("R", CultureInfo.InvariantCulture));
				}
				num += smethod_243("pick/recovery/random-offsets-bounded", flag);
				num += smethod_244("pick/recovery/random-offsets-distinct", 5, hashSet.Count);
				Class403 item = new Class403
				{
					uint_0 = 702u,
					byte_0 = 101,
					ushort_0 = 2,
					ushort_1 = 1,
					float_0 = @class.class83_0.float_0,
					float_1 = @class.class83_0.float_1,
					float_2 = @class.class83_0.float_2
				};
				@class.class222_0.method_0(smethod_113(new List<Class403> { @class.class403_0, item }, @class.dictionary_0, @class.class83_0, ++@class.int_3), bool_0: true);
				num += smethod_243("pick/recovery/blacklist-pass-still-owned", Class360.smethod_1(@class.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_243("pick/recovery/blacklist-selects-next", @class.list_0.Last().Contains("\"cmd\":\"pick\"") && @class.list_0.Last().Contains("\"id\":702"));
				long num4 = @class.long_0;
				@class.list_0.Clear();
				@class.long_0 = num4 + 59999L;
				@class.class222_0.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, ++@class.int_3), bool_0: true);
				num += smethod_243("pick/recovery/blacklist-59999-declines", !Class360.smethod_1(@class.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/recovery/blacklist-59999-no-send", 0, @class.list_0.Count);
				@class.long_0 = num4 + 60000L;
				@class.class222_0.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, ++@class.int_3), bool_0: true);
				num += smethod_243("pick/recovery/blacklist-60000-expires", Class360.smethod_1(@class.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_243("pick/recovery/expired-starts-first-pick", @class.list_0.Count == 1 && @class.list_0[0].Contains("\"cmd\":\"pick\"") && @class.list_0[0].Contains("\"id\":701"));
			}
		}
		@class.class119_1 = new Class119();
		@class.list_2 = new List<string>();
		@class.class403_1 = new Class403
		{
			uint_0 = 711u,
			byte_0 = 102,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		@class.class83_1 = new Class83
		{
			float_0 = 0f,
			float_1 = 0f,
			float_2 = 0f
		};
		@class.class222_1 = null;
		@class.long_0 = 0L;
		@class.int_3 = 800;
		@class.bool_2 = false;
		@class.class119_1.method_30(@class.method_4);
		Func<int, Task> func_3 = @class.method_5;
		using (@class.class222_1 = new Class222(@class.class119_1))
		{
			using (Class169.smethod_3(@class.method_6, 1000L, null, func_3, Class299.class299_0.method_64))
			{
				@class.class222_1.method_4(1, 18, bool_0: false, Array.Empty<string>());
				Class360.smethod_33();
				for (int l = 1; l <= 5; l++)
				{
					@class.class222_1.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
					Class360.smethod_1(@class.class222_1.gform0_0, 20f).GetAwaiter().GetResult();
					@class.long_0 += 500L;
				}
				@class.bool_2 = true;
				@class.class222_1.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				int gparam_ = @class.list_2.Count(Class299.class299_0.method_65);
				num += smethod_243("pick/recovery/disappearance-during-move-owns", Class360.smethod_1(@class.class222_1.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/recovery/disappearance-no-pick", gparam_, @class.list_2.Count(Class299.class299_0.method_66));
				@class.bool_2 = false;
				@class.class222_1.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				Class360.smethod_1(@class.class222_1.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/recovery/disappearance-resets-without-blacklist", @class.list_2.Last().Contains("\"cmd\":\"pick\""));
			}
		}
		@class.class119_2 = new Class119();
		@class.list_3 = new List<string>();
		@class.class222_2 = null;
		@class.long_0 = 0L;
		@class.int_3 = 900;
		@class.bool_3 = false;
		@class.class119_2.method_30(@class.method_7);
		using (@class.class222_2 = new Class222(@class.class119_2))
		{
			using (Class169.smethod_3(@class.method_8, 1000L, null, @class.method_9, Class299.class299_0.method_67))
			{
				@class.class222_2.method_4(1, 18, bool_0: false, Array.Empty<string>());
				Class360.smethod_33();
				for (int m = 1; m <= 5; m++)
				{
					@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
					Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult();
					@class.long_0 += 500L;
				}
				@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				int gparam_2 = @class.list_3.Count(Class299.class299_0.method_68);
				num += smethod_243("pick/recovery/timeout-owns-no-attack", Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/recovery/timeout-no-pick", gparam_2, @class.list_3.Count(Class299.class299_0.method_69));
				long num5 = @class.long_0;
				@class.list_3.Clear();
				@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				num += smethod_243("pick/recovery/money-timeout-blacklisted", !Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/recovery/money-timeout-no-send", 0, @class.list_3.Count);
				@class.long_0 = num5 + 59999L;
				@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				num += smethod_243("pick/recovery/money-timeout-blocks-full-minute", !Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult());
				@class.long_0 = num5 + 60000L;
				@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/recovery/money-timeout-expires", @class.list_3.Last().Contains("\"cmd\":\"pick\""));
				for (int n = 2; n <= 5; n++)
				{
					@class.long_0 += 500L;
					@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
					Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult();
				}
				@class.bool_3 = true;
				@class.long_0 += 500L;
				@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				int gparam_3 = @class.list_3.Count(Class299.class299_0.method_70);
				num += smethod_243("pick/recovery/stop-during-move-owns", Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/recovery/stop-during-move-no-pick", gparam_3, @class.list_3.Count(Class299.class299_0.method_71));
				@class.class222_2.gform0_0.bool_3 = false;
				@class.bool_3 = false;
				@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/recovery/stop-resets-without-blacklist", @class.list_3.Last().Contains("\"cmd\":\"pick\""));
				for (int num6 = 2; num6 <= 5; num6++)
				{
					@class.long_0 += 500L;
					@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
					Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult();
				}
				@class.class119_2.method_30(null);
				@class.long_0 += 500L;
				@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				int gparam_4 = @class.list_3.Count(Class299.class299_0.method_72);
				num += smethod_243("pick/recovery/move-post-failure-owns", Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/recovery/move-post-failure-no-pick", gparam_4, @class.list_3.Count(Class299.class299_0.method_73));
				@class.class119_2.method_30(@class.method_10);
				@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/recovery/move-post-failure-resets-without-blacklist", @class.list_3.Last().Contains("\"cmd\":\"pick\""));
			}
		}
		@class.class119_3 = new Class119();
		@class.class119_4 = new Class119();
		@class.list_4 = new List<string>();
		@class.class222_3 = null;
		@class.long_0 = 0L;
		@class.int_3 = 1000;
		@class.class119_3.method_30(@class.method_11);
		@class.class119_4.method_30(@class.method_12);
		@class.bool_4 = false;
		Func<int, Task> func_4 = @class.method_13;
		using (@class.class222_3 = new Class222(@class.class119_3))
		{
			using (Class169.smethod_3(@class.method_14, 1000L, null, func_4, Class299.class299_0.method_74))
			{
				@class.class222_3.method_4(1, 18, bool_0: false, Array.Empty<string>());
				Class360.smethod_33();
				for (int num7 = 1; num7 <= 5; num7++)
				{
					@class.class222_3.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
					Class360.smethod_1(@class.class222_3.gform0_0, 20f).GetAwaiter().GetResult();
					@class.long_0 += 500L;
				}
				@class.bool_4 = true;
				@class.class222_3.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				int gparam_5 = @class.list_4.Count(Class299.class299_0.method_75);
				num += smethod_243("pick/recovery/session-change-during-move-owns", Class360.smethod_1(@class.class222_3.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/recovery/session-change-no-pick", gparam_5, @class.list_4.Count(Class299.class299_0.method_76));
				Class360.smethod_1(@class.class222_3.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/recovery/session-change-resets-first-pick", @class.list_4.Last().Contains("\"cmd\":\"pick\""));
			}
		}
		Class360.smethod_33();
		return num;
	}

	private static int smethod_107(Dictionary<string, string> dictionary_0, Class83 class83_0)
	{
		Class239 @class = new Class239();
		@class.dictionary_0 = dictionary_0;
		@class.class83_0 = class83_0;
		int num = 0;
		@class.long_0 = 0L;
		@class.class403_1 = new Class403
		{
			uint_0 = 501u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 15f,
			float_1 = 0f,
			float_2 = 0f
		};
		@class.class403_0 = new Class403
		{
			uint_0 = 501u,
			byte_0 = 101,
			ushort_0 = 1,
			ushort_1 = 1,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class119 class2 = new Class119();
		@class.list_0 = new List<string>();
		class2.method_30(@class.method_0);
		Class313 class3 = new Class313();
		class3.class239_0 = @class;
		class3.class222_0 = new Class222(class2);
		try
		{
			using (Class169.smethod_2(class3.class239_0.method_1, 1000L, class3.method_0))
			{
				class3.class222_0.method_4(1, 18, bool_0: false, Array.Empty<string>());
				class3.class222_0.method_0(smethod_113(new List<Class403> { class3.class239_0.class403_1 }, class3.class239_0.dictionary_0, class3.class239_0.class83_0, 400), bool_0: true);
				Class360.smethod_33();
				typeof(Class412).GetField("_id", BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, 77u);
				Class360.smethod_1(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
				Class360.smethod_1(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_244("pick/command-adjacent/new-target-stops-attack-once", 1, class3.class239_0.list_0.Count(Class299.class299_0.method_77));
				num += smethod_243("pick/command-adjacent/far-to-near-picks", class3.class239_0.list_0.Count(Class299.class299_0.method_78) == 1);
			}
		}
		finally
		{
			if (class3.class222_0 != null)
			{
				((IDisposable)class3.class222_0).Dispose();
			}
		}
		Class119 class4 = new Class119();
		@class.list_1 = new List<string>();
		class4.method_30(@class.method_2);
		Class233 class5 = new Class233();
		class5.class239_0 = @class;
		class5.class222_0 = new Class222(class4);
		try
		{
			using (Class169.smethod_2(class5.class239_0.method_3, 1000L, class5.method_0))
			{
				class5.class222_0.method_4(1, 18, bool_0: false, Array.Empty<string>());
				class5.class222_0.method_0(smethod_113(new List<Class403> { class5.class239_0.class403_0 }, class5.class239_0.dictionary_0, class5.class239_0.class83_0, 410), bool_0: true);
				Class360.smethod_33();
				Class360.smethod_1(class5.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/command-adjacent/near-to-far-moves", class5.class239_0.list_1.Count == 1 && class5.class239_0.list_1[0].Contains("\"cmd\":\"move\""));
				return num + smethod_244("pick/command-adjacent/move-does-not-pick", 0, class5.class239_0.list_1.Count(Class299.class299_0.method_79));
			}
		}
		finally
		{
			if (class5.class222_0 != null)
			{
				((IDisposable)class5.class222_0).Dispose();
			}
		}
	}

	private static int smethod_108(Dictionary<string, string> dictionary_0, Class83 class83_0, Class403 class403_0)
	{
		Class273 @class = new Class273();
		@class.class403_0 = class403_0;
		@class.dictionary_0 = dictionary_0;
		@class.class83_0 = class83_0;
		int num = 0;
		@class.long_0 = 0L;
		@class.class119_0 = new Class119();
		@class.list_0 = new List<string>();
		@class.class119_0.method_30(@class.method_0);
		Class222 class2 = new Class222(@class.class119_0);
		try
		{
			using (Class169.smethod_1(@class.method_1, 1000L))
			{
				class2.method_4(1, 18, bool_0: false, Array.Empty<string>());
				Class360.smethod_33();
				for (int i = 0; i < 10; i++)
				{
					class2.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, 100 + i), bool_0: true);
					Class360.smethod_1(class2.gform0_0, 20f).GetAwaiter().GetResult();
					@class.long_0 += 500L;
				}
				num += smethod_244("pick/reply/refused-ten-picks", 10, @class.list_0.Count(Class299.class299_0.method_80));
				num += smethod_244("pick/reply/refused-never-forces-move", 0, @class.list_0.Count(Class299.class299_0.method_81));
			}
		}
		finally
		{
			((IDisposable)class2).Dispose();
		}
		Class119 class3 = new Class119();
		@class.list_1 = new List<string>();
		class3.method_30(@class.method_2);
		@class.long_0 = 0L;
		Class222 class4 = new Class222(class3);
		try
		{
			using (Class169.smethod_1(@class.method_3, 1000L))
			{
				class4.method_4(1, 18, bool_0: false, Array.Empty<string>());
				class4.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, 200), bool_0: true);
				Class360.smethod_33();
				class3.method_145(@class.class403_0.uint_0, 3, 1u, bool_17: true, null);
				Class360.smethod_1(class4.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_244("pick/reply/stale-before-send-ignored", 1, @class.list_1.Count);
				uint uint_ = (uint)JObject.Parse(@class.list_1[0])["req"];
				class3.method_145(@class.class403_0.uint_0, 3, 0u, bool_17: true, null);
				@class.long_0 = 250L;
				num += smethod_243("pick/reply/legacy-missing-token-owns", Class360.smethod_1(class4.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/reply/legacy-missing-token-not-counted", 1, @class.list_1.Count);
				class3.method_145(999u, 3, uint_, bool_17: true, null);
				@class.long_0 = 500L;
				num += smethod_243("pick/reply/unrelated-owns-without-resend", Class360.smethod_1(class4.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/reply/unrelated-no-resend", 1, @class.list_1.Count);
				class3.method_145(@class.class403_0.uint_0, 3, uint_, bool_17: true, null);
				num += smethod_243("pick/reply/async-ok-same-census-owns", Class360.smethod_1(class4.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/reply/async-ok-same-census-no-resend", 1, @class.list_1.Count);
				@class.long_0 = 1000L;
				class4.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, 201), bool_0: true);
				Class360.smethod_1(class4.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_244("pick/reply/later-census-advances-one-attempt", 2, @class.list_1.Count);
				uint uint_2 = (uint)JObject.Parse(@class.list_1[1])["req"];
				class3.method_145(@class.class403_0.uint_0, 3, uint_2, bool_17: true, null);
				@class.long_0 = 1500L;
				class4.method_0(smethod_113(new List<Class403>(), @class.dictionary_0, @class.class83_0, 202), bool_0: true);
				num += smethod_243("pick/reply/disappearance-after-ok-declines", !Class360.smethod_1(class4.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/reply/disappearance-no-extra-command", 2, @class.list_1.Count);
			}
		}
		finally
		{
			((IDisposable)class4).Dispose();
		}
		Class119 class5 = new Class119();
		@class.list_2 = new List<string>();
		class5.method_30(@class.method_4);
		@class.long_0 = 0L;
		Class222 class6 = new Class222(class5);
		try
		{
			using (Class169.smethod_1(@class.method_5, 1000L))
			{
				class6.method_4(1, 18, bool_0: false, Array.Empty<string>());
				class6.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, 300), bool_0: true);
				Class360.smethod_33();
				Class360.smethod_1(class6.gform0_0, 20f).GetAwaiter().GetResult();
				@class.long_0 = 2999L;
				class6.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, 301), bool_0: true);
				num += smethod_243("pick/reply/lost-before-timeout-owns", Class360.smethod_1(class6.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/reply/lost-before-timeout-no-resend", 1, @class.list_2.Count);
				@class.long_0 = 3000L;
				num += smethod_243("pick/reply/lost-at-timeout-retries", Class360.smethod_1(class6.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/reply/lost-timeout-not-counted", 2, @class.list_2.Count);
				num += smethod_244("pick/reply/lost-timeout-no-move", 0, @class.list_2.Count(Class299.class299_0.method_82));
			}
		}
		finally
		{
			((IDisposable)class6).Dispose();
		}
		@class.class119_1 = new Class119();
		@class.list_3 = new List<string>();
		@class.long_0 = 0L;
		Class334 class7 = new Class334();
		class7.class273_0 = @class;
		class7.class222_0 = new Class222(class7.class273_0.class119_1);
		try
		{
			using (Class169.smethod_1(class7.class273_0.method_6, 1000L))
			{
				class7.class222_0.method_4(1, 18, bool_0: false, Array.Empty<string>());
				class7.class222_0.method_0(smethod_113(new List<Class403> { class7.class273_0.class403_0 }, class7.class273_0.dictionary_0, class7.class273_0.class83_0, 320), bool_0: true);
				class7.bool_0 = false;
				class7.class273_0.class119_1.method_30(class7.method_0);
				Class360.smethod_33();
				Class360.smethod_1(class7.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_244("pick/reply/post-boundary-first-send", 1, class7.class273_0.list_3.Count);
				num += smethod_243("pick/reply/post-boundary-intermediate-census-owns", Class360.smethod_1(class7.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/reply/post-boundary-intermediate-census-not-counted", 1, class7.class273_0.list_3.Count);
				class7.class273_0.long_0 = 1500L;
				class7.class222_0.method_0(smethod_113(new List<Class403> { class7.class273_0.class403_0 }, class7.class273_0.dictionary_0, class7.class273_0.class83_0, 322), bool_0: true);
				Class360.smethod_1(class7.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_244("pick/reply/post-boundary-subsequent-census-counted", 2, class7.class273_0.list_3.Count);
			}
		}
		finally
		{
			if (class7.class222_0 != null)
			{
				((IDisposable)class7.class222_0).Dispose();
			}
		}
		Class119 class8 = new Class119();
		@class.list_4 = new List<string>();
		class8.method_30(@class.method_7);
		@class.long_0 = 0L;
		Class222 class9 = new Class222(class8);
		try
		{
			using (Class169.smethod_1(@class.method_8, 1000L))
			{
				class9.method_4(1, 18, bool_0: false, Array.Empty<string>());
				class9.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, 350), bool_0: true);
				Class360.smethod_33();
				Class360.smethod_1(class9.gform0_0, 20f).GetAwaiter().GetResult();
				uint num2 = (uint)JObject.Parse(@class.list_4[0])["req"];
				@class.long_0 = 2000L;
				class9.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, 351), bool_0: true);
				Class360.smethod_1(class9.gform0_0, 20f).GetAwaiter().GetResult();
				uint num3 = (uint)JObject.Parse(@class.list_4[1])["req"];
				num += smethod_243("pick/reply/retry-token-changes", num3 != 0 && num3 != num2);
				class8.method_145(@class.class403_0.uint_0, 3, num2, bool_17: true, null);
				@class.long_0 = 2500L;
				class9.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, 352), bool_0: true);
				num += smethod_243("pick/reply/delayed-old-token-still-owns", Class360.smethod_1(class9.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/reply/delayed-old-token-not-counted", 2, @class.list_4.Count);
				class8.method_145(@class.class403_0.uint_0, 3, num3, bool_17: true, null);
				num += smethod_243("pick/reply/current-token-later-census-owns", Class360.smethod_1(class9.gform0_0, 20f).GetAwaiter().GetResult());
				return num + smethod_244("pick/reply/current-token-later-census-advances", 3, @class.list_4.Count);
			}
		}
		finally
		{
			((IDisposable)class9).Dispose();
		}
	}

	private static int smethod_109()
	{
		int num = 0;
		Type nestedType = typeof(Class360).GetNestedType("PickIdentity", BindingFlags.NonPublic);
		MethodInfo methodInfo = ((nestedType == null) ? null : nestedType.GetMethod("From", BindingFlags.Static | BindingFlags.NonPublic));
		MethodInfo methodInfo2 = typeof(Class360).GetMethod("smethod_23", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		MethodInfo methodInfo3 = typeof(Class360).GetMethod("smethod_24", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		FieldInfo field = typeof(Class360).GetField("_blacklist", BindingFlags.Static | BindingFlags.NonPublic);
		num += smethod_243("pick/blacklist/cap-fixture", nestedType != null && methodInfo != null && methodInfo2 != null && methodInfo3 != null && field != null);
		if (!(nestedType == null) && !(methodInfo == null) && !(methodInfo2 == null) && !(methodInfo3 == null) && !(field == null))
		{
			Class360.smethod_33();
			object obj = null;
			for (uint num2 = 1u; num2 <= 257; num2++)
			{
				obj = methodInfo.Invoke(null, new object[1]
				{
					new Class403
					{
						uint_0 = num2,
						byte_0 = 101,
						ushort_0 = 1,
						ushort_1 = 1
					}
				});
				methodInfo2.Invoke(null, new object[3] { obj, 0L, 1000L });
			}
			IDictionary dictionary = (IDictionary)field.GetValue(null);
			num += smethod_244("pick/blacklist/capped-at-256", 256, dictionary.Count);
			num += smethod_243("pick/blacklist/keeps-newest", dictionary.Contains(obj));
			methodInfo3.Invoke(null, new object[1] { 60000L });
			num += smethod_244("pick/blacklist/prunes-expired", 0, dictionary.Count);
			Class360.smethod_33();
			return num;
		}
		return num;
	}

	private static int smethod_110(Dictionary<string, string> dictionary_0, Class83 class83_0, Class403 class403_0)
	{
		Class213 @class = new Class213();
		int num = 0;
		@class.long_0 = 0L;
		Class119 class2 = new Class119();
		@class.list_0 = new List<string>();
		class2.method_30(@class.method_0);
		Class222 class3 = new Class222(class2);
		try
		{
			using (Class169.smethod_1(@class.method_1, 1000L))
			{
				class3.method_4(1, 18, bool_0: false, Array.Empty<string>());
				Class360.smethod_33();
				class3.method_0(smethod_113(new List<Class403>(), dictionary_0, class83_0, 600), bool_0: true);
				Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
				Type nestedType = typeof(Class360).GetNestedType("PickIdentity", BindingFlags.NonPublic);
				MethodInfo methodInfo = ((nestedType == null) ? null : nestedType.GetMethod("From", BindingFlags.Static | BindingFlags.NonPublic));
				MethodInfo methodInfo2 = typeof(Class360).GetMethod("smethod_23", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				num += smethod_243("pick/lifecycle/blacklist-fixture", nestedType != null && methodInfo != null && methodInfo2 != null);
				if (nestedType == null || methodInfo == null || methodInfo2 == null)
				{
					return num;
				}
				object obj = methodInfo.Invoke(null, new object[1] { class403_0 });
				methodInfo2.Invoke(null, new object[3] { obj, @class.long_0, 1000L });
				class3.method_0(smethod_113(new List<Class403> { class403_0 }, dictionary_0, class83_0, 601), bool_0: true);
				num += smethod_243("pick/lifecycle/active-blacklist-declines", !Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/lifecycle/active-blacklist-no-send", 0, @class.list_0.Count);
				Class403 item = new Class403
				{
					uint_0 = 699u,
					byte_0 = 101,
					ushort_0 = 2,
					ushort_1 = 1,
					float_0 = class83_0.float_0,
					float_1 = class83_0.float_1,
					float_2 = class83_0.float_2
				};
				class2.method_30(null);
				class3.method_0(smethod_113(new List<Class403> { class403_0, item }, dictionary_0, class83_0, 602), bool_0: true);
				num += smethod_243("pick/lifecycle/post-failure-declines", !Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				class2.method_30(@class.method_2);
				class3.method_0(smethod_113(new List<Class403> { class403_0 }, dictionary_0, class83_0, 603), bool_0: true);
				num += smethod_243("pick/lifecycle/post-failure-keeps-active-blacklist", !Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244("pick/lifecycle/post-failure-blacklist-no-send", 0, @class.list_0.Count);
				long num2 = class2.method_22();
				class2.method_210();
				smethod_94(class2, "_pickArmed", true);
				num += smethod_243("pick/lifecycle/close-changes-generation", class2.method_22() > num2);
				@class.long_0 = 500L;
				class3.method_0(smethod_113(new List<Class403> { class403_0 }, dictionary_0, class83_0, 604), bool_0: true);
				num += smethod_243("pick/lifecycle/reset-clears-blacklist", Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_243("pick/lifecycle/reset-starts-fresh-pick", @class.list_0.Count == 1 && @class.list_0[0].Contains("\"cmd\":\"pick\""));
			}
		}
		finally
		{
			((IDisposable)class3).Dispose();
		}
		Class360.smethod_33();
		return num;
	}

	private static int smethod_111()
	{
		using (Class169.smethod_1(Stopwatch.GetTimestamp, Stopwatch.Frequency))
		{
			return smethod_112();
		}
	}

	private static int smethod_112()
	{
		Class293 @class = new Class293();
		int num = 0;
		Dictionary<string, string> dictionary_ = new Dictionary<string, string>(StringComparer.Ordinal) { { "1:1", "Sword" } };
		Class119 class2 = new Class119();
		@class.list_0 = new List<string>();
		class2.method_30(@class.method_0);
		Class83 class83_ = new Class83
		{
			float_0 = 0f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class253 class3 = new Class253();
		class3.class222_0 = new Class222(class2);
		try
		{
			Class311 class4 = new Class311();
			class4.class253_0 = class3;
			Class403 item = new Class403
			{
				uint_0 = 201u,
				byte_0 = 101,
				ushort_0 = 1,
				ushort_1 = 1,
				float_0 = 20f,
				float_1 = 0f,
				float_2 = 0f
			};
			class4.class253_0.class222_0.method_4(1, 18, bool_0: false, Array.Empty<string>());
			class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item }, dictionary_, class83_, 1), bool_0: true);
			Class360.smethod_33();
			bool result = Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243("pick/live/padded-radius-owns", result);
			num += smethod_244("pick/live/padded-radius-move-count", 1, @class.list_0.Count);
			num += smethod_243("pick/live/padded-radius-move-target", @class.list_0.Count == 1 && @class.list_0[0].Contains("\"cmd\":\"move\"") && @class.list_0[0].Contains("\"x\":20"));
			@class.list_0.Clear();
			Class403 item2 = new Class403
			{
				uint_0 = 202u,
				byte_0 = 1,
				float_0 = 10.1f,
				float_1 = 0f,
				float_2 = 0f
			};
			class4.class253_0.class222_0.method_4(1, 18, bool_0: true, Array.Empty<string>());
			class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item, item2 }, dictionary_, class83_, 1), bool_0: true);
			Class360.smethod_33();
			bool result2 = Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243("pick/live/kill-first-base-radius-allows-outside", result2);
			num += smethod_244("pick/live/kill-first-base-radius-command", 1, @class.list_0.Count);
			@class.list_0.Clear();
			Class403 item3 = new Class403
			{
				uint_0 = 203u,
				byte_0 = 1,
				float_0 = 10f,
				float_1 = 0f,
				float_2 = 0f
			};
			class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item, item3 }, dictionary_, class83_, 1), bool_0: true);
			Class360.smethod_33();
			num += smethod_243("pick/live/kill-first-base-radius-blocks-inside", !Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_244("pick/live/kill-first-base-radius-no-command", 0, @class.list_0.Count);
			@class.list_0.Clear();
			Class83 class83_2 = new Class83
			{
				float_0 = 100f,
				float_1 = 0f,
				float_2 = 0f
			};
			Class403 item4 = new Class403
			{
				uint_0 = 204u,
				byte_0 = 101,
				ushort_0 = 1,
				ushort_1 = 1,
				float_0 = 15f,
				float_1 = 0f,
				float_2 = 0f
			};
			class4.class253_0.class222_0.method_4(1, 18, bool_0: false, Array.Empty<string>());
			Class412.smethod_6(0f, 0f, 0f);
			class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item4 }, dictionary_, class83_2, 1), bool_0: true);
			Class360.smethod_33();
			num += smethod_243("pick/live/fixed-zone-owns-center-drop", Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_244("pick/live/fixed-zone-command", 1, @class.list_0.Count);
			@class.list_0.Clear();
			Class412.smethod_7();
			Class360.smethod_33();
			num += smethod_243("pick/live/roaming-gates-from-self", !Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_244("pick/live/roaming-no-command", 0, @class.list_0.Count);
			class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item }, dictionary_, class83_, 1), bool_0: true);
			class4.class253_0.class222_0.method_4(4, 18, bool_0: false, Array.Empty<string>());
			Class360.smethod_33();
			num += smethod_243("pick/live/radio4-unfixed-declines", !Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			class4.class253_0.class222_0.method_4(5, 18, bool_0: false, Array.Empty<string>());
			num += smethod_243("pick/live/radio5-unfixed-declines", !Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_244("pick/live/unfixed-radio-no-command", 0, @class.list_0.Count);
			@class.list_0.Clear();
			Class403 item5 = new Class403
			{
				uint_0 = 205u,
				byte_0 = 101,
				ushort_0 = 1,
				ushort_1 = 1,
				float_0 = 5f,
				float_1 = 0f,
				float_2 = 0f
			};
			class4.class253_0.class222_0.method_4(1, 18, bool_0: false, Array.Empty<string>());
			class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item5 }, dictionary_, class83_, 1), bool_0: true);
			Class360.smethod_33();
			bool result3 = Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			bool result4 = Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243("pick/live/first-in-reach-owns", result3);
			num += smethod_243("pick/live/throttle-keeps-ownership", result4);
			num += smethod_244("pick/live/throttle-sends-once", 1, @class.list_0.Count);
			@class.list_0.Clear();
			Class403 item6 = new Class403
			{
				uint_0 = 206u,
				byte_0 = 101,
				ushort_0 = 1,
				ushort_1 = 1,
				float_0 = 5f,
				float_1 = 0f,
				float_2 = 0f
			};
			Class403 item7 = new Class403
			{
				uint_0 = 206u,
				byte_0 = 101,
				ushort_0 = 1,
				ushort_1 = 1,
				float_0 = 15f,
				float_1 = 0f,
				float_2 = 0f
			};
			class4.class145_0 = smethod_113(new List<Class403> { item7 }, dictionary_, class83_, 1);
			class4.class253_0.class222_0.method_4(1, 20, bool_0: false, new string[1] { "Sword" });
			DataGridView dataGridView = class4.class253_0.class222_0.method_3();
			class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item6 }, dictionary_, class83_, 1), bool_0: true);
			dataGridView.Rows[0].Cells[0].Value = new Class290("Sword", class4.method_0);
			Class360.smethod_33();
			bool result5 = Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243("pick/live/ui-reresolves-replacement", result5);
			num += smethod_244("pick/live/ui-reresolves-one-command", 1, @class.list_0.Count);
			num += smethod_243("pick/live/ui-reresolves-new-target", @class.list_0.Count == 1 && @class.list_0[0].Contains("\"cmd\":\"move\"") && @class.list_0[0].Contains("\"x\":15"));
			@class.list_0.Clear();
			class4.class253_0.class222_0.gform0_0.bool_3 = false;
			class4.class253_0.class222_0.method_4(1, 20, bool_0: false, new string[1] { "Sword" });
			class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item5 }, dictionary_, class83_, 1), bool_0: true);
			dataGridView.Rows[0].Cells[0].Value = new Class290("Sword", class4.class253_0.method_0);
			Class360.smethod_33();
			num += smethod_243("pick/live/stop-after-ui-finishes-pass", Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_244("pick/live/stop-after-ui-current-command", 1, @class.list_0.Count);
			class4.class253_0.class222_0.gform0_0.bool_3 = false;
			@class.list_0.Clear();
			class4.class253_0.class222_0.method_4(1, 18, bool_0: false, Array.Empty<string>());
			class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item5 }, dictionary_, class83_, 1), bool_0: true);
			Class360.smethod_33();
			Task<bool> task = Task.Run((Func<Task<bool>>)class4.class253_0.method_1);
			num += smethod_243("pick/live/worker-ui-boundary-completes", smethod_96(task));
			if (task.IsCompleted)
			{
				num += smethod_243("pick/live/worker-ui-boundary-owns", task.GetAwaiter().GetResult());
			}
			num += smethod_244("pick/live/worker-ui-boundary-command", 1, @class.list_0.Count);
			@class.list_0.Clear();
			StringWriter stringWriter = new StringWriter();
			TextWriterTraceListener textWriterTraceListener = new TextWriterTraceListener(stringWriter);
			Debug.Listeners.Add(textWriterTraceListener);
			try
			{
				class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item5 }, dictionary_, class83_, 1), bool_0: true);
				Class360.smethod_33();
				Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
				Class403 item8 = new Class403
				{
					uint_0 = 207u,
					byte_0 = 102,
					float_0 = 6f,
					float_1 = 0f,
					float_2 = 0f
				};
				class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item8 }, dictionary_, class83_, 1), bool_0: true);
				Class360.smethod_33();
				Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
				textWriterTraceListener.Flush();
			}
			finally
			{
				Debug.Listeners.Remove(textWriterTraceListener);
				textWriterTraceListener.Dispose();
			}
			string text = stringWriter.ToString();
			num += smethod_243("pick/live/diagnostic-keeps-item-kind-name", text.IndexOf("kind=101 name=Sword", StringComparison.Ordinal) >= 0);
			num += smethod_243("pick/live/diagnostic-keeps-money-kind-name", text.IndexOf("kind=102 name=money", StringComparison.Ordinal) >= 0);
			num += smethod_243("pick/live/command-keeps-crow-type", @class.list_0.Count == 2 && @class.list_0[0].Contains("\"type\":3") && @class.list_0[1].Contains("\"type\":4"));
			FieldInfo field = typeof(Class145).GetField("<Items>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic);
			num += smethod_243("pick/live/final-stop-items-fixture", field != null);
			if (field != null)
			{
				@class.list_0.Clear();
				class4.class253_0.class222_0.gform0_0.bool_3 = false;
				Class403 item9 = new Class403
				{
					uint_0 = 208u,
					byte_0 = 101,
					ushort_0 = 1,
					ushort_1 = 1,
					float_0 = 15f,
					float_1 = 0f,
					float_2 = 0f
				};
				Class145 class5 = smethod_113(new List<Class403> { item9 }, dictionary_, class83_, 1);
				Class202<Class403> class6 = new Class202<Class403>(class5.method_6(), 3, class4.class253_0.method_2);
				field.SetValue(class5, class6);
				class4.class253_0.class222_0.method_4(1, 18, bool_0: false, Array.Empty<string>());
				class4.class253_0.class222_0.method_0(class5, bool_0: true);
				Class360.smethod_33();
				bool result6 = Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/live/final-stop-before-move-triggered", class6.method_0());
				num += smethod_243("pick/live/final-stop-before-move-finishes-pass", result6);
				num += smethod_244("pick/live/final-stop-before-move-current-command", 1, @class.list_0.Count);
				@class.list_0.Clear();
				class4.class253_0.class222_0.gform0_0.bool_3 = false;
				Class403 item10 = new Class403
				{
					uint_0 = 209u,
					byte_0 = 101,
					ushort_0 = 1,
					ushort_1 = 1,
					float_0 = 5f,
					float_1 = 0f,
					float_2 = 0f
				};
				Class145 class7 = smethod_113(new List<Class403> { item10 }, dictionary_, class83_, 1);
				Class202<Class403> class8 = new Class202<Class403>(class7.method_6(), 3, class4.class253_0.method_3);
				field.SetValue(class7, class8);
				class4.class253_0.class222_0.method_0(class7, bool_0: true);
				Class360.smethod_33();
				bool result7 = Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243("pick/live/final-stop-before-pick-triggered", class8.method_0());
				num += smethod_243("pick/live/final-stop-before-pick-finishes-pass", result7);
				num += smethod_244("pick/live/final-stop-before-pick-current-command", 1, @class.list_0.Count);
				class4.class253_0.class222_0.gform0_0.bool_3 = false;
				@class.list_0.Clear();
				Class145 class9 = smethod_113(new List<Class403> { item10 }, dictionary_, class83_, 300);
				Class202<Class403> class10 = new Class202<Class403>(class9.method_6(), 1, class4.class253_0.method_4);
				field.SetValue(class9, class10);
				class4.class253_0.class222_0.method_0(class9, bool_0: true);
				Class360.smethod_33();
				num += smethod_243("pick/live/snapshot-loss-during-selection-declines", !Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_243("pick/live/snapshot-loss-during-selection-triggered", class10.method_0());
				num += smethod_244("pick/live/snapshot-loss-during-selection-no-command", 0, @class.list_0.Count);
			}
		}
		finally
		{
			if (class3.class222_0 != null)
			{
				((IDisposable)class3.class222_0).Dispose();
			}
		}
		Class412.smethod_7();
		Class360.smethod_33();
		return num;
	}

	private static Class145 smethod_113(List<Class403> list_0, Dictionary<string, string> dictionary_0, Class83 class83_0, int int_0)
	{
		return Class145.class145_0.method_95(list_0, new Class95(null, dictionary_0, null), null, default(GStruct4), int_0, 0).method_93(class83_0, 1, 0);
	}

	private static DataGridView smethod_114(string[] string_0)
	{
		DataGridView dataGridView = new DataGridView();
		dataGridView.AllowUserToAddRows = false;
		dataGridView.Columns.Add("col0", "item");
		for (int i = 0; i < string_0.Length; i++)
		{
			dataGridView.Rows.Add(string_0[i]);
		}
		return dataGridView;
	}

	public static int smethod_115()
	{
		Class231 @class = new Class231();
		int num = 0;
		Class115 class2 = new Class115();
		DateTime dateTime_ = new DateTime(2026, 9, 25, 0, 0, 0, DateTimeKind.Utc);
		for (int i = 1; i <= 10; i++)
		{
			class2.method_10(i * 2 - 1, 100f, 200f, dateTime_);
			class2.method_14(i * 2, 100f, 200f, dateTime_.AddMilliseconds(800.0));
			num += smethod_244("stall/command-" + i, i, class2.method_0());
			num += smethod_244("stall/recover-only-after-ten-" + i, i == 10, class2.method_8());
			dateTime_ = dateTime_.AddSeconds(1.0);
		}
		class2.method_11();
		for (int j = 1; j <= 5; j++)
		{
			class2.method_12(100 + j * 2, 100f, 200f, dateTime_);
			class2.method_14(101 + j * 2, 100f, 200f, dateTime_.AddMilliseconds(800.0));
			num += smethod_244("stall/recovery-count-" + j, j, class2.method_2());
			num += smethod_244("stall/exhaust-only-after-five-" + j, j == 5, class2.method_9());
			dateTime_ = dateTime_.AddSeconds(1.0);
		}
		class2.method_15();
		class2.method_10(1L, 100f, 200f, dateTime_);
		class2.method_14(1L, 100f, 200f, dateTime_.AddSeconds(2.0));
		num += smethod_243("stall/stale-snapshot-does-not-complete-command", class2.method_4());
		class2.method_14(2L, 101f, 200f, dateTime_.AddSeconds(2.0));
		num += smethod_244("stall/real-movement-resets-attempts", 0, class2.method_0());
		num += smethod_244("seconds_disabled", 0, Class440.smethod_1(bool_0: false, "60"));
		num += smethod_244("seconds_value", 60, Class440.smethod_1(bool_0: true, "60"));
		num += smethod_244("seconds_junk", 0, Class440.smethod_1(bool_0: true, "x"));
		num += smethod_244("seconds_negative", 0, Class440.smethod_1(bool_0: true, "-5"));
		Struct76 struct76_ = new Struct76
		{
			float_0 = 12.5f,
			float_1 = 3.25f,
			float_2 = -7.5f,
			int_0 = 4,
			bool_0 = true
		};
		Struct76 struct76_2;
		bool bool_ = Class440.smethod_9(Class440.smethod_8(struct76_), out struct76_2);
		num += smethod_243("read_ok", bool_);
		num += smethod_243("roundtrip_x", Math.Abs(struct76_2.float_0 - struct76_.float_0) < 0.01f);
		num += smethod_243("roundtrip_z", Math.Abs(struct76_2.float_2 - struct76_.float_2) < 0.01f);
		num += smethod_243("roundtrip_y", Math.Abs(struct76_2.float_1 - struct76_.float_1) < 0.01f);
		num += smethod_244("roundtrip_delay", 4, struct76_2.int_0);
		num += smethod_243("roundtrip_nohit", struct76_2.bool_0);
		num += smethod_243("read_bad_x", !Class440.smethod_9(new string[5]
		{
			string.Empty,
			"1",
			"0",
			"False",
			"0"
		}, out var _));
		num += smethod_243("flag_true", Class440.smethod_7("True"));
		num += smethod_243("flag_false", !Class440.smethod_7("False"));
		List<Struct76> list_ = new List<Struct76>
		{
			new Struct76
			{
				float_0 = 0f,
				float_2 = 0f
			},
			new Struct76
			{
				float_0 = 10f,
				float_2 = 0f
			},
			new Struct76
			{
				float_0 = 50f,
				float_2 = 0f
			}
		};
		num += smethod_244("nearest", 1, Class440.smethod_17(list_, 9f, 0f));
		num += smethod_244("nearest_empty", -1, Class440.smethod_17(new List<Struct76>(), 0f, 0f));
		num += smethod_244("next_wrap", 0, Class440.smethod_18(2, 3));
		num += smethod_244("next_mid", 2, Class440.smethod_18(1, 3));
		num += smethod_244("next_empty", -1, Class440.smethod_18(0, 0));
		num += smethod_243("arrived_in", Class440.smethod_20(4.9f));
		num += smethod_243("arrived_out", !Class440.smethod_20(5.1f));
		num += smethod_243("cd_disabled", Class2.smethod_2("รอ", 0, DateTime.Now) == null);
		num += smethod_243("cd_notstarted", Class2.smethod_2("ต\u0e35", 10, DateTime.MinValue) == null);
		num += smethod_244("cd_clamp", "รอ 0.0s", Class2.smethod_2("รอ", 5, DateTime.Now.AddSeconds(-100.0)));
		num += smethod_243("cd_format", Class2.smethod_2("ค\u0e49าง", 30, DateTime.Now.AddSeconds(-2.0)).StartsWith("ค\u0e49าง "));
		bool[] array = new bool[5];
		int num2 = 0;
		int num3 = 0;
		for (int k = 0; k < 5; k++)
		{
			int num4 = Class2.smethod_1(5);
			if (num4 >= 0 && num4 < 5)
			{
				if (!array[num4])
				{
					array[num4] = true;
					num2++;
				}
			}
			else
			{
				num3++;
			}
		}
		num += smethod_244("rand_inrange", 0, num3);
		num += smethod_244("rand_perm", 5, num2);
		num += smethod_243("zone_in", Class406.smethod_3(3f, 0f, 4f, 0f, 0f, 0f, 5f));
		num += smethod_243("zone_out", !Class406.smethod_3(3f, 0f, 4.01f, 0f, 0f, 0f, 5f));
		num += smethod_243("zone_y", !Class406.smethod_3(0f, 6f, 0f, 0f, 0f, 0f, 5f));
		Class119 class3 = new Class119();
		@class.list_0 = new List<string>();
		class3.method_30(@class.method_0);
		class3.method_29(Class299.class299_0.method_83);
		Class222 class4 = new Class222(class3);
		try
		{
			DataGridView dataGridView_ = smethod_68(class4.gform0_0, "dataGridView1");
			smethod_71(class4.gform0_0, 4);
			smethod_72(class4.gform0_0, 0, 0, bool_0: false);
			smethod_69(dataGridView_, new Struct76[1]
			{
				new Struct76
				{
					float_0 = 10f,
					float_1 = 0f,
					float_2 = 0f,
					int_0 = 0,
					bool_0 = false
				}
			});
			class4.method_0(smethod_78(new List<Class403>(), new Class83
			{
				float_0 = 0f,
				float_1 = 0f,
				float_2 = 0f
			}), bool_0: true);
			Class412.smethod_15();
			typeof(Class412).GetField("_id", BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, 701u);
			bool result = Class2.smethod_0(class4.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243("followpos/walk-stops-attack-before-move", result && @class.list_0.Count == 4 && @class.list_0[0] == Class15.smethod_2() && @class.list_0[1] == Class346.smethod_0(2f, 0f, 0f, bool_0: false) && @class.list_0[2] == Class346.smethod_0(-2f, 0f, 0f, bool_0: false) && @class.list_0[3] == Class346.smethod_0(10f, 0f, 0f, bool_0: true) && !Class412.smethod_0());
		}
		finally
		{
			((IDisposable)class4).Dispose();
		}
		Class83 class83_ = new Class83
		{
			float_0 = 0f,
			float_1 = 0f,
			float_2 = 18f
		};
		Class403 class5 = new Class403
		{
			uint_0 = 1u,
			byte_0 = 101,
			byte_1 = 0,
			float_0 = 4f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class403 class6 = new Class403
		{
			uint_0 = 2u,
			byte_0 = 101,
			byte_1 = 0,
			float_0 = 0f,
			float_1 = 0f,
			float_2 = 20f
		};
		List<Class403> ireadOnlyList_ = new List<Class403> { class5, class6 };
		num += smethod_243("niz_gate_over_self", Class447.smethod_1(ireadOnlyList_, class83_, 0f, 0f, 0f, 5f, out var class403_, out var float_) && class403_ == class5);
		num += smethod_243("niz_vs_nearest_differ", Class447.smethod_0(ireadOnlyList_, class83_, 5f, out var class403_2, out var _) && class403_2 == class6);
		num += smethod_243("niz_excludes_lone_out", !Class447.smethod_1(new List<Class403> { class6 }, class83_, 0f, 0f, 0f, 5f, out class403_, out float_));
		Console.WriteLine("followpos: " + num + " failed");
		return num;
	}

	public static int smethod_116()
	{
		int num = 0;
		num = 0 + smethod_243("redzone/null-form", !Class406.smethod_2(null, 0f, 0f, 0f, 1f));
		Class222 @class = new Class222(new Class119());
		try
		{
			@class.method_0(Class145.class145_0.method_93(new Class83
			{
				float_0 = 0f,
				float_1 = 0f,
				float_2 = 0f
			}, 1, 0), bool_0: true);
			num += smethod_243("redzone/at-position-boundary", Class406.smethod_2(@class.gform0_0, 3f, 0f, 4f, 5f));
			num += smethod_243("redzone/at-position-y-counts", !Class406.smethod_2(@class.gform0_0, 0f, 5.1f, 0f, 5f));
			num += smethod_243("redzone/at-position-negative-radius", !Class406.smethod_2(@class.gform0_0, 0f, 0f, 0f, -1f));
			num += smethod_243("redzone/at-position-nan-target", !Class406.smethod_2(@class.gform0_0, float.NaN, 0f, 0f, 5f));
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		Console.WriteLine("redzone: " + num + " failed");
		return num;
	}

	public static int smethod_117()
	{
		int num = 0;
		num = 0 + smethod_243("dot_first", Class86.smethod_0(bool_0: false, 0, -1));
		num += smethod_243("dot_same", !Class86.smethod_0(bool_0: true, 1, 1));
		num += smethod_243("dot_changed", Class86.smethod_0(bool_0: true, 2, 1));
		num += smethod_243("line_first", Class86.smethod_1(bool_0: false, 0, -1, 0f, 0f, 0f, 0f));
		num += smethod_243("line_target", Class86.smethod_1(bool_0: true, 2, 1, 0f, 0f, 0f, 0f));
		num += smethod_243("line_move", Class86.smethod_1(bool_0: true, 1, 1, 5f, 0f, 0f, 0f));
		num += smethod_243("line_still", !Class86.smethod_1(bool_0: true, 1, 1, 3f, 0f, 0f, 0f));
		num += smethod_243("line_diag", Class86.smethod_1(bool_0: true, 1, 1, 3f, 3f, 0f, 0f));
		Class2.smethod_8();
		num += smethod_244("target_reset", -1, Class2.smethod_6());
		Console.WriteLine("waypoint: " + num + " failed");
		return num;
	}

	public static int smethod_118()
	{
		int num = 0;
		Class181 @class = new Class181();
		@class.method_3(51);
		num = 0 + smethod_243("recorder_first", @class.method_5(100f, 100f));
		num += smethod_243("recorder_near", !@class.method_5(139f, 100f));
		num += smethod_243("recorder_far", @class.method_5(140f, 100f));
		num += smethod_243("recorder_newlast", !@class.method_5(140f, 139f));
		Class455 class2 = new Class455();
		class2.int_0 = 51;
		class2.float_0 = new float[3] { 1f, 2f, 3f };
		class2.float_1 = new float[3] { 10f, 20f, 30f };
		class2.float_2 = new float[3] { 100f, 200f, 300f };
		Class455 class3 = class2;
		class2 = new Class455();
		class2.int_0 = 52;
		class2.float_0 = new float[2] { 4f, 5f };
		class2.float_1 = new float[2] { 40f, 50f };
		class2.float_2 = new float[2] { 400f, 500f };
		Class455 item = class2;
		List<Class455> list = Class189.smethod_1(Class189.smethod_0(new List<Class455> { class3, item }, new DateTime(2026, 9, 16)));
		num += smethod_243("pack_read_notnull", list != null);
		if (list != null)
		{
			num += smethod_244("pack_count", 2, list.Count);
			Class455 class4 = null;
			Class455 class5 = null;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].int_0 == 51)
				{
					class4 = list[i];
				}
				if (list[i].int_0 == 52)
				{
					class5 = list[i];
				}
			}
			num += smethod_243("pack_index51", class4 != null);
			num += smethod_243("pack_index52", class5 != null);
			num += smethod_243("pack_roundtrip", smethod_141(class4, class3));
		}
		num += smethod_243("pack_empty", Class189.smethod_1(string.Empty) == null);
		num += smethod_243("pack_garbage", Class189.smethod_1("not json at all") == null);
		List<Class455> list2 = Class189.smethod_1("{\"SaveDate\":\"2026-09-16T00:00:00\",\"GridData\":[{\"GridIndex\":51,\"Positions\":[{\"X\":1.0,\"Y\":2.0}]}]}");
		num += smethod_243("pack_missingz_one", list2 != null && list2.Count == 1);
		if (list2 != null && list2.Count == 1)
		{
			num += smethod_243("pack_missingz_zero", list2[0].float_2.Length == 1 && Math.Abs(list2[0].float_2[0]) < 0.0001f);
		}
		num += smethod_244("mk_ids_dot", "lr0", Class4.smethod_0(0));
		num += smethod_244("mk_ids_line", "ll0", Class4.smethod_1(0));
		Class4 class6 = new Class4();
		Struct78 @struct = class6.method_2(bool_0: true, 30, 1);
		num += smethod_243("mk_first_show", smethod_142(@struct.int_0, 0, 24));
		num += smethod_243("mk_first_showline", smethod_142(@struct.int_2, 0, 23));
		num += smethod_244("mk_first_hide", 0, @struct.int_1.Length);
		num += smethod_244("mk_first_hideline", 0, @struct.int_3.Length);
		Struct78 struct2 = class6.method_2(bool_0: true, 30, 2);
		num += smethod_243("mk_shift_show24", smethod_143(struct2.int_0, 24));
		num += smethod_243("mk_shift_hide0", smethod_143(struct2.int_1, 0));
		Struct78 struct3 = class6.method_2(bool_0: false, 30, 2);
		num += smethod_244("mk_off_show", 0, struct3.int_0.Length);
		num += smethod_243("mk_off_hideall", smethod_142(struct3.int_1, 1, 24));
		Struct78 struct4 = new Class4().method_2(bool_0: true, 1, 1);
		num += smethod_243("mk_single_show", smethod_142(struct4.int_0, 0, 1));
		num += smethod_244("mk_single_showline", 0, struct4.int_2.Length);
		List<int> ireadOnlyList_ = new List<int> { 51, 53, 66 };
		num += smethod_244("seq_wrap_51", 53, Class188.smethod_6(ireadOnlyList_, 51));
		num += smethod_244("seq_wrap_53", 66, Class188.smethod_6(ireadOnlyList_, 53));
		num += smethod_244("seq_wrap_66", 51, Class188.smethod_6(ireadOnlyList_, 66));
		num += smethod_244("seq_wrap_absent", 51, Class188.smethod_6(ireadOnlyList_, 52));
		List<int> ireadOnlyList_2 = new List<int> { 51, 52, 53 };
		Class188.smethod_16();
		bool[] array = new bool[3];
		int num2 = 0;
		int num3 = 0;
		for (int j = 0; j < 3; j++)
		{
			int num4 = Class188.smethod_7(ireadOnlyList_2) - 51;
			if (num4 >= 0 && num4 < 3)
			{
				if (!array[num4])
				{
					array[num4] = true;
					num2++;
				}
			}
			else
			{
				num3++;
			}
		}
		num += smethod_244("rand_inset", 0, num3);
		num += smethod_244("rand_cover", 3, num2);
		num += smethod_244("reach_first", 5f, Class440.smethod_21(0, 5));
		num += smethod_244("reach_mid", 35f, Class440.smethod_21(2, 5));
		num += smethod_244("reach_last", 5f, Class440.smethod_21(4, 5));
		num += smethod_244("reach_single", 5f, Class440.smethod_21(0, 1));
		Console.WriteLine("looper: " + num + " failed");
		return num;
	}

	public static int smethod_119()
	{
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), "capy_routepersist_" + Guid.NewGuid().ToString("N"));
		Struct76[] array = new Struct76[3]
		{
			new Struct76
			{
				float_0 = 100.5f,
				float_1 = 1.25f,
				float_2 = 200.75f
			},
			new Struct76
			{
				float_0 = 101f,
				float_1 = 2f,
				float_2 = 201f
			},
			new Struct76
			{
				float_0 = -50.25f,
				float_1 = 3.5f,
				float_2 = -60.5f
			}
		};
		try
		{
			Class67 @class = new Class67(text);
			DataGridView dataGridView = smethod_140();
			@class.method_7(dataGridView, "RoutePersistTest.json");
			@class.method_8("__routepersist_test__");
			using (@class.method_17(dataGridView))
			{
				for (int i = 0; i < array.Length; i++)
				{
					dataGridView.Rows.Add(Class440.smethod_2(array[i].float_0), Class440.smethod_2(array[i].float_1), Class440.smethod_2(array[i].float_2));
				}
			}
			num += smethod_243("routepersist_saved", @class.method_3() > 0);
			Class67 class2 = new Class67(text);
			DataGridView dataGridView2 = smethod_140();
			class2.method_7(dataGridView2, "RoutePersistTest.json");
			int gparam_ = class2.method_8("__routepersist_test__");
			num += smethod_244("routepersist_gridsloaded", 1, gparam_);
			num += smethod_244("routepersist_cols", 3, dataGridView2.Columns.Count);
			List<Struct76> list = Class440.smethod_16(dataGridView2);
			num += smethod_244("routepersist_count", array.Length, list.Count);
			if (list.Count == array.Length)
			{
				for (int j = 0; j < array.Length; j++)
				{
					num += smethod_243("routepersist_x" + j, Math.Abs(list[j].float_0 - array[j].float_0) < 0.01f);
					num += smethod_243("routepersist_y" + j, Math.Abs(list[j].float_1 - array[j].float_1) < 0.01f);
					num += smethod_243("routepersist_z" + j, Math.Abs(list[j].float_2 - array[j].float_2) < 0.01f);
				}
			}
		}
		finally
		{
			try
			{
				if (Directory.Exists(text))
				{
					Directory.Delete(text, recursive: true);
				}
			}
			catch
			{
			}
		}
		Console.WriteLine("routepersist: " + num + " failed");
		return num;
	}

	public static int smethod_120()
	{
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), "capy_listbtn_" + Guid.NewGuid().ToString("N"));
		try
		{
			DataGridView dataGridView_;
			DataGridView dataGridView_2;
			Class67 @class = smethod_121(text, "move_dv2_to_dv3", out dataGridView_, out dataGridView_2);
			using (@class.method_17(dataGridView_))
			{
				dataGridView_.Rows.Add("A");
				dataGridView_.Rows.Add("B");
				dataGridView_.Rows.Add("C");
			}
			smethod_123(dataGridView_, 0);
			num += smethod_244("move_dv2_to_dv3_sel", 1, dataGridView_.SelectedRows.Count);
			Class388.smethod_0(dataGridView_, dataGridView_2, @class);
			num += smethod_244("move_dv2_to_dv3_src", "B,C", smethod_124(dataGridView_));
			num += smethod_244("move_dv2_to_dv3_dst", "A", smethod_124(dataGridView_2));
			DataGridView dataGridView_3;
			DataGridView dataGridView_4;
			Class67 class2 = smethod_121(text, "move_dedup_target", out dataGridView_3, out dataGridView_4);
			using (class2.method_17(dataGridView_4))
			{
				dataGridView_4.Rows.Add("A");
			}
			using (class2.method_17(dataGridView_3))
			{
				dataGridView_3.Rows.Add("A");
			}
			smethod_123(dataGridView_3, 0);
			num += smethod_244("move_dedup_sel", 1, dataGridView_3.SelectedRows.Count);
			Class388.smethod_0(dataGridView_3, dataGridView_4, class2);
			num += smethod_244("move_dedup_src", string.Empty, smethod_124(dataGridView_3));
			num += smethod_244("move_dedup_dst", "A", smethod_124(dataGridView_4));
			DataGridView dataGridView_5;
			DataGridView dataGridView_6;
			Class67 class3 = smethod_121(text, "move_dv3_to_dv2", out dataGridView_5, out dataGridView_6);
			using (class3.method_17(dataGridView_6))
			{
				dataGridView_6.Rows.Add("A");
			}
			smethod_123(dataGridView_6, 0);
			num += smethod_244("move_dv3_to_dv2_sel", 1, dataGridView_6.SelectedRows.Count);
			Class388.smethod_0(dataGridView_6, dataGridView_5, class3);
			num += smethod_244("move_dv3_to_dv2_src", string.Empty, smethod_124(dataGridView_6));
			num += smethod_244("move_dv3_to_dv2_dst", "A", smethod_124(dataGridView_5));
			DataGridView dataGridView_7;
			DataGridView dataGridView_8;
			Class67 class4 = smethod_121(text, "del_grid_only_json_kept", out dataGridView_7, out dataGridView_8);
			using (class4.method_17(dataGridView_7))
			{
				dataGridView_7.Rows.Add("A");
				dataGridView_7.Rows.Add("B");
			}
			smethod_123(dataGridView_7, 0);
			num += smethod_244("del_sel", 1, dataGridView_7.SelectedRows.Count);
			Class388.smethod_2(dataGridView_7, class4);
			num += smethod_244("del_grid_after_drop", "B", smethod_124(dataGridView_7));
			class4.method_10(dataGridView_7);
			num += smethod_244("del_grid_reloaded", "A,B", smethod_124(dataGridView_7));
			DataGridView dataGridView_9;
			DataGridView dataGridView_10;
			Class67 class5 = smethod_121(text, "reload_excludes_pick", out dataGridView_9, out dataGridView_10);
			using (class5.method_17(dataGridView_9))
			{
				dataGridView_9.Rows.Add("A");
				dataGridView_9.Rows.Add("B");
			}
			using (class5.method_17(dataGridView_9))
			{
				dataGridView_9.Rows.Clear();
			}
			dataGridView_10.Rows.Add("A");
			class5.method_10(dataGridView_9);
			num += smethod_244("reload_naive", "A,B", smethod_124(dataGridView_9));
			Class388.smethod_1(dataGridView_9, dataGridView_10, class5);
			num += smethod_244("reload_excluded_src", "B", smethod_124(dataGridView_9));
			num += smethod_244("reload_excluded_pick", "A", smethod_124(dataGridView_10));
			DataGridView dataGridView_11;
			DataGridView dataGridView_12;
			Class67 class6 = smethod_121(text, "exclude_ignore_case", out dataGridView_11, out dataGridView_12);
			using (class6.method_17(dataGridView_12))
			{
				dataGridView_12.Rows.Add("apple");
			}
			using (class6.method_17(dataGridView_11))
			{
				dataGridView_11.Rows.Add("APPLE");
				dataGridView_11.Rows.Add("banana");
			}
			Class388.smethod_1(dataGridView_11, dataGridView_12, class6);
			num += smethod_244("exclude_ignore_case_src", "banana", smethod_124(dataGridView_11));
		}
		finally
		{
			try
			{
				if (Directory.Exists(text))
				{
					Directory.Delete(text, recursive: true);
				}
			}
			catch
			{
			}
		}
		Console.WriteLine("listbtn: " + num + " failed");
		return num;
	}

	private static Class67 smethod_121(string string_0, string string_1, out DataGridView dataGridView_0, out DataGridView dataGridView_1)
	{
		Class67 @class = new Class67(Path.Combine(string_0, string_1));
		dataGridView_0 = smethod_122();
		dataGridView_1 = smethod_122();
		@class.method_6(dataGridView_0, "all_items_used_test.json", bool_0: false);
		@class.method_7(dataGridView_1, "Pick_Item_test.json");
		@class.method_8("listbtn");
		return @class;
	}

	private static DataGridView smethod_122()
	{
		return new DataGridView
		{
			AllowUserToAddRows = false,
			ColumnHeadersVisible = false,
			SelectionMode = DataGridViewSelectionMode.FullRowSelect,
			Columns = { (DataGridViewColumn)new DataGridViewTextBoxColumn
			{
				Name = "itemName",
				HeaderText = "Item"
			} }
		};
	}

	private static void smethod_123(DataGridView dataGridView_0, int int_0)
	{
		dataGridView_0.ClearSelection();
		dataGridView_0.Rows[int_0].Selected = true;
	}

	private static string smethod_124(DataGridView dataGridView_0)
	{
		List<string> list = new List<string>();
		foreach (DataGridViewRow item in (IEnumerable)dataGridView_0.Rows)
		{
			if (!item.IsNewRow)
			{
				list.Add(Class388.smethod_8(item));
			}
		}
		list.Sort(StringComparer.Ordinal);
		return string.Join(",", list.ToArray());
	}

	public static int smethod_125()
	{
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), "capy_sellbtn_" + Guid.NewGuid().ToString("N"));
		try
		{
			string text2 = Path.Combine(text, "load_positional");
			smethod_137(text2, "all_items_used_test.json", "Column4", new string[3] { "Apple", "Bread", "Cherry" });
			Class67 @class = new Class67(text2);
			DataGridView dataGridView = smethod_138("dataGridViewTextBoxColumn56");
			num += smethod_244("sellbtn/load_unregistered_reads_nothing", 0, @class.method_10(dataGridView));
			num += smethod_244("sellbtn/load_unregistered_rows", string.Empty, smethod_124(dataGridView));
			num += smethod_243("sellbtn/load_by_name_applies", @class.method_19(dataGridView, "all_items_used_test.json"));
			num += smethod_244("sellbtn/load_by_name_adds_blanks", ",,", smethod_124(dataGridView));
			dataGridView.Rows.Clear();
			num += smethod_244("sellbtn/load_positional_added", 3, @class.method_11(dataGridView, "all_items_used_test.json"));
			num += smethod_244("sellbtn/load_positional_rows", "Apple,Bread,Cherry", smethod_124(dataGridView));
			num += smethod_244("sellbtn/load_positional_order", "Apple,Bread,Cherry", smethod_139(dataGridView));
			string text3 = Path.Combine(text, "load_merges");
			smethod_137(text3, "all_items_used_test.json", "Column4", new string[2] { "Apple", "Bread" });
			Class67 class2 = new Class67(text3);
			DataGridView dataGridView2 = smethod_138("dataGridViewTextBoxColumn56");
			dataGridView2.Rows.Add("Zither");
			num += smethod_244("sellbtn/merge_first_press", 2, class2.method_11(dataGridView2, "all_items_used_test.json"));
			num += smethod_244("sellbtn/merge_first_press_rows", "Apple,Bread,Zither", smethod_124(dataGridView2));
			num += smethod_244("sellbtn/merge_second_press", 0, class2.method_11(dataGridView2, "all_items_used_test.json"));
			num += smethod_244("sellbtn/merge_second_press_rows", "Apple,Bread,Zither", smethod_124(dataGridView2));
			dataGridView2.Rows.Clear();
			dataGridView2.Rows.Add("apple");
			num += smethod_244("sellbtn/merge_case_insensitive", 1, class2.method_11(dataGridView2, "all_items_used_test.json"));
			num += smethod_244("sellbtn/merge_case_insensitive_rows", "Bread,apple", smethod_124(dataGridView2));
			string text4 = Path.Combine(text, "load_newrow");
			smethod_137(text4, "all_items_used_test.json", "Column4", new string[2] { "Apple", "Bread" });
			Class67 class3 = new Class67(text4);
			DataGridView dataGridView3 = smethod_138("dataGridViewTextBoxColumn56");
			dataGridView3.AllowUserToAddRows = true;
			num += smethod_244("sellbtn/newrow_added", 2, class3.method_11(dataGridView3, "all_items_used_test.json"));
			num += smethod_244("sellbtn/newrow_rows", "Apple,Bread", smethod_124(dataGridView3));
			num += smethod_244("sellbtn/newrow_phantom_survives", 3, dataGridView3.Rows.Count);
			DataGridView dataGridView4 = smethod_138("dataGridViewTextBoxColumn55");
			dataGridView3.SelectAll();
			num += smethod_244("sellbtn/newrow_not_moved", 2, Class388.smethod_0(dataGridView3, dataGridView4, class3));
			num += smethod_244("sellbtn/newrow_not_moved_dst", "Apple,Bread", smethod_124(dataGridView4));
			Class67 class4 = new Class67(Path.Combine(text, "load_no_file"));
			DataGridView dataGridView5 = smethod_138("dataGridViewTextBoxColumn56");
			dataGridView5.Rows.Add("Zither");
			num += smethod_244("sellbtn/load_no_file", 0, class4.method_11(dataGridView5, "all_items_used_test.json"));
			num += smethod_244("sellbtn/load_no_file_rows", "Zither", smethod_124(dataGridView5));
			string text5 = Path.Combine(text, "load_excludes");
			smethod_137(text5, "all_items_used_test.json", "Column4", new string[2] { "Apple", "Bread" });
			Class67 class5 = new Class67(text5);
			DataGridView dataGridView_ = smethod_138("dataGridViewTextBoxColumn56");
			DataGridView dataGridView6 = smethod_138("dataGridViewTextBoxColumn55");
			class5.method_7(dataGridView6, "Want_Sell_test.json");
			class5.method_8("__sellbtn_test__");
			using (class5.method_17(dataGridView6))
			{
				dataGridView6.Rows.Add("bread");
			}
			class5.method_11(dataGridView_, "all_items_used_test.json");
			num += smethod_244("sellbtn/load_before_exclude", "Apple,Bread", smethod_124(dataGridView_));
			num += smethod_244("sellbtn/load_excluded", 1, Class388.smethod_1(dataGridView_, dataGridView6, class5));
			num += smethod_244("sellbtn/load_excluded_rows", "Apple", smethod_124(dataGridView_));
			num += smethod_244("sellbtn/load_excluded_keeps_list", "bread", smethod_124(dataGridView6));
			Class67 class6 = new Class67(Path.Combine(text, "moves"));
			DataGridView dataGridView7 = smethod_138("dataGridViewTextBoxColumn56");
			DataGridView dataGridView8 = smethod_138("dataGridViewTextBoxColumn55");
			class6.method_7(dataGridView8, "Want_Sell_test.json");
			class6.method_8("__sellbtn_test__");
			using (class6.method_17(dataGridView7))
			{
				dataGridView7.Rows.Add("Apple");
				dataGridView7.Rows.Add("Bread");
				dataGridView7.Rows.Add("Cherry");
			}
			dataGridView7.ClearSelection();
			num += smethod_244("sellbtn/move_nothing_selected", 0, Class388.smethod_0(dataGridView7, dataGridView8, class6));
			num += smethod_244("sellbtn/move_nothing_selected_src", "Apple,Bread,Cherry", smethod_124(dataGridView7));
			num += smethod_244("sellbtn/move_nothing_selected_dst", string.Empty, smethod_124(dataGridView8));
			dataGridView7.ClearSelection();
			dataGridView7.Rows[2].Selected = true;
			dataGridView7.Rows[0].Selected = true;
			int num2 = class6.method_3();
			num += smethod_244("sellbtn/move_multi", 2, Class388.smethod_0(dataGridView7, dataGridView8, class6));
			num += smethod_244("sellbtn/move_multi_order", "Apple,Cherry", smethod_139(dataGridView8));
			num += smethod_244("sellbtn/move_not_a_copy", "Bread", smethod_124(dataGridView7));
			num += smethod_244("sellbtn/move_saves_once", num2 + 1, class6.method_3());
			dataGridView8.ClearSelection();
			dataGridView8.Rows[0].Selected = true;
			num2 = class6.method_3();
			num += smethod_244("sellbtn/move_back", 1, Class388.smethod_0(dataGridView8, dataGridView7, class6));
			num += smethod_244("sellbtn/move_back_src", "Cherry", smethod_124(dataGridView8));
			num += smethod_244("sellbtn/move_back_dst", "Apple,Bread", smethod_124(dataGridView7));
			num += smethod_244("sellbtn/move_back_saves_once", num2 + 1, class6.method_3());
			Class67 class7 = new Class67(Path.Combine(text, "move_case"));
			DataGridView dataGridView9 = smethod_138("dataGridViewTextBoxColumn56");
			DataGridView dataGridView10 = smethod_138("dataGridViewTextBoxColumn55");
			class7.method_7(dataGridView10, "Want_Sell_test.json");
			class7.method_8("__sellbtn_test__");
			using (class7.method_17(dataGridView10))
			{
				dataGridView10.Rows.Add("Bread");
			}
			using (class7.method_17(dataGridView9))
			{
				dataGridView9.Rows.Add("bread");
			}
			smethod_123(dataGridView9, 0);
			num += smethod_244("sellbtn/move_case_left_source", 1, Class388.smethod_0(dataGridView9, dataGridView10, class7));
			num += smethod_244("sellbtn/move_case_no_duplicate", "Bread", smethod_124(dataGridView10));
			num += smethod_244("sellbtn/move_case_source_cleared", string.Empty, smethod_124(dataGridView9));
			using (class7.method_17(dataGridView9))
			{
				dataGridView9.Rows.Add("Cherry");
				dataGridView9.Rows.Add("cherry");
			}
			dataGridView9.ClearSelection();
			dataGridView9.Rows[0].Selected = true;
			dataGridView9.Rows[1].Selected = true;
			num += smethod_244("sellbtn/move_case_one_press_moved", 2, Class388.smethod_0(dataGridView9, dataGridView10, class7));
			num += smethod_244("sellbtn/move_case_one_press", "Bread,Cherry", smethod_124(dataGridView10));
			num += smethod_244("sellbtn/move_case_one_press_src", string.Empty, smethod_124(dataGridView9));
			string string_ = Path.Combine(text, "round_trip");
			Class67 class8 = new Class67(string_);
			DataGridView dataGridView11 = smethod_138("dataGridViewTextBoxColumn56");
			DataGridView dataGridView12 = smethod_138("dataGridViewTextBoxColumn55");
			class8.method_7(dataGridView12, "Want_Sell_test.json");
			class8.method_8("__sellbtn_test__");
			using (class8.method_17(dataGridView11))
			{
				dataGridView11.Rows.Add("Apple");
				dataGridView11.Rows.Add("Bread");
			}
			dataGridView11.ClearSelection();
			dataGridView11.Rows[0].Selected = true;
			Class388.smethod_0(dataGridView11, dataGridView12, class8);
			Class67 class9 = new Class67(string_);
			DataGridView dataGridView_2 = smethod_138("dataGridViewTextBoxColumn55");
			class9.method_7(dataGridView_2, "Want_Sell_test.json");
			class9.method_8("__sellbtn_test__");
			num += smethod_244("sellbtn/round_trip", "Apple", smethod_124(dataGridView_2));
		}
		finally
		{
			try
			{
				if (Directory.Exists(text))
				{
					Directory.Delete(text, recursive: true);
				}
			}
			catch
			{
			}
		}
		Console.WriteLine("sellbtn: " + num + " failed");
		return num;
	}

	public static int smethod_126()
	{
		int num = 0;
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		dictionary["11:1"] = "Recovery Potion";
		dictionary["61:1"] = " Copper Tin Ring ";
		dictionary["12:1"] = "   ";
		Class95 @class = new Class95(null, dictionary, null);
		num = 0 + smethod_244("bagcat/known_name", "Recovery Potion", Class16.smethod_6(@class, 11, 1));
		num += smethod_244("bagcat/known_name_trims", "Copper Tin Ring", Class16.smethod_6(@class, 61, 1));
		num += smethod_243("bagcat/known_name_unseen", Class16.smethod_6(@class, 9, 9) == null);
		num += smethod_243("bagcat/known_name_blank", Class16.smethod_6(@class, 12, 1) == null);
		num += smethod_243("bagcat/known_name_no_book", Class16.smethod_6(null, 11, 1) == null);
		num += smethod_244("bagcat/nameof_keeps_placeholder", "Item 9:9", Class16.smethod_5(@class, 9, 9));
		List<string> list = Class16.smethod_8(Class145.class145_0.method_97(smethod_233(), null, @class, 7, 24));
		num += smethod_244("bagcat/skips_unresolved", "Recovery Potion,Copper Tin Ring", smethod_240(list));
		num += smethod_243("bagcat/no_placeholder_catalogued", !list.Contains("Item 9:9"));
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>(StringComparer.Ordinal);
		dictionary2["11:1"] = "Recovery Potion";
		dictionary2["11:2"] = "recovery potion";
		Class95 class95_ = new Class95(null, dictionary2, null);
		List<Struct27> list2 = new List<Struct27>();
		list2.Add(new Struct27
		{
			int_0 = 0,
			ushort_0 = 11,
			ushort_1 = 1,
			int_2 = 1
		});
		list2.Add(new Struct27
		{
			int_0 = 1,
			ushort_0 = 11,
			ushort_1 = 1,
			int_2 = 9
		});
		list2.Add(new Struct27
		{
			int_0 = 2,
			ushort_0 = 11,
			ushort_1 = 2,
			int_2 = 3
		});
		Class145 class145_ = Class145.class145_0.method_97(list2, null, class95_, 7, 24);
		num += smethod_244("bagcat/one_name_per_item", "Recovery Potion", smethod_240(Class16.smethod_8(class145_)));
		num += smethod_244("bagcat/fault_catalogues_nothing", 0, Class16.smethod_8(Class145.class145_0.method_99("bag offsets not loaded")).Count);
		num += smethod_244("bagcat/no_snapshot", 0, Class16.smethod_8(null).Count);
		num += smethod_244("bagcat/empty_bag", 0, Class16.smethod_8(Class145.class145_0).Count);
		Console.WriteLine("bagcat: " + num + " failed");
		return num;
	}

	public static int smethod_127()
	{
		int num = 0;
		DataGridView dataGridView = smethod_138("dataGridViewTextBoxColumn56");
		DataGridView dataGridView2 = smethod_138("dataGridViewTextBoxColumn55");
		dataGridView.Rows.Add("Red Apple");
		dataGridView.Rows.Add("Bread");
		dataGridView.Rows.Add("Apple Pie");
		dataGridView2.Rows.Add("Pineapple");
		num = 0 + smethod_244("sellfind/substring", "Red Apple,Apple Pie,Pineapple", smethod_136(Class44.smethod_0("app", dataGridView, dataGridView2)));
		num += smethod_243("sellfind/match_rule_still_exact", !Class96.smethod_0("Red Apple", "Apple"));
		num += smethod_244("sellfind/case_insensitive", "Red Apple,Apple Pie,Pineapple", smethod_136(Class44.smethod_0("APP", dataGridView, dataGridView2)));
		num += smethod_244("sellfind/needle_trimmed", "Red Apple,Apple Pie,Pineapple", smethod_136(Class44.smethod_0("   app   ", dataGridView, dataGridView2)));
		num += smethod_244("sellfind/whole_name", "Bread", smethod_136(Class44.smethod_0("Bread", dataGridView, dataGridView2)));
		num += smethod_244("sellfind/second_grid_only", "Pineapple", smethod_136(Class44.smethod_0("pine", dataGridView, dataGridView2)));
		num += smethod_244("sellfind/no_match", 0, Class44.smethod_0("zzz", dataGridView, dataGridView2).Count);
		num += smethod_244("sellfind/blank_needle", 0, Class44.smethod_0("   ", dataGridView, dataGridView2).Count);
		num += smethod_244("sellfind/empty_needle", 0, Class44.smethod_0(string.Empty, dataGridView, dataGridView2).Count);
		num += smethod_244("sellfind/null_needle", 0, Class44.smethod_0(null, dataGridView, dataGridView2).Count);
		num += smethod_244("sellfind/both_grids_null", 0, Class44.smethod_0("app", null, null).Count);
		num += smethod_244("sellfind/one_grid_null", "Red Apple,Apple Pie", smethod_136(Class44.smethod_0("app", dataGridView, null)));
		num += smethod_244("sellfind/no_columns", 0, Class44.smethod_0("app", new DataGridView(), null).Count);
		string gparam_ = smethod_139(dataGridView);
		string gparam_2 = smethod_139(dataGridView2);
		int count = dataGridView.Rows.Count;
		int count2 = dataGridView2.Rows.Count;
		Class44.smethod_0("app", dataGridView, dataGridView2);
		Class44.smethod_0(string.Empty, dataGridView, dataGridView2);
		Class44.smethod_0("zzz", dataGridView, dataGridView2);
		num += smethod_244("sellfind/search_keeps_rows_8", count, dataGridView.Rows.Count);
		num += smethod_244("sellfind/search_keeps_rows_9", count2, dataGridView2.Rows.Count);
		num += smethod_244("sellfind/search_keeps_cells_8", gparam_, smethod_139(dataGridView));
		num += smethod_244("sellfind/search_keeps_cells_9", gparam_2, smethod_139(dataGridView2));
		DataGridView dataGridView3 = smethod_138("dataGridViewTextBoxColumn56");
		dataGridView3.AllowUserToAddRows = true;
		dataGridView3.Rows.Add("Apple");
		dataGridView3.Rows.Add();
		num += smethod_244("sellfind/newrow_and_null_cell", "Apple", smethod_136(Class44.smethod_0("a", dataGridView3, null)));
		num += smethod_244("sellfind/counter_first", "1 / 3", Class44.smethod_1(1, 3));
		num += smethod_244("sellfind/counter_last", "3 / 3", Class44.smethod_1(3, 3));
		num += smethod_244("sellfind/counter_no_match", "0 / 0", Class44.smethod_1(0, 0));
		num += smethod_244("sellfind/counter_count_wins", "0 / 0", Class44.smethod_1(1, 0));
		num += smethod_244("sellfind/step_first", 0, Class44.smethod_2(-1, 3));
		num += smethod_244("sellfind/step_second", 1, Class44.smethod_2(0, 3));
		num += smethod_244("sellfind/step_third", 2, Class44.smethod_2(1, 3));
		num += smethod_244("sellfind/step_wraps", 0, Class44.smethod_2(2, 3));
		num += smethod_244("sellfind/step_wraps_far", 0, Class44.smethod_2(9, 3));
		num += smethod_244("sellfind/step_nothing_to_show", -1, Class44.smethod_2(-1, 0));
		num += smethod_244("sellfind/step_nothing_to_show_twice", -1, Class44.smethod_2(0, 0));
		DataGridView dataGridView4 = smethod_138("dataGridViewTextBoxColumn56");
		DataGridView dataGridView5 = smethod_138("dataGridViewTextBoxColumn55");
		dataGridView4.Rows.Add("Red Apple");
		dataGridView4.Rows.Add("Apple Pie");
		dataGridView5.Rows.Add("Pineapple");
		List<DataGridViewRow> list = Class44.smethod_0("app", dataGridView4, dataGridView5);
		int num2 = -1;
		num2 = Class44.smethod_2(-1, list.Count);
		num += smethod_244("sellfind/walk_1", "1 / 3", Class44.smethod_1(num2 + 1, list.Count));
		num += smethod_244("sellfind/walk_1_row", "Red Apple", smethod_135(list, num2));
		num2 = Class44.smethod_2(num2, list.Count);
		num += smethod_244("sellfind/walk_2", "2 / 3", Class44.smethod_1(num2 + 1, list.Count));
		num2 = Class44.smethod_2(num2, list.Count);
		num += smethod_244("sellfind/walk_3", "3 / 3", Class44.smethod_1(num2 + 1, list.Count));
		num += smethod_244("sellfind/walk_3_row", "Pineapple", smethod_135(list, num2));
		num2 = Class44.smethod_2(num2, list.Count);
		num += smethod_244("sellfind/walk_wraps", "1 / 3", Class44.smethod_1(num2 + 1, list.Count));
		num += smethod_244("sellfind/walk_wraps_row", "Red Apple", smethod_135(list, num2));
		DataGridView dataGridView6 = smethod_138("dataGridViewTextBoxColumn56");
		dataGridView6.Rows.Add("Apple");
		DataGridViewRow dataGridViewRow = dataGridView6.Rows[0];
		num += smethod_243("sellfind/live_attached", Class44.smethod_3(dataGridViewRow));
		dataGridView6.Rows.Remove(dataGridViewRow);
		num += smethod_243("sellfind/live_detached", !Class44.smethod_3(dataGridViewRow));
		num += smethod_243("sellfind/live_null", !Class44.smethod_3(null));
		DataGridView dataGridView_ = smethod_138("dataGridViewTextBoxColumn56");
		DataGridView dataGridView7 = smethod_138("dataGridViewTextBoxColumn55");
		num += smethod_243("sellfind/add_ok", Class388.smethod_3(dataGridView_, dataGridView7, "Apple", null));
		num += smethod_244("sellfind/add_ok_rows", "Apple", smethod_124(dataGridView_));
		num += smethod_244("sellfind/add_ok_leaves_list", string.Empty, smethod_124(dataGridView7));
		num += smethod_243("sellfind/add_trims", Class388.smethod_3(dataGridView_, dataGridView7, "  Bread  ", null));
		num += smethod_244("sellfind/add_trims_rows", "Apple,Bread", smethod_124(dataGridView_));
		DataGridView dataGridView8 = smethod_138("dataGridViewTextBoxColumn56");
		DataGridView dataGridView_2 = smethod_138("dataGridViewTextBoxColumn55");
		num += smethod_243("sellfind/add_empty", !Class388.smethod_3(dataGridView8, dataGridView_2, string.Empty, null));
		num += smethod_243("sellfind/add_whitespace", !Class388.smethod_3(dataGridView8, dataGridView_2, "   ", null));
		num += smethod_243("sellfind/add_null", !Class388.smethod_3(dataGridView8, dataGridView_2, null, null));
		num += smethod_244("sellfind/add_blank_rows", string.Empty, smethod_124(dataGridView8));
		num += smethod_244("sellfind/add_blank_count", 0, dataGridView8.Rows.Count);
		DataGridView dataGridView9 = smethod_138("dataGridViewTextBoxColumn56");
		DataGridView dataGridView_3 = smethod_138("dataGridViewTextBoxColumn55");
		dataGridView9.Rows.Add("Apple");
		num += smethod_243("sellfind/add_dup_exact", !Class388.smethod_3(dataGridView9, dataGridView_3, "Apple", null));
		num += smethod_243("sellfind/add_dup_case", !Class388.smethod_3(dataGridView9, dataGridView_3, "APPLE", null));
		num += smethod_243("sellfind/add_dup_spaces", !Class388.smethod_3(dataGridView9, dataGridView_3, " apple ", null));
		num += smethod_244("sellfind/add_dup_rows", "Apple", smethod_124(dataGridView9));
		DataGridView dataGridView_4 = smethod_138("dataGridViewTextBoxColumn56");
		DataGridView dataGridView10 = smethod_138("dataGridViewTextBoxColumn55");
		dataGridView10.Rows.Add("Bread");
		num += smethod_243("sellfind/add_in_list", !Class388.smethod_3(dataGridView_4, dataGridView10, "Bread", null));
		num += smethod_243("sellfind/add_in_list_case", !Class388.smethod_3(dataGridView_4, dataGridView10, "bread", null));
		num += smethod_243("sellfind/add_in_list_spaces", !Class388.smethod_3(dataGridView_4, dataGridView10, "  BREAD  ", null));
		num += smethod_244("sellfind/add_in_list_rows", string.Empty, smethod_124(dataGridView_4));
		num += smethod_244("sellfind/add_in_list_keeps_list", "Bread", smethod_124(dataGridView10));
		num += smethod_243("sellfind/add_other_ok", Class388.smethod_3(dataGridView_4, dataGridView10, "Cherry", null));
		num += smethod_244("sellfind/add_other_ok_rows", "Cherry", smethod_124(dataGridView_4));
		DataGridView dataGridView11 = smethod_138("dataGridViewTextBoxColumn56");
		dataGridView11.AllowUserToAddRows = true;
		num += smethod_243("sellfind/add_newrow_ok", Class388.smethod_3(dataGridView11, null, "Apple", null));
		num += smethod_244("sellfind/add_newrow_rows", "Apple", smethod_124(dataGridView11));
		num += smethod_243("sellfind/add_newrow_dedupes", !Class388.smethod_3(dataGridView11, null, "apple", null));
		string text = Path.Combine(Path.GetTempPath(), "capy_sellfind_" + Guid.NewGuid().ToString("N"));
		try
		{
			Class67 @class = new Class67(text);
			DataGridView dataGridView_5 = smethod_138("dataGridViewTextBoxColumn56");
			DataGridView dataGridView12 = smethod_138("dataGridViewTextBoxColumn55");
			@class.method_7(dataGridView12, "Want_Sell_test.json");
			@class.method_8("__sellfind_test__");
			num += smethod_243("sellfind/flow_typed", Class388.smethod_3(dataGridView_5, dataGridView12, "Moon Sugar", @class));
			num += smethod_244("sellfind/flow_typed_rows", "Moon Sugar", smethod_124(dataGridView_5));
			smethod_123(dataGridView_5, 0);
			num += smethod_244("sellfind/flow_moved", 1, Class388.smethod_0(dataGridView_5, dataGridView12, @class));
			num += smethod_244("sellfind/flow_moved_list", "Moon Sugar", smethod_124(dataGridView12));
			num += smethod_244("sellfind/flow_moved_offer", string.Empty, smethod_124(dataGridView_5));
			num += smethod_243("sellfind/flow_no_second_crossing", !Class388.smethod_3(dataGridView_5, dataGridView12, "moon sugar", @class));
			Class67 class2 = new Class67(text);
			DataGridView dataGridView_6 = smethod_138("dataGridViewTextBoxColumn55");
			class2.method_7(dataGridView_6, "Want_Sell_test.json");
			class2.method_8("__sellfind_test__");
			num += smethod_244("sellfind/flow_persists", "Moon Sugar", smethod_124(dataGridView_6));
		}
		finally
		{
			try
			{
				if (Directory.Exists(text))
				{
					Directory.Delete(text, recursive: true);
				}
			}
			catch
			{
			}
		}
		Console.WriteLine("sellfind: " + num + " failed");
		return num;
	}

	public static int smethod_128()
	{
		int num = 0;
		num = 0 + smethod_244("npcpos/whole", "12,3,-7", Class440.smethod_5(12f, 3f, -7f));
		num += smethod_244("npcpos/two_decimals", "12.5,3.25,-7.5", Class440.smethod_5(12.5f, 3.25f, -7.5f));
		num += smethod_244("npcpos/zero", "0,0,0", Class440.smethod_5(0f, 0f, 0f));
		num += smethod_244("npcpos/negative", "-1.5,-2.25,-3", Class440.smethod_5(-1.5f, -2.25f, -3f));
		num += smethod_244("npcpos/rounds_to_two", "1.23,0,0", Class440.smethod_5(1.234f, 0f, 0f));
		num += smethod_244("npcpos/trailing_zeros_dropped", "1.5,2,3", Class440.smethod_5(1.5f, 2f, 3f));
		num += smethod_243("npcpos/no_spaces", Class440.smethod_5(-123.45f, 6.78f, 90f).IndexOf(' ') < 0);
		num += smethod_244("npcpos/order_is_x_y_z", "1,2,3", Class440.smethod_5(1f, 2f, 3f));
		num += smethod_243("npcpos/parse_order_ok", Class440.smethod_6("1,2,3", out var float_, out var float_2, out var float_3));
		num += smethod_243("npcpos/parse_order_x", Math.Abs(float_ - 1f) < 0.001f);
		num += smethod_243("npcpos/parse_order_y", Math.Abs(float_2 - 2f) < 0.001f);
		num += smethod_243("npcpos/parse_order_z", Math.Abs(float_3 - 3f) < 0.001f);
		string text = Class440.smethod_5(10f, 99f, 20f);
		num += smethod_244("npcpos/altitude_is_middle", "10,99,20", text);
		num += smethod_243("npcpos/ground_parse", Class440.smethod_6(text, out var float_4, out var float_5, out var float_6));
		num += smethod_243("npcpos/ground_plane_is_x_z", Math.Abs(float_4 - 10f) < 0.001f && Math.Abs(float_6 - 20f) < 0.001f);
		num += smethod_243("npcpos/altitude_is_y", Math.Abs(float_5 - 99f) < 0.001f);
		float[] array = new float[8] { 0f, 1f, -1f, 12.5f, -7.25f, 123.45f, -0.5f, 1000f };
		int num2 = 0;
		for (int i = 0; i < array.Length; i++)
		{
			float num3 = array[i];
			float num4 = array[(i + 1) % array.Length];
			float num5 = array[(i + 2) % array.Length];
			if (!Class440.smethod_6(Class440.smethod_5(num3, num4, num5), out var float_7, out var float_8, out var float_9))
			{
				num2++;
			}
			else if (Math.Abs(float_7 - num3) > 0.01f || Math.Abs(float_8 - num4) > 0.01f || Math.Abs(float_9 - num5) > 0.01f)
			{
				num2++;
			}
		}
		num += smethod_244("npcpos/roundtrip_all", 0, num2);
		string[] array2 = new string[13]
		{
			null,
			string.Empty,
			"   ",
			"1",
			"1,2",
			"1,2,3,4",
			"1,2,3,",
			",1,2",
			"a,b,c",
			"1,x,3",
			"1,,3",
			"1;2;3",
			"X:1 , Z:3"
		};
		int num6 = 0;
		int num7 = 0;
		for (int j = 0; j < array2.Length; j++)
		{
			if (Class440.smethod_6(array2[j], out var float_10, out var float_11, out var float_12))
			{
				num6++;
			}
			if (float_10 != 0f || float_11 != 0f || float_12 != 0f)
			{
				num7++;
			}
		}
		num += smethod_244("npcpos/malformed_all_refused", 0, num6);
		num += smethod_244("npcpos/malformed_leaves_zero", 0, num7);
		num += smethod_243("npcpos/spaces_tolerated", Class440.smethod_6("  1 , 2 , 3  ", out var float_13, out var float_14, out var float_15));
		num += smethod_243("npcpos/spaces_values", Math.Abs(float_13 - 1f) < 0.001f && Math.Abs(float_14 - 2f) < 0.001f && Math.Abs(float_15 - 3f) < 0.001f);
		CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
		try
		{
			Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
			num += smethod_244("npcpos/de_format", "1.5,2.25,-3.75", Class440.smethod_5(1.5f, 2.25f, -3.75f));
			num += smethod_243("npcpos/de_parse", Class440.smethod_6("1.5,2.25,-3.75", out var float_16, out var float_17, out var float_18));
			num += smethod_243("npcpos/de_parse_values", Math.Abs(float_16 - 1.5f) < 0.001f && Math.Abs(float_17 - 2.25f) < 0.001f && Math.Abs(float_18 + 3.75f) < 0.001f);
			num += smethod_243("npcpos/de_roundtrip", Class440.smethod_5(1.5f, 2.25f, -3.75f) == "1.5,2.25,-3.75");
			num += smethod_243("npcpos/de_comma_decimal_refused", !Class440.smethod_6("1,5,2,25,-3,75", out var _, out var _, out var _));
		}
		finally
		{
			Thread.CurrentThread.CurrentCulture = currentCulture;
		}
		num += smethod_243("npcpos/gate_selected", GForm0.smethod_8(Enum0.Selected, bool_23: true, bool_24: true));
		num += smethod_243("npcpos/gate_started", GForm0.smethod_8(Enum0.Started, bool_23: true, bool_24: true));
		num += smethod_243("npcpos/gate_idle", !GForm0.smethod_8(Enum0.Idle, bool_23: true, bool_24: true));
		num += smethod_243("npcpos/gate_attached", !GForm0.smethod_8(Enum0.Attached, bool_23: true, bool_24: true));
		num += smethod_243("npcpos/gate_detached_keeps_stale_self", !GForm0.smethod_8(Enum0.Selected, bool_23: false, bool_24: true));
		num += smethod_243("npcpos/gate_detached_while_started", !GForm0.smethod_8(Enum0.Started, bool_23: false, bool_24: true));
		num += smethod_243("npcpos/gate_no_snapshot", !GForm0.smethod_8(Enum0.Selected, bool_23: true, bool_24: false));
		num += smethod_243("npcpos/gate_nothing_at_all", !GForm0.smethod_8(Enum0.Idle, bool_23: false, bool_24: false));
		Console.WriteLine("npcpos: " + num + " failed");
		return num;
	}

	public static int smethod_129()
	{
		int num = 0;
		DataGridView dataGridView = new DataGridView();
		Class440.smethod_0(dataGridView);
		dataGridView.AllowUserToAddRows = false;
		dataGridView.CreateControl();
		dataGridView.Rows.Add("1", "2", "0", "False", "0");
		dataGridView.Rows.Add("3", "4", "0", "False", "0");
		dataGridView.Rows.Add("abc", "def", "0", "False", "0");
		dataGridView.Rows.Add("5", "6", "0", "False", "0");
		List<Struct76> list = Class440.smethod_10(dataGridView);
		num = 0 + smethod_244("gridselect_count", 3, list.Count);
		if (list.Count == 3)
		{
			num += smethod_244("gridselect_row0", 0, list[0].int_1);
			num += smethod_244("gridselect_row1", 1, list[1].int_1);
			num += smethod_244("gridselect_row2", 3, list[2].int_1);
		}
		Class440.smethod_11(dataGridView, list[1].int_1);
		num += smethod_244("gridselect_selected_count", 1, dataGridView.SelectedRows.Count);
		if (dataGridView.SelectedRows.Count == 1)
		{
			num += smethod_244("gridselect_selected_row", list[1].int_1, dataGridView.SelectedRows[0].Index);
		}
		dataGridView.CurrentCell = dataGridView.Rows[list[1].int_1].Cells[0];
		num += smethod_244("gridselect_current_row", list[1].int_1, dataGridView.CurrentRow.Index);
		Class440.smethod_11(dataGridView, list[1].int_1);
		num += smethod_244("gridselect_idempotent_count", 1, dataGridView.SelectedRows.Count);
		if (dataGridView.SelectedRows.Count == 1)
		{
			num += smethod_244("gridselect_idempotent_row", list[1].int_1, dataGridView.SelectedRows[0].Index);
		}
		num += smethod_244("gridselect_idempotent_current", list[1].int_1, dataGridView.CurrentRow.Index);
		Class440.smethod_11(dataGridView, -5);
		Class440.smethod_11(dataGridView, 999);
		num += smethod_244("gridselect_oor_count", 1, dataGridView.SelectedRows.Count);
		if (dataGridView.SelectedRows.Count == 1)
		{
			num += smethod_244("gridselect_oor_row", list[1].int_1, dataGridView.SelectedRows[0].Index);
		}
		num += smethod_244("gridselect_oor_current", list[1].int_1, dataGridView.CurrentRow.Index);
		Console.WriteLine("gridselect: " + num + " failed");
		return num;
	}

	public static int smethod_130()
	{
		int num = 0;
		Dictionary<string, string> dictionary_ = new Dictionary<string, string>(StringComparer.Ordinal)
		{
			{ "100:1", "Item Shop Keeper" },
			{ "300:1", "Wild Boar" },
			{ "500:1", "   " },
			{ "700:1", "  Blacksmith  " }
		};
		Class83 @class = new Class83
		{
			float_0 = 0f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class2 = smethod_132(new List<Class403>
		{
			smethod_131(2, 300, 1, 11u, 1f, 0f),
			smethod_131(0, 400, 1, 12u, 2f, 0f),
			smethod_131(5, 600, 1, 13u, 2.5f, 0f),
			smethod_131(1, 200, 1, 14u, 3f, 0f),
			smethod_131(1, 100, 1, 15u, 0f, 5f),
			smethod_131(1, 100, 1, 16u, 10f, 0f)
		}, dictionary_, @class);
		num = 0 + smethod_244("npcpick/census_is_one_pile", 6, class2.method_2().Count);
		List<Class447.Class452> list = Class447.smethod_10(class2, @class);
		num += smethod_244("npcpick/only_npc_kind", 3, list.Count);
		num += smethod_243("npcpick/mob_excluded", !smethod_133(list, 11u));
		num += smethod_243("npcpick/player_crow_excluded", !smethod_133(list, 12u));
		num += smethod_243("npcpick/pet_excluded", !smethod_133(list, 13u));
		num += smethod_243("npcpick/npc_kept_unnamed", smethod_133(list, 14u));
		num += smethod_243("npcpick/npc_kept_near", smethod_133(list, 15u));
		num += smethod_243("npcpick/npc_kept_far", smethod_133(list, 16u));
		if (list.Count == 3)
		{
			num += smethod_244("npcpick/order_0_is_nearest", 14u, list[0].class403_0.uint_0);
			num += smethod_244("npcpick/order_1", 15u, list[1].class403_0.uint_0);
			num += smethod_244("npcpick/order_2_is_farthest", 16u, list[2].class403_0.uint_0);
			num += smethod_243("npcpick/dist_0", Math.Abs(list[0].float_0 - 3f) < 0.001f);
			num += smethod_243("npcpick/dist_1", Math.Abs(list[1].float_0 - 5f) < 0.001f);
			num += smethod_243("npcpick/dist_2", Math.Abs(list[2].float_0 - 10f) < 0.001f);
		}
		if (list.Count == 3)
		{
			num += smethod_244("npcpick/name_resolved", "Item Shop Keeper", list[1].string_0);
			num += smethod_243("npcpick/name_unresolved_is_null", list[0].string_0 == null);
			num += smethod_243("npcpick/unresolved_not_pickable", !Class447.smethod_11(list[0]));
			num += smethod_243("npcpick/resolved_pickable", Class447.smethod_11(list[1]));
			num += smethod_243("npcpick/resolved_pickable_far", Class447.smethod_11(list[2]));
			num += smethod_244("npcpick/pickable_count", 2, Class447.smethod_14(list));
			num += smethod_244("npcpick/unresolved_name_cell_says_so", "(name not known yet)", Class447.smethod_12(list[0]));
			num += smethod_243("npcpick/unresolved_marker_stays_in_name_cell", Class447.smethod_13(list[0]).IndexOf("(name not known yet)", StringComparison.Ordinal) < 0);
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < list.Count; i++)
			{
				if (Class447.smethod_11(list[i]))
				{
					string string_ = list[i].string_0;
					if (string_ == "(name not known yet)")
					{
						num2++;
					}
					if (string_ == null || string_.Trim().Length == 0)
					{
						num3++;
					}
				}
			}
			num += smethod_244("npcpick/no_placeholder_is_pickable", 0, num2);
			num += smethod_244("npcpick/no_blank_is_pickable", 0, num3);
		}
		if (list.Count == 3)
		{
			num += smethod_244("npcpick/duplicates_same_name", list[1].string_0, list[2].string_0);
			num += smethod_243("npcpick/duplicates_are_two_rows", list[1].class403_0.uint_0 != list[2].class403_0.uint_0);
			num += smethod_244("npcpick/duplicates_same_name_cell", Class447.smethod_12(list[1]), Class447.smethod_12(list[2]));
			num += smethod_243("npcpick/duplicates_distinguishable", Class447.smethod_13(list[1]) != Class447.smethod_13(list[2]));
			num += smethod_244("npcpick/name_cell_near", "Item Shop Keeper", Class447.smethod_12(list[1]));
			num += smethod_244("npcpick/dist_cell_near", "5", Class447.smethod_13(list[1]));
			num += smethod_244("npcpick/name_cell_far", "Item Shop Keeper", Class447.smethod_12(list[2]));
			num += smethod_244("npcpick/dist_cell_far", "10", Class447.smethod_13(list[2]));
			num += smethod_244("npcpick/dist_cell_unresolved", "3", Class447.smethod_13(list[0]));
			int num4 = 0;
			for (int j = 0; j < list.Count; j++)
			{
				if (smethod_134(Class447.smethod_12(list[j])))
				{
					num4++;
				}
				if (smethod_134(Class447.smethod_13(list[j])))
				{
					num4++;
				}
			}
			num += smethod_244("npcpick/no_position_in_any_cell", 0, num4);
		}
		List<Class447.Class452> list2 = Class447.smethod_10(smethod_132(new List<Class403>
		{
			smethod_131(1, 100, 1, 31u, 0f, 4f),
			smethod_131(1, 100, 1, 32u, 4f, 0f)
		}, dictionary_, @class), @class);
		num += smethod_244("npcpick/tie_count", 2, list2.Count);
		if (list2.Count == 2)
		{
			num += smethod_243("npcpick/tie_same_distance", Math.Abs(list2[0].float_0 - list2[1].float_0) < 0.001f);
			num += smethod_244("npcpick/tie_keeps_census_order_0", 31u, list2[0].class403_0.uint_0);
			num += smethod_244("npcpick/tie_keeps_census_order_1", 32u, list2[1].class403_0.uint_0);
		}
		List<Class447.Class452> list3 = Class447.smethod_10(smethod_132(new List<Class403>
		{
			smethod_131(1, 100, 1, 32u, 4f, 0f),
			smethod_131(1, 100, 1, 31u, 0f, 4f)
		}, dictionary_, @class), @class);
		num += smethod_244("npcpick/tie_follows_input_order", 32u, (list3.Count == 2) ? list3[0].class403_0.uint_0 : 0u);
		List<Class447.Class452> list4 = Class447.smethod_10(smethod_132(new List<Class403>
		{
			smethod_131(1, 500, 1, 41u, 1f, 0f),
			smethod_131(1, 700, 1, 42u, 2f, 0f)
		}, dictionary_, @class), @class);
		num += smethod_244("npcpick/odd_count", 2, list4.Count);
		if (list4.Count == 2)
		{
			num += smethod_243("npcpick/blank_name_is_null", list4[0].string_0 == null);
			num += smethod_243("npcpick/blank_name_not_pickable", !Class447.smethod_11(list4[0]));
			num += smethod_244("npcpick/name_is_trimmed", "Blacksmith", list4[1].string_0);
			num += smethod_243("npcpick/trimmed_name_pickable", Class447.smethod_11(list4[1]));
		}
		num += smethod_244("npcpick/empty_census", 0, Class447.smethod_10(Class145.class145_0.method_93(@class, 1, 0), @class).Count);
		Class145 class3 = smethod_132(new List<Class403>
		{
			smethod_131(2, 300, 1, 51u, 1f, 0f),
			smethod_131(2, 300, 1, 52u, 2f, 0f)
		}, dictionary_, @class);
		num += smethod_244("npcpick/census_has_rows", 2, class3.method_2().Count);
		num += smethod_244("npcpick/no_npc_rows", 0, Class447.smethod_10(class3, @class).Count);
		num += smethod_244("npcpick/no_self", 0, Class447.smethod_10(class3, null).Count);
		num += smethod_244("npcpick/no_world", 0, Class447.smethod_10(null, @class).Count);
		num += smethod_244("npcpick/pickable_of_nothing", 0, Class447.smethod_14(null));
		num += smethod_243("npcpick/name_cell_of_nothing", Class447.smethod_12(null) == string.Empty);
		num += smethod_243("npcpick/dist_cell_of_nothing", Class447.smethod_13(null) == string.Empty);
		num += smethod_243("npcpick/pick_of_nothing", !Class447.smethod_11(null));
		num += smethod_243("npcpick/gate_live", GForm0.smethod_8(Enum0.Selected, bool_23: true, bool_24: true));
		num += smethod_243("npcpick/gate_detached_keeps_stale_census", !GForm0.smethod_8(Enum0.Selected, bool_23: false, bool_24: true));
		num += smethod_243("npcpick/gate_before_select", !GForm0.smethod_8(Enum0.Attached, bool_23: true, bool_24: true));
		Console.WriteLine("npcpick: " + num + " failed");
		return num;
	}

	private static Class403 smethod_131(byte byte_0, ushort ushort_0, ushort ushort_1, uint uint_0, float float_0, float float_1)
	{
		return new Class403
		{
			byte_0 = byte_0,
			ushort_0 = ushort_0,
			ushort_1 = ushort_1,
			uint_0 = uint_0,
			float_0 = float_0,
			float_1 = 0f,
			float_2 = float_1
		};
	}

	private static Class145 smethod_132(List<Class403> list_0, Dictionary<string, string> dictionary_0, Class83 class83_0)
	{
		return Class145.class145_0.method_95(list_0, new Class95(dictionary_0, null, null), null, default(GStruct4), 1, 0).method_93(class83_0, 1, 0);
	}

	private static bool smethod_133(List<Class447.Class452> list_0, uint uint_0)
	{
		if (list_0 == null)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				if (list_0[num] != null && list_0[num].class403_0 != null && list_0[num].class403_0.uint_0 == uint_0)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool smethod_134(string string_0)
	{
		if (string_0 == null)
		{
			return false;
		}
		if (string_0.IndexOf("X:", StringComparison.Ordinal) < 0)
		{
			return string_0.IndexOf("Z:", StringComparison.Ordinal) >= 0;
		}
		return true;
	}

	private static string smethod_135(List<DataGridViewRow> list_0, int int_0)
	{
		if (int_0 >= 0 && int_0 < list_0.Count)
		{
			return Class388.smethod_8(list_0[int_0]);
		}
		return "(none)";
	}

	private static string smethod_136(List<DataGridViewRow> list_0)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < list_0.Count; i++)
		{
			list.Add(Class388.smethod_8(list_0[i]));
		}
		return string.Join(",", list.ToArray());
	}

	private static void smethod_137(string string_0, string string_1, string string_2, string[] string_3)
	{
		Class67 @class = new Class67(string_0);
		DataGridView dataGridView = smethod_138(string_2);
		@class.method_6(dataGridView, string_1, bool_0: false);
		using (@class.method_17(dataGridView))
		{
			for (int i = 0; i < string_3.Length; i++)
			{
				dataGridView.Rows.Add(string_3[i]);
			}
		}
	}

	private static DataGridView smethod_138(string string_0)
	{
		return new DataGridView
		{
			AllowUserToAddRows = false,
			ColumnHeadersVisible = false,
			SelectionMode = DataGridViewSelectionMode.FullRowSelect,
			Columns = { (DataGridViewColumn)new DataGridViewTextBoxColumn
			{
				Name = string_0,
				HeaderText = "Item"
			} }
		};
	}

	private static string smethod_139(DataGridView dataGridView_0)
	{
		List<string> list = new List<string>();
		foreach (DataGridViewRow item in (IEnumerable)dataGridView_0.Rows)
		{
			if (!item.IsNewRow)
			{
				list.Add(Class388.smethod_8(item));
			}
		}
		return string.Join(",", list.ToArray());
	}

	private static DataGridView smethod_140()
	{
		DataGridView dataGridView = new DataGridView();
		dataGridView.AllowUserToAddRows = false;
		dataGridView.ColumnHeadersVisible = false;
		dataGridView.Columns.AddRange(new DataGridViewTextBoxColumn
		{
			Name = "routeCol0",
			HeaderText = "X"
		}, new DataGridViewTextBoxColumn
		{
			Name = "routeCol1",
			HeaderText = "Y"
		}, new DataGridViewTextBoxColumn
		{
			Name = "routeCol2",
			HeaderText = "Z"
		});
		return dataGridView;
	}

	private static bool smethod_141(Class455 class455_0, Class455 class455_1)
	{
		if (class455_0 != null && class455_1 != null)
		{
			if (class455_0.float_0 != null && class455_0.float_1 != null && class455_0.float_2 != null)
			{
				if (class455_1.float_0 != null && class455_1.float_1 != null && class455_1.float_2 != null)
				{
					int num = class455_1.float_0.Length;
					if (class455_0.float_0.Length == num && class455_0.float_1.Length == num && class455_0.float_2.Length == num)
					{
						if (class455_1.float_1.Length == num && class455_1.float_2.Length == num)
						{
							int num2 = 0;
							while (true)
							{
								if (num2 < num)
								{
									if (!(Math.Abs(class455_0.float_0[num2] - class455_1.float_0[num2]) <= 0.0001f))
									{
										break;
									}
									if (Math.Abs(class455_0.float_1[num2] - class455_1.float_1[num2]) <= 0.0001f)
									{
										if (Math.Abs(class455_0.float_2[num2] - class455_1.float_2[num2]) <= 0.0001f)
										{
											num2++;
											continue;
										}
										return false;
									}
									return false;
								}
								return true;
							}
							return false;
						}
						return false;
					}
					return false;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	private static bool smethod_142(int[] int_0, int int_1, int int_2)
	{
		if (int_0 != null && int_0.Length == int_2)
		{
			int num = 0;
			while (true)
			{
				if (num < int_2)
				{
					if (!smethod_143(int_0, int_1 + num))
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	private static bool smethod_143(int[] int_0, int int_1)
	{
		if (int_0 != null)
		{
			return Array.IndexOf(int_0, int_1) >= 0;
		}
		return false;
	}

	public static int smethod_144()
	{
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), "capy_sellcopy_" + Guid.NewGuid().ToString("N"));
		try
		{
			string text2 = Path.Combine(text, "enumerate");
			smethod_145(text2, "Want_Sell.json", "SellCopyMine", "dataGridViewTextBoxColumn55", new string[1] { "Apple" });
			smethod_145(text2, "Want_Sell.json", "SellCopyAlpha", "dataGridViewTextBoxColumn55", new string[1] { "Bread" });
			smethod_145(text2, "Want_Sell.json", "SellCopyZulu", "dataGridViewTextBoxColumn55", new string[1] { "Cherry" });
			smethod_145(text2, "Want_Buy.json", "SellCopyAlpha", "dataGridViewTextBoxColumn55", new string[1] { "Date" });
			File.WriteAllText(Path.Combine(text2, "Want_Sell.json"), "{}");
			num += smethod_244("sellcopy/enum_excludes_me", "SellCopyAlpha,SellCopyZulu", smethod_240(Class176.smethod_3(text2, "Want_Sell.json", Class176.smethod_0("SellCopyMine"))));
			num += smethod_244("sellcopy/enum_no_hero", "SellCopyAlpha,SellCopyMine,SellCopyZulu", smethod_240(Class176.smethod_3(text2, "Want_Sell.json", null)));
			num += smethod_244("sellcopy/enum_no_folder", string.Empty, smethod_240(Class176.smethod_3(Path.Combine(text, "nope"), "Want_Sell.json", "SellCopyMine")));
			string text3 = "A_Want_SellB_Want_Sell.json";
			num += smethod_244("sellcopy/stem_substring", "A_Want_SellB", Class176.smethod_2(text3, "Want_Sell.json"));
			num += smethod_244("sellcopy/stem_ref_replace_mangles", "AB", Path.GetFileNameWithoutExtension(text3).Replace("_Want_Sell", string.Empty));
			num += smethod_244("sellcopy/stem_other_base", string.Empty, Class176.smethod_2("Hero_Want_Buy.json", "Want_Sell.json"));
			num += smethod_244("sellcopy/stem_unprefixed", string.Empty, Class176.smethod_2("Want_Sell.json", "Want_Sell.json"));
			num += smethod_244("sellcopy/stem_no_hero", string.Empty, Class176.smethod_2("_Want_Sell.json", "Want_Sell.json"));
			string string_ = Path.Combine(text, "stem");
			smethod_145(string_, "Want_Sell.json", "A_Want_SellB", "dataGridViewTextBoxColumn55", new string[1] { "Apple" });
			num += smethod_244("sellcopy/stem_enumerated", "A_Want_SellB", smethod_240(Class176.smethod_3(string_, "Want_Sell.json", Class176.smethod_0("SellCopyMine"))));
			string text4 = Path.Combine(text, "reader");
			smethod_145(text4, "Want_Sell.json", "SellCopyAlpha", "dataGridViewTextBoxColumn55", new string[2] { "Bread", "Cherry" });
			smethod_145(text4, "Want_Sell.json", "SellCopyZulu", "dataGridViewTextBoxColumn55", Array.Empty<string>());
			Class67 @class = new Class67(text4);
			string text5 = Class67.smethod_1(smethod_138("dataGridViewTextBoxColumn55"));
			num += smethod_244("sellcopy/reader_key", "dataGridViewTextBoxColumn55", text5);
			num += smethod_244("sellcopy/reader_rows", "Bread,Cherry", smethod_240(Class67.smethod_2(@class.method_18(Class176.smethod_1("SellCopyAlpha", "Want_Sell.json")), text5)));
			num += smethod_244("sellcopy/reader_empty_rows", string.Empty, smethod_240(Class67.smethod_2(@class.method_18(Class176.smethod_1("SellCopyZulu", "Want_Sell.json")), text5)));
			num += smethod_244("sellcopy/reader_missing", string.Empty, smethod_240(Class67.smethod_2(@class.method_18(Class176.smethod_1("Nobody", "Want_Sell.json")), text5)));
			File.WriteAllText(Path.Combine(text4, "Broken1_Want_Sell.json"), "{ not json at all");
			File.WriteAllText(Path.Combine(text4, "Broken2_Want_Sell.json"), "{\"rows\":\"nope\"}");
			File.WriteAllText(Path.Combine(text4, "Broken3_Want_Sell.json"), "{\"grid\":\"dv9\"}");
			bool flag = false;
			int gparam_ = -1;
			try
			{
				gparam_ = @class.method_18("Broken1_Want_Sell.json").Count + @class.method_18("Broken2_Want_Sell.json").Count + @class.method_18("Broken3_Want_Sell.json").Count;
			}
			catch (Exception)
			{
				flag = true;
			}
			num += smethod_243("sellcopy/reader_broken_no_throw", !flag);
			num += smethod_244("sellcopy/reader_broken_empty", 0, gparam_);
			num += smethod_244("sellcopy/reader_key_absent", string.Empty, smethod_240(Class67.smethod_2(@class.method_18(Class176.smethod_1("SellCopyAlpha", "Want_Sell.json")), "someOtherColumn")));
			Class332 class2 = new Class332();
			string text6 = Path.Combine(text, "merge_writes_once");
			smethod_145(text6, "Want_Sell.json", "SellCopyAlpha", "dataGridViewTextBoxColumn55", new string[3] { "Bread", "Cherry", "Date" });
			Class67 class3 = new Class67(text6);
			DataGridView dataGridView = smethod_138("dataGridViewTextBoxColumn55");
			class3.method_7(dataGridView, "Want_Sell.json");
			class3.method_8("SellCopyMine");
			using (class3.method_17(dataGridView))
			{
				dataGridView.Rows.Add("Apple");
				dataGridView.Rows.Add("Bread");
			}
			class2.string_0 = Path.Combine(text6, Class176.smethod_1("SellCopyMine", "Want_Sell.json"));
			num += smethod_244("sellcopy/mine_seeded", 2, smethod_146(class2.string_0));
			string gparam_2 = File.ReadAllText(class2.string_0);
			int num2 = class3.method_3();
			List<string> list_ = Class67.smethod_2(class3.method_18(Class176.smethod_1("SellCopyAlpha", "Want_Sell.json")), Class67.smethod_1(dataGridView));
			num += smethod_244("sellcopy/read_names", "Bread,Cherry,Date", smethod_240(list_));
			num += smethod_244("sellcopy/read_writes_nothing", num2, class3.method_3());
			num += smethod_244("sellcopy/read_bytes_untouched", gparam_2, File.ReadAllText(class2.string_0));
			class2.list_0 = new List<int>();
			dataGridView.RowsAdded += class2.method_0;
			dataGridView.RowsRemoved += class2.method_1;
			int gparam_3 = Class388.smethod_4(dataGridView, list_, class3);
			num += smethod_244("sellcopy/merge_added", 2, gparam_3);
			num += smethod_244("sellcopy/merge_keeps_existing", "Apple,Bread,Cherry,Date", smethod_124(dataGridView));
			num += smethod_244("sellcopy/merge_appends_in_order", "Apple,Bread,Cherry,Date", smethod_139(dataGridView));
			num += smethod_244("sellcopy/merge_saves_once", num2 + 1, class3.method_3());
			num += smethod_244("sellcopy/merge_file_rows", 4, smethod_146(class2.string_0));
			int num3 = int.MaxValue;
			for (int i = 0; i < class2.list_0.Count; i++)
			{
				if (class2.list_0[i] < num3)
				{
					num3 = class2.list_0[i];
				}
			}
			num += smethod_243("sellcopy/merge_watched", class2.list_0.Count > 0);
			num += smethod_243("sellcopy/merge_never_emptied", num3 >= 2);
			string text7 = Path.Combine(text, "merge_dedupes");
			smethod_145(text7, "Want_Sell.json", "SellCopyAlpha", "dataGridViewTextBoxColumn55", new string[4] { " bread ", "BREAD", "Cherry", "   " });
			Class67 class4 = new Class67(text7);
			DataGridView dataGridView2 = smethod_138("dataGridViewTextBoxColumn55");
			class4.method_7(dataGridView2, "Want_Sell.json");
			class4.method_8("SellCopyMine");
			using (class4.method_17(dataGridView2))
			{
				dataGridView2.Rows.Add("Bread");
			}
			List<string> list_2 = Class67.smethod_2(class4.method_18(Class176.smethod_1("SellCopyAlpha", "Want_Sell.json")), Class67.smethod_1(dataGridView2));
			num += smethod_244("sellcopy/dedupe_read", " bread ,BREAD,Cherry", smethod_240(list_2));
			int num4 = class4.method_3();
			num += smethod_244("sellcopy/dedupe_added", 1, Class388.smethod_4(dataGridView2, list_2, class4));
			num += smethod_244("sellcopy/dedupe_rows", "Bread,Cherry", smethod_124(dataGridView2));
			num += smethod_244("sellcopy/dedupe_saves_once", num4 + 1, class4.method_3());
			string text8 = Path.Combine(text, "nothing_to_merge");
			smethod_145(text8, "Want_Sell.json", "SellCopyZulu", "dataGridViewTextBoxColumn55", Array.Empty<string>());
			Class67 class5 = new Class67(text8);
			DataGridView dataGridView3 = smethod_138("dataGridViewTextBoxColumn55");
			class5.method_7(dataGridView3, "Want_Sell.json");
			class5.method_8("SellCopyMine");
			using (class5.method_17(dataGridView3))
			{
				dataGridView3.Rows.Add("Apple");
				dataGridView3.Rows.Add("Bread");
			}
			File.WriteAllText(Path.Combine(text8, "Broken_Want_Sell.json"), "{ not json at all");
			string path = Path.Combine(text8, Class176.smethod_1("SellCopyMine", "Want_Sell.json"));
			string string_2 = Class67.smethod_1(dataGridView3);
			string[] array = new string[3]
			{
				Class176.smethod_1("Nobody", "Want_Sell.json"),
				"Broken_Want_Sell.json",
				Class176.smethod_1("SellCopyZulu", "Want_Sell.json")
			};
			string[] array2 = new string[3] { "missing", "damaged", "no_rows" };
			for (int j = 0; j < array.Length; j++)
			{
				string gparam_4 = File.ReadAllText(path);
				int gparam_5 = class5.method_3();
				List<string> list = Class67.smethod_2(class5.method_18(array[j]), string_2);
				num += smethod_244("sellcopy/" + array2[j] + "_read", 0, list.Count);
				num += smethod_244("sellcopy/" + array2[j] + "_added", 0, Class388.smethod_4(dataGridView3, list, class5));
				num += smethod_244("sellcopy/" + array2[j] + "_no_write", gparam_5, class5.method_3());
				num += smethod_244("sellcopy/" + array2[j] + "_bytes", gparam_4, File.ReadAllText(path));
				num += smethod_244("sellcopy/" + array2[j] + "_rows", "Apple,Bread", smethod_124(dataGridView3));
			}
			string text9 = Path.Combine(text, "exclude_after");
			smethod_145(text9, "Want_Sell.json", "SellCopyAlpha", "dataGridViewTextBoxColumn55", new string[2] { "Cherry", "Date" });
			Class67 class6 = new Class67(text9);
			DataGridView dataGridView4 = smethod_138("dataGridViewTextBoxColumn55");
			class6.method_7(dataGridView4, "Want_Sell.json");
			class6.method_8("SellCopyMine");
			using (class6.method_17(dataGridView4))
			{
				dataGridView4.Rows.Add("Apple");
			}
			DataGridView dataGridView5 = smethod_138("dataGridViewTextBoxColumn56");
			dataGridView5.Rows.Add("cherry");
			dataGridView5.Rows.Add("Elm");
			List<string> list_3 = Class67.smethod_2(class6.method_18(Class176.smethod_1("SellCopyAlpha", "Want_Sell.json")), Class67.smethod_1(dataGridView4));
			num += smethod_244("sellcopy/exclude_merged", 2, Class388.smethod_4(dataGridView4, list_3, class6));
			num += smethod_244("sellcopy/exclude_before", "Elm,cherry", smethod_124(dataGridView5));
			int gparam_6 = class6.method_3();
			num += smethod_244("sellcopy/exclude_dropped", 1, Class388.smethod_1(dataGridView5, dataGridView4, class6));
			num += smethod_244("sellcopy/exclude_after", "Elm", smethod_124(dataGridView5));
			num += smethod_244("sellcopy/exclude_keeps_list", "Apple,Cherry,Date", smethod_124(dataGridView4));
			num += smethod_244("sellcopy/exclude_no_write", gparam_6, class6.method_3());
			string text10 = Path.Combine(text, "round_trip");
			smethod_145(text10, "Want_Sell.json", "SellCopyAlpha", "dataGridViewTextBoxColumn55", new string[1] { "Cherry" });
			Class67 class7 = new Class67(text10);
			DataGridView dataGridView6 = smethod_138("dataGridViewTextBoxColumn55");
			class7.method_7(dataGridView6, "Want_Sell.json");
			class7.method_8("SellCopyMine");
			using (class7.method_17(dataGridView6))
			{
				dataGridView6.Rows.Add("Apple");
			}
			List<string> list_4 = Class67.smethod_2(class7.method_18(Class176.smethod_1("SellCopyAlpha", "Want_Sell.json")), Class67.smethod_1(dataGridView6));
			Class388.smethod_4(dataGridView6, list_4, class7);
			Class67 class8 = new Class67(text10);
			DataGridView dataGridView_ = smethod_138("dataGridViewTextBoxColumn55");
			class8.method_7(dataGridView_, "Want_Sell.json");
			class8.method_8("SellCopyMine");
			num += smethod_244("sellcopy/round_trip_mine", "Apple,Cherry", smethod_124(dataGridView_));
			Class67 class9 = new Class67(text10);
			DataGridView dataGridView_2 = smethod_138("dataGridViewTextBoxColumn55");
			class9.method_7(dataGridView_2, "Want_Sell.json");
			class9.method_8("SellCopyAlpha");
			num += smethod_244("sellcopy/round_trip_source", "Cherry", smethod_124(dataGridView_2));
			num += smethod_243("sellcopy/report_nothing_read", GForm0.smethod_9("Zed", 0, 0).Contains("empty or damaged"));
			num += smethod_243("sellcopy/report_all_duplicates", GForm0.smethod_9("Zed", 5, 0).Contains("already on this one"));
			string text11 = GForm0.smethod_9("Zed", 5, 2);
			num += smethod_243("sellcopy/report_added_many", text11.Contains("Added 2 items from Zed"));
			num += smethod_243("sellcopy/report_skipped_many", text11.Contains("3 items already on this list were skipped"));
			string text12 = GForm0.smethod_9("Zed", 2, 1);
			num += smethod_243("sellcopy/report_added_one", text12.Contains("Added 1 item from Zed"));
			num += smethod_243("sellcopy/report_skipped_one", text12.Contains("1 item already on this list was skipped"));
			num += smethod_243("sellcopy/report_no_skips", !GForm0.smethod_9("Zed", 2, 2).Contains("skipped"));
		}
		finally
		{
			try
			{
				if (Directory.Exists(text))
				{
					Directory.Delete(text, recursive: true);
				}
			}
			catch
			{
			}
		}
		Console.WriteLine("sellcopy: " + num + " failed");
		return num;
	}

	private static void smethod_145(string string_0, string string_1, string string_2, string string_3, string[] string_4)
	{
		Class67 @class = new Class67(string_0);
		DataGridView dataGridView = smethod_138(string_3);
		@class.method_7(dataGridView, string_1);
		@class.method_8(string_2);
		using (@class.method_17(dataGridView))
		{
			for (int i = 0; i < string_4.Length; i++)
			{
				dataGridView.Rows.Add(string_4[i]);
			}
		}
	}

	private static int smethod_146(string string_0)
	{
		if (!File.Exists(string_0))
		{
			return -1;
		}
		try
		{
			return (!(JObject.Parse(File.ReadAllText(string_0))["rows"] is JArray jArray)) ? (-1) : jArray.Count;
		}
		catch (Exception)
		{
			return -2;
		}
	}

	public static int smethod_147()
	{
		int num = 0;
		Struct139 struct139_ = new Struct139
		{
			bool_0 = false
		};
		Struct139 struct139_2 = new Struct139
		{
			bool_0 = true
		};
		Struct67 struct67_ = new Struct67
		{
			bool_0 = true
		};
		Struct67 struct67_2 = new Struct67
		{
			bool_0 = false
		};
		num = 0 + smethod_244("camflow/unavailable says nothing", (Enum12)0, Class61.smethod_0(struct67_, struct139_, Enum0.Started, bool_0: false));
		num += smethod_244("camflow/unavailable says nothing even when on", (Enum12)0, Class61.smethod_0(struct67_, struct139_2, Enum0.Started, bool_0: false));
		num += smethod_244("camflow/remembered before the world: Idle", (Enum12)0, Class61.smethod_0(struct67_, struct139_, Enum0.Idle, bool_0: true));
		num += smethod_244("camflow/remembered before the world: Attached", (Enum12)0, Class61.smethod_0(struct67_, struct139_, Enum0.Attached, bool_0: true));
		num += smethod_244("camflow/applies at select", (Enum12)1, Class61.smethod_0(struct67_, struct139_, Enum0.Selected, bool_0: true));
		num += smethod_244("camflow/applies while started", (Enum12)1, Class61.smethod_0(struct67_, struct139_, Enum0.Started, bool_0: true));
		num += smethod_244("camflow/leaving the world restores", (Enum12)2, Class61.smethod_0(struct67_, struct139_2, Enum0.Attached, bool_0: true));
		num += smethod_244("camflow/nothing to restore is quiet", (Enum12)0, Class61.smethod_0(struct67_, struct139_, Enum0.Attached, bool_0: true));
		num += smethod_244("camflow/untick restores", (Enum12)2, Class61.smethod_0(struct67_2, struct139_2, Enum0.Started, bool_0: true));
		num += smethod_244("camflow/untick with nothing on is quiet", (Enum12)0, Class61.smethod_0(struct67_2, struct139_, Enum0.Started, bool_0: true));
		num += smethod_244("camflow/already on sends nothing", (Enum12)0, Class61.smethod_0(struct67_, struct139_2, Enum0.Started, bool_0: true));
		num += smethod_244("camcmd/on", "{\"cmd\":\"cam\",\"on\":true,\"ceiling\":1000,\"topRadius\":5}", Class178.smethod_0(1000, 5));
		num += smethod_244("camcmd/off", "{\"cmd\":\"cam\",\"on\":false}", Class178.smethod_1());
		Console.WriteLine("cam: " + num + " failed");
		return num;
	}

	public static int smethod_148()
	{
		int num = 0;
		num = 0 + smethod_243("zonetop/apply without zonetop rows", Class357.smethod_15(smethod_230(Class357.valueTuple_0), out var string_));
		num += smethod_243("zonetop/zone available without zonetop rows", Class357.smethod_22());
		num += smethod_243("zonetop/zonetop off without its rows", !Class357.smethod_46());
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("zonetop/message keeps zone keys", text.Contains("\"rvaMaterialCtor\":"));
		num += smethod_243("zonetop/message omits SetInt", !text.Contains("\"rvaMaterialSetInt\":"));
		num += smethod_243("zonetop/message omits renderQueue", !text.Contains("\"rvaMaterialSetRenderQueue\":"));
		List<(string, string)> list = new List<(string, string)>(Class357.valueTuple_0) { Class357.valueTuple_12[0] };
		num += smethod_243("zonetop/apply with half the group", Class357.smethod_15(smethod_230(list.ToArray()), out string_));
		num += smethod_243("zonetop/zone available with half the group", Class357.smethod_22());
		num += smethod_243("zonetop/half the group is off", !Class357.smethod_46());
		text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("zonetop/half the group sends neither key", !text.Contains("\"rvaMaterialSetInt\":") && !text.Contains("\"rvaMaterialSetRenderQueue\":"));
		List<(string, string)> list2 = new List<(string, string)>(Class357.valueTuple_0);
		list2.AddRange(Class357.valueTuple_12);
		num += smethod_243("zonetop/apply with both groups", Class357.smethod_15(smethod_230(list2.ToArray()), out string_));
		num += smethod_243("zonetop/zone available with both", Class357.smethod_22());
		num += smethod_243("zonetop/zonetop available with both", Class357.smethod_46());
		text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("zonetop/message carries SetInt", text.Contains("\"rvaMaterialSetInt\":"));
		num += smethod_243("zonetop/message carries renderQueue", text.Contains("\"rvaMaterialSetRenderQueue\":"));
		(string, string)[] valueTuple_ = Class357.valueTuple_12;
		for (int i = 0; i < valueTuple_.Length; i++)
		{
			(string, string) tuple = valueTuple_[i];
			(string, string)[] valueTuple_2 = Class357.valueTuple_0;
			for (int j = 0; j < valueTuple_2.Length; j++)
			{
				(string, string) tuple2 = valueTuple_2[j];
				num += smethod_243("zonetop/" + tuple.Item1 + " is not a zone row", tuple2.Item1 != tuple.Item1);
			}
		}
		Console.WriteLine("zonetop: " + num + " failed");
		return num;
	}

	public static int smethod_149()
	{
		int num = 0;
		num = 0 + smethod_243("boxbuff/apply required rows", Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out var _));
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("boxbuff/message carries clQItemFact", text.Contains("\"clQItemFact\":" + 844 + ","));
		string text2 = smethod_174(ref num);
		if (text2 != null)
		{
			num += smethod_243("boxbuff/embedded agent requires clQItemFact", text2.Contains("\"clQItemFact\""));
			num += smethod_243("boxbuff/embedded agent writes byte 61", text2.Contains("dv.setUint8(61, cl.add(o.clQItemFact).readU8())"));
		}
		byte[] array = new byte[80];
		array[60] = 1;
		array[61] = 6;
		array[62] = byte.MaxValue;
		array[63] = byte.MaxValue;
		array[64] = 44;
		array[65] = 1;
		Class83 @class = Class83.smethod_1(array);
		num += smethod_243("boxbuff/decode not null", @class != null);
		if (@class != null)
		{
			num += smethod_244("boxbuff/decode ActiveBoxBuff", (byte)6, @class.byte_5);
			num += smethod_244("boxbuff/decode HasDirect unchanged", (byte)1, @class.byte_4);
			num += smethod_244("boxbuff/decode Hp unchanged", (ushort)300, @class.ushort_0);
		}
		array[61] = 0;
		Class83 class2 = Class83.smethod_1(array);
		num += smethod_243("boxbuff/decode no box buff is 0", class2 != null && class2.byte_5 == 0);
		Console.WriteLine("boxbuff: " + num + " failed");
		return num;
	}

	public static int smethod_150()
	{
		int num = 0;
		List<(string, string)> list = new List<(string, string)>(Class357.valueTuple_13);
		list.AddRange(Class357.valueTuple_14);
		num = 0 + smethod_243("selfbuffs/apply boxtime and tabfile", Class357.smethod_15(smethod_230(list.ToArray()), out var string_));
		num += smethod_243("selfbuffs/boxtime available", Class357.smethod_48());
		num += smethod_243("selfbuffs/tabfile available", Class357.smethod_50());
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("selfbuffs/message carries sfQBoxInstance 0", text.Contains("\"sfQBoxInstance\":0,"));
		num += smethod_243("selfbuffs/message carries sfGdmInstance 0", text.Contains("\"sfGdmInstance\":0,"));
		num += smethod_243("selfbuffs/message carries klassStaticFields", text.Contains("\"klassStaticFields\":" + 184 + ","));
		num += smethod_243("selfbuffs/message carries objCachedPtr for boxtime", text.Contains("\"objCachedPtr\":"));
		num += smethod_243("selfbuffs/apply required rows only", Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out string_));
		string text2 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("selfbuffs/no boxtime, no sfQBoxInstance", !text2.Contains("\"sfQBoxInstance\":"));
		num += smethod_243("selfbuffs/no boxtime or tabfile, no klassStaticFields", !text2.Contains("\"klassStaticFields\":"));
		string text3 = smethod_174(ref num);
		if (text3 != null)
		{
			num += smethod_243("selfbuffs/embedded agent lists the zero-ok keys", text3.Contains("var ZERO_OK_KEYS = ["));
			num += smethod_243("selfbuffs/embedded agent tests zero-ok keys for a number", text3.Contains("typeof v !== \"number\""));
		}
		IReadOnlyList<GStruct3> readOnlyList = Class119.smethod_30(JObject.Parse("{\"buffs\":[{\"src\":\"s\",\"slot\":3,\"main\":27,\"sub\":4,\"lv\":9,\"left\":123.5},{\"src\":\"y\",\"slot\":1,\"main\":900,\"sub\":2,\"lv\":1,\"left\":0},{\"src\":\"x\",\"slot\":0,\"main\":5,\"sub\":5,\"lv\":1,\"left\":9}]}"));
		num += smethod_243("selfbuffs/buffs parsed", readOnlyList != null);
		if (readOnlyList != null)
		{
			num += smethod_244("selfbuffs/unknown src skipped", 2, readOnlyList.Count);
		}
		if (readOnlyList != null && readOnlyList.Count == 2)
		{
			GStruct3 gStruct = readOnlyList[0];
			num += smethod_244("selfbuffs/skill is not system", gparam_0: false, gStruct.bool_0);
			num += smethod_244("selfbuffs/skill slot", 3, gStruct.int_0);
			num += smethod_244("selfbuffs/skill main", (ushort)27, gStruct.ushort_0);
			num += smethod_244("selfbuffs/skill sub", (ushort)4, gStruct.ushort_1);
			num += smethod_244("selfbuffs/skill level", 9, gStruct.int_1);
			num += smethod_244("selfbuffs/skill left", 123.5f, gStruct.float_0);
			GStruct3 gStruct2 = readOnlyList[1];
			num += smethod_244("selfbuffs/system is system", gparam_0: true, gStruct2.bool_0);
			num += smethod_244("selfbuffs/system slot", 1, gStruct2.int_0);
			num += smethod_244("selfbuffs/system main", (ushort)900, gStruct2.ushort_0);
			num += smethod_244("selfbuffs/system sub", (ushort)2, gStruct2.ushort_1);
			num += smethod_244("selfbuffs/system level", 1, gStruct2.int_1);
			num += smethod_244("selfbuffs/system left", 0f, gStruct2.float_0);
		}
		IReadOnlyList<GStruct3> readOnlyList2 = Class119.smethod_30(JObject.Parse("{\"buffs\":[]}"));
		num += smethod_243("selfbuffs/empty list parses empty", readOnlyList2 != null && readOnlyList2.Count == 0);
		num += smethod_243("selfbuffs/no buffs field is null", Class119.smethod_30(new JObject()) == null);
		Class145 @class = Class145.class145_0.method_95(null, null, readOnlyList, default(GStruct4), 1, 0);
		num += smethod_244("selfbuffs/world carries the buffs", 2, @class.method_12().Count);
		num += smethod_244("selfbuffs/empty world has no buffs", 0, Class145.class145_0.method_12().Count);
		if (text3 != null)
		{
			num += smethod_243("selfbuffs/embedded agent sends typed buffs", text3.Contains("const ownBuffs = quiet ? [] : selfBuffEntries()") && text3.Contains("buffs: ownBuffs"));
		}
		GStruct4 gstruct4_ = Class119.smethod_37(JObject.Parse("{\"qbox\":{\"type\":6,\"total\":600,\"left\":552.5}}"));
		num += smethod_244("selfbuffs/qbox type", (byte)6, gstruct4_.byte_0);
		num += smethod_244("selfbuffs/qbox total", 600f, gstruct4_.float_0);
		num += smethod_244("selfbuffs/qbox left", 552.5f, gstruct4_.float_1);
		GStruct4 gStruct3 = Class119.smethod_37(JObject.Parse("{\"qbox\":{\"type\":13,\"total\":300,\"left\":-1}}"));
		num += smethod_244("selfbuffs/qbox size type", (byte)13, gStruct3.byte_0);
		num += smethod_244("selfbuffs/qbox size left unknown", -1f, gStruct3.float_1);
		GStruct4 gStruct4 = Class119.smethod_37(new JObject());
		num += smethod_244("selfbuffs/no qbox is type 0", (byte)0, gStruct4.byte_0);
		num += smethod_244("selfbuffs/no qbox left unknown", -1f, gStruct4.float_1);
		Class145 class2 = Class145.class145_0.method_95(null, null, null, gstruct4_, 1, 0);
		num += smethod_244("selfbuffs/world carries the box buff", (byte)6, class2.method_22().byte_0);
		num += smethod_244("selfbuffs/empty world box left unknown", -1f, Class145.class145_0.method_22().float_1);
		if (text3 != null)
		{
			num += smethod_243("selfbuffs/embedded agent sends qbox", text3.Contains("qbox: selfQBox()"));
			num += smethod_243("selfbuffs/embedded agent reads statics by number", text3.Contains("readStaticInstance("));
		}
		(ushort, ushort)[] array = Class119.smethod_38(JObject.Parse("{\"t\":\"skill_tab_ids\",\"tab\":3,\"ok\":true,\"ids\":[\"27:4\",\"65535:65535\",\"27:5\",\"27:6\",\"1:1\",\"2:2\",\"3:3\",\"4:4\",\"5:5\",\"10:2\"]}"));
		num += smethod_243("selfbuffs/tab ids parsed", array != null && array.Length == 10);
		if (array != null && array.Length == 10)
		{
			num += smethod_244("selfbuffs/tab slot 1 main", (ushort)27, array[0].Item1);
			num += smethod_244("selfbuffs/tab slot 1 sub", (ushort)4, array[0].Item2);
			num += smethod_244("selfbuffs/tab slot 2 empty", ushort.MaxValue, array[1].Item1);
			num += smethod_244("selfbuffs/tab slot 10 sub", (ushort)2, array[9].Item2);
		}
		num += smethod_243("selfbuffs/tab ok false is unknown", Class119.smethod_38(JObject.Parse("{\"t\":\"skill_tab_ids\",\"tab\":3,\"ok\":false,\"ids\":[],\"why\":\"no character selected\"}")) == null);
		num += smethod_243("selfbuffs/tab nine ids is unknown", Class119.smethod_38(JObject.Parse("{\"tab\":3,\"ok\":true,\"ids\":[\"1:1\",\"1:1\",\"1:1\",\"1:1\",\"1:1\",\"1:1\",\"1:1\",\"1:1\",\"1:1\"]}")) == null);
		num += smethod_243("selfbuffs/tab id without a colon is unknown", Class119.smethod_38(JObject.Parse("{\"tab\":3,\"ok\":true,\"ids\":[\"27\",\"1:1\",\"1:1\",\"1:1\",\"1:1\",\"1:1\",\"1:1\",\"1:1\",\"1:1\",\"1:1\"]}")) == null);
		num += smethod_244("selfbuffs/tab ids command", "{\"cmd\":\"skill_tab_ids\",\"tab\":3}", Class454.smethod_4(3));
		if (text3 != null)
		{
			num += smethod_243("selfbuffs/embedded agent answers skill_tab_ids", text3.Contains("case \"skill_tab_ids\":"));
			num += smethod_243("selfbuffs/embedded agent reads the window file", text3.Contains("hotkey.save"));
		}
		List<GStruct3> list2 = new List<GStruct3>();
		list2.Add(new GStruct3
		{
			bool_0 = false,
			int_0 = 0,
			ushort_0 = 27,
			ushort_1 = 4,
			int_1 = 1,
			float_0 = 20f
		});
		list2.Add(new GStruct3
		{
			bool_0 = false,
			int_0 = 1,
			ushort_0 = 27,
			ushort_1 = 6,
			int_1 = 1,
			float_0 = 0.5f
		});
		list2.Add(new GStruct3
		{
			bool_0 = true,
			int_0 = 0,
			ushort_0 = 27,
			ushort_1 = 5,
			int_1 = 1,
			float_0 = 0f
		});
		(ushort, ushort)[] array2 = new(ushort, ushort)[10];
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i] = (ushort.MaxValue, ushort.MaxValue);
		}
		array2[0] = (27, 4);
		array2[2] = (27, 5);
		array2[3] = (27, 6);
		(string, Color) tuple = Class91.smethod_3(bool_0: true, array2, 1, list2, "19");
		num += smethod_244("selfbuffs/above threshold text", "20.00", tuple.Item1);
		num += smethod_244("selfbuffs/above threshold is green", Class91.color_0, tuple.Item2);
		(string, Color) tuple2 = Class91.smethod_3(bool_0: true, array2, 1, list2, "20");
		num += smethod_244("selfbuffs/at threshold is red", Class91.color_1, tuple2.Item2);
		(string, Color) tuple3 = Class91.smethod_3(bool_0: true, array2, 3, list2, "5");
		num += smethod_244("selfbuffs/not found text", "0.00", tuple3.Item1);
		num += smethod_244("selfbuffs/not found is red", Class91.color_1, tuple3.Item2);
		(string, Color) tuple4 = Class91.smethod_3(bool_0: false, array2, 1, list2, "5");
		num += smethod_244("selfbuffs/unchecked text", "0", tuple4.Item1);
		num += smethod_244("selfbuffs/unchecked back", Color.Empty, tuple4.Item2);
		(string, Color) tuple5 = Class91.smethod_3(bool_0: true, null, 1, list2, "5");
		num += smethod_244("selfbuffs/ids unknown text", "0", tuple5.Item1);
		num += smethod_244("selfbuffs/ids unknown back", Color.Empty, tuple5.Item2);
		(string, Color) tuple6 = Class91.smethod_3(bool_0: true, array2, 2, list2, "5");
		num += smethod_244("selfbuffs/empty slot text", "0", tuple6.Item1);
		num += smethod_244("selfbuffs/empty slot back", Color.Empty, tuple6.Item2);
		(string, Color) tuple7 = Class91.smethod_3(bool_0: true, array2, 4, list2, string.Empty);
		num += smethod_244("selfbuffs/two decimals", "0.50", tuple7.Item1);
		num += smethod_244("selfbuffs/empty threshold counts as 0", Class91.color_0, tuple7.Item2);
		(string, Color) tuple8 = Class91.smethod_3(bool_0: true, array2, 4, list2, "abc");
		num += smethod_244("selfbuffs/non-numeric threshold counts as 0", Class91.color_0, tuple8.Item2);
		num += smethod_244("selfbuffs/buff 8 is not counted down", "0", Class91.smethod_3(bool_0: true, array2, 8, list2, "5").Item1);
		num += smethod_244("selfbuffs/last countdown buff", 7, 7);
		for (int j = 1; j <= 7; j++)
		{
			int num2 = Class91.smethod_2(j);
			num += smethod_243("selfbuffs/buff " + j + " never writes label30-32", num2 != 30 && num2 != 31 && num2 != 32);
		}
		num += smethod_244("selfbuffs/buff 1 checkbox", 16, Class91.smethod_0(1));
		num += smethod_244("selfbuffs/buff 7 checkbox", 22, Class91.smethod_0(7));
		num += smethod_244("selfbuffs/buff 1 threshold box", 26, Class91.smethod_1(1));
		num += smethod_244("selfbuffs/buff 6 threshold box", 31, Class91.smethod_1(6));
		num += smethod_244("selfbuffs/buff 7 threshold box", 20, Class91.smethod_1(7));
		num += smethod_244("selfbuffs/buff 1 label", 14, Class91.smethod_2(1));
		num += smethod_244("selfbuffs/buff 6 label", 19, Class91.smethod_2(6));
		num += smethod_244("selfbuffs/buff 7 label", 29, Class91.smethod_2(7));
		num += smethod_244("selfbuffs/luckybox none", "# LuckyBox (Lock)", Class91.smethod_4(new GStruct4
		{
			byte_0 = 0,
			float_0 = 0f,
			float_1 = -1f
		}));
		num += smethod_244("selfbuffs/luckybox lucky", "# LuckyBox (Lock) - Lucky 552s", Class91.smethod_4(new GStruct4
		{
			byte_0 = 6,
			float_0 = 600f,
			float_1 = 552.6f
		}));
		num += smethod_243("selfbuffs/luckybox left unknown", Class91.smethod_4(new GStruct4
		{
			byte_0 = 13,
			float_0 = 300f,
			float_1 = -1f
		}).EndsWith("- Size ?s", StringComparison.Ordinal));
		num += smethod_243("selfbuffs/luckybox unknown type", Class91.smethod_4(new GStruct4
		{
			byte_0 = 99,
			float_0 = 30f,
			float_1 = 30f
		}).EndsWith("- Type 99 30s", StringComparison.Ordinal));
		num += smethod_243("selfbuffs/tab ids due on the first tick", Class91.smethod_6(-1L, 0L));
		num += smethod_243("selfbuffs/tab ids not due before 10 s", !Class91.smethod_6(1000L, 10999L));
		num += smethod_243("selfbuffs/tab ids due at 10 s", Class91.smethod_6(1000L, 11000L));
		Console.WriteLine("selfbuffs: " + num + " failed");
		return num;
	}

	public static int smethod_151()
	{
		int num = 0;
		num = 0 + smethod_243("rebuff/apply rebuff rows", Class357.smethod_15(smethod_230(Class357.valueTuple_15), out var string_));
		num += smethod_243("rebuff/rebuff available", Class357.smethod_52());
		num += smethod_243("rebuff/skill is its own group", !Class357.smethod_36());
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("rebuff/message carries sfSkillTabInstance 0", text.Contains("\"sfSkillTabInstance\":0,"));
		num += smethod_243("rebuff/message carries klassStaticFields", text.Contains("\"klassStaticFields\":" + 184 + ","));
		num += smethod_243("rebuff/message carries swoTabIndex", text.Contains("\"swoTabIndex\":" + 44 + ","));
		num += smethod_243("rebuff/message carries pcCastPending", text.Contains("\"pcCastPending\":" + 332 + ","));
		num += smethod_243("rebuff/message carries sdToMove", text.Contains("\"sdToMove\":" + 48 + "}"));
		num += smethod_243("rebuff/apply required rows only", Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out string_));
		string text2 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("rebuff/no rebuff, no sfSkillTabInstance", !text2.Contains("\"sfSkillTabInstance\":"));
		num += smethod_243("rebuff/no skill or rebuff, no swoTabIndex", !text2.Contains("\"swoTabIndex\":"));
		string text3 = smethod_174(ref num);
		if (text3 != null)
		{
			num += smethod_243("rebuff/embedded agent counts the static offset 0 as present", text3.Contains("\"sfSkillTabInstance\""));
		}
		Class74 @class = Class119.smethod_53(JObject.Parse("{\"t\":\"buff_cast\",\"slot\":2,\"result\":\"ok\",\"code\":0,\"settle_ms\":1312,\"timed_out\":false}"));
		num += smethod_244("rebuff/ok slot", 2, @class.int_0);
		num += smethod_244("rebuff/ok result", "ok", @class.string_0);
		num += smethod_244("rebuff/ok code", 0, @class.int_1);
		num += smethod_244("rebuff/ok settle", 1312, @class.int_2);
		num += smethod_243("rebuff/ok not timed out", !@class.bool_0);
		num += smethod_244("rebuff/ok why", string.Empty, @class.string_1);
		Class74 class2 = Class119.smethod_53(JObject.Parse("{\"t\":\"buff_cast\",\"slot\":5,\"result\":\"move\",\"code\":1,\"settle_ms\":5000,\"timed_out\":true}"));
		num += smethod_244("rebuff/move result", "move", class2.string_0);
		num += smethod_244("rebuff/move code", 1, class2.int_1);
		num += smethod_243("rebuff/move timed out", class2.bool_0);
		string[] array = new string[4] { "busy", "mismatch", "error", "unavailable" };
		for (int i = 0; i < array.Length; i++)
		{
			Class74 class3 = Class119.smethod_53(JObject.Parse("{\"t\":\"buff_cast\",\"slot\":3,\"result\":\"" + array[i] + "\",\"why\":\"because\"}"));
			num += smethod_244("rebuff/" + array[i] + " result", array[i], class3.string_0);
			num += smethod_244("rebuff/" + array[i] + " why", "because", class3.string_1);
			num += smethod_244("rebuff/" + array[i] + " has no code", -1, class3.int_1);
			num += smethod_244("rebuff/" + array[i] + " has no settle", -1, class3.int_2);
			num += smethod_243("rebuff/" + array[i] + " not timed out", !class3.bool_0);
		}
		Class74 class4 = Class119.smethod_53(JObject.Parse("{\"t\":\"buff_cast\",\"slot\":1,\"result\":\"not_ready\",\"code\":3}"));
		num += smethod_244("rebuff/not_ready result", "not_ready", class4.string_0);
		num += smethod_244("rebuff/not_ready code", 3, class4.int_1);
		Class74 class5 = Class119.smethod_53(JObject.Parse("{\"t\":\"buff_cast\",\"slot\":1,\"result\":\"invalid\",\"code\":2}"));
		num += smethod_244("rebuff/invalid result", "invalid", class5.string_0);
		num += smethod_244("rebuff/invalid code", 2, class5.int_1);
		Class74 class6 = Class119.smethod_53(new JObject());
		num += smethod_244("rebuff/empty reply slot", 0, class6.int_0);
		num += smethod_244("rebuff/empty reply result", string.Empty, class6.string_0);
		num += smethod_244("rebuff/empty reply code", -1, class6.int_1);
		Class74 class7 = Class119.smethod_53(JObject.Parse("{\"t\":\"buff_cast\",\"slot\":6,\"result\":\"error\",\"code\":null,\"settle_ms\":null}"));
		num += smethod_244("rebuff/null code reads -1", -1, class7.int_1);
		num += smethod_244("rebuff/null settle reads -1", -1, class7.int_2);
		num += smethod_244("rebuff/buff_cast command", "{\"cmd\":\"buff_cast\",\"slot\":4,\"main\":27,\"sub\":5}", Class454.smethod_5(4, 27, 5));
		if (text3 != null)
		{
			num += smethod_243("rebuff/embedded agent answers buff_cast", text3.Contains("case \"buff_cast\":"));
			num += smethod_243("rebuff/embedded agent steps the job on the frame hook", text3.Contains("rebuffStep();"));
			num += smethod_243("rebuff/embedded agent guards the skill walk", text3.Contains("a buff_cast holds the bar"));
			num += smethod_243("rebuff/embedded agent reports its ready key", text3.Contains("rebuffReady"));
			num += smethod_243("rebuff/embedded agent verifies the switch back", text3.Contains("still shows window "));
		}
		(ushort, ushort)[] array2 = new(ushort, ushort)[10];
		for (int j = 0; j < array2.Length; j++)
		{
			array2[j] = (ushort.MaxValue, ushort.MaxValue);
		}
		array2[0] = (27, 1);
		array2[1] = (27, 2);
		array2[2] = (27, 3);
		array2[3] = (27, 4);
		array2[7] = (40, 1);
		array2[8] = (50, 9);
		array2[9] = (50, 10);
		bool[] array3 = new bool[9];
		string[] array4 = new string[9];
		for (int k = 1; k <= 7; k++)
		{
			array4[k] = "10";
		}
		array4[8] = "60";
		List<GStruct3> list = new List<GStruct3>();
		Class342.smethod_2();
		array3[2] = true;
		array3[3] = true;
		bool flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out var int_);
		num += smethod_243("rebuff/a cast holds pick and attack", !flag);
		num += smethod_244("rebuff/first checked slot wins", 2, int_);
		num += smethod_244("rebuff/a send is casting", 1, Class342.smethod_5());
		flag = Class342.smethod_24(100L, bool_1: false, array2, smethod_227(array2, 100L), list, array3, array4, out int_);
		num += smethod_243("rebuff/casting holds pick and attack", !flag);
		num += smethod_244("rebuff/casting sends nothing", 0, int_);
		MethodInfo methodInfo = null;
		MethodInfo methodInfo2 = null;
		MethodInfo[] methods = typeof(Class342).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
		for (int l = 0; l < methods.Length; l++)
		{
			ParameterInfo[] parameters = methods[l].GetParameters();
			if (methods[l].Name == "Step" && parameters.Length == 9 && parameters[8].ParameterType == typeof(bool))
			{
				methodInfo = methods[l];
			}
			if (methods[l].Name == "Send" && parameters.Length == 4)
			{
				methodInfo2 = methods[l];
			}
		}
		num += smethod_243("rebuff/pre-send/prepare-step-is-uncommitted", methodInfo != null);
		num += smethod_243("rebuff/pre-send/send-uses-scalar-ids", methodInfo2 != null);
		if (methodInfo != null && methodInfo2 != null)
		{
			Class342.smethod_2();
			bool[] array5 = new bool[9] { false, false, true, false, false, false, false, false, false };
			string[] array6 = new string[9];
			for (int m = 1; m <= 7; m++)
			{
				array6[m] = "10";
			}
			array6[8] = "60";
			List<GStruct3> list2 = new List<GStruct3>();
			object[] array7 = new object[9]
			{
				0L,
				false,
				array2,
				smethod_227(array2, 0L),
				list2,
				array5,
				array6,
				0,
				false
			};
			bool flag2 = (bool)methodInfo.Invoke(null, array7);
			int num2 = (int)array7[7];
			num += smethod_243("rebuff/pre-send/abort-keeps-idle", !flag2 && num2 == 2 && Class342.smethod_5() == 0);
			ushort item = array2[num2 - 1].Item1;
			ushort item2 = array2[num2 - 1].Item2;
			(ushort, ushort)[] array8 = new(ushort, ushort)[array2.Length];
			Array.Copy(array2, array8, array2.Length);
			array8[num2 - 1] = (99, 99);
			methodInfo2.Invoke(null, new object[4] { num2, item, item2, 0L });
			num += smethod_244("rebuff/pre-send/scalar-send-starts-casting", 1, Class342.smethod_5());
			Class342.smethod_0(new Class74
			{
				int_0 = num2,
				string_0 = "ok",
				int_1 = 0,
				int_2 = 1,
				string_1 = string.Empty
			});
			Class342.smethod_24(100L, bool_1: false, array8, smethod_227(array8, 100L), list2, array5, array6, out int_);
			List<GStruct3> ireadOnlyList_ = new List<GStruct3>
			{
				new GStruct3
				{
					bool_0 = false,
					ushort_0 = item,
					ushort_1 = item2,
					float_0 = 180f
				}
			};
			Class342.smethod_24(200L, bool_1: false, array8, smethod_227(array8, 200L), ireadOnlyList_, array5, array6, out int_);
			num += smethod_244("rebuff/pre-send/tab3-change-keeps-checked-confirmation", 0, Class342.smethod_5());
		}
		list.Add(new GStruct3
		{
			bool_0 = false,
			int_0 = 0,
			ushort_0 = 27,
			ushort_1 = 1,
			int_1 = 1,
			float_0 = 11f
		});
		list.Add(new GStruct3
		{
			bool_0 = false,
			int_0 = 1,
			ushort_0 = 27,
			ushort_1 = 2,
			int_1 = 1,
			float_0 = 10f
		});
		list.Add(new GStruct3
		{
			bool_0 = true,
			int_0 = 0,
			ushort_0 = 27,
			ushort_1 = 3,
			int_1 = 1,
			float_0 = 50f
		});
		num += smethod_243("rebuff/above threshold no cast", !Class342.smethod_28(bool_1: true, array2, 1, list, "10", 0L, 0L));
		num += smethod_243("rebuff/equal threshold casts", Class342.smethod_28(bool_1: true, array2, 2, list, "10", 0L, 0L));
		num += smethod_243("rebuff/absent casts", Class342.smethod_28(bool_1: true, array2, 4, list, "10", 0L, 0L));
		num += smethod_243("rebuff/a system buff is not ours", Class342.smethod_28(bool_1: true, array2, 3, list, "10", 0L, 0L));
		num += smethod_243("rebuff/unchecked no cast", !Class342.smethod_28(bool_1: false, array2, 4, list, "10", 0L, 0L));
		num += smethod_243("rebuff/ids unknown no cast", !Class342.smethod_28(bool_1: true, null, 4, list, "10", 0L, 0L));
		num += smethod_243("rebuff/empty slot no cast", !Class342.smethod_28(bool_1: true, array2, 5, list, "10", 0L, 0L));
		num += smethod_243("rebuff/held slot no cast", !Class342.smethod_28(bool_1: true, array2, 4, list, "10", 1000L, 999L));
		num += smethod_243("rebuff/hold ends at its time", Class342.smethod_28(bool_1: true, array2, 4, list, "10", 1000L, 1000L));
		num += smethod_243("rebuff/buff 8 is not a threshold buff", !Class342.smethod_28(bool_1: true, array2, 8, list, "10", 0L, 0L));
		num += smethod_244("rebuff/empty box is 0", 0, Class342.smethod_33(string.Empty));
		num += smethod_244("rebuff/null box is 0", 0, Class342.smethod_33(null));
		num += smethod_244("rebuff/non-numeric box is 0", 0, Class342.smethod_33("abc"));
		num += smethod_244("rebuff/padded box parses", 15, Class342.smethod_33(" 15 "));
		num += smethod_243("rebuff/11 s left over a bad box no cast", !Class342.smethod_28(bool_1: true, array2, 1, list, "abc", 0L, 0L));
		List<GStruct3> ireadOnlyList_2 = new List<GStruct3>
		{
			new GStruct3
			{
				bool_0 = false,
				ushort_0 = 27,
				ushort_1 = 1,
				float_0 = 0f
			}
		};
		num += smethod_243("rebuff/0 s left over an empty box casts", Class342.smethod_28(bool_1: true, array2, 1, ireadOnlyList_2, string.Empty, 0L, 0L));
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: true, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_243("rebuff/dead runs pick and attack", flag);
		num += smethod_244("rebuff/dead casts nothing", 0, int_);
		num += smethod_244("rebuff/dead stays idle", 0, Class342.smethod_5());
		flag = Class342.smethod_24(0L, bool_1: false, null, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_243("rebuff/ids unknown runs pick and attack", flag && int_ == 0);
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), null, array3, array4, out int_);
		num += smethod_243("rebuff/no census yet runs pick and attack", flag && int_ == 0);
		string[] array9 = new string[4] { "not_ready", "invalid", "mismatch", "error" };
		for (int n = 0; n < array9.Length; n++)
		{
			Class342.smethod_2();
			flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
			Class342.smethod_0(new Class74
			{
				int_0 = int_,
				string_0 = array9[n],
				int_1 = 3,
				int_2 = -1,
				string_1 = "test"
			});
			flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
			num += smethod_244("rebuff/" + array9[n] + " goes idle", 0, Class342.smethod_5());
			flag = Class342.smethod_24(1299L, bool_1: false, array2, smethod_227(array2, 1299L), list, array3, array4, out int_);
			num += smethod_243("rebuff/" + array9[n] + " gap blocks buff 3 too", flag && int_ == 0);
			flag = Class342.smethod_24(1300L, bool_1: false, array2, smethod_227(array2, 1300L), list, array3, array4, out int_);
			num += smethod_244("rebuff/" + array9[n] + " lets buff 3 fire once the gap ends", 3, int_);
		}
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		Class342.smethod_0(new Class74
		{
			int_0 = int_,
			string_0 = "busy",
			int_1 = -1,
			int_2 = -1,
			string_1 = "test"
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/busy goes idle", 0, Class342.smethod_5());
		flag = Class342.smethod_24(1299L, bool_1: false, array2, smethod_227(array2, 1299L), list, array3, array4, out int_);
		num += smethod_243("rebuff/busy gap blocks buff 3 too", flag && int_ == 0);
		flag = Class342.smethod_24(1300L, bool_1: false, array2, smethod_227(array2, 1300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/busy retries the same slot once the gap ends", 2, int_);
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		flag = Class342.smethod_24(6999L, bool_1: false, array2, smethod_227(array2, 6999L), list, array3, array4, out int_);
		num += smethod_244("rebuff/casting waits 7 s", 1, Class342.smethod_5());
		flag = Class342.smethod_24(7000L, bool_1: false, array2, smethod_227(array2, 7000L), list, array3, array4, out int_);
		num += smethod_244("rebuff/casting timeout goes idle", 0, Class342.smethod_5());
		flag = Class342.smethod_24(7300L, bool_1: false, array2, smethod_227(array2, 7300L), list, array3, array4, out int_);
		num += smethod_243("rebuff/casting timeout gap blocks buff 3 too", flag && int_ == 0);
		flag = Class342.smethod_24(8000L, bool_1: false, array2, smethod_227(array2, 8000L), list, array3, array4, out int_);
		num += smethod_244("rebuff/casting timeout holds the slot", 3, int_);
		array3[2] = false;
		array3[3] = false;
		array3[8] = true;
		Class342.smethod_2();
		flag = Class342.smethod_24(1000L, bool_1: false, array2, smethod_227(array2, 1000L), list, array3, array4, out int_);
		num += smethod_244("rebuff/buff 8 first cast at once", 8, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 8,
			string_0 = "ok",
			int_1 = 0,
			int_2 = 1300,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(1000L, bool_1: false, array2, smethod_227(array2, 1000L), list, array3, array4, out int_);
		num += smethod_244("rebuff/buff 8 ok needs no confirm", 0, Class342.smethod_5());
		num += smethod_244("rebuff/buff 8 ok restarts the interval", 1000L, Class342.smethod_6());
		flag = Class342.smethod_24(60999L, bool_1: false, array2, smethod_227(array2, 60999L), list, array3, array4, out int_);
		num += smethod_243("rebuff/buff 8 not due before N", flag && int_ == 0);
		flag = Class342.smethod_24(61000L, bool_1: false, array2, smethod_227(array2, 61000L), list, array3, array4, out int_);
		num += smethod_244("rebuff/buff 8 due at N", 8, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 8,
			string_0 = "not_ready",
			int_1 = 3,
			int_2 = -1,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(61300L, bool_1: false, array2, smethod_227(array2, 61300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/buff 8 not_ready keeps the last ok", 1000L, Class342.smethod_6());
		flag = Class342.smethod_24(62300L, bool_1: false, array2, smethod_227(array2, 62300L), list, array3, array4, out int_);
		num += smethod_243("rebuff/buff 8 not due while the 5 s hold still runs", flag && int_ == 0);
		flag = Class342.smethod_24(66300L, bool_1: false, array2, smethod_227(array2, 66300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/buff 8 retries after the 5 s hold", 8, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 8,
			string_0 = "move",
			int_1 = 1,
			int_2 = 2100,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(66600L, bool_1: false, array2, smethod_227(array2, 66600L), list, array3, array4, out int_);
		num += smethod_244("rebuff/buff 8 move restarts the interval", 66600L, Class342.smethod_6());
		(ushort, ushort)[] array10 = new(ushort, ushort)[10];
		for (int num3 = 0; num3 < array10.Length; num3++)
		{
			array10[num3] = (ushort.MaxValue, ushort.MaxValue);
		}
		num += smethod_243("rebuff/interval never cast is due", Class342.smethod_30(bool_1: true, array2, "60", -1L, 0L, 0L));
		num += smethod_243("rebuff/interval 0 is never due", !Class342.smethod_30(bool_1: true, array2, "0", -1L, 0L, 0L));
		num += smethod_243("rebuff/interval bad box is never due", !Class342.smethod_30(bool_1: true, array2, "abc", -1L, 0L, 0L));
		num += smethod_243("rebuff/interval unchecked is never due", !Class342.smethod_30(bool_1: false, array2, "60", -1L, 0L, 0L));
		num += smethod_243("rebuff/interval ids unknown is never due", !Class342.smethod_30(bool_1: true, null, "60", -1L, 0L, 0L));
		num += smethod_243("rebuff/interval empty slot 8 is never due", !Class342.smethod_30(bool_1: true, array10, "60", -1L, 0L, 0L));
		num += smethod_243("rebuff/interval held is not due", !Class342.smethod_30(bool_1: true, array2, "60", -1L, 500L, 0L));
		Class342.smethod_2();
		array3[2] = true;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_244("rebuff/buff 1-7 go before buff 8", 2, int_);
		array3[3] = true;
		array3[8] = false;
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = "ok",
			int_1 = 0,
			int_2 = 1400,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(1500L, bool_1: false, array2, smethod_227(array2, 1500L), list, array3, array4, out int_);
		num += smethod_244("rebuff/ok for buff 1-7 confirms", 2, Class342.smethod_5());
		flag = Class342.smethod_24(1800L, bool_1: false, array2, smethod_227(array2, 1800L), list, array3, array4, out int_);
		num += smethod_243("rebuff/confirming lets pick and attack run", flag && int_ == 0);
		List<GStruct3> ireadOnlyList_3 = new List<GStruct3>
		{
			new GStruct3
			{
				bool_0 = false,
				ushort_0 = 27,
				ushort_1 = 2,
				float_0 = 180f
			}
		};
		flag = Class342.smethod_24(2100L, bool_1: false, array2, smethod_227(array2, 2100L), ireadOnlyList_3, array3, array4, out int_);
		num += smethod_244("rebuff/the new time left confirms", 0, Class342.smethod_5());
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = "move",
			int_1 = 1,
			int_2 = 3000,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/move for buff 1-7 confirms", 2, Class342.smethod_5());
		flag = Class342.smethod_24(5299L, bool_1: false, array2, smethod_227(array2, 5299L), list, array3, array4, out int_);
		num += smethod_244("rebuff/confirming waits 5 s", 2, Class342.smethod_5());
		flag = Class342.smethod_24(5300L, bool_1: false, array2, smethod_227(array2, 5300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/confirming timeout goes idle", 0, Class342.smethod_5());
		flag = Class342.smethod_24(5600L, bool_1: false, array2, smethod_227(array2, 5600L), list, array3, array4, out int_);
		num += smethod_243("rebuff/confirming timeout gap blocks buff 3 too", flag && int_ == 0);
		flag = Class342.smethod_24(6300L, bool_1: false, array2, smethod_227(array2, 6300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/confirming timeout holds the slot", 3, int_);
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 5,
			string_0 = "ok",
			int_1 = 0,
			int_2 = 1000,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/another slot's reply is dropped", 1, Class342.smethod_5());
		Class342.smethod_2();
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = "ok",
			int_1 = 0,
			int_2 = 1000,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/a reply from before the send is dropped", 1, Class342.smethod_5());
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = "unavailable",
			int_1 = -1,
			int_2 = -1,
			string_1 = "the skill tier is not armed"
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		flag = Class342.smethod_24(600L, bool_1: false, array2, smethod_227(array2, 600L), list, array3, array4, out int_);
		num += smethod_243("rebuff/unavailable stops buffing", flag && int_ == 0);
		Class342.smethod_2();
		flag = Class342.smethod_24(900L, bool_1: false, array2, smethod_227(array2, 900L), list, array3, array4, out int_);
		num += smethod_244("rebuff/reset starts buffing again", 2, int_);
		Class342.smethod_2();
		(string, Color) tuple = Class91.smethod_11(bool_0: true, 1000L, 11500L, "60");
		num += smethod_244("rebuff/label30 counts down", "49.50", tuple.Item1);
		num += smethod_244("rebuff/label30 counting is green", Class91.color_0, tuple.Item2);
		(string, Color) tuple2 = Class91.smethod_11(bool_0: true, 1000L, 61000L, "60");
		num += smethod_244("rebuff/label30 at 0", "0.00", tuple2.Item1);
		num += smethod_244("rebuff/label30 at 0 is red", Class91.color_1, tuple2.Item2);
		(string, Color) tuple3 = Class91.smethod_11(bool_0: true, 1000L, 70000L, "60");
		num += smethod_244("rebuff/label30 past due stays 0.00", "0.00", tuple3.Item1);
		num += smethod_244("rebuff/label30 past due is red", Class91.color_1, tuple3.Item2);
		(string, Color) tuple4 = Class91.smethod_11(bool_0: true, -1L, 5000L, "60");
		num += smethod_244("rebuff/label30 never cast", "0.00", tuple4.Item1);
		num += smethod_244("rebuff/label30 never cast is red", Class91.color_1, tuple4.Item2);
		(string, Color) tuple5 = Class91.smethod_11(bool_0: false, 1000L, 11500L, "60");
		num += smethod_244("rebuff/label30 unchecked text", "0", tuple5.Item1);
		num += smethod_244("rebuff/label30 unchecked back", Color.Empty, tuple5.Item2);
		(string, Color) tuple6 = Class91.smethod_11(bool_0: true, 1000L, 1000L, "abc");
		num += smethod_244("rebuff/label30 bad box counts as 0", "0.00", tuple6.Item1);
		num += smethod_244("rebuff/label30 bad box is red", Class91.color_1, tuple6.Item2);
		num += smethod_244("rebuff/label30 number", 30, 30);
		num += smethod_244("rebuff/buff 8 checkbox", 23, Class91.smethod_0(8));
		num += smethod_244("rebuff/buff 8 interval box", 21, 21);
		Class342.smethod_2();
		for (int num4 = 1; num4 <= 8; num4++)
		{
			array3[num4] = false;
		}
		array3[2] = true;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_244("rebuff/a: buff 2 sent", 2, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = "not_ready",
			int_1 = 3,
			int_2 = -1,
			string_1 = "test"
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/a: not_ready goes idle", 0, Class342.smethod_5());
		flag = Class342.smethod_24(5200L, bool_1: false, array2, smethod_227(array2, 5200L), list, array3, array4, out int_);
		num += smethod_243("rebuff/a: not re-attempted before 5 s", flag && int_ == 0);
		flag = Class342.smethod_24(5300L, bool_1: false, array2, smethod_227(array2, 5300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/a: retried at 5 s", 2, int_);
		Class342.smethod_2();
		for (int num5 = 1; num5 <= 8; num5++)
		{
			array3[num5] = false;
		}
		array3[2] = true;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_244("rebuff/b: buff 2 sent", 2, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = "busy",
			int_1 = -1,
			int_2 = -1,
			string_1 = "test"
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/b: busy goes idle", 0, Class342.smethod_5());
		flag = Class342.smethod_24(1200L, bool_1: false, array2, smethod_227(array2, 1200L), list, array3, array4, out int_);
		num += smethod_243("rebuff/b: not re-attempted before 1 s", flag && int_ == 0);
		flag = Class342.smethod_24(1300L, bool_1: false, array2, smethod_227(array2, 1300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/b: retried at 1 s", 2, int_);
		Class342.smethod_2();
		for (int num6 = 1; num6 <= 8; num6++)
		{
			array3[num6] = false;
		}
		array3[2] = true;
		array3[3] = true;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_244("rebuff/c: buff 2 sent first", 2, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = "invalid",
			int_1 = 2,
			int_2 = -1,
			string_1 = "test"
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/c: invalid goes idle", 0, Class342.smethod_5());
		flag = Class342.smethod_24(999L, bool_1: false, array2, smethod_227(array2, 999L), list, array3, array4, out int_);
		num += smethod_243("rebuff/c: gap still blocks buff 3 midway", flag && int_ == 0);
		flag = Class342.smethod_24(1299L, bool_1: false, array2, smethod_227(array2, 1299L), list, array3, array4, out int_);
		num += smethod_243("rebuff/c: gap blocks buff 3 right up to the end", flag && int_ == 0);
		flag = Class342.smethod_24(1300L, bool_1: false, array2, smethod_227(array2, 1300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/c: buff 3 fires once the gap ends", 3, int_);
		Class342.smethod_2();
		for (int num7 = 1; num7 <= 8; num7++)
		{
			array3[num7] = false;
		}
		array3[1] = true;
		array3[2] = true;
		array3[3] = true;
		List<GStruct3> ireadOnlyList_4 = new List<GStruct3>();
		long num8 = 0L;
		int num9 = 0;
		for (int num10 = 0; num10 < 30; num10++)
		{
			if (flag = Class342.smethod_24(num8, bool_1: false, array2, smethod_227(array2, num8), ireadOnlyList_4, array3, array4, out int_))
			{
				num9++;
			}
			if (int_ != 0)
			{
				Class342.smethod_0(new Class74
				{
					int_0 = int_,
					string_0 = "not_ready",
					int_1 = 3,
					int_2 = -1,
					string_1 = "test"
				});
			}
			num8 += 300L;
		}
		num += smethod_243("rebuff/d: at least a third of 30 ticks free pick and attack", num9 * 3 >= 30);
		Class342.smethod_2();
		for (int num11 = 1; num11 <= 8; num11++)
		{
			array3[num11] = false;
		}
		array3[2] = true;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_244("rebuff/f: buff 2 sent", 2, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = "not_ready",
			int_1 = 3,
			int_2 = -1,
			string_1 = "test"
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244("rebuff/f: not_ready goes idle", 0, Class342.smethod_5());
		flag = Class342.smethod_24(600L, bool_1: false, array2, smethod_227(array2, 600L), list, array3, array4, out int_);
		num += smethod_243("rebuff/f: still held and gapped before reset", flag && int_ == 0);
		Class342.smethod_2();
		flag = Class342.smethod_24(600L, bool_1: false, array2, smethod_227(array2, 600L), list, array3, array4, out int_);
		num += smethod_244("rebuff/f: reset clears the hold and the gap - buff 2 fires at once", 2, int_);
		Class342.smethod_2();
		for (int num12 = 1; num12 <= 8; num12++)
		{
			array3[num12] = false;
		}
		array3[2] = true;
		array3[3] = true;
		array3[8] = true;
		List<GStruct3> ireadOnlyList_5 = new List<GStruct3>();
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_244("rebuff/cf1: buff 2 sent", 2, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = "ok",
			int_1 = 0,
			int_2 = 1400,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_243("rebuff/cf1: the tick that reads ok still holds pick and attack", !flag && int_ == 0);
		num += smethod_244("rebuff/cf1: ok is confirming", 2, Class342.smethod_5());
		flag = Class342.smethod_24(600L, bool_1: false, array2, smethod_227(array2, 600L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_243("rebuff/cf1: confirming lets pick and attack run", flag && int_ == 0);
		int num13 = 0;
		for (long num14 = 900L; num14 < 5100L; num14 += 300L)
		{
			flag = Class342.smethod_24(num14, bool_1: false, array2, smethod_227(array2, num14), ireadOnlyList_5, array3, array4, out int_);
			if (int_ != 0)
			{
				num13++;
			}
		}
		num += smethod_244("rebuff/cf2: no slot starts while confirming", 0, num13);
		num += smethod_244("rebuff/cf2: still confirming inside 5 s", 2, Class342.smethod_5());
		List<GStruct3> ireadOnlyList_6 = new List<GStruct3>
		{
			new GStruct3
			{
				bool_0 = false,
				ushort_0 = 27,
				ushort_1 = 2,
				float_0 = 180f
			}
		};
		flag = Class342.smethod_24(5100L, bool_1: false, array2, smethod_227(array2, 5100L), ireadOnlyList_6, array3, array4, out int_);
		num += smethod_244("rebuff/cf3: the buff showing resolves to idle", 0, Class342.smethod_5());
		num += smethod_243("rebuff/cf3: the resolving tick runs pick and attack and starts nothing", flag && int_ == 0);
		flag = Class342.smethod_24(5400L, bool_1: false, array2, smethod_227(array2, 5400L), ireadOnlyList_6, array3, array4, out int_);
		num += smethod_244("rebuff/cf3: the next due slot starts on the next tick", 3, int_);
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), ireadOnlyList_5, array3, array4, out int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = "ok",
			int_1 = 0,
			int_2 = 1400,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), ireadOnlyList_5, array3, array4, out int_);
		int num15 = 0;
		for (long num16 = 600L; num16 < 5300L; num16 += 300L)
		{
			if (!(flag = Class342.smethod_24(num16, bool_1: false, array2, smethod_227(array2, num16), ireadOnlyList_5, array3, array4, out int_)) || int_ != 0)
			{
				num15++;
			}
		}
		num += smethod_244("rebuff/cf4: every confirming tick runs pick and attack", 0, num15);
		flag = Class342.smethod_24(5300L, bool_1: false, array2, smethod_227(array2, 5300L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_244("rebuff/cf4: the timeout goes idle", 0, Class342.smethod_5());
		num += smethod_243("rebuff/cf4: the timeout tick runs pick and attack", flag && int_ == 0);
		flag = Class342.smethod_24(6299L, bool_1: false, array2, smethod_227(array2, 6299L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_243("rebuff/cf4: the timeout gap blocks buff 3", flag && int_ == 0);
		flag = Class342.smethod_24(6300L, bool_1: false, array2, smethod_227(array2, 6300L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_244("rebuff/cf4: buff 3 goes once the gap ends, buff 2 is held", 3, int_);
		array3[3] = false;
		array3[8] = false;
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), ireadOnlyList_5, array3, array4, out int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = "ok",
			int_1 = 0,
			int_2 = 1400,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), ireadOnlyList_5, array3, array4, out int_);
		flag = Class342.smethod_24(5300L, bool_1: false, array2, smethod_227(array2, 5300L), ireadOnlyList_5, array3, array4, out int_);
		flag = Class342.smethod_24(10299L, bool_1: false, array2, smethod_227(array2, 10299L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_243("rebuff/cf4: the timeout holds buff 2 5 s", flag && int_ == 0);
		flag = Class342.smethod_24(10300L, bool_1: false, array2, smethod_227(array2, 10300L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_244("rebuff/cf4: buff 2 retries when the hold ends", 2, int_);
		Class342.smethod_2();
		array3[1] = true;
		long num17 = 0L;
		int num18 = 0;
		for (int num19 = 0; num19 < 200; num19++)
		{
			if (flag = Class342.smethod_24(num17, bool_1: false, array2, smethod_227(array2, num17), ireadOnlyList_5, array3, array4, out int_))
			{
				num18++;
			}
			if (int_ != 0)
			{
				Class342.smethod_0(new Class74
				{
					int_0 = int_,
					string_0 = "ok",
					int_1 = 0,
					int_2 = 1400,
					string_1 = string.Empty
				});
			}
			num17 += 300L;
		}
		num += smethod_243("rebuff/cf4: slots that answer ok but never show leave half the ticks free", num18 * 2 >= 200);
		for (int num20 = 1; num20 <= 8; num20++)
		{
			array3[num20] = false;
		}
		Class342.smethod_2();
		List<GStruct3> ireadOnlyList_7 = new List<GStruct3>();
		for (int num21 = 1; num21 <= 8; num21++)
		{
			array3[num21] = false;
		}
		Class342.smethod_2();
		array3[1] = true;
		flag = Class342.smethod_24(1000L, bool_1: false, array2, smethod_228(1000L, new Struct16[1] { smethod_229(27, 1, 0) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243("rebuff/r1: due and ready holds pick and attack", !flag);
		num += smethod_244("rebuff/r1: due and ready casts buff 1", 1, int_);
		num += smethod_244("rebuff/r1: due and ready is casting", 1, Class342.smethod_5());
		Class342.smethod_2();
		array3[2] = true;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_228(0L, new Struct16[2]
		{
			smethod_229(27, 1, 2),
			smethod_229(27, 2, 0)
		}), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_244("rebuff/r2: a cooling buff 1 lets buff 2 cast in the same tick", 2, int_);
		Class342.smethod_2();
		array3[2] = false;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_228(0L, new Struct16[1] { smethod_229(27, 1, 2) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243("rebuff/r2: a cooling slot costs no tick", flag && int_ == 0);
		num += smethod_244("rebuff/r2: a cooling slot stays idle", 0, Class342.smethod_5());
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_228(300L, new Struct16[1] { smethod_229(27, 1, 0) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_244("rebuff/r2: no hold and no gap after a cooling skip", 1, int_);
		num += smethod_244("rebuff/r3: max age", 1000, 1000);
		Class342.smethod_2();
		flag = Class342.smethod_24(2001L, bool_1: false, array2, smethod_228(1000L, new Struct16[1] { smethod_229(27, 1, 0) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243("rebuff/r3: ready 1001 ms old is skipped", flag && int_ == 0);
		Class342.smethod_2();
		flag = Class342.smethod_24(2000L, bool_1: false, array2, smethod_228(1000L, new Struct16[1] { smethod_229(27, 1, 0) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_244("rebuff/r3: ready exactly 1000 ms old casts", 1, int_);
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, null, ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243("rebuff/r4: no skill_ready yet is skipped", flag && int_ == 0);
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_228(0L, Array.Empty<Struct16>()), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243("rebuff/r4: a reply without buff 1's id is skipped", flag && int_ == 0);
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_228(0L, new Struct16[1] { smethod_229(27, 9, 0) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243("rebuff/r4: another sub is not buff 1", flag && int_ == 0);
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_228(0L, new Struct16[1] { smethod_229(28, 1, 0) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243("rebuff/r4: another main is not buff 1", flag && int_ == 0);
		num += smethod_243("rebuff/r4: a snapshot with no id list is not ready", !Class342.smethod_26(27, 1, new Class358
		{
			long_0 = 0L,
			struct16_0 = null
		}, 0L));
		num += smethod_243("rebuff/r4: the matching id is ready", Class342.smethod_26(27, 1, smethod_228(0L, new Struct16[2]
		{
			smethod_229(27, 9, 0),
			smethod_229(27, 1, 0)
		}), 0L));
		Class342.smethod_2();
		array3[1] = false;
		array3[8] = true;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_228(0L, new Struct16[1] { smethod_229(40, 1, 2) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243("rebuff/r5: buff 8 due but cooling is skipped", flag && int_ == 0);
		num += smethod_244("rebuff/r5: a buff 8 skip is not a cast", -1L, Class342.smethod_6());
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_228(300L, new Struct16[1] { smethod_229(40, 1, 0) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_244("rebuff/r5: buff 8 casts once ready", 8, int_);
		Class342.smethod_2();
		array3[1] = true;
		array3[2] = true;
		array3[3] = true;
		Class358 class8 = smethod_228(0L, new Struct16[4]
		{
			smethod_229(27, 1, 2),
			smethod_229(27, 2, 7),
			smethod_229(27, 3, 1),
			smethod_229(40, 1, 13)
		});
		int num22 = 0;
		for (int num23 = 0; num23 < 10; num23++)
		{
			class8.long_0 = num23 * 300L;
			if ((flag = Class342.smethod_24(num23 * 300L, bool_1: false, array2, class8, ireadOnlyList_7, array3, array4, out int_)) && int_ == 0)
			{
				num22++;
			}
		}
		num += smethod_244("rebuff/r6: nothing ready runs pick and attack every tick", 10, num22);
		num += smethod_244("rebuff/r6: nothing ready stays idle", 0, Class342.smethod_5());
		num += smethod_243("rebuff/r6: code -1 is not ready", !Class342.smethod_26(27, 1, smethod_228(0L, new Struct16[1] { smethod_229(27, 1, -1) }), 0L));
		for (int num24 = 1; num24 <= 8; num24++)
		{
			array3[num24] = false;
		}
		Class342.smethod_2();
		Class358 class9 = smethod_228(5L, new Struct16[1] { smethod_229(1, 1, 0) });
		Class358 class10 = Class119.smethod_54(JObject.Parse("{\"t\":\"skill_ready\",\"ok\":true,\"ids\":[{\"main\":27,\"sub\":1,\"code\":0},{\"main\":40,\"sub\":1,\"code\":2}]}"), 1234L, class9);
		num += smethod_243("rebuff/r7: a valid reply is a new snapshot", class10 != null && class10 != class9);
		if (class10 != null && class10.struct16_0 != null && class10.struct16_0.Length == 2)
		{
			num += smethod_244("rebuff/r7: receive time", 1234L, class10.long_0);
			num += smethod_244("rebuff/r7: row 0 main", (ushort)27, class10.struct16_0[0].ushort_0);
			num += smethod_244("rebuff/r7: row 0 sub", (ushort)1, class10.struct16_0[0].ushort_1);
			num += smethod_244("rebuff/r7: row 0 code", 0, class10.struct16_0[0].int_0);
			num += smethod_244("rebuff/r7: row 1 main", (ushort)40, class10.struct16_0[1].ushort_0);
			num += smethod_244("rebuff/r7: row 1 code", 2, class10.struct16_0[1].int_0);
		}
		else
		{
			num += smethod_243("rebuff/r7: a valid reply has two rows", bool_0: false);
		}
		Class358 class11 = Class119.smethod_54(JObject.Parse("{\"t\":\"skill_ready\",\"ok\":true,\"ids\":[]}"), 1500L, class9);
		num += smethod_243("rebuff/r7: an ok reply with no ids is a fresh empty snapshot", class11 != null && class11.long_0 == 1500L && class11.struct16_0 != null && class11.struct16_0.Length == 0);
		JObject jobject_ = JObject.Parse("{\"t\":\"skill_ready\",\"ok\":false,\"reason\":\"the skill tier is not armed\"}");
		num += smethod_243("rebuff/r7: ok:false keeps the last snapshot", class9 == Class119.smethod_54(jobject_, 2000L, class9));
		num += smethod_243("rebuff/r7: ok:false records nothing", Class119.smethod_54(jobject_, 2000L, null) == null);
		string[] array11 = new string[7] { "{\"t\":\"skill_ready\"}", "{\"t\":\"skill_ready\",\"ok\":\"true\",\"ids\":[]}", "{\"t\":\"skill_ready\",\"ok\":null,\"ids\":[]}", "{\"t\":\"skill_ready\",\"ok\":true}", "{\"t\":\"skill_ready\",\"ok\":true,\"ids\":5}", "{\"t\":\"skill_ready\",\"ok\":true,\"ids\":null}", "{\"t\":\"skill_ready\",\"ok\":true,\"ids\":{\"main\":27,\"sub\":1,\"code\":0}}" };
		for (int num25 = 0; num25 < array11.Length; num25++)
		{
			Class358 class12 = null;
			bool flag3 = false;
			try
			{
				class12 = Class119.smethod_54(JObject.Parse(array11[num25]), 3000L, class9);
			}
			catch
			{
				flag3 = true;
			}
			num += smethod_243("rebuff/r7: malformed " + num25 + " does not throw", !flag3);
			num += smethod_243("rebuff/r7: malformed " + num25 + " keeps the last snapshot", class9 == class12);
		}
		Class358 class13 = null;
		bool flag4 = false;
		try
		{
			class13 = Class119.smethod_54(JObject.Parse("{\"t\":\"skill_ready\",\"ok\":true,\"ids\":[7,\"x\",null,[27,1],{\"main\":\"27\",\"sub\":1,\"code\":0},{\"main\":27,\"sub\":1.5,\"code\":0},{\"main\":27,\"code\":0},{\"main\":70000,\"sub\":1,\"code\":0},{\"main\":-1,\"sub\":1,\"code\":0},{\"main\":99999999999999999999,\"sub\":1,\"code\":0},{\"main\":27,\"sub\":3,\"code\":0}]}"), 4000L, class9);
		}
		catch
		{
			flag4 = true;
		}
		num += smethod_243("rebuff/r7: bad rows do not throw", !flag4);
		num += smethod_243("rebuff/r7: bad rows are dropped, the good row stays", class13 != null && class13.struct16_0 != null && class13.struct16_0.Length == 1 && class13.struct16_0[0].ushort_0 == 27 && class13.struct16_0[0].ushort_1 == 3 && class13.struct16_0[0].int_0 == 0);
		Class358 class14 = null;
		bool flag5 = false;
		try
		{
			class14 = Class119.smethod_54(JObject.Parse("{\"t\":\"skill_ready\",\"ok\":true,\"ids\":[{\"main\":27,\"sub\":1,\"code\":null},{\"main\":27,\"sub\":2},{\"main\":27,\"sub\":3,\"code\":\"0\"},{\"main\":27,\"sub\":4,\"code\":0.0},{\"main\":27,\"sub\":5,\"code\":99999999999999999999}]}"), 5000L, class9);
		}
		catch
		{
			flag5 = true;
		}
		num += smethod_243("rebuff/r7: bad codes do not throw", !flag5);
		num += smethod_243("rebuff/r7: bad codes keep their rows", class14 != null && class14.struct16_0 != null && class14.struct16_0.Length == 5);
		if (class14 != null && class14.struct16_0 != null && class14.struct16_0.Length == 5)
		{
			for (int num26 = 0; num26 < 5; num26++)
			{
				num += smethod_244("rebuff/r7: bad code " + num26 + " reads -1", -1, class14.struct16_0[num26].int_0);
			}
		}
		num += smethod_243("rebuff/r7: code null is not ready", !Class342.smethod_26(27, 1, class14, 5000L));
		StringBuilder stringBuilder = new StringBuilder("{\"t\":\"skill_ready\",\"ok\":true,\"ids\":[");
		for (int num27 = 0; num27 < 12; num27++)
		{
			stringBuilder.Append((num27 == 0) ? string.Empty : ",").Append("{\"main\":27,\"sub\":" + num27 + ",\"code\":0}");
		}
		stringBuilder.Append("]}");
		Class358 class15 = Class119.smethod_54(JObject.Parse(stringBuilder.ToString()), 6000L, class9);
		num += smethod_243("rebuff/r7: rows past the cap are dropped", class15 != null && class15.struct16_0 != null && class15.struct16_0.Length == 10);
		num += smethod_244("rebuff/r7: the cap covers all ten slots", 10, 10);
		num += smethod_244("rebuff/r8: poll every 500 ms", 500, 500);
		num += smethod_243("rebuff/r8: due on the first tick", Class91.smethod_8(bool_0: true, array2, 1, -1L, 0L));
		num += smethod_243("rebuff/r8: not due before 500 ms", !Class91.smethod_8(bool_0: true, array2, 1, 1000L, 1499L));
		num += smethod_243("rebuff/r8: due at 500 ms", Class91.smethod_8(bool_0: true, array2, 1, 1000L, 1500L));
		num += smethod_243("rebuff/r8: not while stopped", !Class91.smethod_8(bool_0: false, array2, 1, -1L, 0L));
		num += smethod_243("rebuff/r8: not with no buff checked", !Class91.smethod_8(bool_0: true, array2, 0, -1L, 0L));
		num += smethod_243("rebuff/r8: not while the window 3 ids are unknown", !Class91.smethod_8(bool_0: true, null, 1, -1L, 0L));
		bool[] bool_ = new bool[11]
		{
			false, false, true, false, true, true, false, false, true, true,
			true
		};
		List<(ushort, ushort)> list3 = Class91.smethod_9(bool_, array2);
		num += smethod_244("rebuff/r8: ids of the checked slots only", 5, list3.Count);
		if (list3.Count == 5)
		{
			num += smethod_244("rebuff/r8: first id is buff 2", ((ushort)27, (ushort)2), list3[0]);
			num += smethod_244("rebuff/r8: second id is buff 4", ((ushort)27, (ushort)4), list3[1]);
			num += smethod_244("rebuff/r8: third id is buff 8", ((ushort)40, (ushort)1), list3[2]);
			num += smethod_244("rebuff/r8: fourth id is party buff 9", ((ushort)50, (ushort)9), list3[3]);
			num += smethod_244("rebuff/r8: fifth id is party buff 10", ((ushort)50, (ushort)10), list3[4]);
		}
		num += smethod_244("rebuff/r8: nothing checked asks nothing", 0, Class91.smethod_9(new bool[11], array2).Count);
		num += smethod_244("rebuff/r8: unknown ids ask nothing", 0, Class91.smethod_9(bool_, null).Count);
		num += smethod_244("rebuff/r8: skill_ready command", "{\"cmd\":\"skill_ready\",\"ids\":[[27,2],[27,4],[40,1],[50,9],[50,10]]}", Class454.smethod_6(list3));
		List<(ushort, ushort)> list4 = Class91.smethod_9(new bool[11]
		{
			false, false, false, false, false, false, false, false, false, true,
			true
		}, array2);
		num += smethod_244("rebuff/r8: party-only asks two ids", 2, list4.Count);
		num += smethod_244("rebuff/r8: party-only command", "{\"cmd\":\"skill_ready\",\"ids\":[[50,9],[50,10]]}", Class454.smethod_6(list4));
		num += smethod_244("rebuff/r8: older eight-slot mask remains valid", 0, Class91.smethod_9(new bool[9], array2).Count);
		num += smethod_244("rebuff/r8: skill_ready with no ids", "{\"cmd\":\"skill_ready\",\"ids\":[]}", Class454.smethod_6(new List<(ushort, ushort)>()));
		if (text3 != null)
		{
			num += smethod_243("rebuff/r8: embedded agent answers skill_ready", text3.Contains("case \"skill_ready\":"));
		}
		long num28 = Class358.smethod_0();
		long num29 = Class342.smethod_10();
		long num30 = Class358.smethod_0();
		num += smethod_243("rebuff/D11: Buff reads the session's clock", num28 <= num29 && num29 <= num30);
		num += smethod_243("rebuff/D12: SkillIdCode is internal", !typeof(Struct16).IsPublic);
		num += smethod_243("rebuff/D13: gate open when all hold", Class91.smethod_7(bool_0: true, bool_1: true, bool_2: true, bool_3: false));
		num += smethod_243("rebuff/D13: gate shut while stopped", !Class91.smethod_7(bool_0: false, bool_1: true, bool_2: true, bool_3: false));
		num += smethod_243("rebuff/D13: gate shut while soft-paused", !Class91.smethod_7(bool_0: true, bool_1: false, bool_2: true, bool_3: false));
		num += smethod_243("rebuff/D13: gate shut while the rebuff tier is unavailable", !Class91.smethod_7(bool_0: true, bool_1: true, bool_2: false, bool_3: false));
		num += smethod_243("rebuff/D13: gate shut after an unavailable reply", !Class91.smethod_7(bool_0: true, bool_1: true, bool_2: true, bool_3: true));
		num += smethod_243("rebuff/D13: a shut gate is never due", !Class91.smethod_8(Class91.smethod_7(bool_0: true, bool_1: false, bool_2: true, bool_3: false), array2, 1, -1L, 0L));
		for (int num31 = 1; num31 <= 8; num31++)
		{
			array3[num31] = false;
		}
		array3[2] = true;
		Class342.smethod_2();
		num += smethod_243("rebuff/D13: not off after reset", !Class342.smethod_7());
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_244("rebuff/D13: buff 2 sent", 2, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = "unavailable",
			int_1 = -1,
			int_2 = -1,
			string_1 = "test"
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_243("rebuff/D13: unavailable turns buffing off", Class342.smethod_7());
		Class342.smethod_2();
		num += smethod_243("rebuff/D13: reset turns buffing back on", !Class342.smethod_7());
		array3[2] = false;
		(ushort, ushort)[] valueTuple_ = new(ushort, ushort)[8]
		{
			(27, 1),
			(27, 2),
			(ushort.MaxValue, ushort.MaxValue),
			(27, 4),
			(27, 5),
			(27, 6),
			(27, 7),
			(27, 8)
		};
		bool[] array12 = new bool[9];
		string[] array13 = new string[9];
		for (int num32 = 0; num32 <= 8; num32++)
		{
			array13[num32] = string.Empty;
		}
		List<GStruct3> list5 = new List<GStruct3>();
		num += smethod_244("trace/rebuff_off line", "rebuff_off run=true cast=0", Class342.smethod_15("rebuff_off", bool_1: true, 0, string.Empty));
		Class342.smethod_2();
		Class342.smethod_24(0L, bool_1: true, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out var int_2);
		num += smethod_244("trace/dead", "dead", Class342.smethod_3());
		Class342.smethod_24(0L, bool_1: false, null, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244("trace/tab3_null", "tab3_null", Class342.smethod_3());
		num += smethod_244("trace/tab3_null line", "tab3_null run=true cast=0 age=0ms", Class342.smethod_4());
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), null, array12, array13, out int_2);
		num += smethod_244("trace/buffs_null", "buffs_null", Class342.smethod_3());
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244("trace/all_off", "all_off", Class342.smethod_3());
		num += smethod_243("trace/all_off slots", Class342.smethod_4().Contains("slots=1:slot_off 2:slot_off") && Class342.smethod_4().Contains("8:interval_off"));
		array12[1] = true;
		array13[1] = "10";
		Class342.smethod_24(0L, bool_1: false, valueTuple_, null, list5, array12, array13, out int_2);
		num += smethod_244("trace/ready_null", "ready_null", Class342.smethod_3());
		num += smethod_244("trace/ready_null no cast", 0, int_2);
		num += smethod_244("trace/ready_null line", "ready_null run=true cast=0 slot=1 id=27:1 left=absent thr=10s ready=none age=none slots=1:ready_null 2:slot_off 3:slot_off 4:slot_off 5:slot_off 6:slot_off 7:slot_off 8:interval_off", Class342.smethod_4());
		Class342.smethod_24(2000L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244("trace/ready_stale", "ready_stale", Class342.smethod_3());
		num += smethod_243("trace/ready_stale line", Class342.smethod_4().Contains(" ready=0 age=2000ms "));
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_228(0L, new Struct16[1] { smethod_229(99, 99, 0) }), list5, array12, array13, out int_2);
		num += smethod_244("trace/ready_missing", "ready_missing", Class342.smethod_3());
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_228(0L, new Struct16[1] { smethod_229(27, 1, 8) }), list5, array12, array13, out int_2);
		num += smethod_244("trace/ready_code", "ready_code", Class342.smethod_3());
		num += smethod_243("trace/ready_code line", Class342.smethod_4().Contains(" ready=8 age=0ms "));
		list5.Add(new GStruct3
		{
			bool_0 = false,
			ushort_0 = 27,
			ushort_1 = 1,
			float_0 = 50f
		});
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244("trace/not_due", "not_due", Class342.smethod_3());
		num += smethod_243("trace/not_due line", Class342.smethod_4().Contains("not_due run=true cast=0 slot=1 id=27:1 left=50.0s thr=10s ready=0 age=0ms"));
		num += smethod_243("trace/not_due is not written", !Class342.smethod_13("not_due"));
		num += smethod_243("trace/cast is written", Class342.smethod_13("cast"));
		array13[1] = string.Empty;
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244("trace/thr_empty", "thr_empty", Class342.smethod_3());
		array13[1] = "0";
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244("trace/typed 0 is not_due", "not_due", Class342.smethod_3());
		list5.Clear();
		array13[1] = "10";
		array12[1] = false;
		array12[3] = true;
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244("trace/slot_empty", "slot_empty", Class342.smethod_3());
		num += smethod_243("trace/slot_empty line", Class342.smethod_4().Contains("slot_empty run=true cast=0 slot=3 id=65535:65535 "));
		(ushort, ushort)[] valueTuple_2 = new(ushort, ushort)[2]
		{
			(27, 1),
			(27, 2)
		};
		Class342.smethod_24(0L, bool_1: false, valueTuple_2, smethod_227(valueTuple_2, 0L), list5, array12, array13, out int_2);
		num += smethod_244("trace/tab3_short", "tab3_short", Class342.smethod_3());
		array12[3] = false;
		array12[8] = true;
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244("trace/interval_secs_empty", "interval_secs_empty", Class342.smethod_3());
		array13[8] = "60";
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244("trace/cast interval", "cast", Class342.smethod_3());
		num += smethod_244("trace/cast interval slot", 8, int_2);
		num += smethod_244("trace/cast line", "cast run=false cast=8 slot=8 id=27:8 left=absent every=60s ready=0 age=0ms slots=1:slot_off 2:slot_off 3:slot_off 4:slot_off 5:slot_off 6:slot_off 7:slot_off 8:cast", Class342.smethod_4());
		Class342.smethod_24(100L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 100L), list5, array12, array13, out int_2);
		num += smethod_244("trace/casting", "casting", Class342.smethod_3());
		num += smethod_243("trace/casting line", Class342.smethod_4().Contains("casting run=false cast=0 slot=8 ") && Class342.smethod_4().Contains(" sent_ms=100"));
		Class342.smethod_0(new Class74
		{
			int_0 = 8,
			string_0 = "ok",
			int_1 = 0,
			int_2 = 1300,
			string_1 = string.Empty
		});
		Class342.smethod_24(1400L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 1400L), list5, array12, array13, out int_2);
		num += smethod_244("trace/cast_ok", "cast_ok", Class342.smethod_3());
		Class342.smethod_24(2000L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 2000L), list5, array12, array13, out int_2);
		num += smethod_244("trace/interval_not_due", "interval_not_due", Class342.smethod_3());
		num += smethod_243("trace/interval_not_due next", Class342.smethod_4().Contains(" every=60s ") && Class342.smethod_4().Contains(" next_ms=59400 "));
		array12[8] = false;
		Class342.smethod_2();
		array12[1] = true;
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244("trace/cast slot 1", 1, int_2);
		Class342.smethod_0(new Class74
		{
			int_0 = 1,
			string_0 = "ok",
			int_1 = 0,
			int_2 = 1300,
			string_1 = string.Empty
		});
		Class342.smethod_24(1400L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 1400L), list5, array12, array13, out int_2);
		num += smethod_244("trace/cast_landed", "cast_landed", Class342.smethod_3());
		Class342.smethod_24(1700L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 1700L), list5, array12, array13, out int_2);
		num += smethod_244("trace/confirming", "confirming", Class342.smethod_3());
		num += smethod_243("trace/confirming line", Class342.smethod_4().Contains("confirming run=true cast=0 slot=1 ") && Class342.smethod_4().Contains(" replied_ms=300"));
		list5.Add(new GStruct3
		{
			bool_0 = false,
			ushort_0 = 27,
			ushort_1 = 1,
			float_0 = 180f
		});
		Class342.smethod_24(2000L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 2000L), list5, array12, array13, out int_2);
		num += smethod_244("trace/confirmed", "confirmed", Class342.smethod_3());
		list5.Clear();
		Class342.smethod_24(2300L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 2300L), list5, array12, array13, out int_2);
		num += smethod_244("trace/cast again", 1, int_2);
		Class342.smethod_0(new Class74
		{
			int_0 = 1,
			string_0 = "ok",
			int_1 = 0,
			int_2 = 1300,
			string_1 = string.Empty
		});
		Class342.smethod_24(2600L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 2600L), list5, array12, array13, out int_2);
		Class342.smethod_24(7700L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 7700L), list5, array12, array13, out int_2);
		num += smethod_244("trace/confirm_timeout", "confirm_timeout", Class342.smethod_3());
		Class342.smethod_24(8000L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 8000L), list5, array12, array13, out int_2);
		num += smethod_244("trace/gap", "gap", Class342.smethod_3());
		num += smethod_243("trace/gap line", Class342.smethod_4().Contains("gap run=true cast=0 gap_ms=700 after=hold_fail slot=1 id=27:1 "));
		Class342.smethod_24(8700L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 8700L), list5, array12, array13, out int_2);
		num += smethod_244("trace/hold_fail", "hold_fail", Class342.smethod_3());
		num += smethod_243("trace/hold_fail line", Class342.smethod_4().Contains("hold_fail run=true cast=0 slot=1 id=27:1 ") && Class342.smethod_4().Contains(" hold_ms=4000 "));
		Class342.smethod_2();
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		Class342.smethod_0(new Class74
		{
			int_0 = 1,
			string_0 = "busy",
			int_1 = -1,
			int_2 = 200,
			string_1 = string.Empty
		});
		Class342.smethod_24(300L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 300L), list5, array12, array13, out int_2);
		num += smethod_244("trace/cast_busy", "cast_busy", Class342.smethod_3());
		Class342.smethod_24(400L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 400L), list5, array12, array13, out int_2);
		num += smethod_244("trace/gap after busy", "gap", Class342.smethod_3());
		num += smethod_243("trace/hold_busy line", Class342.smethod_4().Contains(" gap_ms=900 after=hold_busy slot=1 "));
		Class342.smethod_2();
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		Class342.smethod_24(7000L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 7000L), list5, array12, array13, out int_2);
		num += smethod_244("trace/cast_timeout", "cast_timeout", Class342.smethod_3());
		Class342.smethod_2();
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		Class342.smethod_0(new Class74
		{
			int_0 = 1,
			string_0 = "not_ready",
			int_1 = 8,
			int_2 = 200,
			string_1 = string.Empty
		});
		Class342.smethod_24(300L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 300L), list5, array12, array13, out int_2);
		num += smethod_244("trace/cast_refused", "cast_refused", Class342.smethod_3());
		num += smethod_243("trace/cast_refused line", Class342.smethod_4().Contains(" result=not_ready code=8"));
		Class342.smethod_2();
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		Class342.smethod_0(new Class74
		{
			int_0 = 1,
			string_0 = "unavailable",
			int_1 = -1,
			int_2 = -1,
			string_1 = string.Empty
		});
		Class342.smethod_24(300L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 300L), list5, array12, array13, out int_2);
		num += smethod_244("trace/cast_unavailable", "cast_unavailable", Class342.smethod_3());
		Class342.smethod_24(600L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 600L), list5, array12, array13, out int_2);
		num += smethod_244("trace/unavailable", "unavailable", Class342.smethod_3());
		Class342.smethod_2();
		array12[1] = false;
		num += smethod_243("sessionlog_buffcast_now_kept", GForm0.smethod_1("{\"t\":\"buff_cast\",\"slot\":3,\"result\":\"ok\",\"code\":0}") != null);
		num += smethod_243("sessionlog_buffcast_compact", GForm0.smethod_1("{  \"t\"  :  \"buff_cast\"  ,  \"slot\"  :  3  }").IndexOf('\n') < 0);
		num += smethod_243("sessionlog_reply_has_fields", GForm0.smethod_1("{\"t\":\"buff_cast\",\"slot\":1,\"result\":\"busy\",\"code\":7,\"settle_ms\":123}") != null);
		Console.WriteLine("rebuff: " + num + " failed");
		return num;
	}

	public static int smethod_152()
	{
		int num = 0;
		num = 0 + smethod_243("bag/apply bag rows", Class357.smethod_15(smethod_230(Class357.valueTuple_16), out var string_));
		num += smethod_243("bag/bag available", Class357.smethod_54());
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("bag/message carries tiInstanceContainer", text.Contains("\"tiInstanceContainer\":"));
		num += smethod_243("bag/message carries rvaBagGetItemObject", text.Contains("\"rvaBagGetItemObject\":"));
		num += smethod_244("bag/icInstance really is zero", 0, 0);
		num += smethod_243("bag/message carries icInstance 0", smethod_221(text, "icInstance", 0));
		num += smethod_243("bag/message carries icInventory", smethod_221(text, "icInventory", 40));
		num += smethod_243("bag/message carries icEquipment", smethod_221(text, "icEquipment", 48));
		num += smethod_243("bag/message carries ioContainer", smethod_221(text, "ioContainer", 40));
		num += smethod_243("bag/message carries invSlots", smethod_221(text, "invSlots", 16));
		num += smethod_243("bag/message carries slotItemPos", smethod_221(text, "slotItemPos", 24));
		num += smethod_243("bag/message carries slotIndex", smethod_221(text, "slotIndex", 104));
		num += smethod_243("bag/message carries itemMainId", smethod_221(text, "itemMainId", 16));
		num += smethod_243("bag/message carries itemSubId", smethod_221(text, "itemSubId", 20));
		num += smethod_243("bag/message carries itemObjWearPos", smethod_221(text, "itemObjWearPos", 57));
		num += smethod_243("bag/message carries itemObjMaxPile", smethod_221(text, "itemObjMaxPile", 282));
		num += smethod_243("bag/message carries phInvenLine", smethod_221(text, "phInvenLine", 382));
		num += smethod_243("bag/message carries slotItem", smethod_221(text, "slotItem", 112));
		num += smethod_243("bag/message carries slotAmount", smethod_221(text, "slotAmount", 120));
		num += smethod_243("bag/message carries klassStaticFields", smethod_221(text, "klassStaticFields", 184));
		num += smethod_243("bag/message carries itemObjName", smethod_221(text, "itemObjName", 32));
		num += smethod_243("bag/apply required rows only", Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out string_));
		string text2 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("bag/no group, no tiInstanceContainer", !text2.Contains("\"tiInstanceContainer\""));
		num += smethod_243("bag/no group, no icInventory", !text2.Contains("\"icInventory\""));
		num += smethod_243("bag/no group, no icInstance", !text2.Contains("\"icInstance\""));
		num += smethod_243("bag/no group, no phInvenLine", !text2.Contains("\"phInvenLine\""));
		num += smethod_243("bag/no group, bag unavailable", !Class357.smethod_54());
		num += smethod_243("bag/apply quickslot only", Class357.smethod_15(smethod_230(Class357.valueTuple_5), out string_));
		string text3 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("bag/quickslot alone carries slotItem", text3.Contains("\"slotItem\":"));
		num += smethod_243("bag/quickslot alone has no icInventory", !text3.Contains("\"icInventory\""));
		num += smethod_243("bag/quickslot alone has no klassStaticFields", !text3.Contains("\"klassStaticFields\""));
		num += smethod_243("bag/quickslot alone has no phInvenLine", !text3.Contains("\"phInvenLine\""));
		num += smethod_244("bag/command", "{\"cmd\":\"bag\"}", Class341.smethod_0());
		num += smethod_244("bag/twelve worn slots", 12, 12);
		num += smethod_244("bag/empty main id", ushort.MaxValue, ushort.MaxValue);
		num += smethod_244("bag/no bag sequence is zero", 0, 0);
		num += smethod_244("bag/no bag capacity is zero", 0, 0);
		num += smethod_244("bag/no backing array length is zero", 0, 0);
		num += smethod_244("bag/counter separator", " / ", " / ");
		num += smethod_244("bag/counter unknown mark", "?", "?");
		JObject jobject_ = JObject.Parse("{\"t\":\"bag\",\"ok\":true,\"seq\":7,\"bag\":[{\"i\":0,\"ord\":0,\"main\":11,\"sub\":1,\"amt\":1},{\"i\":3,\"ord\":3,\"main\":9,\"sub\":9,\"amt\":42},{\"i\":7,\"ord\":7,\"main\":61,\"sub\":1,\"amt\":2}],\"slots\":60,\"equip\":[{\"i\":0,\"pos\":1,\"main\":65535,\"sub\":65535,\"amt\":0},{\"i\":1,\"pos\":6,\"main\":29,\"sub\":3,\"amt\":1},{\"i\":2,\"pos\":6,\"main\":65535,\"sub\":65535,\"amt\":0},{\"i\":3,\"pos\":2,\"main\":38,\"sub\":1,\"amt\":0},{\"i\":4,\"pos\":3,\"main\":41,\"sub\":1,\"amt\":0},{\"i\":5,\"pos\":5,\"main\":44,\"sub\":1,\"amt\":0},{\"i\":6,\"pos\":4,\"main\":65535,\"sub\":65535,\"amt\":0},{\"i\":7,\"pos\":7,\"main\":59,\"sub\":1,\"amt\":1},{\"i\":8,\"pos\":8,\"main\":65535,\"sub\":65535,\"amt\":0},{\"i\":9,\"pos\":9,\"main\":61,\"sub\":2,\"amt\":1},{\"i\":10,\"pos\":9,\"main\":61,\"sub\":1,\"amt\":1},{\"i\":11,\"pos\":12,\"main\":65535,\"sub\":65535,\"amt\":0}],\"inames\":{\"11:1\":\"Recovery Potion\",\"29:3\":\"JianXi Bow\",\"38:1\":\"Preparatory Coat\",\"41:1\":\"Preparatory Skirt\",\"44:1\":\"Preparatory Boots\",\"59:1\":\"Wooden Necklace\",\"61:2\":\"Copper Ring\",\"61:1\":\"Copper Tin Ring\"}}");
		IReadOnlyList<Struct27> readOnlyList = Class119.smethod_40(jobject_);
		IReadOnlyList<Struct19> readOnlyList2 = Class119.smethod_43(jobject_);
		num += smethod_244("bag/three occupied slots", 3, readOnlyList.Count);
		if (readOnlyList.Count == 3)
		{
			num += smethod_244("bag/row 0 slot no", 0, readOnlyList[0].int_0);
			num += smethod_244("bag/row 1 slot no", 3, readOnlyList[1].int_0);
			num += smethod_244("bag/row 2 slot no", 7, readOnlyList[2].int_0);
			num += smethod_244("bag/row 0 backing ordinal", 0, readOnlyList[0].int_1);
			num += smethod_244("bag/row 1 backing ordinal", 3, readOnlyList[1].int_1);
			num += smethod_244("bag/row 2 backing ordinal", 7, readOnlyList[2].int_1);
			num += smethod_244("bag/row 0 main", (ushort)11, readOnlyList[0].ushort_0);
			num += smethod_244("bag/row 0 sub", (ushort)1, readOnlyList[0].ushort_1);
			num += smethod_244("bag/row 0 amount", 1, readOnlyList[0].int_2);
			num += smethod_244("bag/row 1 main", (ushort)9, readOnlyList[1].ushort_0);
			num += smethod_244("bag/row 1 sub", (ushort)9, readOnlyList[1].ushort_1);
			num += smethod_244("bag/row 1 amount", 42, readOnlyList[1].int_2);
			num += smethod_244("bag/row 2 main", (ushort)61, readOnlyList[2].ushort_0);
			num += smethod_244("bag/row 2 sub", (ushort)1, readOnlyList[2].ushort_1);
			num += smethod_244("bag/row 2 amount", 2, readOnlyList[2].int_2);
		}
		num += smethod_244("bag/backing array length", 60, Class119.smethod_42(jobject_));
		IReadOnlyList<Struct27> readOnlyList3 = Class119.smethod_40(JObject.Parse("{\"bag\":[{\"i\":7,\"ord\":3,\"main\":11,\"sub\":1,\"amt\":1}]}"));
		num += smethod_244("bag/divergent row decoded", 1, readOnlyList3.Count);
		if (readOnlyList3.Count == 1)
		{
			num += smethod_244("bag/divergent row keeps index", 7, readOnlyList3[0].int_0);
			num += smethod_244("bag/divergent row keeps ordinal", 3, readOnlyList3[0].int_1);
			num += smethod_243("bag/divergent row is flagged", Class16.smethod_1(readOnlyList3[0], 60).Contains("divergent=true"));
		}
		num += smethod_244("bag/missing ordinal row is dropped", 0, Class119.smethod_40(JObject.Parse("{\"bag\":[{\"i\":7,\"main\":11,\"sub\":1,\"amt\":1}]}")).Count);
		num += smethod_243("bag/worn array accepted", readOnlyList2 != null);
		if (readOnlyList2 != null)
		{
			num += smethod_244("bag/twelve worn cells", 12, readOnlyList2.Count);
			byte[] array = new byte[12]
			{
				1, 6, 6, 2, 3, 5, 4, 7, 8, 9,
				9, 12
			};
			ushort[] array2 = new ushort[12]
			{
				65535, 29, 65535, 38, 41, 44, 65535, 59, 65535, 61,
				61, 65535
			};
			ushort[] array3 = new ushort[12]
			{
				65535, 3, 65535, 1, 1, 1, 65535, 1, 65535, 2,
				1, 65535
			};
			int[] array4 = new int[12]
			{
				0, 1, 0, 0, 0, 0, 0, 1, 0, 1,
				1, 0
			};
			for (int i = 0; i < readOnlyList2.Count && i < array.Length; i++)
			{
				num += smethod_244("bag/worn " + i + " index", i, readOnlyList2[i].int_0);
				num += smethod_244("bag/worn " + i + " pos", array[i], readOnlyList2[i].byte_0);
				num += smethod_244("bag/worn " + i + " main", array2[i], readOnlyList2[i].ushort_0);
				num += smethod_244("bag/worn " + i + " sub", array3[i], readOnlyList2[i].ushort_1);
				num += smethod_244("bag/worn " + i + " amount", array4[i], readOnlyList2[i].int_1);
			}
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		smethod_222(jobject_, dictionary);
		num += smethod_244("bag/reply claimed eight names", 8, dictionary.Count);
		Class95 class95_ = new Class95(null, dictionary, null);
		Class145 @class = Class145.class145_0.method_98(readOnlyList, readOnlyList2, class95_, 7, Class119.smethod_41(jobject_), Class119.smethod_42(jobject_));
		num += smethod_244("bag/snapshot sequence", 7, @class.method_43());
		num += smethod_244("bag/ok reply has no error", string.Empty, @class.method_51());
		num += smethod_244("bag/capture carries no capacity", 0, @class.method_47());
		num += smethod_244("bag/snapshot carries backing array length", 60, @class.method_49());
		List<string[]> list = Class16.smethod_2(@class);
		num += smethod_244("bag/grid row count", 3, list.Count);
		if (list.Count == 3)
		{
			num += smethod_244("bag/grid 0 slot no", "0", list[0][0]);
			num += smethod_244("bag/grid 0 name", "Recovery Potion", list[0][1]);
			num += smethod_244("bag/grid 0 amount", "1", list[0][2]);
			num += smethod_244("bag/grid 1 slot no", "3", list[1][0]);
			num += smethod_244("bag/grid 1 unresolved name", "Item 9:9", list[1][1]);
			num += smethod_244("bag/grid 1 amount", "42", list[1][2]);
			num += smethod_244("bag/grid 2 slot no", "7", list[2][0]);
			num += smethod_244("bag/grid 2 name", "Copper Tin Ring", list[2][1]);
			num += smethod_244("bag/grid 2 amount", "2", list[2][2]);
		}
		num += smethod_244("bag/name null book", "Item 1:2", Class16.smethod_5(null, 1, 2));
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>(StringComparer.Ordinal);
		dictionary2["1:1"] = null;
		dictionary2["1:2"] = "   ";
		dictionary2["1:3"] = "  Padded Name  ";
		Class95 class95_2 = new Class95(null, dictionary2, null);
		num += smethod_244("bag/name null entry", "Item 1:1", Class16.smethod_5(class95_2, 1, 1));
		num += smethod_244("bag/name blank entry", "Item 1:2", Class16.smethod_5(class95_2, 1, 2));
		num += smethod_244("bag/name trimmed", "Padded Name", Class16.smethod_5(class95_2, 1, 3));
		string[] array5 = new string[12]
		{
			"Head", "Weapon", "Off-hand", "Upper", "Lower", "Foot", "Hand", "Necklace", "Bracelet", "Ring",
			"Ring 2", "Vehicle"
		};
		(string, string) tuple = Class16.smethod_4(@class, 0, array5[0]);
		num += smethod_244("bag/worn empty shows the placeholder", "Head", tuple.Item1);
		num += smethod_244("bag/worn empty has no qty", string.Empty, tuple.Item2);
		(string, string) tuple2 = Class16.smethod_4(@class, 1, array5[1]);
		num += smethod_244("bag/worn bow name", "JianXi Bow", tuple2.Item1);
		num += smethod_244("bag/worn bow qty", "1", tuple2.Item2);
		(string, string) tuple3 = Class16.smethod_4(@class, 3, array5[3]);
		num += smethod_244("bag/worn coat at amount 0 shows its name", "Preparatory Coat", tuple3.Item1);
		num += smethod_244("bag/worn coat prints no zero", string.Empty, tuple3.Item2);
		num += smethod_244("bag/worn skirt at amount 0 shows its name", "Preparatory Skirt", Class16.smethod_4(@class, 4, array5[4]).Item1);
		num += smethod_244("bag/worn boots at amount 0 shows its name", "Preparatory Boots", Class16.smethod_4(@class, 5, array5[5]).Item1);
		num += smethod_244("bag/worn hand is empty", "Hand", Class16.smethod_4(@class, 6, array5[6]).Item1);
		num += smethod_244("bag/worn necklace name", "Wooden Necklace", Class16.smethod_4(@class, 7, array5[7]).Item1);
		num += smethod_244("bag/worn bracelet is empty", "Bracelet", Class16.smethod_4(@class, 8, array5[8]).Item1);
		num += smethod_244("bag/worn ring name", "Copper Ring", Class16.smethod_4(@class, 9, array5[9]).Item1);
		num += smethod_244("bag/worn ring 2 name", "Copper Tin Ring", Class16.smethod_4(@class, 10, array5[10]).Item1);
		num += smethod_244("bag/worn vehicle is empty", "Vehicle", Class16.smethod_4(@class, 11, array5[11]).Item1);
		num += smethod_244("bag/worn past the end", "x", Class16.smethod_4(@class, 12, "x").Item1);
		num += smethod_244("bag/worn below zero", "x", Class16.smethod_4(@class, -1, "x").Item1);
		num += smethod_244("bag/worn no snapshot", "x", Class16.smethod_4(null, 0, "x").Item1);
		num += smethod_244("bag/worn null placeholder", string.Empty, Class16.smethod_4(@class, 0, null).Item1);
		Class145 class145_ = smethod_225(smethod_223("{\"i\":0,\"pos\":1,\"main\":65535,\"sub\":65535,\"amt\":1}"));
		num += smethod_244("bag/empty main with amount 1 is still empty", "Head", Class16.smethod_4(class145_, 0, "Head").Item1);
		Class145 class145_2 = smethod_225(smethod_223("{\"i\":0,\"pos\":1,\"main\":65535,\"sub\":3,\"amt\":0}"));
		num += smethod_244("bag/empty main with a real sub is still empty", "Head", Class16.smethod_4(class145_2, 0, "Head").Item1);
		Class145 class145_3 = smethod_225(smethod_223("{\"i\":0,\"pos\":1,\"main\":38,\"sub\":1,\"amt\":0}"));
		num += smethod_244("bag/real main at amount 0 is filled", "Item 38:1", Class16.smethod_4(class145_3, 0, "Head").Item1);
		JObject jobject_2 = JObject.Parse("{\"t\":\"bag\",\"ok\":false,\"error\":\"no inventory slots yet\"}");
		num += smethod_244("bag/fault keeps the agent sentence", "no inventory slots yet", Class119.smethod_39(jobject_2, Class119.smethod_43(jobject_2), bool_17: false));
		num += smethod_244("bag/fault without a reason", "the agent refused the bag without saying why", Class119.smethod_39(JObject.Parse("{\"t\":\"bag\",\"ok\":false}"), null, bool_17: false));
		num += smethod_244("bag/fault with a blank reason", "the agent refused the bag without saying why", Class119.smethod_39(JObject.Parse("{\"t\":\"bag\",\"ok\":false,\"error\":\"\"}"), null, bool_17: false));
		num += smethod_244("bag/fault with no ok field", "the agent refused the bag without saying why", Class119.smethod_39(JObject.Parse("{\"t\":\"bag\"}"), readOnlyList2, bool_17: true));
		num += smethod_244("bag/fault with a non-boolean ok", "the agent refused the bag without saying why", Class119.smethod_39(JObject.Parse("{\"t\":\"bag\",\"ok\":\"true\"}"), readOnlyList2, bool_17: true));
		num += smethod_244("bag/fault on a null envelope", "the agent refused the bag without saying why", Class119.smethod_39(null, null, bool_17: false));
		JObject jobject_3 = smethod_224(11);
		num += smethod_243("bag/eleven worn cells refused", Class119.smethod_43(jobject_3) == null);
		num += smethod_244("bag/eleven worn cells fault", "the reply did not carry twelve equipment slots", Class119.smethod_39(jobject_3, Class119.smethod_43(jobject_3), bool_17: true));
		JObject jobject_4 = smethod_224(13);
		num += smethod_243("bag/thirteen worn cells refused", Class119.smethod_43(jobject_4) == null);
		num += smethod_243("bag/no worn array refused", Class119.smethod_43(JObject.Parse("{\"t\":\"bag\",\"ok\":true,\"seq\":1}")) == null);
		num += smethod_243("bag/one unusable worn cell refuses the set", Class119.smethod_43(smethod_223("{\"i\":0,\"pos\":1,\"main\":70000,\"sub\":1,\"amt\":1}")) == null);
		num += smethod_243("bag/worn cell with a missing field refuses the set", Class119.smethod_43(smethod_223("{\"i\":0,\"pos\":1,\"sub\":1,\"amt\":1}")) == null);
		num += smethod_243("bag/worn cell that is not an object refuses the set", Class119.smethod_43(smethod_223("\"junk\"")) == null);
		num += smethod_243("bag/negative worn amount is accepted", Class119.smethod_43(smethod_223("{\"i\":0,\"pos\":1,\"main\":38,\"sub\":1,\"amt\":-1}")) != null);
		num += smethod_244("bag/ok reply with no sequence", "the reply carried no sequence number", Class119.smethod_39(jobject_, readOnlyList2, bool_17: false));
		num += smethod_244("bag/ok reply has no fault", string.Empty, Class119.smethod_39(jobject_, readOnlyList2, bool_17: true));
		Class145 class2 = @class.method_99("no inventory slots yet");
		num += smethod_244("bag/fault clears the rows", 0, class2.method_39().Count);
		num += smethod_244("bag/fault clears the worn cells", 0, class2.method_41().Count);
		num += smethod_244("bag/fault parks the sequence", 0, class2.method_43());
		num += smethod_244("bag/fault carries the sentence", "no inventory slots yet", class2.method_51());
		num += smethod_244("bag/fault with a null sentence", string.Empty, @class.method_99(null).method_51());
		List<string[]> list2 = Class16.smethod_2(class2);
		num += smethod_244("bag/fault is one grid row", 1, list2.Count);
		if (list2.Count == 1)
		{
			num += smethod_244("bag/fault row says why", "no inventory slots yet", list2[0][1]);
			num += smethod_244("bag/fault row has no slot no", string.Empty, list2[0][0]);
			num += smethod_244("bag/fault row has no amount", string.Empty, list2[0][2]);
		}
		num += smethod_244("bag/fault worn cell falls back", "Weapon", Class16.smethod_4(class2, 1, "Weapon").Item1);
		num += smethod_244("bag/no snapshot has no rows", 0, Class16.smethod_2(null).Count);
		num += smethod_244("bag/empty world has no rows", 0, Class16.smethod_2(Class145.class145_0).Count);
		Class145 class3 = class2.method_97(readOnlyList, readOnlyList2, class95_, 8, 42);
		num += smethod_244("bag/ok reply clears the sentence", string.Empty, class3.method_51());
		num += smethod_244("bag/ok reply sets the sequence", 8, class3.method_43());
		num += smethod_244("bag/ok reply restores the rows", 3, class3.method_39().Count);
		num += smethod_244("bag/ok reply restores the capacity", 42, class3.method_47());
		num += smethod_244("bag/capacity present", 30, Class119.smethod_41(smethod_226("30")));
		num += smethod_244("bag/capacity with no bought rows", 24, Class119.smethod_41(smethod_226("24")));
		num += smethod_244("bag/capacity with every bought row", 60, Class119.smethod_41(smethod_226("60")));
		num += smethod_244("bag/capacity absent", 0, Class119.smethod_41(jobject_));
		num += smethod_244("bag/capacity zero", 0, Class119.smethod_41(smethod_226("0")));
		num += smethod_244("bag/capacity negative", 0, Class119.smethod_41(smethod_226("-6")));
		num += smethod_244("bag/capacity as a string", 0, Class119.smethod_41(smethod_226("\"24\"")));
		num += smethod_244("bag/capacity null", 0, Class119.smethod_41(smethod_226("null")));
		num += smethod_244("bag/capacity fractional", 0, Class119.smethod_41(smethod_226("24.5")));
		num += smethod_244("bag/capacity on a null envelope", 0, Class119.smethod_41(null));
		num += smethod_244("bag/an unreadable capacity does not refuse the reply", string.Empty, Class119.smethod_39(smethod_226("0"), readOnlyList2, bool_17: true));
		Class145 class4 = Class145.class145_0.method_97(readOnlyList, readOnlyList2, class95_, 7, 30);
		num += smethod_244("bag/counter shows used over capacity", "3 / 30", Class16.smethod_3(class4));
		num += smethod_244("bag/counter at a full bag", "3 / 3", Class16.smethod_3(Class145.class145_0.method_97(readOnlyList, readOnlyList2, class95_, 7, 3)));
		num += smethod_244("bag/counter at the designer default", "0 / 24", Class16.smethod_3(Class145.class145_0.method_97(null, readOnlyList2, class95_, 7, 24)));
		num += smethod_244("bag/counter with no capacity", "3 / ?", Class16.smethod_3(@class));
		num += smethod_244("bag/counter with a zero capacity", "3 / ?", Class16.smethod_3(Class145.class145_0.method_97(readOnlyList, readOnlyList2, class95_, 7, 0)));
		num += smethod_244("bag/counter with a negative capacity", "3 / ?", Class16.smethod_3(Class145.class145_0.method_97(readOnlyList, readOnlyList2, class95_, 7, -6)));
		num += smethod_244("bag/counter on a fault", "0 / ?", Class16.smethod_3(class2));
		num += smethod_244("bag/counter on an empty world", "0 / ?", Class16.smethod_3(Class145.class145_0));
		num += smethod_244("bag/counter with no snapshot", "0 / ?", Class16.smethod_3(null));
		num += smethod_244("bag/fault parks the capacity", 0, class2.method_47());
		IReadOnlyList<Struct27> readOnlyList4 = Class119.smethod_40(JObject.Parse("{\"t\":\"bag\",\"ok\":true,\"seq\":1,\"bag\":[{\"i\":0,\"ord\":0,\"main\":11,\"sub\":1,\"amt\":0},{\"i\":1,\"ord\":1,\"main\":11,\"sub\":1,\"amt\":null},{\"i\":2,\"ord\":2,\"main\":70000,\"sub\":1,\"amt\":1},{\"i\":-1,\"ord\":0,\"main\":11,\"sub\":1,\"amt\":1},{\"ord\":0,\"main\":11,\"sub\":1,\"amt\":1},\"junk\",{\"i\":5,\"ord\":5,\"main\":11,\"sub\":1,\"amt\":3}]}"));
		num += smethod_244("bag/only the usable row survives", 1, readOnlyList4.Count);
		if (readOnlyList4.Count == 1)
		{
			num += smethod_244("bag/surviving row slot no", 5, readOnlyList4[0].int_0);
			num += smethod_244("bag/surviving row amount", 3, readOnlyList4[0].int_2);
		}
		num += smethod_244("bag/no bag array is no rows", 0, Class119.smethod_40(JObject.Parse("{\"t\":\"bag\",\"ok\":true,\"seq\":1}")).Count);
		num += smethod_244("bag/null envelope is no rows", 0, Class119.smethod_40(null).Count);
		JObject jobject_5 = JObject.Parse("{\"t\":\"bag\",\"ok\":true,\"seq\":8,\"inames\":{},\"bag\":[{\"i\":2,\"ord\":2,\"main\":29,\"sub\":3,\"amt\":1}]}");
		smethod_222(jobject_5, dictionary);
		num += smethod_244("bag/second reply claimed no new names", 8, dictionary.Count);
		List<string[]> list3 = Class16.smethod_2(Class145.class145_0.method_97(Class119.smethod_40(jobject_5), readOnlyList2, new Class95(null, dictionary, null), 8, Class119.smethod_41(jobject_5)));
		num += smethod_244("bag/nameless reply still has a row", 1, list3.Count);
		if (list3.Count == 1)
		{
			num += smethod_244("bag/nameless row resolves from the cache", "JianXi Bow", list3[0][1]);
		}
		Dictionary<string, string> dictionary3 = new Dictionary<string, string>(StringComparer.Ordinal);
		dictionary3["9:9"] = "Destiny Box";
		num += smethod_244("bag/a drop's name resolves a bag row", "Destiny Box", Class16.smethod_5(new Class95(null, dictionary3, null), 9, 9));
		num += smethod_244("bag/poll interval", 1000, 1000);
		num += smethod_243("bag/due on the first tick", Class16.smethod_0(-1L, 0L));
		num += smethod_243("bag/not due just before the boundary", !Class16.smethod_0(0L, 999L));
		num += smethod_243("bag/due at the boundary", Class16.smethod_0(0L, 1000L));
		num += smethod_243("bag/not due mid interval", !Class16.smethod_0(5000L, 5999L));
		num += smethod_243("bag/due at the next boundary", Class16.smethod_0(5000L, 6000L));
		Class145 class5 = @class.method_93(new Class83
		{
			float_0 = 1f,
			float_1 = 2f,
			float_2 = 3f
		}, 2, 0);
		num += smethod_244("bag/self publish keeps the rows", 3, class5.method_39().Count);
		num += smethod_244("bag/self publish keeps the worn cells", 12, class5.method_41().Count);
		num += smethod_244("bag/self publish keeps the sequence", 7, class5.method_43());
		num += smethod_244("bag/self publish keeps the capacity", 30, class4.method_93(new Class83
		{
			float_0 = 1f,
			float_1 = 2f,
			float_2 = 3f
		}, 2, 0).method_47());
		num += smethod_244("bag/self publish keeps the backing array length", 60, @class.method_93(new Class83
		{
			float_0 = 1f,
			float_1 = 2f,
			float_2 = 3f
		}, 2, 0).method_49());
		num += smethod_244("bag/self publish keeps the counter", "3 / 30", Class16.smethod_3(class4.method_93(null, 2, 0)));
		Class145 class6 = class2.method_95(null, null, null, default(GStruct4), 3, 0);
		num += smethod_244("bag/census publish keeps the fault", "no inventory slots yet", class6.method_51());
		num += smethod_244("bag/census publish keeps the parked sequence", 0, class6.method_43());
		num += smethod_244("bag/census publish keeps the parked capacity", 0, class6.method_47());
		num += smethod_244("bag/census publish keeps the capacity", 30, class4.method_95(null, null, null, default(GStruct4), 3, 0).method_47());
		num += smethod_244("bag/census publish keeps the backing array length", 60, @class.method_95(null, null, null, default(GStruct4), 3, 0).method_49());
		num += smethod_244("bag/empty world has no bag", 0, Class145.class145_0.method_39().Count);
		num += smethod_244("bag/empty world has no worn cells", 0, Class145.class145_0.method_41().Count);
		num += smethod_244("bag/empty world sequence", 0, Class145.class145_0.method_43());
		num += smethod_244("bag/empty world capacity", 0, Class145.class145_0.method_47());
		num += smethod_244("bag/empty world has no error", string.Empty, Class145.class145_0.method_51());
		string text4 = smethod_174(ref num);
		if (text4 != null)
		{
			num += smethod_243("bag/embedded agent answers the bag command", text4.Contains("case \"bag\":"));
			num += smethod_243("bag/embedded agent builds GetItemObject", text4.Contains("fnItemObject = new NativeFunction(moduleBase.add(o.rvaBagGetItemObject), \"pointer\", [\"pointer\", \"pointer\"]);"));
			num += smethod_243("bag/embedded agent sends the ok envelope", text4.Contains("send({ t: \"bag\", ok: true, seq: bagSeq, bag, equip, inames, cap, slots });"));
			num += smethod_243("bag/embedded agent reads the bought-rows byte", text4.Contains("handlerPtr.add(o.phInvenLine).readU8() + BAG_ROWS_FREE"));
			num += smethod_243("bag/embedded agent knows the free rows", text4.Contains("var BAG_ROWS_FREE = 4;"));
			num += smethod_243("bag/embedded agent knows the row ceiling", text4.Contains("var BAG_ROWS_MAX = 10;"));
			num += smethod_243("bag/embedded agent knows the row width", text4.Contains("var BAG_ROW_SLOTS = 6;"));
			num += smethod_243("bag/embedded agent caps the bought rows", text4.Contains("if (rows > BAG_ROWS_MAX)"));
			num += smethod_243("bag/embedded agent multiplies the rows out", text4.Contains("return rows * BAG_ROW_SLOTS;"));
			num += smethod_243("bag/embedded agent answers an unknown capacity", text4.Contains("return BAG_CAP_UNKNOWN;"));
			num += smethod_243("bag/embedded agent unknown capacity is zero", text4.Contains("var BAG_CAP_UNKNOWN = " + 0 + ";"));
			num += smethod_243("bag/embedded agent pre-increments the sequence", text4.Contains("bagSeq++;"));
			num += smethod_243("bag/embedded agent knows twelve worn slots", text4.Contains("var EQUIP_SLOTS = " + 12 + ";"));
			num += smethod_243("bag/embedded agent knows the empty marker", text4.Contains("var EMPTY_NATIVE_ID = " + ushort.MaxValue + ";"));
			num += smethod_243("bag/embedded agent drops an empty bag slot by amount", text4.Contains("if (amt <= 0)"));
			num += smethod_243("bag/embedded agent sends the backing ordinal", text4.Contains("rows.push({ i: slot.add(o.slotIndex).readS32(), ord: i, main, sub, amt });"));
			num += smethod_243("bag/embedded agent sends the backing array length", text4.Contains("const slots = inv.add(o.arrCount).readU32();"));
			num += smethod_243("bag/embedded agent keeps the amount on an empty worn cell", text4.Contains("cells.push({ i: idx, pos, main: EMPTY_NATIVE_ID, sub: EMPTY_NATIVE_ID, amt });"));
			num += smethod_243("bag/embedded agent reads ItemPosition[0] with no stride", text4.Contains("return arr.add(o.arrFirst).readU8();"));
			num += smethod_243("bag/embedded agent claims names into the shared cache", text4.Contains("knownItemNames[k] = true;"));
		}
		MethodInfo methodInfo = typeof(GForm0).GetMethod("method_114", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		FieldInfo field = typeof(Class357).GetField("<BagAvailable>k__BackingField", BindingFlags.Static | BindingFlags.NonPublic);
		num += smethod_243("bag/producer-test-seams", methodInfo != null && field != null);
		if (methodInfo != null && field != null)
		{
			bool flag = (bool)field.GetValue(null);
			try
			{
				field.SetValue(null, true);
				Class222 class7 = new Class222(new Class119());
				try
				{
					Class211 class8 = new Class211();
					class8.list_0 = new List<string>();
					class7.class119_0.method_30(class8.method_0);
					class7.method_0(Class145.class145_0, bool_0: true);
					((TabControl)class7.gform0_0.Controls.Find("tabControl1", searchAllChildren: true)[0]).SelectedIndex = 0;
					methodInfo.Invoke(class7.gform0_0, new object[1] { class7.gform0_0.method_5() });
					num += smethod_243("bag/producer-asks-on-unrelated-tab", class8.list_0.Count == 1 && class8.list_0[0].Contains("\"cmd\":\"bag\""));
					methodInfo.Invoke(class7.gform0_0, new object[1] { class7.gform0_0.method_5() });
					num += smethod_244("bag/producer-no-overlap", 1, class8.list_0.Count);
					smethod_94(class7.gform0_0, "_bagAskedMs", -10000L);
					methodInfo.Invoke(class7.gform0_0, new object[1] { class7.gform0_0.method_5() });
					num += smethod_244("bag/producer-retries-timeout", 2, class8.list_0.Count);
					class7.method_0(Class145.class145_0.method_97(new Struct27[0], new Struct19[0], Class95.class95_0, 1, 24), bool_0: true);
					smethod_94(class7.gform0_0, "_bagAskedMs", -10000L);
					methodInfo.Invoke(class7.gform0_0, new object[1] { class7.gform0_0.method_5() });
					num += smethod_244("bag/producer-accepts-reply", 3, class8.list_0.Count);
					class7.method_0(Class145.class145_0, bool_0: false);
					smethod_94(class7.gform0_0, "_bagAskedMs", -10000L);
					methodInfo.Invoke(class7.gform0_0, new object[1] { class7.gform0_0.method_5() });
					num += smethod_244("bag/producer-stops-when-not-ready", 3, class8.list_0.Count);
					class7.method_0(Class145.class145_0, bool_0: true);
				}
				finally
				{
					((IDisposable)class7).Dispose();
				}
			}
			finally
			{
				field.SetValue(null, flag);
			}
		}
		string text5 = smethod_173("Capybara-UI-Winform\\Ui\\SellRun.cs", ref num);
		if (text5 != null)
		{
			num += smethod_243("bag/manual-sell-consumes-producer", !text5.Contains("session.AskBag();"));
		}
		Console.WriteLine("bag: " + num + " failed");
		return num;
	}

	public static int smethod_153()
	{
		int num = 0;
		num = 0 + smethod_243("party-transport/apply party rows", Class357.smethod_15(smethod_230(Class357.valueTuple_23), out var string_));
		num += smethod_243("party-transport/party available", Class357.smethod_68());
		num += smethod_243("party-transport/attack stays unavailable", !Class357.smethod_34());
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("party-transport/message carries tiPartyManager", text.Contains("\"tiPartyManager\":"));
		num += smethod_243("party-transport/message carries rvaPartyMemberCount", text.Contains("\"rvaPartyMemberCount\":"));
		num += smethod_243("party-transport/message carries rvaPartyMemberPlayerId", text.Contains("\"rvaPartyMemberPlayerId\":"));
		num += smethod_243("party-transport/message carries rvaPlayerGetPlayer", text.Contains("\"rvaPlayerGetPlayer\":"));
		num += smethod_243("party-transport/message carries rvaSelectRemotePlayer", text.Contains("\"rvaSelectRemotePlayer\":"));
		num += smethod_243("party-transport/message carries rvaSelectSelf", text.Contains("\"rvaSelectSelf\":"));
		num += smethod_243("party-transport/message reuses the clicker anchor", text.Contains("\"rvaAtkAnchor\":"));
		num += smethod_244("party-transport/manager Instance really is zero", 0, 0);
		num += smethod_243("party-transport/message carries partyInstance 0", smethod_221(text, "partyInstance", 0));
		num += smethod_243("party-transport/message carries unitSelf", smethod_221(text, "unitSelf", 88));
		num += smethod_243("party-transport/message carries klassStaticFields", smethod_221(text, "klassStaticFields", 184));
		num += smethod_243("party-transport/apply attack rows", Class357.smethod_15(smethod_230(Class357.valueTuple_6), out string_));
		num += smethod_243("party-transport/attack available", Class357.smethod_34());
		num += smethod_243("party-transport/attack does not arm party", !Class357.smethod_68());
		string text2 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("party-transport/attack carries shared anchor", text2.Contains("\"rvaAtkAnchor\":"));
		num += smethod_243("party-transport/attack has no party manager", !text2.Contains("\"tiPartyManager\":"));
		num += smethod_243("party-transport/apply required rows only", Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out string_));
		string text3 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("party-transport/no group leaves party unavailable", !Class357.smethod_68());
		num += smethod_243("party-transport/no group has no party manager", !text3.Contains("\"tiPartyManager\":"));
		num += smethod_243("party-transport/no group has no selector", !text3.Contains("\"rvaSelectRemotePlayer\":"));
		Console.WriteLine("party-transport: " + num + " failed");
		return num;
	}

	public static int smethod_154()
	{
		int num = 0;
		num = 0 + smethod_243("friends/apply friend rows", Class357.smethod_15(smethod_230(Class357.valueTuple_22), out var string_));
		num += smethod_243("friends/friends available", Class357.smethod_66());
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("friends/message carries tiCharacterFriendManager", text.Contains("\"tiCharacterFriendManager\":"));
		num += smethod_243("friends/message carries rvaGetFriends", text.Contains("\"rvaGetFriends\":"));
		num += smethod_243("friends/message carries klassStaticFields", smethod_221(text, "klassStaticFields", 184));
		num += smethod_244("friends/manager Instance really is zero", 0, 0);
		num += smethod_244("friends/CharId really is zero", 0, 0);
		num += smethod_243("friends/message carries sfFriendMgrInstance 0", smethod_221(text, "sfFriendMgrInstance", 0));
		num += smethod_243("friends/message carries fceId 0", smethod_221(text, "fceId", 0));
		num += smethod_243("friends/message carries fmFriends", smethod_221(text, "fmFriends", 152));
		num += smethod_243("friends/message carries fmListLoaded", smethod_221(text, "fmListLoaded", 176));
		num += smethod_243("friends/message carries fceName", smethod_221(text, "fceName", 8));
		num += smethod_243("friends/message carries fceFlag", smethod_221(text, "fceFlag", 16));
		num += smethod_243("friends/message carries fceOnline", smethod_221(text, "fceOnline", 17));
		num += smethod_243("friends/message carries fceKnown", smethod_221(text, "fceKnown", 24));
		num += smethod_243("friends/message carries fceChannel", smethod_221(text, "fceChannel", 18));
		num += smethod_243("friends/message carries fceLevel", smethod_221(text, "fceLevel", 20));
		num += smethod_243("friends/message carries fceClass", smethod_221(text, "fceClass", 22));
		num += smethod_243("friends/message carries fceSchool", smethod_221(text, "fceSchool", 23));
		num += smethod_243("friends/message carries fceStride", smethod_221(text, "fceStride", 32));
		num += smethod_243("friends/message carries listItems", smethod_221(text, "listItems", 16));
		num += smethod_243("friends/message carries listSize", smethod_221(text, "listSize", 24));
		num += smethod_243("friends/stride is positive", bool_0: true);
		num += smethod_243("friends/stride is 8-aligned", bool_0: true);
		num += smethod_243("friends/name fits the stride", bool_0: true);
		num += smethod_243("friends/id fits the stride", bool_0: true);
		num += smethod_243("friends/level fits the stride", bool_0: true);
		num += smethod_243("friends/known fits the stride", bool_0: true);
		num += smethod_243("friends/name is pointer-aligned", bool_0: true);
		num += smethod_243("friends/online and known are different bytes", bool_0: true);
		num += smethod_243("friends/apply required rows only", Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out string_));
		string text2 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("friends/no group, no tiCharacterFriendManager", !text2.Contains("\"tiCharacterFriendManager\""));
		num += smethod_243("friends/no group, no rvaGetFriends", !text2.Contains("\"rvaGetFriends\""));
		num += smethod_243("friends/no group, friends unavailable", !Class357.smethod_66());
		num += smethod_243("friends/apply bag only", Class357.smethod_15(smethod_230(Class357.valueTuple_16), out string_));
		string text3 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("friends/bag alone carries klassStaticFields", text3.Contains("\"klassStaticFields\":"));
		num += smethod_243("friends/bag alone has no rvaGetFriends", !text3.Contains("\"rvaGetFriends\""));
		num += smethod_243("friends/bag alone leaves friends unavailable", !Class357.smethod_66());
		num += smethod_243("friends/apply friends only", Class357.smethod_15(smethod_230(Class357.valueTuple_22), out string_));
		string text4 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("friends/friends alone carries klassStaticFields", text4.Contains("\"klassStaticFields\":"));
		num += smethod_243("friends/friends alone has no tiInstanceContainer", !text4.Contains("\"tiInstanceContainer\""));
		num += smethod_243("friends/friends alone leaves bag unavailable", !Class357.smethod_54());
		num += smethod_243("sell/apply required rows", Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out string_));
		string text5 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("sell/no group, sell unavailable", !Class357.smethod_40());
		num += smethod_243("sell/no group, no sale request", !text5.Contains("\"rvaNpcSaleRequest\""));
		num += smethod_243("sell/apply sale row", Class357.smethod_15(smethod_230(Class357.valueTuple_9), out string_));
		string text6 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("sell/sell available", Class357.smethod_40());
		num += smethod_243("sell/message carries sale request", text6.Contains("\"rvaNpcSaleRequest\":"));
		num += smethod_243("sell/sell alone leaves friends unavailable", !Class357.smethod_66());
		num += smethod_244("sell/one sale row", 1, Class357.valueTuple_9.Length);
		num += smethod_244("sell/store row", "Addr_Function_ServerConnectionManager_SendNpcSaleRequest", Class357.valueTuple_9[0].Item1);
		num += smethod_244("sell/agent key", "rvaNpcSaleRequest", Class357.valueTuple_9[0].Item2);
		num += smethod_244("friends/command", "{\"cmd\":\"friends\"}", Class347.smethod_0());
		num += smethod_244("friends/block flag", (sbyte)(-1), (sbyte)(-1));
		num += smethod_244("friends/no friends sequence is zero", 0, 0);
		num += smethod_244("friends/no state is blank", string.Empty, string.Empty);
		num += smethod_243("friends/refresh gap is positive", bool_0: true);
		num += smethod_243("friends/ready is a state", Class347.smethod_1("ready"));
		num += smethod_243("friends/empty is a state", Class347.smethod_1("empty"));
		num += smethod_243("friends/refreshing is a state", Class347.smethod_1("refreshing"));
		num += smethod_243("friends/unknown word is not a state", !Class347.smethod_1("loading"));
		num += smethod_243("friends/null is not a state", !Class347.smethod_1(null));
		num += smethod_243("friends/refreshing is pending", Class347.smethod_2("refreshing"));
		num += smethod_243("friends/ready is not pending", !Class347.smethod_2("ready"));
		num += smethod_243("friends/empty is not pending", !Class347.smethod_2("empty"));
		JObject jobject_ = JObject.Parse("{\"t\":\"friends\",\"ok\":true,\"seq\":4,\"state\":\"ready\",\"loaded\":true,\"asked\":false,\"friends\":[{\"name\":\"Sena\",\"id\":1001,\"flag\":1,\"online\":true,\"known\":true,\"ch\":0,\"lv\":120,\"cls\":2,\"sch\":1},{\"name\":\"Rook\",\"id\":1002,\"flag\":-1,\"online\":false,\"known\":true,\"ch\":0,\"lv\":85,\"cls\":1,\"sch\":0},{\"name\":\"Mira\",\"id\":1003,\"flag\":1,\"online\":false,\"known\":true,\"ch\":2,\"lv\":140,\"cls\":8,\"sch\":2},{\"name\":\"Tam\",\"id\":1004,\"flag\":0,\"online\":false,\"known\":false,\"ch\":0,\"lv\":0,\"cls\":0,\"sch\":0},{\"name\":\" Bo Bo \",\"id\":1005,\"flag\":2,\"online\":true,\"known\":true,\"ch\":1,\"lv\":99,\"cls\":4,\"sch\":1}]}");
		string text7 = Class119.smethod_50(jobject_);
		num += smethod_244("friends/state is ready", "ready", text7);
		num += smethod_244("friends/ready is not a fault", string.Empty, Class119.smethod_51(jobject_, text7, bool_17: true));
		int int_;
		IReadOnlyList<Struct140> readOnlyList = Class119.smethod_52(jobject_, out int_);
		num += smethod_244("friends/five names", 5, readOnlyList.Count);
		num += smethod_244("friends/nothing dropped", 0, int_);
		if (readOnlyList.Count == 5)
		{
			num += smethod_244("friends/row 0 name", "Sena", readOnlyList[0].string_0);
			num += smethod_244("friends/row 0 id", 1001, readOnlyList[0].int_0);
			num += smethod_244("friends/row 0 level", (ushort)120, readOnlyList[0].ushort_0);
			num += smethod_244("friends/row 0 class code", (byte)2, readOnlyList[0].byte_1);
			num += smethod_244("friends/row 0 school code", (byte)1, readOnlyList[0].byte_2);
			num += smethod_244("friends/blocked name kept", "Rook", readOnlyList[1].string_0);
			num += smethod_244("friends/blocked flag kept", (sbyte)(-1), readOnlyList[1].sbyte_0);
			num += smethod_244("friends/offline name kept", "Mira", readOnlyList[2].string_0);
			num += smethod_243("friends/offline is offline", !readOnlyList[2].bool_0);
			num += smethod_243("friends/offline details are known", readOnlyList[2].bool_1);
			num += smethod_244("friends/unknown name kept", "Tam", readOnlyList[3].string_0);
			num += smethod_243("friends/unknown details not known", !readOnlyList[3].bool_1);
			num += smethod_243("friends/unknown online byte is false", !readOnlyList[3].bool_0);
			num += smethod_244("friends/name kept verbatim", " Bo Bo ", readOnlyList[4].string_0);
			num += smethod_244("friends/row 4 channel", (byte)1, readOnlyList[4].byte_0);
		}
		Class145 @class = Class145.class145_0.method_109(readOnlyList, text7, 4, int_);
		num += smethod_244("friends/snapshot count", 5, @class.method_73().Count);
		num += smethod_244("friends/snapshot state", "ready", @class.method_75());
		num += smethod_244("friends/snapshot seq", 4, @class.method_77());
		num += smethod_244("friends/snapshot error blank", string.Empty, @class.method_81());
		Class145 class2 = @class.method_93(null, 9, 0);
		num += smethod_244("friends/survives a self frame", 5, class2.method_73().Count);
		num += smethod_244("friends/state survives a self frame", "ready", class2.method_75());
		JObject jobject_2 = JObject.Parse("{\"t\":\"friends\",\"ok\":true,\"seq\":1,\"state\":\"empty\",\"loaded\":true,\"asked\":false,\"friends\":[]}");
		JObject jobject_3 = JObject.Parse("{\"t\":\"friends\",\"ok\":true,\"seq\":1,\"state\":\"refreshing\",\"loaded\":false,\"asked\":true,\"friends\":[]}");
		string text8 = Class119.smethod_50(jobject_2);
		string text9 = Class119.smethod_50(jobject_3);
		num += smethod_244("friends/empty state", "empty", text8);
		num += smethod_244("friends/refreshing state", "refreshing", text9);
		num += smethod_244("friends/empty is not a fault", string.Empty, Class119.smethod_51(jobject_2, text8, bool_17: true));
		num += smethod_244("friends/refreshing is not a fault", string.Empty, Class119.smethod_51(jobject_3, text9, bool_17: true));
		num += smethod_244("friends/empty carries no names", 0, Class119.smethod_52(jobject_2, out var int_2).Count);
		num += smethod_244("friends/refreshing carries no names", 0, Class119.smethod_52(jobject_3, out var int_3).Count);
		num += smethod_244("friends/empty dropped nothing", 0, int_2);
		num += smethod_244("friends/refreshing dropped nothing", 0, int_3);
		num += smethod_243("friends/empty draws", !Class347.smethod_2(text8));
		num += smethod_243("friends/refreshing waits", Class347.smethod_2(text9));
		JObject jobject_4 = JObject.Parse("{\"t\":\"friends\",\"ok\":false,\"error\":\"friend offsets not loaded\"}");
		num += smethod_244("friends/refusal keeps the agent sentence", "friend offsets not loaded", Class119.smethod_51(jobject_4, Class119.smethod_50(jobject_4), bool_17: false));
		JObject jobject_5 = JObject.Parse("{\"t\":\"friends\",\"ok\":false}");
		num += smethod_244("friends/silent refusal gets a sentence", "the agent refused the friend list without saying why", Class119.smethod_51(jobject_5, null, bool_17: false));
		JObject jobject_6 = JObject.Parse("{\"t\":\"friends\",\"ok\":true,\"seq\":2,\"friends\":[]}");
		num += smethod_244("friends/no state is refused", "the reply did not say whether the friend list is ready", Class119.smethod_51(jobject_6, Class119.smethod_50(jobject_6), bool_17: true));
		JObject jobject_7 = JObject.Parse("{\"t\":\"friends\",\"ok\":true,\"seq\":2,\"state\":\"loading\",\"friends\":[]}");
		num += smethod_243("friends/unknown state reads as none", Class119.smethod_50(jobject_7) == null);
		num += smethod_244("friends/unknown state is refused", "the reply did not say whether the friend list is ready", Class119.smethod_51(jobject_7, Class119.smethod_50(jobject_7), bool_17: true));
		JObject jobject_8 = JObject.Parse("{\"t\":\"friends\",\"ok\":true,\"state\":\"empty\",\"friends\":[]}");
		num += smethod_244("friends/no seq is refused", "the reply carried no sequence number", Class119.smethod_51(jobject_8, Class119.smethod_50(jobject_8), bool_17: false));
		num += smethod_244("friends/no reply at all", "the agent refused the friend list without saying why", Class119.smethod_51(null, null, bool_17: true));
		Class145 class3 = Class145.class145_0.method_109(new Struct140[1], "ready", 3, 0).method_110("friend offsets not loaded");
		num += smethod_244("friends/fault empties the list", 0, class3.method_73().Count);
		num += smethod_244("friends/fault parks the sequence", 0, class3.method_77());
		num += smethod_244("friends/fault clears the state", string.Empty, class3.method_75());
		num += smethod_244("friends/fault keeps the sentence", "friend offsets not loaded", class3.method_81());
		JObject jobject_9 = JObject.Parse("{\"t\":\"friends\",\"ok\":true,\"seq\":6,\"state\":\"ready\",\"friends\":[{\"name\":\"Good\",\"id\":1,\"flag\":1,\"online\":true,\"known\":true,\"ch\":0,\"lv\":10,\"cls\":1,\"sch\":0},{\"id\":2,\"flag\":1,\"online\":true,\"known\":true,\"ch\":0,\"lv\":10,\"cls\":1,\"sch\":0},{\"name\":\"   \",\"id\":3,\"flag\":1,\"online\":true,\"known\":true,\"ch\":0,\"lv\":10,\"cls\":1,\"sch\":0},{\"name\":\"NoOnline\",\"id\":4,\"flag\":1,\"known\":true,\"ch\":0,\"lv\":10,\"cls\":1,\"sch\":0},{\"name\":\"NullKnown\",\"id\":5,\"flag\":1,\"online\":true,\"known\":null,\"ch\":0,\"lv\":10,\"cls\":1,\"sch\":0},{\"name\":\"BadLevel\",\"id\":6,\"flag\":1,\"online\":true,\"known\":true,\"ch\":0,\"lv\":99999,\"cls\":1,\"sch\":0},{\"name\":\"Also\",\"id\":7,\"flag\":1,\"online\":false,\"known\":false,\"ch\":0,\"lv\":11,\"cls\":1,\"sch\":0}]}");
		int int_4;
		IReadOnlyList<Struct140> readOnlyList2 = Class119.smethod_52(jobject_9, out int_4);
		num += smethod_244("friends/readable rows survive", 2, readOnlyList2.Count);
		num += smethod_244("friends/unreadable rows counted", 5, int_4);
		if (readOnlyList2.Count == 2)
		{
			num += smethod_244("friends/first survivor", "Good", readOnlyList2[0].string_0);
			num += smethod_244("friends/last survivor", "Also", readOnlyList2[1].string_0);
		}
		num += smethod_244("friends/torn reply still publishes", string.Empty, Class119.smethod_51(jobject_9, Class119.smethod_50(jobject_9), bool_17: true));
		Class145 class4 = Class145.class145_0.method_109(readOnlyList2, "ready", 6, int_4);
		num += smethod_244("friends/snapshot carries the drop count", 5, class4.method_79());
		string text10 = smethod_174(ref num);
		if (text10 != null)
		{
			num += smethod_243("friends/embedded agent answers the friends command", text10.Contains("case \"friends\":"));
			num += smethod_243("friends/embedded agent builds GetFriends", text10.Contains("fnGetFriends = new NativeFunction(moduleBase.add(o.rvaGetFriends), \"void\", [\"pointer\", \"pointer\"]);"));
			num += smethod_243("friends/embedded agent reads the loaded flag", text10.Contains("const loaded = mgr.add(o.fmListLoaded).readU8() !== 0;"));
			num += smethod_243("friends/embedded agent refreshes only when not loaded", text10.Contains("if (!loaded) {") && text10.Contains("fnGetFriends(mgr, NULL);"));
			num += smethod_243("friends/embedded agent honours the refresh gap", text10.Contains("if (friendsAskedAtMs === 0 || now - friendsAskedAtMs >= FRIEND_REFRESH_GAP_MS)"));
			num += smethod_243("friends/embedded agent knows the gap", text10.Contains("var FRIEND_REFRESH_GAP_MS = 3e3;"));
			num += smethod_244("friends/gap matches the agent", 3000, 3000);
			num += smethod_243("friends/embedded agent reads the backing array", text10.Contains("const items = list.add(o.listItems).readPointer();"));
			num += smethod_243("friends/embedded agent bounds the walk by _size", text10.Contains("let n = list.add(o.listSize).readS32();"));
			num += smethod_243("friends/embedded agent does not bound the walk by arrCount", !text10.Contains("list.add(o.arrCount)"));
			num += smethod_243("friends/embedded agent strides from the first element", text10.Contains("items.add(o.arrFirst + i * o.fceStride)"));
			num += smethod_243("friends/embedded agent caps a bad count", text10.Contains("if (n > FRIEND_MAX)"));
			num += smethod_243("friends/embedded agent reads the flag signed", text10.Contains("flag: e.add(o.fceFlag).readS8()"));
			num += smethod_243("friends/embedded agent reads online", text10.Contains("online: e.add(o.fceOnline).readU8() !== 0"));
			num += smethod_243("friends/embedded agent reads known", text10.Contains("known: e.add(o.fceKnown).readU8() !== 0"));
			int num2 = text10.IndexOf("let state = \"refreshing\";", StringComparison.Ordinal);
			int num3 = text10.IndexOf("state = friends.length > 0 ? \"ready\" : \"empty\";", StringComparison.Ordinal);
			num += smethod_243("friends/embedded agent defaults to refreshing", num2 >= 0);
			num += smethod_243("friends/embedded agent splits ready from empty", num3 >= 0);
			num += smethod_243("friends/readiness is decided before the count", num2 >= 0 && num3 > num2);
			num += smethod_243("friends/embedded agent gates the split on loaded", text10.Contains("if (loaded)"));
			num += smethod_243("friends/embedded agent sends the ok envelope", text10.Contains("send({ t: \"friends\", ok: true, seq: friendsSeq, state, loaded, asked, friends });"));
			num += smethod_243("friends/embedded agent refuses missing offsets", text10.Contains("send({ t: \"friends\", ok: false, error: \"friend offsets not loaded\" });"));
			num += smethod_243("friends/embedded agent refuses a missing manager", text10.Contains("error: \"no friend manager yet; enter the world first\""));
			num += smethod_243("friends/embedded agent refuses a full frame queue", text10.Contains("send({ t: \"friends\", ok: false, error: \"frame queue unavailable\" });"));
			num += smethod_243("friends/embedded agent catches a torn read", text10.Contains("send({ t: \"friends\", ok: false, error: \"\" + e });"));
			num += smethod_243("friends/agent states are all known", Class347.smethod_1("ready") && Class347.smethod_1("empty") && Class347.smethod_1("refreshing"));
			string text11 = smethod_220(text10);
			num += smethod_243("friends/agent zero-ok list found", text11.Length != 0);
			num += smethod_243("friends/agent zero-ok names the manager instance", text11.Contains("\"sfFriendMgrInstance\""));
			num += smethod_243("friends/agent zero-ok names CharId", text11.Contains("\"fceId\""));
			num += smethod_243("friends/agent zero-ok does not name the stride", !text11.Contains("\"fceStride\""));
			num += smethod_243("friends/agent zero-ok does not name the list fields", !text11.Contains("\"fmFriends\"") && !text11.Contains("\"listSize\""));
		}
		num += smethod_218();
		Console.WriteLine("friends: " + num + " failed");
		return num;
	}

	public static int smethod_155()
	{
		Class261 @class = new Class261();
		try
		{
			return smethod_156();
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
	}

	private static int smethod_156()
	{
		return smethod_157();
	}

	private static int smethod_157()
	{
		Class291 @class = new Class291();
		int num = 0;
		Class409.Struct125[] ireadOnlyList_ = new Class409.Struct125[2]
		{
			new Class409.Struct125
			{
				int_0 = 9,
				int_1 = 2,
				ushort_0 = 11,
				ushort_1 = 1
			},
			new Class409.Struct125
			{
				int_0 = 1,
				int_1 = 1,
				ushort_0 = 12,
				ushort_1 = 3
			}
		};
		num = 0 + smethod_244("sale/request-json", "{\"cmd\":\"sell\",\"npc\":77,\"items\":[{\"slot\":9,\"ord\":2,\"main\":11,\"sub\":1},{\"slot\":1,\"ord\":1,\"main\":12,\"sub\":3}]}", Class409.smethod_0(77, ireadOnlyList_));
		Class119 class2 = new Class119();
		@class.string_0 = null;
		class2.method_30(@class.method_0);
		class2.method_169(0, 9, 2, 11, 1);
		num += smethod_244("sale/ask-one-zero-npc", "{\"cmd\":\"sell\",\"npc\":0,\"items\":[{\"slot\":9,\"ord\":2,\"main\":11,\"sub\":1}]}", @class.string_0);
		JObject jobject_ = JObject.Parse("{\"t\":\"sell\",\"ok\":true,\"seq\":4,\"state\":\"complete\",\"outcomes\":[{\"slot\":9,\"ord\":2,\"main\":11,\"sub\":1,\"matched\":true,\"attempted\":true,\"gone\":true,\"outcome\":\"sold\"},{\"slot\":1,\"ord\":1,\"main\":12,\"sub\":3,\"matched\":true,\"attempted\":true,\"gone\":false,\"outcome\":\"nochange\"}]}");
		IReadOnlyList<Class78> readOnlyList = Class119.smethod_45(jobject_, Class119.smethod_44(jobject_), ireadOnlyList_);
		num += smethod_243("sale/reply-decodes-identity", readOnlyList != null && readOnlyList.Count == 2 && readOnlyList[0].int_0 == 9 && readOnlyList[0].int_1 == 2 && readOnlyList[0].string_0 == "sold");
		Dictionary<string, string> dictionary_ = new Dictionary<string, string>(StringComparer.Ordinal) { { "11:1", "Apple" } };
		Dictionary<string, string> dictionary_2 = new Dictionary<string, string>(StringComparer.Ordinal) { { "100:1", "Item Shop Keeper" } };
		List<Struct27> list_ = new List<Struct27>
		{
			new Struct27
			{
				int_0 = 8,
				int_1 = 1,
				ushort_0 = 11,
				ushort_1 = 1,
				int_2 = 1
			},
			new Struct27
			{
				int_0 = 3,
				int_1 = 2,
				ushort_0 = 11,
				ushort_1 = 1,
				int_2 = 1
			}
		};
		Class222 class3 = new Class222(new Class119());
		try
		{
			class3.method_0(smethod_161(list_, new List<Class403> { smethod_131(1, 100, 1, 77u, 2f, 0f) }, dictionary_, dictionary_2, new Class83
			{
				float_0 = 0f,
				float_1 = 0f,
				float_2 = 0f
			}, 7, 24), bool_0: true);
			List<Struct96> list = Class385.smethod_5(class3.gform0_0, new List<string> { "Apple" });
			num += smethod_244("sale/step-candidates-count", 2, list.Count);
			num += smethod_243("sale/step-candidates-descending-slot", list.Count == 2 && list[0].int_0 == 8 && list[1].int_0 == 3);
			num += smethod_244("sale/step-candidates-filter", 0, Class385.smethod_5(class3.gform0_0, new List<string> { "Pear" }).Count);
		}
		finally
		{
			((IDisposable)class3).Dispose();
		}
		Console.WriteLine("sale: " + num + " failed");
		return num;
	}

	private static int smethod_158()
	{
		int num = 0;
		num = 0 + smethod_244("recall/request-json", "{\"cmd\":\"recall\",\"ord\":7,\"main\":232,\"sub\":18}", Class387.smethod_0(7, 232, 18));
		num += smethod_244("recall/friend-request-json", "{\"cmd\":\"friend_warp\",\"name\":\"Bob\",\"ord\":8,\"main\":232,\"sub\":20}", Class30.smethod_0("Bob", 8, 232, 20));
		Console.WriteLine("recall: " + num + " failed");
		return num;
	}

	private static Class409.Struct125[] smethod_159(Class119 class119_0)
	{
		FieldInfo field = typeof(Class119).GetField("_sellExpected", BindingFlags.Instance | BindingFlags.NonPublic);
		if (!(field == null))
		{
			return field.GetValue(class119_0) as Class409.Struct125[];
		}
		return null;
	}

	private static int smethod_160(string string_0, string string_1)
	{
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1))
		{
			int num = 0;
			int startIndex = 0;
			while ((startIndex = string_0.IndexOf(string_1, startIndex, StringComparison.Ordinal)) >= 0)
			{
				num++;
				startIndex += string_1.Length;
			}
			return num;
		}
		return 0;
	}

	private static Class145 smethod_161(List<Struct27> list_0, List<Class403> list_1, Dictionary<string, string> dictionary_0, Dictionary<string, string> dictionary_1, Class83 class83_0, int int_0, int int_1)
	{
		Class95 class95_ = new Class95(dictionary_1, dictionary_0, null);
		return Class145.class145_0.method_95(list_1, class95_, null, default(GStruct4), 1, 0).method_98(list_0, null, class95_, int_0, int_1, 60).method_93(class83_0, 1, 0);
	}

	private static void smethod_162(Class145 class145_0, string string_0)
	{
		FieldInfo field = typeof(Class145).GetField("<BagError>k__BackingField", BindingFlags.Instance | BindingFlags.NonPublic);
		if (field != null)
		{
			field.SetValue(class145_0, string_0);
		}
	}

	private static string smethod_163(string string_0)
	{
		if (string_0 == null)
		{
			return string.Empty;
		}
		int num = string_0.IndexOf("function sellBatch(", StringComparison.Ordinal);
		if (num < 0)
		{
			return string.Empty;
		}
		int num2 = string_0.IndexOf("function friendsRead(", num, StringComparison.Ordinal);
		if (num2 < 0)
		{
			return string.Empty;
		}
		return string_0.Substring(num, num2 - num);
	}

	private static bool smethod_164(List<Struct96> list_0, int int_0)
	{
		if (list_0 == null)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				if (list_0[num].int_0 == int_0)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool smethod_165()
	{
		Class251 @class = new Class251();
		@class.class119_0 = new Class119
		{
			synchronizationContext_0 = new Class302()
		};
		FieldInfo field = typeof(Class119).GetField("_agent", BindingFlags.Instance | BindingFlags.NonPublic);
		FieldInfo field2 = typeof(Class119).GetField("_readyRequest", BindingFlags.Instance | BindingFlags.NonPublic);
		PropertyInfo property = typeof(Class119).GetProperty("TestPostSink", BindingFlags.Instance | BindingFlags.NonPublic);
		@class.methodInfo_0 = typeof(Class119).GetMethod("method_204", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		EventInfo eventInfo = typeof(Class119).GetEvent("OnDetached", BindingFlags.Instance | BindingFlags.Public);
		if (!(field == null) && !(field2 == null) && !(property == null) && !(@class.methodInfo_0 == null) && !(eventInfo == null))
		{
			Class331 class2 = new Class331(8);
			@class.bool_0 = false;
			@class.int_0 = int.MinValue;
			Action<int> handler = @class.method_0;
			try
			{
				field.SetValue(@class.class119_0, new IntPtr(1));
				field2.SetValue(@class.class119_0, 1);
				property.SetValue(@class.class119_0, new Action<string>(class2.method_0), null);
				eventInfo.AddEventHandler(@class.class119_0, handler);
				Task task = Task.Run((Action)@class.method_1);
				Task task2 = Task.Run((Action)@class.method_2);
				if (!Task.WhenAll(task, task2).Wait(2000))
				{
					return false;
				}
				if (@class.class119_0.method_28() && class2.method_1(Class54.smethod_0("t1", @class.class119_0.int_14)) == 1 && class2.method_1(Class54.smethod_0("t2", @class.class119_0.int_15)) == 1)
				{
					class2.method_2();
					Task task3 = Task.Run((Action)@class.method_3);
					Task task4 = Task.Run((Func<object>)@class.method_4);
					if (!Task.WhenAll(task3, task4).Wait(2000))
					{
						return false;
					}
					return ((!@class.class119_0.method_28() && !@class.class119_0.method_10()) & @class.bool_0) && @class.int_0 == 73 && class2.method_1(Class54.smethod_1("t1")) == 1 && class2.method_1(Class54.smethod_1("t2")) == 1;
				}
				return false;
			}
			catch
			{
				return false;
			}
			finally
			{
				eventInfo.RemoveEventHandler(@class.class119_0, handler);
			}
		}
		return false;
	}

	private static bool smethod_166()
	{
		GForm0 obj = (GForm0)FormatterServices.GetUninitializedObject(typeof(GForm0));
		Class119 @class = new Class119();
		FieldInfo field = typeof(GForm0).GetField("_session", BindingFlags.Instance | BindingFlags.NonPublic);
		PropertyInfo property = typeof(GForm0).GetProperty("Snap", BindingFlags.Instance | BindingFlags.NonPublic);
		FieldInfo field2 = typeof(Class119).GetField("_world", BindingFlags.Instance | BindingFlags.NonPublic);
		if (!(field == null) && !(property == null) && !(field2 == null))
		{
			try
			{
				field.SetValue(obj, @class);
				field2.SetValue(@class, Class145.class145_0);
				object value = property.GetValue(obj, null);
				field2.SetValue(@class, Class145.class145_0.method_93(new Class83
				{
					float_0 = 1f
				}, 1, 0));
				object value2 = property.GetValue(obj, null);
				return value != value2 && ((Class145)value2).method_0() != null;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}

	private static bool smethod_167()
	{
		Class303 @class = new Class303();
		@class.gform0_0 = new GForm0();
		@class.class119_0 = new Class119();
		@class.class119_1 = new Class119();
		@class.methodInfo_0 = typeof(GForm0).GetMethod("method_8", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		FieldInfo field = typeof(Class119).GetField("_world", BindingFlags.Instance | BindingFlags.NonPublic);
		FieldInfo field2 = typeof(Class119).GetField("_readyRequest", BindingFlags.Instance | BindingFlags.NonPublic);
		if (!(@class.methodInfo_0 == null) && !(field == null) && !(field2 == null))
		{
			Class145 class2 = Class145.class145_0.method_93(new Class83
			{
				float_0 = 11f,
				float_2 = 12f
			}, 1, 0);
			Class145 class3 = Class145.class145_0.method_93(new Class83
			{
				float_0 = 21f,
				float_2 = 22f
			}, 2, 0);
			field.SetValue(@class.class119_0, class2);
			field.SetValue(@class.class119_1, class3);
			field2.SetValue(@class.class119_0, 1);
			field2.SetValue(@class.class119_1, 0);
			int location = 0;
			@class.int_0 = 0;
			int location2 = 0;
			int location3 = 0;
			int location4 = 0;
			Task task = Task.Run((Action)@class.method_0);
			do
			{
				try
				{
					Class145 class4 = @class.gform0_0.method_5();
					Class119 class5 = @class.gform0_0.method_7();
					bool num = @class.gform0_0.method_6();
					if (class4 != Class145.class145_0 && class4 != class2 && class4 != class3)
					{
						Interlocked.Increment(ref location);
					}
					if (class5 != null && class5 != @class.class119_0 && class5 != @class.class119_1)
					{
						Interlocked.Increment(ref location);
					}
					if (num)
					{
						Interlocked.Increment(ref location3);
					}
					else
					{
						Interlocked.Increment(ref location4);
					}
					Interlocked.Increment(ref location2);
				}
				catch
				{
					Interlocked.Increment(ref @class.int_0);
				}
			}
			while (!task.IsCompleted);
			task.GetAwaiter().GetResult();
			@class.methodInfo_0.Invoke(@class.gform0_0, new object[1]);
			@class.class119_0.Dispose();
			@class.class119_1.Dispose();
			@class.gform0_0.Dispose();
			if (location2 > 0 && location3 > 0 && location4 > 0 && location == 0)
			{
				return @class.int_0 == 0;
			}
			return false;
		}
		return false;
	}

	private static Class278 smethod_168(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0) && File.Exists(string_0))
		{
			try
			{
				string text = File.ReadAllText(string_0);
				return string.IsNullOrWhiteSpace(text) ? new Class278(null, "empty") : new Class278(text, null);
			}
			catch (Exception ex)
			{
				return new Class278(null, ex.GetType().Name);
			}
		}
		return new Class278(null, "missing");
	}

	private static Class278 smethod_169(Stream stream_0)
	{
		if (stream_0 == null)
		{
			return new Class278(null, "missing");
		}
		try
		{
			StreamReader streamReader = new StreamReader(stream_0, Encoding.UTF8, detectEncodingFromByteOrderMarks: true, 1024, leaveOpen: true);
			try
			{
				string text = streamReader.ReadToEnd();
				return string.IsNullOrWhiteSpace(text) ? new Class278(null, "empty") : new Class278(text, null);
			}
			finally
			{
				((IDisposable)streamReader).Dispose();
			}
		}
		catch (Exception ex)
		{
			return new Class278(null, "unreadable:" + ex.GetType().Name);
		}
	}

	private static Class278 smethod_170()
	{
		try
		{
			using Stream stream_ = Assembly.GetExecutingAssembly().GetManifestResourceStream("runtime.js");
			return smethod_169(stream_);
		}
		catch (Exception ex)
		{
			return new Class278(null, "unreadable:" + ex.GetType().Name);
		}
	}

	private static string smethod_171(string string_0)
	{
		return smethod_172(Environment.CurrentDirectory, string_0) ?? smethod_172(AppDomain.CurrentDomain.BaseDirectory, string_0);
	}

	private static string smethod_172(string string_0, string string_1)
	{
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1))
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			string text;
			while (true)
			{
				if (directoryInfo != null)
				{
					text = Path.Combine(directoryInfo.FullName, string_1);
					if (File.Exists(text))
					{
						break;
					}
					directoryInfo = directoryInfo.Parent;
					continue;
				}
				return null;
			}
			return text;
		}
		return null;
	}

	private static string smethod_173(string string_0, ref int int_0)
	{
		Class278 @class = smethod_168(smethod_171(string_0));
		if (@class.string_0 == null)
		{
			Console.WriteLine("source/" + string_0 + "/read: " + @class.string_1);
			int_0 += smethod_243("source/" + string_0 + "/available", bool_0: false);
			return null;
		}
		return @class.string_0;
	}

	private static string smethod_174(ref int int_0)
	{
		Class278 @class = smethod_170();
		if (@class.string_0 == null)
		{
			Console.WriteLine("source/runtime.js/read: " + @class.string_1);
			int_0 += smethod_243("source/runtime.js/available", bool_0: false);
			return null;
		}
		return @class.string_0;
	}

	private static Dictionary<string, string> smethod_175(Class282[] class282_1, ref int int_0)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		foreach (Class282 @class in class282_1)
		{
			if (!dictionary2.TryGetValue(@class.string_0, out var value))
			{
				value = smethod_173(@class.string_0, ref int_0);
				dictionary2[@class.string_0] = value;
			}
			string value2 = smethod_206(value, @class, ref int_0);
			if (dictionary.ContainsKey(@class.string_3))
			{
				int_0 += smethod_243("automatic/inventory/duplicate-key/" + @class.string_3, bool_0: false);
			}
			else
			{
				dictionary.Add(@class.string_3, value2);
			}
		}
		return dictionary;
	}

	private static int smethod_176(Class282[] class282_1, bool bool_0)
	{
		int int_ = 0;
		Assembly assembly = typeof(Class198).Assembly;
		Dictionary<Type, MethodBase> dictionary = new Dictionary<Type, MethodBase>();
		Type[] types = assembly.GetTypes();
		for (int i = 0; i < types.Length; i++)
		{
			MethodInfo[] methods = types[i].GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			for (int j = 0; j < methods.Length; j++)
			{
				AsyncStateMachineAttribute asyncStateMachineAttribute = (AsyncStateMachineAttribute)Attribute.GetCustomAttribute(methods[j], typeof(AsyncStateMachineAttribute));
				if (asyncStateMachineAttribute != null)
				{
					dictionary[asyncStateMachineAttribute.StateMachineType] = methods[j];
				}
			}
		}
		HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
		Dictionary<Class282, string> dictionary2 = new Dictionary<Class282, string>();
		for (int k = 0; k < class282_1.Length; k++)
		{
			MethodBase methodBase = smethod_178(class282_1[k], types, bool_0, ref int_);
			if (!(methodBase == null))
			{
				string text = smethod_190(methodBase);
				dictionary2.Add(class282_1[k], text);
				if (!hashSet.Add(text))
				{
					int_ += smethod_177("automatic/inventory/duplicate-signature/" + text, bool_0);
				}
			}
		}
		Queue<MethodBase> queue = new Queue<MethodBase>();
		smethod_192(queue, typeof(Class58), "Master_Manager", 1);
		smethod_192(queue, typeof(GForm0), "Prepare_Start", 1);
		smethod_192(queue, typeof(GForm0), "Start_Button", 1);
		smethod_192(queue, typeof(GForm0), "Stop_Button", 1);
		smethod_192(queue, typeof(GForm0), "RequestStop", 1);
		smethod_192(queue, typeof(GForm0), "StopCoreAsync", 0);
		smethod_192(queue, typeof(GForm0), "ObserveAutomaticRunAsync", 2);
		smethod_192(queue, typeof(GForm0), "button1_Click", 2);
		smethod_192(queue, typeof(GForm0), "button2_Click", 2);
		smethod_192(queue, typeof(GForm0), "Form1_FormClosing", 2);
		smethod_192(queue, typeof(GForm0), "Session_Detached", 1);
		smethod_192(queue, typeof(GForm0), "Sell_Run_Click", 2);
		smethod_192(queue, typeof(GForm0), "SellPump_Tick", 2);
		smethod_192(queue, typeof(GForm0), "RunManualSellPassAsync", 0);
		smethod_192(queue, typeof(Class179), "BackToStartAsync", 4);
		smethod_192(queue, typeof(Class179), "BackToRecentAsync", 4);
		smethod_192(queue, typeof(Class179), "WarpToFriendAsync", 5);
		HashSet<MethodBase> hashSet2 = new HashSet<MethodBase>();
		HashSet<string> hashSet3 = new HashSet<string>(StringComparer.Ordinal);
		while (queue.Count != 0)
		{
			MethodBase methodBase2 = smethod_193(queue.Dequeue(), dictionary);
			if (methodBase2 == null || !hashSet2.Add(methodBase2))
			{
				continue;
			}
			MethodBase methodBase3 = smethod_193(methodBase2, dictionary);
			bool flag = smethod_197(methodBase3);
			if (methodBase3 != null && smethod_195(methodBase3) && !smethod_196(methodBase3) && !flag)
			{
				string text2 = smethod_190(methodBase3);
				hashSet3.Add(text2);
				if (!hashSet.Contains(text2))
				{
					int_ += smethod_177("automatic/reachable/unlisted/" + text2, bool_0);
				}
			}
			if (flag)
			{
				continue;
			}
			foreach (MethodBase item in smethod_203(smethod_194(methodBase2, dictionary)))
			{
				MethodBase methodBase4 = smethod_193(item, dictionary);
				if (methodBase4 != null && methodBase4.DeclaringType != null && methodBase4.DeclaringType.Assembly == assembly)
				{
					queue.Enqueue(item);
				}
			}
		}
		for (int l = 0; l < class282_1.Length; l++)
		{
			if (dictionary2.TryGetValue(class282_1[l], out var value) && !hashSet3.Contains(value))
			{
				int_ += smethod_177("automatic/inventory/unreachable/" + class282_1[l].string_3, bool_0);
			}
		}
		return int_;
	}

	private static int smethod_177(string string_0, bool bool_0)
	{
		if (!bool_0)
		{
			return 1;
		}
		return smethod_243(string_0, bool_0: false);
	}

	private static MethodBase smethod_178(Class282 class282_1, Type[] type_0, bool bool_0, ref int int_0)
	{
		List<Type> list = new List<Type>();
		for (int i = 0; i < type_0.Length; i++)
		{
			if (type_0[i].Name == class282_1.string_1)
			{
				list.Add(type_0[i]);
			}
		}
		if (list.Count != 1)
		{
			int_0 += smethod_177("automatic/inventory/type-resolution/" + class282_1.string_3, bool_0);
			return null;
		}
		if (!smethod_179(class282_1.string_2, out var string_, out var int_1))
		{
			int_0 += smethod_177("automatic/inventory/declaration-signature/" + class282_1.string_3, bool_0);
			return null;
		}
		MethodInfo[] methods = list[0].GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		List<MethodBase> list2 = new List<MethodBase>();
		for (int j = 0; j < methods.Length; j++)
		{
			if (methods[j].Name == string_ && smethod_188(methods[j]) == int_1 && smethod_180(class282_1.string_2, methods[j]))
			{
				list2.Add(methods[j]);
			}
		}
		if (list2.Count == 1)
		{
			return list2[0];
		}
		int_0 += smethod_177("automatic/inventory/method-resolution/" + class282_1.string_3, bool_0);
		return null;
	}

	private static bool smethod_179(string string_0, out string string_1, out int int_0)
	{
		string_1 = null;
		int_0 = 0;
		int num = string_0.IndexOf('(');
		if (num < 0)
		{
			return false;
		}
		string text = string_0.Substring(0, num).Trim();
		int num2 = text.LastIndexOf(' ');
		string text2 = ((num2 < 0) ? text : text.Substring(num2 + 1));
		string_1 = text2;
		int num3 = string_1.IndexOf('<');
		if (num3 < 0)
		{
			return string_1.Length != 0;
		}
		int num4 = string_1.LastIndexOf('>');
		if (num4 <= num3)
		{
			return false;
		}
		string string_2 = string_1.Substring(num3 + 1, num4 - num3 - 1);
		int_0 = smethod_187(string_2, ',').Count;
		string_1 = string_1.Substring(0, num3);
		if (string_1.Length != 0)
		{
			return int_0 != 0;
		}
		return false;
	}

	private static bool smethod_180(string string_0, MethodBase methodBase_0)
	{
		int num = string_0.IndexOf('(');
		int num2 = smethod_186(string_0, num, '(', ')');
		if (num >= 0 && num2 >= 0)
		{
			string text = string_0.Substring(num + 1, num2 - num - 1);
			List<string> list = (string.IsNullOrWhiteSpace(text) ? new List<string>() : smethod_187(text, ','));
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			if (list.Count != parameters.Length)
			{
				return false;
			}
			int num3 = 0;
			while (true)
			{
				if (num3 < parameters.Length)
				{
					if (!string.Equals(smethod_181(list[num3]), smethod_189(parameters[num3].ParameterType), StringComparison.Ordinal))
					{
						break;
					}
					num3++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	private static string smethod_181(string string_0)
	{
		string text = smethod_182(string_0).Trim();
		bool flag = false;
		string[] array = new string[5] { "this", "params", "out", "ref", "in" };
		bool flag2;
		do
		{
			flag2 = false;
			for (int i = 0; i < array.Length; i++)
			{
				string text2 = array[i] + " ";
				if (text.StartsWith(text2, StringComparison.Ordinal))
				{
					if (array[i] == "out" || array[i] == "ref" || array[i] == "in")
					{
						flag = true;
					}
					text = text.Substring(text2.Length).TrimStart();
					flag2 = true;
					break;
				}
			}
		}
		while (flag2);
		text = smethod_183(text);
		string text3 = smethod_184(text);
		if (!flag)
		{
			return text3;
		}
		return text3 + "&";
	}

	private static string smethod_182(string string_0)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < string_0.Length; i++)
		{
			switch (string_0[i])
			{
			case '<':
				num++;
				break;
			case '>':
				num--;
				break;
			case '(':
				num2++;
				break;
			case ')':
				num2--;
				break;
			case '[':
				num3++;
				break;
			case ']':
				num3--;
				break;
			case '=':
				if (num == 0 && num2 == 0 && num3 == 0)
				{
					return string_0.Substring(0, i);
				}
				break;
			}
		}
		return string_0;
	}

	private static string smethod_183(string string_0)
	{
		int num = string_0.Length - 1;
		while (num >= 0 && char.IsWhiteSpace(string_0[num]))
		{
			num--;
		}
		int num2 = num;
		while (num2 >= 0 && (char.IsLetterOrDigit(string_0[num2]) || string_0[num2] == '_'))
		{
			num2--;
		}
		if (num2 >= 0 && char.IsWhiteSpace(string_0[num2]))
		{
			return string_0.Substring(0, num2).TrimEnd();
		}
		return string_0.Trim();
	}

	private static string smethod_184(string string_0)
	{
		string_0 = string_0.Trim().Replace("global::", string.Empty);
		string text = string.Empty;
		while (string_0.EndsWith("[]", StringComparison.Ordinal))
		{
			text += "[]";
			string_0 = string_0.Substring(0, string_0.Length - 2).TrimEnd();
		}
		if (string_0.StartsWith("(", StringComparison.Ordinal) && smethod_186(string_0, 0, '(', ')') == string_0.Length - 1)
		{
			List<string> list = smethod_187(string_0.Substring(1, string_0.Length - 2), ',');
			for (int i = 0; i < list.Count; i++)
			{
				list[i] = smethod_184(smethod_183(list[i]));
			}
			return "(" + string.Join(",", list) + ")" + text;
		}
		int num = smethod_185(string_0, '<');
		if (num >= 0)
		{
			int num2 = smethod_186(string_0, num, '<', '>');
			if (num2 == string_0.Length - 1)
			{
				string text2 = string_0.Substring(0, num).Trim();
				List<string> list2 = smethod_187(string_0.Substring(num + 1, num2 - num - 1), ',');
				for (int j = 0; j < list2.Count; j++)
				{
					list2[j] = smethod_184(list2[j]);
				}
				return text2 + "<" + string.Join(",", list2) + ">" + text;
			}
		}
		return Regex.Replace(string_0, "\\s+", string.Empty) + text;
	}

	private static int smethod_185(string string_0, char char_0)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		while (true)
		{
			if (num4 < string_0.Length)
			{
				char c = string_0[num4];
				if (c == char_0 && num == 0 && num2 == 0 && num3 == 0)
				{
					break;
				}
				switch (c)
				{
				case '<':
					num++;
					break;
				case '>':
					num--;
					break;
				case '(':
					num2++;
					break;
				case ')':
					num2--;
					break;
				case '[':
					num3++;
					break;
				case ']':
					num3--;
					break;
				}
				num4++;
				continue;
			}
			return -1;
		}
		return num4;
	}

	private static int smethod_186(string string_0, int int_0, char char_0, char char_1)
	{
		if (int_0 >= 0 && int_0 < string_0.Length && string_0[int_0] == char_0)
		{
			int num = 0;
			int num2 = int_0;
			while (true)
			{
				if (num2 < string_0.Length)
				{
					if (string_0[num2] == char_0)
					{
						num++;
					}
					else if (string_0[num2] == char_1 && --num == 0)
					{
						break;
					}
					num2++;
					continue;
				}
				return -1;
			}
			return num2;
		}
		return -1;
	}

	private static List<string> smethod_187(string string_0, char char_0)
	{
		List<string> list = new List<string>();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		for (int i = 0; i < string_0.Length; i++)
		{
			char c = string_0[i];
			switch (c)
			{
			case '<':
				num++;
				continue;
			case '>':
				num--;
				continue;
			case '(':
				num2++;
				continue;
			case ')':
				num2--;
				continue;
			case '[':
				num3++;
				continue;
			case ']':
				num3--;
				continue;
			}
			if (c == char_0 && num == 0 && num2 == 0 && num3 == 0)
			{
				list.Add(string_0.Substring(num4, i - num4).Trim());
				num4 = i + 1;
			}
		}
		list.Add(string_0.Substring(num4).Trim());
		return list;
	}

	private static int smethod_188(MethodBase methodBase_0)
	{
		MethodInfo methodInfo = methodBase_0 as MethodInfo;
		if (methodInfo != null && methodInfo.IsGenericMethod)
		{
			return methodInfo.GetGenericArguments().Length;
		}
		return 0;
	}

	private static string smethod_189(Type type_0)
	{
		if (type_0.IsByRef)
		{
			return smethod_189(type_0.GetElementType()) + "&";
		}
		if (type_0.IsArray)
		{
			return smethod_189(type_0.GetElementType()) + "[" + new string(',', type_0.GetArrayRank() - 1) + "]";
		}
		if (type_0.IsGenericParameter)
		{
			return type_0.Name;
		}
		if (type_0 == typeof(void))
		{
			return "void";
		}
		if (type_0 == typeof(bool))
		{
			return "bool";
		}
		if (type_0 == typeof(byte))
		{
			return "byte";
		}
		if (type_0 == typeof(short))
		{
			return "short";
		}
		if (type_0 == typeof(ushort))
		{
			return "ushort";
		}
		if (type_0 == typeof(int))
		{
			return "int";
		}
		if (type_0 == typeof(uint))
		{
			return "uint";
		}
		if (type_0 == typeof(long))
		{
			return "long";
		}
		if (type_0 == typeof(ulong))
		{
			return "ulong";
		}
		if (type_0 == typeof(float))
		{
			return "float";
		}
		if (type_0 == typeof(double))
		{
			return "double";
		}
		if (type_0 == typeof(char))
		{
			return "char";
		}
		if (type_0 == typeof(string))
		{
			return "string";
		}
		if (type_0 == typeof(object))
		{
			return "object";
		}
		if (type_0.IsGenericType)
		{
			Type genericTypeDefinition = type_0.GetGenericTypeDefinition();
			Type[] genericArguments = type_0.GetGenericArguments();
			string[] array = new string[genericArguments.Length];
			for (int i = 0; i < genericArguments.Length; i++)
			{
				array[i] = smethod_189(genericArguments[i]);
			}
			if (genericTypeDefinition.FullName != null && genericTypeDefinition.FullName.StartsWith("System.ValueTuple`", StringComparison.Ordinal))
			{
				return "(" + string.Join(",", array) + ")";
			}
			string text = genericTypeDefinition.Name;
			int num = text.IndexOf('`');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			return text + "<" + string.Join(",", array) + ">";
		}
		return type_0.Name;
	}

	private static string smethod_190(MethodBase methodBase_0)
	{
		string text = smethod_191(methodBase_0.DeclaringType);
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		string[] array = new string[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			array[i] = smethod_191(parameters[i].ParameterType);
		}
		return text + "::" + methodBase_0.Name + "`" + smethod_188(methodBase_0) + "(" + string.Join(",", array) + ")";
	}

	private static string smethod_191(Type type_0)
	{
		if (type_0 == null)
		{
			return "<null>";
		}
		if (type_0.IsByRef)
		{
			return smethod_191(type_0.GetElementType()) + "&";
		}
		if (type_0.IsPointer)
		{
			return smethod_191(type_0.GetElementType()) + "*";
		}
		if (type_0.IsArray)
		{
			return smethod_191(type_0.GetElementType()) + "[" + new string(',', type_0.GetArrayRank() - 1) + "]";
		}
		if (type_0.IsGenericParameter)
		{
			return ((type_0.DeclaringMethod == null) ? "!" : "!!") + type_0.GenericParameterPosition;
		}
		if (type_0.IsGenericType)
		{
			Type genericTypeDefinition = type_0.GetGenericTypeDefinition();
			string text = genericTypeDefinition.FullName ?? genericTypeDefinition.Name;
			int num = text.IndexOf('`');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			Type[] genericArguments = type_0.GetGenericArguments();
			string[] array = new string[genericArguments.Length];
			for (int i = 0; i < genericArguments.Length; i++)
			{
				array[i] = smethod_191(genericArguments[i]);
			}
			return text.Replace('+', '.') + "<" + string.Join(",", array) + ">";
		}
		return (type_0.FullName ?? type_0.Name).Replace('+', '.');
	}

	private static void smethod_192(Queue<MethodBase> queue_0, Type type_0, string string_0, int int_0)
	{
		MethodInfo[] methods = type_0.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		int num = 0;
		while (true)
		{
			if (num < methods.Length)
			{
				if (methods[num].Name == string_0 && methods[num].GetParameters().Length == int_0)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		queue_0.Enqueue(methods[num]);
	}

	private static MethodBase smethod_193(MethodBase methodBase_0, Dictionary<Type, MethodBase> dictionary_0)
	{
		if (methodBase_0 == null)
		{
			return null;
		}
		MethodBase value;
		MethodBase methodBase = ((!(methodBase_0.Name == "MoveNext") || !(methodBase_0.DeclaringType != null) || !dictionary_0.TryGetValue(methodBase_0.DeclaringType, out value)) ? methodBase_0 : value);
		MethodInfo methodInfo = methodBase as MethodInfo;
		if (methodInfo != null && methodInfo.IsGenericMethod && !methodInfo.IsGenericMethodDefinition)
		{
			return methodInfo.GetGenericMethodDefinition();
		}
		return methodBase;
	}

	private static MethodBase smethod_194(MethodBase methodBase_0, Dictionary<Type, MethodBase> dictionary_0)
	{
		MethodInfo methodInfo = methodBase_0 as MethodInfo;
		if (methodInfo == null)
		{
			return methodBase_0;
		}
		AsyncStateMachineAttribute asyncStateMachineAttribute = (AsyncStateMachineAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(AsyncStateMachineAttribute));
		if (asyncStateMachineAttribute == null)
		{
			return methodBase_0;
		}
		return asyncStateMachineAttribute.StateMachineType.GetMethod("MoveNext", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
	}

	private static bool smethod_195(MethodBase methodBase_0)
	{
		if (!(methodBase_0 == null) && !(methodBase_0.DeclaringType == null) && !(methodBase_0.DeclaringType.Assembly != typeof(Class198).Assembly))
		{
			if (methodBase_0.DeclaringType == typeof(GForm0))
			{
				return true;
			}
			return methodBase_0.DeclaringType.Namespace == "Capybara_UI_Winform.Ui.Bot";
		}
		return false;
	}

	private static bool smethod_196(MethodBase methodBase_0)
	{
		if (!methodBase_0.IsConstructor && !methodBase_0.Name.StartsWith("get_", StringComparison.Ordinal) && !methodBase_0.Name.StartsWith("set_", StringComparison.Ordinal) && !methodBase_0.Name.StartsWith("<", StringComparison.Ordinal) && !methodBase_0.IsDefined(typeof(CompilerGeneratedAttribute), inherit: false))
		{
			if (methodBase_0.DeclaringType != null)
			{
				return methodBase_0.DeclaringType.IsDefined(typeof(CompilerGeneratedAttribute), inherit: false);
			}
			return false;
		}
		return true;
	}

	private static bool smethod_197(MethodBase methodBase_0)
	{
		if (methodBase_0 != null && methodBase_0.DeclaringType != null)
		{
			return hashSet_0.Contains(smethod_190(methodBase_0));
		}
		return false;
	}

	private static HashSet<string> smethod_198()
	{
		HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
		smethod_200(hashSet, typeof(GForm0), "Snap");
		smethod_200(hashSet, typeof(GForm0), "SessionReady");
		smethod_200(hashSet, typeof(GForm0), "ActiveSession");
		smethod_199(hashSet, typeof(GForm0), "IsStopRequested", Array.Empty<Type>());
		smethod_199(hashSet, typeof(GForm0), "PumpTitle", Array.Empty<Type>());
		smethod_199(hashSet, typeof(GForm0), "SignalAutomaticSelfStop", new Type[1] { typeof(Class148) });
		smethod_200(hashSet, typeof(Class119), "Streaming");
		smethod_200(hashSet, typeof(Class119), "World");
		smethod_200(hashSet, typeof(Class119), "ReadyRequest");
		smethod_200(hashSet, typeof(Class119), "PickArmed");
		smethod_200(hashSet, typeof(Class119), "RebuffAvailable");
		smethod_200(hashSet, typeof(Class119), "SkillAvailable");
		smethod_200(hashSet, typeof(Class119), "SkillReadiness");
		smethod_200(hashSet, typeof(Class119), "SkillTab3Ids");
		smethod_201(hashSet, typeof(Class119), "OnDetached");
		smethod_199(hashSet, typeof(Class119), "AskBag", Array.Empty<Type>());
		smethod_199(hashSet, typeof(Class119), "AskFriendWarp", new Type[4]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		});
		smethod_199(hashSet, typeof(Class119), "AskRecall", new Type[3]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		});
		smethod_199(hashSet, typeof(Class119), "AskSell", new Type[2]
		{
			typeof(ushort),
			typeof(IReadOnlyList<Class409.Struct125>)
		});
		smethod_199(hashSet, typeof(Class119), "Attack", new Type[1] { typeof(uint) });
		smethod_199(hashSet, typeof(Class119), "AttackStop", Array.Empty<Type>());
		smethod_199(hashSet, typeof(Class119), "CastBuff", new Type[3]
		{
			typeof(int),
			typeof(ushort),
			typeof(ushort)
		});
		smethod_199(hashSet, typeof(Class119), "CastSkills", new Type[1] { typeof(IEnumerable<int>) });
		smethod_199(hashSet, typeof(Class119), "CheckSkills", new Type[1] { typeof(IEnumerable<int>) });
		smethod_199(hashSet, typeof(Class119), "Dispose", Array.Empty<Type>());
		smethod_199(hashSet, typeof(Class119), "LogDecision", new Type[1] { typeof(string) });
		smethod_199(hashSet, typeof(Class119), "MoveTo", new Type[5]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool),
			typeof(string)
		});
		smethod_199(hashSet, typeof(Class119), "Pick", new Type[2]
		{
			typeof(byte),
			typeof(uint)
		});
		smethod_199(hashSet, typeof(Class119), "TryMoveTo", new Type[5]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool),
			typeof(string)
		});
		smethod_199(hashSet, typeof(Class119), "TryPick", new Type[2]
		{
			typeof(byte),
			typeof(uint)
		});
		smethod_199(hashSet, typeof(Class119), "SelectTarget", new Type[1] { typeof(uint) });
		smethod_199(hashSet, typeof(Class119), "StopStreaming", Array.Empty<Type>());
		smethod_202(hashSet, typeof(Class398), new Type[4]
		{
			typeof(bool),
			typeof(float),
			typeof(float),
			typeof(float)
		});
		smethod_202(hashSet, typeof(Class52), new Type[1] { typeof(IReadOnlyList<GStruct1>) });
		smethod_202(hashSet, typeof(Class132), new Type[3]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		});
		smethod_200(hashSet, typeof(Class412), "Zone");
		smethod_200(hashSet, typeof(Class2), "TargetIndex");
		smethod_200(hashSet, typeof(Class188), "CurrentPosition");
		smethod_200(hashSet, typeof(Class342), "Off");
		smethod_200(hashSet, typeof(Class342), "LastIntervalOkMs");
		smethod_200(hashSet, typeof(Class138), "Readiness");
		smethod_200(hashSet, typeof(Class138), "Refused");
		return hashSet;
	}

	private static void smethod_199(HashSet<string> hashSet_1, Type type_0, string string_0, Type[] type_1)
	{
		MethodInfo method = type_0.GetMethod(string_0, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, type_1, null);
		if (method != null)
		{
			hashSet_1.Add(smethod_190(method));
		}
	}

	private static void smethod_200(HashSet<string> hashSet_1, Type type_0, string string_0)
	{
		PropertyInfo property = type_0.GetProperty(string_0, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		MethodInfo methodInfo = ((property == null) ? null : property.GetGetMethod(nonPublic: true));
		if (methodInfo != null)
		{
			hashSet_1.Add(smethod_190(methodInfo));
		}
	}

	private static void smethod_201(HashSet<string> hashSet_1, Type type_0, string string_0)
	{
		EventInfo eventInfo = type_0.GetEvent(string_0, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		if (!(eventInfo == null))
		{
			MethodInfo addMethod = eventInfo.GetAddMethod(nonPublic: true);
			MethodInfo removeMethod = eventInfo.GetRemoveMethod(nonPublic: true);
			if (addMethod != null)
			{
				hashSet_1.Add(smethod_190(addMethod));
			}
			if (removeMethod != null)
			{
				hashSet_1.Add(smethod_190(removeMethod));
			}
		}
	}

	private static void smethod_202(HashSet<string> hashSet_1, Type type_0, Type[] type_1)
	{
		ConstructorInfo constructor = type_0.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, type_1, null);
		if (constructor != null)
		{
			hashSet_1.Add(smethod_190(constructor));
		}
	}

	[IteratorStateMachine(typeof(Class230))]
	private static IEnumerable<MethodBase> smethod_203(MethodBase methodBase_0)
	{
		return new Class230(-2)
		{
			methodBase_2 = methodBase_0
		};
	}

	private static OpCode[] smethod_204(bool bool_0)
	{
		OpCode[] array = new OpCode[256];
		FieldInfo[] fields = typeof(OpCodes).GetFields(BindingFlags.Static | BindingFlags.Public);
		for (int i = 0; i < fields.Length; i++)
		{
			OpCode opCode = (OpCode)fields[i].GetValue(null);
			ushort num = (ushort)opCode.Value;
			if ((!bool_0 && num < 256) || (bool_0 && (num & 0xFF00) == 65024))
			{
				array[num & 0xFF] = opCode;
			}
		}
		return array;
	}

	private static int smethod_205(OperandType operandType_0, byte[] byte_0, int int_0)
	{
		switch (operandType_0)
		{
		case OperandType.InlineSwitch:
			return 4 + BitConverter.ToInt32(byte_0, int_0) * 4;
		case OperandType.InlineVar:
			return 2;
		case OperandType.ShortInlineBrTarget:
		case OperandType.ShortInlineI:
		case OperandType.ShortInlineVar:
			return 1;
		case OperandType.InlineNone:
			return 0;
		default:
			return 4;
		case OperandType.InlineI8:
		case OperandType.InlineR:
			return 8;
		}
	}

	private static string smethod_206(string string_0, Class282 class282_1, ref int int_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		int num = smethod_210(string_0, "class " + class282_1.string_1, 0, string_0.Length);
		if (num < 0)
		{
			int_0 += smethod_243("automatic/inventory/type/" + class282_1.string_1, bool_0: false);
			return null;
		}
		int num2 = string_0.IndexOf('{', num);
		int num3 = smethod_211(string_0, num2);
		if (num2 >= 0 && num3 >= 0)
		{
			string input = string_0.Substring(num2 + 1, num3 - num2 - 1);
			string pattern = Regex.Escape(class282_1.string_2).Replace("\\ ", "\\s+");
			MatchCollection matchCollection = Regex.Matches(input, pattern, RegexOptions.CultureInvariant);
			if (matchCollection.Count != 1)
			{
				int_0 += smethod_243("automatic/inventory/declaration/" + class282_1.string_3, bool_0: false);
				return null;
			}
			int num4 = num2 + 1 + matchCollection[0].Index;
			int num5 = string_0.IndexOf('{', num4 + matchCollection[0].Length);
			int num6 = smethod_211(string_0, num5);
			if (num5 >= 0 && num5 <= num3 && num6 >= 0 && num6 <= num3)
			{
				return string_0.Substring(num4, num6 - num4 + 1);
			}
			int_0 += smethod_243("automatic/inventory/body/" + class282_1.string_3, bool_0: false);
			return null;
		}
		int_0 += smethod_243("automatic/inventory/type-body/" + class282_1.string_1, bool_0: false);
		return null;
	}

	private static string smethod_207(Dictionary<string, string> dictionary_0, string string_0, ref int int_0)
	{
		if (dictionary_0.TryGetValue(string_0, out var value) && value != null)
		{
			return value;
		}
		int_0 += smethod_243("automatic/inventory/required/" + string_0, bool_0: false);
		return null;
	}

	private static string smethod_208(string string_0, string string_1, string string_2, ref int int_0)
	{
		return smethod_209(smethod_173(string_0, ref int_0), string_0, string_1, string_2, ref int_0);
	}

	private static string smethod_209(string string_0, string string_1, string string_2, string string_3, ref int int_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		int num = smethod_210(string_0, "class " + string_2, 0, string_0.Length);
		if (num < 0)
		{
			int_0 += smethod_243("source/" + string_1 + "/" + string_2 + "/available", bool_0: false);
			return null;
		}
		int num2 = string_0.IndexOf('{', num);
		int num3 = smethod_211(string_0, num2);
		if (num2 >= 0 && num3 >= 0)
		{
			int num4 = smethod_210(string_0, string_3, num2 + 1, num3);
			if (num4 < 0)
			{
				int_0 += smethod_243("source/" + string_1 + "/" + string_3 + "/declaration", bool_0: false);
				return null;
			}
			int num5 = string_0.IndexOf('{', num4 + string_3.Length);
			int num6 = smethod_211(string_0, num5);
			if (num5 >= 0 && num5 <= num3 && num6 >= 0 && num6 <= num3)
			{
				return string_0.Substring(num4, num6 - num4 + 1);
			}
			int_0 += smethod_243("source/" + string_1 + "/" + string_3 + "/body", bool_0: false);
			return null;
		}
		int_0 += smethod_243("source/" + string_1 + "/" + string_2 + "/body", bool_0: false);
		return null;
	}

	private static int smethod_210(string string_0, string string_1, int int_0, int int_1)
	{
		if (!string.IsNullOrEmpty(string_0) && !string.IsNullOrEmpty(string_1) && int_0 >= 0 && int_1 <= string_0.Length)
		{
			int num = string_0.IndexOf(string_1, int_0, StringComparison.Ordinal);
			if (num >= int_0 && num < int_1)
			{
				int num2 = string_0.IndexOf(string_1, num + string_1.Length, StringComparison.Ordinal);
				if (num2 >= 0 && num2 < int_1)
				{
					return -1;
				}
				return num;
			}
			return -1;
		}
		return -1;
	}

	private static int smethod_211(string string_0, int int_0)
	{
		if (!string.IsNullOrEmpty(string_0) && int_0 >= 0 && int_0 < string_0.Length && string_0[int_0] == '{')
		{
			int num = 0;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			int num2 = int_0;
			while (true)
			{
				if (num2 < string_0.Length)
				{
					char c = string_0[num2];
					char c2 = ((num2 + 1 < string_0.Length) ? string_0[num2 + 1] : '\0');
					if (flag)
					{
						if (c == '\n')
						{
							flag = false;
						}
					}
					else if (flag2)
					{
						if (c == '*' && c2 == '/')
						{
							flag2 = false;
							num2++;
						}
					}
					else if (flag3)
					{
						if (flag5 && c == '"' && c2 == '"')
						{
							num2++;
						}
						else
						{
							if ((!flag5 && c == '"' && !flag6) || (flag5 && c == '"'))
							{
								flag3 = false;
								flag5 = false;
							}
							flag6 = !flag5 && c == '\\' && !flag6;
							if (c != '\\')
							{
								flag6 = false;
							}
						}
					}
					else if (flag4)
					{
						if (c == '\'' && !flag6)
						{
							flag4 = false;
						}
						flag6 = c == '\\' && !flag6;
						if (c != '\\')
						{
							flag6 = false;
						}
					}
					else if (c == '/' && c2 == '/')
					{
						flag = true;
						num2++;
					}
					else if (c == '/' && c2 == '*')
					{
						flag2 = true;
						num2++;
					}
					else if (c == '@' && c2 == '"')
					{
						flag3 = true;
						flag5 = true;
						num2++;
					}
					else
					{
						switch (c)
						{
						case '"':
							flag3 = true;
							flag6 = false;
							goto IL_0184;
						case '\'':
							flag4 = true;
							flag6 = false;
							goto IL_0184;
						case '{':
							num++;
							break;
						}
						if (c == '}' && --num == 0)
						{
							break;
						}
					}
					goto IL_0184;
				}
				return -1;
				IL_0184:
				num2++;
			}
			return num2;
		}
		return -1;
	}

	public static int smethod_212()
	{
		Class261 @class = new Class261();
		try
		{
			return smethod_216();
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
	}

	public static int smethod_213()
	{
		Class261 @class = new Class261();
		try
		{
			return smethod_214();
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
	}

	private static int smethod_214()
	{
		Class223 @class = new Class223();
		int num = 0;
		MethodInfo methodInfo = typeof(Class179).GetMethod("smethod_3", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		num = 0 + smethod_243("card-travel/shared-core", methodInfo != null);
		MethodInfo[] methods = typeof(Class179).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
		num += smethod_243("card-travel/exactly-three-entry-methods", methods.Count(Class299.class299_0.method_84) == 3 && methods.All(Class299.class299_0.method_85) && methodInfo != null && methodInfo.IsPrivate);
		MethodInfo methodInfo2 = methods.SingleOrDefault(Class299.class299_0.method_86);
		MethodInfo methodInfo3 = methods.SingleOrDefault(Class299.class299_0.method_87);
		MethodInfo methodInfo4 = methods.SingleOrDefault(Class299.class299_0.method_88);
		num += smethod_243("card-travel/back-to-start-api", methodInfo2 != null);
		num += smethod_243("card-travel/back-to-recent-api", methodInfo3 != null);
		num += smethod_243("card-travel/warp-to-friend-api", methodInfo4 != null);
		if (methodInfo2 != null)
		{
			ParameterInfo[] parameters = methodInfo2.GetParameters();
			num += smethod_243("card-travel/explicit-timing-units", parameters[1].Name == "delayBeforePressSeconds" && parameters[2].Name == "pollIntervalMilliseconds" && parameters[3].Name == "timeoutSeconds" && (int)parameters[1].DefaultValue == 0 && (int)parameters[2].DefaultValue == 200 && (double)parameters[3].DefaultValue == 10.0);
		}
		Dictionary<string, string> dictionary_ = new Dictionary<string, string>(StringComparer.Ordinal)
		{
			["232:18"] = "Start Point Pass [7D]",
			["232:19"] = "Back Point Pass [7D]",
			["232:20"] = "Buddy Transmission Card [7D]"
		};
		Dictionary<string, string> dictionary_2 = new Dictionary<string, string>(StringComparer.Ordinal);
		List<Struct27> list = new List<Struct27>
		{
			new Struct27
			{
				int_0 = 1,
				int_1 = 7,
				ushort_0 = 232,
				ushort_1 = 18,
				int_2 = 1
			},
			new Struct27
			{
				int_0 = 2,
				int_1 = 8,
				ushort_0 = 232,
				ushort_1 = 19,
				int_2 = 1
			},
			new Struct27
			{
				int_0 = 3,
				int_1 = 9,
				ushort_0 = 232,
				ushort_1 = 20,
				int_2 = 1
			}
		};
		Class145 class2 = smethod_161(list, new List<Class403>(), dictionary_, dictionary_2, new Class83
		{
			float_0 = 0f,
			float_1 = 0f,
			float_2 = 0f
		}, 1, 24);
		@class.class145_2 = smethod_161(list, new List<Class403>(), dictionary_, dictionary_2, new Class83
		{
			float_0 = 100f,
			float_1 = 0f,
			float_2 = 0f
		}, 1, 24);
		Dictionary<string, string> dictionary_3 = new Dictionary<string, string>(StringComparer.Ordinal)
		{
			["850:4"] = "Bus Card [7D]",
			["850:5"] = "Start Point Pass [30D]",
			["850:6"] = "Back Point Pass",
			["850:7"] = " buddy transmission card [7d] ",
			["850:8"] = "Start Point Pass Deluxe [7D]"
		};
		List<Struct27> list2 = new List<Struct27>
		{
			new Struct27
			{
				int_0 = 1,
				int_1 = 1,
				ushort_0 = 850,
				ushort_1 = 4,
				int_2 = 1
			},
			new Struct27
			{
				int_0 = 2,
				int_1 = 12,
				ushort_0 = 850,
				ushort_1 = 5,
				int_2 = 1
			},
			new Struct27
			{
				int_0 = 3,
				int_1 = 3,
				ushort_0 = 850,
				ushort_1 = 6,
				int_2 = 1
			},
			new Struct27
			{
				int_0 = 4,
				int_1 = 4,
				ushort_0 = 850,
				ushort_1 = 7,
				int_2 = 1
			},
			new Struct27
			{
				int_0 = 5,
				int_1 = 0,
				ushort_0 = 850,
				ushort_1 = 8,
				int_2 = 1
			},
			new Struct27
			{
				int_0 = 6,
				int_1 = 2,
				ushort_0 = 850,
				ushort_1 = 5,
				int_2 = 0
			},
			new Struct27
			{
				int_0 = 7,
				int_1 = 5,
				ushort_0 = 850,
				ushort_1 = 5,
				int_2 = 1
			}
		};
		@class.class145_1 = smethod_161(list2, new List<Class403>(), dictionary_3, dictionary_2, new Class83
		{
			float_0 = 0f,
			float_2 = 0f
		}, 7, 24);
		@class.class145_0 = smethod_161(list2, new List<Class403>(), dictionary_3, dictionary_2, new Class83
		{
			float_0 = 100f,
			float_2 = 0f
		}, 8, 24);
		Class262 class3 = new Class262();
		class3.class223_0 = @class;
		class3.class222_0 = new Class222(new Class119());
		try
		{
			class3.class222_0.method_0(class3.class223_0.class145_1, bool_0: true);
			class3.list_0 = new List<string>();
			class3.class222_0.class119_0.method_30(class3.method_0);
			class3.long_0 = 0L;
			using (Class75.smethod_1(class3.method_1, 1000L, class3.method_2, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/alternate-start", (Enum9)0, Class179.smethod_0(class3.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
				class3.class222_0.method_0(class3.class223_0.class145_1, bool_0: true);
				num += smethod_244("card-travel/alternate-recent", (Enum9)0, Class179.smethod_1(class3.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
				class3.class222_0.method_0(class3.class223_0.class145_1, bool_0: true);
				num += smethod_244("card-travel/alternate-friend", (Enum9)0, Class179.smethod_2(class3.class222_0.gform0_0, "Bob", 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_243("card-travel/uses-backing-ordinal-and-real-id", class3.list_0.Count == 3 && class3.list_0[0].Contains("\"ord\":5,\"main\":850,\"sub\":5") && class3.list_0[1].Contains("\"ord\":3,\"main\":850,\"sub\":6") && class3.list_0[2].Contains("\"ord\":4,\"main\":850,\"sub\":7"));
		}
		finally
		{
			if (class3.class222_0 != null)
			{
				((IDisposable)class3.class222_0).Dispose();
			}
		}
		Class249 class4 = new Class249();
		class4.class223_0 = @class;
		class4.class222_0 = new Class222(new Class119());
		try
		{
			Class145 class5 = smethod_161(list2, new List<Class403>(), dictionary_3, dictionary_2, new Class83
			{
				float_0 = 0f,
				float_2 = 0f
			}, 6, 24);
			smethod_94(class5, "<BagReceivedUtcTicks>k__BackingField", DateTime.UtcNow.AddSeconds(-10.0).Ticks);
			class4.class222_0.method_0(class5, bool_0: true);
			class4.int_0 = 0;
			class4.list_0 = new List<string>();
			class4.class222_0.class119_0.method_30(class4.method_0);
			class4.long_0 = 0L;
			using (Class75.smethod_1(class4.method_1, 1000L, class4.method_2, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/waits-for-fresh-bag", (Enum9)0, Class179.smethod_0(class4.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_243("card-travel/no-direct-bag-request", class4.int_0 == 2 && class4.list_0.Count == 1 && class4.list_0[0].Contains("\"cmd\":\"recall\""));
		}
		finally
		{
			if (class4.class222_0 != null)
			{
				((IDisposable)class4.class222_0).Dispose();
			}
		}
		Class222 class6 = new Class222(new Class119());
		try
		{
			Class205 class7 = new Class205();
			class6.method_0(Class145.class145_0.method_93(new Class83
			{
				float_0 = 0f
			}, 1, 0), bool_0: true);
			class7.list_0 = new List<string>();
			class6.class119_0.method_30(class7.method_0);
			class7.long_0 = 0L;
			using (Class75.smethod_1(class7.method_1, 1000L, class7.method_2, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/no-bag-is-unavailable", (Enum9)1, Class179.smethod_0(class6.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_244("card-travel/no-bag-no-send", 0, class7.list_0.Count);
			class6.method_0(@class.class145_1.method_99("inventory loading"), bool_0: true);
			class7.long_0 = 0L;
			using (Class75.smethod_1(class7.method_3, 1000L, class7.method_4, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/bag-error-is-unavailable", (Enum9)1, Class179.smethod_0(class6.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_244("card-travel/bag-error-no-send", 0, class7.list_0.Count);
			class6.method_0(@class.class145_1.method_98(list2, null, Class95.class95_0, 9, 24, 60), bool_0: true);
			class7.long_0 = 0L;
			using (Class75.smethod_1(class7.method_5, 1000L, class7.method_6, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/unknown-name-not-guessed", (Enum9)1, Class179.smethod_0(class6.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_244("card-travel/unknown-name-no-send", 0, class7.list_0.Count);
		}
		finally
		{
			((IDisposable)class6).Dispose();
		}
		Class285 class8 = new Class285();
		class8.class223_0 = @class;
		class8.class222_0 = new Class222(new Class119());
		try
		{
			class8.class222_0.method_0(class8.class223_0.class145_1.method_98(list2, null, Class95.class95_0, 9, 24, 60), bool_0: true);
			class8.int_0 = 0;
			class8.list_0 = new List<string>();
			class8.class222_0.class119_0.method_30(class8.method_0);
			class8.long_0 = 0L;
			using (Class75.smethod_1(class8.method_1, 1000L, class8.method_2, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/name-arrives-next-bag", (Enum9)0, Class179.smethod_0(class8.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_243("card-travel/unknown-name-waited-for-producer", class8.int_0 == 2 && class8.list_0.Count == 1);
		}
		finally
		{
			if (class8.class222_0 != null)
			{
				((IDisposable)class8.class222_0).Dispose();
			}
		}
		Class245 class9 = new Class245();
		class9.class222_0 = new Class222(new Class119());
		try
		{
			Class301 class10 = new Class301();
			class9.class222_0.method_0(class2, bool_0: true);
			class10.long_0 = 0L;
			using (Class75.smethod_1(class10.method_0, 1000L, Class299.class299_0.method_89, bool_0: false, bool_1: false))
			{
				num += smethod_244("card-travel/unavailable-start", (Enum9)1, Class179.smethod_0(class9.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
				num += smethod_244("card-travel/unavailable-recent", (Enum9)1, Class179.smethod_1(class9.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
				num += smethod_244("card-travel/unavailable-friend", (Enum9)1, Class179.smethod_2(class9.class222_0.gform0_0, "Bob", 0, 200, 10.0).GetAwaiter().GetResult());
				num += smethod_243("card-travel/invalid-delay-before-availability", smethod_215(class9.method_0));
				num += smethod_243("card-travel/invalid-poll-before-availability", smethod_215(class9.method_1));
				num += smethod_243("card-travel/nan-before-blank-friend", smethod_215(class9.method_2));
				num += smethod_243("card-travel/infinite-timeout-rejected", smethod_215(class9.method_3));
				num += smethod_243("card-travel/negative-timeout-rejected", smethod_215(class9.method_4));
				num += smethod_243("card-travel/unrepresentable-timeout-rejected", smethod_215(class9.method_5));
			}
			using (Class75.smethod_1(class10.method_1, 1000L, Class299.class299_0.method_90, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/blank-friend", (Enum9)3, Class179.smethod_2(class9.class222_0.gform0_0, "   ", 0, 200, 10.0).GetAwaiter().GetResult());
			}
		}
		finally
		{
			if (class9.class222_0 != null)
			{
				((IDisposable)class9.class222_0).Dispose();
			}
		}
		Class222 class11 = new Class222(new Class119());
		try
		{
			Class221 class12 = new Class221();
			class11.method_0(smethod_161(new List<Struct27>(), new List<Class403>(), dictionary_, dictionary_2, new Class83
			{
				float_0 = 0f,
				float_1 = 0f,
				float_2 = 0f
			}, 1, 24), bool_0: true);
			class12.long_0 = 0L;
			using (Class75.smethod_1(class12.method_0, 1000L, Class299.class299_0.method_91, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/missing-card", (Enum9)2, Class179.smethod_0(class11.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
				class11.method_0(smethod_161(list, new List<Class403>(), dictionary_, dictionary_2, null, 1, 24), bool_0: true);
				num += smethod_244("card-travel/missing-self", (Enum9)4, Class179.smethod_0(class11.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
		}
		finally
		{
			((IDisposable)class11).Dispose();
		}
		Class119 class13 = new Class119();
		@class.list_0 = new List<string>();
		Class260 class14 = new Class260();
		class14.class223_0 = @class;
		class14.class222_0 = new Class222(class13);
		try
		{
			class14.class222_0.method_0(class2, bool_0: true);
			class14.long_0 = 0L;
			class14.list_0 = new List<int>();
			List<Struct27> list3 = new List<Struct27>(list);
			list3[0] = new Struct27
			{
				int_0 = 1,
				int_1 = 17,
				ushort_0 = 232,
				ushort_1 = 18,
				int_2 = 1
			};
			class14.class145_1 = smethod_161(list3, new List<Class403>(), dictionary_, dictionary_2, new Class83
			{
				float_0 = 0f,
				float_1 = 0f,
				float_2 = 0f
			}, 1, 24);
			class14.class145_0 = smethod_161(list3, new List<Class403>(), dictionary_, dictionary_2, new Class83
			{
				float_0 = 100f,
				float_1 = 0f,
				float_2 = 0f
			}, 1, 24);
			class13.method_30(class14.method_0);
			using (Class75.smethod_1(class14.method_1, 1000L, class14.method_2, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/pre-delay-result", (Enum9)0, Class179.smethod_0(class14.class222_0.gform0_0, 1, 300, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_243("card-travel/pre-delay-slices-exactly", class14.list_0.SequenceEqual(new int[4] { 300, 300, 300, 100 }));
			num += smethod_243("card-travel/re-resolves-ordinal-after-delay", class14.class223_0.list_0.Count == 1 && class14.class223_0.list_0[0].Contains("\"cmd\":\"recall\",\"ord\":17,\"main\":232,\"sub\":18"));
		}
		finally
		{
			if (class14.class222_0 != null)
			{
				((IDisposable)class14.class222_0).Dispose();
			}
		}
		Class322 class15 = new Class322();
		class15.class222_0 = new Class222(new Class119());
		try
		{
			class15.class222_0.method_0(class2, bool_0: true);
			class15.long_0 = 0L;
			class15.int_0 = 0;
			class15.class222_0.gform0_0.method_7().method_30(class15.method_0);
			using (Class75.smethod_1(class15.method_1, 1000L, class15.method_2, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/stop-during-pre-delay", (Enum9)7, Class179.smethod_0(class15.class222_0.gform0_0, 1, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_244("card-travel/stop-before-send", 0, class15.int_0);
			class15.class222_0.gform0_0.bool_3 = false;
		}
		finally
		{
			if (class15.class222_0 != null)
			{
				((IDisposable)class15.class222_0).Dispose();
			}
		}
		Class324 class16 = new Class324();
		class16.class222_0 = new Class222(new Class119());
		try
		{
			Class203 class17 = new Class203();
			class16.class222_0.method_0(class2, bool_0: true);
			class17.long_0 = 0L;
			class17.int_0 = 0;
			class16.class222_0.gform0_0.method_7().method_30(class16.method_0);
			using (Class75.smethod_1(class17.method_0, 1000L, class17.method_1, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/zero-timeout-synchronous-refusal", (Enum9)5, Class179.smethod_0(class16.class222_0.gform0_0, 0, 200, 0.0).GetAwaiter().GetResult());
			}
			num += smethod_244("card-travel/zero-timeout-does-not-wait", 0, class17.int_0);
		}
		finally
		{
			if (class16.class222_0 != null)
			{
				((IDisposable)class16.class222_0).Dispose();
			}
		}
		Class283 class18 = new Class283();
		class18.class222_0 = new Class222(new Class119());
		try
		{
			class18.class222_0.method_0(class2, bool_0: true);
			class18.long_0 = 0L;
			class18.list_1 = new List<int>();
			class18.list_0 = new List<string>();
			class18.class222_0.gform0_0.method_7().method_30(class18.method_0);
			using (Class75.smethod_1(class18.method_1, 1000L, class18.method_2, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/exact-boundary-refusal", (Enum9)5, Class179.smethod_0(class18.class222_0.gform0_0, 0, 300, 1.0).GetAwaiter().GetResult());
			}
			num += smethod_243("card-travel/confirmation-slices-exactly", class18.list_1.SequenceEqual(new int[4] { 300, 300, 300, 100 }));
			num += smethod_243("card-travel/start-card-id", class18.list_0.Count == 1 && class18.list_0[0].Contains("\"main\":232,\"sub\":18"));
		}
		finally
		{
			if (class18.class222_0 != null)
			{
				((IDisposable)class18.class222_0).Dispose();
			}
		}
		Class243 class19 = new Class243();
		class19.class223_0 = @class;
		class19.class222_0 = new Class222(new Class119());
		try
		{
			class19.class222_0.method_0(class2, bool_0: true);
			class19.long_0 = 0L;
			class19.int_0 = 0;
			class19.class222_0.gform0_0.method_7().method_30(Class299.class299_0.method_92);
			using (Class75.smethod_1(class19.method_0, 1000L, class19.method_1, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/exact-boundary-landing", (Enum9)0, Class179.smethod_0(class19.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_244("card-travel/default-ten-second-200ms-polls", 50, class19.int_0);
		}
		finally
		{
			if (class19.class222_0 != null)
			{
				((IDisposable)class19.class222_0).Dispose();
			}
		}
		Class222 class20 = new Class222(new Class119());
		try
		{
			Class309 class21 = new Class309();
			class20.method_0(class2, bool_0: true);
			class21.long_0 = 0L;
			class21.list_0 = new List<string>();
			class20.gform0_0.method_7().method_30(class21.method_0);
			using (Class75.smethod_1(class21.method_1, 1000L, class21.method_2, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/custom-recent-timeout", (Enum9)6, Class179.smethod_1(class20.gform0_0, 1, 250, 0.5).GetAwaiter().GetResult());
			}
			num += smethod_243("card-travel/recent-card-id", class21.list_0.Count == 1 && class21.list_0[0].Contains("\"main\":232,\"sub\":19"));
		}
		finally
		{
			((IDisposable)class20).Dispose();
		}
		Class229 class22 = new Class229();
		class22.class223_0 = @class;
		class22.class222_0 = new Class222(new Class119());
		try
		{
			class22.class222_0.method_0(class2, bool_0: true);
			class22.long_0 = 0L;
			class22.list_0 = new List<string>();
			class22.class222_0.gform0_0.method_7().method_30(class22.method_0);
			using (Class75.smethod_1(class22.method_1, 1000L, Class299.class299_0.method_93, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/friend-landed", (Enum9)0, Class179.smethod_2(class22.class222_0.gform0_0, "Bob", 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_243("card-travel/friend-card-id", class22.list_0.Count == 1 && class22.list_0[0].Contains("\"cmd\":\"friend_warp\",\"name\":\"Bob\"") && class22.list_0[0].Contains("\"main\":232,\"sub\":20"));
		}
		finally
		{
			if (class22.class222_0 != null)
			{
				((IDisposable)class22.class222_0).Dispose();
			}
		}
		Class269 class23 = new Class269();
		class23.class222_0 = new Class222(new Class119());
		try
		{
			class23.class222_0.method_0(class2, bool_0: true);
			class23.long_0 = 0L;
			using (Class75.smethod_1(class23.method_0, 1000L, class23.method_1, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/detach-while-polling", (Enum9)8, Class179.smethod_0(class23.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
		}
		finally
		{
			if (class23.class222_0 != null)
			{
				((IDisposable)class23.class222_0).Dispose();
			}
		}
		Class330 class24 = new Class330();
		class24.class222_0 = new Class222(new Class119());
		try
		{
			Class209 class25 = new Class209();
			Class210<Struct27> ireadOnlyList_ = new Class210<Struct27>(list, class24.method_0);
			class24.class222_0.method_0(class2.method_97(ireadOnlyList_, new Struct19[0], class2.method_10(), class2.method_43(), class2.method_47()), bool_0: true);
			class25.long_0 = 0L;
			using (Class75.smethod_1(class25.method_0, 1000L, Class299.class299_0.method_94, bool_0: true, bool_1: true))
			{
				num += smethod_244("card-travel/detach-during-live-resolution", (Enum9)8, Class179.smethod_0(class24.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
		}
		finally
		{
			if (class24.class222_0 != null)
			{
				((IDisposable)class24.class222_0).Dispose();
			}
		}
		Class289 class26 = new Class289();
		class26.class222_0 = new Class222(new Class119());
		try
		{
			class26.class145_0 = smethod_161(list, new List<Class403>(), dictionary_, dictionary_2, new Class83
			{
				float_0 = 11f,
				float_1 = 0f,
				float_2 = 12f
			}, 1, 24);
			class26.class145_1 = smethod_161(list, new List<Class403>(), dictionary_, dictionary_2, new Class83
			{
				float_0 = 21f,
				float_1 = 0f,
				float_2 = 22f
			}, 2, 24);
			class26.class222_0.method_0(class26.class145_0, bool_0: true);
			bool bool_ = true;
			Task task = Task.Run((Action)class26.method_0);
			for (int i = 0; i < 20000; i++)
			{
				if (!class26.class222_0.gform0_0.smethod_33(out var float_, out var float_2) || ((float_ != 11f || float_2 != 12f) && (float_ != 21f || float_2 != 22f)))
				{
					bool_ = false;
					break;
				}
			}
			task.GetAwaiter().GetResult();
			num += smethod_243("card-travel/coherent-self-publication", bool_);
		}
		finally
		{
			if (class26.class222_0 != null)
			{
				((IDisposable)class26.class222_0).Dispose();
			}
		}
		Class305 class27 = new Class305();
		class27.class222_0 = new Class222(new Class119());
		try
		{
			Class225 class28 = new Class225();
			class27.class222_0.method_0(smethod_161(new List<Struct27>(), new List<Class403>(), dictionary_, dictionary_2, new Class83
			{
				float_0 = 0f,
				float_1 = 0f,
				float_2 = 0f
			}, 1, 24), bool_0: true);
			Task<Enum9> task2 = Task.Run((Func<Enum9>)class27.method_0);
			Task<Enum9> task3 = Task.Run((Func<Enum9>)class27.method_1);
			Task.WaitAll(task2, task3);
			num += smethod_244("card-travel/concurrent-runtime-unavailable", (Enum9)1, task2.Result);
			num += smethod_244("card-travel/concurrent-runtime-missing", (Enum9)2, task3.Result);
			class28.long_0 = 0L;
			using (Class75.smethod_1(class28.method_0, 1000L, Class299.class299_0.method_97, bool_0: false, bool_1: false))
			{
				using (Class75.smethod_1(class28.method_1, 1000L, Class299.class299_0.method_98, bool_0: true, bool_1: true))
				{
					num += smethod_244("card-travel/runtime-inner-scope", (Enum9)2, Class179.smethod_0(class27.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
				}
				num += smethod_244("card-travel/runtime-scope-restored", (Enum9)1, Class179.smethod_0(class27.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
		}
		finally
		{
			if (class27.class222_0 != null)
			{
				((IDisposable)class27.class222_0).Dispose();
			}
		}
		string text = smethod_174(ref num);
		if (text != null)
		{
			num += smethod_243("card-travel/friend-frame-validates-type", text.Contains("warpCardAt(ord, main, sub, true)") && text.Contains("itemObject.add(o.itemObjType).readU8()") && text.Contains("warpCardRefusal(true, true, true, itemType)") && text.IndexOf("const bad = warpCardAt(ord, main, sub, true)", StringComparison.Ordinal) < text.IndexOf("fnFriendMoveSend(pickConn", StringComparison.Ordinal));
		}
		string text2 = smethod_173("Capybara-UI-Winform\\Ui\\Bot\\Card_Travel.cs", ref num);
		string text3 = smethod_173("Capybara-UI-Winform\\Ui\\Bot\\FormAccess.cs", ref num);
		if (text2 != null && text3 != null)
		{
			num += smethod_243("card-travel/no-legacy-item-id-selection", !text2.Contains("CardMain = 232") && !text2.Contains("CardStartPointSub = 18") && !text2.Contains("CardBackPointSub = 19") && !text2.Contains("CardBuddySub = 20") && !text3.Contains("TryReadLiveCardOrdinal"));
		}
		Console.WriteLine("card-travel: " + num + " failed");
		return num;
	}

	private static bool smethod_215(Func<Task<Enum9>> func_0)
	{
		try
		{
			func_0().GetAwaiter().GetResult();
			return false;
		}
		catch (ArgumentOutOfRangeException)
		{
			return true;
		}
	}

	private static int smethod_216()
	{
		return smethod_217();
	}

	private static int smethod_217()
	{
		return smethod_158();
	}

	private static int smethod_218()
	{
		int num = 0;
		num = 0 + smethod_244("friendpick/ready draws", (Class81.Enum4)1, Class81.smethod_2(bool_0: true, "ready", string.Empty, 100L));
		num += smethod_244("friendpick/empty stops", (Class81.Enum4)2, Class81.smethod_2(bool_0: true, "empty", string.Empty, 100L));
		num += smethod_244("friendpick/refreshing waits", (Class81.Enum4)0, Class81.smethod_2(bool_0: true, "refreshing", string.Empty, 100L));
		num += smethod_244("friendpick/refusal is refused", (Class81.Enum4)3, Class81.smethod_2(bool_0: true, string.Empty, "no friend manager yet", 100L));
		num += smethod_243("friendpick/empty and refreshing differ", Class81.smethod_2(bool_0: true, "empty", string.Empty, 100L) != Class81.smethod_2(bool_0: true, "refreshing", string.Empty, 100L));
		num += smethod_243("friendpick/empty does not keep the splash up", Class81.smethod_2(bool_0: true, "empty", string.Empty, 100L) != (Class81.Enum4)0);
		num += smethod_243("friendpick/refreshing does not report no friends", Class81.smethod_2(bool_0: true, "refreshing", string.Empty, 100L) != (Class81.Enum4)2);
		num += smethod_244("friendpick/refusal beats a ready state", (Class81.Enum4)3, Class81.smethod_2(bool_0: true, "ready", "torn read", 100L));
		num += smethod_244("friendpick/stale ready keeps waiting", (Class81.Enum4)0, Class81.smethod_2(bool_0: false, "ready", string.Empty, 100L));
		num += smethod_244("friendpick/stale empty keeps waiting", (Class81.Enum4)0, Class81.smethod_2(bool_0: false, "empty", string.Empty, 100L));
		num += smethod_244("friendpick/no state yet waits", (Class81.Enum4)0, Class81.smethod_2(bool_0: true, string.Empty, string.Empty, 100L));
		num += smethod_244("friendpick/refreshing forever times out", (Class81.Enum4)4, Class81.smethod_2(bool_0: true, "refreshing", string.Empty, 12000L));
		num += smethod_244("friendpick/silence times out", (Class81.Enum4)4, Class81.smethod_2(bool_0: false, string.Empty, string.Empty, 12000L));
		num += smethod_244("friendpick/one ms short still waits", (Class81.Enum4)0, Class81.smethod_2(bool_0: true, "refreshing", string.Empty, 11999L));
		num += smethod_244("friendpick/repeated refusal keeps its sentence", (Class81.Enum4)3, Class81.smethod_2(bool_0: false, string.Empty, "friend offsets not loaded", 12000L));
		num += smethod_243("friendpick/bound covers three refresh gaps", bool_0: true);
		num += smethod_243("friendpick/poll is positive", bool_0: true);
		num += smethod_243("friendpick/poll is faster than the bound", bool_0: true);
		num += smethod_243("friendpick/ask gap is inside the refresh gap", bool_0: true);
		num += smethod_243("friendpick/never asked asks now", Class81.smethod_0(-1L, 0L));
		num += smethod_243("friendpick/inside the gap does not ask", !Class81.smethod_0(0L, 499L));
		num += smethod_243("friendpick/on the gap asks", Class81.smethod_0(0L, 500L));
		num += smethod_243("friendpick/past the gap asks", Class81.smethod_0(0L, 501L));
		num += smethod_243("friendpick/same reply is not fresh", !Class81.smethod_1(4, string.Empty, 4, string.Empty));
		num += smethod_243("friendpick/moved sequence is fresh", Class81.smethod_1(5, string.Empty, 4, string.Empty));
		num += smethod_243("friendpick/new sentence is fresh", Class81.smethod_1(0, "no friend manager yet", 0, string.Empty));
		num += smethod_243("friendpick/cleared sentence is fresh", Class81.smethod_1(0, string.Empty, 0, "no friend manager yet"));
		num += smethod_243("friendpick/changed sentence is fresh", Class81.smethod_1(0, "torn read", 0, "no friend manager yet"));
		num += smethod_243("friendpick/parked sequence still notices the sentence", Class81.smethod_1(0, "torn read", 0, string.Empty));
		num += smethod_243("friendpick/null sentence equals blank", !Class81.smethod_1(4, null, 4, string.Empty));
		num += smethod_243("friendpick/blank sentence equals null", !Class81.smethod_1(4, string.Empty, 4, null));
		num += smethod_244("friendpick/countdown at the start", "Waiting for the game to answer - 12s left", Class81.smethod_3(0L));
		num += smethod_244("friendpick/countdown rounds up", "Waiting for the game to answer - 12s left", Class81.smethod_3(1L));
		num += smethod_244("friendpick/countdown near the end", "Waiting for the game to answer - 1s left", Class81.smethod_3(11999L));
		num += smethod_244("friendpick/countdown at the bound", "Waiting for the game to answer - 0s left", Class81.smethod_3(12000L));
		num += smethod_244("friendpick/countdown past the bound", "Waiting for the game to answer - 0s left", Class81.smethod_3(17000L));
		string[] array = Class81.smethod_14();
		num += smethod_244("friendpick/eight columns", 8, array.Length);
		num += smethod_244("friendpick/head name", "Name", array[0]);
		num += smethod_244("friendpick/head id", "Id", array[1]);
		num += smethod_244("friendpick/head block", "Block", array[2]);
		num += smethod_244("friendpick/head online", "Online", array[3]);
		num += smethod_244("friendpick/head channel", "Ch", array[4]);
		num += smethod_244("friendpick/head level", "Level", array[5]);
		num += smethod_244("friendpick/head class", "Class", array[6]);
		num += smethod_244("friendpick/head school", "School", array[7]);
		for (int i = 0; i < array.Length; i++)
		{
			num += smethod_243("friendpick/head " + i + " is filled", array[i] != null && array[i].Length != 0);
		}
		Struct140 struct140_ = smethod_219("Sena", 1001, 1, bool_0: true, bool_1: true, 3, 120, 2, 1);
		string[] array2 = Class81.smethod_13(struct140_);
		num += smethod_244("friendpick/row is eight cells", 8, array2.Length);
		num += smethod_244("friendpick/cell name", "Sena", array2[0]);
		num += smethod_244("friendpick/cell id", "1001", array2[1]);
		num += smethod_244("friendpick/cell block", "Valid", array2[2]);
		num += smethod_244("friendpick/cell online", "Online", array2[3]);
		num += smethod_244("friendpick/cell channel", "3", array2[4]);
		num += smethod_244("friendpick/cell level", "120", array2[5]);
		num += smethod_244("friendpick/cell class", "2", array2[6]);
		num += smethod_244("friendpick/cell school", "MysticPeak", array2[7]);
		num += smethod_244("friendpick/row name matches the renderer", Class81.smethod_5(struct140_), array2[0]);
		num += smethod_244("friendpick/row class matches the renderer", Class81.smethod_11(struct140_), array2[6]);
		num += smethod_244("friendpick/row school matches the renderer", Class81.smethod_12(struct140_), array2[7]);
		num += smethod_244("friendpick/online", "Online", Class81.smethod_8(smethod_219("A", 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244("friendpick/offline", "Offline", Class81.smethod_8(smethod_219("A", 1, 1, bool_0: false, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244("friendpick/unknown with a false byte", "Unknown", Class81.smethod_8(smethod_219("A", 1, 1, bool_0: false, bool_1: false, 0, 1, 0, 0)));
		num += smethod_244("friendpick/unknown with a true byte", "Unknown", Class81.smethod_8(smethod_219("A", 1, 1, bool_0: true, bool_1: false, 0, 1, 0, 0)));
		num += smethod_243("friendpick/unknown is not offline", Class81.smethod_8(smethod_219("A", 1, 1, bool_0: false, bool_1: false, 0, 1, 0, 0)) != Class81.smethod_8(smethod_219("A", 1, 1, bool_0: false, bool_1: true, 0, 1, 0, 0)));
		num += smethod_243("friendpick/unknown is not online", Class81.smethod_8(smethod_219("A", 1, 1, bool_0: true, bool_1: false, 0, 1, 0, 0)) != Class81.smethod_8(smethod_219("A", 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_243("friendpick/three distinct online words", bool_0: true);
		num += smethod_244("friendpick/flag block", "Block", Class81.smethod_7(smethod_219("A", 1, -1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244("friendpick/flag off", "Off", Class81.smethod_7(smethod_219("A", 1, 0, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244("friendpick/flag valid", "Valid", Class81.smethod_7(smethod_219("A", 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244("friendpick/flag betray", "Betray", Class81.smethod_7(smethod_219("A", 1, 2, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244("friendpick/flag unknown reads as the number", "7", Class81.smethod_7(smethod_219("A", 1, 7, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244("friendpick/flag -1 is not 255", "Block", Class81.smethod_7(smethod_219("A", 1, -1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244("friendpick/school 0", "SacredGate", Class81.smethod_12(smethod_219("A", 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244("friendpick/school 1", "MysticPeak", Class81.smethod_12(smethod_219("A", 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 1)));
		num += smethod_244("friendpick/school 2", "Phoenix", Class81.smethod_12(smethod_219("A", 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 2)));
		num += smethod_244("friendpick/school unknown reads as the number", "9", Class81.smethod_12(smethod_219("A", 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 9)));
		num += smethod_244("friendpick/class 0", "0", Class81.smethod_11(smethod_219("A", 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244("friendpick/class 2", "2", Class81.smethod_11(smethod_219("A", 1, 1, bool_0: true, bool_1: true, 0, 1, 2, 0)));
		num += smethod_244("friendpick/class 255", "255", Class81.smethod_11(smethod_219("A", 1, 1, bool_0: true, bool_1: true, 0, 1, byte.MaxValue, 0)));
		num += smethod_243("friendpick/class never borrows a school name", Class81.smethod_11(smethod_219("A", 1, 1, bool_0: true, bool_1: true, 0, 1, 1, 1)) != Class81.smethod_12(smethod_219("A", 1, 1, bool_0: true, bool_1: true, 0, 1, 1, 1)));
		num += smethod_244("friendpick/id negative", "-4", Class81.smethod_6(smethod_219("A", -4, 1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244("friendpick/channel", "12", Class81.smethod_9(smethod_219("A", 1, 1, bool_0: true, bool_1: true, 12, 1, 0, 0)));
		num += smethod_244("friendpick/level", "65535", Class81.smethod_10(smethod_219("A", 1, 1, bool_0: true, bool_1: true, 0, ushort.MaxValue, 0, 0)));
		num += smethod_243("friendpick/blocked is selectable", Class81.smethod_4(smethod_219("Rook", 2, -1, bool_0: false, bool_1: true, 0, 60, 1, 0)));
		num += smethod_243("friendpick/offline is selectable", Class81.smethod_4(smethod_219("Mira", 3, 1, bool_0: false, bool_1: true, 0, 60, 1, 0)));
		num += smethod_243("friendpick/unknown is selectable", Class81.smethod_4(smethod_219("Tam", 4, 1, bool_0: false, bool_1: false, 0, 0, 0, 0)));
		num += smethod_243("friendpick/betray is selectable", Class81.smethod_4(smethod_219("Ess", 5, 2, bool_0: true, bool_1: true, 0, 60, 1, 0)));
		num += smethod_244("friendpick/blocked keeps its name", "Rook", Class81.smethod_5(smethod_219("Rook", 2, -1, bool_0: false, bool_1: true, 0, 60, 1, 0)));
		num += smethod_243("friendpick/blank name is refused", !Class81.smethod_4(smethod_219(string.Empty, 6, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)));
		num += smethod_243("friendpick/whitespace name is refused", !Class81.smethod_4(smethod_219("   ", 7, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)));
		num += smethod_243("friendpick/null name is refused", !Class81.smethod_4(smethod_219(null, 8, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)));
		num += smethod_244("friendpick/blank name shows the placeholder", "(no name)", Class81.smethod_5(smethod_219(string.Empty, 6, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)));
		num += smethod_244("friendpick/null name shows the placeholder", "(no name)", Class81.smethod_5(smethod_219(null, 8, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)));
		num += smethod_243("friendpick/the placeholder row is still refused", !Class81.smethod_4(smethod_219(string.Empty, 6, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)) && Class81.smethod_5(smethod_219(string.Empty, 6, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)) == "(no name)");
		num += smethod_244("friendpick/name kept verbatim", " Bo Bo ", Class81.smethod_5(smethod_219(" Bo Bo ", 9, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)));
		List<Struct140> list = new List<Struct140>();
		list.Add(smethod_219("Sena", 1, 1, bool_0: true, bool_1: true, 0, 60, 1, 0));
		list.Add(smethod_219("Rook", 2, -1, bool_0: false, bool_1: true, 0, 60, 1, 0));
		list.Add(smethod_219(string.Empty, 3, 1, bool_0: true, bool_1: true, 0, 60, 1, 0));
		num += smethod_244("friendpick/pickable counts the blocked row", 2, Class81.smethod_15(list));
		num += smethod_244("friendpick/pickable of none", 0, Class81.smethod_15(null));
		num += smethod_244("friendpick/pickable of empty", 0, Class81.smethod_15(new Struct140[0]));
		num += smethod_244("friendpick/clean reply says nothing about drops", string.Empty, Class81.smethod_16(0));
		num += smethod_244("friendpick/negative drop says nothing", string.Empty, Class81.smethod_16(-1));
		num += smethod_243("friendpick/drops are said out loud", Class81.smethod_16(2).Contains("2") && Class81.smethod_16(2).Contains("could not be read"));
		num += smethod_244("friendpick/agent sentence is shown", "friend offsets not loaded", GForm0.smethod_12("friend offsets not loaded"));
		num += smethod_244("friendpick/silent refusal gets a sentence", "the agent refused the friend list without saying why", GForm0.smethod_12(string.Empty));
		return num + smethod_244("friendpick/null refusal gets a sentence", "the agent refused the friend list without saying why", GForm0.smethod_12(null));
	}

	private static Struct140 smethod_219(string string_0, int int_0, sbyte sbyte_0, bool bool_0, bool bool_1, byte byte_0, ushort ushort_0, byte byte_1, byte byte_2)
	{
		return new Struct140
		{
			string_0 = string_0,
			int_0 = int_0,
			sbyte_0 = sbyte_0,
			bool_0 = bool_0,
			bool_1 = bool_1,
			byte_0 = byte_0,
			ushort_0 = ushort_0,
			byte_1 = byte_1,
			byte_2 = byte_2
		};
	}

	private static string smethod_220(string string_0)
	{
		int num = string_0.IndexOf("var ZERO_OK_KEYS = [", StringComparison.Ordinal);
		if (num < 0)
		{
			return string.Empty;
		}
		int num2 = string_0.IndexOf(']', num);
		if (num2 < 0)
		{
			return string.Empty;
		}
		return string_0.Substring(num, num2 - num);
	}

	private static bool smethod_221(string string_0, string string_1, int int_0)
	{
		string text = "\"" + string_1 + "\":" + int_0;
		if (!string_0.Contains(text + ","))
		{
			return string_0.Contains(text + "}");
		}
		return true;
	}

	private static void smethod_222(JObject jobject_0, Dictionary<string, string> dictionary_0)
	{
		JObject jObject = ((jobject_0 == null) ? null : (jobject_0["inames"] as JObject));
		if (jObject == null)
		{
			return;
		}
		foreach (KeyValuePair<string, JToken> item in jObject)
		{
			if (!string.IsNullOrEmpty(item.Key))
			{
				dictionary_0[item.Key] = (string?)item.Value;
			}
		}
	}

	private static JObject smethod_223(string string_0)
	{
		string text = "{\"t\":\"bag\",\"ok\":true,\"seq\":1,\"bag\":[],\"inames\":{},\"equip\":[" + string_0;
		for (int i = 1; i < 12; i++)
		{
			text = text + ",{\"i\":" + i + ",\"pos\":6,\"main\":29,\"sub\":3,\"amt\":1}";
		}
		return JObject.Parse(text + "]}");
	}

	private static JObject smethod_224(int int_0)
	{
		string text = "{\"t\":\"bag\",\"ok\":true,\"seq\":1,\"bag\":[],\"inames\":{},\"equip\":[";
		for (int i = 0; i < int_0; i++)
		{
			if (i != 0)
			{
				text += ",";
			}
			text = text + "{\"i\":" + i + ",\"pos\":6,\"main\":29,\"sub\":3,\"amt\":1}";
		}
		return JObject.Parse(text + "]}");
	}

	private static Class145 smethod_225(JObject jobject_0)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		smethod_222(jobject_0, dictionary);
		return Class145.class145_0.method_97(Class119.smethod_40(jobject_0), Class119.smethod_43(jobject_0), new Class95(null, dictionary, null), 1, Class119.smethod_41(jobject_0));
	}

	private static JObject smethod_226(string string_0)
	{
		return JObject.Parse("{\"t\":\"bag\",\"ok\":true,\"seq\":7,\"bag\":[{\"i\":0,\"ord\":0,\"main\":11,\"sub\":1,\"amt\":1},{\"i\":3,\"ord\":3,\"main\":9,\"sub\":9,\"amt\":42},{\"i\":7,\"ord\":7,\"main\":61,\"sub\":1,\"amt\":2}],\"slots\":60,\"equip\":[{\"i\":0,\"pos\":1,\"main\":65535,\"sub\":65535,\"amt\":0},{\"i\":1,\"pos\":6,\"main\":29,\"sub\":3,\"amt\":1},{\"i\":2,\"pos\":6,\"main\":65535,\"sub\":65535,\"amt\":0},{\"i\":3,\"pos\":2,\"main\":38,\"sub\":1,\"amt\":0},{\"i\":4,\"pos\":3,\"main\":41,\"sub\":1,\"amt\":0},{\"i\":5,\"pos\":5,\"main\":44,\"sub\":1,\"amt\":0},{\"i\":6,\"pos\":4,\"main\":65535,\"sub\":65535,\"amt\":0},{\"i\":7,\"pos\":7,\"main\":59,\"sub\":1,\"amt\":1},{\"i\":8,\"pos\":8,\"main\":65535,\"sub\":65535,\"amt\":0},{\"i\":9,\"pos\":9,\"main\":61,\"sub\":2,\"amt\":1},{\"i\":10,\"pos\":9,\"main\":61,\"sub\":1,\"amt\":1},{\"i\":11,\"pos\":12,\"main\":65535,\"sub\":65535,\"amt\":0}],\"inames\":{\"11:1\":\"Recovery Potion\",\"29:3\":\"JianXi Bow\",\"38:1\":\"Preparatory Coat\",\"41:1\":\"Preparatory Skirt\",\"44:1\":\"Preparatory Boots\",\"59:1\":\"Wooden Necklace\",\"61:2\":\"Copper Ring\",\"61:1\":\"Copper Tin Ring\"}}".Substring(0, 932) + ",\"cap\":" + string_0 + "}");
	}

	private static Class358 smethod_227((ushort, ushort)[] valueTuple_0, long long_1)
	{
		List<Struct16> list = new List<Struct16>();
		for (int i = 0; i < valueTuple_0.Length; i++)
		{
			if (valueTuple_0[i].Item1 != ushort.MaxValue && valueTuple_0[i].Item2 != ushort.MaxValue)
			{
				list.Add(smethod_229(valueTuple_0[i].Item1, valueTuple_0[i].Item2, 0));
			}
		}
		return new Class358
		{
			long_0 = long_1,
			struct16_0 = list.ToArray()
		};
	}

	private static Class358 smethod_228(long long_1, Struct16[] struct16_0)
	{
		return new Class358
		{
			long_0 = long_1,
			struct16_0 = struct16_0
		};
	}

	private static Struct16 smethod_229(ushort ushort_0, ushort ushort_1, int int_0)
	{
		return new Struct16
		{
			ushort_0 = ushort_0,
			ushort_1 = ushort_1,
			int_0 = int_0
		};
	}

	private static GClass6 smethod_230((string, string)[] valueTuple_0)
	{
		List<GClass4> list = new List<GClass4>
		{
			new GClass4
			{
				Key = Class357.string_0,
				Value = "0x1000"
			},
			new GClass4
			{
				Key = Class357.string_1,
				Value = "0x1004"
			},
			new GClass4
			{
				Key = Class357.string_2,
				Value = "0x1008"
			},
			new GClass4
			{
				Key = Class357.string_3,
				Value = "24"
			},
			new GClass4
			{
				Key = Class357.string_4,
				Value = "6000.0.0f1"
			}
		};
		for (int i = 0; i < valueTuple_0.Length; i++)
		{
			list.Add(new GClass4
			{
				Key = valueTuple_0[i].Item1,
				Value = "0x" + (8192 + i * 4).ToString("X")
			});
		}
		return new GClass6
		{
			MemoryPointers = list
		};
	}

	public static int smethod_231()
	{
		int num = 0;
		List<string[]> list = new List<string[]>();
		list.Add(new string[5] { "12.5", "-3.25", "2", "True", "7.75" });
		list.Add(new string[5] { "100", "200", "0", "False", "0" });
		string text = Class440.smethod_12(list, "Hero1", new DateTime(2026, 9, 17, 10, 30, 0));
		num = 0 + smethod_243("json_date", text.Contains("\"SaveDate\": \"2026-09-17 10:30:00\""));
		num += smethod_243("json_grid", text.Contains("\"GridName\": \"grid1\""));
		num += smethod_243("json_hero", text.Contains("\"HeroName\": \"Hero1\""));
		List<string[]> list2 = Class440.smethod_13(text, out var int_);
		num += smethod_243("rt_parsed", list2 != null);
		num += smethod_244("rt_count", 2, list2?.Count ?? (-1));
		num += smethod_244("rt_skipped", 0, int_);
		if (list2 != null && list2.Count == 2)
		{
			for (int i = 0; i < list.Count; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					num += smethod_244("rt_" + i + "_" + j, list[i][j], list2[i][j]);
				}
			}
		}
		list2 = Class440.smethod_13("{\"RowData\":[[\"1\",\"2\"]]}", out int_);
		num += smethod_243("def_parsed", list2 != null && list2.Count == 1);
		num += smethod_244("def_skipped", 0, int_);
		if (list2 != null && list2.Count == 1)
		{
			num += smethod_244("def_x", "1", list2[0][0]);
			num += smethod_244("def_z", "2", list2[0][1]);
			num += smethod_244("def_delay", "0", list2[0][2]);
			num += smethod_244("def_nohit", "False", list2[0][3]);
			num += smethod_244("def_y", "0", list2[0][4]);
		}
		list2 = Class440.smethod_13("{\"RowData\":[[\"1\",\"2\",\"abc\",\"maybe\",\"tall\"],[\"3\",\"4\",\"-5\",\"true\",\"9\"]]}", out int_);
		num += smethod_243("bad_parsed", list2 != null && list2.Count == 2);
		if (list2 != null && list2.Count == 2)
		{
			num += smethod_244("bad_delay", "0", list2[0][2]);
			num += smethod_244("bad_nohit", "False", list2[0][3]);
			num += smethod_244("bad_y", "0", list2[0][4]);
			num += smethod_244("neg_delay", "0", list2[1][2]);
			num += smethod_244("lower_true", "True", list2[1][3]);
			num += smethod_244("kept_y", "9", list2[1][4]);
		}
		list2 = Class440.smethod_13("{\"RowData\":[[\"x\",\"2\",\"0\",\"False\",\"0\"],[\"1\"],\"junk\",[\"3\",\"4\"]]}", out int_);
		num += smethod_243("skip_parsed", list2 != null && list2.Count == 1);
		num += smethod_244("skip_count", 3, int_);
		if (list2 != null && list2.Count == 1)
		{
			num += smethod_244("skip_kept_x", "3", list2[0][0]);
		}
		list2 = Class440.smethod_13("{\"RowData\":[[1, 2.5, 3, true, 4]]}", out int_);
		num += smethod_243("num_parsed", list2 != null && list2.Count == 1);
		if (list2 != null && list2.Count == 1)
		{
			num += smethod_244("num_x", "1", list2[0][0]);
			num += smethod_244("num_z", "2.5", list2[0][1]);
			num += smethod_244("num_delay", "3", list2[0][2]);
			num += smethod_244("num_nohit", "True", list2[0][3]);
			num += smethod_244("num_y", "4", list2[0][4]);
		}
		num += smethod_243("inv_text", Class440.smethod_13("not json", out int_) == null);
		num += smethod_243("inv_array", Class440.smethod_13("[[\"1\",\"2\"]]", out int_) == null);
		num += smethod_243("inv_norowdata", Class440.smethod_13("{\"GridName\":\"grid1\"}", out int_) == null);
		num += smethod_243("inv_rowdata_type", Class440.smethod_13("{\"RowData\":\"nope\"}", out int_) == null);
		num += smethod_243("inv_empty", Class440.smethod_13("{\"RowData\":[]}", out int_) == null);
		num += smethod_243("inv_allbad", Class440.smethod_13("{\"RowData\":[[\"x\",\"y\"],[\"1\"]]}", out int_) == null);
		num += smethod_244("inv_allbad_skipped", 2, int_);
		num += smethod_243("inv_null", Class440.smethod_13(null, out int_) == null);
		num += smethod_243("inv_blank", Class440.smethod_13("   ", out int_) == null);
		List<string[]> list3 = new List<string[]>();
		list3.Add(new string[2] { "1", "2" });
		list3.Add(null);
		string text2 = Class440.smethod_12(list3, null, DateTime.Now);
		num += smethod_243("ragged_hero", text2.Contains("\"HeroName\": \"\""));
		list2 = Class440.smethod_13(text2, out int_);
		num += smethod_243("ragged_parsed", list2 != null && list2.Count == 1);
		num += smethod_244("ragged_skipped", 1, int_);
		Console.WriteLine("gridjson: " + num + " failed");
		return num;
	}

	public static int smethod_232()
	{
		int num = 0;
		num = 0 + smethod_243("sell/exact", Class96.smethod_2(smethod_235(new string[1] { "Apple" }), "Apple"));
		num += smethod_243("sell/case", Class96.smethod_2(smethod_235(new string[1] { "apple" }), "APPLE"));
		num += smethod_243("sell/trim_row", Class96.smethod_2(smethod_235(new string[1] { " Apple " }), "Apple"));
		num += smethod_243("sell/trim_name", Class96.smethod_2(smethod_235(new string[1] { "Apple" }), " Apple "));
		num += smethod_243("sell/whitespace_row_matches_nothing", !Class96.smethod_2(smethod_235(new string[1] { "   " }), "Red Apple"));
		num += smethod_243("sell/whitespace_row_vs_blank", !Class96.smethod_2(smethod_235(new string[1] { "   " }), "   "));
		num += smethod_243("sell/substring_row_not", !Class96.smethod_2(smethod_235(new string[1] { "Red Apple" }), "Apple"));
		num += smethod_243("sell/substring_name_not", !Class96.smethod_2(smethod_235(new string[1] { "App" }), "Apple"));
		num += smethod_243("sell/empty_list", !Class96.smethod_2(smethod_235(Array.Empty<string>()), "Apple"));
		num += smethod_243("sell/null_name", !Class96.smethod_2(smethod_235(new string[1] { "Apple" }), null));
		num += smethod_243("sell/no_columns", !Class96.smethod_2(new DataGridView(), "Apple"));
		num += smethod_243("sell/newrow_skipped", !Class96.smethod_2(smethod_236(Array.Empty<string>()), "Apple"));
		DataGridView dataGridView = smethod_235(Array.Empty<string>());
		dataGridView.Rows.Add();
		num += smethod_243("sell/null_cell", !Class96.smethod_2(dataGridView, "Apple"));
		DataGridView dataGridView2 = new DataGridView();
		dataGridView2.AllowUserToAddRows = false;
		dataGridView2.Columns.Add("slot", "slot no.");
		dataGridView2.Rows.Add("0");
		num += smethod_244("sell/rowname_short_row", string.Empty, Class96.smethod_3(dataGridView2.Rows[0]));
		DataGridView dataGridView_ = smethod_235(Array.Empty<string>());
		num += smethod_243("sell/toggle_on", Class55.smethod_3(dataGridView_, "Apple", null));
		num += smethod_244("sell/toggle_on_rows", "Apple", smethod_124(dataGridView_));
		num += smethod_243("sell/toggle_off", !Class55.smethod_3(dataGridView_, "Apple", null));
		num += smethod_244("sell/toggle_off_rows", string.Empty, smethod_124(dataGridView_));
		DataGridView dataGridView_2 = smethod_235(new string[1] { "apple" });
		num += smethod_243("sell/toggle_off_case", !Class55.smethod_3(dataGridView_2, "APPLE", null));
		num += smethod_244("sell/toggle_off_case_rows", string.Empty, smethod_124(dataGridView_2));
		DataGridView dataGridView_3 = smethod_235(Array.Empty<string>());
		num += smethod_244("sell/no_duplicate_added", 1, Class55.smethod_1(dataGridView_3, smethod_239(new string[3] { "Apple", "apple", " Apple " }), null));
		num += smethod_244("sell/no_duplicate", "Apple", smethod_124(dataGridView_3));
		DataGridView dataGridView_4 = smethod_235(Array.Empty<string>());
		num += smethod_244("sell/add_blank_ignored", 0, Class55.smethod_1(dataGridView_4, smethod_239(new string[3]
		{
			string.Empty,
			"   ",
			null
		}), null));
		num += smethod_244("sell/add_blank_ignored_rows", string.Empty, smethod_124(dataGridView_4));
		DataGridView dataGridView_5 = smethod_235(new string[1] { "Apple" });
		num += smethod_244("sell/remove_absent", 0, Class55.smethod_2(dataGridView_5, smethod_239(new string[1] { "Banana" }), null));
		num += smethod_244("sell/remove_absent_rows", "Apple", smethod_124(dataGridView_5));
		DataGridView dataGridView3 = smethod_236(new string[2] { "Apple", "Banana" });
		num += smethod_244("sell/remove_newrow_safe", 2, Class55.smethod_2(dataGridView3, smethod_239(new string[2] { "Apple", "Banana" }), null));
		num += smethod_244("sell/remove_newrow_safe_rows", string.Empty, smethod_124(dataGridView3));
		num += smethod_244("sell/remove_newrow_safe_phantom", 1, dataGridView3.Rows.Count);
		string text = Path.Combine(Path.GetTempPath(), "capy_sell_" + Guid.NewGuid().ToString("N"));
		try
		{
			Class67 @class = new Class67(Path.Combine(text, "bulk"));
			DataGridView dataGridView_6 = smethod_235(Array.Empty<string>());
			@class.method_7(dataGridView_6, "Want_Sell_test.json");
			@class.method_8("__sell_test__");
			int num2 = @class.method_3();
			Class55.smethod_1(dataGridView_6, smethod_239(new string[3] { "Apple", "Banana", "Cherry" }), @class);
			num += smethod_244("sell/bulk_saves_once", num2 + 1, @class.method_3());
			num += smethod_244("sell/bulk_saves_once_rows", "Apple,Banana,Cherry", smethod_124(dataGridView_6));
			string string_ = Path.Combine(text, "persist");
			Class67 class2 = new Class67(string_);
			DataGridView dataGridView_7 = smethod_235(Array.Empty<string>());
			class2.method_7(dataGridView_7, "Want_Sell_test.json");
			class2.method_8("__sell_test__");
			Class55.smethod_3(dataGridView_7, "Apple", class2);
			num += smethod_243("sell/persist_saved", class2.method_3() > 0);
			Class67 class3 = new Class67(string_);
			DataGridView dataGridView_8 = smethod_235(Array.Empty<string>());
			class3.method_7(dataGridView_8, "Want_Sell_test.json");
			class3.method_8("__sell_test__");
			num += smethod_244("sell/persist_roundtrip", "Apple", smethod_124(dataGridView_8));
		}
		finally
		{
			try
			{
				if (Directory.Exists(text))
				{
					Directory.Delete(text, recursive: true);
				}
			}
			catch
			{
			}
		}
		DataGridView dataGridView4 = smethod_237(new string[3] { "Sword", "Potion", "Shield" });
		dataGridView4.ClearSelection();
		dataGridView4.CurrentCell = null;
		num += smethod_244("sell/sel_none", 0, Class55.smethod_0(dataGridView4).Count);
		dataGridView4.Rows[1].Cells[0].Selected = true;
		num += smethod_244("sell/sel_reads_name_column", "Potion", smethod_240(Class55.smethod_0(dataGridView4)));
		dataGridView4.ClearSelection();
		dataGridView4.Rows[0].Cells[0].Selected = true;
		dataGridView4.Rows[0].Cells[1].Selected = true;
		dataGridView4.Rows[0].Cells[2].Selected = true;
		num += smethod_244("sell/sel_dedupes_row", "Sword", smethod_240(Class55.smethod_0(dataGridView4)));
		dataGridView4.ClearSelection();
		dataGridView4.Rows[2].Cells[1].Selected = true;
		dataGridView4.Rows[0].Cells[1].Selected = true;
		num += smethod_244("sell/sel_order", "Sword,Shield", smethod_240(Class55.smethod_0(dataGridView4)));
		DataGridView dataGridView5 = smethod_237(new string[2] { "Potion", "Potion" });
		dataGridView5.ClearSelection();
		dataGridView5.Rows[0].Cells[1].Selected = true;
		dataGridView5.Rows[1].Cells[1].Selected = true;
		num += smethod_244("sell/sel_dedupes_name", "Potion", smethod_240(Class55.smethod_0(dataGridView5)));
		DataGridView dataGridView6 = smethod_237(new string[2] { "Sword", "Potion" });
		dataGridView6.CurrentCell = dataGridView6.Rows[1].Cells[1];
		dataGridView6.ClearSelection();
		num += smethod_244("sell/sel_current_cell_fallback", "Potion", smethod_240(Class55.smethod_0(dataGridView6)));
		DataGridView dataGridView7 = smethod_237(Array.Empty<string>());
		smethod_238(dataGridView7, "bag offsets not loaded");
		dataGridView7.ClearSelection();
		dataGridView7.Rows[0].Cells[1].Selected = true;
		num += smethod_244("sell/sel_skips_fault_row", 0, Class55.smethod_0(dataGridView7).Count);
		DataGridView dataGridView8 = smethod_237(new string[2] { "Apple", "Banana" });
		DataGridView dataGridView9 = smethod_235(new string[1] { "Apple" });
		num += smethod_244("sell/paint_marks_listed", 1, Class96.smethod_4(dataGridView8, dataGridView9));
		num += smethod_243("sell/paint_marks_listed_row0", smethod_241(dataGridView8, 0));
		num += smethod_243("sell/paint_marks_listed_row1", smethod_242(dataGridView8, 1));
		dataGridView8.Rows[0].Cells[1].Value = "Banana";
		dataGridView8.Rows[1].Cells[1].Value = "Cherry";
		num += smethod_244("sell/paint_smear", 0, Class96.smethod_4(dataGridView8, dataGridView9));
		num += smethod_243("sell/paint_smear_row0", smethod_242(dataGridView8, 0));
		dataGridView8.Rows[0].Cells[1].Value = "Apple";
		Class96.smethod_4(dataGridView8, dataGridView9);
		num += smethod_243("sell/paint_never_reads_back_marked", smethod_241(dataGridView8, 0));
		dataGridView9.Rows.Clear();
		num += smethod_244("sell/paint_never_reads_back", 0, Class96.smethod_4(dataGridView8, dataGridView9));
		num += smethod_243("sell/paint_never_reads_back_row0", smethod_242(dataGridView8, 0));
		DataGridView dataGridView_9 = smethod_237(new string[1] { "Apple" });
		Class96.smethod_4(dataGridView_9, smethod_235(new string[1] { "Apple" }));
		num += smethod_244("sell/paint_empty_reset", 0, Class96.smethod_4(dataGridView_9, null));
		num += smethod_243("sell/paint_empty_reset_row0", smethod_242(dataGridView_9, 0));
		DataGridView dataGridView_10 = smethod_237(Array.Empty<string>());
		smethod_238(dataGridView_10, "bag offsets not loaded");
		num += smethod_244("sell/paint_skips_fault_row", 0, Class96.smethod_4(dataGridView_10, smethod_235(new string[1] { "bag offsets not loaded" })));
		num += smethod_243("sell/paint_skips_fault_row_row0", smethod_242(dataGridView_10, 0));
		Class281 class4 = new Class281();
		class4.int_0 = 0;
		EventHandler value = class4.method_0;
		Button button = new Button();
		for (int i = 0; i < 2; i++)
		{
			button.Click -= value;
			button.Click += value;
		}
		button.PerformClick();
		num += smethod_244("sell/wire_once", 1, class4.int_0);
		num += smethod_244("bagwin/dimensions_cols", 6, 6);
		num += smethod_244("bagwin/dimensions_rows", 10, 10);
		num += smethod_244("bagwin/dimensions_cells", 60, 60);
		num += smethod_244("bagwin/geometry_left_first", 3, Class432.smethod_0(0));
		num += smethod_244("bagwin/geometry_left_last_in_row", 488, Class432.smethod_0(5));
		num += smethod_244("bagwin/geometry_left_wraps", 3, Class432.smethod_0(6));
		num += smethod_244("bagwin/geometry_top_first", 3, Class432.smethod_1(0));
		num += smethod_244("bagwin/geometry_top_second_row", 59, Class432.smethod_1(6));
		num += smethod_244("bagwin/geometry_top_last_row", 507, Class432.smethod_1(54));
		num += smethod_244("bagwin/geometry_client_width", 584, 584);
		num += smethod_244("bagwin/geometry_client_height", 582, 582);
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		dictionary["11:1"] = "Recovery Potion";
		dictionary["61:1"] = "Copper Tin Ring";
		Class95 class95_ = new Class95(null, dictionary, null);
		Class145 class145_ = Class145.class145_0.method_97(smethod_233(), null, class95_, 7, 24);
		string[] array = new string[60];
		string[] array2 = new string[60];
		num += smethod_244("bagwin/sparse_index_filled", 3, Class432.smethod_5(class145_, array, array2));
		num += smethod_244("bagwin/sparse_index_cell0", "Recovery Potion", array[0]);
		num += smethod_244("bagwin/sparse_index_cell7", "Copper Tin Ring", array[7]);
		num += smethod_244("bagwin/sparse_index_gap1", string.Empty, array[1]);
		num += smethod_244("bagwin/sparse_index_gap2", string.Empty, array[2]);
		num += smethod_244("bagwin/sparse_index_gap4", string.Empty, array[4]);
		num += smethod_244("bagwin/name_through_book", "Item 9:9", array[3]);
		num += smethod_244("bagwin/qty", "42", array2[3]);
		num += smethod_244("bagwin/qty_empty_cell", string.Empty, array2[1]);
		num += smethod_244("bagwin/status_text", "3 / 24", Class432.smethod_6(class145_));
		List<Struct27> list = new List<Struct27>();
		list.Add(new Struct27
		{
			int_0 = -1,
			ushort_0 = 11,
			ushort_1 = 1,
			int_2 = 1
		});
		list.Add(new Struct27
		{
			int_0 = 60,
			ushort_0 = 11,
			ushort_1 = 1,
			int_2 = 1
		});
		list.Add(new Struct27
		{
			int_0 = 5,
			ushort_0 = 61,
			ushort_1 = 1,
			int_2 = 9
		});
		Class145 class145_2 = Class145.class145_0.method_97(list, null, Class95.class95_0, 7, 60);
		string[] array3 = new string[60];
		string[] string_2 = new string[60];
		num += smethod_244("bagwin/slot_out_of_range", 1, Class432.smethod_5(class145_2, array3, string_2));
		num += smethod_244("bagwin/slot_out_of_range_keeps_the_good_row", "Item 61:1", array3[5]);
		num += smethod_244("bagwin/slot_out_of_range_no_clamp_low", string.Empty, array3[0]);
		num += smethod_244("bagwin/slot_out_of_range_no_clamp_high", string.Empty, array3[59]);
		num += smethod_243("bagwin/locked_known_cap_inside", !Class432.smethod_2(23, 24));
		num += smethod_243("bagwin/locked_known_cap_boundary", Class432.smethod_2(24, 24));
		num += smethod_243("bagwin/locked_known_cap_last", Class432.smethod_2(59, 24));
		num += smethod_243("bagwin/locked_full_cap_last", !Class432.smethod_2(59, 60));
		num += smethod_243("bagwin/locked_unknown_cap_first", !Class432.smethod_2(0, 0));
		num += smethod_243("bagwin/locked_unknown_cap_last", !Class432.smethod_2(59, 0));
		num += smethod_243("bagwin/locked_negative_cap", !Class432.smethod_2(59, -6));
		num += smethod_243("bagwin/back_free", Class432.smethod_4(bool_0: false, bool_1: false, bool_2: false) == Class432.color_0);
		num += smethod_243("bagwin/back_marked", Class432.smethod_4(bool_0: true, bool_1: false, bool_2: false) == Class432.color_1);
		num += smethod_243("bagwin/back_locked", Class432.smethod_4(bool_0: false, bool_1: true, bool_2: false) == Class432.color_2);
		num += smethod_243("bagwin/back_locked_wins", Class432.smethod_4(bool_0: true, bool_1: true, bool_2: false) == Class432.color_2);
		num += smethod_243("bagwin/back_shares_the_grid_mark", Class432.color_1 == Class96.color_0);
		int num3 = Class432.color_0.ToArgb();
		int num4 = Class432.color_1.ToArgb();
		int gparam_ = Class432.color_2.ToArgb();
		int num5 = Class432.color_3.ToArgb();
		int num6 = Class432.smethod_4(bool_0: false, bool_1: false, bool_2: true).ToArgb();
		int num7 = Class432.smethod_4(bool_0: true, bool_1: false, bool_2: true).ToArgb();
		num += smethod_244("bagwin/sel_free_unselected", num3, Class432.smethod_4(bool_0: false, bool_1: false, bool_2: false).ToArgb());
		num += smethod_244("bagwin/sel_mark_unselected", num4, Class432.smethod_4(bool_0: true, bool_1: false, bool_2: false).ToArgb());
		num += smethod_244("bagwin/sel_locked_unselected", gparam_, Class432.smethod_4(bool_0: false, bool_1: true, bool_2: false).ToArgb());
		num += smethod_244("bagwin/sel_locked_listed_unselected", gparam_, Class432.smethod_4(bool_0: true, bool_1: true, bool_2: false).ToArgb());
		num += smethod_244("bagwin/sel_locked_ignores_selection", gparam_, Class432.smethod_4(bool_0: false, bool_1: true, bool_2: true).ToArgb());
		num += smethod_244("bagwin/sel_locked_listed_ignores_selection", gparam_, Class432.smethod_4(bool_0: true, bool_1: true, bool_2: true).ToArgb());
		num += smethod_243("bagwin/sel_free_changes", num6 != num3);
		num += smethod_243("bagwin/sel_mark_changes", num7 != num4);
		num += smethod_243("bagwin/sel_free_is_not_the_raw_tint", num6 != num5);
		num += smethod_243("bagwin/sel_mark_is_not_the_raw_tint", num7 != num5);
		num += smethod_243("bagwin/sel_mark_still_reads_as_listed", num7 != num6);
		num += smethod_244("bagwin/sel_alpha", 96, 96);
		num += smethod_244("bagwin/sel_free_exact", Color.FromArgb(255, 240, 159).ToArgb(), num6);
		num += smethod_244("bagwin/sel_mark_exact", Color.FromArgb(186, 229, 90).ToArgb(), num7);
		num += smethod_244("bagwin/blend_zero_keeps_under", Color.White.ToArgb(), Class432.smethod_3(Color.White, Color.Gold, 0).ToArgb());
		num += smethod_244("bagwin/blend_full_takes_over", Color.Gold.ToArgb(), Class432.smethod_3(Color.White, Color.Gold, 255).ToArgb());
		num += smethod_244("bagwin/blend_negative_keeps_under", Color.White.ToArgb(), Class432.smethod_3(Color.White, Color.Gold, -8).ToArgb());
		num += smethod_244("bagwin/blend_rounds_not_truncates", 240, Class432.smethod_3(Class432.color_0, Class432.color_3, 96).G);
		num += smethod_244("bagwin/blend_rounds_a_half_step_up", 1, Class432.smethod_3(Color.FromArgb(1, 1, 1), Color.Black, 1).R);
		num += smethod_244("bagwin/blend_is_opaque", 255, Class432.smethod_3(Color.White, Color.Gold, 96).A);
		Class145 class145_3 = Class145.class145_0.method_99("bag offsets not loaded");
		string[] array4 = new string[60];
		string[] array5 = new string[60];
		num += smethod_244("bagwin/fault_clears_cells", 0, Class432.smethod_5(class145_3, array4, array5));
		num += smethod_244("bagwin/fault_clears_cells_first", string.Empty, array4[0]);
		num += smethod_244("bagwin/fault_clears_cells_last", string.Empty, array4[59]);
		num += smethod_243("bagwin/fault_never_becomes_a_cell", !smethod_234(array4, "bag offsets not loaded") && !smethod_234(array5, "bag offsets not loaded"));
		num += smethod_244("bagwin/fault_status_says_why", "bag offsets not loaded", Class432.smethod_6(class145_3));
		Class145 class145_4 = Class145.class145_0.method_97(smethod_233(), null, Class95.class95_0, 7, 0);
		num += smethod_244("bagwin/status_text_unknown_cap", "3 / ?", Class432.smethod_6(class145_4));
		num += smethod_244("bagwin/status_text_no_snapshot", "0 / ?", Class432.smethod_6(null));
		num += smethod_244("bagwin/fill_null_arrays", 0, Class432.smethod_5(Class145.class145_0, null, null));
		num += smethod_244("bagwin/fill_short_arrays", 0, Class432.smethod_5(Class145.class145_0, new string[59], new string[60]));
		num += smethod_244("bagwin/fill_no_snapshot", 0, Class432.smethod_5(null, new string[60], new string[60]));
		Console.WriteLine("sell: " + num + " failed");
		return num;
	}

	private static List<Struct27> smethod_233()
	{
		return new List<Struct27>
		{
			new Struct27
			{
				int_0 = 0,
				ushort_0 = 11,
				ushort_1 = 1,
				int_2 = 1
			},
			new Struct27
			{
				int_0 = 3,
				ushort_0 = 9,
				ushort_1 = 9,
				int_2 = 42
			},
			new Struct27
			{
				int_0 = 7,
				ushort_0 = 61,
				ushort_1 = 1,
				int_2 = 2
			}
		};
	}

	private static bool smethod_234(string[] string_0, string string_1)
	{
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (string_0[num] == string_1)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static DataGridView smethod_235(string[] string_0)
	{
		return smethod_114(string_0);
	}

	private static DataGridView smethod_236(string[] string_0)
	{
		DataGridView dataGridView = new DataGridView();
		dataGridView.Columns.Add("col0", "item");
		for (int i = 0; i < string_0.Length; i++)
		{
			dataGridView.Rows.Add(string_0[i]);
		}
		return dataGridView;
	}

	private static DataGridView smethod_237(string[] string_0)
	{
		DataGridView dataGridView = new DataGridView();
		dataGridView.AllowUserToAddRows = false;
		dataGridView.Columns.Add("slot", "slot no.");
		dataGridView.Columns.Add("name", "item");
		dataGridView.Columns.Add("amount", "amount");
		for (int i = 0; i < string_0.Length; i++)
		{
			dataGridView.Rows.Add(i.ToString(), string_0[i], "1");
		}
		return dataGridView;
	}

	private static void smethod_238(DataGridView dataGridView_0, string string_0)
	{
		dataGridView_0.Rows.Add(string.Empty, string_0, string.Empty);
	}

	private static List<string> smethod_239(string[] string_0)
	{
		return new List<string>(string_0);
	}

	private static string smethod_240(List<string> list_0)
	{
		return string.Join(",", list_0.ToArray());
	}

	private static bool smethod_241(DataGridView dataGridView_0, int int_0)
	{
		return dataGridView_0.Rows[int_0].DefaultCellStyle.BackColor == Class96.color_0;
	}

	private static bool smethod_242(DataGridView dataGridView_0, int int_0)
	{
		return dataGridView_0.Rows[int_0].DefaultCellStyle.BackColor == Color.Empty;
	}

	private static int smethod_243(string string_0, bool bool_0)
	{
		if (bool_0)
		{
			return 0;
		}
		Console.WriteLine("FAIL  " + string_0);
		return 1;
	}

	private static int smethod_244<T>(string string_0, T gparam_0, T gparam_1)
	{
		if (EqualityComparer<T>.Default.Equals(gparam_0, gparam_1))
		{
			return 0;
		}
		string[] obj = new string[6] { "FAIL  ", string_0, "  expected=", null, null, null };
		T val = gparam_0;
		obj[3] = val?.ToString();
		obj[4] = "  actual=";
		val = gparam_1;
		obj[5] = val?.ToString();
		Console.WriteLine(string.Concat(obj));
		return 1;
	}

	internal static int smethod_245()
	{
		int num = 0;
		JObject jObject = JObject.Parse(Class428.smethod_6(60));
		num = 0 + smethod_244<string>("radar/renderer", "radar", (string?)jObject["renderer"]);
		num += smethod_244<string>("radar/player-only", "player", (string?)jObject["id"]);
		num += smethod_244("radar/green-r", 0.2f, (float)jObject["r"]);
		num += smethod_244("radar/green-g", 1f, (float)jObject["g"]);
		num += smethod_244("radar/green-b", 0.3f, (float)jObject["b"]);
		num += smethod_244("radar/opacity", 0.25f, (float)jObject["a"]);
		num += smethod_243("radar/following", jObject["x"] == null);
		JObject jObject2 = JObject.Parse(Class428.smethod_7(75, 11f, 22f, 33f));
		num += smethod_244("radar/fixed-x", 11f, (float)jObject2["x"]);
		num += smethod_244("radar/fixed-y", 22f, (float)jObject2["y"]);
		num += smethod_244("radar/fixed-z", 33f, (float)jObject2["z"]);
		num += smethod_244<string>("radar/resize-selector", "radar", (string?)JObject.Parse(Class428.smethod_8(90))["renderer"]);
		num += smethod_244<string>("radar/hide-selector", "radar", (string?)JObject.Parse(Class428.smethod_9())["renderer"]);
		num += smethod_244("radar/legacy-marker", "{\"cmd\":\"zone\",\"id\":\"marker\",\"on\":true,\"radius\":2,\"r\":1,\"g\":0,\"b\":0,\"a\":0.15,\"x\":1,\"y\":2,\"z\":3}", Class428.smethod_1("marker", 2f, 1f, 0f, 0f, 0.15f, 1f, 2f, 3f));
		num += smethod_243("radar/legacy-line", JObject.Parse(Class428.smethod_2("route", 1f, 1f, 0f, 0f, 0.15f, 1f, 2f, 3f, 4f, 5f, 6f))["renderer"] == null);
		num += smethod_243("radar/legacy-follow-marker", JObject.Parse(Class428.smethod_0("hero", 2f, 1f, 0f, 0f, 0.15f))["renderer"] == null);
		List<string> list = new List<string>();
		Class119 @class = new Class119();
		try
		{
			@class.method_30(list.Add);
			@class.method_108("player", 60);
			@class.method_109("player", 75, 11f, 22f, 33f);
			@class.method_113("player", 90);
			@class.method_114("player");
			@class.method_108("other", 12);
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		num += smethod_244("radar/classic-player-command-count", 5, list.Count);
		JObject jObject3 = JObject.Parse(list[0]);
		num += smethod_244<string>("radar/classic-follow-id", "player", (string?)jObject3["id"]);
		num += smethod_244("radar/classic-follow-r", 1f, (float)jObject3["r"]);
		num += smethod_244("radar/classic-follow-g", 0f, (float)jObject3["g"]);
		num += smethod_244("radar/classic-follow-b", 0f, (float)jObject3["b"]);
		num += smethod_244("radar/classic-follow-alpha", 0.15f, (float)jObject3["a"]);
		num += smethod_243("radar/classic-follow-no-renderer", jObject3["renderer"] == null);
		num += smethod_243("radar/classic-follow-no-fixed-center", jObject3["x"] == null);
		JObject jObject4 = JObject.Parse(list[1]);
		num += smethod_244("radar/classic-pinned-x", 11f, (float)jObject4["x"]);
		num += smethod_244("radar/classic-pinned-y", 22f, (float)jObject4["y"]);
		num += smethod_244("radar/classic-pinned-z", 33f, (float)jObject4["z"]);
		num += smethod_243("radar/classic-pinned-no-renderer", jObject4["renderer"] == null);
		JObject jObject5 = JObject.Parse(list[2]);
		num += smethod_244("radar/classic-resize-radius", 90, (int)jObject5["radius"]);
		num += smethod_243("radar/classic-resize-no-renderer", jObject5["renderer"] == null);
		JObject jObject6 = JObject.Parse(list[3]);
		num += smethod_243("radar/classic-hide-off", !(bool)jObject6["on"]);
		num += smethod_243("radar/classic-hide-no-renderer", jObject6["renderer"] == null);
		num += smethod_244("radar/nonplayer-routing-unchanged", "{\"cmd\":\"zone\",\"id\":\"other\",\"on\":true,\"radius\":12,\"r\":1,\"g\":0,\"b\":0,\"a\":0.15}", list[4]);
		num += smethod_243("radar/readiness-group-missing", !Class119.smethod_4(bool_17: false, "{\"radarReady\":true}"));
		num += smethod_243("radar/readiness-ack-missing", !Class119.smethod_4(bool_17: true, "{}"));
		num += smethod_243("radar/readiness-ack-ready", Class119.smethod_4(bool_17: true, "{\"radarReady\":true}"));
		num += smethod_243("radar/readiness-ack-invalid", !Class119.smethod_4(bool_17: true, "invalid"));
		List<(string, string)> list2 = new List<(string, string)>(Class357.valueTuple_0);
		HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
		(string, string)[] valueTuple_ = Class357.valueTuple_0;
		for (int i = 0; i < valueTuple_.Length; i++)
		{
			(string, string) tuple = valueTuple_[i];
			hashSet.Add(tuple.Item1);
		}
		valueTuple_ = Class357.valueTuple_4;
		for (int i = 0; i < valueTuple_.Length; i++)
		{
			(string, string) item = valueTuple_[i];
			if (hashSet.Add(item.Item1))
			{
				list2.Add(item);
			}
		}
		num += smethod_243("radar/offsets-complete-apply", Class357.smethod_15(smethod_230(list2.ToArray()), out var string_));
		num += smethod_243("radar/offsets-complete-zone-available", Class357.smethod_22());
		num += smethod_243("radar/offsets-complete-available", Class357.smethod_30());
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("radar/offsets-complete-vector-array", text.Contains("\"tiRadarVector3Array\":"));
		num += smethod_243("radar/offsets-complete-color-array", text.Contains("\"tiRadarColorArray\":"));
		num += smethod_243("radar/offsets-complete-int-array", text.Contains("\"tiRadarIntArray\":"));
		num += smethod_243("radar/offsets-complete-mesh-setter", text.Contains("\"rvaMeshSetVertices\":"));
		num += smethod_243("radar/offsets-complete-frame-latch", text.Contains("\"rvaZoomLateUpdate\":"));
		num += smethod_243("radar/offsets-complete-cached-pointer", text.Contains("\"objCachedPtr\":"));
		List<(string, string)> list3 = new List<(string, string)>(Class357.valueTuple_0);
		HashSet<string> hashSet2 = new HashSet<string>(StringComparer.Ordinal);
		valueTuple_ = Class357.valueTuple_0;
		for (int i = 0; i < valueTuple_.Length; i++)
		{
			(string, string) tuple2 = valueTuple_[i];
			hashSet2.Add(tuple2.Item1);
		}
		valueTuple_ = Class357.valueTuple_4;
		for (int i = 0; i < valueTuple_.Length; i++)
		{
			(string, string) item2 = valueTuple_[i];
			if (item2.Item2 != "rvaZoomLateUpdate" && hashSet2.Add(item2.Item1))
			{
				list3.Add(item2);
			}
		}
		num += smethod_243("radar/offsets-missing-shared-apply", Class357.smethod_15(smethod_230(list3.ToArray()), out string_));
		num += smethod_243("radar/offsets-missing-shared-unavailable", !Class357.smethod_30());
		num += smethod_243("radar/offsets-missing-shared-zone-stays-available", Class357.smethod_22());
		text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243("radar/offsets-missing-shared-sends-no-radar", !text.Contains("\"tiRadarVector3Array\":") && !text.Contains("\"tiRadarColorArray\":"));
		num += smethod_243("radar/offsets-without-zone-apply", Class357.smethod_15(smethod_230(Class357.valueTuple_4), out string_));
		num += smethod_243("radar/offsets-without-zone-unavailable", !Class357.smethod_30());
		num += smethod_243("radar/cold-readiness-fixture", Class357.smethod_15(smethod_230(list2.ToArray()), out string_));
		Class119 class2 = new Class119();
		try
		{
			class2.method_44(1L);
			num += smethod_243("radar/cold-initially-unarmed", !class2.method_97());
			smethod_250(class2, "{\"t\":\"radar_readiness\",\"ready\":true,\"reason\":\"\"}", 1L);
			num += smethod_243("radar/cold-delayed-ready-arms", class2.method_97());
			class2.method_100("{\"radarReady\":false}", 1L);
			num += smethod_243("radar/old-initial-ack-cannot-overwrite-event", class2.method_97());
			smethod_250(class2, "{\"t\":\"radar_readiness\",\"ready\":\"true\"}", 1L);
			num += smethod_243("radar/invalid-readiness-is-ignored", class2.method_97());
			class2.method_44(2L);
			smethod_250(class2, "{\"t\":\"radar_readiness\",\"ready\":false}", 1L);
			num += smethod_243("radar/old-generation-cannot-disarm", class2.method_97());
			smethod_250(class2, "{\"t\":\"radar_readiness\",\"ready\":false,\"reason\":\"waiting for arrays\"}", 2L);
			num += smethod_243("radar/current-generation-can-disarm", !class2.method_97());
			class2.method_100("{\"radarReady\":true}", 1L);
			num += smethod_243("radar/old-generation-ack-is-ignored", !class2.method_97());
			smethod_250(class2, "{\"t\":\"radar_readiness\",\"ready\":true}", 2L);
			class2.method_210();
			num += smethod_243("radar/close-clears-delayed-ready", !class2.method_97());
		}
		finally
		{
			((IDisposable)class2).Dispose();
		}
		Class241 class3 = new Class241();
		class3.class119_0 = new Class119();
		try
		{
			class3.class119_0.method_44(1L);
			class3.class119_0.method_2(class3.method_0);
			class3.class119_0.method_204(1, new IntPtr(1));
			num += smethod_243("radar/old-detach-cleanup-cannot-clear-new-ready", class3.class119_0.method_97());
		}
		finally
		{
			if (class3.class119_0 != null)
			{
				((IDisposable)class3.class119_0).Dispose();
			}
		}
		Console.WriteLine((num == 0) ? "PASS radar command, offsets and cold readiness" : ("FAIL radar: " + num));
		return num;
	}

	internal static int smethod_246()
	{
		int num = 0;
		List<(string, string)> list = new List<(string, string)>(Class357.valueTuple_0);
		HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
		foreach (var item2 in list)
		{
			hashSet.Add(item2.Item1);
		}
		(string, string)[] valueTuple_ = Class357.valueTuple_4;
		for (int i = 0; i < valueTuple_.Length; i++)
		{
			(string, string) item = valueTuple_[i];
			if (hashSet.Add(item.Item1))
			{
				list.Add(item);
			}
		}
		num += smethod_243("zone-mode/offset-fixture", Class357.smethod_15(smethod_230(list.ToArray()), out var _));
		string text = smethod_173("Capybara-UI-Winform\\Ui\\Bot\\BotTimer.cs", ref num);
		if (text != null)
		{
			string string_2 = text.Replace("\r\n", "\n");
			num += smethod_243("zone-mode/normal-and-catch-stop-call-zone-reconciliation", smethod_160(string_2, "start_request = false;\n                RunStopCleanup(\"ApplyZone\", ApplyZone);") == 2);
		}
		List<string> list2 = new List<string>();
		Class119 @class = new Class119();
		try
		{
			GForm0 gForm = new GForm0();
			try
			{
				@class.method_30(list2.Add);
				@class.method_44(1L);
				RadioButton radioButton = (RadioButton)gForm.Controls.Find("radioButton6", searchAllChildren: true)[0];
				RadioButton radioButton2 = (RadioButton)gForm.Controls.Find("radioButton7", searchAllChildren: true)[0];
				CheckBox checkBox = (CheckBox)gForm.Controls.Find("checkBox1", searchAllChildren: true)[0];
				num += smethod_243("zone-mode/default-classic", radioButton.Checked && !radioButton2.Checked);
				num += smethod_243("zone-mode/exclusive-borderless-panel", radioButton.Parent is Panel && radioButton.Parent == radioButton2.Parent && radioButton.Parent.Controls.Count == 2 && ((Panel)radioButton.Parent).BorderStyle == BorderStyle.None);
				RadioButton radioButton3 = new RadioButton
				{
					Checked = true
				};
				radioButton.Parent.Parent.Controls.Add(radioButton3);
				radioButton2.Checked = true;
				num += smethod_243("zone-mode/only-two-radios-exclusive", !radioButton.Checked && radioButton2.Checked && radioButton3.Checked);
				radioButton.Checked = true;
				num += smethod_243("zone-mode/reverse-exclusivity", radioButton.Checked && !radioButton2.Checked && radioButton3.Checked);
				typeof(GForm0).GetField("_session", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, @class);
				gForm.bool_2 = true;
				checkBox.Checked = true;
				num += smethod_243("zone-mode/classic-shown", list2.Count == 1 && JObject.Parse(list2[0])["renderer"] == null && (bool)JObject.Parse(list2[0])["on"]);
				radioButton2.Checked = true;
				num += smethod_243("zone-mode/hide-old-before-prepare", list2.Count == 3 && !(bool)JObject.Parse(list2[1])["on"] && JObject.Parse(list2[1])["renderer"] == null && (string?)JObject.Parse(list2[2])["cmd"] == "radar_mode" && (bool)JObject.Parse(list2[2])["on"]);
				smethod_250(@class, "{\"t\":\"radar_readiness\",\"ready\":true}", 1L);
				(typeof(GForm0).GetMethod("method_118", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)).Invoke(gForm, null);
				num += smethod_243("zone-mode/ready-modern-shown", list2.Count == 4 && (string?)JObject.Parse(list2[3])["renderer"] == "radar" && (bool)JObject.Parse(list2[3])["on"]);
				radioButton.Checked = true;
				num += smethod_243("zone-mode/modern-to-classic", list2.Count == 7 && (string?)JObject.Parse(list2[4])["renderer"] == "radar" && !(bool)JObject.Parse(list2[4])["on"] && (string?)JObject.Parse(list2[5])["cmd"] == "radar_mode" && !(bool)JObject.Parse(list2[5])["on"] && JObject.Parse(list2[6])["renderer"] == null && (bool)JObject.Parse(list2[6])["on"]);
				checkBox.Checked = false;
				num += smethod_243("zone-mode/show-off-hides-selected", list2.Count == 8 && !(bool)JObject.Parse(list2[7])["on"]);
				int count = list2.Count;
				radioButton2.Checked = true;
				num += smethod_243("zone-mode/hidden-selection-does-not-arm", list2.Count == count);
				checkBox.Checked = true;
				num += smethod_243("zone-mode/re-enable-prepares-modern", (string?)JObject.Parse(list2[list2.Count - 1])["cmd"] == "radar_mode" && (bool)JObject.Parse(list2[list2.Count - 1])["on"]);
				smethod_250(@class, "{\"t\":\"radar_readiness\",\"ready\":true}", 1L);
				MethodInfo obj = typeof(GForm0).GetMethod("method_118", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				obj.Invoke(gForm, null);
				int count2 = list2.Count;
				(typeof(Class119).GetMethod("method_99", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)).Invoke(@class, null);
				obj.Invoke(gForm, null);
				num += smethod_243("zone-mode/same-session-offset-reset-reprepares", list2.Count == count2 + 1 && (string?)JObject.Parse(list2[list2.Count - 1])["cmd"] == "radar_mode" && (bool)JObject.Parse(list2[list2.Count - 1])["on"]);
				smethod_250(@class, "{\"t\":\"radar_readiness\",\"ready\":true}", 1L);
				obj.Invoke(gForm, null);
				int count3 = list2.Count;
				checkBox.Checked = false;
				num += smethod_243("zone-mode/show-off-releases-modern", list2.Count == count3 + 2 && (string?)JObject.Parse(list2[list2.Count - 1])["cmd"] == "radar_mode" && !(bool)JObject.Parse(list2[list2.Count - 1])["on"]);
				checkBox.Checked = true;
				num += smethod_243("zone-mode/show-on-rearms-modern", list2.Count == count3 + 3 && (string?)JObject.Parse(list2[list2.Count - 1])["cmd"] == "radar_mode" && (bool)JObject.Parse(list2[list2.Count - 1])["on"]);
				smethod_250(@class, "{\"t\":\"radar_readiness\",\"ready\":true}", 1L);
				obj.Invoke(gForm, null);
				int count4 = list2.Count;
				gForm.bool_2 = false;
				obj.Invoke(gForm, null);
				num += smethod_243("zone-mode/stopped-state-releases-modern", list2.Count == count4 + 2 && (string?)JObject.Parse(list2[list2.Count - 1])["cmd"] == "radar_mode" && !(bool)JObject.Parse(list2[list2.Count - 1])["on"]);
				gForm.bool_2 = true;
				obj.Invoke(gForm, null);
				num += smethod_243("zone-mode/immediate-start-reprepares", list2.Count == count4 + 3 && (string?)JObject.Parse(list2[list2.Count - 1])["cmd"] == "radar_mode" && (bool)JObject.Parse(list2[list2.Count - 1])["on"]);
				long num2 = @class.method_98();
				@class.method_204(1, new IntPtr(1));
				num += smethod_243("zone-mode/detach-invalidates-preparation-epoch", @class.method_98() > num2);
				@class.method_44(2L);
				int count5 = list2.Count;
				obj.Invoke(gForm, null);
				num += smethod_243("zone-mode/same-object-reconnect-reprepares", list2.Count == count5 + 1 && (string?)JObject.Parse(list2[list2.Count - 1])["cmd"] == "radar_mode" && (bool)JObject.Parse(list2[list2.Count - 1])["on"]);
				gForm.bool_2 = false;
			}
			finally
			{
				((IDisposable)gForm).Dispose();
			}
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		using (Class119 class2 = new Class119())
		{
			list2.Clear();
			class2.method_30(list2.Add);
			class2.method_105(75, 11f, 22f, 33f, bool_17: true);
			class2.method_106(90, bool_17: true);
			class2.method_107(bool_17: true);
			class2.method_110("waypoint", 2f, 1f, 0f, 0f, 0.15f, 11f, 22f, 33f);
			num += smethod_243("zone-mode/pinned-modern-coordinate-routing", (float)JObject.Parse(list2[0])["x"] == 11f && (float)JObject.Parse(list2[0])["y"] == 22f && (float)JObject.Parse(list2[0])["z"] == 33f && (string?)JObject.Parse(list2[0])["renderer"] == "radar");
			num += smethod_243("zone-mode/modern-resize-routing", (int)JObject.Parse(list2[1])["radius"] == 90 && (string?)JObject.Parse(list2[1])["renderer"] == "radar");
			num += smethod_243("zone-mode/modern-hide-routing", !(bool)JObject.Parse(list2[2])["on"] && (string?)JObject.Parse(list2[2])["renderer"] == "radar");
			num += smethod_243("zone-mode/marker-unchanged", JObject.Parse(list2[3])["renderer"] == null);
		}
		Console.WriteLine((num == 0) ? "PASS Classic/Modern exclusive selector and zone handoff" : ("FAIL zone-mode: " + num));
		return num;
	}

	internal static int smethod_247()
	{
		int num = 0;
		num = 0 + smethod_243("fog/complete-apply", Class357.smethod_15(smethod_230(Class357.valueTuple_2), out var string_));
		num += smethod_243("fog/available-without-camera", Class357.smethod_26() && !Class357.smethod_28());
		JObject jObject = JObject.Parse(Class431.smethod_0());
		string[] array = new string[5] { "rvaFogSettings", "rvaFogGet", "rvaFogSet", "rvaZoomLateUpdate", "objCachedPtr" };
		foreach (string text in array)
		{
			num += smethod_243("fog/payload-" + text, jObject["off"][text] != null);
		}
		(string, string)[] valueTuple_ = Class357.valueTuple_2;
		for (int i = 0; i < valueTuple_.Length; i++)
		{
			Class317 @class = new Class317();
			@class.valueTuple_0 = valueTuple_[i];
			List<(string, string)> list = new List<(string, string)>(Class357.valueTuple_3);
			HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
			foreach (var item2 in list)
			{
				hashSet.Add(item2.Item1);
			}
			(string, string)[] valueTuple_2 = Class357.valueTuple_2;
			for (int j = 0; j < valueTuple_2.Length; j++)
			{
				(string, string) item = valueTuple_2[j];
				if (item.Item1 != @class.valueTuple_0.Item1 && hashSet.Add(item.Item1))
				{
					list.Add(item);
				}
			}
			if (@class.valueTuple_0.Item2 == "rvaZoomLateUpdate")
			{
				list.RemoveAll(@class.method_0);
			}
			num += smethod_243("fog/partial-apply-" + @class.valueTuple_0.Item2, Class357.smethod_15(smethod_230(list.ToArray()), out string_));
			num += smethod_243("fog/partial-unavailable-" + @class.valueTuple_0.Item2, !Class357.smethod_26());
			if (@class.valueTuple_0.Item2 != "rvaZoomLateUpdate")
			{
				num += smethod_243("fog/partial-keeps-camera-" + @class.valueTuple_0.Item2, Class357.smethod_28());
			}
			jObject = JObject.Parse(Class431.smethod_0());
			num += smethod_243("fog/partial-omits-setter-" + @class.valueTuple_0.Item2, jObject["off"]["rvaFogSet"] == null);
		}
		num += smethod_243("fog/required-only-apply", Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out string_));
		num += smethod_243("fog/required-only-unavailable", !Class357.smethod_26());
		Console.WriteLine((num == 0) ? "PASS fog offset contract" : ("FAIL fog: " + num));
		return num;
	}

	internal static int smethod_248()
	{
		int num = 0;
		num = 0 + smethod_244("klassx-camera/slider-min", 0.6f, Class143.smethod_0(6));
		num += smethod_244("klassx-camera/slider-max", 11.6f, Class143.smethod_0(116));
		num += smethod_244("klassx-camera/slider-unclamped-below", 0.5f, Class143.smethod_0(5));
		num += smethod_244("klassx-camera/slider-unclamped-above", 11.7f, Class143.smethod_0(117));
		Struct137 struct137_ = default(Struct137);
		Struct1 struct1_ = default(Struct1);
		num += smethod_243("klassx-camera/status-request-after-select", Class143.smethod_2(struct1_, Enum0.Selected, bool_0: true));
		Class143.smethod_3(ref struct1_);
		num += smethod_243("klassx-camera/status-request-is-once-per-lifecycle", !Class143.smethod_2(struct1_, Enum0.Started, bool_0: true));
		Class143.smethod_4(ref struct1_, new Class400(bool_2: true, bool_3: true, string.Empty, 1f, 80f));
		num += smethod_243("klassx-camera/status-arms-write", struct1_.bool_1 && struct1_.bool_2 && struct1_.nullable_0.GetValueOrDefault() == 1f);
		Struct1 struct1_2 = struct1_;
		Class143.smethod_4(ref struct1_2, new Class400(bool_2: false, bool_3: false, "camera unavailable", null, null));
		num += smethod_243("klassx-camera/unavailable-status-clears-label-value", !struct1_2.bool_1 && !struct1_2.bool_2 && !struct1_2.nullable_0.HasValue);
		num += smethod_243("klassx-camera/default-does-not-send", !Class143.smethod_5(struct137_, struct1_, Enum0.Selected, bool_0: true).bool_0);
		Struct137 struct137_2 = default(Struct137);
		Class143.smethod_1(ref struct137_2, 10);
		num += smethod_243("klassx-camera/select-queues-current-default", struct137_2.bool_0 && struct137_2.float_0 == 1f && struct137_2.int_0 == 1);
		Struct1 struct1_3 = default(Struct1);
		num += smethod_243("klassx-camera/select-intent-waits-for-delayed-anchor", !Class143.smethod_5(struct137_2, struct1_3, Enum0.Selected, bool_0: false).bool_0);
		Struct17 struct17_ = Class143.smethod_5(struct137_2, struct1_3, Enum0.Selected, bool_0: true);
		num += smethod_243("klassx-camera/select-sends-current-default-once", struct17_.bool_0 && struct17_.float_0 == 1f);
		Class143.smethod_6(ref struct1_3, struct17_, 31u, 0L);
		num += smethod_243("klassx-camera/select-current-default-is-one-shot", !Class143.smethod_5(struct137_2, struct1_3, Enum0.Started, bool_0: true).bool_0);
		Class143.smethod_9(ref struct1_3, new Class101(bool_2: true, 31u, 1f, string.Empty));
		Class143.smethod_1(ref struct137_2, 37);
		Struct17 struct17_2 = Class143.smethod_5(struct137_2, struct1_3, Enum0.Selected, bool_0: true);
		num += smethod_243("klassx-camera/reselect-queues-persisted-track-revision", struct137_2.int_0 == 2 && struct17_2.bool_0 && struct17_2.float_0 == 3.7f);
		Class143.smethod_6(ref struct1_3, struct17_2, 32u, 0L);
		Class143.smethod_9(ref struct1_3, new Class101(bool_2: true, 32u, 3.7f, string.Empty));
		Class143.smethod_10(ref struct1_3, new Class101(bool_2: true, 0u, 3.8f, string.Empty, 304f));
		num += smethod_243("klassx-camera/reselect-does-not-replay-on-start-stop-or-pinch", !Class143.smethod_5(struct137_2, struct1_3, Enum0.Started, bool_0: true).bool_0 && !Class143.smethod_5(struct137_2, struct1_3, Enum0.Selected, bool_0: true).bool_0 && struct1_3.nullable_0.GetValueOrDefault() == 3.8f);
		Struct137 @struct = new Struct137
		{
			bool_0 = true,
			float_0 = 1.6f,
			int_0 = 1
		};
		num += smethod_243("klassx-camera/waits-for-select", !Class143.smethod_5(@struct, struct1_, Enum0.Attached, bool_0: true).bool_0);
		num += smethod_243("klassx-camera/waits-for-readiness", !Class143.smethod_5(@struct, struct1_, Enum0.Selected, bool_0: false).bool_0);
		Struct17 struct17_3 = Class143.smethod_5(@struct, struct1_, Enum0.Selected, bool_0: true);
		num += smethod_243("klassx-camera/user-change-sends-once", struct17_3.bool_0 && struct17_3.float_0 == 1.6f && struct17_3.int_0 == 1);
		Class143.smethod_6(ref struct1_, struct17_3, 41u, 0L);
		num += smethod_243("klassx-camera/pending-does-not-resend", !Class143.smethod_5(@struct, struct1_, Enum0.Started, bool_0: true).bool_0);
		Struct1 struct1_4 = default(Struct1);
		Class143.smethod_6(ref struct1_4, struct17_3, 51u, 100L);
		num += smethod_243("klassx-camera/pending-waits-before-timeout", !Class143.smethod_8(ref struct1_4, 2099L));
		num += smethod_243("klassx-camera/pending-timeout-does-not-retry", Class143.smethod_8(ref struct1_4, 2100L) && struct1_4.uint_0 == 0 && !Class143.smethod_5(@struct, struct1_4, Enum0.Started, bool_0: true).bool_0);
		Class101 class101_ = new Class101(bool_2: true, 40u, 2.1f, string.Empty);
		num += smethod_243("klassx-camera/stale-ack-ignored", !Class143.smethod_9(ref struct1_, class101_) && struct1_.uint_0 == 41);
		Struct137 struct137_3 = @struct;
		struct137_3.float_0 = 2.2f;
		struct137_3.int_0 = 2;
		Class143.smethod_7(ref struct1_);
		Struct17 struct17_4 = Class143.smethod_5(struct137_3, struct1_, Enum0.Started, bool_0: true);
		Class143.smethod_6(ref struct1_, struct17_4, 42u, 0L);
		num += smethod_243("klassx-camera/late-prior-ack-ignored", !Class143.smethod_9(ref struct1_, new Class101(bool_2: true, 41u, 1.6f, string.Empty)));
		num += smethod_243("klassx-camera/matching-ack-shows-actual", Class143.smethod_9(ref struct1_, new Class101(bool_2: true, 42u, 2.15f, string.Empty)) && struct1_.nullable_0.GetValueOrDefault() == 2.15f);
		Class101 class101_2 = new Class101(bool_2: true, 0u, 2.4f, string.Empty, 192f);
		num += smethod_243("klassx-camera/pinch-telemetry-updates-actual-without-writer", Class143.smethod_10(ref struct1_, class101_2) && Class143.smethod_11(struct1_.nullable_0) == "Zoom 2.4x" && !Class143.smethod_5(struct137_3, struct1_, Enum0.Started, bool_0: true).bool_0);
		num += smethod_244("klassx-camera/label-unavailable", "Zoom --", Class143.smethod_11(null));
		num += smethod_244("klassx-camera/label-actual", "Zoom 2.15x", Class143.smethod_11(2.15f));
		Class143.smethod_12(ref struct1_);
		num += smethod_243("klassx-camera/lifecycle-clears-stale-state", struct1_.uint_0 == 0 && !struct1_.nullable_0.HasValue);
		num += smethod_243("klassx-camera/reconnect-does-not-replay-consumed-intent", !Class143.smethod_5(struct137_3, struct1_, Enum0.Selected, bool_0: true).bool_0);
		Struct1 struct1_5 = default(Struct1);
		Class143.smethod_12(ref struct1_5);
		num += smethod_243("klassx-camera/preselect-input-survives-lifecycle-readiness", Class143.smethod_5(struct137_3, struct1_5, Enum0.Selected, bool_0: true).bool_0);
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		try
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("th-TH");
			num += smethod_244("klassx-camera/wire-invariant", "{\"cmd\":\"cam_zoom\",\"zoom\":2.2,\"req\":7}", Class178.smethod_2(2.2f, 7u));
			num += smethod_244("klassx-camera/status-wire", "{\"cmd\":\"cam_zoom_status\"}", Class178.smethod_3());
		}
		finally
		{
			CultureInfo.CurrentCulture = currentCulture;
		}
		num += smethod_243("klassx-camera/reply-finite", Class119.smethod_26(JObject.Parse("{\"t\":\"cam_zoom\",\"ok\":true,\"req\":7,\"zoom\":2.15,\"raw\":172.0,\"ready\":true}")) != null);
		Class101 @class = Class119.smethod_26(JObject.Parse("{\"t\":\"cam_zoom\",\"ok\":true,\"req\":0,\"zoom\":2.25,\"raw\":180.0,\"ready\":true}"));
		num += smethod_243("klassx-camera/telemetry-request-zero", @class != null && @class.uint_0 == 0 && @class.nullable_0.GetValueOrDefault() == 2.25f && @class.nullable_1.GetValueOrDefault() == 180f && @class.bool_1);
		Struct1 struct1_6 = default(Struct1);
		num += smethod_243("klassx-camera/telemetry-arms-anchor-without-command", Class143.smethod_10(ref struct1_6, @class) && struct1_6.bool_1 && struct1_6.bool_2 && struct1_6.nullable_0.GetValueOrDefault() == 2.25f);
		Class143.smethod_4(ref struct1_6, new Class400(bool_2: true, bool_3: true, string.Empty, null, null));
		num += smethod_243("klassx-camera/status-without-actual-preserves-telemetry", struct1_6.bool_1 && struct1_6.bool_2 && struct1_6.nullable_0.GetValueOrDefault() == 2.25f);
		Class143.smethod_4(ref struct1_6, new Class400(bool_2: false, bool_3: false, "camera unavailable", null, null));
		num += smethod_243("klassx-camera/unavailable-after-telemetry-clears-actual", !struct1_6.bool_1 && !struct1_6.bool_2 && !struct1_6.nullable_0.HasValue);
		num += smethod_243("klassx-camera/reply-rejects-nan-string", Class119.smethod_26(JObject.Parse("{\"t\":\"cam_zoom\",\"ok\":true,\"req\":7,\"zoom\":\"NaN\"}")) == null);
		num += smethod_243("klassx-camera/reply-rejects-missing-actual", Class119.smethod_26(JObject.Parse("{\"t\":\"cam_zoom\",\"ok\":true,\"req\":7}")) == null);
		Class400 class2 = Class119.smethod_27(JObject.Parse("{\"t\":\"cam_zoom_status\",\"ready\":true,\"anchored\":true,\"reason\":\"\",\"zoom\":1.0,\"raw\":80.0}"));
		num += smethod_243("klassx-camera/status-decodes-anchor", class2 != null && class2.bool_0 && class2.bool_1 && class2.nullable_0.GetValueOrDefault() == 1f && class2.nullable_1.GetValueOrDefault() == 80f);
		List<string> list = new List<string>();
		Class119 class3 = new Class119();
		try
		{
			class3.method_30(list.Add);
			num += smethod_243("klassx-camera/session-posts-request", class3.method_118(3.4f, out var uint_) && uint_ != 0 && list.Count == 1 && list[0] == Class178.smethod_2(3.4f, uint_));
			num += smethod_243("klassx-camera/session-rejects-nonfinite", !class3.method_118(float.NaN, out uint_) && list.Count == 1);
			num += smethod_243("klassx-camera/session-rejects-nonpositive", !class3.method_118(0f, out uint_) && !class3.method_118(-1f, out uint_) && list.Count == 1);
			class3.method_43(-1);
			num += smethod_243("klassx-camera/request-zero-is-skipped-on-wrap", class3.method_118(1f, out uint_) && uint_ == 1 && list.Count == 2 && list[1] == Class178.smethod_2(1f, uint_));
			class3.method_119();
			num += smethod_243("klassx-camera/session-posts-status", list.Count == 3 && list[2] == Class178.smethod_3());
		}
		finally
		{
			((IDisposable)class3).Dispose();
		}
		using (GForm0 gForm = new GForm0())
		{
			TrackBar trackBar = gForm.method_121();
			System.Windows.Forms.Label label = gForm.method_122();
			num += smethod_243("klassx-camera/designer-range-and-actual-only-label", trackBar != null && trackBar.Minimum == 6 && trackBar.Maximum == 116 && trackBar.Value == 10 && label != null && label.Text == "Zoom --");
			trackBar.Value = 16;
			num += smethod_243("klassx-camera/programmatic-default-is-silent", !gForm.method_123().bool_0);
			gForm.method_126();
			Struct137 struct2 = gForm.method_123();
			num += smethod_243("klassx-camera/form-select-queues-current-track", struct2.bool_0 && struct2.float_0 == 1.6f && struct2.int_0 == 1);
			gForm.method_125();
			Struct137 struct3 = gForm.method_123();
			num += smethod_243("klassx-camera/user-scroll-records-intent-only", struct3.bool_0 && struct3.float_0 == 1.6f && struct3.int_0 == 2 && label.Text == "Zoom --");
			System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer
			{
				Interval = 250
			};
			timer.Start();
			gForm.method_124(timer);
			gForm.method_125();
			num += smethod_243("klassx-camera/new-scroll-stops-superseded-timeout", !timer.Enabled);
		}
		num += smethod_249();
		Class119 class4 = new Class119();
		try
		{
			Class237 class5 = new Class237();
			Class318 class6 = (Class318)(class4.synchronizationContext_0 = new Class318());
			class5.int_0 = 0;
			class5.int_1 = 0;
			class4.method_6(class5.method_0);
			class4.method_8(class5.method_1);
			class4.method_44(1L);
			smethod_250(class4, "{\"t\":\"cam_zoom\",\"ok\":true,\"req\":0,\"zoom\":1.5,\"raw\":120.0,\"ready\":true}", 1L);
			smethod_250(class4, "{\"t\":\"cam_zoom_status\",\"ready\":true,\"anchored\":true,\"reason\":\"\"}", 1L);
			class4.method_44(2L);
			class6.method_0();
			num += smethod_243("klassx-camera/queued-old-generation-is-ignored", class5.int_0 == 0 && class5.int_1 == 0);
			smethod_250(class4, "{\"t\":\"cam_zoom\",\"ok\":true,\"req\":0,\"zoom\":1.6,\"raw\":128.0,\"ready\":true}", 2L);
			class6.method_0();
			num += smethod_243("klassx-camera/current-generation-is-delivered", class5.int_0 == 1 && class5.int_1 == 0);
		}
		finally
		{
			((IDisposable)class4).Dispose();
		}
		Console.WriteLine("klassx-camera: " + num + " failed");
		return num;
	}

	private static int smethod_249()
	{
		Class277 @class = new Class277();
		@class.class119_0 = new Class119();
		@class.manualResetEventSlim_0 = new ManualResetEventSlim(initialState: false);
		@class.manualResetEventSlim_1 = new ManualResetEventSlim(initialState: false);
		@class.manualResetEventSlim_2 = new ManualResetEventSlim(initialState: false);
		@class.exception_1 = null;
		@class.exception_0 = null;
		@class.class119_0.method_41(@class.method_0);
		@class.class119_0.method_8(@class.method_1);
		@class.class119_0.method_44(1L);
		Thread thread = new Thread(@class.method_2);
		thread.IsBackground = true;
		thread.Start();
		bool flag = @class.manualResetEventSlim_0.Wait(1500);
		Thread thread2 = new Thread(@class.method_3);
		thread2.IsBackground = true;
		thread2.Start();
		bool flag2 = @class.manualResetEventSlim_2.Wait(1500);
		@class.manualResetEventSlim_1.Set();
		bool flag3 = thread2.Join(1500);
		bool flag4 = thread.Join(1500);
		return smethod_243("klassx-camera/callback-close-no-lock-inversion", flag && flag2 && flag3 && flag4 && @class.exception_1 == null && @class.exception_0 == null);
	}

	private static void smethod_250(Class119 class119_0, string string_0, long long_1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0 + "\0");
		IntPtr intPtr = Marshal.AllocHGlobal(bytes.Length);
		try
		{
			Marshal.Copy(bytes, 0, intPtr, bytes.Length);
			class119_0.method_45(intPtr, IntPtr.Zero, 0, new IntPtr(long_1));
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	internal static int smethod_251()
	{
		return smethod_252("heartbeat-watchdog/launcher", smethod_253) + smethod_252("heartbeat-watchdog/transition", smethod_254) + smethod_252("heartbeat-watchdog/pre-show-lifecycle", smethod_256) + smethod_252("heartbeat-watchdog/loss", smethod_255) + smethod_252("heartbeat-watchdog/probe-fault", smethod_257) + smethod_252("heartbeat-watchdog/dispatcher-fault", smethod_259) + smethod_252("heartbeat-watchdog/dispose", smethod_258) + smethod_252("heartbeat-watchdog/idempotent", smethod_260) + smethod_252("heartbeat-watchdog/login-gate", smethod_261);
	}

	private static int smethod_252(string string_0, Func<int> func_0)
	{
		try
		{
			return func_0();
		}
		catch (Exception ex)
		{
			Console.WriteLine("FAIL " + string_0 + ": " + ex.GetType().Name);
			return 1;
		}
	}

	private static int smethod_253()
	{
		int num = 0;
		num = 0 + smethod_244("heartbeat-watchdog/default-startup-grace", TimeSpan.FromSeconds(30.0), Class92.timeSpan_0);
		num += smethod_244("heartbeat-watchdog/default-poll", TimeSpan.FromMilliseconds(300.0), Class92.timeSpan_1);
		Class246 @class = new Class246();
		try
		{
			@class.method_2(1400);
			bool result = Class343.smethod_4(@class.method_0(), TimeSpan.FromSeconds(2.0), TimeSpan.FromMilliseconds(20.0), CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243("heartbeat-watchdog/already-running", result);
			num += smethod_243("heartbeat-watchdog/parameterized-probe", Class343.smethod_3(@class.method_0()));
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		Class338 class2 = new Class338();
		class2.class246_0 = new Class246();
		try
		{
			Task task = Task.Run((Func<Task>)class2.method_0);
			bool result2 = Class343.smethod_4(class2.class246_0.method_0(), TimeSpan.FromSeconds(2.0), TimeSpan.FromMilliseconds(20.0), CancellationToken.None).GetAwaiter().GetResult();
			task.GetAwaiter().GetResult();
			num += smethod_243("heartbeat-watchdog/delayed-appearance", result2);
		}
		finally
		{
			if (class2.class246_0 != null)
			{
				((IDisposable)class2.class246_0).Dispose();
			}
		}
		string string_ = "hb" + Guid.NewGuid().ToString("N");
		Stopwatch stopwatch = Stopwatch.StartNew();
		bool result3 = Class343.smethod_4(string_, TimeSpan.FromMilliseconds(160.0), TimeSpan.FromMilliseconds(20.0), CancellationToken.None).GetAwaiter().GetResult();
		stopwatch.Stop();
		num += smethod_243("heartbeat-watchdog/startup-timeout", !result3);
		return num + smethod_243("heartbeat-watchdog/startup-timeout-bounded", stopwatch.Elapsed >= TimeSpan.FromMilliseconds(120.0) && stopwatch.Elapsed < TimeSpan.FromSeconds(2.0));
	}

	private static int smethod_254()
	{
		Class217 @class = new Class217();
		int num = 0;
		Class242 class2 = new Class242();
		Class17 class3 = new Class17();
		@class.int_0 = 0;
		using Class92 class4 = new Class92("transition-probe", TimeSpan.FromMilliseconds(20.0), Class299.class299_0.method_99, class2.method_0, class3.method_0, Class299.class299_0.method_100);
		bool result = class4.method_0(Class299.class299_0.method_101, TimeSpan.FromSeconds(1.0), TimeSpan.FromMilliseconds(20.0), CancellationToken.None).GetAwaiter().GetResult();
		num += smethod_243("heartbeat-watchdog/transition-observed", result);
		num += smethod_243("heartbeat-watchdog/transition-posted", class2.method_1(TimeSpan.FromSeconds(1.0)));
		class2.method_3();
		num += smethod_244("heartbeat-watchdog/transition-before-attach", 0, @class.int_0);
		bool flag = class3.method_1(@class.method_0);
		num += smethod_243("heartbeat-watchdog/transition-refuses-show", !flag);
		num += smethod_244("heartbeat-watchdog/transition-close-on-attach", 1, @class.int_0);
		class3.method_0();
		Thread.Sleep(80);
		class2.method_3();
		return num + smethod_244("heartbeat-watchdog/transition-close-once", 1, @class.int_0);
	}

	private static int smethod_255()
	{
		Class297 @class = new Class297();
		int num = 0;
		Class242 class2 = new Class242();
		@class.int_0 = 0;
		List<string> list = new List<string>();
		Class257 class3 = new Class257();
		class3.class246_0 = new Class246();
		try
		{
			class3.class246_0.method_2(900);
			Class92 class4 = new Class92(class3.class246_0.method_0(), Class92.timeSpan_1, Class343.smethod_3, class2.method_0, @class.method_0, list.Add);
			try
			{
				bool result = class4.method_0(Class343.smethod_4, TimeSpan.FromSeconds(2.0), TimeSpan.FromMilliseconds(20.0), CancellationToken.None).GetAwaiter().GetResult();
				num += smethod_243("heartbeat-watchdog/runtime-observed", result);
				class3.class246_0.method_3(TimeSpan.FromSeconds(3.0));
				Stopwatch stopwatch = Stopwatch.StartNew();
				bool bool_ = class2.method_2(@class.method_1, TimeSpan.FromSeconds(2.0));
				stopwatch.Stop();
				num += smethod_243("heartbeat-watchdog/runtime-close", bool_);
				num += smethod_243("heartbeat-watchdog/runtime-close-bound", stopwatch.Elapsed <= TimeSpan.FromMilliseconds(1300.0));
				num += smethod_243("heartbeat-watchdog/runtime-safe-log", list.Exists(class3.method_0));
				Thread.Sleep(500);
				class2.method_3();
				num += smethod_244("heartbeat-watchdog/runtime-close-once", 1, @class.int_0);
				return num + smethod_243("heartbeat-watchdog/runtime-no-respawn", !Class343.smethod_3(class3.class246_0.method_0()));
			}
			finally
			{
				((IDisposable)class4).Dispose();
			}
		}
		finally
		{
			if (class3.class246_0 != null)
			{
				((IDisposable)class3.class246_0).Dispose();
			}
		}
	}

	private static int smethod_256()
	{
		int num = 0;
		Class307 @class = new Class307();
		@class.gform0_0 = new GForm0();
		try
		{
			Class227 class2 = new Class227();
			class2.int_0 = 0;
			class2.int_1 = 0;
			class2.int_2 = 0;
			@class.gform0_0.FormClosing += class2.method_0;
			@class.gform0_0.FormClosed += class2.method_1;
			Class17 class3 = new Class17();
			class3.method_0();
			Action action_ = @class.gform0_0.method_19;
			bool flag = class3.method_1(action_);
			bool bool_ = smethod_264(@class.method_0, TimeSpan.FromSeconds(3.0));
			num += smethod_243("heartbeat-watchdog/pre-show/refuses-show", !flag);
			num += smethod_243("heartbeat-watchdog/pre-show/disposed", bool_);
			num += smethod_243("heartbeat-watchdog/pre-show/form-closing", Volatile.Read(ref class2.int_0) >= 1);
			num += smethod_244("heartbeat-watchdog/pre-show/form-closed-once", 1, Volatile.Read(ref class2.int_1));
			num += smethod_244("heartbeat-watchdog/pre-show/exit-request-once", 1, Volatile.Read(ref class2.int_2));
			num += smethod_243("heartbeat-watchdog/pre-show/cleanup-complete", @class.gform0_0.method_3());
			return num + smethod_243("heartbeat-watchdog/pre-show/remains-hidden", !@class.gform0_0.Visible);
		}
		finally
		{
			if (@class.gform0_0 != null)
			{
				((IDisposable)@class.gform0_0).Dispose();
			}
		}
	}

	private static int smethod_257()
	{
		Class267 @class = new Class267();
		int num = 0;
		Class242 class2 = new Class242();
		@class.int_0 = 0;
		List<string> list = new List<string>();
		Class92 class3 = new Class92("fault-probe", TimeSpan.FromMilliseconds(20.0), Class299.class299_0.method_102, class2.method_0, @class.method_0, list.Add);
		try
		{
			bool result = class3.method_0(Class299.class299_0.method_103, TimeSpan.FromSeconds(1.0), TimeSpan.FromMilliseconds(20.0), CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243("heartbeat-watchdog/fault-observed", result);
			num += smethod_243("heartbeat-watchdog/fault-close", class2.method_2(@class.method_1, TimeSpan.FromSeconds(1.0)));
			return num + smethod_243("heartbeat-watchdog/fault-safe-log", list.Exists(Class299.class299_0.method_104));
		}
		finally
		{
			((IDisposable)class3).Dispose();
		}
	}

	private static int smethod_258()
	{
		Class328 @class = new Class328();
		Class242 class2 = new Class242();
		@class.int_0 = 0;
		Class92 class3 = new Class92("dispose-probe", TimeSpan.FromMilliseconds(20.0), Class299.class299_0.method_105, class2.method_0, @class.method_0, Class299.class299_0.method_106);
		bool result = class3.method_0(Class299.class299_0.method_107, TimeSpan.FromSeconds(1.0), TimeSpan.FromMilliseconds(20.0), CancellationToken.None).GetAwaiter().GetResult();
		int num = smethod_243("heartbeat-watchdog/dispose-observed", result) + smethod_243("heartbeat-watchdog/dispose-posted", class2.method_1(TimeSpan.FromSeconds(1.0)));
		class3.Dispose();
		class2.method_3();
		int result2 = num + smethod_244("heartbeat-watchdog/dispose-suppresses-close", 0, @class.int_0);
		class3.Dispose();
		return result2;
	}

	private static int smethod_259()
	{
		Class207 @class = new Class207();
		int num = 0;
		@class.int_0 = 0;
		@class.list_0 = new List<string>();
		Class92 class2 = new Class92("dispatcher-fault-probe", TimeSpan.FromMilliseconds(20.0), Class299.class299_0.method_108, Class299.class299_0.method_109, @class.method_0, @class.list_0.Add);
		try
		{
			class2.method_0(Class299.class299_0.method_110, TimeSpan.FromSeconds(1.0), TimeSpan.FromMilliseconds(20.0), CancellationToken.None).GetAwaiter().GetResult();
			bool bool_ = SpinWait.SpinUntil(@class.method_1, TimeSpan.FromSeconds(1.0));
			num += smethod_243("heartbeat-watchdog/dispatcher-fault-logged", bool_);
			num += smethod_244("heartbeat-watchdog/dispatcher-fault-no-worker-close", 0, @class.int_0);
			return num + smethod_243("heartbeat-watchdog/dispatcher-fault-safe-log", @class.list_0.TrueForAll(Class299.class299_0.method_112));
		}
		finally
		{
			((IDisposable)class2).Dispose();
		}
	}

	private static int smethod_260()
	{
		Class287 @class = new Class287();
		int num = 0;
		Class242 class2 = new Class242();
		@class.int_0 = 0;
		using Class92 class3 = new Class92("idempotent-probe", TimeSpan.FromMilliseconds(10.0), Class299.class299_0.method_113, class2.method_0, @class.method_0, Class299.class299_0.method_114);
		class3.method_0(Class299.class299_0.method_115, TimeSpan.FromSeconds(1.0), TimeSpan.FromMilliseconds(10.0), CancellationToken.None).GetAwaiter().GetResult();
		class2.method_2(@class.method_1, TimeSpan.FromSeconds(1.0));
		Thread.Sleep(100);
		class2.method_3();
		return num + smethod_244("heartbeat-watchdog/repeated-ticks-close-once", 1, @class.int_0);
	}

	private static int smethod_261()
	{
		return smethod_263("null", null) + smethod_263("invalid", new GClass0
		{
			IsValid = false
		}) + smethod_262();
	}

	private static int smethod_262()
	{
		Class247 @class = new Class247();
		@class.int_0 = 0;
		@class.int_1 = 0;
		@class.int_2 = 0;
		@class.int_3 = 0;
		@class.int_4 = 0;
		@class.int_5 = 0;
		bool result = GForm1.smethod_0(new GClass0
		{
			IsValid = true
		}, @class.method_0, @class.method_1, @class.method_2, @class.method_3, @class.method_4, @class.method_5).GetAwaiter().GetResult();
		return smethod_243("heartbeat-watchdog/login-start-failure-rejected", !result) + smethod_244("heartbeat-watchdog/login-start-failure-guard-reset", 1, @class.int_0) + smethod_244("heartbeat-watchdog/login-start-failure-no-warning", 0, @class.int_1) + smethod_244("heartbeat-watchdog/login-start-failure-heartbeat-once", 1, @class.int_3) + smethod_244("heartbeat-watchdog/login-start-failure-close-once", 1, @class.int_2) + smethod_244("heartbeat-watchdog/login-start-failure-no-active-update", 0, @class.int_4) + smethod_244("heartbeat-watchdog/login-start-failure-no-form", 0, @class.int_5);
	}

	private static int smethod_263(string string_0, GClass0 gclass0_0)
	{
		Class315 @class = new Class315();
		@class.int_0 = 0;
		@class.int_1 = 0;
		@class.int_2 = 0;
		@class.int_3 = 0;
		@class.int_4 = 0;
		@class.int_5 = 0;
		bool result = GForm1.smethod_0(gclass0_0, @class.method_0, @class.method_1, @class.method_2, @class.method_3, @class.method_4, @class.method_5).GetAwaiter().GetResult();
		return smethod_243("heartbeat-watchdog/login-" + string_0 + "-rejected", !result) + smethod_244("heartbeat-watchdog/login-" + string_0 + "-guard-reset", 1, @class.int_0) + smethod_244("heartbeat-watchdog/login-" + string_0 + "-warning", 1, @class.int_1) + smethod_244("heartbeat-watchdog/login-" + string_0 + "-no-client-close", 0, @class.int_2) + smethod_244("heartbeat-watchdog/login-" + string_0 + "-no-heartbeat", 0, @class.int_3) + smethod_244("heartbeat-watchdog/login-" + string_0 + "-no-active-update", 0, @class.int_4) + smethod_244("heartbeat-watchdog/login-" + string_0 + "-no-form", 0, @class.int_5);
	}

	private static bool smethod_264(Func<bool> func_0, TimeSpan timeSpan_0)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		while (true)
		{
			if (stopwatch.Elapsed < timeSpan_0)
			{
				Application.DoEvents();
				if (func_0())
				{
					break;
				}
				Thread.Sleep(5);
				continue;
			}
			Application.DoEvents();
			return func_0();
		}
		return true;
	}

	internal static int smethod_265(string string_0, string string_1)
	{
		try
		{
			if (!File.Exists(string_0))
			{
				Console.Error.WriteLine("test-klx-preprocess: PNG file missing: " + string_0);
				return 2;
			}
			string directoryName = Path.GetDirectoryName(Path.GetFullPath(string_1));
			if (!Directory.Exists(directoryName))
			{
				Console.Error.WriteLine("test-klx-preprocess: output directory missing: " + directoryName);
				return 2;
			}
			float[] array = new float[38400];
			int num = Class167.smethod_0(File.ReadAllBytes(string_0), array);
			FileStream fileStream = new FileStream(string_1, FileMode.Create, FileAccess.Write, FileShare.None);
			try
			{
				BinaryWriter binaryWriter = new BinaryWriter(fileStream);
				try
				{
					float[] array2 = array;
					foreach (float value in array2)
					{
						binaryWriter.Write(value);
					}
				}
				finally
				{
					((IDisposable)binaryWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream).Dispose();
			}
			Console.WriteLine("test-klx-preprocess: PASS width=" + num + " floats=" + array.Length + " output=" + Path.GetFullPath(string_1));
			return 0;
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine("test-klx-preprocess: FAIL " + ex.GetType().Name + ": " + ex.Message);
			return 1;
		}
	}

	internal static int smethod_266()
	{
		Class235 @class = new Class235();
		int num = 0;
		@class.string_0 = Path.Combine(Path.GetTempPath(), "capy-grid-safety-" + Guid.NewGuid().ToString("N"));
		Directory.CreateDirectory(@class.string_0);
		try
		{
			string path = Path.Combine(@class.string_0, "catalogue.json");
			using (DataGridView dataGridView = smethod_267())
			{
				Class67 class2 = new Class67(@class.string_0);
				class2.method_6(dataGridView, "catalogue.json", bool_0: false);
				dataGridView.Rows.Add("A");
				int gparam_ = class2.method_3();
				using (class2.method_17(dataGridView))
				{
				}
				num += smethod_244("grid-safety/unchanged-bulk-does-not-save", gparam_, class2.method_3());
				using (DataGridView dataGridView2 = smethod_267())
				{
					new Class67(@class.string_0).method_6(dataGridView2, "catalogue.json", bool_0: false);
					dataGridView2.Rows.Add("B");
					string text = File.ReadAllText(path, Encoding.UTF8);
					num += smethod_243("grid-safety/two-writers-merge", text.Contains("\"A\"") && text.Contains("\"B\""));
				}
				gparam_ = class2.method_3();
				FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
				try
				{
					dataGridView.Rows.Add("C");
				}
				finally
				{
					((IDisposable)fileStream).Dispose();
				}
				num += smethod_244("grid-safety/locked-file-not-written", gparam_, class2.method_3());
				using (class2.method_17(dataGridView))
				{
				}
				num += smethod_243("grid-safety/lock-release-retries-pending", class2.method_3() == gparam_ + 1 && File.ReadAllText(path, Encoding.UTF8).Contains("\"C\""));
				File.WriteAllText(path, "{broken json", Encoding.UTF8);
				gparam_ = class2.method_3();
				dataGridView.Rows.Add("D");
				num += smethod_243("grid-safety/bad-file-preserved", File.ReadAllText(path, Encoding.UTF8) == "{broken json" && class2.method_3() == gparam_);
			}
			string path2 = Path.Combine(@class.string_0, "concurrent.json");
			@class.countdownEvent_0 = new CountdownEvent(2);
			try
			{
				@class.manualResetEventSlim_0 = new ManualResetEventSlim(initialState: false);
				try
				{
					@class.exception_0 = new Exception[2];
					Thread[] array = new Thread[2];
					for (int i = 0; i < array.Length; i++)
					{
						Class275 class3 = new Class275();
						class3.class235_0 = @class;
						class3.int_0 = i;
						array[i] = new Thread(class3.method_0);
						array[i].SetApartmentState(ApartmentState.STA);
						array[i].IsBackground = true;
						array[i].Start();
					}
					bool flag = @class.countdownEvent_0.Wait(10000);
					@class.manualResetEventSlim_0.Set();
					bool flag2 = true;
					Thread[] array2 = array;
					foreach (Thread thread in array2)
					{
						flag2 &= thread.Join(10000);
					}
					num += smethod_243("grid-safety/concurrent-writers-finished", flag && flag2 && @class.exception_0[0] == null && @class.exception_0[1] == null);
				}
				finally
				{
					if (@class.manualResetEventSlim_0 != null)
					{
						((IDisposable)@class.manualResetEventSlim_0).Dispose();
					}
				}
			}
			finally
			{
				if (@class.countdownEvent_0 != null)
				{
					((IDisposable)@class.countdownEvent_0).Dispose();
				}
			}
			Class404 class4 = JsonConvert.DeserializeObject<Class404>(File.ReadAllText(path2, Encoding.UTF8));
			num += smethod_244("grid-safety/concurrent-writers-keep-all", 40, (class4 == null || class4.List_1 == null) ? (-1) : class4.List_1.Count);
		}
		finally
		{
			string fullPath = Path.GetFullPath(@class.string_0);
			string fullPath2 = Path.GetFullPath(Path.GetTempPath());
			if (fullPath.StartsWith(fullPath2, StringComparison.OrdinalIgnoreCase) && Path.GetFileName(fullPath).StartsWith("capy-grid-safety-", StringComparison.Ordinal))
			{
				Directory.Delete(fullPath, recursive: true);
			}
		}
		Console.WriteLine("grid-safety: " + num + " failed");
		return num;
	}

	private static DataGridView smethod_267()
	{
		return new DataGridView
		{
			Name = "catalogueGrid",
			AllowUserToAddRows = false,
			Columns = { { "Name", "Name" } }
		};
	}

	internal static int smethod_268()
	{
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Expected O, but got Unknown
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected O, but got Unknown
		//IL_0ba5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Expected O, but got Unknown
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), "capy-challenge-test-" + Guid.NewGuid().ToString("N"));
		Directory.CreateDirectory(text);
		try
		{
			Class336 @class = new Class336();
			num += smethod_243("challenge/app-config-webhook", Uri.TryCreate(Class131.smethod_0(), UriKind.Absolute, out var result) && result.Scheme == Uri.UriSchemeHttps && result.Host == "discord.com" && result.AbsolutePath.StartsWith("/api/webhooks/", StringComparison.Ordinal));
			byte[] array = Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAQAAAC1HAwCAAAAC0lEQVR42mP8/x8AAwMCAO+jRZkAAAAASUVORK5CYII=");
			Class35 class2 = new Class35(text);
			class2.method_0("session-a", 17u, 0, 60, 3, array, 1000L, 29, null);
			class2.method_3("session-a", 17u, "54223", 1500L);
			class2.method_4("session-a", 17u, 0, 3, 1600L);
			@class.class1_1 = class2.method_5("session-a", 17u);
			@class.class1_1.String_9 = "54223";
			@class.class1_1.Nullable_2 = 98.85;
			PropertyInfo property = typeof(Class1).GetProperty("HeroName");
			if (property != null)
			{
				property.SetValue(@class.class1_1, "CapyHealing", null);
			}
			num += smethod_243("challenge/pass-promoted", @class.class1_1 != null && @class.class1_1.String_7 == "verified" && @class.class1_1.String_5 == "54223" && File.Exists(Path.Combine(text, "verified", @class.class1_1.String_0, "image.png")));
			num += smethod_243("challenge/duplicate-packet-does-not-create-sample", class2.method_0("session-a", 17u, 0, 60, 3, array, 1700L, 29, null) && class2.method_5("session-a", 17u).String_0 == @class.class1_1.String_0);
			class2.method_0("session-b", 17u, 0, 60, 3, array, 2000L, 29, null);
			class2.method_4("session-b", 17u, 3, 0, 61000L);
			@class.class1_2 = class2.method_5("session-b", 17u);
			num += smethod_243("challenge/expired-review-only", @class.class1_2 != null && @class.class1_2.String_7 == "expired" && @class.class1_2.String_5 == null && @class.class1_1.String_0 != @class.class1_2.String_0 && File.Exists(Path.Combine(text, "rejected", @class.class1_2.String_0, "image.png")));
			class2.method_0("session-c", 18u, 0, 60, 3, array, 3000L, 29, null);
			class2.method_3("session-c", 18u, "11111", 3100L);
			class2.method_4("session-c", 18u, 1, 2, 3200L);
			@class.class1_0 = class2.method_5("session-c", 18u);
			num += smethod_243("challenge/wrong-retry-stays-local", @class.class1_0 != null && @class.class1_0.String_7 == "wrong_retry" && @class.class1_0.String_5 == null && !class2.method_6().Any(@class.method_0));
			class2.method_3("session-c", 18u, "22222", 3300L);
			class2.method_4("session-c", 18u, 0, 2, 3400L);
			num += smethod_243("challenge/manual-correction-is-label", class2.method_5("session-c", 18u).String_5 == "22222");
			class2.method_0("session-d", 19u, 0, 60, 3, array, 4000L, 29, null);
			class2.method_4("session-d", 19u, 0, 3, 4500L);
			num += smethod_243("challenge/pass-without-answer-unresolved", class2.method_5("session-d", 19u).String_7 == "pass_without_observed_answer" && !class2.method_6().Any(Class299.class299_0.method_116));
			class2.method_0("session-f", 22u, 0, 60, 3, array, 7000L, 29, null);
			class2.method_3("session-f", 22u, "12345", 7200L);
			class2.method_4("session-f", 22u, 2, 0, 7300L);
			Class1 class3 = class2.method_5("session-f", 22u);
			JObject jObject = JObject.Parse(Class411.smethod_0(class3));
			num += smethod_243("challenge/failed-has-no-verified-label", class3.String_7 == "failed" && class3.String_5 == null && Class411.smethod_0(class3).Contains("REVIEW_NEEDED_FAILED") && jObject.Property("verifiedAnswer") != null && jObject["verifiedAnswer"].Type == JTokenType.Null);
			num += smethod_243("challenge/restart-recovers-uploads", new Class35(text).method_6().Count() == 4);
			string text2 = Class411.smethod_0(@class.class1_1);
			JObject jObject2 = JObject.Parse(text2);
			num += smethod_243("challenge/discord-content-is-readable-json", text2.Contains(Environment.NewLine) && property != null && (string?)jObject2["heroName"] == "CapyHealing" && (string?)jObject2["prediction"] == "54223" && Math.Abs((double)jObject2["predictionConfidence"] - 98.85) < 0.0001 && (string?)jObject2["verifiedAnswer"] == "54223");
			num += smethod_243("challenge/discord-content-labels", text2.Contains("PASS_VERIFIED") && Class411.smethod_0(@class.class1_2).Contains("REVIEW_NEEDED_EXPIRED") && JObject.Parse(Class411.smethod_0(@class.class1_2)).Property("verifiedAnswer") != null);
			string text3 = Path.Combine(text, "hero-provider");
			Type[] types = new Type[5]
			{
				typeof(string),
				typeof(string),
				typeof(Action<string>),
				typeof(HttpClient),
				typeof(Func<string>)
			};
			ConstructorInfo constructor = typeof(Class363).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, types, null);
			num += smethod_243("challenge/service-accepts-hero-provider", constructor != null);
			if (constructor != null)
			{
				using (Class363 class4 = (Class363)constructor.Invoke(new object[5]
				{
					text3,
					string.Empty,
					null,
					null,
					new Func<string>(Class299.class299_0.method_117)
				}))
				{
					class4.method_2("session-hero", 24u, 0, 60, 3, array, 8300L, 29);
					class4.method_12().GetAwaiter().GetResult();
				}
				Class1 class5 = new Class35(text3).method_5("session-hero", 24u);
				num += smethod_243("challenge/hero-persists-with-capture", class5 != null && property != null && (string)property.GetValue(class5, null) == "HitCbara");
			}
			Class250 class6 = new Class250(HttpStatusCode.OK, "{\"id\":\"discord-123\"}");
			try
			{
				HttpClient val = new HttpClient((HttpMessageHandler)(object)class6);
				try
				{
					Class187 result2 = new Class411(val, "https://discord.com/api/webhooks/test/test").method_0(@class.class1_1, class2.method_7(@class.class1_1), CancellationToken.None).GetAwaiter().GetResult();
					num += smethod_243("challenge/discord-multipart-receipt", result2.string_0 == "discord-123" && class6.string_1.Contains("wait=true") && class6.string_2.Contains("challenge_" + @class.class1_1.String_0 + ".png") && class6.string_2.Contains("PASS_VERIFIED"));
				}
				finally
				{
					((IDisposable)val).Dispose();
				}
			}
			finally
			{
				((IDisposable)(object)class6).Dispose();
			}
			Class250 class7 = new Class250((HttpStatusCode)429, "{\"retry_after\":2.5}");
			try
			{
				HttpClient val2 = new HttpClient((HttpMessageHandler)(object)class7);
				try
				{
					Class187 result3 = new Class411(val2, "https://discord.com/api/webhooks/test/test").method_0(@class.class1_2, class2.method_7(@class.class1_2), CancellationToken.None).GetAwaiter().GetResult();
					num += smethod_243("challenge/discord-429-retry-after", result3.string_0 == null && result3.timeSpan_0.TotalSeconds == 2.5);
				}
				finally
				{
					((IDisposable)val2).Dispose();
				}
			}
			finally
			{
				((IDisposable)(object)class7).Dispose();
			}
			num += smethod_243("challenge/ack-removes-pending-upload", class2.method_8(@class.class1_1.String_0, "discord-123") && !class2.method_6().Any(@class.method_1));
			num += smethod_243("challenge/ack-survives-restart", new Class35(text).method_6().Count() == 3);
			File.Delete(class2.method_7(@class.class1_2));
			num += smethod_243("challenge/missing-image-is-not-uploaded", !class2.method_6().Any(@class.method_2));
			num += smethod_243("challenge/invalid-png-rejected", !class2.method_0("session-e", 20u, 0, 60, 3, Encoding.UTF8.GetBytes("invalid"), 5000L, 29, null));
			string text4 = Path.Combine(text, "callback");
			Class363 class8 = new Class363(text4, string.Empty);
			try
			{
				Class119 class9 = new Class119();
				class9.method_1(class8);
				Class119 obj = class9;
				string text5 = "{\"type\":\"send\",\"payload\":{\"t\":\"challenge\",\"challengeId\":21,\"challengeType\":0,\"timeoutSec\":60,\"attemptsLeft\":3,\"imageLen\":" + array.Length + ",\"receivedUnixMs\":6000}}";
				byte[] bytes = Encoding.UTF8.GetBytes(text5 + "\0");
				IntPtr intPtr = Marshal.AllocHGlobal(bytes.Length);
				IntPtr intPtr2 = Marshal.AllocHGlobal(array.Length);
				try
				{
					Marshal.Copy(bytes, 0, intPtr, bytes.Length);
					Marshal.Copy(array, 0, intPtr2, array.Length);
					typeof(Class119).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic).Single(Class299.class299_0.method_118).Invoke(obj, new object[4]
					{
						intPtr,
						intPtr2,
						array.Length,
						IntPtr.Zero
					});
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr);
					Marshal.FreeHGlobal(intPtr2);
				}
				class8.method_12().GetAwaiter().GetResult();
			}
			finally
			{
				((IDisposable)class8).Dispose();
			}
			num += smethod_244("challenge/callback-copies-png", 1, Directory.GetDirectories(Path.Combine(text4, "pending")).Length);
			string text6 = Path.Combine(text, "pipeline");
			Class250 class10 = new Class250(HttpStatusCode.OK, "{\"id\":\"discord-pipeline\"}");
			try
			{
				HttpClient val3 = new HttpClient((HttpMessageHandler)(object)class10);
				try
				{
					Class363 class11 = new Class363(text6, "https://discord.com/api/webhooks/test/test", null, val3);
					class11.method_2("session-pipeline", 23u, 0, 60, 3, array, 8000L, 29);
					class11.method_4("session-pipeline", 23u, "12345", 8100L);
					class11.method_5("session-pipeline", 23u, 0, 3, 8200L);
					bool flag = false;
					for (int i = 0; i < 100; i++)
					{
						if (flag)
						{
							break;
						}
						if (!(flag = Directory.GetDirectories(Path.Combine(text6, "uploaded")).Length == 1))
						{
							Thread.Sleep(20);
						}
					}
					class11.method_12().GetAwaiter().GetResult();
					num += smethod_243("challenge/pipeline-uploads-after-result", flag && class10.string_2 != null && class10.string_2.Contains("PASS_VERIFIED"));
					num += smethod_243("challenge/pipeline-ack-survives-restart", !new Class35(text6).method_6().Any());
				}
				finally
				{
					((IDisposable)val3).Dispose();
				}
			}
			finally
			{
				((IDisposable)(object)class10).Dispose();
			}
		}
		finally
		{
			string fullPath = Path.GetFullPath(text);
			if (fullPath.StartsWith(Path.GetFullPath(Path.GetTempPath()), StringComparison.OrdinalIgnoreCase) && Path.GetFileName(fullPath).StartsWith("capy-challenge-test-", StringComparison.Ordinal))
			{
				Directory.Delete(fullPath, recursive: true);
			}
		}
		Console.WriteLine("challenge-capture: " + num + " failed");
		return num;
	}

	internal static int smethod_269()
	{
		string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Class131.smethod_8());
		string text = Path.Combine(Path.GetTempPath(), "ทดสอบ-oneocr", "OneOCR");
		int num = 0;
		try
		{
			Directory.CreateDirectory(text);
			string[] array = new string[3] { "oneocr.dll", "oneocr.onemodel", "onnxruntime.dll" };
			foreach (string path2 in array)
			{
				string text2 = Path.Combine(path, path2);
				if (File.Exists(text2))
				{
					File.Copy(text2, Path.Combine(text, path2), overwrite: true);
					continue;
				}
				Console.Error.WriteLine("test-ocr-thaipath: engine file missing beside exe: " + text2);
				return 2;
			}
			string text3 = Path.Combine(text, "oneocr.onemodel");
			string text4 = Class136.smethod_3(text3);
			Console.WriteLine("test-ocr-thaipath: thai path=" + text3);
			Console.WriteLine("test-ocr-thaipath: resolved=" + text4);
			if (!text4.All(Class299.class299_0.method_120))
			{
				Console.WriteLine("test-ocr-thaipath: FAIL resolved path still contains non-ASCII characters");
				num++;
			}
			if (string.Compare(text4, text3, StringComparison.OrdinalIgnoreCase) == 0)
			{
				Console.WriteLine("test-ocr-thaipath: FAIL resolver returned the original path unchanged");
				num++;
			}
			using Class136 @class = new Class136(text, Class299.class299_0.method_121);
			Class50 class2 = @class.imethod_0(smethod_273("12345"));
			Console.WriteLine("test-ocr-thaipath: text=" + class2.method_0() + " candidate=" + (class2.method_8() ?? "(none)") + ((class2.method_6() == null) ? string.Empty : (" error=" + class2.method_6())));
			if (class2.method_6() != null)
			{
				num++;
			}
			if (class2.method_8() != "12345")
			{
				num++;
			}
		}
		finally
		{
			string path3 = Path.Combine(Path.GetTempPath(), "ทดสอบ-oneocr");
			for (int j = 0; j < 3; Thread.Sleep(300), j++)
			{
				try
				{
					Directory.Delete(path3, recursive: true);
				}
				catch (IOException)
				{
					continue;
				}
				catch (UnauthorizedAccessException)
				{
					continue;
				}
				break;
			}
		}
		Console.WriteLine("test-ocr-thaipath: " + ((num == 0) ? "PASS" : (num + " failed")));
		return num;
	}

	internal static int smethod_270()
	{
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string text = Path.Combine(baseDirectory, "Vision", Class131.smethod_3());
		if (!File.Exists(text))
		{
			Console.Error.WriteLine("test-shadow: model file missing: " + text);
			return 2;
		}
		string string_ = Path.Combine(baseDirectory, Class131.smethod_8());
		using Class28 @class = new Class28(text, string_, Class299.class299_0.method_122);
		Class50 class2 = @class.imethod_0(smethod_273("12345"));
		Console.WriteLine("test-shadow: text=" + class2.method_0() + " candidate=" + (class2.method_8() ?? "(none)") + " confidence=" + class2.method_2().ToString("0.0000") + " latency=" + class2.method_4() + "ms" + ((class2.method_6() == null) ? string.Empty : (" error=" + class2.method_6())));
		int num = 0;
		if (class2.method_6() != null)
		{
			num++;
		}
		if (class2.method_8() != "12345")
		{
			num++;
		}
		Console.WriteLine("test-shadow: " + ((num == 0) ? "PASS" : (num + " failed")));
		return num;
	}

	internal static int smethod_271(string string_0)
	{
		int num = smethod_272();
		if (string_0 == null)
		{
			Console.WriteLine("test-fallback: " + ((num == 0) ? "PASS (matrix only)" : (num + " failed")));
			return num;
		}
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string text = Path.Combine(baseDirectory, "Vision", Class131.smethod_3());
		if (!File.Exists(text))
		{
			Console.Error.WriteLine("test-fallback: model file missing: " + text);
			return 2;
		}
		List<string> list = new List<string>();
		if (Directory.Exists(string_0))
		{
			list.AddRange(Directory.GetFiles(string_0, "*.png").OrderBy(Class299.class299_0.method_123).Take(12));
		}
		else if (File.Exists(string_0))
		{
			list.Add(string_0);
		}
		if (list.Count == 0)
		{
			Console.Error.WriteLine("test-fallback: no PNG images at: " + string_0);
			return 2;
		}
		using (Class28 @class = new Class28(text, Path.Combine(baseDirectory, Class131.smethod_8()), Class299.class299_0.method_124))
		{
			foreach (string item in list)
			{
				Class50 class2 = @class.imethod_0(File.ReadAllBytes(item));
				Console.WriteLine("test-fallback: " + Path.GetFileName(item) + " candidate=" + (class2.method_8() ?? "(none)") + " confidence=" + class2.method_2().ToString("0.00") + "% latency=" + class2.method_4() + "ms" + ((class2.method_6() == null) ? string.Empty : (" error=" + class2.method_6())));
				if (class2.method_6() != null)
				{
					num++;
				}
				if (class2.method_2() < 0.0 || class2.method_2() > 100.0)
				{
					Console.WriteLine("test-fallback: FAIL confidence outside 0..100: " + class2.method_2().ToString("0.0000"));
					num++;
				}
			}
		}
		Console.WriteLine("test-fallback: " + ((num == 0) ? "PASS" : (num + " failed")));
		return num;
	}

	private static int smethod_272()
	{
		List<Class286> obj = new List<Class286>
		{
			new Class286
			{
				string_0 = "oneocr-clear-wins-ours-low",
				string_1 = "12345",
				double_0 = 95.0,
				string_2 = "99999",
				double_1 = 60.0,
				bool_1 = true,
				string_3 = "12345",
				string_4 = "oneocr",
				string_5 = "oneocr-gate"
			},
			new Class286
			{
				string_0 = "confidence-override-real-case",
				string_1 = "85264",
				double_0 = 96.0,
				string_2 = "85284",
				double_1 = 99.0,
				bool_1 = true,
				string_3 = "85284",
				string_4 = "klx-fallback",
				string_5 = "confidence-override"
			},
			new Class286
			{
				string_0 = "fallback-always-disagree",
				string_1 = "54321",
				double_0 = 80.0,
				string_2 = "54322",
				double_1 = 12.0,
				bool_1 = true,
				string_3 = "54322",
				string_4 = "klx-fallback",
				string_5 = "fallback-always"
			},
			new Class286
			{
				string_0 = "fallback-always-agree",
				string_1 = "54321",
				double_0 = 80.0,
				string_2 = "54321",
				double_1 = 12.0,
				bool_1 = true,
				string_3 = "54321",
				string_4 = "klx-fallback",
				string_5 = "fallback-always"
			},
			new Class286
			{
				string_0 = "oneocr-error-klx-answers",
				string_1 = null,
				double_0 = 0.0,
				bool_0 = true,
				string_2 = "77777",
				double_1 = 12.0,
				bool_1 = true,
				string_3 = "77777",
				string_4 = "klx-fallback",
				string_5 = "oneocr-error"
			},
			new Class286
			{
				string_0 = "fallback-off-holds",
				string_1 = "54321",
				double_0 = 80.0,
				string_2 = "54321",
				double_1 = 99.0,
				bool_1 = false,
				string_3 = null,
				string_4 = null,
				string_5 = "below-gate"
			},
			new Class286
			{
				string_0 = "oneocr-invalid-digits-klx-answers",
				string_1 = null,
				double_0 = 95.0,
				string_2 = "91827",
				double_1 = 12.0,
				bool_1 = true,
				string_3 = "91827",
				string_4 = "klx-fallback",
				string_5 = "fallback-always"
			}
		};
		int num = 0;
		foreach (Class286 item in obj)
		{
			double double_;
			string string_;
			string string_2;
			string text = Class351.smethod_0(item.string_1, item.double_0, item.bool_0, item.string_2, item.double_1, bool_2: true, 90.0, item.bool_1, out double_, out string_, out string_2);
			bool flag;
			if (!(flag = text == item.string_3 && string_ == item.string_4 && string_2 == item.string_5))
			{
				num++;
			}
			Console.WriteLine("test-fallback: " + item.string_0 + " -> digits=" + (text ?? "(none)") + " engine=" + (string_ ?? "-") + " reason=" + string_2 + " conf=" + double_.ToString("0.00") + (flag ? string.Empty : ("  FAIL want " + (item.string_3 ?? "(none)") + "/" + (item.string_4 ?? "-") + "/" + item.string_5)));
		}
		return num;
	}

	private static byte[] smethod_273(string string_0)
	{
		Bitmap bitmap = new Bitmap(400, 100);
		try
		{
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.Clear(Color.White);
				Font font = new Font("Arial", 48f, FontStyle.Bold);
				try
				{
					using Brush brush = Brushes.Black;
					graphics.DrawString(string_0, font, brush, 20f, 15f);
				}
				finally
				{
					((IDisposable)font).Dispose();
				}
			}
			using MemoryStream memoryStream = new MemoryStream();
			bitmap.Save(memoryStream, ImageFormat.Png);
			return memoryStream.ToArray();
		}
		finally
		{
			((IDisposable)bitmap).Dispose();
		}
	}

	internal static int smethod_274(string string_0)
	{
		if (!File.Exists(string_0))
		{
			Console.Error.WriteLine("test-ocr: file not found: " + string_0);
			return 2;
		}
		using Class136 @class = new Class136(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Class131.smethod_8()), Class299.class299_0.method_125);
		Class50 class2 = @class.imethod_0(File.ReadAllBytes(string_0));
		Console.WriteLine("test-ocr: text=" + class2.method_0() + " confidence=" + class2.method_2().ToString("0.0000") + " latency=" + class2.method_4() + "ms" + ((class2.method_6() == null) ? string.Empty : (" error=" + class2.method_6())) + " candidate=" + (class2.method_8() ?? "(none)"));
		return (class2.method_6() != null) ? 1 : 0;
	}

	internal static int smethod_275()
	{
		Class215 @class = new Class215();
		int num = 0;
		num = 0 + smethod_243("challenge-auto/native-confidence-is-percent", Math.Abs(Class136.smethod_0(0.9885377288) - 98.85377288) < 1E-06);
		long num2 = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
		byte[] byte_ = Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAQAAAC1HAwCAAAAC0lEQVR42mP8/x8AAwMCAO+jRZkAAAAASUVORK5CYII=");
		Action<Class270, Class218, double> action = Class299.class299_0.method_126;
		Action action2 = Class299.class299_0.method_128;
		Class270 class2 = new Class270();
		Class218 arg = new Class218
		{
			string_0 = "74536",
			double_0 = 98.4
		};
		action(class2, arg, 90.0);
		class2.method_1(101u, num2, 60);
		class2.class351_0.method_0("s", 101u, 60, num2, byte_);
		action2();
		num += smethod_243("challenge-auto/high-confidence-submits", class2.list_0.Count == 1);
		num += smethod_243("challenge-auto/high-confidence-prediction", class2.list_1.Count == 1 && class2.list_1[0] == "101:74536");
		class2.dictionary_0["s/101"].String_7 = "submitted";
		class2.class351_0.method_0("s", 101u, 60, num2, byte_);
		action2();
		num += smethod_243("challenge-auto/one-attempt-per-challenge", class2.list_0.Count == 1);
		class2.class351_0.Dispose();
		Class270 class3 = new Class270();
		action(class3, new Class218
		{
			string_0 = "8558",
			double_0 = 82.07
		}, 90.0);
		class3.method_1(102u, num2, 60);
		class3.class351_0.method_0("s", 102u, 60, num2, byte_);
		action2();
		num += smethod_243("challenge-auto/low-confidence-holds", class3.list_0.Count == 0);
		num += smethod_243("challenge-auto/low-confidence-prediction-recorded", class3.list_1.Count == 1 && class3.list_1[0] == "102:8558");
		class3.class351_0.Dispose();
		Class270 class4 = new Class270();
		action(class4, new Class218
		{
			string_0 = "4 8 5 5 8 x",
			double_0 = 99.0
		}, 90.0);
		class4.method_1(103u, num2, 60);
		class4.class351_0.method_0("s", 103u, 60, num2, byte_);
		action2();
		num += smethod_243("challenge-auto/non-digits-hold", class4.list_0.Count == 0);
		num += smethod_243("challenge-auto/non-digits-prediction-null", class4.list_1.Count == 1 && class4.list_1[0] == "103:null");
		class4.class351_0.Dispose();
		Class270 class5 = new Class270();
		action(class5, new Class218
		{
			string_0 = "74536",
			double_0 = 98.4
		}, 90.0);
		class5.method_1(104u, num2, 60);
		class5.dictionary_0["s/104"].String_7 = "submitted";
		class5.method_1(105u, num2, 60);
		class5.dictionary_0["s/105"].String_7 = "expired";
		class5.class351_0.method_0("s", 104u, 60, num2, byte_);
		class5.class351_0.method_0("s", 105u, 60, num2, byte_);
		action2();
		num += smethod_243("challenge-auto/state-guards-hold", class5.list_0.Count == 0);
		class5.class351_0.Dispose();
		Class270 class6 = new Class270();
		action(class6, new Class218
		{
			string_0 = "74536",
			double_0 = 98.4
		}, 90.0);
		class6.method_1(106u, num2 - 59500L, 60);
		class6.class351_0.method_0("s", 106u, 60, num2 - 59500L, byte_);
		action2();
		num += smethod_243("challenge-auto/margin-holds", class6.list_0.Count == 0);
		num += smethod_243("challenge-auto/margin-prediction-recorded", class6.list_1.Count == 1);
		class6.class351_0.Dispose();
		@class.class270_0 = new Class270();
		action(@class.class270_0, new Class218
		{
			string_0 = "74536",
			double_0 = 98.4
		}, 90.0);
		@class.class270_0.method_1(107u, num2, 60);
		@class.class270_0.class351_0 = new Class351(new Class218
		{
			string_0 = "74536",
			double_0 = 98.4
		}, @class.class270_0.method_0, @class.method_0, Class299.class299_0.method_129, new Class114
		{
			bool_0 = true,
			double_0 = 90.0,
			double_1 = 0.0,
			double_2 = 0.3,
			double_3 = 0.3
		}, Class299.class299_0.method_130);
		@class.class270_0.class351_0.method_0("s", 107u, 60, num2, byte_);
		Thread.Sleep(60);
		@class.class270_0.dictionary_0["s/107"].String_7 = "submitted";
		Thread.Sleep(700);
		num += smethod_243("challenge-auto/race-cancel-during-delay", @class.class270_0.list_0.Count == 0);
		@class.class270_0.class351_0.Dispose();
		Class270 class7 = new Class270();
		action(class7, new Class218
		{
			string_0 = "74536",
			double_0 = 98.4
		}, 150.0);
		class7.method_1(108u, num2, 60);
		class7.class351_0.method_0("s", 108u, 60, num2, byte_);
		Thread.Sleep(150);
		num += smethod_243("challenge-auto/invalid-config-disabled", class7.list_0.Count == 0 && class7.list_1.Count == 0);
		class7.class351_0.Dispose();
		num += smethod_244("challenge-auto/confidence-scale-percent", 98.85, Math.Round(Class136.smethod_0(0.9885), 4));
		string text = Path.Combine(Path.GetTempPath(), "capy-challenge-auto-" + Guid.NewGuid().ToString("N"));
		try
		{
			Class35 class8 = new Class35(text);
			byte[] byte_2 = Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAQAAAC1HAwCAAAAC0lEQVR42mP8/x8AAwMCAO+jRZkAAAAASUVORK5CYII=");
			class8.method_0("late", 7u, 0, 60, 3, byte_2, 1L, 29, null);
			class8.method_4("late", 7u, 0, 3, 100L);
			num += smethod_243("challenge-auto/late-pass-stays-pending", class8.method_5("late", 7u).String_7 == "pass_without_observed_answer");
			class8.method_3("late", 7u, "74536", 90L);
			Class1 class9 = class8.method_5("late", 7u);
			num += smethod_243("challenge-auto/late-submission-promotes", class9.String_7 == "verified" && class9.String_5 == "74536");
			class8.method_3("late", 7u, "74536", 95L);
			num += smethod_243("challenge-auto/duplicate-submission-keeps-verified", class8.method_5("late", 7u).String_7 == "verified");
		}
		finally
		{
			try
			{
				Directory.Delete(text, recursive: true);
			}
			catch (IOException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
		}
		Console.WriteLine("challenge-auto: " + num + " failed");
		return num;
	}

	public static int smethod_276()
	{
		int num = 0;
		num = 0 + smethod_277();
		num += smethod_244("loading-rebirth/cmd/normal", "{\"cmd\":\"rebirth\",\"mode\":\"normal\",\"req\":41}", Class344.smethod_0((Enum13)0, 41u));
		num += smethod_244("loading-rebirth/cmd/withneck", "{\"cmd\":\"rebirth\",\"mode\":\"withneck\",\"req\":42}", Class344.smethod_0((Enum13)1, 42u));
		num += smethod_244("loading-rebirth/cmd/auto", "{\"cmd\":\"rebirth\",\"mode\":\"auto\",\"req\":43}", Class344.smethod_0((Enum13)2, 43u));
		bool bool_ = false;
		try
		{
			Class344.smethod_0((Enum13)99, 44u);
		}
		catch (ArgumentOutOfRangeException)
		{
			bool_ = true;
		}
		num += smethod_243("loading-rebirth/cmd/invalid-impossible", bool_);
		Class119 @class = new Class119();
		try
		{
			Class255 class2 = new Class255();
			class2.list_0 = new List<JObject>();
			class2.list_1 = new List<string>();
			@class.method_30(class2.method_0);
			@class.method_2(class2.method_1);
			uint num2 = @class.method_147();
			uint num3 = @class.method_148();
			uint num4 = @class.method_149();
			num += smethod_243("loading-rebirth/session/unique-nonzero-req", num2 != 0 && num3 != 0 && num4 != 0 && num2 != num3 && num2 != num4 && num3 != num4);
			num += smethod_243("loading-rebirth/session/old-agent-unavailable", !@class.method_137() && !@class.method_138() && class2.list_0.Count == 0 && @class.method_23() != null && @class.method_23().uint_0 == num4 && @class.method_23().string_0 == "auto" && @class.method_23().string_1 == "rebirth unavailable" && class2.list_1.Count == 3 && class2.list_1.All(Class299.class299_0.method_131));
			@class.method_154(77u, "auto", bool_17: true, false, bool_18: false, null);
			Class93 class3 = @class.method_23();
			num += smethod_243("loading-rebirth/reply/coherent", class3 != null && class3.uint_0 == 77 && class3.string_0 == "auto" && class3.bool_0 && class3.nullable_0 == false && !class3.bool_1 && class3.string_1 == string.Empty);
			long num5 = @class.method_24();
			@class.method_210();
			num += smethod_243("loading-rebirth/reply/lifecycle-reset", @class.method_23() == null && @class.method_24() == num5);
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		FieldInfo field = typeof(Class357).GetField("<RebirthAvailable>k__BackingField", BindingFlags.Static | BindingFlags.NonPublic);
		num += smethod_243("loading-rebirth/session/availability-fixture", field != null);
		if (field != null)
		{
			bool flag = (bool)field.GetValue(null);
			try
			{
				field.SetValue(null, true);
				Class119 class4 = new Class119();
				try
				{
					Class308 class5 = new Class308();
					class5.list_0 = new List<string>();
					class4.method_30(class5.method_0);
					smethod_94(class4, "_rebirthArmed", true);
					uint uint_ = class4.method_147();
					uint uint_2 = class4.method_148();
					uint uint_3 = class4.method_149();
					num += smethod_243("loading-rebirth/session/exact-wire-payloads", class5.list_0.SequenceEqual(new string[3]
					{
						Class344.smethod_0((Enum13)0, uint_),
						Class344.smethod_0((Enum13)1, uint_2),
						Class344.smethod_0((Enum13)2, uint_3)
					}));
				}
				finally
				{
					((IDisposable)class4).Dispose();
				}
			}
			finally
			{
				field.SetValue(null, flag);
			}
		}
		Class93 class6 = Class119.smethod_5(JObject.Parse("{\"t\":\"rebirth\",\"ok\":false,\"req\":88,\"mode\":\"withneck\",\"useRosary\":null,\"confirmed\":false,\"error\":\"no valid rosary\"}"), 9L);
		num += smethod_243("loading-rebirth/reply/decode", class6.long_0 == 9L && class6.uint_0 == 88 && class6.string_0 == "withneck" && !class6.bool_0 && !class6.nullable_0.HasValue && !class6.bool_1 && class6.string_1 == "no valid rosary");
		Class446 class7 = Class119.smethod_22(JObject.Parse("{\"loading\":true,\"loading_source\":3,\"loading_age_ms\":25,\"dead\":false,\"dead_age_ms\":19}"));
		num += smethod_243("loading-rebirth/census/true-source-age", class7.method_0() == true && class7.method_2() == 3 && class7.method_4() == 25 && class7.method_6() == false && class7.method_9() == 19);
		num += smethod_243("loading-rebirth/census/alive-derived", class7.method_8() == true);
		Class446 class8 = Class119.smethod_22(JObject.Parse("{\"loading\":false,\"loading_source\":0,\"loading_age_ms\":0,\"dead\":true,\"dead_age_ms\":0}"));
		num += smethod_243("loading-rebirth/census/false-and-dead", class8.method_0() == false && class8.method_6() == true && class8.method_8() == false);
		Class446 class9 = Class119.smethod_22(new JObject());
		num += smethod_243("loading-rebirth/census/unknown-stays-null", !class9.method_0().HasValue && !class9.method_4().HasValue && class9.method_2() == 0 && !class9.method_6().HasValue && !class9.method_8().HasValue && !class9.method_9().HasValue);
		Class446 class10 = Class119.smethod_22(JObject.Parse("{\"loading\":null,\"loading_source\":0,\"loading_age_ms\":7,\"dead\":null,\"dead_age_ms\":5}"));
		num += smethod_243("loading-rebirth/census/hook-tick-unreadable-keeps-sample-age", !class10.method_0().HasValue && class10.method_2() == 0 && class10.method_4() == 7 && !class10.method_6().HasValue && !class10.method_8().HasValue && class10.method_9() == 5);
		Class446 class11 = Class119.smethod_22(JObject.Parse("{\"loading\":true,\"loading_source\":1,\"loading_age_ms\":250,\"dead\":false,\"dead_age_ms\":250}"));
		num += smethod_243("loading-rebirth/census/no-hook-tick-keeps-aged-prior-value", class11.method_0() == true && class11.method_2() == 1 && class11.method_4() == 250 && class11.method_6() == false && class11.method_8() == true && class11.method_9() == 250);
		Class446 class12 = Class119.smethod_22(JObject.Parse("{\"loading\":1,\"loading_source\":9,\"loading_age_ms\":-1,\"dead\":\"false\",\"dead_age_ms\":1.5}"));
		num += smethod_243("loading-rebirth/census/malformed-stays-unknown", !class12.method_0().HasValue && class12.method_2() == 0 && !class12.method_4().HasValue && !class12.method_6().HasValue && !class12.method_9().HasValue);
		Class145 class13 = Class145.class145_0.method_96(null, Class95.class95_0, null, default(GStruct4), class7, 7, 1, null, null, null, null, default(Struct26)).method_93(new Class83
		{
			float_0 = 1f
		}, 8, 0);
		Class145 class14 = class13.method_96(null, Class95.class95_0, null, default(GStruct4), class8, 9, 0, null, null, null, null, default(Struct26));
		num += smethod_243("loading-rebirth/world/copy-across-self", class13.method_28() == true && class13.method_34() == false && class13.method_32() == 25);
		Class145 class15 = class13.method_97(null, null, Class95.class95_0, 1, 0);
		num += smethod_243("loading-rebirth/world/preserve-across-unrelated-reply", class15.method_28() == true && class15.method_34() == false && class15.method_37() == 19);
		num += smethod_243("loading-rebirth/world/replace-on-census", class14.method_28() == false && class14.method_34() == true && class14.method_89() == 9);
		Class145 class16 = class14.method_96(null, Class95.class95_0, null, default(GStruct4), class10, 10, 0, null, null, null, null, default(Struct26));
		num += smethod_243("loading-rebirth/world/replace-with-sampled-unknown", !class16.method_28().HasValue && class16.method_32() == 7 && !class16.method_34().HasValue && !class16.method_36().HasValue && class16.method_37() == 5);
		Class145 class17 = class14.method_95(null, Class95.class95_0, null, default(GStruct4), 11, 0);
		num += smethod_243("loading-rebirth/world/old-census-clears-optional", !class17.method_28().HasValue && !class17.method_34().HasValue);
		num += smethod_244("loading-rebirth/binary/self-size", 80, 80);
		num += smethod_244("loading-rebirth/binary/entity-size", 32, 32);
		num += smethod_244("loading-rebirth/t2/ack", "{\"cmd\":\"ack\",\"tier\":\"t2\"}", Class54.smethod_2(Class54.smethod_3("census_raw")));
		Class327 class18 = new Class327(new IntPtr(141));
		Class119 class19 = new Class119();
		try
		{
			class19.method_34(class18);
			class19.method_35(Class299.class299_0.method_132);
			class19.method_46(5046u);
			string text = class19.method_78(27043);
			int int_ = class18.int_2;
			class18.method_1("{\"type\":\"send\",\"payload\":{\"t\":\"census_raw\",\"seq\":12,\"skipped\":2,\"loading\":true,\"loading_source\":1,\"loading_age_ms\":4,\"dead\":false,\"dead_age_ms\":3}}");
			num += smethod_243("loading-rebirth/t2/callback-ack-and-publish", text == null && class18.int_2 == int_ + 1 && class19.method_51().method_89() == 12 && class19.method_51().method_28() == true && class19.method_51().method_36() == true);
		}
		finally
		{
			((IDisposable)class19).Dispose();
		}
		string text2 = smethod_173("Shared\\Agent\\runtime.ts", ref num);
		string text3 = Class119.smethod_61();
		if (text2 != null)
		{
			string[] array = new string[15]
			{
				"function sampleLoadingAndDeath()", "function rebirthAsk(", "function rebirthStep()", "REBIRTH_WATCHDOG_MS", "new RebirthQueue()", "rebirthQueue.ask(", "rebirthQueue.take(", "rebirthQueue.expire(", "connectionFailure(", "stateFailure(",
				"decideRosary(", "fnSendRebirth!(", "confirmed: false", "loading_source", "dead_age_ms"
			};
			for (int i = 0; i < array.Length; i++)
			{
				num += smethod_243("loading-rebirth/runtime/contract-" + i, text2.Contains(array[i]));
			}
			num += smethod_243("loading-rebirth/runtime/handler-owns-work", text2.Contains("sampleLoadingAndDeath(); rebirthStep();") && !text2.Contains("drainFrameQueue(); rebuffStep(); rebirthStep();"));
			num += smethod_243("loading-rebirth/runtime/no-decoy-loader", !text2.Contains("LoaderScene.instance") && !text2.Contains("tiLoaderScene"));
			num += smethod_244("loading-rebirth/runtime/rosary-called-once-in-decision", 1, smethod_160(text2, "fnHasValidRosary!(equipment, NULL)"));
			num += smethod_244("loading-rebirth/runtime/send-called-once-in-decision", 1, smethod_160(text2, "fnSendRebirth!(scm, choice.useRosary ? 1 : 0, NULL)"));
			int num6 = text2.IndexOf("const choice = decideRosary(", StringComparison.Ordinal);
			int num7 = text2.IndexOf("if (!choice.ok)", StringComparison.Ordinal);
			int num8 = text2.IndexOf("fnSendRebirth!(scm, choice.useRosary ? 1 : 0, NULL)", StringComparison.Ordinal);
			num += smethod_243("loading-rebirth/runtime/rosary-guard-before-send", num6 >= 0 && num7 > num6 && num8 > num7);
			num += smethod_243("loading-rebirth/runtime/shared-anchor-independent", text2.Contains("rebirthReady = initRebirthFunctions();") && text2.Contains("ensureServerConnectionAnchor(o.rvaPickAnchor)"));
			num += smethod_243("loading-rebirth/runtime/every-census-carries-vitals", smethod_160(text2, "loading_age_ms: vitals.loadingAge(Date.now())") == 3 && smethod_160(text2, "dead_age_ms: vitals.deadAge(Date.now())") == 3);
			num += smethod_243("loading-rebirth/runtime/hook-starts-unknown-sample", text2.Contains("vitals.beginHookSample(Date.now());") && text2.Contains("sampleLoadingSources([") && text2.Contains("vitals.observeLoading(loading.value, loading.source);") && text2.Contains("vitals.observeDead(fnIsGenuinelyDead(playerPtr, NULL) !== 0);"));
		}
		num += smethod_243("loading-rebirth/shipped/generated-keys", text3 != null && text3.Contains("tiMultiSceneHelper") && text3.Contains("rvaSendRebirth") && text3.Contains("rvaHasValidRosary") && text3.Contains("watchdog expired") && text3.Contains("no valid rosary"));
		Console.WriteLine("loading-rebirth: " + num + " failed");
		return num;
	}

	private static int smethod_277()
	{
		string text = smethod_171("Shared\\Agent\\test-rebirth-core.mjs");
		if (text == null)
		{
			return smethod_243("loading-rebirth/core/node-script-available", bool_0: false);
		}
		try
		{
			using Process process = Process.Start(new ProcessStartInfo
			{
				FileName = "node",
				Arguments = "\"" + text + "\"",
				WorkingDirectory = Path.GetDirectoryName(text),
				UseShellExecute = false,
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true
			});
			if (process == null)
			{
				return smethod_243("loading-rebirth/core/node-start", bool_0: false);
			}
			Task<string> task = process.StandardOutput.ReadToEndAsync();
			Task<string> task2 = process.StandardError.ReadToEndAsync();
			if (!process.WaitForExit(15000))
			{
				try
				{
					process.Kill();
				}
				catch
				{
				}
				process.WaitForExit(2000);
				Console.WriteLine("rebirth-core: timed out");
				return 1;
			}
			Task.WaitAll(new Task[2] { task, task2 }, 2000);
			string text2 = (task.IsCompleted ? task.Result : string.Empty);
			string text3 = (task2.IsCompleted ? task2.Result : string.Empty);
			if (process.ExitCode == 0 && text2.Contains("rebirth-core: 0 failed"))
			{
				return 0;
			}
			Console.WriteLine(text2 + text3);
			return smethod_243("loading-rebirth/core/node-behavior", bool_0: false);
		}
		catch (Exception ex)
		{
			Console.WriteLine("rebirth-core: " + ex.GetType().Name + ": " + ex.Message);
			return smethod_243("loading-rebirth/core/node-executable", bool_0: false);
		}
	}

	public static int smethod_278()
	{
		Struct26 struct26_ = Class119.smethod_23(JObject.Parse("{\"pet\":{\"ready\":true,\"fullness\":37,\"activeSlot\":8,\"globalId\":1234,\"objectPresent\":true}}"));
		int num = smethod_243("pet-world/census/active", struct26_.bool_0 && struct26_.nullable_0 == 37 && struct26_.nullable_1 == 8 && struct26_.nullable_2 == 1234 && struct26_.nullable_3 == true);
		Struct26 struct26_2 = Class119.smethod_23(JObject.Parse("{\"pet\":{\"ready\":false,\"fullness\":null,\"activeSlot\":null,\"globalId\":null,\"objectPresent\":null}}"));
		int num2 = num + smethod_243("pet-world/census/unknown", !struct26_2.bool_0 && !struct26_2.nullable_0.HasValue && !struct26_2.nullable_1.HasValue && !struct26_2.nullable_2.HasValue && !struct26_2.nullable_3.HasValue);
		Struct26 @struct = Class119.smethod_23(JObject.Parse("{\"pet\":{\"ready\":\"true\",\"fullness\":-1,\"activeSlot\":65536,\"globalId\":\"1234\",\"objectPresent\":1}}"));
		int num3 = num2 + smethod_243("pet-world/census/malformed", !@struct.bool_0 && !@struct.nullable_0.HasValue && !@struct.nullable_1.HasValue && !@struct.nullable_2.HasValue && !@struct.nullable_3.HasValue);
		Class145 @class = Class145.class145_0.method_96(null, Class95.class95_0, null, default(GStruct4), Class446.class446_0, 10, 0, null, null, null, null, struct26_).method_93(new Class83
		{
			float_0 = 1f
		}, 11, 0);
		Class145 class2 = @class.method_97(null, null, Class95.class95_0, 12, 24);
		int num4 = num3 + smethod_243("pet-world/preserve-across-other-publishes", @class.method_24().nullable_0 == 37 && class2.method_24().nullable_1 == 8);
		Class145 class3 = class2.method_96(null, Class95.class95_0, null, default(GStruct4), Class446.class446_0, 13, 0, null, null, null, null, struct26_2);
		int num5 = num4 + smethod_243("pet-world/replace-on-census", !class3.method_24().bool_0 && !class3.method_24().nullable_0.HasValue);
		IReadOnlyList<Struct27> readOnlyList = Class119.smethod_40(JObject.Parse("{\"bag\":[{\"i\":2,\"ord\":2,\"main\":11,\"sub\":1,\"amt\":1,\"type\":51},{\"i\":3,\"ord\":3,\"main\":12,\"sub\":1,\"amt\":4,\"type\":52},{\"i\":4,\"ord\":4,\"main\":13,\"sub\":1,\"amt\":1,\"type\":null}]}"));
		return num5 + smethod_243("pet-world/bag/types", readOnlyList.Count == 3 && readOnlyList[0].nullable_0 == 51 && readOnlyList[1].nullable_0 == 52 && !readOnlyList[2].nullable_0.HasValue);
	}

	public static int smethod_279()
	{
		int num = 0;
		num = 0 + smethod_244("pet-request/feed-wire", "{\"cmd\":\"pet\",\"action\":\"feed\",\"req\":7,\"foodSlot\":3,\"foodMain\":10,\"foodSub\":2,\"cardSlot\":8,\"cardMain\":142,\"cardSub\":204}", Class7.smethod_0(7u, 3, 10, 2, 8, 142, 204));
		num += smethod_244("pet-request/summon-wire", "{\"cmd\":\"pet\",\"action\":\"summon\",\"req\":8,\"cardSlot\":8,\"cardMain\":142,\"cardSub\":204}", Class7.smethod_1(8u, 8, 142, 204));
		num += smethod_244("pet-request/dismiss-wire", "{\"cmd\":\"pet\",\"action\":\"dismiss\",\"req\":9}", Class7.smethod_2(9u));
		Class327 @class = new Class327(new IntPtr(241));
		Class119 class2 = new Class119();
		try
		{
			Class228 class3 = new Class228();
			class2.method_34(@class);
			class2.method_35(Class299.class299_0.method_133);
			class2.method_46(5046u);
			string text = class2.method_78(27043);
			class3.list_0 = new List<JObject>();
			class2.method_30(class3.method_0);
			uint num2 = class2.method_157(8, 142, 204);
			num += smethod_243("pet-request/summon-pending", text == null && num2 != 0 && class2.method_27() && class3.list_0.Count == 1 && (uint)class3.list_0[0]["req"] == num2);
			num += smethod_244("pet-request/busy-refuses-overlap", 0u, class2.method_156(3, 10, 2, 8, 142, 204));
			num += smethod_244("pet-request/no-second-send", 1, class3.list_0.Count);
			@class.method_1("{\"type\":\"send\",\"payload\":{\"t\":\"pet_request\",\"action\":\"summon\",\"req\":" + num2 + ",\"ok\":true,\"serverConfirmed\":false}}");
			num += smethod_243("pet-request/ack-is-not-result", class2.method_27() && class2.method_25() == null);
			@class.method_1("{\"type\":\"send\",\"payload\":{\"t\":\"pet_response\",\"action\":\"summon\",\"req\":" + (num2 + 1) + ",\"result\":0,\"ok\":true}}");
			num += smethod_243("pet-request/old-or-unrelated-token-ignored", class2.method_27() && class2.method_25() == null);
			@class.method_1("{\"type\":\"send\",\"payload\":{\"t\":\"pet_response\",\"action\":\"summon\",\"req\":" + num2 + ",\"result\":0,\"ok\":true,\"globalId\":149,\"cardSlot\":8}}");
			Class194 class4 = class2.method_25();
			int num3 = num;
			int bool_;
			if (!class2.method_27() && class4 != null && class4.uint_0 == num2 && class4.string_0 == "summon" && class4.bool_0 && class4.bool_1)
			{
				int? num4 = class4.nullable_0;
				if ((num4.GetValueOrDefault() == 0) & num4.HasValue)
				{
					uint? nullable_ = class4.nullable_3;
					uint num5 = 149u;
					if (nullable_ == 149)
					{
						bool_ = ((class4.nullable_4 == 8) ? 1 : 0);
						goto IL_031f;
					}
				}
			}
			bool_ = 0;
			goto IL_031f;
			IL_031f:
			num = num3 + smethod_243("pet-request/server-result-clears-pending", (byte)bool_ != 0);
			uint num6 = class2.method_156(3, 10, 2, 8, 142, 204);
			num += smethod_243("pet-request/feed-can-start-after-summon", num6 != 0 && class2.method_27() && class3.list_0.Count == 2);
			@class.method_1("{\"type\":\"send\",\"payload\":{\"t\":\"pet_request\",\"action\":\"feed\",\"req\":" + num6 + ",\"ok\":false,\"error\":\"slot changed\"}}");
			Class194 class5 = class2.method_25();
			num += smethod_243("pet-request/refusal-clears-pending", !class2.method_27() && class5 != null && class5.uint_0 == num6 && !class5.bool_0 && !class5.bool_1 && class5.string_1 == "slot changed");
			uint num7 = class2.method_156(3, 10, 2, 8, 142, 204);
			@class.method_1("{\"type\":\"send\",\"payload\":{\"t\":\"pet_response\",\"action\":\"feed\",\"req\":" + num7 + ",\"result\":0,\"ok\":true,\"newFullness\":1000,\"consumedSlot\":3}}");
			Class194 class6 = class2.method_25();
			num += smethod_243("pet-request/feed-result-and-fullness", num7 != 0 && !class2.method_27() && class6 != null && class6.bool_1 && class6.bool_0 && class6.nullable_1 == 1000 && class6.nullable_2 == 3);
			uint num8 = class2.method_158();
			num += smethod_243("pet-request/dismiss-pending", num8 != 0 && class2.method_27() && class3.list_0.Count == 4);
			@class.method_1("{\"type\":\"send\",\"payload\":{\"t\":\"pet_response\",\"action\":\"dismiss\",\"req\":" + num8 + ",\"result\":0,\"ok\":true,\"globalId\":0,\"cardSlot\":65535}}");
			num += smethod_243("pet-request/dismiss-result", !class2.method_27() && class2.method_25() != null && class2.method_25().string_0 == "dismiss" && class2.method_25().bool_1 && class2.method_25().nullable_4 == ushort.MaxValue);
			class2.method_30(Class299.class299_0.method_134);
			uint num9 = class2.method_158();
			num += smethod_243("pet-request/post-failure-clears-pending", num9 == 0 && !class2.method_27() && class2.method_25() != null && class2.method_25().string_1 == "post failed");
			class2.method_210();
			return num + smethod_243("pet-request/close-clears-session-state", !class2.method_27() && class2.method_25() == null);
		}
		finally
		{
			((IDisposable)class2).Dispose();
		}
	}

	public static int smethod_280()
	{
		int num = 0;
		Class95 class95_ = new Class95(null, new Dictionary<string, string>
		{
			{ "142:204", "Ranny Bear" },
			{ "10:2", "Advanced Feed(100%)" }
		}, null);
		Struct27[] ireadOnlyList_ = new Struct27[3]
		{
			new Struct27
			{
				int_0 = 4,
				ushort_0 = 142,
				ushort_1 = 204,
				int_2 = 1,
				nullable_0 = 52
			},
			new Struct27
			{
				int_0 = 8,
				ushort_0 = 142,
				ushort_1 = 204,
				int_2 = 1,
				nullable_0 = 51
			},
			new Struct27
			{
				int_0 = 3,
				ushort_0 = 10,
				ushort_1 = 2,
				int_2 = 2,
				nullable_0 = 52
			}
		};
		Class145 class145_ = Class145.class145_0.method_97(ireadOnlyList_, null, class95_, 1, 60);
		num = 0 + smethod_243("pet-mode/card-name-and-type", GClass7.smethod_1(class145_, " ranny bear ", out var struct27_) && struct27_.int_0 == 8);
		num += smethod_243("pet-mode/food-type", GClass7.smethod_2(class145_, out var struct27_2) && struct27_2.int_0 == 4);
		num += smethod_243("pet-mode/no-card-match", !GClass7.smethod_1(class145_, "Other Pet", out struct27_));
		num += smethod_243("pet-mode/summoned", GClass7.smethod_3(new Struct26
		{
			bool_0 = true,
			nullable_1 = 8,
			nullable_2 = 149u,
			nullable_3 = true
		}) == true);
		num += smethod_243("pet-mode/not-summoned", GClass7.smethod_3(new Struct26
		{
			bool_0 = true,
			nullable_1 = ushort.MaxValue,
			nullable_2 = 0u,
			nullable_3 = false
		}) == false);
		num += smethod_243("pet-mode/mixed-stays-unknown", !GClass7.smethod_3(new Struct26
		{
			bool_0 = true,
			nullable_1 = 8,
			nullable_2 = 0u,
			nullable_3 = true
		}).HasValue);
		Struct26 struct26_ = new Struct26
		{
			bool_0 = true,
			nullable_0 = 0,
			nullable_1 = ushort.MaxValue,
			nullable_2 = 0u,
			nullable_3 = false
		};
		num += smethod_243("pet-mode/initial-zero-probes-once", GClass7.smethod_5(struct26_, bool_0: false) && !GClass7.smethod_5(struct26_, bool_0: true));
		struct26_.nullable_0 = 766;
		num += smethod_243("pet-mode/known-fullness-does-not-probe", !GClass7.smethod_5(struct26_, bool_0: false));
		struct26_.nullable_0 = 0;
		struct26_.nullable_1 = 8;
		struct26_.nullable_2 = 149u;
		struct26_.nullable_3 = true;
		num += smethod_243("pet-mode/active-pet-does-not-probe", !GClass7.smethod_5(struct26_, bool_0: false));
		new Class148(1L).int_4 = 8;
		Class148 @class = new Class148(2L);
		num += smethod_243("pet-mode/new-start-needs-its-own-probe", @class.int_4 != 8 && @class.int_5 == -1 && @class.uint_0 == 0);
		Class194 class194_ = new Class194(1L, 7u, "summon", bool_2: false, bool_3: true, 6, null, null, null, null, string.Empty, 12);
		Class194 class194_2 = new Class194(2L, 7u, "summon", bool_2: false, bool_3: false, null, null, null, null, null, "post failed", 12);
		num += smethod_243("pet-mode/zero-is-trusted-only-after-server-and-fresh-census", !GClass7.smethod_6(7u, null, 13) && !GClass7.smethod_6(7u, class194_2, 13) && !GClass7.smethod_6(7u, class194_, 12) && !GClass7.smethod_6(8u, class194_, 13) && GClass7.smethod_6(7u, class194_, 13));
		num += smethod_243("pet-mode/percent-threshold", GClass7.smethod_4(0, 50) && GClass7.smethod_4(499, 50) && !GClass7.smethod_4(500, 50) && !GClass7.smethod_4(760, 50) && GClass7.smethod_4(760, 77) && !GClass7.smethod_4(null, 50));
		num += smethod_244("pet-mode/progress-scale", 100, GClass7.smethod_7(1000));
		Class194 class194_3 = new Class194(1L, 7u, "feed", bool_2: true, bool_3: true, 0, 1000, 3, null, null, string.Empty, 12);
		return num + smethod_243("pet-mode/wait-for-census-after-success", GClass7.smethod_8(class194_3, 12) && !GClass7.smethod_8(class194_3, 13));
	}

	internal static int smethod_281()
	{
		int num = 0;
		Class394 @class = new Class394();
		DateTime dateTime_ = new DateTime(2026, 9, 24, 0, 0, 0, DateTimeKind.Utc);
		for (int i = 0; i < 5; i++)
		{
			DateTime dateTime_2 = dateTime_.AddSeconds(i);
			num += smethod_243("attack-stuck/early-not-blocked", !@class.method_0(2629u, 2, 1, 2, 972f, -97f, 745 + i, 986f, -105f, 0, dateTime_2));
			@class.method_1(2629u, dateTime_2);
		}
		num += smethod_243("attack-stuck/five-asks-five-seconds", @class.method_0(2629u, 2, 1, 2, 972f, -97f, 750, 986f, -105f, 0, dateTime_.AddSeconds(5.0)));
		num += smethod_243("attack-stuck/other-target-available", !@class.method_2(2630u, 2, 1, 2, 974f, -97f, dateTime_.AddSeconds(5.0)));
		num += smethod_243("attack-stuck/expires-after-minute", !@class.method_2(2629u, 2, 1, 2, 972f, -97f, dateTime_.AddSeconds(66.0)));
		@class.method_3();
		@class.method_0(2629u, 2, 1, 2, 972f, -97f, 745, 986f, -105f, 0, dateTime_);
		@class.method_1(2629u, dateTime_);
		num += smethod_243("attack-stuck/damage-clears-attempts", !@class.method_0(2629u, 2, 1, 2, 972f, -97f, 740, 986f, -105f, 0, dateTime_.AddSeconds(6.0)));
		for (int j = 0; j < 5; j++)
		{
			@class.method_1(2629u, dateTime_.AddSeconds(7 + j));
		}
		num += smethod_243("attack-stuck/damage-starts-new-window", !@class.method_0(2629u, 2, 1, 2, 972f, -97f, 740, 986f, -105f, 0, dateTime_.AddSeconds(11.0)));
		@class.method_3();
		@class.method_0(2629u, 2, 1, 2, 972f, -97f, 745, 986f, -105f, 0, dateTime_);
		for (int k = 0; k < 5; k++)
		{
			@class.method_1(2629u, dateTime_.AddSeconds(k));
		}
		num += smethod_243("attack-stuck/movement-clears-attempts", !@class.method_0(2629u, 2, 1, 2, 972f, -97f, 750, 989f, -105f, 0, dateTime_.AddSeconds(5.0)));
		for (int l = 0; l < 5; l++)
		{
			@class.method_1(2629u, dateTime_.AddSeconds(6 + l));
		}
		num += smethod_243("attack-stuck/new-position-can-block", @class.method_0(2629u, 2, 1, 2, 972f, -97f, 750, 989f, -105f, 0, dateTime_.AddSeconds(11.0)));
		num += smethod_243("attack-stuck/id-reuse-does-not-inherit-block", !@class.method_2(2629u, 2, 1, 2, 980f, -97f, dateTime_.AddSeconds(6.0)));
		@class.method_3();
		@class.method_0(2629u, 2, 1, 2, 972f, -97f, 745, 986f, -105f, 0, dateTime_);
		for (int m = 0; m < 5; m++)
		{
			@class.method_1(2629u, dateTime_.AddSeconds(m));
		}
		@class.method_0(2630u, 2, 1, 2, 974f, -97f, 500, 986f, -105f, 0, dateTime_.AddSeconds(5.0));
		return num + smethod_243("attack-stuck/switching-target-preserves-attempts", @class.method_0(2629u, 2, 1, 2, 972f, -97f, 750, 986f, -105f, 0, dateTime_.AddSeconds(5.0)));
	}

	public static int smethod_282()
	{
		Class268 @class = new Class268();
		int num = 0;
		num = 0 + smethod_283();
		Type type = typeof(GForm0).Assembly.GetType("Capybara_UI_Winform.Ui.TitleText");
		num += smethod_243("title/type", type != null);
		@class.methodInfo_0 = ((type == null) ? null : type.GetMethod("Format", BindingFlags.Static | BindingFlags.NonPublic));
		num += smethod_243("title/format", @class.methodInfo_0 != null);
		if (@class.methodInfo_0 != null)
		{
			Func<bool, bool, string, string, string, string> func = @class.method_0;
			num += smethod_244("title/ld-only", "LDPlayer-1", func(arg1: false, arg2: false, "Raw Hero", "login-user", "LDPlayer-1"));
			num += smethod_244("title/name", "Raw Hero : LDPlayer-1", func(arg1: true, arg2: false, "Raw Hero", "login-user", "LDPlayer-1"));
			num += smethod_244("title/id", "login-user : LDPlayer-1", func(arg1: false, arg2: true, "Raw Hero", "login-user", "LDPlayer-1"));
			num += smethod_244("title/name-id-order", "Raw Hero : login-user : LDPlayer-1", func(arg1: true, arg2: true, "Raw Hero", "login-user", "LDPlayer-1"));
			num += smethod_244("title/whitespace-hidden", Class135.smethod_4(), func(arg1: true, arg2: true, "  ", "\t", " "));
			num += smethod_244("title/null-fallback", Class135.smethod_4(), func(arg1: true, arg2: true, null, null, null));
			num += smethod_244("title/raw-hero-not-safe-file", "Hero A+B : LD", func(arg1: true, arg2: false, "Hero A+B", null, "LD"));
		}
		PropertyInfo property = typeof(Class145).GetProperty("LoginUserId");
		MethodInfo methodInfo = typeof(Class145).GetMethod("method_94", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		num += smethod_243("title/world/login-property", property != null);
		num += smethod_243("title/world/with-login", methodInfo != null);
		if (property != null && methodInfo != null)
		{
			Class145 class2 = (Class145)methodInfo.Invoke(Class145.class145_0, new object[1] { "login-user" });
			num += smethod_244("title/world/assigned", "login-user", (string)property.GetValue(class2));
			Class145 obj = class2.method_93(new Class83(), 1, 0).method_97(null, null, Class95.class95_0, 1, 0);
			num += smethod_244("title/world/with-copy-retains", "login-user", (string)property.GetValue(obj));
			num += smethod_244("title/world/empty-reset", null, (string)property.GetValue(Class145.class145_0));
		}
		@class.methodInfo_1 = typeof(Class119).GetMethod("smethod_24", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		num += smethod_243("title/census/parser", @class.methodInfo_1 != null);
		if (@class.methodInfo_1 != null)
		{
			Func<string, string> func2 = @class.method_1;
			num += smethod_244("title/census/valid", "login-user", func2("{\"login_id\":\"login-user\"}"));
			num += smethod_244("title/census/absent", null, func2("{}"));
			num += smethod_244("title/census/null", null, func2("{\"login_id\":null}"));
			num += smethod_244("title/census/empty", null, func2("{\"login_id\":\"\"}"));
			num += smethod_244("title/census/whitespace", null, func2("{\"login_id\":\"  \"}"));
			num += smethod_244("title/census/wrong-type", null, func2("{\"login_id\":17}"));
		}
		Class327 class3 = new Class327(new IntPtr(177));
		Class119 class4 = new Class119();
		try
		{
			class4.method_34(class3);
			class4.method_35(Class299.class299_0.method_135);
			class4.method_46(5046u);
			string text = class4.method_78(27043);
			class3.method_1("{\"type\":\"send\",\"payload\":{\"t\":\"census_raw\",\"seq\":1,\"login_id\":\"login-user\"}}");
			num += smethod_243("title/census/callback-publishes", text == null && class4.method_51().method_26() == "login-user");
			class3.method_1("{\"type\":\"send\",\"payload\":{\"t\":\"census_raw\",\"seq\":2,\"login_id\":null}}");
			class3.method_1("{\"type\":\"send\",\"payload\":{\"t\":\"census_raw\",\"seq\":3,\"login_id\":17}}");
			num += smethod_244("title/census/callback-retains", "login-user", class4.method_51().method_26());
			class4.method_210();
			num += smethod_244("title/census/session-reset", null, class4.method_51().method_26());
		}
		finally
		{
			((IDisposable)class4).Dispose();
		}
		int int_ = 0;
		string text2 = smethod_173("Shared\\Agent\\runtime.ts", ref int_);
		num += int_;
		if (text2 != null)
		{
			num += smethod_243("title/runtime/identity-ready", text2.Contains("identityReady"));
			num += smethod_243("title/runtime/cache", text2.Contains("new IdentityCache()"));
			num += smethod_243("title/runtime/census-field", text2.Contains("login_id: loginUserId()"));
			num += smethod_243("title/runtime/cache-observe", text2.Contains("loginIdentity.observe(readString(client, io.clientUserId));"));
			num += smethod_243("title/runtime/reset", text2.Contains("loginIdentity.reset();"));
			num += smethod_243("title/runtime/no-id-log", !text2.Contains("console.log(loginIdentity") && !text2.Contains("trace(loginIdentity") && !text2.Contains("send({ t: \"identity\", login_id"));
		}
		string text3 = smethod_173("Capybara-UI-Winform\\Ui\\ProcessButton.cs", ref num);
		if (text3 != null)
		{
			int num2 = text3.IndexOf("_settings.SetHero(hero, this);", StringComparison.Ordinal);
			int num3 = text3.IndexOf("session.InstallFrameHook();", StringComparison.Ordinal);
			int num4 = text3.IndexOf("_selectedHeroName = hero;", StringComparison.Ordinal);
			num += smethod_243("title/select/publish-only-after-success", num2 >= 0 && num3 > num2 && num4 > num3);
		}
		if (num == 0)
		{
			Console.WriteLine("PASS title");
		}
		else
		{
			Console.WriteLine(num + " title test(s) failed");
		}
		return num;
	}

	private static int smethod_283()
	{
		string text = smethod_171("Shared\\Agent\\test-identity-core.mjs");
		if (text == null)
		{
			return smethod_243("title/identity-core/script", bool_0: false);
		}
		try
		{
			using Process process = Process.Start(new ProcessStartInfo
			{
				FileName = "node",
				Arguments = "\"" + text + "\"",
				WorkingDirectory = Path.GetDirectoryName(text),
				UseShellExecute = false,
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true
			});
			if (process == null)
			{
				return smethod_243("title/identity-core/start", bool_0: false);
			}
			string text2 = process.StandardOutput.ReadToEnd();
			string text3 = process.StandardError.ReadToEnd();
			if (!process.WaitForExit(15000))
			{
				try
				{
					process.Kill();
				}
				catch
				{
				}
				return smethod_243("title/identity-core/timeout", bool_0: false);
			}
			if (process.ExitCode == 0 && text2.Contains("identity-core: 0 failed"))
			{
				return 0;
			}
			Console.WriteLine(text2 + text3);
			return smethod_243("title/identity-core/behavior", bool_0: false);
		}
		catch (Exception ex)
		{
			Console.WriteLine("identity-core: " + ex.GetType().Name + ": " + ex.Message);
			return smethod_243("title/identity-core/node", bool_0: false);
		}
	}

	internal static int smethod_284()
	{
		int num = 0;
		string text = ((Class135.smethod_1() == "klassx") ? "KlassX" : ((Class135.smethod_1() == "origin") ? "Origin" : null));
		num += smethod_243("profile/supported", text != null);
		if (text != null)
		{
			string text2 = "Capybara-" + text;
			num += smethod_244("profile/server", "ran-" + Class135.smethod_1(), Class135.smethod_2());
			num += smethod_244("profile/app", text2, Class135.smethod_4());
			num += smethod_244("profile/heartbeat", text2 + "-Hearthbeat", Class135.smethod_3());
			num += smethod_244("profile/update-name", text2 + "-Update", Class135.smethod_5());
			num += smethod_244("profile/update-repository", text2 + "-VersionControl", Class135.smethod_7());
			num += smethod_244("profile/control-pipe", text2 + "-Control", Class135.smethod_8());
		}
		num += smethod_243("update/newer", Class39.smethod_7("1.1", "1.2"));
		num += smethod_243("update/patch-newer", Class39.smethod_7("1.1", "v1.1.1"));
		num += smethod_243("update/same", !Class39.smethod_7("1.1", "1.1.0"));
		num += smethod_243("update/older", !Class39.smethod_7("1.2", "1.1"));
		num += smethod_243("update/bad-version", !Class39.smethod_7("1.1", "unknown"));
		string text3 = Class39.smethod_10("C:\\Program Files\\Capybara\\", "token with spaces");
		num += smethod_243("update/quoted-install-path", text3.Contains("\"C:\\Program Files\\Capybara\\\\\""));
		num += smethod_243("update/owner", text3.Contains("\"capybara-2025\""));
		num += smethod_243("update/repository", text3.Contains("\"" + Class135.smethod_7() + "\""));
		num += smethod_243("update/token", text3.Contains("\"token with spaces\""));
		num += smethod_243("update/app-name", !string.IsNullOrWhiteSpace(Class135.smethod_4()));
		num += smethod_244("update/owner-config", "capybara-2025", Class135.smethod_6());
		num += smethod_244("update/repo-config", Class135.smethod_4() + "-VersionControl", Class135.smethod_7());
		string text4 = Class39.smethod_8(JsonConvert.DeserializeObject<GClass5>("{\"version\":\"1.2\",\"release_notes\":\"Fixed party buff\\nImproved travel\"}"));
		num += smethod_243("update/release-notes-in-prompt", text4.Contains("Fixed party buff\nImproved travel"));
		num += smethod_243("update/version-in-prompt", text4.Contains("1.2"));
		num += smethod_243("update/net48-present", Class39.smethod_0(528040));
		num += smethod_243("update/net472-rejected", !Class39.smethod_0(461808));
		using (Stream stream = typeof(GForm0).Assembly.GetManifestResourceStream("Capybara-AutoUpdate.exe"))
		{
			num += smethod_243("update/embedded-exe", stream != null && stream.Length > 0L);
		}
		num += smethod_244("update/license-zero", "0d 0h 0m 0s", GForm0.smethod_21(TimeSpan.Zero));
		num += smethod_244("update/license-negative", "0d 0h 0m 0s", GForm0.smethod_21(TimeSpan.FromSeconds(-1.0)));
		Class39.smethod_2("offline-update-token");
		num += smethod_243("update/queued-handoff", Class39.smethod_3(out var string_));
		num += smethod_244("update/queued-token", "offline-update-token", string_);
		num += smethod_243("update/one-shot-handoff", !Class39.smethod_3(out string_));
		Console.WriteLine((num == 0) ? "PASS update" : ("FAIL update: " + num));
		return num;
	}

	internal static int smethod_285()
	{
		int num = smethod_284();
		num += smethod_282();
		num += smethod_31();
		Console.WriteLine((num == 0) ? "PASS product-profile" : ("FAIL product-profile: " + num));
		return num;
	}

	internal static int smethod_286()
	{
		Class329 @class = new Class329();
		int num = 0;
		@class.int_0 = 0;
		@class.int_1 = 0;
		using (Class139 class2 = smethod_287(smethod_288(bool_0: false, "catalog-a"), @class.method_0, @class.method_1))
		{
			bool result = class2.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243("catalog/unchanged-not-accepted", !result);
			num += smethod_244("catalog/unchanged-no-prompt", 0, @class.int_0);
			num += smethod_244("catalog/unchanged-no-queue", 0, @class.int_1);
		}
		@class.class438_0 = smethod_288(bool_0: true, "catalog-b");
		using (Class139 class3 = smethod_287(@class.class438_0, @class.method_2, @class.method_3))
		{
			bool result2 = class3.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243("catalog/no-keeps-running", !result2);
			num += smethod_244("catalog/no-does-not-queue", 0, @class.int_1);
			int int_ = @class.int_0;
			class3.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_244("catalog/no-suppresses-same-revision", int_, @class.int_0);
		}
		@class.int_3 = 0;
		@class.int_2 = 0;
		using (Class139 class4 = new Class139(Class299.class299_0.method_136, @class.method_4, @class.method_5, Class299.class299_0.method_137, Class299.class299_0.method_138, Class299.class299_0.method_139))
		{
			class4.method_0(CancellationToken.None).GetAwaiter().GetResult();
			class4.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_244("catalog/new-revision-prompts", 2, @class.int_3);
		}
		@class.string_0 = null;
		using (Class139 class5 = smethod_287(@class.class438_0, Class299.class299_0.method_140, @class.method_6))
		{
			bool result3 = class5.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243("catalog/yes-queues", result3);
			num += smethod_244("catalog/queue-token", "runtime-read-token", @class.string_0);
		}
		@class.int_4 = 0;
		using (Class139 class6 = new Class139(@class.method_7, @class.method_8, Class299.class299_0.method_141, Class299.class299_0.method_142, Class299.class299_0.method_143, Class299.class299_0.method_144))
		{
			bool result4 = class6.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243("catalog/legacy-pending-wins", !result4);
			num += smethod_244("catalog/legacy-skips-token", 0, @class.int_4);
		}
		@class.int_5 = 0;
		@class.taskCompletionSource_0 = new TaskCompletionSource<Class438>();
		using (Class139 class7 = new Class139(Class299.class299_0.method_145, @class.method_9, Class299.class299_0.method_146, Class299.class299_0.method_147, Class299.class299_0.method_148, Class299.class299_0.method_149))
		{
			Task<bool> task = class7.method_0(CancellationToken.None);
			bool result5 = class7.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243("catalog/non-overlap-second-skipped", !result5);
			num += smethod_244("catalog/non-overlap-one-check", 1, @class.int_5);
			@class.taskCompletionSource_0.SetResult(@class.class438_0);
			task.GetAwaiter().GetResult();
		}
		@class.string_1 = null;
		Class139 class8 = new Class139(Class299.class299_0.method_150, Class299.class299_0.method_151, @class.method_10, @class.method_11, Class299.class299_0.method_152, @class.method_12);
		try
		{
			bool result6 = class8.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243("catalog/failure-not-accepted", !result6);
			num += smethod_243("catalog/failure-safe-log", @class.string_1 != null && !@class.string_1.Contains("secret-sentinel-token"));
		}
		finally
		{
			((IDisposable)class8).Dispose();
		}
		@class.taskCompletionSource_1 = new TaskCompletionSource<string>();
		Class139 class9 = new Class139(@class.method_13, @class.method_14, Class299.class299_0.method_153, Class299.class299_0.method_154, Class299.class299_0.method_155, Class299.class299_0.method_156);
		Task<bool> task2 = class9.method_0(CancellationToken.None);
		class9.Dispose();
		num += smethod_243("catalog/dispose-cancels-check", !task2.GetAwaiter().GetResult());
		string text = Class39.smethod_11(@class.class438_0, "C:\\Capybara\\", "C:\\Temp\\token.bin", 1234, 5678L);
		num += smethod_243("catalog/args-mode", text.Contains("--catalog-apply"));
		num += smethod_243("catalog/args-ui", text.Contains("--ui"));
		num += smethod_243("catalog/args-pinned-release", text.Contains("--catalog-release-id \"101\""));
		num += smethod_243("catalog/args-pinned-asset", text.Contains("--catalog-asset-id \"202\""));
		num += smethod_243("catalog/args-pinned-size", text.Contains("--catalog-size \"2\""));
		num += smethod_243("catalog/args-token-file", text.Contains("--token-file \"C:\\Temp\\token.bin\""));
		num += smethod_243("catalog/args-parent", text.Contains("--parent-pid \"1234\"") && text.Contains("--parent-start-time-utc-ticks \"5678\""));
		num += smethod_243("catalog/args-no-token", !text.Contains("runtime-read-token"));
		num += smethod_243("catalog/args-app", text.Contains("--app \"" + Class135.smethod_4() + ".exe\""));
		string text2 = Class39.smethod_12(@class.class438_0);
		num += smethod_243("catalog/prompt-count", text2.Contains("1 file"));
		num += smethod_243("catalog/prompt-version", text2.Contains("model.bin") && text2.Contains("v2"));
		Class438 class10 = smethod_289("- Fixed model\n- Improved OCR", bool_0: true);
		num += smethod_244("catalog/release-notes-read", "- Fixed model\n- Improved OCR", class10.String_4);
		string text3 = Class39.smethod_12(class10);
		num += smethod_243("catalog/prompt-release-notes-heading", text3.Contains("รายละเอ\u0e35ยดการอ\u0e31ปเดต:"));
		num += smethod_243("catalog/prompt-release-notes-bullets", text3.Contains("- Fixed model") && text3.Contains("- Improved OCR"));
		Class438 class11 = smethod_289(null, bool_0: false);
		num += smethod_244("catalog/release-notes-missing-compatible", string.Empty, class11.String_4);
		Class438 class12 = smethod_289("Immutable schema 2 Release Studio catalog. Legacy releases remain unchanged.", bool_0: true);
		num += smethod_244("catalog/release-notes-legacy-placeholder-hidden", string.Empty, class12.String_4);
		Class438 class13 = smethod_289(new string('x', 9000), bool_0: true);
		num += smethod_244("catalog/release-notes-bounded", 8192, class13.String_4.Length);
		Class39.smethod_3(out var string_);
		Class39.smethod_6(out var class40_);
		num += smethod_243("catalog/queue-catalog", Class39.smethod_5(@class.class438_0, "catalog-read-token"));
		num += smethod_243("catalog/queue-catalog-one-shot", !Class39.smethod_5(@class.class438_0, "replacement-token"));
		Class39.smethod_2("legacy-token");
		num += smethod_243("catalog/legacy-clears-catalog", !Class39.smethod_6(out class40_));
		num += smethod_243("catalog/legacy-remains-first", Class39.smethod_3(out string_));
		num += smethod_244("catalog/legacy-token", "legacy-token", string_);
		string text4 = Class49.smethod_0("one-time-token");
		byte[] bytes = File.ReadAllBytes(text4);
		num += smethod_243("catalog/token-file-encrypted", !Encoding.UTF8.GetString(bytes).Contains("one-time-token"));
		num += smethod_244("catalog/token-file-consumed", "one-time-token", Class49.smethod_1(text4));
		num += smethod_243("catalog/token-file-deleted", !File.Exists(text4));
		Console.WriteLine((num == 0) ? "PASS catalog-update" : ("FAIL catalog-update: " + num));
		return num;
	}

	private static Class139 smethod_287(Class438 class438_0, Func<Class438, bool> func_0, Func<Class438, string, bool> func_1)
	{
		Class208 @class = new Class208();
		@class.class438_0 = class438_0;
		return new Class139(Class299.class299_0.method_157, @class.method_0, func_0, func_1, Class299.class299_0.method_158, Class299.class299_0.method_159);
	}

	private static Class438 smethod_288(bool bool_0, string string_0)
	{
		Class94 @class = new Class94
		{
			String_0 = "model.bin",
			String_1 = "v2",
			String_2 = new string('a', 64),
			Int64_0 = 25L,
			Int64_1 = 303L,
			Int64_2 = 404L,
			String_3 = (bool_0 ? "UPDATE" : "UNCHANGED"),
			Nullable_0 = (bool_0 ? new long?(20L) : new long?(25L)),
			String_4 = (bool_0 ? new string('b', 64) : new string('a', 64))
		};
		Class438 class2 = new Class438();
		class2.String_0 = "ran-klassx";
		class2.String_1 = string_0;
		class2.String_3 = "{}";
		class2.String_2 = new string(string_0.EndsWith("c") ? 'd' : 'c', 64);
		class2.Int64_0 = 101L;
		class2.Int64_1 = 202L;
		class2.Int64_2 = 2L;
		class2.IReadOnlyList_0 = new Class94[1] { @class };
		class2.IReadOnlyList_1 = ((!bool_0) ? new Class94[0] : new Class94[1] { @class });
		class2.Boolean_0 = bool_0;
		class2.Int64_3 = (bool_0 ? 25 : 0);
		return class2;
	}

	private static Class438 smethod_289(string string_0, bool bool_0)
	{
		string text = Path.Combine(Path.GetTempPath(), "Capybara-CatalogNotesTest-" + Guid.NewGuid().ToString("N"));
		Directory.CreateDirectory(text);
		try
		{
			Class238 @class = new Class238(string_0, bool_0);
			try
			{
				return Class21.smethod_1("owner", "repo", "ran-test", text, "read-token", CancellationToken.None, (HttpMessageHandler)(object)@class).GetAwaiter().GetResult();
			}
			finally
			{
				((IDisposable)(object)@class).Dispose();
			}
		}
		finally
		{
			if (Directory.Exists(text))
			{
				Directory.Delete(text, recursive: true);
			}
		}
	}

	internal static int smethod_290()
	{
		int num = 0;
		num = 0 + smethod_243("renew/valid-key", Form5.smethod_0("ABCD-0123-FFFF-9876"));
		num += smethod_243("renew/invalid-key", !Form5.smethod_0("not-a-key"));
		num += smethod_243("renew/lowercase-rejected", !Form5.smethod_0("abcd-0123-ffff-9876"));
		Form5 form = new Form5("device-123", "1.1", new GClass20());
		try
		{
			Control[] array = form.Controls.Find("textBoxHwid", searchAllChildren: true);
			num += smethod_243("renew/hwid-control", array.Length == 1);
			if (array.Length == 1)
			{
				num += smethod_244("renew/hwid-value", "device-123", array[0].Text);
			}
			num += smethod_243("renew/key-control", form.Controls.Find("textBoxKey", searchAllChildren: true).Length == 1);
			num += smethod_243("renew/button-control", form.Controls.Find("buttonRenew", searchAllChildren: true).Length == 1);
			num += smethod_244("renew/center-parent", FormStartPosition.CenterParent, form.StartPosition);
		}
		finally
		{
			((IDisposable)form).Dispose();
		}
		Console.WriteLine((num == 0) ? "PASS renew" : ("FAIL renew: " + num));
		return num;
	}

	internal static int smethod_291()
	{
		int num = 0;
		num = 0 + smethod_243("sell-vip/null-form", !GClass15.smethod_0(null, 1).GetAwaiter().GetResult());
		int[] array = new int[2] { 1, 2 };
		foreach (int int_ in array)
		{
			num += smethod_292("missing-license", null, int_);
			num += smethod_292("normal-license", new GClass0
			{
				IsValid = true,
				Vip = false
			}, int_);
			num += smethod_292("invalid-vip", new GClass0
			{
				IsValid = false,
				Vip = true
			}, int_);
		}
		GForm0 gForm = (GForm0)FormatterServices.GetUninitializedObject(typeof(GForm0));
		GC.SuppressFinalize(gForm);
		typeof(GForm0).GetField("_loginLicense", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, new GClass0
		{
			IsValid = true,
			Vip = true
		});
		PropertyInfo property = typeof(GForm0).GetProperty("CanUseVip", BindingFlags.Instance | BindingFlags.NonPublic);
		num += smethod_243("sell-vip/valid-vip-allowed", property != null && (bool)property.GetValue(gForm));
		Class119 @class = (Class119)FormatterServices.GetUninitializedObject(typeof(Class119));
		typeof(GForm0).GetField("_session", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, @class);
		bool[] array2 = new bool[2] { true, false };
		foreach (bool flag in array2)
		{
			Class145 class145_ = Class145.class145_0;
			Class95 class95_ = Class95.class95_0;
			GStruct3[] ireadOnlyList_ = new GStruct3[0];
			Class446 class2 = new Class446();
			class2.method_7(flag);
			class2.method_1(!flag);
			Class145 value = class145_.method_96(null, class95_, ireadOnlyList_, default(GStruct4), class2, 1, 0, null, null, null, null, default(Struct26));
			typeof(Class119).GetField("_world", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(@class, value);
			num += smethod_243("sell-vip/valid-vip-" + (flag ? "dead" : "loading"), !GClass15.smethod_0(gForm, 1).GetAwaiter().GetResult());
		}
		Console.WriteLine("sell-vip: " + num + " failed");
		return num;
	}

	private static int smethod_292(string string_0, GClass0 gclass0_0, int int_0)
	{
		GForm0 gForm = (GForm0)FormatterServices.GetUninitializedObject(typeof(GForm0));
		GC.SuppressFinalize(gForm);
		typeof(GForm0).GetField("_loginLicense", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, gclass0_0);
		string text = "sell-vip/" + string_0 + "/mode-" + int_0;
		try
		{
			return smethod_243(text, !GClass15.smethod_0(gForm, int_0).GetAwaiter().GetResult());
		}
		catch (Exception ex)
		{
			Console.WriteLine("FAIL  " + text + " reached game/UI logic: " + ex.GetType().Name);
			return 1;
		}
	}

	internal static int smethod_293()
	{
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), "klx-root-toast-" + Guid.NewGuid().ToString("N"));
		Directory.CreateDirectory(text);
		try
		{
			string string_ = Path.Combine(text, "superuser.sqlite");
			Class59 @class = new Class59(string_);
			try
			{
				@class.method_0("CREATE TABLE settings (key text primary key not null, value text)");
				@class.method_0("INSERT INTO settings VALUES ('automatic_response', '2')");
				@class.method_0("PRAGMA journal_mode=WAL");
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			num += smethod_243("root-toast/disable-changed", Class396.smethod_0(string_, bool_0: false));
			Class59 class2 = new Class59(string_);
			try
			{
				num += smethod_244("root-toast/disabled", "0", class2.method_1("SELECT value FROM settings WHERE key='notification'"));
				num += smethod_244("root-toast/grant-untouched", "2", class2.method_1("SELECT value FROM settings WHERE key='automatic_response'"));
			}
			finally
			{
				((IDisposable)class2).Dispose();
			}
			num += smethod_243("root-toast/disable-idempotent", !Class396.smethod_0(string_, bool_0: false));
			num += smethod_243("root-toast/enable-changed", Class396.smethod_0(string_, bool_0: true));
			Class59 class3 = new Class59(string_);
			try
			{
				num += smethod_244("root-toast/default-restored", null, class3.method_1("SELECT value FROM settings WHERE key='notification'"));
				num += smethod_244("root-toast/grant-still-untouched", "2", class3.method_1("SELECT value FROM settings WHERE key='automatic_response'"));
				num += smethod_244("root-toast/integrity", "ok", class3.method_1("PRAGMA integrity_check"));
			}
			finally
			{
				((IDisposable)class3).Dispose();
			}
			num += smethod_243("root-toast/enable-idempotent", !Class396.smethod_0(string_, bool_0: true));
			string string_2 = Path.Combine(text, "invalid.sqlite");
			Class59 class4 = new Class59(string_2);
			try
			{
				class4.method_0("CREATE TABLE other (key text, value text)");
			}
			finally
			{
				((IDisposable)class4).Dispose();
			}
			bool bool_ = false;
			try
			{
				Class396.smethod_0(string_2, bool_0: false);
			}
			catch (InvalidOperationException)
			{
				bool_ = true;
			}
			num += smethod_243("root-toast/schema-rejected", bool_);
		}
		finally
		{
			Directory.Delete(text, recursive: true);
		}
		Console.WriteLine((num == 0) ? "PASS root-toast" : ("FAIL root-toast: " + num));
		return num;
	}

	internal static int smethod_294()
	{
		Class288 @class = new Class288();
		int num = 0;
		Dictionary<string, string> ireadOnlyDictionary_ = new Dictionary<string, string>
		{
			{ "1", "Hero" },
			{ "2", "Teammate" },
			{ "3", "Stranger" }
		};
		List<Class403> ilist_ = new List<Class403>
		{
			new Class403
			{
				byte_0 = 100,
				uint_0 = 1u,
				ushort_5 = 0,
				byte_1 = 4
			},
			new Class403
			{
				byte_0 = 100,
				uint_0 = 2u,
				ushort_5 = 7
			},
			new Class403
			{
				byte_0 = 100,
				uint_0 = 3u,
				ushort_5 = 7
			}
		};
		@class.class145_0 = Class145.class145_0.method_96(ilist_, new Class95(null, null, ireadOnlyDictionary_), null, default(GStruct4), Class446.class446_0, 1, 0, null, new uint[2] { 1u, 2u }, null, null, default(Struct26));
		@class.hashSet_0 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		List<Class53> source = Class144.smethod_0(@class.class145_0, "Hero", @class.hashSet_0);
		num = 0 + smethod_243("party/self", source.Any(Class299.class299_0.method_160));
		num += smethod_243("party/member", source.Any(Class299.class299_0.method_161));
		num += smethod_243("party/exclude_other", source.All(Class299.class299_0.method_162));
		@class.valueTuple_0 = new(ushort, ushort)[10];
		@class.valueTuple_0[8] = (7, 8);
		Dictionary<uint, IReadOnlyList<GStruct2>> dictionary = new Dictionary<uint, IReadOnlyList<GStruct2>>();
		dictionary.Add(1u, new GStruct2[1]
		{
			new GStruct2
			{
				ushort_0 = 7,
				ushort_1 = 8,
				float_0 = 12.34f
			}
		});
		dictionary.Add(2u, new GStruct2[0]);
		Dictionary<uint, IReadOnlyList<GStruct2>> dictionary2 = dictionary;
		@class.class145_0 = Class145.class145_0.method_96(ilist_, new Class95(null, null, ireadOnlyDictionary_), null, default(GStruct4), Class446.class446_0, 1, 0, dictionary2, new uint[2] { 1u, 2u }, new uint[2] { 1u, 2u }, null, default(Struct26));
		source = Class144.smethod_1(@class.class145_0, "Hero", @class.hashSet_0, 9, @class.valueTuple_0);
		num += smethod_243("party/time_left_from_member_buff", source.Any(Class299.class299_0.method_163));
		num += smethod_243("party/time_left_absent_buff_is_zero", source.Any(Class299.class299_0.method_164));
		@class.valueTuple_0[9] = (9, 10);
		dictionary2[1u] = new GStruct2[2]
		{
			new GStruct2
			{
				ushort_0 = 7,
				ushort_1 = 8,
				float_0 = 12.34f
			},
			new GStruct2
			{
				ushort_0 = 9,
				ushort_1 = 10,
				float_0 = 45.5f
			}
		};
		@class.class145_0 = Class145.class145_0.method_96(ilist_, new Class95(null, null, ireadOnlyDictionary_), null, default(GStruct4), Class446.class446_0, 1, 0, dictionary2, new uint[2] { 1u, 2u }, new uint[2] { 1u, 2u }, null, default(Struct26));
		source = Class144.smethod_1(@class.class145_0, "Hero", @class.hashSet_0, 10, @class.valueTuple_0);
		num += smethod_243("party/time_left_uses_selected_slot", source.Any(Class299.class299_0.method_165));
		dictionary2.Remove(2u);
		@class.class145_0 = Class145.class145_0.method_96(ilist_, new Class95(null, null, ireadOnlyDictionary_), null, default(GStruct4), Class446.class446_0, 2, 0, dictionary2, new uint[2] { 1u, 2u }, new uint[2] { 1u, 2u }, null, default(Struct26));
		source = Class144.smethod_1(@class.class145_0, "Hero", @class.hashSet_0, 9, @class.valueTuple_0);
		num += smethod_243("party/time_left_unreadable_is_unknown", source.Any(Class299.class299_0.method_166));
		@class.class145_0 = Class145.class145_0.method_96(ilist_, new Class95(null, null, ireadOnlyDictionary_), null, default(GStruct4), Class446.class446_0, 2, 0, null, new uint[0], null, null, default(Struct26));
		source = Class144.smethod_0(@class.class145_0, "Hero", @class.hashSet_0);
		num += smethod_243("party/confirmed_solo", source.Count == 1 && source[0].string_0 == "Hero");
		@class.hashSet_0.Add("Teammate");
		source = Class144.smethod_0(@class.class145_0, "Hero", @class.hashSet_0);
		num += smethod_243("party/retain_missing", source.Any(Class299.class299_0.method_167));
		Form9 form = new Form9(9, @class.hashSet_0, @class.method_0);
		try
		{
			form.method_0();
			DataGridView dataGridView = form.Controls.OfType<DataGridView>().Single();
			num += smethod_243("party/dialog_three_columns", dataGridView.Columns.Count == 3 && dataGridView.Columns[2].Name == "TimeLeft");
		}
		finally
		{
			((IDisposable)form).Dispose();
		}
		Form9 form2 = new Form9(9, @class.hashSet_0, @class.method_1);
		try
		{
			form2.method_0();
			DataGridView dataGridView2 = form2.Controls.OfType<DataGridView>().Single();
			num += smethod_243("party/dialog_rows", dataGridView2.Rows.Count == 2);
			dataGridView2.Rows[0].Cells[0].Value = true;
			num += smethod_243("party/dialog_checked", @class.hashSet_0.Contains("Hero"));
			form2.method_0();
			num += smethod_243("party/refresh_keeps_checked", dataGridView2.Rows.Cast<DataGridViewRow>().Any(Class299.class299_0.method_168));
		}
		finally
		{
			((IDisposable)form2).Dispose();
		}
		GForm0 gForm = (GForm0)FormatterServices.GetUninitializedObject(typeof(GForm0));
		object value = new object();
		HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "Hero", "Teammate" };
		HashSet<string> hashSet2 = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "Hero" };
		typeof(GForm0).GetField("_partySelectionGate", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, value);
		typeof(GForm0).GetField("_buff9PartyNames", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, hashSet);
		typeof(GForm0).GetField("_buff10PartyNames", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, hashSet2);
		num += smethod_243("party/slot9_has_checked_names", gForm.method_103(9, out var list_) && list_.Count == 2 && list_.Contains("Hero") && list_.Contains("Teammate"));
		list_.Clear();
		num += smethod_243("party/returns_copy", hashSet.Count == 2);
		num += smethod_243("party/slot10_is_separate", gForm.method_103(10, out list_) && list_.Count == 1 && list_[0] == "Hero");
		num += smethod_243("party/invalid_slot_has_no_names", !gForm.method_103(8, out list_) && list_.Count == 0);
		hashSet2.Clear();
		num += smethod_243("party/empty_selection_returns_false", !gForm.method_103(10, out list_) && list_.Count == 0);
		Console.WriteLine("party-picker: " + num + " failed");
		return num;
	}

	internal static int smethod_295()
	{
		int num = 0;
		num = 0 + smethod_243("party-runtime/remote_wire", Class418.smethod_0(1058u) == "{\"cmd\":\"party_select\",\"id\":1058,\"self\":false}");
		num += smethod_243("party-runtime/self_wire", Class418.smethod_1() == "{\"cmd\":\"party_select\",\"self\":true}");
		num += smethod_243("party-runtime/status_wire", Class418.smethod_2() == "{\"cmd\":\"party_status\"}");
		List<string> list = new List<string>();
		Class119 @class = new Class119();
		try
		{
			@class.method_30(list.Add);
			@class.method_124(1058u);
			@class.method_125();
			@class.method_126();
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		return num + smethod_243("party-runtime/session_routes_distinct_commands", list.Count == 3 && (string?)JObject.Parse(list[0])["cmd"] == "party_select" && (uint)JObject.Parse(list[0])["id"] == 1058 && (bool)JObject.Parse(list[1])["self"] && (string?)JObject.Parse(list[2])["cmd"] == "party_status");
	}

	internal static int smethod_296()
	{
		int num = 0;
		IReadOnlyList<uint> readOnlyList = Class119.smethod_31(JObject.Parse("{}"));
		num = 0 + smethod_243("party-roster/missing_is_unreadable", readOnlyList == null);
		IReadOnlyList<uint> readOnlyList2 = Class119.smethod_31(JObject.Parse("{\"partyIds\":[]}"));
		num += smethod_243("party-roster/empty_is_confirmed_solo", readOnlyList2 != null && readOnlyList2.Count == 0);
		IReadOnlyList<uint> readOnlyList3 = Class119.smethod_31(JObject.Parse("{\"partyIds\":[1,2,4294967295]}"));
		num += smethod_243("party-roster/unsigned_ids_preserved", readOnlyList3 != null && readOnlyList3.Count == 3 && readOnlyList3[0] == 1 && readOnlyList3[1] == 2 && readOnlyList3[2] == uint.MaxValue);
		num += smethod_243("party-roster/malformed_is_unreadable", Class119.smethod_31(JObject.Parse("{\"partyIds\":[1,\"two\"]}")) == null);
		num += smethod_243("party-present/missing_is_unreadable", Class119.smethod_32(JObject.Parse("{}")) == null);
		IReadOnlyList<uint> readOnlyList4 = Class119.smethod_32(JObject.Parse("{\"partyPresentIds\":[]}"));
		num += smethod_243("party-present/empty_is_known", readOnlyList4 != null && readOnlyList4.Count == 0);
		IReadOnlyList<uint> readOnlyList5 = Class119.smethod_32(JObject.Parse("{\"partyPresentIds\":[1,2]}"));
		num += smethod_243("party-present/member_ids_preserved", readOnlyList5 != null && readOnlyList5.Count == 2 && readOnlyList5[0] == 1 && readOnlyList5[1] == 2);
		num += smethod_243("party-present/malformed_is_unreadable", Class119.smethod_32(JObject.Parse("{\"partyPresentIds\":[1,\"bad\"]}")) == null);
		List<Class403> ilist_ = new List<Class403>
		{
			new Class403
			{
				byte_0 = 100,
				uint_0 = 1u,
				ushort_5 = 0,
				byte_1 = 4
			},
			new Class403
			{
				byte_0 = 100,
				uint_0 = 3u,
				ushort_5 = 99
			}
		};
		JObject jobject_ = JObject.Parse("{\"pbuffs\":{\"1\":[{\"id\":\"99:1\",\"lv\":1,\"age\":1}],\"2\":[],\"3\":[{\"id\":\"15:3\",\"lv\":2,\"age\":9.5}]}}");
		IReadOnlyList<GStruct3> readOnlyList6 = new List<GStruct3>
		{
			new GStruct3
			{
				bool_0 = false,
				ushort_0 = 7,
				ushort_1 = 8,
				int_1 = 4,
				float_0 = 30f
			},
			new GStruct3
			{
				bool_0 = true,
				ushort_0 = 5,
				ushort_1 = 6,
				int_1 = 1,
				float_0 = 0f
			}
		};
		IReadOnlyDictionary<uint, IReadOnlyList<GStruct2>> readOnlyDictionary = Class119.smethod_33(jobject_, new uint[3] { 1u, 2u, 4u }, ilist_, readOnlyList6);
		num += smethod_243("party-buff/self_uses_own_source", readOnlyDictionary.ContainsKey(1u) && readOnlyDictionary[1u].Count == 1 && readOnlyDictionary[1u][0].ushort_0 == 7 && readOnlyDictionary[1u][0].ushort_1 == 8 && readOnlyDictionary[1u][0].int_0 == 4 && readOnlyDictionary[1u][0].float_0 == 30f);
		num += smethod_243("party-buff/empty_array_is_known", readOnlyDictionary.ContainsKey(2u) && readOnlyDictionary[2u].Count == 0);
		num += smethod_243("party-buff/missing_key_is_unreadable", !readOnlyDictionary.ContainsKey(4u));
		num += smethod_243("party-buff/stale_visible_player_excluded", !readOnlyDictionary.ContainsKey(3u));
		Class145 @class = Class145.class145_0.method_96(ilist_, Class95.class95_0, readOnlyList6, default(GStruct4), Class446.class446_0, 1, 0, readOnlyDictionary, new uint[3] { 1u, 2u, 4u }, readOnlyList5, null, default(Struct26));
		num += smethod_243("party-roster/published_with_census", @class.method_14() != null && @class.method_14().Count == 3 && @class.method_14()[2] == 4);
		num += smethod_243("party-roster/survives_self_update", @class.method_93(null, 1, 0).method_14() != null && @class.method_93(null, 1, 0).method_14().Count == 3);
		num += smethod_243("party-present/published_and_survives_self_update", @class.method_16() != null && @class.method_16().Count == 2 && @class.method_93(null, 1, 0).method_16() != null && @class.method_93(null, 1, 0).method_16().Count == 2);
		@class = @class.method_96(ilist_, Class95.class95_0, readOnlyList6, default(GStruct4), Class446.class446_0, 2, 0, new Dictionary<uint, IReadOnlyList<GStruct2>>(), readOnlyList2, readOnlyList4, null, default(Struct26));
		num += smethod_243("party-roster/next_census_replaces_with_solo", @class.method_14() != null && @class.method_14().Count == 0);
		num += smethod_243("party-present/next_census_replaces_ids", @class.method_16() != null && @class.method_16().Count == 0);
		num += smethod_243("party-buff/absent_fact_is_due", GClass19.smethod_1(new List<GStruct2>(), 7, 8, 5));
		num += smethod_243("party-buff/expired_fact_is_due", GClass19.smethod_1(new List<GStruct2>
		{
			new GStruct2
			{
				ushort_0 = 7,
				ushort_1 = 8,
				float_0 = 4.9f
			}
		}, 7, 8, 5));
		num += smethod_243("party-buff/fresh_fact_is_not_due", !GClass19.smethod_1(new List<GStruct2>
		{
			new GStruct2
			{
				ushort_0 = 7,
				ushort_1 = 8,
				float_0 = 5.1f
			}
		}, 7, 8, 5));
		num += smethod_243("party-buff/empty_slot_is_not_due", !GClass19.smethod_1(new List<GStruct2>(), ushort.MaxValue, ushort.MaxValue, 5));
		num += smethod_243("party-helper/null_form", !((GForm0)null).smethod_4());
		GForm0 gForm = (GForm0)FormatterServices.GetUninitializedObject(typeof(GForm0));
		num += smethod_243("party-helper/no_session", !gForm.smethod_4());
		Class119 class2 = (Class119)FormatterServices.GetUninitializedObject(typeof(Class119));
		typeof(GForm0).GetField("_session", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, class2);
		typeof(Class119).GetField("_world", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(class2, @class);
		num += smethod_243("party-helper/confirmed_solo", !gForm.smethod_4());
		Class145 value = @class.method_96(ilist_, Class95.class95_0, readOnlyList6, default(GStruct4), Class446.class446_0, 3, 0, readOnlyDictionary, new uint[2] { 1u, 2u }, null, null, default(Struct26));
		typeof(Class119).GetField("_world", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(class2, value);
		num += smethod_243("party-helper/roster_present", gForm.smethod_4());
		Console.WriteLine("player-buff-census: " + num + " failed");
		return num;
	}

	internal static int smethod_297()
	{
		int num = 0;
		Class95 class95_ = new Class95(null, null, new Dictionary<string, string>
		{
			{ "11", "Me" },
			{ "22", "Friend" },
			{ "33", "Leader" }
		});
		List<Class403> list = new List<Class403>
		{
			new Class403
			{
				byte_0 = 100,
				uint_0 = 11u,
				byte_1 = 4,
				float_0 = 0f
			},
			new Class403
			{
				byte_0 = 100,
				uint_0 = 22u,
				float_0 = 7f,
				float_1 = 2f,
				float_2 = 3f
			},
			new Class403
			{
				byte_0 = 100,
				uint_0 = 33u,
				byte_1 = 8,
				float_0 = 12f
			}
		};
		Class145 @class = Class145.class145_0.method_96(list, class95_, null, default(GStruct4), Class446.class446_0, 1, 0, null, new uint[3] { 11u, 22u, 33u }, new uint[3] { 11u, 22u, 33u }, null, default(Struct26));
		DateTime dateTime = new DateTime(2026, 9, 22, 0, 0, 0, DateTimeKind.Utc);
		@class = @class.method_96(list, class95_, null, default(GStruct4), Class446.class446_0, 1, 0, null, new uint[3] { 11u, 22u, 33u }, new uint[3] { 11u, 22u, 33u }, new Dictionary<uint, GStruct0> { 
		{
			11u,
			new GStruct0
			{
				byte_0 = 2,
				ushort_0 = 77
			}
		} }, default(Struct26));
		Class145 class2 = @class.method_93(new Class83
		{
			long_0 = 1234L,
			float_0 = 4f,
			float_1 = 5f,
			float_2 = 6f,
			byte_0 = 1
		}, 1, 0);
		Class401 class3 = Class38.smethod_0(class2, "Me", dateTime);
		num = 0 + smethod_243("party-follow/self-snapshot-builds-shm-slot", class3 != null && class3.uint_0 == 11 && class3.string_0 == "Me" && class3.float_0 == 4f && class3.float_1 == 5f && class3.float_2 == 6f && class3.bool_1 && class3.byte_0 == 1 && class3.bool_2 && class3.byte_1 == 2 && class3.ushort_0 == 77 && class3.long_0 == dateTime.Ticks);
		string text = Class174.smethod_1(class3, 1234L);
		num += smethod_243("party-follow/shm-update-log-has-live-fields", text.Contains("[PartySHM] update") && text.Contains("id=11") && text.Contains("name=\"Me\"") && text.Contains("actor=1") && text.Contains("pos=(4.00,5.00,6.00)") && text.Contains("target=2:77") && text.Contains("self_stamp_ms=1234"));
		num += smethod_243("party-follow/diagnostic-log-throttles-one-second", Class174.smethod_0(-1000L, 0L) && !Class174.smethod_0(0L, 999L) && Class174.smethod_0(0L, 1000L));
		num += smethod_243("party-follow/no-party-clears-shm-slot", Class38.smethod_0(class2.method_96(list, class95_, null, default(GStruct4), Class446.class446_0, 2, 0, null, new uint[0], new uint[1] { 11u }, null, default(Struct26)), "Me", dateTime) == null);
		Class401[] array = new Class401[2]
		{
			new Class401
			{
				uint_0 = 22u,
				string_0 = "Friend",
				float_0 = 99f,
				long_0 = dateTime.Ticks,
				bool_0 = false
			},
			new Class401
			{
				uint_0 = 33u,
				string_0 = "Leader",
				float_0 = 90f,
				long_0 = dateTime.Ticks,
				bool_0 = true
			}
		};
		Class31 class4 = Class38.smethod_8(@class, "Friend", bool_0: false, array, dateTime);
		num += smethod_243("party-follow/fresh-local-position-wins", class4 != null && !class4.bool_0 && class4.uint_0 == 22 && class4.float_0 == 99f);
		class4 = Class38.smethod_8(@class, "Friend", bool_0: false, new Class401[1]
		{
			new Class401
			{
				uint_0 = 9001u,
				string_0 = "Friend",
				float_0 = 77f,
				byte_0 = 1,
				bool_1 = true,
				long_0 = dateTime.Ticks
			}
		}, dateTime);
		num += smethod_243("party-follow/shm-name-maps-to-local-party-id", class4 != null && !class4.bool_0 && class4.uint_0 == 22 && class4.float_0 == 77f && class4.bool_1 && class4.byte_0 == 1);
		Class31 class5 = Class38.smethod_8(@class, null, bool_0: true, new Class401[1]
		{
			new Class401
			{
				uint_0 = 9002u,
				string_0 = "Leader",
				float_0 = 88f,
				bool_0 = true,
				byte_0 = 1,
				bool_1 = true,
				long_0 = dateTime.Ticks
			}
		}, dateTime);
		num += smethod_243("party-follow/shm-leader-name-maps-to-local-party-id", class5 != null && !class5.bool_0 && class5.uint_0 == 33 && class5.float_0 == 88f && class5.byte_0 == 1);
		num += smethod_243("party-follow/shm-name-outside-party-is-rejected", Class38.smethod_8(@class, "Stranger", bool_0: false, new Class401[1]
		{
			new Class401
			{
				uint_0 = 22u,
				string_0 = "Stranger",
				float_0 = 66f,
				long_0 = dateTime.Ticks
			}
		}, dateTime) == null);
		string text2 = Class174.smethod_3(class4, new Class83
		{
			float_0 = 130f,
			float_1 = 5f,
			float_2 = 0f
		}, 110f, 7f, 0f, bool_0: true, 20f, 40f);
		num += smethod_243("party-follow/move-log-has-source-and-destination", text2.Contains("[PartyFollow] move") && text2.Contains("source=shm") && text2.Contains("id=22") && text2.Contains("dest=(110.00,7.00,0.00)") && text2.Contains("gap=20.00 radius=40.00"));
		Class31 class6 = Class38.smethod_8(@class, null, bool_0: true, array, dateTime);
		num += smethod_243("party-follow/fresh-local-leader-wins", class6 != null && !class6.bool_0 && class6.uint_0 == 33 && class6.float_0 == 90f);
		num += smethod_244("party-follow/leader-name-from-snapshot", "Leader", Class38.smethod_3(@class));
		Class31 class7 = Class38.smethod_8(@class, null, bool_0: true, new Class401[1]
		{
			new Class401
			{
				uint_0 = 9002u,
				string_0 = "Leader",
				float_0 = 91f,
				bool_0 = false,
				long_0 = dateTime.Ticks
			}
		}, dateTime);
		num += smethod_243("party-follow/leader-mode-matches-snapshot-name", class7 != null && !class7.bool_0 && class7.uint_0 == 33 && class7.float_0 == 91f);
		class4 = Class38.smethod_8(@class, "Friend", bool_0: false, array, dateTime.AddSeconds(3.0));
		num += smethod_243("party-follow/stale-local-falls-back-to-census", class4 != null && class4.bool_0 && class4.uint_0 == 22 && class4.float_0 == 7f);
		IReadOnlyList<string> readOnlyList = Class38.smethod_2(@class);
		num += smethod_243("party-follow/picker-lists-other-party-members", readOnlyList.Count == 2 && readOnlyList[0] == "Friend" && readOnlyList[1] == "Leader");
		Class145 class145_ = Class145.class145_0.method_96(new List<Class403> { list[0] }, class95_, null, default(GStruct4), Class446.class446_0, 2, 0, null, new uint[3] { 11u, 22u, 33u }, new uint[1] { 11u }, null, default(Struct26));
		class4 = Class38.smethod_8(class145_, "Friend", bool_0: false, array, dateTime);
		num += smethod_243("party-follow/local-shared-fallback", class4 != null && !class4.bool_0 && class4.uint_0 == 22 && class4.float_0 == 99f);
		Class31 class31_ = Class38.smethod_8(@class, "Friend", bool_0: false, array, dateTime);
		num += smethod_243("party-follow/visible-host-builds-blue-zone", Class38.smethod_5(@class, class31_, 100, out var class348_) && class348_.uint_0 == 22 && class348_.float_0 == 99f && class348_.float_1 == 0f && class348_.float_2 == 0f && class348_.int_0 == 100);
		num += smethod_243("party-follow/shm-only-host-hides-blue-zone", !Class38.smethod_5(class145_, class4, 100, out class348_));
		num += smethod_243("party-follow/invalid-radius-hides-blue-zone", !Class38.smethod_5(@class, class31_, -1, out class348_));
		Class390 class8 = new Class390();
		num += smethod_243("party-follow/first-blue-zone-sample-sends", class8.method_0(class348_ = new Class348
		{
			uint_0 = 22u,
			float_0 = 7f,
			float_1 = 2f,
			float_2 = 3f,
			int_0 = 100
		}));
		num += smethod_243("party-follow/unchanged-blue-zone-does-not-resend", !class8.method_0(class348_));
		num += smethod_243("party-follow/moved-blue-zone-sends", class8.method_0(new Class348
		{
			uint_0 = 22u,
			float_0 = 8f,
			float_1 = 2f,
			float_2 = 3f,
			int_0 = 100
		}));
		num += smethod_243("party-follow/resized-blue-zone-sends", class8.method_0(new Class348
		{
			uint_0 = 22u,
			float_0 = 8f,
			float_1 = 2f,
			float_2 = 3f,
			int_0 = 120
		}));
		num += smethod_243("party-follow/visible-blue-zone-hides-once", class8.method_1() && !class8.method_1());
		class4 = Class38.smethod_8(class145_, "Friend", bool_0: false, array, dateTime.AddSeconds(3.0));
		num += smethod_243("party-follow/stale-shared-rejected", class4 == null);
		list.Add(new Class403
		{
			byte_0 = 2,
			uint_0 = 88u,
			ushort_2 = 100
		});
		Class145 class145_2 = Class145.class145_0.method_96(list, class95_, null, default(GStruct4), Class446.class446_0, 4, 0, null, new uint[3] { 11u, 22u, 33u }, new uint[3] { 11u, 22u, 33u }, new Dictionary<uint, GStruct0> { 
		{
			22u,
			new GStruct0
			{
				byte_0 = 2,
				ushort_0 = 88
			}
		} }, default(Struct26));
		class4 = Class38.smethod_8(class145_2, "Friend", bool_0: false, null, dateTime);
		num += smethod_243("party-follow/visible-member-monster", Class38.smethod_7(class145_2, class4, 10f) == 88);
		Class31 class9 = Class38.smethod_8(class145_2, "Friend", bool_0: false, new Class401[1]
		{
			new Class401
			{
				uint_0 = 9001u,
				string_0 = "Friend",
				float_0 = 7f,
				float_1 = 2f,
				float_2 = 3f,
				byte_0 = 2,
				bool_1 = true,
				bool_2 = true,
				byte_1 = 2,
				ushort_0 = 88,
				long_0 = dateTime.Ticks
			}
		}, dateTime);
		num += smethod_243("party-follow/remapped-shm-drives-shared-target-data", class9 != null && class9.uint_0 == 22 && Class38.smethod_7(class145_2, class9, 10f) == 88);
		class9.byte_0 = 0;
		num += smethod_243("party-follow/idle-host-cannot-drive-shared-attack", Class38.smethod_7(class145_2, class9, 10f) == 0);
		num += smethod_243("party-follow/outside-attack-radius", Class38.smethod_7(class145_2, class4, 5f) == 0);
		num += smethod_243("party-follow/host-zone-ignores-height", Class38.smethod_6(new Class403
		{
			byte_0 = 2,
			uint_0 = 89u,
			float_0 = 8f,
			float_1 = 100f,
			float_2 = 3f
		}, class4, 2f));
		num += smethod_243("party-follow/rejects-monster-outside-host-zone", !Class38.smethod_6(new Class403
		{
			byte_0 = 2,
			uint_0 = 90u,
			float_0 = 25f,
			float_2 = 3f
		}, class4, 10f));
		num += smethod_243("party-follow/absent-member-cannot-drive-attack", Class38.smethod_7(class145_, Class38.smethod_8(class145_, "Friend", bool_0: false, array, dateTime), 100f) == 0);
		num += smethod_243("party-follow/fresh-shared-host-position-bounds-attack", Class38.smethod_7(class145_2, Class38.smethod_8(class145_2, "Friend", bool_0: false, array, dateTime), 10f) == 0);
		Class145 class145_3 = Class145.class145_0.method_96(new List<Class403> { list[0] }, class95_, null, default(GStruct4), Class446.class446_0, 3, 0, null, new uint[0], new uint[1] { 11u }, null, default(Struct26));
		num += smethod_243("party-follow/not-in-party-rejected", Class38.smethod_8(class145_3, "Friend", bool_0: false, array, dateTime) == null);
		num += smethod_243("party-follow/never-follow-own-shared-record", Class38.smethod_8(class145_, "Me", bool_0: false, new Class401[1]
		{
			new Class401
			{
				uint_0 = 11u,
				string_0 = "Me",
				long_0 = dateTime.Ticks
			}
		}, dateTime) == null);
		Class441 class10 = new Class441();
		Class31 class11 = new Class31
		{
			uint_0 = 22u,
			float_0 = 100f,
			float_2 = 0f,
			long_0 = 1L,
			bool_0 = false
		};
		num += smethod_243("party-follow/first-sample-is-stationary", !class10.method_0(class11, dateTime));
		class11.float_0 = 102f;
		class11.long_0 = 2L;
		num += smethod_243("party-follow/new-position-is-moving", class10.method_0(class11, dateTime.AddMilliseconds(100.0)));
		num += smethod_243("party-follow/motion-survives-repeated-sample", class10.method_0(class11, dateTime.AddMilliseconds(300.0)));
		num += smethod_243("party-follow/unchanged-position-becomes-stationary", !class10.method_0(class11, dateTime.AddMilliseconds(800.0)));
		class11.bool_1 = true;
		class11.byte_0 = 1;
		num += smethod_243("party-follow/shared-actor-one-means-moving", class10.method_0(class11, dateTime.AddMilliseconds(900.0)));
		class11.byte_0 = 0;
		num += smethod_243("party-follow/shared-actor-zero-means-stationary", !class10.method_0(class11, dateTime.AddMilliseconds(1000.0)));
		float float_;
		float float_2;
		float float_3;
		bool flag = Class38.smethod_1(130f, 5f, 0f, 100f, 7f, 0f, bool_0: true, 20f, 40f, out float_, out float_2, out float_3);
		num += smethod_243("party-follow/walks-inside-trigger-radius", flag && float_ < 120f && float_ > 100f && float_2 == 7f && Math.Abs(float_3) < 0.01f);
		num += smethod_243("party-follow/idle-inside-host-zone-does-not-walk", !Class38.smethod_1(130f, 5f, 0f, 100f, 7f, 0f, bool_0: false, 20f, 40f, out float_, out float_2, out float_3));
		num += smethod_243("party-follow/idle-outside-host-zone-walks-to-catch-up-gap", Class38.smethod_1(150f, 5f, 0f, 100f, 7f, 0f, bool_0: false, 20f, 40f, out float_, out float_2, out float_3) && float_ < 120f && float_ > 100f);
		num += smethod_243("party-follow/gap-larger-than-host-zone-enters-zone", Class38.smethod_1(150f, 5f, 0f, 100f, 7f, 0f, bool_0: false, 60f, 40f, out float_, out float_2, out float_3) && float_ < 140f && float_ > 100f);
		Class102 class12 = new Class102();
		IReadOnlyList<Class401> readOnlyList2 = class12.method_0(array, dateTime);
		num += smethod_243("party-follow/transient-empty-keeps-shm-sample", class12.method_0(new Class401[0], dateTime.AddMilliseconds(300.0)).Count == readOnlyList2.Count);
		num += smethod_243("party-follow/expired-shm-sample-is-dropped", class12.method_0(new Class401[0], dateTime.AddSeconds(3.0)).Count == 0);
		num += smethod_243("party-follow/zero-radius-still-avoids-overlap", Class38.smethod_1(10f, 0f, 0f, 0f, 0f, 0f, bool_0: true, 0f, 0f, out float_, out float_2, out float_3) && float_ >= 2f);
		num += smethod_243("party-follow/overlap-walks-away-from-member", Class38.smethod_1(0f, 0f, 0f, 0f, 0f, 0f, bool_0: false, 20f, 40f, out float_, out float_2, out float_3) && Math.Sqrt(float_ * float_ + float_3 * float_3) >= 2.0);
		num += smethod_243("party-follow/near-overlap-walks-away-from-member", Class38.smethod_1(1f, 0f, 0f, 0f, 0f, 0f, bool_0: false, 20f, 40f, out float_, out float_2, out float_3) && float_ >= 2f);
		string string_ = "Local\\CapybaraPartyFollowTest_" + Guid.NewGuid().ToString("N");
		Class64 class13 = new Class64(string_);
		try
		{
			Class64 class14 = new Class64(string_);
			try
			{
				class13.method_0(new Class401
				{
					uint_0 = 22u,
					string_0 = "Friend",
					float_0 = 24f,
					float_1 = 2f,
					float_2 = 4f,
					byte_0 = 1,
					bool_1 = true,
					bool_2 = true,
					byte_1 = 2,
					ushort_0 = 88,
					long_0 = DateTime.UtcNow.Ticks
				});
				IReadOnlyList<Class401> readOnlyList3 = class14.method_1(DateTime.UtcNow);
				num += smethod_243("party-follow/local-map-publishes-across-readers", readOnlyList3.Count == 1 && readOnlyList3[0].uint_0 == 22 && readOnlyList3[0].float_0 == 24f && readOnlyList3[0].bool_1 && readOnlyList3[0].byte_0 == 1 && readOnlyList3[0].bool_2 && readOnlyList3[0].byte_1 == 2 && readOnlyList3[0].ushort_0 == 88);
				class13.method_2();
				num += smethod_243("party-follow/clear-removes-presence", class14.method_1(DateTime.UtcNow).Count == 0);
			}
			finally
			{
				((IDisposable)class14).Dispose();
			}
		}
		finally
		{
			((IDisposable)class13).Dispose();
		}
		using (Class119 class15 = new Class119())
		{
			Class248 class16 = new Class248();
			class16.list_0 = new List<string>();
			class15.method_30(class16.method_0);
			smethod_94(class15, "_world", Class145.class145_0.method_93(new Class83
			{
				float_0 = 10f,
				float_1 = 5f,
				float_2 = 20f
			}, 1, 0));
			MethodInfo methodInfo = typeof(Class119).GetMethod("method_130", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			num += smethod_243("party-follow/attack-stop-helper-available", methodInfo != null);
			if (methodInfo != null)
			{
				Class316 class17 = new Class316();
				((Task)methodInfo.Invoke(class15, null)).GetAwaiter().GetResult();
				num += smethod_243("party-follow/attack-stop-moves-twice-in-order", class16.list_0.Count == 3 && class16.list_0[0] == Class15.smethod_2() && class16.list_0[1] == Class346.smethod_0(12f, 5f, 20f, bool_0: false) && class16.list_0[2] == Class346.smethod_0(8f, 5f, 20f, bool_0: false));
				((Task)methodInfo.Invoke(class15, null)).GetAwaiter().GetResult();
				num += smethod_243("party-follow/attack-stop-is-idempotent-until-next-attack", class16.list_0.Count == 3);
				class15.method_127(88u);
				((Task)methodInfo.Invoke(class15, null)).GetAwaiter().GetResult();
				num += smethod_243("party-follow/new-attack-resets-stop-flag", class16.list_0.Count == 7 && class16.list_0[3] == Class15.smethod_0(88u) && class16.list_0[4] == Class15.smethod_2() && class16.list_0[5] == Class346.smethod_0(12f, 5f, 20f, bool_0: false) && class16.list_0[6] == Class346.smethod_0(8f, 5f, 20f, bool_0: false));
				class17.taskCompletionSource_0 = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
				class15.method_29(class17.method_0);
				class15.method_127(89u);
				class16.list_0.Clear();
				Task obj = (Task)methodInfo.Invoke(class15, null);
				class15.method_128(90u);
				class17.taskCompletionSource_0.SetResult(result: true);
				obj.GetAwaiter().GetResult();
				num += smethod_243("party-follow/new-target-cancels-old-stop-nudge", class16.list_0.Count == 3 && class16.list_0[0] == Class15.smethod_2() && class16.list_0[1] == Class346.smethod_0(12f, 5f, 20f, bool_0: false) && class16.list_0[2] == Class15.smethod_1(90u));
				class15.method_29(Class299.class299_0.method_169);
				((Task)methodInfo.Invoke(class15, null)).GetAwaiter().GetResult();
				num += smethod_243("party-follow/new-selection-resets-stop-flag", class16.list_0.Count == 6 && class16.list_0[3] == Class15.smethod_2() && class16.list_0[4] == Class346.smethod_0(12f, 5f, 20f, bool_0: false) && class16.list_0[5] == Class346.smethod_0(8f, 5f, 20f, bool_0: false));
			}
		}
		Console.WriteLine("party-follow: " + num + " failed");
		return num;
	}

	internal static int smethod_298()
	{
		Class236 @class = new Class236();
		int num = 0;
		Class95 class95_ = new Class95(null, null, new Dictionary<string, string>
		{
			{ "1", "Me" },
			{ "2", "Friend" },
			{ "3", "Leader" },
			{ "4", "Stranger" },
			{ "5", "Gone" }
		});
		@class.class145_0 = Class145.class145_0.method_96(new List<Class403>
		{
			new Class403
			{
				byte_0 = 100,
				uint_0 = 1u,
				byte_1 = 4
			},
			new Class403
			{
				byte_0 = 100,
				uint_0 = 2u,
				float_0 = 4f
			},
			new Class403
			{
				byte_0 = 100,
				uint_0 = 3u,
				byte_1 = 8,
				float_0 = 8f
			},
			new Class403
			{
				byte_0 = 100,
				uint_0 = 4u,
				float_0 = 12f
			}
		}, class95_, null, default(GStruct4), Class446.class446_0, 1, 0, null, new uint[4] { 1u, 2u, 3u, 5u }, new uint[3] { 1u, 2u, 3u }, null, default(Struct26));
		List<Class381> list = Class46.smethod_0(@class.class145_0, bool_0: false);
		num = 0 + smethod_243("party-follow-picker/all-visible-players", list.Count == 4 && list.Any(Class299.class299_0.method_170) && list.All(Class299.class299_0.method_171));
		List<Class381> list2 = Class46.smethod_0(@class.class145_0, bool_0: true);
		num += smethod_243("party-follow-picker/leader-first", list2.Count == 4 && list2[0].string_0 == "Leader" && list2.Any(Class299.class299_0.method_172) && list2.All(Class299.class299_0.method_173));
		Form4 form = new Form4(@class.method_0);
		try
		{
			form.method_3();
			TabControl tabControl = form.Controls.OfType<TabControl>().Single();
			num += smethod_243("party-follow-picker/two-tabs", tabControl.TabPages.Count == 2 && tabControl.TabPages[0].Text == "All players" && tabControl.TabPages[1].Text == "Party members");
			num += smethod_243("party-follow-picker/choose-current-player", form.method_4(2u, bool_0: false) && form.method_0() == "Friend");
			num += smethod_243("party-follow-picker/never-follow-self", !form.method_4(1u, bool_0: true));
			@class.class145_0 = Class145.class145_0.method_96(new List<Class403>
			{
				new Class403
				{
					byte_0 = 100,
					uint_0 = 1u,
					byte_1 = 4
				},
				new Class403
				{
					byte_0 = 100,
					uint_0 = 3u,
					byte_1 = 8,
					float_0 = 9f
				}
			}, class95_, null, default(GStruct4), Class446.class446_0, 2, 0, null, new uint[4] { 1u, 2u, 3u, 5u }, new uint[2] { 1u, 3u }, null, default(Struct26));
			form.method_3();
			num += smethod_243("party-follow-picker/reads-latest-snapshot", tabControl.TabPages[0].Controls.OfType<DataGridView>().Single().Rows.Count == 2 && !form.method_4(2u, bool_0: false));
		}
		finally
		{
			((IDisposable)form).Dispose();
		}
		Console.WriteLine("party-follow-picker: " + num + " failed");
		return num;
	}

	internal static int smethod_299()
	{
		int num = 0;
		num = 0 + smethod_243("remote-target/public_sidecar_exists", typeof(Class145).GetProperty("RemotePlayerTargets") != null);
		List<Class403> ilist_ = new List<Class403>
		{
			new Class403
			{
				byte_0 = 100,
				uint_0 = 101u
			},
			new Class403
			{
				byte_0 = 100,
				uint_0 = 102u,
				byte_1 = 4
			},
			new Class403
			{
				byte_0 = 100,
				uint_0 = 103u
			}
		};
		IReadOnlyDictionary<uint, GStruct0> readOnlyDictionary = Class119.smethod_34(JObject.Parse("{\"ptargets\":{\"101\":{\"t\":2,\"id\":777},\"102\":{\"t\":0,\"id\":0},\"103\":{\"t\":2,\"id\":779},\"bad\":{\"t\":2,\"id\":780},\"104\":{\"t\":256,\"id\":781}}}"), new uint[2] { 101u, 102u }, ilist_);
		num += smethod_243("remote-target/visible_party_targets_published", readOnlyDictionary != null && readOnlyDictionary.Count == 2 && readOnlyDictionary.ContainsKey(101u) && readOnlyDictionary[101u].byte_0 == 2 && readOnlyDictionary[101u].ushort_0 == 777 && readOnlyDictionary.ContainsKey(102u) && readOnlyDictionary[102u].byte_0 == 0 && readOnlyDictionary[102u].ushort_0 == 0);
		num += smethod_243("remote-target/nonparty_and_malformed_excluded", readOnlyDictionary != null && !readOnlyDictionary.ContainsKey(103u) && !readOnlyDictionary.ContainsKey(104u));
		Class145 @class = Class145.class145_0.method_96(ilist_, Class95.class95_0, null, default(GStruct4), Class446.class446_0, 1, 0, null, new uint[2] { 101u, 102u }, null, readOnlyDictionary, default(Struct26));
		num += smethod_243("remote-target/world_publishes_and_self_update_retains_sidecar", @class.method_20().ContainsKey(101u) && @class.method_93(null, 2, 0).method_20().ContainsKey(101u));
		num += smethod_244("remote-target/next_census_clears_prior_target", 0, @class.method_95(ilist_, Class95.class95_0, null, default(GStruct4), 2, 0).method_20().Count);
		string text = Class119.smethod_61() ?? string.Empty;
		num += smethod_243("remote-target/embedded_agent_reads_and_sends_sidecar", text.Contains("isSelf && !playerPtr.isNull()") && text.Contains("playerPtr.add(o.pcTarget)") && text.Contains("cc.add(o.ccTarget)") && text.Contains("const targetId = target.add(o.targetId).readU16();") && text.Contains("ptargets,"));
		Console.WriteLine("remote-player-target-census: " + num + " failed");
		return num;
	}
}
