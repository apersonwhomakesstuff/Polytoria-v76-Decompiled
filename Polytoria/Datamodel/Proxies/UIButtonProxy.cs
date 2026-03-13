using System;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002FE RID: 766
	public class UIButtonProxy : UILabelProxy
	{
		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060026B2 RID: 9906 RVA: 0x0001C704 File Offset: 0x0001A904
		// (set) Token: 0x060026B3 RID: 9907 RVA: 0x0001C707 File Offset: 0x0001A907
		public bool Interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x0001C709 File Offset: 0x0001A909
		public UIButtonProxy(UIButton target) : base(null)
		{
		}

		// Token: 0x04000D2A RID: 3370
		private readonly UIButton uiButton;
	}
}
