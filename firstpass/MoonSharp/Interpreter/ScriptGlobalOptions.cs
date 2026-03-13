using System;
using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Platforms;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000058 RID: 88
	public class ScriptGlobalOptions
	{
		// Token: 0x060005E4 RID: 1508 RVA: 0x0000D12F File Offset: 0x0000B32F
		internal ScriptGlobalOptions()
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0000D137 File Offset: 0x0000B337
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x0000D13F File Offset: 0x0000B33F
		public CustomConvertersCollection CustomConverters
		{
			get
			{
				return this.<CustomConverters>k__BackingField;
			}
			set
			{
				this.<CustomConverters>k__BackingField = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0000D148 File Offset: 0x0000B348
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x0000D150 File Offset: 0x0000B350
		public IPlatformAccessor Platform
		{
			get
			{
				return this.<Platform>k__BackingField;
			}
			set
			{
				this.<Platform>k__BackingField = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0000D159 File Offset: 0x0000B359
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x0000D161 File Offset: 0x0000B361
		public bool RethrowExceptionNested
		{
			get
			{
				return this.<RethrowExceptionNested>k__BackingField;
			}
			set
			{
				this.<RethrowExceptionNested>k__BackingField = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0000D16A File Offset: 0x0000B36A
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x0000D172 File Offset: 0x0000B372
		public FuzzySymbolMatchingBehavior FuzzySymbolMatching
		{
			get
			{
				return this.<FuzzySymbolMatching>k__BackingField;
			}
			set
			{
				this.<FuzzySymbolMatching>k__BackingField = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0000D17B File Offset: 0x0000B37B
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x0000D183 File Offset: 0x0000B383
		public Func<Exception, bool> ShouldPCallCatchException
		{
			get
			{
				return this.<ShouldPCallCatchException>k__BackingField;
			}
			set
			{
				this.<ShouldPCallCatchException>k__BackingField = value;
			}
		}

		// Token: 0x040001F8 RID: 504
		private CustomConvertersCollection <CustomConverters>k__BackingField;

		// Token: 0x040001F9 RID: 505
		private IPlatformAccessor <Platform>k__BackingField;

		// Token: 0x040001FA RID: 506
		private bool <RethrowExceptionNested>k__BackingField;

		// Token: 0x040001FB RID: 507
		private FuzzySymbolMatchingBehavior <FuzzySymbolMatching>k__BackingField;

		// Token: 0x040001FC RID: 508
		private Func<Exception, bool> <ShouldPCallCatchException>k__BackingField;

		// Token: 0x0200018B RID: 395
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000F38 RID: 3896 RVA: 0x0000F401 File Offset: 0x0000D601
			internal bool <.ctor>b__0_0(Exception _)
			{
				return false;
			}

			// Token: 0x04000662 RID: 1634
			public static readonly ScriptGlobalOptions.<>c <>9;

			// Token: 0x04000663 RID: 1635
			public static Func<Exception, bool> <>9__0_0;
		}
	}
}
