namespace RLD;

public class Object2ObjectSnapHotkeys : Settings
{
	[SerializeField]
	private Hotkeys _toggleSnap; //Field offset: 0x28
	[SerializeField]
	private Hotkeys _toggleSitBelowSurface; //Field offset: 0x30
	[SerializeField]
	private Hotkeys _enableMoreControl; //Field offset: 0x38
	[SerializeField]
	private Hotkeys _enableFlexiSnap; //Field offset: 0x40

	public Hotkeys EnableFlexiSnap
	{
		 get { } //Length: 5
	}

	public Hotkeys EnableMoreControl
	{
		 get { } //Length: 5
	}

	public Hotkeys ToggleSitBelowSurface
	{
		 get { } //Length: 95
	}

	public Hotkeys ToggleSnap
	{
		 get { } //Length: 5
	}

	public Object2ObjectSnapHotkeys() { }

	public Hotkeys get_EnableFlexiSnap() { }

	public Hotkeys get_EnableMoreControl() { }

	public Hotkeys get_ToggleSitBelowSurface() { }

	public Hotkeys get_ToggleSnap() { }

}

