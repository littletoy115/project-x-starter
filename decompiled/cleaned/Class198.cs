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
			JObject val = JObject.Parse(string_0);
			if ((string)val[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141308140))
			{
				class119_0.method_145((uint)val[Class185.smethod_0(-1141293578)], (byte)val[Class185.smethod_0(-1141255953)], (uint)val[Class185.smethod_0(-1141255964)], bool_17: true, null);
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
			if (string_0.IndexOf(Class185.smethod_0(-1141255614), StringComparison.Ordinal) >= 0)
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
			return new Class175(Class185.smethod_0(-1141254975), string_0, Class185.smethod_0(-1141255009), Class185.smethod_0(-1141255026));
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
			if (string_6 == Class185.smethod_0(-1141303611))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141303627));
			}
			if (string_6.Contains(Class185.smethod_0(-1141303685)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141296459));
			}
			if (string_6.Contains(Class185.smethod_0(-1141252736)))
			{
				return Class71.Class72.smethod_0(bool_6 ? Class185.smethod_0(-1141259106) : string.Empty);
			}
			if (string_6.StartsWith(Class185.smethod_0(-1141253974)))
			{
				int_0++;
				if (!bool_0)
				{
					return Class71.Class72.smethod_0(Class185.smethod_0(-1141253978));
				}
				return Class71.Class72.smethod_1(Class185.smethod_0(-1141253999));
			}
			if (string_6.Contains(Class185.smethod_0(-1141255360)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141255374));
			}
			if (string_6.Contains(Class185.smethod_0(-1141255417)))
			{
				return Class71.Class72.smethod_0(long_0.ToString());
			}
			if (string_6.Contains(Class185.smethod_0(-1141255434)))
			{
				return Class71.Class72.smethod_0((string_6.Contains(Class185.smethod_0(-1141259125)) ? string_3 : string_1) + Class185.smethod_0(-1141259132));
			}
			if (string_6.Contains(Class185.smethod_0(-1141259147)))
			{
				return Class71.Class72.smethod_0(string_3);
			}
			if (string_6.Contains(Class185.smethod_0(-1141255380)))
			{
				return Class71.Class72.smethod_0(string_2);
			}
			if (string_6.Contains(Class185.smethod_0(-1141259200)) && string_6.Contains(Class185.smethod_0(-1141259204)))
			{
				if (!bool_2)
				{
					return Class71.Class72.smethod_0(string.Empty);
				}
				return Class71.Class72.smethod_1(Class185.smethod_0(-1141259230));
			}
			if (string_6.Contains(Class185.smethod_0(-1141259250)))
			{
				if (bool_3)
				{
					string_1 = string_3;
					bool_4 = true;
					return Class71.Class72.smethod_1(Class185.smethod_0(-1141258267));
				}
				string_1 = string_3;
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_6.Contains(Class185.smethod_0(-1141258292)))
			{
				if (bool_5)
				{
					return Class71.Class72.smethod_1(Class185.smethod_0(-1141258344));
				}
				string_2 = string_3;
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_6.Contains(Class185.smethod_0(-1141258361)))
			{
				string_1 = string_0;
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_6.Contains(Class185.smethod_0(-1141258402)))
			{
				string_2 = string_0;
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_6.Contains(Class185.smethod_0(-1141258454)) && string_6.Contains(Class185.smethod_0(-1141258459)) && bool_1)
			{
				return Class71.Class72.smethod_1(Class185.smethod_0(-1141258481));
			}
			if (!string_6.Contains(Class185.smethod_0(-1141253201)) && !string_6.Contains(Class185.smethod_0(-1141258507)) && !string_6.Contains(Class185.smethod_0(-1141254283)))
			{
				return Class71.Class72.smethod_1(Class185.smethod_0(-1141258525) + string_6);
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
			if (string_0.IndexOf(Class185.smethod_0(-1141255614), StringComparison.Ordinal) >= 0)
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
			class270_0.list_0.Add(uint_0 + Class185.smethod_0(-1141297577) + string_1);
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
			if (string_3 == Class185.smethod_0(-1141303611))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141303627));
			}
			if (string_3.Contains(Class185.smethod_0(-1141303685)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141296459));
			}
			if (string_3.Contains(Class185.smethod_0(-1141255360)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141255374));
			}
			if (string_3.Contains(Class185.smethod_0(-1141255380)))
			{
				return Class71.Class72.smethod_0(string_0);
			}
			if (string_3.Contains(Class185.smethod_0(-1141255417)))
			{
				return Class71.Class72.smethod_0(long_0.ToString());
			}
			if (string_3.Contains(Class185.smethod_0(-1141255434)))
			{
				return Class71.Class72.smethod_0(string_0 + Class185.smethod_0(-1141255450));
			}
			return Class71.Class72.smethod_1(Class185.smethod_0(-1141255482) + string_3);
		}

		internal Class71.Class72 method_1(string string_1, string string_2, string string_3, int int_2)
		{
			if (!(string_3 == Class185.smethod_0(-1141303611)))
			{
				return func_0(string_1, string_2, string_3, int_2);
			}
			return Class71.Class72.smethod_1(Class185.smethod_0(-1141255507));
		}

		internal Class71.Class72 method_2(string string_1, string string_2, string string_3, int int_2)
		{
			if (!string_3.Contains(Class185.smethod_0(-1141255536)))
			{
				return func_0(string_1, string_2, string_3, int_2);
			}
			return Class71.Class72.smethod_0(Class185.smethod_0(-1141294339));
		}

		internal Class71.Class72 method_3(string string_1, string string_2, string string_3, int int_2)
		{
			if (!string_3.Contains(Class185.smethod_0(-1141303685)))
			{
				return func_0(string_1, string_2, string_3, int_2);
			}
			return Class71.Class72.smethod_1(Class185.smethod_0(-1141255575));
		}

		internal Class71.Class72 method_4(string string_1, string string_2, string string_3, int int_2)
		{
			if (!string_3.Contains(Class185.smethod_0(-1141255417)))
			{
				return func_0(string_1, string_2, string_3, int_2);
			}
			return Class71.Class72.smethod_0((long_0 - 1L).ToString());
		}

		internal Class71.Class72 method_5(string string_1, string string_2, string string_3, int int_2)
		{
			if (string_2 == Class185.smethod_0(-1141255586) && string_3.Contains(Class185.smethod_0(-1141255536)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141294339));
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
		private static readonly FieldInfo fieldInfo_0 = typeof(GForm0).GetField(Class185.smethod_0(-1141256027), BindingFlags.Instance | BindingFlags.NonPublic);

		private static readonly FieldInfo fieldInfo_1 = typeof(Class119).GetField(Class185.smethod_0(-1141259782), BindingFlags.Instance | BindingFlags.NonPublic);

		private static readonly FieldInfo fieldInfo_2 = typeof(Class119).GetField(Class185.smethod_0(-1141259787), BindingFlags.Instance | BindingFlags.NonPublic);

		private static readonly FieldInfo fieldInfo_3 = typeof(Class119).GetField(Class185.smethod_0(-1141259815), BindingFlags.Instance | BindingFlags.NonPublic);

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
			throw new InvalidOperationException(Class185.smethod_0(-1141258700));
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
			return (DataGridView)gform0_0.Controls.Find(Class185.smethod_0(-1141281134), searchAllChildren: true)[0];
		}

		internal void method_4(int int_0, int int_1, bool bool_0, string[] string_0)
		{
			int[] array = new int[6] { 1, 2, 3, 4, 5, 26 };
			for (int i = 0; i < array.Length; i++)
			{
				((RadioButton)gform0_0.Controls.Find(Class185.smethod_0(-1141259832) + array[i], searchAllChildren: true)[0]).Checked = array[i] == int_0;
			}
			int[] array2 = new int[5] { 18, 19, 20, 21, 22 };
			for (int j = 0; j < array2.Length; j++)
			{
				((RadioButton)gform0_0.Controls.Find(Class185.smethod_0(-1141259832) + array2[j], searchAllChildren: true)[0]).Checked = array2[j] == int_1;
			}
			int[] array3 = new int[8] { 29, 30, 31, 32, 33, 38, 43, 94 };
			for (int k = 0; k < array3.Length; k++)
			{
				((CheckBox)gform0_0.Controls.Find(Class185.smethod_0(-1141259842) + array3[k], searchAllChildren: true)[0]).Checked = array3[k] == 43 && bool_0;
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
			((CheckBox)gform0_0.Controls.Find(Class185.smethod_0(-1141276910), searchAllChildren: true)[0]).Checked = bool_0;
			for (int i = 1; i <= 10; i++)
			{
				bool flag = int_0 != null && Array.IndexOf(int_0, i) >= 0;
				((CheckBox)gform0_0.Controls.Find(Class185.smethod_0(-1141259842) + (5 + i), searchAllChildren: true)[0]).Checked = flag;
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
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			method_0(new JObject { [Class185.smethod_0(-1141308128)] = JToken.op_Implicit(Class185.smethod_0(-1141305020)) });
			return 1;
		}

		public void imethod_4(IntPtr intptr_1, Class63.Delegate15 delegate15_1, Class63.Delegate16 delegate16_0, IntPtr intptr_2)
		{
			delegate15_0 = delegate15_1;
			intptr_0 = intptr_2;
		}

		public void imethod_5(IntPtr intptr_1, string string_1, byte[] byte_0, int int_2)
		{
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Expected O, but got Unknown
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected O, but got Unknown
			JObject val = JObject.Parse(string_1);
			if ((string)val[Class185.smethod_0(-1141254460)] != Class185.smethod_0(-1141253277))
			{
				return;
			}
			jobject_0 = val;
			if (!bool_0)
			{
				int num = (int)val[Class185.smethod_0(-1141255964)] + int_0;
				if (string_0 == null)
				{
					method_0(new JObject
					{
						[Class185.smethod_0(-1141308128)] = JToken.op_Implicit(Class185.smethod_0(-1141253289)),
						[Class185.smethod_0(-1141303993)] = JToken.op_Implicit(true),
						[Class185.smethod_0(-1141255964)] = JToken.op_Implicit(num),
						[Class185.smethod_0(-1141253312)] = JToken.op_Implicit(1),
						[Class185.smethod_0(-1141253321)] = JToken.op_Implicit(Class185.smethod_0(-1141253344)),
						[Class185.smethod_0(-1141299845)] = JToken.op_Implicit((string)val[Class185.smethod_0(-1141299845)])
					});
				}
				else
				{
					method_0(new JObject
					{
						[Class185.smethod_0(-1141308128)] = JToken.op_Implicit(Class185.smethod_0(-1141253289)),
						[Class185.smethod_0(-1141303993)] = JToken.op_Implicit(false),
						[Class185.smethod_0(-1141255964)] = JToken.op_Implicit(num),
						[Class185.smethod_0(-1141253360)] = JToken.op_Implicit(string_0)
					});
				}
			}
		}

		public string imethod_6(IntPtr intptr_1)
		{
			return Class185.smethod_0(-1141253364);
		}

		public void imethod_7(IntPtr intptr_1)
		{
			list_0.Add(intptr_1);
		}

		private void method_0(JObject jobject_1)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			if (delegate15_0 == null)
			{
				return;
			}
			IntPtr hglobal = Marshal.StringToHGlobalAnsi(((JToken)new JObject
			{
				[Class185.smethod_0(-1141255953)] = JToken.op_Implicit(Class185.smethod_0(-1141253385)),
				[Class185.smethod_0(-1141253396)] = (JToken)(object)jobject_1
			}).ToString((Formatting)0, Array.Empty<JsonConverter>()));
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
			return Class71.Class72.smethod_1(Class185.smethod_0(-1141255659));
		}

		internal Class9 method_1()
		{
			list_0.Add(Class185.smethod_0(-1141252614));
			return new Class9(null, 27060);
		}

		internal string method_2(int int_4)
		{
			list_0.Add(Class185.smethod_0(-1141252619) + int_4);
			return null;
		}

		internal bool method_3()
		{
			list_0.Add(Class185.smethod_0(-1141252634));
			return true;
		}

		internal string method_4()
		{
			list_0.Add(Class185.smethod_0(-1141252644));
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
			list_1.Add(Class185.smethod_0(-1141252614));
			return new Class9(null, 27060);
		}

		internal string method_8(int int_4)
		{
			list_1.Add(Class185.smethod_0(-1141252657));
			return null;
		}

		internal bool method_9()
		{
			list_1.Add(Class185.smethod_0(-1141252634));
			return false;
		}

		internal string method_10()
		{
			list_1.Add(Class185.smethod_0(-1141252644));
			return null;
		}

		internal Class71.Class72 method_11(string string_0, int int_4)
		{
			list_2.Add(string_0);
			if (string_0.Contains(Class185.smethod_0(-1141252679)))
			{
				return Class71.Class72.smethod_0(bool_0 ? Class185.smethod_0(-1141252697) : Class185.smethod_0(-1141252679));
			}
			if (string_0.Contains(Class185.smethod_0(-1141252736)))
			{
				return Class71.Class72.smethod_0(bool_1 ? Class185.smethod_0(-1141252748) : string.Empty);
			}
			if (string_0 == Class185.smethod_0(-1141252767))
			{
				if (!bool_1)
				{
					return Class71.Class72.smethod_1(Class185.smethod_0(-1141252807));
				}
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252818));
			}
			if (string_0 == Class185.smethod_0(-1141252870))
			{
				if (!bool_1)
				{
					return Class71.Class72.smethod_1(Class185.smethod_0(-1141252807));
				}
				return Class71.Class72.smethod_0(func_0(4512, 100uL));
			}
			if (string_0 == Class185.smethod_0(-1141252899))
			{
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (!(string_0 == Class185.smethod_0(-1141252944)) && !(string_0 == Class185.smethod_0(-1141252971)))
			{
				if (string_0.Contains(Class185.smethod_0(-1141254214)))
				{
					bool_1 = false;
					return Class71.Class72.smethod_0(Class185.smethod_0(-1141254214));
				}
				if (string_0 == Class185.smethod_0(-1141253015))
				{
					bool_0 = false;
					return Class71.Class72.smethod_0(string.Empty);
				}
				if (string_0.Contains(Class185.smethod_0(-1141253058)))
				{
					return Class71.Class72.smethod_0(bool_0 ? string.Empty : Class185.smethod_0(-1141253058));
				}
				return Class71.Class72.smethod_0(string.Empty);
			}
			return Class71.Class72.smethod_0(string.Empty);
		}

		internal Class71.Class72 method_12(string string_0, int int_4)
		{
			list_3.Add(string_0);
			if (string_0.Contains(Class185.smethod_0(-1141252679)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141253083));
			}
			if (string_0.Contains(Class185.smethod_0(-1141252736)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252748));
			}
			if (string_0.EndsWith(Class185.smethod_0(-1141253114)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252818));
			}
			if (string_0.EndsWith(Class185.smethod_0(-1141252105)))
			{
				return Class71.Class72.smethod_0(func_0(4512, (++int_2 == 1) ? 100uL : 200uL));
			}
			if (string_0.Contains(Class185.smethod_0(-1141252125)))
			{
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_0.Contains(Class185.smethod_0(-1141252135)))
			{
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_0.Contains(Class185.smethod_0(-1141254214)))
			{
				bool_2 = false;
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141254244));
			}
			if (string_0.Contains(Class185.smethod_0(-1141254283)))
			{
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_0.Contains(Class185.smethod_0(-1141253058)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141253058));
			}
			return Class71.Class72.smethod_0(string.Empty);
		}

		internal Class71.Class72 method_13(string string_0, int int_4)
		{
			list_4.Add(string_0);
			if (string_0.Contains(Class185.smethod_0(-1141252679)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252679));
			}
			if (string_0.Contains(Class185.smethod_0(-1141252736)))
			{
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_0.Contains(Class185.smethod_0(-1141252135)))
			{
				return Class71.Class72.smethod_1(Class185.smethod_0(-1141252147));
			}
			return Class71.Class72.smethod_0(string.Empty);
		}

		internal Class71.Class72 method_14(string string_0, int int_4)
		{
			list_5.Add(string_0);
			if (string_0.Contains(Class185.smethod_0(-1141252679)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252679));
			}
			if (string_0.Contains(Class185.smethod_0(-1141252736)))
			{
				return new Class71.Class72(string.Empty, Class185.smethod_0(-1141252147), bool_2: true, bool_3: false, 0);
			}
			string_0.Contains(Class185.smethod_0(-1141252135));
			return Class71.Class72.smethod_0(string.Empty);
		}

		internal Class71.Class72 method_15(string string_0, int int_4)
		{
			list_6.Add(string_0);
			if (string_0.Contains(Class185.smethod_0(-1141252679)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141253083));
			}
			if (string_0.Contains(Class185.smethod_0(-1141252736)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252748));
			}
			if (string_0.EndsWith(Class185.smethod_0(-1141253114)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252818));
			}
			if (string_0.EndsWith(Class185.smethod_0(-1141252105)))
			{
				return Class71.Class72.smethod_0(func_0(4512, 100uL));
			}
			if (string_0.Contains(Class185.smethod_0(-1141252125)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252171));
			}
			if (string_0 == Class185.smethod_0(-1141252944))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252216));
			}
			if (string_0 == Class185.smethod_0(-1141252971))
			{
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_0 == Class185.smethod_0(-1141252316))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252362));
			}
			return Class71.Class72.smethod_0(string.Empty);
		}

		internal Class71.Class72 method_16(string string_0, int int_4)
		{
			list_7.Add(string_0);
			if (string_0.Contains(Class185.smethod_0(-1141252679)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252401) + int_3);
			}
			if (string_0 == Class185.smethod_0(-1141252428))
			{
				return Class71.Class72.smethod_0(int_3.ToString());
			}
			if (string_0.Contains(Class185.smethod_0(-1141252736)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252748));
			}
			if (string_0.EndsWith(Class185.smethod_0(-1141253114)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252818));
			}
			if (string_0.EndsWith(Class185.smethod_0(-1141252105)))
			{
				return Class71.Class72.smethod_0(func_0(4512, 100uL));
			}
			if (string_0.Contains(Class185.smethod_0(-1141252125)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252171));
			}
			if (string_0 == Class185.smethod_0(-1141252944))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252216));
			}
			if (string_0 == Class185.smethod_0(-1141252971))
			{
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_0 == Class185.smethod_0(-1141252316))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141252362));
			}
			if (string_0.Contains(Class185.smethod_0(-1141254316)))
			{
				int_3 = 4512;
				return Class71.Class72.smethod_0(string.Empty);
			}
			return Class71.Class72.smethod_0(string.Empty);
		}

		internal void method_17()
		{
			class327_0.method_0(7);
		}

		internal void method_18()
		{
			class327_1.method_1(Class185.smethod_0(-1141252485));
		}

		internal void method_19()
		{
			class327_2.method_1(Class185.smethod_0(-1141252485));
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
			string text = Class21.smethod_24(Encoding.UTF8.GetBytes(Class185.smethod_0(-1141259909)));
			string s = Class185.smethod_0(-1141259919) + text + Class185.smethod_0(-1141260054);
			byte_0 = Encoding.UTF8.GetBytes(s);
			string text2 = (bool_0 ? (Class185.smethod_0(-1141260093) + JsonConvert.SerializeObject((object)string_1)) : string.Empty);
			string_0 = Class185.smethod_0(-1141260100) + text2 + Class185.smethod_0(-1141260219) + byte_0.Length + Class185.smethod_0(-1141260276) + Class21.smethod_24(byte_0) + Class185.smethod_0(-1141259285) + text + Class185.smethod_0(-1141259469);
		}

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			string absolutePath = request.RequestUri.AbsolutePath;
			if (absolutePath.EndsWith(Class185.smethod_0(-1141259473), StringComparison.Ordinal))
			{
				return Task.FromResult<HttpResponseMessage>(smethod_0(string_0));
			}
			if (absolutePath.EndsWith(Class185.smethod_0(-1141259489), StringComparison.Ordinal))
			{
				return Task.FromResult<HttpResponseMessage>(smethod_1(byte_0));
			}
			return Task.FromResult<HttpResponseMessage>(new HttpResponseMessage(HttpStatusCode.NotFound));
		}

		private static HttpResponseMessage smethod_0(string string_1)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_0026: Expected O, but got Unknown
			return new HttpResponseMessage(HttpStatusCode.OK)
			{
				Content = (HttpContent)new StringContent(string_1, Encoding.UTF8, Class185.smethod_0(-1141264665))
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
			if (string_0.StartsWith(Class185.smethod_0(-1141256042), StringComparison.Ordinal))
			{
				class119_0.method_44(2L);
				smethod_250(class119_0, Class185.smethod_0(-1141256058), 2L);
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
			return Class179.smethod_2(class222_0.gform0_0, Class185.smethod_0(-1141299597), 0, 200, double.NaN);
		}

		internal Task<Enum9> method_3()
		{
			return Class179.smethod_2(class222_0.gform0_0, Class185.smethod_0(-1141299597), 0, 200, double.PositiveInfinity);
		}

		internal Task<Enum9> method_4()
		{
			return Class179.smethod_2(class222_0.gform0_0, Class185.smethod_0(-1141299597), 0, 200, -0.1);
		}

		internal Task<Enum9> method_5()
		{
			return Class179.smethod_2(class222_0.gform0_0, Class185.smethod_0(-1141299597), 0, 200, double.MaxValue);
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
			string text = Class185.smethod_0(-1141258552) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407));
			string_0 = Path.Combine(Path.GetTempPath(), text + Class185.smethod_0(-1141265149));
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
				Arguments = Class185.smethod_0(-1141258553) + int_0,
				UseShellExecute = false,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			});
			lock (object_0)
			{
				if (process_0 != null)
				{
					process.Dispose();
					throw new InvalidOperationException(Class185.smethod_0(-1141258593));
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
				throw new TimeoutException(Class185.smethod_0(-1141258654));
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
			if (string_0 == Class185.smethod_0(-1141252561))
			{
				manualResetEventSlim_0.Set();
				manualResetEventSlim_1.Wait(2000);
			}
			else if (string_0.Contains(Class185.smethod_0(-1141252572)))
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
			if (!(string_0 == Class185.smethod_0(-1141302136)))
			{
				return true;
			}
			return Class185.smethod_0(-1141255644);
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
			if (string_0.Contains(Class185.smethod_0(-1141256172)) && string_0.Contains(Class185.smethod_0(-1141255177) + class246_0.method_0()))
			{
				return string_0.Contains(Class185.smethod_0(-1141255200));
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
				throw new InvalidOperationException(Class185.smethod_0(-1141259857));
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
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			method_3(method_0(), new JObject { [Class185.smethod_0(-1141308128)] = JToken.op_Implicit(Class185.smethod_0(-1141305020)) });
			return 1;
		}

		public void imethod_4(IntPtr intptr_0, Class63.Delegate15 delegate15_0, Class63.Delegate16 delegate16_0, IntPtr intptr_1)
		{
			list_3.Add(new Class266(delegate15_0, intptr_1));
		}

		public void imethod_5(IntPtr intptr_0, string string_0, byte[] byte_0, int int_4)
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Expected O, but got Unknown
			//IL_0273: Expected O, but got Unknown
			JObject val = JObject.Parse(string_0);
			string text = (string)val[Class185.smethod_0(-1141254460)];
			list_1.Add(text);
			list_2.Add(text);
			if (text == Class185.smethod_0(-1141253277))
			{
				method_3(method_0(), new JObject
				{
					[Class185.smethod_0(-1141308128)] = JToken.op_Implicit(Class185.smethod_0(-1141253289)),
					[Class185.smethod_0(-1141303993)] = JToken.op_Implicit(true),
					[Class185.smethod_0(-1141255964)] = JToken.op_Implicit((int)val[Class185.smethod_0(-1141255964)]),
					[Class185.smethod_0(-1141253312)] = JToken.op_Implicit(1),
					[Class185.smethod_0(-1141253321)] = JToken.op_Implicit(Class185.smethod_0(-1141253344)),
					[Class185.smethod_0(-1141299845)] = JToken.op_Implicit((string)val[Class185.smethod_0(-1141299845)])
				});
			}
			else if (text == Class185.smethod_0(-1141253410))
			{
				int_1++;
				if (!bool_0)
				{
					jobject_1 = new JObject
					{
						[Class185.smethod_0(-1141308128)] = JToken.op_Implicit(Class185.smethod_0(-1141253437)),
						[Class185.smethod_0(-1141303993)] = JToken.op_Implicit(true),
						[Class185.smethod_0(-1141255964)] = JToken.op_Implicit((int)val[Class185.smethod_0(-1141255964)] + int_2),
						[Class185.smethod_0(-1141253449)] = JToken.op_Implicit(1),
						[Class185.smethod_0(-1141252634)] = JToken.op_Implicit(uint_0 + int_3),
						[Class185.smethod_0(-1141253472)] = JToken.op_Implicit(Class185.smethod_0(-1141253488)),
						[Class185.smethod_0(-1141264978)] = JToken.op_Implicit(Class185.smethod_0(-1141253527)),
						[Class185.smethod_0(-1141253598)] = JToken.op_Implicit(bool_1 ? (Class185.smethod_0(-1141258871) + new string('0', 128)) : Class185.smethod_0(-1141253614))
					};
					method_3(method_0(), jobject_1);
				}
			}
			else if (text == Class185.smethod_0(-1141258880))
			{
				jobject_0 = val;
				int_0++;
				method_3(method_0(), new JObject
				{
					[Class185.smethod_0(-1141308128)] = JToken.op_Implicit(Class185.smethod_0(-1141258880)),
					[Class185.smethod_0(-1141303993)] = JToken.op_Implicit(true),
					[Class185.smethod_0(-1141255964)] = JToken.op_Implicit((int)val[Class185.smethod_0(-1141255964)]),
					[Class185.smethod_0(-1141253472)] = JToken.op_Implicit(bool_2 ? Class185.smethod_0(-1141258904) : ((string)val[Class185.smethod_0(-1141253472)]))
				});
				if (bool_3)
				{
					method_2(method_0(), bool_4: true, Class185.smethod_0(-1141258943), Class185.smethod_0(-1141258958), 1, 1);
				}
			}
		}

		public string imethod_6(IntPtr intptr_0)
		{
			return Class185.smethod_0(-1141253364);
		}

		public void imethod_7(IntPtr intptr_0)
		{
			list_2.Add(Class185.smethod_0(-1141258974));
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
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			method_3(int_4, new JObject
			{
				[Class185.smethod_0(-1141308128)] = JToken.op_Implicit(Class185.smethod_0(-1141258978)),
				[Class185.smethod_0(-1141253472)] = JToken.op_Implicit(Class185.smethod_0(-1141253488)),
				[Class185.smethod_0(-1141259007)] = JToken.op_Implicit(bool_4),
				[Class185.smethod_0(-1141259024)] = JToken.op_Implicit(string_0),
				[Class185.smethod_0(-1141259028)] = JToken.op_Implicit(string_1),
				[Class185.smethod_0(-1141259041)] = JToken.op_Implicit(int_5),
				[Class185.smethod_0(-1141259063)] = JToken.op_Implicit(int_6),
				[Class185.smethod_0(-1141259067)] = JToken.op_Implicit(Class185.smethod_0(-1141255009))
			});
		}

		private void method_3(int int_4, JObject jobject_2)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			if (int_4 >= 0 && int_4 < list_3.Count)
			{
				Class266 @class = list_3[int_4];
				IntPtr intPtr = Marshal.StringToHGlobalAnsi(((JToken)new JObject
				{
					[Class185.smethod_0(-1141255953)] = JToken.op_Implicit(Class185.smethod_0(-1141253385)),
					[Class185.smethod_0(-1141253396)] = (JToken)(object)jobject_2
				}).ToString((Formatting)0, Array.Empty<JsonConverter>()));
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
			smethod_94(class222_0.gform0_0, Class185.smethod_0(-1141256027), null);
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
			dictionary_0.TryGetValue(string_0 + Class185.smethod_0(-1141300031) + uint_0, out var value);
			return value;
		}

		internal void method_1(uint uint_0, long long_0, int int_0)
		{
			dictionary_0[Class185.smethod_0(-1141252607) + uint_0] = new Class1
			{
				String_0 = uint_0.ToString(),
				String_1 = Class185.smethod_0(-1141253640),
				UInt32_0 = uint_0,
				String_7 = Class185.smethod_0(-1141253648),
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
			return new Class87(enum1_0, 0, 0, Class185.smethod_0(-1141252550));
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
			JObject val = JObject.Parse(string_0);
			if ((string)val[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141308140))
			{
				class119_0.method_145((uint)val[Class185.smethod_0(-1141293578)], (byte)val[Class185.smethod_0(-1141255953)], (uint)val[Class185.smethod_0(-1141255964)], bool_17: false, Class185.smethod_0(-1141256006));
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
			if (string_0.IndexOf(Class185.smethod_0(-1141255614), StringComparison.Ordinal) >= 0)
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
				}, Class185.smethod_0(-1141255639));
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
				@class.method_6(dataGridView, Class185.smethod_0(-1141255210), bool_0: false);
				class235_0.countdownEvent_0.Signal();
				class235_0.manualResetEventSlim_0.Wait();
				for (int i = 0; i < 20; i++)
				{
					using (@class.method_17(dataGridView))
					{
						dataGridView.Rows.Add(int_0 + Class185.smethod_0(-1141293701) + i);
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
				smethod_250(class119_0, Class185.smethod_0(-1141256109), 1L);
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
			JObject val = JObject.Parse(string_0);
			string text = (string)val[Class185.smethod_0(-1141254460)];
			if (text == Class185.smethod_0(-1141254478))
			{
				int_0++;
				int_1 = 0;
				bool_0 = false;
				if (int_0 > 1)
				{
					list_1.Add(Tuple.Create(class403_0.float_0, class403_0.float_2));
				}
			}
			else if (text == Class185.smethod_0(-1141308140))
			{
				if (int_0 != 0 && !bool_0)
				{
					bool_1 = true;
				}
				class119_0.method_145((uint)val[Class185.smethod_0(-1141293578)], (byte)val[Class185.smethod_0(-1141255953)], (uint)val[Class185.smethod_0(-1141255964)], bool_17: true, null);
			}
		}

		internal Task method_1(int int_4)
		{
			long_0 += int_4;
			int_1++;
			JObject obj = JObject.Parse(list_0.Last());
			float num = (float)obj[Class185.smethod_0(-1141255982)];
			float float_ = (float)obj[Class185.smethod_0(-1141255990)];
			float float_2 = (float)obj[Class185.smethod_0(-1141255998)];
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
			JObject val = JObject.Parse(string_0);
			if ((string)val[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141308140))
			{
				class119_1.method_145((uint)val[Class185.smethod_0(-1141293578)], (byte)val[Class185.smethod_0(-1141255953)], (uint)val[Class185.smethod_0(-1141255964)], bool_17: true, null);
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
			JObject val = JObject.Parse(string_0);
			if ((string)val[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141308140))
			{
				class119_2.method_145((uint)val[Class185.smethod_0(-1141293578)], (byte)val[Class185.smethod_0(-1141255953)], (uint)val[Class185.smethod_0(-1141255964)], bool_17: true, null);
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
			JObject val = JObject.Parse(string_0);
			if ((string)val[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141308140))
			{
				class119_2.method_145((uint)val[Class185.smethod_0(-1141293578)], (byte)val[Class185.smethod_0(-1141255953)], (uint)val[Class185.smethod_0(-1141255964)], bool_17: true, null);
			}
		}

		internal void method_11(string string_0)
		{
			list_4.Add(string_0);
			JObject val = JObject.Parse(string_0);
			if ((string)val[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141308140))
			{
				class119_3.method_145((uint)val[Class185.smethod_0(-1141293578)], (byte)val[Class185.smethod_0(-1141255953)], (uint)val[Class185.smethod_0(-1141255964)], bool_17: true, null);
			}
		}

		internal void method_12(string string_0)
		{
			list_4.Add(string_0);
			JObject val = JObject.Parse(string_0);
			if ((string)val[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141308140))
			{
				class119_4.method_145((uint)val[Class185.smethod_0(-1141293578)], (byte)val[Class185.smethod_0(-1141255953)], (uint)val[Class185.smethod_0(-1141255964)], bool_17: true, null);
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
			if (string_0.IndexOf(Class185.smethod_0(-1141255614), StringComparison.Ordinal) >= 0)
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
				}, Class185.smethod_0(-1141255639));
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
			string_3 = string_7 ?? (string_5 + Class185.smethod_0(-1141299374) + string_6);
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
				class222_0.method_0(class222_0.gform0_0.method_5().method_104(Class185.smethod_0(-1141256012)), bool_0: true);
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
			return Class144.smethod_1(class145_0, Class185.smethod_0(-1141255857), hashSet_0, 9, valueTuple_0);
		}

		internal List<Class53> method_1()
		{
			return Class144.smethod_0(class145_0, Class185.smethod_0(-1141255857), hashSet_0);
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
			class119_0.method_178(Class185.smethod_0(-1141252561));
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
			if (string_0.IndexOf(Class185.smethod_0(-1141255614), StringComparison.Ordinal) >= 0)
			{
				class339_0.method_0(new List<Class403>
				{
					new Class403
					{
						byte_0 = 100,
						byte_1 = 4,
						uint_0 = 77u
					}
				}, Class185.smethod_0(-1141255639));
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
			class270_0.list_0.Add(uint_0 + Class185.smethod_0(-1141297577) + string_1);
		}

		internal void method_1(string string_0, uint uint_0, string string_1, double double_0, string string_2, int int_0)
		{
			class270_0.list_1.Add(uint_0 + Class185.smethod_0(-1141297577) + (string_1 ?? Class185.smethod_0(-1141273631)));
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
			if (string_0.Contains(Class185.smethod_0(-1141254766)))
			{
				return string_0.Contains(Class185.smethod_0(-1141254792));
			}
			return false;
		}

		internal bool method_1(string string_0)
		{
			if (string_0.Contains(Class185.smethod_0(-1141254796)) && string_0.Contains(Class185.smethod_0(-1141254817)))
			{
				return string_0.Contains(Class185.smethod_0(-1141254846));
			}
			return false;
		}

		internal bool method_2(string string_0)
		{
			if (string_0.Contains(Class185.smethod_0(-1141254859)))
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
			Class103.smethod_2(new Class175(string.Empty, Class185.smethod_0(-1141303627), Class185.smethod_0(-1141254886), Class185.smethod_0(-1141254891)));
		}

		internal void method_6()
		{
			Class103.smethod_2(new Class175(Class185.smethod_0(-1141254926), string.Empty, Class185.smethod_0(-1141254886), Class185.smethod_0(-1141254891)));
		}

		internal void method_7()
		{
			Class103.smethod_2(new Class175(Class185.smethod_0(-1141254926), Class185.smethod_0(-1141254932), Class185.smethod_0(-1141254886), Class185.smethod_0(-1141254891)));
		}

		internal void method_8()
		{
			Class103.smethod_2(new Class175(new string('x', 1025), Class185.smethod_0(-1141303627), Class185.smethod_0(-1141254886), Class185.smethod_0(-1141254891)));
		}

		internal void method_9()
		{
			Class103.smethod_2(new Class175(Class185.smethod_0(-1141254926), Class185.smethod_0(-1141254946), Class185.smethod_0(-1141254886), Class185.smethod_0(-1141254891)));
		}

		internal void method_10()
		{
			Class103.smethod_4(smethod_18(new string('0', 63) + Class185.smethod_0(-1141297402)), new byte[65], new byte[65]);
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
			if (string_0.IndexOf(Class185.smethod_0(-1141254975), StringComparison.Ordinal) < 0)
			{
				return string_0.IndexOf(Class185.smethod_0(-1141254988), StringComparison.Ordinal) < 0;
			}
			return false;
		}

		internal Class175 method_14()
		{
			return new Class175(string.Empty, string.Empty, Class185.smethod_0(-1141255009), Class185.smethod_0(-1141255026));
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
			return string_0.IndexOf(Class185.smethod_0(-1141255063), StringComparison.Ordinal) >= 0;
		}

		internal bool method_20(string string_0)
		{
			return string_0.IndexOf(Class185.smethod_0(-1141255088), StringComparison.Ordinal) >= 0;
		}

		internal void method_21(string string_0)
		{
		}

		internal void method_22(string string_0)
		{
		}

		internal string method_23(int int_0, ulong ulong_0)
		{
			return int_0 + Class185.smethod_0(-1141255098) + ulong_0 + Class185.smethod_0(-1141254162);
		}

		internal Class87 method_24()
		{
			return new Class87(Enum1.Unhealthy, 0, 0, Class185.smethod_0(-1141254172));
		}

		internal Class87 method_25()
		{
			return new Class87(Enum1.Unhealthy, 0, 0, Class185.smethod_0(-1141254172));
		}

		internal Class87 method_26()
		{
			return new Class87(Enum1.Unhealthy, 0, 0, Class185.smethod_0(-1141254172));
		}

		internal void method_27(int int_0)
		{
		}

		internal bool method_28(string string_0)
		{
			if (string_0.Contains(Class185.smethod_0(-1141254198)))
			{
				return string_0.Contains(Class185.smethod_0(-1141254214));
			}
			return false;
		}

		internal bool method_29(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254228));
		}

		internal void method_30(int int_0)
		{
		}

		internal bool method_31(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254244));
		}

		internal void method_32(int int_0)
		{
		}

		internal bool method_33(string string_0)
		{
			if (!string_0.Contains(Class185.smethod_0(-1141254278)) && !string_0.Contains(Class185.smethod_0(-1141254283)))
			{
				return string_0.Contains(Class185.smethod_0(-1141254303));
			}
			return true;
		}

		internal void method_34(int int_0)
		{
		}

		internal bool method_35(string string_0)
		{
			if (!string_0.Contains(Class185.smethod_0(-1141254278)) && !string_0.Contains(Class185.smethod_0(-1141254283)))
			{
				return string_0.Contains(Class185.smethod_0(-1141254303));
			}
			return true;
		}

		internal Enum3 method_36()
		{
			return Enum3.Current;
		}

		internal bool method_37(string string_0)
		{
			if (!string_0.Contains(Class185.smethod_0(-1141254278)) && !string_0.Contains(Class185.smethod_0(-1141254303)))
			{
				return string_0.Contains(Class185.smethod_0(-1141254283));
			}
			return true;
		}

		internal Enum3 method_38()
		{
			return Enum3.Current;
		}

		internal bool method_39(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254316));
		}

		internal bool method_40(string string_0)
		{
			if (!string_0.Contains(Class185.smethod_0(-1141254278)))
			{
				return string_0.Contains(Class185.smethod_0(-1141254303));
			}
			return true;
		}

		internal bool method_41(int int_0)
		{
			return true;
		}

		internal Class87 method_42()
		{
			return new Class87(Enum1.Unhealthy, 0, 0, Class185.smethod_0(-1141254172));
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
			return (string_0 ?? string.Empty).Replace(Class185.smethod_0(-1141254362), Class185.smethod_0(-1141254370)).Replace(Class185.smethod_0(-1141254379), Class185.smethod_0(-1141254387));
		}

		internal bool method_55(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254396));
		}

		internal bool method_56(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254396));
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
			return string_0.Contains(Class185.smethod_0(-1141254430));
		}

		internal bool method_61(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254441));
		}

		internal bool method_62(JObject jobject_0)
		{
			return (string)jobject_0[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141254478);
		}

		internal bool method_63(JObject jobject_0)
		{
			return (string)jobject_0[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141308140);
		}

		internal int method_64(int int_0, int int_1)
		{
			return int_0;
		}

		internal bool method_65(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254430));
		}

		internal bool method_66(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254430));
		}

		internal int method_67(int int_0, int int_1)
		{
			return int_0;
		}

		internal bool method_68(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254430));
		}

		internal bool method_69(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254430));
		}

		internal bool method_70(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254430));
		}

		internal bool method_71(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254430));
		}

		internal bool method_72(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254430));
		}

		internal bool method_73(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254430));
		}

		internal int method_74(int int_0, int int_1)
		{
			return int_0;
		}

		internal bool method_75(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254430));
		}

		internal bool method_76(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254430));
		}

		internal bool method_77(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254396));
		}

		internal bool method_78(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254430));
		}

		internal bool method_79(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254430));
		}

		internal bool method_80(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254430));
		}

		internal bool method_81(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254441));
		}

		internal bool method_82(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141254441));
		}

		internal Task method_83(int int_0)
		{
			return Task.CompletedTask;
		}

		internal bool method_84(MethodInfo methodInfo_0)
		{
			if (!(methodInfo_0.Name == Class185.smethod_0(-1141254481)) && !(methodInfo_0.Name == Class185.smethod_0(-1141254512)))
			{
				return methodInfo_0.Name == Class185.smethod_0(-1141254536);
			}
			return true;
		}

		internal bool method_85(MethodInfo methodInfo_0)
		{
			return !methodInfo_0.Name.EndsWith(Class185.smethod_0(-1141254560), StringComparison.Ordinal);
		}

		internal bool method_86(MethodInfo methodInfo_0)
		{
			if (methodInfo_0.Name == Class185.smethod_0(-1141254481))
			{
				return methodInfo_0.GetParameters().Length == 4;
			}
			return false;
		}

		internal bool method_87(MethodInfo methodInfo_0)
		{
			if (methodInfo_0.Name == Class185.smethod_0(-1141254512))
			{
				return methodInfo_0.GetParameters().Length == 4;
			}
			return false;
		}

		internal bool method_88(MethodInfo methodInfo_0)
		{
			if (methodInfo_0.Name == Class185.smethod_0(-1141254536))
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
			throw new InvalidOperationException(Class185.smethod_0(-1141254576));
		}

		internal Task<bool> method_103(string string_0, TimeSpan timeSpan_0, TimeSpan timeSpan_1, CancellationToken cancellationToken_0)
		{
			return Task.FromResult(result: true);
		}

		internal bool method_104(string string_0)
		{
			if (string_0.Contains(Class185.smethod_0(-1141254597)) && string_0.Contains(Class185.smethod_0(-1141254637)))
			{
				return string_0.IndexOf(Class185.smethod_0(-1141254576), StringComparison.Ordinal) < 0;
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
			throw new InvalidOperationException(Class185.smethod_0(-1141255687));
		}

		internal Task<bool> method_110(string string_0, TimeSpan timeSpan_0, TimeSpan timeSpan_1, CancellationToken cancellationToken_0)
		{
			return Task.FromResult(result: true);
		}

		internal bool method_111(string string_0)
		{
			return string_0.Contains(Class185.smethod_0(-1141255719));
		}

		internal bool method_112(string string_0)
		{
			return string_0.IndexOf(Class185.smethod_0(-1141255687), StringComparison.Ordinal) < 0;
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
			return Class185.smethod_0(-1141255751);
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
			return string_0.StartsWith(Class185.smethod_0(-1141255766));
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
			throw new InvalidOperationException(Class185.smethod_0(-1141255782));
		}

		internal bool method_135(int int_0)
		{
			return true;
		}

		internal Task<string> method_136(CancellationToken cancellationToken_0)
		{
			return Task.FromResult(Class185.smethod_0(-1141255800));
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
			return Task.FromResult(Class185.smethod_0(-1141255800));
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
			return Task.FromResult(Class185.smethod_0(-1141255804));
		}

		internal Task<Class438> method_151(string string_0, CancellationToken cancellationToken_0)
		{
			return Task.FromException<Class438>(new InvalidOperationException(Class185.smethod_0(-1141255804)));
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
			return Task.FromResult(Class185.smethod_0(-1141255840));
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
			if (class53_0.string_0 == Class185.smethod_0(-1141255857))
			{
				return class53_0.bool_0;
			}
			return false;
		}

		internal bool method_161(Class53 class53_0)
		{
			if (class53_0.string_0 == Class185.smethod_0(-1141255868))
			{
				return class53_0.bool_0;
			}
			return false;
		}

		internal bool method_162(Class53 class53_0)
		{
			return class53_0.string_0 != Class185.smethod_0(-1141255883);
		}

		internal bool method_163(Class53 class53_0)
		{
			if (class53_0.string_0 == Class185.smethod_0(-1141255857))
			{
				return class53_0.string_1 == Class185.smethod_0(-1141255898);
			}
			return false;
		}

		internal bool method_164(Class53 class53_0)
		{
			if (class53_0.string_0 == Class185.smethod_0(-1141255868))
			{
				return class53_0.string_1 == Class185.smethod_0(-1141274464);
			}
			return false;
		}

		internal bool method_165(Class53 class53_0)
		{
			if (class53_0.string_0 == Class185.smethod_0(-1141255857))
			{
				return class53_0.string_1 == Class185.smethod_0(-1141255918);
			}
			return false;
		}

		internal bool method_166(Class53 class53_0)
		{
			if (class53_0.string_0 == Class185.smethod_0(-1141255868))
			{
				return class53_0.string_1 == Class185.smethod_0(-1141274433);
			}
			return false;
		}

		internal bool method_167(Class53 class53_0)
		{
			if (class53_0.string_0 == Class185.smethod_0(-1141255868))
			{
				return !class53_0.bool_0;
			}
			return false;
		}

		internal bool method_168(DataGridViewRow dataGridViewRow_0)
		{
			if ((string)dataGridViewRow_0.Cells[1].Value == Class185.smethod_0(-1141255857))
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
			return class381_0.string_0 == Class185.smethod_0(-1141255883);
		}

		internal bool method_171(Class381 class381_0)
		{
			return class381_0.string_0 != Class185.smethod_0(-1141255922);
		}

		internal bool method_172(Class381 class381_0)
		{
			if (class381_0.string_0 == Class185.smethod_0(-1141255922))
			{
				return !class381_0.bool_2;
			}
			return false;
		}

		internal bool method_173(Class381 class381_0)
		{
			return class381_0.string_0 != Class185.smethod_0(-1141255883);
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
			class119_0.method_178(Class185.smethod_0(-1141252598));
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
				return Class71.Class72.smethod_1(Class185.smethod_0(-1141253663));
			}
			if (string_7 == Class185.smethod_0(-1141303611))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141303627));
			}
			if (string_7.StartsWith(Class185.smethod_0(-1141253683), StringComparison.Ordinal))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141253733) + string_1 + Class185.smethod_0(-1141253740));
			}
			if (string_7.StartsWith(Class185.smethod_0(-1141253765), StringComparison.Ordinal))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141253786) + string_1 + Class185.smethod_0(-1141253802) + string_1);
			}
			if (string_7.Contains(Class185.smethod_0(-1141253849)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141296459));
			}
			if (string_7.Contains(Class185.smethod_0(-1141253866)))
			{
				if (!bool_4 && !bool_5)
				{
					if (!bool_0)
					{
						return Class71.Class72.smethod_0(Class185.smethod_0(-1141253919));
					}
					int_1++;
					return Class71.Class72.smethod_0(Class185.smethod_0(-1141253866) + ((string_0 == string_4) ? Class185.smethod_0(-1141253960) : Class185.smethod_0(-1141253944)));
				}
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141253884));
			}
			if (string_7.StartsWith(Class185.smethod_0(-1141253974), StringComparison.Ordinal))
			{
				int_0++;
				if (!bool_1)
				{
					return Class71.Class72.smethod_0(Class185.smethod_0(-1141253978));
				}
				return Class71.Class72.smethod_1(Class185.smethod_0(-1141253999));
			}
			if (string_7.Contains(Class185.smethod_0(-1141254859)))
			{
				if (bool_2)
				{
					return Class71.Class72.smethod_1(Class185.smethod_0(-1141254029));
				}
				if (bool_6)
				{
					return Class71.Class72.smethod_0(Class185.smethod_0(-1141254053));
				}
				if (bool_3)
				{
					return Class71.Class72.smethod_0(Class185.smethod_0(-1141254073));
				}
				bool_7 = true;
				bool_0 = true;
				string_0 = string_4;
				int_1++;
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141254111));
			}
			if (string_7.Contains(Class185.smethod_0(-1141254129)) && string_7.Contains(Class185.smethod_0(-1141253128)))
			{
				if (!bool_2)
				{
					return Class71.Class72.smethod_0(string.Empty);
				}
				return Class71.Class72.smethod_1(Class185.smethod_0(-1141254029));
			}
			if (string_7.Contains(Class185.smethod_0(-1141253151)) && string_7.Contains(Class185.smethod_0(-1141253153)))
			{
				bool_7 = true;
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_7.Contains(Class185.smethod_0(-1141254792)) && string_7.Contains(Class185.smethod_0(-1141253153)))
			{
				if (!bool_7)
				{
					return Class71.Class72.smethod_1(Class185.smethod_0(-1141253175));
				}
				bool_0 = true;
				string_0 = string_4;
				return Class71.Class72.smethod_0(string.Empty);
			}
			if (string_7.Contains(Class185.smethod_0(-1141253187)) && string_7.Contains(Class185.smethod_0(-1141253153)))
			{
				return Class71.Class72.smethod_0(Class185.smethod_0(-1141294339));
			}
			if (!string_7.Contains(Class185.smethod_0(-1141253201)) && !string_7.Contains(Class185.smethod_0(-1141253222)) && !string_7.Contains(Class185.smethod_0(-1141253227)) && !string_7.Contains(Class185.smethod_0(-1141254283)))
			{
				return Class71.Class72.smethod_1(Class185.smethod_0(-1141253244));
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
			if (string_0.IndexOf(Class185.smethod_0(-1141255614), StringComparison.Ordinal) >= 0)
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
				class119_0.method_145(num, 3, num, (num & 1) == 0, num + Class185.smethod_0(-1141255941) + ((num & 1) == 0));
			}
		}

		internal void method_1()
		{
			for (uint num = 501u; num <= 1000; num++)
			{
				class119_0.method_145(num, 4, num, (num & 1) == 0, num + Class185.smethod_0(-1141255951) + ((num & 1) == 0));
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
			if (string_0.IndexOf(Class185.smethod_0(-1141255614), StringComparison.Ordinal) >= 0)
			{
				class259_0.class339_0.method_0(new List<Class403>
				{
					new Class403
					{
						byte_0 = 100,
						byte_1 = 4,
						uint_0 = 77u
					}
				}, Class185.smethod_0(-1141255639));
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
			class222_0.method_0(class222_0.gform0_0.method_5().method_104(Class185.smethod_0(-1141256006)), bool_0: true);
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
			return Class185.smethod_0(-1141259082);
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
			return Task.FromResult((int_2++ == 0) ? smethod_288(bool_0: true, Class185.smethod_0(-1141255256)) : smethod_288(bool_0: true, Class185.smethod_0(-1141255240)));
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
			return Task.FromResult(Class185.smethod_0(-1141255800));
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
			smethod_94(class222_0.gform0_0, Class185.smethod_0(-1141256027), null);
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
			JObject val = JObject.Parse(string_0);
			if (!bool_0 && !((string)val[Class185.smethod_0(-1141254460)] != Class185.smethod_0(-1141308140)))
			{
				bool_0 = true;
				class273_0.long_0 = 1000L;
				class222_0.method_0(smethod_113(new List<Class403> { class273_0.class403_0 }, class273_0.dictionary_0, class273_0.class83_0, 321), bool_0: true);
				class273_0.class119_1.method_145((uint)val[Class185.smethod_0(-1141293578)], (byte)val[Class185.smethod_0(-1141255953)], (uint)val[Class185.smethod_0(-1141255964)], bool_17: true, null);
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
			Class442.smethod_1(null, string_0, Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), smethod_7);
		}

		internal void method_1()
		{
			Class442.smethod_1(byte_0, string_0, Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), smethod_7);
		}

		internal void method_2()
		{
			Class442.smethod_1(byte_1, string_0, Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), class306_0.method_0);
		}

		internal void method_3()
		{
			Class442.smethod_1(byte_1, string_0, Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), class306_1.method_0);
		}

		internal void method_4()
		{
			Class442.smethod_1(byte_1, string_0, Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), class306_2.method_0);
		}

		internal void method_5()
		{
			Class442.smethod_1(byte_1, string_0, Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), class306_3.method_0);
		}

		internal void method_6()
		{
			Class442.smethod_1(byte_1, string_0, Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), class306_4.method_0);
		}

		internal void method_7()
		{
			Class442.smethod_1(byte_1, string_0, Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255334), class306_5.method_0);
		}

		internal void method_8()
		{
			Class442.smethod_1(byte_1, string_0, Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), class306_6.method_0);
		}

		internal void method_9()
		{
			Class442.smethod_1(byte_1, string_0, Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), class306_7.method_0);
		}

		internal void method_10()
		{
			Class442.smethod_1(byte_1, string_0, Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), class306_8.method_0);
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
		private static readonly MethodInfo methodInfo_0 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);

		private static readonly MethodInfo methodInfo_1 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);

		private static readonly FieldInfo fieldInfo_0 = typeof(Class119).GetField(Class185.smethod_0(-1141259613), BindingFlags.Instance | BindingFlags.NonPublic);

		private static readonly FieldInfo fieldInfo_1 = typeof(Class119).GetField(Class185.smethod_0(-1141259787), BindingFlags.Instance | BindingFlags.NonPublic);

		private static readonly FieldInfo fieldInfo_2 = typeof(Class119).GetField(Class185.smethod_0(-1141259618), BindingFlags.Instance | BindingFlags.NonPublic);

		private static readonly FieldInfo fieldInfo_3 = typeof(Class119).GetField(Class185.smethod_0(-1141259634), BindingFlags.Instance | BindingFlags.NonPublic);

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
					throw new InvalidOperationException(Class185.smethod_0(-1141259561));
				}
				long_0 = (long)array[1];
				return;
			}
			throw new InvalidOperationException(Class185.smethod_0(-1141259515));
		}

		internal void method_0(List<Class403> list_0, string string_0)
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				class119_0.dictionary_2[Class185.smethod_0(-1141259656)] = string_0;
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
		new Class282(Class185.smethod_0(-1141259657), Class185.smethod_0(-1141259708), Class185.smethod_0(-1141259729), Class185.smethod_0(-1141256715)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141256803), Class185.smethod_0(-1141256863)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141256895), Class185.smethod_0(-1141256932)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141256963), Class185.smethod_0(-1141257025)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141257063), Class185.smethod_0(-1141257107)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141257152), Class185.smethod_0(-1141257185)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141256197), Class185.smethod_0(-1141256285)),
		new Class282(Class185.smethod_0(-1141256340), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141256383), Class185.smethod_0(-1141256442)),
		new Class282(Class185.smethod_0(-1141256340), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141256494), Class185.smethod_0(-1141256553)),
		new Class282(Class185.smethod_0(-1141256340), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141256605), Class185.smethod_0(-1141256687)),
		new Class282(Class185.smethod_0(-1141256340), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141257762), Class185.smethod_0(-1141257824)),
		new Class282(Class185.smethod_0(-1141256340), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141257850), Class185.smethod_0(-1141257889)),
		new Class282(Class185.smethod_0(-1141256340), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141257921), Class185.smethod_0(-1141258021)),
		new Class282(Class185.smethod_0(-1141258080), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141258120), Class185.smethod_0(-1141258182)),
		new Class282(Class185.smethod_0(-1141258080), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141258219), Class185.smethod_0(-1141257264)),
		new Class282(Class185.smethod_0(-1141258080), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141257300), Class185.smethod_0(-1141257358)),
		new Class282(Class185.smethod_0(-1141257387), Class185.smethod_0(-1141257435), Class185.smethod_0(-1141257461)),
		new Class282(Class185.smethod_0(-1141257387), Class185.smethod_0(-1141257435), Class185.smethod_0(-1141257626)),
		new Class282(Class185.smethod_0(-1141257387), Class185.smethod_0(-1141257435), Class185.smethod_0(-1141361232)),
		new Class282(Class185.smethod_0(-1141257387), Class185.smethod_0(-1141257435), Class185.smethod_0(-1141361417)),
		new Class282(Class185.smethod_0(-1141257387), Class185.smethod_0(-1141257435), Class185.smethod_0(-1141360645)),
		new Class282(Class185.smethod_0(-1141257387), Class185.smethod_0(-1141257435), Class185.smethod_0(-1141360703)),
		new Class282(Class185.smethod_0(-1141257387), Class185.smethod_0(-1141257435), Class185.smethod_0(-1141360810)),
		new Class282(Class185.smethod_0(-1141257387), Class185.smethod_0(-1141257435), Class185.smethod_0(-1141360881)),
		new Class282(Class185.smethod_0(-1141257387), Class185.smethod_0(-1141257435), Class185.smethod_0(-1141360969)),
		new Class282(Class185.smethod_0(-1141257387), Class185.smethod_0(-1141257435), Class185.smethod_0(-1141361041)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141362235)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141362430), Class185.smethod_0(-1141362497)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141362617), Class185.smethod_0(-1141361671)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141361712)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141361913)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141362016)),
		new Class282(Class185.smethod_0(-1141362110), Class185.smethod_0(-1141362168), Class185.smethod_0(-1141359116), Class185.smethod_0(-1141359192)),
		new Class282(Class185.smethod_0(-1141362110), Class185.smethod_0(-1141362168), Class185.smethod_0(-1141359238)),
		new Class282(Class185.smethod_0(-1141362110), Class185.smethod_0(-1141362168), Class185.smethod_0(-1141359309)),
		new Class282(Class185.smethod_0(-1141362110), Class185.smethod_0(-1141362168), Class185.smethod_0(-1141359360)),
		new Class282(Class185.smethod_0(-1141362110), Class185.smethod_0(-1141362168), Class185.smethod_0(-1141359426)),
		new Class282(Class185.smethod_0(-1141359459), Class185.smethod_0(-1141359507), Class185.smethod_0(-1141359533)),
		new Class282(Class185.smethod_0(-1141359459), Class185.smethod_0(-1141359507), Class185.smethod_0(-1141358610)),
		new Class282(Class185.smethod_0(-1141359459), Class185.smethod_0(-1141359507), Class185.smethod_0(-1141358726)),
		new Class282(Class185.smethod_0(-1141359459), Class185.smethod_0(-1141359507), Class185.smethod_0(-1141358840)),
		new Class282(Class185.smethod_0(-1141359459), Class185.smethod_0(-1141359507), Class185.smethod_0(-1141358933)),
		new Class282(Class185.smethod_0(-1141359459), Class185.smethod_0(-1141359507), Class185.smethod_0(-1141359000)),
		new Class282(Class185.smethod_0(-1141359459), Class185.smethod_0(-1141359507), Class185.smethod_0(-1141359360)),
		new Class282(Class185.smethod_0(-1141359459), Class185.smethod_0(-1141359507), Class185.smethod_0(-1141359079)),
		new Class282(Class185.smethod_0(-1141360210), Class185.smethod_0(-1141360259), Class185.smethod_0(-1141360286)),
		new Class282(Class185.smethod_0(-1141360358), Class185.smethod_0(-1141360401), Class185.smethod_0(-1141360430)),
		new Class282(Class185.smethod_0(-1141360358), Class185.smethod_0(-1141360401), Class185.smethod_0(-1141360497)),
		new Class282(Class185.smethod_0(-1141360358), Class185.smethod_0(-1141360401), Class185.smethod_0(-1141360567)),
		new Class282(Class185.smethod_0(-1141359632), Class185.smethod_0(-1141359686), Class185.smethod_0(-1141359116), Class185.smethod_0(-1141359710)),
		new Class282(Class185.smethod_0(-1141359632), Class185.smethod_0(-1141359686), Class185.smethod_0(-1141359752)),
		new Class282(Class185.smethod_0(-1141359632), Class185.smethod_0(-1141359686), Class185.smethod_0(-1141359826)),
		new Class282(Class185.smethod_0(-1141359632), Class185.smethod_0(-1141359686), Class185.smethod_0(-1141359878)),
		new Class282(Class185.smethod_0(-1141359632), Class185.smethod_0(-1141359686), Class185.smethod_0(-1141359928)),
		new Class282(Class185.smethod_0(-1141359632), Class185.smethod_0(-1141359686), Class185.smethod_0(-1141359426)),
		new Class282(Class185.smethod_0(-1141359981), Class185.smethod_0(-1141360031), Class185.smethod_0(-1141359116), Class185.smethod_0(-1141360043)),
		new Class282(Class185.smethod_0(-1141359981), Class185.smethod_0(-1141360031), Class185.smethod_0(-1141360081)),
		new Class282(Class185.smethod_0(-1141359981), Class185.smethod_0(-1141360031), Class185.smethod_0(-1141365250)),
		new Class282(Class185.smethod_0(-1141359981), Class185.smethod_0(-1141360031), Class185.smethod_0(-1141365291)),
		new Class282(Class185.smethod_0(-1141359981), Class185.smethod_0(-1141360031), Class185.smethod_0(-1141365343)),
		new Class282(Class185.smethod_0(-1141359981), Class185.smethod_0(-1141360031), Class185.smethod_0(-1141365402)),
		new Class282(Class185.smethod_0(-1141359981), Class185.smethod_0(-1141360031), Class185.smethod_0(-1141365489)),
		new Class282(Class185.smethod_0(-1141359981), Class185.smethod_0(-1141360031), Class185.smethod_0(-1141365552)),
		new Class282(Class185.smethod_0(-1141359981), Class185.smethod_0(-1141360031), Class185.smethod_0(-1141359426)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141365622)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141365691)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141364739)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141364830)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141364906)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141364997)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141365079), Class185.smethod_0(-1141365090)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141365195)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141366305)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141366399)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141366493)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141366600)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141366694)),
		new Class282(Class185.smethod_0(-1141366776), Class185.smethod_0(-1141365800), Class185.smethod_0(-1141365810)),
		new Class282(Class185.smethod_0(-1141366776), Class185.smethod_0(-1141365800), Class185.smethod_0(-1141365913)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141366018)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141366094)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141366164)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141366248)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141363230)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141363287)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141363373)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141363433)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141363516)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141363569)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141363617)),
		new Class282(Class185.smethod_0(-1141256766), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141363692)),
		new Class282(Class185.smethod_0(-1141258080), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141362773)),
		new Class282(Class185.smethod_0(-1141258080), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141362825)),
		new Class282(Class185.smethod_0(-1141258080), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141362898)),
		new Class282(Class185.smethod_0(-1141258080), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141362955)),
		new Class282(Class185.smethod_0(-1141258080), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141362993)),
		new Class282(Class185.smethod_0(-1141258080), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141363070)),
		new Class282(Class185.smethod_0(-1141258080), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141363097)),
		new Class282(Class185.smethod_0(-1141258080), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141363168)),
		new Class282(Class185.smethod_0(-1141258080), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141363194)),
		new Class282(Class185.smethod_0(-1141256340), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141364260)),
		new Class282(Class185.smethod_0(-1141256340), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141364302)),
		new Class282(Class185.smethod_0(-1141364334), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141364370)),
		new Class282(Class185.smethod_0(-1141364334), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141364413)),
		new Class282(Class185.smethod_0(-1141364334), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141364442)),
		new Class282(Class185.smethod_0(-1141364490), Class185.smethod_0(-1141308060), Class185.smethod_0(-1141364541)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141364630)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141364668)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141363962)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141364136)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141364209)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141369448)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141369613)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141368903)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141369109)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141370481)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141370670)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141370728)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141370806)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141369982)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141370032)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141370139)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141370207)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141370246)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141370301)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141367297)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141367383)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141367418)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141367505)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141367609), Class185.smethod_0(-1141367628)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141367609), Class185.smethod_0(-1141367683)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141367736), Class185.smethod_0(-1141367759)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141367736), Class185.smethod_0(-1141366791)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141367736), Class185.smethod_0(-1141366826)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141367736), Class185.smethod_0(-1141366875)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141366949)),
		new Class282(Class185.smethod_0(-1141362549), Class185.smethod_0(-1141362594), Class185.smethod_0(-1141359426)),
		new Class282(Class185.smethod_0(-1141359459), Class185.smethod_0(-1141359507), Class185.smethod_0(-1141367022)),
		new Class282(Class185.smethod_0(-1141359459), Class185.smethod_0(-1141359507), Class185.smethod_0(-1141367139)),
		new Class282(Class185.smethod_0(-1141359459), Class185.smethod_0(-1141359507), Class185.smethod_0(-1141367203)),
		new Class282(Class185.smethod_0(-1141359459), Class185.smethod_0(-1141359507), Class185.smethod_0(-1141367249)),
		new Class282(Class185.smethod_0(-1141359459), Class185.smethod_0(-1141359507), Class185.smethod_0(-1141367291)),
		new Class282(Class185.smethod_0(-1141362110), Class185.smethod_0(-1141362168), Class185.smethod_0(-1141368353)),
		new Class282(Class185.smethod_0(-1141362110), Class185.smethod_0(-1141362168), Class185.smethod_0(-1141368421)),
		new Class282(Class185.smethod_0(-1141362110), Class185.smethod_0(-1141362168), Class185.smethod_0(-1141368451)),
		new Class282(Class185.smethod_0(-1141359632), Class185.smethod_0(-1141359686), Class185.smethod_0(-1141368490)),
		new Class282(Class185.smethod_0(-1141359632), Class185.smethod_0(-1141359686), Class185.smethod_0(-1141368538)),
		new Class282(Class185.smethod_0(-1141359981), Class185.smethod_0(-1141360031), Class185.smethod_0(-1141368589)),
		new Class282(Class185.smethod_0(-1141359981), Class185.smethod_0(-1141360031), Class185.smethod_0(-1141368649)),
		new Class282(Class185.smethod_0(-1141359981), Class185.smethod_0(-1141360031), Class185.smethod_0(-1141368714)),
		new Class282(Class185.smethod_0(-1141359981), Class185.smethod_0(-1141360031), Class185.smethod_0(-1141368772)),
		new Class282(Class185.smethod_0(-1141360210), Class185.smethod_0(-1141360259), Class185.smethod_0(-1141359426)),
		new Class282(Class185.smethod_0(-1141360358), Class185.smethod_0(-1141360401), Class185.smethod_0(-1141367811)),
		new Class282(Class185.smethod_0(-1141360358), Class185.smethod_0(-1141360401), Class185.smethod_0(-1141367889)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141367976)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141368081)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141368182)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141368270)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141373471)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141373565)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141373643)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141359426)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141373689)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141373739)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141373808)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141373835)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141373883)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141373952)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141372968)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141373054)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141373139)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141373301)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141373370)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141373433)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141374491)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141374527)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141374553)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141374703)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141374899)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141373985)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141374178)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141374346)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141374462)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141371439)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141371482)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141371639)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141371791)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141371870)),
		new Class282(Class185.smethod_0(-1141362364), Class185.smethod_0(-1141362411), Class185.smethod_0(-1141370895)),
		new Class282(Class185.smethod_0(-1141370944), Class185.smethod_0(-1141371000), Class185.smethod_0(-1141371010)),
		new Class282(Class185.smethod_0(-1141370944), Class185.smethod_0(-1141371000), Class185.smethod_0(-1141371078)),
		new Class282(Class185.smethod_0(-1141370944), Class185.smethod_0(-1141371000), Class185.smethod_0(-1141371151)),
		new Class282(Class185.smethod_0(-1141370944), Class185.smethod_0(-1141371000), Class185.smethod_0(-1141371232)),
		new Class282(Class185.smethod_0(-1141370944), Class185.smethod_0(-1141371000), Class185.smethod_0(-1141371293)),
		new Class282(Class185.smethod_0(-1141370944), Class185.smethod_0(-1141371000), Class185.smethod_0(-1141371348)),
		new Class282(Class185.smethod_0(-1141370944), Class185.smethod_0(-1141371000), Class185.smethod_0(-1141372434)),
		new Class282(Class185.smethod_0(-1141370944), Class185.smethod_0(-1141372494), Class185.smethod_0(-1141372520)),
		new Class282(Class185.smethod_0(-1141370944), Class185.smethod_0(-1141372494), Class185.smethod_0(-1141372562)),
		new Class282(Class185.smethod_0(-1141370944), Class185.smethod_0(-1141372494), Class185.smethod_0(-1141372601)),
		new Class282(Class185.smethod_0(-1141370944), Class185.smethod_0(-1141372494), Class185.smethod_0(-1141372658)),
		new Class282(Class185.smethod_0(-1141370944), Class185.smethod_0(-1141372494), Class185.smethod_0(-1141372735)),
		new Class282(Class185.smethod_0(-1141370944), Class185.smethod_0(-1141372494), Class185.smethod_0(-1141372797)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141371921)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141371989)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141372031)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141372085)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141372137)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141372232)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141372267)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141372330)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141372400)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141344812)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141344876)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141344946)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141344993)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141345077)),
		new Class282(Class185.smethod_0(-1141372875), Class185.smethod_0(-1141371909), Class185.smethod_0(-1141345119)),
		new Class282(Class185.smethod_0(-1141345176), Class185.smethod_0(-1141345223), Class185.smethod_0(-1141345240)),
		new Class282(Class185.smethod_0(-1141361147), Class185.smethod_0(-1141362218), Class185.smethod_0(-1141344259)),
		new Class282(Class185.smethod_0(-1141344338), Class185.smethod_0(-1141344392), Class185.smethod_0(-1141344408)),
		new Class282(Class185.smethod_0(-1141360358), Class185.smethod_0(-1141360401), Class185.smethod_0(-1141344452)),
		new Class282(Class185.smethod_0(-1141360210), Class185.smethod_0(-1141344513), Class185.smethod_0(-1141344540))
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
			Console.WriteLine(Class185.smethod_0(-1141344578) + ex.Message);
			Console.WriteLine(Class185.smethod_0(-1141344620));
			return 1;
		}
		num += smethod_243(Class185.smethod_0(-1141344657), byte_.Length >= 20);
		num += smethod_244(Class185.smethod_0(-1141344709), (byte)2, byte_[4]);
		num += smethod_244(Class185.smethod_0(-1141344744), (byte)1, byte_[5]);
		num += smethod_244(Class185.smethod_0(-1141345803), 183, byte_[18] | (byte_[19] << 8));
		num += smethod_244(Class185.smethod_0(-1141345848), smethod_2(byte_), string_1);
		if (!string.IsNullOrWhiteSpace(string_0))
		{
			num += smethod_243(Class185.smethod_0(-1141345874), File.Exists(string_0));
			if (File.Exists(string_0))
			{
				byte[] array = File.ReadAllBytes(string_0);
				num += smethod_244(Class185.smethod_0(-1141345924), array.Length, byte_.Length);
				num += smethod_244(Class185.smethod_0(-1141345982), smethod_2(array), string_1);
			}
		}
		num += smethod_243(Class185.smethod_0(-1141346030), smethod_1(new byte[4] { 127, 69, 76, 70 }));
		byte[] array2 = (byte[])byte_.Clone();
		array2[18] = 62;
		array2[19] = 0;
		num += smethod_243(Class185.smethod_0(-1141346078), smethod_1(array2));
		Console.WriteLine((num == 0) ? Class185.smethod_0(-1141346163) : (Class185.smethod_0(-1141346135) + num));
		Console.WriteLine(Class185.smethod_0(-1141346205) + string_1);
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
		return BitConverter.ToString(sHA.ComputeHash(byte_0)).Replace(Class185.smethod_0(-1141293701), string.Empty).ToLowerInvariant();
	}

	internal static int smethod_3()
	{
		Class337 @class = new Class337();
		int num = 0;
		@class.byte_1 = smethod_5();
		@class.string_0 = Class57.smethod_1(@class.byte_1);
		num = 0 + smethod_243(Class185.smethod_0(-1141346235), smethod_6(@class.method_0, Class185.smethod_0(-1141304945)));
		@class.byte_0 = (byte[])@class.byte_1.Clone();
		@class.byte_0[0] = 0;
		num += smethod_243(Class185.smethod_0(-1141346290), smethod_6(@class.method_1, Class185.smethod_0(-1141345321)));
		Class306 class2 = new Class306(Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255306), @class.string_0, @class.byte_1.Length)
		{
			bool_0 = true,
			string_0 = @class.string_0
		};
		Class32 class3 = Class442.smethod_1(@class.byte_1, @class.string_0, Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), class2.method_0);
		num += smethod_244(Class185.smethod_0(-1141345331), Class185.smethod_0(-1141345378) + @class.string_0 + Class185.smethod_0(-1141345452), class3.string_2);
		num += smethod_244(Class185.smethod_0(-1141345479), @class.string_0, class3.string_3);
		num += smethod_244(Class185.smethod_0(-1141345526), 10066, class3.int_0);
		num += smethod_243(Class185.smethod_0(-1141345564), class3.bool_0);
		num += smethod_244(Class185.smethod_0(-1141345629), 0, class2.int_0);
		@class.class306_0 = new Class306(Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255306), @class.string_0, @class.byte_1.Length)
		{
			bool_4 = true
		};
		num += smethod_243(Class185.smethod_0(-1141345674), smethod_6(@class.method_2, Class185.smethod_0(-1141345742)));
		num += smethod_244(Class185.smethod_0(-1141345748), 0, @class.class306_0.int_0);
		@class.class306_1 = new Class306(Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255306), @class.string_0, @class.byte_1.Length)
		{
			bool_5 = true
		};
		num += smethod_243(Class185.smethod_0(-1141342724), smethod_6(@class.method_3, Class185.smethod_0(-1141345742)));
		num += smethod_244(Class185.smethod_0(-1141342787), 0, @class.class306_1.int_0);
		@class.class306_2 = new Class306(Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255306), @class.string_0, @class.byte_1.Length)
		{
			bool_6 = true
		};
		num += smethod_243(Class185.smethod_0(-1141342846), smethod_6(@class.method_4, Class185.smethod_0(-1141345742)));
		num += smethod_244(Class185.smethod_0(-1141342895), 1, @class.class306_2.int_0);
		num += smethod_243(Class185.smethod_0(-1141342940), !@class.class306_2.bool_0);
		Class306 class4 = new Class306(Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255306), @class.string_0, @class.byte_1.Length);
		Class32 class5 = Class442.smethod_1(@class.byte_1, @class.string_0, Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), class4.method_0);
		num += smethod_244(Class185.smethod_0(-1141343006), 1, class4.int_0);
		num += smethod_243(Class185.smethod_0(-1141343055), !class5.bool_0);
		num += smethod_243(Class185.smethod_0(-1141343110), class4.bool_0 && class4.string_0 == @class.string_0 && class4.int_1 > 0 && class5.string_2.EndsWith(Class185.smethod_0(-1141300031) + @class.string_0 + Class185.smethod_0(-1141345452), StringComparison.Ordinal));
		num += smethod_243(Class185.smethod_0(-1141343168), class4.list_0.Exists(Class299.class299_0.method_0));
		num += smethod_243(Class185.smethod_0(-1141343213), class4.list_0.Exists(Class299.class299_0.method_1));
		num += smethod_243(Class185.smethod_0(-1141342247), class4.list_0.Exists(Class299.class299_0.method_2));
		@class.class306_3 = new Class306(Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255306), @class.string_0, @class.byte_1.Length)
		{
			bool_0 = true,
			string_0 = new string('0', 64)
		};
		num += smethod_243(Class185.smethod_0(-1141342300), smethod_6(@class.method_5, Class185.smethod_0(-1141342368)));
		num += smethod_244(Class185.smethod_0(-1141342384), 0, @class.class306_3.int_0);
		@class.class306_4 = new Class306(Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255306), @class.string_0, @class.byte_1.Length)
		{
			string_1 = Class185.smethod_0(-1141342434)
		};
		num += smethod_243(Class185.smethod_0(-1141342458), smethod_6(@class.method_6, Class185.smethod_0(-1141342523)));
		num += smethod_244(Class185.smethod_0(-1141342537), 0, @class.class306_4.int_0);
		@class.class306_5 = new Class306(Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255306), @class.string_0, @class.byte_1.Length);
		num += smethod_243(Class185.smethod_0(-1141342586), smethod_6(@class.method_7, Class185.smethod_0(-1141342654)));
		num += smethod_244(Class185.smethod_0(-1141342659), 0, @class.class306_5.list_0.Count);
		@class.class306_6 = new Class306(Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255306), @class.string_0, @class.byte_1.Length)
		{
			bool_1 = true
		};
		num += smethod_243(Class185.smethod_0(-1141342719), smethod_6(@class.method_8, Class185.smethod_0(-1141343792)));
		num += smethod_243(Class185.smethod_0(-1141343795), !@class.class306_6.bool_0);
		@class.class306_7 = new Class306(Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255306), @class.string_0, @class.byte_1.Length)
		{
			bool_2 = true
		};
		num += smethod_243(Class185.smethod_0(-1141343852), smethod_6(@class.method_9, Class185.smethod_0(-1141343914)));
		num += smethod_243(Class185.smethod_0(-1141343948), !@class.class306_7.bool_0);
		@class.class306_8 = new Class306(Class185.smethod_0(-1141255272), Class185.smethod_0(-1141255306), @class.string_0, @class.byte_1.Length)
		{
			bool_3 = true
		};
		num += smethod_243(Class185.smethod_0(-1141344018), smethod_6(@class.method_10, Class185.smethod_0(-1141344082)));
		Class32 class6 = new Class32(Class185.smethod_0(-1141255272), 10066, Class185.smethod_0(-1141344100), Class185.smethod_0(-1141345378) + @class.string_0 + Class185.smethod_0(-1141345452), @class.string_0);
		Class226 class7 = new Class226(new IntPtr(501));
		Class119 class8 = new Class119();
		try
		{
			class8.method_34(class7);
			class8.method_39(class6);
			class8.method_46(7001u);
			string gparam_ = class8.method_78(27043);
			num += smethod_244(Class185.smethod_0(-1141344145), null, gparam_);
			num += smethod_243(Class185.smethod_0(-1141344198), class8.method_47() == new IntPtr(501) && class7.jobject_0 != null && (string)class7.jobject_0[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141253277) && (string)class7.jobject_0[Class185.smethod_0(-1141342523)] == Class185.smethod_0(-1141255272) && (string)class7.jobject_0[Class185.smethod_0(-1141299812)] == class6.string_2 && (string)class7.jobject_0[Class185.smethod_0(-1141299845)] == @class.string_0 && (int)class7.jobject_0[Class185.smethod_0(-1141255964)] > 0);
		}
		finally
		{
			((IDisposable)class8).Dispose();
		}
		Class226 class9 = new Class226(new IntPtr(502))
		{
			string_0 = Class185.smethod_0(-1141344254)
		};
		Class119 class10 = new Class119();
		try
		{
			class10.method_34(class9);
			class10.method_39(class6);
			class10.method_46(7002u);
			string text = class10.method_78(27043);
			num += smethod_243(Class185.smethod_0(-1141343242), text != null && text.Contains(Class185.smethod_0(-1141344254)) && class10.method_47() == IntPtr.Zero && class9.list_0.Contains(new IntPtr(502)));
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
			num += smethod_243(Class185.smethod_0(-1141343313), text2 != null && text2.Contains(Class185.smethod_0(-1141343372)) && class12.method_47() == IntPtr.Zero && class11.list_0.Contains(new IntPtr(503)));
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
			num += smethod_243(Class185.smethod_0(-1141343393), text3 != null && text3.Contains(Class185.smethod_0(-1141343449)) && class13.method_47() == IntPtr.Zero);
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
			num += smethod_243(Class185.smethod_0(-1141343488), text4 != null && text4.Contains(Class185.smethod_0(-1141343558)) && class15.method_47() == IntPtr.Zero && class14.list_0.Contains(new IntPtr(505)));
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
			num += smethod_243(Class185.smethod_0(-1141343578), text5 != null && text5.Contains(Class185.smethod_0(-1141343642)) && text6 == null && class16.jobject_0 != null && class17.method_47() == new IntPtr(507));
		}
		finally
		{
			((IDisposable)class17).Dispose();
		}
		Console.WriteLine((num == 0) ? Class185.smethod_0(-1141343704) : (Class185.smethod_0(-1141343670) + num));
		return num;
	}

	internal static int smethod_4(string string_0, string string_1)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Class32 @class = Class442.smethod_0(string_0, string_1);
			Console.WriteLine(Class185.smethod_0(-1141343736));
			Console.WriteLine(Class185.smethod_0(-1141348893) + ((JToken)new JObject
			{
				[Class185.smethod_0(-1141342523)] = JToken.op_Implicit(@class.string_0),
				[Class185.smethod_0(-1141299812)] = JToken.op_Implicit(@class.string_2),
				[Class185.smethod_0(-1141299845)] = JToken.op_Implicit(@class.string_3)
			}).ToString((Formatting)0, Array.Empty<JsonConverter>()));
			Console.WriteLine(Class185.smethod_0(-1141348911) + @class.int_0);
			Console.WriteLine(Class185.smethod_0(-1141348914) + (@class.bool_0 ? Class185.smethod_0(-1141348947) : Class185.smethod_0(-1141348941)));
			return 0;
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(Class185.smethod_0(-1141348968) + ex.Message);
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
		throw new InvalidOperationException(Class185.smethod_0(-1141349007));
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
		Console.WriteLine((num == 0) ? Class185.smethod_0(-1141349087) : (Class185.smethod_0(-1141349053) + num));
		return num;
	}

	private static int smethod_9()
	{
		byte[] byte_ = Class103.smethod_5(smethod_18(Class185.smethod_0(-1141349119)), smethod_18(Class185.smethod_0(-1141349162)), smethod_18(Class185.smethod_0(-1141349195)), 42);
		return smethod_244(Class185.smethod_0(-1141349230), Class185.smethod_0(-1141349257), smethod_19(byte_));
	}

	private static int smethod_10()
	{
		Class271 @class = new Class271();
		@class.byte_0 = new byte[32];
		@class.byte_1 = new byte[12];
		byte[] array = new byte[16];
		@class.class66_0 = Class103.smethod_6(@class.byte_0, @class.byte_1, new byte[0], array);
		int num = smethod_244(Class185.smethod_0(-1141349348), Class185.smethod_0(-1141348375), smethod_19(@class.class66_0.byte_0)) + smethod_244(Class185.smethod_0(-1141348414), Class185.smethod_0(-1141348442), smethod_19(@class.class66_0.byte_1)) + smethod_244(Class185.smethod_0(-1141348481), smethod_19(array), smethod_19(Class103.smethod_7(@class.byte_0, @class.byte_1, new byte[0], @class.class66_0.byte_0, @class.class66_0.byte_1)));
		@class.byte_2 = (byte[])@class.class66_0.byte_1.Clone();
		@class.byte_2[0] ^= 1;
		return num + smethod_243(Class185.smethod_0(-1141348521), smethod_14(@class.method_0));
	}

	private static int smethod_11()
	{
		int num = 0;
		byte[] byte_ = smethod_18(Class185.smethod_0(-1141253488));
		byte[] byte_2 = smethod_18(Class185.smethod_0(-1141253527));
		byte[] array = smethod_18(Class185.smethod_0(-1141253614));
		byte[] byte_3 = smethod_18(Class185.smethod_0(-1141348570));
		byte[] byte_4 = smethod_18(Class185.smethod_0(-1141348641));
		byte[] byte_5 = smethod_18(Class185.smethod_0(-1141348778));
		Class393 class393_ = new Class393(7, 1, 1234u, byte_, byte_2, array);
		Class175 class175_ = new Class175(Class185.smethod_0(-1141348809), Class185.smethod_0(-1141348839), Class185.smethod_0(-1141255009), Class185.smethod_0(-1141297686));
		using Class103 @class = Class103.smethod_1(class393_, class175_, byte_3, byte_4, byte_5);
		num += smethod_244(Class185.smethod_0(-1141348852), Class185.smethod_0(-1141348641), smethod_19(@class.byte_0));
		num += smethod_244(Class185.smethod_0(-1141349922), Class185.smethod_0(-1141349976), smethod_19(Class103.smethod_4(byte_3, byte_4, array)));
		num += smethod_244(Class185.smethod_0(-1141350047), Class185.smethod_0(-1141350076), smethod_19(Class103.smethod_2(class175_)));
		num += smethod_244(Class185.smethod_0(-1141350321), Class185.smethod_0(-1141350372), smethod_19(@class.byte_3));
		num += smethod_244(Class185.smethod_0(-1141349593), Class185.smethod_0(-1141349645), smethod_19(@class.byte_2));
		return num + smethod_244(Class185.smethod_0(-1141349676), 93 + @class.byte_3.Length, @class.byte_4.Length);
	}

	private static int smethod_12()
	{
		return smethod_243(Class185.smethod_0(-1141349728), !smethod_14(Class299.class299_0.method_5)) + smethod_243(Class185.smethod_0(-1141349770), smethod_14(Class299.class299_0.method_6)) + smethod_243(Class185.smethod_0(-1141349831), smethod_14(Class299.class299_0.method_7)) + smethod_243(Class185.smethod_0(-1141349867), smethod_14(Class299.class299_0.method_8)) + smethod_243(Class185.smethod_0(-1141346854), smethod_14(Class299.class299_0.method_9)) + smethod_243(Class185.smethod_0(-1141346904), smethod_14(Class299.class299_0.method_10));
	}

	private static int smethod_13()
	{
		Class393 class393_ = new Class393(1, 1, 2u, new byte[16], new byte[32], smethod_18(Class185.smethod_0(-1141253614)));
		Class175 class175_ = new Class175(string.Empty, Class185.smethod_0(-1141303627), Class185.smethod_0(-1141254886), Class185.smethod_0(-1141254891));
		Class103 @class = Class103.smethod_0(class393_, class175_);
		Class103 class2 = Class103.smethod_0(class393_, class175_);
		int num = smethod_243(Class185.smethod_0(-1141346958), !Class80.smethod_1(@class.byte_0, class2.byte_0)) + smethod_243(Class185.smethod_0(-1141346994), !Class80.smethod_1(@class.byte_1, class2.byte_1));
		byte[] byte_ = @class.byte_3;
		byte[] byte_2 = @class.byte_2;
		@class.Dispose();
		int result = num + smethod_243(Class185.smethod_0(-1141347033), byte_.All(Class299.class299_0.method_11)) + smethod_243(Class185.smethod_0(-1141347093), byte_2.All(Class299.class299_0.method_12));
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
		JObject val = smethod_17(Class185.smethod_0(-1141347130));
		string text = (string)val[Class185.smethod_0(-1141346339)] + (string)val[Class185.smethod_0(-1141346361)] + (string)val[Class185.smethod_0(-1141346381)] + (string)val[Class185.smethod_0(-1141346391)];
		return smethod_243(Class185.smethod_0(-1141346408), (int)val[Class185.smethod_0(-1141253449)] == 1 && (string)val[Class185.smethod_0(-1141253472)] == Class185.smethod_0(-1141253488) && (string)val[Class185.smethod_0(-1141346451)] == text && ((object)val).ToString().IndexOf(Class185.smethod_0(-1141348809), StringComparison.Ordinal) < 0 && ((object)val).ToString().IndexOf(Class185.smethod_0(-1141348839), StringComparison.Ordinal) < 0);
	}

	internal static int smethod_16(string string_0, string string_1)
	{
		try
		{
			if (string.IsNullOrWhiteSpace(string_1))
			{
				throw new ArgumentException(Class185.smethod_0(-1141346467), Class185.smethod_0(-1141346498));
			}
			JObject val = smethod_17(string_0);
			File.WriteAllText(string_1, ((JToken)val).ToString((Formatting)1, Array.Empty<JsonConverter>()), new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			Console.WriteLine(Class185.smethod_0(-1141346517));
			Console.WriteLine(Class185.smethod_0(-1141346551) + Path.GetFullPath(string_1));
			return 0;
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(Class185.smethod_0(-1141346565) + ex.Message);
			return 1;
		}
	}

	private static JObject smethod_17(string string_0)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		byte[] array = smethod_18(string_0);
		if (array.Length != 113)
		{
			throw new ArgumentException(Class185.smethod_0(-1141346593), Class185.smethod_0(-1141346641));
		}
		byte[] array2 = new byte[16];
		byte[] array3 = new byte[32];
		byte[] array4 = new byte[65];
		Buffer.BlockCopy(array, 0, array2, 0, array2.Length);
		Buffer.BlockCopy(array, array2.Length, array3, 0, array3.Length);
		Buffer.BlockCopy(array, array2.Length + array3.Length, array4, 0, array4.Length);
		Class393 @class = new Class393(1, 1, 0u, array2, array3, array4);
		Class175 class175_ = new Class175(Class185.smethod_0(-1141348809), Class185.smethod_0(-1141348839), Class135.smethod_2(), Class135.smethod_0());
		using Class103 class2 = Class103.smethod_0(@class, class175_);
		return new JObject
		{
			[Class185.smethod_0(-1141253449)] = JToken.op_Implicit(1),
			[Class185.smethod_0(-1141253472)] = JToken.op_Implicit(@class.method_0()),
			[Class185.smethod_0(-1141346339)] = JToken.op_Implicit(smethod_19(class2.byte_0)),
			[Class185.smethod_0(-1141346361)] = JToken.op_Implicit(smethod_19(class2.byte_1)),
			[Class185.smethod_0(-1141346381)] = JToken.op_Implicit(smethod_19(class2.byte_2)),
			[Class185.smethod_0(-1141346391)] = JToken.op_Implicit(smethod_19(class2.byte_3)),
			[Class185.smethod_0(-1141346451)] = JToken.op_Implicit(smethod_19(class2.byte_4))
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
		throw new ArgumentException(Class185.smethod_0(-1141346652));
	}

	private static string smethod_19(byte[] byte_0)
	{
		StringBuilder stringBuilder = new StringBuilder(byte_0.Length * 2);
		foreach (byte b in byte_0)
		{
			stringBuilder.Append(b.ToString(Class185.smethod_0(-1141346677)));
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
		Console.WriteLine((num == 0) ? Class185.smethod_0(-1141346705) : (Class185.smethod_0(-1141346686) + num));
		return num;
	}

	private static int smethod_21()
	{
		Class201 @class = new Class201();
		int num = 0;
		Class265 class2 = new Class265(new IntPtr(801));
		@class.string_0 = Class185.smethod_0(-1141346730);
		List<string> list = new List<string>();
		using Class119 class3 = smethod_27(class2, 8101u);
		class3.method_2(list.Add);
		@class.int_0 = 0;
		class3.method_38(@class.method_0);
		@class.string_0 = Class185.smethod_0(-1141254988);
		string gparam_ = class3.method_80(27043);
		num += smethod_244(Class185.smethod_0(-1141346760), null, gparam_);
		num += smethod_244(Class185.smethod_0(-1141346788), 1, @class.int_0);
		num += smethod_243(Class185.smethod_0(-1141347861), class3.method_47() == new IntPtr(801) && class2.list_1.IndexOf(Class185.smethod_0(-1141253277)) < class2.list_1.IndexOf(Class185.smethod_0(-1141253410)) && class2.list_1.IndexOf(Class185.smethod_0(-1141253410)) < class2.list_1.IndexOf(Class185.smethod_0(-1141258880)));
		num += smethod_243(Class185.smethod_0(-1141347910), class2.jobject_0 != null && ((string)class2.jobject_0[Class185.smethod_0(-1141346339)]).Length == 130 && ((string)class2.jobject_0[Class185.smethod_0(-1141346361)]).Length == 24 && ((string)class2.jobject_0[Class185.smethod_0(-1141346381)]).Length == 32 && ((string)class2.jobject_0[Class185.smethod_0(-1141346391)]).Length > 0 && ((object)class2.jobject_0).ToString().IndexOf(Class185.smethod_0(-1141254975), StringComparison.Ordinal) < 0 && ((object)class2.jobject_0).ToString().IndexOf(Class185.smethod_0(-1141254988), StringComparison.Ordinal) < 0 && ((object)class2.jobject_0).ToString().IndexOf(Class185.smethod_0(-1141255026), StringComparison.Ordinal) < 0);
		num += smethod_243(Class185.smethod_0(-1141347956), class3.method_47() != IntPtr.Zero && !class3.method_50().bool_0);
		int int_ = class2.int_0;
		class2.method_1();
		num += smethod_244(Class185.smethod_0(-1141348021), int_, class2.int_0);
		class2.method_2(class2.method_0(), bool_4: true, Class185.smethod_0(-1141258943), Class185.smethod_0(-1141303993), 1, 1);
		Class147 class4 = class3.method_50();
		num += smethod_243(Class185.smethod_0(-1141348064), class4.bool_0 && class4.string_1 == Class185.smethod_0(-1141258943) && class4.string_2 == Class185.smethod_0(-1141303993) && class4.int_0 == 1 && class4.int_1 == 1);
		num += smethod_243(Class185.smethod_0(-1141348109), list.TrueForAll(Class299.class299_0.method_13));
		class3.method_210();
		return num + smethod_243(Class185.smethod_0(-1141348151), class2.list_2.IndexOf(Class185.smethod_0(-1141348199)) >= 0 && class2.list_2.IndexOf(Class185.smethod_0(-1141348199)) < class2.list_2.IndexOf(Class185.smethod_0(-1141258974)));
	}

	private static int smethod_22()
	{
		Class265 @class = new Class265(new IntPtr(802));
		using Class119 class2 = smethod_27(@class, 8102u);
		class2.method_38(Class299.class299_0.method_14);
		string text = class2.method_80(27043);
		return smethod_243(Class185.smethod_0(-1141348221), text != null && text.IndexOf(Class185.smethod_0(-1141348271), StringComparison.OrdinalIgnoreCase) >= 0 && @class.int_1 == 0 && class2.method_47() == IntPtr.Zero && @class.list_0.Contains(new IntPtr(802)));
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
		num += smethod_243(Class185.smethod_0(-1141348286), text != null && text.IndexOf(Class185.smethod_0(-1141343372), StringComparison.OrdinalIgnoreCase) >= 0 && class2.method_47() == IntPtr.Zero && @class.list_0.Contains(new IntPtr(803)));
		return num + smethod_243(Class185.smethod_0(-1141348333), @class.list_1.Contains(Class185.smethod_0(-1141348199)));
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
			num += smethod_243(Class185.smethod_0(-1141347346), text != null && text.IndexOf(Class185.smethod_0(-1141347397), StringComparison.OrdinalIgnoreCase) >= 0 && @class.method_47() == IntPtr.Zero);
		}
		using (Class119 class2 = smethod_27(new Class265(new IntPtr(805))
		{
			int_3 = 1
		}, 8105u))
		{
			class2.method_38(smethod_29);
			class2.method_37(Class299.class299_0.method_17);
			string text2 = class2.method_80(27043);
			num += smethod_243(Class185.smethod_0(-1141347419), text2 != null && text2.IndexOf(Class185.smethod_0(-1141347397), StringComparison.OrdinalIgnoreCase) >= 0 && class2.method_47() == IntPtr.Zero);
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
			num += smethod_243(Class185.smethod_0(-1141347458), ex == null && text3 != null && text3.IndexOf(Class185.smethod_0(-1141347520), StringComparison.OrdinalIgnoreCase) >= 0 && class3.list_1.Contains(Class185.smethod_0(-1141348199)) && class4.method_47() == IntPtr.Zero);
		}
		using Class119 class5 = smethod_27(new Class265(new IntPtr(809))
		{
			bool_2 = true
		}, 8109u);
		class5.method_38(smethod_29);
		class5.method_37(Class299.class299_0.method_18);
		string text4 = class5.method_80(27043);
		return num + smethod_243(Class185.smethod_0(-1141347532), text4 != null && text4.IndexOf(Class185.smethod_0(-1141347586), StringComparison.OrdinalIgnoreCase) >= 0 && class5.method_47() == IntPtr.Zero);
	}

	private static int smethod_25()
	{
		int num = 0;
		Class265 @class = new Class265(new IntPtr(806), new IntPtr(807));
		using Class119 class2 = smethod_27(@class, 8106u);
		class2.method_38(smethod_29);
		num += smethod_244(Class185.smethod_0(-1141347618), null, class2.method_80(27043));
		int int_ = @class.method_0();
		class2.method_210();
		class2.method_39(smethod_28());
		num += smethod_244(Class185.smethod_0(-1141347665), null, class2.method_80(27043));
		@class.method_2(int_, bool_4: true, Class185.smethod_0(-1141258943), Class185.smethod_0(-1141347713), 6, 3);
		num += smethod_243(Class185.smethod_0(-1141347733), !class2.method_50().bool_0 && class2.method_50().string_2 != Class185.smethod_0(-1141347713));
		@class.method_2(@class.method_0(), bool_4: true, Class185.smethod_0(-1141258943), Class185.smethod_0(-1141347784), 1, 1);
		return num + smethod_243(Class185.smethod_0(-1141347798), class2.method_50().bool_0 && class2.method_50().string_2 == Class185.smethod_0(-1141347784));
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
		return smethod_243(Class185.smethod_0(-1141352961), text == null && class2.bool_0 && class2.string_1 == Class185.smethod_0(-1141258943) && class2.string_2 == Class185.smethod_0(-1141258958));
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
		return new Class32(Class185.smethod_0(-1141255272), 10066, Class185.smethod_0(-1141344100), Class185.smethod_0(-1141353019), Class185.smethod_0(-1141353121));
	}

	private static Class175 smethod_29()
	{
		return new Class175(string.Empty, Class185.smethod_0(-1141348839), Class185.smethod_0(-1141255009), Class185.smethod_0(-1141255026));
	}

	internal static int smethod_30()
	{
		int int_ = 0;
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141353200));
		string text2 = Path.Combine(text, Class185.smethod_0(-1141353226));
		string currentDirectory = Environment.CurrentDirectory;
		Directory.CreateDirectory(text2);
		try
		{
			Environment.CurrentDirectory = text2;
			int_ += smethod_244(Class185.smethod_0(-1141353264), Path.GetFullPath(Path.Combine(text, Class185.smethod_0(-1141307926), Class185.smethod_0(-1141353289))), Class18.smethod_0(text));
			int_ += smethod_244(Class185.smethod_0(-1141353311), Path.GetFullPath(Path.Combine(text, Class185.smethod_0(-1141307926), Class185.smethod_0(-1141353344))), Class18.smethod_1(text));
			int_ += smethod_243(Class185.smethod_0(-1141353357), !Class384.smethod_3(Class18.smethod_0(text), out var string_));
			int_ += smethod_243(Class185.smethod_0(-1141353394), string_ != null && string_.IndexOf(Class18.smethod_0(text), StringComparison.OrdinalIgnoreCase) >= 0);
			int_ += smethod_244(Class185.smethod_0(-1141353435), Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Class185.smethod_0(-1141307926), Class185.smethod_0(-1141353344))), Class180.smethod_1());
			int_ += smethod_243(Class185.smethod_0(-1141352452), !Class421.smethod_1());
			Struct31 @struct = Class392.smethod_0(Enum3.RunnerMissing, Enum0.Idle);
			int_ += smethod_244(Class185.smethod_0(-1141352497), Class185.smethod_0(-1141302923), @struct.string_0);
			int_ += smethod_243(Class185.smethod_0(-1141352538), @struct.string_1.IndexOf(Class185.smethod_0(-1141352591), StringComparison.OrdinalIgnoreCase) >= 0);
			int_ += smethod_243(Class185.smethod_0(-1141352603), @struct.string_1.IndexOf(Class185.smethod_0(-1141352662), StringComparison.OrdinalIgnoreCase) < 0);
			string text3 = smethod_173(Class185.smethod_0(-1141352676), ref int_);
			int_ += smethod_243(Class185.smethod_0(-1141352723), text3 != null && text3.IndexOf(Class185.smethod_0(-1141352765), StringComparison.Ordinal) >= 0);
			string text4 = smethod_173(Class185.smethod_0(-1141352808), ref int_);
			int_ += smethod_243(Class185.smethod_0(-1141352861), text4 != null && text4.IndexOf(Class185.smethod_0(-1141352902), StringComparison.OrdinalIgnoreCase) < 0);
			string text5 = smethod_173(Class185.smethod_0(-1141352935), ref int_);
			int_ += smethod_243(Class185.smethod_0(-1141353988), text5 != null && text5.IndexOf(Class185.smethod_0(-1141246263), StringComparison.Ordinal) >= 0 && text5.IndexOf(Class185.smethod_0(-1141354019), StringComparison.Ordinal) >= 0);
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
		Console.WriteLine((int_ == 0) ? Class185.smethod_0(-1141354082) : (Class185.smethod_0(-1141354049) + int_));
		return int_;
	}

	internal static int smethod_31()
	{
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141354114));
		try
		{
			Directory.CreateDirectory(Path.Combine(text, Class185.smethod_0(-1141307926)));
			Directory.CreateDirectory(Path.Combine(text, Class185.smethod_0(-1141354158)));
			File.WriteAllText(Path.Combine(text, Class135.smethod_4() + Class185.smethod_0(-1141265149)), Class185.smethod_0(-1141354163));
			File.WriteAllBytes(Path.Combine(text, Class185.smethod_0(-1141307926), Class185.smethod_0(-1141353289)), new byte[1] { 1 });
			string text2 = Path.Combine(text, Class185.smethod_0(-1141307926), Class185.smethod_0(-1141353344));
			File.WriteAllBytes(text2, smethod_41());
			string[] string_ = Class436.string_0;
			foreach (string path in string_)
			{
				File.WriteAllBytes(Path.Combine(text, Class185.smethod_0(-1141354158), path), new byte[1] { 1 });
			}
			num += smethod_243(Class185.smethod_0(-1141354177), Class436.smethod_1(text, out var list_));
			num += smethod_244(Class185.smethod_0(-1141354228), 0, list_.Count);
			num += smethod_243(Class185.smethod_0(-1141354279), Class436.smethod_2(text2));
			File.WriteAllText(Path.Combine(text, Class185.smethod_0(-1141354158), Class185.smethod_0(-1141354320)), Class185.smethod_0(-1141354336));
			num += smethod_243(Class185.smethod_0(-1141354346), !Class436.smethod_1(text, out list_));
			num += smethod_243(Class185.smethod_0(-1141354405), smethod_40(list_, Class185.smethod_0(-1141354320)));
			File.Delete(Path.Combine(text, Class185.smethod_0(-1141354158), Class185.smethod_0(-1141354320)));
			Directory.CreateDirectory(Path.Combine(text, Class185.smethod_0(-1141354158), Class185.smethod_0(-1141354454)));
			num += smethod_243(Class185.smethod_0(-1141354459), !Class436.smethod_1(text, out list_));
			num += smethod_243(Class185.smethod_0(-1141353495), smethod_40(list_, Class185.smethod_0(-1141354454)));
			Directory.Delete(Path.Combine(text, Class185.smethod_0(-1141354158), Class185.smethod_0(-1141354454)));
			File.Move(Path.Combine(text, Class185.smethod_0(-1141354158), Class185.smethod_0(-1141353537)), Path.Combine(text, Class185.smethod_0(-1141354158), Class185.smethod_0(-1141353567)));
			num += smethod_243(Class185.smethod_0(-1141353579), !Class436.smethod_1(text, out list_));
			num += smethod_243(Class185.smethod_0(-1141353639), smethod_40(list_, Class185.smethod_0(-1141353537)));
			File.Move(Path.Combine(text, Class185.smethod_0(-1141354158), Class185.smethod_0(-1141353567)), Path.Combine(text, Class185.smethod_0(-1141354158), Class185.smethod_0(-1141353537)));
			string_ = Class436.string_0;
			foreach (string path2 in string_)
			{
				File.Delete(Path.Combine(text, Class185.smethod_0(-1141354158), path2));
			}
			Directory.Delete(Path.Combine(text, Class185.smethod_0(-1141354158)));
			num += smethod_243(Class185.smethod_0(-1141353682), !Class436.smethod_1(text, out list_));
			Directory.CreateDirectory(Path.Combine(text, Class185.smethod_0(-1141354158)));
			string_ = Class436.string_0;
			foreach (string path3 in string_)
			{
				File.WriteAllBytes(Path.Combine(text, Class185.smethod_0(-1141354158), path3), new byte[1] { 1 });
			}
			string text3 = Class135.smethod_4() + Class185.smethod_0(-1141353743);
			File.WriteAllText(Path.Combine(text, text3), Class185.smethod_0(-1141354336));
			num += smethod_243(Class185.smethod_0(-1141353753), !Class436.smethod_1(text, out list_));
			num += smethod_243(Class185.smethod_0(-1141353802), smethod_40(list_, text3));
			File.Delete(Path.Combine(text, text3));
			File.WriteAllBytes(text2, new byte[20]);
			num += smethod_243(Class185.smethod_0(-1141353849), !Class436.smethod_2(text2));
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
		Console.WriteLine((num == 0) ? Class185.smethod_0(-1141353929) : (Class185.smethod_0(-1141353901) + num));
		return num;
	}

	internal static int smethod_32()
	{
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141353964));
		try
		{
			string text2 = Path.Combine(text, Class185.smethod_0(-1141350942));
			string text3 = Path.Combine(text, Class185.smethod_0(-1141350946), Class185.smethod_0(-1141307926));
			Directory.CreateDirectory(text2);
			Directory.CreateDirectory(text3);
			string text4 = Path.Combine(text2, Class185.smethod_0(-1141353289));
			string text5 = Path.Combine(text3, Class185.smethod_0(-1141353289));
			string text6 = smethod_171(Class185.smethod_0(-1141350961));
			num += smethod_243(Class185.smethod_0(-1141351016), File.Exists(text6));
			if (num == 0)
			{
				File.Copy(text6, text5);
			}
			string string_;
			bool flag = smethod_36(text2, text4, out string_);
			num += smethod_243(Class185.smethod_0(-1141351061), flag);
			if (!flag)
			{
				Console.WriteLine(Class185.smethod_0(-1141351099) + string_);
			}
			if (num == 0)
			{
				string string_2;
				int gparam_ = smethod_37(text4, text5, out string_2);
				num += smethod_244(Class185.smethod_0(-1141351134), 0, gparam_);
				num += smethod_243(Class185.smethod_0(-1141351176), string_2.IndexOf(Class185.smethod_0(-1141351210), StringComparison.Ordinal) >= 0);
				string string_3;
				int gparam_2 = smethod_38(text5, out string_3);
				num += smethod_244(Class185.smethod_0(-1141351246), 0, gparam_2);
				num += smethod_243(Class185.smethod_0(-1141351294), string_3.IndexOf(Class185.smethod_0(-1141351342), StringComparison.Ordinal) >= 0);
				string string_4;
				int gparam_3 = smethod_39(text4, text5, out string_4);
				num += smethod_244(Class185.smethod_0(-1141351376), 0, gparam_3);
				num += smethod_243(Class185.smethod_0(-1141351420), string_4.IndexOf(Class185.smethod_0(-1141350456), StringComparison.Ordinal) >= 0);
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
		Console.WriteLine((num == 0) ? Class185.smethod_0(-1141350522) : (Class185.smethod_0(-1141350494) + num));
		return num;
	}

	internal static int smethod_33(string string_0, string string_1)
	{
		if (LoadLibraryExW(string_0, IntPtr.Zero, 0u) == IntPtr.Zero)
		{
			Console.Error.WriteLine(Class185.smethod_0(-1141350565) + Marshal.GetLastWin32Error());
			return 2;
		}
		if (Class384.smethod_3(string_1, out var string_2))
		{
			Console.Error.WriteLine(Class185.smethod_0(-1141350613));
			return 1;
		}
		if (!string.IsNullOrEmpty(string_2) && string_2.IndexOf(string_1, StringComparison.OrdinalIgnoreCase) >= 0 && string_2.IndexOf(string_0, StringComparison.OrdinalIgnoreCase) >= 0)
		{
			Console.WriteLine(Class185.smethod_0(-1141351210));
			return 0;
		}
		Console.Error.WriteLine(Class185.smethod_0(-1141350657) + (string_2 ?? Class185.smethod_0(-1141350722)));
		return 1;
	}

	internal static int smethod_34(string string_0)
	{
		IntPtr intPtr = LoadLibraryExW(string_0, IntPtr.Zero, 0u);
		if (intPtr == IntPtr.Zero)
		{
			Console.Error.WriteLine(Class185.smethod_0(-1141350743) + Marshal.GetLastWin32Error());
			return 2;
		}
		if (!Class384.smethod_3(string_0, out var string_1))
		{
			Console.Error.WriteLine(Class185.smethod_0(-1141350795) + string_1);
			return 1;
		}
		if (!FreeLibrary(intPtr))
		{
			Console.Error.WriteLine(Class185.smethod_0(-1141350850) + Marshal.GetLastWin32Error());
			return 2;
		}
		try
		{
			if (string.IsNullOrWhiteSpace(Class63.smethod_1(Class63.klx_frida_version())))
			{
				Console.Error.WriteLine(Class185.smethod_0(-1141351938));
				return 1;
			}
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(Class185.smethod_0(-1141351993) + ex.GetType().Name + Class185.smethod_0(-1141301932) + ex.Message);
			return 1;
		}
		Console.WriteLine(Class185.smethod_0(-1141351342));
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
				Console.Error.WriteLine(Class185.smethod_0(-1141352042));
				return 1;
			}
			if (@class.intptr_0 == IntPtr.Zero)
			{
				Console.Error.WriteLine(Class185.smethod_0(-1141352099) + Marshal.GetLastWin32Error());
				return 2;
			}
			if (string.IsNullOrEmpty(string_2) || string_2.IndexOf(string_1, StringComparison.OrdinalIgnoreCase) < 0 || string_2.IndexOf(@class.string_0, StringComparison.OrdinalIgnoreCase) < 0)
			{
				Console.Error.WriteLine(Class185.smethod_0(-1141352157) + (string_2 ?? Class185.smethod_0(-1141350722)));
				return 1;
			}
		}
		finally
		{
			Class384.smethod_1(null);
			Class384.smethod_2(null);
		}
		Console.WriteLine(Class185.smethod_0(-1141350456));
		return 0;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr LoadLibraryExW(string string_0, IntPtr intptr_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool FreeLibrary(IntPtr intptr_0);

	private static bool smethod_36(string string_0, string string_1, out string string_2)
	{
		string_2 = null;
		string text = Class185.smethod_0(-1141352222);
		if (!File.Exists(text))
		{
			string_2 = Class185.smethod_0(-1141352308) + text;
			return false;
		}
		string text2 = Path.Combine(string_0, Class185.smethod_0(-1141352351));
		File.WriteAllText(text2, Class185.smethod_0(-1141352365));
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = Environment.GetEnvironmentVariable(Class185.smethod_0(-1141352443)) ?? Class185.smethod_0(-1141351433);
		processStartInfo.Arguments = Class185.smethod_0(-1141351455) + text + Class185.smethod_0(-1141351465) + string_1 + Class185.smethod_0(-1141351509) + text2 + Class185.smethod_0(-1141351519);
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
		string_2 = Class185.smethod_0(-1141351528) + process.ExitCode + Class185.smethod_0(-1141301932) + text3 + text4;
		return false;
	}

	private static int smethod_37(string string_0, string string_1, out string string_2)
	{
		string location = Assembly.GetExecutingAssembly().Location;
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = location;
		processStartInfo.Arguments = Class185.smethod_0(-1141351532) + string_0 + Class185.smethod_0(-1141351509) + string_1 + Class185.smethod_0(-1141304355);
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
			Arguments = Class185.smethod_0(-1141351570) + string_0 + Class185.smethod_0(-1141304355),
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
		processStartInfo.Arguments = Class185.smethod_0(-1141351622) + string_0 + Class185.smethod_0(-1141351509) + string_1 + Class185.smethod_0(-1141304355);
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
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141351670) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
		File.WriteAllText(text, Class185.smethod_0(-1141351692));
		try
		{
			Class216 @class = new Class216();
			using (SHA256 sHA = SHA256.Create())
			{
				using FileStream inputStream = File.OpenRead(text);
				@class.string_0 = BitConverter.ToString(sHA.ComputeHash(inputStream)).Replace(Class185.smethod_0(-1141293701), string.Empty).ToLowerInvariant();
			}
			@class.long_0 = new FileInfo(text).Length;
			@class.func_0 = @class.method_0;
			num += smethod_243(Class185.smethod_0(-1141351737), Class421.smethod_5(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), @class.func_0).enum3_0 == Enum3.Current);
			Func<string, string, string, int, Class71.Class72> func_ = @class.method_1;
			num += smethod_243(Class185.smethod_0(-1141351798), Class421.smethod_5(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), func_).enum3_0 == Enum3.Unknown);
			Func<string, string, string, int, Class71.Class72> func_2 = @class.method_2;
			num += smethod_243(Class185.smethod_0(-1141351837), Class421.smethod_5(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), func_2).enum3_0 == Enum3.Stale);
			Func<string, string, string, int, Class71.Class72> func_3 = @class.method_3;
			num += smethod_243(Class185.smethod_0(-1141351874), Class421.smethod_5(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), func_3).enum3_0 == Enum3.Unknown);
			Func<string, string, string, int, Class71.Class72> func_4 = @class.method_4;
			num += smethod_243(Class185.smethod_0(-1141351916), Class421.smethod_5(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), func_4).enum3_0 == Enum3.Stale);
			Func<string, string, string, int, Class71.Class72> func_5 = @class.method_5;
			num += smethod_243(Class185.smethod_0(-1141357076), Class421.smethod_5(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), func_5).enum3_0 == Enum3.Current && Class421.smethod_5(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255586), func_5).enum3_0 == Enum3.Stale);
			Class85 class2 = new Class85
			{
				string_1 = Class185.smethod_0(-1141255306)
			};
			Class85 class85_ = new Class85
			{
				string_1 = Class185.smethod_0(-1141255586)
			};
			num += smethod_243(Class185.smethod_0(-1141357113), GForm0.smethod_2(class2, class2, 4L, 4L) && !GForm0.smethod_2(class85_, class2, 5L, 4L));
			num += smethod_243(Class185.smethod_0(-1141357167), Class392.smethod_0(Enum3.Stale, Enum0.Selected).bool_0 && Class392.smethod_0(Enum3.Stale, Enum0.Selected).color_0 == Class392.color_1);
			Class206 class3 = new Class206(@class.long_0, @class.string_0);
			class3.bool_0 = true;
			bool flag = Class421.smethod_16(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), null, class3.method_0, out var string_);
			num += smethod_243(Class185.smethod_0(-1141357214), !flag && class3.string_1 == class3.string_0 && class3.string_2 == class3.string_0 && string_.Contains(Class185.smethod_0(-1141357261)));
			class3 = new Class206(@class.long_0, @class.string_0)
			{
				bool_0 = true,
				bool_1 = true
			};
			flag = Class421.smethod_16(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), null, class3.method_0, out string_);
			num += smethod_243(Class185.smethod_0(-1141357279), !flag && string_.Contains(Class185.smethod_0(-1141258459)) && string_.Contains(Class185.smethod_0(-1141357330)));
			class3 = new Class206(@class.long_0, @class.string_0)
			{
				bool_6 = true
			};
			flag = Class421.smethod_16(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), null, class3.method_0, out string_);
			num += smethod_243(Class185.smethod_0(-1141357359), !flag && class3.int_0 == 0 && class3.string_1 == class3.string_0);
			class3 = new Class206(@class.long_0, @class.string_0)
			{
				bool_2 = true
			};
			flag = Class421.smethod_16(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), null, class3.method_0, out string_);
			num += smethod_243(Class185.smethod_0(-1141357395), !flag && class3.string_1 == class3.string_0 && class3.string_2 == class3.string_0);
			class3 = new Class206(@class.long_0, @class.string_0)
			{
				bool_3 = true
			};
			flag = Class421.smethod_16(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), null, class3.method_0, out string_);
			num += smethod_243(Class185.smethod_0(-1141357444), !flag && class3.string_1 == class3.string_0 && class3.string_2 == class3.string_0 && class3.bool_4);
			@class.int_0 = 0;
			@class.int_1 = 0;
			Stopwatch stopwatch = Stopwatch.StartNew();
			Func<string, string, string, int, Class71.Class72> func_6 = @class.method_6;
			Class82 class4 = Class421.smethod_6(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), func_6, 2250);
			num += smethod_243(Class185.smethod_0(-1141357500), class4.enum3_0 == Enum3.Unknown && @class.int_0 <= 2 && @class.int_1 < 150 && stopwatch.ElapsedMilliseconds < 300L);
			class3 = new Class206(@class.long_0, @class.string_0)
			{
				bool_5 = true
			};
			flag = Class421.smethod_16(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), null, class3.method_0, out string_);
			num += smethod_243(Class185.smethod_0(-1141357548), !flag && class3.string_1 == class3.string_0 && class3.string_2 == class3.string_0);
			class3 = new Class206(@class.long_0, @class.string_0);
			flag = Class421.smethod_16(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), null, class3.method_0, out string_);
			num += smethod_243(Class185.smethod_0(-1141356581), flag && class3.string_1 == @class.string_0 && class3.string_2 == @class.string_0 && class3.int_0 == 1);
			class3 = new Class206(@class.long_0, @class.string_0)
			{
				bool_1 = true
			};
			flag = Class421.smethod_16(text, Class185.smethod_0(-1141255304), Class185.smethod_0(-1141255306), null, class3.method_0, out string_);
			num += smethod_243(Class185.smethod_0(-1141356619), !flag && class3.string_1 == @class.string_0 && class3.string_2 == @class.string_0 && string_.Contains(Class185.smethod_0(-1141258459)) && string_.Contains(Class185.smethod_0(-1141357330)));
		}
		finally
		{
			File.Delete(text);
		}
		Console.WriteLine(Class185.smethod_0(-1141356668) + num + Class185.smethod_0(-1141356690));
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
			num += smethod_243(Class185.smethod_0(-1141356712), Volatile.Read(ref @class.int_0) > 0);
			form.method_1(Keys.F2);
			int num2 = Volatile.Read(ref @class.int_0);
			Thread.Sleep(50);
			return num + smethod_243(Class185.smethod_0(-1141356730), Volatile.Read(ref @class.int_0) == num2);
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
		Dictionary<string, string> ireadOnlyDictionary_ = new Dictionary<string, string> { 
		{
			Class185.smethod_0(-1141356755),
			Class185.smethod_0(-1141356774)
		} };
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
			return num + smethod_244(Class185.smethod_0(-1141356786), Class185.smethod_0(-1141356774), @class.string_0);
		}
		finally
		{
			((IDisposable)form).Dispose();
		}
	}

	internal static int smethod_45()
	{
		int num = 0;
		string text = Class185.smethod_0(-1141356811) + Environment.NewLine + Class185.smethod_0(-1141356873);
		Form0 form = new Form0(Class185.smethod_0(-1141357018), Class185.smethod_0(-1141255306));
		try
		{
			_ = form.Handle;
			FieldInfo field = typeof(Form0).GetField(Class185.smethod_0(-1141357035), BindingFlags.Instance | BindingFlags.NonPublic);
			System.Windows.Forms.Label label = ((field == null) ? null : (field.GetValue(form) as System.Windows.Forms.Label));
			num += smethod_243(Class185.smethod_0(-1141357049), form.Size == new Size(420, 210) && label != null && label.Text == Class185.smethod_0(-1141358114) && label.Height == 22);
			MethodInfo methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
			num += smethod_243(Class185.smethod_0(-1141358140), methodInfo != null);
			if (methodInfo != null)
			{
				methodInfo.Invoke(form, new object[2] { false, text });
				Application.DoEvents();
			}
			FieldInfo field2 = typeof(Form0).GetField(Class185.smethod_0(-1141358184), BindingFlags.Instance | BindingFlags.NonPublic);
			TextBox textBox = ((field2 == null) ? null : (field2.GetValue(form) as TextBox));
			Button button = typeof(Form0).GetField(Class185.smethod_0(-1141358195), BindingFlags.Instance | BindingFlags.NonPublic).GetValue(form) as Button;
			num += smethod_243(Class185.smethod_0(-1141358216), textBox != null && textBox.Text == text && textBox.ReadOnly);
			num += smethod_243(Class185.smethod_0(-1141358250), textBox != null && textBox.Multiline && textBox.WordWrap && textBox.ScrollBars == ScrollBars.Vertical && textBox.Height >= textBox.Font.Height * 3 && textBox.Height <= textBox.Font.Height * 5);
			num += smethod_243(Class185.smethod_0(-1141358292), textBox != null && button != null && textBox.Top >= 109 && textBox.Bottom < button.Top && button.Bottom < form.ClientSize.Height);
			num += smethod_243(Class185.smethod_0(-1141358333), textBox != null && form.Height > 210 && form.Height <= 220 + textBox.Height);
		}
		finally
		{
			((IDisposable)form).Dispose();
		}
		Console.WriteLine(Class185.smethod_0(-1141358362) + num + Class185.smethod_0(-1141356690));
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
		@class.methodInfo_0 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		MethodInfo methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		MethodInfo methodInfo2 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		num = 0 + smethod_243(Class185.smethod_0(-1141358386), @class.methodInfo_0 != null);
		num += smethod_243(Class185.smethod_0(-1141358431), methodInfo != null);
		num += smethod_243(Class185.smethod_0(-1141358471), methodInfo2 != null);
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
				num += smethod_243(Class185.smethod_0(-1141358497), flag2);
				if (flag2)
				{
					num += smethod_244(Class185.smethod_0(-1141358546), Class185.smethod_0(-1141255639), (string)smethod_51(result));
					num += smethod_243(Class185.smethod_0(-1141357574), smethod_50(result));
				}
				num += smethod_243(Class185.smethod_0(-1141357621), class3.int_0 >= 2);
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
				num += smethod_243(Class185.smethod_0(-1141357669), flag3);
				num += smethod_244(Class185.smethod_0(-1141357711), 1, class5.int_0);
				if (flag3)
				{
					num += smethod_244(Class185.smethod_0(-1141357752), null, (string)smethod_51(result2));
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
				num += smethod_243(Class185.smethod_0(-1141357789), flag4);
				num += smethod_244(Class185.smethod_0(-1141357833), 1, class7.int_0);
				if (flag4)
				{
					num += smethod_243(Class185.smethod_0(-1141357884), !smethod_50(result3));
					num += smethod_244(Class185.smethod_0(-1141357938), null, (string)smethod_51(result3));
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
					num += smethod_243(Class185.smethod_0(-1141357997), flag5);
					num += smethod_244(Class185.smethod_0(-1141358035), 1, class9.int_0);
					if (flag5)
					{
						num += smethod_243(Class185.smethod_0(-1141355016), !smethod_50(result4));
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
				num += smethod_243(Class185.smethod_0(-1141355050), flag6);
				if (flag6)
				{
					num += smethod_244(Class185.smethod_0(-1141355111), Class185.smethod_0(-1141255639), (string)smethod_51(result5));
					flag = !smethod_50(result5);
					num += smethod_243(Class185.smethod_0(-1141355159), flag);
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
					smethod_94(class12.class259_0.class339_0.gform0_0, Class185.smethod_0(-1141355214), new Class11(Class185.smethod_0(-1141355230)));
					smethod_94(class12.class259_0.class339_0.gform0_0, Class185.smethod_0(-1141355255), new Class67(Class185.smethod_0(-1141307926)));
					class12.list_0 = new List<string>();
					class12.class259_0.class339_0.class119_0.method_30(class12.method_0);
					class12.class259_0.class339_0.gform0_0.func_0 = class12.class259_0.method_0;
					Task<bool> task = (Task<bool>)methodInfo2.Invoke(class12.class259_0.class339_0.gform0_0, new object[2]
					{
						class12.class259_0.class339_0.class119_0,
						class12.class259_0.class339_0.long_0
					});
					bool flag7 = smethod_96(task);
					num += smethod_243(Class185.smethod_0(-1141355260), flag7);
					if (flag7)
					{
						num += smethod_243(Class185.smethod_0(-1141355328), !task.GetAwaiter().GetResult());
						num += smethod_244(Class185.smethod_0(-1141355379), null, ((Class11)smethod_95(class12.class259_0.class339_0.gform0_0, Class185.smethod_0(-1141355214))).method_0());
						num += smethod_244(Class185.smethod_0(-1141355434), null, ((Class67)smethod_95(class12.class259_0.class339_0.gform0_0, Class185.smethod_0(-1141355255))).method_1());
						num += smethod_243(Class185.smethod_0(-1141355494), !class12.list_0.Any(Class299.class299_0.method_19));
						num += smethod_243(Class185.smethod_0(-1141354513), smethod_95(class12.class259_0.class339_0.gform0_0, Class185.smethod_0(-1141354575)) == null);
						num += smethod_243(Class185.smethod_0(-1141354590), !class12.class259_0.class339_0.class119_0.method_28() && !class12.list_0.Any(Class299.class299_0.method_20));
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
				num += smethod_244(Class185.smethod_0(-1141354635), null, gparam_);
				num += smethod_243(Class185.smethod_0(-1141354666), class13.int_0 >= 2);
				num += smethod_243(Class185.smethod_0(-1141354700), stopwatch.ElapsedMilliseconds >= 100L && stopwatch.ElapsedMilliseconds < 750L);
			}
			finally
			{
				if (class13.class339_0 != null)
				{
					((IDisposable)class13.class339_0).Dispose();
				}
			}
		}
		string text = smethod_173(Class185.smethod_0(-1141354742), ref num);
		if (text != null)
		{
			string text2 = smethod_80(text, Class185.smethod_0(-1141354764), Class185.smethod_0(-1141354785));
			num += smethod_243(Class185.smethod_0(-1141354853), text2 != null && smethod_81(text2, new string[4]
			{
				Class185.smethod_0(-1141354891),
				Class185.smethod_0(-1141354951),
				Class185.smethod_0(-1141354984),
				Class185.smethod_0(-1141356047)
			}));
		}
		string text3 = smethod_174(ref num);
		if (text3 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141356074), text3.Contains(Class185.smethod_0(-1141354891)) && text3.Contains(Class185.smethod_0(-1141356047)));
		}
		Console.WriteLine(Class185.smethod_0(-1141356123) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_48()
	{
		int num = 0;
		num = 0 + smethod_49(Class185.smethod_0(-1141302830));
		num += smethod_49(Class185.smethod_0(-1141302115));
		num += smethod_49(Class185.smethod_0(-1141302136));
		string text = smethod_173(Class185.smethod_0(-1141356151), ref num);
		string text2 = smethod_173(Class185.smethod_0(-1141256766), ref num);
		string text3 = smethod_173(Class185.smethod_0(-1141256340), ref num);
		if (text != null)
		{
			num += smethod_243(Class185.smethod_0(-1141356197), !text.Contains(Class185.smethod_0(-1141356251)) && !text.Contains(Class185.smethod_0(-1141356282)) && text.Contains(Class185.smethod_0(-1141356312)) && text.Contains(Class185.smethod_0(-1141356344)) && text.Contains(Class185.smethod_0(-1141356371)) && smethod_160(text, Class185.smethod_0(-1141356414)) == 1 && smethod_160(text, Class185.smethod_0(-1141356448)) == 1 && smethod_160(text, Class185.smethod_0(-1141356485)) == 1 && smethod_160(text, Class185.smethod_0(-1141356514)) >= 3);
		}
		if (text2 != null)
		{
			string text4 = smethod_80(text2, Class185.smethod_0(-1141363569), Class185.smethod_0(-1141355523));
			num += smethod_243(Class185.smethod_0(-1141355574), text4 != null && smethod_81(text4, new string[5]
			{
				Class185.smethod_0(-1141355618),
				Class185.smethod_0(-1141355644),
				Class185.smethod_0(-1141355701),
				Class185.smethod_0(-1141355738),
				Class185.smethod_0(-1141355774)
			}));
		}
		if (text3 != null)
		{
			string text5 = smethod_80(text3, Class185.smethod_0(-1141256383), Class185.smethod_0(-1141256494));
			string text6 = smethod_80(text3, Class185.smethod_0(-1141256494), Class185.smethod_0(-1141355788));
			string text7 = smethod_80(text3, Class185.smethod_0(-1141355849), Class185.smethod_0(-1141355925));
			string text8 = smethod_80(text3, Class185.smethod_0(-1141355979), Class185.smethod_0(-1141328406));
			num += smethod_243(Class185.smethod_0(-1141328460), text5 != null && text6 != null && text7 != null && text8 != null && text5.Contains(Class185.smethod_0(-1141328534)) && text5.Contains(Class185.smethod_0(-1141328575)) && text6.Contains(Class185.smethod_0(-1141328594)) && text6.Contains(Class185.smethod_0(-1141328575)) && text7.Contains(Class185.smethod_0(-1141328634)) && text7.Contains(Class185.smethod_0(-1141328575)) && text8.Contains(Class185.smethod_0(-1141328575)));
		}
		Console.WriteLine(Class185.smethod_0(-1141328668) + num + Class185.smethod_0(-1141356690));
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
			MethodInfo methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
			string name = ((class2.class254_0.string_0 == Class185.smethod_0(-1141302830)) ? Class185.smethod_0(-1141328762) : ((class2.class254_0.string_0 == Class185.smethod_0(-1141302115)) ? Class185.smethod_0(-1141328736) : Class185.smethod_0(-1141328702)));
			class2.methodInfo_0 = typeof(GForm0).GetMethod(name, BindingFlags.Instance | BindingFlags.NonPublic);
			class2.methodInfo_1 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
			FieldInfo field = typeof(GForm0).GetField(Class185.smethod_0(-1141328793), BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field2 = typeof(GForm0).GetField(Class185.smethod_0(-1141328831), BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field3 = typeof(GForm0).GetField(Class185.smethod_0(-1141328851), BindingFlags.Instance | BindingFlags.NonPublic);
			num += smethod_243(Class185.smethod_0(-1141328876) + class2.class254_0.string_0 + Class185.smethod_0(-1141327885), methodInfo != null && class2.methodInfo_0 != null && class2.methodInfo_1 != null && field != null && field2 != null && field3 != null);
			if (num != 0)
			{
				return num;
			}
			methodInfo.Invoke(class2.class254_0.gform0_0, new object[1] { class2.class254_0.class119_0 });
			field.SetValue(class2.class254_0.gform0_0, new Func<string, Class119, Func<object>, object>(class2.class254_0.method_0));
			field2.SetValue(class2.class254_0.gform0_0, new Action<Class119>(class2.class254_0.method_1));
			MethodInfo methodInfo2 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
			object[] array = new object[2] { null, 0L };
			bool flag = (bool)methodInfo2.Invoke(class2.class254_0.gform0_0, array);
			Class119 class3 = (Class119)array[0];
			long num3 = (long)array[1];
			num += smethod_243(Class185.smethod_0(-1141328876) + class2.class254_0.string_0 + Class185.smethod_0(-1141327901), flag && class3 == class2.class254_0.class119_0);
			class2.object_0 = ((!(class2.class254_0.string_0 == Class185.smethod_0(-1141302136))) ? new object[5]
			{
				class2.class254_0.class119_0,
				num3,
				Class185.smethod_0(-1141327908),
				Class185.smethod_0(-1141327922),
				27043
			} : new object[2]
			{
				class2.class254_0.class119_0,
				num3
			});
			Task result = Task.Factory.StartNew((Func<Task>)class2.method_0, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).GetAwaiter().GetResult();
			num += smethod_243(Class185.smethod_0(-1141328876) + class2.class254_0.string_0 + Class185.smethod_0(-1141327939), result != null && class2.class254_0.manualResetEventSlim_0.Wait(2000));
			Task task = Task.Run((Func<Task>)class2.method_1);
			num += smethod_243(Class185.smethod_0(-1141328876) + class2.class254_0.string_0 + Class185.smethod_0(-1141327954), !task.Wait(100) && class2.class254_0.int_2 == 0 && class2.class254_0.gform0_0.method_7() == null);
			Task result2 = Task.Factory.StartNew((Func<Task>)class2.method_2, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).GetAwaiter().GetResult();
			result2.Wait(1000);
			num += smethod_243(Class185.smethod_0(-1141328876) + class2.class254_0.string_0 + Class185.smethod_0(-1141327981), result2.IsCompleted && !smethod_50(result2) && class2.class254_0.int_0 == 1);
			class2.class254_0.manualResetEventSlim_1.Set();
			num += smethod_243(Class185.smethod_0(-1141328876) + class2.class254_0.string_0 + Class185.smethod_0(-1141328007), Task.WhenAll(task, result).Wait(3000));
			if (smethod_50(result))
			{
				num2++;
			}
			object value = field3.GetValue(class2.class254_0.gform0_0);
			int gparam_ = (int)value.GetType().GetProperty(Class185.smethod_0(-1141328022)).GetValue(value, null);
			num += smethod_244(Class185.smethod_0(-1141328876) + class2.class254_0.string_0 + Class185.smethod_0(-1141328026), 1, class2.class254_0.int_2);
			num += smethod_244(Class185.smethod_0(-1141328876) + class2.class254_0.string_0 + Class185.smethod_0(-1141328055), 0, class2.class254_0.int_1);
			num += smethod_244(Class185.smethod_0(-1141328876) + class2.class254_0.string_0 + Class185.smethod_0(-1141328079), 0, num2);
			num += smethod_244(Class185.smethod_0(-1141328876) + class2.class254_0.string_0 + Class185.smethod_0(-1141328095), (class2.class254_0.string_0 == Class185.smethod_0(-1141302136)) ? Class185.smethod_0(-1141255644) : ((object)true), smethod_51(result));
			num += smethod_244(Class185.smethod_0(-1141328876) + class2.class254_0.string_0 + Class185.smethod_0(-1141328107), 0, gparam_);
		}
		catch (Exception ex)
		{
			Console.WriteLine(Class185.smethod_0(-1141328135) + @class.string_0 + Class185.smethod_0(-1141328166) + ex.GetBaseException().GetType().Name + Class185.smethod_0(-1141301932) + ex.GetBaseException().Message);
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
		PropertyInfo property = task_0.GetType().GetProperty(Class185.smethod_0(-1141307038));
		object obj = ((property == null) ? null : property.GetValue(task_0, null));
		if (obj == null)
		{
			return false;
		}
		PropertyInfo property2 = obj.GetType().GetProperty(Class185.smethod_0(-1141328184), BindingFlags.Instance | BindingFlags.NonPublic);
		if (property2 != null)
		{
			return (bool)property2.GetValue(obj, null);
		}
		return false;
	}

	private static object smethod_51(Task task_0)
	{
		PropertyInfo property = task_0.GetType().GetProperty(Class185.smethod_0(-1141307038));
		object obj = ((property == null) ? null : property.GetValue(task_0, null));
		if (obj == null)
		{
			return null;
		}
		PropertyInfo property2 = obj.GetType().GetProperty(Class185.smethod_0(-1141328198), BindingFlags.Instance | BindingFlags.NonPublic);
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
			Class185.smethod_0(-1141299597),
			Class185.smethod_0(-1141328202),
			Class185.smethod_0(-1141328210),
			Class185.smethod_0(-1141328238),
			Class185.smethod_0(-1141328252),
			Class185.smethod_0(-1141328274),
			Class185.smethod_0(-1141328297),
			Class185.smethod_0(-1141328328),
			Class185.smethod_0(-1141328351),
			Class185.smethod_0(-1141328376),
			Class185.smethod_0(-1141329417),
			Class185.smethod_0(-1141329428),
			Class185.smethod_0(-1141329448),
			Class185.smethod_0(-1141329458),
			Class185.smethod_0(-1141329476),
			Class185.smethod_0(-1141329493)
		};
		for (int i = 0; i < array.Length; i++)
		{
			num += smethod_243(Class185.smethod_0(-1141329498) + i, !Class71.smethod_2(array[i]));
		}
		string[] array2 = new string[4]
		{
			Class185.smethod_0(-1141255586),
			Class185.smethod_0(-1141329542),
			Class185.smethod_0(-1141329555),
			Class185.smethod_0(-1141329581)
		};
		for (int j = 0; j < array2.Length; j++)
		{
			num += smethod_243(Class185.smethod_0(-1141329596) + j, Class71.smethod_2(array2[j]));
		}
		Class71.Class72 class2 = Class71.smethod_1(Class185.smethod_0(-1141329638), Class185.smethod_0(-1141329672), Class185.smethod_0(-1141303611), 1);
		num += smethod_243(Class185.smethod_0(-1141329681), !class2.bool_0 && class2.string_2 == Class185.smethod_0(-1141329749));
		@class.int_0 = 0;
		string[] array3 = array;
		foreach (string string_ in array3)
		{
			int gparam_ = smethod_54(Class185.smethod_0(-1141255304), string_, @class.method_0, Class299.class299_0.method_21, Class299.class299_0.method_22);
			num += smethod_244(Class185.smethod_0(-1141329785), 1, gparam_);
		}
		num += smethod_244(Class185.smethod_0(-1141329817), 0, @class.int_0);
		num += smethod_244(Class185.smethod_0(-1141329857), Class185.smethod_0(-1141329904), Class119.smethod_6());
		num += smethod_243(Class185.smethod_0(-1141329103), Class119.smethod_7(Class71.Class72.smethod_0(Class185.smethod_0(-1141252679)), out var int_, out var string_2) && int_ == 0);
		num += smethod_243(Class185.smethod_0(-1141329151), !Class119.smethod_7(new Class71.Class72(Class185.smethod_0(-1141252679), Class185.smethod_0(-1141329201), bool_2: true, bool_3: false, 0), out int_, out string_2) && string_2.Contains(Class185.smethod_0(-1141329232)));
		@class.func_0 = Class299.class299_0.method_23;
		num += smethod_243(Class185.smethod_0(-1141329243), Class195.smethod_4(@class.func_0(4512, 98765uL), 4512, out var ulong_) && ulong_ == 98765L);
		string gparam_2 = Class119.smethod_13(new Class45(4512, 98765uL), bool_17: false, bool_18: true);
		num += smethod_244(Class185.smethod_0(-1141329293), Class185.smethod_0(-1141329333), gparam_2);
		Class380 class380_ = new Class380
		{
			bool_0 = false,
			bool_1 = true,
			bool_2 = true,
			bool_3 = true,
			string_2 = Class185.smethod_0(-1141326646)
		};
		num += smethod_244(Class185.smethod_0(-1141326671), Enum1.Unknown, Class195.smethod_0(class380_, 27060).enum1_0);
		Class380 class3 = new Class380();
		class3.int_0 = 4512;
		class3.bool_0 = true;
		class3.bool_1 = true;
		class3.string_0 = Class185.smethod_0(-1141252216);
		class3.bool_2 = true;
		class3.bool_3 = true;
		class3.ireadOnlyList_0 = new Class133[1]
		{
			new Class133(4512, Class185.smethod_0(-1141252818), @class.func_0(4512, 100uL), Class185.smethod_0(-1141252171))
		};
		Class380 class4 = class3;
		num += smethod_244(Class185.smethod_0(-1141326709), Enum1.Healthy, Class195.smethod_0(class4, 27060).enum1_0);
		class4.bool_3 = false;
		class4.string_2 = Class185.smethod_0(-1141326757);
		num += smethod_244(Class185.smethod_0(-1141326779), Enum1.Unknown, Class195.smethod_0(class4, 27060).enum1_0);
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
			new Class133(4512, Class185.smethod_0(-1141252818), @class.func_0(4512, 100uL), string.Empty)
		};
		Class380 class380_2 = class3;
		num += smethod_244(Class185.smethod_0(-1141326833), Enum1.Unhealthy, Class195.smethod_0(class380_2, 27060).enum1_0);
		num += smethod_244(Class185.smethod_0(-1141325859), 4512, Class195.smethod_1(class380_2).Single().int_0);
		class3 = new Class380();
		class3.bool_0 = true;
		class3.bool_1 = true;
		class3.bool_2 = true;
		class3.bool_3 = true;
		class3.ireadOnlyList_0 = new Class133[1]
		{
			new Class133(4512, Class185.smethod_0(-1141252818), @class.func_0(4512, 100uL), string.Empty, bool_3: true, bool_4: true, bool_5: false, Class185.smethod_0(-1141325906))
		};
		Class380 class380_3 = class3;
		num += smethod_244(Class185.smethod_0(-1141325942), Enum1.Unknown, Class195.smethod_0(class380_3, 27060).enum1_0);
		num += smethod_243(Class185.smethod_0(-1141325980), Class119.smethod_11(Class185.smethod_0(-1141326021), Class185.smethod_0(-1141255586), 27043, 27060));
		num += smethod_243(Class185.smethod_0(-1141326061), !Class119.smethod_11(Class185.smethod_0(-1141326103), Class185.smethod_0(-1141255586), 27043, 27060));
		num += smethod_243(Class185.smethod_0(-1141326143), !Class119.smethod_11(Class185.smethod_0(-1141326183), Class185.smethod_0(-1141255586), 27043, 27060));
		@class.list_0 = new List<string>();
		Class414 class414_ = new Class414
		{
			func_0 = Class299.class299_0.method_24,
			func_1 = @class.method_1,
			func_2 = @class.method_2,
			func_3 = @class.method_3,
			func_4 = @class.method_4
		};
		Class3 class5 = Class142.smethod_0(Class185.smethod_0(-1141326223), bool_0: true, class414_);
		num += smethod_243(Class185.smethod_0(-1141326262), class5.bool_0 && class5.string_0 == null && string.Join(Class185.smethod_0(-1141326297), @class.list_0) == Class185.smethod_0(-1141326305));
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
			Class3 class7 = Class142.smethod_0(Class185.smethod_0(-1141326223), bool_0: true, new Class414
			{
				func_0 = class6.method_0,
				func_1 = @class.method_5
			});
			num += smethod_243(Class185.smethod_0(-1141327375) + class6.enum1_0.ToString().ToLowerInvariant(), !class7.bool_0);
		}
		Class3 class8 = Class142.smethod_0(Class185.smethod_0(-1141327396), bool_0: true, new Class414
		{
			func_0 = Class299.class299_0.method_25,
			func_1 = @class.method_6
		});
		num += smethod_243(Class185.smethod_0(-1141327435), !class8.bool_0);
		num += smethod_244(Class185.smethod_0(-1141327487), 0, @class.int_1);
		@class.list_1 = new List<string>();
		Class3 class9 = Class142.smethod_0(Class185.smethod_0(-1141326223), bool_0: true, new Class414
		{
			func_0 = Class299.class299_0.method_26,
			func_1 = @class.method_7,
			func_2 = @class.method_8,
			func_3 = @class.method_9,
			func_4 = @class.method_10
		});
		num += smethod_243(Class185.smethod_0(-1141327533), class9.bool_0 && class9.string_0.Contains(Class185.smethod_0(-1141327582)) && string.Join(Class185.smethod_0(-1141326297), @class.list_1) == Class185.smethod_0(-1141327605));
		@class.list_2 = new List<string>();
		@class.bool_1 = true;
		@class.bool_0 = true;
		Class119 class10 = new Class119();
		try
		{
			class10.method_32(Class299.class299_0.method_27);
			class10.method_31(@class.method_11);
			num += smethod_244(Class185.smethod_0(-1141327630), null, class10.method_194(Class185.smethod_0(-1141255304), Class185.smethod_0(-1141342654)));
		}
		finally
		{
			((IDisposable)class10).Dispose();
		}
		num += smethod_243(Class185.smethod_0(-1141327652), @class.list_2.Any(Class299.class299_0.method_28));
		num += smethod_243(Class185.smethod_0(-1141327698), !@class.list_2.Any(Class299.class299_0.method_29));
		num += smethod_243(Class185.smethod_0(-1141327751), @class.list_2.Contains(Class185.smethod_0(-1141253015)));
		@class.list_3 = new List<string>();
		@class.int_2 = 0;
		@class.bool_2 = false;
		Class119 class11 = new Class119();
		try
		{
			class11.method_32(Class299.class299_0.method_30);
			class11.method_31(@class.method_12);
			num += smethod_244(Class185.smethod_0(-1141327789), null, class11.method_194(Class185.smethod_0(-1141255304), Class185.smethod_0(-1141342654)));
		}
		finally
		{
			((IDisposable)class11).Dispose();
		}
		num += smethod_243(Class185.smethod_0(-1141327824), !@class.bool_2 && @class.list_3.Any(Class299.class299_0.method_31));
		@class.list_4 = new List<string>();
		Class119 class12 = new Class119();
		try
		{
			class12.method_32(Class299.class299_0.method_32);
			class12.method_31(@class.method_13);
			int int_2;
			string text = class12.method_192(Class185.smethod_0(-1141255304), Class185.smethod_0(-1141342654), out int_2);
			num += smethod_243(Class185.smethod_0(-1141327860), text?.Contains(Class185.smethod_0(-1141326881)) ?? false);
		}
		finally
		{
			((IDisposable)class12).Dispose();
		}
		num += smethod_243(Class185.smethod_0(-1141326917), !@class.list_4.Any(Class299.class299_0.method_33));
		@class.list_5 = new List<string>();
		Class119 class13 = new Class119();
		try
		{
			class13.method_32(Class299.class299_0.method_34);
			class13.method_31(@class.method_14);
			int int_3;
			string text2 = class13.method_192(Class185.smethod_0(-1141255304), Class185.smethod_0(-1141342654), out int_3);
			num += smethod_243(Class185.smethod_0(-1141326974), text2?.Contains(Class185.smethod_0(-1141326881)) ?? false);
		}
		finally
		{
			((IDisposable)class13).Dispose();
		}
		num += smethod_243(Class185.smethod_0(-1141327012), !@class.list_5.Any(Class299.class299_0.method_35));
		@class.list_6 = new List<string>();
		Class119 class14 = new Class119();
		try
		{
			class14.method_33(Class299.class299_0.method_36);
			class14.method_31(@class.method_15);
			num += smethod_244(Class185.smethod_0(-1141327070), null, class14.method_192(Class185.smethod_0(-1141255304), Class185.smethod_0(-1141342654), out var int_4));
			num += smethod_244(Class185.smethod_0(-1141327100), 27060, int_4);
		}
		finally
		{
			((IDisposable)class14).Dispose();
		}
		num += smethod_243(Class185.smethod_0(-1141327144), !@class.list_6.Any(Class299.class299_0.method_37));
		@class.int_3 = 3776;
		@class.list_7 = new List<string>();
		Class119 class15 = new Class119();
		try
		{
			class15.method_33(Class299.class299_0.method_38);
			class15.method_31(@class.method_16);
			num += smethod_244(Class185.smethod_0(-1141327198), null, class15.method_192(Class185.smethod_0(-1141255304), Class185.smethod_0(-1141342654), out var _));
		}
		finally
		{
			((IDisposable)class15).Dispose();
		}
		num += smethod_243(Class185.smethod_0(-1141327239), @class.list_7.Any(Class299.class299_0.method_39) && !@class.list_7.Any(Class299.class299_0.method_40));
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
			num += smethod_243(Class185.smethod_0(-1141327282), class18.bool_0 && class18.string_0 != null && class16.list_0.SequenceEqual(new IntPtr[2]
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
			num += smethod_244(Class185.smethod_0(-1141327341), null, class19.method_78(27043));
			num += smethod_244(Class185.smethod_0(-1141332496), new IntPtr(21), class19.method_47());
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
			string text3 = class20.method_78(27043);
			num += smethod_243(Class185.smethod_0(-1141332541), text3 != null && text3.Contains(Class185.smethod_0(-1141332591)) && class20.method_47() == IntPtr.Zero && @class.class327_0.list_0.SequenceEqual(new IntPtr[1]
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
			string text4 = class22.method_78(27043);
			num += smethod_243(Class185.smethod_0(-1141332621), text4 != null && class21.manualResetEventSlim_0.IsSet);
			string text5 = class22.method_78(27043);
			num += smethod_243(Class185.smethod_0(-1141332662), text5 != null && text5.Contains(Class185.smethod_0(-1141332698)) && class21.int_1 == 1);
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
			num += smethod_243(Class185.smethod_0(-1141332726), !class22.method_49());
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
			num += smethod_243(Class185.smethod_0(-1141332774), class24.manualResetEventSlim_0.Wait(1000));
			Thread thread2 = new Thread(class23.method_210);
			thread2.Start();
			num += smethod_243(Class185.smethod_0(-1141332821), @class.class327_1.manualResetEventSlim_2.Wait(1000));
			class24.manualResetEventSlim_1.Set();
			num += smethod_243(Class185.smethod_0(-1141332867), !@class.class327_1.bool_1 && thread.Join(1000) && thread2.Join(1000) && !class23.method_49());
			num += smethod_244(Class185.smethod_0(-1141332915), 1, @class.class327_1.int_2);
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
			num += smethod_243(Class185.smethod_0(-1141332973), class26.manualResetEventSlim_0.Wait(1000));
			Thread thread4 = new Thread(@class.method_19);
			thread4.Start();
			num += smethod_243(Class185.smethod_0(-1141331991), thread4.Join(1000));
			class26.manualResetEventSlim_1.Set();
			num += smethod_243(Class185.smethod_0(-1141332030), thread3.Join(1000));
			num += smethod_243(Class185.smethod_0(-1141332059), SpinWait.SpinUntil(class26.method_1, 1000));
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
			num += smethod_243(Class185.smethod_0(-1141332099), class27.manualResetEventSlim_0.Wait(2000));
			Thread thread6 = new Thread(class28.method_0);
			thread6.Start();
			Thread thread7 = new Thread(class28.method_1);
			thread7.Start();
			Thread.Sleep(100);
			num += smethod_244(Class185.smethod_0(-1141332137), 1, class27.int_1);
			num += smethod_244(Class185.smethod_0(-1141332192), 1, class27.int_2);
			class27.manualResetEventSlim_1.Set();
			num += smethod_243(Class185.smethod_0(-1141332237), thread5.Join(2000) && thread7.Join(2000) && thread6.Join(2000));
			num += smethod_244(Class185.smethod_0(-1141332273), 2, class27.int_1);
			num += smethod_244(Class185.smethod_0(-1141332322), 1, class27.int_2);
			class27.bool_0 = false;
		}
		finally
		{
			if (class28.class119_0 != null)
			{
				((IDisposable)class28.class119_0).Dispose();
			}
		}
		Console.WriteLine(Class185.smethod_0(-1141332375) + num + Class185.smethod_0(-1141356690));
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
			Class71.Class72 @class = func_0(string_0, string_1, Class185.smethod_0(-1141303611), 8000);
			smethod_56(Class185.smethod_0(-1141303627), @class, action_0);
			if (smethod_55(@class) && !(@class.string_1.Trim() != Class185.smethod_0(-1141303627)))
			{
				Class71.Class72 class72_ = func_0(string_0, string_1, Class119.smethod_6(), 8000);
				smethod_56(Class185.smethod_0(-1141332462), class72_, action_0);
				if (!Class119.smethod_7(class72_, out var int_, out var string_2))
				{
					action_1(Class185.smethod_0(-1141332468) + string_2);
					return 1;
				}
				Class71.Class72 class2 = func_0(string_0, string_1, Class185.smethod_0(-1141333534), 8000);
				smethod_56(Class185.smethod_0(-1141333581), class2, action_0);
				if (!smethod_55(class2))
				{
					action_1(Class185.smethod_0(-1141333600));
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
						Class71.Class72 class3 = func_0(string_0, string_1, Class185.smethod_0(-1141333637) + num2 + Class185.smethod_0(-1141252105), 8000);
						if (smethod_55(class3) && Class195.smethod_4(class3.string_1, num2, out var ulong_))
						{
							string text = Class119.smethod_13(new Class45(num2, ulong_), bool_17: false, bool_18: true);
							if (text.Contains(Class185.smethod_0(-1141254198)) || !text.EndsWith(Class185.smethod_0(-1141333657), StringComparison.Ordinal))
							{
								break;
							}
							Class71.Class72 class4 = func_0(string_0, string_1, text, 8000);
							smethod_56(Class185.smethod_0(-1141333733) + num2, class4, action_0);
							if (smethod_55(class4) && class4.string_1.Trim() == Class185.smethod_0(-1141333749))
							{
								action_0(Class185.smethod_0(-1141333764) + num2 + Class185.smethod_0(-1141333804) + ulong_ + Class185.smethod_0(-1141333830) + int_);
								return 0;
							}
						}
						num++;
						continue;
					}
					action_1(Class185.smethod_0(-1141333846));
					return 1;
				}
				action_1(Class185.smethod_0(-1141333694));
				return 1;
			}
			action_1(Class185.smethod_0(-1141332431));
			return 1;
		}
		action_1(Class185.smethod_0(-1141332397));
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
			action_0(Class185.smethod_0(-1141333923) + string_0 + Class185.smethod_0(-1141333951));
			return;
		}
		Func<string, string> func = Class299.class299_0.method_54;
		action_0(Class185.smethod_0(-1141333923) + string_0 + Class185.smethod_0(-1141333962) + class72_0.int_0 + Class185.smethod_0(-1141333983) + func(class72_0.string_1) + Class185.smethod_0(-1141333999) + func(class72_0.string_2) + Class185.smethod_0(-1141304355));
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
		InvalidOperationException ex = new InvalidOperationException(Class185.smethod_0(-1141334016));
		Class8 @class = Class8.smethod_5(17L).method_12(Class8.smethod_4(17L)).method_12(Class8.smethod_3(17L))
			.method_12(Class8.smethod_2(17L, ex))
			.method_12(Class8.smethod_1(17L, 73))
			.method_12(Class8.smethod_0(17L));
		num = 0 + smethod_244(Class185.smethod_0(-1141333016), 17L, @class.method_0());
		num += smethod_243(Class185.smethod_0(-1141333056), @class.method_1() && @class.method_2() && @class.method_3() && @class.method_4() && @class.method_5() && @class.method_6());
		num += smethod_243(Class185.smethod_0(-1141333094), ex == @class.method_7());
		num += smethod_244(Class185.smethod_0(-1141333131), 73, @class.method_8());
		num += smethod_244(Class185.smethod_0(-1141333177), (Enum2)4, @class.method_11());
		num += smethod_244(Class185.smethod_0(-1141333231), (Enum2)3, Class8.smethod_5(17L).method_12(Class8.smethod_3(17L)).method_12(Class8.smethod_2(17L, ex))
			.method_11());
		num += smethod_244(Class185.smethod_0(-1141333276), (Enum2)2, Class8.smethod_5(17L).method_12(Class8.smethod_4(17L)).method_11());
		num += smethod_244(Class185.smethod_0(-1141333336), (Enum2)1, Class8.smethod_5(17L).method_11());
		num += smethod_243(Class185.smethod_0(-1141333384), Class8.smethod_5(17L).method_10());
		num += smethod_243(Class185.smethod_0(-1141333418), !Class8.smethod_5(17L).method_12(Class8.smethod_3(17L)).method_10());
		TaskCompletionSource<object> taskCompletionSource = new TaskCompletionSource<object>(TaskCreationOptions.RunContinuationsAsynchronously);
		Class148 class2 = new Class148(17L);
		class2.method_6(taskCompletionSource.Task);
		num += smethod_243(Class185.smethod_0(-1141333473), taskCompletionSource.Task == class2.method_1());
		bool bool_ = false;
		try
		{
			class2.method_6(taskCompletionSource.Task);
		}
		catch (InvalidOperationException)
		{
			bool_ = true;
		}
		num += smethod_243(Class185.smethod_0(-1141330434), bool_);
		num += smethod_243(Class185.smethod_0(-1141330488), class2.method_8());
		num += smethod_243(Class185.smethod_0(-1141330516), class2.method_4());
		bool bool_2 = class2.method_11((Enum5)1);
		bool bool_3 = !class2.method_7();
		num += smethod_243(Class185.smethod_0(-1141330553), bool_2);
		num += smethod_243(Class185.smethod_0(-1141330594), bool_3);
		num += smethod_243(Class185.smethod_0(-1141330634), class2.method_3());
		num += smethod_244(Class185.smethod_0(-1141330674), (Enum5)1, class2.method_2());
		Exception ex3 = class2.method_12(ex);
		InvalidOperationException exception_ = new InvalidOperationException(Class185.smethod_0(-1141330718));
		num += smethod_243(Class185.smethod_0(-1141330743), ex == ex3 && ex3 == class2.method_12(exception_) && ex3 == class2.method_5());
		num += smethod_243(Class185.smethod_0(-1141330780), class2.method_14(17L, taskCompletionSource.Task, ex3));
		num += smethod_243(Class185.smethod_0(-1141330839), !class2.method_14(17L, taskCompletionSource.Task, ex3));
		Class148 class3 = new Class148(18L);
		class3.method_6(Task.CompletedTask);
		Exception ex4 = class3.method_13();
		num += smethod_243(Class185.smethod_0(-1141330888), ex4 == class3.method_13());
		string text = smethod_173(Class185.smethod_0(-1141370944), ref num);
		string text2 = smethod_173(Class185.smethod_0(-1141256766), ref num);
		string text3 = smethod_173(Class185.smethod_0(-1141256340), ref num);
		if (text != null)
		{
			num += smethod_243(Class185.smethod_0(-1141330934), text.Contains(Class185.smethod_0(-1141329937)) && text.Contains(Class185.smethod_0(-1141329986)) && text.Contains(Class185.smethod_0(-1141330035)) && text.Contains(Class185.smethod_0(-1141330074)));
			num += smethod_243(Class185.smethod_0(-1141330113), text.Contains(Class185.smethod_0(-1141330165)) && text.Contains(Class185.smethod_0(-1141330211)));
			num += smethod_243(Class185.smethod_0(-1141330272), text.Contains(Class185.smethod_0(-1141330308)) && text.Contains(Class185.smethod_0(-1141330351)));
		}
		if (text2 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141330378), text2.Contains(Class185.smethod_0(-1141257063)) && text2.Contains(Class185.smethod_0(-1141257152)) && text2.Contains(Class185.smethod_0(-1141330418)) && !text2.Contains(Class185.smethod_0(-1141331492)) && !text2.Contains(Class185.smethod_0(-1141331535)));
			num += smethod_243(Class185.smethod_0(-1141331571), text2.IndexOf(Class185.smethod_0(-1141331617), StringComparison.Ordinal) < 0 && text2.IndexOf(Class185.smethod_0(-1141331639), StringComparison.Ordinal) < 0 && text2.IndexOf(Class185.smethod_0(-1141331653), StringComparison.Ordinal) < 0 && text2.IndexOf(Class185.smethod_0(-1141331672), StringComparison.Ordinal) < 0);
			num += smethod_243(Class185.smethod_0(-1141331683), text2.IndexOf(Class185.smethod_0(-1141331734), StringComparison.Ordinal) < 0 && text2.IndexOf(Class185.smethod_0(-1141331740), StringComparison.Ordinal) < 0);
		}
		if (text3 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141331754), text3.Contains(Class185.smethod_0(-1141331794)));
			num += smethod_243(Class185.smethod_0(-1141331826), text3.Contains(Class185.smethod_0(-1141331878)) && text3.Contains(Class185.smethod_0(-1141331901)) && text3.Contains(Class185.smethod_0(-1141331928)));
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
		smethod_94(obj.gform0_0, Class185.smethod_0(-1141331948), @class);
		Task task = Task.Run((Func<Task>)obj.method_0);
		@class.method_6(task);
		smethod_94(obj.gform0_0, Class185.smethod_0(-1141330958), task);
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
			string text = smethod_80(string_0, Class185.smethod_0(-1141359238), Class185.smethod_0(-1141368451));
			string string_5 = smethod_80(text, Class185.smethod_0(-1141330971), Class185.smethod_0(-1141331005));
			string string_6 = smethod_80(string_0, Class185.smethod_0(-1141331005), Class185.smethod_0(-1141368451));
			string text2 = smethod_80(string_3, Class185.smethod_0(-1141360286), Class185.smethod_0(-1141359426));
			string text3 = smethod_80(string_0, Class185.smethod_0(-1141359116), Class185.smethod_0(-1141359238));
			string text4 = smethod_80(string_2, Class185.smethod_0(-1141360430), Class185.smethod_0(-1141360497));
			string text5 = smethod_80(string_1, Class185.smethod_0(-1141331018), Class185.smethod_0(-1141331103));
			string text6 = smethod_80(string_1, Class185.smethod_0(-1141331181), Class185.smethod_0(-1141331263));
			string text7 = smethod_80(string_1, Class185.smethod_0(-1141331263), Class185.smethod_0(-1141358933));
			string text8 = smethod_80(string_1, Class185.smethod_0(-1141358933), Class185.smethod_0(-1141359000));
			string text9 = smethod_80(string_1, Class185.smethod_0(-1141359000), Class185.smethod_0(-1141331316));
			bool flag = string_0.Contains(Class185.smethod_0(-1141359309)) && string_0.Contains(Class185.smethod_0(-1141359116)) && string_0.Contains(Class185.smethod_0(-1141359238)) && string_0.Contains(Class185.smethod_0(-1141359360)) && string_0.Contains(Class185.smethod_0(-1141359426)) && string_2.Contains(Class185.smethod_0(-1141360430)) && string_1.Contains(Class185.smethod_0(-1141331018)) && string_1.Contains(Class185.smethod_0(-1141331181)) && string_1.Contains(Class185.smethod_0(-1141331263)) && string_1.Contains(Class185.smethod_0(-1141358933)) && string_1.Contains(Class185.smethod_0(-1141359000)) && string_3.Contains(Class185.smethod_0(-1141360286)) && string_3.Contains(Class185.smethod_0(-1141359426)) && !string_0.Contains(Class185.smethod_0(-1141331366)) && !string_0.Contains(Class185.smethod_0(-1141331412)) && !string_3.Contains(Class185.smethod_0(-1141336600));
			bool flag2 = text != null && text2 != null && text3 != null && text4 != null && text5 != null && text6 != null && text7 != null && text8 != null && text9 != null && text.IndexOf(Class185.smethod_0(-1141336635), StringComparison.Ordinal) < 0 && text.IndexOf(Class185.smethod_0(-1141336661), StringComparison.Ordinal) < 0 && text2.IndexOf(Class185.smethod_0(-1141336635), StringComparison.Ordinal) < 0 && text2.IndexOf(Class185.smethod_0(-1141336661), StringComparison.Ordinal) < 0 && text3.IndexOf(Class185.smethod_0(-1141336635), StringComparison.Ordinal) < 0 && text3.IndexOf(Class185.smethod_0(-1141336661), StringComparison.Ordinal) < 0 && text4.IndexOf(Class185.smethod_0(-1141336635), StringComparison.Ordinal) < 0 && text4.IndexOf(Class185.smethod_0(-1141336661), StringComparison.Ordinal) < 0 && text4.IndexOf(Class185.smethod_0(-1141336678), StringComparison.Ordinal) < 0 && text5.IndexOf(Class185.smethod_0(-1141336635), StringComparison.Ordinal) < 0 && text5.IndexOf(Class185.smethod_0(-1141336661), StringComparison.Ordinal) < 0 && text6.IndexOf(Class185.smethod_0(-1141336635), StringComparison.Ordinal) < 0 && text6.IndexOf(Class185.smethod_0(-1141336661), StringComparison.Ordinal) < 0 && text7.IndexOf(Class185.smethod_0(-1141336635), StringComparison.Ordinal) < 0 && text7.IndexOf(Class185.smethod_0(-1141336661), StringComparison.Ordinal) < 0 && text8.IndexOf(Class185.smethod_0(-1141336635), StringComparison.Ordinal) < 0 && text8.IndexOf(Class185.smethod_0(-1141336661), StringComparison.Ordinal) < 0 && text9.IndexOf(Class185.smethod_0(-1141336635), StringComparison.Ordinal) < 0 && text9.IndexOf(Class185.smethod_0(-1141336661), StringComparison.Ordinal) < 0 && smethod_81(text4, new string[5]
			{
				Class185.smethod_0(-1141336709),
				Class185.smethod_0(-1141336766),
				Class185.smethod_0(-1141336824),
				Class185.smethod_0(-1141336887),
				Class185.smethod_0(-1141336951)
			});
			bool flag3 = smethod_81(string_5, new string[4]
			{
				Class185.smethod_0(-1141337024),
				Class185.smethod_0(-1141337086),
				Class185.smethod_0(-1141336089),
				Class185.smethod_0(-1141336150)
			});
			bool flag4 = smethod_81(string_6, new string[4]
			{
				Class185.smethod_0(-1141336192),
				Class185.smethod_0(-1141336254),
				Class185.smethod_0(-1141336283),
				Class185.smethod_0(-1141336330)
			});
			bool flag5 = !string_0.Contains(Class185.smethod_0(-1141336362)) && !string_1.Contains(Class185.smethod_0(-1141336362)) && !string_2.Contains(Class185.smethod_0(-1141336362)) && !string_3.Contains(Class185.smethod_0(-1141336362));
			bool flag6 = string_0.IndexOf(Class185.smethod_0(-1141336386), StringComparison.Ordinal) < 0 && string_4.Contains(Class185.smethod_0(-1141336424)) && string_4.Contains(Class185.smethod_0(-1141336464)) && string_4.IndexOf(Class185.smethod_0(-1141336483), StringComparison.Ordinal) < 0;
			string text10 = smethod_80(string_0, Class185.smethod_0(-1141359426), Class185.smethod_0(-1141336533));
			bool flag7 = text != null && text.Contains(Class185.smethod_0(-1141336537)) && text.Contains(Class185.smethod_0(-1141337626)) && text.Contains(Class185.smethod_0(-1141337669)) && text.Contains(Class185.smethod_0(-1141337676)) && text.Contains(Class185.smethod_0(-1141337713)) && text.Contains(Class185.smethod_0(-1141337755)) && string_0.Contains(Class185.smethod_0(-1141337829)) && text10 != null && !text10.Contains(Class185.smethod_0(-1141337873)) && text2 != null && text2.Contains(Class185.smethod_0(-1141337891)) && text2.Contains(Class185.smethod_0(-1141337916)) && smethod_81(text2, new string[2]
			{
				Class185.smethod_0(-1141337977),
				Class185.smethod_0(-1141338019)
			});
			return flag && flag2 && flag3 && flag4 && flag5 && flag6 && flag7;
		}
		return false;
	}

	private static bool smethod_63(string string_0, string string_1, string string_2, string string_3)
	{
		if (string_0 != null && string_1 != null && string_2 != null && string_3 != null)
		{
			if (string_2.Contains(Class185.smethod_0(-1141359116)) && !string_2.Contains(Class185.smethod_0(-1141331366)) && string_1.Contains(Class185.smethod_0(-1141331103)) && !string_1.Contains(Class185.smethod_0(-1141338059)) && string_0.IndexOf(Class185.smethod_0(-1141337099), StringComparison.Ordinal) < 0 && string_0.IndexOf(Class185.smethod_0(-1141337136), StringComparison.Ordinal) < 0 && string_2.IndexOf(Class185.smethod_0(-1141337171), StringComparison.Ordinal) < 0 && string_3.Contains(Class185.smethod_0(-1141337199)))
			{
				return string_3.Contains(Class185.smethod_0(-1141337230));
			}
			return false;
		}
		return false;
	}

	private static bool smethod_64(string string_0, string string_1, string string_2, string string_3)
	{
		if (string_0 != null && string_1 != null && string_2 != null && string_3 != null)
		{
			if (string_2.Contains(Class185.smethod_0(-1141359116)) && !string_2.Contains(Class185.smethod_0(-1141331366)) && string_0.IndexOf(Class185.smethod_0(-1141337264), StringComparison.Ordinal) < 0 && string_2.IndexOf(Class185.smethod_0(-1141337171), StringComparison.Ordinal) < 0 && string_3.Contains(Class185.smethod_0(-1141337282)) && string_3.Contains(Class185.smethod_0(-1141337313)))
			{
				return string_3.Contains(Class185.smethod_0(-1141337351));
			}
			return false;
		}
		return false;
	}

	private static bool smethod_65(string string_0, string string_1)
	{
		if (string_0 != null && string_1 != null)
		{
			if (smethod_160(string_0, Class185.smethod_0(-1141337379)) >= 4 && smethod_160(string_1, Class185.smethod_0(-1141337379)) >= 6 && !string_0.Contains(Class185.smethod_0(-1141336362)) && !string_1.Contains(Class185.smethod_0(-1141336362)) && !string_0.Contains(Class185.smethod_0(-1141337400)) && !string_1.Contains(Class185.smethod_0(-1141337400)) && string_0.Contains(Class185.smethod_0(-1141337439)))
			{
				return string_1.Contains(Class185.smethod_0(-1141337439));
			}
			return false;
		}
		return false;
	}

	private static bool smethod_66()
	{
		Class263 @class = new Class263();
		@class.methodInfo_0 = typeof(Class412).GetMethod(Class185.smethod_0(-1141337463), BindingFlags.Static | BindingFlags.Public, null, new Type[2]
		{
			typeof(GForm0),
			typeof(uint)
		}, null);
		if (!(@class.methodInfo_0 == null) && !(@class.methodInfo_0.ReturnType != typeof(Task<bool>)))
		{
			FieldInfo field = typeof(Class412).GetField(Class185.smethod_0(-1141337468), BindingFlags.Static | BindingFlags.NonPublic);
			FieldInfo field2 = typeof(Class412).GetField(Class185.smethod_0(-1141337486), BindingFlags.Static | BindingFlags.NonPublic);
			FieldInfo field3 = typeof(Class119).GetField(Class185.smethod_0(-1141337504), BindingFlags.Instance | BindingFlags.NonPublic);
			FieldInfo field4 = typeof(Class357).GetField(Class185.smethod_0(-1141337514), BindingFlags.Static | BindingFlags.NonPublic);
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
						if (!num || class3.class263_0.list_0.Count != 1 || !class3.class263_0.list_0[0].Contains(Class185.smethod_0(-1141337560)) || (uint)field.GetValue(null) != class3.class263_0.class403_0.uint_0 || dateTime == DateTime.MinValue)
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
						if (!smethod_76(class3.class263_0.methodInfo_0, class3.class222_0.gform0_0, class3.class263_0.class403_0.uint_0) || class3.class263_0.list_0.Count != 1 || !class3.class263_0.list_0[0].Contains(Class185.smethod_0(-1141337560)))
						{
							return false;
						}
						class3.class263_0.list_0.Clear();
						field.SetValue(null, 0u);
						class3.class222_0.method_5(bool_0: true, Array.Empty<int>());
						if (!smethod_76(class3.class263_0.methodInfo_0, class3.class222_0.gform0_0, class3.class263_0.class403_0.uint_0) || class3.class263_0.list_0.Count != 1 || !class3.class263_0.list_0[0].Contains(Class185.smethod_0(-1141337590)))
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
						if (!smethod_76(class3.class263_0.methodInfo_0, class3.class222_0.gform0_0, class3.class263_0.class403_0.uint_0) || class3.class263_0.list_0.Count != 3 || !class3.class263_0.list_0[0].Contains(Class185.smethod_0(-1141334530)) || !class3.class263_0.list_0[1].Contains(Class185.smethod_0(-1141334556)) || !class3.class263_0.list_0[2].Contains(Class185.smethod_0(-1141334608)) || class3.class263_0.list_0.Exists(Class299.class299_0.method_55) || (uint)field.GetValue(null) != 0)
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
						if (!smethod_76(class3.class263_0.methodInfo_0, class3.class222_0.gform0_0, class3.class263_0.class403_0.uint_0) || class3.class263_0.list_0.Count != 3 || !class3.class263_0.list_0[0].Contains(Class185.smethod_0(-1141334530)) || !class3.class263_0.list_0[1].Contains(Class185.smethod_0(-1141334556)) || !class3.class263_0.list_0[2].Contains(Class185.smethod_0(-1141334608)) || class3.class263_0.list_0.Exists(Class299.class299_0.method_56) || (uint)field.GetValue(null) != 0)
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
		Dictionary<string, string> dictionary_ = new Dictionary<string, string>(StringComparer.Ordinal) { 
		{
			Class185.smethod_0(-1141334620),
			Class185.smethod_0(-1141334638)
		} };
		Class284 class3 = new Class284();
		class3.class222_0 = new Class222(class2);
		try
		{
			DataGridView dataGridView = smethod_68(class3.class222_0.gform0_0, Class185.smethod_0(-1141278745));
			DataGridView dataGridView2 = (DataGridView)class3.class222_0.gform0_0.Controls.Find(Class185.smethod_0(-1141284112), searchAllChildren: true)[0];
			DataGridView dataGridView3 = (DataGridView)class3.class222_0.gform0_0.Controls.Find(Class185.smethod_0(-1141284636), searchAllChildren: true)[0];
			dataGridView2.Rows.Clear();
			class3.class222_0.gform0_0.bool_3 = false;
			dataGridView2.Rows.Add(new Class290(Class185.smethod_0(-1141296459), class3.method_0), Class185.smethod_0(-1141296459), Class185.smethod_0(-1141296459));
			IReadOnlyList<int> result = class3.class222_0.gform0_0.smethod_18().GetAwaiter().GetResult();
			num += smethod_244(Class185.smethod_0(-1141334655), 1, result?.Count ?? (-1));
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
			dataGridView.Rows[0].Cells[0].Value = Class185.smethod_0(-1141334691);
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
			num += smethod_243(Class185.smethod_0(-1141334709), !Class360.smethod_1(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			@class.list_0.Clear();
			bool result2 = Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243(Class185.smethod_0(-1141334757), result2);
			num += smethod_244(Class185.smethod_0(-1141334791), 0, Class2.smethod_6());
			num += smethod_243(Class185.smethod_0(-1141334832), @class.list_0.Count == 1 && @class.list_0[0].Contains(Class185.smethod_0(-1141254441)) && @class.list_0[0].Contains(Class185.smethod_0(-1141334870)));
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
			bool result3 = Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243(Class185.smethod_0(-1141334875), result3);
			num += smethod_244(Class185.smethod_0(-1141334919), 0, Class2.smethod_6());
			num += smethod_243(Class185.smethod_0(-1141334959), Class412.smethod_2());
			Class360.smethod_33();
			num += smethod_243(Class185.smethod_0(-1141334994), Class360.smethod_1(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_243(Class185.smethod_0(-1141334017), smethod_74(typeof(Class2), Class185.smethod_0(-1141334069), DateTime.Now.AddSeconds(-3.0)));
			Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244(Class185.smethod_0(-1141334085), 1, Class2.smethod_6());
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
			num += smethod_244(Class185.smethod_0(-1141334136), 0, Class2.smethod_6());
			Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244(Class185.smethod_0(-1141334181), 1, Class2.smethod_6());
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
			num += smethod_243(Class185.smethod_0(-1141334230), Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_243(Class185.smethod_0(-1141334257), @class.list_0.Count != 0);
			num += smethod_243(Class185.smethod_0(-1141334303), smethod_74(typeof(Class2), Class185.smethod_0(-1141334351), DateTime.Now.AddSeconds(-2.0)));
			Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244(Class185.smethod_0(-1141334362), 1, Class2.smethod_6());
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
			System.Windows.Forms.Label obj = (System.Windows.Forms.Label)class3.class222_0.gform0_0.Controls.Find(Class185.smethod_0(-1141305504), searchAllChildren: true)[0];
			obj.Text = string.Empty;
			class3.class222_0.gform0_0.bool_3 = false;
			EventHandler value = class3.method_1;
			obj.TextChanged += value;
			@class.list_0.Clear();
			bool result4 = Class2.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			obj.TextChanged -= value;
			num += smethod_243(Class185.smethod_0(-1141334413), result4);
			num += smethod_244(Class185.smethod_0(-1141334460), 0, @class.list_0.Count);
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
			num += smethod_243(Class185.smethod_0(-1141334519), Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_244(Class185.smethod_0(-1141335579), 51, Class188.smethod_13());
			num += smethod_243(Class185.smethod_0(-1141335617), @class.list_0.Count == 1 && @class.list_0[0].Contains(Class185.smethod_0(-1141334870)));
			class3.class222_0.method_0(smethod_78(new List<Class403>(), new Class83
			{
				float_0 = 10f,
				float_1 = 0f,
				float_2 = 0f
			}), bool_0: true);
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243(Class185.smethod_0(-1141335669), Class412.smethod_2());
			class3.class222_0.method_4(5, 18, bool_0: false, Array.Empty<string>());
			class3.class222_0.method_0(smethod_113(new List<Class403> { item }, dictionary_, new Class83
			{
				float_0 = 10f,
				float_1 = 0f,
				float_2 = 0f
			}, 1), bool_0: true);
			Class360.smethod_33();
			num += smethod_243(Class185.smethod_0(-1141335705), Class360.smethod_1(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243(Class185.smethod_0(-1141335756), !Class412.smethod_2());
			Class360.smethod_33();
			num += smethod_243(Class185.smethod_0(-1141335802), !Class360.smethod_1(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			@class.list_0.Clear();
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244(Class185.smethod_0(-1141335850), 52, Class188.smethod_13());
			num += smethod_243(Class185.smethod_0(-1141335898), @class.list_0.Count == 1 && @class.list_0[0].Contains(Class185.smethod_0(-1141335949)));
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
			System.Windows.Forms.Label label = (System.Windows.Forms.Label)class3.class222_0.gform0_0.Controls.Find(Class185.smethod_0(-1141278146), searchAllChildren: true)[0];
			num += smethod_244(Class185.smethod_0(-1141335954), 51, Class188.smethod_13());
			num += smethod_244(Class185.smethod_0(-1141336002), 0, @class.list_0.Count);
			num += smethod_244(Class185.smethod_0(-1141336055), Class185.smethod_0(-1141335071), label.Text);
			num += smethod_243(Class185.smethod_0(-1141335116), smethod_74(typeof(Class188), Class185.smethod_0(-1141335164), DateTime.Now.AddSeconds(-61.0)));
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244(Class185.smethod_0(-1141335179), 51, Class188.smethod_13());
			@class.list_0.Clear();
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244(Class185.smethod_0(-1141335228), 51, Class188.smethod_13());
			num += smethod_244(Class185.smethod_0(-1141335285), 0, @class.list_0.Count);
			num += smethod_244(Class185.smethod_0(-1141335323), Class185.smethod_0(-1141335364), label.Text);
			num += smethod_243(Class185.smethod_0(-1141335417), smethod_74(typeof(Class188), Class185.smethod_0(-1141335466), DateTime.Now.AddSeconds(-61.0)));
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244(Class185.smethod_0(-1141335482), 52, Class188.smethod_13());
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
			num += smethod_243(Class185.smethod_0(-1141335534), smethod_75(typeof(Class188), new int[2] { 52, 51 }, 0));
			class3.class222_0.method_0(smethod_78(new List<Class403>(), class83_), bool_0: true);
			@class.list_0.Clear();
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244(Class185.smethod_0(-1141340701), 52, Class188.smethod_13());
			num += smethod_243(Class185.smethod_0(-1141340760), @class.list_0.Count == 1 && @class.list_0[0].Contains(Class185.smethod_0(-1141340809)));
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
			num += smethod_243(Class185.smethod_0(-1141340830), Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_243(Class185.smethod_0(-1141340857), @class.list_0.Count != 0);
			num += smethod_243(Class185.smethod_0(-1141340903), smethod_74(typeof(Class188), Class185.smethod_0(-1141334351), DateTime.Now.AddSeconds(-2.0)));
			Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_244(Class185.smethod_0(-1141340951), 52, Class188.smethod_13());
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
			System.Windows.Forms.Label obj2 = (System.Windows.Forms.Label)class3.class222_0.gform0_0.Controls.Find(Class185.smethod_0(-1141278146), searchAllChildren: true)[0];
			EventHandler value2 = class3.method_2;
			obj2.TextChanged += value2;
			@class.list_0.Clear();
			bool result5 = Class188.smethod_0(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			obj2.TextChanged -= value2;
			num += smethod_243(Class185.smethod_0(-1141340986), result5);
			num += smethod_244(Class185.smethod_0(-1141341041), 1, @class.list_0.Count);
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
			((RadioButton)gform0_0.Controls.Find(Class185.smethod_0(-1141259832) + array[i], searchAllChildren: true)[0]).Checked = array[i] == int_0;
		}
	}

	private static void smethod_72(GForm0 gform0_0, int int_0, int int_1, bool bool_0)
	{
		((CheckBox)gform0_0.Controls.Find(Class185.smethod_0(-1141306848), searchAllChildren: true)[0]).Checked = int_0 > 0;
		((TextBox)gform0_0.Controls.Find(Class185.smethod_0(-1141306726), searchAllChildren: true)[0]).Text = int_0.ToString();
		((CheckBox)gform0_0.Controls.Find(Class185.smethod_0(-1141306742), searchAllChildren: true)[0]).Checked = int_1 > 0;
		((TextBox)gform0_0.Controls.Find(Class185.smethod_0(-1141306685), searchAllChildren: true)[0]).Text = int_1.ToString();
		((CheckBox)gform0_0.Controls.Find(Class185.smethod_0(-1141279288), searchAllChildren: true)[0]).Checked = bool_0;
	}

	private static void smethod_73(GForm0 gform0_0, bool bool_0, int int_0, int int_1, int int_2, bool bool_1)
	{
		((CheckBox)gform0_0.Controls.Find(Class185.smethod_0(-1141283668), searchAllChildren: true)[0]).Checked = bool_1;
		((CheckBox)gform0_0.Controls.Find(Class185.smethod_0(-1141283485), searchAllChildren: true)[0]).Checked = bool_0;
		((TextBox)gform0_0.Controls.Find(Class185.smethod_0(-1141283661), searchAllChildren: true)[0]).Text = int_0.ToString();
		((TextBox)gform0_0.Controls.Find(Class185.smethod_0(-1141283646), searchAllChildren: true)[0]).Text = int_1.ToString();
		((CheckBox)gform0_0.Controls.Find(Class185.smethod_0(-1141283393), searchAllChildren: true)[0]).Checked = int_2 > 0;
		((TextBox)gform0_0.Controls.Find(Class185.smethod_0(-1141283377), searchAllChildren: true)[0]).Text = int_2.ToString();
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
		FieldInfo field = type_0.GetField(Class185.smethod_0(-1141341089), BindingFlags.Static | BindingFlags.NonPublic);
		FieldInfo field2 = type_0.GetField(Class185.smethod_0(-1141341112), BindingFlags.Static | BindingFlags.NonPublic);
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
			throw new TimeoutException(Class185.smethod_0(-1141341121));
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
		string text = smethod_171(Class185.smethod_0(-1141352808));
		if (text == null)
		{
			return -1;
		}
		string directoryName = Path.GetDirectoryName(text);
		string fullPath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(directoryName), string_1));
		int num = 0;
		string[] files = Directory.GetFiles(directoryName, Class185.smethod_0(-1141341170), SearchOption.AllDirectories);
		for (int i = 0; i < files.Length; i++)
		{
			string fullPath2 = Path.GetFullPath(files[i]);
			if (!string.Equals(fullPath2, fullPath, StringComparison.OrdinalIgnoreCase) && !fullPath2.EndsWith(Class185.smethod_0(-1141340165), StringComparison.OrdinalIgnoreCase) && fullPath2.IndexOf(Class185.smethod_0(-1141340184), StringComparison.OrdinalIgnoreCase) < 0)
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
			num += smethod_243(Class185.smethod_0(-1141340195), task.IsCompleted);
			num += smethod_244(Class185.smethod_0(-1141340239), managedThreadId, task.GetAwaiter().GetResult());
			num += smethod_244(Class185.smethod_0(-1141340272), 1, class2.int_0);
			class2.int_1 = 0;
			Task<int> task2 = Task.Run((Func<Task<int>>)class2.method_1);
			num += smethod_243(Class185.smethod_0(-1141340303), smethod_96(task2));
			if (task2.IsCompleted)
			{
				num += smethod_244(Class185.smethod_0(-1141340331), managedThreadId, task2.GetAwaiter().GetResult());
			}
			num += smethod_244(Class185.smethod_0(-1141340364), 1, class2.int_1);
			CheckBox checkBox = class2.class244_0.gform0_0.Controls.Find(Class185.smethod_0(-1141307681), searchAllChildren: true)[0] as CheckBox;
			RadioButton obj = class2.class244_0.gform0_0.Controls.Find(Class185.smethod_0(-1141279179), searchAllChildren: true)[0] as RadioButton;
			TrackBar trackBar = class2.class244_0.gform0_0.Controls.Find(Class185.smethod_0(-1141278908), searchAllChildren: true)[0] as TrackBar;
			checkBox.Checked = true;
			obj.Checked = true;
			trackBar.Value = trackBar.Minimum + 1;
			Task<bool> task3 = Task.Run((Func<Task<bool>>)class2.class244_0.method_0);
			Task<bool> task4 = Task.Run((Func<Task<bool>>)class2.class244_0.method_1);
			Task<int> task5 = Task.Run((Func<Task<int>>)class2.class244_0.method_2);
			num += smethod_243(Class185.smethod_0(-1141340401), smethod_96(task3));
			num += smethod_243(Class185.smethod_0(-1141340455), smethod_96(task4));
			num += smethod_243(Class185.smethod_0(-1141340501), smethod_96(task5));
			if (task3.IsCompleted)
			{
				num += smethod_243(Class185.smethod_0(-1141340539), task3.GetAwaiter().GetResult());
			}
			if (task4.IsCompleted)
			{
				num += smethod_243(Class185.smethod_0(-1141340583), task4.GetAwaiter().GetResult());
			}
			if (task5.IsCompleted)
			{
				num += smethod_244(Class185.smethod_0(-1141340611), trackBar.Minimum + 1, task5.GetAwaiter().GetResult());
			}
			checkBox.Checked = false;
			obj.Checked = false;
			trackBar.Value = trackBar.Minimum + 2;
			Task<bool> task6 = Task.Run((Func<Task<bool>>)class2.class244_0.method_3);
			Task<bool> task7 = Task.Run((Func<Task<bool>>)class2.class244_0.method_4);
			Task<int> task8 = Task.Run((Func<Task<int>>)class2.class244_0.method_5);
			num += smethod_243(Class185.smethod_0(-1141340655), smethod_96(task6));
			num += smethod_243(Class185.smethod_0(-1141341726), smethod_96(task7));
			num += smethod_243(Class185.smethod_0(-1141341773), smethod_96(task8));
			if (task6.IsCompleted)
			{
				num += smethod_243(Class185.smethod_0(-1141341812), !task6.GetAwaiter().GetResult());
			}
			if (task7.IsCompleted)
			{
				num += smethod_243(Class185.smethod_0(-1141341849), !task7.GetAwaiter().GetResult());
			}
			if (task8.IsCompleted)
			{
				num += smethod_244(Class185.smethod_0(-1141341894), trackBar.Minimum + 2, task8.GetAwaiter().GetResult());
			}
			for (int i = 29; i <= 33; i++)
			{
				((CheckBox)class2.class244_0.gform0_0.Controls.Find(Class185.smethod_0(-1141259842) + i, searchAllChildren: true)[0]).Checked = false;
			}
			((CheckBox)class2.class244_0.gform0_0.Controls.Find(Class185.smethod_0(-1141306139), searchAllChildren: true)[0]).Checked = true;
			((CheckBox)class2.class244_0.gform0_0.Controls.Find(Class185.smethod_0(-1141306086), searchAllChildren: true)[0]).Checked = true;
			((CheckBox)class2.class244_0.gform0_0.Controls.Find(Class185.smethod_0(-1141306029), searchAllChildren: true)[0]).Checked = true;
			Task<List<int>> task9 = Task.Run((Func<Task<List<int>>>)class2.class244_0.method_6);
			num += smethod_243(Class185.smethod_0(-1141341923), smethod_96(task9));
			if (task9.IsCompleted)
			{
				List<int> result = task9.GetAwaiter().GetResult();
				num += smethod_244(Class185.smethod_0(-1141341964), 3, result.Count);
				num += smethod_243(Class185.smethod_0(-1141342001), result.SequenceEqual(new int[3] { 29, 31, 33 }));
			}
			((CheckBox)class2.class244_0.gform0_0.Controls.Find(Class185.smethod_0(-1141306139), searchAllChildren: true)[0]).Checked = false;
			((CheckBox)class2.class244_0.gform0_0.Controls.Find(Class185.smethod_0(-1141306118), searchAllChildren: true)[0]).Checked = true;
			((CheckBox)class2.class244_0.gform0_0.Controls.Find(Class185.smethod_0(-1141306086), searchAllChildren: true)[0]).Checked = false;
			Task<List<int>> task10 = Task.Run((Func<Task<List<int>>>)class2.class244_0.method_7);
			num += smethod_243(Class185.smethod_0(-1141342047), smethod_96(task10));
			if (task10.IsCompleted)
			{
				List<int> result2 = task10.GetAwaiter().GetResult();
				num += smethod_244(Class185.smethod_0(-1141342081), 2, result2.Count);
				num += smethod_243(Class185.smethod_0(-1141342127), result2.SequenceEqual(new int[2] { 30, 33 }));
			}
			DataGridView dataGridView = class2.class244_0.gform0_0.Controls.Find(Class185.smethod_0(-1141281134), searchAllChildren: true)[0] as DataGridView;
			dataGridView.Rows.Add(Class185.smethod_0(-1141342166));
			dataGridView.Rows.Add(Class185.smethod_0(-1141342170));
			Task<IReadOnlyList<string>> task11 = Task.Run((Func<Task<IReadOnlyList<string>>>)class2.class244_0.method_8);
			num += smethod_243(Class185.smethod_0(-1141342189), smethod_96(task11));
			if (task11.IsCompleted)
			{
				IReadOnlyList<string> result3 = task11.GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141341199), result3 != null && !(result3 is Control));
				num += smethod_244(Class185.smethod_0(-1141341226), 2, result3.Count);
				if (result3.Count == 2)
				{
					num += smethod_244(Class185.smethod_0(-1141341264), Class185.smethod_0(-1141342166), result3[0]);
					num += smethod_244(Class185.smethod_0(-1141341294), Class185.smethod_0(-1141342170), result3[1]);
				}
			}
			DataGridView dataGridView2 = class2.class244_0.gform0_0.Controls.Find(Class185.smethod_0(-1141286285), searchAllChildren: true)[0] as DataGridView;
			dataGridView2.Rows.Clear();
			dataGridView2.Rows.Add(Class185.smethod_0(-1141341325));
			dataGridView2.Rows.Add(new object[1]);
			dataGridView2.Rows.Add(Class185.smethod_0(-1141341332));
			dataGridView2.Rows.Add(Class185.smethod_0(-1141342166));
			Task<IReadOnlyList<string>> task12 = Task.Run((Func<Task<IReadOnlyList<string>>>)class2.class244_0.method_9);
			num += smethod_243(Class185.smethod_0(-1141341350), smethod_96(task12));
			if (task12.IsCompleted)
			{
				IReadOnlyList<string> result4 = task12.GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141341389), result4 != null && result4 is IList<string> && ((IList<string>)result4).IsReadOnly);
				num += smethod_244(Class185.smethod_0(-1141341425), 2, result4.Count);
				if (result4.Count == 2)
				{
					num += smethod_244(Class185.smethod_0(-1141341460), Class185.smethod_0(-1141342170), result4[0]);
					num += smethod_244(Class185.smethod_0(-1141341509), Class185.smethod_0(-1141342166), result4[1]);
				}
				bool bool_ = false;
				try
				{
					((IList<string>)result4).Add(Class185.smethod_0(-1141341550));
				}
				catch (NotSupportedException)
				{
					bool_ = true;
				}
				num += smethod_243(Class185.smethod_0(-1141341554), bool_);
			}
			using (GForm0 gForm = new GForm0())
			{
				_ = gForm.Handle;
				DataGridView dataGridView3 = gForm.Controls.Find(Class185.smethod_0(-1141286285), searchAllChildren: true)[0] as DataGridView;
				dataGridView3.Parent.Controls.Remove(dataGridView3);
				num += smethod_243(Class185.smethod_0(-1141341608), gForm.smethod_14().GetAwaiter().GetResult() == null);
				dataGridView3.Dispose();
			}
			StringWriter stringWriter = new StringWriter();
			TextWriterTraceListener textWriterTraceListener = new TextWriterTraceListener(stringWriter);
			Debug.Listeners.Add(textWriterTraceListener);
			try
			{
				num += smethod_243(Class185.smethod_0(-1141341653), !class2.class244_0.gform0_0.smethod_6(9999).GetAwaiter().GetResult());
				num += smethod_243(Class185.smethod_0(-1141341681), !class2.class244_0.gform0_0.smethod_7(9998).GetAwaiter().GetResult());
				num += smethod_243(Class185.smethod_0(-1141338656), class2.class244_0.gform0_0.smethod_8(9999).GetAwaiter().GetResult() == null);
				num += smethod_243(Class185.smethod_0(-1141338688), class2.class244_0.gform0_0.smethod_9(Class185.smethod_0(-1141338713)).GetAwaiter().GetResult() == null);
				num += smethod_244(Class185.smethod_0(-1141338732), 0, class2.class244_0.gform0_0.smethod_10(9999).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141338773), -1, class2.class244_0.gform0_0.smethod_12(new int[1] { 9999 }).GetAwaiter().GetResult());
				class2.class244_0.gform0_0.smethod_13(9999, Class185.smethod_0(-1141338806)).GetAwaiter().GetResult();
				textWriterTraceListener.Flush();
			}
			finally
			{
				Debug.Listeners.Remove(textWriterTraceListener);
				textWriterTraceListener.Dispose();
			}
			string string_ = stringWriter.ToString();
			num += smethod_244(Class185.smethod_0(-1141338812), 1, smethod_160(string_, Class185.smethod_0(-1141338852)));
			num += smethod_244(Class185.smethod_0(-1141338892), 1, smethod_160(string_, Class185.smethod_0(-1141338943)));
			num += smethod_244(Class185.smethod_0(-1141338978), 1, smethod_160(string_, Class185.smethod_0(-1141339022)));
			num += smethod_244(Class185.smethod_0(-1141339061), 1, smethod_160(string_, Class185.smethod_0(-1141339090)));
			num += smethod_244(Class185.smethod_0(-1141339130), 1, smethod_160(string_, Class185.smethod_0(-1141338151)));
			num += smethod_244(Class185.smethod_0(-1141338191), 1, smethod_160(string_, Class185.smethod_0(-1141338220)));
			num += smethod_244(Class185.smethod_0(-1141338271), 1, smethod_160(string_, Class185.smethod_0(-1141338300)));
			GForm0 gForm2 = new GForm0();
			_ = gForm2.Handle;
			gForm2.Dispose();
			Task<int> task13 = gForm2.smethod_0(Class299.class299_0.method_57);
			num += smethod_243(Class185.smethod_0(-1141338337), task13.IsFaulted);
			num += smethod_243(Class185.smethod_0(-1141338381), task13.Exception != null && task13.Exception.InnerException is ObjectDisposedException);
			class2.gform0_0 = new GForm0();
			class2.int_2 = 0;
			num += smethod_243(Class185.smethod_0(-1141338417), !class2.gform0_0.IsHandleCreated);
			Task<int> task14 = Task.Run((Func<Task<int>>)class2.method_3);
			num += smethod_243(Class185.smethod_0(-1141338463), smethod_96(task14));
			num += smethod_243(Class185.smethod_0(-1141338510), task14.IsFaulted && task14.Exception != null && task14.Exception.InnerException is InvalidOperationException);
			num += smethod_244(Class185.smethod_0(-1141338546), 0, class2.int_2);
			class2.gform0_0.Dispose();
			class2.gform0_1 = new GForm0();
			_ = class2.gform0_1.Handle;
			Task<Task<int>> task15 = Task.Factory.StartNew((Func<Task<int>>)class2.method_5, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
			num += smethod_243(Class185.smethod_0(-1141338598), smethod_97(task15));
			Task<int> result5 = task15.GetAwaiter().GetResult();
			class2.gform0_1.Dispose();
			num += smethod_243(Class185.smethod_0(-1141339662), smethod_96(result5));
			num += smethod_243(Class185.smethod_0(-1141339697), result5.IsFaulted && result5.Exception != null && result5.Exception.InnerException is ObjectDisposedException);
			num += smethod_87(class2.class244_0.gform0_0);
			string text = smethod_173(Class185.smethod_0(-1141361147), ref num);
			if (text != null)
			{
				num += smethod_244(Class185.smethod_0(-1141339746), 1, smethod_160(text, Class185.smethod_0(-1141339786)));
				num += smethod_243(Class185.smethod_0(-1141339813), text.IndexOf(Class185.smethod_0(-1141339844), StringComparison.Ordinal) >= 0);
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
		string text = smethod_171(Class185.smethod_0(-1141352808));
		Class278 @class = smethod_168(text);
		num = 0 + smethod_243(Class185.smethod_0(-1141339909), @class.string_0 != null);
		if (@class.string_0 == null)
		{
			return num;
		}
		string directoryName = Path.GetDirectoryName(text);
		MatchCollection matchCollection = Regex.Matches(@class.string_0, Class185.smethod_0(-1141339949), RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
		num += smethod_243(Class185.smethod_0(-1141339991), matchCollection.Count > 0);
		for (int i = 0; i < matchCollection.Count; i++)
		{
			string value = matchCollection[i].Groups[1].Value;
			string path = value.Replace('\\', Path.DirectorySeparatorChar);
			string fullPath = Path.GetFullPath(Path.Combine(directoryName, path));
			if (!fullPath.EndsWith(Path.DirectorySeparatorChar + Class185.smethod_0(-1141340038), StringComparison.OrdinalIgnoreCase) && !fullPath.EndsWith(Path.DirectorySeparatorChar + Class185.smethod_0(-1141340056), StringComparison.OrdinalIgnoreCase))
			{
				Class278 class2 = smethod_168(fullPath);
				num += smethod_243(Class185.smethod_0(-1141340068) + value, class2.string_0 != null);
				if (class2.string_0 != null)
				{
					num += smethod_244(Class185.smethod_0(-1141340118) + value, 0, Regex.Matches(class2.string_0, Class185.smethod_0(-1141340148), RegexOptions.CultureInvariant).Count);
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
		smethod_94(gform0_0, Class185.smethod_0(-1141256027), class119_0);
		smethod_93(class119_0, bool_0: true, bool_1: true);
		smethod_94(gform0_0, Class185.smethod_0(-1141339157), true);
		Class148 @class = new Class148(long_1);
		@class.method_6(task_0);
		smethod_94(gform0_0, Class185.smethod_0(-1141331948), @class);
		smethod_94(gform0_0, Class185.smethod_0(-1141330958), task_0);
		gform0_0.bool_2 = true;
		gform0_0.bool_3 = false;
		gform0_0.bool_4 = false;
		gform0_0.method_92((Enum11)2);
		return @class;
	}

	private static void smethod_93(Class119 class119_0, bool bool_0, bool bool_1)
	{
		typeof(Class119).GetField(Class185.smethod_0(-1141259787), BindingFlags.Instance | BindingFlags.NonPublic).SetValue(class119_0, bool_0 ? 1 : 0);
		typeof(Class119).GetField(Class185.smethod_0(-1141339170), BindingFlags.Instance | BindingFlags.NonPublic).SetValue(class119_0, bool_1 ? 1 : 0);
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
		num = 0 + smethod_243(Class185.smethod_0(-1141339187), !Class172.smethod_0(Class185.smethod_0(-1141339222)));
		num += smethod_243(Class185.smethod_0(-1141339244), !Class172.smethod_0(Class185.smethod_0(-1141339280)));
		num += smethod_243(Class185.smethod_0(-1141339310), !Class172.smethod_0(Class185.smethod_0(-1141339329)));
		num += smethod_243(Class185.smethod_0(-1141339366), Class172.smethod_0(Class185.smethod_0(-1141339390)));
		num += smethod_243(Class185.smethod_0(-1141339402), Class172.smethod_0(Class185.smethod_0(-1141339436)));
		Class172.bool_0 = false;
		num += smethod_243(Class185.smethod_0(-1141339477), Class172.smethod_0(Class185.smethod_0(-1141339499)));
		Class172.bool_0 = true;
		string text = Class172.smethod_7(7u, 101, Class185.smethod_0(-1141339526), 0f, 0f, 0f, 1f, 10f, 0f, 1f, 10f, 0f, 10.05f, 1f, 10f, Class185.smethod_0(-1141254478), 12, 3456L, 9);
		num += smethod_243(Class185.smethod_0(-1141339530), text.IndexOf(Class185.smethod_0(-1141339568), StringComparison.Ordinal) >= 0 && text.IndexOf(Class185.smethod_0(-1141339570), StringComparison.Ordinal) >= 0);
		num += smethod_243(Class185.smethod_0(-1141339617), text.IndexOf(Class185.smethod_0(-1141312001), StringComparison.Ordinal) >= 0);
		string text2 = Class172.smethod_7(7u, 101, Class185.smethod_0(-1141339526), 0f, 0f, 0f, 10.004f, 0f, 0f, 10.004f, 0f, 0f, 10.004f, 10.004f, 10f, Class185.smethod_0(-1141254478), 12, 3456L, 9);
		num += smethod_243(Class185.smethod_0(-1141312051), text2.IndexOf(Class185.smethod_0(-1141312092), StringComparison.Ordinal) >= 0 && text2.IndexOf(Class185.smethod_0(-1141312118), StringComparison.Ordinal) < 0);
		string text3 = Class172.smethod_7(8u, 101, Class185.smethod_0(-1141312143), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 10f, Class185.smethod_0(-1141308140), 1, 2L, 3);
		num += smethod_243(Class185.smethod_0(-1141312166), text3.IndexOf('\r') < 0 && text3.IndexOf('\n') < 0 && text3.IndexOf(Class185.smethod_0(-1141312187), StringComparison.Ordinal) >= 0);
		Class172.Class173 @class = new Class172.Class173();
		DateTime dateTime_ = new DateTime(2026, 9, 17, 0, 0, 0, DateTimeKind.Utc);
		num += smethod_243(Class185.smethod_0(-1141312221), @class.method_0(Class185.smethod_0(-1141312238), bool_0: false, dateTime_));
		num += smethod_243(Class185.smethod_0(-1141312256), !@class.method_0(Class185.smethod_0(-1141312238), bool_0: false, dateTime_.AddMilliseconds(999.0)));
		num += smethod_243(Class185.smethod_0(-1141312280), @class.method_0(Class185.smethod_0(-1141312238), bool_0: false, dateTime_.AddMilliseconds(1000.0)));
		num += smethod_243(Class185.smethod_0(-1141312309), @class.method_0(Class185.smethod_0(-1141312334), bool_0: false, dateTime_.AddMilliseconds(1001.0)));
		num += smethod_243(Class185.smethod_0(-1141312352), @class.method_0(Class185.smethod_0(-1141312369), bool_0: false, dateTime_.AddMilliseconds(1002.0)));
		num += smethod_243(Class185.smethod_0(-1141312387), @class.method_0(Class185.smethod_0(-1141312369), bool_0: true, dateTime_.AddMilliseconds(1003.0)));
		num += smethod_243(Class185.smethod_0(-1141312424), !@class.method_0(Class185.smethod_0(-1141312369), bool_0: true, dateTime_.AddMilliseconds(1004.0)));
		Class172.Class173 class2 = new Class172.Class173();
		num += smethod_243(Class185.smethod_0(-1141312443), class2.method_0(Class185.smethod_0(-1141312468), bool_0: false, dateTime_));
		num += smethod_243(Class185.smethod_0(-1141312490), !class2.method_0(Class185.smethod_0(-1141312468), bool_0: false, dateTime_.AddMilliseconds(600.0)));
		Console.WriteLine(Class185.smethod_0(-1141311507) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_101()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		int num = 0;
		num = 0 + smethod_244(Class185.smethod_0(-1141311535), Class185.smethod_0(-1141311546), Class454.smethod_1(new int[3] { 1, 3, 5 }));
		num += smethod_244(Class185.smethod_0(-1141311598), Class185.smethod_0(-1141311609), Class454.smethod_1(new int[0]));
		IReadOnlyList<GStruct1> readOnlyList = Class119.smethod_17((JObject)JToken.Parse(Class185.smethod_0(-1141311656)));
		num += smethod_244(Class185.smethod_0(-1141311787), 3, readOnlyList.Count);
		if (readOnlyList.Count == 3)
		{
			num += smethod_244(Class185.smethod_0(-1141311804), 1, readOnlyList[0].int_0);
			num += smethod_243(Class185.smethod_0(-1141311820), readOnlyList[0].bool_0);
			num += smethod_244(Class185.smethod_0(-1141311854), 8, readOnlyList[1].int_1);
			num += smethod_243(Class185.smethod_0(-1141311870), !readOnlyList[1].bool_0);
			num += smethod_244(Class185.smethod_0(-1141311901), -1, readOnlyList[2].int_1);
			num += smethod_243(Class185.smethod_0(-1141311917), !readOnlyList[2].bool_0);
		}
		num += smethod_243(Class185.smethod_0(-1141311949), new GStruct1(3, 0).bool_0);
		num += smethod_243(Class185.smethod_0(-1141311969), !new GStruct1(1, 8).bool_0);
		num += smethod_243(Class185.smethod_0(-1141313025), !new GStruct1(2, -1).bool_0);
		FieldInfo field = typeof(Class357).GetField(Class185.smethod_0(-1141337514), BindingFlags.Static | BindingFlags.NonPublic);
		FieldInfo field2 = typeof(Class119).GetField(Class185.smethod_0(-1141337504), BindingFlags.Instance | BindingFlags.NonPublic);
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
				num += smethod_243(Class185.smethod_0(-1141313058), result && @class.list_0.Count == 3 && @class.list_0[0].Contains(Class185.smethod_0(-1141334530)) && @class.list_0[1].Contains(Class185.smethod_0(-1141334556)) && @class.list_0[2].Contains(Class185.smethod_0(-1141334608)));
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
		num += smethod_243(Class185.smethod_0(-1141313111), smethod_66());
		Console.WriteLine(Class185.smethod_0(-1141313153) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_102()
	{
		int num = 0;
		num = 0 + smethod_244(Class185.smethod_0(-1141313172), Class185.smethod_0(-1141313187), Class440.smethod_3(12.5f, -7.25f));
		Class412.smethod_6(3f, 9f, 4f);
		num += smethod_243(Class185.smethod_0(-1141313211), Class412.smethod_2());
		num += smethod_243(Class185.smethod_0(-1141313233), Class412.smethod_2() == Class412.smethod_1().bool_0);
		num += smethod_244(Class185.smethod_0(-1141313275), Class185.smethod_0(-1141313298), Class412.smethod_8());
		Class412.smethod_7();
		num += smethod_243(Class185.smethod_0(-1141313328), !Class412.smethod_2());
		num += smethod_243(Class185.smethod_0(-1141313352), Class412.smethod_2() == Class412.smethod_1().bool_0);
		num += smethod_244(Class185.smethod_0(-1141313388), Class185.smethod_0(-1141293701), Class412.smethod_8());
		Console.WriteLine(Class185.smethod_0(-1141313421) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_103()
	{
		int num = 0;
		num = 0 + smethod_244(Class185.smethod_0(-1141313439), Class185.smethod_0(-1141313460), Class397.smethod_0(3, 77u, 1234u));
		string text = smethod_174(ref num);
		if (text != null)
		{
			num += smethod_243(Class185.smethod_0(-1141313517), text.Contains(Class185.smethod_0(-1141312542)));
			num += smethod_243(Class185.smethod_0(-1141312648), text.Contains(Class185.smethod_0(-1141312684)));
			num += smethod_243(Class185.smethod_0(-1141312733), text.Contains(Class185.smethod_0(-1141312777)));
		}
		Dictionary<string, string> dictionary_ = new Dictionary<string, string>(StringComparer.Ordinal)
		{
			{
				Class185.smethod_0(-1141334620),
				Class185.smethod_0(-1141339526)
			},
			{
				Class185.smethod_0(-1141312871),
				Class185.smethod_0(-1141276712)
			},
			{
				Class185.smethod_0(-1141312873),
				Class185.smethod_0(-1141312883)
			}
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
		num += smethod_244(Class185.smethod_0(-1141312926), Class185.smethod_0(-1141339526), Class447.smethod_3(class145_, @class));
		num += smethod_243(Class185.smethod_0(-1141312938), Class447.smethod_3(class145_, class2) == null);
		num += smethod_243(Class185.smethod_0(-1141312973), Class360.smethod_32(smethod_114(new string[1] { Class185.smethod_0(-1141312985) }), Class185.smethod_0(-1141313005)));
		num += smethod_243(Class185.smethod_0(-1141313009), Class360.smethod_32(smethod_114(new string[1] { Class185.smethod_0(-1141309974) }), Class185.smethod_0(-1141312985)));
		num += smethod_243(Class185.smethod_0(-1141309990), Class360.smethod_32(smethod_114(new string[1] { Class185.smethod_0(-1141310011) }), Class185.smethod_0(-1141312985)));
		num += smethod_243(Class185.smethod_0(-1141310029), !Class360.smethod_32(smethod_114(Array.Empty<string>()), Class185.smethod_0(-1141312985)));
		num += smethod_243(Class185.smethod_0(-1141310049), !Class360.smethod_32(smethod_114(new string[1] { Class185.smethod_0(-1141312985) }), null));
		num += smethod_243(Class185.smethod_0(-1141310076), !Class360.smethod_32(smethod_114(new string[1] { Class185.smethod_0(-1141312985) }), string.Empty));
		DataGridView dataGridView = new DataGridView();
		dataGridView.Columns.Add(Class185.smethod_0(-1141310112), Class185.smethod_0(-1141310115));
		dataGridView.Rows.Add(Class185.smethod_0(-1141312985));
		num += smethod_243(Class185.smethod_0(-1141310134), Class360.smethod_32(dataGridView, Class185.smethod_0(-1141312985)));
		num += smethod_243(Class185.smethod_0(-1141310158), !Class360.smethod_32(dataGridView, Class185.smethod_0(-1141310184)));
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
		num += smethod_243(Class185.smethod_0(-1141310197), Class360.smethod_27(class145_2, class83_, bool_5: false, 0f, 0f, 0f, 100f, 22, bool_6: false, bool_7: false, 0, bool_8: false, null) == null);
		num += smethod_243(Class185.smethod_0(-1141310212), Class360.smethod_27(class145_2, class83_, bool_5: false, 0f, 0f, 0f, 100f, -1, bool_6: false, bool_7: false, 0, bool_8: false, null) == null);
		num += smethod_243(Class185.smethod_0(-1141310236), Class360.smethod_27(class145_2, class83_, bool_5: false, 0f, 0f, 0f, 100f, 19, bool_6: false, bool_7: false, 0, bool_8: false, null) == class4);
		num += smethod_243(Class185.smethod_0(-1141310271), Class360.smethod_27(class145_2, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class3);
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
		DataGridView dataGridView_ = smethod_114(new string[1] { Class185.smethod_0(-1141339526) });
		Class403 class7 = Class360.smethod_27(class145_3, class83_, bool_5: false, 0f, 0f, 0f, 100f, 20, bool_6: false, bool_7: false, 0, bool_8: false, dataGridView_);
		num += smethod_243(Class185.smethod_0(-1141310292), class7 != class6);
		num += smethod_243(Class185.smethod_0(-1141310333), class7 == class5);
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
		DataGridView dataGridView_2 = smethod_114(new string[1] { Class185.smethod_0(-1141339526) });
		Class403 class10 = Class360.smethod_27(class145_4, class83_, bool_5: false, 0f, 0f, 0f, 100f, 21, bool_6: false, bool_7: false, 0, bool_8: false, dataGridView_2);
		num += smethod_243(Class185.smethod_0(-1141310360), class10 != class8);
		num += smethod_243(Class185.smethod_0(-1141310380), class10 == class9);
		Class403 class11 = new Class403
		{
			uint_0 = 40u,
			byte_0 = 102,
			float_0 = 5f,
			float_1 = 0f,
			float_2 = 0f
		};
		Class145 class145_5 = smethod_113(new List<Class403> { class11 }, dictionary_, class83_, 1);
		num += smethod_243(Class185.smethod_0(-1141310409), Class360.smethod_27(class145_5, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: true, bool_7: false, 0, bool_8: false, null) == null);
		num += smethod_243(Class185.smethod_0(-1141310447), Class360.smethod_27(class145_5, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class11);
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
		num += smethod_243(Class185.smethod_0(-1141309443), Class360.smethod_27(class145_6, class83_, bool_5: false, 0f, 0f, 0f, 100f, 20, bool_6: false, bool_7: true, 0, bool_8: false, dataGridView_3) == null);
		num += smethod_243(Class185.smethod_0(-1141309479), Class360.smethod_27(class145_6, class83_, bool_5: false, 0f, 0f, 0f, 100f, 20, bool_6: false, bool_7: false, 0, bool_8: false, dataGridView_3) == class12);
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
		num += smethod_243(Class185.smethod_0(-1141309497), Class360.smethod_27(class145_7, class83_, bool_5: true, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: true, null) == null);
		Class145 class145_8 = smethod_113(new List<Class403> { class13 }, dictionary_, class83_, 1);
		num += smethod_243(Class185.smethod_0(-1141309536), Class360.smethod_27(class145_8, class83_, bool_5: true, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: true, null) == class13);
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
		num += smethod_243(Class185.smethod_0(-1141309566), Class360.smethod_27(class145_9, class83_2, bool_5: true, 0f, 0f, 0f, 50f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class14);
		num += smethod_243(Class185.smethod_0(-1141309586), Class360.smethod_27(class145_9, class83_2, bool_5: false, 0f, 0f, 0f, 50f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class15);
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
		num += smethod_243(Class185.smethod_0(-1141309619), Class360.smethod_27(class145_10, class83_3, bool_5: true, 0f, 0f, 0f, 30f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class16);
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
		num += smethod_243(Class185.smethod_0(-1141309660), Class360.smethod_27(class145_11, class83_, bool_5: false, 0f, 0f, 0f, 100f, 19, bool_6: false, bool_7: false, 0, bool_8: false, null) == class17);
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
		num += smethod_243(Class185.smethod_0(-1141309698), Class360.smethod_27(class145_12, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class18);
		num += smethod_243(Class185.smethod_0(-1141309721), Class360.smethod_27(class145_12, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: true, 0, bool_8: false, null) == null);
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
		num += smethod_243(Class185.smethod_0(-1141309752), class21 != class19);
		num += smethod_243(Class185.smethod_0(-1141309780), class21 == class20);
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
		num += smethod_243(Class185.smethod_0(-1141309823), Class360.smethod_27(class145_13, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, Class360.smethod_0(6), bool_8: false, null) == null);
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
		num += smethod_243(Class185.smethod_0(-1141309836), Class360.smethod_27(class145_14, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class22);
		num += smethod_243(Class185.smethod_0(-1141309864), Class360.smethod_27(class145_15, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class23);
		num += smethod_243(Class185.smethod_0(-1141309886), Class360.smethod_27(class145_14, class83_, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: true, 0, bool_8: false, null) == null);
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
		num += smethod_243(Class185.smethod_0(-1141309906), Class360.smethod_27(class145_16, class83_5, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, int_, bool_8: false, null) == null);
		num += smethod_243(Class185.smethod_0(-1141309949), Class360.smethod_27(class145_16, class83_5, bool_5: false, 0f, 0f, 0f, 100f, 20, bool_6: false, bool_7: false, int_, bool_8: false, smethod_114(Array.Empty<string>())) == null);
		num += smethod_243(Class185.smethod_0(-1141311015), Class360.smethod_27(class145_16, class83_5, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, 0, bool_8: false, null) == class24);
		Class145 class145_17 = smethod_113(new List<Class403> { item6, class26 }, dictionary_, class83_4, 1);
		num += smethod_243(Class185.smethod_0(-1141311048), Class360.smethod_27(class145_17, class83_4, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, int_, bool_8: false, null) == class26);
		Class145 class145_18 = smethod_113(new List<Class403> { class24, class25 }, dictionary_, class83_6, 1);
		num += smethod_243(Class185.smethod_0(-1141311076), Class360.smethod_27(class145_18, class83_6, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, int_2, bool_8: false, null) == class25);
		Class145 class145_19 = smethod_113(new List<Class403> { class24, class27 }, dictionary_, class83_5, 1);
		num += smethod_243(Class185.smethod_0(-1141311105), Class360.smethod_27(class145_19, class83_5, bool_5: false, 0f, 0f, 0f, 100f, 18, bool_6: false, bool_7: false, int_, bool_8: false, null) == class27);
		string text2 = GForm0.smethod_1(Class185.smethod_0(-1141311144));
		num += smethod_243(Class185.smethod_0(-1141311228), text2 != null);
		num += smethod_243(Class185.smethod_0(-1141311264), text2 != null && text2.IndexOf('\n') < 0 && text2.IndexOf('\r') < 0);
		num += smethod_244(Class185.smethod_0(-1141311296), Class185.smethod_0(-1141311327), text2);
		num += smethod_244(Class185.smethod_0(-1141311384), Class185.smethod_0(-1141311403), GForm0.smethod_1(Class185.smethod_0(-1141311450)));
		num += smethod_243(Class185.smethod_0(-1141310503), GForm0.smethod_1(Class185.smethod_0(-1141310533)) == null);
		num += smethod_244(Class185.smethod_0(-1141310590), Class185.smethod_0(-1141339390), GForm0.smethod_1(Class185.smethod_0(-1141339390)));
		num += smethod_244(Class185.smethod_0(-1141310622), Class185.smethod_0(-1141310655), GForm0.smethod_1(Class185.smethod_0(-1141310655)));
		num += smethod_104();
		num += smethod_111();
		num += smethod_105();
		Console.WriteLine(Class185.smethod_0(-1141310679) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	private static int smethod_104()
	{
		int num = 0;
		Class119 @class = new Class119();
		try
		{
			num += smethod_243(Class185.smethod_0(-1141310684), @class.method_20() == null);
			long num2 = @class.method_21();
			@class.method_145(401u, 3, 11u, bool_17: false, Class185.smethod_0(-1141256006));
			Class60 class2 = @class.method_20();
			num += smethod_243(Class185.smethod_0(-1141310715), class2 != null && class2.long_0 == num2 + 1L && class2.uint_0 == 401 && class2.byte_0 == 3 && class2.uint_1 == 11 && !class2.bool_0 && class2.string_0 == Class185.smethod_0(-1141256006));
			@class.method_145(402u, 4, 12u, bool_17: true, null);
			Class60 class3 = @class.method_20();
			num += smethod_243(Class185.smethod_0(-1141310747), class3 != null && class3.long_0 == class2.long_0 + 1L && class3.uint_0 == 402 && class3.byte_0 == 4 && class3.uint_1 == 12 && class3.bool_0 && class3.string_0 == string.Empty);
			long gparam_ = @class.method_21();
			long num3 = @class.method_22();
			smethod_94(@class, Class185.smethod_0(-1141259815), true);
			@class.method_210();
			num += smethod_243(Class185.smethod_0(-1141310780), @class.method_20() == null);
			num += smethod_244(Class185.smethod_0(-1141310830), gparam_, @class.method_21());
			num += smethod_243(Class185.smethod_0(-1141310872), @class.method_22() > num3);
			num += smethod_243(Class185.smethod_0(-1141310906), !@class.method_136());
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
					string text = class5.uint_0 + Class185.smethod_0(-1141297577) + class5.byte_0 + Class185.smethod_0(-1141297577) + class5.bool_0;
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
			num += smethod_243(Class185.smethod_0(-1141310950), bool_);
			num += smethod_244(Class185.smethod_0(-1141316119), 1000L, class4.class119_0.method_21());
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
			MethodInfo methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
			num += smethod_243(Class185.smethod_0(-1141316154), methodInfo != null);
			if (methodInfo != null)
			{
				smethod_94(class7, Class185.smethod_0(-1141259815), true);
				class7.method_145(403u, 3, 13u, bool_17: true, null);
				long num5 = class7.method_22();
				methodInfo.Invoke(class7, new object[2]
				{
					7,
					IntPtr.Zero
				});
				num += smethod_243(Class185.smethod_0(-1141316186), !class7.method_136());
				num += smethod_243(Class185.smethod_0(-1141316231), class7.method_20() == null);
				num += smethod_243(Class185.smethod_0(-1141316266), class7.method_22() > num5);
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
			{
				Class185.smethod_0(-1141334620),
				Class185.smethod_0(-1141339526)
			},
			{
				Class185.smethod_0(-1141316317),
				Class185.smethod_0(-1141276712)
			}
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
				num += smethod_243(Class185.smethod_0(-1141316327), !Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141316365), 0, @class.list_0.Count);
				class3.method_2(bool_0: true);
				for (int i = 1; i <= 5; i++)
				{
					class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, i), bool_0: true);
					bool result = Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
					num += smethod_243(Class185.smethod_0(-1141316394) + i, result);
					num += smethod_244(Class185.smethod_0(-1141316425) + i, i, @class.list_0.Count(Class299.class299_0.method_60));
					num += smethod_244(Class185.smethod_0(-1141316470) + i, 0, @class.list_0.Count(Class299.class299_0.method_61));
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
				num += smethod_243(Class185.smethod_0(-1141316509), @class.list_0.Last().Contains(Class185.smethod_0(-1141254430)) && @class.list_0.Last().Contains(Class185.smethod_0(-1141316552)));
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
				num += smethod_243(Class185.smethod_0(-1141316567), @class.list_0.Count == 2 && @class.list_0[1].Contains(Class185.smethod_0(-1141315590)));
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
				num += smethod_243(Class185.smethod_0(-1141315605), @class.list_0.Count == 2 && @class.list_0[1].Contains(Class185.smethod_0(-1141316552)));
				@class.list_0.Clear();
				Class360.smethod_33();
				for (int k = 1; k <= 5; k++)
				{
					class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 34 + k), bool_0: true);
					Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
					@class.long_0 += 500L;
				}
				class3.method_4(1, 19, bool_0: false, Array.Empty<string>());
				num += smethod_243(Class185.smethod_0(-1141315647), !Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				class3.method_4(1, 18, bool_0: false, Array.Empty<string>());
				class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 40), bool_0: true);
				Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141315676), @class.list_0.Last().Contains(Class185.smethod_0(-1141254430)));
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
				num += smethod_243(Class185.smethod_0(-1141315729), !Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				class3.method_4(1, 18, bool_0: false, Array.Empty<string>());
				class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 66), bool_0: true);
				Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141315770), @class.list_0.Last().Contains(Class185.smethod_0(-1141254430)));
				@class.list_0.Clear();
				Class360.smethod_33();
				for (int m = 1; m <= 5; m++)
				{
					class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 70 + m), bool_0: true);
					Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
					@class.long_0 += 500L;
				}
				class3.method_2(bool_0: false);
				num += smethod_243(Class185.smethod_0(-1141315829), !Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				class3.method_2(bool_0: true);
				class3.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 76), bool_0: true);
				Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141315865), @class.list_0.Last().Contains(Class185.smethod_0(-1141254430)));
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
				num += smethod_243(Class185.smethod_0(-1141315927), @class.list_0.Last().Contains(Class185.smethod_0(-1141254430)));
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
				num += smethod_243(Class185.smethod_0(-1141315971), @class.list_0.Last().Contains(Class185.smethod_0(-1141254430)));
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
					num += smethod_243(Class185.smethod_0(-1141316026) + num3, !Class360.smethod_1(class6.gform0_0, 20f).GetAwaiter().GetResult());
					@class.long_0 += 500L;
				}
				class5.method_30(@class.method_4);
				class6.method_0(smethod_113(new List<Class403> { class2 }, dictionary_, class83_, 86), bool_0: true);
				num += smethod_243(Class185.smethod_0(-1141316070), Class360.smethod_1(class6.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_243(Class185.smethod_0(-1141317136), @class.list_1.Count == 1 && @class.list_1[0].Contains(Class185.smethod_0(-1141254430)));
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
				num += smethod_243(Class185.smethod_0(-1141317172), result);
				num += smethod_243(Class185.smethod_0(-1141317218), !@class.bool_1);
				num += smethod_244(Class185.smethod_0(-1141317269), 2, @class.int_2);
				List<JObject> list = ((IEnumerable<string>)@class.list_0).Select((Func<string, JObject>)JObject.Parse).ToList();
				num += smethod_244(Class185.smethod_0(-1141317310), 8, list.Count);
				num += smethod_243(Class185.smethod_0(-1141317367), (string)list[5][Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141254478) && (float)list[5][Class185.smethod_0(-1141255982)] == 8f && (float)list[5][Class185.smethod_0(-1141255990)] == 3f && (float)list[5][Class185.smethod_0(-1141255998)] == 9f);
				num += smethod_243(Class185.smethod_0(-1141317414), (string)list[6][Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141254478) && (string)list[7][Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141308140));
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
					num += smethod_243(Class185.smethod_0(-1141317450) + j, Class360.smethod_1(@class.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
				}
				list = ((IEnumerable<string>)@class.list_0).Select((Func<string, JObject>)JObject.Parse).ToList();
				List<JObject> list2 = list.Where(Class299.class299_0.method_62).Skip(1).ToList();
				num += smethod_244(Class185.smethod_0(-1141317492), 5, list2.Count);
				num += smethod_244(Class185.smethod_0(-1141317530), 10, list.Count(Class299.class299_0.method_63));
				HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
				bool flag = list2.Count == @class.list_1.Count;
				for (int k = 0; k < list2.Count && k < @class.list_1.Count; k++)
				{
					float num2 = (float)list2[k][Class185.smethod_0(-1141255982)] - @class.list_1[k].Item1;
					float num3 = (float)list2[k][Class185.smethod_0(-1141255998)] - @class.list_1[k].Item2;
					flag = flag && num2 >= -1f && num2 <= 1f && num3 >= -1f && num3 <= 1f;
					hashSet.Add(num2.ToString(Class185.smethod_0(-1141317570), CultureInfo.InvariantCulture) + Class185.smethod_0(-1141297577) + num3.ToString(Class185.smethod_0(-1141317570), CultureInfo.InvariantCulture));
				}
				num += smethod_243(Class185.smethod_0(-1141317578), flag);
				num += smethod_244(Class185.smethod_0(-1141317629), 5, hashSet.Count);
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
				num += smethod_243(Class185.smethod_0(-1141316641), Class360.smethod_1(@class.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_243(Class185.smethod_0(-1141316696), @class.list_0.Last().Contains(Class185.smethod_0(-1141254430)) && @class.list_0.Last().Contains(Class185.smethod_0(-1141316731)));
				long num4 = @class.long_0;
				@class.list_0.Clear();
				@class.long_0 = num4 + 59999L;
				@class.class222_0.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, ++@class.int_3), bool_0: true);
				num += smethod_243(Class185.smethod_0(-1141316746), !Class360.smethod_1(@class.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141316799), 0, @class.list_0.Count);
				@class.long_0 = num4 + 60000L;
				@class.class222_0.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, ++@class.int_3), bool_0: true);
				num += smethod_243(Class185.smethod_0(-1141316835), Class360.smethod_1(@class.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_243(Class185.smethod_0(-1141316887), @class.list_0.Count == 1 && @class.list_0[0].Contains(Class185.smethod_0(-1141254430)) && @class.list_0[0].Contains(Class185.smethod_0(-1141316933)));
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
				num += smethod_243(Class185.smethod_0(-1141316940), Class360.smethod_1(@class.class222_1.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141316999), gparam_, @class.list_2.Count(Class299.class299_0.method_66));
				@class.bool_2 = false;
				@class.class222_1.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				Class360.smethod_1(@class.class222_1.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141317033), @class.list_2.Last().Contains(Class185.smethod_0(-1141254430)));
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
				num += smethod_243(Class185.smethod_0(-1141317092), Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141314071), gparam_2, @class.list_3.Count(Class299.class299_0.method_69));
				long num5 = @class.long_0;
				@class.list_3.Clear();
				@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				num += smethod_243(Class185.smethod_0(-1141314099), !Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141314145), 0, @class.list_3.Count);
				@class.long_0 = num5 + 59999L;
				@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				num += smethod_243(Class185.smethod_0(-1141314187), !Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult());
				@class.long_0 = num5 + 60000L;
				@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141314248), @class.list_3.Last().Contains(Class185.smethod_0(-1141254430)));
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
				num += smethod_243(Class185.smethod_0(-1141314282), Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141314324), gparam_3, @class.list_3.Count(Class299.class299_0.method_71));
				@class.class222_2.gform0_0.bool_3 = false;
				@class.bool_3 = false;
				@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141314369), @class.list_3.Last().Contains(Class185.smethod_0(-1141254430)));
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
				num += smethod_243(Class185.smethod_0(-1141314419), Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141314470), gparam_4, @class.list_3.Count(Class299.class299_0.method_73));
				@class.class119_2.method_30(@class.method_10);
				@class.class222_2.method_0(smethod_113(new List<Class403> { @class.class403_1 }, @class.dictionary_0, @class.class83_1, ++@class.int_3), bool_0: true);
				Class360.smethod_1(@class.class222_2.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141314508), @class.list_3.Last().Contains(Class185.smethod_0(-1141254430)));
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
				num += smethod_243(Class185.smethod_0(-1141313547), Class360.smethod_1(@class.class222_3.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141313607), gparam_5, @class.list_4.Count(Class299.class299_0.method_76));
				Class360.smethod_1(@class.class222_3.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141313642), @class.list_4.Last().Contains(Class185.smethod_0(-1141254430)));
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
				typeof(Class412).GetField(Class185.smethod_0(-1141337468), BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, 77u);
				Class360.smethod_1(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
				Class360.smethod_1(class3.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_244(Class185.smethod_0(-1141313703), 1, class3.class239_0.list_0.Count(Class299.class299_0.method_77));
				num += smethod_243(Class185.smethod_0(-1141313760), class3.class239_0.list_0.Count(Class299.class299_0.method_78) == 1);
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
				num += smethod_243(Class185.smethod_0(-1141313806), class5.class239_0.list_1.Count == 1 && class5.class239_0.list_1[0].Contains(Class185.smethod_0(-1141254441)));
				return num + smethod_244(Class185.smethod_0(-1141313844), 0, class5.class239_0.list_1.Count(Class299.class299_0.method_79));
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
				num += smethod_244(Class185.smethod_0(-1141313891), 10, @class.list_0.Count(Class299.class299_0.method_80));
				num += smethod_244(Class185.smethod_0(-1141313934), 0, @class.list_0.Count(Class299.class299_0.method_81));
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
				num += smethod_244(Class185.smethod_0(-1141313969), 1, @class.list_1.Count);
				uint uint_ = (uint)JObject.Parse(@class.list_1[0])[Class185.smethod_0(-1141255964)];
				class3.method_145(@class.class403_0.uint_0, 3, 0u, bool_17: true, null);
				@class.long_0 = 250L;
				num += smethod_243(Class185.smethod_0(-1141314012), Class360.smethod_1(class4.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141315087), 1, @class.list_1.Count);
				class3.method_145(999u, 3, uint_, bool_17: true, null);
				@class.long_0 = 500L;
				num += smethod_243(Class185.smethod_0(-1141315129), Class360.smethod_1(class4.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141315184), 1, @class.list_1.Count);
				class3.method_145(@class.class403_0.uint_0, 3, uint_, bool_17: true, null);
				num += smethod_243(Class185.smethod_0(-1141315221), Class360.smethod_1(class4.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141315264), 1, @class.list_1.Count);
				@class.long_0 = 1000L;
				class4.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, 201), bool_0: true);
				Class360.smethod_1(class4.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_244(Class185.smethod_0(-1141315312), 2, @class.list_1.Count);
				uint uint_2 = (uint)JObject.Parse(@class.list_1[1])[Class185.smethod_0(-1141255964)];
				class3.method_145(@class.class403_0.uint_0, 3, uint_2, bool_17: true, null);
				@class.long_0 = 1500L;
				class4.method_0(smethod_113(new List<Class403>(), @class.dictionary_0, @class.class83_0, 202), bool_0: true);
				num += smethod_243(Class185.smethod_0(-1141315355), !Class360.smethod_1(class4.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141315404), 2, @class.list_1.Count);
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
				num += smethod_243(Class185.smethod_0(-1141315452), Class360.smethod_1(class6.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141315502), 1, @class.list_2.Count);
				@class.long_0 = 3000L;
				num += smethod_243(Class185.smethod_0(-1141315549), Class360.smethod_1(class6.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141314566), 2, @class.list_2.Count);
				num += smethod_244(Class185.smethod_0(-1141314608), 0, @class.list_2.Count(Class299.class299_0.method_82));
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
				num += smethod_244(Class185.smethod_0(-1141314646), 1, class7.class273_0.list_3.Count);
				num += smethod_243(Class185.smethod_0(-1141314688), Class360.smethod_1(class7.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141314744), 1, class7.class273_0.list_3.Count);
				class7.class273_0.long_0 = 1500L;
				class7.class222_0.method_0(smethod_113(new List<Class403> { class7.class273_0.class403_0 }, class7.class273_0.dictionary_0, class7.class273_0.class83_0, 322), bool_0: true);
				Class360.smethod_1(class7.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
				num += smethod_244(Class185.smethod_0(-1141314807), 2, class7.class273_0.list_3.Count);
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
				uint num2 = (uint)JObject.Parse(@class.list_4[0])[Class185.smethod_0(-1141255964)];
				@class.long_0 = 2000L;
				class9.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, 351), bool_0: true);
				Class360.smethod_1(class9.gform0_0, 20f).GetAwaiter().GetResult();
				uint num3 = (uint)JObject.Parse(@class.list_4[1])[Class185.smethod_0(-1141255964)];
				num += smethod_243(Class185.smethod_0(-1141314864), num3 != 0 && num3 != num2);
				class8.method_145(@class.class403_0.uint_0, 3, num2, bool_17: true, null);
				@class.long_0 = 2500L;
				class9.method_0(smethod_113(new List<Class403> { @class.class403_0 }, @class.dictionary_0, @class.class83_0, 352), bool_0: true);
				num += smethod_243(Class185.smethod_0(-1141314901), Class360.smethod_1(class9.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141314939), 2, @class.list_4.Count);
				class8.method_145(@class.class403_0.uint_0, 3, num3, bool_17: true, null);
				num += smethod_243(Class185.smethod_0(-1141314986), Class360.smethod_1(class9.gform0_0, 20f).GetAwaiter().GetResult());
				return num + smethod_244(Class185.smethod_0(-1141315035), 3, @class.list_4.Count);
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
		Type nestedType = typeof(Class360).GetNestedType(Class185.smethod_0(-1141367609), BindingFlags.NonPublic);
		MethodInfo methodInfo = ((nestedType == null) ? null : nestedType.GetMethod(Class185.smethod_0(-1141320216), BindingFlags.Static | BindingFlags.NonPublic));
		MethodInfo methodInfo2 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		MethodInfo methodInfo3 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		FieldInfo field = typeof(Class360).GetField(Class185.smethod_0(-1141320219), BindingFlags.Static | BindingFlags.NonPublic);
		num += smethod_243(Class185.smethod_0(-1141320236), nestedType != null && methodInfo != null && methodInfo2 != null && methodInfo3 != null && field != null);
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
			num += smethod_244(Class185.smethod_0(-1141320277), 256, dictionary.Count);
			num += smethod_243(Class185.smethod_0(-1141320312), dictionary.Contains(obj));
			methodInfo3.Invoke(null, new object[1] { 60000L });
			num += smethod_244(Class185.smethod_0(-1141320338), 0, dictionary.Count);
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
				Type nestedType = typeof(Class360).GetNestedType(Class185.smethod_0(-1141367609), BindingFlags.NonPublic);
				MethodInfo methodInfo = ((nestedType == null) ? null : nestedType.GetMethod(Class185.smethod_0(-1141320216), BindingFlags.Static | BindingFlags.NonPublic));
				MethodInfo methodInfo2 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
				num += smethod_243(Class185.smethod_0(-1141320382), nestedType != null && methodInfo != null && methodInfo2 != null);
				if (nestedType == null || methodInfo == null || methodInfo2 == null)
				{
					return num;
				}
				object obj = methodInfo.Invoke(null, new object[1] { class403_0 });
				methodInfo2.Invoke(null, new object[3] { obj, @class.long_0, 1000L });
				class3.method_0(smethod_113(new List<Class403> { class403_0 }, dictionary_0, class83_0, 601), bool_0: true);
				num += smethod_243(Class185.smethod_0(-1141320421), !Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141320460), 0, @class.list_0.Count);
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
				num += smethod_243(Class185.smethod_0(-1141320506), !Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				class2.method_30(@class.method_2);
				class3.method_0(smethod_113(new List<Class403> { class403_0 }, dictionary_0, class83_0, 603), bool_0: true);
				num += smethod_243(Class185.smethod_0(-1141320557), !Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141320614), 0, @class.list_0.Count);
				long num2 = class2.method_22();
				class2.method_210();
				smethod_94(class2, Class185.smethod_0(-1141259815), true);
				num += smethod_243(Class185.smethod_0(-1141320658), class2.method_22() > num2);
				@class.long_0 = 500L;
				class3.method_0(smethod_113(new List<Class403> { class403_0 }, dictionary_0, class83_0, 604), bool_0: true);
				num += smethod_243(Class185.smethod_0(-1141319688), Class360.smethod_1(class3.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_243(Class185.smethod_0(-1141319724), @class.list_0.Count == 1 && @class.list_0[0].Contains(Class185.smethod_0(-1141254430)));
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
		Dictionary<string, string> dictionary_ = new Dictionary<string, string>(StringComparer.Ordinal) { 
		{
			Class185.smethod_0(-1141334620),
			Class185.smethod_0(-1141339526)
		} };
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
			num += smethod_243(Class185.smethod_0(-1141319769), result);
			num += smethod_244(Class185.smethod_0(-1141319804), 1, @class.list_0.Count);
			num += smethod_243(Class185.smethod_0(-1141319853), @class.list_0.Count == 1 && @class.list_0[0].Contains(Class185.smethod_0(-1141254441)) && @class.list_0[0].Contains(Class185.smethod_0(-1141335949)));
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
			num += smethod_243(Class185.smethod_0(-1141319895), result2);
			num += smethod_244(Class185.smethod_0(-1141319949), 1, @class.list_0.Count);
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
			num += smethod_243(Class185.smethod_0(-1141319988), !Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_244(Class185.smethod_0(-1141320041), 0, @class.list_0.Count);
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
			num += smethod_243(Class185.smethod_0(-1141320091), Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_244(Class185.smethod_0(-1141320143), 1, @class.list_0.Count);
			@class.list_0.Clear();
			Class412.smethod_7();
			Class360.smethod_33();
			num += smethod_243(Class185.smethod_0(-1141320170), !Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_244(Class185.smethod_0(-1141321234), 0, @class.list_0.Count);
			class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item }, dictionary_, class83_, 1), bool_0: true);
			class4.class253_0.class222_0.method_4(4, 18, bool_0: false, Array.Empty<string>());
			Class360.smethod_33();
			num += smethod_243(Class185.smethod_0(-1141321277), !Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			class4.class253_0.class222_0.method_4(5, 18, bool_0: false, Array.Empty<string>());
			num += smethod_243(Class185.smethod_0(-1141321317), !Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_244(Class185.smethod_0(-1141321357), 0, @class.list_0.Count);
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
			num += smethod_243(Class185.smethod_0(-1141321398), result3);
			num += smethod_243(Class185.smethod_0(-1141321426), result4);
			num += smethod_244(Class185.smethod_0(-1141321467), 1, @class.list_0.Count);
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
			class4.class253_0.class222_0.method_4(1, 20, bool_0: false, new string[1] { Class185.smethod_0(-1141339526) });
			DataGridView dataGridView = class4.class253_0.class222_0.method_3();
			class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item6 }, dictionary_, class83_, 1), bool_0: true);
			dataGridView.Rows[0].Cells[0].Value = new Class290(Class185.smethod_0(-1141339526), class4.method_0);
			Class360.smethod_33();
			bool result5 = Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243(Class185.smethod_0(-1141321511), result5);
			num += smethod_244(Class185.smethod_0(-1141321545), 1, @class.list_0.Count);
			num += smethod_243(Class185.smethod_0(-1141321587), @class.list_0.Count == 1 && @class.list_0[0].Contains(Class185.smethod_0(-1141254441)) && @class.list_0[0].Contains(Class185.smethod_0(-1141321628)));
			@class.list_0.Clear();
			class4.class253_0.class222_0.gform0_0.bool_3 = false;
			class4.class253_0.class222_0.method_4(1, 20, bool_0: false, new string[1] { Class185.smethod_0(-1141339526) });
			class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item5 }, dictionary_, class83_, 1), bool_0: true);
			dataGridView.Rows[0].Cells[0].Value = new Class290(Class185.smethod_0(-1141339526), class4.class253_0.method_0);
			Class360.smethod_33();
			num += smethod_243(Class185.smethod_0(-1141321641), Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
			num += smethod_244(Class185.smethod_0(-1141321693), 1, @class.list_0.Count);
			class4.class253_0.class222_0.gform0_0.bool_3 = false;
			@class.list_0.Clear();
			class4.class253_0.class222_0.method_4(1, 18, bool_0: false, Array.Empty<string>());
			class4.class253_0.class222_0.method_0(smethod_113(new List<Class403> { item5 }, dictionary_, class83_, 1), bool_0: true);
			Class360.smethod_33();
			Task<bool> task = Task.Run((Func<Task<bool>>)class4.class253_0.method_1);
			num += smethod_243(Class185.smethod_0(-1141320707), smethod_96(task));
			if (task.IsCompleted)
			{
				num += smethod_243(Class185.smethod_0(-1141320760), task.GetAwaiter().GetResult());
			}
			num += smethod_244(Class185.smethod_0(-1141320800), 1, @class.list_0.Count);
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
			num += smethod_243(Class185.smethod_0(-1141320835), text.IndexOf(Class185.smethod_0(-1141320883), StringComparison.Ordinal) >= 0);
			num += smethod_243(Class185.smethod_0(-1141320917), text.IndexOf(Class185.smethod_0(-1141320966), StringComparison.Ordinal) >= 0);
			num += smethod_243(Class185.smethod_0(-1141320992), @class.list_0.Count == 2 && @class.list_0[0].Contains(Class185.smethod_0(-1141321032)) && @class.list_0[1].Contains(Class185.smethod_0(-1141321047)));
			FieldInfo field = typeof(Class145).GetField(Class185.smethod_0(-1141321062), BindingFlags.Instance | BindingFlags.NonPublic);
			num += smethod_243(Class185.smethod_0(-1141321083), field != null);
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
				num += smethod_243(Class185.smethod_0(-1141321124), class6.method_0());
				num += smethod_243(Class185.smethod_0(-1141321181), result6);
				num += smethod_244(Class185.smethod_0(-1141318154), 1, @class.list_0.Count);
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
				num += smethod_243(Class185.smethod_0(-1141318209), class8.method_0());
				num += smethod_243(Class185.smethod_0(-1141318258), result7);
				num += smethod_244(Class185.smethod_0(-1141318319), 1, @class.list_0.Count);
				class4.class253_0.class222_0.gform0_0.bool_3 = false;
				@class.list_0.Clear();
				Class145 class9 = smethod_113(new List<Class403> { item10 }, dictionary_, class83_, 300);
				Class202<Class403> class10 = new Class202<Class403>(class9.method_6(), 1, class4.class253_0.method_4);
				field.SetValue(class9, class10);
				class4.class253_0.class222_0.method_0(class9, bool_0: true);
				Class360.smethod_33();
				num += smethod_243(Class185.smethod_0(-1141318374), !Class360.smethod_1(class4.class253_0.class222_0.gform0_0, 20f).GetAwaiter().GetResult());
				num += smethod_243(Class185.smethod_0(-1141318430), class10.method_0());
				num += smethod_244(Class185.smethod_0(-1141318487), 0, @class.list_0.Count);
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
		dataGridView.Columns.Add(Class185.smethod_0(-1141310112), Class185.smethod_0(-1141310115));
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
			num += smethod_244(Class185.smethod_0(-1141318537) + i, i, class2.method_0());
			num += smethod_244(Class185.smethod_0(-1141318566) + i, i == 10, class2.method_8());
			dateTime_ = dateTime_.AddSeconds(1.0);
		}
		class2.method_11();
		for (int j = 1; j <= 5; j++)
		{
			class2.method_12(100 + j * 2, 100f, 200f, dateTime_);
			class2.method_14(101 + j * 2, 100f, 200f, dateTime_.AddMilliseconds(800.0));
			num += smethod_244(Class185.smethod_0(-1141318594) + j, j, class2.method_2());
			num += smethod_244(Class185.smethod_0(-1141318630) + j, j == 5, class2.method_9());
			dateTime_ = dateTime_.AddSeconds(1.0);
		}
		class2.method_15();
		class2.method_10(1L, 100f, 200f, dateTime_);
		class2.method_14(1L, 100f, 200f, dateTime_.AddSeconds(2.0));
		num += smethod_243(Class185.smethod_0(-1141317635), class2.method_4());
		class2.method_14(2L, 101f, 200f, dateTime_.AddSeconds(2.0));
		num += smethod_244(Class185.smethod_0(-1141317696), 0, class2.method_0());
		num += smethod_244(Class185.smethod_0(-1141317730), 0, Class440.smethod_1(bool_0: false, Class185.smethod_0(-1141306701)));
		num += smethod_244(Class185.smethod_0(-1141317753), 60, Class440.smethod_1(bool_0: true, Class185.smethod_0(-1141306701)));
		num += smethod_244(Class185.smethod_0(-1141317781), 0, Class440.smethod_1(bool_0: true, Class185.smethod_0(-1141255982)));
		num += smethod_244(Class185.smethod_0(-1141317800), 0, Class440.smethod_1(bool_0: true, Class185.smethod_0(-1141317823)));
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
		num += smethod_243(Class185.smethod_0(-1141317832), bool_);
		num += smethod_243(Class185.smethod_0(-1141317846), Math.Abs(struct76_2.float_0 - struct76_.float_0) < 0.01f);
		num += smethod_243(Class185.smethod_0(-1141317864), Math.Abs(struct76_2.float_2 - struct76_.float_2) < 0.01f);
		num += smethod_243(Class185.smethod_0(-1141317874), Math.Abs(struct76_2.float_1 - struct76_.float_1) < 0.01f);
		num += smethod_244(Class185.smethod_0(-1141317892), 4, struct76_2.int_0);
		num += smethod_243(Class185.smethod_0(-1141317914), struct76_2.bool_0);
		num += smethod_243(Class185.smethod_0(-1141317944), !Class440.smethod_9(new string[5]
		{
			string.Empty,
			Class185.smethod_0(-1141296467),
			Class185.smethod_0(-1141296459),
			Class185.smethod_0(-1141317953),
			Class185.smethod_0(-1141296459)
		}, out var _));
		num += smethod_243(Class185.smethod_0(-1141317973), Class440.smethod_7(Class185.smethod_0(-1141317989)));
		num += smethod_243(Class185.smethod_0(-1141318000), !Class440.smethod_7(Class185.smethod_0(-1141317953)));
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
		num += smethod_244(Class185.smethod_0(-1141318009), 1, Class440.smethod_17(list_, 9f, 0f));
		num += smethod_244(Class185.smethod_0(-1141318031), -1, Class440.smethod_17(new List<Struct76>(), 0f, 0f));
		num += smethod_244(Class185.smethod_0(-1141318043), 0, Class440.smethod_18(2, 3));
		num += smethod_244(Class185.smethod_0(-1141318059), 2, Class440.smethod_18(1, 3));
		num += smethod_244(Class185.smethod_0(-1141318074), -1, Class440.smethod_18(0, 0));
		num += smethod_243(Class185.smethod_0(-1141318091), Class440.smethod_20(4.9f));
		num += smethod_243(Class185.smethod_0(-1141318108), !Class440.smethod_20(5.1f));
		num += smethod_243(Class185.smethod_0(-1141318134), Class2.smethod_2(Class185.smethod_0(-1141319176), 0, DateTime.Now) == null);
		num += smethod_243(Class185.smethod_0(-1141319179), Class2.smethod_2(Class185.smethod_0(-1141319207), 10, DateTime.MinValue) == null);
		num += smethod_244(Class185.smethod_0(-1141319210), Class185.smethod_0(-1141319225), Class2.smethod_2(Class185.smethod_0(-1141319176), 5, DateTime.Now.AddSeconds(-100.0)));
		num += smethod_243(Class185.smethod_0(-1141319254), Class2.smethod_2(Class185.smethod_0(-1141319270), 30, DateTime.Now.AddSeconds(-2.0)).StartsWith(Class185.smethod_0(-1141319285)));
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
		num += smethod_244(Class185.smethod_0(-1141319302), 0, num3);
		num += smethod_244(Class185.smethod_0(-1141319313), 5, num2);
		num += smethod_243(Class185.smethod_0(-1141319329), Class406.smethod_3(3f, 0f, 4f, 0f, 0f, 0f, 5f));
		num += smethod_243(Class185.smethod_0(-1141319351), !Class406.smethod_3(3f, 0f, 4.01f, 0f, 0f, 0f, 5f));
		num += smethod_243(Class185.smethod_0(-1141319366), !Class406.smethod_3(0f, 6f, 0f, 0f, 0f, 0f, 5f));
		Class119 class3 = new Class119();
		@class.list_0 = new List<string>();
		class3.method_30(@class.method_0);
		class3.method_29(Class299.class299_0.method_83);
		Class222 class4 = new Class222(class3);
		try
		{
			DataGridView dataGridView_ = smethod_68(class4.gform0_0, Class185.smethod_0(-1141278745));
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
			typeof(Class412).GetField(Class185.smethod_0(-1141337468), BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, 701u);
			bool result = Class2.smethod_0(class4.gform0_0, 20f).GetAwaiter().GetResult();
			num += smethod_243(Class185.smethod_0(-1141319371), result && @class.list_0.Count == 4 && @class.list_0[0] == Class15.smethod_2() && @class.list_0[1] == Class346.smethod_0(2f, 0f, 0f, bool_0: false) && @class.list_0[2] == Class346.smethod_0(-2f, 0f, 0f, bool_0: false) && @class.list_0[3] == Class346.smethod_0(10f, 0f, 0f, bool_0: true) && !Class412.smethod_0());
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
		num += smethod_243(Class185.smethod_0(-1141319417), Class447.smethod_1(ireadOnlyList_, class83_, 0f, 0f, 0f, 5f, out var class403_, out var float_) && class403_ == class5);
		num += smethod_243(Class185.smethod_0(-1141319442), Class447.smethod_0(ireadOnlyList_, class83_, 5f, out var class403_2, out var _) && class403_2 == class6);
		num += smethod_243(Class185.smethod_0(-1141319478), !Class447.smethod_1(new List<Class403> { class6 }, class83_, 0f, 0f, 0f, 5f, out class403_, out float_));
		Console.WriteLine(Class185.smethod_0(-1141319498) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_116()
	{
		int num = 0;
		num = 0 + smethod_243(Class185.smethod_0(-1141319516), !Class406.smethod_2(null, 0f, 0f, 0f, 1f));
		Class222 @class = new Class222(new Class119());
		try
		{
			@class.method_0(Class145.class145_0.method_93(new Class83
			{
				float_0 = 0f,
				float_1 = 0f,
				float_2 = 0f
			}, 1, 0), bool_0: true);
			num += smethod_243(Class185.smethod_0(-1141319540), Class406.smethod_2(@class.gform0_0, 3f, 0f, 4f, 5f));
			num += smethod_243(Class185.smethod_0(-1141319583), !Class406.smethod_2(@class.gform0_0, 0f, 5.1f, 0f, 5f));
			num += smethod_243(Class185.smethod_0(-1141319610), !Class406.smethod_2(@class.gform0_0, 0f, 0f, 0f, -1f));
			num += smethod_243(Class185.smethod_0(-1141319652), !Class406.smethod_2(@class.gform0_0, float.NaN, 0f, 0f, 5f));
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		Console.WriteLine(Class185.smethod_0(-1141318665) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_117()
	{
		int num = 0;
		num = 0 + smethod_243(Class185.smethod_0(-1141318681), Class86.smethod_0(bool_0: false, 0, -1));
		num += smethod_243(Class185.smethod_0(-1141318697), !Class86.smethod_0(bool_0: true, 1, 1));
		num += smethod_243(Class185.smethod_0(-1141318720), Class86.smethod_0(bool_0: true, 2, 1));
		num += smethod_243(Class185.smethod_0(-1141318730), Class86.smethod_1(bool_0: false, 0, -1, 0f, 0f, 0f, 0f));
		num += smethod_243(Class185.smethod_0(-1141318747), Class86.smethod_1(bool_0: true, 2, 1, 0f, 0f, 0f, 0f));
		num += smethod_243(Class185.smethod_0(-1141318773), Class86.smethod_1(bool_0: true, 1, 1, 5f, 0f, 0f, 0f));
		num += smethod_243(Class185.smethod_0(-1141318789), !Class86.smethod_1(bool_0: true, 1, 1, 3f, 0f, 0f, 0f));
		num += smethod_243(Class185.smethod_0(-1141318806), Class86.smethod_1(bool_0: true, 1, 1, 3f, 3f, 0f, 0f));
		Class2.smethod_8();
		num += smethod_244(Class185.smethod_0(-1141318822), -1, Class2.smethod_6());
		Console.WriteLine(Class185.smethod_0(-1141318833) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_118()
	{
		int num = 0;
		Class181 @class = new Class181();
		@class.method_3(51);
		num = 0 + smethod_243(Class185.smethod_0(-1141318850), @class.method_5(100f, 100f));
		num += smethod_243(Class185.smethod_0(-1141318879), !@class.method_5(139f, 100f));
		num += smethod_243(Class185.smethod_0(-1141318891), @class.method_5(140f, 100f));
		num += smethod_243(Class185.smethod_0(-1141318918), !@class.method_5(140f, 139f));
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
		num += smethod_243(Class185.smethod_0(-1141318941), list != null);
		if (list != null)
		{
			num += smethod_244(Class185.smethod_0(-1141318965), 2, list.Count);
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
			num += smethod_243(Class185.smethod_0(-1141318982), class4 != null);
			num += smethod_243(Class185.smethod_0(-1141318993), class5 != null);
			num += smethod_243(Class185.smethod_0(-1141319012), smethod_141(class4, class3));
		}
		num += smethod_243(Class185.smethod_0(-1141319033), Class189.smethod_1(string.Empty) == null);
		num += smethod_243(Class185.smethod_0(-1141319050), Class189.smethod_1(Class185.smethod_0(-1141319077)) == null);
		List<Class455> list2 = Class189.smethod_1(Class185.smethod_0(-1141319091));
		num += smethod_243(Class185.smethod_0(-1141324314), list2 != null && list2.Count == 1);
		if (list2 != null && list2.Count == 1)
		{
			num += smethod_243(Class185.smethod_0(-1141324338), list2[0].float_2.Length == 1 && Math.Abs(list2[0].float_2[0]) < 0.0001f);
		}
		num += smethod_244(Class185.smethod_0(-1141324363), Class185.smethod_0(-1141324380), Class4.smethod_0(0));
		num += smethod_244(Class185.smethod_0(-1141324398), Class185.smethod_0(-1141324416), Class4.smethod_1(0));
		Class4 class6 = new Class4();
		Struct78 @struct = class6.method_2(bool_0: true, 30, 1);
		num += smethod_243(Class185.smethod_0(-1141324418), smethod_142(@struct.int_0, 0, 24));
		num += smethod_243(Class185.smethod_0(-1141324446), smethod_142(@struct.int_2, 0, 23));
		num += smethod_244(Class185.smethod_0(-1141324470), 0, @struct.int_1.Length);
		num += smethod_244(Class185.smethod_0(-1141324482), 0, @struct.int_3.Length);
		Struct78 struct2 = class6.method_2(bool_0: true, 30, 2);
		num += smethod_243(Class185.smethod_0(-1141324506), smethod_143(struct2.int_0, 24));
		num += smethod_243(Class185.smethod_0(-1141324536), smethod_143(struct2.int_1, 0));
		Struct78 struct3 = class6.method_2(bool_0: false, 30, 2);
		num += smethod_244(Class185.smethod_0(-1141324557), 0, struct3.int_0.Length);
		num += smethod_243(Class185.smethod_0(-1141324575), smethod_142(struct3.int_1, 1, 24));
		Struct78 struct4 = new Class4().method_2(bool_0: true, 1, 1);
		num += smethod_243(Class185.smethod_0(-1141324588), smethod_142(struct4.int_0, 0, 1));
		num += smethod_244(Class185.smethod_0(-1141324609), 0, struct4.int_2.Length);
		List<int> ireadOnlyList_ = new List<int> { 51, 53, 66 };
		num += smethod_244(Class185.smethod_0(-1141324634), 53, Class188.smethod_6(ireadOnlyList_, 51));
		num += smethod_244(Class185.smethod_0(-1141324652), 66, Class188.smethod_6(ireadOnlyList_, 53));
		num += smethod_244(Class185.smethod_0(-1141324678), 51, Class188.smethod_6(ireadOnlyList_, 66));
		num += smethod_244(Class185.smethod_0(-1141324696), 51, Class188.smethod_6(ireadOnlyList_, 52));
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
		num += smethod_244(Class185.smethod_0(-1141324718), 0, num3);
		num += smethod_244(Class185.smethod_0(-1141324735), 3, num2);
		num += smethod_244(Class185.smethod_0(-1141324752), 5f, Class440.smethod_21(0, 5));
		num += smethod_244(Class185.smethod_0(-1141324762), 35f, Class440.smethod_21(2, 5));
		num += smethod_244(Class185.smethod_0(-1141324778), 5f, Class440.smethod_21(4, 5));
		num += smethod_244(Class185.smethod_0(-1141324795), 5f, Class440.smethod_21(0, 1));
		Console.WriteLine(Class185.smethod_0(-1141323798) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_119()
	{
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141323813) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
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
			@class.method_7(dataGridView, Class185.smethod_0(-1141323838));
			@class.method_8(Class185.smethod_0(-1141323858));
			using (@class.method_17(dataGridView))
			{
				for (int i = 0; i < array.Length; i++)
				{
					dataGridView.Rows.Add(Class440.smethod_2(array[i].float_0), Class440.smethod_2(array[i].float_1), Class440.smethod_2(array[i].float_2));
				}
			}
			num += smethod_243(Class185.smethod_0(-1141323894), @class.method_3() > 0);
			Class67 class2 = new Class67(text);
			DataGridView dataGridView2 = smethod_140();
			class2.method_7(dataGridView2, Class185.smethod_0(-1141323838));
			int gparam_ = class2.method_8(Class185.smethod_0(-1141323858));
			num += smethod_244(Class185.smethod_0(-1141323919), 1, gparam_);
			num += smethod_244(Class185.smethod_0(-1141323950), 3, dataGridView2.Columns.Count);
			List<Struct76> list = Class440.smethod_16(dataGridView2);
			num += smethod_244(Class185.smethod_0(-1141323974), array.Length, list.Count);
			if (list.Count == array.Length)
			{
				for (int j = 0; j < array.Length; j++)
				{
					num += smethod_243(Class185.smethod_0(-1141323999) + j, Math.Abs(list[j].float_0 - array[j].float_0) < 0.01f);
					num += smethod_243(Class185.smethod_0(-1141324012) + j, Math.Abs(list[j].float_1 - array[j].float_1) < 0.01f);
					num += smethod_243(Class185.smethod_0(-1141324033) + j, Math.Abs(list[j].float_2 - array[j].float_2) < 0.01f);
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
		Console.WriteLine(Class185.smethod_0(-1141324062) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_120()
	{
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141324075) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
		try
		{
			DataGridView dataGridView_;
			DataGridView dataGridView_2;
			Class67 @class = smethod_121(text, Class185.smethod_0(-1141324103), out dataGridView_, out dataGridView_2);
			using (@class.method_17(dataGridView_))
			{
				dataGridView_.Rows.Add(Class185.smethod_0(-1141324125));
				dataGridView_.Rows.Add(Class185.smethod_0(-1141324133));
				dataGridView_.Rows.Add(Class185.smethod_0(-1141297596));
			}
			smethod_123(dataGridView_, 0);
			num += smethod_244(Class185.smethod_0(-1141324141), 1, dataGridView_.SelectedRows.Count);
			Class388.smethod_0(dataGridView_, dataGridView_2, @class);
			num += smethod_244(Class185.smethod_0(-1141324167), Class185.smethod_0(-1141324185), smethod_124(dataGridView_));
			num += smethod_244(Class185.smethod_0(-1141324195), Class185.smethod_0(-1141324125), smethod_124(dataGridView_2));
			DataGridView dataGridView_3;
			DataGridView dataGridView_4;
			Class67 class2 = smethod_121(text, Class185.smethod_0(-1141324229), out dataGridView_3, out dataGridView_4);
			using (class2.method_17(dataGridView_4))
			{
				dataGridView_4.Rows.Add(Class185.smethod_0(-1141324125));
			}
			using (class2.method_17(dataGridView_3))
			{
				dataGridView_3.Rows.Add(Class185.smethod_0(-1141324125));
			}
			smethod_123(dataGridView_3, 0);
			num += smethod_244(Class185.smethod_0(-1141324253), 1, dataGridView_3.SelectedRows.Count);
			Class388.smethod_0(dataGridView_3, dataGridView_4, class2);
			num += smethod_244(Class185.smethod_0(-1141324266), string.Empty, smethod_124(dataGridView_3));
			num += smethod_244(Class185.smethod_0(-1141325319), Class185.smethod_0(-1141324125), smethod_124(dataGridView_4));
			DataGridView dataGridView_5;
			DataGridView dataGridView_6;
			Class67 class3 = smethod_121(text, Class185.smethod_0(-1141325332), out dataGridView_5, out dataGridView_6);
			using (class3.method_17(dataGridView_6))
			{
				dataGridView_6.Rows.Add(Class185.smethod_0(-1141324125));
			}
			smethod_123(dataGridView_6, 0);
			num += smethod_244(Class185.smethod_0(-1141325354), 1, dataGridView_6.SelectedRows.Count);
			Class388.smethod_0(dataGridView_6, dataGridView_5, class3);
			num += smethod_244(Class185.smethod_0(-1141325380), string.Empty, smethod_124(dataGridView_6));
			num += smethod_244(Class185.smethod_0(-1141325414), Class185.smethod_0(-1141324125), smethod_124(dataGridView_5));
			DataGridView dataGridView_7;
			DataGridView dataGridView_8;
			Class67 class4 = smethod_121(text, Class185.smethod_0(-1141325440), out dataGridView_7, out dataGridView_8);
			using (class4.method_17(dataGridView_7))
			{
				dataGridView_7.Rows.Add(Class185.smethod_0(-1141324125));
				dataGridView_7.Rows.Add(Class185.smethod_0(-1141324133));
			}
			smethod_123(dataGridView_7, 0);
			num += smethod_244(Class185.smethod_0(-1141325470), 1, dataGridView_7.SelectedRows.Count);
			Class388.smethod_2(dataGridView_7, class4);
			num += smethod_244(Class185.smethod_0(-1141325476), Class185.smethod_0(-1141324133), smethod_124(dataGridView_7));
			class4.method_10(dataGridView_7);
			num += smethod_244(Class185.smethod_0(-1141325510), Class185.smethod_0(-1141325534), smethod_124(dataGridView_7));
			DataGridView dataGridView_9;
			DataGridView dataGridView_10;
			Class67 class5 = smethod_121(text, Class185.smethod_0(-1141325544), out dataGridView_9, out dataGridView_10);
			using (class5.method_17(dataGridView_9))
			{
				dataGridView_9.Rows.Add(Class185.smethod_0(-1141324125));
				dataGridView_9.Rows.Add(Class185.smethod_0(-1141324133));
			}
			using (class5.method_17(dataGridView_9))
			{
				dataGridView_9.Rows.Clear();
			}
			dataGridView_10.Rows.Add(Class185.smethod_0(-1141324125));
			class5.method_10(dataGridView_9);
			num += smethod_244(Class185.smethod_0(-1141325563), Class185.smethod_0(-1141325534), smethod_124(dataGridView_9));
			Class388.smethod_1(dataGridView_9, dataGridView_10, class5);
			num += smethod_244(Class185.smethod_0(-1141325590), Class185.smethod_0(-1141324133), smethod_124(dataGridView_9));
			num += smethod_244(Class185.smethod_0(-1141325616), Class185.smethod_0(-1141324125), smethod_124(dataGridView_10));
			DataGridView dataGridView_11;
			DataGridView dataGridView_12;
			Class67 class6 = smethod_121(text, Class185.smethod_0(-1141325635), out dataGridView_11, out dataGridView_12);
			using (class6.method_17(dataGridView_12))
			{
				dataGridView_12.Rows.Add(Class185.smethod_0(-1141313005));
			}
			using (class6.method_17(dataGridView_11))
			{
				dataGridView_11.Rows.Add(Class185.smethod_0(-1141325669));
				dataGridView_11.Rows.Add(Class185.smethod_0(-1141325673));
			}
			Class388.smethod_1(dataGridView_11, dataGridView_12, class6);
			num += smethod_244(Class185.smethod_0(-1141325694), Class185.smethod_0(-1141325673), smethod_124(dataGridView_11));
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
		Console.WriteLine(Class185.smethod_0(-1141325716) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	private static Class67 smethod_121(string string_0, string string_1, out DataGridView dataGridView_0, out DataGridView dataGridView_1)
	{
		Class67 @class = new Class67(Path.Combine(string_0, string_1));
		dataGridView_0 = smethod_122();
		dataGridView_1 = smethod_122();
		@class.method_6(dataGridView_0, Class185.smethod_0(-1141325732), bool_0: false);
		@class.method_7(dataGridView_1, Class185.smethod_0(-1141325763));
		@class.method_8(Class185.smethod_0(-1141325797));
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
				Name = Class185.smethod_0(-1141325803),
				HeaderText = Class185.smethod_0(-1141325818)
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
		return string.Join(Class185.smethod_0(-1141326297), list.ToArray());
	}

	public static int smethod_125()
	{
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141324813) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
		try
		{
			string text2 = Path.Combine(text, Class185.smethod_0(-1141324825));
			smethod_137(text2, Class185.smethod_0(-1141325732), Class185.smethod_0(-1141281254), new string[3]
			{
				Class185.smethod_0(-1141312985),
				Class185.smethod_0(-1141324855),
				Class185.smethod_0(-1141324859)
			});
			Class67 @class = new Class67(text2);
			DataGridView dataGridView = smethod_138(Class185.smethod_0(-1141291575));
			num += smethod_244(Class185.smethod_0(-1141324880), 0, @class.method_10(dataGridView));
			num += smethod_244(Class185.smethod_0(-1141324926), string.Empty, smethod_124(dataGridView));
			num += smethod_243(Class185.smethod_0(-1141324955), @class.method_19(dataGridView, Class185.smethod_0(-1141325732)));
			num += smethod_244(Class185.smethod_0(-1141324998), Class185.smethod_0(-1141325037), smethod_124(dataGridView));
			dataGridView.Rows.Clear();
			num += smethod_244(Class185.smethod_0(-1141325046), 3, @class.method_11(dataGridView, Class185.smethod_0(-1141325732)));
			num += smethod_244(Class185.smethod_0(-1141325074), Class185.smethod_0(-1141325117), smethod_124(dataGridView));
			num += smethod_244(Class185.smethod_0(-1141325142), Class185.smethod_0(-1141325117), smethod_139(dataGridView));
			string text3 = Path.Combine(text, Class185.smethod_0(-1141325170));
			smethod_137(text3, Class185.smethod_0(-1141325732), Class185.smethod_0(-1141281254), new string[2]
			{
				Class185.smethod_0(-1141312985),
				Class185.smethod_0(-1141324855)
			});
			Class67 class2 = new Class67(text3);
			DataGridView dataGridView2 = smethod_138(Class185.smethod_0(-1141291575));
			dataGridView2.Rows.Add(Class185.smethod_0(-1141325188));
			num += smethod_244(Class185.smethod_0(-1141325201), 2, class2.method_11(dataGridView2, Class185.smethod_0(-1141325732)));
			num += smethod_244(Class185.smethod_0(-1141325233), Class185.smethod_0(-1141325278), smethod_124(dataGridView2));
			num += smethod_244(Class185.smethod_0(-1141325303), 0, class2.method_11(dataGridView2, Class185.smethod_0(-1141325732)));
			num += smethod_244(Class185.smethod_0(-1141322264), Class185.smethod_0(-1141325278), smethod_124(dataGridView2));
			dataGridView2.Rows.Clear();
			dataGridView2.Rows.Add(Class185.smethod_0(-1141313005));
			num += smethod_244(Class185.smethod_0(-1141322302), 1, class2.method_11(dataGridView2, Class185.smethod_0(-1141325732)));
			num += smethod_244(Class185.smethod_0(-1141322331), Class185.smethod_0(-1141322381), smethod_124(dataGridView2));
			string text4 = Path.Combine(text, Class185.smethod_0(-1141322399));
			smethod_137(text4, Class185.smethod_0(-1141325732), Class185.smethod_0(-1141281254), new string[2]
			{
				Class185.smethod_0(-1141312985),
				Class185.smethod_0(-1141324855)
			});
			Class67 class3 = new Class67(text4);
			DataGridView dataGridView3 = smethod_138(Class185.smethod_0(-1141291575));
			dataGridView3.AllowUserToAddRows = true;
			num += smethod_244(Class185.smethod_0(-1141322409), 2, class3.method_11(dataGridView3, Class185.smethod_0(-1141325732)));
			num += smethod_244(Class185.smethod_0(-1141322436), Class185.smethod_0(-1141322470), smethod_124(dataGridView3));
			num += smethod_244(Class185.smethod_0(-1141322488), 3, dataGridView3.Rows.Count);
			DataGridView dataGridView4 = smethod_138(Class185.smethod_0(-1141286338));
			dataGridView3.SelectAll();
			num += smethod_244(Class185.smethod_0(-1141322526), 2, Class388.smethod_0(dataGridView3, dataGridView4, class3));
			num += smethod_244(Class185.smethod_0(-1141322557), Class185.smethod_0(-1141322470), smethod_124(dataGridView4));
			Class67 class4 = new Class67(Path.Combine(text, Class185.smethod_0(-1141322592)));
			DataGridView dataGridView5 = smethod_138(Class185.smethod_0(-1141291575));
			dataGridView5.Rows.Add(Class185.smethod_0(-1141325188));
			num += smethod_244(Class185.smethod_0(-1141322603), 0, class4.method_11(dataGridView5, Class185.smethod_0(-1141325732)));
			num += smethod_244(Class185.smethod_0(-1141322638), Class185.smethod_0(-1141325188), smethod_124(dataGridView5));
			string text5 = Path.Combine(text, Class185.smethod_0(-1141322670));
			smethod_137(text5, Class185.smethod_0(-1141325732), Class185.smethod_0(-1141281254), new string[2]
			{
				Class185.smethod_0(-1141312985),
				Class185.smethod_0(-1141324855)
			});
			Class67 class5 = new Class67(text5);
			DataGridView dataGridView_ = smethod_138(Class185.smethod_0(-1141291575));
			DataGridView dataGridView6 = smethod_138(Class185.smethod_0(-1141286338));
			class5.method_7(dataGridView6, Class185.smethod_0(-1141322682));
			class5.method_8(Class185.smethod_0(-1141322708));
			using (class5.method_17(dataGridView6))
			{
				dataGridView6.Rows.Add(Class185.smethod_0(-1141322731));
			}
			class5.method_11(dataGridView_, Class185.smethod_0(-1141325732));
			num += smethod_244(Class185.smethod_0(-1141322751), Class185.smethod_0(-1141322470), smethod_124(dataGridView_));
			num += smethod_244(Class185.smethod_0(-1141321753), 1, Class388.smethod_1(dataGridView_, dataGridView6, class5));
			num += smethod_244(Class185.smethod_0(-1141321789), Class185.smethod_0(-1141312985), smethod_124(dataGridView_));
			num += smethod_244(Class185.smethod_0(-1141321822), Class185.smethod_0(-1141322731), smethod_124(dataGridView6));
			Class67 class6 = new Class67(Path.Combine(text, Class185.smethod_0(-1141321861)));
			DataGridView dataGridView7 = smethod_138(Class185.smethod_0(-1141291575));
			DataGridView dataGridView8 = smethod_138(Class185.smethod_0(-1141286338));
			class6.method_7(dataGridView8, Class185.smethod_0(-1141322682));
			class6.method_8(Class185.smethod_0(-1141322708));
			using (class6.method_17(dataGridView7))
			{
				dataGridView7.Rows.Add(Class185.smethod_0(-1141312985));
				dataGridView7.Rows.Add(Class185.smethod_0(-1141324855));
				dataGridView7.Rows.Add(Class185.smethod_0(-1141324859));
			}
			dataGridView7.ClearSelection();
			num += smethod_244(Class185.smethod_0(-1141321865), 0, Class388.smethod_0(dataGridView7, dataGridView8, class6));
			num += smethod_244(Class185.smethod_0(-1141321909), Class185.smethod_0(-1141325117), smethod_124(dataGridView7));
			num += smethod_244(Class185.smethod_0(-1141321949), string.Empty, smethod_124(dataGridView8));
			dataGridView7.ClearSelection();
			dataGridView7.Rows[2].Selected = true;
			dataGridView7.Rows[0].Selected = true;
			int num2 = class6.method_3();
			num += smethod_244(Class185.smethod_0(-1141321989), 2, Class388.smethod_0(dataGridView7, dataGridView8, class6));
			num += smethod_244(Class185.smethod_0(-1141322014), Class185.smethod_0(-1141322045), smethod_139(dataGridView8));
			num += smethod_244(Class185.smethod_0(-1141322064), Class185.smethod_0(-1141324855), smethod_124(dataGridView7));
			num += smethod_244(Class185.smethod_0(-1141322094), num2 + 1, class6.method_3());
			dataGridView8.ClearSelection();
			dataGridView8.Rows[0].Selected = true;
			num2 = class6.method_3();
			num += smethod_244(Class185.smethod_0(-1141322116), 1, Class388.smethod_0(dataGridView8, dataGridView7, class6));
			num += smethod_244(Class185.smethod_0(-1141322140), Class185.smethod_0(-1141324859), smethod_124(dataGridView8));
			num += smethod_244(Class185.smethod_0(-1141322176), Class185.smethod_0(-1141322470), smethod_124(dataGridView7));
			num += smethod_244(Class185.smethod_0(-1141322196), num2 + 1, class6.method_3());
			Class67 class7 = new Class67(Path.Combine(text, Class185.smethod_0(-1141322239)));
			DataGridView dataGridView9 = smethod_138(Class185.smethod_0(-1141291575));
			DataGridView dataGridView10 = smethod_138(Class185.smethod_0(-1141286338));
			class7.method_7(dataGridView10, Class185.smethod_0(-1141322682));
			class7.method_8(Class185.smethod_0(-1141322708));
			using (class7.method_17(dataGridView10))
			{
				dataGridView10.Rows.Add(Class185.smethod_0(-1141324855));
			}
			using (class7.method_17(dataGridView9))
			{
				dataGridView9.Rows.Add(Class185.smethod_0(-1141322731));
			}
			smethod_123(dataGridView9, 0);
			num += smethod_244(Class185.smethod_0(-1141323279), 1, Class388.smethod_0(dataGridView9, dataGridView10, class7));
			num += smethod_244(Class185.smethod_0(-1141323307), Class185.smethod_0(-1141324855), smethod_124(dataGridView10));
			num += smethod_244(Class185.smethod_0(-1141323352), string.Empty, smethod_124(dataGridView9));
			using (class7.method_17(dataGridView9))
			{
				dataGridView9.Rows.Add(Class185.smethod_0(-1141324859));
				dataGridView9.Rows.Add(Class185.smethod_0(-1141323391));
			}
			dataGridView9.ClearSelection();
			dataGridView9.Rows[0].Selected = true;
			dataGridView9.Rows[1].Selected = true;
			num += smethod_244(Class185.smethod_0(-1141323396), 2, Class388.smethod_0(dataGridView9, dataGridView10, class7));
			num += smethod_244(Class185.smethod_0(-1141323436), Class185.smethod_0(-1141323478), smethod_124(dataGridView10));
			num += smethod_244(Class185.smethod_0(-1141323489), string.Empty, smethod_124(dataGridView9));
			string string_ = Path.Combine(text, Class185.smethod_0(-1141323535));
			Class67 class8 = new Class67(string_);
			DataGridView dataGridView11 = smethod_138(Class185.smethod_0(-1141291575));
			DataGridView dataGridView12 = smethod_138(Class185.smethod_0(-1141286338));
			class8.method_7(dataGridView12, Class185.smethod_0(-1141322682));
			class8.method_8(Class185.smethod_0(-1141322708));
			using (class8.method_17(dataGridView11))
			{
				dataGridView11.Rows.Add(Class185.smethod_0(-1141312985));
				dataGridView11.Rows.Add(Class185.smethod_0(-1141324855));
			}
			dataGridView11.ClearSelection();
			dataGridView11.Rows[0].Selected = true;
			Class388.smethod_0(dataGridView11, dataGridView12, class8);
			Class67 class9 = new Class67(string_);
			DataGridView dataGridView_2 = smethod_138(Class185.smethod_0(-1141286338));
			class9.method_7(dataGridView_2, Class185.smethod_0(-1141322682));
			class9.method_8(Class185.smethod_0(-1141322708));
			num += smethod_244(Class185.smethod_0(-1141323552), Class185.smethod_0(-1141312985), smethod_124(dataGridView_2));
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
		Console.WriteLine(Class185.smethod_0(-1141323569) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_126()
	{
		int num = 0;
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		dictionary[Class185.smethod_0(-1141356755)] = Class185.smethod_0(-1141323585);
		dictionary[Class185.smethod_0(-1141323615)] = Class185.smethod_0(-1141323618);
		dictionary[Class185.smethod_0(-1141323642)] = Class185.smethod_0(-1141341332);
		Class95 @class = new Class95(null, dictionary, null);
		num = 0 + smethod_244(Class185.smethod_0(-1141323661), Class185.smethod_0(-1141323585), Class16.smethod_6(@class, 11, 1));
		num += smethod_244(Class185.smethod_0(-1141323685), Class185.smethod_0(-1141323707), Class16.smethod_6(@class, 61, 1));
		num += smethod_243(Class185.smethod_0(-1141323729), Class16.smethod_6(@class, 9, 9) == null);
		num += smethod_243(Class185.smethod_0(-1141323768), Class16.smethod_6(@class, 12, 1) == null);
		num += smethod_243(Class185.smethod_0(-1141322774), Class16.smethod_6(null, 11, 1) == null);
		num += smethod_244(Class185.smethod_0(-1141322806), Class185.smethod_0(-1141322836), Class16.smethod_5(@class, 9, 9));
		List<string> list = Class16.smethod_8(Class145.class145_0.method_97(smethod_233(), null, @class, 7, 24));
		num += smethod_244(Class185.smethod_0(-1141322851), Class185.smethod_0(-1141322881), smethod_240(list));
		num += smethod_243(Class185.smethod_0(-1141322927), !list.Contains(Class185.smethod_0(-1141322836)));
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>(StringComparer.Ordinal);
		dictionary2[Class185.smethod_0(-1141356755)] = Class185.smethod_0(-1141323585);
		dictionary2[Class185.smethod_0(-1141322966)] = Class185.smethod_0(-1141322969);
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
		num += smethod_244(Class185.smethod_0(-1141322999), Class185.smethod_0(-1141323585), smethod_240(Class16.smethod_8(class145_)));
		num += smethod_244(Class185.smethod_0(-1141323030), 0, Class16.smethod_8(Class145.class145_0.method_99(Class185.smethod_0(-1141323060))).Count);
		num += smethod_244(Class185.smethod_0(-1141323089), 0, Class16.smethod_8(null).Count);
		num += smethod_244(Class185.smethod_0(-1141323114), 0, Class16.smethod_8(Class145.class145_0).Count);
		Console.WriteLine(Class185.smethod_0(-1141323137) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_127()
	{
		int num = 0;
		DataGridView dataGridView = smethod_138(Class185.smethod_0(-1141291575));
		DataGridView dataGridView2 = smethod_138(Class185.smethod_0(-1141286338));
		dataGridView.Rows.Add(Class185.smethod_0(-1141309974));
		dataGridView.Rows.Add(Class185.smethod_0(-1141324855));
		dataGridView.Rows.Add(Class185.smethod_0(-1141323160));
		dataGridView2.Rows.Add(Class185.smethod_0(-1141323176));
		num = 0 + smethod_244(Class185.smethod_0(-1141323192), Class185.smethod_0(-1141323209), smethod_136(Class44.smethod_0(Class185.smethod_0(-1141323253), dataGridView, dataGridView2)));
		num += smethod_243(Class185.smethod_0(-1141323263), !Class96.smethod_0(Class185.smethod_0(-1141309974), Class185.smethod_0(-1141312985)));
		num += smethod_244(Class185.smethod_0(-1141164581), Class185.smethod_0(-1141323209), smethod_136(Class44.smethod_0(Class185.smethod_0(-1141164613), dataGridView, dataGridView2)));
		num += smethod_244(Class185.smethod_0(-1141164623), Class185.smethod_0(-1141323209), smethod_136(Class44.smethod_0(Class185.smethod_0(-1141164653), dataGridView, dataGridView2)));
		num += smethod_244(Class185.smethod_0(-1141164669), Class185.smethod_0(-1141324855), smethod_136(Class44.smethod_0(Class185.smethod_0(-1141324855), dataGridView, dataGridView2)));
		num += smethod_244(Class185.smethod_0(-1141164695), Class185.smethod_0(-1141323176), smethod_136(Class44.smethod_0(Class185.smethod_0(-1141164727), dataGridView, dataGridView2)));
		num += smethod_244(Class185.smethod_0(-1141164730), 0, Class44.smethod_0(Class185.smethod_0(-1141164754), dataGridView, dataGridView2).Count);
		num += smethod_244(Class185.smethod_0(-1141164764), 0, Class44.smethod_0(Class185.smethod_0(-1141341332), dataGridView, dataGridView2).Count);
		num += smethod_244(Class185.smethod_0(-1141164800), 0, Class44.smethod_0(string.Empty, dataGridView, dataGridView2).Count);
		num += smethod_244(Class185.smethod_0(-1141164820), 0, Class44.smethod_0(null, dataGridView, dataGridView2).Count);
		num += smethod_244(Class185.smethod_0(-1141164855), 0, Class44.smethod_0(Class185.smethod_0(-1141323253), null, null).Count);
		num += smethod_244(Class185.smethod_0(-1141164886), Class185.smethod_0(-1141164907), smethod_136(Class44.smethod_0(Class185.smethod_0(-1141323253), dataGridView, null)));
		num += smethod_244(Class185.smethod_0(-1141164941), 0, Class44.smethod_0(Class185.smethod_0(-1141323253), new DataGridView(), null).Count);
		string gparam_ = smethod_139(dataGridView);
		string gparam_2 = smethod_139(dataGridView2);
		int count = dataGridView.Rows.Count;
		int count2 = dataGridView2.Rows.Count;
		Class44.smethod_0(Class185.smethod_0(-1141323253), dataGridView, dataGridView2);
		Class44.smethod_0(string.Empty, dataGridView, dataGridView2);
		Class44.smethod_0(Class185.smethod_0(-1141164754), dataGridView, dataGridView2);
		num += smethod_244(Class185.smethod_0(-1141164967), count, dataGridView.Rows.Count);
		num += smethod_244(Class185.smethod_0(-1141164994), count2, dataGridView2.Rows.Count);
		num += smethod_244(Class185.smethod_0(-1141165037), gparam_, smethod_139(dataGridView));
		num += smethod_244(Class185.smethod_0(-1141164041), gparam_2, smethod_139(dataGridView2));
		DataGridView dataGridView3 = smethod_138(Class185.smethod_0(-1141291575));
		dataGridView3.AllowUserToAddRows = true;
		dataGridView3.Rows.Add(Class185.smethod_0(-1141312985));
		dataGridView3.Rows.Add();
		num += smethod_244(Class185.smethod_0(-1141164085), Class185.smethod_0(-1141312985), smethod_136(Class44.smethod_0(Class185.smethod_0(-1141164113), dataGridView3, null)));
		num += smethod_244(Class185.smethod_0(-1141164121), Class185.smethod_0(-1141164158), Class44.smethod_1(1, 3));
		num += smethod_244(Class185.smethod_0(-1141164162), Class185.smethod_0(-1141164198), Class44.smethod_1(3, 3));
		num += smethod_244(Class185.smethod_0(-1141164202), Class185.smethod_0(-1141262328), Class44.smethod_1(0, 0));
		num += smethod_244(Class185.smethod_0(-1141164234), Class185.smethod_0(-1141262328), Class44.smethod_1(1, 0));
		num += smethod_244(Class185.smethod_0(-1141164268), 0, Class44.smethod_2(-1, 3));
		num += smethod_244(Class185.smethod_0(-1141164302), 1, Class44.smethod_2(0, 3));
		num += smethod_244(Class185.smethod_0(-1141164321), 2, Class44.smethod_2(1, 3));
		num += smethod_244(Class185.smethod_0(-1141164347), 0, Class44.smethod_2(2, 3));
		num += smethod_244(Class185.smethod_0(-1141164381), 0, Class44.smethod_2(9, 3));
		num += smethod_244(Class185.smethod_0(-1141164403), -1, Class44.smethod_2(-1, 0));
		num += smethod_244(Class185.smethod_0(-1141164447), -1, Class44.smethod_2(0, 0));
		DataGridView dataGridView4 = smethod_138(Class185.smethod_0(-1141291575));
		DataGridView dataGridView5 = smethod_138(Class185.smethod_0(-1141286338));
		dataGridView4.Rows.Add(Class185.smethod_0(-1141309974));
		dataGridView4.Rows.Add(Class185.smethod_0(-1141323160));
		dataGridView5.Rows.Add(Class185.smethod_0(-1141323176));
		List<DataGridViewRow> list = Class44.smethod_0(Class185.smethod_0(-1141323253), dataGridView4, dataGridView5);
		int num2 = -1;
		num2 = Class44.smethod_2(-1, list.Count);
		num += smethod_244(Class185.smethod_0(-1141164481), Class185.smethod_0(-1141164158), Class44.smethod_1(num2 + 1, list.Count));
		num += smethod_244(Class185.smethod_0(-1141164511), Class185.smethod_0(-1141309974), smethod_135(list, num2));
		num2 = Class44.smethod_2(num2, list.Count);
		num += smethod_244(Class185.smethod_0(-1141164529), Class185.smethod_0(-1141165583), Class44.smethod_1(num2 + 1, list.Count));
		num2 = Class44.smethod_2(num2, list.Count);
		num += smethod_244(Class185.smethod_0(-1141165587), Class185.smethod_0(-1141164198), Class44.smethod_1(num2 + 1, list.Count));
		num += smethod_244(Class185.smethod_0(-1141165609), Class185.smethod_0(-1141323176), smethod_135(list, num2));
		num2 = Class44.smethod_2(num2, list.Count);
		num += smethod_244(Class185.smethod_0(-1141165635), Class185.smethod_0(-1141164158), Class44.smethod_1(num2 + 1, list.Count));
		num += smethod_244(Class185.smethod_0(-1141165669), Class185.smethod_0(-1141309974), smethod_135(list, num2));
		DataGridView dataGridView6 = smethod_138(Class185.smethod_0(-1141291575));
		dataGridView6.Rows.Add(Class185.smethod_0(-1141312985));
		DataGridViewRow dataGridViewRow = dataGridView6.Rows[0];
		num += smethod_243(Class185.smethod_0(-1141165691), Class44.smethod_3(dataGridViewRow));
		dataGridView6.Rows.Remove(dataGridViewRow);
		num += smethod_243(Class185.smethod_0(-1141165728), !Class44.smethod_3(dataGridViewRow));
		num += smethod_243(Class185.smethod_0(-1141165757), !Class44.smethod_3(null));
		DataGridView dataGridView_ = smethod_138(Class185.smethod_0(-1141291575));
		DataGridView dataGridView7 = smethod_138(Class185.smethod_0(-1141286338));
		num += smethod_243(Class185.smethod_0(-1141165782), Class388.smethod_3(dataGridView_, dataGridView7, Class185.smethod_0(-1141312985), null));
		num += smethod_244(Class185.smethod_0(-1141165796), Class185.smethod_0(-1141312985), smethod_124(dataGridView_));
		num += smethod_244(Class185.smethod_0(-1141165831), string.Empty, smethod_124(dataGridView7));
		num += smethod_243(Class185.smethod_0(-1141165857), Class388.smethod_3(dataGridView_, dataGridView7, Class185.smethod_0(-1141165882), null));
		num += smethod_244(Class185.smethod_0(-1141165898), Class185.smethod_0(-1141322470), smethod_124(dataGridView_));
		DataGridView dataGridView8 = smethod_138(Class185.smethod_0(-1141291575));
		DataGridView dataGridView_2 = smethod_138(Class185.smethod_0(-1141286338));
		num += smethod_243(Class185.smethod_0(-1141165936), !Class388.smethod_3(dataGridView8, dataGridView_2, string.Empty, null));
		num += smethod_243(Class185.smethod_0(-1141165953), !Class388.smethod_3(dataGridView8, dataGridView_2, Class185.smethod_0(-1141341332), null));
		num += smethod_243(Class185.smethod_0(-1141165991), !Class388.smethod_3(dataGridView8, dataGridView_2, null, null));
		num += smethod_244(Class185.smethod_0(-1141166015), string.Empty, smethod_124(dataGridView8));
		num += smethod_244(Class185.smethod_0(-1141166045), 0, dataGridView8.Rows.Count);
		DataGridView dataGridView9 = smethod_138(Class185.smethod_0(-1141291575));
		DataGridView dataGridView_3 = smethod_138(Class185.smethod_0(-1141286338));
		dataGridView9.Rows.Add(Class185.smethod_0(-1141312985));
		num += smethod_243(Class185.smethod_0(-1141166068), !Class388.smethod_3(dataGridView9, dataGridView_3, Class185.smethod_0(-1141312985), null));
		num += smethod_243(Class185.smethod_0(-1141165073), !Class388.smethod_3(dataGridView9, dataGridView_3, Class185.smethod_0(-1141325669), null));
		num += smethod_243(Class185.smethod_0(-1141165109), !Class388.smethod_3(dataGridView9, dataGridView_3, Class185.smethod_0(-1141165131), null));
		num += smethod_244(Class185.smethod_0(-1141165145), Class185.smethod_0(-1141312985), smethod_124(dataGridView9));
		DataGridView dataGridView_4 = smethod_138(Class185.smethod_0(-1141291575));
		DataGridView dataGridView10 = smethod_138(Class185.smethod_0(-1141286338));
		dataGridView10.Rows.Add(Class185.smethod_0(-1141324855));
		num += smethod_243(Class185.smethod_0(-1141165181), !Class388.smethod_3(dataGridView_4, dataGridView10, Class185.smethod_0(-1141324855), null));
		num += smethod_243(Class185.smethod_0(-1141165208), !Class388.smethod_3(dataGridView_4, dataGridView10, Class185.smethod_0(-1141322731), null));
		num += smethod_243(Class185.smethod_0(-1141165240), !Class388.smethod_3(dataGridView_4, dataGridView10, Class185.smethod_0(-1141165266), null));
		num += smethod_244(Class185.smethod_0(-1141165282), string.Empty, smethod_124(dataGridView_4));
		num += smethod_244(Class185.smethod_0(-1141165314), Class185.smethod_0(-1141324855), smethod_124(dataGridView10));
		num += smethod_243(Class185.smethod_0(-1141165360), Class388.smethod_3(dataGridView_4, dataGridView10, Class185.smethod_0(-1141324859), null));
		num += smethod_244(Class185.smethod_0(-1141165380), Class185.smethod_0(-1141324859), smethod_124(dataGridView_4));
		DataGridView dataGridView11 = smethod_138(Class185.smethod_0(-1141291575));
		dataGridView11.AllowUserToAddRows = true;
		num += smethod_243(Class185.smethod_0(-1141165421), Class388.smethod_3(dataGridView11, null, Class185.smethod_0(-1141312985), null));
		num += smethod_244(Class185.smethod_0(-1141165442), Class185.smethod_0(-1141312985), smethod_124(dataGridView11));
		num += smethod_243(Class185.smethod_0(-1141165473), !Class388.smethod_3(dataGridView11, null, Class185.smethod_0(-1141313005), null));
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141165507) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
		try
		{
			Class67 @class = new Class67(text);
			DataGridView dataGridView_5 = smethod_138(Class185.smethod_0(-1141291575));
			DataGridView dataGridView12 = smethod_138(Class185.smethod_0(-1141286338));
			@class.method_7(dataGridView12, Class185.smethod_0(-1141322682));
			@class.method_8(Class185.smethod_0(-1141165536));
			num += smethod_243(Class185.smethod_0(-1141165560), Class388.smethod_3(dataGridView_5, dataGridView12, Class185.smethod_0(-1141162506), @class));
			num += smethod_244(Class185.smethod_0(-1141162523), Class185.smethod_0(-1141162506), smethod_124(dataGridView_5));
			smethod_123(dataGridView_5, 0);
			num += smethod_244(Class185.smethod_0(-1141162554), 1, Class388.smethod_0(dataGridView_5, dataGridView12, @class));
			num += smethod_244(Class185.smethod_0(-1141162580), Class185.smethod_0(-1141162506), smethod_124(dataGridView12));
			num += smethod_244(Class185.smethod_0(-1141162611), string.Empty, smethod_124(dataGridView_5));
			num += smethod_243(Class185.smethod_0(-1141162643), !Class388.smethod_3(dataGridView_5, dataGridView12, Class185.smethod_0(-1141162682), @class));
			Class67 class2 = new Class67(text);
			DataGridView dataGridView_6 = smethod_138(Class185.smethod_0(-1141286338));
			class2.method_7(dataGridView_6, Class185.smethod_0(-1141322682));
			class2.method_8(Class185.smethod_0(-1141165536));
			num += smethod_244(Class185.smethod_0(-1141162699), Class185.smethod_0(-1141162506), smethod_124(dataGridView_6));
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
		Console.WriteLine(Class185.smethod_0(-1141162736) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_128()
	{
		int num = 0;
		num = 0 + smethod_244(Class185.smethod_0(-1141162745), Class185.smethod_0(-1141162764), Class440.smethod_5(12f, 3f, -7f));
		num += smethod_244(Class185.smethod_0(-1141162778), Class185.smethod_0(-1141162804), Class440.smethod_5(12.5f, 3.25f, -7.5f));
		num += smethod_244(Class185.smethod_0(-1141162825), Class185.smethod_0(-1141162843), Class440.smethod_5(0f, 0f, 0f));
		num += smethod_244(Class185.smethod_0(-1141162863), Class185.smethod_0(-1141162885), Class440.smethod_5(-1.5f, -2.25f, -3f));
		num += smethod_244(Class185.smethod_0(-1141162897), Class185.smethod_0(-1141162924), Class440.smethod_5(1.234f, 0f, 0f));
		num += smethod_244(Class185.smethod_0(-1141162939), Class185.smethod_0(-1141162983), Class440.smethod_5(1.5f, 2f, 3f));
		num += smethod_243(Class185.smethod_0(-1141162997), Class440.smethod_5(-123.45f, 6.78f, 90f).IndexOf(' ') < 0);
		num += smethod_244(Class185.smethod_0(-1141161988), Class185.smethod_0(-1141162024), Class440.smethod_5(1f, 2f, 3f));
		num += smethod_243(Class185.smethod_0(-1141162028), Class440.smethod_6(Class185.smethod_0(-1141162024), out var float_, out var float_2, out var float_3));
		num += smethod_243(Class185.smethod_0(-1141162064), Math.Abs(float_ - 1f) < 0.001f);
		num += smethod_243(Class185.smethod_0(-1141162083), Math.Abs(float_2 - 2f) < 0.001f);
		num += smethod_243(Class185.smethod_0(-1141162118), Math.Abs(float_3 - 3f) < 0.001f);
		string text = Class440.smethod_5(10f, 99f, 20f);
		num += smethod_244(Class185.smethod_0(-1141162137), Class185.smethod_0(-1141162169), text);
		num += smethod_243(Class185.smethod_0(-1141162192), Class440.smethod_6(text, out var float_4, out var float_5, out var float_6));
		num += smethod_243(Class185.smethod_0(-1141162210), Math.Abs(float_4 - 10f) < 0.001f && Math.Abs(float_6 - 20f) < 0.001f);
		num += smethod_243(Class185.smethod_0(-1141162243), Math.Abs(float_5 - 99f) < 0.001f);
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
		num += smethod_244(Class185.smethod_0(-1141162278), 0, num2);
		string[] array2 = new string[13]
		{
			null,
			string.Empty,
			Class185.smethod_0(-1141341332),
			Class185.smethod_0(-1141296467),
			Class185.smethod_0(-1141162297),
			Class185.smethod_0(-1141162307),
			Class185.smethod_0(-1141162321),
			Class185.smethod_0(-1141162342),
			Class185.smethod_0(-1141162345),
			Class185.smethod_0(-1141162365),
			Class185.smethod_0(-1141162369),
			Class185.smethod_0(-1141162380),
			Class185.smethod_0(-1141162400)
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
		num += smethod_244(Class185.smethod_0(-1141162416), 0, num6);
		num += smethod_244(Class185.smethod_0(-1141162443), 0, num7);
		num += smethod_243(Class185.smethod_0(-1141162486), Class440.smethod_6(Class185.smethod_0(-1141163532), out var float_13, out var float_14, out var float_15));
		num += smethod_243(Class185.smethod_0(-1141163560), Math.Abs(float_13 - 1f) < 0.001f && Math.Abs(float_14 - 2f) < 0.001f && Math.Abs(float_15 - 3f) < 0.001f);
		CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
		try
		{
			Thread.CurrentThread.CurrentCulture = new CultureInfo(Class185.smethod_0(-1141163579));
			num += smethod_244(Class185.smethod_0(-1141163599), Class185.smethod_0(-1141163622), Class440.smethod_5(1.5f, 2.25f, -3.75f));
			num += smethod_243(Class185.smethod_0(-1141163635), Class440.smethod_6(Class185.smethod_0(-1141163622), out var float_16, out var float_17, out var float_18));
			num += smethod_243(Class185.smethod_0(-1141163657), Math.Abs(float_16 - 1.5f) < 0.001f && Math.Abs(float_17 - 2.25f) < 0.001f && Math.Abs(float_18 + 3.75f) < 0.001f);
			num += smethod_243(Class185.smethod_0(-1141163694), Class440.smethod_5(1.5f, 2.25f, -3.75f) == Class185.smethod_0(-1141163622));
			num += smethod_243(Class185.smethod_0(-1141163720), !Class440.smethod_6(Class185.smethod_0(-1141163758), out var _, out var _, out var _));
		}
		finally
		{
			Thread.CurrentThread.CurrentCulture = currentCulture;
		}
		num += smethod_243(Class185.smethod_0(-1141163771), GForm0.smethod_8(Enum0.Selected, bool_23: true, bool_24: true));
		num += smethod_243(Class185.smethod_0(-1141163806), GForm0.smethod_8(Enum0.Started, bool_23: true, bool_24: true));
		num += smethod_243(Class185.smethod_0(-1141163832), !GForm0.smethod_8(Enum0.Idle, bool_23: true, bool_24: true));
		num += smethod_243(Class185.smethod_0(-1141163855), !GForm0.smethod_8(Enum0.Attached, bool_23: true, bool_24: true));
		num += smethod_243(Class185.smethod_0(-1141163874), !GForm0.smethod_8(Enum0.Selected, bool_23: false, bool_24: true));
		num += smethod_243(Class185.smethod_0(-1141163926), !GForm0.smethod_8(Enum0.Started, bool_23: false, bool_24: true));
		num += smethod_243(Class185.smethod_0(-1141163967), !GForm0.smethod_8(Enum0.Selected, bool_23: true, bool_24: false));
		num += smethod_243(Class185.smethod_0(-1141163997), !GForm0.smethod_8(Enum0.Idle, bool_23: false, bool_24: false));
		Console.WriteLine(Class185.smethod_0(-1141164030) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_129()
	{
		int num = 0;
		DataGridView dataGridView = new DataGridView();
		Class440.smethod_0(dataGridView);
		dataGridView.AllowUserToAddRows = false;
		dataGridView.CreateControl();
		dataGridView.Rows.Add(Class185.smethod_0(-1141296467), Class185.smethod_0(-1141297402), Class185.smethod_0(-1141296459), Class185.smethod_0(-1141317953), Class185.smethod_0(-1141296459));
		dataGridView.Rows.Add(Class185.smethod_0(-1141297437), Class185.smethod_0(-1141291508), Class185.smethod_0(-1141296459), Class185.smethod_0(-1141317953), Class185.smethod_0(-1141296459));
		dataGridView.Rows.Add(Class185.smethod_0(-1141163021), Class185.smethod_0(-1141163031), Class185.smethod_0(-1141296459), Class185.smethod_0(-1141317953), Class185.smethod_0(-1141296459));
		dataGridView.Rows.Add(Class185.smethod_0(-1141305630), Class185.smethod_0(-1141291516), Class185.smethod_0(-1141296459), Class185.smethod_0(-1141317953), Class185.smethod_0(-1141296459));
		List<Struct76> list = Class440.smethod_10(dataGridView);
		num = 0 + smethod_244(Class185.smethod_0(-1141163033), 3, list.Count);
		if (list.Count == 3)
		{
			num += smethod_244(Class185.smethod_0(-1141163064), 0, list[0].int_1);
			num += smethod_244(Class185.smethod_0(-1141163086), 1, list[1].int_1);
			num += smethod_244(Class185.smethod_0(-1141163100), 3, list[2].int_1);
		}
		Class440.smethod_11(dataGridView, list[1].int_1);
		num += smethod_244(Class185.smethod_0(-1141163122), 1, dataGridView.SelectedRows.Count);
		if (dataGridView.SelectedRows.Count == 1)
		{
			num += smethod_244(Class185.smethod_0(-1141163154), list[1].int_1, dataGridView.SelectedRows[0].Index);
		}
		dataGridView.CurrentCell = dataGridView.Rows[list[1].int_1].Cells[0];
		num += smethod_244(Class185.smethod_0(-1141163192), list[1].int_1, dataGridView.CurrentRow.Index);
		Class440.smethod_11(dataGridView, list[1].int_1);
		num += smethod_244(Class185.smethod_0(-1141163221), 1, dataGridView.SelectedRows.Count);
		if (dataGridView.SelectedRows.Count == 1)
		{
			num += smethod_244(Class185.smethod_0(-1141163255), list[1].int_1, dataGridView.SelectedRows[0].Index);
		}
		num += smethod_244(Class185.smethod_0(-1141163287), list[1].int_1, dataGridView.CurrentRow.Index);
		Class440.smethod_11(dataGridView, -5);
		Class440.smethod_11(dataGridView, 999);
		num += smethod_244(Class185.smethod_0(-1141163315), 1, dataGridView.SelectedRows.Count);
		if (dataGridView.SelectedRows.Count == 1)
		{
			num += smethod_244(Class185.smethod_0(-1141163350), list[1].int_1, dataGridView.SelectedRows[0].Index);
		}
		num += smethod_244(Class185.smethod_0(-1141163375), list[1].int_1, dataGridView.CurrentRow.Index);
		Console.WriteLine(Class185.smethod_0(-1141163396) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_130()
	{
		int num = 0;
		Dictionary<string, string> dictionary_ = new Dictionary<string, string>(StringComparer.Ordinal)
		{
			{
				Class185.smethod_0(-1141163423),
				Class185.smethod_0(-1141163427)
			},
			{
				Class185.smethod_0(-1141163450),
				Class185.smethod_0(-1141163470)
			},
			{
				Class185.smethod_0(-1141163486),
				Class185.smethod_0(-1141341332)
			},
			{
				Class185.smethod_0(-1141163490),
				Class185.smethod_0(-1141163510)
			}
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
		num = 0 + smethod_244(Class185.smethod_0(-1141168643), 6, class2.method_2().Count);
		List<Class447.Class452> list = Class447.smethod_10(class2, @class);
		num += smethod_244(Class185.smethod_0(-1141168676), 3, list.Count);
		num += smethod_243(Class185.smethod_0(-1141168712), !smethod_133(list, 11u));
		num += smethod_243(Class185.smethod_0(-1141168731), !smethod_133(list, 12u));
		num += smethod_243(Class185.smethod_0(-1141168774), !smethod_133(list, 13u));
		num += smethod_243(Class185.smethod_0(-1141168793), smethod_133(list, 14u));
		num += smethod_243(Class185.smethod_0(-1141168832), smethod_133(list, 15u));
		num += smethod_243(Class185.smethod_0(-1141168852), smethod_133(list, 16u));
		if (list.Count == 3)
		{
			num += smethod_244(Class185.smethod_0(-1141168887), 14u, list[0].class403_0.uint_0);
			num += smethod_244(Class185.smethod_0(-1141168920), 15u, list[1].class403_0.uint_0);
			num += smethod_244(Class185.smethod_0(-1141168942), 16u, list[2].class403_0.uint_0);
			num += smethod_243(Class185.smethod_0(-1141168976), Math.Abs(list[0].float_0 - 3f) < 0.001f);
			num += smethod_243(Class185.smethod_0(-1141168997), Math.Abs(list[1].float_0 - 5f) < 0.001f);
			num += smethod_243(Class185.smethod_0(-1141169010), Math.Abs(list[2].float_0 - 10f) < 0.001f);
		}
		if (list.Count == 3)
		{
			num += smethod_244(Class185.smethod_0(-1141169039), Class185.smethod_0(-1141163427), list[1].string_0);
			num += smethod_243(Class185.smethod_0(-1141169059), list[0].string_0 == null);
			num += smethod_243(Class185.smethod_0(-1141169097), !Class447.smethod_11(list[0]));
			num += smethod_243(Class185.smethod_0(-1141169143), Class447.smethod_11(list[1]));
			num += smethod_243(Class185.smethod_0(-1141168151), Class447.smethod_11(list[2]));
			num += smethod_244(Class185.smethod_0(-1141168179), 2, Class447.smethod_14(list));
			num += smethod_244(Class185.smethod_0(-1141168216), Class185.smethod_0(-1141168251), Class447.smethod_12(list[0]));
			num += smethod_243(Class185.smethod_0(-1141168286), Class447.smethod_13(list[0]).IndexOf(Class185.smethod_0(-1141168251), StringComparison.Ordinal) < 0);
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < list.Count; i++)
			{
				if (Class447.smethod_11(list[i]))
				{
					string string_ = list[i].string_0;
					if (string_ == Class185.smethod_0(-1141168251))
					{
						num2++;
					}
					if (string_ == null || string_.Trim().Length == 0)
					{
						num3++;
					}
				}
			}
			num += smethod_244(Class185.smethod_0(-1141168329), 0, num2);
			num += smethod_244(Class185.smethod_0(-1141168370), 0, num3);
		}
		if (list.Count == 3)
		{
			num += smethod_244(Class185.smethod_0(-1141168413), list[1].string_0, list[2].string_0);
			num += smethod_243(Class185.smethod_0(-1141168448), list[1].class403_0.uint_0 != list[2].class403_0.uint_0);
			num += smethod_244(Class185.smethod_0(-1141168486), Class447.smethod_12(list[1]), Class447.smethod_12(list[2]));
			num += smethod_243(Class185.smethod_0(-1141168526), Class447.smethod_13(list[1]) != Class447.smethod_13(list[2]));
			num += smethod_244(Class185.smethod_0(-1141168567), Class185.smethod_0(-1141163427), Class447.smethod_12(list[1]));
			num += smethod_244(Class185.smethod_0(-1141168588), Class185.smethod_0(-1141305630), Class447.smethod_13(list[1]));
			num += smethod_244(Class185.smethod_0(-1141168617), Class185.smethod_0(-1141163427), Class447.smethod_12(list[2]));
			num += smethod_244(Class185.smethod_0(-1141169677), Class185.smethod_0(-1141276741), Class447.smethod_13(list[2]));
			num += smethod_244(Class185.smethod_0(-1141169697), Class185.smethod_0(-1141297437), Class447.smethod_13(list[0]));
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
			num += smethod_244(Class185.smethod_0(-1141169732), 0, num4);
		}
		List<Class447.Class452> list2 = Class447.smethod_10(smethod_132(new List<Class403>
		{
			smethod_131(1, 100, 1, 31u, 0f, 4f),
			smethod_131(1, 100, 1, 32u, 4f, 0f)
		}, dictionary_, @class), @class);
		num += smethod_244(Class185.smethod_0(-1141169770), 2, list2.Count);
		if (list2.Count == 2)
		{
			num += smethod_243(Class185.smethod_0(-1141169794), Math.Abs(list2[0].float_0 - list2[1].float_0) < 0.001f);
			num += smethod_244(Class185.smethod_0(-1141169826), 31u, list2[0].class403_0.uint_0);
			num += smethod_244(Class185.smethod_0(-1141169865), 32u, list2[1].class403_0.uint_0);
		}
		List<Class447.Class452> list3 = Class447.smethod_10(smethod_132(new List<Class403>
		{
			smethod_131(1, 100, 1, 32u, 4f, 0f),
			smethod_131(1, 100, 1, 31u, 0f, 4f)
		}, dictionary_, @class), @class);
		num += smethod_244(Class185.smethod_0(-1141169912), 32u, (list3.Count == 2) ? list3[0].class403_0.uint_0 : 0u);
		List<Class447.Class452> list4 = Class447.smethod_10(smethod_132(new List<Class403>
		{
			smethod_131(1, 500, 1, 41u, 1f, 0f),
			smethod_131(1, 700, 1, 42u, 2f, 0f)
		}, dictionary_, @class), @class);
		num += smethod_244(Class185.smethod_0(-1141169950), 2, list4.Count);
		if (list4.Count == 2)
		{
			num += smethod_243(Class185.smethod_0(-1141169974), list4[0].string_0 == null);
			num += smethod_243(Class185.smethod_0(-1141170007), !Class447.smethod_11(list4[0]));
			num += smethod_244(Class185.smethod_0(-1141170045), Class185.smethod_0(-1141170067), list4[1].string_0);
			num += smethod_243(Class185.smethod_0(-1141170084), Class447.smethod_11(list4[1]));
		}
		num += smethod_244(Class185.smethod_0(-1141170128), 0, Class447.smethod_10(Class145.class145_0.method_93(@class, 1, 0), @class).Count);
		Class145 class3 = smethod_132(new List<Class403>
		{
			smethod_131(2, 300, 1, 51u, 1f, 0f),
			smethod_131(2, 300, 1, 52u, 2f, 0f)
		}, dictionary_, @class);
		num += smethod_244(Class185.smethod_0(-1141170147), 2, class3.method_2().Count);
		num += smethod_244(Class185.smethod_0(-1141169153), 0, Class447.smethod_10(class3, @class).Count);
		num += smethod_244(Class185.smethod_0(-1141169179), 0, Class447.smethod_10(class3, null).Count);
		num += smethod_244(Class185.smethod_0(-1141169201), 0, Class447.smethod_10(null, @class).Count);
		num += smethod_244(Class185.smethod_0(-1141169232), 0, Class447.smethod_14(null));
		num += smethod_243(Class185.smethod_0(-1141169258), Class447.smethod_12(null) == string.Empty);
		num += smethod_243(Class185.smethod_0(-1141169301), Class447.smethod_13(null) == string.Empty);
		num += smethod_243(Class185.smethod_0(-1141169336), !Class447.smethod_11(null));
		num += smethod_243(Class185.smethod_0(-1141169366), GForm0.smethod_8(Enum0.Selected, bool_23: true, bool_24: true));
		num += smethod_243(Class185.smethod_0(-1141169390), !GForm0.smethod_8(Enum0.Selected, bool_23: false, bool_24: true));
		num += smethod_243(Class185.smethod_0(-1141169437), !GForm0.smethod_8(Enum0.Attached, bool_23: true, bool_24: true));
		Console.WriteLine(Class185.smethod_0(-1141169470) + num + Class185.smethod_0(-1141356690));
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
		if (string_0.IndexOf(Class185.smethod_0(-1141169486), StringComparison.Ordinal) < 0)
		{
			return string_0.IndexOf(Class185.smethod_0(-1141169495), StringComparison.Ordinal) >= 0;
		}
		return true;
	}

	private static string smethod_135(List<DataGridViewRow> list_0, int int_0)
	{
		if (int_0 >= 0 && int_0 < list_0.Count)
		{
			return Class388.smethod_8(list_0[int_0]);
		}
		return Class185.smethod_0(-1141350722);
	}

	private static string smethod_136(List<DataGridViewRow> list_0)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < list_0.Count; i++)
		{
			list.Add(Class388.smethod_8(list_0[i]));
		}
		return string.Join(Class185.smethod_0(-1141326297), list.ToArray());
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
				HeaderText = Class185.smethod_0(-1141325818)
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
		return string.Join(Class185.smethod_0(-1141326297), list.ToArray());
	}

	private static DataGridView smethod_140()
	{
		DataGridView dataGridView = new DataGridView();
		dataGridView.AllowUserToAddRows = false;
		dataGridView.ColumnHeadersVisible = false;
		dataGridView.Columns.AddRange(new DataGridViewTextBoxColumn
		{
			Name = Class185.smethod_0(-1141169504),
			HeaderText = Class185.smethod_0(-1141278773)
		}, new DataGridViewTextBoxColumn
		{
			Name = Class185.smethod_0(-1141169520),
			HeaderText = Class185.smethod_0(-1141278787)
		}, new DataGridViewTextBoxColumn
		{
			Name = Class185.smethod_0(-1141169536),
			HeaderText = Class185.smethod_0(-1141284167)
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
									if (Math.Abs(class455_0.float_0[num2] - class455_1.float_0[num2]) <= 0.0001f)
									{
										if (Math.Abs(class455_0.float_1[num2] - class455_1.float_1[num2]) <= 0.0001f)
										{
											if (!(Math.Abs(class455_0.float_2[num2] - class455_1.float_2[num2]) <= 0.0001f))
											{
												break;
											}
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
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141169552) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
		try
		{
			string text2 = Path.Combine(text, Class185.smethod_0(-1141169573));
			smethod_145(text2, Class185.smethod_0(-1141307890), Class185.smethod_0(-1141169589), Class185.smethod_0(-1141286338), new string[1] { Class185.smethod_0(-1141312985) });
			smethod_145(text2, Class185.smethod_0(-1141307890), Class185.smethod_0(-1141169608), Class185.smethod_0(-1141286338), new string[1] { Class185.smethod_0(-1141324855) });
			smethod_145(text2, Class185.smethod_0(-1141307890), Class185.smethod_0(-1141169620), Class185.smethod_0(-1141286338), new string[1] { Class185.smethod_0(-1141324859) });
			smethod_145(text2, Class185.smethod_0(-1141308943), Class185.smethod_0(-1141169608), Class185.smethod_0(-1141286338), new string[1] { Class185.smethod_0(-1141169647) });
			File.WriteAllText(Path.Combine(text2, Class185.smethod_0(-1141307890)), Class185.smethod_0(-1141252598));
			num += smethod_244(Class185.smethod_0(-1141169650), Class185.smethod_0(-1141166610), smethod_240(Class176.smethod_3(text2, Class185.smethod_0(-1141307890), Class176.smethod_0(Class185.smethod_0(-1141169589)))));
			num += smethod_244(Class185.smethod_0(-1141166643), Class185.smethod_0(-1141166679), smethod_240(Class176.smethod_3(text2, Class185.smethod_0(-1141307890), null)));
			num += smethod_244(Class185.smethod_0(-1141166725), string.Empty, smethod_240(Class176.smethod_3(Path.Combine(text, Class185.smethod_0(-1141166747)), Class185.smethod_0(-1141307890), Class185.smethod_0(-1141169589))));
			string text3 = Class185.smethod_0(-1141166766);
			num += smethod_244(Class185.smethod_0(-1141166800), Class185.smethod_0(-1141166830), Class176.smethod_2(text3, Class185.smethod_0(-1141307890)));
			num += smethod_244(Class185.smethod_0(-1141166841), Class185.smethod_0(-1141166881), Path.GetFileNameWithoutExtension(text3).Replace(Class185.smethod_0(-1141166890), string.Empty));
			num += smethod_244(Class185.smethod_0(-1141166907), string.Empty, Class176.smethod_2(Class185.smethod_0(-1141166938), Class185.smethod_0(-1141307890)));
			num += smethod_244(Class185.smethod_0(-1141166963), string.Empty, Class176.smethod_2(Class185.smethod_0(-1141307890), Class185.smethod_0(-1141307890)));
			num += smethod_244(Class185.smethod_0(-1141166994), string.Empty, Class176.smethod_2(Class185.smethod_0(-1141261521), Class185.smethod_0(-1141307890)));
			string string_ = Path.Combine(text, Class185.smethod_0(-1141167030));
			smethod_145(string_, Class185.smethod_0(-1141307890), Class185.smethod_0(-1141166830), Class185.smethod_0(-1141286338), new string[1] { Class185.smethod_0(-1141312985) });
			num += smethod_244(Class185.smethod_0(-1141167033), Class185.smethod_0(-1141166830), smethod_240(Class176.smethod_3(string_, Class185.smethod_0(-1141307890), Class176.smethod_0(Class185.smethod_0(-1141169589)))));
			string text4 = Path.Combine(text, Class185.smethod_0(-1141167072));
			smethod_145(text4, Class185.smethod_0(-1141307890), Class185.smethod_0(-1141169608), Class185.smethod_0(-1141286338), new string[2]
			{
				Class185.smethod_0(-1141324855),
				Class185.smethod_0(-1141324859)
			});
			smethod_145(text4, Class185.smethod_0(-1141307890), Class185.smethod_0(-1141169620), Class185.smethod_0(-1141286338), Array.Empty<string>());
			Class67 @class = new Class67(text4);
			string text5 = Class67.smethod_1(smethod_138(Class185.smethod_0(-1141286338)));
			num += smethod_244(Class185.smethod_0(-1141167085), Class185.smethod_0(-1141286338), text5);
			num += smethod_244(Class185.smethod_0(-1141166087), Class185.smethod_0(-1141323478), smethod_240(Class67.smethod_2(@class.method_18(Class176.smethod_1(Class185.smethod_0(-1141169608), Class185.smethod_0(-1141307890))), text5)));
			num += smethod_244(Class185.smethod_0(-1141166106), string.Empty, smethod_240(Class67.smethod_2(@class.method_18(Class176.smethod_1(Class185.smethod_0(-1141169620), Class185.smethod_0(-1141307890))), text5)));
			num += smethod_244(Class185.smethod_0(-1141166139), string.Empty, smethod_240(Class67.smethod_2(@class.method_18(Class176.smethod_1(Class185.smethod_0(-1141166169), Class185.smethod_0(-1141307890))), text5)));
			File.WriteAllText(Path.Combine(text4, Class185.smethod_0(-1141166190)), Class185.smethod_0(-1141166211));
			File.WriteAllText(Path.Combine(text4, Class185.smethod_0(-1141166235)), Class185.smethod_0(-1141166272));
			File.WriteAllText(Path.Combine(text4, Class185.smethod_0(-1141166294)), Class185.smethod_0(-1141166315));
			bool flag = false;
			int gparam_ = -1;
			try
			{
				gparam_ = @class.method_18(Class185.smethod_0(-1141166190)).Count + @class.method_18(Class185.smethod_0(-1141166235)).Count + @class.method_18(Class185.smethod_0(-1141166294)).Count;
			}
			catch (Exception)
			{
				flag = true;
			}
			num += smethod_243(Class185.smethod_0(-1141166344), !flag);
			num += smethod_244(Class185.smethod_0(-1141166382), 0, gparam_);
			num += smethod_244(Class185.smethod_0(-1141166409), string.Empty, smethod_240(Class67.smethod_2(@class.method_18(Class176.smethod_1(Class185.smethod_0(-1141169608), Class185.smethod_0(-1141307890))), Class185.smethod_0(-1141166442))));
			Class332 class2 = new Class332();
			string text6 = Path.Combine(text, Class185.smethod_0(-1141166472));
			smethod_145(text6, Class185.smethod_0(-1141307890), Class185.smethod_0(-1141169608), Class185.smethod_0(-1141286338), new string[3]
			{
				Class185.smethod_0(-1141324855),
				Class185.smethod_0(-1141324859),
				Class185.smethod_0(-1141169647)
			});
			Class67 class3 = new Class67(text6);
			DataGridView dataGridView = smethod_138(Class185.smethod_0(-1141286338));
			class3.method_7(dataGridView, Class185.smethod_0(-1141307890));
			class3.method_8(Class185.smethod_0(-1141169589));
			using (class3.method_17(dataGridView))
			{
				dataGridView.Rows.Add(Class185.smethod_0(-1141312985));
				dataGridView.Rows.Add(Class185.smethod_0(-1141324855));
			}
			class2.string_0 = Path.Combine(text6, Class176.smethod_1(Class185.smethod_0(-1141169589), Class185.smethod_0(-1141307890)));
			num += smethod_244(Class185.smethod_0(-1141166496), 2, smethod_146(class2.string_0));
			string gparam_2 = File.ReadAllText(class2.string_0);
			int num2 = class3.method_3();
			List<string> list_ = Class67.smethod_2(class3.method_18(Class176.smethod_1(Class185.smethod_0(-1141169608), Class185.smethod_0(-1141307890))), Class67.smethod_1(dataGridView));
			num += smethod_244(Class185.smethod_0(-1141166515), Class185.smethod_0(-1141166549), smethod_240(list_));
			num += smethod_244(Class185.smethod_0(-1141166573), num2, class3.method_3());
			num += smethod_244(Class185.smethod_0(-1141167632), gparam_2, File.ReadAllText(class2.string_0));
			class2.list_0 = new List<int>();
			dataGridView.RowsAdded += class2.method_0;
			dataGridView.RowsRemoved += class2.method_1;
			int gparam_3 = Class388.smethod_4(dataGridView, list_, class3);
			num += smethod_244(Class185.smethod_0(-1141167660), 2, gparam_3);
			num += smethod_244(Class185.smethod_0(-1141167695), Class185.smethod_0(-1141167723), smethod_124(dataGridView));
			num += smethod_244(Class185.smethod_0(-1141167753), Class185.smethod_0(-1141167723), smethod_139(dataGridView));
			num += smethod_244(Class185.smethod_0(-1141167799), num2 + 1, class3.method_3());
			num += smethod_244(Class185.smethod_0(-1141167831), 4, smethod_146(class2.string_0));
			int num3 = int.MaxValue;
			for (int i = 0; i < class2.list_0.Count; i++)
			{
				if (class2.list_0[i] < num3)
				{
					num3 = class2.list_0[i];
				}
			}
			num += smethod_243(Class185.smethod_0(-1141167862), class2.list_0.Count > 0);
			num += smethod_243(Class185.smethod_0(-1141167883), num3 >= 2);
			string text7 = Path.Combine(text, Class185.smethod_0(-1141167926));
			smethod_145(text7, Class185.smethod_0(-1141307890), Class185.smethod_0(-1141169608), Class185.smethod_0(-1141286338), new string[4]
			{
				Class185.smethod_0(-1141167938),
				Class185.smethod_0(-1141167960),
				Class185.smethod_0(-1141324859),
				Class185.smethod_0(-1141341332)
			});
			Class67 class4 = new Class67(text7);
			DataGridView dataGridView2 = smethod_138(Class185.smethod_0(-1141286338));
			class4.method_7(dataGridView2, Class185.smethod_0(-1141307890));
			class4.method_8(Class185.smethod_0(-1141169589));
			using (class4.method_17(dataGridView2))
			{
				dataGridView2.Rows.Add(Class185.smethod_0(-1141324855));
			}
			List<string> list_2 = Class67.smethod_2(class4.method_18(Class176.smethod_1(Class185.smethod_0(-1141169608), Class185.smethod_0(-1141307890))), Class67.smethod_1(dataGridView2));
			num += smethod_244(Class185.smethod_0(-1141167964), Class185.smethod_0(-1141167999), smethod_240(list_2));
			int num4 = class4.method_3();
			num += smethod_244(Class185.smethod_0(-1141168018), 1, Class388.smethod_4(dataGridView2, list_2, class4));
			num += smethod_244(Class185.smethod_0(-1141168054), Class185.smethod_0(-1141323478), smethod_124(dataGridView2));
			num += smethod_244(Class185.smethod_0(-1141168073), num4 + 1, class4.method_3());
			string text8 = Path.Combine(text, Class185.smethod_0(-1141168106));
			smethod_145(text8, Class185.smethod_0(-1141307890), Class185.smethod_0(-1141169620), Class185.smethod_0(-1141286338), Array.Empty<string>());
			Class67 class5 = new Class67(text8);
			DataGridView dataGridView3 = smethod_138(Class185.smethod_0(-1141286338));
			class5.method_7(dataGridView3, Class185.smethod_0(-1141307890));
			class5.method_8(Class185.smethod_0(-1141169589));
			using (class5.method_17(dataGridView3))
			{
				dataGridView3.Rows.Add(Class185.smethod_0(-1141312985));
				dataGridView3.Rows.Add(Class185.smethod_0(-1141324855));
			}
			File.WriteAllText(Path.Combine(text8, Class185.smethod_0(-1141167105)), Class185.smethod_0(-1141166211));
			string path = Path.Combine(text8, Class176.smethod_1(Class185.smethod_0(-1141169589), Class185.smethod_0(-1141307890)));
			string string_2 = Class67.smethod_1(dataGridView3);
			string[] array = new string[3]
			{
				Class176.smethod_1(Class185.smethod_0(-1141166169), Class185.smethod_0(-1141307890)),
				Class185.smethod_0(-1141167105),
				Class176.smethod_1(Class185.smethod_0(-1141169620), Class185.smethod_0(-1141307890))
			};
			string[] array2 = new string[3]
			{
				Class185.smethod_0(-1141304945),
				Class185.smethod_0(-1141167141),
				Class185.smethod_0(-1141167147)
			};
			for (int j = 0; j < array.Length; j++)
			{
				string gparam_4 = File.ReadAllText(path);
				int gparam_5 = class5.method_3();
				List<string> list = Class67.smethod_2(class5.method_18(array[j]), string_2);
				num += smethod_244(Class185.smethod_0(-1141167161) + array2[j] + Class185.smethod_0(-1141167177), 0, list.Count);
				num += smethod_244(Class185.smethod_0(-1141167161) + array2[j] + Class185.smethod_0(-1141167197), 0, Class388.smethod_4(dataGridView3, list, class5));
				num += smethod_244(Class185.smethod_0(-1141167161) + array2[j] + Class185.smethod_0(-1141167202), gparam_5, class5.method_3());
				num += smethod_244(Class185.smethod_0(-1141167161) + array2[j] + Class185.smethod_0(-1141167218), gparam_4, File.ReadAllText(path));
				num += smethod_244(Class185.smethod_0(-1141167161) + array2[j] + Class185.smethod_0(-1141167239), Class185.smethod_0(-1141322470), smethod_124(dataGridView3));
			}
			string text9 = Path.Combine(text, Class185.smethod_0(-1141167243));
			smethod_145(text9, Class185.smethod_0(-1141307890), Class185.smethod_0(-1141169608), Class185.smethod_0(-1141286338), new string[2]
			{
				Class185.smethod_0(-1141324859),
				Class185.smethod_0(-1141169647)
			});
			Class67 class6 = new Class67(text9);
			DataGridView dataGridView4 = smethod_138(Class185.smethod_0(-1141286338));
			class6.method_7(dataGridView4, Class185.smethod_0(-1141307890));
			class6.method_8(Class185.smethod_0(-1141169589));
			using (class6.method_17(dataGridView4))
			{
				dataGridView4.Rows.Add(Class185.smethod_0(-1141312985));
			}
			DataGridView dataGridView5 = smethod_138(Class185.smethod_0(-1141291575));
			dataGridView5.Rows.Add(Class185.smethod_0(-1141323391));
			dataGridView5.Rows.Add(Class185.smethod_0(-1141167271));
			List<string> list_3 = Class67.smethod_2(class6.method_18(Class176.smethod_1(Class185.smethod_0(-1141169608), Class185.smethod_0(-1141307890))), Class67.smethod_1(dataGridView4));
			num += smethod_244(Class185.smethod_0(-1141167273), 2, Class388.smethod_4(dataGridView4, list_3, class6));
			num += smethod_244(Class185.smethod_0(-1141167311), Class185.smethod_0(-1141167341), smethod_124(dataGridView5));
			int gparam_6 = class6.method_3();
			num += smethod_244(Class185.smethod_0(-1141167358), 1, Class388.smethod_1(dataGridView5, dataGridView4, class6));
			num += smethod_244(Class185.smethod_0(-1141167389), Class185.smethod_0(-1141167271), smethod_124(dataGridView5));
			num += smethod_244(Class185.smethod_0(-1141167410), Class185.smethod_0(-1141167444), smethod_124(dataGridView4));
			num += smethod_244(Class185.smethod_0(-1141167468), gparam_6, class6.method_3());
			string text10 = Path.Combine(text, Class185.smethod_0(-1141323535));
			smethod_145(text10, Class185.smethod_0(-1141307890), Class185.smethod_0(-1141169608), Class185.smethod_0(-1141286338), new string[1] { Class185.smethod_0(-1141324859) });
			Class67 class7 = new Class67(text10);
			DataGridView dataGridView6 = smethod_138(Class185.smethod_0(-1141286338));
			class7.method_7(dataGridView6, Class185.smethod_0(-1141307890));
			class7.method_8(Class185.smethod_0(-1141169589));
			using (class7.method_17(dataGridView6))
			{
				dataGridView6.Rows.Add(Class185.smethod_0(-1141312985));
			}
			List<string> list_4 = Class67.smethod_2(class7.method_18(Class176.smethod_1(Class185.smethod_0(-1141169608), Class185.smethod_0(-1141307890))), Class67.smethod_1(dataGridView6));
			Class388.smethod_4(dataGridView6, list_4, class7);
			Class67 class8 = new Class67(text10);
			DataGridView dataGridView_ = smethod_138(Class185.smethod_0(-1141286338));
			class8.method_7(dataGridView_, Class185.smethod_0(-1141307890));
			class8.method_8(Class185.smethod_0(-1141169589));
			num += smethod_244(Class185.smethod_0(-1141167500), Class185.smethod_0(-1141322045), smethod_124(dataGridView_));
			Class67 class9 = new Class67(text10);
			DataGridView dataGridView_2 = smethod_138(Class185.smethod_0(-1141286338));
			class9.method_7(dataGridView_2, Class185.smethod_0(-1141307890));
			class9.method_8(Class185.smethod_0(-1141169608));
			num += smethod_244(Class185.smethod_0(-1141167531), Class185.smethod_0(-1141324859), smethod_124(dataGridView_2));
			num += smethod_243(Class185.smethod_0(-1141167564), GForm0.smethod_9(Class185.smethod_0(-1141167607), 0, 0).Contains(Class185.smethod_0(-1141167609)));
			num += smethod_243(Class185.smethod_0(-1141172760), GForm0.smethod_9(Class185.smethod_0(-1141167607), 5, 0).Contains(Class185.smethod_0(-1141172797)));
			string text11 = GForm0.smethod_9(Class185.smethod_0(-1141167607), 5, 2);
			num += smethod_243(Class185.smethod_0(-1141172823), text11.Contains(Class185.smethod_0(-1141172856)));
			num += smethod_243(Class185.smethod_0(-1141172885), text11.Contains(Class185.smethod_0(-1141172920)));
			string text12 = GForm0.smethod_9(Class185.smethod_0(-1141167607), 2, 1);
			num += smethod_243(Class185.smethod_0(-1141172968), text12.Contains(Class185.smethod_0(-1141173000)));
			num += smethod_243(Class185.smethod_0(-1141173020), text12.Contains(Class185.smethod_0(-1141173062)));
			num += smethod_243(Class185.smethod_0(-1141173100), !GForm0.smethod_9(Class185.smethod_0(-1141167607), 2, 2).Contains(Class185.smethod_0(-1141173131)));
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
		Console.WriteLine(Class185.smethod_0(-1141173145) + num + Class185.smethod_0(-1141356690));
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
			JToken obj = JObject.Parse(File.ReadAllText(string_0))[Class185.smethod_0(-1141173162)];
			JArray val = (JArray)(object)((obj is JArray) ? obj : null);
			return (val == null) ? (-1) : ((JContainer)val).Count;
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
		num = 0 + smethod_244(Class185.smethod_0(-1141173181), (Enum12)0, Class61.smethod_0(struct67_, struct139_, Enum0.Started, bool_0: false));
		num += smethod_244(Class185.smethod_0(-1141173212), (Enum12)0, Class61.smethod_0(struct67_, struct139_2, Enum0.Started, bool_0: false));
		num += smethod_244(Class185.smethod_0(-1141172248), (Enum12)0, Class61.smethod_0(struct67_, struct139_, Enum0.Idle, bool_0: true));
		num += smethod_244(Class185.smethod_0(-1141172296), (Enum12)0, Class61.smethod_0(struct67_, struct139_, Enum0.Attached, bool_0: true));
		num += smethod_244(Class185.smethod_0(-1141172340), (Enum12)1, Class61.smethod_0(struct67_, struct139_, Enum0.Selected, bool_0: true));
		num += smethod_244(Class185.smethod_0(-1141172372), (Enum12)1, Class61.smethod_0(struct67_, struct139_, Enum0.Started, bool_0: true));
		num += smethod_244(Class185.smethod_0(-1141172416), (Enum12)2, Class61.smethod_0(struct67_, struct139_2, Enum0.Attached, bool_0: true));
		num += smethod_244(Class185.smethod_0(-1141172449), (Enum12)0, Class61.smethod_0(struct67_, struct139_, Enum0.Attached, bool_0: true));
		num += smethod_244(Class185.smethod_0(-1141172491), (Enum12)2, Class61.smethod_0(struct67_2, struct139_2, Enum0.Started, bool_0: true));
		num += smethod_244(Class185.smethod_0(-1141172521), (Enum12)0, Class61.smethod_0(struct67_2, struct139_, Enum0.Started, bool_0: true));
		num += smethod_244(Class185.smethod_0(-1141172575), (Enum12)0, Class61.smethod_0(struct67_, struct139_2, Enum0.Started, bool_0: true));
		num += smethod_244(Class185.smethod_0(-1141172614), Class185.smethod_0(-1141172630), Class178.smethod_0(1000, 5));
		num += smethod_244(Class185.smethod_0(-1141172681), Class185.smethod_0(-1141172698), Class178.smethod_1());
		Console.WriteLine(Class185.smethod_0(-1141172729) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_148()
	{
		int num = 0;
		num = 0 + smethod_243(Class185.smethod_0(-1141173773), Class357.smethod_15(smethod_230(Class357.valueTuple_0), out var string_));
		num += smethod_243(Class185.smethod_0(-1141173814), Class357.smethod_22());
		num += smethod_243(Class185.smethod_0(-1141173864), !Class357.smethod_46());
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141173899), text.Contains(Class185.smethod_0(-1141173937)));
		num += smethod_243(Class185.smethod_0(-1141173962), !text.Contains(Class185.smethod_0(-1141174005)));
		num += smethod_243(Class185.smethod_0(-1141174032), !text.Contains(Class185.smethod_0(-1141174072)));
		List<(string, string)> list = new List<(string, string)>(Class357.valueTuple_0) { Class357.valueTuple_12[0] };
		num += smethod_243(Class185.smethod_0(-1141174099), Class357.smethod_15(smethod_230(list.ToArray()), out string_));
		num += smethod_243(Class185.smethod_0(-1141174139), Class357.smethod_22());
		num += smethod_243(Class185.smethod_0(-1141174188), !Class357.smethod_46());
		text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141174232), !text.Contains(Class185.smethod_0(-1141174005)) && !text.Contains(Class185.smethod_0(-1141174072)));
		List<(string, string)> list2 = new List<(string, string)>(Class357.valueTuple_0);
		list2.AddRange(Class357.valueTuple_12);
		num += smethod_243(Class185.smethod_0(-1141173255), Class357.smethod_15(smethod_230(list2.ToArray()), out string_));
		num += smethod_243(Class185.smethod_0(-1141173284), Class357.smethod_22());
		num += smethod_243(Class185.smethod_0(-1141173323), Class357.smethod_46());
		text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141173373), text.Contains(Class185.smethod_0(-1141174005)));
		num += smethod_243(Class185.smethod_0(-1141173402), text.Contains(Class185.smethod_0(-1141174072)));
		(string, string)[] valueTuple_ = Class357.valueTuple_12;
		for (int i = 0; i < valueTuple_.Length; i++)
		{
			(string, string) tuple = valueTuple_[i];
			(string, string)[] valueTuple_2 = Class357.valueTuple_0;
			for (int j = 0; j < valueTuple_2.Length; j++)
			{
				(string, string) tuple2 = valueTuple_2[j];
				num += smethod_243(Class185.smethod_0(-1141173444) + tuple.Item1 + Class185.smethod_0(-1141173459), tuple2.Item1 != tuple.Item1);
			}
		}
		Console.WriteLine(Class185.smethod_0(-1141173484) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_149()
	{
		int num = 0;
		num = 0 + smethod_243(Class185.smethod_0(-1141173500), Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out var _));
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141173542), text.Contains(Class185.smethod_0(-1141173584) + 844 + Class185.smethod_0(-1141326297)));
		string text2 = smethod_174(ref num);
		if (text2 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141173605), text2.Contains(Class185.smethod_0(-1141173655)));
			num += smethod_243(Class185.smethod_0(-1141173667), text2.Contains(Class185.smethod_0(-1141173719)));
		}
		byte[] array = new byte[80];
		array[60] = 1;
		array[61] = 6;
		array[62] = byte.MaxValue;
		array[63] = byte.MaxValue;
		array[64] = 44;
		array[65] = 1;
		Class83 @class = Class83.smethod_1(array);
		num += smethod_243(Class185.smethod_0(-1141170701), @class != null);
		if (@class != null)
		{
			num += smethod_244(Class185.smethod_0(-1141170723), (byte)6, @class.byte_5);
			num += smethod_244(Class185.smethod_0(-1141170766), (byte)1, @class.byte_4);
			num += smethod_244(Class185.smethod_0(-1141170807), (ushort)300, @class.ushort_0);
		}
		array[61] = 0;
		Class83 class2 = Class83.smethod_1(array);
		num += smethod_243(Class185.smethod_0(-1141170833), class2 != null && class2.byte_5 == 0);
		Console.WriteLine(Class185.smethod_0(-1141170879) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_150()
	{
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected O, but got Unknown
		int num = 0;
		List<(string, string)> list = new List<(string, string)>(Class357.valueTuple_13);
		list.AddRange(Class357.valueTuple_14);
		num = 0 + smethod_243(Class185.smethod_0(-1141170895), Class357.smethod_15(smethod_230(list.ToArray()), out var string_));
		num += smethod_243(Class185.smethod_0(-1141170929), Class357.smethod_48());
		num += smethod_243(Class185.smethod_0(-1141170963), Class357.smethod_50());
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141171005), text.Contains(Class185.smethod_0(-1141171054)));
		num += smethod_243(Class185.smethod_0(-1141171080), text.Contains(Class185.smethod_0(-1141171128)));
		num += smethod_243(Class185.smethod_0(-1141171145), text.Contains(Class185.smethod_0(-1141171195) + 184 + Class185.smethod_0(-1141326297)));
		num += smethod_243(Class185.smethod_0(-1141170206), text.Contains(Class185.smethod_0(-1141170263)));
		num += smethod_243(Class185.smethod_0(-1141170285), Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out string_));
		string text2 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141170326), !text2.Contains(Class185.smethod_0(-1141170364)));
		num += smethod_243(Class185.smethod_0(-1141170388), !text2.Contains(Class185.smethod_0(-1141171195)));
		string text3 = smethod_174(ref num);
		if (text3 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141170456), text3.Contains(Class185.smethod_0(-1141170510)));
			num += smethod_243(Class185.smethod_0(-1141170529), text3.Contains(Class185.smethod_0(-1141170600)));
		}
		IReadOnlyList<GStruct3> readOnlyList = Class119.smethod_30(JObject.Parse(Class185.smethod_0(-1141170620)));
		num += smethod_243(Class185.smethod_0(-1141171839), readOnlyList != null);
		if (readOnlyList != null)
		{
			num += smethod_244(Class185.smethod_0(-1141171860), 2, readOnlyList.Count);
		}
		if (readOnlyList != null && readOnlyList.Count == 2)
		{
			GStruct3 gStruct = readOnlyList[0];
			num += smethod_244(Class185.smethod_0(-1141171904), gparam_0: false, gStruct.bool_0);
			num += smethod_244(Class185.smethod_0(-1141171932), 3, gStruct.int_0);
			num += smethod_244(Class185.smethod_0(-1141171967), (ushort)27, gStruct.ushort_0);
			num += smethod_244(Class185.smethod_0(-1141171986), (ushort)4, gStruct.ushort_1);
			num += smethod_244(Class185.smethod_0(-1141172012), 9, gStruct.int_1);
			num += smethod_244(Class185.smethod_0(-1141172048), 123.5f, gStruct.float_0);
			GStruct3 gStruct2 = readOnlyList[1];
			num += smethod_244(Class185.smethod_0(-1141172067), gparam_0: true, gStruct2.bool_0);
			num += smethod_244(Class185.smethod_0(-1141172100), 1, gStruct2.int_0);
			num += smethod_244(Class185.smethod_0(-1141172136), (ushort)900, gStruct2.ushort_0);
			num += smethod_244(Class185.smethod_0(-1141172156), (ushort)2, gStruct2.ushort_1);
			num += smethod_244(Class185.smethod_0(-1141172191), 1, gStruct2.int_1);
			num += smethod_244(Class185.smethod_0(-1141172212), 0f, gStruct2.float_0);
		}
		IReadOnlyList<GStruct3> readOnlyList2 = Class119.smethod_30(JObject.Parse(Class185.smethod_0(-1141171224)));
		num += smethod_243(Class185.smethod_0(-1141171235), readOnlyList2 != null && readOnlyList2.Count == 0);
		num += smethod_243(Class185.smethod_0(-1141171275), Class119.smethod_30(new JObject()) == null);
		Class145 @class = Class145.class145_0.method_95(null, null, readOnlyList, default(GStruct4), 1, 0);
		num += smethod_244(Class185.smethod_0(-1141171314), 2, @class.method_12().Count);
		num += smethod_244(Class185.smethod_0(-1141171354), 0, Class145.class145_0.method_12().Count);
		if (text3 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141171395), text3.Contains(Class185.smethod_0(-1141171444)) && text3.Contains(Class185.smethod_0(-1141171498)));
		}
		GStruct4 gstruct4_ = Class119.smethod_37(JObject.Parse(Class185.smethod_0(-1141171528)));
		num += smethod_244(Class185.smethod_0(-1141171571), (byte)6, gstruct4_.byte_0);
		num += smethod_244(Class185.smethod_0(-1141171605), 600f, gstruct4_.float_0);
		num += smethod_244(Class185.smethod_0(-1141171632), 552.5f, gstruct4_.float_1);
		GStruct4 gStruct3 = Class119.smethod_37(JObject.Parse(Class185.smethod_0(-1141171650)));
		num += smethod_244(Class185.smethod_0(-1141171699), (byte)13, gStruct3.byte_0);
		num += smethod_244(Class185.smethod_0(-1141176850), -1f, gStruct3.float_1);
		GStruct4 gStruct4 = Class119.smethod_37(new JObject());
		num += smethod_244(Class185.smethod_0(-1141176889), (byte)0, gStruct4.byte_0);
		num += smethod_244(Class185.smethod_0(-1141176923), -1f, gStruct4.float_1);
		Class145 class2 = Class145.class145_0.method_95(null, null, null, gstruct4_, 1, 0);
		num += smethod_244(Class185.smethod_0(-1141176968), (byte)6, class2.method_22().byte_0);
		num += smethod_244(Class185.smethod_0(-1141177003), -1f, Class145.class145_0.method_22().float_1);
		if (text3 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141177056), text3.Contains(Class185.smethod_0(-1141177090)));
			num += smethod_243(Class185.smethod_0(-1141177113), text3.Contains(Class185.smethod_0(-1141177176)));
		}
		(ushort, ushort)[] array = Class119.smethod_38(JObject.Parse(Class185.smethod_0(-1141177194)));
		num += smethod_243(Class185.smethod_0(-1141177328), array != null && array.Length == 10);
		if (array != null && array.Length == 10)
		{
			num += smethod_244(Class185.smethod_0(-1141176335), (ushort)27, array[0].Item1);
			num += smethod_244(Class185.smethod_0(-1141176367), (ushort)4, array[0].Item2);
			num += smethod_244(Class185.smethod_0(-1141176398), ushort.MaxValue, array[1].Item1);
			num += smethod_244(Class185.smethod_0(-1141176431), (ushort)2, array[9].Item2);
		}
		num += smethod_243(Class185.smethod_0(-1141176463), Class119.smethod_38(JObject.Parse(Class185.smethod_0(-1141176503))) == null);
		num += smethod_243(Class185.smethod_0(-1141176589), Class119.smethod_38(JObject.Parse(Class185.smethod_0(-1141176629))) == null);
		num += smethod_243(Class185.smethod_0(-1141176717), Class119.smethod_38(JObject.Parse(Class185.smethod_0(-1141176767))) == null);
		num += smethod_244(Class185.smethod_0(-1141177876), Class185.smethod_0(-1141177908), Class454.smethod_4(3));
		if (text3 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141177946), text3.Contains(Class185.smethod_0(-1141178007)));
			num += smethod_243(Class185.smethod_0(-1141178027), text3.Contains(Class185.smethod_0(-1141178088)));
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
		(string, Color) tuple = Class91.smethod_3(bool_0: true, array2, 1, list2, Class185.smethod_0(-1141178098));
		num += smethod_244(Class185.smethod_0(-1141178107), Class185.smethod_0(-1141178152), tuple.Item1);
		num += smethod_244(Class185.smethod_0(-1141178156), Class91.color_0, tuple.Item2);
		(string, Color) tuple2 = Class91.smethod_3(bool_0: true, array2, 1, list2, Class185.smethod_0(-1141277093));
		num += smethod_244(Class185.smethod_0(-1141178205), Class91.color_1, tuple2.Item2);
		(string, Color) tuple3 = Class91.smethod_3(bool_0: true, array2, 3, list2, Class185.smethod_0(-1141305630));
		num += smethod_244(Class185.smethod_0(-1141178233), Class185.smethod_0(-1141274464), tuple3.Item1);
		num += smethod_244(Class185.smethod_0(-1141178272), Class91.color_1, tuple3.Item2);
		(string, Color) tuple4 = Class91.smethod_3(bool_0: false, array2, 1, list2, Class185.smethod_0(-1141305630));
		num += smethod_244(Class185.smethod_0(-1141178297), Class185.smethod_0(-1141296459), tuple4.Item1);
		num += smethod_244(Class185.smethod_0(-1141178336), Color.Empty, tuple4.Item2);
		(string, Color) tuple5 = Class91.smethod_3(bool_0: true, null, 1, list2, Class185.smethod_0(-1141305630));
		num += smethod_244(Class185.smethod_0(-1141178367), Class185.smethod_0(-1141296459), tuple5.Item1);
		num += smethod_244(Class185.smethod_0(-1141177376), Color.Empty, tuple5.Item2);
		(string, Color) tuple6 = Class91.smethod_3(bool_0: true, array2, 2, list2, Class185.smethod_0(-1141305630));
		num += smethod_244(Class185.smethod_0(-1141177401), Class185.smethod_0(-1141296459), tuple6.Item1);
		num += smethod_244(Class185.smethod_0(-1141177433), Color.Empty, tuple6.Item2);
		(string, Color) tuple7 = Class91.smethod_3(bool_0: true, array2, 4, list2, string.Empty);
		num += smethod_244(Class185.smethod_0(-1141177465), Class185.smethod_0(-1141177502), tuple7.Item1);
		num += smethod_244(Class185.smethod_0(-1141177505), Class91.color_0, tuple7.Item2);
		(string, Color) tuple8 = Class91.smethod_3(bool_0: true, array2, 4, list2, Class185.smethod_0(-1141163021));
		num += smethod_244(Class185.smethod_0(-1141177557), Class91.color_0, tuple8.Item2);
		(string, Color) tuple9 = Class91.smethod_3(bool_0: true, array2, 8, list2, Class185.smethod_0(-1141305630));
		num += smethod_244(Class185.smethod_0(-1141177607), Class185.smethod_0(-1141296459), tuple9.Item1);
		num += smethod_244(Class185.smethod_0(-1141177642), 7, 7);
		for (int j = 1; j <= 7; j++)
		{
			int num2 = Class91.smethod_2(j);
			num += smethod_243(Class185.smethod_0(-1141177686) + j + Class185.smethod_0(-1141177700), num2 != 30 && num2 != 31 && num2 != 32);
		}
		num += smethod_244(Class185.smethod_0(-1141177731), 16, Class91.smethod_0(1));
		num += smethod_244(Class185.smethod_0(-1141177763), 22, Class91.smethod_0(7));
		num += smethod_244(Class185.smethod_0(-1141177795), 26, Class91.smethod_1(1));
		num += smethod_244(Class185.smethod_0(-1141177840), 31, Class91.smethod_1(6));
		num += smethod_244(Class185.smethod_0(-1141174805), 20, Class91.smethod_1(7));
		num += smethod_244(Class185.smethod_0(-1141174834), 14, Class91.smethod_2(1));
		num += smethod_244(Class185.smethod_0(-1141174871), 19, Class91.smethod_2(6));
		num += smethod_244(Class185.smethod_0(-1141174892), 29, Class91.smethod_2(7));
		num += smethod_244(Class185.smethod_0(-1141174921), Class185.smethod_0(-1141306264), Class91.smethod_4(new GStruct4
		{
			byte_0 = 0,
			float_0 = 0f,
			float_1 = -1f
		}));
		num += smethod_244(Class185.smethod_0(-1141174959), Class185.smethod_0(-1141174990), Class91.smethod_4(new GStruct4
		{
			byte_0 = 6,
			float_0 = 600f,
			float_1 = 552.6f
		}));
		num += smethod_243(Class185.smethod_0(-1141175019), Class91.smethod_4(new GStruct4
		{
			byte_0 = 13,
			float_0 = 300f,
			float_1 = -1f
		}).EndsWith(Class185.smethod_0(-1141175057), StringComparison.Ordinal));
		num += smethod_243(Class185.smethod_0(-1141175073), Class91.smethod_4(new GStruct4
		{
			byte_0 = 99,
			float_0 = 30f,
			float_1 = 30f
		}).EndsWith(Class185.smethod_0(-1141175119), StringComparison.Ordinal));
		num += smethod_243(Class185.smethod_0(-1141175131), Class91.smethod_6(-1L, 0L));
		num += smethod_243(Class185.smethod_0(-1141175177), !Class91.smethod_6(1000L, 10999L));
		num += smethod_243(Class185.smethod_0(-1141175229), Class91.smethod_6(1000L, 11000L));
		Console.WriteLine(Class185.smethod_0(-1141175257) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_151()
	{
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected O, but got Unknown
		int num = 0;
		num = 0 + smethod_243(Class185.smethod_0(-1141175275), Class357.smethod_15(smethod_230(Class357.valueTuple_15), out var string_));
		num += smethod_243(Class185.smethod_0(-1141174282), Class357.smethod_52());
		num += smethod_243(Class185.smethod_0(-1141174320), !Class357.smethod_36());
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141174348), text.Contains(Class185.smethod_0(-1141174406)));
		num += smethod_243(Class185.smethod_0(-1141174428), text.Contains(Class185.smethod_0(-1141171195) + 184 + Class185.smethod_0(-1141326297)));
		num += smethod_243(Class185.smethod_0(-1141174475), text.Contains(Class185.smethod_0(-1141174516) + 44 + Class185.smethod_0(-1141326297)));
		num += smethod_243(Class185.smethod_0(-1141174537), text.Contains(Class185.smethod_0(-1141174580) + 332 + Class185.smethod_0(-1141326297)));
		num += smethod_243(Class185.smethod_0(-1141174603), text.Contains(Class185.smethod_0(-1141174641) + 48 + Class185.smethod_0(-1141174659)));
		num += smethod_243(Class185.smethod_0(-1141174667), Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out string_));
		string text2 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141174705), !text2.Contains(Class185.smethod_0(-1141174759)));
		num += smethod_243(Class185.smethod_0(-1141174779), !text2.Contains(Class185.smethod_0(-1141174516)));
		string text3 = smethod_174(ref num);
		if (text3 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141175851), text3.Contains(Class185.smethod_0(-1141175925)));
		}
		Class74 @class = Class119.smethod_53(JObject.Parse(Class185.smethod_0(-1141175952)));
		num += smethod_244(Class185.smethod_0(-1141176035), 2, @class.int_0);
		num += smethod_244(Class185.smethod_0(-1141176064), Class185.smethod_0(-1141303993), @class.string_0);
		num += smethod_244(Class185.smethod_0(-1141176087), 0, @class.int_1);
		num += smethod_244(Class185.smethod_0(-1141176100), 1312, @class.int_2);
		num += smethod_243(Class185.smethod_0(-1141176123), !@class.bool_0);
		num += smethod_244(Class185.smethod_0(-1141176153), string.Empty, @class.string_1);
		Class74 class2 = Class119.smethod_53(JObject.Parse(Class185.smethod_0(-1141176181)));
		num += smethod_244(Class185.smethod_0(-1141176265), Class185.smethod_0(-1141254478), class2.string_0);
		num += smethod_244(Class185.smethod_0(-1141176290), 1, class2.int_1);
		num += smethod_243(Class185.smethod_0(-1141176313), class2.bool_0);
		string[] array = new string[4]
		{
			Class185.smethod_0(-1141175325),
			Class185.smethod_0(-1141175336),
			Class185.smethod_0(-1141253360),
			Class185.smethod_0(-1141175351)
		};
		for (int i = 0; i < array.Length; i++)
		{
			Class74 class3 = Class119.smethod_53(JObject.Parse(Class185.smethod_0(-1141175361) + array[i] + Class185.smethod_0(-1141175404)));
			num += smethod_244(Class185.smethod_0(-1141175437) + array[i] + Class185.smethod_0(-1141175443), array[i], class3.string_0);
			num += smethod_244(Class185.smethod_0(-1141175437) + array[i] + Class185.smethod_0(-1141175457), Class185.smethod_0(-1141175468), class3.string_1);
			num += smethod_244(Class185.smethod_0(-1141175437) + array[i] + Class185.smethod_0(-1141175482), -1, class3.int_1);
			num += smethod_244(Class185.smethod_0(-1141175437) + array[i] + Class185.smethod_0(-1141175509), -1, class3.int_2);
			num += smethod_243(Class185.smethod_0(-1141175437) + array[i] + Class185.smethod_0(-1141175522), !class3.bool_0);
		}
		Class74 class4 = Class119.smethod_53(JObject.Parse(Class185.smethod_0(-1141175551)));
		num += smethod_244(Class185.smethod_0(-1141175614), Class185.smethod_0(-1141175636), class4.string_0);
		num += smethod_244(Class185.smethod_0(-1141175652), 3, class4.int_1);
		Class74 class5 = Class119.smethod_53(JObject.Parse(Class185.smethod_0(-1141175688)));
		num += smethod_244(Class185.smethod_0(-1141175749), Class185.smethod_0(-1141273605), class5.string_0);
		num += smethod_244(Class185.smethod_0(-1141175769), 2, class5.int_1);
		Class74 class6 = Class119.smethod_53(new JObject());
		num += smethod_244(Class185.smethod_0(-1141175795), 0, class6.int_0);
		num += smethod_244(Class185.smethod_0(-1141148177), string.Empty, class6.string_0);
		num += smethod_244(Class185.smethod_0(-1141148209), -1, class6.int_1);
		Class74 class7 = Class119.smethod_53(JObject.Parse(Class185.smethod_0(-1141148247)));
		num += smethod_244(Class185.smethod_0(-1141148326), -1, class7.int_1);
		num += smethod_244(Class185.smethod_0(-1141148358), -1, class7.int_2);
		num += smethod_244(Class185.smethod_0(-1141148392), Class185.smethod_0(-1141148423), Class454.smethod_5(4, 27, 5));
		if (text3 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141148468), text3.Contains(Class185.smethod_0(-1141148514)));
			num += smethod_243(Class185.smethod_0(-1141148538), text3.Contains(Class185.smethod_0(-1141148606)));
			num += smethod_243(Class185.smethod_0(-1141148618), text3.Contains(Class185.smethod_0(-1141148668)));
			num += smethod_243(Class185.smethod_0(-1141147676), text3.Contains(Class185.smethod_0(-1141147734)));
			num += smethod_243(Class185.smethod_0(-1141147752), text3.Contains(Class185.smethod_0(-1141147805)));
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
			array4[k] = Class185.smethod_0(-1141276741);
		}
		array4[8] = Class185.smethod_0(-1141306701);
		List<GStruct3> list = new List<GStruct3>();
		Class342.smethod_2();
		array3[2] = true;
		array3[3] = true;
		bool flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out var int_);
		num += smethod_243(Class185.smethod_0(-1141147831), !flag);
		num += smethod_244(Class185.smethod_0(-1141147865), 2, int_);
		num += smethod_244(Class185.smethod_0(-1141147910), 1, Class342.smethod_5());
		flag = Class342.smethod_24(100L, bool_1: false, array2, smethod_227(array2, 100L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141147941), !flag);
		num += smethod_244(Class185.smethod_0(-1141147984), 0, int_);
		MethodInfo methodInfo = null;
		MethodInfo methodInfo2 = null;
		MethodInfo[] methods = typeof(Class342).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
		for (int l = 0; l < methods.Length; l++)
		{
			ParameterInfo[] parameters = methods[l].GetParameters();
			if (methods[l].Name == Class185.smethod_0(-1141148011) && parameters.Length == 9 && parameters[8].ParameterType == typeof(bool))
			{
				methodInfo = methods[l];
			}
			if (methods[l].Name == Class185.smethod_0(-1141148030) && parameters.Length == 4)
			{
				methodInfo2 = methods[l];
			}
		}
		num += smethod_243(Class185.smethod_0(-1141148033), methodInfo != null);
		num += smethod_243(Class185.smethod_0(-1141148083), methodInfo2 != null);
		if (methodInfo != null && methodInfo2 != null)
		{
			Class342.smethod_2();
			bool[] array5 = new bool[9] { false, false, true, false, false, false, false, false, false };
			string[] array6 = new string[9];
			for (int m = 1; m <= 7; m++)
			{
				array6[m] = Class185.smethod_0(-1141276741);
			}
			array6[8] = Class185.smethod_0(-1141306701);
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
			num += smethod_243(Class185.smethod_0(-1141148134), !flag2 && num2 == 2 && Class342.smethod_5() == 0);
			ushort item = array2[num2 - 1].Item1;
			ushort item2 = array2[num2 - 1].Item2;
			(ushort, ushort)[] array8 = new(ushort, ushort)[array2.Length];
			Array.Copy(array2, array8, array2.Length);
			array8[num2 - 1] = (99, 99);
			methodInfo2.Invoke(null, new object[4] { num2, item, item2, 0L });
			num += smethod_244(Class185.smethod_0(-1141149197), 1, Class342.smethod_5());
			Class342.smethod_0(new Class74
			{
				int_0 = num2,
				string_0 = Class185.smethod_0(-1141303993),
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
			num += smethod_244(Class185.smethod_0(-1141149246), 0, Class342.smethod_5());
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
		num += smethod_243(Class185.smethod_0(-1141149299), !Class342.smethod_28(bool_1: true, array2, 1, list, Class185.smethod_0(-1141276741), 0L, 0L));
		num += smethod_243(Class185.smethod_0(-1141149344), Class342.smethod_28(bool_1: true, array2, 2, list, Class185.smethod_0(-1141276741), 0L, 0L));
		num += smethod_243(Class185.smethod_0(-1141149371), Class342.smethod_28(bool_1: true, array2, 4, list, Class185.smethod_0(-1141276741), 0L, 0L));
		num += smethod_243(Class185.smethod_0(-1141149405), Class342.smethod_28(bool_1: true, array2, 3, list, Class185.smethod_0(-1141276741), 0L, 0L));
		num += smethod_243(Class185.smethod_0(-1141149436), !Class342.smethod_28(bool_1: false, array2, 4, list, Class185.smethod_0(-1141276741), 0L, 0L));
		num += smethod_243(Class185.smethod_0(-1141149467), !Class342.smethod_28(bool_1: true, null, 4, list, Class185.smethod_0(-1141276741), 0L, 0L));
		num += smethod_243(Class185.smethod_0(-1141149500), !Class342.smethod_28(bool_1: true, array2, 5, list, Class185.smethod_0(-1141276741), 0L, 0L));
		num += smethod_243(Class185.smethod_0(-1141149532), !Class342.smethod_28(bool_1: true, array2, 4, list, Class185.smethod_0(-1141276741), 1000L, 999L));
		num += smethod_243(Class185.smethod_0(-1141149563), Class342.smethod_28(bool_1: true, array2, 4, list, Class185.smethod_0(-1141276741), 1000L, 1000L));
		num += smethod_243(Class185.smethod_0(-1141149606), !Class342.smethod_28(bool_1: true, array2, 8, list, Class185.smethod_0(-1141276741), 0L, 0L));
		num += smethod_244(Class185.smethod_0(-1141149642), 0, Class342.smethod_33(string.Empty));
		num += smethod_244(Class185.smethod_0(-1141149678), 0, Class342.smethod_33(null));
		num += smethod_244(Class185.smethod_0(-1141148673), 0, Class342.smethod_33(Class185.smethod_0(-1141163021)));
		num += smethod_244(Class185.smethod_0(-1141148707), 15, Class342.smethod_33(Class185.smethod_0(-1141148738)));
		num += smethod_243(Class185.smethod_0(-1141148757), !Class342.smethod_28(bool_1: true, array2, 1, list, Class185.smethod_0(-1141163021), 0L, 0L));
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
		num += smethod_243(Class185.smethod_0(-1141148795), Class342.smethod_28(bool_1: true, array2, 1, ireadOnlyList_2, string.Empty, 0L, 0L));
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: true, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141148841), flag);
		num += smethod_244(Class185.smethod_0(-1141148888), 0, int_);
		num += smethod_244(Class185.smethod_0(-1141148920), 0, Class342.smethod_5());
		flag = Class342.smethod_24(0L, bool_1: false, null, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141148949), flag && int_ == 0);
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), null, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141148987), flag && int_ == 0);
		string[] array9 = new string[4]
		{
			Class185.smethod_0(-1141175636),
			Class185.smethod_0(-1141273605),
			Class185.smethod_0(-1141175336),
			Class185.smethod_0(-1141253360)
		};
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
				string_1 = Class185.smethod_0(-1141149035)
			});
			flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
			num += smethod_244(Class185.smethod_0(-1141175437) + array9[n] + Class185.smethod_0(-1141149054), 0, Class342.smethod_5());
			flag = Class342.smethod_24(1299L, bool_1: false, array2, smethod_227(array2, 1299L), list, array3, array4, out int_);
			num += smethod_243(Class185.smethod_0(-1141175437) + array9[n] + Class185.smethod_0(-1141149071), flag && int_ == 0);
			flag = Class342.smethod_24(1300L, bool_1: false, array2, smethod_227(array2, 1300L), list, array3, array4, out int_);
			num += smethod_244(Class185.smethod_0(-1141175437) + array9[n] + Class185.smethod_0(-1141149092), 3, int_);
		}
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		Class342.smethod_0(new Class74
		{
			int_0 = int_,
			string_0 = Class185.smethod_0(-1141175325),
			int_1 = -1,
			int_2 = -1,
			string_1 = Class185.smethod_0(-1141149035)
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141149142), 0, Class342.smethod_5());
		flag = Class342.smethod_24(1299L, bool_1: false, array2, smethod_227(array2, 1299L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141149162), flag && int_ == 0);
		flag = Class342.smethod_24(1300L, bool_1: false, array2, smethod_227(array2, 1300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141146130), 2, int_);
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		flag = Class342.smethod_24(6999L, bool_1: false, array2, smethod_227(array2, 6999L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141146188), 1, Class342.smethod_5());
		flag = Class342.smethod_24(7000L, bool_1: false, array2, smethod_227(array2, 7000L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141146219), 0, Class342.smethod_5());
		flag = Class342.smethod_24(7300L, bool_1: false, array2, smethod_227(array2, 7300L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141146258), flag && int_ == 0);
		flag = Class342.smethod_24(8000L, bool_1: false, array2, smethod_227(array2, 8000L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141146317), 3, int_);
		array3[2] = false;
		array3[3] = false;
		array3[8] = true;
		Class342.smethod_2();
		flag = Class342.smethod_24(1000L, bool_1: false, array2, smethod_227(array2, 1000L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141146353), 8, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 8,
			string_0 = Class185.smethod_0(-1141303993),
			int_1 = 0,
			int_2 = 1300,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(1000L, bool_1: false, array2, smethod_227(array2, 1000L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141146400), 0, Class342.smethod_5());
		num += smethod_244(Class185.smethod_0(-1141146440), 1000L, Class342.smethod_6());
		flag = Class342.smethod_24(60999L, bool_1: false, array2, smethod_227(array2, 60999L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141146485), flag && int_ == 0);
		flag = Class342.smethod_24(61000L, bool_1: false, array2, smethod_227(array2, 61000L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141146514), 8, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 8,
			string_0 = Class185.smethod_0(-1141175636),
			int_1 = 3,
			int_2 = -1,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(61300L, bool_1: false, array2, smethod_227(array2, 61300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141146551), 1000L, Class342.smethod_6());
		flag = Class342.smethod_24(62300L, bool_1: false, array2, smethod_227(array2, 62300L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141146599), flag && int_ == 0);
		flag = Class342.smethod_24(66300L, bool_1: false, array2, smethod_227(array2, 66300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141145625), 8, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 8,
			string_0 = Class185.smethod_0(-1141254478),
			int_1 = 1,
			int_2 = 2100,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(66600L, bool_1: false, array2, smethod_227(array2, 66600L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141145680), 66600L, Class342.smethod_6());
		(ushort, ushort)[] array10 = new(ushort, ushort)[10];
		for (int num3 = 0; num3 < array10.Length; num3++)
		{
			array10[num3] = (ushort.MaxValue, ushort.MaxValue);
		}
		num += smethod_243(Class185.smethod_0(-1141145727), Class342.smethod_30(bool_1: true, array2, Class185.smethod_0(-1141306701), -1L, 0L, 0L));
		num += smethod_243(Class185.smethod_0(-1141145767), !Class342.smethod_30(bool_1: true, array2, Class185.smethod_0(-1141296459), -1L, 0L, 0L));
		num += smethod_243(Class185.smethod_0(-1141145796), !Class342.smethod_30(bool_1: true, array2, Class185.smethod_0(-1141163021), -1L, 0L, 0L));
		num += smethod_243(Class185.smethod_0(-1141145847), !Class342.smethod_30(bool_1: false, array2, Class185.smethod_0(-1141306701), -1L, 0L, 0L));
		num += smethod_243(Class185.smethod_0(-1141145884), !Class342.smethod_30(bool_1: true, null, Class185.smethod_0(-1141306701), -1L, 0L, 0L));
		num += smethod_243(Class185.smethod_0(-1141145931), !Class342.smethod_30(bool_1: true, array10, Class185.smethod_0(-1141306701), -1L, 0L, 0L));
		num += smethod_243(Class185.smethod_0(-1141145979), !Class342.smethod_30(bool_1: true, array2, Class185.smethod_0(-1141306701), -1L, 500L, 0L));
		Class342.smethod_2();
		array3[2] = true;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141146017), 2, int_);
		array3[3] = true;
		array3[8] = false;
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = Class185.smethod_0(-1141303993),
			int_1 = 0,
			int_2 = 1400,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(1500L, bool_1: false, array2, smethod_227(array2, 1500L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141146064), 2, Class342.smethod_5());
		flag = Class342.smethod_24(1800L, bool_1: false, array2, smethod_227(array2, 1800L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141146102), flag && int_ == 0);
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
		num += smethod_244(Class185.smethod_0(-1141147175), 0, Class342.smethod_5());
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = Class185.smethod_0(-1141254478),
			int_1 = 1,
			int_2 = 3000,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141147215), 2, Class342.smethod_5());
		flag = Class342.smethod_24(5299L, bool_1: false, array2, smethod_227(array2, 5299L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141147255), 2, Class342.smethod_5());
		flag = Class342.smethod_24(5300L, bool_1: false, array2, smethod_227(array2, 5300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141147281), 0, Class342.smethod_5());
		flag = Class342.smethod_24(5600L, bool_1: false, array2, smethod_227(array2, 5600L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141147323), flag && int_ == 0);
		flag = Class342.smethod_24(6300L, bool_1: false, array2, smethod_227(array2, 6300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141147377), 3, int_);
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 5,
			string_0 = Class185.smethod_0(-1141303993),
			int_1 = 0,
			int_2 = 1000,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141147432), 1, Class342.smethod_5());
		Class342.smethod_2();
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = Class185.smethod_0(-1141303993),
			int_1 = 0,
			int_2 = 1000,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141147477), 1, Class342.smethod_5());
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = Class185.smethod_0(-1141175351),
			int_1 = -1,
			int_2 = -1,
			string_1 = Class185.smethod_0(-1141147522)
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		flag = Class342.smethod_24(600L, bool_1: false, array2, smethod_227(array2, 600L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141147556), flag && int_ == 0);
		Class342.smethod_2();
		flag = Class342.smethod_24(900L, bool_1: false, array2, smethod_227(array2, 900L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141147595), 2, int_);
		Class342.smethod_2();
		(string, Color) tuple = Class91.smethod_11(bool_0: true, 1000L, 11500L, Class185.smethod_0(-1141306701));
		num += smethod_244(Class185.smethod_0(-1141147635), Class185.smethod_0(-1141146644), tuple.Item1);
		num += smethod_244(Class185.smethod_0(-1141146664), Class91.color_0, tuple.Item2);
		(string, Color) tuple2 = Class91.smethod_11(bool_0: true, 1000L, 61000L, Class185.smethod_0(-1141306701));
		num += smethod_244(Class185.smethod_0(-1141146703), Class185.smethod_0(-1141274464), tuple2.Item1);
		num += smethod_244(Class185.smethod_0(-1141146721), Class91.color_1, tuple2.Item2);
		(string, Color) tuple3 = Class91.smethod_11(bool_0: true, 1000L, 70000L, Class185.smethod_0(-1141306701));
		num += smethod_244(Class185.smethod_0(-1141146754), Class185.smethod_0(-1141274464), tuple3.Item1);
		num += smethod_244(Class185.smethod_0(-1141146795), Class91.color_1, tuple3.Item2);
		(string, Color) tuple4 = Class91.smethod_11(bool_0: true, -1L, 5000L, Class185.smethod_0(-1141306701));
		num += smethod_244(Class185.smethod_0(-1141146840), Class185.smethod_0(-1141274464), tuple4.Item1);
		num += smethod_244(Class185.smethod_0(-1141146872), Class91.color_1, tuple4.Item2);
		(string, Color) tuple5 = Class91.smethod_11(bool_0: false, 1000L, 11500L, Class185.smethod_0(-1141306701));
		num += smethod_244(Class185.smethod_0(-1141146911), Class185.smethod_0(-1141296459), tuple5.Item1);
		num += smethod_244(Class185.smethod_0(-1141146939), Color.Empty, tuple5.Item2);
		(string, Color) tuple6 = Class91.smethod_11(bool_0: true, 1000L, 1000L, Class185.smethod_0(-1141163021));
		num += smethod_244(Class185.smethod_0(-1141146983), Class185.smethod_0(-1141274464), tuple6.Item1);
		num += smethod_244(Class185.smethod_0(-1141147024), Class91.color_1, tuple6.Item2);
		num += smethod_244(Class185.smethod_0(-1141147052), 30, 30);
		num += smethod_244(Class185.smethod_0(-1141147088), 23, Class91.smethod_0(8));
		num += smethod_244(Class185.smethod_0(-1141147117), 21, 21);
		Class342.smethod_2();
		for (int num4 = 1; num4 <= 8; num4++)
		{
			array3[num4] = false;
		}
		array3[2] = true;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141152270), 2, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = Class185.smethod_0(-1141175636),
			int_1 = 3,
			int_2 = -1,
			string_1 = Class185.smethod_0(-1141149035)
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141152290), 0, Class342.smethod_5());
		flag = Class342.smethod_24(5200L, bool_1: false, array2, smethod_227(array2, 5200L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141152334), flag && int_ == 0);
		flag = Class342.smethod_24(5300L, bool_1: false, array2, smethod_227(array2, 5300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141152370), 2, int_);
		Class342.smethod_2();
		for (int num5 = 1; num5 <= 8; num5++)
		{
			array3[num5] = false;
		}
		array3[2] = true;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141152401), 2, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = Class185.smethod_0(-1141175325),
			int_1 = -1,
			int_2 = -1,
			string_1 = Class185.smethod_0(-1141149035)
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141152437), 0, Class342.smethod_5());
		flag = Class342.smethod_24(1200L, bool_1: false, array2, smethod_227(array2, 1200L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141152460), flag && int_ == 0);
		flag = Class342.smethod_24(1300L, bool_1: false, array2, smethod_227(array2, 1300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141152512), 2, int_);
		Class342.smethod_2();
		for (int num6 = 1; num6 <= 8; num6++)
		{
			array3[num6] = false;
		}
		array3[2] = true;
		array3[3] = true;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141152543), 2, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = Class185.smethod_0(-1141273605),
			int_1 = 2,
			int_2 = -1,
			string_1 = Class185.smethod_0(-1141149035)
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141152569), 0, Class342.smethod_5());
		flag = Class342.smethod_24(999L, bool_1: false, array2, smethod_227(array2, 999L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141152603), flag && int_ == 0);
		flag = Class342.smethod_24(1299L, bool_1: false, array2, smethod_227(array2, 1299L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141152650), flag && int_ == 0);
		flag = Class342.smethod_24(1300L, bool_1: false, array2, smethod_227(array2, 1300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141152712), 3, int_);
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
					string_0 = Class185.smethod_0(-1141175636),
					int_1 = 3,
					int_2 = -1,
					string_1 = Class185.smethod_0(-1141149035)
				});
			}
			num8 += 300L;
		}
		num += smethod_243(Class185.smethod_0(-1141152759), num9 * 3 >= 30);
		Class342.smethod_2();
		for (int num11 = 1; num11 <= 8; num11++)
		{
			array3[num11] = false;
		}
		array3[2] = true;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141151793), 2, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = Class185.smethod_0(-1141175636),
			int_1 = 3,
			int_2 = -1,
			string_1 = Class185.smethod_0(-1141149035)
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141151829), 0, Class342.smethod_5());
		flag = Class342.smethod_24(600L, bool_1: false, array2, smethod_227(array2, 600L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141151857), flag && int_ == 0);
		Class342.smethod_2();
		flag = Class342.smethod_24(600L, bool_1: false, array2, smethod_227(array2, 600L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141151908), 2, int_);
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
		num += smethod_244(Class185.smethod_0(-1141151989), 2, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = Class185.smethod_0(-1141303993),
			int_1 = 0,
			int_2 = 1400,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141152011), !flag && int_ == 0);
		num += smethod_244(Class185.smethod_0(-1141152088), 2, Class342.smethod_5());
		flag = Class342.smethod_24(600L, bool_1: false, array2, smethod_227(array2, 600L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141152115), flag && int_ == 0);
		int num13 = 0;
		for (long num14 = 900L; num14 < 5100L; num14 += 300L)
		{
			flag = Class342.smethod_24(num14, bool_1: false, array2, smethod_227(array2, num14), ireadOnlyList_5, array3, array4, out int_);
			if (int_ != 0)
			{
				num13++;
			}
		}
		num += smethod_244(Class185.smethod_0(-1141152169), 0, num13);
		num += smethod_244(Class185.smethod_0(-1141152219), 2, Class342.smethod_5());
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
		num += smethod_244(Class185.smethod_0(-1141153289), 0, Class342.smethod_5());
		num += smethod_243(Class185.smethod_0(-1141153349), flag && int_ == 0);
		flag = Class342.smethod_24(5400L, bool_1: false, array2, smethod_227(array2, 5400L), ireadOnlyList_6, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141153418), 3, int_);
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), ireadOnlyList_5, array3, array4, out int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = Class185.smethod_0(-1141303993),
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
		num += smethod_244(Class185.smethod_0(-1141153486), 0, num15);
		flag = Class342.smethod_24(5300L, bool_1: false, array2, smethod_227(array2, 5300L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141153539), 0, Class342.smethod_5());
		num += smethod_243(Class185.smethod_0(-1141153579), flag && int_ == 0);
		flag = Class342.smethod_24(6299L, bool_1: false, array2, smethod_227(array2, 6299L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141153635), flag && int_ == 0);
		flag = Class342.smethod_24(6300L, bool_1: false, array2, smethod_227(array2, 6300L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141153683), 3, int_);
		array3[3] = false;
		array3[8] = false;
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), ireadOnlyList_5, array3, array4, out int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = Class185.smethod_0(-1141303993),
			int_1 = 0,
			int_2 = 1400,
			string_1 = string.Empty
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), ireadOnlyList_5, array3, array4, out int_);
		flag = Class342.smethod_24(5300L, bool_1: false, array2, smethod_227(array2, 5300L), ireadOnlyList_5, array3, array4, out int_);
		flag = Class342.smethod_24(10299L, bool_1: false, array2, smethod_227(array2, 10299L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141153747), flag && int_ == 0);
		flag = Class342.smethod_24(10300L, bool_1: false, array2, smethod_227(array2, 10300L), ireadOnlyList_5, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141152770), 2, int_);
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
					string_0 = Class185.smethod_0(-1141303993),
					int_1 = 0,
					int_2 = 1400,
					string_1 = string.Empty
				});
			}
			num17 += 300L;
		}
		num += smethod_243(Class185.smethod_0(-1141152830), num18 * 2 >= 200);
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
		num += smethod_243(Class185.smethod_0(-1141152910), !flag);
		num += smethod_244(Class185.smethod_0(-1141152955), 1, int_);
		num += smethod_244(Class185.smethod_0(-1141153007), 1, Class342.smethod_5());
		Class342.smethod_2();
		array3[2] = true;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_228(0L, new Struct16[2]
		{
			smethod_229(27, 1, 2),
			smethod_229(27, 2, 0)
		}), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141153041), 2, int_);
		Class342.smethod_2();
		array3[2] = false;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_228(0L, new Struct16[1] { smethod_229(27, 1, 2) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141153117), flag && int_ == 0);
		num += smethod_244(Class185.smethod_0(-1141153155), 0, Class342.smethod_5());
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_228(300L, new Struct16[1] { smethod_229(27, 1, 0) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141153206), 1, int_);
		num += smethod_244(Class185.smethod_0(-1141153263), 1000, 1000);
		Class342.smethod_2();
		flag = Class342.smethod_24(2001L, bool_1: false, array2, smethod_228(1000L, new Struct16[1] { smethod_229(27, 1, 0) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141150216), flag && int_ == 0);
		Class342.smethod_2();
		flag = Class342.smethod_24(2000L, bool_1: false, array2, smethod_228(1000L, new Struct16[1] { smethod_229(27, 1, 0) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141150262), 1, int_);
		Class342.smethod_2();
		flag = Class342.smethod_24(0L, bool_1: false, array2, null, ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141150311), flag && int_ == 0);
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_228(0L, Array.Empty<Struct16>()), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141150358), flag && int_ == 0);
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_228(0L, new Struct16[1] { smethod_229(27, 9, 0) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141150414), flag && int_ == 0);
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_228(0L, new Struct16[1] { smethod_229(28, 1, 0) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141150449), flag && int_ == 0);
		num += smethod_243(Class185.smethod_0(-1141150501), !Class342.smethod_26(27, 1, new Class358
		{
			long_0 = 0L,
			struct16_0 = null
		}, 0L));
		num += smethod_243(Class185.smethod_0(-1141150558), Class342.smethod_26(27, 1, smethod_228(0L, new Struct16[2]
		{
			smethod_229(27, 9, 0),
			smethod_229(27, 1, 0)
		}), 0L));
		Class342.smethod_2();
		array3[1] = false;
		array3[8] = true;
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_228(0L, new Struct16[1] { smethod_229(40, 1, 2) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141150600), flag && int_ == 0);
		num += smethod_244(Class185.smethod_0(-1141150643), -1L, Class342.smethod_6());
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_228(300L, new Struct16[1] { smethod_229(40, 1, 0) }), ireadOnlyList_7, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141150696), 8, int_);
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
		num += smethod_244(Class185.smethod_0(-1141149705), 10, num22);
		num += smethod_244(Class185.smethod_0(-1141149776), 0, Class342.smethod_5());
		num += smethod_243(Class185.smethod_0(-1141149810), !Class342.smethod_26(27, 1, smethod_228(0L, new Struct16[1] { smethod_229(27, 1, -1) }), 0L));
		for (int num24 = 1; num24 <= 8; num24++)
		{
			array3[num24] = false;
		}
		Class342.smethod_2();
		Class358 class9 = smethod_228(5L, new Struct16[1] { smethod_229(1, 1, 0) });
		Class358 class10 = Class119.smethod_54(JObject.Parse(Class185.smethod_0(-1141149856)), 1234L, class9);
		num += smethod_243(Class185.smethod_0(-1141149958), class10 != null && class10 != class9);
		if (class10 != null && class10.struct16_0 != null && class10.struct16_0.Length == 2)
		{
			num += smethod_244(Class185.smethod_0(-1141150007), 1234L, class10.long_0);
			num += smethod_244(Class185.smethod_0(-1141150037), (ushort)27, class10.struct16_0[0].ushort_0);
			num += smethod_244(Class185.smethod_0(-1141150057), (ushort)1, class10.struct16_0[0].ushort_1);
			num += smethod_244(Class185.smethod_0(-1141150084), 0, class10.struct16_0[0].int_0);
			num += smethod_244(Class185.smethod_0(-1141150120), (ushort)40, class10.struct16_0[1].ushort_0);
			num += smethod_244(Class185.smethod_0(-1141150140), 2, class10.struct16_0[1].int_0);
		}
		else
		{
			num += smethod_243(Class185.smethod_0(-1141150176), bool_0: false);
		}
		Class358 class11 = Class119.smethod_54(JObject.Parse(Class185.smethod_0(-1141151236)), 1500L, class9);
		num += smethod_243(Class185.smethod_0(-1141151281), class11 != null && class11.long_0 == 1500L && class11.struct16_0 != null && class11.struct16_0.Length == 0);
		JObject jobject_ = JObject.Parse(Class185.smethod_0(-1141151348));
		num += smethod_243(Class185.smethod_0(-1141151432), class9 == Class119.smethod_54(jobject_, 2000L, class9));
		num += smethod_243(Class185.smethod_0(-1141151474), Class119.smethod_54(jobject_, 2000L, null) == null);
		string[] array11 = new string[7]
		{
			Class185.smethod_0(-1141151516),
			Class185.smethod_0(-1141151550),
			Class185.smethod_0(-1141151597),
			Class185.smethod_0(-1141151634),
			Class185.smethod_0(-1141151678),
			Class185.smethod_0(-1141151714),
			Class185.smethod_0(-1141150737)
		};
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
			num += smethod_243(Class185.smethod_0(-1141150816) + num25 + Class185.smethod_0(-1141150836), !flag3);
			num += smethod_243(Class185.smethod_0(-1141150816) + num25 + Class185.smethod_0(-1141150858), class9 == class12);
		}
		Class358 class13 = null;
		bool flag4 = false;
		try
		{
			class13 = Class119.smethod_54(JObject.Parse(Class185.smethod_0(-1141150889)), 4000L, class9);
		}
		catch
		{
			flag4 = true;
		}
		num += smethod_243(Class185.smethod_0(-1141151082), !flag4);
		num += smethod_243(Class185.smethod_0(-1141151121), class13 != null && class13.struct16_0 != null && class13.struct16_0.Length == 1 && class13.struct16_0[0].ushort_0 == 27 && class13.struct16_0[0].ushort_1 == 3 && class13.struct16_0[0].int_0 == 0);
		Class358 class14 = null;
		bool flag5 = false;
		try
		{
			class14 = Class119.smethod_54(JObject.Parse(Class185.smethod_0(-1141151179)), 5000L, class9);
		}
		catch
		{
			flag5 = true;
		}
		num += smethod_243(Class185.smethod_0(-1141156480), !flag5);
		num += smethod_243(Class185.smethod_0(-1141156520), class14 != null && class14.struct16_0 != null && class14.struct16_0.Length == 5);
		if (class14 != null && class14.struct16_0 != null && class14.struct16_0.Length == 5)
		{
			for (int num26 = 0; num26 < 5; num26++)
			{
				num += smethod_244(Class185.smethod_0(-1141156555) + num26 + Class185.smethod_0(-1141156590), -1, class14.struct16_0[num26].int_0);
			}
		}
		num += smethod_243(Class185.smethod_0(-1141156606), !Class342.smethod_26(27, 1, class14, 5000L));
		StringBuilder stringBuilder = new StringBuilder(Class185.smethod_0(-1141156646));
		for (int num27 = 0; num27 < 12; num27++)
		{
			stringBuilder.Append((num27 == 0) ? string.Empty : Class185.smethod_0(-1141326297)).Append(Class185.smethod_0(-1141156681) + num27 + Class185.smethod_0(-1141156705));
		}
		stringBuilder.Append(Class185.smethod_0(-1141156722));
		Class358 class15 = Class119.smethod_54(JObject.Parse(stringBuilder.ToString()), 6000L, class9);
		num += smethod_243(Class185.smethod_0(-1141156731), class15 != null && class15.struct16_0 != null && class15.struct16_0.Length == 10);
		num += smethod_244(Class185.smethod_0(-1141156778), 10, 10);
		num += smethod_244(Class185.smethod_0(-1141156832), 500, 500);
		num += smethod_243(Class185.smethod_0(-1141156859), Class91.smethod_8(bool_0: true, array2, 1, -1L, 0L));
		num += smethod_243(Class185.smethod_0(-1141155874), !Class91.smethod_8(bool_0: true, array2, 1, 1000L, 1499L));
		num += smethod_243(Class185.smethod_0(-1141155913), Class91.smethod_8(bool_0: true, array2, 1, 1000L, 1500L));
		num += smethod_243(Class185.smethod_0(-1141155952), !Class91.smethod_8(bool_0: false, array2, 1, -1L, 0L));
		num += smethod_243(Class185.smethod_0(-1141155979), !Class91.smethod_8(bool_0: true, array2, 0, -1L, 0L));
		num += smethod_243(Class185.smethod_0(-1141156029), !Class91.smethod_8(bool_0: true, null, 1, -1L, 0L));
		bool[] bool_ = new bool[11]
		{
			false, false, true, false, true, true, false, false, true, true,
			true
		};
		List<(ushort, ushort)> list3 = Class91.smethod_9(bool_, array2);
		num += smethod_244(Class185.smethod_0(-1141156085), 5, list3.Count);
		if (list3.Count == 5)
		{
			num += smethod_244(Class185.smethod_0(-1141156124), ((ushort)27, (ushort)2), list3[0]);
			num += smethod_244(Class185.smethod_0(-1141156168), ((ushort)27, (ushort)4), list3[1]);
			num += smethod_244(Class185.smethod_0(-1141156205), ((ushort)40, (ushort)1), list3[2]);
			num += smethod_244(Class185.smethod_0(-1141156233), ((ushort)50, (ushort)9), list3[3]);
			num += smethod_244(Class185.smethod_0(-1141156276), ((ushort)50, (ushort)10), list3[4]);
		}
		num += smethod_244(Class185.smethod_0(-1141156327), 0, Class91.smethod_9(new bool[11], array2).Count);
		num += smethod_244(Class185.smethod_0(-1141157397), 0, Class91.smethod_9(bool_, null).Count);
		num += smethod_244(Class185.smethod_0(-1141157438), Class185.smethod_0(-1141157467), Class454.smethod_6(list3));
		List<(ushort, ushort)> list4 = Class91.smethod_9(new bool[11]
		{
			false, false, false, false, false, false, false, false, false, true,
			true
		}, array2);
		num += smethod_244(Class185.smethod_0(-1141157539), 2, list4.Count);
		num += smethod_244(Class185.smethod_0(-1141157580), Class185.smethod_0(-1141157624), Class454.smethod_6(list4));
		num += smethod_244(Class185.smethod_0(-1141157667), 0, Class91.smethod_9(new bool[9], array2).Count);
		num += smethod_244(Class185.smethod_0(-1141157728), Class185.smethod_0(-1141157761), Class454.smethod_6(new List<(ushort, ushort)>()));
		if (text3 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141157806), text3.Contains(Class185.smethod_0(-1141157850)));
		}
		long num28 = Class358.smethod_0();
		long num29 = Class342.smethod_10();
		long num30 = Class358.smethod_0();
		num += smethod_243(Class185.smethod_0(-1141157876), num28 <= num29 && num29 <= num30);
		num += smethod_243(Class185.smethod_0(-1141156909), !typeof(Struct16).IsPublic);
		num += smethod_243(Class185.smethod_0(-1141156951), Class91.smethod_7(bool_0: true, bool_1: true, bool_2: true, bool_3: false));
		num += smethod_243(Class185.smethod_0(-1141156985), !Class91.smethod_7(bool_0: false, bool_1: true, bool_2: true, bool_3: false));
		num += smethod_243(Class185.smethod_0(-1141157027), !Class91.smethod_7(bool_0: true, bool_1: false, bool_2: true, bool_3: false));
		num += smethod_243(Class185.smethod_0(-1141157073), !Class91.smethod_7(bool_0: true, bool_1: true, bool_2: false, bool_3: false));
		num += smethod_243(Class185.smethod_0(-1141157138), !Class91.smethod_7(bool_0: true, bool_1: true, bool_2: true, bool_3: true));
		num += smethod_243(Class185.smethod_0(-1141157193), !Class91.smethod_8(Class91.smethod_7(bool_0: true, bool_1: false, bool_2: true, bool_3: false), array2, 1, -1L, 0L));
		for (int num31 = 1; num31 <= 8; num31++)
		{
			array3[num31] = false;
		}
		array3[2] = true;
		Class342.smethod_2();
		num += smethod_243(Class185.smethod_0(-1141157236), !Class342.smethod_7());
		flag = Class342.smethod_24(0L, bool_1: false, array2, smethod_227(array2, 0L), list, array3, array4, out int_);
		num += smethod_244(Class185.smethod_0(-1141157274), 2, int_);
		Class342.smethod_0(new Class74
		{
			int_0 = 2,
			string_0 = Class185.smethod_0(-1141175351),
			int_1 = -1,
			int_2 = -1,
			string_1 = Class185.smethod_0(-1141149035)
		});
		flag = Class342.smethod_24(300L, bool_1: false, array2, smethod_227(array2, 300L), list, array3, array4, out int_);
		num += smethod_243(Class185.smethod_0(-1141157312), Class342.smethod_7());
		Class342.smethod_2();
		num += smethod_243(Class185.smethod_0(-1141157360), !Class342.smethod_7());
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
		num += smethod_244(Class185.smethod_0(-1141154334), Class185.smethod_0(-1141154354), Class342.smethod_15(Class185.smethod_0(-1141154387), bool_1: true, 0, string.Empty));
		Class342.smethod_2();
		Class342.smethod_24(0L, bool_1: true, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out var int_2);
		num += smethod_244(Class185.smethod_0(-1141154404), Class185.smethod_0(-1141154429), Class342.smethod_3());
		Class342.smethod_24(0L, bool_1: false, null, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141154440), Class185.smethod_0(-1141154462), Class342.smethod_3());
		num += smethod_244(Class185.smethod_0(-1141154478), Class185.smethod_0(-1141154497), Class342.smethod_4());
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), null, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141154537), Class185.smethod_0(-1141154568), Class342.smethod_3());
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141154577), Class185.smethod_0(-1141154605), Class342.smethod_3());
		num += smethod_243(Class185.smethod_0(-1141154611), Class342.smethod_4().Contains(Class185.smethod_0(-1141154645)) && Class342.smethod_4().Contains(Class185.smethod_0(-1141154679)));
		array12[1] = true;
		array13[1] = Class185.smethod_0(-1141276741);
		Class342.smethod_24(0L, bool_1: false, valueTuple_, null, list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141154692), Class185.smethod_0(-1141154715), Class342.smethod_3());
		num += smethod_244(Class185.smethod_0(-1141154732), 0, int_2);
		num += smethod_244(Class185.smethod_0(-1141154763), Class185.smethod_0(-1141154799), Class342.smethod_4());
		Class342.smethod_24(2000L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141153955), Class185.smethod_0(-1141153979), Class342.smethod_3());
		num += smethod_243(Class185.smethod_0(-1141154005), Class342.smethod_4().Contains(Class185.smethod_0(-1141154026)));
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_228(0L, new Struct16[1] { smethod_229(99, 99, 0) }), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141154061), Class185.smethod_0(-1141154087), Class342.smethod_3());
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_228(0L, new Struct16[1] { smethod_229(27, 1, 8) }), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141154099), Class185.smethod_0(-1141154122), Class342.smethod_3());
		num += smethod_243(Class185.smethod_0(-1141154139), Class342.smethod_4().Contains(Class185.smethod_0(-1141154175)));
		list5.Add(new GStruct3
		{
			bool_0 = false,
			ushort_0 = 27,
			ushort_1 = 1,
			float_0 = 50f
		});
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141154199), Class185.smethod_0(-1141154211), Class342.smethod_3());
		num += smethod_243(Class185.smethod_0(-1141154225), Class342.smethod_4().Contains(Class185.smethod_0(-1141154250)));
		num += smethod_243(Class185.smethod_0(-1141155354), !Class342.smethod_13(Class185.smethod_0(-1141154211)));
		num += smethod_243(Class185.smethod_0(-1141155397), Class342.smethod_13(Class185.smethod_0(-1141155417)));
		array13[1] = string.Empty;
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141155428), Class185.smethod_0(-1141155450), Class342.smethod_3());
		array13[1] = Class185.smethod_0(-1141296459);
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141155466), Class185.smethod_0(-1141154211), Class342.smethod_3());
		list5.Clear();
		array13[1] = Class185.smethod_0(-1141276741);
		array12[1] = false;
		array12[3] = true;
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141155497), Class185.smethod_0(-1141155528), Class342.smethod_3());
		num += smethod_243(Class185.smethod_0(-1141155537), Class342.smethod_4().Contains(Class185.smethod_0(-1141155573)));
		(ushort, ushort)[] valueTuple_2 = new(ushort, ushort)[2]
		{
			(27, 1),
			(27, 2)
		};
		Class342.smethod_24(0L, bool_1: false, valueTuple_2, smethod_227(valueTuple_2, 0L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141155629), Class185.smethod_0(-1141155644), Class342.smethod_3());
		array12[3] = false;
		array12[8] = true;
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141155669), Class185.smethod_0(-1141155701), Class342.smethod_3());
		array13[8] = Class185.smethod_0(-1141306701);
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141155727), Class185.smethod_0(-1141155417), Class342.smethod_3());
		num += smethod_244(Class185.smethod_0(-1141155745), 8, int_2);
		num += smethod_244(Class185.smethod_0(-1141155784), Class185.smethod_0(-1141155806), Class342.smethod_4());
		Class342.smethod_24(100L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 100L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141154945), Class185.smethod_0(-1141154973), Class342.smethod_3());
		num += smethod_243(Class185.smethod_0(-1141154979), Class342.smethod_4().Contains(Class185.smethod_0(-1141155004)) && Class342.smethod_4().Contains(Class185.smethod_0(-1141155043)));
		Class342.smethod_0(new Class74
		{
			int_0 = 8,
			string_0 = Class185.smethod_0(-1141303993),
			int_1 = 0,
			int_2 = 1300,
			string_1 = string.Empty
		});
		Class342.smethod_24(1400L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 1400L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141155070), Class185.smethod_0(-1141155082), Class342.smethod_3());
		Class342.smethod_24(2000L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 2000L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141155104), Class185.smethod_0(-1141155133), Class342.smethod_3());
		num += smethod_243(Class185.smethod_0(-1141155148), Class342.smethod_4().Contains(Class185.smethod_0(-1141155190)) && Class342.smethod_4().Contains(Class185.smethod_0(-1141155208)));
		array12[8] = false;
		Class342.smethod_2();
		array12[1] = true;
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141155230), 1, int_2);
		Class342.smethod_0(new Class74
		{
			int_0 = 1,
			string_0 = Class185.smethod_0(-1141303993),
			int_1 = 0,
			int_2 = 1300,
			string_1 = string.Empty
		});
		Class342.smethod_24(1400L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 1400L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141155254), Class185.smethod_0(-1141155278), Class342.smethod_3());
		Class342.smethod_24(1700L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 1700L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141155296), Class185.smethod_0(-1141155319), Class342.smethod_3());
		num += smethod_243(Class185.smethod_0(-1141160456), Class342.smethod_4().Contains(Class185.smethod_0(-1141160476)) && Class342.smethod_4().Contains(Class185.smethod_0(-1141160525)));
		list5.Add(new GStruct3
		{
			bool_0 = false,
			ushort_0 = 27,
			ushort_1 = 1,
			float_0 = 180f
		});
		Class342.smethod_24(2000L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 2000L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141160539), Class185.smethod_0(-1141160561), Class342.smethod_3());
		list5.Clear();
		Class342.smethod_24(2300L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 2300L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141160577), 1, int_2);
		Class342.smethod_0(new Class74
		{
			int_0 = 1,
			string_0 = Class185.smethod_0(-1141303993),
			int_1 = 0,
			int_2 = 1300,
			string_1 = string.Empty
		});
		Class342.smethod_24(2600L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 2600L), list5, array12, array13, out int_2);
		Class342.smethod_24(7700L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 7700L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141160608), Class185.smethod_0(-1141160628), Class342.smethod_3());
		Class342.smethod_24(8000L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 8000L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141160650), Class185.smethod_0(-1141160666), Class342.smethod_3());
		num += smethod_243(Class185.smethod_0(-1141160676), Class342.smethod_4().Contains(Class185.smethod_0(-1141160697)));
		Class342.smethod_24(8700L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 8700L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141160774), Class185.smethod_0(-1141160788), Class342.smethod_3());
		num += smethod_243(Class185.smethod_0(-1141160804), Class342.smethod_4().Contains(Class185.smethod_0(-1141160839)) && Class342.smethod_4().Contains(Class185.smethod_0(-1141160887)));
		Class342.smethod_2();
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		Class342.smethod_0(new Class74
		{
			int_0 = 1,
			string_0 = Class185.smethod_0(-1141175325),
			int_1 = -1,
			int_2 = 200,
			string_1 = string.Empty
		});
		Class342.smethod_24(300L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 300L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141160900), Class185.smethod_0(-1141160922), Class342.smethod_3());
		Class342.smethod_24(400L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 400L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141160938), Class185.smethod_0(-1141160666), Class342.smethod_3());
		num += smethod_243(Class185.smethod_0(-1141159949), Class342.smethod_4().Contains(Class185.smethod_0(-1141159976)));
		Class342.smethod_2();
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		Class342.smethod_24(7000L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 7000L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141160010), Class185.smethod_0(-1141160035), Class342.smethod_3());
		Class342.smethod_2();
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		Class342.smethod_0(new Class74
		{
			int_0 = 1,
			string_0 = Class185.smethod_0(-1141175636),
			int_1 = 8,
			int_2 = 200,
			string_1 = string.Empty
		});
		Class342.smethod_24(300L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 300L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141160062), Class185.smethod_0(-1141160087), Class342.smethod_3());
		num += smethod_243(Class185.smethod_0(-1141160098), Class342.smethod_4().Contains(Class185.smethod_0(-1141160136)));
		Class342.smethod_2();
		Class342.smethod_24(0L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 0L), list5, array12, array13, out int_2);
		Class342.smethod_0(new Class74
		{
			int_0 = 1,
			string_0 = Class185.smethod_0(-1141175351),
			int_1 = -1,
			int_2 = -1,
			string_1 = string.Empty
		});
		Class342.smethod_24(300L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 300L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141160167), Class185.smethod_0(-1141160188), Class342.smethod_3());
		Class342.smethod_24(600L, bool_1: false, valueTuple_, smethod_227(valueTuple_, 600L), list5, array12, array13, out int_2);
		num += smethod_244(Class185.smethod_0(-1141160211), Class185.smethod_0(-1141175351), Class342.smethod_3());
		Class342.smethod_2();
		array12[1] = false;
		num += smethod_243(Class185.smethod_0(-1141160235), GForm0.smethod_1(Class185.smethod_0(-1141160278)) != null);
		num += smethod_243(Class185.smethod_0(-1141160334), GForm0.smethod_1(Class185.smethod_0(-1141160368)).IndexOf('\n') < 0);
		num += smethod_243(Class185.smethod_0(-1141160409), GForm0.smethod_1(Class185.smethod_0(-1141160443)) != null);
		Console.WriteLine(Class185.smethod_0(-1141161549) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_152()
	{
		int num = 0;
		num = 0 + smethod_243(Class185.smethod_0(-1141161556), Class357.smethod_15(smethod_230(Class357.valueTuple_16), out var string_));
		num += smethod_243(Class185.smethod_0(-1141161589), Class357.smethod_54());
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141161613), text.Contains(Class185.smethod_0(-1141161651)));
		num += smethod_243(Class185.smethod_0(-1141161688), text.Contains(Class185.smethod_0(-1141161734)));
		num += smethod_244(Class185.smethod_0(-1141161755), 0, 0);
		num += smethod_243(Class185.smethod_0(-1141161799), smethod_221(text, Class185.smethod_0(-1141161838), 0));
		num += smethod_243(Class185.smethod_0(-1141161855), smethod_221(text, Class185.smethod_0(-1141161893), 40));
		num += smethod_243(Class185.smethod_0(-1141161911), smethod_221(text, Class185.smethod_0(-1141161949), 48));
		num += smethod_243(Class185.smethod_0(-1141161967), smethod_221(text, Class185.smethod_0(-1141160981), 40));
		num += smethod_243(Class185.smethod_0(-1141160999), smethod_221(text, Class185.smethod_0(-1141161026), 16));
		num += smethod_243(Class185.smethod_0(-1141161041), smethod_221(text, Class185.smethod_0(-1141161087), 24));
		num += smethod_243(Class185.smethod_0(-1141161097), smethod_221(text, Class185.smethod_0(-1141161141), 104));
		num += smethod_243(Class185.smethod_0(-1141161157), smethod_221(text, Class185.smethod_0(-1141161186), 16));
		num += smethod_243(Class185.smethod_0(-1141161203), smethod_221(text, Class185.smethod_0(-1141161247), 20));
		num += smethod_243(Class185.smethod_0(-1141161263), smethod_221(text, Class185.smethod_0(-1141161304), 57));
		num += smethod_243(Class185.smethod_0(-1141161325), smethod_221(text, Class185.smethod_0(-1141161366), 282));
		num += smethod_243(Class185.smethod_0(-1141161379), smethod_221(text, Class185.smethod_0(-1141161417), 382));
		num += smethod_243(Class185.smethod_0(-1141161435), smethod_221(text, Class185.smethod_0(-1141158406), 112));
		num += smethod_243(Class185.smethod_0(-1141158421), smethod_221(text, Class185.smethod_0(-1141158450), 120));
		num += smethod_243(Class185.smethod_0(-1141158467), smethod_221(text, Class185.smethod_0(-1141158519), 184));
		num += smethod_243(Class185.smethod_0(-1141158543), smethod_221(text, Class185.smethod_0(-1141158581), 32));
		num += smethod_243(Class185.smethod_0(-1141158599), Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out string_));
		string text2 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141158626), !text2.Contains(Class185.smethod_0(-1141158677)));
		num += smethod_243(Class185.smethod_0(-1141158697), !text2.Contains(Class185.smethod_0(-1141158732)));
		num += smethod_243(Class185.smethod_0(-1141158760), !text2.Contains(Class185.smethod_0(-1141158786)));
		num += smethod_243(Class185.smethod_0(-1141158813), !text2.Contains(Class185.smethod_0(-1141158848)));
		num += smethod_243(Class185.smethod_0(-1141158860), !Class357.smethod_54());
		num += smethod_243(Class185.smethod_0(-1141158904), Class357.smethod_15(smethod_230(Class357.valueTuple_5), out string_));
		string text3 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141157911), text3.Contains(Class185.smethod_0(-1141157946)));
		num += smethod_243(Class185.smethod_0(-1141157964), !text3.Contains(Class185.smethod_0(-1141158732)));
		num += smethod_243(Class185.smethod_0(-1141158009), !text3.Contains(Class185.smethod_0(-1141158060)));
		num += smethod_243(Class185.smethod_0(-1141158094), !text3.Contains(Class185.smethod_0(-1141158848)));
		num += smethod_244(Class185.smethod_0(-1141158131), Class185.smethod_0(-1141158157), Class341.smethod_0());
		num += smethod_244(Class185.smethod_0(-1141158169), 12, 12);
		num += smethod_244(Class185.smethod_0(-1141158205), ushort.MaxValue, ushort.MaxValue);
		num += smethod_244(Class185.smethod_0(-1141158229), 0, 0);
		num += smethod_244(Class185.smethod_0(-1141158263), 0, 0);
		num += smethod_244(Class185.smethod_0(-1141158289), 0, 0);
		num += smethod_244(Class185.smethod_0(-1141158331), Class185.smethod_0(-1141262332), Class185.smethod_0(-1141262332));
		num += smethod_244(Class185.smethod_0(-1141158367), Class185.smethod_0(-1141274433), Class185.smethod_0(-1141274433));
		JObject jobject_ = JObject.Parse(Class185.smethod_0(-1141158398));
		IReadOnlyList<Struct27> readOnlyList = Class119.smethod_40(jobject_);
		IReadOnlyList<Struct19> readOnlyList2 = Class119.smethod_43(jobject_);
		num += smethod_244(Class185.smethod_0(-1141158921), 3, readOnlyList.Count);
		if (readOnlyList.Count == 3)
		{
			num += smethod_244(Class185.smethod_0(-1141158960), 0, readOnlyList[0].int_0);
			num += smethod_244(Class185.smethod_0(-1141158984), 3, readOnlyList[1].int_0);
			num += smethod_244(Class185.smethod_0(-1141159008), 7, readOnlyList[2].int_0);
			num += smethod_244(Class185.smethod_0(-1141159032), 0, readOnlyList[0].int_1);
			num += smethod_244(Class185.smethod_0(-1141159064), 3, readOnlyList[1].int_1);
			num += smethod_244(Class185.smethod_0(-1141159096), 7, readOnlyList[2].int_1);
			num += smethod_244(Class185.smethod_0(-1141159128), (ushort)11, readOnlyList[0].ushort_0);
			num += smethod_244(Class185.smethod_0(-1141159149), (ushort)1, readOnlyList[0].ushort_1);
			num += smethod_244(Class185.smethod_0(-1141159161), 1, readOnlyList[0].int_2);
			num += smethod_244(Class185.smethod_0(-1141159192), (ushort)9, readOnlyList[1].ushort_0);
			num += smethod_244(Class185.smethod_0(-1141159213), (ushort)9, readOnlyList[1].ushort_1);
			num += smethod_244(Class185.smethod_0(-1141159225), 42, readOnlyList[1].int_2);
			num += smethod_244(Class185.smethod_0(-1141159256), (ushort)61, readOnlyList[2].ushort_0);
			num += smethod_244(Class185.smethod_0(-1141159277), (ushort)1, readOnlyList[2].ushort_1);
			num += smethod_244(Class185.smethod_0(-1141159289), 2, readOnlyList[2].int_2);
		}
		num += smethod_244(Class185.smethod_0(-1141159320), 60, Class119.smethod_42(jobject_));
		IReadOnlyList<Struct27> readOnlyList3 = Class119.smethod_40(JObject.Parse(Class185.smethod_0(-1141159351)));
		num += smethod_244(Class185.smethod_0(-1141159401), 1, readOnlyList3.Count);
		if (readOnlyList3.Count == 1)
		{
			num += smethod_244(Class185.smethod_0(-1141131785), 7, readOnlyList3[0].int_0);
			num += smethod_244(Class185.smethod_0(-1141131829), 3, readOnlyList3[0].int_1);
			num += smethod_243(Class185.smethod_0(-1141131859), Class16.smethod_1(readOnlyList3[0], 60).Contains(Class185.smethod_0(-1141131902)));
		}
		num += smethod_244(Class185.smethod_0(-1141131915), 0, Class119.smethod_40(JObject.Parse(Class185.smethod_0(-1141131956))).Count);
		num += smethod_243(Class185.smethod_0(-1141132014), readOnlyList2 != null);
		if (readOnlyList2 != null)
		{
			num += smethod_244(Class185.smethod_0(-1141132036), 12, readOnlyList2.Count);
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
				num += smethod_244(Class185.smethod_0(-1141132072) + i + Class185.smethod_0(-1141132088), i, readOnlyList2[i].int_0);
				num += smethod_244(Class185.smethod_0(-1141132072) + i + Class185.smethod_0(-1141132101), array[i], readOnlyList2[i].byte_0);
				num += smethod_244(Class185.smethod_0(-1141132072) + i + Class185.smethod_0(-1141132112), array2[i], readOnlyList2[i].ushort_0);
				num += smethod_244(Class185.smethod_0(-1141132072) + i + Class185.smethod_0(-1141132116), array3[i], readOnlyList2[i].ushort_1);
				num += smethod_244(Class185.smethod_0(-1141132072) + i + Class185.smethod_0(-1141132135), array4[i], readOnlyList2[i].int_1);
			}
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		smethod_222(jobject_, dictionary);
		num += smethod_244(Class185.smethod_0(-1141132149), 8, dictionary.Count);
		Class95 class95_ = new Class95(null, dictionary, null);
		Class145 @class = Class145.class145_0.method_98(readOnlyList, readOnlyList2, class95_, 7, Class119.smethod_41(jobject_), Class119.smethod_42(jobject_));
		num += smethod_244(Class185.smethod_0(-1141132177), 7, @class.method_43());
		num += smethod_244(Class185.smethod_0(-1141132213), string.Empty, @class.method_51());
		num += smethod_244(Class185.smethod_0(-1141132245), 0, @class.method_47());
		num += smethod_244(Class185.smethod_0(-1141132275), 60, @class.method_49());
		List<string[]> list = Class16.smethod_2(@class);
		num += smethod_244(Class185.smethod_0(-1141131299), 3, list.Count);
		if (list.Count == 3)
		{
			num += smethod_244(Class185.smethod_0(-1141131324), Class185.smethod_0(-1141296459), list[0][0]);
			num += smethod_244(Class185.smethod_0(-1141131357), Class185.smethod_0(-1141323585), list[0][1]);
			num += smethod_244(Class185.smethod_0(-1141131371), Class185.smethod_0(-1141296467), list[0][2]);
			num += smethod_244(Class185.smethod_0(-1141131395), Class185.smethod_0(-1141297437), list[1][0]);
			num += smethod_244(Class185.smethod_0(-1141131420), Class185.smethod_0(-1141322836), list[1][1]);
			num += smethod_244(Class185.smethod_0(-1141131461), Class185.smethod_0(-1141131485), list[1][2]);
			num += smethod_244(Class185.smethod_0(-1141131494), Class185.smethod_0(-1141292548), list[2][0]);
			num += smethod_244(Class185.smethod_0(-1141131519), Class185.smethod_0(-1141323707), list[2][1]);
			num += smethod_244(Class185.smethod_0(-1141131541), Class185.smethod_0(-1141297402), list[2][2]);
		}
		num += smethod_244(Class185.smethod_0(-1141131565), Class185.smethod_0(-1141131590), Class16.smethod_5(null, 1, 2));
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>(StringComparer.Ordinal);
		dictionary2[Class185.smethod_0(-1141334620)] = null;
		dictionary2[Class185.smethod_0(-1141312871)] = Class185.smethod_0(-1141341332);
		dictionary2[Class185.smethod_0(-1141131605)] = Class185.smethod_0(-1141131615);
		Class95 class95_2 = new Class95(null, dictionary2, null);
		num += smethod_244(Class185.smethod_0(-1141131637), Class185.smethod_0(-1141131663), Class16.smethod_5(class95_2, 1, 1));
		num += smethod_244(Class185.smethod_0(-1141131678), Class185.smethod_0(-1141131590), Class16.smethod_5(class95_2, 1, 2));
		num += smethod_244(Class185.smethod_0(-1141131697), Class185.smethod_0(-1141131728), Class16.smethod_5(class95_2, 1, 3));
		string[] array5 = new string[12]
		{
			Class185.smethod_0(-1141285164),
			Class185.smethod_0(-1141285104),
			Class185.smethod_0(-1141285026),
			Class185.smethod_0(-1141284967),
			Class185.smethod_0(-1141284892),
			Class185.smethod_0(-1141285850),
			Class185.smethod_0(-1141285792),
			Class185.smethod_0(-1141285714),
			Class185.smethod_0(-1141285644),
			Class185.smethod_0(-1141285578),
			Class185.smethod_0(-1141285507),
			Class185.smethod_0(-1141285435)
		};
		(string, string) tuple = Class16.smethod_4(@class, 0, array5[0]);
		num += smethod_244(Class185.smethod_0(-1141131738), Class185.smethod_0(-1141285164), tuple.Item1);
		num += smethod_244(Class185.smethod_0(-1141132813), string.Empty, tuple.Item2);
		(string, string) tuple2 = Class16.smethod_4(@class, 1, array5[1]);
		num += smethod_244(Class185.smethod_0(-1141132845), Class185.smethod_0(-1141132869), tuple2.Item1);
		num += smethod_244(Class185.smethod_0(-1141132886), Class185.smethod_0(-1141296467), tuple2.Item2);
		(string, string) tuple3 = Class16.smethod_4(@class, 3, array5[3]);
		num += smethod_244(Class185.smethod_0(-1141132909), Class185.smethod_0(-1141132948), tuple3.Item1);
		num += smethod_244(Class185.smethod_0(-1141132971), string.Empty, tuple3.Item2);
		(string, string) tuple4 = Class16.smethod_4(@class, 4, array5[4]);
		num += smethod_244(Class185.smethod_0(-1141133014), Class185.smethod_0(-1141133062), tuple4.Item1);
		(string, string) tuple5 = Class16.smethod_4(@class, 5, array5[5]);
		num += smethod_244(Class185.smethod_0(-1141133086), Class185.smethod_0(-1141133134), tuple5.Item1);
		num += smethod_244(Class185.smethod_0(-1141133158), Class185.smethod_0(-1141285792), Class16.smethod_4(@class, 6, array5[6]).Item1);
		num += smethod_244(Class185.smethod_0(-1141133179), Class185.smethod_0(-1141133216), Class16.smethod_4(@class, 7, array5[7]).Item1);
		num += smethod_244(Class185.smethod_0(-1141133238), Class185.smethod_0(-1141285644), Class16.smethod_4(@class, 8, array5[8]).Item1);
		num += smethod_244(Class185.smethod_0(-1141133271), Class185.smethod_0(-1141133296), Class16.smethod_4(@class, 9, array5[9]).Item1);
		num += smethod_244(Class185.smethod_0(-1141133306), Class185.smethod_0(-1141323707), Class16.smethod_4(@class, 10, array5[10]).Item1);
		num += smethod_244(Class185.smethod_0(-1141132317), Class185.smethod_0(-1141285435), Class16.smethod_4(@class, 11, array5[11]).Item1);
		num += smethod_244(Class185.smethod_0(-1141132349), Class185.smethod_0(-1141255982), Class16.smethod_4(@class, 12, Class185.smethod_0(-1141255982)).Item1);
		num += smethod_244(Class185.smethod_0(-1141132369), Class185.smethod_0(-1141255982), Class16.smethod_4(@class, -1, Class185.smethod_0(-1141255982)).Item1);
		num += smethod_244(Class185.smethod_0(-1141132395), Class185.smethod_0(-1141255982), Class16.smethod_4(null, 0, Class185.smethod_0(-1141255982)).Item1);
		num += smethod_244(Class185.smethod_0(-1141132430), string.Empty, Class16.smethod_4(@class, 0, null).Item1);
		Class145 class145_ = smethod_225(smethod_223(Class185.smethod_0(-1141132462)));
		num += smethod_244(Class185.smethod_0(-1141132517), Class185.smethod_0(-1141285164), Class16.smethod_4(class145_, 0, Class185.smethod_0(-1141285164)).Item1);
		Class145 class145_2 = smethod_225(smethod_223(Class185.smethod_0(-1141132567)));
		num += smethod_244(Class185.smethod_0(-1141132610), Class185.smethod_0(-1141285164), Class16.smethod_4(class145_2, 0, Class185.smethod_0(-1141285164)).Item1);
		Class145 class145_3 = smethod_225(smethod_223(Class185.smethod_0(-1141132670)));
		num += smethod_244(Class185.smethod_0(-1141132718), Class185.smethod_0(-1141132760), Class16.smethod_4(class145_3, 0, Class185.smethod_0(-1141285164)).Item1);
		JObject jobject_2 = JObject.Parse(Class185.smethod_0(-1141132776));
		num += smethod_244(Class185.smethod_0(-1141129766), Class185.smethod_0(-1141129807), Class119.smethod_39(jobject_2, Class119.smethod_43(jobject_2), bool_17: false));
		num += smethod_244(Class185.smethod_0(-1141129828), Class185.smethod_0(-1141129869), Class119.smethod_39(JObject.Parse(Class185.smethod_0(-1141129920)), null, bool_17: false));
		num += smethod_244(Class185.smethod_0(-1141129949), Class185.smethod_0(-1141129869), Class119.smethod_39(JObject.Parse(Class185.smethod_0(-1141129977)), null, bool_17: false));
		num += smethod_244(Class185.smethod_0(-1141130017), Class185.smethod_0(-1141129869), Class119.smethod_39(JObject.Parse(Class185.smethod_0(-1141130050)), readOnlyList2, bool_17: true));
		num += smethod_244(Class185.smethod_0(-1141130068), Class185.smethod_0(-1141129869), Class119.smethod_39(JObject.Parse(Class185.smethod_0(-1141130106)), readOnlyList2, bool_17: true));
		num += smethod_244(Class185.smethod_0(-1141130144), Class185.smethod_0(-1141129869), Class119.smethod_39(null, null, bool_17: false));
		JObject jobject_3 = smethod_224(11);
		num += smethod_243(Class185.smethod_0(-1141130171), Class119.smethod_43(jobject_3) == null);
		num += smethod_244(Class185.smethod_0(-1141130215), Class185.smethod_0(-1141129217), Class119.smethod_39(jobject_3, Class119.smethod_43(jobject_3), bool_17: true));
		JObject jobject_4 = smethod_224(13);
		num += smethod_243(Class185.smethod_0(-1141129278), Class119.smethod_43(jobject_4) == null);
		num += smethod_243(Class185.smethod_0(-1141129308), Class119.smethod_43(JObject.Parse(Class185.smethod_0(-1141129340))) == null);
		num += smethod_243(Class185.smethod_0(-1141129384), Class119.smethod_43(smethod_223(Class185.smethod_0(-1141129425))) == null);
		num += smethod_243(Class185.smethod_0(-1141129476), Class119.smethod_43(smethod_223(Class185.smethod_0(-1141129541))) == null);
		num += smethod_243(Class185.smethod_0(-1141129571), Class119.smethod_43(smethod_223(Class185.smethod_0(-1141129637))) == null);
		num += smethod_243(Class185.smethod_0(-1141129642), Class119.smethod_43(smethod_223(Class185.smethod_0(-1141129693))) != null);
		num += smethod_244(Class185.smethod_0(-1141130766), Class185.smethod_0(-1141130794), Class119.smethod_39(jobject_, readOnlyList2, bool_17: false));
		num += smethod_244(Class185.smethod_0(-1141130845), string.Empty, Class119.smethod_39(jobject_, readOnlyList2, bool_17: true));
		Class145 class2 = @class.method_99(Class185.smethod_0(-1141129807));
		num += smethod_244(Class185.smethod_0(-1141130877), 0, class2.method_39().Count);
		num += smethod_244(Class185.smethod_0(-1141130909), 0, class2.method_41().Count);
		num += smethod_244(Class185.smethod_0(-1141130939), 0, class2.method_43());
		num += smethod_244(Class185.smethod_0(-1141130982), Class185.smethod_0(-1141129807), class2.method_51());
		num += smethod_244(Class185.smethod_0(-1141131011), string.Empty, @class.method_99(null).method_51());
		List<string[]> list2 = Class16.smethod_2(class2);
		num += smethod_244(Class185.smethod_0(-1141131056), 1, list2.Count);
		if (list2.Count == 1)
		{
			num += smethod_244(Class185.smethod_0(-1141131088), Class185.smethod_0(-1141129807), list2[0][1]);
			num += smethod_244(Class185.smethod_0(-1141131117), string.Empty, list2[0][0]);
			num += smethod_244(Class185.smethod_0(-1141131152), string.Empty, list2[0][2]);
		}
		num += smethod_244(Class185.smethod_0(-1141131178), Class185.smethod_0(-1141285104), Class16.smethod_4(class2, 1, Class185.smethod_0(-1141285104)).Item1);
		num += smethod_244(Class185.smethod_0(-1141131223), 0, Class16.smethod_2(null).Count);
		num += smethod_244(Class185.smethod_0(-1141131249), 0, Class16.smethod_2(Class145.class145_0).Count);
		Class145 class3 = class2.method_97(readOnlyList, readOnlyList2, class95_, 8, 42);
		num += smethod_244(Class185.smethod_0(-1141130259), string.Empty, class3.method_51());
		num += smethod_244(Class185.smethod_0(-1141130298), 8, class3.method_43());
		num += smethod_244(Class185.smethod_0(-1141130343), 3, class3.method_39().Count);
		num += smethod_244(Class185.smethod_0(-1141130372), 42, class3.method_47());
		num += smethod_244(Class185.smethod_0(-1141130421), 30, Class119.smethod_41(smethod_226(Class185.smethod_0(-1141289094))));
		num += smethod_244(Class185.smethod_0(-1141130448), 24, Class119.smethod_41(smethod_226(Class185.smethod_0(-1141285992))));
		num += smethod_244(Class185.smethod_0(-1141130487), 60, Class119.smethod_41(smethod_226(Class185.smethod_0(-1141306701))));
		num += smethod_244(Class185.smethod_0(-1141130528), 0, Class119.smethod_41(jobject_));
		num += smethod_244(Class185.smethod_0(-1141130546), 0, Class119.smethod_41(smethod_226(Class185.smethod_0(-1141296459))));
		num += smethod_244(Class185.smethod_0(-1141130570), 0, Class119.smethod_41(smethod_226(Class185.smethod_0(-1141130606))));
		num += smethod_244(Class185.smethod_0(-1141130615), 0, Class119.smethod_41(smethod_226(Class185.smethod_0(-1141130646))));
		num += smethod_244(Class185.smethod_0(-1141130649), 0, Class119.smethod_41(smethod_226(Class185.smethod_0(-1141273631))));
		num += smethod_244(Class185.smethod_0(-1141130673), 0, Class119.smethod_41(smethod_226(Class185.smethod_0(-1141130711))));
		num += smethod_244(Class185.smethod_0(-1141130714), 0, Class119.smethod_41(null));
		num += smethod_244(Class185.smethod_0(-1141135880), string.Empty, Class119.smethod_39(smethod_226(Class185.smethod_0(-1141296459)), readOnlyList2, bool_17: true));
		Class145 class4 = Class145.class145_0.method_97(readOnlyList, readOnlyList2, class95_, 7, 30);
		num += smethod_244(Class185.smethod_0(-1141135931), Class185.smethod_0(-1141135982), Class16.smethod_3(class4));
		num += smethod_244(Class185.smethod_0(-1141135987), Class185.smethod_0(-1141164198), Class16.smethod_3(Class145.class145_0.method_97(readOnlyList, readOnlyList2, class95_, 7, 3)));
		num += smethod_244(Class185.smethod_0(-1141136019), Class185.smethod_0(-1141288269), Class16.smethod_3(Class145.class145_0.method_97(null, readOnlyList2, class95_, 7, 24)));
		num += smethod_244(Class185.smethod_0(-1141136069), Class185.smethod_0(-1141136104), Class16.smethod_3(@class));
		num += smethod_244(Class185.smethod_0(-1141136108), Class185.smethod_0(-1141136104), Class16.smethod_3(Class145.class145_0.method_97(readOnlyList, readOnlyList2, class95_, 7, 0)));
		num += smethod_244(Class185.smethod_0(-1141136147), Class185.smethod_0(-1141136104), Class16.smethod_3(Class145.class145_0.method_97(readOnlyList, readOnlyList2, class95_, 7, -6)));
		num += smethod_244(Class185.smethod_0(-1141136198), Class185.smethod_0(-1141136219), Class16.smethod_3(class2));
		num += smethod_244(Class185.smethod_0(-1141136239), Class185.smethod_0(-1141136219), Class16.smethod_3(Class145.class145_0));
		num += smethod_244(Class185.smethod_0(-1141136267), Class185.smethod_0(-1141136219), Class16.smethod_3(null));
		num += smethod_244(Class185.smethod_0(-1141136310), 0, class2.method_47());
		IReadOnlyList<Struct27> readOnlyList4 = Class119.smethod_40(JObject.Parse(Class185.smethod_0(-1141136337)));
		num += smethod_244(Class185.smethod_0(-1141135520), 1, readOnlyList4.Count);
		if (readOnlyList4.Count == 1)
		{
			num += smethod_244(Class185.smethod_0(-1141135559), 5, readOnlyList4[0].int_0);
			num += smethod_244(Class185.smethod_0(-1141135591), 3, readOnlyList4[0].int_2);
		}
		num += smethod_244(Class185.smethod_0(-1141135622), 0, Class119.smethod_40(JObject.Parse(Class185.smethod_0(-1141129340))).Count);
		num += smethod_244(Class185.smethod_0(-1141135656), 0, Class119.smethod_40(null).Count);
		JObject jobject_5 = JObject.Parse(Class185.smethod_0(-1141135683));
		smethod_222(jobject_5, dictionary);
		num += smethod_244(Class185.smethod_0(-1141135789), 8, dictionary.Count);
		List<string[]> list3 = Class16.smethod_2(Class145.class145_0.method_97(Class119.smethod_40(jobject_5), readOnlyList2, new Class95(null, dictionary, null), 8, Class119.smethod_41(jobject_5)));
		num += smethod_244(Class185.smethod_0(-1141135825), 1, list3.Count);
		if (list3.Count == 1)
		{
			num += smethod_244(Class185.smethod_0(-1141135866), Class185.smethod_0(-1141132869), list3[0][1]);
		}
		Dictionary<string, string> dictionary3 = new Dictionary<string, string>(StringComparer.Ordinal);
		dictionary3[Class185.smethod_0(-1141312873)] = Class185.smethod_0(-1141136937);
		num += smethod_244(Class185.smethod_0(-1141136955), Class185.smethod_0(-1141136937), Class16.smethod_5(new Class95(null, dictionary3, null), 9, 9));
		num += smethod_244(Class185.smethod_0(-1141137006), 1000, 1000);
		num += smethod_243(Class185.smethod_0(-1141137030), Class16.smethod_0(-1L, 0L));
		num += smethod_243(Class185.smethod_0(-1141137062), !Class16.smethod_0(0L, 999L));
		num += smethod_243(Class185.smethod_0(-1141137097), Class16.smethod_0(0L, 1000L));
		num += smethod_243(Class185.smethod_0(-1141137135), !Class16.smethod_0(5000L, 5999L));
		num += smethod_243(Class185.smethod_0(-1141137166), Class16.smethod_0(5000L, 6000L));
		Class145 class5 = @class.method_93(new Class83
		{
			float_0 = 1f,
			float_1 = 2f,
			float_2 = 3f
		}, 2, 0);
		num += smethod_244(Class185.smethod_0(-1141137193), 3, class5.method_39().Count);
		num += smethod_244(Class185.smethod_0(-1141137239), 12, class5.method_41().Count);
		num += smethod_244(Class185.smethod_0(-1141137275), 7, class5.method_43());
		num += smethod_244(Class185.smethod_0(-1141137325), 30, class4.method_93(new Class83
		{
			float_0 = 1f,
			float_1 = 2f,
			float_2 = 3f
		}, 2, 0).method_47());
		num += smethod_244(Class185.smethod_0(-1141137367), 60, @class.method_93(new Class83
		{
			float_0 = 1f,
			float_1 = 2f,
			float_2 = 3f
		}, 2, 0).method_49());
		num += smethod_244(Class185.smethod_0(-1141136397), Class185.smethod_0(-1141135982), Class16.smethod_3(class4.method_93(null, 2, 0)));
		Class145 class6 = class2.method_95(null, null, null, default(GStruct4), 3, 0);
		num += smethod_244(Class185.smethod_0(-1141136438), Class185.smethod_0(-1141129807), class6.method_51());
		num += smethod_244(Class185.smethod_0(-1141136479), 0, class6.method_43());
		num += smethod_244(Class185.smethod_0(-1141136522), 0, class6.method_47());
		num += smethod_244(Class185.smethod_0(-1141136581), 30, class4.method_95(null, null, null, default(GStruct4), 3, 0).method_47());
		num += smethod_244(Class185.smethod_0(-1141136617), 60, @class.method_95(null, null, null, default(GStruct4), 3, 0).method_49());
		num += smethod_244(Class185.smethod_0(-1141136673), 0, Class145.class145_0.method_39().Count);
		num += smethod_244(Class185.smethod_0(-1141136706), 0, Class145.class145_0.method_41().Count);
		num += smethod_244(Class185.smethod_0(-1141136746), 0, Class145.class145_0.method_43());
		num += smethod_244(Class185.smethod_0(-1141136777), 0, Class145.class145_0.method_47());
		num += smethod_244(Class185.smethod_0(-1141136816), string.Empty, Class145.class145_0.method_51());
		string text4 = smethod_174(ref num);
		if (text4 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141136843), text4.Contains(Class185.smethod_0(-1141136892)));
			num += smethod_243(Class185.smethod_0(-1141133846), text4.Contains(Class185.smethod_0(-1141133884)));
			num += smethod_243(Class185.smethod_0(-1141134007), text4.Contains(Class185.smethod_0(-1141134054)));
			num += smethod_243(Class185.smethod_0(-1141134135), text4.Contains(Class185.smethod_0(-1141134179)));
			num += smethod_243(Class185.smethod_0(-1141134248), text4.Contains(Class185.smethod_0(-1141134293)));
			num += smethod_243(Class185.smethod_0(-1141134314), text4.Contains(Class185.smethod_0(-1141133337)));
			num += smethod_243(Class185.smethod_0(-1141133374), text4.Contains(Class185.smethod_0(-1141133411)));
			num += smethod_243(Class185.smethod_0(-1141133448), text4.Contains(Class185.smethod_0(-1141133494)));
			num += smethod_243(Class185.smethod_0(-1141133525), text4.Contains(Class185.smethod_0(-1141133574)));
			num += smethod_243(Class185.smethod_0(-1141133601), text4.Contains(Class185.smethod_0(-1141133662)));
			num += smethod_243(Class185.smethod_0(-1141133684), text4.Contains(Class185.smethod_0(-1141133742) + 0 + Class185.smethod_0(-1141133763)));
			num += smethod_243(Class185.smethod_0(-1141133771), text4.Contains(Class185.smethod_0(-1141134856)));
			num += smethod_243(Class185.smethod_0(-1141134872), text4.Contains(Class185.smethod_0(-1141134913) + 12 + Class185.smethod_0(-1141133763)));
			num += smethod_243(Class185.smethod_0(-1141134938), text4.Contains(Class185.smethod_0(-1141134986) + ushort.MaxValue + Class185.smethod_0(-1141133763)));
			num += smethod_243(Class185.smethod_0(-1141135023), text4.Contains(Class185.smethod_0(-1141135074)));
			num += smethod_243(Class185.smethod_0(-1141135102), text4.Contains(Class185.smethod_0(-1141135145)));
			num += smethod_243(Class185.smethod_0(-1141135226), text4.Contains(Class185.smethod_0(-1141135282)));
			num += smethod_243(Class185.smethod_0(-1141135341), text4.Contains(Class185.smethod_0(-1141134381)));
			num += smethod_243(Class185.smethod_0(-1141134458), text4.Contains(Class185.smethod_0(-1141134528)));
			num += smethod_243(Class185.smethod_0(-1141134563), text4.Contains(Class185.smethod_0(-1141134631)));
		}
		MethodInfo methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		FieldInfo field = typeof(Class357).GetField(Class185.smethod_0(-1141134663), BindingFlags.Static | BindingFlags.NonPublic);
		num += smethod_243(Class185.smethod_0(-1141134691), methodInfo != null && field != null);
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
					((TabControl)class7.gform0_0.Controls.Find(Class185.smethod_0(-1141277980), searchAllChildren: true)[0]).SelectedIndex = 0;
					methodInfo.Invoke(class7.gform0_0, new object[1] { class7.gform0_0.method_5() });
					num += smethod_243(Class185.smethod_0(-1141134721), class8.list_0.Count == 1 && class8.list_0[0].Contains(Class185.smethod_0(-1141134762)));
					methodInfo.Invoke(class7.gform0_0, new object[1] { class7.gform0_0.method_5() });
					num += smethod_244(Class185.smethod_0(-1141134780), 1, class8.list_0.Count);
					smethod_94(class7.gform0_0, Class185.smethod_0(-1141134810), -10000L);
					methodInfo.Invoke(class7.gform0_0, new object[1] { class7.gform0_0.method_5() });
					num += smethod_244(Class185.smethod_0(-1141134828), 2, class8.list_0.Count);
					class7.method_0(Class145.class145_0.method_97(new Struct27[0], new Struct19[0], Class95.class95_0, 1, 24), bool_0: true);
					smethod_94(class7.gform0_0, Class185.smethod_0(-1141134810), -10000L);
					methodInfo.Invoke(class7.gform0_0, new object[1] { class7.gform0_0.method_5() });
					num += smethod_244(Class185.smethod_0(-1141139991), 3, class8.list_0.Count);
					class7.method_0(Class145.class145_0, bool_0: false);
					smethod_94(class7.gform0_0, Class185.smethod_0(-1141134810), -10000L);
					methodInfo.Invoke(class7.gform0_0, new object[1] { class7.gform0_0.method_5() });
					num += smethod_244(Class185.smethod_0(-1141140024), 3, class8.list_0.Count);
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
		string text5 = smethod_173(Class185.smethod_0(-1141258080), ref num);
		if (text5 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141140064), !text5.Contains(Class185.smethod_0(-1141140104)));
		}
		Console.WriteLine(Class185.smethod_0(-1141140128) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_153()
	{
		int num = 0;
		num = 0 + smethod_243(Class185.smethod_0(-1141140132), Class357.smethod_15(smethod_230(Class357.valueTuple_23), out var string_));
		num += smethod_243(Class185.smethod_0(-1141140171), Class357.smethod_68());
		num += smethod_243(Class185.smethod_0(-1141140209), !Class357.smethod_34());
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141140264), text.Contains(Class185.smethod_0(-1141140317)));
		num += smethod_243(Class185.smethod_0(-1141140341), text.Contains(Class185.smethod_0(-1141140399)));
		num += smethod_243(Class185.smethod_0(-1141140420), text.Contains(Class185.smethod_0(-1141139457)));
		num += smethod_243(Class185.smethod_0(-1141139489), text.Contains(Class185.smethod_0(-1141139546)));
		num += smethod_243(Class185.smethod_0(-1141139582), text.Contains(Class185.smethod_0(-1141139634)));
		num += smethod_243(Class185.smethod_0(-1141139665), text.Contains(Class185.smethod_0(-1141139725)));
		num += smethod_243(Class185.smethod_0(-1141139740), text.Contains(Class185.smethod_0(-1141139796)));
		num += smethod_244(Class185.smethod_0(-1141139818), 0, 0);
		num += smethod_243(Class185.smethod_0(-1141139880), smethod_221(text, Class185.smethod_0(-1141139934), 0));
		num += smethod_243(Class185.smethod_0(-1141139946), smethod_221(text, Class185.smethod_0(-1141141017), 88));
		num += smethod_243(Class185.smethod_0(-1141141040), smethod_221(text, Class185.smethod_0(-1141158519), 184));
		num += smethod_243(Class185.smethod_0(-1141141096), Class357.smethod_15(smethod_230(Class357.valueTuple_6), out string_));
		num += smethod_243(Class185.smethod_0(-1141141136), Class357.smethod_34());
		num += smethod_243(Class185.smethod_0(-1141141175), !Class357.smethod_68());
		string text2 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141141223), text2.Contains(Class185.smethod_0(-1141139796)));
		num += smethod_243(Class185.smethod_0(-1141141266), !text2.Contains(Class185.smethod_0(-1141140317)));
		num += smethod_243(Class185.smethod_0(-1141141316), Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out string_));
		string text3 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141141363), !Class357.smethod_68());
		num += smethod_243(Class185.smethod_0(-1141141419), !text3.Contains(Class185.smethod_0(-1141140317)));
		num += smethod_243(Class185.smethod_0(-1141141479), !text3.Contains(Class185.smethod_0(-1141139634)));
		Console.WriteLine(Class185.smethod_0(-1141140502) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_154()
	{
		int num = 0;
		num = 0 + smethod_243(Class185.smethod_0(-1141140526), Class357.smethod_15(smethod_230(Class357.valueTuple_22), out var string_));
		num += smethod_243(Class185.smethod_0(-1141140558), Class357.smethod_66());
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141140590), text.Contains(Class185.smethod_0(-1141140645)));
		num += smethod_243(Class185.smethod_0(-1141140679), text.Contains(Class185.smethod_0(-1141140715)));
		num += smethod_243(Class185.smethod_0(-1141140738), smethod_221(text, Class185.smethod_0(-1141158519), 184));
		num += smethod_244(Class185.smethod_0(-1141140786), 0, 0);
		num += smethod_244(Class185.smethod_0(-1141140840), 0, 0);
		num += smethod_243(Class185.smethod_0(-1141140868), smethod_221(text, Class185.smethod_0(-1141140928), 0));
		num += smethod_243(Class185.smethod_0(-1141140946), smethod_221(text, Class185.smethod_0(-1141140992), 0));
		num += smethod_243(Class185.smethod_0(-1141137924), smethod_221(text, Class185.smethod_0(-1141137964), 152));
		num += smethod_243(Class185.smethod_0(-1141137980), smethod_221(text, Class185.smethod_0(-1141138031), 176));
		num += smethod_243(Class185.smethod_0(-1141138042), smethod_221(text, Class185.smethod_0(-1141138088), 8));
		num += smethod_243(Class185.smethod_0(-1141138102), smethod_221(text, Class185.smethod_0(-1141138132), 16));
		num += smethod_243(Class185.smethod_0(-1141138146), smethod_221(text, Class185.smethod_0(-1141138186), 17));
		num += smethod_243(Class185.smethod_0(-1141138202), smethod_221(text, Class185.smethod_0(-1141138241), 24));
		num += smethod_243(Class185.smethod_0(-1141138264), smethod_221(text, Class185.smethod_0(-1141138297), 18));
		num += smethod_243(Class185.smethod_0(-1141138314), smethod_221(text, Class185.smethod_0(-1141138353), 20));
		num += smethod_243(Class185.smethod_0(-1141138376), smethod_221(text, Class185.smethod_0(-1141138415), 22));
		num += smethod_243(Class185.smethod_0(-1141138430), smethod_221(text, Class185.smethod_0(-1141137446), 23));
		num += smethod_243(Class185.smethod_0(-1141137462), smethod_221(text, Class185.smethod_0(-1141137502), 32));
		num += smethod_243(Class185.smethod_0(-1141137518), smethod_221(text, Class185.smethod_0(-1141137558), 16));
		num += smethod_243(Class185.smethod_0(-1141137574), smethod_221(text, Class185.smethod_0(-1141137613), 24));
		num += smethod_243(Class185.smethod_0(-1141137620), bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141137661), bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141137695), bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141137722), bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141137755), bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141137799), bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141137827), bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141137865), bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141137916), Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out string_));
		string text2 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141138979), !text2.Contains(Class185.smethod_0(-1141139039)));
		num += smethod_243(Class185.smethod_0(-1141139072), !text2.Contains(Class185.smethod_0(-1141139105)));
		num += smethod_243(Class185.smethod_0(-1141139135), !Class357.smethod_66());
		num += smethod_243(Class185.smethod_0(-1141139171), Class357.smethod_15(smethod_230(Class357.valueTuple_16), out string_));
		string text3 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141139208), text3.Contains(Class185.smethod_0(-1141171195)));
		num += smethod_243(Class185.smethod_0(-1141139250), !text3.Contains(Class185.smethod_0(-1141139105)));
		num += smethod_243(Class185.smethod_0(-1141139303), !Class357.smethod_66());
		num += smethod_243(Class185.smethod_0(-1141139346), Class357.smethod_15(smethod_230(Class357.valueTuple_22), out string_));
		string text4 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141139379), text4.Contains(Class185.smethod_0(-1141171195)));
		num += smethod_243(Class185.smethod_0(-1141139433), !text4.Contains(Class185.smethod_0(-1141158677)));
		num += smethod_243(Class185.smethod_0(-1141138472), !Class357.smethod_54());
		num += smethod_243(Class185.smethod_0(-1141138515), Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out string_));
		string text5 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141138546), !Class357.smethod_40());
		num += smethod_243(Class185.smethod_0(-1141138592), !text5.Contains(Class185.smethod_0(-1141138629)));
		num += smethod_243(Class185.smethod_0(-1141138655), Class357.smethod_15(smethod_230(Class357.valueTuple_9), out string_));
		string text6 = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141138673), Class357.smethod_40());
		num += smethod_243(Class185.smethod_0(-1141138699), text6.Contains(Class185.smethod_0(-1141138739)));
		num += smethod_243(Class185.smethod_0(-1141138774), !Class357.smethod_66());
		num += smethod_244(Class185.smethod_0(-1141138823), 1, Class357.valueTuple_9.Length);
		num += smethod_244(Class185.smethod_0(-1141138847), Class185.smethod_0(-1141275455), Class357.valueTuple_9[0].Item1);
		num += smethod_244(Class185.smethod_0(-1141138860), Class185.smethod_0(-1141275518), Class357.valueTuple_9[0].Item2);
		num += smethod_244(Class185.smethod_0(-1141138881), Class185.smethod_0(-1141138911), Class347.smethod_0());
		num += smethod_244(Class185.smethod_0(-1141138935), (sbyte)(-1), (sbyte)(-1));
		num += smethod_244(Class185.smethod_0(-1141144080), 0, 0);
		num += smethod_244(Class185.smethod_0(-1141144114), string.Empty, string.Empty);
		num += smethod_243(Class185.smethod_0(-1141144146), bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141144192), Class347.smethod_1(Class185.smethod_0(-1141305020)));
		num += smethod_243(Class185.smethod_0(-1141144223), Class347.smethod_1(Class185.smethod_0(-1141144254)));
		num += smethod_243(Class185.smethod_0(-1141144258), Class347.smethod_1(Class185.smethod_0(-1141144302)));
		num += smethod_243(Class185.smethod_0(-1141144319), !Class347.smethod_1(Class185.smethod_0(-1141144353)));
		num += smethod_243(Class185.smethod_0(-1141144375), !Class347.smethod_1(null));
		num += smethod_243(Class185.smethod_0(-1141144401), Class347.smethod_2(Class185.smethod_0(-1141144302)));
		num += smethod_243(Class185.smethod_0(-1141144445), !Class347.smethod_2(Class185.smethod_0(-1141305020)));
		num += smethod_243(Class185.smethod_0(-1141144480), !Class347.smethod_2(Class185.smethod_0(-1141144254)));
		JObject jobject_ = JObject.Parse(Class185.smethod_0(-1141144507));
		string text7 = Class119.smethod_50(jobject_);
		num += smethod_244(Class185.smethod_0(-1141143839), Class185.smethod_0(-1141305020), text7);
		num += smethod_244(Class185.smethod_0(-1141143860), string.Empty, Class119.smethod_51(jobject_, text7, bool_17: true));
		int int_;
		IReadOnlyList<Struct140> readOnlyList = Class119.smethod_52(jobject_, out int_);
		num += smethod_244(Class185.smethod_0(-1141143903), 5, readOnlyList.Count);
		num += smethod_244(Class185.smethod_0(-1141143928), 0, int_);
		if (readOnlyList.Count == 5)
		{
			num += smethod_244(Class185.smethod_0(-1141143958), Class185.smethod_0(-1141143983), readOnlyList[0].string_0);
			num += smethod_244(Class185.smethod_0(-1141143986), 1001, readOnlyList[0].int_0);
			num += smethod_244(Class185.smethod_0(-1141144009), (ushort)120, readOnlyList[0].ushort_0);
			num += smethod_244(Class185.smethod_0(-1141144035), (byte)2, readOnlyList[0].byte_1);
			num += smethod_244(Class185.smethod_0(-1141145090), (byte)1, readOnlyList[0].byte_2);
			num += smethod_244(Class185.smethod_0(-1141145122), Class185.smethod_0(-1141145154), readOnlyList[1].string_0);
			num += smethod_244(Class185.smethod_0(-1141145173), (sbyte)(-1), readOnlyList[1].sbyte_0);
			num += smethod_244(Class185.smethod_0(-1141145205), Class185.smethod_0(-1141145237), readOnlyList[2].string_0);
			num += smethod_243(Class185.smethod_0(-1141145248), !readOnlyList[2].bool_0);
			num += smethod_243(Class185.smethod_0(-1141145273), readOnlyList[2].bool_1);
			num += smethod_244(Class185.smethod_0(-1141145313), Class185.smethod_0(-1141145345), readOnlyList[3].string_0);
			num += smethod_243(Class185.smethod_0(-1141145355), !readOnlyList[3].bool_1);
			num += smethod_243(Class185.smethod_0(-1141145395), !readOnlyList[3].bool_0);
			num += smethod_244(Class185.smethod_0(-1141145446), Class185.smethod_0(-1141145479), readOnlyList[4].string_0);
			num += smethod_244(Class185.smethod_0(-1141145493), (byte)1, readOnlyList[4].byte_0);
		}
		Class145 @class = Class145.class145_0.method_109(readOnlyList, text7, 4, int_);
		num += smethod_244(Class185.smethod_0(-1141145513), 5, @class.method_73().Count);
		num += smethod_244(Class185.smethod_0(-1141145550), Class185.smethod_0(-1141305020), @class.method_75());
		num += smethod_244(Class185.smethod_0(-1141145571), 4, @class.method_77());
		num += smethod_244(Class185.smethod_0(-1141144582), string.Empty, @class.method_81());
		Class145 class2 = @class.method_93(null, 9, 0);
		num += smethod_244(Class185.smethod_0(-1141144609), 5, class2.method_73().Count);
		num += smethod_244(Class185.smethod_0(-1141144653), Class185.smethod_0(-1141305020), class2.method_75());
		JObject jobject_2 = JObject.Parse(Class185.smethod_0(-1141144695));
		JObject jobject_3 = JObject.Parse(Class185.smethod_0(-1141144792));
		string text8 = Class119.smethod_50(jobject_2);
		string text9 = Class119.smethod_50(jobject_3);
		num += smethod_244(Class185.smethod_0(-1141144894), Class185.smethod_0(-1141144254), text8);
		num += smethod_244(Class185.smethod_0(-1141144920), Class185.smethod_0(-1141144302), text9);
		num += smethod_244(Class185.smethod_0(-1141144951), string.Empty, Class119.smethod_51(jobject_2, text8, bool_17: true));
		num += smethod_244(Class185.smethod_0(-1141144978), string.Empty, Class119.smethod_51(jobject_3, text9, bool_17: true));
		num += smethod_244(Class185.smethod_0(-1141145018), 0, Class119.smethod_52(jobject_2, out var int_2).Count);
		num += smethod_244(Class185.smethod_0(-1141145063), 0, Class119.smethod_52(jobject_3, out var int_3).Count);
		num += smethod_244(Class185.smethod_0(-1141142025), 0, int_2);
		num += smethod_244(Class185.smethod_0(-1141142069), 0, int_3);
		num += smethod_243(Class185.smethod_0(-1141142110), !Class347.smethod_2(text8));
		num += smethod_243(Class185.smethod_0(-1141142136), Class347.smethod_2(text9));
		JObject jobject_4 = JObject.Parse(Class185.smethod_0(-1141142167));
		num += smethod_244(Class185.smethod_0(-1141142228), Class185.smethod_0(-1141142275), Class119.smethod_51(jobject_4, Class119.smethod_50(jobject_4), bool_17: false));
		JObject jobject_5 = JObject.Parse(Class185.smethod_0(-1141142307));
		num += smethod_244(Class185.smethod_0(-1141142340), Class185.smethod_0(-1141267684), Class119.smethod_51(jobject_5, null, bool_17: false));
		JObject jobject_6 = JObject.Parse(Class185.smethod_0(-1141142385));
		num += smethod_244(Class185.smethod_0(-1141142446), Class185.smethod_0(-1141142480), Class119.smethod_51(jobject_6, Class119.smethod_50(jobject_6), bool_17: true));
		JObject jobject_7 = JObject.Parse(Class185.smethod_0(-1141141517));
		num += smethod_243(Class185.smethod_0(-1141141580), Class119.smethod_50(jobject_7) == null);
		num += smethod_244(Class185.smethod_0(-1141141630), Class185.smethod_0(-1141142480), Class119.smethod_51(jobject_7, Class119.smethod_50(jobject_7), bool_17: true));
		JObject jobject_8 = JObject.Parse(Class185.smethod_0(-1141141669));
		num += smethod_244(Class185.smethod_0(-1141141722), Class185.smethod_0(-1141130794), Class119.smethod_51(jobject_8, Class119.smethod_50(jobject_8), bool_17: false));
		num += smethod_244(Class185.smethod_0(-1141141754), Class185.smethod_0(-1141267684), Class119.smethod_51(null, null, bool_17: true));
		Class145 class3 = Class145.class145_0.method_109(new Struct140[1], Class185.smethod_0(-1141305020), 3, 0).method_110(Class185.smethod_0(-1141142275));
		num += smethod_244(Class185.smethod_0(-1141141792), 0, class3.method_73().Count);
		num += smethod_244(Class185.smethod_0(-1141141829), 0, class3.method_77());
		num += smethod_244(Class185.smethod_0(-1141141860), string.Empty, class3.method_75());
		num += smethod_244(Class185.smethod_0(-1141141897), Class185.smethod_0(-1141142275), class3.method_81());
		JObject jobject_9 = JObject.Parse(Class185.smethod_0(-1141141944));
		int int_4;
		IReadOnlyList<Struct140> readOnlyList2 = Class119.smethod_52(jobject_9, out int_4);
		num += smethod_244(Class185.smethod_0(-1141143272), 2, readOnlyList2.Count);
		num += smethod_244(Class185.smethod_0(-1141143300), 5, int_4);
		if (readOnlyList2.Count == 2)
		{
			num += smethod_244(Class185.smethod_0(-1141143338), Class185.smethod_0(-1141143375), readOnlyList2[0].string_0);
			num += smethod_244(Class185.smethod_0(-1141143378), Class185.smethod_0(-1141143414), readOnlyList2[1].string_0);
		}
		num += smethod_244(Class185.smethod_0(-1141143417), string.Empty, Class119.smethod_51(jobject_9, Class119.smethod_50(jobject_9), bool_17: true));
		Class145 class4 = Class145.class145_0.method_109(readOnlyList2, Class185.smethod_0(-1141305020), 6, int_4);
		num += smethod_244(Class185.smethod_0(-1141143458), 5, class4.method_79());
		string text10 = smethod_174(ref num);
		if (text10 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141143512), text10.Contains(Class185.smethod_0(-1141142537)));
			num += smethod_243(Class185.smethod_0(-1141142567), text10.Contains(Class185.smethod_0(-1141142614)));
			num += smethod_243(Class185.smethod_0(-1141142720), text10.Contains(Class185.smethod_0(-1141142763)));
			num += smethod_243(Class185.smethod_0(-1141142832), text10.Contains(Class185.smethod_0(-1141142884)) && text10.Contains(Class185.smethod_0(-1141142905)));
			num += smethod_243(Class185.smethod_0(-1141142944), text10.Contains(Class185.smethod_0(-1141142997)));
			num += smethod_243(Class185.smethod_0(-1141115426), text10.Contains(Class185.smethod_0(-1141115477)));
			num += smethod_244(Class185.smethod_0(-1141115508), 3000, 3000);
			num += smethod_243(Class185.smethod_0(-1141115552), text10.Contains(Class185.smethod_0(-1141115605)));
			num += smethod_243(Class185.smethod_0(-1141115662), text10.Contains(Class185.smethod_0(-1141115708)));
			num += smethod_243(Class185.smethod_0(-1141115754), !text10.Contains(Class185.smethod_0(-1141115819)));
			num += smethod_243(Class185.smethod_0(-1141115854), text10.Contains(Class185.smethod_0(-1141114882)));
			num += smethod_243(Class185.smethod_0(-1141114936), text10.Contains(Class185.smethod_0(-1141114982)));
			num += smethod_243(Class185.smethod_0(-1141115008), text10.Contains(Class185.smethod_0(-1141115051)));
			num += smethod_243(Class185.smethod_0(-1141115089), text10.Contains(Class185.smethod_0(-1141115131)));
			num += smethod_243(Class185.smethod_0(-1141115179), text10.Contains(Class185.smethod_0(-1141115220)));
			int num2 = text10.IndexOf(Class185.smethod_0(-1141115266), StringComparison.Ordinal);
			int num3 = text10.IndexOf(Class185.smethod_0(-1141115298), StringComparison.Ordinal);
			num += smethod_243(Class185.smethod_0(-1141115360), num2 >= 0);
			num += smethod_243(Class185.smethod_0(-1141116428), num3 >= 0);
			num += smethod_243(Class185.smethod_0(-1141116481), num2 >= 0 && num3 > num2);
			num += smethod_243(Class185.smethod_0(-1141116541), text10.Contains(Class185.smethod_0(-1141116588)));
			num += smethod_243(Class185.smethod_0(-1141116614), text10.Contains(Class185.smethod_0(-1141116657)));
			num += smethod_243(Class185.smethod_0(-1141116745), text10.Contains(Class185.smethod_0(-1141116806)));
			num += smethod_243(Class185.smethod_0(-1141116875), text10.Contains(Class185.smethod_0(-1141115906)));
			num += smethod_243(Class185.smethod_0(-1141115974), text10.Contains(Class185.smethod_0(-1141116030)));
			num += smethod_243(Class185.smethod_0(-1141116097), text10.Contains(Class185.smethod_0(-1141116146)));
			num += smethod_243(Class185.smethod_0(-1141116202), Class347.smethod_1(Class185.smethod_0(-1141305020)) && Class347.smethod_1(Class185.smethod_0(-1141144254)) && Class347.smethod_1(Class185.smethod_0(-1141144302)));
			string text11 = smethod_220(text10);
			num += smethod_243(Class185.smethod_0(-1141116243), text11.Length != 0);
			num += smethod_243(Class185.smethod_0(-1141116282), text11.Contains(Class185.smethod_0(-1141116337)));
			num += smethod_243(Class185.smethod_0(-1141116373), text11.Contains(Class185.smethod_0(-1141116414)));
			num += smethod_243(Class185.smethod_0(-1141113348), !text11.Contains(Class185.smethod_0(-1141113401)));
			num += smethod_243(Class185.smethod_0(-1141113419), !text11.Contains(Class185.smethod_0(-1141113485)) && !text11.Contains(Class185.smethod_0(-1141113503)));
		}
		num += smethod_218();
		Console.WriteLine(Class185.smethod_0(-1141113520) + num + Class185.smethod_0(-1141356690));
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
		num = 0 + smethod_244(Class185.smethod_0(-1141113536), Class185.smethod_0(-1141113560), Class409.smethod_0(77, ireadOnlyList_));
		Class119 class2 = new Class119();
		@class.string_0 = null;
		class2.method_30(@class.method_0);
		class2.method_169(0, 9, 2, 11, 1);
		num += smethod_244(Class185.smethod_0(-1141113666), Class185.smethod_0(-1141113702), @class.string_0);
		JObject jobject_ = JObject.Parse(Class185.smethod_0(-1141113770));
		IReadOnlyList<Class78> readOnlyList = Class119.smethod_45(jobject_, Class119.smethod_44(jobject_), ireadOnlyList_);
		num += smethod_243(Class185.smethod_0(-1141112946), readOnlyList != null && readOnlyList.Count == 2 && readOnlyList[0].int_0 == 9 && readOnlyList[0].int_1 == 2 && readOnlyList[0].string_0 == Class185.smethod_0(-1141112980));
		Dictionary<string, string> dictionary_ = new Dictionary<string, string>(StringComparer.Ordinal) { 
		{
			Class185.smethod_0(-1141356755),
			Class185.smethod_0(-1141312985)
		} };
		Dictionary<string, string> dictionary_2 = new Dictionary<string, string>(StringComparer.Ordinal) { 
		{
			Class185.smethod_0(-1141163423),
			Class185.smethod_0(-1141163427)
		} };
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
			List<Struct96> list = Class385.smethod_5(class3.gform0_0, new List<string> { Class185.smethod_0(-1141312985) });
			num += smethod_244(Class185.smethod_0(-1141112999), 2, list.Count);
			num += smethod_243(Class185.smethod_0(-1141113032), list.Count == 2 && list[0].int_0 == 8 && list[1].int_0 == 3);
			num += smethod_244(Class185.smethod_0(-1141113067), 0, Class385.smethod_5(class3.gform0_0, new List<string> { Class185.smethod_0(-1141113109) }).Count);
		}
		finally
		{
			((IDisposable)class3).Dispose();
		}
		Console.WriteLine(Class185.smethod_0(-1141113120) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	private static int smethod_158()
	{
		int num = 0;
		num = 0 + smethod_244(Class185.smethod_0(-1141113133), Class185.smethod_0(-1141113159), Class387.smethod_0(7, 232, 18));
		num += smethod_244(Class185.smethod_0(-1141113202), Class185.smethod_0(-1141113235), Class30.smethod_0(Class185.smethod_0(-1141113312), 8, 232, 20));
		Console.WriteLine(Class185.smethod_0(-1141113314) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	private static Class409.Struct125[] smethod_159(Class119 class119_0)
	{
		FieldInfo field = typeof(Class119).GetField(Class185.smethod_0(-1141113329), BindingFlags.Instance | BindingFlags.NonPublic);
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
		FieldInfo field = typeof(Class145).GetField(Class185.smethod_0(-1141114381), BindingFlags.Instance | BindingFlags.NonPublic);
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
		int num = string_0.IndexOf(Class185.smethod_0(-1141114413), StringComparison.Ordinal);
		if (num < 0)
		{
			return string.Empty;
		}
		int num2 = string_0.IndexOf(Class185.smethod_0(-1141114439), num, StringComparison.Ordinal);
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
		FieldInfo field = typeof(Class119).GetField(Class185.smethod_0(-1141259613), BindingFlags.Instance | BindingFlags.NonPublic);
		FieldInfo field2 = typeof(Class119).GetField(Class185.smethod_0(-1141259787), BindingFlags.Instance | BindingFlags.NonPublic);
		PropertyInfo property = typeof(Class119).GetProperty(Class185.smethod_0(-1141114459), BindingFlags.Instance | BindingFlags.NonPublic);
		@class.methodInfo_0 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		EventInfo eventInfo = typeof(Class119).GetEvent(Class185.smethod_0(-1141114486), BindingFlags.Instance | BindingFlags.Public);
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
				if (@class.class119_0.method_28() && class2.method_1(Class54.smethod_0(Class185.smethod_0(-1141114503), @class.class119_0.int_14)) == 1 && class2.method_1(Class54.smethod_0(Class185.smethod_0(-1141114512), @class.class119_0.int_15)) == 1)
				{
					class2.method_2();
					Task task3 = Task.Run((Action)@class.method_3);
					Task task4 = Task.Run((Func<object>)@class.method_4);
					if (!Task.WhenAll(task3, task4).Wait(2000))
					{
						return false;
					}
					return ((!@class.class119_0.method_28() && !@class.class119_0.method_10()) & @class.bool_0) && @class.int_0 == 73 && class2.method_1(Class54.smethod_1(Class185.smethod_0(-1141114503))) == 1 && class2.method_1(Class54.smethod_1(Class185.smethod_0(-1141114512))) == 1;
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
		FieldInfo field = typeof(GForm0).GetField(Class185.smethod_0(-1141256027), BindingFlags.Instance | BindingFlags.NonPublic);
		PropertyInfo property = typeof(GForm0).GetProperty(Class185.smethod_0(-1141114513), BindingFlags.Instance | BindingFlags.NonPublic);
		FieldInfo field2 = typeof(Class119).GetField(Class185.smethod_0(-1141259782), BindingFlags.Instance | BindingFlags.NonPublic);
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
		@class.methodInfo_0 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		FieldInfo field = typeof(Class119).GetField(Class185.smethod_0(-1141259782), BindingFlags.Instance | BindingFlags.NonPublic);
		FieldInfo field2 = typeof(Class119).GetField(Class185.smethod_0(-1141259787), BindingFlags.Instance | BindingFlags.NonPublic);
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
				return string.IsNullOrWhiteSpace(text) ? new Class278(null, Class185.smethod_0(-1141144254)) : new Class278(text, null);
			}
			catch (Exception ex)
			{
				return new Class278(null, ex.GetType().Name);
			}
		}
		return new Class278(null, Class185.smethod_0(-1141304945));
	}

	private static Class278 smethod_169(Stream stream_0)
	{
		if (stream_0 == null)
		{
			return new Class278(null, Class185.smethod_0(-1141304945));
		}
		try
		{
			StreamReader streamReader = new StreamReader(stream_0, Encoding.UTF8, detectEncodingFromByteOrderMarks: true, 1024, leaveOpen: true);
			try
			{
				string text = streamReader.ReadToEnd();
				return string.IsNullOrWhiteSpace(text) ? new Class278(null, Class185.smethod_0(-1141144254)) : new Class278(text, null);
			}
			finally
			{
				((IDisposable)streamReader).Dispose();
			}
		}
		catch (Exception ex)
		{
			return new Class278(null, Class185.smethod_0(-1141114524) + ex.GetType().Name);
		}
	}

	private static Class278 smethod_170()
	{
		try
		{
			using Stream stream_ = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class185.smethod_0(-1141114550));
			return smethod_169(stream_);
		}
		catch (Exception ex)
		{
			return new Class278(null, Class185.smethod_0(-1141114524) + ex.GetType().Name);
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
			Console.WriteLine(Class185.smethod_0(-1141114567) + string_0 + Class185.smethod_0(-1141114581) + @class.string_1);
			int_0 += smethod_243(Class185.smethod_0(-1141114567) + string_0 + Class185.smethod_0(-1141114587), bool_0: false);
			return null;
		}
		return @class.string_0;
	}

	private static string smethod_174(ref int int_0)
	{
		Class278 @class = smethod_170();
		if (@class.string_0 == null)
		{
			Console.WriteLine(Class185.smethod_0(-1141114604) + @class.string_1);
			int_0 += smethod_243(Class185.smethod_0(-1141114635), bool_0: false);
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
				int_0 += smethod_243(Class185.smethod_0(-1141114677) + @class.string_3, bool_0: false);
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
					int_ += smethod_177(Class185.smethod_0(-1141114718) + text, bool_0);
				}
			}
		}
		Queue<MethodBase> queue = new Queue<MethodBase>();
		smethod_192(queue, typeof(Class58), Class185.smethod_0(-1141114765), 1);
		smethod_192(queue, typeof(GForm0), Class185.smethod_0(-1141114778), 1);
		smethod_192(queue, typeof(GForm0), Class185.smethod_0(-1141114806), 1);
		smethod_192(queue, typeof(GForm0), Class185.smethod_0(-1141114817), 1);
		smethod_192(queue, typeof(GForm0), Class185.smethod_0(-1141114835), 1);
		smethod_192(queue, typeof(GForm0), Class185.smethod_0(-1141302676), 0);
		smethod_192(queue, typeof(GForm0), Class185.smethod_0(-1141114861), 2);
		smethod_192(queue, typeof(GForm0), Class185.smethod_0(-1141113860), 2);
		smethod_192(queue, typeof(GForm0), Class185.smethod_0(-1141113888), 2);
		smethod_192(queue, typeof(GForm0), Class185.smethod_0(-1141113900), 2);
		smethod_192(queue, typeof(GForm0), Class185.smethod_0(-1141113924), 1);
		smethod_192(queue, typeof(GForm0), Class185.smethod_0(-1141113947), 2);
		smethod_192(queue, typeof(GForm0), Class185.smethod_0(-1141113976), 2);
		smethod_192(queue, typeof(GForm0), Class185.smethod_0(-1141113988), 0);
		smethod_192(queue, typeof(Class179), Class185.smethod_0(-1141254481), 4);
		smethod_192(queue, typeof(Class179), Class185.smethod_0(-1141254512), 4);
		smethod_192(queue, typeof(Class179), Class185.smethod_0(-1141254536), 5);
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
					int_ += smethod_177(Class185.smethod_0(-1141114017) + text2, bool_0);
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
				int_ += smethod_177(Class185.smethod_0(-1141114061) + class282_1[l].string_3, bool_0);
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
			int_0 += smethod_177(Class185.smethod_0(-1141114092) + class282_1.string_3, bool_0);
			return null;
		}
		if (!smethod_179(class282_1.string_2, out var string_, out var int_1))
		{
			int_0 += smethod_177(Class185.smethod_0(-1141114143) + class282_1.string_3, bool_0);
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
		int_0 += smethod_177(Class185.smethod_0(-1141114192) + class282_1.string_3, bool_0);
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
		string[] array = new string[5]
		{
			Class185.smethod_0(-1141114237),
			Class185.smethod_0(-1141114248),
			Class185.smethod_0(-1141114261),
			Class185.smethod_0(-1141114271),
			Class185.smethod_0(-1141114273)
		};
		bool flag2;
		do
		{
			flag2 = false;
			for (int i = 0; i < array.Length; i++)
			{
				string text2 = array[i] + Class185.smethod_0(-1141299597);
				if (text.StartsWith(text2, StringComparison.Ordinal))
				{
					if (array[i] == Class185.smethod_0(-1141114261) || array[i] == Class185.smethod_0(-1141114271) || array[i] == Class185.smethod_0(-1141114273))
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
		return text3 + Class185.smethod_0(-1141114282);
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
		string_0 = string_0.Trim().Replace(Class185.smethod_0(-1141114290), string.Empty);
		string text = string.Empty;
		while (string_0.EndsWith(Class185.smethod_0(-1141114305), StringComparison.Ordinal))
		{
			text += Class185.smethod_0(-1141114305);
			string_0 = string_0.Substring(0, string_0.Length - 2).TrimEnd();
		}
		if (string_0.StartsWith(Class185.smethod_0(-1141114314), StringComparison.Ordinal) && smethod_186(string_0, 0, '(', ')') == string_0.Length - 1)
		{
			List<string> list = smethod_187(string_0.Substring(1, string_0.Length - 2), ',');
			for (int i = 0; i < list.Count; i++)
			{
				list[i] = smethod_184(smethod_183(list[i]));
			}
			return Class185.smethod_0(-1141114314) + string.Join(Class185.smethod_0(-1141326297), list) + Class185.smethod_0(-1141308401) + text;
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
				return text2 + Class185.smethod_0(-1141281104) + string.Join(Class185.smethod_0(-1141326297), list2) + Class185.smethod_0(-1141281126) + text;
			}
		}
		return Regex.Replace(string_0, Class185.smethod_0(-1141114322), string.Empty) + text;
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
			return smethod_189(type_0.GetElementType()) + Class185.smethod_0(-1141114282);
		}
		if (type_0.IsArray)
		{
			return smethod_189(type_0.GetElementType()) + Class185.smethod_0(-1141114332) + new string(',', type_0.GetArrayRank() - 1) + Class185.smethod_0(-1141114340);
		}
		if (type_0.IsGenericParameter)
		{
			return type_0.Name;
		}
		if (type_0 == typeof(void))
		{
			return Class185.smethod_0(-1141114348);
		}
		if (type_0 == typeof(bool))
		{
			return Class185.smethod_0(-1141114367);
		}
		if (type_0 == typeof(byte))
		{
			return Class185.smethod_0(-1141119490);
		}
		if (type_0 == typeof(short))
		{
			return Class185.smethod_0(-1141119509);
		}
		if (type_0 == typeof(ushort))
		{
			return Class185.smethod_0(-1141119513);
		}
		if (type_0 == typeof(int))
		{
			return Class185.smethod_0(-1141119534);
		}
		if (type_0 == typeof(uint))
		{
			return Class185.smethod_0(-1141119544);
		}
		if (type_0 == typeof(long))
		{
			return Class185.smethod_0(-1141119547);
		}
		if (type_0 == typeof(ulong))
		{
			return Class185.smethod_0(-1141119566);
		}
		if (type_0 == typeof(float))
		{
			return Class185.smethod_0(-1141119570);
		}
		if (type_0 == typeof(double))
		{
			return Class185.smethod_0(-1141119590);
		}
		if (type_0 == typeof(char))
		{
			return Class185.smethod_0(-1141119595);
		}
		if (type_0 == typeof(string))
		{
			return Class185.smethod_0(-1141119614);
		}
		if (type_0 == typeof(object))
		{
			return Class185.smethod_0(-1141119619);
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
			if (genericTypeDefinition.FullName != null && genericTypeDefinition.FullName.StartsWith(Class185.smethod_0(-1141119640), StringComparison.Ordinal))
			{
				return Class185.smethod_0(-1141114314) + string.Join(Class185.smethod_0(-1141326297), array) + Class185.smethod_0(-1141308401);
			}
			string text = genericTypeDefinition.Name;
			int num = text.IndexOf('`');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			return text + Class185.smethod_0(-1141281104) + string.Join(Class185.smethod_0(-1141326297), array) + Class185.smethod_0(-1141281126);
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
		return text + Class185.smethod_0(-1141119657) + methodBase_0.Name + Class185.smethod_0(-1141119666) + smethod_188(methodBase_0) + Class185.smethod_0(-1141114314) + string.Join(Class185.smethod_0(-1141326297), array) + Class185.smethod_0(-1141308401);
	}

	private static string smethod_191(Type type_0)
	{
		if (type_0 == null)
		{
			return Class185.smethod_0(-1141119674);
		}
		if (type_0.IsByRef)
		{
			return smethod_191(type_0.GetElementType()) + Class185.smethod_0(-1141114282);
		}
		if (type_0.IsPointer)
		{
			return smethod_191(type_0.GetElementType()) + Class185.smethod_0(-1141119695);
		}
		if (type_0.IsArray)
		{
			return smethod_191(type_0.GetElementType()) + Class185.smethod_0(-1141114332) + new string(',', type_0.GetArrayRank() - 1) + Class185.smethod_0(-1141114340);
		}
		if (type_0.IsGenericParameter)
		{
			return ((type_0.DeclaringMethod == null) ? Class185.smethod_0(-1141119712) : Class185.smethod_0(-1141119703)) + type_0.GenericParameterPosition;
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
			return text.Replace('+', '.') + Class185.smethod_0(-1141281104) + string.Join(Class185.smethod_0(-1141326297), array) + Class185.smethod_0(-1141281126);
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
		MethodBase methodBase = ((!(methodBase_0.Name == Class185.smethod_0(-1141119720)) || !(methodBase_0.DeclaringType != null) || !dictionary_0.TryGetValue(methodBase_0.DeclaringType, out value)) ? methodBase_0 : value);
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
		return asyncStateMachineAttribute.StateMachineType.GetMethod(Class185.smethod_0(-1141119720), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
	}

	private static bool smethod_195(MethodBase methodBase_0)
	{
		if (!(methodBase_0 == null) && !(methodBase_0.DeclaringType == null) && !(methodBase_0.DeclaringType.Assembly != typeof(Class198).Assembly))
		{
			if (methodBase_0.DeclaringType == typeof(GForm0))
			{
				return true;
			}
			return methodBase_0.DeclaringType.Namespace == Class185.smethod_0(-1141119735);
		}
		return false;
	}

	private static bool smethod_196(MethodBase methodBase_0)
	{
		if (!methodBase_0.IsConstructor && !methodBase_0.Name.StartsWith(Class185.smethod_0(-1141119768), StringComparison.Ordinal) && !methodBase_0.Name.StartsWith(Class185.smethod_0(-1141119771), StringComparison.Ordinal) && !methodBase_0.Name.StartsWith(Class185.smethod_0(-1141281104), StringComparison.Ordinal) && !methodBase_0.IsDefined(typeof(CompilerGeneratedAttribute), inherit: false))
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
		smethod_200(hashSet, typeof(GForm0), Class185.smethod_0(-1141114513));
		smethod_200(hashSet, typeof(GForm0), Class185.smethod_0(-1141119790));
		smethod_200(hashSet, typeof(GForm0), Class185.smethod_0(-1141119801));
		smethod_199(hashSet, typeof(GForm0), Class185.smethod_0(-1141119829), Array.Empty<Type>());
		smethod_199(hashSet, typeof(GForm0), Class185.smethod_0(-1141119843), Array.Empty<Type>());
		smethod_199(hashSet, typeof(GForm0), Class185.smethod_0(-1141119859), new Type[1] { typeof(Class148) });
		smethod_200(hashSet, typeof(Class119), Class185.smethod_0(-1141119889));
		smethod_200(hashSet, typeof(Class119), Class185.smethod_0(-1141119905));
		smethod_200(hashSet, typeof(Class119), Class185.smethod_0(-1141119925));
		smethod_200(hashSet, typeof(Class119), Class185.smethod_0(-1141119944));
		smethod_200(hashSet, typeof(Class119), Class185.smethod_0(-1141119960));
		smethod_200(hashSet, typeof(Class119), Class185.smethod_0(-1141119982));
		smethod_200(hashSet, typeof(Class119), Class185.smethod_0(-1141119995));
		smethod_200(hashSet, typeof(Class119), Class185.smethod_0(-1141119000));
		smethod_201(hashSet, typeof(Class119), Class185.smethod_0(-1141114486));
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119011), Array.Empty<Type>());
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119032), new Type[4]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		});
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119044), new Type[3]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		});
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119060), new Type[2]
		{
			typeof(ushort),
			typeof(IReadOnlyList<Class409.Struct125>)
		});
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141276804), new Type[1] { typeof(uint) });
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141302295), Array.Empty<Type>());
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119074), new Type[3]
		{
			typeof(int),
			typeof(ushort),
			typeof(ushort)
		});
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119089), new Type[1] { typeof(IEnumerable<int>) });
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119106), new Type[1] { typeof(IEnumerable<int>) });
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119124), Array.Empty<Type>());
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119138), new Type[1] { typeof(string) });
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119156), new Type[5]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool),
			typeof(string)
		});
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119169), new Type[2]
		{
			typeof(byte),
			typeof(uint)
		});
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119180), new Type[5]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool),
			typeof(string)
		});
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119196), new Type[2]
		{
			typeof(byte),
			typeof(uint)
		});
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119210), new Type[1] { typeof(uint) });
		smethod_199(hashSet, typeof(Class119), Class185.smethod_0(-1141119237), Array.Empty<Type>());
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
		smethod_200(hashSet, typeof(Class412), Class185.smethod_0(-1141119249));
		smethod_200(hashSet, typeof(Class2), Class185.smethod_0(-1141119260));
		smethod_200(hashSet, typeof(Class188), Class185.smethod_0(-1141119286));
		smethod_200(hashSet, typeof(Class342), Class185.smethod_0(-1141119300));
		smethod_200(hashSet, typeof(Class342), Class185.smethod_0(-1141119318));
		smethod_200(hashSet, typeof(Class138), Class185.smethod_0(-1141119341));
		smethod_200(hashSet, typeof(Class138), Class185.smethod_0(-1141119357));
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
		int num = smethod_210(string_0, Class185.smethod_0(-1141119363) + class282_1.string_1, 0, string_0.Length);
		if (num < 0)
		{
			int_0 += smethod_243(Class185.smethod_0(-1141119384) + class282_1.string_1, bool_0: false);
			return null;
		}
		int num2 = string_0.IndexOf('{', num);
		int num3 = smethod_211(string_0, num2);
		if (num2 >= 0 && num3 >= 0)
		{
			string input = string_0.Substring(num2 + 1, num3 - num2 - 1);
			string pattern = Regex.Escape(class282_1.string_2).Replace(Class185.smethod_0(-1141119453), Class185.smethod_0(-1141114322));
			MatchCollection matchCollection = Regex.Matches(input, pattern, RegexOptions.CultureInvariant);
			if (matchCollection.Count != 1)
			{
				int_0 += smethod_243(Class185.smethod_0(-1141119462) + class282_1.string_3, bool_0: false);
				return null;
			}
			int num4 = num2 + 1 + matchCollection[0].Index;
			int num5 = string_0.IndexOf('{', num4 + matchCollection[0].Length);
			int num6 = smethod_211(string_0, num5);
			if (num5 >= 0 && num5 <= num3 && num6 >= 0 && num6 <= num3)
			{
				return string_0.Substring(num4, num6 - num4 + 1);
			}
			int_0 += smethod_243(Class185.smethod_0(-1141120525) + class282_1.string_3, bool_0: false);
			return null;
		}
		int_0 += smethod_243(Class185.smethod_0(-1141119416) + class282_1.string_1, bool_0: false);
		return null;
	}

	private static string smethod_207(Dictionary<string, string> dictionary_0, string string_0, ref int int_0)
	{
		if (dictionary_0.TryGetValue(string_0, out var value) && value != null)
		{
			return value;
		}
		int_0 += smethod_243(Class185.smethod_0(-1141120557) + string_0, bool_0: false);
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
		int num = smethod_210(string_0, Class185.smethod_0(-1141119363) + string_2, 0, string_0.Length);
		if (num < 0)
		{
			int_0 += smethod_243(Class185.smethod_0(-1141114567) + string_1 + Class185.smethod_0(-1141300031) + string_2 + Class185.smethod_0(-1141114587), bool_0: false);
			return null;
		}
		int num2 = string_0.IndexOf('{', num);
		int num3 = smethod_211(string_0, num2);
		if (num2 >= 0 && num3 >= 0)
		{
			int num4 = smethod_210(string_0, string_3, num2 + 1, num3);
			if (num4 < 0)
			{
				int_0 += smethod_243(Class185.smethod_0(-1141114567) + string_1 + Class185.smethod_0(-1141300031) + string_3 + Class185.smethod_0(-1141120605), bool_0: false);
				return null;
			}
			int num5 = string_0.IndexOf('{', num4 + string_3.Length);
			int num6 = smethod_211(string_0, num5);
			if (num5 >= 0 && num5 <= num3 && num6 >= 0 && num6 <= num3)
			{
				return string_0.Substring(num4, num6 - num4 + 1);
			}
			int_0 += smethod_243(Class185.smethod_0(-1141114567) + string_1 + Class185.smethod_0(-1141300031) + string_3 + Class185.smethod_0(-1141120585), bool_0: false);
			return null;
		}
		int_0 += smethod_243(Class185.smethod_0(-1141114567) + string_1 + Class185.smethod_0(-1141300031) + string_2 + Class185.smethod_0(-1141120585), bool_0: false);
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
		MethodInfo methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		num = 0 + smethod_243(Class185.smethod_0(-1141120624), methodInfo != null);
		MethodInfo[] methods = typeof(Class179).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
		num += smethod_243(Class185.smethod_0(-1141120654), methods.Count(Class299.class299_0.method_84) == 3 && methods.All(Class299.class299_0.method_85) && methodInfo != null && methodInfo.IsPrivate);
		MethodInfo methodInfo2 = methods.SingleOrDefault(Class299.class299_0.method_86);
		MethodInfo methodInfo3 = methods.SingleOrDefault(Class299.class299_0.method_87);
		MethodInfo methodInfo4 = methods.SingleOrDefault(Class299.class299_0.method_88);
		num += smethod_243(Class185.smethod_0(-1141120692), methodInfo2 != null);
		num += smethod_243(Class185.smethod_0(-1141120736), methodInfo3 != null);
		num += smethod_243(Class185.smethod_0(-1141120773), methodInfo4 != null);
		if (methodInfo2 != null)
		{
			ParameterInfo[] parameters = methodInfo2.GetParameters();
			num += smethod_243(Class185.smethod_0(-1141120802), parameters[1].Name == Class185.smethod_0(-1141120842) && parameters[2].Name == Class185.smethod_0(-1141120880) && parameters[3].Name == Class185.smethod_0(-1141120911) && (int)parameters[1].DefaultValue == 0 && (int)parameters[2].DefaultValue == 200 && (double)parameters[3].DefaultValue == 10.0);
		}
		Dictionary<string, string> dictionary_ = new Dictionary<string, string>(StringComparer.Ordinal)
		{
			[Class185.smethod_0(-1141120924)] = Class185.smethod_0(-1141120937),
			[Class185.smethod_0(-1141120973)] = Class185.smethod_0(-1141120978),
			[Class185.smethod_0(-1141121013)] = Class185.smethod_0(-1141121018)
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
			[Class185.smethod_0(-1141120037)] = Class185.smethod_0(-1141120041),
			[Class185.smethod_0(-1141120069)] = Class185.smethod_0(-1141120073),
			[Class185.smethod_0(-1141120110)] = Class185.smethod_0(-1141120114),
			[Class185.smethod_0(-1141120144)] = Class185.smethod_0(-1141120148),
			[Class185.smethod_0(-1141120185)] = Class185.smethod_0(-1141120205)
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
				num += smethod_244(Class185.smethod_0(-1141120240), (Enum9)0, Class179.smethod_0(class3.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
				class3.class222_0.method_0(class3.class223_0.class145_1, bool_0: true);
				num += smethod_244(Class185.smethod_0(-1141120266), (Enum9)0, Class179.smethod_1(class3.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
				class3.class222_0.method_0(class3.class223_0.class145_1, bool_0: true);
				num += smethod_244(Class185.smethod_0(-1141120309), (Enum9)0, Class179.smethod_2(class3.class222_0.gform0_0, Class185.smethod_0(-1141113312), 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_243(Class185.smethod_0(-1141120344), class3.list_0.Count == 3 && class3.list_0[0].Contains(Class185.smethod_0(-1141120387)) && class3.list_0[1].Contains(Class185.smethod_0(-1141120420)) && class3.list_0[2].Contains(Class185.smethod_0(-1141120461)));
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
			smethod_94(class5, Class185.smethod_0(-1141120494), DateTime.UtcNow.AddSeconds(-10.0).Ticks);
			class4.class222_0.method_0(class5, bool_0: true);
			class4.int_0 = 0;
			class4.list_0 = new List<string>();
			class4.class222_0.class119_0.method_30(class4.method_0);
			class4.long_0 = 0L;
			using (Class75.smethod_1(class4.method_1, 1000L, class4.method_2, bool_0: true, bool_1: true))
			{
				num += smethod_244(Class185.smethod_0(-1141117457), (Enum9)0, Class179.smethod_0(class4.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_243(Class185.smethod_0(-1141117503), class4.int_0 == 2 && class4.list_0.Count == 1 && class4.list_0[0].Contains(Class185.smethod_0(-1141117543)));
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
				num += smethod_244(Class185.smethod_0(-1141117556), (Enum9)1, Class179.smethod_0(class6.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_244(Class185.smethod_0(-1141117596), 0, class7.list_0.Count);
			class6.method_0(@class.class145_1.method_99(Class185.smethod_0(-1141117637)), bool_0: true);
			class7.long_0 = 0L;
			using (Class75.smethod_1(class7.method_3, 1000L, class7.method_4, bool_0: true, bool_1: true))
			{
				num += smethod_244(Class185.smethod_0(-1141117661), (Enum9)1, Class179.smethod_0(class6.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_244(Class185.smethod_0(-1141117704), 0, class7.list_0.Count);
			class6.method_0(@class.class145_1.method_98(list2, null, Class95.class95_0, 9, 24, 60), bool_0: true);
			class7.long_0 = 0L;
			using (Class75.smethod_1(class7.method_5, 1000L, class7.method_6, bool_0: true, bool_1: true))
			{
				num += smethod_244(Class185.smethod_0(-1141117732), (Enum9)1, Class179.smethod_0(class6.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_244(Class185.smethod_0(-1141117783), 0, class7.list_0.Count);
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
				num += smethod_244(Class185.smethod_0(-1141117822), (Enum9)0, Class179.smethod_0(class8.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_243(Class185.smethod_0(-1141117862), class8.int_0 == 2 && class8.list_0.Count == 1);
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
				num += smethod_244(Class185.smethod_0(-1141117905), (Enum9)1, Class179.smethod_0(class9.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141117949), (Enum9)1, Class179.smethod_1(class9.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
				num += smethod_244(Class185.smethod_0(-1141116954), (Enum9)1, Class179.smethod_2(class9.class222_0.gform0_0, Class185.smethod_0(-1141113312), 0, 200, 10.0).GetAwaiter().GetResult());
				num += smethod_243(Class185.smethod_0(-1141116999), smethod_215(class9.method_0));
				num += smethod_243(Class185.smethod_0(-1141117043), smethod_215(class9.method_1));
				num += smethod_243(Class185.smethod_0(-1141117102), smethod_215(class9.method_2));
				num += smethod_243(Class185.smethod_0(-1141117144), smethod_215(class9.method_3));
				num += smethod_243(Class185.smethod_0(-1141117180), smethod_215(class9.method_4));
				num += smethod_243(Class185.smethod_0(-1141117232), smethod_215(class9.method_5));
			}
			using (Class75.smethod_1(class10.method_1, 1000L, Class299.class299_0.method_90, bool_0: true, bool_1: true))
			{
				num += smethod_244(Class185.smethod_0(-1141117275), (Enum9)3, Class179.smethod_2(class9.class222_0.gform0_0, Class185.smethod_0(-1141341332), 0, 200, 10.0).GetAwaiter().GetResult());
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
				num += smethod_244(Class185.smethod_0(-1141117306), (Enum9)2, Class179.smethod_0(class11.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
				class11.method_0(smethod_161(list, new List<Class403>(), dictionary_, dictionary_2, null, 1, 24), bool_0: true);
				num += smethod_244(Class185.smethod_0(-1141117337), (Enum9)4, Class179.smethod_0(class11.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
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
				num += smethod_244(Class185.smethod_0(-1141117376), (Enum9)0, Class179.smethod_0(class14.class222_0.gform0_0, 1, 300, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_243(Class185.smethod_0(-1141117403), class14.list_0.SequenceEqual(new int[4] { 300, 300, 300, 100 }));
			num += smethod_243(Class185.smethod_0(-1141118478), class14.class223_0.list_0.Count == 1 && class14.class223_0.list_0[0].Contains(Class185.smethod_0(-1141118528)));
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
				num += smethod_244(Class185.smethod_0(-1141118570), (Enum9)7, Class179.smethod_0(class15.class222_0.gform0_0, 1, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_244(Class185.smethod_0(-1141118610), 0, class15.int_0);
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
				num += smethod_244(Class185.smethod_0(-1141118653), (Enum9)5, Class179.smethod_0(class16.class222_0.gform0_0, 0, 200, 0.0).GetAwaiter().GetResult());
			}
			num += smethod_244(Class185.smethod_0(-1141118704), 0, class17.int_0);
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
				num += smethod_244(Class185.smethod_0(-1141118749), (Enum9)5, Class179.smethod_0(class18.class222_0.gform0_0, 0, 300, 1.0).GetAwaiter().GetResult());
			}
			num += smethod_243(Class185.smethod_0(-1141118790), class18.list_1.SequenceEqual(new int[4] { 300, 300, 300, 100 }));
			num += smethod_243(Class185.smethod_0(-1141118828), class18.list_0.Count == 1 && class18.list_0[0].Contains(Class185.smethod_0(-1141118860)));
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
				num += smethod_244(Class185.smethod_0(-1141118894), (Enum9)0, Class179.smethod_0(class19.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_244(Class185.smethod_0(-1141118935), 50, class19.int_0);
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
				num += smethod_244(Class185.smethod_0(-1141117960), (Enum9)6, Class179.smethod_1(class20.gform0_0, 1, 250, 0.5).GetAwaiter().GetResult());
			}
			num += smethod_243(Class185.smethod_0(-1141118000), class21.list_0.Count == 1 && class21.list_0[0].Contains(Class185.smethod_0(-1141118025)));
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
				num += smethod_244(Class185.smethod_0(-1141118051), (Enum9)0, Class179.smethod_2(class22.class222_0.gform0_0, Class185.smethod_0(-1141113312), 0, 200, 10.0).GetAwaiter().GetResult());
			}
			num += smethod_243(Class185.smethod_0(-1141118083), class22.list_0.Count == 1 && class22.list_0[0].Contains(Class185.smethod_0(-1141118116)) && class22.list_0[0].Contains(Class185.smethod_0(-1141118155)));
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
				num += smethod_244(Class185.smethod_0(-1141118189), (Enum9)8, Class179.smethod_0(class23.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
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
				num += smethod_244(Class185.smethod_0(-1141118220), (Enum9)8, Class179.smethod_0(class24.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
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
			num += smethod_243(Class185.smethod_0(-1141118268), bool_);
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
			num += smethod_244(Class185.smethod_0(-1141118320), (Enum9)1, task2.Result);
			num += smethod_244(Class185.smethod_0(-1141118361), (Enum9)2, task3.Result);
			class28.long_0 = 0L;
			using (Class75.smethod_1(class28.method_0, 1000L, Class299.class299_0.method_97, bool_0: false, bool_1: false))
			{
				using (Class75.smethod_1(class28.method_1, 1000L, Class299.class299_0.method_98, bool_0: true, bool_1: true))
				{
					num += smethod_244(Class185.smethod_0(-1141118414), (Enum9)2, Class179.smethod_0(class27.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
				}
				num += smethod_244(Class185.smethod_0(-1141118444), (Enum9)1, Class179.smethod_0(class27.class222_0.gform0_0, 0, 200, 10.0).GetAwaiter().GetResult());
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
			num += smethod_243(Class185.smethod_0(-1141123613), text.Contains(Class185.smethod_0(-1141123651)) && text.Contains(Class185.smethod_0(-1141123690)) && text.Contains(Class185.smethod_0(-1141123743)) && text.IndexOf(Class185.smethod_0(-1141123785), StringComparison.Ordinal) < text.IndexOf(Class185.smethod_0(-1141123836), StringComparison.Ordinal));
		}
		string text2 = smethod_173(Class185.smethod_0(-1141257387), ref num);
		string text3 = smethod_173(Class185.smethod_0(-1141361147), ref num);
		if (text2 != null && text3 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141123868), !text2.Contains(Class185.smethod_0(-1141123914)) && !text2.Contains(Class185.smethod_0(-1141123943)) && !text2.Contains(Class185.smethod_0(-1141123964)) && !text2.Contains(Class185.smethod_0(-1141124000)) && !text3.Contains(Class185.smethod_0(-1141124024)));
		}
		Console.WriteLine(Class185.smethod_0(-1141124053) + num + Class185.smethod_0(-1141356690));
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
		num = 0 + smethod_244(Class185.smethod_0(-1141124065), (Class81.Enum4)1, Class81.smethod_2(bool_0: true, Class185.smethod_0(-1141305020), string.Empty, 100L));
		num += smethod_244(Class185.smethod_0(-1141123078), (Class81.Enum4)2, Class81.smethod_2(bool_0: true, Class185.smethod_0(-1141144254), string.Empty, 100L));
		num += smethod_244(Class185.smethod_0(-1141123099), (Class81.Enum4)0, Class81.smethod_2(bool_0: true, Class185.smethod_0(-1141144302), string.Empty, 100L));
		num += smethod_244(Class185.smethod_0(-1141123141), (Class81.Enum4)3, Class81.smethod_2(bool_0: true, string.Empty, Class185.smethod_0(-1141123169), 100L));
		num += smethod_243(Class185.smethod_0(-1141123205), Class81.smethod_2(bool_0: true, Class185.smethod_0(-1141144254), string.Empty, 100L) != Class81.smethod_2(bool_0: true, Class185.smethod_0(-1141144302), string.Empty, 100L));
		num += smethod_243(Class185.smethod_0(-1141123242), Class81.smethod_2(bool_0: true, Class185.smethod_0(-1141144254), string.Empty, 100L) != (Class81.Enum4)0);
		num += smethod_243(Class185.smethod_0(-1141123301), Class81.smethod_2(bool_0: true, Class185.smethod_0(-1141144302), string.Empty, 100L) != (Class81.Enum4)2);
		num += smethod_244(Class185.smethod_0(-1141123348), (Class81.Enum4)3, Class81.smethod_2(bool_0: true, Class185.smethod_0(-1141305020), Class185.smethod_0(-1141123393), 100L));
		num += smethod_244(Class185.smethod_0(-1141123409), (Class81.Enum4)0, Class81.smethod_2(bool_0: false, Class185.smethod_0(-1141305020), string.Empty, 100L));
		num += smethod_244(Class185.smethod_0(-1141123452), (Class81.Enum4)0, Class81.smethod_2(bool_0: false, Class185.smethod_0(-1141144254), string.Empty, 100L));
		num += smethod_244(Class185.smethod_0(-1141123503), (Class81.Enum4)0, Class81.smethod_2(bool_0: true, string.Empty, string.Empty, 100L));
		num += smethod_244(Class185.smethod_0(-1141123531), (Class81.Enum4)4, Class81.smethod_2(bool_0: true, Class185.smethod_0(-1141144302), string.Empty, 12000L));
		num += smethod_244(Class185.smethod_0(-1141123577), (Class81.Enum4)4, Class81.smethod_2(bool_0: false, string.Empty, string.Empty, 12000L));
		num += smethod_244(Class185.smethod_0(-1141124636), (Class81.Enum4)0, Class81.smethod_2(bool_0: true, Class185.smethod_0(-1141144302), string.Empty, 11999L));
		num += smethod_244(Class185.smethod_0(-1141124686), (Class81.Enum4)3, Class81.smethod_2(bool_0: false, string.Empty, Class185.smethod_0(-1141142275), 12000L));
		num += smethod_243(Class185.smethod_0(-1141124731), bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141124780), bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141124822), bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141124869), bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141124920), Class81.smethod_0(-1L, 0L));
		num += smethod_243(Class185.smethod_0(-1141124958), !Class81.smethod_0(0L, 499L));
		num += smethod_243(Class185.smethod_0(-1141124995), Class81.smethod_0(0L, 500L));
		num += smethod_243(Class185.smethod_0(-1141125028), Class81.smethod_0(0L, 501L));
		num += smethod_243(Class185.smethod_0(-1141125071), !Class81.smethod_1(4, string.Empty, 4, string.Empty));
		num += smethod_243(Class185.smethod_0(-1141125112), Class81.smethod_1(5, string.Empty, 4, string.Empty));
		num += smethod_243(Class185.smethod_0(-1141124121), Class81.smethod_1(0, Class185.smethod_0(-1141123169), 0, string.Empty));
		num += smethod_243(Class185.smethod_0(-1141124168), Class81.smethod_1(0, string.Empty, 0, Class185.smethod_0(-1141123169)));
		num += smethod_243(Class185.smethod_0(-1141124203), Class81.smethod_1(0, Class185.smethod_0(-1141123393), 0, Class185.smethod_0(-1141123169)));
		num += smethod_243(Class185.smethod_0(-1141124254), Class81.smethod_1(0, Class185.smethod_0(-1141123393), 0, string.Empty));
		num += smethod_243(Class185.smethod_0(-1141124306), !Class81.smethod_1(4, null, 4, string.Empty));
		num += smethod_243(Class185.smethod_0(-1141124358), !Class81.smethod_1(4, string.Empty, 4, null));
		num += smethod_244(Class185.smethod_0(-1141124394), Class185.smethod_0(-1141124434), Class81.smethod_3(0L));
		num += smethod_244(Class185.smethod_0(-1141124482), Class185.smethod_0(-1141124434), Class81.smethod_3(1L));
		num += smethod_244(Class185.smethod_0(-1141124527), Class185.smethod_0(-1141124567), Class81.smethod_3(11999L));
		num += smethod_244(Class185.smethod_0(-1141121542), Class185.smethod_0(-1141121582), Class81.smethod_3(12000L));
		num += smethod_244(Class185.smethod_0(-1141121629), Class185.smethod_0(-1141121582), Class81.smethod_3(17000L));
		string[] array = Class81.smethod_14();
		num += smethod_244(Class185.smethod_0(-1141121671), 8, array.Length);
		num += smethod_244(Class185.smethod_0(-1141121702), Class185.smethod_0(-1141298782), array[0]);
		num += smethod_244(Class185.smethod_0(-1141121721), Class185.smethod_0(-1141121746), array[1]);
		num += smethod_244(Class185.smethod_0(-1141121755), Class185.smethod_0(-1141121791), array[2]);
		num += smethod_244(Class185.smethod_0(-1141121795), Class185.smethod_0(-1141121832), array[3]);
		num += smethod_244(Class185.smethod_0(-1141121845), Class185.smethod_0(-1141121867), array[4]);
		num += smethod_244(Class185.smethod_0(-1141121876), Class185.smethod_0(-1141121912), array[5]);
		num += smethod_244(Class185.smethod_0(-1141121916), Class185.smethod_0(-1141121952), array[6]);
		num += smethod_244(Class185.smethod_0(-1141121956), Class185.smethod_0(-1141121985), array[7]);
		for (int i = 0; i < array.Length; i++)
		{
			num += smethod_243(Class185.smethod_0(-1141122006) + i + Class185.smethod_0(-1141122029), array[i] != null && array[i].Length != 0);
		}
		Struct140 struct140_ = smethod_219(Class185.smethod_0(-1141143983), 1001, 1, bool_0: true, bool_1: true, 3, 120, 2, 1);
		string[] array2 = Class81.smethod_13(struct140_);
		num += smethod_244(Class185.smethod_0(-1141122046), 8, array2.Length);
		num += smethod_244(Class185.smethod_0(-1141121050), Class185.smethod_0(-1141143983), array2[0]);
		num += smethod_244(Class185.smethod_0(-1141121085), Class185.smethod_0(-1141121110), array2[1]);
		num += smethod_244(Class185.smethod_0(-1141121113), Class185.smethod_0(-1141121149), array2[2]);
		num += smethod_244(Class185.smethod_0(-1141121153), Class185.smethod_0(-1141121832), array2[3]);
		num += smethod_244(Class185.smethod_0(-1141121190), Class185.smethod_0(-1141297437), array2[4]);
		num += smethod_244(Class185.smethod_0(-1141121212), Class185.smethod_0(-1141121248), array2[5]);
		num += smethod_244(Class185.smethod_0(-1141121250), Class185.smethod_0(-1141297402), array2[6]);
		num += smethod_244(Class185.smethod_0(-1141121286), Class185.smethod_0(-1141121307), array2[7]);
		num += smethod_244(Class185.smethod_0(-1141121324), Class81.smethod_5(struct140_), array2[0]);
		num += smethod_244(Class185.smethod_0(-1141121371), Class81.smethod_11(struct140_), array2[6]);
		num += smethod_244(Class185.smethod_0(-1141121419), Class81.smethod_12(struct140_), array2[7]);
		num += smethod_244(Class185.smethod_0(-1141121468), Class185.smethod_0(-1141121832), Class81.smethod_8(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244(Class185.smethod_0(-1141121492), Class185.smethod_0(-1141121525), Class81.smethod_8(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: false, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244(Class185.smethod_0(-1141121531), Class185.smethod_0(-1141122606), Class81.smethod_8(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: false, bool_1: false, 0, 1, 0, 0)));
		num += smethod_244(Class185.smethod_0(-1141122612), Class185.smethod_0(-1141122606), Class81.smethod_8(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: false, 0, 1, 0, 0)));
		num += smethod_243(Class185.smethod_0(-1141122662), Class81.smethod_8(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: false, bool_1: false, 0, 1, 0, 0)) != Class81.smethod_8(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: false, bool_1: true, 0, 1, 0, 0)));
		num += smethod_243(Class185.smethod_0(-1141122702), Class81.smethod_8(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: false, 0, 1, 0, 0)) != Class81.smethod_8(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_243(Class185.smethod_0(-1141122741), bool_0: true);
		num += smethod_244(Class185.smethod_0(-1141122778), Class185.smethod_0(-1141121791), Class81.smethod_7(smethod_219(Class185.smethod_0(-1141324125), 1, -1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244(Class185.smethod_0(-1141122814), Class185.smethod_0(-1141119300), Class81.smethod_7(smethod_219(Class185.smethod_0(-1141324125), 1, 0, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244(Class185.smethod_0(-1141122840), Class185.smethod_0(-1141121149), Class81.smethod_7(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244(Class185.smethod_0(-1141122860), Class185.smethod_0(-1141122889), Class81.smethod_7(smethod_219(Class185.smethod_0(-1141324125), 1, 2, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244(Class185.smethod_0(-1141122910), Class185.smethod_0(-1141292548), Class81.smethod_7(smethod_219(Class185.smethod_0(-1141324125), 1, 7, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244(Class185.smethod_0(-1141122960), Class185.smethod_0(-1141121791), Class81.smethod_7(smethod_219(Class185.smethod_0(-1141324125), 1, -1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244(Class185.smethod_0(-1141122988), Class185.smethod_0(-1141123022), Class81.smethod_12(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244(Class185.smethod_0(-1141123039), Class185.smethod_0(-1141121307), Class81.smethod_12(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 1)));
		num += smethod_244(Class185.smethod_0(-1141123057), Class185.smethod_0(-1141122059), Class81.smethod_12(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 2)));
		num += smethod_244(Class185.smethod_0(-1141122073), Class185.smethod_0(-1141122133), Class81.smethod_12(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 9)));
		num += smethod_244(Class185.smethod_0(-1141122141), Class185.smethod_0(-1141296459), Class81.smethod_11(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244(Class185.smethod_0(-1141122166), Class185.smethod_0(-1141297402), Class81.smethod_11(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: true, 0, 1, 2, 0)));
		num += smethod_244(Class185.smethod_0(-1141122191), Class185.smethod_0(-1141122210), Class81.smethod_11(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: true, 0, 1, byte.MaxValue, 0)));
		num += smethod_243(Class185.smethod_0(-1141122220), Class81.smethod_11(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: true, 0, 1, 1, 1)) != Class81.smethod_12(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: true, 0, 1, 1, 1)));
		num += smethod_244(Class185.smethod_0(-1141122279), Class185.smethod_0(-1141122300), Class81.smethod_6(smethod_219(Class185.smethod_0(-1141324125), -4, 1, bool_0: true, bool_1: true, 0, 1, 0, 0)));
		num += smethod_244(Class185.smethod_0(-1141122317), Class185.smethod_0(-1141122342), Class81.smethod_9(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: true, 12, 1, 0, 0)));
		num += smethod_244(Class185.smethod_0(-1141122351), Class185.smethod_0(-1141122374), Class81.smethod_10(smethod_219(Class185.smethod_0(-1141324125), 1, 1, bool_0: true, bool_1: true, 0, ushort.MaxValue, 0, 0)));
		num += smethod_243(Class185.smethod_0(-1141122378), Class81.smethod_4(smethod_219(Class185.smethod_0(-1141145154), 2, -1, bool_0: false, bool_1: true, 0, 60, 1, 0)));
		num += smethod_243(Class185.smethod_0(-1141122417), Class81.smethod_4(smethod_219(Class185.smethod_0(-1141145237), 3, 1, bool_0: false, bool_1: true, 0, 60, 1, 0)));
		num += smethod_243(Class185.smethod_0(-1141122464), Class81.smethod_4(smethod_219(Class185.smethod_0(-1141145345), 4, 1, bool_0: false, bool_1: false, 0, 0, 0, 0)));
		num += smethod_243(Class185.smethod_0(-1141122503), Class81.smethod_4(smethod_219(Class185.smethod_0(-1141122541), 5, 2, bool_0: true, bool_1: true, 0, 60, 1, 0)));
		num += smethod_244(Class185.smethod_0(-1141122551), Class185.smethod_0(-1141145154), Class81.smethod_5(smethod_219(Class185.smethod_0(-1141145154), 2, -1, bool_0: false, bool_1: true, 0, 60, 1, 0)));
		num += smethod_243(Class185.smethod_0(-1141127711), !Class81.smethod_4(smethod_219(string.Empty, 6, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)));
		num += smethod_243(Class185.smethod_0(-1141127750), !Class81.smethod_4(smethod_219(Class185.smethod_0(-1141341332), 7, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)));
		num += smethod_243(Class185.smethod_0(-1141127786), !Class81.smethod_4(smethod_219(null, 8, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)));
		num += smethod_244(Class185.smethod_0(-1141127832), Class185.smethod_0(-1141127874), Class81.smethod_5(smethod_219(string.Empty, 6, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)));
		num += smethod_244(Class185.smethod_0(-1141127890), Class185.smethod_0(-1141127874), Class81.smethod_5(smethod_219(null, 8, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)));
		num += smethod_243(Class185.smethod_0(-1141127939), !Class81.smethod_4(smethod_219(string.Empty, 6, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)) && Class81.smethod_5(smethod_219(string.Empty, 6, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)) == Class185.smethod_0(-1141127874));
		num += smethod_244(Class185.smethod_0(-1141127993), Class185.smethod_0(-1141145479), Class81.smethod_5(smethod_219(Class185.smethod_0(-1141145479), 9, 1, bool_0: true, bool_1: true, 0, 60, 1, 0)));
		List<Struct140> list = new List<Struct140>();
		list.Add(smethod_219(Class185.smethod_0(-1141143983), 1, 1, bool_0: true, bool_1: true, 0, 60, 1, 0));
		list.Add(smethod_219(Class185.smethod_0(-1141145154), 2, -1, bool_0: false, bool_1: true, 0, 60, 1, 0));
		list.Add(smethod_219(string.Empty, 3, 1, bool_0: true, bool_1: true, 0, 60, 1, 0));
		num += smethod_244(Class185.smethod_0(-1141128037), 2, Class81.smethod_15(list));
		num += smethod_244(Class185.smethod_0(-1141128086), 0, Class81.smethod_15(null));
		num += smethod_244(Class185.smethod_0(-1141128120), 0, Class81.smethod_15(new Struct140[0]));
		num += smethod_244(Class185.smethod_0(-1141128147), string.Empty, Class81.smethod_16(0));
		num += smethod_244(Class185.smethod_0(-1141127177), string.Empty, Class81.smethod_16(-1));
		num += smethod_243(Class185.smethod_0(-1141127229), Class81.smethod_16(2).Contains(Class185.smethod_0(-1141297402)) && Class81.smethod_16(2).Contains(Class185.smethod_0(-1141127270)));
		num += smethod_244(Class185.smethod_0(-1141127294), Class185.smethod_0(-1141142275), GForm0.smethod_12(Class185.smethod_0(-1141142275)));
		num += smethod_244(Class185.smethod_0(-1141127335), Class185.smethod_0(-1141267684), GForm0.smethod_12(string.Empty));
		return num + smethod_244(Class185.smethod_0(-1141127383), Class185.smethod_0(-1141267684), GForm0.smethod_12(null));
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
		int num = string_0.IndexOf(Class185.smethod_0(-1141170510), StringComparison.Ordinal);
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
		string text = Class185.smethod_0(-1141304355) + string_1 + Class185.smethod_0(-1141127429) + int_0;
		if (!string_0.Contains(text + Class185.smethod_0(-1141326297)))
		{
			return string_0.Contains(text + Class185.smethod_0(-1141174659));
		}
		return true;
	}

	private static void smethod_222(JObject jobject_0, Dictionary<string, string> dictionary_0)
	{
		JObject val = (JObject)((jobject_0 == null) ? null : /*isinst with value type is only supported in some contexts*/);
		if (val == null)
		{
			return;
		}
		foreach (KeyValuePair<string, JToken> item in val)
		{
			if (!string.IsNullOrEmpty(item.Key))
			{
				dictionary_0[item.Key] = (string)item.Value;
			}
		}
	}

	private static JObject smethod_223(string string_0)
	{
		string text = Class185.smethod_0(-1141127443) + string_0;
		for (int i = 1; i < 12; i++)
		{
			text = text + Class185.smethod_0(-1141127517) + i + Class185.smethod_0(-1141127522);
		}
		return JObject.Parse(text + Class185.smethod_0(-1141156722));
	}

	private static JObject smethod_224(int int_0)
	{
		string text = Class185.smethod_0(-1141127443);
		for (int i = 0; i < int_0; i++)
		{
			if (i != 0)
			{
				text += Class185.smethod_0(-1141326297);
			}
			text = text + Class185.smethod_0(-1141127564) + i + Class185.smethod_0(-1141127522);
		}
		return JObject.Parse(text + Class185.smethod_0(-1141156722));
	}

	private static Class145 smethod_225(JObject jobject_0)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		smethod_222(jobject_0, dictionary);
		return Class145.class145_0.method_97(Class119.smethod_40(jobject_0), Class119.smethod_43(jobject_0), new Class95(null, dictionary, null), 1, Class119.smethod_41(jobject_0));
	}

	private static JObject smethod_226(string string_0)
	{
		return JObject.Parse(Class185.smethod_0(-1141158398).Substring(0, 932) + Class185.smethod_0(-1141127584) + string_0 + Class185.smethod_0(-1141174659));
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
				Value = Class185.smethod_0(-1141127598)
			},
			new GClass4
			{
				Key = Class357.string_1,
				Value = Class185.smethod_0(-1141127603)
			},
			new GClass4
			{
				Key = Class357.string_2,
				Value = Class185.smethod_0(-1141127624)
			},
			new GClass4
			{
				Key = Class357.string_3,
				Value = Class185.smethod_0(-1141285992)
			},
			new GClass4
			{
				Key = Class357.string_4,
				Value = Class185.smethod_0(-1141127637)
			}
		};
		for (int i = 0; i < valueTuple_0.Length; i++)
		{
			list.Add(new GClass4
			{
				Key = valueTuple_0[i].Item1,
				Value = Class185.smethod_0(-1141274413) + (8192 + i * 4).ToString(Class185.smethod_0(-1141278773))
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
		list.Add(new string[5]
		{
			Class185.smethod_0(-1141127654),
			Class185.smethod_0(-1141127657),
			Class185.smethod_0(-1141297402),
			Class185.smethod_0(-1141317989),
			Class185.smethod_0(-1141127677)
		});
		list.Add(new string[5]
		{
			Class185.smethod_0(-1141278971),
			Class185.smethod_0(-1141128712),
			Class185.smethod_0(-1141296459),
			Class185.smethod_0(-1141317953),
			Class185.smethod_0(-1141296459)
		});
		string text = Class440.smethod_12(list, Class185.smethod_0(-1141128714), new DateTime(2026, 9, 17, 10, 30, 0));
		num = 0 + smethod_243(Class185.smethod_0(-1141128734), text.Contains(Class185.smethod_0(-1141128750)));
		num += smethod_243(Class185.smethod_0(-1141128790), text.Contains(Class185.smethod_0(-1141128806)));
		num += smethod_243(Class185.smethod_0(-1141128832), text.Contains(Class185.smethod_0(-1141128848)));
		List<string[]> list2 = Class440.smethod_13(text, out var int_);
		num += smethod_243(Class185.smethod_0(-1141128866), list2 != null);
		num += smethod_244(Class185.smethod_0(-1141128882), 2, list2?.Count ?? (-1));
		num += smethod_244(Class185.smethod_0(-1141128897), 0, int_);
		if (list2 != null && list2.Count == 2)
		{
			for (int i = 0; i < list.Count; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					num += smethod_244(Class185.smethod_0(-1141128914) + i + Class185.smethod_0(-1141128924) + j, list[i][j], list2[i][j]);
				}
			}
		}
		list2 = Class440.smethod_13(Class185.smethod_0(-1141128932), out int_);
		num += smethod_243(Class185.smethod_0(-1141128962), list2 != null && list2.Count == 1);
		num += smethod_244(Class185.smethod_0(-1141128979), 0, int_);
		if (list2 != null && list2.Count == 1)
		{
			num += smethod_244(Class185.smethod_0(-1141129005), Class185.smethod_0(-1141296467), list2[0][0]);
			num += smethod_244(Class185.smethod_0(-1141129009), Class185.smethod_0(-1141297402), list2[0][1]);
			num += smethod_244(Class185.smethod_0(-1141129029), Class185.smethod_0(-1141296459), list2[0][2]);
			num += smethod_244(Class185.smethod_0(-1141129045), Class185.smethod_0(-1141317953), list2[0][3]);
			num += smethod_244(Class185.smethod_0(-1141129061), Class185.smethod_0(-1141296459), list2[0][4]);
		}
		list2 = Class440.smethod_13(Class185.smethod_0(-1141129065), out int_);
		num += smethod_243(Class185.smethod_0(-1141129150), list2 != null && list2.Count == 2);
		if (list2 != null && list2.Count == 2)
		{
			num += smethod_244(Class185.smethod_0(-1141129167), Class185.smethod_0(-1141296459), list2[0][2]);
			num += smethod_244(Class185.smethod_0(-1141129183), Class185.smethod_0(-1141317953), list2[0][3]);
			num += smethod_244(Class185.smethod_0(-1141129199), Class185.smethod_0(-1141296459), list2[0][4]);
			num += smethod_244(Class185.smethod_0(-1141129203), Class185.smethod_0(-1141296459), list2[1][2]);
			num += smethod_244(Class185.smethod_0(-1141128195), Class185.smethod_0(-1141317989), list2[1][3]);
			num += smethod_244(Class185.smethod_0(-1141128212), Class185.smethod_0(-1141122133), list2[1][4]);
		}
		list2 = Class440.smethod_13(Class185.smethod_0(-1141128225), out int_);
		num += smethod_243(Class185.smethod_0(-1141128302), list2 != null && list2.Count == 1);
		num += smethod_244(Class185.smethod_0(-1141128320), 3, int_);
		if (list2 != null && list2.Count == 1)
		{
			num += smethod_244(Class185.smethod_0(-1141128329), Class185.smethod_0(-1141297437), list2[0][0]);
		}
		list2 = Class440.smethod_13(Class185.smethod_0(-1141128347), out int_);
		num += smethod_243(Class185.smethod_0(-1141128388), list2 != null && list2.Count == 1);
		if (list2 != null && list2.Count == 1)
		{
			num += smethod_244(Class185.smethod_0(-1141128413), Class185.smethod_0(-1141296467), list2[0][0]);
			num += smethod_244(Class185.smethod_0(-1141128417), Class185.smethod_0(-1141128437), list2[0][1]);
			num += smethod_244(Class185.smethod_0(-1141128447), Class185.smethod_0(-1141297437), list2[0][2]);
			num += smethod_244(Class185.smethod_0(-1141128463), Class185.smethod_0(-1141317989), list2[0][3]);
			num += smethod_244(Class185.smethod_0(-1141128479), Class185.smethod_0(-1141291508), list2[0][4]);
		}
		num += smethod_243(Class185.smethod_0(-1141128483), Class440.smethod_13(Class185.smethod_0(-1141128498), out int_) == null);
		num += smethod_243(Class185.smethod_0(-1141128513), Class440.smethod_13(Class185.smethod_0(-1141128529), out int_) == null);
		num += smethod_243(Class185.smethod_0(-1141128547), Class440.smethod_13(Class185.smethod_0(-1141128575), out int_) == null);
		num += smethod_243(Class185.smethod_0(-1141128594), Class440.smethod_13(Class185.smethod_0(-1141128617), out int_) == null);
		num += smethod_243(Class185.smethod_0(-1141128642), Class440.smethod_13(Class185.smethod_0(-1141128658), out int_) == null);
		num += smethod_243(Class185.smethod_0(-1141128687), Class440.smethod_13(Class185.smethod_0(-1141128704), out int_) == null);
		num += smethod_244(Class185.smethod_0(-1141125660), 2, int_);
		num += smethod_243(Class185.smethod_0(-1141125693), Class440.smethod_13(null, out int_) == null);
		num += smethod_243(Class185.smethod_0(-1141125700), Class440.smethod_13(Class185.smethod_0(-1141341332), out int_) == null);
		List<string[]> list3 = new List<string[]>();
		list3.Add(new string[2]
		{
			Class185.smethod_0(-1141296467),
			Class185.smethod_0(-1141297402)
		});
		list3.Add(null);
		string text2 = Class440.smethod_12(list3, null, DateTime.Now);
		num += smethod_243(Class185.smethod_0(-1141125716), text2.Contains(Class185.smethod_0(-1141125742)));
		list2 = Class440.smethod_13(text2, out int_);
		num += smethod_243(Class185.smethod_0(-1141125755), list2 != null && list2.Count == 1);
		num += smethod_244(Class185.smethod_0(-1141125783), 1, int_);
		Console.WriteLine(Class185.smethod_0(-1141125796) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_232()
	{
		int num = 0;
		num = 0 + smethod_243(Class185.smethod_0(-1141125821), Class96.smethod_2(smethod_235(new string[1] { Class185.smethod_0(-1141312985) }), Class185.smethod_0(-1141312985)));
		num += smethod_243(Class185.smethod_0(-1141125838), Class96.smethod_2(smethod_235(new string[1] { Class185.smethod_0(-1141313005) }), Class185.smethod_0(-1141325669)));
		num += smethod_243(Class185.smethod_0(-1141125854), Class96.smethod_2(smethod_235(new string[1] { Class185.smethod_0(-1141125866) }), Class185.smethod_0(-1141312985)));
		num += smethod_243(Class185.smethod_0(-1141125888), Class96.smethod_2(smethod_235(new string[1] { Class185.smethod_0(-1141312985) }), Class185.smethod_0(-1141125866)));
		num += smethod_243(Class185.smethod_0(-1141125909), !Class96.smethod_2(smethod_235(new string[1] { Class185.smethod_0(-1141341332) }), Class185.smethod_0(-1141309974)));
		num += smethod_243(Class185.smethod_0(-1141125951), !Class96.smethod_2(smethod_235(new string[1] { Class185.smethod_0(-1141341332) }), Class185.smethod_0(-1141341332)));
		num += smethod_243(Class185.smethod_0(-1141125978), !Class96.smethod_2(smethod_235(new string[1] { Class185.smethod_0(-1141309974) }), Class185.smethod_0(-1141312985)));
		num += smethod_243(Class185.smethod_0(-1141126015), !Class96.smethod_2(smethod_235(new string[1] { Class185.smethod_0(-1141310011) }), Class185.smethod_0(-1141312985)));
		num += smethod_243(Class185.smethod_0(-1141126045), !Class96.smethod_2(smethod_235(Array.Empty<string>()), Class185.smethod_0(-1141312985)));
		num += smethod_243(Class185.smethod_0(-1141126059), !Class96.smethod_2(smethod_235(new string[1] { Class185.smethod_0(-1141312985) }), null));
		num += smethod_243(Class185.smethod_0(-1141126088), !Class96.smethod_2(new DataGridView(), Class185.smethod_0(-1141312985)));
		num += smethod_243(Class185.smethod_0(-1141126110), !Class96.smethod_2(smethod_236(Array.Empty<string>()), Class185.smethod_0(-1141312985)));
		DataGridView dataGridView = smethod_235(Array.Empty<string>());
		dataGridView.Rows.Add();
		num += smethod_243(Class185.smethod_0(-1141126136), !Class96.smethod_2(dataGridView, Class185.smethod_0(-1141312985)));
		DataGridView dataGridView2 = new DataGridView();
		dataGridView2.AllowUserToAddRows = false;
		dataGridView2.Columns.Add(Class185.smethod_0(-1141125133), Class185.smethod_0(-1141125144));
		dataGridView2.Rows.Add(Class185.smethod_0(-1141296459));
		num += smethod_244(Class185.smethod_0(-1141125159), string.Empty, Class96.smethod_3(dataGridView2.Rows[0]));
		DataGridView dataGridView_ = smethod_235(Array.Empty<string>());
		num += smethod_243(Class185.smethod_0(-1141125180), Class55.smethod_3(dataGridView_, Class185.smethod_0(-1141312985), null));
		num += smethod_244(Class185.smethod_0(-1141125201), Class185.smethod_0(-1141312985), smethod_124(dataGridView_));
		num += smethod_243(Class185.smethod_0(-1141125227), !Class55.smethod_3(dataGridView_, Class185.smethod_0(-1141312985), null));
		num += smethod_244(Class185.smethod_0(-1141125249), string.Empty, smethod_124(dataGridView_));
		DataGridView dataGridView_2 = smethod_235(new string[1] { Class185.smethod_0(-1141313005) });
		num += smethod_243(Class185.smethod_0(-1141125276), !Class55.smethod_3(dataGridView_2, Class185.smethod_0(-1141325669), null));
		num += smethod_244(Class185.smethod_0(-1141125311), string.Empty, smethod_124(dataGridView_2));
		DataGridView dataGridView_3 = smethod_235(Array.Empty<string>());
		num += smethod_244(Class185.smethod_0(-1141125343), 1, Class55.smethod_1(dataGridView_3, smethod_239(new string[3]
		{
			Class185.smethod_0(-1141312985),
			Class185.smethod_0(-1141313005),
			Class185.smethod_0(-1141125866)
		}), null));
		num += smethod_244(Class185.smethod_0(-1141125373), Class185.smethod_0(-1141312985), smethod_124(dataGridView_3));
		DataGridView dataGridView_4 = smethod_235(Array.Empty<string>());
		num += smethod_244(Class185.smethod_0(-1141125397), 0, Class55.smethod_1(dataGridView_4, smethod_239(new string[3]
		{
			string.Empty,
			Class185.smethod_0(-1141341332),
			null
		}), null));
		num += smethod_244(Class185.smethod_0(-1141125418), string.Empty, smethod_124(dataGridView_4));
		DataGridView dataGridView_5 = smethod_235(new string[1] { Class185.smethod_0(-1141312985) });
		num += smethod_244(Class185.smethod_0(-1141125452), 0, Class55.smethod_2(dataGridView_5, smethod_239(new string[1] { Class185.smethod_0(-1141310184) }), null));
		num += smethod_244(Class185.smethod_0(-1141125485), Class185.smethod_0(-1141312985), smethod_124(dataGridView_5));
		DataGridView dataGridView3 = smethod_236(new string[2]
		{
			Class185.smethod_0(-1141312985),
			Class185.smethod_0(-1141310184)
		});
		num += smethod_244(Class185.smethod_0(-1141125507), 2, Class55.smethod_2(dataGridView3, smethod_239(new string[2]
		{
			Class185.smethod_0(-1141312985),
			Class185.smethod_0(-1141310184)
		}), null));
		num += smethod_244(Class185.smethod_0(-1141125537), string.Empty, smethod_124(dataGridView3));
		num += smethod_244(Class185.smethod_0(-1141125572), 1, dataGridView3.Rows.Count);
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141125610) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
		try
		{
			Class67 @class = new Class67(Path.Combine(text, Class185.smethod_0(-1141125627)));
			DataGridView dataGridView_6 = smethod_235(Array.Empty<string>());
			@class.method_7(dataGridView_6, Class185.smethod_0(-1141322682));
			@class.method_8(Class185.smethod_0(-1141126670));
			int num2 = @class.method_3();
			Class55.smethod_1(dataGridView_6, smethod_239(new string[3]
			{
				Class185.smethod_0(-1141312985),
				Class185.smethod_0(-1141310184),
				Class185.smethod_0(-1141324859)
			}), @class);
			num += smethod_244(Class185.smethod_0(-1141126682), num2 + 1, @class.method_3());
			num += smethod_244(Class185.smethod_0(-1141126717), Class185.smethod_0(-1141126749), smethod_124(dataGridView_6));
			string string_ = Path.Combine(text, Class185.smethod_0(-1141126775));
			Class67 class2 = new Class67(string_);
			DataGridView dataGridView_7 = smethod_235(Array.Empty<string>());
			class2.method_7(dataGridView_7, Class185.smethod_0(-1141322682));
			class2.method_8(Class185.smethod_0(-1141126670));
			Class55.smethod_3(dataGridView_7, Class185.smethod_0(-1141312985), class2);
			num += smethod_243(Class185.smethod_0(-1141126789), class2.method_3() > 0);
			Class67 class3 = new Class67(string_);
			DataGridView dataGridView_8 = smethod_235(Array.Empty<string>());
			class3.method_7(dataGridView_8, Class185.smethod_0(-1141322682));
			class3.method_8(Class185.smethod_0(-1141126670));
			num += smethod_244(Class185.smethod_0(-1141126814), Class185.smethod_0(-1141312985), smethod_124(dataGridView_8));
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
		DataGridView dataGridView4 = smethod_237(new string[3]
		{
			Class185.smethod_0(-1141339526),
			Class185.smethod_0(-1141276712),
			Class185.smethod_0(-1141126835)
		});
		dataGridView4.ClearSelection();
		dataGridView4.CurrentCell = null;
		num += smethod_244(Class185.smethod_0(-1141126856), 0, Class55.smethod_0(dataGridView4).Count);
		dataGridView4.Rows[1].Cells[0].Selected = true;
		num += smethod_244(Class185.smethod_0(-1141126868), Class185.smethod_0(-1141276712), smethod_240(Class55.smethod_0(dataGridView4)));
		dataGridView4.ClearSelection();
		dataGridView4.Rows[0].Cells[0].Selected = true;
		dataGridView4.Rows[0].Cells[1].Selected = true;
		dataGridView4.Rows[0].Cells[2].Selected = true;
		num += smethod_244(Class185.smethod_0(-1141126909), Class185.smethod_0(-1141339526), smethod_240(Class55.smethod_0(dataGridView4)));
		dataGridView4.ClearSelection();
		dataGridView4.Rows[2].Cells[1].Selected = true;
		dataGridView4.Rows[0].Cells[1].Selected = true;
		num += smethod_244(Class185.smethod_0(-1141126936), Class185.smethod_0(-1141126957), smethod_240(Class55.smethod_0(dataGridView4)));
		DataGridView dataGridView5 = smethod_237(new string[2]
		{
			Class185.smethod_0(-1141276712),
			Class185.smethod_0(-1141276712)
		});
		dataGridView5.ClearSelection();
		dataGridView5.Rows[0].Cells[1].Selected = true;
		dataGridView5.Rows[1].Cells[1].Selected = true;
		num += smethod_244(Class185.smethod_0(-1141126976), Class185.smethod_0(-1141276712), smethod_240(Class55.smethod_0(dataGridView5)));
		DataGridView dataGridView6 = smethod_237(new string[2]
		{
			Class185.smethod_0(-1141339526),
			Class185.smethod_0(-1141276712)
		});
		dataGridView6.CurrentCell = dataGridView6.Rows[1].Cells[1];
		dataGridView6.ClearSelection();
		num += smethod_244(Class185.smethod_0(-1141126996), Class185.smethod_0(-1141276712), smethod_240(Class55.smethod_0(dataGridView6)));
		DataGridView dataGridView7 = smethod_237(Array.Empty<string>());
		smethod_238(dataGridView7, Class185.smethod_0(-1141323060));
		dataGridView7.ClearSelection();
		dataGridView7.Rows[0].Cells[1].Selected = true;
		num += smethod_244(Class185.smethod_0(-1141127033), 0, Class55.smethod_0(dataGridView7).Count);
		DataGridView dataGridView8 = smethod_237(new string[2]
		{
			Class185.smethod_0(-1141312985),
			Class185.smethod_0(-1141310184)
		});
		DataGridView dataGridView9 = smethod_235(new string[1] { Class185.smethod_0(-1141312985) });
		num += smethod_244(Class185.smethod_0(-1141127072), 1, Class96.smethod_4(dataGridView8, dataGridView9));
		num += smethod_243(Class185.smethod_0(-1141127102), smethod_241(dataGridView8, 0));
		num += smethod_243(Class185.smethod_0(-1141127129), smethod_242(dataGridView8, 1));
		dataGridView8.Rows[0].Cells[1].Value = Class185.smethod_0(-1141310184);
		dataGridView8.Rows[1].Cells[1].Value = Class185.smethod_0(-1141324859);
		num += smethod_244(Class185.smethod_0(-1141127164), 0, Class96.smethod_4(dataGridView8, dataGridView9));
		num += smethod_243(Class185.smethod_0(-1141126163), smethod_242(dataGridView8, 0));
		dataGridView8.Rows[0].Cells[1].Value = Class185.smethod_0(-1141312985);
		Class96.smethod_4(dataGridView8, dataGridView9);
		num += smethod_243(Class185.smethod_0(-1141126199), smethod_241(dataGridView8, 0));
		dataGridView9.Rows.Clear();
		num += smethod_244(Class185.smethod_0(-1141126240), 0, Class96.smethod_4(dataGridView8, dataGridView9));
		num += smethod_243(Class185.smethod_0(-1141126266), smethod_242(dataGridView8, 0));
		DataGridView dataGridView_9 = smethod_237(new string[1] { Class185.smethod_0(-1141312985) });
		Class96.smethod_4(dataGridView_9, smethod_235(new string[1] { Class185.smethod_0(-1141312985) }));
		num += smethod_244(Class185.smethod_0(-1141126305), 0, Class96.smethod_4(dataGridView_9, null));
		num += smethod_243(Class185.smethod_0(-1141126342), smethod_242(dataGridView_9, 0));
		DataGridView dataGridView_10 = smethod_237(Array.Empty<string>());
		smethod_238(dataGridView_10, Class185.smethod_0(-1141323060));
		num += smethod_244(Class185.smethod_0(-1141126376), 0, Class96.smethod_4(dataGridView_10, smethod_235(new string[1] { Class185.smethod_0(-1141323060) })));
		num += smethod_243(Class185.smethod_0(-1141126401), smethod_242(dataGridView_10, 0));
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
		num += smethod_244(Class185.smethod_0(-1141126447), 1, class4.int_0);
		num += smethod_244(Class185.smethod_0(-1141126460), 6, 6);
		num += smethod_244(Class185.smethod_0(-1141126489), 10, 10);
		num += smethod_244(Class185.smethod_0(-1141126526), 60, 60);
		num += smethod_244(Class185.smethod_0(-1141126548), 3, Class432.smethod_0(0));
		num += smethod_244(Class185.smethod_0(-1141126589), 488, Class432.smethod_0(5));
		num += smethod_244(Class185.smethod_0(-1141126620), 3, Class432.smethod_0(6));
		num += smethod_244(Class185.smethod_0(-1141230085), 3, Class432.smethod_1(0));
		num += smethod_244(Class185.smethod_0(-1141230117), 59, Class432.smethod_1(6));
		num += smethod_244(Class185.smethod_0(-1141230146), 507, Class432.smethod_1(54));
		num += smethod_244(Class185.smethod_0(-1141230189), 584, 584);
		num += smethod_244(Class185.smethod_0(-1141230224), 582, 582);
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		dictionary[Class185.smethod_0(-1141356755)] = Class185.smethod_0(-1141323585);
		dictionary[Class185.smethod_0(-1141323615)] = Class185.smethod_0(-1141323707);
		Class95 class95_ = new Class95(null, dictionary, null);
		Class145 class145_ = Class145.class145_0.method_97(smethod_233(), null, class95_, 7, 24);
		string[] array = new string[60];
		string[] array2 = new string[60];
		num += smethod_244(Class185.smethod_0(-1141230252), 3, Class432.smethod_5(class145_, array, array2));
		num += smethod_244(Class185.smethod_0(-1141230293), Class185.smethod_0(-1141323585), array[0]);
		num += smethod_244(Class185.smethod_0(-1141230325), Class185.smethod_0(-1141323707), array[7]);
		num += smethod_244(Class185.smethod_0(-1141230357), string.Empty, array[1]);
		num += smethod_244(Class185.smethod_0(-1141230380), string.Empty, array[2]);
		num += smethod_244(Class185.smethod_0(-1141230411), string.Empty, array[4]);
		num += smethod_244(Class185.smethod_0(-1141230442), Class185.smethod_0(-1141322836), array[3]);
		num += smethod_244(Class185.smethod_0(-1141230473), Class185.smethod_0(-1141131485), array2[3]);
		num += smethod_244(Class185.smethod_0(-1141230490), string.Empty, array2[1]);
		num += smethod_244(Class185.smethod_0(-1141230526), Class185.smethod_0(-1141230551), Class432.smethod_6(class145_));
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
		num += smethod_244(Class185.smethod_0(-1141230556), 1, Class432.smethod_5(class145_2, array3, string_2));
		num += smethod_244(Class185.smethod_0(-1141230587), Class185.smethod_0(-1141229621), array3[5]);
		num += smethod_244(Class185.smethod_0(-1141229637), string.Empty, array3[0]);
		num += smethod_244(Class185.smethod_0(-1141229673), string.Empty, array3[59]);
		num += smethod_243(Class185.smethod_0(-1141229726), !Class432.smethod_2(23, 24));
		num += smethod_243(Class185.smethod_0(-1141229755), Class432.smethod_2(24, 24));
		num += smethod_243(Class185.smethod_0(-1141229794), Class432.smethod_2(59, 24));
		num += smethod_243(Class185.smethod_0(-1141229837), !Class432.smethod_2(59, 60));
		num += smethod_243(Class185.smethod_0(-1141229871), !Class432.smethod_2(0, 0));
		num += smethod_243(Class185.smethod_0(-1141229909), !Class432.smethod_2(59, 0));
		num += smethod_243(Class185.smethod_0(-1141229938), !Class432.smethod_2(59, -6));
		num += smethod_243(Class185.smethod_0(-1141229971), Class432.smethod_4(bool_0: false, bool_1: false, bool_2: false) == Class432.color_0);
		num += smethod_243(Class185.smethod_0(-1141229994), Class432.smethod_4(bool_0: true, bool_1: false, bool_2: false) == Class432.color_1);
		num += smethod_243(Class185.smethod_0(-1141230019), Class432.smethod_4(bool_0: false, bool_1: true, bool_2: false) == Class432.color_2);
		num += smethod_243(Class185.smethod_0(-1141230044), Class432.smethod_4(bool_0: true, bool_1: true, bool_2: false) == Class432.color_2);
		num += smethod_243(Class185.smethod_0(-1141230074), Class432.color_1 == Class96.color_0);
		int num3 = Class432.color_0.ToArgb();
		int num4 = Class432.color_1.ToArgb();
		int gparam_ = Class432.color_2.ToArgb();
		int num5 = Class432.color_3.ToArgb();
		int num6 = Class432.smethod_4(bool_0: false, bool_1: false, bool_2: true).ToArgb();
		int num7 = Class432.smethod_4(bool_0: true, bool_1: false, bool_2: true).ToArgb();
		num += smethod_244(Class185.smethod_0(-1141231137), num3, Class432.smethod_4(bool_0: false, bool_1: false, bool_2: false).ToArgb());
		num += smethod_244(Class185.smethod_0(-1141231170), num4, Class432.smethod_4(bool_0: true, bool_1: false, bool_2: false).ToArgb());
		num += smethod_244(Class185.smethod_0(-1141231203), gparam_, Class432.smethod_4(bool_0: false, bool_1: true, bool_2: false).ToArgb());
		num += smethod_244(Class185.smethod_0(-1141231246), gparam_, Class432.smethod_4(bool_0: true, bool_1: true, bool_2: false).ToArgb());
		num += smethod_244(Class185.smethod_0(-1141231288), gparam_, Class432.smethod_4(bool_0: false, bool_1: true, bool_2: true).ToArgb());
		num += smethod_244(Class185.smethod_0(-1141231322), gparam_, Class432.smethod_4(bool_0: true, bool_1: true, bool_2: true).ToArgb());
		num += smethod_243(Class185.smethod_0(-1141231371), num6 != num3);
		num += smethod_243(Class185.smethod_0(-1141231401), num7 != num4);
		num += smethod_243(Class185.smethod_0(-1141231439), num6 != num5);
		num += smethod_243(Class185.smethod_0(-1141231473), num7 != num5);
		num += smethod_243(Class185.smethod_0(-1141231515), num7 != num6);
		num += smethod_244(Class185.smethod_0(-1141231567), 96, 96);
		num += smethod_244(Class185.smethod_0(-1141231590), Color.FromArgb(255, 240, 159).ToArgb(), num6);
		num += smethod_244(Class185.smethod_0(-1141231610), Color.FromArgb(186, 229, 90).ToArgb(), num7);
		num += smethod_244(Class185.smethod_0(-1141230622), Color.White.ToArgb(), Class432.smethod_3(Color.White, Color.Gold, 0).ToArgb());
		num += smethod_244(Class185.smethod_0(-1141230650), Color.Gold.ToArgb(), Class432.smethod_3(Color.White, Color.Gold, 255).ToArgb());
		num += smethod_244(Class185.smethod_0(-1141230693), Color.White.ToArgb(), Class432.smethod_3(Color.White, Color.Gold, -8).ToArgb());
		num += smethod_244(Class185.smethod_0(-1141230733), 240, Class432.smethod_3(Class432.color_0, Class432.color_3, 96).G);
		num += smethod_244(Class185.smethod_0(-1141230773), 1, Class432.smethod_3(Color.FromArgb(1, 1, 1), Color.Black, 1).R);
		num += smethod_244(Class185.smethod_0(-1141230814), 255, Class432.smethod_3(Color.White, Color.Gold, 96).A);
		Class145 class145_3 = Class145.class145_0.method_99(Class185.smethod_0(-1141323060));
		string[] array4 = new string[60];
		string[] array5 = new string[60];
		num += smethod_244(Class185.smethod_0(-1141230835), 0, Class432.smethod_5(class145_3, array4, array5));
		num += smethod_244(Class185.smethod_0(-1141230867), string.Empty, array4[0]);
		num += smethod_244(Class185.smethod_0(-1141230905), string.Empty, array4[59]);
		num += smethod_243(Class185.smethod_0(-1141230950), !smethod_234(array4, Class185.smethod_0(-1141323060)) && !smethod_234(array5, Class185.smethod_0(-1141323060)));
		num += smethod_244(Class185.smethod_0(-1141230990), Class185.smethod_0(-1141323060), Class432.smethod_6(class145_3));
		Class145 class145_4 = Class145.class145_0.method_97(smethod_233(), null, Class95.class95_0, 7, 0);
		num += smethod_244(Class185.smethod_0(-1141231017), Class185.smethod_0(-1141136104), Class432.smethod_6(class145_4));
		num += smethod_244(Class185.smethod_0(-1141231062), Class185.smethod_0(-1141136219), Class432.smethod_6(null));
		num += smethod_244(Class185.smethod_0(-1141231091), 0, Class432.smethod_5(Class145.class145_0, null, null));
		num += smethod_244(Class185.smethod_0(-1141228049), 0, Class432.smethod_5(Class145.class145_0, new string[59], new string[60]));
		num += smethod_244(Class185.smethod_0(-1141228088), 0, Class432.smethod_5(null, new string[60], new string[60]));
		Console.WriteLine(Class185.smethod_0(-1141228118) + num + Class185.smethod_0(-1141356690));
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
		dataGridView.Columns.Add(Class185.smethod_0(-1141310112), Class185.smethod_0(-1141310115));
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
		dataGridView.Columns.Add(Class185.smethod_0(-1141125133), Class185.smethod_0(-1141125144));
		dataGridView.Columns.Add(Class185.smethod_0(-1141293587), Class185.smethod_0(-1141310115));
		dataGridView.Columns.Add(Class185.smethod_0(-1141228123), Class185.smethod_0(-1141228123));
		for (int i = 0; i < string_0.Length; i++)
		{
			dataGridView.Rows.Add(i.ToString(), string_0[i], Class185.smethod_0(-1141296467));
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
		return string.Join(Class185.smethod_0(-1141326297), list_0.ToArray());
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
		Console.WriteLine(Class185.smethod_0(-1141228144) + string_0);
		return 1;
	}

	private static int smethod_244<T>(string string_0, T gparam_0, T gparam_1)
	{
		if (EqualityComparer<T>.Default.Equals(gparam_0, gparam_1))
		{
			return 0;
		}
		string[] obj = new string[6]
		{
			Class185.smethod_0(-1141228144),
			string_0,
			Class185.smethod_0(-1141228157),
			null,
			null,
			null
		};
		T val = gparam_0;
		obj[3] = val?.ToString();
		obj[4] = Class185.smethod_0(-1141228175);
		val = gparam_1;
		obj[5] = val?.ToString();
		Console.WriteLine(string.Concat(obj));
		return 1;
	}

	internal static int smethod_245()
	{
		int num = 0;
		JObject val = JObject.Parse(Class428.smethod_6(60));
		num = 0 + smethod_244(Class185.smethod_0(-1141228191), Class185.smethod_0(-1141228204), (string)val[Class185.smethod_0(-1141228224)]);
		num += smethod_244(Class185.smethod_0(-1141228239), Class185.smethod_0(-1141228263), (string)val[Class185.smethod_0(-1141293578)]);
		num += smethod_244(Class185.smethod_0(-1141228268), 0.2f, (float)val[Class185.smethod_0(-1141228296)]);
		num += smethod_244(Class185.smethod_0(-1141228304), 1f, (float)val[Class185.smethod_0(-1141228316)]);
		num += smethod_244(Class185.smethod_0(-1141228324), 0.3f, (float)val[Class185.smethod_0(-1141228352)]);
		num += smethod_244(Class185.smethod_0(-1141228360), 0.25f, (float)val[Class185.smethod_0(-1141164113)]);
		num += smethod_243(Class185.smethod_0(-1141228372), val[Class185.smethod_0(-1141255982)] == null);
		JObject val2 = JObject.Parse(Class428.smethod_7(75, 11f, 22f, 33f));
		num += smethod_244(Class185.smethod_0(-1141228394), 11f, (float)val2[Class185.smethod_0(-1141255982)]);
		num += smethod_244(Class185.smethod_0(-1141228422), 22f, (float)val2[Class185.smethod_0(-1141255990)]);
		num += smethod_244(Class185.smethod_0(-1141228434), 33f, (float)val2[Class185.smethod_0(-1141255998)]);
		num += smethod_244(Class185.smethod_0(-1141228462), Class185.smethod_0(-1141228204), (string)JObject.Parse(Class428.smethod_8(90))[Class185.smethod_0(-1141228224)]);
		num += smethod_244(Class185.smethod_0(-1141228482), Class185.smethod_0(-1141228204), (string)JObject.Parse(Class428.smethod_9())[Class185.smethod_0(-1141228224)]);
		num += smethod_244(Class185.smethod_0(-1141228508), Class185.smethod_0(-1141228542), Class428.smethod_1(Class185.smethod_0(-1141227611), 2f, 1f, 0f, 0f, 0.15f, 1f, 2f, 3f));
		num += smethod_243(Class185.smethod_0(-1141227632), JObject.Parse(Class428.smethod_2(Class185.smethod_0(-1141227656), 1f, 1f, 0f, 0f, 0.15f, 1f, 2f, 3f, 4f, 5f, 6f))[Class185.smethod_0(-1141228224)] == null);
		num += smethod_243(Class185.smethod_0(-1141227660), JObject.Parse(Class428.smethod_0(Class185.smethod_0(-1141227701), 2f, 1f, 0f, 0f, 0.15f))[Class185.smethod_0(-1141228224)] == null);
		List<string> list = new List<string>();
		Class119 @class = new Class119();
		try
		{
			@class.method_30(list.Add);
			@class.method_108(Class185.smethod_0(-1141228263), 60);
			@class.method_109(Class185.smethod_0(-1141228263), 75, 11f, 22f, 33f);
			@class.method_113(Class185.smethod_0(-1141228263), 90);
			@class.method_114(Class185.smethod_0(-1141228263));
			@class.method_108(Class185.smethod_0(-1141227712), 12);
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		num += smethod_244(Class185.smethod_0(-1141227716), 5, list.Count);
		JObject val3 = JObject.Parse(list[0]);
		num += smethod_244(Class185.smethod_0(-1141227765), Class185.smethod_0(-1141228263), (string)val3[Class185.smethod_0(-1141293578)]);
		num += smethod_244(Class185.smethod_0(-1141227787), 1f, (float)val3[Class185.smethod_0(-1141228296)]);
		num += smethod_244(Class185.smethod_0(-1141227824), 0f, (float)val3[Class185.smethod_0(-1141228316)]);
		num += smethod_244(Class185.smethod_0(-1141227853), 0f, (float)val3[Class185.smethod_0(-1141228352)]);
		num += smethod_244(Class185.smethod_0(-1141227874), 0.15f, (float)val3[Class185.smethod_0(-1141164113)]);
		num += smethod_243(Class185.smethod_0(-1141227907), val3[Class185.smethod_0(-1141228224)] == null);
		num += smethod_243(Class185.smethod_0(-1141227946), val3[Class185.smethod_0(-1141255982)] == null);
		JObject val4 = JObject.Parse(list[1]);
		num += smethod_244(Class185.smethod_0(-1141227997), 11f, (float)val4[Class185.smethod_0(-1141255982)]);
		num += smethod_244(Class185.smethod_0(-1141228018), 22f, (float)val4[Class185.smethod_0(-1141255990)]);
		num += smethod_244(Class185.smethod_0(-1141229079), 33f, (float)val4[Class185.smethod_0(-1141255998)]);
		num += smethod_243(Class185.smethod_0(-1141229100), val4[Class185.smethod_0(-1141228224)] == null);
		JObject val5 = JObject.Parse(list[2]);
		num += smethod_244(Class185.smethod_0(-1141229139), 90, (int)val5[Class185.smethod_0(-1141229181)]);
		num += smethod_243(Class185.smethod_0(-1141229186), val5[Class185.smethod_0(-1141228224)] == null);
		JObject val6 = JObject.Parse(list[3]);
		num += smethod_243(Class185.smethod_0(-1141229225), !(bool)val6[Class185.smethod_0(-1141229262)]);
		num += smethod_243(Class185.smethod_0(-1141229271), val6[Class185.smethod_0(-1141228224)] == null);
		num += smethod_244(Class185.smethod_0(-1141229300), Class185.smethod_0(-1141229340), list[4]);
		num += smethod_243(Class185.smethod_0(-1141229431), !Class119.smethod_4(bool_17: false, Class185.smethod_0(-1141229459)));
		num += smethod_243(Class185.smethod_0(-1141229493), !Class119.smethod_4(bool_17: true, Class185.smethod_0(-1141252598)));
		num += smethod_243(Class185.smethod_0(-1141229527), Class119.smethod_4(bool_17: true, Class185.smethod_0(-1141229459)));
		num += smethod_243(Class185.smethod_0(-1141229559), !Class119.smethod_4(bool_17: true, Class185.smethod_0(-1141273605)));
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
		num += smethod_243(Class185.smethod_0(-1141228561), Class357.smethod_15(smethod_230(list2.ToArray()), out var string_));
		num += smethod_243(Class185.smethod_0(-1141228596), Class357.smethod_22());
		num += smethod_243(Class185.smethod_0(-1141228648), Class357.smethod_30());
		string text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141228687), text.Contains(Class185.smethod_0(-1141228721)));
		num += smethod_243(Class185.smethod_0(-1141228758), text.Contains(Class185.smethod_0(-1141228799)));
		num += smethod_243(Class185.smethod_0(-1141228818), text.Contains(Class185.smethod_0(-1141228857)));
		num += smethod_243(Class185.smethod_0(-1141228882), text.Contains(Class185.smethod_0(-1141228923)));
		num += smethod_243(Class185.smethod_0(-1141228959), text.Contains(Class185.smethod_0(-1141229000)));
		num += smethod_243(Class185.smethod_0(-1141229019), text.Contains(Class185.smethod_0(-1141170263)));
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
			if (item2.Item2 != Class185.smethod_0(-1141268893) && hashSet2.Add(item2.Item1))
			{
				list3.Add(item2);
			}
		}
		num += smethod_243(Class185.smethod_0(-1141234191), Class357.smethod_15(smethod_230(list3.ToArray()), out string_));
		num += smethod_243(Class185.smethod_0(-1141234232), !Class357.smethod_30());
		num += smethod_243(Class185.smethod_0(-1141234279), Class357.smethod_22());
		text = Class431.smethod_0() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141234335), !text.Contains(Class185.smethod_0(-1141228721)) && !text.Contains(Class185.smethod_0(-1141228799)));
		num += smethod_243(Class185.smethod_0(-1141234377), Class357.smethod_15(smethod_230(Class357.valueTuple_4), out string_));
		num += smethod_243(Class185.smethod_0(-1141234424), !Class357.smethod_30());
		num += smethod_243(Class185.smethod_0(-1141234469), Class357.smethod_15(smethod_230(list2.ToArray()), out string_));
		Class119 class2 = new Class119();
		try
		{
			class2.method_44(1L);
			num += smethod_243(Class185.smethod_0(-1141234504), !class2.method_97());
			smethod_250(class2, Class185.smethod_0(-1141234531), 1L);
			num += smethod_243(Class185.smethod_0(-1141234586), class2.method_97());
			class2.method_100(Class185.smethod_0(-1141234630), 1L);
			num += smethod_243(Class185.smethod_0(-1141234649), class2.method_97());
			smethod_250(class2, Class185.smethod_0(-1141233676), 1L);
			num += smethod_243(Class185.smethod_0(-1141233721), class2.method_97());
			class2.method_44(2L);
			smethod_250(class2, Class185.smethod_0(-1141233762), 1L);
			num += smethod_243(Class185.smethod_0(-1141233814), class2.method_97());
			smethod_250(class2, Class185.smethod_0(-1141233855), 2L);
			num += smethod_243(Class185.smethod_0(-1141233921), !class2.method_97());
			class2.method_100(Class185.smethod_0(-1141229459), 1L);
			num += smethod_243(Class185.smethod_0(-1141233963), !class2.method_97());
			smethod_250(class2, Class185.smethod_0(-1141256058), 2L);
			class2.method_210();
			num += smethod_243(Class185.smethod_0(-1141234013), !class2.method_97());
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
			num += smethod_243(Class185.smethod_0(-1141234044), class3.class119_0.method_97());
		}
		finally
		{
			if (class3.class119_0 != null)
			{
				((IDisposable)class3.class119_0).Dispose();
			}
		}
		Console.WriteLine((num == 0) ? Class185.smethod_0(-1141234125) : (Class185.smethod_0(-1141234098) + num));
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
		num += smethod_243(Class185.smethod_0(-1141234170), Class357.smethod_15(smethod_230(list.ToArray()), out var _));
		string text = smethod_173(Class185.smethod_0(-1141256766), ref num);
		if (text != null)
		{
			string string_2 = text.Replace(Class185.smethod_0(-1141235225), Class185.smethod_0(-1141254379));
			num += smethod_243(Class185.smethod_0(-1141235234), smethod_160(string_2, Class185.smethod_0(-1141235297)) == 2);
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
				RadioButton radioButton = (RadioButton)gForm.Controls.Find(Class185.smethod_0(-1141306354), searchAllChildren: true)[0];
				RadioButton radioButton2 = (RadioButton)gForm.Controls.Find(Class185.smethod_0(-1141305363), searchAllChildren: true)[0];
				CheckBox checkBox = (CheckBox)gForm.Controls.Find(Class185.smethod_0(-1141279737), searchAllChildren: true)[0];
				num += smethod_243(Class185.smethod_0(-1141235390), radioButton.Checked && !radioButton2.Checked);
				num += smethod_243(Class185.smethod_0(-1141235422), radioButton.Parent is Panel && radioButton.Parent == radioButton2.Parent && radioButton.Parent.Controls.Count == 2 && ((Panel)radioButton.Parent).BorderStyle == BorderStyle.None);
				RadioButton radioButton3 = new RadioButton
				{
					Checked = true
				};
				radioButton.Parent.Parent.Controls.Add(radioButton3);
				radioButton2.Checked = true;
				num += smethod_243(Class185.smethod_0(-1141235457), !radioButton.Checked && radioButton2.Checked && radioButton3.Checked);
				radioButton.Checked = true;
				num += smethod_243(Class185.smethod_0(-1141235499), radioButton.Checked && !radioButton2.Checked && radioButton3.Checked);
				typeof(GForm0).GetField(Class185.smethod_0(-1141256027), BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, @class);
				gForm.bool_2 = true;
				checkBox.Checked = true;
				num += smethod_243(Class185.smethod_0(-1141235543), list2.Count == 1 && JObject.Parse(list2[0])[Class185.smethod_0(-1141228224)] == null && (bool)JObject.Parse(list2[0])[Class185.smethod_0(-1141229262)]);
				radioButton2.Checked = true;
				num += smethod_243(Class185.smethod_0(-1141235573), list2.Count == 3 && !(bool)JObject.Parse(list2[1])[Class185.smethod_0(-1141229262)] && JObject.Parse(list2[1])[Class185.smethod_0(-1141228224)] == null && (string)JObject.Parse(list2[2])[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141235613) && (bool)JObject.Parse(list2[2])[Class185.smethod_0(-1141229262)]);
				smethod_250(@class, Class185.smethod_0(-1141256058), 1L);
				((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)).Invoke(gForm, null);
				num += smethod_243(Class185.smethod_0(-1141235630), list2.Count == 4 && (string)JObject.Parse(list2[3])[Class185.smethod_0(-1141228224)] == Class185.smethod_0(-1141228204) && (bool)JObject.Parse(list2[3])[Class185.smethod_0(-1141229262)]);
				radioButton.Checked = true;
				num += smethod_243(Class185.smethod_0(-1141235657), list2.Count == 7 && (string)JObject.Parse(list2[4])[Class185.smethod_0(-1141228224)] == Class185.smethod_0(-1141228204) && !(bool)JObject.Parse(list2[4])[Class185.smethod_0(-1141229262)] && (string)JObject.Parse(list2[5])[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141235613) && !(bool)JObject.Parse(list2[5])[Class185.smethod_0(-1141229262)] && JObject.Parse(list2[6])[Class185.smethod_0(-1141228224)] == null && (bool)JObject.Parse(list2[6])[Class185.smethod_0(-1141229262)]);
				checkBox.Checked = false;
				num += smethod_243(Class185.smethod_0(-1141235691), list2.Count == 8 && !(bool)JObject.Parse(list2[7])[Class185.smethod_0(-1141229262)]);
				int count = list2.Count;
				radioButton2.Checked = true;
				num += smethod_243(Class185.smethod_0(-1141234707), list2.Count == count);
				checkBox.Checked = true;
				num += smethod_243(Class185.smethod_0(-1141234753), (string)JObject.Parse(list2[list2.Count - 1])[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141235613) && (bool)JObject.Parse(list2[list2.Count - 1])[Class185.smethod_0(-1141229262)]);
				smethod_250(@class, Class185.smethod_0(-1141256058), 1L);
				MethodInfo obj = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
				obj.Invoke(gForm, null);
				int count2 = list2.Count;
				((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)).Invoke(@class, null);
				obj.Invoke(gForm, null);
				num += smethod_243(Class185.smethod_0(-1141234795), list2.Count == count2 + 1 && (string)JObject.Parse(list2[list2.Count - 1])[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141235613) && (bool)JObject.Parse(list2[list2.Count - 1])[Class185.smethod_0(-1141229262)]);
				smethod_250(@class, Class185.smethod_0(-1141256058), 1L);
				obj.Invoke(gForm, null);
				int count3 = list2.Count;
				checkBox.Checked = false;
				num += smethod_243(Class185.smethod_0(-1141234856), list2.Count == count3 + 2 && (string)JObject.Parse(list2[list2.Count - 1])[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141235613) && !(bool)JObject.Parse(list2[list2.Count - 1])[Class185.smethod_0(-1141229262)]);
				checkBox.Checked = true;
				num += smethod_243(Class185.smethod_0(-1141234889), list2.Count == count3 + 3 && (string)JObject.Parse(list2[list2.Count - 1])[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141235613) && (bool)JObject.Parse(list2[list2.Count - 1])[Class185.smethod_0(-1141229262)]);
				smethod_250(@class, Class185.smethod_0(-1141256058), 1L);
				obj.Invoke(gForm, null);
				int count4 = list2.Count;
				gForm.bool_2 = false;
				obj.Invoke(gForm, null);
				num += smethod_243(Class185.smethod_0(-1141234935), list2.Count == count4 + 2 && (string)JObject.Parse(list2[list2.Count - 1])[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141235613) && !(bool)JObject.Parse(list2[list2.Count - 1])[Class185.smethod_0(-1141229262)]);
				gForm.bool_2 = true;
				obj.Invoke(gForm, null);
				num += smethod_243(Class185.smethod_0(-1141234981), list2.Count == count4 + 3 && (string)JObject.Parse(list2[list2.Count - 1])[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141235613) && (bool)JObject.Parse(list2[list2.Count - 1])[Class185.smethod_0(-1141229262)]);
				long num2 = @class.method_98();
				@class.method_204(1, new IntPtr(1));
				num += smethod_243(Class185.smethod_0(-1141235024), @class.method_98() > num2);
				@class.method_44(2L);
				int count5 = list2.Count;
				obj.Invoke(gForm, null);
				num += smethod_243(Class185.smethod_0(-1141235077), list2.Count == count5 + 1 && (string)JObject.Parse(list2[list2.Count - 1])[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141235613) && (bool)JObject.Parse(list2[list2.Count - 1])[Class185.smethod_0(-1141229262)]);
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
			class2.method_110(Class185.smethod_0(-1141235126), 2f, 1f, 0f, 0f, 0.15f, 11f, 22f, 33f);
			num += smethod_243(Class185.smethod_0(-1141235141), (float)JObject.Parse(list2[0])[Class185.smethod_0(-1141255982)] == 11f && (float)JObject.Parse(list2[0])[Class185.smethod_0(-1141255990)] == 22f && (float)JObject.Parse(list2[0])[Class185.smethod_0(-1141255998)] == 33f && (string)JObject.Parse(list2[0])[Class185.smethod_0(-1141228224)] == Class185.smethod_0(-1141228204));
			num += smethod_243(Class185.smethod_0(-1141235190), (int)JObject.Parse(list2[1])[Class185.smethod_0(-1141229181)] == 90 && (string)JObject.Parse(list2[1])[Class185.smethod_0(-1141228224)] == Class185.smethod_0(-1141228204));
			num += smethod_243(Class185.smethod_0(-1141232148), !(bool)JObject.Parse(list2[2])[Class185.smethod_0(-1141229262)] && (string)JObject.Parse(list2[2])[Class185.smethod_0(-1141228224)] == Class185.smethod_0(-1141228204));
			num += smethod_243(Class185.smethod_0(-1141232192), JObject.Parse(list2[3])[Class185.smethod_0(-1141228224)] == null);
		}
		Console.WriteLine((num == 0) ? Class185.smethod_0(-1141232248) : (Class185.smethod_0(-1141232217) + num));
		return num;
	}

	internal static int smethod_247()
	{
		int num = 0;
		num = 0 + smethod_243(Class185.smethod_0(-1141232310), Class357.smethod_15(smethod_230(Class357.valueTuple_2), out var string_));
		num += smethod_243(Class185.smethod_0(-1141232335), Class357.smethod_26() && !Class357.smethod_28());
		JObject val = JObject.Parse(Class431.smethod_0());
		string[] array = new string[5]
		{
			Class185.smethod_0(-1141268714),
			Class185.smethod_0(-1141268784),
			Class185.smethod_0(-1141268833),
			Class185.smethod_0(-1141268893),
			Class185.smethod_0(-1141232362)
		};
		foreach (string text in array)
		{
			num += smethod_243(Class185.smethod_0(-1141232389) + text, val[Class185.smethod_0(-1141232408)][(object)text] != null);
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
			if (@class.valueTuple_0.Item2 == Class185.smethod_0(-1141268893))
			{
				list.RemoveAll(@class.method_0);
			}
			num += smethod_243(Class185.smethod_0(-1141232410) + @class.valueTuple_0.Item2, Class357.smethod_15(smethod_230(list.ToArray()), out string_));
			num += smethod_243(Class185.smethod_0(-1141232435) + @class.valueTuple_0.Item2, !Class357.smethod_26());
			if (@class.valueTuple_0.Item2 != Class185.smethod_0(-1141268893))
			{
				num += smethod_243(Class185.smethod_0(-1141232466) + @class.valueTuple_0.Item2, Class357.smethod_28());
			}
			val = JObject.Parse(Class431.smethod_0());
			num += smethod_243(Class185.smethod_0(-1141232498) + @class.valueTuple_0.Item2, val[Class185.smethod_0(-1141232408)][(object)Class185.smethod_0(-1141268833)] == null);
		}
		num += smethod_243(Class185.smethod_0(-1141232530), Class357.smethod_15(smethod_230(Array.Empty<(string, string)>()), out string_));
		num += smethod_243(Class185.smethod_0(-1141232568), !Class357.smethod_26());
		Console.WriteLine((num == 0) ? Class185.smethod_0(-1141232621) : (Class185.smethod_0(-1141232596) + num));
		return num;
	}

	internal static int smethod_248()
	{
		int num = 0;
		num = 0 + smethod_244(Class185.smethod_0(-1141231620), 0.6f, Class143.smethod_0(6));
		num += smethod_244(Class185.smethod_0(-1141231651), 11.6f, Class143.smethod_0(116));
		num += smethod_244(Class185.smethod_0(-1141231682), 0.5f, Class143.smethod_0(5));
		num += smethod_244(Class185.smethod_0(-1141231733), 11.7f, Class143.smethod_0(117));
		Struct137 struct137_ = default(Struct137);
		Struct1 struct1_ = default(Struct1);
		num += smethod_243(Class185.smethod_0(-1141231776), Class143.smethod_2(struct1_, Enum0.Selected, bool_0: true));
		Class143.smethod_3(ref struct1_);
		num += smethod_243(Class185.smethod_0(-1141231824), !Class143.smethod_2(struct1_, Enum0.Started, bool_0: true));
		Class143.smethod_4(ref struct1_, new Class400(bool_2: true, bool_3: true, string.Empty, 1f, 80f));
		num += smethod_243(Class185.smethod_0(-1141231873), struct1_.bool_1 && struct1_.bool_2 && struct1_.nullable_0.GetValueOrDefault() == 1f);
		Struct1 struct1_2 = struct1_;
		Class143.smethod_4(ref struct1_2, new Class400(bool_2: false, bool_3: false, Class185.smethod_0(-1141231919), null, null));
		num += smethod_243(Class185.smethod_0(-1141231944), !struct1_2.bool_1 && !struct1_2.bool_2 && !struct1_2.nullable_0.HasValue);
		num += smethod_243(Class185.smethod_0(-1141231994), !Class143.smethod_5(struct137_, struct1_, Enum0.Selected, bool_0: true).bool_0);
		Struct137 struct137_2 = default(Struct137);
		Class143.smethod_1(ref struct137_2, 10);
		num += smethod_243(Class185.smethod_0(-1141232036), struct137_2.bool_0 && struct137_2.float_0 == 1f && struct137_2.int_0 == 1);
		Struct1 struct1_3 = default(Struct1);
		num += smethod_243(Class185.smethod_0(-1141232094), !Class143.smethod_5(struct137_2, struct1_3, Enum0.Selected, bool_0: false).bool_0);
		Struct17 struct17_ = Class143.smethod_5(struct137_2, struct1_3, Enum0.Selected, bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141233169), struct17_.bool_0 && struct17_.float_0 == 1f);
		Class143.smethod_6(ref struct1_3, struct17_, 31u, 0L);
		num += smethod_243(Class185.smethod_0(-1141233231), !Class143.smethod_5(struct137_2, struct1_3, Enum0.Started, bool_0: true).bool_0);
		Class143.smethod_9(ref struct1_3, new Class101(bool_2: true, 31u, 1f, string.Empty));
		Class143.smethod_1(ref struct137_2, 37);
		Struct17 struct17_2 = Class143.smethod_5(struct137_2, struct1_3, Enum0.Selected, bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141233286), struct137_2.int_0 == 2 && struct17_2.bool_0 && struct17_2.float_0 == 3.7f);
		Class143.smethod_6(ref struct1_3, struct17_2, 32u, 0L);
		Class143.smethod_9(ref struct1_3, new Class101(bool_2: true, 32u, 3.7f, string.Empty));
		Class143.smethod_10(ref struct1_3, new Class101(bool_2: true, 0u, 3.8f, string.Empty, 304f));
		num += smethod_243(Class185.smethod_0(-1141233339), !Class143.smethod_5(struct137_2, struct1_3, Enum0.Started, bool_0: true).bool_0 && !Class143.smethod_5(struct137_2, struct1_3, Enum0.Selected, bool_0: true).bool_0 && struct1_3.nullable_0.GetValueOrDefault() == 3.8f);
		Struct137 @struct = new Struct137
		{
			bool_0 = true,
			float_0 = 1.6f,
			int_0 = 1
		};
		num += smethod_243(Class185.smethod_0(-1141233415), !Class143.smethod_5(@struct, struct1_, Enum0.Attached, bool_0: true).bool_0);
		num += smethod_243(Class185.smethod_0(-1141233444), !Class143.smethod_5(@struct, struct1_, Enum0.Selected, bool_0: false).bool_0);
		Struct17 struct17_3 = Class143.smethod_5(@struct, struct1_, Enum0.Selected, bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141233484), struct17_3.bool_0 && struct17_3.float_0 == 1.6f && struct17_3.int_0 == 1);
		Class143.smethod_6(ref struct1_, struct17_3, 41u, 0L);
		num += smethod_243(Class185.smethod_0(-1141233535), !Class143.smethod_5(@struct, struct1_, Enum0.Started, bool_0: true).bool_0);
		Struct1 struct1_4 = default(Struct1);
		Class143.smethod_6(ref struct1_4, struct17_3, 51u, 100L);
		num += smethod_243(Class185.smethod_0(-1141233571), !Class143.smethod_8(ref struct1_4, 2099L));
		num += smethod_243(Class185.smethod_0(-1141233620), Class143.smethod_8(ref struct1_4, 2100L) && struct1_4.uint_0 == 0 && !Class143.smethod_5(@struct, struct1_4, Enum0.Started, bool_0: true).bool_0);
		Class101 class101_ = new Class101(bool_2: true, 40u, 2.1f, string.Empty);
		num += smethod_243(Class185.smethod_0(-1141232655), !Class143.smethod_9(ref struct1_, class101_) && struct1_.uint_0 == 41);
		Struct137 struct137_3 = @struct;
		struct137_3.float_0 = 2.2f;
		struct137_3.int_0 = 2;
		Class143.smethod_7(ref struct1_);
		Struct17 struct17_4 = Class143.smethod_5(struct137_3, struct1_, Enum0.Started, bool_0: true);
		Class143.smethod_6(ref struct1_, struct17_4, 42u, 0L);
		num += smethod_243(Class185.smethod_0(-1141232693), !Class143.smethod_9(ref struct1_, new Class101(bool_2: true, 41u, 1.6f, string.Empty)));
		num += smethod_243(Class185.smethod_0(-1141232736), Class143.smethod_9(ref struct1_, new Class101(bool_2: true, 42u, 2.15f, string.Empty)) && struct1_.nullable_0.GetValueOrDefault() == 2.15f);
		Class101 class101_2 = new Class101(bool_2: true, 0u, 2.4f, string.Empty, 192f);
		num += smethod_243(Class185.smethod_0(-1141232782), Class143.smethod_10(ref struct1_, class101_2) && Class143.smethod_11(struct1_.nullable_0) == Class185.smethod_0(-1141232848) && !Class143.smethod_5(struct137_3, struct1_, Enum0.Started, bool_0: true).bool_0);
		num += smethod_244(Class185.smethod_0(-1141232864), Class185.smethod_0(-1141280428), Class143.smethod_11(null));
		num += smethod_244(Class185.smethod_0(-1141232902), Class185.smethod_0(-1141232935), Class143.smethod_11(2.15f));
		Class143.smethod_12(ref struct1_);
		num += smethod_243(Class185.smethod_0(-1141232952), struct1_.uint_0 == 0 && !struct1_.nullable_0.HasValue);
		num += smethod_243(Class185.smethod_0(-1141232993), !Class143.smethod_5(struct137_3, struct1_, Enum0.Selected, bool_0: true).bool_0);
		Struct1 struct1_5 = default(Struct1);
		Class143.smethod_12(ref struct1_5);
		num += smethod_243(Class185.smethod_0(-1141233063), Class143.smethod_5(struct137_3, struct1_5, Enum0.Selected, bool_0: true).bool_0);
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		try
		{
			CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(Class185.smethod_0(-1141233128));
			num += smethod_244(Class185.smethod_0(-1141233132), Class185.smethod_0(-1141238295), Class178.smethod_2(2.2f, 7u));
			num += smethod_244(Class185.smethod_0(-1141238331), Class185.smethod_0(-1141238363), Class178.smethod_3());
		}
		finally
		{
			CultureInfo.CurrentCulture = currentCulture;
		}
		num += smethod_243(Class185.smethod_0(-1141238395), Class119.smethod_26(JObject.Parse(Class185.smethod_0(-1141238428))) != null);
		Class101 @class = Class119.smethod_26(JObject.Parse(Class185.smethod_0(-1141238506)));
		num += smethod_243(Class185.smethod_0(-1141238592), @class != null && @class.uint_0 == 0 && @class.nullable_0.GetValueOrDefault() == 2.25f && @class.nullable_1.GetValueOrDefault() == 180f && @class.bool_1);
		Struct1 struct1_6 = default(Struct1);
		num += smethod_243(Class185.smethod_0(-1141238627), Class143.smethod_10(ref struct1_6, @class) && struct1_6.bool_1 && struct1_6.bool_2 && struct1_6.nullable_0.GetValueOrDefault() == 2.25f);
		Class143.smethod_4(ref struct1_6, new Class400(bool_2: true, bool_3: true, string.Empty, null, null));
		num += smethod_243(Class185.smethod_0(-1141238693), struct1_6.bool_1 && struct1_6.bool_2 && struct1_6.nullable_0.GetValueOrDefault() == 2.25f);
		Class143.smethod_4(ref struct1_6, new Class400(bool_2: false, bool_3: false, Class185.smethod_0(-1141231919), null, null));
		num += smethod_243(Class185.smethod_0(-1141238747), !struct1_6.bool_1 && !struct1_6.bool_2 && !struct1_6.nullable_0.HasValue);
		num += smethod_243(Class185.smethod_0(-1141237785), Class119.smethod_26(JObject.Parse(Class185.smethod_0(-1141237838))) == null);
		num += smethod_243(Class185.smethod_0(-1141237884), Class119.smethod_26(JObject.Parse(Class185.smethod_0(-1141237941))) == null);
		Class400 class2 = Class119.smethod_27(JObject.Parse(Class185.smethod_0(-1141237982)));
		num += smethod_243(Class185.smethod_0(-1141238067), class2 != null && class2.bool_0 && class2.bool_1 && class2.nullable_0.GetValueOrDefault() == 1f && class2.nullable_1.GetValueOrDefault() == 80f);
		List<string> list = new List<string>();
		Class119 class3 = new Class119();
		try
		{
			class3.method_30(list.Add);
			num += smethod_243(Class185.smethod_0(-1141238117), class3.method_118(3.4f, out var uint_) && uint_ != 0 && list.Count == 1 && list[0] == Class178.smethod_2(3.4f, uint_));
			num += smethod_243(Class185.smethod_0(-1141238159), !class3.method_118(float.NaN, out uint_) && list.Count == 1);
			num += smethod_243(Class185.smethod_0(-1141238205), !class3.method_118(0f, out uint_) && !class3.method_118(-1f, out uint_) && list.Count == 1);
			class3.method_43(-1);
			num += smethod_243(Class185.smethod_0(-1141238253), class3.method_118(1f, out uint_) && uint_ == 1 && list.Count == 2 && list[1] == Class178.smethod_2(1f, uint_));
			class3.method_119();
			num += smethod_243(Class185.smethod_0(-1141239321), list.Count == 3 && list[2] == Class178.smethod_3());
		}
		finally
		{
			((IDisposable)class3).Dispose();
		}
		using (GForm0 gForm = new GForm0())
		{
			TrackBar trackBar = gForm.method_121();
			System.Windows.Forms.Label label = gForm.method_122();
			num += smethod_243(Class185.smethod_0(-1141239362), trackBar != null && trackBar.Minimum == 6 && trackBar.Maximum == 116 && trackBar.Value == 10 && label != null && label.Text == Class185.smethod_0(-1141280428));
			trackBar.Value = 16;
			Struct137 struct2 = gForm.method_123();
			num += smethod_243(Class185.smethod_0(-1141239419), !struct2.bool_0);
			gForm.method_126();
			Struct137 struct3 = gForm.method_123();
			num += smethod_243(Class185.smethod_0(-1141239478), struct3.bool_0 && struct3.float_0 == 1.6f && struct3.int_0 == 1);
			gForm.method_125();
			Struct137 struct4 = gForm.method_123();
			num += smethod_243(Class185.smethod_0(-1141239523), struct4.bool_0 && struct4.float_0 == 1.6f && struct4.int_0 == 2 && label.Text == Class185.smethod_0(-1141280428));
			System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer
			{
				Interval = 250
			};
			timer.Start();
			gForm.method_124(timer);
			gForm.method_125();
			num += smethod_243(Class185.smethod_0(-1141239583), !timer.Enabled);
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
			smethod_250(class4, Class185.smethod_0(-1141239639), 1L);
			smethod_250(class4, Class185.smethod_0(-1141256109), 1L);
			class4.method_44(2L);
			class6.method_0();
			num += smethod_243(Class185.smethod_0(-1141239708), class5.int_0 == 0 && class5.int_1 == 0);
			smethod_250(class4, Class185.smethod_0(-1141239761), 2L);
			class6.method_0();
			num += smethod_243(Class185.smethod_0(-1141238822), class5.int_0 == 1 && class5.int_1 == 0);
		}
		finally
		{
			((IDisposable)class4).Dispose();
		}
		Console.WriteLine(Class185.smethod_0(-1141238866) + num + Class185.smethod_0(-1141356690));
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
		return smethod_243(Class185.smethod_0(-1141238896), flag && flag2 && flag3 && flag4 && @class.exception_1 == null && @class.exception_0 == null);
	}

	private static void smethod_250(Class119 class119_0, string string_0, long long_1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0 + Class185.smethod_0(-1141299436));
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
		return smethod_252(Class185.smethod_0(-1141238949), smethod_253) + smethod_252(Class185.smethod_0(-1141238983), smethod_254) + smethod_252(Class185.smethod_0(-1141239011), smethod_256) + smethod_252(Class185.smethod_0(-1141239063), smethod_255) + smethod_252(Class185.smethod_0(-1141239093), smethod_257) + smethod_252(Class185.smethod_0(-1141239122), smethod_259) + smethod_252(Class185.smethod_0(-1141239164), smethod_258) + smethod_252(Class185.smethod_0(-1141239205), smethod_260) + smethod_252(Class185.smethod_0(-1141239233), smethod_261);
	}

	private static int smethod_252(string string_0, Func<int> func_0)
	{
		try
		{
			return func_0();
		}
		catch (Exception ex)
		{
			Console.WriteLine(Class185.smethod_0(-1141239277) + string_0 + Class185.smethod_0(-1141301932) + ex.GetType().Name);
			return 1;
		}
	}

	private static int smethod_253()
	{
		int num = 0;
		num = 0 + smethod_244(Class185.smethod_0(-1141239281), TimeSpan.FromSeconds(30.0), Class92.timeSpan_0);
		num += smethod_244(Class185.smethod_0(-1141236264), TimeSpan.FromMilliseconds(300.0), Class92.timeSpan_1);
		Class246 @class = new Class246();
		try
		{
			@class.method_2(1400);
			bool result = Class343.smethod_4(@class.method_0(), TimeSpan.FromSeconds(2.0), TimeSpan.FromMilliseconds(20.0), CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243(Class185.smethod_0(-1141236302), result);
			num += smethod_243(Class185.smethod_0(-1141236343), Class343.smethod_3(@class.method_0()));
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
			num += smethod_243(Class185.smethod_0(-1141236380), result2);
		}
		finally
		{
			if (class2.class246_0 != null)
			{
				((IDisposable)class2.class246_0).Dispose();
			}
		}
		string string_ = Class185.smethod_0(-1141258552) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407));
		Stopwatch stopwatch = Stopwatch.StartNew();
		bool result3 = Class343.smethod_4(string_, TimeSpan.FromMilliseconds(160.0), TimeSpan.FromMilliseconds(20.0), CancellationToken.None).GetAwaiter().GetResult();
		stopwatch.Stop();
		num += smethod_243(Class185.smethod_0(-1141236432), !result3);
		return num + smethod_243(Class185.smethod_0(-1141236465), stopwatch.Elapsed >= TimeSpan.FromMilliseconds(120.0) && stopwatch.Elapsed < TimeSpan.FromSeconds(2.0));
	}

	private static int smethod_254()
	{
		Class217 @class = new Class217();
		int num = 0;
		Class242 class2 = new Class242();
		Class17 class3 = new Class17();
		@class.int_0 = 0;
		using Class92 class4 = new Class92(Class185.smethod_0(-1141236514), TimeSpan.FromMilliseconds(20.0), Class299.class299_0.method_99, class2.method_0, class3.method_0, Class299.class299_0.method_100);
		bool result = class4.method_0(Class299.class299_0.method_101, TimeSpan.FromSeconds(1.0), TimeSpan.FromMilliseconds(20.0), CancellationToken.None).GetAwaiter().GetResult();
		num += smethod_243(Class185.smethod_0(-1141236537), result);
		num += smethod_243(Class185.smethod_0(-1141236590), class2.method_1(TimeSpan.FromSeconds(1.0)));
		class2.method_3();
		num += smethod_244(Class185.smethod_0(-1141236625), 0, @class.int_0);
		bool flag = class3.method_1(@class.method_0);
		num += smethod_243(Class185.smethod_0(-1141236675), !flag);
		num += smethod_244(Class185.smethod_0(-1141236724), 1, @class.int_0);
		class3.method_0();
		Thread.Sleep(80);
		class2.method_3();
		return num + smethod_244(Class185.smethod_0(-1141235760), 1, @class.int_0);
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
				num += smethod_243(Class185.smethod_0(-1141235807), result);
				class3.class246_0.method_3(TimeSpan.FromSeconds(3.0));
				Stopwatch stopwatch = Stopwatch.StartNew();
				bool bool_ = class2.method_2(@class.method_1, TimeSpan.FromSeconds(2.0));
				stopwatch.Stop();
				num += smethod_243(Class185.smethod_0(-1141235841), bool_);
				num += smethod_243(Class185.smethod_0(-1141235888), stopwatch.Elapsed <= TimeSpan.FromMilliseconds(1300.0));
				num += smethod_243(Class185.smethod_0(-1141235933), list.Exists(class3.method_0));
				Thread.Sleep(500);
				class2.method_3();
				num += smethod_244(Class185.smethod_0(-1141235975), 1, @class.int_0);
				return num + smethod_243(Class185.smethod_0(-1141236011), !Class343.smethod_3(class3.class246_0.method_0()));
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
			num += smethod_243(Class185.smethod_0(-1141236063), !flag);
			num += smethod_243(Class185.smethod_0(-1141236110), bool_);
			num += smethod_243(Class185.smethod_0(-1141236145), Volatile.Read(ref class2.int_0) >= 1);
			num += smethod_244(Class185.smethod_0(-1141236200), 1, Volatile.Read(ref class2.int_1));
			num += smethod_244(Class185.smethod_0(-1141237267), 1, Volatile.Read(ref class2.int_2));
			num += smethod_243(Class185.smethod_0(-1141237327), @class.gform0_0.method_3());
			return num + smethod_243(Class185.smethod_0(-1141237370), !@class.gform0_0.Visible);
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
		Class92 class3 = new Class92(Class185.smethod_0(-1141237419), TimeSpan.FromMilliseconds(20.0), Class299.class299_0.method_102, class2.method_0, @class.method_0, list.Add);
		try
		{
			bool result = class3.method_0(Class299.class299_0.method_103, TimeSpan.FromSeconds(1.0), TimeSpan.FromMilliseconds(20.0), CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243(Class185.smethod_0(-1141237445), result);
			num += smethod_243(Class185.smethod_0(-1141237485), class2.method_2(@class.method_1, TimeSpan.FromSeconds(1.0)));
			return num + smethod_243(Class185.smethod_0(-1141237514), list.Exists(Class299.class299_0.method_104));
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
		Class92 class3 = new Class92(Class185.smethod_0(-1141237554), TimeSpan.FromMilliseconds(20.0), Class299.class299_0.method_105, class2.method_0, @class.method_0, Class299.class299_0.method_106);
		bool result = class3.method_0(Class299.class299_0.method_107, TimeSpan.FromSeconds(1.0), TimeSpan.FromMilliseconds(20.0), CancellationToken.None).GetAwaiter().GetResult();
		int num = smethod_243(Class185.smethod_0(-1141237582), result) + smethod_243(Class185.smethod_0(-1141237624), class2.method_1(TimeSpan.FromSeconds(1.0)));
		class3.Dispose();
		class2.method_3();
		int result2 = num + smethod_244(Class185.smethod_0(-1141237664), 0, @class.int_0);
		class3.Dispose();
		return result2;
	}

	private static int smethod_259()
	{
		Class207 @class = new Class207();
		int num = 0;
		@class.int_0 = 0;
		@class.list_0 = new List<string>();
		Class92 class2 = new Class92(Class185.smethod_0(-1141237706), TimeSpan.FromMilliseconds(20.0), Class299.class299_0.method_108, Class299.class299_0.method_109, @class.method_0, @class.list_0.Add);
		try
		{
			class2.method_0(Class299.class299_0.method_110, TimeSpan.FromSeconds(1.0), TimeSpan.FromMilliseconds(20.0), CancellationToken.None).GetAwaiter().GetResult();
			bool bool_ = SpinWait.SpinUntil(@class.method_1, TimeSpan.FromSeconds(1.0));
			num += smethod_243(Class185.smethod_0(-1141237743), bool_);
			num += smethod_244(Class185.smethod_0(-1141236768), 0, @class.int_0);
			return num + smethod_243(Class185.smethod_0(-1141236818), @class.list_0.TrueForAll(Class299.class299_0.method_112));
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
		using Class92 class3 = new Class92(Class185.smethod_0(-1141236877), TimeSpan.FromMilliseconds(10.0), Class299.class299_0.method_113, class2.method_0, @class.method_0, Class299.class299_0.method_114);
		class3.method_0(Class299.class299_0.method_115, TimeSpan.FromSeconds(1.0), TimeSpan.FromMilliseconds(10.0), CancellationToken.None).GetAwaiter().GetResult();
		class2.method_2(@class.method_1, TimeSpan.FromSeconds(1.0));
		Thread.Sleep(100);
		class2.method_3();
		return num + smethod_244(Class185.smethod_0(-1141236892), 1, @class.int_0);
	}

	private static int smethod_261()
	{
		return smethod_263(Class185.smethod_0(-1141273631), null) + smethod_263(Class185.smethod_0(-1141273605), new GClass0
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
		return smethod_243(Class185.smethod_0(-1141236951), !result) + smethod_244(Class185.smethod_0(-1141237005), 1, @class.int_0) + smethod_244(Class185.smethod_0(-1141237062), 0, @class.int_1) + smethod_244(Class185.smethod_0(-1141237118), 1, @class.int_3) + smethod_244(Class185.smethod_0(-1141237170), 1, @class.int_2) + smethod_244(Class185.smethod_0(-1141237226), 0, @class.int_4) + smethod_244(Class185.smethod_0(-1141242416), 0, @class.int_5);
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
		return smethod_243(Class185.smethod_0(-1141242469) + string_0 + Class185.smethod_0(-1141242501), !result) + smethod_244(Class185.smethod_0(-1141242469) + string_0 + Class185.smethod_0(-1141242517), 1, @class.int_0) + smethod_244(Class185.smethod_0(-1141242469) + string_0 + Class185.smethod_0(-1141242536), 1, @class.int_1) + smethod_244(Class185.smethod_0(-1141242469) + string_0 + Class185.smethod_0(-1141242551), 0, @class.int_2) + smethod_244(Class185.smethod_0(-1141242469) + string_0 + Class185.smethod_0(-1141242574), 0, @class.int_3) + smethod_244(Class185.smethod_0(-1141242469) + string_0 + Class185.smethod_0(-1141242586), 0, @class.int_4) + smethod_244(Class185.smethod_0(-1141242469) + string_0 + Class185.smethod_0(-1141242610), 0, @class.int_5);
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
				Console.Error.WriteLine(Class185.smethod_0(-1141242625) + string_0);
				return 2;
			}
			string directoryName = Path.GetDirectoryName(Path.GetFullPath(string_1));
			if (!Directory.Exists(directoryName))
			{
				Console.Error.WriteLine(Class185.smethod_0(-1141242679) + directoryName);
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
			Console.WriteLine(Class185.smethod_0(-1141242733) + num + Class185.smethod_0(-1141242764) + array.Length + Class185.smethod_0(-1141242779) + Path.GetFullPath(string_1));
			return 0;
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(Class185.smethod_0(-1141242794) + ex.GetType().Name + Class185.smethod_0(-1141301932) + ex.Message);
			return 1;
		}
	}

	internal static int smethod_266()
	{
		Class235 @class = new Class235();
		int num = 0;
		@class.string_0 = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141242827) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
		Directory.CreateDirectory(@class.string_0);
		try
		{
			string path = Path.Combine(@class.string_0, Class185.smethod_0(-1141242851));
			using (DataGridView dataGridView = smethod_267())
			{
				Class67 class2 = new Class67(@class.string_0);
				class2.method_6(dataGridView, Class185.smethod_0(-1141242851), bool_0: false);
				dataGridView.Rows.Add(Class185.smethod_0(-1141324125));
				int gparam_ = class2.method_3();
				using (class2.method_17(dataGridView))
				{
				}
				num += smethod_244(Class185.smethod_0(-1141242880), gparam_, class2.method_3());
				using (DataGridView dataGridView2 = smethod_267())
				{
					new Class67(@class.string_0).method_6(dataGridView2, Class185.smethod_0(-1141242851), bool_0: false);
					dataGridView2.Rows.Add(Class185.smethod_0(-1141324133));
					string text = File.ReadAllText(path, Encoding.UTF8);
					num += smethod_243(Class185.smethod_0(-1141241903), text.Contains(Class185.smethod_0(-1141241931)) && text.Contains(Class185.smethod_0(-1141241949)));
				}
				gparam_ = class2.method_3();
				FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
				try
				{
					dataGridView.Rows.Add(Class185.smethod_0(-1141297596));
				}
				finally
				{
					((IDisposable)fileStream).Dispose();
				}
				num += smethod_244(Class185.smethod_0(-1141241959), gparam_, class2.method_3());
				using (class2.method_17(dataGridView))
				{
				}
				num += smethod_243(Class185.smethod_0(-1141241993), class2.method_3() == gparam_ + 1 && File.ReadAllText(path, Encoding.UTF8).Contains(Class185.smethod_0(-1141242048)));
				File.WriteAllText(path, Class185.smethod_0(-1141242050), Encoding.UTF8);
				gparam_ = class2.method_3();
				dataGridView.Rows.Add(Class185.smethod_0(-1141242077));
				num += smethod_243(Class185.smethod_0(-1141242085), File.ReadAllText(path, Encoding.UTF8) == Class185.smethod_0(-1141242050) && class2.method_3() == gparam_);
			}
			string path2 = Path.Combine(@class.string_0, Class185.smethod_0(-1141255210));
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
					num += smethod_243(Class185.smethod_0(-1141242114), flag && flag2 && @class.exception_0[0] == null && @class.exception_0[1] == null);
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
			num += smethod_244(Class185.smethod_0(-1141242168), 40, (class4 == null || class4.List_1 == null) ? (-1) : class4.List_1.Count);
		}
		finally
		{
			string fullPath = Path.GetFullPath(@class.string_0);
			string fullPath2 = Path.GetFullPath(Path.GetTempPath());
			if (fullPath.StartsWith(fullPath2, StringComparison.OrdinalIgnoreCase) && Path.GetFileName(fullPath).StartsWith(Class185.smethod_0(-1141242827), StringComparison.Ordinal))
			{
				Directory.Delete(fullPath, recursive: true);
			}
		}
		Console.WriteLine(Class185.smethod_0(-1141242214) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	private static DataGridView smethod_267()
	{
		return new DataGridView
		{
			Name = Class185.smethod_0(-1141242226),
			AllowUserToAddRows = false,
			Columns = { 
			{
				Class185.smethod_0(-1141298782),
				Class185.smethod_0(-1141298782)
			} }
		};
	}

	internal static int smethod_268()
	{
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Invalid comparison between Unknown and I4
		//IL_0988: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected O, but got Unknown
		//IL_0a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8a: Expected O, but got Unknown
		//IL_0da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daa: Expected O, but got Unknown
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141242254) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
		Directory.CreateDirectory(text);
		try
		{
			Class336 @class = new Class336();
			num += smethod_243(Class185.smethod_0(-1141242273), Uri.TryCreate(Class131.smethod_0(), UriKind.Absolute, out var result) && result.Scheme == Uri.UriSchemeHttps && result.Host == Class185.smethod_0(-1141242308) && result.AbsolutePath.StartsWith(Class185.smethod_0(-1141242334), StringComparison.Ordinal));
			byte[] array = Convert.FromBase64String(Class185.smethod_0(-1141242347));
			Class35 class2 = new Class35(text);
			class2.method_0(Class185.smethod_0(-1141243478), 17u, 0, 60, 3, array, 1000L, 29, null);
			class2.method_3(Class185.smethod_0(-1141243478), 17u, Class185.smethod_0(-1141243494), 1500L);
			class2.method_4(Class185.smethod_0(-1141243478), 17u, 0, 3, 1600L);
			@class.class1_1 = class2.method_5(Class185.smethod_0(-1141243478), 17u);
			@class.class1_1.String_9 = Class185.smethod_0(-1141243494);
			@class.class1_1.Nullable_2 = 98.85;
			PropertyInfo property = typeof(Class1).GetProperty(Class185.smethod_0(-1141243498));
			if (property != null)
			{
				property.SetValue(@class.class1_1, Class185.smethod_0(-1141243513), null);
			}
			num += smethod_243(Class185.smethod_0(-1141243531), @class.class1_1 != null && @class.class1_1.String_7 == Class185.smethod_0(-1141243561) && @class.class1_1.String_5 == Class185.smethod_0(-1141243494) && File.Exists(Path.Combine(text, Class185.smethod_0(-1141243561), @class.class1_1.String_0, Class185.smethod_0(-1141243584))));
			num += smethod_243(Class185.smethod_0(-1141243600), class2.method_0(Class185.smethod_0(-1141243478), 17u, 0, 60, 3, array, 1700L, 29, null) && class2.method_5(Class185.smethod_0(-1141243478), 17u).String_0 == @class.class1_1.String_0);
			class2.method_0(Class185.smethod_0(-1141243656), 17u, 0, 60, 3, array, 2000L, 29, null);
			class2.method_4(Class185.smethod_0(-1141243656), 17u, 3, 0, 61000L);
			@class.class1_2 = class2.method_5(Class185.smethod_0(-1141243656), 17u);
			num += smethod_243(Class185.smethod_0(-1141243672), @class.class1_2 != null && @class.class1_2.String_7 == Class185.smethod_0(-1141243700) && @class.class1_2.String_5 == null && @class.class1_1.String_0 != @class.class1_2.String_0 && File.Exists(Path.Combine(text, Class185.smethod_0(-1141243714), @class.class1_2.String_0, Class185.smethod_0(-1141243584))));
			class2.method_0(Class185.smethod_0(-1141243729), 18u, 0, 60, 3, array, 3000L, 29, null);
			class2.method_3(Class185.smethod_0(-1141243729), 18u, Class185.smethod_0(-1141243745), 3100L);
			class2.method_4(Class185.smethod_0(-1141243729), 18u, 1, 2, 3200L);
			@class.class1_0 = class2.method_5(Class185.smethod_0(-1141243729), 18u);
			num += smethod_243(Class185.smethod_0(-1141243765), @class.class1_0 != null && @class.class1_0.String_7 == Class185.smethod_0(-1141243805) && @class.class1_0.String_5 == null && !class2.method_6().Any(@class.method_0));
			class2.method_3(Class185.smethod_0(-1141243729), 18u, Class185.smethod_0(-1141243823), 3300L);
			class2.method_4(Class185.smethod_0(-1141243729), 18u, 0, 2, 3400L);
			num += smethod_243(Class185.smethod_0(-1141243827), class2.method_5(Class185.smethod_0(-1141243729), 18u).String_5 == Class185.smethod_0(-1141243823));
			class2.method_0(Class185.smethod_0(-1141243878), 19u, 0, 60, 3, array, 4000L, 29, null);
			class2.method_4(Class185.smethod_0(-1141243878), 19u, 0, 3, 4500L);
			num += smethod_243(Class185.smethod_0(-1141243894), class2.method_5(Class185.smethod_0(-1141243878), 19u).String_7 == Class185.smethod_0(-1141242917) && !class2.method_6().Any(Class299.class299_0.method_116));
			class2.method_0(Class185.smethod_0(-1141242952), 22u, 0, 60, 3, array, 7000L, 29, null);
			class2.method_3(Class185.smethod_0(-1141242952), 22u, Class185.smethod_0(-1141242968), 7200L);
			class2.method_4(Class185.smethod_0(-1141242952), 22u, 2, 0, 7300L);
			Class1 class3 = class2.method_5(Class185.smethod_0(-1141242952), 22u);
			JObject val = JObject.Parse(Class411.smethod_0(class3));
			num += smethod_243(Class185.smethod_0(-1141242972), class3.String_7 == Class185.smethod_0(-1141243017) && class3.String_5 == null && Class411.smethod_0(class3).Contains(Class185.smethod_0(-1141243038)) && val.Property(Class185.smethod_0(-1141243057)) != null && (int)val[Class185.smethod_0(-1141243057)].Type == 10);
			num += smethod_243(Class185.smethod_0(-1141243086), new Class35(text).method_6().Count() == 4);
			string text2 = Class411.smethod_0(@class.class1_1);
			JObject val2 = JObject.Parse(text2);
			num += smethod_243(Class185.smethod_0(-1141243127), text2.Contains(Environment.NewLine) && property != null && (string)val2[Class185.smethod_0(-1141243176)] == Class185.smethod_0(-1141243513) && (string)val2[Class185.smethod_0(-1141243191)] == Class185.smethod_0(-1141243494) && Math.Abs((double)val2[Class185.smethod_0(-1141243208)] - 98.85) < 0.0001 && (string)val2[Class185.smethod_0(-1141243057)] == Class185.smethod_0(-1141243494));
			num += smethod_243(Class185.smethod_0(-1141243227), text2.Contains(Class185.smethod_0(-1141243266)) && Class411.smethod_0(@class.class1_2).Contains(Class185.smethod_0(-1141243294)) && JObject.Parse(Class411.smethod_0(@class.class1_2)).Property(Class185.smethod_0(-1141243057)) != null);
			string text3 = Path.Combine(text, Class185.smethod_0(-1141243314));
			Type[] types = new Type[5]
			{
				typeof(string),
				typeof(string),
				typeof(Action<string>),
				typeof(HttpClient),
				typeof(Func<string>)
			};
			ConstructorInfo constructor = typeof(Class363).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, types, null);
			num += smethod_243(Class185.smethod_0(-1141243342), constructor != null);
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
					class4.method_2(Class185.smethod_0(-1141243380), 24u, 0, 60, 3, array, 8300L, 29);
					class4.method_12().GetAwaiter().GetResult();
				}
				Class1 class5 = new Class35(text3).method_5(Class185.smethod_0(-1141243380), 24u);
				num += smethod_243(Class185.smethod_0(-1141240335), class5 != null && property != null && (string)property.GetValue(class5, null) == Class185.smethod_0(-1141255751));
			}
			Class250 class6 = new Class250(HttpStatusCode.OK, Class185.smethod_0(-1141240370));
			try
			{
				HttpClient val3 = new HttpClient((HttpMessageHandler)(object)class6);
				try
				{
					Class187 result2 = new Class411(val3, Class185.smethod_0(-1141240405)).method_0(@class.class1_1, class2.method_7(@class.class1_1), CancellationToken.None).GetAwaiter().GetResult();
					num += smethod_243(Class185.smethod_0(-1141240454), result2.string_0 == Class185.smethod_0(-1141240496) && class6.string_1.Contains(Class185.smethod_0(-1141240506)) && class6.string_2.Contains(Class185.smethod_0(-1141240522) + @class.class1_1.String_0 + Class185.smethod_0(-1141295916)) && class6.string_2.Contains(Class185.smethod_0(-1141243266)));
				}
				finally
				{
					((IDisposable)val3).Dispose();
				}
			}
			finally
			{
				((IDisposable)(object)class6).Dispose();
			}
			Class250 class7 = new Class250((HttpStatusCode)429, Class185.smethod_0(-1141240539));
			try
			{
				HttpClient val4 = new HttpClient((HttpMessageHandler)(object)class7);
				try
				{
					Class187 result3 = new Class411(val4, Class185.smethod_0(-1141240405)).method_0(@class.class1_2, class2.method_7(@class.class1_2), CancellationToken.None).GetAwaiter().GetResult();
					num += smethod_243(Class185.smethod_0(-1141240573), result3.string_0 == null && result3.timeSpan_0.TotalSeconds == 2.5);
				}
				finally
				{
					((IDisposable)val4).Dispose();
				}
			}
			finally
			{
				((IDisposable)(object)class7).Dispose();
			}
			num += smethod_243(Class185.smethod_0(-1141240613), class2.method_8(@class.class1_1.String_0, Class185.smethod_0(-1141240496)) && !class2.method_6().Any(@class.method_1));
			num += smethod_243(Class185.smethod_0(-1141240656), new Class35(text).method_6().Count() == 3);
			File.Delete(class2.method_7(@class.class1_2));
			num += smethod_243(Class185.smethod_0(-1141240693), !class2.method_6().Any(@class.method_2));
			num += smethod_243(Class185.smethod_0(-1141240731), !class2.method_0(Class185.smethod_0(-1141240776), 20u, 0, 60, 3, Encoding.UTF8.GetBytes(Class185.smethod_0(-1141273605)), 5000L, 29, null));
			string text4 = Path.Combine(text, Class185.smethod_0(-1141240792));
			Class363 class8 = new Class363(text4, string.Empty);
			try
			{
				Class119 class9 = new Class119();
				class9.method_1(class8);
				Class119 obj = class9;
				string text5 = Class185.smethod_0(-1141240807) + array.Length + Class185.smethod_0(-1141239911);
				byte[] bytes = Encoding.UTF8.GetBytes(text5 + Class185.smethod_0(-1141299436));
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
			num += smethod_244(Class185.smethod_0(-1141239942), 1, Directory.GetDirectories(Path.Combine(text4, Class185.smethod_0(-1141239970))).Length);
			string text6 = Path.Combine(text, Class185.smethod_0(-1141239992));
			Class250 class10 = new Class250(HttpStatusCode.OK, Class185.smethod_0(-1141240007));
			try
			{
				HttpClient val5 = new HttpClient((HttpMessageHandler)(object)class10);
				try
				{
					Class363 class11 = new Class363(text6, Class185.smethod_0(-1141240405), null, val5);
					class11.method_2(Class185.smethod_0(-1141240039), 23u, 0, 60, 3, array, 8000L, 29);
					class11.method_4(Class185.smethod_0(-1141240039), 23u, Class185.smethod_0(-1141242968), 8100L);
					class11.method_5(Class185.smethod_0(-1141240039), 23u, 0, 3, 8200L);
					bool flag = false;
					for (int i = 0; i < 100; i++)
					{
						if (flag)
						{
							break;
						}
						if (!(flag = Directory.GetDirectories(Path.Combine(text6, Class185.smethod_0(-1141240062))).Length == 1))
						{
							Thread.Sleep(20);
						}
					}
					class11.method_12().GetAwaiter().GetResult();
					num += smethod_243(Class185.smethod_0(-1141240077), flag && class10.string_2 != null && class10.string_2.Contains(Class185.smethod_0(-1141243266)));
					num += smethod_243(Class185.smethod_0(-1141240115), !new Class35(text6).method_6().Any());
				}
				finally
				{
					((IDisposable)val5).Dispose();
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
			if (fullPath.StartsWith(Path.GetFullPath(Path.GetTempPath()), StringComparison.OrdinalIgnoreCase) && Path.GetFileName(fullPath).StartsWith(Class185.smethod_0(-1141242254), StringComparison.Ordinal))
			{
				Directory.Delete(fullPath, recursive: true);
			}
		}
		Console.WriteLine(Class185.smethod_0(-1141240161) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	internal static int smethod_269()
	{
		string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Class131.smethod_8());
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141240187), Class185.smethod_0(-1141354158));
		int num = 0;
		try
		{
			Directory.CreateDirectory(text);
			string[] array = new string[3]
			{
				Class185.smethod_0(-1141240218),
				Class185.smethod_0(-1141353537),
				Class185.smethod_0(-1141240235)
			};
			foreach (string path2 in array)
			{
				string text2 = Path.Combine(path, path2);
				if (File.Exists(text2))
				{
					File.Copy(text2, Path.Combine(text, path2), overwrite: true);
					continue;
				}
				Console.Error.WriteLine(Class185.smethod_0(-1141240257) + text2);
				return 2;
			}
			string text3 = Path.Combine(text, Class185.smethod_0(-1141353537));
			string text4 = Class136.smethod_3(text3);
			Console.WriteLine(Class185.smethod_0(-1141240315) + text3);
			Console.WriteLine(Class185.smethod_0(-1141241383) + text4);
			if (!text4.All(Class299.class299_0.method_120))
			{
				Console.WriteLine(Class185.smethod_0(-1141241410));
				num++;
			}
			if (string.Compare(text4, text3, StringComparison.OrdinalIgnoreCase) == 0)
			{
				Console.WriteLine(Class185.smethod_0(-1141241490));
				num++;
			}
			using Class136 @class = new Class136(text, Class299.class299_0.method_121);
			Class50 class2 = @class.imethod_0(smethod_273(Class185.smethod_0(-1141242968)));
			Console.WriteLine(Class185.smethod_0(-1141241574) + class2.method_0() + Class185.smethod_0(-1141241605) + (class2.method_8() ?? Class185.smethod_0(-1141350722)) + ((class2.method_6() == null) ? string.Empty : (Class185.smethod_0(-1141241623) + class2.method_6())));
			if (class2.method_6() != null)
			{
				num++;
			}
			if (class2.method_8() != Class185.smethod_0(-1141242968))
			{
				num++;
			}
		}
		finally
		{
			string path3 = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141240187));
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
		Console.WriteLine(Class185.smethod_0(-1141241637) + ((num == 0) ? Class185.smethod_0(-1141241663) : (num + Class185.smethod_0(-1141356690))));
		return num;
	}

	internal static int smethod_270()
	{
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string text = Path.Combine(baseDirectory, Class185.smethod_0(-1141308296), Class131.smethod_3());
		if (!File.Exists(text))
		{
			Console.Error.WriteLine(Class185.smethod_0(-1141241666) + text);
			return 2;
		}
		string string_ = Path.Combine(baseDirectory, Class131.smethod_8());
		using Class28 @class = new Class28(text, string_, Class299.class299_0.method_122);
		Class50 class2 = @class.imethod_0(smethod_273(Class185.smethod_0(-1141242968)));
		Console.WriteLine(Class185.smethod_0(-1141241706) + class2.method_0() + Class185.smethod_0(-1141241605) + (class2.method_8() ?? Class185.smethod_0(-1141350722)) + Class185.smethod_0(-1141241731) + class2.method_2().ToString(Class185.smethod_0(-1141241758)) + Class185.smethod_0(-1141241763) + class2.method_4() + Class185.smethod_0(-1141241779) + ((class2.method_6() == null) ? string.Empty : (Class185.smethod_0(-1141241623) + class2.method_6())));
		int num = 0;
		if (class2.method_6() != null)
		{
			num++;
		}
		if (class2.method_8() != Class185.smethod_0(-1141242968))
		{
			num++;
		}
		Console.WriteLine(Class185.smethod_0(-1141241788) + ((num == 0) ? Class185.smethod_0(-1141241663) : (num + Class185.smethod_0(-1141356690))));
		return num;
	}

	internal static int smethod_271(string string_0)
	{
		int num = smethod_272();
		if (string_0 == null)
		{
			Console.WriteLine(Class185.smethod_0(-1141241816) + ((num == 0) ? Class185.smethod_0(-1141241838) : (num + Class185.smethod_0(-1141356690))));
			return num;
		}
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string text = Path.Combine(baseDirectory, Class185.smethod_0(-1141308296), Class131.smethod_3());
		if (!File.Exists(text))
		{
			Console.Error.WriteLine(Class185.smethod_0(-1141240839) + text);
			return 2;
		}
		List<string> list = new List<string>();
		if (Directory.Exists(string_0))
		{
			list.AddRange(Directory.GetFiles(string_0, Class185.smethod_0(-1141240873)).OrderBy(Class299.class299_0.method_123).Take(12));
		}
		else if (File.Exists(string_0))
		{
			list.Add(string_0);
		}
		if (list.Count == 0)
		{
			Console.Error.WriteLine(Class185.smethod_0(-1141240893) + string_0);
			return 2;
		}
		using (Class28 @class = new Class28(text, Path.Combine(baseDirectory, Class131.smethod_8()), Class299.class299_0.method_124))
		{
			foreach (string item in list)
			{
				Class50 class2 = @class.imethod_0(File.ReadAllBytes(item));
				Console.WriteLine(Class185.smethod_0(-1141241816) + Path.GetFileName(item) + Class185.smethod_0(-1141241605) + (class2.method_8() ?? Class185.smethod_0(-1141350722)) + Class185.smethod_0(-1141241731) + class2.method_2().ToString(Class185.smethod_0(-1141274464)) + Class185.smethod_0(-1141240933) + class2.method_4() + Class185.smethod_0(-1141241779) + ((class2.method_6() == null) ? string.Empty : (Class185.smethod_0(-1141241623) + class2.method_6())));
				if (class2.method_6() != null)
				{
					num++;
				}
				if (class2.method_2() < 0.0 || class2.method_2() > 100.0)
				{
					Console.WriteLine(Class185.smethod_0(-1141240950) + class2.method_2().ToString(Class185.smethod_0(-1141241758)));
					num++;
				}
			}
		}
		Console.WriteLine(Class185.smethod_0(-1141241816) + ((num == 0) ? Class185.smethod_0(-1141241663) : (num + Class185.smethod_0(-1141356690))));
		return num;
	}

	private static int smethod_272()
	{
		List<Class286> obj = new List<Class286>
		{
			new Class286
			{
				string_0 = Class185.smethod_0(-1141240996),
				string_1 = Class185.smethod_0(-1141242968),
				double_0 = 95.0,
				string_2 = Class185.smethod_0(-1141241037),
				double_1 = 60.0,
				bool_1 = true,
				string_3 = Class185.smethod_0(-1141242968),
				string_4 = Class185.smethod_0(-1141241041),
				string_5 = Class185.smethod_0(-1141241062)
			},
			new Class286
			{
				string_0 = Class185.smethod_0(-1141241080),
				string_1 = Class185.smethod_0(-1141241108),
				double_0 = 96.0,
				string_2 = Class185.smethod_0(-1141241128),
				double_1 = 99.0,
				bool_1 = true,
				string_3 = Class185.smethod_0(-1141241128),
				string_4 = Class185.smethod_0(-1141241132),
				string_5 = Class185.smethod_0(-1141241159)
			},
			new Class286
			{
				string_0 = Class185.smethod_0(-1141241177),
				string_1 = Class185.smethod_0(-1141241216),
				double_0 = 80.0,
				string_2 = Class185.smethod_0(-1141241220),
				double_1 = 12.0,
				bool_1 = true,
				string_3 = Class185.smethod_0(-1141241220),
				string_4 = Class185.smethod_0(-1141241132),
				string_5 = Class185.smethod_0(-1141241240)
			},
			new Class286
			{
				string_0 = Class185.smethod_0(-1141241262),
				string_1 = Class185.smethod_0(-1141241216),
				double_0 = 80.0,
				string_2 = Class185.smethod_0(-1141241216),
				double_1 = 12.0,
				bool_1 = true,
				string_3 = Class185.smethod_0(-1141241216),
				string_4 = Class185.smethod_0(-1141241132),
				string_5 = Class185.smethod_0(-1141241240)
			},
			new Class286
			{
				string_0 = Class185.smethod_0(-1141241282),
				string_1 = null,
				double_0 = 0.0,
				bool_0 = true,
				string_2 = Class185.smethod_0(-1141241313),
				double_1 = 12.0,
				bool_1 = true,
				string_3 = Class185.smethod_0(-1141241313),
				string_4 = Class185.smethod_0(-1141241132),
				string_5 = Class185.smethod_0(-1141241333)
			},
			new Class286
			{
				string_0 = Class185.smethod_0(-1141213704),
				string_1 = Class185.smethod_0(-1141241216),
				double_0 = 80.0,
				string_2 = Class185.smethod_0(-1141241216),
				double_1 = 99.0,
				bool_1 = false,
				string_3 = null,
				string_4 = null,
				string_5 = Class185.smethod_0(-1141213721)
			},
			new Class286
			{
				string_0 = Class185.smethod_0(-1141213738),
				string_1 = null,
				double_0 = 95.0,
				string_2 = Class185.smethod_0(-1141213778),
				double_1 = 12.0,
				bool_1 = true,
				string_3 = Class185.smethod_0(-1141213778),
				string_4 = Class185.smethod_0(-1141241132),
				string_5 = Class185.smethod_0(-1141241240)
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
			Console.WriteLine(Class185.smethod_0(-1141241816) + item.string_0 + Class185.smethod_0(-1141213798) + (text ?? Class185.smethod_0(-1141350722)) + Class185.smethod_0(-1141213816) + (string_ ?? Class185.smethod_0(-1141293701)) + Class185.smethod_0(-1141213831) + string_2 + Class185.smethod_0(-1141213846) + double_.ToString(Class185.smethod_0(-1141274464)) + (flag ? string.Empty : (Class185.smethod_0(-1141213851) + (item.string_3 ?? Class185.smethod_0(-1141350722)) + Class185.smethod_0(-1141300031) + (item.string_4 ?? Class185.smethod_0(-1141293701)) + Class185.smethod_0(-1141300031) + item.string_5)));
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
				Font font = new Font(Class185.smethod_0(-1141213878), 48f, FontStyle.Bold);
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
			Console.Error.WriteLine(Class185.smethod_0(-1141213882) + string_0);
			return 2;
		}
		using Class136 @class = new Class136(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Class131.smethod_8()), Class299.class299_0.method_125);
		Class50 class2 = @class.imethod_0(File.ReadAllBytes(string_0));
		Console.WriteLine(Class185.smethod_0(-1141213915) + class2.method_0() + Class185.smethod_0(-1141241731) + class2.method_2().ToString(Class185.smethod_0(-1141241758)) + Class185.smethod_0(-1141241763) + class2.method_4() + Class185.smethod_0(-1141241779) + ((class2.method_6() == null) ? string.Empty : (Class185.smethod_0(-1141241623) + class2.method_6())) + Class185.smethod_0(-1141241605) + (class2.method_8() ?? Class185.smethod_0(-1141350722)));
		return (class2.method_6() != null) ? 1 : 0;
	}

	internal static int smethod_275()
	{
		Class215 @class = new Class215();
		int num = 0;
		num = 0 + smethod_243(Class185.smethod_0(-1141213937), Math.Abs(Class136.smethod_0(0.9885377288) - 98.85377288) < 1E-06);
		long num2 = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
		byte[] byte_ = Convert.FromBase64String(Class185.smethod_0(-1141242347));
		Action<Class270, Class218, double> action = Class299.class299_0.method_126;
		Action action2 = Class299.class299_0.method_128;
		Class270 class2 = new Class270();
		Class218 arg = new Class218
		{
			string_0 = Class185.smethod_0(-1141213987),
			double_0 = 98.4
		};
		action(class2, arg, 90.0);
		class2.method_1(101u, num2, 60);
		class2.class351_0.method_0(Class185.smethod_0(-1141253640), 101u, 60, num2, byte_);
		action2();
		num += smethod_243(Class185.smethod_0(-1141214007), class2.list_0.Count == 1);
		num += smethod_243(Class185.smethod_0(-1141214044), class2.list_1.Count == 1 && class2.list_1[0] == Class185.smethod_0(-1141214092));
		class2.dictionary_0[Class185.smethod_0(-1141214108)].String_7 = Class185.smethod_0(-1141214128);
		class2.class351_0.method_0(Class185.smethod_0(-1141253640), 101u, 60, num2, byte_);
		action2();
		num += smethod_243(Class185.smethod_0(-1141214144), class2.list_0.Count == 1);
		class2.class351_0.Dispose();
		Class270 class3 = new Class270();
		action(class3, new Class218
		{
			string_0 = Class185.smethod_0(-1141214191),
			double_0 = 82.07
		}, 90.0);
		class3.method_1(102u, num2, 60);
		class3.class351_0.method_0(Class185.smethod_0(-1141253640), 102u, 60, num2, byte_);
		action2();
		num += smethod_243(Class185.smethod_0(-1141214194), class3.list_0.Count == 0);
		num += smethod_243(Class185.smethod_0(-1141213212), class3.list_1.Count == 1 && class3.list_1[0] == Class185.smethod_0(-1141213268));
		class3.class351_0.Dispose();
		Class270 class4 = new Class270();
		action(class4, new Class218
		{
			string_0 = Class185.smethod_0(-1141213283),
			double_0 = 99.0
		}, 90.0);
		class4.method_1(103u, num2, 60);
		class4.class351_0.method_0(Class185.smethod_0(-1141253640), 103u, 60, num2, byte_);
		action2();
		num += smethod_243(Class185.smethod_0(-1141213309), class4.list_0.Count == 0);
		num += smethod_243(Class185.smethod_0(-1141213338), class4.list_1.Count == 1 && class4.list_1[0] == Class185.smethod_0(-1141213386));
		class4.class351_0.Dispose();
		Class270 class5 = new Class270();
		action(class5, new Class218
		{
			string_0 = Class185.smethod_0(-1141213987),
			double_0 = 98.4
		}, 90.0);
		class5.method_1(104u, num2, 60);
		class5.dictionary_0[Class185.smethod_0(-1141213401)].String_7 = Class185.smethod_0(-1141214128);
		class5.method_1(105u, num2, 60);
		class5.dictionary_0[Class185.smethod_0(-1141213421)].String_7 = Class185.smethod_0(-1141243700);
		class5.class351_0.method_0(Class185.smethod_0(-1141253640), 104u, 60, num2, byte_);
		class5.class351_0.method_0(Class185.smethod_0(-1141253640), 105u, 60, num2, byte_);
		action2();
		num += smethod_243(Class185.smethod_0(-1141213425), class5.list_0.Count == 0);
		class5.class351_0.Dispose();
		Class270 class6 = new Class270();
		action(class6, new Class218
		{
			string_0 = Class185.smethod_0(-1141213987),
			double_0 = 98.4
		}, 90.0);
		class6.method_1(106u, num2 - 59500L, 60);
		class6.class351_0.method_0(Class185.smethod_0(-1141253640), 106u, 60, num2 - 59500L, byte_);
		action2();
		num += smethod_243(Class185.smethod_0(-1141213472), class6.list_0.Count == 0);
		num += smethod_243(Class185.smethod_0(-1141213498), class6.list_1.Count == 1);
		class6.class351_0.Dispose();
		@class.class270_0 = new Class270();
		action(@class.class270_0, new Class218
		{
			string_0 = Class185.smethod_0(-1141213987),
			double_0 = 98.4
		}, 90.0);
		@class.class270_0.method_1(107u, num2, 60);
		@class.class270_0.class351_0 = new Class351(new Class218
		{
			string_0 = Class185.smethod_0(-1141213987),
			double_0 = 98.4
		}, @class.class270_0.method_0, @class.method_0, Class299.class299_0.method_129, new Class114
		{
			bool_0 = true,
			double_0 = 90.0,
			double_1 = 0.0,
			double_2 = 0.3,
			double_3 = 0.3
		}, Class299.class299_0.method_130);
		@class.class270_0.class351_0.method_0(Class185.smethod_0(-1141253640), 107u, 60, num2, byte_);
		Thread.Sleep(60);
		@class.class270_0.dictionary_0[Class185.smethod_0(-1141213546)].String_7 = Class185.smethod_0(-1141214128);
		Thread.Sleep(700);
		num += smethod_243(Class185.smethod_0(-1141213566), @class.class270_0.list_0.Count == 0);
		@class.class270_0.class351_0.Dispose();
		Class270 class7 = new Class270();
		action(class7, new Class218
		{
			string_0 = Class185.smethod_0(-1141213987),
			double_0 = 98.4
		}, 150.0);
		class7.method_1(108u, num2, 60);
		class7.class351_0.method_0(Class185.smethod_0(-1141253640), 108u, 60, num2, byte_);
		Thread.Sleep(150);
		num += smethod_243(Class185.smethod_0(-1141213604), class7.list_0.Count == 0 && class7.list_1.Count == 0);
		class7.class351_0.Dispose();
		num += smethod_244(Class185.smethod_0(-1141213649), 98.85, Math.Round(Class136.smethod_0(0.9885), 4));
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141214727) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
		try
		{
			Class35 class8 = new Class35(text);
			byte[] byte_2 = Convert.FromBase64String(Class185.smethod_0(-1141242347));
			class8.method_0(Class185.smethod_0(-1141214746), 7u, 0, 60, 3, byte_2, 1L, 29, null);
			class8.method_4(Class185.smethod_0(-1141214746), 7u, 0, 3, 100L);
			num += smethod_243(Class185.smethod_0(-1141214765), class8.method_5(Class185.smethod_0(-1141214746), 7u).String_7 == Class185.smethod_0(-1141242917));
			class8.method_3(Class185.smethod_0(-1141214746), 7u, Class185.smethod_0(-1141213987), 90L);
			Class1 class9 = class8.method_5(Class185.smethod_0(-1141214746), 7u);
			num += smethod_243(Class185.smethod_0(-1141214802), class9.String_7 == Class185.smethod_0(-1141243561) && class9.String_5 == Class185.smethod_0(-1141213987));
			class8.method_3(Class185.smethod_0(-1141214746), 7u, Class185.smethod_0(-1141213987), 95L);
			num += smethod_243(Class185.smethod_0(-1141214856), class8.method_5(Class185.smethod_0(-1141214746), 7u).String_7 == Class185.smethod_0(-1141243561));
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
		Console.WriteLine(Class185.smethod_0(-1141214905) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	public static int smethod_276()
	{
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		int num = 0;
		num = 0 + smethod_277();
		num += smethod_244(Class185.smethod_0(-1141214936), Class185.smethod_0(-1141214961), Class344.smethod_0((Enum13)0, 41u));
		num += smethod_244(Class185.smethod_0(-1141215010), Class185.smethod_0(-1141215053), Class344.smethod_0((Enum13)1, 42u));
		num += smethod_244(Class185.smethod_0(-1141215104), Class185.smethod_0(-1141215135), Class344.smethod_0((Enum13)2, 43u));
		bool bool_ = false;
		try
		{
			Class344.smethod_0((Enum13)99, 44u);
		}
		catch (ArgumentOutOfRangeException)
		{
			bool_ = true;
		}
		num += smethod_243(Class185.smethod_0(-1141215182), bool_);
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
			num += smethod_243(Class185.smethod_0(-1141215219), num2 != 0 && num3 != 0 && num4 != 0 && num2 != num3 && num2 != num4 && num3 != num4);
			num += smethod_243(Class185.smethod_0(-1141214244), !@class.method_137() && !@class.method_138() && class2.list_0.Count == 0 && @class.method_23() != null && @class.method_23().uint_0 == num4 && @class.method_23().string_0 == Class185.smethod_0(-1141214304) && @class.method_23().string_1 == Class185.smethod_0(-1141214307) && class2.list_1.Count == 3 && class2.list_1.All(Class299.class299_0.method_131));
			@class.method_154(77u, Class185.smethod_0(-1141214304), bool_17: true, false, bool_18: false, null);
			Class93 class3 = @class.method_23();
			num += smethod_243(Class185.smethod_0(-1141214341), class3 != null && class3.uint_0 == 77 && class3.string_0 == Class185.smethod_0(-1141214304) && class3.bool_0 && class3.nullable_0 == false && !class3.bool_1 && class3.string_1 == string.Empty);
			long num5 = @class.method_24();
			@class.method_210();
			num += smethod_243(Class185.smethod_0(-1141214370), @class.method_23() == null && @class.method_24() == num5);
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		FieldInfo field = typeof(Class357).GetField(Class185.smethod_0(-1141214422), BindingFlags.Static | BindingFlags.NonPublic);
		num += smethod_243(Class185.smethod_0(-1141214462), field != null);
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
					smethod_94(class4, Class185.smethod_0(-1141214505), true);
					uint uint_ = class4.method_147();
					uint uint_2 = class4.method_148();
					uint uint_3 = class4.method_149();
					num += smethod_243(Class185.smethod_0(-1141214533), class5.list_0.SequenceEqual(new string[3]
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
		Class93 class6 = Class119.smethod_5(JObject.Parse(Class185.smethod_0(-1141214583)), 9L);
		num += smethod_243(Class185.smethod_0(-1141214704), class6.long_0 == 9L && class6.uint_0 == 88 && class6.string_0 == Class185.smethod_0(-1141211659) && !class6.bool_0 && !class6.nullable_0.HasValue && !class6.bool_1 && class6.string_1 == Class185.smethod_0(-1141211674));
		Class446 class7 = Class119.smethod_22(JObject.Parse(Class185.smethod_0(-1141211704)));
		num += smethod_243(Class185.smethod_0(-1141211788), class7.method_0() == true && class7.method_2() == 3 && class7.method_4() == 25 && class7.method_6() == false && class7.method_9() == 19);
		num += smethod_243(Class185.smethod_0(-1141211833), class7.method_8() == true);
		Class446 class8 = Class119.smethod_22(JObject.Parse(Class185.smethod_0(-1141211876)));
		num += smethod_243(Class185.smethod_0(-1141211974), class8.method_0() == false && class8.method_6() == true && class8.method_8() == false);
		Class446 class9 = Class119.smethod_22(new JObject());
		num += smethod_243(Class185.smethod_0(-1141212010), !class9.method_0().HasValue && !class9.method_4().HasValue && class9.method_2() == 0 && !class9.method_6().HasValue && !class9.method_8().HasValue && !class9.method_9().HasValue);
		Class446 class10 = Class119.smethod_22(JObject.Parse(Class185.smethod_0(-1141212058)));
		num += smethod_243(Class185.smethod_0(-1141212147), !class10.method_0().HasValue && class10.method_2() == 0 && class10.method_4() == 7 && !class10.method_6().HasValue && !class10.method_8().HasValue && class10.method_9() == 5);
		Class446 class11 = Class119.smethod_22(JObject.Parse(Class185.smethod_0(-1141211198)));
		num += smethod_243(Class185.smethod_0(-1141211284), class11.method_0() == true && class11.method_2() == 1 && class11.method_4() == 250 && class11.method_6() == false && class11.method_8() == true && class11.method_9() == 250);
		Class446 class12 = Class119.smethod_22(JObject.Parse(Class185.smethod_0(-1141211357)));
		num += smethod_243(Class185.smethod_0(-1141211441), !class12.method_0().HasValue && class12.method_2() == 0 && !class12.method_4().HasValue && !class12.method_6().HasValue && !class12.method_9().HasValue);
		Class145 class13 = Class145.class145_0.method_96(null, Class95.class95_0, null, default(GStruct4), class7, 7, 1, null, null, null, null, default(Struct26)).method_93(new Class83
		{
			float_0 = 1f
		}, 8, 0);
		Class145 class14 = class13.method_96(null, Class95.class95_0, null, default(GStruct4), class8, 9, 0, null, null, null, null, default(Struct26));
		num += smethod_243(Class185.smethod_0(-1141211502), class13.method_28() == true && class13.method_34() == false && class13.method_32() == 25);
		Class145 class15 = class13.method_97(null, null, Class95.class95_0, 1, 0);
		num += smethod_243(Class185.smethod_0(-1141211539), class15.method_28() == true && class15.method_34() == false && class15.method_37() == 19);
		num += smethod_243(Class185.smethod_0(-1141211607), class14.method_28() == false && class14.method_34() == true && class14.method_89() == 9);
		Class145 class16 = class14.method_96(null, Class95.class95_0, null, default(GStruct4), class10, 10, 0, null, null, null, null, default(Struct26));
		num += smethod_243(Class185.smethod_0(-1141212677), !class16.method_28().HasValue && class16.method_32() == 7 && !class16.method_34().HasValue && !class16.method_36().HasValue && class16.method_37() == 5);
		Class145 class17 = class14.method_95(null, Class95.class95_0, null, default(GStruct4), 11, 0);
		num += smethod_243(Class185.smethod_0(-1141212734), !class17.method_28().HasValue && !class17.method_34().HasValue);
		num += smethod_244(Class185.smethod_0(-1141212789), 80, 80);
		num += smethod_244(Class185.smethod_0(-1141212820), 32, 32);
		num += smethod_244(Class185.smethod_0(-1141212869), Class185.smethod_0(-1141212890), Class54.smethod_2(Class54.smethod_3(Class185.smethod_0(-1141212922))));
		Class327 class18 = new Class327(new IntPtr(141));
		Class119 class19 = new Class119();
		try
		{
			class19.method_34(class18);
			class19.method_35(Class299.class299_0.method_132);
			class19.method_46(5046u);
			string text = class19.method_78(27043);
			int int_ = class18.int_2;
			class18.method_1(Class185.smethod_0(-1141212939));
			num += smethod_243(Class185.smethod_0(-1141213101), text == null && class18.int_2 == int_ + 1 && class19.method_51().method_89() == 12 && class19.method_51().method_28() == true && class19.method_51().method_36() == true);
		}
		finally
		{
			((IDisposable)class19).Dispose();
		}
		string text2 = smethod_173(Class185.smethod_0(-1141354742), ref num);
		string text3 = Class119.smethod_61();
		if (text2 != null)
		{
			string[] array = new string[15]
			{
				Class185.smethod_0(-1141213151),
				Class185.smethod_0(-1141212166),
				Class185.smethod_0(-1141212185),
				Class185.smethod_0(-1141212222),
				Class185.smethod_0(-1141212248),
				Class185.smethod_0(-1141212265),
				Class185.smethod_0(-1141212289),
				Class185.smethod_0(-1141212314),
				Class185.smethod_0(-1141212349),
				Class185.smethod_0(-1141212374),
				Class185.smethod_0(-1141212386),
				Class185.smethod_0(-1141212414),
				Class185.smethod_0(-1141212428),
				Class185.smethod_0(-1141212451),
				Class185.smethod_0(-1141212480)
			};
			for (int i = 0; i < array.Length; i++)
			{
				num += smethod_243(Class185.smethod_0(-1141212490) + i, text2.Contains(array[i]));
			}
			num += smethod_243(Class185.smethod_0(-1141212530), text2.Contains(Class185.smethod_0(-1141212578)) && !text2.Contains(Class185.smethod_0(-1141212632)));
			num += smethod_243(Class185.smethod_0(-1141217806), !text2.Contains(Class185.smethod_0(-1141217844)) && !text2.Contains(Class185.smethod_0(-1141217879)));
			num += smethod_244(Class185.smethod_0(-1141217891), 1, smethod_160(text2, Class185.smethod_0(-1141217960)));
			num += smethod_244(Class185.smethod_0(-1141217993), 1, smethod_160(text2, Class185.smethod_0(-1141218052)));
			int num6 = text2.IndexOf(Class185.smethod_0(-1141218118), StringComparison.Ordinal);
			int num7 = text2.IndexOf(Class185.smethod_0(-1141218145), StringComparison.Ordinal);
			int num8 = text2.IndexOf(Class185.smethod_0(-1141218052), StringComparison.Ordinal);
			num += smethod_243(Class185.smethod_0(-1141218175), num6 >= 0 && num7 > num6 && num8 > num7);
			num += smethod_243(Class185.smethod_0(-1141218230), text2.Contains(Class185.smethod_0(-1141218286)) && text2.Contains(Class185.smethod_0(-1141217299)));
			num += smethod_243(Class185.smethod_0(-1141217359), smethod_160(text2, Class185.smethod_0(-1141217409)) == 3 && smethod_160(text2, Class185.smethod_0(-1141217469)) == 3);
			num += smethod_243(Class185.smethod_0(-1141217507), text2.Contains(Class185.smethod_0(-1141217564)) && text2.Contains(Class185.smethod_0(-1141217614)) && text2.Contains(Class185.smethod_0(-1141217635)) && text2.Contains(Class185.smethod_0(-1141217703)));
		}
		num += smethod_243(Class185.smethod_0(-1141217763), text3 != null && text3.Contains(Class185.smethod_0(-1141276097)) && text3.Contains(Class185.smethod_0(-1141273536)) && text3.Contains(Class185.smethod_0(-1141272584)) && text3.Contains(Class185.smethod_0(-1141218840)) && text3.Contains(Class185.smethod_0(-1141211674)));
		Console.WriteLine(Class185.smethod_0(-1141218863) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	private static int smethod_277()
	{
		string text = smethod_171(Class185.smethod_0(-1141218887));
		if (text == null)
		{
			return smethod_243(Class185.smethod_0(-1141218928), bool_0: false);
		}
		try
		{
			using Process process = Process.Start(new ProcessStartInfo
			{
				FileName = Class185.smethod_0(-1141218969),
				Arguments = Class185.smethod_0(-1141304355) + text + Class185.smethod_0(-1141304355),
				WorkingDirectory = Path.GetDirectoryName(text),
				UseShellExecute = false,
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true
			});
			if (process == null)
			{
				return smethod_243(Class185.smethod_0(-1141218980), bool_0: false);
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
				Console.WriteLine(Class185.smethod_0(-1141219018));
				return 1;
			}
			Task.WaitAll(new Task[2] { task, task2 }, 2000);
			string text2 = (task.IsCompleted ? task.Result : string.Empty);
			string text3 = (task2.IsCompleted ? task2.Result : string.Empty);
			if (process.ExitCode == 0 && text2.Contains(Class185.smethod_0(-1141219056)))
			{
				return 0;
			}
			Console.WriteLine(text2 + text3);
			return smethod_243(Class185.smethod_0(-1141219085), bool_0: false);
		}
		catch (Exception ex)
		{
			Console.WriteLine(Class185.smethod_0(-1141219126) + ex.GetType().Name + Class185.smethod_0(-1141301932) + ex.Message);
			return smethod_243(Class185.smethod_0(-1141219139), bool_0: false);
		}
	}

	public static int smethod_278()
	{
		Struct26 struct26_ = Class119.smethod_23(JObject.Parse(Class185.smethod_0(-1141219190)));
		int num = smethod_243(Class185.smethod_0(-1141219285), struct26_.bool_0 && struct26_.nullable_0 == 37 && struct26_.nullable_1 == 8 && struct26_.nullable_2 == 1234 && struct26_.nullable_3 == true);
		Struct26 struct26_2 = Class119.smethod_23(JObject.Parse(Class185.smethod_0(-1141219307)));
		int num2 = num + smethod_243(Class185.smethod_0(-1141218392), !struct26_2.bool_0 && !struct26_2.nullable_0.HasValue && !struct26_2.nullable_1.HasValue && !struct26_2.nullable_2.HasValue && !struct26_2.nullable_3.HasValue);
		Struct26 @struct = Class119.smethod_23(JObject.Parse(Class185.smethod_0(-1141218423)));
		int num3 = num2 + smethod_243(Class185.smethod_0(-1141218515), !@struct.bool_0 && !@struct.nullable_0.HasValue && !@struct.nullable_1.HasValue && !@struct.nullable_2.HasValue && !@struct.nullable_3.HasValue);
		Class145 @class = Class145.class145_0.method_96(null, Class95.class95_0, null, default(GStruct4), Class446.class446_0, 10, 0, null, null, null, null, struct26_).method_93(new Class83
		{
			float_0 = 1f
		}, 11, 0);
		Class145 class2 = @class.method_97(null, null, Class95.class95_0, 12, 24);
		int num4 = num3 + smethod_243(Class185.smethod_0(-1141218548), @class.method_24().nullable_0 == 37 && class2.method_24().nullable_1 == 8);
		Class145 class3 = class2.method_96(null, Class95.class95_0, null, default(GStruct4), Class446.class446_0, 13, 0, null, null, null, null, struct26_2);
		int num5 = num4 + smethod_243(Class185.smethod_0(-1141218596), !class3.method_24().bool_0 && !class3.method_24().nullable_0.HasValue);
		IReadOnlyList<Struct27> readOnlyList = Class119.smethod_40(JObject.Parse(Class185.smethod_0(-1141218638)));
		return num5 + smethod_243(Class185.smethod_0(-1141218804), readOnlyList.Count == 3 && readOnlyList[0].nullable_0 == 51 && readOnlyList[1].nullable_0 == 52 && !readOnlyList[2].nullable_0.HasValue);
	}

	public static int smethod_279()
	{
		int num = 0;
		num = 0 + smethod_244(Class185.smethod_0(-1141215766), Class185.smethod_0(-1141215786), Class7.smethod_0(7u, 3, 10, 2, 8, 142, 204));
		num += smethod_244(Class185.smethod_0(-1141215919), Class185.smethod_0(-1141215949), Class7.smethod_1(8u, 8, 142, 204));
		num += smethod_244(Class185.smethod_0(-1141216037), Class185.smethod_0(-1141216060), Class7.smethod_2(9u));
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
			num += smethod_243(Class185.smethod_0(-1141216107), text == null && num2 != 0 && class2.method_27() && class3.list_0.Count == 1 && (uint)class3.list_0[0][Class185.smethod_0(-1141255964)] == num2);
			num += smethod_244(Class185.smethod_0(-1141216140), 0u, class2.method_156(3, 10, 2, 8, 142, 204));
			num += smethod_244(Class185.smethod_0(-1141216179), 1, class3.list_0.Count);
			@class.method_1(Class185.smethod_0(-1141216212) + num2 + Class185.smethod_0(-1141215271));
			num += smethod_243(Class185.smethod_0(-1141215306), class2.method_27() && class2.method_25() == null);
			@class.method_1(Class185.smethod_0(-1141215350) + (num2 + 1) + Class185.smethod_0(-1141215418));
			num += smethod_243(Class185.smethod_0(-1141215456), class2.method_27() && class2.method_25() == null);
			@class.method_1(Class185.smethod_0(-1141215350) + num2 + Class185.smethod_0(-1141215497));
			Class194 class4 = class2.method_25();
			int num3 = num;
			string string_ = Class185.smethod_0(-1141215555);
			int bool_;
			if (!class2.method_27() && class4 != null && class4.uint_0 == num2 && class4.string_0 == Class185.smethod_0(-1141215602) && class4.bool_0 && class4.bool_1)
			{
				int? num4 = class4.nullable_0;
				if ((num4.GetValueOrDefault() == 0) & num4.HasValue)
				{
					uint? nullable_ = class4.nullable_3;
					uint num5 = 149u;
					if (nullable_ == 149)
					{
						bool_ = ((class4.nullable_4 == 8) ? 1 : 0);
						goto IL_0383;
					}
				}
			}
			bool_ = 0;
			goto IL_0383;
			IL_0383:
			num = num3 + smethod_243(string_, (byte)bool_ != 0);
			uint num6 = class2.method_156(3, 10, 2, 8, 142, 204);
			num += smethod_243(Class185.smethod_0(-1141215623), num6 != 0 && class2.method_27() && class3.list_0.Count == 2);
			@class.method_1(Class185.smethod_0(-1141215669) + num6 + Class185.smethod_0(-1141215742));
			Class194 class5 = class2.method_25();
			num += smethod_243(Class185.smethod_0(-1141216801), !class2.method_27() && class5 != null && class5.uint_0 == num6 && !class5.bool_0 && !class5.bool_1 && class5.string_1 == Class185.smethod_0(-1141216842));
			uint num7 = class2.method_156(3, 10, 2, 8, 142, 204);
			@class.method_1(Class185.smethod_0(-1141216869) + num7 + Class185.smethod_0(-1141216943));
			Class194 class6 = class2.method_25();
			num += smethod_243(Class185.smethod_0(-1141217001), num7 != 0 && !class2.method_27() && class6 != null && class6.bool_1 && class6.bool_0 && class6.nullable_1 == 1000 && class6.nullable_2 == 3);
			uint num8 = class2.method_158();
			num += smethod_243(Class185.smethod_0(-1141217044), num8 != 0 && class2.method_27() && class3.list_0.Count == 4);
			@class.method_1(Class185.smethod_0(-1141217086) + num8 + Class185.smethod_0(-1141217155));
			num += smethod_243(Class185.smethod_0(-1141217223), !class2.method_27() && class2.method_25() != null && class2.method_25().string_0 == Class185.smethod_0(-1141217256) && class2.method_25().bool_1 && class2.method_25().nullable_4 == ushort.MaxValue);
			class2.method_30(Class299.class299_0.method_134);
			uint num9 = class2.method_158();
			num += smethod_243(Class185.smethod_0(-1141217270), num9 == 0 && !class2.method_27() && class2.method_25() != null && class2.method_25().string_1 == Class185.smethod_0(-1141255782));
			class2.method_210();
			return num + smethod_243(Class185.smethod_0(-1141216284), !class2.method_27() && class2.method_25() == null);
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
			{
				Class185.smethod_0(-1141216329),
				Class185.smethod_0(-1141216351)
			},
			{
				Class185.smethod_0(-1141216368),
				Class185.smethod_0(-1141216371)
			}
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
		num = 0 + smethod_243(Class185.smethod_0(-1141216405), GClass7.smethod_1(class145_, Class185.smethod_0(-1141216439), out var struct27_) && struct27_.int_0 == 8);
		num += smethod_243(Class185.smethod_0(-1141216450), GClass7.smethod_2(class145_, out var struct27_2) && struct27_2.int_0 == 4);
		num += smethod_243(Class185.smethod_0(-1141216475), !GClass7.smethod_1(class145_, Class185.smethod_0(-1141216512), out struct27_));
		num += smethod_243(Class185.smethod_0(-1141216528), GClass7.smethod_3(new Struct26
		{
			bool_0 = true,
			nullable_1 = 8,
			nullable_2 = 149u,
			nullable_3 = true
		}) == true);
		num += smethod_243(Class185.smethod_0(-1141216552), GClass7.smethod_3(new Struct26
		{
			bool_0 = true,
			nullable_1 = ushort.MaxValue,
			nullable_2 = 0u,
			nullable_3 = false
		}) == false);
		num += smethod_243(Class185.smethod_0(-1141216572), !GClass7.smethod_3(new Struct26
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
		num += smethod_243(Class185.smethod_0(-1141216615), GClass7.smethod_5(struct26_, bool_0: false) && !GClass7.smethod_5(struct26_, bool_0: true));
		struct26_.nullable_0 = 766;
		num += smethod_243(Class185.smethod_0(-1141216655), !GClass7.smethod_5(struct26_, bool_0: false));
		struct26_.nullable_0 = 0;
		struct26_.nullable_1 = 8;
		struct26_.nullable_2 = 149u;
		struct26_.nullable_3 = true;
		num += smethod_243(Class185.smethod_0(-1141216692), !GClass7.smethod_5(struct26_, bool_0: false));
		new Class148(1L).int_4 = 8;
		Class148 @class = new Class148(2L);
		num += smethod_243(Class185.smethod_0(-1141216741), @class.int_4 != 8 && @class.int_5 == -1 && @class.uint_0 == 0);
		Class194 class194_ = new Class194(1L, 7u, Class185.smethod_0(-1141215602), bool_2: false, bool_3: true, 6, null, null, null, null, string.Empty, 12);
		Class194 class194_2 = new Class194(2L, 7u, Class185.smethod_0(-1141215602), bool_2: false, bool_3: false, null, null, null, null, null, Class185.smethod_0(-1141255782), 12);
		num += smethod_243(Class185.smethod_0(-1141221898), !GClass7.smethod_6(7u, null, 13) && !GClass7.smethod_6(7u, class194_2, 13) && !GClass7.smethod_6(7u, class194_, 12) && !GClass7.smethod_6(8u, class194_, 13) && GClass7.smethod_6(7u, class194_, 13));
		num += smethod_243(Class185.smethod_0(-1141221964), GClass7.smethod_4(0, 50) && GClass7.smethod_4(499, 50) && !GClass7.smethod_4(500, 50) && !GClass7.smethod_4(760, 50) && GClass7.smethod_4(760, 77) && !GClass7.smethod_4(null, 50));
		num += smethod_244(Class185.smethod_0(-1141222005), 100, GClass7.smethod_7(1000));
		Class194 class194_3 = new Class194(1L, 7u, Class185.smethod_0(-1141222027), bool_2: true, bool_3: true, 0, 1000, 3, null, null, string.Empty, 12);
		return num + smethod_243(Class185.smethod_0(-1141222046), GClass7.smethod_8(class194_3, 12) && !GClass7.smethod_8(class194_3, 13));
	}

	internal static int smethod_281()
	{
		int num = 0;
		Class394 @class = new Class394();
		DateTime dateTime_ = new DateTime(2026, 9, 24, 0, 0, 0, DateTimeKind.Utc);
		for (int i = 0; i < 5; i++)
		{
			DateTime dateTime_2 = dateTime_.AddSeconds(i);
			num += smethod_243(Class185.smethod_0(-1141222083), !@class.method_0(2629u, 2, 1, 2, 972f, -97f, 745 + i, 986f, -105f, 0, dateTime_2));
			@class.method_1(2629u, dateTime_2);
		}
		num += smethod_243(Class185.smethod_0(-1141222128), @class.method_0(2629u, 2, 1, 2, 972f, -97f, 750, 986f, -105f, 0, dateTime_.AddSeconds(5.0)));
		num += smethod_243(Class185.smethod_0(-1141222162), !@class.method_2(2630u, 2, 1, 2, 974f, -97f, dateTime_.AddSeconds(5.0)));
		num += smethod_243(Class185.smethod_0(-1141222204), !@class.method_2(2629u, 2, 1, 2, 972f, -97f, dateTime_.AddSeconds(66.0)));
		@class.method_3();
		@class.method_0(2629u, 2, 1, 2, 972f, -97f, 745, 986f, -105f, 0, dateTime_);
		@class.method_1(2629u, dateTime_);
		num += smethod_243(Class185.smethod_0(-1141222244), !@class.method_0(2629u, 2, 1, 2, 972f, -97f, 740, 986f, -105f, 0, dateTime_.AddSeconds(6.0)));
		for (int j = 0; j < 5; j++)
		{
			@class.method_1(2629u, dateTime_.AddSeconds(7 + j));
		}
		num += smethod_243(Class185.smethod_0(-1141222294), !@class.method_0(2629u, 2, 1, 2, 972f, -97f, 740, 986f, -105f, 0, dateTime_.AddSeconds(11.0)));
		@class.method_3();
		@class.method_0(2629u, 2, 1, 2, 972f, -97f, 745, 986f, -105f, 0, dateTime_);
		for (int k = 0; k < 5; k++)
		{
			@class.method_1(2629u, dateTime_.AddSeconds(k));
		}
		num += smethod_243(Class185.smethod_0(-1141222330), !@class.method_0(2629u, 2, 1, 2, 972f, -97f, 750, 989f, -105f, 0, dateTime_.AddSeconds(5.0)));
		for (int l = 0; l < 5; l++)
		{
			@class.method_1(2629u, dateTime_.AddSeconds(6 + l));
		}
		num += smethod_243(Class185.smethod_0(-1141222382), @class.method_0(2629u, 2, 1, 2, 972f, -97f, 750, 989f, -105f, 0, dateTime_.AddSeconds(11.0)));
		num += smethod_243(Class185.smethod_0(-1141221400), !@class.method_2(2629u, 2, 1, 2, 980f, -97f, dateTime_.AddSeconds(6.0)));
		@class.method_3();
		@class.method_0(2629u, 2, 1, 2, 972f, -97f, 745, 986f, -105f, 0, dateTime_);
		for (int m = 0; m < 5; m++)
		{
			@class.method_1(2629u, dateTime_.AddSeconds(m));
		}
		@class.method_0(2630u, 2, 1, 2, 974f, -97f, 500, 986f, -105f, 0, dateTime_.AddSeconds(5.0));
		return num + smethod_243(Class185.smethod_0(-1141221443), @class.method_0(2629u, 2, 1, 2, 972f, -97f, 750, 986f, -105f, 0, dateTime_.AddSeconds(5.0)));
	}

	public static int smethod_282()
	{
		Class268 @class = new Class268();
		int num = 0;
		num = 0 + smethod_283();
		Type type = typeof(GForm0).Assembly.GetType(Class185.smethod_0(-1141221498));
		num += smethod_243(Class185.smethod_0(-1141221537), type != null);
		@class.methodInfo_0 = ((type == null) ? null : type.GetMethod(Class185.smethod_0(-1141221554), BindingFlags.Static | BindingFlags.NonPublic));
		num += smethod_243(Class185.smethod_0(-1141221575), @class.methodInfo_0 != null);
		if (@class.methodInfo_0 != null)
		{
			Func<bool, bool, string, string, string, string> func = @class.method_0;
			num += smethod_244(Class185.smethod_0(-1141221586), Class185.smethod_0(-1141221614), func(arg1: false, arg2: false, Class185.smethod_0(-1141221631), Class185.smethod_0(-1141221646), Class185.smethod_0(-1141221614)));
			num += smethod_244(Class185.smethod_0(-1141221663), Class185.smethod_0(-1141221680), func(arg1: true, arg2: false, Class185.smethod_0(-1141221631), Class185.smethod_0(-1141221646), Class185.smethod_0(-1141221614)));
			num += smethod_244(Class185.smethod_0(-1141221700), Class185.smethod_0(-1141221715), func(arg1: false, arg2: true, Class185.smethod_0(-1141221631), Class185.smethod_0(-1141221646), Class185.smethod_0(-1141221614)));
			num += smethod_244(Class185.smethod_0(-1141221745), Class185.smethod_0(-1141221771), func(arg1: true, arg2: true, Class185.smethod_0(-1141221631), Class185.smethod_0(-1141221646), Class185.smethod_0(-1141221614)));
			num += smethod_244(Class185.smethod_0(-1141221812), Class135.smethod_4(), func(arg1: true, arg2: true, Class185.smethod_0(-1141270620), Class185.smethod_0(-1141328202), Class185.smethod_0(-1141299597)));
			num += smethod_244(Class185.smethod_0(-1141221842), Class135.smethod_4(), func(arg1: true, arg2: true, null, null, null));
			num += smethod_244(Class185.smethod_0(-1141221868), Class185.smethod_0(-1141222935), func(arg1: true, arg2: false, Class185.smethod_0(-1141222947), null, Class185.smethod_0(-1141222962)));
		}
		PropertyInfo property = typeof(Class145).GetProperty(Class185.smethod_0(-1141222971));
		MethodInfo methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		num += smethod_243(Class185.smethod_0(-1141222997), property != null);
		num += smethod_243(Class185.smethod_0(-1141223030), methodInfo != null);
		if (property != null && methodInfo != null)
		{
			Class145 class2 = (Class145)methodInfo.Invoke(Class145.class145_0, new object[1] { Class185.smethod_0(-1141221646) });
			num += smethod_244(Class185.smethod_0(-1141223051), Class185.smethod_0(-1141221646), (string)property.GetValue(class2));
			Class145 obj = class2.method_93(new Class83(), 1, 0).method_97(null, null, Class95.class95_0, 1, 0);
			num += smethod_244(Class185.smethod_0(-1141223086), Class185.smethod_0(-1141221646), (string)property.GetValue(obj));
			num += smethod_244(Class185.smethod_0(-1141223114), null, (string)property.GetValue(Class145.class145_0));
		}
		@class.methodInfo_1 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		num += smethod_243(Class185.smethod_0(-1141223152), @class.methodInfo_1 != null);
		if (@class.methodInfo_1 != null)
		{
			Func<string, string> func2 = @class.method_1;
			num += smethod_244(Class185.smethod_0(-1141223170), Class185.smethod_0(-1141221646), func2(Class185.smethod_0(-1141223195)));
			num += smethod_244(Class185.smethod_0(-1141223227), null, func2(Class185.smethod_0(-1141252598)));
			num += smethod_244(Class185.smethod_0(-1141223261), null, func2(Class185.smethod_0(-1141223285)));
			num += smethod_244(Class185.smethod_0(-1141223309), null, func2(Class185.smethod_0(-1141223334)));
			num += smethod_244(Class185.smethod_0(-1141223348), null, func2(Class185.smethod_0(-1141223378)));
			num += smethod_244(Class185.smethod_0(-1141223402), null, func2(Class185.smethod_0(-1141222416)));
		}
		Class327 class3 = new Class327(new IntPtr(177));
		Class119 class4 = new Class119();
		try
		{
			class4.method_34(class3);
			class4.method_35(Class299.class299_0.method_135);
			class4.method_46(5046u);
			string text = class4.method_78(27043);
			class3.method_1(Class185.smethod_0(-1141222438));
			num += smethod_243(Class185.smethod_0(-1141222513), text == null && class4.method_51().method_26() == Class185.smethod_0(-1141221646));
			class3.method_1(Class185.smethod_0(-1141222559));
			class3.method_1(Class185.smethod_0(-1141222626));
			num += smethod_244(Class185.smethod_0(-1141222699), Class185.smethod_0(-1141221646), class4.method_51().method_26());
			class4.method_210();
			num += smethod_244(Class185.smethod_0(-1141222743), null, class4.method_51().method_26());
		}
		finally
		{
			((IDisposable)class4).Dispose();
		}
		int int_ = 0;
		string text2 = smethod_173(Class185.smethod_0(-1141354742), ref int_);
		num += int_;
		if (text2 != null)
		{
			num += smethod_243(Class185.smethod_0(-1141222776), text2.Contains(Class185.smethod_0(-1141222803)));
			num += smethod_243(Class185.smethod_0(-1141222831), text2.Contains(Class185.smethod_0(-1141222849)));
			num += smethod_243(Class185.smethod_0(-1141222875), text2.Contains(Class185.smethod_0(-1141222908)));
			num += smethod_243(Class185.smethod_0(-1141219866), text2.Contains(Class185.smethod_0(-1141219900)));
			num += smethod_243(Class185.smethod_0(-1141219974), text2.Contains(Class185.smethod_0(-1141220000)));
			num += smethod_243(Class185.smethod_0(-1141220029), !text2.Contains(Class185.smethod_0(-1141220051)) && !text2.Contains(Class185.smethod_0(-1141220083)) && !text2.Contains(Class185.smethod_0(-1141220117)));
		}
		string text3 = smethod_173(Class185.smethod_0(-1141356151), ref num);
		if (text3 != null)
		{
			int num2 = text3.IndexOf(Class185.smethod_0(-1141220146), StringComparison.Ordinal);
			int num3 = text3.IndexOf(Class185.smethod_0(-1141220191), StringComparison.Ordinal);
			int num4 = text3.IndexOf(Class185.smethod_0(-1141220217), StringComparison.Ordinal);
			num += smethod_243(Class185.smethod_0(-1141220249), num2 >= 0 && num3 > num2 && num4 > num3);
		}
		if (num == 0)
		{
			Console.WriteLine(Class185.smethod_0(-1141220303));
		}
		else
		{
			Console.WriteLine(num + Class185.smethod_0(-1141220320));
		}
		return num;
	}

	private static int smethod_283()
	{
		string text = smethod_171(Class185.smethod_0(-1141220340));
		if (text == null)
		{
			return smethod_243(Class185.smethod_0(-1141219366), bool_0: false);
		}
		try
		{
			using Process process = Process.Start(new ProcessStartInfo
			{
				FileName = Class185.smethod_0(-1141218969),
				Arguments = Class185.smethod_0(-1141304355) + text + Class185.smethod_0(-1141304355),
				WorkingDirectory = Path.GetDirectoryName(text),
				UseShellExecute = false,
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true
			});
			if (process == null)
			{
				return smethod_243(Class185.smethod_0(-1141219399), bool_0: false);
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
				return smethod_243(Class185.smethod_0(-1141219431), bool_0: false);
			}
			if (process.ExitCode == 0 && text2.Contains(Class185.smethod_0(-1141219457)))
			{
				return 0;
			}
			Console.WriteLine(text2 + text3);
			return smethod_243(Class185.smethod_0(-1141219495), bool_0: false);
		}
		catch (Exception ex)
		{
			Console.WriteLine(Class185.smethod_0(-1141219522) + ex.GetType().Name + Class185.smethod_0(-1141301932) + ex.Message);
			return smethod_243(Class185.smethod_0(-1141219552), bool_0: false);
		}
	}

	internal static int smethod_284()
	{
		int num = 0;
		string text = ((Class135.smethod_1() == Class185.smethod_0(-1141297765)) ? Class185.smethod_0(-1141219601) : ((Class135.smethod_1() == Class185.smethod_0(-1141219583)) ? Class185.smethod_0(-1141219588) : null));
		num += smethod_243(Class185.smethod_0(-1141219622), text != null);
		if (text != null)
		{
			string text2 = Class185.smethod_0(-1141219646) + text;
			num += smethod_244(Class185.smethod_0(-1141219662), Class185.smethod_0(-1141219675) + Class135.smethod_1(), Class135.smethod_2());
			num += smethod_244(Class185.smethod_0(-1141219694), text2, Class135.smethod_4());
			num += smethod_244(Class185.smethod_0(-1141219712), text2 + Class185.smethod_0(-1141219736), Class135.smethod_3());
			num += smethod_244(Class185.smethod_0(-1141219746), text2 + Class185.smethod_0(-1141219772), Class135.smethod_5());
			num += smethod_244(Class185.smethod_0(-1141219786), text2 + Class185.smethod_0(-1141219818), Class135.smethod_7());
			num += smethod_244(Class185.smethod_0(-1141220872), text2 + Class185.smethod_0(-1141220891), Class135.smethod_8());
		}
		num += smethod_243(Class185.smethod_0(-1141220906), Class39.smethod_7(Class185.smethod_0(-1141220933), Class185.smethod_0(-1141220943)));
		num += smethod_243(Class185.smethod_0(-1141220945), Class39.smethod_7(Class185.smethod_0(-1141220933), Class185.smethod_0(-1141220970)));
		num += smethod_243(Class185.smethod_0(-1141220991), !Class39.smethod_7(Class185.smethod_0(-1141220933), Class185.smethod_0(-1141221001)));
		num += smethod_243(Class185.smethod_0(-1141221021), !Class39.smethod_7(Class185.smethod_0(-1141220943), Class185.smethod_0(-1141220933)));
		num += smethod_243(Class185.smethod_0(-1141221040), !Class39.smethod_7(Class185.smethod_0(-1141220933), Class185.smethod_0(-1141221057)));
		string text3 = Class39.smethod_10(Class185.smethod_0(-1141221079), Class185.smethod_0(-1141221112));
		num += smethod_243(Class185.smethod_0(-1141221136), text3.Contains(Class185.smethod_0(-1141221161)));
		num += smethod_243(Class185.smethod_0(-1141221205), text3.Contains(Class185.smethod_0(-1141221224)));
		num += smethod_243(Class185.smethod_0(-1141221246), text3.Contains(Class185.smethod_0(-1141304355) + Class135.smethod_7() + Class185.smethod_0(-1141304355)));
		num += smethod_243(Class185.smethod_0(-1141221270), text3.Contains(Class185.smethod_0(-1141221281)));
		num += smethod_243(Class185.smethod_0(-1141221307), !string.IsNullOrWhiteSpace(Class135.smethod_4()));
		num += smethod_244(Class185.smethod_0(-1141221329), Class185.smethod_0(-1141297879), Class135.smethod_6());
		num += smethod_244(Class185.smethod_0(-1141221355), Class135.smethod_4() + Class185.smethod_0(-1141219818), Class135.smethod_7());
		string text4 = Class39.smethod_8(JsonConvert.DeserializeObject<GClass5>(Class185.smethod_0(-1141220356)));
		num += smethod_243(Class185.smethod_0(-1141220440), text4.Contains(Class185.smethod_0(-1141220477)));
		num += smethod_243(Class185.smethod_0(-1141220508), text4.Contains(Class185.smethod_0(-1141220943)));
		num += smethod_243(Class185.smethod_0(-1141220539), Class39.smethod_0(528040));
		num += smethod_243(Class185.smethod_0(-1141220574), !Class39.smethod_0(461808));
		using (Stream stream = typeof(GForm0).Assembly.GetManifestResourceStream(Class185.smethod_0(-1141270703)))
		{
			num += smethod_243(Class185.smethod_0(-1141220595), stream != null && stream.Length > 0L);
		}
		num += smethod_244(Class185.smethod_0(-1141220629), Class185.smethod_0(-1141220655), GForm0.smethod_21(TimeSpan.Zero));
		num += smethod_244(Class185.smethod_0(-1141220665), Class185.smethod_0(-1141220655), GForm0.smethod_21(TimeSpan.FromSeconds(-1.0)));
		Class39.smethod_2(Class185.smethod_0(-1141220703));
		num += smethod_243(Class185.smethod_0(-1141220722), Class39.smethod_3(out var string_));
		num += smethod_244(Class185.smethod_0(-1141220758), Class185.smethod_0(-1141220703), string_);
		num += smethod_243(Class185.smethod_0(-1141220784), !Class39.smethod_3(out string_));
		Console.WriteLine((num == 0) ? Class185.smethod_0(-1141220826) : (Class185.smethod_0(-1141220814) + num));
		return num;
	}

	internal static int smethod_285()
	{
		int num = smethod_284();
		num += smethod_282();
		num += smethod_31();
		Console.WriteLine((num == 0) ? Class185.smethod_0(-1141225993) : (Class185.smethod_0(-1141220844) + num));
		return num;
	}

	internal static int smethod_286()
	{
		Class329 @class = new Class329();
		int num = 0;
		@class.int_0 = 0;
		@class.int_1 = 0;
		using (Class139 class2 = smethod_287(smethod_288(bool_0: false, Class185.smethod_0(-1141226020)), @class.method_0, @class.method_1))
		{
			bool result = class2.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243(Class185.smethod_0(-1141226036), !result);
			num += smethod_244(Class185.smethod_0(-1141226073), 0, @class.int_0);
			num += smethod_244(Class185.smethod_0(-1141226107), 0, @class.int_1);
		}
		@class.class438_0 = smethod_288(bool_0: true, Class185.smethod_0(-1141255256));
		using (Class139 class3 = smethod_287(@class.class438_0, @class.method_2, @class.method_3))
		{
			bool result2 = class3.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243(Class185.smethod_0(-1141226140), !result2);
			num += smethod_244(Class185.smethod_0(-1141226171), 0, @class.int_1);
			int int_ = @class.int_0;
			class3.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_244(Class185.smethod_0(-1141226203), int_, @class.int_0);
		}
		@class.int_3 = 0;
		@class.int_2 = 0;
		using (Class139 class4 = new Class139(Class299.class299_0.method_136, @class.method_4, @class.method_5, Class299.class299_0.method_137, Class299.class299_0.method_138, Class299.class299_0.method_139))
		{
			class4.method_0(CancellationToken.None).GetAwaiter().GetResult();
			class4.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_244(Class185.smethod_0(-1141226253), 2, @class.int_3);
		}
		@class.string_0 = null;
		using (Class139 class5 = smethod_287(@class.class438_0, Class299.class299_0.method_140, @class.method_6))
		{
			bool result3 = class5.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243(Class185.smethod_0(-1141226288), result3);
			num += smethod_244(Class185.smethod_0(-1141226305), Class185.smethod_0(-1141255840), @class.string_0);
		}
		@class.int_4 = 0;
		using (Class139 class6 = new Class139(@class.method_7, @class.method_8, Class299.class299_0.method_141, Class299.class299_0.method_142, Class299.class299_0.method_143, Class299.class299_0.method_144))
		{
			bool result4 = class6.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243(Class185.smethod_0(-1141226331), !result4);
			num += smethod_244(Class185.smethod_0(-1141226373), 0, @class.int_4);
		}
		@class.int_5 = 0;
		@class.taskCompletionSource_0 = new TaskCompletionSource<Class438>();
		using (Class139 class7 = new Class139(Class299.class299_0.method_145, @class.method_9, Class299.class299_0.method_146, Class299.class299_0.method_147, Class299.class299_0.method_148, Class299.class299_0.method_149))
		{
			Task<bool> task = class7.method_0(CancellationToken.None);
			num += smethod_243(bool_0: !class7.method_0(CancellationToken.None).GetAwaiter().GetResult(), string_0: Class185.smethod_0(-1141226406));
			num += smethod_244(Class185.smethod_0(-1141226447), 1, @class.int_5);
			@class.taskCompletionSource_0.SetResult(@class.class438_0);
			task.GetAwaiter().GetResult();
		}
		@class.string_1 = null;
		Class139 class8 = new Class139(Class299.class299_0.method_150, Class299.class299_0.method_151, @class.method_10, @class.method_11, Class299.class299_0.method_152, @class.method_12);
		try
		{
			bool result5 = class8.method_0(CancellationToken.None).GetAwaiter().GetResult();
			num += smethod_243(Class185.smethod_0(-1141226475), !result5);
			num += smethod_243(Class185.smethod_0(-1141225494), @class.string_1 != null && !@class.string_1.Contains(Class185.smethod_0(-1141255804)));
		}
		finally
		{
			((IDisposable)class8).Dispose();
		}
		@class.taskCompletionSource_1 = new TaskCompletionSource<string>();
		Class139 class9 = new Class139(@class.method_13, @class.method_14, Class299.class299_0.method_153, Class299.class299_0.method_154, Class299.class299_0.method_155, Class299.class299_0.method_156);
		Task<bool> task2 = class9.method_0(CancellationToken.None);
		class9.Dispose();
		num += smethod_243(Class185.smethod_0(-1141225525), !task2.GetAwaiter().GetResult());
		string text = Class39.smethod_11(@class.class438_0, Class185.smethod_0(-1141225553), Class185.smethod_0(-1141225572), 1234, 5678L);
		num += smethod_243(Class185.smethod_0(-1141225596), text.Contains(Class185.smethod_0(-1141271295)));
		num += smethod_243(Class185.smethod_0(-1141225620), text.Contains(Class185.smethod_0(-1141271317)));
		num += smethod_243(Class185.smethod_0(-1141225642), text.Contains(Class185.smethod_0(-1141225676)));
		num += smethod_243(Class185.smethod_0(-1141225717), text.Contains(Class185.smethod_0(-1141225749)));
		num += smethod_243(Class185.smethod_0(-1141225772), text.Contains(Class185.smethod_0(-1141225803)));
		num += smethod_243(Class185.smethod_0(-1141225828), text.Contains(Class185.smethod_0(-1141225858)));
		num += smethod_243(Class185.smethod_0(-1141225897), text.Contains(Class185.smethod_0(-1141225923)) && text.Contains(Class185.smethod_0(-1141225957)));
		num += smethod_243(Class185.smethod_0(-1141227024), !text.Contains(Class185.smethod_0(-1141255840)));
		num += smethod_243(Class185.smethod_0(-1141227044), text.Contains(Class185.smethod_0(-1141227067) + Class135.smethod_4() + Class185.smethod_0(-1141227081)));
		string text2 = Class39.smethod_12(@class.class438_0);
		num += smethod_243(Class185.smethod_0(-1141227101), text2.Contains(Class185.smethod_0(-1141227128)));
		num += smethod_243(Class185.smethod_0(-1141227141), text2.Contains(Class185.smethod_0(-1141227162)) && text2.Contains(Class185.smethod_0(-1141227178)));
		Class438 class10 = smethod_289(Class185.smethod_0(-1141227187), bool_0: true);
		num += smethod_244(Class185.smethod_0(-1141227230), Class185.smethod_0(-1141227187), class10.String_4);
		string text3 = Class39.smethod_12(class10);
		num += smethod_243(Class185.smethod_0(-1141227263), text3.Contains(Class185.smethod_0(-1141227298)));
		num += smethod_243(Class185.smethod_0(-1141227345), text3.Contains(Class185.smethod_0(-1141227388)) && text3.Contains(Class185.smethod_0(-1141227416)));
		Class438 class11 = smethod_289(null, bool_0: false);
		num += smethod_244(Class185.smethod_0(-1141227437), string.Empty, class11.String_4);
		Class438 class12 = smethod_289(Class185.smethod_0(-1141299444), bool_0: true);
		num += smethod_244(Class185.smethod_0(-1141227476), string.Empty, class12.String_4);
		Class438 class13 = smethod_289(new string('x', 9000), bool_0: true);
		num += smethod_244(Class185.smethod_0(-1141226506), 8192, class13.String_4.Length);
		Class39.smethod_3(out var string_);
		Class39.smethod_6(out var class40_);
		num += smethod_243(Class185.smethod_0(-1141226550), Class39.smethod_5(@class.class438_0, Class185.smethod_0(-1141226570)));
		num += smethod_243(Class185.smethod_0(-1141226595), !Class39.smethod_5(@class.class438_0, Class185.smethod_0(-1141226640)));
		Class39.smethod_2(Class185.smethod_0(-1141226664));
		num += smethod_243(Class185.smethod_0(-1141226675), !Class39.smethod_6(out class40_));
		num += smethod_243(Class185.smethod_0(-1141226719), Class39.smethod_3(out string_));
		num += smethod_244(Class185.smethod_0(-1141226746), Class185.smethod_0(-1141226664), string_);
		string text4 = Class49.smethod_0(Class185.smethod_0(-1141226781));
		byte[] bytes = File.ReadAllBytes(text4);
		num += smethod_243(Class185.smethod_0(-1141226794), !Encoding.UTF8.GetString(bytes).Contains(Class185.smethod_0(-1141226781)));
		num += smethod_244(Class185.smethod_0(-1141226837), Class185.smethod_0(-1141226781), Class49.smethod_1(text4));
		num += smethod_243(Class185.smethod_0(-1141226871), !File.Exists(text4));
		Console.WriteLine((num == 0) ? Class185.smethod_0(-1141226924) : (Class185.smethod_0(-1141226904) + num));
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
			String_0 = Class185.smethod_0(-1141227162),
			String_1 = Class185.smethod_0(-1141227178),
			String_2 = new string('a', 64),
			Int64_0 = 25L,
			Int64_1 = 303L,
			Int64_2 = 404L,
			String_3 = (bool_0 ? Class185.smethod_0(-1141294353) : Class185.smethod_0(-1141293618)),
			Nullable_0 = (bool_0 ? new long?(20L) : new long?(25L)),
			String_4 = (bool_0 ? new string('b', 64) : new string('a', 64))
		};
		Class438 class2 = new Class438();
		class2.String_0 = Class185.smethod_0(-1141297770);
		class2.String_1 = string_0;
		class2.String_3 = Class185.smethod_0(-1141252598);
		class2.String_2 = new string(string_0.EndsWith(Class185.smethod_0(-1141226958)) ? 'd' : 'c', 64);
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
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141226966) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
		Directory.CreateDirectory(text);
		try
		{
			Class238 @class = new Class238(string_0, bool_0);
			try
			{
				return Class21.smethod_1(Class185.smethod_0(-1141293709), Class185.smethod_0(-1141226999), Class185.smethod_0(-1141227002), text, Class185.smethod_0(-1141223945), CancellationToken.None, (HttpMessageHandler)(object)@class).GetAwaiter().GetResult();
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
		num = 0 + smethod_243(Class185.smethod_0(-1141223962), Form5.smethod_0(Class185.smethod_0(-1141223992)));
		num += smethod_243(Class185.smethod_0(-1141224010), !Form5.smethod_0(Class185.smethod_0(-1141224034)));
		num += smethod_243(Class185.smethod_0(-1141224050), !Form5.smethod_0(Class185.smethod_0(-1141224081)));
		Form5 form = new Form5(Class185.smethod_0(-1141224107), Class185.smethod_0(-1141220933), new GClass20());
		try
		{
			Control[] array = form.Controls.Find(Class185.smethod_0(-1141266307), searchAllChildren: true);
			num += smethod_243(Class185.smethod_0(-1141224124), array.Length == 1);
			if (array.Length == 1)
			{
				num += smethod_244(Class185.smethod_0(-1141224157), Class185.smethod_0(-1141224107), array[0].Text);
			}
			num += smethod_243(Class185.smethod_0(-1141224172), form.Controls.Find(Class185.smethod_0(-1141266343), searchAllChildren: true).Length == 1);
			num += smethod_243(Class185.smethod_0(-1141224196), form.Controls.Find(Class185.smethod_0(-1141266360), searchAllChildren: true).Length == 1);
			num += smethod_244(Class185.smethod_0(-1141224231), FormStartPosition.CenterParent, form.StartPosition);
		}
		finally
		{
			((IDisposable)form).Dispose();
		}
		Console.WriteLine((num == 0) ? Class185.smethod_0(-1141224268) : (Class185.smethod_0(-1141224249) + num));
		return num;
	}

	internal static int smethod_291()
	{
		int num = 0;
		num = 0 + smethod_243(Class185.smethod_0(-1141224293), !GClass15.smethod_0(null, 1).GetAwaiter().GetResult());
		int[] array = new int[2] { 1, 2 };
		foreach (int int_ in array)
		{
			num += smethod_292(Class185.smethod_0(-1141224318), null, int_);
			num += smethod_292(Class185.smethod_0(-1141224332), new GClass0
			{
				IsValid = true,
				Vip = false
			}, int_);
			num += smethod_292(Class185.smethod_0(-1141224353), new GClass0
			{
				IsValid = false,
				Vip = true
			}, int_);
		}
		GForm0 gForm = (GForm0)FormatterServices.GetUninitializedObject(typeof(GForm0));
		GC.SuppressFinalize(gForm);
		typeof(GForm0).GetField(Class185.smethod_0(-1141224371), BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, new GClass0
		{
			IsValid = true,
			Vip = true
		});
		PropertyInfo property = typeof(GForm0).GetProperty(Class185.smethod_0(-1141224399), BindingFlags.Instance | BindingFlags.NonPublic);
		num += smethod_243(Class185.smethod_0(-1141224415), property != null && (bool)property.GetValue(gForm));
		Class119 @class = (Class119)FormatterServices.GetUninitializedObject(typeof(Class119));
		typeof(GForm0).GetField(Class185.smethod_0(-1141256027), BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, @class);
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
			typeof(Class119).GetField(Class185.smethod_0(-1141259782), BindingFlags.Instance | BindingFlags.NonPublic).SetValue(@class, value);
			num += smethod_243(Class185.smethod_0(-1141224448) + (flag ? Class185.smethod_0(-1141154429) : Class185.smethod_0(-1141144353)), !GClass15.smethod_0(gForm, 1).GetAwaiter().GetResult());
		}
		Console.WriteLine(Class185.smethod_0(-1141223442) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	private static int smethod_292(string string_0, GClass0 gclass0_0, int int_0)
	{
		GForm0 gForm = (GForm0)FormatterServices.GetUninitializedObject(typeof(GForm0));
		GC.SuppressFinalize(gForm);
		typeof(GForm0).GetField(Class185.smethod_0(-1141224371), BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, gclass0_0);
		string text = Class185.smethod_0(-1141223459) + string_0 + Class185.smethod_0(-1141223475) + int_0;
		try
		{
			return smethod_243(text, !GClass15.smethod_0(gForm, int_0).GetAwaiter().GetResult());
		}
		catch (Exception ex)
		{
			Console.WriteLine(Class185.smethod_0(-1141228144) + text + Class185.smethod_0(-1141223496) + ex.GetType().Name);
			return 1;
		}
	}

	internal static int smethod_293()
	{
		int num = 0;
		string text = Path.Combine(Path.GetTempPath(), Class185.smethod_0(-1141305101) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407)));
		Directory.CreateDirectory(text);
		try
		{
			string string_ = Path.Combine(text, Class185.smethod_0(-1141305115));
			Class59 @class = new Class59(string_);
			try
			{
				@class.method_0(Class185.smethod_0(-1141223527));
				@class.method_0(Class185.smethod_0(-1141223599));
				@class.method_0(Class185.smethod_0(-1141223661));
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			num += smethod_243(Class185.smethod_0(-1141223683), Class396.smethod_0(string_, bool_0: false));
			Class59 class2 = new Class59(string_);
			try
			{
				num += smethod_244(Class185.smethod_0(-1141223716), Class185.smethod_0(-1141296459), class2.method_1(Class185.smethod_0(-1141304114)));
				num += smethod_244(Class185.smethod_0(-1141223750), Class185.smethod_0(-1141297402), class2.method_1(Class185.smethod_0(-1141304050)));
			}
			finally
			{
				((IDisposable)class2).Dispose();
			}
			num += smethod_243(Class185.smethod_0(-1141223783), !Class396.smethod_0(string_, bool_0: false));
			num += smethod_243(Class185.smethod_0(-1141223811), Class396.smethod_0(string_, bool_0: true));
			Class59 class3 = new Class59(string_);
			try
			{
				num += smethod_244(Class185.smethod_0(-1141223843), null, class3.method_1(Class185.smethod_0(-1141304114)));
				num += smethod_244(Class185.smethod_0(-1141223885), Class185.smethod_0(-1141297402), class3.method_1(Class185.smethod_0(-1141304050)));
				num += smethod_244(Class185.smethod_0(-1141223916), Class185.smethod_0(-1141303993), class3.method_1(Class185.smethod_0(-1141303964)));
			}
			finally
			{
				((IDisposable)class3).Dispose();
			}
			num += smethod_243(Class185.smethod_0(-1141224975), !Class396.smethod_0(string_, bool_0: true));
			string string_2 = Path.Combine(text, Class185.smethod_0(-1141225002));
			Class59 class4 = new Class59(string_2);
			try
			{
				class4.method_0(Class185.smethod_0(-1141225031));
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
			num += smethod_243(Class185.smethod_0(-1141225079), bool_);
		}
		finally
		{
			Directory.Delete(text, recursive: true);
		}
		Console.WriteLine((num == 0) ? Class185.smethod_0(-1141225136) : (Class185.smethod_0(-1141225112) + num));
		return num;
	}

	internal static int smethod_294()
	{
		Class288 @class = new Class288();
		int num = 0;
		Dictionary<string, string> ireadOnlyDictionary_ = new Dictionary<string, string>
		{
			{
				Class185.smethod_0(-1141296467),
				Class185.smethod_0(-1141255857)
			},
			{
				Class185.smethod_0(-1141297402),
				Class185.smethod_0(-1141255868)
			},
			{
				Class185.smethod_0(-1141297437),
				Class185.smethod_0(-1141255883)
			}
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
		List<Class53> source = Class144.smethod_0(@class.class145_0, Class185.smethod_0(-1141255857), @class.hashSet_0);
		num = 0 + smethod_243(Class185.smethod_0(-1141225158), source.Any(Class299.class299_0.method_160));
		num += smethod_243(Class185.smethod_0(-1141225175), source.Any(Class299.class299_0.method_161));
		num += smethod_243(Class185.smethod_0(-1141225186), source.All(Class299.class299_0.method_162));
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
		source = Class144.smethod_1(@class.class145_0, Class185.smethod_0(-1141255857), @class.hashSet_0, 9, @class.valueTuple_0);
		num += smethod_243(Class185.smethod_0(-1141225212), source.Any(Class299.class299_0.method_163));
		num += smethod_243(Class185.smethod_0(-1141225251), source.Any(Class299.class299_0.method_164));
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
		source = Class144.smethod_1(@class.class145_0, Class185.smethod_0(-1141255857), @class.hashSet_0, 10, @class.valueTuple_0);
		num += smethod_243(Class185.smethod_0(-1141225301), source.Any(Class299.class299_0.method_165));
		dictionary2.Remove(2u);
		@class.class145_0 = Class145.class145_0.method_96(ilist_, new Class95(null, null, ireadOnlyDictionary_), null, default(GStruct4), Class446.class446_0, 2, 0, dictionary2, new uint[2] { 1u, 2u }, new uint[2] { 1u, 2u }, null, default(Struct26));
		source = Class144.smethod_1(@class.class145_0, Class185.smethod_0(-1141255857), @class.hashSet_0, 9, @class.valueTuple_0);
		num += smethod_243(Class185.smethod_0(-1141225342), source.Any(Class299.class299_0.method_166));
		@class.class145_0 = Class145.class145_0.method_96(ilist_, new Class95(null, null, ireadOnlyDictionary_), null, default(GStruct4), Class446.class446_0, 2, 0, null, new uint[0], null, null, default(Struct26));
		source = Class144.smethod_0(@class.class145_0, Class185.smethod_0(-1141255857), @class.hashSet_0);
		num += smethod_243(Class185.smethod_0(-1141225378), source.Count == 1 && source[0].string_0 == Class185.smethod_0(-1141255857));
		@class.hashSet_0.Add(Class185.smethod_0(-1141255868));
		source = Class144.smethod_0(@class.class145_0, Class185.smethod_0(-1141255857), @class.hashSet_0);
		num += smethod_243(Class185.smethod_0(-1141225413), source.Any(Class299.class299_0.method_167));
		Form9 form = new Form9(9, @class.hashSet_0, @class.method_0);
		try
		{
			form.method_0();
			DataGridView dataGridView = form.Controls.OfType<DataGridView>().Single();
			num += smethod_243(Class185.smethod_0(-1141225440), dataGridView.Columns.Count == 3 && dataGridView.Columns[2].Name == Class185.smethod_0(-1141225465));
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
			num += smethod_243(Class185.smethod_0(-1141224464), dataGridView2.Rows.Count == 2);
			dataGridView2.Rows[0].Cells[0].Value = true;
			num += smethod_243(Class185.smethod_0(-1141224488), @class.hashSet_0.Contains(Class185.smethod_0(-1141255857)));
			form2.method_0();
			num += smethod_243(Class185.smethod_0(-1141224507), dataGridView2.Rows.Cast<DataGridViewRow>().Any(Class299.class299_0.method_168));
		}
		finally
		{
			((IDisposable)form2).Dispose();
		}
		GForm0 gForm = (GForm0)FormatterServices.GetUninitializedObject(typeof(GForm0));
		object value = new object();
		HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			Class185.smethod_0(-1141255857),
			Class185.smethod_0(-1141255868)
		};
		HashSet<string> hashSet2 = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { Class185.smethod_0(-1141255857) };
		typeof(GForm0).GetField(Class185.smethod_0(-1141224549), BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, value);
		typeof(GForm0).GetField(Class185.smethod_0(-1141224575), BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, hashSet);
		typeof(GForm0).GetField(Class185.smethod_0(-1141224598), BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, hashSet2);
		num += smethod_243(Class185.smethod_0(-1141224622), gForm.method_103(9, out var list_) && list_.Count == 2 && list_.Contains(Class185.smethod_0(-1141255857)) && list_.Contains(Class185.smethod_0(-1141255868)));
		list_.Clear();
		num += smethod_243(Class185.smethod_0(-1141224650), hashSet.Count == 2);
		num += smethod_243(Class185.smethod_0(-1141224675), gForm.method_103(10, out list_) && list_.Count == 1 && list_[0] == Class185.smethod_0(-1141255857));
		num += smethod_243(Class185.smethod_0(-1141224706), !gForm.method_103(8, out list_) && list_.Count == 0);
		hashSet2.Clear();
		num += smethod_243(Class185.smethod_0(-1141224752), !gForm.method_103(10, out list_) && list_.Count == 0);
		Console.WriteLine(Class185.smethod_0(-1141224786) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	internal static int smethod_295()
	{
		int num = 0;
		num = 0 + smethod_243(Class185.smethod_0(-1141224815), Class418.smethod_0(1058u) == Class185.smethod_0(-1141224847));
		num += smethod_243(Class185.smethod_0(-1141224891), Class418.smethod_1() == Class185.smethod_0(-1141224921));
		num += smethod_243(Class185.smethod_0(-1141197314), Class418.smethod_2() == Class185.smethod_0(-1141197346));
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
		return num + smethod_243(Class185.smethod_0(-1141197383), list.Count == 3 && (string)JObject.Parse(list[0])[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141197428) && (uint)JObject.Parse(list[0])[Class185.smethod_0(-1141293578)] == 1058 && (bool)JObject.Parse(list[1])[Class185.smethod_0(-1141197455)] && (string)JObject.Parse(list[2])[Class185.smethod_0(-1141254460)] == Class185.smethod_0(-1141197458));
	}

	internal static int smethod_296()
	{
		int num = 0;
		IReadOnlyList<uint> readOnlyList = Class119.smethod_31(JObject.Parse(Class185.smethod_0(-1141252598)));
		num = 0 + smethod_243(Class185.smethod_0(-1141197485), readOnlyList == null);
		IReadOnlyList<uint> readOnlyList2 = Class119.smethod_31(JObject.Parse(Class185.smethod_0(-1141197526)));
		num += smethod_243(Class185.smethod_0(-1141197540), readOnlyList2 != null && readOnlyList2.Count == 0);
		IReadOnlyList<uint> readOnlyList3 = Class119.smethod_31(JObject.Parse(Class185.smethod_0(-1141197591)));
		num += smethod_243(Class185.smethod_0(-1141197619), readOnlyList3 != null && readOnlyList3.Count == 3 && readOnlyList3[0] == 1 && readOnlyList3[1] == 2 && readOnlyList3[2] == uint.MaxValue);
		num += smethod_243(Class185.smethod_0(-1141197669), Class119.smethod_31(JObject.Parse(Class185.smethod_0(-1141197712))) == null);
		num += smethod_243(Class185.smethod_0(-1141197741), Class119.smethod_32(JObject.Parse(Class185.smethod_0(-1141252598))) == null);
		IReadOnlyList<uint> readOnlyList4 = Class119.smethod_32(JObject.Parse(Class185.smethod_0(-1141197783)));
		num += smethod_243(Class185.smethod_0(-1141197804), readOnlyList4 != null && readOnlyList4.Count == 0);
		IReadOnlyList<uint> readOnlyList5 = Class119.smethod_32(JObject.Parse(Class185.smethod_0(-1141196823)));
		num += smethod_243(Class185.smethod_0(-1141196855), readOnlyList5 != null && readOnlyList5.Count == 2 && readOnlyList5[0] == 1 && readOnlyList5[1] == 2);
		num += smethod_243(Class185.smethod_0(-1141196896), Class119.smethod_32(JObject.Parse(Class185.smethod_0(-1141196932))) == null);
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
		JObject jobject_ = JObject.Parse(Class185.smethod_0(-1141196976));
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
		num += smethod_243(Class185.smethod_0(-1141197066), readOnlyDictionary.ContainsKey(1u) && readOnlyDictionary[1u].Count == 1 && readOnlyDictionary[1u][0].ushort_0 == 7 && readOnlyDictionary[1u][0].ushort_1 == 8 && readOnlyDictionary[1u][0].int_0 == 4 && readOnlyDictionary[1u][0].float_0 == 30f);
		num += smethod_243(Class185.smethod_0(-1141197112), readOnlyDictionary.ContainsKey(2u) && readOnlyDictionary[2u].Count == 0);
		num += smethod_243(Class185.smethod_0(-1141197150), !readOnlyDictionary.ContainsKey(4u));
		num += smethod_243(Class185.smethod_0(-1141197185), !readOnlyDictionary.ContainsKey(3u));
		Class145 @class = Class145.class145_0.method_96(ilist_, Class95.class95_0, readOnlyList6, default(GStruct4), Class446.class446_0, 1, 0, readOnlyDictionary, new uint[3] { 1u, 2u, 4u }, readOnlyList5, null, default(Struct26));
		num += smethod_243(Class185.smethod_0(-1141197240), @class.method_14() != null && @class.method_14().Count == 3 && @class.method_14()[2] == 4);
		num += smethod_243(Class185.smethod_0(-1141197273), @class.method_93(null, 1, 0).method_14() != null && @class.method_93(null, 1, 0).method_14().Count == 3);
		num += smethod_243(Class185.smethod_0(-1141198337), @class.method_16() != null && @class.method_16().Count == 2 && @class.method_93(null, 1, 0).method_16() != null && @class.method_93(null, 1, 0).method_16().Count == 2);
		@class = @class.method_96(ilist_, Class95.class95_0, readOnlyList6, default(GStruct4), Class446.class446_0, 2, 0, new Dictionary<uint, IReadOnlyList<GStruct2>>(), readOnlyList2, readOnlyList4, null, default(Struct26));
		num += smethod_243(Class185.smethod_0(-1141198400), @class.method_14() != null && @class.method_14().Count == 0);
		num += smethod_243(Class185.smethod_0(-1141198442), @class.method_16() != null && @class.method_16().Count == 0);
		num += smethod_243(Class185.smethod_0(-1141198495), GClass19.smethod_1(new List<GStruct2>(), 7, 8, 5));
		num += smethod_243(Class185.smethod_0(-1141198523), GClass19.smethod_1(new List<GStruct2>
		{
			new GStruct2
			{
				ushort_0 = 7,
				ushort_1 = 8,
				float_0 = 4.9f
			}
		}, 7, 8, 5));
		num += smethod_243(Class185.smethod_0(-1141198568), !GClass19.smethod_1(new List<GStruct2>
		{
			new GStruct2
			{
				ushort_0 = 7,
				ushort_1 = 8,
				float_0 = 5.1f
			}
		}, 7, 8, 5));
		num += smethod_243(Class185.smethod_0(-1141198607), !GClass19.smethod_1(new List<GStruct2>(), ushort.MaxValue, ushort.MaxValue, 5));
		num += smethod_243(Class185.smethod_0(-1141198646), !((GForm0)null).smethod_4());
		GForm0 gForm = (GForm0)FormatterServices.GetUninitializedObject(typeof(GForm0));
		num += smethod_243(Class185.smethod_0(-1141198667), !gForm.smethod_4());
		Class119 class2 = (Class119)FormatterServices.GetUninitializedObject(typeof(Class119));
		typeof(GForm0).GetField(Class185.smethod_0(-1141256027), BindingFlags.Instance | BindingFlags.NonPublic).SetValue(gForm, class2);
		typeof(Class119).GetField(Class185.smethod_0(-1141259782), BindingFlags.Instance | BindingFlags.NonPublic).SetValue(class2, @class);
		num += smethod_243(Class185.smethod_0(-1141198697), !gForm.smethod_4());
		Class145 value = @class.method_96(ilist_, Class95.class95_0, readOnlyList6, default(GStruct4), Class446.class446_0, 3, 0, readOnlyDictionary, new uint[2] { 1u, 2u }, null, null, default(Struct26));
		typeof(Class119).GetField(Class185.smethod_0(-1141259782), BindingFlags.Instance | BindingFlags.NonPublic).SetValue(class2, value);
		num += smethod_243(Class185.smethod_0(-1141198731), gForm.smethod_4());
		Console.WriteLine(Class185.smethod_0(-1141198773) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	internal static int smethod_297()
	{
		int num = 0;
		Class95 class95_ = new Class95(null, null, new Dictionary<string, string>
		{
			{
				Class185.smethod_0(-1141198800),
				Class185.smethod_0(-1141198801)
			},
			{
				Class185.smethod_0(-1141198810),
				Class185.smethod_0(-1141198819)
			},
			{
				Class185.smethod_0(-1141198840),
				Class185.smethod_0(-1141306917)
			}
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
		Class401 class3 = Class38.smethod_0(class2, Class185.smethod_0(-1141198801), dateTime);
		num = 0 + smethod_243(Class185.smethod_0(-1141198841), class3 != null && class3.uint_0 == 11 && class3.string_0 == Class185.smethod_0(-1141198801) && class3.float_0 == 4f && class3.float_1 == 5f && class3.float_2 == 6f && class3.bool_1 && class3.byte_0 == 1 && class3.bool_2 && class3.byte_1 == 2 && class3.ushort_0 == 77 && class3.long_0 == dateTime.Ticks);
		string text = Class174.smethod_1(class3, 1234L);
		num += smethod_243(Class185.smethod_0(-1141197866), text.Contains(Class185.smethod_0(-1141197916)) && text.Contains(Class185.smethod_0(-1141197940)) && text.Contains(Class185.smethod_0(-1141197960)) && text.Contains(Class185.smethod_0(-1141197976)) && text.Contains(Class185.smethod_0(-1141197990)) && text.Contains(Class185.smethod_0(-1141198009)) && text.Contains(Class185.smethod_0(-1141198027)));
		num += smethod_243(Class185.smethod_0(-1141198052), Class174.smethod_0(-1000L, 0L) && !Class174.smethod_0(0L, 999L) && Class174.smethod_0(0L, 1000L));
		num += smethod_243(Class185.smethod_0(-1141198107), Class38.smethod_0(class2.method_96(list, class95_, null, default(GStruct4), Class446.class446_0, 2, 0, null, new uint[0], new uint[1] { 11u }, null, default(Struct26)), Class185.smethod_0(-1141198801), dateTime) == null);
		Class401[] array = new Class401[2]
		{
			new Class401
			{
				uint_0 = 22u,
				string_0 = Class185.smethod_0(-1141198819),
				float_0 = 99f,
				long_0 = dateTime.Ticks,
				bool_0 = false
			},
			new Class401
			{
				uint_0 = 33u,
				string_0 = Class185.smethod_0(-1141306917),
				float_0 = 90f,
				long_0 = dateTime.Ticks,
				bool_0 = true
			}
		};
		Class31 class4 = Class38.smethod_8(@class, Class185.smethod_0(-1141198819), bool_0: false, array, dateTime);
		num += smethod_243(Class185.smethod_0(-1141198159), class4 != null && !class4.bool_0 && class4.uint_0 == 22 && class4.float_0 == 99f);
		class4 = Class38.smethod_8(@class, Class185.smethod_0(-1141198819), bool_0: false, new Class401[1]
		{
			new Class401
			{
				uint_0 = 9001u,
				string_0 = Class185.smethod_0(-1141198819),
				float_0 = 77f,
				byte_0 = 1,
				bool_1 = true,
				long_0 = dateTime.Ticks
			}
		}, dateTime);
		num += smethod_243(Class185.smethod_0(-1141198196), class4 != null && !class4.bool_0 && class4.uint_0 == 22 && class4.float_0 == 77f && class4.bool_1 && class4.byte_0 == 1);
		Class31 class5 = Class38.smethod_8(@class, null, bool_0: true, new Class401[1]
		{
			new Class401
			{
				uint_0 = 9002u,
				string_0 = Class185.smethod_0(-1141306917),
				float_0 = 88f,
				bool_0 = true,
				byte_0 = 1,
				bool_1 = true,
				long_0 = dateTime.Ticks
			}
		}, dateTime);
		num += smethod_243(Class185.smethod_0(-1141198255), class5 != null && !class5.bool_0 && class5.uint_0 == 33 && class5.float_0 == 88f && class5.byte_0 == 1);
		num += smethod_243(Class185.smethod_0(-1141198305), Class38.smethod_8(@class, Class185.smethod_0(-1141255883), bool_0: false, new Class401[1]
		{
			new Class401
			{
				uint_0 = 22u,
				string_0 = Class185.smethod_0(-1141255883),
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
		num += smethod_243(Class185.smethod_0(-1141195295), text2.Contains(Class185.smethod_0(-1141195350)) && text2.Contains(Class185.smethod_0(-1141195375)) && text2.Contains(Class185.smethod_0(-1141195392)) && text2.Contains(Class185.smethod_0(-1141195396)) && text2.Contains(Class185.smethod_0(-1141195426)));
		Class31 class6 = Class38.smethod_8(@class, null, bool_0: true, array, dateTime);
		num += smethod_243(Class185.smethod_0(-1141195463), class6 != null && !class6.bool_0 && class6.uint_0 == 33 && class6.float_0 == 90f);
		num += smethod_244(Class185.smethod_0(-1141195498), Class185.smethod_0(-1141306917), Class38.smethod_3(@class));
		Class31 class7 = Class38.smethod_8(@class, null, bool_0: true, new Class401[1]
		{
			new Class401
			{
				uint_0 = 9002u,
				string_0 = Class185.smethod_0(-1141306917),
				float_0 = 91f,
				bool_0 = false,
				long_0 = dateTime.Ticks
			}
		}, dateTime);
		num += smethod_243(Class185.smethod_0(-1141195551), class7 != null && !class7.bool_0 && class7.uint_0 == 33 && class7.float_0 == 91f);
		class4 = Class38.smethod_8(@class, Class185.smethod_0(-1141198819), bool_0: false, array, dateTime.AddSeconds(3.0));
		num += smethod_243(Class185.smethod_0(-1141195596), class4 != null && class4.bool_0 && class4.uint_0 == 22 && class4.float_0 == 7f);
		IReadOnlyList<string> readOnlyList = Class38.smethod_2(@class);
		num += smethod_243(Class185.smethod_0(-1141195656), readOnlyList.Count == 2 && readOnlyList[0] == Class185.smethod_0(-1141198819) && readOnlyList[1] == Class185.smethod_0(-1141306917));
		Class145 class145_ = Class145.class145_0.method_96(new List<Class403> { list[0] }, class95_, null, default(GStruct4), Class446.class446_0, 2, 0, null, new uint[3] { 11u, 22u, 33u }, new uint[1] { 11u }, null, default(Struct26));
		class4 = Class38.smethod_8(class145_, Class185.smethod_0(-1141198819), bool_0: false, array, dateTime);
		num += smethod_243(Class185.smethod_0(-1141195700), class4 != null && !class4.bool_0 && class4.uint_0 == 22 && class4.float_0 == 99f);
		Class31 class31_ = Class38.smethod_8(@class, Class185.smethod_0(-1141198819), bool_0: false, array, dateTime);
		num += smethod_243(Class185.smethod_0(-1141195749), Class38.smethod_5(@class, class31_, 100, out var class348_) && class348_.uint_0 == 22 && class348_.float_0 == 99f && class348_.float_1 == 0f && class348_.float_2 == 0f && class348_.int_0 == 100);
		num += smethod_243(Class185.smethod_0(-1141194774), !Class38.smethod_5(class145_, class4, 100, out class348_));
		num += smethod_243(Class185.smethod_0(-1141194823), !Class38.smethod_5(@class, class31_, -1, out class348_));
		Class390 class8 = new Class390();
		num += smethod_243(Class185.smethod_0(-1141194865), class8.method_0(class348_ = new Class348
		{
			uint_0 = 22u,
			float_0 = 7f,
			float_1 = 2f,
			float_2 = 3f,
			int_0 = 100
		}));
		num += smethod_243(Class185.smethod_0(-1141194913), !class8.method_0(class348_));
		num += smethod_243(Class185.smethod_0(-1141194976), class8.method_0(new Class348
		{
			uint_0 = 22u,
			float_0 = 8f,
			float_1 = 2f,
			float_2 = 3f,
			int_0 = 100
		}));
		num += smethod_243(Class185.smethod_0(-1141195009), class8.method_0(new Class348
		{
			uint_0 = 22u,
			float_0 = 8f,
			float_1 = 2f,
			float_2 = 3f,
			int_0 = 120
		}));
		num += smethod_243(Class185.smethod_0(-1141195052), class8.method_1() && !class8.method_1());
		class4 = Class38.smethod_8(class145_, Class185.smethod_0(-1141198819), bool_0: false, array, dateTime.AddSeconds(3.0));
		num += smethod_243(Class185.smethod_0(-1141195100), class4 == null);
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
		class4 = Class38.smethod_8(class145_2, Class185.smethod_0(-1141198819), bool_0: false, null, dateTime);
		num += smethod_243(Class185.smethod_0(-1141195149), Class38.smethod_7(class145_2, class4, 10f) == 88);
		Class31 class9 = Class38.smethod_8(class145_2, Class185.smethod_0(-1141198819), bool_0: false, new Class401[1]
		{
			new Class401
			{
				uint_0 = 9001u,
				string_0 = Class185.smethod_0(-1141198819),
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
		num += smethod_243(Class185.smethod_0(-1141195191), class9 != null && class9.uint_0 == 22 && Class38.smethod_7(class145_2, class9, 10f) == 88);
		class9.byte_0 = 0;
		num += smethod_243(Class185.smethod_0(-1141195241), Class38.smethod_7(class145_2, class9, 10f) == 0);
		num += smethod_243(Class185.smethod_0(-1141196321), Class38.smethod_7(class145_2, class4, 5f) == 0);
		num += smethod_243(Class185.smethod_0(-1141196362), Class38.smethod_6(new Class403
		{
			byte_0 = 2,
			uint_0 = 89u,
			float_0 = 8f,
			float_1 = 100f,
			float_2 = 3f
		}, class4, 2f));
		num += smethod_243(Class185.smethod_0(-1141196414), !Class38.smethod_6(new Class403
		{
			byte_0 = 2,
			uint_0 = 90u,
			float_0 = 25f,
			float_2 = 3f
		}, class4, 10f));
		num += smethod_243(Class185.smethod_0(-1141196459), Class38.smethod_7(class145_, Class38.smethod_8(class145_, Class185.smethod_0(-1141198819), bool_0: false, array, dateTime), 100f) == 0);
		num += smethod_243(Class185.smethod_0(-1141196520), Class38.smethod_7(class145_2, Class38.smethod_8(class145_2, Class185.smethod_0(-1141198819), bool_0: false, array, dateTime), 10f) == 0);
		Class145 class145_3 = Class145.class145_0.method_96(new List<Class403> { list[0] }, class95_, null, default(GStruct4), Class446.class446_0, 3, 0, null, new uint[0], new uint[1] { 11u }, null, default(Struct26));
		num += smethod_243(Class185.smethod_0(-1141196572), Class38.smethod_8(class145_3, Class185.smethod_0(-1141198819), bool_0: false, array, dateTime) == null);
		num += smethod_243(Class185.smethod_0(-1141196621), Class38.smethod_8(class145_, Class185.smethod_0(-1141198801), bool_0: false, new Class401[1]
		{
			new Class401
			{
				uint_0 = 11u,
				string_0 = Class185.smethod_0(-1141198801),
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
		num += smethod_243(Class185.smethod_0(-1141196671), !class10.method_0(class11, dateTime));
		class11.float_0 = 102f;
		class11.long_0 = 2L;
		num += smethod_243(Class185.smethod_0(-1141196717), class10.method_0(class11, dateTime.AddMilliseconds(100.0)));
		num += smethod_243(Class185.smethod_0(-1141196759), class10.method_0(class11, dateTime.AddMilliseconds(300.0)));
		num += smethod_243(Class185.smethod_0(-1141195778), !class10.method_0(class11, dateTime.AddMilliseconds(800.0)));
		class11.bool_1 = true;
		class11.byte_0 = 1;
		num += smethod_243(Class185.smethod_0(-1141195835), class10.method_0(class11, dateTime.AddMilliseconds(900.0)));
		class11.byte_0 = 0;
		num += smethod_243(Class185.smethod_0(-1141195884), !class10.method_0(class11, dateTime.AddMilliseconds(1000.0)));
		float float_;
		float float_2;
		float float_3;
		bool flag = Class38.smethod_1(130f, 5f, 0f, 100f, 7f, 0f, bool_0: true, 20f, 40f, out float_, out float_2, out float_3);
		num += smethod_243(Class185.smethod_0(-1141195938), flag && float_ < 120f && float_ > 100f && float_2 == 7f && Math.Abs(float_3) < 0.01f);
		num += smethod_243(Class185.smethod_0(-1141195985), !Class38.smethod_1(130f, 5f, 0f, 100f, 7f, 0f, bool_0: false, 20f, 40f, out float_, out float_2, out float_3));
		num += smethod_243(Class185.smethod_0(-1141196048), Class38.smethod_1(150f, 5f, 0f, 100f, 7f, 0f, bool_0: false, 20f, 40f, out float_, out float_2, out float_3) && float_ < 120f && float_ > 100f);
		num += smethod_243(Class185.smethod_0(-1141196112), Class38.smethod_1(150f, 5f, 0f, 100f, 7f, 0f, bool_0: false, 60f, 40f, out float_, out float_2, out float_3) && float_ < 140f && float_ > 100f);
		Class102 class12 = new Class102();
		IReadOnlyList<Class401> readOnlyList2 = class12.method_0(array, dateTime);
		num += smethod_243(Class185.smethod_0(-1141196161), class12.method_0(new Class401[0], dateTime.AddMilliseconds(300.0)).Count == readOnlyList2.Count);
		num += smethod_243(Class185.smethod_0(-1141196221), class12.method_0(new Class401[0], dateTime.AddSeconds(3.0)).Count == 0);
		num += smethod_243(Class185.smethod_0(-1141196270), Class38.smethod_1(10f, 0f, 0f, 0f, 0f, 0f, bool_0: true, 0f, 0f, out float_, out float_2, out float_3) && float_ >= 2f);
		num += smethod_243(Class185.smethod_0(-1141201434), Class38.smethod_1(0f, 0f, 0f, 0f, 0f, 0f, bool_0: false, 20f, 40f, out float_, out float_2, out float_3) && Math.Sqrt(float_ * float_ + float_3 * float_3) >= 2.0);
		num += smethod_243(Class185.smethod_0(-1141201484), Class38.smethod_1(1f, 0f, 0f, 0f, 0f, 0f, bool_0: false, 20f, 40f, out float_, out float_2, out float_3) && float_ >= 2f);
		string string_ = Class185.smethod_0(-1141201539) + Guid.NewGuid().ToString(Class185.smethod_0(-1141300407));
		Class64 class13 = new Class64(string_);
		try
		{
			Class64 class14 = new Class64(string_);
			try
			{
				class13.method_0(new Class401
				{
					uint_0 = 22u,
					string_0 = Class185.smethod_0(-1141198819),
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
				num += smethod_243(Class185.smethod_0(-1141201584), readOnlyList3.Count == 1 && readOnlyList3[0].uint_0 == 22 && readOnlyList3[0].float_0 == 24f && readOnlyList3[0].bool_1 && readOnlyList3[0].byte_0 == 1 && readOnlyList3[0].bool_2 && readOnlyList3[0].byte_1 == 2 && readOnlyList3[0].ushort_0 == 88);
				class13.method_2();
				num += smethod_243(Class185.smethod_0(-1141201638), class14.method_1(DateTime.UtcNow).Count == 0);
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
			smethod_94(class15, Class185.smethod_0(-1141259782), Class145.class145_0.method_93(new Class83
			{
				float_0 = 10f,
				float_1 = 5f,
				float_2 = 20f
			}, 1, 0));
			MethodInfo methodInfo = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
			num += smethod_243(Class185.smethod_0(-1141201680), methodInfo != null);
			if (methodInfo != null)
			{
				Class316 class17 = new Class316();
				((Task)methodInfo.Invoke(class15, null)).GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141201728), class16.list_0.Count == 3 && class16.list_0[0] == Class15.smethod_2() && class16.list_0[1] == Class346.smethod_0(12f, 5f, 20f, bool_0: false) && class16.list_0[2] == Class346.smethod_0(8f, 5f, 20f, bool_0: false));
				((Task)methodInfo.Invoke(class15, null)).GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141201772), class16.list_0.Count == 3);
				class15.method_127(88u);
				((Task)methodInfo.Invoke(class15, null)).GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141201835), class16.list_0.Count == 7 && class16.list_0[3] == Class15.smethod_0(88u) && class16.list_0[4] == Class15.smethod_2() && class16.list_0[5] == Class346.smethod_0(12f, 5f, 20f, bool_0: false) && class16.list_0[6] == Class346.smethod_0(8f, 5f, 20f, bool_0: false));
				class17.taskCompletionSource_0 = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
				class15.method_29(class17.method_0);
				class15.method_127(89u);
				class16.list_0.Clear();
				Task obj = (Task)methodInfo.Invoke(class15, null);
				class15.method_128(90u);
				class17.taskCompletionSource_0.SetResult(result: true);
				obj.GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141201882), class16.list_0.Count == 3 && class16.list_0[0] == Class15.smethod_2() && class16.list_0[1] == Class346.smethod_0(12f, 5f, 20f, bool_0: false) && class16.list_0[2] == Class15.smethod_1(90u));
				class15.method_29(Class299.class299_0.method_169);
				((Task)methodInfo.Invoke(class15, null)).GetAwaiter().GetResult();
				num += smethod_243(Class185.smethod_0(-1141200919), class16.list_0.Count == 6 && class16.list_0[3] == Class15.smethod_2() && class16.list_0[4] == Class346.smethod_0(12f, 5f, 20f, bool_0: false) && class16.list_0[5] == Class346.smethod_0(8f, 5f, 20f, bool_0: false));
			}
		}
		Console.WriteLine(Class185.smethod_0(-1141200961) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	internal static int smethod_298()
	{
		Class236 @class = new Class236();
		int num = 0;
		Class95 class95_ = new Class95(null, null, new Dictionary<string, string>
		{
			{
				Class185.smethod_0(-1141296467),
				Class185.smethod_0(-1141198801)
			},
			{
				Class185.smethod_0(-1141297402),
				Class185.smethod_0(-1141198819)
			},
			{
				Class185.smethod_0(-1141297437),
				Class185.smethod_0(-1141306917)
			},
			{
				Class185.smethod_0(-1141291508),
				Class185.smethod_0(-1141255883)
			},
			{
				Class185.smethod_0(-1141305630),
				Class185.smethod_0(-1141255922)
			}
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
		num = 0 + smethod_243(Class185.smethod_0(-1141200990), list.Count == 4 && list.Any(Class299.class299_0.method_170) && list.All(Class299.class299_0.method_171));
		List<Class381> list2 = Class46.smethod_0(@class.class145_0, bool_0: true);
		num += smethod_243(Class185.smethod_0(-1141201028), list2.Count == 4 && list2[0].string_0 == Class185.smethod_0(-1141306917) && list2.Any(Class299.class299_0.method_172) && list2.All(Class299.class299_0.method_173));
		Form4 form = new Form4(@class.method_0);
		try
		{
			form.method_3();
			TabControl tabControl = form.Controls.OfType<TabControl>().Single();
			num += smethod_243(Class185.smethod_0(-1141201067), tabControl.TabPages.Count == 2 && tabControl.TabPages[0].Text == Class185.smethod_0(-1141201110) && tabControl.TabPages[1].Text == Class185.smethod_0(-1141201128));
			num += smethod_243(Class185.smethod_0(-1141201140), form.method_4(2u, bool_0: false) && form.method_0() == Class185.smethod_0(-1141198819));
			num += smethod_243(Class185.smethod_0(-1141201188), !form.method_4(1u, bool_0: true));
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
			num += smethod_243(Class185.smethod_0(-1141201240), tabControl.TabPages[0].Controls.OfType<DataGridView>().Single().Rows.Count == 2 && !form.method_4(2u, bool_0: false));
		}
		finally
		{
			((IDisposable)form).Dispose();
		}
		Console.WriteLine(Class185.smethod_0(-1141201288) + num + Class185.smethod_0(-1141356690));
		return num;
	}

	internal static int smethod_299()
	{
		int num = 0;
		num = 0 + smethod_243(Class185.smethod_0(-1141201308), typeof(Class145).GetProperty(Class185.smethod_0(-1141201358)) != null);
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
		IReadOnlyDictionary<uint, GStruct0> readOnlyDictionary = Class119.smethod_34(JObject.Parse(Class185.smethod_0(-1141201384)), new uint[2] { 101u, 102u }, ilist_);
		num += smethod_243(Class185.smethod_0(-1141202544), readOnlyDictionary != null && readOnlyDictionary.Count == 2 && readOnlyDictionary.ContainsKey(101u) && readOnlyDictionary[101u].byte_0 == 2 && readOnlyDictionary[101u].ushort_0 == 777 && readOnlyDictionary.ContainsKey(102u) && readOnlyDictionary[102u].byte_0 == 0 && readOnlyDictionary[102u].ushort_0 == 0);
		num += smethod_243(Class185.smethod_0(-1141202588), readOnlyDictionary != null && !readOnlyDictionary.ContainsKey(103u) && !readOnlyDictionary.ContainsKey(104u));
		Class145 @class = Class145.class145_0.method_96(ilist_, Class95.class95_0, null, default(GStruct4), Class446.class446_0, 1, 0, null, new uint[2] { 101u, 102u }, null, readOnlyDictionary, default(Struct26));
		num += smethod_243(Class185.smethod_0(-1141202648), @class.method_20().ContainsKey(101u) && @class.method_93(null, 2, 0).method_20().ContainsKey(101u));
		num += smethod_244(Class185.smethod_0(-1141202708), 0, @class.method_95(ilist_, Class95.class95_0, null, default(GStruct4), 2, 0).method_20().Count);
		string text = Class119.smethod_61() ?? string.Empty;
		num += smethod_243(Class185.smethod_0(-1141202768), text.Contains(Class185.smethod_0(-1141202819)) && text.Contains(Class185.smethod_0(-1141202863)) && text.Contains(Class185.smethod_0(-1141202895)) && text.Contains(Class185.smethod_0(-1141202920)) && text.Contains(Class185.smethod_0(-1141201945)));
		Console.WriteLine(Class185.smethod_0(-1141201961) + num + Class185.smethod_0(-1141356690));
		return num;
	}
}
