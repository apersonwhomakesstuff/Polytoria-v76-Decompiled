using System;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F5 RID: 757
	public class SignalProxy : InstanceProxy
	{
		// Token: 0x06002665 RID: 9829 RVA: 0x0001C5F7 File Offset: 0x0001A7F7
		public SignalProxy(Signal target) : base(null)
		{
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002666 RID: 9830 RVA: 0x0001C600 File Offset: 0x0001A800
		public LuaEvent Invoked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x0001C603 File Offset: 0x0001A803
		public void Invoke(object[] par)
		{
		}

		// Token: 0x04000D21 RID: 3361
		private readonly Signal signal;
	}
}
