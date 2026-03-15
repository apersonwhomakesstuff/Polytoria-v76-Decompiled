namespace Polytoria.Datamodel;

[Instantiatable]
public class UIImage : UIField
{
	private Image image; //Field offset: 0x198
	[SyncVar(hook = "SyncSetColor")]
	private Color color; //Field offset: 0x1A0
	[SyncVar(hook = "SetImage")]
	private string imageID; //Field offset: 0x1B0
	[SyncVar(hook = "SetImageType")]
	private ImageType imageType; //Field offset: 0x1B8
	[SyncVar(hook = "SyncSetClickable")]
	private bool clickable; //Field offset: 0x1BC
	private bool loading; //Field offset: 0x1BD
	private Texture2D texture; //Field offset: 0x1C0
	private ImageCacheKey lastCacheKey; //Field offset: 0x1C8
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_color; //Field offset: 0x1E0
	public Action<String, String> _Mirror_SyncVarHookDelegate_imageID; //Field offset: 0x1E8
	public Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType; //Field offset: 0x1F0
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_clickable; //Field offset: 0x1F8

	[Archivable]
	[CreatorProperty]
	public bool Clickable
	{
		 get { } //Length: 8
		 set { } //Length: 147
	}

	[Archivable]
	[CreatorProperty]
	public Color Color
	{
		 get { } //Length: 14
		 set { } //Length: 166
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
		 set { } //Length: 110
	}

	public bool Loading
	{
		 get { } //Length: 8
	}

	public bool Networkclickable
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
		 set { } //Length: 101
	}

	public UIImage() { }

	[CompilerGenerated]
	private void <GetImage>b__29_0(ImageCacheKey key, ImageCacheEntry entry) { }

	protected virtual void Awake() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public bool get_Clickable() { }

	public Color get_Color() { }

	public string get_ImageID() { }

	public ImageType get_ImageType() { }

	public bool get_Loading() { }

	public bool get_Networkclickable() { }

	public Color get_Networkcolor() { }

	public string get_NetworkimageID() { }

	public ImageType get_NetworkimageType() { }

	private void GetImage() { }

	private void LoadFallback() { }

	protected virtual void OnHide() { }

	protected virtual void OnShow() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Clickable(bool value) { }

	public void set_Color(Color value) { }

	public void set_ImageID(string value) { }

	public void set_ImageType(ImageType value) { }

	public void set_Networkclickable(in bool value) { }

	public void set_Networkcolor(in Color value) { }

	public void set_NetworkimageID(in string value) { }

	public void set_NetworkimageType(in ImageType value) { }

	private void SetImage(string oldValue, string newValue) { }

	private void SetImageType(ImageType oldValue, ImageType newValue) { }

	protected virtual void Start() { }

	private void SyncSetClickable(bool oldValue, bool newValue) { }

	private void SyncSetColor(Color oldValue, Color newValue) { }

	public virtual bool Weaved() { }

}

