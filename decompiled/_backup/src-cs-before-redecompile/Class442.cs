using System;
using System.IO;
using System.Text.RegularExpressions;

internal static class Class442
{
	private static readonly Regex regex_0 = new Regex("\\A[A-Za-z][A-Za-z0-9_]*(\\.[A-Za-z][A-Za-z0-9_]*)+\\z", RegexOptions.CultureInvariant);

	private static readonly Regex regex_1 = new Regex("\\A[0-9a-f]{64}\\z", RegexOptions.CultureInvariant);

	internal static Class32 smethod_0(string string_0, string string_1)
	{
		Class57.smethod_0(out var byte_, out var string_2);
		return smethod_1(byte_, string_2, "com.klab.klassxonline", string_0, string_1, Class71.smethod_1);
	}

	internal static Class32 smethod_1(byte[] byte_0, string string_0, string string_1, string string_2, string string_3, Func<string, string, string, int, Class71.Class72> func_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			string text = Class57.smethod_1(byte_0);
			if (regex_1.IsMatch(string_0 ?? string.Empty) && string.Equals(text, string_0, StringComparison.Ordinal))
			{
				if (!regex_0.IsMatch(string_1 ?? string.Empty))
				{
					throw new InvalidOperationException("The target package name is invalid.");
				}
				if (!Class71.smethod_2(string_3))
				{
					throw new InvalidOperationException("The selected ADB serial is invalid.");
				}
				if (string.IsNullOrWhiteSpace(string_2))
				{
					throw new InvalidOperationException("The ADB executable is not configured.");
				}
				if (func_0 == null)
				{
					throw new ArgumentNullException("runAdb");
				}
				smethod_6(func_0, string_2, string_3);
				int num = smethod_7(func_0, string_2, string_3, string_1);
				smethod_8(func_0, string_2, string_3, string_1, out var int_, out var string_4);
				if (int_ != num)
				{
					throw new InvalidOperationException("The selected package UID changed while deployment was being prepared.");
				}
				smethod_9(func_0, string_2, string_3);
				string text2 = "/data/user/0/" + string_1;
				string string_5 = "/data/data/" + string_1;
				string string_6 = text2 + "/code_cache/capybara-license/" + text + "/libshare.so";
				string text3 = smethod_2(func_0, string_2, string_3, int_, text2, string_5, text, byte_0.Length);
				if (text3 == "CURRENT")
				{
					return new Class32(string_1, int_, string_4, string_6, text, bool_1: true);
				}
				smethod_4(text3, "CAPY_PROBE");
				string text4 = Guid.NewGuid().ToString("N");
				string text5 = Path.Combine(Path.GetTempPath(), "capybara-license-" + text4 + ".so");
				string text6 = "/data/local/tmp/.capybara-license." + text4 + ".so";
				bool flag = false;
				Exception ex = null;
				try
				{
					File.WriteAllBytes(text5, byte_0);
					smethod_11(func_0, string_2, string_3, "push \"" + text5 + "\" " + text6, 120000, "library push", text5);
					flag = true;
					string text7 = smethod_3(func_0, string_2, string_3, int_, text2, string_5, text, byte_0.Length, text6, text4);
					if (text7 != "CREATED" && text7 != "REUSED")
					{
						smethod_4(text7, "CAPY_DEPLOY");
					}
					return new Class32(string_1, int_, string_4, string_6, text, text7 == "REUSED");
				}
				catch (Exception ex2)
				{
					ex = ex2;
					throw;
				}
				finally
				{
					string text8 = null;
					try
					{
						if (File.Exists(text5))
						{
							File.Delete(text5);
						}
					}
					catch
					{
						if (ex == null)
						{
							text8 = "Host staging cleanup failed.";
						}
					}
					if (flag)
					{
						Class71.Class72 class72_ = func_0(string_2, string_3, smethod_10("rm -f " + text6), 15000);
						if (ex == null && !smethod_12(class72_))
						{
							text8 = "Device staging cleanup failed.";
						}
					}
					if (text8 != null)
					{
						throw new InvalidOperationException("Agent license deployment succeeded but " + text8);
					}
				}
			}
			throw new InvalidDataException("The embedded agent license library SHA256 is invalid.");
		}
		throw new InvalidDataException("The embedded agent license library is missing.");
	}

	private static string smethod_2(Func<string, string, string, int, Class71.Class72> func_0, string string_0, string string_1, int int_0, string string_2, string string_3, string string_4, int int_1)
	{
		string text = string_2 + "/code_cache";
		string text2 = string_3 + "/code_cache";
		string text3 = text + "/capybara-license";
		string text4 = text2 + "/capybara-license";
		string text5 = text3 + "/" + string_4;
		string text6 = text4 + "/" + string_4;
		string text7 = text5 + "/libshare.so";
		string text8 = text6 + "/libshare.so";
		string string_5 = "set -eu; code=" + text + "; exec 9<$code || { echo CAPY_PROBE=NAMESPACE; exit 0; }; cl=$(readlink /proc/$$/fd/9); case $cl in " + text + "|" + text2 + ") ;; *) echo CAPY_PROBE=NAMESPACE; exit 0;; esac; [ -d /proc/$$/fd/9 ] && [ $(stat -L -c %u /proc/$$/fd/9) = " + int_0 + " ] || { echo CAPY_PROBE=NAMESPACE; exit 0; }; base=$code/capybara-license; [ -e $base ] || { echo CAPY_PROBE=MISSING; exit 0; }; [ ! -L $base ] || { echo CAPY_PROBE=NAMESPACE; exit 0; }; exec 8<$base || { echo CAPY_PROBE=NAMESPACE; exit 0; }; bl=$(readlink /proc/$$/fd/8); case $bl in " + text3 + "|" + text4 + ") ;; *) echo CAPY_PROBE=NAMESPACE; exit 0;; esac; [ -d /proc/$$/fd/8 ] && [ $(stat -L -c %u:%g:%a /proc/$$/fd/8) = 0:0:711 ] || { echo CAPY_PROBE=NAMESPACE; exit 0; }; ver=$base/" + string_4 + "; [ -e $ver ] || { echo CAPY_PROBE=MISSING; exit 0; }; [ ! -L $ver ] || { echo CAPY_PROBE=NAMESPACE; exit 0; }; exec 7<$ver || { echo CAPY_PROBE=NAMESPACE; exit 0; }; vl=$(readlink /proc/$$/fd/7); case $vl in " + text5 + "|" + text6 + ") ;; *) echo CAPY_PROBE=NAMESPACE; exit 0;; esac; [ -d /proc/$$/fd/7 ] && [ $(stat -L -c %u:%g:%a /proc/$$/fd/7) = 0:0:711 ] || { echo CAPY_PROBE=NAMESPACE; exit 0; }; final=/proc/$$/fd/7/libshare.so; [ -e $final ] || { echo CAPY_PROBE=MISSING; exit 0; }; [ ! -L $final ] || { echo CAPY_PROBE=NAMESPACE; exit 0; }; exec 6<$final || { echo CAPY_PROBE=NAMESPACE; exit 0; }; fl=$(readlink /proc/$$/fd/6); case $fl in " + text7 + "|" + text8 + ") ;; *) echo CAPY_PROBE=NAMESPACE; exit 0;; esac; meta=$(stat -L -c %u:%g:%a:%s /proc/$$/fd/6); [ -f /proc/$$/fd/6 ] && [ $meta = 0:0:555:" + int_1 + " ] || { echo CAPY_PROBE=NAMESPACE; exit 0; }; actual=$(sha256sum /proc/$$/fd/6 | cut -d\\  -f1); [ $actual = " + string_4 + " ] || { echo CAPY_PROBE=IMMUTABLE; exit 0; }; [ $(stat -L -c %d:%i $final) = $(stat -L -c %d:%i /proc/$$/fd/6) ] || { echo CAPY_PROBE=NAMESPACE; exit 0; }; echo CAPY_PROBE=CURRENT";
		return smethod_5(smethod_11(func_0, string_0, string_1, smethod_10(string_5), 15000, "agent license namespace probe", null).string_1, "CAPY_PROBE");
	}

	private static string smethod_3(Func<string, string, string, int, Class71.Class72> func_0, string string_0, string string_1, int int_0, string string_2, string string_3, string string_4, int int_1, string string_5, string string_6)
	{
		string text = string_2 + "/code_cache";
		string text2 = string_3 + "/code_cache";
		string text3 = ".libshare.so.stage." + string_6;
		string string_7 = "set -eu;umask 077;u=" + text + ";l=" + text2 + ";h=" + string_4 + ";p=/proc/$$/fd;bad(){ echo CAPY_DEPLOY=NAMESPACE;exit 0;};perm(){ echo CAPY_DEPLOY=PERMISSIONS;exit 0;};imm(){ echo CAPY_DEPLOY=IMMUTABLE;exit 0;};exec 9<$u||bad;c=$(readlink $p/9);[ $c = $u ]||[ $c = $l ]||bad;[ -d $p/9 ]&&[ $(stat -L -c %u $p/9) = " + int_0 + " ]||bad;b=$p/9/capybara-license;mb=0;if [ ! -e $b ];then mkdir $b||exit 1;mb=1;fi;[ ! -L $b ]||bad;exec 8<$b||bad;c=$(readlink $p/8);[ $c = $u/capybara-license ]||[ $c = $l/capybara-license ]||bad;[ -d $p/8 ]&&[ $(stat -L -c %u $p/8) = 0 ]||bad;if [ $mb = 1 ];then chown 0:0 $p/8;chmod 711 $p/8;fi;[ $(stat -L -c %u:%g:%a $p/8) = 0:0:711 ]||bad;v=$p/8/$h;mv=0;if [ ! -e $v ];then mkdir $v||exit 1;mv=1;fi;[ ! -L $v ]||bad;exec 7<$v||bad;c=$(readlink $p/7);[ $c = $u/capybara-license/$h ]||[ $c = $l/capybara-license/$h ]||bad;[ -d $p/7 ]&&[ $(stat -L -c %u $p/7) = 0 ]||bad;if [ $mv = 1 ];then chown 0:0 $p/7;chmod 711 $p/7;fi;[ $(stat -L -c %u:%g:%a $p/7) = 0:0:711 ]||bad;n=" + text3 + ";s=$p/7/$n;clean(){ rm -f $s;};trap clean EXIT;[ ! -e $s ]&&[ ! -L $s ]||bad;set -C;cat " + string_5 + " >$s;set +C;exec 6<$s||bad;c=$(readlink $p/6);[ $c = $u/capybara-license/$h/$n ]||[ $c = $l/capybara-license/$h/$n ]||bad;[ -f $p/6 ]&&[ $(stat -L -c %u $p/6) = 0 ]||bad;chown 0:0 $p/6;[ $(stat -L -c %u:%g:%a:%s $p/6) = 0:0:600:" + int_1 + " ]||perm;set -- $(sha256sum $p/6);[ $1 = $h ]||imm;chmod 555 $p/6;[ $(stat -L -c %u:%g:%a:%s $p/6) = 0:0:555:" + int_1 + " ]||perm;f=$p/7/libshare.so;o=CREATED;if [ -e $f ];then o=REUSED;else mv -n $s $f;fi;[ ! -L $f ]||bad;exec 5<$f||bad;c=$(readlink $p/5);[ $c = $u/capybara-license/$h/libshare.so ]||[ $c = $l/capybara-license/$h/libshare.so ]||bad;[ -f $p/5 ]&&[ $(stat -L -c %u:%g:%a:%s $p/5) = 0:0:555:" + int_1 + " ]||perm;set -- $(sha256sum $p/5);[ $1 = $h ]||imm;[ $(stat -L -c %d:%i $f) = $(stat -L -c %d:%i $p/5) ]||bad;c=$(readlink $p/8);[ $c = $u/capybara-license ]||[ $c = $l/capybara-license ]||bad;c=$(readlink $p/7);[ $c = $u/capybara-license/$h ]||[ $c = $l/capybara-license/$h ]||bad;echo CAPY_DEPLOY=$o";
		return smethod_5(smethod_11(func_0, string_0, string_1, smethod_10(string_7), 15000, "anchored private deployment", null).string_1, "CAPY_DEPLOY");
	}

	private static void smethod_4(string string_0, string string_1)
	{
		if (!(string_0 == "MISSING") || !(string_1 == "CAPY_PROBE"))
		{
			switch (string_0)
			{
			case "IMMUTABLE":
				throw new InvalidOperationException("The immutable agent license library path contains different bytes.");
			case "NAMESPACE":
				throw new InvalidOperationException("The agent license deployment namespace contains a symlink or unsafe entry.");
			case "PERMISSIONS":
				throw new InvalidOperationException("The deployed library permissions or size did not verify.");
			default:
				throw new InvalidOperationException("The agent license deployment returned an invalid answer.");
			}
		}
	}

	private static string smethod_5(string string_0, string string_1)
	{
		Match match = Regex.Match(string_0 ?? string.Empty, "(?:\\A|\\r?\\n)" + Regex.Escape(string_1) + "=(?<value>[A-Z]+)(?:\\r?\\n|\\z)", RegexOptions.CultureInvariant);
		if (!match.Success)
		{
			throw new InvalidOperationException("The device deployment response was invalid.");
		}
		return match.Groups["value"].Value;
	}

	private static void smethod_6(Func<string, string, string, int, Class71.Class72> func_0, string string_0, string string_1)
	{
		if (!string.Equals(smethod_11(func_0, string_0, string_1, "get-state", 8000, "selected device check", null).string_1.Trim(), "device", StringComparison.Ordinal))
		{
			throw new InvalidOperationException("The selected device is not reachable.");
		}
	}

	private static int smethod_7(Func<string, string, string, int, Class71.Class72> func_0, string string_0, string string_1, string string_2)
	{
		Match match = Regex.Match(smethod_11(func_0, string_0, string_1, "shell cmd package list packages -U " + string_2, 15000, "selected package lookup", null).string_1, "(?:\\A|\\r?\\n)package:(?<package>[A-Za-z0-9_.]+)\\s+uid:(?<uid>[0-9]+)(?:\\r?\\n|\\z)", RegexOptions.CultureInvariant);
		if (!match.Success || !string.Equals(match.Groups["package"].Value, string_2, StringComparison.Ordinal) || !int.TryParse(match.Groups["uid"].Value, out var result) || result < 10000)
		{
			throw new InvalidOperationException("The selected device did not report the exact target package and UID.");
		}
		return result;
	}

	private static void smethod_8(Func<string, string, string, int, Class71.Class72> func_0, string string_0, string string_1, string string_2, out int int_0, out string string_3)
	{
		Class71.Class72 @class = smethod_11(func_0, string_0, string_1, "shell dumpsys package " + string_2, 15000, "selected package details", null);
		Match match = Regex.Match(@class.string_1, "(?m)^\\s*Package \\[(?<package>[^\\]]+)\\](?:\\s+\\([^)]+\\))?:?\\s*$", RegexOptions.CultureInvariant);
		Match match2 = Regex.Match(@class.string_1, "(?m)^\\s*userId=(?<uid>[0-9]+)\\s*$", RegexOptions.CultureInvariant);
		Match match3 = Regex.Match(@class.string_1, "(?m)^\\s*dataDir=(?<path>\\S+)\\s*$", RegexOptions.CultureInvariant);
		if (match.Success && string.Equals(match.Groups["package"].Value, string_2, StringComparison.Ordinal) && match2.Success && int.TryParse(match2.Groups["uid"].Value, out int_0) && int_0 >= 10000 && match3.Success)
		{
			string_3 = match3.Groups["path"].Value;
			string b = "/data/user/0/" + string_2;
			string b2 = "/data/data/" + string_2;
			if (!string.Equals(string_3, b, StringComparison.Ordinal) && !string.Equals(string_3, b2, StringComparison.Ordinal))
			{
				throw new InvalidOperationException("The selected package data directory is outside its strict app-private scope.");
			}
			return;
		}
		throw new InvalidOperationException("The selected package details could not be verified.");
	}

	private static void smethod_9(Func<string, string, string, int, Class71.Class72> func_0, string string_0, string string_1)
	{
		if (!string.Equals(smethod_11(func_0, string_0, string_1, "shell \"su 0 id -u\"", 8000, "root access check", null).string_1.Trim(), "0", StringComparison.Ordinal))
		{
			throw new InvalidOperationException("Root access did not return UID 0 on the selected device.");
		}
	}

	private static string smethod_10(string string_0)
	{
		return "shell \"su 0 sh -c '" + string_0 + "'\"";
	}

	private static Class71.Class72 smethod_11(Func<string, string, string, int, Class71.Class72> func_0, string string_0, string string_1, string string_2, int int_0, string string_3, string string_4)
	{
		Class71.Class72 @class = func_0(string_0, string_1, string_2, int_0);
		if (!smethod_12(@class))
		{
			string text = ((@class == null) ? "no ADB result" : @class.string_0);
			if (!string.IsNullOrEmpty(string_0) && text != null)
			{
				text = text.Replace(string_0, "<adb>");
			}
			if (!string.IsNullOrEmpty(string_4) && text != null)
			{
				text = text.Replace(string_4, "<temporary-file>");
			}
			if (string.IsNullOrWhiteSpace(text))
			{
				text = ((@class == null || !@class.bool_1) ? "ADB command failed" : "ADB timed out");
			}
			if (text.Length > 240)
			{
				text = text.Substring(0, 240);
			}
			throw new InvalidOperationException(string_3 + " failed: " + text.Trim());
		}
		return @class;
	}

	private static bool smethod_12(Class71.Class72 class72_0)
	{
		if (class72_0 != null && class72_0.method_0())
		{
			return string.IsNullOrWhiteSpace(class72_0.string_2);
		}
		return false;
	}
}
