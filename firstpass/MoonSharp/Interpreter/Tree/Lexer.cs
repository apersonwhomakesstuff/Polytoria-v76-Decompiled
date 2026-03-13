using System;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x0200005C RID: 92
	internal class Lexer
	{
		// Token: 0x06000611 RID: 1553 RVA: 0x0000D26A File Offset: 0x0000B46A
		public Lexer(int sourceID, string scriptContent, bool autoSkipComments)
		{
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x0000D272 File Offset: 0x0000B472
		public Token Current
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0000D275 File Offset: 0x0000B475
		private Token FetchNewToken()
		{
			return null;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0000D278 File Offset: 0x0000B478
		public void Next()
		{
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0000D27A File Offset: 0x0000B47A
		public Token PeekNext()
		{
			return null;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0000D27D File Offset: 0x0000B47D
		private void CursorNext()
		{
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0000D27F File Offset: 0x0000B47F
		private char CursorChar()
		{
			return '\0';
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0000D282 File Offset: 0x0000B482
		private char CursorCharNext()
		{
			return '\0';
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0000D285 File Offset: 0x0000B485
		private bool CursorMatches(string pattern)
		{
			return false;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0000D288 File Offset: 0x0000B488
		private bool CursorNotEof()
		{
			return false;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0000D28B File Offset: 0x0000B48B
		private void SkipWhiteSpace()
		{
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0000D28D File Offset: 0x0000B48D
		private Token ReadToken()
		{
			return null;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0000D290 File Offset: 0x0000B490
		private string ReadLongString(int fromLine, int fromCol, string startpattern, string subtypeforerrors)
		{
			return null;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0000D293 File Offset: 0x0000B493
		private Token ReadNumberToken(int fromLine, int fromCol, bool leadingDot)
		{
			return null;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0000D296 File Offset: 0x0000B496
		private Token CreateSingleCharToken(TokenType tokenType, int fromLine, int fromCol)
		{
			return null;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0000D299 File Offset: 0x0000B499
		private Token ReadHashBang(int fromLine, int fromCol)
		{
			return null;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0000D29C File Offset: 0x0000B49C
		private Token ReadComment(int fromLine, int fromCol)
		{
			return null;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0000D29F File Offset: 0x0000B49F
		private Token ReadSimpleStringToken(int fromLine, int fromCol)
		{
			return null;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0000D2A2 File Offset: 0x0000B4A2
		private Token PotentiallyDoubleCharOperator(char expectedSecondChar, TokenType singleCharToken, TokenType doubleCharToken, int fromLine, int fromCol)
		{
			return null;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0000D2A5 File Offset: 0x0000B4A5
		private Token CreateNameToken(string name, int fromLine, int fromCol)
		{
			return null;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		private Token CreateToken(TokenType tokenType, int fromLine, int fromCol, string text = null)
		{
			return null;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0000D2AB File Offset: 0x0000B4AB
		private string ReadNameToken()
		{
			return null;
		}

		// Token: 0x04000207 RID: 519
		private Token m_Current;

		// Token: 0x04000208 RID: 520
		private readonly string m_Code;

		// Token: 0x04000209 RID: 521
		private int m_PrevLineTo;

		// Token: 0x0400020A RID: 522
		private int m_PrevColTo;

		// Token: 0x0400020B RID: 523
		private int m_Cursor;

		// Token: 0x0400020C RID: 524
		private readonly int m_StartCursor;

		// Token: 0x0400020D RID: 525
		private int m_Line;

		// Token: 0x0400020E RID: 526
		private int m_Col;

		// Token: 0x0400020F RID: 527
		private readonly int m_SourceId;

		// Token: 0x04000210 RID: 528
		private readonly bool m_AutoSkipComments;
	}
}
