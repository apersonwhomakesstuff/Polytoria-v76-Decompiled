namespace Polytoria.Datamodel;

[Instantiatable]
public class UIView : UIField
{
	private Image border; //Field offset: 0x198
	private RectTransform borderRect; //Field offset: 0x1A0
	private Image fill; //Field offset: 0x1A8
	[SyncVar(hook = "SyncSetColor")]
	private Color color; //Field offset: 0x1B0
	[SyncVar(hook = "SyncSetBorderWidth")]
	private float borderWidth; //Field offset: 0x1C0
	[SyncVar(hook = "SyncSetBorderColor")]
	private Color borderColor; //Field offset: 0x1C4
	[SyncVar(hook = "SyncSetCornerRadius")]
	private float cornerRadius; //Field offset: 0x1D4
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_color; //Field offset: 0x1D8
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_borderWidth; //Field offset: 0x1E0
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_borderColor; //Field offset: 0x1E8
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_cornerRadius; //Field offset: 0x1F0

	[Archivable]
	[CreatorProperty]
	public Color BorderColor
	{
		 get { } //Length: 14
		 set { } //Length: 162
	}

	[Archivable]
	[CreatorProperty]
	public float BorderWidth
	{
		 get { } //Length: 9
		 set { } //Length: 142
	}

	[Archivable]
	[CreatorProperty]
	public Color Color
	{
		 get { } //Length: 14
		 set { } //Length: 162
	}

	[Archivable]
	[CreatorProperty]
	public float CornerRadius
	{
		 get { } //Length: 9
		 set { } //Length: 176
	}

	public Color NetworkborderColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public float NetworkborderWidth
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public Color Networkcolor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public float NetworkcornerRadius
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public UIView() { }

	protected virtual void Awake() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public Color get_BorderColor() { }

	public float get_BorderWidth() { }

	public Color get_Color() { }

	public float get_CornerRadius() { }

	public Color get_NetworkborderColor() { }

	public float get_NetworkborderWidth() { }

	public Color get_Networkcolor() { }

	public float get_NetworkcornerRadius() { }

	protected virtual void OnHide() { }

	protected virtual void OnShow() { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_BorderColor(Color value) { }

	public void set_BorderWidth(float value) { }

	public void set_Color(Color value) { }

	public void set_CornerRadius(float value) { }

	public void set_NetworkborderColor(in Color value) { }

	public void set_NetworkborderWidth(in float value) { }

	public void set_Networkcolor(in Color value) { }

	public void set_NetworkcornerRadius(in float value) { }

	protected virtual void Start() { }

	private void SyncSetBorderColor(Color oldValue, Color newValue) { }

	private void SyncSetBorderWidth(float oldValue, float newValue) { }

	private void SyncSetColor(Color oldValue, Color newValue) { }

	private void SyncSetCornerRadius(float oldValue, float newValue) { }

	private void UpdateBorder() { }

	public virtual bool Weaved() { }

}

