namespace RLD;

[Extension]
public static class PlaneEx
{

	[Extension]
	public static float GetAbsDistanceToPoint(Plane plane, Vector3 point) { }

	public static Plane GetCameraFacingAxisSlicePlane(Vector3 axisOrigin, Vector3 axis, Camera camera) { }

	[Extension]
	public static int GetClosestPtInFront(Plane plane, List<Vector3> points) { }

	[Extension]
	public static int GetClosestPtInFrontOrOnPlane(Plane plane, List<Vector3> points) { }

	[Extension]
	public static int GetFurthestPtBehind(Plane plane, List<Vector3> points) { }

	[Extension]
	public static int GetFurthestPtInFront(Plane plane, List<Vector3> points) { }

	[Extension]
	public static Plane InvertNormal(Plane plane) { }

	[Extension]
	public static List<Vector3> ProjectAllPoints(Plane plane, List<Vector3> points) { }

	[Extension]
	public static Vector3 ProjectPoint(Plane plane, Vector3 pt) { }

}

