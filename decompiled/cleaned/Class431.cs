using System.Collections.Generic;
using System.Globalization;
using System.Text;

internal static class Class431
{
	internal static bool bool_0;

	internal static string smethod_0()
	{
		if (!Class357.smethod_0())
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder(Class185.smethod_0(-1141210056));
		stringBuilder.Append(bool_0 ? Class185.smethod_0(-1141210092) : Class185.smethod_0(-1141210088)).Append(Class185.smethod_0(-1141210111));
		smethod_3(stringBuilder);
		if (stringBuilder[stringBuilder.Length - 1] == ',')
		{
			stringBuilder.Length--;
		}
		stringBuilder.Append(Class185.smethod_0(-1141209102));
		return stringBuilder.ToString();
	}

	private static void smethod_1(StringBuilder stringBuilder_0, string string_0, int int_0)
	{
		stringBuilder_0.Append('"').Append(string_0).Append(Class185.smethod_0(-1141127429))
			.Append(int_0.ToString(CultureInfo.InvariantCulture))
			.Append(',');
	}

	private static void smethod_2(StringBuilder stringBuilder_0, string string_0, string string_1)
	{
		stringBuilder_0.Append('"').Append(string_0).Append(Class185.smethod_0(-1141209111))
			.Append((string_1 ?? string.Empty).Replace(Class185.smethod_0(-1141300999), Class185.smethod_0(-1141300327)).Replace(Class185.smethod_0(-1141304355), Class185.smethod_0(-1141209113)))
			.Append(Class185.smethod_0(-1141209122));
	}

	private static void smethod_3(StringBuilder stringBuilder_0)
	{
		smethod_2(stringBuilder_0, Class185.smethod_0(-1141209131), Class185.smethod_0(-1141209152));
		smethod_2(stringBuilder_0, Class185.smethod_0(-1141209163), Class357.smethod_12());
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209190), Class357.smethod_10());
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209208), Class357.smethod_4());
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209231), Class357.smethod_6());
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209242), Class357.smethod_8());
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209268), 24);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209283), 32);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209298), 8);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209314), 16);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209335), 20);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209350), 40);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209366), 64);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209372), 80);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209386), 96);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209408), 56);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209418), 80);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209436), 184);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209451), 104);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209480), 116);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209501), 120);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209508), 124);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209533), 329);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209550), 16);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209567), 28);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209584), 60);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141209593), 96);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210640), 100);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210651), 116);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210677), 120);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210690), 664);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210708), 672);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210735), 844);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210745), 4);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210766), 280);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210769), 284);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210780), 288);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210799), 292);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210814), 132);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210820), 136);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210834), 32);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210855), 38);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210872), 56);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210893), 40);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210911), 48);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210925), 120);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210932), 136);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210947), 208);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210963), 32);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210977), 63);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210999), 49);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141211013), 24);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141211019), 72);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141211039), 92);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141211054), 16);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141211060), 18);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141211073), 40);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141211090), 128);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141211107), 76);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141211124), 184);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210116), 56);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210141), 58);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210157), 188);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210174), 48);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210189), 80);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210195), 48);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210210), 144);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210227), 216);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210254), 0);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210267), 2);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210282), 102);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210301), 52);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210307), 16);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210328), 40);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210343), 48);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210358), 36);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210364), 16);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210377), 24);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210400), 16);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210412), 30);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141158581), 32);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210428), 56);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210454), 344);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210468), 16);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210491), 40);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210506), 36);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210521), 16);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210543), 24);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210553), 56);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210576), 40);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210580), 44);
		smethod_1(stringBuilder_0, Class185.smethod_0(-1141210594), 46);
		foreach (KeyValuePair<string, int> item in Class357.smethod_14())
		{
			smethod_1(stringBuilder_0, item.Key, item.Value);
		}
		if (Class357.smethod_22() || Class357.smethod_24() || Class357.smethod_48() || Class357.smethod_30() || Class357.smethod_26() || Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141232362), 16);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141210611), 32);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207565), 128);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207583), 136);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207599), 564);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207612), 520);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207637), 376);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207651), 532);
		}
		if (Class357.smethod_32() || Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141158406), 112);
		}
		if (Class357.smethod_32() || Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141158450), 120);
		}
		if (Class357.smethod_34())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207676), 136);
		}
		if (Class357.smethod_68())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141139934), 0);
		}
		if (Class357.smethod_68())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141141017), 88);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207689), 136);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207717), 48);
		}
		if (Class357.smethod_36() || Class357.smethod_52())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207736), 44);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207746), 16);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207768), 72);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207782), 48);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207800), 16);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207815), 18);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207829), 32);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207834), 360);
		}
		if (Class357.smethod_36())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207852), 32);
		}
		if (Class357.smethod_48() || Class357.smethod_50() || Class357.smethod_52() || Class357.smethod_54() || Class357.smethod_66() || Class357.smethod_60() || Class357.smethod_62() || Class357.smethod_64() || Class357.smethod_68())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141158519), 184);
		}
		if (Class357.smethod_64())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207873), 0);
		}
		if (Class357.smethod_64())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207904), 64);
		}
		if (Class357.smethod_60())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207915), 0);
		}
		if (Class357.smethod_60())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207941), 32);
		}
		if (Class357.smethod_60())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207957), 40);
		}
		if (Class357.smethod_60())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207970), 32);
		}
		if (Class357.smethod_48())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207997), 0);
		}
		if (Class357.smethod_48())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208010), 120);
		}
		if (Class357.smethod_48())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208028), 244);
		}
		if (Class357.smethod_50())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208056), 0);
		}
		if (Class357.smethod_50())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207044), 64);
		}
		if (Class357.smethod_50())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207072), 24);
		}
		if (Class357.smethod_52())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207075), 0);
		}
		if (Class357.smethod_52())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207100), 332);
		}
		if (Class357.smethod_52())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207128), 48);
		}
		if (Class357.smethod_54() || Class357.smethod_62())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141161838), 0);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141161893), 40);
		}
		if (Class357.smethod_54() || Class357.smethod_62())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141161949), 48);
		}
		if (Class357.smethod_62() || Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207143), 48);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141160981), 40);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141161026), 16);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141161087), 24);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141161141), 104);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141161186), 16);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141161247), 20);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141161304), 57);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141161366), 282);
		}
		if (Class357.smethod_54())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141161417), 382);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207167), 570);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207180), 380);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207214), 376);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207226), 368);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207244), 16);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207272), 18);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207289), 20);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207315), 16);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207337), 20);
		}
		if (Class357.smethod_56())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207361), 32);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207385), 16);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207413), 20);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207427), 21);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207454), 22);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207467), 24);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207484), 32);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207498), 16);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207527), 20);
		}
		if (Class357.smethod_58())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141207543), 21);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141140928), 0);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141137964), 152);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141138031), 176);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141138088), 8);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141140992), 0);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141138132), 16);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141138186), 17);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141138241), 24);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141138297), 18);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141138353), 20);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141138415), 22);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141137446), 23);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141137502), 32);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141137558), 16);
		}
		if (Class357.smethod_66())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141137613), 24);
		}
		if (Class357.smethod_22())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208589), 12);
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208596), 16);
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208622), 4);
		}
		if (Class357.smethod_24())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208638), 2);
		}
		if (Class357.smethod_28())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208644), 24);
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208666), 84);
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208696), 176);
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208718), 240);
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208732), 150);
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208760), 110);
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208772), 150);
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208800), 150);
		}
		if (Class357.smethod_32())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208812), 6);
		}
		if (Class357.smethod_34())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208826), 2);
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208848), 2999);
		}
		if (Class357.smethod_38())
		{
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208864), 3);
			smethod_1(stringBuilder_0, Class185.smethod_0(-1141208879), 4);
		}
	}
}
