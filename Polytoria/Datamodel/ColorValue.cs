using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000274 RID: 628
	public class ColorValue : ValueBase
	{
		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x00024238 File Offset: 0x00022438
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x0001A7F1 File Offset: 0x000189F1
		public Color Value
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0001A7F3 File Offset: 0x000189F3
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x0001A7F5 File Offset: 0x000189F5
		private void OnValueChanged(Color oldValue, Color newValue)
		{
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x0001A7FF File Offset: 0x000189FF
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x00024250 File Offset: 0x00022450
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x0001A802 File Offset: 0x00018A02
		public Color Networkval
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0001A804 File Offset: 0x00018A04
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x0001A806 File Offset: 0x00018A06
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x040009E1 RID: 2529
		private Color val;

		// Token: 0x040009E2 RID: 2530
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_val;
	}
}
