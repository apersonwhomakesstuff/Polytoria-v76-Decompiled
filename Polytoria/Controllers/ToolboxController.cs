namespace Polytoria.Controllers;

public class ToolboxController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Instance> <>9__24_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <InsertModel>b__24_0(Instance i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public JSONNode entry; //Field offset: 0x10
		public ToolboxController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass22_0() { }

		internal void <DoReloadToolbox>b__0() { }

		internal void <DoReloadToolbox>b__1() { }

		internal void <DoReloadToolbox>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <DoReloadToolbox>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ToolboxController <>4__this; //Field offset: 0x20
		private UnityWebRequest <uwr>5__2; //Field offset: 0x28

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
		public <DoReloadToolbox>d__22(int <>1__state) { }

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
	private sealed class <LoadThumbnail>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public JSONNode entry; //Field offset: 0x20
		public RawImage image; //Field offset: 0x28
		private UnityWebRequest <twr>5__2; //Field offset: 0x30

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
		public <LoadThumbnail>d__23(int <>1__state) { }

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

	internal enum ToolboxCategory : int
	{
		RecentlyUpdated = 0,
		UploadedModels = 1,
	}

	[SerializeField]
	private TMP_Dropdown categorySelector; //Field offset: 0x20
	[SerializeField]
	private RectTransform toolboxContainer; //Field offset: 0x28
	[SerializeField]
	private RectTransform entryPrefab; //Field offset: 0x30
	[SerializeField]
	private TMP_Text pageLabel; //Field offset: 0x38
	private int page; //Field offset: 0x40
	private int pageLimit; //Field offset: 0x44
	private ToolboxCategory cat; //Field offset: 0x48
	private string searchQuery; //Field offset: 0x50

	public ToolboxCategory Category
	{
		 get { } //Length: 4
		 set { } //Length: 10
	}

	public int Page
	{
		 get { } //Length: 4
		 set { } //Length: 39
	}

	public string SearchQuery
	{
		 get { } //Length: 5
		 set { } //Length: 37
	}

	public ToolboxController() { }

	[IteratorStateMachine(typeof(<DoReloadToolbox>d__22))]
	private IEnumerator DoReloadToolbox() { }

	public ToolboxCategory get_Category() { }

	public int get_Page() { }

	public string get_SearchQuery() { }

	public void InsertModel(int id) { }

	[IteratorStateMachine(typeof(<LoadThumbnail>d__23))]
	private IEnumerator LoadThumbnail(JSONNode entry, RawImage image) { }

	public void PageDown() { }

	public void PageUp() { }

	public void ReloadToolbox() { }

	public void set_Category(ToolboxCategory value) { }

	public void set_Page(int value) { }

	public void set_SearchQuery(string value) { }

	public void SetCategory(int c) { }

	public void SetSearchQuery(string q) { }

	private void Start() { }

}

