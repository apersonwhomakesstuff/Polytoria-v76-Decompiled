namespace RLD;

public class CameraZoomSettings : Settings
{
	[SerializeField]
	private CameraZoomMode _zoomMode; //Field offset: 0x28
	[SerializeField]
	private float _orthoStandardZoomSensitivity; //Field offset: 0x2C
	[SerializeField]
	private float _perspStandardZoomSensitivity; //Field offset: 0x30
	[SerializeField]
	private float _orthoSmoothZoomSensitivity; //Field offset: 0x34
	[SerializeField]
	private float _perspSmoothZoomSensitivity; //Field offset: 0x38
	[SerializeField]
	private float _orthoZoomSmoothValue; //Field offset: 0x3C
	[SerializeField]
	private float _perspZoomSmoothValue; //Field offset: 0x40
	[SerializeField]
	private bool _invertZoomAxis; //Field offset: 0x44
	[SerializeField]
	private bool _isZoomEnabled; //Field offset: 0x45

	public bool InvertZoomAxis
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool IsZoomEnabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float OrthoSmoothZoomSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public float OrthoStandardZoomSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public float OrthoZoomSmoothValue
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public float PerspSmoothZoomSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public float PerspStandardZoomSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public float PerspZoomSmoothValue
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public CameraZoomMode ZoomMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public CameraZoomSettings() { }

	public bool get_InvertZoomAxis() { }

	public bool get_IsZoomEnabled() { }

	public float get_OrthoSmoothZoomSensitivity() { }

	public float get_OrthoStandardZoomSensitivity() { }

	public float get_OrthoZoomSmoothValue() { }

	public float get_PerspSmoothZoomSensitivity() { }

	public float get_PerspStandardZoomSensitivity() { }

	public float get_PerspZoomSmoothValue() { }

	public CameraZoomMode get_ZoomMode() { }

	public float GetZoomSensitivity(Camera camera) { }

	public float GetZoomSmoothValue(Camera camera) { }

	public void set_InvertZoomAxis(bool value) { }

	public void set_IsZoomEnabled(bool value) { }

	public void set_OrthoSmoothZoomSensitivity(float value) { }

	public void set_OrthoStandardZoomSensitivity(float value) { }

	public void set_OrthoZoomSmoothValue(float value) { }

	public void set_PerspSmoothZoomSensitivity(float value) { }

	public void set_PerspStandardZoomSensitivity(float value) { }

	public void set_PerspZoomSmoothValue(float value) { }

	public void set_ZoomMode(CameraZoomMode value) { }

}

