using System;
using System.Collections.Generic;
using Newtonsoft.Json;

internal static class Class189
{
	internal static string smethod_0(IEnumerable<Class455> ienumerable_0, DateTime dateTime_0)
	{
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		List<Class410> list = new List<Class410>();
		if (ienumerable_0 != null)
		{
			foreach (Class455 item in ienumerable_0)
			{
				if (item == null || item.float_0 == null || item.float_1 == null || item.float_2 == null)
				{
					continue;
				}
				int num = item.float_0.Length;
				if (num != 0 && item.float_1.Length == num && item.float_2.Length == num)
				{
					List<Class79> list2 = new List<Class79>(num);
					for (int i = 0; i < num; i++)
					{
						list2.Add(new Class79
						{
							Single_0 = item.float_0[i],
							Single_1 = item.float_1[i],
							Nullable_0 = item.float_2[i]
						});
					}
					list.Add(new Class410
					{
						Int32_0 = item.int_0,
						List_0 = list2
					});
				}
			}
		}
		return JsonConvert.SerializeObject((object)new Class84
		{
			DateTime_0 = dateTime_0,
			List_0 = list
		}, (Formatting)1, new JsonSerializerSettings
		{
			NullValueHandling = (NullValueHandling)1
		});
	}

	internal static List<Class455> smethod_1(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return null;
		}
		Class84 @class;
		try
		{
			@class = JsonConvert.DeserializeObject<Class84>(string_0);
		}
		catch (JsonException)
		{
			return null;
		}
		if (@class != null && @class.List_0 != null)
		{
			List<Class455> list = new List<Class455>();
			{
				foreach (Class410 item in @class.List_0)
				{
					if (item == null || item.List_0 == null || item.List_0.Count == 0)
					{
						continue;
					}
					List<float> list2 = new List<float>();
					List<float> list3 = new List<float>();
					List<float> list4 = new List<float>();
					foreach (Class79 item2 in item.List_0)
					{
						if (item2 != null)
						{
							list2.Add(item2.Single_0);
							list3.Add(item2.Single_1);
							list4.Add(item2.Nullable_0.GetValueOrDefault());
						}
					}
					if (list2.Count != 0)
					{
						list.Add(new Class455
						{
							int_0 = item.Int32_0,
							float_0 = list2.ToArray(),
							float_1 = list3.ToArray(),
							float_2 = list4.ToArray()
						});
					}
				}
				return list;
			}
		}
		return null;
	}
}
