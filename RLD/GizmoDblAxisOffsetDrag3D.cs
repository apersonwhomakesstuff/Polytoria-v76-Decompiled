using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000037 RID: 55
	public class GizmoDblAxisOffsetDrag3D : GizmoPlaneDrag3D
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0001E414 File Offset: 0x0001C614
		public override GizmoDragChannel DragChannel
		{
			get
			{
				return GizmoDragChannel.None;
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000162C8 File Offset: 0x000144C8
		public void SetWorkData(GizmoDblAxisOffsetDrag3D.WorkData workData)
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0001E42C File Offset: 0x0001C62C
		protected override Plane CalculateDragPlane()
		{
			return default(Plane);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000162CA File Offset: 0x000144CA
		protected override void CalculateDragValues()
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000162CC File Offset: 0x000144CC
		protected override void OnSessionEnd()
		{
		}

		// Token: 0x040000D3 RID: 211
		private float _accumSnapDrag0;

		// Token: 0x040000D4 RID: 212
		private float _accumSnapDrag1;

		// Token: 0x040000D5 RID: 213
		private GizmoDblAxisOffsetDrag3D.WorkData _workData;

		// Token: 0x02000351 RID: 849
		public struct WorkData
		{
			// Token: 0x04000EA3 RID: 3747
			public Vector3 DragOrigin;

			// Token: 0x04000EA4 RID: 3748
			public Vector3 Axis0;

			// Token: 0x04000EA5 RID: 3749
			public Vector3 Axis1;

			// Token: 0x04000EA6 RID: 3750
			public float SnapStep0;

			// Token: 0x04000EA7 RID: 3751
			public float SnapStep1;
		}
	}
}
