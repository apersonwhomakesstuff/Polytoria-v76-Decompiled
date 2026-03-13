using System;
using System.Text;

namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
	// Token: 0x020000CB RID: 203
	public class LuaLBuffer
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x0000E147 File Offset: 0x0000C347
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x0000E14F File Offset: 0x0000C34F
		public StringBuilder StringBuilder
		{
			get
			{
				return this.<StringBuilder>k__BackingField;
			}
			private set
			{
				this.<StringBuilder>k__BackingField = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0000E158 File Offset: 0x0000C358
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x0000E160 File Offset: 0x0000C360
		public LuaState LuaState
		{
			get
			{
				return this.<LuaState>k__BackingField;
			}
			private set
			{
				this.<LuaState>k__BackingField = value;
			}
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0000E169 File Offset: 0x0000C369
		public LuaLBuffer(LuaState l)
		{
		}

		// Token: 0x04000387 RID: 903
		private StringBuilder <StringBuilder>k__BackingField;

		// Token: 0x04000388 RID: 904
		private LuaState <LuaState>k__BackingField;
	}
}
