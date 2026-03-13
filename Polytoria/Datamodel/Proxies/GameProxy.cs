using System;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D9 RID: 729
	public class GameProxy : InstanceProxy
	{
		// Token: 0x060024C9 RID: 9417 RVA: 0x0001C115 File Offset: 0x0001A315
		public GameProxy(Game target) : base(null)
		{
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x0001C11E File Offset: 0x0001A31E
		public LuaEvent Rendered
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x060024CB RID: 9419 RVA: 0x0001C121 File Offset: 0x0001A321
		public int GameID
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x0001C124 File Offset: 0x0001A324
		public int PlayersConnected
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x060024CD RID: 9421 RVA: 0x0001C127 File Offset: 0x0001A327
		public int InstanceCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x0001C12A File Offset: 0x0001A32A
		public int LocalInstanceCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x04000D05 RID: 3333
		private readonly Game game;
	}
}
