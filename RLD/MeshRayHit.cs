using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B4 RID: 436
	public class MeshRayHit
	{
		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x0001931A File Offset: 0x0001751A
		public int HitTriangleIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x00021BE4 File Offset: 0x0001FDE4
		public Vector3 HitPoint
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x0001931D File Offset: 0x0001751D
		public float HitEnter
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x00021BFC File Offset: 0x0001FDFC
		public Vector3 HitNormal
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00019324 File Offset: 0x00017524
		public MeshRayHit(Ray ray, int hitTriangleIndex, float hitEnter, Vector3 hitNormal)
		{
		}

		// Token: 0x040006E0 RID: 1760
		private int _hitTriangleIndex;

		// Token: 0x040006E1 RID: 1761
		private Vector3 _hitPoint;

		// Token: 0x040006E2 RID: 1762
		private float _hitEnter;

		// Token: 0x040006E3 RID: 1763
		private Vector3 _hitNormal;
	}
}
