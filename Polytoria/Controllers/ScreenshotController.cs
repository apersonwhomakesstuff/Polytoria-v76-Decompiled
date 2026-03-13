using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	// Token: 0x02000337 RID: 823
	public class ScreenshotController : MonoBehaviour
	{
		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x060028A5 RID: 10405 RVA: 0x0001CCC9 File Offset: 0x0001AEC9
		// (set) Token: 0x060028A6 RID: 10406 RVA: 0x0001CCD0 File Offset: 0x0001AED0
		public static ScreenshotController instance
		{
			get
			{
				return ScreenshotController.<instance>k__BackingField;
			}
			private set
			{
				ScreenshotController.<instance>k__BackingField = value;
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x0001CCD8 File Offset: 0x0001AED8
		public bool Focused
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x0001CCDB File Offset: 0x0001AEDB
		private void Awake()
		{
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x0001CCDD File Offset: 0x0001AEDD
		private void Start()
		{
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x0001CCDF File Offset: 0x0001AEDF
		private void Update()
		{
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x0001CCE1 File Offset: 0x0001AEE1
		private void HideToast()
		{
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x0001CCE3 File Offset: 0x0001AEE3
		private void ShowToast()
		{
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x0001CCE5 File Offset: 0x0001AEE5
		public void Screenshot(bool hideUI)
		{
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x0001CCE7 File Offset: 0x0001AEE7
		private IEnumerator DoScreenshot(bool hideUI)
		{
			return null;
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x0001CCEA File Offset: 0x0001AEEA
		public void OpenScreenshot()
		{
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x0001CCEC File Offset: 0x0001AEEC
		public void PublishScreenshot()
		{
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x0001CCEE File Offset: 0x0001AEEE
		private IEnumerator DoPublishScreenshot()
		{
			return null;
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x0001CCF9 File Offset: 0x0001AEF9
		private void <Start>b__19_0()
		{
		}

		// Token: 0x04000DE0 RID: 3552
		private static ScreenshotController <instance>k__BackingField;

		// Token: 0x04000DE1 RID: 3553
		private RectTransform toast;

		// Token: 0x04000DE2 RID: 3554
		private RectTransform publishModal;

		// Token: 0x04000DE3 RID: 3555
		public TMP_InputField captionInput;

		// Token: 0x04000DE4 RID: 3556
		private Button publishButton;

		// Token: 0x04000DE5 RID: 3557
		private TMP_Text publishError;

		// Token: 0x04000DE6 RID: 3558
		private float toastDuration;

		// Token: 0x04000DE7 RID: 3559
		private float toastTimer;

		// Token: 0x04000DE8 RID: 3560
		private bool toastActive;

		// Token: 0x04000DE9 RID: 3561
		private string screenshotPath;

		// Token: 0x04000DEA RID: 3562
		private Sprite lastScreenshot;

		// Token: 0x04000DEB RID: 3563
		private string passphrase;

		// Token: 0x04000DEC RID: 3564
		private byte[] screenshotBytes;

		// Token: 0x0200042A RID: 1066
		private sealed class <DoPublishScreenshot>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002CFB RID: 11515 RVA: 0x0001DAF8 File Offset: 0x0001BCF8
			public <DoPublishScreenshot>d__27(int <>1__state)
			{
			}

			// Token: 0x06002CFC RID: 11516 RVA: 0x0001DB00 File Offset: 0x0001BD00
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002CFD RID: 11517 RVA: 0x0001DB02 File Offset: 0x0001BD02
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002CFE RID: 11518 RVA: 0x0001DB05 File Offset: 0x0001BD05
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000D0C RID: 3340
			// (get) Token: 0x06002CFF RID: 11519 RVA: 0x0001DB07 File Offset: 0x0001BD07
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D00 RID: 11520 RVA: 0x0001DB0A File Offset: 0x0001BD0A
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D0D RID: 3341
			// (get) Token: 0x06002D01 RID: 11521 RVA: 0x0001DB0C File Offset: 0x0001BD0C
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040011E9 RID: 4585
			private int <>1__state;

			// Token: 0x040011EA RID: 4586
			private object <>2__current;

			// Token: 0x040011EB RID: 4587
			public ScreenshotController <>4__this;

			// Token: 0x040011EC RID: 4588
			private UnityWebRequest <uwr>5__2;
		}

		// Token: 0x0200042B RID: 1067
		private sealed class <DoScreenshot>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D02 RID: 11522 RVA: 0x0001DB0F File Offset: 0x0001BD0F
			public <DoScreenshot>d__24(int <>1__state)
			{
			}

			// Token: 0x06002D03 RID: 11523 RVA: 0x0001DB17 File Offset: 0x0001BD17
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D04 RID: 11524 RVA: 0x0001DB19 File Offset: 0x0001BD19
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000D0E RID: 3342
			// (get) Token: 0x06002D05 RID: 11525 RVA: 0x0001DB1C File Offset: 0x0001BD1C
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D06 RID: 11526 RVA: 0x0001DB1F File Offset: 0x0001BD1F
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D0F RID: 3343
			// (get) Token: 0x06002D07 RID: 11527 RVA: 0x0001DB21 File Offset: 0x0001BD21
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040011ED RID: 4589
			private int <>1__state;

			// Token: 0x040011EE RID: 4590
			private object <>2__current;

			// Token: 0x040011EF RID: 4591
			public bool hideUI;

			// Token: 0x040011F0 RID: 4592
			public ScreenshotController <>4__this;

			// Token: 0x040011F1 RID: 4593
			private string <path>5__2;

			// Token: 0x040011F2 RID: 4594
			private string <filename>5__3;
		}
	}
}
