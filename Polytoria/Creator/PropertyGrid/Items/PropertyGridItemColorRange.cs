namespace Polytoria.Creator.PropertyGrid.Items;

public class PropertyGridItemColorRange : PropertyGridItem
{
	private ProceduralImage colorDisplayerMin; //Field offset: 0x40
	private ProceduralImage colorDisplayerMax; //Field offset: 0x48
	private Button colorDisplayerBtnMin; //Field offset: 0x50
	private Button colorDisplayerBtnMax; //Field offset: 0x58

	public PropertyGridItemColorRange() { }

	private void Awake() { }

	private void OnColorDisplayerBtnClickMax() { }

	private void OnColorDisplayerBtnClickMin() { }

	private void OnDestroy() { }

	private void OnValueChanged(bool value) { }

	private void OnValueChangeMax(Color color) { }

	private void OnValueChangeMin(Color color) { }

	public virtual void SetProperty(PropertyInfo property) { }

	public virtual void SetValue(object value) { }

}

