namespace RLD;

public class RTPrefabLib
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public GameObject unityPrefab; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal bool <Contains>b__0(RTPrefab item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public GameObject unityPrefab; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <GetPrefab>b__0(RTPrefab item) { }

	}

	[CompilerGenerated]
	private PrefabCreatedInLibHandler PrefabCreated; //Field offset: 0x10
	[CompilerGenerated]
	private PrefabRemovedFromLibHandler PrefabRemoved; //Field offset: 0x18
	[CompilerGenerated]
	private PrefabLibClearedHandler Cleared; //Field offset: 0x20
	[SerializeField]
	private string _name; //Field offset: 0x28
	[SerializeField]
	private List<RTPrefab> _prefabs; //Field offset: 0x30

	public event PrefabLibClearedHandler Cleared
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event PrefabCreatedInLibHandler PrefabCreated
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event PrefabRemovedFromLibHandler PrefabRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public int NumPrefabs
	{
		 get { } //Length: 60
	}

	public RTPrefabLib() { }

	[CompilerGenerated]
	public void add_Cleared(PrefabLibClearedHandler value) { }

	[CompilerGenerated]
	public void add_PrefabCreated(PrefabCreatedInLibHandler value) { }

	[CompilerGenerated]
	public void add_PrefabRemoved(PrefabRemovedFromLibHandler value) { }

	public void Clear() { }

	public bool Contains(RTPrefab prefab) { }

	public bool Contains(GameObject unityPrefab) { }

	public RTPrefab CreatePrefab(GameObject unityPrefab, Texture2D prefabPreview) { }

	public RTPrefab CreatePrefabFromSceneObject(GameObject sceneObject) { }

	public List<RTPrefab> CreatePrefabsFromSceneObjects(List<GameObject> sceneObjects) { }

	public string get_Name() { }

	public int get_NumPrefabs() { }

	public RTPrefab GetPrefab(GameObject unityPrefab) { }

	public RTPrefab GetPrefab(int prefabIndex) { }

	public int GetPrefabIndex(RTPrefab prefab) { }

	public void Remove(int prefabIndex) { }

	public void Remove(RTPrefab prefab) { }

	[CompilerGenerated]
	public void remove_Cleared(PrefabLibClearedHandler value) { }

	[CompilerGenerated]
	public void remove_PrefabCreated(PrefabCreatedInLibHandler value) { }

	[CompilerGenerated]
	public void remove_PrefabRemoved(PrefabRemovedFromLibHandler value) { }

	public void set_Name(string value) { }

}

