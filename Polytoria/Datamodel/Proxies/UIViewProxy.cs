using System;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000306 RID: 774
	public class UIViewProxy : UIFieldProxy
	{
		// Token: 0x06002721 RID: 10017 RVA: 0x0001C836 File Offset: 0x0001AA36
		public UIViewProxy(UIView target) : base(null)
		{
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x00025F90 File Offset: 0x00024190
		// (set) Token: 0x06002723 RID: 10019 RVA: 0x0001C83F File Offset: 0x0001AA3F
		public Color BorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x0001C841 File Offset: 0x0001AA41
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x0001C848 File Offset: 0x0001AA48
		public float BorderWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x00025FA8 File Offset: 0x000241A8
		// (set) Token: 0x06002727 RID: 10023 RVA: 0x0001C84A File Offset: 0x0001AA4A
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

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x0001C84C File Offset: 0x0001AA4C
		// (set) Token: 0x06002729 RID: 10025 RVA: 0x0001C853 File Offset: 0x0001AA53
		public float CornerRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x04000D32 RID: 3378
		private readonly UIView uiView;
	}
}
