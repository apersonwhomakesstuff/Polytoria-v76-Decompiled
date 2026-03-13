using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001D7 RID: 471
	public class BoxShape3D : Shape3D
	{
		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x00021F8C File Offset: 0x0002018C
		// (set) Token: 0x060014A9 RID: 5289 RVA: 0x00019714 File Offset: 0x00017914
		public Vector3 Size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x00019716 File Offset: 0x00017916
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x0001971D File Offset: 0x0001791D
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

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x0001971F File Offset: 0x0001791F
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x00019726 File Offset: 0x00017926
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

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x00019728 File Offset: 0x00017928
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x0001972F File Offset: 0x0001792F
		public float Depth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x00021FA4 File Offset: 0x000201A4
		public Vector3 Extents
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x00021FBC File Offset: 0x000201BC
		// (set) Token: 0x060014B2 RID: 5298 RVA: 0x00019731 File Offset: 0x00017931
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

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x00021FD4 File Offset: 0x000201D4
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x00019733 File Offset: 0x00017933
		public BoxEpsilon Epsilon
		{
			get
			{
				return default(BoxEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x00021FEC File Offset: 0x000201EC
		// (set) Token: 0x060014B6 RID: 5302 RVA: 0x00019735 File Offset: 0x00017935
		public Vector3 SizeEps
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x00019737 File Offset: 0x00017937
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x0001973E File Offset: 0x0001793E
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

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x00019740 File Offset: 0x00017940
		// (set) Token: 0x060014BA RID: 5306 RVA: 0x00019747 File Offset: 0x00017947
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

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x00019749 File Offset: 0x00017949
		// (set) Token: 0x060014BC RID: 5308 RVA: 0x00019750 File Offset: 0x00017950
		public float DepthEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x00022004 File Offset: 0x00020204
		// (set) Token: 0x060014BE RID: 5310 RVA: 0x00019752 File Offset: 0x00017952
		public Vector3 Min
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x0002201C File Offset: 0x0002021C
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x00019754 File Offset: 0x00017954
		public Vector3 Max
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x00022034 File Offset: 0x00020234
		// (set) Token: 0x060014C2 RID: 5314 RVA: 0x00019756 File Offset: 0x00017956
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

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x0002204C File Offset: 0x0002024C
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x00022064 File Offset: 0x00020264
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x0002207C File Offset: 0x0002027C
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x00019758 File Offset: 0x00017958
		public BoxShape3D.WireRenderDescriptor WireRenderDesc
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x00022094 File Offset: 0x00020294
		public static Vector3 ModelRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x000220AC File Offset: 0x000202AC
		public static Vector3 ModelUp
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x000220C4 File Offset: 0x000202C4
		public static Vector3 ModelLook
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x000220DC File Offset: 0x000202DC
		public static Vector3 ModelCenter
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0001975B File Offset: 0x0001795B
		public void FromOBB(OBB obb)
		{
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0001975D File Offset: 0x0001795D
		public float GetSizeAlongDirection(Vector3 direction)
		{
			return 0f;
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00019764 File Offset: 0x00017964
		public void AlignWidth(Vector3 axis)
		{
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00019766 File Offset: 0x00017966
		public void AlignHeight(Vector3 axis)
		{
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00019768 File Offset: 0x00017968
		public void AlignDepth(Vector3 axis)
		{
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x000220F4 File Offset: 0x000202F4
		public Vector3 GetFaceCenter(BoxFace boxFace)
		{
			return default(Vector3);
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0001976A File Offset: 0x0001796A
		public void SetFaceCenter(BoxFace boxFace, Vector3 newCenter)
		{
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0001976C File Offset: 0x0001796C
		public override void RenderSolid()
		{
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0001976E File Offset: 0x0001796E
		public override void RenderWire()
		{
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00019770 File Offset: 0x00017970
		public override bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0002210C File Offset: 0x0002030C
		public override AABB GetAABB()
		{
			return default(AABB);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00022124 File Offset: 0x00020324
		public OBB GetOBB()
		{
			return default(OBB);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0001977A File Offset: 0x0001797A
		public bool ContainsPoint(Vector3 point)
		{
			return false;
		}

		// Token: 0x04000790 RID: 1936
		private BoxShape3D.WireRenderDescriptor _wireRenderDesc;

		// Token: 0x04000791 RID: 1937
		private Vector3 _size;

		// Token: 0x04000792 RID: 1938
		private Vector3 _center;

		// Token: 0x04000793 RID: 1939
		private Quaternion _rotation;

		// Token: 0x04000794 RID: 1940
		private BoxEpsilon _epsilon;

		// Token: 0x020003AE RID: 942
		public enum WireRenderMode
		{
			// Token: 0x04000FC0 RID: 4032
			Wire,
			// Token: 0x04000FC1 RID: 4033
			WireCorners
		}

		// Token: 0x020003AF RID: 943
		public class WireRenderDescriptor
		{
			// Token: 0x17000C9A RID: 3226
			// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x00026838 File Offset: 0x00024A38
			// (set) Token: 0x06002AF4 RID: 10996 RVA: 0x0001D3D1 File Offset: 0x0001B5D1
			public BoxShape3D.WireRenderMode WireMode
			{
				get
				{
					return BoxShape3D.WireRenderMode.Wire;
				}
				set
				{
				}
			}

			// Token: 0x17000C9B RID: 3227
			// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x0001D3D3 File Offset: 0x0001B5D3
			// (set) Token: 0x06002AF6 RID: 10998 RVA: 0x0001D3DA File Offset: 0x0001B5DA
			public float CornerLinePercentage
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			// Token: 0x04000FC2 RID: 4034
			private float _cornerLinePercentage;

			// Token: 0x04000FC3 RID: 4035
			private BoxShape3D.WireRenderMode _wireMode;
		}
	}
}
