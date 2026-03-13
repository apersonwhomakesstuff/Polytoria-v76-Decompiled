using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Datamodel.Proxies;
using Polytoria.Datamodel.Proxies.Services;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002CC RID: 716
	public class ScriptService : Instance
	{
		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x0001BF02 File Offset: 0x0001A102
		// (set) Token: 0x06002416 RID: 9238 RVA: 0x0001BF09 File Offset: 0x0001A109
		public static ScriptService Instance
		{
			get
			{
				return ScriptService.<Instance>k__BackingField;
			}
			private set
			{
				ScriptService.<Instance>k__BackingField = value;
			}
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x0001BF11 File Offset: 0x0001A111
		protected override void Awake()
		{
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x0001BF13 File Offset: 0x0001A113
		public void RunScripts()
		{
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x0001BF15 File Offset: 0x0001A115
		public void RunLocalScripts()
		{
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x0001BF17 File Offset: 0x0001A117
		private void GenerateAllowList()
		{
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x0001BF19 File Offset: 0x0001A119
		public void SendAllowList(Player player)
		{
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x0001BF1B File Offset: 0x0001A11B
		public void TargetReceiveAllowList(NetworkConnection target, string[] hashes, byte[] sig, string pubKey)
		{
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x0001BF1D File Offset: 0x0001A11D
		private void GetLocalScripts(Instance parent, List<LocalScript> results)
		{
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x0001BF1F File Offset: 0x0001A11F
		public void RpcReceiveAllowlist(string[] hashes, byte[] sig, string pubKey)
		{
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x0001BF21 File Offset: 0x0001A121
		private void ReceivedAllowList(string[] hashes, byte[] sig, string pubKey)
		{
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x0001BF23 File Offset: 0x0001A123
		private void CheckForLocalScripts(Instance parent)
		{
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x0001BF25 File Offset: 0x0001A125
		private void CheckForScripts(Instance parent)
		{
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x0001BF27 File Offset: 0x0001A127
		public void RunScript(BaseScript s)
		{
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0001BF29 File Offset: 0x0001A129
		private IEnumerator RunScriptInstance(BaseScript scriptInstance)
		{
			return null;
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x0001BF2C File Offset: 0x0001A12C
		public void LuaSpawn(DynValue func)
		{
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x0001BF2E File Offset: 0x0001A12E
		public DynValue LuaRequire(ModuleScript moduleScript, Script script)
		{
			return null;
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x0001BF31 File Offset: 0x0001A131
		public void LuaPrint(string message, bool error = false)
		{
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x0001BF33 File Offset: 0x0001A133
		private void RpcOnLuaPrintReceive(string message, bool error)
		{
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x0001BF35 File Offset: 0x0001A135
		private DynValue ResumeScriptCoroutine(DynValue coroutine, string identifier, object[] par)
		{
			return null;
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x0001BF38 File Offset: 0x0001A138
		private DynValue ExecuteScriptInstance(Script script, BaseScript s)
		{
			return null;
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x0001BF3B File Offset: 0x0001A13B
		public void CallFunc(DynValue func, object[] par)
		{
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x0001BF3D File Offset: 0x0001A13D
		public IEnumerator InvokeEvent(DynValue func, object[] par)
		{
			return null;
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0001BF40 File Offset: 0x0001A140
		private float Tick()
		{
			return 0f;
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x0001BF47 File Offset: 0x0001A147
		private float GameTime()
		{
			return 0f;
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x0001BF56 File Offset: 0x0001A156
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x0001BF59 File Offset: 0x0001A159
		protected void UserCode_TargetReceiveAllowList__NetworkConnection__String[]__Byte[]__String(NetworkConnection target, string[] hashes, byte[] sig, string pubKey)
		{
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x0001BF5B File Offset: 0x0001A15B
		protected static void InvokeUserCode_TargetReceiveAllowList__NetworkConnection__String[]__Byte[]__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x0001BF5D File Offset: 0x0001A15D
		protected void UserCode_RpcReceiveAllowlist__String[]__Byte[]__String(string[] hashes, byte[] sig, string pubKey)
		{
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x0001BF5F File Offset: 0x0001A15F
		protected static void InvokeUserCode_RpcReceiveAllowlist__String[]__Byte[]__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x0001BF61 File Offset: 0x0001A161
		protected void UserCode_RpcOnLuaPrintReceive__String__Boolean(string message, bool error)
		{
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x0001BF63 File Offset: 0x0001A163
		protected static void InvokeUserCode_RpcOnLuaPrintReceive__String__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x04000CF0 RID: 3312
		private static ScriptService <Instance>k__BackingField;

		// Token: 0x04000CF1 RID: 3313
		public const string payload = "function wait(N)\ncoroutine.yield(N);\nreturn os.time();\nend";

		// Token: 0x04000CF2 RID: 3314
		private List<BaseScript> scripts;

		// Token: 0x04000CF3 RID: 3315
		private List<BaseScript> scriptsLocal;

		// Token: 0x04000CF4 RID: 3316
		private HashSet<string> allowList;

		// Token: 0x04000CF5 RID: 3317
		private RSACryptoServiceProvider rsa;

		// Token: 0x04000CF6 RID: 3318
		private bool receivedAllowlist;

		// Token: 0x04000CF7 RID: 3319
		private string[] _hashes;

		// Token: 0x04000CF8 RID: 3320
		private byte[] _signature;

		// Token: 0x04000CF9 RID: 3321
		private string _pubKey;

		// Token: 0x02000408 RID: 1032
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002C26 RID: 11302 RVA: 0x0001D82A File Offset: 0x0001BA2A
			internal InstanceProxy <Awake>b__5_0(Instance r)
			{
				return null;
			}

			// Token: 0x06002C27 RID: 11303 RVA: 0x0001D82D File Offset: 0x0001BA2D
			internal DynamicInstanceProxy <Awake>b__5_1(DynamicInstance r)
			{
				return null;
			}

			// Token: 0x06002C28 RID: 11304 RVA: 0x0001D830 File Offset: 0x0001BA30
			internal PartProxy <Awake>b__5_2(Part r)
			{
				return null;
			}

			// Token: 0x06002C29 RID: 11305 RVA: 0x0001D833 File Offset: 0x0001BA33
			internal GameProxy <Awake>b__5_3(Game r)
			{
				return null;
			}

			// Token: 0x06002C2A RID: 11306 RVA: 0x0001D836 File Offset: 0x0001BA36
			internal BaseScriptProxy <Awake>b__5_4(BaseScript r)
			{
				return null;
			}

			// Token: 0x06002C2B RID: 11307 RVA: 0x0001D839 File Offset: 0x0001BA39
			internal ScriptInstanceProxy <Awake>b__5_5(ScriptInstance r)
			{
				return null;
			}

			// Token: 0x06002C2C RID: 11308 RVA: 0x0001D83C File Offset: 0x0001BA3C
			internal LocalScriptProxy <Awake>b__5_6(LocalScript r)
			{
				return null;
			}

			// Token: 0x06002C2D RID: 11309 RVA: 0x0001D83F File Offset: 0x0001BA3F
			internal ModuleScriptProxy <Awake>b__5_7(ModuleScript r)
			{
				return null;
			}

			// Token: 0x06002C2E RID: 11310 RVA: 0x0001D842 File Offset: 0x0001BA42
			internal RemoveEventProxy <Awake>b__5_8(RemoteEvent r)
			{
				return null;
			}

			// Token: 0x06002C2F RID: 11311 RVA: 0x0001D845 File Offset: 0x0001BA45
			internal EnvironmentProxy <Awake>b__5_9(Environment r)
			{
				return null;
			}

			// Token: 0x06002C30 RID: 11312 RVA: 0x0001D848 File Offset: 0x0001BA48
			internal PlayerProxy <Awake>b__5_10(Player r)
			{
				return null;
			}

			// Token: 0x06002C31 RID: 11313 RVA: 0x0001D84B File Offset: 0x0001BA4B
			internal PlayersProxy <Awake>b__5_11(Players r)
			{
				return null;
			}

			// Token: 0x06002C32 RID: 11314 RVA: 0x0001D84E File Offset: 0x0001BA4E
			internal Text3DProxy <Awake>b__5_12(Text3D r)
			{
				return null;
			}

			// Token: 0x06002C33 RID: 11315 RVA: 0x0001D851 File Offset: 0x0001BA51
			internal SoundProxy <Awake>b__5_13(Sound r)
			{
				return null;
			}

			// Token: 0x06002C34 RID: 11316 RVA: 0x0001D854 File Offset: 0x0001BA54
			internal ToolProxy <Awake>b__5_14(Tool r)
			{
				return null;
			}

			// Token: 0x06002C35 RID: 11317 RVA: 0x0001D857 File Offset: 0x0001BA57
			internal NPCProxy <Awake>b__5_15(NPC r)
			{
				return null;
			}

			// Token: 0x06002C36 RID: 11318 RVA: 0x0001D85A File Offset: 0x0001BA5A
			internal SpotlightProxy <Awake>b__5_16(Spotlight r)
			{
				return null;
			}

			// Token: 0x06002C37 RID: 11319 RVA: 0x0001D85D File Offset: 0x0001BA5D
			internal ValueBaseProxy <Awake>b__5_17(ValueBase r)
			{
				return null;
			}

			// Token: 0x06002C38 RID: 11320 RVA: 0x0001D860 File Offset: 0x0001BA60
			internal BoolValueProxy <Awake>b__5_18(BoolValue r)
			{
				return null;
			}

			// Token: 0x06002C39 RID: 11321 RVA: 0x0001D863 File Offset: 0x0001BA63
			internal ColorValueProxy <Awake>b__5_19(ColorValue r)
			{
				return null;
			}

			// Token: 0x06002C3A RID: 11322 RVA: 0x0001D866 File Offset: 0x0001BA66
			internal StringValueProxy <Awake>b__5_20(StringValue r)
			{
				return null;
			}

			// Token: 0x06002C3B RID: 11323 RVA: 0x0001D869 File Offset: 0x0001BA69
			internal InstanceValueProxy <Awake>b__5_21(InstanceValue r)
			{
				return null;
			}

			// Token: 0x06002C3C RID: 11324 RVA: 0x0001D86C File Offset: 0x0001BA6C
			internal IntValueProxy <Awake>b__5_22(IntValue r)
			{
				return null;
			}

			// Token: 0x06002C3D RID: 11325 RVA: 0x0001D86F File Offset: 0x0001BA6F
			internal NumberValueProxy <Awake>b__5_23(NumberValue r)
			{
				return null;
			}

			// Token: 0x06002C3E RID: 11326 RVA: 0x0001D872 File Offset: 0x0001BA72
			internal Vector3ValueProxy <Awake>b__5_24(Vector3Value r)
			{
				return null;
			}

			// Token: 0x06002C3F RID: 11327 RVA: 0x0001D875 File Offset: 0x0001BA75
			internal MeshPartProxy <Awake>b__5_25(MeshPart r)
			{
				return null;
			}

			// Token: 0x06002C40 RID: 11328 RVA: 0x0001D878 File Offset: 0x0001BA78
			internal BodyPositionProxy <Awake>b__5_26(BodyPosition r)
			{
				return null;
			}

			// Token: 0x06002C41 RID: 11329 RVA: 0x0001D87B File Offset: 0x0001BA7B
			internal BackpackProxy <Awake>b__5_27(Backpack r)
			{
				return null;
			}

			// Token: 0x06002C42 RID: 11330 RVA: 0x0001D87E File Offset: 0x0001BA7E
			internal LightingProxy <Awake>b__5_28(Lighting r)
			{
				return null;
			}

			// Token: 0x06002C43 RID: 11331 RVA: 0x0001D881 File Offset: 0x0001BA81
			internal SunLightProxy <Awake>b__5_29(SunLight r)
			{
				return null;
			}

			// Token: 0x06002C44 RID: 11332 RVA: 0x0001D884 File Offset: 0x0001BA84
			internal ClimbableProxy <Awake>b__5_30(Climbable r)
			{
				return null;
			}

			// Token: 0x06002C45 RID: 11333 RVA: 0x0001D887 File Offset: 0x0001BA87
			internal DecalProxy <Awake>b__5_31(Decal r)
			{
				return null;
			}

			// Token: 0x06002C46 RID: 11334 RVA: 0x0001D88A File Offset: 0x0001BA8A
			internal ParticlesProxy <Awake>b__5_32(Particles r)
			{
				return null;
			}

			// Token: 0x06002C47 RID: 11335 RVA: 0x0001D88D File Offset: 0x0001BA8D
			internal HiddenProxy <Awake>b__5_33(Hidden r)
			{
				return null;
			}

			// Token: 0x06002C48 RID: 11336 RVA: 0x0001D890 File Offset: 0x0001BA90
			internal ServerHiddenProxy <Awake>b__5_34(ServerHidden r)
			{
				return null;
			}

			// Token: 0x06002C49 RID: 11337 RVA: 0x0001D893 File Offset: 0x0001BA93
			internal ModelProxy <Awake>b__5_35(Model r)
			{
				return null;
			}

			// Token: 0x06002C4A RID: 11338 RVA: 0x0001D896 File Offset: 0x0001BA96
			internal PointLightProxy <Awake>b__5_36(PointLight r)
			{
				return null;
			}

			// Token: 0x06002C4B RID: 11339 RVA: 0x0001D899 File Offset: 0x0001BA99
			internal TrussProxy <Awake>b__5_37(Truss r)
			{
				return null;
			}

			// Token: 0x06002C4C RID: 11340 RVA: 0x0001D89C File Offset: 0x0001BA9C
			internal SeatProxy <Awake>b__5_38(Seat r)
			{
				return null;
			}

			// Token: 0x06002C4D RID: 11341 RVA: 0x0001D89F File Offset: 0x0001BA9F
			internal SkyBaseProxy <Awake>b__5_39(SkyBase r)
			{
				return null;
			}

			// Token: 0x06002C4E RID: 11342 RVA: 0x0001D8A2 File Offset: 0x0001BAA2
			internal ImageSkyProxy <Awake>b__5_40(ImageSky r)
			{
				return null;
			}

			// Token: 0x06002C4F RID: 11343 RVA: 0x0001D8A5 File Offset: 0x0001BAA5
			internal GradientSkyProxy <Awake>b__5_41(GradientSky r)
			{
				return null;
			}

			// Token: 0x06002C50 RID: 11344 RVA: 0x0001D8A8 File Offset: 0x0001BAA8
			internal ProceduralSkyProxy <Awake>b__5_42(ProceduralSky r)
			{
				return null;
			}

			// Token: 0x06002C51 RID: 11345 RVA: 0x0001D8AB File Offset: 0x0001BAAB
			internal NetworkEventProxy <Awake>b__5_43(NetworkEvent r)
			{
				return null;
			}

			// Token: 0x06002C52 RID: 11346 RVA: 0x0001D8AE File Offset: 0x0001BAAE
			internal SignalProxy <Awake>b__5_44(Signal r)
			{
				return null;
			}

			// Token: 0x06002C53 RID: 11347 RVA: 0x0001D8B1 File Offset: 0x0001BAB1
			internal PlayerDefaultsProxy <Awake>b__5_45(PlayerDefaults r)
			{
				return null;
			}

			// Token: 0x06002C54 RID: 11348 RVA: 0x0001D8B4 File Offset: 0x0001BAB4
			internal GUIProxy <Awake>b__5_46(GUI r)
			{
				return null;
			}

			// Token: 0x06002C55 RID: 11349 RVA: 0x0001D8B7 File Offset: 0x0001BAB7
			internal UIButtonProxy <Awake>b__5_47(UIButton r)
			{
				return null;
			}

			// Token: 0x06002C56 RID: 11350 RVA: 0x0001D8BA File Offset: 0x0001BABA
			internal UIFieldProxy <Awake>b__5_48(UIField r)
			{
				return null;
			}

			// Token: 0x06002C57 RID: 11351 RVA: 0x0001D8BD File Offset: 0x0001BABD
			internal UILabelProxy <Awake>b__5_49(UILabel r)
			{
				return null;
			}

			// Token: 0x06002C58 RID: 11352 RVA: 0x0001D8C0 File Offset: 0x0001BAC0
			internal UITextInputProxy <Awake>b__5_50(UITextInput r)
			{
				return null;
			}

			// Token: 0x06002C59 RID: 11353 RVA: 0x0001D8C3 File Offset: 0x0001BAC3
			internal UIViewProxy <Awake>b__5_51(UIView r)
			{
				return null;
			}

			// Token: 0x06002C5A RID: 11354 RVA: 0x0001D8C6 File Offset: 0x0001BAC6
			internal UIImageProxy <Awake>b__5_52(UIImage r)
			{
				return null;
			}

			// Token: 0x06002C5B RID: 11355 RVA: 0x0001D8C9 File Offset: 0x0001BAC9
			internal UIHVLayoutProxy <Awake>b__5_53(UIHVLayout r)
			{
				return null;
			}

			// Token: 0x06002C5C RID: 11356 RVA: 0x0001D8CC File Offset: 0x0001BACC
			internal UIVerticalLayoutProxy <Awake>b__5_54(UIVerticalLayout r)
			{
				return null;
			}

			// Token: 0x06002C5D RID: 11357 RVA: 0x0001D8CF File Offset: 0x0001BACF
			internal UIHorizontalLayoutProxy <Awake>b__5_55(UIHorizontalLayout r)
			{
				return null;
			}

			// Token: 0x06002C5E RID: 11358 RVA: 0x0001D8D2 File Offset: 0x0001BAD2
			internal PlayerGUIProxy <Awake>b__5_56(PlayerGUI r)
			{
				return null;
			}

			// Token: 0x06002C5F RID: 11359 RVA: 0x0001D8D5 File Offset: 0x0001BAD5
			internal CameraProxy <Awake>b__5_57(Camera r)
			{
				return null;
			}

			// Token: 0x06002C60 RID: 11360 RVA: 0x0001D8D8 File Offset: 0x0001BAD8
			internal DatastoreProxy <Awake>b__5_58(Datastore r)
			{
				return null;
			}

			// Token: 0x06002C61 RID: 11361 RVA: 0x0001D8DB File Offset: 0x0001BADB
			internal AchievementServiceProxy <Awake>b__5_59(AchievementService r)
			{
				return null;
			}

			// Token: 0x06002C62 RID: 11362 RVA: 0x0001D8DE File Offset: 0x0001BADE
			internal PurchasesServiceProxy <Awake>b__5_60(PurchasesService r)
			{
				return null;
			}

			// Token: 0x06002C63 RID: 11363 RVA: 0x0001D8E1 File Offset: 0x0001BAE1
			internal ChatServiceProxy <Awake>b__5_61(ChatService r)
			{
				return null;
			}

			// Token: 0x06002C64 RID: 11364 RVA: 0x0001D8E4 File Offset: 0x0001BAE4
			internal CoreUIServiceProxy <Awake>b__5_62(CoreUIService r)
			{
				return null;
			}

			// Token: 0x06002C65 RID: 11365 RVA: 0x0001D8E7 File Offset: 0x0001BAE7
			internal DatastoreProxy <Awake>b__5_63(Datastore r)
			{
				return null;
			}

			// Token: 0x06002C66 RID: 11366 RVA: 0x0001D8EA File Offset: 0x0001BAEA
			internal DataStoreServiceProxy <Awake>b__5_64(DataStoreService r)
			{
				return null;
			}

			// Token: 0x06002C67 RID: 11367 RVA: 0x0001D8ED File Offset: 0x0001BAED
			internal FilterServiceProxy <Awake>b__5_65(FilterService r)
			{
				return null;
			}

			// Token: 0x06002C68 RID: 11368 RVA: 0x0001D8F0 File Offset: 0x0001BAF0
			internal HttpServiceProxy <Awake>b__5_66(HttpService r)
			{
				return null;
			}

			// Token: 0x06002C69 RID: 11369 RVA: 0x0001D8F3 File Offset: 0x0001BAF3
			internal InputServiceProxy <Awake>b__5_67(InputService r)
			{
				return null;
			}

			// Token: 0x06002C6A RID: 11370 RVA: 0x0001D8F6 File Offset: 0x0001BAF6
			internal InsertServiceProxy <Awake>b__5_68(InsertService r)
			{
				return null;
			}

			// Token: 0x06002C6B RID: 11371 RVA: 0x0001D8F9 File Offset: 0x0001BAF9
			internal TweenServiceProxy <Awake>b__5_69(TweenService r)
			{
				return null;
			}

			// Token: 0x06002C6C RID: 11372 RVA: 0x0001D8FC File Offset: 0x0001BAFC
			internal void <RunScripts>b__14_0(BaseScript s)
			{
			}

			// Token: 0x06002C6D RID: 11373 RVA: 0x0001D8FE File Offset: 0x0001BAFE
			internal void <RunLocalScripts>b__15_0(BaseScript s)
			{
			}

			// Token: 0x0400110A RID: 4362
			public static readonly ScriptService.<>c <>9;

			// Token: 0x0400110B RID: 4363
			public static Func<Instance, InstanceProxy> <>9__5_0;

			// Token: 0x0400110C RID: 4364
			public static Func<DynamicInstance, DynamicInstanceProxy> <>9__5_1;

			// Token: 0x0400110D RID: 4365
			public static Func<Part, PartProxy> <>9__5_2;

			// Token: 0x0400110E RID: 4366
			public static Func<Game, GameProxy> <>9__5_3;

			// Token: 0x0400110F RID: 4367
			public static Func<BaseScript, BaseScriptProxy> <>9__5_4;

			// Token: 0x04001110 RID: 4368
			public static Func<ScriptInstance, ScriptInstanceProxy> <>9__5_5;

			// Token: 0x04001111 RID: 4369
			public static Func<LocalScript, LocalScriptProxy> <>9__5_6;

			// Token: 0x04001112 RID: 4370
			public static Func<ModuleScript, ModuleScriptProxy> <>9__5_7;

			// Token: 0x04001113 RID: 4371
			public static Func<RemoteEvent, RemoveEventProxy> <>9__5_8;

			// Token: 0x04001114 RID: 4372
			public static Func<Environment, EnvironmentProxy> <>9__5_9;

			// Token: 0x04001115 RID: 4373
			public static Func<Player, PlayerProxy> <>9__5_10;

			// Token: 0x04001116 RID: 4374
			public static Func<Players, PlayersProxy> <>9__5_11;

			// Token: 0x04001117 RID: 4375
			public static Func<Text3D, Text3DProxy> <>9__5_12;

			// Token: 0x04001118 RID: 4376
			public static Func<Sound, SoundProxy> <>9__5_13;

			// Token: 0x04001119 RID: 4377
			public static Func<Tool, ToolProxy> <>9__5_14;

			// Token: 0x0400111A RID: 4378
			public static Func<NPC, NPCProxy> <>9__5_15;

			// Token: 0x0400111B RID: 4379
			public static Func<Spotlight, SpotlightProxy> <>9__5_16;

			// Token: 0x0400111C RID: 4380
			public static Func<ValueBase, ValueBaseProxy> <>9__5_17;

			// Token: 0x0400111D RID: 4381
			public static Func<BoolValue, BoolValueProxy> <>9__5_18;

			// Token: 0x0400111E RID: 4382
			public static Func<ColorValue, ColorValueProxy> <>9__5_19;

			// Token: 0x0400111F RID: 4383
			public static Func<StringValue, StringValueProxy> <>9__5_20;

			// Token: 0x04001120 RID: 4384
			public static Func<InstanceValue, InstanceValueProxy> <>9__5_21;

			// Token: 0x04001121 RID: 4385
			public static Func<IntValue, IntValueProxy> <>9__5_22;

			// Token: 0x04001122 RID: 4386
			public static Func<NumberValue, NumberValueProxy> <>9__5_23;

			// Token: 0x04001123 RID: 4387
			public static Func<Vector3Value, Vector3ValueProxy> <>9__5_24;

			// Token: 0x04001124 RID: 4388
			public static Func<MeshPart, MeshPartProxy> <>9__5_25;

			// Token: 0x04001125 RID: 4389
			public static Func<BodyPosition, BodyPositionProxy> <>9__5_26;

			// Token: 0x04001126 RID: 4390
			public static Func<Backpack, BackpackProxy> <>9__5_27;

			// Token: 0x04001127 RID: 4391
			public static Func<Lighting, LightingProxy> <>9__5_28;

			// Token: 0x04001128 RID: 4392
			public static Func<SunLight, SunLightProxy> <>9__5_29;

			// Token: 0x04001129 RID: 4393
			public static Func<Climbable, ClimbableProxy> <>9__5_30;

			// Token: 0x0400112A RID: 4394
			public static Func<Decal, DecalProxy> <>9__5_31;

			// Token: 0x0400112B RID: 4395
			public static Func<Particles, ParticlesProxy> <>9__5_32;

			// Token: 0x0400112C RID: 4396
			public static Func<Hidden, HiddenProxy> <>9__5_33;

			// Token: 0x0400112D RID: 4397
			public static Func<ServerHidden, ServerHiddenProxy> <>9__5_34;

			// Token: 0x0400112E RID: 4398
			public static Func<Model, ModelProxy> <>9__5_35;

			// Token: 0x0400112F RID: 4399
			public static Func<PointLight, PointLightProxy> <>9__5_36;

			// Token: 0x04001130 RID: 4400
			public static Func<Truss, TrussProxy> <>9__5_37;

			// Token: 0x04001131 RID: 4401
			public static Func<Seat, SeatProxy> <>9__5_38;

			// Token: 0x04001132 RID: 4402
			public static Func<SkyBase, SkyBaseProxy> <>9__5_39;

			// Token: 0x04001133 RID: 4403
			public static Func<ImageSky, ImageSkyProxy> <>9__5_40;

			// Token: 0x04001134 RID: 4404
			public static Func<GradientSky, GradientSkyProxy> <>9__5_41;

			// Token: 0x04001135 RID: 4405
			public static Func<ProceduralSky, ProceduralSkyProxy> <>9__5_42;

			// Token: 0x04001136 RID: 4406
			public static Func<NetworkEvent, NetworkEventProxy> <>9__5_43;

			// Token: 0x04001137 RID: 4407
			public static Func<Signal, SignalProxy> <>9__5_44;

			// Token: 0x04001138 RID: 4408
			public static Func<PlayerDefaults, PlayerDefaultsProxy> <>9__5_45;

			// Token: 0x04001139 RID: 4409
			public static Func<GUI, GUIProxy> <>9__5_46;

			// Token: 0x0400113A RID: 4410
			public static Func<UIButton, UIButtonProxy> <>9__5_47;

			// Token: 0x0400113B RID: 4411
			public static Func<UIField, UIFieldProxy> <>9__5_48;

			// Token: 0x0400113C RID: 4412
			public static Func<UILabel, UILabelProxy> <>9__5_49;

			// Token: 0x0400113D RID: 4413
			public static Func<UITextInput, UITextInputProxy> <>9__5_50;

			// Token: 0x0400113E RID: 4414
			public static Func<UIView, UIViewProxy> <>9__5_51;

			// Token: 0x0400113F RID: 4415
			public static Func<UIImage, UIImageProxy> <>9__5_52;

			// Token: 0x04001140 RID: 4416
			public static Func<UIHVLayout, UIHVLayoutProxy> <>9__5_53;

			// Token: 0x04001141 RID: 4417
			public static Func<UIVerticalLayout, UIVerticalLayoutProxy> <>9__5_54;

			// Token: 0x04001142 RID: 4418
			public static Func<UIHorizontalLayout, UIHorizontalLayoutProxy> <>9__5_55;

			// Token: 0x04001143 RID: 4419
			public static Func<PlayerGUI, PlayerGUIProxy> <>9__5_56;

			// Token: 0x04001144 RID: 4420
			public static Func<Camera, CameraProxy> <>9__5_57;

			// Token: 0x04001145 RID: 4421
			public static Func<Datastore, DatastoreProxy> <>9__5_58;

			// Token: 0x04001146 RID: 4422
			public static Func<AchievementService, AchievementServiceProxy> <>9__5_59;

			// Token: 0x04001147 RID: 4423
			public static Func<PurchasesService, PurchasesServiceProxy> <>9__5_60;

			// Token: 0x04001148 RID: 4424
			public static Func<ChatService, ChatServiceProxy> <>9__5_61;

			// Token: 0x04001149 RID: 4425
			public static Func<CoreUIService, CoreUIServiceProxy> <>9__5_62;

			// Token: 0x0400114A RID: 4426
			public static Func<Datastore, DatastoreProxy> <>9__5_63;

			// Token: 0x0400114B RID: 4427
			public static Func<DataStoreService, DataStoreServiceProxy> <>9__5_64;

			// Token: 0x0400114C RID: 4428
			public static Func<FilterService, FilterServiceProxy> <>9__5_65;

			// Token: 0x0400114D RID: 4429
			public static Func<HttpService, HttpServiceProxy> <>9__5_66;

			// Token: 0x0400114E RID: 4430
			public static Func<InputService, InputServiceProxy> <>9__5_67;

			// Token: 0x0400114F RID: 4431
			public static Func<InsertService, InsertServiceProxy> <>9__5_68;

			// Token: 0x04001150 RID: 4432
			public static Func<TweenService, TweenServiceProxy> <>9__5_69;

			// Token: 0x04001151 RID: 4433
			public static Action<BaseScript> <>9__14_0;

			// Token: 0x04001152 RID: 4434
			public static Action<BaseScript> <>9__15_0;
		}

		// Token: 0x02000409 RID: 1033
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x06002C6F RID: 11375 RVA: 0x0001D908 File Offset: 0x0001BB08
			internal void <RunScriptInstance>b__0(string s)
			{
			}

			// Token: 0x06002C70 RID: 11376 RVA: 0x0001D90A File Offset: 0x0001BB0A
			internal DynValue <RunScriptInstance>b__1(ModuleScript ms)
			{
				return null;
			}

			// Token: 0x04001153 RID: 4435
			public ScriptService <>4__this;

			// Token: 0x04001154 RID: 4436
			public Script script;
		}

		// Token: 0x0200040A RID: 1034
		private sealed class <InvokeEvent>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002C71 RID: 11377 RVA: 0x0001D90D File Offset: 0x0001BB0D
			public <InvokeEvent>d__33(int <>1__state)
			{
			}

			// Token: 0x06002C72 RID: 11378 RVA: 0x0001D915 File Offset: 0x0001BB15
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002C73 RID: 11379 RVA: 0x0001D917 File Offset: 0x0001BB17
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CF0 RID: 3312
			// (get) Token: 0x06002C74 RID: 11380 RVA: 0x0001D91A File Offset: 0x0001BB1A
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002C75 RID: 11381 RVA: 0x0001D91D File Offset: 0x0001BB1D
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CF1 RID: 3313
			// (get) Token: 0x06002C76 RID: 11382 RVA: 0x0001D91F File Offset: 0x0001BB1F
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001155 RID: 4437
			private int <>1__state;

			// Token: 0x04001156 RID: 4438
			private object <>2__current;

			// Token: 0x04001157 RID: 4439
			public DynValue func;

			// Token: 0x04001158 RID: 4440
			public ScriptService <>4__this;

			// Token: 0x04001159 RID: 4441
			public object[] par;

			// Token: 0x0400115A RID: 4442
			private DynValue <coroutine>5__2;
		}

		// Token: 0x0200040B RID: 1035
		private sealed class <RunScriptInstance>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002C77 RID: 11383 RVA: 0x0001D922 File Offset: 0x0001BB22
			public <RunScriptInstance>d__25(int <>1__state)
			{
			}

			// Token: 0x06002C78 RID: 11384 RVA: 0x0001D92A File Offset: 0x0001BB2A
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002C79 RID: 11385 RVA: 0x0001D92C File Offset: 0x0001BB2C
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CF2 RID: 3314
			// (get) Token: 0x06002C7A RID: 11386 RVA: 0x0001D92F File Offset: 0x0001BB2F
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002C7B RID: 11387 RVA: 0x0001D932 File Offset: 0x0001BB32
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CF3 RID: 3315
			// (get) Token: 0x06002C7C RID: 11388 RVA: 0x0001D934 File Offset: 0x0001BB34
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x0400115B RID: 4443
			private int <>1__state;

			// Token: 0x0400115C RID: 4444
			private object <>2__current;

			// Token: 0x0400115D RID: 4445
			public ScriptService <>4__this;

			// Token: 0x0400115E RID: 4446
			public BaseScript scriptInstance;

			// Token: 0x0400115F RID: 4447
			private ScriptService.<>c__DisplayClass25_0 <>8__1;

			// Token: 0x04001160 RID: 4448
			private DynValue <coroutine>5__2;

			// Token: 0x04001161 RID: 4449
			private float <timeout>5__3;
		}
	}
}
