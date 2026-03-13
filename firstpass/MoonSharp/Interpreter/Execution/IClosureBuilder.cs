using System;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000E0 RID: 224
	internal interface IClosureBuilder
	{
		// Token: 0x06000A33 RID: 2611
		SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol);
	}
}
