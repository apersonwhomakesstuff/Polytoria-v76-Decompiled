namespace RLD;

public class GizmoRotationArc3DLookAndFeel
{
	[SerializeField]
	private bool _useShortestRotation; //Field offset: 0x10
	[SerializeField]
	private GizmoRotationArcFillFlags _fillFlags; //Field offset: 0x14
	[SerializeField]
	private Color _color; //Field offset: 0x18
	[SerializeField]
	private Color _borderColor; //Field offset: 0x28

	public Color BorderColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Color Color
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public GizmoRotationArcFillFlags FillFlags
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool UseShortestRotation
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public GizmoRotationArc3DLookAndFeel() { }

	public Color get_BorderColor() { }

	public Color get_Color() { }

	public GizmoRotationArcFillFlags get_FillFlags() { }

	public bool get_UseShortestRotation() { }

	public void set_BorderColor(Color value) { }

	public void set_Color(Color value) { }

	public void set_FillFlags(GizmoRotationArcFillFlags value) { }

	public void set_UseShortestRotation(bool value) { }

}

