using System;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x02000109 RID: 265
	public class Bit32Module
	{
		// Token: 0x06000BDE RID: 3038 RVA: 0x0000EAF2 File Offset: 0x0000CCF2
		private static uint ToUInt32(DynValue v)
		{
			return 0U;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0000EAF5 File Offset: 0x0000CCF5
		private static int ToInt32(DynValue v)
		{
			return 0;
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0000EAF8 File Offset: 0x0000CCF8
		private static uint NBitMask(int bits)
		{
			return 0U;
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0000EAFB File Offset: 0x0000CCFB
		public static uint Bitwise(string funcName, CallbackArguments args, Func<uint, uint, uint> accumFunc)
		{
			return 0U;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0000EAFE File Offset: 0x0000CCFE
		public static DynValue extract(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0000EB01 File Offset: 0x0000CD01
		public static DynValue replace(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0000EB04 File Offset: 0x0000CD04
		private static void ValidatePosWidth(string func, int argPos, int pos, int width)
		{
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0000EB06 File Offset: 0x0000CD06
		public static DynValue arshift(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x0000EB09 File Offset: 0x0000CD09
		public static DynValue rshift(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0000EB0C File Offset: 0x0000CD0C
		public static DynValue lshift(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0000EB0F File Offset: 0x0000CD0F
		public static DynValue band(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0000EB12 File Offset: 0x0000CD12
		public static DynValue btest(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0000EB15 File Offset: 0x0000CD15
		public static DynValue bor(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0000EB18 File Offset: 0x0000CD18
		public static DynValue bnot(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x0000EB1B File Offset: 0x0000CD1B
		public static DynValue bxor(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0000EB1E File Offset: 0x0000CD1E
		public static DynValue lrotate(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0000EB21 File Offset: 0x0000CD21
		public static DynValue rrotate(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x040004A0 RID: 1184
		private static readonly uint[] MASKS;

		// Token: 0x020001CF RID: 463
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001037 RID: 4151 RVA: 0x0000F703 File Offset: 0x0000D903
			internal uint <band>b__11_0(uint x, uint y)
			{
				return 0U;
			}

			// Token: 0x06001038 RID: 4152 RVA: 0x0000F706 File Offset: 0x0000D906
			internal uint <btest>b__12_0(uint x, uint y)
			{
				return 0U;
			}

			// Token: 0x06001039 RID: 4153 RVA: 0x0000F709 File Offset: 0x0000D909
			internal uint <bor>b__13_0(uint x, uint y)
			{
				return 0U;
			}

			// Token: 0x0600103A RID: 4154 RVA: 0x0000F70C File Offset: 0x0000D90C
			internal uint <bxor>b__15_0(uint x, uint y)
			{
				return 0U;
			}

			// Token: 0x04000728 RID: 1832
			public static readonly Bit32Module.<>c <>9;

			// Token: 0x04000729 RID: 1833
			public static Func<uint, uint, uint> <>9__11_0;

			// Token: 0x0400072A RID: 1834
			public static Func<uint, uint, uint> <>9__12_0;

			// Token: 0x0400072B RID: 1835
			public static Func<uint, uint, uint> <>9__13_0;

			// Token: 0x0400072C RID: 1836
			public static Func<uint, uint, uint> <>9__15_0;
		}
	}
}
