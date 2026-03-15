namespace Polytoria.Datamodel;

[Instantiatable]
public class NumberValue : ValueBase
{
	[SyncVar(hook = "OnValueChanged")]
	private float val; //Field offset: 0x100
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_val; //Field offset: 0x108

	public float Networkval
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	public float Value
	{
		 get { } //Length: 9
		 set { } //Length: 129
	}

	public NumberValue() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public float get_Networkval() { }

	public float get_Value() { }

	private void OnValueChanged(float oldValue, float newValue) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Networkval(in float value) { }

	public void set_Value(float value) { }

	public virtual bool Weaved() { }

}

