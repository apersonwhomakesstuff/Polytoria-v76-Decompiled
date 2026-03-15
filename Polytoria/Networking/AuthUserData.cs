namespace Polytoria.Networking;

public struct AuthUserData
{
	[CompilerGenerated]
	private int <ID>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private string <Username>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <Token>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <CanChat>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsAgeRestricted>k__BackingField; //Field offset: 0x19

	public bool CanChat
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int ID
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 3
		[CompilerGenerated]
		 set { } //Length: 3
	}

	public bool IsAgeRestricted
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string Token
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public string Username
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public AuthUserData(int id, string username, string token, bool canChat, bool isAgeRestricted) { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_CanChat() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_ID() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_IsAgeRestricted() { }

	[CompilerGenerated]
	[IsReadOnly]
	public string get_Token() { }

	[CompilerGenerated]
	[IsReadOnly]
	public string get_Username() { }

	[CompilerGenerated]
	public void set_CanChat(bool value) { }

	[CompilerGenerated]
	public void set_ID(int value) { }

	[CompilerGenerated]
	public void set_IsAgeRestricted(bool value) { }

	[CompilerGenerated]
	public void set_Token(string value) { }

	[CompilerGenerated]
	public void set_Username(string value) { }

}

