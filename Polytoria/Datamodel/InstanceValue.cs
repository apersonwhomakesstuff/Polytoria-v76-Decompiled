namespace Polytoria.Datamodel;

[Instantiatable]
public class InstanceValue : ValueBase
{
	[SyncVar(hook = "OnValueChanged")]
	private Instance val; //Field offset: 0x100
	protected NetworkBehaviourSyncVar ___valNetId; //Field offset: 0x108
	public Action<Instance, Instance> _Mirror_SyncVarHookDelegate_val; //Field offset: 0x110

	public Instance Networkval
	{
		 get { } //Length: 71
		 set { } //Length: 339
	}

	[Archivable]
	[CreatorProperty]
	public Instance Value
	{
		 get { } //Length: 71
		 set { } //Length: 476
	}

	public InstanceValue() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public Instance get_Networkval() { }

	public Instance get_Value() { }

	private void OnValueChanged(Instance oldValue, Instance newValue) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Networkval(in Instance value) { }

	public void set_Value(Instance value) { }

	public virtual bool Weaved() { }

}

