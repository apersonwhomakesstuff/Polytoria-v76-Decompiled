namespace RLD;

public class ObjectSelectionRotationHotkeys : Settings
{
	[SerializeField]
	private Hotkeys _rotateAroundX; //Field offset: 0x28
	[SerializeField]
	private Hotkeys _rotateAroundY; //Field offset: 0x30
	[SerializeField]
	private Hotkeys _rotateAroundZ; //Field offset: 0x38
	[SerializeField]
	private Hotkeys _setRotationToIdentity; //Field offset: 0x40

	public Hotkeys RotateAroundX
	{
		 get { } //Length: 5
	}

	public Hotkeys RotateAroundY
	{
		 get { } //Length: 95
	}

	public Hotkeys RotateAroundZ
	{
		 get { } //Length: 5
	}

	public Hotkeys SetRotationToIdentity
	{
		 get { } //Length: 5
	}

	public ObjectSelectionRotationHotkeys() { }

	public Hotkeys get_RotateAroundX() { }

	public Hotkeys get_RotateAroundY() { }

	public Hotkeys get_RotateAroundZ() { }

	public Hotkeys get_SetRotationToIdentity() { }

}

