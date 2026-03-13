using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200019D RID: 413
	[Serializable]
	public class RTPrefabLib
	{
		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06001228 RID: 4648 RVA: 0x00019039 File Offset: 0x00017239
		// (remove) Token: 0x06001229 RID: 4649 RVA: 0x0001903B File Offset: 0x0001723B
		public event PrefabCreatedInLibHandler PrefabCreated
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x0600122A RID: 4650 RVA: 0x0001903D File Offset: 0x0001723D
		// (remove) Token: 0x0600122B RID: 4651 RVA: 0x0001903F File Offset: 0x0001723F
		public event PrefabRemovedFromLibHandler PrefabRemoved
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x0600122C RID: 4652 RVA: 0x00019041 File Offset: 0x00017241
		// (remove) Token: 0x0600122D RID: 4653 RVA: 0x00019043 File Offset: 0x00017243
		public event PrefabLibClearedHandler Cleared
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00019045 File Offset: 0x00017245
		public int NumPrefabs
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00019048 File Offset: 0x00017248
		// (set) Token: 0x06001230 RID: 4656 RVA: 0x0001904B File Offset: 0x0001724B
		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0001904D File Offset: 0x0001724D
		public RTPrefab CreatePrefab(GameObject unityPrefab, Texture2D prefabPreview)
		{
			return null;
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00019050 File Offset: 0x00017250
		public RTPrefab CreatePrefabFromSceneObject(GameObject sceneObject)
		{
			return null;
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00019053 File Offset: 0x00017253
		public List<RTPrefab> CreatePrefabsFromSceneObjects(List<GameObject> sceneObjects)
		{
			return null;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00019056 File Offset: 0x00017256
		public void Remove(int prefabIndex)
		{
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00019058 File Offset: 0x00017258
		public void Remove(RTPrefab prefab)
		{
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0001905A File Offset: 0x0001725A
		public void Clear()
		{
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0001905C File Offset: 0x0001725C
		public bool Contains(GameObject unityPrefab)
		{
			return false;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0001905F File Offset: 0x0001725F
		public bool Contains(RTPrefab prefab)
		{
			return false;
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00019062 File Offset: 0x00017262
		public int GetPrefabIndex(RTPrefab prefab)
		{
			return 0;
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00019065 File Offset: 0x00017265
		public RTPrefab GetPrefab(int prefabIndex)
		{
			return null;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00019068 File Offset: 0x00017268
		public RTPrefab GetPrefab(GameObject unityPrefab)
		{
			return null;
		}

		// Token: 0x04000672 RID: 1650
		private string _name;

		// Token: 0x04000673 RID: 1651
		private List<RTPrefab> _prefabs;

		// Token: 0x02000394 RID: 916
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06002AC1 RID: 10945 RVA: 0x0001D357 File Offset: 0x0001B557
			internal bool <Contains>b__0(RTPrefab item)
			{
				return false;
			}

			// Token: 0x04000F77 RID: 3959
			public GameObject unityPrefab;
		}

		// Token: 0x02000395 RID: 917
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x06002AC3 RID: 10947 RVA: 0x0001D362 File Offset: 0x0001B562
			internal bool <GetPrefab>b__0(RTPrefab item)
			{
				return false;
			}

			// Token: 0x04000F78 RID: 3960
			public GameObject unityPrefab;
		}
	}
}
