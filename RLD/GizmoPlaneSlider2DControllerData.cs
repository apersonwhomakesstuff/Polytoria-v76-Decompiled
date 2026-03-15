namespace RLD;

public class GizmoPlaneSlider2DControllerData
{
	public Gizmo Gizmo; //Field offset: 0x10
	public GizmoPlaneSlider2D Slider; //Field offset: 0x18
	public GizmoHandle SliderHandle; //Field offset: 0x20
	public GizmoQuad2DBorder QuadBorder; //Field offset: 0x28
	public GizmoCircle2DBorder CircleBorder; //Field offset: 0x30
	public GizmoPolygon2DBorder PolygonBorder; //Field offset: 0x38
	public QuadShape2D Quad; //Field offset: 0x40
	public CircleShape2D Circle; //Field offset: 0x48
	public PolygonShape2D Polygon; //Field offset: 0x50
	public int QuadIndex; //Field offset: 0x58
	public int CircleIndex; //Field offset: 0x5C
	public int PolygonIndex; //Field offset: 0x60

	public GizmoPlaneSlider2DControllerData() { }

}

