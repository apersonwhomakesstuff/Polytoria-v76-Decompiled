using System;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C3 RID: 707
	public class CoreUIService : MonoBehaviour
	{
		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x0001BDBE File Offset: 0x00019FBE
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x0001BDC5 File Offset: 0x00019FC5
		public static CoreUIService Instance
		{
			get
			{
				return CoreUIService.<Instance>k__BackingField;
			}
			private set
			{
				CoreUIService.<Instance>k__BackingField = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x0001BDCD File Offset: 0x00019FCD
		// (set) Token: 0x060023B3 RID: 9139 RVA: 0x0001BDD0 File Offset: 0x00019FD0
		public bool UserCardEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x0001BDD2 File Offset: 0x00019FD2
		// (set) Token: 0x060023B5 RID: 9141 RVA: 0x0001BDD5 File Offset: 0x00019FD5
		public bool ChatEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x0001BDD7 File Offset: 0x00019FD7
		// (set) Token: 0x060023B7 RID: 9143 RVA: 0x0001BDDA File Offset: 0x00019FDA
		public bool HealthBarEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x0001BDDC File Offset: 0x00019FDC
		// (set) Token: 0x060023B9 RID: 9145 RVA: 0x0001BDDF File Offset: 0x00019FDF
		public bool LeaderboardEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x0001BDE1 File Offset: 0x00019FE1
		// (set) Token: 0x060023BB RID: 9147 RVA: 0x0001BDE4 File Offset: 0x00019FE4
		public bool HotbarEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x0001BDE6 File Offset: 0x00019FE6
		// (set) Token: 0x060023BD RID: 9149 RVA: 0x0001BDE9 File Offset: 0x00019FE9
		public bool MenuButtonEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x0001BDEB File Offset: 0x00019FEB
		// (set) Token: 0x060023BF RID: 9151 RVA: 0x0001BDEE File Offset: 0x00019FEE
		public bool CanRespawn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x0001BDF0 File Offset: 0x00019FF0
		private void Awake()
		{
		}

		// Token: 0x04000CC5 RID: 3269
		private static CoreUIService <Instance>k__BackingField;

		// Token: 0x04000CC6 RID: 3270
		private GameObject userCard;

		// Token: 0x04000CC7 RID: 3271
		private GameObject chat;

		// Token: 0x04000CC8 RID: 3272
		private GameObject healthBar;

		// Token: 0x04000CC9 RID: 3273
		private GameObject leaderboard;

		// Token: 0x04000CCA RID: 3274
		private GameObject hotbar;

		// Token: 0x04000CCB RID: 3275
		private GameObject menuButton;

		// Token: 0x04000CCC RID: 3276
		private GameObject chatButton;

		// Token: 0x04000CCD RID: 3277
		private Button resetButton;
	}
}
