using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B9 RID: 441
	public class SceneOverlapFilter
	{
		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x000193BE File Offset: 0x000175BE
		public List<GameObjectType> AllowedObjectTypes
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x000193C1 File Offset: 0x000175C1
		public List<GameObject> IgnoreObjects
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x000193C4 File Offset: 0x000175C4
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x000193C7 File Offset: 0x000175C7
		public int LayerMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x000193C9 File Offset: 0x000175C9
		public void FilterOverlaps(List<GameObject> gameObjects)
		{
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x000193D3 File Offset: 0x000175D3
		private bool <FilterOverlaps>b__10_0(GameObject item)
		{
			return false;
		}

		// Token: 0x040006FC RID: 1788
		private List<GameObjectType> _allowedObjectTypes;

		// Token: 0x040006FD RID: 1789
		private List<GameObject> _ignoreObjects;

		// Token: 0x040006FE RID: 1790
		private int _layerMask;
	}
}
