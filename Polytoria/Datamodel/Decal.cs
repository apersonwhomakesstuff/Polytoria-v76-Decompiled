using System;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Controllers;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000275 RID: 629
	public class Decal : DynamicInstance
	{
		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x0001A808 File Offset: 0x00018A08
		// (set) Token: 0x06001B3C RID: 6972 RVA: 0x0001A80B File Offset: 0x00018A0B
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

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x00024268 File Offset: 0x00022468
		// (set) Token: 0x06001B3E RID: 6974 RVA: 0x0001A80D File Offset: 0x00018A0D
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

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x00024280 File Offset: 0x00022480
		// (set) Token: 0x06001B40 RID: 6976 RVA: 0x0001A80F File Offset: 0x00018A0F
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

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x00024298 File Offset: 0x00022498
		// (set) Token: 0x06001B42 RID: 6978 RVA: 0x0001A811 File Offset: 0x00018A11
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

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001B43 RID: 6979 RVA: 0x000242B0 File Offset: 0x000224B0
		// (set) Token: 0x06001B44 RID: 6980 RVA: 0x0001A813 File Offset: 0x00018A13
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

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x0001A815 File Offset: 0x00018A15
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x0001A818 File Offset: 0x00018A18
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

		// Token: 0x06001B47 RID: 6983 RVA: 0x0001A81A File Offset: 0x00018A1A
		private void SetTextureScale(Vector2 oldScale, Vector2 newScale)
		{
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0001A81C File Offset: 0x00018A1C
		private void SetTextureOffset(Vector2 oldOffset, Vector2 newOffset)
		{
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0001A81E File Offset: 0x00018A1E
		private void SetCastShadows(bool oldShadows, bool newShadows)
		{
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0001A820 File Offset: 0x00018A20
		protected override void OnHide()
		{
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x0001A822 File Offset: 0x00018A22
		protected override void OnShow()
		{
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0001A824 File Offset: 0x00018A24
		private void SetImage(string oldId, string newId)
		{
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0001A826 File Offset: 0x00018A26
		private void SetImageType(ImageType oldType, ImageType newType)
		{
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0001A828 File Offset: 0x00018A28
		private void SetColor(Color oldColor, Color newColor)
		{
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0001A82A File Offset: 0x00018A2A
		protected override void Awake()
		{
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0001A82C File Offset: 0x00018A2C
		protected override void Start()
		{
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0001A82E File Offset: 0x00018A2E
		protected override void Update()
		{
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0001A830 File Offset: 0x00018A30
		private void GetImage()
		{
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0001A832 File Offset: 0x00018A32
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0001A83C File Offset: 0x00018A3C
		private void <GetImage>b__41_0(ImageCacheKey key, ImageCacheEntry entry)
		{
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0001A83E File Offset: 0x00018A3E
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x0001A841 File Offset: 0x00018A41
		// (set) Token: 0x06001B58 RID: 7000 RVA: 0x0001A844 File Offset: 0x00018A44
		public string NetworkimageID
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x000242C8 File Offset: 0x000224C8
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x0001A846 File Offset: 0x00018A46
		public ImageType NetworkimageType
		{
			get
			{
				return ImageType.Asset;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x000242E0 File Offset: 0x000224E0
		// (set) Token: 0x06001B5C RID: 7004 RVA: 0x0001A848 File Offset: 0x00018A48
		public Vector2 NetworktextureScale
		{
			get
			{
				return default(Vector2);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x000242F8 File Offset: 0x000224F8
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x0001A84A File Offset: 0x00018A4A
		public Vector2 NetworktextureOffset
		{
			get
			{
				return default(Vector2);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x00024310 File Offset: 0x00022510
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x0001A84C File Offset: 0x00018A4C
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

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x0001A84E File Offset: 0x00018A4E
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x0001A851 File Offset: 0x00018A51
		public bool NetworkcastShadows
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

		// Token: 0x06001B63 RID: 7011 RVA: 0x0001A853 File Offset: 0x00018A53
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0001A855 File Offset: 0x00018A55
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x040009E3 RID: 2531
		private string imageID;

		// Token: 0x040009E4 RID: 2532
		private ImageType imageType;

		// Token: 0x040009E5 RID: 2533
		private Vector2 textureScale;

		// Token: 0x040009E6 RID: 2534
		private Vector2 textureOffset;

		// Token: 0x040009E7 RID: 2535
		private Color color;

		// Token: 0x040009E8 RID: 2536
		private bool castShadows;

		// Token: 0x040009E9 RID: 2537
		private ImageCacheKey lastCacheKey;

		// Token: 0x040009EA RID: 2538
		private BoxCollider col;

		// Token: 0x040009EB RID: 2539
		private MeshRenderer meshRenderer;

		// Token: 0x040009EC RID: 2540
		private ImageCacheEntry currentEntry;

		// Token: 0x040009ED RID: 2541
		private Material transparentMaterial;

		// Token: 0x040009EE RID: 2542
		private Material cutoutMaterial;

		// Token: 0x040009EF RID: 2543
		public Action<string, string> _Mirror_SyncVarHookDelegate_imageID;

		// Token: 0x040009F0 RID: 2544
		public Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType;

		// Token: 0x040009F1 RID: 2545
		public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_textureScale;

		// Token: 0x040009F2 RID: 2546
		public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_textureOffset;

		// Token: 0x040009F3 RID: 2547
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_color;

		// Token: 0x040009F4 RID: 2548
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_castShadows;
	}
}
