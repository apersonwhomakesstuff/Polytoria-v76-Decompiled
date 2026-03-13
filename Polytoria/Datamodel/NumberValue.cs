using System;
using System.Runtime.InteropServices;
using Mirror;

namespace Polytoria.Datamodel
{
	// Token: 0x02000296 RID: 662
	public class NumberValue : ValueBase
	{
		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x0001AF3E File Offset: 0x0001913E
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x0001AF45 File Offset: 0x00019145
		public float Value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x0001AF47 File Offset: 0x00019147
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x0001AF49 File Offset: 0x00019149
		private void OnValueChanged(float oldValue, float newValue)
		{
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x0001AF53 File Offset: 0x00019153
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x0001AF56 File Offset: 0x00019156
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x0001AF5D File Offset: 0x0001915D
		public float Networkval
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x0001AF5F File Offset: 0x0001915F
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x0001AF61 File Offset: 0x00019161
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000ADF RID: 2783
		private float val;

		// Token: 0x04000AE0 RID: 2784
		public Action<float, float> _Mirror_SyncVarHookDelegate_val;
	}
}
