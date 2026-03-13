using System;
using System.IO;
using System.Text;

namespace MoonSharp.Interpreter.Platforms
{
	// Token: 0x02000089 RID: 137
	public interface IPlatformAccessor
	{
		// Token: 0x06000704 RID: 1796
		CoreModules FilterSupportedCoreModules(CoreModules module);

		// Token: 0x06000705 RID: 1797
		string GetEnvironmentVariable(string envvarname);

		// Token: 0x06000706 RID: 1798
		bool IsRunningOnAOT();

		// Token: 0x06000707 RID: 1799
		string GetPlatformName();

		// Token: 0x06000708 RID: 1800
		void DefaultPrint(string content);

		// Token: 0x06000709 RID: 1801
		string DefaultInput(string prompt);

		// Token: 0x0600070A RID: 1802
		Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode);

		// Token: 0x0600070B RID: 1803
		Stream IO_GetStandardStream(StandardFileType type);

		// Token: 0x0600070C RID: 1804
		string IO_OS_GetTempFilename();

		// Token: 0x0600070D RID: 1805
		void OS_ExitFast(int exitCode);

		// Token: 0x0600070E RID: 1806
		bool OS_FileExists(string file);

		// Token: 0x0600070F RID: 1807
		void OS_FileDelete(string file);

		// Token: 0x06000710 RID: 1808
		void OS_FileMove(string src, string dst);

		// Token: 0x06000711 RID: 1809
		int OS_Execute(string cmdline);
	}
}
