namespace RLD;

public class GizmoQuad3DBorderControllerData
{
	public Gizmo Gizmo; //Field offset: 0x10
	public GizmoPlaneSlider3D PlaneSlider; //Field offset: 0x18
	public GizmoQuad3DBorder Border; //Field offset: 0x20
	public GizmoHandle TargetHandle; //Field offset: 0x28
	public QuadShape3D TargetQuad; //Field offset: 0x30
	public QuadShape3D BorderQuad; //Field offset: 0x38
	public BoxShape3D TopBox; //Field offset: 0x40
	public BoxShape3D RightBox; //Field offset: 0x48
	public BoxShape3D BottomBox; //Field offset: 0x50
	public BoxShape3D LeftBox; //Field offset: 0x58
	public BoxShape3D TopLeftBox; //Field offset: 0x60
	public BoxShape3D TopRightBox; //Field offset: 0x68
	public BoxShape3D BottomRightBox; //Field offset: 0x70
	public BoxShape3D BottomLeftBox; //Field offset: 0x78
	public int BorderQuadIndex; //Field offset: 0x80
	public int TopBoxIndex; //Field offset: 0x84
	public int RightBoxIndex; //Field offset: 0x88
	public int BottomBoxIndex; //Field offset: 0x8C
	public int LeftBoxIndex; //Field offset: 0x90
	public int TopLeftBoxIndex; //Field offset: 0x94
	public int TopRightBoxIndex; //Field offset: 0x98
	public int BottomRightBoxIndex; //Field offset: 0x9C
	public int BottomLeftBoxIndex; //Field offset: 0xA0

	public GizmoQuad3DBorderControllerData() { }

}

