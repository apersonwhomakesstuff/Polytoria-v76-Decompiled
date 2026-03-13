using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.DataStructs
{
	// Token: 0x02000106 RID: 262
	internal class ReferenceEqualityComparer : IEqualityComparer<object>
	{
		// Token: 0x06000BBD RID: 3005 RVA: 0x0000EA89 File Offset: 0x0000CC89
		bool IEqualityComparer<object>.Equals(object x, object y)
		{
			return false;
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0000EA8C File Offset: 0x0000CC8C
		int IEqualityComparer<object>.GetHashCode(object obj)
		{
			return 0;
		}
	}
}
