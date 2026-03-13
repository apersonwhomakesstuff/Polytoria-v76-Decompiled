using System;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A7 RID: 167
	public class DelegateProxyFactory<TProxy, TTarget> : IProxyFactory<TProxy, TTarget>, IProxyFactory where TProxy : class where TTarget : class
	{
		// Token: 0x060007E7 RID: 2023 RVA: 0x0000D9A6 File Offset: 0x0000BBA6
		public DelegateProxyFactory(Func<TTarget, TProxy> wrapDelegate)
		{
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00010388 File Offset: 0x0000E588
		public TProxy CreateProxyObject(TTarget target)
		{
			return default(TProxy);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0000D9AE File Offset: 0x0000BBAE
		public object CreateProxyObject(object o)
		{
			return null;
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x0000D9B1 File Offset: 0x0000BBB1
		public Type TargetType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x0000D9B4 File Offset: 0x0000BBB4
		public Type ProxyType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040002F3 RID: 755
		private Func<TTarget, TProxy> wrapDelegate;
	}
}
