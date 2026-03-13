using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B6 RID: 182
	public class OverloadedMethodMemberDescriptor : IOptimizableDescriptor, IMemberDescriptor, IWireableDescriptor
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0000DC9D File Offset: 0x0000BE9D
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x0000DCA5 File Offset: 0x0000BEA5
		public bool IgnoreExtensionMethods
		{
			get
			{
				return this.<IgnoreExtensionMethods>k__BackingField;
			}
			set
			{
				this.<IgnoreExtensionMethods>k__BackingField = value;
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0000DCAE File Offset: 0x0000BEAE
		public OverloadedMethodMemberDescriptor(string name, Type declaringType)
		{
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0000DCB6 File Offset: 0x0000BEB6
		public OverloadedMethodMemberDescriptor(string name, Type declaringType, IOverloadableMemberDescriptor descriptor)
		{
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0000DCBE File Offset: 0x0000BEBE
		public OverloadedMethodMemberDescriptor(string name, Type declaringType, IEnumerable<IOverloadableMemberDescriptor> descriptors)
		{
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0000DCC6 File Offset: 0x0000BEC6
		internal void SetExtensionMethodsSnapshot(int version, List<IOverloadableMemberDescriptor> extMethods)
		{
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x0000DCD0 File Offset: 0x0000BED0
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x0000DCD9 File Offset: 0x0000BED9
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x0000DCE1 File Offset: 0x0000BEE1
		public Type DeclaringType
		{
			get
			{
				return this.<DeclaringType>k__BackingField;
			}
			private set
			{
				this.<DeclaringType>k__BackingField = value;
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0000DCEA File Offset: 0x0000BEEA
		public void AddOverload(IOverloadableMemberDescriptor overload)
		{
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x0000DCEC File Offset: 0x0000BEEC
		public int OverloadCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0000DCEF File Offset: 0x0000BEEF
		private DynValue PerformOverloadedCall(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0000DCF2 File Offset: 0x0000BEF2
		private void Cache(bool hasObject, CallbackArguments args, IOverloadableMemberDescriptor bestOverload)
		{
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		private bool CheckMatch(bool hasObject, CallbackArguments args, OverloadedMethodMemberDescriptor.OverloadCacheItem overloadCacheItem)
		{
			return false;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0000DCF7 File Offset: 0x0000BEF7
		private int CalcScoreForOverload(ScriptExecutionContext context, CallbackArguments args, IOverloadableMemberDescriptor method, bool isExtMethod)
		{
			return 0;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0000DCFA File Offset: 0x0000BEFA
		private static int CalcScoreForSingleArgument(ParameterDescriptor desc, Type parameterType, DynValue arg, bool isOptional)
		{
			return 0;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0000DCFD File Offset: 0x0000BEFD
		public Func<ScriptExecutionContext, CallbackArguments, DynValue> GetCallback(Script script, object obj)
		{
			return null;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0000DD00 File Offset: 0x0000BF00
		void IOptimizableDescriptor.Optimize()
		{
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0000DD02 File Offset: 0x0000BF02
		public CallbackFunction GetCallbackFunction(Script script, object obj = null)
		{
			return null;
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x0000DD05 File Offset: 0x0000BF05
		public bool IsStatic
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00010430 File Offset: 0x0000E630
		public MemberDescriptorAccess MemberAccess
		{
			get
			{
				return (MemberDescriptorAccess)0;
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0000DD08 File Offset: 0x0000BF08
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0000DD0B File Offset: 0x0000BF0B
		public void SetValue(Script script, object obj, DynValue value)
		{
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0000DD0D File Offset: 0x0000BF0D
		public void PrepareForWiring(Table t)
		{
		}

		// Token: 0x04000342 RID: 834
		private const int CACHE_SIZE = 5;

		// Token: 0x04000343 RID: 835
		private List<IOverloadableMemberDescriptor> m_Overloads;

		// Token: 0x04000344 RID: 836
		private List<IOverloadableMemberDescriptor> m_ExtOverloads;

		// Token: 0x04000345 RID: 837
		private bool m_Unsorted;

		// Token: 0x04000346 RID: 838
		private OverloadedMethodMemberDescriptor.OverloadCacheItem[] m_Cache;

		// Token: 0x04000347 RID: 839
		private int m_CacheHits;

		// Token: 0x04000348 RID: 840
		private int m_ExtensionMethodVersion;

		// Token: 0x04000349 RID: 841
		private bool <IgnoreExtensionMethods>k__BackingField;

		// Token: 0x0400034A RID: 842
		private string <Name>k__BackingField;

		// Token: 0x0400034B RID: 843
		private Type <DeclaringType>k__BackingField;

		// Token: 0x020001B2 RID: 434
		private class OverloadableMemberDescriptorComparer : IComparer<IOverloadableMemberDescriptor>
		{
			// Token: 0x06000FC9 RID: 4041 RVA: 0x0000F531 File Offset: 0x0000D731
			public int Compare(IOverloadableMemberDescriptor x, IOverloadableMemberDescriptor y)
			{
				return 0;
			}
		}

		// Token: 0x020001B3 RID: 435
		private class OverloadCacheItem
		{
			// Token: 0x040006AB RID: 1707
			public bool HasObject;

			// Token: 0x040006AC RID: 1708
			public IOverloadableMemberDescriptor Method;

			// Token: 0x040006AD RID: 1709
			public List<DataType> ArgsDataType;

			// Token: 0x040006AE RID: 1710
			public List<Type> ArgsUserDataType;

			// Token: 0x040006AF RID: 1711
			public int HitIndexAtLastHit;
		}

		// Token: 0x020001B4 RID: 436
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000FCE RID: 4046 RVA: 0x0000F54E File Offset: 0x0000D74E
			internal bool <get_IsStatic>b__37_0(IOverloadableMemberDescriptor o)
			{
				return false;
			}

			// Token: 0x040006B0 RID: 1712
			public static readonly OverloadedMethodMemberDescriptor.<>c <>9;

			// Token: 0x040006B1 RID: 1713
			public static Func<IOverloadableMemberDescriptor, bool> <>9__37_0;
		}

		// Token: 0x020001B5 RID: 437
		private sealed class <>c__DisplayClass33_0
		{
			// Token: 0x06000FD0 RID: 4048 RVA: 0x0000F559 File Offset: 0x0000D759
			internal DynValue <GetCallback>b__0(ScriptExecutionContext context, CallbackArguments args)
			{
				return null;
			}

			// Token: 0x040006B2 RID: 1714
			public OverloadedMethodMemberDescriptor <>4__this;

			// Token: 0x040006B3 RID: 1715
			public Script script;

			// Token: 0x040006B4 RID: 1716
			public object obj;
		}
	}
}
