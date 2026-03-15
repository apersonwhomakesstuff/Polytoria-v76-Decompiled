namespace RLD;

[Extension]
public static class GameObjectEx
{
	private static List<Transform> _transformsChildren; //Field offset: 0x0

	private static GameObjectEx() { }

	public static List<GameObject> FilterParentsOnly(IEnumerable<GameObject> gameObjects) { }

	[Extension]
	public static List<GameObject> GetAllChildren(GameObject gameObject) { }

	[Extension]
	public static List<GameObject> GetAllChildrenAndSelf(GameObject gameObject) { }

	[Extension]
	public static void GetAllChildrenAndSelf(GameObject gameObject, List<GameObject> childrenAndSelf) { }

	[Extension]
	public static GameObjectType GetGameObjectType(GameObject gameObject) { }

	[Extension]
	public static Mesh GetMesh(GameObject gameObject) { }

	[Extension]
	public static List<GameObject> GetMeshObjectsInHierarchy(GameObject root) { }

	[Extension]
	public static Renderer GetMeshRenderer(GameObject gameObject) { }

	public static List<GameObject> GetRoots(IEnumerable<GameObject> gameObjects) { }

	[Extension]
	public static Sprite GetSprite(GameObject gameObject) { }

	[Extension]
	public static List<GameObject> GetSpriteObjectsInHierarchy(GameObject root) { }

	[Extension]
	public static bool HierarchyHasMesh(GameObject root) { }

	[Extension]
	public static bool HierarchyHasObjectsOfType(GameObject root, GameObjectType typeFlags) { }

	[Extension]
	public static bool HierarchyHasSprite(GameObject root) { }

	[Extension]
	public static void InheritHierarchyLayers(GameObject hierarchy, GameObject sourceHierarchy) { }

	[Extension]
	public static bool IsRLDAppObject(GameObject gameObject) { }

	[Extension]
	public static void SetHierarchyWorldScaleByPivot(GameObject root, Vector3 worldScale, Vector3 pivotPoint) { }

	[Extension]
	public static void SetStatic(GameObject gameObject, bool isStatic, bool affectChildren) { }

}

