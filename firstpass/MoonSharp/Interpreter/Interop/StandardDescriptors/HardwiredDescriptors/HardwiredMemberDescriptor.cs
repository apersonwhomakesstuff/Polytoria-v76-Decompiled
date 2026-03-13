using System;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors
{
	// Token: 0x020000C2 RID: 194
	public abstract class HardwiredMemberDescriptor : IMemberDescriptor
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x0000DF34 File Offset: 0x0000C134
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x0000DF3C File Offset: 0x0000C13C
		public Type MemberType
		{
			get
			{
				return this.<MemberType>k__BackingField;
			}
			private set
			{
				this.<MemberType>k__BackingField = value;
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0000DF45 File Offset: 0x0000C145
		protected HardwiredMemberDescriptor(Type memberType, string name, bool isStatic, MemberDescriptorAccess access)
		{
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0000DF4D File Offset: 0x0000C14D
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x0000DF55 File Offset: 0x0000C155
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

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x0000DF5E File Offset: 0x0000C15E
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x0000DF66 File Offset: 0x0000C166
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

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x0000DF6F File Offset: 0x0000C16F
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x0000DF77 File Offset: 0x0000C177
		public MemberDescriptorAccess MemberAccess
		{
			get
			{
				return this.<MemberAccess>k__BackingField;
			}
			private set
			{
				this.<MemberAccess>k__BackingField = value;
			}
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0000DF80 File Offset: 0x0000C180
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0000DF83 File Offset: 0x0000C183
		public void SetValue(Script script, object obj, DynValue value)
		{
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0000DF85 File Offset: 0x0000C185
		protected virtual object GetValueImpl(Script script, object obj)
		{
			return null;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0000DF88 File Offset: 0x0000C188
		protected virtual void SetValueImpl(Script script, object obj, object value)
		{
		}

		// Token: 0x04000375 RID: 885
		private Type <MemberType>k__BackingField;

		// Token: 0x04000376 RID: 886
		private bool <IsStatic>k__BackingField;

		// Token: 0x04000377 RID: 887
		private string <Name>k__BackingField;

		// Token: 0x04000378 RID: 888
		private MemberDescriptorAccess <MemberAccess>k__BackingField;
	}
}
