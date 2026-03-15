namespace RLD;

[Extension]
public static class RectEx
{

	[Extension]
	public static bool ContainsAllPoints(Rect rect, IEnumerable<Vector2> points) { }

	public static Rect FromCenterAndSize(Vector2 center, Vector2 size) { }

	public static Rect FromPoints(IEnumerable<Vector2> points) { }

	public static Rect FromTexture2D(Texture2D texture2D) { }

	[Extension]
	public static List<Vector2> GetCornerPoints(Rect rect) { }

	[Extension]
	public static Rect Inflate(Rect rect, float inflateAmount) { }

	[Extension]
	public static Rect InvertScreenY(Rect rect) { }

	[Extension]
	public static Rect PlaceBelowCenterHrz(Rect rect, Rect other) { }

}

