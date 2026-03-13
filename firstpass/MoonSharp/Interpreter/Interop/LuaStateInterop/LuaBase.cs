using System;

namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
	// Token: 0x020000CA RID: 202
	public class LuaBase
	{
		// Token: 0x06000950 RID: 2384 RVA: 0x0000E06D File Offset: 0x0000C26D
		protected static DynValue GetArgument(LuaState L, int pos)
		{
			return null;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0000E070 File Offset: 0x0000C270
		protected static DynValue ArgAsType(LuaState L, int pos, DataType type, bool allowNil = false)
		{
			return null;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0000E073 File Offset: 0x0000C273
		protected static int LuaType(LuaState L, int p)
		{
			return 0;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0000E076 File Offset: 0x0000C276
		protected static string LuaLCheckLString(LuaState L, int argNum, out uint l)
		{
			l = 0U;
			return null;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0000E080 File Offset: 0x0000C280
		protected static void LuaPushInteger(LuaState L, int val)
		{
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0000E082 File Offset: 0x0000C282
		protected static int LuaToBoolean(LuaState L, int p)
		{
			return 0;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0000E085 File Offset: 0x0000C285
		protected static string LuaToLString(LuaState luaState, int p, out uint l)
		{
			l = 0U;
			return null;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0000E08F File Offset: 0x0000C28F
		protected static string LuaToString(LuaState luaState, int p)
		{
			return null;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0000E092 File Offset: 0x0000C292
		protected static void LuaLAddValue(LuaLBuffer b)
		{
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0000E094 File Offset: 0x0000C294
		protected static void LuaLAddLString(LuaLBuffer b, CharPtr s, uint p)
		{
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0000E096 File Offset: 0x0000C296
		protected static void LuaLAddString(LuaLBuffer b, string s)
		{
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0000E098 File Offset: 0x0000C298
		protected static int LuaLOptInteger(LuaState L, int pos, int def)
		{
			return 0;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0000E09B File Offset: 0x0000C29B
		protected static int LuaLCheckInteger(LuaState L, int pos)
		{
			return 0;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0000E09E File Offset: 0x0000C29E
		protected static void LuaLArgCheck(LuaState L, bool condition, int argNum, string message)
		{
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		protected static int LuaLCheckInt(LuaState L, int argNum)
		{
			return 0;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0000E0A3 File Offset: 0x0000C2A3
		protected static int LuaGetTop(LuaState L)
		{
			return 0;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0000E0A6 File Offset: 0x0000C2A6
		protected static int LuaLError(LuaState luaState, string message, object[] args)
		{
			return 0;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0000E0A9 File Offset: 0x0000C2A9
		protected static void LuaLAddChar(LuaLBuffer b, char p)
		{
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0000E0AB File Offset: 0x0000C2AB
		protected static void LuaLBuffInit(LuaState L, LuaLBuffer b)
		{
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0000E0AD File Offset: 0x0000C2AD
		protected static void LuaPushLiteral(LuaState L, string literalString)
		{
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0000E0AF File Offset: 0x0000C2AF
		protected static void LuaLPushResult(LuaLBuffer b)
		{
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0000E0B1 File Offset: 0x0000C2B1
		protected static void LuaPushLString(LuaState L, CharPtr s, uint len)
		{
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0000E0B3 File Offset: 0x0000C2B3
		protected static void LuaLCheckStack(LuaState L, int n, string message)
		{
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0000E0B5 File Offset: 0x0000C2B5
		protected static string LUA_QL(string p)
		{
			return null;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		protected static void LuaPushNil(LuaState L)
		{
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0000E0BA File Offset: 0x0000C2BA
		protected static void LuaAssert(bool p)
		{
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0000E0BC File Offset: 0x0000C2BC
		protected static string LuaLTypeName(LuaState L, int p)
		{
			return null;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0000E0BF File Offset: 0x0000C2BF
		protected static int LuaIsString(LuaState L, int p)
		{
			return 0;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0000E0C2 File Offset: 0x0000C2C2
		protected static void LuaPop(LuaState L, int p)
		{
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0000E0C4 File Offset: 0x0000C2C4
		protected static void LuaGetTable(LuaState L, int p)
		{
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0000E0C6 File Offset: 0x0000C2C6
		protected static int LuaLOptInt(LuaState L, int pos, int def)
		{
			return 0;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0000E0C9 File Offset: 0x0000C2C9
		protected static CharPtr LuaLCheckString(LuaState L, int p)
		{
			return null;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0000E0CC File Offset: 0x0000C2CC
		protected static string LuaLCheckStringStr(LuaState L, int p)
		{
			return null;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0000E0CF File Offset: 0x0000C2CF
		protected static void LuaLArgError(LuaState L, int arg, string p)
		{
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0000E0D1 File Offset: 0x0000C2D1
		protected static double LuaLCheckNumber(LuaState L, int pos)
		{
			return 0.0;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0000E0DC File Offset: 0x0000C2DC
		protected static void LuaPushValue(LuaState L, int arg)
		{
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0000E0DE File Offset: 0x0000C2DE
		protected static void LuaCall(LuaState L, int nargs, int nresults = -1)
		{
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0000E0E0 File Offset: 0x0000C2E0
		protected static int memcmp(CharPtr ptr1, CharPtr ptr2, uint size)
		{
			return 0;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0000E0E3 File Offset: 0x0000C2E3
		protected static int memcmp(CharPtr ptr1, CharPtr ptr2, int size)
		{
			return 0;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0000E0E6 File Offset: 0x0000C2E6
		protected static CharPtr memchr(CharPtr ptr, char c, uint count)
		{
			return null;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0000E0E9 File Offset: 0x0000C2E9
		protected static CharPtr strpbrk(CharPtr str, CharPtr charset)
		{
			return null;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0000E0EC File Offset: 0x0000C2EC
		protected static bool isalpha(char c)
		{
			return false;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0000E0EF File Offset: 0x0000C2EF
		protected static bool iscntrl(char c)
		{
			return false;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0000E0F2 File Offset: 0x0000C2F2
		protected static bool isdigit(char c)
		{
			return false;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0000E0F5 File Offset: 0x0000C2F5
		protected static bool islower(char c)
		{
			return false;
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0000E0F8 File Offset: 0x0000C2F8
		protected static bool ispunct(char c)
		{
			return false;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0000E0FB File Offset: 0x0000C2FB
		protected static bool isspace(char c)
		{
			return false;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0000E0FE File Offset: 0x0000C2FE
		protected static bool isupper(char c)
		{
			return false;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0000E101 File Offset: 0x0000C301
		protected static bool isalnum(char c)
		{
			return false;
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0000E104 File Offset: 0x0000C304
		protected static bool isxdigit(char c)
		{
			return false;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0000E107 File Offset: 0x0000C307
		protected static bool isgraph(char c)
		{
			return false;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0000E10A File Offset: 0x0000C30A
		protected static bool isalpha(int c)
		{
			return false;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0000E10D File Offset: 0x0000C30D
		protected static bool iscntrl(int c)
		{
			return false;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0000E110 File Offset: 0x0000C310
		protected static bool isdigit(int c)
		{
			return false;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0000E113 File Offset: 0x0000C313
		protected static bool islower(int c)
		{
			return false;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0000E116 File Offset: 0x0000C316
		protected static bool ispunct(int c)
		{
			return false;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0000E119 File Offset: 0x0000C319
		protected static bool isspace(int c)
		{
			return false;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0000E11C File Offset: 0x0000C31C
		protected static bool isupper(int c)
		{
			return false;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0000E11F File Offset: 0x0000C31F
		protected static bool isalnum(int c)
		{
			return false;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0000E122 File Offset: 0x0000C322
		protected static bool isgraph(int c)
		{
			return false;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0000E125 File Offset: 0x0000C325
		protected static char tolower(char c)
		{
			return '\0';
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0000E128 File Offset: 0x0000C328
		protected static char toupper(char c)
		{
			return '\0';
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0000E12B File Offset: 0x0000C32B
		protected static char tolower(int c)
		{
			return '\0';
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0000E12E File Offset: 0x0000C32E
		protected static char toupper(int c)
		{
			return '\0';
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0000E131 File Offset: 0x0000C331
		protected static CharPtr strchr(CharPtr str, char c)
		{
			return null;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0000E134 File Offset: 0x0000C334
		protected static CharPtr strcpy(CharPtr dst, CharPtr src)
		{
			return null;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0000E137 File Offset: 0x0000C337
		protected static CharPtr strncpy(CharPtr dst, CharPtr src, int length)
		{
			return null;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0000E13A File Offset: 0x0000C33A
		protected static int strlen(CharPtr str)
		{
			return 0;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0000E13D File Offset: 0x0000C33D
		public static void sprintf(CharPtr buffer, CharPtr str, object[] argv)
		{
		}

		// Token: 0x0400037B RID: 891
		protected const int LUA_TNONE = -1;

		// Token: 0x0400037C RID: 892
		protected const int LUA_TNIL = 0;

		// Token: 0x0400037D RID: 893
		protected const int LUA_TBOOLEAN = 1;

		// Token: 0x0400037E RID: 894
		protected const int LUA_TLIGHTUSERDATA = 2;

		// Token: 0x0400037F RID: 895
		protected const int LUA_TNUMBER = 3;

		// Token: 0x04000380 RID: 896
		protected const int LUA_TSTRING = 4;

		// Token: 0x04000381 RID: 897
		protected const int LUA_TTABLE = 5;

		// Token: 0x04000382 RID: 898
		protected const int LUA_TFUNCTION = 6;

		// Token: 0x04000383 RID: 899
		protected const int LUA_TUSERDATA = 7;

		// Token: 0x04000384 RID: 900
		protected const int LUA_TTHREAD = 8;

		// Token: 0x04000385 RID: 901
		protected const int LUA_MULTRET = -1;

		// Token: 0x04000386 RID: 902
		protected const string LUA_INTFRMLEN = "l";
	}
}
