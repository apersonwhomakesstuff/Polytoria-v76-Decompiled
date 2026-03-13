using System;
using TMPro;
using UnityEngine;

namespace Polytoria.UI
{
	// Token: 0x02000257 RID: 599
	public class UISpeechBubble : MonoBehaviour
	{
		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x0001A3E1 File Offset: 0x000185E1
		// (set) Token: 0x060019F7 RID: 6647 RVA: 0x0001A3E4 File Offset: 0x000185E4
		public string Message
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x0001A3E6 File Offset: 0x000185E6
		private void Awake()
		{
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0001A3E8 File Offset: 0x000185E8
		private void Update()
		{
		}

		// Token: 0x04000980 RID: 2432
		private RectTransform chatContentRect;

		// Token: 0x04000981 RID: 2433
		private RectTransform bubbleRect;

		// Token: 0x04000982 RID: 2434
		private TMP_Text chatText;

		// Token: 0x04000983 RID: 2435
		private string message;

		// Token: 0x04000984 RID: 2436
		public Vector2 Padding;

		// Token: 0x04000985 RID: 2437
		public float DisplayTime;

		// Token: 0x04000986 RID: 2438
		private float targetOpacity;

		// Token: 0x04000987 RID: 2439
		private float timer;

		// Token: 0x04000988 RID: 2440
		private CanvasGroup canvasGroup;
	}
}
