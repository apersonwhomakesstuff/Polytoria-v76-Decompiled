using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001A0 RID: 416
	public class RTPrefabLibDbUI : MonoBehaviour
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x000190D7 File Offset: 0x000172D7
		public RTActiveLibDropDown ActiveLibDropDown
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x000190DA File Offset: 0x000172DA
		public RTPrefabScrollView PrefabScrollView
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x000190DD File Offset: 0x000172DD
		public RTHoveredPrefabNameLabel HoveredPrefabNameLabel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x000190E0 File Offset: 0x000172E0
		public RTPrefabSearch PrefabSearch
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x000190E3 File Offset: 0x000172E3
		private void Awake()
		{
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x000190E5 File Offset: 0x000172E5
		private void OnPrefabPreviewHoverEnter(RTPrefab prefab)
		{
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x000190E7 File Offset: 0x000172E7
		private void OnPrefabPreviewHoverExit(RTPrefab prefab)
		{
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x000190E9 File Offset: 0x000172E9
		private void OnPrefabSearchFieldValueChanged(string value)
		{
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x000190F3 File Offset: 0x000172F3
		private void <Awake>b__12_0(string p)
		{
		}

		// Token: 0x0400067E RID: 1662
		private RTActiveLibDropDown _activeLibDropDown;

		// Token: 0x0400067F RID: 1663
		private RTPrefabScrollView _prefabScrollView;

		// Token: 0x04000680 RID: 1664
		private RTHoveredPrefabNameLabel _hoveredPrefabNameLabel;

		// Token: 0x04000681 RID: 1665
		private RTPrefabSearch _prefabSearch;
	}
}
