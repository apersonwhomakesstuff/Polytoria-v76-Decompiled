using System;

namespace RLD
{
	// Token: 0x020000FE RID: 254
	[Serializable]
	public class CameraLookAroundSettings : Settings
	{
		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00020454 File Offset: 0x0001E654
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x000183C5 File Offset: 0x000165C5
		public CameraLookAroundMode LookAroundMode
		{
			get
			{
				return CameraLookAroundMode.Standard;
			}
			set
			{
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x000183C7 File Offset: 0x000165C7
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x000183CE File Offset: 0x000165CE
		public float StandardLookAroundSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x000183D0 File Offset: 0x000165D0
		// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x000183D7 File Offset: 0x000165D7
		public float SmoothLookAroundSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x000183D9 File Offset: 0x000165D9
		public float Sensitivity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x000183E0 File Offset: 0x000165E0
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x000183E7 File Offset: 0x000165E7
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

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x000183E9 File Offset: 0x000165E9
		// (set) Token: 0x06000DDE RID: 3550 RVA: 0x000183EC File Offset: 0x000165EC
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

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x000183EE File Offset: 0x000165EE
		// (set) Token: 0x06000DE0 RID: 3552 RVA: 0x000183F1 File Offset: 0x000165F1
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

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x000183F3 File Offset: 0x000165F3
		// (set) Token: 0x06000DE2 RID: 3554 RVA: 0x000183F6 File Offset: 0x000165F6
		public bool IsLookAroundEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x040004D1 RID: 1233
		private CameraLookAroundMode _lookAroundMode;

		// Token: 0x040004D2 RID: 1234
		private float _standardLookAroundSensitivity;

		// Token: 0x040004D3 RID: 1235
		private float _smoothLookAroundSensitivity;

		// Token: 0x040004D4 RID: 1236
		private float smoothValue;

		// Token: 0x040004D5 RID: 1237
		private bool _invertX;

		// Token: 0x040004D6 RID: 1238
		private bool _invertY;

		// Token: 0x040004D7 RID: 1239
		private bool _isLookAroundEnabled;
	}
}
