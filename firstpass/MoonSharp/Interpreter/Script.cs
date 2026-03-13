using System;
using System.Collections.Generic;
using System.IO;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Diagnostics;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000057 RID: 87
	public class Script : IScriptPrivateResource
	{
		// Token: 0x060005B5 RID: 1461 RVA: 0x0000D077 File Offset: 0x0000B277
		public Script()
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0000D07F File Offset: 0x0000B27F
		public Script(CoreModules coreModules)
		{
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0000D087 File Offset: 0x0000B287
		public static ScriptOptions DefaultOptions
		{
			get
			{
				return Script.<DefaultOptions>k__BackingField;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0000D08E File Offset: 0x0000B28E
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x0000D096 File Offset: 0x0000B296
		public ScriptOptions Options
		{
			get
			{
				return this.<Options>k__BackingField;
			}
			private set
			{
				this.<Options>k__BackingField = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x0000D09F File Offset: 0x0000B29F
		public static ScriptGlobalOptions GlobalOptions
		{
			get
			{
				return Script.<GlobalOptions>k__BackingField;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0000D0A6 File Offset: 0x0000B2A6
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x0000D0AE File Offset: 0x0000B2AE
		public PerformanceStatistics PerformanceStats
		{
			get
			{
				return this.<PerformanceStats>k__BackingField;
			}
			private set
			{
				this.<PerformanceStats>k__BackingField = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0000D0B7 File Offset: 0x0000B2B7
		public Table Globals
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0000D0BA File Offset: 0x0000B2BA
		public DynValue LoadFunction(string code, Table globalTable = null, string funcFriendlyName = null)
		{
			return null;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0000D0BD File Offset: 0x0000B2BD
		private void SignalByteCodeChange()
		{
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0000D0BF File Offset: 0x0000B2BF
		private void SignalSourceCodeChange(SourceCode source)
		{
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000D0C1 File Offset: 0x0000B2C1
		public DynValue LoadString(string code, Table globalTable = null, string codeFriendlyName = null)
		{
			return null;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
		public DynValue LoadStream(Stream stream, Table globalTable = null, string codeFriendlyName = null)
		{
			return null;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0000D0C7 File Offset: 0x0000B2C7
		public void Dump(DynValue function, Stream stream)
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0000D0C9 File Offset: 0x0000B2C9
		public DynValue LoadFile(string filename, Table globalContext = null, string friendlyFilename = null)
		{
			return null;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000D0CC File Offset: 0x0000B2CC
		public DynValue DoString(string code, Table globalContext = null, string codeFriendlyName = null)
		{
			return null;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0000D0CF File Offset: 0x0000B2CF
		public DynValue DoStream(Stream stream, Table globalContext = null, string codeFriendlyName = null)
		{
			return null;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000D0D2 File Offset: 0x0000B2D2
		public DynValue DoFile(string filename, Table globalContext = null, string codeFriendlyName = null)
		{
			return null;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0000D0D5 File Offset: 0x0000B2D5
		public static DynValue RunFile(string filename)
		{
			return null;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
		public static DynValue RunString(string code)
		{
			return null;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0000D0DB File Offset: 0x0000B2DB
		private DynValue MakeClosure(int address, Table envTable = null)
		{
			return null;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0000D0DE File Offset: 0x0000B2DE
		public DynValue Call(DynValue function)
		{
			return null;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0000D0E1 File Offset: 0x0000B2E1
		public DynValue Call(DynValue function, DynValue[] args)
		{
			return null;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0000D0E4 File Offset: 0x0000B2E4
		public DynValue Call(DynValue function, object[] args)
		{
			return null;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0000D0E7 File Offset: 0x0000B2E7
		public DynValue Call(object function)
		{
			return null;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0000D0EA File Offset: 0x0000B2EA
		public DynValue Call(object function, object[] args)
		{
			return null;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0000D0ED File Offset: 0x0000B2ED
		public DynValue CreateCoroutine(DynValue function)
		{
			return null;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000D0F0 File Offset: 0x0000B2F0
		public DynValue RecycleCoroutine(Coroutine coroutine, DynValue function)
		{
			return null;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000D0F3 File Offset: 0x0000B2F3
		public DynValue CreateCoroutine(object function)
		{
			return null;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0000D0F6 File Offset: 0x0000B2F6
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x0000D0F9 File Offset: 0x0000B2F9
		public bool DebuggerEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0000D0FB File Offset: 0x0000B2FB
		public void AttachDebugger(IDebugger debugger)
		{
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0000D0FD File Offset: 0x0000B2FD
		public SourceCode GetSourceCode(int sourceCodeID)
		{
			return null;
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0000D100 File Offset: 0x0000B300
		public int SourceCodeCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0000D103 File Offset: 0x0000B303
		public DynValue RequireModule(string modname, Table globalContext = null)
		{
			return null;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0000D106 File Offset: 0x0000B306
		public Table GetTypeMetatable(DataType type)
		{
			return null;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0000D109 File Offset: 0x0000B309
		public void SetTypeMetatable(DataType type, Table metatable)
		{
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0000D10B File Offset: 0x0000B30B
		public static void WarmUp()
		{
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000D10D File Offset: 0x0000B30D
		public DynamicExpression CreateDynamicExpression(string code)
		{
			return null;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0000D110 File Offset: 0x0000B310
		public DynamicExpression CreateConstantDynamicExpression(string code, DynValue constant)
		{
			return null;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0000D113 File Offset: 0x0000B313
		internal ScriptExecutionContext CreateDynamicExecutionContext(CallbackFunction func = null)
		{
			return null;
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x0000D116 File Offset: 0x0000B316
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x0000D11E File Offset: 0x0000B31E
		public Table Registry
		{
			get
			{
				return this.<Registry>k__BackingField;
			}
			private set
			{
				this.<Registry>k__BackingField = value;
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000D127 File Offset: 0x0000B327
		public static string GetBanner(string subproduct = null)
		{
			return null;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0000D12A File Offset: 0x0000B32A
		Script IScriptPrivateResource.OwnerScript
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040001EB RID: 491
		public const string VERSION = "2.0.0.0";

		// Token: 0x040001EC RID: 492
		public const string LUA_VERSION = "5.2";

		// Token: 0x040001ED RID: 493
		private Processor m_MainProcessor;

		// Token: 0x040001EE RID: 494
		private ByteCode m_ByteCode;

		// Token: 0x040001EF RID: 495
		private List<SourceCode> m_Sources;

		// Token: 0x040001F0 RID: 496
		private Table m_GlobalTable;

		// Token: 0x040001F1 RID: 497
		private IDebugger m_Debugger;

		// Token: 0x040001F2 RID: 498
		private Table[] m_TypeMetatables;

		// Token: 0x040001F3 RID: 499
		private static readonly ScriptOptions <DefaultOptions>k__BackingField;

		// Token: 0x040001F4 RID: 500
		private ScriptOptions <Options>k__BackingField;

		// Token: 0x040001F5 RID: 501
		private static readonly ScriptGlobalOptions <GlobalOptions>k__BackingField;

		// Token: 0x040001F6 RID: 502
		private PerformanceStatistics <PerformanceStats>k__BackingField;

		// Token: 0x040001F7 RID: 503
		private Table <Registry>k__BackingField;

		// Token: 0x0200018A RID: 394
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000F33 RID: 3891 RVA: 0x0000F3EF File Offset: 0x0000D5EF
			internal string <SignalByteCodeChange>b__27_0(Instruction s)
			{
				return null;
			}

			// Token: 0x06000F34 RID: 3892 RVA: 0x0000F3F2 File Offset: 0x0000D5F2
			internal void <.cctor>b__68_0(string s)
			{
			}

			// Token: 0x06000F35 RID: 3893 RVA: 0x0000F3F4 File Offset: 0x0000D5F4
			internal string <.cctor>b__68_1(string s)
			{
				return null;
			}

			// Token: 0x04000660 RID: 1632
			public static readonly Script.<>c <>9;

			// Token: 0x04000661 RID: 1633
			public static Func<Instruction, string> <>9__27_0;
		}
	}
}
