using System;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree.Statements
{
	// Token: 0x0200006D RID: 109
	internal class GotoStatement : Statement
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x0000D406 File Offset: 0x0000B606
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x0000D40E File Offset: 0x0000B60E
		internal SourceRef SourceRef
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x0000D417 File Offset: 0x0000B617
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x0000D41F File Offset: 0x0000B61F
		internal Token GotoToken
		{
			get
			{
				return this.<GotoToken>k__BackingField;
			}
			private set
			{
				this.<GotoToken>k__BackingField = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0000D428 File Offset: 0x0000B628
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x0000D430 File Offset: 0x0000B630
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

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0000D439 File Offset: 0x0000B639
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x0000D441 File Offset: 0x0000B641
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

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x0000D44A File Offset: 0x0000B64A
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x0000D452 File Offset: 0x0000B652
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

		// Token: 0x06000673 RID: 1651 RVA: 0x0000D45B File Offset: 0x0000B65B
		public GotoStatement(ScriptLoadingContext lcontext) : base(null)
		{
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0000D464 File Offset: 0x0000B664
		public override void Compile(ByteCode bc)
		{
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0000D466 File Offset: 0x0000B666
		internal void SetDefinedVars(int definedVarsCount, string lastDefinedVarsName)
		{
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0000D468 File Offset: 0x0000B668
		internal void SetAddress(int labelAddress)
		{
		}

		// Token: 0x0400027E RID: 638
		private SourceRef <SourceRef>k__BackingField;

		// Token: 0x0400027F RID: 639
		private Token <GotoToken>k__BackingField;

		// Token: 0x04000280 RID: 640
		private string <Label>k__BackingField;

		// Token: 0x04000281 RID: 641
		private int <DefinedVarsCount>k__BackingField;

		// Token: 0x04000282 RID: 642
		private string <LastDefinedVarName>k__BackingField;

		// Token: 0x04000283 RID: 643
		private Instruction m_Jump;

		// Token: 0x04000284 RID: 644
		private int m_LabelAddress;
	}
}
