using System;
using System.Runtime.InteropServices;
using Mirror;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel
{
	// Token: 0x020002B0 RID: 688
	public class Text3D : DynamicInstance
	{
		// Token: 0x060021AD RID: 8621 RVA: 0x0001B905 File Offset: 0x00019B05
		protected override void OnHide()
		{
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x0001B907 File Offset: 0x00019B07
		protected override void OnShow()
		{
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x0001B909 File Offset: 0x00019B09
		// (set) Token: 0x060021B0 RID: 8624 RVA: 0x0001B90C File Offset: 0x00019B0C
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

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00024F10 File Offset: 0x00023110
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x0001B90E File Offset: 0x00019B0E
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

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x0001B910 File Offset: 0x00019B10
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x0001B917 File Offset: 0x00019B17
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

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x0001B919 File Offset: 0x00019B19
		// (set) Token: 0x060021B6 RID: 8630 RVA: 0x0001B91C File Offset: 0x00019B1C
		public bool FaceCamera
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x00024F28 File Offset: 0x00023128
		// (set) Token: 0x060021B8 RID: 8632 RVA: 0x0001B91E File Offset: 0x00019B1E
		public HorizontalAlignmentOptions HorizontalAlignment
		{
			get
			{
				return (HorizontalAlignmentOptions)0;
			}
			set
			{
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x00024F40 File Offset: 0x00023140
		// (set) Token: 0x060021BA RID: 8634 RVA: 0x0001B920 File Offset: 0x00019B20
		public VerticalAlignmentOptions VerticalAlignment
		{
			get
			{
				return (VerticalAlignmentOptions)0;
			}
			set
			{
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x00024F58 File Offset: 0x00023158
		// (set) Token: 0x060021BC RID: 8636 RVA: 0x0001B922 File Offset: 0x00019B22
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

		// Token: 0x060021BD RID: 8637 RVA: 0x0001B924 File Offset: 0x00019B24
		protected override void Awake()
		{
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0001B926 File Offset: 0x00019B26
		protected override void Start()
		{
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x0001B928 File Offset: 0x00019B28
		protected override void Update()
		{
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x0001B92A File Offset: 0x00019B2A
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x0001B92C File Offset: 0x00019B2C
		private void RpcSetText(string t)
		{
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0001B92E File Offset: 0x00019B2E
		private void RpcSetColor(Color color)
		{
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x0001B930 File Offset: 0x00019B30
		private void RpcSetFontSize(float fs)
		{
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x0001B932 File Offset: 0x00019B32
		private void RpcSetHorizontalAlignment(HorizontalAlignmentOptions al)
		{
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x0001B934 File Offset: 0x00019B34
		private void RpcSetVerticalAlignment(VerticalAlignmentOptions al)
		{
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x0001B936 File Offset: 0x00019B36
		private void SyncSetFont(TextFontPreset oldValue, TextFontPreset newValue)
		{
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x0001B940 File Offset: 0x00019B40
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x0001B943 File Offset: 0x00019B43
		// (set) Token: 0x060021CA RID: 8650 RVA: 0x0001B946 File Offset: 0x00019B46
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

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x00024F70 File Offset: 0x00023170
		// (set) Token: 0x060021CC RID: 8652 RVA: 0x0001B948 File Offset: 0x00019B48
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

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x0001B94A File Offset: 0x00019B4A
		// (set) Token: 0x060021CE RID: 8654 RVA: 0x0001B951 File Offset: 0x00019B51
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

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x0001B953 File Offset: 0x00019B53
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x0001B956 File Offset: 0x00019B56
		public bool NetworkfaceCamera
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

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x00024F88 File Offset: 0x00023188
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x0001B958 File Offset: 0x00019B58
		public HorizontalAlignmentOptions NetworkhorizontalAlignment
		{
			get
			{
				return (HorizontalAlignmentOptions)0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x00024FA0 File Offset: 0x000231A0
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x0001B95A File Offset: 0x00019B5A
		public VerticalAlignmentOptions NetworkverticalAlignment
		{
			get
			{
				return (VerticalAlignmentOptions)0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x00024FB8 File Offset: 0x000231B8
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x0001B95C File Offset: 0x00019B5C
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

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x00024FD0 File Offset: 0x000231D0
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x0001B95E File Offset: 0x00019B5E
		public Vector3 NetworkrotationCache
		{
			get
			{
				return default(Vector3);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x00024FE8 File Offset: 0x000231E8
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x0001B960 File Offset: 0x00019B60
		public Vector3 NetworkpositionCache
		{
			get
			{
				return default(Vector3);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x0001B962 File Offset: 0x00019B62
		protected void UserCode_RpcSetText__String(string t)
		{
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x0001B964 File Offset: 0x00019B64
		protected static void InvokeUserCode_RpcSetText__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x0001B966 File Offset: 0x00019B66
		protected void UserCode_RpcSetColor__Color(Color color)
		{
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x0001B968 File Offset: 0x00019B68
		protected static void InvokeUserCode_RpcSetColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x0001B96A File Offset: 0x00019B6A
		protected void UserCode_RpcSetFontSize__Single(float fs)
		{
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x0001B96C File Offset: 0x00019B6C
		protected static void InvokeUserCode_RpcSetFontSize__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x0001B96E File Offset: 0x00019B6E
		protected void UserCode_RpcSetHorizontalAlignment__HorizontalAlignmentOptions(HorizontalAlignmentOptions al)
		{
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x0001B970 File Offset: 0x00019B70
		protected static void InvokeUserCode_RpcSetHorizontalAlignment__HorizontalAlignmentOptions(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x0001B972 File Offset: 0x00019B72
		protected void UserCode_RpcSetVerticalAlignment__VerticalAlignmentOptions(VerticalAlignmentOptions al)
		{
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x0001B974 File Offset: 0x00019B74
		protected static void InvokeUserCode_RpcSetVerticalAlignment__VerticalAlignmentOptions(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x0001B978 File Offset: 0x00019B78
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x0001B97A File Offset: 0x00019B7A
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000C10 RID: 3088
		private TMP_Text tmp;

		// Token: 0x04000C11 RID: 3089
		protected string text;

		// Token: 0x04000C12 RID: 3090
		protected Color color;

		// Token: 0x04000C13 RID: 3091
		protected float fontSize;

		// Token: 0x04000C14 RID: 3092
		protected bool faceCamera;

		// Token: 0x04000C15 RID: 3093
		protected HorizontalAlignmentOptions horizontalAlignment;

		// Token: 0x04000C16 RID: 3094
		protected VerticalAlignmentOptions verticalAlignment;

		// Token: 0x04000C17 RID: 3095
		private TextFontPreset font;

		// Token: 0x04000C18 RID: 3096
		private Vector3 rotationCache;

		// Token: 0x04000C19 RID: 3097
		private Vector3 positionCache;

		// Token: 0x04000C1A RID: 3098
		private ContentSizeFitter csf;

		// Token: 0x04000C1B RID: 3099
		public Action<TextFontPreset, TextFontPreset> _Mirror_SyncVarHookDelegate_font;
	}
}
