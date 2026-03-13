using System;
using System.Reflection;
using UnityEngine;

namespace Polytoria.Creator.PropertyGrid
{
	// Token: 0x02000315 RID: 789
	public abstract class PropertyGridItem : MonoBehaviour
	{
		// Token: 0x14000052 RID: 82
		// (add) Token: 0x0600278E RID: 10126 RVA: 0x0001C98B File Offset: 0x0001AB8B
		// (remove) Token: 0x0600278F RID: 10127 RVA: 0x0001C98D File Offset: 0x0001AB8D
		public event Action<object> PropertyChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x0001C98F File Offset: 0x0001AB8F
		public virtual void SetProperty(PropertyInfo property)
		{
		}

		// Token: 0x06002791 RID: 10129
		public abstract void SetValue(object value);

		// Token: 0x06002792 RID: 10130 RVA: 0x0001C991 File Offset: 0x0001AB91
		protected virtual void InvokeValueChanged(object value)
		{
		}

		// Token: 0x04000D46 RID: 3398
		private PropertyInfo property;

		// Token: 0x04000D47 RID: 3399
		protected object currentValue;

		// Token: 0x04000D48 RID: 3400
		protected bool editingMultipleValues;
	}
}
