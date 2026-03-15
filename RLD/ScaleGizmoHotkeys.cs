namespace RLD;

public class ScaleGizmoHotkeys : Settings
{
	[SerializeField]
	private Hotkeys _enableSnapping; //Field offset: 0x28
	[SerializeField]
	private Hotkeys _changeMultiAxisMode; //Field offset: 0x30

	public Hotkeys ChangeMultiAxisMode
	{
		 get { } //Length: 95
	}

	public Hotkeys EnableSnapping
	{
		 get { } //Length: 5
	}

	public ScaleGizmoHotkeys() { }

	public Hotkeys get_ChangeMultiAxisMode() { }

	public Hotkeys get_EnableSnapping() { }

}

