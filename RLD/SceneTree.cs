namespace RLD;

public class SceneTree
{
	private SphereTree<GameObject> _objectTree; //Field offset: 0x10
	private Dictionary<GameObject, SphereTreeNode`1<GameObject>> _objectToNode; //Field offset: 0x18
	private List<SphereTreeNodeRayHit`1<GameObject>> _nodeHitBuffer; //Field offset: 0x20
	private List<SphereTreeNode`1<GameObject>> _nodeBuffer; //Field offset: 0x28

	public SceneTree() { }

	private bool CanRegisterObject(GameObject gameObject) { }

	public void DebugDraw() { }

	public bool IsObjectRegistered(GameObject gameObject) { }

	public void OnObjectTransformChanged(Transform objectTransform) { }

	public bool OverlapBox(OBB obb, List<GameObject> gameObjects) { }

	public bool RaycastAll(Ray ray, SceneRaycastPrecision raycastPresicion, List<GameObjectRayHit> hits) { }

	public GameObjectRayHit RaycastMeshObject(Ray ray, GameObject gameObject) { }

	public GameObjectRayHit RaycastSpriteObject(Ray ray, GameObject gameObject) { }

	public bool RegisterObject(GameObject gameObject) { }

	public void RemoveNodesWithNullObjects() { }

	public bool UnregisterObject(GameObject gameObject) { }

}

