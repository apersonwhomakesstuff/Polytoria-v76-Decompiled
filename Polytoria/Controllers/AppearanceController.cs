using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using GLTFast;
using Polytoria.Datamodel;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	// Token: 0x02000322 RID: 802
	public class AppearanceController : MonoBehaviour
	{
		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x060027CF RID: 10191 RVA: 0x0001CA5A File Offset: 0x0001AC5A
		// (set) Token: 0x060027D0 RID: 10192 RVA: 0x0001CA61 File Offset: 0x0001AC61
		public static AppearanceController Instance
		{
			get
			{
				return AppearanceController.<Instance>k__BackingField;
			}
			private set
			{
				AppearanceController.<Instance>k__BackingField = value;
			}
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x0001CA69 File Offset: 0x0001AC69
		private void Awake()
		{
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x0001CA6B File Offset: 0x0001AC6B
		private void Update()
		{
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x0001CA6D File Offset: 0x0001AC6D
		private IEnumerator ProcessPlayerAppearance(Player player)
		{
			return null;
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x0001CA70 File Offset: 0x0001AC70
		public void AddPlayerToQueue(Player player)
		{
		}

		// Token: 0x04000D5F RID: 3423
		private static AppearanceController <Instance>k__BackingField;

		// Token: 0x04000D60 RID: 3424
		private Queue<Player> playerQueue;

		// Token: 0x04000D61 RID: 3425
		private bool isProcessing;

		// Token: 0x02000415 RID: 1045
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06002C99 RID: 11417 RVA: 0x0001D9AE File Offset: 0x0001BBAE
			internal void <ProcessPlayerAppearance>b__0(ImageCacheKey key, ImageCacheEntry entry)
			{
			}

			// Token: 0x06002C9A RID: 11418 RVA: 0x0001D9B0 File Offset: 0x0001BBB0
			internal void <ProcessPlayerAppearance>b__1(ImageCacheKey key, ImageCacheEntry entry)
			{
			}

			// Token: 0x06002C9B RID: 11419 RVA: 0x0001D9B2 File Offset: 0x0001BBB2
			internal void <ProcessPlayerAppearance>b__2(ImageCacheKey key, ImageCacheEntry entry)
			{
			}

			// Token: 0x0400117D RID: 4477
			public Transform headObj;

			// Token: 0x0400117E RID: 4478
			public Transform leftArmObj;

			// Token: 0x0400117F RID: 4479
			public Transform rightArmObj;

			// Token: 0x04001180 RID: 4480
			public Transform torsoObj;

			// Token: 0x04001181 RID: 4481
			public Transform leftLegObj;

			// Token: 0x04001182 RID: 4482
			public Transform rightLegObj;

			// Token: 0x04001183 RID: 4483
			public Action<ImageCacheKey, ImageCacheEntry> <>9__0;

			// Token: 0x04001184 RID: 4484
			public Action<ImageCacheKey, ImageCacheEntry> <>9__1;

			// Token: 0x04001185 RID: 4485
			public Action<ImageCacheKey, ImageCacheEntry> <>9__2;
		}

		// Token: 0x02000416 RID: 1046
		private sealed class <ProcessPlayerAppearance>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002C9C RID: 11420 RVA: 0x0001D9B4 File Offset: 0x0001BBB4
			public <ProcessPlayerAppearance>d__8(int <>1__state)
			{
			}

			// Token: 0x06002C9D RID: 11421 RVA: 0x0001D9BC File Offset: 0x0001BBBC
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002C9E RID: 11422 RVA: 0x0001D9BE File Offset: 0x0001BBBE
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002C9F RID: 11423 RVA: 0x0001D9C1 File Offset: 0x0001BBC1
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000CF6 RID: 3318
			// (get) Token: 0x06002CA0 RID: 11424 RVA: 0x0001D9C3 File Offset: 0x0001BBC3
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002CA1 RID: 11425 RVA: 0x0001D9C6 File Offset: 0x0001BBC6
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CF7 RID: 3319
			// (get) Token: 0x06002CA2 RID: 11426 RVA: 0x0001D9C8 File Offset: 0x0001BBC8
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001186 RID: 4486
			private int <>1__state;

			// Token: 0x04001187 RID: 4487
			private object <>2__current;

			// Token: 0x04001188 RID: 4488
			public Player player;

			// Token: 0x04001189 RID: 4489
			private AppearanceController.<>c__DisplayClass8_0 <>8__1;

			// Token: 0x0400118A RID: 4490
			public AppearanceController <>4__this;

			// Token: 0x0400118B RID: 4491
			private UnityWebRequest <uwr>5__2;

			// Token: 0x0400118C RID: 4492
			private JSONNode.Enumerator <>7__wrap2;

			// Token: 0x0400118D RID: 4493
			private GameObject <hat>5__4;

			// Token: 0x0400118E RID: 4494
			private GltfImport <gltf>5__5;

			// Token: 0x0400118F RID: 4495
			private Task<bool> <t>5__6;

			// Token: 0x04001190 RID: 4496
			private Task<bool> <task>5__7;
		}
	}
}
