using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000090 RID: 144
	public abstract class GizmoPlaneSlider2DController : IGizmoPlaneSlider2DController
	{
		// Token: 0x06000683 RID: 1667 RVA: 0x00016DFC File Offset: 0x00014FFC
		public GizmoPlaneSlider2DController(GizmoPlaneSlider2DControllerData controllerData)
		{
		}

		// Token: 0x06000684 RID: 1668
		public abstract void UpdateHandles();

		// Token: 0x06000685 RID: 1669
		public abstract void UpdateTransforms();

		// Token: 0x06000686 RID: 1670
		public abstract void UpdateEpsilons();

		// Token: 0x06000687 RID: 1671
		public abstract Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt);

		// Token: 0x0400023F RID: 575
		protected GizmoPlaneSlider2DControllerData _data;
	}
}
