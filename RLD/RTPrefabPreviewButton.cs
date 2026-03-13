using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace RLD
{
	// Token: 0x020001A1 RID: 417
	public class RTPrefabPreviewButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06001271 RID: 4721 RVA: 0x000190F5 File Offset: 0x000172F5
		// (remove) Token: 0x06001272 RID: 4722 RVA: 0x000190F7 File Offset: 0x000172F7
		public event RTPrefabPreviewButton.HoverEnterHandler HoverEnter
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06001273 RID: 4723 RVA: 0x000190F9 File Offset: 0x000172F9
		// (remove) Token: 0x06001274 RID: 4724 RVA: 0x000190FB File Offset: 0x000172FB
		public event RTPrefabPreviewButton.HoverExitHandler HoverExit
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x000190FD File Offset: 0x000172FD
		// (set) Token: 0x06001276 RID: 4726 RVA: 0x00019100 File Offset: 0x00017300
		public RTPrefab Prefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x00019102 File Offset: 0x00017302
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x00019105 File Offset: 0x00017305
		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00019107 File Offset: 0x00017307
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00019109 File Offset: 0x00017309
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0001910B File Offset: 0x0001730B
		private void OnEnable()
		{
		}

		// Token: 0x04000684 RID: 1668
		private Text _text;

		// Token: 0x04000685 RID: 1669
		private RTPrefab _prefab;

		// Token: 0x02000399 RID: 921
		// (Invoke) Token: 0x06002ACC RID: 10956
		public delegate void HoverEnterHandler(RTPrefab prefab);

		// Token: 0x0200039A RID: 922
		// (Invoke) Token: 0x06002AD0 RID: 10960
		public delegate void HoverExitHandler(RTPrefab prefab);
	}
}
