namespace RLD;

public class ObjectTransformGizmoSettings : Settings
{
	[SerializeField]
	private int _transformableLayers; //Field offset: 0x28
	private HashSet<GameObject> _nonTransformableObjects; //Field offset: 0x30

	public int TransformableLayers
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public ObjectTransformGizmoSettings() { }

	public int get_TransformableLayers() { }

	public bool IsLayerTransformable(int objectLayer) { }

	public bool IsObjectTransformable(GameObject gameObject) { }

	public void set_TransformableLayers(int value) { }

	public void SetLayerTransformable(int objectLayer, bool isTransformable) { }

	public void SetObjectCollectionTransformable(List<GameObject> gameObjectCollection, bool areTransformable) { }

	public void SetObjectTransformable(GameObject gameObject, bool isTransformable) { }

}

