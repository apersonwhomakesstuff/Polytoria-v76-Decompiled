using System;
using System.IO;

namespace MoonSharp.Interpreter.CoreLib.IO
{
	// Token: 0x02000120 RID: 288
	internal abstract class StreamFileUserDataBase : FileUserDataBase
	{
		// Token: 0x06000CE7 RID: 3303 RVA: 0x0000EE53 File Offset: 0x0000D053
		protected void Initialize(Stream stream, StreamReader reader, StreamWriter writer)
		{
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0000EE55 File Offset: 0x0000D055
		private void CheckFileIsNotClosed()
		{
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0000EE57 File Offset: 0x0000D057
		protected override bool Eof()
		{
			return false;
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0000EE5A File Offset: 0x0000D05A
		protected override string ReadLine()
		{
			return null;
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0000EE5D File Offset: 0x0000D05D
		protected override string ReadToEnd()
		{
			return null;
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0000EE60 File Offset: 0x0000D060
		protected override string ReadBuffer(int p)
		{
			return null;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0000EE63 File Offset: 0x0000D063
		protected override char Peek()
		{
			return '\0';
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0000EE66 File Offset: 0x0000D066
		protected override void Write(string value)
		{
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0000EE68 File Offset: 0x0000D068
		protected override string Close()
		{
			return null;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0000EE6B File Offset: 0x0000D06B
		public override bool flush()
		{
			return false;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0000EE6E File Offset: 0x0000D06E
		public override long seek(string whence, long offset = 0L)
		{
			return 0L;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0000EE72 File Offset: 0x0000D072
		public override bool setvbuf(string mode)
		{
			return false;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0000EE75 File Offset: 0x0000D075
		protected internal override bool isopen()
		{
			return false;
		}

		// Token: 0x040004B2 RID: 1202
		protected Stream m_Stream;

		// Token: 0x040004B3 RID: 1203
		protected StreamReader m_Reader;

		// Token: 0x040004B4 RID: 1204
		protected StreamWriter m_Writer;

		// Token: 0x040004B5 RID: 1205
		protected bool m_Closed;
	}
}
