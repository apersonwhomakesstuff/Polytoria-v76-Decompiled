using System;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D2 RID: 722
	public class CameraProxy : DynamicInstanceProxy
	{
		// Token: 0x06002453 RID: 9299 RVA: 0x0001BFD3 File Offset: 0x0001A1D3
		public CameraProxy(Camera target) : base(null)
		{
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06002454 RID: 9300 RVA: 0x00025510 File Offset: 0x00023710
		// (set) Token: 0x06002455 RID: 9301 RVA: 0x0001BFDC File Offset: 0x0001A1DC
		public CameraMode Mode
		{
			get
			{
				return CameraMode.FollowPlayer;
			}
			set
			{
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06002456 RID: 9302 RVA: 0x0001BFDE File Offset: 0x0001A1DE
		// (set) Token: 0x06002457 RID: 9303 RVA: 0x0001BFE5 File Offset: 0x0001A1E5
		public float FOV
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x0001BFE7 File Offset: 0x0001A1E7
		// (set) Token: 0x06002459 RID: 9305 RVA: 0x0001BFEA File Offset: 0x0001A1EA
		public bool Orthographic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x0001BFEC File Offset: 0x0001A1EC
		// (set) Token: 0x0600245B RID: 9307 RVA: 0x0001BFF3 File Offset: 0x0001A1F3
		public float OrthographicSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x0001BFF5 File Offset: 0x0001A1F5
		// (set) Token: 0x0600245D RID: 9309 RVA: 0x0001BFFC File Offset: 0x0001A1FC
		public float Distance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x0001BFFE File Offset: 0x0001A1FE
		// (set) Token: 0x0600245F RID: 9311 RVA: 0x0001C005 File Offset: 0x0001A205
		public float MinDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x0001C007 File Offset: 0x0001A207
		// (set) Token: 0x06002461 RID: 9313 RVA: 0x0001C00E File Offset: 0x0001A20E
		public float MaxDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06002462 RID: 9314 RVA: 0x0001C010 File Offset: 0x0001A210
		// (set) Token: 0x06002463 RID: 9315 RVA: 0x0001C017 File Offset: 0x0001A217
		public float HorizontalSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x0001C019 File Offset: 0x0001A219
		// (set) Token: 0x06002465 RID: 9317 RVA: 0x0001C020 File Offset: 0x0001A220
		public float VerticalSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002466 RID: 9318 RVA: 0x0001C022 File Offset: 0x0001A222
		// (set) Token: 0x06002467 RID: 9319 RVA: 0x0001C029 File Offset: 0x0001A229
		public float ScrollSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06002468 RID: 9320 RVA: 0x0001C02B File Offset: 0x0001A22B
		// (set) Token: 0x06002469 RID: 9321 RVA: 0x0001C02E File Offset: 0x0001A22E
		public bool ClipThroughWalls
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x0001C030 File Offset: 0x0001A230
		// (set) Token: 0x0600246B RID: 9323 RVA: 0x0001C037 File Offset: 0x0001A237
		public float FlySpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x0600246C RID: 9324 RVA: 0x0001C039 File Offset: 0x0001A239
		// (set) Token: 0x0600246D RID: 9325 RVA: 0x0001C040 File Offset: 0x0001A240
		public float FastFlySpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x0001C042 File Offset: 0x0001A242
		// (set) Token: 0x0600246F RID: 9327 RVA: 0x0001C049 File Offset: 0x0001A249
		public float FreeLookSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x0001C04B File Offset: 0x0001A24B
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x0001C052 File Offset: 0x0001A252
		public float LerpSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x0001C054 File Offset: 0x0001A254
		// (set) Token: 0x06002473 RID: 9331 RVA: 0x0001C057 File Offset: 0x0001A257
		public bool FollowLerp
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x0001C059 File Offset: 0x0001A259
		// (set) Token: 0x06002475 RID: 9333 RVA: 0x0001C060 File Offset: 0x0001A260
		public float SensitivityMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x00025528 File Offset: 0x00023728
		// (set) Token: 0x06002477 RID: 9335 RVA: 0x0001C062 File Offset: 0x0001A262
		public Vector3 PositionOffset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002478 RID: 9336 RVA: 0x00025540 File Offset: 0x00023740
		// (set) Token: 0x06002479 RID: 9337 RVA: 0x0001C064 File Offset: 0x0001A264
		public Vector3 RotationOffset
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x0600247A RID: 9338 RVA: 0x0001C066 File Offset: 0x0001A266
		public bool IsFirstPerson
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x0001C069 File Offset: 0x0001A269
		// (set) Token: 0x0600247C RID: 9340 RVA: 0x0001C06C File Offset: 0x0001A26C
		public DynamicInstance FollowTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x04000CFE RID: 3326
		private readonly Camera camera;
	}
}
