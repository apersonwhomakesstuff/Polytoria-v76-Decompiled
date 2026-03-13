using System;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002F3 RID: 755
	public class SeatProxy : PartProxy
	{
		// Token: 0x06002660 RID: 9824 RVA: 0x0001C5DC File Offset: 0x0001A7DC
		public SeatProxy(Seat target) : base(null)
		{
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x0001C5E5 File Offset: 0x0001A7E5
		public Player Occupant
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002662 RID: 9826 RVA: 0x0001C5E8 File Offset: 0x0001A7E8
		public LuaEvent Sat
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002663 RID: 9827 RVA: 0x0001C5EB File Offset: 0x0001A7EB
		public LuaEvent Vacated
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000D1F RID: 3359
		private readonly Seat seat;
	}
}
