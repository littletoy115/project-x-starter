using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

internal sealed class _0002_2001_200B
{
	private int m__000E;

	private int m__0003;

	internal static string _000E(int _000E)
	{
		return _0008_0017._000E(-1141036878) + _000E.ToString(CultureInfo.InvariantCulture);
	}

	internal static string _0003(int _000E)
	{
		return _0008_0017._000E(-1141036887) + _000E.ToString(CultureInfo.InvariantCulture);
	}

	internal int _000E()
	{
		return this.m__0003 - this.m__000E;
	}

	internal int _0003()
	{
		if (this.m__0003 - this.m__000E <= 0)
		{
			return 0;
		}
		return this.m__0003 - this.m__000E - 1;
	}

	internal _0008_2003_200B _000E(bool _000E, int _0003, int _0006)
	{
		int num;
		int num2;
		if (!_000E || _0003 <= 0)
		{
			num = (num2 = 0);
		}
		else
		{
			num = _0006 - 1;
			if (num < 0)
			{
				num = 0;
			}
			if (num > _0003)
			{
				num = _0003;
			}
			num2 = num + 24;
			if (num2 > _0003)
			{
				num2 = _0003;
			}
		}
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		List<int> list3 = new List<int>();
		List<int> list4 = new List<int>();
		for (int i = this.m__000E; i < this.m__0003; i++)
		{
			if (i < num || i >= num2)
			{
				list2.Add(i);
			}
		}
		for (int j = num; j < num2; j++)
		{
			if (j < this.m__000E || j >= this.m__0003)
			{
				list.Add(j);
			}
		}
		int num3 = ((num2 > num) ? (num2 - 1) : num);
		int num4 = ((this.m__0003 > this.m__000E) ? (this.m__0003 - 1) : this.m__000E);
		for (int k = this.m__000E; k < num4; k++)
		{
			if (k < num || k >= num3)
			{
				list4.Add(k);
			}
		}
		for (int l = num; l < num3; l++)
		{
			if (l < this.m__000E || l >= num4)
			{
				list3.Add(l);
			}
		}
		this.m__000E = num;
		this.m__0003 = num2;
		return new _0008_2003_200B
		{
			_000E = list.ToArray(),
			_0003 = list2.ToArray(),
			_0006 = list3.ToArray(),
			_000F = list4.ToArray()
		};
	}

	internal void _000E()
	{
		this.m__000E = (this.m__0003 = 0);
	}
}
internal sealed class _0002_2002_200B
{
	internal static readonly _0002_2002_200B _000E = new _0002_2002_200B(0L, _0003: false, _0006: false, _000F: false, _0002: false, _0008: false, _0005: false, null, 0);

	private readonly long m__0003;

	private readonly bool m__0006;

	private readonly bool m__000F;

	private readonly bool m__0002;

	private readonly bool m__0008;

	private readonly bool m__0005;

	private readonly bool m__000E_2008;

	private readonly Exception _0003_2008;

	private readonly int _0006_2008;

	private _0002_2002_200B(long _000E, bool _0003, bool _0006, bool _000F, bool _0002, bool _0008, bool _0005, Exception _000E_2008, int _0003_2008)
	{
		this.m__0003 = _000E;
		this.m__0006 = _0003;
		this.m__000F = _0006;
		this.m__0002 = _000F;
		this.m__0008 = _0002;
		this.m__0005 = _0008;
		this.m__000E_2008 = _0005;
		this._0003_2008 = _000E_2008;
		_0006_2008 = _0003_2008;
	}

	internal long _000E()
	{
		return this.m__0003;
	}

	internal bool _000E()
	{
		return this.m__0006;
	}

	internal bool _0003()
	{
		return this.m__000F;
	}

	internal bool _0006()
	{
		return this.m__0002;
	}

	internal bool _000F()
	{
		return this.m__0008;
	}

	internal bool _0002()
	{
		return this.m__0005;
	}

	internal bool _0008()
	{
		return this.m__000E_2008;
	}

	internal Exception _000E()
	{
		return _0003_2008;
	}

	internal int _000E()
	{
		return _0006_2008;
	}

	internal bool _0005()
	{
		if (!this._000E() && !_0003() && !_0006() && !_000F() && !_0002())
		{
			return !_0008();
		}
		return false;
	}

	internal bool _000E_2008()
	{
		if (_0008())
		{
			return this._000E() == (_0003_0017)1;
		}
		return false;
	}

	internal _0003_0017 _000E()
	{
		if (this._000E())
		{
			return (_0003_0017)4;
		}
		if (_0003() || _0006())
		{
			return (_0003_0017)3;
		}
		if (_000F() || _0002())
		{
			return (_0003_0017)2;
		}
		if (_0008())
		{
			return (_0003_0017)1;
		}
		return (_0003_0017)0;
	}

	internal static _0002_2002_200B _000E(long _000E)
	{
		return new _0002_2002_200B(_000E, _0003: true, _0006: false, _000F: false, _0002: false, _0008: false, _0005: false, null, 0);
	}

	internal static _0002_2002_200B _000E(long _000E, int _0003)
	{
		return new _0002_2002_200B(_000E, _0003: false, _0006: true, _000F: false, _0002: false, _0008: false, _0005: false, null, _0003);
	}

	internal static _0002_2002_200B _000E(long _000E, Exception _0003)
	{
		if (_0003 == null)
		{
			throw new ArgumentNullException(_0008_0017._000E(-1141035782));
		}
		return new _0002_2002_200B(_000E, _0003: false, _0006: false, _000F: true, _0002: false, _0008: false, _0005: false, _0003, 0);
	}

	internal static _0002_2002_200B _0003(long _000E)
	{
		return new _0002_2002_200B(_000E, _0003: false, _0006: false, _000F: false, _0002: true, _0008: false, _0005: false, null, 0);
	}

	internal static _0002_2002_200B _0006(long _000E)
	{
		return new _0002_2002_200B(_000E, _0003: false, _0006: false, _000F: false, _0002: false, _0008: true, _0005: false, null, 0);
	}

	internal static _0002_2002_200B _000F(long _000E)
	{
		return new _0002_2002_200B(_000E, _0003: false, _0006: false, _000F: false, _0002: false, _0008: false, _0005: true, null, 0);
	}

	internal _0002_2002_200B _000E(_0002_2002_200B _000E)
	{
		if (_000E == null || _000E._0005())
		{
			return this;
		}
		if (_0005())
		{
			return _000E;
		}
		if (this._000E() != _000E._000E())
		{
			throw new InvalidOperationException(_0008_0017._000E(-1141035785));
		}
		return new _0002_2002_200B(this._000E(), this._000E() || _000E._000E(), _0003() || _000E._0003(), _0006() || _000E._0006(), _000F() || _000E._000F(), _0002() || _000E._0002(), _0008() || _000E._0008(), this._000E() ?? _000E._000E(), _0003() ? this._000E() : _000E._000E());
	}
}
internal struct _0002_2003_200B
{
	public uint _000E;

	public long _0003;

	public int _0006;

	public float? _000F;

	public bool _0002;

	public bool _0008;

	public bool _0005;
}
internal sealed class _0002_2004_200B
{
	private readonly Form m__000E;

	private Point m__0003;

	internal _0002_2004_200B(Form _000E)
	{
		if (_000E == null)
		{
			throw new ArgumentNullException(_0008_0017._000E(-1141036201));
		}
		this.m__000E = _000E;
	}

	[DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
	private static extern bool _000E();

	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	private static extern IntPtr _000E(IntPtr _000E, int _0003, int _0006, int _000F);

	internal void _000E()
	{
		foreach (Control item in _0002_2004_200B._000E((Control)this.m__000E))
		{
			item.MouseDown += _000E;
			item.MouseMove += _0003;
		}
	}

	internal static bool _000E(Control _000E)
	{
		if (!(_000E is TextBox) && !(_000E is ComboBox) && !(_000E is TrackBar))
		{
			return _000E is RichTextBox;
		}
		return true;
	}

	internal static List<Control> _000E(Control _000E)
	{
		List<Control> list = new List<Control>();
		_0002_2004_200B._000E(_000E, list);
		return list;
	}

	private static void _000E(Control _000E, List<Control> _0003)
	{
		_0003.Add(_000E);
		foreach (Control control in _000E.Controls)
		{
			if (!_0002_2004_200B._000E(control))
			{
				_0002_2004_200B._000E(control, _0003);
			}
		}
	}

	internal static bool _000E(Point _000E, Point _0003)
	{
		if (Math.Abs(_0003.X - _000E.X) <= 5)
		{
			return Math.Abs(_0003.Y - _000E.Y) > 5;
		}
		return true;
	}

	private void _000E(object _000E, MouseEventArgs _0003)
	{
		if (_0003.Button == MouseButtons.Left)
		{
			this.m__0003 = _0003.Location;
		}
	}

	private void _0003(object _000E, MouseEventArgs _0003)
	{
		if (_0003.Button == MouseButtons.Left && _0002_2004_200B._000E(this.m__0003, _0003.Location))
		{
			_0002_2004_200B._000E();
			_0002_2004_200B._000E(this.m__000E.Handle, 161, 2, 0);
		}
	}
}
internal sealed class _0002_2006_200B : Form
{
	private sealed class _0003
	{
		public _0002_2006_200B _000E;

		public bool _0003;

		public string _0006;

		internal void _000E()
		{
			this._000E._000E(_0003);
			if (_0003)
			{
				this._000E.Close();
				return;
			}
			this._000E._000F.Visible = false;
			this._000E.m__0003.Visible = false;
			this._000E.m__000E.Text = _0008_0017._000E(-1141035854);
			this._000E.m__000E.ForeColor = Color.FromArgb(255, 140, 130);
			this._000E._0006.Height = this._000E._0006.Font.Height * 3 + 10;
			this._000E._0006.Text = (string.IsNullOrEmpty(_0006) ? _0008_0017._000E(-1141035893) : _0006);
			this._000E._0006.Visible = true;
			this._000E._0008.Location = new Point(165, this._000E._0006.Bottom + 12);
			this._000E.Size = new Size(420, this._000E._0008.Bottom + this._000E.Height - this._000E.ClientSize.Height + 14);
			this._000E._0008.Visible = true;
		}
	}

	private sealed class _000E
	{
		public _0002_2006_200B _000E;

		public int _0003;

		internal void _000E()
		{
			this._000E._0002._000E(_0003, _0003 + _0008_0017._000E(-1141277546));
		}
	}

	private readonly Label m__000E;

	private readonly Label m__0003;

	private readonly TextBox _0006;

	private readonly Label _000F;

	private readonly _0008_2004_200B _0002;

	private readonly Button _0008;

	private readonly string _0005;

	private readonly string _000E_2008;

	private bool _0003_2008;

	internal _0002_2006_200B(string _000E, string _0003)
	{
		_0005 = _000E;
		_000E_2008 = _0003;
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.StartPosition = FormStartPosition.CenterParent;
		base.ControlBox = false;
		base.ShowInTaskbar = false;
		base.Size = new Size(420, 210);
		Text = _0008_0017._000E(-1141035907);
		BackColor = Color.FromArgb(30, 30, 30);
		ForeColor = Color.Gainsboro;
		this.m__000E = new Label
		{
			Text = _0008_0017._000E(-1141035942),
			Location = new Point(0, 26),
			Size = new Size(420, 26),
			TextAlign = ContentAlignment.MiddleCenter,
			Font = new Font(_0008_0017._000E(-1141265716), 11f)
		};
		this.m__0003 = new Label
		{
			Text = _0008_0017._000E(-1141358114),
			Location = new Point(0, 54),
			Size = new Size(420, 22),
			TextAlign = ContentAlignment.MiddleCenter,
			ForeColor = Color.Gray,
			Font = new Font(_0008_0017._000E(-1141265716), 9f)
		};
		_0006 = new TextBox
		{
			Location = new Point(15, 115),
			Size = new Size(390, 58),
			Multiline = true,
			ReadOnly = true,
			WordWrap = true,
			ScrollBars = ScrollBars.Vertical,
			BorderStyle = BorderStyle.None,
			BackColor = Color.FromArgb(30, 30, 30),
			ForeColor = Color.Gainsboro,
			Font = new Font(_0008_0017._000E(-1141265716), 9f),
			Visible = false
		};
		_000F = new Label
		{
			Text = _0008_0017._000E(-1141035964),
			Location = new Point(0, 116),
			Size = new Size(420, 22),
			TextAlign = ContentAlignment.MiddleCenter,
			ForeColor = Color.Gray,
			Font = new Font(_0008_0017._000E(-1141265716), 8.5f)
		};
		_0008 = new Button
		{
			Text = _0008_0017._000E(-1141035021),
			Location = new Point(165, 142),
			Size = new Size(90, 26),
			Visible = false
		};
		_0008.Click += this._000E;
		base.Controls.Add(this.m__000E);
		base.Controls.Add(this.m__0003);
		base.Controls.Add(_0006);
		base.Controls.Add(_000F);
		base.Controls.Add(_0008);
		_0002 = _0008_2004_200B._000E(this, Color.FromArgb(255, 200, 120), Color.FromArgb(120, 200, 255), 60, 86, 300, 23, null, 0);
		base.Shown += this._0003;
	}

	internal bool _000E()
	{
		return _0003_2008;
	}

	private void _000E(bool _000E)
	{
		_0003_2008 = _000E;
	}

	private void _000E()
	{
		Thread thread = new Thread(_0003);
		thread.IsBackground = true;
		thread.Start();
	}

	private void _000E(long _000E, long _0003)
	{
		_000E obj = new _000E();
		obj._000E = this;
		if (base.IsDisposed || !base.IsHandleCreated)
		{
			return;
		}
		obj._0003 = (int)((_0003 > 0) ? (_000E * 100 / _0003) : 0);
		if (obj._0003 < 0)
		{
			obj._0003 = 0;
		}
		if (obj._0003 > 100)
		{
			obj._0003 = 100;
		}
		try
		{
			BeginInvoke(new Action(obj._000E));
		}
		catch (InvalidOperationException)
		{
		}
	}

	private void _000E(bool _000E, string _0003)
	{
		_0003 obj = new _0003();
		obj._000E = this;
		obj._0003 = _000E;
		obj._0006 = _0003;
		if (base.IsDisposed || !base.IsHandleCreated)
		{
			return;
		}
		try
		{
			BeginInvoke(new Action(obj._000E));
		}
		catch (InvalidOperationException)
		{
		}
	}

	private void _000E(object _000E, EventArgs _0003)
	{
		Close();
	}

	private void _0003(object _000E, EventArgs _0003)
	{
		this._000E();
	}

	private void _0003()
	{
		string text;
		bool flag = _000F_2003_200A._000E(_0005, _000E_2008, _000E, out text);
		_000E(flag, text);
	}
}
public static class _0002_2007_200B
{
	[StructLayout(LayoutKind.Auto)]
	private struct _0002 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder _0003;

		public _0006_2006 _0006;

		private int _000F;

		private TaskAwaiter _0002;

		private TaskAwaiter<bool> _0008;

		private void MoveNext()
		{
			int num = _000E;
			try
			{
				TaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				bool flag;
				_0006_0018 obj;
				switch (num)
				{
				default:
					_000F = 0;
					goto IL_009b;
				case 0:
					awaiter2 = _0002;
					_0002 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_0082;
				case 1:
					awaiter = _0008;
					_0008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0114;
				case 2:
					awaiter2 = _0002;
					_0002 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_018a;
				case 3:
					awaiter2 = _0002;
					_0002 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_01f2;
				case 4:
					{
						awaiter = _0008;
						_0008 = default(TaskAwaiter<bool>);
						num = (_000E = -1);
						goto IL_02d3;
					}
					IL_009b:
					flag = _000F < 5 && !_0006._0006();
					if (flag)
					{
						awaiter = _000E_2000_200A._000E(_0006, 42).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 1);
							_0008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0114;
					}
					goto IL_011c;
					IL_018a:
					awaiter2.GetResult();
					_000F = 0;
					goto IL_020b;
					IL_020b:
					flag = (_000F < 10 || (_0006._000E()._000E()?._0008_2007).GetValueOrDefault() <= 0 || _0006._000E()._000E() == true) && !_0006._0006();
					if (flag)
					{
						awaiter = _000E_2000_200A._000E(_0006, 42).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 4);
							_0008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02d3;
					}
					goto IL_02db;
					IL_0082:
					awaiter2.GetResult();
					_000F++;
					goto IL_009b;
					IL_01f2:
					awaiter2.GetResult();
					_000F++;
					goto IL_020b;
					IL_02d3:
					flag = awaiter.GetResult();
					goto IL_02db;
					IL_0114:
					flag = awaiter.GetResult();
					goto IL_011c;
					IL_011c:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 0);
							_0002 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0082;
					}
					obj = _0006._000E();
					awaiter2 = _000E(_0006, obj).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_000E = 2);
						_0002 = awaiter2;
						_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_018a;
					IL_02db:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 3);
							_0002 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_01f2;
					}
					break;
				}
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _0003 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder _0003;

		public _0006_0018 _0006;

		private TaskAwaiter _000F;

		private void MoveNext()
		{
			int num = _000E;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _000F;
					_000F = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_0071;
				}
				if (_0006 != null)
				{
					_000F_2000_200A._0006();
					awaiter = Task.Delay(1000).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 0);
						_000F = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0071;
				}
				goto end_IL_0007;
				IL_0071:
				awaiter.GetResult();
				_0006._0002();
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _0006 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		private TaskAwaiter _000F;

		private TaskAwaiter<bool> _0002;

		private int _0008;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				TaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				bool flag;
				switch (num)
				{
				default:
					awaiter2 = _0002_2007_200B._000E(_0006).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_000E = 0);
						_000F = awaiter2;
						_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_007a;
				case 0:
					awaiter2 = _000F;
					_000F = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_007a;
				case 1:
					awaiter = _0002;
					_0002 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_00dc;
				case 2:
					awaiter = _0002;
					_0002 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_013f;
				case 3:
					awaiter2 = _000F;
					_000F = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_01be;
				case 4:
					{
						awaiter = _0002;
						_0002 = default(TaskAwaiter<bool>);
						num = (_000E = -1);
						goto IL_024e;
					}
					IL_01d7:
					flag = _0008 < 10 && !_0006._0006();
					if (flag)
					{
						awaiter = _000E_2000_200A._000E(_0006, 42).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 4);
							_0002 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_024e;
					}
					goto IL_0256;
					IL_007a:
					awaiter2.GetResult();
					awaiter = _000E_2000_200A._000E(_0006, 45).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 1);
						_0002 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00dc;
					IL_01be:
					awaiter2.GetResult();
					_0008++;
					goto IL_01d7;
					IL_00dc:
					if (awaiter.GetResult())
					{
						awaiter = _000E_2008_200B._000E(_0006, 1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 2);
							_0002 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_013f;
					}
					goto IL_0147;
					IL_024e:
					flag = awaiter.GetResult();
					goto IL_0256;
					IL_0256:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 3);
							_000F = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_01be;
					}
					result = true;
					break;
					IL_013f:
					awaiter.GetResult();
					goto IL_0147;
					IL_0147:
					_0006._000E(_0006._000E());
					_0008 = 0;
					goto IL_01d7;
				}
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _000E : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		private int _000F;

		private int _0002;

		private TaskAwaiter _0008;

		private TaskAwaiter<bool> _0005;

		private TaskAwaiter<string> _000E_2008;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				TaskAwaiter<string> awaiter3;
				TaskAwaiter<bool> awaiter2;
				TaskAwaiter awaiter;
				bool flag;
				string result2;
				switch (num)
				{
				default:
					if (_0006 == null)
					{
						result = false;
					}
					else if ((_0006._000E()._000E()?._0008_2007).GetValueOrDefault() > 0)
					{
						result = false;
					}
					else
					{
						if (_000E_2000_200A._000E(_0006))
						{
							_0002 = 0;
							goto IL_0100;
						}
						result = false;
					}
					goto end_IL_0007;
				case 0:
					awaiter = _0008;
					_0008 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_00e7;
				case 1:
					awaiter2 = _0005;
					_0005 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_017c;
				case 2:
					awaiter3 = _000E_2008;
					_000E_2008 = default(TaskAwaiter<string>);
					num = (_000E = -1);
					goto IL_01ea;
				case 3:
					awaiter3 = _000E_2008;
					_000E_2008 = default(TaskAwaiter<string>);
					num = (_000E = -1);
					goto IL_0263;
				case 4:
					awaiter2 = _0005;
					_0005 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_02f0;
				case 5:
					awaiter2 = _0005;
					_0005 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_035c;
				case 6:
					{
						awaiter = _0008;
						_0008 = default(TaskAwaiter);
						num = (_000E = -1);
						break;
					}
					IL_0185:
					if (flag)
					{
						awaiter = Task.Delay(100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 0);
							_0008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00e7;
					}
					awaiter3 = _000E_2000_200A._000E(_0006, 24).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_000E = 2);
						_000E_2008 = awaiter3;
						_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_01ea;
					IL_0100:
					flag = _0002 < 70 && !_0006._0006();
					if (flag)
					{
						awaiter2 = _000E_2000_200A._000E(_0006, 42).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 1);
							_0005 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_017c;
					}
					goto IL_0185;
					IL_01ea:
					int.TryParse(awaiter3.GetResult(), out _000F);
					awaiter3 = _000E_2000_200A._000E(_0006, _0008_0017._000E(-1141280161)).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_000E = 3);
						_000E_2008 = awaiter3;
						_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0263;
					IL_035c:
					result = awaiter2.GetResult();
					goto end_IL_0007;
					IL_00e7:
					awaiter.GetResult();
					_0002++;
					goto IL_0100;
					IL_02f0:
					result = awaiter2.GetResult();
					goto end_IL_0007;
					IL_0263:
					result2 = awaiter3.GetResult();
					if (!(result2 == _0008_0017._000E(-1141280038)))
					{
						if (result2 == _0008_0017._000E(-1141280073))
						{
							awaiter2 = _000E(_0006, _000F).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_000E = 5);
								_0005 = awaiter2;
								_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_035c;
						}
						_000F_2000_200A._0006();
						_0006_0018 obj = _0006._000E();
						awaiter = _000E(_0006, obj).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 6);
							_0008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter2 = _0003(_0006).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_000E = 4);
						_0005 = awaiter2;
						_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_02f0;
					IL_017c:
					flag = awaiter2.GetResult();
					goto IL_0185;
				}
				awaiter.GetResult();
				result = false;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _000F : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		public int _000F;

		private TaskAwaiter _0002;

		private TaskAwaiter<bool> _0008;

		private TaskAwaiter<_0008_0018> _0005;

		private int _000E_2008;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				TaskAwaiter<_0008_0018> awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				bool flag;
				switch (num)
				{
				default:
					awaiter2 = _0002_2007_200B._000E(_0006).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_000E = 0);
						_0002 = awaiter2;
						_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0082;
				case 0:
					awaiter2 = _0002;
					_0002 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_0082;
				case 1:
					awaiter = _0008;
					_0008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_00e4;
				case 2:
					awaiter = _0008;
					_0008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_014a;
				case 3:
					awaiter2 = _0002;
					_0002 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_01aa;
				case 4:
					awaiter3 = _0005;
					_0005 = default(TaskAwaiter<_0008_0018>);
					num = (_000E = -1);
					goto IL_0221;
				case 5:
					awaiter2 = _0002;
					_0002 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_028a;
				case 6:
					{
						awaiter = _0008;
						_0008 = default(TaskAwaiter<bool>);
						num = (_000E = -1);
						goto IL_036b;
					}
					IL_0373:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 5);
							_0002 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_028a;
					}
					result = true;
					break;
					IL_0082:
					awaiter2.GetResult();
					awaiter = _000E_2000_200A._000E(_0006, 45).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 1);
						_0008 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00e4;
					IL_0221:
					awaiter3.GetResult();
					_000E_2008 = 0;
					goto IL_02a3;
					IL_00e4:
					if (awaiter.GetResult())
					{
						awaiter = _000E_2008_200B._000E(_0006, 1).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 2);
							_0008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_014a;
					}
					goto IL_01b1;
					IL_02a3:
					flag = (_000E_2008 < 10 || (_0006._000E()._000E()?._0008_2007).GetValueOrDefault() <= 0 || _0006._000E()._000E() == true) && !_0006._0006();
					if (flag)
					{
						awaiter = _000E_2000_200A._000E(_0006, 42).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 6);
							_0008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_036b;
					}
					goto IL_0373;
					IL_036b:
					flag = awaiter.GetResult();
					goto IL_0373;
					IL_014a:
					awaiter.GetResult();
					awaiter2 = Task.Delay(500).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_000E = 3);
						_0002 = awaiter2;
						_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_01aa;
					IL_028a:
					awaiter2.GetResult();
					_000E_2008++;
					goto IL_02a3;
					IL_01aa:
					awaiter2.GetResult();
					goto IL_01b1;
					IL_01b1:
					awaiter3 = _0006_200A_200A._0003(_0006, _000F, 200, 10.0).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_000E = 4);
						_0005 = awaiter3;
						_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0221;
				}
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	public static async Task<bool> _000E(_0006_2006 _000E)
	{
		if (_000E == null)
		{
			return false;
		}
		if ((_000E._000E()._000E()?._0008_2007).GetValueOrDefault() > 0)
		{
			return false;
		}
		if (!_000E_2000_200A._000E(_000E))
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			bool flag = num < 70 && !_000E._0006();
			if (flag)
			{
				flag = await _000E_2000_200A._000E(_000E, 42);
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(100);
			num++;
		}
		int.TryParse(await _000E_2000_200A._000E(_000E, 24), out var result);
		string text = await _000E_2000_200A._000E(_000E, _0008_0017._000E(-1141280161));
		if (!(text == _0008_0017._000E(-1141280038)))
		{
			if (text == _0008_0017._000E(-1141280073))
			{
				return await _0002_2007_200B._000E(_000E, result);
			}
			_000F_2000_200A._0006();
			_0006_0018 obj = _000E._000E();
			await _0002_2007_200B._000E(_000E, obj);
			return false;
		}
		return await _0003(_000E);
	}

	public static async Task<bool> _0003(_0006_2006 _000E)
	{
		await _0002_2007_200B._000E(_000E);
		if (await _000E_2000_200A._000E(_000E, 45))
		{
			await _000E_2008_200B._000E(_000E, 1);
		}
		_000E._000E(_000E._000E());
		int num = 0;
		while (true)
		{
			bool flag = num < 10 && !_000E._0006();
			if (flag)
			{
				flag = await _000E_2000_200A._000E(_000E, 42);
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
		return true;
	}

	public static async Task<bool> _000E(_0006_2006 _000E, int _0003)
	{
		await _0002_2007_200B._000E(_000E);
		if (await _000E_2000_200A._000E(_000E, 45))
		{
			await _000E_2008_200B._000E(_000E, 1);
			await Task.Delay(500);
		}
		await _0006_200A_200A._0003(_000E, _0003, 200, 10.0);
		int num = 0;
		while (true)
		{
			bool flag = (num < 10 || (_000E._000E()._000E()?._0008_2007).GetValueOrDefault() <= 0 || _000E._000E()._000E() == true) && !_000E._0006();
			if (flag)
			{
				flag = await _000E_2000_200A._000E(_000E, 42);
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
		return true;
	}

	private static async Task _000E(_0006_2006 _000E)
	{
		int num = 0;
		while (true)
		{
			bool flag = num < 5 && !_000E._0006();
			if (flag)
			{
				flag = await _000E_2000_200A._000E(_000E, 42);
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
		_0006_0018 obj = _000E._000E();
		await _0002_2007_200B._000E(_000E, obj);
		num = 0;
		while (true)
		{
			bool flag = (num < 10 || (_000E._000E()._000E()?._0008_2007).GetValueOrDefault() <= 0 || _000E._000E()._000E() == true) && !_000E._0006();
			if (flag)
			{
				flag = await _000E_2000_200A._000E(_000E, 42);
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
	}

	private static async Task _000E(_0006_2006 _000E, _0006_0018 _0003)
	{
		if (_0003 != null)
		{
			_000F_2000_200A._0006();
			await Task.Delay(1000);
			_0003._0002();
		}
	}
}
internal sealed class _0002_2008_200B
{
	internal uint _000E;

	internal string _0003;

	internal float _0006;

	internal float _000F;

	internal float _0002;

	internal bool _0008;

	internal long _0005;

	internal byte _000E_2008;

	internal bool _0003_2008;

	internal byte _0006_2008;

	internal ushort _000F_2008;

	internal bool _0002_2008;
}
internal sealed class _0002_2009_200B
{
	public IntPtr _000E;

	public string _0003;

	public int _0006;

	public int _000F;

	public string _0002;

	public int _0008;

	public bool _0005;

	public override string ToString()
	{
		return _0003;
	}
}
internal static class _0002_200B_200B
{
	internal static _0008_200B_200B _000E(_0002_0017 _000E)
	{
		return _000E switch
		{
			_0002_0017.Attached => new _0008_200B_200B
			{
				_000E = false,
				_0003 = true,
				_0006 = false,
				_000F = false
			}, 
			_0002_0017.Selected => new _0008_200B_200B
			{
				_000E = false,
				_0003 = false,
				_0006 = true,
				_000F = false
			}, 
			_0002_0017.Started => new _0008_200B_200B
			{
				_000E = false,
				_0003 = false,
				_0006 = false,
				_000F = true
			}, 
			_ => new _0008_200B_200B
			{
				_000E = true,
				_0003 = true,
				_0006 = false,
				_000F = false
			}, 
		};
	}
}
internal static class _0003_2001_200B
{
	private sealed class _0003
	{
		public uint _000E;

		internal bool _000E(_000E_2008_200A _000E)
		{
			return _000E._000E_2008 == this._000E;
		}
	}

	[Serializable]
	private sealed class _000E
	{
		public static readonly _000E _000E = new _000E();

		public static Func<_000E_2001_200B, bool> _0003;

		internal bool _000E(_000E_2001_200B _000E)
		{
			return _000E._000F;
		}
	}

	internal static List<_000E_2001_200B> _000E(_0006_2004_200A _000E, bool _0003)
	{
		List<_000E_2001_200B> list = new List<_000E_2001_200B>();
		if (_000E == null)
		{
			return list;
		}
		if (!_0003)
		{
			foreach (_000E_2008_200A item in _000E._0003())
			{
				string text = _0003_2001_200B._000E(_000E, item._000E_2008);
				if (!string.IsNullOrWhiteSpace(text))
				{
					list.Add(new _000E_2001_200B
					{
						_000E = item._000E_2008,
						_0003 = text,
						_0006 = item._0006(),
						_000F = item._000F(),
						_0002 = true
					});
				}
			}
			return list;
		}
		if (_000E._000E() == null)
		{
			return list;
		}
		using (IEnumerator<uint> enumerator2 = _000E._000E().GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				_0003 obj = new _0003();
				obj._000E = enumerator2.Current;
				string text2 = _0003_2001_200B._000E(_000E, obj._000E);
				if (!string.IsNullOrWhiteSpace(text2))
				{
					_000E_2008_200A obj2 = _000E._0003().FirstOrDefault(obj._000E);
					list.Add(new _000E_2001_200B
					{
						_000E = obj._000E,
						_0003 = text2,
						_0006 = (obj2?._0006() ?? false),
						_000F = (obj2?._000F() ?? false),
						_0002 = (obj2 != null)
					});
				}
			}
		}
		return list.OrderByDescending(_0003_2001_200B._000E._000E._000E).ToList();
	}

	private static string _000E(_0006_2004_200A _000E, uint _0003)
	{
		if (!_000E._000E()._0006().TryGetValue(_0003.ToString(CultureInfo.InvariantCulture), out var value))
		{
			return null;
		}
		return value;
	}
}
internal sealed class _0003_2002_200B
{
	private readonly bool[] m__000E;

	internal _0003_2002_200B(IReadOnlyList<_0005_200B_200A> _000E)
	{
		this.m__000E = new bool[11];
		if (_000E == null)
		{
			return;
		}
		for (int i = 0; i < _000E.Count; i++)
		{
			_0005_200B_200A obj = _000E[i];
			if (obj._0006 && obj._000E >= 1 && obj._000E <= 10)
			{
				this.m__000E[obj._000E] = true;
			}
		}
	}

	internal bool _000E(int _000E)
	{
		if (_000E >= 1 && _000E < this.m__000E.Length)
		{
			return this.m__000E[_000E];
		}
		return false;
	}
}
internal struct _0003_2003_200B
{
	public bool _000E;

	public float _0003;

	public int _0006;
}
internal static class _0003_2004_200B
{
	private sealed class _000E : IDisposable
	{
		public void Dispose()
		{
		}
	}

	internal static List<string> _000E(DataGridView _000E)
	{
		List<string> list = new List<string>();
		if (_000E == null)
		{
			return list;
		}
		List<int> list2 = new List<int>();
		foreach (DataGridViewCell selectedCell in _000E.SelectedCells)
		{
			int rowIndex = selectedCell.RowIndex;
			if (rowIndex >= 0 && !list2.Contains(rowIndex))
			{
				list2.Add(rowIndex);
			}
		}
		if (list2.Count == 0 && _000E.CurrentCell != null)
		{
			int rowIndex2 = _000E.CurrentCell.RowIndex;
			if (rowIndex2 >= 0)
			{
				list2.Add(rowIndex2);
			}
		}
		if (list2.Count == 0)
		{
			return list;
		}
		list2.Sort();
		DataGridViewRowCollection rows = _000E.Rows;
		for (int i = 0; i < list2.Count; i++)
		{
			int num = list2[i];
			if (num < rows.Count)
			{
				string text = _0005_2007_200B._000E(rows[num]);
				if (text.Length != 0 && !_0003_2004_200B._000E(list, text))
				{
					list.Add(text);
				}
			}
		}
		return list;
	}

	internal static int _000E(DataGridView _000E, List<string> _0003, _0003_2009_200A _0006)
	{
		if (_000E == null || _0003 == null || _0003.Count == 0)
		{
			return 0;
		}
		int num = 0;
		using (_0003_2004_200B._000E(_0006, _000E))
		{
			for (int i = 0; i < _0003.Count; i++)
			{
				string text = _0003[i];
				if (text != null)
				{
					text = text.Trim();
					if (text.Length != 0 && !_0005_2007_200B._000E(_000E, text))
					{
						_000E.Rows.Add(text);
						num++;
					}
				}
			}
			return num;
		}
	}

	internal static int _0003(DataGridView _000E, List<string> _0003, _0003_2009_200A _0006)
	{
		if (_000E == null || _0003 == null || _0003.Count == 0)
		{
			return 0;
		}
		int num = 0;
		using (_0003_2004_200B._000E(_0006, _000E))
		{
			for (int i = 0; i < _0003.Count; i++)
			{
				for (int num2 = _0005_2007_200B._000E(_000E, _0003[i]); num2 >= 0; num2 = _0005_2007_200B._000E(_000E, _0003[i]))
				{
					_000E.Rows.RemoveAt(num2);
					num++;
				}
			}
			return num;
		}
	}

	internal static bool _000E(DataGridView _000E, string _0003, _0003_2009_200A _0006)
	{
		if (_000E == null || _0003 == null)
		{
			return false;
		}
		_0003 = _0003.Trim();
		if (_0003.Length == 0)
		{
			return false;
		}
		using (_0003_2004_200B._000E(_0006, _000E))
		{
			int num = _0005_2007_200B._000E(_000E, _0003);
			if (num >= 0)
			{
				_000E.Rows.RemoveAt(num);
				return false;
			}
			_000E.Rows.Add(_0003);
			return true;
		}
	}

	private static bool _000E(List<string> _000E, string _0003)
	{
		for (int i = 0; i < _000E.Count; i++)
		{
			if (_0005_2007_200B._000E(_000E[i], _0003))
			{
				return true;
			}
		}
		return false;
	}

	private static IDisposable _000E(_0003_2009_200A _000E, DataGridView _0003)
	{
		if (_000E != null)
		{
			return _000E._000E(_0003);
		}
		return new _000E();
	}
}
internal static class _0003_2006_200B
{
	internal static _000F_0017 _000E(_0006_2006_200B _000E, _000F_2006_200B _0003, _0002_0017 _0006, bool _000F)
	{
		if (!_000F)
		{
			return (_000F_0017)0;
		}
		if (_0006 != _0002_0017.Selected && _0006 != _0002_0017.Started)
		{
			if (!_0003._000E)
			{
				return (_000F_0017)0;
			}
			return (_000F_0017)2;
		}
		if (!_000E._000E)
		{
			if (!_0003._000E)
			{
				return (_000F_0017)0;
			}
			return (_000F_0017)2;
		}
		if (!_0003._000E)
		{
			return (_000F_0017)1;
		}
		return (_000F_0017)0;
	}
}
internal sealed class _0003_2007_200B : IDisposable
{
	private readonly MemoryMappedFile m__000E;

	private readonly MemoryMappedViewAccessor _0003;

	private readonly Mutex _0006;

	private readonly int _000F = Process.GetCurrentProcess().Id;

	private int _0002 = -1;

	private bool _0008;

	internal _0003_2007_200B()
		: this(_0003_2007_200B._000E())
	{
	}

	internal _0003_2007_200B(string _000E)
	{
		this.m__000E = MemoryMappedFile.CreateOrOpen(_000E, 4096L, MemoryMappedFileAccess.ReadWrite);
		_0003 = this.m__000E.CreateViewAccessor(0L, 4096L, MemoryMappedFileAccess.ReadWrite);
		_0006 = new Mutex(initiallyOwned: false, _000E + _0008_0017._000E(-1141035550));
	}

	internal static string _000E()
	{
		return _0008_0017._000E(-1141035554) + _0006_2002._0002().Replace(_0008_0017._000E(-1141293701), string.Empty) + _0008_0017._000E(-1141035575);
	}

	internal bool _000E(_000E_2007_200B _000E)
	{
		if (_0008 || _000E == null || _000E._000E == 0 || string.IsNullOrWhiteSpace(_000E._0003))
		{
			return false;
		}
		if (!this._000E())
		{
			return false;
		}
		try
		{
			if (_0002 < 0 || _0003.ReadInt32(_0002 * 128) != _000F)
			{
				_0002 = this._000E(DateTime.UtcNow.Ticks);
			}
			if (_0002 < 0)
			{
				return false;
			}
			int num = _0002 * 128;
			byte[] bytes = Encoding.UTF8.GetBytes(_000E._0003);
			int num2 = Math.Min(bytes.Length, 80);
			while (num2 > 0 && num2 < bytes.Length && (bytes[num2] & 0xC0) == 128)
			{
				num2--;
			}
			_0003.Write(num + 4, _000E._000E);
			_0003.Write(num + 8, _000E._0006 ? 1 : 0);
			_0003.Write(num + 12, _000E._000F);
			_0003.Write(num + 16, _000E._0002);
			_0003.Write(num + 20, _000E._0008);
			_0003.Write(num + 24, _000E._0005);
			_0003.Write(num + 32, num2);
			_0003.WriteArray(num + 36, bytes, 0, num2);
			_0003.Write(num + 116, _000E._000E_2008);
			_0003.Write(num + 117, _000E._0003_2008 ? ((byte)1) : ((byte)0));
			_0003.Write(num + 118, _000E._0006_2008);
			_0003.Write(num + 119, _000E._0002_2008 ? ((byte)1) : ((byte)0));
			_0003.Write(num + 120, _000E._000F_2008);
			_0003.Write(num, _000F);
			return true;
		}
		finally
		{
			_0006.ReleaseMutex();
		}
	}

	internal IReadOnlyList<_000E_2007_200B> _000E(DateTime _000E)
	{
		List<_000E_2007_200B> list = new List<_000E_2007_200B>();
		if (_0008 || !this._000E())
		{
			return list;
		}
		try
		{
			for (int i = 0; i < 32; i++)
			{
				int num = i * 128;
				if (_0003.ReadInt32(num) == 0)
				{
					continue;
				}
				long num2 = _0003.ReadInt64(num + 24);
				long num3 = _000E.Ticks - num2;
				if (num2 > 0 && num3 >= 0 && num3 <= TimeSpan.FromSeconds(2.0).Ticks)
				{
					int num4 = _0003.ReadInt32(num + 32);
					if (num4 > 0 && num4 <= 80)
					{
						byte[] array = new byte[num4];
						_0003.ReadArray(num + 36, array, 0, num4);
						list.Add(new _000E_2007_200B
						{
							_000E = _0003.ReadUInt32(num + 4),
							_0006 = (_0003.ReadInt32(num + 8) != 0),
							_000F = _0003.ReadSingle(num + 12),
							_0002 = _0003.ReadSingle(num + 16),
							_0008 = _0003.ReadSingle(num + 20),
							_0005 = num2,
							_000E_2008 = _0003.ReadByte(num + 116),
							_0003_2008 = (_0003.ReadByte(num + 117) != 0),
							_0006_2008 = _0003.ReadByte(num + 118),
							_0002_2008 = (_0003.ReadByte(num + 119) != 0),
							_000F_2008 = _0003.ReadUInt16(num + 120),
							_0003 = Encoding.UTF8.GetString(array)
						});
					}
				}
			}
			return list;
		}
		finally
		{
			_0006.ReleaseMutex();
		}
	}

	internal void _000E()
	{
		if (_0008 || _0002 < 0 || !_000E())
		{
			return;
		}
		try
		{
			if (_0003.ReadInt32(_0002 * 128) == _000F)
			{
				_0003.Write(_0002 * 128, 0);
				_0003.Write(_0002 * 128 + 24, 0L);
			}
			_0002 = -1;
		}
		finally
		{
			_0006.ReleaseMutex();
		}
	}

	private int _000E(long _000E)
	{
		int num = -1;
		for (int i = 0; i < 32; i++)
		{
			int num2 = i * 128;
			int num3 = _0003.ReadInt32(num2);
			if (num3 == _000F)
			{
				return i;
			}
			long num4 = _0003.ReadInt64(num2 + 24);
			if (num < 0 && (num3 == 0 || num4 <= 0 || _000E - num4 > TimeSpan.FromSeconds(5.0).Ticks))
			{
				num = i;
			}
		}
		return num;
	}

	private bool _000E()
	{
		try
		{
			return _0006.WaitOne(0);
		}
		catch (AbandonedMutexException)
		{
			return true;
		}
	}

	public void Dispose()
	{
		if (!_0008)
		{
			this._000E();
			_0008 = true;
			_0003.Dispose();
			this.m__000E.Dispose();
			_0006.Dispose();
		}
	}
}
internal static class _0003_2008_200B
{
	[StructLayout(LayoutKind.Auto)]
	private struct _0002 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public IReadOnlyList<uint> _0006;

		public _0006_2006 _000F;

		private int _0002;

		private uint _0008;

		private TaskAwaiter<bool> _0005;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					if (num != 1)
					{
						if (_0006 != null)
						{
							_0002 = 0;
							goto IL_0123;
						}
						goto IL_0139;
					}
					awaiter = _0005;
					_0005 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0106;
				}
				awaiter = _0005;
				_0005 = default(TaskAwaiter<bool>);
				num = (_000E = -1);
				goto IL_009e;
				IL_0139:
				_000F_2000_200A._0003();
				result = false;
				goto end_IL_0007;
				IL_0123:
				if (_0002 < _0006.Count)
				{
					_0008 = _0006[_0002];
					awaiter = _0003_2008_200B._000E(_000F, _0008).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 0);
						_0005 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_009e;
				}
				goto IL_0139;
				IL_0113:
				_0002++;
				goto IL_0123;
				IL_009e:
				if (awaiter.GetResult())
				{
					awaiter = _000F_2000_200A._000E(_000F, _0008).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 1);
						_0005 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0106;
				}
				goto IL_0113;
				IL_0106:
				if (!awaiter.GetResult())
				{
					goto IL_0113;
				}
				result = true;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _0003 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		public float _000F;

		public float _0002;

		public float _0008;

		public float _0005;

		private List<uint> _000E_2008;

		private TaskAwaiter<List<uint>> _0003_2008;

		private int _0006_2008;

		private uint _000F_2008;

		private TaskAwaiter<bool> _0002_2008;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				TaskAwaiter<List<uint>> awaiter2;
				TaskAwaiter<bool> awaiter;
				List<uint> result2;
				switch (num)
				{
				default:
					awaiter2 = _000F_200A_200A._000E(_0006).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_000E = 0);
						_0003_2008 = awaiter2;
						_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0072;
				case 0:
					awaiter2 = _0003_2008;
					_0003_2008 = default(TaskAwaiter<List<uint>>);
					num = (_000E = -1);
					goto IL_0072;
				case 1:
					awaiter = _0002_2008;
					_0002_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0105;
				case 2:
					{
						awaiter = _0002_2008;
						_0002_2008 = default(TaskAwaiter<bool>);
						num = (_000E = -1);
						goto IL_019b;
					}
					IL_019b:
					if (awaiter.GetResult())
					{
						result = true;
						break;
					}
					goto IL_01a8;
					IL_0072:
					result2 = awaiter2.GetResult();
					_000E_2008 = result2;
					_0006_2008 = 0;
					goto IL_01ba;
					IL_01ba:
					if (_0006_2008 < _000E_2008.Count)
					{
						_000F_2008 = _000E_2008[_0006_2008];
						awaiter = _0003_2008_200B._000E(_0006, _000F_2008).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 1);
							_0002_2008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0105;
					}
					_000F_2000_200A._0003();
					result = false;
					break;
					IL_0105:
					if (awaiter.GetResult() && _000E(_0006, _000F_2008, _000F, _0002, _0008, _0005))
					{
						awaiter = _000F_2000_200A._000E(_0006, _000F_2008).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 2);
							_0002_2008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_019b;
					}
					goto IL_01a8;
					IL_01a8:
					_0006_2008++;
					goto IL_01ba;
				}
			}
			catch (Exception exception)
			{
				_000E = -2;
				_000E_2008 = null;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_000E_2008 = null;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _0006 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		public float _000F;

		public IReadOnlyList<uint> _0002;

		private bool _0008;

		private float _0005;

		private float _000E_2008;

		private float _0003_2008;

		private bool _0006_2008;

		private TaskAwaiter<bool> _000F_2008;

		private TaskAwaiter<string> _0002_2008;

		private TaskAwaiter _0008_2008;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _0005_2008;

		private int _000E_2007;

		private uint _0003_2007;

		private void MoveNext()
		{
			int num = _000E;
			bool result2;
			try
			{
				TaskAwaiter<string> awaiter4;
				TaskAwaiter awaiter3;
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				bool result;
				_0006_0018 obj;
				int result3;
				float? num2;
				float? num3;
				float? num4;
				switch (num)
				{
				default:
					awaiter = _000E_2000_200A._000E(_0006, 63).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 0);
						_000F_2008 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0080;
				case 0:
					awaiter = _000F_2008;
					_000F_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0080;
				case 1:
					awaiter4 = _0002_2008;
					_0002_2008 = default(TaskAwaiter<string>);
					num = (_000E = -1);
					goto IL_00f1;
				case 2:
					awaiter3 = _0008_2008;
					_0008_2008 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_01e1;
				case 3:
					awaiter2 = _0005_2008;
					_0005_2008 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = (_000E = -1);
					goto IL_03b7;
				case 4:
					awaiter = _000F_2008;
					_000F_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_04a0;
				case 5:
					{
						awaiter = _000F_2008;
						_000F_2008 = default(TaskAwaiter<bool>);
						num = (_000E = -1);
						goto IL_0540;
					}
					IL_055f:
					if (_000E_2007 >= _0002.Count)
					{
						break;
					}
					_0003_2007 = _0002[_000E_2007];
					awaiter = _0003_2008_200B._000E(_0006, _0003_2007).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 4);
						_000F_2008 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_04a0;
					IL_0080:
					result = awaiter.GetResult();
					_0008 = false;
					if (result)
					{
						awaiter4 = _000E_2000_200A._000E(_0006, 34).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							num = (_000E = 1);
							_0002_2008 = awaiter4;
							_0003.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							return;
						}
						goto IL_00f1;
					}
					_0003_2008_200B.m__000E = DateTime.MinValue;
					goto IL_020f;
					IL_01e1:
					awaiter3.GetResult();
					goto IL_01e8;
					IL_03b7:
					awaiter2.GetResult();
					obj = _0006._000E();
					if (obj == null)
					{
						result2 = false;
					}
					else
					{
						obj._000E(_0005, _000E_2008, _0003_2008, _000F: true, _0008_0017._000E(-1141038239));
						if (_0006_2008)
						{
							_0003_2008_200B.m__000E = DateTime.MinValue;
						}
						result2 = false;
					}
					goto end_IL_0007;
					IL_00f1:
					if (int.TryParse(awaiter4.GetResult(), out result3) && result3 > 0)
					{
						if (_0003_2008_200B.m__000E > DateTime.MinValue)
						{
							double totalSeconds = (DateTime.Now - _0003_2008_200B.m__000E).TotalSeconds;
							if (!(totalSeconds > (double)result3))
							{
								string text = _0008_0017._000E(-1141038146) + ((double)result3 - totalSeconds).ToString(_0008_0017._000E(-1141038161)) + _0008_0017._000E(-1141038170);
								awaiter3 = _000E_2000_200A._000E(_0006, 57, text).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num = (_000E = 2);
									_0008_2008 = awaiter3;
									_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_01e1;
							}
							_0008 = true;
						}
						goto IL_01e8;
					}
					goto IL_020f;
					IL_01e8:
					if (_0003_2008_200B.m__000E == DateTime.MinValue)
					{
						_0003_2008_200B.m__000E = DateTime.Now;
					}
					goto IL_020f;
					IL_020f:
					num2 = _0006._000E()._000E()?._0003;
					num3 = _0006._000E()._000E()?._0006;
					num4 = _0006._000E()._000E()?._000F;
					if (!num2.HasValue || !num3.HasValue || !num4.HasValue)
					{
						result2 = false;
					}
					else
					{
						float value = num2.Value;
						float value2 = num3.Value;
						float value3 = num4.Value;
						_000E_2006_200B obj2 = _000F_2000_200A._000E();
						_0005 = obj2._0006;
						_000E_2008 = obj2._000F;
						_0003_2008 = obj2._0002;
						_0006_2008 = _000E_200A_200A._000E(value, value2, value3, _0005, _000E_2008, _0003_2008, _000F);
						if (!(!_0006_2008 | _0008))
						{
							if (_0002 == null)
							{
								break;
							}
							_000E_2007 = 0;
							goto IL_055f;
						}
						_000F_2000_200A._0003();
						_0006_0018 obj3 = _0006._000E();
						if (obj3 != null)
						{
							awaiter2 = obj3._000E().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_000E = 3);
								_0005_2008 = awaiter2;
								_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_03b7;
						}
						result2 = false;
					}
					goto end_IL_0007;
					IL_054d:
					_000E_2007++;
					goto IL_055f;
					IL_04a0:
					if (awaiter.GetResult())
					{
						_000E_2006_200B obj4 = _000F_2000_200A._000E();
						if (_000E(_0006, _0003_2007, obj4._0006, obj4._000F, obj4._0002, _000F))
						{
							awaiter = _000F_2000_200A._000E(_0006, _0003_2007).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_000E = 5);
								_000F_2008 = awaiter;
								_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0540;
						}
					}
					goto IL_054d;
					IL_0540:
					if (!awaiter.GetResult())
					{
						goto IL_054d;
					}
					result2 = true;
					goto end_IL_0007;
				}
				_000F_2000_200A._0003();
				result2 = false;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult(result2);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _000E : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		public uint _000F;

		private bool _0002;

		private TaskAwaiter<bool> _0008;

		private TaskAwaiter<string> _0005;

		private void MoveNext()
		{
			int num = _000E;
			bool result3;
			try
			{
				TaskAwaiter<string> awaiter;
				TaskAwaiter<bool> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _0005;
						_0005 = default(TaskAwaiter<string>);
						num = (_000E = -1);
						goto IL_00de;
					}
					awaiter2 = _000E_2000_200A._000E(_0006, 82).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_000E = 0);
						_0008 = awaiter2;
						_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = _0008;
					_0008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
				}
				bool result = awaiter2.GetResult();
				_0002 = result;
				awaiter = _000E_2000_200A._000E(_0006, 54).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_000E = 1);
					_0005 = awaiter;
					_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00de;
				IL_00de:
				string result2 = awaiter.GetResult();
				_000E_2008_200A obj = _0003_2008_200B._000E(_0006, _000F);
				if (obj == null || obj._000E())
				{
					result3 = false;
				}
				else
				{
					string text = ((_0002 && !string.IsNullOrEmpty(result2)) ? _000F_200A_200A._000E(_0006, obj._0006, obj._000F) : null);
					result3 = !_000F_2000_200A._000E(obj) && _000E(obj._000E, obj._000E_2008, obj._0002, obj._0008, text, _0002, result2);
				}
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult(result3);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _000F : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		public float _000F;

		public IReadOnlyList<uint> _0002;

		private float _0008;

		private float _0005;

		private float _000E_2008;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _0003_2008;

		private int _0006_2008;

		private uint _000F_2008;

		private TaskAwaiter<bool> _0002_2008;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				_0006_0018 obj4;
				switch (num)
				{
				default:
				{
					_000E_2006_200B obj = _000F_2000_200A._000E();
					_0008 = obj._0006;
					_0005 = obj._000F;
					_000E_2008 = obj._0002;
					float? num2 = _0006._000E()._000E()?._0003;
					float? num3 = _0006._000E()._000E()?._0006;
					float? num4 = _0006._000E()._000E()?._000F;
					if (!num2.HasValue || !num3.HasValue || !num4.HasValue)
					{
						result = false;
						break;
					}
					float value = num2.Value;
					float value2 = num3.Value;
					float value3 = num4.Value;
					if (!_000E_200A_200A._000E(value, value2, value3, _0008, _0005, _000E_2008, _000F))
					{
						_000F_2000_200A._0003();
						_0006_0018 obj2 = _0006._000E();
						if (obj2 == null)
						{
							result = false;
							break;
						}
						awaiter2 = obj2._000E().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 0);
							_0003_2008 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_01a7;
					}
					if (_0002 == null || _0002.Count == 0)
					{
						_000F_2000_200A._0003();
						result = false;
						break;
					}
					_0006_2008 = 0;
					goto IL_0353;
				}
				case 0:
					awaiter2 = _0003_2008;
					_0003_2008 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = (_000E = -1);
					goto IL_01a7;
				case 1:
					awaiter = _0002_2008;
					_0002_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0294;
				case 2:
					{
						awaiter = _0002_2008;
						_0002_2008 = default(TaskAwaiter<bool>);
						num = (_000E = -1);
						goto IL_0334;
					}
					IL_0334:
					if (awaiter.GetResult())
					{
						result = true;
						break;
					}
					goto IL_0341;
					IL_0341:
					_0006_2008++;
					goto IL_0353;
					IL_0294:
					if (awaiter.GetResult())
					{
						_000E_2006_200B obj3 = _000F_2000_200A._000E();
						if (_000E(_0006, _000F_2008, obj3._0006, obj3._000F, obj3._0002, _000F))
						{
							awaiter = _000F_2000_200A._000E(_0006, _000F_2008).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_000E = 2);
								_0002_2008 = awaiter;
								_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0334;
						}
					}
					goto IL_0341;
					IL_0353:
					if (_0006_2008 < _0002.Count)
					{
						_000F_2008 = _0002[_0006_2008];
						awaiter = _0003_2008_200B._000E(_0006, _000F_2008).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 1);
							_0002_2008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0294;
					}
					_000F_2000_200A._0003();
					result = false;
					break;
					IL_01a7:
					awaiter2.GetResult();
					obj4 = _0006._000E();
					if (obj4 == null)
					{
						result = false;
						break;
					}
					obj4._000E(_0008, _0005, _000E_2008, _000F: true, _0008_0017._000E(-1141038239));
					result = false;
					break;
				}
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	private static DateTime m__000E = DateTime.MinValue;

	public static async Task<bool> _000E(_0006_2006 _000E, float _0003, IReadOnlyList<uint> _0006)
	{
		_000E_2006_200B obj = _000F_2000_200A._000E();
		float num = obj._0006;
		float num2 = obj._000F;
		float num3 = obj._0002;
		float? num4 = _000E._000E()._000E()?._0003;
		float? num5 = _000E._000E()._000E()?._0006;
		float? num6 = _000E._000E()._000E()?._000F;
		if (!num4.HasValue || !num5.HasValue || !num6.HasValue)
		{
			return false;
		}
		float value = num4.Value;
		float value2 = num5.Value;
		float value3 = num6.Value;
		if (!_000E_200A_200A._000E(value, value2, value3, num, num2, num3, _0003))
		{
			_000F_2000_200A._0003();
			_0006_0018 obj2 = _000E._000E();
			if (obj2 == null)
			{
				return false;
			}
			await obj2._000E().ConfigureAwait(continueOnCapturedContext: false);
			_0006_0018 obj3 = _000E._000E();
			if (obj3 == null)
			{
				return false;
			}
			obj3._000E(num, num2, num3, _000F: true, _0008_0017._000E(-1141038239));
			return false;
		}
		if (_0006 == null || _0006.Count == 0)
		{
			_000F_2000_200A._0003();
			return false;
		}
		for (int i = 0; i < _0006.Count; i++)
		{
			uint num7 = _0006[i];
			if (await _0003_2008_200B._000E(_000E, num7))
			{
				_000E_2006_200B obj4 = _000F_2000_200A._000E();
				if (_0003_2008_200B._000E(_000E, num7, obj4._0006, obj4._000F, obj4._0002, _0003) && await _000F_2000_200A._000E(_000E, num7))
				{
					return true;
				}
			}
		}
		_000F_2000_200A._0003();
		return false;
	}

	public static async Task<bool> _000E(_0006_2006 _000E, float _0003, float _0006, float _000F, float _0002)
	{
		List<uint> list = await _000F_200A_200A._000E(_000E);
		for (int i = 0; i < list.Count; i++)
		{
			uint num = list[i];
			if (await _0003_2008_200B._000E(_000E, num) && _0003_2008_200B._000E(_000E, num, _0006, _000F, _0002, _0003) && await _000F_2000_200A._000E(_000E, num))
			{
				return true;
			}
		}
		_000F_2000_200A._0003();
		return false;
	}

	public static async Task<bool> _0003(_0006_2006 _000E, float _0003, IReadOnlyList<uint> _0006)
	{
		bool num = await _000E_2000_200A._000E(_000E, 63);
		bool flag = false;
		if (num)
		{
			if (int.TryParse(await _000E_2000_200A._000E(_000E, 34), out var result) && result > 0)
			{
				if (_0003_2008_200B.m__000E > DateTime.MinValue)
				{
					double totalSeconds = (DateTime.Now - _0003_2008_200B.m__000E).TotalSeconds;
					if (totalSeconds > (double)result)
					{
						flag = true;
					}
					else
					{
						string text = _0008_0017._000E(-1141038146) + ((double)result - totalSeconds).ToString(_0008_0017._000E(-1141038161)) + _0008_0017._000E(-1141038170);
						await _000E_2000_200A._000E(_000E, 57, text);
					}
				}
				if (_0003_2008_200B.m__000E == DateTime.MinValue)
				{
					_0003_2008_200B.m__000E = DateTime.Now;
				}
			}
		}
		else
		{
			_0003_2008_200B.m__000E = DateTime.MinValue;
		}
		float? num2 = _000E._000E()._000E()?._0003;
		float? num3 = _000E._000E()._000E()?._0006;
		float? num4 = _000E._000E()._000E()?._000F;
		if (!num2.HasValue || !num3.HasValue || !num4.HasValue)
		{
			return false;
		}
		float value = num2.Value;
		float value2 = num3.Value;
		float value3 = num4.Value;
		_000E_2006_200B obj = _000F_2000_200A._000E();
		float num5 = obj._0006;
		float num6 = obj._000F;
		float num7 = obj._0002;
		bool flag2 = _000E_200A_200A._000E(value, value2, value3, num5, num6, num7, _0003);
		if (!flag2 || flag)
		{
			_000F_2000_200A._0003();
			_0006_0018 obj2 = _000E._000E();
			if (obj2 == null)
			{
				return false;
			}
			await obj2._000E().ConfigureAwait(continueOnCapturedContext: false);
			_0006_0018 obj3 = _000E._000E();
			if (obj3 == null)
			{
				return false;
			}
			obj3._000E(num5, num6, num7, _000F: true, _0008_0017._000E(-1141038239));
			if (flag2)
			{
				_0003_2008_200B.m__000E = DateTime.MinValue;
			}
			return false;
		}
		if (_0006 != null)
		{
			for (int i = 0; i < _0006.Count; i++)
			{
				uint num8 = _0006[i];
				if (await _0003_2008_200B._000E(_000E, num8))
				{
					_000E_2006_200B obj4 = _000F_2000_200A._000E();
					if (_0003_2008_200B._000E(_000E, num8, obj4._0006, obj4._000F, obj4._0002, _0003) && await _000F_2000_200A._000E(_000E, num8))
					{
						return true;
					}
				}
			}
		}
		_000F_2000_200A._0003();
		return false;
	}

	public static async Task<bool> _000E(_0006_2006 _000E, IReadOnlyList<uint> _0003)
	{
		if (_0003 != null)
		{
			for (int i = 0; i < _0003.Count; i++)
			{
				uint num = _0003[i];
				if (await _0003_2008_200B._000E(_000E, num) && await _000F_2000_200A._000E(_000E, num))
				{
					return true;
				}
			}
		}
		_000F_2000_200A._0003();
		return false;
	}

	public static Task<bool> _000E(_0006_2006 _000E, float _0003)
	{
		_000F_2000_200A._0003();
		return Task.FromResult(result: false);
	}

	public static async Task<bool> _000E(_0006_2006 _000E, uint _0003)
	{
		bool flag = await _000E_2000_200A._000E(_000E, 82);
		string text = await _000E_2000_200A._000E(_000E, 54);
		_000E_2008_200A obj = _0003_2008_200B._000E(_000E, _0003);
		if (obj == null || obj._000E())
		{
			return false;
		}
		string text2 = ((flag && !string.IsNullOrEmpty(text)) ? _000F_200A_200A._000E(_000E, obj._0006, obj._000F) : null);
		return !_000F_2000_200A._000E(obj) && _0003_2008_200B._000E(obj._000E, obj._000E_2008, obj._0002, obj._0008, text2, flag, text);
	}

	private static bool _000E(byte _000E, uint _0003, int _0006, int _000F, string _0002, bool _0008, string _0005)
	{
		if (_000E != 2)
		{
			return false;
		}
		if (_0008 && !string.IsNullOrEmpty(_0005) && (_0002 == null || !_0003_2008_200B._000E(_0002, _0005)))
		{
			return false;
		}
		if (_000F >= 20000 && _0006 <= 6)
		{
			return false;
		}
		if (_000F >= 10000 && _0006 <= 5)
		{
			return false;
		}
		if (_000F >= 5000 && _0006 <= 4)
		{
			return false;
		}
		if (_000F >= 1000 && _0006 <= 3)
		{
			return false;
		}
		return _0006 > 2;
	}

	private static _000E_2008_200A _000E(_0006_2006 _000E, uint _0003)
	{
		IReadOnlyList<_000E_2008_200A> readOnlyList = _000E._000E()._000E();
		if (readOnlyList == null)
		{
			return null;
		}
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			_000E_2008_200A obj = readOnlyList[i];
			if (obj != null && obj._000E_2008 == _0003)
			{
				return obj;
			}
		}
		return null;
	}

	private static bool _000E(_0006_2006 _000E, uint _0003, float _0006, float _000F, float _0002, float _0008)
	{
		_000E_2008_200A obj = _0003_2008_200B._000E(_000E, _0003);
		if (obj != null && !obj._000E())
		{
			return _000E_200A_200A._000E(obj._0003_2008, obj._0006_2008, obj._000F_2008, _0006, _000F, _0002, _0008);
		}
		return false;
	}

	private static bool _000E(string _000E, string _0003)
	{
		if (_000E.Equals(_0003, StringComparison.OrdinalIgnoreCase))
		{
			return true;
		}
		if (_0003.IndexOf(_000E, StringComparison.OrdinalIgnoreCase) < 0)
		{
			return _000E.IndexOf(_0003, StringComparison.OrdinalIgnoreCase) >= 0;
		}
		return true;
	}

	public static void _000E()
	{
		_0003_2008_200B.m__000E = DateTime.MinValue;
	}
}
internal static class _0003_2009_200B
{
	internal sealed class _0003
	{
		internal readonly string _000E;

		internal readonly string _0003;

		internal readonly string _0006;

		internal readonly bool _000F;

		internal readonly bool _0002;

		internal readonly int _0008;

		internal _0003(string _000E, string _0003, bool _0006, bool _000F, int _0002)
		{
			this._0003 = _000E ?? string.Empty;
			this._0006 = _0003 ?? string.Empty;
			this._000E = _0003_2009_200B._0003._000E(this._0003, this._0006);
			this._000F = _0006;
			this._0002 = _000F;
			_0008 = _0002;
		}

		internal bool _000E()
		{
			if (_000F && !_0002)
			{
				return _0008 == 0;
			}
			return false;
		}

		internal static _0003 _000E(string _000E)
		{
			return new _0003(_000E, string.Empty, _0006: true, _000F: false, 0);
		}

		internal static _0003 _0003(string _000E)
		{
			return new _0003(string.Empty, _000E, _0006: true, _000F: false, 1);
		}

		private static string _000E(string _000E, string _0003)
		{
			if (string.IsNullOrEmpty(_000E))
			{
				return _0003;
			}
			if (string.IsNullOrEmpty(_0003))
			{
				return _000E;
			}
			return _000E + Environment.NewLine + _0003;
		}
	}

	private sealed class _000E
	{
		public StringBuilder _000E;

		public StringBuilder _0003;

		internal void _000E(object _000E, DataReceivedEventArgs _0003)
		{
			if (_0003.Data == null)
			{
				return;
			}
			lock (this._000E)
			{
				this._000E.AppendLine(_0003.Data);
			}
		}

		internal void _0003(object _000E, DataReceivedEventArgs _0003)
		{
			if (_0003.Data == null)
			{
				return;
			}
			lock (this._0003)
			{
				this._0003.AppendLine(_0003.Data);
			}
		}
	}

	private static readonly Regex m__000E = new Regex(_0008_0017._000E(-1141036385), RegexOptions.CultureInvariant);

	internal static string _000E(string _000E, string _0003, string _0006, int _000F)
	{
		return _0003_2009_200B._000E(_000E, _0003, _0006, _000F)._000E;
	}

	internal static _0003 _000E(string _000E, string _0003, string _0006, int _000F)
	{
		_000E obj = new _000E();
		if (_0003 != null && !_0003_2009_200B._000E(_0003))
		{
			return new _0003(string.Empty, _0008_0017._000E(-1141329749), _0006: false, _000F: false, -1);
		}
		string arguments = ((_0003 == null) ? string.Empty : (_0008_0017._000E(-1141036412) + _0003 + _0008_0017._000E(-1141299597))) + _0006;
		ProcessStartInfo startInfo = new ProcessStartInfo(_000E, arguments)
		{
			RedirectStandardOutput = true,
			RedirectStandardError = true,
			UseShellExecute = false,
			CreateNoWindow = true,
			StandardOutputEncoding = Encoding.UTF8,
			StandardErrorEncoding = Encoding.UTF8
		};
		obj._000E = new StringBuilder();
		obj._0003 = new StringBuilder();
		try
		{
			using Process process = new Process
			{
				StartInfo = startInfo
			};
			DataReceivedEventHandler value = obj._000E;
			DataReceivedEventHandler value2 = obj._0003;
			process.OutputDataReceived += value;
			process.ErrorDataReceived += value2;
			process.Start();
			process.BeginOutputReadLine();
			process.BeginErrorReadLine();
			if (!process.WaitForExit(_000F))
			{
				try
				{
					process.Kill();
				}
				catch
				{
				}
				try
				{
					process.WaitForExit(2000);
				}
				catch
				{
				}
				lock (obj._0003)
				{
					obj._0003.AppendLine(_0008_0017._000E(-1141036430) + _000F + _0008_0017._000E(-1141185280));
				}
				string text;
				lock (obj._000E)
				{
					text = obj._000E.ToString().Trim();
				}
				string text2;
				lock (obj._0003)
				{
					text2 = obj._0003.ToString().Trim();
				}
				return new _0003(text, text2, _0006: true, _000F: true, -1);
			}
			process.WaitForExit();
			int exitCode = process.ExitCode;
			string text3;
			lock (obj._000E)
			{
				text3 = obj._000E.ToString().Trim();
			}
			string text4;
			lock (obj._0003)
			{
				text4 = obj._0003.ToString().Trim();
			}
			return new _0003(text3, text4, _0006: true, _000F: false, exitCode);
		}
		catch (Exception ex)
		{
			lock (obj._0003)
			{
				obj._0003.AppendLine(ex.Message);
			}
			string text5;
			lock (obj._000E)
			{
				text5 = obj._000E.ToString().Trim();
			}
			string text6;
			lock (obj._0003)
			{
				text6 = obj._0003.ToString().Trim();
			}
			return new _0003(text5, text6, _0006: false, _000F: false, -1);
		}
	}

	internal static bool _000E(string _000E)
	{
		if (!string.IsNullOrEmpty(_000E) && _000E[0] != '-')
		{
			return _0003_2009_200B.m__000E.IsMatch(_000E);
		}
		return false;
	}
}
internal sealed class _0003_200B_200B
{
	private float _000E;

	private float _0003;

	private float? _0006;

	[JsonProperty("X")]
	public float _000F
	{
		get
		{
			return _000E;
		}
		set
		{
			_000E = value;
		}
	}

	[JsonProperty("Y")]
	public float _0002
	{
		get
		{
			return _0003;
		}
		set
		{
			_0003 = value;
		}
	}

	[JsonProperty("Z")]
	public float? _0008
	{
		get
		{
			return _0006;
		}
		set
		{
			_0006 = value;
		}
	}
}
internal sealed class _0005_2001_200B
{
	private DateTime _000E;

	private List<_000E_200B_200B> _0003;

	[JsonProperty("SaveDate")]
	public DateTime _0006
	{
		get
		{
			return _000E;
		}
		set
		{
			_000E = value;
		}
	}

	[JsonProperty("GridData")]
	public List<_000E_200B_200B> _000F
	{
		get
		{
			return _0003;
		}
		set
		{
			_0003 = value;
		}
	}
}
internal static class _0005_2002_200B
{
	public static bool _000E(bool _000E, int _0003, int _0006)
	{
		if (_000E)
		{
			return _0003 != _0006;
		}
		return true;
	}

	public static bool _000E(bool _000E, int _0003, int _0006, float _000F, float _0002, float _0008, float _0005)
	{
		if (!_000E)
		{
			return true;
		}
		if (_0003 != _0006)
		{
			return true;
		}
		float num = _000F - _0008;
		float num2 = _0002 - _0005;
		return num * num + num2 * num2 >= 16f;
	}
}
internal sealed class _0005_2003_200B : Form
{
	private TextBox m__000E;

	private readonly DataGridView m__0003;

	private readonly Label _0006;

	private readonly Button _000F;

	private readonly List<_000F_200A_200A._0008> _0002 = new List<_000F_200A_200A._0008>();

	internal _0005_2003_200B(TextBox _000E)
	{
		this.m__000E = _000E;
		Text = _0008_0017._000E(-1141267293);
		base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		base.StartPosition = FormStartPosition.CenterParent;
		base.MaximizeBox = false;
		base.ShowInTaskbar = false;
		BackColor = SystemColors.Control;
		base.ClientSize = new Size(440, 255);
		this.m__0003 = new DataGridView();
		this.m__0003.Location = new Point(10, 10);
		this.m__0003.Size = new Size(420, 170);
		this.m__0003.ReadOnly = true;
		this.m__0003.AllowUserToAddRows = false;
		this.m__0003.AllowUserToDeleteRows = false;
		this.m__0003.AllowUserToResizeRows = false;
		this.m__0003.AllowUserToResizeColumns = false;
		this.m__0003.AllowUserToOrderColumns = false;
		this.m__0003.RowHeadersVisible = false;
		this.m__0003.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.m__0003.MultiSelect = false;
		this.m__0003.BackgroundColor = SystemColors.Window;
		this.m__0003.BorderStyle = BorderStyle.FixedSingle;
		this.m__0003.Columns.Add(_0008_0017._000E(-1141285330), _0008_0017._000E(-1141285330));
		this.m__0003.Columns.Add(_0008_0017._000E(-1141035464), _0008_0017._000E(-1141035464));
		this.m__0003.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.m__0003.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		base.Controls.Add(this.m__0003);
		_0006 = new Label();
		_0006.Location = new Point(10, 190);
		_0006.Size = new Size(420, 30);
		_0006.TextAlign = ContentAlignment.TopLeft;
		_0006.Text = _0008_0017._000E(-1141035479);
		base.Controls.Add(_0006);
		_000F = new Button();
		_000F.Location = new Point(355, 222);
		_000F.Size = new Size(75, 23);
		_000F.Text = _0008_0017._000E(-1141035216);
		_000F.UseVisualStyleBackColor = true;
		base.Controls.Add(_000F);
		_000F.Click += this._000E;
		this.m__0003.CellDoubleClick += this._000E;
		this.m__0003.SelectionChanged += _0003;
	}

	internal void _000E(List<_000F_200A_200A._0008> _000E)
	{
		if (base.IsDisposed)
		{
			return;
		}
		_0002.Clear();
		this.m__0003.Rows.Clear();
		if (_000E != null)
		{
			for (int i = 0; i < _000E.Count; i++)
			{
				_000F_200A_200A._0008 obj = _000E[i];
				if (obj != null)
				{
					_0002.Add(obj);
					this.m__0003.Rows.Add(_000F_200A_200A._000E(obj), _000F_200A_200A._0003(obj));
				}
			}
		}
		this.m__0003.ClearSelection();
		this.m__0003.CurrentCell = null;
		_0006.Text = ((_000F_200A_200A._000E(_0002) == 0) ? _0008_0017._000E(-1141036550) : _0008_0017._000E(-1141035479));
	}

	private void _000E(object _000E, EventArgs _0003)
	{
		this._000E(this._000E());
	}

	private void _000E(object _000E, DataGridViewCellEventArgs _0003)
	{
		this._000E(this._000E());
	}

	private void _0003(object _000E, EventArgs _0003)
	{
		int num = this._000E();
		if (num >= 0 && num < _0002.Count)
		{
			_0006.Text = (_000F_200A_200A._000E(_0002[num]) ? _0008_0017._000E(-1141035479) : _0008_0017._000E(-1141036632));
		}
	}

	private int _000E()
	{
		if (this.m__0003.SelectedRows.Count == 0)
		{
			return -1;
		}
		return this.m__0003.SelectedRows[0].Index;
	}

	private void _000E(int _000E)
	{
		if (_000E >= 0 && _000E < _0002.Count && this.m__000E != null)
		{
			_000F_200A_200A._0008 obj = _0002[_000E];
			if (!_000F_200A_200A._000E(obj))
			{
				_0006.Text = _0008_0017._000E(-1141036632);
				return;
			}
			this.m__000E.Text = obj._0003;
			Close();
		}
	}

	protected override void OnFormClosed(FormClosedEventArgs _000E)
	{
		_000F.Click -= this._000E;
		this.m__0003.CellDoubleClick -= this._000E;
		this.m__0003.SelectionChanged -= _0003;
		_0002.Clear();
		this.m__000E = null;
		base.OnFormClosed(_000E);
	}
}
internal static class _0005_2004_200B
{
	private static class _000E
	{
		public static ResolveEventHandler _000E;
	}

	private static object m__000E = new object();

	private static Dictionary<string, bool> _0003 = new Dictionary<string, bool>();

	private static Dictionary<string, string> _0006 = new Dictionary<string, string>();

	private static Dictionary<string, string> _000F = new Dictionary<string, string>();

	private static int _0002;

	static _0005_2004_200B()
	{
		_0006.Add(_0008_0017._000E(-1141036212), _0008_0017._000E(-1141036226));
		_000F.Add(_0008_0017._000E(-1141036212), _0008_0017._000E(-1141036271));
		_0006.Add(_0008_0017._000E(-1141036300), _0008_0017._000E(-1141036322));
	}

	private static string _000E(CultureInfo _000E)
	{
		if (_000E == null)
		{
			return string.Empty;
		}
		return _000E.Name;
	}

	private static Assembly _000E(AssemblyName _000E)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		Assembly[] assemblies = currentDomain.GetAssemblies();
		Assembly[] array = assemblies;
		foreach (Assembly assembly in array)
		{
			AssemblyName name = assembly.GetName();
			if (string.Equals(name.Name, _000E.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(_0005_2004_200B._000E(name.CultureInfo), _0005_2004_200B._000E(_000E.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
			{
				return assembly;
			}
		}
		return null;
	}

	private static string _000E(AssemblyName _000E)
	{
		string text = _000E.Name.ToLowerInvariant();
		if (_000E.CultureInfo != null && !string.IsNullOrEmpty(_000E.CultureInfo.Name))
		{
			text = (_0005_2004_200B._000E(_000E.CultureInfo) + _0008_0017._000E(-1141299374) + text).ToLowerInvariant();
		}
		return text;
	}

	private static void _000E(Stream _000E, Stream _0003)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = _000E.Read(array, 0, array.Length)) != 0)
		{
			_0003.Write(array, 0, count);
		}
	}

	private static Stream _000E(string _000E)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (_000E.EndsWith(_0008_0017._000E(-1141036375)))
		{
			using (Stream stream = executingAssembly.GetManifestResourceStream(_000E))
			{
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				try
				{
					MemoryStream memoryStream = new MemoryStream();
					_0005_2004_200B._000E(deflateStream, memoryStream);
					memoryStream.Position = 0L;
					return memoryStream;
				}
				finally
				{
					((IDisposable)deflateStream).Dispose();
				}
			}
		}
		return executingAssembly.GetManifestResourceStream(_000E);
	}

	private static Stream _000E(Dictionary<string, string> _000E, string _0003)
	{
		if (_000E.TryGetValue(_0003, out var value))
		{
			return _0005_2004_200B._000E(value);
		}
		return null;
	}

	private static byte[] _000E(Stream _000E)
	{
		byte[] array = new byte[_000E.Length];
		_000E.Read(array, 0, array.Length);
		return array;
	}

	private static Assembly _000E(Dictionary<string, string> _000E, Dictionary<string, string> _0003, AssemblyName _0006)
	{
		string text = _0005_2004_200B._000E(_0006);
		byte[] rawAssembly;
		using (Stream stream = _0005_2004_200B._000E(_000E, text))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = _0005_2004_200B._000E(stream);
		}
		using (Stream stream2 = _0005_2004_200B._000E(_0003, text))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = _0005_2004_200B._000E(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	public static Assembly _000E(object _000E, ResolveEventArgs _0003)
	{
		string name = _0003.Name;
		AssemblyName assemblyName = new AssemblyName(name);
		lock (_0005_2004_200B.m__000E)
		{
			if (_0005_2004_200B._0003.ContainsKey(name))
			{
				return null;
			}
		}
		Assembly assembly = _0005_2004_200B._000E(assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = _0005_2004_200B._000E(_0006, _000F, assemblyName);
		if ((object)assembly == null)
		{
			lock (_0005_2004_200B.m__000E)
			{
				_0005_2004_200B._0003[name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	public static void _000E(bool _000E)
	{
		if (Interlocked.Exchange(ref _0002, 1) != 1 && _000E)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += _0005_2004_200B._000E;
		}
	}
}
internal sealed class _0005_2006_200B : Form
{
	private TextBox m__000E;

	private readonly DataGridView m__0003;

	private readonly Label _0006;

	private readonly Button _000F;

	private readonly List<_000F_2008_200A> _0002 = new List<_000F_2008_200A>();

	private string _0008 = _0008_0017._000E(-1141035168);

	internal _0005_2006_200B(TextBox _000E)
	{
		this.m__000E = _000E;
		Text = _0008_0017._000E(-1141268020);
		base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		base.StartPosition = FormStartPosition.CenterParent;
		base.MaximizeBox = false;
		base.ShowInTaskbar = false;
		BackColor = SystemColors.Control;
		base.ClientSize = new Size(640, 300);
		this.m__0003 = new DataGridView();
		this.m__0003.Location = new Point(10, 10);
		this.m__0003.Size = new Size(620, 205);
		this.m__0003.ReadOnly = true;
		this.m__0003.AllowUserToAddRows = false;
		this.m__0003.AllowUserToDeleteRows = false;
		this.m__0003.AllowUserToResizeRows = false;
		this.m__0003.AllowUserToOrderColumns = false;
		this.m__0003.AllowUserToResizeColumns = true;
		this.m__0003.RowHeadersVisible = false;
		this.m__0003.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.m__0003.MultiSelect = false;
		this.m__0003.BackgroundColor = SystemColors.Window;
		this.m__0003.BorderStyle = BorderStyle.FixedSingle;
		string[] array = _0005_0018._000E();
		for (int i = 0; i < array.Length; i++)
		{
			this.m__0003.Columns.Add(array[i], array[i]);
		}
		for (int j = 0; j < this.m__0003.Columns.Count; j++)
		{
			this.m__0003.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		}
		this.m__0003.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		base.Controls.Add(this.m__0003);
		_0006 = new Label();
		_0006.Location = new Point(10, 225);
		_0006.Size = new Size(620, 32);
		_0006.TextAlign = ContentAlignment.TopLeft;
		_0006.Text = _0008_0017._000E(-1141035168);
		base.Controls.Add(_0006);
		_000F = new Button();
		_000F.Location = new Point(555, 267);
		_000F.Size = new Size(75, 23);
		_000F.Text = _0008_0017._000E(-1141035216);
		_000F.UseVisualStyleBackColor = true;
		base.Controls.Add(_000F);
		_000F.Click += this._000E;
		this.m__0003.CellDoubleClick += this._000E;
		this.m__0003.SelectionChanged += _0003;
	}

	internal void _000E(IReadOnlyList<_000F_2008_200A> _000E, int _0003)
	{
		if (base.IsDisposed)
		{
			return;
		}
		_0002.Clear();
		this.m__0003.Rows.Clear();
		if (_000E != null)
		{
			for (int i = 0; i < _000E.Count; i++)
			{
				_000F_2008_200A obj = _000E[i];
				_0002.Add(obj);
				DataGridViewRowCollection rows = this.m__0003.Rows;
				object[] values = _0005_0018._000E(obj);
				rows.Add(values);
			}
		}
		this.m__0003.ClearSelection();
		this.m__0003.CurrentCell = null;
		string text = ((_0005_0018._000E(_0002) == 0 && _0002.Count != 0) ? _0008_0017._000E(-1141035218) : _0008_0017._000E(-1141035168));
		_0008 = text + _0005_0018._000E(_0003);
		_0006.Text = _0008;
	}

	private void _000E(object _000E, EventArgs _0003)
	{
		this._000E(this._000E());
	}

	private void _000E(object _000E, DataGridViewCellEventArgs _0003)
	{
		this._000E(this._000E());
	}

	private void _0003(object _000E, EventArgs _0003)
	{
		int num = this._000E();
		if (num >= 0 && num < _0002.Count)
		{
			_0006.Text = (_0005_0018._000E(_0002[num]) ? _0008 : _0008_0017._000E(-1141035290));
		}
	}

	private int _000E()
	{
		if (this.m__0003.SelectedRows.Count == 0)
		{
			return -1;
		}
		return this.m__0003.SelectedRows[0].Index;
	}

	private void _000E(int _000E)
	{
		if (_000E >= 0 && _000E < _0002.Count && this.m__000E != null)
		{
			_000F_2008_200A obj = _0002[_000E];
			if (!_0005_0018._000E(obj))
			{
				_0006.Text = _0008_0017._000E(-1141035290);
				return;
			}
			this.m__000E.Text = obj._000E;
			Close();
		}
	}

	protected override void OnFormClosed(FormClosedEventArgs _000E)
	{
		_000F.Click -= this._000E;
		this.m__0003.CellDoubleClick -= this._000E;
		this.m__0003.SelectionChanged -= _0003;
		_0002.Clear();
		this.m__000E = null;
		base.OnFormClosed(_000E);
	}
}
internal static class _0005_2007_200B
{
	internal static readonly Color _000E = Color.LightGreen;

	internal static bool _000E(string _000E, string _0003)
	{
		if (_000E == null || _0003 == null)
		{
			return false;
		}
		_000E = _000E.Trim();
		_0003 = _0003.Trim();
		if (_000E.Length == 0 || _0003.Length == 0)
		{
			return false;
		}
		return string.Equals(_000E, _0003, StringComparison.OrdinalIgnoreCase);
	}

	internal static int _000E(DataGridView _000E, string _0003)
	{
		if (_000E == null || _0003 == null)
		{
			return -1;
		}
		string text = _0003.Trim();
		if (text.Length == 0)
		{
			return -1;
		}
		DataGridViewRowCollection rows = _000E.Rows;
		for (int i = 0; i < rows.Count; i++)
		{
			DataGridViewRow dataGridViewRow = rows[i];
			if (!dataGridViewRow.IsNewRow && dataGridViewRow.Cells.Count > 0)
			{
				object value = dataGridViewRow.Cells[0].Value;
				if (value != null && _0005_2007_200B._000E(value.ToString(), text))
				{
					return i;
				}
			}
		}
		return -1;
	}

	internal static bool _000E(DataGridView _000E, string _0003)
	{
		return _0005_2007_200B._000E(_000E, _0003) >= 0;
	}

	internal static string _000E(DataGridViewRow _000E)
	{
		if (_000E == null)
		{
			return string.Empty;
		}
		if (_000E.IsNewRow)
		{
			return string.Empty;
		}
		DataGridViewCellCollection cells = _000E.Cells;
		if (cells.Count <= 1)
		{
			return string.Empty;
		}
		object value = cells[0].Value;
		if (value == null)
		{
			return string.Empty;
		}
		if (value.ToString().Trim().Length == 0)
		{
			return string.Empty;
		}
		object value2 = cells[1].Value;
		if (value2 == null)
		{
			return string.Empty;
		}
		return value2.ToString().Trim();
	}

	internal static int _000E(DataGridView _000E, DataGridView _0003)
	{
		if (_000E == null)
		{
			return 0;
		}
		int num = 0;
		DataGridViewRowCollection rows = _000E.Rows;
		for (int i = 0; i < rows.Count; i++)
		{
			DataGridViewRow dataGridViewRow = rows[i];
			if (dataGridViewRow.IsNewRow)
			{
				continue;
			}
			string text = _0005_2007_200B._000E(dataGridViewRow);
			int num2;
			Color color;
			if (text.Length != 0)
			{
				num2 = (_0005_2007_200B._000E(_0003, text) ? 1 : 0);
				if (num2 != 0)
				{
					color = _0005_2007_200B._000E;
					goto IL_004d;
				}
			}
			else
			{
				num2 = 0;
			}
			color = Color.Empty;
			goto IL_004d;
			IL_004d:
			Color color2 = color;
			if (dataGridViewRow.DefaultCellStyle.BackColor != color2)
			{
				dataGridViewRow.DefaultCellStyle.BackColor = color2;
			}
			if (num2 != 0)
			{
				num++;
			}
		}
		return num;
	}
}
internal sealed class _0005_2008_200B
{
	private IReadOnlyList<_000E_2007_200B> m__000E = new _000E_2007_200B[0];

	private DateTime _0003;

	internal IReadOnlyList<_000E_2007_200B> _000E(IReadOnlyList<_000E_2007_200B> _000E, DateTime _0003)
	{
		if (_000E != null && _000E.Count > 0)
		{
			this.m__000E = _000E;
			this._0003 = _0003;
			return _000E;
		}
		if (this._0003 != DateTime.MinValue && _0003 - this._0003 <= TimeSpan.FromSeconds(2.0))
		{
			return this.m__000E;
		}
		return _000E ?? new _000E_2007_200B[0];
	}

	internal void _000E()
	{
		this.m__000E = new _000E_2007_200B[0];
		_0003 = DateTime.MinValue;
	}
}
internal static class _0005_2009_200B
{
	private sealed class _0002
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _000E()
		{
			return _0005_2009_200B._0003._000E(_0005_2009_200B._000E(typeof(_000F)), _0005_2009_200B._000E(typeof(_0008)) ^ _0005_2009_200B._0003._0003(_0005_2009_200B._000E(typeof(_0002)), _0005_2009_200B._0003._0006(_0005_2009_200B._000E(typeof(_000E_2008)), _0008._000E())));
		}
	}

	private static class _0003
	{
		internal static int _000E(int _000E, int _0003)
		{
			return _000E ^ (_0003 - -(~(~(-(-(~(~(-(-(~(~-1398160775)))))))))));
		}

		internal static int _0003(int _000E, int _0003)
		{
			return (_000E - ~(-(-(~(~(-(~(-(~-1656948447))))))))) ^ (_0003 + -(~(-(~(-(~(~(-(~-658536355)))))))));
		}

		internal static int _0006(int _000E, int _0003)
		{
			return _000E ^ ((_0003 - ~(-(~(-(-(~(~(-(~(-(~280966476))))))))))) ^ (_000E - _0003));
		}
	}

	private sealed class _0005
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _000E()
		{
			return _0005_2009_200B._0003._0003(_0005_2009_200B._0003._0003(_000F._000E(), _0005_2009_200B._0003._000E(_0005_2009_200B._000E(typeof(_0005)), _0002._000E())), _0005_2009_200B._000E(typeof(_000E_2008)));
		}
	}

	private sealed class _0006
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _000E()
		{
			return _0005_2009_200B._0003._0006(_0005_2009_200B._0003._0003(_0005_2009_200B._000E(typeof(_0002)), _0005_2009_200B._0003._0006(_0005_2009_200B._000E(typeof(_0006)), _0005_2009_200B._000E(typeof(_0005)))), _000E_2008._000E());
		}
	}

	private sealed class _0008
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _000E()
		{
			return _0005_2009_200B._0003._0006(_0005_2009_200B._000E(typeof(_0008)), _0005_2009_200B._0003._000E(_0005_2009_200B._000E(typeof(_0006)), _0005_2009_200B._0003._0003(_0005_2009_200B._000E(typeof(_0002)), _0005_2009_200B._0003._0006(_0005_2009_200B._000E(typeof(_000F)), _0005_2009_200B._0003._000E(_0005_2009_200B._000E(typeof(_0005)), _0005_2009_200B._000E(typeof(_000E_2008)))))));
		}
	}

	private sealed class _000E
	{
		private int m__000E;

		private int _0003;

		internal _000E()
		{
			_000E(0L);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal long _000E()
		{
			if ((object)Assembly.GetCallingAssembly() != typeof(_000E).Assembly)
			{
				return 2918384L;
			}
			if (!_0005_2009_200B._000E())
			{
				return 2918384L;
			}
			int[] array = new int[4];
			array[3] = ~(-(~(-(-(~(~(-(-(~(~554402715))))))))));
			array[1] = ~(-(-(~(~(-(~(-(~-1445981172))))))));
			array[2] = ~(-(~(-(-(~(-(~(~(-(~-267516146))))))))));
			array[0] = ~(-(-(~(~(-(~(-(~-404454212))))))));
			int num = this.m__000E;
			int num2 = _0003;
			int num3 = ~(-(-(~(-(~(-(~(~(-(~1640531527))))))))));
			int num4 = -(~(-(~(-(~(~(-(~957401313))))))));
			for (int i = 0; i != 32; i++)
			{
				num2 -= (((num << 4) ^ (num >> 5)) + num) ^ (num4 + array[(num4 >> 11) & 3]);
				num4 -= num3;
				num -= (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + array[num4 & 3]);
			}
			for (int j = 0; j != 4; j++)
			{
				array[j] = 0;
			}
			ulong num5 = (ulong)((long)num2 << 32);
			return (long)(num5 | (uint)num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _000E(long _000E)
		{
			if ((object)Assembly.GetCallingAssembly() == typeof(_000E).Assembly && _0005_2009_200B._000E())
			{
				int[] array = new int[4];
				array[1] = -(~(~(-(-(~(-(~(-(~(~-1445981167))))))))));
				array[0] = ~(-(-(~(-(~(~(-(-(~(~-404454209))))))))));
				array[2] = -(~(~(-(-(~(-(~(~-267516143))))))));
				array[3] = ~(-(-(~(~(-(~(-(~(-(~554402713))))))))));
				int num = -(~(-(~(~(-(-(~(~(-(~1640531527))))))))));
				int num2 = (int)_000E;
				int num3 = (int)(_000E >> 32);
				int num4 = 0;
				for (int i = 0; i != 32; i++)
				{
					num2 += (((num3 << 4) ^ (num3 >> 5)) + num3) ^ (num4 + array[num4 & 3]);
					num4 += num;
					num3 += (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + array[(num4 >> 11) & 3]);
				}
				for (int j = 0; j != 4; j++)
				{
					array[j] = 0;
				}
				this.m__000E = num2;
				_0003 = num3;
			}
		}
	}

	private sealed class _000E_2008
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _000E()
		{
			return _0005_2009_200B._0003._000E(_0005_2009_200B._000E(typeof(_000E_2008)), _0005_2009_200B._0003._0006(_0005_2009_200B._0003._0003(_0005_2009_200B._000E(typeof(_0005)), _0005_2009_200B._000E(typeof(_0006))), _0005_2009_200B._0003._0006(_0005_2009_200B._000E(typeof(_000F)) ^ -(~(~(-(~(-(-(~(-(~(~872978741)))))))))), _0005._000E())));
		}
	}

	private sealed class _000F
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int _000E()
		{
			return _0005_2009_200B._0003._0006(_0005_2009_200B._0003._000E(_0002._000E() ^ -(~(~(-(-(~(-(~(~-527758445)))))))), _0005_2009_200B._000E(typeof(_0008))), _0005_2009_200B._0003._0003(_0005_2009_200B._000E(typeof(_0006)) ^ _0005_2009_200B._000E(typeof(_000E_2008)), -(~(-(~(~(-(-(~(~-593750658))))))))));
		}
	}

	private static _000E m__000E = new _000E();

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long _000E()
	{
		if ((object)Assembly.GetCallingAssembly() != typeof(_0005_2009_200B).Assembly || !_000E())
		{
			return 0L;
		}
		lock (_0005_2009_200B.m__000E)
		{
			long num = _0005_2009_200B.m__000E._000E();
			if (num == 0)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				List<byte> list = new List<byte>();
				AssemblyName assemblyName;
				try
				{
					assemblyName = executingAssembly.GetName();
				}
				catch
				{
					assemblyName = new AssemblyName(executingAssembly.FullName);
				}
				byte[] array = assemblyName.GetPublicKeyToken();
				if (array != null && array.Length == 0)
				{
					array = null;
				}
				if (array != null)
				{
					list.AddRange(array);
				}
				list.AddRange(Encoding.Unicode.GetBytes(assemblyName.Name));
				int num2 = _000E(typeof(_0005_2009_200B));
				int num3 = _0006._000E();
				list.Add((byte)(num2 >> 24));
				list.Add((byte)(num3 >> 16));
				list.Add((byte)(num2 >> 8));
				list.Add((byte)num3);
				list.Add((byte)(num2 >> 16));
				list.Add((byte)(num3 >> 8));
				list.Add((byte)num2);
				list.Add((byte)(num3 >> 24));
				int count = list.Count;
				ulong num4 = 0uL;
				for (int i = 0; i != count; i++)
				{
					num4 += list[i];
					num4 += num4 << 20;
					num4 ^= num4 >> 12;
					list[i] = 0;
				}
				num4 += num4 << 6;
				num4 ^= num4 >> 22;
				num4 += num4 << 30;
				num = (long)num4;
				num ^= 0x52217D9FDEBFBB46L;
				_0005_2009_200B.m__000E._000E(num);
			}
			return num;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _000E()
	{
		if (!_0003())
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _0003()
	{
		StackTrace stackTrace = new StackTrace();
		Type type = (stackTrace.GetFrame(3)?.GetMethod())?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			return false;
		}
		if ((object)type == null)
		{
			return false;
		}
		if ((object)type.Assembly != typeof(_0005_2009_200B).Assembly)
		{
			return false;
		}
		return true;
	}

	private static int _000E(Type _000E)
	{
		return _000E.MetadataToken;
	}
}
internal struct _0005_200B_200B
{
	public Color _000E;

	public string _0003;

	public string _0006;

	public bool _000F;
}
internal sealed class _0006_2001_200B : Form
{
	private sealed class _000E
	{
		public uint _000E;

		internal bool _000E(_000E_2001_200B _000E)
		{
			return _000E._000E == this._000E;
		}
	}

	private readonly Func<_0006_2004_200A> m__000E;

	private readonly TabControl m__0003;

	private readonly DataGridView m__0006;

	private readonly DataGridView m__000F;

	private readonly System.Windows.Forms.Timer _0002;

	private string _0008;

	internal _0006_2001_200B(Func<_0006_2004_200A> _000E)
	{
		this.m__000E = _000E;
		Text = _0008_0017._000E(-1141309339);
		base.StartPosition = FormStartPosition.CenterParent;
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.TopMost = true;
		base.ShowInTaskbar = false;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.ClientSize = new Size(430, 360);
		this.m__0003 = new TabControl
		{
			Location = new Point(10, 10),
			Size = new Size(410, 300)
		};
		TabPage tabPage = new TabPage(_0008_0017._000E(-1141201110));
		TabPage tabPage2 = new TabPage(_0008_0017._000E(-1141201128));
		this.m__0006 = this._000E();
		this.m__000F = this._000E();
		tabPage.Controls.Add(this.m__0006);
		tabPage2.Controls.Add(this.m__000F);
		this.m__0003.TabPages.Add(tabPage);
		this.m__0003.TabPages.Add(tabPage2);
		base.Controls.Add(this.m__0003);
		Button button = new Button
		{
			Text = _0008_0017._000E(-1141263398),
			Location = new Point(10, 320),
			Size = new Size(80, 27)
		};
		button.Click += this._000E;
		base.Controls.Add(button);
		Button button2 = new Button
		{
			Text = _0008_0017._000E(-1141303145),
			Location = new Point(250, 320),
			Size = new Size(80, 27)
		};
		button2.Click += _0003;
		base.Controls.Add(button2);
		Button button3 = new Button
		{
			Text = _0008_0017._000E(-1141035021),
			Location = new Point(340, 320),
			Size = new Size(80, 27),
			DialogResult = DialogResult.Cancel
		};
		base.Controls.Add(button3);
		base.AcceptButton = button2;
		base.CancelButton = button3;
		_0002 = new System.Windows.Forms.Timer
		{
			Interval = 500
		};
		_0002.Tick += _0006;
		base.Shown += _000F;
		base.FormClosed += this._000E;
	}

	internal string _000E()
	{
		return _0008;
	}

	private void _000E(string _000E)
	{
		_0008 = _000E;
	}

	private DataGridView _000E()
	{
		DataGridView dataGridView = new DataGridView();
		dataGridView.Dock = DockStyle.Fill;
		dataGridView.ReadOnly = true;
		dataGridView.AllowUserToAddRows = false;
		dataGridView.AllowUserToDeleteRows = false;
		dataGridView.AllowUserToResizeRows = false;
		dataGridView.RowHeadersVisible = false;
		dataGridView.MultiSelect = false;
		dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView.BackgroundColor = SystemColors.Window;
		dataGridView.Columns.Add(new DataGridViewTextBoxColumn
		{
			Name = _0008_0017._000E(-1141298782),
			HeaderText = _0008_0017._000E(-1141036764),
			AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
		});
		dataGridView.Columns.Add(new DataGridViewTextBoxColumn
		{
			Name = _0008_0017._000E(-1141036780),
			HeaderText = _0008_0017._000E(-1141036780),
			Width = 110
		});
		dataGridView.CellDoubleClick += _000E;
		return dataGridView;
	}

	internal void _000E()
	{
		_0006_2004_200A obj = this.m__000E();
		_000E(this.m__0006, _0003_2001_200B._000E(obj, _0003: false));
		_000E(this.m__000F, _0003_2001_200B._000E(obj, _0003: true));
	}

	private static void _000E(DataGridView _000E, List<_000E_2001_200B> _0003)
	{
		uint? num = ((_000E.SelectedRows.Count == 0) ? ((uint?)null) : new uint?((uint)_000E.SelectedRows[0].Tag));
		_000E.Rows.Clear();
		foreach (_000E_2001_200B item in _0003)
		{
			int index = _000E.Rows.Add(item._0003, (!item._0002) ? _0008_0017._000E(-1141274422) : (item._000F ? _0008_0017._000E(-1141306917) : (item._0006 ? _0008_0017._000E(-1141036814) : _0008_0017._000E(-1141036793))));
			DataGridViewRow dataGridViewRow = _000E.Rows[index];
			dataGridViewRow.Tag = item._000E;
			if (item._0006)
			{
				dataGridViewRow.DefaultCellStyle.ForeColor = SystemColors.GrayText;
			}
		}
		_000E.ClearSelection();
		if (!num.HasValue)
		{
			return;
		}
		foreach (DataGridViewRow item2 in (IEnumerable)_000E.Rows)
		{
			if ((uint)item2.Tag == num.Value)
			{
				item2.Selected = true;
				break;
			}
		}
	}

	internal bool _000E(uint _000E, bool _0003)
	{
		_000E obj = new _000E();
		obj._000E = _000E;
		_000E_2001_200B obj2 = _0003_2001_200B._000E(this.m__000E(), _0003).FirstOrDefault(obj._000E);
		if (obj2 == null || obj2._0006)
		{
			return false;
		}
		this._000E(obj2._0003);
		return true;
	}

	private void _0003()
	{
		bool flag = this.m__0003.SelectedIndex == 1;
		DataGridView dataGridView = (flag ? this.m__000F : this.m__0006);
		if (dataGridView.SelectedRows.Count != 0 && _000E((uint)dataGridView.SelectedRows[0].Tag, flag))
		{
			base.DialogResult = DialogResult.OK;
			Close();
		}
	}

	private void _000E(object _000E, EventArgs _0003)
	{
		this._000E();
	}

	private void _0003(object _000E, EventArgs _0003)
	{
		this._0003();
	}

	private void _0006(object _000E, EventArgs _0003)
	{
		this._000E();
	}

	private void _000F(object _000E, EventArgs _0003)
	{
		this._000E();
		_0002.Start();
	}

	private void _000E(object _000E, FormClosedEventArgs _0003)
	{
		_0002.Dispose();
	}

	private void _000E(object _000E, DataGridViewCellEventArgs _0003)
	{
		if (_0003.RowIndex >= 0)
		{
			this._0003();
		}
	}
}
internal static class _0006_2002_200B
{
	[StructLayout(LayoutKind.Auto)]
	private struct _000E : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		public uint _000F;

		private TaskAwaiter<List<int>> _0002;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				TaskAwaiter<List<int>> awaiter;
				if (num == 0)
				{
					awaiter = _0002;
					_0002 = default(TaskAwaiter<List<int>>);
					num = (_000E = -1);
					goto IL_008e;
				}
				_0006_0018 obj = _0006._000E();
				if (obj != null && obj._000E_2007())
				{
					awaiter = _0005_2009_200A._000E(_0006, 6, 15).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 0);
						_0002 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_008e;
				}
				result = false;
				goto end_IL_0008;
				IL_008e:
				List<int> result2 = awaiter.GetResult();
				if (result2.Count == 0)
				{
					result = false;
				}
				else
				{
					int[] array = new int[result2.Count];
					for (int i = 0; i < result2.Count; i++)
					{
						array[i] = result2[i] - 5;
					}
					_0006_0018 obj2 = _0006._000E();
					if (obj2 == null || !obj2._000E_2007())
					{
						result = false;
					}
					else
					{
						obj2._0003((IEnumerable<int>)array);
						_0003_2002_200B obj3 = Volatile.Read(ref _0006_2002_200B.m__000E);
						if (obj3 == null)
						{
							result = false;
						}
						else
						{
							int num2 = 0;
							while (true)
							{
								if (num2 < array.Length)
								{
									int num3 = array[num2];
									if (obj3._000E(num3))
									{
										_0006_0018 obj4 = _0006._000E();
										if (obj4 == null || !obj4._000E_2007())
										{
											result = false;
											break;
										}
										int[] array2 = new int[1] { num3 };
										obj4._0002(_000F);
										obj4._000E((IEnumerable<int>)array2);
										_000E_2008_200A obj5 = null;
										IReadOnlyList<_000E_2008_200A> readOnlyList = _0006._000E()._000E();
										if (readOnlyList != null)
										{
											for (int j = 0; j < readOnlyList.Count; j++)
											{
												if (readOnlyList[j] != null && readOnlyList[j]._000E_2008 == _000F)
												{
													obj5 = readOnlyList[j];
													break;
												}
											}
										}
										_0005_2001_200A obj6 = _0006._000E()._000E();
										if (obj5 != null)
										{
											string.Format(_0008_0017._000E(-1141038716), obj5._0003_2008, obj5._0006_2008, obj5._000F_2008);
										}
										if (obj5 != null)
										{
											string.Format(_0008_0017._000E(-1141035768), obj5._0002, obj5._0008);
										}
										if (obj6 != null)
										{
											string.Format(_0008_0017._000E(-1141038716), obj6._0003, obj6._0006, obj6._000F);
										}
										result = true;
										break;
									}
									num2++;
									continue;
								}
								result = false;
								break;
							}
						}
					}
				}
				end_IL_0008:;
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	private static _0003_2002_200B m__000E;

	internal static _0003_2002_200B _000E()
	{
		return Volatile.Read(ref _0006_2002_200B.m__000E);
	}

	public static void _000E(IReadOnlyList<_0005_200B_200A> _000E)
	{
		Volatile.Write(ref _0006_2002_200B.m__000E, new _0003_2002_200B(_000E));
	}

	public static async Task<bool> _000E(_0006_2006 _000E, uint _0003)
	{
		_0006_0018 obj = _000E._000E();
		if (obj == null || !obj._000E_2007())
		{
			return false;
		}
		List<int> list = await _0005_2009_200A._000E(_000E, 6, 15);
		if (list.Count == 0)
		{
			return false;
		}
		int[] array = new int[list.Count];
		for (int i = 0; i < list.Count; i++)
		{
			array[i] = list[i] - 5;
		}
		_0006_0018 obj2 = _000E._000E();
		if (obj2 == null || !obj2._000E_2007())
		{
			return false;
		}
		obj2._0003((IEnumerable<int>)array);
		_0003_2002_200B obj3 = Volatile.Read(ref _0006_2002_200B.m__000E);
		if (obj3 == null)
		{
			return false;
		}
		foreach (int num in array)
		{
			if (!obj3._000E(num))
			{
				continue;
			}
			_0006_0018 obj4 = _000E._000E();
			if (obj4 == null || !obj4._000E_2007())
			{
				return false;
			}
			int[] array2 = new int[1] { num };
			obj4._0002(_0003);
			obj4._000E((IEnumerable<int>)array2);
			_000E_2008_200A obj5 = null;
			IReadOnlyList<_000E_2008_200A> readOnlyList = _000E._000E()._000E();
			if (readOnlyList != null)
			{
				for (int k = 0; k < readOnlyList.Count; k++)
				{
					if (readOnlyList[k] != null && readOnlyList[k]._000E_2008 == _0003)
					{
						obj5 = readOnlyList[k];
						break;
					}
				}
			}
			_0005_2001_200A obj6 = _000E._000E()._000E();
			if (obj5 != null)
			{
				string.Format(_0008_0017._000E(-1141038716), obj5._0003_2008, obj5._0006_2008, obj5._000F_2008);
			}
			if (obj5 != null)
			{
				string.Format(_0008_0017._000E(-1141035768), obj5._0002, obj5._0008);
			}
			if (obj6 != null)
			{
				string.Format(_0008_0017._000E(-1141038716), obj6._0003, obj6._0006, obj6._000F);
			}
			return true;
		}
		return false;
	}

	public static void _000E()
	{
		Volatile.Write(ref _0006_2002_200B.m__000E, null);
	}
}
internal static class _0006_2003_200B
{
	internal static float _000E(int _000E)
	{
		return (float)_000E / 10f;
	}

	internal static void _000E(ref _000F_2003_200B _000E, int _0003)
	{
		_000E._000E = true;
		_000E._0003 = _0006_2003_200B._000E(_0003);
		_000E._0006++;
	}

	internal static bool _000E(_0002_2003_200B _000E, _0002_0017 _0003, bool _0006)
	{
		if (_0006 && !_000E._0002)
		{
			if (_0003 != _0002_0017.Selected)
			{
				return _0003 == _0002_0017.Started;
			}
			return true;
		}
		return false;
	}

	internal static void _000E(ref _0002_2003_200B _000E)
	{
		_000E._0002 = true;
	}

	internal static void _000E(ref _0002_2003_200B _000E, _000E_2007_200A _0003)
	{
		if (_0003 != null)
		{
			_000E._0008 = _0003._000E;
			_000E._0005 = _0003._0003;
			if (!_0003._000E || !_0003._0003)
			{
				_000E._000F = null;
			}
			else if (_0003._000F.HasValue)
			{
				_000E._000F = _0003._000F;
			}
		}
	}

	internal static _0003_2003_200B _000E(_000F_2003_200B _000E, _0002_2003_200B _0003, _0002_0017 _0006, bool _000F)
	{
		if (!_000F || !_000E._000E || _0003._000E != 0 || _0003._0006 == _000E._0006 || (_0006 != _0002_0017.Selected && _0006 != _0002_0017.Started))
		{
			return default(_0003_2003_200B);
		}
		return new _0003_2003_200B
		{
			_000E = true,
			_0003 = _000E._0003,
			_0006 = _000E._0006
		};
	}

	internal static void _000E(ref _0002_2003_200B _000E, _0003_2003_200B _0003, uint _0006, long _000F)
	{
		_000E._000E = _0006;
		_000E._0003 = _000F;
		_000E._0006 = _0003._0006;
	}

	internal static void _0003(ref _0002_2003_200B _000E)
	{
		_000E._000E = 0u;
	}

	internal static bool _000E(ref _0002_2003_200B _000E, long _0003)
	{
		if (_000E._000E == 0 || _0003 < _000E._0003 || _0003 - _000E._0003 < 2000)
		{
			return false;
		}
		_000E._000E = 0u;
		return true;
	}

	internal static bool _000E(ref _0002_2003_200B _000E, _0005_2008_200A _0003)
	{
		if (_0003 == null || _0003._0003 == 0 || _0003._0003 != _000E._000E)
		{
			return false;
		}
		_000E._000E = 0u;
		_000E._000F = (_0003._000E ? _0003._0006 : ((float?)null));
		return true;
	}

	internal static bool _0003(ref _0002_2003_200B _000E, _0005_2008_200A _0003)
	{
		if (_0003 == null || _0003._0003 != 0 || !_0003._000E || !_0003._0006.HasValue)
		{
			return false;
		}
		_000E._0008 = _0003._0002;
		_000E._0005 = _0003._0002;
		_000E._000F = _0003._0006;
		return true;
	}

	internal static string _000E(float? _000E)
	{
		if (!_000E.HasValue)
		{
			return _0008_0017._000E(-1141280428);
		}
		return _0008_0017._000E(-1141035439) + _000E.Value.ToString(_0008_0017._000E(-1141035443), CultureInfo.InvariantCulture) + _0008_0017._000E(-1141255982);
	}

	internal static void _0006(ref _0002_2003_200B _000E)
	{
		int num = _000E._0006;
		_000E = new _0002_2003_200B
		{
			_0006 = num
		};
	}
}
internal static class _0006_2004_200B
{
	internal static string _000E()
	{
		return _0006_2002._0002();
	}

	internal static string _000E(bool _000E, bool _0003, string _0006, string _000F, string _0002)
	{
		List<string> list = new List<string>(3);
		string text = _0006_2004_200B._000E(_0006);
		string text2 = _0006_2004_200B._000E(_000F);
		string text3 = _0006_2004_200B._000E(_0002);
		if (_000E && text.Length != 0)
		{
			list.Add(text);
		}
		if (_0003 && text2.Length != 0)
		{
			list.Add(text2);
		}
		list.Add((text3.Length == 0) ? _0006_2004_200B._000E() : text3);
		return string.Join(_0008_0017._000E(-1141036199), list.ToArray());
	}

	private static string _000E(string _000E)
	{
		if (!string.IsNullOrWhiteSpace(_000E))
		{
			return _000E.Trim();
		}
		return string.Empty;
	}
}
internal struct _0006_2006_200B
{
	public bool _000E;
}
internal sealed class _0006_2007_200B
{
	private sealed class _0003 : IDisposable
	{
		private readonly _0006_2007_200B _000E;

		private int m__0003;

		internal _0003(_0006_2007_200B _000E)
		{
			this._000E = _000E;
		}

		public void Dispose()
		{
			if (Interlocked.Exchange(ref m__0003, 1) == 0)
			{
				_0006_2007_200B.m__000E.Value = _000E;
			}
		}
	}

	[Serializable]
	private sealed class _000E
	{
		public static readonly _000E _000E = new _000E();

		public static Func<int, Task> _0003;

		public static Func<_0006_0018, bool> _0006;

		internal Task _000E(int _000E)
		{
			return Task.CompletedTask;
		}

		internal bool _000E(_0006_0018 _000E)
		{
			return _000E._0006_2007();
		}

		internal bool _0003(_0006_0018 _000E)
		{
			return _000E._0003_2007();
		}

		internal Task _0003(int _000E)
		{
			return Task.Delay(_000E);
		}
	}

	private static readonly AsyncLocal<_0006_2007_200B> m__000E = new AsyncLocal<_0006_2007_200B>();

	private static readonly _0006_2007_200B m__0003 = new _0006_2007_200B(Stopwatch.GetTimestamp, Stopwatch.Frequency, _0006_2007_200B._000E._000E._0003, null, _0006_2007_200B._000E._000E._0003, _0006_2007_200B._000E);

	private static readonly object _0006 = new object();

	private static readonly Random _000F = new Random();

	internal readonly Func<long> _0002;

	internal readonly long _0008;

	private readonly Func<_0006_0018, bool> _0005;

	private readonly Action _000E_2008;

	private readonly Func<int, Task> _0003_2008;

	private readonly Func<int, int, int> _0006_2008;

	private _0006_2007_200B(Func<long> _000E, long _0003, Func<_0006_0018, bool> _0006, Action _000F, Func<int, Task> _0002, Func<int, int, int> _0008)
	{
		if (_000E == null)
		{
			throw new ArgumentNullException(_0008_0017._000E(-1141035588));
		}
		if (_0003 <= 0)
		{
			throw new ArgumentOutOfRangeException(_0008_0017._000E(-1141035607));
		}
		if (_0006 == null)
		{
			throw new ArgumentNullException(_0008_0017._000E(-1141035610));
		}
		if (_0002 == null)
		{
			throw new ArgumentNullException(_0008_0017._000E(-1141035629));
		}
		if (_0008 == null)
		{
			throw new ArgumentNullException(_0008_0017._000E(-1141035640));
		}
		this._0002 = _000E;
		this._0008 = _0003;
		_0005 = _0006;
		_000E_2008 = _000F;
		_0003_2008 = _0002;
		_0006_2008 = _0008;
	}

	internal static _0006_2007_200B _000E()
	{
		return _0006_2007_200B.m__000E.Value ?? _0006_2007_200B.m__0003;
	}

	internal static IDisposable _000E(Func<long> _000E, long _0003)
	{
		return _0006_2007_200B._000E(_000E, _0003, null);
	}

	internal static IDisposable _000E(Func<long> _000E, long _0003, Action _0006)
	{
		return _0006_2007_200B._000E(_000E, _0003, _0006, _0006_2007_200B._000E._000E._000E, _0006_2007_200B._000E);
	}

	internal static IDisposable _000E(Func<long> _000E, long _0003, Action _0006, Func<int, Task> _000F, Func<int, int, int> _0002)
	{
		_0006_2007_200B value = _0006_2007_200B.m__000E.Value;
		_0006_2007_200B.m__000E.Value = new _0006_2007_200B(_000E, _0003, _0006_2007_200B._000E._000E._000E, _0006, _000F, _0002);
		return new _0003(value);
	}

	internal bool _000E(_0006_0018 _000E)
	{
		if (_000E != null)
		{
			return _0005(_000E);
		}
		return false;
	}

	internal void _000E()
	{
		if (_000E_2008 != null)
		{
			_000E_2008();
		}
	}

	internal Task _000E(int _000E)
	{
		return _0003_2008(_000E);
	}

	internal int _000E(int _000E, int _0003)
	{
		return _0006_2008(_000E, _0003);
	}

	private static int _000E(int _000E, int _0003)
	{
		lock (_0006)
		{
			return _000F.Next(_000E, _0003);
		}
	}
}
internal static class _0006_2008_200B
{
	internal static bool _000E(long _000E, long _0003)
	{
		if (_000E >= 0)
		{
			return _0003 - _000E >= 1000;
		}
		return true;
	}

	internal static string _000E(_000E_2007_200B _000E, long _0003)
	{
		if (_000E == null)
		{
			return _0008_0017._000E(-1141038251);
		}
		return _0008_0017._000E(-1141038295) + _000E._000E.ToString(CultureInfo.InvariantCulture) + _0008_0017._000E(-1141038315) + _0006_2008_200B._000E(_000E._0003) + _0008_0017._000E(-1141038329) + (_000E._0006 ? _0008_0017._000E(-1141210092) : _0008_0017._000E(-1141210088)) + _0008_0017._000E(-1141038345) + (_000E._0003_2008 ? _000E._000E_2008.ToString(CultureInfo.InvariantCulture) : _0008_0017._000E(-1141037869)) + _0008_0017._000E(-1141038367) + _0006_2008_200B._000E(_000E._000F, _000E._0002, _000E._0008) + _0008_0017._000E(-1141181453) + _0006_2008_200B._000E(_000E._0002_2008, _000E._0006_2008, _000E._000F_2008) + _0008_0017._000E(-1141181808) + _0003.ToString(CultureInfo.InvariantCulture);
	}

	internal static string _000E(IReadOnlyList<_000E_2007_200B> _000E, DateTime _0003)
	{
		int num = _000E?.Count ?? 0;
		string text = _0008_0017._000E(-1141038371) + num.ToString(CultureInfo.InvariantCulture);
		for (int i = 0; i < num; i++)
		{
			_000E_2007_200B obj = _000E[i];
			if (obj != null)
			{
				long num2 = Math.Max(0L, (_0003.Ticks - obj._0005) / 10000);
				text = text + _0008_0017._000E(-1141038395) + obj._000E.ToString(CultureInfo.InvariantCulture) + _0008_0017._000E(-1141038315) + _0006_2008_200B._000E(obj._0003) + _0008_0017._000E(-1141038329) + (obj._0006 ? _0008_0017._000E(-1141210092) : _0008_0017._000E(-1141210088)) + _0008_0017._000E(-1141038345) + (obj._0003_2008 ? obj._000E_2008.ToString(CultureInfo.InvariantCulture) : _0008_0017._000E(-1141037869)) + _0008_0017._000E(-1141038367) + _0006_2008_200B._000E(obj._000F, obj._0002, obj._0008) + _0008_0017._000E(-1141181453) + _0006_2008_200B._000E(obj._0002_2008, obj._0006_2008, obj._000F_2008) + _0008_0017._000E(-1141038416) + num2.ToString(CultureInfo.InvariantCulture);
			}
		}
		return text;
	}

	internal static string _000E(_0002_2008_200B _000E, _0005_2001_200A _0003, float _0006, float _000F, float _0002, bool _0008, float _0005, float _000E_2008)
	{
		if (_000E == null || _0003 == null)
		{
			return _0008_0017._000E(-1141038431);
		}
		return _0008_0017._000E(-1141038460) + (_000E._0008 ? _0008_0017._000E(-1141038511) : _0008_0017._000E(-1141038501)) + _0008_0017._000E(-1141181596) + _000E._000E.ToString(CultureInfo.InvariantCulture) + _0008_0017._000E(-1141038315) + _0006_2008_200B._000E(_000E._0003) + _0008_0017._000E(-1141038516) + (_000E._0003_2008 ? _000E._000E_2008.ToString(CultureInfo.InvariantCulture) : _0008_0017._000E(-1141037869)) + _0008_0017._000E(-1141038531) + (_0008 ? _0008_0017._000E(-1141210092) : _0008_0017._000E(-1141210088)) + _0008_0017._000E(-1141181675) + _0006_2008_200B._000E(_0003._0003, _0003._0006, _0003._000F) + _0008_0017._000E(-1141038546) + _0006_2008_200B._000E(_000E._0006, _000E._000F, _000E._0002) + _0008_0017._000E(-1141038567) + _0006_2008_200B._000E(_0006, _000F, _0002) + _0008_0017._000E(-1141038572) + _0005.ToString(_0008_0017._000E(-1141274464), CultureInfo.InvariantCulture) + _0008_0017._000E(-1141038592) + _000E_2008.ToString(_0008_0017._000E(-1141274464), CultureInfo.InvariantCulture) + _0008_0017._000E(-1141035535) + _000E._0005.ToString(CultureInfo.InvariantCulture);
	}

	private static string _000E(float _000E, float _0003, float _0006)
	{
		return _0008_0017._000E(-1141114314) + _000E.ToString(_0008_0017._000E(-1141274464), CultureInfo.InvariantCulture) + _0008_0017._000E(-1141326297) + _0003.ToString(_0008_0017._000E(-1141274464), CultureInfo.InvariantCulture) + _0008_0017._000E(-1141326297) + _0006.ToString(_0008_0017._000E(-1141274464), CultureInfo.InvariantCulture) + _0008_0017._000E(-1141308401);
	}

	private static string _000E(string _000E)
	{
		return (_000E ?? string.Empty).Replace(_0008_0017._000E(-1141304355), _0008_0017._000E(-1141298972));
	}

	private static string _000E(bool _000E, byte _0003, ushort _0006)
	{
		if (_000E)
		{
			if (_0006 != 0)
			{
				return _0003.ToString(CultureInfo.InvariantCulture) + _0008_0017._000E(-1141297577) + _0006.ToString(CultureInfo.InvariantCulture);
			}
			return _0008_0017._000E(-1141037869);
		}
		return _0008_0017._000E(-1141221057);
	}
}
internal static class _0006_2009_200B
{
}
internal sealed class _0006_200B_200B
{
	internal float _000E = 40f;

	private float m__0003;

	private float _0006;

	private bool _000F;

	private int _0002;

	internal int _000E()
	{
		return _0002;
	}

	private void _000E(int _000E)
	{
		_0002 = _000E;
	}

	internal bool _000E()
	{
		return this._000E() != 0;
	}

	internal void _0003(int _000E)
	{
		this._000E(_000E);
		_000F = false;
	}

	internal void _000E()
	{
		_000E(0);
		_000F = false;
	}

	internal bool _000E(float _000E, float _0003)
	{
		if (!this._000E())
		{
			return false;
		}
		if (_000F)
		{
			float num = _000E - this.m__0003;
			float num2 = _0003 - _0006;
			if (num * num + num2 * num2 < this._000E * this._000E)
			{
				return false;
			}
		}
		this.m__0003 = _000E;
		_0006 = _0003;
		_000F = true;
		return true;
	}
}
internal static class _0008_2001_200B
{
	internal static string _000E(IEnumerable<_000F_200B_200B> _000E, DateTime _0003)
	{
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		List<_000E_200B_200B> list = new List<_000E_200B_200B>();
		if (_000E != null)
		{
			foreach (_000F_200B_200B item in _000E)
			{
				if (item == null || item._0003 == null || item._0006 == null || item._000F == null)
				{
					continue;
				}
				int num = item._0003.Length;
				if (num != 0 && item._0006.Length == num && item._000F.Length == num)
				{
					List<_0003_200B_200B> list2 = new List<_0003_200B_200B>(num);
					for (int i = 0; i < num; i++)
					{
						list2.Add(new _0003_200B_200B
						{
							_000F = item._0003[i],
							_0002 = item._0006[i],
							_0008 = item._000F[i]
						});
					}
					list.Add(new _000E_200B_200B
					{
						_0006 = item._000E,
						_000F = list2
					});
				}
			}
		}
		return JsonConvert.SerializeObject((object)new _0005_2001_200B
		{
			_0006 = _0003,
			_000F = list
		}, (Formatting)1, new JsonSerializerSettings
		{
			NullValueHandling = (NullValueHandling)1
		});
	}

	internal static List<_000F_200B_200B> _000E(string _000E)
	{
		if (string.IsNullOrEmpty(_000E))
		{
			return null;
		}
		_0005_2001_200B obj;
		try
		{
			obj = JsonConvert.DeserializeObject<_0005_2001_200B>(_000E);
		}
		catch (JsonException)
		{
			return null;
		}
		if (obj == null || obj._000F == null)
		{
			return null;
		}
		List<_000F_200B_200B> list = new List<_000F_200B_200B>();
		foreach (_000E_200B_200B item in obj._000F)
		{
			if (item == null || item._000F == null || item._000F.Count == 0)
			{
				continue;
			}
			List<float> list2 = new List<float>();
			List<float> list3 = new List<float>();
			List<float> list4 = new List<float>();
			foreach (_0003_200B_200B item2 in item._000F)
			{
				if (item2 != null)
				{
					list2.Add(item2._000F);
					list3.Add(item2._0002);
					list4.Add(item2._0008.GetValueOrDefault());
				}
			}
			if (list2.Count != 0)
			{
				list.Add(new _000F_200B_200B
				{
					_000E = item._0006,
					_0003 = list2.ToArray(),
					_0006 = list3.ToArray(),
					_000F = list4.ToArray()
				});
			}
		}
		return list;
	}
}
internal struct _0008_2002_200B
{
	public float _000E;

	public float _0003;

	public float _0006;

	public int _000F;

	public bool _0002;

	public int _0008;
}
internal struct _0008_2003_200B
{
	internal int[] _000E;

	internal int[] _0003;

	internal int[] _0006;

	internal int[] _000F;
}
public sealed class _0008_2004_200B : ProgressBar
{
	public Color _000E = Color.Yellow;

	public Color _0003 = Color.Green;

	public int _0006 = 100;

	public int _000F;

	private readonly Label _0002;

	public _0008_2004_200B()
	{
		DoubleBuffered = true;
		SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
		_0002 = new Label
		{
			AutoSize = false,
			TextAlign = ContentAlignment.MiddleCenter,
			Dock = DockStyle.Fill,
			BackColor = Color.Transparent
		};
		base.Controls.Add(_0002);
	}

	protected override void OnPaint(PaintEventArgs _000E)
	{
		base.OnPaint(_000E);
		this._000E(_000E.Graphics);
	}

	internal void _000E(Graphics _000E)
	{
		_ = base.ClientRectangle;
		int num = ((_0006 <= 0) ? 1 : _0006);
		int num2 = (int)((float)_000F / (float)num * (float)base.Width);
		if (num2 < 0)
		{
			num2 = 0;
		}
		if (num2 > base.Width)
		{
			num2 = base.Width;
		}
		if (num2 > 0)
		{
			if (this._000E == _0003)
			{
				SolidBrush solidBrush = new SolidBrush(this._000E);
				try
				{
					_000E.FillRectangle(solidBrush, 0, 0, num2, base.Height);
				}
				finally
				{
					((IDisposable)solidBrush).Dispose();
				}
			}
			else
			{
				LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(num2, 0), this._000E, _0003);
				try
				{
					_000E.FillRectangle(linearGradientBrush, 0, 0, num2, base.Height);
				}
				finally
				{
					((IDisposable)linearGradientBrush).Dispose();
				}
			}
		}
		Pen pen = new Pen(Color.Black);
		try
		{
			_000E.DrawRectangle(pen, 0, 0, base.Width - 1, base.Height - 1);
		}
		finally
		{
			((IDisposable)pen).Dispose();
		}
	}

	public void _000E(int _000E, string _0003)
	{
		_000F = Math.Max(0, Math.Min(_000E, _0006));
		if (_0003 != null)
		{
			_0002.Text = _0003;
		}
		Invalidate();
	}

	public static _0008_2004_200B _000E(Control _000E, Color _0003, Color _0006, int _000F, int _0002, int _0008, int _0005, TabControl _000E_2008, int _0003_2008)
	{
		_0008_2004_200B result = new _0008_2004_200B
		{
			Location = new Point(_000F, _0002),
			Size = new Size(_0008, _0005),
			_0006 = 100,
			_000E = _0003,
			_0003 = _0006
		};
		if (_000E_2008 != null && _0003_2008 >= 0 && _0003_2008 < _000E_2008.TabPages.Count)
		{
			_000E_2008.TabPages[_0003_2008].Controls.Add(result);
		}
		else
		{
			_000E.Controls.Add(result);
		}
		return result;
	}
}
internal sealed class _0008_2006_200B : Form
{
	private readonly _0006_0018 m__000E;

	private readonly Label m__0003;

	private readonly Label _0006;

	private readonly ProgressBar _000F;

	private readonly System.Windows.Forms.Timer _0002;

	private readonly Stopwatch _0008 = new Stopwatch();

	private readonly int _0005;

	private readonly string _000E_2008;

	private long _0003_2008 = -1L;

	private Font[] _0006_2008;

	private _0005_0018._000E _000F_2008;

	private IReadOnlyList<_000F_2008_200A> _0002_2008;

	private int _0008_2008;

	private string _0005_2008;

	internal _0008_2006_200B(_0006_0018 _000E)
	{
		this.m__000E = _000E;
		this._000E((_0005_0018._000E)0);
		this._000E(new _000F_2008_200A[0]);
		this._000E(string.Empty);
		_0006_2004_200A obj = ((_000E == null) ? _0006_2004_200A._0006_2008 : _000E._000E());
		_0005 = obj._000E_2008();
		_000E_2008 = obj._000E_2008();
		Text = _0008_0017._000E(-1141035025);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.StartPosition = FormStartPosition.CenterParent;
		base.ControlBox = false;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.ShowInTaskbar = false;
		base.ClientSize = new Size(420, 170);
		BackColor = Color.FromArgb(30, 30, 30);
		ForeColor = Color.Gainsboro;
		Font font = new Font(_0008_0017._000E(-1141265716), 11f);
		Font font2 = new Font(_0008_0017._000E(-1141265716), 9f);
		Font font3 = new Font(_0008_0017._000E(-1141265716), 8.5f);
		_0006_2008 = new Font[3] { font, font2, font3 };
		this.m__0003 = new Label();
		this.m__0003.Text = _0008_0017._000E(-1141035063);
		this.m__0003.Location = new Point(0, 26);
		this.m__0003.Size = new Size(420, 26);
		this.m__0003.TextAlign = ContentAlignment.MiddleCenter;
		this.m__0003.Font = font;
		base.Controls.Add(this.m__0003);
		_0006 = new Label();
		_0006.Text = _0005_0018._000E(0L);
		_0006.Location = new Point(0, 54);
		_0006.Size = new Size(420, 22);
		_0006.TextAlign = ContentAlignment.MiddleCenter;
		_0006.ForeColor = Color.Gray;
		_0006.Font = font2;
		base.Controls.Add(_0006);
		_000F = new ProgressBar();
		_000F.Location = new Point(60, 88);
		_000F.Size = new Size(300, 23);
		_000F.Style = ProgressBarStyle.Marquee;
		_000F.MarqueeAnimationSpeed = 30;
		base.Controls.Add(_000F);
		Label value = new Label
		{
			Text = _0008_0017._000E(-1141035096),
			Location = new Point(0, 122),
			Size = new Size(420, 22),
			TextAlign = ContentAlignment.MiddleCenter,
			ForeColor = Color.Gray,
			Font = font3
		};
		base.Controls.Add(value);
		_0002 = new System.Windows.Forms.Timer();
		_0002.Interval = 250;
		_0002.Tick += _0003;
		base.Shown += this._000E;
	}

	internal _0005_0018._000E _000E()
	{
		return _000F_2008;
	}

	private void _000E(_0005_0018._000E _000E)
	{
		_000F_2008 = _000E;
	}

	internal IReadOnlyList<_000F_2008_200A> _000E()
	{
		return _0002_2008;
	}

	private void _000E(IReadOnlyList<_000F_2008_200A> _000E)
	{
		_0002_2008 = _000E;
	}

	internal int _000E()
	{
		return _0008_2008;
	}

	private void _000E(int _000E)
	{
		_0008_2008 = _000E;
	}

	internal string _000E()
	{
		return _0005_2008;
	}

	private void _000E(string _000E)
	{
		_0005_2008 = _000E;
	}

	private void _000E(object _000E, EventArgs _0003)
	{
		_0008.Start();
		_0002.Start();
		this._0003(this, EventArgs.Empty);
	}

	private void _0003(object _000E, EventArgs _0003)
	{
		if (base.IsDisposed)
		{
			return;
		}
		if (this.m__000E == null)
		{
			this._000E((_0005_0018._000E)4, _0006_2004_200A._0006_2008);
			return;
		}
		long elapsedMilliseconds = _0008.ElapsedMilliseconds;
		_0006_2004_200A obj = this.m__000E._000E();
		_0005_0018._000E obj2 = _0005_0018._000E(_0005_0018._000E(obj._000E_2008(), obj._000E_2008(), _0005, _000E_2008), obj._0005(), obj._000E_2008(), elapsedMilliseconds);
		if (obj2 != 0)
		{
			this._000E(obj2, obj);
			return;
		}
		string text = _0005_0018._000E(elapsedMilliseconds);
		if (_0006.Text != text)
		{
			_0006.Text = text;
		}
		if (_0005_0018._000E(_0003_2008, elapsedMilliseconds))
		{
			_0003_2008 = elapsedMilliseconds;
			this.m__000E._0002_2007();
		}
	}

	private void _000E(_0005_0018._000E _000E, _0006_2004_200A _0003)
	{
		_0002.Stop();
		this._000E(_000E);
		this._000E(_0003._000E());
		this._000E(_0003._0003_2008());
		this._000E(_0003._000E_2008() ?? string.Empty);
		Close();
	}

	protected override void OnFormClosed(FormClosedEventArgs _000E)
	{
		_0002.Stop();
		_0002.Tick -= _0003;
		_0002.Dispose();
		base.Shown -= this._000E;
		_0008.Stop();
		_000F.MarqueeAnimationSpeed = 0;
		base.OnFormClosed(_000E);
	}

	protected override void Dispose(bool _000E)
	{
		base.Dispose(_000E);
		if (!_000E || _0006_2008 == null)
		{
			return;
		}
		for (int i = 0; i < _0006_2008.Length; i++)
		{
			if (_0006_2008[i] != null)
			{
				_0006_2008[i].Dispose();
			}
		}
		_0006_2008 = null;
	}
}
internal struct _0008_2007_200B
{
	public int _000E;

	public int _0003;

	public ushort _0006;

	public ushort _000F;

	public string _0002;
}
internal sealed class _0008_2008_200B
{
	internal uint _000E;

	internal float _0003;

	internal float _0006;

	internal float _000F;

	internal int _0002;
}
internal static class _0008_2009_200B
{
}
internal struct _0008_200B_200B
{
	public bool _000E;

	public bool _0003;

	public bool _0006;

	public bool _000F;
}
internal sealed class _000E_2001_200B
{
	internal uint _000E;

	internal string _0003;

	internal bool _0006;

	internal bool _000F;

	internal bool _0002;
}
internal static class _000E_2002_200B
{
	[StructLayout(LayoutKind.Auto)]
	private struct _0003 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		private int _000F;

		private TaskAwaiter _0002;

		private TaskAwaiter<int> _0008;

		private void MoveNext()
		{
			int num = _000E;
			bool result2;
			try
			{
				TaskAwaiter<int> awaiter2;
				TaskAwaiter awaiter;
				int result;
				switch (num)
				{
				default:
					awaiter = Task.Delay(100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 0);
						_0002 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_006e;
				case 0:
					awaiter = _0002;
					_0002 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_006e;
				case 1:
					awaiter2 = _0008;
					_0008 = default(TaskAwaiter<int>);
					num = (_000E = -1);
					goto IL_00dd;
				case 2:
					{
						awaiter = _0002;
						_0002 = default(TaskAwaiter);
						num = (_000E = -1);
						break;
					}
					IL_00dd:
					result = awaiter2.GetResult();
					_000F = result;
					awaiter = Task.Delay(100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 2);
						_0002 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
					IL_006e:
					awaiter.GetResult();
					if (_0006 != null)
					{
						awaiter2 = _000E_2002_200B._000E(_0006).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 1);
							_0008 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_00dd;
					}
					result2 = false;
					goto end_IL_0007;
				}
				awaiter.GetResult();
				result2 = _000F > 0;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult(result2);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _0006 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<int> _0003;

		public _0006_2006 _0006;

		private _000E _000F;

		private ushort _0002;

		private List<_0008_2007_200B> _0008;

		private int _0005;

		private int _000E_2008;

		private TaskAwaiter<string> _0003_2008;

		private TaskAwaiter<IReadOnlyList<string>> _0006_2008;

		private TaskAwaiter _000F_2008;

		private List<_0008_2007_200B>.Enumerator _0002_2008;

		private int _0008_2008;

		private int _0005_2008;

		private void MoveNext()
		{
			int num = _000E;
			int result;
			try
			{
				TaskAwaiter<string> awaiter3;
				TaskAwaiter<IReadOnlyList<string>> awaiter2;
				string result2;
				uint num2;
				IReadOnlyList<string> result3;
				TaskAwaiter awaiter;
				switch (num)
				{
				default:
					if (_0006 != null)
					{
						awaiter3 = _000E_2000_200A._000E(_0006, 61).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = (_000E = 0);
							_0003_2008 = awaiter3;
							_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_008e;
					}
					result = 0;
					goto end_IL_0007;
				case 0:
					awaiter3 = _0003_2008;
					_0003_2008 = default(TaskAwaiter<string>);
					num = (_000E = -1);
					goto IL_008e;
				case 1:
					awaiter2 = _0006_2008;
					_0006_2008 = default(TaskAwaiter<IReadOnlyList<string>>);
					num = (_000E = -1);
					goto IL_014f;
				case 2:
					awaiter = _000F_2008;
					_000F_2008 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_01d7;
				case 3:
				case 4:
					break;
					IL_008e:
					result2 = awaiter3.GetResult();
					if (!_000E(_0006, result2, out num2))
					{
						result = 0;
					}
					else if (!_000E(num2, out _0002))
					{
						result = 0;
					}
					else
					{
						if (!(_000E(_0006, result2, num2) > 30f))
						{
							_0006._000E()._0003();
							awaiter2 = _000E_2000_200A._000E(_0006).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_000E = 1);
								_0006_2008 = awaiter2;
								_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_014f;
						}
						result = 0;
					}
					goto end_IL_0007;
					IL_01d7:
					awaiter.GetResult();
					_0005 = 0;
					_000E_2008 = 0;
					_0002_2008 = _0008.GetEnumerator();
					break;
					IL_014f:
					result3 = awaiter2.GetResult();
					_0008 = _000E(_0006, result3);
					if (_0008.Count != 0)
					{
						awaiter = Task.Delay(300).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 2);
							_000F_2008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01d7;
					}
					result = 0;
					goto end_IL_0007;
				}
				try
				{
					if (num != 3)
					{
						if (num != 4)
						{
							goto IL_04be;
						}
						awaiter = _000F_2008;
						_000F_2008 = default(TaskAwaiter);
						num = (_000E = -1);
						goto IL_04b0;
					}
					awaiter = _000F_2008;
					_000F_2008 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_0325;
					IL_0325:
					awaiter.GetResult();
					_0005_2008++;
					goto IL_033c;
					IL_04b0:
					awaiter.GetResult();
					_000F = null;
					goto IL_04be;
					IL_033c:
					if (_0005_2008 < 50 && !_0006._0006() && _0006._000E()._0002() == _0008_2008 && _0006._000E()._000F() == string.Empty)
					{
						awaiter = Task.Delay(100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 3);
							_000F_2008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0325;
					}
					if (!_0006._0006() && _0006._000E() != null && !(_0006._000E()._000F() != string.Empty) && _0006._000E()._0002() != _0008_2008)
					{
						IEnumerator<_0003_200B_200A> enumerator = _0006._000E()._000E().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								_ = enumerator.Current;
							}
						}
						finally
						{
							if (num < 0)
							{
								enumerator?.Dispose();
							}
						}
						if (_0006._000E()._000E().Any(_000F._000E))
						{
							_0005++;
						}
						awaiter = Task.Delay(500).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 4);
							_000F_2008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_04b0;
					}
					result = _0005;
					goto end_IL_0007;
					IL_04be:
					if (!_0002_2008.MoveNext())
					{
						goto end_IL_01fe;
					}
					_000F = new _000E();
					_000F._000E = _0002_2008.Current;
					_000E_2008++;
					if (_0006._000E() != null)
					{
						_0008_2008 = _0006._000E()._0002();
						_0006._000E()._000E(_0002, _000F._000E._000E, _000F._000E._0003, _000F._000E._0006, _000F._000E._000F);
						_0005_2008 = 0;
						goto IL_033c;
					}
					result = _0005;
					goto end_IL_0007;
					end_IL_01fe:;
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)_0002_2008/*cast due to .constrained prefix*/).Dispose();
					}
				}
				_0002_2008 = default(List<_0008_2007_200B>.Enumerator);
				result = _0005;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0008 = null;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0008 = null;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	private sealed class _000E
	{
		public _0008_2007_200B _000E;

		internal bool _000E(_0003_200B_200A _000E)
		{
			if (_000E._000E == this._000E._000E && _000E._0003 == this._000E._0003 && _000E._0006 == this._000E._0006 && _000E._000F == this._000E._000F)
			{
				return _000E._000E_2008 == _0008_0017._000E(-1141112980);
			}
			return false;
		}
	}

	public static async Task<bool> _000E(_0006_2006 _000E)
	{
		await Task.Delay(100);
		if (_000E == null)
		{
			return false;
		}
		int num = await _000E_2002_200B._000E(_000E);
		await Task.Delay(100);
		return num > 0;
	}

	private static async Task<int> _000E(_0006_2006 _000E)
	{
		if (_000E == null)
		{
			return 0;
		}
		string text = await _000E_2000_200A._000E(_000E, 61);
		if (!_000E_2002_200B._000E(_000E, text, out var num))
		{
			return 0;
		}
		if (!_000E_2002_200B._000E(num, out var num2))
		{
			return 0;
		}
		if (_000E_2002_200B._000E(_000E, text, num) > 30f)
		{
			return 0;
		}
		_000E._000E()._0003();
		List<_0008_2007_200B> list = _000E_2002_200B._000E(_000E, await _000E_2000_200A._000E(_000E));
		if (list.Count == 0)
		{
			return 0;
		}
		await Task.Delay(300);
		int num3 = 0;
		int num4 = 0;
		using (List<_0008_2007_200B>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_000E obj = new _000E
				{
					_000E = enumerator.Current
				};
				num4++;
				if (_000E._000E() == null)
				{
					return num3;
				}
				int num5 = _000E._000E()._0002();
				_000E._000E()._000E(num2, obj._000E._000E, obj._000E._0003, obj._000E._0006, obj._000E._000F);
				for (int i = 0; i < 50; i++)
				{
					if (_000E._0006())
					{
						break;
					}
					if (_000E._000E()._0002() != num5)
					{
						break;
					}
					if (!(_000E._000E()._000F() == string.Empty))
					{
						break;
					}
					await Task.Delay(100);
				}
				if (_000E._0006() || _000E._000E() == null || _000E._000E()._000F() != string.Empty || _000E._000E()._0002() == num5)
				{
					return num3;
				}
				foreach (_0003_200B_200A item in _000E._000E()._000E())
				{
					_ = item;
				}
				if (_000E._000E()._000E().Any(obj._000E))
				{
					num3++;
				}
				await Task.Delay(500);
			}
		}
		return num3;
	}

	private static float _000E(_0006_2006 _000E, string _0003, uint _0006)
	{
		if (_000E == null || string.IsNullOrWhiteSpace(_0003))
		{
			return float.MaxValue;
		}
		IReadOnlyList<_000E_2008_200A> readOnlyList = _000E._000E()?._000E();
		if (readOnlyList == null)
		{
			return float.MaxValue;
		}
		float num = float.MaxValue;
		uint num2 = 0u;
		bool flag = false;
		int count = readOnlyList.Count;
		for (int i = 0; i < count; i++)
		{
			if (readOnlyList[i] == null || readOnlyList[i]._000E != 1)
			{
				continue;
			}
			ushort num3 = readOnlyList[i]._0006;
			ushort num4 = readOnlyList[i]._000F;
			float num5 = readOnlyList[i]._0003_2008;
			float num6 = readOnlyList[i]._0006_2008;
			float num7 = readOnlyList[i]._000F_2008;
			uint num8 = readOnlyList[i]._000E_2008;
			if (_0005_2007_200B._000E(_000E_2002_200B._000E(_000E, num3, num4), _0003))
			{
				float num9 = _000E._000E()._000E()?._0003 ?? float.NaN;
				float num10 = _000E._000E()._000E()?._0006 ?? float.NaN;
				float num11 = _000E._000E()._000E()?._000F ?? float.NaN;
				if (float.IsNaN(num9) || float.IsNaN(num10) || float.IsNaN(num11))
				{
					return float.MaxValue;
				}
				float num12 = _000E_2002_200B._000E(num9, num10, num11, num5, num6, num7);
				if (!(num12 >= num))
				{
					num = num12;
					num2 = num8;
					flag = true;
				}
			}
		}
		if (!flag || num2 != _0006)
		{
			return float.MaxValue;
		}
		return num;
	}

	private static bool _000E(_0006_2006 _000E, string _0003, out uint _0006)
	{
		_0006 = 0u;
		if (_000E == null || string.IsNullOrWhiteSpace(_0003))
		{
			return false;
		}
		IReadOnlyList<_000E_2008_200A> readOnlyList = _000E._000E()?._000E();
		if (readOnlyList == null)
		{
			return false;
		}
		float num = float.MaxValue;
		bool result = false;
		int count = readOnlyList.Count;
		for (int i = 0; i < count; i++)
		{
			if (readOnlyList[i] == null || readOnlyList[i]._000E != 1)
			{
				continue;
			}
			ushort num2 = readOnlyList[i]._0006;
			ushort num3 = readOnlyList[i]._000F;
			float num4 = readOnlyList[i]._0003_2008;
			float num5 = readOnlyList[i]._0006_2008;
			float num6 = readOnlyList[i]._000F_2008;
			uint num7 = readOnlyList[i]._000E_2008;
			if (_0005_2007_200B._000E(_000E_2002_200B._000E(_000E, num2, num3), _0003))
			{
				float num8 = _000E._000E()._000E()?._0003 ?? float.NaN;
				float num9 = _000E._000E()._000E()?._0006 ?? float.NaN;
				float num10 = _000E._000E()._000E()?._000F ?? float.NaN;
				if (float.IsNaN(num8) || float.IsNaN(num9) || float.IsNaN(num10))
				{
					return false;
				}
				float num11 = _000E_2002_200B._000E(num8, num9, num10, num4, num5, num6);
				if (!(num11 >= num))
				{
					num = num11;
					_0006 = num7;
					result = true;
				}
			}
		}
		return result;
	}

	private static bool _000E(uint _000E, out ushort _0003)
	{
		_0003 = 0;
		if (_000E >= 4096 || _000E == 65535)
		{
			return false;
		}
		_0003 = checked((ushort)_000E);
		return true;
	}

	public static List<_0008_2007_200B> _000E(_0006_2006 _000E, IReadOnlyList<string> _0003)
	{
		List<_0008_2007_200B> list = new List<_0008_2007_200B>();
		if (_000E == null || !_000E_2002_200B._000E(_0003))
		{
			return list;
		}
		IReadOnlyList<_0005_2005> readOnlyList = _000E._000E()?._000E();
		if (readOnlyList == null || !string.IsNullOrEmpty(_000E._000E()?._0003()))
		{
			return list;
		}
		int count = readOnlyList.Count;
		for (int i = 0; i < count; i++)
		{
			_0005_2005 obj = readOnlyList[i];
			string text = _000E_2002_200B._0003(_000E, obj._0006, obj._000F);
			if (text == null)
			{
				continue;
			}
			bool flag = false;
			for (int j = 0; j < _0003.Count; j++)
			{
				if (_0005_2007_200B._000E(text, _0003[j]))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				_0008_2007_200B item = new _0008_2007_200B
				{
					_000E = obj._000E,
					_0003 = obj._0003,
					_0006 = obj._0006,
					_000F = obj._000F,
					_0002 = text
				};
				int num = list.Count;
				while (num > 0 && item._000E > list[num - 1]._000E)
				{
					num--;
				}
				list.Insert(num, item);
			}
		}
		return list;
	}

	private static IReadOnlyList<_000E_200B_200A._000E> _000E(List<_0008_2007_200B> _000E)
	{
		List<_000E_200B_200A._000E> list = new List<_000E_200B_200A._000E>();
		if (_000E == null)
		{
			return list;
		}
		for (int i = 0; i < _000E.Count; i++)
		{
			_0008_2007_200B obj = _000E[i];
			list.Add(new _000E_200B_200A._000E
			{
				_000E = obj._000E,
				_0003 = obj._0003,
				_0006 = obj._0006,
				_000F = obj._000F
			});
		}
		return list;
	}

	private static string _000E(_0006_2006 _000E, ushort _0003, ushort _0006)
	{
		IReadOnlyDictionary<string, string> readOnlyDictionary = _000E?._000E()?._000E()?._000E();
		if (readOnlyDictionary == null)
		{
			return null;
		}
		string key = _0003.ToString(CultureInfo.InvariantCulture) + _0008_0017._000E(-1141297577) + _0006.ToString(CultureInfo.InvariantCulture);
		if (!readOnlyDictionary.TryGetValue(key, out var value) || value == null)
		{
			return null;
		}
		value = value.Trim();
		if (value.Length != 0)
		{
			return value;
		}
		return null;
	}

	private static string _0003(_0006_2006 _000E, ushort _0003, ushort _0006)
	{
		IReadOnlyDictionary<string, string> readOnlyDictionary = _000E?._000E()?._000E()?._0003();
		if (readOnlyDictionary == null)
		{
			return null;
		}
		string key = _0003.ToString(CultureInfo.InvariantCulture) + _0008_0017._000E(-1141297577) + _0006.ToString(CultureInfo.InvariantCulture);
		if (!readOnlyDictionary.TryGetValue(key, out var value) || value == null)
		{
			return null;
		}
		value = value.Trim();
		if (value.Length != 0)
		{
			return value;
		}
		return null;
	}

	private static bool _000E(IReadOnlyList<string> _000E)
	{
		return _000E_2002_200B._000E(_000E) != 0;
	}

	private static int _000E(IReadOnlyList<string> _000E)
	{
		int num = 0;
		if (_000E == null)
		{
			return num;
		}
		for (int i = 0; i < _000E.Count; i++)
		{
			if (!string.IsNullOrWhiteSpace(_000E[i]))
			{
				num++;
			}
		}
		return num;
	}

	private static float _000E(float _000E, float _0003, float _0006, float _000F, float _0002, float _0008)
	{
		float num = _000F - _000E;
		float num2 = _0002 - _0003;
		float num3 = _0008 - _0006;
		return (float)Math.Sqrt(num * num + num2 * num2 + num3 * num3);
	}
}
internal static class _000E_2003_200B
{
	private sealed class _000E : IDisposable
	{
		public void Dispose()
		{
		}
	}

	internal static int _000E(DataGridView _000E, DataGridView _0003, _0003_2009_200A _0006)
	{
		if (_000E == null || _0003 == null || _000E == _0003)
		{
			return 0;
		}
		List<DataGridViewRow> list = new List<DataGridViewRow>();
		foreach (DataGridViewRow selectedRow in _000E.SelectedRows)
		{
			if (!selectedRow.IsNewRow)
			{
				list.Add(selectedRow);
			}
		}
		if (list.Count == 0)
		{
			return 0;
		}
		list.Sort(_000E_2003_200B._000E);
		List<string> list2 = new List<string>();
		foreach (DataGridViewRow item in (IEnumerable)_0003.Rows)
		{
			if (!item.IsNewRow)
			{
				list2.Add(_000E_2003_200B._000E(item));
			}
		}
		using (_000E_2003_200B._000E(_0006, _0003))
		{
			using (_000E_2003_200B._000E(_0006, _000E))
			{
				foreach (DataGridViewRow item2 in list)
				{
					string text = _000E_2003_200B._000E(item2);
					if (text.Length != 0 && !_000E_2003_200B._000E(list2, text))
					{
						list2.Add(text);
						_0003.Rows.Add(text);
					}
				}
				foreach (DataGridViewRow item3 in list)
				{
					_000E.Rows.Remove(item3);
				}
			}
		}
		return list.Count;
	}

	internal static int _0003(DataGridView _000E, DataGridView _0003, _0003_2009_200A _0006)
	{
		if (_000E == null || _0003 == null || _000E == _0003)
		{
			return 0;
		}
		List<string> list = new List<string>();
		foreach (DataGridViewRow item in (IEnumerable)_0003.Rows)
		{
			if (!item.IsNewRow)
			{
				list.Add(_000E_2003_200B._000E(item));
			}
		}
		List<DataGridViewRow> list2 = new List<DataGridViewRow>();
		foreach (DataGridViewRow item2 in (IEnumerable)_000E.Rows)
		{
			if (!item2.IsNewRow)
			{
				string text = _000E_2003_200B._000E(item2);
				if (text.Length > 0 && _000E_2003_200B._000E(list, text))
				{
					list2.Add(item2);
				}
			}
		}
		if (list2.Count == 0)
		{
			return 0;
		}
		using (_000E_2003_200B._000E(_0006, _000E))
		{
			foreach (DataGridViewRow item3 in list2)
			{
				_000E.Rows.Remove(item3);
			}
		}
		return list2.Count;
	}

	internal static int _000E(DataGridView _000E, _0003_2009_200A _0003)
	{
		if (_000E == null)
		{
			return 0;
		}
		List<DataGridViewRow> list = new List<DataGridViewRow>();
		foreach (DataGridViewRow selectedRow in _000E.SelectedRows)
		{
			if (!selectedRow.IsNewRow)
			{
				list.Add(selectedRow);
			}
		}
		if (list.Count == 0 && _000E.CurrentCell != null)
		{
			DataGridViewRow dataGridViewRow2 = _000E.Rows[_000E.CurrentCell.RowIndex];
			if (!dataGridViewRow2.IsNewRow)
			{
				list.Add(dataGridViewRow2);
			}
		}
		if (list.Count == 0)
		{
			return 0;
		}
		using (_000E_2003_200B._000E(_0003, _000E))
		{
			foreach (DataGridViewRow item in list)
			{
				_000E.Rows.Remove(item);
			}
		}
		return list.Count;
	}

	internal static bool _000E(DataGridView _000E, DataGridView _0003, string _0006, _0003_2009_200A _000F)
	{
		if (_000E == null || _0006 == null)
		{
			return false;
		}
		_0006 = _0006.Trim();
		if (_0006.Length == 0)
		{
			return false;
		}
		List<string> list = new List<string>();
		_000E_2003_200B._000E(list, _000E);
		_000E_2003_200B._000E(list, _0003);
		if (_000E_2003_200B._000E(list, _0006))
		{
			return false;
		}
		using (_000E_2003_200B._000E(_000F, _000E))
		{
			_000E.Rows.Add(_0006);
		}
		return true;
	}

	internal static int _000E(DataGridView _000E, List<string> _0003, _0003_2009_200A _0006)
	{
		if (_000E == null || _0003 == null)
		{
			return 0;
		}
		List<string> list = new List<string>();
		_000E_2003_200B._000E(list, _000E);
		List<string> list2 = new List<string>();
		for (int i = 0; i < _0003.Count; i++)
		{
			string text = ((_0003[i] == null) ? string.Empty : _0003[i].Trim());
			if (text.Length != 0 && !_000E_2003_200B._000E(list, text))
			{
				list.Add(text);
				list2.Add(text);
			}
		}
		if (list2.Count == 0)
		{
			return 0;
		}
		using (_000E_2003_200B._000E(_0006, _000E))
		{
			for (int j = 0; j < list2.Count; j++)
			{
				_000E.Rows.Add(list2[j]);
			}
		}
		return list2.Count;
	}

	private static void _000E(List<string> _000E, DataGridView _0003)
	{
		if (_0003 == null)
		{
			return;
		}
		foreach (DataGridViewRow item in (IEnumerable)_0003.Rows)
		{
			if (!item.IsNewRow && item.Cells.Count != 0)
			{
				_000E.Add(_000E_2003_200B._000E(item));
			}
		}
	}

	private static int _000E(DataGridViewRow _000E, DataGridViewRow _0003)
	{
		return _000E.Index.CompareTo(_0003.Index);
	}

	private static bool _000E(List<string> _000E, string _0003)
	{
		for (int i = 0; i < _000E.Count; i++)
		{
			if (_0005_2007_200B._000E(_000E[i], _0003))
			{
				return true;
			}
		}
		return false;
	}

	internal static string _000E(DataGridViewRow _000E)
	{
		object value = _000E.Cells[0].Value;
		if (value != null)
		{
			return value.ToString().Trim();
		}
		return string.Empty;
	}

	private static IDisposable _000E(_0003_2009_200A _000E, DataGridView _0003)
	{
		if (_000E != null)
		{
			return _000E._000E(_0003);
		}
		return new _000E();
	}
}
internal static class _000E_2004_200B
{
	internal static readonly Color _000E = Color.FromArgb(192, 255, 192);

	internal static readonly Color _0003 = Color.FromArgb(255, 192, 192);

	internal static _0005_200B_200B _000E(_0003_0018 _000E, _0002_0017 _0003)
	{
		return _000E switch
		{
			_0003_0018.Current => new _0005_200B_200B
			{
				_000F = true,
				_000E = _000E_2004_200B._000E,
				_0003 = _0008_0017._000E(-1141302830),
				_0006 = _0008_0017._000E(-1141036896)
			}, 
			_0003_0018.Stale => new _0005_200B_200B
			{
				_000F = true,
				_000E = _000E_2004_200B._0003,
				_0003 = ((_0003 == _0002_0017.Idle) ? _0008_0017._000E(-1141302923) : _0008_0017._000E(-1141302830)),
				_0006 = ((_0003 == _0002_0017.Idle) ? _0008_0017._000E(-1141037027) : _0008_0017._000E(-1141036957))
			}, 
			_0003_0018.RunnerMissing => new _0005_200B_200B
			{
				_000F = true,
				_000E = _000E_2004_200B._0003,
				_0003 = ((_0003 == _0002_0017.Idle) ? _0008_0017._000E(-1141302923) : _0008_0017._000E(-1141302830)),
				_0006 = _0008_0017._000E(-1141036089)
			}, 
			_ => new _0005_200B_200B
			{
				_000F = false,
				_0003 = _0008_0017._000E(-1141302830),
				_0006 = string.Empty
			}, 
		};
	}
}
internal sealed class _000E_2006_200B
{
	internal static readonly _000E_2006_200B _000E = new _000E_2006_200B(_000E: false, 0f, 0f, 0f);

	internal readonly bool _0003;

	internal readonly float _0006;

	internal readonly float _000F;

	internal readonly float _0002;

	internal _000E_2006_200B(bool _000E, float _0003, float _0006, float _000F)
	{
		this._0003 = _000E;
		this._0006 = _0003;
		this._000F = _0006;
		_0002 = _000F;
	}
}
internal sealed class _000E_2007_200B
{
	internal uint _000E;

	internal string _0003;

	internal bool _0006;

	internal float _000F;

	internal float _0002;

	internal float _0008;

	internal long _0005;

	internal byte _000E_2008;

	internal bool _0003_2008;

	internal byte _0006_2008;

	internal ushort _000F_2008;

	internal bool _0002_2008;
}
public static class _000E_2008_200B
{
	[StructLayout(LayoutKind.Auto)]
	private struct _0002 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		private _0008_2002_200B _000F;

		private TaskAwaiter<string> _0002;

		private int _0008;

		private TaskAwaiter _0005;

		private TaskAwaiter<bool> _000E_2008;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				TaskAwaiter<string> awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				bool flag;
				switch (num)
				{
				default:
					awaiter3 = _000E_2000_200A._000E(_0006, 19).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_000E = 0);
						_0002 = awaiter3;
						_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0083;
				case 0:
					awaiter3 = _0002;
					_0002 = default(TaskAwaiter<string>);
					num = (_000E = -1);
					goto IL_0083;
				case 1:
					awaiter2 = _0005;
					_0005 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_0103;
				case 2:
					awaiter = _000E_2008;
					_000E_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0196;
				case 3:
					awaiter = _000E_2008;
					_000E_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0244;
				case 4:
					awaiter2 = _0005;
					_0005 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_02e6;
				case 5:
					{
						awaiter = _000E_2008;
						_000E_2008 = default(TaskAwaiter<bool>);
						num = (_000E = -1);
						goto IL_0378;
					}
					IL_0103:
					awaiter2.GetResult();
					_0008++;
					goto IL_011c;
					IL_0083:
					if (!_000E(awaiter3.GetResult(), out _000F))
					{
						result = false;
						break;
					}
					goto IL_01d7;
					IL_0378:
					flag = awaiter.GetResult();
					goto IL_0380;
					IL_01d7:
					flag = !_0006._0006();
					if (flag)
					{
						awaiter = _000E_2000_200A._000E(_0006, 42).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 3);
							_000E_2008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0244;
					}
					goto IL_024c;
					IL_0196:
					flag = awaiter.GetResult();
					goto IL_019e;
					IL_02ff:
					flag = _0008 < 5 && !_0006._0006();
					if (flag)
					{
						awaiter = _000E_2000_200A._000E(_0006, 42).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 5);
							_000E_2008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0378;
					}
					goto IL_0380;
					IL_0244:
					flag = awaiter.GetResult();
					goto IL_024c;
					IL_024c:
					if (flag && !_000E_200A_200A._000E(_0006, _000F._000E, _000F._0003, _000F._0006, 20f))
					{
						_0008 = 0;
						goto IL_011c;
					}
					_0008 = 0;
					goto IL_02ff;
					IL_019e:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 1);
							_0005 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0103;
					}
					_0006._000E()._000E(_000F._000E, _000F._0003, _000F._0006, _000F: true, (string)null);
					goto IL_01d7;
					IL_02e6:
					awaiter2.GetResult();
					_0008++;
					goto IL_02ff;
					IL_011c:
					flag = _0008 < 10 && !_0006._0006();
					if (flag)
					{
						awaiter = _000E_2000_200A._000E(_0006, 42).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 2);
							_000E_2008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0196;
					}
					goto IL_019e;
					IL_0380:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 4);
							_0005 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_02e6;
					}
					result = _000E_200A_200A._000E(_0006, _000F._000E, _000F._0003, _000F._0006, 20f);
					break;
				}
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _0003 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		private string _000F;

		private TaskAwaiter<string> _0002;

		private TaskAwaiter<_0008_0018> _0008;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				TaskAwaiter<string> awaiter2;
				TaskAwaiter<_0008_0018> awaiter;
				int result3;
				string result2;
				switch (num)
				{
				default:
					if (_0006 == null)
					{
						result = false;
						break;
					}
					awaiter2 = _000E_2000_200A._000E(_0006, _0008_0017._000E(-1141286905)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_000E = 0);
						_0002 = awaiter2;
						_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_008b;
				case 0:
					awaiter2 = _0002;
					_0002 = default(TaskAwaiter<string>);
					num = (_000E = -1);
					goto IL_008b;
				case 1:
					awaiter2 = _0002;
					_0002 = default(TaskAwaiter<string>);
					num = (_000E = -1);
					goto IL_00f5;
				case 2:
					{
						awaiter = _0008;
						_0008 = default(TaskAwaiter<_0008_0018>);
						num = (_000E = -1);
						goto IL_01ba;
					}
					IL_008b:
					result2 = awaiter2.GetResult();
					_000F = result2;
					awaiter2 = _000E_2000_200A._000E(_0006, 42).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_000E = 1);
						_0002 = awaiter2;
						_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_00f5;
					IL_01ba:
					awaiter.GetResult();
					result = true;
					break;
					IL_00f5:
					int.TryParse(awaiter2.GetResult(), out result3);
					result2 = _000F;
					if (!(result2 == _0008_0017._000E(-1141286801)))
					{
						if (result2 == _0008_0017._000E(-1141286840))
						{
							awaiter = _0006_200A_200A._0003(_0006, result3, 200, 10.0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_000E = 2);
								_0008 = awaiter;
								_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01ba;
						}
						result = false;
						break;
					}
					_0006._000E(_0006._000E());
					result = true;
					break;
				}
			}
			catch (Exception exception)
			{
				_000E = -2;
				_000F = null;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_000F = null;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _0006 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		public int _000F;

		private TaskAwaiter<bool> _0002;

		private TaskAwaiter<IReadOnlyList<string>> _0008;

		private int _0005;

		private TaskAwaiter _000E_2008;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				TaskAwaiter<IReadOnlyList<string>> awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				bool flag2;
				bool flag;
				IReadOnlyList<string> result2;
				switch (num)
				{
				default:
					if (_0006 == null)
					{
						result = false;
						break;
					}
					if (!_0006._0002())
					{
						result = false;
						break;
					}
					if (_000E_2000_200A._000E(_0006))
					{
						result = false;
						break;
					}
					if (_0006._000E()._000E() == true)
					{
						result = false;
						break;
					}
					flag = _000F == 2;
					if (flag)
					{
						awaiter = _000E_2000_200A._000E(_0006, 55).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 0);
							_0002 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_010a;
					}
					goto IL_0115;
				case 0:
					awaiter = _0002;
					_0002 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_010a;
				case 1:
					awaiter = _0002;
					_0002 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0185;
				case 2:
					awaiter3 = _0008;
					_0008 = default(TaskAwaiter<IReadOnlyList<string>>);
					num = (_000E = -1);
					goto IL_01f6;
				case 3:
					awaiter = _0002;
					_0002 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0279;
				case 4:
					awaiter2 = _000E_2008;
					_000E_2008 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_02ed;
				case 5:
					awaiter = _0002;
					_0002 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0396;
				case 6:
					awaiter = _0002;
					_0002 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0404;
				case 7:
					awaiter = _0002;
					_0002 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_046d;
				case 8:
					awaiter2 = _000E_2008;
					_000E_2008 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_04d9;
				case 9:
					awaiter = _0002;
					_0002 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_056c;
				case 10:
					awaiter3 = _0008;
					_0008 = default(TaskAwaiter<IReadOnlyList<string>>);
					num = (_000E = -1);
					goto IL_05d7;
				case 11:
					awaiter = _0002;
					_0002 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_064f;
				case 12:
					awaiter = _0002;
					_0002 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_06b2;
				case 13:
					awaiter2 = _000E_2008;
					_000E_2008 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_071f;
				case 14:
					{
						awaiter = _0002;
						_0002 = default(TaskAwaiter<bool>);
						num = (_000E = -1);
						goto IL_07c6;
					}
					IL_0738:
					flag = _0005 < 10;
					if (!flag)
					{
						flag2 = _000E_2000_200A._0006(_0006) && !_0006._0006();
						if (flag2)
						{
							awaiter = _000E_2000_200A._000E(_0006, 42).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_000E = 14);
								_0002 = awaiter;
								_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_07c6;
						}
						goto IL_07cf;
					}
					goto IL_07d2;
					IL_07d2:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 13);
							_000E_2008 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_071f;
					}
					result = true;
					break;
					IL_0306:
					flag = _0005 < 10;
					if (!flag)
					{
						flag2 = _000E_2000_200A._0006(_0006) && !_0006._0006();
						if (flag2)
						{
							awaiter = _000E_2000_200A._000E(_0006, 42).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_000E = 5);
								_0002 = awaiter;
								_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0396;
						}
						goto IL_039f;
					}
					goto IL_03a2;
					IL_06b2:
					awaiter.GetResult();
					_0005 = 0;
					goto IL_0738;
					IL_07c6:
					flag2 = awaiter.GetResult();
					goto IL_07cf;
					IL_056c:
					flag = awaiter.GetResult();
					goto IL_0574;
					IL_071f:
					awaiter2.GetResult();
					_0005++;
					goto IL_0738;
					IL_0574:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 8);
							_000E_2008 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_04d9;
					}
					awaiter3 = _000E_2000_200A._000E(_0006).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_000E = 10);
						_0008 = awaiter3;
						_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_05d7;
					IL_02ed:
					awaiter2.GetResult();
					_0005++;
					goto IL_0306;
					IL_0396:
					flag2 = awaiter.GetResult();
					goto IL_039f;
					IL_010a:
					flag = !awaiter.GetResult();
					goto IL_0115;
					IL_0115:
					if (flag)
					{
						result = false;
						break;
					}
					flag = _000F == 2;
					if (flag)
					{
						awaiter = _000E(_0006).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 1);
							_0002 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0185;
					}
					goto IL_0190;
					IL_039f:
					flag = flag2;
					goto IL_03a2;
					IL_03a2:
					if (flag)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 4);
							_000E_2008 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_02ed;
					}
					awaiter = _000E(_0006, _0003: false, null, _000F: false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 6);
						_0002 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0404;
					IL_04d9:
					awaiter2.GetResult();
					_0005++;
					goto IL_04f2;
					IL_07cf:
					flag = flag2;
					goto IL_07d2;
					IL_0185:
					flag = !awaiter.GetResult();
					goto IL_0190;
					IL_0190:
					if (flag)
					{
						result = false;
						break;
					}
					awaiter3 = _000E_2000_200A._000E(_0006).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_000E = 2);
						_0008 = awaiter3;
						_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_01f6;
					IL_0404:
					if (!awaiter.GetResult())
					{
						result = false;
						break;
					}
					awaiter = _000E_2002_200B._000E(_0006).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 7);
						_0002 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_046d;
					IL_064f:
					awaiter.GetResult();
					goto IL_0657;
					IL_0657:
					awaiter = _000E(_0006, _0003: false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 12);
						_0002 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_06b2;
					IL_01f6:
					result2 = awaiter3.GetResult();
					if (_000E_2002_200B._000E(_0006, result2).Count == 0)
					{
						result = false;
						break;
					}
					awaiter = _0003(_0006, _000F).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 3);
						_0002 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0279;
					IL_05d7:
					result2 = awaiter3.GetResult();
					if (_000E_2002_200B._000E(_0006, result2).Count > 0)
					{
						awaiter = _000E_2002_200B._000E(_0006).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 11);
							_0002 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_064f;
					}
					goto IL_0657;
					IL_046d:
					awaiter.GetResult();
					_0005 = 0;
					goto IL_04f2;
					IL_04f2:
					flag = _0005 < 5 && !_0006._0006();
					if (flag)
					{
						awaiter = _000E_2000_200A._000E(_0006, 42).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 9);
							_0002 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_056c;
					}
					goto IL_0574;
					IL_0279:
					if (!awaiter.GetResult())
					{
						result = false;
						break;
					}
					_0005 = 0;
					goto IL_0306;
				}
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _000E : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		private TaskAwaiter<string> _000F;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					awaiter = _000E_2000_200A._000E(_0006, 39).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 0);
						_000F = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _000F;
					_000F = default(TaskAwaiter<string>);
					num = (_000E = -1);
				}
				result = int.TryParse(awaiter.GetResult()?.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result2) && _0006._000E()._000E().Count >= result2;
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _000F : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		public int _000F;

		private TaskAwaiter _0002;

		private TaskAwaiter<_0008_0018> _0008;

		private int _0005;

		private TaskAwaiter<bool> _000E_2008;

		private TaskAwaiter<string> _0003_2008;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				TaskAwaiter<string> awaiter4;
				TaskAwaiter<_0008_0018> awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter<bool> awaiter;
				int num2;
				bool flag;
				bool flag2;
				string result2;
				string text;
				switch (num)
				{
				default:
					if (_0006 != null)
					{
						awaiter2 = Task.Delay(1000).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 0);
							_0002 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0099;
					}
					result = false;
					goto end_IL_0007;
				case 0:
					awaiter2 = _0002;
					_0002 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_0099;
				case 1:
					awaiter3 = _0008;
					_0008 = default(TaskAwaiter<_0008_0018>);
					num = (_000E = -1);
					goto IL_011d;
				case 2:
					awaiter2 = _0002;
					_0002 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_0186;
				case 3:
					awaiter = _000E_2008;
					_000E_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_022f;
				case 4:
					awaiter = _000E_2008;
					_000E_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_029c;
				case 5:
					awaiter4 = _0003_2008;
					_0003_2008 = default(TaskAwaiter<string>);
					num = (_000E = -1);
					goto IL_0306;
				case 6:
					awaiter3 = _0008;
					_0008 = default(TaskAwaiter<_0008_0018>);
					num = (_000E = -1);
					goto IL_0391;
				case 7:
					awaiter2 = _0002;
					_0002 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_03fa;
				case 8:
					{
						awaiter = _000E_2008;
						_000E_2008 = default(TaskAwaiter<bool>);
						num = (_000E = -1);
						goto IL_04a0;
					}
					IL_022f:
					flag = awaiter.GetResult();
					goto IL_0238;
					IL_0238:
					flag2 = flag;
					goto IL_023b;
					IL_023b:
					if (flag2)
					{
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 2);
							_0002 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0186;
					}
					awaiter = _000E_2000_200A._000E(_0006, 101).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 4);
						_000E_2008 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_029c;
					IL_0099:
					awaiter2.GetResult();
					num2 = _000F;
					if (num2 != 1 && num2 == 2)
					{
						awaiter3 = _0006_200A_200A._000E(_0006, 3, 200, 10.0).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = (_000E = 1);
							_0008 = awaiter3;
							_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_011d;
					}
					goto IL_0125;
					IL_04a0:
					flag = awaiter.GetResult();
					goto IL_04a9;
					IL_0413:
					flag2 = _0005 < 10;
					if (!flag2)
					{
						flag = _000E_2000_200A._0006(_0006) && !_0006._0006();
						if (flag)
						{
							awaiter = _000E_2000_200A._000E(_0006, 42).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_000E = 8);
								_000E_2008 = awaiter;
								_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_04a0;
						}
						goto IL_04a9;
					}
					goto IL_04ac;
					IL_029c:
					if (!awaiter.GetResult())
					{
						break;
					}
					awaiter4 = _000E_2000_200A._000E(_0006, 63).GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = (_000E = 5);
						_0003_2008 = awaiter4;
						_0003.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
						return;
					}
					goto IL_0306;
					IL_011d:
					awaiter3.GetResult();
					goto IL_0125;
					IL_0125:
					_0005 = 0;
					goto IL_019f;
					IL_019f:
					flag2 = _0005 < 10;
					if (!flag2)
					{
						flag = _000E_2000_200A._0006(_0006) && !_0006._0006();
						if (flag)
						{
							awaiter = _000E_2000_200A._000E(_0006, 42).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_000E = 3);
								_000E_2008 = awaiter;
								_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_022f;
						}
						goto IL_0238;
					}
					goto IL_023b;
					IL_04a9:
					flag2 = flag;
					goto IL_04ac;
					IL_0306:
					result2 = awaiter4.GetResult();
					text = ((result2 == null) ? string.Empty : result2.Trim());
					awaiter3 = _0006_200A_200A._000E(_0006, text, 10, 200, 10.0).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_000E = 6);
						_0008 = awaiter3;
						_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0391;
					IL_03fa:
					awaiter2.GetResult();
					_0005++;
					goto IL_0413;
					IL_0186:
					awaiter2.GetResult();
					_0005++;
					goto IL_019f;
					IL_0391:
					awaiter3.GetResult();
					_0005 = 0;
					goto IL_0413;
					IL_04ac:
					if (!flag2)
					{
						break;
					}
					awaiter2 = Task.Delay(200).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_000E = 7);
						_0002 = awaiter2;
						_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_03fa;
				}
				result = true;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	public static async Task<bool> _000E(_0006_2006 _000E, int _0003)
	{
		if (_000E == null)
		{
			return false;
		}
		if (!_000E._0002())
		{
			return false;
		}
		if (_000E_2000_200A._000E(_000E))
		{
			return false;
		}
		if (_000E._000E()._000E() == true)
		{
			return false;
		}
		bool flag = _0003 == 2;
		if (flag)
		{
			flag = !(await _000E_2000_200A._000E(_000E, 55));
		}
		if (flag)
		{
			return false;
		}
		flag = _0003 == 2;
		if (flag)
		{
			flag = !(await _000E_2008_200B._000E(_000E));
		}
		if (flag)
		{
			return false;
		}
		if (_000E_2002_200B._000E(_000E, await _000E_2000_200A._000E(_000E)).Count == 0)
		{
			return false;
		}
		if (!(await _000E_2008_200B._0003(_000E, _0003)))
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			flag = num < 10;
			if (!flag)
			{
				bool flag2 = _000E_2000_200A._0006(_000E) && !_000E._0006();
				if (flag2)
				{
					flag2 = await _000E_2000_200A._000E(_000E, 42);
				}
				flag = flag2;
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
		if (!(await _000E_2008_200B._000E(_000E, _0003: false, null, _000F: false)))
		{
			return false;
		}
		await _000E_2002_200B._000E(_000E);
		num = 0;
		while (true)
		{
			flag = num < 5 && !_000E._0006();
			if (flag)
			{
				flag = await _000E_2000_200A._000E(_000E, 42);
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
		if (_000E_2002_200B._000E(_000E, await _000E_2000_200A._000E(_000E)).Count > 0)
		{
			await _000E_2002_200B._000E(_000E);
		}
		await _000E_2008_200B._000E(_000E, _0003: false);
		num = 0;
		while (true)
		{
			flag = num < 10;
			if (!flag)
			{
				bool flag2 = _000E_2000_200A._0006(_000E) && !_000E._0006();
				if (flag2)
				{
					flag2 = await _000E_2000_200A._000E(_000E, 42);
				}
				flag = flag2;
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
		return true;
	}

	private static async Task<bool> _0003(_0006_2006 _000E, int _0003)
	{
		if (_000E == null)
		{
			return false;
		}
		await Task.Delay(1000);
		if (_0003 != 1 && _0003 == 2)
		{
			await _0006_200A_200A._000E(_000E, 3, 200, 10.0);
		}
		int num = 0;
		while (true)
		{
			bool flag = num < 10;
			if (!flag)
			{
				bool flag2 = _000E_2000_200A._0006(_000E) && !_000E._0006();
				if (flag2)
				{
					flag2 = await _000E_2000_200A._000E(_000E, 42);
				}
				flag = flag2;
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
		if (await _000E_2000_200A._000E(_000E, 101))
		{
			string text = await _000E_2000_200A._000E(_000E, 63);
			string text2 = ((text == null) ? string.Empty : text.Trim());
			await _0006_200A_200A._000E(_000E, text2, 10, 200, 10.0);
			num = 0;
			while (true)
			{
				bool flag = num < 10;
				if (!flag)
				{
					bool flag2 = _000E_2000_200A._0006(_000E) && !_000E._0006();
					if (flag2)
					{
						flag2 = await _000E_2000_200A._000E(_000E, 42);
					}
					flag = flag2;
				}
				if (!flag)
				{
					break;
				}
				await Task.Delay(200);
				num++;
			}
		}
		return true;
	}

	public static async Task<bool> _000E(_0006_2006 _000E)
	{
		if (!int.TryParse((await _000E_2000_200A._000E(_000E, 39))?.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
		{
			return false;
		}
		return _000E._000E()._000E().Count >= result;
	}

	private static async Task<bool> _000E(_0006_2006 _000E, bool _0003, string _0006, bool _000F)
	{
		if (!_000E_2008_200B._000E(await _000E_2000_200A._000E(_000E, 19), out var obj))
		{
			return false;
		}
		int num;
		while (true)
		{
			bool flag = !_000E._0006();
			if (flag)
			{
				flag = await _000E_2000_200A._000E(_000E, 42);
			}
			if (!flag || _000E_200A_200A._000E(_000E, obj._000E, obj._0003, obj._0006, 20f))
			{
				break;
			}
			num = 0;
			while (true)
			{
				flag = num < 10 && !_000E._0006();
				if (flag)
				{
					flag = await _000E_2000_200A._000E(_000E, 42);
				}
				if (!flag)
				{
					break;
				}
				await Task.Delay(200);
				num++;
			}
			_000E._000E()._000E(obj._000E, obj._0003, obj._0006, _000F: true, (string)null);
		}
		num = 0;
		while (true)
		{
			bool flag = num < 5 && !_000E._0006();
			if (flag)
			{
				flag = await _000E_2000_200A._000E(_000E, 42);
			}
			if (!flag)
			{
				break;
			}
			await Task.Delay(200);
			num++;
		}
		return _000E_200A_200A._000E(_000E, obj._000E, obj._0003, obj._0006, 20f);
	}

	private static bool _000E(string _000E, out _0008_2002_200B _0003)
	{
		_0003 = default(_0008_2002_200B);
		if (!_000F_2007_200B._000E(_000E, out var num, out var num2, out var num3))
		{
			return false;
		}
		_0003 = new _0008_2002_200B
		{
			_000E = num,
			_0003 = num2,
			_0006 = num3
		};
		return true;
	}

	public static async Task<bool> _000E(_0006_2006 _000E, bool _0003)
	{
		if (_000E == null)
		{
			return false;
		}
		string text = await _000E_2000_200A._000E(_000E, _0008_0017._000E(-1141286905));
		int.TryParse(await _000E_2000_200A._000E(_000E, 42), out var result);
		string text2 = text;
		if (!(text2 == _0008_0017._000E(-1141286801)))
		{
			if (text2 == _0008_0017._000E(-1141286840))
			{
				await _0006_200A_200A._0003(_000E, result, 200, 10.0);
				return true;
			}
			return false;
		}
		_000E._000E(_000E._000E());
		return true;
	}
}
public static class _000E_2009_200B
{
	[StructLayout(LayoutKind.Auto)]
	private struct _0003 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder _0003;

		public _0008_2004_200B _0006;

		public int _000F;

		public string _0002;

		private TaskAwaiter _0008;

		private void MoveNext()
		{
			int num = _000E;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Run((Action)new _000E
					{
						_000E = _0006,
						_0003 = _000F,
						_0006 = _0002
					}._000E).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 0);
						_0008 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _0008;
					_0008 = default(TaskAwaiter);
					num = (_000E = -1);
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0003.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	private sealed class _000E
	{
		public _0008_2004_200B _000E;

		public int _0003;

		public string _0006;

		public Action _000F;

		internal void _000E()
		{
			this._000E.BeginInvoke(new Action(_0003));
		}

		internal void _0003()
		{
			this._000E._000E(this._0003, _0006 ?? string.Format(_0008_0017._000E(-1141265729), this._0003));
		}
	}

	public static async Task _000E(_0008_2004_200B _000E, int _0003, string _0006)
	{
		await Task.Run((Action)new _000E
		{
			_000E = _000E,
			_0003 = _0003,
			_0006 = _0006
		}._000E);
	}
}
internal sealed class _000E_200B_200B
{
	private int _000E;

	private List<_0003_200B_200B> _0003;

	[JsonProperty("GridIndex")]
	public int _0006
	{
		get
		{
			return _000E;
		}
		set
		{
			_000E = value;
		}
	}

	[JsonProperty("Positions")]
	public List<_0003_200B_200B> _000F
	{
		get
		{
			return _0003;
		}
		set
		{
			_0003 = value;
		}
	}
}
internal sealed class _000F_2001_200B : Form
{
	private sealed class _000E
	{
		public string _000E;

		internal bool _000E(_0003_2004 _000E)
		{
			return string.Equals(_000E._000E, this._000E, StringComparison.OrdinalIgnoreCase);
		}
	}

	private readonly HashSet<string> m__000E;

	private readonly Func<List<_0003_2004>> m__0003;

	private readonly DataGridView m__0006;

	private readonly System.Windows.Forms.Timer _000F;

	internal _000F_2001_200B(int _000E, HashSet<string> _0003, Func<List<_0003_2004>> _0006)
	{
		this.m__000E = _0003;
		this.m__0003 = _0006;
		Text = _0008_0017._000E(-1141036824) + _000E;
		base.StartPosition = FormStartPosition.CenterParent;
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.TopMost = true;
		base.ShowInTaskbar = false;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.ClientSize = new Size(390, 330);
		this.m__0006 = new DataGridView
		{
			Location = new Point(10, 10),
			Size = new Size(370, 270),
			AllowUserToAddRows = false,
			AllowUserToDeleteRows = false,
			AllowUserToResizeRows = false,
			RowHeadersVisible = false,
			MultiSelect = false,
			BackgroundColor = SystemColors.Window
		};
		this.m__0006.Columns.Add(new DataGridViewCheckBoxColumn
		{
			Name = _0008_0017._000E(-1141036836),
			HeaderText = _0008_0017._000E(-1141362411),
			Width = 50
		});
		this.m__0006.Columns.Add(new DataGridViewTextBoxColumn
		{
			Name = _0008_0017._000E(-1141298782),
			HeaderText = _0008_0017._000E(-1141036764),
			ReadOnly = true,
			AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
		});
		this.m__0006.Columns.Add(new DataGridViewTextBoxColumn
		{
			Name = _0008_0017._000E(-1141225465),
			HeaderText = _0008_0017._000E(-1141036850),
			ReadOnly = true,
			Width = 105
		});
		this.m__0006.CurrentCellDirtyStateChanged += this._000E;
		this.m__0006.CellValueChanged += this._000E;
		base.Controls.Add(this.m__0006);
		Button button = new Button
		{
			Text = _0008_0017._000E(-1141263398),
			Location = new Point(10, 290),
			Size = new Size(80, 25)
		};
		button.Click += this._0003;
		base.Controls.Add(button);
		Button button2 = new Button
		{
			Text = _0008_0017._000E(-1141035021),
			Location = new Point(300, 290),
			Size = new Size(80, 25),
			DialogResult = DialogResult.OK
		};
		base.Controls.Add(button2);
		base.AcceptButton = button2;
		_000F = new System.Windows.Forms.Timer
		{
			Interval = 1000
		};
		_000F.Tick += this._0006;
		_000F.Start();
		base.FormClosed += this._000E;
	}

	internal void _000E()
	{
		this.m__0006.EndEdit();
		List<_0003_2004> list = this.m__0003();
		this.m__0006.Rows.Clear();
		foreach (_0003_2004 item in list)
		{
			this.m__0006.Rows.Add(this.m__000E.Contains(item._000E), item._000E, item._0006);
		}
		this.m__0006.ClearSelection();
	}

	private void _0003()
	{
		List<_0003_2004> list = this.m__0003();
		foreach (DataGridViewRow item in (IEnumerable)this.m__0006.Rows)
		{
			_000E obj = new _000E();
			obj._000E = item.Cells[1].Value as string;
			_0003_2004 obj2 = list.Find(obj._000E);
			item.Cells[2].Value = ((obj2 == null) ? _0008_0017._000E(-1141274422) : obj2._0006);
		}
	}

	private void _000E(object _000E, EventArgs _0003)
	{
		if (this.m__0006.IsCurrentCellDirty)
		{
			this.m__0006.CommitEdit(DataGridViewDataErrorContexts.Commit);
		}
	}

	private void _000E(object _000E, DataGridViewCellEventArgs _0003)
	{
		if (_0003.RowIndex < 0 || _0003.ColumnIndex != 0)
		{
			return;
		}
		DataGridViewRow dataGridViewRow = this.m__0006.Rows[_0003.RowIndex];
		if (dataGridViewRow.Cells[1].Value is string item)
		{
			if (dataGridViewRow.Cells[0].Value is bool && (bool)dataGridViewRow.Cells[0].Value)
			{
				this.m__000E.Add(item);
			}
			else
			{
				this.m__000E.Remove(item);
			}
		}
	}

	private void _0003(object _000E, EventArgs _0003)
	{
		this._000E();
	}

	private void _0006(object _000E, EventArgs _0003)
	{
		this._0003();
	}

	private void _000E(object _000E, FormClosedEventArgs _0003)
	{
		_000F.Dispose();
	}
}
public static class _000F_2002_200B
{
	[StructLayout(LayoutKind.Auto)]
	private struct _0002 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _000E_2008_200A _0006;

		public _0006_0018 _000F;

		private _0003 _0002;

		private Action<uint, bool, bool, string> _0008;

		private TaskAwaiter<Task> _0005;

		private TaskAwaiter<bool> _000E_2008;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				if ((uint)num > 1u)
				{
					_0002 = new _0003();
					_0002._000E = _0006;
					_0002._0003 = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
					_0008 = _0002._000E;
					_000F._000E(_0008);
				}
				try
				{
					TaskAwaiter<bool> awaiter;
					TaskAwaiter<Task> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = _000E_2008;
							_000E_2008 = default(TaskAwaiter<bool>);
							num = (_000E = -1);
							goto IL_019d;
						}
						if (_0002._000E._0006())
						{
							_000F._000E_2008();
						}
						else
						{
							_000F._0006(_0002._000E._000E_2008);
						}
						awaiter2 = Task.WhenAny(_0002._0003.Task, Task.Delay(1500)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 0);
							_0005 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = _0005;
						_0005 = default(TaskAwaiter<Task>);
						num = (_000E = -1);
					}
					bool flag = awaiter2.GetResult() == _0002._0003.Task;
					if (flag)
					{
						awaiter = _0002._0003.Task.GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 1);
							_000E_2008 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_019d;
					}
					goto IL_01a5;
					IL_019d:
					flag = awaiter.GetResult();
					goto IL_01a5;
					IL_01a5:
					result = flag;
				}
				finally
				{
					if (num < 0)
					{
						_000F._0003(_0008);
					}
				}
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0002 = null;
				_0008 = null;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0002 = null;
			_0008 = null;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	private sealed class _0003
	{
		public _000E_2008_200A _000E;

		public TaskCompletionSource<bool> _0003;

		internal void _000E(uint _000E, bool _0003, bool _0006, string _000F)
		{
			if (_0003 == this._000E._0006() && (_0003 || _000E == this._000E._000E_2008))
			{
				this._0003.TrySetResult(_0006);
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _0006 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		private List<string> _000F;

		private List<string> _0002;

		private bool _0008;

		private bool _0005;

		private _0006_0018 _000E_2008;

		private (ushort, ushort)[] _0003_2008;

		private IReadOnlyList<uint> _0006_2008;

		private int _000F_2008;

		private int _0002_2008;

		private TaskAwaiter<bool> _0008_2008;

		private TaskAwaiter<string> _0005_2008;

		private TaskAwaiter<int> _000E_2007;

		private IEnumerator<_000E_2008_200A> _0003_2007;

		private void MoveNext()
		{
			int num = _000E;
			bool result2;
			try
			{
				TaskAwaiter<string> awaiter2;
				TaskAwaiter<int> awaiter;
				float num2 = default(float);
				bool flag;
				string result;
				TaskAwaiter<bool> awaiter3;
				switch (num)
				{
				default:
					awaiter3 = _000E_2000_200A._000E(_0006, 24).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_000E = 0);
						_0008_2008 = awaiter3;
						_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_008c;
				case 0:
					awaiter3 = _0008_2008;
					_0008_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_008c;
				case 1:
					awaiter3 = _0008_2008;
					_0008_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_00f7;
				case 2:
					awaiter3 = _0008_2008;
					_0008_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0193;
				case 3:
					awaiter3 = _0008_2008;
					_0008_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0217;
				case 4:
					awaiter2 = _0005_2008;
					_0005_2008 = default(TaskAwaiter<string>);
					num = (_000E = -1);
					goto IL_0333;
				case 5:
					awaiter2 = _0005_2008;
					_0005_2008 = default(TaskAwaiter<string>);
					num = (_000E = -1);
					goto IL_03a7;
				case 6:
					awaiter = _000E_2007;
					_000E_2007 = default(TaskAwaiter<int>);
					num = (_000E = -1);
					goto IL_041a;
				case 7:
				case 8:
					break;
					IL_03a7:
					result = awaiter2.GetResult();
					_0002_2008 = _0008_2005_200A._0003(result);
					awaiter = _000E_2000_200A._000E(_0006, 1).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 6);
						_000E_2007 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_041a;
					IL_008c:
					flag = !awaiter3.GetResult();
					if (flag)
					{
						awaiter3 = _000E_2000_200A._000E(_0006, 25).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = (_000E = 1);
							_0008_2008 = awaiter3;
							_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_00f7;
					}
					goto IL_0103;
					IL_0217:
					flag = awaiter3.GetResult();
					_0005 = flag && _0006._000E(10, out _0002);
					if (!_0008 && !_0005)
					{
						result2 = false;
					}
					else
					{
						_000E_2008 = _0006._000E();
						if (_000E_2008 == null || !_000E_2008._0008_2007())
						{
							result2 = false;
						}
						else
						{
							_0003_2008 = _000E_2008._000E;
							if (_0003_2008 == null || _0003_2008.Length < 10)
							{
								result2 = false;
							}
							else
							{
								_0006_2008 = _0006._000E()._0003();
								if (_0006_2008 != null)
								{
									awaiter2 = _000E_2000_200A._000E(_0006, 43).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										num = (_000E = 4);
										_0005_2008 = awaiter2;
										_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										return;
									}
									goto IL_0333;
								}
								result2 = false;
							}
						}
					}
					goto end_IL_0007;
					IL_041a:
					num2 = awaiter.GetResult();
					_0003_2007 = _0006._000E()._0003().GetEnumerator();
					break;
					IL_00f7:
					flag = !awaiter3.GetResult();
					goto IL_0103;
					IL_0103:
					if (flag)
					{
						result2 = false;
					}
					else
					{
						if (_000E_2000_200A._0003(_0006))
						{
							_000F = new List<string>();
							_0002 = new List<string>();
							awaiter3 = _000E_2000_200A._000E(_0006, 24).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = (_000E = 2);
								_0008_2008 = awaiter3;
								_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_0193;
						}
						result2 = false;
					}
					goto end_IL_0007;
					IL_0193:
					flag = awaiter3.GetResult();
					_0008 = flag && _0006._000E(9, out _000F);
					awaiter3 = _000E_2000_200A._000E(_0006, 25).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_000E = 3);
						_0008_2008 = awaiter3;
						_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0217;
					IL_0333:
					result = awaiter2.GetResult();
					_000F_2008 = _0008_2005_200A._0003(result);
					awaiter2 = _000E_2000_200A._000E(_0006, 44).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_000E = 5);
						_0005_2008 = awaiter2;
						_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_03a7;
				}
				try
				{
					if (num == 7)
					{
						awaiter3 = _0008_2008;
						_0008_2008 = default(TaskAwaiter<bool>);
						num = (_000E = -1);
						goto IL_067b;
					}
					if (num == 8)
					{
						awaiter3 = _0008_2008;
						_0008_2008 = default(TaskAwaiter<bool>);
						num = (_000E = -1);
						goto IL_0791;
					}
					_000E_2008_200A current;
					while (_0003_2007.MoveNext())
					{
						current = _0003_2007.Current;
						if (current == null || !_0006_2008.Contains(current._000E_2008) || _0006._000E()._000E() == null || !_0006._000E()._000E().Contains(current._000E_2008) || !_0006._000E()._000E()._0006()
							.TryGetValue(current._000E_2008.ToString(CultureInfo.InvariantCulture), out var value))
						{
							continue;
						}
						bool flag2 = _0008 && _000F.Contains(value, StringComparer.OrdinalIgnoreCase);
						bool flag3 = _0005 && _0002.Contains(value, StringComparer.OrdinalIgnoreCase);
						if ((!flag2 && !flag3) || (!current._0006() && !_000E_200A_200A._000E(_0006, current._0003_2008, current._0006_2008, current._000F_2008, num2)) || !_0006._000E()._000E().TryGetValue(current._000E_2008, out var value2))
						{
							continue;
						}
						if (flag2 && _000E(value2, _0003_2008[8].Item1, _0003_2008[8].Item2, _000F_2008) && _0008_2005_200A._000E(_0003_2008[8].Item1, _0003_2008[8].Item2, _000E_2008._000E(), _0008_2005_200A._0003()))
						{
							goto IL_05ef;
						}
						if (!flag3 || !_000E(value2, _0003_2008[9].Item1, _0003_2008[9].Item2, _0002_2008) || !_0008_2005_200A._000E(_0003_2008[9].Item1, _0003_2008[9].Item2, _000E_2008._000E(), _0008_2005_200A._0003()))
						{
							continue;
						}
						goto IL_0703;
					}
					goto end_IL_0440;
					IL_067b:
					result2 = awaiter3.GetResult();
					goto end_IL_0007;
					IL_0703:
					awaiter3 = _000E(_0006, _000E_2008, current, num2, 10, _0003_2008[9].Item1, _0003_2008[9].Item2, _0002_2008).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_000E = 8);
						_0008_2008 = awaiter3;
						_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0791;
					IL_0791:
					result2 = awaiter3.GetResult();
					goto end_IL_0007;
					IL_05ef:
					awaiter3 = _000E(_0006, _000E_2008, current, num2, 9, _0003_2008[8].Item1, _0003_2008[8].Item2, _000F_2008).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_000E = 7);
						_0008_2008 = awaiter3;
						_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_067b;
					end_IL_0440:;
				}
				finally
				{
					if (num < 0 && _0003_2007 != null)
					{
						_0003_2007.Dispose();
					}
				}
				_0003_2007 = null;
				result2 = false;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				_000E = -2;
				_000F = null;
				_0002 = null;
				_000E_2008 = null;
				_0003_2008 = null;
				_0006_2008 = null;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_000F = null;
			_0002 = null;
			_000E_2008 = null;
			_0003_2008 = null;
			_0006_2008 = null;
			_0003.SetResult(result2);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	private sealed class _000E
	{
		public _000E_2008_200A _000E;

		public int _0003;

		public TaskCompletionSource<_0003_200A> _0006;

		internal bool _000E(_000E_2008_200A _000E)
		{
			if (_000E != null)
			{
				return _000E._000E_2008 == this._000E._000E_2008;
			}
			return false;
		}

		internal void _000E(_0003_200A _000E)
		{
			if (_000E != null && _000E._000E == _0003)
			{
				_0006.TrySetResult(_000E);
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _000F : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _000E_2008_200A _0006;

		public int _000F;

		public _0006_0018 _0002;

		public _0006_2006 _0008;

		private _000E _0005;

		public float _000E_2008;

		public ushort _0003_2008;

		public ushort _0006_2008;

		public int _000F_2008;

		private Action<_0003_200A> _0002_2008;

		private TaskAwaiter<bool> _0008_2008;

		private int _0005_2008;

		private TaskAwaiter<Task> _000E_2007;

		private TaskAwaiter<_0003_200A> _0003_2007;

		private int _0006_2007;

		private TaskAwaiter _000F_2007;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					if ((uint)(num - 1) <= 2u)
					{
						goto IL_01a0;
					}
					_0005 = new _000E();
					_0005._000E = _0006;
					_0005._0003 = _000F;
					awaiter = _000E(_0002, _0005._000E).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 0);
						_0008_2008 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _0008_2008;
					_0008_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
				}
				if (!awaiter.GetResult())
				{
					result = false;
				}
				else if (_0008._000E() != _0002)
				{
					result = true;
				}
				else
				{
					IReadOnlyList<uint> readOnlyList = _0008._000E()._0003();
					_000E_2008_200A obj = _0008._000E()._0003().FirstOrDefault(_0005._000E);
					if (readOnlyList == null || !readOnlyList.Contains(_0005._000E._000E_2008) || obj == null)
					{
						result = true;
					}
					else
					{
						if (obj._0006() || _000E_200A_200A._000E(_0008, obj._0003_2008, obj._0006_2008, obj._000F_2008, _000E_2008))
						{
							_0005._0006 = new TaskCompletionSource<_0003_200A>(TaskCreationOptions.RunContinuationsAsynchronously);
							_0002_2008 = _0005._000E;
							_0002._000E(_0002_2008);
							goto IL_01a0;
						}
						result = true;
					}
				}
				goto end_IL_0007;
				IL_01a0:
				try
				{
					TaskAwaiter<Task> awaiter4;
					TaskAwaiter<_0003_200A> awaiter3;
					TaskAwaiter awaiter2;
					IReadOnlyList<_0006_2006_200A> value;
					_0003_200A result2;
					switch (num)
					{
					default:
						_0005_2008 = _0008._000E()._0002_2008();
						_0002._000E(_0005._0003, _0003_2008, _0006_2008);
						awaiter4 = Task.WhenAny(_0005._0006.Task, Task.Delay(7000)).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							num = (_000E = 1);
							_000E_2007 = awaiter4;
							_0003.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							return;
						}
						goto IL_0268;
					case 1:
						awaiter4 = _000E_2007;
						_000E_2007 = default(TaskAwaiter<Task>);
						num = (_000E = -1);
						goto IL_0268;
					case 2:
						awaiter3 = _0003_2007;
						_0003_2007 = default(TaskAwaiter<_0003_200A>);
						num = (_000E = -1);
						goto IL_02e9;
					case 3:
						{
							awaiter2 = _000F_2007;
							_000F_2007 = default(TaskAwaiter);
							num = (_000E = -1);
							goto IL_0390;
						}
						IL_0390:
						awaiter2.GetResult();
						if (_0008._000E()._0002_2008() <= _0005_2008 || !_0008._000E()._000E().TryGetValue(_0005._000E._000E_2008, out value) || _000E(value, _0003_2008, _0006_2008, _000F_2008))
						{
							_0006_2007++;
							goto IL_0409;
						}
						result = true;
						goto end_IL_01a0;
						IL_0268:
						if (awaiter4.GetResult() == _0005._0006.Task)
						{
							awaiter3 = _0005._0006.Task.GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = (_000E = 2);
								_0003_2007 = awaiter3;
								_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_02e9;
						}
						result = true;
						goto end_IL_01a0;
						IL_02e9:
						result2 = awaiter3.GetResult();
						if (!(result2._0003 != _0008_0017._000E(-1141303993)) || !(result2._0003 != _0008_0017._000E(-1141254478)))
						{
							_0006_2007 = 0;
							goto IL_0409;
						}
						result = true;
						goto end_IL_01a0;
						IL_0409:
						if (_0006_2007 >= 25 || _0008._0006())
						{
							break;
						}
						awaiter2 = Task.Delay(200).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 3);
							_000F_2007 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0390;
					}
					result = true;
					end_IL_01a0:;
				}
				finally
				{
					if (num < 0)
					{
						_0002._0003(_0002_2008);
					}
				}
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0005 = null;
				_0002_2008 = null;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0005 = null;
			_0002_2008 = null;
			_0003.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine _000E)
		{
			_0003.SetStateMachine(_000E);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine _000E)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(_000E);
		}
	}

	public static async Task<bool> _000E(_0006_2006 _000E)
	{
		bool flag = !(await _000E_2000_200A._000E(_000E, 24));
		if (flag)
		{
			flag = !(await _000E_2000_200A._000E(_000E, 25));
		}
		if (flag)
		{
			return false;
		}
		if (!_000E_2000_200A._0003(_000E))
		{
			return false;
		}
		List<string> source = new List<string>();
		List<string> source2 = new List<string>();
		bool flag2 = await _000E_2000_200A._000E(_000E, 24) && _000E._000E(9, out source);
		bool flag3 = await _000E_2000_200A._000E(_000E, 25) && _000E._000E(10, out source2);
		if (!flag2 && !flag3)
		{
			return false;
		}
		_0006_0018 obj = _000E._000E();
		if (obj == null || !obj._0008_2007())
		{
			return false;
		}
		(ushort, ushort)[] array = obj._000E;
		if (array == null || array.Length < 10)
		{
			return false;
		}
		IReadOnlyList<uint> readOnlyList = _000E._000E()._0003();
		if (readOnlyList == null)
		{
			return false;
		}
		int num = _0008_2005_200A._0003(await _000E_2000_200A._000E(_000E, 43));
		int num2 = _0008_2005_200A._0003(await _000E_2000_200A._000E(_000E, 44));
		float num3 = await _000E_2000_200A._000E(_000E, 1);
		foreach (_000E_2008_200A item in _000E._000E()._0003())
		{
			if (item == null || !readOnlyList.Contains(item._000E_2008) || _000E._000E()._000E() == null || !_000E._000E()._000E().Contains(item._000E_2008) || !_000E._000E()._000E()._0006()
				.TryGetValue(item._000E_2008.ToString(CultureInfo.InvariantCulture), out var value))
			{
				continue;
			}
			bool flag4 = flag2 && source.Contains(value, StringComparer.OrdinalIgnoreCase);
			bool flag5 = flag3 && source2.Contains(value, StringComparer.OrdinalIgnoreCase);
			if ((flag4 || flag5) && (item._0006() || _000E_200A_200A._000E(_000E, item._0003_2008, item._0006_2008, item._000F_2008, num3)) && _000E._000E()._000E().TryGetValue(item._000E_2008, out var value2))
			{
				if (flag4 && _000F_2002_200B._000E(value2, array[8].Item1, array[8].Item2, num) && _0008_2005_200A._000E(array[8].Item1, array[8].Item2, obj._000E(), _0008_2005_200A._0003()))
				{
					return await _000F_2002_200B._000E(_000E, obj, item, num3, 9, array[8].Item1, array[8].Item2, num);
				}
				if (flag5 && _000F_2002_200B._000E(value2, array[9].Item1, array[9].Item2, num2) && _0008_2005_200A._000E(array[9].Item1, array[9].Item2, obj._000E(), _0008_2005_200A._0003()))
				{
					return await _000F_2002_200B._000E(_000E, obj, item, num3, 10, array[9].Item1, array[9].Item2, num2);
				}
			}
		}
		return false;
	}

	internal static bool _000E(IReadOnlyList<_0006_2006_200A> _000E, ushort _0003, ushort _0006, int _000F)
	{
		if (_000E == null || _0003 == ushort.MaxValue || _0006 == ushort.MaxValue || (_0003 == 0 && _0006 == 0))
		{
			return false;
		}
		foreach (_0006_2006_200A item in _000E)
		{
			if (item._000E == _0003 && item._0003 == _0006)
			{
				return item._000F <= (float)_000F;
			}
		}
		return true;
	}

	private static async Task<bool> _000E(_0006_2006 _000E, _0006_0018 _0003, _000E_2008_200A _0006, float _000F, int _0002, ushort _0008, ushort _0005, int _000E_2008)
	{
		_000E obj = new _000E
		{
			_000E = _0006,
			_0003 = _0002
		};
		if (!(await _000F_2002_200B._000E(_0003, obj._000E)))
		{
			return false;
		}
		if (_000E._000E() != _0003)
		{
			return true;
		}
		IReadOnlyList<uint> readOnlyList = _000E._000E()._0003();
		_000E_2008_200A obj2 = _000E._000E()._0003().FirstOrDefault(obj._000E);
		if (readOnlyList == null || !readOnlyList.Contains(obj._000E._000E_2008) || obj2 == null)
		{
			return true;
		}
		if (!obj2._0006() && !_000E_200A_200A._000E(_000E, obj2._0003_2008, obj2._0006_2008, obj2._000F_2008, _000F))
		{
			return true;
		}
		obj._0006 = new TaskCompletionSource<_0003_200A>(TaskCreationOptions.RunContinuationsAsynchronously);
		Action<_0003_200A> action = obj._000E;
		_0003._000E(action);
		try
		{
			int num = _000E._000E()._0002_2008();
			_0003._000E(obj._0003, _0008, _0005);
			if (await Task.WhenAny(obj._0006.Task, Task.Delay(7000)) != obj._0006.Task)
			{
				return true;
			}
			_0003_200A obj3 = await obj._0006.Task;
			if (obj3._0003 != _0008_0017._000E(-1141303993) && obj3._0003 != _0008_0017._000E(-1141254478))
			{
				return true;
			}
			for (int i = 0; i < 25; i++)
			{
				if (_000E._0006())
				{
					break;
				}
				await Task.Delay(200);
				if (_000E._000E()._0002_2008() > num && _000E._000E()._000E().TryGetValue(obj._000E._000E_2008, out var value) && !_000F_2002_200B._000E(value, _0008, _0005, _000E_2008))
				{
					return true;
				}
			}
			return true;
		}
		finally
		{
			_0003._0003(action);
		}
	}

	private static async Task<bool> _000E(_0006_0018 _000E, _000E_2008_200A _0003)
	{
		_0003 obj = new _0003
		{
			_000E = _0003,
			_0003 = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously)
		};
		Action<uint, bool, bool, string> action = obj._000E;
		_000E._000E(action);
		try
		{
			if (obj._000E._0006())
			{
				_000E._000E_2008();
			}
			else
			{
				_000E._0006(obj._000E._000E_2008);
			}
			bool flag = await Task.WhenAny(obj._0003.Task, Task.Delay(1500)) == obj._0003.Task;
			if (flag)
			{
				flag = await obj._0003.Task;
			}
			return flag;
		}
		finally
		{
			_000E._0003(action);
		}
	}
}
internal struct _000F_2003_200B
{
	public bool _000E;

	public float _0003;

	public int _0006;
}
internal static class _000F_2004_200B
{
	private sealed class _000E
	{
		public IWin32Window _000E;

		public string _0003;

		public string _0006;

		public MessageBoxButtons _000F;

		public MessageBoxIcon _0002;

		internal DialogResult _000E()
		{
			return _000F_2004_200B._000E(this._000E, _0003, _0006, _000F, _0002);
		}
	}

	internal static DialogResult _000E(IWin32Window _000E, string _0003, string _0006)
	{
		return _000F_2004_200B._000E(_000E, _0003, _0006, MessageBoxButtons.OK, MessageBoxIcon.None);
	}

	internal static DialogResult _000E(string _000E)
	{
		return _000F_2004_200B._000E(null, _000E, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None);
	}

	internal static DialogResult _000E(string _000E, string _0003, MessageBoxButtons _0006, MessageBoxIcon _000F)
	{
		return _000F_2004_200B._000E(null, _000E, _0003, _0006, _000F);
	}

	internal static DialogResult _000E(IWin32Window _000E, string _0003, string _0006, MessageBoxButtons _000F, MessageBoxIcon _0002)
	{
		_000E obj = new _000E();
		obj._000E = _000E;
		obj._0003 = _0003;
		obj._0006 = _0006;
		obj._000F = _000F;
		obj._0002 = _0002;
		if (obj._000E is Control { IsHandleCreated: not false, InvokeRequired: not false } control)
		{
			return (DialogResult)control.Invoke(new Func<DialogResult>(obj._000E));
		}
		using Form owner = _000F_2004_200B._000E(obj._000E);
		return MessageBox.Show(owner, obj._0003, obj._0006, obj._000F, obj._0002);
	}

	internal static Form _000E(IWin32Window _000E)
	{
		Form form = _000E as Form;
		if (form == null && _000E is Control control)
		{
			form = control.FindForm();
		}
		return new Form
		{
			TopMost = true,
			ShowInTaskbar = false,
			FormBorderStyle = FormBorderStyle.None,
			StartPosition = FormStartPosition.Manual,
			Bounds = _000F_2004_200B._000E(_000F_2004_200B._000E(form), _0003(form))
		};
	}

	internal static Rectangle _000E(Rectangle _000E, Rectangle _0003)
	{
		Rectangle rectangle = ((_000E.Width > 0 && _000E.Height > 0 && _000E.IntersectsWith(_0003)) ? _000E : _0003);
		return new Rectangle(rectangle.Left + rectangle.Width / 2, rectangle.Top + rectangle.Height / 2, 1, 1);
	}

	private static Rectangle _000E(Form _000E)
	{
		if (_000E == null || _000E.IsDisposed)
		{
			return Rectangle.Empty;
		}
		if (!_000E.Visible || _000E.WindowState == FormWindowState.Minimized)
		{
			return Rectangle.Empty;
		}
		return _000E.Bounds;
	}

	private static Rectangle _0003(Form _000E)
	{
		return ((_000E == null || _000E.IsDisposed || !_000E.IsHandleCreated) ? Screen.PrimaryScreen : Screen.FromControl(_000E)).WorkingArea;
	}
}
internal struct _000F_2006_200B
{
	public bool _000E;
}
internal static class _000F_2007_200B
{
	public static readonly string[] _000E = new string[5]
	{
		_0008_0017._000E(-1141278773),
		_0008_0017._000E(-1141284167),
		_0008_0017._000E(-1141283074),
		_0008_0017._000E(-1141035643),
		_0008_0017._000E(-1141278787)
	};

	public static void _000E(DataGridView _000E)
	{
		if (_000E != null)
		{
			while (_000E.Columns.Count < 5)
			{
				_000E.Columns.Add((_000E.Columns.Count == 3) ? ((DataGridViewColumn)new DataGridViewCheckBoxColumn()) : ((DataGridViewColumn)new DataGridViewTextBoxColumn()));
			}
			for (int i = 0; i < 5; i++)
			{
				DataGridViewColumn dataGridViewColumn = _000E.Columns[i];
				dataGridViewColumn.Name = _000F_2007_200B._000E[i];
				dataGridViewColumn.HeaderText = _000F_2007_200B._000E[i];
				dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
			_000E.Columns[4].Visible = false;
			_000E.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}
	}

	public static int _000E(bool _000E, string _0003)
	{
		if (!_000E)
		{
			return 0;
		}
		if (!int.TryParse(_0003?.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
		{
			return 0;
		}
		return Math.Max(0, result);
	}

	public static string _000E(float _000E)
	{
		return _000E.ToString(_0008_0017._000E(-1141035663), CultureInfo.InvariantCulture);
	}

	public static string _000E(float _000E, float _0003)
	{
		return _0008_0017._000E(-1141169486) + _000E.ToString(_0008_0017._000E(-1141277503), CultureInfo.InvariantCulture) + _0008_0017._000E(-1141035666) + _0003.ToString(_0008_0017._000E(-1141277503), CultureInfo.InvariantCulture);
	}

	public static bool _000E(string _000E, out float _0003)
	{
		return float.TryParse(_000E?.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out _0003);
	}

	public static string _000E(float _000E, float _0003, float _0006)
	{
		return _000F_2007_200B._000E(_000E) + _0008_0017._000E(-1141326297) + _000F_2007_200B._000E(_0003) + _0008_0017._000E(-1141326297) + _000F_2007_200B._000E(_0006);
	}

	public static bool _000E(string _000E, out float _0003, out float _0006, out float _000F)
	{
		_0003 = 0f;
		_0006 = 0f;
		_000F = 0f;
		if (_000E == null)
		{
			return false;
		}
		string[] array = _000E.Split(',');
		if (array.Length != 3)
		{
			return false;
		}
		if (!_000F_2007_200B._000E(array[0], out float num))
		{
			return false;
		}
		if (!_000F_2007_200B._000E(array[1], out float num2))
		{
			return false;
		}
		if (!_000F_2007_200B._000E(array[2], out float num3))
		{
			return false;
		}
		_0003 = num;
		_0006 = num2;
		_000F = num3;
		return true;
	}

	public static bool _000E(string _000E)
	{
		bool result;
		return bool.TryParse(_000E?.Trim(), out result) && result;
	}

	public static string[] _000E(_0008_2002_200B _000E)
	{
		return new string[5]
		{
			_000F_2007_200B._000E(_000E._000E),
			_000F_2007_200B._000E(_000E._0006),
			_000E._000F.ToString(CultureInfo.InvariantCulture),
			_000E._0002.ToString(),
			_000F_2007_200B._000E(_000E._0003)
		};
	}

	public static bool _000E(string[] _000E, out _0008_2002_200B _0003)
	{
		_0003 = new _0008_2002_200B
		{
			_0008 = -1
		};
		if (_000E == null || _000E.Length < 5)
		{
			return false;
		}
		if (!_000F_2007_200B._000E(_000E[0], out float num))
		{
			return false;
		}
		if (!_000F_2007_200B._000E(_000E[1], out float num2))
		{
			return false;
		}
		if (!_000F_2007_200B._000E(_000E[4], out float num3))
		{
			num3 = 0f;
		}
		if (!int.TryParse(_000E[2], NumberStyles.Integer, CultureInfo.InvariantCulture, out var result) || result < 0)
		{
			result = 0;
		}
		_0003 = new _0008_2002_200B
		{
			_000E = num,
			_0003 = num3,
			_0006 = num2,
			_000F = result,
			_0002 = _000F_2007_200B._000E(_000E[3]),
			_0008 = -1
		};
		return true;
	}

	public static List<_0008_2002_200B> _000E(DataGridView _000E)
	{
		List<_0008_2002_200B> list = new List<_0008_2002_200B>();
		if (_000E == null)
		{
			return list;
		}
		for (int i = 0; i < _000E.Rows.Count; i++)
		{
			DataGridViewRow dataGridViewRow = _000E.Rows[i];
			if (!dataGridViewRow.IsNewRow)
			{
				string[] array = new string[5];
				for (int j = 0; j < 5; j++)
				{
					array[j] = dataGridViewRow.Cells[j].Value?.ToString();
				}
				if (_000F_2007_200B._000E(array, out var item))
				{
					item._0008 = i;
					list.Add(item);
				}
			}
		}
		return list;
	}

	public static void _000E(DataGridView _000E, int _0003)
	{
		if (_000E != null && _0003 >= 0 && _0003 < _000E.Rows.Count && (_000E.CurrentRow == null || _000E.CurrentRow.Index != _0003 || !_000E.Rows[_0003].Selected))
		{
			_000E.ClearSelection();
			_000E.Rows[_0003].Selected = true;
			_000E.FirstDisplayedScrollingRowIndex = _0003;
		}
	}

	public static string _000E(List<string[]> _000E, string _0003, DateTime _0006)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		JArray val = new JArray();
		if (_000E != null)
		{
			for (int i = 0; i < _000E.Count; i++)
			{
				string[] array = _000E[i];
				JArray val2 = new JArray();
				for (int j = 0; j < 5; j++)
				{
					string text = ((array != null && j < array.Length && array[j] != null) ? array[j] : string.Empty);
					val2.Add(JToken.op_Implicit(text));
				}
				val.Add((JToken)(object)val2);
			}
		}
		return ((JToken)new JObject
		{
			[_0008_0017._000E(-1141035686)] = JToken.op_Implicit(_0006.ToString(_0008_0017._000E(-1141035701), CultureInfo.InvariantCulture)),
			[_0008_0017._000E(-1141035727)] = JToken.op_Implicit(_0008_0017._000E(-1141035742)),
			[_0008_0017._000E(-1141243498)] = JToken.op_Implicit((_0003 == null) ? string.Empty : _0003),
			[_0008_0017._000E(-1141035746)] = (JToken)(object)val
		}).ToString((Formatting)1, Array.Empty<JsonConverter>());
	}

	public static List<string[]> _000E(string _000E, out int _0003)
	{
		_0003 = 0;
		if (string.IsNullOrWhiteSpace(_000E))
		{
			return null;
		}
		JObject val;
		try
		{
			val = JObject.Parse(_000E);
		}
		catch (JsonException)
		{
			return null;
		}
		JToken obj = val[_0008_0017._000E(-1141035746)];
		JArray val2 = (JArray)(object)((obj is JArray) ? obj : null);
		if (val2 == null)
		{
			return null;
		}
		List<string[]> list = new List<string[]>();
		for (int i = 0; i < ((JContainer)val2).Count; i++)
		{
			JToken obj2 = val2[i];
			JArray val3 = (JArray)(object)((obj2 is JArray) ? obj2 : null);
			string[] array = null;
			if (val3 != null)
			{
				array = new string[((JContainer)val3).Count];
				for (int j = 0; j < ((JContainer)val3).Count; j++)
				{
					array[j] = _000F_2007_200B._000E(val3[j]);
				}
			}
			string[] array2 = _000F_2007_200B._000E(array);
			if (array2 == null)
			{
				_0003++;
			}
			else
			{
				list.Add(array2);
			}
		}
		if (list.Count != 0)
		{
			return list;
		}
		return null;
	}

	private static string _000E(JToken _000E)
	{
		JValue val = (JValue)(object)((_000E is JValue) ? _000E : null);
		if (val == null || val.Value == null)
		{
			return null;
		}
		return Convert.ToString(val.Value, CultureInfo.InvariantCulture);
	}

	public static string[] _000E(string[] _000E)
	{
		if (_000E == null || _000E.Length <= 1)
		{
			return null;
		}
		if (!_000F_2007_200B._000E(_000E[0], out float _))
		{
			return null;
		}
		if (!_000F_2007_200B._000E(_000E[1], out float _))
		{
			return null;
		}
		string[] array = new string[5]
		{
			_000E[0].Trim(),
			_000E[1].Trim(),
			null,
			null,
			null
		};
		if (_000E.Length > 2 && _000E[2] != null && int.TryParse(_000E[2].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
		{
			array[2] = Math.Max(0, result).ToString(CultureInfo.InvariantCulture);
		}
		else
		{
			array[2] = _0008_0017._000E(-1141296459);
		}
		if (_000E.Length > 3 && _000E[3] != null && bool.TryParse(_000E[3].Trim(), out var result2))
		{
			array[3] = result2.ToString();
		}
		else
		{
			array[3] = bool.FalseString;
		}
		if (_000E.Length > 4 && _000F_2007_200B._000E(_000E[4], out float _))
		{
			array[4] = _000E[4].Trim();
		}
		else
		{
			array[4] = _0008_0017._000E(-1141296459);
		}
		return array;
	}

	public static List<_0008_2002_200B> _0003(DataGridView _000E)
	{
		List<_0008_2002_200B> list = new List<_0008_2002_200B>();
		if (_000E == null || _000E.Columns.Count < 3)
		{
			return list;
		}
		for (int i = 0; i < _000E.Rows.Count; i++)
		{
			DataGridViewRow dataGridViewRow = _000E.Rows[i];
			if (!dataGridViewRow.IsNewRow)
			{
				object value = dataGridViewRow.Cells[0].Value;
				object value2 = dataGridViewRow.Cells[1].Value;
				object value3 = dataGridViewRow.Cells[2].Value;
				if (_000F_2007_200B._000E(value?.ToString(), out float num) && _000F_2007_200B._000E(value2?.ToString(), out float num2) && _000F_2007_200B._000E(value3?.ToString(), out float num3))
				{
					list.Add(new _0008_2002_200B
					{
						_000E = num,
						_0003 = num2,
						_0006 = num3,
						_000F = 0,
						_0002 = false,
						_0008 = -1
					});
				}
			}
		}
		return list;
	}

	public static int _000E(List<_0008_2002_200B> _000E, float _0003, float _0006)
	{
		if (_000E == null || _000E.Count == 0)
		{
			return -1;
		}
		int result = 0;
		float num = _000F_2007_200B._000E(_0003, _0006, _000E[0]._000E, _000E[0]._0006);
		for (int i = 1; i < _000E.Count; i++)
		{
			float num2 = _000F_2007_200B._000E(_0003, _0006, _000E[i]._000E, _000E[i]._0006);
			if (num2 < num)
			{
				num = num2;
				result = i;
			}
		}
		return result;
	}

	public static int _000E(int _000E, int _0003)
	{
		if (_0003 > 0)
		{
			return (_000E + 1) % _0003;
		}
		return -1;
	}

	public static float _000E(float _000E, float _0003, float _0006, float _000F)
	{
		float num = _000E - _0006;
		float num2 = _0003 - _000F;
		return (float)Math.Sqrt(num * num + num2 * num2);
	}

	public static bool _000E(float _000E)
	{
		return _000E <= 5f;
	}

	public static float _000E(int _000E, int _0003)
	{
		if (_000E != 0 && _000E < _0003 - 1)
		{
			return 35f;
		}
		return 5f;
	}
}
internal sealed class _000F_2008_200B
{
	private uint m__000E;

	private bool _0003;

	private long _0006;

	private float _000F;

	private float _0002;

	private DateTime _0008;

	internal bool _000E(_0002_2008_200B _000E, DateTime _0003)
	{
		if (_000E == null)
		{
			this._000E();
			return false;
		}
		if (_000E._0003_2008)
		{
			return _000E._000E_2008 == 1;
		}
		if (this.m__000E != _000E._000E || this._0003 != _000E._0008)
		{
			this.m__000E = _000E._000E;
			this._0003 = _000E._0008;
			_0006 = _000E._0005;
			_000F = _000E._0006;
			_0002 = _000E._0002;
			_0008 = DateTime.MinValue;
			return false;
		}
		if (_0006 != _000E._0005)
		{
			float num = _000E._0006 - _000F;
			float num2 = _000E._0002 - _0002;
			if (num * num + num2 * num2 >= 0.25f)
			{
				_0008 = _0003;
			}
			_0006 = _000E._0005;
			_000F = _000E._0006;
			_0002 = _000E._0002;
		}
		if (_0008 != DateTime.MinValue)
		{
			return (_0003 - _0008).TotalMilliseconds <= (double)(_000E._0008 ? 1500 : 500);
		}
		return false;
	}

	internal void _000E()
	{
		this.m__000E = 0u;
		_0006 = 0L;
		_0008 = DateTime.MinValue;
	}
}
internal static class _000F_2009_200B
{
	private delegate bool _0003(IntPtr _000E, IntPtr _0003);

	private sealed class _000E
	{
		public List<_0002_2009_200B> _000E;

		internal bool _000E(IntPtr _000E, IntPtr _0003)
		{
			if (!_000F_2009_200B._000E(_000E))
			{
				return true;
			}
			StringBuilder stringBuilder = new StringBuilder(256);
			_000F_2009_200B._000E(_000E, stringBuilder, stringBuilder.Capacity);
			if (stringBuilder.ToString() != _0008_0017._000E(-1141036463))
			{
				return true;
			}
			StringBuilder stringBuilder2 = new StringBuilder(512);
			_000F_2009_200B._0003(_000E, stringBuilder2, stringBuilder2.Capacity);
			_000F_2009_200B._000E(_000E, out var num);
			int num2 = _000F_2009_200B._000E((int)num);
			if (num2 < 0)
			{
				return true;
			}
			this._000E.Add(new _0002_2009_200B
			{
				_000E = _000E,
				_0003 = stringBuilder2.ToString(),
				_0006 = (int)num,
				_000F = num2,
				_0002 = _0008_0017._000E(-1141303920) + (5554 + num2 * 2),
				_0008 = 27042 + num2
			});
			return true;
		}
	}

	[DllImport("user32.dll", EntryPoint = "EnumWindows")]
	private static extern bool _000E(_0003 _000E, IntPtr _0003);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetClassName")]
	private static extern int _000E(IntPtr _000E, StringBuilder _0003, int _0006);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetWindowText")]
	private static extern int _0003(IntPtr _000E, StringBuilder _0003, int _0006);

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
	private static extern uint _000E(IntPtr _000E, out uint _0003);

	[DllImport("user32.dll", EntryPoint = "IsWindowVisible")]
	private static extern bool _000E(IntPtr _000E);

	internal static List<_0002_2009_200B> _000E(string _000E)
	{
		_000E obj = new _000E();
		obj._000E = new List<_0002_2009_200B>();
		_000F_2009_200B._000E(obj._000E, IntPtr.Zero);
		if (!string.IsNullOrEmpty(_000E) && File.Exists(_000E))
		{
			string text = _0003_2009_200B._000E(_000E, (string)null, _0008_0017._000E(-1141036487), 8000);
			foreach (_0002_2009_200B item in obj._000E)
			{
				item._0005 = text.IndexOf(item._0002, StringComparison.OrdinalIgnoreCase) >= 0;
			}
		}
		return obj._000E;
	}

	private static int _000E(int _000E)
	{
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(_0008_0017._000E(-1141036501), _0008_0017._000E(-1141036518) + _000E);
			try
			{
				using ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
				foreach (ManagementObject item in managementObjectCollection)
				{
					string text = item[_0008_0017._000E(-1141041701)] as string;
					if (!string.IsNullOrEmpty(text))
					{
						Match match = Regex.Match(text, _0008_0017._000E(-1141041719), RegexOptions.IgnoreCase);
						if (match.Success)
						{
							return int.Parse(match.Groups[1].Value);
						}
						return 0;
					}
				}
			}
			finally
			{
				((IDisposable)managementObjectSearcher).Dispose();
			}
		}
		catch
		{
		}
		return -1;
	}

	internal static string _000E(string _000E)
	{
		if (string.IsNullOrEmpty(_000E))
		{
			return null;
		}
		string text = Path.Combine(_000E, _0008_0017._000E(-1141327908));
		if (!File.Exists(text))
		{
			return null;
		}
		return text;
	}
}
internal sealed class _000F_200B_200B
{
	internal int _000E;

	internal float[] _0003;

	internal float[] _0006;

	internal float[] _000F;
}
