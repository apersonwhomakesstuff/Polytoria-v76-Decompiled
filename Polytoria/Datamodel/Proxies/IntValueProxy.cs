using System;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E0 RID: 736
	public class IntValueProxy : ValueBaseProxy
	{
		// Token: 0x0600251A RID: 9498 RVA: 0x0001C222 File Offset: 0x0001A422
		public IntValueProxy(IntValue target) : base(null)
		{
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x0001C22B File Offset: 0x0001A42B
		// (set) Token: 0x0600251C RID: 9500 RVA: 0x0001C22E File Offset: 0x0001A42E
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

		// Token: 0x04000D0C RID: 3340
		private readonly IntValue intValue;
	}
}
