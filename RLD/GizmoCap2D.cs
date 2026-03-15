namespace RLD;

public class GizmoCap2D : GizmoCap
{
	private int _quadIndex; //Field offset: 0x28
	private QuadShape2D _quad; //Field offset: 0x30
	private int _circleIndex; //Field offset: 0x38
	private CircleShape2D _circle; //Field offset: 0x40
	private int _arrowIndex; //Field offset: 0x48
	private ConeShape2D _arrow; //Field offset: 0x50
	private GizmoTransform _transform; //Field offset: 0x58
	private GizmoOverrideColor _overrideFillColor; //Field offset: 0x60
	private GizmoOverrideColor _overrideBorderColor; //Field offset: 0x68
	private GizmoCap2DControllerData _controllerData; //Field offset: 0x70
	private IGizmoCap2DController[] _controllers; //Field offset: 0x78
	private GizmoCap2DLookAndFeel _lookAndFeel; //Field offset: 0x80
	private GizmoCap2DLookAndFeel _sharedLookAndFeel; //Field offset: 0x88

	public IGizmoDragSession DragSession
	{
		 get { } //Length: 27
		 set { } //Length: 35
	}

	public GizmoCap2DLookAndFeel LookAndFeel
	{
		 get { } //Length: 26
	}

	public GizmoOverrideColor OverrideBorderColor
	{
		 get { } //Length: 5
	}

	public GizmoOverrideColor OverrideFillColor
	{
		 get { } //Length: 5
	}

	public Vector2 Position
	{
		 get { } //Length: 41
		 set { } //Length: 30
	}

	public Quaternion Rotation
	{
		 get { } //Length: 33
	}

	public float RotationDegrees
	{
		 get { } //Length: 28
		 set { } //Length: 53
	}

	public GizmoCap2DLookAndFeel SharedLookAndFeel
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	public GizmoCap2D(Gizmo gizmo, int handleId) { }

	public void AlignTransformAxis(int axisIndex, AxisSign axisSign, Vector2 axis) { }

	public void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	public void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt) { }

	public IGizmoDragSession get_DragSession() { }

	public GizmoCap2DLookAndFeel get_LookAndFeel() { }

	public GizmoOverrideColor get_OverrideBorderColor() { }

	public GizmoOverrideColor get_OverrideFillColor() { }

	public Vector2 get_Position() { }

	public Quaternion get_Rotation() { }

	public float get_RotationDegrees() { }

	public GizmoCap2DLookAndFeel get_SharedLookAndFeel() { }

	public float GetRealArrowBaseRadius() { }

	public float GetRealArrowHeight() { }

	public float GetRealCircleRadius() { }

	public float GetRealQuadHeight() { }

	public float GetRealQuadWidth() { }

	private void OnGizmoPostEnabled(Gizmo gizmo) { }

	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	protected virtual void OnHoverableStateChanged() { }

	private void OnTransformChanged(GizmoTransform transform, ChangeData changeData) { }

	protected virtual void OnVisibilityStateChanged() { }

	public void Refresh() { }

	public void RegisterTransformAsDragTarget(IGizmoDragSession dragSession) { }

	public virtual void Render(Camera camera) { }

	public void set_DragSession(IGizmoDragSession value) { }

	public void set_Position(Vector2 value) { }

	public void set_RotationDegrees(float value) { }

	public void set_SharedLookAndFeel(GizmoCap2DLookAndFeel value) { }

	public void UnregisterTransformAsDragTarget(IGizmoDragSession dragSession) { }

}

