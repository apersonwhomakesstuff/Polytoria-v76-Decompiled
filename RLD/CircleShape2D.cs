namespace RLD;

public class CircleShape2D : Shape2D
{
	private Vector2 _center; //Field offset: 0x10
	private float _radius; //Field offset: 0x18
	private float _rotationDegrees; //Field offset: 0x1C
	private int _numBorderPoints; //Field offset: 0x20
	private List<Vector2> _modelBorderPoints; //Field offset: 0x28
	private bool _areModelBorderPointsDirty; //Field offset: 0x30
	private CircleEpsilon _epsilon; //Field offset: 0x34
	private Shape2DPtContainMode _ptContainMode; //Field offset: 0x40

	public Vector2 Center
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public CircleEpsilon Epsilon
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public static Vector2 ModelCenter
	{
		 get { } //Length: 274
	}

	public static Vector2 ModelRight
	{
		 get { } //Length: 69
	}

	public static Vector2 ModelUp
	{
		 get { } //Length: 69
	}

	public int NumBorderPoints
	{
		 get { } //Length: 4
		 set { } //Length: 20
	}

	public Shape2DPtContainMode PtContainMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float Radius
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float RadiusEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public Vector2 Right
	{
		 get { } //Length: 226
	}

	public float RotationDegrees
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Vector2 Up
	{
		 get { } //Length: 226
	}

	public float WireEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public CircleShape2D() { }

	private void CalcModelBorderPoints() { }

	public virtual bool ContainsPoint(Vector2 point) { }

	public Vector2 get_Center() { }

	public CircleEpsilon get_Epsilon() { }

	public static Vector2 get_ModelCenter() { }

	public static Vector2 get_ModelRight() { }

	public static Vector2 get_ModelUp() { }

	public int get_NumBorderPoints() { }

	public Shape2DPtContainMode get_PtContainMode() { }

	public float get_Radius() { }

	public float get_RadiusEps() { }

	public Vector2 get_Right() { }

	public float get_RotationDegrees() { }

	public Vector2 get_Up() { }

	public float get_WireEps() { }

	public virtual Rect GetEncapsulatingRect() { }

	public Vector2 GetExtentPoint(Shape2DExtentPoint extentPt) { }

	public List<Vector2> GetExtentPoints() { }

	public virtual void RenderArea(Camera camera) { }

	public virtual void RenderBorder(Camera camera) { }

	public void set_Center(Vector2 value) { }

	public void set_Epsilon(CircleEpsilon value) { }

	public void set_NumBorderPoints(int value) { }

	public void set_PtContainMode(Shape2DPtContainMode value) { }

	public void set_Radius(float value) { }

	public void set_RadiusEps(float value) { }

	public void set_RotationDegrees(float value) { }

	public void set_WireEps(float value) { }

}

