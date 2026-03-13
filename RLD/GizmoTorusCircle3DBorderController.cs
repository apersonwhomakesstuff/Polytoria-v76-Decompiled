using System;

namespace RLD
{
	// Token: 0x020000C5 RID: 197
	public class GizmoTorusCircle3DBorderController : GizmoCircle3DBorderController
	{
		// Token: 0x0600088E RID: 2190 RVA: 0x00017453 File Offset: 0x00015653
		public GizmoTorusCircle3DBorderController(GizmoCircle3DBorderControllerData controllerData) : base(null)
		{
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0001745C File Offset: 0x0001565C
		public override void UpdateHandles()
		{
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0001745E File Offset: 0x0001565E
		public override void UpdateEpsilons(float zoomFactor)
		{
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00017460 File Offset: 0x00015660
		public override void UpdateTransforms(float zoomFactor)
		{
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00017462 File Offset: 0x00015662
		public float GetTorusCoreRadius(float zoomFactor)
		{
			return 0f;
		}
	}
}
