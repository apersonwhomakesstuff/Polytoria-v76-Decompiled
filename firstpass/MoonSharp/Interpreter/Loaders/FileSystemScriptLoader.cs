using System;

namespace MoonSharp.Interpreter.Loaders
{
	// Token: 0x02000090 RID: 144
	public class FileSystemScriptLoader : ScriptLoaderBase
	{
		// Token: 0x06000755 RID: 1877 RVA: 0x0000D7CF File Offset: 0x0000B9CF
		public override bool ScriptFileExists(string name)
		{
			return false;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0000D7D2 File Offset: 0x0000B9D2
		public override object LoadFile(string file, Table globalContext)
		{
			return null;
		}
	}
}
