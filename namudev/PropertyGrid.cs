using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace namudev
{
	// Token: 0x0200023F RID: 575
	public class PropertyGrid : MonoBehaviour
	{
		// Token: 0x14000048 RID: 72
		// (add) Token: 0x0600195B RID: 6491 RVA: 0x0001A1F3 File Offset: 0x000183F3
		// (remove) Token: 0x0600195C RID: 6492 RVA: 0x0001A1F5 File Offset: 0x000183F5
		public event Action<object, PropertyInfo> ValueChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x0001A1F7 File Offset: 0x000183F7
		public void AppendLabel(string text)
		{
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00023BF4 File Offset: 0x00021DF4
		public T AppendProperty<T>(string caption, object value) where T : Component
		{
			return default(T);
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x0001A1F9 File Offset: 0x000183F9
		public void Populate(object obj)
		{
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x0001A1FB File Offset: 0x000183FB
		public void Clear()
		{
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x0001A1FD File Offset: 0x000183FD
		private void Awake()
		{
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x0001A1FF File Offset: 0x000183FF
		private void AppendProperties(object obj, List<string> exclude = null)
		{
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x0001A201 File Offset: 0x00018401
		private void AppendProperty(object obj, PropertyInfo propertyInfo)
		{
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x0001A203 File Offset: 0x00018403
		private void Log(string message)
		{
		}

		// Token: 0x04000916 RID: 2326
		private GameObject targetObject;

		// Token: 0x04000917 RID: 2327
		private bool logging;

		// Token: 0x04000918 RID: 2328
		private GameObject label;

		// Token: 0x04000919 RID: 2329
		private GameObject scrollbar;

		// Token: 0x0400091A RID: 2330
		private Dictionary<Type, GameObject> itemTemplateMap;

		// Token: 0x0400091B RID: 2331
		private List<GameObject> items;

		// Token: 0x020003D8 RID: 984
		[Serializable]
		private sealed class <>c__10<T> where T : Component
		{
			// Token: 0x06002B4F RID: 11087 RVA: 0x0001D513 File Offset: 0x0001B713
			internal bool <AppendProperty>b__10_0(KeyValuePair<Type, Type> pair)
			{
				return false;
			}

			// Token: 0x04001050 RID: 4176
			public static readonly PropertyGrid.<>c__10<T> <>9;

			// Token: 0x04001051 RID: 4177
			public static Func<KeyValuePair<Type, Type>, bool> <>9__10_0;
		}

		// Token: 0x020003D9 RID: 985
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x06002B51 RID: 11089 RVA: 0x0001D51E File Offset: 0x0001B71E
			internal void <AppendProperty>b__0(object s, EventArgs e)
			{
			}

			// Token: 0x04001052 RID: 4178
			public PropertyGrid <>4__this;

			// Token: 0x04001053 RID: 4179
			public object obj;

			// Token: 0x04001054 RID: 4180
			public PropertyInfo propertyInfo;
		}
	}
}
