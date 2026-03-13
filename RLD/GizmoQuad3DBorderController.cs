using System;

namespace RLD
{
	// Token: 0x020000C9 RID: 201
	public abstract class GizmoQuad3DBorderController : IGizmoQuad3DBorderController
	{
		// Token: 0x060008A6 RID: 2214 RVA: 0x000174A8 File Offset: 0x000156A8
		public GizmoQuad3DBorderController(GizmoQuad3DBorderControllerData data)
		{
		}

		// Token: 0x060008A7 RID: 2215
		public abstract void UpdateHandles();

		// Token: 0x060008A8 RID: 2216
		public abstract void UpdateEpsilons(float zoomFactor);

		// Token: 0x060008A9 RID: 2217
		public abstract void UpdateTransforms(float zoomFactor);

		// Token: 0x04000372 RID: 882
		protected GizmoQuad3DBorderControllerData _data;
	}
}
