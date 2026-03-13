using System;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter.Execution.VM
{
	// Token: 0x020000E7 RID: 231
	internal class CallStackItem
	{
		// Token: 0x040003D8 RID: 984
		public int Debug_EntryPoint;

		// Token: 0x040003D9 RID: 985
		public SymbolRef[] Debug_Symbols;

		// Token: 0x040003DA RID: 986
		public SourceRef CallingSourceRef;

		// Token: 0x040003DB RID: 987
		public CallbackFunction ClrFunction;

		// Token: 0x040003DC RID: 988
		public CallbackFunction Continuation;

		// Token: 0x040003DD RID: 989
		public CallbackFunction ErrorHandler;

		// Token: 0x040003DE RID: 990
		public DynValue ErrorHandlerBeforeUnwind;

		// Token: 0x040003DF RID: 991
		public int BasePointer;

		// Token: 0x040003E0 RID: 992
		public int ReturnAddress;

		// Token: 0x040003E1 RID: 993
		public DynValue[] LocalScope;

		// Token: 0x040003E2 RID: 994
		public ClosureContext ClosureScope;

		// Token: 0x040003E3 RID: 995
		public CallStackItemFlags Flags;
	}
}
