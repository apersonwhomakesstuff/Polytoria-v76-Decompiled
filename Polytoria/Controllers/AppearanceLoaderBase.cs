namespace Polytoria.Controllers;

public class AppearanceLoaderBase : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class <ApplyBodyParts>d__62 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AppearanceLoaderBase <>4__this; //Field offset: 0x20
		private GameObject <go>5__2; //Field offset: 0x28
		private GltfImport <gltf>5__3; //Field offset: 0x30
		private Task<Boolean> <t>5__4; //Field offset: 0x38
		private Task<Boolean> <task>5__5; //Field offset: 0x40

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
		public <ApplyBodyParts>d__62(int <>1__state) { }

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
	private sealed class <ApplyHats>d__60 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AppearanceLoaderBase <>4__this; //Field offset: 0x20
		private Enumerator<String> <>7__wrap1; //Field offset: 0x28
		private string <url>5__3; //Field offset: 0x40
		private GameObject <hat>5__4; //Field offset: 0x48
		private GltfImport <gltf>5__5; //Field offset: 0x50
		private Task<Boolean> <t>5__6; //Field offset: 0x58
		private Task<Boolean> <task>5__7; //Field offset: 0x60

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
		public <ApplyHats>d__60(int <>1__state) { }

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
	private sealed class <ProcessAppearance>d__57 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public int userID; //Field offset: 0x20
		public AppearanceLoaderBase <>4__this; //Field offset: 0x28
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
		public <ProcessAppearance>d__57(int <>1__state) { }

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

	private static Dictionary<Int32, AppearanceData> playerAppearanceCache; //Field offset: 0x0
	protected Transform headObj; //Field offset: 0x68
	protected Transform torsoObj; //Field offset: 0x70
	protected Mesh defaultTorsoMesh; //Field offset: 0x78
	private int currentlyLoadingUserID; //Field offset: 0x80
	[SyncVar(hook = "ColorChanged")]
	protected Color headColor; //Field offset: 0x84
	[SyncVar(hook = "ColorChanged")]
	protected Color torsoColor; //Field offset: 0x94
	[SyncVar(hook = "ColorChanged")]
	protected Color leftArmColor; //Field offset: 0xA4
	[SyncVar(hook = "ColorChanged")]
	protected Color rightArmColor; //Field offset: 0xB4
	[SyncVar(hook = "ColorChanged")]
	protected Color leftLegColor; //Field offset: 0xC4
	[SyncVar(hook = "ColorChanged")]
	protected Color rightLegColor; //Field offset: 0xD4
	[SyncVar(hook = "ClothingChanged")]
	protected int faceID; //Field offset: 0xE4
	[SyncVar(hook = "ClothingChanged")]
	protected int shirtID; //Field offset: 0xE8
	[SyncVar(hook = "ClothingChanged")]
	protected int pantsID; //Field offset: 0xEC
	[SyncVar]
	protected int torsoID; //Field offset: 0xF0
	[SerializeField]
	protected readonly SyncList<String> hatUrls; //Field offset: 0xF8
	[SyncVar(hook = "BodyChanged")]
	private string torsoUrl; //Field offset: 0x100
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_headColor; //Field offset: 0x108
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_torsoColor; //Field offset: 0x110
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_leftArmColor; //Field offset: 0x118
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_rightArmColor; //Field offset: 0x120
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_leftLegColor; //Field offset: 0x128
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_rightLegColor; //Field offset: 0x130
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_faceID; //Field offset: 0x138
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_shirtID; //Field offset: 0x140
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_pantsID; //Field offset: 0x148
	public Action<String, String> _Mirror_SyncVarHookDelegate_torsoUrl; //Field offset: 0x150

	public int FaceID
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public Color HeadColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public Color LeftArmColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public Color LeftLegColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public int NetworkfaceID
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public Color NetworkheadColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public Color NetworkleftArmColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public Color NetworkleftLegColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public int NetworkpantsID
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public Color NetworkrightArmColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public Color NetworkrightLegColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public int NetworkshirtID
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public Color NetworktorsoColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public int NetworktorsoID
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	public string NetworktorsoUrl
	{
		 get { } //Length: 8
		 set { } //Length: 319
	}

	public int PantsID
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public Color RightArmColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public Color RightLegColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public int ShirtID
	{
		 get { } //Length: 7
		 set { } //Length: 101
	}

	public Color TorsoColor
	{
		 get { } //Length: 14
		 set { } //Length: 113
	}

	public int TorsoID
	{
		 get { } //Length: 7
		 set { } //Length: 177
	}

	private static AppearanceLoaderBase() { }

	public AppearanceLoaderBase() { }

	private void ApplyAppearance(AppearanceData data) { }

	[IteratorStateMachine(typeof(<ApplyBodyParts>d__62))]
	private IEnumerator ApplyBodyParts() { }

	[IteratorStateMachine(typeof(<ApplyHats>d__60))]
	private IEnumerator ApplyHats() { }

	protected override void Awake() { }

	private void BodyChanged(string oldBody, string newBody) { }

	public override void ClearAppearance() { }

	private void ClothingChanged(int oldClothing, int newClothing) { }

	private void ColorChanged(Color oldColor, Color newColor) { }

	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	public int get_FaceID() { }

	public Color get_HeadColor() { }

	public Color get_LeftArmColor() { }

	public Color get_LeftLegColor() { }

	public int get_NetworkfaceID() { }

	public Color get_NetworkheadColor() { }

	public Color get_NetworkleftArmColor() { }

	public Color get_NetworkleftLegColor() { }

	public int get_NetworkpantsID() { }

	public Color get_NetworkrightArmColor() { }

	public Color get_NetworkrightLegColor() { }

	public int get_NetworkshirtID() { }

	public Color get_NetworktorsoColor() { }

	public int get_NetworktorsoID() { }

	public string get_NetworktorsoUrl() { }

	public int get_PantsID() { }

	public Color get_RightArmColor() { }

	public Color get_RightLegColor() { }

	public int get_ShirtID() { }

	public Color get_TorsoColor() { }

	public int get_TorsoID() { }

	protected override void HatLoaded(GameObject hat) { }

	private void HatsChanged(Operation<String> op, int itemIndex, string oldItem, string newItem) { }

	public void LoadAppearance(int userID) { }

	public virtual void OnStartClient() { }

	[IteratorStateMachine(typeof(<ProcessAppearance>d__57))]
	private IEnumerator ProcessAppearance(int userID) { }

	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	public void set_FaceID(int value) { }

	public void set_HeadColor(Color value) { }

	public void set_LeftArmColor(Color value) { }

	public void set_LeftLegColor(Color value) { }

	public void set_NetworkfaceID(in int value) { }

	public void set_NetworkheadColor(in Color value) { }

	public void set_NetworkleftArmColor(in Color value) { }

	public void set_NetworkleftLegColor(in Color value) { }

	public void set_NetworkpantsID(in int value) { }

	public void set_NetworkrightArmColor(in Color value) { }

	public void set_NetworkrightLegColor(in Color value) { }

	public void set_NetworkshirtID(in int value) { }

	public void set_NetworktorsoColor(in Color value) { }

	public void set_NetworktorsoID(in int value) { }

	public void set_NetworktorsoUrl(in string value) { }

	public void set_PantsID(int value) { }

	public void set_RightArmColor(Color value) { }

	public void set_RightLegColor(Color value) { }

	public void set_ShirtID(int value) { }

	public void set_TorsoColor(Color value) { }

	public void set_TorsoID(int value) { }

	private void UpdateBodyParts() { }

	protected override void UpdateClothing() { }

	protected override void UpdateColors() { }

	private void UpdateHats() { }

	public virtual bool Weaved() { }

}

