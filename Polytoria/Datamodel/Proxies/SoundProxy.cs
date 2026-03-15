namespace Polytoria.Datamodel.Proxies;

public class SoundProxy : DynamicInstanceProxy
{
	private readonly Sound sound; //Field offset: 0x20

	public bool Autoplay
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public float Length
	{
		 get { } //Length: 29
	}

	public LuaEvent Loaded
	{
		 get { } //Length: 30
	}

	public bool Loading
	{
		 get { } //Length: 30
	}

	public bool Loop
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public float MaxDistance
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public float Pitch
	{
		 get { } //Length: 31
		 set { } //Length: 30
	}

	public bool Playing
	{
		 get { } //Length: 30
	}

	public bool PlayInWorld
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public Vector3 Rotation
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public Vector3 Size
	{
		 get { } //Length: 59
		 set { } //Length: 53
	}

	public int SoundID
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public float Time
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public float Volume
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public SoundProxy(Sound target) { }

	public bool get_Autoplay() { }

	public float get_Length() { }

	public LuaEvent get_Loaded() { }

	public bool get_Loading() { }

	public bool get_Loop() { }

	public float get_MaxDistance() { }

	public float get_Pitch() { }

	public bool get_Playing() { }

	public bool get_PlayInWorld() { }

	public Vector3 get_Rotation() { }

	public Vector3 get_Size() { }

	public int get_SoundID() { }

	public float get_Time() { }

	public float get_Volume() { }

	public void Play() { }

	public void PlayOneShot(float volume = 1) { }

	public void set_Autoplay(bool value) { }

	public void set_Loop(bool value) { }

	public void set_MaxDistance(float value) { }

	public void set_Pitch(float value) { }

	public void set_PlayInWorld(bool value) { }

	public void set_Rotation(Vector3 value) { }

	public void set_Size(Vector3 value) { }

	public void set_SoundID(int value) { }

	public void set_Time(float value) { }

	public void set_Volume(float value) { }

	public void Stop() { }

}

