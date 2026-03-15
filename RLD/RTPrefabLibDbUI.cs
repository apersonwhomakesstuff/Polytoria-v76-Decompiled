namespace RLD;

public class RTPrefabLibDbUI : MonoBehaviour
{
	private RTActiveLibDropDown _activeLibDropDown; //Field offset: 0x20
	private RTPrefabScrollView _prefabScrollView; //Field offset: 0x28
	private RTHoveredPrefabNameLabel _hoveredPrefabNameLabel; //Field offset: 0x30
	private RTPrefabSearch _prefabSearch; //Field offset: 0x38

	public RTActiveLibDropDown ActiveLibDropDown
	{
		 get { } //Length: 5
	}

	public RTHoveredPrefabNameLabel HoveredPrefabNameLabel
	{
		 get { } //Length: 95
	}

	public RTPrefabScrollView PrefabScrollView
	{
		 get { } //Length: 5
	}

	public RTPrefabSearch PrefabSearch
	{
		 get { } //Length: 5
	}

	public RTPrefabLibDbUI() { }

	[CompilerGenerated]
	private void <Awake>b__12_0(string p) { }

	private void Awake() { }

	public RTActiveLibDropDown get_ActiveLibDropDown() { }

	public RTHoveredPrefabNameLabel get_HoveredPrefabNameLabel() { }

	public RTPrefabScrollView get_PrefabScrollView() { }

	public RTPrefabSearch get_PrefabSearch() { }

	private void OnPrefabPreviewHoverEnter(RTPrefab prefab) { }

	private void OnPrefabPreviewHoverExit(RTPrefab prefab) { }

	private void OnPrefabSearchFieldValueChanged(string value) { }

}

