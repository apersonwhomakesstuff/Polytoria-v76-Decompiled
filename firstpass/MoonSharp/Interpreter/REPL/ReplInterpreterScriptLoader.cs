using System;
using MoonSharp.Interpreter.Loaders;

namespace MoonSharp.Interpreter.REPL
{
	// Token: 0x02000087 RID: 135
	public class ReplInterpreterScriptLoader : FileSystemScriptLoader
	{
		// Token: 0x06000703 RID: 1795 RVA: 0x0000D6F2 File Offset: 0x0000B8F2
		public override string ResolveModuleName(string modname, Table globalContext)
		{
			return null;
		}
	}
}
