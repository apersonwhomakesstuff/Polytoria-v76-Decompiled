namespace RLD;

public class SceneGridHotkeys : Settings
{
	[SerializeField]
	private Hotkeys _gridUp; //Field offset: 0x28
	[SerializeField]
	private Hotkeys _gridDown; //Field offset: 0x30
	private Hotkeys _snapToCursorPickPoint; //Field offset: 0x38

	public Hotkeys GridDown
	{
		 get { } //Length: 95
	}

	public Hotkeys GridUp
	{
		 get { } //Length: 5
	}

	public Hotkeys SnapToCursorPickPoint
	{
		 get { } //Length: 5
	}

	public SceneGridHotkeys() { }

	public Hotkeys get_GridDown() { }

	public Hotkeys get_GridUp() { }

	public Hotkeys get_SnapToCursorPickPoint() { }

}

