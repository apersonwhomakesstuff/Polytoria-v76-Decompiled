namespace Polytoria.Creator.PropertyGrid.Items;

public class PropertyGridItemVector2 : PropertyGridItem
{
	private TMP_InputField inputFieldX; //Field offset: 0x40
	private TMP_InputField inputFieldY; //Field offset: 0x48

	public PropertyGridItemVector2() { }

	private void OnValueChanged(string value) { }

	public virtual void SetProperty(PropertyInfo property) { }

	public virtual void SetValue(object value) { }

}

