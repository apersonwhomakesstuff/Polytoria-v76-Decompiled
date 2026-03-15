namespace RLD;

public class GizmoQuad2DBorder
{
	private GizmoPlaneSlider2D _planeSlider; //Field offset: 0x10
	private GizmoHandle _targetHandle; //Field offset: 0x18
	private QuadShape2D _targetQuad; //Field offset: 0x20
	private bool _isVisible; //Field offset: 0x28
	private bool _isHoverable; //Field offset: 0x29
	private int _borderQuadIndex; //Field offset: 0x2C
	private QuadShape2D _borderQuad; //Field offset: 0x30
	private GizmoQuad2DBorderControllerData _controllerData; //Field offset: 0x38
	private IGizmoQuad2DBorderController[] _controllers; //Field offset: 0x40

	public bool IsHoverable
	{
		 get { } //Length: 5
	}

	public bool IsVisible
	{
		 get { } //Length: 5
	}

	public GizmoQuad2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, QuadShape2D targetQuad) { }

	public bool get_IsHoverable() { }

	public bool get_IsVisible() { }

	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	public void OnQuadShapeChanged() { }

	public void Render(Camera camera) { }

	public void SetHoverable(bool isHoverable) { }

	public void SetVisible(bool isVisible) { }

}

