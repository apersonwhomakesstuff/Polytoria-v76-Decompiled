namespace Polytoria.Controllers;

public class ImageCacheController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Color32, Boolean> <>9__12_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <LoadImage>b__12_0(Color32 c) { }

	}

	[CompilerGenerated]
	private sealed class <LoadImage>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ImageCacheKey key; //Field offset: 0x20
		public int tries; //Field offset: 0x38
		public ImageCacheController <>4__this; //Field offset: 0x40
		private string <url>5__2; //Field offset: 0x48
		private UnityWebRequest <uwr>5__3; //Field offset: 0x50

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LoadImage>d__12(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <WaitForImage>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Action<ImageCacheKey, ImageCacheEntry> callback; //Field offset: 0x20
		public ImageCacheKey key; //Field offset: 0x28
		public ImageCacheController <>4__this; //Field offset: 0x40
		private float <time>5__2; //Field offset: 0x48

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <WaitForImage>d__10(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private static ImageCacheController <Instance>k__BackingField; //Field offset: 0x0
	private static Dictionary<ImageCacheKey, ImageCacheEntry> cache; //Field offset: 0x8
	private Queue<ImageCacheKey> loadQueue; //Field offset: 0x20
	private Texture2D fallback; //Field offset: 0x28
	private bool loading; //Field offset: 0x30

	public private static ImageCacheController Instance
	{
		[CompilerGenerated]
		 get { } //Length: 78
		[CompilerGenerated]
		private set { } //Length: 105
	}

	private static ImageCacheController() { }

	public ImageCacheController() { }

	private void Awake() { }

	[CompilerGenerated]
	public static ImageCacheController get_Instance() { }

	public void GetImage(ImageCacheKey key, Action<ImageCacheKey, ImageCacheEntry> callback) { }

	[IteratorStateMachine(typeof(<LoadImage>d__12))]
	private IEnumerator LoadImage(ImageCacheKey key, int tries = 0) { }

	[CompilerGenerated]
	private static void set_Instance(ImageCacheController value) { }

	private void Update() { }

	[IteratorStateMachine(typeof(<WaitForImage>d__10))]
	private IEnumerator WaitForImage(ImageCacheKey key, Action<ImageCacheKey, ImageCacheEntry> callback) { }

}

