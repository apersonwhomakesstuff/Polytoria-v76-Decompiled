namespace namudev;

public class PropertyGridBinding : MonoBehaviour
{
	[CompilerGenerated]
	private EventHandler ValueChanged; //Field offset: 0x20
	[CompilerGenerated]
	private string <Caption>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private object <Value>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Type <ValueType>k__BackingField; //Field offset: 0x38
	private object targetObject; //Field offset: 0x40
	private PropertyInfo propertyInfo; //Field offset: 0x48

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public private string Caption
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private object Value
	{
		[CompilerGenerated]
		 get { } //Length: 95
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private Type ValueType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public PropertyGridBinding() { }

	[CompilerGenerated]
	public void add_ValueChanged(EventHandler value) { }

	[CompilerGenerated]
	public string get_Caption() { }

	[CompilerGenerated]
	public object get_Value() { }

	[CompilerGenerated]
	public Type get_ValueType() { }

	public void Initialize(string caption, object value, Type valueType) { }

	public void Initialize(object targetObject, PropertyInfo propertyInfo) { }

	[CompilerGenerated]
	public void remove_ValueChanged(EventHandler value) { }

	[CompilerGenerated]
	private void set_Caption(string value) { }

	[CompilerGenerated]
	private void set_Value(object value) { }

	[CompilerGenerated]
	private void set_ValueType(Type value) { }

	public void SetValue(object value) { }

}

