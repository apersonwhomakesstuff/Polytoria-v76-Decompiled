namespace Polytoria.Creator.PropertyGrid.Items;

public class PropertyGridItemFloat : PropertyGridItem
{
	private TMP_InputField inputField; //Field offset: 0x40

	public PropertyGridItemFloat() { }

	private void OnValueChanged(string value) { }

	public virtual void SetProperty(PropertyInfo property) { }

	public virtual void SetValue(object value) { }

}

