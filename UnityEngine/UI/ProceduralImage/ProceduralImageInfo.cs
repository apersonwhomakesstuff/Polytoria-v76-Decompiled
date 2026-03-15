namespace UnityEngine.UI.ProceduralImage;

public struct ProceduralImageInfo
{
	public float width; //Field offset: 0x0
	public float height; //Field offset: 0x4
	public float fallOffDistance; //Field offset: 0x8
	public Vector4 radius; //Field offset: 0xC
	public float borderWidth; //Field offset: 0x1C
	public float pixelSize; //Field offset: 0x20

	public ProceduralImageInfo(float width, float height, float fallOffDistance, float pixelSize, Vector4 radius, float borderWidth) { }

}

