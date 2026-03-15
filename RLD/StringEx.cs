namespace RLD;

[Extension]
public static class StringEx
{

	[Extension]
	public static bool ContainsOnlyWhiteSpace(string str) { }

	[Extension]
	public static bool IsSingleChar(string str, char character) { }

	[Extension]
	public static bool IsSingleDigit(string str) { }

	[Extension]
	public static bool IsSingleLetter(string str) { }

	[Extension]
	public static char LastChar(string str) { }

	[Extension]
	public static int LastCharIndex(string str) { }

	[Extension]
	public static string RemoveTrailingSlashes(string str) { }

}

