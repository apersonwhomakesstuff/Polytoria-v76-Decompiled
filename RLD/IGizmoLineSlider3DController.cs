using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000A2 RID: 162
	public interface IGizmoLineSlider3DController
	{
		// Token: 0x0600076F RID: 1903
		void UpdateHandles();

		// Token: 0x06000770 RID: 1904
		void UpdateTransforms(float zoomFactor);

		// Token: 0x06000771 RID: 1905
		void UpdateEpsilons(float zoomFactor);

		// Token: 0x06000772 RID: 1906
		float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor);
	}
}
