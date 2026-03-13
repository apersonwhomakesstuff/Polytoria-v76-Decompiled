using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using GLTFast;
using Mirror;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	// Token: 0x02000323 RID: 803
	public class AppearanceLoaderBase : NetworkBehaviour
	{
		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x000260E0 File Offset: 0x000242E0
		// (set) Token: 0x060027D7 RID: 10199 RVA: 0x0001CA7A File Offset: 0x0001AC7A
		public Color HeadColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x000260F8 File Offset: 0x000242F8
		// (set) Token: 0x060027D9 RID: 10201 RVA: 0x0001CA7C File Offset: 0x0001AC7C
		public Color TorsoColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x00026110 File Offset: 0x00024310
		// (set) Token: 0x060027DB RID: 10203 RVA: 0x0001CA7E File Offset: 0x0001AC7E
		public Color LeftArmColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x00026128 File Offset: 0x00024328
		// (set) Token: 0x060027DD RID: 10205 RVA: 0x0001CA80 File Offset: 0x0001AC80
		public Color RightArmColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x00026140 File Offset: 0x00024340
		// (set) Token: 0x060027DF RID: 10207 RVA: 0x0001CA82 File Offset: 0x0001AC82
		public Color LeftLegColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x00026158 File Offset: 0x00024358
		// (set) Token: 0x060027E1 RID: 10209 RVA: 0x0001CA84 File Offset: 0x0001AC84
		public Color RightLegColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x0001CA86 File Offset: 0x0001AC86
		// (set) Token: 0x060027E3 RID: 10211 RVA: 0x0001CA89 File Offset: 0x0001AC89
		public int FaceID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x0001CA8B File Offset: 0x0001AC8B
		// (set) Token: 0x060027E5 RID: 10213 RVA: 0x0001CA8E File Offset: 0x0001AC8E
		public int ShirtID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x0001CA90 File Offset: 0x0001AC90
		// (set) Token: 0x060027E7 RID: 10215 RVA: 0x0001CA93 File Offset: 0x0001AC93
		public int PantsID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x0001CA95 File Offset: 0x0001AC95
		// (set) Token: 0x060027E9 RID: 10217 RVA: 0x0001CA98 File Offset: 0x0001AC98
		public int TorsoID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x0001CA9A File Offset: 0x0001AC9A
		public override void OnStartClient()
		{
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x0001CA9C File Offset: 0x0001AC9C
		private void HatsChanged(SyncList<string>.Operation op, int itemIndex, string oldItem, string newItem)
		{
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x0001CA9E File Offset: 0x0001AC9E
		private void ColorChanged(Color oldColor, Color newColor)
		{
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
		private void ClothingChanged(int oldClothing, int newClothing)
		{
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x0001CAA2 File Offset: 0x0001ACA2
		private void BodyChanged(string oldBody, string newBody)
		{
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x0001CAA4 File Offset: 0x0001ACA4
		protected virtual void UpdateColors()
		{
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x0001CAA6 File Offset: 0x0001ACA6
		protected virtual void UpdateClothing()
		{
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x0001CAA8 File Offset: 0x0001ACA8
		protected virtual void Awake()
		{
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x0001CAAA File Offset: 0x0001ACAA
		public void LoadAppearance(int userID)
		{
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x0001CAAC File Offset: 0x0001ACAC
		public virtual void ClearAppearance()
		{
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x0001CAAE File Offset: 0x0001ACAE
		private IEnumerator ProcessAppearance(int userID)
		{
			return null;
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x0001CAB1 File Offset: 0x0001ACB1
		private void ApplyAppearance(AppearanceData data)
		{
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x0001CAB3 File Offset: 0x0001ACB3
		private void UpdateHats()
		{
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x0001CAB5 File Offset: 0x0001ACB5
		private IEnumerator ApplyHats()
		{
			return null;
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x0001CAB8 File Offset: 0x0001ACB8
		private void UpdateBodyParts()
		{
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x0001CABA File Offset: 0x0001ACBA
		private IEnumerator ApplyBodyParts()
		{
			return null;
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x0001CABD File Offset: 0x0001ACBD
		protected virtual void HatLoaded(GameObject hat)
		{
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x0001CAC9 File Offset: 0x0001ACC9
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x00026170 File Offset: 0x00024370
		// (set) Token: 0x060027FF RID: 10239 RVA: 0x0001CACC File Offset: 0x0001ACCC
		public Color NetworkheadColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x00026188 File Offset: 0x00024388
		// (set) Token: 0x06002801 RID: 10241 RVA: 0x0001CACE File Offset: 0x0001ACCE
		public Color NetworktorsoColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x000261A0 File Offset: 0x000243A0
		// (set) Token: 0x06002803 RID: 10243 RVA: 0x0001CAD0 File Offset: 0x0001ACD0
		public Color NetworkleftArmColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002804 RID: 10244 RVA: 0x000261B8 File Offset: 0x000243B8
		// (set) Token: 0x06002805 RID: 10245 RVA: 0x0001CAD2 File Offset: 0x0001ACD2
		public Color NetworkrightArmColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002806 RID: 10246 RVA: 0x000261D0 File Offset: 0x000243D0
		// (set) Token: 0x06002807 RID: 10247 RVA: 0x0001CAD4 File Offset: 0x0001ACD4
		public Color NetworkleftLegColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06002808 RID: 10248 RVA: 0x000261E8 File Offset: 0x000243E8
		// (set) Token: 0x06002809 RID: 10249 RVA: 0x0001CAD6 File Offset: 0x0001ACD6
		public Color NetworkrightLegColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x0600280A RID: 10250 RVA: 0x0001CAD8 File Offset: 0x0001ACD8
		// (set) Token: 0x0600280B RID: 10251 RVA: 0x0001CADB File Offset: 0x0001ACDB
		public int NetworkfaceID
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x0600280C RID: 10252 RVA: 0x0001CADD File Offset: 0x0001ACDD
		// (set) Token: 0x0600280D RID: 10253 RVA: 0x0001CAE0 File Offset: 0x0001ACE0
		public int NetworkshirtID
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x0600280E RID: 10254 RVA: 0x0001CAE2 File Offset: 0x0001ACE2
		// (set) Token: 0x0600280F RID: 10255 RVA: 0x0001CAE5 File Offset: 0x0001ACE5
		public int NetworkpantsID
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06002810 RID: 10256 RVA: 0x0001CAE7 File Offset: 0x0001ACE7
		// (set) Token: 0x06002811 RID: 10257 RVA: 0x0001CAEA File Offset: 0x0001ACEA
		public int NetworktorsoID
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002812 RID: 10258 RVA: 0x0001CAEC File Offset: 0x0001ACEC
		// (set) Token: 0x06002813 RID: 10259 RVA: 0x0001CAEF File Offset: 0x0001ACEF
		public string NetworktorsoUrl
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x0001CAF1 File Offset: 0x0001ACF1
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x0001CAF3 File Offset: 0x0001ACF3
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000D62 RID: 3426
		private static Dictionary<int, AppearanceData> playerAppearanceCache;

		// Token: 0x04000D63 RID: 3427
		protected Transform headObj;

		// Token: 0x04000D64 RID: 3428
		protected Transform torsoObj;

		// Token: 0x04000D65 RID: 3429
		protected Mesh defaultTorsoMesh;

		// Token: 0x04000D66 RID: 3430
		private int currentlyLoadingUserID;

		// Token: 0x04000D67 RID: 3431
		protected Color headColor;

		// Token: 0x04000D68 RID: 3432
		protected Color torsoColor;

		// Token: 0x04000D69 RID: 3433
		protected Color leftArmColor;

		// Token: 0x04000D6A RID: 3434
		protected Color rightArmColor;

		// Token: 0x04000D6B RID: 3435
		protected Color leftLegColor;

		// Token: 0x04000D6C RID: 3436
		protected Color rightLegColor;

		// Token: 0x04000D6D RID: 3437
		protected int faceID;

		// Token: 0x04000D6E RID: 3438
		protected int shirtID;

		// Token: 0x04000D6F RID: 3439
		protected int pantsID;

		// Token: 0x04000D70 RID: 3440
		protected int torsoID;

		// Token: 0x04000D71 RID: 3441
		protected readonly SyncList<string> hatUrls;

		// Token: 0x04000D72 RID: 3442
		private string torsoUrl;

		// Token: 0x04000D73 RID: 3443
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_headColor;

		// Token: 0x04000D74 RID: 3444
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_torsoColor;

		// Token: 0x04000D75 RID: 3445
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_leftArmColor;

		// Token: 0x04000D76 RID: 3446
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_rightArmColor;

		// Token: 0x04000D77 RID: 3447
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_leftLegColor;

		// Token: 0x04000D78 RID: 3448
		public Action<Color, Color> _Mirror_SyncVarHookDelegate_rightLegColor;

		// Token: 0x04000D79 RID: 3449
		public Action<int, int> _Mirror_SyncVarHookDelegate_faceID;

		// Token: 0x04000D7A RID: 3450
		public Action<int, int> _Mirror_SyncVarHookDelegate_shirtID;

		// Token: 0x04000D7B RID: 3451
		public Action<int, int> _Mirror_SyncVarHookDelegate_pantsID;

		// Token: 0x04000D7C RID: 3452
		public Action<string, string> _Mirror_SyncVarHookDelegate_torsoUrl;

		// Token: 0x02000417 RID: 1047
		private sealed class <ApplyBodyParts>d__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002CA3 RID: 11427 RVA: 0x0001D9CB File Offset: 0x0001BBCB
			public <ApplyBodyParts>d__62(int <>1__state)
			{
			}

			// Token: 0x06002CA4 RID: 11428 RVA: 0x0001D9D3 File Offset: 0x0001BBD3
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002CA5 RID: 11429 RVA: 0x0001D9D5 File Offset: 0x0001BBD5
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CF8 RID: 3320
			// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x0001D9D8 File Offset: 0x0001BBD8
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002CA7 RID: 11431 RVA: 0x0001D9DB File Offset: 0x0001BBDB
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CF9 RID: 3321
			// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x0001D9DD File Offset: 0x0001BBDD
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001191 RID: 4497
			private int <>1__state;

			// Token: 0x04001192 RID: 4498
			private object <>2__current;

			// Token: 0x04001193 RID: 4499
			public AppearanceLoaderBase <>4__this;

			// Token: 0x04001194 RID: 4500
			private GameObject <go>5__2;

			// Token: 0x04001195 RID: 4501
			private GltfImport <gltf>5__3;

			// Token: 0x04001196 RID: 4502
			private Task<bool> <t>5__4;

			// Token: 0x04001197 RID: 4503
			private Task<bool> <task>5__5;
		}

		// Token: 0x02000418 RID: 1048
		private sealed class <ApplyHats>d__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002CA9 RID: 11433 RVA: 0x0001D9E0 File Offset: 0x0001BBE0
			public <ApplyHats>d__60(int <>1__state)
			{
			}

			// Token: 0x06002CAA RID: 11434 RVA: 0x0001D9E8 File Offset: 0x0001BBE8
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002CAB RID: 11435 RVA: 0x0001D9EA File Offset: 0x0001BBEA
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002CAC RID: 11436 RVA: 0x0001D9ED File Offset: 0x0001BBED
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000CFA RID: 3322
			// (get) Token: 0x06002CAD RID: 11437 RVA: 0x0001D9EF File Offset: 0x0001BBEF
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002CAE RID: 11438 RVA: 0x0001D9F2 File Offset: 0x0001BBF2
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CFB RID: 3323
			// (get) Token: 0x06002CAF RID: 11439 RVA: 0x0001D9F4 File Offset: 0x0001BBF4
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001198 RID: 4504
			private int <>1__state;

			// Token: 0x04001199 RID: 4505
			private object <>2__current;

			// Token: 0x0400119A RID: 4506
			public AppearanceLoaderBase <>4__this;

			// Token: 0x0400119B RID: 4507
			private SyncList<string>.Enumerator <>7__wrap1;

			// Token: 0x0400119C RID: 4508
			private string <url>5__3;

			// Token: 0x0400119D RID: 4509
			private GameObject <hat>5__4;

			// Token: 0x0400119E RID: 4510
			private GltfImport <gltf>5__5;

			// Token: 0x0400119F RID: 4511
			private Task<bool> <t>5__6;

			// Token: 0x040011A0 RID: 4512
			private Task<bool> <task>5__7;
		}

		// Token: 0x02000419 RID: 1049
		private sealed class <ProcessAppearance>d__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002CB0 RID: 11440 RVA: 0x0001D9F7 File Offset: 0x0001BBF7
			public <ProcessAppearance>d__57(int <>1__state)
			{
			}

			// Token: 0x06002CB1 RID: 11441 RVA: 0x0001D9FF File Offset: 0x0001BBFF
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002CB2 RID: 11442 RVA: 0x0001DA01 File Offset: 0x0001BC01
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002CB3 RID: 11443 RVA: 0x0001DA04 File Offset: 0x0001BC04
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000CFC RID: 3324
			// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x0001DA06 File Offset: 0x0001BC06
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002CB5 RID: 11445 RVA: 0x0001DA09 File Offset: 0x0001BC09
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CFD RID: 3325
			// (get) Token: 0x06002CB6 RID: 11446 RVA: 0x0001DA0B File Offset: 0x0001BC0B
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040011A1 RID: 4513
			private int <>1__state;

			// Token: 0x040011A2 RID: 4514
			private object <>2__current;

			// Token: 0x040011A3 RID: 4515
			public int userID;

			// Token: 0x040011A4 RID: 4516
			public AppearanceLoaderBase <>4__this;

			// Token: 0x040011A5 RID: 4517
			private UnityWebRequest <uwr>5__2;
		}
	}
}
