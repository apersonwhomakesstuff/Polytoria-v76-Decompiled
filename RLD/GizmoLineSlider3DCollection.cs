namespace RLD;

[DefaultMember("Item")]
public class GizmoLineSlider3DCollection
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public Camera renderCamera; //Field offset: 0x10
		public Vector3 cameraPos; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal int <GetRenderSortedSliders>b__0(GizmoLineSlider3D s0, GizmoLineSlider3D s1) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public int capHandleId; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <ContainsCapId>b__0(GizmoLineSlider3D item) { }

	}

	private List<GizmoLineSlider3D> _sliders; //Field offset: 0x10
	private Dictionary<Int32, GizmoLineSlider3D> _handleIdToSlider; //Field offset: 0x18

	public int Count
	{
		 get { } //Length: 60
	}

	public GizmoLineSlider3D Item
	{
		 get { } //Length: 81
	}

	public GizmoLineSlider3DCollection() { }

	public void Add(GizmoLineSlider3D slider) { }

	public void ApplyZoomFactor(Camera camera) { }

	public bool Contains(GizmoLineSlider3D slider) { }

	public bool Contains(int sliderHandleId) { }

	public bool ContainsCapId(int capHandleId) { }

	public int get_Count() { }

	public GizmoLineSlider3D get_Item(int id) { }

	public List<GizmoLineSlider3D> GetRenderSortedSliders(Camera renderCamera) { }

	public void Make3DHoverPriorityHigherThan(Priority priority) { }

	public void Make3DHoverPriorityLowerThan(Priority priority) { }

	public void RegisterScalerHandle(int handleId, IEnumerable<Int32> scaleDragAxisIndices) { }

	public void Remove(GizmoLineSlider3D slider) { }

	public void Set3DCapsVisible(bool visible) { }

	public void SetDragChannel(GizmoDragChannel dragChannel) { }

	public void SetSnapEnabled(bool isEnabled) { }

	public void SetVisible(bool visible) { }

	public void SetZoomFactorTransform(GizmoTransform zoomFactorTransform) { }

}

