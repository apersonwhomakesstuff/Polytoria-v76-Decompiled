namespace RLD;

public class Object2ObjectSnapDataDb : Singleton<Object2ObjectSnapDataDb>
{
	private Dictionary<GameObject, Object2ObjectSnapData> _objectToSnapData; //Field offset: 0x10

	public Object2ObjectSnapDataDb() { }

	public Object2ObjectSnapData GetObject2ObjectSnapData(GameObject gameObject) { }

}

