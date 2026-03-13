using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E4 RID: 484
	public class RightAngTriangle2D : Shape2D
	{
		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x00022F7C File Offset: 0x0002117C
		// (set) Token: 0x0600166B RID: 5739 RVA: 0x00019B3C File Offset: 0x00017D3C
		public Vector2 RightAngleCorner
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x00019B3E File Offset: 0x00017D3E
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x00019B45 File Offset: 0x00017D45
		public float XLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x00019B47 File Offset: 0x00017D47
		// (set) Token: 0x0600166F RID: 5743 RVA: 0x00019B4E File Offset: 0x00017D4E
		public float YLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x00019B50 File Offset: 0x00017D50
		// (set) Token: 0x06001671 RID: 5745 RVA: 0x00019B57 File Offset: 0x00017D57
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

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x00022F94 File Offset: 0x00021194
		public Vector2 Right
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x00022FAC File Offset: 0x000211AC
		public Vector2 Up
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x00022FC4 File Offset: 0x000211C4
		// (set) Token: 0x06001675 RID: 5749 RVA: 0x00019B59 File Offset: 0x00017D59
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

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x00019B5B File Offset: 0x00017D5B
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x00019B62 File Offset: 0x00017D62
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

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x00022FDC File Offset: 0x000211DC
		public static Vector2 ModelRight
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x00022FF4 File Offset: 0x000211F4
		public static Vector2 ModelUp
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x0002300C File Offset: 0x0002120C
		public static Vector2 ModelRightAngleCorner
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00019B64 File Offset: 0x00017D64
		public override void RenderArea(Camera camera)
		{
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00019B66 File Offset: 0x00017D66
		public override void RenderBorder(Camera camera)
		{
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00019B68 File Offset: 0x00017D68
		public List<Vector2> GetPoints()
		{
			return null;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00019B6B File Offset: 0x00017D6B
		public override bool ContainsPoint(Vector2 point)
		{
			return false;
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00023024 File Offset: 0x00021224
		public override Rect GetEncapsulatingRect()
		{
			return default(Rect);
		}

		// Token: 0x040007DD RID: 2013
		private Vector2 _rightAngleCorner;

		// Token: 0x040007DE RID: 2014
		private float _XLength;

		// Token: 0x040007DF RID: 2015
		private float _YLength;

		// Token: 0x040007E0 RID: 2016
		private float _rotationDegrees;

		// Token: 0x040007E1 RID: 2017
		private TriangleEpsilon _epsilon;
	}
}
