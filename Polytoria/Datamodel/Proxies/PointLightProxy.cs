using System;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002EF RID: 751
	public class PointLightProxy : DynamicInstanceProxy
	{
		// Token: 0x06002640 RID: 9792 RVA: 0x0001C566 File Offset: 0x0001A766
		public PointLightProxy(PointLight target) : base(null)
		{
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06002641 RID: 9793 RVA: 0x0001C56F File Offset: 0x0001A76F
		// (set) Token: 0x06002642 RID: 9794 RVA: 0x0001C576 File Offset: 0x0001A776
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

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x0001C578 File Offset: 0x0001A778
		// (set) Token: 0x06002644 RID: 9796 RVA: 0x0001C57F File Offset: 0x0001A77F
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

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06002645 RID: 9797 RVA: 0x00025CD8 File Offset: 0x00023ED8
		// (set) Token: 0x06002646 RID: 9798 RVA: 0x0001C581 File Offset: 0x0001A781
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

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002647 RID: 9799 RVA: 0x0001C583 File Offset: 0x0001A783
		// (set) Token: 0x06002648 RID: 9800 RVA: 0x0001C586 File Offset: 0x0001A786
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

		// Token: 0x04000D1B RID: 3355
		private readonly PointLight pointLight;
	}
}
