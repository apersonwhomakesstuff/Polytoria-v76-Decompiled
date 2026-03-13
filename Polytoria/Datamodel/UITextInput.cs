using System;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Lua;
using TMPro;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002BC RID: 700
	public class UITextInput : UIView
	{
		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x0001BC3C File Offset: 0x00019E3C
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x0001BC3F File Offset: 0x00019E3F
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

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x00025270 File Offset: 0x00023470
		// (set) Token: 0x0600231C RID: 8988 RVA: 0x0001BC41 File Offset: 0x00019E41
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

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x00025288 File Offset: 0x00023488
		// (set) Token: 0x0600231E RID: 8990 RVA: 0x0001BC43 File Offset: 0x00019E43
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

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x000252A0 File Offset: 0x000234A0
		// (set) Token: 0x06002320 RID: 8992 RVA: 0x0001BC45 File Offset: 0x00019E45
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

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x0001BC47 File Offset: 0x00019E47
		// (set) Token: 0x06002322 RID: 8994 RVA: 0x0001BC4E File Offset: 0x00019E4E
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

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x0001BC50 File Offset: 0x00019E50
		// (set) Token: 0x06002324 RID: 8996 RVA: 0x0001BC57 File Offset: 0x00019E57
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

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x0001BC59 File Offset: 0x00019E59
		// (set) Token: 0x06002326 RID: 8998 RVA: 0x0001BC5C File Offset: 0x00019E5C
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

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x000252B8 File Offset: 0x000234B8
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x0001BC5E File Offset: 0x00019E5E
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

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x0001BC60 File Offset: 0x00019E60
		// (set) Token: 0x0600232A RID: 9002 RVA: 0x0001BC63 File Offset: 0x00019E63
		public string Placeholder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x000252D0 File Offset: 0x000234D0
		// (set) Token: 0x0600232C RID: 9004 RVA: 0x0001BC65 File Offset: 0x00019E65
		public Color PlaceholderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x0001BC67 File Offset: 0x00019E67
		// (set) Token: 0x0600232E RID: 9006 RVA: 0x0001BC6A File Offset: 0x00019E6A
		public bool IsMultiline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x0001BC6C File Offset: 0x00019E6C
		// (set) Token: 0x06002330 RID: 9008 RVA: 0x0001BC6F File Offset: 0x00019E6F
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x0001BC71 File Offset: 0x00019E71
		public bool IsFocused
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x0001BC74 File Offset: 0x00019E74
		public void Focus()
		{
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x0001BC76 File Offset: 0x00019E76
		private void SyncSetText(string oldtext, string newtext)
		{
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x0001BC78 File Offset: 0x00019E78
		private void SyncSetTextJustify(TextJustify oldValue, TextJustify newValue)
		{
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x0001BC7A File Offset: 0x00019E7A
		private void SyncSetTextAlign(TextVerticalAlign oldValue, TextVerticalAlign newValue)
		{
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x0001BC7C File Offset: 0x00019E7C
		private void SyncSetFontSize(float oldValue, float newValue)
		{
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x0001BC7E File Offset: 0x00019E7E
		private void SyncSetMaxFontSize(float oldValue, float newValue)
		{
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x0001BC80 File Offset: 0x00019E80
		private void SyncSetAutoSize(bool oldValue, bool newValue)
		{
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x0001BC82 File Offset: 0x00019E82
		private void SyncSetColor(Color oldValue, Color newValue)
		{
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x0001BC84 File Offset: 0x00019E84
		private void SyncSetFont(TextFontPreset oldValue, TextFontPreset newValue)
		{
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x0001BC86 File Offset: 0x00019E86
		private void SyncSetPlaceholder(string oldValue, string newValue)
		{
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x0001BC88 File Offset: 0x00019E88
		private void SyncSetPlaceholderColor(Color oldValue, Color newValue)
		{
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x0001BC8A File Offset: 0x00019E8A
		private void SyncSetIsMultiline(bool oldValue, bool newValue)
		{
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x0001BC8C File Offset: 0x00019E8C
		private void SyncSetIsReadOnly(bool oldValue, bool newValue)
		{
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x0001BC8E File Offset: 0x00019E8E
		protected override void Awake()
		{
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x0001BC90 File Offset: 0x00019E90
		protected override void Start()
		{
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x0001BC92 File Offset: 0x00019E92
		protected override void OnHide()
		{
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0001BC94 File Offset: 0x00019E94
		protected override void OnShow()
		{
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x0001BC96 File Offset: 0x00019E96
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0001BCA0 File Offset: 0x00019EA0
		private void <Awake>b__67_0(string s)
		{
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0001BCA2 File Offset: 0x00019EA2
		private void <Awake>b__67_1(string s)
		{
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x0001BCA4 File Offset: 0x00019EA4
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x000252E8 File Offset: 0x000234E8
		// (set) Token: 0x06002349 RID: 9033 RVA: 0x0001BCA7 File Offset: 0x00019EA7
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

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x00025300 File Offset: 0x00023500
		// (set) Token: 0x0600234B RID: 9035 RVA: 0x0001BCA9 File Offset: 0x00019EA9
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

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x0600234C RID: 9036 RVA: 0x0001BCAB File Offset: 0x00019EAB
		// (set) Token: 0x0600234D RID: 9037 RVA: 0x0001BCB2 File Offset: 0x00019EB2
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

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x0001BCB4 File Offset: 0x00019EB4
		// (set) Token: 0x0600234F RID: 9039 RVA: 0x0001BCBB File Offset: 0x00019EBB
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

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x0001BCBD File Offset: 0x00019EBD
		// (set) Token: 0x06002351 RID: 9041 RVA: 0x0001BCC0 File Offset: 0x00019EC0
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

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x0001BCC2 File Offset: 0x00019EC2
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x0001BCC5 File Offset: 0x00019EC5
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

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x00025318 File Offset: 0x00023518
		// (set) Token: 0x06002355 RID: 9045 RVA: 0x0001BCC7 File Offset: 0x00019EC7
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

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x00025330 File Offset: 0x00023530
		// (set) Token: 0x06002357 RID: 9047 RVA: 0x0001BCC9 File Offset: 0x00019EC9
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

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x0001BCCB File Offset: 0x00019ECB
		// (set) Token: 0x06002359 RID: 9049 RVA: 0x0001BCCE File Offset: 0x00019ECE
		public string Networkplaceholder
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

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x00025348 File Offset: 0x00023548
		// (set) Token: 0x0600235B RID: 9051 RVA: 0x0001BCD0 File Offset: 0x00019ED0
		public Color NetworkplaceholderColor
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

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x0600235C RID: 9052 RVA: 0x0001BCD2 File Offset: 0x00019ED2
		// (set) Token: 0x0600235D RID: 9053 RVA: 0x0001BCD5 File Offset: 0x00019ED5
		public bool NetworkisReadOnly
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

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x0001BCD7 File Offset: 0x00019ED7
		// (set) Token: 0x0600235F RID: 9055 RVA: 0x0001BCDA File Offset: 0x00019EDA
		public bool NetworkisMultiline
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

		// Token: 0x06002360 RID: 9056 RVA: 0x0001BCDC File Offset: 0x00019EDC
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x0001BCDE File Offset: 0x00019EDE
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000C93 RID: 3219
		private TMP_InputField inputField;

		// Token: 0x04000C94 RID: 3220
		private TMP_Text placeholderText;

		// Token: 0x04000C95 RID: 3221
		public LuaEvent Changed;

		// Token: 0x04000C96 RID: 3222
		public LuaEvent Submitted;

		// Token: 0x04000C97 RID: 3223
		private TextJustify justify;

		// Token: 0x04000C98 RID: 3224
		private TextVerticalAlign verticalAlign;

		// Token: 0x04000C99 RID: 3225
		private float fontSize;

		// Token: 0x04000C9A RID: 3226
		private float maxFontSize;

		// Token: 0x04000C9B RID: 3227
		private bool autoSize;

		// Token: 0x04000C9C RID: 3228
		private string text;

		// Token: 0x04000C9D RID: 3229
		private Color textColor;

		// Token: 0x04000C9E RID: 3230
		private TextFontPreset font;

		// Token: 0x04000C9F RID: 3231
		private string placeholder;

		// Token: 0x04000CA0 RID: 3232
		private Color placeholderColor;

		// Token: 0x04000CA1 RID: 3233
		private bool isReadOnly;

		// Token: 0x04000CA2 RID: 3234
		private bool isMultiline;

		// Token: 0x04000CA3 RID: 3235
		public Action<TextJustify, TextJustify> _Mirror_SyncVarHookDelegate_justify;

		// Token: 0x04000CA4 RID: 3236
		public Action<TextVerticalAlign, TextVerticalAlign> _Mirror_SyncVarHookDelegate_verticalAlign;

		// Token: 0x04000CA5 RID: 3237
		public Action<float, float> _Mirror_SyncVarHookDelegate_fontSize;

		// Token: 0x04000CA6 RID: 3238
		public Action<float, float> _Mirror_SyncVarHookDelegate_maxFontSize;

		// Token: 0x04000CA7 RID: 3239
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_autoSize;

		// Token: 0x04000CA8 RID: 3240
		public Action<string, string> _Mirror_SyncVarHookDelegate_text;

		// Token: 0x04000CA9 RID: 3241
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_textColor;

		// Token: 0x04000CAA RID: 3242
		public Action<TextFontPreset, TextFontPreset> _Mirror_SyncVarHookDelegate_font;

		// Token: 0x04000CAB RID: 3243
		public Action<string, string> _Mirror_SyncVarHookDelegate_placeholder;

		// Token: 0x04000CAC RID: 3244
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_placeholderColor;

		// Token: 0x04000CAD RID: 3245
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_isReadOnly;

		// Token: 0x04000CAE RID: 3246
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_isMultiline;
	}
}
