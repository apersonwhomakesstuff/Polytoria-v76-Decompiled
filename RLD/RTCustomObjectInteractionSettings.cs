using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B5 RID: 437
	[Serializable]
	public class RTCustomObjectInteractionSettings : Settings
	{
		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x00021C14 File Offset: 0x0001FE14
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x0001932C File Offset: 0x0001752C
		public Vector3 NoVolumeObjectSize
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x040006E4 RID: 1764
		private Vector3 _noVolumeObjectSize;
	}
}
