using System;
using System.Text;

namespace SimpleJSON
{
	// Token: 0x02000020 RID: 32
	public class JSONNumber : JSONNode
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00010088 File Offset: 0x0000E288
		public override JSONNodeType Tag
		{
			get
			{
				return (JSONNodeType)0;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0000C80C File Offset: 0x0000AA0C
		public override bool IsNumber
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000100A0 File Offset: 0x0000E2A0
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0000C80F File Offset: 0x0000AA0F
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x0000C812 File Offset: 0x0000AA12
		public override string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0000C814 File Offset: 0x0000AA14
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x0000C81F File Offset: 0x0000AA1F
		public override double AsDouble
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000C821 File Offset: 0x0000AA21
		public JSONNumber(double aData)
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000C829 File Offset: 0x0000AA29
		public JSONNumber(string aData)
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000C831 File Offset: 0x0000AA31
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000C833 File Offset: 0x0000AA33
		private static bool IsNumeric(object value)
		{
			return false;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000C836 File Offset: 0x0000AA36
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000C839 File Offset: 0x0000AA39
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000146 RID: 326
		private double m_Data;
	}
}
