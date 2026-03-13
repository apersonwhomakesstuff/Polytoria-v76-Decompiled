using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	// Token: 0x02000334 RID: 820
	public class NetworkController : MonoBehaviour
	{
		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x0001CC7C File Offset: 0x0001AE7C
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x0001CC84 File Offset: 0x0001AE84
		public int PlaceID
		{
			get
			{
				return this.<PlaceID>k__BackingField;
			}
			private set
			{
				this.<PlaceID>k__BackingField = value;
			}
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x0001CC8D File Offset: 0x0001AE8D
		private void Awake()
		{
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x0001CC8F File Offset: 0x0001AE8F
		private void Start()
		{
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x0001CC91 File Offset: 0x0001AE91
		private IEnumerator StartClient()
		{
			return null;
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x0001CC94 File Offset: 0x0001AE94
		private IEnumerator PlaySolo()
		{
			return null;
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x0001CC97 File Offset: 0x0001AE97
		private void Update()
		{
		}

		// Token: 0x04000DDB RID: 3547
		public static NetworkController singleton;

		// Token: 0x04000DDC RID: 3548
		private string passphrase;

		// Token: 0x04000DDD RID: 3549
		private int <PlaceID>k__BackingField;

		// Token: 0x02000428 RID: 1064
		private sealed class <PlaySolo>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002CEE RID: 11502 RVA: 0x0001DACC File Offset: 0x0001BCCC
			public <PlaySolo>d__9(int <>1__state)
			{
			}

			// Token: 0x06002CEF RID: 11503 RVA: 0x0001DAD4 File Offset: 0x0001BCD4
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002CF0 RID: 11504 RVA: 0x0001DAD6 File Offset: 0x0001BCD6
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000D08 RID: 3336
			// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x0001DAD9 File Offset: 0x0001BCD9
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002CF2 RID: 11506 RVA: 0x0001DADC File Offset: 0x0001BCDC
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D09 RID: 3337
			// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x0001DADE File Offset: 0x0001BCDE
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040011E3 RID: 4579
			private int <>1__state;

			// Token: 0x040011E4 RID: 4580
			private object <>2__current;
		}

		// Token: 0x02000429 RID: 1065
		private sealed class <StartClient>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002CF4 RID: 11508 RVA: 0x0001DAE1 File Offset: 0x0001BCE1
			public <StartClient>d__8(int <>1__state)
			{
			}

			// Token: 0x06002CF5 RID: 11509 RVA: 0x0001DAE9 File Offset: 0x0001BCE9
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002CF6 RID: 11510 RVA: 0x0001DAEB File Offset: 0x0001BCEB
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002CF7 RID: 11511 RVA: 0x0001DAEE File Offset: 0x0001BCEE
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000D0A RID: 3338
			// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x0001DAF0 File Offset: 0x0001BCF0
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002CF9 RID: 11513 RVA: 0x0001DAF3 File Offset: 0x0001BCF3
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D0B RID: 3339
			// (get) Token: 0x06002CFA RID: 11514 RVA: 0x0001DAF5 File Offset: 0x0001BCF5
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040011E5 RID: 4581
			private int <>1__state;

			// Token: 0x040011E6 RID: 4582
			private object <>2__current;

			// Token: 0x040011E7 RID: 4583
			public NetworkController <>4__this;

			// Token: 0x040011E8 RID: 4584
			private UnityWebRequest <uwr>5__2;
		}
	}
}
