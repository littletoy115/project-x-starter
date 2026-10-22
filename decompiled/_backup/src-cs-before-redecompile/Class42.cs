using System.Collections.Generic;
using System.Diagnostics;

internal sealed class Class42<T, U>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T gparam_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_1;

	public T uniqueIdentifier => gparam_0;

	public U server => gparam_1;

	[DebuggerHidden]
	public Class42(T uniqueIdentifier, U server)
	{
		gparam_0 = uniqueIdentifier;
		gparam_1 = server;
	}

	[DebuggerHidden]
	public override bool Equals(object obj)
	{
		Class42<T, U> @class = obj as Class42<T, U>;
		if (this != @class)
		{
			if (@class != null && EqualityComparer<T>.Default.Equals(gparam_0, @class.gparam_0))
			{
				return EqualityComparer<U>.Default.Equals(gparam_1, @class.gparam_1);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-1188885283 + EqualityComparer<T>.Default.GetHashCode(gparam_0)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(gparam_1);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		T val = gparam_0;
		array[0] = ((val != null) ? val.ToString() : null);
		U val2 = gparam_1;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ uniqueIdentifier = {0}, server = {1} }}", array);
	}
}
