using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x02000064 RID: 100
	internal class AssignmentStatement : Statement
	{
		// Token: 0x06000651 RID: 1617 RVA: 0x0000D38C File Offset: 0x0000B58C
		public AssignmentStatement(ScriptLoadingContext lcontext, Token startToken) : base(null)
		{
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0000D395 File Offset: 0x0000B595
		public AssignmentStatement(ScriptLoadingContext lcontext, Expression firstExpression, Token first) : base(null)
		{
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0000D39E File Offset: 0x0000B59E
		private IVariable CheckVar(ScriptLoadingContext lcontext, Expression firstExpression)
		{
			return null;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0000D3A1 File Offset: 0x0000B5A1
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x0400025D RID: 605
		private List<IVariable> m_LValues;

		// Token: 0x0400025E RID: 606
		private List<Expression> m_RValues;

		// Token: 0x0400025F RID: 607
		private SourceRef m_Ref;
	}
}
