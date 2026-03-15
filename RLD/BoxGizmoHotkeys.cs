namespace RLD;

public class BoxGizmoHotkeys : Settings
{
	[SerializeField]
	private Hotkeys _enableSnapping; //Field offset: 0x28
	[SerializeField]
	private Hotkeys _enableCenterPivot; //Field offset: 0x30

	public Hotkeys EnableCenterPivot
	{
		 get { } //Length: 95
	}

	public Hotkeys EnableSnapping
	{
		 get { } //Length: 5
	}

	public BoxGizmoHotkeys() { }

	public Hotkeys get_EnableCenterPivot() { }

	public Hotkeys get_EnableSnapping() { }

}

