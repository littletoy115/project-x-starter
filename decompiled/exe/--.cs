using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

internal enum _0002_0017
{
	Idle,
	Attached,
	Selected,
	Started
}
internal enum _0002_0018
{
	Healthy,
	Unhealthy,
	Unknown
}
internal static class _0002_200B
{
	internal sealed class _000E
	{
		private _000F_2007 m__000E;

		private string _0003;

		internal _000F_2007 _000E()
		{
			return this.m__000E;
		}

		internal void _000E(_000F_2007 _000E)
		{
			this.m__000E = _000E;
		}

		internal string _000E()
		{
			return _0003;
		}

		internal void _000E(string _000E)
		{
			_0003 = _000E;
		}
	}

	private static readonly object m__000E = new object();

	private static string m__0003;

	private static _000E _0006;

	internal static bool _000E(int _000E)
	{
		return _000E >= 528040;
	}

	internal static bool _000E()
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(_0008_0017._000E(-1141265767));
			object obj = registryKey2?.GetValue(_0008_0017._000E(-1141265824));
			return obj is int && _000E((int)obj);
		}
		catch (Exception)
		{
			return false;
		}
	}

	internal static void _000E(string _000E)
	{
		if (string.IsNullOrWhiteSpace(_000E))
		{
			throw new ArgumentException(_0008_0017._000E(-1141265838), _0008_0017._000E(-1141265865));
		}
		lock (_0002_200B.m__000E)
		{
			_0002_200B.m__0003 = _000E;
			_0006 = null;
		}
	}

	internal static bool _000E(out string _000E)
	{
		lock (_0002_200B.m__000E)
		{
			_000E = _0002_200B.m__0003;
			_0002_200B.m__0003 = null;
			return !string.IsNullOrWhiteSpace(_000E);
		}
	}

	internal static bool _0003()
	{
		lock (_0002_200B.m__000E)
		{
			return !string.IsNullOrWhiteSpace(_0002_200B.m__0003);
		}
	}

	internal static bool _000E(_000F_2007 _000E, string _0003)
	{
		if (_000E == null || !_000E._0006_2008)
		{
			throw new ArgumentException(_0008_0017._000E(-1141265876), _0008_0017._000E(-1141265920));
		}
		if (string.IsNullOrWhiteSpace(_0003))
		{
			throw new ArgumentException(_0008_0017._000E(-1141271043), _0008_0017._000E(-1141271083));
		}
		lock (_0002_200B.m__000E)
		{
			if (!string.IsNullOrWhiteSpace(_0002_200B.m__0003) || _0006 != null)
			{
				return false;
			}
			_000E obj = new _000E();
			obj._000E(_000E);
			obj._000E(_0003);
			_0006 = obj;
			return true;
		}
	}

	internal static bool _000E(out _000E _000E)
	{
		lock (_0002_200B.m__000E)
		{
			_000E = _0006;
			_0006 = null;
			return _000E != null;
		}
	}

	internal static bool _000E(string _000E, string _0003)
	{
		if (_0002_200B._000E(_000E, out var version) && _0002_200B._000E(_0003, out var version2))
		{
			return version2 > version;
		}
		return false;
	}

	internal static string _000E(_0003_2003 _000E)
	{
		string text = ((_000E == null) ? _0008_0017._000E(-1141293701) : _000E._0008_2008);
		string text2 = _000E?._0008_2007;
		string text3 = (string.IsNullOrWhiteSpace(text2) ? string.Empty : (_0008_0017._000E(-1141271102) + text2.Trim()));
		return _0008_0017._000E(-1141271153) + text + _0008_0017._000E(-1141271198) + text3 + _0008_0017._000E(-1141271229);
	}

	private static bool _000E(string _000E, out Version _0003)
	{
		_0003 = null;
		if (string.IsNullOrWhiteSpace(_000E))
		{
			return false;
		}
		if (!Version.TryParse(_000E.Trim().TrimStart('v', 'V'), out var result))
		{
			return false;
		}
		_0003 = new Version(result.Major, result.Minor, Math.Max(result.Build, 0), Math.Max(result.Revision, 0));
		return true;
	}

	internal static string _000E(string _000E, string _0003)
	{
		return string.Join(_0008_0017._000E(-1141299597), _0002_200B._000E(_0006_2002._0008()), _0002_200B._000E(_000E), _0002_200B._000E(_0006_2002._0005()), _0002_200B._000E(_0006_2002._000E_2008()), _0002_200B._000E(_0006_2002._0002()), _0002_200B._000E(_0003));
	}

	internal static string _000E(_000F_2007 _000E, string _0003, string _0006, int _000F, long _0002)
	{
		if (_000E == null)
		{
			throw new ArgumentNullException(_0008_0017._000E(-1141271276));
		}
		return string.Join(_0008_0017._000E(-1141299597), _0008_0017._000E(-1141271295), _0008_0017._000E(-1141271317), _0008_0017._000E(-1141271328), _0002_200B._000E(_0006_2002._0005()), _0008_0017._000E(-1141271342), _0002_200B._000E(_0006_2002._000E_2008()), _0008_0017._000E(-1141271353), _0002_200B._000E(_0006_2002._0006()), _0008_0017._000E(-1141271369), _0002_200B._000E(_0003), _0008_0017._000E(-1141271390), _0002_200B._000E(_000E._0006.ToString(CultureInfo.InvariantCulture)), _0008_0017._000E(-1141271409), _0002_200B._000E(_000E._000F.ToString(CultureInfo.InvariantCulture)), _0008_0017._000E(-1141271434), _0002_200B._000E(_000E._0002.ToString(CultureInfo.InvariantCulture)), _0008_0017._000E(-1141271463), _0002_200B._000E(_000E._0008), _0008_0017._000E(-1141271486), _0002_200B._000E(_0006), _0008_0017._000E(-1141271497), _0002_200B._000E(_000F.ToString(CultureInfo.InvariantCulture)), _0008_0017._000E(-1141271516), _0002_200B._000E(_0002.ToString(CultureInfo.InvariantCulture)), _0008_0017._000E(-1141270536), _0002_200B._000E(_0006_2002._0002() + _0008_0017._000E(-1141265149)));
	}

	internal static string _000E(_000F_2007 _000E)
	{
		if (_000E == null)
		{
			throw new ArgumentNullException(_0008_0017._000E(-1141270540));
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = ((_000E._0003_2008 != null) ? _000E._0003_2008.Count : 0);
		stringBuilder.Append(_0008_0017._000E(-1141270559)).Append(num).Append((num == 1) ? _0008_0017._000E(-1141270605) : _0008_0017._000E(-1141270592));
		if (_000E._0003_2008 != null)
		{
			int num2 = Math.Min(_000E._0003_2008.Count, 10);
			for (int i = 0; i < num2; i++)
			{
				_0005_2007 obj = _000E._0003_2008[i];
				stringBuilder.Append(_0008_0017._000E(-1141270609)).Append(obj._000E).Append(_0008_0017._000E(-1141270620))
					.Append(obj._0003);
			}
			if (_000E._0003_2008.Count > num2)
			{
				stringBuilder.Append(_0008_0017._000E(-1141270637)).Append(_000E._0003_2008.Count - num2).Append(_0008_0017._000E(-1141270644));
			}
		}
		string text = _000E._0002_2008 ?? string.Empty;
		if (text.Length > 8192)
		{
			int num3 = 8192;
			if (char.IsHighSurrogate(text[num3 - 1]) && char.IsLowSurrogate(text[num3]))
			{
				num3--;
			}
			text = text.Substring(0, num3);
		}
		if (!string.IsNullOrWhiteSpace(text))
		{
			stringBuilder.Append(_0008_0017._000E(-1141271102)).Append(text);
		}
		stringBuilder.Append(_0008_0017._000E(-1141271229));
		return stringBuilder.ToString();
	}

	private static string _000E(string _000E)
	{
		if (_000E == null)
		{
			_000E = string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(_0008_0017._000E(-1141304355));
		int num = 0;
		string text = _000E;
		foreach (char c in text)
		{
			switch (c)
			{
			case '\\':
				num++;
				break;
			case '"':
				stringBuilder.Append('\\', num * 2 + 1);
				stringBuilder.Append('"');
				num = 0;
				break;
			default:
				stringBuilder.Append('\\', num);
				num = 0;
				stringBuilder.Append(c);
				break;
			}
		}
		stringBuilder.Append('\\', num * 2);
		stringBuilder.Append('"');
		return stringBuilder.ToString();
	}

	internal static void _0003(string _000E)
	{
		if (string.IsNullOrWhiteSpace(_000E))
		{
			throw new InvalidOperationException(_0008_0017._000E(-1141270664));
		}
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string text = Path.Combine(Path.GetTempPath(), _0006_2002._0008(), Guid.NewGuid().ToString(_0008_0017._000E(-1141300407)));
		Directory.CreateDirectory(text);
		string text2 = Path.Combine(text, _0008_0017._000E(-1141270703));
		using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_0008_0017._000E(-1141270703)))
		{
			if (stream == null)
			{
				throw new FileNotFoundException(_0008_0017._000E(-1141270733), _0008_0017._000E(-1141270703));
			}
			using FileStream destination = File.Create(text2);
			stream.CopyTo(destination);
		}
		if (Process.Start(new ProcessStartInfo
		{
			FileName = text2,
			Arguments = _0002_200B._000E(baseDirectory, _000E),
			WorkingDirectory = baseDirectory,
			UseShellExecute = true
		}) == null)
		{
			throw new InvalidOperationException(_0008_0017._000E(-1141270763));
		}
	}

	internal static void _000E(_000E _000E)
	{
		if (_000E == null || _000E._000E() == null)
		{
			throw new InvalidOperationException(_0008_0017._000E(-1141270796));
		}
		if (string.IsNullOrWhiteSpace(_000E._000E()))
		{
			throw new InvalidOperationException(_0008_0017._000E(-1141270853));
		}
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string text = Path.Combine(Path.GetTempPath(), _0006_2002._0008(), Guid.NewGuid().ToString(_0008_0017._000E(-1141300407)));
		Directory.CreateDirectory(text);
		string text2 = Path.Combine(text, _0008_0017._000E(-1141270703));
		using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_0008_0017._000E(-1141270703)))
		{
			if (stream == null)
			{
				throw new FileNotFoundException(_0008_0017._000E(-1141270733), _0008_0017._000E(-1141270703));
			}
			using FileStream destination = File.Create(text2);
			stream.CopyTo(destination);
		}
		string text3 = _0003_2002._000E(_000E._000E());
		try
		{
			using Process process = Process.GetCurrentProcess();
			if (Process.Start(new ProcessStartInfo
			{
				FileName = text2,
				Arguments = _0002_200B._000E(_000E._000E(), baseDirectory, text3, process.Id, process.StartTime.ToUniversalTime().Ticks),
				WorkingDirectory = baseDirectory,
				UseShellExecute = true
			}) == null)
			{
				throw new InvalidOperationException(_0008_0017._000E(-1141270763));
			}
		}
		catch
		{
			try
			{
				File.Delete(text3);
			}
			catch (IOException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
			throw;
		}
	}

	internal static void _000E()
	{
		string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _0008_0017._000E(-1141270890) + _0006_2002._0002() + _0008_0017._000E(-1141265149));
		if (!File.Exists(text))
		{
			return;
		}
		try
		{
			string text2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), _0008_0017._000E(-1141297631), _0008_0017._000E(-1141270912));
			Directory.CreateDirectory(text2);
			string destFileName = Path.Combine(text2, _0006_2002._0002() + _0008_0017._000E(-1141293701) + DateTime.UtcNow.ToString(_0008_0017._000E(-1141270923)) + _0008_0017._000E(-1141265149));
			File.Copy(text, destFileName);
			File.Delete(text);
		}
		catch (Exception)
		{
		}
	}
}
internal struct _0002_200B_200A
{
	public ushort _000E;

	public ushort _0003;

	public int _0006;
}
internal enum _0003_0017
{

}
internal enum _0003_0018
{
	Unknown,
	Current,
	Stale,
	RunnerMissing
}
public sealed class _0003_200B
{
	private List<_0003_2001> _000E;

	private List<_0003_2001> _0003;

	public List<_0003_2001> MemoryPointers
	{
		[CompilerGenerated]
		get
		{
			return _000E;
		}
		[CompilerGenerated]
		set
		{
			_000E = value;
		}
	}

	public List<_0003_2001> ByteArrays
	{
		[CompilerGenerated]
		get
		{
			return _0003;
		}
		[CompilerGenerated]
		set
		{
			_0003 = value;
		}
	}
}
internal sealed class _0003_200B_200A
{
	public int _000E;

	public int _0003;

	public ushort _0006;

	public ushort _000F;

	public bool _0002;

	public bool _0008;

	public bool _0005;

	public string _000E_2008;
}
internal static class _0005_0018
{
	internal enum _000E
	{

	}

	internal static bool _000E(long _000E, long _0003)
	{
		if (_000E < 0)
		{
			return true;
		}
		return _0003 - _000E >= 500;
	}

	internal static bool _000E(int _000E, string _0003, int _0006, string _000F)
	{
		if (_000E != _0006)
		{
			return true;
		}
		return !string.Equals(_0003 ?? string.Empty, _000F ?? string.Empty, StringComparison.Ordinal);
	}

	internal static _000E _000E(bool _000E, string _0003, string _0006, long _000F)
	{
		bool flag = !string.IsNullOrEmpty(_0006);
		bool flag2 = _000F >= 12000;
		if (!_000E)
		{
			if (flag2)
			{
				if (!flag)
				{
					return (_000E)4;
				}
				return (_000E)3;
			}
			return (_000E)0;
		}
		if (flag)
		{
			return (_000E)3;
		}
		if (string.Equals(_0003, _0008_0017._000E(-1141305020), StringComparison.Ordinal))
		{
			return (_000E)1;
		}
		if (string.Equals(_0003, _0008_0017._000E(-1141144254), StringComparison.Ordinal))
		{
			return (_000E)2;
		}
		if (flag2)
		{
			return (_000E)4;
		}
		return (_000E)0;
	}

	internal static string _000E(long _000E)
	{
		long num = 12000 - _000E;
		if (num < 0)
		{
			num = 0L;
		}
		long num2 = (num + 999) / 1000;
		return _0008_0017._000E(-1141038623) + num2.ToString(CultureInfo.InvariantCulture) + _0008_0017._000E(-1141038663);
	}

	internal static bool _000E(_000F_2008_200A _000E)
	{
		if (_000E._000E != null)
		{
			return _000E._000E.Trim().Length != 0;
		}
		return false;
	}

	internal static string _000E(_000F_2008_200A _000E)
	{
		if (!_0005_0018._000E(_000E))
		{
			return _0008_0017._000E(-1141127874);
		}
		return _000E._000E;
	}

	internal static string _0003(_000F_2008_200A _000E)
	{
		return _000E._0003.ToString(CultureInfo.InvariantCulture);
	}

	internal static string _0006(_000F_2008_200A _000E)
	{
		if (_000E._0006 == -1)
		{
			return _0008_0017._000E(-1141121791);
		}
		if (_000E._0006 == 0)
		{
			return _0008_0017._000E(-1141119300);
		}
		if (_000E._0006 == 1)
		{
			return _0008_0017._000E(-1141121149);
		}
		if (_000E._0006 == 2)
		{
			return _0008_0017._000E(-1141122889);
		}
		return _000E._0006.ToString(CultureInfo.InvariantCulture);
	}

	internal static string _000F(_000F_2008_200A _000E)
	{
		if (!_000E._0002)
		{
			return _0008_0017._000E(-1141122606);
		}
		if (!_000E._000F)
		{
			return _0008_0017._000E(-1141121525);
		}
		return _0008_0017._000E(-1141121832);
	}

	internal static string _0002(_000F_2008_200A _000E)
	{
		return _000E._0008.ToString(CultureInfo.InvariantCulture);
	}

	internal static string _0008(_000F_2008_200A _000E)
	{
		return _000E._0005.ToString(CultureInfo.InvariantCulture);
	}

	internal static string _0005(_000F_2008_200A _000E)
	{
		return _000E._000E_2008.ToString(CultureInfo.InvariantCulture);
	}

	internal static string _000E_2008(_000F_2008_200A _000E)
	{
		if (_000E._0003_2008 == 0)
		{
			return _0008_0017._000E(-1141123022);
		}
		if (_000E._0003_2008 == 1)
		{
			return _0008_0017._000E(-1141121307);
		}
		if (_000E._0003_2008 == 2)
		{
			return _0008_0017._000E(-1141122059);
		}
		return _000E._0003_2008.ToString(CultureInfo.InvariantCulture);
	}

	internal static string[] _000E(_000F_2008_200A _000E)
	{
		return new string[8]
		{
			_0005_0018._000E(_000E),
			_0003(_000E),
			_0006(_000E),
			_000F(_000E),
			_0002(_000E),
			_0008(_000E),
			_0005(_000E),
			_000E_2008(_000E)
		};
	}

	internal static string[] _000E()
	{
		return new string[8]
		{
			_0008_0017._000E(-1141298782),
			_0008_0017._000E(-1141121746),
			_0008_0017._000E(-1141121791),
			_0008_0017._000E(-1141121832),
			_0008_0017._000E(-1141121867),
			_0008_0017._000E(-1141121912),
			_0008_0017._000E(-1141121952),
			_0008_0017._000E(-1141121985)
		};
	}

	internal static int _000E(IReadOnlyList<_000F_2008_200A> _000E)
	{
		if (_000E == null)
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < _000E.Count; i++)
		{
			if (_0005_0018._000E(_000E[i]))
			{
				num++;
			}
		}
		return num;
	}

	internal static string _000E(int _000E)
	{
		if (_000E <= 0)
		{
			return string.Empty;
		}
		return _0008_0017._000E(-1141270620) + _000E.ToString(CultureInfo.InvariantCulture) + _0008_0017._000E(-1141038668);
	}
}
internal static class _0005_200B
{
	public static class _000E
	{
	}
}
public struct _0005_200B_200A
{
	public int _000E;

	public int _0003;

	public bool _0006;

	public _0005_200B_200A(int _000E, int _0003)
	{
		this._000E = _000E;
		this._0003 = _0003;
		_0006 = _0003 == 0;
	}
}
internal enum _0006_0017
{

}
internal sealed class _0006_0018 : IDisposable
{
	private sealed class _0002
	{
		public _000E_2007_200A _000E;

		public _0006_0018 _0003;

		internal void _000E()
		{
			_0003._000E_200A?.Invoke(this._000E);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _0002_2008 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder _0003;

		public _0006_0018 _0006;

		private int _000F;

		private float _0002;

		private float _0008;

		private float _0005;

		private Func<int, Task> _000E_2008;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _0003_2008;

		private void MoveNext()
		{
			int num = _000E;
			_0006_0018 obj = _0006;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _0003_2008;
					_0003_2008 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = (_000E = -1);
					goto IL_0159;
				}
				if (num == 1)
				{
					awaiter = _0003_2008;
					_0003_2008 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = (_000E = -1);
					goto IL_023f;
				}
				object obj2 = obj._0003_2008_200A;
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj2, ref lockTaken);
					if (!obj._0006_2008_200A)
					{
						obj._0006_2008_200A = true;
						_000F = obj._000F_2008_200A;
						obj._0006_2008();
						_0005_2001_200A obj3 = obj._000E()._000E();
						if (obj3 != null)
						{
							_0002 = obj3._0003;
							_0008 = obj3._0006;
							_0005 = obj3._000F;
							if (obj._000E(_0002 + 2f, _0008, _0005, _000F: false, _0008_0017._000E(-1141180064)))
							{
								goto IL_00d1;
							}
						}
					}
				}
				finally
				{
					if (num < 0 && lockTaken)
					{
						Monitor.Exit(obj2);
					}
				}
				goto end_IL_000e;
				IL_023f:
				awaiter.GetResult();
				goto end_IL_000e;
				IL_00d1:
				_000E_2008 = obj._0002_2008_200A;
				awaiter = ((_000E_2008 == null) ? Task.Delay(250) : _000E_2008(250)).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_000E = 0);
					_0003_2008 = awaiter;
					_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0159;
				IL_0159:
				awaiter.GetResult();
				obj2 = obj._0003_2008_200A;
				lockTaken = false;
				try
				{
					Monitor.Enter(obj2, ref lockTaken);
					if (_000F == obj._000F_2008_200A && obj._000E(_0002 - 2f, _0008, _0005, _000F: false, _0008_0017._000E(-1141180064)))
					{
						goto IL_01c6;
					}
				}
				finally
				{
					if (num < 0 && lockTaken)
					{
						Monitor.Exit(obj2);
					}
				}
				goto end_IL_000e;
				IL_01c6:
				awaiter = ((_000E_2008 == null) ? Task.Delay(250) : _000E_2008(250)).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_000E = 1);
					_0003_2008 = awaiter;
					_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_023f;
				end_IL_000e:;
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

	private sealed class _0003
	{
		public int _000E;

		public ushort _0003;

		public ushort _0006;

		public int _000F;

		public ushort _0002;

		public ushort _0008;

		internal string _000E(uint _000E)
		{
			return global::_0002_2002_200A._000E(_000E, this._000E, _0003, _0006, _000F, _0002, _0008);
		}
	}

	private enum _0003_0018
	{

	}

	private sealed class _0003_2008
	{
		public _0006_0018 _000E;

		public long _0003;

		public Action _0006;

		internal void _000E()
		{
			bool flag;
			lock (this._000E.m__0006)
			{
				flag = _0003 == Interlocked.Read(ref this._000E.m__0008) && _0003 != this._000E.m__0005;
			}
			if (flag)
			{
				_0006();
			}
		}
	}

	private sealed class _0005
	{
		public _0006_0018 _000E;

		public IntPtr _0003;

		public string _0006;

		internal void _000E(object _000E)
		{
			lock (this._000E.m__0003)
			{
				if (_0003.ToInt64() == Interlocked.Read(ref this._000E.m__0008))
				{
					try
					{
						this._000E._0003(_0006);
						return;
					}
					catch (Exception ex)
					{
						this._000E._000F(_0008_0017._000E(-1141180038) + ex.Message);
						return;
					}
				}
			}
		}
	}

	private sealed class _0006
	{
		public int _000E;

		public ushort _0003;

		public ushort _0006;

		internal string _000E(uint _000E)
		{
			return global::_0002_2002_200A._000E(_000E, this._000E, _0003, _0006);
		}
	}

	private sealed class _0006_2008
	{
		public _0006_0018 _000E;

		public string _0003;

		internal void _000E()
		{
			this._000E._0002_2005?.Invoke(_0003);
		}
	}

	private sealed class _0008
	{
		public _0006_0018 _000E;

		public int _0003;

		internal void _000E()
		{
			this._000E._0008_2005?.Invoke(_0003);
		}
	}

	private sealed class _000E
	{
		public _0006_0018 _000E;

		public string _0003;

		public string _0006;

		public int _000F;

		internal _0005_2003_200A _000E()
		{
			return this._000E._000E(_0003, _0006, 3);
		}

		internal _0002_2003_200A _000E()
		{
			int num;
			return new _0002_2003_200A(this._000E._000E(_0003, _0006, out num), num);
		}

		internal string _000E(int _000E)
		{
			return this._000E._000E(_0003, _0006, _000F, _000E);
		}

		internal bool _000E()
		{
			return this._000E._000E(_0003, _0006);
		}

		internal string _000E()
		{
			return this._000E._0006(_000F);
		}

		internal void _000E()
		{
			this._000E._000F(_0008_0017._000E(-1141179921));
		}
	}

	private enum _000E_0018
	{

	}

	private sealed class _000E_2008
	{
		public Action _000E;

		internal void _000E(object _000E)
		{
			this._000E();
		}
	}

	private sealed class _000F
	{
		public _0005_2008_200A _000E;

		public _0006_0018 _0003;

		internal void _000E()
		{
			_0003._0005_2005?.Invoke(this._000E);
		}
	}

	private sealed class _000F_2008
	{
		public _0005_2004 _000E;

		public IntPtr _0003;

		public Exception _0006;

		public _0006_0018 _000F;

		public Thread _0002;

		internal void _000E()
		{
			try
			{
				this._000E._0005_2004_2009_200B_2005_2005_000E(_0003);
			}
			catch (Exception ex)
			{
				_0006 = ex;
			}
			finally
			{
				_000F._0003_2002();
				lock (_000F.m__000F)
				{
					if (_000F.m__0006_2008 == _0002)
					{
						_000F.m__0006_2008 = null;
					}
				}
			}
		}
	}

	private IntPtr m__000E;

	private readonly object m__0003 = new object();

	private readonly object m__0006 = new object();

	private readonly object m__000F = new object();

	private _0005_2004 m__0002 = new _000F_2007_200A();

	private long m__0008;

	private long m__0005 = -1L;

	private readonly string m__000E_2008 = Guid.NewGuid().ToString(_0008_0017._000E(-1141300407));

	private _000E_2000 m__0003_2008;

	private Thread m__0006_2008;

	private int m__000F_2008 = 10000;

	private _0003_2007_200A._0003 m__0002_2008;

	private _0003_2007_200A._000E m__0008_2008;

	private readonly ManualResetEventSlim m__0005_2008 = new ManualResetEventSlim(initialState: false);

	private int m__000E_2007;

	private readonly ManualResetEventSlim m__0003_2007 = new ManualResetEventSlim(initialState: false);

	private int m__0006_2007;

	private int m__000F_2007;

	private long m__0002_2007 = -1L;

	private bool m__0008_2007;

	private string m__0005_2007;

	private _0002_2009 m__000E_2002;

	private bool m__0003_2002;

	private bool _0006_2002;

	private readonly ManualResetEventSlim _000F_2002 = new ManualResetEventSlim(initialState: false);

	private int _0002_2002;

	private int _0008_2002;

	private int _0005_2002;

	private long _000E_2006 = -1L;

	private _000E_2005 _0003_2006;

	private bool _0006_2006;

	private string _000F_2006;

	private bool _0002_2006;

	private string _0008_2006;

	private long _0005_2006 = -1L;

	private _0006_2005 _000E_2003 = global::_0006_2005._000E();

	private Func<_0006_2009> _0003_2003;

	private readonly ManualResetEventSlim _0006_2003 = new ManualResetEventSlim(initialState: false);

	private readonly ManualResetEventSlim _000F_2003 = new ManualResetEventSlim(initialState: false);

	private readonly ManualResetEventSlim _0002_2003 = new ManualResetEventSlim(initialState: false);

	private string _0008_2003;

	private string _0005_2003;

	private List<_000E_2008_200A> _000E_2001;

	private volatile bool _0003_2001;

	private volatile bool _0006_2001;

	private volatile bool _000F_2001;

	private volatile bool _0002_2001;

	private volatile bool _0008_2001;

	private volatile bool _0005_2001;

	private volatile bool _000E_200B;

	private volatile bool _0003_200B;

	private volatile bool _0006_200B;

	private volatile bool _000F_200B;

	private long _0002_200B;

	private bool? _0008_200B;

	private int _0005_200B;

	private readonly object _000E_2004 = new object();

	private long _0003_2004;

	private long _0006_2004;

	private int _000F_2004;

	private _0003_2006_200A _0002_2004;

	private readonly object _0008_2004 = new object();

	private long _0005_2004;

	private int _000E_2009;

	private _0005_2006_200A _0003_2009;

	private readonly object _0006_2009 = new object();

	private long _000F_2009;

	private int _0002_2009;

	private uint _0008_2009;

	private string _0005_2009;

	private _0008_2002_200A _000E_2005;

	private volatile (ushort, ushort)[] _0003_2005;

	private volatile _0008_200B_200A _0006_2005;

	public SynchronizationContext _000F_2005;

	private Action<string> _0002_2005;

	private Action<int> _0008_2005;

	private Action<_0005_2008_200A> _0005_2005;

	private Action<_000E_2007_200A> _000E_200A;

	private int _0003_200A;

	private int _0006_200A;

	private readonly object _000F_200A = new object();

	private uint _0002_200A;

	private string _0008_200A;

	private int _0005_200A;

	public string _000E_2000;

	private bool _0003_2000;

	public readonly Dictionary<string, string> _0006_2000 = new Dictionary<string, string>(StringComparer.Ordinal);

	public readonly Dictionary<string, string> _000F_2000 = new Dictionary<string, string>(StringComparer.Ordinal);

	public readonly Dictionary<string, string> _0002_2000 = new Dictionary<string, string>(StringComparer.Ordinal);

	public int _0008_2000 = 20;

	public int _0005_2000 = 3;

	private volatile _0006_2004_200A _000E_2008_200A = _0006_2004_200A._0006_2008;

	private readonly object _0003_2008_200A = new object();

	private bool _0006_2008_200A;

	private int _000F_2008_200A;

	private Func<int, Task> _0002_2008_200A;

	private Action<string> _0008_2008_200A;

	private Func<string, int, _0003_2009_200B._0003> _0005_2008_200A;

	private Action<int> _000E_2007_200A;

	private Func<global::_0003_0018> _0003_2007_200A;

	private Func<int, bool> _0006_2007_200A;

	private Func<int, bool> _000F_2007_200A;

	private Func<int, bool> _0002_2007_200A;

	private Action _0008_2007_200A;

	private Action _0005_2007_200A;

	private Action _000E_2002_200A;

	private Action<_0006_2004_200A> _0003_2002_200A;

	private Action<uint, int, bool, string> _0006_2002_200A;

	private Action<uint, bool, bool, string> _000F_2002_200A;

	private Action<int, bool, string> _0002_2002_200A;

	private Action<IReadOnlyList<string>> _0008_2002_200A;

	private Action<IReadOnlyList<_0005_200B_200A>> _0005_2002_200A;

	private Action<_0003_200A> _000E_2006_200A;

	private string _0003_2006_200A;

	private string _0006_2006_200A;

	private string _000F_2006_200A;

	private string _0002_2006_200A;

	private string _0008_2006_200A;

	private _000E_200B_200A._000E[] _0005_2006_200A;

	private string _000E_2003_200A;

	private string _0003_2003_200A;

	private string _0006_2003_200A;

	private readonly _0006_2008_200A._000E _000F_2003_200A = new _0006_2008_200A._000E();

	private readonly _0006_2008_200A._000E _0002_2003_200A = new _0006_2008_200A._000E();

	private readonly _0006_2008_200A._000E _0008_2003_200A = new _0006_2008_200A._000E();

	private static string _0005_2003_200A;

	public (ushort, ushort)[] _000E => _0003_2005;

	internal _000E_2000 _000E()
	{
		return this.m__0003_2008;
	}

	internal void _000E(_000E_2000 _000E)
	{
		this.m__0003_2008 = _000E;
	}

	public void _000E(Action<string> _000E)
	{
		Action<string> action = _0002_2005;
		Action<string> action2;
		do
		{
			action2 = action;
			Action<string> value = (Action<string>)Delegate.Combine(action2, _000E);
			action = Interlocked.CompareExchange(ref _0002_2005, value, action2);
		}
		while ((object)action != action2);
	}

	public void _0003(Action<string> _000E)
	{
		Action<string> action = _0002_2005;
		Action<string> action2;
		do
		{
			action2 = action;
			Action<string> value = (Action<string>)Delegate.Remove(action2, _000E);
			action = Interlocked.CompareExchange(ref _0002_2005, value, action2);
		}
		while ((object)action != action2);
	}

	public void _000E(Action<int> _000E)
	{
		Action<int> action = _0008_2005;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Combine(action2, _000E);
			action = Interlocked.CompareExchange(ref _0008_2005, value, action2);
		}
		while ((object)action != action2);
	}

	public void _0003(Action<int> _000E)
	{
		Action<int> action = _0008_2005;
		Action<int> action2;
		do
		{
			action2 = action;
			Action<int> value = (Action<int>)Delegate.Remove(action2, _000E);
			action = Interlocked.CompareExchange(ref _0008_2005, value, action2);
		}
		while ((object)action != action2);
	}

	public void _000E(Action<_0005_2008_200A> _000E)
	{
		Action<_0005_2008_200A> action = _0005_2005;
		Action<_0005_2008_200A> action2;
		do
		{
			action2 = action;
			Action<_0005_2008_200A> value = (Action<_0005_2008_200A>)Delegate.Combine(action2, _000E);
			action = Interlocked.CompareExchange(ref _0005_2005, value, action2);
		}
		while ((object)action != action2);
	}

	public void _0003(Action<_0005_2008_200A> _000E)
	{
		Action<_0005_2008_200A> action = _0005_2005;
		Action<_0005_2008_200A> action2;
		do
		{
			action2 = action;
			Action<_0005_2008_200A> value = (Action<_0005_2008_200A>)Delegate.Remove(action2, _000E);
			action = Interlocked.CompareExchange(ref _0005_2005, value, action2);
		}
		while ((object)action != action2);
	}

	public void _000E(Action<_000E_2007_200A> _000E)
	{
		Action<_000E_2007_200A> action = _000E_200A;
		Action<_000E_2007_200A> action2;
		do
		{
			action2 = action;
			Action<_000E_2007_200A> value = (Action<_000E_2007_200A>)Delegate.Combine(action2, _000E);
			action = Interlocked.CompareExchange(ref _000E_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public void _0003(Action<_000E_2007_200A> _000E)
	{
		Action<_000E_2007_200A> action = _000E_200A;
		Action<_000E_2007_200A> action2;
		do
		{
			action2 = action;
			Action<_000E_2007_200A> value = (Action<_000E_2007_200A>)Delegate.Remove(action2, _000E);
			action = Interlocked.CompareExchange(ref _000E_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public bool _000E()
	{
		return Volatile.Read(ref _0003_200A) != 0;
	}

	public uint _000E()
	{
		return _0002_200A;
	}

	private void _000E(uint _000E)
	{
		_0002_200A = _000E;
	}

	public string _000E()
	{
		return _0008_200A;
	}

	private void _000E(string _000E)
	{
		_0008_200A = _000E;
	}

	public int _000E()
	{
		return _0005_200A;
	}

	private void _000E(int _000E)
	{
		_0005_200A = _000E;
	}

	public bool _0003()
	{
		return _0003_2000;
	}

	private void _000E(bool _000E)
	{
		_0003_2000 = _000E;
	}

	public _0008_200B_200A _000E()
	{
		return _0006_2005;
	}

	internal _0003_2006_200A _000E()
	{
		return Volatile.Read(ref _0002_2004);
	}

	internal long _000E()
	{
		return Interlocked.Read(ref _0003_2004);
	}

	internal long _0003()
	{
		return Interlocked.Read(ref _0006_2004);
	}

	internal _0005_2006_200A _000E()
	{
		return Volatile.Read(ref _0003_2009);
	}

	internal long _0006()
	{
		return Interlocked.Read(ref _0005_2004);
	}

	internal _0008_2002_200A _000E()
	{
		return Volatile.Read(ref _000E_2005);
	}

	internal long _000F()
	{
		return Interlocked.Read(ref _000F_2009);
	}

	internal bool _0006()
	{
		lock (_0006_2009)
		{
			return _0008_2009 != 0;
		}
	}

	public bool _000F()
	{
		return Volatile.Read(ref _0006_200A) != 0;
	}

	internal void _000E(Func<int, Task> _000E)
	{
		_0002_2008_200A = _000E;
	}

	internal void _0006(Action<string> _000E)
	{
		Volatile.Write(ref _0008_2008_200A, _000E);
	}

	internal void _000E(Func<string, int, _0003_2009_200B._0003> _000E)
	{
		_0005_2008_200A = _000E;
	}

	internal void _0006(Action<int> _000E)
	{
		_000E_2007_200A = _000E;
	}

	internal void _000E(Func<global::_0003_0018> _000E)
	{
		_0003_2007_200A = _000E;
	}

	internal void _000E(_0005_2004 _000E)
	{
		this.m__0002 = _000E ?? new _000F_2007_200A();
	}

	internal void _000E(Func<int, bool> _000E)
	{
		_0006_2007_200A = _000E;
	}

	internal void _0003(Func<int, bool> _000E)
	{
		_000F_2007_200A = _000E;
	}

	internal void _0006(Func<int, bool> _000E)
	{
		_0002_2007_200A = _000E;
	}

	internal void _000E(Func<_0006_2009> _000E)
	{
		_0003_2003 = _000E;
	}

	internal void _000E(_0002_2009 _000E)
	{
		this.m__000E_2002 = _000E;
	}

	internal void _000E(Action _000E)
	{
		_0008_2007_200A = _000E;
	}

	internal void _0003(Action _000E)
	{
		_0005_2007_200A = _000E;
	}

	internal void _0006(Action _000E)
	{
		_000E_2002_200A = _000E;
	}

	internal void _0003(int _000E)
	{
		Interlocked.Exchange(ref _0005_200B, _000E);
	}

	internal void _000E(long _000E)
	{
		Interlocked.Exchange(ref this.m__0008, _000E);
	}

	internal void _000E(IntPtr _000E, IntPtr _0003, int _0006, IntPtr _000F)
	{
		this._0003(_000E, _0003, _0006, _000F);
	}

	internal void _0003(uint _000E)
	{
		this._000E(_000E);
	}

	internal IntPtr _000E()
	{
		return this.m__000E;
	}

	internal void _0006(int _000E)
	{
		this.m__000F_2008 = _000E;
	}

	internal bool _0002()
	{
		return _0005_2007();
	}

	internal _0006_2005 _000E()
	{
		lock (this.m__0006)
		{
			return _000E_2003;
		}
	}

	public _0006_2004_200A _000E()
	{
		return _000E_2008_200A;
	}

	public void _000E(Action<_0006_2004_200A> _000E)
	{
		Action<_0006_2004_200A> action = _0003_2002_200A;
		Action<_0006_2004_200A> action2;
		do
		{
			action2 = action;
			Action<_0006_2004_200A> value = (Action<_0006_2004_200A>)Delegate.Combine(action2, _000E);
			action = Interlocked.CompareExchange(ref _0003_2002_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public void _0003(Action<_0006_2004_200A> _000E)
	{
		Action<_0006_2004_200A> action = _0003_2002_200A;
		Action<_0006_2004_200A> action2;
		do
		{
			action2 = action;
			Action<_0006_2004_200A> value = (Action<_0006_2004_200A>)Delegate.Remove(action2, _000E);
			action = Interlocked.CompareExchange(ref _0003_2002_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public void _000E(Action<uint, int, bool, string> _000E)
	{
		Action<uint, int, bool, string> action = _0006_2002_200A;
		Action<uint, int, bool, string> action2;
		do
		{
			action2 = action;
			Action<uint, int, bool, string> value = (Action<uint, int, bool, string>)Delegate.Combine(action2, _000E);
			action = Interlocked.CompareExchange(ref _0006_2002_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public void _0003(Action<uint, int, bool, string> _000E)
	{
		Action<uint, int, bool, string> action = _0006_2002_200A;
		Action<uint, int, bool, string> action2;
		do
		{
			action2 = action;
			Action<uint, int, bool, string> value = (Action<uint, int, bool, string>)Delegate.Remove(action2, _000E);
			action = Interlocked.CompareExchange(ref _0006_2002_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public void _000E(Action<uint, bool, bool, string> _000E)
	{
		Action<uint, bool, bool, string> action = _000F_2002_200A;
		Action<uint, bool, bool, string> action2;
		do
		{
			action2 = action;
			Action<uint, bool, bool, string> value = (Action<uint, bool, bool, string>)Delegate.Combine(action2, _000E);
			action = Interlocked.CompareExchange(ref _000F_2002_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public void _0003(Action<uint, bool, bool, string> _000E)
	{
		Action<uint, bool, bool, string> action = _000F_2002_200A;
		Action<uint, bool, bool, string> action2;
		do
		{
			action2 = action;
			Action<uint, bool, bool, string> value = (Action<uint, bool, bool, string>)Delegate.Remove(action2, _000E);
			action = Interlocked.CompareExchange(ref _000F_2002_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public void _000E(Action<int, bool, string> _000E)
	{
		Action<int, bool, string> action = _0002_2002_200A;
		Action<int, bool, string> action2;
		do
		{
			action2 = action;
			Action<int, bool, string> value = (Action<int, bool, string>)Delegate.Combine(action2, _000E);
			action = Interlocked.CompareExchange(ref _0002_2002_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public void _0003(Action<int, bool, string> _000E)
	{
		Action<int, bool, string> action = _0002_2002_200A;
		Action<int, bool, string> action2;
		do
		{
			action2 = action;
			Action<int, bool, string> value = (Action<int, bool, string>)Delegate.Remove(action2, _000E);
			action = Interlocked.CompareExchange(ref _0002_2002_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public void _000E(Action<IReadOnlyList<string>> _000E)
	{
		Action<IReadOnlyList<string>> action = _0008_2002_200A;
		Action<IReadOnlyList<string>> action2;
		do
		{
			action2 = action;
			Action<IReadOnlyList<string>> value = (Action<IReadOnlyList<string>>)Delegate.Combine(action2, _000E);
			action = Interlocked.CompareExchange(ref _0008_2002_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public void _0003(Action<IReadOnlyList<string>> _000E)
	{
		Action<IReadOnlyList<string>> action = _0008_2002_200A;
		Action<IReadOnlyList<string>> action2;
		do
		{
			action2 = action;
			Action<IReadOnlyList<string>> value = (Action<IReadOnlyList<string>>)Delegate.Remove(action2, _000E);
			action = Interlocked.CompareExchange(ref _0008_2002_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public void _000E(Action<IReadOnlyList<_0005_200B_200A>> _000E)
	{
		Action<IReadOnlyList<_0005_200B_200A>> action = _0005_2002_200A;
		Action<IReadOnlyList<_0005_200B_200A>> action2;
		do
		{
			action2 = action;
			Action<IReadOnlyList<_0005_200B_200A>> value = (Action<IReadOnlyList<_0005_200B_200A>>)Delegate.Combine(action2, _000E);
			action = Interlocked.CompareExchange(ref _0005_2002_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public void _0003(Action<IReadOnlyList<_0005_200B_200A>> _000E)
	{
		Action<IReadOnlyList<_0005_200B_200A>> action = _0005_2002_200A;
		Action<IReadOnlyList<_0005_200B_200A>> action2;
		do
		{
			action2 = action;
			Action<IReadOnlyList<_0005_200B_200A>> value = (Action<IReadOnlyList<_0005_200B_200A>>)Delegate.Remove(action2, _000E);
			action = Interlocked.CompareExchange(ref _0005_2002_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public void _000E(Action<_0003_200A> _000E)
	{
		Action<_0003_200A> action = _000E_2006_200A;
		Action<_0003_200A> action2;
		do
		{
			action2 = action;
			Action<_0003_200A> value = (Action<_0003_200A>)Delegate.Combine(action2, _000E);
			action = Interlocked.CompareExchange(ref _000E_2006_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public void _0003(Action<_0003_200A> _000E)
	{
		Action<_0003_200A> action = _000E_2006_200A;
		Action<_0003_200A> action2;
		do
		{
			action2 = action;
			Action<_0003_200A> value = (Action<_0003_200A>)Delegate.Remove(action2, _000E);
			action = Interlocked.CompareExchange(ref _000E_2006_200A, value, action2);
		}
		while ((object)action != action2);
	}

	public bool _000E(string _000E, string _0003, int _0006)
	{
		lock (this.m__0003)
		{
			return this._0003(_000E, _0003, _0006);
		}
	}

	private bool _0003(string _000E, string _0003, int _0006)
	{
		this._000E(_0003);
		this._000E(_0006);
		_000E_2002();
		if (_0005_2007())
		{
			_000F(_0008_0017._000E(-1141180088));
			return false;
		}
		string text = this._000E(_000E, _0003, _0006);
		if (text != null)
		{
			_000F(_0008_0017._000E(-1141180174) + text);
			return false;
		}
		text = this._0003(_000E, _0003);
		if (text != null)
		{
			_000F(_0008_0017._000E(-1141180174) + text);
			return false;
		}
		text = this._000E(_000E, _0003);
		if (text != null)
		{
			_000F(_0008_0017._000E(-1141180174) + text);
			return false;
		}
		text = this._0006(_0006);
		if (text != null)
		{
			this._000E(_000E, _0003, _0006, ref text);
			if (text != null)
			{
				_000F(_0008_0017._000E(-1141180174) + text);
				return false;
			}
		}
		if (!_0008())
		{
			return false;
		}
		Volatile.Write(ref _0003_200A, 1);
		_0006_0018._000E(_0003, this._000E());
		_000F(_0008_0017._000E(-1141180178));
		return true;
	}

	public bool _0006(string _000E, string _0003, int _0006)
	{
		lock (this.m__0003)
		{
			return _000F(_000E, _0003, _0006);
		}
	}

	private bool _000F(string _000E, string _0003, int _0006)
	{
		this._000E(_0003);
		this._000E(_0006);
		_000E_2002();
		if (_0005_2007())
		{
			_000F(_0008_0017._000E(-1141180262));
			return false;
		}
		string text = this._000E(_000E, _0003, _0006);
		if (text != null)
		{
			_000F(_0008_0017._000E(-1141180337) + text);
			return false;
		}
		text = this._0006(_000E, _0003);
		if (text != null)
		{
			_000F(_0008_0017._000E(-1141180337) + text);
			return false;
		}
		if (!_0006_0018._000E(_0003, this._000E()))
		{
			_000F(_0008_0017._000E(-1141180360) + this._000E() + _0008_0017._000E(-1141180384) + _0006_0018._000E(_0003) + _0008_0017._000E(-1141179405));
			return false;
		}
		text = _0002(_000E, _0003);
		if (text != null)
		{
			_000F(_0008_0017._000E(-1141180337) + text);
			return false;
		}
		text = this._000E(_000E, _0003);
		if (text != null)
		{
			_000F(_0008_0017._000E(-1141180337) + text);
			return false;
		}
		text = this._0006(_0006);
		if (text != null)
		{
			this._000E(_000E, _0003, _0006, ref text);
			if (text != null)
			{
				_000F(_0008_0017._000E(-1141180337) + text);
				return false;
			}
		}
		if (!_0008())
		{
			return false;
		}
		Volatile.Write(ref _0003_200A, 1);
		_000F(_0008_0017._000E(-1141179431));
		return true;
	}

	private static string _000E(string _000E)
	{
		return _0008_0017._000E(-1141179483) + (_000E ?? string.Empty);
	}

	internal static void _000E(string _000E, uint _0003)
	{
		_0008_2004_200A._000E(_0006_0018._000E(_000E), _0003.ToString(CultureInfo.InvariantCulture));
	}

	internal static uint _000E(string _000E)
	{
		if (!uint.TryParse(_0008_2004_200A._000E(_0006_0018._000E(_000E), string.Empty), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
		{
			return 0u;
		}
		return result;
	}

	internal static bool _000E(string _000E, uint _0003)
	{
		if (_0003 != 0)
		{
			return _0003 == _0006_0018._000E(_000E);
		}
		return false;
	}

	private string _000E(string _000E, string _0003, int _0006)
	{
		string text = _0003_2009_200B._000E(_000E, _0003, _0008_0017._000E(-1141303611), 8000).Trim();
		if (text != _0008_0017._000E(-1141303627))
		{
			return _0008_0017._000E(-1141179509) + text;
		}
		int num;
		if (_0006_200B_200A._000E())
		{
			string text2 = this._000E(_000E, _0003, out num);
			if (text2 != null)
			{
				return text2;
			}
		}
		else
		{
			string text3 = _0005(_000E, _0003);
			if (text3 != null)
			{
				return text3;
			}
			num = 27042;
			_000E_2000 = null;
		}
		return this._000E(_000E, _0003, _0006, num);
	}

	private string _000E(string _000E, string _0003)
	{
		try
		{
			this.m__000E_2002 = global::_000F_2009._000E(_000E, _0003);
			_000F(_0008_0017._000E(-1141179530) + this.m__000E_2002._0002);
			return null;
		}
		catch (Exception ex)
		{
			this.m__000E_2002 = null;
			return _0008_0017._000E(-1141179589) + ex.Message;
		}
	}

	private bool _000E(string _000E, string _0003, int _0006, ref string _000F)
	{
		_000E obj = new _000E();
		obj._000E = this;
		obj._0003 = _000E;
		obj._0006 = _0003;
		obj._000F = _0006;
		if (_0005_2007())
		{
			_000F += _0008_0017._000E(-1141179637);
			return false;
		}
		_000F_2001_200A obj2 = new _000F_2001_200A
		{
			_000E = obj._000E,
			_0003 = obj._000E,
			_0006 = obj._000E,
			_000F = obj._000E,
			_0002 = obj._000E,
			_0008 = obj._000E
		};
		_0002_2001_200A obj3 = global::_0006_2003_200A._000E(_000F, _0006_200B_200A._000E(), obj2);
		_000F = obj3._0003;
		if (obj3._000E && _000F == null)
		{
			this._000F(_0008_0017._000E(-1141179720) + this._000E());
		}
		else if (!obj3._000E && _000F != null && _000F.IndexOf(_0008_0017._000E(-1141179770), StringComparison.OrdinalIgnoreCase) >= 0)
		{
			this._000F(_0008_0017._000E(-1141180174) + _000F);
		}
		return obj3._000E;
	}

	private bool _000E(string _000E, string _0003)
	{
		string[] array = this._000E(_000E, _0003, _0008_0017._000E(-1141179801), 8000).Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			if (uint.TryParse(array[i], out var result) && result == this._000E())
			{
				return true;
			}
		}
		return false;
	}

	private string _0003(string _000E, string _0003)
	{
		_000F(_0008_0017._000E(-1141179841));
		_0003_2009_200B._000E(_000E, _0003, _0008_0017._000E(-1141179893), 15000);
		_0003_2009_200B._000E(_000E, _0003, _0008_0017._000E(-1141185061), 20000);
		return _000F(_000E, _0003);
	}

	private string _0006(string _000E, string _0003)
	{
		for (int i = 0; i < 30; i++)
		{
			if (uint.TryParse(_0003_2009_200B._000E(_000E, _0003, _0008_0017._000E(-1141179801), 8000).Trim().Split(' ')[0], out var result) && result != 0)
			{
				this._000E(result);
				_000F(_0008_0017._000E(-1141185143) + result);
				return null;
			}
			Thread.Sleep(1000);
		}
		return _0008_0017._000E(-1141185159);
	}

	private string _000F(string _000E, string _0003)
	{
		string text = _0006(_000E, _0003);
		if (text != null)
		{
			return text;
		}
		return _0002(_000E, _0003);
	}

	private string _0002(string _000E, string _0003)
	{
		DateTime utcNow = DateTime.UtcNow;
		for (int i = 0; i < 90; i++)
		{
			if (int.TryParse(_0003_2009_200B._000E(_000E, _0003, _0008_0017._000E(-1141185189) + this._000E() + _0008_0017._000E(-1141185232), 8000).Trim(), out var result) && result > 0)
			{
				_000F(_0008_0017._000E(-1141185245) + (int)(DateTime.UtcNow - utcNow).TotalMilliseconds + _0008_0017._000E(-1141185280));
				return null;
			}
			Thread.Sleep(1000);
		}
		return _0008_0017._000E(-1141185282);
	}

	internal string _000E(int _000E)
	{
		return this._000E(_000E, _0003: false);
	}

	internal string _000E(int _000E, bool _0003)
	{
		lock (this.m__0003)
		{
			this.m__0003_2002 = !_0003;
			_0006_2002 = true;
			try
			{
				return _0006(_000E);
			}
			finally
			{
				this.m__0003_2002 = false;
				_0006_2002 = false;
			}
		}
	}

	internal string _0003(int _000E)
	{
		lock (this.m__0003)
		{
			return _0006(_000E);
		}
	}

	private string _0006(int _000E)
	{
		if (_0005_2007())
		{
			return _0008_0017._000E(-1141185336);
		}
		IntPtr intPtr = this.m__0002._0005_2004_2009_200B_2005_2005_000E();
		if (intPtr == IntPtr.Zero)
		{
			return _0008_0017._000E(-1141185403);
		}
		bool flag = false;
		long num = Interlocked.Increment(ref this.m__0008);
		try
		{
			this.m__0005_2008.Reset();
			lock (this.m__0006)
			{
				Volatile.Write(ref this.m__000E_2007, 0);
				this.m__0005 = -1L;
			}
			this.m__0002_2008 = _0003;
			this.m__0008_2008 = this._000E;
			this.m__0002._0005_2004_2009_200B_2005_2005_000E(intPtr, this.m__0002_2008, this.m__0008_2008, new IntPtr(num));
			string text = _0008_0017._000E(-1141185425) + _000E;
			if (this.m__0002._0005_2004_2009_200B_2005_2005_000E(intPtr, text, _000E_2000, 5000) == 0)
			{
				return _0008_0017._000E(-1141185442) + text + _0008_0017._000E(-1141203195) + this.m__0002._0005_2004_2009_200B_2005_2005_000E(intPtr);
			}
			_000F(_0008_0017._000E(-1141185457) + text);
			if (this.m__0002._0005_2004_2009_200B_2005_2005_000E(intPtr, this._000E(), 1) == 0)
			{
				return _0008_0017._000E(-1141185504) + this.m__0002._0005_2004_2009_200B_2005_2005_000E(intPtr);
			}
			_000F(_0008_0017._000E(-1141185526));
			string text2 = _0006_0018._0003();
			if (string.IsNullOrEmpty(text2))
			{
				return _0008_0017._000E(-1141184552);
			}
			if (this.m__0002._0005_2004_2009_200B_2005_2005_000E(intPtr, text2, 0) == 0)
			{
				return _0008_0017._000E(-1141184593) + this.m__0002._0005_2004_2009_200B_2005_2005_000E(intPtr);
			}
			Func<int, bool> func = _0006_2007_200A;
			bool num2;
			if (func == null)
			{
				if (!this.m__0005_2008.Wait(30000))
				{
					goto IL_0214;
				}
				num2 = Volatile.Read(ref this.m__000E_2007) != 0;
			}
			else
			{
				num2 = func(30000);
			}
			if (num2)
			{
				_0008_2007_200A?.Invoke();
				string text3 = this._000E(intPtr, num);
				if (text3 != null)
				{
					return text3;
				}
				if (!_0006_2002)
				{
					string text4 = _0003(intPtr, num);
					if (text4 != null)
					{
						return text4;
					}
				}
				lock (this.m__0006)
				{
					if (num != Interlocked.Read(ref this.m__0008) || this.m__0005 == num || (func == null && Volatile.Read(ref this.m__000E_2007) == 0))
					{
						return _0008_0017._000E(-1141184654);
					}
					this.m__000E = intPtr;
					flag = true;
				}
				return null;
			}
			goto IL_0214;
			IL_0214:
			return _0008_0017._000E(-1141184621);
		}
		finally
		{
			if (!flag)
			{
				lock (this.m__0006)
				{
					Interlocked.CompareExchange(ref this.m__0008, num + 1, num);
				}
				this._000E(intPtr);
			}
		}
	}

	private string _000E(IntPtr _000E, long _0003)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		_0002_2009 obj = this.m__000E_2002;
		if (obj == null)
		{
			if (!this.m__0003_2002)
			{
				return _0008_0017._000E(-1141184694);
			}
			return null;
		}
		int num;
		do
		{
			num = Interlocked.Increment(ref this.m__0006_2007);
		}
		while (num <= 0);
		lock (this.m__0006)
		{
			if (_0003 != Interlocked.Read(ref this.m__0008) || this.m__0005 == _0003)
			{
				return _0008_0017._000E(-1141184751);
			}
			this.m__0003_2007.Reset();
			this.m__000F_2007 = num;
			this.m__0002_2007 = -1L;
			this.m__0008_2007 = false;
			this.m__0005_2007 = null;
		}
		string text = ((JToken)new JObject
		{
			[_0008_0017._000E(-1141254460)] = JToken.op_Implicit(_0008_0017._000E(-1141253277)),
			[_0008_0017._000E(-1141255964)] = JToken.op_Implicit(num),
			[_0008_0017._000E(-1141342523)] = JToken.op_Implicit(obj._000E),
			[_0008_0017._000E(-1141299812)] = JToken.op_Implicit(obj._000F),
			[_0008_0017._000E(-1141299845)] = JToken.op_Implicit(obj._0002)
		}).ToString((Formatting)0, Array.Empty<JsonConverter>());
		this.m__0002._0005_2004_2009_200B_2005_2005_000E(_000E, text, (byte[])null, 0);
		bool flag = _000F_2007_200A?.Invoke(10000) ?? this.m__0003_2007.Wait(10000);
		lock (this.m__0006)
		{
			if (_0003 != Interlocked.Read(ref this.m__0008) || this.m__0005 == _0003)
			{
				return _0008_0017._000E(-1141184807);
			}
			if (!flag)
			{
				return _0008_0017._000E(-1141184863);
			}
			if (this.m__0002_2007 != _0003 || this.m__000F_2007 != num || this.m__0005_2007 == null)
			{
				return _0008_0017._000E(-1141184918);
			}
			if (!this.m__0008_2007)
			{
				return _0008_0017._000E(-1141184970) + this.m__0005_2007;
			}
		}
		_000F(_0008_0017._000E(-1141185009));
		return null;
	}

	private string _0003(IntPtr _000E, long _0003)
	{
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		Func<_0006_2009> func = _0003_2003;
		if (func == null)
		{
			return _0008_0017._000E(-1141186095);
		}
		_0006_2009 obj;
		try
		{
			obj = func();
			global::_0005_2009._000E(obj);
		}
		catch
		{
			return _0008_0017._000E(-1141186158);
		}
		Stopwatch stopwatch = Stopwatch.StartNew();
		int num = this._0003();
		lock (this.m__0006)
		{
			if (!this._000E(_0003))
			{
				return _0008_0017._000E(-1141186223);
			}
			_000F_2002.Reset();
			_0008_2002 = num;
			_0005_2002 = 0;
			_000E_2006 = -1L;
			_0003_2006 = null;
			_0006_2006 = false;
			_000F_2006 = null;
			_0002_2006 = true;
			_0008_2006 = null;
			_0005_2006 = -1L;
			_000E_2003 = global::_0006_2005._000E();
		}
		try
		{
			this.m__0002._0005_2004_2009_200B_2005_2005_000E(_000E, ((JToken)new JObject
			{
				[_0008_0017._000E(-1141254460)] = JToken.op_Implicit(_0008_0017._000E(-1141253410)),
				[_0008_0017._000E(-1141255964)] = JToken.op_Implicit(num)
			}).ToString((Formatting)0, Array.Empty<JsonConverter>()), (byte[])null, 0);
		}
		catch
		{
			this._000E(_000E, null);
			this._0003(_0003);
			return _0008_0017._000E(-1141186278);
		}
		if (!this._000E(stopwatch))
		{
			this._000E(_000E, null);
			this._0003(_0003);
			return _0008_0017._000E(-1141186318);
		}
		bool flag;
		bool flag2;
		_000E_2005 obj4;
		string text;
		lock (this.m__0006)
		{
			flag = !this._000E(_0003);
			flag2 = !flag && (_000E_2006 != _0003 || _0008_2002 != num || (_0003_2006 == null && _000F_2006 == null));
			obj4 = _0003_2006;
			text = _000F_2006;
		}
		if (flag)
		{
			this._000E(_000E, null);
			return _0008_0017._000E(-1141186364);
		}
		if (flag2)
		{
			this._000E(_000E, null);
			this._0003(_0003);
			return _0008_0017._000E(-1141186419);
		}
		if (obj4 == null)
		{
			this._000E(_000E, null);
			this._0003(_0003);
			return _0008_0017._000E(-1141186486) + text;
		}
		int num2 = this._0003();
		_0005_2009 obj5;
		try
		{
			obj5 = global::_0005_2009._000E(obj4, obj);
		}
		catch
		{
			this._000E(_000E, obj4._000E());
			this._0003(_0003);
			return _0008_0017._000E(-1141186525);
		}
		using (_0005_2009 obj7 = obj5)
		{
			lock (this.m__0006)
			{
				if (!this._000E(_0003))
				{
					return _0008_0017._000E(-1141185552);
				}
				_000F_2002.Reset();
				_0008_2002 = 0;
				_0005_2002 = num2;
				_000E_2006 = -1L;
				_0006_2006 = false;
				_000F_2006 = null;
			}
			try
			{
				this.m__0002._0005_2004_2009_200B_2005_2005_000E(_000E, ((JToken)new JObject
				{
					[_0008_0017._000E(-1141254460)] = JToken.op_Implicit(_0008_0017._000E(-1141258880)),
					[_0008_0017._000E(-1141255964)] = JToken.op_Implicit(num2),
					[_0008_0017._000E(-1141253472)] = JToken.op_Implicit(obj4._000E()),
					[_0008_0017._000E(-1141346339)] = JToken.op_Implicit(global::_0008_2009._000E(obj7._000E)),
					[_0008_0017._000E(-1141346361)] = JToken.op_Implicit(global::_0008_2009._000E(obj7._0003)),
					[_0008_0017._000E(-1141346381)] = JToken.op_Implicit(global::_0008_2009._000E(obj7._0006)),
					[_0008_0017._000E(-1141346391)] = JToken.op_Implicit(global::_0008_2009._000E(obj7._000F))
				}).ToString((Formatting)0, Array.Empty<JsonConverter>()), (byte[])null, 0);
			}
			catch
			{
				this._000E(_000E, obj4._000E());
				this._0003(_0003);
				return _0008_0017._000E(-1141185594);
			}
		}
		if (!this._000E(stopwatch))
		{
			this._000E(_000E, obj4._000E());
			this._0003(_0003);
			return _0008_0017._000E(-1141185647);
		}
		bool flag3;
		bool flag4;
		bool flag5;
		lock (this.m__0006)
		{
			flag3 = !this._000E(_0003);
			flag4 = !flag3 && (_000E_2006 != _0003 || _0005_2002 != num2 || _000F_2006 == null);
			flag5 = !flag4 && _0006_2006;
			text = _000F_2006;
			if (!flag3 && !flag4 && flag5)
			{
				_0005_2002 = 0;
			}
		}
		if (flag3)
		{
			this._000E(_000E, obj4._000E());
			return _0008_0017._000E(-1141185696);
		}
		if (flag4)
		{
			this._000E(_000E, obj4._000E());
			this._0003(_0003);
			return _0008_0017._000E(-1141185738);
		}
		if (!flag5)
		{
			this._000E(_000E, obj4._000E());
			this._0003(_0003);
			return _0008_0017._000E(-1141185815) + text;
		}
		_000F(_0008_0017._000E(-1141185854));
		return null;
	}

	private bool _000E(Stopwatch _000E)
	{
		int num = 30000 - (int)Math.Min(30000L, _000E.ElapsedMilliseconds);
		if (num <= 0)
		{
			return false;
		}
		return _0002_2007_200A?.Invoke(num) ?? _000F_2002.Wait(num);
	}

	private int _0003()
	{
		int num;
		while (true)
		{
			num = Interlocked.Increment(ref _0002_2002);
			if (num > 0)
			{
				break;
			}
			if (num == int.MinValue)
			{
				Interlocked.CompareExchange(ref _0002_2002, 0, num);
			}
		}
		return num;
	}

	private bool _000E(long _000E)
	{
		if (_000E == Interlocked.Read(ref this.m__0008))
		{
			return this.m__0005 != _000E;
		}
		return false;
	}

	private void _000E(IntPtr _000E, string _0003)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		if (_000E == IntPtr.Zero)
		{
			return;
		}
		try
		{
			JObject val = new JObject { [_0008_0017._000E(-1141254460)] = JToken.op_Implicit(_0008_0017._000E(-1141348199)) };
			if (!string.IsNullOrEmpty(_0003))
			{
				val[_0008_0017._000E(-1141253472)] = JToken.op_Implicit(_0003);
			}
			this.m__0002._0005_2004_2009_200B_2005_2005_000E(_000E, ((JToken)val).ToString((Formatting)0, Array.Empty<JsonConverter>()), (byte[])null, 0);
		}
		catch
		{
		}
	}

	private void _0003(long _000E)
	{
		lock (this.m__0006)
		{
			if (_0005_2006 == _000E || _0005_2006 == -1)
			{
				this._000E();
			}
		}
	}

	private void _000E()
	{
		_000F_2002.Reset();
		_0008_2002 = 0;
		_0005_2002 = 0;
		_000E_2006 = -1L;
		_0003_2006 = null;
		_0006_2006 = false;
		_000F_2006 = null;
		_0002_2006 = false;
		_0008_2006 = null;
		_0005_2006 = -1L;
		_000E_2003 = global::_0006_2005._000E();
	}

	private bool _0008()
	{
		long num = Interlocked.Read(ref this.m__0008);
		string text = global::_000F_2005._000E();
		if (text == null)
		{
			_000F(_0008_0017._000E(-1141185911));
			return false;
		}
		_000F_2003.Reset();
		_0003_2001 = false;
		_0005_2001 = false;
		_0006_2001 = false;
		_000F_2001 = false;
		_0002_2001 = false;
		_0008_2001 = false;
		_000E_200B = false;
		_0003_200B = false;
		_0006_200B = false;
		_0002();
		_0002_2008();
		_0008_2008();
		_0005_2008();
		_000E_2008_200A = _0006_2004_200A._0006_2008;
		_0005_2003 = null;
		_0006(text);
		if (!_000F_2003.Wait(15000))
		{
			_000F(_0008_0017._000E(-1141185948));
			return false;
		}
		if (!_0006_0018._000E(_0005_2003, _0008_0017._000E(-1141303993)))
		{
			_000F(_0008_0017._000E(-1141185996) + _0005_2003);
			return false;
		}
		_0003_2001 = _0006_0018._000E(_0005_2003, _0008_0017._000E(-1141186025));
		_0005_2001 = _0006_0018._000E(_0005_2003, _0008_0017._000E(-1141186048));
		_0006_2001 = _0006_0018._000E(_0005_2003, _0008_0017._000E(-1141182985));
		_000F_2001 = _0006_0018._000E(_0005_2003, _0008_0017._000E(-1141183002));
		_0002_2001 = _0006_0018._000E(_0005_2003, _0008_0017._000E(-1141147734));
		_0008_2001 = _0006_0018._000E(_0005_2003, _0008_0017._000E(-1141183018));
		_000E_200B = _0006_0018._000E(_0005_2003, _0008_0017._000E(-1141183033));
		_0003_200B = _0006_0018._000E(_0005_2003, _0008_0017._000E(-1141183052));
		_0006_200B = _0006_0018._000E(_0005_2003, _0008_0017._000E(-1141183079));
		_000E(_0005_2003, num);
		if (global::_0008_200B._000E_2008() && !_0003_2001)
		{
			_000F(_0008_0017._000E(-1141183094));
		}
		if (global::_0008_200B._000F_2002() && !_0005_2001)
		{
			_000F(_0008_0017._000E(-1141183154));
		}
		if (global::_0008_200B._0003_2008() && !_0006_2001)
		{
			_000F(_0008_0017._000E(-1141183226));
		}
		if (global::_0008_200B._0006_2008() && !_000F_2001)
		{
			_000F(_0008_0017._000E(-1141183301));
		}
		if (global::_0008_200B._0006_2007() && !_0002_2001)
		{
			_000F(_0008_0017._000E(-1141183366));
		}
		if (global::_0008_200B._000F_2007() && !_0008_2001)
		{
			_000F(_0008_0017._000E(-1141183430));
		}
		if (global::_0008_200B._0005_2007() && !_000E_200B)
		{
			_000F(_0008_0017._000E(-1141182488));
		}
		if (global::_0008_200B._000E_2002() && !_0003_200B)
		{
			_000F(_0008_0017._000E(-1141182556));
		}
		_000F(_0008_0017._000E(-1141182639) + _0005_2003);
		return true;
	}

	public bool _000E(int _000E)
	{
		DateTime dateTime = DateTime.UtcNow.AddMilliseconds(_000E);
		int num = 0;
		while (DateTime.UtcNow < dateTime)
		{
			_0006_2003.Reset();
			_0006(_0008_0017._000E(-1141182651));
			if (_0006_2003.Wait(2000) && _0006_0018._000E(_0008_2003, _0008_0017._000E(-1141303993)))
			{
				_000F(_0008_0017._000E(-1141182675) + _0008_2003);
				return true;
			}
			if (++num % 5 == 0)
			{
				_000F(_0008_0017._000E(-1141182691) + num + _0008_0017._000E(-1141253640));
			}
			Thread.Sleep(1000);
		}
		_000F(_0008_0017._000E(-1141182724) + _0008_2003);
		return false;
	}

	public List<_000E_2008_200A> _000E(int _000E)
	{
		if (this.m__000E == IntPtr.Zero)
		{
			return null;
		}
		_000E_2001 = null;
		_0002_2003.Reset();
		_0006(_0008_0017._000E(-1141182758));
		if (!_0002_2003.Wait(_000E))
		{
			_000F(_0008_0017._000E(-1141182777));
			return null;
		}
		return _000E_2001;
	}

	public void _0003()
	{
		_0006(_0008_0017._000E(-1141182801));
	}

	public void _0006()
	{
		if (this.m__000E == IntPtr.Zero || !this._000E())
		{
			_000F(_0008_0017._000E(-1141182846));
			return;
		}
		lock (_000F_200A)
		{
			if (this.m__000E == IntPtr.Zero || !this._000E() || Volatile.Read(ref _0006_200A) != 0)
			{
				return;
			}
			if (_0005_2000 > 0)
			{
				_0006(_0003_2004_200A._000E(_0008_0017._000E(-1141114512), _0005_2000));
			}
			if (_0008_2000 > 0)
			{
				_0006(_0003_2004_200A._000E(_0008_0017._000E(-1141114503), _0008_2000));
			}
			Volatile.Write(ref _0006_200A, 1);
		}
		_000F(_0008_0017._000E(-1141182890) + ((_0008_2000 > 0) ? (_0008_0017._000E(-1141182929) + _0008_2000) : _0008_0017._000E(-1141182915)) + ((_0005_2000 > 0) ? (_0008_0017._000E(-1141182954) + _0005_2000) : _0008_0017._000E(-1141182940)));
	}

	public void _000F()
	{
		lock (_000F_200A)
		{
			if (Volatile.Read(ref _0006_200A) == 0)
			{
				return;
			}
			_0006(_0003_2004_200A._000E(_0008_0017._000E(-1141114503)));
			_0006(_0003_2004_200A._000E(_0008_0017._000E(-1141114512)));
			Volatile.Write(ref _0006_200A, 0);
		}
		_000F(_0008_0017._000E(-1141182973));
	}

	public bool _0005()
	{
		return global::_0008_200B._0003();
	}

	public bool _000E_2008()
	{
		if (global::_0008_200B._0008())
		{
			return _000F_200B;
		}
		return false;
	}

	internal long _0002()
	{
		return Interlocked.Read(ref _0002_200B);
	}

	internal static bool _000E(bool _000E, string _0003)
	{
		if (_000E)
		{
			return _0006_0018._000E(_0003, _0008_0017._000E(-1141184024));
		}
		return false;
	}

	private void _0002()
	{
		lock (this.m__0006)
		{
			_0008_200B = null;
			_000F_200B = false;
			Interlocked.Increment(ref _0002_200B);
		}
	}

	internal void _000E(string _000E, long _0003)
	{
		lock (this.m__0006)
		{
			if (_0003 == Interlocked.Read(ref this.m__0008) && _0003 != this.m__0005)
			{
				_000F_200B = global::_0008_200B._0008() && (_0008_200B ?? _0006_0018._000E(_000E, _0008_0017._000E(-1141184024)));
			}
		}
	}

	private void _000E(JObject _000E, long _0003)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		JToken val = _000E[_0008_0017._000E(-1141305020)];
		if (val == null || (int)val.Type != 9)
		{
			return;
		}
		bool flag;
		lock (this.m__0006)
		{
			if (_0003 != Interlocked.Read(ref this.m__0008) || _0003 == this.m__0005)
			{
				return;
			}
			_0008_200B = (bool)val;
			flag = (_000F_200B = global::_0008_200B._0008() && (bool)val);
		}
		JToken val2 = _000E[_0008_0017._000E(-1141259028)];
		string text = ((val2 != null && (int)val2.Type == 8) ? ((string)val2) : string.Empty);
		if (text.Length > 512)
		{
			text = text.Substring(0, 512);
		}
		_000F(_0008_0017._000E(-1141184033) + (flag ? _0008_0017._000E(-1141305020) : _0008_0017._000E(-1141175351)) + (string.IsNullOrEmpty(text) ? string.Empty : (_0008_0017._000E(-1141184055) + text)));
	}

	public bool _0003_2008()
	{
		return global::_0008_200B._0006();
	}

	internal void _0003(bool _000E)
	{
		lock (this.m__0006)
		{
			_000F_200B = false;
		}
		_0006(_000E ? _0008_0017._000E(-1141184102) : _0008_0017._000E(-1141184064));
	}

	internal void _000E(int _000E, bool _0003)
	{
		if (_0003)
		{
			_0006(_000F_2004_200A._000E(_000E));
		}
		else
		{
			this._000E(_0008_0017._000E(-1141228263), _000E);
		}
	}

	internal void _000E(int _000E, float _0003, float _0006, float _000F, bool _0002)
	{
		if (_0002)
		{
			this._0006(_000F_2004_200A._000E(_000E, _0003, _0006, _000F));
		}
		else
		{
			this._000E(_0008_0017._000E(-1141228263), _000E, _0003, _0006, _000F);
		}
	}

	internal void _0003(int _000E, bool _0003)
	{
		if (_0003)
		{
			_0006(_000F_2004_200A._0003(_000E));
		}
		else
		{
			this._0003(_0008_0017._000E(-1141228263), _000E);
		}
	}

	internal void _0006(bool _000E)
	{
		if (_000E)
		{
			_0006(_000F_2004_200A._000E());
		}
		else
		{
			this._0003(_0008_0017._000E(-1141228263));
		}
	}

	public void _000E(string _000E, int _0003)
	{
		_0006(_000F_2004_200A._000E(_000E, _0003, 1f, 0f, 0f, 0.15f));
	}

	public void _000E(string _000E, int _0003, float _0006, float _000F, float _0002)
	{
		this._0006(_000F_2004_200A._000E(_000E, _0003, 1f, 0f, 0f, 0.15f, _0006, _000F, _0002));
	}

	public void _000E(string _000E, float _0003, float _0006, float _000F, float _0002, float _0008, float _0005, float _000E_2008, float _0003_2008)
	{
		this._0006(_000F_2004_200A._000E(_000E, _0003, _0006, _000F, _0002, _0008, _0005, _000E_2008, _0003_2008));
	}

	public void _000E(string _000E, float _0003, float _0006, float _000F, float _0002, float _0008)
	{
		this._0006(_000F_2004_200A._000E(_000E, _0003, _0006, _000F, _0002, _0008));
	}

	public void _000E(string _000E, float _0003, float _0006, float _000F, float _0002, float _0008, float _0005, float _000E_2008, float _0003_2008, float _0006_2008, float _000F_2008, float _0002_2008)
	{
		this._0006(_000F_2004_200A._000E(_000E, _0003, _0006, _000F, _0002, _0008, _0005, _000E_2008, _0003_2008, _0006_2008, _000F_2008, _0002_2008));
	}

	public void _0003(string _000E, int _0003)
	{
		_0006(_000F_2004_200A._000E(_000E, _0003));
	}

	public void _0003(string _000E)
	{
		_0006(_000F_2004_200A._000E(_000E));
	}

	public bool _0006_2008()
	{
		if (global::_0008_200B._0002())
		{
			return _0006_200B;
		}
		return false;
	}

	public void _0008()
	{
		_0006(global::_0006_200A._000E(1000, 5));
	}

	public void _0005()
	{
		_0006(global::_0006_200A._000E());
	}

	public bool _000E(float _000E, out uint _0003)
	{
		_0003 = 0u;
		if (_000E <= 0f || float.IsNaN(_000E) || float.IsInfinity(_000E))
		{
			return false;
		}
		do
		{
			_0003 = (uint)Interlocked.Increment(ref _0005_200B);
		}
		while (_0003 == 0);
		return this._000E(global::_0006_200A._000E(_000E, _0003));
	}

	public bool _000F_2008()
	{
		return _000E(global::_0006_200A._0003());
	}

	public bool _0002_2008()
	{
		return global::_0008_200B._0005();
	}

	public void _000F(int _000E)
	{
		_0006(_000E_2004_200A._000E(_000E));
	}

	public bool _0008_2008()
	{
		if (global::_0008_200B._000E_2008())
		{
			return _0003_2001;
		}
		return false;
	}

	public bool _0005_2008()
	{
		if (global::_0008_200B._000F_2002())
		{
			return _0005_2001;
		}
		return false;
	}

	public void _0006(uint _000E)
	{
		_0006(global::_000F_2002_200A._000E(_000E));
	}

	public void _000E_2008()
	{
		_0006(global::_000F_2002_200A._000E());
	}

	public void _0003_2008()
	{
		_0006(global::_000F_2002_200A._0003());
	}

	public void _000F(uint _000E)
	{
		lock (_0003_2008_200A)
		{
			_0006_2008_200A = false;
			_000F_2008_200A++;
			_0006(global::_0002_2005._000E(_000E));
		}
	}

	public void _0002(uint _000E)
	{
		lock (_0003_2008_200A)
		{
			_0006_2008_200A = false;
			_000F_2008_200A++;
			_0006(global::_0002_2005._0003(_000E));
		}
	}

	public void _0006_2008()
	{
		_0006(global::_0002_2005._000E());
	}

	public async Task _000E()
	{
		int num;
		float num2;
		float num3;
		float num4;
		lock (_0003_2008_200A)
		{
			if (_0006_2008_200A)
			{
				return;
			}
			_0006_2008_200A = true;
			num = _000F_2008_200A;
			this._0006_2008();
			_0005_2001_200A obj = this._000E()._000E();
			if (obj == null)
			{
				return;
			}
			num2 = obj._0003;
			num3 = obj._0006;
			num4 = obj._000F;
			if (!this._000E(num2 + 2f, num3, num4, _000F: false, _0008_0017._000E(-1141180064)))
			{
				return;
			}
		}
		Func<int, Task> func = _0002_2008_200A;
		await ((func == null) ? Task.Delay(250) : func(250)).ConfigureAwait(continueOnCapturedContext: false);
		lock (_0003_2008_200A)
		{
			if (num != _000F_2008_200A || !this._000E(num2 - 2f, num3, num4, _000F: false, _0008_0017._000E(-1141180064)))
			{
				return;
			}
		}
		await ((func == null) ? Task.Delay(250) : func(250)).ConfigureAwait(continueOnCapturedContext: false);
	}

	public void _000F_2008()
	{
		_0006(global::_0002_2005._0003());
	}

	public bool _000E_2007()
	{
		if (global::_0008_200B._0003_2008())
		{
			return _0006_2001;
		}
		return false;
	}

	public void _000E(IEnumerable<int> _000E)
	{
		_0006(_000F_200B_200A._000E(_000E));
	}

	public void _0003(IEnumerable<int> _000E)
	{
		_0006(_000F_200B_200A._0003(_000E));
	}

	public bool _0003_2007()
	{
		if (global::_0008_200B._0006_2008())
		{
			return _000F_2001;
		}
		return false;
	}

	internal bool _0006_2007()
	{
		return _000F_2001;
	}

	public bool _000F_2007()
	{
		if (global::_0008_200B._0005_2007())
		{
			return _000E_200B;
		}
		return false;
	}

	public bool _0002_2007()
	{
		if (global::_0008_200B._000E_2002())
		{
			return _0003_200B;
		}
		return false;
	}

	public bool _0008_2007()
	{
		if (global::_0008_200B._0006_2007())
		{
			return _0002_2001;
		}
		return false;
	}

	public void _000E(byte _000E, uint _0003)
	{
		this._000E(_000E, _0003, this._0003());
	}

	internal uint _0003()
	{
		uint num;
		do
		{
			num = (uint)Interlocked.Increment(ref _000F_2004);
		}
		while (num == 0);
		return num;
	}

	public bool _000E(byte _000E, uint _0003)
	{
		return this._000E(_000E, _0003, this._0003());
	}

	internal bool _000E(byte _000E, uint _0003, uint _0006)
	{
		if (_0006 == 0)
		{
			return false;
		}
		return this._000E(global::_000E_2006_200A._000E(_000E, _0003, _0006));
	}

	private void _000E(uint _000E, byte _0003, uint _0006, bool _000F, string _0002)
	{
		lock (_000E_2004)
		{
			long num = Interlocked.Increment(ref _0003_2004);
			Volatile.Write(ref _0002_2004, new _0003_2006_200A(num, _000E, _0003, _0006, _000F, _0002));
		}
	}

	internal void _0003(uint _000E, byte _0003, uint _0006, bool _000F, string _0002)
	{
		this._000E(_000E, _0003, _0006, _000F, _0002);
	}

	private void _0002_2008()
	{
		lock (_000E_2004)
		{
			Volatile.Write(ref _0002_2004, null);
			Interlocked.Increment(ref _0006_2004);
		}
	}

	public uint _0006()
	{
		return _000E((_000F_0018)0);
	}

	public uint _000F()
	{
		return _000E((_000F_0018)1);
	}

	public uint _0002()
	{
		return _000E((_000F_0018)2);
	}

	private uint _000E(_000F_0018 _000E)
	{
		uint num;
		do
		{
			num = (uint)Interlocked.Increment(ref _000E_2009);
		}
		while (num == 0);
		string text = global::_0008_2006_200A._000E(_000E);
		if (!this._0002_2007())
		{
			this._000E(num, text, _0008_0017._000E(-1141214307));
			return num;
		}
		if (!this._000E(global::_0008_2006_200A._000E(_000E, num)))
		{
			this._000E(num, text, _0008_0017._000E(-1141184131));
		}
		return num;
	}

	private void _000E(uint _000E, string _0003, string _0006)
	{
		this._000E(_000E, _0003, _0006: false, null, _0002: false, _0006);
		_000F(_0008_0017._000E(-1141184165) + _000E.ToString(CultureInfo.InvariantCulture) + _0008_0017._000E(-1141184213) + _0003 + _0008_0017._000E(-1141184229) + _0006 + _0008_0017._000E(-1141184274));
	}

	private void _000E(uint _000E, string _0003, bool _0006, bool? _000F, bool _0002, string _0008)
	{
		lock (_0008_2004)
		{
			long num = Interlocked.Increment(ref _0005_2004);
			Volatile.Write(ref _0003_2009, new _0005_2006_200A(num, _000E, _0003, _0006, _000F, _0002, _0008));
		}
	}

	internal static _0005_2006_200A _000E(JObject _000E, long _0003)
	{
		if (_000E == null)
		{
			return new _0005_2006_200A(_0003, 0u, string.Empty, _000F: false, null, _0008: false, string.Empty);
		}
		return new _0005_2006_200A(_0003, _0006_0018._000E(_000E, _0008_0017._000E(-1141255964)), (string)_000E[_0008_0017._000E(-1141184283)], (bool?)_000E[_0008_0017._000E(-1141303993)] == true, _0006_0018._000E(_000E[_0008_0017._000E(-1141184302)]), (bool?)_000E[_0008_0017._000E(-1141160561)] == true, (string)_000E[_0008_0017._000E(-1141253360)]);
	}

	private void _000E(JObject _000E)
	{
		lock (_0008_2004)
		{
			long num = Interlocked.Increment(ref _0005_2004);
			Volatile.Write(ref _0003_2009, _0006_0018._000E(_000E, num));
		}
	}

	internal void _0003(uint _000E, string _0003, bool _0006, bool? _000F, bool _0002, string _0008)
	{
		this._000E(_000E, _0003, _0006, _000F, _0002, _0008);
	}

	private void _0008_2008()
	{
		lock (_0008_2004)
		{
			Volatile.Write(ref _0003_2009, null);
		}
	}

	public uint _000E(int _000E, ushort _0003, ushort _0006, int _000F, ushort _0002, ushort _0008)
	{
		_0003 obj = new _0003();
		obj._000E = _000E;
		obj._0003 = _0003;
		obj._0006 = _0006;
		obj._000F = _000F;
		obj._0002 = _0002;
		obj._0008 = _0008;
		return this._000E(_0008_0017._000E(-1141222027), obj._000E);
	}

	public uint _000E(int _000E, ushort _0003, ushort _0006)
	{
		_0006 obj = new _0006();
		obj._000E = _000E;
		obj._0003 = _0003;
		obj._0006 = _0006;
		return this._000E(_0008_0017._000E(-1141215602), obj._000E);
	}

	public uint _0008()
	{
		return _000E(_0008_0017._000E(-1141217256), global::_0002_2002_200A._000E);
	}

	private uint _000E(string _000E, Func<uint, string> _0003)
	{
		uint num;
		string text;
		lock (_0006_2009)
		{
			if (_0008_2009 != 0)
			{
				return 0u;
			}
			do
			{
				num = (uint)Interlocked.Increment(ref _0002_2009);
			}
			while (num == 0);
			text = _0003(num);
			_0008_2009 = num;
			_0005_2009 = _000E;
			Volatile.Write(ref _000E_2005, null);
		}
		string text2 = _0008_0017._000E(-1141184131);
		bool flag;
		try
		{
			flag = this._000E(text);
		}
		catch (Exception ex)
		{
			flag = false;
			text2 = ex.Message;
		}
		if (flag)
		{
			return num;
		}
		lock (_0006_2009)
		{
			if (_0008_2009 == num)
			{
				this._000E(num, _000E, _0006: false, _000F: false, null, null, null, null, null, text2);
			}
		}
		return 0u;
	}

	private void _000E(JObject _000E, bool _0003)
	{
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Invalid comparison between Unknown and I4
		uint num = _0006_0018._000E(_000E, _0008_0017._000E(-1141255964));
		string text = (string)_000E[_0008_0017._000E(-1141184318)];
		lock (_0006_2009)
		{
			if (num == 0 || num != _0008_2009 || text != _0005_2009 || (!_0003 && _0006_0018._000E(_000E[_0008_0017._000E(-1141303993)]) == true))
			{
				return;
			}
			int num2;
			byte? b = (_0006_0018._000E(_000E[_0008_0017._000E(-1141180506)], 0, 255, out num2) ? new byte?((byte)num2) : ((byte?)null));
			ushort? num3 = (_0006_0018._000E(_000E[_0008_0017._000E(-1141184323)], 0, 65535, out num2) ? new ushort?((ushort)num2) : ((ushort?)null));
			ushort? num4 = (_0006_0018._000E(_000E[_0008_0017._000E(-1141184349)], 0, 65535, out num2) ? new ushort?((ushort)num2) : ((ushort?)null));
			ushort? num5 = (_0006_0018._000E(_000E[_0008_0017._000E(-1141184368)], 0, 65535, out num2) ? new ushort?((ushort)num2) : ((ushort?)null));
			uint? num6 = null;
			JToken val = _000E[_0008_0017._000E(-1141184383)];
			if (val != null && (int)val.Type == 6)
			{
				try
				{
					num6 = (uint)val;
				}
				catch (Exception)
				{
				}
			}
			int num8;
			if (_0003)
			{
				int? num7 = b;
				num8 = (((num7.GetValueOrDefault() == 0) & num7.HasValue) ? 1 : 0);
			}
			else
			{
				num8 = 0;
			}
			this._000E(num, text, (byte)num8 != 0, _0003 && b.HasValue, b, num3, num4, num6, num5, (string)_000E[_0008_0017._000E(-1141253360)]);
		}
	}

	private void _000E(uint _000E, string _0003, bool _0006, bool _000F, byte? _0002, ushort? _0008, ushort? _0005, uint? _000E_2008, ushort? _0003_2008, string _0006_2008)
	{
		_0008_2009 = 0u;
		_0005_2009 = null;
		long num = Interlocked.Increment(ref _000F_2009);
		Volatile.Write(ref _000E_2005, new _0008_2002_200A(num, _000E, _0003, _0006, _000F, _0002, _0008, _0005, _000E_2008, _0003_2008, _0006_2008, _000E_2008_200A._0002_2008()));
	}

	private void _0005_2008()
	{
		lock (_0006_2009)
		{
			_0008_2009 = 0u;
			_0005_2009 = null;
			Volatile.Write(ref _000E_2005, null);
		}
	}

	public void _000E_2007()
	{
		_0006(global::_000E_2006_200A._000E());
	}

	public void _0003_2007()
	{
		_0006(_000F_200B_200A._000E());
	}

	public void _0006_2007()
	{
		_0006(_000F_200B_200A._0003());
	}

	public void _0002(int _000E)
	{
		_0006(_000F_200B_200A._000E(_000E));
	}

	public void _000F_2007()
	{
		_0006(global::_0008_2005._000E());
	}

	public void _000E(ushort _000E, IReadOnlyList<_000E_200B_200A._000E> _0003)
	{
		int num = _0003?.Count ?? 0;
		_000E_200B_200A._000E[] array = new _000E_200B_200A._000E[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = _0003[i];
		}
		_0005_2006_200A = array;
		_000E_2008_200A = _000E_2008_200A._000E();
		_0006(_000E_200B_200A._000E(_000E, array));
	}

	public void _000E(ushort _000E, int _0003, int _0006, ushort _000F, ushort _0002)
	{
		this._000E(_000E, new _000E_200B_200A._000E[1]
		{
			new _000E_200B_200A._000E
			{
				_000E = _0003,
				_0003 = _0006,
				_0006 = _000F,
				_000F = _0002
			}
		});
	}

	public void _000E(int _000E, int _0003, int _0006)
	{
		_000E_2008_200A = _000E_2008_200A._0003();
		this._0006(global::_000E_2003_200A._000E(_000E, _0003, _0006));
	}

	public void _000E(string _000E, int _0003, int _0006, int _000F)
	{
		_000E_2008_200A = _000E_2008_200A._0006();
		this._0006(global::_0002_2008_200A._000E(_000E, _0003, _0006, _000F));
	}

	public void _0002_2007()
	{
		_0006(global::_0008_2008_200A._000E());
	}

	public void _000E(int _000E, ushort _0003, ushort _0006)
	{
		this._0006(_000F_200B_200A._000E(_000E, _0003, _0006));
	}

	public void _000E(IList<(ushort, ushort)> _000E)
	{
		_0006(_000F_200B_200A._000E(_000E));
	}

	public void _000E(string _000E, IEnumerable<(float, float, float)> _0003)
	{
		_0006(_000F_2004_200A._000E(_000E, _0003));
	}

	public void _000E(float _000E, float _0003, float _0006, bool _000F, string _0002)
	{
		this._000E(_000E, _0003, _0006, _000F, _0002);
	}

	public bool _000E(float _000E, float _0003, float _0006, bool _000F, string _0002)
	{
		if (!this._000E(global::_0008_2007_200A._000E(_000E, _0003, _0006, _000F)))
		{
			return false;
		}
		if (global::_0006_2008_200A._000E && _000F_2003_200A._000E((_0002 ?? _0008_0017._000E(-1141182451)) + _0008_0017._000E(-1141297577) + global::_0006_2008_200A._000E(_000E, _0003, _0006), _0003: false, DateTime.UtcNow))
		{
			this._000F(global::_0006_2008_200A._000E(_0002, _000E, _0003, _0006));
		}
		return true;
	}

	public void _0006(string _000E)
	{
		this._000E(_000E);
	}

	private bool _000E(string _000E)
	{
		long num = Interlocked.Read(ref this.m__0008);
		lock (this.m__0003)
		{
			if (num != Interlocked.Read(ref this.m__0008))
			{
				return false;
			}
			return _0003(_000E);
		}
	}

	private bool _0003(string _000E)
	{
		Action<string> action = Volatile.Read(ref _0008_2008_200A);
		if (action != null)
		{
			action(_000E);
			return true;
		}
		IntPtr intPtr = this.m__000E;
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		this.m__0002._0005_2004_2009_200B_2005_2005_000E(intPtr, _000E, (byte[])null, 0);
		return true;
	}

	private string _000E(string _000E, string _0003, string _0006, int _000F)
	{
		return this._000E(_000E, _0003, _0006, _000F)._000E;
	}

	private _0003_2009_200B._0003 _000E(string _000E, string _0003, string _0006, int _000F)
	{
		Func<string, int, _0003_2009_200B._0003> func = _0005_2008_200A;
		if (func == null)
		{
			return _0003_2009_200B._000E(_000E, _0003, _0006, _000F);
		}
		return func(_0006, _000F);
	}

	private void _0008(int _000E)
	{
		Action<int> action = _000E_2007_200A;
		if (action != null)
		{
			action(_000E);
		}
		else
		{
			Thread.Sleep(_000E);
		}
	}

	private global::_0003_0018 _000E(string _000E, string _0003)
	{
		return _0003_2007_200A?.Invoke() ?? global::_000F_2003_200A._000E(_000E, _0003);
	}

	private _000E_2001_200A _000E(string _000E, string _0003)
	{
		List<string> list = new List<string>();
		int num;
		string text;
		bool flag = _0006_0018._000E(this._000E(_000E, _0003, _0006_0018._000E(), 8000), out num, out text);
		if (!flag)
		{
			list.Add(_0008_0017._000E(-1141184398) + text);
		}
		List<_0006_2001_200A> list2 = new List<_0006_2001_200A>();
		_0003_2009_200B._0003 obj = this._000E(_000E, _0003, _0008_0017._000E(-1141333534), 8000);
		bool flag2 = _0006_0018._000E(obj);
		string[] array = (flag2 ? obj._0003 : string.Empty).Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			if (int.TryParse(array[i], out var result) && result > 0)
			{
				_0003_2009_200B._0003 obj2 = this._000E(_000E, _0003, _0008_0017._000E(-1141333637) + result + _0008_0017._000E(-1141253114), 8000);
				_0003_2009_200B._0003 obj3 = this._000E(_000E, _0003, _0008_0017._000E(-1141333637) + result + _0008_0017._000E(-1141252105), 8000);
				_0003_2009_200B._0003 obj4 = this._000E(_000E, _0003, _0008_0017._000E(-1141184414) + result + _0008_0017._000E(-1141252125), 8000);
				string text2 = _0006_0018._000E(new _0003_2009_200B._0003[3] { obj2, obj3, obj4 });
				list2.Add(new _0006_2001_200A(result, obj2._0003, obj3._0003, obj4._0003, _0006_0018._000E(obj2), _0006_0018._000E(obj3), _0006_0018._000E(obj4), text2));
				if (!string.IsNullOrEmpty(text2))
				{
					list.Add(_0008_0017._000E(-1141184436) + result + _0008_0017._000E(-1141301932) + text2);
				}
			}
		}
		_0003_2009_200B._0003 obj5 = this._000E(_000E, _0003, _0008_0017._000E(-1141252944), 8000);
		_0003_2009_200B._0003 obj6 = this._000E(_000E, _0003, _0008_0017._000E(-1141252971), 8000);
		if (!flag2)
		{
			list.Add(_0008_0017._000E(-1141184455) + _0006_0018._000E(obj));
		}
		if (!_0006_0018._000E(obj5))
		{
			list.Add(_0008_0017._000E(-1141184468) + _0006_0018._000E(obj5));
		}
		if (!_0006_0018._000E(obj6))
		{
			list.Add(_0008_0017._000E(-1141184488) + _0006_0018._000E(obj6));
		}
		return new _000E_2001_200A
		{
			_000E = num,
			_0003 = flag,
			_0006 = flag2,
			_000F = obj5._0003,
			_0002 = _0006_0018._000E(obj5),
			_0008 = obj6._0003,
			_0005 = _0006_0018._000E(obj6),
			_000E_2008 = string.Join(_0008_0017._000E(-1141184055), list),
			_0003_2008 = list2
		};
	}

	internal static string _000E()
	{
		return _0008_0017._000E(-1141329904);
	}

	internal static bool _000E(_0003_2009_200B._0003 _000E, out int _0003, out string _0006)
	{
		_0003 = 0;
		_0006 = null;
		if (_000E == null || !_000E._000E() || !string.IsNullOrWhiteSpace(_000E._0006))
		{
			_0006 = _0006_0018._000E(_000E);
			return false;
		}
		string text = _000E._0003.Trim();
		if (text == _0008_0017._000E(-1141252679))
		{
			return true;
		}
		if (text.StartsWith(_0008_0017._000E(-1141252401), StringComparison.Ordinal) && int.TryParse(text.Substring(20), NumberStyles.None, CultureInfo.InvariantCulture, out _0003) && _0003 > 0)
		{
			return true;
		}
		_0003 = 0;
		_0006 = _0008_0017._000E(-1141184501) + text;
		return false;
	}

	private _0005_2003_200A _000E(string _000E, string _0003, int _0006)
	{
		_000E_2001_200A obj;
		return this._000E(_000E, _0003, _0006, out obj);
	}

	internal _0005_2003_200A _000E(string _000E, string _0003, out bool _0006)
	{
		_000E_2001_200A obj;
		_0005_2003_200A result = this._000E(_000E, _0003, 3, out obj);
		_0006 = obj != null && global::_0008_2003_200A._000E(obj).Count > 0;
		return result;
	}

	private _0005_2003_200A _000E(string _000E, string _0003, int _0006, out _000E_2001_200A _000F)
	{
		_0005_2003_200A obj = null;
		_000F = null;
		for (int i = 0; i < _0006; i++)
		{
			_000F = this._000E(_000E, _0003);
			obj = global::_0008_2003_200A._000E(_000F, 27060);
			if (obj._000E != _0002_0018.Unknown)
			{
				return obj;
			}
			if (i + 1 < _0006)
			{
				_0008(100);
			}
		}
		return obj ?? new _0005_2003_200A(_0002_0018.Unknown, 0, 0, _0008_0017._000E(-1141183517));
	}

	private static string _000E(_0003_2009_200B._0003 _000E)
	{
		if (_000E == null)
		{
			return _0008_0017._000E(-1141183547);
		}
		if (_000E._0002)
		{
			return _0008_0017._000E(-1141183569);
		}
		if (!_000E._000F)
		{
			return _0008_0017._000E(-1141183585) + _000E._000E;
		}
		if (!string.IsNullOrWhiteSpace(_000E._0006))
		{
			return _0008_0017._000E(-1141351528) + _000E._0008 + _0008_0017._000E(-1141301932) + _000E._0006;
		}
		return _0008_0017._000E(-1141351528) + _000E._0008 + (string.IsNullOrWhiteSpace(_000E._000E) ? string.Empty : (_0008_0017._000E(-1141301932) + _000E._000E));
	}

	private static bool _000E(_0003_2009_200B._0003 _000E)
	{
		if (_000E != null && _000E._000E())
		{
			return string.IsNullOrWhiteSpace(_000E._0006);
		}
		return false;
	}

	private static string _000E(_0003_2009_200B._0003[] _000E)
	{
		List<string> list = new List<string>();
		foreach (_0003_2009_200B._0003 obj in _000E)
		{
			if (!_0006_0018._000E(obj))
			{
				list.Add(_0006_0018._000E(obj));
			}
		}
		return string.Join(_0008_0017._000E(-1141184055), list);
	}

	private string _000E(string _000E, string _0003, int _0006, int _000F)
	{
		string text = this._000E(_000E, _0003, _0008_0017._000E(-1141183621) + _0006 + _0008_0017._000E(-1141183640) + _000F, 8000);
		if (!_0006_0018._000E(this._000E(_000E, _0003, _0008_0017._000E(-1141183644), 8000), _0003, _0006, _000F))
		{
			return _0008_0017._000E(-1141183665) + _0006 + _0008_0017._000E(-1141183696) + _000F + _0008_0017._000E(-1141183711) + text;
		}
		this._000F(_0008_0017._000E(-1141183730) + _0006 + _0008_0017._000E(-1141183696) + _000F);
		return null;
	}

	internal static bool _000E(string _000E, string _0003, int _0006, int _000F)
	{
		if (string.IsNullOrEmpty(_000E))
		{
			return false;
		}
		string b = (_0003 ?? string.Empty) + _0008_0017._000E(-1141183640) + _0006 + _0008_0017._000E(-1141183640) + _000F;
		string[] array = _000E.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			if (string.Equals(array[i].Trim(), b, StringComparison.Ordinal))
			{
				return true;
			}
		}
		return false;
	}

	private bool _0003(string _000E, string _0003)
	{
		this._000E(_000E, _0003, _0008_0017._000E(-1141253015), 8000);
		return this._000E(_000E, _0003, _0008_0017._000E(-1141183763), 8000).Trim() == _0008_0017._000E(-1141253058);
	}

	private bool _0002(string _000E, string _0003, int _0006)
	{
		this._000E(_000E, _0003, _0008_0017._000E(-1141183861) + _0006 + _0008_0017._000E(-1141183883), 8000);
		if (int.TryParse(this._000E(_000E, _0003, _0008_0017._000E(-1141252428), 8000).Trim(), out var result))
		{
			return result == _0006;
		}
		return false;
	}

	internal string _000E(string _000E, string _0003, out int _0006)
	{
		_0006 = 27060;
		_0005_2003_200A obj = this._000E(_000E, _0003, 3, out var obj2);
		if (obj._000E == _0002_0018.Unknown)
		{
			return _0008_0017._000E(-1141183921) + obj._000F;
		}
		string text = this._000E(_000E, _0003, _0008_0017._000E(-1141252316), 8000).Trim();
		if (obj._000E == _0002_0018.Healthy)
		{
			if (!_0006_0018._000E(text))
			{
				return _0008_0017._000E(-1141183980);
			}
			if (!global::_0008_2003_200A._000E(obj2, _0006, out var num))
			{
				if (!_0002(_000E, _0003, obj._0006))
				{
					return _0008_0017._000E(-1141189224);
				}
				obj = this._000E(_000E, _0003, 3, out obj2);
				if (obj._000E != _0002_0018.Healthy || !global::_0008_2003_200A._000E(obj2, _0006, out num))
				{
					return _0008_0017._000E(-1141189291);
				}
				_000F(_0008_0017._000E(-1141189362) + num);
			}
			_000E_2000 = text;
			_000F(_0008_0017._000E(-1141189418) + num + _0008_0017._000E(-1141189458) + _0006);
			if (this._000E(_000E, _0003) == global::_0003_0018.Stale)
			{
				_000F(_0008_0017._000E(-1141189491));
			}
			return null;
		}
		if (global::_0008_2003_200A._000E(obj2).Count > 0)
		{
			_000F(_0008_0017._000E(-1141189583));
			string text2 = _0008(_000E, _0003);
			if (text2 != null)
			{
				return text2;
			}
			_0008(250);
		}
		else if (!this._0003(_000E, _0003))
		{
			return _0008_0017._000E(-1141188641);
		}
		global::_0003_0018 obj3 = this._000E(_000E, _0003);
		switch (obj3)
		{
		case global::_0003_0018.Unknown:
		case global::_0003_0018.RunnerMissing:
			return _0008_0017._000E(-1141188701) + obj3;
		case global::_0003_0018.Stale:
		{
			_000F(_0008_0017._000E(-1141188751));
			if (!global::_000F_2003_200A._000E(_000E, _0003, null, out var result))
			{
				return result;
			}
			break;
		}
		}
		_000E_2000 = Guid.NewGuid().ToString(_0008_0017._000E(-1141300407));
		this._000E(_000E, _0003, _0008_0017._000E(-1141188781) + _000E_2000 + _0008_0017._000E(-1141188804), 8000);
		if (!this._0003(_000E, _0003))
		{
			return _0008_0017._000E(-1141188876);
		}
		this._000E(_000E, _0003, _0008_0017._000E(-1141188944) + _0006 + _0008_0017._000E(-1141188993), 15000);
		for (int i = 0; i < 60; i++)
		{
			obj = this._000E(_000E, _0003, 1, out obj2);
			if (obj._000E == _0002_0018.Healthy && obj._0003 > 0)
			{
				_000F(_0008_0017._000E(-1141190154) + obj._0003 + _0008_0017._000E(-1141189458) + _0006);
				return null;
			}
			_0008(1000);
		}
		if (obj != null && obj._000E == _0002_0018.Unknown)
		{
			return _0008_0017._000E(-1141190186) + obj._000F;
		}
		return _0008_0017._000E(-1141190233) + this._000E(_000E, _0003, _0008_0017._000E(-1141190265), 8000);
	}

	private static bool _000E(string _000E)
	{
		if (_000E == null || _000E.Length != 32)
		{
			return false;
		}
		foreach (char c in _000E)
		{
			if ((c < '0' || c > '9') && (c < 'a' || c > 'f') && (c < 'A' || c > 'F'))
			{
				return false;
			}
		}
		return true;
	}

	public void _000E(string _000E, string _0003)
	{
		string text = _0008(_000E, _0003);
		_000F((text == null) ? _0008_0017._000E(-1141190345) : (_0008_0017._000E(-1141190326) + text));
	}

	internal string _0008(string _000E, string _0003)
	{
		_000E_2001_200A obj2;
		_0005_2003_200A obj = this._000E(_000E, _0003, 3, out obj2);
		if (obj._000E == _0002_0018.Unknown)
		{
			return _0008_0017._000E(-1141190379) + obj._000F;
		}
		IReadOnlyList<_0003_2001_200A> readOnlyList = global::_0008_2003_200A._000E(obj2);
		foreach (_0003_2001_200A item in readOnlyList)
		{
			if (this._000E(_000E, _0003, item, _000F: false) == (_0003_0018)2)
			{
				return _0008_0017._000E(-1141190448);
			}
		}
		bool flag = false;
		for (int i = 0; i < 20; i++)
		{
			if (!this._000E(_000E, _0003, readOnlyList, out flag))
			{
				break;
			}
			_0008(100);
		}
		if (flag)
		{
			return _0008_0017._000E(-1141190535);
		}
		if (this._000E(_000E, _0003, readOnlyList, out flag))
		{
			foreach (_0003_2001_200A item2 in readOnlyList)
			{
				if (this._000E(_000E, _0003, item2, _000F: true) == (_0003_0018)2)
				{
					return _0008_0017._000E(-1141190585);
				}
			}
			for (int j = 0; j < 10; j++)
			{
				if (!this._000E(_000E, _0003, readOnlyList, out flag))
				{
					break;
				}
				_0008(100);
			}
			if (flag)
			{
				return _0008_0017._000E(-1141189654);
			}
		}
		if (this._000E(_000E, _0003, readOnlyList, out flag))
		{
			return _0008_0017._000E(-1141189712);
		}
		if (flag)
		{
			return _0008_0017._000E(-1141189757);
		}
		if (!this._0003(_000E, _0003))
		{
			return _0008_0017._000E(-1141189795);
		}
		return null;
	}

	private _0003_0018 _000E(string _000E, string _0003, _0003_2001_200A _0006, bool _000F)
	{
		_0003_2009_200B._0003 obj = this._000E(_000E, _0003, _0006_0018._000E(_0006, _000F, _0006: false), 8000);
		if (!obj._000E() || !string.IsNullOrWhiteSpace(obj._0006))
		{
			return (_0003_0018)2;
		}
		string text = obj._0003.Trim();
		if (text.EndsWith(_0008_0017._000E(-1141254214), StringComparison.Ordinal))
		{
			return (_0003_0018)0;
		}
		if (text.EndsWith(_0008_0017._000E(-1141189857), StringComparison.Ordinal) || text.EndsWith(_0008_0017._000E(-1141254244), StringComparison.Ordinal))
		{
			return (_0003_0018)1;
		}
		return (_0003_0018)2;
	}

	internal static string _000E(_0003_2001_200A _000E, bool _0003, bool _0006)
	{
		if (_000E == null)
		{
			throw new ArgumentNullException(_0008_0017._000E(-1141189887));
		}
		string text = (_0006 ? _0008_0017._000E(-1141190000) : ((_0003 ? _0008_0017._000E(-1141189909) : _0008_0017._000E(-1141189890)) + _0008_0017._000E(-1141189915)));
		string text2 = _0008_0017._000E(-1141190020) + _000E._000E + _0008_0017._000E(-1141190039) + _000E._0003.ToString(CultureInfo.InvariantCulture) + _0008_0017._000E(-1141190049) + text;
		return _0008_0017._000E(-1141187330) + text2 + _0008_0017._000E(-1141298972);
	}

	private bool _000E(string _000E, string _0003, IReadOnlyList<_0003_2001_200A> _0006, out bool _000F)
	{
		_000F = false;
		foreach (_0003_2001_200A item in _0006)
		{
			_000E_0018 num = this._000E(_000E, _0003, item);
			if (num == (_000E_0018)2)
			{
				_000F = true;
			}
			if (num == (_000E_0018)0)
			{
				return true;
			}
		}
		return false;
	}

	private _000E_0018 _000E(string _000E, string _0003, _0003_2001_200A _0006)
	{
		_0003_2009_200B._0003 obj = this._000E(_000E, _0003, _0008_0017._000E(-1141333637) + _0006._000E + _0008_0017._000E(-1141253114), 8000);
		_0003_2009_200B._0003 obj2 = this._000E(_000E, _0003, _0008_0017._000E(-1141333637) + _0006._000E + _0008_0017._000E(-1141252105), 8000);
		if (!_0006_0018._000E(obj) || !_0006_0018._000E(obj2))
		{
			if (_0006_0018._0003(obj) || _0006_0018._0003(obj2))
			{
				return (_000E_0018)1;
			}
			return (_000E_0018)2;
		}
		if (!global::_0008_2003_200A._000E(new _0006_2001_200A(_0006._000E, obj._0003, obj2._0003, string.Empty, _0002: true, _0008: true, _0005: false), _0006))
		{
			return (_000E_0018)1;
		}
		return (_000E_0018)0;
	}

	private static bool _0003(_0003_2009_200B._0003 _000E)
	{
		if (_000E != null && _000E._000E != null)
		{
			if (_000E._000E.IndexOf(_0008_0017._000E(-1141252807), StringComparison.OrdinalIgnoreCase) < 0)
			{
				return _000E._000E.IndexOf(_0008_0017._000E(-1141187355), StringComparison.OrdinalIgnoreCase) >= 0;
			}
			return true;
		}
		return false;
	}

	private string _0005(string _000E, string _0003)
	{
		if (_0003_2009_200B._000E(_000E, _0003, _0008_0017._000E(-1141187384), 15000).Contains(_0008_0017._000E(-1141187394)))
		{
			_000F(_0008_0017._000E(-1141187417));
			return null;
		}
		string text = _0008_0017._000E(-1141187457);
		if (!_0003_2009_200B._000E(_000E, _0003, text, 8000).Contains(_0008_0017._000E(-1141187540)))
		{
			string text2 = _0006_200B_200A._0003();
			if (string.IsNullOrEmpty(text2) || !File.Exists(text2))
			{
				return _0008_0017._000E(-1141187560);
			}
			_000F(_0008_0017._000E(-1141186616));
			_0003_2009_200B._000E(_000E, _0003, _0008_0017._000E(-1141304363) + text2 + _0008_0017._000E(-1141186644), 300000);
			_0003_2009_200B._000E(_000E, _0003, _0008_0017._000E(-1141186694), 8000);
			if (!_0003_2009_200B._000E(_000E, _0003, text, 8000).Contains(_0008_0017._000E(-1141187540)))
			{
				return _0008_0017._000E(-1141186757);
			}
		}
		_0003_2009_200B._000E(_000E, _0003, _0008_0017._000E(-1141186837) + 27042 + _0008_0017._000E(-1141186903), 15000);
		for (int i = 0; i < 15; i++)
		{
			if (_0003_2009_200B._000E(_000E, _0003, _0008_0017._000E(-1141187384), 15000).Contains(_0008_0017._000E(-1141187394)))
			{
				_000F(_0008_0017._000E(-1141186970));
				return null;
			}
			Thread.Sleep(1000);
		}
		return _0008_0017._000E(-1141187002);
	}

	private void _0003(IntPtr _000E, IntPtr _0003, int _0006, IntPtr _000F)
	{
		//IL_1a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7a: Invalid comparison between Unknown and I4
		//IL_0a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a68: Invalid comparison between Unknown and I4
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c61: Invalid comparison between Unknown and I4
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Invalid comparison between Unknown and I4
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Invalid comparison between Unknown and I4
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Invalid comparison between Unknown and I4
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Invalid comparison between Unknown and I4
		if (_000F.ToInt64() != Interlocked.Read(ref this.m__0008))
		{
			return;
		}
		string text = global::_0003_2007_200A._000E(_000E);
		if (text == null)
		{
			return;
		}
		JObject val;
		try
		{
			val = JObject.Parse(text);
		}
		catch
		{
			return;
		}
		JToken obj2 = val[_0008_0017._000E(-1141253396)];
		JObject val2 = (JObject)(object)((obj2 is JObject) ? obj2 : null);
		if (val2 == null)
		{
			if ((string)val[_0008_0017._000E(-1141255953)] == _0008_0017._000E(-1141187045))
			{
				this._000F(_0008_0017._000E(-1141187055) + (string)val[_0008_0017._000E(-1141253396)]);
				return;
			}
			val2 = val;
		}
		string text2 = (string)val2[_0008_0017._000E(-1141308128)];
		if (text2 == null || text2 == null)
		{
			return;
		}
		switch (text2.Length)
		{
		case 5:
			switch (text2[0])
			{
			case 'r':
				if (!(text2 == _0008_0017._000E(-1141305020)))
				{
					break;
				}
				lock (this.m__0006)
				{
					if (_000F.ToInt64() == Interlocked.Read(ref this.m__0008) && this.m__0005 != _000F.ToInt64())
					{
						Volatile.Write(ref this.m__000E_2007, 1);
						this.m__0005_2008.Set();
					}
					break;
				}
			case 's':
				if (text2 == _0008_0017._000E(-1141182214))
				{
					int num10 = _0006_0018._000E(val2, _0008_0017._000E(-1141193308));
					bool valueOrDefault2 = (bool?)val2[_0008_0017._000E(-1141303993)] == true;
					string arg = (string)val2[_0008_0017._000E(-1141253360)];
					string text4 = ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>());
					if (_0006_0018._000E(num10, text4, ref _0003_2006_200A))
					{
						this._000F(text4);
					}
					_0002_2002_200A?.Invoke(num10, valueOrDefault2, arg);
				}
				break;
			case 'm':
				if (text2 == _0008_0017._000E(-1141308136))
				{
					bool valueOrDefault = (bool?)val2[_0008_0017._000E(-1141303993)] == true;
					if (!global::_0006_2008_200A._000E || _0002_2003_200A._000E(global::_0006_2008_200A._0003(val2), !valueOrDefault, DateTime.UtcNow))
					{
						this._000F(global::_0006_2008_200A._000E ? global::_0006_2008_200A._000E(val2) : ((object)val2).ToString());
					}
				}
				break;
			case 'e':
				if (text2 == _0008_0017._000E(-1141253360))
				{
					this._000F(_0008_0017._000E(-1141193330) + text);
				}
				break;
			}
			break;
		case 8:
			switch (text2[0])
			{
			default:
				return;
			case 'l':
			{
				if (!(text2 == _0008_0017._000E(-1141253289)) || !_0006_0018._000E(val2[_0008_0017._000E(-1141255964)], 1, int.MaxValue, out var num4))
				{
					return;
				}
				lock (this.m__0006)
				{
					long num5 = _000F.ToInt64();
					if (num5 != Interlocked.Read(ref this.m__0008) || this.m__0005 == num5 || num4 != this.m__000F_2007)
					{
						return;
					}
					bool flag2 = val2[_0008_0017._000E(-1141303993)] != null && (int)val2[_0008_0017._000E(-1141303993)].Type == 9 && (bool)val2[_0008_0017._000E(-1141303993)];
					string text3;
					if (!flag2)
					{
						text3 = ((val2[_0008_0017._000E(-1141253360)] != null && (int)val2[_0008_0017._000E(-1141253360)].Type == 8) ? ((string)val2[_0008_0017._000E(-1141253360)]) : _0008_0017._000E(-1141188470));
						if (string.IsNullOrWhiteSpace(text3))
						{
							text3 = _0008_0017._000E(-1141188520);
						}
					}
					else
					{
						string a = ((val2[_0008_0017._000E(-1141253321)] != null && (int)val2[_0008_0017._000E(-1141253321)].Type == 8) ? ((string)val2[_0008_0017._000E(-1141253321)]) : null);
						string a2 = ((val2[_0008_0017._000E(-1141299845)] != null && (int)val2[_0008_0017._000E(-1141299845)].Type == 8) ? ((string)val2[_0008_0017._000E(-1141299845)]) : null);
						_0002_2009 obj4 = this.m__000E_2002;
						if (!_0006_0018._000E(val2[_0008_0017._000E(-1141253312)], 1, int.MaxValue, out var num6) || num6 != 1 || !string.Equals(a, _0008_0017._000E(-1141253344), StringComparison.Ordinal) || obj4 == null || !string.Equals(a2, obj4._0002, StringComparison.Ordinal))
						{
							flag2 = false;
							text3 = _0008_0017._000E(-1141188568);
						}
						else
						{
							text3 = string.Empty;
						}
					}
					this.m__0002_2007 = num5;
					this.m__0008_2007 = flag2;
					this.m__0005_2007 = text3;
					this.m__0003_2007.Set();
					return;
				}
			}
			case 'c':
				if (text2 == _0008_0017._000E(-1141187069))
				{
					_000F obj3 = new _000F();
					obj3._0003 = this;
					obj3._000E = _0006_0018._000E(val2);
					if (obj3._000E != null)
					{
						long num3 = _000F.ToInt64();
						this._000E(num3, obj3._000E);
					}
				}
				return;
			case 'p':
				break;
			}
			if (!(text2 == _0008_0017._000E(-1141188100)))
			{
				break;
			}
			goto IL_18fb;
		case 13:
			switch (text2[0])
			{
			case 'l':
			{
				if (!(text2 == _0008_0017._000E(-1141253437)) || !_0006_0018._000E(val2[_0008_0017._000E(-1141255964)], 1, int.MaxValue, out var num26))
				{
					break;
				}
				lock (this.m__0006)
				{
					long num27 = _000F.ToInt64();
					if (!this._000E(num27) || num26 != _0008_2002)
					{
						break;
					}
					if (val2[_0008_0017._000E(-1141303993)] == null || (int)val2[_0008_0017._000E(-1141303993)].Type != 9 || !(bool)val2[_0008_0017._000E(-1141303993)])
					{
						_000E_2006 = num27;
						_0003_2006 = null;
						_000F_2006 = _0006_0018._000E(val2, _0008_0017._000E(-1141187605));
						_000F_2002.Set();
						break;
					}
					if (!_0006_0018._000E(val2[_0008_0017._000E(-1141253449)], 1, 1, out var num28) || !_0006_0018._000E(val2[_0008_0017._000E(-1141252634)], out uint num29) || num29 != this._000E() || !global::_0008_2009._000E(_0006_0018._000E(val2[_0008_0017._000E(-1141253472)]), 16, out var array2) || !global::_0008_2009._000E(_0006_0018._000E(val2[_0008_0017._000E(-1141264978)]), 32, out var array3) || !global::_0008_2009._000E(_0006_0018._000E(val2[_0008_0017._000E(-1141253598)]), 65, out var array4) || array4[0] != 4)
					{
						break;
					}
					try
					{
						_0003_2006 = new _000E_2005(num26, num28, num29, array2, array3, array4);
						_000E_2006 = num27;
						_000F_2006 = string.Empty;
						_000F_2002.Set();
						break;
					}
					catch
					{
						break;
					}
				}
			}
			case 'a':
				if (text2 == _0008_0017._000E(-1141182375))
				{
					this._000F(((object)val2).ToString());
				}
				break;
			case 's':
				if (text2 == _0008_0017._000E(-1141182279))
				{
					string text14 = ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>());
					if (text14 != _0006_2006_200A)
					{
						this._000F(text14);
					}
					_0006_2006_200A = text14;
					if (_0006_0018._000E(val2, _0008_0017._000E(-1141193328)) == 3)
					{
						_0003_2005 = _0006_0018._000E(val2);
					}
				}
				break;
			}
			break;
		case 14:
			switch (text2[0])
			{
			case 'l':
				if (!(text2 == _0008_0017._000E(-1141258978)))
				{
					break;
				}
				lock (this.m__0006)
				{
					long num25 = _000F.ToInt64();
					if (this._000E(num25) && num25 == _0005_2006 && !string.IsNullOrEmpty(_0008_2006) && global::_0006_2005._000E(val2, _0008_2006, out var obj11))
					{
						_000E_2003 = obj11;
					}
					break;
				}
			case 'r':
				if (text2 == _0008_0017._000E(-1141188115))
				{
					this._000F(((object)val2).ToString());
				}
				break;
			}
			break;
		case 7:
			switch (text2[0])
			{
			case 'i':
				if (text2 == _0008_0017._000E(-1141188144))
				{
					_0008_2003 = ((object)val2).ToString();
					_0006_2003.Set();
				}
				break;
			case 'o':
				if (text2 == _0008_0017._000E(-1141188158))
				{
					_0005_2003 = ((object)val2).ToString();
					_000F_2003.Set();
				}
				break;
			case 'f':
			{
				if (!(text2 == _0008_0017._000E(-1141188164)))
				{
					break;
				}
				string text12 = _0006_0018._0006(val2);
				int num23;
				bool flag7 = _0006_0018._000E(val2[_0008_0017._000E(-1141187929)], 1, int.MaxValue, out num23);
				string text13 = _0006_0018._000E(val2, text12, flag7);
				if (text13.Length != 0)
				{
					if (text13 != _0006_2003_200A)
					{
						this._000F(_0008_0017._000E(-1141113520) + text13);
					}
					_0006_2003_200A = text13;
					_000E_2008_200A = _000E_2008_200A._0008(text13);
					_0008_2007();
				}
				else
				{
					_0006_2003_200A = null;
					int num24;
					IReadOnlyList<_000F_2008_200A> readOnlyList6 = _0006_0018._000E(val2, out num24);
					_000E_2008_200A = _000E_2008_200A._000E(readOnlyList6, text12, num23, num24);
					_0008_2007();
				}
				break;
			}
			case 'r':
				if (text2 == _0008_0017._000E(-1141188178))
				{
					this._000E(val2);
					this._000F(_0008_0017._000E(-1141255766) + ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()));
				}
				break;
			}
			break;
		case 15:
			switch (text2[0])
			{
			case 'r':
				if (text2 == _0008_0017._000E(-1141188200))
				{
					this._000E(val2, _000F.ToInt64());
				}
				break;
			case 'c':
				if (text2 == _0008_0017._000E(-1141188222))
				{
					_0002 obj10 = new _0002();
					obj10._0003 = this;
					obj10._000E = _0006_0018._000E(val2);
					if (obj10._000E != null)
					{
						long num22 = _000F.ToInt64();
						this._000E(num22, obj10._000E);
					}
				}
				break;
			}
			break;
		case 9:
			switch (text2[0])
			{
			case 'c':
			{
				if (!(text2 == _0008_0017._000E(-1141264978)))
				{
					break;
				}
				_000E_2000 obj9 = this._000E();
				if (obj9 == null || _000F.ToInt64() == this.m__0005 || !_0006_0018._000E(val2[_0008_0017._000E(-1141187696)], out uint num17) || num17 == 0 || !_0006_0018._000E(val2[_0008_0017._000E(-1141181966)], 0, 255, out var num18) || !_0006_0018._000E(val2[_0008_0017._000E(-1141187706)], 1, 255, out var num19) || !_0006_0018._000E(val2[_0008_0017._000E(-1141187723)], 1, 255, out var num20) || !_0006_0018._000E(val2[_0008_0017._000E(-1141187750)], 8, 8192, out var num21) || _0003 == IntPtr.Zero || _0006 != num21)
				{
					this._000F(_0008_0017._000E(-1141187765));
					break;
				}
				byte[] array = new byte[num21];
				Marshal.Copy(_0003, array, 0, num21);
				if (!obj9._000E(this._000E(_000F), num17, num18, num19, num20, array, _0006_0018._000E(val2, _0008_0017._000E(-1141187795)), global::_0008_200B._000F()))
				{
					this._000F(_0008_0017._000E(-1141187824));
				}
				break;
			}
			case 's':
				if (text2 == _0008_0017._000E(-1141182218))
				{
					this._000F(((object)val2).ToString());
					_0008_2002_200A?.Invoke(_0006_0018._000E(val2));
				}
				break;
			case 'b':
				if (text2 == _0008_0017._000E(-1141308159))
				{
					this._000F(((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()));
					_000E_2006_200A?.Invoke(_0006_0018._000E(val2));
				}
				break;
			}
			break;
		case 4:
			switch (text2[1])
			{
			case 'n':
				if (text2 == _0008_0017._000E(-1141188294))
				{
					_000E_2008_200A = _000E_2008_200A._000E(_0005_2001_200A._000E(_0003, _0006), _0006_0018._000E(val2, _0008_0017._000E(-1141187929)), _0006_0018._000E(val2, _0008_0017._000E(-1141173131)));
					_0008_2007();
					_000E_2002_200A?.Invoke();
					this._000E(_0003_2004_200A._0003(_0008_0017._000E(-1141114503)), _000F);
				}
				break;
			case 'e':
			{
				if (!(text2 == _0008_0017._000E(-1141188297)))
				{
					break;
				}
				string text10 = _0006_0018._0003(val2);
				IReadOnlyList<_0003_200B_200A> readOnlyList5 = _0006_0018._000E(val2, text10, _0005_2006_200A);
				int num15;
				bool flag6 = _0006_0018._000E(val2[_0008_0017._000E(-1141187929)], 1, int.MaxValue, out num15);
				string text11 = _0006_0018._000E(val2, readOnlyList5, text10, flag6);
				if (text11.Length != 0)
				{
					if (text11 != _0008_2006_200A)
					{
						this._000F(_0008_0017._000E(-1141228118) + text11);
					}
					_0008_2006_200A = text11;
					_0005_2006_200A = null;
					_000E_2008_200A = _000E_2008_200A._0006(text11);
					_0008_2007();
				}
				else
				{
					_0008_2006_200A = null;
					_0005_2006_200A = null;
					_000E_2008_200A = _000E_2008_200A._000E(readOnlyList5, text10, num15);
					_0008_2007();
				}
				break;
			}
			case 'o':
				if (text2 == _0008_0017._000E(-1141182185))
				{
					this._000F(((object)val2).ToString());
				}
				break;
			case 'l':
				if (text2 == _0008_0017._000E(-1141125133))
				{
					this._000F(((object)val2).ToString());
				}
				break;
			case 'i':
				if (text2 == _0008_0017._000E(-1141308140))
				{
					bool valueOrDefault7 = (bool?)val2[_0008_0017._000E(-1141303993)] == true;
					this._000E((uint)_0006_0018._000E(val2, _0008_0017._000E(-1141293578)), (byte)_0006_0018._000E(val2, _0008_0017._000E(-1141255953)), _0006_0018._000E(val2, _0008_0017._000E(-1141255964)), valueOrDefault7, (string)val2[_0008_0017._000E(-1141253360)]);
					if (!global::_0006_2008_200A._000E || _0008_2003_200A._000E(global::_0006_2008_200A._000F(val2), !valueOrDefault7, DateTime.UtcNow))
					{
						this._000F(global::_0006_2008_200A._000E ? global::_0006_2008_200A._0006(val2) : ((object)val2).ToString());
					}
				}
				break;
			}
			break;
		case 10:
			switch (text2[0])
			{
			default:
				return;
			case 'c':
				if (text2 == _0008_0017._000E(-1141212922))
				{
					this._0003(val2);
					_000E_2001 = _0006_0018._000E(_0003, _0006);
					_0002_2003.Set();
					string text9 = _0006_0018._000E(val2);
					_0006_2004_200A obj6 = ((text9 == null) ? _000E_2008_200A : _000E_2008_200A._000E(text9));
					IReadOnlyList<_0008_2001_200A> readOnlyList3 = _0006_0018._000E(val2);
					IReadOnlyList<uint> readOnlyList4 = _0006_0018._000E(val2);
					IReadOnlyDictionary<uint, _0003_2003_200A> readOnlyDictionary = _0006_0018._000E(val2, readOnlyList4, _000E_2001);
					_0005_2002_200A obj7 = _0006_0018._000E(val2);
					_000E_2008_200A = obj6._000E(_000E_2001, this._000E(), readOnlyList3, _0006_0018._000E(val2), _0006_0018._000E(val2), _0006_0018._000E(val2, _0008_0017._000E(-1141187929)), _0006_0018._000E(val2, _0008_0017._000E(-1141173131)), _0006_0018._000E(val2, readOnlyList4, _000E_2001, readOnlyList3), readOnlyList4, _0006_0018._0003(val2), readOnlyDictionary, obj7);
					_0008_2007();
					_000E_2002_200A?.Invoke();
					this._000E(_0003_2004_200A._0003(_0008_0017._000E(-1141114512)), _000F);
				}
				return;
			case 'f':
				if (text2 == _0008_0017._000E(-1141182317))
				{
					this._000E((bool?)val2[_0008_0017._000E(-1141193255)] == true);
					this._000F(text);
				}
				return;
			case 'p':
				break;
			}
			if (!(text2 == _0008_0017._000E(-1141188308)))
			{
				break;
			}
			goto IL_18fb;
		case 3:
			switch (text2[0])
			{
			case 'b':
			{
				if (!(text2 == _0008_0017._000E(-1141188333)))
				{
					break;
				}
				IReadOnlyList<_0003_2008_200A> readOnlyList = _0006_0018._000E(val2);
				int num13;
				bool flag5 = _0006_0018._000E(val2[_0008_0017._000E(-1141187929)], 1, int.MaxValue, out num13);
				string text8 = _0006_0018._000E(val2, readOnlyList, flag5);
				if (text8.Length != 0)
				{
					if (text8 != _0002_2006_200A)
					{
						this._000F(_0008_0017._000E(-1141140128) + text8);
					}
					_0002_2006_200A = text8;
					_000E_2008_200A = _000E_2008_200A._0003(text8);
					_0008_2007();
				}
				else
				{
					_0002_2006_200A = null;
					this._0003(val2);
					IReadOnlyList<_0005_2005> readOnlyList2 = _0006_0018._000E(val2);
					int num14 = _0006_0018._0003(val2);
					_000E_2008_200A = _000E_2008_200A._000E(readOnlyList2, readOnlyList, this._000E(), num13, _0006_0018._000E(val2), num14);
					_0008_2007();
				}
				break;
			}
			case 'w':
				if (text2 == _0008_0017._000E(-1141182196))
				{
					this._000F(((object)val2).ToString());
				}
				break;
			case 'c':
				if (text2 == _0008_0017._000E(-1141182334))
				{
					this._000F(((object)val2).ToString());
				}
				break;
			}
			break;
		case 6:
			switch (text2[0])
			{
			case 'r':
			{
				if (!(text2 == _0008_0017._000E(-1141188343)))
				{
					break;
				}
				if (!_0006_0018._000E(val2, _0008_0017._000E(-1141187939), _0008_0017._000E(-1141130794), out var flag4, out var text7, out var num12) || !flag4)
				{
					if (text7 != _000E_2003_200A)
					{
						this._000F(_0008_0017._000E(-1141113314) + text7);
					}
					_000E_2003_200A = text7;
					_000E_2008_200A = _000E_2008_200A._000F(text7);
					_0008_2007();
				}
				else
				{
					_000E_2003_200A = null;
					_000E_2008_200A = _000E_2008_200A._000E(_000E: true, num12);
					_0008_2007();
				}
				break;
			}
			case 'a':
				if (text2 == _0008_0017._000E(-1141182344))
				{
					uint arg3 = (uint)_0006_0018._000E(val2, _0008_0017._000E(-1141293578));
					int arg4 = _0006_0018._000E(val2, _0008_0017._000E(-1141193260));
					bool valueOrDefault6 = (bool?)val2[_0008_0017._000E(-1141303993)] == true;
					string arg5 = (string)val2[_0008_0017._000E(-1141253360)];
					if (!valueOrDefault6)
					{
						this._000F(((object)val2).ToString());
					}
					_0006_2002_200A?.Invoke(arg3, arg4, valueOrDefault6, arg5);
				}
				break;
			}
			break;
		case 11:
			switch (text2[7])
			{
			case 'w':
			{
				if (!(text2 == _0008_0017._000E(-1141188348)))
				{
					break;
				}
				if (!_0006_0018._000E(val2, _0008_0017._000E(-1141187993), _0008_0017._000E(-1141188052), out var flag3, out var text6, out var num11) || !flag3)
				{
					if (text6 != _0003_2003_200A)
					{
						this._000F(_0008_0017._000E(-1141193227) + text6);
					}
					_0003_2003_200A = text6;
					_000E_2008_200A = _000E_2008_200A._0002(text6);
					_0008_2007();
				}
				else
				{
					_0003_2003_200A = null;
					_000E_2008_200A = _000E_2008_200A._0003(_000E: true, num11);
					_0008_2007();
				}
				break;
			}
			case 's':
				if (text2 == _0008_0017._000E(-1141182357))
				{
					this._000F(((object)val2).ToString());
				}
				break;
			case 'a':
				if (text2 == _0008_0017._000E(-1141182387))
				{
					this._000F(((object)val2).ToString());
				}
				break;
			case 'u':
				if (text2 == _0008_0017._000E(-1141188374))
				{
					this._000E(val2, _0003: false);
					if (_0006_0018._000E(val2[_0008_0017._000E(-1141303993)]) != true)
					{
						this._000F(_0008_0017._000E(-1141193304) + ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()));
					}
				}
				break;
			case 'h':
				if (text2 == _0008_0017._000E(-1141182234))
				{
					this._000F(((object)val2).ToString());
					_0005_2002_200A?.Invoke(_0006_0018._000E(val2));
				}
				break;
			case 'e':
				if (text2 == _0008_0017._000E(-1141182291))
				{
					JToken val3 = val2[_0008_0017._000E(-1141303993)];
					string text5 = ((val3 != null && (int)val3.Type == 9 && (bool)val3) ? null : ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()));
					if (text5 != null && text5 != _000F_2006_200A)
					{
						this._000F(text5);
					}
					_000F_2006_200A = text5;
					_0006_2005 = _0006_0018._000E(val2, _0008_200B_200A._000E(), _0006_2005);
				}
				break;
			}
			break;
		case 12:
			switch (text2[1])
			{
			case 'a':
			{
				if (!(text2 == _0008_0017._000E(-1141197428)))
				{
					if (text2 == _0008_0017._000E(-1141197458))
					{
						this._000F(((object)val2).ToString());
					}
					break;
				}
				bool valueOrDefault3 = (bool?)val2[_0008_0017._000E(-1141303993)] == true;
				uint valueOrDefault4 = ((uint?)val2[_0008_0017._000E(-1141293578)]).GetValueOrDefault();
				bool valueOrDefault5 = (bool?)val2[_0008_0017._000E(-1141197455)] == true;
				string arg2 = (string)val2[_0008_0017._000E(-1141253360)];
				this._000F(((object)val2).ToString());
				_000F_2002_200A?.Invoke(valueOrDefault4, valueOrDefault5, valueOrDefault3, arg2);
				break;
			}
			case 'e':
				if (text2 == _0008_0017._000E(-1141188392))
				{
					this._000E(val2, _0003: true);
					this._000F(_0008_0017._000E(-1141193304) + ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()));
				}
				break;
			case 'k':
				if (text2 == _0008_0017._000E(-1141182252))
				{
					this._000F(((object)val2).ToString());
				}
				break;
			}
			break;
		case 17:
		{
			if (!(text2 == _0008_0017._000E(-1141258880)) || !_0006_0018._000E(val2[_0008_0017._000E(-1141255964)], 1, int.MaxValue, out var num))
			{
				break;
			}
			lock (this.m__0006)
			{
				long num2 = _000F.ToInt64();
				if (this._000E(num2) && num == _0005_2002 && _0003_2006 != null && string.Equals(_0006_0018._000E(val2[_0008_0017._000E(-1141253472)]), _0003_2006._000E(), StringComparison.OrdinalIgnoreCase))
				{
					bool flag = val2[_0008_0017._000E(-1141303993)] != null && (int)val2[_0008_0017._000E(-1141303993)].Type == 9 && (bool)val2[_0008_0017._000E(-1141303993)];
					_000E_2006 = num2;
					_0006_2006 = flag;
					_000F_2006 = (flag ? string.Empty : _0006_0018._000E(val2, _0008_0017._000E(-1141187653)));
					if (flag)
					{
						_0008_2006 = _0003_2006._000E();
						_0005_2006 = num2;
						_000E_2003 = global::_0006_2005._000E(_0003_2006._000E());
					}
					_000F_2002.Set();
				}
				break;
			}
		}
		case 20:
			if (text2 == _0008_0017._000E(-1141188236))
			{
				_000E_2000 obj8 = this._000E();
				if (obj8 != null && _000F.ToInt64() != this.m__0005 && _0006_0018._000E(val2[_0008_0017._000E(-1141187696)], out uint num16) && num16 != 0)
				{
					obj8._000E(this._000E(_000F), num16, (string)val2[_0008_0017._000E(-1141187864)], _0006_0018._000E(val2, _0008_0017._000E(-1141187877)));
				}
			}
			break;
		case 16:
			if (text2 == _0008_0017._000E(-1141188271))
			{
				_000E_2000 obj5 = this._000E();
				if (obj5 != null && _000F.ToInt64() != this.m__0005 && _0006_0018._000E(val2[_0008_0017._000E(-1141187696)], out uint num7) && num7 != 0 && _0006_0018._000E(val2[_0008_0017._000E(-1141180506)], 0, 3, out var num8) && _0006_0018._000E(val2[_0008_0017._000E(-1141187723)], 0, 255, out var num9) && !obj5._000E(this._000E(_000F), num7, num8, num9, _0006_0018._000E(val2, _0008_0017._000E(-1141187795))))
				{
					this._000F(_0008_0017._000E(-1141187890));
				}
			}
			break;
		case 22:
			if (text2 == _0008_0017._000E(-1141188403))
			{
				this._000F(_0008_0017._000E(-1141193279) + ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()));
			}
			break;
		case 23:
			if (text2 == _0008_0017._000E(-1141188440))
			{
				this._000F(((object)val2).ToString());
			}
			break;
		case 18:
		case 19:
		case 21:
			break;
			IL_18fb:
			this._000F(_0008_0017._000E(-1141193304) + ((JToken)val2).ToString((Formatting)0, Array.Empty<JsonConverter>()));
			break;
		}
	}

	internal static bool _000E(int _000E, string _0003, ref string _0006)
	{
		if (_000E == 0 && _0003 == _0006)
		{
			return false;
		}
		_0006 = ((_000E == 0) ? _0003 : null);
		return true;
	}

	private void _0008_2007()
	{
		_0003_2002_200A?.Invoke(_000E_2008_200A);
	}

	internal static IReadOnlyList<string> _000E(JObject _000E)
	{
		JToken obj = _000E[_0008_0017._000E(-1141193358)];
		JArray val = (JArray)(object)((obj is JArray) ? obj : null);
		List<string> list = new List<string>();
		if (val == null)
		{
			return list;
		}
		foreach (JToken item in val)
		{
			JObject val2 = (JObject)(object)((item is JObject) ? item : null);
			if (val2 == null)
			{
				continue;
			}
			int num = _0006_0018._000E(val2, _0008_0017._000E(-1141193362));
			if (num >= 1 && num <= 10)
			{
				while (list.Count < num)
				{
					list.Add(string.Empty);
				}
				list[num - 1] = ((string)val2[_0008_0017._000E(-1141293587)]) ?? string.Empty;
			}
		}
		return list;
	}

	internal static IReadOnlyList<_0005_200B_200A> _000E(JObject _000E)
	{
		List<_0005_200B_200A> list = new List<_0005_200B_200A>();
		JToken obj = _000E[_0008_0017._000E(-1141193358)];
		JArray val = (JArray)(object)((obj is JArray) ? obj : null);
		if (val != null)
		{
			foreach (JToken item in val)
			{
				JObject val2 = (JObject)(object)((item is JObject) ? item : null);
				if (val2 != null)
				{
					list.Add(new _0005_200B_200A(_0006_0018._000E(val2, _0008_0017._000E(-1141193362)), _0006_0018._000E(val2, _0008_0017._000E(-1141193260))));
				}
			}
		}
		return list;
	}

	private string _000E(IntPtr _000E)
	{
		return this.m__000E_2008 + _0008_0017._000E(-1141300031) + _000E.ToInt64();
	}

	private static long _000E(JObject _000E, string _0003)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		JToken obj = _000E[_0003];
		JValue val = (JValue)(object)((obj is JValue) ? obj : null);
		if (val != null && (int)((JToken)val).Type == 6 && val.Value is long)
		{
			long num = (long)val.Value;
			if (num > 0)
			{
				return num;
			}
		}
		return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
	}

	private static int _000E(JObject _000E, string _0003)
	{
		JToken val = _000E[_0003];
		if (val == null)
		{
			return 0;
		}
		try
		{
			return (int)val;
		}
		catch
		{
			return 0;
		}
	}

	private static uint _000E(JObject _000E, string _0003)
	{
		JToken val = _000E[_0003];
		if (val == null)
		{
			return 0u;
		}
		try
		{
			return (uint)val;
		}
		catch
		{
			return 0u;
		}
	}

	private static bool? _000E(JToken _000E)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if (_000E == null || (int)_000E.Type != 9)
		{
			return null;
		}
		return (bool?)_000E;
	}

	internal static _000F_200A _000E(JObject _000E)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Invalid comparison between Unknown and I4
		_000F_200A obj = new _000F_200A();
		if (_000E == null)
		{
			return obj;
		}
		JToken val = _000E[_0008_0017._000E(-1141144353)];
		obj._000E(_0006_0018._000E(val));
		int value;
		if (val != null && ((int)val.Type == 9 || (int)val.Type == 10))
		{
			if (_0006_0018._000E(_000E[_0008_0017._000E(-1141212451)], 0, 3, out var num))
			{
				obj._000E(num);
			}
			if (_0006_0018._000E(_000E[_0008_0017._000E(-1141193370)], 0, int.MaxValue, out value))
			{
				obj._000E((int?)value);
			}
		}
		JToken val2 = _000E[_0008_0017._000E(-1141154429)];
		obj._0003(_0006_0018._000E(val2));
		if (val2 != null && ((int)val2.Type == 9 || (int)val2.Type == 10) && _0006_0018._000E(_000E[_0008_0017._000E(-1141212480)], 0, int.MaxValue, out value))
		{
			obj._0003(value);
		}
		return obj;
	}

	internal static _0005_2002_200A _000E(JObject _000E)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Invalid comparison between Unknown and I4
		_0005_2002_200A result = default(_0005_2002_200A);
		JObject val = (JObject)((_000E == null) ? null : /*isinst with value type is only supported in some contexts*/);
		if (val == null)
		{
			return result;
		}
		result._000E = _0006_0018._000E(val[_0008_0017._000E(-1141305020)]) == true;
		if (_0006_0018._000E(val[_0008_0017._000E(-1141193401)], 0, 65535, out var num))
		{
			result._0003 = (ushort)num;
		}
		if (_0006_0018._000E(val[_0008_0017._000E(-1141193424)], 0, 65535, out num))
		{
			result._0006 = (ushort)num;
		}
		JToken val2 = val[_0008_0017._000E(-1141184383)];
		if (val2 != null && (int)val2.Type == 6)
		{
			try
			{
				result._000F = (uint)val2;
			}
			catch (Exception)
			{
			}
		}
		result._0002 = _0006_0018._000E(val[_0008_0017._000E(-1141193433)]);
		return result;
	}

	internal static string _000E(JObject _000E)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		if (_000E == null)
		{
			return null;
		}
		JToken val = _000E[_0008_0017._000E(-1141193461)];
		if (val == null || (int)val.Type != 8)
		{
			return null;
		}
		string text = (string)val;
		if (!string.IsNullOrWhiteSpace(text))
		{
			return text.Trim();
		}
		return null;
	}

	private static float _000E(JObject _000E, string _0003, float _0006)
	{
		JToken val = _000E[_0003];
		if (val == null)
		{
			return _0006;
		}
		try
		{
			return (float)val;
		}
		catch
		{
			return _0006;
		}
	}

	internal static _0005_2008_200A _000E(JObject _000E)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between Unknown and I4
		if (_000E == null)
		{
			return null;
		}
		if (!_0006_0018._000E(_000E[_0008_0017._000E(-1141255964)], out uint num) || !_0006_0018._000E(_000E[_0008_0017._000E(-1141303993)], out bool flag) || !_0006_0018._000E(_000E[_0008_0017._000E(-1141305020)], out bool flag2))
		{
			return null;
		}
		float? num2 = _0006_0018._000E(_000E[_0008_0017._000E(-1141193468)]);
		float? num3 = _0006_0018._000E(_000E[_0008_0017._000E(-1141193487)]);
		if (flag && !num2.HasValue)
		{
			return null;
		}
		if (_000E[_0008_0017._000E(-1141193487)] != null && !num3.HasValue)
		{
			return null;
		}
		JToken val = _000E[_0008_0017._000E(-1141253360)];
		string text = ((val != null && (int)val.Type == 8) ? ((string)val) : string.Empty);
		return new _0005_2008_200A(flag, num, num2, text, num3, flag2);
	}

	internal static _000E_2007_200A _000E(JObject _000E)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Invalid comparison between Unknown and I4
		if (_000E == null)
		{
			return null;
		}
		if (!_0006_0018._000E(_000E[_0008_0017._000E(-1141305020)], out bool flag) || !_0006_0018._000E(_000E[_0008_0017._000E(-1141193489)], out bool flag2))
		{
			return null;
		}
		float? num = _0006_0018._000E(_000E[_0008_0017._000E(-1141193468)]);
		float? num2 = _0006_0018._000E(_000E[_0008_0017._000E(-1141193487)]);
		if (_000E[_0008_0017._000E(-1141193468)] != null && !num.HasValue)
		{
			return null;
		}
		if (_000E[_0008_0017._000E(-1141193487)] != null && !num2.HasValue)
		{
			return null;
		}
		JToken val = _000E[_0008_0017._000E(-1141259028)];
		string text = ((val != null && (int)val.Type == 8) ? ((string)val) : string.Empty);
		return new _000E_2007_200A(flag, flag2, text, num, num2);
	}

	private static bool _000E(JToken _000E, out bool _0003)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		_0003 = false;
		if (_000E == null || (int)_000E.Type != 9)
		{
			return false;
		}
		_0003 = (bool)_000E;
		return true;
	}

	private static float? _000E(JToken _000E)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (_000E == null || ((int)_000E.Type != 7 && (int)_000E.Type != 6))
		{
			return null;
		}
		try
		{
			float num = Convert.ToSingle(((JValue)_000E).Value, CultureInfo.InvariantCulture);
			return (float.IsNaN(num) || float.IsInfinity(num)) ? ((float?)null) : new float?(num);
		}
		catch
		{
			return null;
		}
	}

	private _0005_2007_200A _000E()
	{
		return new _0005_2007_200A(new Dictionary<string, string>(_0006_2000, StringComparer.Ordinal), new Dictionary<string, string>(_000F_2000, StringComparer.Ordinal), new Dictionary<string, string>(_0002_2000, StringComparer.Ordinal));
	}

	internal static IReadOnlyList<_0008_2001_200A> _000E(JObject _000E)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		JToken obj = _000E[_0008_0017._000E(-1141193512)];
		JArray val = (JArray)(object)((obj is JArray) ? obj : null);
		if (val == null)
		{
			return null;
		}
		List<_0008_2001_200A> list = new List<_0008_2001_200A>(((JContainer)val).Count);
		for (int i = 0; i < ((JContainer)val).Count; i++)
		{
			JToken obj2 = val[i];
			JObject val2 = (JObject)(object)((obj2 is JObject) ? obj2 : null);
			if (val2 == null)
			{
				continue;
			}
			JToken val3 = val2[_0008_0017._000E(-1141193516)];
			if (val3 != null && (int)val3.Type == 8)
			{
				string text = (string)val3;
				if (!(text != _0008_0017._000E(-1141253640)) || !(text != _0008_0017._000E(-1141255990)))
				{
					list.Add(new _0008_2001_200A
					{
						_000E = (text == _0008_0017._000E(-1141255990)),
						_0003 = _0006_0018._000E(val2, _0008_0017._000E(-1141125133)),
						_0006 = (ushort)_0006_0018._000E(val2, _0008_0017._000E(-1141193534)),
						_000F = (ushort)_0006_0018._000E(val2, _0008_0017._000E(-1141193537)),
						_0002 = _0006_0018._000E(val2, _0008_0017._000E(-1141193547)),
						_0008 = _0006_0018._000E(val2, _0008_0017._000E(-1141193556), 0f)
					});
				}
			}
		}
		return list;
	}

	internal static IReadOnlyList<uint> _000E(JObject _000E)
	{
		JArray val = (JArray)((_000E == null) ? null : /*isinst with value type is only supported in some contexts*/);
		if (val == null)
		{
			return null;
		}
		List<uint> list = new List<uint>(((JContainer)val).Count);
		foreach (JToken item2 in val)
		{
			if (!_0006_0018._000E(item2, out uint item))
			{
				return null;
			}
			list.Add(item);
		}
		return list;
	}

	internal static IReadOnlyList<uint> _0003(JObject _000E)
	{
		JArray val = (JArray)((_000E == null) ? null : /*isinst with value type is only supported in some contexts*/);
		if (val == null)
		{
			return null;
		}
		List<uint> list = new List<uint>(((JContainer)val).Count);
		foreach (JToken item2 in val)
		{
			if (!_0006_0018._000E(item2, out uint item))
			{
				return null;
			}
			list.Add(item);
		}
		return list;
	}

	internal static IReadOnlyDictionary<uint, IReadOnlyList<_0006_2006_200A>> _000E(JObject _000E, IReadOnlyList<uint> _0003, IList<_000E_2008_200A> _0006, IReadOnlyList<_0008_2001_200A> _000F)
	{
		Dictionary<uint, IReadOnlyList<_0006_2006_200A>> dictionary = new Dictionary<uint, IReadOnlyList<_0006_2006_200A>>();
		if (_0003 == null)
		{
			return dictionary;
		}
		uint num = 0u;
		bool flag = false;
		if (_0006 != null)
		{
			foreach (_000E_2008_200A item in _0006)
			{
				if (item != null && item._000E == 100 && item._0006())
				{
					num = item._000E_2008;
					flag = true;
					break;
				}
			}
		}
		JObject val = (JObject)((_000E == null) ? null : /*isinst with value type is only supported in some contexts*/);
		foreach (uint item2 in _0003)
		{
			if (flag && item2 == num)
			{
				if (_000F != null)
				{
					dictionary[item2] = _0006_0018._000E(_000F);
				}
				continue;
			}
			JArray val2 = (JArray)((val == null) ? null : /*isinst with value type is only supported in some contexts*/);
			if (val2 != null)
			{
				dictionary[item2] = _0006_0018._000E(val2);
			}
		}
		return dictionary;
	}

	internal static IReadOnlyDictionary<uint, _0003_2003_200A> _000E(JObject _000E, IReadOnlyList<uint> _0003, IList<_000E_2008_200A> _0006)
	{
		Dictionary<uint, _0003_2003_200A> dictionary = new Dictionary<uint, _0003_2003_200A>();
		JObject val = (JObject)((_000E == null) ? null : /*isinst with value type is only supported in some contexts*/);
		if (val == null || _0003 == null || _0006 == null)
		{
			return dictionary;
		}
		HashSet<uint> hashSet = new HashSet<uint>(_0003);
		foreach (_000E_2008_200A item in _0006)
		{
			if (item != null && item._000E == 100 && hashSet.Contains(item._000E_2008))
			{
				JToken obj = val[item._000E_2008.ToString(CultureInfo.InvariantCulture)];
				JObject val2 = (JObject)(object)((obj is JObject) ? obj : null);
				if (val2 != null && _0006_0018._000E(val2[_0008_0017._000E(-1141308128)], 0, 255, out var num) && _0006_0018._000E(val2[_0008_0017._000E(-1141293578)], 0, 65535, out var num2))
				{
					dictionary[item._000E_2008] = new _0003_2003_200A
					{
						_000E = (byte)num,
						_0003 = (ushort)num2
					};
				}
			}
		}
		return dictionary;
	}

	private static IReadOnlyList<_0006_2006_200A> _000E(IReadOnlyList<_0008_2001_200A> _000E)
	{
		List<_0006_2006_200A> list = new List<_0006_2006_200A>();
		foreach (_0008_2001_200A item in _000E)
		{
			if (!item._000E)
			{
				list.Add(new _0006_2006_200A
				{
					_000E = item._0006,
					_0003 = item._000F,
					_0006 = item._0002,
					_000F = item._0008
				});
			}
		}
		return list;
	}

	private static IReadOnlyList<_0006_2006_200A> _000E(JArray _000E)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		List<_0006_2006_200A> list = new List<_0006_2006_200A>(((JContainer)_000E).Count);
		foreach (JToken item in _000E)
		{
			JObject val = (JObject)(object)((item is JObject) ? item : null);
			if (val == null || val[_0008_0017._000E(-1141293578)] == null || (int)val[_0008_0017._000E(-1141293578)].Type != 8)
			{
				continue;
			}
			string[] array = ((string)val[_0008_0017._000E(-1141293578)]).Split(':');
			if (array.Length == 2 && ushort.TryParse(array[0], NumberStyles.Integer, CultureInfo.InvariantCulture, out var result) && ushort.TryParse(array[1], NumberStyles.Integer, CultureInfo.InvariantCulture, out var result2) && _0006_0018._000E(val[_0008_0017._000E(-1141193547)], 0, 65535, out var num))
			{
				float num2 = _0006_0018._000E(val, _0008_0017._000E(-1141193640), float.NaN);
				if (!float.IsNaN(num2) && !float.IsInfinity(num2))
				{
					list.Add(new _0006_2006_200A
					{
						_000E = result,
						_0003 = result2,
						_0006 = num,
						_000F = num2
					});
				}
			}
		}
		return list;
	}

	internal static _000E_200A _000E(JObject _000E)
	{
		_000E_200A result = new _000E_200A
		{
			_0006 = -1f
		};
		JToken obj = _000E[_0008_0017._000E(-1141193642)];
		JObject val = (JObject)(object)((obj is JObject) ? obj : null);
		if (val == null)
		{
			return result;
		}
		result._000E = (byte)_0006_0018._000E(val, _0008_0017._000E(-1141255953));
		result._0003 = _0006_0018._000E(val, _0008_0017._000E(-1141193661), 0f);
		result._0006 = _0006_0018._000E(val, _0008_0017._000E(-1141193556), -1f);
		return result;
	}

	internal static (ushort, ushort)[] _000E(JObject _000E)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		JToken val = _000E[_0008_0017._000E(-1141303993)];
		if (val == null || (int)val.Type != 9 || !(bool)val)
		{
			return null;
		}
		JToken obj = _000E[_0008_0017._000E(-1141193665)];
		JArray val2 = (JArray)(object)((obj is JArray) ? obj : null);
		if (val2 == null || ((JContainer)val2).Count != 10)
		{
			return null;
		}
		(ushort, ushort)[] array = new(ushort, ushort)[10];
		for (int i = 0; i < 10; i++)
		{
			JToken val3 = val2[i];
			if (val3 == null || (int)val3.Type != 8)
			{
				return null;
			}
			string[] array2 = ((string)val3).Split(':');
			if (array2.Length != 2)
			{
				return null;
			}
			if (!ushort.TryParse(array2[0], NumberStyles.None, CultureInfo.InvariantCulture, out var result))
			{
				return null;
			}
			if (!ushort.TryParse(array2[1], NumberStyles.None, CultureInfo.InvariantCulture, out var result2))
			{
				return null;
			}
			array[i] = (result, result2);
		}
		return array;
	}

	internal static string _000E(JObject _000E, IReadOnlyList<_0003_2008_200A> _0003, bool _0006)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		if (_000E == null)
		{
			return _0008_0017._000E(-1141129869);
		}
		JToken val = _000E[_0008_0017._000E(-1141303993)];
		if (val == null || (int)val.Type != 9 || !(bool)val)
		{
			JToken val2 = _000E[_0008_0017._000E(-1141253360)];
			if (val2 != null && (int)val2.Type == 8 && ((string)val2).Length != 0)
			{
				return (string)val2;
			}
			return _0008_0017._000E(-1141129869);
		}
		if (_0003 == null)
		{
			return _0008_0017._000E(-1141129217);
		}
		if (!_0006)
		{
			return _0008_0017._000E(-1141130794);
		}
		return string.Empty;
	}

	internal static IReadOnlyList<_0005_2005> _000E(JObject _000E)
	{
		List<_0005_2005> list = new List<_0005_2005>();
		if (_000E == null)
		{
			return list;
		}
		JToken obj = _000E[_0008_0017._000E(-1141188333)];
		JArray val = (JArray)(object)((obj is JArray) ? obj : null);
		if (val == null)
		{
			return list;
		}
		for (int i = 0; i < ((JContainer)val).Count; i++)
		{
			JToken obj2 = val[i];
			JObject val2 = (JObject)(object)((obj2 is JObject) ? obj2 : null);
			if (val2 != null && _0006_0018._000E(val2[_0008_0017._000E(-1141193675)], 0, int.MaxValue, out var num) && _0006_0018._000E(val2[_0008_0017._000E(-1141193683)], 0, int.MaxValue, out var num2) && _0006_0018._000E(val2[_0008_0017._000E(-1141193534)], 0, 65535, out var num3) && _0006_0018._000E(val2[_0008_0017._000E(-1141193537)], 0, 65535, out var num4) && _0006_0018._000E(val2[_0008_0017._000E(-1141193701)], 1, int.MaxValue, out var num5))
			{
				_0005_2005 item = new _0005_2005
				{
					_000E = num,
					_0003 = num2,
					_0006 = (ushort)num3,
					_000F = (ushort)num4,
					_0002 = num5
				};
				if (_0006_0018._000E(val2[_0008_0017._000E(-1141255953)], 0, 255, out var num6))
				{
					item._0008 = (byte)num6;
				}
				list.Add(item);
			}
		}
		return list;
	}

	internal static int _000E(JObject _000E)
	{
		if (_000E == null)
		{
			return 0;
		}
		if (!_0006_0018._000E(_000E[_0008_0017._000E(-1141193711)], 1, int.MaxValue, out var result))
		{
			return 0;
		}
		return result;
	}

	internal static int _0003(JObject _000E)
	{
		if (_000E == null)
		{
			return 0;
		}
		if (!_0006_0018._000E(_000E[_0008_0017._000E(-1141193358)], 0, int.MaxValue, out var result))
		{
			return 0;
		}
		return result;
	}

	internal static IReadOnlyList<_0003_2008_200A> _000E(JObject _000E)
	{
		if (_000E == null)
		{
			return null;
		}
		JToken obj = _000E[_0008_0017._000E(-1141193713)];
		JArray val = (JArray)(object)((obj is JArray) ? obj : null);
		if (val == null || ((JContainer)val).Count != 12)
		{
			return null;
		}
		_0003_2008_200A[] array = new _0003_2008_200A[12];
		for (int i = 0; i < 12; i++)
		{
			JToken obj2 = val[i];
			JObject val2 = (JObject)(object)((obj2 is JObject) ? obj2 : null);
			if (val2 == null)
			{
				return null;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141193675)], 0, int.MaxValue, out var num))
			{
				return null;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141192709)], 0, 255, out var num2))
			{
				return null;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141193534)], 0, 65535, out var num3))
			{
				return null;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141193537)], 0, 65535, out var num4))
			{
				return null;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141193701)], int.MinValue, int.MaxValue, out var num5))
			{
				return null;
			}
			array[i]._000E = num;
			array[i]._0003 = (byte)num2;
			array[i]._0006 = (ushort)num3;
			array[i]._000F = (ushort)num4;
			array[i]._0002 = num5;
		}
		return array;
	}

	internal static string _0003(JObject _000E)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		if (_000E == null)
		{
			return null;
		}
		JToken val = _000E[_0008_0017._000E(-1141259024)];
		if (val == null || (int)val.Type != 8)
		{
			return null;
		}
		string text = (string)val;
		if (!_000E_200B_200A._000E(text))
		{
			return null;
		}
		return text;
	}

	internal static IReadOnlyList<_0003_200B_200A> _000E(JObject _000E, string _0003, IReadOnlyList<_000E_200B_200A._000E> _0006)
	{
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Invalid comparison between Unknown and I4
		if (_000E == null || !_000E_200B_200A._000E(_0003))
		{
			return null;
		}
		JToken obj = _000E[_0008_0017._000E(-1141192719)];
		JArray val = (JArray)(object)((obj is JArray) ? obj : null);
		if (val == null || _0006 == null || _0006.Count == 0 || ((JContainer)val).Count != _0006.Count)
		{
			return null;
		}
		List<_0003_200B_200A> list = new List<_0003_200B_200A>();
		for (int i = 0; i < ((JContainer)val).Count; i++)
		{
			JToken obj2 = val[i];
			JObject val2 = (JObject)(object)((obj2 is JObject) ? obj2 : null);
			if (val2 == null)
			{
				return null;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141125133)], 0, 65535, out var num))
			{
				return null;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141193683)], 0, int.MaxValue, out var num2))
			{
				return null;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141193534)], 0, 65535, out var num3))
			{
				return null;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141193537)], 0, 65535, out var num4))
			{
				return null;
			}
			_000E_200B_200A._000E obj3 = _0006[i];
			if (num != obj3._000E || num2 != obj3._0003 || num3 != obj3._0006 || num4 != obj3._000F)
			{
				return null;
			}
			if (!_0006_0018._0003(val2[_0008_0017._000E(-1141192734)], out var flag))
			{
				return null;
			}
			if (!_0006_0018._0003(val2[_0008_0017._000E(-1141192740)], out var flag2))
			{
				return null;
			}
			if (!_0006_0018._0003(val2[_0008_0017._000E(-1141192756)], out var flag3))
			{
				return null;
			}
			JToken val3 = val2[_0008_0017._000E(-1141192775)];
			if (val3 == null || (int)val3.Type != 8)
			{
				return null;
			}
			string text = (string)val3;
			if (!_000E_200B_200A._0003(text))
			{
				return null;
			}
			if (!_0006_0018._000E(_0003, text, flag, flag2, flag3))
			{
				return null;
			}
			list.Add(new _0003_200B_200A
			{
				_000E = num,
				_0003 = num2,
				_0006 = (ushort)num3,
				_000F = (ushort)num4,
				_0002 = flag,
				_0008 = flag2,
				_0005 = flag3,
				_000E_2008 = text
			});
		}
		return list;
	}

	private static bool _0003(JToken _000E, out bool _0003)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		_0003 = false;
		if (_000E == null || (int)_000E.Type != 9)
		{
			return false;
		}
		_0003 = (bool)_000E;
		return true;
	}

	private static bool _000E(string _000E, string _0003, bool _0006, bool _000F, bool _0002)
	{
		if (string.Equals(_0003, _0008_0017._000E(-1141173131), StringComparison.Ordinal))
		{
			if (!_0006 && !_000F)
			{
				return !_0002;
			}
			return false;
		}
		if (string.Equals(_0003, _0008_0017._000E(-1141112980), StringComparison.Ordinal))
		{
			return _000E == _0008_0017._000E(-1141192789) && _0006 && _000F && _0002;
		}
		if (string.Equals(_0003, _0008_0017._000E(-1141192796), StringComparison.Ordinal))
		{
			if (_000E == _0008_0017._000E(-1141192789) && _0006 && _000F)
			{
				return !_0002;
			}
			return false;
		}
		return false;
	}

	internal static string _000E(JObject _000E, IReadOnlyList<_0003_200B_200A> _0003, string _0006, bool _000F)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		if (_000E == null)
		{
			return _0008_0017._000E(-1141192811);
		}
		JToken val = _000E[_0008_0017._000E(-1141303993)];
		if (val == null || (int)val.Type != 9 || !(bool)val)
		{
			JToken val2 = _000E[_0008_0017._000E(-1141253360)];
			if (val2 != null && (int)val2.Type == 8 && ((string)val2).Length != 0)
			{
				return (string)val2;
			}
			return _0008_0017._000E(-1141192811);
		}
		if (_0006 == null)
		{
			return _0008_0017._000E(-1141192871);
		}
		if (_0003 == null)
		{
			return _0008_0017._000E(-1141192920);
		}
		if (!_000F)
		{
			return _0008_0017._000E(-1141130794);
		}
		return string.Empty;
	}

	internal static bool _000E(JObject _000E, string _0003, string _0006, out bool _000F, out string _0002, out int _0008)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Invalid comparison between Unknown and I4
		_000F = false;
		_0002 = string.Empty;
		_0008 = 0;
		if (_000E == null)
		{
			_0002 = _0003;
			return false;
		}
		JToken val = _000E[_0008_0017._000E(-1141303993)];
		if (val == null || (int)val.Type != 9)
		{
			_0002 = _0003;
			return false;
		}
		_000F = (bool)val;
		if (!_000F)
		{
			JToken val2 = _000E[_0008_0017._000E(-1141253360)];
			_0002 = ((val2 != null && (int)val2.Type == 8 && ((string)val2).Length != 0) ? ((string)val2) : _0003);
			return true;
		}
		if (!_0006_0018._000E(_000E[_0008_0017._000E(-1141187929)], 1, int.MaxValue, out _0008))
		{
			_0002 = _0006;
			return false;
		}
		return true;
	}

	internal static string _0006(JObject _000E)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		if (_000E == null)
		{
			return null;
		}
		JToken val = _000E[_0008_0017._000E(-1141259024)];
		if (val == null || (int)val.Type != 8)
		{
			return null;
		}
		string text = (string)val;
		if (!global::_0008_2008_200A._000E(text))
		{
			return null;
		}
		return text;
	}

	internal static string _000E(JObject _000E, string _0003, bool _0006)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		if (_000E == null)
		{
			return _0008_0017._000E(-1141267684);
		}
		JToken val = _000E[_0008_0017._000E(-1141303993)];
		if (val == null || (int)val.Type != 9 || !(bool)val)
		{
			JToken val2 = _000E[_0008_0017._000E(-1141253360)];
			if (val2 != null && (int)val2.Type == 8 && ((string)val2).Length != 0)
			{
				return (string)val2;
			}
			return _0008_0017._000E(-1141267684);
		}
		if (_0003 == null)
		{
			return _0008_0017._000E(-1141142480);
		}
		if (!_0006)
		{
			return _0008_0017._000E(-1141130794);
		}
		return string.Empty;
	}

	internal static IReadOnlyList<_000F_2008_200A> _000E(JObject _000E, out int _0003)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Invalid comparison between Unknown and I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Invalid comparison between Unknown and I4
		_0003 = 0;
		List<_000F_2008_200A> list = new List<_000F_2008_200A>();
		if (_000E == null)
		{
			return list;
		}
		JToken obj = _000E[_0008_0017._000E(-1141188164)];
		JArray val = (JArray)(object)((obj is JArray) ? obj : null);
		if (val == null)
		{
			return list;
		}
		for (int i = 0; i < ((JContainer)val).Count; i++)
		{
			JToken obj2 = val[i];
			JObject val2 = (JObject)(object)((obj2 is JObject) ? obj2 : null);
			if (val2 == null)
			{
				_0003++;
				continue;
			}
			JToken val3 = val2[_0008_0017._000E(-1141293587)];
			if (val3 == null || (int)val3.Type != 8)
			{
				_0003++;
				continue;
			}
			string text = (string)val3;
			if (text.Trim().Length == 0)
			{
				_0003++;
				continue;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141293578)], int.MinValue, int.MaxValue, out var num))
			{
				_0003++;
				continue;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141192968)], -128, 127, out var num2))
			{
				_0003++;
				continue;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141192971)], 0, 255, out var num3))
			{
				_0003++;
				continue;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141193547)], 0, 65535, out var num4))
			{
				_0003++;
				continue;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141192980)], 0, 255, out var num5))
			{
				_0003++;
				continue;
			}
			if (!_0006_0018._000E(val2[_0008_0017._000E(-1141192998)], 0, 255, out var num6))
			{
				_0003++;
				continue;
			}
			JToken val4 = val2[_0008_0017._000E(-1141193008)];
			if (val4 == null || (int)val4.Type != 9)
			{
				_0003++;
				continue;
			}
			JToken val5 = val2[_0008_0017._000E(-1141193021)];
			if (val5 == null || (int)val5.Type != 9)
			{
				_0003++;
				continue;
			}
			list.Add(new _000F_2008_200A
			{
				_000E = text,
				_0003 = num,
				_0006 = (sbyte)num2,
				_000F = (bool)val4,
				_0002 = (bool)val5,
				_0008 = (byte)num3,
				_0005 = (ushort)num4,
				_000E_2008 = (byte)num5,
				_0003_2008 = (byte)num6
			});
		}
		return list;
	}

	internal static _0003_200A _000E(JObject _000E)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Invalid comparison between Unknown and I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Invalid comparison between Unknown and I4
		_0003_200A obj = new _0003_200A
		{
			_000E = _0006_0018._000E(_000E, _0008_0017._000E(-1141125133))
		};
		JToken val = _000E[_0008_0017._000E(-1141180506)];
		obj._0003 = ((val != null && (int)val.Type == 8) ? ((string)val) : string.Empty);
		JToken val2 = _000E[_0008_0017._000E(-1141193260)];
		obj._0006 = ((val2 != null && (int)val2.Type == 6) ? ((int)val2) : (-1));
		JToken val3 = _000E[_0008_0017._000E(-1141193025)];
		obj._000F = ((val3 != null && (int)val3.Type == 6) ? ((int)val3) : (-1));
		JToken val4 = _000E[_0008_0017._000E(-1141193041)];
		obj._0002 = val4 != null && (int)val4.Type == 9 && (bool)val4;
		JToken val5 = _000E[_0008_0017._000E(-1141193057)];
		obj._0008 = ((val5 != null && (int)val5.Type == 8) ? ((string)val5) : string.Empty);
		return obj;
	}

	internal static _0008_200B_200A _000E(JObject _000E, long _0003, _0008_200B_200A _0006)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		if (_000E == null)
		{
			return _0006;
		}
		JToken val = _000E[_0008_0017._000E(-1141303993)];
		if (val == null || (int)val.Type != 9 || !(bool)val)
		{
			return _0006;
		}
		JToken obj = _000E[_0008_0017._000E(-1141193665)];
		JArray val2 = (JArray)(object)((obj is JArray) ? obj : null);
		if (val2 == null)
		{
			return _0006;
		}
		List<_0002_200B_200A> list = new List<_0002_200B_200A>();
		for (int i = 0; i < ((JContainer)val2).Count; i++)
		{
			if (list.Count >= 10)
			{
				break;
			}
			JToken obj2 = val2[i];
			JObject val3 = (JObject)(object)((obj2 is JObject) ? obj2 : null);
			if (val3 != null && _0006_0018._000E(val3[_0008_0017._000E(-1141193534)], 0, 65535, out var num) && _0006_0018._000E(val3[_0008_0017._000E(-1141193537)], 0, 65535, out var num2))
			{
				if (!_0006_0018._000E(val3[_0008_0017._000E(-1141193260)], int.MinValue, int.MaxValue, out var num3))
				{
					num3 = -1;
				}
				list.Add(new _0002_200B_200A
				{
					_000E = (ushort)num,
					_0003 = (ushort)num2,
					_0006 = num3
				});
			}
		}
		return new _0008_200B_200A
		{
			_0003 = _0003,
			_0006 = list.ToArray()
		};
	}

	private static bool _000E(JToken _000E, int _0003, int _0006, out int _000F)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		_000F = 0;
		JValue val = (JValue)(object)((_000E is JValue) ? _000E : null);
		if (val == null || (int)((JToken)val).Type != 6 || !(val.Value is long))
		{
			return false;
		}
		long num = (long)val.Value;
		if (num < _0003 || num > _0006)
		{
			return false;
		}
		_000F = (int)num;
		return true;
	}

	private void _0003(JObject _000E)
	{
		JToken obj = _000E[_0008_0017._000E(-1141193067)];
		_0006_0018._000E((JObject)(object)((obj is JObject) ? obj : null), _0006_2000);
		JToken obj2 = _000E[_0008_0017._000E(-1141127438)];
		_0006_0018._000E((JObject)(object)((obj2 is JObject) ? obj2 : null), _000F_2000);
		JToken obj3 = _000E[_0008_0017._000E(-1141193088)];
		_0006_0018._000E((JObject)(object)((obj3 is JObject) ? obj3 : null), _0002_2000);
	}

	private static void _000E(JObject _000E, Dictionary<string, string> _0003)
	{
		if (_000E == null)
		{
			return;
		}
		foreach (KeyValuePair<string, JToken> item in _000E)
		{
			if (!string.IsNullOrEmpty(item.Key))
			{
				_0003[item.Key] = (string)item.Value;
			}
		}
	}

	private static List<_000E_2008_200A> _000E(IntPtr _000E, int _0003)
	{
		List<_000E_2008_200A> list = new List<_000E_2008_200A>();
		if (_000E == IntPtr.Zero || _0003 < 32)
		{
			return list;
		}
		byte[] array = new byte[_0003];
		Marshal.Copy(_000E, array, 0, _0003);
		for (int i = 0; i + 32 <= array.Length; i += 32)
		{
			list.Add(new _000E_2008_200A
			{
				_000E = array[i],
				_0003 = array[i + 1],
				_0006 = BitConverter.ToUInt16(array, i + 2),
				_000F = BitConverter.ToUInt16(array, i + 4),
				_0002 = BitConverter.ToUInt16(array, i + 6),
				_0008 = BitConverter.ToUInt16(array, i + 8),
				_0005 = BitConverter.ToUInt16(array, i + 10),
				_000E_2008 = BitConverter.ToUInt32(array, i + 12),
				_0003_2008 = BitConverter.ToSingle(array, i + 16),
				_0006_2008 = BitConverter.ToSingle(array, i + 20),
				_000F_2008 = BitConverter.ToSingle(array, i + 24),
				_0002_2008 = BitConverter.ToUInt16(array, i + 28),
				_0008_2008 = array[i + 30],
				_0005_2008 = array[i + 31]
			});
		}
		return list;
	}

	internal void _000E(int _000E, IntPtr _0003)
	{
		_0008 obj = new _0008();
		obj._000E = this;
		obj._0003 = _000E;
		lock (this.m__0006)
		{
			if (_0003.ToInt64() != Interlocked.Read(ref this.m__0008))
			{
				return;
			}
			this.m__0005 = _0003.ToInt64();
			_0008_200B = null;
			_000F_200B = false;
			Interlocked.Increment(ref _0002_200B);
			Volatile.Write(ref this.m__000E_2007, 0);
			_000E_2006 = _0003.ToInt64();
			_000F_2006 = _0008_0017._000E(-1141193101);
			_0006_2006 = false;
			_0002_2006 = false;
			_0008_2006 = null;
			_0005_2006 = -1L;
			_000E_2003 = global::_0006_2005._000E();
			this.m__0005_2008.Set();
			this.m__0003_2007.Set();
			_000F_2002.Set();
			_0006_2003.Set();
			_000F_2003.Set();
			_0002_2003.Set();
		}
		_000F(_0008_0017._000E(-1141193126) + obj._0003);
		Volatile.Write(ref _0003_200A, 0);
		_0003_2001 = false;
		_0005_2001 = false;
		_0006_2001 = false;
		_000F_2001 = false;
		_0002_2001 = false;
		_0008_2001 = false;
		_000E_200B = false;
		_0003_200B = false;
		_0006_200B = false;
		_0002_2008();
		_0008_2008();
		_0005_2008();
		_000E_2008_200A = _0006_2004_200A._0006_2008;
		_0005_2006_200A = null;
		_000E_2003_200A = null;
		_0003_2003_200A = null;
		this._000F();
		_000F(obj._000E);
	}

	private void _000E(string _000E, IntPtr _0003)
	{
		_0005 obj = new _0005();
		obj._000E = this;
		obj._0003 = _0003;
		obj._0006 = _000E;
		if (obj._0003.ToInt64() != Interlocked.Read(ref this.m__0008))
		{
			return;
		}
		bool lockTaken = false;
		try
		{
			Monitor.TryEnter(this.m__0003, 0, ref lockTaken);
			if (!lockTaken)
			{
				ThreadPool.QueueUserWorkItem(obj._000E);
			}
			else if (obj._0003.ToInt64() == Interlocked.Read(ref this.m__0008))
			{
				this._0003(obj._0006);
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(this.m__0003);
			}
		}
	}

	internal static bool _000E(string _000E, string _0003)
	{
		if (_000E == null)
		{
			return false;
		}
		try
		{
			return (bool?)JObject.Parse(_000E)[_0003] == true;
		}
		catch
		{
			return false;
		}
	}

	private static string _000E(JToken _000E)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		if (_000E == null || (int)_000E.Type != 8)
		{
			return null;
		}
		return (string)_000E;
	}

	private static string _000E(JObject _000E, string _0003)
	{
		string text = _0006_0018._000E((_000E == null) ? null : _000E[_0008_0017._000E(-1141253360)]);
		if (string.IsNullOrWhiteSpace(text) || text.Length > 160)
		{
			return _0003;
		}
		string text2 = text;
		for (int i = 0; i < text2.Length; i++)
		{
			if (char.IsControl(text2[i]))
			{
				return _0003;
			}
		}
		return text;
	}

	internal static string _0003()
	{
		if (_0005_2003_200A != null)
		{
			return _0005_2003_200A;
		}
		try
		{
			using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_0008_0017._000E(-1141114550));
			if (stream == null)
			{
				return null;
			}
			StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
			try
			{
				_0005_2003_200A = streamReader.ReadToEnd();
			}
			finally
			{
				((IDisposable)streamReader).Dispose();
			}
		}
		catch
		{
			return null;
		}
		return _0005_2003_200A;
	}

	private void _000F(Action _000E)
	{
		_000E_2008 obj = new _000E_2008();
		obj._000E = _000E;
		SynchronizationContext synchronizationContext = _000F_2005;
		if (synchronizationContext != null)
		{
			synchronizationContext.Post(obj._000E, null);
		}
		else
		{
			obj._000E();
		}
	}

	private void _000E(long _000E, Action _0003)
	{
		_0003_2008 obj = new _0003_2008();
		obj._000E = this;
		obj._0003 = _000E;
		obj._0006 = _0003;
		_000F(obj._000E);
	}

	private void _000F(string _000E)
	{
		_0006_2008 obj = new _0006_2008();
		obj._000E = this;
		obj._0003 = _000E;
		if (global::_0006_2008_200A._000E(obj._0003))
		{
			_000F(obj._000E);
		}
	}

	internal void _0002(string _000E)
	{
		_000F(_000E ?? string.Empty);
	}

	public void Dispose()
	{
		this._0005_2007();
	}

	public void _0005_2007()
	{
		lock (this.m__0003)
		{
			_0005_2007_200A?.Invoke();
			_000E_2002();
		}
	}

	private void _000E_2002()
	{
		this.m__000E_2002 = null;
		Volatile.Write(ref _0003_200A, 0);
		IntPtr intPtr = IntPtr.Zero;
		string text = null;
		lock (this.m__0006)
		{
			if (this.m__000E != IntPtr.Zero && _0002_2006)
			{
				intPtr = this.m__000E;
				text = _0008_2006;
				_0002_2006 = false;
			}
		}
		if (intPtr != IntPtr.Zero)
		{
			_000E(intPtr, text);
		}
		this._000F();
		if (this.m__000E != IntPtr.Zero)
		{
			try
			{
				_0003(_0008_0017._000E(-1141193150));
				Thread.Sleep(200);
			}
			catch
			{
			}
		}
		IntPtr intPtr2;
		lock (this.m__0006)
		{
			Interlocked.Increment(ref this.m__0008);
			Volatile.Write(ref this.m__000E_2007, 0);
			this.m__0005 = -1L;
			intPtr2 = this.m__000E;
			this.m__000E = IntPtr.Zero;
		}
		_0003_2002();
		if (intPtr2 != IntPtr.Zero)
		{
			_000E(intPtr2);
		}
	}

	private void _0003_2002()
	{
		Volatile.Write(ref _0003_200A, 0);
		Volatile.Write(ref this.m__000E_2007, 0);
		this.m__0005_2008.Reset();
		this.m__0003_2007.Reset();
		this.m__000F_2007 = 0;
		this.m__0002_2007 = -1L;
		this.m__0008_2007 = false;
		this.m__0005_2007 = null;
		lock (this.m__0006)
		{
			_000E();
		}
		_0003_2006_200A = null;
		_0006_2006_200A = null;
		_000F_2006_200A = null;
		_0002_2006_200A = null;
		_0008_2006_200A = null;
		_0005_2006_200A = null;
		_000E_2003_200A = null;
		_0003_2003_200A = null;
		_0003_2001 = false;
		_0005_2001 = false;
		_0006_2001 = false;
		_000F_2001 = false;
		_0002_2001 = false;
		_0008_2001 = false;
		_000E_200B = false;
		_0003_200B = false;
		_0006_200B = false;
		_0002();
		_0002_2008();
		_0008_2008();
		_0005_2008();
		_000E_2008_200A = _0006_2004_200A._0006_2008;
		_0003_2005 = null;
		_0006_2005 = null;
	}

	private bool _0005_2007()
	{
		lock (this.m__000F)
		{
			if (this.m__0006_2008 == null)
			{
				return false;
			}
			if (this.m__0006_2008.IsAlive)
			{
				return true;
			}
			this.m__0006_2008 = null;
			return false;
		}
	}

	private bool _000E(IntPtr _000E)
	{
		_000F_2008 obj = new _000F_2008();
		obj._0003 = _000E;
		obj._000F = this;
		if (obj._0003 == IntPtr.Zero)
		{
			return true;
		}
		obj._000E = this.m__0002;
		obj._0006 = null;
		obj._0002 = null;
		obj._0002 = new Thread(obj._000E)
		{
			IsBackground = true
		};
		lock (this.m__000F)
		{
			if (this.m__0006_2008 != null && this.m__0006_2008.IsAlive)
			{
				_000F(_0008_0017._000E(-1141193180));
				return false;
			}
			this.m__0006_2008 = obj._0002;
			obj._0002.Start();
		}
		if (!obj._0002.Join(this.m__000F_2008))
		{
			_000F(_0008_0017._000E(-1141194286));
			return false;
		}
		if (obj._0006 != null)
		{
			_000F(_0008_0017._000E(-1141194382) + obj._0006.Message);
		}
		return true;
	}

	private static bool _000E(JToken _000E, out uint _0003)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		_0003 = 0u;
		JValue val = (JValue)(object)((_000E is JValue) ? _000E : null);
		if (val == null || (int)((JToken)val).Type != 6 || !(val.Value is long))
		{
			return false;
		}
		long num = (long)val.Value;
		if (num < 0 || num > uint.MaxValue)
		{
			return false;
		}
		_0003 = (uint)num;
		return true;
	}
}
public sealed class _0006_200B : JsonConverter
{
	public override bool CanConvert(Type _000E)
	{
		return _000E == typeof(TimeSpan?);
	}

	public override object ReadJson(JsonReader _000E, Type _0003, object _0006, JsonSerializer _000F)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)_000E.TokenType == 7)
		{
			return TimeSpan.FromMilliseconds((long)_000E.Value);
		}
		return null;
	}

	public override void WriteJson(JsonWriter _000E, object _0003, JsonSerializer _0006)
	{
		if (_0003 is TimeSpan timeSpan)
		{
			_000E.WriteValue(timeSpan.TotalMilliseconds);
		}
	}
}
internal static class _0006_200B_200A
{
	internal static bool _000E()
	{
		return _0008_2004_200A._000E(_0008_0017._000E(-1141031530), _0008_0017._000E(-1141296467)) != _0008_0017._000E(-1141296459);
	}

	internal static string _000E()
	{
		return _0002_2006_200A._0003();
	}

	internal static string _0003()
	{
		return _0008_2004_200A._000E(_0008_0017._000E(-1141031557), string.Empty);
	}
}
internal static class _0008_0017
{
	private sealed class _0003
	{
		private Stream m__000E;

		private byte[] m__0003;

		public _0003(Stream _000E)
		{
			this.m__000E = _000E;
			m__0003 = new byte[4];
		}

		public Stream _000E()
		{
			return this.m__000E;
		}

		public short _000E()
		{
			_000E(2);
			return (short)(m__0003[0] | (m__0003[1] << 8));
		}

		public int _000E()
		{
			_000E(4);
			return m__0003[0] | (m__0003[1] << 8) | (m__0003[2] << 16) | (m__0003[3] << 24);
		}

		private static void _000E()
		{
			throw new EndOfStreamException();
		}

		private void _000E(int _000E)
		{
			int num = 0;
			int num2 = 0;
			if (_000E == 1)
			{
				num2 = this.m__000E.ReadByte();
				if (num2 == -1)
				{
					_0008_0017._0003._000E();
				}
				m__0003[0] = (byte)num2;
				return;
			}
			do
			{
				num2 = this.m__000E.Read(m__0003, num, _000E - num);
				if (num2 == 0)
				{
					_0008_0017._0003._000E();
				}
				num += num2;
			}
			while (num < _000E);
		}

		public void _000E()
		{
			Stream stream = this.m__000E;
			this.m__000E = null;
			stream?.Close();
			m__0003 = null;
		}

		public byte[] _000E(int _000E)
		{
			if (_000E < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[_000E];
			int num = 0;
			do
			{
				int num2 = this.m__000E.Read(array, num, _000E);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				_000E -= num2;
			}
			while (_000E > 0);
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				array = array2;
			}
			return array;
		}
	}

	private enum _000E
	{

	}

	private static int _0002;

	private static _0003 m__0003;

	private static ConcurrentDictionary<int, string> m__000E;

	private static byte[] _0008;

	private static byte[] _0006;

	private static short _000F;

	private static _000E _0003_2008;

	private static int _0005;

	private static int _000E_2008;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _0008_0017()
	{
		int num = 920246534;
		int num2 = num + -74375988;
		_0008_0017.m__000E = new ConcurrentDictionary<int, string>();
		int num3 = 2;
		StackTrace stackTrace = new StackTrace(num3, fNeedFileInfo: false);
		num3 -= 2;
		StackFrame frame = stackTrace.GetFrame(num3);
		int num4 = num3;
		if (frame == null)
		{
			stackTrace = new StackTrace();
			num4 = 1;
			frame = stackTrace.GetFrame(num4);
		}
		int num5 = -(~(~(-(-(~(-(~(~((-1019345426 ^ num) - num2))))))))) ^ ~(-(-(~(~(-(-(~(~(-(~((369701070 - num) ^ num2)))))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num5 ^= -(~(~(-(-(~(-(~(~((num ^ 0x29692CD5) - num2)))))))));
		}
		Type type = methodBase?.DeclaringType;
		if (type == typeof(RuntimeMethodHandle))
		{
			num5 ^= num + -1766116273 + num2 + num3;
			_0003_2008 |= (_000E)4;
		}
		else if (type == null)
		{
			if (_000E(stackTrace, num4))
			{
				num5 ^= -(~(~(-(~(-(~(-(~(-78868787 ^ num ^ num2))))))))) - num3;
				_0003_2008 = (_000E)16 | _0003_2008;
			}
			else
			{
				_0003_2008 |= (_000E)1;
				num5 ^= -(~(-(~(~(-(-(~(~(1766080035 - num - num2)))))))));
			}
		}
		else
		{
			num5 ^= ~(-(~(-(-(~(~(-(~(num ^ -78868787 ^ num2))))))))) - num3;
			_0003_2008 = (_000E)16 | _0003_2008;
		}
		_000E_2008 = num5 + _000E_2008;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string _000E(int _000E)
	{
		if (_0008_0017.m__000E.TryGetValue(_000E, out var value))
		{
			return value;
		}
		return _0008_0017._000E(_000E, _0003: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string _000E(int _000E, bool _0003)
	{
		int num = 539390694;
		int num2 = -1299397304 - num;
		string value = null;
		byte[] array;
		int num19;
		int num20;
		int num21;
		int num23;
		byte[] array4;
		byte[] array3;
		int num22;
		while (true)
		{
			lock (_0008_0017.m__000E)
			{
				int num7;
				if (_0008_0017.m__0003 == null)
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					Assembly callingAssembly;
					try
					{
						callingAssembly = Assembly.GetCallingAssembly();
					}
					catch (PlatformNotSupportedException)
					{
						callingAssembly = executingAssembly;
					}
					_0002 |= (num + 1918389754) ^ num2;
					StringBuilder stringBuilder = new StringBuilder();
					int num3 = (num ^ -1383612603) + num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = (-762583732 - num) ^ num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = (-1840316278 ^ num) - num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = (-762780342 - num) ^ num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = (-1383612603 ^ num) + num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = (-762452655 - num) ^ num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = (-1840709502 ^ num) - num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
					int num4 = 2;
					StackTrace stackTrace = new StackTrace(num4, fNeedFileInfo: false);
					_0002 ^= (-1916782134 - num + num2) | num4;
					num4 -= 2;
					StackFrame frame = stackTrace.GetFrame(num4);
					int num5 = num4;
					if (frame == null)
					{
						stackTrace = new StackTrace();
						num5 = 1;
						frame = stackTrace.GetFrame(num5);
					}
					MethodBase methodBase = frame?.GetMethod();
					_0002 ^= num4 + (1916788732 + num - num2);
					Type type = methodBase?.DeclaringType;
					if (frame == null)
					{
						_0002 ^= -1916569289 - num + num2;
					}
					bool flag = type == typeof(RuntimeMethodHandle);
					_0002 ^= (num ^ -1304419868) - num2;
					if (!flag)
					{
						flag = type == null;
						if (flag)
						{
							if (_0008_0017._000E(stackTrace, num5))
							{
								flag = false;
							}
							else
							{
								_0002 ^= 1299616587 + num + num2;
							}
						}
					}
					if (flag == (stackTrace != null))
					{
						_0002 ^= 32;
					}
					_0002 ^= ((num ^ -1304422098) - num2) | (num4 + 1);
					_0008_0017.m__0003 = new _0003(manifestResourceStream);
					short num6 = (short)(_0008_0017.m__0003._000E() ^ (short)(-(~(-(~(~(-(-(~(~(1299380580 + num + num2)))))))))));
					if (num6 == 0)
					{
						_000F = (short)(_0008_0017.m__0003._000E() ^ (short)(-(~(~(-(-(~(~(-(-(~(~(num ^ 0x4DBFC7BC ^ num2)))))))))))));
					}
					else
					{
						_0006 = _0008_0017.m__0003._000E(num6);
					}
					callingAssembly = executingAssembly;
					AssemblyName assemblyName = _0008_0017._000E(callingAssembly);
					_0008 = _0008_0017._000E(assemblyName);
					num7 = _000E_2008;
					_000E_2008 = 0;
					num7 ^= num + 1633904493 + num2;
					long num8 = _0005_2009_200B._000E();
					num7 ^= (int)num8;
					num7 ^= (-1722188970 ^ num) - num2;
					num7 ^= (-625719944 + num) ^ num2;
					int num9 = 0;
					int num10 = 0;
					int num11 = num7;
					int num12 = 0;
					int num13 = 0;
					global::_0008_2008<int> obj = null;
					int num14 = 0;
					num12 = num11;
					int num15 = 0;
					num13 = num12 ^ ((0x4E519F8D ^ num) - num2);
					num10 = 0;
					num9 = num13 * ((-1299400267 - num) ^ num2) % (1327138981 + num + num2);
					obj = null;
					num10 = num ^ -1304420111 ^ num2;
					num15 = 0;
					num14 = num9;
					obj = ((global::_0006_2008<int>)new _0005_2008._0006((-1916788606 - num) | num2)
					{
						_0002 = num14
					}).GetEnumerator();
					try
					{
						while (((_000F_2008)obj)._000F_2008_2009_200B_2005_2005_000E())
						{
							num15 = obj._000F_2008_2009_200B_2005_2005_000E();
							num9 ^= num15 - num10;
							num10 -= num9 + 3 >> 8;
						}
					}
					finally
					{
						obj?._0002_2008_2009_200B_2005_2005_000E();
					}
					int num16 = num9;
					num7 ^= 1300112362 + num + num2 + -(~(~(-(~(-(~(-(~(-(~(-1299397614 - num - num2)))))))))));
					num7 ^= -(~(-(~(-(~(~(-(-(~(~((num ^ 0x528C5C2F) + num2)))))))))));
					num7 += num16;
					_0002 = (_0002 & ((-1111482378 - num) ^ num2)) ^ (1916795392 + num - num2);
					_0005 = num7;
					if (((uint)_0003_2008 & (uint)(~(-(-(~(~(-(~(-(-(~(~((-1916788622 - num) | num2))))))))))))) == 0)
					{
						_0002 = (1916831474 + num) ^ num2;
					}
				}
				else
				{
					num7 = _0005;
				}
				if (_0002 == (num ^ 0x4DBC2BBE) + num2)
				{
					value = new string(new char[3]
					{
						(char)((-1299397344 - num) ^ num2),
						'0',
						(char)(num + 1299397392 + num2)
					});
					return value;
				}
				int num17 = _000E ^ (386230417 - num - num2) ^ num7;
				num17 ^= (num + -1679286138) ^ num2;
				_0008_0017.m__0003._000E().Position = num17;
				if (_0006 != null)
				{
					array = _0006;
				}
				else
				{
					short num18 = ((_000F != -1) ? _000F : ((short)(_0008_0017.m__0003._000E() ^ (-1916765170 - num + num2) ^ num17)));
					if (num18 == 0)
					{
						array = null;
					}
					else
					{
						array = _0008_0017.m__0003._000E(num18);
						for (int i = 0; i != array.Length; i++)
						{
							array[i] ^= (byte)(_0005 >> ((3 & i) << 3));
						}
					}
				}
				num19 = _0008_0017.m__0003._000E() ^ num17 ^ -(~(~(-(~(-(~(-(-(~(~(0x4A08AE28 ^ num ^ num2))))))))))) ^ num7;
				if (num19 == ((1299397302 + num) | num2))
				{
					byte[] array2 = _0008_0017.m__0003._000E(4);
					_000E = ((num ^ -1170493102) - num2) ^ num7;
					_000E = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -_000E;
					goto IL_0013;
				}
				num20 = _0002;
				num21 = (-1297789494 - num) ^ num2;
				num22 = num20 - 12;
				num23 = num19;
				num19 &= num + 1567832759 + num2;
				array3 = _0008_0017.m__0003._000E(num19);
				array4 = _0008;
			}
			break;
			IL_0013:
			if (_0008_0017.m__000E.TryGetValue(_000E, out value))
			{
				return value;
			}
		}
		bool flag2 = (num23 & (num ^ -1841291132 ^ num2)) != 0;
		bool flag3 = (num23 & (-225655480 - num - num2)) != 0;
		bool flag4 = (num23 & (-848086344 + num + num2)) != 0;
		byte[] array5 = array;
		byte[] array6 = array3;
		byte[] array7 = array5;
		ushort num24 = 0;
		byte b = 0;
		byte b2 = 0;
		int num25 = 0;
		byte b3 = 0;
		uint num26 = 0u;
		byte b4 = 0;
		int num27 = 0;
		b = array7[1];
		num25 = array6.Length;
		b2 = (byte)((11 + num25) ^ (7 + b));
		num26 = (uint)((array7[0] | (array7[2] << 8)) + (b2 << 3));
		num27 = 0;
		num24 = 0;
		while (num27 < num25)
		{
			if ((1 & num27) == 0)
			{
				num26 = (uint)((int)num26 * (-1299183291 - num - num2) + ((num ^ 0x4DE63E87) + num2));
				num24 = (ushort)(num26 >> 16);
			}
			b3 = (byte)num24;
			num24 >>= 8;
			b4 = array6[num27];
			array6[num27] = (byte)(b4 ^ b ^ (3 + b2) ^ b3);
			b2 = b4;
			num27 = 1 + num27;
		}
		array3 = array6;
		if (array4 != null != (num20 != num21))
		{
			for (int j = 0; j < num19; j++)
			{
				byte b5 = array4[7 & j];
				b5 = (byte)((b5 << 3) | (b5 >> 5));
				array3[j] ^= b5;
			}
		}
		byte[] array8;
		int num28;
		if (!flag3)
		{
			array8 = array3;
			num28 = num19;
		}
		else
		{
			num28 = array3[2] | (array3[0] << 16) | (array3[3] << 8) | (array3[1] << 24);
			array8 = new byte[num28];
			_0008_0017._000E(array3, 4, array8);
		}
		if (flag2 && num22 == num21 - 12)
		{
			char[] array9 = new char[num28];
			for (int num29 = 0; num29 < num28; num29 = 1 + num29)
			{
				array9[num29] = (char)array8[num29];
			}
			value = new string(array9);
		}
		else
		{
			char[] array10 = new char[num28 / 2];
			int num30 = 0;
			for (int k = 0; k < num28; k += 2)
			{
				array10[num30++] = (char)(array8[k] | (array8[1 + k] << 8));
			}
			value = new string(array10);
		}
		num22 += ((-1299397373 - num) ^ num2) + (3 & num22) << 5;
		if (num22 != num21 - 12 + (1299397431 + num + num2 + ((num21 - 12) & 3) << 5))
		{
			int num31 = (num19 + _000E) ^ (-1298460736 - num - num2) ^ (num22 & ((num + 1916789897) ^ num2));
			StringBuilder stringBuilder = new StringBuilder();
			int num3 = -1299397216 - num - num2;
			stringBuilder.Append((char)(byte)num3);
			value = num31.ToString(stringBuilder.ToString());
		}
		if (!flag4 && _0003)
		{
			value = string.Intern(value);
			_0008_0017.m__000E[_000E] = value;
			if (_0008_0017.m__000E.Count == (-1304412389 ^ num ^ num2))
			{
				bool lockTaken = false;
				ConcurrentDictionary<int, string> obj2 = _0008_0017.m__000E;
				try
				{
					Monitor.Enter(obj2, ref lockTaken);
					if (_0008_0017.m__0003 != null)
					{
						_0008_0017.m__0003._000E();
						_0008_0017.m__0003 = null;
						_0006 = null;
						_0008 = null;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj2);
					}
				}
			}
		}
		return value;
	}

	private static AssemblyName _000E(Assembly _000E)
	{
		try
		{
			return _000E.GetName();
		}
		catch
		{
			return new AssemblyName(_000E.FullName);
		}
	}

	private static byte[] _000E(AssemblyName _000E)
	{
		byte[] array = _000E.GetPublicKeyToken();
		if (array != null && array.Length == 0)
		{
			array = null;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _000E(StackTrace _000E, int _0003)
	{
		Assembly assembly = _000E.GetFrame(++_0003)?.GetMethod()?.DeclaringType?.Assembly;
		if (assembly != null)
		{
			AssemblyName assemblyName = _0008_0017._000E(assembly);
			byte[] array = _0008_0017._000E(assemblyName);
			if (array != null && array.Length == 8 && array[0] == 183 && array[7] == 137)
			{
				return true;
			}
		}
		while (true)
		{
			StackFrame frame = _000E.GetFrame(++_0003);
			if (frame == null)
			{
				break;
			}
			assembly = frame.GetMethod()?.DeclaringType?.Assembly;
			if (assembly != null && assembly == typeof(_0008_0017).Assembly)
			{
				return true;
			}
		}
		return false;
	}

	private static void _000E(byte[] _000E, int _0003, byte[] _0006)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 128;
		int num4 = _0006.Length;
		while (num < num4)
		{
			if ((num3 <<= 1) == 256)
			{
				num3 = 1;
				num2 = _000E[_0003++];
			}
			if ((num2 & num3) != 0)
			{
				int num5 = (_000E[_0003] >> 2) + 3;
				int num6 = ((_000E[_0003] << 8) | _000E[_0003 + 1]) & 0x3FF;
				_0003 += 2;
				int num7 = num - num6;
				if (num7 < 0)
				{
					break;
				}
				while (--num5 >= 0 && num < num4)
				{
					_0006[num++] = _0006[num7++];
				}
			}
			else
			{
				_0006[num++] = _000E[_0003++];
			}
		}
	}
}
internal enum _0008_0018
{

}
internal static class _0008_200B
{
	internal static readonly string _000E = _0008_0017._000E(-1141270947);

	internal static readonly string _0003 = _0008_0017._000E(-1141270988);

	internal static readonly string _0006 = _0008_0017._000E(-1141271035);

	internal static readonly string _000F = _0008_0017._000E(-1141272104);

	internal static readonly string _0002 = _0008_0017._000E(-1141272135);

	private static bool m__0008;

	private static string m__0005;

	private static int m__000E_2008;

	private static int m__0003_2008;

	private static int m__0006_2008;

	private static int m__000F_2008;

	private static string m__0002_2008;

	internal static bool _0008_2008 = true;

	private static readonly Dictionary<string, int> m__0005_2008 = new Dictionary<string, int>(StringComparer.Ordinal);

	private static bool m__000E_2007;

	private static bool m__0003_2007;

	private static bool m__0006_2007;

	private static bool m__000F_2007;

	private static bool m__0002_2007;

	private static bool m__0008_2007;

	private static bool m__0005_2007;

	private static bool m__000E_2002;

	private static bool m__0003_2002;

	private static bool m__0006_2002;

	private static bool m__000F_2002;

	private static bool _0002_2002;

	private static bool _0008_2002;

	private static bool _0005_2002;

	private static bool _000E_2006;

	private static bool _0003_2006;

	private static bool _0006_2006;

	private static bool _000F_2006;

	private static bool _0002_2006;

	private static bool _0008_2006;

	private static bool _0005_2006;

	private static bool _000E_2003;

	private static bool _0003_2003;

	private static bool _0006_2003;

	internal static readonly (string, string)[] _000F_2003 = new(string, string)[20]
	{
		(_0008_0017._000E(-1141272167), _0008_0017._000E(-1141272197)),
		(_0008_0017._000E(-1141272215), _0008_0017._000E(-1141272256)),
		(_0008_0017._000E(-1141272276), _0008_0017._000E(-1141272322)),
		(_0008_0017._000E(-1141272357), _0008_0017._000E(-1141272405)),
		(_0008_0017._000E(-1141272426), _0008_0017._000E(-1141272467)),
		(_0008_0017._000E(-1141272503), _0008_0017._000E(-1141272538)),
		(_0008_0017._000E(-1141272562), _0008_0017._000E(-1141271590)),
		(_0008_0017._000E(-1141271622), _0008_0017._000E(-1141271663)),
		(_0008_0017._000E(-1141271683), _0008_0017._000E(-1141271724)),
		(_0008_0017._000E(-1141271760), _0008_0017._000E(-1141271796)),
		(_0008_0017._000E(-1141271827), _0008_0017._000E(-1141271867)),
		(_0008_0017._000E(-1141271903), _0008_0017._000E(-1141271960)),
		(_0008_0017._000E(-1141271998), _0008_0017._000E(-1141272044)),
		(_0008_0017._000E(-1141269012), _0008_0017._000E(-1141269055)),
		(_0008_0017._000E(-1141269078), _0008_0017._000E(-1141269115)),
		(_0008_0017._000E(-1141269147), _0008_0017._000E(-1141269185)),
		(_0008_0017._000E(-1141269210), _0008_0017._000E(-1141269249)),
		(_0008_0017._000E(-1141269275), _0008_0017._000E(-1141269319)),
		(_0008_0017._000E(-1141269342), _0008_0017._000E(-1141269374)),
		(_0008_0017._000E(-1141269386), _0008_0017._000E(-1141269427))
	};

	internal static readonly (string, string)[] _0002_2003 = new(string, string)[4]
	{
		(_0008_0017._000E(-1141269449), _0008_0017._000E(-1141268488)),
		(_0008_0017._000E(-1141268498), _0008_0017._000E(-1141268543)),
		(_0008_0017._000E(-1141268556), _0008_0017._000E(-1141268594)),
		(_0008_0017._000E(-1141268624), _0008_0017._000E(-1141268652))
	};

	internal static readonly (string, string)[] _0008_2003 = new(string, string)[4]
	{
		(_0008_0017._000E(-1141268680), _0008_0017._000E(-1141268714)),
		(_0008_0017._000E(-1141268743), _0008_0017._000E(-1141268784)),
		(_0008_0017._000E(-1141268800), _0008_0017._000E(-1141268833)),
		(_0008_0017._000E(-1141268849), _0008_0017._000E(-1141268893))
	};

	internal static readonly (string, string)[] _0005_2003 = new(string, string)[3]
	{
		(_0008_0017._000E(-1141268917), _0008_0017._000E(-1141268949)),
		(_0008_0017._000E(-1141268961), _0008_0017._000E(-1141270027)),
		(_0008_0017._000E(-1141268849), _0008_0017._000E(-1141268893))
	};

	internal static readonly (string, string)[] _000E_2001 = new(string, string)[7]
	{
		(_0008_0017._000E(-1141270054), _0008_0017._000E(-1141270087)),
		(_0008_0017._000E(-1141270105), _0008_0017._000E(-1141270144)),
		(_0008_0017._000E(-1141270168), _0008_0017._000E(-1141270199)),
		(_0008_0017._000E(-1141269147), _0008_0017._000E(-1141269185)),
		(_0008_0017._000E(-1141269210), _0008_0017._000E(-1141269249)),
		(_0008_0017._000E(-1141269275), _0008_0017._000E(-1141269319)),
		(_0008_0017._000E(-1141268849), _0008_0017._000E(-1141268893))
	};

	internal static readonly (string, string)[] _0003_2001 = new(string, string)[4]
	{
		(_0008_0017._000E(-1141270221), _0008_0017._000E(-1141270277)),
		(_0008_0017._000E(-1141270289), _0008_0017._000E(-1141270347)),
		(_0008_0017._000E(-1141270370), _0008_0017._000E(-1141270419)),
		(_0008_0017._000E(-1141270441), _0008_0017._000E(-1141270501))
	};

	internal static readonly (string, string)[] _0006_2001 = new(string, string)[7]
	{
		(_0008_0017._000E(-1141270518), _0008_0017._000E(-1141269543)),
		(_0008_0017._000E(-1141269565), _0008_0017._000E(-1141269615)),
		(_0008_0017._000E(-1141269628), _0008_0017._000E(-1141269683)),
		(_0008_0017._000E(-1141269709), _0008_0017._000E(-1141269755)),
		(_0008_0017._000E(-1141269782), _0008_0017._000E(-1141269824)),
		(_0008_0017._000E(-1141269078), _0008_0017._000E(-1141269115)),
		(_0008_0017._000E(-1141269836), _0008_0017._000E(-1141269895))
	};

	internal static readonly (string, string)[] _000F_2001 = new(string, string)[4]
	{
		(_0008_0017._000E(-1141269906), _0008_0017._000E(-1141269960)),
		(_0008_0017._000E(-1141269984), _0008_0017._000E(-1141275149)),
		(_0008_0017._000E(-1141275161), _0008_0017._000E(-1141275203)),
		(_0008_0017._000E(-1141275230), _0008_0017._000E(-1141275267))
	};

	internal static readonly (string, string)[] _0002_2001 = new(string, string)[2]
	{
		(_0008_0017._000E(-1141275291), _0008_0017._000E(-1141275366)),
		(_0008_0017._000E(-1141275384), _0008_0017._000E(-1141275427))
	};

	internal static readonly (string, string)[] _0008_2001 = new(string, string)[1] { (_0008_0017._000E(-1141275455), _0008_0017._000E(-1141275518)) };

	internal static readonly (string, string)[] _0005_2001 = new(string, string)[1] { (_0008_0017._000E(-1141275542), _0008_0017._000E(-1141275608)) };

	internal static readonly (string, string)[] _000E_200B = new(string, string)[1] { (_0008_0017._000E(-1141275627), _0008_0017._000E(-1141274677)) };

	internal static readonly (string, string)[] _0003_200B = new(string, string)[2]
	{
		(_0008_0017._000E(-1141274704), _0008_0017._000E(-1141274749)),
		(_0008_0017._000E(-1141274781), _0008_0017._000E(-1141274820))
	};

	internal static readonly (string, string)[] _0006_200B = new(string, string)[3]
	{
		(_0008_0017._000E(-1141274844), _0008_0017._000E(-1141274897)),
		(_0008_0017._000E(-1141274936), _0008_0017._000E(-1141274961)),
		(_0008_0017._000E(-1141274990), _0008_0017._000E(-1141275016))
	};

	internal static readonly (string, string)[] _000F_200B = new(string, string)[1] { (_0008_0017._000E(-1141275030), _0008_0017._000E(-1141275058)) };

	internal static readonly (string, string)[] _0002_200B = new(string, string)[2]
	{
		(_0008_0017._000E(-1141275082), _0008_0017._000E(-1141275130)),
		(_0008_0017._000E(-1141276183), _0008_0017._000E(-1141276211))
	};

	internal static readonly (string, string)[] _0008_200B = new(string, string)[2]
	{
		(_0008_0017._000E(-1141276235), _0008_0017._000E(-1141276283)),
		(_0008_0017._000E(-1141276317), _0008_0017._000E(-1141276347))
	};

	internal static readonly (string, string)[] _0005_200B = new(string, string)[6]
	{
		(_0008_0017._000E(-1141276381), _0008_0017._000E(-1141276433)),
		(_0008_0017._000E(-1141276462), _0008_0017._000E(-1141276520)),
		(_0008_0017._000E(-1141276531), _0008_0017._000E(-1141276598)),
		(_0008_0017._000E(-1141276610), _0008_0017._000E(-1141275664)),
		(_0008_0017._000E(-1141275693), _0008_0017._000E(-1141275753)),
		(_0008_0017._000E(-1141275384), _0008_0017._000E(-1141275427))
	};

	internal static readonly (string, string)[] _000E_2004 = new(string, string)[4]
	{
		(_0008_0017._000E(-1141275780), _0008_0017._000E(-1141275843)),
		(_0008_0017._000E(-1141275878), _0008_0017._000E(-1141275937)),
		(_0008_0017._000E(-1141275974), _0008_0017._000E(-1141276035)),
		(_0008_0017._000E(-1141275384), _0008_0017._000E(-1141275427))
	};

	internal static readonly (string, string)[] _0003_2004 = new(string, string)[2]
	{
		(_0008_0017._000E(-1141276060), _0008_0017._000E(-1141276097)),
		(_0008_0017._000E(-1141276122), _0008_0017._000E(-1141273092))
	};

	internal static readonly (string, string)[] _0006_2004 = new(string, string)[8]
	{
		(_0008_0017._000E(-1141273121), _0008_0017._000E(-1141273169)),
		(_0008_0017._000E(-1141273194), _0008_0017._000E(-1141273264)),
		(_0008_0017._000E(-1141273287), _0008_0017._000E(-1141273349)),
		(_0008_0017._000E(-1141273364), _0008_0017._000E(-1141273434)),
		(_0008_0017._000E(-1141273465), _0008_0017._000E(-1141273536)),
		(_0008_0017._000E(-1141273557), _0008_0017._000E(-1141272584)),
		(_0008_0017._000E(-1141275384), _0008_0017._000E(-1141275427)),
		(_0008_0017._000E(-1141276317), _0008_0017._000E(-1141276347))
	};

	internal static readonly (string, string)[] _000F_2004 = new(string, string)[1] { (_0008_0017._000E(-1141272608), _0008_0017._000E(-1141272627)) };

	internal static readonly (string, string)[] _0002_2004 = new(string, string)[2]
	{
		(_0008_0017._000E(-1141272642), _0008_0017._000E(-1141272693)),
		(_0008_0017._000E(-1141272716), _0008_0017._000E(-1141272770))
	};

	internal static readonly (string, string)[] _0008_2004 = new(string, string)[7]
	{
		(_0008_0017._000E(-1141272798), _0008_0017._000E(-1141272831)),
		(_0008_0017._000E(-1141272844), _0008_0017._000E(-1141272901)),
		(_0008_0017._000E(-1141272927), _0008_0017._000E(-1141272970)),
		(_0008_0017._000E(-1141273007), _0008_0017._000E(-1141273043)),
		(_0008_0017._000E(-1141273068), _0008_0017._000E(-1141274158)),
		(_0008_0017._000E(-1141274178), _0008_0017._000E(-1141274228)),
		(_0008_0017._000E(-1141269836), _0008_0017._000E(-1141269895))
	};

	internal static bool _000E()
	{
		return global::_0008_200B.m__0008;
	}

	private static void _000E(bool _000E)
	{
		global::_0008_200B.m__0008 = _000E;
	}

	internal static string _000E()
	{
		return global::_0008_200B.m__0005;
	}

	private static void _000E(string _000E)
	{
		global::_0008_200B.m__0005 = _000E;
	}

	internal static int _000E()
	{
		return global::_0008_200B.m__000E_2008;
	}

	private static void _000E(int _000E)
	{
		global::_0008_200B.m__000E_2008 = _000E;
	}

	internal static int _0003()
	{
		return global::_0008_200B.m__0003_2008;
	}

	private static void _0003(int _000E)
	{
		global::_0008_200B.m__0003_2008 = _000E;
	}

	internal static int _0006()
	{
		return global::_0008_200B.m__0006_2008;
	}

	private static void _0006(int _000E)
	{
		global::_0008_200B.m__0006_2008 = _000E;
	}

	internal static int _000F()
	{
		return global::_0008_200B.m__000F_2008;
	}

	private static void _000F(int _000E)
	{
		global::_0008_200B.m__000F_2008 = _000E;
	}

	internal static string _0003()
	{
		return global::_0008_200B.m__0002_2008;
	}

	private static void _0003(string _000E)
	{
		global::_0008_200B.m__0002_2008 = _000E;
	}

	internal static IReadOnlyDictionary<string, int> _000E()
	{
		return global::_0008_200B.m__0005_2008;
	}

	internal static bool _000E(_0003_200B _000E, out string _0003)
	{
		if (_000E == null || _000E.MemoryPointers == null || _000E.MemoryPointers.Count == 0)
		{
			return global::_0008_200B._000E(out _0003, _0008_0017._000E(-1141274256));
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		foreach (_0003_2001 memoryPointer in _000E.MemoryPointers)
		{
			if (memoryPointer != null && !string.IsNullOrEmpty(memoryPointer.Key))
			{
				if (dictionary.ContainsKey(memoryPointer.Key))
				{
					return global::_0008_200B._000E(out _0003, _0008_0017._000E(-1141274299) + memoryPointer.Key);
				}
				dictionary[memoryPointer.Key] = memoryPointer.Value;
			}
		}
		if (!global::_0008_200B._000E(dictionary, global::_0008_200B._000E, out int num, out string text))
		{
			return global::_0008_200B._000E(out _0003, text);
		}
		if (!global::_0008_200B._000E(dictionary, global::_0008_200B._0003, out int num2, out text))
		{
			return global::_0008_200B._000E(out _0003, text);
		}
		if (!global::_0008_200B._000E(dictionary, global::_0008_200B._0006, out int num3, out text))
		{
			return global::_0008_200B._000E(out _0003, text);
		}
		if (!global::_0008_200B._000E(dictionary, global::_0008_200B._000F, out int num4, out text))
		{
			return global::_0008_200B._000E(out _0003, text);
		}
		if (!global::_0008_200B._0003(dictionary, global::_0008_200B._0002, out var text2, out text))
		{
			return global::_0008_200B._000E(out _0003, text);
		}
		global::_0008_200B._000E(num);
		global::_0008_200B._0003(num2);
		_0006(num3);
		_000F(num4);
		global::_0008_200B._0003(text2);
		global::_0008_200B._000E(_000E: true);
		global::_0008_200B._000E((string)null);
		_0003 = null;
		global::_0008_200B.m__0005_2008.Clear();
		if (global::_0008_200B._0008_2008)
		{
			global::_0008_200B._000E(dictionary);
		}
		else
		{
			global::_0008_200B._000E();
		}
		return true;
	}

	private static bool _000E(Dictionary<string, string> _000E, (string, string)[] _0003)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>(StringComparer.Ordinal);
		for (int i = 0; i < _0003.Length; i++)
		{
			(string, string) tuple = _0003[i];
			if (!_000E.TryGetValue(tuple.Item1, out var value) || !global::_0008_200B._000E(value, out var value2))
			{
				return false;
			}
			dictionary[tuple.Item2] = value2;
		}
		foreach (KeyValuePair<string, int> item in dictionary)
		{
			global::_0008_200B.m__0005_2008[item.Key] = item.Value;
		}
		return true;
	}

	private static bool _000E(Dictionary<string, string> _000E, string _0003, out string _0006, out string _000F)
	{
		if (!_000E.TryGetValue(_0003, out _0006))
		{
			_000F = _0003 + _0008_0017._000E(-1141274328);
			return false;
		}
		_000F = null;
		return true;
	}

	private static bool _000E(Dictionary<string, string> _000E, string _0003, out int _0006, out string _000F)
	{
		_0006 = 0;
		if (!global::_0008_200B._000E(_000E, _0003, out string text, out _000F))
		{
			return false;
		}
		if (!global::_0008_200B._000E(text, out _0006))
		{
			_000F = _0003 + _0008_0017._000E(-1141274356) + text + _0008_0017._000E(-1141298972);
			return false;
		}
		return true;
	}

	private static bool _0003(Dictionary<string, string> _000E, string _0003, out string _0006, out string _000F)
	{
		_0006 = null;
		if (!global::_0008_200B._000E(_000E, _0003, out string text, out _000F))
		{
			return false;
		}
		if (string.IsNullOrEmpty(text))
		{
			_000F = _0003 + _0008_0017._000E(-1141274397);
			return false;
		}
		_0006 = text;
		return true;
	}

	private static bool _000E(string _000E, out int _0003)
	{
		_0003 = 0;
		if (string.IsNullOrEmpty(_000E))
		{
			return false;
		}
		if (_000E.StartsWith(_0008_0017._000E(-1141274413), StringComparison.OrdinalIgnoreCase))
		{
			return int.TryParse(_000E.Substring(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out _0003);
		}
		return int.TryParse(_000E, NumberStyles.Integer, CultureInfo.InvariantCulture, out _0003);
	}

	private static bool _000E(out string _000E, string _0003)
	{
		global::_0008_200B._000E(_000E: false);
		global::_0008_200B._000E();
		global::_0008_200B.m__0005_2008.Clear();
		global::_0008_200B._000E(_0003);
		_000E = _0003;
		return false;
	}

	internal static bool _0003()
	{
		return global::_0008_200B.m__000E_2007;
	}

	private static void _0003(bool _000E)
	{
		global::_0008_200B.m__000E_2007 = _000E;
	}

	internal static bool _0006()
	{
		return global::_0008_200B.m__0003_2007;
	}

	private static void _0006(bool _000E)
	{
		global::_0008_200B.m__0003_2007 = _000E;
	}

	internal static bool _000F()
	{
		return global::_0008_200B.m__0006_2007;
	}

	private static void _000F(bool _000E)
	{
		global::_0008_200B.m__0006_2007 = _000E;
	}

	internal static bool _0002()
	{
		return global::_0008_200B.m__000F_2007;
	}

	private static void _0002(bool _000E)
	{
		global::_0008_200B.m__000F_2007 = _000E;
	}

	internal static bool _0008()
	{
		return global::_0008_200B.m__0002_2007;
	}

	private static void _0008(bool _000E)
	{
		global::_0008_200B.m__0002_2007 = _000E;
	}

	internal static bool _0005()
	{
		return global::_0008_200B.m__0008_2007;
	}

	private static void _0005(bool _000E)
	{
		global::_0008_200B.m__0008_2007 = _000E;
	}

	internal static bool _000E_2008()
	{
		return global::_0008_200B.m__0005_2007;
	}

	private static void _000E_2008(bool _000E)
	{
		global::_0008_200B.m__0005_2007 = _000E;
	}

	internal static bool _0003_2008()
	{
		return global::_0008_200B.m__000E_2002;
	}

	private static void _0003_2008(bool _000E)
	{
		global::_0008_200B.m__000E_2002 = _000E;
	}

	internal static bool _0006_2008()
	{
		return global::_0008_200B.m__0003_2002;
	}

	private static void _0006_2008(bool _000E)
	{
		global::_0008_200B.m__0003_2002 = _000E;
	}

	internal static bool _000F_2008()
	{
		return global::_0008_200B.m__0006_2002;
	}

	private static void _000F_2008(bool _000E)
	{
		global::_0008_200B.m__0006_2002 = _000E;
	}

	internal static bool _0002_2008()
	{
		return global::_0008_200B.m__000F_2002;
	}

	private static void _0002_2008(bool _000E)
	{
		global::_0008_200B.m__000F_2002 = _000E;
	}

	internal static bool _0008_2008()
	{
		return _0002_2002;
	}

	private static void _0008_2008(bool _000E)
	{
		_0002_2002 = _000E;
	}

	internal static bool _0005_2008()
	{
		return _0008_2002;
	}

	private static void _0005_2008(bool _000E)
	{
		_0008_2002 = _000E;
	}

	internal static bool _000E_2007()
	{
		return _0005_2002;
	}

	private static void _000E_2007(bool _000E)
	{
		_0005_2002 = _000E;
	}

	internal static bool _0003_2007()
	{
		return _000E_2006;
	}

	private static void _0003_2007(bool _000E)
	{
		_000E_2006 = _000E;
	}

	internal static bool _0006_2007()
	{
		return _0003_2006;
	}

	private static void _0006_2007(bool _000E)
	{
		_0003_2006 = _000E;
	}

	internal static bool _000F_2007()
	{
		return _0006_2006;
	}

	private static void _000F_2007(bool _000E)
	{
		_0006_2006 = _000E;
	}

	internal static bool _0002_2007()
	{
		return _000F_2006;
	}

	private static void _0002_2007(bool _000E)
	{
		_000F_2006 = _000E;
	}

	internal static bool _0008_2007()
	{
		return _0002_2006;
	}

	private static void _0008_2007(bool _000E)
	{
		_0002_2006 = _000E;
	}

	internal static bool _0005_2007()
	{
		return _0008_2006;
	}

	private static void _0005_2007(bool _000E)
	{
		_0008_2006 = _000E;
	}

	internal static bool _000E_2002()
	{
		return _0005_2006;
	}

	private static void _000E_2002(bool _000E)
	{
		_0005_2006 = _000E;
	}

	internal static bool _0003_2002()
	{
		return _000E_2003;
	}

	private static void _0003_2002(bool _000E)
	{
		_000E_2003 = _000E;
	}

	internal static bool _0006_2002()
	{
		return _0003_2003;
	}

	private static void _0006_2002(bool _000E)
	{
		_0003_2003 = _000E;
	}

	internal static bool _000F_2002()
	{
		return _0006_2003;
	}

	private static void _000F_2002(bool _000E)
	{
		_0006_2003 = _000E;
	}

	private static void _000E(Dictionary<string, string> _000E)
	{
		_0003(global::_0008_200B._000E(_000E, _000F_2003));
		_0006(global::_0008_200B._000E(_000E, _0002_2003));
		_000F(global::_0008_200B._000E(_000E, _0008_2003));
		_0002(global::_0008_200B._000E(_000E, _0005_2003));
		_0008(global::_0008_200B._0003() && global::_0008_200B._000E(_000E, _000E_2001));
		_0005(global::_0008_200B._000E(_000E, _0003_2001));
		_000E_2008(global::_0008_200B._000E(_000E, _0006_2001));
		_0003_2008(global::_0008_200B._000E(_000E, _000F_2001));
		_0006_2008(global::_0008_200B._000E(_000E, _0002_2001));
		_000F_2008(global::_0008_200B._000E(_000E, _0008_2001));
		_0002_2008(global::_0008_200B._000E(_000E, _0005_2001));
		_0008_2008(global::_0008_200B._000E(_000E, _000E_200B));
		_0005_2008(global::_0008_200B._000E(_000E, _0003_200B));
		_000E_2007(global::_0008_200B._000E(_000E, _0006_200B));
		_0003_2007(global::_0008_200B._000E(_000E, _000F_200B));
		_0006_2007(global::_0008_200B._000E(_000E, _0002_200B));
		_000F_2007(global::_0008_200B._000E(_000E, _0008_200B));
		_0002_2007(global::_0008_200B._000E(_000E, _0005_200B));
		_0008_2007(global::_0008_200B._000E(_000E, _000E_2004));
		_0005_2007(global::_0008_200B._000E(_000E, _0003_2004));
		_000E_2002(global::_0008_200B._000E(_000E, _0006_2004));
		_0003_2002(global::_0008_200B._000E(_000E, _000F_2004));
		_0006_2002(global::_0008_200B._000E(_000E, _0002_2004));
		_000F_2002(global::_0008_200B._000E(_000E, _0008_2004));
	}

	private static void _000E()
	{
		_0003(_000E: false);
		_0006(_000E: false);
		_000F(_000E: false);
		_0002(_000E: false);
		_0008(_000E: false);
		_0005(_000E: false);
		_000E_2008(_000E: false);
		_0003_2008(_000E: false);
		_0006_2008(_000E: false);
		_000F_2008(_000E: false);
		_0002_2008(_000E: false);
		_0008_2008(_000E: false);
		_0005_2008(_000E: false);
		_000E_2007(_000E: false);
		_0003_2007(_000E: false);
		_0006_2007(_000E: false);
		_000F_2007(_000E: false);
		_0002_2007(_000E: false);
		_0008_2007(_000E: false);
		_0005_2007(_000E: false);
		_000E_2002(_000E: false);
		_0003_2002(_000E: false);
		_0006_2002(_000E: false);
		_000F_2002(_000E: false);
	}
}
internal sealed class _0008_200B_200A
{
	private static readonly Stopwatch m__000E = Stopwatch.StartNew();

	public long _0003;

	public _0002_200B_200A[] _0006;

	internal static long _000E()
	{
		return _0008_200B_200A.m__000E.ElapsedMilliseconds;
	}
}
internal static class _000E_0017
{
	private sealed class _0002 : IEquatable<_0002>
	{
		internal uint _000E;

		internal byte _0003;

		internal ushort _0006;

		internal ushort _000F;

		internal byte _0002;

		internal byte _0008;

		internal static _0002 _000E(_000E_2008_200A _000E)
		{
			return new _0002
			{
				_000E = _000E._000E_2008,
				_0003 = _000E._000E,
				_0006 = _000E._0006,
				_000F = _000E._000F,
				_0002 = _000E._000E(),
				_0008 = _000E._0003()
			};
		}

		public bool Equals(_0002 _000E)
		{
			if (_000E != null && this._000E == _000E._000E && _0003 == _000E._0003 && _0006 == _000E._0006 && _000F == _000E._000F && _0002 == _000E._0002)
			{
				return _0008 == _000E._0008;
			}
			return false;
		}

		public override bool Equals(object _000E)
		{
			return Equals(_000E as _0002);
		}

		public override int GetHashCode()
		{
			return (int)((((((((((this._000E * 397) ^ _0003) * 397) ^ _0006) * 397) ^ _000F) * 397) ^ _0002) * 397) ^ _0008);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _0003 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<_0006> _0003;

		public _0006_2006 _0006;

		public float _000F;

		public float _0002;

		public float _0008;

		public string _0005;

		public _0002 _000E_2008;

		public string _0003_2008;

		public int _0006_2008;

		public _0006_2007_200B _000F_2008;

		public _000E_2006_200B _0002_2008;

		public float _0008_2008;

		public int _0005_2008;

		public bool _000E_2007;

		public bool _0003_2007;

		public bool _0006_2007;

		public int _000F_2007;

		public IReadOnlyList<string> _0002_2007;

		private long _0008_2007;

		private int _0005_2007;

		private TaskAwaiter _000E_2002;

		private void MoveNext()
		{
			int num = _000E;
			_0006 result;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _000E_2002;
					_000E_2002 = default(TaskAwaiter);
					num = (_000E = -1);
					goto IL_01fd;
				}
				_0006_0018 obj = _0006._000E();
				if (!_000E(obj))
				{
					result = _000E_0017._0006.SessionChanged;
				}
				else
				{
					if (obj._000E(_000F, _0002, _0008, _000F: true, _0005))
					{
						_000E(_000E_2008, _0003_2008 + _0008_0017._000E(-1141038098), _0006_2008, (_0006_2008 > 0) ? 5 : 0);
						_0008_2007 = _000F_2008._0002();
						_0005_2007 = 0;
						goto IL_0204;
					}
					result = _000E_0017._0006.PostFailed;
				}
				goto end_IL_0007;
				IL_0204:
				if (!_0006._0006())
				{
					float num2;
					float num3;
					float num4;
					byte b;
					byte b2;
					string text;
					float num5;
					float num6;
					float num7;
					if (!_000E(_0006._000E()))
					{
						result = _000E_0017._0006.SessionChanged;
					}
					else if (!_000E(_0006, _000E_2008, _0002_2008, _0008_2008, _0005_2008, _000E_2007, _0003_2007, _0006_2007, _000F_2007, _0002_2007, out num2, out num3, out num4, out b, out b2, out text))
					{
						result = _000E_0017._0006.TargetUnavailable;
					}
					else if (!_000E(_0006, out num5, out num6, out num7))
					{
						result = _000E_0017._0006.TargetUnavailable;
					}
					else if (_000E(num5, num7, _000F, _0008) <= 0.25f)
					{
						result = _000E_0017._0006.Arrived;
					}
					else
					{
						if (_0005_2007 < 100 && !(_000E(_0008_2007, _000F_2008._0002(), _000F_2008._0008) >= 10000.0))
						{
							_0005_2007++;
							awaiter = _000F_2008._000E(100).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_000E = 0);
								_000E_2002 = awaiter;
								_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01fd;
						}
						result = _000E_0017._0006.TimedOut;
					}
				}
				else
				{
					result = _000E_0017._0006.Interrupted;
				}
				goto end_IL_0007;
				IL_01fd:
				awaiter.GetResult();
				goto IL_0204;
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

	private enum _0006
	{
		Arrived,
		PostFailed,
		TargetUnavailable,
		SessionChanged,
		TimedOut,
		Interrupted
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _000E : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0006_2006 _0006;

		public float _000F;

		private _000E_2006_200B _0002;

		private int _0008;

		private int _0005;

		private bool _000E_2008;

		private bool _0003_2008;

		private bool _0006_2008;

		private IReadOnlyList<string> _000F_2008;

		private _0006_2007_200B _0002_2008;

		private long _0008_2008;

		private _0002 _0005_2008;

		private TaskAwaiter<int> _000E_2007;

		private TaskAwaiter<List<int>> _0003_2007;

		private TaskAwaiter<bool> _0006_2007;

		private TaskAwaiter<IReadOnlyList<string>> _000F_2007;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _0002_2007;

		private int _0008_2007;

		private TaskAwaiter<_0006> _0005_2007;

		private void MoveNext()
		{
			int num = _000E;
			bool result2;
			try
			{
				TaskAwaiter<List<int>> awaiter6;
				TaskAwaiter<int> awaiter5;
				TaskAwaiter<bool> awaiter4;
				TaskAwaiter<IReadOnlyList<string>> awaiter3;
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter2;
				TaskAwaiter<_0006> awaiter;
				IReadOnlyList<string> result;
				_0006_0018 obj;
				long num2;
				int result3;
				float num3;
				float num4;
				float num5;
				byte b;
				byte b2;
				string text;
				float num6;
				float num7;
				float num8;
				int result4;
				_0006 result5;
				float num11;
				List<int> result6;
				bool result7;
				_0006 result8;
				switch (num)
				{
				default:
					awaiter5 = _000E_2000_200A._000E(_0006, new int[6] { 1, 2, 3, 4, 5, 26 }).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						num = (_000E = 0);
						_000E_2007 = awaiter5;
						_0003.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
						return;
					}
					goto IL_00a2;
				case 0:
					awaiter5 = _000E_2007;
					_000E_2007 = default(TaskAwaiter<int>);
					num = (_000E = -1);
					goto IL_00a2;
				case 1:
					awaiter6 = _0003_2007;
					_0003_2007 = default(TaskAwaiter<List<int>>);
					num = (_000E = -1);
					goto IL_0139;
				case 2:
					awaiter5 = _000E_2007;
					_000E_2007 = default(TaskAwaiter<int>);
					num = (_000E = -1);
					goto IL_0244;
				case 3:
					awaiter4 = _0006_2007;
					_0006_2007 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_02b0;
				case 4:
					awaiter4 = _0006_2007;
					_0006_2007 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_031c;
				case 5:
					awaiter4 = _0006_2007;
					_0006_2007 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0388;
				case 6:
					awaiter3 = _000F_2007;
					_000F_2007 = default(TaskAwaiter<IReadOnlyList<string>>);
					num = (_000E = -1);
					goto IL_03f5;
				case 7:
					awaiter2 = _0002_2007;
					_0002_2007 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = (_000E = -1);
					goto IL_069c;
				case 8:
					awaiter = _0005_2007;
					_0005_2007 = default(TaskAwaiter<_0006>);
					num = (_000E = -1);
					goto IL_07d2;
				case 9:
					{
						awaiter = _0005_2007;
						_0005_2007 = default(TaskAwaiter<_0006>);
						num = (_000E = -1);
						goto IL_09d3;
					}
					IL_03f5:
					result = awaiter3.GetResult();
					_000F_2008 = result;
					obj = _0006._000E();
					num2 = obj?._0003() ?? 0;
					if (obj != _000E_0017._0002_2008 || num2 != _000E_0017._0008_2008)
					{
						_000E(_000E: true);
						_000E_0017._0002_2008 = obj;
						_000E_0017._0008_2008 = num2;
					}
					if (obj == null)
					{
						result2 = false;
					}
					else
					{
						_0002_2008 = _0006_2007_200B._000E();
						if (!_0002_2008._000E(obj))
						{
							_000E();
							result2 = false;
						}
						else
						{
							_0008_2008 = _0002_2008._0002();
							_000E(_0008_2008);
							if (_000E_0017.m__0003 && _000E_0017._000F_2008 != null && _000E(_0006, _000E_0017.m__000E, _0002, _000F, _0005, _000E_2008, _0003_2008, _0006_2008, _0008, _000F_2008))
							{
								_0005_2008 = _000E_0017.m__000E;
								goto IL_0544;
							}
							if (_000E(_0006, _0002, _000F, _0005, _000E_2008, _0003_2008, _0006_2008, _0008, _000F_2008, out _0005_2008))
							{
								goto IL_0544;
							}
							_000E();
							result2 = false;
						}
					}
					goto end_IL_0007;
					IL_00a2:
					result3 = awaiter5.GetResult();
					_0002 = _000F_2000_200A._000E();
					if ((result3 != 4 && result3 != 5) || _0002._0003)
					{
						awaiter6 = _0005_2009_200A._000E(_0006, 29, 33).GetAwaiter();
						if (!awaiter6.IsCompleted)
						{
							num = (_000E = 1);
							_0003_2007 = awaiter6;
							_0003.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
							return;
						}
						goto IL_0139;
					}
					_000E();
					result2 = false;
					goto end_IL_0007;
					IL_0870:
					if (_000E(_0006, _0005_2008, _0002, _000F, _0005, _000E_2008, _0003_2008, _0006_2008, _0008, _000F_2008, out num3, out num4, out num5, out b, out b2, out text) && _000E(_0006, out num6, out num7, out num8))
					{
						_0008_2007 = _000E_0017.m__000F - 5 + 1;
						_000E(_0002_2008, _0008_2007, num3, num5, num6, num8, out var num9, out var num10);
						awaiter = _000E(_0006, _0005_2008, num9, num4, num10, _0008_0017._000E(-1141039008) + _0008_2007, _0008_0017._000E(-1141039018), _0008_2007, _0002, _000F, _0005, _000E_2008, _0003_2008, _0006_2008, _0008, _000F_2008, _0002_2008).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_000E = 9);
							_0005_2007 = awaiter;
							_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_09d3;
					}
					_000E();
					result2 = true;
					goto end_IL_0007;
					IL_069c:
					awaiter2.GetResult();
					goto IL_06a3;
					IL_0244:
					result4 = awaiter5.GetResult();
					_0005 = result4;
					awaiter4 = _000E_2000_200A._000E(_0006, 94).GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = (_000E = 3);
						_0006_2007 = awaiter4;
						_0003.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
						return;
					}
					goto IL_02b0;
					IL_09d3:
					result5 = awaiter.GetResult();
					if (result5 != _000E_0017._0006.Arrived)
					{
						_000E(_0005_2008, _0008_0017._000E(-1141039046) + _0008_2007, result5, _0008_2007);
						if (result5 == _000E_0017._0006.TimedOut)
						{
							_000E(_0005_2008, _0002_2008._0002(), _0002_2008._0008);
							_000E(_0005_2008, _0008_0017._000E(-1141038927), 60, 0);
						}
						if (result5 == _000E_0017._0006.SessionChanged)
						{
							_000E(_000E: true);
						}
						else
						{
							_000E();
						}
						result2 = true;
					}
					else
					{
						_000E(_0005_2008, _0008_0017._000E(-1141039059), _0008_2007, 5);
						if (_000E(_0006, _0005_2008, _0002, _000F, _0005, _000E_2008, _0003_2008, _0006_2008, _0008, _000F_2008, out num3, out num4, out num5, out b, out b2, out text))
						{
							num11 = 0f;
							break;
						}
						_000E();
						result2 = true;
					}
					goto end_IL_0007;
					IL_0615:
					if (!_000E_0017.m__0006 && _000F_2000_200A._000E())
					{
						_0006_0018 obj2 = _0006._000E();
						if (obj2 != null)
						{
							awaiter2 = obj2._000E().ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_000E = 7);
								_0002_2007 = awaiter2;
								_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_069c;
						}
						goto IL_06a3;
					}
					goto IL_06ae;
					IL_0139:
					result6 = awaiter6.GetResult();
					_0008 = 0;
					if (result6.Contains(29))
					{
						_0008 |= _000E(1);
					}
					if (result6.Contains(30))
					{
						_0008 |= _000E(2);
					}
					if (result6.Contains(31))
					{
						_0008 |= _000E(3);
					}
					if (result6.Contains(32))
					{
						_0008 |= _000E(4);
					}
					if (result6.Contains(33))
					{
						_0008 |= _000E(6);
					}
					awaiter5 = _000E_2000_200A._000E(_0006, new int[5] { 18, 19, 20, 21, 22 }).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						num = (_000E = 2);
						_000E_2007 = awaiter5;
						_0003.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
						return;
					}
					goto IL_0244;
					IL_06a3:
					_000F_2000_200A._0003();
					_000E_0017.m__0006 = true;
					goto IL_06ae;
					IL_02b0:
					result7 = awaiter4.GetResult();
					_000E_2008 = result7;
					awaiter4 = _000E_2000_200A._000E(_0006, 38).GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = (_000E = 4);
						_0006_2007 = awaiter4;
						_0003.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
						return;
					}
					goto IL_031c;
					IL_06ae:
					_0002_2008._000E();
					if (!_000E(_0006, out num6, out num7, out num8) || !_000E(_0006, _0005_2008, out num3, out num4, out num5, out b, out b2, out text))
					{
						_000E();
						result2 = false;
					}
					else
					{
						num11 = _000E_200A_200A._000E(num6, num7, num8, num3, num4, num5);
						if (_000E_0017.m__000F >= 5)
						{
							if (!_000E_0017.m__0002)
							{
								awaiter = _000E(_0006, _0005_2008, num3, num4, num5, _0008_0017._000E(-1141038943), _0008_0017._000E(-1141038966), 0, _0002, _000F, _0005, _000E_2008, _0003_2008, _0006_2008, _0008, _000F_2008, _0002_2008).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = (_000E = 8);
									_0005_2007 = awaiter;
									_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_07d2;
							}
							goto IL_0870;
						}
						if (!(num11 > 10f))
						{
							break;
						}
						_0006_0018 obj3 = _0006._000E();
						if (!_000E(obj3))
						{
							_000E(_000E: true);
							result2 = false;
						}
						else
						{
							_000E(_0006, _0005_2008, num11, _0008_0017._000E(-1141254478));
							if (!obj3._000E(num3, num4, num5, _000F: true, _0008_0017._000E(-1141308140)))
							{
								_000E();
								result2 = false;
							}
							else
							{
								result2 = true;
							}
						}
					}
					goto end_IL_0007;
					IL_031c:
					result7 = awaiter4.GetResult();
					_0003_2008 = result7;
					awaiter4 = _000E_2000_200A._000E(_0006, 43).GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = (_000E = 5);
						_0006_2007 = awaiter4;
						_0003.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
						return;
					}
					goto IL_0388;
					IL_0544:
					_000E(_0005_2008);
					if (!_000E(_0006, _0005_2008, obj, _0008_2008, _0002_2008._0008))
					{
						result2 = true;
					}
					else
					{
						if (_000E_0017.m__000F < 10)
						{
							goto IL_0615;
						}
						_000E(_0005_2008, _0008_2008, _0002_2008._0008);
						_000E(_0005_2008, _0008_0017._000E(-1141038927), 60, 0);
						_000E();
						if (_000E(_0006, _0002, _000F, _0005, _000E_2008, _0003_2008, _0006_2008, _0008, _000F_2008, out _0005_2008))
						{
							_000E(_0005_2008);
							goto IL_0615;
						}
						result2 = false;
					}
					goto end_IL_0007;
					IL_0388:
					result7 = awaiter4.GetResult();
					_0006_2008 = result7;
					awaiter3 = _000E_2000_200A._0003(_0006).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_000E = 6);
						_000F_2007 = awaiter3;
						_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_03f5;
					IL_07d2:
					result8 = awaiter.GetResult();
					if (result8 == _000E_0017._0006.Arrived)
					{
						_000E_0017.m__0002 = true;
						_000E(_0005_2008, _0008_0017._000E(-1141038983), 0, 0);
						goto IL_0870;
					}
					_000E(_0005_2008, _0008_0017._000E(-1141038966), result8, 0);
					if (result8 == _000E_0017._0006.TimedOut)
					{
						_000E(_0005_2008, _0002_2008._0002(), _0002_2008._0008);
						_000E(_0005_2008, _0008_0017._000E(-1141038927), 60, 0);
					}
					if (result8 == _000E_0017._0006.SessionChanged)
					{
						_000E(_000E: true);
					}
					else
					{
						_000E();
					}
					result2 = true;
					goto end_IL_0007;
				}
				if (_000E_0017.m__000F < 5 && _000E_0017._0006_2008 && _000E(_000E_0017._0003_2008, _0008_2008, _0002_2008._0008) < 400.0)
				{
					_000E(_0006, _0005_2008, num11, _0008_0017._000E(-1141039095));
					result2 = true;
				}
				else
				{
					_0006_0018 obj4 = _0006._000E();
					if (!_000E(obj4))
					{
						_000E(_000E: true);
						result2 = false;
					}
					else
					{
						int num12 = (_000E_0017.m__0002 ? (_000E_0017.m__000F - 5 + 1) : (_000E_0017.m__000F + 1));
						string text2 = (_000E_0017.m__0002 ? _0008_0017._000E(-1141038086) : _0008_0017._000E(-1141259041));
						if (_000E_0017.m__0002)
						{
							_000E(_0005_2008, _0008_0017._000E(-1141038086), num12, 5);
						}
						_000E(_0006, _0005_2008, num11, text2 + _0008_0017._000E(-1141293701) + num12 + _0008_0017._000E(-1141300031) + 5);
						uint num13 = obj4._0003();
						_000F obj5 = (_000E_0017._000F_2008 = new _000F
						{
							_000E = _0005_2008,
							_0003 = b,
							_0006 = num13,
							_000F = obj4._000E()
						});
						if (!obj4._000E(b, _0005_2008._000E, num13))
						{
							_000E();
							result2 = false;
						}
						else
						{
							long num14 = (obj5._0008 = _0002_2008._0002());
							obj5._0002 = _0006._000E()._0002_2008();
							Volatile.Write(ref obj5._0005, 1);
							_000E_0017._0003_2008 = num14;
							_000E_0017._0006_2008 = true;
							result2 = true;
						}
					}
				}
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				_000E = -2;
				_0002 = null;
				_000F_2008 = null;
				_0002_2008 = null;
				_0005_2008 = null;
				_0003.SetException(exception);
				return;
			}
			_000E = -2;
			_0002 = null;
			_000F_2008 = null;
			_0002_2008 = null;
			_0005_2008 = null;
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

	private sealed class _000F
	{
		internal _0002 _000E;

		internal byte _0003;

		internal uint _0006;

		internal long _000F;

		internal int _0002;

		internal long _0008;

		internal int _0005;

		internal bool _000E_2008;
	}

	private static _0002 m__000E;

	private static bool m__0003;

	private static bool m__0006;

	private static int m__000F;

	private static bool m__0002;

	private static bool _0008;

	private static float _0005;

	private static float _000E_2008;

	private static long _0003_2008;

	private static bool _0006_2008;

	private static _000F _000F_2008;

	private static _0006_0018 _0002_2008;

	private static long _0008_2008;

	private static readonly Dictionary<_0002, long> _0005_2008 = new Dictionary<_0002, long>();

	private static readonly _0006_2008_200A._000E _000E_2007 = new _0006_2008_200A._000E();

	internal static int _000E(byte _000E)
	{
		if (_000E > 15)
		{
			return 0;
		}
		return 1 << (int)_000E;
	}

	internal static async Task<bool> _000E(_0006_2006 _000E, float _0003)
	{
		int num = await _000E_2000_200A._000E(_000E, new int[6] { 1, 2, 3, 4, 5, 26 });
		_000E_2006_200B obj = _000F_2000_200A._000E();
		if ((num == 4 || num == 5) && !obj._0003)
		{
			_000E_0017._000E();
			return false;
		}
		List<int> obj2 = await _0005_2009_200A._000E(_000E, 29, 33);
		int num2 = 0;
		if (obj2.Contains(29))
		{
			num2 |= _000E_0017._000E(1);
		}
		if (obj2.Contains(30))
		{
			num2 |= _000E_0017._000E(2);
		}
		if (obj2.Contains(31))
		{
			num2 |= _000E_0017._000E(3);
		}
		if (obj2.Contains(32))
		{
			num2 |= _000E_0017._000E(4);
		}
		if (obj2.Contains(33))
		{
			num2 |= _000E_0017._000E(6);
		}
		int num3 = await _000E_2000_200A._000E(_000E, new int[5] { 18, 19, 20, 21, 22 });
		bool flag = await _000E_2000_200A._000E(_000E, 94);
		bool flag2 = await _000E_2000_200A._000E(_000E, 38);
		bool flag3 = await _000E_2000_200A._000E(_000E, 43);
		IReadOnlyList<string> readOnlyList = await _000E_2000_200A._0003(_000E);
		_0006_0018 obj3 = _000E._000E();
		long num4 = obj3?._0003() ?? 0;
		if (obj3 != _0002_2008 || num4 != _0008_2008)
		{
			_000E_0017._000E(_000E: true);
			_0002_2008 = obj3;
			_0008_2008 = num4;
		}
		if (obj3 == null)
		{
			return false;
		}
		_0006_2007_200B obj4 = _0006_2007_200B._000E();
		if (!obj4._000E(obj3))
		{
			_000E_0017._000E();
			return false;
		}
		long num5 = obj4._0002();
		_000E_0017._000E(num5);
		_0002 obj5;
		if (_000E_0017.m__0003 && _000F_2008 != null && _000E_0017._000E(_000E, _000E_0017.m__000E, obj, _0003, num3, flag, flag2, flag3, num2, readOnlyList))
		{
			obj5 = _000E_0017.m__000E;
		}
		else if (!_000E_0017._000E(_000E, obj, _0003, num3, flag, flag2, flag3, num2, readOnlyList, out obj5))
		{
			_000E_0017._000E();
			return false;
		}
		_000E_0017._000E(obj5);
		if (!_000E_0017._000E(_000E, obj5, obj3, num5, obj4._0008))
		{
			return true;
		}
		if (_000E_0017.m__000F >= 10)
		{
			_000E_0017._000E(obj5, num5, obj4._0008);
			_000E_0017._000E(obj5, _0008_0017._000E(-1141038927), 60, 0);
			_000E_0017._000E();
			if (!_000E_0017._000E(_000E, obj, _0003, num3, flag, flag2, flag3, num2, readOnlyList, out obj5))
			{
				return false;
			}
			_000E_0017._000E(obj5);
		}
		if (!_000E_0017.m__0006 && _000F_2000_200A._000E())
		{
			_0006_0018 obj6 = _000E._000E();
			if (obj6 != null)
			{
				await obj6._000E().ConfigureAwait(continueOnCapturedContext: false);
			}
			_000F_2000_200A._0003();
			_000E_0017.m__0006 = true;
		}
		obj4._000E();
		if (!_000E_0017._000E(_000E, out var num6, out var num7, out var num8) || !_000E_0017._000E(_000E, obj5, out var num9, out var num10, out var num11, out var b, out var b2, out var text))
		{
			_000E_0017._000E();
			return false;
		}
		float num12 = _000E_200A_200A._000E(num6, num7, num8, num9, num10, num11);
		if (_000E_0017.m__000F >= 5)
		{
			if (!_000E_0017.m__0002)
			{
				_0006 obj7 = await _000E_0017._000E(_000E, obj5, num9, num10, num11, _0008_0017._000E(-1141038943), _0008_0017._000E(-1141038966), 0, obj, _0003, num3, flag, flag2, flag3, num2, readOnlyList, obj4);
				if (obj7 != _000E_0017._0006.Arrived)
				{
					_000E_0017._000E(obj5, _0008_0017._000E(-1141038966), obj7, 0);
					if (obj7 == _000E_0017._0006.TimedOut)
					{
						_000E_0017._000E(obj5, obj4._0002(), obj4._0008);
						_000E_0017._000E(obj5, _0008_0017._000E(-1141038927), 60, 0);
					}
					if (obj7 == _000E_0017._0006.SessionChanged)
					{
						_000E_0017._000E(_000E: true);
					}
					else
					{
						_000E_0017._000E();
					}
					return true;
				}
				_000E_0017.m__0002 = true;
				_000E_0017._000E(obj5, _0008_0017._000E(-1141038983), 0, 0);
			}
			if (!_000E_0017._000E(_000E, obj5, obj, _0003, num3, flag, flag2, flag3, num2, readOnlyList, out num9, out num10, out num11, out b, out b2, out text) || !_000E_0017._000E(_000E, out num6, out num7, out num8))
			{
				_000E_0017._000E();
				return true;
			}
			int num13 = _000E_0017.m__000F - 5 + 1;
			_000E_0017._000E(obj4, num13, num9, num11, num6, num8, out var num14, out var num15);
			_0006 obj8 = await _000E_0017._000E(_000E, obj5, num14, num10, num15, _0008_0017._000E(-1141039008) + num13, _0008_0017._000E(-1141039018), num13, obj, _0003, num3, flag, flag2, flag3, num2, readOnlyList, obj4);
			if (obj8 != _000E_0017._0006.Arrived)
			{
				_000E_0017._000E(obj5, _0008_0017._000E(-1141039046) + num13, obj8, num13);
				if (obj8 == _000E_0017._0006.TimedOut)
				{
					_000E_0017._000E(obj5, obj4._0002(), obj4._0008);
					_000E_0017._000E(obj5, _0008_0017._000E(-1141038927), 60, 0);
				}
				if (obj8 == _000E_0017._0006.SessionChanged)
				{
					_000E_0017._000E(_000E: true);
				}
				else
				{
					_000E_0017._000E();
				}
				return true;
			}
			_000E_0017._000E(obj5, _0008_0017._000E(-1141039059), num13, 5);
			if (!_000E_0017._000E(_000E, obj5, obj, _0003, num3, flag, flag2, flag3, num2, readOnlyList, out num9, out num10, out num11, out b, out b2, out text))
			{
				_000E_0017._000E();
				return true;
			}
			num12 = 0f;
		}
		else if (num12 > 10f)
		{
			_0006_0018 obj9 = _000E._000E();
			if (!_000E_0017._000E(obj9))
			{
				_000E_0017._000E(_000E: true);
				return false;
			}
			_000E_0017._000E(_000E, obj5, num12, _0008_0017._000E(-1141254478));
			if (!obj9._000E(num9, num10, num11, _000F: true, _0008_0017._000E(-1141308140)))
			{
				_000E_0017._000E();
				return false;
			}
			return true;
		}
		if (_000E_0017.m__000F < 5 && _0006_2008 && _000E_0017._000E(_0003_2008, num5, obj4._0008) < 400.0)
		{
			_000E_0017._000E(_000E, obj5, num12, _0008_0017._000E(-1141039095));
			return true;
		}
		_0006_0018 obj10 = _000E._000E();
		if (!_000E_0017._000E(obj10))
		{
			_000E_0017._000E(_000E: true);
			return false;
		}
		int num16 = (_000E_0017.m__0002 ? (_000E_0017.m__000F - 5 + 1) : (_000E_0017.m__000F + 1));
		string text2 = (_000E_0017.m__0002 ? _0008_0017._000E(-1141038086) : _0008_0017._000E(-1141259041));
		if (_000E_0017.m__0002)
		{
			_000E_0017._000E(obj5, _0008_0017._000E(-1141038086), num16, 5);
		}
		_000E_0017._000E(_000E, obj5, num12, text2 + _0008_0017._000E(-1141293701) + num16 + _0008_0017._000E(-1141300031) + 5);
		uint num17 = obj10._0003();
		_000F obj11 = (_000F_2008 = new _000F
		{
			_000E = obj5,
			_0003 = b,
			_0006 = num17,
			_000F = obj10._000E()
		});
		if (!obj10._000E(b, obj5._000E, num17))
		{
			_000E_0017._000E();
			return false;
		}
		long num18 = (obj11._0008 = obj4._0002());
		obj11._0002 = _000E._000E()._0002_2008();
		Volatile.Write(ref obj11._0005, 1);
		_0003_2008 = num18;
		_0006_2008 = true;
		return true;
	}

	private static bool _000E(_0006_2006 _000E, _000E_2006_200B _0003, float _0006, int _000F, bool _0002, bool _0008, bool _0005, int _000E_2008, IReadOnlyList<string> _0003_2008, out _0002 _0006_2008)
	{
		_0006_2008 = null;
		if (_000F == 22 || _000F < 0 || !_000E_0017._000E(_000E, out var num, out var num2, out var num3, out var b))
		{
			return false;
		}
		float num4 = (_0003._0003 ? _0003._0006 : num);
		float num5 = (_0003._0003 ? _0003._000F : num2);
		float num6 = (_0003._0003 ? _0003._0002 : num3);
		if (_0005 && _000E_0017._000E(_000E, num4, num5, num6, _0006 - 10f))
		{
			return false;
		}
		bool result = false;
		float num7 = float.MaxValue;
		_000E_0017._000E(_000E, _000E._000E()._0006(), _0003, _0006, _000F, _0002, _0008, _000E_2008, _0003_2008, b, num, num2, num3, ref result, ref _0006_2008, ref num7);
		_000E_0017._000E(_000E, _000E._000E()._000F(), _0003, _0006, _000F, _0002, _0008, _000E_2008, _0003_2008, b, num, num2, num3, ref result, ref _0006_2008, ref num7);
		return result;
	}

	private static bool _000E(_0006_2006 _000E, float _0003, float _0006, float _000F, float _0002)
	{
		IReadOnlyList<_000E_2008_200A> readOnlyList = _000E._000E()._000E();
		if (readOnlyList == null)
		{
			return false;
		}
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			_000E_2008_200A obj = readOnlyList[i];
			if (obj != null && !obj._000E() && _000E_200A_200A._000E(obj._0003_2008, obj._0006_2008, obj._000F_2008, _0003, _0006, _000F, _0002))
			{
				return true;
			}
		}
		return false;
	}

	private static void _000E(_0006_2006 _000E, IReadOnlyList<_000E_2008_200A> _0003, _000E_2006_200B _0006, float _000F, int _0002, bool _0008, bool _0005, int _000E_2008, IReadOnlyList<string> _0003_2008, byte _0006_2008, float _000F_2008, float _0002_2008, float _0008_2008, ref bool _0005_2008, ref _0002 _000E_2007, ref float _0003_2007)
	{
		if (_0003 == null)
		{
			return;
		}
		for (int i = 0; i < _0003.Count; i++)
		{
			_000E_2008_200A obj = _0003[i];
			if (obj == null || obj._000E())
			{
				continue;
			}
			float num = _000E_200A_200A._000E(_000F_2008, _0002_2008, _0008_2008, obj._0003_2008, obj._0006_2008, obj._000F_2008);
			if (_0006._0003)
			{
				if (!_000E_200A_200A._000E(obj._0003_2008, obj._0006_2008, obj._000F_2008, _0006._0006, _0006._000F, _0006._0002, _000F))
				{
					continue;
				}
			}
			else if (num > _000F)
			{
				continue;
			}
			if (_000E_0017._000E(_000E, obj, _0002, _0008, _0005, _000E_2008, _0003_2008, _0006_2008))
			{
				_0002 obj2 = _000E_0017._0002._000E(obj);
				if (!_000E_0017._0005_2008.ContainsKey(obj2) && num < _0003_2007)
				{
					_0003_2007 = num;
					_000E_2007 = obj2;
					_0005_2008 = true;
				}
			}
		}
	}

	private static bool _000E(_0006_2006 _000E, _000E_2008_200A _0003, int _0006, bool _000F, bool _0002, int _0008, IReadOnlyList<string> _0005, byte _000E_2008)
	{
		bool flag = _0003._000E == 102;
		bool flag2 = _0003._000E == 101 && _0003._000E() == 16;
		string text = (flag ? null : _000F_200A_200A._0003(_000E, _0003._0006, _0003._000F));
		if (_000F && flag)
		{
			return false;
		}
		if (_0002 && flag2)
		{
			return false;
		}
		if (flag2 && (_0008 & _000E_0017._000E(_0003._0003())) != 0)
		{
			return false;
		}
		if (flag2 && _000E_2008 != 0 && (_0008 & _000E_0017._000E(_000E_2008)) != 0)
		{
			return false;
		}
		switch (_0006)
		{
		case 19:
			return flag;
		case 20:
			if (!(flag || flag2))
			{
				return _000E_0017._000E(_0005, text);
			}
			return true;
		case 21:
			if (!(flag || flag2))
			{
				return !_000E_0017._000E(_0005, text);
			}
			return true;
		default:
			return true;
		}
	}

	private static bool _000E(_0006_2006 _000E, out float _0003, out float _0006, out float _000F)
	{
		_0003 = (_0006 = (_000F = 0f));
		_0005_2001_200A obj = _000E._000E()._000E();
		if (obj == null)
		{
			return false;
		}
		_0003 = obj._0003;
		_0006 = obj._0006;
		_000F = obj._000F;
		return true;
	}

	private static bool _000E(_0006_2006 _000E, out float _0003, out float _0006, out float _000F, out byte _0002)
	{
		_0003 = (_0006 = (_000F = 0f));
		_0002 = 0;
		_0005_2001_200A obj = _000E._000E()._000E();
		if (obj == null)
		{
			return false;
		}
		_0003 = obj._0003;
		_0006 = obj._0006;
		_000F = obj._000F;
		_0002 = obj._0002_2007;
		return true;
	}

	private static bool _000E(_0006_2006 _000E, _0002 _0003, out float _0006, out float _000F, out float _0002, out byte _0008, out byte _0005, out string _000E_2008)
	{
		_0006 = (_000F = (_0002 = 0f));
		_0008 = 0;
		_0005 = 0;
		_000E_2008 = _0008_0017._000E(-1141293701);
		IReadOnlyList<_000E_2008_200A> readOnlyList = _000E._000E()._0006();
		if (_000E_0017._000E(_000E, readOnlyList, _0003, out _0006, out _000F, out _0002, out _0008, out _0005, out _000E_2008))
		{
			return true;
		}
		readOnlyList = _000E._000E()._000F();
		return _000E_0017._000E(_000E, readOnlyList, _0003, out _0006, out _000F, out _0002, out _0008, out _0005, out _000E_2008);
	}

	private static bool _000E(_0006_2006 _000E, _0002 _0003, _000E_2006_200B _0006, float _000F, int _0002, bool _0008, bool _0005, bool _000E_2008, int _0003_2008, IReadOnlyList<string> _0006_2008, out float _000F_2008, out float _0002_2008, out float _0008_2008, out byte _0005_2008, out byte _000E_2007, out string _0003_2007)
	{
		_000F_2008 = (_0002_2008 = (_0008_2008 = 0f));
		_0005_2008 = (_000E_2007 = 0);
		_0003_2007 = _0008_0017._000E(-1141293701);
		if (!_000E_0017._000E(_000E, out var num, out var num2, out var num3, out var b))
		{
			return false;
		}
		if (_000E_2008)
		{
			float num4 = (_0006._0003 ? _0006._0006 : num);
			float num5 = (_0006._0003 ? _0006._000F : num2);
			float num6 = (_0006._0003 ? _0006._0002 : num3);
			if (_000E_0017._000E(_000E, num4, num5, num6, _000F - 10f))
			{
				return false;
			}
		}
		if (!_000E_0017._000E(_000E, _0003, out _000F_2008, out _0002_2008, out _0008_2008, out _0005_2008, out _000E_2007, out _0003_2007))
		{
			return false;
		}
		if (_0006._0003)
		{
			if (!_000E_200A_200A._000E(_000F_2008, _0002_2008, _0008_2008, _0006._0006, _0006._000F, _0006._0002, _000F))
			{
				return false;
			}
		}
		else if (_000E_200A_200A._000E(num, num2, num3, _000F_2008, _0002_2008, _0008_2008) > _000F)
		{
			return false;
		}
		bool flag = _0003._0003 == 102;
		bool flag2 = _0003._0003 == 101 && _0003._0002 == 16;
		if (_0008 && flag)
		{
			return false;
		}
		if (_0005 && flag2)
		{
			return false;
		}
		if (flag2 && (_0003_2008 & _000E_0017._000E(_0003._0008)) != 0)
		{
			return false;
		}
		if (flag2 && b != 0 && (_0003_2008 & _000E_0017._000E(b)) != 0)
		{
			return false;
		}
		switch (_0002)
		{
		case 19:
			return flag;
		case 20:
			if (!(flag || flag2))
			{
				return _000E_0017._000E(_0006_2008, _0003_2007);
			}
			return true;
		case 21:
			if (!(flag || flag2))
			{
				return !_000E_0017._000E(_0006_2008, _0003_2007);
			}
			return true;
		default:
			return _0002 >= 0;
		case 22:
			return false;
		}
	}

	private static bool _000E(_0006_2006 _000E, _0002 _0003, _000E_2006_200B _0006, float _000F, int _0002, bool _0008, bool _0005, bool _000E_2008, int _0003_2008, IReadOnlyList<string> _0006_2008)
	{
		float num;
		float num2;
		float num3;
		byte b;
		byte b2;
		string text;
		return _000E_0017._000E(_000E, _0003, _0006, _000F, _0002, _0008, _0005, _000E_2008, _0003_2008, _0006_2008, out num, out num2, out num3, out b, out b2, out text);
	}

	private static async Task<_0006> _000E(_0006_2006 _000E, _0002 _0003, float _0006, float _000F, float _0002, string _0008, string _0005, int _000E_2008, _000E_2006_200B _0003_2008, float _0006_2008, int _000F_2008, bool _0002_2008, bool _0008_2008, bool _0005_2008, int _000E_2007, IReadOnlyList<string> _0003_2007, _0006_2007_200B _0006_2007)
	{
		_0006_0018 obj = _000E._000E();
		if (!_000E_0017._000E(obj))
		{
			return _000E_0017._0006.SessionChanged;
		}
		if (!obj._000E(_0006, _000F, _0002, _000F: true, _0008))
		{
			return _000E_0017._0006.PostFailed;
		}
		_000E_0017._000E(_0003, _0005 + _0008_0017._000E(-1141038098), _000E_2008, (_000E_2008 > 0) ? 5 : 0);
		long num = _0006_2007._0002();
		int num2 = 0;
		while (!_000E._0006())
		{
			if (!_000E_0017._000E(_000E._000E()))
			{
				return _000E_0017._0006.SessionChanged;
			}
			if (!_000E_0017._000E(_000E, _0003, _0003_2008, _0006_2008, _000F_2008, _0002_2008, _0008_2008, _0005_2008, _000E_2007, _0003_2007, out var _, out var _, out var _, out var _, out var _, out var _))
			{
				return _000E_0017._0006.TargetUnavailable;
			}
			if (!_000E_0017._000E(_000E, out var num6, out var _, out var num8))
			{
				return _000E_0017._0006.TargetUnavailable;
			}
			if (_000E_0017._000E(num6, num8, _0006, _0002) <= 0.25f)
			{
				return _000E_0017._0006.Arrived;
			}
			if (num2 >= 100 || _000E_0017._000E(num, _0006_2007._0002(), _0006_2007._0008) >= 10000.0)
			{
				return _000E_0017._0006.TimedOut;
			}
			num2++;
			await _0006_2007._000E(100);
		}
		return _000E_0017._0006.Interrupted;
	}

	private static void _000E(_0006_2007_200B _000E, int _0003, float _0006, float _000F, float _0002, float _0008, out float _0005, out float _000E_2008)
	{
		float num = 0f;
		float num2 = 0f;
		bool flag = false;
		for (int i = 0; i < 8; i++)
		{
			num = _000E_0017._000E(_000E);
			num2 = _000E_0017._000E(_000E);
			float num3 = _0006 + num;
			float num4 = _000F + num2;
			bool num5 = _000E_0017._0008 && Math.Abs(num - _000E_0017._0005) < 1E-06f && Math.Abs(num2 - _000E_0017._000E_2008) < 1E-06f;
			bool flag2 = _000E_0017._000E(_0002, _0008, num3, num4) <= 0.25f;
			if (!(num5 || flag2))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			for (int j = 0; j < 4; j++)
			{
				int num6 = (_0003 - 1 + j) & 3;
				num = ((num6 < 2) ? (-1f) : 1f);
				num2 = (((num6 & 1) == 0) ? (-1f) : 1f);
				bool num7 = _000E_0017._0008 && num == _000E_0017._0005 && num2 == _000E_0017._000E_2008;
				bool flag3 = _000E_0017._000E(_0002, _0008, _0006 + num, _000F + num2) <= 0.25f;
				if (!(num7 || flag3))
				{
					flag = true;
					break;
				}
			}
		}
		_000E_0017._0005 = num;
		_000E_0017._000E_2008 = num2;
		_000E_0017._0008 = true;
		_0005 = _0006 + num;
		_000E_2008 = _000F + num2;
	}

	private static float _000E(_0006_2007_200B _000E)
	{
		int num = _000E._000E(0, 2000001);
		if (num < 0)
		{
			num = 0;
		}
		if (num > 2000000)
		{
			num = 2000000;
		}
		return (float)num / 1000000f - 1f;
	}

	private static float _000E(float _000E, float _0003, float _0006, float _000F)
	{
		float num = _0006 - _000E;
		float num2 = _000F - _0003;
		return (float)Math.Sqrt(num * num + num2 * num2);
	}

	private static bool _000E(_0006_2006 _000E, IReadOnlyList<_000E_2008_200A> _0003, _0002 _0006, out float _000F, out float _0002, out float _0008, out byte _0005, out byte _000E_2008, out string _0003_2008)
	{
		_000F = (_0002 = (_0008 = 0f));
		_0005 = 0;
		_000E_2008 = 0;
		_0003_2008 = _0008_0017._000E(-1141293701);
		if (_0003 == null)
		{
			return false;
		}
		for (int i = 0; i < _0003.Count; i++)
		{
			_000E_2008_200A obj = _0003[i];
			if (obj != null && !obj._000E() && _000E_0017._0002._000E(obj).Equals(_0006))
			{
				_000F = obj._0003_2008;
				_0002 = obj._0006_2008;
				_0008 = obj._000F_2008;
				_000E_2008 = obj._000E;
				_0003_2008 = ((_000E_2008 == 102) ? _0008_0017._000E(-1141038118) : (_000F_200A_200A._0003(_000E, obj._0006, obj._000F) ?? _0008_0017._000E(-1141293701)));
				_0005 = (byte)((obj._000E == 102) ? 4u : 3u);
				return true;
			}
		}
		return false;
	}

	private static void _000E(_0006_2006 _000E, _0002 _0003, float _0006, string _000F)
	{
		if (_0006_2008_200A._000E)
		{
			string text = _0003._000E + _0008_0017._000E(-1141297577) + _000F;
			if (_000E_2007._000E(text, _0003: false, DateTime.UtcNow) && _000E_0017._000E(_000E, out var num, out var _, out var num3) && _000E_0017._000E(_000E, _0003, out var num4, out var _, out var num6, out var _, out var _, out var _))
			{
				float num7 = num4 - num;
				float num8 = num6 - num3;
				Math.Sqrt(num7 * num7 + num8 * num8);
			}
		}
	}

	private static void _000E(_0002 _000E)
	{
		if (!_000E_0017.m__0003 || !_000E_0017.m__000E.Equals(_000E))
		{
			_000E_0017._000E();
			_000E_0017.m__000E = _000E;
			_000E_0017.m__0003 = true;
		}
	}

	private static bool _000E(_0006_2006 _000E, _0002 _0003, _0006_0018 _0006, long _000F, long _0002)
	{
		_000F obj = _000F_2008;
		if (obj == null)
		{
			return true;
		}
		if (Volatile.Read(ref obj._0005) == 0)
		{
			return false;
		}
		if (!obj._000E.Equals(_0003))
		{
			_000F_2008 = null;
			return true;
		}
		if (!obj._000E_2008)
		{
			_0003_2006_200A obj2 = _0006._000E();
			if (obj2 == null || obj2._000E <= obj._000F || obj2._0003 != _0003._000E || obj2._0006 != obj._0003 || obj2._000F != obj._0006)
			{
				if (_000E_0017._000E(obj._0008, _000F, _0002) >= 2000.0)
				{
					_000F_2008 = null;
					return true;
				}
				return false;
			}
			if (!obj2._0002)
			{
				_000F_2008 = null;
				return true;
			}
			obj._000E_2008 = true;
		}
		if (_000E._000E()._0002_2008() == obj._0002)
		{
			return false;
		}
		_000E_0017.m__000F++;
		_000F_2008 = null;
		return true;
	}

	private static void _000E()
	{
		_000E_0017.m__000E = null;
		_000E_0017.m__0003 = false;
		_000E_0017.m__0006 = false;
		_000E_0017.m__000F = 0;
		_000E_0017.m__0002 = false;
		_0008 = false;
		_0005 = 0f;
		_000E_2008 = 0f;
		_0003_2008 = 0L;
		_0006_2008 = false;
		_000F_2008 = null;
	}

	private static void _000E(bool _000E)
	{
		_000E_0017._000E();
		if (_000E)
		{
			_0005_2008.Clear();
		}
	}

	private static bool _000E(_0006_0018 _000E)
	{
		if (_000E == _0002_2008 && _000E != null)
		{
			return _000E._0003() == _0008_2008;
		}
		return false;
	}

	private static double _000E(long _000E, long _0003, long _0006)
	{
		if (_0003 <= _000E)
		{
			return 0.0;
		}
		return (double)(_0003 - _000E) * 1000.0 / (double)_0006;
	}

	private static void _000E(_0002 _000E, long _0003, long _0006)
	{
		_000E_0017._000E(_0003);
		if (_0005_2008.Count >= 256)
		{
			_0002 key = null;
			long num = long.MaxValue;
			bool flag = false;
			foreach (KeyValuePair<_0002, long> item in _0005_2008)
			{
				if (!flag || item.Value < num)
				{
					key = item.Key;
					num = item.Value;
					flag = true;
				}
			}
			if (flag)
			{
				_0005_2008.Remove(key);
			}
		}
		long num2 = ((_0006 > 153722867280912930L) ? long.MaxValue : (_0006 * 60));
		_0005_2008[_000E] = ((_0003 > long.MaxValue - num2) ? long.MaxValue : (_0003 + num2));
	}

	private static void _000E(long _000E)
	{
		if (_0005_2008.Count == 0)
		{
			return;
		}
		List<_0002> list = new List<_0002>();
		foreach (KeyValuePair<_0002, long> item in _0005_2008)
		{
			if (_000E >= item.Value)
			{
				list.Add(item.Key);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			_0005_2008.Remove(list[i]);
			_000E_0017._000E(list[i], _0008_0017._000E(-1141038122), 0, 0);
		}
	}

	private static void _000E(_0002 _000E, string _0003, int _0006, int _000F)
	{
		if (!(_0003 == _0008_0017._000E(-1141038927)))
		{
			if (_000F > 0)
			{
				_0006.ToString();
				_000F.ToString();
			}
		}
		else
		{
			_0006.ToString();
		}
	}

	private static void _000E(_0002 _000E, string _0003, _0006 _0006, int _000F)
	{
		if (_0006 != _0006.TimedOut)
		{
			_0006.ToString().ToLowerInvariant();
		}
		if (_000F > 0)
		{
			_000F.ToString();
			5.ToString();
		}
	}

	internal static _000E_2008_200A _000E(_0006_2004_200A _000E, _0005_2001_200A _0003, bool _0006, float _000F, float _0002, float _0008, float _0005, int _000E_2008, bool _0003_2008, bool _0006_2008, int _000F_2008, bool _0002_2008, DataGridView _0008_2008)
	{
		if (_000E_2008 == 22 || _000E_2008 < 0)
		{
			return null;
		}
		if (_0002_2008)
		{
			float num = _0005 - 10f;
			float num2 = (_0006 ? _000F : _0003._0003);
			float num3 = (_0006 ? _0002 : _0003._0006);
			float num4 = (_0006 ? _0008 : _0003._000F);
			if (_000E_0017._000E(_000E, num2, num3, num4, num))
			{
				return null;
			}
		}
		_000E_2008_200A result = null;
		float num5 = float.MaxValue;
		_000E_0017._000E(_000E, _000E._0006(), _0003, _0006, _000F, _0002, _0008, _0005, _000E_2008, _0003_2008, _0006_2008, _000F_2008, _0003._0002_2007, _0008_2008, ref result, ref num5);
		_000E_0017._000E(_000E, _000E._000F(), _0003, _0006, _000F, _0002, _0008, _0005, _000E_2008, _0003_2008, _0006_2008, _000F_2008, _0003._0002_2007, _0008_2008, ref result, ref num5);
		return result;
	}

	private static bool _000E(_0006_2004_200A _000E, float _0003, float _0006, float _000F, float _0002)
	{
		IReadOnlyList<_000E_2008_200A> readOnlyList = _000E._000E();
		if (readOnlyList == null)
		{
			return false;
		}
		for (int i = 0; i < readOnlyList.Count; i++)
		{
			_000E_2008_200A obj = readOnlyList[i];
			if (obj != null && !obj._000E() && _000E_200A_200A._000E(obj._0003_2008, obj._0006_2008, obj._000F_2008, _0003, _0006, _000F, _0002))
			{
				return true;
			}
		}
		return false;
	}

	private static void _000E(_0006_2004_200A _000E, IReadOnlyList<_000E_2008_200A> _0003, _0005_2001_200A _0006, bool _000F, float _0002, float _0008, float _0005, float _000E_2008, int _0003_2008, bool _0006_2008, bool _000F_2008, int _0002_2008, byte _0008_2008, DataGridView _0005_2008, ref _000E_2008_200A _000E_2007, ref float _0003_2007)
	{
		if (_0003 == null)
		{
			return;
		}
		for (int i = 0; i < _0003.Count; i++)
		{
			_000E_2008_200A obj = _0003[i];
			if (obj == null || obj._000E())
			{
				continue;
			}
			float num = _000E_200A_200A._000E(_0006, obj._0003_2008, obj._0006_2008, obj._000F_2008);
			if (_000F)
			{
				if (!_000E_200A_200A._000E(obj._0003_2008, obj._0006_2008, obj._000F_2008, _0002, _0008, _0005, _000E_2008))
				{
					continue;
				}
			}
			else if (num > _000E_2008)
			{
				continue;
			}
			if (_000E_0017._000E(_000E, obj, _0003_2008, _0006_2008, _000F_2008, _0002_2008, _0008_2008, _0005_2008) && num < _0003_2007)
			{
				_0003_2007 = num;
				_000E_2007 = obj;
			}
		}
	}

	private static bool _000E(_0006_2004_200A _000E, _000E_2008_200A _0003, int _0006, bool _000F, bool _0002, int _0008, byte _0005, DataGridView _000E_2008)
	{
		bool flag = _0003._000E == 102;
		bool flag2 = _0003._000E == 101 && _0003._000E() == 16;
		string text = (flag ? null : _000F_200A_200A._0003(_000E, _0003));
		if (_000F && flag)
		{
			return false;
		}
		if (_0002 && flag2)
		{
			return false;
		}
		if (flag2 && (_0008 & _000E_0017._000E(_0003._0003())) != 0)
		{
			return false;
		}
		if (flag2 && _0005 != 0 && (_0008 & _000E_0017._000E(_0005)) != 0)
		{
			return false;
		}
		switch (_0006)
		{
		case 19:
			return flag;
		case 20:
			if (!(flag || flag2))
			{
				return _000E_0017._000E(_000E_2008, text);
			}
			return true;
		case 21:
			if (!(flag || flag2))
			{
				return !_000E_0017._000E(_000E_2008, text);
			}
			return true;
		default:
			return true;
		}
	}

	private static bool _000E(IReadOnlyList<string> _000E, string _0003)
	{
		if (_000E == null || string.IsNullOrEmpty(_0003))
		{
			return false;
		}
		for (int i = 0; i < _000E.Count; i++)
		{
			string text = _000E[i];
			if (!string.IsNullOrEmpty(text) && (text.IndexOf(_0003, StringComparison.OrdinalIgnoreCase) >= 0 || _0003.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0))
			{
				return true;
			}
		}
		return false;
	}

	internal static bool _000E(DataGridView _000E, string _0003)
	{
		if (_000E == null || string.IsNullOrEmpty(_0003))
		{
			return false;
		}
		List<string> list = new List<string>();
		for (int i = 0; i < _000E.Rows.Count; i++)
		{
			DataGridViewRow dataGridViewRow = _000E.Rows[i];
			if (!dataGridViewRow.IsNewRow && dataGridViewRow.Cells.Count != 0 && dataGridViewRow.Cells[0].Value != null)
			{
				list.Add(dataGridViewRow.Cells[0].Value.ToString());
			}
		}
		return _000E_0017._000E(list, _0003);
	}

	public static void _0003()
	{
		_0002_2008 = null;
		_0008_2008 = 0L;
		_000E(_000E: true);
		_000E_2007._000E();
	}
}
internal enum _000E_0018
{

}
public sealed class _000E_200B : Form
{
	private sealed class _0003
	{
		[StructLayout(LayoutKind.Auto)]
		private struct _0003 : IAsyncStateMachine
		{
			public int _000E;

			public AsyncTaskMethodBuilder<bool> _0003;

			public _000E_200B._0003 _0006;

			private TaskAwaiter<(_000F_2001, _0002_2001)> _000F;

			private void MoveNext()
			{
				int num = _000E;
				_000E_200B._0003 obj = _0006;
				bool result2;
				try
				{
					TaskAwaiter<(_000F_2001, _0002_2001)> awaiter;
					if (num != 0)
					{
						awaiter = obj._000E._000E(obj._0008.LicenseKey, obj._0003.m__0006, obj._0003.m__0003).GetAwaiter();
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
						_000F = default(TaskAwaiter<(_000F_2001, _0002_2001)>);
						num = (_000E = -1);
					}
					(_000F_2001, _0002_2001) result = awaiter.GetResult();
					result2 = result.Item1 != null && result.Item1.Success;
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

			public _000E_200B._0003 _0006;

			private TaskAwaiter<bool> _000F;

			private void MoveNext()
			{
				int num = _000E;
				_000E_200B._0003 obj = _0006;
				bool result;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						if (obj._0006 == null)
						{
							throw new InvalidOperationException(_0008_0017._000E(-1141265455));
						}
						obj._000F = new _0005_2006(_0006_2002._000F(), _0005_2006._0003, _0008_2006._000E, obj._000E, obj._0002._000E, _000E_200B._000E._000E._000E);
						_0008_2006._000E();
						awaiter = obj._000F._000E(_0008_2006._000E, _0005_2006._000E, _0005_2006._0003, CancellationToken.None).GetAwaiter();
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
						_000F = default(TaskAwaiter<bool>);
						num = (_000E = -1);
					}
					result = awaiter.GetResult();
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

		public _000F_2003 _000E;

		public _000E_200B _0003;

		public SynchronizationContext _0006;

		public _0005_2006 _000F;

		public _0002_2006 _0002;

		public _0002_2001 _0008;

		public bool _0005;

		public Action<Action> _000E_2008;

		internal async Task<bool> _000E()
		{
			if (_0006 == null)
			{
				throw new InvalidOperationException(_0008_0017._000E(-1141265455));
			}
			_000F = new _0005_2006(_0006_2002._000F(), _0005_2006._0003, _0008_2006._000E, _000E, _0002._000E, _000E_200B._000E._000E._000E);
			_0008_2006._000E();
			return await _000F._000E(_0008_2006._000E, _0005_2006._000E, _0005_2006._0003, CancellationToken.None);
		}

		internal void _000E(Action _000E)
		{
			_0006.Post(_000E_200B._000E._000E._000E, _000E);
		}

		internal async Task<bool> _0003()
		{
			(_000F_2001, _0002_2001) tuple = await this._000E._000E(_0008.LicenseKey, this._0003.m__0006, this._0003.m__0003);
			return tuple.Item1 != null && tuple.Item1.Success;
		}

		internal void _000E()
		{
			_0006_2006 obj = new _0006_2006();
			obj._000E(_0008, this._000E, this._0003._000E(), this._0003.m__0006);
			obj.FormClosed += _000E_200B._000E._000E._000E;
			obj._000E(_000F);
			_0005 = true;
			this._0003.Hide();
			if (_0002._000E(obj._0006))
			{
				obj.Show();
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _0006 : IAsyncStateMachine
	{
		public int _000E;

		public AsyncTaskMethodBuilder<bool> _0003;

		public _0002_2001 _0006;

		public Action _000F;

		public Action _0002;

		public Func<Task<bool>> _0008;

		public Action _0005;

		public Func<Task<bool>> _000E_2008;

		public Action _0003_2008;

		private TaskAwaiter<bool> _0006_2008;

		private void MoveNext()
		{
			int num = _000E;
			bool result;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num == 0)
				{
					awaiter = _0006_2008;
					_0006_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_009c;
				}
				if (num == 1)
				{
					awaiter = _0006_2008;
					_0006_2008 = default(TaskAwaiter<bool>);
					num = (_000E = -1);
					goto IL_0118;
				}
				if (_0006 != null && _0006.IsValid)
				{
					awaiter = _0008().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 0);
						_0006_2008 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_009c;
				}
				_000F();
				_0002();
				result = false;
				goto end_IL_0007;
				IL_009c:
				if (awaiter.GetResult())
				{
					awaiter = _000E_2008().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 1);
						_0006_2008 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0118;
				}
				_000F();
				_0005();
				result = false;
				goto end_IL_0007;
				IL_0118:
				if (!awaiter.GetResult())
				{
					_000F();
					result = false;
				}
				else
				{
					_0003_2008();
					result = true;
				}
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

	[Serializable]
	private sealed class _000E
	{
		public static readonly _000E _000E = new _000E();

		public static Action _0003;

		public static Action _0006;

		public static SendOrPostCallback _000F;

		public static Action<string> _0002;

		public static FormClosedEventHandler _0008;

		internal void _000E()
		{
			_000E_200B._000E(_000E: false);
		}

		internal void _0003()
		{
			_000F_2004_200B._000E(_0008_0017._000E(-1141266426));
		}

		internal void _000E(object _000E)
		{
			((Action)_000E)();
		}

		internal void _000E(string _000E)
		{
		}

		internal void _000E(object _000E, FormClosedEventArgs _0003)
		{
			Application.Exit();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _000F : IAsyncStateMachine
	{
		public int _000E;

		public AsyncVoidMethodBuilder _0003;

		public _000E_200B _0006;

		private _0003 _000F;

		private TaskAwaiter<_000F_2001> _0002;

		private TaskAwaiter<_0002_2001> _0008;

		private TaskAwaiter<bool> _0005;

		private void MoveNext()
		{
			int num = _000E;
			_000E_200B obj = _0006;
			try
			{
				TaskAwaiter<_000F_2001> awaiter2;
				TaskAwaiter<_0002_2001> awaiter;
				_000F_2001 result;
				_0002_2001 result2;
				switch (num)
				{
				default:
					_000F = new _0003();
					_000F._0003 = _0006;
					if (!_000E_200B._000E())
					{
						_000E(_000E: true);
						_000F._000E = new _000F_2003();
						awaiter2 = _000F._000E._000E(obj._0008.Text, obj.m__0006, obj.m__0003).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_000E = 0);
							_0002 = awaiter2;
							_0003.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_00e3;
					}
					_000F_2004_200B._000E(_0008_0017._000E(-1141265500));
					goto end_IL_000e;
				case 0:
					awaiter2 = _0002;
					_0002 = default(TaskAwaiter<_000F_2001>);
					num = (_000E = -1);
					goto IL_00e3;
				case 1:
					awaiter = _0008;
					_0008 = default(TaskAwaiter<_0002_2001>);
					num = (_000E = -1);
					goto IL_019b;
				case 2:
					{
						try
						{
							TaskAwaiter<bool> awaiter3;
							if (num != 2)
							{
								awaiter3 = _000E(_000F._0008, _000E_200B._000E._000E._000E, _000E_200B._000E._000E._0003, obj.Close, _000F._000E, _000F._0003, _000F._000E).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num = (_000E = 2);
									_0005 = awaiter3;
									_0003.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
							}
							else
							{
								awaiter3 = _0005;
								_0005 = default(TaskAwaiter<bool>);
								num = (_000E = -1);
							}
							awaiter3.GetResult();
						}
						finally
						{
							if (num < 0 && !_000F._0005 && _000F._000F != null)
							{
								_000F._000F.Dispose();
							}
						}
						goto end_IL_000e;
					}
					IL_00e3:
					result = awaiter2.GetResult();
					if (result == null || !result.Success)
					{
						break;
					}
					_000F._000F = null;
					_000F._0005 = false;
					_000F._0002 = new _0002_2006();
					_000F._0006 = SynchronizationContext.Current;
					awaiter = _000F._000E._000E(obj.m__0006).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_000E = 1);
						_0008 = awaiter;
						_0003.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_019b;
					IL_019b:
					result2 = awaiter.GetResult();
					_000F._0008 = result2;
					goto case 2;
				}
				_000E(_000E: false);
				_000F_2004_200B._000E(_0008_0017._000E(-1141265561));
				end_IL_000e:;
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

	private _0002_2002 m__000E;

	private string m__0003 = string.Empty;

	private string m__0006 = string.Empty;

	private static bool m__000F;

	private IContainer _0002;

	private TextBox _0008;

	private Button _0005;

	private TextBox _000E_2008;

	public _000E_200B()
	{
		_000E();
		_000E(new _0002_2002());
		this.m__0006 = _000E()._0003();
		_000E_2008.Text = this.m__0006;
		this.m__0003 = _000E()._0006();
	}

	internal static async Task<bool> _000E(_0002_2001 _000E, Action _0003, Action _0006, Action _000F, Func<Task<bool>> _0002, Func<Task<bool>> _0008, Action _0005)
	{
		if (_000E == null || !_000E.IsValid)
		{
			_0003();
			_0006();
			return false;
		}
		if (!(await _0002()))
		{
			_0003();
			_000F();
			return false;
		}
		if (!(await _0008()))
		{
			_0003();
			return false;
		}
		_0005();
		return true;
	}

	private _0002_2002 _000E()
	{
		return this.m__000E;
	}

	private void _000E(_0002_2002 _000E)
	{
		this.m__000E = _000E;
	}

	public static bool _000E()
	{
		return _000E_200B.m__000F;
	}

	public static void _000E(bool _000E)
	{
		_000E_200B.m__000F = _000E;
	}

	private void _000E(object _000E, EventArgs _0003)
	{
	}

	private async void _0003(object _000E, EventArgs _0003)
	{
		_0003 obj = new _0003
		{
			_0003 = this
		};
		if (_000E_200B._000E())
		{
			_000F_2004_200B._000E(_0008_0017._000E(-1141265500));
			return;
		}
		_000E_200B._000E(_000E: true);
		obj._000E = new _000F_2003();
		_000F_2001 obj2 = await obj._000E._000E(_0008.Text, this.m__0006, this.m__0003);
		if (obj2 != null && obj2.Success)
		{
			obj._000F = null;
			obj._0005 = false;
			obj._0002 = new _0002_2006();
			obj._0006 = SynchronizationContext.Current;
			obj._0008 = await obj._000E._000E(this.m__0006);
			try
			{
				await _000E_200B._000E(obj._0008, _000E_200B._000E._000E._000E, _000E_200B._000E._000E._0003, base.Close, obj._000E, obj._0003, obj._000E);
				return;
			}
			finally
			{
				if (!obj._0005 && obj._000F != null)
				{
					obj._000F.Dispose();
				}
			}
		}
		_000E_200B._000E(_000E: false);
		_000F_2004_200B._000E(_0008_0017._000E(-1141265561));
	}

	protected override void Dispose(bool _000E)
	{
		if (_000E && _0002 != null)
		{
			_0002.Dispose();
		}
		base.Dispose(_000E);
	}

	private void _000E()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_000E_200B));
		_0008 = new TextBox();
		_0005 = new Button();
		_000E_2008 = new TextBox();
		SuspendLayout();
		_0008.Font = new Font(_0008_0017._000E(-1141306171), 12f, FontStyle.Regular, GraphicsUnit.Point, 222);
		_0008.Location = new Point(11, 49);
		_0008.Name = _0008_0017._000E(-1141289103);
		_0008.Size = new Size(412, 26);
		_0008.TabIndex = 0;
		_0008.Text = _0008_0017._000E(-1141265630);
		_0005.Location = new Point(183, 84);
		_0005.Name = _0008_0017._000E(-1141280343);
		_0005.Size = new Size(75, 23);
		_0005.TabIndex = 1;
		_0005.Text = _0008_0017._000E(-1141295834);
		_0005.UseVisualStyleBackColor = true;
		_0005.Click += _0003;
		_000E_2008.Font = new Font(_0008_0017._000E(-1141306171), 12f, FontStyle.Regular, GraphicsUnit.Point, 222);
		_000E_2008.Location = new Point(13, 13);
		_000E_2008.Name = _0008_0017._000E(-1141281066);
		_000E_2008.ReadOnly = true;
		_000E_2008.Size = new Size(408, 26);
		_000E_2008.TabIndex = 2;
		_000E_2008.TextAlign = HorizontalAlignment.Center;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(433, 114);
		base.Controls.Add(_000E_2008);
		base.Controls.Add(_0005);
		base.Controls.Add(_0008);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.Icon = (Icon)componentResourceManager.GetObject(_0008_0017._000E(-1141260701));
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = _0008_0017._000E(-1141261127);
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = _0008_0017._000E(-1141261127);
		base.TopMost = true;
		base.Load += _000E;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
internal static class _000E_200B_200A
{
	internal struct _000E
	{
		public int _000E;

		public int _0003;

		public ushort _0006;

		public ushort _000F;
	}

	internal static string _000E(ushort _000E, IReadOnlyList<_000E> _0003)
	{
		StringBuilder stringBuilder = new StringBuilder(_0008_0017._000E(-1141031457));
		stringBuilder.Append(_000E.ToString(CultureInfo.InvariantCulture)).Append(_0008_0017._000E(-1141031484));
		int num = _0003?.Count ?? 0;
		for (int i = 0; i < num; i++)
		{
			if (i != 0)
			{
				stringBuilder.Append(',');
			}
			_000E obj = _0003[i];
			stringBuilder.Append(_0008_0017._000E(-1141031509)).Append(obj._000E.ToString(CultureInfo.InvariantCulture)).Append(_0008_0017._000E(-1141031516))
				.Append(obj._0003.ToString(CultureInfo.InvariantCulture))
				.Append(_0008_0017._000E(-1141181928))
				.Append(obj._0006.ToString(CultureInfo.InvariantCulture))
				.Append(_0008_0017._000E(-1141181943))
				.Append(obj._000F.ToString(CultureInfo.InvariantCulture))
				.Append('}');
		}
		return stringBuilder.Append(_0008_0017._000E(-1141156722)).ToString();
	}

	internal static bool _000E(string _000E)
	{
		if (string.Equals(_000E, _0008_0017._000E(-1141192789), StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}

	internal static bool _0003(string _000E)
	{
		if (string.Equals(_000E, _0008_0017._000E(-1141112980), StringComparison.Ordinal))
		{
			return true;
		}
		if (string.Equals(_000E, _0008_0017._000E(-1141173131), StringComparison.Ordinal))
		{
			return true;
		}
		if (string.Equals(_000E, _0008_0017._000E(-1141192796), StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
internal enum _000F_0017
{

}
internal enum _000F_0018
{

}
public sealed class _000F_200B : Form
{
	public _0008_2004_200B _000E;

	private Label _0003;

	private IContainer _0006;

	public _000F_200B()
	{
		_000E();
		base.FormBorderStyle = FormBorderStyle.None;
		base.StartPosition = FormStartPosition.CenterScreen;
		base.Size = new Size(400, 200);
		base.TopMost = true;
		_0003 = new Label
		{
			Text = _0008_0017._000E(-1141265671),
			Location = new Point(0, 50),
			Size = new Size(400, 30),
			TextAlign = ContentAlignment.MiddleCenter,
			Font = new Font(_0008_0017._000E(-1141265716), 14f)
		};
		base.Controls.Add(_0003);
		this._000E = _0008_2004_200B._000E(this, Color.FromArgb(255, 128, 128), Color.FromArgb(128, 255, 128), 50, 100, 300, 23, null, 0);
	}

	public void _000E(string _000E)
	{
		if (base.InvokeRequired)
		{
			Invoke(new Action<string>(this._000E), _000E);
		}
		else
		{
			_0003.Text = _000E;
		}
	}

	public void _000E(int _000E)
	{
		if (base.InvokeRequired)
		{
			Invoke(new Action<int>(this._000E), _000E);
		}
		else
		{
			_000E = Math.Max(0, Math.Min(100, _000E));
			this._000E._000E(_000E, string.Format(_0008_0017._000E(-1141265729), _000E));
		}
	}

	protected override void Dispose(bool _000E)
	{
		if (_000E && _0006 != null)
		{
			_0006.Dispose();
		}
		base.Dispose(_000E);
	}

	private void _000E()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_000F_200B));
		SuspendLayout();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(800, 450);
		base.Icon = (Icon)componentResourceManager.GetObject(_0008_0017._000E(-1141260701));
		base.Name = _0008_0017._000E(-1141265740);
		base.ShowInTaskbar = false;
		Text = _0008_0017._000E(-1141265740);
		ResumeLayout(performLayout: false);
	}
}
internal static class _000F_200B_200A
{
	internal static string _000E(IEnumerable<int> _000E)
	{
		StringBuilder stringBuilder = new StringBuilder(_0008_0017._000E(-1141031584));
		bool flag = true;
		if (_000E != null)
		{
			foreach (int item in _000E)
			{
				if (!flag)
				{
					stringBuilder.Append(',');
				}
				stringBuilder.Append(_0003(item));
				flag = false;
			}
		}
		stringBuilder.Append(_0008_0017._000E(-1141156722));
		return stringBuilder.ToString();
	}

	internal static string _0003(IEnumerable<int> _000E)
	{
		StringBuilder stringBuilder = new StringBuilder(_0008_0017._000E(-1141031615));
		bool flag = true;
		if (_000E != null)
		{
			foreach (int item in _000E)
			{
				if (!flag)
				{
					stringBuilder.Append(',');
				}
				stringBuilder.Append(_0003(item));
				flag = false;
			}
		}
		stringBuilder.Append(_0008_0017._000E(-1141156722));
		return stringBuilder.ToString();
	}

	internal static string _000E()
	{
		return _0008_0017._000E(-1141031644);
	}

	internal static string _0003()
	{
		return _0008_0017._000E(-1141031678);
	}

	internal static string _000E(int _000E)
	{
		return _0008_0017._000E(-1141031699) + _0003(_000E) + _0008_0017._000E(-1141174659);
	}

	internal static string _000E(int _000E, ushort _0003, ushort _0006)
	{
		return _0008_0017._000E(-1141031743) + _000F_200B_200A._0003(_000E) + _0008_0017._000E(-1141181928) + _000F_200B_200A._0003(_0003) + _0008_0017._000E(-1141181943) + _000F_200B_200A._0003(_0006) + _0008_0017._000E(-1141174659);
	}

	internal static string _000E(IList<(ushort, ushort)> _000E)
	{
		StringBuilder stringBuilder = new StringBuilder(_0008_0017._000E(-1141031776));
		if (_000E != null)
		{
			for (int i = 0; i < _000E.Count && i < 10; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(',');
				}
				stringBuilder.Append('[').Append(_0003(_000E[i].Item1)).Append(',')
					.Append(_0003(_000E[i].Item2))
					.Append(']');
			}
		}
		stringBuilder.Append(_0008_0017._000E(-1141156722));
		return stringBuilder.ToString();
	}

	private static string _0003(int _000E)
	{
		return _000E.ToString(CultureInfo.InvariantCulture);
	}
}
