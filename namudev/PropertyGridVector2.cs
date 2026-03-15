namespace namudev;

public class PropertyGridVector2 : PropertyGridItem<Vector2>
{
	private GameObject caption; //Field offset: 0x30
	private GameObject inputFieldX; //Field offset: 0x38
	private GameObject inputFieldY; //Field offset: 0x40

	public PropertyGridVector2() { }

	protected virtual void Awake() { }

	private void OnEndEditX(string str) { }

	private void OnEndEditY(string str) { }

	private void OnValueChangeX(string str) { }

	private void OnValueChangeY(string str) { }

	private void Start() { }

}

