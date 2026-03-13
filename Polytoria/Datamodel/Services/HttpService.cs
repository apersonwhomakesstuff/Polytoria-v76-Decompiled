using System;
using System.Collections;
using System.Collections.Generic;
using MoonSharp.Interpreter;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C9 RID: 713
	public class HttpService : MonoBehaviour
	{
		// Token: 0x060023E4 RID: 9188 RVA: 0x0001BE7D File Offset: 0x0001A07D
		private void Awake()
		{
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x0001BE7F File Offset: 0x0001A07F
		private static bool RateLimit(DynValue callback = null)
		{
			return false;
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x0001BE82 File Offset: 0x0001A082
		public static void Get(string url, DynValue callback = null, Table headers = null)
		{
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x0001BE84 File Offset: 0x0001A084
		public static void Post(string url, string body, DynValue callback = null, Table headers = null)
		{
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x0001BE86 File Offset: 0x0001A086
		public static void Put(string url, string body, DynValue callback = null, Table headers = null)
		{
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x0001BE88 File Offset: 0x0001A088
		public static void Delete(string url, DynValue callback = null, Table headers = null)
		{
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x0001BE8A File Offset: 0x0001A08A
		public static void Patch(string url, string body, DynValue callback = null, Table headers = null)
		{
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x0001BE8C File Offset: 0x0001A08C
		private static IEnumerator DoRequest(string method, string url, string body = null, DynValue callback = null, Table headers = null)
		{
			return null;
		}

		// Token: 0x04000CE9 RID: 3305
		public static HttpService instance;

		// Token: 0x04000CEA RID: 3306
		private static int maxRequestsPerMinute;

		// Token: 0x04000CEB RID: 3307
		private static int requestsThisMinute;

		// Token: 0x04000CEC RID: 3308
		private static int currentMinute;

		// Token: 0x02000406 RID: 1030
		private sealed class <DoRequest>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002C1B RID: 11291 RVA: 0x0001D7FF File Offset: 0x0001B9FF
			public <DoRequest>d__11(int <>1__state)
			{
			}

			// Token: 0x06002C1C RID: 11292 RVA: 0x0001D807 File Offset: 0x0001BA07
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002C1D RID: 11293 RVA: 0x0001D809 File Offset: 0x0001BA09
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002C1E RID: 11294 RVA: 0x0001D80C File Offset: 0x0001BA0C
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000CEE RID: 3310
			// (get) Token: 0x06002C1F RID: 11295 RVA: 0x0001D80E File Offset: 0x0001BA0E
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002C20 RID: 11296 RVA: 0x0001D811 File Offset: 0x0001BA11
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CEF RID: 3311
			// (get) Token: 0x06002C21 RID: 11297 RVA: 0x0001D813 File Offset: 0x0001BA13
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001100 RID: 4352
			private int <>1__state;

			// Token: 0x04001101 RID: 4353
			private object <>2__current;

			// Token: 0x04001102 RID: 4354
			public string url;

			// Token: 0x04001103 RID: 4355
			public string method;

			// Token: 0x04001104 RID: 4356
			public string body;

			// Token: 0x04001105 RID: 4357
			public Table headers;

			// Token: 0x04001106 RID: 4358
			public DynValue callback;

			// Token: 0x04001107 RID: 4359
			private UnityWebRequest <uwr>5__2;
		}
	}
}
