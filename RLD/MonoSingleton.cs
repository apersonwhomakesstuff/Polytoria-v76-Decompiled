using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001F2 RID: 498
	public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x0002366C File Offset: 0x0002186C
		public static T Get
		{
			get
			{
				return default(T);
			}
		}

		// Token: 0x04000816 RID: 2070
		private static object _singletonLock;

		// Token: 0x04000817 RID: 2071
		private static T _instance;
	}
}
