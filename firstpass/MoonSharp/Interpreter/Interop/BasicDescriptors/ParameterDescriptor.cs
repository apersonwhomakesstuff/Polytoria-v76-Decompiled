using System;
using System.Reflection;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	// Token: 0x020000DA RID: 218
	public sealed class ParameterDescriptor : IWireableDescriptor
	{
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0000E2D1 File Offset: 0x0000C4D1
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x0000E2D9 File Offset: 0x0000C4D9
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

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0000E2E2 File Offset: 0x0000C4E2
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x0000E2EA File Offset: 0x0000C4EA
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

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0000E2F3 File Offset: 0x0000C4F3
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x0000E2FB File Offset: 0x0000C4FB
		public bool HasDefaultValue
		{
			get
			{
				return this.<HasDefaultValue>k__BackingField;
			}
			private set
			{
				this.<HasDefaultValue>k__BackingField = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0000E304 File Offset: 0x0000C504
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x0000E30C File Offset: 0x0000C50C
		public object DefaultValue
		{
			get
			{
				return this.<DefaultValue>k__BackingField;
			}
			private set
			{
				this.<DefaultValue>k__BackingField = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0000E315 File Offset: 0x0000C515
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x0000E31D File Offset: 0x0000C51D
		public bool IsOut
		{
			get
			{
				return this.<IsOut>k__BackingField;
			}
			private set
			{
				this.<IsOut>k__BackingField = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0000E326 File Offset: 0x0000C526
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x0000E32E File Offset: 0x0000C52E
		public bool IsRef
		{
			get
			{
				return this.<IsRef>k__BackingField;
			}
			private set
			{
				this.<IsRef>k__BackingField = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0000E337 File Offset: 0x0000C537
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x0000E33F File Offset: 0x0000C53F
		public bool IsVarArgs
		{
			get
			{
				return this.<IsVarArgs>k__BackingField;
			}
			private set
			{
				this.<IsVarArgs>k__BackingField = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0000E348 File Offset: 0x0000C548
		public bool HasBeenRestricted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0000E34B File Offset: 0x0000C54B
		public Type OriginalType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0000E34E File Offset: 0x0000C54E
		public ParameterDescriptor(string name, Type type, bool hasDefaultValue = false, object defaultValue = null, bool isOut = false, bool isRef = false, bool isVarArgs = false)
		{
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0000E356 File Offset: 0x0000C556
		public ParameterDescriptor(string name, Type type, bool hasDefaultValue, object defaultValue, bool isOut, bool isRef, bool isVarArgs, Type typeRestriction)
		{
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0000E35E File Offset: 0x0000C55E
		public ParameterDescriptor(ParameterInfo pi)
		{
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0000E366 File Offset: 0x0000C566
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0000E369 File Offset: 0x0000C569
		public void RestrictType(Type type)
		{
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0000E36B File Offset: 0x0000C56B
		public void PrepareForWiring(Table table)
		{
		}

		// Token: 0x040003B3 RID: 947
		private string <Name>k__BackingField;

		// Token: 0x040003B4 RID: 948
		private Type <Type>k__BackingField;

		// Token: 0x040003B5 RID: 949
		private bool <HasDefaultValue>k__BackingField;

		// Token: 0x040003B6 RID: 950
		private object <DefaultValue>k__BackingField;

		// Token: 0x040003B7 RID: 951
		private bool <IsOut>k__BackingField;

		// Token: 0x040003B8 RID: 952
		private bool <IsRef>k__BackingField;

		// Token: 0x040003B9 RID: 953
		private bool <IsVarArgs>k__BackingField;

		// Token: 0x040003BA RID: 954
		private Type m_OriginalType;
	}
}
