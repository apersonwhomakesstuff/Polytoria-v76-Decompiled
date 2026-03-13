using System;
using Polytoria.Lua;

namespace Polytoria.Datamodel
{
	// Token: 0x020002AA RID: 682
	public class Signal : Instance
	{
		// Token: 0x06002106 RID: 8454 RVA: 0x0001B731 File Offset: 0x00019931
		public void Invoke(object[] par)
		{
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x0001B73B File Offset: 0x0001993B
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x04000BF0 RID: 3056
		public LuaEvent Invoked;
	}
}
