using System;
using System.Text;

namespace SimpleJSON
{
	// Token: 0x02000021 RID: 33
	public class JSONBool : JSONNode
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060003BA RID: 954 RVA: 0x000100B8 File Offset: 0x0000E2B8
		public override JSONNodeType Tag
		{
			get
			{
				return (JSONNodeType)0;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0000C83C File Offset: 0x0000AA3C
		public override bool IsBoolean
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000100D0 File Offset: 0x0000E2D0
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000C83F File Offset: 0x0000AA3F
		// (set) Token: 0x060003BE RID: 958 RVA: 0x0000C842 File Offset: 0x0000AA42
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

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000C844 File Offset: 0x0000AA44
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x0000C847 File Offset: 0x0000AA47
		public override bool AsBool
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000C849 File Offset: 0x0000AA49
		public JSONBool(bool aData)
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000C851 File Offset: 0x0000AA51
		public JSONBool(string aData)
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000C859 File Offset: 0x0000AA59
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000C85B File Offset: 0x0000AA5B
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000C85E File Offset: 0x0000AA5E
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000147 RID: 327
		private bool m_Data;
	}
}
