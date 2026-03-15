namespace RLD;

public class CameraOrbitSettings : Settings
{
	[SerializeField]
	private CameraOrbitMode _orbitMode; //Field offset: 0x28
	[SerializeField]
	private float _standardOrbitSensitivity; //Field offset: 0x2C
	[SerializeField]
	private float _smoothOrbitSensitivity; //Field offset: 0x30
	[SerializeField]
	private float _smoothValue; //Field offset: 0x34
	[SerializeField]
	private bool _invertX; //Field offset: 0x38
	[SerializeField]
	private bool _invertY; //Field offset: 0x39
	[SerializeField]
	private bool _isOrbitEnabled; //Field offset: 0x3A

	public bool InvertX
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool InvertY
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool IsOrbitEnabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public CameraOrbitMode OrbitMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float OrbitSensitivity
	{
		 get { } //Length: 18
	}

	public float SmoothOrbitSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public float SmoothValue
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public float StandardOrbitSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public CameraOrbitSettings() { }

	public bool get_InvertX() { }

	public bool get_InvertY() { }

	public bool get_IsOrbitEnabled() { }

	public CameraOrbitMode get_OrbitMode() { }

	public float get_OrbitSensitivity() { }

	public float get_SmoothOrbitSensitivity() { }

	public float get_SmoothValue() { }

	public float get_StandardOrbitSensitivity() { }

	public void set_InvertX(bool value) { }

	public void set_InvertY(bool value) { }

	public void set_IsOrbitEnabled(bool value) { }

	public void set_OrbitMode(CameraOrbitMode value) { }

	public void set_SmoothOrbitSensitivity(float value) { }

	public void set_SmoothValue(float value) { }

	public void set_StandardOrbitSensitivity(float value) { }

}

