using System;

namespace RLD
{
	// Token: 0x020000A7 RID: 167
	public abstract class GizmoPlaneSlider3DController : IGizmoPlaneSlider3DController
	{
		// Token: 0x060007CC RID: 1996 RVA: 0x000171DC File Offset: 0x000153DC
		public GizmoPlaneSlider3DController(GizmoPlaneSlider3DControllerData controllerData)
		{
		}

		// Token: 0x060007CD RID: 1997
		public abstract void UpdateHandles();

		// Token: 0x060007CE RID: 1998
		public abstract void UpdateTransforms(float zoomFactor);

		// Token: 0x060007CF RID: 1999
		public abstract void UpdateEpsilons(float zoomFactor);

		// Token: 0x040002CB RID: 715
		protected GizmoPlaneSlider3DControllerData _data;
	}
}
