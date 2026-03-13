using System;
using Mirror;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002A6 RID: 678
	public class RemoteEvent : Instance
	{
		// Token: 0x060020D1 RID: 8401 RVA: 0x0001B6A9 File Offset: 0x000198A9
		public void Invoke(string val)
		{
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x0001B6AB File Offset: 0x000198AB
		public void Invoke(bool val)
		{
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x0001B6AD File Offset: 0x000198AD
		public void Invoke(float val)
		{
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x0001B6AF File Offset: 0x000198AF
		public void Invoke(int val)
		{
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x0001B6B1 File Offset: 0x000198B1
		public void Invoke(Vector3 val)
		{
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x0001B6B3 File Offset: 0x000198B3
		public void Invoke(Color val)
		{
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x0001B6B5 File Offset: 0x000198B5
		public void Invoke(Instance val)
		{
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x0001B6B7 File Offset: 0x000198B7
		private void CmdInvokeString(string val, NetworkConnectionToClient sender = null)
		{
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x0001B6B9 File Offset: 0x000198B9
		private void CmdInvokeBool(bool val, NetworkConnectionToClient sender = null)
		{
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x0001B6BB File Offset: 0x000198BB
		private void CmdInvokeFloat(float val, NetworkConnectionToClient sender = null)
		{
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x0001B6BD File Offset: 0x000198BD
		private void CmdInvokeInt(int val, NetworkConnectionToClient sender = null)
		{
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x0001B6BF File Offset: 0x000198BF
		private void CmdInvokeVec3(Vector3 val, NetworkConnectionToClient sender = null)
		{
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x0001B6C1 File Offset: 0x000198C1
		private void CmdInvokeColor(Color val, NetworkConnectionToClient sender = null)
		{
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x0001B6C3 File Offset: 0x000198C3
		private void CmdInvokeInstance(Instance val, NetworkConnectionToClient sender = null)
		{
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x0001B6CD File Offset: 0x000198CD
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x0001B6D0 File Offset: 0x000198D0
		protected void UserCode_CmdInvokeString__String__NetworkConnectionToClient(string val, NetworkConnectionToClient sender)
		{
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x0001B6D2 File Offset: 0x000198D2
		protected static void InvokeUserCode_CmdInvokeString__String__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x0001B6D4 File Offset: 0x000198D4
		protected void UserCode_CmdInvokeBool__Boolean__NetworkConnectionToClient(bool val, NetworkConnectionToClient sender)
		{
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x0001B6D6 File Offset: 0x000198D6
		protected static void InvokeUserCode_CmdInvokeBool__Boolean__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x0001B6D8 File Offset: 0x000198D8
		protected void UserCode_CmdInvokeFloat__Single__NetworkConnectionToClient(float val, NetworkConnectionToClient sender)
		{
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x0001B6DA File Offset: 0x000198DA
		protected static void InvokeUserCode_CmdInvokeFloat__Single__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x0001B6DC File Offset: 0x000198DC
		protected void UserCode_CmdInvokeInt__Int32__NetworkConnectionToClient(int val, NetworkConnectionToClient sender)
		{
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x0001B6DE File Offset: 0x000198DE
		protected static void InvokeUserCode_CmdInvokeInt__Int32__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x0001B6E0 File Offset: 0x000198E0
		protected void UserCode_CmdInvokeVec3__Vector3__NetworkConnectionToClient(Vector3 val, NetworkConnectionToClient sender)
		{
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x0001B6E2 File Offset: 0x000198E2
		protected static void InvokeUserCode_CmdInvokeVec3__Vector3__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x0001B6E4 File Offset: 0x000198E4
		protected void UserCode_CmdInvokeColor__Color__NetworkConnectionToClient(Color val, NetworkConnectionToClient sender)
		{
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x0001B6E6 File Offset: 0x000198E6
		protected static void InvokeUserCode_CmdInvokeColor__Color__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x0001B6E8 File Offset: 0x000198E8
		protected void UserCode_CmdInvokeInstance__Instance__NetworkConnectionToClient(Instance val, NetworkConnectionToClient sender)
		{
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x0001B6EA File Offset: 0x000198EA
		protected static void InvokeUserCode_CmdInvokeInstance__Instance__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		// Token: 0x04000BE8 RID: 3048
		public LuaEvent Invoked;
	}
}
