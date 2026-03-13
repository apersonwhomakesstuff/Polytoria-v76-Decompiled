using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000127 RID: 295
	public static class PlaneEx
	{
		// Token: 0x06000F7D RID: 3965 RVA: 0x000209C4 File Offset: 0x0001EBC4
		public static Plane InvertNormal(Plane plane)
		{
			return default(Plane);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0001886F File Offset: 0x00016A6F
		public static float GetAbsDistanceToPoint(Plane plane, Vector3 point)
		{
			return 0f;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x000209DC File Offset: 0x0001EBDC
		public static Vector3 ProjectPoint(Plane plane, Vector3 pt)
		{
			return default(Vector3);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00018876 File Offset: 0x00016A76
		public static List<Vector3> ProjectAllPoints(Plane plane, List<Vector3> points)
		{
			return null;
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00018879 File Offset: 0x00016A79
		public static int GetFurthestPtInFront(Plane plane, List<Vector3> points)
		{
			return 0;
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0001887C File Offset: 0x00016A7C
		public static int GetClosestPtInFront(Plane plane, List<Vector3> points)
		{
			return 0;
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0001887F File Offset: 0x00016A7F
		public static int GetClosestPtInFrontOrOnPlane(Plane plane, List<Vector3> points)
		{
			return 0;
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00018882 File Offset: 0x00016A82
		public static int GetFurthestPtBehind(Plane plane, List<Vector3> points)
		{
			return 0;
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x000209F4 File Offset: 0x0001EBF4
		public static Plane GetCameraFacingAxisSlicePlane(Vector3 axisOrigin, Vector3 axis, Camera camera)
		{
			return default(Plane);
		}
	}
}
