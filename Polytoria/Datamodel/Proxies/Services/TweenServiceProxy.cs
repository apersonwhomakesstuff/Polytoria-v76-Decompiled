using System;
using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x02000313 RID: 787
	public class TweenServiceProxy
	{
		// Token: 0x0600277B RID: 10107 RVA: 0x0001C951 File Offset: 0x0001AB51
		public TweenServiceProxy(TweenService target)
		{
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x0001C959 File Offset: 0x0001AB59
		public static int TweenPosition(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x0001C95C File Offset: 0x0001AB5C
		public static int TweenRotation(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x0001C95F File Offset: 0x0001AB5F
		public static int TweenSize(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x0001C962 File Offset: 0x0001AB62
		public static int TweenNumber(float start, float end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x0001C965 File Offset: 0x0001AB65
		public static int TweenColor(Color start, Color end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x0001C968 File Offset: 0x0001AB68
		public static int TweenVector3(Vector3 start, Vector3 end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x0001C96B File Offset: 0x0001AB6B
		public static int TweenVector2(Vector2 start, Vector2 end, float time, DynValue callback, LeanTweenType tweenType = LeanTweenType.linear, DynValue callOnComplete = null)
		{
			return 0;
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x0001C96E File Offset: 0x0001AB6E
		public static void Cancel(int id, bool callOnComplete = false)
		{
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x0001C970 File Offset: 0x0001AB70
		public static void CancelAll(bool callOnComplete = false)
		{
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x0001C972 File Offset: 0x0001AB72
		public static void Pause(int id)
		{
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x0001C974 File Offset: 0x0001AB74
		public static void Resume(int id)
		{
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x0001C976 File Offset: 0x0001AB76
		public static bool IsPaused(int id)
		{
			return false;
		}

		// Token: 0x04000D40 RID: 3392
		private readonly TweenService tweenService;
	}
}
