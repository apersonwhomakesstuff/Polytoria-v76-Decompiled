using System;
using System.Collections.Generic;
using System.IO;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter.Execution.VM
{
	// Token: 0x020000EA RID: 234
	internal class Instruction
	{
		// Token: 0x06000A82 RID: 2690 RVA: 0x0000E53D File Offset: 0x0000C73D
		internal Instruction(SourceRef sourceref)
		{
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0000E545 File Offset: 0x0000C745
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0000E548 File Offset: 0x0000C748
		private string PurifyFromNewLines(DynValue Value)
		{
			return null;
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0000E54B File Offset: 0x0000C74B
		private string GenSpaces()
		{
			return null;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0000E54E File Offset: 0x0000C74E
		internal void WriteBinary(BinaryWriter wr, int baseAddress, Dictionary<SymbolRef, int> symbolMap)
		{
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0000E550 File Offset: 0x0000C750
		private static void WriteSymbol(BinaryWriter wr, SymbolRef symbolRef, Dictionary<SymbolRef, int> symbolMap)
		{
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0000E552 File Offset: 0x0000C752
		private static SymbolRef ReadSymbol(BinaryReader rd, SymbolRef[] deserializedSymbols)
		{
			return null;
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0000E555 File Offset: 0x0000C755
		internal static Instruction ReadBinary(SourceRef chunkRef, BinaryReader rd, int baseAddress, Table envTable, SymbolRef[] deserializedSymbols)
		{
			return null;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0000E558 File Offset: 0x0000C758
		private static DynValue ReadValue(BinaryReader rd, Table envTable)
		{
			return null;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0000E55B File Offset: 0x0000C75B
		private void DumpValue(BinaryWriter wr, DynValue value)
		{
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0000E55D File Offset: 0x0000C75D
		internal void GetSymbolReferences(out SymbolRef[] symbolList, out SymbolRef symbol)
		{
			symbolList = null;
			symbol = null;
		}

		// Token: 0x040003EF RID: 1007
		internal OpCode OpCode;

		// Token: 0x040003F0 RID: 1008
		internal SymbolRef Symbol;

		// Token: 0x040003F1 RID: 1009
		internal SymbolRef[] SymbolList;

		// Token: 0x040003F2 RID: 1010
		internal string Name;

		// Token: 0x040003F3 RID: 1011
		internal DynValue Value;

		// Token: 0x040003F4 RID: 1012
		internal int NumVal;

		// Token: 0x040003F5 RID: 1013
		internal int NumVal2;

		// Token: 0x040003F6 RID: 1014
		internal SourceRef SourceCodeRef;

		// Token: 0x020001C7 RID: 455
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001020 RID: 4128 RVA: 0x0000F6A5 File Offset: 0x0000D8A5
			internal string <ToString>b__9_0(SymbolRef s)
			{
				return null;
			}

			// Token: 0x04000701 RID: 1793
			public static readonly Instruction.<>c <>9;

			// Token: 0x04000702 RID: 1794
			public static Func<SymbolRef, string> <>9__9_0;
		}
	}
}
