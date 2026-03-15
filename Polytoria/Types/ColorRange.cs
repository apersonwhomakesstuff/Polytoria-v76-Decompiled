namespace Polytoria.Types;

public struct ColorRange
{
	public Color min; //Field offset: 0x0
	public Color max; //Field offset: 0x10

	public ColorRange(Color min, Color max) { }

	public Color Lerp(float t) { }

	public static ColorRange New(Color min, Color max) { }

}

