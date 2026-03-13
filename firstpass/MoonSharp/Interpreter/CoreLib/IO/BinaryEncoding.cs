using System;
using System.Text;

namespace MoonSharp.Interpreter.CoreLib.IO
{
	// Token: 0x0200011C RID: 284
	internal class BinaryEncoding : Encoding
	{
		// Token: 0x06000CC9 RID: 3273 RVA: 0x0000EE0E File Offset: 0x0000D00E
		public override int GetByteCount(char[] chars, int index, int count)
		{
			return 0;
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0000EE11 File Offset: 0x0000D011
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return 0;
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x0000EE14 File Offset: 0x0000D014
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return 0;
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x0000EE17 File Offset: 0x0000D017
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return 0;
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0000EE1A File Offset: 0x0000D01A
		public override int GetMaxByteCount(int charCount)
		{
			return 0;
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x0000EE1D File Offset: 0x0000D01D
		public override int GetMaxCharCount(int byteCount)
		{
			return 0;
		}
	}
}
