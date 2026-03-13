using System;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Interop.LuaStateInterop;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000045 RID: 69
	public class ScriptExecutionContext : IScriptPrivateResource
	{
		// Token: 0x06000575 RID: 1397 RVA: 0x0000CF21 File Offset: 0x0000B121
		internal ScriptExecutionContext(Processor p, CallbackFunction callBackFunction, SourceRef sourceRef, bool isDynamic = false)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0000CF29 File Offset: 0x0000B129
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x0000CF31 File Offset: 0x0000B131
		public bool IsDynamicExecution
		{
			get
			{
				return this.<IsDynamicExecution>k__BackingField;
			}
			private set
			{
				this.<IsDynamicExecution>k__BackingField = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0000CF3A File Offset: 0x0000B13A
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x0000CF42 File Offset: 0x0000B142
		public SourceRef CallingLocation
		{
			get
			{
				return this.<CallingLocation>k__BackingField;
			}
			private set
			{
				this.<CallingLocation>k__BackingField = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0000CF4B File Offset: 0x0000B14B
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x0000CF4E File Offset: 0x0000B14E
		public object AdditionalData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0000CF50 File Offset: 0x0000B150
		public Table GetMetatable(DynValue value)
		{
			return null;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0000CF53 File Offset: 0x0000B153
		public DynValue GetMetamethod(DynValue value, string metamethod)
		{
			return null;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0000CF56 File Offset: 0x0000B156
		public DynValue GetMetamethodTailCall(DynValue value, string metamethod, DynValue[] args)
		{
			return null;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0000CF59 File Offset: 0x0000B159
		public DynValue GetBinaryMetamethod(DynValue op1, DynValue op2, string eventName)
		{
			return null;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0000CF5C File Offset: 0x0000B15C
		public Script GetScript()
		{
			return null;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0000CF5F File Offset: 0x0000B15F
		public Coroutine GetCallingCoroutine()
		{
			return null;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0000CF62 File Offset: 0x0000B162
		public DynValue EmulateClassicCall(CallbackArguments args, string functionName, Func<LuaState, int> callback)
		{
			return null;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000CF65 File Offset: 0x0000B165
		public DynValue Call(DynValue func, DynValue[] args)
		{
			return null;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0000CF68 File Offset: 0x0000B168
		public DynValue EvaluateSymbol(SymbolRef symref)
		{
			return null;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0000CF6B File Offset: 0x0000B16B
		public DynValue EvaluateSymbolByName(string symbol)
		{
			return null;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0000CF6E File Offset: 0x0000B16E
		public SymbolRef FindSymbolByName(string symbol)
		{
			return null;
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0000CF71 File Offset: 0x0000B171
		public Table CurrentGlobalEnv
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0000CF74 File Offset: 0x0000B174
		public void PerformMessageDecorationBeforeUnwind(DynValue messageHandler, ScriptRuntimeException exception)
		{
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0000CF76 File Offset: 0x0000B176
		public Script OwnerScript
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040001B5 RID: 437
		private Processor m_Processor;

		// Token: 0x040001B6 RID: 438
		private CallbackFunction m_Callback;

		// Token: 0x040001B7 RID: 439
		private bool <IsDynamicExecution>k__BackingField;

		// Token: 0x040001B8 RID: 440
		private SourceRef <CallingLocation>k__BackingField;
	}
}
