namespace Polytoria.Datamodel.Proxies;

public class DecalProxy : DynamicInstanceProxy
{
	private readonly Decal decal; //Field offset: 0x20

	public bool CastShadows
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public Color Color
	{
		 get { } //Length: 36
		 set { } //Length: 44
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

	public Vector2 TextureOffset
	{
		 get { } //Length: 47
		 set { } //Length: 30
	}

	public Vector2 TextureScale
	{
		 get { } //Length: 47
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public DecalProxy(Decal target) { }

	public bool get_CastShadows() { }

	public Color get_Color() { }

	public string get_ImageID() { }

	public ImageType get_ImageType() { }

	public Vector2 get_TextureOffset() { }

	public Vector2 get_TextureScale() { }

	public void set_CastShadows(bool value) { }

	public void set_Color(Color value) { }

	public void set_ImageID(string value) { }

	public void set_ImageType(ImageType value) { }

	public void set_TextureOffset(Vector2 value) { }

	public void set_TextureScale(Vector2 value) { }

}

