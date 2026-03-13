using System;

namespace MoonSharp.Interpreter.REPL
{
	// Token: 0x02000085 RID: 133
	public class ReplHistoryInterpreter : ReplInterpreter
	{
		// Token: 0x060006F5 RID: 1781 RVA: 0x0000D6A2 File Offset: 0x0000B8A2
		public ReplHistoryInterpreter(Script script, int historySize) : base(null)
		{
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0000D6AB File Offset: 0x0000B8AB
		public override DynValue Evaluate(string input)
		{
			return null;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0000D6AE File Offset: 0x0000B8AE
		public string HistoryPrev()
		{
			return null;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0000D6B1 File Offset: 0x0000B8B1
		public string HistoryNext()
		{
			return null;
		}

		// Token: 0x040002C8 RID: 712
		private string[] m_History;

		// Token: 0x040002C9 RID: 713
		private int m_Last;

		// Token: 0x040002CA RID: 714
		private int m_Navi;
	}
}
