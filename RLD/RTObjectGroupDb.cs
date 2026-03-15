namespace RLD;

public class RTObjectGroupDb : MonoSingleton<RTObjectGroupDb>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<GameObject> <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <RemoveNullRefs>b__11_0(GameObject item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <GetGroupByName>b__0(GameObject item) { }

	}

	[SerializeField]
	private List<GameObject> _objectGroups; //Field offset: 0x20

	public int NumGroups
	{
		 get { } //Length: 60
	}

	public RTObjectGroupDb() { }

	public void Add(GameObject gameObject) { }

	public void Clear() { }

	public int get_NumGroups() { }

	public List<GameObject> GetAll() { }

	public GameObject GetGroupByIndex(int index) { }

	public GameObject GetGroupByName(string name) { }

	public bool IsGroup(GameObject gameObject) { }

	public void Remove(GameObject gameObject) { }

	public void RemoveAt(int index) { }

	public void RemoveNullRefs() { }

}

