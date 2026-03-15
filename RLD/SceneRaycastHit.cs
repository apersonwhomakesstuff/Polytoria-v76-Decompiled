namespace RLD;

public class SceneRaycastHit
{
	private GameObjectRayHit _objectHit; //Field offset: 0x10
	private XZGridRayHit _gridHit; //Field offset: 0x18

	public XZGridRayHit GridHit
	{
		 get { } //Length: 5
	}

	public GameObjectRayHit ObjectHit
	{
		 get { } //Length: 5
	}

	public bool WasAnObjectHit
	{
		 get { } //Length: 9
	}

	public bool WasAnythingHit
	{
		 get { } //Length: 19
	}

	public bool WasGridHit
	{
		 get { } //Length: 9
	}

	public SceneRaycastHit(GameObjectRayHit objectRayHit, XZGridRayHit gridRayHit) { }

	public XZGridRayHit get_GridHit() { }

	public GameObjectRayHit get_ObjectHit() { }

	public bool get_WasAnObjectHit() { }

	public bool get_WasAnythingHit() { }

	public bool get_WasGridHit() { }

}

