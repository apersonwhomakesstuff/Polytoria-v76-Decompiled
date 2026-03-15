namespace RLD;

public class CameraHotkeys : Settings
{
	[SerializeField]
	private Hotkeys _moveForward; //Field offset: 0x28
	[SerializeField]
	private Hotkeys _moveBack; //Field offset: 0x30
	[SerializeField]
	private Hotkeys _strafeLeft; //Field offset: 0x38
	[SerializeField]
	private Hotkeys _strafeRight; //Field offset: 0x40
	[SerializeField]
	private Hotkeys _moveUp; //Field offset: 0x48
	[SerializeField]
	private Hotkeys _moveDown; //Field offset: 0x50
	[SerializeField]
	private Hotkeys _pan; //Field offset: 0x58
	[SerializeField]
	private Hotkeys _lookAround; //Field offset: 0x60
	[SerializeField]
	private Hotkeys _orbit; //Field offset: 0x68
	[SerializeField]
	private Hotkeys _alternateMoveSpeed; //Field offset: 0x70

	public Hotkeys AlternateMoveSpeed
	{
		 get { } //Length: 5
	}

	public Hotkeys LookAround
	{
		 get { } //Length: 5
	}

	public Hotkeys MoveBack
	{
		 get { } //Length: 95
	}

	public Hotkeys MoveDown
	{
		 get { } //Length: 5
	}

	public Hotkeys MoveForward
	{
		 get { } //Length: 5
	}

	public Hotkeys MoveUp
	{
		 get { } //Length: 5
	}

	public Hotkeys Orbit
	{
		 get { } //Length: 5
	}

	public Hotkeys Pan
	{
		 get { } //Length: 5
	}

	public Hotkeys StrafeLeft
	{
		 get { } //Length: 5
	}

	public Hotkeys StrafeRight
	{
		 get { } //Length: 5
	}

	public CameraHotkeys() { }

	public Hotkeys get_AlternateMoveSpeed() { }

	public Hotkeys get_LookAround() { }

	public Hotkeys get_MoveBack() { }

	public Hotkeys get_MoveDown() { }

	public Hotkeys get_MoveForward() { }

	public Hotkeys get_MoveUp() { }

	public Hotkeys get_Orbit() { }

	public Hotkeys get_Pan() { }

	public Hotkeys get_StrafeLeft() { }

	public Hotkeys get_StrafeRight() { }

}

