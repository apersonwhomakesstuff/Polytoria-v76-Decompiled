using System;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x020000FE RID: 254
	public class SourceRef
	{
		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0000E8C6 File Offset: 0x0000CAC6
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x0000E8CE File Offset: 0x0000CACE
		public bool IsClrLocation
		{
			get
			{
				return this.<IsClrLocation>k__BackingField;
			}
			private set
			{
				this.<IsClrLocation>k__BackingField = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0000E8D7 File Offset: 0x0000CAD7
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x0000E8DF File Offset: 0x0000CADF
		public int SourceIdx
		{
			get
			{
				return this.<SourceIdx>k__BackingField;
			}
			private set
			{
				this.<SourceIdx>k__BackingField = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0000E8E8 File Offset: 0x0000CAE8
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x0000E8F0 File Offset: 0x0000CAF0
		public int FromChar
		{
			get
			{
				return this.<FromChar>k__BackingField;
			}
			private set
			{
				this.<FromChar>k__BackingField = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0000E8F9 File Offset: 0x0000CAF9
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x0000E901 File Offset: 0x0000CB01
		public int ToChar
		{
			get
			{
				return this.<ToChar>k__BackingField;
			}
			private set
			{
				this.<ToChar>k__BackingField = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0000E90A File Offset: 0x0000CB0A
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x0000E912 File Offset: 0x0000CB12
		public int FromLine
		{
			get
			{
				return this.<FromLine>k__BackingField;
			}
			private set
			{
				this.<FromLine>k__BackingField = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0000E91B File Offset: 0x0000CB1B
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x0000E923 File Offset: 0x0000CB23
		public int ToLine
		{
			get
			{
				return this.<ToLine>k__BackingField;
			}
			private set
			{
				this.<ToLine>k__BackingField = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0000E92C File Offset: 0x0000CB2C
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x0000E934 File Offset: 0x0000CB34
		public bool IsStepStop
		{
			get
			{
				return this.<IsStepStop>k__BackingField;
			}
			private set
			{
				this.<IsStepStop>k__BackingField = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x0000E93D File Offset: 0x0000CB3D
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x0000E945 File Offset: 0x0000CB45
		public bool CannotBreakpoint
		{
			get
			{
				return this.<CannotBreakpoint>k__BackingField;
			}
			private set
			{
				this.<CannotBreakpoint>k__BackingField = value;
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0000E94E File Offset: 0x0000CB4E
		internal static SourceRef GetClrLocation()
		{
			return null;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0000E951 File Offset: 0x0000CB51
		public SourceRef(SourceRef src, bool isStepStop)
		{
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0000E959 File Offset: 0x0000CB59
		public SourceRef(int sourceIdx, int from, int to, int fromline, int toline, bool isStepStop)
		{
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0000E961 File Offset: 0x0000CB61
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0000E964 File Offset: 0x0000CB64
		internal int GetLocationDistance(int sourceIdx, int line, int col)
		{
			return 0;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0000E967 File Offset: 0x0000CB67
		public bool IncludesLocation(int sourceIdx, int line, int col)
		{
			return false;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0000E96A File Offset: 0x0000CB6A
		public SourceRef SetNoBreakPoint()
		{
			return null;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0000E96D File Offset: 0x0000CB6D
		public string FormatLocation(Script script, bool forceClassicFormat = false)
		{
			return null;
		}

		// Token: 0x0400047D RID: 1149
		private bool <IsClrLocation>k__BackingField;

		// Token: 0x0400047E RID: 1150
		private int <SourceIdx>k__BackingField;

		// Token: 0x0400047F RID: 1151
		private int <FromChar>k__BackingField;

		// Token: 0x04000480 RID: 1152
		private int <ToChar>k__BackingField;

		// Token: 0x04000481 RID: 1153
		private int <FromLine>k__BackingField;

		// Token: 0x04000482 RID: 1154
		private int <ToLine>k__BackingField;

		// Token: 0x04000483 RID: 1155
		private bool <IsStepStop>k__BackingField;

		// Token: 0x04000484 RID: 1156
		public bool Breakpoint;

		// Token: 0x04000485 RID: 1157
		private bool <CannotBreakpoint>k__BackingField;
	}
}
