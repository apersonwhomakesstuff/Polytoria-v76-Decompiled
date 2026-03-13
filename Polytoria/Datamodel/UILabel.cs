using System;
using System.Runtime.InteropServices;
using Mirror;
using TMPro;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002BB RID: 699
	public class UILabel : UIView
	{
		// Token: 0x060022DC RID: 8924 RVA: 0x0001BBAD File Offset: 0x00019DAD
		private void SyncSetText(string oldtext, string newtext)
		{
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x0001BBAF File Offset: 0x00019DAF
		private void SyncSetTextJustify(TextJustify oldValue, TextJustify newValue)
		{
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x0001BBB1 File Offset: 0x00019DB1
		private void SyncSetTextAlign(TextVerticalAlign oldValue, TextVerticalAlign newValue)
		{
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x0001BBB3 File Offset: 0x00019DB3
		private void SyncSetFontSize(float oldValue, float newValue)
		{
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x0001BBB5 File Offset: 0x00019DB5
		private void SyncSetMaxFontSize(float oldValue, float newValue)
		{
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x0001BBB7 File Offset: 0x00019DB7
		private void SyncSetAutoSize(bool oldValue, bool newValue)
		{
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x0001BBB9 File Offset: 0x00019DB9
		private void SyncSetColor(Color oldValue, Color newValue)
		{
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x0001BBBB File Offset: 0x00019DBB
		private void SyncSetFont(TextFontPreset oldValue, TextFontPreset newValue)
		{
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x0001BBBD File Offset: 0x00019DBD
		private void SyncSetOutlineColor(Color oldValue, Color newValue)
		{
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x0001BBBF File Offset: 0x00019DBF
		private void SyncSetOutlineWidth(float oldValue, float newValue)
		{
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x0001BBC1 File Offset: 0x00019DC1
		// (set) Token: 0x060022E7 RID: 8935 RVA: 0x0001BBC4 File Offset: 0x00019DC4
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

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x00025180 File Offset: 0x00023380
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x0001BBC6 File Offset: 0x00019DC6
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

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x00025198 File Offset: 0x00023398
		// (set) Token: 0x060022EB RID: 8939 RVA: 0x0001BBC8 File Offset: 0x00019DC8
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

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x000251B0 File Offset: 0x000233B0
		// (set) Token: 0x060022ED RID: 8941 RVA: 0x0001BBCA File Offset: 0x00019DCA
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

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x0001BBCC File Offset: 0x00019DCC
		// (set) Token: 0x060022EF RID: 8943 RVA: 0x0001BBD3 File Offset: 0x00019DD3
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

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x0001BBD5 File Offset: 0x00019DD5
		// (set) Token: 0x060022F1 RID: 8945 RVA: 0x0001BBDC File Offset: 0x00019DDC
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

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x0001BBDE File Offset: 0x00019DDE
		// (set) Token: 0x060022F3 RID: 8947 RVA: 0x0001BBE1 File Offset: 0x00019DE1
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

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x000251C8 File Offset: 0x000233C8
		// (set) Token: 0x060022F5 RID: 8949 RVA: 0x0001BBE3 File Offset: 0x00019DE3
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

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x000251E0 File Offset: 0x000233E0
		// (set) Token: 0x060022F7 RID: 8951 RVA: 0x0001BBE5 File Offset: 0x00019DE5
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

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x060022F8 RID: 8952 RVA: 0x0001BBE7 File Offset: 0x00019DE7
		// (set) Token: 0x060022F9 RID: 8953 RVA: 0x0001BBEE File Offset: 0x00019DEE
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

		// Token: 0x060022FA RID: 8954 RVA: 0x0001BBF0 File Offset: 0x00019DF0
		private void UpdateOutline()
		{
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x0001BBF2 File Offset: 0x00019DF2
		protected override void Awake()
		{
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x0001BBF4 File Offset: 0x00019DF4
		protected override void Start()
		{
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x0001BBF6 File Offset: 0x00019DF6
		protected override void OnHide()
		{
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x0001BBF8 File Offset: 0x00019DF8
		protected override void OnShow()
		{
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x0001BBFA File Offset: 0x00019DFA
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x0001BBFC File Offset: 0x00019DFC
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0001BC06 File Offset: 0x00019E06
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x000251F8 File Offset: 0x000233F8
		// (set) Token: 0x06002304 RID: 8964 RVA: 0x0001BC09 File Offset: 0x00019E09
		public TextJustify Networkjustify
		{
			get
			{
				return TextJustify.Left;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x00025210 File Offset: 0x00023410
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x0001BC0B File Offset: 0x00019E0B
		public TextVerticalAlign NetworkverticalAlign
		{
			get
			{
				return TextVerticalAlign.Top;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x0001BC0D File Offset: 0x00019E0D
		// (set) Token: 0x06002308 RID: 8968 RVA: 0x0001BC14 File Offset: 0x00019E14
		public float NetworkfontSize
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

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x0001BC16 File Offset: 0x00019E16
		// (set) Token: 0x0600230A RID: 8970 RVA: 0x0001BC1D File Offset: 0x00019E1D
		public float NetworkmaxFontSize
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

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x0001BC1F File Offset: 0x00019E1F
		// (set) Token: 0x0600230C RID: 8972 RVA: 0x0001BC22 File Offset: 0x00019E22
		public bool NetworkautoSize
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

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x0001BC24 File Offset: 0x00019E24
		// (set) Token: 0x0600230E RID: 8974 RVA: 0x0001BC27 File Offset: 0x00019E27
		public string Networktext
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

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x00025228 File Offset: 0x00023428
		// (set) Token: 0x06002310 RID: 8976 RVA: 0x0001BC29 File Offset: 0x00019E29
		public Color NetworktextColor
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

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x00025240 File Offset: 0x00023440
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x0001BC2B File Offset: 0x00019E2B
		public TextFontPreset Networkfont
		{
			get
			{
				return TextFontPreset.SourceSans;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x00025258 File Offset: 0x00023458
		// (set) Token: 0x06002314 RID: 8980 RVA: 0x0001BC2D File Offset: 0x00019E2D
		public Color NetworkoutlineColor
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

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x0001BC2F File Offset: 0x00019E2F
		// (set) Token: 0x06002316 RID: 8982 RVA: 0x0001BC36 File Offset: 0x00019E36
		public float NetworkoutlineWidth
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

		// Token: 0x06002317 RID: 8983 RVA: 0x0001BC38 File Offset: 0x00019E38
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x0001BC3A File Offset: 0x00019E3A
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000C7D RID: 3197
		public const float FONT_SCALE = 1.5f;

		// Token: 0x04000C7E RID: 3198
		private TMP_Text tmp;

		// Token: 0x04000C7F RID: 3199
		private TextJustify justify;

		// Token: 0x04000C80 RID: 3200
		private TextVerticalAlign verticalAlign;

		// Token: 0x04000C81 RID: 3201
		private float fontSize;

		// Token: 0x04000C82 RID: 3202
		private float maxFontSize;

		// Token: 0x04000C83 RID: 3203
		private bool autoSize;

		// Token: 0x04000C84 RID: 3204
		private string text;

		// Token: 0x04000C85 RID: 3205
		private Color textColor;

		// Token: 0x04000C86 RID: 3206
		private TextFontPreset font;

		// Token: 0x04000C87 RID: 3207
		private Color outlineColor;

		// Token: 0x04000C88 RID: 3208
		private float outlineWidth;

		// Token: 0x04000C89 RID: 3209
		public Action<TextJustify, TextJustify> _Mirror_SyncVarHookDelegate_justify;

		// Token: 0x04000C8A RID: 3210
		public Action<TextVerticalAlign, TextVerticalAlign> _Mirror_SyncVarHookDelegate_verticalAlign;

		// Token: 0x04000C8B RID: 3211
		public Action<float, float> _Mirror_SyncVarHookDelegate_fontSize;

		// Token: 0x04000C8C RID: 3212
		public Action<float, float> _Mirror_SyncVarHookDelegate_maxFontSize;

		// Token: 0x04000C8D RID: 3213
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_autoSize;

		// Token: 0x04000C8E RID: 3214
		public Action<string, string> _Mirror_SyncVarHookDelegate_text;

		// Token: 0x04000C8F RID: 3215
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_textColor;

		// Token: 0x04000C90 RID: 3216
		public Action<TextFontPreset, TextFontPreset> _Mirror_SyncVarHookDelegate_font;

		// Token: 0x04000C91 RID: 3217
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_outlineColor;

		// Token: 0x04000C92 RID: 3218
		public Action<float, float> _Mirror_SyncVarHookDelegate_outlineWidth;
	}
}
