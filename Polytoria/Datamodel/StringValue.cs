namespace Polytoria.Datamodel;

[Instantiatable]
public class StringValue : ValueBase
{
	[SyncVar(hook = "OnValueChanged")]
	private string val; //Field offset: 0x100
	public Action<String, String> _Mirror_SyncVarHookDelegate_val; //Field offset: 0x108

	public string Networkval
	{
		 get { } //Length: 8
		 set { } //Length: 103
	}

	[Archivable]
	[CreatorProperty]
	public string Value
	{
		 get { } //Length: 8
		 set { } //Length: 131
	}

	public StringValue() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public string get_Networkval() { }

	public string get_Value() { }

	private void OnValueChanged(string oldValue, string newValue) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Networkval(in string value) { }

	public void set_Value(string value) { }

	public virtual bool Weaved() { }

}

