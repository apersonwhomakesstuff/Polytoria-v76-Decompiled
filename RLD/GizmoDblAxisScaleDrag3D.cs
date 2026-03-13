using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000039 RID: 57
	public class GizmoDblAxisScaleDrag3D : GizmoPlaneDrag3D
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0001E45C File Offset: 0x0001C65C
		public override GizmoDragChannel DragChannel
		{
			get
			{
				return GizmoDragChannel.None;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00016300 File Offset: 0x00014500
		public int AxisIndex0
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00016303 File Offset: 0x00014503
		public int AxisIndex1
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00016306 File Offset: 0x00014506
		public float RelativeScale0
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0001630D File Offset: 0x0001450D
		public float RelativeScale1
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00016314 File Offset: 0x00014514
		public float TotalScale0
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0001631B File Offset: 0x0001451B
		public float TotalScale1
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00016322 File Offset: 0x00014522
		public void SetWorkData(GizmoDblAxisScaleDrag3D.WorkData workData)
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0001E474 File Offset: 0x0001C674
		protected override Plane CalculateDragPlane()
		{
			return default(Plane);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00016324 File Offset: 0x00014524
		protected override void CalculateDragValues()
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00016326 File Offset: 0x00014526
		protected override void OnSessionEnd()
		{
		}

		// Token: 0x040000DE RID: 222
		private GizmoDblAxisScaleDrag3D.WorkData _workData;

		// Token: 0x040000DF RID: 223
		private float _accumSnapDrag0;

		// Token: 0x040000E0 RID: 224
		private float _accumSnapDrag1;

		// Token: 0x040000E1 RID: 225
		private float _scale0;

		// Token: 0x040000E2 RID: 226
		private float _scale1;

		// Token: 0x040000E3 RID: 227
		private float _relativeScale0;

		// Token: 0x040000E4 RID: 228
		private float _relativeScale1;

		// Token: 0x040000E5 RID: 229
		private float _totalScale0;

		// Token: 0x040000E6 RID: 230
		private float _totalScale1;

		// Token: 0x040000E7 RID: 231
		private Vector3 _scaleDragAxis;

		// Token: 0x02000353 RID: 851
		public struct WorkData
		{
			// Token: 0x04000EAF RID: 3759
			public int AxisIndex0;

			// Token: 0x04000EB0 RID: 3760
			public int AxisIndex1;

			// Token: 0x04000EB1 RID: 3761
			public Vector3 DragOrigin;

			// Token: 0x04000EB2 RID: 3762
			public Vector3 Axis0;

			// Token: 0x04000EB3 RID: 3763
			public Vector3 Axis1;

			// Token: 0x04000EB4 RID: 3764
			public float SnapStep;
		}
	}
}
