using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000040 RID: 64
	public class GizmoSglAxisOffsetDrag3D : GizmoPlaneDrag3D
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0001E54C File Offset: 0x0001C74C
		public Vector3 Axis
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0001E564 File Offset: 0x0001C764
		public override GizmoDragChannel DragChannel
		{
			get
			{
				return GizmoDragChannel.None;
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000163E4 File Offset: 0x000145E4
		public void SetWorkData(GizmoSglAxisOffsetDrag3D.WorkData workData)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0001E57C File Offset: 0x0001C77C
		protected override Plane CalculateDragPlane()
		{
			return default(Plane);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000163E6 File Offset: 0x000145E6
		protected override void CalculateDragValues()
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000163E8 File Offset: 0x000145E8
		protected override void OnSessionEnd()
		{
		}

		// Token: 0x04000103 RID: 259
		private float _accumSnapDrag;

		// Token: 0x04000104 RID: 260
		private GizmoSglAxisOffsetDrag3D.WorkData _workData;

		// Token: 0x02000356 RID: 854
		public struct WorkData
		{
			// Token: 0x04000EBA RID: 3770
			public Vector3 DragOrigin;

			// Token: 0x04000EBB RID: 3771
			public Vector3 Axis;

			// Token: 0x04000EBC RID: 3772
			public float SnapStep;
		}
	}
}
