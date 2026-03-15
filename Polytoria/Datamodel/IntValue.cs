namespace Polytoria.Datamodel;

[Instantiatable]
public class IntValue : ValueBase
{
	[SyncVar(hook = "OnValueChanged")]
	private int val; //Field offset: 0x100
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_val; //Field offset: 0x108

	public int Networkval
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	[Archivable]
	[CreatorProperty]
	public int Value
	{
		 get { } //Length: 7
		 set { } //Length: 119
	}

	public IntValue() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public int get_Networkval() { }

	public int get_Value() { }

	private void OnValueChanged(int oldValue, int newValue) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Networkval(in int value) { }

	public void set_Value(int value) { }

	public virtual bool Weaved() { }

}

