namespace RLD;

public static class TorusMath
{

	public static List<Vector3> Calc3DHrzExtentPoints(Vector3 torusCenter, float torusCoreRadius, float torusTubeRadius, Quaternion torusRotation) { }

	public static AABB CalcCylAABB(Vector3 torusCenter, float torusCoreRadius, float torusHrzRadius, float torusVertRadius, Quaternion torusRotation) { }

	public static AABB CalcCylModelAABB(float torusCoreRadius, float torusHrzRadius, float torusVertRadius) { }

	public static float CalcSphereRadius(float torusCoreRadius, float torusTubeRadius) { }

	public static bool Raycast(Ray ray, out float t, Vector3 torusCenter, float torusCoreRadius, float torusTubeRadius, Quaternion torusRotation, TorusEpsilon epsilon = null) { }

	public static bool RaycastCylindrical(Ray ray, out float t, Vector3 torusCenter, float torusCoreRadius, float torusHrzRadius, float torusVertRadius, Quaternion torusRotation, TorusEpsilon epsilon = null) { }

}

