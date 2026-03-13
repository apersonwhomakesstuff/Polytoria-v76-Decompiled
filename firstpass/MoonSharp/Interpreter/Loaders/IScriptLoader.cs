using System;

namespace MoonSharp.Interpreter.Loaders
{
	// Token: 0x02000092 RID: 146
	public interface IScriptLoader
	{
		// Token: 0x0600075C RID: 1884
		object LoadFile(string file, Table globalContext);

		// Token: 0x0600075D RID: 1885
		string ResolveFileName(string filename, Table globalContext);

		// Token: 0x0600075E RID: 1886
		string ResolveModuleName(string modname, Table globalContext);
	}
}
