namespace Polytoria.Creator.PropertyGrid.Items;

public class PropertyGridItemColor : PropertyGridItem
{
	private ProceduralImage colorDisplayer; //Field offset: 0x40
	private Button colorDisplayerBtn; //Field offset: 0x48
	private TMP_InputField hexInput; //Field offset: 0x50

	public PropertyGridItemColor() { }

	private void Awake() { }

	private void OnColorDisplayerBtnClick() { }

	private void OnDestroy() { }

	private void OnHexInputValueChanged(string value) { }

	private void OnValueChange(Color color) { }

	private void OnValueChanged(bool value) { }

	public virtual void SetProperty(PropertyInfo property) { }

	public virtual void SetValue(object value) { }

}

