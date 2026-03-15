namespace RLD;

[DefaultMember("Item")]
public class GizmoLineSlider2DCollection
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public int capHandleId; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <ContainsCapId>b__0(GizmoLineSlider2D item) { }

	}

	private List<GizmoLineSlider2D> _sliders; //Field offset: 0x10
	private Dictionary<Int32, GizmoLineSlider2D> _handleIdToSlider; //Field offset: 0x18

	public int Count
	{
		 get { } //Length: 60
	}

	public GizmoLineSlider2D Item
	{
		 get { } //Length: 81
	}

	public GizmoLineSlider2DCollection() { }

	public void Add(GizmoLineSlider2D slider) { }

	public bool Contains(GizmoLineSlider2D slider) { }

	public bool Contains(int sliderHandleId) { }

	public bool ContainsCapId(int capHandleId) { }

	public int get_Count() { }

	public GizmoLineSlider2D get_Item(int id) { }

	public void Make2DHoverPriorityHigherThan(Priority priority) { }

	public void Make2DHoverPriorityLowerThan(Priority priority) { }

	public void Remove(GizmoLineSlider2D slider) { }

	public void Render(Camera camera) { }

	public void Set2DCapsVisible(bool visible) { }

	public void SetOffsetDragOrigin(Vector3 dragOrigin) { }

	public void SetSnapEnabled(bool isEnabled) { }

	public void SetVisible(bool visible) { }

}

