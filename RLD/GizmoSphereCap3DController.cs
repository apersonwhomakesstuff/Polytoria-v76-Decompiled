using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200001F RID: 31
	public class GizmoSphereCap3DController : GizmoCap3DController
	{
		// Token: 0x06000124 RID: 292 RVA: 0x00016165 File Offset: 0x00014365
		public GizmoSphereCap3DController(GizmoCap3DControllerData controllerData) : base(null)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0001616E File Offset: 0x0001436E
		public override void UpdateHandles()
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00016170 File Offset: 0x00014370
		public override void UpdateTransforms(float zoomFactor)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00016172 File Offset: 0x00014372
		public override void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00016174 File Offset: 0x00014374
		public override void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor)
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00016176 File Offset: 0x00014376
		public override float GetSliderAlignedRealLength(float zoomFactor)
		{
			return 0f;
		}
	}
}
