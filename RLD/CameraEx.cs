using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200011E RID: 286
	public static class CameraEx
	{
		// Token: 0x06000F2C RID: 3884 RVA: 0x0001878D File Offset: 0x0001698D
		public static bool IsCurrent(Camera camera)
		{
			return false;
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00018790 File Offset: 0x00016990
		public static float GetFrustumDistanceFromHeight(Camera camera, float frustumHeight)
		{
			return 0f;
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00018797 File Offset: 0x00016997
		public static float GetFOVFromDistanceAndHeight(Camera camera, float frustumHeight, float distance)
		{
			return 0f;
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x0001879E File Offset: 0x0001699E
		public static float GetFrustumWidthFromDistance(Camera camera, float distance)
		{
			return 0f;
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x000187A5 File Offset: 0x000169A5
		public static float GetFrustumHeightFromDistance(Camera camera, float distance)
		{
			return 0f;
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00020844 File Offset: 0x0001EA44
		public static AABB CalculateVolumeAABB(Camera camera)
		{
			return default(AABB);
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0002085C File Offset: 0x0001EA5C
		public static AABB CalculateFrustumAABB(Camera camera)
		{
			return default(AABB);
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00020874 File Offset: 0x0001EA74
		public static AABB CalculateOrthoAABB(Camera camera)
		{
			return default(AABB);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x000187AC File Offset: 0x000169AC
		public static bool IsPointInFrontNearPlane(Camera camera, Vector3 position)
		{
			return false;
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0002088C File Offset: 0x0001EA8C
		public static Plane GetNearPlaneForward(Camera camera)
		{
			return default(Plane);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x000208A4 File Offset: 0x0001EAA4
		public static Vector3 GetFarMidPoint(Camera camera)
		{
			return default(Vector3);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x000208BC File Offset: 0x0001EABC
		public static Vector3 GetFarMidOrthoTop(Camera camera)
		{
			return default(Vector3);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x000187AF File Offset: 0x000169AF
		public static float GetOrthoFOV(Camera camera)
		{
			return 0f;
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x000187B6 File Offset: 0x000169B6
		public static bool IsPointFacingCamera(Camera camera, Vector3 point, Vector3 pointNormal)
		{
			return false;
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x000187B9 File Offset: 0x000169B9
		public static float GetPointZDistance(Camera camera, Vector3 point)
		{
			return 0f;
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x000187C0 File Offset: 0x000169C0
		public static List<Vector3> GetVisibleSphereExtents(Camera camera, Sphere sphere)
		{
			return null;
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x000187C3 File Offset: 0x000169C3
		public static List<Vector2> ConvertWorldToScreenPoints(Camera camera, List<Vector3> worldPoints)
		{
			return null;
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x000187C6 File Offset: 0x000169C6
		public static float ScreenToEstimatedWorldSize(Camera camera, Vector3 worldPos, float screenSize)
		{
			return 0f;
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x000187CD File Offset: 0x000169CD
		public static float EstimateZoomFactor(Camera camera, Vector3 worldPos)
		{
			return 0f;
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x000187D4 File Offset: 0x000169D4
		public static float EstimateZoomFactorSpherical(Camera camera, Vector3 worldPos)
		{
			return 0f;
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x000187DB File Offset: 0x000169DB
		public static void GetVisibleObjects(Camera camera, CameraViewVolume viewVolume, List<GameObject> visibleObjects)
		{
		}

		// Token: 0x04000562 RID: 1378
		private static List<GameObject> _objectBuffer;
	}
}
