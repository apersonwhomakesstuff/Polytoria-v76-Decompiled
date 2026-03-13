using System;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E1 RID: 737
	public class LightingProxy : InstanceProxy
	{
		// Token: 0x0600251D RID: 9501 RVA: 0x0001C230 File Offset: 0x0001A430
		public LightingProxy(Lighting target) : base(null)
		{
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x0001C239 File Offset: 0x0001A439
		// (set) Token: 0x0600251F RID: 9503 RVA: 0x0001C240 File Offset: 0x0001A440
		public float SunBrightness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x00025870 File Offset: 0x00023A70
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x0001C242 File Offset: 0x0001A442
		public Color SunColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x00025888 File Offset: 0x00023A88
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x0001C244 File Offset: 0x0001A444
		public Color AmbientColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x000258A0 File Offset: 0x00023AA0
		// (set) Token: 0x06002525 RID: 9509 RVA: 0x0001C246 File Offset: 0x0001A446
		public AmbientSource AmbientSource
		{
			get
			{
				return AmbientSource.Skybox;
			}
			set
			{
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x0001C248 File Offset: 0x0001A448
		// (set) Token: 0x06002527 RID: 9511 RVA: 0x0001C24B File Offset: 0x0001A44B
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

		// Token: 0x04000D0D RID: 3341
		private readonly Lighting lighting;
	}
}
