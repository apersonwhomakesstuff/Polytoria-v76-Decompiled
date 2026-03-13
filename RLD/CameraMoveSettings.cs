using System;

namespace RLD
{
	// Token: 0x020000FF RID: 255
	[Serializable]
	public class CameraMoveSettings : Settings
	{
		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00018400 File Offset: 0x00016600
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x00018407 File Offset: 0x00016607
		public float MoveSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00018409 File Offset: 0x00016609
		// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x00018410 File Offset: 0x00016610
		public float AlternateMoveSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x00018412 File Offset: 0x00016612
		// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x00018419 File Offset: 0x00016619
		public float AccelerationRate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x040004D8 RID: 1240
		private static readonly float _minMoveSpeed;

		// Token: 0x040004D9 RID: 1241
		private float _moveSpeed;

		// Token: 0x040004DA RID: 1242
		private float _alternateMoveSpeed;

		// Token: 0x040004DB RID: 1243
		private float _accelerationRate;
	}
}
