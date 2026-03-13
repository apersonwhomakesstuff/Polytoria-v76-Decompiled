using System;
using System.Text;

namespace SimpleJSON
{
	// Token: 0x0200001F RID: 31
	public class JSONString : JSONNode
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00010058 File Offset: 0x0000E258
		public override JSONNodeType Tag
		{
			get
			{
				return (JSONNodeType)0;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		public override bool IsString
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00010070 File Offset: 0x0000E270
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x0000C7F7 File Offset: 0x0000A9F7
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x0000C7FA File Offset: 0x0000A9FA
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

		// Token: 0x060003A9 RID: 937 RVA: 0x0000C7FC File Offset: 0x0000A9FC
		public JSONString(string aData)
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000C804 File Offset: 0x0000AA04
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000C806 File Offset: 0x0000AA06
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000C809 File Offset: 0x0000AA09
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000145 RID: 325
		private string m_Data;
	}
}
