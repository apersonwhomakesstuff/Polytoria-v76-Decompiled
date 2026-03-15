namespace Polytoria.Controllers;

public class CreatorController : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Instance, Boolean> <>9__57_0; //Field offset: 0x8
		public static Func<String, Char> <>9__79_0; //Field offset: 0x10
		public static Func<String, Char> <>9__82_0; //Field offset: 0x18
		public static Func<Instance, GameObject> <>9__96_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <DoExportModel>b__57_0(Instance i) { }

		internal char <RandomString>b__82_0(string s) { }

		internal char <TestGame>b__79_0(string s) { }

		internal GameObject <Update>b__96_0(Instance i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public string mat; //Field offset: 0x10
		public CreatorController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass46_0() { }

		internal void <Start>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public int lowestLevel; //Field offset: 0x10

		public <>c__DisplayClass53_0() { }

		internal bool <GroupSelection>b__0(Instance i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public int lowestLevel; //Field offset: 0x10

		public <>c__DisplayClass54_0() { }

		internal bool <UngroupSelection>b__0(Instance i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_0
	{
		public JSONNode node; //Field offset: 0x10
		public CreatorController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass68_0() { }

		internal void <LoadStarterPlaces>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_1
	{
		public JSONNode node; //Field offset: 0x10
		public CreatorController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass68_1() { }

		internal void <LoadStarterPlaces>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public JSONNode game; //Field offset: 0x10
		public CreatorController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass74_0() { }

		internal void <DoPublish>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public CreatorController <>4__this; //Field offset: 0x10
		public JSONNode game; //Field offset: 0x18

		public <>c__DisplayClass76_0() { }

		internal void <SetPublishModalSelectedGame>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <AutoSaveLoop>d__85 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CreatorController <>4__this; //Field offset: 0x20

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
		public <AutoSaveLoop>d__85(int <>1__state) { }

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
	private sealed class <CheckToken>d__50 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CreatorController <>4__this; //Field offset: 0x20
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
		public <CheckToken>d__50(int <>1__state) { }

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
	private sealed class <DoPublish>d__74 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CreatorController <>4__this; //Field offset: 0x20
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
		public <DoPublish>d__74(int <>1__state) { }

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
	private sealed class <DoPublishModel>d__62 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CreatorController <>4__this; //Field offset: 0x20
		private Enumerator<Instance> <>7__wrap1; //Field offset: 0x28
		private UnityWebRequest <uwr>5__3; //Field offset: 0x40

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
		public <DoPublishModel>d__62(int <>1__state) { }

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
	private sealed class <LoadMapFromFile>d__87 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CreatorController <>4__this; //Field offset: 0x20
		public string path; //Field offset: 0x28

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
		public <LoadMapFromFile>d__87(int <>1__state) { }

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
	private sealed class <LoadStarterPlaces>d__68 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CreatorController <>4__this; //Field offset: 0x20
		private List<ThumbnailImageTarget> <images>5__2; //Field offset: 0x28
		private RectTransform <template>5__3; //Field offset: 0x30
		private UnityWebRequest <uwr>5__4; //Field offset: 0x38

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
		public <LoadStarterPlaces>d__68(int <>1__state) { }

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
	private sealed class <LoadThumbnailImage>d__77 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string src; //Field offset: 0x20
		public Image target; //Field offset: 0x28
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
		public <LoadThumbnailImage>d__77(int <>1__state) { }

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
	private sealed class <LoadThumbnailImages>d__75 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public List<ThumbnailImageTarget> thumbnails; //Field offset: 0x20
		private Enumerator<ThumbnailImageTarget> <>7__wrap1; //Field offset: 0x28
		private Image <target>5__3; //Field offset: 0x48
		private UnityWebRequest <twr>5__4; //Field offset: 0x50

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
		public <LoadThumbnailImages>d__75(int <>1__state) { }

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
	private sealed class <PublishLevelToID>d__81 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CreatorController <>4__this; //Field offset: 0x20
		public int id; //Field offset: 0x28
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
		public <PublishLevelToID>d__81(int <>1__state) { }

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
	private sealed class <ShowExportGLTFDialog>d__59 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <ShowExportGLTFDialog>d__59(int <>1__state) { }

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
	private sealed class <ShowExportModelDialog>d__56 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <ShowExportModelDialog>d__56(int <>1__state) { }

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
	private sealed class <ShowImportModelDialog>d__64 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <ShowImportModelDialog>d__64(int <>1__state) { }

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
	private sealed class <ShowOpenDialog>d__84 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <ShowOpenDialog>d__84(int <>1__state) { }

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
	private sealed class <ShowSaveDialog>d__89 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <ShowSaveDialog>d__89(int <>1__state) { }

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

	internal enum PaintType : int
	{
		None = 0,
		Color = 1,
		Material = 2,
	}

	private struct ThumbnailImageTarget
	{
		[CompilerGenerated]
		private string <Url>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Image <Target>k__BackingField; //Field offset: 0x8

		public Image Target
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 13
		}

		public string Url
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 8
		}

		[CompilerGenerated]
		[IsReadOnly]
		public Image get_Target() { }

		[CompilerGenerated]
		[IsReadOnly]
		public string get_Url() { }

		[CompilerGenerated]
		public void set_Target(Image value) { }

		[CompilerGenerated]
		public void set_Url(string value) { }

	}

	public static CreatorController singleton; //Field offset: 0x0
	public static bool IsCreator; //Field offset: 0x8
	public static string externalScriptFolder; //Field offset: 0x10
	private static Random random; //Field offset: 0x18
	private static string saveLocation; //Field offset: 0x20
	[SerializeField]
	private string testCreatorToken; //Field offset: 0x68
	public VirtualizingTreeView TreeView; //Field offset: 0x70
	public CreatorPropertyGrid PropertyGrid; //Field offset: 0x78
	public Image[] activateButtons; //Field offset: 0x80
	public ColorPicker colorPicker; //Field offset: 0x88
	public Image[] colorDisplay; //Field offset: 0x90
	public Canvas canvas; //Field offset: 0x98
	public RectTransform landing; //Field offset: 0xA0
	public RectTransform materialSelector; //Field offset: 0xA8
	public RectTransform publishModal; //Field offset: 0xB0
	public RectTransform contextMenu; //Field offset: 0xB8
	public ColorPicker propertyColorPicker; //Field offset: 0xC0
	public TMP_Text statusBar; //Field offset: 0xC8
	public GameObject confirmExit; //Field offset: 0xD0
	private float moveSnap; //Field offset: 0xD8
	private float rotateSnap; //Field offset: 0xDC
	private bool moveSnapEnabled; //Field offset: 0xE0
	private bool rotateSnapEnabled; //Field offset: 0xE1
	public float autoSaveInterval; //Field offset: 0xE4
	private PaintType paintType; //Field offset: 0xE8
	private Color defaultButtonClr; //Field offset: 0xEC
	private Dictionary<String, BaseScript> externalScriptFiles; //Field offset: 0x100
	private FileSystemWatcher watcher; //Field offset: 0x108
	private Color paintColor; //Field offset: 0x110
	private PartMaterial paintMaterial; //Field offset: 0x120
	private int userID; //Field offset: 0x124
	private int gameID; //Field offset: 0x128
	private Vector3 mouseDownPosition; //Field offset: 0x12C
	[CompilerGenerated]
	private string <CreatorToken>k__BackingField; //Field offset: 0x138
	private List<Instance> selectionQueue; //Field offset: 0x140

	public private string CreatorToken
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	private static CreatorController() { }

	public CreatorController() { }

	[CompilerGenerated]
	private void <CheckToken>b__50_0(bool result) { }

	[CompilerGenerated]
	private void <LoadMapFromFile>b__87_0(bool r) { }

	public Instance Add(string instanceClass, string parentClass) { }

	public Instance AddInstance(string className, Instance parent = null, bool ignorePlacement = false) { }

	public void AddLocalScript() { }

	public void AddModuleScript() { }

	public void AddPart(PartShape shape = 0, string name = "Brick") { }

	public void AddPart(string shape) { }

	public void AddRemoteEvent() { }

	public void AddScript() { }

	public void AddSeat(string name = "Seat") { }

	public void AddSound() { }

	public void AddTruss() { }

	public void AddUI(string instanceClass) { }

	[IteratorStateMachine(typeof(<AutoSaveLoop>d__85))]
	private IEnumerator AutoSaveLoop() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<CheckToken>d__50))]
	private IEnumerator CheckToken() { }

	private List<Instance> ChildrenOf(Instance parent) { }

	private static int chmod(string path, int mode) { }

	public void ClearWorkspace() { }

	public void CloseContextMenu() { }

	public void CloseStartScreen() { }

	public void CopySelectionToClipboard() { }

	public void CutSelectionToClipboard() { }

	public void DeleteSelection() { }

	public void DoExit() { }

	private static void DoExportGLTF(string path) { }

	private static void DoExportModel(string path) { }

	private static void DoImportModel(String[] paths) { }

	private static void DoLoadMap(String[] paths) { }

	[IteratorStateMachine(typeof(<DoPublish>d__74))]
	private IEnumerator DoPublish() { }

	[IteratorStateMachine(typeof(<DoPublishModel>d__62))]
	private IEnumerator DoPublishModel() { }

	private static void DoSaveFile(string path) { }

	public void DuplicateSelection() { }

	private void EditScript(BaseScript script) { }

	public void ExportGLTF() { }

	public void ExportModel() { }

	public void FileOpen() { }

	public void FileSave(bool saveAs) { }

	private void GameLoaded() { }

	[CompilerGenerated]
	public string get_CreatorToken() { }

	private Dictionary<String, String> GetCommandLineArgs() { }

	public static List<Instance> GetSelectedInstances() { }

	public List<Instance> GetSelectedInstancesTreeView() { }

	public void GroupSelection() { }

	public void ImportModel() { }

	private bool IsEditingTextField() { }

	public static bool IsPointerOverUIObject() { }

	[IteratorStateMachine(typeof(<LoadMapFromFile>d__87))]
	private IEnumerator LoadMapFromFile(string path) { }

	[IteratorStateMachine(typeof(<LoadStarterPlaces>d__68))]
	private IEnumerator LoadStarterPlaces() { }

	[IteratorStateMachine(typeof(<LoadThumbnailImage>d__77))]
	private IEnumerator LoadThumbnailImage(string src, Image target) { }

	[IteratorStateMachine(typeof(<LoadThumbnailImages>d__75))]
	private IEnumerator LoadThumbnailImages(List<ThumbnailImageTarget> thumbnails) { }

	private void OnAppInitialized() { }

	private void OnItemBeginDrag(object sender, ItemArgs e) { }

	private void OnItemBeginDrop(object sender, ItemDropCancelArgs e) { }

	private void OnItemDataBinding(object sender, VirtualizingTreeViewItemDataBindingArgs e) { }

	private void OnItemDoubleClick(object sender, ItemArgs e) { }

	private void OnItemDrop(object sender, ItemDropArgs e) { }

	private void OnItemEndDrag(object sender, ItemArgs e) { }

	private void OnItemExpanding(object sender, VirtualizingItemExpandingArgs e) { }

	private void OnObjectSelectionChanged(ObjectSelectionChangedEventArgs args) { }

	private void OnPostDragEnd(Gizmo gizmo, int handleId) { }

	private void OnTreeSelectionChanged(object sender, SelectionChangedArgs e) { }

	public void PasteFromClipboard() { }

	public void PromptExit() { }

	private void PropertyGrid_ValueChanged(object obj, PropertyInfo propertyInfo) { }

	public void PublishGame() { }

	public void PublishGameOverwrite(int id) { }

	[IteratorStateMachine(typeof(<PublishLevelToID>d__81))]
	private IEnumerator PublishLevelToID(int id) { }

	public void PublishModel() { }

	public static string RandomString(int length) { }

	public void Redo() { }

	private void RelaunchCreator() { }

	private void ScriptEditedExternally(object sender, FileSystemEventArgs e) { }

	public void SelectChildren() { }

	[CompilerGenerated]
	private void set_CreatorToken(string value) { }

	public void SetActiveGizmo(string name) { }

	public void SetMoveSnapEnabled(bool enabled) { }

	public void SetMoveSnapSize(string snapString) { }

	public void SetPaintColor(Color c) { }

	public void SetPublishModalSelectedGame(JSONNode game) { }

	public void SetRotateSnapEnabled(bool enabled) { }

	public void SetRotateSnapSize(string snapString) { }

	public void SetStatusBarMessage(string message) { }

	private void ShowContextMenu() { }

	[IteratorStateMachine(typeof(<ShowExportGLTFDialog>d__59))]
	private IEnumerator ShowExportGLTFDialog() { }

	[IteratorStateMachine(typeof(<ShowExportModelDialog>d__56))]
	private IEnumerator ShowExportModelDialog() { }

	[IteratorStateMachine(typeof(<ShowImportModelDialog>d__64))]
	private IEnumerator ShowImportModelDialog() { }

	[IteratorStateMachine(typeof(<ShowOpenDialog>d__84))]
	private IEnumerator ShowOpenDialog() { }

	[IteratorStateMachine(typeof(<ShowSaveDialog>d__89))]
	private IEnumerator ShowSaveDialog() { }

	private void Start() { }

	public void TestGame() { }

	public void ToggleColorPicker() { }

	public void ToggleMaterialPicker() { }

	public void ToolboxModelAdded(Model i) { }

	public void Undo() { }

	public void UngroupSelection() { }

	private void Update() { }

	private static bool WantsToQuit() { }

	public virtual bool Weaved() { }

}

