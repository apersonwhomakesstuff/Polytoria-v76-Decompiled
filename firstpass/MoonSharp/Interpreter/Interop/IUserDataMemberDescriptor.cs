using System;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x0200009F RID: 159
	public interface IUserDataMemberDescriptor
	{
		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060007BE RID: 1982
		string Name { get; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060007BF RID: 1983
		Type Type { get; }

		// Token: 0x060007C0 RID: 1984
		DynValue GetValue(Script script, object obj);

		// Token: 0x060007C1 RID: 1985
		bool SetValue(Script script, object obj, DynValue value);

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060007C2 RID: 1986
		UserDataMemberType MemberType { get; }

		// Token: 0x060007C3 RID: 1987
		void Optimize();

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060007C4 RID: 1988
		bool IsStatic { get; }
	}
}
