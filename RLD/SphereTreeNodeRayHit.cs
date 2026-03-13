using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000F7 RID: 247
	public class SphereTreeNodeRayHit<T>
	{
		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x0001834B File Offset: 0x0001654B
		public SphereTreeNode<T> HitNode
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x000203F4 File Offset: 0x0001E5F4
		public Vector3 HitPoint
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x0001834E File Offset: 0x0001654E
		public float HitEnter
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00018355 File Offset: 0x00016555
		public SphereTreeNodeRayHit(Ray ray, SphereTreeNode<T> hitNode, float hitEnter)
		{
		}

		// Token: 0x040004B5 RID: 1205
		private SphereTreeNode<T> _hitNode;

		// Token: 0x040004B6 RID: 1206
		private Vector3 _hitPoint;

		// Token: 0x040004B7 RID: 1207
		private float _hitEnter;
	}
}
