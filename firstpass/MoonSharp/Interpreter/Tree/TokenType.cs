using System;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x0200005F RID: 95
	internal enum TokenType
	{
		// Token: 0x0400021B RID: 539
		Eof,
		// Token: 0x0400021C RID: 540
		HashBang,
		// Token: 0x0400021D RID: 541
		Name,
		// Token: 0x0400021E RID: 542
		And,
		// Token: 0x0400021F RID: 543
		Break,
		// Token: 0x04000220 RID: 544
		Do,
		// Token: 0x04000221 RID: 545
		Else,
		// Token: 0x04000222 RID: 546
		ElseIf,
		// Token: 0x04000223 RID: 547
		End,
		// Token: 0x04000224 RID: 548
		False,
		// Token: 0x04000225 RID: 549
		For,
		// Token: 0x04000226 RID: 550
		Function,
		// Token: 0x04000227 RID: 551
		Lambda,
		// Token: 0x04000228 RID: 552
		Goto,
		// Token: 0x04000229 RID: 553
		If,
		// Token: 0x0400022A RID: 554
		In,
		// Token: 0x0400022B RID: 555
		Local,
		// Token: 0x0400022C RID: 556
		Nil,
		// Token: 0x0400022D RID: 557
		Not,
		// Token: 0x0400022E RID: 558
		Or,
		// Token: 0x0400022F RID: 559
		Repeat,
		// Token: 0x04000230 RID: 560
		Return,
		// Token: 0x04000231 RID: 561
		Then,
		// Token: 0x04000232 RID: 562
		True,
		// Token: 0x04000233 RID: 563
		Until,
		// Token: 0x04000234 RID: 564
		While,
		// Token: 0x04000235 RID: 565
		Op_Equal,
		// Token: 0x04000236 RID: 566
		Op_Assignment,
		// Token: 0x04000237 RID: 567
		Op_LessThan,
		// Token: 0x04000238 RID: 568
		Op_LessThanEqual,
		// Token: 0x04000239 RID: 569
		Op_GreaterThanEqual,
		// Token: 0x0400023A RID: 570
		Op_GreaterThan,
		// Token: 0x0400023B RID: 571
		Op_NotEqual,
		// Token: 0x0400023C RID: 572
		Op_Concat,
		// Token: 0x0400023D RID: 573
		VarArgs,
		// Token: 0x0400023E RID: 574
		Dot,
		// Token: 0x0400023F RID: 575
		Colon,
		// Token: 0x04000240 RID: 576
		DoubleColon,
		// Token: 0x04000241 RID: 577
		Comma,
		// Token: 0x04000242 RID: 578
		Brk_Close_Curly,
		// Token: 0x04000243 RID: 579
		Brk_Open_Curly,
		// Token: 0x04000244 RID: 580
		Brk_Close_Round,
		// Token: 0x04000245 RID: 581
		Brk_Open_Round,
		// Token: 0x04000246 RID: 582
		Brk_Close_Square,
		// Token: 0x04000247 RID: 583
		Brk_Open_Square,
		// Token: 0x04000248 RID: 584
		Op_Len,
		// Token: 0x04000249 RID: 585
		Op_Pwr,
		// Token: 0x0400024A RID: 586
		Op_Mod,
		// Token: 0x0400024B RID: 587
		Op_Div,
		// Token: 0x0400024C RID: 588
		Op_Mul,
		// Token: 0x0400024D RID: 589
		Op_MinusOrSub,
		// Token: 0x0400024E RID: 590
		Op_Add,
		// Token: 0x0400024F RID: 591
		Comment,
		// Token: 0x04000250 RID: 592
		String,
		// Token: 0x04000251 RID: 593
		String_Long,
		// Token: 0x04000252 RID: 594
		Number,
		// Token: 0x04000253 RID: 595
		Number_HexFloat,
		// Token: 0x04000254 RID: 596
		Number_Hex,
		// Token: 0x04000255 RID: 597
		SemiColon,
		// Token: 0x04000256 RID: 598
		Invalid,
		// Token: 0x04000257 RID: 599
		Brk_Open_Curly_Shared,
		// Token: 0x04000258 RID: 600
		Op_Dollar
	}
}
