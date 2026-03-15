namespace Polytoria.Datamodel;

[Instantiatable]
public class BodyPosition : Instance
{
	[SyncVar]
	private Vector3 tPos; //Field offset: 0xF8
	[SyncVar]
	private float force; //Field offset: 0x104
	[SyncVar]
	private float accDist; //Field offset: 0x108

	[Archivable]
	[CreatorProperty]
	public float AcceptanceDistance
	{
		 get { } //Length: 9
		 set { } //Length: 8
	}

	[Archivable]
	[CreatorProperty]
	public float Force
	{
		 get { } //Length: 9
		 set { } //Length: 8
	}

	public float NetworkaccDist
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public float Networkforce
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public Vector3 NetworktPos
	{
		 get { } //Length: 25
		 set { } //Length: 218
	}

	[Archivable]
	[CreatorProperty]
	public Vector3 TargetPosition
	{
		 get { } //Length: 25
		 set { } //Length: 218
	}

	public BodyPosition() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	private void FixedUpdate() { }

	public float get_AcceptanceDistance() { }

	public float get_Force() { }

	public float get_NetworkaccDist() { }

	public float get_Networkforce() { }

	public Vector3 get_NetworktPos() { }

	public Vector3 get_TargetPosition() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_AcceptanceDistance(float value) { }

	public void set_Force(float value) { }

	public void set_NetworkaccDist(in float value) { }

	public void set_Networkforce(in float value) { }

	public void set_NetworktPos(in Vector3 value) { }

	public void set_TargetPosition(Vector3 value) { }

	protected virtual void Start() { }

	public virtual bool Weaved() { }

}

