namespace Polytoria.Datamodel.Proxies;

public class ParticlesProxy : DynamicInstanceProxy
{
	private readonly Particles particles; //Field offset: 0x20

	public NumberRange AngularVelocity
	{
		 get { } //Length: 47
		 set { } //Length: 30
	}

	public bool Autoplay
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public ColorRange Color
	{
		 get { } //Length: 47
		 set { } //Length: 53
	}

	public ParticleColorMode ColorMode
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public float Duration
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public int EmissionRate
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public float Gravity
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public string ImageID
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public ImageType ImageType
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public bool IsPaused
	{
		 get { } //Length: 29
	}

	public bool IsPlaying
	{
		 get { } //Length: 29
	}

	public bool IsStopped
	{
		 get { } //Length: 29
	}

	public NumberRange Lifetime
	{
		 get { } //Length: 47
		 set { } //Length: 30
	}

	public bool Loop
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public int MaxParticles
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public int ParticleCount
	{
		 get { } //Length: 29
	}

	public ParticleShape Shape
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public float ShapeAngle
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public float ShapeRadius
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public Vector3 ShapeScale
	{
		 get { } //Length: 47
		 set { } //Length: 53
	}

	public ParticleSimulationSpace SimulationSpace
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public NumberRange SizeOverLifetime
	{
		 get { } //Length: 47
		 set { } //Length: 30
	}

	public NumberRange Speed
	{
		 get { } //Length: 47
		 set { } //Length: 30
	}

	public NumberRange StartRotation
	{
		 get { } //Length: 47
		 set { } //Length: 30
	}

	public float Time
	{
		 get { } //Length: 29
	}

	public float TotalTime
	{
		 get { } //Length: 29
	}

	[MoonSharpHidden]
	public ParticlesProxy(Particles target) { }

	public void Clear() { }

	public void Emit(int count) { }

	public NumberRange get_AngularVelocity() { }

	public bool get_Autoplay() { }

	public ColorRange get_Color() { }

	public ParticleColorMode get_ColorMode() { }

	public float get_Duration() { }

	public int get_EmissionRate() { }

	public float get_Gravity() { }

	public string get_ImageID() { }

	public ImageType get_ImageType() { }

	public bool get_IsPaused() { }

	public bool get_IsPlaying() { }

	public bool get_IsStopped() { }

	public NumberRange get_Lifetime() { }

	public bool get_Loop() { }

	public int get_MaxParticles() { }

	public int get_ParticleCount() { }

	public ParticleShape get_Shape() { }

	public float get_ShapeAngle() { }

	public float get_ShapeRadius() { }

	public Vector3 get_ShapeScale() { }

	public ParticleSimulationSpace get_SimulationSpace() { }

	public NumberRange get_SizeOverLifetime() { }

	public NumberRange get_Speed() { }

	public NumberRange get_StartRotation() { }

	public float get_Time() { }

	public float get_TotalTime() { }

	public void Pause() { }

	public void Play() { }

	public void set_AngularVelocity(NumberRange value) { }

	public void set_Autoplay(bool value) { }

	public void set_Color(ColorRange value) { }

	public void set_ColorMode(ParticleColorMode value) { }

	public void set_Duration(float value) { }

	public void set_EmissionRate(int value) { }

	public void set_Gravity(float value) { }

	public void set_ImageID(string value) { }

	public void set_ImageType(ImageType value) { }

	public void set_Lifetime(NumberRange value) { }

	public void set_Loop(bool value) { }

	public void set_MaxParticles(int value) { }

	public void set_Shape(ParticleShape value) { }

	public void set_ShapeAngle(float value) { }

	public void set_ShapeRadius(float value) { }

	public void set_ShapeScale(Vector3 value) { }

	public void set_SimulationSpace(ParticleSimulationSpace value) { }

	public void set_SizeOverLifetime(NumberRange value) { }

	public void set_Speed(NumberRange value) { }

	public void set_StartRotation(NumberRange value) { }

	public void Simulate(float time) { }

	public void Stop() { }

}

