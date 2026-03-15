namespace RLD;

public class GizmoPlaneSlider2D : GizmoSlider
{
	private int _quadIndex; //Field offset: 0x28
	private int _circleIndex; //Field offset: 0x2C
	private int _polygonIndex; //Field offset: 0x30
	private QuadShape2D _quad; //Field offset: 0x38
	private CircleShape2D _circle; //Field offset: 0x40
	private PolygonShape2D _polygon; //Field offset: 0x48
	private GizmoQuad2DBorder _quadBorder; //Field offset: 0x50
	private GizmoCircle2DBorder _circleBorder; //Field offset: 0x58
	private GizmoPolygon2DBorder _polygonBorder; //Field offset: 0x60
	private bool _isBorderVisible; //Field offset: 0x68
	private bool _isBorderHoverable; //Field offset: 0x69
	private GizmoTransform _transform; //Field offset: 0x70
	private GizmoDragChannel _dragChannel; //Field offset: 0x78
	private IGizmoDragSession _selectedDragSession; //Field offset: 0x80
	private GizmoDblAxisOffsetDrag3D _offsetDrag; //Field offset: 0x88
	private Vector3 _offsetDragOrigin; //Field offset: 0x90
	private GizmoSglAxisRotationDrag3D _rotationDrag; //Field offset: 0xA0
	private GizmoRotationArc2D _rotationArc; //Field offset: 0xA8
	private GizmoDblAxisScaleDrag3D _scaleDrag; //Field offset: 0xB0
	private Vector3 _scaleDragOrigin; //Field offset: 0xB8
	private Vector3 _scaleAxisRight; //Field offset: 0xC4
	private Vector3 _scaleAxisUp; //Field offset: 0xD0
	private int _scaleDragAxisIndexRight; //Field offset: 0xDC
	private int _scaleDragAxisIndexUp; //Field offset: 0xE0
	private GizmoPlaneSlider2DControllerData _controllerData; //Field offset: 0xE8
	private IGizmoPlaneSlider2DController[] _controllers; //Field offset: 0xF0
	private GizmoPlaneSlider2DSettings _settings; //Field offset: 0xF8
	private GizmoPlaneSlider2DSettings _sharedSettings; //Field offset: 0x100
	private GizmoPlaneSlider2DLookAndFeel _lookAndFeel; //Field offset: 0x108
	private GizmoPlaneSlider2DLookAndFeel _sharedLookAndFeel; //Field offset: 0x110

	public GizmoDragChannel DragChannel
	{
		 get { } //Length: 4
	}

	public bool IsBorderHoverable
	{
		 get { } //Length: 5
	}

	public bool IsBorderVisible
	{
		 get { } //Length: 5
	}

	public bool IsDragged
	{
		 get { } //Length: 89
	}

	public bool IsMoving
	{
		 get { } //Length: 45
	}

	public bool IsRotating
	{
		 get { } //Length: 45
	}

	public bool IsScaling
	{
		 get { } //Length: 45
	}

	public GizmoPlaneSlider2DLookAndFeel LookAndFeel
	{
		 get { } //Length: 26
	}

	public Vector3 OffsetDragOrigin
	{
		 get { } //Length: 25
		 set { } //Length: 22
	}

	public Vector2 PolyCenter
	{
		 get { } //Length: 172
	}

	public Vector2 Position
	{
		 get { } //Length: 41
		 set { } //Length: 30
	}

	public Vector3 RelativeDragOffset
	{
		 get { } //Length: 44
	}

	public float RelativeDragRotation
	{
		 get { } //Length: 34
	}

	public float RelativeDragScaleRight
	{
		 get { } //Length: 34
	}

	public float RelativeDragScaleUp
	{
		 get { } //Length: 34
	}

	public Vector2 Right
	{
		 get { } //Length: 35
	}

	public Quaternion Rotation
	{
		 get { } //Length: 33
	}

	public float RotationDegrees
	{
		 get { } //Length: 28
		 set { } //Length: 30
	}

	public int ScaleDragAxisIndexRight
	{
		 get { } //Length: 7
		 set { } //Length: 38
	}

	public int ScaleDragAxisIndexUp
	{
		 get { } //Length: 7
		 set { } //Length: 38
	}

	public Vector3 ScaleDragOrigin
	{
		 get { } //Length: 25
		 set { } //Length: 22
	}

	public GizmoPlaneSlider2DSettings Settings
	{
		 get { } //Length: 26
	}

	public GizmoPlaneSlider2DLookAndFeel SharedLookAndFeel
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public GizmoPlaneSlider2DSettings SharedSettings
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public Vector3 TotalDragOffset
	{
		 get { } //Length: 44
	}

	public float TotalDragRotation
	{
		 get { } //Length: 34
	}

	public float TotalDragScaleRight
	{
		 get { } //Length: 34
	}

	public float TotalDragScaleUp
	{
		 get { } //Length: 34
	}

	public Vector2 Up
	{
		 get { } //Length: 38
	}

	public GizmoPlaneSlider2D(Gizmo gizmo, int handleId) { }

	public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	public void AddTargetTransform(GizmoTransform transform) { }

	public GizmoDragChannel get_DragChannel() { }

	public bool get_IsBorderHoverable() { }

	public bool get_IsBorderVisible() { }

	public bool get_IsDragged() { }

	public bool get_IsMoving() { }

	public bool get_IsRotating() { }

	public bool get_IsScaling() { }

	public GizmoPlaneSlider2DLookAndFeel get_LookAndFeel() { }

	public Vector3 get_OffsetDragOrigin() { }

	public Vector2 get_PolyCenter() { }

	public Vector2 get_Position() { }

	public Vector3 get_RelativeDragOffset() { }

	public float get_RelativeDragRotation() { }

	public float get_RelativeDragScaleRight() { }

	public float get_RelativeDragScaleUp() { }

	public Vector2 get_Right() { }

	public Quaternion get_Rotation() { }

	public float get_RotationDegrees() { }

	public int get_ScaleDragAxisIndexRight() { }

	public int get_ScaleDragAxisIndexUp() { }

	public Vector3 get_ScaleDragOrigin() { }

	public GizmoPlaneSlider2DSettings get_Settings() { }

	public GizmoPlaneSlider2DLookAndFeel get_SharedLookAndFeel() { }

	public GizmoPlaneSlider2DSettings get_SharedSettings() { }

	public Vector3 get_TotalDragOffset() { }

	public float get_TotalDragRotation() { }

	public float get_TotalDragScaleRight() { }

	public float get_TotalDragScaleUp() { }

	public Vector2 get_Up() { }

	public float GetRealCircleRadius() { }

	public Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt) { }

	public float GetRealQuadHeight() { }

	public Vector2 GetRealQuadSize() { }

	public float GetRealQuadWidth() { }

	public void MakePolySphereBorder(Vector3 sphereCenter, float sphereRadius, int numPoints, Camera camera) { }

	private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId) { }

	private void OnGizmoHandleDragUpdate(Gizmo gizmo, int handleId) { }

	private void OnGizmoPostEnabled(Gizmo gizmo) { }

	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	protected virtual void OnHoverableStateChanged() { }

	private void OnTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	protected virtual void OnVisibilityStateChanged() { }

	public void Refresh() { }

	public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	public void RemoveTargetTransform(GizmoTransform transform) { }

	public virtual void Render(Camera camera) { }

	public void set_OffsetDragOrigin(Vector3 value) { }

	public void set_Position(Vector2 value) { }

	public void set_RotationDegrees(float value) { }

	public void set_ScaleDragAxisIndexRight(int value) { }

	public void set_ScaleDragAxisIndexUp(int value) { }

	public void set_ScaleDragOrigin(Vector3 value) { }

	public void set_SharedLookAndFeel(GizmoPlaneSlider2DLookAndFeel value) { }

	public void set_SharedSettings(GizmoPlaneSlider2DSettings value) { }

	public void SetBorderHoverable(bool isHoverable) { }

	public void SetBorderVisible(bool isVisible) { }

	public void SetDragChannel(GizmoDragChannel dragChannel) { }

	public void SetPolyCwPoints(List<Vector2> cwPoints, bool isClosed) { }

	public virtual void SetSnapEnabled(bool isEnabled) { }

}

