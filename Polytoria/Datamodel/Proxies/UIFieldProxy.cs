namespace Polytoria.Datamodel.Proxies;

public class UIFieldProxy : InstanceProxy
{
	private readonly UIField uiField; //Field offset: 0x18

	public bool ClipDescendants
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public LuaEvent MouseDown
	{
		 get { } //Length: 30
	}

	public LuaEvent MouseUp
	{
		 get { } //Length: 30
	}

	public Vector2 PivotPoint
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public Vector2 PositionOffset
	{
		 get { } //Length: 47
		 set { } //Length: 30
	}

	public Vector2 PositionRelative
	{
		 get { } //Length: 47
		 set { } //Length: 30
	}

	public float Rotation
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public Vector2 SizeOffset
	{
		 get { } //Length: 47
		 set { } //Length: 30
	}

	public Vector2 SizeRelative
	{
		 get { } //Length: 47
		 set { } //Length: 30
	}

	public bool Visible
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	[MoonSharpHidden]
	public UIFieldProxy(UIField target) { }

	public bool get_ClipDescendants() { }

	public LuaEvent get_MouseDown() { }

	public LuaEvent get_MouseUp() { }

	public Vector2 get_PivotPoint() { }

	public Vector2 get_PositionOffset() { }

	public Vector2 get_PositionRelative() { }

	public float get_Rotation() { }

	public Vector2 get_SizeOffset() { }

	public Vector2 get_SizeRelative() { }

	public bool get_Visible() { }

	public void set_ClipDescendants(bool value) { }

	public void set_PivotPoint(Vector2 value) { }

	public void set_PositionOffset(Vector2 value) { }

	public void set_PositionRelative(Vector2 value) { }

	public void set_Rotation(float value) { }

	public void set_SizeOffset(Vector2 value) { }

	public void set_SizeRelative(Vector2 value) { }

	public void set_Visible(bool value) { }

}

