using System;

namespace RLD
{
	// Token: 0x02000228 RID: 552
	public class ObjectDeselectEventArgs
	{
		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x00023B64 File Offset: 0x00021D64
		public ObjectDeselectReason DeselectReason
		{
			get
			{
				return ObjectDeselectReason.None;
			}
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0001A006 File Offset: 0x00018206
		public ObjectDeselectEventArgs(ObjectDeselectReason deselectReason)
		{
		}

		// Token: 0x040008B4 RID: 2228
		private ObjectDeselectReason _deselectReason;
	}
}
