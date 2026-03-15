namespace Polytoria.Datamodel;

[Instantiatable]
[RequireComponent(typeof(ParentConstraint))]
public class Tool : DynamicInstance
{
	private Renderer _renderer; //Field offset: 0x210
	private BoxCollider col; //Field offset: 0x218
	private Rigidbody rb; //Field offset: 0x220
	private ParentConstraint parentConstraint; //Field offset: 0x228
	public LuaEvent Activated; //Field offset: 0x230
	public LuaEvent Deactivated; //Field offset: 0x238
	public LuaEvent Equipped; //Field offset: 0x240
	public LuaEvent Unequipped; //Field offset: 0x248
	private float pickupCooldown; //Field offset: 0x250
	[SyncVar]
	private bool droppable; //Field offset: 0x254

	protected virtual bool DoTransformSync
	{
		 get { } //Length: 74
	}

	[Archivable]
	[CreatorProperty]
	public bool Droppable
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public bool Networkdroppable
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	private static Tool() { }

	public Tool() { }

	protected virtual void Awake() { }

	[Command(requiresAuthority = False)]
	private void CmdActivate() { }

	[Command(requiresAuthority = False)]
	private void CmdDeactivate() { }

	[Command(requiresAuthority = False)]
	private void CmdEquip() { }

	[Command(requiresAuthority = False)]
	private void CmdUnequip() { }

	private void CollectTool(IToolHolder holder) { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	private void DoActivate() { }

	private void DoDeactivate() { }

	private void DoEquip() { }

	private void DoLinkTool(Instance par) { }

	private void DoUnequip() { }

	private void FixChildTransforms(DynamicInstance i) { }

	protected virtual bool get_DoTransformSync() { }

	public bool get_Droppable() { }

	public bool get_Networkdroppable() { }

	public void InvokeActivate() { }

	public void InvokeDeactivate() { }

	public void InvokeEquip() { }

	public void InvokeUnequip() { }

	protected static void InvokeUserCode_CmdActivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_CmdDeactivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_CmdEquip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_CmdUnequip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcActivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcDeactivate(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcEquip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcLinkTool__Instance(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcUnequip(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcUpdateChildTransform__DynamicInstance__Vector3__Quaternion__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	private void OnDescendantAdded(Instance obj) { }

	protected virtual void OnHide() { }

	private void OnParentChange() { }

	protected virtual void OnShow() { }

	private void OnTouched(Instance obj) { }

	public void Play(string anim) { }

	private void RecalculateBounds() { }

	[ClientRpc]
	private void RpcActivate() { }

	[ClientRpc]
	private void RpcDeactivate() { }

	[ClientRpc]
	private void RpcEquip() { }

	[ClientRpc]
	private void RpcLinkTool(Instance par) { }

	[ClientRpc]
	private void RpcUnequip() { }

	[ClientRpc]
	private void RpcUpdateChildTransform(DynamicInstance i, Vector3 pos, Quaternion rot, Vector3 size) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Droppable(bool value) { }

	public void set_Networkdroppable(in bool value) { }

	protected virtual void Start() { }

	protected virtual void Update() { }

	protected void UserCode_CmdActivate() { }

	protected void UserCode_CmdDeactivate() { }

	protected void UserCode_CmdEquip() { }

	protected void UserCode_CmdUnequip() { }

	protected void UserCode_RpcActivate() { }

	protected void UserCode_RpcDeactivate() { }

	protected void UserCode_RpcEquip() { }

	protected void UserCode_RpcLinkTool__Instance(Instance par) { }

	protected void UserCode_RpcUnequip() { }

	protected void UserCode_RpcUpdateChildTransform__DynamicInstance__Vector3__Quaternion__Vector3(DynamicInstance i, Vector3 pos, Quaternion rot, Vector3 size) { }

	public virtual bool Weaved() { }

}

