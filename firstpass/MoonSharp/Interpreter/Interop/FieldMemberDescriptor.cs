using System;
using System.Reflection;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B3 RID: 179
	public class FieldMemberDescriptor : IMemberDescriptor, IOptimizableDescriptor, IWireableDescriptor
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0000DB8C File Offset: 0x0000BD8C
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x0000DB94 File Offset: 0x0000BD94
		public FieldInfo FieldInfo
		{
			get
			{
				return this.<FieldInfo>k__BackingField;
			}
			private set
			{
				this.<FieldInfo>k__BackingField = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0000DB9D File Offset: 0x0000BD9D
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x0000DBA5 File Offset: 0x0000BDA5
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

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0000DBAE File Offset: 0x0000BDAE
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x0000DBB6 File Offset: 0x0000BDB6
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

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0000DBBF File Offset: 0x0000BDBF
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x0000DBC7 File Offset: 0x0000BDC7
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

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x0000DBD0 File Offset: 0x0000BDD0
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		public bool IsConst
		{
			get
			{
				return this.<IsConst>k__BackingField;
			}
			private set
			{
				this.<IsConst>k__BackingField = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x0000DBE1 File Offset: 0x0000BDE1
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x0000DBE9 File Offset: 0x0000BDE9
		public bool IsReadonly
		{
			get
			{
				return this.<IsReadonly>k__BackingField;
			}
			private set
			{
				this.<IsReadonly>k__BackingField = value;
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0000DBF2 File Offset: 0x0000BDF2
		public static FieldMemberDescriptor TryCreateIfVisible(FieldInfo fi, InteropAccessMode accessMode)
		{
			return null;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0000DBF5 File Offset: 0x0000BDF5
		public FieldMemberDescriptor(FieldInfo fi, InteropAccessMode accessMode)
		{
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0000DBFD File Offset: 0x0000BDFD
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0000DC00 File Offset: 0x0000BE00
		internal void OptimizeGetter()
		{
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0000DC02 File Offset: 0x0000BE02
		public void SetValue(Script script, object obj, DynValue v)
		{
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00010418 File Offset: 0x0000E618
		public MemberDescriptorAccess MemberAccess
		{
			get
			{
				return (MemberDescriptorAccess)0;
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0000DC04 File Offset: 0x0000BE04
		void IOptimizableDescriptor.Optimize()
		{
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0000DC06 File Offset: 0x0000BE06
		public void PrepareForWiring(Table t)
		{
		}

		// Token: 0x0400032E RID: 814
		private FieldInfo <FieldInfo>k__BackingField;

		// Token: 0x0400032F RID: 815
		private InteropAccessMode <AccessMode>k__BackingField;

		// Token: 0x04000330 RID: 816
		private bool <IsStatic>k__BackingField;

		// Token: 0x04000331 RID: 817
		private string <Name>k__BackingField;

		// Token: 0x04000332 RID: 818
		private bool <IsConst>k__BackingField;

		// Token: 0x04000333 RID: 819
		private bool <IsReadonly>k__BackingField;

		// Token: 0x04000334 RID: 820
		private object m_ConstValue;

		// Token: 0x04000335 RID: 821
		private Func<object, object> m_OptimizedGetter;
	}
}
