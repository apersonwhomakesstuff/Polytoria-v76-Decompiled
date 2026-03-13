using System;

namespace RLD
{
	// Token: 0x020000D1 RID: 209
	public interface IGizmoRATriangle3DBorderController
	{
		// Token: 0x060008C5 RID: 2245
		void UpdateHandles();

		// Token: 0x060008C6 RID: 2246
		void UpdateEpsilons(float zoomFactor);

		// Token: 0x060008C7 RID: 2247
		void UpdateTransforms(float zoomFactor);
	}
}
