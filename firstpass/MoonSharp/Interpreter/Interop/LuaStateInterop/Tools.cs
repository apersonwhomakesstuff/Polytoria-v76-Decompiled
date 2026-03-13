using System;
using System.IO;
using System.Text.RegularExpressions;

namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
	// Token: 0x020000CD RID: 205
	internal static class Tools
	{
		// Token: 0x060009A8 RID: 2472 RVA: 0x0000E1B1 File Offset: 0x0000C3B1
		public static bool IsNumericType(object o)
		{
			return false;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0000E1B4 File Offset: 0x0000C3B4
		public static bool IsPositive(object Value, bool ZeroIsPositive)
		{
			return false;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0000E1B7 File Offset: 0x0000C3B7
		public static object ToUnsigned(object Value)
		{
			return null;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0000E1BA File Offset: 0x0000C3BA
		public static object ToInteger(object Value, bool Round)
		{
			return null;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0000E1BD File Offset: 0x0000C3BD
		public static long UnboxToLong(object Value, bool Round)
		{
			return 0L;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0000E1C1 File Offset: 0x0000C3C1
		public static string ReplaceMetaChars(string input)
		{
			return null;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0000E1C4 File Offset: 0x0000C3C4
		private static string ReplaceMetaCharsMatch(Match m)
		{
			return null;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0000E1C7 File Offset: 0x0000C3C7
		public static void fprintf(TextWriter Destination, string Format, object[] Parameters)
		{
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0000E1C9 File Offset: 0x0000C3C9
		public static string sprintf(string Format, object[] Parameters)
		{
			return null;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0000E1CC File Offset: 0x0000C3CC
		private static string FormatOct(string NativeFormat, bool Alternate, int FieldLength, int FieldPrecision, bool Left2Right, char Padding, object Value)
		{
			return null;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0000E1CF File Offset: 0x0000C3CF
		private static string FormatHex(string NativeFormat, bool Alternate, int FieldLength, int FieldPrecision, bool Left2Right, char Padding, object Value)
		{
			return null;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0000E1D2 File Offset: 0x0000C3D2
		private static string FormatNumber(string NativeFormat, bool Alternate, int FieldLength, int FieldPrecision, bool Left2Right, bool PositiveSign, bool PositiveSpace, char Padding, object Value)
		{
			return null;
		}

		// Token: 0x0400038C RID: 908
		internal static Regex r;
	}
}
