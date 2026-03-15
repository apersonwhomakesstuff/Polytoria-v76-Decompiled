namespace RLD;

public static class TriangleMath
{
	private static readonly float _eqTriangleAltFactor; //Field offset: 0x0

	public static float EqTriangleAltFactor
	{
		 get { } //Length: 79
	}

	private static TriangleMath() { }

	public static OBB Calc3DTriangleOBB(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 normal, TriangleEpsilon epsilon = null) { }

	public static List<Vector2> CalcEqTriangle2DPoints(Vector2 centroid, float sideLength, Quaternion rotation) { }

	public static List<Vector3> CalcEqTriangle3DPoints(Vector3 centroid, float sideLength, Quaternion rotation) { }

	public static List<Vector2> CalcRATriangle2DPoints(Vector2 rightAngleCorner, float xLength, float yLength, float degreeTriRotation) { }

	public static List<Vector3> CalcRATriangle3DPoints(Vector3 rightAngleCorner, float xLength, float yLength, Quaternion triangleRotation) { }

	public static float CalcRATriangleAltitude(Vector2 sides) { }

	public static float CalcRATriangleHypotenuse(float side0, float side1) { }

	public static float CalcRATriangleHypotenuse(Vector2 sides) { }

	public static bool Contains2DPoint(Vector2 point, Vector2 p0, Vector2 p1, Vector2 p2, TriangleEpsilon epsilon = null) { }

	public static bool Contains3DPoint(Vector3 point, bool checkOnPlane, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = null) { }

	public static float get_EqTriangleAltFactor() { }

	public static float GetEqTriangleAltitude(float sideLength) { }

	public static float GetEqTriangleCentroidAltitude(float sideLength) { }

	public static bool Raycast(Ray ray, out float t, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = null) { }

	public static bool RaycastWire(Ray ray, out float t, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = null) { }

}

