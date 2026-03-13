using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002A5 RID: 677
	public class ProceduralSky : SkyBase
	{
		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x0001B636 File Offset: 0x00019836
		// (set) Token: 0x060020AC RID: 8364 RVA: 0x0001B63D File Offset: 0x0001983D
		public float SunSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x0001B63F File Offset: 0x0001983F
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x0001B646 File Offset: 0x00019846
		public float SunSizeConvergence
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x0001B648 File Offset: 0x00019848
		// (set) Token: 0x060020B0 RID: 8368 RVA: 0x0001B64F File Offset: 0x0001984F
		public float AtmosphereThickness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x00024E20 File Offset: 0x00023020
		// (set) Token: 0x060020B2 RID: 8370 RVA: 0x0001B651 File Offset: 0x00019851
		public Color SkyTint
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x00024E38 File Offset: 0x00023038
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x0001B653 File Offset: 0x00019853
		public Color GroundColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x0001B655 File Offset: 0x00019855
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x0001B65C File Offset: 0x0001985C
		public float Exposure
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x0001B65E File Offset: 0x0001985E
		protected override void Awake()
		{
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x0001B660 File Offset: 0x00019860
		protected override void Start()
		{
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x0001B662 File Offset: 0x00019862
		protected override void Apply()
		{
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x0001B664 File Offset: 0x00019864
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x0001B666 File Offset: 0x00019866
		private void OnSunSizeChanged(float oldValue, float newValue)
		{
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x0001B668 File Offset: 0x00019868
		private void OnSunSizeConvergenceChanged(float oldValue, float newValue)
		{
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x0001B66A File Offset: 0x0001986A
		private void OnAtmosphereThicknessChanged(float oldValue, float newValue)
		{
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x0001B66C File Offset: 0x0001986C
		private void OnSkyTintChanged(Color oldValue, Color newValue)
		{
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x0001B66E File Offset: 0x0001986E
		private void OnGroundColorChanged(Color oldValue, Color newValue)
		{
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x0001B670 File Offset: 0x00019870
		private void OnExposureChanged(float oldValue, float newValue)
		{
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x0001B67A File Offset: 0x0001987A
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x0001B67D File Offset: 0x0001987D
		// (set) Token: 0x060020C4 RID: 8388 RVA: 0x0001B684 File Offset: 0x00019884
		public float NetworksunSize
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

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x0001B686 File Offset: 0x00019886
		// (set) Token: 0x060020C6 RID: 8390 RVA: 0x0001B68D File Offset: 0x0001988D
		public float NetworksunSizeConvergence
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

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x0001B68F File Offset: 0x0001988F
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x0001B696 File Offset: 0x00019896
		public float NetworkatmosphereThickness
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

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x00024E50 File Offset: 0x00023050
		// (set) Token: 0x060020CA RID: 8394 RVA: 0x0001B698 File Offset: 0x00019898
		public Color NetworkskyTint
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

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x00024E68 File Offset: 0x00023068
		// (set) Token: 0x060020CC RID: 8396 RVA: 0x0001B69A File Offset: 0x0001989A
		public Color NetworkgroundColor
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

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x0001B69C File Offset: 0x0001989C
		// (set) Token: 0x060020CE RID: 8398 RVA: 0x0001B6A3 File Offset: 0x000198A3
		public float Networkexposure
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

		// Token: 0x060020CF RID: 8399 RVA: 0x0001B6A5 File Offset: 0x000198A5
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x0001B6A7 File Offset: 0x000198A7
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000BDC RID: 3036
		private float sunSize;

		// Token: 0x04000BDD RID: 3037
		private float sunSizeConvergence;

		// Token: 0x04000BDE RID: 3038
		private float atmosphereThickness;

		// Token: 0x04000BDF RID: 3039
		private Color skyTint;

		// Token: 0x04000BE0 RID: 3040
		private Color groundColor;

		// Token: 0x04000BE1 RID: 3041
		private float exposure;

		// Token: 0x04000BE2 RID: 3042
		public Action<float, float> _Mirror_SyncVarHookDelegate_sunSize;

		// Token: 0x04000BE3 RID: 3043
		public Action<float, float> _Mirror_SyncVarHookDelegate_sunSizeConvergence;

		// Token: 0x04000BE4 RID: 3044
		public Action<float, float> _Mirror_SyncVarHookDelegate_atmosphereThickness;

		// Token: 0x04000BE5 RID: 3045
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_skyTint;

		// Token: 0x04000BE6 RID: 3046
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_groundColor;

		// Token: 0x04000BE7 RID: 3047
		public Action<float, float> _Mirror_SyncVarHookDelegate_exposure;
	}
}
