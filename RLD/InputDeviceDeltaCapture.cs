using System;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000138 RID: 312
	public class InputDeviceDeltaCapture
	{
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x000189B8 File Offset: 0x00016BB8
		public int Id
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x00020D54 File Offset: 0x0001EF54
		public Vector3 Origin
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x00020D6C File Offset: 0x0001EF6C
		public Vector3 Delta
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x000189BB File Offset: 0x00016BBB
		public InputDeviceDeltaCapture(int id, Vector3 origin)
		{
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x000189C3 File Offset: 0x00016BC3
		public void Update(Vector3 devicePosition)
		{
		}

		// Token: 0x04000582 RID: 1410
		private int _id;

		// Token: 0x04000583 RID: 1411
		private Vector3 _origin;

		// Token: 0x04000584 RID: 1412
		private Vector3 _delta;
	}
}
