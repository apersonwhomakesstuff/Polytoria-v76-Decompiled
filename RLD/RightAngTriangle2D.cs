namespace RLD;

public class RightAngTriangle2D : Shape2D
{
	private Vector2 _rightAngleCorner; //Field offset: 0x10
	private float _XLength; //Field offset: 0x18
	private float _YLength; //Field offset: 0x1C
	private float _rotationDegrees; //Field offset: 0x20
	private TriangleEpsilon _epsilon; //Field offset: 0x24

	public float AreaEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public TriangleEpsilon Epsilon
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public static Vector2 ModelRight
	{
		 get { } //Length: 69
	}

	public static Vector2 ModelRightAngleCorner
	{
		 get { } //Length: 274
	}

	public static Vector2 ModelUp
	{
		 get { } //Length: 69
	}

	public Vector2 Right
	{
		 get { } //Length: 226
	}

	public Vector2 RightAngleCorner
	{
		 get { } //Length: 19
		 set { } //Length: 5
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

	public float XLength
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float YLength
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public RightAngTriangle2D() { }

	public virtual bool ContainsPoint(Vector2 point) { }

	public float get_AreaEps() { }

	public TriangleEpsilon get_Epsilon() { }

	public static Vector2 get_ModelRight() { }

	public static Vector2 get_ModelRightAngleCorner() { }

	public static Vector2 get_ModelUp() { }

	public Vector2 get_Right() { }

	public Vector2 get_RightAngleCorner() { }

	public float get_RotationDegrees() { }

	public Vector2 get_Up() { }

	public float get_XLength() { }

	public float get_YLength() { }

	public virtual Rect GetEncapsulatingRect() { }

	public List<Vector2> GetPoints() { }

	public virtual void RenderArea(Camera camera) { }

	public virtual void RenderBorder(Camera camera) { }

	public void set_AreaEps(float value) { }

	public void set_Epsilon(TriangleEpsilon value) { }

	public void set_RightAngleCorner(Vector2 value) { }

	public void set_RotationDegrees(float value) { }

	public void set_XLength(float value) { }

	public void set_YLength(float value) { }

}

