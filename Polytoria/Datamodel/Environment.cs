namespace Polytoria.Datamodel;

public class Environment : Instance
{
	[CompilerGenerated]
	private sealed class <ExplosionForce>d__36 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Collider col; //Field offset: 0x20
		public float force; //Field offset: 0x28
		public Vector3 position; //Field offset: 0x2C
		public float radius; //Field offset: 0x38

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ExplosionForce>d__36(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SyncVar]
	private SkyboxPreset skybox; //Field offset: 0xF8
	[SyncVar]
	private Vector3 gravity; //Field offset: 0xFC
	[SyncVar]
	private bool fogEnabled; //Field offset: 0x108
	[SyncVar]
	private float fogStartDistance; //Field offset: 0x10C
	[SyncVar]
	private float fogEndDistance; //Field offset: 0x110
	[SyncVar]
	private Color fogColor; //Field offset: 0x114
	[SyncVar]
	private float partDestroyHeight; //Field offset: 0x124
	[SyncVar]
	private bool autoGenerateNavMesh; //Field offset: 0x128
	private NavMeshSurface surface; //Field offset: 0x130
	private GameObject explosionPrefab; //Field offset: 0x138

	[Archivable]
	[CreatorProperty]
	public bool AutoGenerateNavMesh
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	[Archivable]
	[CreatorProperty]
	public Color FogColor
	{
		 get { } //Length: 14
		 set { } //Length: 569
	}

	[Archivable]
	[CreatorProperty]
	public bool FogEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 599
	}

	[Archivable]
	[CreatorProperty]
	public float FogEndDistance
	{
		 get { } //Length: 9
		 set { } //Length: 529
	}

	[Archivable]
	[CreatorProperty]
	public float FogStartDistance
	{
		 get { } //Length: 9
		 set { } //Length: 529
	}

	[Archivable]
	[CreatorProperty]
	public Vector3 Gravity
	{
		 get { } //Length: 25
		 set { } //Length: 525
	}

	public bool NetworkautoGenerateNavMesh
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public Color NetworkfogColor
	{
		 get { } //Length: 14
		 set { } //Length: 202
	}

	public bool NetworkfogEnabled
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public float NetworkfogEndDistance
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public float NetworkfogStartDistance
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public Vector3 Networkgravity
	{
		 get { } //Length: 25
		 set { } //Length: 218
	}

	public float NetworkpartDestroyHeight
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public SkyboxPreset Networkskybox
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	[Archivable]
	[CreatorProperty]
	public float PartDestroyHeight
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	public SkyboxPreset Skybox
	{
		 get { } //Length: 7
		 set { } //Length: 790
	}

	private static Environment() { }

	public Environment() { }

	private void AddPlrExplosionForce(Player player, Vector3 position, float radius, float force) { }

	[TargetRpc]
	private void ApplyForceTargetRpc(NetworkConnection target, Vector3 force) { }

	protected virtual void Awake() { }

	public void CreateExplosion(Vector3 position, float radius = 10, float force = 5000, bool affectKinematic = true, DynValue callback = null, float damage = 100000) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[IteratorStateMachine(typeof(<ExplosionForce>d__36))]
	private IEnumerator ExplosionForce(Collider col, Vector3 position, float radius, float force) { }

	public bool get_AutoGenerateNavMesh() { }

	public Color get_FogColor() { }

	public bool get_FogEnabled() { }

	public float get_FogEndDistance() { }

	public float get_FogStartDistance() { }

	public Vector3 get_Gravity() { }

	public bool get_NetworkautoGenerateNavMesh() { }

	public Color get_NetworkfogColor() { }

	public bool get_NetworkfogEnabled() { }

	public float get_NetworkfogEndDistance() { }

	public float get_NetworkfogStartDistance() { }

	public Vector3 get_Networkgravity() { }

	public float get_NetworkpartDestroyHeight() { }

	public SkyboxPreset get_Networkskybox() { }

	public float get_PartDestroyHeight() { }

	public SkyboxPreset get_Skybox() { }

	public Vector3 GetPointOnNavMesh(Vector3 position, float maxDistance = 100) { }

	protected static void InvokeUserCode_ApplyForceTargetRpc__NetworkConnection__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcExplode__Vector3__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetFogColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetFogEnabled__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetFogEndDistance__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetFogStartDistance__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetGravity__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetSkybox__SkyboxPreset(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	public Instance[] OverlapBox(Vector3 center, Vector3 size, Vector3 rotation, List<Instance> ignoreList = null) { }

	public Instance[] OverlapSphere(Vector3 position, float radius, List<Instance> ignoreList = null) { }

	public Nullable<RayResult> Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, List<Instance> ignoreList = null) { }

	public RayResult[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance = ∞, List<Instance> ignoreList = null) { }

	public void RebuildNavMesh(Instance root = null) { }

	[ClientRpc]
	private void RpcExplode(Vector3 position, float radius) { }

	[ClientRpc]
	private void RpcSetFogColor(Color c) { }

	[ClientRpc]
	private void RpcSetFogEnabled(bool enabled) { }

	[ClientRpc]
	private void RpcSetFogEndDistance(float dist) { }

	[ClientRpc]
	private void RpcSetFogStartDistance(float dist) { }

	[ClientRpc]
	private void RpcSetGravity(Vector3 g) { }

	[ClientRpc]
	private void RpcSetSkybox(SkyboxPreset sky) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_AutoGenerateNavMesh(bool value) { }

	public void set_FogColor(Color value) { }

	public void set_FogEnabled(bool value) { }

	public void set_FogEndDistance(float value) { }

	public void set_FogStartDistance(float value) { }

	public void set_Gravity(Vector3 value) { }

	public void set_NetworkautoGenerateNavMesh(in bool value) { }

	public void set_NetworkfogColor(in Color value) { }

	public void set_NetworkfogEnabled(in bool value) { }

	public void set_NetworkfogEndDistance(in float value) { }

	public void set_NetworkfogStartDistance(in float value) { }

	public void set_Networkgravity(in Vector3 value) { }

	public void set_NetworkpartDestroyHeight(in float value) { }

	public void set_Networkskybox(in SkyboxPreset value) { }

	public void set_PartDestroyHeight(float value) { }

	public void set_Skybox(SkyboxPreset value) { }

	protected virtual void Start() { }

	protected void UserCode_ApplyForceTargetRpc__NetworkConnection__Vector3(NetworkConnection target, Vector3 force) { }

	protected void UserCode_RpcExplode__Vector3__Single(Vector3 position, float radius) { }

	protected void UserCode_RpcSetFogColor__Color(Color c) { }

	protected void UserCode_RpcSetFogEnabled__Boolean(bool enabled) { }

	protected void UserCode_RpcSetFogEndDistance__Single(float dist) { }

	protected void UserCode_RpcSetFogStartDistance__Single(float dist) { }

	protected void UserCode_RpcSetGravity__Vector3(Vector3 g) { }

	protected void UserCode_RpcSetSkybox__SkyboxPreset(SkyboxPreset sky) { }

	public virtual bool Weaved() { }

}

