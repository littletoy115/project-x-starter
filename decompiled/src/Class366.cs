using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

internal static class Class366
{
	private sealed class Class367
	{
		public GForm0 gform0_0;

		public int[] int_0;

		internal int method_0()
		{
			bool flag = false;
			int num = 0;
			while (true)
			{
				if (num < int_0.Length)
				{
					RadioButton radioButton = smethod_31<RadioButton>(gform0_0, "radioButton" + int_0[num], bool_0: false);
					if (radioButton != null)
					{
						flag = true;
						if (radioButton.Checked)
						{
							break;
						}
					}
					num++;
					continue;
				}
				if (!flag && int_0.Length != 0)
				{
					smethod_32("radioButton" + int_0[0]);
				}
				return -1;
			}
			return int_0[num];
		}
	}

	private sealed class Class368
	{
		public GForm0 gform0_0;

		public int int_0;

		internal string method_0()
		{
			return smethod_31<TextBox>(gform0_0, "textBox" + int_0, bool_0: true)?.Text;
		}
	}

	private sealed class Class369<T>
	{
		public GForm0 gform0_0;

		public EventHandler eventHandler_0;

		public TaskCompletionSource<T> taskCompletionSource_0;

		public Func<T> func_0;

		internal void method_0(object sender, EventArgs e)
		{
			gform0_0.Disposed -= eventHandler_0;
			taskCompletionSource_0.TrySetException(new ObjectDisposedException("Form1"));
		}

		internal void method_1()
		{
			try
			{
				if (gform0_0.IsDisposed || gform0_0.Disposing)
				{
					throw new ObjectDisposedException("Form1");
				}
				taskCompletionSource_0.TrySetResult(func_0());
			}
			catch (Exception exception)
			{
				taskCompletionSource_0.TrySetException(exception);
			}
			finally
			{
				gform0_0.Disposed -= eventHandler_0;
			}
		}
	}

	private sealed class Class370<T>
	{
		public GForm0 gform0_0;

		public string string_0;

		public Func<DataGridView, T> func_0;

		internal T method_0()
		{
			DataGridView dataGridView = smethod_31<DataGridView>(gform0_0, string_0, bool_0: true);
			if (dataGridView != null)
			{
				return func_0(dataGridView);
			}
			return default(T);
		}
	}

	private sealed class Class371
	{
		public int int_0;

		internal object method_0(DataGridView dataGridView_0)
		{
			Class440.smethod_11(dataGridView_0, int_0);
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct105 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<IReadOnlyList<int>> asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		private List<int> list_0;

		private int int_1;

		private TaskAwaiter<IReadOnlyList<Struct76>> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			IReadOnlyList<int> result2;
			try
			{
				if (num != 0)
				{
					list_0 = new List<int>();
					int_1 = 51;
					goto IL_004f;
				}
				TaskAwaiter<IReadOnlyList<Struct76>> awaiter = taskAwaiter_0;
				taskAwaiter_0 = default(TaskAwaiter<IReadOnlyList<Struct76>>);
				num = -1;
				int_0 = -1;
				goto IL_0096;
				IL_0096:
				IReadOnlyList<Struct76> result = awaiter.GetResult();
				if (result != null && result.Count != 0)
				{
					list_0.Add(int_1);
				}
				int_1++;
				goto IL_004f;
				IL_004f:
				if (int_1 <= 66)
				{
					awaiter = gform0_0.smethod_17(int_1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0096;
				}
				result2 = new ReadOnlyCollection<int>(list_0);
			}
			catch (Exception exception)
			{
				int_0 = -2;
				list_0 = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			list_0 = null;
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

	private sealed class Class372
	{
		public GForm0 gform0_0;

		public int int_0;

		internal int method_0()
		{
			return smethod_31<TrackBar>(gform0_0, "trackBar" + int_0, bool_0: true)?.Value ?? 0;
		}
	}

	private sealed class Class373
	{
		public GForm0 gform0_0;

		public int int_0;

		internal bool method_0()
		{
			return smethod_31<CheckBox>(gform0_0, "checkBox" + int_0, bool_0: true)?.Checked ?? false;
		}
	}

	private sealed class Class374
	{
		public GForm0 gform0_0;

		public int int_0;

		public string string_0;

		internal void method_0()
		{
			Label label = smethod_31<Label>(gform0_0, "label" + int_0, bool_0: true);
			if (label != null)
			{
				label.Text = string_0;
			}
		}
	}

	private sealed class Class375
	{
		public GForm0 gform0_0;

		public string string_0;

		internal string method_0()
		{
			return smethod_31<ComboBox>(gform0_0, string_0, bool_0: true)?.Text;
		}
	}

	[Serializable]
	private sealed class Class376
	{
		public static readonly Class376 class376_0 = new Class376();

		public static Func<DataGridView, IReadOnlyList<string>> func_0;

		public static Func<DataGridView, IReadOnlyList<string>> func_1;

		public static Func<DataGridView, IReadOnlyList<Struct76>> func_2;

		public static Func<DataGridView, IReadOnlyList<Struct76>> func_3;

		internal IReadOnlyList<string> method_0(DataGridView dataGridView_0)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dataGridView_0.Rows.Count; i++)
			{
				DataGridViewRow dataGridViewRow = dataGridView_0.Rows[i];
				if (dataGridViewRow.IsNewRow || dataGridViewRow.Cells.Count <= 0)
				{
					continue;
				}
				object value = dataGridViewRow.Cells[0].Value;
				if (value != null)
				{
					string text = value.ToString().Trim();
					if (text.Length != 0)
					{
						list.Add(text);
					}
				}
			}
			return new ReadOnlyCollection<string>(list);
		}

		internal IReadOnlyList<string> method_1(DataGridView dataGridView_0)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dataGridView_0.Rows.Count; i++)
			{
				DataGridViewRow dataGridViewRow = dataGridView_0.Rows[i];
				if (dataGridViewRow.IsNewRow || dataGridViewRow.Cells.Count == 0)
				{
					continue;
				}
				object value = dataGridViewRow.Cells[0].Value;
				if (value != null)
				{
					string text = value.ToString();
					if (text.Length != 0)
					{
						list.Add(text);
					}
				}
			}
			return list;
		}

		internal IReadOnlyList<Struct76> method_2(DataGridView dataGridView_0)
		{
			return smethod_20(Class440.smethod_10(dataGridView_0));
		}

		internal IReadOnlyList<Struct76> method_3(DataGridView dataGridView_0)
		{
			return smethod_20(Class440.smethod_16(dataGridView_0));
		}
	}

	private sealed class Class377
	{
		public Action action_0;

		internal object method_0()
		{
			action_0();
			return null;
		}
	}

	private sealed class Class378
	{
		public GForm0 gform0_0;

		public int int_0;

		internal float method_0()
		{
			NumericUpDown numericUpDown = smethod_31<NumericUpDown>(gform0_0, "numericUpDown" + int_0, bool_0: true);
			if (numericUpDown != null)
			{
				return (float)numericUpDown.Value;
			}
			return 0f;
		}
	}

	private sealed class Class379
	{
		public GForm0 gform0_0;

		public int int_0;

		internal bool method_0()
		{
			return smethod_31<RadioButton>(gform0_0, "radioButton" + int_0, bool_0: true)?.Checked ?? false;
		}
	}

	internal static Task<T> smethod_0<T>(this GForm0 gform0_0, Func<T> func_0)
	{
		Class369<T> @class = new Class369<T>();
		@class.gform0_0 = gform0_0;
		@class.func_0 = func_0;
		if (@class.gform0_0 == null)
		{
			return Task.FromException<T>(new ArgumentNullException("form"));
		}
		if (!@class.gform0_0.IsDisposed && !@class.gform0_0.Disposing)
		{
			if (!@class.gform0_0.IsHandleCreated)
			{
				return Task.FromException<T>(new InvalidOperationException("[FormAccess] form handle is not created"));
			}
			if (!@class.gform0_0.InvokeRequired)
			{
				try
				{
					if (@class.gform0_0.IsDisposed || @class.gform0_0.Disposing)
					{
						throw new ObjectDisposedException("Form1");
					}
					return Task.FromResult(@class.func_0());
				}
				catch (Exception exception)
				{
					return Task.FromException<T>(exception);
				}
			}
			@class.taskCompletionSource_0 = new TaskCompletionSource<T>(TaskCreationOptions.RunContinuationsAsynchronously);
			@class.eventHandler_0 = null;
			@class.eventHandler_0 = @class.method_0;
			@class.gform0_0.Disposed += @class.eventHandler_0;
			if (!@class.gform0_0.IsDisposed && !@class.gform0_0.Disposing)
			{
				try
				{
					@class.gform0_0.BeginInvoke(new MethodInvoker(@class.method_1));
				}
				catch (Exception ex)
				{
					@class.gform0_0.Disposed -= @class.eventHandler_0;
					@class.taskCompletionSource_0.TrySetException((ex is ObjectDisposedException || @class.gform0_0.IsDisposed || @class.gform0_0.Disposing) ? new ObjectDisposedException("Form1", ex) : ex);
				}
				return @class.taskCompletionSource_0.Task;
			}
			@class.gform0_0.Disposed -= @class.eventHandler_0;
			@class.taskCompletionSource_0.TrySetException(new ObjectDisposedException("Form1"));
			return @class.taskCompletionSource_0.Task;
		}
		return Task.FromException<T>(new ObjectDisposedException("Form1"));
	}

	internal static Task smethod_1(this GForm0 gform0_0, Action action_0)
	{
		Class377 @class = new Class377();
		@class.action_0 = action_0;
		return gform0_0.smethod_0(@class.method_0);
	}

	internal static Task<T> smethod_2<T>(this GForm0 gform0_0, string string_0, Func<DataGridView, T> func_0)
	{
		Class370<T> @class = new Class370<T>();
		@class.gform0_0 = gform0_0;
		@class.string_0 = string_0;
		@class.func_0 = func_0;
		return @class.gform0_0.smethod_0(@class.method_0);
	}

	internal static bool smethod_3(this GForm0 gform0_0)
	{
		bool? flag = gform0_0?.method_5().method_34();
		if (flag.HasValue)
		{
			return flag.Value;
		}
		return false;
	}

	internal static bool smethod_4(this GForm0 gform0_0)
	{
		if (gform0_0 == null)
		{
			return false;
		}
		IReadOnlyList<uint> readOnlyList = gform0_0.method_5().method_14();
		if (readOnlyList != null)
		{
			return readOnlyList.Count > 0;
		}
		return false;
	}

	internal static bool smethod_5(this GForm0 gform0_0)
	{
		bool? flag = gform0_0?.method_5().method_28();
		if (flag.HasValue)
		{
			return flag.Value;
		}
		return false;
	}

	internal static Task<bool> smethod_6(this GForm0 gform0_0, int int_0)
	{
		Class373 @class = new Class373();
		@class.gform0_0 = gform0_0;
		@class.int_0 = int_0;
		return @class.gform0_0.smethod_0(@class.method_0);
	}

	internal static Task<bool> smethod_7(this GForm0 gform0_0, int int_0)
	{
		Class379 @class = new Class379();
		@class.gform0_0 = gform0_0;
		@class.int_0 = int_0;
		return @class.gform0_0.smethod_0(@class.method_0);
	}

	internal static Task<string> smethod_8(this GForm0 gform0_0, int int_0)
	{
		Class368 @class = new Class368();
		@class.gform0_0 = gform0_0;
		@class.int_0 = int_0;
		return @class.gform0_0.smethod_0(@class.method_0);
	}

	internal static Task<string> smethod_9(this GForm0 gform0_0, string string_0)
	{
		Class375 @class = new Class375();
		@class.gform0_0 = gform0_0;
		@class.string_0 = string_0;
		return @class.gform0_0.smethod_0(@class.method_0);
	}

	internal static Task<int> smethod_10(this GForm0 gform0_0, int int_0)
	{
		Class372 @class = new Class372();
		@class.gform0_0 = gform0_0;
		@class.int_0 = int_0;
		return @class.gform0_0.smethod_0(@class.method_0);
	}

	internal static Task<float> smethod_11(this GForm0 gform0_0, int int_0)
	{
		Class378 @class = new Class378();
		@class.gform0_0 = gform0_0;
		@class.int_0 = int_0;
		return @class.gform0_0.smethod_0(@class.method_0);
	}

	internal static Task<int> smethod_12(this GForm0 gform0_0, int[] int_0)
	{
		Class367 @class = new Class367();
		@class.gform0_0 = gform0_0;
		@class.int_0 = int_0;
		return @class.gform0_0.smethod_0(@class.method_0);
	}

	internal static Task smethod_13(this GForm0 gform0_0, int int_0, string string_0)
	{
		Class374 @class = new Class374();
		@class.gform0_0 = gform0_0;
		@class.int_0 = int_0;
		@class.string_0 = string_0;
		return @class.gform0_0.smethod_1(@class.method_0);
	}

	internal static Task<IReadOnlyList<string>> smethod_14(this GForm0 gform0_0)
	{
		return gform0_0.smethod_2("dataGridView9", Class376.class376_0.method_0);
	}

	internal static Task<IReadOnlyList<string>> smethod_15(this GForm0 gform0_0)
	{
		return gform0_0.smethod_2("dataGridView3", Class376.class376_0.method_1);
	}

	internal static Task<IReadOnlyList<Struct76>> smethod_16(this GForm0 gform0_0)
	{
		return gform0_0.smethod_2("dataGridView1", Class376.class376_0.method_2);
	}

	internal static Task<IReadOnlyList<Struct76>> smethod_17(this GForm0 gform0_0, int int_0)
	{
		return gform0_0.smethod_2("dataGridView" + int_0, Class376.class376_0.method_3);
	}

	internal static async Task<IReadOnlyList<int>> smethod_18(this GForm0 gform0_0)
	{
		List<int> list = new List<int>();
		for (int i = 51; i <= 66; i++)
		{
			IReadOnlyList<Struct76> readOnlyList = await gform0_0.smethod_17(i);
			if (readOnlyList != null && readOnlyList.Count != 0)
			{
				list.Add(i);
			}
		}
		return new ReadOnlyCollection<int>(list);
	}

	internal static Task smethod_19(this GForm0 gform0_0, int int_0)
	{
		Class371 @class = new Class371();
		@class.int_0 = int_0;
		return gform0_0.smethod_2("dataGridView1", @class.method_0);
	}

	private static IReadOnlyList<Struct76> smethod_20(List<Struct76> list_0)
	{
		return new ReadOnlyCollection<Struct76>((list_0 == null) ? new List<Struct76>() : new List<Struct76>(list_0));
	}

	public static bool smethod_21(this GForm0 gform0_0, int int_0)
	{
		return smethod_31<CheckBox>(gform0_0, "checkBox" + int_0, bool_0: true)?.Checked ?? false;
	}

	public static string smethod_22(this GForm0 gform0_0, int int_0)
	{
		return smethod_31<TextBox>(gform0_0, "textBox" + int_0, bool_0: true)?.Text;
	}

	public static string smethod_23(this GForm0 gform0_0, string string_0)
	{
		return smethod_31<ComboBox>(gform0_0, string_0, bool_0: true)?.Text;
	}

	public static void smethod_24(this GForm0 gform0_0, int int_0, string string_0)
	{
		TextBox textBox = smethod_31<TextBox>(gform0_0, "textBox" + int_0, bool_0: true);
		if (textBox != null)
		{
			textBox.Text = string_0;
		}
	}

	public static void smethod_25(this GForm0 gform0_0, int int_0, string string_0)
	{
		Label label = smethod_31<Label>(gform0_0, "label" + int_0, bool_0: true);
		if (label != null)
		{
			label.Text = string_0;
		}
	}

	public static void smethod_26(this GForm0 gform0_0, int int_0, string string_0, Color color_0)
	{
		Label label = smethod_31<Label>(gform0_0, "label" + int_0, bool_0: true);
		if (label != null)
		{
			label.Text = string_0;
			label.ForeColor = color_0;
		}
	}

	public static void smethod_27(this GForm0 gform0_0, int int_0, string string_0, Color color_0)
	{
		Label label = smethod_31<Label>(gform0_0, "label" + int_0, bool_0: true);
		if (label != null)
		{
			label.Text = string_0;
			label.BackColor = color_0;
		}
	}

	public static int smethod_28(this GForm0 gform0_0, int int_0)
	{
		return smethod_31<TrackBar>(gform0_0, "trackBar" + int_0, bool_0: true)?.Value ?? 0;
	}

	public static int smethod_29(this GForm0 gform0_0, int[] int_0)
	{
		int num = 0;
		while (true)
		{
			if (num < int_0.Length)
			{
				RadioButton radioButton = smethod_31<RadioButton>(gform0_0, "radioButton" + int_0[num], bool_0: false);
				if (radioButton != null && radioButton.Checked)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return int_0[num];
	}

	public static DataGridView smethod_30(this GForm0 gform0_0, string string_0)
	{
		return smethod_31<DataGridView>(gform0_0, string_0, bool_0: true);
	}

	// Name -> control per form. The bot reads dozens of settings every loop tick, and each
	// Controls.Find(searchAllChildren) walked the whole form (well over a thousand controls).
	private static readonly ConditionalWeakTable<GForm0, ConcurrentDictionary<string, Control>> conditionalWeakTable_0 = new ConditionalWeakTable<GForm0, ConcurrentDictionary<string, Control>>();

	private static Control smethod_35(GForm0 gform0_0, string string_0)
	{
		ConcurrentDictionary<string, Control> orCreateValue = conditionalWeakTable_0.GetOrCreateValue(gform0_0);
		if (orCreateValue.TryGetValue(string_0, out var value) && !value.IsDisposed && value.Name == string_0)
		{
			return value;
		}
		Control control = Class80.smethod_0(gform0_0.Controls.Find(string_0, searchAllChildren: true));
		if (control != null)
		{
			orCreateValue[string_0] = control;
		}
		return control;
	}

	private static T smethod_31<T>(GForm0 gform0_0, string string_0, bool bool_0) where T : Control
	{
		T obj = smethod_35(gform0_0, string_0) as T;
		if (obj == null && bool_0)
		{
			smethod_32(string_0);
		}
		return obj;
	}

	private static void smethod_32(string string_0)
	{
	}

	internal static bool smethod_33(this GForm0 gform0_0, out float float_0, out float float_1)
	{
		float_0 = float.NaN;
		float_1 = float.NaN;
		if (gform0_0 == null)
		{
			return false;
		}
		Class83 @class = gform0_0.method_5().method_0();
		if (@class == null)
		{
			return false;
		}
		float_0 = @class.float_0;
		float_1 = @class.float_2;
		return true;
	}

	internal static bool smethod_34(this GForm0 gform0_0, bool bool_0, out float float_0, out float float_1, out string string_0)
	{
		float_0 = float.NaN;
		float_1 = float.NaN;
		string_0 = string.Empty;
		if (gform0_0 == null)
		{
			return false;
		}
		Class145 @class = gform0_0.method_5();
		string_0 = (bool_0 ? @class.method_71() : @class.method_65());
		Class83 class2 = @class.method_0();
		if (class2 == null)
		{
			return false;
		}
		float_0 = class2.float_0;
		float_1 = class2.float_2;
		return true;
	}
}
