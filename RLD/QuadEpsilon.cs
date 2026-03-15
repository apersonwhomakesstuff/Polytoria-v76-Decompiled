namespace RLD;

public struct QuadEpsilon
{
	private Vector2 _sizeEps; //Field offset: 0x0
	private float _extrudeEps; //Field offset: 0x8
	private float _wireEps; //Field offset: 0xC

	public float ExtrudeEps
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float HeightEps
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public Vector2 SizeEps
	{
		 get { } //Length: 18
		 set { } //Length: 41
	}

	public float WidthEps
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public float WireEps
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float get_ExtrudeEps() { }

	public float get_HeightEps() { }

	public Vector2 get_SizeEps() { }

	public float get_WidthEps() { }

	public float get_WireEps() { }

	public void set_ExtrudeEps(float value) { }

	public void set_HeightEps(float value) { }

	public void set_SizeEps(Vector2 value) { }

	public void set_WidthEps(float value) { }

	public void set_WireEps(float value) { }

}

