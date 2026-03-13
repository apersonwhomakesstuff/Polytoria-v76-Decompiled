using System;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B8 RID: 184
	public class ValueTypeDefaultCtorMemberDescriptor : IOverloadableMemberDescriptor, IMemberDescriptor, IWireableDescriptor
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x0000DD7C File Offset: 0x0000BF7C
		public bool IsStatic
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0000DD7F File Offset: 0x0000BF7F
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x0000DD87 File Offset: 0x0000BF87
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

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0000DD90 File Offset: 0x0000BF90
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x0000DD98 File Offset: 0x0000BF98
		public Type ValueTypeDefaultCtor
		{
			get
			{
				return this.<ValueTypeDefaultCtor>k__BackingField;
			}
			private set
			{
				this.<ValueTypeDefaultCtor>k__BackingField = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0000DDA1 File Offset: 0x0000BFA1
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
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

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0000DDB2 File Offset: 0x0000BFB2
		public Type ExtensionMethodType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x0000DDB5 File Offset: 0x0000BFB5
		public Type VarArgsArrayType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		public Type VarArgsElementType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0000DDBB File Offset: 0x0000BFBB
		public ValueTypeDefaultCtorMemberDescriptor(Type valueType)
		{
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0000DDC3 File Offset: 0x0000BFC3
		public DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x0000DDC6 File Offset: 0x0000BFC6
		public string SortDiscriminant
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00010460 File Offset: 0x0000E660
		public MemberDescriptorAccess MemberAccess
		{
			get
			{
				return (MemberDescriptorAccess)0;
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0000DDC9 File Offset: 0x0000BFC9
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0000DDCC File Offset: 0x0000BFCC
		public void SetValue(Script script, object obj, DynValue value)
		{
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0000DDCE File Offset: 0x0000BFCE
		public void PrepareForWiring(Table t)
		{
		}

		// Token: 0x04000354 RID: 852
		private string <Name>k__BackingField;

		// Token: 0x04000355 RID: 853
		private Type <ValueTypeDefaultCtor>k__BackingField;

		// Token: 0x04000356 RID: 854
		private ParameterDescriptor[] <Parameters>k__BackingField;
	}
}
