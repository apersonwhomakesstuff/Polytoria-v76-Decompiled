using System;
using System.Collections.Generic;
using MoonSharp.Interpreter;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C4 RID: 708
	public class Datastore
	{
		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x060023C2 RID: 9154 RVA: 0x0001BDFA File Offset: 0x00019FFA
		public bool Loading
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x0001BDFD File Offset: 0x00019FFD
		public string Key
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x0001BE00 File Offset: 0x0001A000
		public Datastore(string key)
		{
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x0001BE08 File Offset: 0x0001A008
		public void Deserialize(string jsonData)
		{
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x0001BE0A File Offset: 0x0001A00A
		public void Get(string key, DynValue callback)
		{
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x0001BE0C File Offset: 0x0001A00C
		public void Set(string key, DynValue value, DynValue callback = null)
		{
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x0001BE0E File Offset: 0x0001A00E
		public void Remove(string key, DynValue callback = null)
		{
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x0001BE12 File Offset: 0x0001A012
		private void <.ctor>b__10_0(bool success)
		{
		}

		// Token: 0x04000CCE RID: 3278
		public static readonly float CACHE_TIME;

		// Token: 0x04000CCF RID: 3279
		private string key;

		// Token: 0x04000CD0 RID: 3280
		private bool loading;

		// Token: 0x04000CD1 RID: 3281
		private Dictionary<string, Datastore.DatastoreEntry> data;

		// Token: 0x04000CD2 RID: 3282
		private ScriptService scriptService;

		// Token: 0x04000CD3 RID: 3283
		public LuaEvent Loaded;

		// Token: 0x020003FE RID: 1022
		private struct DatastoreEntry
		{
			// Token: 0x040010E3 RID: 4323
			public object value;

			// Token: 0x040010E4 RID: 4324
			public float timestamp;
		}

		// Token: 0x020003FF RID: 1023
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06002BFD RID: 11261 RVA: 0x0001D794 File Offset: 0x0001B994
			internal void <Get>b__0(bool success)
			{
			}

			// Token: 0x040010E5 RID: 4325
			public Datastore <>4__this;

			// Token: 0x040010E6 RID: 4326
			public string key;

			// Token: 0x040010E7 RID: 4327
			public DynValue callback;

			// Token: 0x040010E8 RID: 4328
			public Datastore.DatastoreEntry entry;
		}

		// Token: 0x02000400 RID: 1024
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06002BFF RID: 11263 RVA: 0x0001D79E File Offset: 0x0001B99E
			internal void <Set>b__0(bool success)
			{
			}

			// Token: 0x040010E9 RID: 4329
			public DynValue callback;

			// Token: 0x040010EA RID: 4330
			public Datastore <>4__this;
		}

		// Token: 0x02000401 RID: 1025
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06002C01 RID: 11265 RVA: 0x0001D7A8 File Offset: 0x0001B9A8
			internal void <Remove>b__0(bool success)
			{
			}

			// Token: 0x040010EB RID: 4331
			public DynValue callback;

			// Token: 0x040010EC RID: 4332
			public Datastore <>4__this;
		}
	}
}
