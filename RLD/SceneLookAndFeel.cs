namespace RLD;

public class SceneLookAndFeel : Settings
{
	[SerializeField]
	private bool _drawLightIcons; //Field offset: 0x28
	[SerializeField]
	private bool _drawParticleSystemIcons; //Field offset: 0x29
	[SerializeField]
	private bool _drawCameraIcons; //Field offset: 0x2A
	[SerializeField]
	private float _lightIconAlpha; //Field offset: 0x2C
	[SerializeField]
	private float _particleSystemIconAlpha; //Field offset: 0x30
	[SerializeField]
	private float _cameraIconAlpha; //Field offset: 0x34
	[SerializeField]
	private Texture2D _lightIcon; //Field offset: 0x38
	[SerializeField]
	private Texture2D _particleSystemIcon; //Field offset: 0x40
	[SerializeField]
	private Texture2D _cameraIcon; //Field offset: 0x48

	public Texture2D CameraIcon
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public float CameraIconAlpha
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public bool DrawCameraIcons
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool DrawLightIcons
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool DrawParticleSystemIcons
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public Texture2D LightIcon
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public float LightIconAlpha
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public Texture2D ParticleSystemIcon
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public float ParticleSystemIconAlpha
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public SceneLookAndFeel() { }

	public Texture2D get_CameraIcon() { }

	public float get_CameraIconAlpha() { }

	public bool get_DrawCameraIcons() { }

	public bool get_DrawLightIcons() { }

	public bool get_DrawParticleSystemIcons() { }

	public Texture2D get_LightIcon() { }

	public float get_LightIconAlpha() { }

	public Texture2D get_ParticleSystemIcon() { }

	public float get_ParticleSystemIconAlpha() { }

	public void set_CameraIcon(Texture2D value) { }

	public void set_CameraIconAlpha(float value) { }

	public void set_DrawCameraIcons(bool value) { }

	public void set_DrawLightIcons(bool value) { }

	public void set_DrawParticleSystemIcons(bool value) { }

	public void set_LightIcon(Texture2D value) { }

	public void set_LightIconAlpha(float value) { }

	public void set_ParticleSystemIcon(Texture2D value) { }

	public void set_ParticleSystemIconAlpha(float value) { }

}

