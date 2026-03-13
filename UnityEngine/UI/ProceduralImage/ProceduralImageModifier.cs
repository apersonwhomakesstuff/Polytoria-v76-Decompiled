using System;

namespace UnityEngine.UI.ProceduralImage
{
	// Token: 0x02000345 RID: 837
	public abstract class ProceduralImageModifier : MonoBehaviour
	{
		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x0001D072 File Offset: 0x0001B272
		protected Graphic _Graphic
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060029BD RID: 10685
		public abstract Vector4 CalculateRadius(Rect imageRect);

		// Token: 0x04000E6C RID: 3692
		protected Graphic graphic;
	}
}
