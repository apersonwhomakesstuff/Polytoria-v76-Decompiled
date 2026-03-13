using System;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F1 RID: 753
	public class RemoveEventProxy : InstanceProxy
	{
		// Token: 0x06002656 RID: 9814 RVA: 0x0001C5B9 File Offset: 0x0001A7B9
		public RemoveEventProxy(RemoteEvent target) : base(null)
		{
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x0001C5C2 File Offset: 0x0001A7C2
		public LuaEvent Invoked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x0001C5C5 File Offset: 0x0001A7C5
		public void Invoke(string val)
		{
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x0001C5C7 File Offset: 0x0001A7C7
		public void Invoke(bool val)
		{
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x0001C5C9 File Offset: 0x0001A7C9
		public void Invoke(float val)
		{
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x0001C5CB File Offset: 0x0001A7CB
		public void Invoke(int val)
		{
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x0001C5CD File Offset: 0x0001A7CD
		public void Invoke(Vector3 val)
		{
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x0001C5CF File Offset: 0x0001A7CF
		public void Invoke(Color val)
		{
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x0001C5D1 File Offset: 0x0001A7D1
		public void Invoke(Instance val)
		{
		}

		// Token: 0x04000D1D RID: 3357
		private readonly RemoteEvent remoteEvent;
	}
}
