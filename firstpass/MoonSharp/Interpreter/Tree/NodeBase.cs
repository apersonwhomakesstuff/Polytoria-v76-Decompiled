using System;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x02000062 RID: 98
	internal abstract class NodeBase
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x0000D33B File Offset: 0x0000B53B
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x0000D343 File Offset: 0x0000B543
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

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x0000D34C File Offset: 0x0000B54C
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x0000D354 File Offset: 0x0000B554
		private protected ScriptLoadingContext LoadingContext
		{
			protected get
			{
				return this.<LoadingContext>k__BackingField;
			}
			private set
			{
				this.<LoadingContext>k__BackingField = value;
			}
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0000D35D File Offset: 0x0000B55D
		public NodeBase(ScriptLoadingContext lcontext)
		{
		}

		// Token: 0x06000647 RID: 1607
		public abstract void Compile(ByteCode bc);

		// Token: 0x06000648 RID: 1608 RVA: 0x0000D365 File Offset: 0x0000B565
		protected static Token UnexpectedTokenType(Token t)
		{
			return null;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0000D368 File Offset: 0x0000B568
		protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType)
		{
			return null;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0000D36B File Offset: 0x0000B56B
		protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType1, TokenType tokenType2)
		{
			return null;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0000D36E File Offset: 0x0000B56E
		protected static Token CheckTokenType(ScriptLoadingContext lcontext, TokenType tokenType1, TokenType tokenType2, TokenType tokenType3)
		{
			return null;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0000D371 File Offset: 0x0000B571
		protected static void CheckTokenTypeNotNext(ScriptLoadingContext lcontext, TokenType tokenType)
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000D373 File Offset: 0x0000B573
		protected static Token CheckMatch(ScriptLoadingContext lcontext, Token originalToken, TokenType expectedTokenType, string expectedTokenText)
		{
			return null;
		}

		// Token: 0x0400025B RID: 603
		private Script <Script>k__BackingField;

		// Token: 0x0400025C RID: 604
		private ScriptLoadingContext <LoadingContext>k__BackingField;
	}
}
