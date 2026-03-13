using System;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A0 RID: 160
	public interface IUserDataType
	{
		// Token: 0x060007C5 RID: 1989
		DynValue Index(Script script, DynValue index, bool isDirectIndexing);

		// Token: 0x060007C6 RID: 1990
		bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing);

		// Token: 0x060007C7 RID: 1991
		DynValue MetaIndex(Script script, string metaname);
	}
}
