using System;

namespace RLD
{
	// Token: 0x020001C7 RID: 455
	[Serializable]
	public class Object2ObjectSnapSettings : Settings
	{
		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x000194CD File Offset: 0x000176CD
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x000194D0 File Offset: 0x000176D0
		public int SnapDestinationLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x000194D2 File Offset: 0x000176D2
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x000194D5 File Offset: 0x000176D5
		public bool CanClimbObjects
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x000194D7 File Offset: 0x000176D7
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x000194DE File Offset: 0x000176DE
		public float SnapRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x0400072E RID: 1838
		private int _snapDestinationLayers;

		// Token: 0x0400072F RID: 1839
		private bool _canClimbObjects;

		// Token: 0x04000730 RID: 1840
		private float _snapRadius;
	}
}
