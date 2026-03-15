namespace RLD;

public class GizmoOverrideColor
{
	private bool _isActive; //Field offset: 0x10
	private Color _color; //Field offset: 0x14

	public Color Color
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public bool IsActive
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public GizmoOverrideColor() { }

	public Color get_Color() { }

	public bool get_IsActive() { }

	public void set_Color(Color value) { }

	public void set_IsActive(bool value) { }

}

