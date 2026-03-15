namespace RLD;

[ExecuteInEditMode]
public class RTPrefabLibDb : MonoSingleton<RTPrefabLibDb>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<RTPrefabLib> <>9__29_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <SortLibsByName>b__29_0(RTPrefabLib l0, RTPrefabLib l1) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public string libName; //Field offset: 0x10

		public <>c__DisplayClass44_0() { }

		internal bool <GetLibIndex>b__0(RTPrefabLib item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public string libName; //Field offset: 0x10

		public <>c__DisplayClass47_0() { }

		internal bool <GetLib>b__0(RTPrefabLib item) { }

	}

	[SerializeField]
	private string _newLibName; //Field offset: 0x20
	[SerializeField]
	private Vector2 _prefabScrollPos; //Field offset: 0x28
	[SerializeField]
	private int _numPrefabsPerRow; //Field offset: 0x30
	[CompilerGenerated]
	private PrefabLibDbPrefabSpawnedHander PrefabSpawned; //Field offset: 0x38
	private EditorPrefabPreviewGen _editorPrefabPreviewGen; //Field offset: 0x40
	[SerializeField]
	private PrefabLibDbSettings _settings; //Field offset: 0x48
	[SerializeField]
	private RTPrefabLibDbUI _runtimeUI; //Field offset: 0x50
	[SerializeField]
	private PrefabPreviewLookAndFeel _prefabPreviewLookAndFeel; //Field offset: 0x58
	[SerializeField]
	private int _activeLibIndex; //Field offset: 0x60
	[SerializeField]
	private List<RTPrefabLib> _libs; //Field offset: 0x68

	public event PrefabLibDbPrefabSpawnedHander PrefabSpawned
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public RTPrefabLib ActiveLib
	{
		 get { } //Length: 85
	}

	public int ActiveLibIndex
	{
		 get { } //Length: 4
	}

	public EditorPrefabPreviewGen EditorPrefabPreviewGen
	{
		 get { } //Length: 5
	}

	public bool HasRuntimeUI
	{
		 get { } //Length: 162
	}

	public int NumLibs
	{
		 get { } //Length: 60
	}

	public PrefabPreviewLookAndFeel PrefabPreviewLookAndFeel
	{
		 get { } //Length: 5
	}

	public RTPrefabLibDbUI RuntimeUI
	{
		 get { } //Length: 5
	}

	public PrefabLibDbSettings Settings
	{
		 get { } //Length: 5
	}

	public RTPrefabLibDb() { }

	[CompilerGenerated]
	private void <Start>b__48_0(int <p0>) { }

	[CompilerGenerated]
	public void add_PrefabSpawned(PrefabLibDbPrefabSpawnedHander value) { }

	public void Clear() { }

	public bool Contains(string libName) { }

	public bool Contains(RTPrefabLib lib) { }

	public RTPrefabLib CreateLib(string libName) { }

	public RTPrefabLib get_ActiveLib() { }

	public int get_ActiveLibIndex() { }

	public EditorPrefabPreviewGen get_EditorPrefabPreviewGen() { }

	public bool get_HasRuntimeUI() { }

	public int get_NumLibs() { }

	public PrefabPreviewLookAndFeel get_PrefabPreviewLookAndFeel() { }

	public RTPrefabLibDbUI get_RuntimeUI() { }

	public PrefabLibDbSettings get_Settings() { }

	public List<String> GetAllLibNames() { }

	public List<RTPrefabLib> GetEmptyLibs() { }

	public RTPrefabLib GetLib(string libName) { }

	public RTPrefabLib GetLib(int libIndex) { }

	public int GetLibIndex(RTPrefabLib lib) { }

	public int GetLibIndex(string libName) { }

	private void OnActiveLibDropDownChanged() { }

	private void OnPrefabCreatedInLib(RTPrefabLib prefabLib, RTPrefab prefab) { }

	private void OnPrefabLibCleared(RTPrefabLib prefabLib) { }

	private void OnPrefabPreviewButtonClicked(RTPrefab prefab) { }

	private void OnPrefabRemovedFromLib(RTPrefabLib prefabLib, RTPrefab prefab) { }

	public void Remove(List<RTPrefabLib> libs) { }

	public void Remove(RTPrefabLib lib) { }

	public void Remove(int libIndex) { }

	public void Remove(string libName) { }

	[CompilerGenerated]
	public void remove_PrefabSpawned(PrefabLibDbPrefabSpawnedHander value) { }

	public void RemoveEmptyLibs() { }

	public void SetActiveLib(string libName) { }

	public void SetActiveLib(RTPrefabLib lib) { }

	public void SetActiveLib(int libIndex) { }

	public bool SetLibName(RTPrefabLib lib, string newLibName) { }

	public void SortLibsByName() { }

	private void Start() { }

}

