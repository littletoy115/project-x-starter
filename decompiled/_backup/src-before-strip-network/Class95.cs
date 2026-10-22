using System;
using System.Collections.Generic;

internal sealed class Class95
{
	private static readonly IReadOnlyDictionary<string, string> ireadOnlyDictionary_0 = new Dictionary<string, string>(StringComparer.Ordinal);

	internal static readonly Class95 class95_0 = new Class95(null, null, null);

	private IReadOnlyDictionary<string, string> ireadOnlyDictionary_1;

	private IReadOnlyDictionary<string, string> ireadOnlyDictionary_2;

	private IReadOnlyDictionary<string, string> ireadOnlyDictionary_3;

	internal Class95(IReadOnlyDictionary<string, string> ireadOnlyDictionary_4, IReadOnlyDictionary<string, string> ireadOnlyDictionary_5, IReadOnlyDictionary<string, string> ireadOnlyDictionary_6)
	{
		method_1(ireadOnlyDictionary_4 ?? ireadOnlyDictionary_0);
		method_3(ireadOnlyDictionary_5 ?? ireadOnlyDictionary_0);
		method_5(ireadOnlyDictionary_6 ?? ireadOnlyDictionary_0);
	}

	public IReadOnlyDictionary<string, string> method_0()
	{
		return ireadOnlyDictionary_1;
	}

	private void method_1(IReadOnlyDictionary<string, string> ireadOnlyDictionary_4)
	{
		ireadOnlyDictionary_1 = ireadOnlyDictionary_4;
	}

	public IReadOnlyDictionary<string, string> method_2()
	{
		return ireadOnlyDictionary_2;
	}

	private void method_3(IReadOnlyDictionary<string, string> ireadOnlyDictionary_4)
	{
		ireadOnlyDictionary_2 = ireadOnlyDictionary_4;
	}

	public IReadOnlyDictionary<string, string> method_4()
	{
		return ireadOnlyDictionary_3;
	}

	private void method_5(IReadOnlyDictionary<string, string> ireadOnlyDictionary_4)
	{
		ireadOnlyDictionary_3 = ireadOnlyDictionary_4;
	}
}
