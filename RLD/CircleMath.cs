using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000151 RID: 337
	public static class CircleMath
	{
		// Token: 0x060010C9 RID: 4297 RVA: 0x00018B26 File Offset: 0x00016D26
		public static List<Vector3> Calc3DExtentPoints(Vector3 circleCenter, float circleRadius, Quaternion circleRotation)
		{
			return null;
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00018B29 File Offset: 0x00016D29
		public static List<Vector2> Calc2DExtentPoints(Vector2 circleCenter, float circleRadius, float degreeCircleRotation)
		{
			return null;
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00018B2C File Offset: 0x00016D2C
		public static bool Raycast(Ray ray, out float t, Vector3 circleCenter, float circleRadius, Vector3 circleNormal, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00018B36 File Offset: 0x00016D36
		public static bool RaycastWire(Ray ray, out float t, Vector3 circleCenter, float circleRadius, Vector3 circleNormal, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00018B40 File Offset: 0x00016D40
		public static bool Contains3DPoint(Vector3 point, bool checkOnPlane, Vector3 circleCenter, float circleRadius, Vector3 circleNormal, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			return false;
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00018B43 File Offset: 0x00016D43
		public static bool Contains2DPoint(Vector2 point, Vector2 circleCenter, float circleRadius, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			return false;
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00018B46 File Offset: 0x00016D46
		public static bool Is2DPointOnBorder(Vector2 point, Vector2 circleCenter, float circleRadius, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			return false;
		}
	}
}
