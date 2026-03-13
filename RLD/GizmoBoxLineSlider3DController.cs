using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000099 RID: 153
	public class GizmoBoxLineSlider3DController : GizmoLineSlider3DController
	{
		// Token: 0x060006D2 RID: 1746 RVA: 0x00016EEF File Offset: 0x000150EF
		public GizmoBoxLineSlider3DController(GizmoLineSlider3DControllerData controllerData) : base(null)
		{
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00016EF8 File Offset: 0x000150F8
		public override void UpdateHandles()
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00016EFA File Offset: 0x000150FA
		public override void UpdateTransforms(float zoomFactor)
		{
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00016EFC File Offset: 0x000150FC
		public override void UpdateEpsilons(float zoomFactor)
		{
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00016EFE File Offset: 0x000150FE
		public override float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor)
		{
			return 0f;
		}
	}
}
