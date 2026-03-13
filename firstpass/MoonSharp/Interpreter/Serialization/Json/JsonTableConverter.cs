using System;
using System.Text;
using MoonSharp.Interpreter.Tree;

namespace MoonSharp.Interpreter.Serialization.Json
{
	// Token: 0x02000083 RID: 131
	public static class JsonTableConverter
	{
		// Token: 0x060006E9 RID: 1769 RVA: 0x0000D681 File Offset: 0x0000B881
		public static string TableToJson(Table table)
		{
			return null;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0000D684 File Offset: 0x0000B884
		private static void TableToJson(StringBuilder sb, Table table)
		{
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0000D686 File Offset: 0x0000B886
		public static string ObjectToJson(object obj)
		{
			return null;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0000D689 File Offset: 0x0000B889
		private static void ValueToJson(StringBuilder sb, DynValue value)
		{
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0000D68B File Offset: 0x0000B88B
		private static string EscapeString(string s)
		{
			return null;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0000D68E File Offset: 0x0000B88E
		private static bool IsValueJsonCompatible(DynValue value)
		{
			return false;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0000D691 File Offset: 0x0000B891
		public static Table JsonToTable(string json, Script script = null)
		{
			return null;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0000D694 File Offset: 0x0000B894
		private static void AssertToken(Lexer L, TokenType type)
		{
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0000D696 File Offset: 0x0000B896
		private static Table ParseJsonArray(Lexer L, Script script)
		{
			return null;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0000D699 File Offset: 0x0000B899
		private static Table ParseJsonObject(Lexer L, Script script)
		{
			return null;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0000D69C File Offset: 0x0000B89C
		private static DynValue ParseJsonValue(Lexer L, Script script)
		{
			return null;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0000D69F File Offset: 0x0000B89F
		private static DynValue ParseJsonNumberValue(Lexer L, Script script)
		{
			return null;
		}
	}
}
