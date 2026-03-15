namespace RLD;

public class GizmoScaleGuideLookAndFeel
{
	[SerializeField]
	private bool _useZoomFactor; //Field offset: 0x10
	[SerializeField]
	private Color _xAxisColor; //Field offset: 0x14
	[SerializeField]
	private Color _yAxisColor; //Field offset: 0x24
	[SerializeField]
	private Color _zAxisColor; //Field offset: 0x34
	[SerializeField]
	private float _axisLength; //Field offset: 0x44

	public float AxisLength
	{
		 get { } //Length: 6
		 set { } //Length: 15
	}

	public bool UseZoomFactor
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public Color XAxisColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Color YAxisColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Color ZAxisColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public GizmoScaleGuideLookAndFeel() { }

	public float get_AxisLength() { }

	public bool get_UseZoomFactor() { }

	public Color get_XAxisColor() { }

	public Color get_YAxisColor() { }

	public Color get_ZAxisColor() { }

	public void set_AxisLength(float value) { }

	public void set_UseZoomFactor(bool value) { }

	public void set_XAxisColor(Color value) { }

	public void set_YAxisColor(Color value) { }

	public void set_ZAxisColor(Color value) { }

}

