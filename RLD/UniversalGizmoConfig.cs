using System;

namespace RLD
{
	// Token: 0x0200023E RID: 574
	[Serializable]
	public class UniversalGizmoConfig : Settings
	{
		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x00023BAC File Offset: 0x00021DAC
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x0001A1E5 File Offset: 0x000183E5
		public UniversalGizmoSettingsCategory InheritCategory
		{
			get
			{
				return UniversalGizmoSettingsCategory.Move;
			}
			set
			{
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x00023BC4 File Offset: 0x00021DC4
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x0001A1E7 File Offset: 0x000183E7
		public UniversalGizmoSettingsType InheritType
		{
			get
			{
				return UniversalGizmoSettingsType.Settings2D;
			}
			set
			{
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x00023BDC File Offset: 0x00021DDC
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x0001A1E9 File Offset: 0x000183E9
		public UniversalGizmoSettingsCategory DisplayCategory
		{
			get
			{
				return UniversalGizmoSettingsCategory.Move;
			}
			set
			{
			}
		}

		// Token: 0x04000913 RID: 2323
		private UniversalGizmoSettingsCategory _inheritCategory;

		// Token: 0x04000914 RID: 2324
		private UniversalGizmoSettingsType _inheritType;

		// Token: 0x04000915 RID: 2325
		private UniversalGizmoSettingsCategory _displayCategory;
	}
}
