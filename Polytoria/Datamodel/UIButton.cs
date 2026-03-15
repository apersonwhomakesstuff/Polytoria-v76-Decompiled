namespace Polytoria.Datamodel;

[Instantiatable]
public class UIButton : UILabel
{
	private Button button; //Field offset: 0x298
	[SyncVar(hook = "SetInteractable")]
	private bool interactable; //Field offset: 0x2A0
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_interactable; //Field offset: 0x2A8

	[Archivable]
	[CreatorProperty]
	public bool Interactable
	{
		 get { } //Length: 8
		 set { } //Length: 129
	}

	public bool Networkinteractable
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public UIButton() { }

	[CompilerGenerated]
	private void <Start>b__6_0() { }

	protected virtual void Awake() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public bool get_Interactable() { }

	public bool get_Networkinteractable() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Interactable(bool value) { }

	public void set_Networkinteractable(in bool value) { }

	private void SetInteractable(bool oldValue, bool value) { }

	protected virtual void Start() { }

	public virtual bool Weaved() { }

}

