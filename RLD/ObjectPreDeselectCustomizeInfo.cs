using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000217 RID: 535
	public class ObjectPreDeselectCustomizeInfo
	{
		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x00023A44 File Offset: 0x00021C44
		public ObjectDeselectReason DeselectReason
		{
			get
			{
				return ObjectDeselectReason.None;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x00019EB2 File Offset: 0x000180B2
		public int ToBeDeselectedCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x00019EB5 File Offset: 0x000180B5
		public List<GameObject> ToBeDeselected
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x00019EB8 File Offset: 0x000180B8
		public ObjectPreDeselectCustomizeInfo(List<GameObject> toBeDeselected, ObjectDeselectReason deselectReason)
		{
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00019EC0 File Offset: 0x000180C0
		public void DeselectThese(IEnumerable<GameObject> toBeDeselected)
		{
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00019EC2 File Offset: 0x000180C2
		public void IgnoreThese(IEnumerable<GameObject> toBeIgnored)
		{
		}

		// Token: 0x0400085F RID: 2143
		private List<GameObject> _toBeDeselected;

		// Token: 0x04000860 RID: 2144
		private ObjectDeselectReason _deselectReason;
	}
}
