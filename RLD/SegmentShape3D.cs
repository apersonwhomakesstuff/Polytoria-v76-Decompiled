namespace RLD;

public class SegmentShape3D : Shape3D
{
	private Vector3 _startPoint; //Field offset: 0x10
	private Vector3 _endPoint; //Field offset: 0x1C
	private Vector3 _direction; //Field offset: 0x28
	private float _length; //Field offset: 0x34
	private SegmentEpsilon _epsilon; //Field offset: 0x38

	public Vector3 Direction
	{
		 get { } //Length: 19
		 set { } //Length: 225
	}

	public Vector3 EndPoint
	{
		 get { } //Length: 19
		 set { } //Length: 184
	}

	public SegmentEpsilon Epsilon
	{
		 get { } //Length: 19
		 set { } //Length: 5
	}

	public float Length
	{
		 get { } //Length: 6
		 set { } //Length: 92
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

	public Vector3 StartPoint
	{
		 get { } //Length: 19
		 set { } //Length: 96
	}

	public SegmentShape3D() { }

	public Vector3 get_Direction() { }

	public Vector3 get_EndPoint() { }

	public SegmentEpsilon get_Epsilon() { }

	public float get_Length() { }

	public float get_PtOnSegmentEps() { }

	public float get_RaycastEps() { }

	public Vector3 get_StartPoint() { }

	public virtual AABB GetAABB() { }

	public virtual bool Raycast(Ray ray, out float t) { }

	public virtual void RenderSolid() { }

	public virtual void RenderWire() { }

	public void set_Direction(Vector3 value) { }

	public void set_EndPoint(Vector3 value) { }

	public void set_Epsilon(SegmentEpsilon value) { }

	public void set_Length(float value) { }

	public void set_PtOnSegmentEps(float value) { }

	public void set_RaycastEps(float value) { }

	public void set_StartPoint(Vector3 value) { }

	public void SetEndPtFromStart(Vector3 dirDromStart, float offset) { }

}

