using System;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.UI
{
	// Token: 0x02000258 RID: 600
	public class UIStaminaBar : MonoBehaviour
	{
		// Token: 0x060019FB RID: 6651 RVA: 0x0001A3F2 File Offset: 0x000185F2
		private void Awake()
		{
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x0001A3F4 File Offset: 0x000185F4
		private void Update()
		{
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0001A3F6 File Offset: 0x000185F6
		public void SetEnabled(bool enabled)
		{
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0001A3F8 File Offset: 0x000185F8
		public void SetFill(float newFillAmount, bool exhausted)
		{
		}

		// Token: 0x04000989 RID: 2441
		private const float fadeTime = 0.3f;

		// Token: 0x0400098A RID: 2442
		private float _fadeStartTimer;

		// Token: 0x0400098B RID: 2443
		private int fadeTimerState;

		// Token: 0x0400098C RID: 2444
		private const float fadeStartTime = 0.3f;

		// Token: 0x0400098D RID: 2445
		private Image fill;

		// Token: 0x0400098E RID: 2446
		private Image cont;

		// Token: 0x0400098F RID: 2447
		private float fillAmount;

		// Token: 0x04000990 RID: 2448
		public Color FillColor;

		// Token: 0x04000991 RID: 2449
		public Color FillExhaustedColor;

		// Token: 0x04000992 RID: 2450
		private float alpha;
	}
}
