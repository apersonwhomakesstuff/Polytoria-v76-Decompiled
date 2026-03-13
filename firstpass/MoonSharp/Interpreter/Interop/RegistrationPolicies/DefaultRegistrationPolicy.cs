using System;

namespace MoonSharp.Interpreter.Interop.RegistrationPolicies
{
	// Token: 0x020000C6 RID: 198
	public class DefaultRegistrationPolicy : IRegistrationPolicy
	{
		// Token: 0x0600091D RID: 2333 RVA: 0x0000DFAD File Offset: 0x0000C1AD
		public IUserDataDescriptor HandleRegistration(IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor)
		{
			return null;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		public virtual bool AllowTypeAutoRegistration(Type type)
		{
			return false;
		}
	}
}
