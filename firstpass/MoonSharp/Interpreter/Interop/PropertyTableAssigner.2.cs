using System;
using System.Collections.Generic;
using System.Reflection;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A5 RID: 165
	public class PropertyTableAssigner : IPropertyTableAssigner
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x0000D991 File Offset: 0x0000BB91
		public PropertyTableAssigner(Type type, string[] expectedMissingProperties)
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0000D999 File Offset: 0x0000BB99
		public void AddExpectedMissingProperty(string name)
		{
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0000D99B File Offset: 0x0000BB9B
		private bool TryAssignProperty(object obj, string name, DynValue value)
		{
			return false;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0000D99E File Offset: 0x0000BB9E
		private void AssignProperty(object obj, string name, DynValue value)
		{
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0000D9A0 File Offset: 0x0000BBA0
		public void AssignObject(object obj, Table data)
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0000D9A2 File Offset: 0x0000BBA2
		public void SetSubassignerForType(Type propertyType, IPropertyTableAssigner assigner)
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0000D9A4 File Offset: 0x0000BBA4
		void IPropertyTableAssigner.AssignObjectUnchecked(object obj, Table data)
		{
		}

		// Token: 0x040002F0 RID: 752
		private Type m_Type;

		// Token: 0x040002F1 RID: 753
		private Dictionary<string, PropertyInfo> m_PropertyMap;

		// Token: 0x040002F2 RID: 754
		private Dictionary<Type, IPropertyTableAssigner> m_SubAssigners;
	}
}
