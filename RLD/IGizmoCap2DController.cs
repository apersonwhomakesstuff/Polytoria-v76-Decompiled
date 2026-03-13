using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000015 RID: 21
	public interface IGizmoCap2DController
	{
		// Token: 0x0600009E RID: 158
		void UpdateHandles();

		// Token: 0x0600009F RID: 159
		void UpdateTransforms();

		// Token: 0x060000A0 RID: 160
		void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt);

		// Token: 0x060000A1 RID: 161
		void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt);

		// Token: 0x060000A2 RID: 162
		float GetSliderAlignedRealLength();
	}
}
