namespace RLD;

public class GizmoCollectionEnabledStateSnapshot
{
	private Dictionary<Gizmo, Boolean> _gizmoToState; //Field offset: 0x10

	public GizmoCollectionEnabledStateSnapshot() { }

	public void Apply() { }

	public void Snapshot(IEnumerable<Gizmo> gizmos) { }

}

