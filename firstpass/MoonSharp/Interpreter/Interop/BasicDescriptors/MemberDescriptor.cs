using System;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	// Token: 0x020000D6 RID: 214
	public static class MemberDescriptor
	{
		// Token: 0x060009FB RID: 2555 RVA: 0x0000E2BD File Offset: 0x0000C4BD
		public static bool HasAllFlags(MemberDescriptorAccess access, MemberDescriptorAccess flag)
		{
			return false;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0000E2C0 File Offset: 0x0000C4C0
		public static bool CanRead(IMemberDescriptor desc)
		{
			return false;
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0000E2C3 File Offset: 0x0000C4C3
		public static bool CanWrite(IMemberDescriptor desc)
		{
			return false;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0000E2C6 File Offset: 0x0000C4C6
		public static bool CanExecute(IMemberDescriptor desc)
		{
			return false;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0000E2C9 File Offset: 0x0000C4C9
		public static DynValue GetGetterCallbackAsDynValue(IMemberDescriptor desc, Script script, object obj)
		{
			return null;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0000E2CC File Offset: 0x0000C4CC
		public static IMemberDescriptor WithAccessOrNull(IMemberDescriptor desc, MemberDescriptorAccess access)
		{
			return null;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0000E2CF File Offset: 0x0000C4CF
		public static void CheckAccess(IMemberDescriptor desc, MemberDescriptorAccess access, object obj)
		{
		}

		// Token: 0x020001C4 RID: 452
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06001018 RID: 4120 RVA: 0x0000F681 File Offset: 0x0000D881
			internal DynValue <GetGetterCallbackAsDynValue>b__0(ScriptExecutionContext p1, CallbackArguments p2)
			{
				return null;
			}

			// Token: 0x040006FB RID: 1787
			public IMemberDescriptor desc;

			// Token: 0x040006FC RID: 1788
			public Script script;

			// Token: 0x040006FD RID: 1789
			public object obj;
		}
	}
}
