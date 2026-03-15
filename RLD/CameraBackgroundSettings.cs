namespace RLD;

public class CameraBackgroundSettings : Settings
{
	[SerializeField]
	private Color _firstColor; //Field offset: 0x28
	[SerializeField]
	private Color _secondColor; //Field offset: 0x38
	[SerializeField]
	private float _gradientOffset; //Field offset: 0x48
	[SerializeField]
	private bool _isVisible; //Field offset: 0x4C

	public Color FirstColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float GradientOffset
	{
		 get { } //Length: 6
		 set { } //Length: 38
	}

	public bool IsVisible
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public Color SecondColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public CameraBackgroundSettings() { }

	public Color get_FirstColor() { }

	public float get_GradientOffset() { }

	public bool get_IsVisible() { }

	public Color get_SecondColor() { }

	public void set_FirstColor(Color value) { }

	public void set_GradientOffset(float value) { }

	public void set_IsVisible(bool value) { }

	public void set_SecondColor(Color value) { }

}

