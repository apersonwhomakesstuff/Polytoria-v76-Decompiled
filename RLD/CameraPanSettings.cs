using System;

namespace RLD
{
	// Token: 0x02000103 RID: 259
	[Serializable]
	public class CameraPanSettings : Settings
	{
		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00020484 File Offset: 0x0001E684
		// (set) Token: 0x06000DFD RID: 3581 RVA: 0x00018460 File Offset: 0x00016660
		public CameraPanMode PanMode
		{
			get
			{
				return CameraPanMode.Standard;
			}
			set
			{
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x00018462 File Offset: 0x00016662
		// (set) Token: 0x06000DFF RID: 3583 RVA: 0x00018469 File Offset: 0x00016669
		public float StandardPanSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x0001846B File Offset: 0x0001666B
		// (set) Token: 0x06000E01 RID: 3585 RVA: 0x00018472 File Offset: 0x00016672
		public float SmoothPanSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x00018474 File Offset: 0x00016674
		public float Sensitivity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x0001847B File Offset: 0x0001667B
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x00018482 File Offset: 0x00016682
		public float SmoothValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x00018484 File Offset: 0x00016684
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x00018487 File Offset: 0x00016687
		public bool InvertX
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00018489 File Offset: 0x00016689
		// (set) Token: 0x06000E08 RID: 3592 RVA: 0x0001848C File Offset: 0x0001668C
		public bool InvertY
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x0001848E File Offset: 0x0001668E
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x00018491 File Offset: 0x00016691
		public bool IsPanningEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x040004E9 RID: 1257
		private CameraPanMode _panMode;

		// Token: 0x040004EA RID: 1258
		private float _standardPanSensitivity;

		// Token: 0x040004EB RID: 1259
		private float _smoothPanSensitivity;

		// Token: 0x040004EC RID: 1260
		private float _smoothValue;

		// Token: 0x040004ED RID: 1261
		private bool _invertX;

		// Token: 0x040004EE RID: 1262
		private bool _invertY;

		// Token: 0x040004EF RID: 1263
		private bool _isPanningEnabled;
	}
}
