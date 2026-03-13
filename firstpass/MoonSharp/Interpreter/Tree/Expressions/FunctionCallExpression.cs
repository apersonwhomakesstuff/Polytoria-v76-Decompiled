using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Expressions
{
	// Token: 0x02000079 RID: 121
	internal class FunctionCallExpression : Expression
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0000D59A File Offset: 0x0000B79A
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x0000D5A2 File Offset: 0x0000B7A2
		internal SourceRef SourceRef
		{
			get
			{
				return this.<SourceRef>k__BackingField;
			}
			private set
			{
				this.<SourceRef>k__BackingField = value;
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0000D5AB File Offset: 0x0000B7AB
		public FunctionCallExpression(ScriptLoadingContext lcontext, Expression function, Token thisCallName) : base(null)
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0000D5B4 File Offset: 0x0000B7B4
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0000D5B6 File Offset: 0x0000B7B6
		public override DynValue Eval(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x040002AD RID: 685
		private List<Expression> m_Arguments;

		// Token: 0x040002AE RID: 686
		private Expression m_Function;

		// Token: 0x040002AF RID: 687
		private string m_Name;

		// Token: 0x040002B0 RID: 688
		private string m_DebugErr;

		// Token: 0x040002B1 RID: 689
		private SourceRef <SourceRef>k__BackingField;
	}
}
