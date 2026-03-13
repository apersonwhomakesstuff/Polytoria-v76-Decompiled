using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E2 RID: 482
	public class QuadShape2D : Shape2D
	{
		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00019A6E File Offset: 0x00017C6E
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x00019A75 File Offset: 0x00017C75
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

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x00022C94 File Offset: 0x00020E94
		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x00022CAC File Offset: 0x00020EAC
		// (set) Token: 0x06001619 RID: 5657 RVA: 0x00019A77 File Offset: 0x00017C77
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

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x00022CC4 File Offset: 0x00020EC4
		// (set) Token: 0x0600161B RID: 5659 RVA: 0x00019A79 File Offset: 0x00017C79
		public Vector2 Size
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x00022CDC File Offset: 0x00020EDC
		public Vector2 Extents
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x00019A7B File Offset: 0x00017C7B
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x00019A82 File Offset: 0x00017C82
		public float Width
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x00019A84 File Offset: 0x00017C84
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x00019A8B File Offset: 0x00017C8B
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

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x00022CF4 File Offset: 0x00020EF4
		// (set) Token: 0x06001622 RID: 5666 RVA: 0x00019A8D File Offset: 0x00017C8D
		public QuadEpsilon Epsilon
		{
			get
			{
				return default(QuadEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x00022D0C File Offset: 0x00020F0C
		// (set) Token: 0x06001624 RID: 5668 RVA: 0x00019A8F File Offset: 0x00017C8F
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

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00022D24 File Offset: 0x00020F24
		// (set) Token: 0x06001626 RID: 5670 RVA: 0x00019A91 File Offset: 0x00017C91
		public Vector2 SizeEps
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x00019A93 File Offset: 0x00017C93
		// (set) Token: 0x06001628 RID: 5672 RVA: 0x00019A9A File Offset: 0x00017C9A
		public float WidthEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x00019A9C File Offset: 0x00017C9C
		// (set) Token: 0x0600162A RID: 5674 RVA: 0x00019AA3 File Offset: 0x00017CA3
		public float HeightEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x00019AA5 File Offset: 0x00017CA5
		// (set) Token: 0x0600162C RID: 5676 RVA: 0x00019AAC File Offset: 0x00017CAC
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

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x00022D3C File Offset: 0x00020F3C
		public Vector2 Right
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x00022D54 File Offset: 0x00020F54
		public Vector2 Up
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x0600162F RID: 5679 RVA: 0x00022D6C File Offset: 0x00020F6C
		public static Vector2 ModelRight
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x00022D84 File Offset: 0x00020F84
		public static Vector2 ModelUp
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x00022D9C File Offset: 0x00020F9C
		public static Vector2 ModelCenter
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00022DB4 File Offset: 0x00020FB4
		public Vector2 GetExtentPoint(Shape2DExtentPoint extentPt)
		{
			return default(Vector2);
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00019AAE File Offset: 0x00017CAE
		public void AlignWidth(Vector2 axis)
		{
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00019AB0 File Offset: 0x00017CB0
		public float GetSizeAlongDirection(Vector2 direction)
		{
			return 0f;
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00019AB7 File Offset: 0x00017CB7
		public override void RenderArea(Camera camera)
		{
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00019AB9 File Offset: 0x00017CB9
		public override void RenderBorder(Camera camera)
		{
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00019ABB File Offset: 0x00017CBB
		public override bool ContainsPoint(Vector2 point)
		{
			return false;
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00022DCC File Offset: 0x00020FCC
		public override Rect GetEncapsulatingRect()
		{
			return default(Rect);
		}

		// Token: 0x040007D2 RID: 2002
		private Vector2 _center;

		// Token: 0x040007D3 RID: 2003
		private Vector2 _size;

		// Token: 0x040007D4 RID: 2004
		private float _rotationDegrees;

		// Token: 0x040007D5 RID: 2005
		private QuadEpsilon _epsilon;

		// Token: 0x040007D6 RID: 2006
		private Shape2DPtContainMode _ptContainMode;
	}
}
