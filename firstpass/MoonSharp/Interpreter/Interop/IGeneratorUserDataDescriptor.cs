using System;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x0200009C RID: 156
	public interface IGeneratorUserDataDescriptor : IUserDataDescriptor
	{
		// Token: 0x060007B3 RID: 1971
		IUserDataDescriptor Generate(Type type);
	}
}
