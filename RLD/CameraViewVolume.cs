using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200010D RID: 269
	public class CameraViewVolume
	{
		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x000204FC File Offset: 0x0001E6FC
		public Plane LeftPlane
		{
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00020514 File Offset: 0x0001E714
		public Plane RightPlane
		{
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x0002052C File Offset: 0x0001E72C
		public Plane BottomPlane
		{
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x00020544 File Offset: 0x0001E744
		public Plane TopPlane
		{
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x0002055C File Offset: 0x0001E75C
		public Plane NearPlane
		{
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x00020574 File Offset: 0x0001E774
		public Plane FarPlane
		{
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x0002058C File Offset: 0x0001E78C
		public Vector3 NearTopLeft
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x000205A4 File Offset: 0x0001E7A4
		public Vector3 NearTopRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x000205BC File Offset: 0x0001E7BC
		public Vector3 NearBottomRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x000205D4 File Offset: 0x0001E7D4
		public Vector3 NearBottomLeft
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x000205EC File Offset: 0x0001E7EC
		public Vector3 FarTopLeft
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00020604 File Offset: 0x0001E804
		public Vector3 FarTopRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0002061C File Offset: 0x0001E81C
		public Vector3 FarBottomRight
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x00020634 File Offset: 0x0001E834
		public Vector3 FarBottomLeft
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x0002064C File Offset: 0x0001E84C
		public Vector2 FarPlaneSize
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00020664 File Offset: 0x0001E864
		public Vector2 NearPlaneSize
		{
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x0002067C File Offset: 0x0001E87C
		public AABB WorldAABB
		{
			get
			{
				return default(AABB);
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00020694 File Offset: 0x0001E894
		public OBB WorldOBB
		{
			get
			{
				return default(OBB);
			}
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0001851A File Offset: 0x0001671A
		public CameraViewVolume()
		{
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00018522 File Offset: 0x00016722
		public CameraViewVolume(Camera camera)
		{
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x0001852A File Offset: 0x0001672A
		public void FromCamera(Camera camera)
		{
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x0001852C File Offset: 0x0001672C
		public List<Vector3> GetNearPlanePoints()
		{
			return null;
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0001852F File Offset: 0x0001672F
		public static Plane[] GetCameraWorldPlanes(Camera camera)
		{
			return null;
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00018532 File Offset: 0x00016732
		public bool CheckAABB(AABB aabb)
		{
			return false;
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00018535 File Offset: 0x00016735
		public static bool CheckAABB(Camera camera, AABB aabb)
		{
			return false;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00018538 File Offset: 0x00016738
		public static bool CheckAABB(Camera camera, AABB aabb, Plane[] cameraWorldPlanes)
		{
			return false;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0001853B File Offset: 0x0001673B
		private void CalculateWorldPoints(Camera camera)
		{
		}

		// Token: 0x0400050A RID: 1290
		private const int _numWorldPoints = 8;

		// Token: 0x0400050B RID: 1291
		private const int _numWorldPlanes = 6;

		// Token: 0x0400050C RID: 1292
		private Vector3[] _worldPoints;

		// Token: 0x0400050D RID: 1293
		private Plane[] _worldPlanes;

		// Token: 0x0400050E RID: 1294
		private Vector2 _farPlaneSize;

		// Token: 0x0400050F RID: 1295
		private Vector2 _nearPlaneSize;

		// Token: 0x04000510 RID: 1296
		private AABB _worldAABB;

		// Token: 0x04000511 RID: 1297
		private OBB _worldOBB;

		// Token: 0x02000377 RID: 887
		public enum VPoint
		{
			// Token: 0x04000F11 RID: 3857
			NearTopLeft,
			// Token: 0x04000F12 RID: 3858
			NearTopRight,
			// Token: 0x04000F13 RID: 3859
			NearBottomRight,
			// Token: 0x04000F14 RID: 3860
			NearBottomLeft,
			// Token: 0x04000F15 RID: 3861
			FarTopLeft,
			// Token: 0x04000F16 RID: 3862
			FarTopRight,
			// Token: 0x04000F17 RID: 3863
			FarBottomRight,
			// Token: 0x04000F18 RID: 3864
			FarBottomLeft
		}

		// Token: 0x02000378 RID: 888
		public enum VPlane
		{
			// Token: 0x04000F1A RID: 3866
			Left,
			// Token: 0x04000F1B RID: 3867
			Right,
			// Token: 0x04000F1C RID: 3868
			Bottom,
			// Token: 0x04000F1D RID: 3869
			Top,
			// Token: 0x04000F1E RID: 3870
			Near,
			// Token: 0x04000F1F RID: 3871
			Far
		}
	}
}
