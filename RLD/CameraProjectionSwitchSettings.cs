namespace RLD;

public class CameraProjectionSwitchSettings : Settings
{
	[SerializeField]
	private CameraProjectionSwitchMode _switchMode; //Field offset: 0x28
	[SerializeField]
	private float _transitionDurationInSeconds; //Field offset: 0x2C

	public CameraProjectionSwitchMode SwitchMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float TransitionDurationInSeconds
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public CameraProjectionSwitchSettings() { }

	public CameraProjectionSwitchMode get_SwitchMode() { }

	public float get_TransitionDurationInSeconds() { }

	public void set_SwitchMode(CameraProjectionSwitchMode value) { }

	public void set_TransitionDurationInSeconds(float value) { }

}

