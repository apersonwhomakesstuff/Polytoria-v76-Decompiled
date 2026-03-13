using System;
using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002CB RID: 715
	public class InsertService : MonoBehaviour
	{
		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x0001BEE5 File Offset: 0x0001A0E5
		// (set) Token: 0x06002410 RID: 9232 RVA: 0x0001BEEC File Offset: 0x0001A0EC
		public static InsertService Instance
		{
			get
			{
				return InsertService.<Instance>k__BackingField;
			}
			private set
			{
				InsertService.<Instance>k__BackingField = value;
			}
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x0001BEF4 File Offset: 0x0001A0F4
		private void Awake()
		{
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x0001BEF6 File Offset: 0x0001A0F6
		public void Model(int id, DynValue callback = null)
		{
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
		private void NetworkSpawn(Instance i)
		{
		}

		// Token: 0x04000CEF RID: 3311
		private static InsertService <Instance>k__BackingField;

		// Token: 0x02000407 RID: 1031
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06002C23 RID: 11299 RVA: 0x0001D81E File Offset: 0x0001BA1E
			internal void <Model>b__0(Instance i)
			{
			}

			// Token: 0x04001108 RID: 4360
			public InsertService <>4__this;

			// Token: 0x04001109 RID: 4361
			public DynValue callback;
		}
	}
}
