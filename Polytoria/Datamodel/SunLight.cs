using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002AF RID: 687
	public class SunLight : DynamicInstance
	{
		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002199 RID: 8601 RVA: 0x0001B8CE File Offset: 0x00019ACE
		// (set) Token: 0x0600219A RID: 8602 RVA: 0x0001B8D5 File Offset: 0x00019AD5
		public float Brightness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x00024EE0 File Offset: 0x000230E0
		// (set) Token: 0x0600219C RID: 8604 RVA: 0x0001B8D7 File Offset: 0x00019AD7
		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x0001B8D9 File Offset: 0x00019AD9
		// (set) Token: 0x0600219E RID: 8606 RVA: 0x0001B8DC File Offset: 0x00019ADC
		public bool Shadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x0001B8DE File Offset: 0x00019ADE
		protected override void Awake()
		{
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x0001B8E0 File Offset: 0x00019AE0
		private void OnBrightnessChanged(float oldValue, float newValue)
		{
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x0001B8E2 File Offset: 0x00019AE2
		private void OnColorChanged(Color oldValue, Color newValue)
		{
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x0001B8E4 File Offset: 0x00019AE4
		private void OnShadowsChanged(bool oldValue, bool newValue)
		{
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x0001B8EE File Offset: 0x00019AEE
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x0001B8F1 File Offset: 0x00019AF1
		// (set) Token: 0x060021A6 RID: 8614 RVA: 0x0001B8F8 File Offset: 0x00019AF8
		public float Networkbrightness
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

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00024EF8 File Offset: 0x000230F8
		// (set) Token: 0x060021A8 RID: 8616 RVA: 0x0001B8FA File Offset: 0x00019AFA
		public Color Networkcolor
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

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x0001B8FC File Offset: 0x00019AFC
		// (set) Token: 0x060021AA RID: 8618 RVA: 0x0001B8FF File Offset: 0x00019AFF
		public bool Networkshadows
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0001B901 File Offset: 0x00019B01
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x0001B903 File Offset: 0x00019B03
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000C09 RID: 3081
		private Light light;

		// Token: 0x04000C0A RID: 3082
		private float brightness;

		// Token: 0x04000C0B RID: 3083
		private Color color;

		// Token: 0x04000C0C RID: 3084
		private bool shadows;

		// Token: 0x04000C0D RID: 3085
		public Action<float, float> _Mirror_SyncVarHookDelegate_brightness;

		// Token: 0x04000C0E RID: 3086
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_color;

		// Token: 0x04000C0F RID: 3087
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_shadows;
	}
}
