namespace RLD;

[Extension]
public static class Matrix4x4Ex
{

	[Extension]
	public static Matrix4x4 GetInverse(Matrix4x4 mtx) { }

	[Extension]
	public static Vector3[] GetNormalizedAxes(Matrix4x4 matrix) { }

	[Extension]
	public static Vector3 GetNormalizedAxis(Matrix4x4 matrix, int axisIndex) { }

	[Extension]
	public static Matrix4x4 GetRelativeTransform(Matrix4x4 matrix, Matrix4x4 referenceTransform) { }

	[Extension]
	public static Vector3 GetScale(Matrix4x4 matrix) { }

	[Extension]
	public static Vector3 GetTranslation(Matrix4x4 matrix) { }

	public static Matrix4x4 RotationMatrixFromRightUp(Vector3 right, Vector3 up) { }

	[Extension]
	public static List<Vector3> TransformPoints(Matrix4x4 matrix, List<Vector3> points) { }

	public static Matrix4x4 Translation(Vector3 translation) { }

}

