namespace RLD;

public class LocalGizmoTransformSnapshot
{
	private GizmoTransform _transform; //Field offset: 0x10
	private GizmoTransform _parentTransform; //Field offset: 0x18
	private Vector3 _localPosition3D; //Field offset: 0x20
	private Quaternion _localRotation3D; //Field offset: 0x2C
	private Vector2 _localPosition2D; //Field offset: 0x3C
	private float _localRotation2D_Degrees; //Field offset: 0x44

	public GizmoTransform Transform
	{
		 get { } //Length: 5
	}

	public LocalGizmoTransformSnapshot() { }

	public void Apply() { }

	public GizmoTransform get_Transform() { }

	public static List<LocalGizmoTransformSnapshot> GetSnapshotCollection(IEnumerable<Gizmo> gizmos) { }

	public void Snapshot(GizmoTransform transform) { }

}

