using System;

namespace Polytoria.Networking
{
	// Token: 0x02000260 RID: 608
	public struct AuthUserData
	{
		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x0001A4A0 File Offset: 0x000186A0
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x0001A4A8 File Offset: 0x000186A8
		public int ID
		{
			get
			{
				return this.<ID>k__BackingField;
			}
			set
			{
				this.<ID>k__BackingField = value;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x0001A4B1 File Offset: 0x000186B1
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x0001A4B9 File Offset: 0x000186B9
		public string Username
		{
			get
			{
				return this.<Username>k__BackingField;
			}
			set
			{
				this.<Username>k__BackingField = value;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x0001A4C2 File Offset: 0x000186C2
		// (set) Token: 0x06001A3C RID: 6716 RVA: 0x0001A4CA File Offset: 0x000186CA
		public string Token
		{
			get
			{
				return this.<Token>k__BackingField;
			}
			set
			{
				this.<Token>k__BackingField = value;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x0001A4D3 File Offset: 0x000186D3
		// (set) Token: 0x06001A3E RID: 6718 RVA: 0x0001A4DB File Offset: 0x000186DB
		public bool CanChat
		{
			get
			{
				return this.<CanChat>k__BackingField;
			}
			set
			{
				this.<CanChat>k__BackingField = value;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x0001A4E4 File Offset: 0x000186E4
		// (set) Token: 0x06001A40 RID: 6720 RVA: 0x0001A4EC File Offset: 0x000186EC
		public bool IsAgeRestricted
		{
			get
			{
				return this.<IsAgeRestricted>k__BackingField;
			}
			set
			{
				this.<IsAgeRestricted>k__BackingField = value;
			}
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0001A4F5 File Offset: 0x000186F5
		public AuthUserData(int id, string username, string token, bool canChat, bool isAgeRestricted)
		{
			this.<ID>k__BackingField = 0;
			this.<Username>k__BackingField = null;
			this.<Token>k__BackingField = null;
			this.<CanChat>k__BackingField = false;
			this.<IsAgeRestricted>k__BackingField = false;
		}

		// Token: 0x040009A2 RID: 2466
		private int <ID>k__BackingField;

		// Token: 0x040009A3 RID: 2467
		private string <Username>k__BackingField;

		// Token: 0x040009A4 RID: 2468
		private string <Token>k__BackingField;

		// Token: 0x040009A5 RID: 2469
		private bool <CanChat>k__BackingField;

		// Token: 0x040009A6 RID: 2470
		private bool <IsAgeRestricted>k__BackingField;
	}
}
