namespace RLD;

[DefaultMember("Item")]
public class GizmoCap2DCollection
{
	private List<GizmoCap2D> _caps; //Field offset: 0x10
	private Dictionary<Int32, GizmoCap2D> _handleIdToCap; //Field offset: 0x18

	public int Count
	{
		 get { } //Length: 60
	}

	public GizmoCap2D Item
	{
		 get { } //Length: 81
	}

	public GizmoCap2DCollection() { }

	public void Add(GizmoCap2D cap) { }

	public bool Contains(GizmoCap2D cap) { }

	public bool Contains(int capHandleId) { }

	public int get_Count() { }

	public GizmoCap2D get_Item(int id) { }

	public void Make2DHoverPriorityHigherThan(Priority priority) { }

	public void Make2DHoverPriorityLowerThan(Priority priority) { }

	public void Remove(GizmoCap2D cap) { }

	public void Render(Camera camera) { }

	public void SetDragSession(IGizmoDragSession dragSession) { }

	public void SetHoverable(bool hoverable) { }

	public void SetVisible(bool visible) { }

}

