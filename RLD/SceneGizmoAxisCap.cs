using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000078 RID: 120
	public class SceneGizmoAxisCap : SceneGizmoCap
	{
		// Token: 0x06000514 RID: 1300 RVA: 0x000169D9 File Offset: 0x00014BD9
		public SceneGizmoAxisCap(SceneGizmo sceneGizmo, int id, AxisDescriptor gizmoAxisDesc) : base(null, 0)
		{
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000169E3 File Offset: 0x00014BE3
		public override void Render(Camera camera)
		{
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000169E5 File Offset: 0x00014BE5
		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000169E7 File Offset: 0x00014BE7
		private void UpdateHoverPermission()
		{
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x000169E9 File Offset: 0x00014BE9
		private void UpdateColor()
		{
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000169EB File Offset: 0x00014BEB
		private void UpdateTransform(Camera camera)
		{
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000169ED File Offset: 0x00014BED
		private void OnGizmoHandlePicked(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x040001A6 RID: 422
		private AxisDescriptor _axisDesc;

		// Token: 0x040001A7 RID: 423
		private BoxFace _midAxisBoxFace;

		// Token: 0x040001A8 RID: 424
		private GizmoTransform _zoomFactorTransform;

		// Token: 0x040001A9 RID: 425
		private ColorRef _color;

		// Token: 0x040001AA RID: 426
		private ColorTransition _colorTransition;

		// Token: 0x040001AB RID: 427
		private Texture2D _labelTexture;
	}
}
