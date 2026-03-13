using System;

namespace RLD
{
	// Token: 0x02000227 RID: 551
	public class ObjectSelectEventArgs
	{
		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x00023B4C File Offset: 0x00021D4C
		public ObjectSelectReason SelectReason
		{
			get
			{
				return ObjectSelectReason.None;
			}
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00019FFE File Offset: 0x000181FE
		public ObjectSelectEventArgs(ObjectSelectReason selectReason)
		{
		}

		// Token: 0x040008B3 RID: 2227
		private ObjectSelectReason _selectReason;
	}
}
