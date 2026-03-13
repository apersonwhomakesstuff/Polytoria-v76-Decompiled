using System;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002FA RID: 762
	public class SunLightProxy : DynamicInstanceProxy
	{
		// Token: 0x06002693 RID: 9875 RVA: 0x0001C6A2 File Offset: 0x0001A8A2
		public SunLightProxy(SunLight target) : base(null)
		{
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x0001C6AB File Offset: 0x0001A8AB
		// (set) Token: 0x06002695 RID: 9877 RVA: 0x0001C6B2 File Offset: 0x0001A8B2
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

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06002696 RID: 9878 RVA: 0x00025D68 File Offset: 0x00023F68
		// (set) Token: 0x06002697 RID: 9879 RVA: 0x0001C6B4 File Offset: 0x0001A8B4
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

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06002698 RID: 9880 RVA: 0x0001C6B6 File Offset: 0x0001A8B6
		// (set) Token: 0x06002699 RID: 9881 RVA: 0x0001C6B9 File Offset: 0x0001A8B9
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

		// Token: 0x04000D26 RID: 3366
		private readonly SunLight sunLight;
	}
}
