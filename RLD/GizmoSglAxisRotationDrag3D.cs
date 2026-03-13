using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000041 RID: 65
	public class GizmoSglAxisRotationDrag3D : GizmoScreenDrag
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0001E594 File Offset: 0x0001C794
		public override GizmoDragChannel DragChannel
		{
			get
			{
				return GizmoDragChannel.None;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600024C RID: 588 RVA: 0x000163F2 File Offset: 0x000145F2
		public float RelativeRotation
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600024D RID: 589 RVA: 0x000163F9 File Offset: 0x000145F9
		public float TotalRotation
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0001E5AC File Offset: 0x0001C7AC
		public Plane RotationPlane
		{
			get
			{
				return default(Plane);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00016400 File Offset: 0x00014600
		public void SetWorkData(GizmoSglAxisRotationDrag3D.WorkData workData)
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00016402 File Offset: 0x00014602
		protected override void CalculateDragValues()
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00016404 File Offset: 0x00014604
		protected override void OnSessionBegin()
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00016406 File Offset: 0x00014606
		protected override void OnSessionEnd()
		{
		}

		// Token: 0x04000105 RID: 261
		private float _accumSnapDrag;

		// Token: 0x04000106 RID: 262
		private Plane _rotationPlane;

		// Token: 0x04000107 RID: 263
		private Vector3 _screenDragCircleTangent;

		// Token: 0x04000108 RID: 264
		private GizmoSglAxisRotationDrag3D.WorkData _workData;

		// Token: 0x04000109 RID: 265
		private bool _adjustRotationForAbsSnap;

		// Token: 0x0400010A RID: 266
		private float _relativeRotation;

		// Token: 0x0400010B RID: 267
		private float _totalRotation;

		// Token: 0x02000357 RID: 855
		public struct WorkData
		{
			// Token: 0x04000EBD RID: 3773
			public Vector3 RotationPlanePos;

			// Token: 0x04000EBE RID: 3774
			public Vector3 Axis;

			// Token: 0x04000EBF RID: 3775
			public GizmoSnapMode SnapMode;

			// Token: 0x04000EC0 RID: 3776
			public float SnapStep;
		}
	}
}
