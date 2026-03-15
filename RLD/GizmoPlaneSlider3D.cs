namespace RLD;

public class GizmoPlaneSlider3D : GizmoSlider
{
	private int _quadIndex; //Field offset: 0x28
	private int _raTriangleIndex; //Field offset: 0x2C
	private int _circleIndex; //Field offset: 0x30
	private QuadShape3D _quad; //Field offset: 0x38
	private RightAngTriangle3D _raTriangle; //Field offset: 0x40
	private CircleShape3D _circle; //Field offset: 0x48
	private GizmoQuad3DBorder _quadBorder; //Field offset: 0x50
	private GizmoRATriangle3DBorder _raTriangleBorder; //Field offset: 0x58
	private GizmoCircle3DBorder _circleBorder; //Field offset: 0x60
	private bool _isBorderHoverable; //Field offset: 0x68
	private bool _isBorderVisible; //Field offset: 0x69
	private GizmoTransform _transform; //Field offset: 0x70
	private GizmoDragChannel _dragChannel; //Field offset: 0x78
	private IGizmoDragSession _selectedDragSession; //Field offset: 0x80
	private GizmoDblAxisOffsetDrag3D _dblAxisOffsetDrag; //Field offset: 0x88
	private GizmoSglAxisRotationDrag3D _rotationDrag; //Field offset: 0x90
	private GizmoRotationArc3D _rotationArc; //Field offset: 0x98
	private GizmoDblAxisScaleDrag3D _scaleDrag; //Field offset: 0xA0
	private int _scaleDragAxisIndexRight; //Field offset: 0xA8
	private int _scaleDragAxisIndexUp; //Field offset: 0xAC
	private GizmoPlaneSlider3DControllerData _controllerData; //Field offset: 0xB0
	private IGizmoPlaneSlider3DController[] _controllers; //Field offset: 0xB8
	private GizmoPlaneSlider3DSettings _settings; //Field offset: 0xC0
	private GizmoPlaneSlider3DSettings _sharedSettings; //Field offset: 0xC8
	private GizmoPlaneSlider3DLookAndFeel _lookAndFeel; //Field offset: 0xD0
	private GizmoPlaneSlider3DLookAndFeel _sharedLookAndFeel; //Field offset: 0xD8

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

	public Quaternion LocalRotation
	{
		 get { } //Length: 33
		 set { } //Length: 44
	}

	public Vector3 Look
	{
		 get { } //Length: 74
	}

	public GizmoPlaneSlider3DLookAndFeel LookAndFeel
	{
		 get { } //Length: 26
	}

	public Vector3 Normal
	{
		 get { } //Length: 74
	}

	public Plane Plane
	{
		 get { } //Length: 273
	}

	public Vector3 Position
	{
		 get { } //Length: 41
		 set { } //Length: 53
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

	public Vector3 Right
	{
		 get { } //Length: 71
	}

	public Quaternion Rotation
	{
		 get { } //Length: 33
		 set { } //Length: 44
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

	public GizmoPlaneSlider3DSettings Settings
	{
		 get { } //Length: 26
	}

	public GizmoPlaneSlider3DLookAndFeel SharedLookAndFeel
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public GizmoPlaneSlider3DSettings SharedSettings
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

	public Vector3 Up
	{
		 get { } //Length: 74
	}

	public GizmoPlaneSlider3D(Gizmo gizmo, int handleId) { }

	public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	public void AddTargetTransform(GizmoTransform transform) { }

	public void AlignToQuadrant(GizmoTransform transform, PlaneId planeId, PlaneQuadrantId quadrantId, bool alignXToFirstAxis) { }

	public void ApplyZoomFactor(Camera camera) { }

	public GizmoDragChannel get_DragChannel() { }

	public bool get_IsBorderHoverable() { }

	public bool get_IsBorderVisible() { }

	public bool get_IsDragged() { }

	public bool get_IsMoving() { }

	public bool get_IsRotating() { }

	public bool get_IsScaling() { }

	public Quaternion get_LocalRotation() { }

	public Vector3 get_Look() { }

	public GizmoPlaneSlider3DLookAndFeel get_LookAndFeel() { }

	public Vector3 get_Normal() { }

	public Plane get_Plane() { }

	public Vector3 get_Position() { }

	public Vector3 get_RelativeDragOffset() { }

	public float get_RelativeDragRotation() { }

	public float get_RelativeDragScaleRight() { }

	public float get_RelativeDragScaleUp() { }

	public Vector3 get_Right() { }

	public Quaternion get_Rotation() { }

	public int get_ScaleDragAxisIndexRight() { }

	public int get_ScaleDragAxisIndexUp() { }

	public GizmoPlaneSlider3DSettings get_Settings() { }

	public GizmoPlaneSlider3DLookAndFeel get_SharedLookAndFeel() { }

	public GizmoPlaneSlider3DSettings get_SharedSettings() { }

	public Vector3 get_TotalDragOffset() { }

	public float get_TotalDragRotation() { }

	public float get_TotalDragScaleRight() { }

	public float get_TotalDragScaleUp() { }

	public Vector3 get_Up() { }

	public Vector3 GetQuadCornerPosition(QuadCorner corner) { }

	public float GetRealCircleRadius(float zoomFactor) { }

	public float GetRealQuadHeight(float zoomFactor) { }

	public Vector2 GetRealQuadSize(float zoomFactor) { }

	public float GetRealQuadWidth(float zoomFactor) { }

	public Vector2 GetRealRATriSize(float zoomFactor) { }

	public float GetRealRATriXLength(float zoomFactor) { }

	public float GetRealRATriYLength(float zoomFactor) { }

	public float GetZoomFactor(Camera camera) { }

	public void MakeSliderPlane(GizmoTransform sliderPlaneTransform, PlaneId planeId, GizmoLineSlider3D firstAxisSlider, GizmoLineSlider3D secondAxisSlider, Camera camera) { }

	private void OnCanHoverHandle(int handleId, Gizmo gizmo, GizmoHandleHoverData hoverData, YesNoAnswer answer) { }

	private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId) { }

	private void OnGizmoPostEnabled(Gizmo gizmo) { }

	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	protected virtual void OnHoverableStateChanged() { }

	private void OnTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	protected virtual void OnVisibilityStateChanged() { }

	public void Refresh() { }

	public void RemoveTargetTransform(GizmoTransform transform) { }

	public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) { }

	public virtual void Render(Camera camera) { }

	public void set_LocalRotation(Quaternion value) { }

	public void set_Position(Vector3 value) { }

	public void set_Rotation(Quaternion value) { }

	public void set_ScaleDragAxisIndexRight(int value) { }

	public void set_ScaleDragAxisIndexUp(int value) { }

	public void set_SharedLookAndFeel(GizmoPlaneSlider3DLookAndFeel value) { }

	public void set_SharedSettings(GizmoPlaneSlider3DSettings value) { }

	public void SetBorderHoverable(bool isHoverable) { }

	public void SetBorderVisible(bool isVisible) { }

	public void SetDragChannel(GizmoDragChannel dragChannel) { }

	public void SetQuadCornerPosition(QuadCorner corner, Vector3 cornerPosition) { }

	public virtual void SetSnapEnabled(bool isEnabled) { }

	public void SetZoomFactorTransform(GizmoTransform transform) { }

}

