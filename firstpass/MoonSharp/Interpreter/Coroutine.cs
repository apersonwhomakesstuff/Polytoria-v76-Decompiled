using System;
using System.Collections;
using System.Collections.Generic;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200002A RID: 42
	public class Coroutine : RefIdObject, IScriptPrivateResource
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0000C9B2 File Offset: 0x0000ABB2
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x0000C9BA File Offset: 0x0000ABBA
		public Coroutine.CoroutineType Type
		{
			get
			{
				return this.<Type>k__BackingField;
			}
			private set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000C9C3 File Offset: 0x0000ABC3
		internal Coroutine(CallbackFunction function)
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000C9CB File Offset: 0x0000ABCB
		internal Coroutine(Processor proc)
		{
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000C9D3 File Offset: 0x0000ABD3
		internal void MarkClrCallbackAsDead()
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000C9D5 File Offset: 0x0000ABD5
		internal DynValue Recycle(Processor mainProcessor, Closure closure)
		{
			return null;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		public IEnumerable<DynValue> AsTypedEnumerable()
		{
			return null;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000C9DB File Offset: 0x0000ABDB
		public IEnumerable<object> AsEnumerable()
		{
			return null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000C9DE File Offset: 0x0000ABDE
		public IEnumerable<T> AsEnumerable<T>()
		{
			return null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000C9E1 File Offset: 0x0000ABE1
		public IEnumerator AsUnityCoroutine()
		{
			return null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000C9E4 File Offset: 0x0000ABE4
		public DynValue Resume(DynValue[] args)
		{
			return null;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000C9E7 File Offset: 0x0000ABE7
		public DynValue Resume(ScriptExecutionContext context, DynValue[] args)
		{
			return null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000C9EA File Offset: 0x0000ABEA
		public DynValue Resume()
		{
			return null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0000C9ED File Offset: 0x0000ABED
		public DynValue Resume(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		public DynValue Resume(object[] args)
		{
			return null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000C9F3 File Offset: 0x0000ABF3
		public DynValue Resume(ScriptExecutionContext context, object[] args)
		{
			return null;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x000101D8 File Offset: 0x0000E3D8
		public CoroutineState State
		{
			get
			{
				return CoroutineState.Main;
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000C9F6 File Offset: 0x0000ABF6
		public WatchItem[] GetStackTrace(int skip, SourceRef entrySourceRef = null)
		{
			return null;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0000C9F9 File Offset: 0x0000ABF9
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x0000CA01 File Offset: 0x0000AC01
		public Script OwnerScript
		{
			get
			{
				return this.<OwnerScript>k__BackingField;
			}
			private set
			{
				this.<OwnerScript>k__BackingField = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0000CA0A File Offset: 0x0000AC0A
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x0000CA0E File Offset: 0x0000AC0E
		public long AutoYieldCounter
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		// Token: 0x0400015B RID: 347
		private Coroutine.CoroutineType <Type>k__BackingField;

		// Token: 0x0400015C RID: 348
		private CallbackFunction m_ClrCallback;

		// Token: 0x0400015D RID: 349
		private Processor m_Processor;

		// Token: 0x0400015E RID: 350
		private Script <OwnerScript>k__BackingField;

		// Token: 0x0200017C RID: 380
		public enum CoroutineType
		{
			// Token: 0x04000632 RID: 1586
			Coroutine,
			// Token: 0x04000633 RID: 1587
			ClrCallback,
			// Token: 0x04000634 RID: 1588
			ClrCallbackDead,
			// Token: 0x04000635 RID: 1589
			Recycled
		}

		// Token: 0x0200017D RID: 381
		private sealed class <AsEnumerable>d__12 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000EEF RID: 3823 RVA: 0x0000F2FC File Offset: 0x0000D4FC
			public <AsEnumerable>d__12(int <>1__state)
			{
			}

			// Token: 0x06000EF0 RID: 3824 RVA: 0x0000F304 File Offset: 0x0000D504
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06000EF1 RID: 3825 RVA: 0x0000F306 File Offset: 0x0000D506
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06000EF2 RID: 3826 RVA: 0x0000F309 File Offset: 0x0000D509
			private void <>m__Finally1()
			{
			}

			// Token: 0x170001DF RID: 479
			// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x0000F30B File Offset: 0x0000D50B
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000EF4 RID: 3828 RVA: 0x0000F30E File Offset: 0x0000D50E
			void IEnumerator.Reset()
			{
			}

			// Token: 0x170001E0 RID: 480
			// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x0000F310 File Offset: 0x0000D510
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000EF6 RID: 3830 RVA: 0x0000F313 File Offset: 0x0000D513
			IEnumerator<object> IEnumerable<object>.GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000EF7 RID: 3831 RVA: 0x0000F316 File Offset: 0x0000D516
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000636 RID: 1590
			private int <>1__state;

			// Token: 0x04000637 RID: 1591
			private object <>2__current;

			// Token: 0x04000638 RID: 1592
			private int <>l__initialThreadId;

			// Token: 0x04000639 RID: 1593
			public Coroutine <>4__this;

			// Token: 0x0400063A RID: 1594
			private IEnumerator<DynValue> <>7__wrap1;
		}

		// Token: 0x0200017E RID: 382
		private sealed class <AsEnumerable>d__13<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x06000EF8 RID: 3832 RVA: 0x0000F319 File Offset: 0x0000D519
			public <AsEnumerable>d__13(int <>1__state)
			{
			}

			// Token: 0x06000EF9 RID: 3833 RVA: 0x0000F321 File Offset: 0x0000D521
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06000EFA RID: 3834 RVA: 0x0000F323 File Offset: 0x0000D523
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06000EFB RID: 3835 RVA: 0x0000F326 File Offset: 0x0000D526
			private void <>m__Finally1()
			{
			}

			// Token: 0x170001E1 RID: 481
			// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00010B80 File Offset: 0x0000ED80
			T IEnumerator<!0>.Current
			{
				get
				{
					return default(T);
				}
			}

			// Token: 0x06000EFD RID: 3837 RVA: 0x0000F328 File Offset: 0x0000D528
			void IEnumerator.Reset()
			{
			}

			// Token: 0x170001E2 RID: 482
			// (get) Token: 0x06000EFE RID: 3838 RVA: 0x0000F32A File Offset: 0x0000D52A
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000EFF RID: 3839 RVA: 0x0000F32D File Offset: 0x0000D52D
			IEnumerator<T> IEnumerable<!0>.GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000F00 RID: 3840 RVA: 0x0000F330 File Offset: 0x0000D530
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400063B RID: 1595
			private int <>1__state;

			// Token: 0x0400063C RID: 1596
			private T <>2__current;

			// Token: 0x0400063D RID: 1597
			private int <>l__initialThreadId;

			// Token: 0x0400063E RID: 1598
			public Coroutine <>4__this;

			// Token: 0x0400063F RID: 1599
			private IEnumerator<DynValue> <>7__wrap1;
		}

		// Token: 0x0200017F RID: 383
		private sealed class <AsTypedEnumerable>d__11 : IEnumerable<DynValue>, IEnumerable, IEnumerator<DynValue>, IEnumerator, IDisposable
		{
			// Token: 0x06000F01 RID: 3841 RVA: 0x0000F333 File Offset: 0x0000D533
			public <AsTypedEnumerable>d__11(int <>1__state)
			{
			}

			// Token: 0x06000F02 RID: 3842 RVA: 0x0000F33B File Offset: 0x0000D53B
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06000F03 RID: 3843 RVA: 0x0000F33D File Offset: 0x0000D53D
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x170001E3 RID: 483
			// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0000F340 File Offset: 0x0000D540
			DynValue IEnumerator<DynValue>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000F05 RID: 3845 RVA: 0x0000F343 File Offset: 0x0000D543
			void IEnumerator.Reset()
			{
			}

			// Token: 0x170001E4 RID: 484
			// (get) Token: 0x06000F06 RID: 3846 RVA: 0x0000F345 File Offset: 0x0000D545
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000F07 RID: 3847 RVA: 0x0000F348 File Offset: 0x0000D548
			IEnumerator<DynValue> IEnumerable<DynValue>.GetEnumerator()
			{
				return null;
			}

			// Token: 0x06000F08 RID: 3848 RVA: 0x0000F34B File Offset: 0x0000D54B
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x04000640 RID: 1600
			private int <>1__state;

			// Token: 0x04000641 RID: 1601
			private DynValue <>2__current;

			// Token: 0x04000642 RID: 1602
			private int <>l__initialThreadId;

			// Token: 0x04000643 RID: 1603
			public Coroutine <>4__this;
		}

		// Token: 0x02000180 RID: 384
		private sealed class <AsUnityCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000F09 RID: 3849 RVA: 0x0000F34E File Offset: 0x0000D54E
			public <AsUnityCoroutine>d__14(int <>1__state)
			{
			}

			// Token: 0x06000F0A RID: 3850 RVA: 0x0000F356 File Offset: 0x0000D556
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06000F0B RID: 3851 RVA: 0x0000F358 File Offset: 0x0000D558
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06000F0C RID: 3852 RVA: 0x0000F35B File Offset: 0x0000D55B
			private void <>m__Finally1()
			{
			}

			// Token: 0x170001E5 RID: 485
			// (get) Token: 0x06000F0D RID: 3853 RVA: 0x0000F35D File Offset: 0x0000D55D
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06000F0E RID: 3854 RVA: 0x0000F360 File Offset: 0x0000D560
			void IEnumerator.Reset()
			{
			}

			// Token: 0x170001E6 RID: 486
			// (get) Token: 0x06000F0F RID: 3855 RVA: 0x0000F362 File Offset: 0x0000D562
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04000644 RID: 1604
			private int <>1__state;

			// Token: 0x04000645 RID: 1605
			private object <>2__current;

			// Token: 0x04000646 RID: 1606
			public Coroutine <>4__this;

			// Token: 0x04000647 RID: 1607
			private IEnumerator<DynValue> <>7__wrap1;
		}
	}
}
