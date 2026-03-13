using System;

namespace SimpleJSON
{
	// Token: 0x0200001A RID: 26
	public enum JSONNodeType
	{
		// Token: 0x04000131 RID: 305
		Array = 1,
		// Token: 0x04000132 RID: 306
		Object,
		// Token: 0x04000133 RID: 307
		String,
		// Token: 0x04000134 RID: 308
		Number,
		// Token: 0x04000135 RID: 309
		NullValue,
		// Token: 0x04000136 RID: 310
		Boolean,
		// Token: 0x04000137 RID: 311
		None,
		// Token: 0x04000138 RID: 312
		Custom = 255
	}
}
