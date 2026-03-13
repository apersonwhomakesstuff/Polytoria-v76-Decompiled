using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000A1 RID: 161
	public class GizmoThinLineSlider3DController : GizmoLineSlider3DController
	{
		// Token: 0x0600076A RID: 1898 RVA: 0x000170CE File Offset: 0x000152CE
		public GizmoThinLineSlider3DController(GizmoLineSlider3DControllerData controllerData) : base(null)
		{
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x000170D7 File Offset: 0x000152D7
		public override void UpdateHandles()
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000170D9 File Offset: 0x000152D9
		public override void UpdateTransforms(float zoomFactor)
		{
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x000170DB File Offset: 0x000152DB
		public override void UpdateEpsilons(float zoomFactor)
		{
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000170DD File Offset: 0x000152DD
		public override float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor)
		{
			return 0f;
		}
	}
}
