namespace RLD;

public class GizmoHandleShape3D
{
	private bool _isVisible; //Field offset: 0x10
	private bool _isHoverable; //Field offset: 0x11
	private Shape3D _shape; //Field offset: 0x18

	public bool IsHoverable
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool IsVisible
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public Shape3D Shape
	{
		 get { } //Length: 5
	}

	public GizmoHandleShape3D(Shape3D shape) { }

	public bool get_IsHoverable() { }

	public bool get_IsVisible() { }

	public Shape3D get_Shape() { }

	public void set_IsHoverable(bool value) { }

	public void set_IsVisible(bool value) { }

}

