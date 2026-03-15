namespace RLD;

public class YesNoAnswer
{
	private bool _hasYes; //Field offset: 0x10
	private bool _hasNo; //Field offset: 0x11

	public bool HasNo
	{
		 get { } //Length: 5
	}

	public bool HasOnlyYes
	{
		 get { } //Length: 661
	}

	public bool HasYes
	{
		 get { } //Length: 5
	}

	public YesNoAnswer() { }

	public bool get_HasNo() { }

	public bool get_HasOnlyYes() { }

	public bool get_HasYes() { }

	public void No() { }

	public void Yes() { }

}

