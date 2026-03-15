namespace Polytoria.Datamodel.Services;

public class TweenService
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public DynValue callOnComplete; //Field offset: 0x10
		public ScriptService ss; //Field offset: 0x18
		public DynamicInstance inst; //Field offset: 0x20

		public <>c__DisplayClass0_0() { }

		internal void <TweenPosition>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public DynValue callOnComplete; //Field offset: 0x10
		public ScriptService ss; //Field offset: 0x18
		public DynamicInstance inst; //Field offset: 0x20

		public <>c__DisplayClass1_0() { }

		internal void <TweenRotation>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public DynValue callOnComplete; //Field offset: 0x10
		public ScriptService ss; //Field offset: 0x18
		public DynamicInstance inst; //Field offset: 0x20

		public <>c__DisplayClass2_0() { }

		internal void <TweenSize>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public ScriptService ss; //Field offset: 0x10
		public DynValue callback; //Field offset: 0x18
		public DynValue callOnComplete; //Field offset: 0x20

		public <>c__DisplayClass3_0() { }

		internal void <TweenNumber>b__1() { }

		internal void <TweenNumber>g__onUpdate|0(float val) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public ScriptService ss; //Field offset: 0x10
		public DynValue callback; //Field offset: 0x18
		public DynValue callOnComplete; //Field offset: 0x20

		public <>c__DisplayClass4_0() { }

		internal void <TweenColor>b__1() { }

		internal void <TweenColor>g__onUpdate|0(Color val) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public ScriptService ss; //Field offset: 0x10
		public DynValue callback; //Field offset: 0x18
		public DynValue callOnComplete; //Field offset: 0x20

		public <>c__DisplayClass5_0() { }

		internal void <TweenVector3>b__0(Vector3 val) { }

		internal void <TweenVector3>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public ScriptService ss; //Field offset: 0x10
		public DynValue callback; //Field offset: 0x18
		public DynValue callOnComplete; //Field offset: 0x20

		public <>c__DisplayClass6_0() { }

		internal void <TweenVector2>b__0(Vector2 val) { }

		internal void <TweenVector2>b__1() { }

	}


	public TweenService() { }

	public static void Cancel(int id, bool callOnComplete = false) { }

	public static void CancelAll(bool callOnComplete = false) { }

	public static bool IsPaused(int id) { }

	public static void Pause(int id) { }

	public static void Resume(int id) { }

	public static int TweenColor(Color start, Color end, float time, DynValue callback, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	public static int TweenNumber(float start, float end, float time, DynValue callback, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	public static int TweenPosition(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	public static int TweenRotation(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	public static int TweenSize(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	public static int TweenVector2(Vector2 start, Vector2 end, float time, DynValue callback, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	public static int TweenVector3(Vector3 start, Vector3 end, float time, DynValue callback, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

}

