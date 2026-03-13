using System;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000308 RID: 776
	public class Vector3ValueProxy : ValueBaseProxy
	{
		// Token: 0x0600272C RID: 10028 RVA: 0x0001C861 File Offset: 0x0001AA61
		public Vector3ValueProxy(Vector3Value target) : base(null)
		{
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x00025FC0 File Offset: 0x000241C0
		// (set) Token: 0x0600272E RID: 10030 RVA: 0x0001C86A File Offset: 0x0001AA6A
		public Vector3 Value
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x04000D34 RID: 3380
		private readonly Vector3Value vector3Value;
	}
}
