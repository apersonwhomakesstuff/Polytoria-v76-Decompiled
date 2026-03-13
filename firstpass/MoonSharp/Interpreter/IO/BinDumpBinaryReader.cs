using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MoonSharp.Interpreter.IO
{
	// Token: 0x02000096 RID: 150
	public class BinDumpBinaryReader : BinaryReader
	{
		// Token: 0x06000772 RID: 1906 RVA: 0x0000D845 File Offset: 0x0000BA45
		public BinDumpBinaryReader(Stream s) : base(null)
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0000D84E File Offset: 0x0000BA4E
		public BinDumpBinaryReader(Stream s, Encoding e) : base(null)
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0000D857 File Offset: 0x0000BA57
		public override int ReadInt32()
		{
			return 0;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0000D85A File Offset: 0x0000BA5A
		public override uint ReadUInt32()
		{
			return 0U;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0000D85D File Offset: 0x0000BA5D
		public override string ReadString()
		{
			return null;
		}

		// Token: 0x040002E3 RID: 739
		private List<string> m_Strings;
	}
}
