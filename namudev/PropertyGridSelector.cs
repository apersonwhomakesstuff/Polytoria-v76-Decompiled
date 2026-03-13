using System;
using UnityEngine;

namespace namudev
{
	// Token: 0x02000249 RID: 585
	public class PropertyGridSelector : MonoBehaviour
	{
		// Token: 0x060019A6 RID: 6566 RVA: 0x0001A2E4 File Offset: 0x000184E4
		private void Update()
		{
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x0001A2E6 File Offset: 0x000184E6
		private bool IsCursorOverUi()
		{
			return false;
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x0001A2E9 File Offset: 0x000184E9
		private void Select(GameObject gameObject)
		{
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x0001A2EB File Offset: 0x000184EB
		private void ClearSelection()
		{
		}

		// Token: 0x0400093A RID: 2362
		private static readonly Color highlight;

		// Token: 0x0400093B RID: 2363
		private GameObject propertyGrid;

		// Token: 0x0400093C RID: 2364
		private GameObject selected;

		// Token: 0x0400093D RID: 2365
		private Color color;
	}
}
