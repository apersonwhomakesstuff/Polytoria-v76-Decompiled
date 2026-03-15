namespace Polytoria.Datamodel;

[Instantiatable]
public class BoolValue : ValueBase
{
	[SyncVar(hook = "OnValueChanged")]
	private bool val; //Field offset: 0x100
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_val; //Field offset: 0x108

	public bool Networkval
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	public bool Value
	{
		 get { } //Length: 8
		 set { } //Length: 122
	}

	public BoolValue() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public bool get_Networkval() { }

	public bool get_Value() { }

	private void OnValueChanged(bool oldValue, bool newValue) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Networkval(in bool value) { }

	public void set_Value(bool value) { }

	public virtual bool Weaved() { }

}

