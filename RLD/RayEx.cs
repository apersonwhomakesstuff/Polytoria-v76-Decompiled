namespace RLD;

[Extension]
public static class RayEx
{

	[Extension]
	public static Ray InverseTransform(Ray ray, Matrix4x4 transformMatrix) { }

	[Extension]
	public static Ray Mirror(Ray ray, Vector3 mirrorPoint) { }

}

