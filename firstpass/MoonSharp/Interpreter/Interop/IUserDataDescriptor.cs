using System;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x0200009E RID: 158
	public interface IUserDataDescriptor
	{
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060007B7 RID: 1975
		string Name { get; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060007B8 RID: 1976
		Type Type { get; }

		// Token: 0x060007B9 RID: 1977
		DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing);

		// Token: 0x060007BA RID: 1978
		bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing);

		// Token: 0x060007BB RID: 1979
		string AsString(object obj);

		// Token: 0x060007BC RID: 1980
		DynValue MetaIndex(Script script, object obj, string metaname);

		// Token: 0x060007BD RID: 1981
		bool IsTypeCompatible(Type type, object obj);
	}
}
