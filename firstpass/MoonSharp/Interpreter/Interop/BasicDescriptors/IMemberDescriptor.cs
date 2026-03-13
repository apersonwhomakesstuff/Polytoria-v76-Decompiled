using System;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	// Token: 0x020000D5 RID: 213
	public interface IMemberDescriptor
	{
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060009F6 RID: 2550
		bool IsStatic { get; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060009F7 RID: 2551
		string Name { get; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060009F8 RID: 2552
		MemberDescriptorAccess MemberAccess { get; }

		// Token: 0x060009F9 RID: 2553
		DynValue GetValue(Script script, object obj);

		// Token: 0x060009FA RID: 2554
		void SetValue(Script script, object obj, DynValue value);
	}
}
