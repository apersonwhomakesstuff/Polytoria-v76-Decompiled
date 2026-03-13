using System;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors
{
	// Token: 0x020000C4 RID: 196
	public abstract class HardwiredUserDataDescriptor : DispatchingUserDataDescriptor
	{
		// Token: 0x0600091A RID: 2330 RVA: 0x0000DF98 File Offset: 0x0000C198
		protected HardwiredUserDataDescriptor(Type T) : base(null, null)
		{
		}
	}
}
