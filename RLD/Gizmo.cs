namespace RLD;

public class Gizmo
{
	[CompilerGenerated]
	private GizmoPostEnabledHandler PostEnabled; //Field offset: 0x10
	[CompilerGenerated]
	private GizmoPostDisabledHandler PostDisabled; //Field offset: 0x18
	[CompilerGenerated]
	private GizmoPreUpdateBeginHandler PreUpdateBegin; //Field offset: 0x20
	[CompilerGenerated]
	private GizmoPostUpdateEndHandler PostUpdateEnd; //Field offset: 0x28
	[CompilerGenerated]
	private GizmoPreHoverEnterHandler PreHoverEnter; //Field offset: 0x30
	[CompilerGenerated]
	private GizmoPostHoverEnterHandler PostHoverEnter; //Field offset: 0x38
	[CompilerGenerated]
	private GizmoPreHoverExitHandler PreHoverExit; //Field offset: 0x40
	[CompilerGenerated]
	private GizmoPostHoverExitHandler PostHoverExit; //Field offset: 0x48
	[CompilerGenerated]
	private GizmoPreDragBeginHandler PreDragBegin; //Field offset: 0x50
	[CompilerGenerated]
	private GizmoPostDragBeginHandler PostDragBegin; //Field offset: 0x58
	[CompilerGenerated]
	private GizmoPreDragEndHandler PreDragEnd; //Field offset: 0x60
	[CompilerGenerated]
	private GizmoPostDragEndHandler PostDragEnd; //Field offset: 0x68
	[CompilerGenerated]
	private GizmoPreDragUpdateHandler PreDragUpdate; //Field offset: 0x70
	[CompilerGenerated]
	private GizmoPostDragUpdateHandler PostDragUpdate; //Field offset: 0x78
	[CompilerGenerated]
	private GizmoPreHandlePickedHandler PreHandlePicked; //Field offset: 0x80
	[CompilerGenerated]
	private GizmoPostHandlePickedHandler PostHandlePicked; //Field offset: 0x88
	[CompilerGenerated]
	private GizmoPreDragBeginAttemptHandler PreDragBeginAttempt; //Field offset: 0x90
	[CompilerGenerated]
	private GizmoPostDragBeginAttemptHandler PostDragBeginAttempt; //Field offset: 0x98
	private bool _isEnabled; //Field offset: 0xA0
	private GizmoHandleCollection _handles; //Field offset: 0xA8
	private GizmoBehaviourCollection _behaviours; //Field offset: 0xB0
	private GizmoHoverInfo _hoverInfo; //Field offset: 0xB8
	private GizmoDragInfo _dragInfo; //Field offset: 0xD0
	private IGizmoHandle _hoveredHandle; //Field offset: 0x140
	private Priority _genericHoverPriority; //Field offset: 0x148
	private Priority _hoverPriority3D; //Field offset: 0x150
	private Priority _hoverPriority2D; //Field offset: 0x158
	private IGizmoDragSession _activeDragSession; //Field offset: 0x160
	private GizmoTransform _transform; //Field offset: 0x168
	private MoveGizmo _moveGizmo; //Field offset: 0x170
	private RotationGizmo _rotationGizmo; //Field offset: 0x178
	private ScaleGizmo _scaleGizmo; //Field offset: 0x180
	private UniversalGizmo _universalGizmo; //Field offset: 0x188
	private ObjectTransformGizmo _objectTransformGizmo; //Field offset: 0x190
	private BoxGizmo _boxGizmo; //Field offset: 0x198
	private ObjectExtrudeGizmo _objectExtrudeGizmo; //Field offset: 0x1A0
	private SceneGizmo _sceneGizmo; //Field offset: 0x1A8

	public event GizmoPostDisabledHandler PostDisabled
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event GizmoPostDragBeginHandler PostDragBegin
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event GizmoPostDragBeginAttemptHandler PostDragBeginAttempt
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event GizmoPostDragEndHandler PostDragEnd
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event GizmoPostDragUpdateHandler PostDragUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event GizmoPostEnabledHandler PostEnabled
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event GizmoPostHandlePickedHandler PostHandlePicked
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event GizmoPostHoverEnterHandler PostHoverEnter
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event GizmoPostHoverExitHandler PostHoverExit
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event GizmoPostUpdateEndHandler PostUpdateEnd
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event GizmoPreDragBeginHandler PreDragBegin
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event GizmoPreDragBeginAttemptHandler PreDragBeginAttempt
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event GizmoPreDragEndHandler PreDragEnd
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event GizmoPreDragUpdateHandler PreDragUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event GizmoPreHandlePickedHandler PreHandlePicked
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event GizmoPreHoverEnterHandler PreHoverEnter
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event GizmoPreHoverExitHandler PreHoverExit
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event GizmoPreUpdateBeginHandler PreUpdateBegin
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public GizmoDragChannel ActiveDragChannel
	{
		 get { } //Length: 7
	}

	public BoxGizmo BoxGizmo
	{
		 get { } //Length: 8
	}

	public Vector3 DragBeginPoint
	{
		 get { } //Length: 25
	}

	public GizmoDimension DragHandleDimension
	{
		 get { } //Length: 7
	}

	public int DragHandleId
	{
		 get { } //Length: 7
	}

	public GizmoDragInfo DragInfo
	{
		 get { } //Length: 91
	}

	public Camera FocusCamera
	{
		 get { } //Length: 143
	}

	public Priority GenericHoverPriority
	{
		 get { } //Length: 8
	}

	public GizmoDimension HoverHandleDimension
	{
		 get { } //Length: 7
	}

	public int HoverHandleId
	{
		 get { } //Length: 7
	}

	public GizmoHoverInfo HoverInfo
	{
		 get { } //Length: 27
	}

	public Vector3 HoverPoint
	{
		 get { } //Length: 25
	}

	public Priority HoverPriority2D
	{
		 get { } //Length: 8
	}

	public Priority HoverPriority3D
	{
		 get { } //Length: 8
	}

	public static int InputDeviceDragButtonIndex
	{
		 get { } //Length: 3
	}

	public bool IsDragged
	{
		 get { } //Length: 8
	}

	public bool IsEnabled
	{
		 get { } //Length: 8
	}

	public bool IsHovered
	{
		 get { } //Length: 8
	}

	public MoveGizmo MoveGizmo
	{
		 get { } //Length: 8
	}

	public int NumHandles
	{
		 get { } //Length: 69
	}

	public ObjectExtrudeGizmo ObjectExtrudeGizmo
	{
		 get { } //Length: 8
	}

	public ObjectTransformGizmo ObjectTransformGizmo
	{
		 get { } //Length: 8
	}

	public Vector3 RelativeDragOffset
	{
		 get { } //Length: 25
	}

	public Quaternion RelativeDragRotation
	{
		 get { } //Length: 14
	}

	public Vector3 RelativeDragScale
	{
		 get { } //Length: 25
	}

	public RotationGizmo RotationGizmo
	{
		 get { } //Length: 8
	}

	public ScaleGizmo ScaleGizmo
	{
		 get { } //Length: 8
	}

	public SceneGizmo SceneGizmo
	{
		 get { } //Length: 8
	}

	public Vector3 TotalDragOffset
	{
		 get { } //Length: 25
	}

	public Quaternion TotalDragRotation
	{
		 get { } //Length: 14
	}

	public Vector3 TotalDragScale
	{
		 get { } //Length: 25
	}

	public GizmoTransform Transform
	{
		 get { } //Length: 8
	}

	public UniversalGizmo UniversalGizmo
	{
		 get { } //Length: 8
	}

	public Gizmo() { }

	[CompilerGenerated]
	public void add_PostDisabled(GizmoPostDisabledHandler value) { }

	[CompilerGenerated]
	public void add_PostDragBegin(GizmoPostDragBeginHandler value) { }

	[CompilerGenerated]
	public void add_PostDragBeginAttempt(GizmoPostDragBeginAttemptHandler value) { }

	[CompilerGenerated]
	public void add_PostDragEnd(GizmoPostDragEndHandler value) { }

	[CompilerGenerated]
	public void add_PostDragUpdate(GizmoPostDragUpdateHandler value) { }

	[CompilerGenerated]
	public void add_PostEnabled(GizmoPostEnabledHandler value) { }

	[CompilerGenerated]
	public void add_PostHandlePicked(GizmoPostHandlePickedHandler value) { }

	[CompilerGenerated]
	public void add_PostHoverEnter(GizmoPostHoverEnterHandler value) { }

	[CompilerGenerated]
	public void add_PostHoverExit(GizmoPostHoverExitHandler value) { }

	[CompilerGenerated]
	public void add_PostUpdateEnd(GizmoPostUpdateEndHandler value) { }

	[CompilerGenerated]
	public void add_PreDragBegin(GizmoPreDragBeginHandler value) { }

	[CompilerGenerated]
	public void add_PreDragBeginAttempt(GizmoPreDragBeginAttemptHandler value) { }

	[CompilerGenerated]
	public void add_PreDragEnd(GizmoPreDragEndHandler value) { }

	[CompilerGenerated]
	public void add_PreDragUpdate(GizmoPreDragUpdateHandler value) { }

	[CompilerGenerated]
	public void add_PreHandlePicked(GizmoPreHandlePickedHandler value) { }

	[CompilerGenerated]
	public void add_PreHoverEnter(GizmoPreHoverEnterHandler value) { }

	[CompilerGenerated]
	public void add_PreHoverExit(GizmoPreHoverExitHandler value) { }

	[CompilerGenerated]
	public void add_PreUpdateBegin(GizmoPreUpdateBeginHandler value) { }

	public bool AddBehaviour(IGizmoBehaviour behaviour) { }

	public BehaviourType AddBehaviour() { }

	public GizmoHandle CreateHandle(int id) { }

	private void EndDragSession() { }

	public GizmoDragChannel get_ActiveDragChannel() { }

	public BoxGizmo get_BoxGizmo() { }

	public Vector3 get_DragBeginPoint() { }

	public GizmoDimension get_DragHandleDimension() { }

	public int get_DragHandleId() { }

	public GizmoDragInfo get_DragInfo() { }

	public Camera get_FocusCamera() { }

	public Priority get_GenericHoverPriority() { }

	public GizmoDimension get_HoverHandleDimension() { }

	public int get_HoverHandleId() { }

	public GizmoHoverInfo get_HoverInfo() { }

	public Vector3 get_HoverPoint() { }

	public Priority get_HoverPriority2D() { }

	public Priority get_HoverPriority3D() { }

	public static int get_InputDeviceDragButtonIndex() { }

	public bool get_IsDragged() { }

	public bool get_IsEnabled() { }

	public bool get_IsHovered() { }

	public MoveGizmo get_MoveGizmo() { }

	public int get_NumHandles() { }

	public ObjectExtrudeGizmo get_ObjectExtrudeGizmo() { }

	public ObjectTransformGizmo get_ObjectTransformGizmo() { }

	public Vector3 get_RelativeDragOffset() { }

	public Quaternion get_RelativeDragRotation() { }

	public Vector3 get_RelativeDragScale() { }

	public RotationGizmo get_RotationGizmo() { }

	public ScaleGizmo get_ScaleGizmo() { }

	public SceneGizmo get_SceneGizmo() { }

	public Vector3 get_TotalDragOffset() { }

	public Quaternion get_TotalDragRotation() { }

	public Vector3 get_TotalDragScale() { }

	public GizmoTransform get_Transform() { }

	public UniversalGizmo get_UniversalGizmo() { }

	public List<GizmoHandleHoverData> GetAllHandlesHoverData(Ray hoverRay) { }

	public List<BehaviourType> GetBehavioursOfType() { }

	public BehaviourType GetFirstBehaviourOfType() { }

	public IGizmoBehaviour GetFirstBehaviourOfType(Type behaviourType) { }

	public IGizmoHandle GetHandleById_SystemCall(int handleId) { }

	public Camera GetWorkCamera() { }

	public void HandleInputDeviceEvents_SystemCall() { }

	public void OnGUI_SystemCall() { }

	private void OnInputDeviceMoved() { }

	private void OnInputDevicePickButtonDown() { }

	private void OnInputDevicePickButtonUp() { }

	public void OnUpdateBegin_SystemCall() { }

	public void OnUpdateEnd_SystemCall() { }

	[CompilerGenerated]
	public void remove_PostDisabled(GizmoPostDisabledHandler value) { }

	[CompilerGenerated]
	public void remove_PostDragBegin(GizmoPostDragBeginHandler value) { }

	[CompilerGenerated]
	public void remove_PostDragBeginAttempt(GizmoPostDragBeginAttemptHandler value) { }

	[CompilerGenerated]
	public void remove_PostDragEnd(GizmoPostDragEndHandler value) { }

	[CompilerGenerated]
	public void remove_PostDragUpdate(GizmoPostDragUpdateHandler value) { }

	[CompilerGenerated]
	public void remove_PostEnabled(GizmoPostEnabledHandler value) { }

	[CompilerGenerated]
	public void remove_PostHandlePicked(GizmoPostHandlePickedHandler value) { }

	[CompilerGenerated]
	public void remove_PostHoverEnter(GizmoPostHoverEnterHandler value) { }

	[CompilerGenerated]
	public void remove_PostHoverExit(GizmoPostHoverExitHandler value) { }

	[CompilerGenerated]
	public void remove_PostUpdateEnd(GizmoPostUpdateEndHandler value) { }

	[CompilerGenerated]
	public void remove_PreDragBegin(GizmoPreDragBeginHandler value) { }

	[CompilerGenerated]
	public void remove_PreDragBeginAttempt(GizmoPreDragBeginAttemptHandler value) { }

	[CompilerGenerated]
	public void remove_PreDragEnd(GizmoPreDragEndHandler value) { }

	[CompilerGenerated]
	public void remove_PreDragUpdate(GizmoPreDragUpdateHandler value) { }

	[CompilerGenerated]
	public void remove_PreHandlePicked(GizmoPreHandlePickedHandler value) { }

	[CompilerGenerated]
	public void remove_PreHoverEnter(GizmoPreHoverEnterHandler value) { }

	[CompilerGenerated]
	public void remove_PreHoverExit(GizmoPreHoverExitHandler value) { }

	[CompilerGenerated]
	public void remove_PreUpdateBegin(GizmoPreUpdateBeginHandler value) { }

	public bool RemoveBehaviour(IGizmoBehaviour behaviour) { }

	public void Render_SystemCall(Camera camera, Plane[] worldFrustumPlanes) { }

	public void SetEnabled(bool enabled) { }

	private void TryActivateDragSession() { }

	public void UpdateHandleHoverInfo_SystemCall(GizmoHoverInfo hoverInfo) { }

}

