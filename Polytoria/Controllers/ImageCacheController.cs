using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	// Token: 0x0200032A RID: 810
	public class ImageCacheController : MonoBehaviour
	{
		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x0001CBA2 File Offset: 0x0001ADA2
		// (set) Token: 0x0600285E RID: 10334 RVA: 0x0001CBA9 File Offset: 0x0001ADA9
		public static ImageCacheController Instance
		{
			get
			{
				return ImageCacheController.<Instance>k__BackingField;
			}
			private set
			{
				ImageCacheController.<Instance>k__BackingField = value;
			}
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x0001CBB1 File Offset: 0x0001ADB1
		private void Awake()
		{
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x0001CBB3 File Offset: 0x0001ADB3
		public void GetImage(ImageCacheKey key, Action<ImageCacheKey, ImageCacheEntry> callback)
		{
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x0001CBB5 File Offset: 0x0001ADB5
		private IEnumerator WaitForImage(ImageCacheKey key, Action<ImageCacheKey, ImageCacheEntry> callback)
		{
			return null;
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x0001CBB8 File Offset: 0x0001ADB8
		private void Update()
		{
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x0001CBBA File Offset: 0x0001ADBA
		private IEnumerator LoadImage(ImageCacheKey key, int tries = 0)
		{
			return null;
		}

		// Token: 0x04000D9A RID: 3482
		private static ImageCacheController <Instance>k__BackingField;

		// Token: 0x04000D9B RID: 3483
		private static Dictionary<ImageCacheKey, ImageCacheEntry> cache;

		// Token: 0x04000D9C RID: 3484
		private Queue<ImageCacheKey> loadQueue;

		// Token: 0x04000D9D RID: 3485
		private Texture2D fallback;

		// Token: 0x04000D9E RID: 3486
		private bool loading;

		// Token: 0x02000421 RID: 1057
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002CD9 RID: 11481 RVA: 0x0001DA8F File Offset: 0x0001BC8F
			internal bool <LoadImage>b__12_0(Color32 c)
			{
				return false;
			}

			// Token: 0x040011BE RID: 4542
			public static readonly ImageCacheController.<>c <>9;

			// Token: 0x040011BF RID: 4543
			public static Func<Color32, bool> <>9__12_0;
		}

		// Token: 0x02000422 RID: 1058
		private sealed class <LoadImage>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002CDA RID: 11482 RVA: 0x0001DA92 File Offset: 0x0001BC92
			public <LoadImage>d__12(int <>1__state)
			{
			}

			// Token: 0x06002CDB RID: 11483 RVA: 0x0001DA9A File Offset: 0x0001BC9A
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002CDC RID: 11484 RVA: 0x0001DA9C File Offset: 0x0001BC9C
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002CDD RID: 11485 RVA: 0x0001DA9F File Offset: 0x0001BC9F
			private void <>m__Finally1()
			{
			}

			// Token: 0x06002CDE RID: 11486 RVA: 0x0001DAA1 File Offset: 0x0001BCA1
			private void <>m__Finally2()
			{
			}

			// Token: 0x17000D04 RID: 3332
			// (get) Token: 0x06002CDF RID: 11487 RVA: 0x0001DAA3 File Offset: 0x0001BCA3
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002CE0 RID: 11488 RVA: 0x0001DAA6 File Offset: 0x0001BCA6
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D05 RID: 3333
			// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x0001DAA8 File Offset: 0x0001BCA8
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040011C0 RID: 4544
			private int <>1__state;

			// Token: 0x040011C1 RID: 4545
			private object <>2__current;

			// Token: 0x040011C2 RID: 4546
			public ImageCacheKey key;

			// Token: 0x040011C3 RID: 4547
			public int tries;

			// Token: 0x040011C4 RID: 4548
			public ImageCacheController <>4__this;

			// Token: 0x040011C5 RID: 4549
			private string <url>5__2;

			// Token: 0x040011C6 RID: 4550
			private UnityWebRequest <uwr>5__3;
		}

		// Token: 0x02000423 RID: 1059
		private sealed class <WaitForImage>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002CE2 RID: 11490 RVA: 0x0001DAAB File Offset: 0x0001BCAB
			public <WaitForImage>d__10(int <>1__state)
			{
			}

			// Token: 0x06002CE3 RID: 11491 RVA: 0x0001DAB3 File Offset: 0x0001BCB3
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002CE4 RID: 11492 RVA: 0x0001DAB5 File Offset: 0x0001BCB5
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000D06 RID: 3334
			// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x0001DAB8 File Offset: 0x0001BCB8
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002CE6 RID: 11494 RVA: 0x0001DABB File Offset: 0x0001BCBB
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D07 RID: 3335
			// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x0001DABD File Offset: 0x0001BCBD
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040011C7 RID: 4551
			private int <>1__state;

			// Token: 0x040011C8 RID: 4552
			private object <>2__current;

			// Token: 0x040011C9 RID: 4553
			public Action<ImageCacheKey, ImageCacheEntry> callback;

			// Token: 0x040011CA RID: 4554
			public ImageCacheKey key;

			// Token: 0x040011CB RID: 4555
			public ImageCacheController <>4__this;

			// Token: 0x040011CC RID: 4556
			private float <time>5__2;
		}
	}
}
