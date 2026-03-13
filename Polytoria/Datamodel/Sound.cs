using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Lua;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Datamodel
{
	// Token: 0x020002AC RID: 684
	public class Sound : DynamicInstance
	{
		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x0001B751 File Offset: 0x00019951
		public bool Playing
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x0001B754 File Offset: 0x00019954
		public bool Loading
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x0001B757 File Offset: 0x00019957
		// (set) Token: 0x06002112 RID: 8466 RVA: 0x0001B75A File Offset: 0x0001995A
		public int SoundID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x0001B75C File Offset: 0x0001995C
		// (set) Token: 0x06002114 RID: 8468 RVA: 0x0001B763 File Offset: 0x00019963
		public float Pitch
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x0001B765 File Offset: 0x00019965
		// (set) Token: 0x06002116 RID: 8470 RVA: 0x0001B76C File Offset: 0x0001996C
		public float MaxDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x0001B76E File Offset: 0x0001996E
		public float Length
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06002118 RID: 8472 RVA: 0x00024E80 File Offset: 0x00023080
		// (set) Token: 0x06002119 RID: 8473 RVA: 0x0001B775 File Offset: 0x00019975
		public new Vector3 Size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x00024E98 File Offset: 0x00023098
		// (set) Token: 0x0600211B RID: 8475 RVA: 0x0001B777 File Offset: 0x00019977
		public new Vector3 Rotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x0001B779 File Offset: 0x00019979
		// (set) Token: 0x0600211D RID: 8477 RVA: 0x0001B780 File Offset: 0x00019980
		public float Time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x0001B782 File Offset: 0x00019982
		private IEnumerator GetAudioClip(int id)
		{
			return null;
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x0001B785 File Offset: 0x00019985
		private void RpcSetSoundId(int id)
		{
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x0001B787 File Offset: 0x00019987
		// (set) Token: 0x06002121 RID: 8481 RVA: 0x0001B78A File Offset: 0x0001998A
		public bool Autoplay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x0001B78C File Offset: 0x0001998C
		// (set) Token: 0x06002123 RID: 8483 RVA: 0x0001B78F File Offset: 0x0001998F
		public bool Loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x0001B791 File Offset: 0x00019991
		// (set) Token: 0x06002125 RID: 8485 RVA: 0x0001B794 File Offset: 0x00019994
		public bool PlayInWorld
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x0001B796 File Offset: 0x00019996
		// (set) Token: 0x06002127 RID: 8487 RVA: 0x0001B79D File Offset: 0x0001999D
		public float Volume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x0001B79F File Offset: 0x0001999F
		public void Play()
		{
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x0001B7A1 File Offset: 0x000199A1
		public void PlayOneShot(float volume = 1f)
		{
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x0001B7A3 File Offset: 0x000199A3
		public void RpcPlayOneShot(float volume)
		{
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x0001B7A5 File Offset: 0x000199A5
		private IEnumerator playC()
		{
			return null;
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x0001B7A8 File Offset: 0x000199A8
		public void Stop()
		{
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x0001B7AA File Offset: 0x000199AA
		protected override void Awake()
		{
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x0001B7AC File Offset: 0x000199AC
		protected override void Start()
		{
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x0001B7AE File Offset: 0x000199AE
		protected override void Update()
		{
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x0001B7B0 File Offset: 0x000199B0
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x0001B7B2 File Offset: 0x000199B2
		protected override void OnHide()
		{
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x0001B7B4 File Offset: 0x000199B4
		protected override void OnShow()
		{
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x0001B7B6 File Offset: 0x000199B6
		private void RpcStop()
		{
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x0001B7B8 File Offset: 0x000199B8
		private void RpcPlay()
		{
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x0001B7BA File Offset: 0x000199BA
		private void RpcSetTime(float t)
		{
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x0001B7BC File Offset: 0x000199BC
		private void RpcSetVolume(float vol)
		{
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x0001B7BE File Offset: 0x000199BE
		private void RpcSetPitch(float p)
		{
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x0001B7C0 File Offset: 0x000199C0
		private void RpcSetMaxDistance(float d)
		{
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x0001B7C2 File Offset: 0x000199C2
		private void RpcChangeBoolProperty(int property, bool value)
		{
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x0001B7CE File Offset: 0x000199CE
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x0001B7D1 File Offset: 0x000199D1
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x0001B7D4 File Offset: 0x000199D4
		public int NetworksoundID
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

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x0001B7D6 File Offset: 0x000199D6
		// (set) Token: 0x06002140 RID: 8512 RVA: 0x0001B7D9 File Offset: 0x000199D9
		public bool Network_isPlaying
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x0001B7DB File Offset: 0x000199DB
		// (set) Token: 0x06002142 RID: 8514 RVA: 0x0001B7DE File Offset: 0x000199DE
		public bool Networkautoplay
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x0001B7E0 File Offset: 0x000199E0
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x0001B7E7 File Offset: 0x000199E7
		public float Networkvolume
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x0001B7E9 File Offset: 0x000199E9
		// (set) Token: 0x06002146 RID: 8518 RVA: 0x0001B7F0 File Offset: 0x000199F0
		public float Networktime
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x0001B7F2 File Offset: 0x000199F2
		// (set) Token: 0x06002148 RID: 8520 RVA: 0x0001B7F5 File Offset: 0x000199F5
		public bool Networkloop
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x0001B7F7 File Offset: 0x000199F7
		// (set) Token: 0x0600214A RID: 8522 RVA: 0x0001B7FA File Offset: 0x000199FA
		public bool NetworkplayInWorld
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x0001B7FC File Offset: 0x000199FC
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x0001B803 File Offset: 0x00019A03
		public float Networkpitch
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x0001B805 File Offset: 0x00019A05
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x0001B80C File Offset: 0x00019A0C
		public float NetworkmaxDistance
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x0001B80E File Offset: 0x00019A0E
		protected void UserCode_RpcSetSoundId__Int32(int id)
		{
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x0001B810 File Offset: 0x00019A10
		protected static void InvokeUserCode_RpcSetSoundId__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x0001B812 File Offset: 0x00019A12
		protected void UserCode_RpcPlayOneShot__Single(float volume)
		{
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x0001B814 File Offset: 0x00019A14
		protected static void InvokeUserCode_RpcPlayOneShot__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x0001B816 File Offset: 0x00019A16
		protected void UserCode_RpcStop()
		{
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x0001B818 File Offset: 0x00019A18
		protected static void InvokeUserCode_RpcStop(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x0001B81A File Offset: 0x00019A1A
		protected void UserCode_RpcPlay()
		{
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x0001B81C File Offset: 0x00019A1C
		protected static void InvokeUserCode_RpcPlay(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x0001B81E File Offset: 0x00019A1E
		protected void UserCode_RpcSetTime__Single(float t)
		{
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x0001B820 File Offset: 0x00019A20
		protected static void InvokeUserCode_RpcSetTime__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x0001B822 File Offset: 0x00019A22
		protected void UserCode_RpcSetVolume__Single(float vol)
		{
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x0001B824 File Offset: 0x00019A24
		protected static void InvokeUserCode_RpcSetVolume__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x0001B826 File Offset: 0x00019A26
		protected void UserCode_RpcSetPitch__Single(float p)
		{
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x0001B828 File Offset: 0x00019A28
		protected static void InvokeUserCode_RpcSetPitch__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x0001B82A File Offset: 0x00019A2A
		protected void UserCode_RpcSetMaxDistance__Single(float d)
		{
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x0001B82C File Offset: 0x00019A2C
		protected static void InvokeUserCode_RpcSetMaxDistance__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x0001B82E File Offset: 0x00019A2E
		protected void UserCode_RpcChangeBoolProperty__Int32__Boolean(int property, bool value)
		{
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x0001B830 File Offset: 0x00019A30
		protected static void InvokeUserCode_RpcChangeBoolProperty__Int32__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x0001B832 File Offset: 0x00019A32
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x0001B834 File Offset: 0x00019A34
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000BF2 RID: 3058
		private static Dictionary<int, Sound.AudioCacheEntry> audioCache;

		// Token: 0x04000BF3 RID: 3059
		private AudioSource audioSource;

		// Token: 0x04000BF4 RID: 3060
		private AudioClip clip;

		// Token: 0x04000BF5 RID: 3061
		private int soundID;

		// Token: 0x04000BF6 RID: 3062
		private bool _isPlaying;

		// Token: 0x04000BF7 RID: 3063
		private bool autoplay;

		// Token: 0x04000BF8 RID: 3064
		private float volume;

		// Token: 0x04000BF9 RID: 3065
		private float time;

		// Token: 0x04000BFA RID: 3066
		private bool loop;

		// Token: 0x04000BFB RID: 3067
		private bool playInWorld;

		// Token: 0x04000BFC RID: 3068
		private float pitch;

		// Token: 0x04000BFD RID: 3069
		private float maxDistance;

		// Token: 0x04000BFE RID: 3070
		public LuaEvent Loaded;

		// Token: 0x04000BFF RID: 3071
		private bool loading;

		// Token: 0x020003F7 RID: 1015
		private struct AudioCacheEntry
		{
			// Token: 0x040010C2 RID: 4290
			public AudioClip clip;

			// Token: 0x040010C3 RID: 4291
			public bool loading;
		}

		// Token: 0x020003F8 RID: 1016
		private sealed class <>c__DisplayClass39_0
		{
			// Token: 0x06002BDA RID: 11226 RVA: 0x0001D71A File Offset: 0x0001B91A
			internal bool <GetAudioClip>b__0()
			{
				return false;
			}

			// Token: 0x040010C4 RID: 4292
			public int id;
		}

		// Token: 0x020003F9 RID: 1017
		private sealed class <GetAudioClip>d__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002BDB RID: 11227 RVA: 0x0001D71D File Offset: 0x0001B91D
			public <GetAudioClip>d__39(int <>1__state)
			{
			}

			// Token: 0x06002BDC RID: 11228 RVA: 0x0001D725 File Offset: 0x0001B925
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002BDD RID: 11229 RVA: 0x0001D727 File Offset: 0x0001B927
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002BDE RID: 11230 RVA: 0x0001D72A File Offset: 0x0001B92A
			private void <>m__Finally1()
			{
			}

			// Token: 0x06002BDF RID: 11231 RVA: 0x0001D72C File Offset: 0x0001B92C
			private void <>m__Finally2()
			{
			}

			// Token: 0x17000CDE RID: 3294
			// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x0001D72E File Offset: 0x0001B92E
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002BE1 RID: 11233 RVA: 0x0001D731 File Offset: 0x0001B931
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CDF RID: 3295
			// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x0001D733 File Offset: 0x0001B933
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010C5 RID: 4293
			private int <>1__state;

			// Token: 0x040010C6 RID: 4294
			private object <>2__current;

			// Token: 0x040010C7 RID: 4295
			public int id;

			// Token: 0x040010C8 RID: 4296
			public Sound <>4__this;

			// Token: 0x040010C9 RID: 4297
			private Sound.<>c__DisplayClass39_0 <>8__1;

			// Token: 0x040010CA RID: 4298
			private UnityWebRequest <uwr>5__2;

			// Token: 0x040010CB RID: 4299
			private UnityWebRequest <uwr2>5__3;
		}

		// Token: 0x020003FA RID: 1018
		private sealed class <playC>d__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002BE3 RID: 11235 RVA: 0x0001D736 File Offset: 0x0001B936
			public <playC>d__56(int <>1__state)
			{
			}

			// Token: 0x06002BE4 RID: 11236 RVA: 0x0001D73E File Offset: 0x0001B93E
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002BE5 RID: 11237 RVA: 0x0001D740 File Offset: 0x0001B940
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CE0 RID: 3296
			// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x0001D743 File Offset: 0x0001B943
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002BE7 RID: 11239 RVA: 0x0001D746 File Offset: 0x0001B946
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CE1 RID: 3297
			// (get) Token: 0x06002BE8 RID: 11240 RVA: 0x0001D748 File Offset: 0x0001B948
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x040010CC RID: 4300
			private int <>1__state;

			// Token: 0x040010CD RID: 4301
			private object <>2__current;

			// Token: 0x040010CE RID: 4302
			public Sound <>4__this;

			// Token: 0x040010CF RID: 4303
			private bool <played>5__2;

			// Token: 0x040010D0 RID: 4304
			private int <timeout>5__3;
		}
	}
}
