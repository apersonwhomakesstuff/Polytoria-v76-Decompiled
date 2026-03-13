using System;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	// Token: 0x020000D8 RID: 216
	public interface IOverloadableMemberDescriptor : IMemberDescriptor
	{
		// Token: 0x06000A03 RID: 2563
		DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args);

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000A04 RID: 2564
		Type ExtensionMethodType { get; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000A05 RID: 2565
		ParameterDescriptor[] Parameters { get; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000A06 RID: 2566
		Type VarArgsArrayType { get; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000A07 RID: 2567
		Type VarArgsElementType { get; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000A08 RID: 2568
		string SortDiscriminant { get; }
	}
}
