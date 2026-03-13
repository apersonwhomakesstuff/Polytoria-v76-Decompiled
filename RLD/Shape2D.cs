using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001E8 RID: 488
	public abstract class Shape2D
	{
		// Token: 0x060016D6 RID: 5846
		public abstract void RenderArea(Camera camera);

		// Token: 0x060016D7 RID: 5847
		public abstract void RenderBorder(Camera camera);

		// Token: 0x060016D8 RID: 5848
		public abstract bool ContainsPoint(Vector2 point);

		// Token: 0x060016D9 RID: 5849
		public abstract Rect GetEncapsulatingRect();
	}
}
