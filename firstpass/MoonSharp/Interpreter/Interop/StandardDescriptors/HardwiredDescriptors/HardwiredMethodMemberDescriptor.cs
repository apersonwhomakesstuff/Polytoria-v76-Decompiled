using System;

namespace MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors
{
	// Token: 0x020000C3 RID: 195
	public abstract class HardwiredMethodMemberDescriptor : FunctionMemberDescriptorBase
	{
		// Token: 0x06000916 RID: 2326 RVA: 0x0000DF8A File Offset: 0x0000C18A
		public override DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0000DF8D File Offset: 0x0000C18D
		private int CalcArgsCount(object[] pars)
		{
			return 0;
		}

		// Token: 0x06000918 RID: 2328
		protected abstract object Invoke(Script script, object obj, object[] pars, int argscount);
	}
}
