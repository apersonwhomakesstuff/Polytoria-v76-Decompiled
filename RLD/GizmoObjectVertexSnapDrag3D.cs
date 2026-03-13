using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200003C RID: 60
	public class GizmoObjectVertexSnapDrag3D : GizmoDragSession
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00016353 File Offset: 0x00014553
		public override bool IsActive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0001E51C File Offset: 0x0001C71C
		public override GizmoDragChannel DragChannel
		{
			get
			{
				return GizmoDragChannel.None;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0001E534 File Offset: 0x0001C734
		public Vector3 SnapPivot
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000099 RID: 153
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00016356 File Offset: 0x00014556
		public GizmoObjectVertexSnapSettings Settings
		{
			set
			{
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00016358 File Offset: 0x00014558
		public void SetTargetObjects(IEnumerable<GameObject> targetObjects)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0001635A File Offset: 0x0001455A
		public bool SelectSnapPivotPoint(Gizmo gizmo)
		{
			return false;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0001635D File Offset: 0x0001455D
		protected override bool DoBeginSession()
		{
			return false;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00016360 File Offset: 0x00014560
		protected override bool DoUpdateSession()
		{
			return false;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00016363 File Offset: 0x00014563
		protected override void DoEndSession()
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00016365 File Offset: 0x00014565
		protected override void CalculateDragValues()
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00016367 File Offset: 0x00014567
		protected bool GetWorldPointClosestToInputDevice(Camera focusCamera, IEnumerable<GameObject> gameObjects, out Vector3 point)
		{
			point = default(Vector3);
			return false;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00016371 File Offset: 0x00014571
		protected bool CanUseObjectAsSnapDestination(GameObject gameObject)
		{
			return false;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00016374 File Offset: 0x00014574
		private void GatherDestinationObjects()
		{
		}

		// Token: 0x040000F4 RID: 244
		private IEnumerable<GameObject> _targetObjects;

		// Token: 0x040000F5 RID: 245
		private Vector3 _snapPivot;

		// Token: 0x040000F6 RID: 246
		private bool _isActive;

		// Token: 0x040000F7 RID: 247
		private List<GameObject> _destinationObjects;

		// Token: 0x040000F8 RID: 248
		private GizmoObjectVertexSnapSettings _settings;

		// Token: 0x040000F9 RID: 249
		private List<GameObject> _visibleObjectBuffer;

		// Token: 0x02000354 RID: 852
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06002A2C RID: 10796 RVA: 0x0001D128 File Offset: 0x0001B328
			internal bool <GatherDestinationObjects>b__0(GameObject a)
			{
				return false;
			}

			// Token: 0x04000EB5 RID: 3765
			public List<GameObject> targetObjects;

			// Token: 0x04000EB6 RID: 3766
			public Camera focusCamera;

			// Token: 0x04000EB7 RID: 3767
			public ObjectBounds.QueryConfig boundsQConfig;

			// Token: 0x04000EB8 RID: 3768
			public Vector2 inputDevicePos;
		}

		// Token: 0x02000355 RID: 853
		private sealed class <>c__DisplayClass22_1
		{
			// Token: 0x06002A2E RID: 10798 RVA: 0x0001D133 File Offset: 0x0001B333
			internal bool <GatherDestinationObjects>b__1(GameObject b)
			{
				return false;
			}

			// Token: 0x04000EB9 RID: 3769
			public GameObject a;
		}
	}
}
