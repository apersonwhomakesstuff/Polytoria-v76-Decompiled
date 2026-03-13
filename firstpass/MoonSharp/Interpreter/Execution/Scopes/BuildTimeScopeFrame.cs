using System;
using MoonSharp.Interpreter.Tree.Statements;

namespace MoonSharp.Interpreter.Execution.Scopes
{
	// Token: 0x020000EF RID: 239
	internal class BuildTimeScopeFrame
	{
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0000E6DF File Offset: 0x0000C8DF
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x0000E6E7 File Offset: 0x0000C8E7
		public bool HasVarArgs
		{
			get
			{
				return this.<HasVarArgs>k__BackingField;
			}
			private set
			{
				this.<HasVarArgs>k__BackingField = value;
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0000E6F0 File Offset: 0x0000C8F0
		internal BuildTimeScopeFrame(bool hasVarArgs)
		{
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0000E6F8 File Offset: 0x0000C8F8
		internal void PushBlock()
		{
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0000E6FA File Offset: 0x0000C8FA
		internal RuntimeScopeBlock PopBlock()
		{
			return null;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0000E6FD File Offset: 0x0000C8FD
		internal RuntimeScopeFrame GetRuntimeFrameData()
		{
			return null;
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0000E700 File Offset: 0x0000C900
		internal SymbolRef Find(string name)
		{
			return null;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0000E703 File Offset: 0x0000C903
		internal SymbolRef DefineLocal(string name)
		{
			return null;
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0000E706 File Offset: 0x0000C906
		internal SymbolRef TryDefineLocal(string name)
		{
			return null;
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0000E709 File Offset: 0x0000C909
		internal void ResolveLRefs()
		{
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0000E70B File Offset: 0x0000C90B
		internal int AllocVar(SymbolRef var)
		{
			return 0;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0000E70E File Offset: 0x0000C90E
		internal int GetPosForNextVar()
		{
			return 0;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0000E711 File Offset: 0x0000C911
		internal void DefineLabel(LabelStatement label)
		{
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0000E713 File Offset: 0x0000C913
		internal void RegisterGoto(GotoStatement gotostat)
		{
		}

		// Token: 0x0400044D RID: 1101
		private BuildTimeScopeBlock m_ScopeTreeRoot;

		// Token: 0x0400044E RID: 1102
		private BuildTimeScopeBlock m_ScopeTreeHead;

		// Token: 0x0400044F RID: 1103
		private RuntimeScopeFrame m_ScopeFrame;

		// Token: 0x04000450 RID: 1104
		private bool <HasVarArgs>k__BackingField;
	}
}
