using System;

namespace RLD
{
	// Token: 0x020000B1 RID: 177
	public abstract class GizmoCircle2DBorderController : IGizmoCircle2DBorderController
	{
		// Token: 0x0600083B RID: 2107 RVA: 0x0001734B File Offset: 0x0001554B
		public GizmoCircle2DBorderController(GizmoCircle2DBorderControllerData data)
		{
		}

		// Token: 0x0600083C RID: 2108
		public abstract void UpdateHandles();

		// Token: 0x0600083D RID: 2109
		public abstract void UpdateEpsilons();

		// Token: 0x0600083E RID: 2110
		public abstract void UpdateTransforms();

		// Token: 0x04000311 RID: 785
		protected GizmoCircle2DBorderControllerData _data;
	}
}
