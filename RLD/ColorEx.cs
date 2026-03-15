namespace RLD;

[Extension]
public static class ColorEx
{

	public static Color FromByteValues(byte r, byte g, byte b, byte a) { }

	public static Color[] GetFilledColorArray(int arrayLength, Color fillValue) { }

	[Extension]
	public static Color KeepAllButAlpha(Color color, float newAlpha) { }

}

