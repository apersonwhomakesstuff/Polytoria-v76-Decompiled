namespace RLD;

[DefaultMember("Item")]
public class GizmoCap3DCollection
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public Vector3 cameraPos; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal int <GetRenderSortedCaps>b__0(GizmoCap3D c0, GizmoCap3D c1) { }

	}

	private List<GizmoCap3D> _caps; //Field offset: 0x10
	private Dictionary<Int32, GizmoCap3D> _handleIdToCap; //Field offset: 0x18

	public int Count
	{
		 get { } //Length: 60
	}

	public GizmoCap3D Item
	{
		 get { } //Length: 81
	}

	public GizmoCap3DCollection() { }

	public void Add(GizmoCap3D cap) { }

	public void ApplyZoomFactor(Camera camera) { }

	public bool Contains(GizmoCap3D cap) { }

	public bool Contains(int capHandleId) { }

	public int get_Count() { }

	public GizmoCap3D get_Item(int id) { }

	public List<GizmoCap3D> GetRenderSortedCaps(Camera renderCamera) { }

	public void Make3DHoverPriorityHigherThan(Priority priority) { }

	public void Make3DHoverPriorityLowerThan(Priority priority) { }

	public void Remove(GizmoCap3D cap) { }

	public void SetVisible(bool visible) { }

	public void SetZoomFactorTransform(GizmoTransform zoomFactorTransform) { }

}

