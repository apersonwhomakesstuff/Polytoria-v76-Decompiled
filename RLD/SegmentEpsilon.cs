namespace RLD;

public struct SegmentEpsilon
{
	private float _raycastEps; //Field offset: 0x0
	private float _ptOnSegmentEps; //Field offset: 0x4

	public float PtOnSegmentEps
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float RaycastEps
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public float get_PtOnSegmentEps() { }

	public float get_RaycastEps() { }

	public void set_PtOnSegmentEps(float value) { }

	public void set_RaycastEps(float value) { }

}

