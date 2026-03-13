using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001EF RID: 495
	public class SphereShape3D : Shape3D
	{
		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x00019C78 File Offset: 0x00017E78
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x00019C7F File Offset: 0x00017E7F
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

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x00019C81 File Offset: 0x00017E81
		public float WireRadius
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x000232C4 File Offset: 0x000214C4
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x00019C88 File Offset: 0x00017E88
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

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x000232DC File Offset: 0x000214DC
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x00019C8A File Offset: 0x00017E8A
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

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x000232F4 File Offset: 0x000214F4
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x00019C8C File Offset: 0x00017E8C
		public SphereEpsilon Epsilon
		{
			get
			{
				return default(SphereEpsilon);
			}
			set
			{
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x00019C8E File Offset: 0x00017E8E
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x00019C95 File Offset: 0x00017E95
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

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x00019C97 File Offset: 0x00017E97
		public SphereShape3D.WireRenderDescriptor WireRenderDesc
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x0002330C File Offset: 0x0002150C
		public Vector3 CentralAxis
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x00023324 File Offset: 0x00021524
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x0002333C File Offset: 0x0002153C
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x00023354 File Offset: 0x00021554
		public Vector3 Look
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x0002336C File Offset: 0x0002156C
		public static Vector3 ModelRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x00023384 File Offset: 0x00021584
		public static Vector3 ModelUp
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x0002339C File Offset: 0x0002159C
		public static Vector3 ModelLook
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x000233B4 File Offset: 0x000215B4
		public static Vector3 ModelCenter
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00019C9A File Offset: 0x00017E9A
		public override void RenderSolid()
		{
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00019C9C File Offset: 0x00017E9C
		public override void RenderWire()
		{
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00019C9E File Offset: 0x00017E9E
		public override bool Raycast(Ray ray, out float t)
		{
			t = 0f;
			return false;
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00019CA8 File Offset: 0x00017EA8
		public bool ContainsPoint(Vector3 point)
		{
			return false;
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x000233CC File Offset: 0x000215CC
		public override AABB GetAABB()
		{
			return default(AABB);
		}

		// Token: 0x04000805 RID: 2053
		private float _radius;

		// Token: 0x04000806 RID: 2054
		private Vector3 _center;

		// Token: 0x04000807 RID: 2055
		private Quaternion _rotation;

		// Token: 0x04000808 RID: 2056
		private SphereEpsilon _epsilon;

		// Token: 0x04000809 RID: 2057
		private SphereShape3D.WireRenderDescriptor _wireRenderDesc;

		// Token: 0x020003B6 RID: 950
		public enum WireRenderMode
		{
			// Token: 0x04000FDA RID: 4058
			Basic,
			// Token: 0x04000FDB RID: 4059
			Detailed
		}

		// Token: 0x020003B7 RID: 951
		public class WireRenderDescriptor
		{
			// Token: 0x17000CA4 RID: 3236
			// (get) Token: 0x06002B0B RID: 11019 RVA: 0x000268C8 File Offset: 0x00024AC8
			// (set) Token: 0x06002B0C RID: 11020 RVA: 0x0001D419 File Offset: 0x0001B619
			public SphereShape3D.WireRenderMode WireMode
			{
				get
				{
					return SphereShape3D.WireRenderMode.Basic;
				}
				set
				{
				}
			}

			// Token: 0x17000CA5 RID: 3237
			// (get) Token: 0x06002B0D RID: 11021 RVA: 0x0001D41B File Offset: 0x0001B61B
			// (set) Token: 0x06002B0E RID: 11022 RVA: 0x0001D41E File Offset: 0x0001B61E
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

			// Token: 0x17000CA6 RID: 3238
			// (get) Token: 0x06002B0F RID: 11023 RVA: 0x0001D420 File Offset: 0x0001B620
			// (set) Token: 0x06002B10 RID: 11024 RVA: 0x0001D423 File Offset: 0x0001B623
			public int NumDetailSliceRings
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			// Token: 0x17000CA7 RID: 3239
			// (get) Token: 0x06002B11 RID: 11025 RVA: 0x0001D425 File Offset: 0x0001B625
			// (set) Token: 0x06002B12 RID: 11026 RVA: 0x0001D42C File Offset: 0x0001B62C
			public float RadiusAdd
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			// Token: 0x04000FDC RID: 4060
			private SphereShape3D.WireRenderMode _wireMode;

			// Token: 0x04000FDD RID: 4061
			private int _numDetailAxialRings;

			// Token: 0x04000FDE RID: 4062
			private int _numDetailSliceRings;

			// Token: 0x04000FDF RID: 4063
			private float _radiusAdd;
		}
	}
}
