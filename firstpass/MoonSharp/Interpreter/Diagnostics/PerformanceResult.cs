using System;

namespace MoonSharp.Interpreter.Diagnostics
{
	// Token: 0x020000F2 RID: 242
	public class PerformanceResult
	{
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0000E715 File Offset: 0x0000C915
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x0000E71D File Offset: 0x0000C91D
		public string Name
		{
			get
			{
				return this.<Name>k__BackingField;
			}
			internal set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x0000E726 File Offset: 0x0000C926
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x0000E72E File Offset: 0x0000C92E
		public long Counter
		{
			get
			{
				return this.<Counter>k__BackingField;
			}
			internal set
			{
				this.<Counter>k__BackingField = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x0000E737 File Offset: 0x0000C937
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x0000E73F File Offset: 0x0000C93F
		public int Instances
		{
			get
			{
				return this.<Instances>k__BackingField;
			}
			internal set
			{
				this.<Instances>k__BackingField = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0000E748 File Offset: 0x0000C948
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x0000E750 File Offset: 0x0000C950
		public bool Global
		{
			get
			{
				return this.<Global>k__BackingField;
			}
			internal set
			{
				this.<Global>k__BackingField = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0000E759 File Offset: 0x0000C959
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x0000E761 File Offset: 0x0000C961
		public PerformanceCounterType Type
		{
			get
			{
				return this.<Type>k__BackingField;
			}
			internal set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0000E76A File Offset: 0x0000C96A
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0000E76D File Offset: 0x0000C96D
		public static string PerformanceCounterTypeToString(PerformanceCounterType Type)
		{
			return null;
		}

		// Token: 0x0400045A RID: 1114
		private string <Name>k__BackingField;

		// Token: 0x0400045B RID: 1115
		private long <Counter>k__BackingField;

		// Token: 0x0400045C RID: 1116
		private int <Instances>k__BackingField;

		// Token: 0x0400045D RID: 1117
		private bool <Global>k__BackingField;

		// Token: 0x0400045E RID: 1118
		private PerformanceCounterType <Type>k__BackingField;
	}
}
