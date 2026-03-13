using System;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002FF RID: 767
	public class UIFieldProxy : InstanceProxy
	{
		// Token: 0x060026B5 RID: 9909 RVA: 0x0001C712 File Offset: 0x0001A912
		public UIFieldProxy(UIField target) : base(null)
		{
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060026B6 RID: 9910 RVA: 0x0001C71B File Offset: 0x0001A91B
		public LuaEvent MouseUp
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x0001C71E File Offset: 0x0001A91E
		public LuaEvent MouseDown
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x060026B8 RID: 9912 RVA: 0x00025DE0 File Offset: 0x00023FE0
		// (set) Token: 0x060026B9 RID: 9913 RVA: 0x0001C721 File Offset: 0x0001A921
		public Vector2 PositionOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x060026BA RID: 9914 RVA: 0x00025DF8 File Offset: 0x00023FF8
		// (set) Token: 0x060026BB RID: 9915 RVA: 0x0001C723 File Offset: 0x0001A923
		public Vector2 PositionRelative
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x0001C725 File Offset: 0x0001A925
		// (set) Token: 0x060026BD RID: 9917 RVA: 0x0001C72C File Offset: 0x0001A92C
		public float Rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x060026BE RID: 9918 RVA: 0x00025E10 File Offset: 0x00024010
		// (set) Token: 0x060026BF RID: 9919 RVA: 0x0001C72E File Offset: 0x0001A92E
		public Vector2 SizeOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x00025E28 File Offset: 0x00024028
		// (set) Token: 0x060026C1 RID: 9921 RVA: 0x0001C730 File Offset: 0x0001A930
		public Vector2 SizeRelative
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x060026C2 RID: 9922 RVA: 0x00025E40 File Offset: 0x00024040
		// (set) Token: 0x060026C3 RID: 9923 RVA: 0x0001C732 File Offset: 0x0001A932
		public Vector2 PivotPoint
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x0001C734 File Offset: 0x0001A934
		// (set) Token: 0x060026C5 RID: 9925 RVA: 0x0001C737 File Offset: 0x0001A937
		public bool Visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x0001C739 File Offset: 0x0001A939
		// (set) Token: 0x060026C7 RID: 9927 RVA: 0x0001C73C File Offset: 0x0001A93C
		public bool ClipDescendants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x04000D2B RID: 3371
		private readonly UIField uiField;
	}
}
