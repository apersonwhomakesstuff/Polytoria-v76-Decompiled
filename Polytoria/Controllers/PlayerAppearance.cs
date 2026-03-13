using System;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000336 RID: 822
	public class PlayerAppearance : AppearanceLoaderBase
	{
		// Token: 0x0600289E RID: 10398 RVA: 0x0001CCB4 File Offset: 0x0001AEB4
		protected override void Awake()
		{
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x0001CCB6 File Offset: 0x0001AEB6
		public override void ClearAppearance()
		{
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x0001CCB8 File Offset: 0x0001AEB8
		protected override void UpdateColors()
		{
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x0001CCBA File Offset: 0x0001AEBA
		protected override void UpdateClothing()
		{
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x0001CCBC File Offset: 0x0001AEBC
		protected override void HatLoaded(GameObject hat)
		{
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x0001CCC6 File Offset: 0x0001AEC6
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x04000DDF RID: 3551
		private Player player;
	}
}
