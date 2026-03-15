namespace RLD;

public class ObjectGrabHotkeys : Settings
{
	[SerializeField]
	private Hotkeys _toggleGrab; //Field offset: 0x28
	[SerializeField]
	private Hotkeys _enableRotation; //Field offset: 0x30
	[SerializeField]
	private Hotkeys _enableRotationAroundAnchor; //Field offset: 0x38
	[SerializeField]
	private Hotkeys _enableScaling; //Field offset: 0x40
	[SerializeField]
	private Hotkeys _enableOffsetFromSurface; //Field offset: 0x48
	[SerializeField]
	private Hotkeys _enableAnchorAdjust; //Field offset: 0x50
	[SerializeField]
	private Hotkeys _enableOffsetFromAnchor; //Field offset: 0x58
	[SerializeField]
	private Hotkeys _nextAlignmentAxis; //Field offset: 0x60

	public Hotkeys EnableAnchorAdjust
	{
		 get { } //Length: 5
	}

	public Hotkeys EnableOffsetFromAnchor
	{
		 get { } //Length: 5
	}

	public Hotkeys EnableOffsetFromSurface
	{
		 get { } //Length: 5
	}

	public Hotkeys EnableRotation
	{
		 get { } //Length: 95
	}

	public Hotkeys EnableRotationAroundAnchor
	{
		 get { } //Length: 5
	}

	public Hotkeys EnableScaling
	{
		 get { } //Length: 5
	}

	public Hotkeys NextAlignmentAxis
	{
		 get { } //Length: 5
	}

	public Hotkeys ToggleGrab
	{
		 get { } //Length: 5
	}

	public ObjectGrabHotkeys() { }

	private void EstablishPotentialOverlaps() { }

	public Hotkeys get_EnableAnchorAdjust() { }

	public Hotkeys get_EnableOffsetFromAnchor() { }

	public Hotkeys get_EnableOffsetFromSurface() { }

	public Hotkeys get_EnableRotation() { }

	public Hotkeys get_EnableRotationAroundAnchor() { }

	public Hotkeys get_EnableScaling() { }

	public Hotkeys get_NextAlignmentAxis() { }

	public Hotkeys get_ToggleGrab() { }

}

