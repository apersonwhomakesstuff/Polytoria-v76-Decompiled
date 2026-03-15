namespace RLD;

public class GizmoPolygon2DBorderControllerData
{
	public Gizmo Gizmo; //Field offset: 0x10
	public GizmoPlaneSlider2D PlaneSlider; //Field offset: 0x18
	public GizmoPolygon2DBorder Border; //Field offset: 0x20
	public GizmoHandle TargetHandle; //Field offset: 0x28
	public PolygonShape2D TargetPolygon; //Field offset: 0x30
	public PolygonShape2D BorderPolygon; //Field offset: 0x38
	public PolygonShape2D ThickBorderPolygon; //Field offset: 0x40
	public int BorderPolygonIndex; //Field offset: 0x48
	public int ThickBorderPolygonIndex; //Field offset: 0x4C

	public GizmoPolygon2DBorderControllerData() { }

}

