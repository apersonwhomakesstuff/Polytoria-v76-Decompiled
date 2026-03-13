using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001D8 RID: 472
	public class CircleShape2D : Shape2D
	{
		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x0002213C File Offset: 0x0002033C
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x00019785 File Offset: 0x00017985
		public Vector2 Center
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x00019787 File Offset: 0x00017987
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x0001978E File Offset: 0x0001798E
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

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x00019790 File Offset: 0x00017990
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x00019797 File Offset: 0x00017997
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

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x00022154 File Offset: 0x00020354
		public Vector2 Right
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x0002216C File Offset: 0x0002036C
		public Vector2 Up
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x00022184 File Offset: 0x00020384
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x00019799 File Offset: 0x00017999
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

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x0001979B File Offset: 0x0001799B
		// (set) Token: 0x060014E4 RID: 5348 RVA: 0x000197A2 File Offset: 0x000179A2
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

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x000197A4 File Offset: 0x000179A4
		// (set) Token: 0x060014E6 RID: 5350 RVA: 0x000197AB File Offset: 0x000179AB
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

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x000197AD File Offset: 0x000179AD
		// (set) Token: 0x060014E8 RID: 5352 RVA: 0x000197B0 File Offset: 0x000179B0
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

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x0002219C File Offset: 0x0002039C
		// (set) Token: 0x060014EA RID: 5354 RVA: 0x000197B2 File Offset: 0x000179B2
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

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x000221B4 File Offset: 0x000203B4
		public static Vector2 ModelRight
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x000221CC File Offset: 0x000203CC
		public static Vector2 ModelUp
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x000221E4 File Offset: 0x000203E4
		public static Vector2 ModelCenter
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x000221FC File Offset: 0x000203FC
		public Vector2 GetExtentPoint(Shape2DExtentPoint extentPt)
		{
			return default(Vector2);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x000197B4 File Offset: 0x000179B4
		public override void RenderBorder(Camera camera)
		{
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x000197B6 File Offset: 0x000179B6
		public override void RenderArea(Camera camera)
		{
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x000197B8 File Offset: 0x000179B8
		public override bool ContainsPoint(Vector2 point)
		{
			return false;
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x000197BB File Offset: 0x000179BB
		public List<Vector2> GetExtentPoints()
		{
			return null;
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00022214 File Offset: 0x00020414
		public override Rect GetEncapsulatingRect()
		{
			return default(Rect);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x000197BE File Offset: 0x000179BE
		private void CalcModelBorderPoints()
		{
		}

		// Token: 0x04000795 RID: 1941
		private Vector2 _center;

		// Token: 0x04000796 RID: 1942
		private float _radius;

		// Token: 0x04000797 RID: 1943
		private float _rotationDegrees;

		// Token: 0x04000798 RID: 1944
		private int _numBorderPoints;

		// Token: 0x04000799 RID: 1945
		private List<Vector2> _modelBorderPoints;

		// Token: 0x0400079A RID: 1946
		private bool _areModelBorderPointsDirty;

		// Token: 0x0400079B RID: 1947
		private CircleEpsilon _epsilon;

		// Token: 0x0400079C RID: 1948
		private Shape2DPtContainMode _ptContainMode;
	}
}
