namespace RLD;

public class TexturePool : Singleton<TexturePool>
{
	private Texture2D _mainLightIcon; //Field offset: 0x10
	private Texture2D _mainParticleSystemIcon; //Field offset: 0x18
	private Texture2D _cameraIcon; //Field offset: 0x20
	private Texture2D _xAxisLabel; //Field offset: 0x28
	private Texture2D _yAxisLabel; //Field offset: 0x30
	private Texture2D _zAxisLabel; //Field offset: 0x38
	private Texture2D _camPerspMode; //Field offset: 0x40
	private Texture2D _camOrthoMode; //Field offset: 0x48

	public Texture2D CameraIcon
	{
		 get { } //Length: 196
	}

	public Texture2D CamOrthoMode
	{
		 get { } //Length: 196
	}

	public Texture2D CamPerspMode
	{
		 get { } //Length: 196
	}

	public Texture2D MainLightIcon
	{
		 get { } //Length: 196
	}

	public Texture2D MainParticleSystemIcon
	{
		 get { } //Length: 196
	}

	public Texture2D XAxisLabel
	{
		 get { } //Length: 196
	}

	public Texture2D YAxisLabel
	{
		 get { } //Length: 196
	}

	public Texture2D ZAxisLabel
	{
		 get { } //Length: 196
	}

	public TexturePool() { }

	public Texture2D get_CameraIcon() { }

	public Texture2D get_CamOrthoMode() { }

	public Texture2D get_CamPerspMode() { }

	public Texture2D get_MainLightIcon() { }

	public Texture2D get_MainParticleSystemIcon() { }

	public Texture2D get_XAxisLabel() { }

	public Texture2D get_YAxisLabel() { }

	public Texture2D get_ZAxisLabel() { }

}

