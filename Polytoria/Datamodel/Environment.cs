using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mirror;
using MoonSharp.Interpreter;
using Unity.AI.Navigation;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000279 RID: 633
	public class Environment : Instance
	{
		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x000244F0 File Offset: 0x000226F0
		// (set) Token: 0x06001BBB RID: 7099 RVA: 0x0001A8FE File Offset: 0x00018AFE
		public SkyboxPreset Skybox
		{
			get
			{
				return SkyboxPreset.Day1;
			}
			set
			{
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x00024508 File Offset: 0x00022708
		// (set) Token: 0x06001BBD RID: 7101 RVA: 0x0001A900 File Offset: 0x00018B00
		public Vector3 Gravity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x0001A902 File Offset: 0x00018B02
		// (set) Token: 0x06001BBF RID: 7103 RVA: 0x0001A905 File Offset: 0x00018B05
		public bool FogEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x0001A907 File Offset: 0x00018B07
		// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x0001A90E File Offset: 0x00018B0E
		public float FogStartDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x0001A910 File Offset: 0x00018B10
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x0001A917 File Offset: 0x00018B17
		public float FogEndDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00024520 File Offset: 0x00022720
		// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x0001A919 File Offset: 0x00018B19
		public Color FogColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x0001A91B File Offset: 0x00018B1B
		// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x0001A922 File Offset: 0x00018B22
		public float PartDestroyHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x0001A924 File Offset: 0x00018B24
		// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x0001A927 File Offset: 0x00018B27
		public bool AutoGenerateNavMesh
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0001A929 File Offset: 0x00018B29
		protected override void Awake()
		{
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0001A92B File Offset: 0x00018B2B
		public void CreateExplosion(Vector3 position, float radius = 10f, float force = 5000f, bool affectKinematic = true, DynValue callback = null, float damage = 100000f)
		{
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0001A92D File Offset: 0x00018B2D
		private IEnumerator ExplosionForce(Collider col, Vector3 position, float radius, float force)
		{
			return null;
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00024538 File Offset: 0x00022738
		public RayResult? Raycast(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity, List<Instance> ignoreList = null)
		{
			return null;
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0001A930 File Offset: 0x00018B30
		public RayResult[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity, List<Instance> ignoreList = null)
		{
			return null;
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0001A933 File Offset: 0x00018B33
		public Instance[] OverlapSphere(Vector3 position, float radius, List<Instance> ignoreList = null)
		{
			return null;
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0001A936 File Offset: 0x00018B36
		public Instance[] OverlapBox(Vector3 center, Vector3 size, Vector3 rotation, List<Instance> ignoreList = null)
		{
			return null;
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0001A939 File Offset: 0x00018B39
		protected override void Start()
		{
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0001A93B File Offset: 0x00018B3B
		public void RebuildNavMesh(Instance root = null)
		{
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00024550 File Offset: 0x00022750
		public Vector3 GetPointOnNavMesh(Vector3 position, float maxDistance = 100f)
		{
			return default(Vector3);
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0001A93D File Offset: 0x00018B3D
		private void RpcSetSkybox(SkyboxPreset sky)
		{
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0001A93F File Offset: 0x00018B3F
		private void RpcExplode(Vector3 position, float radius)
		{
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0001A941 File Offset: 0x00018B41
		private void AddPlrExplosionForce(Player player, Vector3 position, float radius, float force)
		{
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0001A943 File Offset: 0x00018B43
		private void ApplyForceTargetRpc(NetworkConnection target, Vector3 force)
		{
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0001A945 File Offset: 0x00018B45
		private void RpcSetGravity(Vector3 g)
		{
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0001A947 File Offset: 0x00018B47
		private void RpcSetFogEnabled(bool enabled)
		{
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0001A949 File Offset: 0x00018B49
		private void RpcSetFogStartDistance(float dist)
		{
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0001A94B File Offset: 0x00018B4B
		private void RpcSetFogEndDistance(float dist)
		{
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0001A94D File Offset: 0x00018B4D
		private void RpcSetFogColor(Color c)
		{
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0001A957 File Offset: 0x00018B57
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x00024568 File Offset: 0x00022768
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x0001A95A File Offset: 0x00018B5A
		public SkyboxPreset Networkskybox
		{
			get
			{
				return SkyboxPreset.Day1;
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x00024580 File Offset: 0x00022780
		// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x0001A95C File Offset: 0x00018B5C
		public Vector3 Networkgravity
		{
			get
			{
				return default(Vector3);
			}
			[param: In]
			set
			{
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x0001A95E File Offset: 0x00018B5E
		// (set) Token: 0x06001BE4 RID: 7140 RVA: 0x0001A961 File Offset: 0x00018B61
		public bool NetworkfogEnabled
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

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x0001A963 File Offset: 0x00018B63
		// (set) Token: 0x06001BE6 RID: 7142 RVA: 0x0001A96A File Offset: 0x00018B6A
		public float NetworkfogStartDistance
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

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x0001A96C File Offset: 0x00018B6C
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x0001A973 File Offset: 0x00018B73
		public float NetworkfogEndDistance
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

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x00024598 File Offset: 0x00022798
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x0001A975 File Offset: 0x00018B75
		public Color NetworkfogColor
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

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x0001A977 File Offset: 0x00018B77
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x0001A97E File Offset: 0x00018B7E
		public float NetworkpartDestroyHeight
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

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x0001A980 File Offset: 0x00018B80
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x0001A983 File Offset: 0x00018B83
		public bool NetworkautoGenerateNavMesh
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

		// Token: 0x06001BEF RID: 7151 RVA: 0x0001A985 File Offset: 0x00018B85
		protected void UserCode_RpcSetSkybox__SkyboxPreset(SkyboxPreset sky)
		{
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x0001A987 File Offset: 0x00018B87
		protected static void InvokeUserCode_RpcSetSkybox__SkyboxPreset(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x0001A989 File Offset: 0x00018B89
		protected void UserCode_RpcExplode__Vector3__Single(Vector3 position, float radius)
		{
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0001A98B File Offset: 0x00018B8B
		protected static void InvokeUserCode_RpcExplode__Vector3__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0001A98D File Offset: 0x00018B8D
		protected void UserCode_ApplyForceTargetRpc__NetworkConnection__Vector3(NetworkConnection target, Vector3 force)
		{
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0001A98F File Offset: 0x00018B8F
		protected static void InvokeUserCode_ApplyForceTargetRpc__NetworkConnection__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0001A991 File Offset: 0x00018B91
		protected void UserCode_RpcSetGravity__Vector3(Vector3 g)
		{
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0001A993 File Offset: 0x00018B93
		protected static void InvokeUserCode_RpcSetGravity__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0001A995 File Offset: 0x00018B95
		protected void UserCode_RpcSetFogEnabled__Boolean(bool enabled)
		{
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0001A997 File Offset: 0x00018B97
		protected static void InvokeUserCode_RpcSetFogEnabled__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0001A999 File Offset: 0x00018B99
		protected void UserCode_RpcSetFogStartDistance__Single(float dist)
		{
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0001A99B File Offset: 0x00018B9B
		protected static void InvokeUserCode_RpcSetFogStartDistance__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0001A99D File Offset: 0x00018B9D
		protected void UserCode_RpcSetFogEndDistance__Single(float dist)
		{
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0001A99F File Offset: 0x00018B9F
		protected static void InvokeUserCode_RpcSetFogEndDistance__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0001A9A1 File Offset: 0x00018BA1
		protected void UserCode_RpcSetFogColor__Color(Color c)
		{
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0001A9A3 File Offset: 0x00018BA3
		protected static void InvokeUserCode_RpcSetFogColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0001A9A7 File Offset: 0x00018BA7
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0001A9A9 File Offset: 0x00018BA9
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000A25 RID: 2597
		private SkyboxPreset skybox;

		// Token: 0x04000A26 RID: 2598
		private Vector3 gravity;

		// Token: 0x04000A27 RID: 2599
		private bool fogEnabled;

		// Token: 0x04000A28 RID: 2600
		private float fogStartDistance;

		// Token: 0x04000A29 RID: 2601
		private float fogEndDistance;

		// Token: 0x04000A2A RID: 2602
		private Color fogColor;

		// Token: 0x04000A2B RID: 2603
		private float partDestroyHeight;

		// Token: 0x04000A2C RID: 2604
		private bool autoGenerateNavMesh;

		// Token: 0x04000A2D RID: 2605
		private NavMeshSurface surface;

		// Token: 0x04000A2E RID: 2606
		private GameObject explosionPrefab;

		// Token: 0x020003E8 RID: 1000
		private sealed class <ExplosionForce>d__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002B87 RID: 11143 RVA: 0x0001D5E1 File Offset: 0x0001B7E1
			public <ExplosionForce>d__36(int <>1__state)
			{
			}

			// Token: 0x06002B88 RID: 11144 RVA: 0x0001D5E9 File Offset: 0x0001B7E9
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002B89 RID: 11145 RVA: 0x0001D5EB File Offset: 0x0001B7EB
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CC6 RID: 3270
			// (get) Token: 0x06002B8A RID: 11146 RVA: 0x0001D5EE File Offset: 0x0001B7EE
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002B8B RID: 11147 RVA: 0x0001D5F1 File Offset: 0x0001B7F1
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CC7 RID: 3271
			// (get) Token: 0x06002B8C RID: 11148 RVA: 0x0001D5F3 File Offset: 0x0001B7F3
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001081 RID: 4225
			private int <>1__state;

			// Token: 0x04001082 RID: 4226
			private object <>2__current;

			// Token: 0x04001083 RID: 4227
			public Collider col;

			// Token: 0x04001084 RID: 4228
			public float force;

			// Token: 0x04001085 RID: 4229
			public Vector3 position;

			// Token: 0x04001086 RID: 4230
			public float radius;
		}
	}
}
