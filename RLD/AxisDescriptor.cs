using System;

namespace RLD
{
	// Token: 0x02000141 RID: 321
	public class AxisDescriptor
	{
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x00021034 File Offset: 0x0001F234
		public AxisSign Sign
		{
			get
			{
				return AxisSign.Positive;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x00018A34 File Offset: 0x00016C34
		public int Index
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x00018A37 File Offset: 0x00016C37
		public bool IsPositive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x00018A3A File Offset: 0x00016C3A
		public bool IsNegative
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00018A3D File Offset: 0x00016C3D
		public AxisDescriptor(int axisIndex, AxisSign axisSign)
		{
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00018A45 File Offset: 0x00016C45
		public AxisDescriptor(int axisIndex, bool isNegative)
		{
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0002104C File Offset: 0x0001F24C
		public BoxFace GetAssociatedBoxFace()
		{
			return BoxFace.Front;
		}

		// Token: 0x04000599 RID: 1433
		private AxisSign _sign;

		// Token: 0x0400059A RID: 1434
		private int _index;
	}
}
