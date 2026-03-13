using System;
using System.Text;

namespace SimpleJSON
{
	// Token: 0x02000023 RID: 35
	internal class JSONLazyCreator : JSONNode
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00010118 File Offset: 0x0000E318
		public override JSONNodeType Tag
		{
			get
			{
				return (JSONNodeType)0;
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00010130 File Offset: 0x0000E330
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000C883 File Offset: 0x0000AA83
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000C88B File Offset: 0x0000AA8B
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000C893 File Offset: 0x0000AA93
		private void Set(JSONNode aVal)
		{
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000C895 File Offset: 0x0000AA95
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x0000C898 File Offset: 0x0000AA98
		public override JSONNode Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0000C89A File Offset: 0x0000AA9A
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0000C89D File Offset: 0x0000AA9D
		public override JSONNode Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000C89F File Offset: 0x0000AA9F
		public override void Add(JSONNode aItem)
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000C8A1 File Offset: 0x0000AAA1
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000C8A3 File Offset: 0x0000AAA3
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return false;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000C8A6 File Offset: 0x0000AAA6
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return false;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000C8A9 File Offset: 0x0000AAA9
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000C8AC File Offset: 0x0000AAAC
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0000C8AF File Offset: 0x0000AAAF
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x0000C8B2 File Offset: 0x0000AAB2
		public override int AsInt
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000C8B4 File Offset: 0x0000AAB4
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x0000C8BB File Offset: 0x0000AABB
		public override float AsFloat
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000C8BD File Offset: 0x0000AABD
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x0000C8C8 File Offset: 0x0000AAC8
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

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0000C8CA File Offset: 0x0000AACA
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x0000C8CD File Offset: 0x0000AACD
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

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000C8CF File Offset: 0x0000AACF
		public override JSONArray AsArray
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0000C8D2 File Offset: 0x0000AAD2
		public override JSONObject AsObject
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000C8D5 File Offset: 0x0000AAD5
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		// Token: 0x0400014A RID: 330
		private JSONNode m_Node;

		// Token: 0x0400014B RID: 331
		private string m_Key;
	}
}
