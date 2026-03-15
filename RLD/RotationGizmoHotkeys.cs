namespace RLD;

public class RotationGizmoHotkeys : Settings
{
	[SerializeField]
	private Hotkeys _enableSnapping; //Field offset: 0x28

	public Hotkeys EnableSnapping
	{
		 get { } //Length: 5
	}

	public RotationGizmoHotkeys() { }

	public Hotkeys get_EnableSnapping() { }

}

