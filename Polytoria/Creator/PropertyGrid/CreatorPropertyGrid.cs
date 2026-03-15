namespace Polytoria.Creator.PropertyGrid;

public class CreatorPropertyGrid : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public CreatorPropertyGrid <>4__this; //Field offset: 0x10
		public PropertyInfo property; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <AddPropertyItem>b__0(object value) { }

	}

	private Vector2 scrollPosition; //Field offset: 0x20
	private RectTransform content; //Field offset: 0x28
	private Dictionary<String, PropertyGridItem> items; //Field offset: 0x30
	private List<Instance> instances; //Field offset: 0x38

	public CreatorPropertyGrid() { }

	private void AddPropertyItem(PropertyInfo property) { }

	private void Awake() { }

	public void Clear() { }

	private void OnValueChanged(PropertyInfo property, object value) { }

	public void SetPropertyGridItems(List<Instance> instances) { }

}

