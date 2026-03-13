using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.DataStructs
{
	// Token: 0x02000104 RID: 260
	internal class LinkedListIndex<TKey, TValue>
	{
		// Token: 0x06000BAD RID: 2989 RVA: 0x0000EA51 File Offset: 0x0000CC51
		public LinkedListIndex(LinkedList<TValue> linkedList)
		{
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0000EA59 File Offset: 0x0000CC59
		public LinkedListNode<TValue> Find(TKey key)
		{
			return null;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x000105C8 File Offset: 0x0000E7C8
		public TValue Set(TKey key, TValue value)
		{
			return default(TValue);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0000EA5C File Offset: 0x0000CC5C
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0000EA5E File Offset: 0x0000CC5E
		public bool Remove(TKey key)
		{
			return false;
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0000EA61 File Offset: 0x0000CC61
		public bool ContainsKey(TKey key)
		{
			return false;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0000EA64 File Offset: 0x0000CC64
		public void Clear()
		{
		}

		// Token: 0x04000498 RID: 1176
		private LinkedList<TValue> m_LinkedList;

		// Token: 0x04000499 RID: 1177
		private Dictionary<TKey, LinkedListNode<TValue>> m_Map;
	}
}
