namespace RLD;

public static class PrimitiveFactory
{
	internal enum PolyBorderDirection : int
	{
		Inward = 0,
		Outward = 1,
	}


	public static List<Vector2> Generate2DArcBorderPoints(Vector2 arcOrigin, Vector2 arcStartPoint, float degreesFromStart, bool forceShortestArc, int numPoints) { }

	public static List<Vector2> Generate2DCircleBorderPointsCW(Vector2 circleCenter, float circleRadius, int numPoints) { }

	public static List<Vector2> Generate2DPolyBorderPointsCW(List<Vector2> cwPolyPoints, PolyBorderDirection borderDirection, float borderThickness, bool isClosed) { }

	public static List<Vector2> Generate2DPolyBorderQuadsCW(List<Vector2> cwPolyPoints, List<Vector2> cwBorderPts, PolyBorderDirection borderDirection, bool isClosed) { }

	public static List<Vector3> Generate3DArcBorderPoints(Vector3 arcOrigin, Vector3 arcStartPoint, Plane arcPlane, float degreesFromStart, bool forceShortestArc, int numPoints) { }

	public static List<Vector3> Generate3DCircleBorderPoints(Vector3 circleCenter, float circleRadius, Vector3 circleRight, Vector3 circleUp, int numPoints) { }

	public static List<Vector3> GenerateSphereBorderPoints(Camera camera, Vector3 sphereCenter, float sphereRadius, int numPoints) { }

	public static float PolyBorderDirToSign(PolyBorderDirection borderDirection) { }

	public static List<Vector2> ProjectArcPointsOnPoly2DBorder(Vector2 arcOrigin, List<Vector2> arcPoints, List<Vector2> clockwisePolyPoints) { }

}

