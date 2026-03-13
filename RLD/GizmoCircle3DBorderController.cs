using System;

namespace RLD
{
	// Token: 0x020000C1 RID: 193
	public abstract class GizmoCircle3DBorderController : IGizmoCircle3DBorderController
	{
		// Token: 0x06000880 RID: 2176 RVA: 0x0001741E File Offset: 0x0001561E
		public GizmoCircle3DBorderController(GizmoCircle3DBorderControllerData controllerData)
		{
		}

		// Token: 0x06000881 RID: 2177
		public abstract void UpdateHandles();

		// Token: 0x06000882 RID: 2178
		public abstract void UpdateEpsilons(float zoomFactor);

		// Token: 0x06000883 RID: 2179
		public abstract void UpdateTransforms(float zoomFactor);

		// Token: 0x0400034C RID: 844
		protected GizmoCircle3DBorderControllerData _data;
	}
}
