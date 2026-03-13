using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200007C RID: 124
	[Serializable]
	public class SceneGizmo : GizmoBehaviour, ISceneGizmo
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00016A22 File Offset: 0x00014C22
		public RTSceneGizmoCamera SceneGizmoCamera
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00016A25 File Offset: 0x00014C25
		public Gizmo OwnerGizmo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00016A28 File Offset: 0x00014C28
		public Camera SceneCamera
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00016A2B File Offset: 0x00014C2B
		public SceneGizmoLookAndFeel LookAndFeel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00016A2E File Offset: 0x00014C2E
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00016A31 File Offset: 0x00014C31
		public SceneGizmoLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00016A33 File Offset: 0x00014C33
		public override void OnAttached()
		{
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00016A35 File Offset: 0x00014C35
		public override void OnGUI()
		{
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00016A37 File Offset: 0x00014C37
		public override void OnGizmoRender(Camera camera)
		{
		}

		// Token: 0x040001B1 RID: 433
		private SceneGizmoCamPrjSwitchLabel _camPrjSwitchLabel;

		// Token: 0x040001B2 RID: 434
		private SceneGizmoMidCap _midAxisHandle;

		// Token: 0x040001B3 RID: 435
		private SceneGizmoAxisCap[] _axesHandles;

		// Token: 0x040001B4 RID: 436
		private List<SceneGizmoCap> _renderSortedHandles;

		// Token: 0x040001B5 RID: 437
		private RTSceneGizmoCamera _sceneGizmoCamera;

		// Token: 0x040001B6 RID: 438
		private SceneGizmoLookAndFeel _lookAndFeel;

		// Token: 0x040001B7 RID: 439
		private SceneGizmoLookAndFeel _sharedLookAndFeel;

		// Token: 0x02000364 RID: 868
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06002A41 RID: 10817 RVA: 0x0001D198 File Offset: 0x0001B398
			internal int <OnGizmoRender>b__0(SceneGizmoCap h0, SceneGizmoCap h1)
			{
				return 0;
			}

			// Token: 0x04000EDC RID: 3804
			public Vector3 cameraPos;
		}
	}
}
