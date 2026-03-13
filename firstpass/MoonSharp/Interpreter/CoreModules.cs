using System;

namespace MoonSharp.Interpreter
{
	// Token: 0x0200004E RID: 78
	public enum CoreModules
	{
		// Token: 0x040001C9 RID: 457
		None,
		// Token: 0x040001CA RID: 458
		Basic = 64,
		// Token: 0x040001CB RID: 459
		GlobalConsts = 1,
		// Token: 0x040001CC RID: 460
		TableIterators,
		// Token: 0x040001CD RID: 461
		Metatables = 4,
		// Token: 0x040001CE RID: 462
		String = 8,
		// Token: 0x040001CF RID: 463
		LoadMethods = 16,
		// Token: 0x040001D0 RID: 464
		Table = 32,
		// Token: 0x040001D1 RID: 465
		ErrorHandling = 128,
		// Token: 0x040001D2 RID: 466
		Math = 256,
		// Token: 0x040001D3 RID: 467
		Coroutine = 512,
		// Token: 0x040001D4 RID: 468
		Bit32 = 1024,
		// Token: 0x040001D5 RID: 469
		OS_Time = 2048,
		// Token: 0x040001D6 RID: 470
		OS_System = 4096,
		// Token: 0x040001D7 RID: 471
		IO = 8192,
		// Token: 0x040001D8 RID: 472
		Debug = 16384,
		// Token: 0x040001D9 RID: 473
		Dynamic = 32768,
		// Token: 0x040001DA RID: 474
		Json = 65536,
		// Token: 0x040001DB RID: 475
		Preset_HardSandbox = 1387,
		// Token: 0x040001DC RID: 476
		Preset_SoftSandbox = 102383,
		// Token: 0x040001DD RID: 477
		Preset_Default = 114687,
		// Token: 0x040001DE RID: 478
		Preset_Complete = 131071
	}
}
