namespace namudev;

public class PropertyGrid : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__10
	{
		public static readonly <>c__10<T> <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<Type, Type>, Boolean> <>9__10_0; //Field offset: 0x0

		private static <>c__10`1() { }

		public <>c__10`1() { }

		internal bool <AppendProperty>b__10_0(KeyValuePair<Type, Type> pair) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public PropertyGrid <>4__this; //Field offset: 0x10
		public object obj; //Field offset: 0x18
		public PropertyInfo propertyInfo; //Field offset: 0x20

		public <>c__DisplayClass15_0() { }

		internal void <AppendProperty>b__0(object s, EventArgs e) { }

	}

	[SerializeField]
	private GameObject targetObject; //Field offset: 0x20
	[SerializeField]
	private bool logging; //Field offset: 0x28
	private GameObject label; //Field offset: 0x30
	private GameObject scrollbar; //Field offset: 0x38
	private Dictionary<Type, GameObject> itemTemplateMap; //Field offset: 0x40
	private List<GameObject> items; //Field offset: 0x48
	[CompilerGenerated]
	private Action<Object, PropertyInfo> ValueChanged; //Field offset: 0x50

	public event Action<Object, PropertyInfo> ValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public PropertyGrid() { }

	[CompilerGenerated]
	public void add_ValueChanged(Action<Object, PropertyInfo> value) { }

	public void AppendLabel(string text) { }

	private void AppendProperties(object obj, List<String> exclude = null) { }

	public T AppendProperty(string caption, object value) { }

	private void AppendProperty(object obj, PropertyInfo propertyInfo) { }

	private void Awake() { }

	public void Clear() { }

	private void Log(string message) { }

	public void Populate(object obj) { }

	[CompilerGenerated]
	public void remove_ValueChanged(Action<Object, PropertyInfo> value) { }

}

