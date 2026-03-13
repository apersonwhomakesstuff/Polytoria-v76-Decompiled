using System;

namespace RLD
{
	// Token: 0x02000101 RID: 257
	[Serializable]
	public class CameraOrbitSettings : Settings
	{
		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0002046C File Offset: 0x0001E66C
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x00018425 File Offset: 0x00016625
		public CameraOrbitMode OrbitMode
		{
			get
			{
				return CameraOrbitMode.Standard;
			}
			set
			{
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x00018427 File Offset: 0x00016627
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x0001842E File Offset: 0x0001662E
		public float StandardOrbitSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00018430 File Offset: 0x00016630
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x00018437 File Offset: 0x00016637
		public float SmoothOrbitSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00018439 File Offset: 0x00016639
		public float OrbitSensitivity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x00018440 File Offset: 0x00016640
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x00018447 File Offset: 0x00016647
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

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00018449 File Offset: 0x00016649
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x0001844C File Offset: 0x0001664C
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

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x0001844E File Offset: 0x0001664E
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x00018451 File Offset: 0x00016651
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

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00018453 File Offset: 0x00016653
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x00018456 File Offset: 0x00016656
		public bool IsOrbitEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x040004DF RID: 1247
		private CameraOrbitMode _orbitMode;

		// Token: 0x040004E0 RID: 1248
		private float _standardOrbitSensitivity;

		// Token: 0x040004E1 RID: 1249
		private float _smoothOrbitSensitivity;

		// Token: 0x040004E2 RID: 1250
		private float _smoothValue;

		// Token: 0x040004E3 RID: 1251
		private bool _invertX;

		// Token: 0x040004E4 RID: 1252
		private bool _invertY;

		// Token: 0x040004E5 RID: 1253
		private bool _isOrbitEnabled;
	}
}
