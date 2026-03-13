using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x0200027E RID: 638
	public class GradientSky : SkyBase
	{
		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x000245B0 File Offset: 0x000227B0
		// (set) Token: 0x06001C2E RID: 7214 RVA: 0x0001AA65 File Offset: 0x00018C65
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

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x0001AA67 File Offset: 0x00018C67
		// (set) Token: 0x06001C30 RID: 7216 RVA: 0x0001AA6E File Offset: 0x00018C6E
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

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x0001AA70 File Offset: 0x00018C70
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x0001AA77 File Offset: 0x00018C77
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

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x000245C8 File Offset: 0x000227C8
		// (set) Token: 0x06001C34 RID: 7220 RVA: 0x0001AA79 File Offset: 0x00018C79
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

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x0001AA7B File Offset: 0x00018C7B
		// (set) Token: 0x06001C36 RID: 7222 RVA: 0x0001AA82 File Offset: 0x00018C82
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

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x0001AA84 File Offset: 0x00018C84
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x0001AA8B File Offset: 0x00018C8B
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

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x000245E0 File Offset: 0x000227E0
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x0001AA8D File Offset: 0x00018C8D
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

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x0001AA8F File Offset: 0x00018C8F
		// (set) Token: 0x06001C3C RID: 7228 RVA: 0x0001AA96 File Offset: 0x00018C96
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

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x0001AA98 File Offset: 0x00018C98
		// (set) Token: 0x06001C3E RID: 7230 RVA: 0x0001AA9F File Offset: 0x00018C9F
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

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x000245F8 File Offset: 0x000227F8
		// (set) Token: 0x06001C40 RID: 7232 RVA: 0x0001AAA1 File Offset: 0x00018CA1
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

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x00024610 File Offset: 0x00022810
		// (set) Token: 0x06001C42 RID: 7234 RVA: 0x0001AAA3 File Offset: 0x00018CA3
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

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x0001AAA5 File Offset: 0x00018CA5
		// (set) Token: 0x06001C44 RID: 7236 RVA: 0x0001AAAC File Offset: 0x00018CAC
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

		// Token: 0x06001C45 RID: 7237 RVA: 0x0001AAAE File Offset: 0x00018CAE
		protected override void Awake()
		{
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0001AAB0 File Offset: 0x00018CB0
		protected override void Start()
		{
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x0001AAB2 File Offset: 0x00018CB2
		protected override void Apply()
		{
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0001AAB4 File Offset: 0x00018CB4
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0001AAB6 File Offset: 0x00018CB6
		private void OnSunDiscColorChanged(Color oldValue, Color newValue)
		{
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0001AAB8 File Offset: 0x00018CB8
		private void OnSunDiscMultiplierChanged(float oldValue, float newValue)
		{
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x0001AABA File Offset: 0x00018CBA
		private void OnSunDiscExponentChanged(float oldValue, float newValue)
		{
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0001AABC File Offset: 0x00018CBC
		private void OnSunHaloColorChanged(Color oldValue, Color newValue)
		{
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0001AABE File Offset: 0x00018CBE
		private void OnSunHaloExponentChanged(float oldValue, float newValue)
		{
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0001AAC0 File Offset: 0x00018CC0
		private void OnSunHaloContributionChanged(float oldValue, float newValue)
		{
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0001AAC2 File Offset: 0x00018CC2
		private void OnHorizonLineColorChanged(Color oldValue, Color newValue)
		{
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0001AAC4 File Offset: 0x00018CC4
		private void OnHorizonLineExponentChanged(float oldValue, float newValue)
		{
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0001AAC6 File Offset: 0x00018CC6
		private void OnHorizonLineContributionChanged(float oldValue, float newValue)
		{
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0001AAC8 File Offset: 0x00018CC8
		private void OnSkyGradientTopChanged(Color oldValue, Color newValue)
		{
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0001AACA File Offset: 0x00018CCA
		private void OnSkyGradientBottomChanged(Color oldValue, Color newValue)
		{
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0001AACC File Offset: 0x00018CCC
		private void OnSkyGradientExponentChanged(float oldValue, float newValue)
		{
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x0001AAD6 File Offset: 0x00018CD6
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x00024628 File Offset: 0x00022828
		// (set) Token: 0x06001C58 RID: 7256 RVA: 0x0001AAD9 File Offset: 0x00018CD9
		public Color NetworksunDiscColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x0001AADB File Offset: 0x00018CDB
		// (set) Token: 0x06001C5A RID: 7258 RVA: 0x0001AAE2 File Offset: 0x00018CE2
		public float NetworksunDiscMultiplier
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x0001AAE4 File Offset: 0x00018CE4
		// (set) Token: 0x06001C5C RID: 7260 RVA: 0x0001AAEB File Offset: 0x00018CEB
		public float NetworksunDiscExponent
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x00024640 File Offset: 0x00022840
		// (set) Token: 0x06001C5E RID: 7262 RVA: 0x0001AAED File Offset: 0x00018CED
		public Color NetworksunHaloColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x0001AAEF File Offset: 0x00018CEF
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x0001AAF6 File Offset: 0x00018CF6
		public float NetworksunHaloExponent
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x0001AAF8 File Offset: 0x00018CF8
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x0001AAFF File Offset: 0x00018CFF
		public float NetworksunHaloContribution
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x00024658 File Offset: 0x00022858
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x0001AB01 File Offset: 0x00018D01
		public Color NetworkhorizonLineColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x0001AB03 File Offset: 0x00018D03
		// (set) Token: 0x06001C66 RID: 7270 RVA: 0x0001AB0A File Offset: 0x00018D0A
		public float NetworkhorizonLineExponent
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x0001AB0C File Offset: 0x00018D0C
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x0001AB13 File Offset: 0x00018D13
		public float NetworkhorizonLineContribution
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x00024670 File Offset: 0x00022870
		// (set) Token: 0x06001C6A RID: 7274 RVA: 0x0001AB15 File Offset: 0x00018D15
		public Color NetworkskyGradientTop
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x00024688 File Offset: 0x00022888
		// (set) Token: 0x06001C6C RID: 7276 RVA: 0x0001AB17 File Offset: 0x00018D17
		public Color NetworkskyGradientBottom
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x0001AB19 File Offset: 0x00018D19
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x0001AB20 File Offset: 0x00018D20
		public float NetworkskyGradientExponent
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0001AB22 File Offset: 0x00018D22
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0001AB24 File Offset: 0x00018D24
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000A55 RID: 2645
		private Color sunDiscColor;

		// Token: 0x04000A56 RID: 2646
		private float sunDiscMultiplier;

		// Token: 0x04000A57 RID: 2647
		private float sunDiscExponent;

		// Token: 0x04000A58 RID: 2648
		private Color sunHaloColor;

		// Token: 0x04000A59 RID: 2649
		private float sunHaloExponent;

		// Token: 0x04000A5A RID: 2650
		private float sunHaloContribution;

		// Token: 0x04000A5B RID: 2651
		private Color horizonLineColor;

		// Token: 0x04000A5C RID: 2652
		private float horizonLineExponent;

		// Token: 0x04000A5D RID: 2653
		private float horizonLineContribution;

		// Token: 0x04000A5E RID: 2654
		private Color skyGradientTop;

		// Token: 0x04000A5F RID: 2655
		private Color skyGradientBottom;

		// Token: 0x04000A60 RID: 2656
		private float skyGradientExponent;

		// Token: 0x04000A61 RID: 2657
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_sunDiscColor;

		// Token: 0x04000A62 RID: 2658
		public Action<float, float> _Mirror_SyncVarHookDelegate_sunDiscMultiplier;

		// Token: 0x04000A63 RID: 2659
		public Action<float, float> _Mirror_SyncVarHookDelegate_sunDiscExponent;

		// Token: 0x04000A64 RID: 2660
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_sunHaloColor;

		// Token: 0x04000A65 RID: 2661
		public Action<float, float> _Mirror_SyncVarHookDelegate_sunHaloExponent;

		// Token: 0x04000A66 RID: 2662
		public Action<float, float> _Mirror_SyncVarHookDelegate_sunHaloContribution;

		// Token: 0x04000A67 RID: 2663
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_horizonLineColor;

		// Token: 0x04000A68 RID: 2664
		public Action<float, float> _Mirror_SyncVarHookDelegate_horizonLineExponent;

		// Token: 0x04000A69 RID: 2665
		public Action<float, float> _Mirror_SyncVarHookDelegate_horizonLineContribution;

		// Token: 0x04000A6A RID: 2666
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_skyGradientTop;

		// Token: 0x04000A6B RID: 2667
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_skyGradientBottom;

		// Token: 0x04000A6C RID: 2668
		public Action<float, float> _Mirror_SyncVarHookDelegate_skyGradientExponent;
	}
}
