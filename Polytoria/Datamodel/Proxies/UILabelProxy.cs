using System;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000303 RID: 771
	public class UILabelProxy : UIViewProxy
	{
		// Token: 0x060026EE RID: 9966 RVA: 0x0001C7AC File Offset: 0x0001A9AC
		public UILabelProxy(UILabel target) : base(null)
		{
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060026EF RID: 9967 RVA: 0x0001C7B5 File Offset: 0x0001A9B5
		// (set) Token: 0x060026F0 RID: 9968 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x00025EA0 File Offset: 0x000240A0
		// (set) Token: 0x060026F2 RID: 9970 RVA: 0x0001C7BA File Offset: 0x0001A9BA
		public Color TextColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x060026F3 RID: 9971 RVA: 0x00025EB8 File Offset: 0x000240B8
		// (set) Token: 0x060026F4 RID: 9972 RVA: 0x0001C7BC File Offset: 0x0001A9BC
		public TextJustify JustifyText
		{
			get
			{
				return TextJustify.Left;
			}
			set
			{
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x00025ED0 File Offset: 0x000240D0
		// (set) Token: 0x060026F6 RID: 9974 RVA: 0x0001C7BE File Offset: 0x0001A9BE
		public TextVerticalAlign VerticalAlign
		{
			get
			{
				return TextVerticalAlign.Top;
			}
			set
			{
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x0001C7C0 File Offset: 0x0001A9C0
		// (set) Token: 0x060026F8 RID: 9976 RVA: 0x0001C7C7 File Offset: 0x0001A9C7
		public float FontSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x0001C7C9 File Offset: 0x0001A9C9
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x0001C7D0 File Offset: 0x0001A9D0
		public float MaxFontSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x0001C7D2 File Offset: 0x0001A9D2
		// (set) Token: 0x060026FC RID: 9980 RVA: 0x0001C7D5 File Offset: 0x0001A9D5
		public bool AutoSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x00025EE8 File Offset: 0x000240E8
		// (set) Token: 0x060026FE RID: 9982 RVA: 0x0001C7D7 File Offset: 0x0001A9D7
		public TextFontPreset Font
		{
			get
			{
				return TextFontPreset.SourceSans;
			}
			set
			{
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x00025F00 File Offset: 0x00024100
		// (set) Token: 0x06002700 RID: 9984 RVA: 0x0001C7D9 File Offset: 0x0001A9D9
		public Color OutlineColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x0001C7DB File Offset: 0x0001A9DB
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x0001C7E2 File Offset: 0x0001A9E2
		public float OutlineWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x04000D2F RID: 3375
		private readonly UILabel uiLabel;
	}
}
