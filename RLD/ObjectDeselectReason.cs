using System;

namespace RLD
{
	// Token: 0x02000225 RID: 549
	public enum ObjectDeselectReason
	{
		// Token: 0x040008A1 RID: 2209
		None,
		// Token: 0x040008A2 RID: 2210
		ClickSelectOther,
		// Token: 0x040008A3 RID: 2211
		CickAppendAlreadySelected,
		// Token: 0x040008A4 RID: 2212
		ClickAir,
		// Token: 0x040008A5 RID: 2213
		MultiDeselect,
		// Token: 0x040008A6 RID: 2214
		MultiSelectNotOverlapped,
		// Token: 0x040008A7 RID: 2215
		Undo,
		// Token: 0x040008A8 RID: 2216
		Redo,
		// Token: 0x040008A9 RID: 2217
		RemoveFromSelectionCall,
		// Token: 0x040008AA RID: 2218
		ClearSelectionCall,
		// Token: 0x040008AB RID: 2219
		SetSelectedCall,
		// Token: 0x040008AC RID: 2220
		Inactive,
		// Token: 0x040008AD RID: 2221
		WillBeDeleted
	}
}
