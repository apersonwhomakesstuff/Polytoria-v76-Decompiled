using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E0 RID: 480
	public class PolygonShape2D : Shape2D
	{
		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x000199E0 File Offset: 0x00017BE0
		public int NumPoints
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x00022AFC File Offset: 0x00020CFC
		// (set) Token: 0x060015DE RID: 5598 RVA: 0x000199E3 File Offset: 0x00017BE3
		public PolygonEpsilon Epsilon
		{
			get
			{
				return default(PolygonEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x000199E5 File Offset: 0x00017BE5
		// (set) Token: 0x060015E0 RID: 5600 RVA: 0x000199EC File Offset: 0x00017BEC
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

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x000199EE File Offset: 0x00017BEE
		// (set) Token: 0x060015E2 RID: 5602 RVA: 0x000199F5 File Offset: 0x00017BF5
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

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x000199F7 File Offset: 0x00017BF7
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x000199FE File Offset: 0x00017BFE
		public float ThickWireEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x00019A00 File Offset: 0x00017C00
		public bool IsClosed
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x00022B14 File Offset: 0x00020D14
		// (set) Token: 0x060015E7 RID: 5607 RVA: 0x00019A03 File Offset: 0x00017C03
		public Shape2DPtContainMode PtContainMode
		{
			get
			{
				return Shape2DPtContainMode.InsideArea;
			}
			set
			{
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x00019A05 File Offset: 0x00017C05
		public PolygonShape2D.BorderRenderDescriptor BorderRenderDesc
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00022B2C File Offset: 0x00020D2C
		public Vector2 GetExtentPoint(Shape2DExtentPoint extentPt)
		{
			return default(Vector2);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00019A08 File Offset: 0x00017C08
		public override void RenderArea(Camera camera)
		{
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00019A0A File Offset: 0x00017C0A
		public override void RenderBorder(Camera camera)
		{
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00019A0C File Offset: 0x00017C0C
		public List<Vector2> GetPoints()
		{
			return null;
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00022B44 File Offset: 0x00020D44
		public override Rect GetEncapsulatingRect()
		{
			return default(Rect);
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00019A0F File Offset: 0x00017C0F
		public void CopyPoints(PolygonShape2D sourcePoly)
		{
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00019A11 File Offset: 0x00017C11
		public void SetClockwisePoints(List<Vector2> cwBorderPoints, bool isClosed)
		{
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00019A13 File Offset: 0x00017C13
		public void MakeSphereBorder(Vector3 sphereCenter, float sphereRadius, int numPoints, Camera camera)
		{
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00019A15 File Offset: 0x00017C15
		public override bool ContainsPoint(Vector2 point)
		{
			return false;
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00019A18 File Offset: 0x00017C18
		private void CalculateRect()
		{
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00019A1A File Offset: 0x00017C1A
		private void CalculateThickBorderPoints()
		{
		}

		// Token: 0x040007C3 RID: 1987
		private Rect _rect;

		// Token: 0x040007C4 RID: 1988
		private bool _isRectDirty;

		// Token: 0x040007C5 RID: 1989
		private bool _isClosed;

		// Token: 0x040007C6 RID: 1990
		private List<Vector2> _cwPolyPoints;

		// Token: 0x040007C7 RID: 1991
		private List<Vector2> _thickCwBorderPoints;

		// Token: 0x040007C8 RID: 1992
		private bool _isThickBorderDirty;

		// Token: 0x040007C9 RID: 1993
		private PolygonEpsilon _epsilon;

		// Token: 0x040007CA RID: 1994
		private Shape2DPtContainMode _ptContainMode;

		// Token: 0x040007CB RID: 1995
		private PolygonShape2D.BorderRenderDescriptor _borderRenderDesc;

		// Token: 0x020003B2 RID: 946
		public enum ThickBorderFillMode
		{
			// Token: 0x04000FCB RID: 4043
			Filled,
			// Token: 0x04000FCC RID: 4044
			Border
		}

		// Token: 0x020003B3 RID: 947
		public class BorderRenderDescriptor
		{
			// Token: 0x17000C9F RID: 3231
			// (get) Token: 0x06002AFF RID: 11007 RVA: 0x00026868 File Offset: 0x00024A68
			// (set) Token: 0x06002B00 RID: 11008 RVA: 0x0001D3F8 File Offset: 0x0001B5F8
			public Shape2DBorderType BorderType
			{
				get
				{
					return Shape2DBorderType.Thin;
				}
				set
				{
				}
			}

			// Token: 0x17000CA0 RID: 3232
			// (get) Token: 0x06002B01 RID: 11009 RVA: 0x0001D3FA File Offset: 0x0001B5FA
			// (set) Token: 0x06002B02 RID: 11010 RVA: 0x0001D401 File Offset: 0x0001B601
			public float Thickness
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			// Token: 0x17000CA1 RID: 3233
			// (get) Token: 0x06002B03 RID: 11011 RVA: 0x00026880 File Offset: 0x00024A80
			// (set) Token: 0x06002B04 RID: 11012 RVA: 0x0001D403 File Offset: 0x0001B603
			public Shape2DBorderDirection Direction
			{
				get
				{
					return Shape2DBorderDirection.Inward;
				}
				set
				{
				}
			}

			// Token: 0x17000CA2 RID: 3234
			// (get) Token: 0x06002B05 RID: 11013 RVA: 0x00026898 File Offset: 0x00024A98
			// (set) Token: 0x06002B06 RID: 11014 RVA: 0x0001D405 File Offset: 0x0001B605
			public PolygonShape2D.ThickBorderFillMode FillMode
			{
				get
				{
					return PolygonShape2D.ThickBorderFillMode.Filled;
				}
				set
				{
				}
			}

			// Token: 0x04000FCD RID: 4045
			private Shape2DBorderType _borderType;

			// Token: 0x04000FCE RID: 4046
			private float _thickness;

			// Token: 0x04000FCF RID: 4047
			private Shape2DBorderDirection _direction;

			// Token: 0x04000FD0 RID: 4048
			private PolygonShape2D.ThickBorderFillMode _fillMode;
		}
	}
}
