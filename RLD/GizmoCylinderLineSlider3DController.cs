using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200009A RID: 154
	public class GizmoCylinderLineSlider3DController : GizmoLineSlider3DController
	{
		// Token: 0x060006D7 RID: 1751 RVA: 0x00016F05 File Offset: 0x00015105
		public GizmoCylinderLineSlider3DController(GizmoLineSlider3DControllerData controllerData) : base(null)
		{
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00016F0E File Offset: 0x0001510E
		public override void UpdateHandles()
		{
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00016F10 File Offset: 0x00015110
		public override void UpdateTransforms(float zoomFactor)
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00016F12 File Offset: 0x00015112
		public override void UpdateEpsilons(float zoomFactor)
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00016F14 File Offset: 0x00015114
		public override float GetRealSizeAlongDirection(Vector3 direction, float zoomFactor)
		{
			return 0f;
		}
	}
}
