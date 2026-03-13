using System;
using System.Collections;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.DataStructs
{
	// Token: 0x02000107 RID: 263
	internal class Slice<T> : IEnumerable<!0>, IEnumerable, IList<T>, ICollection<T>
	{
		// Token: 0x06000BC0 RID: 3008 RVA: 0x0000EA97 File Offset: 0x0000CC97
		public Slice(IList<T> list, int from, int length, bool reversed)
		{
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x000105E0 File Offset: 0x0000E7E0
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x0000EA9F File Offset: 0x0000CC9F
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

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0000EAA1 File Offset: 0x0000CCA1
		public int From
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0000EAA4 File Offset: 0x0000CCA4
		public int Count
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0000EAA7 File Offset: 0x0000CCA7
		public bool Reversed
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0000EAAA File Offset: 0x0000CCAA
		private int CalcRealIndex(int index)
		{
			return 0;
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0000EAAD File Offset: 0x0000CCAD
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0000EAB0 File Offset: 0x0000CCB0
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0000EAB3 File Offset: 0x0000CCB3
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0000EAB6 File Offset: 0x0000CCB6
		public List<T> ToList()
		{
			return null;
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0000EAB9 File Offset: 0x0000CCB9
		public int IndexOf(T item)
		{
			return 0;
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0000EABC File Offset: 0x0000CCBC
		public void Insert(int index, T item)
		{
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0000EABE File Offset: 0x0000CCBE
		public void RemoveAt(int index)
		{
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		public void Add(T item)
		{
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x0000EAC2 File Offset: 0x0000CCC2
		public void Clear()
		{
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0000EAC4 File Offset: 0x0000CCC4
		public bool Contains(T item)
		{
			return false;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0000EAC7 File Offset: 0x0000CCC7
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0000EAC9 File Offset: 0x0000CCC9
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0000EACC File Offset: 0x0000CCCC
		public bool Remove(T item)
		{
			return false;
		}

		// Token: 0x0400049C RID: 1180
		private IList<T> m_SourceList;

		// Token: 0x0400049D RID: 1181
		private int m_From;

		// Token: 0x0400049E RID: 1182
		private int m_Length;

		// Token: 0x0400049F RID: 1183
		private bool m_Reversed;

		// Token: 0x020001CD RID: 461
		private sealed class <GetEnumerator>d__15 : IEnumerator<!0>, IEnumerator, IDisposable
		{
			// Token: 0x06001029 RID: 4137 RVA: 0x0000F6D2 File Offset: 0x0000D8D2
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			// Token: 0x0600102A RID: 4138 RVA: 0x0000F6DA File Offset: 0x0000D8DA
			void IDisposable.Dispose()
			{
			}

			// Token: 0x0600102B RID: 4139 RVA: 0x0000F6DC File Offset: 0x0000D8DC
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x170001E9 RID: 489
			// (get) Token: 0x0600102C RID: 4140 RVA: 0x00010BE0 File Offset: 0x0000EDE0
			T IEnumerator<!0>.Current
			{
				get
				{
					return default(T);
				}
			}

			// Token: 0x0600102D RID: 4141 RVA: 0x0000F6DF File Offset: 0x0000D8DF
			void IEnumerator.Reset()
			{
			}

			// Token: 0x170001EA RID: 490
			// (get) Token: 0x0600102E RID: 4142 RVA: 0x0000F6E1 File Offset: 0x0000D8E1
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04000720 RID: 1824
			private int <>1__state;

			// Token: 0x04000721 RID: 1825
			private T <>2__current;

			// Token: 0x04000722 RID: 1826
			public Slice<T> <>4__this;

			// Token: 0x04000723 RID: 1827
			private int <i>5__2;
		}

		// Token: 0x020001CE RID: 462
		private sealed class <System-Collections-IEnumerable-GetEnumerator>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600102F RID: 4143 RVA: 0x0000F6E4 File Offset: 0x0000D8E4
			public <System-Collections-IEnumerable-GetEnumerator>d__16(int <>1__state)
			{
			}

			// Token: 0x06001030 RID: 4144 RVA: 0x0000F6EC File Offset: 0x0000D8EC
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06001031 RID: 4145 RVA: 0x0000F6EE File Offset: 0x0000D8EE
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x170001EB RID: 491
			// (get) Token: 0x06001032 RID: 4146 RVA: 0x0000F6F1 File Offset: 0x0000D8F1
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06001033 RID: 4147 RVA: 0x0000F6F4 File Offset: 0x0000D8F4
			void IEnumerator.Reset()
			{
			}

			// Token: 0x170001EC RID: 492
			// (get) Token: 0x06001034 RID: 4148 RVA: 0x0000F6F6 File Offset: 0x0000D8F6
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04000724 RID: 1828
			private int <>1__state;

			// Token: 0x04000725 RID: 1829
			private object <>2__current;

			// Token: 0x04000726 RID: 1830
			public Slice<T> <>4__this;

			// Token: 0x04000727 RID: 1831
			private int <i>5__2;
		}
	}
}
