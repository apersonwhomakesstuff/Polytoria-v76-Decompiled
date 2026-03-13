using System;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x0200005E RID: 94
	internal class Token
	{
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x0000D2E8 File Offset: 0x0000B4E8
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		public string Text
		{
			get
			{
				return this.<Text>k__BackingField;
			}
			set
			{
				this.<Text>k__BackingField = value;
			}
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0000D2F9 File Offset: 0x0000B4F9
		public Token(TokenType type, int sourceId, int fromLine, int fromCol, int toLine, int toCol, int prevLine, int prevCol)
		{
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0000D301 File Offset: 0x0000B501
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000102C8 File Offset: 0x0000E4C8
		public static TokenType? GetReservedTokenType(string reservedWord)
		{
			return null;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0000D304 File Offset: 0x0000B504
		public double GetNumberValue()
		{
			return 0.0;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0000D30F File Offset: 0x0000B50F
		public bool IsEndOfBlock()
		{
			return false;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0000D312 File Offset: 0x0000B512
		public bool IsUnaryOperator()
		{
			return false;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0000D315 File Offset: 0x0000B515
		public bool IsBinaryOperator()
		{
			return false;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0000D318 File Offset: 0x0000B518
		internal SourceRef GetSourceRef(bool isStepStop = true)
		{
			return null;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0000D31B File Offset: 0x0000B51B
		internal SourceRef GetSourceRef(Token to, bool isStepStop = true)
		{
			return null;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0000D31E File Offset: 0x0000B51E
		internal SourceRef GetSourceRefUpTo(Token to, bool isStepStop = true)
		{
			return null;
		}

		// Token: 0x04000211 RID: 529
		public readonly int SourceId;

		// Token: 0x04000212 RID: 530
		public readonly int FromCol;

		// Token: 0x04000213 RID: 531
		public readonly int ToCol;

		// Token: 0x04000214 RID: 532
		public readonly int FromLine;

		// Token: 0x04000215 RID: 533
		public readonly int ToLine;

		// Token: 0x04000216 RID: 534
		public readonly int PrevCol;

		// Token: 0x04000217 RID: 535
		public readonly int PrevLine;

		// Token: 0x04000218 RID: 536
		public readonly TokenType Type;

		// Token: 0x04000219 RID: 537
		private string <Text>k__BackingField;
	}
}
