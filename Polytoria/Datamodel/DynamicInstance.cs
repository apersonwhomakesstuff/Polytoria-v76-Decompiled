using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000276 RID: 630
	public class DynamicInstance : Instance
	{
		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x0001A857 File Offset: 0x00018A57
		protected virtual bool DoTransformSync
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x0001A85A File Offset: 0x00018A5A
		// (set) Token: 0x06001B67 RID: 7015 RVA: 0x0001A862 File Offset: 0x00018A62
		public SyncMode SyncMode
		{
			get
			{
				return this.<SyncMode>k__BackingField;
			}
			set
			{
				this.<SyncMode>k__BackingField = value;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x00024328 File Offset: 0x00022528
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x0001A86B File Offset: 0x00018A6B
		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x00024340 File Offset: 0x00022540
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x0001A86D File Offset: 0x00018A6D
		public Vector3 Rotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x00024358 File Offset: 0x00022558
		// (set) Token: 0x06001B6D RID: 7021 RVA: 0x0001A86F File Offset: 0x00018A6F
		public Vector3 LocalPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001B6E RID: 7022 RVA: 0x00024370 File Offset: 0x00022570
		// (set) Token: 0x06001B6F RID: 7023 RVA: 0x0001A871 File Offset: 0x00018A71
		public Vector3 LocalRotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001B70 RID: 7024 RVA: 0x00024388 File Offset: 0x00022588
		// (set) Token: 0x06001B71 RID: 7025 RVA: 0x0001A873 File Offset: 0x00018A73
		public Vector3 Size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x000243A0 File Offset: 0x000225A0
		// (set) Token: 0x06001B73 RID: 7027 RVA: 0x0001A875 File Offset: 0x00018A75
		public Vector3 LocalSize
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x000243B8 File Offset: 0x000225B8
		// (set) Token: 0x06001B75 RID: 7029 RVA: 0x0001A877 File Offset: 0x00018A77
		public Quaternion Quaternion
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x000243D0 File Offset: 0x000225D0
		// (set) Token: 0x06001B77 RID: 7031 RVA: 0x0001A879 File Offset: 0x00018A79
		public Quaternion LocalQuaternion
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x000243E8 File Offset: 0x000225E8
		public Vector3 Forward
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x00024400 File Offset: 0x00022600
		public Vector3 Right
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x00024418 File Offset: 0x00022618
		public Vector3 Up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x0001A87B File Offset: 0x00018A7B
		private bool IgnoreSync
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0001A87E File Offset: 0x00018A7E
		private void OnVelocityChanged(Vector3 _, Vector3 newValue)
		{
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0001A880 File Offset: 0x00018A80
		private void OnAngularVelocityChanged(Vector3 _, Vector3 newValue)
		{
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0001A882 File Offset: 0x00018A82
		private void OnIsKinematicChanged(bool _, bool newValue)
		{
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0001A884 File Offset: 0x00018A84
		private void OnUseGravityChanged(bool _, bool newValue)
		{
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0001A886 File Offset: 0x00018A86
		private void OnDragChanged(float _, float newValue)
		{
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0001A888 File Offset: 0x00018A88
		private void OnAngularDragChanged(float _, float newValue)
		{
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0001A88A File Offset: 0x00018A8A
		protected override void Awake()
		{
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0001A88C File Offset: 0x00018A8C
		private void OnGameLoadedLocally()
		{
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0001A88E File Offset: 0x00018A8E
		protected override void OnDestroy()
		{
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0001A890 File Offset: 0x00018A90
		private void RequestTransform()
		{
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0001A892 File Offset: 0x00018A92
		public void ApplyTransform()
		{
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0001A894 File Offset: 0x00018A94
		public void CheckIfChildOfPlayerTool()
		{
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0001A896 File Offset: 0x00018A96
		protected override void Start()
		{
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0001A898 File Offset: 0x00018A98
		public override void OnStartClient()
		{
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0001A89A File Offset: 0x00018A9A
		private void UpdateServer()
		{
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0001A89C File Offset: 0x00018A9C
		private void UpdateClient()
		{
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0001A89E File Offset: 0x00018A9E
		protected virtual void Update()
		{
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0001A8A0 File Offset: 0x00018AA0
		private bool HasTransformChanged()
		{
			return false;
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0001A8A3 File Offset: 0x00018AA3
		private void CacheTransform()
		{
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0001A8A5 File Offset: 0x00018AA5
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0001A8A7 File Offset: 0x00018AA7
		private void SyncPhysics()
		{
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0001A8A9 File Offset: 0x00018AA9
		private void UpdateTransform()
		{
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0001A8AB File Offset: 0x00018AAB
		public void SyncTransformRecursively()
		{
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0001A8AD File Offset: 0x00018AAD
		protected void RpcSyncTransform(Vector3 position, Quaternion rotation, Vector3 size)
		{
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0001A8AF File Offset: 0x00018AAF
		private void CmdRequestTransform(NetworkConnectionToClient sender = null)
		{
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0001A8B1 File Offset: 0x00018AB1
		private void SetTransformTargetRpc(NetworkConnection target, Vector3 position, Quaternion rotation, Vector3 size)
		{
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0001A8B3 File Offset: 0x00018AB3
		public void LookAt(Vector3 target, Vector3 worldUp)
		{
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0001A8B5 File Offset: 0x00018AB5
		public void LookAt(Vector3 target)
		{
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0001A8B7 File Offset: 0x00018AB7
		public void LookAt(DynamicInstance target)
		{
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0001A8B9 File Offset: 0x00018AB9
		public void Translate(Vector3 translation)
		{
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0001A8BB File Offset: 0x00018ABB
		public void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0001A8BD File Offset: 0x00018ABD
		public void Rotate(Vector3 eulerAngles)
		{
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x00024430 File Offset: 0x00022630
		public Vector3 InverseTransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x00024448 File Offset: 0x00022648
		public Vector3 TransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x00024460 File Offset: 0x00022660
		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00024478 File Offset: 0x00022678
		public Vector3 TransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00024490 File Offset: 0x00022690
		public Vector3 InverseTransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x000244A8 File Offset: 0x000226A8
		public Vector3 TransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0001A8C7 File Offset: 0x00018AC7
		private void <Awake>b__74_0()
		{
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0001A8C9 File Offset: 0x00018AC9
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x000244C0 File Offset: 0x000226C0
		// (set) Token: 0x06001BA6 RID: 7078 RVA: 0x0001A8CC File Offset: 0x00018ACC
		public Vector3 Network_velocity
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

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x000244D8 File Offset: 0x000226D8
		// (set) Token: 0x06001BA8 RID: 7080 RVA: 0x0001A8CE File Offset: 0x00018ACE
		public Vector3 Network_angularVelocity
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

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x0001A8D0 File Offset: 0x00018AD0
		// (set) Token: 0x06001BAA RID: 7082 RVA: 0x0001A8D3 File Offset: 0x00018AD3
		public bool Network_isKinematic
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

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001BAB RID: 7083 RVA: 0x0001A8D5 File Offset: 0x00018AD5
		// (set) Token: 0x06001BAC RID: 7084 RVA: 0x0001A8D8 File Offset: 0x00018AD8
		public bool Network_useGravity
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

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x0001A8DA File Offset: 0x00018ADA
		// (set) Token: 0x06001BAE RID: 7086 RVA: 0x0001A8E1 File Offset: 0x00018AE1
		public float Network_drag
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

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x0001A8E3 File Offset: 0x00018AE3
		// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x0001A8EA File Offset: 0x00018AEA
		public float Network_angularDrag
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

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0001A8EC File Offset: 0x00018AEC
		protected void UserCode_RpcSyncTransform__Vector3__Quaternion__Vector3(Vector3 position, Quaternion rotation, Vector3 size)
		{
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0001A8EE File Offset: 0x00018AEE
		protected static void InvokeUserCode_RpcSyncTransform__Vector3__Quaternion__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0001A8F0 File Offset: 0x00018AF0
		protected void UserCode_CmdRequestTransform__NetworkConnectionToClient(NetworkConnectionToClient sender)
		{
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0001A8F2 File Offset: 0x00018AF2
		protected static void InvokeUserCode_CmdRequestTransform__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0001A8F4 File Offset: 0x00018AF4
		protected void UserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3(NetworkConnection target, Vector3 position, Quaternion rotation, Vector3 size)
		{
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x0001A8F6 File Offset: 0x00018AF6
		protected static void InvokeUserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0001A8FA File Offset: 0x00018AFA
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0001A8FC File Offset: 0x00018AFC
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x040009F5 RID: 2549
		public float transformSyncInterval;

		// Token: 0x040009F6 RID: 2550
		public float positionThreshold;

		// Token: 0x040009F7 RID: 2551
		public float rotationThreshold;

		// Token: 0x040009F8 RID: 2552
		public float scaleThreshold;

		// Token: 0x040009F9 RID: 2553
		private Rigidbody _rb;

		// Token: 0x040009FA RID: 2554
		private SyncMode <SyncMode>k__BackingField;

		// Token: 0x040009FB RID: 2555
		private bool syncVelocity;

		// Token: 0x040009FC RID: 2556
		private float velocitySensitivity;

		// Token: 0x040009FD RID: 2557
		private bool syncAngularVelocity;

		// Token: 0x040009FE RID: 2558
		private float angularVelocitySensitivity;

		// Token: 0x040009FF RID: 2559
		protected float timeAlive;

		// Token: 0x04000A00 RID: 2560
		private bool first;

		// Token: 0x04000A01 RID: 2561
		private bool requestedTransform;

		// Token: 0x04000A02 RID: 2562
		private const float MIN_SIZE = 0.01f;

		// Token: 0x04000A03 RID: 2563
		private double lastServerSendTime;

		// Token: 0x04000A04 RID: 2564
		private Vector3 _velocity;

		// Token: 0x04000A05 RID: 2565
		private Vector3 _angularVelocity;

		// Token: 0x04000A06 RID: 2566
		private bool _isKinematic;

		// Token: 0x04000A07 RID: 2567
		private bool _useGravity;

		// Token: 0x04000A08 RID: 2568
		private float _drag;

		// Token: 0x04000A09 RID: 2569
		private float _angularDrag;

		// Token: 0x04000A0A RID: 2570
		private ClientSyncState previousValue;

		// Token: 0x04000A0B RID: 2571
		private Vector3 lastPos;

		// Token: 0x04000A0C RID: 2572
		private Vector3 lastSize;

		// Token: 0x04000A0D RID: 2573
		private Quaternion lastRot;

		// Token: 0x04000A0E RID: 2574
		private Vector3 serverPosition;

		// Token: 0x04000A0F RID: 2575
		private Vector3 serverSize;

		// Token: 0x04000A10 RID: 2576
		private Quaternion serverRotation;

		// Token: 0x04000A11 RID: 2577
		private bool isDirty;

		// Token: 0x04000A12 RID: 2578
		private bool isChildOfPlayerTool;

		// Token: 0x04000A13 RID: 2579
		private Players players;

		// Token: 0x04000A14 RID: 2580
		public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate__velocity;

		// Token: 0x04000A15 RID: 2581
		public Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate__angularVelocity;

		// Token: 0x04000A16 RID: 2582
		public Action<bool, bool> _Mirror_SyncVarHookDelegate__isKinematic;

		// Token: 0x04000A17 RID: 2583
		public Action<bool, bool> _Mirror_SyncVarHookDelegate__useGravity;

		// Token: 0x04000A18 RID: 2584
		public Action<float, float> _Mirror_SyncVarHookDelegate__drag;

		// Token: 0x04000A19 RID: 2585
		public Action<float, float> _Mirror_SyncVarHookDelegate__angularDrag;
	}
}
