using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000042 RID: 66
	public class GizmoSglAxisScaleDrag3D : GizmoPlaneDrag3D
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0001E5C4 File Offset: 0x0001C7C4
		public override GizmoDragChannel DragChannel
		{
			get
			{
				return GizmoDragChannel.None;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00016410 File Offset: 0x00014610
		public int AxisIndex
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00016413 File Offset: 0x00014613
		public float RelativeScale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0001641A File Offset: 0x0001461A
		public float TotalScale
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00016421 File Offset: 0x00014621
		public void SetWorkData(GizmoSglAxisScaleDrag3D.WorkData workData)
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0001E5DC File Offset: 0x0001C7DC
		protected override Plane CalculateDragPlane()
		{
			return default(Plane);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00016423 File Offset: 0x00014623
		protected override void CalculateDragValues()
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00016425 File Offset: 0x00014625
		protected override void OnSessionEnd()
		{
		}

		// Token: 0x0400010C RID: 268
		private float _accumSnapDrag;

		// Token: 0x0400010D RID: 269
		private GizmoSglAxisScaleDrag3D.WorkData _workData;

		// Token: 0x0400010E RID: 270
		private float _scale;

		// Token: 0x0400010F RID: 271
		private float _relativeScale;

		// Token: 0x04000110 RID: 272
		private float _totalScale;

		// Token: 0x02000358 RID: 856
		public struct WorkData
		{
			// Token: 0x04000EC1 RID: 3777
			public int AxisIndex;

			// Token: 0x04000EC2 RID: 3778
			public Vector3 DragOrigin;

			// Token: 0x04000EC3 RID: 3779
			public Vector3 Axis;

			// Token: 0x04000EC4 RID: 3780
			public float SnapStep;

			// Token: 0x04000EC5 RID: 3781
			public float EntityScale;
		}
	}
}
