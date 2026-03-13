using System;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F8 RID: 760
	public class SpotlightProxy : DynamicInstanceProxy
	{
		// Token: 0x06002685 RID: 9861 RVA: 0x0001C669 File Offset: 0x0001A869
		public SpotlightProxy(Spotlight target) : base(null)
		{
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x0001C672 File Offset: 0x0001A872
		// (set) Token: 0x06002687 RID: 9863 RVA: 0x0001C679 File Offset: 0x0001A879
		public float Range
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x0001C67B File Offset: 0x0001A87B
		// (set) Token: 0x06002689 RID: 9865 RVA: 0x0001C682 File Offset: 0x0001A882
		public float Angle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x0001C684 File Offset: 0x0001A884
		// (set) Token: 0x0600268B RID: 9867 RVA: 0x0001C68B File Offset: 0x0001A88B
		public float Brightness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x00025D50 File Offset: 0x00023F50
		// (set) Token: 0x0600268D RID: 9869 RVA: 0x0001C68D File Offset: 0x0001A88D
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

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x0600268E RID: 9870 RVA: 0x0001C68F File Offset: 0x0001A88F
		// (set) Token: 0x0600268F RID: 9871 RVA: 0x0001C692 File Offset: 0x0001A892
		public bool Shadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x04000D24 RID: 3364
		private readonly Spotlight spotlight;
	}
}
