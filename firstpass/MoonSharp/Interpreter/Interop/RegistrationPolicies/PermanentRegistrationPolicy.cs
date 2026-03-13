using System;

namespace MoonSharp.Interpreter.Interop.RegistrationPolicies
{
	// Token: 0x020000C8 RID: 200
	public class PermanentRegistrationPolicy : IRegistrationPolicy
	{
		// Token: 0x06000922 RID: 2338 RVA: 0x0000DFBB File Offset: 0x0000C1BB
		public IUserDataDescriptor HandleRegistration(IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor)
		{
			return null;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0000DFBE File Offset: 0x0000C1BE
		public bool AllowTypeAutoRegistration(Type type)
		{
			return false;
		}
	}
}
