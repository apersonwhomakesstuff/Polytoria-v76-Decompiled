namespace RLD;

[DefaultMember("Item")]
public class SerializableDictionary : ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<SerializedKeyType, SerializedValueType> <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<SerializedKeyType, SerializedValueType>, Boolean> <>9__14_0; //Field offset: 0x0
		public static Func<KeyValuePair`2<SerializedKeyType, SerializedValueType>, SerializedKeyType> <>9__14_1; //Field offset: 0x0
		public static Func<KeyValuePair`2<SerializedKeyType, SerializedValueType>, SerializedValueType> <>9__14_2; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <RemoveNullKeys>b__14_0(KeyValuePair<SerializedKeyType, SerializedValueType> keyValuePair) { }

		internal SerializedKeyType <RemoveNullKeys>b__14_1(KeyValuePair<SerializedKeyType, SerializedValueType> keyValuePair) { }

		internal SerializedValueType <RemoveNullKeys>b__14_2(KeyValuePair<SerializedKeyType, SerializedValueType> keyValuePair) { }

	}

	private Dictionary<SerializedKeyType, SerializedValueType> _dictionary; //Field offset: 0x0
	[SerializeField]
	private List<SerializedKeyType> _serializedKeys; //Field offset: 0x0
	[SerializeField]
	private List<SerializedValueType> _serializedValues; //Field offset: 0x0

	public Dictionary<SerializedKeyType, SerializedValueType> Dictionary
	{
		 get { } //Length: 5
	}

	public SerializedValueType Item
	{
		 get { } //Length: 306
		 set { } //Length: 368
	}

	public SerializableDictionary`2() { }

	public void Add(SerializedKeyType key, SerializedValueType value) { }

	public void Clear() { }

	public bool ContainsKey(SerializedKeyType key) { }

	public void Copy(SerializableDictionary<SerializedKeyType, SerializedValueType> other) { }

	public Dictionary<SerializedKeyType, SerializedValueType> get_Dictionary() { }

	public SerializedValueType get_Item(SerializedKeyType index) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public void RemoveNullKeys() { }

	public void set_Item(SerializedKeyType index, SerializedValueType value) { }

}

