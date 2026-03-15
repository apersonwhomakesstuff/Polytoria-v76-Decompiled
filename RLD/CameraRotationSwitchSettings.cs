namespace RLD;

public class CameraRotationSwitchSettings : Settings
{
	private static readonly float _minConstantDuration; //Field offset: 0x0
	[SerializeField]
	private CameraRotationSwitchMode _switchMode; //Field offset: 0x28
	[SerializeField]
	private float _constantSwitchDurationInSeconds; //Field offset: 0x2C
	[SerializeField]
	private float _smoothValue; //Field offset: 0x30

	public float ConstantSwitchDurationInSeconds
	{
		 get { } //Length: 6
		 set { } //Length: 103
	}

	public float SmoothValue
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public CameraRotationSwitchMode SwitchMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	private static CameraRotationSwitchSettings() { }

	public CameraRotationSwitchSettings() { }

	public float get_ConstantSwitchDurationInSeconds() { }

	public float get_SmoothValue() { }

	public CameraRotationSwitchMode get_SwitchMode() { }

	public void set_ConstantSwitchDurationInSeconds(float value) { }

	public void set_SmoothValue(float value) { }

	public void set_SwitchMode(CameraRotationSwitchMode value) { }

}

