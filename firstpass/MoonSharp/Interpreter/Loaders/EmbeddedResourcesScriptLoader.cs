using System;
using System.Collections.Generic;
using System.Reflection;

namespace MoonSharp.Interpreter.Loaders
{
	// Token: 0x0200008F RID: 143
	public class EmbeddedResourcesScriptLoader : ScriptLoaderBase
	{
		// Token: 0x06000751 RID: 1873 RVA: 0x0000D7BE File Offset: 0x0000B9BE
		public EmbeddedResourcesScriptLoader(Assembly resourceAssembly = null)
		{
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0000D7C6 File Offset: 0x0000B9C6
		private string FileNameToResource(string file)
		{
			return null;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0000D7C9 File Offset: 0x0000B9C9
		public override bool ScriptFileExists(string name)
		{
			return false;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0000D7CC File Offset: 0x0000B9CC
		public override object LoadFile(string file, Table globalContext)
		{
			return null;
		}

		// Token: 0x040002DB RID: 731
		private Assembly m_ResourceAssembly;

		// Token: 0x040002DC RID: 732
		private HashSet<string> m_ResourceNames;

		// Token: 0x040002DD RID: 733
		private string m_Namespace;
	}
}
