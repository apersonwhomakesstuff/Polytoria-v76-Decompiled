using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SimpleJSON
{
	// Token: 0x0200001D RID: 29
	public class JSONArray : JSONNode
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0000C79D File Offset: 0x0000A99D
		// (set) Token: 0x06000384 RID: 900 RVA: 0x0000C7A0 File Offset: 0x0000A9A0
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

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0000FFF8 File Offset: 0x0000E1F8
		public override JSONNodeType Tag
		{
			get
			{
				return (JSONNodeType)0;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000C7A2 File Offset: 0x0000A9A2
		public override bool IsArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00010010 File Offset: 0x0000E210
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0000C7A5 File Offset: 0x0000A9A5
		// (set) Token: 0x06000389 RID: 905 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
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

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0000C7AA File Offset: 0x0000A9AA
		// (set) Token: 0x0600038B RID: 907 RVA: 0x0000C7AD File Offset: 0x0000A9AD
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

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0000C7AF File Offset: 0x0000A9AF
		public override int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000C7B2 File Offset: 0x0000A9B2
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000C7B4 File Offset: 0x0000A9B4
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000C7B7 File Offset: 0x0000A9B7
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0000C7BA File Offset: 0x0000A9BA
		public override IEnumerable<JSONNode> Children
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000C7BD File Offset: 0x0000A9BD
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		// Token: 0x04000141 RID: 321
		private List<JSONNode> m_List;

		// Token: 0x04000142 RID: 322
		private bool inline;

		// Token: 0x02000178 RID: 376
		private sealed class <get_Children>d__22 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			// Token: 0x06000EDB RID: 3803 RVA: 0x0000F2B7 File Offset: 0x0000D4B7
			public <get_Children>d__22(int <>1__state)
			{
			}

			// Token: 0x06000EDC RID: 3804 RVA: 0x0000F2BF File Offset: 0x0000D4BF
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06000EDD RID: 3805 RVA: 0x0000F2C1 File Offset: 0x0000D4C1
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06000EDE RID: 3806 RVA: 0x0000F2C4 File Offset: 0x0000D4C4
			private void <>m__Finally1()
			{
			}

			// Token: 0x170001DB RID: 475
			// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0000F2C6 File Offset: 0x0000D4C6
			JSONNode IEnumerator<JSONNode>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000EE0 RID: 3808 RVA: 0x0000F2C9 File Offset: 0x0000D4C9
			void IEnumerator.Reset()
			{
			}

			// Token: 0x170001DC RID: 476
			// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x0000F2CB File Offset: 0x0000D4CB
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000EE2 RID: 3810 RVA: 0x0000F2CE File Offset: 0x0000D4CE
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000EE3 RID: 3811 RVA: 0x0000F2D1 File Offset: 0x0000D4D1
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000622 RID: 1570
			private int <>1__state;

			// Token: 0x04000623 RID: 1571
			private JSONNode <>2__current;

			// Token: 0x04000624 RID: 1572
			private int <>l__initialThreadId;

			// Token: 0x04000625 RID: 1573
			public JSONArray <>4__this;

			// Token: 0x04000626 RID: 1574
			private List<JSONNode>.Enumerator <>7__wrap1;
		}
	}
}
