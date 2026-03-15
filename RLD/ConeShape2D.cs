namespace RLD;

public class ConeShape2D : Shape2D
{
	private Vector2 _baseCenter; //Field offset: 0x10
	private float _rotationDegrees; //Field offset: 0x18
	private float _baseRadius; //Field offset: 0x1C
	private float _height; //Field offset: 0x20

	public Vector2 BaseCenter
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public Vector2 BaseLeft
	{
		 get { } //Length: 93
		 set { } //Length: 74
	}

	public float BaseRadius
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public Vector2 BaseRight
	{
		 get { } //Length: 93
		 set { } //Length: 82
	}

	public Vector2 CentralAxis
	{
		 get { } //Length: 226
	}

	public float Height
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public static Vector2 ModelBaseCenter
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

	public Vector2 Tip
	{
		 get { } //Length: 93
		 set { } //Length: 82
	}

	public Vector2 Up
	{
		 get { } //Length: 226
	}

	public ConeShape2D() { }

	public virtual bool ContainsPoint(Vector2 point) { }

	public Vector2 get_BaseCenter() { }

	public Vector2 get_BaseLeft() { }

	public float get_BaseRadius() { }

	public Vector2 get_BaseRight() { }

	public Vector2 get_CentralAxis() { }

	public float get_Height() { }

	public static Vector2 get_ModelBaseCenter() { }

	public static Vector2 get_ModelRight() { }

	public static Vector2 get_ModelUp() { }

	public Vector2 get_Right() { }

	public Quaternion get_Rotation() { }

	public float get_RotationDegrees() { }

	public Vector2 get_Tip() { }

	public Vector2 get_Up() { }

	public virtual Rect GetEncapsulatingRect() { }

	public virtual void RenderArea(Camera camera) { }

	public virtual void RenderBorder(Camera camera) { }

	public void set_BaseCenter(Vector2 value) { }

	public void set_BaseLeft(Vector2 value) { }

	public void set_BaseRadius(float value) { }

	public void set_BaseRight(Vector2 value) { }

	public void set_Height(float value) { }

	public void set_RotationDegrees(float value) { }

	public void set_Tip(Vector2 value) { }

}

