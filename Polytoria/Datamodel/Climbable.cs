namespace Polytoria.Datamodel;

public class Climbable : Part
{
	[SyncVar]
	private float climbSpeed; //Field offset: 0x300

	[Archivable]
	[CreatorProperty]
	public float ClimbSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public float NetworkclimbSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public Climbable() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public float get_ClimbSpeed() { }

	public float get_NetworkclimbSpeed() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_ClimbSpeed(float value) { }

	public void set_NetworkclimbSpeed(in float value) { }

	protected virtual void Start() { }

	public virtual bool Weaved() { }

}

