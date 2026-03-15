namespace Polytoria.Datamodel;

[DefaultMember("Item")]
public class Instance : NetworkBehaviour
{
	protected Transform _transform; //Field offset: 0x68
	[SyncVar]
	protected string _name; //Field offset: 0x70
	protected string className; //Field offset: 0x78
	protected bool canReparent; //Field offset: 0x80
	protected bool hidesMembers; //Field offset: 0x81
	protected bool clientSpawned; //Field offset: 0x82
	private DynValue shared; //Field offset: 0x88
	public LuaEvent ChildRemoved; //Field offset: 0x90
	public LuaEvent ChildAdded; //Field offset: 0x98
	public LuaEvent Touched; //Field offset: 0xA0
	public LuaEvent TouchEnded; //Field offset: 0xA8
	public LuaEvent MouseHover; //Field offset: 0xB0
	public LuaEvent MouseHoverEnded; //Field offset: 0xB8
	public LuaEvent Clicked; //Field offset: 0xC0
	public LuaEvent MouseEnter; //Field offset: 0xC8
	public LuaEvent MouseExit; //Field offset: 0xD0
	[CompilerGenerated]
	private Action<Instance> _DescendantAdded; //Field offset: 0xD8
	[CompilerGenerated]
	private Action _ParentChanged; //Field offset: 0xE0
	[CompilerGenerated]
	private Action<Instance> _Touched; //Field offset: 0xE8
	[MoonSharpHidden]
	public bool isHidden; //Field offset: 0xF0
	private bool isMouseOver; //Field offset: 0xF1

	[MoonSharpHidden]
	public event Action<Instance> _DescendantAdded
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	[MoonSharpHidden]
	public event Action _ParentChanged
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	[MoonSharpHidden]
	public event Action<Instance> _Touched
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	public bool CanReparent
	{
		 get { } //Length: 8
	}

	[CreatorProperty]
	public string ClassName
	{
		 get { } //Length: 5
	}

	public bool ClientSpawned
	{
		 get { } //Length: 8
	}

	[MoonSharpHidden]
	public int DescendantLevel
	{
		 get { } //Length: 263
	}

	public string FullName
	{
		 get { } //Length: 371
	}

	public Instance Item
	{
		 get { } //Length: 284
	}

	public Instance Item
	{
		 get { } //Length: 56
	}

	[Archivable]
	[CreatorProperty]
	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 411
	}

	public string Network_name
	{
		 get { } //Length: 5
		 set { } //Length: 174
	}

	public Instance Parent
	{
		 get { } //Length: 281
		 set { } //Length: 8
	}

	public DynValue Shared
	{
		 get { } //Length: 8
	}

	private static Instance() { }

	public Instance() { }

	[CompilerGenerated]
	public void add__DescendantAdded(Action<Instance> value) { }

	[CompilerGenerated]
	public void add__ParentChanged(Action value) { }

	[CompilerGenerated]
	public void add__Touched(Action<Instance> value) { }

	protected override void Awake() { }

	public Instance Clone() { }

	[Command(requiresAuthority = False)]
	private void CmdClicked(NetworkConnectionToClient sender = null) { }

	protected override void CopyProperties(Instance clone) { }

	public void Delete(float time = 0) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public void Destroy(float time = 0) { }

	public Instance FindChild(string name) { }

	public Instance FindChildByClass(string className) { }

	public T FindChildOfType() { }

	public bool get_CanReparent() { }

	public string get_ClassName() { }

	public bool get_ClientSpawned() { }

	public int get_DescendantLevel() { }

	public string get_FullName() { }

	public Instance get_Item(int index) { }

	public Instance get_Item(string name) { }

	public string get_Name() { }

	public string get_Network_name() { }

	public Instance get_Parent() { }

	public DynValue get_Shared() { }

	public Bounds GetBounds(BoundsCalculationMethod calculationMethod = 0) { }

	public Instance[] GetChildren() { }

	public Instance[] GetChildrenOfClass(string className) { }

	public T[] GetChildrenOfType() { }

	private int GetDescendantLevel() { }

	public Instance GetParent() { }

	protected static void InvokeUserCode_CmdClicked__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RequestParent__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetName__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetParent__Transform(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	public bool IsA(string className) { }

	public bool IsDescendantOf(Instance other) { }

	public bool IsDescendantOfType() { }

	public static Instance New(string className, Instance parent = null) { }

	protected override void OnCollisionEnter(Collision collision) { }

	protected override void OnCollisionExit(Collision collision) { }

	protected override void OnDestroy() { }

	private void OnGameLoaded() { }

	protected override void OnHide() { }

	private void OnMouseDown() { }

	private void OnMouseEnter() { }

	private void OnMouseExit() { }

	protected override void OnNetworkStart() { }

	protected override void OnShow() { }

	public virtual void OnStartClient() { }

	public virtual void OnStartServer() { }

	protected override void OnTriggerEnter(Collider collider) { }

	protected override void OnTriggerExit(Collider collider) { }

	protected override void PostClone() { }

	[CompilerGenerated]
	public void remove__DescendantAdded(Action<Instance> value) { }

	[CompilerGenerated]
	public void remove__ParentChanged(Action value) { }

	[CompilerGenerated]
	public void remove__Touched(Action<Instance> value) { }

	[Command(requiresAuthority = False)]
	private void RequestParent(NetworkConnectionToClient sender = null) { }

	[ClientRpc]
	private void RpcSetName(string n) { }

	[ClientRpc]
	private void RpcSetParent(Transform par) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Name(string value) { }

	public void set_Network_name(in string value) { }

	public void set_Parent(Instance value) { }

	public void SetParent(Instance par) { }

	[TargetRpc]
	private void SetParentTargetRpc(NetworkConnection target, Transform par, int index) { }

	protected override void Start() { }

	protected void UserCode_CmdClicked__NetworkConnectionToClient(NetworkConnectionToClient sender) { }

	protected void UserCode_RequestParent__NetworkConnectionToClient(NetworkConnectionToClient sender) { }

	protected void UserCode_RpcSetName__String(string n) { }

	protected void UserCode_RpcSetParent__Transform(Transform par) { }

	protected void UserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32(NetworkConnection target, Transform par, int index) { }

	public virtual bool Weaved() { }

}

