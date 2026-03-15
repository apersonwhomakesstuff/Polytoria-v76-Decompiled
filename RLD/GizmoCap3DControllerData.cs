namespace RLD;

public class GizmoCap3DControllerData
{
	public Gizmo Gizmo; //Field offset: 0x10
	public GizmoCap3D Cap; //Field offset: 0x18
	public GizmoHandle CapHandle; //Field offset: 0x20
	public ConeShape3D Cone; //Field offset: 0x28
	public PyramidShape3D Pyramid; //Field offset: 0x30
	public BoxShape3D Box; //Field offset: 0x38
	public SphereShape3D Sphere; //Field offset: 0x40
	public TriangPrismShape3D TrPrism; //Field offset: 0x48
	public int ConeIndex; //Field offset: 0x50
	public int PyramidIndex; //Field offset: 0x54
	public int BoxIndex; //Field offset: 0x58
	public int SphereIndex; //Field offset: 0x5C
	public int TrPrismIndex; //Field offset: 0x60

	public GizmoCap3DControllerData() { }

}

