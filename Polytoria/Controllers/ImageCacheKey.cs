using System;

namespace Polytoria.Controllers
{
	// Token: 0x0200032C RID: 812
	public struct ImageCacheKey
	{
		// Token: 0x06002867 RID: 10343 RVA: 0x0001CBCF File Offset: 0x0001ADCF
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x0001CBD2 File Offset: 0x0001ADD2
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000DA2 RID: 3490
		public string id;

		// Token: 0x04000DA3 RID: 3491
		public string url;

		// Token: 0x04000DA4 RID: 3492
		public ImageType type;
	}
}
