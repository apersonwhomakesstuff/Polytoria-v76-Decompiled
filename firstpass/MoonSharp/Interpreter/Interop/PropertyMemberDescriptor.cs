using System;
using System.Reflection;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000B7 RID: 183
	public class PropertyMemberDescriptor : IMemberDescriptor, IOptimizableDescriptor, IWireableDescriptor
	{
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x0000DD0F File Offset: 0x0000BF0F
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x0000DD17 File Offset: 0x0000BF17
		public PropertyInfo PropertyInfo
		{
			get
			{
				return this.<PropertyInfo>k__BackingField;
			}
			private set
			{
				this.<PropertyInfo>k__BackingField = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x0000DD20 File Offset: 0x0000BF20
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x0000DD28 File Offset: 0x0000BF28
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x0000DD31 File Offset: 0x0000BF31
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x0000DD39 File Offset: 0x0000BF39
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

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0000DD42 File Offset: 0x0000BF42
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x0000DD4A File Offset: 0x0000BF4A
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

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x0000DD53 File Offset: 0x0000BF53
		public bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x0000DD56 File Offset: 0x0000BF56
		public bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0000DD59 File Offset: 0x0000BF59
		public static PropertyMemberDescriptor TryCreateIfVisible(PropertyInfo pi, InteropAccessMode accessMode)
		{
			return null;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0000DD5C File Offset: 0x0000BF5C
		private static PropertyMemberDescriptor TryCreate(PropertyInfo pi, InteropAccessMode accessMode, MethodInfo getter, MethodInfo setter)
		{
			return null;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0000DD5F File Offset: 0x0000BF5F
		public PropertyMemberDescriptor(PropertyInfo pi, InteropAccessMode accessMode)
		{
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0000DD67 File Offset: 0x0000BF67
		public PropertyMemberDescriptor(PropertyInfo pi, InteropAccessMode accessMode, MethodInfo getter, MethodInfo setter)
		{
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0000DD6F File Offset: 0x0000BF6F
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0000DD72 File Offset: 0x0000BF72
		internal void OptimizeGetter()
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0000DD74 File Offset: 0x0000BF74
		internal void OptimizeSetter()
		{
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0000DD76 File Offset: 0x0000BF76
		public void SetValue(Script script, object obj, DynValue v)
		{
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00010448 File Offset: 0x0000E648
		public MemberDescriptorAccess MemberAccess
		{
			get
			{
				return (MemberDescriptorAccess)0;
			}
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0000DD78 File Offset: 0x0000BF78
		void IOptimizableDescriptor.Optimize()
		{
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0000DD7A File Offset: 0x0000BF7A
		public void PrepareForWiring(Table t)
		{
		}

		// Token: 0x0400034C RID: 844
		private PropertyInfo <PropertyInfo>k__BackingField;

		// Token: 0x0400034D RID: 845
		private InteropAccessMode <AccessMode>k__BackingField;

		// Token: 0x0400034E RID: 846
		private bool <IsStatic>k__BackingField;

		// Token: 0x0400034F RID: 847
		private string <Name>k__BackingField;

		// Token: 0x04000350 RID: 848
		private MethodInfo m_Getter;

		// Token: 0x04000351 RID: 849
		private MethodInfo m_Setter;

		// Token: 0x04000352 RID: 850
		private Func<object, object> m_OptimizedGetter;

		// Token: 0x04000353 RID: 851
		private Action<object, object> m_OptimizedSetter;
	}
}
