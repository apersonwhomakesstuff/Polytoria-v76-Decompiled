using System;

namespace Polytoria.Datamodel
{
	// Token: 0x0200029F RID: 671
	public class PlayerChatEvent
	{
		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x0001B464 File Offset: 0x00019664
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x0001B46C File Offset: 0x0001966C
		public Player Player
		{
			get
			{
				return this.<Player>k__BackingField;
			}
			private set
			{
				this.<Player>k__BackingField = value;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x0001B475 File Offset: 0x00019675
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x0001B47D File Offset: 0x0001967D
		public string Message
		{
			get
			{
				return this.<Message>k__BackingField;
			}
			private set
			{
				this.<Message>k__BackingField = value;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x0001B486 File Offset: 0x00019686
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x0001B48E File Offset: 0x0001968E
		public bool Canceled
		{
			get
			{
				return this.<Canceled>k__BackingField;
			}
			set
			{
				this.<Canceled>k__BackingField = value;
			}
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x0001B497 File Offset: 0x00019697
		public PlayerChatEvent(Player player, string message)
		{
		}

		// Token: 0x04000BB9 RID: 3001
		private Player <Player>k__BackingField;

		// Token: 0x04000BBA RID: 3002
		private string <Message>k__BackingField;

		// Token: 0x04000BBB RID: 3003
		private bool <Canceled>k__BackingField;
	}
}
