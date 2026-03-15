namespace RLD;

public static class ObjectVertexCollect
{
	private static List<Vector3> _hierarchyVertsCollectBuffer; //Field offset: 0x0

	private static ObjectVertexCollect() { }

	public static List<Vector3> CollectHierarchyVerts(GameObject root, BoxFace collectFace, float collectBoxScale, float collectEps) { }

	public static List<Vector3> CollectModelSpriteVerts(Sprite sprite, AABB collectAABB) { }

	public static List<Vector3> CollectWorldSpriteVerts(Sprite sprite, Transform spriteTransform, OBB collectOBB) { }

}

