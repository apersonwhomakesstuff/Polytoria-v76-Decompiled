namespace RLD;

public static class GameObjectTypeHelper
{
	private static int _numTypes; //Field offset: 0x0
	private static List<GameObjectType> _allObjectTypes; //Field offset: 0x8
	private static GameObjectType _allCombined; //Field offset: 0x10

	public static GameObjectType AllCombined
	{
		 get { } //Length: 78
	}

	public static GameObjectType[] AllObjectTypes
	{
		 get { } //Length: 112
	}

	public static int NumTypes
	{
		 get { } //Length: 77
	}

	private static GameObjectTypeHelper() { }

	public static int ClearTypeBit(int objectTypeMask, GameObjectType typeBit) { }

	public static GameObjectType get_AllCombined() { }

	public static GameObjectType[] get_AllObjectTypes() { }

	public static int get_NumTypes() { }

	public static bool HasVolume(GameObjectType objectType) { }

	public static bool Is2DObjectType(GameObjectType objectType) { }

	public static bool Is3DObjectType(GameObjectType objectType) { }

	public static bool IsTypeBitSet(int objectTypeMask, GameObjectType typeBit) { }

	public static int SetTypeBit(int objectTypeMask, GameObjectType typeBit) { }

}

