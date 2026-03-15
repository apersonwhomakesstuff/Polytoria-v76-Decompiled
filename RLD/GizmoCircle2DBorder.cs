namespace RLD;

public class GizmoCircle2DBorder
{
	private GizmoPlaneSlider2D _planeSlider; //Field offset: 0x10
	private GizmoHandle _targetHandle; //Field offset: 0x18
	private CircleShape2D _targetCircle; //Field offset: 0x20
	private bool _isVisible; //Field offset: 0x28
	private bool _isHoverable; //Field offset: 0x29
	private int _borderCircleIndex; //Field offset: 0x2C
	private CircleShape2D _borderCircle; //Field offset: 0x30
	private GizmoCircle2DBorderControllerData _controllerData; //Field offset: 0x38
	private IGizmoCircle2DBorderController[] _controllers; //Field offset: 0x40

	public bool IsHoverable
	{
		 get { } //Length: 5
	}

	public bool IsVisible
	{
		 get { } //Length: 5
	}

	public GizmoCircle2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, CircleShape2D targetCircle) { }

	public bool get_IsHoverable() { }

	public bool get_IsVisible() { }

	public void OnCircleShapeChanged() { }

	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	public void Render(Camera camera) { }

	public void SetHoverable(bool isHoverable) { }

	public void SetVisible(bool isVisible) { }

}

