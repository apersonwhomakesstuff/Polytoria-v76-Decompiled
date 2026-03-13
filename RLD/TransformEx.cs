using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200012F RID: 303
	public static class TransformEx
	{
		// Token: 0x06000FA4 RID: 4004 RVA: 0x000188B9 File Offset: 0x00016AB9
		public static void TransformPoints(Transform transform, List<Vector3> points)
		{
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x000188BB File Offset: 0x00016ABB
		public static List<Transform> GetGameObjectTransformCollection(IEnumerable<GameObject> gameObjects)
		{
			return null;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x000188BE File Offset: 0x00016ABE
		public static List<Transform> FilterParentsOnly(IEnumerable<Transform> transforms)
		{
			return null;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x000188C1 File Offset: 0x00016AC1
		public static void SetWorldScale(Transform transform, Vector3 worldScale)
		{
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000188C3 File Offset: 0x00016AC3
		public static void ScaleFromPivot(Transform transform, Vector3 scaleFactor, Vector3 pivot)
		{
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x000188C5 File Offset: 0x00016AC5
		public static void RotateAroundPivot(Transform transform, Quaternion rotation, Vector3 pivot)
		{
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00020B74 File Offset: 0x0001ED74
		public static Vector3 GetLocalAxis(Transform transform, AxisDescriptor axisDesc)
		{
			return default(Vector3);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00020B8C File Offset: 0x0001ED8C
		public static Plane GetLocalPlane(Transform transform, PlaneDescriptor planeDesc)
		{
			return default(Plane);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00020BA4 File Offset: 0x0001EDA4
		public static Quaternion Align(Transform transform, Vector3 normAlignVector, TransformAxis alignmentAxis)
		{
			return default(Quaternion);
		}
	}
}
