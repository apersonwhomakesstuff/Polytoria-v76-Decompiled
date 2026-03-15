namespace Polytoria.Creator.PropertyGrid.Items;

public class PropertyGridItemEnum : PropertyGridItem
{
	private TMP_Dropdown dropdown; //Field offset: 0x40

	public PropertyGridItemEnum() { }

	private void OnValueChanged(int value) { }

	public virtual void SetProperty(PropertyInfo property) { }

	public virtual void SetValue(object value) { }

}

