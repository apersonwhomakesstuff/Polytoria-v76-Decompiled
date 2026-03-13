using System;

namespace RLD
{
	// Token: 0x02000222 RID: 546
	[Serializable]
	public class ObjectSelectionRotationSettings : Settings
	{
		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x00023AEC File Offset: 0x00021CEC
		// (set) Token: 0x06001840 RID: 6208 RVA: 0x00019F8B File Offset: 0x0001818B
		public ObjectRotationPivot RotationPivot
		{
			get
			{
				return ObjectRotationPivot.IndividualPivot;
			}
			set
			{
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x00019F8D File Offset: 0x0001818D
		public ObjectKeyRotationSettings KeyRotationSettings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000889 RID: 2185
		private ObjectRotationPivot _rotationPivot;

		// Token: 0x0400088A RID: 2186
		private ObjectKeyRotationSettings _keyRotationSettings;
	}
}
