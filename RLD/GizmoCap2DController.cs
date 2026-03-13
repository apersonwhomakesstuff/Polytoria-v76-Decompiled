using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200000F RID: 15
	public abstract class GizmoCap2DController : IGizmoCap2DController
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00015F05 File Offset: 0x00014105
		public GizmoCap2DController(GizmoCap2DControllerData controllerData)
		{
		}

		// Token: 0x06000073 RID: 115
		public abstract void UpdateHandles();

		// Token: 0x06000074 RID: 116
		public abstract void UpdateTransforms();

		// Token: 0x06000075 RID: 117
		public abstract void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt);

		// Token: 0x06000076 RID: 118
		public abstract void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt);

		// Token: 0x06000077 RID: 119
		public abstract float GetSliderAlignedRealLength();

		// Token: 0x04000025 RID: 37
		protected GizmoCap2DControllerData _data;
	}
}
