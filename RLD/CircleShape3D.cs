using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001D9 RID: 473
	public class CircleShape3D : Shape3D
	{
		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x0002222C File Offset: 0x0002042C
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x000197C8 File Offset: 0x000179C8
		public Vector3 Center
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x000197CA File Offset: 0x000179CA
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x000197D1 File Offset: 0x000179D1
		public float Radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x00022244 File Offset: 0x00020444
		// (set) Token: 0x060014FB RID: 5371 RVA: 0x000197D3 File Offset: 0x000179D3
		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x0002225C File Offset: 0x0002045C
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x00022274 File Offset: 0x00020474
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x0002228C File Offset: 0x0002048C
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x000222A4 File Offset: 0x000204A4
		public Vector3 Normal
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x000222BC File Offset: 0x000204BC
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x000197D5 File Offset: 0x000179D5
		public CircleEpsilon Epsilon
		{
			get
			{
				return default(CircleEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x000197D7 File Offset: 0x000179D7
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x000197DE File Offset: 0x000179DE
		public float RadiusEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x000197E0 File Offset: 0x000179E0
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x000197E7 File Offset: 0x000179E7
		public float ExtrudeEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x000197E9 File Offset: 0x000179E9
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x000197F0 File Offset: 0x000179F0
		public float WireEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x000222D4 File Offset: 0x000204D4
		// (set) Token: 0x06001509 RID: 5385 RVA: 0x000197F2 File Offset: 0x000179F2
		public Shape3DRaycastMode RaycastMode
		{
			get
			{
				return Shape3DRaycastMode.Solid;
			}
			set
			{
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x000222EC File Offset: 0x000204EC
		public static Vector3 ModelRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x00022304 File Offset: 0x00020504
		public static Vector3 ModelUp
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x0002231C File Offset: 0x0002051C
		public static Vector3 ModelLook
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x00022334 File Offset: 0x00020534
		public static Vector3 ModelCenter
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x0002234C File Offset: 0x0002054C
		public static Vector3 ModelNormal
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x000197F4 File Offset: 0x000179F4
		public void AlignNormal(Vector3 axis)
		{
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x000197F6 File Offset: 0x000179F6
		public void AlignRight(Vector3 axis)
		{
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x000197F8 File Offset: 0x000179F8
		public void AlignUp(Vector3 axis)
		{
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x000197FA File Offset: 0x000179FA
		public override void RenderSolid()
		{
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000197FC File Offset: 0x000179FC
		public override void RenderWire()
		{
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000197FE File Offset: 0x000179FE
		public override bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00019808 File Offset: 0x00017A08
		public override bool RaycastWire(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x00019812 File Offset: 0x00017A12
		public bool ContainsPoint(Vector3 point, bool checkOnPlane)
		{
			return false;
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00019815 File Offset: 0x00017A15
		public List<Vector3> GetExtentPoints()
		{
			return null;
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00022364 File Offset: 0x00020564
		public override AABB GetAABB()
		{
			return default(AABB);
		}

		// Token: 0x0400079D RID: 1949
		private Vector3 _center;

		// Token: 0x0400079E RID: 1950
		private float _radius;

		// Token: 0x0400079F RID: 1951
		private Quaternion _rotation;

		// Token: 0x040007A0 RID: 1952
		private CircleEpsilon _epsilon;

		// Token: 0x040007A1 RID: 1953
		private Shape3DRaycastMode _raycastMode;
	}
}
