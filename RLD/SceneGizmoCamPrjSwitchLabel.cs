using System;

namespace RLD
{
	// Token: 0x02000079 RID: 121
	public class SceneGizmoCamPrjSwitchLabel
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x000169EF File Offset: 0x00014BEF
		public GizmoHandle Handle
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x000169F2 File Offset: 0x00014BF2
		public int Id
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000169F5 File Offset: 0x00014BF5
		public SceneGizmoCamPrjSwitchLabel(SceneGizmo sceneGizmo)
		{
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000169FD File Offset: 0x00014BFD
		public void OnGUI()
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000169FF File Offset: 0x00014BFF
		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00016A01 File Offset: 0x00014C01
		private void UpdateTransform()
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00016A03 File Offset: 0x00014C03
		private void OnGizmoHandlePicked(Gizmo gizmo, int handleId)
		{
		}

		// Token: 0x040001AC RID: 428
		private SceneGizmo _sceneGizmo;

		// Token: 0x040001AD RID: 429
		private GizmoHandle _handle;

		// Token: 0x040001AE RID: 430
		private QuadShape2D _labelQuad;
	}
}
