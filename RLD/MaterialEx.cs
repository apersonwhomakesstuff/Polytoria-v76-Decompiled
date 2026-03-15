namespace RLD;

[Extension]
public static class MaterialEx
{

	[Extension]
	public static void SetColor(Material material, Color color) { }

	[Extension]
	public static void SetCullModeBack(Material material) { }

	[Extension]
	public static void SetCullModeFront(Material material) { }

	[Extension]
	public static void SetCullModeOff(Material material) { }

	[Extension]
	public static void SetStencilCmpAlways(Material material) { }

	[Extension]
	public static void SetStencilCmpNotEqual(Material material) { }

	[Extension]
	public static void SetZTestAlways(Material material) { }

	[Extension]
	public static void SetZTestEnabled(Material material, bool enabled) { }

	[Extension]
	public static void SetZTestLess(Material material) { }

	[Extension]
	public static void SetZWriteEnabled(Material material, bool enabled) { }

}

