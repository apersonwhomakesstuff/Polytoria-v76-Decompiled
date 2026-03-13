using System;

namespace RLD
{
	// Token: 0x0200005D RID: 93
	[Serializable]
	public class GizmoEngineSettings : Settings
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00016571 File Offset: 0x00014771
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00016574 File Offset: 0x00014774
		public bool EnableGizmoSorting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x04000143 RID: 323
		private bool _enableGizmoSorting;
	}
}
