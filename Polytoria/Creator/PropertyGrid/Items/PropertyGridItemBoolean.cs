namespace Polytoria.Creator.PropertyGrid.Items;

public class PropertyGridItemBoolean : PropertyGridItem
{
	private Toggle toggle; //Field offset: 0x40

	public PropertyGridItemBoolean() { }

	private void OnValueChanged(bool value) { }

	public virtual void SetProperty(PropertyInfo property) { }

	public virtual void SetValue(object value) { }

}

