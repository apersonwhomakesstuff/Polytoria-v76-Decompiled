using System;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A4 RID: 164
	public class PropertyTableAssigner<T> : IPropertyTableAssigner
	{
		// Token: 0x060007D8 RID: 2008 RVA: 0x0000D97C File Offset: 0x0000BB7C
		public PropertyTableAssigner(string[] expectedMissingProperties)
		{
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0000D984 File Offset: 0x0000BB84
		public void AddExpectedMissingProperty(string name)
		{
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0000D986 File Offset: 0x0000BB86
		public void AssignObject(T obj, Table data)
		{
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0000D988 File Offset: 0x0000BB88
		public PropertyTableAssigner GetTypeUnsafeAssigner()
		{
			return null;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0000D98B File Offset: 0x0000BB8B
		public void SetSubassignerForType(Type propertyType, IPropertyTableAssigner assigner)
		{
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0000D98D File Offset: 0x0000BB8D
		public void SetSubassigner<SubassignerType>(PropertyTableAssigner<SubassignerType> assigner)
		{
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0000D98F File Offset: 0x0000BB8F
		void IPropertyTableAssigner.AssignObjectUnchecked(object o, Table data)
		{
		}

		// Token: 0x040002EF RID: 751
		private PropertyTableAssigner m_InternalAssigner;
	}
}
