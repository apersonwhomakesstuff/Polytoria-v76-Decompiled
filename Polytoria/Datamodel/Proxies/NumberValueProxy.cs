using System;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E8 RID: 744
	public class NumberValueProxy : ValueBaseProxy
	{
		// Token: 0x0600256C RID: 9580 RVA: 0x0001C31A File Offset: 0x0001A51A
		public NumberValueProxy(NumberValue target) : base(null)
		{
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x0001C323 File Offset: 0x0001A523
		// (set) Token: 0x0600256E RID: 9582 RVA: 0x0001C32A File Offset: 0x0001A52A
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

		// Token: 0x04000D14 RID: 3348
		private readonly NumberValue numberValue;
	}
}
