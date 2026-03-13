using System;
using System.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000117 RID: 279
	public class Vec3Samples
	{
		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x000186CD File Offset: 0x000168CD
		public int NumSamples
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000186D0 File Offset: 0x000168D0
		public int MaxNumSamples
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x000186D3 File Offset: 0x000168D3
		public void AddSample(Vector3 sample)
		{
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000186D5 File Offset: 0x000168D5
		public void SetMaxNumSamples(int maxNumSamples)
		{
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000207B4 File Offset: 0x0001E9B4
		public Vector3 GetAverage()
		{
			return default(Vector3);
		}

		// Token: 0x04000548 RID: 1352
		private int _maxNumSamples;

		// Token: 0x04000549 RID: 1353
		private List<Vector3> _samples;
	}
}
