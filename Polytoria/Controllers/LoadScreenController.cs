using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	// Token: 0x02000330 RID: 816
	public class LoadScreenController : MonoBehaviour
	{
		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06002870 RID: 10352 RVA: 0x0001CBEB File Offset: 0x0001ADEB
		// (set) Token: 0x06002871 RID: 10353 RVA: 0x0001CBF3 File Offset: 0x0001ADF3
		public bool IsLoadingMap
		{
			get
			{
				return this.<IsLoadingMap>k__BackingField;
			}
			set
			{
				this.<IsLoadingMap>k__BackingField = value;
			}
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x0001CBFC File Offset: 0x0001ADFC
		private void Awake()
		{
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x0001CBFE File Offset: 0x0001ADFE
		private void Start()
		{
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x0001CC00 File Offset: 0x0001AE00
		public void GameLoaded()
		{
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x0001CC02 File Offset: 0x0001AE02
		public void SetStatus(string status)
		{
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x0001CC04 File Offset: 0x0001AE04
		public void SetGameInfo(string name)
		{
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x0001CC06 File Offset: 0x0001AE06
		private void Update()
		{
		}

		// Token: 0x04000DC8 RID: 3528
		public static LoadScreenController singleton;

		// Token: 0x04000DC9 RID: 3529
		private Image progressBar;

		// Token: 0x04000DCA RID: 3530
		private GameObject progressBarContainer;

		// Token: 0x04000DCB RID: 3531
		private TMP_Text gameName;

		// Token: 0x04000DCC RID: 3532
		private TMP_Text loadingStatus;

		// Token: 0x04000DCD RID: 3533
		private bool <IsLoadingMap>k__BackingField;
	}
}
