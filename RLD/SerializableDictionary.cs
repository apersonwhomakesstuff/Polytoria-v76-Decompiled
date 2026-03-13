using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001C0 RID: 448
	[Serializable]
	public class SerializableDictionary<SerializedKeyType, SerializedValueType> : ISerializationCallbackReceiver
	{
		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x0001943E File Offset: 0x0001763E
		public Dictionary<SerializedKeyType, SerializedValueType> Dictionary
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x00021C5C File Offset: 0x0001FE5C
		// (set) Token: 0x06001393 RID: 5011 RVA: 0x00019441 File Offset: 0x00017641
		public SerializedValueType Item
		{
			get
			{
				return default(SerializedValueType);
			}
			set
			{
			}
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00019443 File Offset: 0x00017643
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00019445 File Offset: 0x00017645
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00019447 File Offset: 0x00017647
		public void Clear()
		{
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00019449 File Offset: 0x00017649
		public void Add(SerializedKeyType key, SerializedValueType value)
		{
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0001944B File Offset: 0x0001764B
		public bool ContainsKey(SerializedKeyType key)
		{
			return false;
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0001944E File Offset: 0x0001764E
		public void Copy(SerializableDictionary<SerializedKeyType, SerializedValueType> other)
		{
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00019450 File Offset: 0x00017650
		public void RemoveNullKeys()
		{
		}

		// Token: 0x04000710 RID: 1808
		private Dictionary<SerializedKeyType, SerializedValueType> _dictionary;

		// Token: 0x04000711 RID: 1809
		private List<SerializedKeyType> _serializedKeys;

		// Token: 0x04000712 RID: 1810
		private List<SerializedValueType> _serializedValues;

		// Token: 0x020003A1 RID: 929
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002AE7 RID: 10983 RVA: 0x0001D3AC File Offset: 0x0001B5AC
			internal bool <RemoveNullKeys>b__14_0(KeyValuePair<SerializedKeyType, SerializedValueType> keyValuePair)
			{
				return false;
			}

			// Token: 0x06002AE8 RID: 10984 RVA: 0x000267D8 File Offset: 0x000249D8
			internal SerializedKeyType <RemoveNullKeys>b__14_1(KeyValuePair<SerializedKeyType, SerializedValueType> keyValuePair)
			{
				return default(SerializedKeyType);
			}

			// Token: 0x06002AE9 RID: 10985 RVA: 0x000267F0 File Offset: 0x000249F0
			internal SerializedValueType <RemoveNullKeys>b__14_2(KeyValuePair<SerializedKeyType, SerializedValueType> keyValuePair)
			{
				return default(SerializedValueType);
			}

			// Token: 0x04000F84 RID: 3972
			public static readonly SerializableDictionary<SerializedKeyType, SerializedValueType>.<>c <>9;

			// Token: 0x04000F85 RID: 3973
			public static Func<KeyValuePair<SerializedKeyType, SerializedValueType>, bool> <>9__14_0;

			// Token: 0x04000F86 RID: 3974
			public static Func<KeyValuePair<SerializedKeyType, SerializedValueType>, SerializedKeyType> <>9__14_1;

			// Token: 0x04000F87 RID: 3975
			public static Func<KeyValuePair<SerializedKeyType, SerializedValueType>, SerializedValueType> <>9__14_2;
		}
	}
}
