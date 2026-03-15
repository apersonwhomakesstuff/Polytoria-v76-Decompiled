namespace RLD;

public class SceneSettings : Settings
{
	[SerializeField]
	private ScenePhysicsMode _physicsMode; //Field offset: 0x28
	[SerializeField]
	private float _noVolumeObjectSize; //Field offset: 0x2C

	public float NoVolumeObjectSize
	{
		 get { } //Length: 6
		 set { } //Length: 105
	}

	public ScenePhysicsMode PhysicsMode
	{
		 get { } //Length: 4
		 set { } //Length: 89
	}

	public SceneSettings() { }

	public float get_NoVolumeObjectSize() { }

	public ScenePhysicsMode get_PhysicsMode() { }

	public void set_NoVolumeObjectSize(float value) { }

	public void set_PhysicsMode(ScenePhysicsMode value) { }

}

