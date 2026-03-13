using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200009D RID: 157
	public abstract class GizmoLineSlider3DController : IGizmoLineSlider3DController
	{
		// Token: 0x06000734 RID: 1844 RVA: 0x00017014 File Offset: 0x00015214
		public GizmoLineSlider3DController(GizmoLineSlider3DControllerData controllerData)
		{
		}

		// Token: 0x06000735 RID: 1845
		public abstract void UpdateHandles();

		// Token: 0x06000736 RID: 1846
		public abstract void UpdateTransforms(float zoomFactor);

		// Token: 0x06000737 RID: 1847
		public abstract void UpdateEpsilons(float zoomFactor);

		// Token: 0x06000738 RID: 1848
		public abstract float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor);

		// Token: 0x04000289 RID: 649
		protected GizmoLineSlider3DControllerData _data;
	}
}
