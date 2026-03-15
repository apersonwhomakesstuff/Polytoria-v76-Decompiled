namespace Polytoria.Datamodel;

[Instantiatable]
public class ProceduralSky : SkyBase
{
	[SyncVar(hook = "OnSunSizeChanged")]
	private float sunSize; //Field offset: 0x100
	[SyncVar(hook = "OnSunSizeConvergenceChanged")]
	private float sunSizeConvergence; //Field offset: 0x104
	[SyncVar(hook = "OnAtmosphereThicknessChanged")]
	private float atmosphereThickness; //Field offset: 0x108
	[SyncVar(hook = "OnSkyTintChanged")]
	private Color skyTint; //Field offset: 0x10C
	[SyncVar(hook = "OnGroundColorChanged")]
	private Color groundColor; //Field offset: 0x11C
	[SyncVar(hook = "OnExposureChanged")]
	private float exposure; //Field offset: 0x12C
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_sunSize; //Field offset: 0x130
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_sunSizeConvergence; //Field offset: 0x138
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_atmosphereThickness; //Field offset: 0x140
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_skyTint; //Field offset: 0x148
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_groundColor; //Field offset: 0x150
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_exposure; //Field offset: 0x158

	[Archivable]
	[CreatorProperty]
	public float AtmosphereThickness
	{
		 get { } //Length: 9
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	public float Exposure
	{
		 get { } //Length: 9
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	public Color GroundColor
	{
		 get { } //Length: 14
		 set { } //Length: 186
	}

	public float NetworkatmosphereThickness
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public float Networkexposure
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public Color NetworkgroundColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public Color NetworkskyTint
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public float NetworksunSize
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public float NetworksunSizeConvergence
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	public Color SkyTint
	{
		 get { } //Length: 14
		 set { } //Length: 186
	}

	[Archivable]
	[CreatorProperty]
	public float SunSize
	{
		 get { } //Length: 9
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	public float SunSizeConvergence
	{
		 get { } //Length: 9
		 set { } //Length: 166
	}

	public ProceduralSky() { }

	protected virtual void Apply() { }

	protected virtual void Awake() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public float get_AtmosphereThickness() { }

	public float get_Exposure() { }

	public Color get_GroundColor() { }

	public float get_NetworkatmosphereThickness() { }

	public float get_Networkexposure() { }

	public Color get_NetworkgroundColor() { }

	public Color get_NetworkskyTint() { }

	public float get_NetworksunSize() { }

	public float get_NetworksunSizeConvergence() { }

	public Color get_SkyTint() { }

	public float get_SunSize() { }

	public float get_SunSizeConvergence() { }

	private void OnAtmosphereThicknessChanged(float oldValue, float newValue) { }

	private void OnExposureChanged(float oldValue, float newValue) { }

	private void OnGroundColorChanged(Color oldValue, Color newValue) { }

	private void OnSkyTintChanged(Color oldValue, Color newValue) { }

	private void OnSunSizeChanged(float oldValue, float newValue) { }

	private void OnSunSizeConvergenceChanged(float oldValue, float newValue) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_AtmosphereThickness(float value) { }

	public void set_Exposure(float value) { }

	public void set_GroundColor(Color value) { }

	public void set_NetworkatmosphereThickness(in float value) { }

	public void set_Networkexposure(in float value) { }

	public void set_NetworkgroundColor(in Color value) { }

	public void set_NetworkskyTint(in Color value) { }

	public void set_NetworksunSize(in float value) { }

	public void set_NetworksunSizeConvergence(in float value) { }

	public void set_SkyTint(Color value) { }

	public void set_SunSize(float value) { }

	public void set_SunSizeConvergence(float value) { }

	protected virtual void Start() { }

	public virtual bool Weaved() { }

}

