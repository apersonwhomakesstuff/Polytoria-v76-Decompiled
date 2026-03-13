using System;
using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x0200030C RID: 780
	public class DatastoreProxy
	{
		// Token: 0x06002744 RID: 10052 RVA: 0x0001C8AF File Offset: 0x0001AAAF
		public DatastoreProxy(Datastore target)
		{
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06002745 RID: 10053 RVA: 0x0001C8B7 File Offset: 0x0001AAB7
		public string Key
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06002746 RID: 10054 RVA: 0x0001C8BA File Offset: 0x0001AABA
		public bool Loading
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06002747 RID: 10055 RVA: 0x0001C8BD File Offset: 0x0001AABD
		public LuaEvent Loaded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
		public void Get(string key, DynValue callback)
		{
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0001C8C2 File Offset: 0x0001AAC2
		public void Set(string key, DynValue value, DynValue callback = null)
		{
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0001C8C4 File Offset: 0x0001AAC4
		public void Remove(string key, DynValue callback = null)
		{
		}

		// Token: 0x04000D38 RID: 3384
		private readonly Datastore datastore;
	}
}
