namespace Polytoria.Datamodel;

public class PlayerChatEvent
{
	[CompilerGenerated]
	private Player <Player>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Message>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <Canceled>k__BackingField; //Field offset: 0x20

	public bool Canceled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private string Message
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private Player Player
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public PlayerChatEvent(Player player, string message) { }

	[CompilerGenerated]
	public bool get_Canceled() { }

	[CompilerGenerated]
	public string get_Message() { }

	[CompilerGenerated]
	public Player get_Player() { }

	[CompilerGenerated]
	public void set_Canceled(bool value) { }

	[CompilerGenerated]
	private void set_Message(string value) { }

	[CompilerGenerated]
	private void set_Player(Player value) { }

}

