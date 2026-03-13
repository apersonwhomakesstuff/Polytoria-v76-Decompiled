using System;
using System.Collections.Generic;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	// Token: 0x020000D4 RID: 212
	public abstract class DispatchingUserDataDescriptor : IUserDataDescriptor, IOptimizableDescriptor
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0000E220 File Offset: 0x0000C420
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x0000E228 File Offset: 0x0000C428
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

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0000E231 File Offset: 0x0000C431
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x0000E239 File Offset: 0x0000C439
		public Type Type
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

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0000E242 File Offset: 0x0000C442
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x0000E24A File Offset: 0x0000C44A
		public string FriendlyName
		{
			get
			{
				return this.<FriendlyName>k__BackingField;
			}
			private set
			{
				this.<FriendlyName>k__BackingField = value;
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0000E253 File Offset: 0x0000C453
		protected DispatchingUserDataDescriptor(Type type, string friendlyName = null)
		{
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0000E25B File Offset: 0x0000C45B
		public void AddMetaMember(string name, IMemberDescriptor desc)
		{
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0000E25D File Offset: 0x0000C45D
		public void AddDynValue(string name, DynValue value)
		{
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0000E25F File Offset: 0x0000C45F
		public void AddMember(string name, IMemberDescriptor desc)
		{
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0000E261 File Offset: 0x0000C461
		public IEnumerable<string> MemberNames
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0000E264 File Offset: 0x0000C464
		public IEnumerable<KeyValuePair<string, IMemberDescriptor>> Members
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0000E267 File Offset: 0x0000C467
		public IMemberDescriptor FindMember(string memberName)
		{
			return null;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0000E26A File Offset: 0x0000C46A
		public void RemoveMember(string memberName)
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x0000E26C File Offset: 0x0000C46C
		public IEnumerable<string> MetaMemberNames
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0000E26F File Offset: 0x0000C46F
		public IEnumerable<KeyValuePair<string, IMemberDescriptor>> MetaMembers
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0000E272 File Offset: 0x0000C472
		public IMemberDescriptor FindMetaMember(string memberName)
		{
			return null;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0000E275 File Offset: 0x0000C475
		public void RemoveMetaMember(string memberName)
		{
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0000E277 File Offset: 0x0000C477
		private void AddMemberTo(Dictionary<string, IMemberDescriptor> members, string name, IMemberDescriptor desc)
		{
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0000E279 File Offset: 0x0000C479
		public virtual DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0000E27C File Offset: 0x0000C47C
		private DynValue TryIndexOnExtMethod(Script script, object obj, string indexName)
		{
			return null;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0000E27F File Offset: 0x0000C47F
		public bool HasMember(string exactName)
		{
			return false;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0000E282 File Offset: 0x0000C482
		public bool HasMetaMember(string exactName)
		{
			return false;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0000E285 File Offset: 0x0000C485
		protected virtual DynValue TryIndex(Script script, object obj, string indexName)
		{
			return null;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0000E288 File Offset: 0x0000C488
		public virtual bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return false;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0000E28B File Offset: 0x0000C48B
		protected virtual bool TrySetIndex(Script script, object obj, string indexName, DynValue value)
		{
			return false;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0000E28E File Offset: 0x0000C48E
		void IOptimizableDescriptor.Optimize()
		{
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0000E290 File Offset: 0x0000C490
		protected static string Camelify(string name)
		{
			return null;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0000E293 File Offset: 0x0000C493
		protected static string UpperFirstLetter(string name)
		{
			return null;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0000E296 File Offset: 0x0000C496
		public virtual string AsString(object obj)
		{
			return null;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0000E299 File Offset: 0x0000C499
		protected virtual DynValue ExecuteIndexer(IMemberDescriptor mdesc, Script script, object obj, DynValue index, DynValue value)
		{
			return null;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0000E29C File Offset: 0x0000C49C
		public virtual DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0000E29F File Offset: 0x0000C49F
		private int PerformComparison(object obj, object p1, object p2)
		{
			return 0;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0000E2A2 File Offset: 0x0000C4A2
		private DynValue MultiDispatchLessThanOrEqual(Script script, object obj)
		{
			return null;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0000E2A5 File Offset: 0x0000C4A5
		private DynValue MultiDispatchLessThan(Script script, object obj)
		{
			return null;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0000E2A8 File Offset: 0x0000C4A8
		private DynValue TryDispatchLength(Script script, object obj)
		{
			return null;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0000E2AB File Offset: 0x0000C4AB
		private DynValue MultiDispatchEqual(Script script, object obj)
		{
			return null;
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0000E2AE File Offset: 0x0000C4AE
		private bool CheckEquality(object obj, object p1, object p2)
		{
			return false;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0000E2B1 File Offset: 0x0000C4B1
		private DynValue DispatchMetaOnMethod(Script script, object obj, string methodName)
		{
			return null;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
		private DynValue TryDispatchToNumber(Script script, object obj)
		{
			return null;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0000E2B7 File Offset: 0x0000C4B7
		private DynValue TryDispatchToBool(Script script, object obj)
		{
			return null;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0000E2BA File Offset: 0x0000C4BA
		public virtual bool IsTypeCompatible(Type type, object obj)
		{
			return false;
		}

		// Token: 0x040003A5 RID: 933
		private int m_ExtMethodsVersion;

		// Token: 0x040003A6 RID: 934
		private Dictionary<string, IMemberDescriptor> m_MetaMembers;

		// Token: 0x040003A7 RID: 935
		private Dictionary<string, IMemberDescriptor> m_Members;

		// Token: 0x040003A8 RID: 936
		protected const string SPECIALNAME_INDEXER_GET = "get_Item";

		// Token: 0x040003A9 RID: 937
		protected const string SPECIALNAME_INDEXER_SET = "set_Item";

		// Token: 0x040003AA RID: 938
		protected const string SPECIALNAME_CAST_EXPLICIT = "op_Explicit";

		// Token: 0x040003AB RID: 939
		protected const string SPECIALNAME_CAST_IMPLICIT = "op_Implicit";

		// Token: 0x040003AC RID: 940
		private string <Name>k__BackingField;

		// Token: 0x040003AD RID: 941
		private Type <Type>k__BackingField;

		// Token: 0x040003AE RID: 942
		private string <FriendlyName>k__BackingField;

		// Token: 0x020001C1 RID: 449
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x06001012 RID: 4114 RVA: 0x0000F660 File Offset: 0x0000D860
			internal DynValue <MultiDispatchLessThanOrEqual>b__0(ScriptExecutionContext context, CallbackArguments args)
			{
				return null;
			}

			// Token: 0x040006F5 RID: 1781
			public DispatchingUserDataDescriptor <>4__this;

			// Token: 0x040006F6 RID: 1782
			public object obj;
		}

		// Token: 0x020001C2 RID: 450
		private sealed class <>c__DisplayClass51_0
		{
			// Token: 0x06001014 RID: 4116 RVA: 0x0000F66B File Offset: 0x0000D86B
			internal DynValue <MultiDispatchLessThan>b__0(ScriptExecutionContext context, CallbackArguments args)
			{
				return null;
			}

			// Token: 0x040006F7 RID: 1783
			public DispatchingUserDataDescriptor <>4__this;

			// Token: 0x040006F8 RID: 1784
			public object obj;
		}

		// Token: 0x020001C3 RID: 451
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x06001016 RID: 4118 RVA: 0x0000F676 File Offset: 0x0000D876
			internal DynValue <MultiDispatchEqual>b__0(ScriptExecutionContext context, CallbackArguments args)
			{
				return null;
			}

			// Token: 0x040006F9 RID: 1785
			public DispatchingUserDataDescriptor <>4__this;

			// Token: 0x040006FA RID: 1786
			public object obj;
		}
	}
}
