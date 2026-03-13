using System;

namespace Discord
{
	// Token: 0x02000142 RID: 322
	public struct ImageHandle
	{
		// Token: 0x06000D5B RID: 3419 RVA: 0x00010688 File Offset: 0x0000E888
		public static ImageHandle User(long id)
		{
			return default(ImageHandle);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x000106A0 File Offset: 0x0000E8A0
		public static ImageHandle User(long id, uint size)
		{
			return default(ImageHandle);
		}

		// Token: 0x0400054F RID: 1359
		public ImageType Type;

		// Token: 0x04000550 RID: 1360
		public long Id;

		// Token: 0x04000551 RID: 1361
		public uint Size;
	}
}
