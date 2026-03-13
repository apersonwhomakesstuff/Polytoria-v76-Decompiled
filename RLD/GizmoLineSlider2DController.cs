using System;

namespace RLD
{
	// Token: 0x02000087 RID: 135
	public abstract class GizmoLineSlider2DController : IGizmoLineSlider2DController
	{
		// Token: 0x0600060A RID: 1546 RVA: 0x00016C98 File Offset: 0x00014E98
		public GizmoLineSlider2DController(GizmoLineSlider2DControllerData controllerData)
		{
		}

		// Token: 0x0600060B RID: 1547
		public abstract void UpdateHandles();

		// Token: 0x0600060C RID: 1548
		public abstract void UpdateTransforms();

		// Token: 0x0600060D RID: 1549
		public abstract void UpdateEpsilons();

		// Token: 0x04000202 RID: 514
		protected GizmoLineSlider2DControllerData _data;
	}
}
