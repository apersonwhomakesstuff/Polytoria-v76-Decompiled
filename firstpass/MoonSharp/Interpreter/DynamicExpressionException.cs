using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200003D RID: 61
	[Serializable]
	public class DynamicExpressionException : ScriptRuntimeException
	{
		// Token: 0x06000508 RID: 1288 RVA: 0x0000CCFA File Offset: 0x0000AEFA
		public DynamicExpressionException(string format, object[] args) : base(null)
		{
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0000CD03 File Offset: 0x0000AF03
		public DynamicExpressionException(string message) : base(null)
		{
		}
	}
}
