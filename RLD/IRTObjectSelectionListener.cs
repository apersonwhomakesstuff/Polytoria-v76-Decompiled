using System;

namespace RLD
{
	// Token: 0x02000214 RID: 532
	public interface IRTObjectSelectionListener
	{
		// Token: 0x060017EA RID: 6122
		bool OnCanBeSelected(ObjectSelectEventArgs selectArgs);

		// Token: 0x060017EB RID: 6123
		void OnSelected(ObjectSelectEventArgs selectArgs);

		// Token: 0x060017EC RID: 6124
		void OnDeselected(ObjectDeselectEventArgs deselectArgs);
	}
}
