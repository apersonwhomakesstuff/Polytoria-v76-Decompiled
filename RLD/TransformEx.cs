namespace RLD;

[Extension]
public static class TransformEx
{

	[Extension]
	public static Quaternion Align(Transform transform, Vector3 normAlignVector, TransformAxis alignmentAxis) { }

	public static List<Transform> FilterParentsOnly(IEnumerable<Transform> transforms) { }

	public static List<Transform> GetGameObjectTransformCollection(IEnumerable<GameObject> gameObjects) { }

	[Extension]
	public static Vector3 GetLocalAxis(Transform transform, AxisDescriptor axisDesc) { }

	[Extension]
	public static Plane GetLocalPlane(Transform transform, PlaneDescriptor planeDesc) { }

	[Extension]
	public static void RotateAroundPivot(Transform transform, Quaternion rotation, Vector3 pivot) { }

	[Extension]
	public static void ScaleFromPivot(Transform transform, Vector3 scaleFactor, Vector3 pivot) { }

	[Extension]
	public static void SetWorldScale(Transform transform, Vector3 worldScale) { }

	[Extension]
	public static void TransformPoints(Transform transform, List<Vector3> points) { }

}

