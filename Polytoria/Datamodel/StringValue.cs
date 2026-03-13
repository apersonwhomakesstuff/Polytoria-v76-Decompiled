using System;
using System.Runtime.InteropServices;
using Mirror;

namespace Polytoria.Datamodel
{
	// Token: 0x020002AE RID: 686
	public class StringValue : ValueBase
	{
		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x0600218F RID: 8591 RVA: 0x0001B8B1 File Offset: 0x00019AB1
		// (set) Token: 0x06002190 RID: 8592 RVA: 0x0001B8B4 File Offset: 0x00019AB4
		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x0001B8B6 File Offset: 0x00019AB6
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x0001B8B8 File Offset: 0x00019AB8
		private void OnValueChanged(string oldValue, string newValue)
		{
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x0001B8C2 File Offset: 0x00019AC2
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x0001B8C5 File Offset: 0x00019AC5
		// (set) Token: 0x06002196 RID: 8598 RVA: 0x0001B8C8 File Offset: 0x00019AC8
		public string Networkval
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

		// Token: 0x06002197 RID: 8599 RVA: 0x0001B8CA File Offset: 0x00019ACA
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x0001B8CC File Offset: 0x00019ACC
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000C07 RID: 3079
		private string val;

		// Token: 0x04000C08 RID: 3080
		public Action<string, string> _Mirror_SyncVarHookDelegate_val;
	}
}
