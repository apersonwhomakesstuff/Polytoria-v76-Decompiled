namespace RLD;

public class GizmoHandleShape2D
{
	private bool _isVisible; //Field offset: 0x10
	private bool _isHoverable; //Field offset: 0x11
	private Shape2D _shape; //Field offset: 0x18

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

	public Shape2D Shape
	{
		 get { } //Length: 5
	}

	public GizmoHandleShape2D(Shape2D shape) { }

	public bool get_IsHoverable() { }

	public bool get_IsVisible() { }

	public Shape2D get_Shape() { }

	public void set_IsHoverable(bool value) { }

	public void set_IsVisible(bool value) { }

}

