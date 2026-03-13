using System;

namespace RLD
{
	// Token: 0x02000224 RID: 548
	public enum ObjectSelectReason
	{
		// Token: 0x04000897 RID: 2199
		None,
		// Token: 0x04000898 RID: 2200
		Click,
		// Token: 0x04000899 RID: 2201
		ClickAppend,
		// Token: 0x0400089A RID: 2202
		MultiSelect,
		// Token: 0x0400089B RID: 2203
		MultiSelectAppend,
		// Token: 0x0400089C RID: 2204
		Undo,
		// Token: 0x0400089D RID: 2205
		Redo,
		// Token: 0x0400089E RID: 2206
		AppendToSelectionCall,
		// Token: 0x0400089F RID: 2207
		SetSelectedCall
	}
}
