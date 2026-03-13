using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001D5 RID: 469
	public class ArcShape2D : Shape2D
	{
		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0001965C File Offset: 0x0001785C
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x00019663 File Offset: 0x00017863
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

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x00019665 File Offset: 0x00017865
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x00019668 File Offset: 0x00017868
		public bool ForceShortestArc
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x0001966A File Offset: 0x0001786A
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x00019671 File Offset: 0x00017871
		public float DegreeAngleFromStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x00019673 File Offset: 0x00017873
		public float AbsDegreeAngleFromStart
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x00021E54 File Offset: 0x00020054
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x0001967A File Offset: 0x0001787A
		public Vector2 Origin
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x0001967C File Offset: 0x0001787C
		// (set) Token: 0x06001474 RID: 5236 RVA: 0x0001967F File Offset: 0x0001787F
		public int NumBorderPoints
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x00021E6C File Offset: 0x0002006C
		public Vector2 StartPoint
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x00021E84 File Offset: 0x00020084
		public Vector2 EndPoint
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x00021E9C File Offset: 0x0002009C
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x00019681 File Offset: 0x00017881
		public ArcEpsilon Epsilon
		{
			get
			{
				return default(ArcEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x00019683 File Offset: 0x00017883
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x0001968A File Offset: 0x0001788A
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

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x0001968C File Offset: 0x0001788C
		public ArcShape2D.BorderRenderDescriptor BorderRenderDesc
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0001968F File Offset: 0x0001788F
		public override void RenderArea(Camera camera)
		{
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00019691 File Offset: 0x00017891
		public override void RenderBorder(Camera camera)
		{
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00019693 File Offset: 0x00017893
		public void SetArcData(Vector2 startPoint, float radius)
		{
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x00021EB4 File Offset: 0x000200B4
		public override Rect GetEncapsulatingRect()
		{
			return default(Rect);
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00019695 File Offset: 0x00017895
		public override bool ContainsPoint(Vector2 point)
		{
			return false;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x00019698 File Offset: 0x00017898
		private void OnBorderPointsFoundDirty()
		{
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0001969A File Offset: 0x0001789A
		private void CalculateEndPoint()
		{
		}

		// Token: 0x04000776 RID: 1910
		private ArcShape2D.BorderRenderDescriptor _borderRenderDesc;

		// Token: 0x04000777 RID: 1911
		private Rect _rect;

		// Token: 0x04000778 RID: 1912
		private bool _forceShortestArc;

		// Token: 0x04000779 RID: 1913
		private float _radius;

		// Token: 0x0400077A RID: 1914
		private Vector2 _origin;

		// Token: 0x0400077B RID: 1915
		private Vector2 _startPoint;

		// Token: 0x0400077C RID: 1916
		private Vector2 _endPoint;

		// Token: 0x0400077D RID: 1917
		private List<Vector2> _borderPoints;

		// Token: 0x0400077E RID: 1918
		private float _degreeAngleFromStart;

		// Token: 0x0400077F RID: 1919
		private int _numBorderPoints;

		// Token: 0x04000780 RID: 1920
		private bool _areBorderPointsDirty;

		// Token: 0x04000781 RID: 1921
		private ArcEpsilon _epsilon;

		// Token: 0x020003AA RID: 938
		public enum BorderRenderFlags
		{
			// Token: 0x04000FB4 RID: 4020
			None,
			// Token: 0x04000FB5 RID: 4021
			ExtremitiesBorder,
			// Token: 0x04000FB6 RID: 4022
			ArcBorder,
			// Token: 0x04000FB7 RID: 4023
			All
		}

		// Token: 0x020003AB RID: 939
		public class BorderRenderDescriptor
		{
			// Token: 0x17000C98 RID: 3224
			// (get) Token: 0x06002AED RID: 10989 RVA: 0x00026808 File Offset: 0x00024A08
			// (set) Token: 0x06002AEE RID: 10990 RVA: 0x0001D3BD File Offset: 0x0001B5BD
			public ArcShape2D.BorderRenderFlags BorderFlags
			{
				get
				{
					return ArcShape2D.BorderRenderFlags.None;
				}
				set
				{
				}
			}

			// Token: 0x04000FB8 RID: 4024
			private ArcShape2D.BorderRenderFlags _borderFlags;
		}
	}
}
