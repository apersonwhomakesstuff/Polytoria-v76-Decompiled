using System;
using System.Collections.Generic;
using System.IO;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000034 RID: 52
	public class SymbolRef
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00010250 File Offset: 0x0000E450
		public SymbolRefType Type
		{
			get
			{
				return SymbolRefType.Local;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0000CB2F File Offset: 0x0000AD2F
		public int Index
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0000CB32 File Offset: 0x0000AD32
		public string Name
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x0000CB35 File Offset: 0x0000AD35
		public SymbolRef Environment
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0000CB38 File Offset: 0x0000AD38
		public static SymbolRef DefaultEnv
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000CB3B File Offset: 0x0000AD3B
		public static SymbolRef Global(string name, SymbolRef envSymbol)
		{
			return null;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000CB3E File Offset: 0x0000AD3E
		internal static SymbolRef Local(string name, int index)
		{
			return null;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0000CB41 File Offset: 0x0000AD41
		internal static SymbolRef Upvalue(string name, int index)
		{
			return null;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000CB44 File Offset: 0x0000AD44
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0000CB47 File Offset: 0x0000AD47
		internal void WriteBinary(BinaryWriter bw)
		{
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000CB49 File Offset: 0x0000AD49
		internal static SymbolRef ReadBinary(BinaryReader br)
		{
			return null;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0000CB4C File Offset: 0x0000AD4C
		internal void WriteBinaryEnv(BinaryWriter bw, Dictionary<SymbolRef, int> symbolMap)
		{
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0000CB4E File Offset: 0x0000AD4E
		internal void ReadBinaryEnv(BinaryReader br, SymbolRef[] symbolRefs)
		{
		}

		// Token: 0x04000183 RID: 387
		private static SymbolRef s_DefaultEnv;

		// Token: 0x04000184 RID: 388
		internal SymbolRefType i_Type;

		// Token: 0x04000185 RID: 389
		internal SymbolRef i_Env;

		// Token: 0x04000186 RID: 390
		internal int i_Index;

		// Token: 0x04000187 RID: 391
		internal string i_Name;
	}
}
