namespace Polytoria.Datamodel;

[Instantiatable]
public class ColorValue : ValueBase
{
	[SyncVar(hook = "OnValueChanged")]
	private Color val; //Field offset: 0x100
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_val; //Field offset: 0x110

	public Color Networkval
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	[Archivable]
	[CreatorProperty]
	public Color Value
	{
		 get { } //Length: 14
		 set { } //Length: 229
	}

	public ColorValue() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public Color get_Networkval() { }

	public Color get_Value() { }

	private void OnValueChanged(Color oldValue, Color newValue) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Networkval(in Color value) { }

	public void set_Value(Color value) { }

	public virtual bool Weaved() { }

}

