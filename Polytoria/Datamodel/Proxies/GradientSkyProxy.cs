using System;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002DA RID: 730
	public class GradientSkyProxy : SkyBaseProxy
	{
		// Token: 0x060024CF RID: 9423 RVA: 0x0001C12D File Offset: 0x0001A32D
		public GradientSkyProxy(GradientSky target) : base(null)
		{
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x060024D0 RID: 9424 RVA: 0x000257E0 File Offset: 0x000239E0
		// (set) Token: 0x060024D1 RID: 9425 RVA: 0x0001C136 File Offset: 0x0001A336
		public Color SunDiscColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x0001C138 File Offset: 0x0001A338
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x0001C13F File Offset: 0x0001A33F
		public float SunDiscMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x0001C141 File Offset: 0x0001A341
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x0001C148 File Offset: 0x0001A348
		public float SunDiscExponent
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x000257F8 File Offset: 0x000239F8
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x0001C14A File Offset: 0x0001A34A
		public Color SunHaloColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x0001C14C File Offset: 0x0001A34C
		// (set) Token: 0x060024D9 RID: 9433 RVA: 0x0001C153 File Offset: 0x0001A353
		public float SunHaloExponent
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x0001C155 File Offset: 0x0001A355
		// (set) Token: 0x060024DB RID: 9435 RVA: 0x0001C15C File Offset: 0x0001A35C
		public float SunHaloContribution
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x00025810 File Offset: 0x00023A10
		// (set) Token: 0x060024DD RID: 9437 RVA: 0x0001C15E File Offset: 0x0001A35E
		public Color HorizonLineColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x0001C160 File Offset: 0x0001A360
		// (set) Token: 0x060024DF RID: 9439 RVA: 0x0001C167 File Offset: 0x0001A367
		public float HorizonLineExponent
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x060024E0 RID: 9440 RVA: 0x0001C169 File Offset: 0x0001A369
		// (set) Token: 0x060024E1 RID: 9441 RVA: 0x0001C170 File Offset: 0x0001A370
		public float HorizonLineContribution
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x00025828 File Offset: 0x00023A28
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x0001C172 File Offset: 0x0001A372
		public Color SkyGradientTop
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x00025840 File Offset: 0x00023A40
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x0001C174 File Offset: 0x0001A374
		public Color SkyGradientBottom
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x0001C176 File Offset: 0x0001A376
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x0001C17D File Offset: 0x0001A37D
		public float SkyGradientExponent
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x04000D06 RID: 3334
		private readonly GradientSky gradientSky;
	}
}
