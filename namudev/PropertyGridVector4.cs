namespace namudev;

public class PropertyGridVector4 : PropertyGridItem<Vector4>
{
	private GameObject caption; //Field offset: 0x30
	private GameObject inputFieldX; //Field offset: 0x38
	private GameObject inputFieldY; //Field offset: 0x40
	private GameObject inputFieldZ; //Field offset: 0x48
	private GameObject inputFieldW; //Field offset: 0x50

	public PropertyGridVector4() { }

	protected virtual void Awake() { }

	private void OnEndEditW(string str) { }

	private void OnEndEditX(string str) { }

	private void OnEndEditY(string str) { }

	private void OnEndEditZ(string str) { }

	private void OnValueChangeW(string str) { }

	private void OnValueChangeX(string str) { }

	private void OnValueChangeY(string str) { }

	private void OnValueChangeZ(string str) { }

	private void Start() { }

}

