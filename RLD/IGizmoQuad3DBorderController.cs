using System;

namespace RLD
{
	// Token: 0x020000CC RID: 204
	public interface IGizmoQuad3DBorderController
	{
		// Token: 0x060008AF RID: 2223
		void UpdateHandles();

		// Token: 0x060008B0 RID: 2224
		void UpdateEpsilons(float zoomFactor);

		// Token: 0x060008B1 RID: 2225
		void UpdateTransforms(float zoomFactor);
	}
}
