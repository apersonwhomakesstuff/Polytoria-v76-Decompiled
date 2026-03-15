namespace RLD;

public class CameraSettings : Settings
{
	[SerializeField]
	private bool _canProcessInput; //Field offset: 0x28

	public bool CanProcessInput
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public CameraSettings() { }

	public bool get_CanProcessInput() { }

	public void set_CanProcessInput(bool value) { }

}

