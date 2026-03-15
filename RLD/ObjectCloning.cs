namespace RLD;

public static class ObjectCloning
{
	internal struct Config
	{
		public Transform Parent; //Field offset: 0x0
		public TransformFlags TransformFlags; //Field offset: 0x8
		public int Layer; //Field offset: 0xC

	}

	[Flags]
	internal enum TransformFlags : int
	{
		None = 0,
		Position = 1,
		Rotation = 2,
		Scale = 4,
		All = 7,
	}

	private static Config _defaultConfig; //Field offset: 0x0

	public static Config DefaultConfig
	{
		 get { } //Length: 90
	}

	private static ObjectCloning() { }

	public static List<GameObject> CloneHierarchies(List<GameObject> roots, Config cloneConfig) { }

	public static GameObject CloneHierarchy(GameObject root, Config cloneConfig) { }

	public static Config get_DefaultConfig() { }

}

