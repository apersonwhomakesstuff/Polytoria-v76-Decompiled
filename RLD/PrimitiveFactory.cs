using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000166 RID: 358
	public static class PrimitiveFactory
	{
		// Token: 0x06001126 RID: 4390 RVA: 0x00018CD9 File Offset: 0x00016ED9
		public static List<Vector2> Generate2DPolyBorderQuadsCW(List<Vector2> cwPolyPoints, List<Vector2> cwBorderPts, PrimitiveFactory.PolyBorderDirection borderDirection, bool isClosed)
		{
			return null;
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00018CDC File Offset: 0x00016EDC
		public static float PolyBorderDirToSign(PrimitiveFactory.PolyBorderDirection borderDirection)
		{
			return 0f;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00018CE3 File Offset: 0x00016EE3
		public static List<Vector2> Generate2DPolyBorderPointsCW(List<Vector2> cwPolyPoints, PrimitiveFactory.PolyBorderDirection borderDirection, float borderThickness, bool isClosed)
		{
			return null;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00018CE6 File Offset: 0x00016EE6
		public static List<Vector2> Generate2DCircleBorderPointsCW(Vector2 circleCenter, float circleRadius, int numPoints)
		{
			return null;
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00018CE9 File Offset: 0x00016EE9
		public static List<Vector3> Generate3DCircleBorderPoints(Vector3 circleCenter, float circleRadius, Vector3 circleRight, Vector3 circleUp, int numPoints)
		{
			return null;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00018CEC File Offset: 0x00016EEC
		public static List<Vector3> GenerateSphereBorderPoints(Camera camera, Vector3 sphereCenter, float sphereRadius, int numPoints)
		{
			return null;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00018CEF File Offset: 0x00016EEF
		public static List<Vector2> Generate2DArcBorderPoints(Vector2 arcOrigin, Vector2 arcStartPoint, float degreesFromStart, bool forceShortestArc, int numPoints)
		{
			return null;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00018CF2 File Offset: 0x00016EF2
		public static List<Vector2> ProjectArcPointsOnPoly2DBorder(Vector2 arcOrigin, List<Vector2> arcPoints, List<Vector2> clockwisePolyPoints)
		{
			return null;
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00018CF5 File Offset: 0x00016EF5
		public static List<Vector3> Generate3DArcBorderPoints(Vector3 arcOrigin, Vector3 arcStartPoint, Plane arcPlane, float degreesFromStart, bool forceShortestArc, int numPoints)
		{
			return null;
		}

		// Token: 0x0200038D RID: 909
		public enum PolyBorderDirection
		{
			// Token: 0x04000F67 RID: 3943
			Inward,
			// Token: 0x04000F68 RID: 3944
			Outward
		}
	}
}
