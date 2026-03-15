namespace namudev;

public class PropertyGridSelector : MonoBehaviour
{
	private static readonly Color highlight; //Field offset: 0x0
	[SerializeField]
	private GameObject propertyGrid; //Field offset: 0x20
	private GameObject selected; //Field offset: 0x28
	private Color color; //Field offset: 0x30

	private static PropertyGridSelector() { }

	public PropertyGridSelector() { }

	private void ClearSelection() { }

	private bool IsCursorOverUi() { }

	private void Select(GameObject gameObject) { }

	private void Update() { }

}

