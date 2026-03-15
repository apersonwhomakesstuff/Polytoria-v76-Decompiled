namespace RLD;

public class Vec3Samples
{
	private int _maxNumSamples; //Field offset: 0x10
	private List<Vector3> _samples; //Field offset: 0x18

	public int MaxNumSamples
	{
		 get { } //Length: 4
	}

	public int NumSamples
	{
		 get { } //Length: 60
	}

	public Vec3Samples() { }

	public void AddSample(Vector3 sample) { }

	public int get_MaxNumSamples() { }

	public int get_NumSamples() { }

	public Vector3 GetAverage() { }

	public void SetMaxNumSamples(int maxNumSamples) { }

}

