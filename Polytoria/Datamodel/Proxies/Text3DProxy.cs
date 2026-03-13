using System;
using TMPro;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002FB RID: 763
	public class Text3DProxy : DynamicInstanceProxy
	{
		// Token: 0x0600269A RID: 9882 RVA: 0x0001C6BB File Offset: 0x0001A8BB
		public Text3DProxy(Text3D target) : base(null)
		{
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x0001C6C4 File Offset: 0x0001A8C4
		// (set) Token: 0x0600269C RID: 9884 RVA: 0x0001C6C7 File Offset: 0x0001A8C7
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

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x00025D80 File Offset: 0x00023F80
		// (set) Token: 0x0600269E RID: 9886 RVA: 0x0001C6C9 File Offset: 0x0001A8C9
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

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x0600269F RID: 9887 RVA: 0x0001C6CB File Offset: 0x0001A8CB
		// (set) Token: 0x060026A0 RID: 9888 RVA: 0x0001C6D2 File Offset: 0x0001A8D2
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

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060026A1 RID: 9889 RVA: 0x0001C6D4 File Offset: 0x0001A8D4
		// (set) Token: 0x060026A2 RID: 9890 RVA: 0x0001C6D7 File Offset: 0x0001A8D7
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

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060026A3 RID: 9891 RVA: 0x00025D98 File Offset: 0x00023F98
		// (set) Token: 0x060026A4 RID: 9892 RVA: 0x0001C6D9 File Offset: 0x0001A8D9
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

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x00025DB0 File Offset: 0x00023FB0
		// (set) Token: 0x060026A6 RID: 9894 RVA: 0x0001C6DB File Offset: 0x0001A8DB
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

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060026A7 RID: 9895 RVA: 0x00025DC8 File Offset: 0x00023FC8
		// (set) Token: 0x060026A8 RID: 9896 RVA: 0x0001C6DD File Offset: 0x0001A8DD
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

		// Token: 0x04000D27 RID: 3367
		private readonly Text3D text3D;
	}
}
