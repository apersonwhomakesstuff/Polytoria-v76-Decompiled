using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RLD
{
	// Token: 0x020001A2 RID: 418
	public class RTPrefabScrollView : MonoBehaviour
	{
		// Token: 0x1400002C RID: 44
		// (add) Token: 0x0600127D RID: 4733 RVA: 0x00019115 File Offset: 0x00017315
		// (remove) Token: 0x0600127E RID: 4734 RVA: 0x00019117 File Offset: 0x00017317
		public event RTPrefabScrollView.PrefabPreviewClickedHandler PrefabPreviewClicked
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x0600127F RID: 4735 RVA: 0x00019119 File Offset: 0x00017319
		// (remove) Token: 0x06001280 RID: 4736 RVA: 0x0001911B File Offset: 0x0001731B
		public event RTPrefabScrollView.PrefabPreviewHoverEnterHandler PrefabPreviewHoverEnter
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06001281 RID: 4737 RVA: 0x0001911D File Offset: 0x0001731D
		// (remove) Token: 0x06001282 RID: 4738 RVA: 0x0001911F File Offset: 0x0001731F
		public event RTPrefabScrollView.PrefabPreviewHoverExitHandler PrefabPreviewHoverExit
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00019121 File Offset: 0x00017321
		public void AddPrefabPreview(RTPrefab prefab)
		{
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00019123 File Offset: 0x00017323
		public void FilterPrefabsByName(string name)
		{
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00019125 File Offset: 0x00017325
		public void ClearPreviews()
		{
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00019127 File Offset: 0x00017327
		public void SyncWithLib(RTPrefabLib prefabLib)
		{
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00019129 File Offset: 0x00017329
		private void Awake()
		{
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0001912B File Offset: 0x0001732B
		private void prefabNames(List<string> names)
		{
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0001912D File Offset: 0x0001732D
		private void OnPreviewButtonClicked()
		{
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0001912F File Offset: 0x0001732F
		private void OnPrefabPreviewHoverEnter(RTPrefab prefab)
		{
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00019131 File Offset: 0x00017331
		private void OnPrefabPreviewHoverExit(RTPrefab prefab)
		{
		}

		// Token: 0x04000689 RID: 1673
		private ObjectPool _previewButtonPool;

		// Token: 0x0400068A RID: 1674
		private GameObject _gridObject;

		// Token: 0x0400068B RID: 1675
		private GridLayoutGroup _gridLayoutGroup;

		// Token: 0x0400068C RID: 1676
		private List<RTPrefabPreviewButton> _activePreviewButtons;

		// Token: 0x0400068D RID: 1677
		private List<string> _prefabSearchNames;

		// Token: 0x0400068E RID: 1678
		private List<string> _prefabSearchMatches;

		// Token: 0x0200039B RID: 923
		// (Invoke) Token: 0x06002AD4 RID: 10964
		public delegate void PrefabPreviewClickedHandler(RTPrefab prefab);

		// Token: 0x0200039C RID: 924
		// (Invoke) Token: 0x06002AD8 RID: 10968
		public delegate void PrefabPreviewHoverEnterHandler(RTPrefab prefab);

		// Token: 0x0200039D RID: 925
		// (Invoke) Token: 0x06002ADC RID: 10972
		public delegate void PrefabPreviewHoverExitHandler(RTPrefab prefab);
	}
}
