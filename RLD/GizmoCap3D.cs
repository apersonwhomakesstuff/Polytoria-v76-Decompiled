namespace RLD;

public class GizmoCap3D : GizmoCap
{
	private int _coneIndex; //Field offset: 0x28
	private ConeShape3D _cone; //Field offset: 0x30
	private int _pyramidIndex; //Field offset: 0x38
	private PyramidShape3D _pyramid; //Field offset: 0x40
	private int _boxIndex; //Field offset: 0x48
	private BoxShape3D _box; //Field offset: 0x50
	private int _sphereIndex; //Field offset: 0x58
	private SphereShape3D _sphere; //Field offset: 0x60
	private int _trPrismIndex; //Field offset: 0x68
	private TriangPrismShape3D _trPrism; //Field offset: 0x70
	private GizmoCap3DControllerData _controllerData; //Field offset: 0x78
	private IGizmoCap3DController[] _controllers; //Field offset: 0x80
	private GizmoTransform _transform; //Field offset: 0x88
	private GizmoOverrideColor _overrideColor; //Field offset: 0x90
	private GizmoCap3DLookAndFeel _lookAndFeel; //Field offset: 0x98
	private GizmoCap3DLookAndFeel _sharedLookAndFeel; //Field offset: 0xA0

	public IGizmoDragSession DragSession
	{
		 get { } //Length: 27
		 set { } //Length: 35
	}

	public GizmoCap3DLookAndFeel LookAndFeel
	{
		 get { } //Length: 26
	}

	public GizmoOverrideColor OverrideColor
	{
		 get { } //Length: 8
	}

	public Vector3 Position
	{
		 get { } //Length: 44
		 set { } //Length: 56
	}

	public Quaternion Rotation
	{
		 get { } //Length: 36
		 set { } //Length: 47
	}

	public GizmoCap3DLookAndFeel SharedLookAndFeel
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public GizmoCap3D(Gizmo gizmo, int handleId) { }

	public void AlignTransformAxis(int axisIndex, AxisSign axisSign, Vector3 axis) { }

	public void ApplyZoomFactor(Camera camera) { }

	public void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt) { }

	public void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt) { }

	public IGizmoDragSession get_DragSession() { }

	public GizmoCap3DLookAndFeel get_LookAndFeel() { }

	public GizmoOverrideColor get_OverrideColor() { }

	public Vector3 get_Position() { }

	public Quaternion get_Rotation() { }

	public GizmoCap3DLookAndFeel get_SharedLookAndFeel() { }

	public float GetRealBoxDepth(float zoomFactor) { }

	public float GetRealBoxHeight(float zoomFactor) { }

	public Vector3 GetRealBoxSize(float zoomFactor) { }

	public float GetRealBoxWidth(float zoomFactor) { }

	public float GetRealConeHeight(float zoomFactor) { }

	public float GetRealConeRadius(float zoomFactor) { }

	public float GetRealPyramidDepth(float zoomFactor) { }

	public float GetRealPyramidHeight(float zoomFactor) { }

	public float GetRealPyramidWidth(float zoomFactor) { }

	public float GetRealSphereRadius(float zoomFactor) { }

	public float GetRealTriPrismDepth(float zoomFactor) { }

	public float GetRealTriPrismHeight(float zoomFactor) { }

	public float GetRealTriPrismWidth(float zoomFactor) { }

	public float GetSliderAlignedRealLength(float zoomFactor) { }

	public float GetZoomFactor(Camera camera) { }

	private void OnGizmoPostDisabled(Gizmo gizmo) { }

	private void OnGizmoPostEnabled(Gizmo gizmo) { }

	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	protected virtual void OnHoverableStateChanged() { }

	private void OnTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	protected virtual void OnVisibilityStateChanged() { }

	public void Refresh() { }

	public void RegisterTransformAsDragTarget(IGizmoDragSession dragSession) { }

	public virtual void Render(Camera camera) { }

	public void set_DragSession(IGizmoDragSession value) { }

	public void set_Position(Vector3 value) { }

	public void set_Rotation(Quaternion value) { }

	public void set_SharedLookAndFeel(GizmoCap3DLookAndFeel value) { }

	public void SetZoomFactorTransform(GizmoTransform transform) { }

	public void UnregisterTransformAsDragTarget(IGizmoDragSession dragSession) { }

}

