using System;

namespace Polytoria.Datamodel
{
	// Token: 0x020002B2 RID: 690
	public class Truss : Climbable
	{
		// Token: 0x06002226 RID: 8742 RVA: 0x0001BA02 File Offset: 0x00019C02
		protected override void Awake()
		{
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x0001BA0C File Offset: 0x00019C0C
		public override bool Weaved()
		{
			return false;
		}
	}
}
