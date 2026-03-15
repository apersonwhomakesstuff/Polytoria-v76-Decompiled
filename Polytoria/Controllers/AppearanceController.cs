namespace Polytoria.Controllers;

public class AppearanceController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Transform headObj; //Field offset: 0x10
		public Transform leftArmObj; //Field offset: 0x18
		public Transform rightArmObj; //Field offset: 0x20
		public Transform torsoObj; //Field offset: 0x28
		public Transform leftLegObj; //Field offset: 0x30
		public Transform rightLegObj; //Field offset: 0x38
		public Action<ImageCacheKey, ImageCacheEntry> <>9__0; //Field offset: 0x40
		public Action<ImageCacheKey, ImageCacheEntry> <>9__1; //Field offset: 0x48
		public Action<ImageCacheKey, ImageCacheEntry> <>9__2; //Field offset: 0x50

		public <>c__DisplayClass8_0() { }

		internal void <ProcessPlayerAppearance>b__0(ImageCacheKey key, ImageCacheEntry entry) { }

		internal void <ProcessPlayerAppearance>b__1(ImageCacheKey key, ImageCacheEntry entry) { }

		internal void <ProcessPlayerAppearance>b__2(ImageCacheKey key, ImageCacheEntry entry) { }

	}

	[CompilerGenerated]
	private sealed class <ProcessPlayerAppearance>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player player; //Field offset: 0x20
		private <>c__DisplayClass8_0 <>8__1; //Field offset: 0x28
		public AppearanceController <>4__this; //Field offset: 0x30
		private UnityWebRequest <uwr>5__2; //Field offset: 0x38
		private Enumerator <>7__wrap2; //Field offset: 0x40
		private GameObject <hat>5__4; //Field offset: 0x88
		private GltfImport <gltf>5__5; //Field offset: 0x90
		private Task<Boolean> <t>5__6; //Field offset: 0x98
		private Task<Boolean> <task>5__7; //Field offset: 0xA0

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
		public <ProcessPlayerAppearance>d__8(int <>1__state) { }

		private void <>m__Finally1() { }

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
	private static AppearanceController <Instance>k__BackingField; //Field offset: 0x0
	private Queue<Player> playerQueue; //Field offset: 0x20
	private bool isProcessing; //Field offset: 0x28

	public private static AppearanceController Instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 81
	}

	public AppearanceController() { }

	public void AddPlayerToQueue(Player player) { }

	private void Awake() { }

	[CompilerGenerated]
	public static AppearanceController get_Instance() { }

	[IteratorStateMachine(typeof(<ProcessPlayerAppearance>d__8))]
	private IEnumerator ProcessPlayerAppearance(Player player) { }

	[CompilerGenerated]
	private static void set_Instance(AppearanceController value) { }

	private void Update() { }

}

