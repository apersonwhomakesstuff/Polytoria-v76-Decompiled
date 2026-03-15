namespace RLD;

public class RTPrefabScrollView : MonoBehaviour
{
	internal sealed class PrefabPreviewClickedHandler : MulticastDelegate
	{

		public PrefabPreviewClickedHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RTPrefab prefab) { }

	}

	internal sealed class PrefabPreviewHoverEnterHandler : MulticastDelegate
	{

		public PrefabPreviewHoverEnterHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RTPrefab prefab) { }

	}

	internal sealed class PrefabPreviewHoverExitHandler : MulticastDelegate
	{

		public PrefabPreviewHoverExitHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RTPrefab prefab, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RTPrefab prefab) { }

	}

	[CompilerGenerated]
	private PrefabPreviewClickedHandler PrefabPreviewClicked; //Field offset: 0x20
	[CompilerGenerated]
	private PrefabPreviewHoverEnterHandler PrefabPreviewHoverEnter; //Field offset: 0x28
	[CompilerGenerated]
	private PrefabPreviewHoverExitHandler PrefabPreviewHoverExit; //Field offset: 0x30
	private ObjectPool _previewButtonPool; //Field offset: 0x38
	private GameObject _gridObject; //Field offset: 0x40
	private GridLayoutGroup _gridLayoutGroup; //Field offset: 0x48
	private List<RTPrefabPreviewButton> _activePreviewButtons; //Field offset: 0x50
	private List<String> _prefabSearchNames; //Field offset: 0x58
	private List<String> _prefabSearchMatches; //Field offset: 0x60

	public event PrefabPreviewClickedHandler PrefabPreviewClicked
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event PrefabPreviewHoverEnterHandler PrefabPreviewHoverEnter
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event PrefabPreviewHoverExitHandler PrefabPreviewHoverExit
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public RTPrefabScrollView() { }

	[CompilerGenerated]
	public void add_PrefabPreviewClicked(PrefabPreviewClickedHandler value) { }

	[CompilerGenerated]
	public void add_PrefabPreviewHoverEnter(PrefabPreviewHoverEnterHandler value) { }

	[CompilerGenerated]
	public void add_PrefabPreviewHoverExit(PrefabPreviewHoverExitHandler value) { }

	public void AddPrefabPreview(RTPrefab prefab) { }

	private void Awake() { }

	public void ClearPreviews() { }

	public void FilterPrefabsByName(string name) { }

	private void OnPrefabPreviewHoverEnter(RTPrefab prefab) { }

	private void OnPrefabPreviewHoverExit(RTPrefab prefab) { }

	private void OnPreviewButtonClicked() { }

	private void prefabNames(List<String> names) { }

	[CompilerGenerated]
	public void remove_PrefabPreviewClicked(PrefabPreviewClickedHandler value) { }

	[CompilerGenerated]
	public void remove_PrefabPreviewHoverEnter(PrefabPreviewHoverEnterHandler value) { }

	[CompilerGenerated]
	public void remove_PrefabPreviewHoverExit(PrefabPreviewHoverExitHandler value) { }

	public void SyncWithLib(RTPrefabLib prefabLib) { }

}

