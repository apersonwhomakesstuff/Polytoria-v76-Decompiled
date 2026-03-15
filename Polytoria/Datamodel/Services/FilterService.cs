namespace Polytoria.Datamodel.Services;

public class FilterService : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static MatchEvaluator <>9__13_0; //Field offset: 0x8
		public static MatchEvaluator <>9__13_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <Filter>b__13_0(Match match) { }

		internal string <Filter>b__13_1(Match match) { }

	}

	[CompilerGenerated]
	private sealed class <LoadFilter>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		private UnityWebRequest <uwr>5__2; //Field offset: 0x20

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
		public <LoadFilter>d__9(int <>1__state) { }

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
	private static bool <FailedToLoad>k__BackingField; //Field offset: 0x0
	private static List<ProfanityFilterData> filtersCache; //Field offset: 0x8
	private static Dictionary<String, Regex> regexCache; //Field offset: 0x10
	private static HashSet<String> literals; //Field offset: 0x18
	private static Regex combinedRegex; //Field offset: 0x20

	public private static bool FailedToLoad
	{
		[CompilerGenerated]
		 get { } //Length: 78
		[CompilerGenerated]
		private set { } //Length: 83
	}

	private static FilterService() { }

	public FilterService() { }

	public static string Filter(string input) { }

	[CompilerGenerated]
	public static bool get_FailedToLoad() { }

	private static Regex GetCompiledRegex(ProfanityFilterData filter) { }

	[IteratorStateMachine(typeof(<LoadFilter>d__9))]
	private IEnumerator LoadFilter() { }

	private static void ParseFilters(string json) { }

	private static void RebuildHelpers() { }

	[CompilerGenerated]
	private static void set_FailedToLoad(bool value) { }

	private void Start() { }

}

