namespace Polytoria.Datamodel;

[Instantiatable]
public class PointLight : DynamicInstance
{
	private static float intensityMultiplier; //Field offset: 0x0
	private static float rangeMultiplier; //Field offset: 0x4
	[SyncVar]
	private float range; //Field offset: 0x210
	[SyncVar]
	private float brightness; //Field offset: 0x214
	[SyncVar]
	private Color color; //Field offset: 0x218
	[SyncVar]
	private bool shadows; //Field offset: 0x228

	[Archivable]
	[CreatorProperty]
	public float Brightness
	{
		 get { } //Length: 155
		 set { } //Length: 668
	}

	[Archivable]
	[CreatorProperty]
	public Color Color
	{
		 get { } //Length: 105
		 set { } //Length: 625
	}

	public float Networkbrightness
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public Color Networkcolor
	{
		 get { } //Length: 14
		 set { } //Length: 202
	}

	public float Networkrange
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public bool Networkshadows
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	[Archivable]
	[CreatorProperty]
	public float Range
	{
		 get { } //Length: 156
		 set { } //Length: 669
	}

	[Archivable]
	[CreatorProperty]
	public bool Shadows
	{
		 get { } //Length: 83
		 set { } //Length: 599
	}

	private static PointLight() { }

	public PointLight() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public float get_Brightness() { }

	public Color get_Color() { }

	public float get_Networkbrightness() { }

	public Color get_Networkcolor() { }

	public float get_Networkrange() { }

	public bool get_Networkshadows() { }

	public float get_Range() { }

	public bool get_Shadows() { }

	protected static void InvokeUserCode_RpcSetBrightness__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetRange__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetShadowsEnabled__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected virtual void OnHide() { }

	protected virtual void OnShow() { }

	[ClientRpc]
	private void RpcSetBrightness(float brightness) { }

	[ClientRpc]
	private void RpcSetColor(Color color) { }

	[ClientRpc]
	private void RpcSetRange(float range) { }

	[ClientRpc]
	private void RpcSetShadowsEnabled(bool enabled) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Brightness(float value) { }

	public void set_Color(Color value) { }

	public void set_Networkbrightness(in float value) { }

	public void set_Networkcolor(in Color value) { }

	public void set_Networkrange(in float value) { }

	public void set_Networkshadows(in bool value) { }

	public void set_Range(float value) { }

	public void set_Shadows(bool value) { }

	protected virtual void Start() { }

	protected void UserCode_RpcSetBrightness__Single(float brightness) { }

	protected void UserCode_RpcSetColor__Color(Color color) { }

	protected void UserCode_RpcSetRange__Single(float range) { }

	protected void UserCode_RpcSetShadowsEnabled__Boolean(bool enabled) { }

	public virtual bool Weaved() { }

}

