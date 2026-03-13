using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000021 RID: 33
	public interface IGizmoCap3DController
	{
		// Token: 0x06000130 RID: 304
		void UpdateHandles();

		// Token: 0x06000131 RID: 305
		void UpdateTransforms(float zoomFactor);

		// Token: 0x06000132 RID: 306
		void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor);

		// Token: 0x06000133 RID: 307
		void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor);

		// Token: 0x06000134 RID: 308
		float GetSliderAlignedRealLength(float zoomFactor);
	}
}
