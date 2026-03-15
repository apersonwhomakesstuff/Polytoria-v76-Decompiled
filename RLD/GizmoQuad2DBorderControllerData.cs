namespace RLD;

public class GizmoQuad2DBorderControllerData
{
	public Gizmo Gizmo; //Field offset: 0x10
	public GizmoPlaneSlider2D PlaneSlider; //Field offset: 0x18
	public GizmoQuad2DBorder Border; //Field offset: 0x20
	public GizmoHandle TargetHandle; //Field offset: 0x28
	public QuadShape2D TargetQuad; //Field offset: 0x30
	public QuadShape2D BorderQuad; //Field offset: 0x38
	public int BorderQuadIndex; //Field offset: 0x40

	public GizmoQuad2DBorderControllerData() { }

}

