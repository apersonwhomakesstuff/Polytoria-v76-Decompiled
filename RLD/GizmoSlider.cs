namespace RLD;

public abstract class GizmoSlider : IGizmoSlider
{
	private GizmoHandle _handle; //Field offset: 0x10
	private Gizmo _gizmo; //Field offset: 0x18
	private bool _isVisible; //Field offset: 0x20
	private bool _isHoverable; //Field offset: 0x21

	public override Priority GenericHoverPriority
	{
		 get { } //Length: 27
	}

	public override Gizmo Gizmo
	{
		 get { } //Length: 5
	}

	protected GizmoHandle Handle
	{
		 get { } //Length: 5
	}

	public override int HandleId
	{
		 get { } //Length: 26
	}

	public override Priority HoverPriority2D
	{
		 get { } //Length: 27
	}

	public override Priority HoverPriority3D
	{
		 get { } //Length: 27
	}

	public bool IsHoverable
	{
		 get { } //Length: 5
	}

	public bool IsHovered
	{
		 get { } //Length: 51
	}

	public bool IsVisible
	{
		 get { } //Length: 5
	}

	public GizmoSlider(Gizmo gizmo, int handleId) { }

	public override Priority get_GenericHoverPriority() { }

	public override Gizmo get_Gizmo() { }

	protected GizmoHandle get_Handle() { }

	public override int get_HandleId() { }

	public override Priority get_HoverPriority2D() { }

	public override Priority get_HoverPriority3D() { }

	public bool get_IsHoverable() { }

	public bool get_IsHovered() { }

	public bool get_IsVisible() { }

	protected abstract void OnHoverableStateChanged() { }

	protected abstract void OnVisibilityStateChanged() { }

	public abstract void Render(Camera camera) { }

	public override void SetHoverable(bool isHoverable) { }

	public abstract void SetSnapEnabled(bool isEnabled) { }

	public override void SetVisible(bool isVisible) { }

}

