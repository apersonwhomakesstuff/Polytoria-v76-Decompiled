using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.DataStructs
{
	// Token: 0x02000103 RID: 259
	internal class FastStackDynamic<T> : List<T>
	{
		// Token: 0x06000BA4 RID: 2980 RVA: 0x0000EA3F File Offset: 0x0000CC3F
		public FastStackDynamic(int startingCapacity)
		{
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0000EA47 File Offset: 0x0000CC47
		public void Set(int idxofs, T item)
		{
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00010580 File Offset: 0x0000E780
		public T Push(T item)
		{
			return default(T);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0000EA49 File Offset: 0x0000CC49
		public void Expand(int size)
		{
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0000EA4B File Offset: 0x0000CC4B
		public void Zero(int index)
		{
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00010598 File Offset: 0x0000E798
		public T Peek(int idxofs = 0)
		{
			return default(T);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0000EA4D File Offset: 0x0000CC4D
		public void CropAtCount(int p)
		{
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0000EA4F File Offset: 0x0000CC4F
		public void RemoveLast(int cnt = 1)
		{
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000105B0 File Offset: 0x0000E7B0
		public T Pop()
		{
			return default(T);
		}
	}
}
