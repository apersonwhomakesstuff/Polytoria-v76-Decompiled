using System;
using System.IO;

namespace MoonSharp.Interpreter.CoreLib.IO
{
	// Token: 0x0200011F RID: 287
	internal class StandardIOFileUserDataBase : StreamFileUserDataBase
	{
		// Token: 0x06000CE3 RID: 3299 RVA: 0x0000EE42 File Offset: 0x0000D042
		protected override string Close()
		{
			return null;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0000EE45 File Offset: 0x0000D045
		public static StandardIOFileUserDataBase CreateInputStream(Stream stream)
		{
			return null;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0000EE48 File Offset: 0x0000D048
		public static StandardIOFileUserDataBase CreateOutputStream(Stream stream)
		{
			return null;
		}
	}
}
