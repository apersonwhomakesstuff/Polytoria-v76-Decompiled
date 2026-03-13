using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Tree.Statements;

namespace MoonSharp.Interpreter.Execution.Scopes
{
	// Token: 0x020000EE RID: 238
	internal class BuildTimeScopeBlock
	{
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x0000E690 File Offset: 0x0000C890
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x0000E698 File Offset: 0x0000C898
		internal BuildTimeScopeBlock Parent
		{
			get
			{
				return this.<Parent>k__BackingField;
			}
			private set
			{
				this.<Parent>k__BackingField = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x0000E6A1 File Offset: 0x0000C8A1
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x0000E6A9 File Offset: 0x0000C8A9
		internal List<BuildTimeScopeBlock> ChildNodes
		{
			get
			{
				return this.<ChildNodes>k__BackingField;
			}
			private set
			{
				this.<ChildNodes>k__BackingField = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x0000E6B2 File Offset: 0x0000C8B2
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x0000E6BA File Offset: 0x0000C8BA
		internal RuntimeScopeBlock ScopeBlock
		{
			get
			{
				return this.<ScopeBlock>k__BackingField;
			}
			private set
			{
				this.<ScopeBlock>k__BackingField = value;
			}
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0000E6C3 File Offset: 0x0000C8C3
		internal void Rename(string name)
		{
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0000E6C5 File Offset: 0x0000C8C5
		internal BuildTimeScopeBlock(BuildTimeScopeBlock parent)
		{
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0000E6CD File Offset: 0x0000C8CD
		internal BuildTimeScopeBlock AddChild()
		{
			return null;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
		internal SymbolRef Find(string name)
		{
			return null;
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0000E6D3 File Offset: 0x0000C8D3
		internal SymbolRef Define(string name)
		{
			return null;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0000E6D6 File Offset: 0x0000C8D6
		internal int ResolveLRefs(BuildTimeScopeFrame buildTimeScopeFrame)
		{
			return 0;
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0000E6D9 File Offset: 0x0000C8D9
		internal void DefineLabel(LabelStatement label)
		{
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0000E6DB File Offset: 0x0000C8DB
		internal void RegisterGoto(GotoStatement gotostat)
		{
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0000E6DD File Offset: 0x0000C8DD
		internal void ResolveGotos()
		{
		}

		// Token: 0x04000446 RID: 1094
		private BuildTimeScopeBlock <Parent>k__BackingField;

		// Token: 0x04000447 RID: 1095
		private List<BuildTimeScopeBlock> <ChildNodes>k__BackingField;

		// Token: 0x04000448 RID: 1096
		private RuntimeScopeBlock <ScopeBlock>k__BackingField;

		// Token: 0x04000449 RID: 1097
		private Dictionary<string, SymbolRef> m_DefinedNames;

		// Token: 0x0400044A RID: 1098
		private List<GotoStatement> m_PendingGotos;

		// Token: 0x0400044B RID: 1099
		private Dictionary<string, LabelStatement> m_LocalLabels;

		// Token: 0x0400044C RID: 1100
		private string m_LastDefinedName;
	}
}
