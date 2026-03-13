using System;

namespace RLD
{
	// Token: 0x020000FB RID: 251
	[Serializable]
	public class CameraFocusSettings : Settings
	{
		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x0002043C File Offset: 0x0001E63C
		// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x0001837A File Offset: 0x0001657A
		public CameraFocusMode FocusMode
		{
			get
			{
				return CameraFocusMode.Instant;
			}
			set
			{
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0001837C File Offset: 0x0001657C
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x00018383 File Offset: 0x00016583
		public float ConstantSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00018385 File Offset: 0x00016585
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x0001838C File Offset: 0x0001658C
		public float SmoothTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x0001838E File Offset: 0x0001658E
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x00018395 File Offset: 0x00016595
		public float FocusDistanceAdd
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x040004C0 RID: 1216
		private CameraFocusMode _focusMode;

		// Token: 0x040004C1 RID: 1217
		private float _constantSpeed;

		// Token: 0x040004C2 RID: 1218
		private float _smoothTime;

		// Token: 0x040004C3 RID: 1219
		private float _focusDistanceAdd;
	}
}
