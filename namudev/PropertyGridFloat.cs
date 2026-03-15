namespace namudev;

public class PropertyGridFloat : PropertyGridItem<Single>
{
	private GameObject caption; //Field offset: 0x30
	private GameObject controls; //Field offset: 0x38

	public PropertyGridFloat() { }

	protected virtual void Awake() { }

	private void OnEndEdit(string str) { }

	private void OnValueChange(string str) { }

	private void Start() { }

}

