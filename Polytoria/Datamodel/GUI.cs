using System;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.UI;

namespace Polytoria.Datamodel
{
	// Token: 0x0200027F RID: 639
	public class GUI : Instance
	{
		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x0001AB26 File Offset: 0x00018D26
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x0001AB29 File Offset: 0x00018D29
		public bool Visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0001AB2B File Offset: 0x00018D2B
		protected override void Start()
		{
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0001AB2D File Offset: 0x00018D2D
		public void Update()
		{
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0001AB2F File Offset: 0x00018D2F
		public void SyncSetVisible(bool oldValue, bool newValue)
		{
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0001AB31 File Offset: 0x00018D31
		protected override void OnHide()
		{
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0001AB33 File Offset: 0x00018D33
		protected override void OnShow()
		{
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x0001AB35 File Offset: 0x00018D35
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0001AB3F File Offset: 0x00018D3F
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x0001AB42 File Offset: 0x00018D42
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x0001AB45 File Offset: 0x00018D45
		public bool Networkvisible
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

		// Token: 0x06001C7D RID: 7293 RVA: 0x0001AB47 File Offset: 0x00018D47
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0001AB49 File Offset: 0x00018D49
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000A6D RID: 2669
		private CreatorViewport vp;

		// Token: 0x04000A6E RID: 2670
		private bool visible;

		// Token: 0x04000A6F RID: 2671
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_visible;
	}
}
