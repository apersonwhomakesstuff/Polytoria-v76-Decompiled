using System;
using MoonSharp.Interpreter.DataStructs;

namespace MoonSharp.Interpreter.Execution.VM
{
	// Token: 0x020000E9 RID: 233
	internal sealed class ExecutionState
	{
		// Token: 0x040003EB RID: 1003
		public FastStack<DynValue> ValueStack;

		// Token: 0x040003EC RID: 1004
		public FastStack<CallStackItem> ExecutionStack;

		// Token: 0x040003ED RID: 1005
		public int InstructionPtr;

		// Token: 0x040003EE RID: 1006
		public CoroutineState State;
	}
}
