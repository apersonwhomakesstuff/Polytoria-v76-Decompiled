using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x020000FB RID: 251
	public sealed class DebugService : IScriptPrivateResource
	{
		// Token: 0x06000B40 RID: 2880 RVA: 0x0000E836 File Offset: 0x0000CA36
		internal DebugService(Script script, Processor processor)
		{
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0000E83E File Offset: 0x0000CA3E
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x0000E846 File Offset: 0x0000CA46
		public Script OwnerScript
		{
			get
			{
				return this.<OwnerScript>k__BackingField;
			}
			private set
			{
				this.<OwnerScript>k__BackingField = value;
			}
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0000E84F File Offset: 0x0000CA4F
		public HashSet<int> ResetBreakPoints(SourceCode src, HashSet<int> lines)
		{
			return null;
		}

		// Token: 0x04000475 RID: 1141
		private Processor m_Processor;

		// Token: 0x04000476 RID: 1142
		private Script <OwnerScript>k__BackingField;
	}
}
