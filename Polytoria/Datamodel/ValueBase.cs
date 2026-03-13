using System;
using Polytoria.Lua;

namespace Polytoria.Datamodel
{
	// Token: 0x020002BF RID: 703
	public class ValueBase : Instance
	{
		// Token: 0x06002384 RID: 9092 RVA: 0x0001BD3E File Offset: 0x00019F3E
		protected void InvokeChanged()
		{
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x0001BD48 File Offset: 0x00019F48
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x04000CBA RID: 3258
		public LuaEvent Changed;
	}
}
