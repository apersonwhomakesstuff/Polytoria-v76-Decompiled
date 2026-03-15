namespace RLD;

[DefaultMember("Item")]
public class GizmoPlaneSlider3DCollection
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Vector3 cameraPos; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal int <GetRenderSortedSliders>b__0(GizmoPlaneSlider3D s0, GizmoPlaneSlider3D s1) { }

	}

	private List<GizmoPlaneSlider3D> _sliders; //Field offset: 0x10
	private Dictionary<Int32, GizmoPlaneSlider3D> _handleIdToSlider; //Field offset: 0x18

	public int Count
	{
		 get { } //Length: 60
	}

	public GizmoPlaneSlider3D Item
	{
		 get { } //Length: 81
	}

	public GizmoPlaneSlider3DCollection() { }

	public void Add(GizmoPlaneSlider3D slider) { }

	public void ApplyZoomFactor(Camera camera) { }

	public bool Contains(GizmoPlaneSlider3D slider) { }

	public bool Contains(int sliderHandleId) { }

	public int get_Count() { }

	public GizmoPlaneSlider3D get_Item(int id) { }

	public List<GizmoPlaneSlider3D> GetRenderSortedSliders(Camera renderCamera) { }

	public void Make3DHoverPriorityHigherThan(Priority priority) { }

	public void Make3DHoverPriorityLowerThan(Priority priority) { }

	public void Remove(GizmoPlaneSlider3D slider) { }

	public void SetBorderHoverable(bool isHoverable) { }

	public void SetBorderVisible(bool isVisible) { }

	public void SetHoverable(bool isHoverable, bool includeBorder) { }

	public void SetSnapEnabled(bool isEnabled) { }

	public void SetVisible(bool isVisible, bool includeBorder) { }

	public void SetZoomFactorTransform(GizmoTransform zoomFactorTransform) { }

}

