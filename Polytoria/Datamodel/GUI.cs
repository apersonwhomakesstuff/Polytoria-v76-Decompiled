namespace Polytoria.Datamodel;

[Instantiatable]
public class GUI : Instance
{
	private CreatorViewport vp; //Field offset: 0xF8
	[SyncVar(hook = "SyncSetVisible")]
	private bool visible; //Field offset: 0x100
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_visible; //Field offset: 0x108

	public bool Networkvisible
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	public bool Visible
	{
		 get { } //Length: 8
		 set { } //Length: 162
	}

	public GUI() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public bool get_Networkvisible() { }

	public bool get_Visible() { }

	protected virtual void OnHide() { }

	protected virtual void OnShow() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Networkvisible(in bool value) { }

	public void set_Visible(bool value) { }

	protected virtual void Start() { }

	public void SyncSetVisible(bool oldValue, bool newValue) { }

	public void Update() { }

	public virtual bool Weaved() { }

}

