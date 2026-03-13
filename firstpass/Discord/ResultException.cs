using System;

namespace Discord
{
	// Token: 0x02000158 RID: 344
	public class ResultException : Exception
	{
		// Token: 0x06000D6C RID: 3436 RVA: 0x0000EF6C File Offset: 0x0000D16C
		public ResultException(Result result)
		{
		}

		// Token: 0x04000598 RID: 1432
		public readonly Result Result;
	}
}
