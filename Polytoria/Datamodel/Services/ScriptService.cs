namespace Polytoria.Datamodel.Services;

public class ScriptService : Instance
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Instance, InstanceProxy> <>9__5_0; //Field offset: 0x8
		public static Func<DynamicInstance, DynamicInstanceProxy> <>9__5_1; //Field offset: 0x10
		public static Func<Part, PartProxy> <>9__5_2; //Field offset: 0x18
		public static Func<Game, GameProxy> <>9__5_3; //Field offset: 0x20
		public static Func<BaseScript, BaseScriptProxy> <>9__5_4; //Field offset: 0x28
		public static Func<ScriptInstance, ScriptInstanceProxy> <>9__5_5; //Field offset: 0x30
		public static Func<LocalScript, LocalScriptProxy> <>9__5_6; //Field offset: 0x38
		public static Func<ModuleScript, ModuleScriptProxy> <>9__5_7; //Field offset: 0x40
		public static Func<RemoteEvent, RemoveEventProxy> <>9__5_8; //Field offset: 0x48
		public static Func<Environment, EnvironmentProxy> <>9__5_9; //Field offset: 0x50
		public static Func<Player, PlayerProxy> <>9__5_10; //Field offset: 0x58
		public static Func<Players, PlayersProxy> <>9__5_11; //Field offset: 0x60
		public static Func<Text3D, Text3DProxy> <>9__5_12; //Field offset: 0x68
		public static Func<Sound, SoundProxy> <>9__5_13; //Field offset: 0x70
		public static Func<Tool, ToolProxy> <>9__5_14; //Field offset: 0x78
		public static Func<NPC, NPCProxy> <>9__5_15; //Field offset: 0x80
		public static Func<Spotlight, SpotlightProxy> <>9__5_16; //Field offset: 0x88
		public static Func<ValueBase, ValueBaseProxy> <>9__5_17; //Field offset: 0x90
		public static Func<BoolValue, BoolValueProxy> <>9__5_18; //Field offset: 0x98
		public static Func<ColorValue, ColorValueProxy> <>9__5_19; //Field offset: 0xA0
		public static Func<StringValue, StringValueProxy> <>9__5_20; //Field offset: 0xA8
		public static Func<InstanceValue, InstanceValueProxy> <>9__5_21; //Field offset: 0xB0
		public static Func<IntValue, IntValueProxy> <>9__5_22; //Field offset: 0xB8
		public static Func<NumberValue, NumberValueProxy> <>9__5_23; //Field offset: 0xC0
		public static Func<Vector3Value, Vector3ValueProxy> <>9__5_24; //Field offset: 0xC8
		public static Func<MeshPart, MeshPartProxy> <>9__5_25; //Field offset: 0xD0
		public static Func<BodyPosition, BodyPositionProxy> <>9__5_26; //Field offset: 0xD8
		public static Func<Backpack, BackpackProxy> <>9__5_27; //Field offset: 0xE0
		public static Func<Lighting, LightingProxy> <>9__5_28; //Field offset: 0xE8
		public static Func<SunLight, SunLightProxy> <>9__5_29; //Field offset: 0xF0
		public static Func<Climbable, ClimbableProxy> <>9__5_30; //Field offset: 0xF8
		public static Func<Decal, DecalProxy> <>9__5_31; //Field offset: 0x100
		public static Func<Particles, ParticlesProxy> <>9__5_32; //Field offset: 0x108
		public static Func<Hidden, HiddenProxy> <>9__5_33; //Field offset: 0x110
		public static Func<ServerHidden, ServerHiddenProxy> <>9__5_34; //Field offset: 0x118
		public static Func<Model, ModelProxy> <>9__5_35; //Field offset: 0x120
		public static Func<PointLight, PointLightProxy> <>9__5_36; //Field offset: 0x128
		public static Func<Truss, TrussProxy> <>9__5_37; //Field offset: 0x130
		public static Func<Seat, SeatProxy> <>9__5_38; //Field offset: 0x138
		public static Func<SkyBase, SkyBaseProxy> <>9__5_39; //Field offset: 0x140
		public static Func<ImageSky, ImageSkyProxy> <>9__5_40; //Field offset: 0x148
		public static Func<GradientSky, GradientSkyProxy> <>9__5_41; //Field offset: 0x150
		public static Func<ProceduralSky, ProceduralSkyProxy> <>9__5_42; //Field offset: 0x158
		public static Func<NetworkEvent, NetworkEventProxy> <>9__5_43; //Field offset: 0x160
		public static Func<Signal, SignalProxy> <>9__5_44; //Field offset: 0x168
		public static Func<PlayerDefaults, PlayerDefaultsProxy> <>9__5_45; //Field offset: 0x170
		public static Func<GUI, GUIProxy> <>9__5_46; //Field offset: 0x178
		public static Func<UIButton, UIButtonProxy> <>9__5_47; //Field offset: 0x180
		public static Func<UIField, UIFieldProxy> <>9__5_48; //Field offset: 0x188
		public static Func<UILabel, UILabelProxy> <>9__5_49; //Field offset: 0x190
		public static Func<UITextInput, UITextInputProxy> <>9__5_50; //Field offset: 0x198
		public static Func<UIView, UIViewProxy> <>9__5_51; //Field offset: 0x1A0
		public static Func<UIImage, UIImageProxy> <>9__5_52; //Field offset: 0x1A8
		public static Func<UIHVLayout, UIHVLayoutProxy> <>9__5_53; //Field offset: 0x1B0
		public static Func<UIVerticalLayout, UIVerticalLayoutProxy> <>9__5_54; //Field offset: 0x1B8
		public static Func<UIHorizontalLayout, UIHorizontalLayoutProxy> <>9__5_55; //Field offset: 0x1C0
		public static Func<PlayerGUI, PlayerGUIProxy> <>9__5_56; //Field offset: 0x1C8
		public static Func<Camera, CameraProxy> <>9__5_57; //Field offset: 0x1D0
		public static Func<Datastore, DatastoreProxy> <>9__5_58; //Field offset: 0x1D8
		public static Func<AchievementService, AchievementServiceProxy> <>9__5_59; //Field offset: 0x1E0
		public static Func<PurchasesService, PurchasesServiceProxy> <>9__5_60; //Field offset: 0x1E8
		public static Func<ChatService, ChatServiceProxy> <>9__5_61; //Field offset: 0x1F0
		public static Func<CoreUIService, CoreUIServiceProxy> <>9__5_62; //Field offset: 0x1F8
		public static Func<Datastore, DatastoreProxy> <>9__5_63; //Field offset: 0x200
		public static Func<DataStoreService, DataStoreServiceProxy> <>9__5_64; //Field offset: 0x208
		public static Func<FilterService, FilterServiceProxy> <>9__5_65; //Field offset: 0x210
		public static Func<HttpService, HttpServiceProxy> <>9__5_66; //Field offset: 0x218
		public static Func<InputService, InputServiceProxy> <>9__5_67; //Field offset: 0x220
		public static Func<InsertService, InsertServiceProxy> <>9__5_68; //Field offset: 0x228
		public static Func<TweenService, TweenServiceProxy> <>9__5_69; //Field offset: 0x230
		public static Action<BaseScript> <>9__14_0; //Field offset: 0x238
		public static Action<BaseScript> <>9__15_0; //Field offset: 0x240

		private static <>c() { }

		public <>c() { }

		internal InstanceProxy <Awake>b__5_0(Instance r) { }

		internal DynamicInstanceProxy <Awake>b__5_1(DynamicInstance r) { }

		internal PlayerProxy <Awake>b__5_10(Player r) { }

		internal PlayersProxy <Awake>b__5_11(Players r) { }

		internal Text3DProxy <Awake>b__5_12(Text3D r) { }

		internal SoundProxy <Awake>b__5_13(Sound r) { }

		internal ToolProxy <Awake>b__5_14(Tool r) { }

		internal NPCProxy <Awake>b__5_15(NPC r) { }

		internal SpotlightProxy <Awake>b__5_16(Spotlight r) { }

		internal ValueBaseProxy <Awake>b__5_17(ValueBase r) { }

		internal BoolValueProxy <Awake>b__5_18(BoolValue r) { }

		internal ColorValueProxy <Awake>b__5_19(ColorValue r) { }

		internal PartProxy <Awake>b__5_2(Part r) { }

		internal StringValueProxy <Awake>b__5_20(StringValue r) { }

		internal InstanceValueProxy <Awake>b__5_21(InstanceValue r) { }

		internal IntValueProxy <Awake>b__5_22(IntValue r) { }

		internal NumberValueProxy <Awake>b__5_23(NumberValue r) { }

		internal Vector3ValueProxy <Awake>b__5_24(Vector3Value r) { }

		internal MeshPartProxy <Awake>b__5_25(MeshPart r) { }

		internal BodyPositionProxy <Awake>b__5_26(BodyPosition r) { }

		internal BackpackProxy <Awake>b__5_27(Backpack r) { }

		internal LightingProxy <Awake>b__5_28(Lighting r) { }

		internal SunLightProxy <Awake>b__5_29(SunLight r) { }

		internal GameProxy <Awake>b__5_3(Game r) { }

		internal ClimbableProxy <Awake>b__5_30(Climbable r) { }

		internal DecalProxy <Awake>b__5_31(Decal r) { }

		internal ParticlesProxy <Awake>b__5_32(Particles r) { }

		internal HiddenProxy <Awake>b__5_33(Hidden r) { }

		internal ServerHiddenProxy <Awake>b__5_34(ServerHidden r) { }

		internal ModelProxy <Awake>b__5_35(Model r) { }

		internal PointLightProxy <Awake>b__5_36(PointLight r) { }

		internal TrussProxy <Awake>b__5_37(Truss r) { }

		internal SeatProxy <Awake>b__5_38(Seat r) { }

		internal SkyBaseProxy <Awake>b__5_39(SkyBase r) { }

		internal BaseScriptProxy <Awake>b__5_4(BaseScript r) { }

		internal ImageSkyProxy <Awake>b__5_40(ImageSky r) { }

		internal GradientSkyProxy <Awake>b__5_41(GradientSky r) { }

		internal ProceduralSkyProxy <Awake>b__5_42(ProceduralSky r) { }

		internal NetworkEventProxy <Awake>b__5_43(NetworkEvent r) { }

		internal SignalProxy <Awake>b__5_44(Signal r) { }

		internal PlayerDefaultsProxy <Awake>b__5_45(PlayerDefaults r) { }

		internal GUIProxy <Awake>b__5_46(GUI r) { }

		internal UIButtonProxy <Awake>b__5_47(UIButton r) { }

		internal UIFieldProxy <Awake>b__5_48(UIField r) { }

		internal UILabelProxy <Awake>b__5_49(UILabel r) { }

		internal ScriptInstanceProxy <Awake>b__5_5(ScriptInstance r) { }

		internal UITextInputProxy <Awake>b__5_50(UITextInput r) { }

		internal UIViewProxy <Awake>b__5_51(UIView r) { }

		internal UIImageProxy <Awake>b__5_52(UIImage r) { }

		internal UIHVLayoutProxy <Awake>b__5_53(UIHVLayout r) { }

		internal UIVerticalLayoutProxy <Awake>b__5_54(UIVerticalLayout r) { }

		internal UIHorizontalLayoutProxy <Awake>b__5_55(UIHorizontalLayout r) { }

		internal PlayerGUIProxy <Awake>b__5_56(PlayerGUI r) { }

		internal CameraProxy <Awake>b__5_57(Camera r) { }

		internal DatastoreProxy <Awake>b__5_58(Datastore r) { }

		internal AchievementServiceProxy <Awake>b__5_59(AchievementService r) { }

		internal LocalScriptProxy <Awake>b__5_6(LocalScript r) { }

		internal PurchasesServiceProxy <Awake>b__5_60(PurchasesService r) { }

		internal ChatServiceProxy <Awake>b__5_61(ChatService r) { }

		internal CoreUIServiceProxy <Awake>b__5_62(CoreUIService r) { }

		internal DatastoreProxy <Awake>b__5_63(Datastore r) { }

		internal DataStoreServiceProxy <Awake>b__5_64(DataStoreService r) { }

		internal FilterServiceProxy <Awake>b__5_65(FilterService r) { }

		internal HttpServiceProxy <Awake>b__5_66(HttpService r) { }

		internal InputServiceProxy <Awake>b__5_67(InputService r) { }

		internal InsertServiceProxy <Awake>b__5_68(InsertService r) { }

		internal TweenServiceProxy <Awake>b__5_69(TweenService r) { }

		internal ModuleScriptProxy <Awake>b__5_7(ModuleScript r) { }

		internal RemoveEventProxy <Awake>b__5_8(RemoteEvent r) { }

		internal EnvironmentProxy <Awake>b__5_9(Environment r) { }

		internal void <RunLocalScripts>b__15_0(BaseScript s) { }

		internal void <RunScripts>b__14_0(BaseScript s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public ScriptService <>4__this; //Field offset: 0x10
		public Script script; //Field offset: 0x18

		public <>c__DisplayClass25_0() { }

		internal void <RunScriptInstance>b__0(string s) { }

		internal DynValue <RunScriptInstance>b__1(ModuleScript ms) { }

	}

	[CompilerGenerated]
	private sealed class <InvokeEvent>d__33 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public DynValue func; //Field offset: 0x20
		public ScriptService <>4__this; //Field offset: 0x28
		public Object[] par; //Field offset: 0x30
		private DynValue <coroutine>5__2; //Field offset: 0x38

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
		public <InvokeEvent>d__33(int <>1__state) { }

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
	private sealed class <RunScriptInstance>d__25 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ScriptService <>4__this; //Field offset: 0x20
		public BaseScript scriptInstance; //Field offset: 0x28
		private <>c__DisplayClass25_0 <>8__1; //Field offset: 0x30
		private DynValue <coroutine>5__2; //Field offset: 0x38
		private float <timeout>5__3; //Field offset: 0x40

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
		public <RunScriptInstance>d__25(int <>1__state) { }

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
	private static ScriptService <Instance>k__BackingField; //Field offset: 0x0
	public const string payload = "function wait(N)
coroutine.yield(N);
return os.time();
end"; //Field offset: 0x0
	private List<BaseScript> scripts; //Field offset: 0xF8
	private List<BaseScript> scriptsLocal; //Field offset: 0x100
	private HashSet<String> allowList; //Field offset: 0x108
	private RSACryptoServiceProvider rsa; //Field offset: 0x110
	private bool receivedAllowlist; //Field offset: 0x118
	private String[] _hashes; //Field offset: 0x120
	private Byte[] _signature; //Field offset: 0x128
	private string _pubKey; //Field offset: 0x130

	public private static ScriptService Instance
	{
		[CompilerGenerated]
		 get { } //Length: 78
		[CompilerGenerated]
		private set { } //Length: 105
	}

	private static ScriptService() { }

	public ScriptService() { }

	protected virtual void Awake() { }

	[MoonSharpHidden]
	public void CallFunc(DynValue func, Object[] par) { }

	private void CheckForLocalScripts(Instance parent) { }

	private void CheckForScripts(Instance parent) { }

	private DynValue ExecuteScriptInstance(Script script, BaseScript s) { }

	private float GameTime() { }

	private void GenerateAllowList() { }

	[CompilerGenerated]
	public static ScriptService get_Instance() { }

	private void GetLocalScripts(Instance parent, List<LocalScript> results) { }

	[IteratorStateMachine(typeof(<InvokeEvent>d__33))]
	[MoonSharpHidden]
	public IEnumerator InvokeEvent(DynValue func, Object[] par) { }

	protected static void InvokeUserCode_RpcOnLuaPrintReceive__String__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_RpcReceiveAllowlist__String[]__Byte[]__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	protected static void InvokeUserCode_TargetReceiveAllowList__NetworkConnection__String[]__Byte[]__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	public void LuaPrint(string message, bool error = false) { }

	public DynValue LuaRequire(ModuleScript moduleScript, Script script) { }

	public void LuaSpawn(DynValue func) { }

	private void ReceivedAllowList(String[] hashes, Byte[] sig, string pubKey) { }

	private DynValue ResumeScriptCoroutine(DynValue coroutine, string identifier, Object[] par) { }

	[ClientRpc]
	private void RpcOnLuaPrintReceive(string message, bool error) { }

	[ClientRpc]
	public void RpcReceiveAllowlist(String[] hashes, Byte[] sig, string pubKey) { }

	[MoonSharpHidden]
	public void RunLocalScripts() { }

	[MoonSharpHidden]
	public void RunScript(BaseScript s) { }

	[IteratorStateMachine(typeof(<RunScriptInstance>d__25))]
	private IEnumerator RunScriptInstance(BaseScript scriptInstance) { }

	[MoonSharpHidden]
	public void RunScripts() { }

	public void SendAllowList(Player player) { }

	[CompilerGenerated]
	private static void set_Instance(ScriptService value) { }

	[TargetRpc]
	public void TargetReceiveAllowList(NetworkConnection target, String[] hashes, Byte[] sig, string pubKey) { }

	private float Tick() { }

	protected void UserCode_RpcOnLuaPrintReceive__String__Boolean(string message, bool error) { }

	protected void UserCode_RpcReceiveAllowlist__String[]__Byte[]__String(String[] hashes, Byte[] sig, string pubKey) { }

	protected void UserCode_TargetReceiveAllowList__NetworkConnection__String[]__Byte[]__String(NetworkConnection target, String[] hashes, Byte[] sig, string pubKey) { }

	public virtual bool Weaved() { }

}

