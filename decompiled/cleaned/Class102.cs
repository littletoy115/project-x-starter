using System;
using System.Collections.Generic;

internal sealed class Class102
{
	private IReadOnlyList<Class401> ireadOnlyList_0 = new Class401[0];

	private DateTime dateTime_0;

	internal IReadOnlyList<Class401> method_0(IReadOnlyList<Class401> ireadOnlyList_1, DateTime dateTime_1)
	{
		if (ireadOnlyList_1 != null && ireadOnlyList_1.Count > 0)
		{
			ireadOnlyList_0 = ireadOnlyList_1;
			dateTime_0 = dateTime_1;
			return ireadOnlyList_1;
		}
		if (dateTime_0 != DateTime.MinValue && dateTime_1 - dateTime_0 <= TimeSpan.FromSeconds(2.0))
		{
			return ireadOnlyList_0;
		}
		return ireadOnlyList_1 ?? new Class401[0];
	}

	internal void method_1()
	{
		ireadOnlyList_0 = new Class401[0];
		dateTime_0 = DateTime.MinValue;
	}
}
