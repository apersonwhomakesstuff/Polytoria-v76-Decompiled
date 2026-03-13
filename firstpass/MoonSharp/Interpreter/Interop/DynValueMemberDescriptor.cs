using System;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000AE RID: 174
	public class DynValueMemberDescriptor : IMemberDescriptor, IWireableDescriptor
	{
		// Token: 0x06000805 RID: 2053 RVA: 0x0000DA16 File Offset: 0x0000BC16
		protected DynValueMemberDescriptor(string name, string serializedTableValue)
		{
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0000DA1E File Offset: 0x0000BC1E
		protected DynValueMemberDescriptor(string name)
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0000DA26 File Offset: 0x0000BC26
		public DynValueMemberDescriptor(string name, DynValue value)
		{
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x0000DA2E File Offset: 0x0000BC2E
		public bool IsStatic
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x0000DA31 File Offset: 0x0000BC31
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x0000DA39 File Offset: 0x0000BC39
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0000DA42 File Offset: 0x0000BC42
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x0000DA4A File Offset: 0x0000BC4A
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

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x0000DA53 File Offset: 0x0000BC53
		public virtual DynValue Value
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0000DA56 File Offset: 0x0000BC56
		public DynValue GetValue(Script script, object obj)
		{
			return null;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0000DA59 File Offset: 0x0000BC59
		public void SetValue(Script script, object obj, DynValue value)
		{
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0000DA5B File Offset: 0x0000BC5B
		public void PrepareForWiring(Table t)
		{
		}

		// Token: 0x04000318 RID: 792
		private DynValue m_Value;

		// Token: 0x04000319 RID: 793
		private string <Name>k__BackingField;

		// Token: 0x0400031A RID: 794
		private MemberDescriptorAccess <MemberAccess>k__BackingField;
	}
}
