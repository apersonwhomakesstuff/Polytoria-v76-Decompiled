using System;
using System.Runtime.InteropServices;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002A2 RID: 674
	public class PlayerGUI : Instance
	{
		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x0001B55A File Offset: 0x0001975A
		// (set) Token: 0x0600205B RID: 8283 RVA: 0x0001B55D File Offset: 0x0001975D
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

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x0001B55F File Offset: 0x0001975F
		// (set) Token: 0x0600205D RID: 8285 RVA: 0x0001B566 File Offset: 0x00019766
		public float Opacity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x0001B568 File Offset: 0x00019768
		private void SyncSetInteractable(bool oldValue, bool newValue)
		{
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x0001B56A File Offset: 0x0001976A
		private void SyncSetOpacity(float oldValue, float newValue)
		{
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x0001B56C File Offset: 0x0001976C
		protected override void Awake()
		{
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x0001B56E File Offset: 0x0001976E
		protected override void Start()
		{
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x0001B578 File Offset: 0x00019778
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x0001B57B File Offset: 0x0001977B
		// (set) Token: 0x06002065 RID: 8293 RVA: 0x0001B57E File Offset: 0x0001977E
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

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x0001B580 File Offset: 0x00019780
		// (set) Token: 0x06002067 RID: 8295 RVA: 0x0001B587 File Offset: 0x00019787
		public float Networkopacity
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

		// Token: 0x06002068 RID: 8296 RVA: 0x0001B589 File Offset: 0x00019789
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x0001B58B File Offset: 0x0001978B
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000BCD RID: 3021
		private CanvasGroup canvasGroup;

		// Token: 0x04000BCE RID: 3022
		private bool interactable;

		// Token: 0x04000BCF RID: 3023
		private float opacity;

		// Token: 0x04000BD0 RID: 3024
		public Action<bool, bool> _Mirror_SyncVarHookDelegate_interactable;

		// Token: 0x04000BD1 RID: 3025
		public Action<float, float> _Mirror_SyncVarHookDelegate_opacity;
	}
}
