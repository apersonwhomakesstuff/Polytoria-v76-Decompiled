using System;
using System.Runtime.InteropServices;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000282 RID: 642
	public class Instance : NetworkBehaviour
	{
		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x0001ABB8 File Offset: 0x00018DB8
		public bool ClientSpawned
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x0001ABBB File Offset: 0x00018DBB
		public bool CanReparent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x06001CAA RID: 7338 RVA: 0x0001ABBE File Offset: 0x00018DBE
		// (remove) Token: 0x06001CAB RID: 7339 RVA: 0x0001ABC0 File Offset: 0x00018DC0
		public event Action<Instance> _DescendantAdded
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x06001CAC RID: 7340 RVA: 0x0001ABC2 File Offset: 0x00018DC2
		// (remove) Token: 0x06001CAD RID: 7341 RVA: 0x0001ABC4 File Offset: 0x00018DC4
		public event Action _ParentChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x06001CAE RID: 7342 RVA: 0x0001ABC6 File Offset: 0x00018DC6
		// (remove) Token: 0x06001CAF RID: 7343 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		public event Action<Instance> _Touched
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x0001ABCA File Offset: 0x00018DCA
		public int DescendantLevel
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x0001ABCD File Offset: 0x00018DCD
		public Instance Item
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x0001ABD0 File Offset: 0x00018DD0
		public Instance Item
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x0001ABD3 File Offset: 0x00018DD3
		// (set) Token: 0x06001CB4 RID: 7348 RVA: 0x0001ABD6 File Offset: 0x00018DD6
		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x0001ABD8 File Offset: 0x00018DD8
		public string FullName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x0001ABDB File Offset: 0x00018DDB
		public string ClassName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001CB7 RID: 7351 RVA: 0x0001ABDE File Offset: 0x00018DDE
		public DynValue Shared
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x0001ABE1 File Offset: 0x00018DE1
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x0001ABE4 File Offset: 0x00018DE4
		public Instance Parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x0001ABE6 File Offset: 0x00018DE6
		public Instance GetParent()
		{
			return null;
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0001ABE9 File Offset: 0x00018DE9
		public void SetParent(Instance par)
		{
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0001ABEB File Offset: 0x00018DEB
		protected virtual void OnHide()
		{
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x0001ABED File Offset: 0x00018DED
		protected virtual void OnShow()
		{
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0001ABEF File Offset: 0x00018DEF
		private void RpcSetParent(Transform par)
		{
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x0001ABF1 File Offset: 0x00018DF1
		public Instance FindChild(string name)
		{
			return null;
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x0001ABF4 File Offset: 0x00018DF4
		public Instance[] GetChildren()
		{
			return null;
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0001ABF7 File Offset: 0x00018DF7
		public Instance[] GetChildrenOfClass(string className)
		{
			return null;
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0001ABFA File Offset: 0x00018DFA
		public T[] GetChildrenOfType<T>() where T : Instance
		{
			return null;
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x000246A0 File Offset: 0x000228A0
		public T FindChildOfType<T>() where T : Instance
		{
			return default(T);
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0001ABFD File Offset: 0x00018DFD
		public Instance FindChildByClass(string className)
		{
			return null;
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x0001AC00 File Offset: 0x00018E00
		public bool IsA(string className)
		{
			return false;
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x0001AC03 File Offset: 0x00018E03
		public bool IsDescendantOf(Instance other)
		{
			return false;
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x0001AC06 File Offset: 0x00018E06
		public bool IsDescendantOfType<T>() where T : Instance
		{
			return false;
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x0001AC09 File Offset: 0x00018E09
		public void Destroy(float time = 0f)
		{
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x0001AC0B File Offset: 0x00018E0B
		public void Delete(float time = 0f)
		{
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0001AC0D File Offset: 0x00018E0D
		private void RpcSetName(string n)
		{
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0001AC0F File Offset: 0x00018E0F
		private void RequestParent(NetworkConnectionToClient sender = null)
		{
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0001AC11 File Offset: 0x00018E11
		private void SetParentTargetRpc(NetworkConnection target, Transform par, int index)
		{
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x0001AC13 File Offset: 0x00018E13
		protected virtual void Awake()
		{
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x0001AC15 File Offset: 0x00018E15
		protected virtual void Start()
		{
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x0001AC17 File Offset: 0x00018E17
		protected virtual void OnNetworkStart()
		{
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0001AC19 File Offset: 0x00018E19
		public override void OnStartClient()
		{
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x0001AC1B File Offset: 0x00018E1B
		public override void OnStartServer()
		{
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0001AC1D File Offset: 0x00018E1D
		private void OnGameLoaded()
		{
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x0001AC1F File Offset: 0x00018E1F
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x0001AC21 File Offset: 0x00018E21
		public static Instance New(string className, Instance parent = null)
		{
			return null;
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0001AC24 File Offset: 0x00018E24
		protected virtual void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0001AC26 File Offset: 0x00018E26
		protected virtual void OnTriggerEnter(Collider collider)
		{
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0001AC28 File Offset: 0x00018E28
		protected virtual void OnCollisionExit(Collision collision)
		{
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x0001AC2A File Offset: 0x00018E2A
		protected virtual void OnTriggerExit(Collider collider)
		{
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0001AC2C File Offset: 0x00018E2C
		private int GetDescendantLevel()
		{
			return 0;
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x0001AC2F File Offset: 0x00018E2F
		private void OnMouseDown()
		{
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0001AC31 File Offset: 0x00018E31
		private void OnMouseEnter()
		{
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x0001AC33 File Offset: 0x00018E33
		private void OnMouseExit()
		{
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x0001AC35 File Offset: 0x00018E35
		private void CmdClicked(NetworkConnectionToClient sender = null)
		{
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0001AC37 File Offset: 0x00018E37
		public Instance Clone()
		{
			return null;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0001AC3A File Offset: 0x00018E3A
		protected virtual void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x0001AC3C File Offset: 0x00018E3C
		protected virtual void PostClone()
		{
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x000246B8 File Offset: 0x000228B8
		public Bounds GetBounds(BoundsCalculationMethod calculationMethod = BoundsCalculationMethod.Renderer)
		{
			return default(Bounds);
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0001AC46 File Offset: 0x00018E46
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x0001AC49 File Offset: 0x00018E49
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x0001AC4C File Offset: 0x00018E4C
		public string Network_name
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

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0001AC4E File Offset: 0x00018E4E
		protected void UserCode_RpcSetParent__Transform(Transform par)
		{
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0001AC50 File Offset: 0x00018E50
		protected static void InvokeUserCode_RpcSetParent__Transform(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x0001AC52 File Offset: 0x00018E52
		protected void UserCode_RpcSetName__String(string n)
		{
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0001AC54 File Offset: 0x00018E54
		protected static void InvokeUserCode_RpcSetName__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x0001AC56 File Offset: 0x00018E56
		protected void UserCode_RequestParent__NetworkConnectionToClient(NetworkConnectionToClient sender)
		{
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0001AC58 File Offset: 0x00018E58
		protected static void InvokeUserCode_RequestParent__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x0001AC5A File Offset: 0x00018E5A
		protected void UserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32(NetworkConnection target, Transform par, int index)
		{
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x0001AC5C File Offset: 0x00018E5C
		protected static void InvokeUserCode_SetParentTargetRpc__NetworkConnection__Transform__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0001AC5E File Offset: 0x00018E5E
		protected void UserCode_CmdClicked__NetworkConnectionToClient(NetworkConnectionToClient sender)
		{
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0001AC60 File Offset: 0x00018E60
		protected static void InvokeUserCode_CmdClicked__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0001AC64 File Offset: 0x00018E64
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x0001AC66 File Offset: 0x00018E66
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000A7E RID: 2686
		protected Transform _transform;

		// Token: 0x04000A7F RID: 2687
		protected string _name;

		// Token: 0x04000A80 RID: 2688
		protected string className;

		// Token: 0x04000A81 RID: 2689
		protected bool canReparent;

		// Token: 0x04000A82 RID: 2690
		protected bool hidesMembers;

		// Token: 0x04000A83 RID: 2691
		protected bool clientSpawned;

		// Token: 0x04000A84 RID: 2692
		private DynValue shared;

		// Token: 0x04000A85 RID: 2693
		public LuaEvent ChildRemoved;

		// Token: 0x04000A86 RID: 2694
		public LuaEvent ChildAdded;

		// Token: 0x04000A87 RID: 2695
		public LuaEvent Touched;

		// Token: 0x04000A88 RID: 2696
		public LuaEvent TouchEnded;

		// Token: 0x04000A89 RID: 2697
		public LuaEvent MouseHover;

		// Token: 0x04000A8A RID: 2698
		public LuaEvent MouseHoverEnded;

		// Token: 0x04000A8B RID: 2699
		public LuaEvent Clicked;

		// Token: 0x04000A8C RID: 2700
		public LuaEvent MouseEnter;

		// Token: 0x04000A8D RID: 2701
		public LuaEvent MouseExit;

		// Token: 0x04000A91 RID: 2705
		public bool isHidden;

		// Token: 0x04000A92 RID: 2706
		private bool isMouseOver;
	}
}
