using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000098 RID: 152
	public interface IGizmoPlaneSlider2DController
	{
		// Token: 0x060006CE RID: 1742
		void UpdateHandles();

		// Token: 0x060006CF RID: 1743
		void UpdateTransforms();

		// Token: 0x060006D0 RID: 1744
		void UpdateEpsilons();

		// Token: 0x060006D1 RID: 1745
		Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt);
	}
}
