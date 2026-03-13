using System;

namespace UnityEngine.UI.ProceduralImage
{
	// Token: 0x02000344 RID: 836
	public struct ProceduralImageInfo
	{
		// Token: 0x060029BB RID: 10683 RVA: 0x00026308 File Offset: 0x00024508
		public ProceduralImageInfo(float width, float height, float fallOffDistance, float pixelSize, Vector4 radius, float borderWidth)
		{
			this.width = 0f;
			this.height = 0f;
			this.fallOffDistance = 0f;
			this.radius = default(Vector4);
			this.borderWidth = 0f;
			this.pixelSize = 0f;
		}

		// Token: 0x04000E66 RID: 3686
		public float width;

		// Token: 0x04000E67 RID: 3687
		public float height;

		// Token: 0x04000E68 RID: 3688
		public float fallOffDistance;

		// Token: 0x04000E69 RID: 3689
		public Vector4 radius;

		// Token: 0x04000E6A RID: 3690
		public float borderWidth;

		// Token: 0x04000E6B RID: 3691
		public float pixelSize;
	}
}
