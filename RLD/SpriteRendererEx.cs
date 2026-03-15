namespace RLD;

[Extension]
public static class SpriteRendererEx
{

	[Extension]
	public static AABB GetModelSpaceAABB(SpriteRenderer spriteRenderer) { }

	[Extension]
	public static Vector3 GetModelSpaceSize(SpriteRenderer spriteRenderer) { }

	[Extension]
	public static Vector3 GetWorldCenterPoint(SpriteRenderer spriteRenderer) { }

	[Extension]
	public static bool IsPixelFullyTransparent(SpriteRenderer spriteRenderer, Vector3 worldPos) { }

}

