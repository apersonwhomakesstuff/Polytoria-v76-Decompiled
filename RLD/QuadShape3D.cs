using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E3 RID: 483
	public class QuadShape3D : Shape3D
	{
		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x00022DE4 File Offset: 0x00020FE4
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x00019AC6 File Offset: 0x00017CC6
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

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x00022DFC File Offset: 0x00020FFC
		// (set) Token: 0x0600163D RID: 5693 RVA: 0x00019AC8 File Offset: 0x00017CC8
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

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x00019ACA File Offset: 0x00017CCA
		// (set) Token: 0x0600163F RID: 5695 RVA: 0x00019AD1 File Offset: 0x00017CD1
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

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x00019AD3 File Offset: 0x00017CD3
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x00019ADA File Offset: 0x00017CDA
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

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x00022E14 File Offset: 0x00021014
		// (set) Token: 0x06001643 RID: 5699 RVA: 0x00019ADC File Offset: 0x00017CDC
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

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x00022E2C File Offset: 0x0002102C
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x00022E44 File Offset: 0x00021044
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x00022E5C File Offset: 0x0002105C
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x00022E74 File Offset: 0x00021074
		public Vector3 Normal
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00022E8C File Offset: 0x0002108C
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x00019ADE File Offset: 0x00017CDE
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

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x00022EA4 File Offset: 0x000210A4
		// (set) Token: 0x0600164B RID: 5707 RVA: 0x00019AE0 File Offset: 0x00017CE0
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

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x00019AE2 File Offset: 0x00017CE2
		// (set) Token: 0x0600164D RID: 5709 RVA: 0x00019AE9 File Offset: 0x00017CE9
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

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x00019AEB File Offset: 0x00017CEB
		// (set) Token: 0x0600164F RID: 5711 RVA: 0x00019AF2 File Offset: 0x00017CF2
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

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x00019AF4 File Offset: 0x00017CF4
		// (set) Token: 0x06001651 RID: 5713 RVA: 0x00019AFB File Offset: 0x00017CFB
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

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x00019AFD File Offset: 0x00017CFD
		// (set) Token: 0x06001653 RID: 5715 RVA: 0x00019B04 File Offset: 0x00017D04
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

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x00022EBC File Offset: 0x000210BC
		// (set) Token: 0x06001655 RID: 5717 RVA: 0x00019B06 File Offset: 0x00017D06
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

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x00019B08 File Offset: 0x00017D08
		public QuadShape3D.WireRenderDescriptor WireRenderDesc
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x00022ED4 File Offset: 0x000210D4
		public static Vector3 ModelRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x00022EEC File Offset: 0x000210EC
		public static Vector3 ModelUp
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00022F04 File Offset: 0x00021104
		public static Vector3 ModelLook
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x00022F1C File Offset: 0x0002111C
		public static Vector3 ModelCenter
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x00022F34 File Offset: 0x00021134
		public static Vector3 ModelNormal
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00019B0B File Offset: 0x00017D0B
		public void AlignNormal(Vector3 axis)
		{
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00019B0D File Offset: 0x00017D0D
		public void AlignRight(Vector3 axis)
		{
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00019B0F File Offset: 0x00017D0F
		public void AlignUp(Vector3 axis)
		{
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00019B11 File Offset: 0x00017D11
		public List<Vector3> GetCornerPoints()
		{
			return null;
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00022F4C File Offset: 0x0002114C
		public Vector3 GetCornerPosition(QuadCorner quadCorner)
		{
			return default(Vector3);
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00019B14 File Offset: 0x00017D14
		public void SetCornerPointPosition(QuadCorner quadCorner, Vector3 position)
		{
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00019B16 File Offset: 0x00017D16
		public override void RenderSolid()
		{
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00019B18 File Offset: 0x00017D18
		public override void RenderWire()
		{
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00019B1A File Offset: 0x00017D1A
		public override bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00019B24 File Offset: 0x00017D24
		public override bool RaycastWire(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00019B2E File Offset: 0x00017D2E
		public bool ContainsPoint(Vector3 point, bool checkOnPlane)
		{
			return false;
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00019B31 File Offset: 0x00017D31
		public List<Vector3> GetCorners()
		{
			return null;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00022F64 File Offset: 0x00021164
		public override AABB GetAABB()
		{
			return default(AABB);
		}

		// Token: 0x040007D7 RID: 2007
		private Shape3DRaycastMode _raycastMode;

		// Token: 0x040007D8 RID: 2008
		private Vector3 _center;

		// Token: 0x040007D9 RID: 2009
		private Vector2 _size;

		// Token: 0x040007DA RID: 2010
		private Quaternion _rotation;

		// Token: 0x040007DB RID: 2011
		private QuadEpsilon _epsilon;

		// Token: 0x040007DC RID: 2012
		private QuadShape3D.WireRenderDescriptor _wireRenderDesc;

		// Token: 0x020003B4 RID: 948
		public enum WireEdgeFlags
		{
			// Token: 0x04000FD2 RID: 4050
			None,
			// Token: 0x04000FD3 RID: 4051
			Top,
			// Token: 0x04000FD4 RID: 4052
			Right,
			// Token: 0x04000FD5 RID: 4053
			Bottom = 4,
			// Token: 0x04000FD6 RID: 4054
			Left = 8,
			// Token: 0x04000FD7 RID: 4055
			All = 15
		}

		// Token: 0x020003B5 RID: 949
		public class WireRenderDescriptor
		{
			// Token: 0x17000CA3 RID: 3235
			// (get) Token: 0x06002B08 RID: 11016 RVA: 0x000268B0 File Offset: 0x00024AB0
			// (set) Token: 0x06002B09 RID: 11017 RVA: 0x0001D40F File Offset: 0x0001B60F
			public QuadShape3D.WireEdgeFlags WireEdgeFlags
			{
				get
				{
					return QuadShape3D.WireEdgeFlags.None;
				}
				set
				{
				}
			}

			// Token: 0x04000FD8 RID: 4056
			private QuadShape3D.WireEdgeFlags _wireEdgeFlags;
		}
	}
}
