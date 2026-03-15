namespace RLD;

public struct ArcEpsilon
{
	private float _areaEps; //Field offset: 0x0
	private float _extrudeEps; //Field offset: 0x4
	private float _wireEps; //Field offset: 0x8

	public float AreaEps
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public float ExtrudeEps
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float WireEps
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float get_AreaEps() { }

	public float get_ExtrudeEps() { }

	public float get_WireEps() { }

	public void set_AreaEps(float value) { }

	public void set_ExtrudeEps(float value) { }

	public void set_WireEps(float value) { }

}

