using System;
using System.Collections.Generic;
using MoonSharp.Interpreter;

namespace Polytoria.Lua
{
	// Token: 0x02000265 RID: 613
	public class LuaEvent
	{
		// Token: 0x06001A58 RID: 6744 RVA: 0x0001A558 File Offset: 0x00018758
		public void Connect(DynValue func)
		{
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0001A55A File Offset: 0x0001875A
		public void Disconnect(DynValue func)
		{
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0001A55C File Offset: 0x0001875C
		public void Invoke(object[] par)
		{
		}

		// Token: 0x040009A7 RID: 2471
		private List<DynValue> callbacks;
	}
}
