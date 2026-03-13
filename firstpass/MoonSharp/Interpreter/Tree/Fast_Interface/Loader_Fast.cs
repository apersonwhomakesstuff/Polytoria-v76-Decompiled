using System;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Tree.Expressions;

namespace MoonSharp.Interpreter.Tree.Fast_Interface
{
	// Token: 0x02000074 RID: 116
	internal static class Loader_Fast
	{
		// Token: 0x06000695 RID: 1685 RVA: 0x0000D527 File Offset: 0x0000B727
		internal static DynamicExprExpression LoadDynamicExpr(Script script, SourceCode source)
		{
			return null;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0000D52A File Offset: 0x0000B72A
		private static ScriptLoadingContext CreateLoadingContext(Script script, SourceCode source)
		{
			return null;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0000D52D File Offset: 0x0000B72D
		internal static int LoadChunk(Script script, SourceCode source, ByteCode bytecode)
		{
			return 0;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0000D530 File Offset: 0x0000B730
		internal static int LoadFunction(Script script, SourceCode source, ByteCode bytecode, bool usesGlobalEnv)
		{
			return 0;
		}
	}
}
