using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class GClass6
{
	private List<GClass4> list_0;

	private List<GClass4> list_1;

	public List<GClass4> MemoryPointers
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
		[CompilerGenerated]
		set
		{
			list_0 = value;
		}
	}

	public List<GClass4> ByteArrays
	{
		[CompilerGenerated]
		get
		{
			return list_1;
		}
		[CompilerGenerated]
		set
		{
			list_1 = value;
		}
	}
}
