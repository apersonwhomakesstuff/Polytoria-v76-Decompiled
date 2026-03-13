using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000AC RID: 172
	public class CompositeUserDataDescriptor : IUserDataDescriptor
	{
		// Token: 0x060007F6 RID: 2038 RVA: 0x0000D9D9 File Offset: 0x0000BBD9
		public CompositeUserDataDescriptor(List<IUserDataDescriptor> descriptors, Type type)
		{
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0000D9E1 File Offset: 0x0000BBE1
		public IList<IUserDataDescriptor> Descriptors
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0000D9E4 File Offset: 0x0000BBE4
		public string Name
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x0000D9E7 File Offset: 0x0000BBE7
		public Type Type
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0000D9EA File Offset: 0x0000BBEA
		public DynValue Index(Script script, object obj, DynValue index, bool isNameIndex)
		{
			return null;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0000D9ED File Offset: 0x0000BBED
		public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isNameIndex)
		{
			return false;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0000D9F0 File Offset: 0x0000BBF0
		public string AsString(object obj)
		{
			return null;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0000D9F3 File Offset: 0x0000BBF3
		public DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0000D9F6 File Offset: 0x0000BBF6
		public bool IsTypeCompatible(Type type, object obj)
		{
			return false;
		}

		// Token: 0x04000315 RID: 789
		private List<IUserDataDescriptor> m_Descriptors;

		// Token: 0x04000316 RID: 790
		private Type m_Type;
	}
}
