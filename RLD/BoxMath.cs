namespace RLD;

public static class BoxMath
{
	private static List<BoxFace> _allBoxFaces; //Field offset: 0x0
	private static Vector3[] A; //Field offset: 0x8
	private static Vector3[] B; //Field offset: 0x10
	private static Single[2] R; //Field offset: 0x18
	private static Single[2] absR; //Field offset: 0x20

	public static List<BoxFace> AllBoxFaces
	{
		 get { } //Length: 150
	}

	private static BoxMath() { }

	public static bool BoxIntersectsBox(Vector3 center0, Vector3 size0, Quaternion rotation0, Vector3 center1, Vector3 size1, Quaternion rotation1) { }

	public static List<Vector3> CalcBoxCornerPoints(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation) { }

	public static Vector3 CalcBoxFaceCenter(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxFace boxFace) { }

	public static Vector3 CalcBoxFaceNormal(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxFace boxFace) { }

	public static Plane CalcBoxFacePlane(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxFace boxFace) { }

	public static Vector3 CalcBoxFaceSize(Vector3 boxSize, BoxFace boxFace) { }

	public static Vector3 CalcBoxPtClosestToPt(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation) { }

	public static bool ContainsPoint(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxEpsilon epsilon = null) { }

	public static List<BoxFace> get_AllBoxFaces() { }

	public static BoxFaceAreaDesc GetBoxFaceAreaDesc(Vector3 boxSize, BoxFace boxFace) { }

	public static int GetFaceAxisIndex(BoxFace face) { }

	public static BoxFaceDesc GetFaceClosestToPoint(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, Vector3 viewVector) { }

	public static BoxFaceDesc GetFaceClosestToPoint(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation) { }

	public static BoxFace GetMostAlignedFace(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, Vector3 direction) { }

	public static bool Raycast(Ray ray, out float t, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxEpsilon epsilon = null) { }

	public static bool Raycast(Ray ray, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxEpsilon epsilon = null) { }

	public static void TransformBox(Vector3 boxCenter, Vector3 boxSize, Matrix4x4 transformMatrix, out Vector3 newBoxCenter, out Vector3 newBoxSize) { }

}

