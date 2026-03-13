using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel
{
	// Token: 0x020002B6 RID: 694
	public class UIHVLayout : UIField
	{
		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x0001BAB4 File Offset: 0x00019CB4
		// (set) Token: 0x06002274 RID: 8820 RVA: 0x0001BABB File Offset: 0x00019CBB
		public float Spacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002275 RID: 8821 RVA: 0x0001BABD File Offset: 0x00019CBD
		// (set) Token: 0x06002276 RID: 8822 RVA: 0x0001BAC0 File Offset: 0x00019CC0
		public bool ChildControlWidth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x0001BAC2 File Offset: 0x00019CC2
		// (set) Token: 0x06002278 RID: 8824 RVA: 0x0001BAC5 File Offset: 0x00019CC5
		public bool ChildControlHeight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x0001BAC7 File Offset: 0x00019CC7
		// (set) Token: 0x0600227A RID: 8826 RVA: 0x0001BACA File Offset: 0x00019CCA
		public bool ChildScaleWidth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x0001BACC File Offset: 0x00019CCC
		// (set) Token: 0x0600227C RID: 8828 RVA: 0x0001BACF File Offset: 0x00019CCF
		public bool ChildScaleHeight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x0001BAD1 File Offset: 0x00019CD1
		// (set) Token: 0x0600227E RID: 8830 RVA: 0x0001BAD4 File Offset: 0x00019CD4
		public bool ChildForceExpandWidth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x0600227F RID: 8831 RVA: 0x0001BAD6 File Offset: 0x00019CD6
		// (set) Token: 0x06002280 RID: 8832 RVA: 0x0001BAD9 File Offset: 0x00019CD9
		public bool ChildForceExpandHeight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x0001BADB File Offset: 0x00019CDB
		// (set) Token: 0x06002282 RID: 8834 RVA: 0x0001BADE File Offset: 0x00019CDE
		public int PaddingLeft
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x0001BAE0 File Offset: 0x00019CE0
		// (set) Token: 0x06002284 RID: 8836 RVA: 0x0001BAE3 File Offset: 0x00019CE3
		public int PaddingRight
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x0001BAE5 File Offset: 0x00019CE5
		// (set) Token: 0x06002286 RID: 8838 RVA: 0x0001BAE8 File Offset: 0x00019CE8
		public int PaddingTop
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x0001BAEA File Offset: 0x00019CEA
		// (set) Token: 0x06002288 RID: 8840 RVA: 0x0001BAED File Offset: 0x00019CED
		public int PaddingBottom
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x000250F0 File Offset: 0x000232F0
		// (set) Token: 0x0600228A RID: 8842 RVA: 0x0001BAEF File Offset: 0x00019CEF
		public TextAnchor ChildAlignment
		{
			get
			{
				return TextAnchor.UpperLeft;
			}
			set
			{
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x0001BAF1 File Offset: 0x00019CF1
		// (set) Token: 0x0600228C RID: 8844 RVA: 0x0001BAF4 File Offset: 0x00019CF4
		public bool ReverseAlignment
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x0001BAF6 File Offset: 0x00019CF6
		private void SyncSpacing(float oldValue, float newValue)
		{
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x0001BAF8 File Offset: 0x00019CF8
		private void SyncChildControlWidth(bool oldValue, bool newValue)
		{
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x0001BAFA File Offset: 0x00019CFA
		private void SyncChildControlHeight(bool oldValue, bool newValue)
		{
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x0001BAFC File Offset: 0x00019CFC
		private void SyncChildScaleWidth(bool oldValue, bool newValue)
		{
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x0001BAFE File Offset: 0x00019CFE
		private void SyncChildScaleHeight(bool oldValue, bool newValue)
		{
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x0001BB00 File Offset: 0x00019D00
		private void SyncChildForceExpandWidth(bool oldValue, bool newValue)
		{
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x0001BB02 File Offset: 0x00019D02
		private void SyncChildForceExpandHeight(bool oldValue, bool newValue)
		{
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x0001BB04 File Offset: 0x00019D04
		private void SyncPaddingLeft(int oldValue, int newValue)
		{
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x0001BB06 File Offset: 0x00019D06
		private void SyncPaddingRight(int oldValue, int newValue)
		{
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x0001BB08 File Offset: 0x00019D08
		private void SyncPaddingTop(int oldValue, int newValue)
		{
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x0001BB0A File Offset: 0x00019D0A
		private void SyncPaddingBottom(int oldValue, int newValue)
		{
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x0001BB0C File Offset: 0x00019D0C
		private void SyncChildAlignment(TextAnchor oldValue, TextAnchor newValue)
		{
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x0001BB0E File Offset: 0x00019D0E
		private void SyncReverseAlignment(bool oldValue, bool newValue)
		{
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x0001BB10 File Offset: 0x00019D10
		protected override void Start()
		{
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x0001BB12 File Offset: 0x00019D12
		private void LateUpdate()
		{
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x0001BB14 File Offset: 0x00019D14
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x0001BB1E File Offset: 0x00019D1E
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x0001BB21 File Offset: 0x00019D21
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x0001BB28 File Offset: 0x00019D28
		public float Networkspacing
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

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0001BB2A File Offset: 0x00019D2A
		// (set) Token: 0x060022A2 RID: 8866 RVA: 0x0001BB2D File Offset: 0x00019D2D
		public bool NetworkchildControlWidth
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

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x0001BB2F File Offset: 0x00019D2F
		// (set) Token: 0x060022A4 RID: 8868 RVA: 0x0001BB32 File Offset: 0x00019D32
		public bool NetworkchildControlHeight
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

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x0001BB34 File Offset: 0x00019D34
		// (set) Token: 0x060022A6 RID: 8870 RVA: 0x0001BB37 File Offset: 0x00019D37
		public bool NetworkchildScaleWidth
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

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x0001BB39 File Offset: 0x00019D39
		// (set) Token: 0x060022A8 RID: 8872 RVA: 0x0001BB3C File Offset: 0x00019D3C
		public bool NetworkchildScaleHeight
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

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x0001BB3E File Offset: 0x00019D3E
		// (set) Token: 0x060022AA RID: 8874 RVA: 0x0001BB41 File Offset: 0x00019D41
		public bool NetworkchildForceExpandWidth
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

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x0001BB43 File Offset: 0x00019D43
		// (set) Token: 0x060022AC RID: 8876 RVA: 0x0001BB46 File Offset: 0x00019D46
		public bool NetworkchildForceExpandHeight
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

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x0001BB48 File Offset: 0x00019D48
		// (set) Token: 0x060022AE RID: 8878 RVA: 0x0001BB4B File Offset: 0x00019D4B
		public int NetworkpaddingLeft
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x0001BB4D File Offset: 0x00019D4D
		// (set) Token: 0x060022B0 RID: 8880 RVA: 0x0001BB50 File Offset: 0x00019D50
		public int NetworkpaddingRight
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x0001BB52 File Offset: 0x00019D52
		// (set) Token: 0x060022B2 RID: 8882 RVA: 0x0001BB55 File Offset: 0x00019D55
		public int NetworkpaddingTop
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x0001BB57 File Offset: 0x00019D57
		// (set) Token: 0x060022B4 RID: 8884 RVA: 0x0001BB5A File Offset: 0x00019D5A
		public int NetworkpaddingBottom
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x00025108 File Offset: 0x00023308
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x0001BB5C File Offset: 0x00019D5C
		public TextAnchor NetworkchildAlignment
		{
			get
			{
				return TextAnchor.UpperLeft;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x0001BB5E File Offset: 0x00019D5E
		// (set) Token: 0x060022B8 RID: 8888 RVA: 0x0001BB61 File Offset: 0x00019D61
		public bool NetworkreverseAlignment
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

		// Token: 0x060022B9 RID: 8889 RVA: 0x0001BB63 File Offset: 0x00019D63
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x0001BB65 File Offset: 0x00019D65
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000C3F RID: 3135
		protected HorizontalOrVerticalLayoutGroup layoutGroup;

		// Token: 0x04000C40 RID: 3136
		protected float spacing;

		// Token: 0x04000C41 RID: 3137
		protected bool childControlWidth;

		// Token: 0x04000C42 RID: 3138
		protected bool childControlHeight;

		// Token: 0x04000C43 RID: 3139
		protected bool childScaleWidth;

		// Token: 0x04000C44 RID: 3140
		protected bool childScaleHeight;

		// Token: 0x04000C45 RID: 3141
		protected bool childForceExpandWidth;

		// Token: 0x04000C46 RID: 3142
		protected bool childForceExpandHeight;

		// Token: 0x04000C47 RID: 3143
		protected int paddingLeft;

		// Token: 0x04000C48 RID: 3144
		protected int paddingRight;

		// Token: 0x04000C49 RID: 3145
		protected int paddingTop;

		// Token: 0x04000C4A RID: 3146
		protected int paddingBottom;

		// Token: 0x04000C4B RID: 3147
		protected TextAnchor childAlignment;

		// Token: 0x04000C4C RID: 3148
		protected bool reverseAlignment;

		// Token: 0x04000C4D RID: 3149
		public Action<float, float> _Mirror_SyncVarHookDelegate_spacing;

		// Token: 0x04000C4E RID: 3150
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_childControlWidth;

		// Token: 0x04000C4F RID: 3151
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_childControlHeight;

		// Token: 0x04000C50 RID: 3152
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_childScaleWidth;

		// Token: 0x04000C51 RID: 3153
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_childScaleHeight;

		// Token: 0x04000C52 RID: 3154
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_childForceExpandWidth;

		// Token: 0x04000C53 RID: 3155
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_childForceExpandHeight;

		// Token: 0x04000C54 RID: 3156
		public Action<int, int> _Mirror_SyncVarHookDelegate_paddingLeft;

		// Token: 0x04000C55 RID: 3157
		public Action<int, int> _Mirror_SyncVarHookDelegate_paddingRight;

		// Token: 0x04000C56 RID: 3158
		public Action<int, int> _Mirror_SyncVarHookDelegate_paddingTop;

		// Token: 0x04000C57 RID: 3159
		public Action<int, int> _Mirror_SyncVarHookDelegate_paddingBottom;

		// Token: 0x04000C58 RID: 3160
		public Action<TextAnchor, TextAnchor> _Mirror_SyncVarHookDelegate_childAlignment;

		// Token: 0x04000C59 RID: 3161
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_reverseAlignment;
	}
}
