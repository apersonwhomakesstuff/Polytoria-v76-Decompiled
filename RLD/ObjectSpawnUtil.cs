namespace RLD;

public static class ObjectSpawnUtil
{
	internal struct Config
	{
		public float ObjectSize; //Field offset: 0x0

	}

	private static Config _defaultConfig; //Field offset: 0x0

	public static Config DefaultConfig
	{
		 get { } //Length: 77
	}

	private static ObjectSpawnUtil() { }

	public static Config get_DefaultConfig() { }

	public static GameObject SpawnInFrontOfCamera(GameObject sourceObject, Camera camera, Config config) { }

}

