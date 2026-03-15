namespace RLD;

public class InputDeviceDeltaCapture
{
	private int _id; //Field offset: 0x10
	private Vector3 _origin; //Field offset: 0x14
	private Vector3 _delta; //Field offset: 0x20

	public Vector3 Delta
	{
		 get { } //Length: 19
	}

	public int Id
	{
		 get { } //Length: 4
	}

	public Vector3 Origin
	{
		 get { } //Length: 19
	}

	public InputDeviceDeltaCapture(int id, Vector3 origin) { }

	public Vector3 get_Delta() { }

	public int get_Id() { }

	public Vector3 get_Origin() { }

	public void Update(Vector3 devicePosition) { }

}

