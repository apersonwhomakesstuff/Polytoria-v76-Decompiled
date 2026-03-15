namespace RLD;

public interface IGizmoSlider
{

	public Priority GenericHoverPriority
	{
		 get { } //Length: 0
	}

	public Gizmo Gizmo
	{
		 get { } //Length: 0
	}

	public int HandleId
	{
		 get { } //Length: 0
	}

	public Priority HoverPriority2D
	{
		 get { } //Length: 0
	}

	public Priority HoverPriority3D
	{
		 get { } //Length: 0
	}

	public Priority get_GenericHoverPriority() { }

	public Gizmo get_Gizmo() { }

	public int get_HandleId() { }

	public Priority get_HoverPriority2D() { }

	public Priority get_HoverPriority3D() { }

	public void Render(Camera camera) { }

	public void SetHoverable(bool isHoverable) { }

	public void SetSnapEnabled(bool isEnabled) { }

	public void SetVisible(bool isVisible) { }

}

