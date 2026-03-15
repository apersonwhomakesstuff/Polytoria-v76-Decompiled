namespace RLD;

[Extension]
public static class QuaternionEx
{

	[Extension]
	public static float ConvertTo2DRotation(Quaternion quat) { }

	public static Quaternion FromToRotation2D(Vector2 from, Vector2 to) { }

	public static Quaternion FromToRotation3D(Vector3 from, Vector3 to, Vector3 perp180) { }

	public static Quaternion GetRelativeRotation(Quaternion from, Quaternion to) { }

	[Extension]
	public static float Length(Quaternion quat) { }

	public static Quaternion Normalize(Quaternion quat) { }

	[Extension]
	public static void RotatePoints(Quaternion quat, List<Vector3> points, Vector3 pivot) { }

}

