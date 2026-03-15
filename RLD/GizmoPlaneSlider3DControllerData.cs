namespace RLD;

public class GizmoPlaneSlider3DControllerData
{
	public Gizmo Gizmo; //Field offset: 0x10
	public GizmoPlaneSlider3D Slider; //Field offset: 0x18
	public GizmoHandle SliderHandle; //Field offset: 0x20
	public GizmoQuad3DBorder QuadBorder; //Field offset: 0x28
	public QuadShape3D Quad; //Field offset: 0x30
	public GizmoRATriangle3DBorder RATriangleBorder; //Field offset: 0x38
	public RightAngTriangle3D RATriangle; //Field offset: 0x40
	public GizmoCircle3DBorder CircleBorder; //Field offset: 0x48
	public CircleShape3D Circle; //Field offset: 0x50
	public int QuadIndex; //Field offset: 0x58
	public int RATriangleIndex; //Field offset: 0x5C
	public int CircleIndex; //Field offset: 0x60

	public GizmoPlaneSlider3DControllerData() { }

}

