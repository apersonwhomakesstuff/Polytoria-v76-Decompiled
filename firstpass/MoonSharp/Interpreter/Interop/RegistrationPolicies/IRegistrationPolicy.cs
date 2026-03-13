using System;

namespace MoonSharp.Interpreter.Interop.RegistrationPolicies
{
	// Token: 0x020000C7 RID: 199
	public interface IRegistrationPolicy
	{
		// Token: 0x06000920 RID: 2336
		IUserDataDescriptor HandleRegistration(IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor);

		// Token: 0x06000921 RID: 2337
		bool AllowTypeAutoRegistration(Type type);
	}
}
