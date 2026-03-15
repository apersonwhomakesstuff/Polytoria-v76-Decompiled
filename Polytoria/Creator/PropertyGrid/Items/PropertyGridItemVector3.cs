namespace Polytoria.Creator.PropertyGrid.Items;

public class PropertyGridItemVector3 : PropertyGridItem
{
	private TMP_InputField inputFieldX; //Field offset: 0x40
	private TMP_InputField inputFieldY; //Field offset: 0x48
	private TMP_InputField inputFieldZ; //Field offset: 0x50

	public PropertyGridItemVector3() { }

	private void OnValueChanged(string value) { }

	public virtual void SetProperty(PropertyInfo property) { }

	public virtual void SetValue(object value) { }

}

