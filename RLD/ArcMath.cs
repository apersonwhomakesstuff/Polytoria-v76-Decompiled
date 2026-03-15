namespace RLD;

public static class ArcMath
{

	public static OBB CalcLg3DArcOBB(Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = null) { }

	public static OBB CalcSh3DArcOBB(Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = null) { }

	public static float ConvertToSh2DArcAngle(Vector2 arcOrigin, Vector2 arcStartPoint, float degreesFromStart) { }

	public static float ConvertToSh3DArcAngle(Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart) { }

	public static bool Is3DPointOnLgArcWire(Vector3 point, bool checkOnPlane, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = null) { }

	public static bool Is3DPointOnShArcWire(Vector3 point, bool checkOnPlane, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = null) { }

	public static bool LgArcContains2DPoint(Vector2 point, Vector2 arcOrigin, Vector2 arcStartPoint, float degreesFromStart, ArcEpsilon epsilon = null) { }

	public static bool LgArcContains3DPoint(Vector3 point, bool checkOnPlane, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = null) { }

	public static bool RaycastLgArc(Ray ray, out float t, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = null) { }

	public static bool RaycastLgArcWire(Ray ray, out float t, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = null) { }

	public static bool RaycastShArc(Ray ray, out float t, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = null) { }

	public static bool RaycastShArcWire(Ray ray, out float t, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = null) { }

	public static bool ShArcContains2DPoint(Vector2 point, Vector2 arcOrigin, Vector2 arcStartPoint, float degreesFromStart, ArcEpsilon epsilon = null) { }

	public static bool ShArcContains3DPoint(Vector3 point, bool checkOnPlane, Vector3 arcOrigin, Vector3 arcStartPoint, Vector3 arcPlaneNormal, float degreesFromStart, ArcEpsilon epsilon = null) { }

}

