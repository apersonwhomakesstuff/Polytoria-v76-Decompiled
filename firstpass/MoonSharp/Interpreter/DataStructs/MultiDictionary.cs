using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.DataStructs
{
	// Token: 0x02000105 RID: 261
	internal class MultiDictionary<K, V>
	{
		// Token: 0x06000BB4 RID: 2996 RVA: 0x0000EA66 File Offset: 0x0000CC66
		public MultiDictionary()
		{
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0000EA6E File Offset: 0x0000CC6E
		public MultiDictionary(IEqualityComparer<K> eqComparer)
		{
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0000EA76 File Offset: 0x0000CC76
		public bool Add(K key, V value)
		{
			return false;
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0000EA79 File Offset: 0x0000CC79
		public IEnumerable<V> Find(K key)
		{
			return null;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0000EA7C File Offset: 0x0000CC7C
		public bool ContainsKey(K key)
		{
			return false;
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x0000EA7F File Offset: 0x0000CC7F
		public IEnumerable<K> Keys
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0000EA82 File Offset: 0x0000CC82
		public void Clear()
		{
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0000EA84 File Offset: 0x0000CC84
		public void Remove(K key)
		{
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0000EA86 File Offset: 0x0000CC86
		public bool RemoveValue(K key, V value)
		{
			return false;
		}

		// Token: 0x0400049A RID: 1178
		private Dictionary<K, List<V>> m_Map;

		// Token: 0x0400049B RID: 1179
		private V[] m_DefaultRet;
	}
}
