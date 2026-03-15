namespace RLD;

public struct GizmoDragInfo
{
	private bool _isDragged; //Field offset: 0x0
	private int _handleId; //Field offset: 0x4
	private Vector3 _dragBeginPoint; //Field offset: 0x8
	private GizmoDragChannel _dragChannel; //Field offset: 0x14
	private GizmoDimension _handleDimension; //Field offset: 0x18
	private Vector3 _totalOffset; //Field offset: 0x1C
	private Quaternion _totalRotation; //Field offset: 0x28
	private Vector3 _totalScale; //Field offset: 0x38
	private Vector3 _relativeOffset; //Field offset: 0x44
	private Quaternion _relativeRotation; //Field offset: 0x50
	private Vector3 _relativeScale; //Field offset: 0x60

	public Vector3 DragBeginPoint
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public GizmoDragChannel DragChannel
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

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

	public bool IsDragged
	{
		 get { } //Length: 4
		 set { } //Length: 3
	}

	public Vector3 RelativeOffset
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public Quaternion RelativeRotation
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Vector3 RelativeScale
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public Vector3 TotalOffset
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public Quaternion TotalRotation
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public Vector3 TotalScale
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public Vector3 get_DragBeginPoint() { }

	public GizmoDragChannel get_DragChannel() { }

	public GizmoDimension get_HandleDimension() { }

	public int get_HandleId() { }

	public bool get_IsDragged() { }

	public Vector3 get_RelativeOffset() { }

	public Quaternion get_RelativeRotation() { }

	public Vector3 get_RelativeScale() { }

	public Vector3 get_TotalOffset() { }

	public Quaternion get_TotalRotation() { }

	public Vector3 get_TotalScale() { }

	public void Reset() { }

	public void set_DragBeginPoint(Vector3 value) { }

	public void set_DragChannel(GizmoDragChannel value) { }

	public void set_HandleDimension(GizmoDimension value) { }

	public void set_HandleId(int value) { }

	public void set_IsDragged(bool value) { }

	public void set_RelativeOffset(Vector3 value) { }

	public void set_RelativeRotation(Quaternion value) { }

	public void set_RelativeScale(Vector3 value) { }

	public void set_TotalOffset(Vector3 value) { }

	public void set_TotalRotation(Quaternion value) { }

	public void set_TotalScale(Vector3 value) { }

}

