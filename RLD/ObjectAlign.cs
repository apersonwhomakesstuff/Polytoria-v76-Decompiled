namespace RLD;

public static class ObjectAlign
{
	internal enum Result : int
	{
		Err_NoObjects = 0,
		Success = 1,
	}


	private static void AlignRootsToPlane(List<GameObject> roots, Plane alignmentPlane) { }

	public static Result AlignToWorldAxis(IEnumerable<GameObject> gameObjects, Axis axis, Vector3 alignmentPlaneOrigin) { }

	public static Result AlignToWorldPlane(IEnumerable<GameObject> gameObjects, Plane alignmentPlane) { }

}

