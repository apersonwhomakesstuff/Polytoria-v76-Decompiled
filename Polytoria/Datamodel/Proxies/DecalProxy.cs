using System;
using Polytoria.Controllers;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D5 RID: 725
	public class DecalProxy : DynamicInstanceProxy
	{
		// Token: 0x06002483 RID: 9347 RVA: 0x0001C08B File Offset: 0x0001A28B
		public DecalProxy(Decal target) : base(null)
		{
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x0001C094 File Offset: 0x0001A294
		// (set) Token: 0x06002485 RID: 9349 RVA: 0x0001C097 File Offset: 0x0001A297
		public string ImageID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x00025570 File Offset: 0x00023770
		// (set) Token: 0x06002487 RID: 9351 RVA: 0x0001C099 File Offset: 0x0001A299
		public ImageType ImageType
		{
			get
			{
				return ImageType.Asset;
			}
			set
			{
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x00025588 File Offset: 0x00023788
		// (set) Token: 0x06002489 RID: 9353 RVA: 0x0001C09B File Offset: 0x0001A29B
		public Vector2 TextureScale
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x000255A0 File Offset: 0x000237A0
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x0001C09D File Offset: 0x0001A29D
		public Vector2 TextureOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x000255B8 File Offset: 0x000237B8
		// (set) Token: 0x0600248D RID: 9357 RVA: 0x0001C09F File Offset: 0x0001A29F
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

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x0001C0A1 File Offset: 0x0001A2A1
		// (set) Token: 0x0600248F RID: 9359 RVA: 0x0001C0A4 File Offset: 0x0001A2A4
		public bool CastShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x04000D01 RID: 3329
		private readonly Decal decal;
	}
}
