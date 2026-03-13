using System;
using System.Text;

namespace SimpleJSON
{
	// Token: 0x02000022 RID: 34
	public class JSONNull : JSONNode
	{
		// Token: 0x060003C6 RID: 966 RVA: 0x0000C861 File Offset: 0x0000AA61
		public static JSONNull CreateOrGet()
		{
			return null;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000C864 File Offset: 0x0000AA64
		private JSONNull()
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x000100E8 File Offset: 0x0000E2E8
		public override JSONNodeType Tag
		{
			get
			{
				return (JSONNodeType)0;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0000C86C File Offset: 0x0000AA6C
		public override bool IsNull
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00010100 File Offset: 0x0000E300
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0000C86F File Offset: 0x0000AA6F
		// (set) Token: 0x060003CC RID: 972 RVA: 0x0000C872 File Offset: 0x0000AA72
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0000C874 File Offset: 0x0000AA74
		// (set) Token: 0x060003CE RID: 974 RVA: 0x0000C877 File Offset: 0x0000AA77
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

		// Token: 0x060003CF RID: 975 RVA: 0x0000C879 File Offset: 0x0000AA79
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000C87C File Offset: 0x0000AA7C
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000C87F File Offset: 0x0000AA7F
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		// Token: 0x04000148 RID: 328
		private static JSONNull m_StaticInstance;

		// Token: 0x04000149 RID: 329
		public static bool reuseSameInstance;
	}
}
