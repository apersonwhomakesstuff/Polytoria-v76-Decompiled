namespace Polytoria.Datamodel;

[Extension]
public static class NetMessageReadWriteFunctions
{

	public static Dictionary<String, T> ReadDictionary(NetworkReader reader) { }

	[Extension]
	public static NetMessage ReadNetMessage(NetworkReader reader) { }

	[Extension]
	private static void WriteDictionary(NetworkWriter writer, Dictionary<String, T> dict) { }

	[Extension]
	public static void WriteNetMessage(NetworkWriter writer, NetMessage value) { }

}

