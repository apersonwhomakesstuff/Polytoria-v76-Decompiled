namespace namudev;

public abstract class PropertyGridItem : MonoBehaviour
{
	[CompilerGenerated]
	private EventHandler ValueChanged; //Field offset: 0x0
	private PropertyGridBinding binding; //Field offset: 0x0

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public string Caption
	{
		 get { } //Length: 27
	}

	public T Value
	{
		 get { } //Length: 100
		 set { } //Length: 69
	}

	public Type ValueType
	{
		 get { } //Length: 27
	}

	protected PropertyGridItem`1() { }

	[CompilerGenerated]
	private void <Awake>b__11_0(object o, EventArgs e) { }

	[CompilerGenerated]
	public void add_ValueChanged(EventHandler value) { }

	protected override void Awake() { }

	public string get_Caption() { }

	public T get_Value() { }

	public Type get_ValueType() { }

	[CompilerGenerated]
	public void remove_ValueChanged(EventHandler value) { }

	protected void set_Value(T value) { }

}

