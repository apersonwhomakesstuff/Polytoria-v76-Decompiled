namespace RLD;

public class RTInputDevice : MonoSingleton<RTInputDevice>
{
	private IInputDevice _inputDevice; //Field offset: 0x20

	public IInputDevice Device
	{
		 get { } //Length: 5
	}

	public InputDeviceType DeviceType
	{
		 get { } //Length: 189
	}

	public RTInputDevice() { }

	private void Awake() { }

	public IInputDevice get_Device() { }

	public InputDeviceType get_DeviceType() { }

	public void Update_SystemCall() { }

}

