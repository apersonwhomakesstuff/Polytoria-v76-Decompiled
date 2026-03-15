namespace Polytoria.Creator.PropertyGrid.Items;

public class PropertyGridItemInteger : PropertyGridItem
{
	private TMP_InputField inputField; //Field offset: 0x40

	public PropertyGridItemInteger() { }

	private void OnValueChanged(string value) { }

	public virtual void SetProperty(PropertyInfo property) { }

	public virtual void SetValue(object value) { }

}

