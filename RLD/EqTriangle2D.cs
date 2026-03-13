using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001DE RID: 478
	public class EqTriangle2D : Shape2D
	{
		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x0001993E File Offset: 0x00017B3E
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x00019945 File Offset: 0x00017B45
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

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x00022874 File Offset: 0x00020A74
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x00019947 File Offset: 0x00017B47
		public Vector2 Centroid
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00019949 File Offset: 0x00017B49
		public float Altitude
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x00019950 File Offset: 0x00017B50
		public float CentroidAltitude
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x00019957 File Offset: 0x00017B57
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x0001995E File Offset: 0x00017B5E
		public float RotationDegrees
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x0002288C File Offset: 0x00020A8C
		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x000228A4 File Offset: 0x00020AA4
		// (set) Token: 0x060015A4 RID: 5540 RVA: 0x00019960 File Offset: 0x00017B60
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

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x00019962 File Offset: 0x00017B62
		// (set) Token: 0x060015A6 RID: 5542 RVA: 0x00019969 File Offset: 0x00017B69
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

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x000228BC File Offset: 0x00020ABC
		public Vector2 Right
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x000228D4 File Offset: 0x00020AD4
		public Vector2 Up
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x000228EC File Offset: 0x00020AEC
		public static Vector2 ModelRight
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x00022904 File Offset: 0x00020B04
		public static Vector2 ModelUp
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x0002291C File Offset: 0x00020B1C
		public static Vector2 ModelCentroid
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00022934 File Offset: 0x00020B34
		public Vector2 GetPoint(EqTrianglePoint point)
		{
			return default(Vector2);
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x0001996B File Offset: 0x00017B6B
		public void SetPoint(EqTrianglePoint point, Vector2 pointValue)
		{
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x0002294C File Offset: 0x00020B4C
		public Vector2 GetEdgeMidPoint(EqTriangleEdge edge)
		{
			return default(Vector2);
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00022964 File Offset: 0x00020B64
		public Vector2 GetEdge(EqTriangleEdge edge)
		{
			return default(Vector2);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x0001996D File Offset: 0x00017B6D
		public override void RenderArea(Camera camera)
		{
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x0001996F File Offset: 0x00017B6F
		public override void RenderBorder(Camera camera)
		{
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00019971 File Offset: 0x00017B71
		public override bool ContainsPoint(Vector2 point)
		{
			return false;
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0002297C File Offset: 0x00020B7C
		public override Rect GetEncapsulatingRect()
		{
			return default(Rect);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00019974 File Offset: 0x00017B74
		private void OnPointsFoundDirty()
		{
		}

		// Token: 0x040007B7 RID: 1975
		private float _sideLength;

		// Token: 0x040007B8 RID: 1976
		private float _rotationDegrees;

		// Token: 0x040007B9 RID: 1977
		private TriangleEpsilon _epsilon;

		// Token: 0x040007BA RID: 1978
		private Vector2[] _points;

		// Token: 0x040007BB RID: 1979
		private Vector2 _centroid;

		// Token: 0x040007BC RID: 1980
		private bool _arePointsDirty;
	}
}
