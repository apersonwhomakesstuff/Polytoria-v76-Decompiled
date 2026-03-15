namespace RLD;

[Extension]
public static class Vector3Ex
{

	[Extension]
	public static Vector3 Abs(Vector3 v) { }

	[Extension]
	public static float AbsDot(Vector3 v1, Vector3 v2) { }

	public static Vector2 ConvertDirTo2D(Vector3 start, Vector3 end, Camera camera) { }

	[Extension]
	public static float Dot(Vector3 v1, Vector3 v2) { }

	public static Vector3 FromValue(float value) { }

	[Extension]
	public static float GetDistanceToSegment(Vector3 point, Vector3 point0, Vector3 point1) { }

	[Extension]
	public static Vector3 GetInverse(Vector3 vector) { }

	[Extension]
	public static float GetMaxAbsComp(Vector3 v) { }

	public static int GetMostAligned(Vector3[] vectors, Vector3 dir, bool checkSameDirection) { }

	public static int GetPointClosestToPoint(List<Vector3> points, Vector3 pt) { }

	public static Vector3 GetPointCloudCenter(IEnumerable<Vector3> ptCloud) { }

	[Extension]
	public static Vector3 GetSignVector(Vector3 v) { }

	[Extension]
	public static bool IsAligned(Vector3 vector, Vector3 other, bool checkSameDirection) { }

	public static void OffsetPoints(List<Vector3> points, Vector3 offset) { }

	[Extension]
	public static bool PointsSameDir(Vector3 vector, Vector3 other) { }

	[Extension]
	public static Vector3 ProjectOnSegment(Vector3 point, Vector3 point0, Vector3 point1) { }

	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

}

