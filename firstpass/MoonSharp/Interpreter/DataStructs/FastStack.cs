using System;
using System.Collections;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.DataStructs
{
	// Token: 0x02000102 RID: 258
	internal class FastStack<T> : IList<T>, ICollection<T>, IEnumerable<!0>, IEnumerable
	{
		// Token: 0x06000B88 RID: 2952 RVA: 0x0000EA03 File Offset: 0x0000CC03
		public FastStack(int maxCapacity)
		{
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00010508 File Offset: 0x0000E708
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x0000EA0B File Offset: 0x0000CC0B
		public T Item
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00010520 File Offset: 0x0000E720
		public T Push(T item)
		{
			return default(T);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0000EA0D File Offset: 0x0000CC0D
		private void Zero(int from, int to)
		{
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0000EA0F File Offset: 0x0000CC0F
		private void Zero(int index)
		{
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00010538 File Offset: 0x0000E738
		public T Peek(int idxofs = 0)
		{
			return default(T);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0000EA11 File Offset: 0x0000CC11
		public void Set(int idxofs, T item)
		{
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0000EA13 File Offset: 0x0000CC13
		public void CropAtCount(int p)
		{
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0000EA15 File Offset: 0x0000CC15
		public void RemoveLast(int cnt = 1)
		{
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00010550 File Offset: 0x0000E750
		public T Pop()
		{
			return default(T);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0000EA17 File Offset: 0x0000CC17
		public void Clear()
		{
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0000EA19 File Offset: 0x0000CC19
		public void ClearUsed()
		{
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0000EA1B File Offset: 0x0000CC1B
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0000EA1E File Offset: 0x0000CC1E
		int IList<!0>.IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0000EA21 File Offset: 0x0000CC21
		void IList<!0>.Insert(int index, T item)
		{
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0000EA23 File Offset: 0x0000CC23
		void IList<!0>.RemoveAt(int index)
		{
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00010568 File Offset: 0x0000E768
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x0000EA25 File Offset: 0x0000CC25
		T IList<!0>.Item
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0000EA27 File Offset: 0x0000CC27
		void ICollection<!0>.Add(T item)
		{
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0000EA29 File Offset: 0x0000CC29
		void ICollection<!0>.Clear()
		{
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0000EA2B File Offset: 0x0000CC2B
		bool ICollection<!0>.Contains(T item)
		{
			return false;
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0000EA2E File Offset: 0x0000CC2E
		void ICollection<!0>.CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0000EA30 File Offset: 0x0000CC30
		int ICollection<!0>.Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x0000EA33 File Offset: 0x0000CC33
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0000EA36 File Offset: 0x0000CC36
		bool ICollection<!0>.Remove(T item)
		{
			return false;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0000EA39 File Offset: 0x0000CC39
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0000EA3C File Offset: 0x0000CC3C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000496 RID: 1174
		private T[] m_Storage;

		// Token: 0x04000497 RID: 1175
		private int m_HeadIdx;
	}
}
