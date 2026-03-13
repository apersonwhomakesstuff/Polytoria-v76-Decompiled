using System;
using MoonSharp.Interpreter.Interop.LuaStateInterop;

namespace MoonSharp.Interpreter.CoreLib.StringLib
{
	// Token: 0x0200011A RID: 282
	internal class KopiLua_StringLib : LuaBase
	{
		// Token: 0x06000C9D RID: 3229 RVA: 0x0000ED66 File Offset: 0x0000CF66
		private static int posrelat(int pos, uint len)
		{
			return 0;
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0000ED69 File Offset: 0x0000CF69
		private static int check_capture(KopiLua_StringLib.MatchState ms, int l)
		{
			return 0;
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0000ED6C File Offset: 0x0000CF6C
		private static int capture_to_close(KopiLua_StringLib.MatchState ms)
		{
			return 0;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0000ED6F File Offset: 0x0000CF6F
		private static CharPtr classend(KopiLua_StringLib.MatchState ms, CharPtr p)
		{
			return null;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0000ED72 File Offset: 0x0000CF72
		private static int match_class(char c, char cl)
		{
			return 0;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0000ED75 File Offset: 0x0000CF75
		private static int matchbracketclass(int c, CharPtr p, CharPtr ec)
		{
			return 0;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0000ED78 File Offset: 0x0000CF78
		private static int singlematch(int c, CharPtr p, CharPtr ep)
		{
			return 0;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0000ED7B File Offset: 0x0000CF7B
		private static CharPtr matchbalance(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p)
		{
			return null;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0000ED7E File Offset: 0x0000CF7E
		private static CharPtr max_expand(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p, CharPtr ep)
		{
			return null;
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0000ED81 File Offset: 0x0000CF81
		private static CharPtr min_expand(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p, CharPtr ep)
		{
			return null;
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0000ED84 File Offset: 0x0000CF84
		private static CharPtr start_capture(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p, int what)
		{
			return null;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x0000ED87 File Offset: 0x0000CF87
		private static CharPtr end_capture(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p)
		{
			return null;
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0000ED8A File Offset: 0x0000CF8A
		private static CharPtr match_capture(KopiLua_StringLib.MatchState ms, CharPtr s, int l)
		{
			return null;
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0000ED8D File Offset: 0x0000CF8D
		private static CharPtr match(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr p)
		{
			return null;
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0000ED90 File Offset: 0x0000CF90
		private static CharPtr lmemfind(CharPtr s1, uint l1, CharPtr s2, uint l2)
		{
			return null;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x0000ED93 File Offset: 0x0000CF93
		private static void push_onecapture(KopiLua_StringLib.MatchState ms, int i, CharPtr s, CharPtr e)
		{
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x0000ED95 File Offset: 0x0000CF95
		private static int push_captures(KopiLua_StringLib.MatchState ms, CharPtr s, CharPtr e)
		{
			return 0;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0000ED98 File Offset: 0x0000CF98
		private static int str_find_aux(LuaState L, int find)
		{
			return 0;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0000ED9B File Offset: 0x0000CF9B
		public static int str_find(LuaState L)
		{
			return 0;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0000ED9E File Offset: 0x0000CF9E
		public static int str_match(LuaState L)
		{
			return 0;
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0000EDA1 File Offset: 0x0000CFA1
		private static int gmatch_aux(LuaState L, KopiLua_StringLib.GMatchAuxData auxdata)
		{
			return 0;
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
		private static DynValue gmatch_aux_2(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0000EDA7 File Offset: 0x0000CFA7
		public static int str_gmatch(LuaState L)
		{
			return 0;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0000EDAA File Offset: 0x0000CFAA
		private static int gfind_nodef(LuaState L)
		{
			return 0;
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x0000EDAD File Offset: 0x0000CFAD
		private static void add_s(KopiLua_StringLib.MatchState ms, LuaLBuffer b, CharPtr s, CharPtr e)
		{
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x0000EDAF File Offset: 0x0000CFAF
		private static void add_value(KopiLua_StringLib.MatchState ms, LuaLBuffer b, CharPtr s, CharPtr e)
		{
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x0000EDB1 File Offset: 0x0000CFB1
		public static int str_gsub(LuaState L)
		{
			return 0;
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0000EDB4 File Offset: 0x0000CFB4
		private static void addquoted(LuaState L, LuaLBuffer b, int arg)
		{
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0000EDB6 File Offset: 0x0000CFB6
		private static CharPtr scanformat(LuaState L, CharPtr strfrmt, CharPtr form)
		{
			return null;
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0000EDB9 File Offset: 0x0000CFB9
		private static void addintlen(CharPtr form)
		{
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0000EDBB File Offset: 0x0000CFBB
		public static int str_format(LuaState L)
		{
			return 0;
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x0000EDBE File Offset: 0x0000CFBE
		private static string PatchPattern(string charPtr)
		{
			return null;
		}

		// Token: 0x040004A7 RID: 1191
		public const int LUA_MAXCAPTURES = 32;

		// Token: 0x040004A8 RID: 1192
		public const int CAP_UNFINISHED = -1;

		// Token: 0x040004A9 RID: 1193
		public const int CAP_POSITION = -2;

		// Token: 0x040004AA RID: 1194
		public const int MAXCCALLS = 200;

		// Token: 0x040004AB RID: 1195
		public const char L_ESC = '%';

		// Token: 0x040004AC RID: 1196
		public const string SPECIALS = "^$*+?.([%-";

		// Token: 0x040004AD RID: 1197
		public const int MAX_ITEM = 512;

		// Token: 0x040004AE RID: 1198
		public const string FLAGS = "-+ #0";

		// Token: 0x040004AF RID: 1199
		public static readonly int MAX_FORMAT;

		// Token: 0x020001D5 RID: 469
		public class MatchState
		{
			// Token: 0x0400074D RID: 1869
			public int matchdepth;

			// Token: 0x0400074E RID: 1870
			public CharPtr src_init;

			// Token: 0x0400074F RID: 1871
			public CharPtr src_end;

			// Token: 0x04000750 RID: 1872
			public LuaState L;

			// Token: 0x04000751 RID: 1873
			public int level;

			// Token: 0x04000752 RID: 1874
			public KopiLua_StringLib.MatchState.capture_[] capture;

			// Token: 0x02000237 RID: 567
			public class capture_
			{
				// Token: 0x04000822 RID: 2082
				public CharPtr init;

				// Token: 0x04000823 RID: 2083
				public int len;
			}
		}

		// Token: 0x020001D6 RID: 470
		private class GMatchAuxData
		{
			// Token: 0x04000753 RID: 1875
			public CharPtr S;

			// Token: 0x04000754 RID: 1876
			public CharPtr P;

			// Token: 0x04000755 RID: 1877
			public uint LS;

			// Token: 0x04000756 RID: 1878
			public uint POS;
		}

		// Token: 0x020001D7 RID: 471
		private sealed class <>c__DisplayClass29_0
		{
			// Token: 0x06001061 RID: 4193 RVA: 0x0000F85E File Offset: 0x0000DA5E
			internal int <gmatch_aux_2>b__0(LuaState L)
			{
				return 0;
			}

			// Token: 0x04000757 RID: 1879
			public ScriptExecutionContext executionContext;
		}
	}
}
