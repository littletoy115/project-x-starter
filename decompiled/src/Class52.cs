using System.Collections.Generic;

internal sealed class Class52
{
	private readonly bool[] bool_0;

	internal Class52(IReadOnlyList<GStruct1> ireadOnlyList_0)
	{
		bool_0 = new bool[11];
		if (ireadOnlyList_0 == null)
		{
			return;
		}
		for (int i = 0; i < ireadOnlyList_0.Count; i++)
		{
			GStruct1 gStruct = ireadOnlyList_0[i];
			if (gStruct.bool_0 && gStruct.int_0 >= 1 && gStruct.int_0 <= 10)
			{
				bool_0[gStruct.int_0] = true;
			}
		}
	}

	internal bool method_0(int int_0)
	{
		if (int_0 >= 1 && int_0 < bool_0.Length)
		{
			return bool_0[int_0];
		}
		return false;
	}
}
