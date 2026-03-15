namespace Polytoria.Datamodel.Services;

public class Datastore
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public Datastore <>4__this; //Field offset: 0x10
		public string key; //Field offset: 0x18
		public DynValue callback; //Field offset: 0x20
		public DatastoreEntry entry; //Field offset: 0x28

		public <>c__DisplayClass12_0() { }

		internal void <Get>b__0(bool success) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public DynValue callback; //Field offset: 0x10
		public Datastore <>4__this; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal void <Set>b__0(bool success) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public DynValue callback; //Field offset: 0x10
		public Datastore <>4__this; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		internal void <Remove>b__0(bool success) { }

	}

	private struct DatastoreEntry
	{
		public object value; //Field offset: 0x0
		public float timestamp; //Field offset: 0x8

	}

	public static readonly float CACHE_TIME; //Field offset: 0x0
	private string key; //Field offset: 0x10
	private bool loading; //Field offset: 0x18
	private Dictionary<String, DatastoreEntry> data; //Field offset: 0x20
	private ScriptService scriptService; //Field offset: 0x28
	public LuaEvent Loaded; //Field offset: 0x30

	public string Key
	{
		 get { } //Length: 5
	}

	public bool Loading
	{
		 get { } //Length: 5
	}

	private static Datastore() { }

	public Datastore(string key) { }

	[CompilerGenerated]
	private void <.ctor>b__10_0(bool success) { }

	public void Deserialize(string jsonData) { }

	public void Get(string key, DynValue callback) { }

	public string get_Key() { }

	public bool get_Loading() { }

	public void Remove(string key, DynValue callback = null) { }

	public void Set(string key, DynValue value, DynValue callback = null) { }

}

