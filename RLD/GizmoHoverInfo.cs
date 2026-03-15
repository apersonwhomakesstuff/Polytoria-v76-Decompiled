namespace RLD;

public struct GizmoHoverInfo
{
	private bool _isHovered; //Field offset: 0x0
	private int _handleId; //Field offset: 0x4
	private GizmoDimension _handleDimension; //Field offset: 0x8
	private Vector3 _hoverPoint; //Field offset: 0xC

	public GizmoDimension HandleDimension
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int HandleId
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Vector3 HoverPoint
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public bool IsHovered
	{
		 get { } //Length: 4
		 set { } //Length: 3
	}

	public GizmoDimension get_HandleDimension() { }

	public int get_HandleId() { }

	public Vector3 get_HoverPoint() { }

	public bool get_IsHovered() { }

	public void Reset() { }

	public void set_HandleDimension(GizmoDimension value) { }

	public void set_HandleId(int value) { }

	public void set_HoverPoint(Vector3 value) { }

	public void set_IsHovered(bool value) { }

}

