using System;
using System.Collections.Generic;
using System.Reflection;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B4 RID: 180
	public class GenericMethodMemberDescriptor : FunctionMemberDescriptorBase, IWireableDescriptor
	{
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0000DC08 File Offset: 0x0000BE08
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x0000DC10 File Offset: 0x0000BE10
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

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x0000DC19 File Offset: 0x0000BE19
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x0000DC21 File Offset: 0x0000BE21
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

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x0000DC2A File Offset: 0x0000BE2A
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x0000DC32 File Offset: 0x0000BE32
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

		// Token: 0x06000865 RID: 2149 RVA: 0x0000DC3B File Offset: 0x0000BE3B
		public GenericMethodMemberDescriptor(MethodBase methodBase, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0000DC43 File Offset: 0x0000BE43
		public static GenericMethodMemberDescriptor TryCreateIfVisible(MethodBase methodBase, InteropAccessMode accessMode, bool forceVisibility = false)
		{
			return null;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0000DC46 File Offset: 0x0000BE46
		public static bool CheckMethodIsCompatible(MethodBase methodBase, bool throwException)
		{
			return false;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0000DC49 File Offset: 0x0000BE49
		public override DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0000DC4C File Offset: 0x0000BE4C
		protected override object[] BuildArgumentList(Script script, object obj, ScriptExecutionContext context, CallbackArguments args, out List<int> outParams)
		{
			outParams = null;
			return null;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0000DC53 File Offset: 0x0000BE53
		public void PrepareForWiring(Table t)
		{
		}

		// Token: 0x04000336 RID: 822
		private MethodBase <MethodInfo>k__BackingField;

		// Token: 0x04000337 RID: 823
		private InteropAccessMode <AccessMode>k__BackingField;

		// Token: 0x04000338 RID: 824
		private bool <IsConstructor>k__BackingField;

		// Token: 0x04000339 RID: 825
		private bool m_IsAction;

		// Token: 0x0400033A RID: 826
		private bool m_IsArrayCtor;

		// Token: 0x020001B0 RID: 432
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000FC1 RID: 4033 RVA: 0x0000F515 File Offset: 0x0000D715
			internal ParameterDescriptor <.ctor>b__14_0(ParameterInfo pi)
			{
				return null;
			}

			// Token: 0x06000FC2 RID: 4034 RVA: 0x0000F518 File Offset: 0x0000D718
			internal bool <.ctor>b__14_1(ParameterDescriptor p)
			{
				return false;
			}

			// Token: 0x06000FC3 RID: 4035 RVA: 0x0000F51B File Offset: 0x0000D71B
			internal bool <CheckMethodIsCompatible>b__16_0(ParameterInfo p)
			{
				return false;
			}

			// Token: 0x040006A3 RID: 1699
			public static readonly GenericMethodMemberDescriptor.<>c <>9;

			// Token: 0x040006A4 RID: 1700
			public static Func<ParameterInfo, ParameterDescriptor> <>9__14_0;

			// Token: 0x040006A5 RID: 1701
			public static Func<ParameterDescriptor, bool> <>9__14_1;

			// Token: 0x040006A6 RID: 1702
			public static Func<ParameterInfo, bool> <>9__16_0;
		}
	}
}
