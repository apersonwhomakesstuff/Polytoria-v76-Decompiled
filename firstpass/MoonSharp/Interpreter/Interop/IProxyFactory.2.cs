using System;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A9 RID: 169
	public interface IProxyFactory<TProxy, TTarget> : IProxyFactory where TProxy : class where TTarget : class
	{
		// Token: 0x060007EF RID: 2031
		TProxy CreateProxyObject(TTarget target);
	}
}
