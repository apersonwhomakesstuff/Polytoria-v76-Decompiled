namespace Polytoria.Controllers;

public class GameIO : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<PropertyInfo, Boolean> <>9__25_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <SaveHandleChild>b__25_0(PropertyInfo prop) { }

	}

	[CompilerGenerated]
	private sealed class <LoadFromSite>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public int id; //Field offset: 0x20
		public GameIO <>4__this; //Field offset: 0x28
		public Action<Boolean> callback; //Field offset: 0x30
		private UnityWebRequest <uwr>5__2; //Field offset: 0x38

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
		public <LoadFromSite>d__13(int <>1__state) { }

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
	private sealed class <ModelFromSite>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public int id; //Field offset: 0x20
		public GameIO <>4__this; //Field offset: 0x28
		public Instance parent; //Field offset: 0x30
		public Action<Instance> callback; //Field offset: 0x38
		private UnityWebRequest <uwr>5__2; //Field offset: 0x40

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
		public <ModelFromSite>d__12(int <>1__state) { }

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
	private sealed class <PostClearDatamodel>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GameIO <>4__this; //Field offset: 0x20

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
		public <PostClearDatamodel>d__10(int <>1__state) { }

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

	public static GameIO singleton; //Field offset: 0x0
	private Game game; //Field offset: 0x20
	private List<Instance> spawnInstances; //Field offset: 0x28

	public GameIO() { }

	private void Awake() { }

	public void ClearDatamodel() { }

	private Instance HandleXmlNodes(XmlNodeList nodes, Instance parent) { }

	public void Load(int id, Action<Boolean> callback = null) { }

	public void LoadFromFile(string path, Action<Boolean> callback = null) { }

	[IteratorStateMachine(typeof(<LoadFromSite>d__13))]
	public IEnumerator LoadFromSite(int id, Action<Boolean> callback = null) { }

	public Instance LoadModelFromFile(string path, Instance parent) { }

	public void LoadModelFromSite(int id, Instance parent, Action<Instance> callback = null) { }

	public Model LoadModelFromXmlString(string xmlString, Instance parent) { }

	private Instance LoadXml(XmlNode xml, Instance parent = null) { }

	[IteratorStateMachine(typeof(<ModelFromSite>d__12))]
	public IEnumerator ModelFromSite(int id, Instance parent, Action<Instance> callback) { }

	[IteratorStateMachine(typeof(<PostClearDatamodel>d__10))]
	private IEnumerator PostClearDatamodel() { }

	public void PostMapLoad() { }

	private void SaveBool(XmlDocument doc, XmlElement properties, string name, bool value) { }

	private void SaveColor(XmlDocument doc, XmlElement properties, string name, Color value) { }

	private void SaveColorRange(XmlDocument doc, XmlElement properties, string name, ColorRange value) { }

	private void SaveFloat(XmlDocument doc, XmlElement properties, string name, float value) { }

	private void SaveHandleChild(XmlDocument doc, Instance i, XmlElement parent) { }

	private void SaveInt(XmlDocument doc, XmlElement properties, string name, int value) { }

	public void SaveModelToFile(Instance root, string path) { }

	public string SaveModelToString(Instance root) { }

	private void SaveNumberRange(XmlDocument doc, XmlElement properties, string name, NumberRange value) { }

	private void SaveString(XmlDocument doc, XmlElement properties, string name, string value) { }

	public void SaveToFile(string path) { }

	public string SaveToString() { }

	private void SaveVector2(XmlDocument doc, XmlElement properties, string name, Vector2 value) { }

	private void SaveVector3(XmlDocument doc, XmlElement properties, string name, Vector3 value) { }

	public Color XmlConvertColor(XmlNode property) { }

	public ColorRange XmlConvertColorRange(XmlNode property) { }

	public NumberRange XmlConvertNumberRange(XmlNode property) { }

	public Vector2 XmlConvertVector2(XmlNode property) { }

	public Vector3 XmlConvertVector3(XmlNode property) { }

}

