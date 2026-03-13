using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200023D RID: 573
	public class ObjectSelectEntireHierarchy : Singleton<ObjectSelectEntireHierarchy>
	{
		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x0001A1CF File Offset: 0x000183CF
		// (set) Token: 0x0600194E RID: 6478 RVA: 0x0001A1D2 File Offset: 0x000183D2
		public bool IgnoreObjectGroups
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0001A1D4 File Offset: 0x000183D4
		public void SetActive(bool isActive)
		{
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x0001A1D6 File Offset: 0x000183D6
		private void OnPreSelectCustomize(ObjectPreSelectCustomizeInfo customizeInfo, List<GameObject> toBeSelected)
		{
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0001A1D8 File Offset: 0x000183D8
		private void OnPreDeselectCustomize(ObjectPreDeselectCustomizeInfo customizeInfo, List<GameObject> toBeDeselected)
		{
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x0001A1DA File Offset: 0x000183DA
		private Transform GetFurthestParentNotGroup(GameObject gameObj)
		{
			return null;
		}

		// Token: 0x04000911 RID: 2321
		private bool _isActive;

		// Token: 0x04000912 RID: 2322
		private bool _ignoreObjectGroups;
	}
}
