namespace RLD;

public static class CircleMath
{

	public static List<Vector2> Calc2DExtentPoints(Vector2 circleCenter, float circleRadius, float degreeCircleRotation) { }

	public static List<Vector3> Calc3DExtentPoints(Vector3 circleCenter, float circleRadius, Quaternion circleRotation) { }

	public static bool Contains2DPoint(Vector2 point, Vector2 circleCenter, float circleRadius, CircleEpsilon epsilon = null) { }

	public static bool Contains3DPoint(Vector3 point, bool checkOnPlane, Vector3 circleCenter, float circleRadius, Vector3 circleNormal, CircleEpsilon epsilon = null) { }

	public static bool Is2DPointOnBorder(Vector2 point, Vector2 circleCenter, float circleRadius, CircleEpsilon epsilon = null) { }

	public static bool Raycast(Ray ray, out float t, Vector3 circleCenter, float circleRadius, Vector3 circleNormal, CircleEpsilon epsilon = null) { }

	public static bool RaycastWire(Ray ray, out float t, Vector3 circleCenter, float circleRadius, Vector3 circleNormal, CircleEpsilon epsilon = null) { }

}

