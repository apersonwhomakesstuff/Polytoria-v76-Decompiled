namespace RLD;

public struct TorusEpsilon
{
	private float _tubeRadiusEps; //Field offset: 0x0
	private float _cylHrzRadius; //Field offset: 0x4
	private float _cylVertRadius; //Field offset: 0x8

	public float CylHrzRadius
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float CylVertRadius
	{
		 get { } //Length: 6
		 set { } //Length: 13
	}

	public float TubeRadiusEps
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public float get_CylHrzRadius() { }

	public float get_CylVertRadius() { }

	public float get_TubeRadiusEps() { }

	public void set_CylHrzRadius(float value) { }

	public void set_CylVertRadius(float value) { }

	public void set_TubeRadiusEps(float value) { }

}

