using System;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D1 RID: 721
	public class BoolValueProxy : ValueBaseProxy
	{
		// Token: 0x06002450 RID: 9296 RVA: 0x0001BFC5 File Offset: 0x0001A1C5
		public BoolValueProxy(BoolValue target) : base(null)
		{
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x0001BFCE File Offset: 0x0001A1CE
		// (set) Token: 0x06002452 RID: 9298 RVA: 0x0001BFD1 File Offset: 0x0001A1D1
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

		// Token: 0x04000CFD RID: 3325
		private readonly BoolValue boolValue;
	}
}
