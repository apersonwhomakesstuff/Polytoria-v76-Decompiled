using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E1 RID: 481
	public class PyramidShape3D : Shape3D
	{
		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x00022B5C File Offset: 0x00020D5C
		// (set) Token: 0x060015F6 RID: 5622 RVA: 0x00019A24 File Offset: 0x00017C24
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

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x00022B74 File Offset: 0x00020D74
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x00019A26 File Offset: 0x00017C26
		public Vector3 Tip
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x00022B8C File Offset: 0x00020D8C
		// (set) Token: 0x060015FA RID: 5626 RVA: 0x00019A28 File Offset: 0x00017C28
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

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x00019A2A File Offset: 0x00017C2A
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x00019A31 File Offset: 0x00017C31
		public float BaseWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x00019A33 File Offset: 0x00017C33
		// (set) Token: 0x060015FE RID: 5630 RVA: 0x00019A3A File Offset: 0x00017C3A
		public float BaseDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x00019A3C File Offset: 0x00017C3C
		// (set) Token: 0x06001600 RID: 5632 RVA: 0x00019A43 File Offset: 0x00017C43
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

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x00022BA4 File Offset: 0x00020DA4
		// (set) Token: 0x06001602 RID: 5634 RVA: 0x00019A45 File Offset: 0x00017C45
		public PyramidEpsilon Epsilon
		{
			get
			{
				return default(PyramidEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x00019A47 File Offset: 0x00017C47
		// (set) Token: 0x06001604 RID: 5636 RVA: 0x00019A4E File Offset: 0x00017C4E
		public float PtContainEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x00022BBC File Offset: 0x00020DBC
		public Vector3 CentralAxis
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x00022BD4 File Offset: 0x00020DD4
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x00022BEC File Offset: 0x00020DEC
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x00022C04 File Offset: 0x00020E04
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x00022C1C File Offset: 0x00020E1C
		public static Vector3 ModelRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x00022C34 File Offset: 0x00020E34
		public static Vector3 ModelUp
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x00022C4C File Offset: 0x00020E4C
		public static Vector3 ModelLook
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x00022C64 File Offset: 0x00020E64
		public static Vector3 ModelBaseCenter
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00019A50 File Offset: 0x00017C50
		public void PointTipAlongAxis(Vector3 axis)
		{
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00019A52 File Offset: 0x00017C52
		public override void RenderSolid()
		{
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00019A54 File Offset: 0x00017C54
		public override void RenderWire()
		{
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00019A56 File Offset: 0x00017C56
		public List<Vector3> GetBaseCornerPoints()
		{
			return null;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00022C7C File Offset: 0x00020E7C
		public override AABB GetAABB()
		{
			return default(AABB);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00019A59 File Offset: 0x00017C59
		public override bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00019A63 File Offset: 0x00017C63
		public bool ContainsPoint(Vector3 point)
		{
			return false;
		}

		// Token: 0x040007CC RID: 1996
		private Vector3 _baseCenter;

		// Token: 0x040007CD RID: 1997
		private float _baseWidth;

		// Token: 0x040007CE RID: 1998
		private float _baseDepth;

		// Token: 0x040007CF RID: 1999
		private float _height;

		// Token: 0x040007D0 RID: 2000
		private Quaternion _rotation;

		// Token: 0x040007D1 RID: 2001
		private PyramidEpsilon _epsilon;
	}
}
