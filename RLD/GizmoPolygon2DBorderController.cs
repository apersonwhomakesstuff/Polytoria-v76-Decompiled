using System;

namespace RLD
{
	// Token: 0x020000B6 RID: 182
	public abstract class GizmoPolygon2DBorderController : IGizmoPolygon2DBorderController
	{
		// Token: 0x0600084F RID: 2127 RVA: 0x00017382 File Offset: 0x00015582
		public GizmoPolygon2DBorderController(GizmoPolygon2DBorderControllerData data)
		{
		}

		// Token: 0x06000850 RID: 2128
		public abstract void UpdateHandles();

		// Token: 0x06000851 RID: 2129
		public abstract void UpdateEpsilons();

		// Token: 0x06000852 RID: 2130
		public abstract void UpdateTransforms();

		// Token: 0x04000324 RID: 804
		protected GizmoPolygon2DBorderControllerData _data;
	}
}
