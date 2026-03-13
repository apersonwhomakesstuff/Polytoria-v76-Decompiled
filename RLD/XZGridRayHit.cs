using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B1 RID: 433
	public class XZGridRayHit
	{
		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x000192D5 File Offset: 0x000174D5
		public XZGridCell HitCell
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x00021B84 File Offset: 0x0001FD84
		public Vector3 HitPoint
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x000192D8 File Offset: 0x000174D8
		public float HitEnter
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x00021B9C File Offset: 0x0001FD9C
		public Vector3 HitNormal
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x00021BB4 File Offset: 0x0001FDB4
		public Plane HitPlane
		{
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x000192DF File Offset: 0x000174DF
		public XZGridRayHit(Ray ray, XZGridCell hitCell, float hitEnter)
		{
		}

		// Token: 0x040006D5 RID: 1749
		private XZGridCell _hitCell;

		// Token: 0x040006D6 RID: 1750
		private Vector3 _hitPoint;

		// Token: 0x040006D7 RID: 1751
		private float _hitEnter;

		// Token: 0x040006D8 RID: 1752
		private Vector3 _hitNormal;

		// Token: 0x040006D9 RID: 1753
		private Plane _hitPlane;
	}
}
