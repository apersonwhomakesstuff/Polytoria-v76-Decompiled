using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.UI
{
	// Token: 0x02000256 RID: 598
	public class UICommandListItem : MonoBehaviour
	{
		// Token: 0x060019F1 RID: 6641 RVA: 0x0001A3D1 File Offset: 0x000185D1
		private void Awake()
		{
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x0001A3D3 File Offset: 0x000185D3
		public void SetCommand(SlashCommand cmd)
		{
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x0001A3D5 File Offset: 0x000185D5
		public void SetActive(bool active)
		{
		}

		// Token: 0x04000975 RID: 2421
		private static List<Sprite> commandIcons;

		// Token: 0x04000976 RID: 2422
		private static List<Sprite> commandIconsActive;

		// Token: 0x04000977 RID: 2423
		private static Sprite contSprite;

		// Token: 0x04000978 RID: 2424
		private static Sprite contSpriteActive;

		// Token: 0x04000979 RID: 2425
		private static bool loaded;

		// Token: 0x0400097A RID: 2426
		private Image cont;

		// Token: 0x0400097B RID: 2427
		private Image icon;

		// Token: 0x0400097C RID: 2428
		private TMP_Text nameT;

		// Token: 0x0400097D RID: 2429
		private TMP_Text description;

		// Token: 0x0400097E RID: 2430
		private SlashCommand cmd;

		// Token: 0x0400097F RID: 2431
		private bool active;
	}
}
