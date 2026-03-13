using System;
using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002CD RID: 717
	public class TweenService
	{
		// Token: 0x06002437 RID: 9271 RVA: 0x0001BF67 File Offset: 0x0001A167
		public static int TweenPosition(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x0001BF6A File Offset: 0x0001A16A
		public static int TweenRotation(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x0001BF6D File Offset: 0x0001A16D
		public static int TweenSize(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x0001BF70 File Offset: 0x0001A170
		public static int TweenNumber(float start, float end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x0001BF73 File Offset: 0x0001A173
		public static int TweenColor(Color start, Color end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x0001BF76 File Offset: 0x0001A176
		public static int TweenVector3(Vector3 start, Vector3 end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x0001BF79 File Offset: 0x0001A179
		public static int TweenVector2(Vector2 start, Vector2 end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x0001BF7C File Offset: 0x0001A17C
		public static void Cancel(int id, bool callOnComplete = false)
		{
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x0001BF7E File Offset: 0x0001A17E
		public static void CancelAll(bool callOnComplete = false)
		{
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x0001BF80 File Offset: 0x0001A180
		public static void Pause(int id)
		{
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x0001BF82 File Offset: 0x0001A182
		public static void Resume(int id)
		{
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x0001BF84 File Offset: 0x0001A184
		public static bool IsPaused(int id)
		{
			return false;
		}

		// Token: 0x0200040C RID: 1036
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x06002C7E RID: 11390 RVA: 0x0001D93F File Offset: 0x0001BB3F
			internal void <TweenPosition>b__0()
			{
			}

			// Token: 0x04001162 RID: 4450
			public DynValue callOnComplete;

			// Token: 0x04001163 RID: 4451
			public ScriptService ss;

			// Token: 0x04001164 RID: 4452
			public DynamicInstance inst;
		}

		// Token: 0x0200040D RID: 1037
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06002C80 RID: 11392 RVA: 0x0001D949 File Offset: 0x0001BB49
			internal void <TweenRotation>b__0()
			{
			}

			// Token: 0x04001165 RID: 4453
			public DynValue callOnComplete;

			// Token: 0x04001166 RID: 4454
			public ScriptService ss;

			// Token: 0x04001167 RID: 4455
			public DynamicInstance inst;
		}

		// Token: 0x0200040E RID: 1038
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06002C82 RID: 11394 RVA: 0x0001D953 File Offset: 0x0001BB53
			internal void <TweenSize>b__0()
			{
			}

			// Token: 0x04001168 RID: 4456
			public DynValue callOnComplete;

			// Token: 0x04001169 RID: 4457
			public ScriptService ss;

			// Token: 0x0400116A RID: 4458
			public DynamicInstance inst;
		}

		// Token: 0x0200040F RID: 1039
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06002C84 RID: 11396 RVA: 0x0001D95D File Offset: 0x0001BB5D
			internal void <TweenNumber>g__onUpdate|0(float val)
			{
			}

			// Token: 0x06002C85 RID: 11397 RVA: 0x0001D95F File Offset: 0x0001BB5F
			internal void <TweenNumber>b__1()
			{
			}

			// Token: 0x0400116B RID: 4459
			public ScriptService ss;

			// Token: 0x0400116C RID: 4460
			public DynValue callback;

			// Token: 0x0400116D RID: 4461
			public DynValue callOnComplete;
		}

		// Token: 0x02000410 RID: 1040
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06002C87 RID: 11399 RVA: 0x0001D969 File Offset: 0x0001BB69
			internal void <TweenColor>g__onUpdate|0(Color val)
			{
			}

			// Token: 0x06002C88 RID: 11400 RVA: 0x0001D96B File Offset: 0x0001BB6B
			internal void <TweenColor>b__1()
			{
			}

			// Token: 0x0400116E RID: 4462
			public ScriptService ss;

			// Token: 0x0400116F RID: 4463
			public DynValue callback;

			// Token: 0x04001170 RID: 4464
			public DynValue callOnComplete;
		}

		// Token: 0x02000411 RID: 1041
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06002C8A RID: 11402 RVA: 0x0001D975 File Offset: 0x0001BB75
			internal void <TweenVector3>b__0(Vector3 val)
			{
			}

			// Token: 0x06002C8B RID: 11403 RVA: 0x0001D977 File Offset: 0x0001BB77
			internal void <TweenVector3>b__1()
			{
			}

			// Token: 0x04001171 RID: 4465
			public ScriptService ss;

			// Token: 0x04001172 RID: 4466
			public DynValue callback;

			// Token: 0x04001173 RID: 4467
			public DynValue callOnComplete;
		}

		// Token: 0x02000412 RID: 1042
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06002C8D RID: 11405 RVA: 0x0001D981 File Offset: 0x0001BB81
			internal void <TweenVector2>b__0(Vector2 val)
			{
			}

			// Token: 0x06002C8E RID: 11406 RVA: 0x0001D983 File Offset: 0x0001BB83
			internal void <TweenVector2>b__1()
			{
			}

			// Token: 0x04001174 RID: 4468
			public ScriptService ss;

			// Token: 0x04001175 RID: 4469
			public DynValue callback;

			// Token: 0x04001176 RID: 4470
			public DynValue callOnComplete;
		}
	}
}
