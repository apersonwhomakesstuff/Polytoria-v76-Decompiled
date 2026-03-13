using System;
using System.Reflection;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B5 RID: 181
	public class MethodMemberDescriptor : FunctionMemberDescriptorBase, IOptimizableDescriptor, IWireableDescriptor
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0000DC55 File Offset: 0x0000BE55
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x0000DC5D File Offset: 0x0000BE5D
		public MethodBase MethodInfo
		{
			get
			{
				return this.<MethodInfo>k__BackingField;
			}
			private set
			{
				this.<MethodInfo>k__BackingField = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0000DC66 File Offset: 0x0000BE66
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x0000DC6E File Offset: 0x0000BE6E
		public InteropAccessMode AccessMode
		{
			get
			{
				return this.<AccessMode>k__BackingField;
			}
			private set
			{
				this.<AccessMode>k__BackingField = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0000DC77 File Offset: 0x0000BE77
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x0000DC7F File Offset: 0x0000BE7F
		public bool IsConstructor
		{
			get
			{
				return this.<IsConstructor>k__BackingField;
			}
			private set
			{
				this.<IsConstructor>k__BackingField = value;
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0000DC88 File Offset: 0x0000BE88
		public MethodMemberDescriptor(MethodBase methodBase, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0000DC90 File Offset: 0x0000BE90
		public static MethodMemberDescriptor TryCreateIfVisible(MethodBase methodBase, InteropAccessMode accessMode, bool forceVisibility = false)
		{
			return null;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0000DC93 File Offset: 0x0000BE93
		public static bool CheckMethodIsCompatible(MethodBase methodBase, bool throwException)
		{
			return false;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0000DC96 File Offset: 0x0000BE96
		public override DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0000DC99 File Offset: 0x0000BE99
		void IOptimizableDescriptor.Optimize()
		{
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0000DC9B File Offset: 0x0000BE9B
		public void PrepareForWiring(Table t)
		{
		}

		// Token: 0x0400033B RID: 827
		private MethodBase <MethodInfo>k__BackingField;

		// Token: 0x0400033C RID: 828
		private InteropAccessMode <AccessMode>k__BackingField;

		// Token: 0x0400033D RID: 829
		private bool <IsConstructor>k__BackingField;

		// Token: 0x0400033E RID: 830
		private Func<object, object[], object> m_OptimizedFunc;

		// Token: 0x0400033F RID: 831
		private Action<object, object[]> m_OptimizedAction;

		// Token: 0x04000340 RID: 832
		private bool m_IsAction;

		// Token: 0x04000341 RID: 833
		private bool m_IsArrayCtor;

		// Token: 0x020001B1 RID: 433
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000FC6 RID: 4038 RVA: 0x0000F528 File Offset: 0x0000D728
			internal ParameterDescriptor <.ctor>b__16_0(ParameterInfo pi)
			{
				return null;
			}

			// Token: 0x06000FC7 RID: 4039 RVA: 0x0000F52B File Offset: 0x0000D72B
			internal bool <.ctor>b__16_1(ParameterDescriptor p)
			{
				return false;
			}

			// Token: 0x06000FC8 RID: 4040 RVA: 0x0000F52E File Offset: 0x0000D72E
			internal bool <CheckMethodIsCompatible>b__18_0(ParameterInfo p)
			{
				return false;
			}

			// Token: 0x040006A7 RID: 1703
			public static readonly MethodMemberDescriptor.<>c <>9;

			// Token: 0x040006A8 RID: 1704
			public static Func<ParameterInfo, ParameterDescriptor> <>9__16_0;

			// Token: 0x040006A9 RID: 1705
			public static Func<ParameterDescriptor, bool> <>9__16_1;

			// Token: 0x040006AA RID: 1706
			public static Func<ParameterInfo, bool> <>9__18_0;
		}
	}
}
