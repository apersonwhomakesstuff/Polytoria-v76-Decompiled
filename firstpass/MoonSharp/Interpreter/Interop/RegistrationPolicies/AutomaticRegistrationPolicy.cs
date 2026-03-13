using System;

namespace MoonSharp.Interpreter.Interop.RegistrationPolicies
{
	// Token: 0x020000C5 RID: 197
	public class AutomaticRegistrationPolicy : DefaultRegistrationPolicy
	{
		// Token: 0x0600091B RID: 2331 RVA: 0x0000DFA2 File Offset: 0x0000C1A2
		public override bool AllowTypeAutoRegistration(Type type)
		{
			return false;
		}
	}
}
