using System;
using System.Runtime.InteropServices;
using Mirror;

namespace Polytoria.Datamodel
{
	// Token: 0x02000287 RID: 647
	public class InstanceValue : ValueBase
	{
		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x0001AC80 File Offset: 0x00018E80
		// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x0001AC83 File Offset: 0x00018E83
		public Instance Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0001AC85 File Offset: 0x00018E85
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x0001AC87 File Offset: 0x00018E87
		private void OnValueChanged(Instance oldValue, Instance newValue)
		{
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x0001AC91 File Offset: 0x00018E91
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x0001AC94 File Offset: 0x00018E94
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x0001AC97 File Offset: 0x00018E97
		public Instance Networkval
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x0001AC99 File Offset: 0x00018E99
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x0001AC9B File Offset: 0x00018E9B
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000A96 RID: 2710
		private Instance val;

		// Token: 0x04000A97 RID: 2711
		protected NetworkBehaviourSyncVar ___valNetId;

		// Token: 0x04000A98 RID: 2712
		public Action<Instance, Instance> _Mirror_SyncVarHookDelegate_val;
	}
}
