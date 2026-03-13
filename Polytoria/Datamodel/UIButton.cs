using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine.UI;

namespace Polytoria.Datamodel
{
	// Token: 0x020002B3 RID: 691
	public class UIButton : UILabel
	{
		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002229 RID: 8745 RVA: 0x0001BA0F File Offset: 0x00019C0F
		// (set) Token: 0x0600222A RID: 8746 RVA: 0x0001BA12 File Offset: 0x00019C12
		public bool Interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x0001BA14 File Offset: 0x00019C14
		protected override void Awake()
		{
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x0001BA16 File Offset: 0x00019C16
		protected override void Start()
		{
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x0001BA18 File Offset: 0x00019C18
		private void SetInteractable(bool oldValue, bool value)
		{
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x0001BA1A File Offset: 0x00019C1A
		protected override void CopyProperties(Instance clone)
		{
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x0001BA24 File Offset: 0x00019C24
		private void <Start>b__6_0()
		{
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x0001BA26 File Offset: 0x00019C26
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x0001BA29 File Offset: 0x00019C29
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x0001BA2C File Offset: 0x00019C2C
		public bool Networkinteractable
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

		// Token: 0x06002234 RID: 8756 RVA: 0x0001BA2E File Offset: 0x00019C2E
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x0001BA30 File Offset: 0x00019C30
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000C26 RID: 3110
		private Button button;

		// Token: 0x04000C27 RID: 3111
		private bool interactable;

		// Token: 0x04000C28 RID: 3112
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_interactable;
	}
}
