using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000149 RID: 329
	public static class ArcMath
	{
		// Token: 0x060010A7 RID: 4263 RVA: 0x00018AAF File Offset: 0x00016CAF
		public static float ConvertToSh3DArcAngle(Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart)
		{
			return 0f;
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00018AB6 File Offset: 0x00016CB6
		public static float ConvertToSh2DArcAngle(Vector2 arcOrigin, Vector2 arcStartPoint, float degreesFromStart)
		{
			return 0f;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x000214FC File Offset: 0x0001F6FC
		public static OBB CalcSh3DArcOBB(Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			return default(OBB);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00021514 File Offset: 0x0001F714
		public static OBB CalcLg3DArcOBB(Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			return default(OBB);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00018ABD File Offset: 0x00016CBD
		public static bool RaycastShArc(Ray ray, out float t, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00018AC7 File Offset: 0x00016CC7
		public static bool RaycastShArcWire(Ray ray, out float t, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00018AD1 File Offset: 0x00016CD1
		public static bool RaycastLgArc(Ray ray, out float t, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00018ADB File Offset: 0x00016CDB
		public static bool RaycastLgArcWire(Ray ray, out float t, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			t = 0f;
			return false;
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00018AE5 File Offset: 0x00016CE5
		public static bool ShArcContains3DPoint(Vector3 point, bool checkOnPlane, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			return false;
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00018AE8 File Offset: 0x00016CE8
		public static bool Is3DPointOnShArcWire(Vector3 point, bool checkOnPlane, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			return false;
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00018AEB File Offset: 0x00016CEB
		public static bool ShArcContains2DPoint(Vector2 point, Vector2 arcOrigin, Vector2 arcStartPoint, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			return false;
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00018AEE File Offset: 0x00016CEE
		public static bool LgArcContains3DPoint(Vector3 point, bool checkOnPlane, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			return false;
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00018AF1 File Offset: 0x00016CF1
		public static bool Is3DPointOnLgArcWire(Vector3 point, bool checkOnPlane, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			return false;
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00018AF4 File Offset: 0x00016CF4
		public static bool LgArcContains2DPoint(Vector2 point, Vector2 arcOrigin, Vector2 arcStartPoint, float degreesFromStart, ArcEpsilon epsilon = default(ArcEpsilon))
		{
			return false;
		}
	}
}
