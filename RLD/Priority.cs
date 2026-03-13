using System;

namespace RLD
{
	// Token: 0x02000115 RID: 277
	public class Priority
	{
		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x00018697 File Offset: 0x00016897
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x0001869A File Offset: 0x0001689A
		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x0001869C File Offset: 0x0001689C
		public static int Lowest
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x0001869F File Offset: 0x0001689F
		public static int Highest
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000186A2 File Offset: 0x000168A2
		public void MakeLowest()
		{
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x000186A4 File Offset: 0x000168A4
		public void MakeHighest()
		{
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x000186A6 File Offset: 0x000168A6
		public void MakeLowerThan(Priority priority)
		{
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x000186A8 File Offset: 0x000168A8
		public void MakeHigherThan(Priority priority)
		{
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x000186AA File Offset: 0x000168AA
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x000186AD File Offset: 0x000168AD
		public override bool Equals(object obj)
		{
			return false;
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x000186B0 File Offset: 0x000168B0
		public int CompareTo(Priority other)
		{
			return 0;
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x000186B3 File Offset: 0x000168B3
		public static bool operator ==(Priority firstPriority, Priority secondPriority)
		{
			return false;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x000186B6 File Offset: 0x000168B6
		public static bool operator !=(Priority firstPriority, Priority secondPriority)
		{
			return false;
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x000186B9 File Offset: 0x000168B9
		public static bool operator >(Priority firstPriority, Priority secondPriority)
		{
			return false;
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x000186BC File Offset: 0x000168BC
		public static bool operator >=(Priority firstPriority, Priority secondPriority)
		{
			return false;
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x000186BF File Offset: 0x000168BF
		public static bool operator <(Priority firstPriority, Priority secondPriority)
		{
			return false;
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x000186C2 File Offset: 0x000168C2
		public static bool operator <=(Priority firstPriority, Priority secondPriority)
		{
			return false;
		}

		// Token: 0x04000543 RID: 1347
		private int _priority;
	}
}
