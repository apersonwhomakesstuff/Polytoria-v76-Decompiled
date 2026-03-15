namespace RLD;

public class SceneOverlapFilter
{
	private List<GameObjectType> _allowedObjectTypes; //Field offset: 0x10
	private List<GameObject> _ignoreObjects; //Field offset: 0x18
	private int _layerMask; //Field offset: 0x20

	public List<GameObjectType> AllowedObjectTypes
	{
		 get { } //Length: 5
	}

	public List<GameObject> IgnoreObjects
	{
		 get { } //Length: 5
	}

	public int LayerMask
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public SceneOverlapFilter() { }

	[CompilerGenerated]
	private bool <FilterOverlaps>b__10_0(GameObject item) { }

	public void FilterOverlaps(List<GameObject> gameObjects) { }

	public List<GameObjectType> get_AllowedObjectTypes() { }

	public List<GameObject> get_IgnoreObjects() { }

	public int get_LayerMask() { }

	public void set_LayerMask(int value) { }

}

