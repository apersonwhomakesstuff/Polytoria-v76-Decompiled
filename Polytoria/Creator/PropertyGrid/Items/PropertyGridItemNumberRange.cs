namespace Polytoria.Creator.PropertyGrid.Items;

public class PropertyGridItemNumberRange : PropertyGridItem
{
	private TMP_InputField inputFieldMin; //Field offset: 0x40
	private TMP_InputField inputFieldMax; //Field offset: 0x48

	public PropertyGridItemNumberRange() { }

	private void OnValueChanged(string value) { }

	public virtual void SetProperty(PropertyInfo property) { }

	public virtual void SetValue(object value) { }

}

