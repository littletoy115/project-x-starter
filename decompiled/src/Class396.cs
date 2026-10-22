using System;
using System.IO;

internal static class Class396
{
	internal static bool smethod_0(string string_0, bool bool_0)
	{
		if (!File.Exists(string_0))
		{
			throw new FileNotFoundException("Superuser database is missing", string_0);
		}
		Class59 @class = new Class59(string_0);
		bool result;
		try
		{
			if (@class.method_1("PRAGMA integrity_check") != "ok")
			{
				throw new InvalidOperationException("Superuser database failed integrity_check");
			}
			string text = @class.method_1("SELECT value FROM settings WHERE key='automatic_response'");
			string text2 = @class.method_1("SELECT value FROM settings WHERE key='notification'");
			if (!(result = (bool_0 ? (text2 != null) : (text2 != "0"))))
			{
				return false;
			}
			@class.method_0("BEGIN IMMEDIATE");
			try
			{
				if (bool_0)
				{
					@class.method_0("DELETE FROM settings WHERE key='notification'");
				}
				else
				{
					@class.method_0("INSERT INTO settings(key,value) VALUES('notification','0') ON CONFLICT(key) DO UPDATE SET value='0'");
				}
				@class.method_0("COMMIT");
			}
			catch
			{
				try
				{
					@class.method_0("ROLLBACK");
				}
				catch (InvalidOperationException)
				{
				}
				throw;
			}
			@class.method_0("PRAGMA wal_checkpoint(TRUNCATE)");
			if (@class.method_1("PRAGMA integrity_check") != "ok" || @class.method_1("SELECT value FROM settings WHERE key='automatic_response'") != text)
			{
				throw new InvalidOperationException("Superuser database verification failed");
			}
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
		if (!File.Exists(string_0 + "-wal") && !File.Exists(string_0 + "-shm"))
		{
			return result;
		}
		throw new InvalidOperationException("SQLite sidecar files remain after checkpoint");
	}

	internal static bool smethod_1(string string_0, string string_1, bool bool_0)
	{
		if (!string.IsNullOrEmpty(string_0) && File.Exists(string_0))
		{
			if (!Class71.smethod_2(string_1))
			{
				throw new ArgumentException("Selected emulator serial is invalid", "\u0003");
			}
			if (smethod_3(string_0, string_1, "get-state", 8000) != "device")
			{
				throw new InvalidOperationException("Selected emulator is not ready");
			}
			if (smethod_2(string_0, string_1, "id -u", 8000) != "0")
			{
				throw new InvalidOperationException("Selected emulator did not grant root access");
			}
			string text = smethod_2(string_0, string_1, "if test ! -f /data/user_de/0/com.android.settings/databases/superuser.sqlite; then echo missing; elif test -e /data/user_de/0/com.android.settings/databases/superuser.sqlite-wal || test -e /data/user_de/0/com.android.settings/databases/superuser.sqlite-shm; then echo busy; else echo ready; fi", 8000);
			if (text == "missing")
			{
				throw new InvalidOperationException("Superuser database is missing on the selected emulator");
			}
			if (text != "ready")
			{
				throw new InvalidOperationException("Superuser database is in use or could not be checked: " + text);
			}
			string text2 = Path.Combine(Path.GetTempPath(), "klx-root-toast-" + Guid.NewGuid().ToString("N"));
			Directory.CreateDirectory(text2);
			try
			{
				string text3 = Path.Combine(text2, "superuser.sqlite");
				string text4 = Path.Combine(text2, "verified.sqlite");
				smethod_2(string_0, string_1, "cp /data/user_de/0/com.android.settings/databases/superuser.sqlite /data/local/tmp/.capy-toast-copy.sqlite && chmod 644 /data/local/tmp/.capy-toast-copy.sqlite", 8000);
				smethod_3(string_0, string_1, "pull /data/local/tmp/.capy-toast-copy.sqlite \"" + text3 + "\"", 20000);
				if (!smethod_0(text3, bool_0))
				{
					return false;
				}
				Class59 @class = new Class59(text3);
				string text5;
				try
				{
					text5 = @class.method_1("SELECT value FROM settings WHERE key='automatic_response'");
				}
				finally
				{
					((IDisposable)@class).Dispose();
				}
				smethod_3(string_0, string_1, "push \"" + text3 + "\" /data/local/tmp/.capy-toast-new.sqlite", 20000);
				smethod_2(string_0, string_1, "am force-stop com.android.settings && test ! -e /data/user_de/0/com.android.settings/databases/superuser.sqlite-wal && test ! -e /data/user_de/0/com.android.settings/databases/superuser.sqlite-shm && (test -e /data/user_de/0/com.android.settings/databases/superuser.sqlite.capy-toast.bak || cp /data/user_de/0/com.android.settings/databases/superuser.sqlite /data/user_de/0/com.android.settings/databases/superuser.sqlite.capy-toast.bak) && cp /data/local/tmp/.capy-toast-new.sqlite /data/user_de/0/com.android.settings/databases/superuser.sqlite && chown system:system /data/user_de/0/com.android.settings/databases/superuser.sqlite && chmod 660 /data/user_de/0/com.android.settings/databases/superuser.sqlite", 15000);
				smethod_2(string_0, string_1, "cp /data/user_de/0/com.android.settings/databases/superuser.sqlite /data/local/tmp/.capy-toast-copy.sqlite && chmod 644 /data/local/tmp/.capy-toast-copy.sqlite", 8000);
				smethod_3(string_0, string_1, "pull /data/local/tmp/.capy-toast-copy.sqlite \"" + text4 + "\"", 20000);
				Class59 class2 = new Class59(text4);
				try
				{
					string text6 = class2.method_1("SELECT value FROM settings WHERE key='notification'");
					string text7 = class2.method_1("SELECT value FROM settings WHERE key='automatic_response'");
					if (class2.method_1("PRAGMA integrity_check") != "ok" || text6 != (bool_0 ? null : "0") || text7 != text5)
					{
						throw new InvalidOperationException("Read-back verification failed; original database is backed up at /data/user_de/0/com.android.settings/databases/superuser.sqlite.capy-toast.bak");
					}
				}
				finally
				{
					((IDisposable)class2).Dispose();
				}
				return true;
			}
			finally
			{
				try
				{
					smethod_2(string_0, string_1, "rm -f /data/local/tmp/.capy-toast-copy.sqlite /data/local/tmp/.capy-toast-new.sqlite", 8000);
				}
				catch (Exception)
				{
				}
				try
				{
					Directory.Delete(text2, recursive: true);
				}
				catch (IOException)
				{
				}
				catch (UnauthorizedAccessException)
				{
				}
			}
		}
		throw new FileNotFoundException("Selected LDPlayer adb.exe was not found", string_0);
	}

	private static string smethod_2(string string_0, string string_1, string string_2, int int_0)
	{
		return smethod_3(string_0, string_1, "shell \"su 0 sh -c '" + string_2 + "'\"", int_0);
	}

	private static string smethod_3(string string_0, string string_1, string string_2, int int_0)
	{
		Class71.Class72 @class = Class71.smethod_1(string_0, string_1, string_2, int_0);
		if (!@class.method_0())
		{
			throw new InvalidOperationException("adb " + string_2 + ": " + @class.string_0);
		}
		return @class.string_1.Trim();
	}
}
