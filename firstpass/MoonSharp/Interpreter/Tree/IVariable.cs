using System;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x0200005B RID: 91
	internal interface IVariable
	{
		// Token: 0x06000610 RID: 1552
		void CompileAssignment(ByteCode bc, int stackofs, int tupleidx);
	}
}
