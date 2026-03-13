using System;
using System.Runtime.InteropServices;
using Mirror;

namespace Polytoria.Datamodel
{
	// Token: 0x02000270 RID: 624
	public class BoolValue : ValueBase
	{
		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x0001A65E File Offset: 0x0001885E
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x0001A661 File Offset: 0x00018861
		public bool Value
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x0001A663 File Offset: 0x00018863
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0001A665 File Offset: 0x00018865
		private void OnValueChanged(bool oldValue, bool newValue)
		{
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0001A66F File Offset: 0x0001886F
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001AD6 RID: 6870 RVA: 0x0001A672 File Offset: 0x00018872
		// (set) Token: 0x06001AD7 RID: 6871 RVA: 0x0001A675 File Offset: 0x00018875
		public bool Networkval
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x0001A677 File Offset: 0x00018877
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0001A679 File Offset: 0x00018879
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x040009B3 RID: 2483
		private bool val;

		// Token: 0x040009B4 RID: 2484
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_val;
	}
}
