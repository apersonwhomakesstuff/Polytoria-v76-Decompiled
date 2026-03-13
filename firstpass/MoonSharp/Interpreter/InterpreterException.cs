using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200003F RID: 63
	[Serializable]
	public class InterpreterException : Exception
	{
		// Token: 0x0600050C RID: 1292 RVA: 0x0000CD20 File Offset: 0x0000AF20
		protected InterpreterException(Exception ex, string message)
		{
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000CD28 File Offset: 0x0000AF28
		protected InterpreterException(Exception ex)
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0000CD30 File Offset: 0x0000AF30
		protected InterpreterException(string message)
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0000CD38 File Offset: 0x0000AF38
		protected InterpreterException(string format, object[] args)
		{
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0000CD40 File Offset: 0x0000AF40
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x0000CD48 File Offset: 0x0000AF48
		public int InstructionPtr
		{
			get
			{
				return this.<InstructionPtr>k__BackingField;
			}
			internal set
			{
				this.<InstructionPtr>k__BackingField = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x0000CD51 File Offset: 0x0000AF51
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x0000CD59 File Offset: 0x0000AF59
		public IList<WatchItem> CallStack
		{
			get
			{
				return this.<CallStack>k__BackingField;
			}
			internal set
			{
				this.<CallStack>k__BackingField = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0000CD62 File Offset: 0x0000AF62
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x0000CD6A File Offset: 0x0000AF6A
		public string DecoratedMessage
		{
			get
			{
				return this.<DecoratedMessage>k__BackingField;
			}
			internal set
			{
				this.<DecoratedMessage>k__BackingField = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0000CD73 File Offset: 0x0000AF73
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x0000CD7B File Offset: 0x0000AF7B
		public bool DoNotDecorateMessage
		{
			get
			{
				return this.<DoNotDecorateMessage>k__BackingField;
			}
			set
			{
				this.<DoNotDecorateMessage>k__BackingField = value;
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0000CD84 File Offset: 0x0000AF84
		internal void DecorateMessage(Script script, SourceRef sref, int ip = -1)
		{
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0000CD86 File Offset: 0x0000AF86
		public virtual void Rethrow()
		{
		}

		// Token: 0x040001AB RID: 427
		private int <InstructionPtr>k__BackingField;

		// Token: 0x040001AC RID: 428
		private IList<WatchItem> <CallStack>k__BackingField;

		// Token: 0x040001AD RID: 429
		private string <DecoratedMessage>k__BackingField;

		// Token: 0x040001AE RID: 430
		private bool <DoNotDecorateMessage>k__BackingField;
	}
}
