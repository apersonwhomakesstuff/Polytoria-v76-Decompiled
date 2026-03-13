using System;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A8 RID: 168
	public interface IProxyFactory
	{
		// Token: 0x060007EC RID: 2028
		object CreateProxyObject(object o);

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060007ED RID: 2029
		Type TargetType { get; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060007EE RID: 2030
		Type ProxyType { get; }
	}
}
