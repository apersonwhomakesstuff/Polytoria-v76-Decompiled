namespace RLD;

public class GizmoObjectVertexSnapDrag3D : GizmoDragSession
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public List<GameObject> targetObjects; //Field offset: 0x10
		public Camera focusCamera; //Field offset: 0x18
		public QueryConfig boundsQConfig; //Field offset: 0x20
		public Vector2 inputDevicePos; //Field offset: 0x30

		public <>c__DisplayClass22_0() { }

		internal bool <GatherDestinationObjects>b__0(GameObject a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_1
	{
		public GameObject a; //Field offset: 0x10

		public <>c__DisplayClass22_1() { }

		internal bool <GatherDestinationObjects>b__1(GameObject b) { }

	}

	private IEnumerable<GameObject> _targetObjects; //Field offset: 0x68
	private Vector3 _snapPivot; //Field offset: 0x70
	private bool _isActive; //Field offset: 0x7C
	private List<GameObject> _destinationObjects; //Field offset: 0x80
	private GizmoObjectVertexSnapSettings _settings; //Field offset: 0x88
	private List<GameObject> _visibleObjectBuffer; //Field offset: 0x90

	public virtual GizmoDragChannel DragChannel
	{
		 get { } //Length: 6
	}

	public virtual bool IsActive
	{
		 get { } //Length: 5
	}

	public GizmoObjectVertexSnapSettings Settings
	{
		 set { } //Length: 25
	}

	public Vector3 SnapPivot
	{
		 get { } //Length: 19
	}

	public GizmoObjectVertexSnapDrag3D() { }

	protected virtual void CalculateDragValues() { }

	protected bool CanUseObjectAsSnapDestination(GameObject gameObject) { }

	protected virtual bool DoBeginSession() { }

	protected virtual void DoEndSession() { }

	protected virtual bool DoUpdateSession() { }

	private void GatherDestinationObjects() { }

	public virtual GizmoDragChannel get_DragChannel() { }

	public virtual bool get_IsActive() { }

	public Vector3 get_SnapPivot() { }

	protected bool GetWorldPointClosestToInputDevice(Camera focusCamera, IEnumerable<GameObject> gameObjects, out Vector3 point) { }

	public bool SelectSnapPivotPoint(Gizmo gizmo) { }

	public void set_Settings(GizmoObjectVertexSnapSettings value) { }

	public void SetTargetObjects(IEnumerable<GameObject> targetObjects) { }

}

