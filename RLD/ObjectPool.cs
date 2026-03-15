namespace RLD;

public class ObjectPool
{
	internal enum GrowMode : int
	{
		None = 0,
		Increment = 1,
		ByAmount = 2,
	}

	private GameObject _sourceObject; //Field offset: 0x10
	private GrowMode _growMode; //Field offset: 0x18
	private int _growAmount; //Field offset: 0x1C
	private List<GameObject> _pooledObjects; //Field offset: 0x20
	private Transform _pooledParent; //Field offset: 0x28

	public int GrowAmount
	{
		 get { } //Length: 4
		 set { } //Length: 16
	}

	public GrowMode PoolGrowMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public ObjectPool(GameObject sourceObject, int numPooled, GrowMode growMode) { }

	private GameObject CreatePooledObject() { }

	public int get_GrowAmount() { }

	public GrowMode get_PoolGrowMode() { }

	public GameObject GetPooledObject() { }

	private void Grow() { }

	public void MarkAllAsUnused() { }

	public void MarkAsUnused(GameObject gameObject) { }

	public void set_GrowAmount(int value) { }

	public void set_PoolGrowMode(GrowMode value) { }

	public void SetPooledObjectsParent(Transform parent) { }

}

