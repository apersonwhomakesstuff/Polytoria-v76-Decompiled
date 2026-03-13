using System;
using System.Collections.Generic;
using System.Reflection;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000AF RID: 175
	public abstract class FunctionMemberDescriptorBase : IOverloadableMemberDescriptor, IMemberDescriptor
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x0000DA5D File Offset: 0x0000BC5D
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x0000DA65 File Offset: 0x0000BC65
		public bool IsStatic
		{
			get
			{
				return this.<IsStatic>k__BackingField;
			}
			private set
			{
				this.<IsStatic>k__BackingField = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x0000DA6E File Offset: 0x0000BC6E
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x0000DA76 File Offset: 0x0000BC76
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x0000DA7F File Offset: 0x0000BC7F
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x0000DA87 File Offset: 0x0000BC87
		public string SortDiscriminant
		{
			get
			{
				return this.<SortDiscriminant>k__BackingField;
			}
			private set
			{
				this.<SortDiscriminant>k__BackingField = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x0000DA90 File Offset: 0x0000BC90
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x0000DA98 File Offset: 0x0000BC98
		public ParameterDescriptor[] Parameters
		{
			get
			{
				return this.<Parameters>k__BackingField;
			}
			private set
			{
				this.<Parameters>k__BackingField = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x0000DAA1 File Offset: 0x0000BCA1
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x0000DAA9 File Offset: 0x0000BCA9
		public Type ExtensionMethodType
		{
			get
			{
				return this.<ExtensionMethodType>k__BackingField;
			}
			private set
			{
				this.<ExtensionMethodType>k__BackingField = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x0000DAB2 File Offset: 0x0000BCB2
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x0000DABA File Offset: 0x0000BCBA
		public Type VarArgsArrayType
		{
			get
			{
				return this.<VarArgsArrayType>k__BackingField;
			}
			private set
			{
				this.<VarArgsArrayType>k__BackingField = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x0000DAC3 File Offset: 0x0000BCC3
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x0000DACB File Offset: 0x0000BCCB
		public Type VarArgsElementType
		{
			get
			{
				return this.<VarArgsElementType>k__BackingField;
			}
			private set
			{
				this.<VarArgsElementType>k__BackingField = value;
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0000DAD4 File Offset: 0x0000BCD4
		protected void Initialize(string funcName, bool isStatic, ParameterDescriptor[] parameters, bool isExtensionMethod)
		{
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0000DAD6 File Offset: 0x0000BCD6
		public Func<ScriptExecutionContext, CallbackArguments, DynValue> GetCallback(Script script, object obj = null)
		{
			return null;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0000DAD9 File Offset: 0x0000BCD9
		public CallbackFunction GetCallbackFunction(Script script, object obj = null)
		{
			return null;
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0000DADC File Offset: 0x0000BCDC
		public DynValue GetCallbackAsDynValue(Script script, object obj = null)
		{
			return null;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0000DADF File Offset: 0x0000BCDF
		public static DynValue CreateCallbackDynValue(Script script, MethodInfo mi, object obj = null)
		{
			return null;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0000DAE2 File Offset: 0x0000BCE2
		protected virtual object[] BuildArgumentList(Script script, object obj, ScriptExecutionContext context, CallbackArguments args, out List<int> outParams)
		{
			outParams = null;
			return null;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0000DAE9 File Offset: 0x0000BCE9
		protected static DynValue BuildReturnValue(Script script, List<int> outParams, object[] pars, object retv)
		{
			return null;
		}

		// Token: 0x06000826 RID: 2086
		public abstract DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args);

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x000103E8 File Offset: 0x0000E5E8
		public MemberDescriptorAccess MemberAccess
		{
			get
			{
				return (MemberDescriptorAccess)0;
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0000DAEC File Offset: 0x0000BCEC
		public virtual DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0000DAEF File Offset: 0x0000BCEF
		public virtual void SetValue(Script script, object obj, DynValue v)
		{
		}

		// Token: 0x0400031B RID: 795
		private bool <IsStatic>k__BackingField;

		// Token: 0x0400031C RID: 796
		private string <Name>k__BackingField;

		// Token: 0x0400031D RID: 797
		private string <SortDiscriminant>k__BackingField;

		// Token: 0x0400031E RID: 798
		private ParameterDescriptor[] <Parameters>k__BackingField;

		// Token: 0x0400031F RID: 799
		private Type <ExtensionMethodType>k__BackingField;

		// Token: 0x04000320 RID: 800
		private Type <VarArgsArrayType>k__BackingField;

		// Token: 0x04000321 RID: 801
		private Type <VarArgsElementType>k__BackingField;

		// Token: 0x0200019A RID: 410
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000F61 RID: 3937 RVA: 0x0000F4BB File Offset: 0x0000D6BB
			internal string <Initialize>b__28_0(ParameterDescriptor pi)
			{
				return null;
			}

			// Token: 0x04000698 RID: 1688
			public static readonly FunctionMemberDescriptorBase.<>c <>9;

			// Token: 0x04000699 RID: 1689
			public static Func<ParameterDescriptor, string> <>9__28_0;
		}

		// Token: 0x0200019B RID: 411
		private sealed class <>c__DisplayClass29_0
		{
			// Token: 0x06000F63 RID: 3939 RVA: 0x0000F4C6 File Offset: 0x0000D6C6
			internal DynValue <GetCallback>b__0(ScriptExecutionContext c, CallbackArguments a)
			{
				return null;
			}

			// Token: 0x0400069A RID: 1690
			public FunctionMemberDescriptorBase <>4__this;

			// Token: 0x0400069B RID: 1691
			public Script script;

			// Token: 0x0400069C RID: 1692
			public object obj;
		}
	}
}
