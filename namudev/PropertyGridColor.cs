namespace namudev;

public class PropertyGridColor : PropertyGridItem<Color>
{
	private GameObject caption; //Field offset: 0x30
	private GameObject inputFieldR; //Field offset: 0x38
	private GameObject inputFieldG; //Field offset: 0x40
	private GameObject inputFieldB; //Field offset: 0x48
	private GameObject inputFieldA; //Field offset: 0x50
	private GameObject inputFieldHex; //Field offset: 0x58
	private Image colorDisplayer; //Field offset: 0x60
	private Button colorDisplayerBtn; //Field offset: 0x68

	public PropertyGridColor() { }

	protected virtual void Awake() { }

	private void OnColorBtnClick() { }

	private void OnDestroy() { }

	private void OnEndEditA(string str) { }

	private void OnEndEditB(string str) { }

	private void OnEndEditG(string str) { }

	private void OnEndEditHex(string str) { }

	private void OnEndEditR(string str) { }

	private void OnValueChange(Color color) { }

	private void OnValueChangeA(string str) { }

	private void OnValueChangeB(string str) { }

	private void OnValueChangeG(string str) { }

	private void OnValueChangeHex(string hexColor) { }

	private void OnValueChangeR(string str) { }

	private void Start() { }

}

