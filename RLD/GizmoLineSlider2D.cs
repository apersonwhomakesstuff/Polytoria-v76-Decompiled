namespace RLD;

public class GizmoLineSlider2D : GizmoSlider
{
	private SegmentShape2D _segment; //Field offset: 0x28
	private QuadShape2D _quad; //Field offset: 0x30
	private int _segmentIndex; //Field offset: 0x38
	private int _quadIndex; //Field offset: 0x3C
	private GizmoDragChannel _dragChannel; //Field offset: 0x40
	private GizmoSglAxisOffsetDrag3D _offsetDrag; //Field offset: 0x48
	private Vector3 _offsetDragOrigin; //Field offset: 0x50
	private GizmoSglAxisRotationDrag3D _rotationDrag; //Field offset: 0x60
	private GizmoRotationArc2D _rotationArc; //Field offset: 0x68
	private GizmoSglAxisScaleDrag3D _scaleDrag; //Field offset: 0x70
	private Vector3 _scaleDragOrigin; //Field offset: 0x78
	private Vector3 _scaleAxis; //Field offset: 0x84
	private int _scaleDragAxisIndex; //Field offset: 0x90
	private IGizmoDragSession _selectedDragSession; //Field offset: 0x98
	private GizmoCap2D _cap2D; //Field offset: 0xA0
	private GizmoTransform _transform; //Field offset: 0xA8
	private GizmoTransformAxisMap2D _directionAxisMap; //Field offset: 0xB0
	private GizmoOverrideColor _overrideFillColor; //Field offset: 0xB8
	private GizmoOverrideColor _overrideBorderColor; //Field offset: 0xC0
	private GizmoLineSlider2DControllerData _controllerData; //Field offset: 0xC8
	private IGizmoLineSlider2DController[] _controllers; //Field offset: 0xD0
	private GizmoLineSlider2DSettings _settings; //Field offset: 0xD8
	private GizmoLineSlider2DSettings _sharedSettings; //Field offset: 0xE0
	private GizmoLineSlider2DLookAndFeel _lookAndFeel; //Field offset: 0xE8
	private GizmoLineSlider2DLookAndFeel _sharedLookAndFeel; //Field offset: 0xF0

	public int Cap2DHandleId
	{
		 get { } //Length: 32
	}

	public Vector2 Direction
	{
		 get { } //Length: 32
	}

	public bool Is2DCapHoverable
	{
		 get { } //Length: 30
	}

	public bool Is2DCapVisible
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
		 get { } //Length: 42
	}

	public GizmoLineSlider2DLookAndFeel LookAndFeel
	{
		 get { } //Length: 26
	}

	public Vector3 OffsetDragOrigin
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public GizmoOverrideColor OverrideBorderColor
	{
		 get { } //Length: 8
	}

	public GizmoOverrideColor OverrideFillColor
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
		 get { } //Length: 31
	}

	public Quaternion Rotation
	{
		 get { } //Length: 36
	}

	public float RotationDegrees
	{
		 get { } //Length: 31
	}

	public int ScaleDragAxisIndex
	{
		 get { } //Length: 7
		 set { } //Length: 38
	}

	public Vector3 ScaleDragOrigin
	{
		 get { } //Length: 22
		 set { } //Length: 19
	}

	public GizmoLineSlider2DSettings Settings
	{
		 get { } //Length: 26
	}

	public GizmoLineSlider2DLookAndFeel SharedLookAndFeel
	{
		 get { } //Length: 8
		 set { } //Length: 103
	}

	public GizmoLineSlider2DSettings SharedSettings
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public Vector2 StartPosition
	{
		 get { } //Length: 44
		 set { } //Length: 33
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
		 get { } //Length: 31
	}

	public GizmoLineSlider2D(Gizmo gizmo, int handleId, int capHandleId) { }

	public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	public void AddTargetTransform(GizmoTransform transform) { }

	public int get_Cap2DHandleId() { }

	public Vector2 get_Direction() { }

	public bool get_Is2DCapHoverable() { }

	public bool get_Is2DCapVisible() { }

	public bool get_IsDragged() { }

	public bool get_IsMoving() { }

	public bool get_IsRotating() { }

	public bool get_IsScaling() { }

	public GizmoLineSlider2DLookAndFeel get_LookAndFeel() { }

	public Vector3 get_OffsetDragOrigin() { }

	public GizmoOverrideColor get_OverrideBorderColor() { }

	public GizmoOverrideColor get_OverrideFillColor() { }

	public Vector3 get_RelativeDragOffset() { }

	public float get_RelativeDragRotation() { }

	public float get_RelativeDragScale() { }

	public Quaternion get_Rotation() { }

	public float get_RotationDegrees() { }

	public int get_ScaleDragAxisIndex() { }

	public Vector3 get_ScaleDragOrigin() { }

	public GizmoLineSlider2DSettings get_Settings() { }

	public GizmoLineSlider2DLookAndFeel get_SharedLookAndFeel() { }

	public GizmoLineSlider2DSettings get_SharedSettings() { }

	public Vector2 get_StartPosition() { }

	public Vector3 get_TotalDragOffset() { }

	public float get_TotalDragRotation() { }

	public float get_TotalDragScale() { }

	public float GetRealBoxThickness() { }

	public Vector2 GetRealDirection() { }

	public Vector2 GetRealEndPosition() { }

	public float GetRealLength() { }

	public void MapDirection(int axisIndex, AxisSign axisSign) { }

	private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId) { }

	private void OnGizmoHandleDragUpdate(Gizmo gizmo, int handleId) { }

	private void OnGizmoHandleHoverEnter(Gizmo gizmo, int handleId) { }

	private void OnGizmoHandleHoverExit(Gizmo gizmo, int handleId) { }

	private void OnGizmoPostEnabled(Gizmo gizmo) { }

	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	protected virtual void OnHoverableStateChanged() { }

	private void OnTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	protected virtual void OnVisibilityStateChanged() { }

	public void Refresh() { }

	public void RemoveTargetTransform(GizmoTransform transform) { }

	public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	public virtual void Render(Camera camera) { }

	public void set_OffsetDragOrigin(Vector3 value) { }

	public void set_ScaleDragAxisIndex(int value) { }

	public void set_ScaleDragOrigin(Vector3 value) { }

	public void set_SharedLookAndFeel(GizmoLineSlider2DLookAndFeel value) { }

	public void set_SharedSettings(GizmoLineSlider2DSettings value) { }

	public void set_StartPosition(Vector2 value) { }

	public void Set2DCapHoverable(bool isHoverable) { }

	public void Set2DCapVisible(bool isVisible) { }

	public void SetDirection(Vector2 directionAxis) { }

	public void SetDragChannel(GizmoDragChannel dragChannel) { }

	public virtual void SetSnapEnabled(bool isEnabled) { }

	private void SetupSharedLookAndFeel() { }

}

