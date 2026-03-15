namespace Polytoria.Datamodel;

[Instantiatable]
public class Vector3Value : ValueBase
{
	[SyncVar(hook = "OnValueChanged")]
	private Vector3 val; //Field offset: 0x100
	public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_val; //Field offset: 0x110

	public Vector3 Networkval
	{
		 get { } //Length: 25
		 set { } //Length: 415
	}

	[Archivable]
	[CreatorProperty]
	public Vector3 Value
	{
		 get { } //Length: 25
		 set { } //Length: 819
	}

	public Vector3Value() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public Vector3 get_Networkval() { }

	public Vector3 get_Value() { }

	private void OnValueChanged(Vector3 oldValue, Vector3 newValue) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Networkval(in Vector3 value) { }

	public void set_Value(Vector3 value) { }

	public virtual bool Weaved() { }

}

