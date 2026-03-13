using System;
using System.Collections.Generic;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter.Execution.VM
{
	// Token: 0x020000E6 RID: 230
	internal class ByteCode : RefIdObject
	{
		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0000E49C File Offset: 0x0000C69C
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x0000E4A4 File Offset: 0x0000C6A4
		public Script Script
		{
			get
			{
				return this.<Script>k__BackingField;
			}
			private set
			{
				this.<Script>k__BackingField = value;
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0000E4AD File Offset: 0x0000C6AD
		public ByteCode(Script script)
		{
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0000E4B5 File Offset: 0x0000C6B5
		public IDisposable EnterSource(SourceRef sref)
		{
			return null;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
		public void PushSourceRef(SourceRef sref)
		{
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0000E4BA File Offset: 0x0000C6BA
		public void PopSourceRef()
		{
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0000E4BC File Offset: 0x0000C6BC
		public void Dump(string file)
		{
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0000E4BE File Offset: 0x0000C6BE
		public int GetJumpPointForNextInstruction()
		{
			return 0;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0000E4C1 File Offset: 0x0000C6C1
		public int GetJumpPointForLastInstruction()
		{
			return 0;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0000E4C4 File Offset: 0x0000C6C4
		public Instruction GetLastInstruction()
		{
			return null;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0000E4C7 File Offset: 0x0000C6C7
		private Instruction AppendInstruction(Instruction c)
		{
			return null;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0000E4CA File Offset: 0x0000C6CA
		public Instruction Emit_Nop(string comment)
		{
			return null;
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0000E4CD File Offset: 0x0000C6CD
		public Instruction Emit_Invalid(string type)
		{
			return null;
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
		public Instruction Emit_Pop(int num = 1)
		{
			return null;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0000E4D3 File Offset: 0x0000C6D3
		public void Emit_Call(int argCount, string debugName)
		{
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0000E4D5 File Offset: 0x0000C6D5
		public void Emit_ThisCall(int argCount, string debugName)
		{
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0000E4D7 File Offset: 0x0000C6D7
		public Instruction Emit_Literal(DynValue value)
		{
			return null;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0000E4DA File Offset: 0x0000C6DA
		public Instruction Emit_Jump(OpCode jumpOpCode, int idx, int optPar = 0)
		{
			return null;
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0000E4DD File Offset: 0x0000C6DD
		public Instruction Emit_MkTuple(int cnt)
		{
			return null;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0000E4E0 File Offset: 0x0000C6E0
		public Instruction Emit_Operator(OpCode opcode)
		{
			return null;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0000E4E3 File Offset: 0x0000C6E3
		public void Emit_Debug(string str)
		{
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0000E4E5 File Offset: 0x0000C6E5
		public Instruction Emit_Enter(RuntimeScopeBlock runtimeScopeBlock)
		{
			return null;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0000E4E8 File Offset: 0x0000C6E8
		public Instruction Emit_Leave(RuntimeScopeBlock runtimeScopeBlock)
		{
			return null;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0000E4EB File Offset: 0x0000C6EB
		public Instruction Emit_Exit(RuntimeScopeBlock runtimeScopeBlock)
		{
			return null;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0000E4EE File Offset: 0x0000C6EE
		public Instruction Emit_Clean(RuntimeScopeBlock runtimeScopeBlock)
		{
			return null;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0000E4F1 File Offset: 0x0000C6F1
		public Instruction Emit_Closure(SymbolRef[] symbols, int jmpnum)
		{
			return null;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0000E4F4 File Offset: 0x0000C6F4
		public Instruction Emit_Args(SymbolRef[] symbols)
		{
			return null;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0000E4F7 File Offset: 0x0000C6F7
		public Instruction Emit_Ret(int retvals)
		{
			return null;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0000E4FA File Offset: 0x0000C6FA
		public Instruction Emit_ToNum(int stage = 0)
		{
			return null;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0000E4FD File Offset: 0x0000C6FD
		public Instruction Emit_Incr(int i)
		{
			return null;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0000E500 File Offset: 0x0000C700
		public Instruction Emit_NewTable(bool shared)
		{
			return null;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0000E503 File Offset: 0x0000C703
		public Instruction Emit_IterPrep()
		{
			return null;
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0000E506 File Offset: 0x0000C706
		public Instruction Emit_ExpTuple(int stackOffset)
		{
			return null;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0000E509 File Offset: 0x0000C709
		public Instruction Emit_IterUpd()
		{
			return null;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0000E50C File Offset: 0x0000C70C
		public Instruction Emit_Meta(string funcName, OpCodeMetadataType metaType, DynValue value = null)
		{
			return null;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0000E50F File Offset: 0x0000C70F
		public Instruction Emit_BeginFn(RuntimeScopeFrame stackFrame)
		{
			return null;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0000E512 File Offset: 0x0000C712
		public Instruction Emit_Scalar()
		{
			return null;
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0000E515 File Offset: 0x0000C715
		public int Emit_Load(SymbolRef sym)
		{
			return 0;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0000E518 File Offset: 0x0000C718
		public int Emit_Store(SymbolRef sym, int stackofs, int tupleidx)
		{
			return 0;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0000E51B File Offset: 0x0000C71B
		public Instruction Emit_TblInitN()
		{
			return null;
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0000E51E File Offset: 0x0000C71E
		public Instruction Emit_TblInitI(bool lastpos)
		{
			return null;
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0000E521 File Offset: 0x0000C721
		public Instruction Emit_Index(DynValue index = null, bool isNameIndex = false, bool isExpList = false)
		{
			return null;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0000E524 File Offset: 0x0000C724
		public Instruction Emit_IndexSet(int stackofs, int tupleidx, DynValue index = null, bool isNameIndex = false, bool isExpList = false)
		{
			return null;
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0000E527 File Offset: 0x0000C727
		public Instruction Emit_Copy(int numval)
		{
			return null;
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0000E52A File Offset: 0x0000C72A
		public Instruction Emit_Swap(int p1, int p2)
		{
			return null;
		}

		// Token: 0x040003D3 RID: 979
		public List<Instruction> Code;

		// Token: 0x040003D4 RID: 980
		private Script <Script>k__BackingField;

		// Token: 0x040003D5 RID: 981
		private List<SourceRef> m_SourceRefStack;

		// Token: 0x040003D6 RID: 982
		private SourceRef m_CurrentSourceRef;

		// Token: 0x040003D7 RID: 983
		internal LoopTracker LoopTracker;

		// Token: 0x020001C6 RID: 454
		private class SourceCodeStackGuard : IDisposable
		{
			// Token: 0x0600101C RID: 4124 RVA: 0x0000F691 File Offset: 0x0000D891
			public SourceCodeStackGuard(SourceRef sref, ByteCode bc)
			{
			}

			// Token: 0x0600101D RID: 4125 RVA: 0x0000F699 File Offset: 0x0000D899
			public void Dispose()
			{
			}

			// Token: 0x04000700 RID: 1792
			private ByteCode m_Bc;
		}
	}
}
