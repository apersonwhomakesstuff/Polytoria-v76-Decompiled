using System;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F0 RID: 752
	public class ProceduralSkyProxy : SkyBaseProxy
	{
		// Token: 0x06002649 RID: 9801 RVA: 0x0001C588 File Offset: 0x0001A788
		public ProceduralSkyProxy(ProceduralSky target) : base(null)
		{
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x0001C591 File Offset: 0x0001A791
		// (set) Token: 0x0600264B RID: 9803 RVA: 0x0001C598 File Offset: 0x0001A798
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

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x0001C59A File Offset: 0x0001A79A
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x0001C5A1 File Offset: 0x0001A7A1
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

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x0001C5A3 File Offset: 0x0001A7A3
		// (set) Token: 0x0600264F RID: 9807 RVA: 0x0001C5AA File Offset: 0x0001A7AA
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

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x00025CF0 File Offset: 0x00023EF0
		// (set) Token: 0x06002651 RID: 9809 RVA: 0x0001C5AC File Offset: 0x0001A7AC
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

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x00025D08 File Offset: 0x00023F08
		// (set) Token: 0x06002653 RID: 9811 RVA: 0x0001C5AE File Offset: 0x0001A7AE
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

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06002654 RID: 9812 RVA: 0x0001C5B0 File Offset: 0x0001A7B0
		// (set) Token: 0x06002655 RID: 9813 RVA: 0x0001C5B7 File Offset: 0x0001A7B7
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

		// Token: 0x04000D1C RID: 3356
		private readonly ProceduralSky proceduralSky;
	}
}
