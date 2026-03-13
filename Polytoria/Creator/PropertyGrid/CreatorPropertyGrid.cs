using System;
using System.Collections.Generic;
using System.Reflection;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Creator.PropertyGrid
{
	// Token: 0x02000314 RID: 788
	public class CreatorPropertyGrid : MonoBehaviour
	{
		// Token: 0x06002788 RID: 10120 RVA: 0x0001C979 File Offset: 0x0001AB79
		private void Awake()
		{
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x0001C97B File Offset: 0x0001AB7B
		public void SetPropertyGridItems(List<Instance> instances)
		{
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x0001C97D File Offset: 0x0001AB7D
		public void Clear()
		{
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x0001C97F File Offset: 0x0001AB7F
		private void AddPropertyItem(PropertyInfo property)
		{
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x0001C981 File Offset: 0x0001AB81
		private void OnValueChanged(PropertyInfo property, object value)
		{
		}

		// Token: 0x04000D41 RID: 3393
		private Vector2 scrollPosition;

		// Token: 0x04000D42 RID: 3394
		private RectTransform content;

		// Token: 0x04000D43 RID: 3395
		private Dictionary<string, PropertyGridItem> items;

		// Token: 0x04000D44 RID: 3396
		private List<Instance> instances;

		// Token: 0x02000413 RID: 1043
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06002C90 RID: 11408 RVA: 0x0001D98D File Offset: 0x0001BB8D
			internal void <AddPropertyItem>b__0(object value)
			{
			}

			// Token: 0x04001177 RID: 4471
			public CreatorPropertyGrid <>4__this;

			// Token: 0x04001178 RID: 4472
			public PropertyInfo property;
		}
	}
}
