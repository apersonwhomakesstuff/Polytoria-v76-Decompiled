namespace Polytoria.Datamodel;

public class Lighting : Instance
{
	[SyncVar]
	private Color ambientColor; //Field offset: 0xF8
	[SyncVar]
	private AmbientSource ambientSource; //Field offset: 0x108
	private SunLight sun; //Field offset: 0x110

	[Archivable]
	[CreatorProperty]
	public Color AmbientColor
	{
		 get { } //Length: 36
		 set { } //Length: 569
	}

	[Archivable]
	[CreatorProperty]
	public AmbientSource AmbientSource
	{
		 get { } //Length: 7
		 set { } //Length: 547
	}

	public Color NetworkambientColor
	{
		 get { } //Length: 14
		 set { } //Length: 202
	}

	public AmbientSource NetworkambientSource
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	public bool Shadows
	{
		 get { } //Length: 33
		 set { } //Length: 33
	}

	public float SunBrightness
	{
		 get { } //Length: 34
		 set { } //Length: 33
	}

	public Color SunColor
	{
		 get { } //Length: 39
		 set { } //Length: 47
	}

	private static Lighting() { }

	public Lighting() { }

	protected virtual void Awake() { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public Color get_AmbientColor() { }

	public AmbientSource get_AmbientSource() { }

	public Color get_NetworkambientColor() { }

	public AmbientSource get_NetworkambientSource() { }

	public bool get_Shadows() { }

	public float get_SunBrightness() { }

	public Color get_SunColor() { }

	protected static void InvokeUserCode_RpcSetAmbientColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetAmbientSource__AmbientSource(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[ClientRpc]
	private void RpcSetAmbientColor(Color c) { }

	[ClientRpc]
	private void RpcSetAmbientSource(AmbientSource source) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_AmbientColor(Color value) { }

	public void set_AmbientSource(AmbientSource value) { }

	public void set_NetworkambientColor(in Color value) { }

	public void set_NetworkambientSource(in AmbientSource value) { }

	public void set_Shadows(bool value) { }

	public void set_SunBrightness(float value) { }

	public void set_SunColor(Color value) { }

	protected virtual void Start() { }

	protected void UserCode_RpcSetAmbientColor__Color(Color c) { }

	protected void UserCode_RpcSetAmbientSource__AmbientSource(AmbientSource source) { }

	public virtual bool Weaved() { }

}

