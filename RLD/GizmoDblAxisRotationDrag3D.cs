using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000038 RID: 56
	public class GizmoDblAxisRotationDrag3D : GizmoScreenDrag
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0001E444 File Offset: 0x0001C644
		public override GizmoDragChannel DragChannel
		{
			get
			{
				return GizmoDragChannel.None;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000162D6 File Offset: 0x000144D6
		public float RelativeRotation0
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000162DD File Offset: 0x000144DD
		public float RelativeRotation1
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001ED RID: 493 RVA: 0x000162E4 File Offset: 0x000144E4
		public float TotalRotation0
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000162EB File Offset: 0x000144EB
		public float TotalRotation1
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000162F2 File Offset: 0x000144F2
		public void SetWorkData(GizmoDblAxisRotationDrag3D.WorkData workData)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000162F4 File Offset: 0x000144F4
		protected override void CalculateDragValues()
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000162F6 File Offset: 0x000144F6
		protected override void OnSessionEnd()
		{
		}

		// Token: 0x040000D6 RID: 214
		private GizmoDblAxisRotationDrag3D.WorkData _workData;

		// Token: 0x040000D7 RID: 215
		private bool _adjustRotationForAbsSnap;

		// Token: 0x040000D8 RID: 216
		private float _accumSnapDrag0;

		// Token: 0x040000D9 RID: 217
		private float _accumSnapDrag1;

		// Token: 0x040000DA RID: 218
		private float _relativeRotation0;

		// Token: 0x040000DB RID: 219
		private float _relativeRotation1;

		// Token: 0x040000DC RID: 220
		private float _totalRotation0;

		// Token: 0x040000DD RID: 221
		private float _totalRotation1;

		// Token: 0x02000352 RID: 850
		public struct WorkData
		{
			// Token: 0x04000EA8 RID: 3752
			public Vector2 ScreenAxis0;

			// Token: 0x04000EA9 RID: 3753
			public Vector2 ScreenAxis1;

			// Token: 0x04000EAA RID: 3754
			public Vector3 Axis0;

			// Token: 0x04000EAB RID: 3755
			public Vector3 Axis1;

			// Token: 0x04000EAC RID: 3756
			public GizmoSnapMode SnapMode;

			// Token: 0x04000EAD RID: 3757
			public float SnapStep0;

			// Token: 0x04000EAE RID: 3758
			public float SnapStep1;
		}
	}
}
