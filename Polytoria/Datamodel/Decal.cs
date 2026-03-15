namespace Polytoria.Datamodel;

[Instantiatable]
[RequireComponent(typeof(MeshRenderer))]
public class Decal : DynamicInstance
{
	[SyncVar(hook = "SetImage")]
	private string imageID; //Field offset: 0x210
	[SyncVar(hook = "SetImageType")]
	private ImageType imageType; //Field offset: 0x218
	[SyncVar(hook = "SetTextureScale")]
	private Vector2 textureScale; //Field offset: 0x21C
	[SyncVar(hook = "SetTextureOffset")]
	private Vector2 textureOffset; //Field offset: 0x224
	[SyncVar(hook = "SetColor")]
	private Color color; //Field offset: 0x22C
	[SyncVar(hook = "SetCastShadows")]
	private bool castShadows; //Field offset: 0x23C
	private ImageCacheKey lastCacheKey; //Field offset: 0x240
	private BoxCollider col; //Field offset: 0x258
	private MeshRenderer meshRenderer; //Field offset: 0x260
	private ImageCacheEntry currentEntry; //Field offset: 0x268
	private Material transparentMaterial; //Field offset: 0x270
	private Material cutoutMaterial; //Field offset: 0x278
	public Action<String, String> _Mirror_SyncVarHookDelegate_imageID; //Field offset: 0x280
	public Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType; //Field offset: 0x288
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_textureScale; //Field offset: 0x290
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_textureOffset; //Field offset: 0x298
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_color; //Field offset: 0x2A0
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_castShadows; //Field offset: 0x2A8

	[Archivable]
	[CreatorProperty]
	public bool CastShadows
	{
		 get { } //Length: 8
		 set { } //Length: 130
	}

	[Archivable]
	[CreatorProperty]
	public Color Color
	{
		 get { } //Length: 14
		 set { } //Length: 517
	}

	[Archivable]
	[CreatorProperty]
	public string ImageID
	{
		 get { } //Length: 8
		 set { } //Length: 112
	}

	[Archivable]
	[CreatorProperty]
	public ImageType ImageType
	{
		 get { } //Length: 7
		 set { } //Length: 325
	}

	public bool NetworkcastShadows
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	public Color Networkcolor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public string NetworkimageID
	{
		 get { } //Length: 8
		 set { } //Length: 103
	}

	public ImageType NetworkimageType
	{
		 get { } //Length: 7
		 set { } //Length: 316
	}

	public Vector2 NetworktextureOffset
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	public Vector2 NetworktextureScale
	{
		 get { } //Length: 25
		 set { } //Length: 108
	}

	[Archivable]
	[CreatorProperty]
	public Vector2 TextureOffset
	{
		 get { } //Length: 25
		 set { } //Length: 152
	}

	[Archivable]
	[CreatorProperty]
	public Vector2 TextureScale
	{
		 get { } //Length: 25
		 set { } //Length: 152
	}

	public Decal() { }

	[CompilerGenerated]
	private void <GetImage>b__41_0(ImageCacheKey key, ImageCacheEntry entry) { }

	protected virtual void Awake() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public bool get_CastShadows() { }

	public Color get_Color() { }

	public string get_ImageID() { }

	public ImageType get_ImageType() { }

	public bool get_NetworkcastShadows() { }

	public Color get_Networkcolor() { }

	public string get_NetworkimageID() { }

	public ImageType get_NetworkimageType() { }

	public Vector2 get_NetworktextureOffset() { }

	public Vector2 get_NetworktextureScale() { }

	public Vector2 get_TextureOffset() { }

	public Vector2 get_TextureScale() { }

	private void GetImage() { }

	protected virtual void OnHide() { }

	protected virtual void OnShow() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_CastShadows(bool value) { }

	public void set_Color(Color value) { }

	public void set_ImageID(string value) { }

	public void set_ImageType(ImageType value) { }

	public void set_NetworkcastShadows(in bool value) { }

	public void set_Networkcolor(in Color value) { }

	public void set_NetworkimageID(in string value) { }

	public void set_NetworkimageType(in ImageType value) { }

	public void set_NetworktextureOffset(in Vector2 value) { }

	public void set_NetworktextureScale(in Vector2 value) { }

	public void set_TextureOffset(Vector2 value) { }

	public void set_TextureScale(Vector2 value) { }

	private void SetCastShadows(bool oldShadows, bool newShadows) { }

	private void SetColor(Color oldColor, Color newColor) { }

	private void SetImage(string oldId, string newId) { }

	private void SetImageType(ImageType oldType, ImageType newType) { }

	private void SetTextureOffset(Vector2 oldOffset, Vector2 newOffset) { }

	private void SetTextureScale(Vector2 oldScale, Vector2 newScale) { }

	protected virtual void Start() { }

	protected virtual void Update() { }

	public virtual bool Weaved() { }

}

