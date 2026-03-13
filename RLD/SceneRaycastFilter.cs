using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001BB RID: 443
	public class SceneRaycastFilter
	{
		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x000193D6 File Offset: 0x000175D6
		public List<GameObjectType> AllowedObjectTypes
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x000193D9 File Offset: 0x000175D9
		public List<GameObject> IgnoreObjects
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x000193DC File Offset: 0x000175DC
		// (set) Token: 0x06001376 RID: 4982 RVA: 0x000193DF File Offset: 0x000175DF
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

		// Token: 0x06001377 RID: 4983 RVA: 0x000193E1 File Offset: 0x000175E1
		public void FilterHits(List<GameObjectRayHit> hits)
		{
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x000193EB File Offset: 0x000175EB
		private bool <FilterHits>b__10_0(GameObjectRayHit item)
		{
			return false;
		}

		// Token: 0x04000702 RID: 1794
		private List<GameObjectType> _allowedObjectTypes;

		// Token: 0x04000703 RID: 1795
		private List<GameObject> _ignoreObjects;

		// Token: 0x04000704 RID: 1796
		private int _layerMask;
	}
}
