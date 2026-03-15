namespace Polytoria.Datamodel;

[RequireComponent(typeof(Light))]
public class SunLight : DynamicInstance
{
	private Light light; //Field offset: 0x210
	[SyncVar(hook = "OnBrightnessChanged")]
	private float brightness; //Field offset: 0x218
	[SyncVar(hook = "OnColorChanged")]
	private Color color; //Field offset: 0x21C
	[SyncVar(hook = "OnShadowsChanged")]
	private bool shadows; //Field offset: 0x22C
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_brightness; //Field offset: 0x230
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_color; //Field offset: 0x238
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_shadows; //Field offset: 0x240

	[Archivable]
	[CreatorProperty]
	public float Brightness
	{
		 get { } //Length: 9
		 set { } //Length: 131
	}

	[Archivable]
	[CreatorProperty]
	public Color Color
	{
		 get { } //Length: 14
		 set { } //Length: 151
	}

	public float Networkbrightness
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public Color Networkcolor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public bool Networkshadows
	{
		 get { } //Length: 8
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	public bool Shadows
	{
		 get { } //Length: 8
		 set { } //Length: 132
	}

	public SunLight() { }

	protected virtual void Awake() { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public float get_Brightness() { }

	public Color get_Color() { }

	public float get_Networkbrightness() { }

	public Color get_Networkcolor() { }

	public bool get_Networkshadows() { }

	public bool get_Shadows() { }

	private void OnBrightnessChanged(float oldValue, float newValue) { }

	private void OnColorChanged(Color oldValue, Color newValue) { }

	private void OnShadowsChanged(bool oldValue, bool newValue) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_Brightness(float value) { }

	public void set_Color(Color value) { }

	public void set_Networkbrightness(in float value) { }

	public void set_Networkcolor(in Color value) { }

	public void set_Networkshadows(in bool value) { }

	public void set_Shadows(bool value) { }

	public virtual bool Weaved() { }

}

