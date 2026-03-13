using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000191 RID: 401
	public class ObjectPool
	{
		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x00021944 File Offset: 0x0001FB44
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x00018F91 File Offset: 0x00017191
		public ObjectPool.GrowMode PoolGrowMode
		{
			get
			{
				return ObjectPool.GrowMode.None;
			}
			set
			{
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x00018F93 File Offset: 0x00017193
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x00018F96 File Offset: 0x00017196
		public int GrowAmount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00018F98 File Offset: 0x00017198
		public ObjectPool(GameObject sourceObject, int numPooled, ObjectPool.GrowMode growMode)
		{
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00018FA0 File Offset: 0x000171A0
		public void SetPooledObjectsParent(Transform parent)
		{
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00018FA2 File Offset: 0x000171A2
		public GameObject GetPooledObject()
		{
			return null;
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00018FA5 File Offset: 0x000171A5
		public void MarkAsUnused(GameObject gameObject)
		{
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00018FA7 File Offset: 0x000171A7
		public void MarkAllAsUnused()
		{
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00018FA9 File Offset: 0x000171A9
		private void Grow()
		{
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00018FAB File Offset: 0x000171AB
		private GameObject CreatePooledObject()
		{
			return null;
		}

		// Token: 0x04000657 RID: 1623
		private GameObject _sourceObject;

		// Token: 0x04000658 RID: 1624
		private ObjectPool.GrowMode _growMode;

		// Token: 0x04000659 RID: 1625
		private int _growAmount;

		// Token: 0x0400065A RID: 1626
		private List<GameObject> _pooledObjects;

		// Token: 0x0400065B RID: 1627
		private Transform _pooledParent;

		// Token: 0x02000391 RID: 913
		public enum GrowMode
		{
			// Token: 0x04000F71 RID: 3953
			None,
			// Token: 0x04000F72 RID: 3954
			Increment,
			// Token: 0x04000F73 RID: 3955
			ByAmount
		}
	}
}
