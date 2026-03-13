using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel
{
	// Token: 0x0200026E RID: 622
	public class BaseScript : Instance
	{
		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x0001A5DE File Offset: 0x000187DE
		// (set) Token: 0x06001AA2 RID: 6818 RVA: 0x0001A5E1 File Offset: 0x000187E1
		public string Source
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x0001A5E3 File Offset: 0x000187E3
		// (set) Token: 0x06001AA4 RID: 6820 RVA: 0x0001A5E6 File Offset: 0x000187E6
		public new object Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0001A5E8 File Offset: 0x000187E8
		protected override void Awake()
		{
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0001A5EA File Offset: 0x000187EA
		protected override void Start()
		{
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x0001A5EC File Offset: 0x000187EC
		protected override void OnNetworkStart()
		{
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x0001A5EE File Offset: 0x000187EE
		public override void OnStartClient()
		{
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0001A5F0 File Offset: 0x000187F0
		public void Run()
		{
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x0001A5F2 File Offset: 0x000187F2
		private void RpcRun()
		{
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0001A5F4 File Offset: 0x000187F4
		public void Call(string function, object[] args)
		{
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0001A5F6 File Offset: 0x000187F6
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0001A5F8 File Offset: 0x000187F8
		protected override void PostClone()
		{
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0001A5FA File Offset: 0x000187FA
		public void Update()
		{
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0001A5FC File Offset: 0x000187FC
		public void FixedUpdate()
		{
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0001A5FE File Offset: 0x000187FE
		protected override void OnHide()
		{
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0001A600 File Offset: 0x00018800
		protected override void OnShow()
		{
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0001A60A File Offset: 0x0001880A
		private void <Awake>b__11_0()
		{
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0001A60C File Offset: 0x0001880C
		private IEnumerator <RpcRun>g__DelayedRun|18_0()
		{
			return null;
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0001A60F File Offset: 0x0001880F
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x0001A612 File Offset: 0x00018812
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x0001A615 File Offset: 0x00018815
		public string Networksource
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

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0001A617 File Offset: 0x00018817
		protected void UserCode_RpcRun()
		{
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0001A619 File Offset: 0x00018819
		protected static void InvokeUserCode_RpcRun(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x0001A61D File Offset: 0x0001881D
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0001A61F File Offset: 0x0001881F
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x040009A9 RID: 2473
		public bool running;

		// Token: 0x040009AA RID: 2474
		private bool requestedRun;

		// Token: 0x040009AB RID: 2475
		private ScriptService scriptService;

		// Token: 0x040009AC RID: 2476
		public string source;

		// Token: 0x040009AD RID: 2477
		public Script script;

		// Token: 0x040009AE RID: 2478
		private DynValue updateFunc;

		// Token: 0x040009AF RID: 2479
		private DynValue fixedUpdateFunc;

		// Token: 0x020003E7 RID: 999
		private sealed class <<RpcRun>g__DelayedRun|18_0>d : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002B81 RID: 11137 RVA: 0x0001D5CC File Offset: 0x0001B7CC
			public <<RpcRun>g__DelayedRun|18_0>d(int <>1__state)
			{
			}

			// Token: 0x06002B82 RID: 11138 RVA: 0x0001D5D4 File Offset: 0x0001B7D4
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002B83 RID: 11139 RVA: 0x0001D5D6 File Offset: 0x0001B7D6
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x17000CC4 RID: 3268
			// (get) Token: 0x06002B84 RID: 11140 RVA: 0x0001D5D9 File Offset: 0x0001B7D9
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002B85 RID: 11141 RVA: 0x0001D5DC File Offset: 0x0001B7DC
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000CC5 RID: 3269
			// (get) Token: 0x06002B86 RID: 11142 RVA: 0x0001D5DE File Offset: 0x0001B7DE
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x0400107E RID: 4222
			private int <>1__state;

			// Token: 0x0400107F RID: 4223
			private object <>2__current;

			// Token: 0x04001080 RID: 4224
			public BaseScript <>4__this;
		}
	}
}
