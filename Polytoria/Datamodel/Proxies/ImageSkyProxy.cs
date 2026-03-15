namespace Polytoria.Datamodel.Proxies;

public class ImageSkyProxy : SkyBaseProxy
{
	private readonly ImageSky imageSky; //Field offset: 0x20

	public int BackId
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public int BottomId
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public int FrontId
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public int LeftId
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public int RightId
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public int TopId
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public ImageSkyProxy(ImageSky target) { }

	public int get_BackId() { }

	public int get_BottomId() { }

	public int get_FrontId() { }

	public int get_LeftId() { }

	public int get_RightId() { }

	public int get_TopId() { }

	public void set_BackId(int value) { }

	public void set_BottomId(int value) { }

	public void set_FrontId(int value) { }

	public void set_LeftId(int value) { }

	public void set_RightId(int value) { }

	public void set_TopId(int value) { }

}

