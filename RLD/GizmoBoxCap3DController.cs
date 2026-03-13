using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000016 RID: 22
	public class GizmoBoxCap3DController : GizmoCap3DController
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00015F8F File Offset: 0x0001418F
		public GizmoBoxCap3DController(GizmoCap3DControllerData controllerData) : base(null)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00015F98 File Offset: 0x00014198
		public override void UpdateHandles()
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00015F9A File Offset: 0x0001419A
		public override void UpdateTransforms(float zoomFactor)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00015F9C File Offset: 0x0001419C
		public override void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00015F9E File Offset: 0x0001419E
		public override void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00015FA0 File Offset: 0x000141A0
		public override float GetSliderAlignedRealLength(float zoomFactor)
		{
			return 0f;
		}
	}
}
