using System;
using MoonSharp.Interpreter.Interop;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200004C RID: 76
	public class AutoDescribingUserDataDescriptor : IUserDataDescriptor
	{
		// Token: 0x06000598 RID: 1432 RVA: 0x0000CFED File Offset: 0x0000B1ED
		public AutoDescribingUserDataDescriptor(Type type, string friendlyName)
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0000CFF5 File Offset: 0x0000B1F5
		public string Name
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0000CFF8 File Offset: 0x0000B1F8
		public Type Type
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0000CFFB File Offset: 0x0000B1FB
		public DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0000CFFE File Offset: 0x0000B1FE
		public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return false;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0000D001 File Offset: 0x0000B201
		public string AsString(object obj)
		{
			return null;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0000D004 File Offset: 0x0000B204
		public DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0000D007 File Offset: 0x0000B207
		public bool IsTypeCompatible(Type type, object obj)
		{
			return false;
		}

		// Token: 0x040001C6 RID: 454
		private string m_FriendlyName;

		// Token: 0x040001C7 RID: 455
		private Type m_Type;
	}
}
