using System;
using System.IO;
using System.Text;

namespace MoonSharp.Interpreter.Platforms
{
	// Token: 0x0200008E RID: 142
	public class StandardPlatformAccessor : PlatformAccessorBase
	{
		// Token: 0x06000742 RID: 1858 RVA: 0x00010328 File Offset: 0x0000E528
		public static FileAccess ParseFileAccess(string mode)
		{
			return (FileAccess)0;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00010340 File Offset: 0x0000E540
		public static FileMode ParseFileMode(string mode)
		{
			return (FileMode)0;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0000D799 File Offset: 0x0000B999
		public override Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode)
		{
			return null;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0000D79C File Offset: 0x0000B99C
		public override string GetEnvironmentVariable(string envvarname)
		{
			return null;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0000D79F File Offset: 0x0000B99F
		public override Stream IO_GetStandardStream(StandardFileType type)
		{
			return null;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0000D7A2 File Offset: 0x0000B9A2
		public override void DefaultPrint(string content)
		{
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0000D7A4 File Offset: 0x0000B9A4
		public override string IO_OS_GetTempFilename()
		{
			return null;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0000D7A7 File Offset: 0x0000B9A7
		public override void OS_ExitFast(int exitCode)
		{
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0000D7A9 File Offset: 0x0000B9A9
		public override bool OS_FileExists(string file)
		{
			return false;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0000D7AC File Offset: 0x0000B9AC
		public override void OS_FileDelete(string file)
		{
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0000D7AE File Offset: 0x0000B9AE
		public override void OS_FileMove(string src, string dst)
		{
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
		public override int OS_Execute(string cmdline)
		{
			return 0;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00010358 File Offset: 0x0000E558
		public override CoreModules FilterSupportedCoreModules(CoreModules module)
		{
			return CoreModules.None;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0000D7B3 File Offset: 0x0000B9B3
		public override string GetPlatformNamePrefix()
		{
			return null;
		}
	}
}
