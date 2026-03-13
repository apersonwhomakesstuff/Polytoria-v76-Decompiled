using System;

namespace RLD
{
	// Token: 0x020000C3 RID: 195
	public class GizmoCylindricalTorusCircle3DBorderController : GizmoCircle3DBorderController
	{
		// Token: 0x06000885 RID: 2181 RVA: 0x0001742E File Offset: 0x0001562E
		public GizmoCylindricalTorusCircle3DBorderController(GizmoCircle3DBorderControllerData controllerData) : base(null)
		{
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00017437 File Offset: 0x00015637
		public override void UpdateHandles()
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00017439 File Offset: 0x00015639
		public override void UpdateEpsilons(float zoomFactor)
		{
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0001743B File Offset: 0x0001563B
		public override void UpdateTransforms(float zoomFactor)
		{
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0001743D File Offset: 0x0001563D
		public float GetTorusCoreRadius(float zoomFactor)
		{
			return 0f;
		}
	}
}
