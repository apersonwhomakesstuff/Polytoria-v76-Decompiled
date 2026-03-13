using System;
using System.Reflection;
using UnityEngine;

namespace namudev
{
	// Token: 0x02000240 RID: 576
	public class PropertyGridBinding : MonoBehaviour
	{
		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06001966 RID: 6502 RVA: 0x0001A20D File Offset: 0x0001840D
		// (remove) Token: 0x06001967 RID: 6503 RVA: 0x0001A20F File Offset: 0x0001840F
		public event EventHandler ValueChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x0001A211 File Offset: 0x00018411
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x0001A219 File Offset: 0x00018419
		public string Caption
		{
			get
			{
				return this.<Caption>k__BackingField;
			}
			private set
			{
				this.<Caption>k__BackingField = value;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x0001A222 File Offset: 0x00018422
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x0001A22A File Offset: 0x0001842A
		public object Value
		{
			get
			{
				return this.<Value>k__BackingField;
			}
			private set
			{
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x0001A233 File Offset: 0x00018433
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x0001A23B File Offset: 0x0001843B
		public Type ValueType
		{
			get
			{
				return this.<ValueType>k__BackingField;
			}
			private set
			{
				this.<ValueType>k__BackingField = value;
			}
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x0001A244 File Offset: 0x00018444
		public void Initialize(string caption, object value, Type valueType)
		{
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x0001A246 File Offset: 0x00018446
		public void Initialize(object targetObject, PropertyInfo propertyInfo)
		{
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x0001A248 File Offset: 0x00018448
		public void SetValue(object value)
		{
		}

		// Token: 0x0400091E RID: 2334
		private string <Caption>k__BackingField;

		// Token: 0x0400091F RID: 2335
		private object <Value>k__BackingField;

		// Token: 0x04000920 RID: 2336
		private Type <ValueType>k__BackingField;

		// Token: 0x04000921 RID: 2337
		private object targetObject;

		// Token: 0x04000922 RID: 2338
		private PropertyInfo propertyInfo;
	}
}
