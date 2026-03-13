using System;
using System.IO;

namespace MoonSharp.Interpreter.IO
{
	// Token: 0x02000098 RID: 152
	public class UndisposableStream : Stream
	{
		// Token: 0x0600077C RID: 1916 RVA: 0x0000D876 File Offset: 0x0000BA76
		public UndisposableStream(Stream stream)
		{
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0000D87E File Offset: 0x0000BA7E
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0000D880 File Offset: 0x0000BA80
		public override void Close()
		{
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x0000D882 File Offset: 0x0000BA82
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0000D885 File Offset: 0x0000BA85
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x0000D888 File Offset: 0x0000BA88
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0000D88B File Offset: 0x0000BA8B
		public override void Flush()
		{
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x0000D88D File Offset: 0x0000BA8D
		public override long Length
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0000D891 File Offset: 0x0000BA91
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x0000D895 File Offset: 0x0000BA95
		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0000D897 File Offset: 0x0000BA97
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0000D89A File Offset: 0x0000BA9A
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0000D89E File Offset: 0x0000BA9E
		public override void SetLength(long value)
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0000D8A2 File Offset: 0x0000BAA2
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0000D8A5 File Offset: 0x0000BAA5
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0000D8AA File Offset: 0x0000BAAA
		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x0000D8AD File Offset: 0x0000BAAD
		public override bool CanTimeout
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0000D8B0 File Offset: 0x0000BAB0
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0000D8B3 File Offset: 0x0000BAB3
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0000D8B6 File Offset: 0x0000BAB6
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x0000D8B9 File Offset: 0x0000BAB9
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x0000D8BC File Offset: 0x0000BABC
		public override int ReadTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0000D8BE File Offset: 0x0000BABE
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0000D8C1 File Offset: 0x0000BAC1
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x0000D8C3 File Offset: 0x0000BAC3
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x0000D8C6 File Offset: 0x0000BAC6
		public override int WriteTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x040002E5 RID: 741
		private Stream m_Stream;
	}
}
