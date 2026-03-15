namespace Polytoria.Controllers;

public class DiscordController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UpdateActivityHandler <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <UpdateActivity>b__11_0(Result res) { }

	}

	[CompilerGenerated]
	private static DiscordController <Instance>k__BackingField; //Field offset: 0x0
	private Discord discord; //Field offset: 0x20
	private ActivityManager activityManager; //Field offset: 0x28
	private Activity currentActivity; //Field offset: 0x30

	public Activity Activity
	{
		 get { } //Length: 90
	}

	public private static DiscordController Instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 81
	}

	public DiscordController() { }

	private void Awake() { }

	public Activity get_Activity() { }

	[CompilerGenerated]
	public static DiscordController get_Instance() { }

	private void OnDestroy() { }

	[CompilerGenerated]
	private static void set_Instance(DiscordController value) { }

	private void Start() { }

	private void Update() { }

	public void UpdateActivity(Activity activity) { }

}

