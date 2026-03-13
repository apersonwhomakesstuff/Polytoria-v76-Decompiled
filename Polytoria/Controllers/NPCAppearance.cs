using System;
using Polytoria.Datamodel;

namespace Polytoria.Controllers
{
	// Token: 0x02000335 RID: 821
	public class NPCAppearance : AppearanceLoaderBase
	{
		// Token: 0x06002898 RID: 10392 RVA: 0x0001CCA1 File Offset: 0x0001AEA1
		protected override void Awake()
		{
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x0001CCA3 File Offset: 0x0001AEA3
		public override void ClearAppearance()
		{
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x0001CCA5 File Offset: 0x0001AEA5
		protected override void UpdateColors()
		{
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x0001CCA7 File Offset: 0x0001AEA7
		protected override void UpdateClothing()
		{
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x0001CCB1 File Offset: 0x0001AEB1
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x04000DDE RID: 3550
		private NPC npc;
	}
}
