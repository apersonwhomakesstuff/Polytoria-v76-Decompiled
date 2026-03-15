namespace Polytoria.Datamodel.Services;

public class CoreUIService : MonoBehaviour
{
	[CompilerGenerated]
	private static CoreUIService <Instance>k__BackingField; //Field offset: 0x0
	[SerializeField]
	private GameObject userCard; //Field offset: 0x20
	[SerializeField]
	private GameObject chat; //Field offset: 0x28
	[SerializeField]
	private GameObject healthBar; //Field offset: 0x30
	[SerializeField]
	private GameObject leaderboard; //Field offset: 0x38
	[SerializeField]
	private GameObject hotbar; //Field offset: 0x40
	[SerializeField]
	private GameObject menuButton; //Field offset: 0x48
	[SerializeField]
	private GameObject chatButton; //Field offset: 0x50
	[SerializeField]
	private Button resetButton; //Field offset: 0x58

	public bool CanRespawn
	{
		 get { } //Length: 30
		 set { } //Length: 30
	}

	public bool ChatEnabled
	{
		 get { } //Length: 29
		 set { } //Length: 68
	}

	public bool HealthBarEnabled
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public bool HotbarEnabled
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public private static CoreUIService Instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 81
	}

	public bool LeaderboardEnabled
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public bool MenuButtonEnabled
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public bool UserCardEnabled
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public CoreUIService() { }

	private void Awake() { }

	public bool get_CanRespawn() { }

	public bool get_ChatEnabled() { }

	public bool get_HealthBarEnabled() { }

	public bool get_HotbarEnabled() { }

	[CompilerGenerated]
	public static CoreUIService get_Instance() { }

	public bool get_LeaderboardEnabled() { }

	public bool get_MenuButtonEnabled() { }

	public bool get_UserCardEnabled() { }

	public void set_CanRespawn(bool value) { }

	public void set_ChatEnabled(bool value) { }

	public void set_HealthBarEnabled(bool value) { }

	public void set_HotbarEnabled(bool value) { }

	[CompilerGenerated]
	private static void set_Instance(CoreUIService value) { }

	public void set_LeaderboardEnabled(bool value) { }

	public void set_MenuButtonEnabled(bool value) { }

	public void set_UserCardEnabled(bool value) { }

}

