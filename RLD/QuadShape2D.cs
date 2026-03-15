namespace RLD;

public class QuadShape2D : Shape2D
{
	private Vector2 _center; //Field offset: 0x10
	private Vector2 _size; //Field offset: 0x18
	private float _rotationDegrees; //Field offset: 0x20
	private QuadEpsilon _epsilon; //Field offset: 0x24
	private Shape2DPtContainMode _ptContainMode; //Field offset: 0x34

	public Vector2 Center
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public QuadEpsilon Epsilon
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Vector2 Extents
	{
		 get { } //Length: 35
	}

	public float Height
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float HeightEps
	{
		 get { } //Length: 11
		 set { } //Length: 12
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

	public Shape2DPtContainMode PtContainMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Vector2 Right
	{
		 get { } //Length: 226
	}

	public Quaternion Rotation
	{
		 get { } //Length: 120
	}

	public float RotationDegrees
	{
		 get { } //Length: 6
		 set { } //Length: 36
	}

	public Vector2 Size
	{
		 get { } //Length: 19
		 set { } //Length: 59
	}

	public Vector2 SizeEps
	{
		 get { } //Length: 19
		 set { } //Length: 12
	}

	public Vector2 Up
	{
		 get { } //Length: 226
	}

	public float Width
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float WidthEps
	{
		 get { } //Length: 11
		 set { } //Length: 12
	}

	public float WireEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public QuadShape2D() { }

	public void AlignWidth(Vector2 axis) { }

	public virtual bool ContainsPoint(Vector2 point) { }

	public Vector2 get_Center() { }

	public QuadEpsilon get_Epsilon() { }

	public Vector2 get_Extents() { }

	public float get_Height() { }

	public float get_HeightEps() { }

	public static Vector2 get_ModelCenter() { }

	public static Vector2 get_ModelRight() { }

	public static Vector2 get_ModelUp() { }

	public Shape2DPtContainMode get_PtContainMode() { }

	public Vector2 get_Right() { }

	public Quaternion get_Rotation() { }

	public float get_RotationDegrees() { }

	public Vector2 get_Size() { }

	public Vector2 get_SizeEps() { }

	public Vector2 get_Up() { }

	public float get_Width() { }

	public float get_WidthEps() { }

	public float get_WireEps() { }

	public virtual Rect GetEncapsulatingRect() { }

	public Vector2 GetExtentPoint(Shape2DExtentPoint extentPt) { }

	public float GetSizeAlongDirection(Vector2 direction) { }

	public virtual void RenderArea(Camera camera) { }

	public virtual void RenderBorder(Camera camera) { }

	public void set_Center(Vector2 value) { }

	public void set_Epsilon(QuadEpsilon value) { }

	public void set_Height(float value) { }

	public void set_HeightEps(float value) { }

	public void set_PtContainMode(Shape2DPtContainMode value) { }

	public void set_RotationDegrees(float value) { }

	public void set_Size(Vector2 value) { }

	public void set_SizeEps(Vector2 value) { }

	public void set_Width(float value) { }

	public void set_WidthEps(float value) { }

	public void set_WireEps(float value) { }

}

