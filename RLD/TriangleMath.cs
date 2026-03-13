using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000175 RID: 373
	public static class TriangleMath
	{
		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x00018DA6 File Offset: 0x00016FA6
		public static float EqTriangleAltFactor
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00018DAD File Offset: 0x00016FAD
		public static float GetEqTriangleAltitude(float sideLength)
		{
			return 0f;
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00018DB4 File Offset: 0x00016FB4
		public static float GetEqTriangleCentroidAltitude(float sideLength)
		{
			return 0f;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00018DBB File Offset: 0x00016FBB
		public static List<Vector3> CalcEqTriangle3DPoints(Vector3 centroid, float sideLength, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00018DBE File Offset: 0x00016FBE
		public static List<Vector2> CalcEqTriangle2DPoints(Vector2 centroid, float sideLength, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00018DC1 File Offset: 0x00016FC1
		public static float CalcRATriangleHypotenuse(float side0, float side1)
		{
			return 0f;
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00018DC8 File Offset: 0x00016FC8
		public static float CalcRATriangleHypotenuse(Vector2 sides)
		{
			return 0f;
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00018DCF File Offset: 0x00016FCF
		public static float CalcRATriangleAltitude(Vector2 sides)
		{
			return 0f;
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00018DD6 File Offset: 0x00016FD6
		public static List<Vector3> CalcRATriangle3DPoints(Vector3 rightAngleCorner, float xLength, float yLength, Quaternion triangleRotation)
		{
			return null;
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00018DD9 File Offset: 0x00016FD9
		public static List<Vector2> CalcRATriangle2DPoints(Vector2 rightAngleCorner, float xLength, float yLength, float degreeTriRotation)
		{
			return null;
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x000216EC File Offset: 0x0001F8EC
		public static OBB Calc3DTriangleOBB(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 normal, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			return default(OBB);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00018DDC File Offset: 0x00016FDC
		public static bool Raycast(Ray ray, out float t, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00018DE6 File Offset: 0x00016FE6
		public static bool RaycastWire(Ray ray, out float t, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00018DF0 File Offset: 0x00016FF0
		public static bool Contains3DPoint(Vector3 point, bool checkOnPlane, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			return false;
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00018DF3 File Offset: 0x00016FF3
		public static bool Contains2DPoint(Vector2 point, Vector2 p0, Vector2 p1, Vector2 p2, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			return false;
		}

		// Token: 0x04000624 RID: 1572
		private static readonly float _eqTriangleAltFactor;
	}
}
