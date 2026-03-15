namespace RLD;

public class UniversalGizmoHotkeys : Settings
{
	[SerializeField]
	private Hotkeys _enable2DMode; //Field offset: 0x28
	[SerializeField]
	private Hotkeys _enableSnapping; //Field offset: 0x30
	[SerializeField]
	private Hotkeys _enableVertexSnapping; //Field offset: 0x38

	public Hotkeys Enable2DMode
	{
		 get { } //Length: 5
	}

	public Hotkeys EnableSnapping
	{
		 get { } //Length: 95
	}

	public Hotkeys EnableVertexSnapping
	{
		 get { } //Length: 5
	}

	public UniversalGizmoHotkeys() { }

	public Hotkeys get_Enable2DMode() { }

	public Hotkeys get_EnableSnapping() { }

	public Hotkeys get_EnableVertexSnapping() { }

}

