using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SimpleJSON
{
	// Token: 0x0200001E RID: 30
	public class JSONObject : JSONNode
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000393 RID: 915 RVA: 0x0000C7C7 File Offset: 0x0000A9C7
		// (set) Token: 0x06000394 RID: 916 RVA: 0x0000C7CA File Offset: 0x0000A9CA
		public override bool Inline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00010028 File Offset: 0x0000E228
		public override JSONNodeType Tag
		{
			get
			{
				return (JSONNodeType)0;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0000C7CC File Offset: 0x0000A9CC
		public override bool IsObject
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00010040 File Offset: 0x0000E240
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0000C7CF File Offset: 0x0000A9CF
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0000C7D2 File Offset: 0x0000A9D2
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0000C7D7 File Offset: 0x0000A9D7
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

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000C7D9 File Offset: 0x0000A9D9
		public override int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000C7DC File Offset: 0x0000A9DC
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000C7DE File Offset: 0x0000A9DE
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000C7E1 File Offset: 0x0000A9E1
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000C7E4 File Offset: 0x0000A9E4
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000C7E7 File Offset: 0x0000A9E7
		public override IEnumerable<JSONNode> Children
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000C7EA File Offset: 0x0000A9EA
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		// Token: 0x04000143 RID: 323
		private Dictionary<string, JSONNode> m_Dict;

		// Token: 0x04000144 RID: 324
		private bool inline;

		// Token: 0x02000179 RID: 377
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06000EE5 RID: 3813 RVA: 0x0000F2DC File Offset: 0x0000D4DC
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return false;
			}

			// Token: 0x04000627 RID: 1575
			public JSONNode aNode;
		}

		// Token: 0x0200017A RID: 378
		private sealed class <get_Children>d__23 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			// Token: 0x06000EE6 RID: 3814 RVA: 0x0000F2DF File Offset: 0x0000D4DF
			public <get_Children>d__23(int <>1__state)
			{
			}

			// Token: 0x06000EE7 RID: 3815 RVA: 0x0000F2E7 File Offset: 0x0000D4E7
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06000EE8 RID: 3816 RVA: 0x0000F2E9 File Offset: 0x0000D4E9
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06000EE9 RID: 3817 RVA: 0x0000F2EC File Offset: 0x0000D4EC
			private void <>m__Finally1()
			{
			}

			// Token: 0x170001DD RID: 477
			// (get) Token: 0x06000EEA RID: 3818 RVA: 0x0000F2EE File Offset: 0x0000D4EE
			JSONNode IEnumerator<JSONNode>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000EEB RID: 3819 RVA: 0x0000F2F1 File Offset: 0x0000D4F1
			void IEnumerator.Reset()
			{
			}

			// Token: 0x170001DE RID: 478
			// (get) Token: 0x06000EEC RID: 3820 RVA: 0x0000F2F3 File Offset: 0x0000D4F3
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000EED RID: 3821 RVA: 0x0000F2F6 File Offset: 0x0000D4F6
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000EEE RID: 3822 RVA: 0x0000F2F9 File Offset: 0x0000D4F9
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000628 RID: 1576
			private int <>1__state;

			// Token: 0x04000629 RID: 1577
			private JSONNode <>2__current;

			// Token: 0x0400062A RID: 1578
			private int <>l__initialThreadId;

			// Token: 0x0400062B RID: 1579
			public JSONObject <>4__this;

			// Token: 0x0400062C RID: 1580
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;
		}
	}
}
