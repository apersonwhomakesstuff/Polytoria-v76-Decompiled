using System;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel
{
	// Token: 0x020002B7 RID: 695
	public class UIImage : UIField
	{
		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x00025120 File Offset: 0x00023320
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x0001BB67 File Offset: 0x00019D67
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

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x0001BB69 File Offset: 0x00019D69
		public bool Loading
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x0001BB6C File Offset: 0x00019D6C
		// (set) Token: 0x060022BF RID: 8895 RVA: 0x0001BB6F File Offset: 0x00019D6F
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

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x00025138 File Offset: 0x00023338
		// (set) Token: 0x060022C1 RID: 8897 RVA: 0x0001BB71 File Offset: 0x00019D71
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

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x0001BB73 File Offset: 0x00019D73
		// (set) Token: 0x060022C3 RID: 8899 RVA: 0x0001BB76 File Offset: 0x00019D76
		public bool Clickable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x0001BB78 File Offset: 0x00019D78
		private void SyncSetColor(Color oldValue, Color newValue)
		{
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x0001BB7A File Offset: 0x00019D7A
		private void SetImage(string oldValue, string newValue)
		{
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x0001BB7C File Offset: 0x00019D7C
		private void SetImageType(ImageType oldValue, ImageType newValue)
		{
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x0001BB7E File Offset: 0x00019D7E
		private void SyncSetClickable(bool oldValue, bool newValue)
		{
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x0001BB80 File Offset: 0x00019D80
		protected override void Awake()
		{
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x0001BB82 File Offset: 0x00019D82
		protected override void Start()
		{
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x0001BB84 File Offset: 0x00019D84
		private void LoadFallback()
		{
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x0001BB86 File Offset: 0x00019D86
		private void GetImage()
		{
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x0001BB88 File Offset: 0x00019D88
		protected override void OnHide()
		{
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x0001BB8A File Offset: 0x00019D8A
		protected override void OnShow()
		{
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x0001BB8C File Offset: 0x00019D8C
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x0001BB96 File Offset: 0x00019D96
		private void <GetImage>b__29_0(ImageCacheKey key, ImageCacheEntry entry)
		{
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x0001BB98 File Offset: 0x00019D98
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x00025150 File Offset: 0x00023350
		// (set) Token: 0x060022D3 RID: 8915 RVA: 0x0001BB9B File Offset: 0x00019D9B
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

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x0001BB9D File Offset: 0x00019D9D
		// (set) Token: 0x060022D5 RID: 8917 RVA: 0x0001BBA0 File Offset: 0x00019DA0
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

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x00025168 File Offset: 0x00023368
		// (set) Token: 0x060022D7 RID: 8919 RVA: 0x0001BBA2 File Offset: 0x00019DA2
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

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x0001BBA4 File Offset: 0x00019DA4
		// (set) Token: 0x060022D9 RID: 8921 RVA: 0x0001BBA7 File Offset: 0x00019DA7
		public bool Networkclickable
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

		// Token: 0x060022DA RID: 8922 RVA: 0x0001BBA9 File Offset: 0x00019DA9
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x0001BBAB File Offset: 0x00019DAB
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000C5A RID: 3162
		private Image image;

		// Token: 0x04000C5B RID: 3163
		private Color color;

		// Token: 0x04000C5C RID: 3164
		private string imageID;

		// Token: 0x04000C5D RID: 3165
		private ImageType imageType;

		// Token: 0x04000C5E RID: 3166
		private bool clickable;

		// Token: 0x04000C5F RID: 3167
		private bool loading;

		// Token: 0x04000C60 RID: 3168
		private Texture2D texture;

		// Token: 0x04000C61 RID: 3169
		private ImageCacheKey lastCacheKey;

		// Token: 0x04000C62 RID: 3170
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_color;

		// Token: 0x04000C63 RID: 3171
		public Action<string, string> _Mirror_SyncVarHookDelegate_imageID;

		// Token: 0x04000C64 RID: 3172
		public Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType;

		// Token: 0x04000C65 RID: 3173
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_clickable;
	}
}
