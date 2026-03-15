namespace RLD;

public class GizmoCap2DControllerData
{
	public Gizmo Gizmo; //Field offset: 0x10
	public GizmoCap2D Cap; //Field offset: 0x18
	public GizmoHandle CapHandle; //Field offset: 0x20
	public QuadShape2D Quad; //Field offset: 0x28
	public CircleShape2D Circle; //Field offset: 0x30
	public ConeShape2D Arrow; //Field offset: 0x38
	public int QuadIndex; //Field offset: 0x40
	public int CircleIndex; //Field offset: 0x44
	public int ArrowIndex; //Field offset: 0x48

	public GizmoCap2DControllerData() { }

}

