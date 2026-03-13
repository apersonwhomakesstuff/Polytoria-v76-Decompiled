using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.Loaders
{
	// Token: 0x02000094 RID: 148
	public class UnityAssetsScriptLoader : ScriptLoaderBase
	{
		// Token: 0x0600076B RID: 1899 RVA: 0x0000D827 File Offset: 0x0000BA27
		public UnityAssetsScriptLoader(string assetsPath = null)
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0000D82F File Offset: 0x0000BA2F
		public UnityAssetsScriptLoader(Dictionary<string, string> scriptToCodeMap)
		{
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0000D837 File Offset: 0x0000BA37
		private void LoadResourcesWithReflection(string assetsPath)
		{
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0000D839 File Offset: 0x0000BA39
		private string GetFileName(string filename)
		{
			return null;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0000D83C File Offset: 0x0000BA3C
		public override object LoadFile(string file, Table globalContext)
		{
			return null;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0000D83F File Offset: 0x0000BA3F
		public override bool ScriptFileExists(string file)
		{
			return false;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0000D842 File Offset: 0x0000BA42
		public string[] GetLoadedScripts()
		{
			return null;
		}

		// Token: 0x040002E1 RID: 737
		private Dictionary<string, string> m_Resources;

		// Token: 0x040002E2 RID: 738
		public const string DEFAULT_PATH = "MoonSharp/Scripts";
	}
}
