using System;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000304 RID: 772
	public class UITextInputProxy : UIViewProxy
	{
		// Token: 0x06002703 RID: 9987 RVA: 0x0001C7E4 File Offset: 0x0001A9E4
		public UITextInputProxy(UITextInput target) : base(null)
		{
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002704 RID: 9988 RVA: 0x0001C7ED File Offset: 0x0001A9ED
		// (set) Token: 0x06002705 RID: 9989 RVA: 0x0001C7F0 File Offset: 0x0001A9F0
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

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x00025F18 File Offset: 0x00024118
		// (set) Token: 0x06002707 RID: 9991 RVA: 0x0001C7F2 File Offset: 0x0001A9F2
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

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002708 RID: 9992 RVA: 0x00025F30 File Offset: 0x00024130
		// (set) Token: 0x06002709 RID: 9993 RVA: 0x0001C7F4 File Offset: 0x0001A9F4
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

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x0600270A RID: 9994 RVA: 0x00025F48 File Offset: 0x00024148
		// (set) Token: 0x0600270B RID: 9995 RVA: 0x0001C7F6 File Offset: 0x0001A9F6
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

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x0600270C RID: 9996 RVA: 0x0001C7F8 File Offset: 0x0001A9F8
		// (set) Token: 0x0600270D RID: 9997 RVA: 0x0001C7FF File Offset: 0x0001A9FF
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

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x0600270E RID: 9998 RVA: 0x0001C801 File Offset: 0x0001AA01
		// (set) Token: 0x0600270F RID: 9999 RVA: 0x0001C808 File Offset: 0x0001AA08
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

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x0001C80A File Offset: 0x0001AA0A
		// (set) Token: 0x06002711 RID: 10001 RVA: 0x0001C80D File Offset: 0x0001AA0D
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

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x00025F60 File Offset: 0x00024160
		// (set) Token: 0x06002713 RID: 10003 RVA: 0x0001C80F File Offset: 0x0001AA0F
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

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002714 RID: 10004 RVA: 0x0001C811 File Offset: 0x0001AA11
		// (set) Token: 0x06002715 RID: 10005 RVA: 0x0001C814 File Offset: 0x0001AA14
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

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002716 RID: 10006 RVA: 0x00025F78 File Offset: 0x00024178
		// (set) Token: 0x06002717 RID: 10007 RVA: 0x0001C816 File Offset: 0x0001AA16
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

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06002718 RID: 10008 RVA: 0x0001C818 File Offset: 0x0001AA18
		// (set) Token: 0x06002719 RID: 10009 RVA: 0x0001C81B File Offset: 0x0001AA1B
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

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x0600271A RID: 10010 RVA: 0x0001C81D File Offset: 0x0001AA1D
		// (set) Token: 0x0600271B RID: 10011 RVA: 0x0001C820 File Offset: 0x0001AA20
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

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x0001C822 File Offset: 0x0001AA22
		public bool IsFocused
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x0001C825 File Offset: 0x0001AA25
		public LuaEvent Changed
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x0600271E RID: 10014 RVA: 0x0001C828 File Offset: 0x0001AA28
		public LuaEvent Submitted
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x0001C82B File Offset: 0x0001AA2B
		public void Focus()
		{
		}

		// Token: 0x04000D30 RID: 3376
		private readonly UITextInput uiTextInput;
	}
}
