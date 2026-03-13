using System;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000AD RID: 173
	public class ArrayMemberDescriptor : ObjectCallbackMemberDescriptor, IWireableDescriptor
	{
		// Token: 0x060007FF RID: 2047 RVA: 0x0000D9F9 File Offset: 0x0000BBF9
		public ArrayMemberDescriptor(string name, bool isSetter, ParameterDescriptor[] indexerParams) : base(null)
		{
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0000DA02 File Offset: 0x0000BC02
		public ArrayMemberDescriptor(string name, bool isSetter) : base(null)
		{
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0000DA0B File Offset: 0x0000BC0B
		public void PrepareForWiring(Table t)
		{
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0000DA0D File Offset: 0x0000BC0D
		private static int[] BuildArrayIndices(CallbackArguments args, int count)
		{
			return null;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0000DA10 File Offset: 0x0000BC10
		private static object ArrayIndexerSet(object arrayObj, ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0000DA13 File Offset: 0x0000BC13
		private static object ArrayIndexerGet(object arrayObj, ScriptExecutionContext ctx, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x04000317 RID: 791
		private bool m_IsSetter;
	}
}
