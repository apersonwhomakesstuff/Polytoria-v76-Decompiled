using System;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D3 RID: 723
	public class ClimbableProxy : PartProxy
	{
		// Token: 0x0600247D RID: 9341 RVA: 0x0001C06E File Offset: 0x0001A26E
		public ClimbableProxy(Climbable target) : base(null)
		{
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x0001C077 File Offset: 0x0001A277
		// (set) Token: 0x0600247F RID: 9343 RVA: 0x0001C07E File Offset: 0x0001A27E
		public float ClimbSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x04000CFF RID: 3327
		private readonly Climbable climbable;
	}
}
