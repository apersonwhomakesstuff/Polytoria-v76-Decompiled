namespace RLD;

public class GizmoLineSlider3DControllerData
{
	public Gizmo Gizmo; //Field offset: 0x10
	public GizmoLineSlider3D Slider; //Field offset: 0x18
	public GizmoHandle SliderHandle; //Field offset: 0x20
	public SegmentShape3D Segment; //Field offset: 0x28
	public BoxShape3D Box; //Field offset: 0x30
	public CylinderShape3D Cylinder; //Field offset: 0x38
	public int SegmentIndex; //Field offset: 0x40
	public int BoxIndex; //Field offset: 0x44
	public int CylinderIndex; //Field offset: 0x48

	public GizmoLineSlider3DControllerData() { }

}

