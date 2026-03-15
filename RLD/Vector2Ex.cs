namespace RLD;

[Extension]
public static class Vector2Ex
{

	[Extension]
	public static Vector2 Abs(Vector2 v) { }

	[Extension]
	public static float AbsDot(Vector2 v1, Vector2 v2) { }

	public static Vector3 ConvertDirTo3D(Vector2 start, Vector2 end, Vector3 zPos, Camera camera) { }

	public static Vector3 ConvertDirTo3D(Vector2 dir, Vector3 zPos, Camera camera) { }

	public static Vector2 FromValue(float value) { }

	[Extension]
	public static float GetDistanceToSegment(Vector2 point, Vector2 point0, Vector2 point1) { }

	[Extension]
	public static Vector2 GetInverse(Vector2 vector) { }

	[Extension]
	public static Vector2 GetNormal(Vector2 vec) { }

	public static int GetPointClosestToPoint(List<Vector2> points, Vector2 pt) { }

	[Extension]
	public static Vector3 ToVector3(Vector2 vec, float z = 0) { }

}

