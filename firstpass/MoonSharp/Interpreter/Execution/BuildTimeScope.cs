using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Execution.Scopes;
using MoonSharp.Interpreter.Tree.Statements;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000DE RID: 222
	internal class BuildTimeScope
	{
		// Token: 0x06000A21 RID: 2593 RVA: 0x0000E36D File Offset: 0x0000C56D
		public void PushFunction(IClosureBuilder closureBuilder, bool hasVarArgs)
		{
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0000E36F File Offset: 0x0000C56F
		public void PushBlock()
		{
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0000E371 File Offset: 0x0000C571
		public RuntimeScopeBlock PopBlock()
		{
			return null;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0000E374 File Offset: 0x0000C574
		public RuntimeScopeFrame PopFunction()
		{
			return null;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0000E377 File Offset: 0x0000C577
		public SymbolRef Find(string name)
		{
			return null;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0000E37A File Offset: 0x0000C57A
		public SymbolRef CreateGlobalReference(string name)
		{
			return null;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0000E37D File Offset: 0x0000C57D
		public void ForceEnvUpValue()
		{
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0000E37F File Offset: 0x0000C57F
		private SymbolRef CreateUpValue(BuildTimeScope buildTimeScope, SymbolRef symb, int closuredFrame, int currentFrame)
		{
			return null;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0000E382 File Offset: 0x0000C582
		public SymbolRef DefineLocal(string name)
		{
			return null;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0000E385 File Offset: 0x0000C585
		public SymbolRef TryDefineLocal(string name)
		{
			return null;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0000E388 File Offset: 0x0000C588
		public bool CurrentFunctionHasVarArgs()
		{
			return false;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0000E38B File Offset: 0x0000C58B
		internal void DefineLabel(LabelStatement label)
		{
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0000E38D File Offset: 0x0000C58D
		internal void RegisterGoto(GotoStatement gotostat)
		{
		}

		// Token: 0x040003C4 RID: 964
		private List<BuildTimeScopeFrame> m_Frames;

		// Token: 0x040003C5 RID: 965
		private List<IClosureBuilder> m_ClosureBuilders;
	}
}
