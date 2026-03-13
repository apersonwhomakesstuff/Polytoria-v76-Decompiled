using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200001D RID: 29
	public class GizmoConeCap3DController : GizmoCap3DController
	{
		// Token: 0x06000118 RID: 280 RVA: 0x00016135 File Offset: 0x00014335
		public GizmoConeCap3DController(GizmoCap3DControllerData controllerData) : base(null)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0001613E File Offset: 0x0001433E
		public override void UpdateHandles()
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00016140 File Offset: 0x00014340
		public override void UpdateTransforms(float zoomFactor)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00016142 File Offset: 0x00014342
		public override void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00016144 File Offset: 0x00014344
		public override void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00016146 File Offset: 0x00014346
		public override float GetSliderAlignedRealLength(float zoomFactor)
		{
			return 0f;
		}
	}
}
