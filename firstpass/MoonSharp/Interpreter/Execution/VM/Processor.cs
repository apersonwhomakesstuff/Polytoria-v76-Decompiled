using System;
using System.Collections.Generic;
using System.IO;
using MoonSharp.Interpreter.DataStructs;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.Interpreter.Execution.VM
{
	// Token: 0x020000ED RID: 237
	internal sealed class Processor
	{
		// Token: 0x06000A8D RID: 2701 RVA: 0x0000E565 File Offset: 0x0000C765
		public Processor(Script script, Table globalContext, ByteCode byteCode)
		{
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0000E56D File Offset: 0x0000C76D
		private Processor(Processor parentProcessor)
		{
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0000E575 File Offset: 0x0000C775
		internal Processor(Processor parentProcessor, Processor recycleProcessor)
		{
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0000E57D File Offset: 0x0000C77D
		public DynValue Call(DynValue function, DynValue[] args)
		{
			return null;
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0000E580 File Offset: 0x0000C780
		private int PushClrToScriptStackFrame(CallStackItemFlags flags, DynValue function, DynValue[] args)
		{
			return 0;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0000E583 File Offset: 0x0000C783
		private void LeaveProcessor()
		{
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0000E585 File Offset: 0x0000C785
		private int GetThreadId()
		{
			return 0;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0000E588 File Offset: 0x0000C788
		private void EnterProcessor()
		{
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0000E58A File Offset: 0x0000C78A
		internal SourceRef GetCoroutineSuspendedLocation()
		{
			return null;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0000E58D File Offset: 0x0000C78D
		internal static bool IsDumpStream(Stream stream)
		{
			return false;
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0000E590 File Offset: 0x0000C790
		internal int Dump(Stream stream, int baseAddress, bool hasUpvalues)
		{
			return 0;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0000E593 File Offset: 0x0000C793
		private void AddSymbolToMap(Dictionary<SymbolRef, int> symbolMap, SymbolRef s)
		{
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0000E595 File Offset: 0x0000C795
		internal int Undump(Stream stream, int sourceID, Table envTable, out bool hasUpvalues)
		{
			hasUpvalues = default(bool);
			return 0;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
		public DynValue Coroutine_Create(Closure closure)
		{
			return null;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0000E5A3 File Offset: 0x0000C7A3
		public DynValue Coroutine_Recycle(Processor mainProcessor, Closure closure)
		{
			return null;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x000104D8 File Offset: 0x0000E6D8
		public CoroutineState State
		{
			get
			{
				return CoroutineState.Main;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0000E5A6 File Offset: 0x0000C7A6
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x0000E5AE File Offset: 0x0000C7AE
		public Coroutine AssociatedCoroutine
		{
			get
			{
				return this.<AssociatedCoroutine>k__BackingField;
			}
			set
			{
				this.<AssociatedCoroutine>k__BackingField = value;
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0000E5B7 File Offset: 0x0000C7B7
		public DynValue Coroutine_Resume(DynValue[] args)
		{
			return null;
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0000E5BA File Offset: 0x0000C7BA
		internal Instruction FindMeta(ref int baseAddress)
		{
			return null;
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0000E5BD File Offset: 0x0000C7BD
		internal void AttachDebugger(IDebugger debugger)
		{
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0000E5BF File Offset: 0x0000C7BF
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x0000E5C2 File Offset: 0x0000C7C2
		internal bool DebuggerEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0000E5C4 File Offset: 0x0000C7C4
		private void ListenDebugger(Instruction instr, int instructionPtr)
		{
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0000E5C6 File Offset: 0x0000C7C6
		private void ResetBreakPoints(DebuggerAction action)
		{
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		internal HashSet<int> ResetBreakPoints(SourceCode src, HashSet<int> lines)
		{
			return null;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0000E5CB File Offset: 0x0000C7CB
		private bool ToggleBreakPoint(DebuggerAction action, bool? state)
		{
			return false;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0000E5CE File Offset: 0x0000C7CE
		private void RefreshDebugger(bool hard, int instructionPtr)
		{
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0000E5D0 File Offset: 0x0000C7D0
		private List<WatchItem> Debugger_RefreshThreads(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0000E5D3 File Offset: 0x0000C7D3
		private List<WatchItem> Debugger_RefreshVStack()
		{
			return null;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0000E5D6 File Offset: 0x0000C7D6
		private List<WatchItem> Debugger_RefreshWatches(ScriptExecutionContext context, List<DynamicExpression> watchList)
		{
			return null;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0000E5D9 File Offset: 0x0000C7D9
		private List<WatchItem> Debugger_RefreshLocals(ScriptExecutionContext context)
		{
			return null;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0000E5DC File Offset: 0x0000C7DC
		private WatchItem Debugger_RefreshWatch(ScriptExecutionContext context, DynamicExpression dynExpr)
		{
			return null;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0000E5DF File Offset: 0x0000C7DF
		internal List<WatchItem> Debugger_GetCallStack(SourceRef startingRef)
		{
			return null;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0000E5E2 File Offset: 0x0000C7E2
		private SourceRef GetCurrentSourceRef(int instructionPtr)
		{
			return null;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0000E5E5 File Offset: 0x0000C7E5
		private void FillDebugData(InterpreterException ex, int ip)
		{
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0000E5E7 File Offset: 0x0000C7E7
		internal Table GetMetatable(DynValue value)
		{
			return null;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0000E5EA File Offset: 0x0000C7EA
		internal DynValue GetBinaryMetamethod(DynValue op1, DynValue op2, string eventName)
		{
			return null;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0000E5ED File Offset: 0x0000C7ED
		internal DynValue GetMetamethod(DynValue value, string metamethod)
		{
			return null;
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0000E5F0 File Offset: 0x0000C7F0
		internal DynValue GetMetamethodRaw(DynValue value, string metamethod)
		{
			return null;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0000E5F3 File Offset: 0x0000C7F3
		internal Script GetScript()
		{
			return null;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0000E5F6 File Offset: 0x0000C7F6
		private DynValue Processing_Loop(int instructionPtr)
		{
			return null;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0000E5F9 File Offset: 0x0000C7F9
		internal string PerformMessageDecorationBeforeUnwind(DynValue messageHandler, string decoratedMessage, SourceRef sourceRef)
		{
			return null;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0000E5FC File Offset: 0x0000C7FC
		private void AssignLocal(SymbolRef symref, DynValue value)
		{
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0000E5FE File Offset: 0x0000C7FE
		private void ExecStoreLcl(Instruction i)
		{
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0000E600 File Offset: 0x0000C800
		private void ExecStoreUpv(Instruction i)
		{
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0000E602 File Offset: 0x0000C802
		private void ExecSwap(Instruction i)
		{
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0000E604 File Offset: 0x0000C804
		private DynValue GetStoreValue(Instruction i)
		{
			return null;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0000E607 File Offset: 0x0000C807
		private void ExecClosure(Instruction i)
		{
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0000E609 File Offset: 0x0000C809
		private DynValue GetUpvalueSymbol(SymbolRef s)
		{
			return null;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0000E60C File Offset: 0x0000C80C
		private void ExecMkTuple(Instruction i)
		{
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0000E60E File Offset: 0x0000C80E
		private void ExecToNum(Instruction i)
		{
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0000E610 File Offset: 0x0000C810
		private void ExecIterUpd(Instruction i)
		{
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0000E612 File Offset: 0x0000C812
		private void ExecExpTuple(Instruction i)
		{
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0000E614 File Offset: 0x0000C814
		private void ExecIterPrep(Instruction i)
		{
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0000E616 File Offset: 0x0000C816
		private int ExecJFor(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0000E619 File Offset: 0x0000C819
		private void ExecIncr(Instruction i)
		{
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0000E61B File Offset: 0x0000C81B
		private void ExecCNot(Instruction i)
		{
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0000E61D File Offset: 0x0000C81D
		private void ExecNot(Instruction i)
		{
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0000E61F File Offset: 0x0000C81F
		private void ExecBeginFn(Instruction i)
		{
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0000E621 File Offset: 0x0000C821
		private CallStackItem PopToBasePointer()
		{
			return null;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0000E624 File Offset: 0x0000C824
		private int PopExecStackAndCheckVStack(int vstackguard)
		{
			return 0;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0000E627 File Offset: 0x0000C827
		private IList<DynValue> CreateArgsListForFunctionCall(int numargs, int offsFromTop)
		{
			return null;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0000E62A File Offset: 0x0000C82A
		private void ExecArgs(Instruction I)
		{
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0000E62C File Offset: 0x0000C82C
		private int Internal_ExecCall(int argsCount, int instructionPtr, CallbackFunction handler = null, CallbackFunction continuation = null, bool thisCall = false, string debugText = null, DynValue unwindHandler = null)
		{
			return 0;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0000E62F File Offset: 0x0000C82F
		private int PerformTCO(int instructionPtr, int argsCount)
		{
			return 0;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0000E632 File Offset: 0x0000C832
		private int ExecRet(Instruction i)
		{
			return 0;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0000E635 File Offset: 0x0000C835
		private int Internal_CheckForTailRequests(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0000E638 File Offset: 0x0000C838
		private int JumpBool(Instruction i, bool expectedValueForJump, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0000E63B File Offset: 0x0000C83B
		private int ExecShortCircuitingOperator(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0000E63E File Offset: 0x0000C83E
		private int ExecAdd(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0000E641 File Offset: 0x0000C841
		private int ExecSub(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0000E644 File Offset: 0x0000C844
		private int ExecMul(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0000E647 File Offset: 0x0000C847
		private int ExecMod(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0000E64A File Offset: 0x0000C84A
		private int ExecDiv(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0000E64D File Offset: 0x0000C84D
		private int ExecPower(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0000E650 File Offset: 0x0000C850
		private int ExecNeg(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0000E653 File Offset: 0x0000C853
		private int ExecEq(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0000E656 File Offset: 0x0000C856
		private int ExecLess(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0000E659 File Offset: 0x0000C859
		private int ExecLessEq(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0000E65C File Offset: 0x0000C85C
		private int ExecLen(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0000E65F File Offset: 0x0000C85F
		private int ExecConcat(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0000E662 File Offset: 0x0000C862
		private void ExecTblInitI(Instruction i)
		{
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0000E664 File Offset: 0x0000C864
		private void ExecTblInitN(Instruction i)
		{
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0000E666 File Offset: 0x0000C866
		private int ExecIndexSet(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0000E669 File Offset: 0x0000C869
		private int ExecIndex(Instruction i, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0000E66C File Offset: 0x0000C86C
		private void ClearBlockData(Instruction I)
		{
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0000E66E File Offset: 0x0000C86E
		public DynValue GetGenericSymbol(SymbolRef symref)
		{
			return null;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0000E671 File Offset: 0x0000C871
		private DynValue GetGlobalSymbol(DynValue dynValue, string name)
		{
			return null;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0000E674 File Offset: 0x0000C874
		private void SetGlobalSymbol(DynValue dynValue, string name, DynValue value)
		{
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0000E676 File Offset: 0x0000C876
		public void AssignGenericSymbol(SymbolRef symref, DynValue value)
		{
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0000E678 File Offset: 0x0000C878
		private CallStackItem GetTopNonClrFunction()
		{
			return null;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0000E67B File Offset: 0x0000C87B
		public SymbolRef FindSymbolByName(string name)
		{
			return null;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0000E67E File Offset: 0x0000C87E
		private DynValue[] Internal_AdjustTuple(IList<DynValue> values)
		{
			return null;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0000E681 File Offset: 0x0000C881
		private int Internal_InvokeUnaryMetaMethod(DynValue op1, string eventName, int instructionPtr)
		{
			return 0;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0000E684 File Offset: 0x0000C884
		private int Internal_InvokeBinaryMetaMethod(DynValue l, DynValue r, string eventName, int instructionPtr, DynValue extraPush = null)
		{
			return 0;
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0000E687 File Offset: 0x0000C887
		private DynValue[] StackTopToArray(int items, bool pop)
		{
			return null;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0000E68A File Offset: 0x0000C88A
		private DynValue[] StackTopToArrayReverse(int items, bool pop)
		{
			return null;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0000E68D File Offset: 0x0000C88D
		private DynValue <ExecClosure>b__71_0(SymbolRef s)
		{
			return null;
		}

		// Token: 0x04000433 RID: 1075
		private const int STACK_SIZE = 131072;

		// Token: 0x04000434 RID: 1076
		private ByteCode m_RootChunk;

		// Token: 0x04000435 RID: 1077
		private FastStack<DynValue> m_ValueStack;

		// Token: 0x04000436 RID: 1078
		private FastStack<CallStackItem> m_ExecutionStack;

		// Token: 0x04000437 RID: 1079
		private List<Processor> m_CoroutinesStack;

		// Token: 0x04000438 RID: 1080
		private Table m_GlobalTable;

		// Token: 0x04000439 RID: 1081
		private Script m_Script;

		// Token: 0x0400043A RID: 1082
		private Processor m_Parent;

		// Token: 0x0400043B RID: 1083
		private CoroutineState m_State;

		// Token: 0x0400043C RID: 1084
		private bool m_CanYield;

		// Token: 0x0400043D RID: 1085
		private int m_SavedInstructionPtr;

		// Token: 0x0400043E RID: 1086
		private Processor.DebugContext m_Debug;

		// Token: 0x0400043F RID: 1087
		private int m_OwningThreadID;

		// Token: 0x04000440 RID: 1088
		private int m_ExecutionNesting;

		// Token: 0x04000441 RID: 1089
		private const ulong DUMP_CHUNK_MAGIC = 1877195438928383261UL;

		// Token: 0x04000442 RID: 1090
		private const int DUMP_CHUNK_VERSION = 336;

		// Token: 0x04000443 RID: 1091
		private Coroutine <AssociatedCoroutine>k__BackingField;

		// Token: 0x04000444 RID: 1092
		private const int YIELD_SPECIAL_TRAP = -99;

		// Token: 0x04000445 RID: 1093
		internal long AutoYieldCounter;

		// Token: 0x020001C8 RID: 456
		private class DebugContext
		{
			// Token: 0x04000703 RID: 1795
			public bool DebuggerEnabled;

			// Token: 0x04000704 RID: 1796
			public IDebugger DebuggerAttached;

			// Token: 0x04000705 RID: 1797
			public DebuggerAction.ActionType DebuggerCurrentAction;

			// Token: 0x04000706 RID: 1798
			public int DebuggerCurrentActionTarget;

			// Token: 0x04000707 RID: 1799
			public SourceRef LastHlRef;

			// Token: 0x04000708 RID: 1800
			public int ExStackDepthAtStep;

			// Token: 0x04000709 RID: 1801
			public List<SourceRef> BreakPoints;

			// Token: 0x0400070A RID: 1802
			public bool LineBasedBreakPoints;
		}

		// Token: 0x020001C9 RID: 457
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001024 RID: 4132 RVA: 0x0000F6BA File Offset: 0x0000D8BA
			internal WatchItem <Debugger_RefreshThreads>b__49_0(Processor c)
			{
				return null;
			}

			// Token: 0x0400070B RID: 1803
			public static readonly Processor.<>c <>9;

			// Token: 0x0400070C RID: 1804
			public static Func<Processor, WatchItem> <>9__49_0;
		}

		// Token: 0x020001CA RID: 458
		private sealed class <>c__DisplayClass51_0
		{
			// Token: 0x06001026 RID: 4134 RVA: 0x0000F6C5 File Offset: 0x0000D8C5
			internal WatchItem <Debugger_RefreshWatches>b__0(DynamicExpression w)
			{
				return null;
			}

			// Token: 0x0400070D RID: 1805
			public Processor <>4__this;

			// Token: 0x0400070E RID: 1806
			public ScriptExecutionContext context;
		}
	}
}
