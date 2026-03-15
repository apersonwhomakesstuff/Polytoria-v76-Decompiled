namespace Polytoria.Datamodel;

[Instantiatable]
public class Seat : Part
{
	[SyncVar]
	private Player occupant; //Field offset: 0x300
	private float timeUntilCanSitAgain; //Field offset: 0x308
	[CompilerGenerated]
	private Action<Player> _Sat; //Field offset: 0x310
	public LuaEvent Sat; //Field offset: 0x318
	[CompilerGenerated]
	private Action<Player> _Vacated; //Field offset: 0x320
	public LuaEvent Vacated; //Field offset: 0x328
	protected NetworkBehaviourSyncVar ___occupantNetId; //Field offset: 0x330

	[MoonSharpHidden]
	public event Action<Player> _Sat
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	[MoonSharpHidden]
	public event Action<Player> _Vacated
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	public Player Networkoccupant
	{
		 get { } //Length: 71
		 set { } //Length: 200
	}

	public Player Occupant
	{
		 get { } //Length: 71
	}

	public Seat() { }

	[CompilerGenerated]
	public void add__Sat(Action<Player> value) { }

	[CompilerGenerated]
	public void add__Vacated(Action<Player> value) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public Player get_Networkoccupant() { }

	public Player get_Occupant() { }

	protected virtual void OnCollisionEnter(Collision collision) { }

	protected virtual void OnTriggerEnter(Collider other) { }

	[CompilerGenerated]
	public void remove__Sat(Action<Player> value) { }

	[CompilerGenerated]
	public void remove__Vacated(Action<Player> value) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Networkoccupant(in Player value) { }

	[MoonSharpHidden]
	public void SetOccupant(Player player) { }

	protected virtual void Start() { }

	protected virtual void Update() { }

	public virtual bool Weaved() { }

}

