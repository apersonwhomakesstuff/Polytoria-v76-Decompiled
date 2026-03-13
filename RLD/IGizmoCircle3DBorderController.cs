using System;

namespace RLD
{
	// Token: 0x020000C6 RID: 198
	public interface IGizmoCircle3DBorderController
	{
		// Token: 0x06000893 RID: 2195
		void UpdateHandles();

		// Token: 0x06000894 RID: 2196
		void UpdateEpsilons(float zoomFactor);

		// Token: 0x06000895 RID: 2197
		void UpdateTransforms(float zoomFactor);
	}
}
