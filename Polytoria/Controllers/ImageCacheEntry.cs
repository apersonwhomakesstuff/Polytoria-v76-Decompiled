namespace Polytoria.Controllers;

public class ImageCacheEntry
{
	public Texture2D texture; //Field offset: 0x10
	public bool loaded; //Field offset: 0x18
	public bool hasTransparency; //Field offset: 0x19

	public ImageCacheEntry() { }

}

