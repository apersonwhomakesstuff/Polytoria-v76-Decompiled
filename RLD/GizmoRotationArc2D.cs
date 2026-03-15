namespace RLD;

public class GizmoRotationArc2D
{
	internal enum ArcType : int
	{
		Standard = 0,
		PolyProjected = 1,
	}

	private ArcShape2D _arc; //Field offset: 0x10
	private ArcType _type; //Field offset: 0x18
	private PolygonShape2D _projectionPoly; //Field offset: 0x20
	private int _numProjectedPoints; //Field offset: 0x28

	public int NumProjectedPoints
	{
		 get { } //Length: 4
		 set { } //Length: 16
	}

	public PolygonShape2D ProjectionPoly
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public float RotationAngle
	{
		 get { } //Length: 28
		 set { } //Length: 30
	}

	public ArcType Type
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public GizmoRotationArc2D() { }

	public int get_NumProjectedPoints() { }

	public PolygonShape2D get_ProjectionPoly() { }

	public float get_RotationAngle() { }

	public ArcType get_Type() { }

	public void Render(GizmoRotationArc2DLookAndFeel lookAndFeel, Camera camera) { }

	public void set_NumProjectedPoints(int value) { }

	public void set_ProjectionPoly(PolygonShape2D value) { }

	public void set_RotationAngle(float value) { }

	public void set_Type(ArcType value) { }

	public void SetArcData(Vector2 arcOrigin, Vector2 arcStart, float radius) { }

}

