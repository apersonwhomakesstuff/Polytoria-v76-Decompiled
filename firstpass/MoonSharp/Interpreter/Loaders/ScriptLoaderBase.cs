using System;

namespace MoonSharp.Interpreter.Loaders
{
	// Token: 0x02000093 RID: 147
	public abstract class ScriptLoaderBase : IScriptLoader
	{
		// Token: 0x0600075F RID: 1887
		public abstract bool ScriptFileExists(string name);

		// Token: 0x06000760 RID: 1888
		public abstract object LoadFile(string file, Table globalContext);

		// Token: 0x06000761 RID: 1889 RVA: 0x0000D7EE File Offset: 0x0000B9EE
		protected virtual string ResolveModuleName(string modname, string[] paths)
		{
			return null;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0000D7F1 File Offset: 0x0000B9F1
		public virtual string ResolveModuleName(string modname, Table globalContext)
		{
			return null;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0000D7F4 File Offset: 0x0000B9F4
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x0000D7FC File Offset: 0x0000B9FC
		public string[] ModulePaths
		{
			get
			{
				return this.<ModulePaths>k__BackingField;
			}
			set
			{
				this.<ModulePaths>k__BackingField = value;
			}
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0000D805 File Offset: 0x0000BA05
		public static string[] UnpackStringPaths(string str)
		{
			return null;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0000D808 File Offset: 0x0000BA08
		public static string[] GetDefaultEnvironmentPaths()
		{
			return null;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0000D80B File Offset: 0x0000BA0B
		public virtual string ResolveFileName(string filename, Table globalContext)
		{
			return null;
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x0000D80E File Offset: 0x0000BA0E
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x0000D816 File Offset: 0x0000BA16
		public bool IgnoreLuaPathGlobal
		{
			get
			{
				return this.<IgnoreLuaPathGlobal>k__BackingField;
			}
			set
			{
				this.<IgnoreLuaPathGlobal>k__BackingField = value;
			}
		}

		// Token: 0x040002DF RID: 735
		private string[] <ModulePaths>k__BackingField;

		// Token: 0x040002E0 RID: 736
		private bool <IgnoreLuaPathGlobal>k__BackingField;

		// Token: 0x02000194 RID: 404
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000F4C RID: 3916 RVA: 0x0000F462 File Offset: 0x0000D662
			internal string <UnpackStringPaths>b__8_0(string s)
			{
				return null;
			}

			// Token: 0x06000F4D RID: 3917 RVA: 0x0000F465 File Offset: 0x0000D665
			internal bool <UnpackStringPaths>b__8_1(string s)
			{
				return false;
			}

			// Token: 0x04000688 RID: 1672
			public static readonly ScriptLoaderBase.<>c <>9;

			// Token: 0x04000689 RID: 1673
			public static Func<string, string> <>9__8_0;

			// Token: 0x0400068A RID: 1674
			public static Func<string, bool> <>9__8_1;
		}
	}
}
