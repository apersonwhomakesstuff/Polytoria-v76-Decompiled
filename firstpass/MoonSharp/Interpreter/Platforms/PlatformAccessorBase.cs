using System;
using System.IO;
using System.Text;

namespace MoonSharp.Interpreter.Platforms
{
	// Token: 0x0200008B RID: 139
	public abstract class PlatformAccessorBase : IPlatformAccessor
	{
		// Token: 0x0600071F RID: 1823
		public abstract string GetPlatformNamePrefix();

		// Token: 0x06000720 RID: 1824 RVA: 0x0000D71A File Offset: 0x0000B91A
		public string GetPlatformName()
		{
			return null;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0000D71D File Offset: 0x0000B91D
		private string GetUnityRuntimeName()
		{
			return null;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0000D720 File Offset: 0x0000B920
		private string GetUnityPlatformName()
		{
			return null;
		}

		// Token: 0x06000723 RID: 1827
		public abstract void DefaultPrint(string content);

		// Token: 0x06000724 RID: 1828 RVA: 0x0000D723 File Offset: 0x0000B923
		public virtual string DefaultInput()
		{
			return null;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0000D726 File Offset: 0x0000B926
		public virtual string DefaultInput(string prompt)
		{
			return null;
		}

		// Token: 0x06000726 RID: 1830
		public abstract Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode);

		// Token: 0x06000727 RID: 1831
		public abstract Stream IO_GetStandardStream(StandardFileType type);

		// Token: 0x06000728 RID: 1832
		public abstract string IO_OS_GetTempFilename();

		// Token: 0x06000729 RID: 1833
		public abstract void OS_ExitFast(int exitCode);

		// Token: 0x0600072A RID: 1834
		public abstract bool OS_FileExists(string file);

		// Token: 0x0600072B RID: 1835
		public abstract void OS_FileDelete(string file);

		// Token: 0x0600072C RID: 1836
		public abstract void OS_FileMove(string src, string dst);

		// Token: 0x0600072D RID: 1837
		public abstract int OS_Execute(string cmdline);

		// Token: 0x0600072E RID: 1838
		public abstract CoreModules FilterSupportedCoreModules(CoreModules module);

		// Token: 0x0600072F RID: 1839
		public abstract string GetEnvironmentVariable(string envvarname);

		// Token: 0x06000730 RID: 1840 RVA: 0x0000D729 File Offset: 0x0000B929
		public virtual bool IsRunningOnAOT()
		{
			return false;
		}
	}
}
