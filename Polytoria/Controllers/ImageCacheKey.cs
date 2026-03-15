namespace Polytoria.Controllers;

public struct ImageCacheKey
{
	public string id; //Field offset: 0x0
	public string url; //Field offset: 0x8
	public ImageType type; //Field offset: 0x10

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

