namespace RLD;

public class CameraLookAroundSettings : Settings
{
	[SerializeField]
	private CameraLookAroundMode _lookAroundMode; //Field offset: 0x28
	[SerializeField]
	private float _standardLookAroundSensitivity; //Field offset: 0x2C
	[SerializeField]
	private float _smoothLookAroundSensitivity; //Field offset: 0x30
	[SerializeField]
	private float smoothValue; //Field offset: 0x34
	[SerializeField]
	private bool _invertX; //Field offset: 0x38
	[SerializeField]
	private bool _invertY; //Field offset: 0x39
	[SerializeField]
	private bool _isLookAroundEnabled; //Field offset: 0x3A

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

	public bool IsLookAroundEnabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public CameraLookAroundMode LookAroundMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float Sensitivity
	{
		 get { } //Length: 18
	}

	public float SmoothLookAroundSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public float SmoothValue
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public float StandardLookAroundSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public CameraLookAroundSettings() { }

	public bool get_InvertX() { }

	public bool get_InvertY() { }

	public bool get_IsLookAroundEnabled() { }

	public CameraLookAroundMode get_LookAroundMode() { }

	public float get_Sensitivity() { }

	public float get_SmoothLookAroundSensitivity() { }

	public float get_SmoothValue() { }

	public float get_StandardLookAroundSensitivity() { }

	public void set_InvertX(bool value) { }

	public void set_InvertY(bool value) { }

	public void set_IsLookAroundEnabled(bool value) { }

	public void set_LookAroundMode(CameraLookAroundMode value) { }

	public void set_SmoothLookAroundSensitivity(float value) { }

	public void set_SmoothValue(float value) { }

	public void set_StandardLookAroundSensitivity(float value) { }

}

