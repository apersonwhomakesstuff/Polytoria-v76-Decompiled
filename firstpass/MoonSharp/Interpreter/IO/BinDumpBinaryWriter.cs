using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MoonSharp.Interpreter.IO
{
	// Token: 0x02000097 RID: 151
	public class BinDumpBinaryWriter : BinaryWriter
	{
		// Token: 0x06000777 RID: 1911 RVA: 0x0000D860 File Offset: 0x0000BA60
		public BinDumpBinaryWriter(Stream s)
		{
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0000D868 File Offset: 0x0000BA68
		public BinDumpBinaryWriter(Stream s, Encoding e)
		{
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0000D870 File Offset: 0x0000BA70
		public override void Write(uint value)
		{
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0000D872 File Offset: 0x0000BA72
		public override void Write(int value)
		{
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0000D874 File Offset: 0x0000BA74
		public override void Write(string value)
		{
		}

		// Token: 0x040002E4 RID: 740
		private Dictionary<string, int> m_StringMap;
	}
}
