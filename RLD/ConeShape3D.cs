using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001DB RID: 475
	public class ConeShape3D : Shape3D
	{
		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x0002249C File Offset: 0x0002069C
		// (set) Token: 0x06001535 RID: 5429 RVA: 0x00019852 File Offset: 0x00017A52
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

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x000224B4 File Offset: 0x000206B4
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x00019854 File Offset: 0x00017A54
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

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x00019856 File Offset: 0x00017A56
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x0001985D File Offset: 0x00017A5D
		public float BaseRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x0001985F File Offset: 0x00017A5F
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x00019866 File Offset: 0x00017A66
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

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x000224CC File Offset: 0x000206CC
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x00019868 File Offset: 0x00017A68
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

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x000224E4 File Offset: 0x000206E4
		public Vector3 CentralAxis
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x000224FC File Offset: 0x000206FC
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x00022514 File Offset: 0x00020714
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x0002252C File Offset: 0x0002072C
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00022544 File Offset: 0x00020744
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x0001986A File Offset: 0x00017A6A
		public ConeEpsilon Epsilon
		{
			get
			{
				return default(ConeEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x0001986C File Offset: 0x00017A6C
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x00019873 File Offset: 0x00017A73
		public float HrzEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x00019875 File Offset: 0x00017A75
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x0001987C File Offset: 0x00017A7C
		public float VertEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x0001987E File Offset: 0x00017A7E
		public ConeShape3D.WireRenderDescriptor WireRenderDesc
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x0002255C File Offset: 0x0002075C
		public static Vector3 ModelRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x00022574 File Offset: 0x00020774
		public static Vector3 ModelUp
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x0002258C File Offset: 0x0002078C
		public static Vector3 ModelLook
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x000225A4 File Offset: 0x000207A4
		public static Vector3 ModelBaseCenter
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00019881 File Offset: 0x00017A81
		public void AlignTip(Vector3 axis)
		{
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00019883 File Offset: 0x00017A83
		public override void RenderSolid()
		{
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00019885 File Offset: 0x00017A85
		public override void RenderWire()
		{
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x00019887 File Offset: 0x00017A87
		public override bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00019891 File Offset: 0x00017A91
		public bool ContainsPoint(Vector3 point)
		{
			return false;
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00019894 File Offset: 0x00017A94
		public List<Vector3> GetBaseExtents()
		{
			return null;
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x000225BC File Offset: 0x000207BC
		public override AABB GetAABB()
		{
			return default(AABB);
		}

		// Token: 0x040007A6 RID: 1958
		private ConeShape3D.WireRenderDescriptor _wireRenderDesc;

		// Token: 0x040007A7 RID: 1959
		private Vector3 _baseCenter;

		// Token: 0x040007A8 RID: 1960
		private Quaternion _rotation;

		// Token: 0x040007A9 RID: 1961
		private float _baseRadius;

		// Token: 0x040007AA RID: 1962
		private float _height;

		// Token: 0x040007AB RID: 1963
		private ConeEpsilon _epsilon;

		// Token: 0x020003B0 RID: 944
		public enum WireRenderMode
		{
			// Token: 0x04000FC5 RID: 4037
			Basic,
			// Token: 0x04000FC6 RID: 4038
			Detailed
		}

		// Token: 0x020003B1 RID: 945
		public class WireRenderDescriptor
		{
			// Token: 0x17000C9C RID: 3228
			// (get) Token: 0x06002AF8 RID: 11000 RVA: 0x00026850 File Offset: 0x00024A50
			// (set) Token: 0x06002AF9 RID: 11001 RVA: 0x0001D3E4 File Offset: 0x0001B5E4
			public ConeShape3D.WireRenderMode WireMode
			{
				get
				{
					return ConeShape3D.WireRenderMode.Basic;
				}
				set
				{
				}
			}

			// Token: 0x17000C9D RID: 3229
			// (get) Token: 0x06002AFA RID: 11002 RVA: 0x0001D3E6 File Offset: 0x0001B5E6
			// (set) Token: 0x06002AFB RID: 11003 RVA: 0x0001D3E9 File Offset: 0x0001B5E9
			public int NumDetailAxialRings
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			// Token: 0x17000C9E RID: 3230
			// (get) Token: 0x06002AFC RID: 11004 RVA: 0x0001D3EB File Offset: 0x0001B5EB
			// (set) Token: 0x06002AFD RID: 11005 RVA: 0x0001D3EE File Offset: 0x0001B5EE
			public int NumDetailAxialSegments
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			// Token: 0x04000FC7 RID: 4039
			private ConeShape3D.WireRenderMode _wireMode;

			// Token: 0x04000FC8 RID: 4040
			private int _numDetailAxialRings;

			// Token: 0x04000FC9 RID: 4041
			private int _numDetailAxialSegments;
		}
	}
}
