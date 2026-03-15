namespace RLD;

public class ObjectKeyRotationSettings : Settings
{
	[SerializeField]
	private float _xRotationStep; //Field offset: 0x28
	[SerializeField]
	private float _yRotationStep; //Field offset: 0x2C
	[SerializeField]
	private float _zRotationStep; //Field offset: 0x30

	public float XRotationStep
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float YRotationStep
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public float ZRotationStep
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public ObjectKeyRotationSettings() { }

	public float get_XRotationStep() { }

	public float get_YRotationStep() { }

	public float get_ZRotationStep() { }

	public void set_XRotationStep(float value) { }

	public void set_YRotationStep(float value) { }

	public void set_ZRotationStep(float value) { }

}

