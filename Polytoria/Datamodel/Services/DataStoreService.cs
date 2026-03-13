using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C5 RID: 709
	public class DataStoreService : NetworkBehaviour
	{
		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x0001BE14 File Offset: 0x0001A014
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x0001BE1B File Offset: 0x0001A01B
		public static DataStoreService Instance
		{
			get
			{
				return DataStoreService.<Instance>k__BackingField;
			}
			private set
			{
				DataStoreService.<Instance>k__BackingField = value;
			}
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x0001BE23 File Offset: 0x0001A023
		private void Awake()
		{
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x0001BE25 File Offset: 0x0001A025
		public Datastore GetDatastore(string key)
		{
			return null;
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x0001BE28 File Offset: 0x0001A028
		private void Update()
		{
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x0001BE2A File Offset: 0x0001A02A
		public bool UseReadRequest()
		{
			return false;
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x0001BE2D File Offset: 0x0001A02D
		public bool UseWriteRequest()
		{
			return false;
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x0001BE30 File Offset: 0x0001A030
		public void LoadFromServer(Datastore ds, Action<bool> callback)
		{
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x0001BE32 File Offset: 0x0001A032
		private IEnumerator DoLoadFromServer(GetDataStoreQueueEntry entry)
		{
			return null;
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0001BE35 File Offset: 0x0001A035
		public void WriteToServer(Datastore ds, string key, object value, Action<bool> callback)
		{
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x0001BE37 File Offset: 0x0001A037
		private IEnumerator DoWriteToServer(Datastore ds, string key, object value, Action<bool> callback)
		{
			return null;
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x0001BE42 File Offset: 0x0001A042
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x04000CD4 RID: 3284
		private static DataStoreService <Instance>k__BackingField;

		// Token: 0x04000CD5 RID: 3285
		public int MaxReadRequestsPerMinute;

		// Token: 0x04000CD6 RID: 3286
		public int ReadRequestsPerPlayerModifier;

		// Token: 0x04000CD7 RID: 3287
		public int MaxWriteRequestsPerMinute;

		// Token: 0x04000CD8 RID: 3288
		public int WriteRequestsPerPlayerModifier;

		// Token: 0x04000CD9 RID: 3289
		private Queue<GetDataStoreQueueEntry> getDataStoreQueue;

		// Token: 0x04000CDA RID: 3290
		private Dictionary<string, Datastore> datastores;

		// Token: 0x04000CDB RID: 3291
		private int readRequestsThisMinute;

		// Token: 0x04000CDC RID: 3292
		private int writeRequestThisMinute;

		// Token: 0x04000CDD RID: 3293
		private int currentMinute;

		// Token: 0x04000CDE RID: 3294
		private bool isGettingDatastore;

		// Token: 0x02000402 RID: 1026
		private sealed class <DoLoadFromServer>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002C02 RID: 11266 RVA: 0x0001D7AA File Offset: 0x0001B9AA
			public <DoLoadFromServer>d__20(int <>1__state)
			{
			}

			// Token: 0x06002C03 RID: 11267 RVA: 0x0001D7B2 File Offset: 0x0001B9B2
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002C04 RID: 11268 RVA: 0x0001D7B4 File Offset: 0x0001B9B4
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002C05 RID: 11269 RVA: 0x0001D7B7 File Offset: 0x0001B9B7
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000CE8 RID: 3304
			// (get) Token: 0x06002C06 RID: 11270 RVA: 0x0001D7B9 File Offset: 0x0001B9B9
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002C07 RID: 11271 RVA: 0x0001D7BC File Offset: 0x0001B9BC
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CE9 RID: 3305
			// (get) Token: 0x06002C08 RID: 11272 RVA: 0x0001D7BE File Offset: 0x0001B9BE
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010ED RID: 4333
			private int <>1__state;

			// Token: 0x040010EE RID: 4334
			private object <>2__current;

			// Token: 0x040010EF RID: 4335
			public GetDataStoreQueueEntry entry;

			// Token: 0x040010F0 RID: 4336
			public DataStoreService <>4__this;

			// Token: 0x040010F1 RID: 4337
			private Datastore <ds>5__2;

			// Token: 0x040010F2 RID: 4338
			private UnityWebRequest <uwr>5__3;
		}

		// Token: 0x02000403 RID: 1027
		private sealed class <DoWriteToServer>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002C09 RID: 11273 RVA: 0x0001D7C1 File Offset: 0x0001B9C1
			public <DoWriteToServer>d__22(int <>1__state)
			{
			}

			// Token: 0x06002C0A RID: 11274 RVA: 0x0001D7C9 File Offset: 0x0001B9C9
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002C0B RID: 11275 RVA: 0x0001D7CB File Offset: 0x0001B9CB
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002C0C RID: 11276 RVA: 0x0001D7CE File Offset: 0x0001B9CE
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000CEA RID: 3306
			// (get) Token: 0x06002C0D RID: 11277 RVA: 0x0001D7D0 File Offset: 0x0001B9D0
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002C0E RID: 11278 RVA: 0x0001D7D3 File Offset: 0x0001B9D3
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CEB RID: 3307
			// (get) Token: 0x06002C0F RID: 11279 RVA: 0x0001D7D5 File Offset: 0x0001B9D5
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010F3 RID: 4339
			private int <>1__state;

			// Token: 0x040010F4 RID: 4340
			private object <>2__current;

			// Token: 0x040010F5 RID: 4341
			public object value;

			// Token: 0x040010F6 RID: 4342
			public string key;

			// Token: 0x040010F7 RID: 4343
			public Datastore ds;

			// Token: 0x040010F8 RID: 4344
			public Action<bool> callback;

			// Token: 0x040010F9 RID: 4345
			private UnityWebRequest <uwr>5__2;
		}
	}
}
