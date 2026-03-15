namespace RLD;

public class CameraPanSettings : Settings
{
	[SerializeField]
	private CameraPanMode _panMode; //Field offset: 0x28
	[SerializeField]
	private float _standardPanSensitivity; //Field offset: 0x2C
	[SerializeField]
	private float _smoothPanSensitivity; //Field offset: 0x30
	[SerializeField]
	private float _smoothValue; //Field offset: 0x34
	[SerializeField]
	private bool _invertX; //Field offset: 0x38
	[SerializeField]
	private bool _invertY; //Field offset: 0x39
	[SerializeField]
	private bool _isPanningEnabled; //Field offset: 0x3A

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

	public bool IsPanningEnabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public CameraPanMode PanMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float Sensitivity
	{
		 get { } //Length: 18
	}

	public float SmoothPanSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public float SmoothValue
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public float StandardPanSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public CameraPanSettings() { }

	public bool get_InvertX() { }

	public bool get_InvertY() { }

	public bool get_IsPanningEnabled() { }

	public CameraPanMode get_PanMode() { }

	public float get_Sensitivity() { }

	public float get_SmoothPanSensitivity() { }

	public float get_SmoothValue() { }

	public float get_StandardPanSensitivity() { }

	public void set_InvertX(bool value) { }

	public void set_InvertY(bool value) { }

	public void set_IsPanningEnabled(bool value) { }

	public void set_PanMode(CameraPanMode value) { }

	public void set_SmoothPanSensitivity(float value) { }

	public void set_SmoothValue(float value) { }

	public void set_StandardPanSensitivity(float value) { }

}

