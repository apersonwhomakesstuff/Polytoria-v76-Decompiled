using System;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000307 RID: 775
	public class ValueBaseProxy : InstanceProxy
	{
		// Token: 0x0600272A RID: 10026 RVA: 0x0001C855 File Offset: 0x0001AA55
		public ValueBaseProxy(ValueBase target) : base(null)
		{
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x0001C85E File Offset: 0x0001AA5E
		public LuaEvent Changed
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000D33 RID: 3379
		private readonly ValueBase valueBase;
	}
}
