using System;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x020000F9 RID: 249
	public class DebuggerAction
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0000E7C5 File Offset: 0x0000C9C5
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x0000E7CD File Offset: 0x0000C9CD
		public DebuggerAction.ActionType Action
		{
			get
			{
				return this.<Action>k__BackingField;
			}
			set
			{
				this.<Action>k__BackingField = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0000E7D6 File Offset: 0x0000C9D6
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x0000E7DE File Offset: 0x0000C9DE
		public DateTime TimeStampUTC
		{
			get
			{
				return this.<TimeStampUTC>k__BackingField;
			}
			private set
			{
				this.<TimeStampUTC>k__BackingField = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x0000E7E7 File Offset: 0x0000C9E7
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x0000E7EF File Offset: 0x0000C9EF
		public int SourceID
		{
			get
			{
				return this.<SourceID>k__BackingField;
			}
			set
			{
				this.<SourceID>k__BackingField = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0000E7F8 File Offset: 0x0000C9F8
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x0000E800 File Offset: 0x0000CA00
		public int SourceLine
		{
			get
			{
				return this.<SourceLine>k__BackingField;
			}
			set
			{
				this.<SourceLine>k__BackingField = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0000E809 File Offset: 0x0000CA09
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x0000E811 File Offset: 0x0000CA11
		public int SourceCol
		{
			get
			{
				return this.<SourceCol>k__BackingField;
			}
			set
			{
				this.<SourceCol>k__BackingField = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x0000E81A File Offset: 0x0000CA1A
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x0000E822 File Offset: 0x0000CA22
		public int[] Lines
		{
			get
			{
				return this.<Lines>k__BackingField;
			}
			set
			{
				this.<Lines>k__BackingField = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x000104F0 File Offset: 0x0000E6F0
		public TimeSpan Age
		{
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0000E833 File Offset: 0x0000CA33
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400046B RID: 1131
		private DebuggerAction.ActionType <Action>k__BackingField;

		// Token: 0x0400046C RID: 1132
		private DateTime <TimeStampUTC>k__BackingField;

		// Token: 0x0400046D RID: 1133
		private int <SourceID>k__BackingField;

		// Token: 0x0400046E RID: 1134
		private int <SourceLine>k__BackingField;

		// Token: 0x0400046F RID: 1135
		private int <SourceCol>k__BackingField;

		// Token: 0x04000470 RID: 1136
		private int[] <Lines>k__BackingField;

		// Token: 0x020001CC RID: 460
		public enum ActionType
		{
			// Token: 0x04000712 RID: 1810
			ByteCodeStepIn,
			// Token: 0x04000713 RID: 1811
			ByteCodeStepOver,
			// Token: 0x04000714 RID: 1812
			ByteCodeStepOut,
			// Token: 0x04000715 RID: 1813
			StepIn,
			// Token: 0x04000716 RID: 1814
			StepOver,
			// Token: 0x04000717 RID: 1815
			StepOut,
			// Token: 0x04000718 RID: 1816
			Run,
			// Token: 0x04000719 RID: 1817
			ToggleBreakpoint,
			// Token: 0x0400071A RID: 1818
			SetBreakpoint,
			// Token: 0x0400071B RID: 1819
			ClearBreakpoint,
			// Token: 0x0400071C RID: 1820
			ResetBreakpoints,
			// Token: 0x0400071D RID: 1821
			Refresh,
			// Token: 0x0400071E RID: 1822
			HardRefresh,
			// Token: 0x0400071F RID: 1823
			None
		}
	}
}
