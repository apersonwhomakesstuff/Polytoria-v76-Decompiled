using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000019 RID: 25
	public abstract class GizmoCap3DController : IGizmoCap3DController
	{
		// Token: 0x060000DF RID: 223 RVA: 0x0001606A File Offset: 0x0001426A
		public GizmoCap3DController(GizmoCap3DControllerData controllerData)
		{
		}

		// Token: 0x060000E0 RID: 224
		public abstract void UpdateHandles();

		// Token: 0x060000E1 RID: 225
		public abstract void UpdateTransforms(float zoomFactor);

		// Token: 0x060000E2 RID: 226
		public abstract void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor);

		// Token: 0x060000E3 RID: 227
		public abstract void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor);

		// Token: 0x060000E4 RID: 228
		public abstract float GetSliderAlignedRealLength(float zoomFactor);

		// Token: 0x04000051 RID: 81
		protected GizmoCap3DControllerData _data;
	}
}
