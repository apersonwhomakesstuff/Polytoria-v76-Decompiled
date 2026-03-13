using System;
using System.Collections;
using System.Collections.Generic;
using Polytoria.Datamodel;
using Polytoria.UI;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	// Token: 0x0200033C RID: 828
	public class UIController : MonoBehaviour
	{
		// Token: 0x14000053 RID: 83
		// (add) Token: 0x060028E3 RID: 10467 RVA: 0x0001CD6C File Offset: 0x0001AF6C
		// (remove) Token: 0x060028E4 RID: 10468 RVA: 0x0001CD6E File Offset: 0x0001AF6E
		public event Action Resetted
		{
			add
			{
			}
			remove
			{
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x0001CD70 File Offset: 0x0001AF70
		// (set) Token: 0x060028E6 RID: 10470 RVA: 0x0001CD78 File Offset: 0x0001AF78
		public RectTransform Leaderboard
		{
			get
			{
				return this.<Leaderboard>k__BackingField;
			}
			private set
			{
				this.<Leaderboard>k__BackingField = value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x0001CD81 File Offset: 0x0001AF81
		// (set) Token: 0x060028E8 RID: 10472 RVA: 0x0001CD89 File Offset: 0x0001AF89
		public RectTransform LeaderboardContent
		{
			get
			{
				return this.<LeaderboardContent>k__BackingField;
			}
			private set
			{
				this.<LeaderboardContent>k__BackingField = value;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x0001CD92 File Offset: 0x0001AF92
		// (set) Token: 0x060028EA RID: 10474 RVA: 0x0001CD9A File Offset: 0x0001AF9A
		public RectTransform UserTag
		{
			get
			{
				return this.<UserTag>k__BackingField;
			}
			private set
			{
				this.<UserTag>k__BackingField = value;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x0001CDA3 File Offset: 0x0001AFA3
		// (set) Token: 0x060028EC RID: 10476 RVA: 0x0001CDAB File Offset: 0x0001AFAB
		public RectTransform PauseMenu
		{
			get
			{
				return this.<PauseMenu>k__BackingField;
			}
			private set
			{
				this.<PauseMenu>k__BackingField = value;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x060028ED RID: 10477 RVA: 0x0001CDB4 File Offset: 0x0001AFB4
		// (set) Token: 0x060028EE RID: 10478 RVA: 0x0001CDBC File Offset: 0x0001AFBC
		public RectTransform ChatButton
		{
			get
			{
				return this.<ChatButton>k__BackingField;
			}
			private set
			{
				this.<ChatButton>k__BackingField = value;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x0001CDC5 File Offset: 0x0001AFC5
		// (set) Token: 0x060028F0 RID: 10480 RVA: 0x0001CDCD File Offset: 0x0001AFCD
		public RectTransform InventoryButton
		{
			get
			{
				return this.<InventoryButton>k__BackingField;
			}
			private set
			{
				this.<InventoryButton>k__BackingField = value;
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060028F1 RID: 10481 RVA: 0x0001CDD6 File Offset: 0x0001AFD6
		// (set) Token: 0x060028F2 RID: 10482 RVA: 0x0001CDDE File Offset: 0x0001AFDE
		public RectTransform DebugConsole
		{
			get
			{
				return this.<DebugConsole>k__BackingField;
			}
			private set
			{
				this.<DebugConsole>k__BackingField = value;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060028F3 RID: 10483 RVA: 0x0001CDE7 File Offset: 0x0001AFE7
		// (set) Token: 0x060028F4 RID: 10484 RVA: 0x0001CDEF File Offset: 0x0001AFEF
		public Image PauseMenuImg
		{
			get
			{
				return this.<PauseMenuImg>k__BackingField;
			}
			private set
			{
				this.<PauseMenuImg>k__BackingField = value;
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060028F5 RID: 10485 RVA: 0x0001CDF8 File Offset: 0x0001AFF8
		// (set) Token: 0x060028F6 RID: 10486 RVA: 0x0001CE00 File Offset: 0x0001B000
		public RectTransform PauseMenuChild
		{
			get
			{
				return this.<PauseMenuChild>k__BackingField;
			}
			private set
			{
				this.<PauseMenuChild>k__BackingField = value;
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060028F7 RID: 10487 RVA: 0x0001CE09 File Offset: 0x0001B009
		// (set) Token: 0x060028F8 RID: 10488 RVA: 0x0001CE11 File Offset: 0x0001B011
		public Canvas Canvas
		{
			get
			{
				return this.<Canvas>k__BackingField;
			}
			private set
			{
				this.<Canvas>k__BackingField = value;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x0001CE1A File Offset: 0x0001B01A
		// (set) Token: 0x060028FA RID: 10490 RVA: 0x0001CE22 File Offset: 0x0001B022
		public TMP_InputField ChatBar
		{
			get
			{
				return this.<ChatBar>k__BackingField;
			}
			private set
			{
				this.<ChatBar>k__BackingField = value;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x0001CE2B File Offset: 0x0001B02B
		// (set) Token: 0x060028FC RID: 10492 RVA: 0x0001CE32 File Offset: 0x0001B032
		public static bool Paused
		{
			get
			{
				return UIController.<Paused>k__BackingField;
			}
			private set
			{
				UIController.<Paused>k__BackingField = value;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060028FD RID: 10493 RVA: 0x0001CE3A File Offset: 0x0001B03A
		// (set) Token: 0x060028FE RID: 10494 RVA: 0x0001CE41 File Offset: 0x0001B041
		public static bool ConsoleOpen
		{
			get
			{
				return UIController.<ConsoleOpen>k__BackingField;
			}
			private set
			{
				UIController.<ConsoleOpen>k__BackingField = value;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x0001CE49 File Offset: 0x0001B049
		// (set) Token: 0x06002900 RID: 10496 RVA: 0x0001CE51 File Offset: 0x0001B051
		public Image HealthbarCont
		{
			get
			{
				return this.<HealthbarCont>k__BackingField;
			}
			private set
			{
				this.<HealthbarCont>k__BackingField = value;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x0001CE5A File Offset: 0x0001B05A
		// (set) Token: 0x06002902 RID: 10498 RVA: 0x0001CE62 File Offset: 0x0001B062
		public Image Healthbar
		{
			get
			{
				return this.<Healthbar>k__BackingField;
			}
			private set
			{
				this.<Healthbar>k__BackingField = value;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x0001CE6B File Offset: 0x0001B06B
		// (set) Token: 0x06002904 RID: 10500 RVA: 0x0001CE73 File Offset: 0x0001B073
		public Image HealthbarHeart
		{
			get
			{
				return this.<HealthbarHeart>k__BackingField;
			}
			private set
			{
				this.<HealthbarHeart>k__BackingField = value;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x0001CE7C File Offset: 0x0001B07C
		// (set) Token: 0x06002906 RID: 10502 RVA: 0x0001CE84 File Offset: 0x0001B084
		public TMP_Text HealthbarHeartText
		{
			get
			{
				return this.<HealthbarHeartText>k__BackingField;
			}
			private set
			{
				this.<HealthbarHeartText>k__BackingField = value;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x0001CE8D File Offset: 0x0001B08D
		// (set) Token: 0x06002908 RID: 10504 RVA: 0x0001CE95 File Offset: 0x0001B095
		public UIStaminaBar StaminaBar
		{
			get
			{
				return this.<StaminaBar>k__BackingField;
			}
			private set
			{
				this.<StaminaBar>k__BackingField = value;
			}
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x0001CE9E File Offset: 0x0001B09E
		private void Awake()
		{
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x0001CEA0 File Offset: 0x0001B0A0
		public void SetActiveMenuTab(int index)
		{
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x0001CEA2 File Offset: 0x0001B0A2
		public void SetButtonFocused(UIController.HudButton type, bool focused)
		{
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x0001CEA4 File Offset: 0x0001B0A4
		private void ToggleLeaderboard()
		{
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x0001CEA6 File Offset: 0x0001B0A6
		private void Update()
		{
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x0001CEA8 File Offset: 0x0001B0A8
		private void UpdateInstanceCount()
		{
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x0001CEAA File Offset: 0x0001B0AA
		private void UpdateTimer()
		{
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x0001CEAC File Offset: 0x0001B0AC
		private void UpdatePlayerCount()
		{
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x0001CEAE File Offset: 0x0001B0AE
		public void ResetCharacter()
		{
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x0001CEB0 File Offset: 0x0001B0B0
		public void ExitGame()
		{
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x0001CEB2 File Offset: 0x0001B0B2
		public void TogglePaused()
		{
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x0001CEB4 File Offset: 0x0001B0B4
		public void SetPaused(bool paused)
		{
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x0001CEB6 File Offset: 0x0001B0B6
		public void SetGameInfo(string gameName)
		{
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x0001CEB8 File Offset: 0x0001B0B8
		public Sprite GetLeaderboardBadgeIcon(string badgeName)
		{
			return null;
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x0001CEBB File Offset: 0x0001B0BB
		public void AddLeaderboardUser(Player player)
		{
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x0001CEBD File Offset: 0x0001B0BD
		private IEnumerator LoadLeaderboardThumbnail(RectTransform _lbEntry, RectTransform _plEntry, Player player)
		{
			return null;
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x0001CEC0 File Offset: 0x0001B0C0
		public void RemoveLeaderboardUser(string username)
		{
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x0001CEC2 File Offset: 0x0001B0C2
		public void SetUserCard(int userId, string username)
		{
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x0001CEC4 File Offset: 0x0001B0C4
		public void ReceiveChat(string username, string message, Color usernameColor)
		{
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x0001CEC6 File Offset: 0x0001B0C6
		public void DebugLog(string message, bool error)
		{
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x0001CEC8 File Offset: 0x0001B0C8
		public void SetHealthFilled(float fill)
		{
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x0001CECA File Offset: 0x0001B0CA
		public void SetStaminaFilled(float fill, bool exhausted)
		{
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x0001CECC File Offset: 0x0001B0CC
		public void ToggleConsole()
		{
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x0001CECE File Offset: 0x0001B0CE
		public void OpenConsoleFromPauseMenu()
		{
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x0001CED0 File Offset: 0x0001B0D0
		public void SetConsoleOpen(bool open)
		{
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x0001CED2 File Offset: 0x0001B0D2
		private IEnumerator LoadThumbnail(int userId)
		{
			return null;
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x0001CED5 File Offset: 0x0001B0D5
		private Texture2D FlipTexture(Texture2D original)
		{
			return null;
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x0001CED8 File Offset: 0x0001B0D8
		public void ShowDisconnectMessage(string reason)
		{
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x0001CEE4 File Offset: 0x0001B0E4
		private void <SetPaused>g__pauseUpdateDelegate|116_0(float val)
		{
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x0001CEE6 File Offset: 0x0001B0E6
		private void <SetPaused>b__116_1()
		{
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x0001CEE8 File Offset: 0x0001B0E8
		private void <SetPaused>b__116_2()
		{
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x0001CEEA File Offset: 0x0001B0EA
		private void <SetConsoleOpen>b__133_0()
		{
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x0001CEEC File Offset: 0x0001B0EC
		private void <SetConsoleOpen>b__133_1()
		{
		}

		// Token: 0x04000E02 RID: 3586
		public static int maxDebugLogLength;

		// Token: 0x04000E03 RID: 3587
		public static UIController singleton;

		// Token: 0x04000E05 RID: 3589
		public Color selectedBtnColor;

		// Token: 0x04000E06 RID: 3590
		public Color unselectedBtnColor;

		// Token: 0x04000E07 RID: 3591
		public Color healthBarGreen;

		// Token: 0x04000E08 RID: 3592
		public Color healthBarRed;

		// Token: 0x04000E09 RID: 3593
		public MenuTabPair[] tabs;

		// Token: 0x04000E0A RID: 3594
		public TMP_Text GameName;

		// Token: 0x04000E0B RID: 3595
		private readonly DateTime timeWhenStarted;

		// Token: 0x04000E0C RID: 3596
		private RectTransform <Leaderboard>k__BackingField;

		// Token: 0x04000E0D RID: 3597
		private RectTransform <LeaderboardContent>k__BackingField;

		// Token: 0x04000E0E RID: 3598
		private RectTransform <UserTag>k__BackingField;

		// Token: 0x04000E0F RID: 3599
		private RectTransform <PauseMenu>k__BackingField;

		// Token: 0x04000E10 RID: 3600
		private RectTransform <ChatButton>k__BackingField;

		// Token: 0x04000E11 RID: 3601
		private RectTransform <InventoryButton>k__BackingField;

		// Token: 0x04000E12 RID: 3602
		private RectTransform <DebugConsole>k__BackingField;

		// Token: 0x04000E13 RID: 3603
		private Image <PauseMenuImg>k__BackingField;

		// Token: 0x04000E14 RID: 3604
		private RectTransform <PauseMenuChild>k__BackingField;

		// Token: 0x04000E15 RID: 3605
		private Canvas <Canvas>k__BackingField;

		// Token: 0x04000E16 RID: 3606
		private TMP_InputField <ChatBar>k__BackingField;

		// Token: 0x04000E17 RID: 3607
		private static bool <Paused>k__BackingField;

		// Token: 0x04000E18 RID: 3608
		private static bool <ConsoleOpen>k__BackingField;

		// Token: 0x04000E19 RID: 3609
		private Image <HealthbarCont>k__BackingField;

		// Token: 0x04000E1A RID: 3610
		private Image <Healthbar>k__BackingField;

		// Token: 0x04000E1B RID: 3611
		private Image <HealthbarHeart>k__BackingField;

		// Token: 0x04000E1C RID: 3612
		private TMP_Text <HealthbarHeartText>k__BackingField;

		// Token: 0x04000E1D RID: 3613
		private UIStaminaBar <StaminaBar>k__BackingField;

		// Token: 0x04000E1E RID: 3614
		private RectTransform leaderboardEntry;

		// Token: 0x04000E1F RID: 3615
		private RectTransform main;

		// Token: 0x04000E20 RID: 3616
		private RectTransform alwaysOnTop;

		// Token: 0x04000E21 RID: 3617
		private RectTransform logsParent;

		// Token: 0x04000E22 RID: 3618
		private RectTransform playerListMenu;

		// Token: 0x04000E23 RID: 3619
		private GameObject playerListMenuEntry;

		// Token: 0x04000E24 RID: 3620
		private GameObject debugLogMessageTemplate;

		// Token: 0x04000E25 RID: 3621
		private MenuButtonAnimation menuController;

		// Token: 0x04000E26 RID: 3622
		private TMP_Text overviewUsername;

		// Token: 0x04000E27 RID: 3623
		private TMP_Text timePlaying;

		// Token: 0x04000E28 RID: 3624
		private TMP_Text playerCount;

		// Token: 0x04000E29 RID: 3625
		private TMP_Text instanceCount;

		// Token: 0x04000E2A RID: 3626
		private TMP_Text debugLogs;

		// Token: 0x04000E2B RID: 3627
		private TMP_Text localText;

		// Token: 0x04000E2C RID: 3628
		private RectTransform pauseMenu;

		// Token: 0x04000E2D RID: 3629
		private RectTransform disconnectScreen;

		// Token: 0x04000E2E RID: 3630
		private CursorLockMode lockState;

		// Token: 0x04000E2F RID: 3631
		private string localUsername;

		// Token: 0x04000E30 RID: 3632
		private bool lbOpen;

		// Token: 0x04000E31 RID: 3633
		private bool PauseDebounce;

		// Token: 0x04000E32 RID: 3634
		private readonly Dictionary<string, Sprite> badgeIcons;

		// Token: 0x04000E33 RID: 3635
		private Dictionary<string, GameObject> LeaderboardUsers;

		// Token: 0x04000E34 RID: 3636
		private Dictionary<string, GameObject> PlayerListUsers;

		// Token: 0x04000E35 RID: 3637
		private bool ConsoleDebounce;

		// Token: 0x02000432 RID: 1074
		public enum HudButton
		{
			// Token: 0x04001205 RID: 4613
			Chat,
			// Token: 0x04001206 RID: 4614
			Inventory
		}

		// Token: 0x02000433 RID: 1075
		private sealed class <>c__DisplayClass120_0
		{
			// Token: 0x06002D20 RID: 11552 RVA: 0x0001DB7F File Offset: 0x0001BD7F
			internal void <AddLeaderboardUser>b__0()
			{
			}

			// Token: 0x06002D21 RID: 11553 RVA: 0x0001DB81 File Offset: 0x0001BD81
			internal void <AddLeaderboardUser>b__1()
			{
			}

			// Token: 0x06002D22 RID: 11554 RVA: 0x0001DB83 File Offset: 0x0001BD83
			internal void <AddLeaderboardUser>b__2()
			{
			}

			// Token: 0x04001207 RID: 4615
			public int userId;
		}

		// Token: 0x02000434 RID: 1076
		private sealed class <>c__DisplayClass121_0
		{
			// Token: 0x06002D24 RID: 11556 RVA: 0x0001DB8D File Offset: 0x0001BD8D
			internal void <LoadLeaderboardThumbnail>b__0()
			{
			}

			// Token: 0x06002D25 RID: 11557 RVA: 0x0001DB8F File Offset: 0x0001BD8F
			internal void <LoadLeaderboardThumbnail>b__1()
			{
			}

			// Token: 0x06002D26 RID: 11558 RVA: 0x0001DB91 File Offset: 0x0001BD91
			internal void <LoadLeaderboardThumbnail>b__2()
			{
			}

			// Token: 0x06002D27 RID: 11559 RVA: 0x0001DB93 File Offset: 0x0001BD93
			internal void <LoadLeaderboardThumbnail>b__3()
			{
			}

			// Token: 0x04001208 RID: 4616
			public Player player;
		}

		// Token: 0x02000435 RID: 1077
		private sealed class <LoadLeaderboardThumbnail>d__121 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D28 RID: 11560 RVA: 0x0001DB95 File Offset: 0x0001BD95
			public <LoadLeaderboardThumbnail>d__121(int <>1__state)
			{
			}

			// Token: 0x06002D29 RID: 11561 RVA: 0x0001DB9D File Offset: 0x0001BD9D
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D2A RID: 11562 RVA: 0x0001DB9F File Offset: 0x0001BD9F
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002D2B RID: 11563 RVA: 0x0001DBA2 File Offset: 0x0001BDA2
			private void <>m__Finally1()
			{
			}

			// Token: 0x06002D2C RID: 11564 RVA: 0x0001DBA4 File Offset: 0x0001BDA4
			private void <>m__Finally2()
			{
			}

			// Token: 0x17000D14 RID: 3348
			// (get) Token: 0x06002D2D RID: 11565 RVA: 0x0001DBA6 File Offset: 0x0001BDA6
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D2E RID: 11566 RVA: 0x0001DBA9 File Offset: 0x0001BDA9
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D15 RID: 3349
			// (get) Token: 0x06002D2F RID: 11567 RVA: 0x0001DBAB File Offset: 0x0001BDAB
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001209 RID: 4617
			private int <>1__state;

			// Token: 0x0400120A RID: 4618
			private object <>2__current;

			// Token: 0x0400120B RID: 4619
			public Player player;

			// Token: 0x0400120C RID: 4620
			private UIController.<>c__DisplayClass121_0 <>8__1;

			// Token: 0x0400120D RID: 4621
			public RectTransform _plEntry;

			// Token: 0x0400120E RID: 4622
			public RectTransform _lbEntry;

			// Token: 0x0400120F RID: 4623
			public UIController <>4__this;

			// Token: 0x04001210 RID: 4624
			private UnityWebRequest <uwr>5__2;

			// Token: 0x04001211 RID: 4625
			private string <token>5__3;

			// Token: 0x04001212 RID: 4626
			private Button <reportBtn>5__4;

			// Token: 0x04001213 RID: 4627
			private UnityWebRequest <twr>5__5;
		}

		// Token: 0x02000436 RID: 1078
		private sealed class <LoadThumbnail>d__134 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06002D30 RID: 11568 RVA: 0x0001DBAE File Offset: 0x0001BDAE
			public <LoadThumbnail>d__134(int <>1__state)
			{
			}

			// Token: 0x06002D31 RID: 11569 RVA: 0x0001DBB6 File Offset: 0x0001BDB6
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002D32 RID: 11570 RVA: 0x0001DBB8 File Offset: 0x0001BDB8
			bool IEnumerator.MoveNext()
			{
				return false;
			}

			// Token: 0x06002D33 RID: 11571 RVA: 0x0001DBBB File Offset: 0x0001BDBB
			private void <>m__Finally1()
			{
			}

			// Token: 0x06002D34 RID: 11572 RVA: 0x0001DBBD File Offset: 0x0001BDBD
			private void <>m__Finally2()
			{
			}

			// Token: 0x06002D35 RID: 11573 RVA: 0x0001DBBF File Offset: 0x0001BDBF
			private void <>m__Finally3()
			{
			}

			// Token: 0x17000D16 RID: 3350
			// (get) Token: 0x06002D36 RID: 11574 RVA: 0x0001DBC1 File Offset: 0x0001BDC1
			object IEnumerator<object>.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x06002D37 RID: 11575 RVA: 0x0001DBC4 File Offset: 0x0001BDC4
			void IEnumerator.Reset()
			{
			}

			// Token: 0x17000D17 RID: 3351
			// (get) Token: 0x06002D38 RID: 11576 RVA: 0x0001DBC6 File Offset: 0x0001BDC6
			object IEnumerator.Current
			{
				get
				{
					return null;
				}
			}

			// Token: 0x04001214 RID: 4628
			private int <>1__state;

			// Token: 0x04001215 RID: 4629
			private object <>2__current;

			// Token: 0x04001216 RID: 4630
			public int userId;

			// Token: 0x04001217 RID: 4631
			public UIController <>4__this;

			// Token: 0x04001218 RID: 4632
			private UnityWebRequest <uwr>5__2;

			// Token: 0x04001219 RID: 4633
			private string <token>5__3;

			// Token: 0x0400121A RID: 4634
			private JSONNode <user>5__4;

			// Token: 0x0400121B RID: 4635
			private UnityWebRequest <twr>5__5;
		}
	}
}
