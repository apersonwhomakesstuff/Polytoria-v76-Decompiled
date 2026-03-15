namespace RLD;

public class SegmentShape2D : Shape2D
{
	private Vector2 _startPoint; //Field offset: 0x10
	private Vector2 _endPoint; //Field offset: 0x18
	private Vector2 _direction; //Field offset: 0x20
	private float _length; //Field offset: 0x28
	private SegmentEpsilon _epsilon; //Field offset: 0x2C

	public Vector2 Direction
	{
		 get { } //Length: 19
		 set { } //Length: 95
	}

	public Vector2 EndPoint
	{
		 get { } //Length: 19
		 set { } //Length: 162
	}

	public SegmentEpsilon Epsilon
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public float Length
	{
		 get { } //Length: 6
		 set { } //Length: 46
	}

	public float PtOnSegmentEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public float RaycastEps
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public Vector2 StartPoint
	{
		 get { } //Length: 19
		 set { } //Length: 64
	}

	public SegmentShape2D() { }

	public virtual bool ContainsPoint(Vector2 point) { }

	public Vector2 get_Direction() { }

	public Vector2 get_EndPoint() { }

	public SegmentEpsilon get_Epsilon() { }

	public float get_Length() { }

	public float get_PtOnSegmentEps() { }

	public float get_RaycastEps() { }

	public Vector2 get_StartPoint() { }

	public virtual Rect GetEncapsulatingRect() { }

	public virtual void RenderArea(Camera camera) { }

	public virtual void RenderBorder(Camera camera) { }

	public void set_Direction(Vector2 value) { }

	public void set_EndPoint(Vector2 value) { }

	public void set_Epsilon(SegmentEpsilon value) { }

	public void set_Length(float value) { }

	public void set_PtOnSegmentEps(float value) { }

	public void set_RaycastEps(float value) { }

	public void set_StartPoint(Vector2 value) { }

	public void SetEndPtFromStart(Vector2 dirDromStart, float offset) { }

}

