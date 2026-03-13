using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200007A RID: 122
	public abstract class SceneGizmoCap
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00016A05 File Offset: 0x00014C05
		public int HandleId
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0001EA74 File Offset: 0x0001CC74
		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00016A08 File Offset: 0x00014C08
		public SceneGizmoCap(SceneGizmo sceneGizmo, int capHandleId)
		{
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00016A10 File Offset: 0x00014C10
		public void SetHoverable(bool isHoverable)
		{
		}

		// Token: 0x06000526 RID: 1318
		public abstract void Render(Camera camera);

		// Token: 0x040001AF RID: 431
		protected SceneGizmo _sceneGizmo;

		// Token: 0x040001B0 RID: 432
		protected GizmoCap3D _cap;
	}
}
