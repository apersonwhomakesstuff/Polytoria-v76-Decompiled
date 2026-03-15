namespace RLD;

public class GizmoCircle3DBorderControllerData
{
	public Gizmo Gizmo; //Field offset: 0x10
	public GizmoPlaneSlider3D PlaneSlider; //Field offset: 0x18
	public GizmoCircle3DBorder Border; //Field offset: 0x20
	public GizmoHandle TargetHandle; //Field offset: 0x28
	public CircleShape3D TargetCircle; //Field offset: 0x30
	public CircleShape3D BorderCircle; //Field offset: 0x38
	public TorusShape3D BorderTorus; //Field offset: 0x40
	public CylTorusShape3D BorderCylTorus; //Field offset: 0x48
	public int BorderCircleIndex; //Field offset: 0x50
	public int BorderTorusIndex; //Field offset: 0x54
	public int BorderCylTorusIndex; //Field offset: 0x58

	public GizmoCircle3DBorderControllerData() { }

}

