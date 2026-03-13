using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200010F RID: 271
	[Serializable]
	public class CameraZoomSettings : Settings
	{
		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x000206AC File Offset: 0x0001E8AC
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x0001853D File Offset: 0x0001673D
		public CameraZoomMode ZoomMode
		{
			get
			{
				return CameraZoomMode.Standard;
			}
			set
			{
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x0001853F File Offset: 0x0001673F
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x00018546 File Offset: 0x00016746
		public float OrthoStandardZoomSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00018548 File Offset: 0x00016748
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x0001854F File Offset: 0x0001674F
		public float PerspStandardZoomSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00018551 File Offset: 0x00016751
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x00018558 File Offset: 0x00016758
		public float OrthoSmoothZoomSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x0001855A File Offset: 0x0001675A
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x00018561 File Offset: 0x00016761
		public float PerspSmoothZoomSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00018563 File Offset: 0x00016763
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x0001856A File Offset: 0x0001676A
		public float OrthoZoomSmoothValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x0001856C File Offset: 0x0001676C
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x00018573 File Offset: 0x00016773
		public float PerspZoomSmoothValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x00018575 File Offset: 0x00016775
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x00018578 File Offset: 0x00016778
		public bool InvertZoomAxis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x0001857A File Offset: 0x0001677A
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x0001857D File Offset: 0x0001677D
		public bool IsZoomEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0001857F File Offset: 0x0001677F
		public float GetZoomSmoothValue(Camera camera)
		{
			return 0f;
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00018586 File Offset: 0x00016786
		public float GetZoomSensitivity(Camera camera)
		{
			return 0f;
		}

		// Token: 0x04000515 RID: 1301
		private CameraZoomMode _zoomMode;

		// Token: 0x04000516 RID: 1302
		private float _orthoStandardZoomSensitivity;

		// Token: 0x04000517 RID: 1303
		private float _perspStandardZoomSensitivity;

		// Token: 0x04000518 RID: 1304
		private float _orthoSmoothZoomSensitivity;

		// Token: 0x04000519 RID: 1305
		private float _perspSmoothZoomSensitivity;

		// Token: 0x0400051A RID: 1306
		private float _orthoZoomSmoothValue;

		// Token: 0x0400051B RID: 1307
		private float _perspZoomSmoothValue;

		// Token: 0x0400051C RID: 1308
		private bool _invertZoomAxis;

		// Token: 0x0400051D RID: 1309
		private bool _isZoomEnabled;
	}
}
