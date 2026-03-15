namespace Polytoria.Datamodel.Proxies;

public class UIImageProxy : UIFieldProxy
{
	private readonly UIImage uiImage; //Field offset: 0x20

	public bool Clickable
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

	public bool Loading
	{
		 get { } //Length: 30
	}

	[MoonSharpHidden]
	public UIImageProxy(UIImage target) { }

	public bool get_Clickable() { }

	public Color get_Color() { }

	public string get_ImageID() { }

	public ImageType get_ImageType() { }

	public bool get_Loading() { }

	public void set_Clickable(bool value) { }

	public void set_Color(Color value) { }

	public void set_ImageID(string value) { }

	public void set_ImageType(ImageType value) { }

}

