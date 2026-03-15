namespace RLD;

public class GizmoPolygon2DBorder
{
	private GizmoPlaneSlider2D _planeSlider; //Field offset: 0x10
	private GizmoHandle _targetHandle; //Field offset: 0x18
	private PolygonShape2D _targetPolygon; //Field offset: 0x20
	private bool _isVisible; //Field offset: 0x28
	private bool _isHoverable; //Field offset: 0x29
	private int _borderPolygonIndex; //Field offset: 0x2C
	private int _thickBorderPolygonIndex; //Field offset: 0x30
	private PolygonShape2D _borderPolygon; //Field offset: 0x38
	private PolygonShape2D _thickBorderPolygon; //Field offset: 0x40
	private GizmoPolygon2DBorderControllerData _controllerData; //Field offset: 0x48
	private IGizmoPolygon2DBorderController[] _controllers; //Field offset: 0x50

	public bool IsHoverable
	{
		 get { } //Length: 5
	}

	public bool IsVisible
	{
		 get { } //Length: 5
	}

	public GizmoPolygon2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, PolygonShape2D targetPolygon) { }

	public bool get_IsHoverable() { }

	public bool get_IsVisible() { }

	private void OnGizmoPreUpdateBegin(Gizmo gizmo) { }

	public void OnPolygonShapeChanged() { }

	public void Render(Camera camera) { }

	public void SetHoverable(bool isHoverable) { }

	public void SetVisible(bool isVisible) { }

}

