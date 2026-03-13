using System;
using UnityEngine;

namespace namudev
{
	// Token: 0x02000247 RID: 583
	public abstract class PropertyGridItem<T> : MonoBehaviour
	{
		// Token: 0x1400004A RID: 74
		// (add) Token: 0x06001994 RID: 6548 RVA: 0x0001A2B4 File Offset: 0x000184B4
		// (remove) Token: 0x06001995 RID: 6549 RVA: 0x0001A2B6 File Offset: 0x000184B6
		public event EventHandler ValueChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x0001A2B8 File Offset: 0x000184B8
		public string Caption
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x00023C0C File Offset: 0x00021E0C
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x0001A2BB File Offset: 0x000184BB
		public T Value
		{
			get
			{
				return default(T);
			}
			protected set
			{
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x0001A2BD File Offset: 0x000184BD
		public Type ValueType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0001A2C0 File Offset: 0x000184C0
		protected virtual void Awake()
		{
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0001A2CA File Offset: 0x000184CA
		private void <Awake>b__11_0(object o, EventArgs e)
		{
		}

		// Token: 0x04000935 RID: 2357
		private PropertyGridBinding binding;
	}
}
