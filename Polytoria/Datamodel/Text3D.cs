namespace Polytoria.Datamodel;

[Instantiatable]
public class Text3D : DynamicInstance
{
	private TMP_Text tmp; //Field offset: 0x210
	[SyncVar]
	protected string text; //Field offset: 0x218
	[SyncVar]
	protected Color color; //Field offset: 0x220
	[SyncVar]
	protected float fontSize; //Field offset: 0x230
	[SyncVar]
	protected bool faceCamera; //Field offset: 0x234
	[SyncVar]
	protected HorizontalAlignmentOptions horizontalAlignment; //Field offset: 0x238
	[SyncVar]
	protected VerticalAlignmentOptions verticalAlignment; //Field offset: 0x23C
	[SyncVar(hook = "SyncSetFont")]
	private TextFontPreset font; //Field offset: 0x240
	[SyncVar]
	private Vector3 rotationCache; //Field offset: 0x244
	[SyncVar]
	private Vector3 positionCache; //Field offset: 0x250
	[SerializeField]
	private ContentSizeFitter csf; //Field offset: 0x260
	public Action<TextFontPreset, TextFontPreset> _Mirror_SyncVarHookDelegate_font; //Field offset: 0x268

	[Archivable]
	[CreatorProperty]
	public Color Color
	{
		 get { } //Length: 65
		 set { } //Length: 455
	}

	[Archivable]
	[CreatorProperty]
	public bool FaceCamera
	{
		 get { } //Length: 8
		 set { } //Length: 696
	}

	[Archivable]
	[CreatorProperty]
	public TextFontPreset Font
	{
		 get { } //Length: 7
		 set { } //Length: 288
	}

	[Archivable]
	[CreatorProperty]
	public float FontSize
	{
		 get { } //Length: 34
		 set { } //Length: 546
	}

	[Archivable]
	[CreatorProperty]
	public HorizontalAlignmentOptions HorizontalAlignment
	{
		 get { } //Length: 7
		 set { } //Length: 660
	}

	public Color Networkcolor
	{
		 get { } //Length: 14
		 set { } //Length: 202
	}

	public bool NetworkfaceCamera
	{
		 get { } //Length: 8
		 set { } //Length: 182
	}

	public TextFontPreset Networkfont
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public float NetworkfontSize
	{
		 get { } //Length: 9
		 set { } //Length: 180
	}

	public HorizontalAlignmentOptions NetworkhorizontalAlignment
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	public Vector3 NetworkpositionCache
	{
		 get { } //Length: 25
		 set { } //Length: 218
	}

	public Vector3 NetworkrotationCache
	{
		 get { } //Length: 25
		 set { } //Length: 218
	}

	public string Networktext
	{
		 get { } //Length: 8
		 set { } //Length: 180
	}

	public VerticalAlignmentOptions NetworkverticalAlignment
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	[Archivable]
	[CreatorProperty]
	public string Text
	{
		 get { } //Length: 45
		 set { } //Length: 426
	}

	[Archivable]
	[CreatorProperty]
	public VerticalAlignmentOptions VerticalAlignment
	{
		 get { } //Length: 7
		 set { } //Length: 662
	}

	private static Text3D() { }

	public Text3D() { }

	protected virtual void Awake() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public Color get_Color() { }

	public bool get_FaceCamera() { }

	public TextFontPreset get_Font() { }

	public float get_FontSize() { }

	public HorizontalAlignmentOptions get_HorizontalAlignment() { }

	public Color get_Networkcolor() { }

	public bool get_NetworkfaceCamera() { }

	public TextFontPreset get_Networkfont() { }

	public float get_NetworkfontSize() { }

	public HorizontalAlignmentOptions get_NetworkhorizontalAlignment() { }

	public Vector3 get_NetworkpositionCache() { }

	public Vector3 get_NetworkrotationCache() { }

	public string get_Networktext() { }

	public VerticalAlignmentOptions get_NetworkverticalAlignment() { }

	public string get_Text() { }

	public VerticalAlignmentOptions get_VerticalAlignment() { }

	protected static void InvokeUserCode_RpcSetColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetFontSize__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetHorizontalAlignment__HorizontalAlignmentOptions(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetText__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcSetVerticalAlignment__VerticalAlignmentOptions(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected virtual void OnHide() { }

	protected virtual void OnShow() { }

	[ClientRpc]
	private void RpcSetColor(Color color) { }

	[ClientRpc]
	private void RpcSetFontSize(float fs) { }

	[ClientRpc]
	private void RpcSetHorizontalAlignment(HorizontalAlignmentOptions al) { }

	[ClientRpc]
	private void RpcSetText(string t) { }

	[ClientRpc]
	private void RpcSetVerticalAlignment(VerticalAlignmentOptions al) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Color(Color value) { }

	public void set_FaceCamera(bool value) { }

	public void set_Font(TextFontPreset value) { }

	public void set_FontSize(float value) { }

	public void set_HorizontalAlignment(HorizontalAlignmentOptions value) { }

	public void set_Networkcolor(in Color value) { }

	public void set_NetworkfaceCamera(in bool value) { }

	public void set_Networkfont(in TextFontPreset value) { }

	public void set_NetworkfontSize(in float value) { }

	public void set_NetworkhorizontalAlignment(in HorizontalAlignmentOptions value) { }

	public void set_NetworkpositionCache(in Vector3 value) { }

	public void set_NetworkrotationCache(in Vector3 value) { }

	public void set_Networktext(in string value) { }

	public void set_NetworkverticalAlignment(in VerticalAlignmentOptions value) { }

	public void set_Text(string value) { }

	public void set_VerticalAlignment(VerticalAlignmentOptions value) { }

	protected virtual void Start() { }

	private void SyncSetFont(TextFontPreset oldValue, TextFontPreset newValue) { }

	protected virtual void Update() { }

	protected void UserCode_RpcSetColor__Color(Color color) { }

	protected void UserCode_RpcSetFontSize__Single(float fs) { }

	protected void UserCode_RpcSetHorizontalAlignment__HorizontalAlignmentOptions(HorizontalAlignmentOptions al) { }

	protected void UserCode_RpcSetText__String(string t) { }

	protected void UserCode_RpcSetVerticalAlignment__VerticalAlignmentOptions(VerticalAlignmentOptions al) { }

	public virtual bool Weaved() { }

}

