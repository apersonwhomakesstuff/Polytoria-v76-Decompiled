namespace RLD;

[DefaultMember("Item")]
public class GizmoHandleCollection
{
	private Gizmo _gizmo; //Field offset: 0x10
	private List<IGizmoHandle> _handles; //Field offset: 0x18
	private Dictionary<Int32, IGizmoHandle> _idToHandle; //Field offset: 0x20

	public int Count
	{
		 get { } //Length: 60
	}

	public Gizmo Gizmo
	{
		 get { } //Length: 5
	}

	public IGizmoHandle Item
	{
		 get { } //Length: 81
	}

	public GizmoHandleCollection(Gizmo gizmo) { }

	public void Add(IGizmoHandle handle) { }

	public void Clear() { }

	public bool Contains(IGizmoHandle handle) { }

	public bool Contains(int handleId) { }

	public int get_Count() { }

	public Gizmo get_Gizmo() { }

	public IGizmoHandle get_Item(int index) { }

	public List<IGizmoHandle> GetAll() { }

	public List<GizmoHandleHoverData> GetAllHandlesHoverData(Ray hoverRay) { }

	public IGizmoHandle GetHandleById(int handleId) { }

	public void Remove(IGizmoHandle handle) { }

}

