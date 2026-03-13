using System;

namespace RLD
{
	// Token: 0x020000AF RID: 175
	public interface IGizmoPlaneSlider3DController
	{
		// Token: 0x06000830 RID: 2096
		void UpdateHandles();

		// Token: 0x06000831 RID: 2097
		void UpdateTransforms(float zoomFactor);

		// Token: 0x06000832 RID: 2098
		void UpdateEpsilons(float zoomFactor);
	}
}
