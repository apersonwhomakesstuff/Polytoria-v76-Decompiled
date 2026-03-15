namespace Polytoria.Creator.PropertyGrid;

public abstract class PropertyGridItem : MonoBehaviour
{
	[CompilerGenerated]
	private Action<Object> PropertyChanged; //Field offset: 0x20
	private PropertyInfo property; //Field offset: 0x28
	protected object currentValue; //Field offset: 0x30
	protected bool editingMultipleValues; //Field offset: 0x38

	public event Action<Object> PropertyChanged
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	protected PropertyGridItem() { }

	[CompilerGenerated]
	public void add_PropertyChanged(Action<Object> value) { }

	protected override void InvokeValueChanged(object value) { }

	[CompilerGenerated]
	public void remove_PropertyChanged(Action<Object> value) { }

	public override void SetProperty(PropertyInfo property) { }

	public abstract void SetValue(object value) { }

}

