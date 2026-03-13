using System;
using Polytoria.Controllers;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000302 RID: 770
	public class UIImageProxy : UIFieldProxy
	{
		// Token: 0x060026E4 RID: 9956 RVA: 0x0001C792 File Offset: 0x0001A992
		public UIImageProxy(UIImage target) : base(null)
		{
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x0001C79B File Offset: 0x0001A99B
		// (set) Token: 0x060026E6 RID: 9958 RVA: 0x0001C79E File Offset: 0x0001A99E
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

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x00025E70 File Offset: 0x00024070
		// (set) Token: 0x060026E8 RID: 9960 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
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

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x00025E88 File Offset: 0x00024088
		// (set) Token: 0x060026EA RID: 9962 RVA: 0x0001C7A2 File Offset: 0x0001A9A2
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

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060026EB RID: 9963 RVA: 0x0001C7A4 File Offset: 0x0001A9A4
		// (set) Token: 0x060026EC RID: 9964 RVA: 0x0001C7A7 File Offset: 0x0001A9A7
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

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060026ED RID: 9965 RVA: 0x0001C7A9 File Offset: 0x0001A9A9
		public bool Loading
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000D2E RID: 3374
		private readonly UIImage uiImage;
	}
}
