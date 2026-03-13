using System;
using System.IO;
using MoonSharp.Interpreter.Loaders;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000059 RID: 89
	public class ScriptOptions
	{
		// Token: 0x060005EF RID: 1519 RVA: 0x0000D18C File Offset: 0x0000B38C
		internal ScriptOptions()
		{
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000D194 File Offset: 0x0000B394
		internal ScriptOptions(ScriptOptions defaults)
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0000D19C File Offset: 0x0000B39C
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x0000D1A4 File Offset: 0x0000B3A4
		public IScriptLoader ScriptLoader
		{
			get
			{
				return this.<ScriptLoader>k__BackingField;
			}
			set
			{
				this.<ScriptLoader>k__BackingField = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0000D1AD File Offset: 0x0000B3AD
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x0000D1B5 File Offset: 0x0000B3B5
		public Action<string> DebugPrint
		{
			get
			{
				return this.<DebugPrint>k__BackingField;
			}
			set
			{
				this.<DebugPrint>k__BackingField = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0000D1BE File Offset: 0x0000B3BE
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x0000D1C6 File Offset: 0x0000B3C6
		public Func<string, string> DebugInput
		{
			get
			{
				return this.<DebugInput>k__BackingField;
			}
			set
			{
				this.<DebugInput>k__BackingField = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0000D1CF File Offset: 0x0000B3CF
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x0000D1D7 File Offset: 0x0000B3D7
		public bool UseLuaErrorLocations
		{
			get
			{
				return this.<UseLuaErrorLocations>k__BackingField;
			}
			set
			{
				this.<UseLuaErrorLocations>k__BackingField = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0000D1E0 File Offset: 0x0000B3E0
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		public ColonOperatorBehaviour ColonOperatorClrCallbackBehaviour
		{
			get
			{
				return this.<ColonOperatorClrCallbackBehaviour>k__BackingField;
			}
			set
			{
				this.<ColonOperatorClrCallbackBehaviour>k__BackingField = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0000D1F1 File Offset: 0x0000B3F1
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x0000D1F9 File Offset: 0x0000B3F9
		public Stream Stdin
		{
			get
			{
				return this.<Stdin>k__BackingField;
			}
			set
			{
				this.<Stdin>k__BackingField = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x0000D202 File Offset: 0x0000B402
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x0000D20A File Offset: 0x0000B40A
		public Stream Stdout
		{
			get
			{
				return this.<Stdout>k__BackingField;
			}
			set
			{
				this.<Stdout>k__BackingField = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x0000D213 File Offset: 0x0000B413
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x0000D21B File Offset: 0x0000B41B
		public Stream Stderr
		{
			get
			{
				return this.<Stderr>k__BackingField;
			}
			set
			{
				this.<Stderr>k__BackingField = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x0000D224 File Offset: 0x0000B424
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x0000D22C File Offset: 0x0000B42C
		public int TailCallOptimizationThreshold
		{
			get
			{
				return this.<TailCallOptimizationThreshold>k__BackingField;
			}
			set
			{
				this.<TailCallOptimizationThreshold>k__BackingField = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0000D235 File Offset: 0x0000B435
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x0000D23D File Offset: 0x0000B43D
		public bool CheckThreadAccess
		{
			get
			{
				return this.<CheckThreadAccess>k__BackingField;
			}
			set
			{
				this.<CheckThreadAccess>k__BackingField = value;
			}
		}

		// Token: 0x040001FD RID: 509
		private IScriptLoader <ScriptLoader>k__BackingField;

		// Token: 0x040001FE RID: 510
		private Action<string> <DebugPrint>k__BackingField;

		// Token: 0x040001FF RID: 511
		private Func<string, string> <DebugInput>k__BackingField;

		// Token: 0x04000200 RID: 512
		private bool <UseLuaErrorLocations>k__BackingField;

		// Token: 0x04000201 RID: 513
		private ColonOperatorBehaviour <ColonOperatorClrCallbackBehaviour>k__BackingField;

		// Token: 0x04000202 RID: 514
		private Stream <Stdin>k__BackingField;

		// Token: 0x04000203 RID: 515
		private Stream <Stdout>k__BackingField;

		// Token: 0x04000204 RID: 516
		private Stream <Stderr>k__BackingField;

		// Token: 0x04000205 RID: 517
		private int <TailCallOptimizationThreshold>k__BackingField;

		// Token: 0x04000206 RID: 518
		private bool <CheckThreadAccess>k__BackingField;
	}
}
