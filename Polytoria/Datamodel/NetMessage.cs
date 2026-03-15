namespace Polytoria.Datamodel;

public class NetMessage
{
	[MoonSharpHidden]
	public readonly Dictionary<String, String> strings; //Field offset: 0x10
	[MoonSharpHidden]
	public readonly Dictionary<String, Int32> ints; //Field offset: 0x18
	[MoonSharpHidden]
	public readonly Dictionary<String, Single> numbers; //Field offset: 0x20
	[MoonSharpHidden]
	public readonly Dictionary<String, Boolean> bools; //Field offset: 0x28
	[MoonSharpHidden]
	public readonly Dictionary<String, Vector2> vec2s; //Field offset: 0x30
	[MoonSharpHidden]
	public readonly Dictionary<String, Vector3> vec3s; //Field offset: 0x38
	[MoonSharpHidden]
	public readonly Dictionary<String, Color> colors; //Field offset: 0x40
	[MoonSharpHidden]
	public readonly Dictionary<String, Instance> instances; //Field offset: 0x48

	public NetMessage() { }

	public NetMessage(Dictionary<String, String> strings, Dictionary<String, Int32> ints, Dictionary<String, Single> numbers, Dictionary<String, Boolean> bools, Dictionary<String, Vector2> vec2s, Dictionary<String, Vector3> vec3s, Dictionary<String, Color> colors, Dictionary<String, Instance> instances) { }

	public void AddBool(string key, bool value) { }

	public void AddColor(string key, Color value) { }

	public void AddInstance(string key, Instance value) { }

	public void AddInt(string key, int value) { }

	public void AddNumber(string key, float value) { }

	public void AddString(string key, string value) { }

	public void AddVector2(string key, Vector2 value) { }

	public void AddVector3(string key, Vector3 value) { }

	public bool GetBool(string key) { }

	public Color GetColor(string key) { }

	public Instance GetInstance(string key) { }

	public int GetInt(string key) { }

	public float GetNumber(string key) { }

	public string GetString(string key) { }

	public Vector2 GetVector2(string key) { }

	public Vector3 GetVector3(string key) { }

	public static NetMessage New() { }

}

