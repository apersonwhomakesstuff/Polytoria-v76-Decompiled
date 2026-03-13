using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000176 RID: 374
	public class QuaternionRef
	{
		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x00021704 File Offset: 0x0001F904
		// (set) Token: 0x06001162 RID: 4450 RVA: 0x00018DF8 File Offset: 0x00016FF8
		public Quaternion Value
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00018DFA File Offset: 0x00016FFA
		public QuaternionRef()
		{
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00018E02 File Offset: 0x00017002
		public QuaternionRef(Quaternion quat)
		{
		}

		// Token: 0x04000625 RID: 1573
		private Quaternion _value;
	}
}
