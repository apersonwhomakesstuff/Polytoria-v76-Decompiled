namespace RLD;

public static class ObjectBounds
{
	internal struct QueryConfig
	{
		public GameObjectType ObjectTypes; //Field offset: 0x0
		public Vector3 NoVolumeSize; //Field offset: 0x4

	}

	private static QueryConfig _defaultQConfig; //Field offset: 0x0

	public static QueryConfig DefaultQConfig
	{
		 get { } //Length: 90
	}

	private static ObjectBounds() { }

	public static AABB CalcHierarchyCollectionWorldAABB(List<GameObject> roots, QueryConfig queryConfig) { }

	public static AABB CalcHierarchyModelAABB(GameObject root, QueryConfig queryConfig) { }

	public static AABB CalcHierarchyWorldAABB(GameObject root, QueryConfig queryConfig) { }

	public static OBB CalcHierarchyWorldOBB(GameObject root, QueryConfig queryConfig) { }

	public static AABB CalcMeshModelAABB(GameObject gameObject) { }

	public static AABB CalcMeshWorldAABB(GameObject gameObject) { }

	public static AABB CalcModelAABB(GameObject gameObject, QueryConfig queryConfig, GameObjectType objectType) { }

	public static AABB CalcObjectCollectionWorldAABB(IEnumerable<GameObject> gameObjectCollection, QueryConfig queryConfig) { }

	public static Rect CalcScreenRect(GameObject gameObject, Camera camera, QueryConfig queryConfig) { }

	public static AABB CalcSpriteModelAABB(GameObject spriteObject) { }

	public static AABB CalcSpriteWorldAABB(GameObject gameObject) { }

	public static OBB CalcSpriteWorldOBB(GameObject gameObject) { }

	public static AABB CalcWorldAABB(GameObject gameObject, QueryConfig queryConfig) { }

	public static OBB CalcWorldOBB(GameObject gameObject, QueryConfig queryConfig) { }

	public static QueryConfig get_DefaultQConfig() { }

	public static AABB GetMeshWorldAABB(GameObject gameObject) { }

	public static OBB GetMeshWorldOBB(GameObject gameObject) { }

}

