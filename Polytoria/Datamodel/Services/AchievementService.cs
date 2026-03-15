namespace Polytoria.Datamodel.Services;

public class AchievementService : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class <DoAward>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public int achievementID; //Field offset: 0x20
		public int userID; //Field offset: 0x24
		public DynValue callback; //Field offset: 0x28
		private UnityWebRequest <uwr>5__2; //Field offset: 0x30

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
		public <DoAward>d__11(int <>1__state) { }

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
	private sealed class <DoHasAchievement>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public int userID; //Field offset: 0x20
		public int achievementID; //Field offset: 0x24
		public DynValue callback; //Field offset: 0x28
		private UnityWebRequest <uwr>5__2; //Field offset: 0x30

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
		public <DoHasAchievement>d__13(int <>1__state) { }

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
	private static AchievementService <Instance>k__BackingField; //Field offset: 0x0
	public int MaxRequestsPerMinute; //Field offset: 0x68
	public int RequestsPerPlayerModifier; //Field offset: 0x6C
	private int requestsThisMinute; //Field offset: 0x70
	private int currentMinute; //Field offset: 0x74

	public private static AchievementService Instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 81
	}

	public AchievementService() { }

	private void Awake() { }

	public void Award(int userID, int achievementID, DynValue callback) { }

	[IteratorStateMachine(typeof(<DoAward>d__11))]
	private IEnumerator DoAward(int userID, int achievementID, DynValue callback) { }

	[IteratorStateMachine(typeof(<DoHasAchievement>d__13))]
	private IEnumerator DoHasAchievement(int userID, int achievementID, DynValue callback) { }

	[CompilerGenerated]
	public static AchievementService get_Instance() { }

	public void HasAchievement(int userID, int achievementID, DynValue callback) { }

	[CompilerGenerated]
	private static void set_Instance(AchievementService value) { }

	public bool UseRequest() { }

	public virtual bool Weaved() { }

}

