namespace Polytoria.Datamodel;

[Instantiatable]
public class GradientSky : SkyBase
{
	[SyncVar(hook = "OnSunDiscColorChanged")]
	private Color sunDiscColor; //Field offset: 0x100
	[SyncVar(hook = "OnSunDiscMultiplierChanged")]
	private float sunDiscMultiplier; //Field offset: 0x110
	[SyncVar(hook = "OnSunDiscExponentChanged")]
	private float sunDiscExponent; //Field offset: 0x114
	[SyncVar(hook = "OnSunHaloColorChanged")]
	private Color sunHaloColor; //Field offset: 0x118
	[SyncVar(hook = "OnSunHaloExponentChanged")]
	private float sunHaloExponent; //Field offset: 0x128
	[SyncVar(hook = "OnSunHaloContributionChanged")]
	private float sunHaloContribution; //Field offset: 0x12C
	[SyncVar(hook = "OnHorizonLineColorChanged")]
	private Color horizonLineColor; //Field offset: 0x130
	[SyncVar(hook = "OnHorizonLineExponentChanged")]
	private float horizonLineExponent; //Field offset: 0x140
	[SyncVar(hook = "OnHorizonLineContributionChanged")]
	private float horizonLineContribution; //Field offset: 0x144
	[SyncVar(hook = "OnSkyGradientTopChanged")]
	private Color skyGradientTop; //Field offset: 0x148
	[SyncVar(hook = "OnSkyGradientBottomChanged")]
	private Color skyGradientBottom; //Field offset: 0x158
	[SyncVar(hook = "OnSkyGradientExponentChanged")]
	private float skyGradientExponent; //Field offset: 0x168
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_sunDiscColor; //Field offset: 0x170
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_sunDiscMultiplier; //Field offset: 0x178
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_sunDiscExponent; //Field offset: 0x180
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_sunHaloColor; //Field offset: 0x188
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_sunHaloExponent; //Field offset: 0x190
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_sunHaloContribution; //Field offset: 0x198
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_horizonLineColor; //Field offset: 0x1A0
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_horizonLineExponent; //Field offset: 0x1A8
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_horizonLineContribution; //Field offset: 0x1B0
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_skyGradientTop; //Field offset: 0x1B8
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_skyGradientBottom; //Field offset: 0x1C0
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_skyGradientExponent; //Field offset: 0x1C8

	[Archivable]
	[CreatorProperty]
	public Color HorizonLineColor
	{
		 get { } //Length: 14
		 set { } //Length: 186
	}

	[Archivable]
	[CreatorProperty]
	public float HorizonLineContribution
	{
		 get { } //Length: 9
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	public float HorizonLineExponent
	{
		 get { } //Length: 9
		 set { } //Length: 166
	}

	public Color NetworkhorizonLineColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public float NetworkhorizonLineContribution
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public float NetworkhorizonLineExponent
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public Color NetworkskyGradientBottom
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public float NetworkskyGradientExponent
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public Color NetworkskyGradientTop
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public Color NetworksunDiscColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public float NetworksunDiscExponent
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public float NetworksunDiscMultiplier
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public Color NetworksunHaloColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public float NetworksunHaloContribution
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	public float NetworksunHaloExponent
	{
		 get { } //Length: 9
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	public Color SkyGradientBottom
	{
		 get { } //Length: 14
		 set { } //Length: 186
	}

	[Archivable]
	[CreatorProperty]
	public float SkyGradientExponent
	{
		 get { } //Length: 9
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	public Color SkyGradientTop
	{
		 get { } //Length: 14
		 set { } //Length: 186
	}

	[Archivable]
	[CreatorProperty]
	public Color SunDiscColor
	{
		 get { } //Length: 14
		 set { } //Length: 186
	}

	[Archivable]
	[CreatorProperty]
	public float SunDiscExponent
	{
		 get { } //Length: 9
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	public float SunDiscMultiplier
	{
		 get { } //Length: 9
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	public Color SunHaloColor
	{
		 get { } //Length: 14
		 set { } //Length: 186
	}

	[Archivable]
	[CreatorProperty]
	public float SunHaloContribution
	{
		 get { } //Length: 9
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	public float SunHaloExponent
	{
		 get { } //Length: 9
		 set { } //Length: 166
	}

	public GradientSky() { }

	protected virtual void Apply() { }

	protected virtual void Awake() { }

	protected virtual void CopyProperties(Instance clone) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public Color get_HorizonLineColor() { }

	public float get_HorizonLineContribution() { }

	public float get_HorizonLineExponent() { }

	public Color get_NetworkhorizonLineColor() { }

	public float get_NetworkhorizonLineContribution() { }

	public float get_NetworkhorizonLineExponent() { }

	public Color get_NetworkskyGradientBottom() { }

	public float get_NetworkskyGradientExponent() { }

	public Color get_NetworkskyGradientTop() { }

	public Color get_NetworksunDiscColor() { }

	public float get_NetworksunDiscExponent() { }

	public float get_NetworksunDiscMultiplier() { }

	public Color get_NetworksunHaloColor() { }

	public float get_NetworksunHaloContribution() { }

	public float get_NetworksunHaloExponent() { }

	public Color get_SkyGradientBottom() { }

	public float get_SkyGradientExponent() { }

	public Color get_SkyGradientTop() { }

	public Color get_SunDiscColor() { }

	public float get_SunDiscExponent() { }

	public float get_SunDiscMultiplier() { }

	public Color get_SunHaloColor() { }

	public float get_SunHaloContribution() { }

	public float get_SunHaloExponent() { }

	private void OnHorizonLineColorChanged(Color oldValue, Color newValue) { }

	private void OnHorizonLineContributionChanged(float oldValue, float newValue) { }

	private void OnHorizonLineExponentChanged(float oldValue, float newValue) { }

	private void OnSkyGradientBottomChanged(Color oldValue, Color newValue) { }

	private void OnSkyGradientExponentChanged(float oldValue, float newValue) { }

	private void OnSkyGradientTopChanged(Color oldValue, Color newValue) { }

	private void OnSunDiscColorChanged(Color oldValue, Color newValue) { }

	private void OnSunDiscExponentChanged(float oldValue, float newValue) { }

	private void OnSunDiscMultiplierChanged(float oldValue, float newValue) { }

	private void OnSunHaloColorChanged(Color oldValue, Color newValue) { }

	private void OnSunHaloContributionChanged(float oldValue, float newValue) { }

	private void OnSunHaloExponentChanged(float oldValue, float newValue) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_HorizonLineColor(Color value) { }

	public void set_HorizonLineContribution(float value) { }

	public void set_HorizonLineExponent(float value) { }

	public void set_NetworkhorizonLineColor(in Color value) { }

	public void set_NetworkhorizonLineContribution(in float value) { }

	public void set_NetworkhorizonLineExponent(in float value) { }

	public void set_NetworkskyGradientBottom(in Color value) { }

	public void set_NetworkskyGradientExponent(in float value) { }

	public void set_NetworkskyGradientTop(in Color value) { }

	public void set_NetworksunDiscColor(in Color value) { }

	public void set_NetworksunDiscExponent(in float value) { }

	public void set_NetworksunDiscMultiplier(in float value) { }

	public void set_NetworksunHaloColor(in Color value) { }

	public void set_NetworksunHaloContribution(in float value) { }

	public void set_NetworksunHaloExponent(in float value) { }

	public void set_SkyGradientBottom(Color value) { }

	public void set_SkyGradientExponent(float value) { }

	public void set_SkyGradientTop(Color value) { }

	public void set_SunDiscColor(Color value) { }

	public void set_SunDiscExponent(float value) { }

	public void set_SunDiscMultiplier(float value) { }

	public void set_SunHaloColor(Color value) { }

	public void set_SunHaloContribution(float value) { }

	public void set_SunHaloExponent(float value) { }

	protected virtual void Start() { }

	public virtual bool Weaved() { }

}

