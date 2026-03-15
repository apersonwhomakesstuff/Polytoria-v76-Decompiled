namespace RLD;

public class ObjectGridSnapHotkeys : Settings
{
	[SerializeField]
	private Hotkeys _beginGridSnap; //Field offset: 0x28

	public Hotkeys BeginGridSnap
	{
		 get { } //Length: 5
	}

	public ObjectGridSnapHotkeys() { }

	public Hotkeys get_BeginGridSnap() { }

}

