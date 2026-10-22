using System.Collections.Generic;
using System.Diagnostics;

internal sealed class Class118<T, U, V>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly V gparam_2;

	public T licenseKey => gparam_0;

	public U uniqueIdentifier => gparam_1;

	public V server => gparam_2;

	[DebuggerHidden]
	public Class118(T licenseKey, U uniqueIdentifier, V server)
	{
		gparam_0 = licenseKey;
		gparam_1 = uniqueIdentifier;
		gparam_2 = server;
	}

	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class118<T, U, V> @class = obj as Class118<T, U, V>;
		if (this != @class)
		{
			if (@class != null && EqualityComparer<T>.Default.Equals(gparam_0, @class.gparam_0) && EqualityComparer<U>.Default.Equals(gparam_1, @class.gparam_1))
			{
				return EqualityComparer<V>.Default.Equals(gparam_2, @class.gparam_2);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return ((-1828029677 + EqualityComparer<T>.Default.GetHashCode(gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(gparam_1)) * -1521134295 + EqualityComparer<V>.Default.GetHashCode(gparam_2);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[3];
		T val = gparam_0;
		array[0] = ((val != null) ? val.ToString() : null);
		U val2 = gparam_1;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		V val3 = gparam_2;
		array[2] = ((val3 != null) ? val3.ToString() : null);
		return string.Format(null, "{{ licenseKey = {0}, uniqueIdentifier = {1}, server = {2} }}", array);
	}
}
