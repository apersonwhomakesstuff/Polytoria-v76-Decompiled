namespace RLD;

public class GizmoLineSlider3D : GizmoSlider
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_0
	{
		public int handleId; //Field offset: 0x10

		public <>c__DisplayClass78_0() { }

		internal bool <IsScalerHandleRegistered>b__0(GizmoScalerHandle item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_0
	{
		public int handleId; //Field offset: 0x10

		public <>c__DisplayClass79_0() { }

		internal bool <IsScalerHandleRegistered>b__0(GizmoScalerHandle item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass81_0
	{
		public int handleId; //Field offset: 0x10

		public <>c__DisplayClass81_0() { }

		internal bool <UnregisterScalerHandle>b__0(GizmoScalerHandle item) { }

	}

	private SegmentShape3D _segment; //Field offset: 0x28
	private BoxShape3D _box; //Field offset: 0x30
	private CylinderShape3D _cylinder; //Field offset: 0x38
	private int _segmentIndex; //Field offset: 0x40
	private int _boxIndex; //Field offset: 0x44
	private int _cylinderIndex; //Field offset: 0x48
	private IGizmoLineSlider3DController[] _controllers; //Field offset: 0x50
	private GizmoLineSlider3DControllerData _controllerData; //Field offset: 0x58
	private GizmoDragChannel _dragChannel; //Field offset: 0x60
	private GizmoSglAxisOffsetDrag3D _offsetDrag; //Field offset: 0x68
	private GizmoSglAxisRotationDrag3D _rotationDrag; //Field offset: 0x70
	private GizmoRotationArc3D _rotationArc; //Field offset: 0x78
	private GizmoSglAxisScaleDrag3D _scaleDrag; //Field offset: 0x80
	private int _scaleDragAxisIndex; //Field offset: 0x88
	private List<GizmoScalerHandle> _scalerHandles; //Field offset: 0x90
	private IGizmoDragSession _selectedDragSession; //Field offset: 0x98
	private GizmoCap3D _cap3D; //Field offset: 0xA0
	private GizmoTransform _transform; //Field offset: 0xA8
	private GizmoTransformAxisMap3D _directionAxisMap; //Field offset: 0xB0
	private GizmoTransformAxisMap3D _dragRotationAxisMap; //Field offset: 0xB8
	private GizmoOverrideColor _overrideColor; //Field offset: 0xC0
	private GizmoLineSlider3DSettings _settings; //Field offset: 0xC8
	private GizmoLineSlider3DSettings _sharedSettings; //Field offset: 0xD0
	private GizmoLineSlider3DLookAndFeel _lookAndFeel; //Field offset: 0xD8
	private GizmoLineSlider3DLookAndFeel _sharedLookAndFeel; //Field offset: 0xE0

	public int Cap3DHandleId
	{
		 get { } //Length: 32
	}

	public GizmoOverrideColor Cap3DOverrideColor
	{
		 get { } //Length: 33
	}

	public Vector3 Direction
	{
		 get { } //Length: 62
	}

	public GizmoDragChannel DragChannel
	{
		 get { } //Length: 4
	}

	public Vector3 DragRotationAxis
	{
		 get { } //Length: 62
	}

	public bool Is3DCapHoverable
	{
		 get { } //Length: 30
	}

	public bool Is3DCapVisible
	{
		 get { } //Length: 30
	}

	public bool IsDragged
	{
		 get { } //Length: 147
	}

	public bool IsMoving
	{
		 get { } //Length: 42
	}

	public bool IsRotating
	{
		 get { } //Length: 42
	}

	public bool IsScaling
	{
		 get { } //Length: 45
	}

	public GizmoLineSlider3DLookAndFeel LookAndFeel
	{
		 get { } //Length: 26
	}

	public GizmoOverrideColor OverrideColor
	{
		 get { } //Length: 8
	}

	public Vector3 RelativeDragOffset
	{
		 get { } //Length: 41
	}

	public float RelativeDragRotation
	{
		 get { } //Length: 31
	}

	public float RelativeDragScale
	{
		 get { } //Length: 34
	}

	public int ScaleDragAxisIndex
	{
		 get { } //Length: 7
		 set { } //Length: 38
	}

	public GizmoLineSlider3DSettings Settings
	{
		 get { } //Length: 26
	}

	public GizmoLineSlider3DLookAndFeel SharedLookAndFeel
	{
		 get { } //Length: 8
		 set { } //Length: 103
	}

	public GizmoLineSlider3DSettings SharedSettings
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public Vector3 StartPosition
	{
		 get { } //Length: 44
		 set { } //Length: 56
	}

	public Vector3 TotalDragOffset
	{
		 get { } //Length: 41
	}

	public float TotalDragRotation
	{
		 get { } //Length: 31
	}

	public float TotalDragScale
	{
		 get { } //Length: 34
	}

	public GizmoLineSlider3D(Gizmo gizmo, int handleId, int capHandleId) { }

	public void AddTargetTransform(GizmoTransform transform) { }

	public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	public void ApplyZoomFactor(Camera camera) { }

	public int get_Cap3DHandleId() { }

	public GizmoOverrideColor get_Cap3DOverrideColor() { }

	public Vector3 get_Direction() { }

	public GizmoDragChannel get_DragChannel() { }

	public Vector3 get_DragRotationAxis() { }

	public bool get_Is3DCapHoverable() { }

	public bool get_Is3DCapVisible() { }

	public bool get_IsDragged() { }

	public bool get_IsMoving() { }

	public bool get_IsRotating() { }

	public bool get_IsScaling() { }

	public GizmoLineSlider3DLookAndFeel get_LookAndFeel() { }

	public GizmoOverrideColor get_OverrideColor() { }

	public Vector3 get_RelativeDragOffset() { }

	public float get_RelativeDragRotation() { }

	public float get_RelativeDragScale() { }

	public int get_ScaleDragAxisIndex() { }

	public GizmoLineSlider3DSettings get_Settings() { }

	public GizmoLineSlider3DLookAndFeel get_SharedLookAndFeel() { }

	public GizmoLineSlider3DSettings get_SharedSettings() { }

	public Vector3 get_StartPosition() { }

	public Vector3 get_TotalDragOffset() { }

	public float get_TotalDragRotation() { }

	public float get_TotalDragScale() { }

	public float GetRealBoxDepth(float zoomFactor) { }

	public float GetRealBoxHeight(float zoomFactor) { }

	public float GetRealCylinderRadius(float zoomFactor) { }

	public Vector3 GetRealDirection() { }

	public Vector3 GetRealEndPosition(float zoomFactor) { }

	public Vector3 GetRealEndPositionWith3DCap(float zoomFactor) { }

	public float GetRealLength(float zoomFactor) { }

	public float GetRealLengthWith3DCap(float zoomFactor) { }

	public float GetRealSizeAlongDirection(Camera camera, Vector3 direction) { }

	public float GetZoomFactor(Camera camera) { }

	public bool IsScalerHandleRegistered(int handleId, int scaleDragAxisIndex) { }

	public bool IsScalerHandleRegistered(int handleId) { }

	public void MapDirection(int axisIndex, AxisSign axisSign) { }

	public void MapDragRotationAxis(GizmoTransform mapTransform, int axisIndex, AxisSign axisSign) { }

	private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId) { }

	private void OnGizmoHandleHoverEnter(Gizmo gizmo, int handleId) { }

	private void OnGizmoHandleHoverExit(Gizmo gizmo, int handleId) { }

	private void OnGizmoPostDisabled(Gizmo gizmo) { }

	private void OnGizmoPostEnabled(Gizmo gizmo) { }

	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	protected virtual void OnHoverableStateChanged() { }

	private void OnTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	protected virtual void OnVisibilityStateChanged() { }

	public void Refresh() { }

	public void RegisterScalerHandle(int handleId, IEnumerable<Int32> scaleDragAxisIndices) { }

	public void RemoveTargetTransform(GizmoTransform transform) { }

	public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	public virtual void Render(Camera camera) { }

	public void set_ScaleDragAxisIndex(int value) { }

	public void set_SharedLookAndFeel(GizmoLineSlider3DLookAndFeel value) { }

	public void set_SharedSettings(GizmoLineSlider3DSettings value) { }

	public void set_StartPosition(Vector3 value) { }

	public void Set3DCapHoverable(bool isHoverable) { }

	public void Set3DCapVisible(bool isVisible) { }

	public void SetDirection(Vector3 directionAxis) { }

	public void SetDragChannel(GizmoDragChannel dragChannel) { }

	public void SetDragRotationAxis(Vector3 rotationAxis) { }

	public virtual void SetSnapEnabled(bool isEnabled) { }

	private void SetupSharedLookAndFeel() { }

	public void SetZoomFactorTransform(GizmoTransform transform) { }

	public void UnmapDragRotationAxis() { }

	public void UnregisterScalerHandle(int handleId) { }

}

