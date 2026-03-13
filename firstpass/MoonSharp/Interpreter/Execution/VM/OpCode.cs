using System;

namespace MoonSharp.Interpreter.Execution.VM
{
	// Token: 0x020000EB RID: 235
	internal enum OpCode
	{
		// Token: 0x040003F8 RID: 1016
		Nop,
		// Token: 0x040003F9 RID: 1017
		Debug,
		// Token: 0x040003FA RID: 1018
		Pop,
		// Token: 0x040003FB RID: 1019
		Copy,
		// Token: 0x040003FC RID: 1020
		Swap,
		// Token: 0x040003FD RID: 1021
		Literal,
		// Token: 0x040003FE RID: 1022
		Closure,
		// Token: 0x040003FF RID: 1023
		NewTable,
		// Token: 0x04000400 RID: 1024
		TblInitN,
		// Token: 0x04000401 RID: 1025
		TblInitI,
		// Token: 0x04000402 RID: 1026
		StoreLcl,
		// Token: 0x04000403 RID: 1027
		Local,
		// Token: 0x04000404 RID: 1028
		StoreUpv,
		// Token: 0x04000405 RID: 1029
		Upvalue,
		// Token: 0x04000406 RID: 1030
		IndexSet,
		// Token: 0x04000407 RID: 1031
		Index,
		// Token: 0x04000408 RID: 1032
		IndexSetN,
		// Token: 0x04000409 RID: 1033
		IndexN,
		// Token: 0x0400040A RID: 1034
		IndexSetL,
		// Token: 0x0400040B RID: 1035
		IndexL,
		// Token: 0x0400040C RID: 1036
		Clean,
		// Token: 0x0400040D RID: 1037
		Meta,
		// Token: 0x0400040E RID: 1038
		BeginFn,
		// Token: 0x0400040F RID: 1039
		Args,
		// Token: 0x04000410 RID: 1040
		Call,
		// Token: 0x04000411 RID: 1041
		ThisCall,
		// Token: 0x04000412 RID: 1042
		Ret,
		// Token: 0x04000413 RID: 1043
		Jump,
		// Token: 0x04000414 RID: 1044
		Jf,
		// Token: 0x04000415 RID: 1045
		JNil,
		// Token: 0x04000416 RID: 1046
		JFor,
		// Token: 0x04000417 RID: 1047
		JtOrPop,
		// Token: 0x04000418 RID: 1048
		JfOrPop,
		// Token: 0x04000419 RID: 1049
		Concat,
		// Token: 0x0400041A RID: 1050
		LessEq,
		// Token: 0x0400041B RID: 1051
		Less,
		// Token: 0x0400041C RID: 1052
		Eq,
		// Token: 0x0400041D RID: 1053
		Add,
		// Token: 0x0400041E RID: 1054
		Sub,
		// Token: 0x0400041F RID: 1055
		Mul,
		// Token: 0x04000420 RID: 1056
		Div,
		// Token: 0x04000421 RID: 1057
		Mod,
		// Token: 0x04000422 RID: 1058
		Not,
		// Token: 0x04000423 RID: 1059
		Len,
		// Token: 0x04000424 RID: 1060
		Neg,
		// Token: 0x04000425 RID: 1061
		Power,
		// Token: 0x04000426 RID: 1062
		CNot,
		// Token: 0x04000427 RID: 1063
		MkTuple,
		// Token: 0x04000428 RID: 1064
		Scalar,
		// Token: 0x04000429 RID: 1065
		Incr,
		// Token: 0x0400042A RID: 1066
		ToNum,
		// Token: 0x0400042B RID: 1067
		ToBool,
		// Token: 0x0400042C RID: 1068
		ExpTuple,
		// Token: 0x0400042D RID: 1069
		IterPrep,
		// Token: 0x0400042E RID: 1070
		IterUpd,
		// Token: 0x0400042F RID: 1071
		Invalid
	}
}
