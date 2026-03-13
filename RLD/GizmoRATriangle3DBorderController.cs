using System;

namespace RLD
{
	// Token: 0x020000CE RID: 206
	public abstract class GizmoRATriangle3DBorderController : IGizmoRATriangle3DBorderController
	{
		// Token: 0x060008BC RID: 2236 RVA: 0x000174E9 File Offset: 0x000156E9
		public GizmoRATriangle3DBorderController(GizmoRATriangle3DBorderControllerData controllerData)
		{
		}

		// Token: 0x060008BD RID: 2237
		public abstract void UpdateHandles();

		// Token: 0x060008BE RID: 2238
		public abstract void UpdateEpsilons(float zoomFactor);

		// Token: 0x060008BF RID: 2239
		public abstract void UpdateTransforms(float zoomFactor);

		// Token: 0x04000393 RID: 915
		protected GizmoRATriangle3DBorderControllerData _data;
	}
}
