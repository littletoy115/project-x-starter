using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

internal sealed class Class351 : IDisposable
{
	private sealed class Class352<T> : IDisposable
	{
		private sealed class Class353 : IEnumerator<T>, IEnumerable<T>, IEnumerable, IEnumerator, IDisposable
		{
			private int int_0;

			private T gparam_0;

			private int int_1;

			public Class352<T> class352_0;

			private object object_0;

			private bool bool_0;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return gparam_0;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return gparam_0;
				}
			}

			[DebuggerHidden]
			public Class353(int int_2)
			{
				int_0 = int_2;
				int_1 = Environment.CurrentManagedThreadId;
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				int num = int_0;
				if (num == -3 || num == 1)
				{
					try
					{
					}
					finally
					{
						method_0();
					}
				}
				object_0 = null;
				int_0 = -2;
			}

			private bool MoveNext()
			{
				bool result;
				try
				{
					int num = int_0;
					Class352<T> @class = class352_0;
					switch (num)
					{
					default:
						result = false;
						goto end_IL_0000;
					case 1:
						int_0 = -3;
						break;
					case 0:
						int_0 = -1;
						object_0 = @class.object_0;
						bool_0 = false;
						int_0 = -3;
						Monitor.Enter(object_0, ref bool_0);
						break;
					}
					while (true)
					{
						if (@class.queue_0.Count <= 0)
						{
							if (!@class.bool_0)
							{
								Monitor.Wait(@class.object_0);
								continue;
							}
							result = false;
							method_0();
							break;
						}
						gparam_0 = @class.queue_0.Dequeue();
						int_0 = 1;
						result = true;
						break;
					}
					end_IL_0000:;
				}
				catch
				{
					//try-fault
					((IDisposable)this).Dispose();
					throw;
				}
				return result;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void method_0()
			{
				int_0 = -1;
				if (bool_0)
				{
					Monitor.Exit(object_0);
				}
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new NotSupportedException();
			}

			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				Class353 @class;
				if (int_0 == -2 && int_1 == Environment.CurrentManagedThreadId)
				{
					int_0 = 0;
					@class = this;
				}
				else
				{
					@class = new Class353(0);
					@class.class352_0 = class352_0;
				}
				return @class;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((IEnumerable<T>)this).GetEnumerator();
			}
		}

		private readonly Queue<T> queue_0 = new Queue<T>();

		private readonly object object_0 = new object();

		private readonly int int_0;

		private bool bool_0;

		internal Class352(int int_1)
		{
			int_0 = int_1;
		}

		internal void method_0(T gparam_0)
		{
			lock (object_0)
			{
				if (!bool_0 && queue_0.Count < int_0)
				{
					queue_0.Enqueue(gparam_0);
					Monitor.Pulse(object_0);
				}
			}
		}

		[IteratorStateMachine(typeof(Class352<>.Class353))]
		internal IEnumerable<T> method_1()
		{
			return new Class353(-2)
			{
				class352_0 = this
			};
		}

		internal void method_2()
		{
			lock (object_0)
			{
				bool_0 = true;
				Monitor.PulseAll(object_0);
			}
		}

		public void Dispose()
		{
			method_2();
		}
	}

	private sealed class Class354
	{
		internal string string_0;

		internal uint uint_0;

		internal int int_0;

		internal long long_0;

		internal byte[] byte_0;
	}

	[Serializable]
	private sealed class Class355
	{
		public static readonly Class355 class355_0 = new Class355();

		public static Action<string, uint, string, double, string, int> action_0;

		public static Action<string, uint, string, double> action_1;

		public static Action<string> action_2;

		internal void method_0(string string_0, uint uint_0, string string_1, double double_0, string string_2, int int_0)
		{
		}

		internal void method_1(string string_0, uint uint_0, string string_1, double double_0)
		{
		}

		internal void method_2(string string_0)
		{
		}
	}

	private readonly Interface5 interface5_0;

	private readonly Interface5 interface5_1;

	private readonly Func<string, uint, Class1> func_0;

	private readonly Action<string, uint, string, int> action_0;

	private readonly Action<string, uint, string, double, string, int> action_1;

	private readonly Action<string, uint, string, double> action_2;

	private readonly Class114 class114_0;

	private readonly Func<bool> func_1;

	private readonly Action<string> action_3;

	private readonly bool bool_0;

	private readonly Random random_0 = new Random();

	private readonly Class352<Class354> class352_0 = new Class352<Class354>(8);

	private readonly Task task_0;

	private int int_0;

	private int int_1;

	internal Class351(Interface5 interface5_2, Func<string, uint, Class1> func_2, Action<string, uint, string, int> action_4, Action<string, uint, string, double, string, int> action_5, Class114 class114_1, Action<string> action_6, Func<bool> func_3 = null, Interface5 interface5_3 = null, Action<string, uint, string, double> action_7 = null, bool bool_1 = false)
	{
		interface5_0 = interface5_2;
		interface5_1 = interface5_3;
		func_0 = func_2;
		action_0 = action_4;
		action_1 = action_5 ?? new Action<string, uint, string, double, string, int>(Class355.class355_0.method_0);
		action_2 = action_7 ?? new Action<string, uint, string, double>(Class355.class355_0.method_1);
		class114_0 = class114_1;
		func_1 = func_3;
		action_3 = action_6 ?? new Action<string>(Class355.class355_0.method_2);
		bool_0 = bool_1;
		if (!class114_0.method_0(out var string_))
		{
			action_3(Class185.smethod_0(-1141208125) + string_);
			task_0 = Task.CompletedTask;
		}
		else
		{
			task_0 = Task.Run((Action)method_1);
		}
	}

	internal void method_0(string string_0, uint uint_0, int int_2, long long_0, byte[] byte_0)
	{
		if (Volatile.Read(ref int_1) == 0 && !task_0.IsCompleted)
		{
			class352_0.method_0(new Class354
			{
				string_0 = string_0,
				uint_0 = uint_0,
				int_0 = int_2,
				long_0 = long_0,
				byte_0 = byte_0
			});
		}
	}

	private void method_1()
	{
		foreach (Class354 item in class352_0.method_1())
		{
			try
			{
				method_2(item);
			}
			catch (Exception ex)
			{
				action_3(Class185.smethod_0(-1141208166) + ex.GetType().Name + Class185.smethod_0(-1141301932) + ex.Message);
			}
		}
	}

	private void method_2(Class354 class354_0)
	{
		if (func_1 != null && !func_1())
		{
			action_3(Class185.smethod_0(-1141208196));
			return;
		}
		Class50 @class = interface5_0.imethod_0(class354_0.byte_0);
		string text = ((@class.method_6() == null) ? @class.method_8() : null);
		Class1 class2 = func_0(class354_0.string_0, class354_0.uint_0);
		if (class2 == null)
		{
			action_3(Class185.smethod_0(-1141208251));
			return;
		}
		action_1(class354_0.string_0, class354_0.uint_0, text, @class.method_2(), Class185.smethod_0(-1141241041), @class.method_4());
		Class50 class3 = null;
		if (interface5_1 != null)
		{
			try
			{
				class3 = interface5_1.imethod_0(class354_0.byte_0);
				action_2(class354_0.string_0, class354_0.uint_0, (class3.method_6() == null) ? class3.method_8() : null, class3.method_2());
			}
			catch (Exception ex)
			{
				action_3(Class185.smethod_0(-1141208327) + ex.Message);
			}
		}
		double double_;
		string string_;
		string string_2;
		string text2 = smethod_0(text, @class.method_2(), @class.method_6() != null, (class3 == null || class3.method_6() != null) ? null : class3.method_8(), class3?.method_2() ?? 0.0, class3 != null && class3.method_6() == null, class114_0.double_0, bool_0, out double_, out string_, out string_2);
		if (text2 == null)
		{
			if (@class.method_6() != null)
			{
				action_3(Class185.smethod_0(-1141208363) + @class.method_6() + Class185.smethod_0(-1141308401));
				return;
			}
			action_3(Class185.smethod_0(-1141208412) + @class.method_2().ToString(Class185.smethod_0(-1141274464)) + Class185.smethod_0(-1141208460) + class114_0.double_0.ToString(Class185.smethod_0(-1141308399)) + Class185.smethod_0(-1141208474) + (bool_0 ? Class185.smethod_0(-1141208499) : string.Empty));
			return;
		}
		if (string_ == Class185.smethod_0(-1141241132))
		{
			action_3(Class185.smethod_0(-1141208534) + class354_0.uint_0 + Class185.smethod_0(-1141208575) + text2 + Class185.smethod_0(-1141241731) + double_.ToString(Class185.smethod_0(-1141274464)) + Class185.smethod_0(-1141213831) + string_2);
			action_1(class354_0.string_0, class354_0.uint_0, text2, double_, string_, class3.method_4());
		}
		if (!method_3(class2))
		{
			action_3(Class185.smethod_0(-1141180942));
			return;
		}
		double num = method_5(class354_0);
		if (num < 1.0)
		{
			action_3(Class185.smethod_0(-1141180993) + num.ToString(Class185.smethod_0(-1141308399)) + Class185.smethod_0(-1141181035));
			return;
		}
		double value = Math.Min(class114_0.double_2 + random_0.NextDouble() * (class114_0.double_3 - class114_0.double_2), num - 1.0);
		action_3(Class185.smethod_0(-1141181059) + class354_0.uint_0 + Class185.smethod_0(-1141208575) + text2 + Class185.smethod_0(-1141241731) + double_.ToString(Class185.smethod_0(-1141274464)) + Class185.smethod_0(-1141213816) + string_ + Class185.smethod_0(-1141181111) + value.ToString(Class185.smethod_0(-1141308399)) + Class185.smethod_0(-1141253640));
		Thread.Sleep(TimeSpan.FromSeconds(value));
		if (!method_4(class354_0))
		{
			action_3(Class185.smethod_0(-1141181125) + class354_0.uint_0 + Class185.smethod_0(-1141181161));
			return;
		}
		int arg = Interlocked.Increment(ref int_0);
		action_3(Class185.smethod_0(-1141181185) + class354_0.uint_0 + Class185.smethod_0(-1141208575) + text2 + Class185.smethod_0(-1141181238) + arg);
		action_0(class354_0.string_0, class354_0.uint_0, text2, arg);
	}

	internal static string smethod_0(string string_0, double double_0, bool bool_1, string string_1, double double_1, bool bool_2, double double_2, bool bool_3, out double double_3, out string string_2, out string string_3)
	{
		double_3 = 0.0;
		string_2 = null;
		string_3 = null;
		if (!bool_1 && string_0 != null && double_0 >= double_2)
		{
			if (bool_3 && bool_2 && string_1 != null && string_1 != string_0 && double_1 >= double_2)
			{
				double_3 = double_1;
				string_2 = Class185.smethod_0(-1141241132);
				string_3 = Class185.smethod_0(-1141241159);
				return string_1;
			}
			double_3 = double_0;
			string_2 = Class185.smethod_0(-1141241041);
			string_3 = Class185.smethod_0(-1141241062);
			return string_0;
		}
		if (bool_3 && bool_2 && string_1 != null)
		{
			double_3 = double_1;
			string_2 = Class185.smethod_0(-1141241132);
			string_3 = (bool_1 ? Class185.smethod_0(-1141241333) : Class185.smethod_0(-1141241240));
			return string_1;
		}
		string_3 = (bool_1 ? Class185.smethod_0(-1141241333) : ((string_0 == null) ? Class185.smethod_0(-1141181242) : Class185.smethod_0(-1141213721)));
		return null;
	}

	private bool method_3(Class1 class1_0)
	{
		if (class1_0 != null && class1_0.String_7 == Class185.smethod_0(-1141253648))
		{
			return class1_0.Int32_4 > 0;
		}
		return false;
	}

	private bool method_4(Class354 class354_0)
	{
		if (func_1 != null && !func_1())
		{
			return false;
		}
		Class1 @class = func_0(class354_0.string_0, class354_0.uint_0);
		if (@class != null && !(@class.String_7 != Class185.smethod_0(-1141253648)))
		{
			return method_5(class354_0) >= 0.0;
		}
		return false;
	}

	private double method_5(Class354 class354_0)
	{
		return ((double)class354_0.long_0 + (double)class354_0.int_0 * 1000.0 - (double)smethod_1() - class114_0.double_1 * 1000.0) / 1000.0;
	}

	private static long smethod_1()
	{
		return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
	}

	public void Dispose()
	{
		if (Interlocked.Exchange(ref int_1, 1) == 0)
		{
			class352_0.method_2();
			try
			{
				task_0.Wait(TimeSpan.FromSeconds(15.0));
			}
			catch (AggregateException)
			{
			}
			interface5_0.Dispose();
		}
	}
}
