namespace Polytoria.Datamodel.Proxies.Services;

public class TweenServiceProxy
{
	private readonly TweenService tweenService; //Field offset: 0x10

	[MoonSharpHidden]
	public TweenServiceProxy(TweenService target) { }

	public static void Cancel(int id, bool callOnComplete = false) { }

	public static void CancelAll(bool callOnComplete = false) { }

	public static bool IsPaused(int id) { }

	public static void Pause(int id) { }

	public static void Resume(int id) { }

	[LuaCallbackParameter("callback", typeof(Color), "value", False)]
	public static int TweenColor(Color start, Color end, float time, DynValue callback, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	[LuaCallbackParameter("callback", typeof(float), "value", False)]
	public static int TweenNumber(float start, float end, float time, DynValue callback, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	public static int TweenPosition(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	public static int TweenRotation(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	public static int TweenSize(DynamicInstance target, Vector3 destination, float time, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	[LuaCallbackParameter("callback", typeof(Vector2), "value", False)]
	public static int TweenVector2(Vector2 start, Vector2 end, float time, DynValue callback, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

	[LuaCallbackParameter("callback", typeof(Vector3), "value", False)]
	public static int TweenVector3(Vector3 start, Vector3 end, float time, DynValue callback, LeanTweenType tweenType = 1, DynValue callOnComplete = null) { }

}

