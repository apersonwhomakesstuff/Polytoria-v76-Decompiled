using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001DF RID: 479
	public class EqTriangle3D : Shape3D
	{
		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x0001997E File Offset: 0x00017B7E
		// (set) Token: 0x060015B7 RID: 5559 RVA: 0x00019985 File Offset: 0x00017B85
		public float SideLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x00022994 File Offset: 0x00020B94
		// (set) Token: 0x060015B9 RID: 5561 RVA: 0x00019987 File Offset: 0x00017B87
		public Vector3 Centroid
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x00019989 File Offset: 0x00017B89
		public float Altitude
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x00019990 File Offset: 0x00017B90
		public float CentroidAltitude
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x000229AC File Offset: 0x00020BAC
		// (set) Token: 0x060015BD RID: 5565 RVA: 0x00019997 File Offset: 0x00017B97
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

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x000229C4 File Offset: 0x00020BC4
		// (set) Token: 0x060015BF RID: 5567 RVA: 0x00019999 File Offset: 0x00017B99
		public TriangleEpsilon Epsilon
		{
			get
			{
				return default(TriangleEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x0001999B File Offset: 0x00017B9B
		// (set) Token: 0x060015C1 RID: 5569 RVA: 0x000199A2 File Offset: 0x00017BA2
		public float AreaEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x000199A4 File Offset: 0x00017BA4
		// (set) Token: 0x060015C3 RID: 5571 RVA: 0x000199AB File Offset: 0x00017BAB
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

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x000199AD File Offset: 0x00017BAD
		// (set) Token: 0x060015C5 RID: 5573 RVA: 0x000199B4 File Offset: 0x00017BB4
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

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x000229DC File Offset: 0x00020BDC
		public Vector3 Normal
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x000229F4 File Offset: 0x00020BF4
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x00022A0C File Offset: 0x00020C0C
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x00022A24 File Offset: 0x00020C24
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x00022A3C File Offset: 0x00020C3C
		public static Vector3 ModelRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x00022A54 File Offset: 0x00020C54
		public static Vector3 ModelUp
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x00022A6C File Offset: 0x00020C6C
		public static Vector3 ModelLook
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x00022A84 File Offset: 0x00020C84
		public static Vector3 ModelCentroid
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x000199B6 File Offset: 0x00017BB6
		public void AlignNormal(Vector3 axis)
		{
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x000199B8 File Offset: 0x00017BB8
		public void AlignRight(Vector3 axis)
		{
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x000199BA File Offset: 0x00017BBA
		public void AlignUp(Vector3 axis)
		{
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00022A9C File Offset: 0x00020C9C
		public Vector3 GetPoint(EqTrianglePoint point)
		{
			return default(Vector3);
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x000199BC File Offset: 0x00017BBC
		public void SetPoint(EqTrianglePoint point, Vector3 pointValue)
		{
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00022AB4 File Offset: 0x00020CB4
		public Vector3 GetEdgeMidPoint(EqTriangleEdge edge)
		{
			return default(Vector3);
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00022ACC File Offset: 0x00020CCC
		public Vector3 GetEdge(EqTriangleEdge edge)
		{
			return default(Vector3);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x000199BE File Offset: 0x00017BBE
		public override void RenderSolid()
		{
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x000199C0 File Offset: 0x00017BC0
		public override void RenderWire()
		{
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x000199C2 File Offset: 0x00017BC2
		public override bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x000199CC File Offset: 0x00017BCC
		public override bool RaycastWire(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00022AE4 File Offset: 0x00020CE4
		public override AABB GetAABB()
		{
			return default(AABB);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x000199D6 File Offset: 0x00017BD6
		private void OnPointsFoundDirty()
		{
		}

		// Token: 0x040007BD RID: 1981
		private float _sideLength;

		// Token: 0x040007BE RID: 1982
		private Quaternion _rotation;

		// Token: 0x040007BF RID: 1983
		private TriangleEpsilon _epsilon;

		// Token: 0x040007C0 RID: 1984
		private Vector3[] _points;

		// Token: 0x040007C1 RID: 1985
		private Vector3 _centroid;

		// Token: 0x040007C2 RID: 1986
		private bool _arePointsDirty;
	}
}
