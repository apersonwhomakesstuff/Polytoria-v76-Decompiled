using System;
using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x0200030F RID: 783
	public class HttpServiceProxy
	{
		// Token: 0x0600274F RID: 10063 RVA: 0x0001C8DC File Offset: 0x0001AADC
		public HttpServiceProxy(HttpService target)
		{
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x0001C8E4 File Offset: 0x0001AAE4
		public static void Get(string url, DynValue callback = null, Table headers = null)
		{
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x0001C8E6 File Offset: 0x0001AAE6
		public static void Post(string url, string body, DynValue callback = null, Table headers = null)
		{
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x0001C8E8 File Offset: 0x0001AAE8
		public static void Put(string url, string body, DynValue callback = null, Table headers = null)
		{
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x0001C8EA File Offset: 0x0001AAEA
		public static void Delete(string url, DynValue callback = null, Table headers = null)
		{
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x0001C8EC File Offset: 0x0001AAEC
		public static void Patch(string url, string body, DynValue callback = null, Table headers = null)
		{
		}

		// Token: 0x04000D3B RID: 3387
		private readonly HttpService httpService;
	}
}
