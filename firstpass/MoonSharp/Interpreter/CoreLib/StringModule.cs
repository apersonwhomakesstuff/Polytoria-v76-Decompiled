using System;

namespace MoonSharp.Interpreter.CoreLib
{
	// Token: 0x02000115 RID: 277
	public class StringModule
	{
		// Token: 0x06000C74 RID: 3188 RVA: 0x0000ECDB File Offset: 0x0000CEDB
		public static void MoonSharpInit(Table globalTable, Table stringTable)
		{
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0000ECDD File Offset: 0x0000CEDD
		public static DynValue dump(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0000ECE0 File Offset: 0x0000CEE0
		public static DynValue @char(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0000ECE3 File Offset: 0x0000CEE3
		public static DynValue @byte(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0000ECE6 File Offset: 0x0000CEE6
		public static DynValue unicode(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0000ECE9 File Offset: 0x0000CEE9
		private static int Unicode2Ascii(int i)
		{
			return 0;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0000ECEC File Offset: 0x0000CEEC
		private static DynValue PerformByteLike(DynValue vs, DynValue vi, DynValue vj, Func<int, int> filter)
		{
			return null;
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00010640 File Offset: 0x0000E840
		private static int? AdjustIndex(string s, DynValue vi, int defval)
		{
			return null;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0000ECEF File Offset: 0x0000CEEF
		public static DynValue len(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0000ECF2 File Offset: 0x0000CEF2
		public static DynValue match(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0000ECF5 File Offset: 0x0000CEF5
		public static DynValue gmatch(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0000ECF8 File Offset: 0x0000CEF8
		public static DynValue gsub(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0000ECFB File Offset: 0x0000CEFB
		public static DynValue find(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0000ECFE File Offset: 0x0000CEFE
		public static DynValue lower(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0000ED01 File Offset: 0x0000CF01
		public static DynValue upper(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0000ED04 File Offset: 0x0000CF04
		public static DynValue rep(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0000ED07 File Offset: 0x0000CF07
		public static DynValue format(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0000ED0A File Offset: 0x0000CF0A
		public static DynValue reverse(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0000ED0D File Offset: 0x0000CF0D
		public static DynValue sub(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x0000ED10 File Offset: 0x0000CF10
		public static DynValue startsWith(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x0000ED13 File Offset: 0x0000CF13
		public static DynValue endsWith(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0000ED16 File Offset: 0x0000CF16
		public static DynValue contains(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x040004A6 RID: 1190
		public const string BASE64_DUMP_HEADER = "MoonSharp_dump_b64::";

		// Token: 0x020001D3 RID: 467
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600105A RID: 4186 RVA: 0x0000F835 File Offset: 0x0000DA35
			internal int <byte>b__4_0(int i)
			{
				return 0;
			}

			// Token: 0x0600105B RID: 4187 RVA: 0x0000F838 File Offset: 0x0000DA38
			internal int <unicode>b__5_0(int i)
			{
				return 0;
			}

			// Token: 0x04000748 RID: 1864
			public static readonly StringModule.<>c <>9;

			// Token: 0x04000749 RID: 1865
			public static Func<int, int> <>9__4_0;

			// Token: 0x0400074A RID: 1866
			public static Func<int, int> <>9__5_0;
		}
	}
}
