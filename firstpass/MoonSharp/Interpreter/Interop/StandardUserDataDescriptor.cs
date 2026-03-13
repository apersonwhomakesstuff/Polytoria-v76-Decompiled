using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000BB RID: 187
	public class StandardUserDataDescriptor : DispatchingUserDataDescriptor, IWireableDescriptor
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0000DE9A File Offset: 0x0000C09A
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x0000DEA2 File Offset: 0x0000C0A2
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

		// Token: 0x060008E2 RID: 2274 RVA: 0x0000DEAB File Offset: 0x0000C0AB
		public StandardUserDataDescriptor(Type type, InteropAccessMode accessMode, string friendlyName = null) : base(null, null)
		{
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0000DEB5 File Offset: 0x0000C0B5
		private void FillMemberList()
		{
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0000DEB7 File Offset: 0x0000C0B7
		public void PrepareForWiring(Table t)
		{
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0000DEB9 File Offset: 0x0000C0B9
		private void Serialize(Table t, IEnumerable<KeyValuePair<string, IMemberDescriptor>> members)
		{
		}

		// Token: 0x04000361 RID: 865
		private InteropAccessMode <AccessMode>k__BackingField;

		// Token: 0x020001B9 RID: 441
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000FF5 RID: 4085 RVA: 0x0000F5EA File Offset: 0x0000D7EA
			internal string <FillMemberList>b__5_0(MoonSharpHideMemberAttribute a)
			{
				return null;
			}

			// Token: 0x040006D6 RID: 1750
			public static readonly StandardUserDataDescriptor.<>c <>9;

			// Token: 0x040006D7 RID: 1751
			public static Func<MoonSharpHideMemberAttribute, string> <>9__5_0;
		}
	}
}
