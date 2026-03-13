using System;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000BA RID: 186
	public class StandardGenericsUserDataDescriptor : IUserDataDescriptor, IGeneratorUserDataDescriptor
	{
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x0000DE4D File Offset: 0x0000C04D
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x0000DE55 File Offset: 0x0000C055
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

		// Token: 0x060008D5 RID: 2261 RVA: 0x0000DE5E File Offset: 0x0000C05E
		public StandardGenericsUserDataDescriptor(Type type, InteropAccessMode accessMode)
		{
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0000DE66 File Offset: 0x0000C066
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x0000DE6E File Offset: 0x0000C06E
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

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0000DE77 File Offset: 0x0000C077
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x0000DE7F File Offset: 0x0000C07F
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

		// Token: 0x060008DA RID: 2266 RVA: 0x0000DE88 File Offset: 0x0000C088
		public DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing)
		{
			return null;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0000DE8B File Offset: 0x0000C08B
		public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing)
		{
			return false;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0000DE8E File Offset: 0x0000C08E
		public string AsString(object obj)
		{
			return null;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0000DE91 File Offset: 0x0000C091
		public DynValue MetaIndex(Script script, object obj, string metaname)
		{
			return null;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0000DE94 File Offset: 0x0000C094
		public bool IsTypeCompatible(Type type, object obj)
		{
			return false;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0000DE97 File Offset: 0x0000C097
		public IUserDataDescriptor Generate(Type type)
		{
			return null;
		}

		// Token: 0x0400035E RID: 862
		private InteropAccessMode <AccessMode>k__BackingField;

		// Token: 0x0400035F RID: 863
		private string <Name>k__BackingField;

		// Token: 0x04000360 RID: 864
		private Type <Type>k__BackingField;
	}
}
