using System;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002EE RID: 750
	public class PlayersProxy : InstanceProxy
	{
		// Token: 0x06002637 RID: 9783 RVA: 0x0001C546 File Offset: 0x0001A746
		public PlayersProxy(Players target) : base(null)
		{
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x0001C54F File Offset: 0x0001A74F
		public LuaEvent PlayerAdded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002639 RID: 9785 RVA: 0x0001C552 File Offset: 0x0001A752
		public LuaEvent PlayerRemoved
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x0001C555 File Offset: 0x0001A755
		// (set) Token: 0x0600263B RID: 9787 RVA: 0x0001C558 File Offset: 0x0001A758
		public bool PlayerCollisionEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x0001C55A File Offset: 0x0001A75A
		public Player LocalPlayer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x0001C55D File Offset: 0x0001A75D
		public Player[] GetPlayers()
		{
			return null;
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x0001C560 File Offset: 0x0001A760
		public Player GetPlayer(string username)
		{
			return null;
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x0001C563 File Offset: 0x0001A763
		public Player GetPlayerByID(int id)
		{
			return null;
		}

		// Token: 0x04000D1A RID: 3354
		private readonly Players players;
	}
}
