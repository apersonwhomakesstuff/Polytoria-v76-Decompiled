namespace RLD;

public class CameraFocusSettings : Settings
{
	[SerializeField]
	private CameraFocusMode _focusMode; //Field offset: 0x28
	[SerializeField]
	private float _constantSpeed; //Field offset: 0x2C
	[SerializeField]
	private float _smoothTime; //Field offset: 0x30
	[SerializeField]
	private float _focusDistanceAdd; //Field offset: 0x34

	public float ConstantSpeed
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public float FocusDistanceAdd
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public CameraFocusMode FocusMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float SmoothTime
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public CameraFocusSettings() { }

	public float get_ConstantSpeed() { }

	public float get_FocusDistanceAdd() { }

	public CameraFocusMode get_FocusMode() { }

	public float get_SmoothTime() { }

	public void set_ConstantSpeed(float value) { }

	public void set_FocusDistanceAdd(float value) { }

	public void set_FocusMode(CameraFocusMode value) { }

	public void set_SmoothTime(float value) { }

}

