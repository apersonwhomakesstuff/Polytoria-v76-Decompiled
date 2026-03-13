using System;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002A8 RID: 680
	public class Seat : Part
	{
		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x0001B6F9 File Offset: 0x000198F9
		public Player Occupant
		{
			get
			{
				return null;
			}
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x060020F3 RID: 8435 RVA: 0x0001B6FC File Offset: 0x000198FC
		// (remove) Token: 0x060020F4 RID: 8436 RVA: 0x0001B6FE File Offset: 0x000198FE
		public event Action<Player> _Sat
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x060020F5 RID: 8437 RVA: 0x0001B700 File Offset: 0x00019900
		// (remove) Token: 0x060020F6 RID: 8438 RVA: 0x0001B702 File Offset: 0x00019902
		public event Action<Player> _Vacated
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x0001B704 File Offset: 0x00019904
		protected override void Start()
		{
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x0001B706 File Offset: 0x00019906
		protected override void Update()
		{
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x0001B708 File Offset: 0x00019908
		protected override void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x0001B70A File Offset: 0x0001990A
		protected override void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x0001B70C File Offset: 0x0001990C
		public void SetOccupant(Player player)
		{
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x0001B716 File Offset: 0x00019916
		public override bool Weaved()
		{
			return false;
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x0001B719 File Offset: 0x00019919
		// (set) Token: 0x060020FF RID: 8447 RVA: 0x0001B71C File Offset: 0x0001991C
		public Player Networkoccupant
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

		// Token: 0x06002100 RID: 8448 RVA: 0x0001B71E File Offset: 0x0001991E
		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x0001B720 File Offset: 0x00019920
		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}

		// Token: 0x04000BE9 RID: 3049
		private Player occupant;

		// Token: 0x04000BEA RID: 3050
		private float timeUntilCanSitAgain;

		// Token: 0x04000BEC RID: 3052
		public LuaEvent Sat;

		// Token: 0x04000BEE RID: 3054
		public LuaEvent Vacated;

		// Token: 0x04000BEF RID: 3055
		protected NetworkBehaviourSyncVar ___occupantNetId;
	}
}
