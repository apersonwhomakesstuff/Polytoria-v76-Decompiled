using System;
using UnityEngine;

namespace Polytoria.Helpers
{
	// Token: 0x0200026B RID: 619
	public class CloseOnClickOutside : MonoBehaviour
	{
		// Token: 0x06001A96 RID: 6806 RVA: 0x0001A5B6 File Offset: 0x000187B6
		private void Update()
		{
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x0001A5B8 File Offset: 0x000187B8
		private bool ClickingSelfOrChild()
		{
			return false;
		}

		// Token: 0x040009A8 RID: 2472
		private bool close;
	}
}
