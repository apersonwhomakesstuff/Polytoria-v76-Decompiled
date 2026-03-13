using System;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002EC RID: 748
	public class PlayerGUIProxy : InstanceProxy
	{
		// Token: 0x060025DF RID: 9695 RVA: 0x0001C46D File Offset: 0x0001A66D
		public PlayerGUIProxy(PlayerGUI target) : base(null)
		{
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x0001C476 File Offset: 0x0001A676
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x0001C47D File Offset: 0x0001A67D
		public float Opacity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x0001C47F File Offset: 0x0001A67F
		// (set) Token: 0x060025E3 RID: 9699 RVA: 0x0001C482 File Offset: 0x0001A682
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

		// Token: 0x04000D18 RID: 3352
		private readonly PlayerGUI playerGUI;
	}
}
