using System;

namespace MoonSharp.Interpreter.Loaders
{
	// Token: 0x02000091 RID: 145
	internal class InvalidScriptLoader : IScriptLoader
	{
		// Token: 0x06000758 RID: 1880 RVA: 0x0000D7DD File Offset: 0x0000B9DD
		internal InvalidScriptLoader(string frameworkname)
		{
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0000D7E5 File Offset: 0x0000B9E5
		public object LoadFile(string file, Table globalContext)
		{
			return null;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		public string ResolveFileName(string filename, Table globalContext)
		{
			return null;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0000D7EB File Offset: 0x0000B9EB
		public string ResolveModuleName(string modname, Table globalContext)
		{
			return null;
		}

		// Token: 0x040002DE RID: 734
		private string m_Error;
	}
}
