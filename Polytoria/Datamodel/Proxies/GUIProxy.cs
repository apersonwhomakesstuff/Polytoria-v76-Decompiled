using System;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002DB RID: 731
	public class GUIProxy : InstanceProxy
	{
		// Token: 0x060024E8 RID: 9448 RVA: 0x0001C17F File Offset: 0x0001A37F
		public GUIProxy(GUI target) : base(null)
		{
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x060024E9 RID: 9449 RVA: 0x0001C188 File Offset: 0x0001A388
		// (set) Token: 0x060024EA RID: 9450 RVA: 0x0001C18B File Offset: 0x0001A38B
		public bool Visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x04000D07 RID: 3335
		private readonly GUI gui;
	}
}
