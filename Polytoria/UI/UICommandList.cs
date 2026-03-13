using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.UI
{
	// Token: 0x02000255 RID: 597
	public class UICommandList : MonoBehaviour
	{
		// Token: 0x060019EB RID: 6635 RVA: 0x0001A3BF File Offset: 0x000185BF
		private void Awake()
		{
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0001A3C1 File Offset: 0x000185C1
		private void Update()
		{
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0001A3C3 File Offset: 0x000185C3
		public void SetActive(bool active)
		{
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x0001A3C5 File Offset: 0x000185C5
		public void AddObject(SlashCommand cmd)
		{
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x0001A3C7 File Offset: 0x000185C7
		public void Search(string Text)
		{
		}

		// Token: 0x0400096B RID: 2411
		public static bool IsActive;

		// Token: 0x0400096C RID: 2412
		public static SlashCommand ActiveCommand;

		// Token: 0x0400096D RID: 2413
		public static bool ActiveCommandFilled;

		// Token: 0x0400096E RID: 2414
		private Transform container;

		// Token: 0x0400096F RID: 2415
		private Transform listContainer;

		// Token: 0x04000970 RID: 2416
		private Transform emptyContainer;

		// Token: 0x04000971 RID: 2417
		private ScrollRect scrollRect;

		// Token: 0x04000972 RID: 2418
		public SlashCommand[] commands;

		// Token: 0x04000973 RID: 2419
		private List<Transform> commandObjects;

		// Token: 0x04000974 RID: 2420
		private int curActive;
	}
}
