namespace Polytoria.Datamodel;

public class PlayerGUI : Instance
{
	private CanvasGroup canvasGroup; //Field offset: 0xF8
	[SyncVar(hook = "SyncSetInteractable")]
	private bool interactable; //Field offset: 0x100
	[SyncVar(hook = "SyncSetOpacity")]
	private float opacity; //Field offset: 0x104
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_interactable; //Field offset: 0x108
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_opacity; //Field offset: 0x110

	[Archivable]
	[CreatorProperty]
	public bool Interactable
	{
		 get { } //Length: 8
		 set { } //Length: 145
	}

	public bool Networkinteractable
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public float Networkopacity
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	public float Opacity
	{
		 get { } //Length: 9
		 set { } //Length: 143
	}

	public PlayerGUI() { }

	protected virtual void Awake() { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public bool get_Interactable() { }

	public bool get_Networkinteractable() { }

	public float get_Networkopacity() { }

	public float get_Opacity() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Interactable(bool value) { }

	public void set_Networkinteractable(in bool value) { }

	public void set_Networkopacity(in float value) { }

	public void set_Opacity(float value) { }

	protected virtual void Start() { }

	private void SyncSetInteractable(bool oldValue, bool newValue) { }

	private void SyncSetOpacity(float oldValue, float newValue) { }

	public virtual bool Weaved() { }

}

