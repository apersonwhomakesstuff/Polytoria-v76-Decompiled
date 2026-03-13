using System;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Tree;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000043 RID: 67
	[Serializable]
	public class SyntaxErrorException : InterpreterException
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x0000CE99 File Offset: 0x0000B099
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x0000CEA1 File Offset: 0x0000B0A1
		internal Token Token
		{
			get
			{
				return this.<Token>k__BackingField;
			}
			private set
			{
				this.<Token>k__BackingField = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x0000CEAA File Offset: 0x0000B0AA
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x0000CEB2 File Offset: 0x0000B0B2
		public bool IsPrematureStreamTermination
		{
			get
			{
				return this.<IsPrematureStreamTermination>k__BackingField;
			}
			set
			{
				this.<IsPrematureStreamTermination>k__BackingField = value;
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0000CEBB File Offset: 0x0000B0BB
		internal SyntaxErrorException(Token t, string format, object[] args) : base(null, null)
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0000CEC5 File Offset: 0x0000B0C5
		internal SyntaxErrorException(Token t, string message) : base(null, null)
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0000CECF File Offset: 0x0000B0CF
		internal SyntaxErrorException(Script script, SourceRef sref, string format, object[] args) : base(null, null)
		{
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0000CED9 File Offset: 0x0000B0D9
		internal SyntaxErrorException(Script script, SourceRef sref, string message) : base(null, null)
		{
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0000CEE3 File Offset: 0x0000B0E3
		private SyntaxErrorException(SyntaxErrorException syntaxErrorException) : base(null, null)
		{
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0000CEED File Offset: 0x0000B0ED
		internal void DecorateMessage(Script script)
		{
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0000CEEF File Offset: 0x0000B0EF
		public override void Rethrow()
		{
		}

		// Token: 0x040001AF RID: 431
		private Token <Token>k__BackingField;

		// Token: 0x040001B0 RID: 432
		private bool <IsPrematureStreamTermination>k__BackingField;
	}
}
