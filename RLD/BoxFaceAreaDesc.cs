using System;

namespace RLD
{
	// Token: 0x0200014D RID: 333
	public struct BoxFaceAreaDesc
	{
		// Token: 0x060010B5 RID: 4277 RVA: 0x0002152C File Offset: 0x0001F72C
		public BoxFaceAreaDesc(BoxFaceAreaType areaType, float area)
		{
			this.AreaType = BoxFaceAreaType.Invalid;
			this.Area = 0f;
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00021554 File Offset: 0x0001F754
		public static BoxFaceAreaDesc GetInvalid()
		{
			return default(BoxFaceAreaDesc);
		}

		// Token: 0x040005C7 RID: 1479
		public BoxFaceAreaType AreaType;

		// Token: 0x040005C8 RID: 1480
		public float Area;
	}
}
