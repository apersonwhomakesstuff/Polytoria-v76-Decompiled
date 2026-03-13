using System;
using System.Runtime.InteropServices;
using Mirror;

namespace Polytoria.Datamodel
{
	// Token: 0x02000289 RID: 649
	public class IntValue : ValueBase
	{
		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x0001AC9D File Offset: 0x00018E9D
		// (set) Token: 0x06001D04 RID: 7428 RVA: 0x0001ACA0 File Offset: 0x00018EA0
		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x0001ACA2 File Offset: 0x00018EA2
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x0001ACA4 File Offset: 0x00018EA4
		private void OnValueChanged(int oldValue, int newValue)
		{
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x0001ACAE File Offset: 0x00018EAE
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x0001ACB1 File Offset: 0x00018EB1
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x0001ACB4 File Offset: 0x00018EB4
		public int Networkval
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x0001ACB6 File Offset: 0x00018EB6
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x0001ACB8 File Offset: 0x00018EB8
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000A99 RID: 2713
		private int val;

		// Token: 0x04000A9A RID: 2714
		public Action<int, int> _Mirror_SyncVarHookDelegate_val;
	}
}
