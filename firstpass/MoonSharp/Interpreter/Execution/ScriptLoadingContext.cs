using System;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Tree;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000E5 RID: 229
	internal class ScriptLoadingContext
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0000E42E File Offset: 0x0000C62E
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x0000E436 File Offset: 0x0000C636
		public Script Script
		{
			get
			{
				return this.<Script>k__BackingField;
			}
			private set
			{
				this.<Script>k__BackingField = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0000E43F File Offset: 0x0000C63F
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x0000E447 File Offset: 0x0000C647
		public BuildTimeScope Scope
		{
			get
			{
				return this.<Scope>k__BackingField;
			}
			set
			{
				this.<Scope>k__BackingField = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x0000E450 File Offset: 0x0000C650
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x0000E458 File Offset: 0x0000C658
		public SourceCode Source
		{
			get
			{
				return this.<Source>k__BackingField;
			}
			set
			{
				this.<Source>k__BackingField = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x0000E461 File Offset: 0x0000C661
		// (set) Token: 0x06000A4D RID: 2637 RVA: 0x0000E469 File Offset: 0x0000C669
		public bool Anonymous
		{
			get
			{
				return this.<Anonymous>k__BackingField;
			}
			set
			{
				this.<Anonymous>k__BackingField = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0000E472 File Offset: 0x0000C672
		// (set) Token: 0x06000A4F RID: 2639 RVA: 0x0000E47A File Offset: 0x0000C67A
		public bool IsDynamicExpression
		{
			get
			{
				return this.<IsDynamicExpression>k__BackingField;
			}
			set
			{
				this.<IsDynamicExpression>k__BackingField = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0000E483 File Offset: 0x0000C683
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x0000E48B File Offset: 0x0000C68B
		public Lexer Lexer
		{
			get
			{
				return this.<Lexer>k__BackingField;
			}
			set
			{
				this.<Lexer>k__BackingField = value;
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0000E494 File Offset: 0x0000C694
		public ScriptLoadingContext(Script s)
		{
		}

		// Token: 0x040003CD RID: 973
		private Script <Script>k__BackingField;

		// Token: 0x040003CE RID: 974
		private BuildTimeScope <Scope>k__BackingField;

		// Token: 0x040003CF RID: 975
		private SourceCode <Source>k__BackingField;

		// Token: 0x040003D0 RID: 976
		private bool <Anonymous>k__BackingField;

		// Token: 0x040003D1 RID: 977
		private bool <IsDynamicExpression>k__BackingField;

		// Token: 0x040003D2 RID: 978
		private Lexer <Lexer>k__BackingField;
	}
}
