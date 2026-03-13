using System;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B1 RID: 177
	public sealed class ProxyUserDataDescriptor : IUserDataDescriptor
	{
		// Token: 0x0600082F RID: 2095 RVA: 0x0000DB14 File Offset: 0x0000BD14
		internal ProxyUserDataDescriptor(IProxyFactory proxyFactory, IUserDataDescriptor proxyDescriptor, string friendlyName = null)
		{
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x0000DB1C File Offset: 0x0000BD1C
		public IUserDataDescriptor InnerDescriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x0000DB1F File Offset: 0x0000BD1F
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x0000DB27 File Offset: 0x0000BD27
		public string Name
		{
			get
			{
				return this.<Name>k__BackingField;
			}
			private set
			{
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x0000DB30 File Offset: 0x0000BD30
		public Type Type
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0000DB33 File Offset: 0x0000BD33
		private object Proxy(object obj)
		{
			return null;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0000DB36 File Offset: 0x0000BD36
		public DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0000DB39 File Offset: 0x0000BD39
		public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return false;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0000DB3C File Offset: 0x0000BD3C
		public string AsString(object obj)
		{
			return null;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0000DB3F File Offset: 0x0000BD3F
		public DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0000DB42 File Offset: 0x0000BD42
		public bool IsTypeCompatible(Type type, object obj)
		{
			return false;
		}

		// Token: 0x04000323 RID: 803
		private IUserDataDescriptor m_ProxyDescriptor;

		// Token: 0x04000324 RID: 804
		private IProxyFactory m_ProxyFactory;

		// Token: 0x04000325 RID: 805
		private string <Name>k__BackingField;
	}
}
