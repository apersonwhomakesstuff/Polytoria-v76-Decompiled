using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200003E RID: 62
	[Serializable]
	public class InternalErrorException : InterpreterException
	{
		// Token: 0x0600050A RID: 1290 RVA: 0x0000CD0C File Offset: 0x0000AF0C
		internal InternalErrorException(string message) : base(null, null)
		{
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000CD16 File Offset: 0x0000AF16
		internal InternalErrorException(string format, object[] args) : base(null, null)
		{
		}
	}
}
