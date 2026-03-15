namespace Polytoria.Controllers;

public class UIController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass120_0
	{
		public int userId; //Field offset: 0x10

		public <>c__DisplayClass120_0() { }

		internal void <AddLeaderboardUser>b__0() { }

		internal void <AddLeaderboardUser>b__1() { }

		internal void <AddLeaderboardUser>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass121_0
	{
		public Player player; //Field offset: 0x10

		public <>c__DisplayClass121_0() { }

		internal void <LoadLeaderboardThumbnail>b__0() { }

		internal void <LoadLeaderboardThumbnail>b__1() { }

		internal void <LoadLeaderboardThumbnail>b__2() { }

		internal void <LoadLeaderboardThumbnail>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <LoadLeaderboardThumbnail>d__121 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Player player; //Field offset: 0x20
		private <>c__DisplayClass121_0 <>8__1; //Field offset: 0x28
		public RectTransform _plEntry; //Field offset: 0x30
		public RectTransform _lbEntry; //Field offset: 0x38
		public UIController <>4__this; //Field offset: 0x40
		private UnityWebRequest <uwr>5__2; //Field offset: 0x48
		private string <token>5__3; //Field offset: 0x50
		private Button <reportBtn>5__4; //Field offset: 0x58
		private UnityWebRequest <twr>5__5; //Field offset: 0x60

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LoadLeaderboardThumbnail>d__121(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <LoadThumbnail>d__134 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public int userId; //Field offset: 0x20
		public UIController <>4__this; //Field offset: 0x28
		private UnityWebRequest <uwr>5__2; //Field offset: 0x30
		private string <token>5__3; //Field offset: 0x38
		private JSONNode <user>5__4; //Field offset: 0x40
		private UnityWebRequest <twr>5__5; //Field offset: 0x48

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LoadThumbnail>d__134(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal enum HudButton : int
	{
		Chat = 0,
		Inventory = 1,
	}

	public static int maxDebugLogLength; //Field offset: 0x0
	public static UIController singleton; //Field offset: 0x8
	[CompilerGenerated]
	private static bool <Paused>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private static bool <ConsoleOpen>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private Action Resetted; //Field offset: 0x20
	public Color selectedBtnColor; //Field offset: 0x28
	public Color unselectedBtnColor; //Field offset: 0x38
	public Color healthBarGreen; //Field offset: 0x48
	public Color healthBarRed; //Field offset: 0x58
	public MenuTabPair[] tabs; //Field offset: 0x68
	public TMP_Text GameName; //Field offset: 0x70
	private readonly DateTime timeWhenStarted; //Field offset: 0x78
	[CompilerGenerated]
	private RectTransform <Leaderboard>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private RectTransform <LeaderboardContent>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private RectTransform <UserTag>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private RectTransform <PauseMenu>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private RectTransform <ChatButton>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private RectTransform <InventoryButton>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private RectTransform <DebugConsole>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private Image <PauseMenuImg>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private RectTransform <PauseMenuChild>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private Canvas <Canvas>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private TMP_InputField <ChatBar>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private Image <HealthbarCont>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private Image <Healthbar>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private Image <HealthbarHeart>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private TMP_Text <HealthbarHeartText>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private UIStaminaBar <StaminaBar>k__BackingField; //Field offset: 0xF8
	private RectTransform leaderboardEntry; //Field offset: 0x100
	private RectTransform main; //Field offset: 0x108
	private RectTransform alwaysOnTop; //Field offset: 0x110
	private RectTransform logsParent; //Field offset: 0x118
	private RectTransform playerListMenu; //Field offset: 0x120
	private GameObject playerListMenuEntry; //Field offset: 0x128
	private GameObject debugLogMessageTemplate; //Field offset: 0x130
	private MenuButtonAnimation menuController; //Field offset: 0x138
	private TMP_Text overviewUsername; //Field offset: 0x140
	private TMP_Text timePlaying; //Field offset: 0x148
	private TMP_Text playerCount; //Field offset: 0x150
	private TMP_Text instanceCount; //Field offset: 0x158
	private TMP_Text debugLogs; //Field offset: 0x160
	[SerializeField]
	private TMP_Text localText; //Field offset: 0x168
	[SerializeField]
	private RectTransform pauseMenu; //Field offset: 0x170
	[SerializeField]
	private RectTransform disconnectScreen; //Field offset: 0x178
	private CursorLockMode lockState; //Field offset: 0x180
	private string localUsername; //Field offset: 0x188
	private bool lbOpen; //Field offset: 0x190
	private bool PauseDebounce; //Field offset: 0x191
	private readonly Dictionary<String, Sprite> badgeIcons; //Field offset: 0x198
	private Dictionary<String, GameObject> LeaderboardUsers; //Field offset: 0x1A0
	private Dictionary<String, GameObject> PlayerListUsers; //Field offset: 0x1A8
	private bool ConsoleDebounce; //Field offset: 0x1B0

	public event Action Resetted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public private Canvas Canvas
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private TMP_InputField ChatBar
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private RectTransform ChatButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private static bool ConsoleOpen
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 84
	}

	public private RectTransform DebugConsole
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private Image Healthbar
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private Image HealthbarCont
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private Image HealthbarHeart
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private TMP_Text HealthbarHeartText
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private RectTransform InventoryButton
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private RectTransform Leaderboard
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private RectTransform LeaderboardContent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private static bool Paused
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 84
	}

	public private RectTransform PauseMenu
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private RectTransform PauseMenuChild
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private Image PauseMenuImg
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private UIStaminaBar StaminaBar
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 527
	}

	public private RectTransform UserTag
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	private static UIController() { }

	public UIController() { }

	[CompilerGenerated]
	private void <SetConsoleOpen>b__133_0() { }

	[CompilerGenerated]
	private void <SetConsoleOpen>b__133_1() { }

	[CompilerGenerated]
	private void <SetPaused>b__116_1() { }

	[CompilerGenerated]
	private void <SetPaused>b__116_2() { }

	[CompilerGenerated]
	private void <SetPaused>g__pauseUpdateDelegate|116_0(float val) { }

	[CompilerGenerated]
	public void add_Resetted(Action value) { }

	public void AddLeaderboardUser(Player player) { }

	private void Awake() { }

	public void DebugLog(string message, bool error) { }

	public void ExitGame() { }

	private Texture2D FlipTexture(Texture2D original) { }

	[CompilerGenerated]
	public Canvas get_Canvas() { }

	[CompilerGenerated]
	public TMP_InputField get_ChatBar() { }

	[CompilerGenerated]
	public RectTransform get_ChatButton() { }

	[CompilerGenerated]
	public static bool get_ConsoleOpen() { }

	[CompilerGenerated]
	public RectTransform get_DebugConsole() { }

	[CompilerGenerated]
	public Image get_Healthbar() { }

	[CompilerGenerated]
	public Image get_HealthbarCont() { }

	[CompilerGenerated]
	public Image get_HealthbarHeart() { }

	[CompilerGenerated]
	public TMP_Text get_HealthbarHeartText() { }

	[CompilerGenerated]
	public RectTransform get_InventoryButton() { }

	[CompilerGenerated]
	public RectTransform get_Leaderboard() { }

	[CompilerGenerated]
	public RectTransform get_LeaderboardContent() { }

	[CompilerGenerated]
	public static bool get_Paused() { }

	[CompilerGenerated]
	public RectTransform get_PauseMenu() { }

	[CompilerGenerated]
	public RectTransform get_PauseMenuChild() { }

	[CompilerGenerated]
	public Image get_PauseMenuImg() { }

	[CompilerGenerated]
	public UIStaminaBar get_StaminaBar() { }

	[CompilerGenerated]
	public RectTransform get_UserTag() { }

	public Sprite GetLeaderboardBadgeIcon(string badgeName) { }

	[IteratorStateMachine(typeof(<LoadLeaderboardThumbnail>d__121))]
	private IEnumerator LoadLeaderboardThumbnail(RectTransform _lbEntry, RectTransform _plEntry, Player player) { }

	[IteratorStateMachine(typeof(<LoadThumbnail>d__134))]
	private IEnumerator LoadThumbnail(int userId) { }

	public void OpenConsoleFromPauseMenu() { }

	public void ReceiveChat(string username, string message, Color usernameColor) { }

	[CompilerGenerated]
	public void remove_Resetted(Action value) { }

	public void RemoveLeaderboardUser(string username) { }

	public void ResetCharacter() { }

	[CompilerGenerated]
	private void set_Canvas(Canvas value) { }

	[CompilerGenerated]
	private void set_ChatBar(TMP_InputField value) { }

	[CompilerGenerated]
	private void set_ChatButton(RectTransform value) { }

	[CompilerGenerated]
	private static void set_ConsoleOpen(bool value) { }

	[CompilerGenerated]
	private void set_DebugConsole(RectTransform value) { }

	[CompilerGenerated]
	private void set_Healthbar(Image value) { }

	[CompilerGenerated]
	private void set_HealthbarCont(Image value) { }

	[CompilerGenerated]
	private void set_HealthbarHeart(Image value) { }

	[CompilerGenerated]
	private void set_HealthbarHeartText(TMP_Text value) { }

	[CompilerGenerated]
	private void set_InventoryButton(RectTransform value) { }

	[CompilerGenerated]
	private void set_Leaderboard(RectTransform value) { }

	[CompilerGenerated]
	private void set_LeaderboardContent(RectTransform value) { }

	[CompilerGenerated]
	private static void set_Paused(bool value) { }

	[CompilerGenerated]
	private void set_PauseMenu(RectTransform value) { }

	[CompilerGenerated]
	private void set_PauseMenuChild(RectTransform value) { }

	[CompilerGenerated]
	private void set_PauseMenuImg(Image value) { }

	[CompilerGenerated]
	private void set_StaminaBar(UIStaminaBar value) { }

	[CompilerGenerated]
	private void set_UserTag(RectTransform value) { }

	public void SetActiveMenuTab(int index) { }

	public void SetButtonFocused(HudButton type, bool focused) { }

	public void SetConsoleOpen(bool open) { }

	public void SetGameInfo(string gameName) { }

	public void SetHealthFilled(float fill) { }

	public void SetPaused(bool paused) { }

	public void SetStaminaFilled(float fill, bool exhausted) { }

	public void SetUserCard(int userId, string username) { }

	public void ShowDisconnectMessage(string reason) { }

	public void ToggleConsole() { }

	private void ToggleLeaderboard() { }

	public void TogglePaused() { }

	private void Update() { }

	private void UpdateInstanceCount() { }

	private void UpdatePlayerCount() { }

	private void UpdateTimer() { }

}

