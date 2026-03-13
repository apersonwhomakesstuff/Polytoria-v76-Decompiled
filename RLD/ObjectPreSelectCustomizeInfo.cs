using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000218 RID: 536
	public class ObjectPreSelectCustomizeInfo
	{
		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00023A5C File Offset: 0x00021C5C
		public ObjectSelectReason SelectReason
		{
			get
			{
				return ObjectSelectReason.None;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x00019EC4 File Offset: 0x000180C4
		public int ToBeSelectedCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00019EC7 File Offset: 0x000180C7
		public List<GameObject> ToBeSelected
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00019ECA File Offset: 0x000180CA
		public ObjectPreSelectCustomizeInfo(List<GameObject> toBeSelected, ObjectSelectReason selectReason)
		{
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00019ED2 File Offset: 0x000180D2
		public void SelectThese(IEnumerable<GameObject> toBeSelected)
		{
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00019ED4 File Offset: 0x000180D4
		public void IgnoreThese(IEnumerable<GameObject> toBeIgnored)
		{
		}

		// Token: 0x04000861 RID: 2145
		private List<GameObject> _toBeSelected;

		// Token: 0x04000862 RID: 2146
		private ObjectSelectReason _selectRason;
	}
}
