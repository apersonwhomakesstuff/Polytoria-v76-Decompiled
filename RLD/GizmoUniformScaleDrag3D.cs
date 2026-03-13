using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000043 RID: 67
	public class GizmoUniformScaleDrag3D : GizmoPlaneDrag3D
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0001E5F4 File Offset: 0x0001C7F4
		public override GizmoDragChannel DragChannel
		{
			get
			{
				return GizmoDragChannel.None;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0001642F File Offset: 0x0001462F
		public float TotalScale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00016436 File Offset: 0x00014636
		public float RelativeScale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0001643D File Offset: 0x0001463D
		public void SetWorkData(GizmoUniformScaleDrag3D.WorkData workData)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0001E60C File Offset: 0x0001C80C
		protected override Plane CalculateDragPlane()
		{
			return default(Plane);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0001643F File Offset: 0x0001463F
		protected override void CalculateDragValues()
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00016441 File Offset: 0x00014641
		protected override void OnSessionEnd()
		{
		}

		// Token: 0x04000111 RID: 273
		private GizmoUniformScaleDrag3D.WorkData _workData;

		// Token: 0x04000112 RID: 274
		private Vector3 _planeAxis0;

		// Token: 0x04000113 RID: 275
		private Vector3 _planeAxis1;

		// Token: 0x04000114 RID: 276
		private float _accumSnapDrag;

		// Token: 0x04000115 RID: 277
		private float _scale;

		// Token: 0x04000116 RID: 278
		private float _relativeScale;

		// Token: 0x04000117 RID: 279
		private float _totalScale;

		// Token: 0x04000118 RID: 280
		private Vector3 _scaleDragAxis;

		// Token: 0x02000359 RID: 857
		public struct WorkData
		{
			// Token: 0x04000EC6 RID: 3782
			public Vector3 CameraRight;

			// Token: 0x04000EC7 RID: 3783
			public Vector3 CameraUp;

			// Token: 0x04000EC8 RID: 3784
			public Vector3 DragOrigin;

			// Token: 0x04000EC9 RID: 3785
			public float SnapStep;
		}
	}
}
