namespace Polytoria.Datamodel;

[Instantiatable]
public class MeshPart : Part
{
	[SyncVar(hook = "AssetIDChanged")]
	protected int assetID; //Field offset: 0x300
	[SyncVar(hook = "PlayAnimationOnStartChanged")]
	private bool playAnimationOnStart; //Field offset: 0x304
	[SyncVar(hook = "CollisionTypeChanged")]
	private CollisionType collisionType; //Field offset: 0x308
	private Animation anim; //Field offset: 0x310
	private Dictionary<String, List`1<Animation>> animationsByName; //Field offset: 0x318
	public Bounds defaultBounds; //Field offset: 0x320
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_assetID; //Field offset: 0x338
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_playAnimationOnStart; //Field offset: 0x340
	public Action<CollisionType, CollisionType> _Mirror_SyncVarHookDelegate_collisionType; //Field offset: 0x348

	[Archivable]
	[CreatorProperty]
	public int AssetID
	{
		 get { } //Length: 7
		 set { } //Length: 689
	}

	[Archivable]
	[CreatorProperty]
	public bool CanCollide
	{
		 get { } //Length: 8
		 set { } //Length: 162
	}

	[Archivable]
	[CreatorProperty]
	public CollisionType CollisionType
	{
		 get { } //Length: 7
		 set { } //Length: 110
	}

	public string CurrentAnimation
	{
		 get { } //Length: 985
	}

	public bool IsAnimationPlaying
	{
		 get { } //Length: 774
	}

	public PartMaterial Material
	{
		 get { } //Length: 3
	}

	public int NetworkassetID
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public CollisionType NetworkcollisionType
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public bool NetworkplayAnimationOnStart
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	public bool PlayAnimationOnStart
	{
		 get { } //Length: 8
		 set { } //Length: 368
	}

	public PartShape Shape
	{
		 get { } //Length: 3
	}

	private static MeshPart() { }

	public MeshPart() { }

	[CompilerGenerated]
	private void <LoadMesh>b__28_0() { }

	private void AssetIDChanged(int oldValue, int newValue) { }

	protected virtual void Awake() { }

	private void CollisionTypeChanged(CollisionType oldValue, CollisionType newValue) { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public int get_AssetID() { }

	public bool get_CanCollide() { }

	public CollisionType get_CollisionType() { }

	public string get_CurrentAnimation() { }

	public bool get_IsAnimationPlaying() { }

	public PartMaterial get_Material() { }

	public int get_NetworkassetID() { }

	public CollisionType get_NetworkcollisionType() { }

	public bool get_NetworkplayAnimationOnStart() { }

	public bool get_PlayAnimationOnStart() { }

	public PartShape get_Shape() { }

	public AnimationInfo[] GetAnimationInfo() { }

	public String[] GetAnimations() { }

	public String[] GetAnimationSources(string animationName) { }

	private string GetRelativePath(Transform root, Transform target) { }

	public void Hide() { }

	protected static void InvokeUserCode_RpcSetAssetID__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	private void LoadMesh() { }

	protected virtual void OnHide() { }

	protected virtual void OnShow() { }

	public void PlayAnimation(string name, string objectPath = "", float speed = 1, bool loop = true) { }

	private void PlayAnimationOnStartChanged(bool oldValue, bool newValue) { }

	private void RefreshAnimationComponents() { }

	[ClientRpc]
	private void RpcSetAssetID(int id) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_AssetID(int value) { }

	public void set_CanCollide(bool value) { }

	public void set_CollisionType(CollisionType value) { }

	public void set_NetworkassetID(in int value) { }

	public void set_NetworkcollisionType(in CollisionType value) { }

	public void set_NetworkplayAnimationOnStart(in bool value) { }

	public void set_PlayAnimationOnStart(bool value) { }

	private void StopAllAnimations() { }

	public void StopAnimation(string name = null) { }

	public void UpdateColliders() { }

	protected void UserCode_RpcSetAssetID__Int32(int id) { }

	public virtual bool Weaved() { }

}

