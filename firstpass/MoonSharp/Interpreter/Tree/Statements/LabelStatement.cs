using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x0200006F RID: 111
	internal class LabelStatement : Statement
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x0000D47B File Offset: 0x0000B67B
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x0000D483 File Offset: 0x0000B683
		public string Label
		{
			get
			{
				return this.<Label>k__BackingField;
			}
			private set
			{
				this.<Label>k__BackingField = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x0000D48C File Offset: 0x0000B68C
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x0000D494 File Offset: 0x0000B694
		public int Address
		{
			get
			{
				return this.<Address>k__BackingField;
			}
			private set
			{
				this.<Address>k__BackingField = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0000D49D File Offset: 0x0000B69D
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x0000D4A5 File Offset: 0x0000B6A5
		public SourceRef SourceRef
		{
			get
			{
				return this.<SourceRef>k__BackingField;
			}
			private set
			{
				this.<SourceRef>k__BackingField = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0000D4AE File Offset: 0x0000B6AE
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x0000D4B6 File Offset: 0x0000B6B6
		public Token NameToken
		{
			get
			{
				return this.<NameToken>k__BackingField;
			}
			private set
			{
				this.<NameToken>k__BackingField = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0000D4BF File Offset: 0x0000B6BF
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x0000D4C7 File Offset: 0x0000B6C7
		internal int DefinedVarsCount
		{
			get
			{
				return this.<DefinedVarsCount>k__BackingField;
			}
			private set
			{
				this.<DefinedVarsCount>k__BackingField = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x0000D4D8 File Offset: 0x0000B6D8
		internal string LastDefinedVarName
		{
			get
			{
				return this.<LastDefinedVarName>k__BackingField;
			}
			private set
			{
				this.<LastDefinedVarName>k__BackingField = value;
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0000D4E1 File Offset: 0x0000B6E1
		public LabelStatement(ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0000D4EA File Offset: 0x0000B6EA
		internal void SetDefinedVars(int definedVarsCount, string lastDefinedVarsName)
		{
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0000D4EC File Offset: 0x0000B6EC
		internal void RegisterGoto(GotoStatement gotostat)
		{
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0000D4EE File Offset: 0x0000B6EE
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
		internal void SetScope(RuntimeScopeBlock runtimeScopeBlock)
		{
		}

		// Token: 0x04000288 RID: 648
		private string <Label>k__BackingField;

		// Token: 0x04000289 RID: 649
		private int <Address>k__BackingField;

		// Token: 0x0400028A RID: 650
		private SourceRef <SourceRef>k__BackingField;

		// Token: 0x0400028B RID: 651
		private Token <NameToken>k__BackingField;

		// Token: 0x0400028C RID: 652
		private int <DefinedVarsCount>k__BackingField;

		// Token: 0x0400028D RID: 653
		private string <LastDefinedVarName>k__BackingField;

		// Token: 0x0400028E RID: 654
		private List<GotoStatement> m_Gotos;

		// Token: 0x0400028F RID: 655
		private RuntimeScopeBlock m_StackFrame;
	}
}
