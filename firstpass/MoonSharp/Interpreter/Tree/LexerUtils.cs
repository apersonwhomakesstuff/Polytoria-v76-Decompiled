using System;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x0200005D RID: 93
	internal static class LexerUtils
	{
		// Token: 0x06000627 RID: 1575 RVA: 0x0000D2AE File Offset: 0x0000B4AE
		public static double ParseNumber(Token T)
		{
			return 0.0;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0000D2B9 File Offset: 0x0000B4B9
		public static double ParseHexInteger(Token T)
		{
			return 0.0;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0000D2C4 File Offset: 0x0000B4C4
		public static string ReadHexProgressive(string s, ref double d, out int digits)
		{
			digits = 0;
			return null;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0000D2CE File Offset: 0x0000B4CE
		public static double ParseHexFloat(Token T)
		{
			return 0.0;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0000D2D9 File Offset: 0x0000B4D9
		public static int HexDigit2Value(char c)
		{
			return 0;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0000D2DC File Offset: 0x0000B4DC
		public static bool CharIsHexDigit(char c)
		{
			return false;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0000D2DF File Offset: 0x0000B4DF
		public static string AdjustLuaLongString(string str)
		{
			return null;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0000D2E2 File Offset: 0x0000B4E2
		public static string UnescapeLuaString(Token token, string str)
		{
			return null;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0000D2E5 File Offset: 0x0000B4E5
		private static string ConvertUtf32ToChar(int i)
		{
			return null;
		}
	}
}
