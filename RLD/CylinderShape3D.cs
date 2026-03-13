using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001DC RID: 476
	public class CylinderShape3D : Shape3D
	{
		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x000225D4 File Offset: 0x000207D4
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x0001989F File Offset: 0x00017A9F
		public Vector3 BaseCenter
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x000225EC File Offset: 0x000207EC
		// (set) Token: 0x06001558 RID: 5464 RVA: 0x000198A1 File Offset: 0x00017AA1
		public Vector3 TopCenter
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x00022604 File Offset: 0x00020804
		// (set) Token: 0x0600155A RID: 5466 RVA: 0x000198A3 File Offset: 0x00017AA3
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

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x0600155B RID: 5467 RVA: 0x000198A5 File Offset: 0x00017AA5
		// (set) Token: 0x0600155C RID: 5468 RVA: 0x000198AC File Offset: 0x00017AAC
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

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x000198AE File Offset: 0x00017AAE
		// (set) Token: 0x0600155E RID: 5470 RVA: 0x000198B5 File Offset: 0x00017AB5
		public float Height
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x0002261C File Offset: 0x0002081C
		// (set) Token: 0x06001560 RID: 5472 RVA: 0x000198B7 File Offset: 0x00017AB7
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

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x00022634 File Offset: 0x00020834
		// (set) Token: 0x06001562 RID: 5474 RVA: 0x000198B9 File Offset: 0x00017AB9
		public CylinderEpsilon Epsilon
		{
			get
			{
				return default(CylinderEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x000198BB File Offset: 0x00017ABB
		// (set) Token: 0x06001564 RID: 5476 RVA: 0x000198C2 File Offset: 0x00017AC2
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

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x000198C4 File Offset: 0x00017AC4
		// (set) Token: 0x06001566 RID: 5478 RVA: 0x000198CB File Offset: 0x00017ACB
		public float VertEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x0002264C File Offset: 0x0002084C
		public Vector3 CentralAxis
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x00022664 File Offset: 0x00020864
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x0002267C File Offset: 0x0002087C
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x00022694 File Offset: 0x00020894
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x000226AC File Offset: 0x000208AC
		public static Vector3 ModelRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x000226C4 File Offset: 0x000208C4
		public static Vector3 ModelUp
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x000226DC File Offset: 0x000208DC
		public static Vector3 ModelLook
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x000226F4 File Offset: 0x000208F4
		public static Vector3 ModelBaseCenter
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x000198CD File Offset: 0x00017ACD
		public void AlignCentralAxis(Vector3 axis)
		{
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x000198CF File Offset: 0x00017ACF
		public override void RenderSolid()
		{
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x000198D1 File Offset: 0x00017AD1
		public override void RenderWire()
		{
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x000198D3 File Offset: 0x00017AD3
		public override bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x000198DD File Offset: 0x00017ADD
		public bool ContainsPoint(Vector3 point)
		{
			return false;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x000198E0 File Offset: 0x00017AE0
		public List<Vector3> GetBottomCapExtentPoints()
		{
			return null;
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x000198E3 File Offset: 0x00017AE3
		public List<Vector3> GetTopCapExtentPoints()
		{
			return null;
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0002270C File Offset: 0x0002090C
		public AABB GetModelAABB()
		{
			return default(AABB);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00022724 File Offset: 0x00020924
		public override AABB GetAABB()
		{
			return default(AABB);
		}

		// Token: 0x040007AC RID: 1964
		private Vector3 _baseCenter;

		// Token: 0x040007AD RID: 1965
		private float _radius;

		// Token: 0x040007AE RID: 1966
		private float _height;

		// Token: 0x040007AF RID: 1967
		private Quaternion _rotation;

		// Token: 0x040007B0 RID: 1968
		private CylinderEpsilon _epsilon;
	}
}
