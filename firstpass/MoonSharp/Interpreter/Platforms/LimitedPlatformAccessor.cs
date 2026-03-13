using System;
using System.IO;
using System.Text;

namespace MoonSharp.Interpreter.Platforms
{
	// Token: 0x0200008A RID: 138
	public class LimitedPlatformAccessor : PlatformAccessorBase
	{
		// Token: 0x06000712 RID: 1810 RVA: 0x0000D6F5 File Offset: 0x0000B8F5
		public override string GetEnvironmentVariable(string envvarname)
		{
			return null;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00010310 File Offset: 0x0000E510
		public override CoreModules FilterSupportedCoreModules(CoreModules module)
		{
			return CoreModules.None;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		public override Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode)
		{
			return null;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0000D6FB File Offset: 0x0000B8FB
		public override Stream IO_GetStandardStream(StandardFileType type)
		{
			return null;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0000D6FE File Offset: 0x0000B8FE
		public override string IO_OS_GetTempFilename()
		{
			return null;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0000D701 File Offset: 0x0000B901
		public override void OS_ExitFast(int exitCode)
		{
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0000D703 File Offset: 0x0000B903
		public override bool OS_FileExists(string file)
		{
			return false;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0000D706 File Offset: 0x0000B906
		public override void OS_FileDelete(string file)
		{
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0000D708 File Offset: 0x0000B908
		public override void OS_FileMove(string src, string dst)
		{
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0000D70A File Offset: 0x0000B90A
		public override int OS_Execute(string cmdline)
		{
			return 0;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0000D70D File Offset: 0x0000B90D
		public override string GetPlatformNamePrefix()
		{
			return null;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0000D710 File Offset: 0x0000B910
		public override void DefaultPrint(string content)
		{
		}
	}
}
