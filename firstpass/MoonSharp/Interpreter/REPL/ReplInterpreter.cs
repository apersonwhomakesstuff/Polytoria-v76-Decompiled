using System;

namespace MoonSharp.Interpreter.REPL
{
	// Token: 0x02000086 RID: 134
	public class ReplInterpreter
	{
		// Token: 0x060006F9 RID: 1785 RVA: 0x0000D6B4 File Offset: 0x0000B8B4
		public ReplInterpreter(Script script)
		{
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x0000D6BC File Offset: 0x0000B8BC
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
		public bool HandleDynamicExprs
		{
			get
			{
				return this.<HandleDynamicExprs>k__BackingField;
			}
			set
			{
				this.<HandleDynamicExprs>k__BackingField = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x0000D6CD File Offset: 0x0000B8CD
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x0000D6D5 File Offset: 0x0000B8D5
		public bool HandleClassicExprsSyntax
		{
			get
			{
				return this.<HandleClassicExprsSyntax>k__BackingField;
			}
			set
			{
				this.<HandleClassicExprsSyntax>k__BackingField = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x0000D6DE File Offset: 0x0000B8DE
		public virtual bool HasPendingCommand
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x0000D6E1 File Offset: 0x0000B8E1
		public virtual string CurrentPendingCommand
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
		public virtual string ClassicPrompt
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0000D6E7 File Offset: 0x0000B8E7
		public virtual DynValue Evaluate(string input)
		{
			return null;
		}

		// Token: 0x040002CB RID: 715
		private Script m_Script;

		// Token: 0x040002CC RID: 716
		private string m_CurrentCommand;

		// Token: 0x040002CD RID: 717
		private bool <HandleDynamicExprs>k__BackingField;

		// Token: 0x040002CE RID: 718
		private bool <HandleClassicExprsSyntax>k__BackingField;
	}
}
