namespace Polytoria.Datamodel.Proxies;

[DefaultMember("Item")]
public class InstanceProxy
{
	private readonly Instance target; //Field offset: 0x10

	[LuaEventParameter(typeof(Instance), "child", False)]
	public LuaEvent ChildAdded
	{
		 get { } //Length: 30
	}

	[LuaEventParameter(typeof(Instance), "child", False)]
	public LuaEvent ChildRemoved
	{
		 get { } //Length: 30
	}

	public string ClassName
	{
		 get { } //Length: 27
	}

	[LuaEventParameter(typeof(Player), "player", False)]
	public LuaEvent Clicked
	{
		 get { } //Length: 30
	}

	public bool ClientSpawned
	{
		 get { } //Length: 30
	}

	public Instance Item
	{
		 get { } //Length: 30
	}

	public Instance Item
	{
		 get { } //Length: 30
	}

	public LuaEvent MouseEnter
	{
		 get { } //Length: 30
	}

	public LuaEvent MouseExit
	{
		 get { } //Length: 30
	}

	public string Name
	{
		 get { } //Length: 27
		 set { } //Length: 30
	}

	public Instance Parent
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public DynValue Shared
	{
		 get { } //Length: 30
	}

	[LuaEventParameter(typeof(Instance), "other", False)]
	public LuaEvent Touched
	{
		 get { } //Length: 30
	}

	[LuaEventParameter(typeof(Instance), "other", False)]
	public LuaEvent TouchEnded
	{
		 get { } //Length: 30
	}

	[MoonSharpHidden]
	public InstanceProxy(Instance target) { }

	public Instance Clone() { }

	public void Delete(float time = 0) { }

	public void Destroy(float time = 0) { }

	public Instance FindChild(string name) { }

	public Instance FindChildByClass(string className) { }

	public LuaEvent get_ChildAdded() { }

	public LuaEvent get_ChildRemoved() { }

	public string get_ClassName() { }

	public LuaEvent get_Clicked() { }

	public bool get_ClientSpawned() { }

	public Instance get_Item(string name) { }

	public Instance get_Item(int index) { }

	public LuaEvent get_MouseEnter() { }

	public LuaEvent get_MouseExit() { }

	public string get_Name() { }

	public Instance get_Parent() { }

	public DynValue get_Shared() { }

	public LuaEvent get_Touched() { }

	public LuaEvent get_TouchEnded() { }

	public Bounds GetBounds() { }

	public Instance[] GetChildren() { }

	public Instance[] GetChildrenOfClass(string className) { }

	public Instance GetParent() { }

	public bool IsA(string className) { }

	public bool IsDescendantOf(Instance parent) { }

	public static Instance New(string className, Instance parent = null) { }

	public void set_Name(string value) { }

	public void set_Parent(Instance value) { }

	public void SetParent(Instance parent) { }

}

